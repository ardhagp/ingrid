Imports System.Text

Namespace UI.Canvas
    Public Class FRMpost
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Private WithEvents Frm_post_Editor As New FRMpostEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "POST"


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the FRMpost form is loaded. It performs several initialization tasks, including loading the logo image from a specified URL, setting the active module to UserParameters, loading the menu strip, displaying menu data, applying color settings to the DataGridView, and retrieving initial data to populate the DataGridView. It also clears any existing search text in the TxtFind control and adjusts the row height of the DataGridView for better display.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_POST, XOLogo,, 512, 512, True, "Module")

            ' Set active module to UserParameters
            With varDataProperties
                SetValue(.AllParameters, tModule.P_ModuleCode, varThisModuleCode)
                varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
                SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
            End With

            ' Continue to Load anything for this module
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnPOST.XOGetNewColor()
            Call GetData(True)
            TxtFind.ClearSearch()
            CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, DgnPOST)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the FRMpost form is activated. It sets the active module to UserParameters by updating the AllParameters collection with the current module code. This ensures that the application recognizes the FRMpost form as the active module for any subsequent operations or interactions.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpost_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the FRMpost form receives focus. It maximizes the window state of the form to ensure that it occupies the entire screen, providing an optimal view for the user to interact with the form's contents.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpost_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Me.WindowState = FormWindowState.Maximized
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the FRMpost form is closed. It disposes of the Com_mms_Menu object, which is responsible for managing the menu strip associated with the form. Disposing of this object helps to free up resources and ensure that any event handlers or references associated with the menu strip are properly cleaned up when the form is no longer in use.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpost_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
            Com_mms_Menu.Dispose()
        End Sub


        ' ----------------------------------------------------------
        ' Other or Extended Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when a record is saved in the FRMpostEditor form. It calls the GetData method with the forcerefresh parameter set to True, which refreshes the data displayed in the DgnPOST DataGridView to reflect any changes made during the record editing process. This ensures that the user sees the most up-to-date information after saving a record.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_RecordSaved() Handles Frm_post_Editor.EventRecordSaved
            Call GetData(True)
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This method retrieves employee position data and displays it in the DgnPOST DataGridView. It can optionally force a refresh of the data, ensuring that the latest information is shown to the user. The method uses double buffering for smoother rendering of the DataGridView and updates the status label accordingly.
        ''' </summary>
        ''' <param name="forcerefresh"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnPOST)
            varDataProperties.EmployeePositionIsForceRefresh = forcerefresh
            CMDpost.View.DisplayData(varDataProperties, DgnPOST, SLFStatus, TxtFind)
        End Sub

        ''' <summary>
        ''' This method retrieves the ID of the currently selected employee position in the DgnPOST DataGridView. If there are no rows in the DataGridView, it sets the EmployeePositionIsNew property to True, indicating that a new position is being added. If a row is selected, it sets the EmployeePositionIsNew property to False and updates the AllParameters collection with the selected position's ID. This allows other parts of the application to know whether a new position is being created or an existing one is being edited.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            With varDataProperties
                If DgnPOST.RowCount = 0 Then
                    .EmployeePositionIsNew = True
                Else
                    .EmployeePositionIsNew = False
                    SetValue(.AllParameters, tPosition.P_PositionId, CLng(DgnPOST.CurrentRow.Cells(tPosition.C_PositionId).Value))
                End If
            End With
        End Sub


        ' ---------------------------------------------------------
        ' Components Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the user selects the "Add New" option from the menu. It checks if the user has the necessary permissions to add a new employee position record. If authorized, it initializes a new instance of the FRMpostEditor form for adding a new record, sets the appropriate properties for the form, and displays it as a dialog. If the user is not authorized, it shows an error message indicating that they do not have permission to add a new record.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                .EmployeePositionIsNew = True
                Frm_post_Editor = New FRMpostEditor
                .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                .IngridFormTitle = "Add New Record"
                .IngridFormSubtitle = "Add new job position data"
                .IngridFormIsDialog = True
                Display(Frm_post_Editor,, varDataProperties)
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                ' Get the ID of the current position in the DataGridView
                Call GetRowID()

                If .EmployeePositionIsNew Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "No Record Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Else
                    Frm_post_Editor = New FRMpostEditor
                    .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                    .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                    .IngridFormTitle = "Update Record"
                    .IngridFormSubtitle = "Update your position data"
                    .IngridFormIsDialog = True
                    Display(Frm_post_Editor,, varDataProperties)
                End If
                UI.Canvas.FRMmainframe6.Ts_status.Text = String.Empty
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                ' Get the ID of the current position in the DataGridView
                Call GetRowID()

                If .EmployeePositionIsNew Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "No Record Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Else
                    With DgnPOST.CurrentRow
                        Dim varMessage As New StringBuilder()
                        varMessage.AppendLine("Do you want to delete this record?")

                        Dim varLine As New String("─"c, 80)
                        varMessage.AppendLine(varLine)

                        varMessage.AppendLine($"Position Code : " & .Cells("position_code").Value.ToString & Environment.NewLine &
                                "Position Name : " & .Cells("position_name").Value.ToString & Environment.NewLine &
                                "Company : " & .Cells("company_name").Value.ToString & Environment.NewLine &
                                "Department : " & .Cells("department_name").Value.ToString)

                        varMessage.AppendLine(varLine)
                        If Decision(My.Application.Info.AssemblyName.ToUpper, varMessage.ToString, LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso (LibSQL.CMDpost.View.DeleteData(varDataProperties, varDatasetIngrid)) Then
                            Call GetData(True)
                            UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                        Else
                            UI.Canvas.FRMmainframe6.Ts_status.Text = "Delete failed"
                        End If
                    End With
                End If
            End With
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the user selects the "Refresh" option from the menu. It clears any existing search text in the TxtFind control and calls the GetData method with the forcerefresh parameter set to True, which refreshes the data displayed in the DgnPOST DataGridView to show the latest employee position records. This ensures that the user sees the most up-to-date information after performing a refresh action.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the user selects the "Close" option from the menu. It closes the FRMpost form, effectively terminating the current session and returning control to the parent form or application. This allows the user to exit the employee position management interface gracefully.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the user selects the "Find" option from the menu. It sets the focus to the TxtFind control, allowing the user to immediately start typing a search query to filter the employee position records displayed in the DgnPOST DataGridView. This enhances the user experience by providing a quick and convenient way to initiate a search operation.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when a key is pressed while the TxtFind control has focus. If the Enter key is pressed, it calls the GetData method to refresh the data displayed in the DgnPOST DataGridView based on the search query entered by the user. This allows for quick and efficient searching of employee position records without requiring additional button clicks.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                ' Refresh the data in the DataGridView based on the search query
                Call GetData()
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Clear" button is clicked. It clears any existing search text in the TxtFind control, calls the GetData method with the forcerefresh parameter set to True to refresh the data displayed in the DgnPOST DataGridView, and clears any search highlights or filters applied to the DataGridView. This allows the user to reset the view and see all employee position records without any search constraints.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub
    End Class
End Namespace