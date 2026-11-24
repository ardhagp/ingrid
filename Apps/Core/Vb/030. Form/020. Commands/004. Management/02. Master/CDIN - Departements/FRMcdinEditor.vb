Namespace UI.Canvas
    Public Class FRMcdinEditor
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Public Event EventRecordSaved()
        Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CDIN"


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This subroutine is an event handler for the form's Activated event. It sets the active module identifier to the current module code and ID, ensuring that the application recognizes the current context as the Department module. This is important for managing user permissions and interactions within the application. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdinEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set the active module identifier to the current module code and ID, ensuring that the application recognizes the current context as the Department module. This is important for managing user permissions and interactions within the application.
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the form's Load event. It initializes the form by loading the logo image, setting up the mainframe menu, and configuring the initial state of the form based on whether a new department record is being created or an existing one is being edited. It also sets default values for certain fields and prepares the form for user interaction.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EDIT, XOLogo,, 512, 512, True, "Module")

            ' Set up the mainframe menu and display it on the form
            ComponentMainframeMenu.LoadIn(Me, True)
            ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            ' Fill the company combo box with available companies and set the initial state of the form based on whether a new department is being created or an existing one is being edited
            Call FillCompany(CboCompany)

            ' If the department is new, show the "Add New" checkbox and clear the input fields; otherwise, hide the checkbox and load the existing department data into the form's input fields
            If varDataProperties.DepartmentIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False

                ' Load the existing department data into the form's input fields
                Call LoadData()
            End If
        End Sub


        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This subroutine is an event handler for the "Save" menu item in the mainframe menu. When the "Save" option is selected, it calls the Save() method to save the current data. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the save functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileSave() Handles ComponentMainframeMenu.EventFileSave
            ' Call the Save() method to save the current data when the "Save" menu item is clicked in the mainframe menu
            Call Save()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Undo" menu item in the mainframe menu. When the "Undo" option is selected, it prompts the user with a decision dialog asking if they want to undo all changes. If the user confirms, it checks whether the department is new or existing. If it's new, it clears the input fields for department code, name, and description. If it's an existing department, it reloads the data to revert any changes made. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the undo functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileUndo() Handles ComponentMainframeMenu.EventFileUndoAll
            ' Prompt the user with a decision dialog asking if they want to undo all changes. If the user confirms, check whether the department is new or existing. If it's new, clear the input fields for department code, name, and description. If it's an existing department, reload the data to revert any changes made.
            If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.UndoChanges, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If (varDataProperties.DepartmentIsNew) Then
                    TxtDeptCode.Clear()
                    TxtDeptName.Clear()
                    TxtDescription.Clear()
                Else
                    ' Reload the data to revert any changes made to the existing department record
                    Call LoadData()
                End If
            End If
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Cancel" menu item in the mainframe menu. When the "Cancel" option is selected, it triggers the form to close by calling the Close() method. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the cancel functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileCancel() Handles ComponentMainframeMenu.EventFileCancel
            ' Handle the cancel menu item click event by calling the CancelEdit() method to cancel any changes and close the form
            Call CancelEdit()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Save" button click event. When the "Save" button is clicked, it calls the Save() method to initiate the process of saving the department record. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the save functionality is only executed in a compatible environment.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            ' Handle the save button click event by calling the Save() method to save the department record
            Call Save()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Cancel" button click event. When the "Cancel" button is clicked, it calls the CancelEdit() method to handle the cancellation of any changes made in the form and close the form. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the cancel functionality is only executed in a compatible environment.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            ' Handle the cancel button click event by calling the CancelEdit() method to cancel any changes and close the form
            Call CancelEdit()
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This subroutine loads the department data into the form's input fields. It retrieves the department properties from the data source and populates the company combo box, department code, name, and description text boxes with the corresponding values. This allows users to view and edit existing department records. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LoadData()
            ' Fill the company combo box and department combo box with available options
            CMDcdin.Editor.GetDepartmentProperties(varDataProperties, varDatasetIngrid)

            ' If the department dataset contains records, populate the form's input fields with the corresponding values for company, department code, name, and description
            If varDatasetIngrid.Tables(tDepartment.TableName).Rows.Count > 0 Then
                With varDatasetIngrid.Tables(tDepartment.TableName).Rows(0)
                    CboCompany.SelectedValue = .Item(tDepartment.C_DepartmentCompany).ToString
                    TxtDeptCode.Text = .Item(tDepartment.C_DepartmentCode).ToString
                    TxtDeptName.Text = .Item(tDepartment.C_DepartmentName).ToString
                    TxtDescription.Text = .Item(tDepartment.C_DepartmentDescription).ToString
                End With
            End If
        End Sub

        ''' <summary>
        ''' This subroutine fills the company combo box with available company options. It calls the FillCompany method from the CMDcdin.Editor class, passing in the data properties and the combo box control. This allows users to select a company when creating or editing a department record. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms.
        ''' </summary>
        ''' <param name="company">The combo box control to be filled with company options.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FillCompany(company As CMCv.UI.Control.Cbo)
            ' Fill the company combo box with available company options by calling the FillCompany method from the CMDcdin.Editor class, passing in the data properties and the combo box control. This allows users to select a company when creating or editing a department record.
            CMDcdin.Editor.FillCompany(varDataProperties, company)
        End Sub

        ''' <summary>
        ''' This function checks for invalid input in the department code and department name fields. It focuses on each field and verifies if they are empty. If any of the fields are empty, it increments an invalid score counter. The function returns True if there are invalid inputs (i.e., if the invalid score is greater than 0), indicating that the form cannot be saved due to missing required information. If all required fields are filled, it returns False, allowing the save operation to proceed. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms.
        ''' </summary>
        ''' <returns>True if there are invalid inputs; otherwise, False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckInvalidInput() As Boolean
            Dim varInvalidScore As Integer = 0

            TxtDeptCode.Focus()
            ' Check if the department code field is empty and increment the invalid score if it is
            If TxtDeptCode.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            TxtDeptName.Focus()
            ' Check if the department name field is empty and increment the invalid score if it is
            If TxtDeptName.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If

            ' Return True if there are invalid inputs (i.e., the invalid score is greater than 0); otherwise, return False
            If varInvalidScore = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' This subroutine is responsible for saving the department record. It first checks for invalid inputs and duplicate department codes. If any issues are found, it displays an error message and exits. If all checks pass, it sets the values of the department properties and attempts to save the data using the PushData method. If the save is successful, it raises an event indicating that the record has been saved. If the "Add New" checkbox is checked, it clears the form for a new entry; otherwise, it closes the form.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Save()
            ' Check for invalid input in the department code and name fields
            If CheckInvalidInput() Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable to save your record." & Environment.NewLine & "Please verify that both the Department Code and Department Name fields have been entered correctly.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyId, CLng(CboCompany.SelectedValue))
                SetValue(.AllParameters, tDepartment.P_DepartmentCode, IIf(TxtDeptCode.XOSqlText = String.Empty OrElse TxtDeptCode.XOSqlText = "", DBNull.Value, TxtDeptCode.XOSqlText))
                SetValue(.AllParameters, tDepartment.P_DepartmentName, IIf(TxtDeptName.XOSqlText = String.Empty OrElse TxtDeptName.XOSqlText = "", DBNull.Value, TxtDeptName.XOSqlText))
                SetValue(.AllParameters, tDepartment.P_DepartmentDescription, IIf(TxtDescription.XOSqlText = String.Empty OrElse TxtDescription.XOSqlText = "", DBNull.Value, TxtDescription.XOSqlText))
            End With

            ' Check if the company combo box is empty or if the department code or name fields are empty
            If (CboCompany.Items.Count = 0) AndAlso (varDataProperties.AllParameters("@DepartmentCode").ToString = String.Empty) OrElse (varDataProperties.AllParameters("@DepartmentName").ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Ensure that the Company Code is selected and that both the Department Code and Department Name are properly filled in.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.DepartmentIsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Department Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.DepartmentIsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Department Code cannot be used because it is already assigned to another company.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            ' Attempt to save the department data and raise an event if successful
            If (CMDcdin.Editor.PushData(varDataProperties)) Then
                RaiseEvent EventRecordSaved()
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            ' If the "Add New" checkbox is checked, clear the form for a new entry; otherwise, close the form
            If ChkAddNew.Checked Then
                CboCompany.SelectedIndex = 0
                TxtDeptCode.Clear()
                TxtDeptName.Clear()
                TxtDescription.Clear()
                CboCompany.Focus()
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
    End Class
End Namespace