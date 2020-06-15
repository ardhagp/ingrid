Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private _SQL As New LibSQL.Commands.EPLS.Editor
    Private _SQL_User As New LibSQL.Commands.UAC.Editor
    Public Event RecordSaved()
    Private WithEvents _AddinPosition As New EPLS_Position
    Private _HavePhoto As Integer
    Private _ChangePhoto As Boolean
    Private _Photo As System.Drawing.Image
#End Region

#Region "Subs Collections"

#End Region

    Private Sub EPLS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _HavePhoto = 0
        _ChangePhoto = False
        If _FORMAttrib.IsNew = True Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = _SQL.GETEmployeeFullName(_FORMAttrib.RowID)
            CboGender.SelectedItem = _SQL.GETGender(_FORMAttrib.RowID)
            TxtPersonalID.Text = _SQL.GETPersonalID(_FORMAttrib.RowID)
            DtpBirthDate.Value = CDate(_SQL.GETBirthDate(_FORMAttrib.RowID))
            TxtBirthPlace.Text = _SQL.GETBirthPlace(_FORMAttrib.RowID)
            TxtAddress.Text = _SQL.GETAddress(_FORMAttrib.RowID)

            'Work In...
            TxtCompany.Text = _SQL.GETCompany(_FORMAttrib.RowID)
            TxtDepartement.Text = _SQL.GETDepartement(_FORMAttrib.RowID)
            TxtPositionID.Text = _SQL.GETPositionID(_FORMAttrib.RowID)
            TxtPosition.Text = _SQL.GETPosition(_FORMAttrib.RowID)
            TxtGradeID.Text = _SQL.GETGradeID(_FORMAttrib.RowID)
            TxtGrade.Text = _SQL.GETGrade(_FORMAttrib.RowID)
            TxtEmployeeNumber.Text = _SQL.GETEmployeeNumber(_FORMAttrib.RowID)
            TxtEmployeeNickname.Text = _SQL.GETEmployeeNickname(_FORMAttrib.RowID)
            TxtContractTypeID.Text = _SQL.GETContractTypeID(_FORMAttrib.RowID)
            TxtContractType.Text = _SQL.GETContractType(_FORMAttrib.RowID)
            ChkActiveEmployee.Checked = _SQL.GETActiveEmployee(_FORMAttrib.RowID)
            _HavePhoto = _SQL.GETIsHavePhoto(_FORMAttrib.RowID)

            'Permissions
            TxtLogin.Text = _SQL_User.GETUsernameByEmployeeID(_FORMAttrib.RowID)
            _FORMAttrib.Field01 = _SQL_User.GETUIDByEmployeeID(_FORMAttrib.RowID)
            _SQL_User.DisplayData(DgnModulesRoles, _FORMAttrib.Field01)

            TxtPersonalID.Focus()

            If _HavePhoto > 0 Then
                pctbxPhoto.Image = _SQL.GETPhoto(_FORMAttrib.RowID)
            End If
        End If

    End Sub

    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        _AddinPosition = New EPLS_Position
        Display(_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_001_512_icon, "Find Position", "Browse for position data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Sub CheckAllInputs()
        'TxtPersonalID.Focus()
        TxtPositionID.Focus()
        TxtEmployeeNumber.Focus()
        TxtFullName.Focus()
        TxtEmployeeNickname.Focus()
        ChkActiveEmployee.Focus()
        BtnSave.Focus()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInputs()

        If (_SQL.IsPersonalIDExist(_FORMAttrib.IsNew, TxtPersonalID.Text, _FORMAttrib.RowID) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (TxtPersonalID.SLFSQLText = String.Empty) Or (TxtPositionID.SLFSQLText = String.Empty) Or (TxtEmployeeNumber.SLFSQLText = String.Empty) Or (TxtFullName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_SQL.IsPositionExist(TxtPositionID.SLFSQLText) = False) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = True) And (_SQL.IsDuplicate(TxtPositionID.SLFSQLText, TxtEmployeeNumber.SLFSQLText) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = False) And (_SQL.IsDuplicate(TxtPositionID.SLFSQLText, TxtEmployeeNumber.SLFSQLText, _FORMAttrib.RowID) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf _HavePhoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _SQL.PUSHData(TxtPersonalID.SLFSQLText, TxtPositionID.SLFSQLText, TxtEmployeeNumber.SLFSQLText, TxtFullName.SLFSQLText, DtpBirthDate, TxtBirthPlace.SLFSQLText, TxtAddress.SLFSQLText, TxtEmployeeNickname.SLFSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem, _Photo, _ChangePhoto, _USERAttrib.EID, _FORMAttrib.RowID) = True Then
            mainframe.ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        If ChkAddNew.Checked = True Then
            TxtCompany.Clear()
            TxtDepartement.Clear()
            TxtPositionID.Clear()
            TxtPosition.Clear()
            TxtGradeID.Clear()
            TxtGrade.Clear()
            TxtEmployeeNumber.Clear()
            TxtFullName.Clear()
            TxtEmployeeNickname.Clear()
            TxtContractTypeID.Clear()
            TxtContractType.Clear()
            TxtPositionID.Focus()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TxtPositionID_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SLFStatus.Items(0).Text = ""

            If _SQL.IsPositionExist(TxtPositionID.SLFSQLText) = False Then
                SLFStatus.Items(0).Text = "Position not found"
                TxtCompany.Clear()
                TxtDepartement.Clear()
                TxtPosition.Clear()
            Else
                TxtCompany.Text = _SQL.GETCompany(-1, TxtPositionID.SLFSQLText)
                TxtDepartement.Text = _SQL.GETDepartement(-1, TxtPositionID.SLFSQLText)
                TxtPosition.Text = _SQL.GETPosition(-1, TxtPositionID.SLFSQLText)
            End If
        End If
    End Sub

    Private Sub TxtPositionID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub _AddinPosition_RecordSelected() Handles _AddinPosition.RecordSelected
        TxtCompany.Text = _FORMAttrib.Field01
        TxtDepartement.Text = _FORMAttrib.Field02
        TxtPositionID.Text = _FORMAttrib.Field03
        TxtPosition.Text = _FORMAttrib.Field04
    End Sub

    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        OfdPhoto.Title = "Ingrid Photo Picker"
        OfdPhoto.FileName = ""
        OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdPhoto.ShowDialog = DialogResult.OK Then
            If OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, _MAXUPLOADSIZE_PHOTO, True) = True Then
                _Photo = _IMG_COMPRESS.OutputAsImage(OfdPhoto.FileName)
                pctbxPhoto.Image = _Photo
                _ChangePhoto = True
                _HavePhoto = 1
            End If
        Else
            _HavePhoto = 1
            Exit Sub
        End If

    End Sub

    Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
        If _HavePhoto = 0 Then
            If CboGender.Text = "MALE" Then
                pctbxPhoto.Image = My.Resources.MALE_001_512_icon
            Else
                pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
            End If
        End If
    End Sub

End Class
