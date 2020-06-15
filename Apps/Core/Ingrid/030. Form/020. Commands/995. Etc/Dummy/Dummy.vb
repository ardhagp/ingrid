Imports CMCv

Public Class Dummy
    Public Event Done()
    Private WithEvents _Dummy_Editor As New Dummy_Editor
    'Private _MMSMenu As VisualInheritanceFixer.MergeableMenuStrip


    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        _Dummy_Editor = New Dummy_Editor
        Display(_Dummy_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Add New Record", "Add new activity", True)
    End Sub

    Private Sub Dummy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call CreateMenu()
    End Sub

#Region "CreateMenu"
    'Private Sub CreateMenu()
    '    Dim _MMSMenu As New VisualInheritanceFixer.MergeableMenuStrip
    '    Dim _item() As ToolStripMenuItem
    '    Dim _item_sub() As ToolStripMenuItem
    '    Dim _item_sep() As ToolStripSeparator

    '    ReDim _item(2)
    '    _MMSMenu = New VisualInheritanceFixer.MergeableMenuStrip
    '    _MMSMenu.Visible = True
    '    _MMSMenu.InheritedToolStrip = SLFMenu

    '    _item(0) = New ToolStripMenuItem() With {.Name = "DATAToolStripMenuItem", .Text = "DATA", .MergeAction = MergeAction.Insert, .MergeIndex = 1}
    '    _MMSMenu.Items.Add(_item(0))

    '    _item(1) = New ToolStripMenuItem() With {.Name = "TOOLSToolStripMenuItem", .Text = "TOOLS", .MergeAction = MergeAction.Insert, .MergeIndex = 2}
    '    _MMSMenu.Items.Add(_item(1))

    '    Me.Controls.Add(_MMSMenu)

    '    ReDim _item_sub(8)
    '    ReDim _item_sep(4)

    '    For Each _s_item As ToolStripMenuItem In _MMSMenu.Items

    '        Select Case _s_item.Name
    '            Case "DATAToolStripMenuItem"
    '                'Insert "Add New..."
    '                _item_sub(0) = New ToolStripMenuItem() With {.Name = "AddNewToolStripMenuItem", .Text = "Add New...", .ShortcutKeys = Keys.Control + Keys.N, .ShortcutKeyDisplayString = "Ctrl+N"}
    '                _s_item.DropDown.Items.Add(_item_sub(0))
    '                AddHandler _item_sub(0).Click, AddressOf AddNewToolStripMenuItem_Clicked

    '                'Insert "Edit..."
    '                _item_sub(1) = New ToolStripMenuItem() With {.Name = "EditToolStripMenuItem", .Text = "Edit...", .ShortcutKeys = Keys.Control + Keys.E, .ShortcutKeyDisplayString = "Ctrl+E"}
    '                _s_item.DropDown.Items.Add(_item_sub(1))
    '                AddHandler _item_sub(1).Click, AddressOf EditToolStripMenuItem_Clicked

    '                'Insert "Delete..."
    '                _item_sub(2) = New ToolStripMenuItem() With {.Name = "DeleteToolStripMenuItem", .Text = "Delete", .ShortcutKeys = Keys.Delete, .ShortcutKeyDisplayString = "Del"}
    '                _s_item.DropDown.Items.Add(_item_sub(2))
    '                AddHandler _item_sub(2).Click, AddressOf DeleteToolStripMenuItem_Clicked

    '                'Insert "Separator"
    '                _item_sep(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
    '                _s_item.DropDown.Items.Add(_item_sep(0))

    '                'Insert "Refresh"
    '                _item_sub(3) = New ToolStripMenuItem() With {.Name = "RefreshToolStripMenuItem", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
    '                _s_item.DropDown.Items.Add(_item_sub(3))
    '                AddHandler _item_sub(3).Click, AddressOf RefreshToolStripMenuItem_Clicked

    '                'Insert "Separator"
    '                _item_sep(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
    '                _s_item.DropDown.Items.Add(_item_sep(1))

    '                'Insert "Close"
    '                _item_sub(4) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Close", .ShortcutKeys = Keys.Control + Keys.Q, .ShortcutKeyDisplayString = "Ctrl+Q"}
    '                _s_item.DropDown.Items.Add(_item_sub(4))
    '                AddHandler _item_sub(4).Click, AddressOf CloseToolStripMenuItem_Clicked

    '            Case "TOOLSToolStripMenuItem"
    '                'Insert "Import"
    '                _item_sub(5) = New ToolStripMenuItem() With {.Name = "ImportToolStripMenuItem", .Text = "Import...", .Enabled = False}
    '                _s_item.DropDown.Items.Add(_item_sub(5))
    '                AddHandler _item_sub(5).Click, AddressOf ImportToolStripMenuItem_Clicked

    '                'Insert "Export"
    '                _item_sub(6) = New ToolStripMenuItem() With {.Name = "CloseToolStripMenuItem", .Text = "Export...", .Enabled = False}
    '                _s_item.DropDown.Items.Add(_item_sub(6))
    '                AddHandler _item_sub(6).Click, AddressOf ExportToolStripMenuItem_Clicked

    '                'Insert "Separator"
    '                _item_sep(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
    '                _s_item.DropDown.Items.Add(_item_sep(2))

    '                'Insert "Find"
    '                _item_sub(7) = New ToolStripMenuItem() With {.Name = "FindToolStripMenuItem", .Text = "Find", .ShortcutKeys = Keys.Control + Keys.F, .ShortcutKeyDisplayString = "Ctrl+F"}
    '                _s_item.DropDown.Items.Add(_item_sub(7))
    '                AddHandler _item_sub(7).Click, AddressOf FindToolStripMenuItem_Clicked

    '                'Insert "Separator"
    '                _item_sep(3) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
    '                _s_item.DropDown.Items.Add(_item_sep(3))
    '        End Select


    '    Next
    'End Sub
#End Region

#Region "CreateMenu_Events"
    'Private Sub AddNewToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub EditToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub DeleteToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub RefreshToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub CloseToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub ImportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub ExportToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub

    'Private Sub FindToolStripMenuItem_Clicked(sender As Object, e As EventArgs)
    '    Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
    '    If item IsNot Nothing Then
    '        'Put your code here
    '    End If
    'End Sub
#End Region

End Class
