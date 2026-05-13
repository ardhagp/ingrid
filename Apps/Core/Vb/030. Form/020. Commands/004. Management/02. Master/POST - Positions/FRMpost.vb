Imports System.Runtime.Versioning
Imports System.Text

Namespace UI
    Public Class FRMpost
#Region "Declaration"
        Private WithEvents Frm_post_Editor As New FRMpostEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        'Parameters
        Private Const pCommand As String = "@Command"
        Private Const pPositionId As String = "@PositionId"
#End Region

#Region "Subs Collections"
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnPOST)
            varDataProperties.EmployeePositionIsForceRefresh = forcerefresh
            CMDpost.View.DisplayData(varDataProperties, DgnPOST, SLFStatus, TxtFind)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varDataProperties.AllParameters.Remove(pPositionId)
            If DgnPOST.RowCount = 0 Then
                varDataProperties.EmployeePositionIsNew = True
            Else
                varDataProperties.EmployeePositionIsNew = False
                varDataProperties.AllParameters.Add(pPositionId, CLng(DgnPOST.CurrentRow.Cells("position_id").Value))
            End If
        End Sub
#End Region

#Region "Menu Strip Functions"
        <SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "POST")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varDataProperties.EmployeePositionIsNew = True
            Frm_post_Editor = New FRMpostEditor
            Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new job position data", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "POST")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.EmployeePositionIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No Record Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_post_Editor = New FRMpostEditor
                Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your position data", True)
            End If
            UI.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "POST")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.EmployeePositionIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No Record Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnPOST.CurrentRow
                    Dim varMessage As New StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As String = New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Employee ID : " & .Cells("employee_number").Value.ToString & Environment.NewLine &
                            "Employee Name : " & .Cells("employee_fullname").Value.ToString & Environment.NewLine &
                            "Company : " & .Cells("company_name").Value.ToString & Environment.NewLine &
                            "Department : " & .Cells("department_name").Value.ToString & Environment.NewLine &
                            "Position : " & .Cells("positition_name").Value.ToString & Environment.NewLine &
                            "Grade : " & .Cells("grade_code").Value.ToString)

                    varMessage.AppendLine(varLine)
                    If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso (LibSQL.CMDpost.View.DeleteData(varDataProperties, varDatasetIngrid)) Then
                        Call GetData(True)
                        UI.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.FRMmainframe6.Ts_status.Text = "Delete failed"
                    End If
                End With
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMpost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnPOST.XOGETNewColor()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_RecordSaved() Handles Frm_post_Editor.EventRecordSaved
            Call GetData(True)
        End Sub

#Region "UNUSED : CreateMenu"
        '<SupportedOSPlatform("windows")>
        'Private Sub CreateMenu()
        '    Dim varCommmsMenu As New CMCv.UI.Control.mnu
        '    Dim varItem As ToolStripMenuItem()
        '    Dim varItemSubmenu As ToolStripMenuItem()
        '    Dim varItemSeparator As ToolStripSeparator()

        '    ReDim varItem(2)
        '    varCommmsMenu.Visible = False

        '    varItem(0) = New ToolStripMenuItem() With {.Name = "DATAToolStripMenuItem", .Text = "DATA", .MergeAction = MergeAction.Insert, .MergeIndex = 1}
        '    varCommmsMenu.Items.Add(varItem(0))

        '    varItem(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
        '    varCommmsMenu.Items.Add(varItem(1))

        '    Me.Controls.Add(varCommmsMenu)

        '    ReDim varItemSubmenu(8)
        '    ReDim varItemSeparator(4)

        '    For Each varEachSubItem As ToolStripMenuItem In varCommmsMenu.Items

        '        Select Case varEachSubItem.Name
        '            Case "DATAToolStripMenuItem"
        '                'Insert "Add New..."
        '                varItemSubmenu(0) = New ToolStripMenuItem() With {.Name = "AddNewToolStripMenuItem", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(0))
        '                AddHandler varItemSubmenu(0).Click, AddressOf AddNewToolStripMenuItem_Clicked

        '                'Insert "Edit..."
        '                varItemSubmenu(1) = New ToolStripMenuItem() With {.Name = "EditToolStripMenuItem", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(1))
        '                AddHandler varItemSubmenu(1).Click, AddressOf EditToolStripMenuItem_Clicked

        '                'Insert "Delete..."
        '                varItemSubmenu(2) = New ToolStripMenuItem() With {.Name = "DeleteToolStripMenuItem", .Text = "Delete", .ShortcutKeys = Keys.Delete, .ShortcutKeyDisplayString = "Del"}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(2))
        '                AddHandler varItemSubmenu(2).Click, AddressOf DeleteToolStripMenuItem_Clicked

        '                'Insert "Separator"
        '                varItemSeparator(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
        '                varEachSubItem.DropDown.Items.Add(varItemSeparator(0))

        '                'Insert "Refresh"
        '                varItemSubmenu(3) = New ToolStripMenuItem() With {.Name = "RefreshToolStripMenuItem", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(3))
        '                AddHandler varItemSubmenu(3).Click, AddressOf RefreshToolStripMenuItem_Clicked

        '                'Insert "Separator"
        '                varItemSeparator(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
        '                varEachSubItem.DropDown.Items.Add(varItemSeparator(1))

        '                'Insert "Close"
        '                varItemSubmenu(4) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.Q, Keys), .ShortcutKeyDisplayString = "Ctrl+Q"}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(4))
        '                AddHandler varItemSubmenu(4).Click, AddressOf CloseToolStripMenuItem_Clicked

        '            Case "TOOLSToolStripMenuItem"
        '                'Insert "Import"
        '                varItemSubmenu(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(5))
        '                AddHandler varItemSubmenu(5).Click, AddressOf ImportToolStripMenuItem_Clicked

        '                'Insert "Export"
        '                varItemSubmenu(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(6))
        '                AddHandler varItemSubmenu(6).Click, AddressOf ExportToolStripMenuItem_Clicked

        '                'Insert "Separator"
        '                varItemSeparator(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
        '                varEachSubItem.DropDown.Items.Add(varItemSeparator(2))

        '                'Insert "Find"
        '                varItemSubmenu(7) = New ToolStripMenuItem() With {.Name = "FindToolStripMenuItem", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
        '                varEachSubItem.DropDown.Items.Add(varItemSubmenu(7))
        '                AddHandler varItemSubmenu(7).Click, AddressOf FindToolStripMenuItem_Clicked
        '        End Select
        '    Next
        'End Sub
#End Region

#Region "UNUSED : CreateMenu_Events"
        '<SupportedOSPlatform("windows")>
        'Private Sub AddNewToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        Try
        '            If Not (varUserAccess.User(varDataProperties, "POST", varDataProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
        '                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '                Return
        '            End If

        '            varDataProperties.EmployeePositionIsNew = True
        '            varDataProperties.EmployeePositionId = "-1"

        '            Frm_post_Editor = New FRMpostEditor
        '            Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new employee data", True)
        '        Catch ex As Exception
        '            MsgBox(ex.ToString)
        '        End Try
        '    End If
        'End Sub

        '<SupportedOSPlatform("windows")>
        'Private Sub EditToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        Try
        '            If Not (varUserAccess.User(varDataProperties, "POST", varDataProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
        '                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '                Return
        '            End If

        '            Call GetRowID()
        '            varDataProperties.EmployeePositionIsNew = False
        '            If Convert.ToString(varDataProperties.EmployeePositionId) = "-1" Then
        '                Decision(My.Application.Info.AssemblyName.ToUpper, "No File Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '            Else
        '                varDataProperties.EmployeePositionIsNew = False
        '                Frm_post_Editor = New FRMpostEditor
        '                Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your employee data", True)
        '            End If
        '        Catch ex As Exception
        '            MsgBox(ex.ToString)
        '        End Try
        '    End If
        'End Sub

        '<SupportedOSPlatform("windows")>
        'Private Sub DeleteToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item Is Nothing Then Return

        '    Try
        '        ' Authorization check early-return
        '        If Not varUserAccess.User(varDataProperties, "POST", varDataProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete) Then
        '            Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '            Return
        '        End If

        '        ' Resolve current row id once
        '        Call GetRowID()
        '        Dim rowId As String = Convert.ToString(varDataProperties.EmployeePositionId)
        '        If rowId = "-1" Then
        '            Decision(My.Application.Info.AssemblyName.ToUpper, "No File Selected", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '            Return
        '        End If

        '        ' Confirm delete
        '        Dim userChoice = Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo)
        '        If userChoice <> Windows.Forms.DialogResult.Yes Then Return

        '        ' Perform delete and update UI accordingly
        '        'Dim deleted As Boolean = CMDpost.View.DeleteData(varDataProperties, varDatasetIngrid)
        '        'If deleted Then
        '        '    Call GetData(True)
        '        '    UI.FRMmainframe6.Ts_status.Text = "Success"
        '        'Else
        '        '    UI.FRMmainframe6.Ts_status.Text = "Delete failed"
        '        'End If

        '        'Obsolete
        '        'If item IsNot Nothing Then
        '        '    If Not (varUserAccess.User(varDatabaseName, "POST", varDataProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
        '        '        Decision(My.Application.Info.AssemblyName.toupper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '        '        Return
        '        '    End If

        '        '    Call GetRowID()
        '        '    If Convert.ToString(varDataProperties.RowID) = "-1" Then
        '        '        Decision(My.Application.Info.AssemblyName.toupper, "No File Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        '        '    Else
        '        '        If Decision(My.Application.Info.AssemblyName.toupper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = system.Windows.Forms.DialogResult.Yes Then
        '        '            If CMDpost.View.DeleteData(varDataProperties, Convert.ToString(varDataProperties.RowID)) Then
        '        '                Call GetData(True)
        '        '                FRMmainframe6.Ts_status.Text = "Success"
        '        '            Else
        '        '                FRMmainframe6.Ts_status.Text = "Delete failed"
        '        '            End If
        '        '        End If
        '        '    End If
        '        'End If
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        'End Sub

        '<SupportedOSPlatform("windows")>
        'Private Sub RefreshToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        Call GETDATA()
        '    End If
        'End Sub

        'Private Sub CloseToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        Me.Close()
        '    End If
        'End Sub

        'Private Sub ImportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        'Code for import
        '    End If
        'End Sub

        'Private Sub ExportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        'Code for export
        '    End If
        'End Sub

        'Private Sub FindToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        '    If item IsNot Nothing Then
        '        TxtFind.Focus()
        '    End If
        'End Sub

#End Region

    End Class
End Namespace