Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMeplsEditor
#Region "Declaration"
        'Private _SQL_User As New CMDuac.Editor
        Public Event EventRecordSaved()

        Const varMessageCannotSave As String = "Cannot save your record."
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
            If (varDataProperties.EmployeeIsNew) Then
                ChkAddNew.Visible = True
                ChkAddNew.Enabled = True
                CboGender.SelectedIndex = 0
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False

                'Personal Detail
                TxtFullName.Text = CMDepls.Editor.GetEmployeeFullName(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                CboGender.SelectedItem = CMDepls.Editor.GetGender(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtPersonalID.Text = CMDepls.Editor.GetPersonalID(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                DtpBirthDate.Value = CDate(CMDepls.Editor.GetBirthDate(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId)))
                TxtBirthPlace.Text = CMDepls.Editor.GetBirthPlace(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtAddress.Text = CMDepls.Editor.GetAddress(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))

                'Work In...
                TxtCompany.Text = CMDepls.Editor.GetCompany(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxTDepartment.Text = CMDepls.Editor.GetDepartment(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                varPositionID = CMDepls.Editor.GETPositionID(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtPosition.Text = CMDepls.Editor.GETPosition(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtGradeID.Text = CMDepls.Editor.GetGradeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtGrade.Text = CMDepls.Editor.GetGrade(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtEmployeeNumber.Text = CMDepls.Editor.GETEmployeeNumber(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtEmployeeNickname.Text = CMDepls.Editor.GetEmployeeNickname(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtContractTypeID.Text = CMDepls.Editor.GetContractTypeID(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                TxtContractType.Text = CMDepls.Editor.GetContractType(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                ChkActiveEmployee.Checked = CMDepls.Editor.GetActiveEmployee(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                varHavePhoto = CMDepls.Editor.GetIsHavePhoto(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))

                'Permissions
                TxtLogin.Text = CMDuac.Editor.GetUsernameByEmployeeID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varDataProperties.EmployeeId))
                varDataProperties.Field01 = CMDuac.Editor.GetUIDbyEmployeeID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varDataProperties.EmployeeId))
                CMDuac.Editor.DisplayData(varDatabaseName, varDatabaseEngineE, DgnModulesRoles, varDataProperties.Field01.ToString)

                TxtPersonalID.Focus()

                If varHavePhoto > 0 Then
                    pctbxPhoto.Image = CMDepls.Editor.GetPhoto(varDatabaseName, varDatabaseEngine, Convert.ToString(varDataProperties.EmployeeId))
                End If
            End If

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
            Frm_epls_AddinPosition = New FRMeplsPosition
            Display(Frm_epls_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Position", "Browse for position data", True)
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

            If (CMDepls.Editor.IsPersonalIDExist(varDatabaseName, varDatabaseEngine, varDataProperties.EmployeeIsNew, TxtPersonalID.Text, Convert.ToString(varDataProperties.EmployeeId))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Duplicate Personal ID", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (varPositionID = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMDepls.Editor.IsPositionExist(varDatabaseName, varDatabaseEngine, varPositionID)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Position not found.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                SLFStatus.Items(0).Text = "Position not found"
                Return
            ElseIf (varDataProperties.EmployeeIsNew) AndAlso (CMDepls.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, varPositionID, TxtEmployeeNumber.XOSQLText)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "This Employee Number already used.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (varDataProperties.EmployeeIsNew) AndAlso (CMDepls.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, varPositionID, TxtEmployeeNumber.XOSQLText, Convert.ToString(varDataProperties.EmployeeID))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "This Employee Number already used by another employee.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf varHavePhoto = 0 Then
                Decision(My.Application.Info.AssemblyName.toupper, varMessageCannotSave & Environment.NewLine & "Please pick employee photo.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDepls.Editor.PushData(varDatabaseName, varDatabaseEngine, TxtPersonalID.XOSQLText, varPositionID, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, varPhoto, varChangePhoto, varDataProperties.EmployeeId, Convert.ToString(varDataProperties.EmployeeId))) Then
                UI.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
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
            With varDataProperties
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
                If (CMCv.OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, varMaxUploadSizePhoto, True)) Then
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
End Namespace