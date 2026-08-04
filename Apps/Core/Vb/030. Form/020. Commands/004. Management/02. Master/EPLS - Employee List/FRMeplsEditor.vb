Namespace UI.Canvas
    Public Class FRMeplsEditor
        Public Event EventRecordSaved()

        Private WithEvents Frm_epls_AddinPosition As New FRMeplsPosition

        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "EPLS"
        Private Const varMessageCannotSave As String = "Cannot save your record."


        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Set active module to UserParameters
            SetValue(varDataProperties.UserParameters, tModule.P_ModuleCode, varThisModuleCode)
            varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.UserParameters)
            SetModuleIdentifier(varDataProperties.UserParameters, varThisModuleCode, varThisModuleId)

            ' Continue to Load anything for this module
            varDataProperties.EmployeeIsHavePhoto = False
            varDataProperties.EmployeeIsNewPhoto = True
            varDataProperties.EmployeeIsForceChangePhoto = False
            If varDataProperties.EmployeeIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Enabled = True
                CboGender.SelectedIndex = 0
                SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeToken, CMCv.Security.Encryption.MD5())
                SetValue(varDataProperties.AllParameters, tPosition.P_PositionId, DBNull.Value)
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
                    TxtCompany.Text = .Item(tCompany.C_CompanyName).ToString
                    TxTDepartment.Text = .Item(tDepartment.C_DepartmentName).ToString
                    TxtPosition.Text = .Item(tPosition.C_PositionName).ToString
                    SetValue(varDataProperties.AllParameters, tPosition.P_PositionId, CLng(.Item(tPosition.C_PositionId)))
                    SetValue(varDataProperties.AllParameters, tEmploymentType.P_EmploymentTypeId, IIf(.Item(tEmployee.C_EmployeeEmploymentType) Is Nothing OrElse .Item(tEmployee.C_EmployeeEmploymentType).ToString = String.Empty OrElse .Item(tEmployee.C_EmployeeEmploymentType).ToString = "", DBNull.Value, .Item(tEmployee.C_EmployeeEmploymentType)))
                    TxtEmployeeNumber.Text = .Item(tEmployee.C_EmployeeNumber).ToString
                    TxtEmployeeNickname.Text = .Item(tEmployee.C_EmployeeNickname).ToString
                    ChkActiveEmployee.Checked = CBool(.Item(tEmployee.C_EmployeeIsActive))
                    varDataProperties.EmployeeIsHavePhoto = CMDepls.Editor.GetIsHavePhoto(varDataProperties, varDatasetIngrid, varDataProperties.UserParameters)
                End With

                If varDataProperties.EmployeeIsHavePhoto Then
                    pctbxPhoto.Image = CMDepls.Editor.GetPhoto(varDataProperties, Convert.ToString(varDataProperties.EmployeeId))
                    varDataProperties.EmployeePhoto = pctbxPhoto.Image
                    BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
                    varDataProperties.EmployeeIsHavePhoto = True
                    varDataProperties.EmployeeIsNewPhoto = False
                    BtnRemovePhoto.Enabled = True
                Else
                    BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
                    BtnRemovePhoto.Enabled = False
                End If
            End If
            Call ResetPhoto()
            TxtPersonalID.Focus()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
            Frm_epls_AddinPosition = New FRMeplsPosition
            Display(Frm_epls_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Position", "Browse for position data", True)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        ''' <summary>
        ''' This subroutine checks all input fields in the form by setting focus to each control sequentially. It ensures that all required fields are validated before proceeding with any save operation.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function CheckInvalidInputs() As Boolean
            Dim varInvalidScore As Integer = 0

            'TxtPersonalID.Focus()
            TxtEmployeeNumber.Focus()
            If TxtEmployeeNumber.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtFullName.Focus()
            If TxtFullName.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtBirthPlace.Focus()
            If TxtBirthPlace.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtPosition.Focus()
            If TxtPosition.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            If varInvalidScore = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            If CheckInvalidInputs() Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable to save your record." & Environment.NewLine & "Please verify that the Company Code, Company Name, Search Term1 and Search Term2 fields have been entered correctly.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                SetValue(.AllParameters, tEmployee.P_EmployeePersonalIdNumber, IIf(TxtPersonalID.XOSqlText = String.Empty OrElse TxtPersonalID.XOSqlText = "", DBNull.Value, TxtPersonalID.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeFullName, IIf(TxtFullName.XOSqlText = String.Empty OrElse TxtFullName.XOSqlText = "", DBNull.Value, TxtFullName.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeBirthPlace, IIf(TxtBirthPlace.XOSqlText = String.Empty OrElse TxtBirthPlace.XOSqlText = "", DBNull.Value, TxtBirthPlace.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeGender, IIf(CboGender.SelectedItem Is Nothing OrElse CboGender.SelectedItem.ToString = String.Empty, DBNull.Value, CboGender.SelectedItem.ToString))
                SetValue(.AllParameters, tEmployee.P_EmployeeAddress, IIf(TxtAddress.XOSqlText = String.Empty OrElse TxtAddress.XOSqlText = "", DBNull.Value, TxtAddress.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeBirthDate, IIf(DtpBirthDate.Value = Nothing OrElse DtpBirthDate.Value = Date.MinValue, DBNull.Value, DtpBirthDate.Value))
                SetValue(.AllParameters, tEmployee.P_EmployeePosition, IIf(TxtPosition.XOSqlText = String.Empty OrElse TxtPosition.XOSqlText = "", DBNull.Value, TxtPosition.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeNumber, IIf(TxtEmployeeNumber.XOSqlText = String.Empty OrElse TxtEmployeeNumber.XOSqlText = "", DBNull.Value, TxtEmployeeNumber.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeNickname, IIf(TxtEmployeeNickname.XOSqlText = String.Empty OrElse TxtEmployeeNickname.XOSqlText = "", DBNull.Value, TxtEmployeeNickname.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeIsActive, ChkActiveEmployee.Checked)

                ' Please update this method when EmploymentType is ready
                SetValue(.AllParameters, tEmployee.P_EmployeeEmploymentType, IIf(TxtEmploymentType.XOSqlText = String.Empty OrElse TxtEmploymentType.XOSqlText = "", DBNull.Value, DBNull.Value))
            End With

            If Not CheckEmployeePersonalID() Then
                Return
            End If
            If Not CheckDuplicateEmployeeNumber() Then
                Return
            End If
            If Not CheckEmployeePhoto() Then
                Return
            End If

            If CMDepls.Editor.PushData(varDataProperties, varDataProperties.AllParameters) Then
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

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckEmployeePersonalID() As Boolean
            If CMDepls.Editor.IsPersonalIdExist(varDataProperties) Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckEmployeeMandatoryFields() As Boolean
            If (TxtPersonalID.XOSqlText = String.Empty OrElse IsDBNull(varDataProperties.AllParameters(tPosition.P_PositionId)) OrElse varDataProperties.AllParameters(tPosition.P_PositionId) Is Nothing OrElse (TxtEmployeeNumber.XOSqlText = String.Empty) OrElse (TxtFullName.XOSqlText = String.Empty)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Ensure that the Personal ID, Full Name, Company, Department, Position and Employee Code fields are correctly completed.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckDuplicateEmployeeNumber() As Boolean
            If varDataProperties.EmployeeIsNew AndAlso CMDepls.Editor.IsEmployeeNumberDuplicate(varDataProperties) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "This Employee Code already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckEmployeePhoto() As Boolean
            If Not varDataProperties.EmployeeIsHavePhoto Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Please select employee photo.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return False
            Else
                Return True
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsAddinPosition_RecordSelected() Handles Frm_epls_AddinPosition.EventRecordSelected
            With varDataProperties
                TxtCompany.Text = .AllParameters(tCompany.P_CompanyName).ToString
                TxTDepartment.Text = .AllParameters(tDepartment.P_DepartmentName).ToString
                TxtPosition.Text = .AllParameters(tPosition.P_PositionName).ToString
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
            If varDatasetIngrid.Tables(dtSettings).Rows(0).Item(tSettings.C_SettingsStorageProvider).ToString = "Disabled" Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Photo upload is disabled. Please contact your system administrator.", LibApp.Ingrid.Global.PopupType.Alert, "Cloud storage is disabled", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            OfdPhoto.Title = "INGRID - Select Photo"
            OfdPhoto.FileName = ""
            OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

            If OfdPhoto.ShowDialog = DialogResult.OK Then
                Dim result = LibAPI.Api.Magika.Validate(OfdPhoto.FileName, {"jpg", "jpeg"})
                If Not result.IsValid Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, result.Reason & Environment.NewLine & "Please select a JPG or JPEG file.", LibApp.Ingrid.Global.PopupType.Alert, "Invalid Photo Format", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Dim ext As String = IO.Path.GetExtension(OfdPhoto.FileName).ToLower()

                If (CMCv.OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, varMaxUploadSizePhoto, True)) Then
                    varDataProperties.EmployeePhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                    pctbxPhoto.Image = varDataProperties.EmployeePhoto
                    varDataProperties.EmployeeIsForceChangePhoto = True
                    varDataProperties.EmployeeIsHavePhoto = True
                    BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
                    BtnRemovePhoto.Enabled = True
                    SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentExtension, ext)
                End If
            Else
                varDataProperties.EmployeeIsHavePhoto = False
                Return
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
            ' Reset to default photo if gender is changed and no
            Call ResetPhoto()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.UserParameters, varThisModuleCode, varThisModuleId)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnRemovePhoto_Click(sender As Object, e As EventArgs) Handles BtnRemovePhoto.Click
            pctbxPhoto.Image = Nothing
            BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
            BtnRemovePhoto.Enabled = False
            varDataProperties.EmployeeIsHavePhoto = False
            Call ResetPhoto()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ResetPhoto()
            If Not varDataProperties.EmployeeIsHavePhoto Then
                If CboGender.Text = "MALE" Then
                    pctbxPhoto.Image = My.Resources.MALE_001_512_icon
                Else
                    pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
                End If
                SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentExtension, GetImageExtension(pctbxPhoto.Image))
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function GetImageExtension(image As Image) As String
            If image Is Nothing Then
                Return String.Empty
            End If
            Dim format As Imaging.ImageFormat = image.RawFormat
            If format.Equals(Imaging.ImageFormat.Jpeg) Then
                Return ".jpg"
            ElseIf format.Equals(Imaging.ImageFormat.Png) Then
                Return ".png"
            ElseIf format.Equals(Imaging.ImageFormat.Gif) Then
                Return ".gif"
            ElseIf format.Equals(Imaging.ImageFormat.Bmp) Then
                Return ".bmp"
            ElseIf format.Equals(Imaging.ImageFormat.Tiff) Then
                Return ".tiff"
            Else
                Return String.Empty
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFullName_TextChanged(sender As Object, e As EventArgs) Handles TxtFullName.TextChanged
            TxtEmployeeNickname.Text = String.Concat(TxtFullName.Text.Trim.Split(" "c).Select(Function(w) w(0))).ToUpper()
        End Sub
    End Class
End Namespace