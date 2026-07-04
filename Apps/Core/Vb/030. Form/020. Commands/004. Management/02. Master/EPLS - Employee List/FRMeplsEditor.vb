Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMeplsEditor
#Region "Declaration"
        Public Event EventRecordSaved()

        Private WithEvents Frm_epls_AddinPosition As New FRMeplsPosition
        Private varHavePhoto As Boolean
        Private varChangePhoto As Boolean
        Private varPhoto As System.Drawing.Image

        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "EPLS"
        Private Const varMessageCannotSave As String = "Cannot save your record."
#End Region

#Region "Subs Collections"

#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            varDataProperties.UserParameters.Remove(tModule.P_ModuleCode)
            varDataProperties.UserParameters.Add(tModule.P_ModuleCode, varThisModuleCode)

            varHavePhoto = False
            varChangePhoto = False
            If varDataProperties.EmployeeIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Enabled = True
                CboGender.SelectedIndex = 0

                With varDataProperties.AllParameters
                    .Remove(tPosition.P_PositionId)
                    .Add(tPosition.P_PositionId, DBNull.Value)

                End With
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False

                CMDepls.Editor.GetEmployeeProperties(varDataProperties, varDatasetIngrid)

                With varDatasetIngrid.Tables("EPLS_Editor").Rows(0)
                    'Displaying Employee Detail
                    TxtPersonalID.Text = .Item(tEmployee.C_EmployeePersonalIdNumber).ToString
                    TxtFullName.Text = .Item(tEmployee.C_EmployeeFullName).ToString
                    CboGender.SelectedItem = .Item(tEmployee.C_EmployeeGender).ToString
                    DtpBirthDate.Value = If(IsDBNull(.Item(tEmployee.C_EmployeeBirthDate)) OrElse .Item(tEmployee.C_EmployeeBirthDate) Is Nothing, Date.Today, CDate(.Item(tEmployee.C_EmployeeBirthDate)))
                    TxtBirthPlace.Text = .Item(tEmployee.C_EmployeeBirthPlace).ToString
                    TxtAddress.Text = .Item(tEmployee.C_EmployeeAddress).ToString

                    'Displaying Employment Detail
                    TxtCompany.Text = .Item(tcompany.C_CompanyName).ToString
                    TxTDepartment.Text = .Item(tDepartment.C_DepartmentName).ToString
                    varDataProperties.AllParameters.Remove(tPosition.P_PositionId)
                    varDataProperties.AllParameters.Add(tPosition.P_PositionId, CLng(.Item(tPosition.C_PositionId)))
                    TxtPosition.Text = .Item(tPosition.C_PositionName).ToString
                    varDataProperties.AllParameters.Remove(tEmploymentType.P_EmploymentTypeId)
                    varDataProperties.AllParameters.Add(tEmploymentType.P_EmploymentTypeId, IIf(.Item(tEmployee.C_EmployeeEmploymentType) Is Nothing OrElse .Item(tEmployee.C_EmployeeEmploymentType).ToString = String.Empty OrElse .Item(tEmployee.C_EmployeeEmploymentType).ToString = "", DBNull.Value, .Item(tEmployee.C_EmployeeEmploymentType)))
                    TxtEmployeeNumber.Text = .Item(tEmployee.C_EmployeeNumber).ToString
                    TxtEmployeeNickname.Text = .Item(tEmployee.C_EmployeeNickname).ToString
                    ChkActiveEmployee.Checked = CBool(.Item(tEmployee.C_EmployeeIsActive))
                    varHavePhoto = CMDepls.Editor.GetIsHavePhoto(varDataProperties, varDataProperties.UserParameters)
                End With

                TxtPersonalID.Focus()

                If varHavePhoto Then
                    pctbxPhoto.Image = CMDepls.Editor.GetPhoto(varDataProperties, Convert.ToString(varDataProperties.EmployeeId))
                Else
                    Return
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
            Frm_epls_AddinPosition = New FRMeplsPosition
            Display(Frm_epls_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Position", "Browse for position data", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
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

            If Not CheckEmployeePersonalID() Then
                Return
            End If

            If Not CheckEmployeeMandatoryFields() Then
                Return
            End If

            If Not CheckDuplicateEmployeeNumber() Then
                Return
            End If

            If Not CheckEmployeePhoto() Then
                Return
            End If

            With varDataProperties
                .AllParameters.Remove(tEmployee.P_EmployeePersonalIdNumber)
                .AllParameters.Add(tEmployee.P_EmployeePersonalIdNumber, IIf(TxtPersonalID.XOSqlText = String.Empty OrElse TxtPersonalID.XOSqlText = "", DBNull.Value, TxtPersonalID.XOSqlText))
                .AllParameters.Remove(tEmployee.P_EmployeeFullName)
                .AllParameters.Add(tEmployee.P_EmployeeFullName, IIf(TxtFullName.XOSqlText = String.Empty OrElse TxtFullName.XOSqlText = "", DBNull.Value, TxtFullName.XOSqlText))
                .AllParameters.Remove(tEmployee.P_EmployeeBirthPlace)
                .AllParameters.Add(tEmployee.P_EmployeeBirthPlace, IIf(TxtBirthPlace.XOSqlText = String.Empty OrElse TxtBirthPlace.XOSqlText = "", DBNull.Value, TxtBirthPlace.XOSqlText))
                .AllParameters.Remove(tEmployee.P_EmployeeGender)
                .AllParameters.Add(tEmployee.P_EmployeeGender, IIf(CboGender.SelectedItem Is Nothing OrElse CboGender.SelectedItem.ToString = String.Empty, DBNull.Value, CboGender.SelectedItem.ToString))
                .AllParameters.Remove(tEmployee.P_EmployeeAddress)
                .AllParameters.Add(tEmployee.P_EmployeeAddress, IIf(TxtAddress.XOSqlText = String.Empty OrElse TxtAddress.XOSqlText = "", DBNull.Value, TxtAddress.XOSqlText))
                .AllParameters.Remove(tEmployee.P_EmployeeNickname)
                .AllParameters.Add(tEmployee.P_EmployeeNickname, IIf(TxtEmployeeNickname.XOSqlText = String.Empty OrElse TxtEmployeeNickname.XOSqlText = "", DBNull.Value, TxtEmployeeNickname.XOSqlText))
            End With

            If CMDepls.Editor.PushData(varDataProperties) Then
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If ChkAddNew.Checked Then
                TxtCompany.Clear()
                TxTDepartment.Clear()
                TxtPosition.Clear()
                TxtEmploymentType.Clear()
                TxtEmployeeNumber.Clear()
                TxtFullName.Clear()
                TxtEmployeeNickname.Clear()
            Else
                Me.Close()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function CheckEmployeePersonalID() As Boolean
            If CMDepls.Editor.IsPersonalIdExist(varDataProperties) Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Private Function CheckEmployeeMandatoryFields() As Boolean
            If (TxtPersonalID.XOSqlText = String.Empty OrElse IsDBNull(varDataProperties.AllParameters(tPosition.P_PositionId)) OrElse varDataProperties.AllParameters(tPosition.P_PositionId) Is Nothing OrElse (TxtEmployeeNumber.XOSqlText = String.Empty) OrElse (TxtFullName.XOSqlText = String.Empty)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Ensure that the Personal ID, Full Name, Company, Department, Position and Employee Number fields are correctly completed.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Private Function CheckDuplicateEmployeeNumber() As Boolean
            If varDataProperties.EmployeeIsNew AndAlso CMDepls.Editor.IsEmployeeNumberDuplicate(varDataProperties) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "This Employee Number is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Private Function CheckEmployeePhoto() As Boolean
            If Not varHavePhoto Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Please pick employee photo.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Private Sub FRMeplsAddinPosition_RecordSelected() Handles Frm_epls_AddinPosition.EventRecordSelected
            With varDataProperties
                TxtCompany.Text = .AllParameters(tCompany.P_CompanyName).ToString
                TxTDepartment.Text = .AllParameters(tDepartment.P_DepartmentName).ToString
                TxtPosition.Text = .AllParameters(tPosition.P_PositionName).ToString
            End With
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
            OfdPhoto.Title = "INGRID - Select Photo"
            OfdPhoto.FileName = ""
            OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

            If OfdPhoto.ShowDialog = DialogResult.OK Then
                Dim result = LibAPI.Api.Magika.Validate(OfdPhoto.FileName, {"jpg", "jpeg"})
                If Not result.IsValid Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, result.Reason & Environment.NewLine & "Please select a JPG or JPEG file.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                If (CMCv.OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, varMaxUploadSizePhoto, True)) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                    pctbxPhoto.Image = varPhoto
                    varChangePhoto = True
                    varHavePhoto = True
                End If
            Else
                varHavePhoto = False
                Return
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
            If Not varHavePhoto Then
                If CboGender.Text = "MALE" Then
                    pctbxPhoto.Image = My.Resources.MALE_001_512_icon
                Else
                    pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
                End If
            End If
        End Sub

        Private Sub FRMeplsEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            varDataProperties.UserParameters.Remove(tModule.P_ModuleId)
            varDataProperties.UserParameters.Add(tModule.P_ModuleId, varThisModuleId)
        End Sub
    End Class
End Namespace