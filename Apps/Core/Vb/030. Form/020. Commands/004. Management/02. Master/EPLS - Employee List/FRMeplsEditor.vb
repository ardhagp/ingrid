Namespace UI.Canvas
    Public Class FRMeplsEditor
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Public Event EventRecordSaved()
        Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip

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
        ''' <summary>
        ''' This subroutine is an event handler for the form's Activated event. It sets the active module identifier to the current module code and ID, ensuring that the application recognizes the current context as the Employee List module. This is important for managing user permissions and interactions within the application. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set the active module identifier to the current module code and ID, ensuring that the application recognizes the current context as the Employee List module. This is important for managing user permissions and interactions within the application.
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the form's Load event. It initializes the form by loading the logo image, setting up the mainframe menu, and configuring the initial state of the form based on whether a new employee record is being created or an existing one is being edited. It also sets default values for certain fields and prepares the form for user interaction.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EDIT, XOLogo,, 512, 512, True, "Module")

            ' Set up the mainframe menu and display it on the form
            ComponentMainframeMenu.LoadIn(Me, True)
            ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            ' Set active module to UserParameters
            CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, DgnModulesRoles)
            SetValue(varDataProperties.AllParameters, tModule.P_ModuleCode, varThisModuleCode)
            varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)

            ' Continue to Load anything for this module
            varDataProperties.EmployeeIsHavePhoto = False
            varDataProperties.EmployeeIsNewPhoto = True
            varDataProperties.EmployeeIsForceChangePhoto = False

            ' If the employee is new, show the "Add New" checkbox and set default values for gender and birth date; otherwise, hide the checkbox and load existing employee data into the form's input fields
            If varDataProperties.EmployeeIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Enabled = True
                CboGender.SelectedIndex = 0
                DtpBirthDate.Value = Date.Today.AddYears(-17)
                BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
                BtnRemovePhoto.Enabled = False

                With varDataProperties
                    ' Clear the EmployeeId parameter to ensure that a new employee record is created instead of updating an existing one.
                    SetValue(.AllParameters, tEmployee.P_EmployeeId, DBNull.Value)
                    .AllParameters.Remove(tEmployee.P_EmployeePersonalIdNumber)
                    .AllParameters.Remove(tEmployee.P_EmployeeFullName)
                    .AllParameters.Remove(tEmployee.P_EmployeeBirthPlace)
                    .AllParameters.Remove(tEmployee.P_EmployeeGender)
                    .AllParameters.Remove(tEmployee.P_EmployeeAddress)
                    .AllParameters.Remove(tEmployee.P_EmployeeBirthDate)
                    .AllParameters.Remove(tEmployee.P_EmployeeNickname)
                    .AllParameters.Remove(tEmployee.P_EmployeeCompanyEmail)
                    .AllParameters.Remove(tEmployee.P_EmployeeIsActive)

                    ' Set the necessary parameters for a new employee record, including generating a new employee token using MD5 encryption.
                    SetValue(.AllParameters, tEmployee.P_EmployeeToken, CMCv.Security.Encryption.MD5())
                    SetValue(.AllParameters, tPosition.P_PositionId, DBNull.Value)
                    SetValue(.AllParameters, tEmploymentType.P_EmploymentTypeId, DBNull.Value)
                End With
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False

                ' Load the existing employee data into the form's input fields
                Call LoadData()
            End If

            ' Reset the photo to its default state and set focus to the Personal ID text box for user input.
            Call ResetPhoto()
            TxtPersonalID.Focus()
        End Sub


        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This subroutine is an event handler for the "Browse Photo" button click event. It allows the user to select a photo file for the employee. The method checks if photo upload is enabled, opens a file dialog for selecting JPG or JPEG files, validates the selected file's format and size, and then processes the image to be displayed in the form. If a valid photo is selected, it updates the employee's photo properties accordingly. If no photo is selected and the employee does not have an existing photo, it resets the photo properties.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
            ' Check if photo upload is disabled in the application settings. If it is, display an alert message and exit the subroutine.
            If varDatasetIngrid.Tables(dtSettings).Rows(0).Item(tSettings.C_SettingsStorageProvider).ToString = "Disabled" Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Photo upload is disabled. Please contact your system administrator.", LibApp.Ingrid.Global.PopupType.Alert, "Cloud storage is disabled", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            ' Open a file dialog for the user to select a photo file.
            OfdPhoto.Title = "INGRID - Select Photo"
            OfdPhoto.FileName = ""
            OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

            ' If the user selects a file and clicks "OK," validate the file format and size. If the file is valid, process it and update the employee's photo properties. If the user cancels the dialog or selects an invalid file, handle accordingly.
            If OfdPhoto.ShowDialog = DialogResult.OK Then
                Dim result = LibAPI.Api.Magika.Validate(OfdPhoto.FileName, {"jpg", "jpeg"})

                ' If the selected file is not a valid JPG or JPEG format, display an alert message and exit the subroutine.
                If Not result.IsValid Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, result.Reason & Environment.NewLine & "Please select a JPG or JPEG file.", LibApp.Ingrid.Global.PopupType.Alert, "Invalid Photo Format", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                ' Update the employee's photo properties with the selected file's name and extension.
                SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentFileNameOriginal, IO.Path.GetFileName(OfdPhoto.FileName))
                Dim ext As String = IO.Path.GetExtension(OfdPhoto.FileName).ToLower()

                ' If the selected file is a valid JPG or JPEG format and its size is within the allowed limit, process the image, update the picture box with the new photo, and set the appropriate flags for the employee's photo status. If the file size exceeds the allowed limit, display an alert message.
                If (CMCv.OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, varMaxUploadSizePhoto, True)) Then
                    varDataProperties.EmployeePhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                    pctbxPhoto.Image = varDataProperties.EmployeePhoto

                    ' If the employee already has a photo, set the flags to indicate that the photo should be changed; otherwise, set the flags to indicate that a new photo is being added. Enable the "Remove Photo" button and update the attachment extension parameter with the selected file's extension.
                    If varDataProperties.EmployeeIsHavePhoto Then
                        varDataProperties.EmployeeIsForceChangePhoto = True
                        varDataProperties.EmployeeIsNewPhoto = False
                    Else
                        varDataProperties.EmployeeIsForceChangePhoto = False
                        varDataProperties.EmployeeIsNewPhoto = True
                    End If

                    BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
                    BtnRemovePhoto.Enabled = True
                    SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentExtension, ext)
                End If
            Else
                ' If the user cancels the file selection dialog and the employee does not have an existing photo, reset the photo properties to indicate that there is no photo.
                If varDataProperties.EmployeeIsHavePhoto Then
                    Return
                End If

                varDataProperties.EmployeeIsForceChangePhoto = False
                varDataProperties.EmployeeIsNewPhoto = False
            End If
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Browse Position" button click event. It opens a new form (FRMeplsPosition) that allows the user to browse and select a position for the employee. The method sets up the necessary properties for the new form, including the form's title, subtitle, and image, and then displays it as a dialog. This enables users to easily find and assign a position to the employee being edited or created.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
            ' Reset to default photo if gender is changed and no
            Call ResetPhoto()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Browse Position" button click event. It opens a new form (FRMeplsPosition) that allows the user to browse and select a position for the employee. The method sets up the necessary properties for the new form, including the form's title, subtitle, and image, and then displays it as a dialog. This enables users to easily find and assign a position to the employee being edited or created.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
            Frm_epls_AddinPosition = New UI.Canvas.FRMeplsPosition
            With varDataProperties
                .IngridFormImage = ImageDb.Main.ImageLibrary.SEARCH_ICON
                .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                .IngridFormTitle = "Find Position"
                .IngridFormSubtitle = "Browse for position data"
                .IngridFormIsDialog = True
            End With

            ' Display the FRMeplsPosition form as a dialog, passing the varDataProperties object to it. This allows the user to browse and select a position for the employee being edited or created.
            Display(Frm_epls_AddinPosition,, varDataProperties)
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Browse Employment Type" button click event. It opens a new form (FRMeplsEmploymentType) that allows the user to browse and select an employment type for the employee. The method sets up the necessary properties for the new form, including the form's title, subtitle, and image, and then displays it as a dialog. This enables users to easily find and assign an employment type to the employee being edited or created.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileSave() Handles ComponentMainframeMenu.EventFileSave
            ' Call the Save() method to save the employee data when the "Save" option is selected from the mainframe menu. This ensures that any changes made to the employee's information are persisted to the database or data source.
            Call Save()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Undo" menu item in the mainframe menu. When the "Undo" option is selected, it prompts the user with a decision dialog asking if they want to undo all changes. If the user confirms, it checks whether the department is new or existing. If it's new, it clears the input fields for department code, name, and description. If it's an existing department, it reloads the data to revert any changes made. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the undo functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileUndo() Handles ComponentMainframeMenu.EventFileUndoAll
            If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.UndoChanges, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                ' If the employee is new, clear the input fields for personal ID, full name, gender, birth date, birth place, address, company, department, position, employment type, employee number, nickname, active status, username, and company email. If the employee is existing, reload the data to revert any changes made.
                If (varDataProperties.EmployeeIsNew) Then
                    TxtPersonalID.Clear()
                    TxtFullName.Clear()
                    CboGender.SelectedItem = 0
                    DtpBirthDate.Value = Date.Today.AddYears(-17)
                    TxtBirthPlace.Clear()
                    TxtAddress.Clear()

                    TxtCompany.Clear()
                    TxTDepartment.Clear()
                    TxtPosition.Clear()
                    TxtEmploymentType.Clear()
                    TxtEmployeeNumber.Clear()
                    TxtEmployeeNickname.Clear()
                    ChkActiveEmployee.Checked = True
                    TxtUsername.Clear()
                    TxtCompanyEmail.Clear()
                    varDataProperties.EmployeeIsHavePhoto = False
                Else
                    ' If the employee is existing, reload the data to revert any changes made.
                    Call LoadData()
                End If
            End If
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Cancel" menu item in the mainframe menu. When the "Cancel" option is selected, it triggers the form to close by calling the Close() method. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the cancel functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileCancel() Handles ComponentMainframeMenu.EventFileCancel
            ' Close the form when the "Cancel" option is selected from the mainframe menu. This allows the user to exit the employee editor without saving any changes made to the employee's information.
            Call CancelEdit()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Save" button click event. It calls the Save() method to initiate the process of saving the employee data entered in the form. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the save functionality is only executed in a compatible environment.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            ' Call the Save() method to save the employee data when the "Save" button is clicked. This ensures that any changes made to the employee's information are persisted to the database or data source.
            Call Save()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Cancel" button click event. It calls the CancelEdit() method to handle the cancellation of any changes made in the form and close the form. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the cancel functionality is only executed in a compatible environment.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            ' Call the CancelEdit() method to handle the cancellation of any changes made in the form and close the form. This ensures that the user can exit the employee editor without saving any changes.
            Call CancelEdit()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Remove Photo" button click event. It removes the currently displayed photo of the employee by setting the picture box image to Nothing, disabling the remove photo button, and updating the employee's photo properties to indicate that they no longer have a photo. It also calls the ResetPhoto() method to reset any related photo settings. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the remove photo functionality is only executed in a compatible environment.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnRemovePhoto_Click(sender As Object, e As EventArgs) Handles BtnRemovePhoto.Click
            pctbxPhoto.Image = Nothing
            BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
            BtnRemovePhoto.Enabled = False
            varDataProperties.EmployeeIsHavePhoto = False

            ' Call the ResetPhoto() method to reset any related photo settings. This ensures that the employee's photo is properly cleared and any associated UI elements are updated accordingly.
            Call ResetPhoto()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Full Name" text box's TextChanged event. It automatically generates a nickname for the employee based on the initials of their full name. When the user types in the full name, the method splits the name into words, takes the first letter of each word, concatenates them, and converts them to uppercase to form the nickname. This provides a convenient way to create a nickname without requiring additional input from the user. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFullName_TextChanged(sender As Object, e As EventArgs) Handles TxtFullName.TextChanged
            ' If the "Full Name" text box is not empty, generate a nickname based on the initials of the full name. The method splits the full name into words, takes the first letter of each word, concatenates them, and converts them to uppercase to form the nickname. This provides a convenient way to create a nickname without requiring additional input from the user.
            If TxtFullName.Text.Length > 0 Then
                TxtEmployeeNickname.Text = String.Concat(TxtFullName.Text.Trim.Split(" "c).Select(Function(w) w(0))).ToUpper()
            End If
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Browse Employment Type" button click event. It opens a new form (FRMeplsEmploymentType) that allows the user to browse and select an employment type for the employee. The method sets up the necessary properties for the new form, including the form's title, subtitle, and image, and then displays it as a dialog. This enables users to easily find and assign an employment type to the employee being edited or created.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnBrowseEmploymentType_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmploymentType.Click
            ' Create a new instance of the FRMeplsEmploymentType form.
            Frm_epls_AddinEmploymentType = New UI.Canvas.FRMeplsEmploymentType
            With varDataProperties
                .IngridFormImage = ImageDb.Main.ImageLibrary.SEARCH_ICON
                .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                .IngridFormTitle = "Find Employment Type"
                .IngridFormSubtitle = "Browse for Employment Type data"
                .IngridFormIsDialog = True
            End With
            Display(Frm_epls_AddinEmploymentType,, varDataProperties)
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This subroutine is responsible for loading employee data into the form. It retrieves employee properties from the database using the GetEmployeeProperties method and populates various input fields with the retrieved data. The fields include personal information such as Personal ID, Full Name, Gender, Birth Date, Birth Place, Address, and employment details like Company, Department, Position, Employment Type, Employee Number, Nickname, Active status, Username, and Company Email. Additionally, it checks if the employee has a photo and loads it if available. The method ensures that all relevant data is displayed correctly for both new and existing employees.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LoadData()
            CMDepls.Editor.GetEmployeeProperties(varDataProperties, varDatasetIngrid)

            With varDatasetIngrid.Tables(dstTableName.EplsEditor).Rows(0)
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
                TxtEmploymentType.Text = .Item(tEmploymentType.C_EmploymentTypeName).ToString
                TxtEmployeeNumber.Text = .Item(tEmployee.C_EmployeeNumber).ToString
                TxtEmployeeNickname.Text = .Item(tEmployee.C_EmployeeNickname).ToString
                ChkActiveEmployee.Checked = CBool(.Item(tEmployee.C_EmployeeIsActive))
                SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeToken, .Item(tEmployee.C_EmployeeToken).ToString)
                TxtUsername.Text = .Item(tUser.C_UserUsername).ToString
                TxtCompanyEmail.Text = .Item(tEmployee.C_EmployeeCompanyEmail).ToString
                varDataProperties.EmployeeIsHavePhoto = CBool(.Item("ishavephoto"))

                ' If the employee has a photo, set the relevant flags and load the photo asynchronously.
                If varDataProperties.EmployeeIsHavePhoto Then
                    varDataProperties.EmployeeIsNewPhoto = False
                    varDataProperties.EmployeeIsForceChangePhoto = False
                    SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentId, CLng(.Item(tAttachment.C_AttachmentId)))
                    SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentToken, .Item(tAttachment.C_AttachmentToken).ToString)
                    CMCv.ImageEditor.File.GetImage.GetImageFromUrlAsync(.Item(tAttachment.C_AttachmentUrl).ToString, pctbxPhoto)
                    BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
                    BtnRemovePhoto.Enabled = True
                Else
                    BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
                    BtnRemovePhoto.Enabled = False
                End If
            End With
        End Sub

        ''' <summary>
        ''' This subroutine checks all input fields in the form by setting focus to each control sequentially. It ensures that all required fields are validated before proceeding with any save operation.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function CheckInvalidInputs() As Integer
            Dim varInvalidScore As Integer = 0

            TxtPersonalID.Focus()
            ' Check if the Personal ID field is empty. If it is, increment the invalid score counter.
            If TxtPersonalID.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtEmployeeNumber.Focus()
            ' Check if the Employee Number field is empty. If it is, increment the invalid score counter.
            If TxtEmployeeNumber.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtFullName.Focus()
            ' Check if the Full Name field is empty. If it is, increment the invalid score counter.
            If TxtFullName.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtBirthPlace.Focus()
            ' Check if the Birth Place field is empty. If it is, increment the invalid score counter.
            If TxtBirthPlace.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtPosition.Focus()
            ' Check if the Position field is empty. If it is, increment the invalid score counter.
            If TxtPosition.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            ' Check if the Employment Type field is empty. If it is, increment the invalid score counter.
            If TxtEmploymentType.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            ' If any of the required fields are invalid (i.e., the invalid score is greater than 0), append a message to the cannot save message string indicating that certain fields have not been entered correctly.
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

            ' If the Personal ID already exists in the system (i.e., the invalid score is greater than 0), append a message to the cannot save message string indicating that the Personal ID Number is already registered. This provides feedback to the user that they need to enter a unique Personal ID for the employee record.
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
            ' Check if any of the mandatory fields are empty or null. If any are, return False; otherwise, return True.
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

            ' If the Employee Number already exists in the system (i.e., the invalid score is greater than 0), append a message to the cannot save message string indicating that the Employee Code is already registered. This provides feedback to the user that they need to enter a unique Employee Number for the employee record.
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

            ' If the employee has a photo and it is not being force refreshed or newly added, set the invalid score to 0.
            If varDataProperties.EmployeeIsHavePhoto AndAlso Not varDataProperties.EmployeeIsForceRefresh AndAlso Not varDataProperties.EmployeeIsNewPhoto Then
                varInvalidScore = 0
            Else
                If Not (varDataProperties.EmployeeIsForceRefresh) AndAlso Not (varDataProperties.EmployeeIsNewPhoto) Then
                    varCannotSaveMessage += "• You haven't select an Employee photo" & Environment.NewLine
                    varInvalidScore = 1
                End If
            End If
            Return varInvalidScore
        End Function

        ''' <summary>
        ''' This subroutine resets the employee photo to a default image based on the selected gender if the employee does not have a photo. If the gender is "MALE," it sets the photo to a default male icon; if "FEMALE," it sets it to a default female icon. It also updates the attachment extension in the employee's parameters to match the default image format. This ensures that there is always a valid photo associated with the employee record, even if no custom photo has been uploaded.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ResetPhoto()
            ' If the employee does not have a photo, set the photo to a default image based on the selected gender.
            If Not varDataProperties.EmployeeIsHavePhoto Then
                If CboGender.Text = "MALE" Then
                    pctbxPhoto.Image = My.Resources.MALE_001_512_icon
                Else
                    pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
                End If
                SetValue(varDataProperties.AllParameters, tAttachment.P_AttachmentExtension, GetImageExtension(pctbxPhoto.Image))
            End If
        End Sub

        ''' <summary>
        ''' This function retrieves the file extension of a given image based on its format. It checks the raw format of the image and returns the corresponding file extension as a string (e.g., ".jpg" for JPEG, ".png" for PNG, etc.). If the image is null or its format is not recognized, it returns an empty string. This is useful for determining the appropriate file extension when saving or processing images.
        ''' </summary>
        ''' <param name="image"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function GetImageExtension(image As Image) As String
            ' If the image is null, return an empty string.
            If image Is Nothing Then
                Return String.Empty
            End If

            Dim format As Imaging.ImageFormat = image.RawFormat

            ' Check the image format and return the corresponding file extension. If the format is not recognized, return an empty string.
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

        ''' <summary>
        ''' This subroutine is responsible for saving the employee record. It first checks for invalid inputs, duplicate employee numbers, and whether a photo has been selected. If any issues are found, it displays an error message and exits. If all checks pass, it sets the values of the employee properties and attempts to save the data using the PushData method. If the save is successful, it raises an event indicating that the record has been saved. If the "Add New" checkbox is checked, it clears the form for a new entry; otherwise, it closes the form.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Async Sub Save()
            Dim varInvalidScore As Integer = 0
            varCannotSaveMessage = String.Empty
            varInvalidScore += CheckInvalidInputs()
            varInvalidScore += CheckEmployeePersonalID()
            varInvalidScore += CheckDuplicateEmployeeNumber()
            varInvalidScore += CheckEmployeeNoPhoto()

            ' If any invalid inputs are found (i.e., the invalid score is greater than 0), display an error message indicating that certain fields have not been entered correctly and prompt the user to ensure that all required items are checked. The message includes a title and a list of the specific issues found. After displaying the message, the method returns without proceeding to save the data.
            If varInvalidScore > 0 Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varCannotSaveMessageTitle & Environment.NewLine & "Please ensure that the following item(s) have been checked:" & Environment.NewLine & varCannotSaveMessage, LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
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
                SetValue(.AllParameters, tEmployee.P_EmployeeCompanyEmail, IIf(TxtCompanyEmail.XOSqlText = String.Empty OrElse TxtCompanyEmail.XOSqlText = "", DBNull.Value, TxtCompanyEmail.XOSqlText))
                SetValue(.AllParameters, tEmployee.P_EmployeeIsActive, ChkActiveEmployee.Checked)

                ' Employment Type is filled automatically when user select the employment type
                ' from the browse form. If the user does not select an employment type, it will
                ' be set to DBNull.Value.
                SetValue(.AllParameters, tEmployee.P_EmployeeEmploymentType, IIf(TxtEmploymentType.XOSqlText = String.Empty OrElse TxtEmploymentType.XOSqlText = "", DBNull.Value, DBNull.Value))
            End With

            ' If the employee is new, set the EmployeeIsNew flag to True; otherwise, set it to False. This flag is used to determine whether the employee record is being created for the first time or if it is an existing record being updated.
            If Await CMDepls.Editor.PushData(varDataProperties, varDataProperties.AllParameters) Then
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            ' If the "Add New" checkbox is checked, clear the input fields for company, department, position, employment type, employee number, full name, and nickname to allow the user to enter a new employee record. If the checkbox is not checked, close the form after saving the current employee record.
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
        ''' This subroutine is an event handler for the "Cancel" menu item in the mainframe menu. When the "Cancel" option is selected, it triggers the form to close by calling the Close() method. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the cancel functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CancelEdit()
            Me.Close()
        End Sub


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

        ''' <summary>
        ''' This event handler is triggered when a record is selected in the FRMepls_AddinEmploymentType form. It retrieves the selected employment type's name from the AllParameters collection of varDataProperties and updates the TxtEmploymentType text field in the FRMeplsEditor form with this value.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsAddinEmploymentType_EventRecordSelected() Handles Frm_epls_AddinEmploymentType.EventRecordSelected
            With varDataProperties
                TxtEmploymentType.Text = .AllParameters(tEmploymentType.P_EmploymentTypeName).ToString
            End With
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the selected tab in the TbctlEmployee tab control changes. If the selected tab is the "Permissions" tab and it is the first time loading this tab, a message box is displayed to inform the user that the feature is not available yet and to contact the system administrator. The varIsTabPermissionFirstLoad flag is then set to False to prevent the message from appearing again on subsequent tab selections.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TbctlEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TbctlEmployee.SelectedIndexChanged
            ' If the selected tab is the "Permissions" tab and it is the first time loading this tab, display a message box to inform the user that the feature is not available yet and to contact the system administrator. Set the varIsTabPermissionFirstLoad flag to False to prevent the message from appearing again on subsequent tab selections.
            If TbctlEmployee.SelectedTab Is tpPermissions AndAlso varIsTabPermissionFirstLoad Then
                MsgBox("This feature is not available yet. Please contact your system administrator.", MsgBoxStyle.Information, "Feature Unavailable")
                varIsTabPermissionFirstLoad = False
            End If
        End Sub
    End Class
End Namespace