Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private _SQL As New Commands.EPLS.Editor
    Private _SQL_User As New Commands.UAC.Editor
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
        If (varFormAttributes.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = Commands.EPLS.Editor.GetEmployeeFullName(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            CboGender.SelectedItem = Commands.EPLS.Editor.GetGender(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtPersonalID.Text = Commands.EPLS.Editor.GetPersonalID(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            DtpBirthDate.Value = CDate(Commands.EPLS.Editor.GetBirthDate(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID))
            TxtBirthPlace.Text = Commands.EPLS.Editor.GetBirthPlace(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtAddress.Text = Commands.EPLS.Editor.GetAddress(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)

            'Work In...
            TxtCompany.Text = Commands.EPLS.Editor.GetCompany(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxTDepartment.Text = Commands.EPLS.Editor.GetDepartment(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            _PositionID = Commands.EPLS.Editor.GETPositionID(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtPosition.Text = Commands.EPLS.Editor.GETPosition(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtGradeID.Text = Commands.EPLS.Editor.GetGradeID(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtGrade.Text = Commands.EPLS.Editor.GetGrade(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtEmployeeNumber.Text = Commands.EPLS.Editor.GETEmployeeNumber(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtEmployeeNickname.Text = Commands.EPLS.Editor.GetEmployeeNickname(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtContractTypeID.Text = Commands.EPLS.Editor.GetContractTypeID(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            TxtContractType.Text = Commands.EPLS.Editor.GetContractType(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            ChkActiveEmployee.Checked = Commands.EPLS.Editor.GetActiveEmployee(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            _HavePhoto = Commands.EPLS.Editor.GetIsHavePhoto(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)

            'Permissions
            TxtLogin.Text = Commands.UAC.Editor.GetUsernameByEmployeeID(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            varFormAttributes.Field01 = Commands.UAC.Editor.GetUIDbyEmployeeID(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
            Commands.UAC.Editor.DisplayData(varDatabaseName, varDatabaseEngine, DgnModulesRoles, varFormAttributes.Field01.ToString)

            TxtPersonalID.Focus()

            If _HavePhoto > 0 Then
                pctbxPhoto.Image = _SQL.GetPhoto(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)
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

        If (Commands.EPLS.Editor.IsPersonalIDExist(varDatabaseName, varDatabaseEngine, varFormAttributes.IsNew, TxtPersonalID.Text, varFormAttributes.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (_PositionID = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (Commands.EPLS.Editor.IsPositionExist(varDatabaseName, varDatabaseEngine, _PositionID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (varFormAttributes.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, _PositionID, TxtEmployeeNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormAttributes.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, _PositionID, TxtEmployeeNumber.XOSQLText, varFormAttributes.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf _HavePhoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.EPLS.Editor.PushData(varDatabaseName, varDatabaseEngine, TxtPersonalID.XOSQLText, _PositionID, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, _Photo, _ChangePhoto, varUserAttributes.EID, varFormAttributes.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
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
        With varFormAttributes
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
