Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMeplsEditor
#Region "Variables"
    'Private _SQL_User As New CMDuac.Editor
    Public Event EventRecordSaved()

    Const varMessageCannotSave As String = "Cannot save your record."
    Const varMessageAlert As String = "Alert"
#End Region

#Region "Subs Collections"

#End Region
    Private WithEvents Frm_epls_AddinPosition As New FRMeplsPosition
    Private varHavePhoto As Integer
    Private varChangePhoto As Boolean
    Private varPositionID As String
    Private varPhoto As System.Drawing.Image

    <SupportedOSPlatform("windows")>
    Private Sub FRMeplsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varHavePhoto = 0
        varChangePhoto = False
        If (varFormProperties.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = CMDepls.Editor.GetEmployeeFullName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            CboGender.SelectedItem = CMDepls.Editor.GetGender(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPersonalID.Text = CMDepls.Editor.GetPersonalID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            DtpBirthDate.Value = CDate(CMDepls.Editor.GetBirthDate(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)))
            TxtBirthPlace.Text = CMDepls.Editor.GetBirthPlace(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtAddress.Text = CMDepls.Editor.GetAddress(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))

            'Work In...
            TxtCompany.Text = CMDepls.Editor.GetCompany(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxTDepartment.Text = CMDepls.Editor.GetDepartment(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            varPositionID = CMDepls.Editor.GETPositionID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPosition.Text = CMDepls.Editor.GETPosition(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtGradeID.Text = CMDepls.Editor.GetGradeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtGrade.Text = CMDepls.Editor.GetGrade(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtEmployeeNumber.Text = CMDepls.Editor.GETEmployeeNumber(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtEmployeeNickname.Text = CMDepls.Editor.GetEmployeeNickname(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtContractTypeID.Text = CMDepls.Editor.GetContractTypeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtContractType.Text = CMDepls.Editor.GetContractType(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkActiveEmployee.Checked = CMDepls.Editor.GetActiveEmployee(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            varHavePhoto = CMDepls.Editor.GetIsHavePhoto(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))

            'Permissions
            TxtLogin.Text = CMDuac.Editor.GetUsernameByEmployeeID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            varFormProperties.Field01 = CMDuac.Editor.GetUIDbyEmployeeID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            CMDuac.Editor.DisplayData(varDatabaseName, varDatabaseEngineE, DgnModulesRoles, varFormProperties.Field01.ToString)

            TxtPersonalID.Focus()

            If varHavePhoto > 0 Then
                pctbxPhoto.Image = CMDepls.Editor.GetPhoto(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            End If
        End If

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        Frm_epls_AddinPosition = New FRMeplsPosition
        Display(Frm_epls_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Position", "Browse for position data", True)
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

        If (CMDepls.Editor.IsPersonalIDExist(varDatabaseName, varDatabaseEngine, varFormProperties.IsNew, TxtPersonalID.Text, Convert.ToString(varFormProperties.RowID))) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Duplicate Personal ID", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (varPositionID = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (CMDepls.Editor.IsPositionExist(varDatabaseName, varDatabaseEngine, varPositionID)) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Position not found.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (varFormProperties.IsNew) AndAlso (CMDepls.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, varPositionID, TxtEmployeeNumber.XOSQLText)) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "This Employee Number already used.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormProperties.IsNew) AndAlso (CMDepls.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, varPositionID, TxtEmployeeNumber.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "This Employee Number already used by another employee.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf varHavePhoto = 0 Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Please pick employee photo.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (CMDepls.Editor.PushData(varDatabaseName, varDatabaseEngine, TxtPersonalID.XOSQLText, varPositionID, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, varPhoto, varChangePhoto, varProperties.EmployeeID, Convert.ToString(varFormProperties.RowID))) Then
            FRMmainframe6.Ts_status.Text = "Success"
            RaiseEvent EventRecordSaved()
        Else
            FRMmainframe6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtCompany.Clear()
            TxTDepartment.Clear()
            varPositionID = String.Empty
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

    Private Sub FRMeplsAddinPosition_RecordSelected() Handles Frm_epls_AddinPosition.EventRecordSelected
        With varFormProperties
            TxtCompany.Text = .Field01.ToString
            TxTDepartment.Text = .Field02.ToString
            varPositionID = .Field03.ToString
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
                varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                pctbxPhoto.Image = varPhoto
                varChangePhoto = True
                varHavePhoto = 1
            End If
        Else
            varHavePhoto = 1
            Return
        End If

    End Sub

    Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
        If varHavePhoto = 0 Then
            If CboGender.Text = "MALE" Then
                pctbxPhoto.Image = My.Resources.MALE_001_512_icon
            Else
                pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
            End If
        End If
    End Sub

End Class
