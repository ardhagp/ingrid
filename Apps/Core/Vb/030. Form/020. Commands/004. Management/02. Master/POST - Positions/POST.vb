Imports System.Runtime.Versioning
Imports CMCv

Public Class POST
#Region "Variables"
    Private _SQL As New LibSQL.Commands.POST.View
    Private WithEvents _POST_Editor As New POST_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.POST.View.DisplayData(V_DatabaseEngine, DgnPOST, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnPOST.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnPOST.CurrentRow.Cells("position_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        _POST_Editor = New POST_Editor
        Display(_POST_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new job position data", True)
        Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your position data", True)
        End If
    End Sub
        V_FORMAttrib.IsNew = False
        _POST_Editor = New POST_Editor
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)

            Display(_POST_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your position data", True)
            Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        Call GETDATA(True)
        Mainframe_n_6.Ts_status.Text = "Success"
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        End If
        End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles clsMMSmenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles clsMMSmenu.EventDataClose
        Me.Close()
    End Sub
    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
    Private Sub EventDataFind() Handles clsMMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose

    <SupportedOSPlatform("windows")>
    Private Sub POST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Private Sub EventDataFind() Handles _MMSMenu.EventToolsFind
        .LoadIn(Me)
        .ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        End With
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _POST_Editor_RecordSaved() Handles frmPOSTeditor.RecordSaved
        Call GETDATA(True)
    End Sub

#Region "UNUSED : CreateMenu"
    <SupportedOSPlatform("windows")>
    Private Sub CreateMenu()
        Dim clsMMSmenu As New CMCv.Mnu
    Private Sub _POST_Editor_RecordSaved() Handles _POST_Editor.RecordSaved
        Dim varItem_sub As ToolStripMenuItem()
        Dim varItem_sep As ToolStripSeparator()

        ReDim varItem(2)
        clsMMSmenu = New CMCv.Mnu
        clsMMSmenu.Visible = False
        Dim _MMSMenu As New CMCv.mnu
        Dim _item As ToolStripMenuItem()
        Dim _item_sub As ToolStripMenuItem()
        Dim _item_sep As ToolStripSeparator()
        varItem(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
        ReDim _item(2)
        _MMSMenu = New CMCv.mnu
        _MMSMenu.Visible = False

        _item(0) = New ToolStripMenuItem() With {.Name = "DATAToolStripMenuItem", .Text = "DATA", .MergeAction = MergeAction.Insert, .MergeIndex = 1}
        _MMSMenu.Items.Add(_item(0))

        _item(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
        _MMSMenu.Items.Add(_item(1))
        Select Case varS_item.Name
        Me.Controls.Add(_MMSMenu)
            'Insert "Add New..."
            ReDim _item_sub(8)
            ReDim _item_sep(4)
            AddHandler varItem_sub(0).Click, AddressOf AddNewToolStripMenuItem_Clicked
            For Each _s_item As ToolStripMenuItem In _MMSMenu.Items
                'Insert "Edit..."
                Select Case _s_item.Name
                varS_item.DropDown.Items.Add(varItem_sub(1))
                    AddHandler varItem_sub(1).Click, AddressOf EditToolStripMenuItem_Clicked
                    _item_sub(0) = New ToolStripMenuItem() With {.Name = "AddNewToolStripMenuItem", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
                    _s_item.DropDown.Items.Add(_item_sub(0))
                    AddHandler _item_sub(0).Click, AddressOf AddNewToolStripMenuItem_Clicked
                    varS_item.DropDown.Items.Add(varItem_sub(2))
                    AddHandler varItem_sub(2).Click, AddressOf DeleteToolStripMenuItem_Clicked
                    _item_sub(1) = New ToolStripMenuItem() With {.Name = "EditToolStripMenuItem", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
                    _s_item.DropDown.Items.Add(_item_sub(1))
                    AddHandler _item_sub(1).Click, AddressOf EditToolStripMenuItem_Clicked
                    varS_item.DropDown.Items.Add(varItem_sep(0))

                    _item_sub(2) = New ToolStripMenuItem() With {.Name = "DeleteToolStripMenuItem", .Text = "Delete", .ShortcutKeys = Keys.Delete, .ShortcutKeyDisplayString = "Del"}
                    _s_item.DropDown.Items.Add(_item_sub(2))
                    AddHandler _item_sub(2).Click, AddressOf DeleteToolStripMenuItem_Clicked
                    AddHandler varItem_sub(3).Click, AddressOf RefreshToolStripMenuItem_Clicked

                    _item_sep(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                    _s_item.DropDown.Items.Add(_item_sep(0))
                    varS_item.DropDown.Items.Add(varItem_sep(1))

                    _item_sub(3) = New ToolStripMenuItem() With {.Name = "RefreshToolStripMenuItem", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                    _s_item.DropDown.Items.Add(_item_sub(3))
                    AddHandler _item_sub(3).Click, AddressOf RefreshToolStripMenuItem_Clicked
                    AddHandler varItem_sub(4).Click, AddressOf CloseToolStripMenuItem_Clicked

                    _item_sep(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                    _s_item.DropDown.Items.Add(_item_sep(1))
                    varItem_sub(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
                    varS_item.DropDown.Items.Add(varItem_sub(5))
                    _item_sub(4) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.Q, Keys), .ShortcutKeyDisplayString = "Ctrl+Q"}
                    _s_item.DropDown.Items.Add(_item_sub(4))
                    AddHandler _item_sub(4).Click, AddressOf CloseToolStripMenuItem_Clicked
                    varItem_sub(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
                    varS_item.DropDown.Items.Add(varItem_sub(6))
                AddHandler varItem_sub(6).Click, AddressOf ExportToolStripMenuItem_Clicked
                    _item_sub(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
                    _s_item.DropDown.Items.Add(_item_sub(5))
                    AddHandler _item_sub(5).Click, AddressOf ImportToolStripMenuItem_Clicked
                    varS_item.DropDown.Items.Add(varItem_sep(2))

                    _item_sub(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
                    _s_item.DropDown.Items.Add(_item_sub(6))
                    AddHandler _item_sub(6).Click, AddressOf ExportToolStripMenuItem_Clicked
                    AddHandler varItem_sub(7).Click, AddressOf FindToolStripMenuItem_Clicked
                End Select
                _item_sep(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                _s_item.DropDown.Items.Add(_item_sep(2))
#End Region

                _item_sub(7) = New ToolStripMenuItem() With {.Name = "FindToolStripMenuItem", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
                _s_item.DropDown.Items.Add(_item_sub(7))
                AddHandler _item_sub(7).Click, AddressOf FindToolStripMenuItem_Clicked
                Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
                If varItem IsNot Nothing Then
            Try
                If Not (varUSRaccess.User("POST", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
                    Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
                        If item IsNot Nothing Then
                            .RowID = "-1"
                            If Not (V_USERAccess.User("POST", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
                                Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                                frmPOSTeditor = New POST_Editor
                                DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
            Catch ex As Exception
                        V_FORMAttrib.IsNew = True
                        V_FORMAttrib.RowID = "-1"

                        _POST_Editor = New POST_Editor
                        Display(_POST_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
                        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
                        If varItem IsNot Nothing Then
            Try
                If Not (varUSRaccess.User("POST", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
                    Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                                Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
                                If item IsNot Nothing Then
                                    If varFORMAttribute.RowID = "-1" Then
                                        If Not (V_USERAccess.User("POST", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
                                            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                                            varFORMAttribute.IsNew = False
                                            frmPOSTeditor = New POST_Editor
                    DISPLAY(frmPOSTeditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
                End If
                                        V_FORMAttrib.IsNew = False
                                        If V_FORMAttrib.RowID = "-1" Then
                                            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                                        End If
                                        V_FORMAttrib.IsNew = False
                                        _POST_Editor = New POST_Editor
                                        Display(_POST_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
    Private Sub DeleteToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Try
                If Not (varUSRaccess.User("POST", varUSERAttribute.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
                    Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
                If item IsNot Nothing Then
                    Decision("No record selected", "Error", CMCv.frmDBdialogbox.MessageIcon.Error, CMCv.frmDBdialogbox.MessageTypes.OkOnly)
                    If Not (V_USERAccess.User("POST", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
                        Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                        If LibSQL.Commands.POST.View.DELETEData(V_DatabaseEngine, V_FORMAttrib.RowID) Then
                            Call GETDATA(True)
                            Mainframe_n_6.Ts_status.Text = "Success"
                        Else
                            If V_FORMAttrib.RowID = "-1" Then
                                Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
                            End If
                        End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Mainframe_n_6.ts_status.Text = "Delete failed"

    <SupportedOSPlatform("windows")>
    Private Sub RefreshToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If varItem IsNot Nothing Then
            Call GETDATA()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
        End If
    End Sub

    Private Sub ImportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
        End If
    End Sub

    Private Sub ExportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
        Dim varItem As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        If item IsNot Nothing Then
            'Put your code here..
    End Sub
#End Region

End Class
