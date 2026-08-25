Namespace UI.Canvas
    Public Class FRMcdin

        Private WithEvents Frm_cdin_Editor As FRMcdinEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CDIN"

        ''' <summary>
        ''' Retrieves the data for the current department.
        ''' </summary>
        ''' <param name="forcerefresh">Indicates whether to force a refresh of the data.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnCDIN)
            varDataProperties.DepartmentIsForceRefresh = forcerefresh
            LibSQL.CMDcdin.View.DisplayData(varDataProperties, DgnCDIN, SLFStatus, TxtFind)
        End Sub

        ''' <summary>
        ''' Retrieves the ID of the currently selected row in the DgnCDIN DataGridView and updates the varDataProperties accordingly.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            With varDataProperties
                If DgnCDIN.RowCount = 0 Then
                    .DepartmentIsNew = True
                Else
                    .DepartmentIsNew = False
                    SetValue(.AllParameters, tDepartment.P_DepartmentId, CLng(DgnCDIN.CurrentRow.Cells(tDepartment.C_DepartmentId).Value))
                End If
            End With
        End Sub

        ''' <summary>
        ''' Handles the event when a new department record is added. It sets the DepartmentIsNew property to True and opens the FRMcdinEditor form for adding a new record.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.DepartmentIsNew = True
            Frm_cdin_Editor = New FRMcdinEditor
            Display(Frm_cdin_Editor, ImageDb.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new departement data", True)
        End Sub

        ''' <summary>
        ''' Handles the event when an existing department record is edited. It retrieves the ID of the selected row and opens the FRMcdinEditor form for updating the record. If no record is selected, it displays an error message.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            Call GetRowID()
            If varDataProperties.DepartmentIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_cdin_Editor = New FRMcdinEditor
                Display(Frm_cdin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your departement data", True)
            End If
            UI.Canvas.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        ''' <summary>
        ''' Handles the event when a department record is deleted. It retrieves the ID of the selected row and prompts the user for confirmation before deleting the record. If no record is selected, it displays an error message.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            Call GetRowID()
            If varDataProperties.DepartmentIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnCDIN.CurrentRow
                    Dim varMessage As New System.Text.StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As String = New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Department ID : " & .Cells("department_id").Value.ToString & Environment.NewLine &
                        "Department Code : " & .Cells("department_code").Value.ToString & Environment.NewLine &
                        "Department Name : " & .Cells("department_name").Value.ToString & Environment.NewLine &
                        "Description : " & .Cells("department_description").Value.ToString)

                    varMessage.AppendLine(varLine)

                    If Decision(My.Application.Info.AssemblyName.ToUpper, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso (LibSQL.CMDcdin.View.DeleteData(varDataProperties, varDatasetIngrid)) Then
                        Call GetData(True)
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Delete failed"
                    End If
                End With
            End If
        End Sub

        ''' <summary>
        ''' Handles the event when the data is refreshed. It clears the search textbox and retrieves the latest data for the current department.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        ''' <summary>
        ''' Handles the event when the data view is closed. It closes the current form.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        ''' <summary>
        ''' Handles the event when the find tool is activated. It sets the focus to the TxtFind textbox for searching.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

        ''' <summary>
        ''' Handles the Load event of the FRMcdin form. It sets the active module to UserParameters, retrieves the module ID, and initializes the menu and data grid. It also clears the search textbox and retrieves the initial data for the current department.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            SLFLogo.Image = CMCv.ImageEditor.File.GetImage.ConvertSvgToBmp($"\Resources\svg-{varThisModuleCode}.svg", True, 512, 512)

            ' Set active module to UserParameters
            With varDataProperties
                SetValue(.AllParameters, tIngrid.P_ModuleCode, varThisModuleCode)
                varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
                SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
            End With

            ' Continue to Load anything for this module
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnCDIN.XOGetNewColor()
            Call GetData(True)
            TxtFind.ClearSearch()
            DatagridBehaviour.AdaptiveRowHeight(Me, DgnCDIN)
        End Sub

        ''' <summary>
        ''' Handles the KeyDown event of the TxtFind textbox. If the Enter key is pressed, it retrieves the data for the current department based on the search criteria entered in the TxtFind textbox.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the BtnClear button. It clears the TxtFind textbox, retrieves the data for the current department, and clears the search criteria in the TxtFind textbox.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        ''' <summary>
        ''' Handles the event when a record is saved in the FRMcdinEditor form. It retrieves the latest data for the current department after a record is saved.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdinEditor_RecordSaved() Handles Frm_cdin_Editor.EventRecordSaved
            Call GetData()
        End Sub

        ''' <summary>
        ''' Handles the GotFocus event of the FRMcdin form. It maximizes the window state of the form when it receives focus.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdin_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Me.WindowState = FormWindowState.Maximized
        End Sub

        ''' <summary>
        ''' Handles the Activated event of the FRMcdin form. It sets the active module to UserParameters when the form is activated.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub
    End Class
End Namespace