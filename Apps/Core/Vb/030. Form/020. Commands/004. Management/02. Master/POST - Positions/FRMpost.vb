Imports System.Runtime.Versioning

Public Class FRMpost
#Region "Variables"
    Private WithEvents Frm_post_Editor As New FRMpostEditor
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

    Const varMessageNoRecordSelected As String = "No record selected"
    Const varMessageError As String = "Error"
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        CMDpost.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnPOST, SLFStatus, TxtFind, forcerefresh)
    End Sub

    Private Sub GetRowID()
        varFormProperties.RowID = "-1"

        If DgnPOST.RowCount > 0 Then
            varFormProperties.RowID = DgnPOST.CurrentRow.Cells("position_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        Frm_post_Editor = New FRMpostEditor
        Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new job position data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        Call GetRowID()
        varFormProperties.IsNew = False
        Frm_post_Editor = New FRMpostEditor
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(varMessageNoRecordSelected, varMessageError, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your position data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        Call GetRowID()

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(varMessageNoRecordSelected, varMessageError, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (CMDpost.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))) Then
                    Call GetData(True)
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
    End Sub

    Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventDataFind() Handles Com_mms_Menu.EventToolsFind
        TxtFind.Focus()
    End Sub

#End Region

    <SupportedOSPlatform("windows")>
    Private Sub FRMpost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        Com_mms_Menu.ShowMenuData(UI.View.MenuStrip.ShowItem.Yes)
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
    <SupportedOSPlatform("windows")>
    Private Sub CreateMenu()
        Dim varCommmsMenu As New CMCv.mnu
        Dim varItem As ToolStripMenuItem()
        Dim varItemSubmenu As ToolStripMenuItem()
        Dim varItemSeparator As ToolStripSeparator()

        ReDim varItem(2)
        varCommmsMenu.Visible = False

        varItem(0) = New ToolStripMenuItem() With {.Name = "DATAToolStripMenuItem", .Text = "DATA", .MergeAction = MergeAction.Insert, .MergeIndex = 1}
        varCommmsMenu.Items.Add(varItem(0))

        varItem(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
        varCommmsMenu.Items.Add(varItem(1))

        Me.Controls.Add(varCommmsMenu)

        ReDim varItemSubmenu(8)
        ReDim varItemSeparator(4)

        For Each varEachSubItem As ToolStripMenuItem In varCommmsMenu.Items

            Select Case varEachSubItem.Name
                Case "DATAToolStripMenuItem"
                    'Insert "Add New..."
                    varItemSubmenu(0) = New ToolStripMenuItem() With {.Name = "AddNewToolStripMenuItem", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(0))
                    AddHandler varItemSubmenu(0).Click, AddressOf AddNewToolStripMenuItem_Clicked

                    'Insert "Edit..."
                    varItemSubmenu(1) = New ToolStripMenuItem() With {.Name = "EditToolStripMenuItem", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(1))
                    AddHandler varItemSubmenu(1).Click, AddressOf EditToolStripMenuItem_Clicked

                    'Insert "Delete..."
                    varItemSubmenu(2) = New ToolStripMenuItem() With {.Name = "DeleteToolStripMenuItem", .Text = "Delete", .ShortcutKeys = Keys.Delete, .ShortcutKeyDisplayString = "Del"}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(2))
                    AddHandler varItemSubmenu(2).Click, AddressOf DeleteToolStripMenuItem_Clicked

                    'Insert "Separator"
                    varItemSeparator(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                    varEachSubItem.DropDown.Items.Add(varItemSeparator(0))

                    'Insert "Refresh"
                    varItemSubmenu(3) = New ToolStripMenuItem() With {.Name = "RefreshToolStripMenuItem", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(3))
                    AddHandler varItemSubmenu(3).Click, AddressOf RefreshToolStripMenuItem_Clicked

                    'Insert "Separator"
                    varItemSeparator(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                    varEachSubItem.DropDown.Items.Add(varItemSeparator(1))

                    'Insert "Close"
                    varItemSubmenu(4) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.Q, Keys), .ShortcutKeyDisplayString = "Ctrl+Q"}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(4))
                    AddHandler varItemSubmenu(4).Click, AddressOf CloseToolStripMenuItem_Clicked

                Case "TOOLSToolStripMenuItem"
                    'Insert "Import"
                    varItemSubmenu(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(5))
                    AddHandler varItemSubmenu(5).Click, AddressOf ImportToolStripMenuItem_Clicked

                    'Insert "Export"
                    varItemSubmenu(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(6))
                    AddHandler varItemSubmenu(6).Click, AddressOf ExportToolStripMenuItem_Clicked

                    'Insert "Separator"
                    varItemSeparator(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                    varEachSubItem.DropDown.Items.Add(varItemSeparator(2))

                    'Insert "Find"
                    varItemSubmenu(7) = New ToolStripMenuItem() With {.Name = "FindToolStripMenuItem", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
                    varEachSubItem.DropDown.Items.Add(varItemSubmenu(7))
                    AddHandler varItemSubmenu(7).Click, AddressOf FindToolStripMenuItem_Clicked
            End Select
        Next
    End Sub
#End Region

#Region "UNUSED : CreateMenu_Events"
    <SupportedOSPlatform("windows")>
    Private Sub AddNewToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            Try
                If Not (varUserAccess.User(varDatabaseName, "POST", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
                    Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                varFormProperties.IsNew = True
                varFormProperties.RowID = "-1"

                Frm_post_Editor = New FRMpostEditor
                Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EditToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            Try
                If Not (varUserAccess.User(varDatabaseName, "POST", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
                    Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Call GetRowID()
                varFormProperties.IsNew = False
                If Convert.ToString(varFormProperties.RowID) = "-1" Then
                    Decision(varMessageNoRecordSelected, varMessageError, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Else
                    varFormProperties.IsNew = False
                    Frm_post_Editor = New FRMpostEditor
                    Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DeleteToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            Try
                If Not (varUserAccess.User(varDatabaseName, "POST", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
                    Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Call GetRowID()
                If Convert.ToString(varFormProperties.RowID) = "-1" Then
                    Decision(varMessageNoRecordSelected, varMessageError, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Else
                    If Decision("Do you want to delete this record?", "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                        If CMDpost.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)) Then
                            Call GetData(True)
                            FRMmainframe6.Ts_status.Text = "Success"
                        Else
                            FRMmainframe6.Ts_status.Text = "Delete failed"
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub RefreshToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            Call GETDATA()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            Me.Close()
        End If
    End Sub

    Private Sub ImportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            'Put your code here
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            'Put your code here..
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            TxtFind.Focus()
        End If
    End Sub

#End Region

End Class