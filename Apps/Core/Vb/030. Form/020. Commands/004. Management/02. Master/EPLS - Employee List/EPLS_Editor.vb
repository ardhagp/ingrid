Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private _SQL As New Commands.EPLS.Editor
    Private _SQL_User As New cmduac.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

#End Region
    Private WithEvents F_AddinPosition As New EPLS_Position
    Private _HavePhoto As Integer
    Private _ChangePhoto As Boolean
    Private _PositionID As String
    Private _Photo As System.Drawing.Image

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _HavePhoto = 0
        _ChangePhoto = False
        If (varFormProperties.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = Commands.EPLS.Editor.GetEmployeeFullName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            CboGender.SelectedItem = Commands.EPLS.Editor.GetGender(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPersonalID.Text = Commands.EPLS.Editor.GetPersonalID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            DtpBirthDate.Value = CDate(Commands.EPLS.Editor.GetBirthDate(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)))
            TxtBirthPlace.Text = Commands.EPLS.Editor.GetBirthPlace(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtAddress.Text = Commands.EPLS.Editor.GetAddress(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))

            'Work In...
            TxtCompany.Text = Commands.EPLS.Editor.GetCompany(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxTDepartment.Text = Commands.EPLS.Editor.GetDepartment(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            _PositionID = Commands.EPLS.Editor.GETPositionID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPosition.Text = Commands.EPLS.Editor.GETPosition(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtGradeID.Text = Commands.EPLS.Editor.GetGradeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtGrade.Text = Commands.EPLS.Editor.GetGrade(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtEmployeeNumber.Text = Commands.EPLS.Editor.GETEmployeeNumber(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtEmployeeNickname.Text = Commands.EPLS.Editor.GetEmployeeNickname(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtContractTypeID.Text = Commands.EPLS.Editor.GetContractTypeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtContractType.Text = Commands.EPLS.Editor.GetContractType(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkActiveEmployee.Checked = Commands.EPLS.Editor.GetActiveEmployee(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            _HavePhoto = Commands.EPLS.Editor.GetIsHavePhoto(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))

            'Permissions
            TxtLogin.Text = cmduac.Editor.GetUsernameByEmployeeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            varFormProperties.Field01 = cmduac.Editor.GetUIDbyEmployeeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            cmduac.Editor.DisplayData(varDatabaseName, varDatabaseEngine, DgnModulesRoles, varFormProperties.Field01.ToString)

            TxtPersonalID.Focus()

            If _HavePhoto > 0 Then
                pctbxPhoto.Image = _SQL.GetPhoto(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            End If
        End If

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        F_AddinPosition = New EPLS_Position
        DISPLAY(F_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Position", "Browse for position data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Sub CheckAllInputs()
        'TxtPersonalID.Focus()
        TxtEmployeeNumber.Focus()
        TxtFullName.Focus()
        TxtEmployeeNickname.Focus()
        ChkActiveEmployee.Focus()
        BtnSave.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInputs()

        If (Commands.EPLS.Editor.IsPersonalIDExist(varDatabaseName, varDatabaseEngine, varFormProperties.IsNew, TxtPersonalID.Text, Convert.ToString(varFormProperties.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (_PositionID = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (Commands.EPLS.Editor.IsPositionExist(varDatabaseName, varDatabaseEngine, _PositionID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (varFormProperties.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, _PositionID, TxtEmployeeNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormProperties.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, _PositionID, TxtEmployeeNumber.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf _HavePhoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.EPLS.Editor.PushData(varDatabaseName, varDatabaseEngine, TxtPersonalID.XOSQLText, _PositionID, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, _Photo, _ChangePhoto, varProperties.EmployeeID, Convert.ToString(varFormProperties.RowID))) Then
            FRMmainframe6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            FRMmainframe6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtCompany.Clear()
            TxTDepartment.Clear()
            _PositionID = String.Empty
            TxtPosition.Clear()
            TxtGradeID.Clear()
            TxtGrade.Clear()
            TxtEmployeeNumber.Clear()
            TxtFullName.Clear()
            TxtEmployeeNickname.Clear()
            TxtContractTypeID.Clear()
            TxtContractType.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub F_AddinPosition_RecordSelected() Handles F_AddinPosition.RecordSelected
        With varFormProperties
            TxtCompany.Text = .Field01.ToString
            TxTDepartment.Text = .Field02.ToString
            _PositionID = .Field03.ToString
            TxtPosition.Text = .Field04.ToString
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        OfdPhoto.Title = "Ingrid Photo Picker"
        OfdPhoto.FileName = ""
        OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdPhoto.ShowDialog = DialogResult.OK Then
            If (OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, varMaxUploadSizePhoto, True)) Then
                _Photo = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                pctbxPhoto.Image = _Photo
                _ChangePhoto = True
                _HavePhoto = 1
            End If
        Else
            _HavePhoto = 1
            Return
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
