Namespace UI.Canvas
    ''' <summary>
    ''' This form is used to manage the company data in the system. It provides functionalities to add, edit, delete, and refresh company records. The form also includes a search feature to filter the displayed data based on user input.
    ''' </summary>
    Public Class FRMccin
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Private WithEvents Frm_ccin_Editor As New FRMccinEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CCIN"


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the FRMcompany form is loaded. It performs several initialization tasks, including loading the logo image from a specified URL, setting the active module to UserParameters, loading the menu strip, displaying menu data, applying color settings to the DataGridView, and retrieving initial data to populate the DataGridView. It also clears any existing search text in the TxtFind control and adjusts the row height of the DataGridView for better display.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_CCIN, XOLogo,, 512, 512, True, "Module")

            ' Set active module to UserParameters
            With varDataProperties
                SetValue(.AllParameters, tIngrid.P_ModuleCode, varThisModuleCode)
                varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
                SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
            End With

            ' Continue to Load anything for this module
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnCCIN.XOGetNewColor()
            Call GetData(True)
            CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, DgnCCIN)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the form is activated. It sets the active module identifier to the current module code and ID, ensuring that the application recognizes the current context as the company management module.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the form gains focus. It maximizes the window state of the form to ensure that it occupies the entire screen, providing an optimal view for managing company data.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccin_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Me.WindowState = FormWindowState.Maximized
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the form is closed. It disposes of the Com_mms_Menu object to free up resources and ensure proper cleanup of the menu strip associated with the form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            Com_mms_Menu.Dispose()
        End Sub


        ' ----------------------------------------------------------
        ' Other or Extended Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when a record is saved in the FRMccinEditor form. It calls the GetData method to refresh the displayed company data in the datagrid, ensuring that any changes made in the editor are reflected in the main form.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_RecordSaved() Handles Frm_ccin_Editor.EventRecordSaved
            ' Refresh the data in the datagrid after a record is saved in the editor form
            Call GetData(True)
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' Retrieves and displays the company data in the datagrid.
        ''' </summary>
        ''' <param name="forcerefresh">Indicates whether to force a refresh of the data.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnCCIN)
            varDataProperties.CompanyIsForceRefresh = forcerefresh
            CMDccin.View.DisplayData(varDataProperties, DgnCCIN, SLFStatus, TxtFind)
        End Sub

        ''' <summary>
        ''' This subroutine retrieves the ID of the currently selected company record in the datagrid. If no record is selected, it sets the CompanyIsNew property to True, indicating that a new company record is being added. If a record is selected, it retrieves the company ID from the selected row and stores it in the AllParameters collection for further processing.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            With varDataProperties
                If DgnCCIN.RowCount = 0 Then
                    .CompanyIsNew = True
                Else
                    .CompanyIsNew = False
                    SetValue(.AllParameters, tCompany.P_CompanyId, CLng(DgnCCIN.CurrentRow.Cells("company_id").Value))
                End If
            End With
        End Sub


        ' ---------------------------------------------------------
        ' Components Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the "Add New" option is selected from the menu. It checks if the user has the necessary permissions to add a new company record. If authorized, it initializes a new instance of the FRMccinEditor form for adding company data and displays it to the user. If not authorized, it shows an error message indicating that the user does not have permission to perform this action.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                .CompanyIsNew = True
                Frm_ccin_Editor = New FRMccinEditor
                With varDataProperties
                    .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                    .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                    .IngridFormTitle = "Add New Record"
                    .IngridFormSubtitle = "Add new company data"
                    .IngridFormIsDialog = True
                End With
                Display(Frm_ccin_Editor,, varDataProperties)
            End With
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Edit" option is selected from the menu. It checks if the user has the necessary permissions to edit an existing company record. If authorized, it retrieves the selected record's ID and initializes a new instance of the FRMccinEditor form for editing the company data. If no record is selected or if the user is not authorized, it shows an appropriate error message.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            ' Get the selected record's ID
            Call GetRowID()

            If varDataProperties.CompanyIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
            Else
                Frm_ccin_Editor = New FRMccinEditor
                With varDataProperties
                    .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                    .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                    .IngridFormTitle = "Update Record"
                    .IngridFormSubtitle = "Update your company data"
                    .IngridFormIsDialog = True
                End With
                Display(Frm_ccin_Editor,, varDataProperties)
            End If

            UI.Canvas.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Delete" option is selected from the menu. It checks if the user has the necessary permissions to delete an existing company record. If authorized, it retrieves the selected record's ID and prompts the user for confirmation before proceeding with the deletion. If no record is selected or if the user is not authorized, it shows an appropriate error message.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            ' Get the selected record's ID
            Call GetRowID()

            If varDataProperties.CompanyIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
            Else
                With DgnCCIN.CurrentRow
                    Dim varMessage As New System.Text.StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Company Code : " & .Cells("company_code").Value.ToString & Environment.NewLine &
                        "Company Name : " & .Cells("company_name").Value.ToString & Environment.NewLine &
                        "Search Term1 : " & .Cells("company_searchterm1").Value.ToString & Environment.NewLine &
                        "Search Term2 : " & .Cells("company_searchterm1").Value.ToString & Environment.NewLine &
                        "Description : " & .Cells("company_description").Value.ToString)

                    varMessage.AppendLine(varLine)

                    If Decision(My.Application.Info.AssemblyName.ToUpper, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso LibSQL.CMDccin.View.DeleteData(varDataProperties, varDatasetIngrid) Then
                        Call GetData(True)
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Delete failed"
                    End If
                End With
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Refresh" option is selected from the menu. It clears the search textbox and calls the GetData method to refresh the displayed company data in the datagrid. The forcerefresh parameter is set to True to ensure that the latest data is retrieved from the database.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()

            ' Force refresh the data in the datagrid
            Call GetData(True)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Close" option is selected from the menu. It closes the current form, effectively exiting the company management interface.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Find" option is selected from the menu. It sets the focus to the search textbox (TxtFind), allowing the user to quickly start typing their search query to filter the displayed company data in the datagrid.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when a key is pressed while the search textbox (TxtFind) has focus. If the Enter key is pressed, it calls the GetData method to refresh the displayed company data in the datagrid based on the current search query.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                ' Refresh the data in the datagrid based on the search query
                Call GetData()
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Clear" button (BtnClear) is clicked. It clears the search textbox (TxtFind), calls the GetData method to refresh the displayed company data in the datagrid, and clears any search filters applied to the datagrid.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()

            ' Refresh the data in the datagrid and clear any search filters
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub
    End Class
End Namespace