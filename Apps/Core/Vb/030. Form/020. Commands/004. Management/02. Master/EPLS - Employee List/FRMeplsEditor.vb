Namespace UI.Canvas
    Public Class FRMeplsEditor
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Public Event EventRecordSaved()

        Private WithEvents Frm_epls_AddinPosition As New UI.Canvas.FRMeplsPosition
        Private WithEvents Frm_epls_AddinEmploymentType As New UI.Canvas.FRMeplsEmploymentType

        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "EPLS"
        Private Const varCannotSaveMessageTitle As String = "Unable to save your record."
        Private varCannotSaveMessage As String = String.Empty
        Private varIsTabPermissionFirstLoad As Boolean = True


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EDIT, XOLogo,, 512, 512)

            ' Set active module to UserParameters
            CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, DgnModulesRoles)
            SetValue(varDataProperties.AllParameters, tModule.P_ModuleCode, varThisModuleCode)
            varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)

            ' Continue to Load anything for this module
            varDataProperties.EmployeeIsHavePhoto = False
            varDataProperties.EmployeeIsNewPhoto = True
            varDataProperties.EmployeeIsForceChangePhoto = False
            If varDataProperties.EmployeeIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Enabled = True
                CboGender.SelectedIndex = 0
                BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
                BtnRemovePhoto.Enabled = False
                SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeToken, CMCv.Security.Encryption.MD5())
                SetValue(varDataProperties.AllParameters, tPosition.P_PositionId, DBNull.Value)
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False

                CMDepls.Editor.GetEmployeeProperties(varDataProperties, varDatasetIngrid)

                With varDatasetIngrid.Tables("EPLS_Editor").Rows(0)
                    'Displaying Employee Detail
                    SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeId, CLng(.Item(tEmployee.C_EmployeeId)))
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
                    TxtUsername.Text = .Item(tUser.C_UserUsername).ToString
                    TxtCompanyEmail.Text = .Item(tEmployee.C_EmployeeCompanyEmail).ToString
                    'varDataProperties.EmployeeIsHavePhoto = CMDepls.Editor.GetIsHavePhoto(varDataProperties, varDatasetIngrid, varDataProperties.UserParameters)
                    varDataProperties.EmployeeIsHavePhoto = CBool(.Item("ishavephoto"))
                    If varDataProperties.EmployeeIsHavePhoto Then
                        SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentId, CLng(.Item(tAttachment.C_AttachmentId)))
                        CMCv.ImageEditor.File.GetImage.GetImageFromUrlAsync(.Item(tAttachment.C_AttachmentUrl).ToString, pctbxPhoto)
                        BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
                        BtnRemovePhoto.Enabled = True
                    Else
                        BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
                        BtnRemovePhoto.Enabled = False
                    End If
                End With
            End If
            Call ResetPhoto()
            TxtPersonalID.Focus()
        End Sub

        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------
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

                SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentFileNameOriginal, IO.Path.GetFileName(OfdPhoto.FileName))
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
        Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
            Frm_epls_AddinPosition = New UI.Canvas.FRMeplsPosition
            Display(Frm_epls_AddinPosition, ImageDb.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Position", "Browse for position data", True)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Dim varInvalidScore As Integer = 0
            varCannotSaveMessage = String.Empty
            varInvalidScore += CheckInvalidInputs()
            varInvalidScore += CheckEmployeePersonalID()
            varInvalidScore += CheckDuplicateEmployeeNumber()
            varInvalidScore += CheckEmployeeNoPhoto()

            If varInvalidScore > 0 Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varCannotSaveMessageTitle & Environment.NewLine & "Please ensure that the following item(s) have been checked:" & Environment.NewLine & varCannotSaveMessage, LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
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

            If Await CMDepls.Editor.PushData(varDataProperties, varDataProperties.AllParameters) Then
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
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
        Private Sub TxtFullName_TextChanged(sender As Object, e As EventArgs) Handles TxtFullName.TextChanged
            If TxtFullName.Text.Length > 0 Then
                TxtEmployeeNickname.Text = String.Concat(TxtFullName.Text.Trim.Split(" "c).Select(Function(w) w(0))).ToUpper()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnBrowseEmploymentType_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmploymentType.Click
            Frm_epls_AddinEmploymentType = New UI.Canvas.FRMeplsEmploymentType
            Display(Frm_epls_AddinEmploymentType, ImageDb.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Employment Type", "Browse for Employment Type data", True)
        End Sub

        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This subroutine checks all input fields in the form by setting focus to each control sequentially. It ensures that all required fields are validated before proceeding with any save operation.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function CheckInvalidInputs() As Integer
            Dim varInvalidScore As Integer = 0

            TxtPersonalID.Focus()
            If TxtPersonalID.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

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
            If varInvalidScore > 0 Then
                varCannotSaveMessage += "• National ID Card, Employee Code, Employee Name, Birth Place, Employee Position and Employment Type fields have been entered correctly" & Environment.NewLine
            End If
            Return varInvalidScore
        End Function

        ''' <summary>
        ''' This function checks if the entered Personal ID already exists in the system. It calls the IsPersonalIdExist method from the CMDepls.Editor class, passing the current data properties and the Personal ID text. If the Personal ID exists, it returns True; otherwise, it returns False.
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckEmployeePersonalID() As Integer
            Dim varInvalidScore As Integer
            varInvalidScore = CMDepls.Editor.IsPersonalIdExist(varDataProperties, TxtPersonalID.XOSqlText)
            If varInvalidScore > 0 Then
                varCannotSaveMessage += "• Personal ID Number already registered" & Environment.NewLine
            End If
            Return varInvalidScore
        End Function

        ''' <summary>
        ''' This function checks if the mandatory fields for an employee record are filled. If any of the required fields (Personal ID, Full Name, Company, Department, Position, Employee Code) are empty or null, it displays an alert message and returns False. If all mandatory fields are filled, it returns True, allowing the save operation to proceed.
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckEmployeeMandatoryFields() As Boolean
            If (TxtPersonalID.XOSqlText = String.Empty OrElse IsDBNull(varDataProperties.AllParameters(tPosition.P_PositionId)) OrElse varDataProperties.AllParameters(tPosition.P_PositionId) Is Nothing OrElse (TxtEmployeeNumber.XOSqlText = String.Empty) OrElse (TxtFullName.XOSqlText = String.Empty)) Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' This function checks for duplicate employee numbers in the system. If the employee is new and the entered employee number already exists, it displays an alert message and returns False. Otherwise, it returns True, indicating that there are no duplicates and the save operation can proceed.
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckDuplicateEmployeeNumber() As Integer
            Dim varInvalidScore As Integer
            SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeNumber, TxtEmployeeNumber.XOSqlText)
            varInvalidScore = CMDepls.Editor.IsEmployeeNumberDuplicate(varDataProperties, TxtEmployeeNumber.XOSqlText)
            If varInvalidScore > 0 Then
                varCannotSaveMessage += "• Employee Code already registered" & Environment.NewLine
            End If
            Return varInvalidScore
        End Function

        ''' <summary>
        ''' This function checks if the employee has a photo uploaded. If not, it displays an alert message prompting the user to select a photo and returns False. If a photo is present, it returns True, allowing the save operation to proceed.
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckEmployeeNoPhoto() As Integer
            Dim varInvalidScore As Integer = 0
            If varDataProperties.EmployeeIsHavePhoto Then
                varInvalidScore = 0
            Else
                varCannotSaveMessage += "• You haven't select an Employee photo" & Environment.NewLine
                varInvalidScore = 1
            End If
            Return varInvalidScore
        End Function

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

        ' ---------------------------------------------------------
        ' Addins Events Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when a record is selected in the FRMepls_AddinPosition form. It retrieves the selected company's name, department's name, and position's name from the AllParameters collection of varDataProperties and updates the corresponding text fields (TxtCompany, TxTDepartment, TxtPosition) in the FRMeplsEditor form with these values.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsAddinPosition_RecordSelected() Handles Frm_epls_AddinPosition.EventRecordSelected
            With varDataProperties
                TxtCompany.Text = .AllParameters(tCompany.P_CompanyName).ToString
                TxTDepartment.Text = .AllParameters(tDepartment.P_DepartmentName).ToString
                TxtPosition.Text = .AllParameters(tPosition.P_PositionName).ToString
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsAddinEmploymentType_EventRecordSelected() Handles Frm_epls_AddinEmploymentType.EventRecordSelected
            With varDataProperties
                TxtEmploymentType.Text = .AllParameters(tEmploymentType.P_EmploymentTypeName).ToString
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TbctlEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TbctlEmployee.SelectedIndexChanged
            If TbctlEmployee.SelectedTab Is tpPermissions AndAlso varIsTabPermissionFirstLoad Then
                MsgBox("This feature is not available yet. Please contact your system administrator.", MsgBoxStyle.Information, "Feature Unavailable")
                varIsTabPermissionFirstLoad = False
            End If
        End Sub
    End Class
End Namespace