Namespace UI.Canvas
    ''' <summary>
    ''' This is the main form for the Employee List module. It provides functionalities to view, add, edit, delete, and refresh employee records. The form interacts with the underlying data properties and handles user access permissions for various operations. It also includes a search feature to filter employee records based on user input.
    ''' </summary>
    Public Class FRMepls
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Private WithEvents Frm_epls_Editor As New FRMeplsEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "EPLS"


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMepls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'SLFLogo.Image = CMCv.ImageEditor.File.GetImage.ConvertSvgToBmp($"\Resources\svg-{varThisModuleCode}.svg", True, 512, 512)
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EPLS, SLFLogo,, 512, 512)

            ' Set active module to UserParameters
            With varDataProperties
                SetValue(.AllParameters, tIngrid.P_ModuleCode, varThisModuleCode)
                varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
                SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
            End With

            ' Continue to Load anything for this module
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnEPLS.XOGetNewColor()
            Call GetData()
            TxtFind.ClearSearch()
            CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, DgnEPLS)
        End Sub

        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This method retrieves employee data and displays it in the DataGridView. It can optionally force a refresh of the data, ensuring that the latest information is shown to the user. The method uses double buffering for smoother rendering of the DataGridView and updates the status label accordingly.
        ''' </summary>
        ''' <param name="forcerefresh"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnEPLS)
            varDataProperties.EmployeeIsForceRefresh = forcerefresh
            CMDepls.View.DisplayData(varDataProperties, DgnEPLS, SLFStatus, TxtFind)
        End Sub

        ''' <summary>
        ''' This method retrieves the ID of the currently selected employee in the DataGridView. If no employee is selected, it sets the EmployeeIsNew property to True, indicating that a new employee record is being added. If an employee is selected, it retrieves the EmployeeId from the current row and stores it in the AllParameters collection for further processing.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            With varDataProperties
                If DgnEPLS.RowCount = 0 Then
                    .EmployeeIsNew = True
                Else
                    .EmployeeIsNew = False
                    SetValue(.AllParameters, tEmployee.P_EmployeeId, CLng(DgnEPLS.CurrentRow.Cells(tEmployee.C_EmployeeId).Value))
                End If
            End With
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Add New" option is selected from the menu. It checks if the user has the necessary permissions to add a new employee record. If authorized, it initializes a new instance of the FRMeplsEditor form for adding employee data and displays it to the user. If not authorized, it shows an error message indicating that the user does not have permission to perform this action.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                .EmployeeIsNew = True
                Frm_epls_Editor = New FRMeplsEditor
                Display(Frm_epls_Editor, ImageDb.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new employee data", True)
            End With
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Edit" option is selected from the menu. It checks if the user has the necessary permissions to edit an existing employee record. If authorized, it retrieves the ID of the currently selected employee and initializes a new instance of the FRMeplsEditor form for editing employee data. If no employee is selected or if the user is not authorized, it shows an appropriate error message.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.EmployeeIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_epls_Editor = New FRMeplsEditor
                Display(Frm_epls_Editor, ImageDb.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your employee data", True)
            End If

            ClearMainFrameFooterText()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Delete" option is selected from the menu. It checks if the user has the necessary permissions to delete an existing employee record. If authorized, it retrieves the ID of the currently selected employee and prompts the user for confirmation before proceeding with the deletion. If no employee is selected or if the user is not authorized, it shows an appropriate error message.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.EmployeeIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnEPLS.CurrentRow
                    Dim varMessage As New System.Text.StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Employee ID : " & .Cells("employee_number").Value.ToString & Environment.NewLine &
                            "Employee Name : " & .Cells("employee_fullname").Value.ToString & Environment.NewLine &
                            "Company : " & .Cells("company_name").Value.ToString & Environment.NewLine &
                            "Department : " & .Cells("department_name").Value.ToString & Environment.NewLine &
                            "Position : " & .Cells("position_name").Value.ToString & Environment.NewLine)

                    varMessage.AppendLine(varLine)
                    If Decision(My.Application.Info.AssemblyName.ToUpper, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso (LibSQL.CMDepls.View.DeleteData(varDataProperties, varDatasetIngrid)) Then
                        Call GetData(True)
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Delete failed"
                    End If
                End With
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Refresh" option is selected from the menu. It clears the search text box and refreshes the employee data displayed in the DataGridView, ensuring that the latest information is shown to the user.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Close" option is selected from the menu. It closes the current form, effectively exiting the Employee List module.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Find" option is selected from the menu. It sets the focus to the TxtFind text box, allowing the user to quickly start typing their search query.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub


        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_RecordSaved() Handles Frm_epls_Editor.EventRecordSaved
            Call GetData()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMepls_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Me.WindowState = FormWindowState.Maximized
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMepls_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub

    End Class
End Namespace