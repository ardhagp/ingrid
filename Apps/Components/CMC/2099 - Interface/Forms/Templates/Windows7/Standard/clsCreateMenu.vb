Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace UI.View
    <SupportedOSPlatform("windows")>
    Public Class MenuStrip
        Implements IDisposable
        Private disposedValue As Boolean

        Private ReadOnly Com_menu As New UI.Control.mnu
        Private varItem As ToolStripMenuItem()
        Private varItemSubmenu As ToolStripMenuItem()

        Public Event EventDataAddNew()
        Public Event EventDataEdit()
        Public Event EventDataDelete()
        Public Event EventDataRefresh()
        Public Event EventDataClose()
        Public Event EventToolsImport()
        Public Event EventToolsExport()
        Public Event EventToolsFind()
        Public Event EventToolsViewAttachment()
        Public Event EventFileSave()
        Public Event EventFileUndoAll()
        Public Event EventFileCancel()
        Public Event EventReportShow()

        Private EventToolsViewAttachmentVisible As Boolean
        Private EventToolsViewAttachmentChecked As Boolean

        Public Enum ShowItem
            Yes = 1
            No = 0
        End Enum


#Region "CreateMenu"
        ''' <summary>
        ''' Menampilkan menu subform
        ''' </summary>
        ''' <param name="FormName">Nama form dimana menu akan ditampilkan</param>
        ''' <remarks></remarks>
        Public Sub LoadIn(formname As Form, Optional isshown As Boolean = False)
            Dim varItemSeparator As ToolStripSeparator()

            ReDim varItem(4)
            'Com_menu = New CMCv.mnu
            With Com_menu
                .Visible = isshown
                .Font = New Drawing.Font("Segoe UI", 12)
            End With


            'Add menu RECORD
            varItem(0) = New ToolStripMenuItem() With {.Name = "RECORD", .Text = "RECORD", .MergeAction = system.Windows.Forms.MergeAction.Insert, .MergeIndex = 1}
            Com_menu.Items.Add(varItem(0))

            'Add menu TOOLS
            varItem(1) = New ToolStripMenuItem() With {.Name = "TOOLS", .Text = "TOOLS", .MergeAction = system.Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            Com_menu.Items.Add(varItem(1))

            'Add menu TOOLS
            varItem(2) = New ToolStripMenuItem() With {.Name = "REPORTS", .Text = "REPORTS", .MergeAction = system.Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            Com_menu.Items.Add(varItem(2))

            'Add menu FILE
            varItem(3) = New ToolStripMenuItem() With {.Name = "FILE", .Text = "FILE", .MergeAction = system.Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            Com_menu.Items.Add(varItem(3))

            For Each varItem As ToolStripMenuItem In Com_menu.Items
                varItem.Visible = False
            Next

            formname.Controls.Add(Com_menu)

            ReDim varItemSubmenu(12) 'normal items
            ReDim varItemSeparator(5) 'separator items

            For Each varEachSubItem As ToolStripMenuItem In Com_menu.Items

                Select Case varEachSubItem.Name
                    Case "RECORD"
                        'Insert "Add New..."
                        varItemSubmenu(0) = New ToolStripMenuItem() With {.Name = "EventDataAddNew", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(0))
                        AddHandler varItemSubmenu(0).Click, AddressOf EventDataAddNew_Clicked

                        'Insert "Edit..."
                        varItemSubmenu(1) = New ToolStripMenuItem() With {.Name = "EventDataEdit", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(1))
                        AddHandler varItemSubmenu(1).Click, AddressOf EventDataEdit_Clicked

                        'Insert "Delete..."
                        varItemSubmenu(2) = New ToolStripMenuItem() With {.Name = "EventDataDelete", .Text = "Delete", .ShortcutKeys = CType(Keys.Control + Keys.Delete, Keys), .ShortcutKeyDisplayString = "Ctrl+Del"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(2))
                        AddHandler varItemSubmenu(2).Click, AddressOf EventDataDelete_Clicked

                        'Insert "Separator"
                        varItemSeparator(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                        varEachSubItem.DropDown.Items.Add(varItemSeparator(0))

                        'Insert "Find"
                        varItemSubmenu(3) = New ToolStripMenuItem() With {.Name = "EventToolsFind", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(3))
                        AddHandler varItemSubmenu(3).Click, AddressOf EventToolsFind_Clicked

                        'Insert "Refresh"
                        varItemSubmenu(4) = New ToolStripMenuItem() With {.Name = "EventDataRefresh", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(4))
                        AddHandler varItemSubmenu(4).Click, AddressOf EventDataRefresh_Clicked

                        'Insert "Separator"
                        varItemSeparator(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                        varEachSubItem.DropDown.Items.Add(varItemSeparator(1))

                        'Insert "Close"
                        varItemSubmenu(5) = New ToolStripMenuItem() With {.Name = "EventDataClose", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.F4, Keys), .ShortcutKeyDisplayString = "Ctrl+F4"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(5))
                        AddHandler varItemSubmenu(5).Click, AddressOf EventDataClose_Clicked

                    Case "TOOLS"
                        'Insert "Import"
                        varItemSubmenu(6) = New ToolStripMenuItem() With {.Name = "EventToolsImport", .Text = "Import...", .Enabled = False}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(6))
                        AddHandler varItemSubmenu(6).Click, AddressOf EventToolsImport_Clicked

                        'Insert "Export"
                        varItemSubmenu(7) = New ToolStripMenuItem() With {.Name = "EventToolsExport", .Text = "Export...", .Enabled = False}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(7))
                        AddHandler varItemSubmenu(7).Click, AddressOf EventToolsExport_Clicked

                        'Insert "Separator"
                        varItemSeparator(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                        varEachSubItem.DropDown.Items.Add(varItemSeparator(2))

                        'Insert "ViewAttachment"
                        varItemSubmenu(8) = New ToolStripMenuItem() With {.Name = "EventToolsViewAttachment", .Text = "Attachment Viewer", .Visible = False, .CheckOnClick = True, .Checked = False, .ShortcutKeys = CType(Keys.Alt + Keys.P, Keys), .ShortcutKeyDisplayString = "Alt+P"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(8))
                        AddHandler varItemSubmenu(8).Click, AddressOf EventToolsViewAttachment_Clicked
                    Case "FILE"
                        'Insert "Save"
                        varItemSubmenu(9) = New ToolStripMenuItem() With {.Name = "EventToolsSave", .Text = "Save", .ShortcutKeys = CType(Keys.Control + Keys.S, Keys), .ShortcutKeyDisplayString = "Ctrl+S"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(9))
                        AddHandler varItemSubmenu(9).Click, AddressOf EventFileSave_Clicked

                        'Insert "Undo All"
                        varItemSubmenu(10) = New ToolStripMenuItem() With {.Name = "EventToolsUndoAll", .Text = "Undo All", .ShortcutKeys = CType(Keys.Control + Keys.Z, Keys), .ShortcutKeyDisplayString = "Ctrl+Z"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(10))
                        AddHandler varItemSubmenu(10).Click, AddressOf EventFileUndoAll_Clicked

                        'Insert "Separator"
                        varItemSeparator(3) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                        varEachSubItem.DropDown.Items.Add(varItemSeparator(3))

                        'Insert "Close"
                        varItemSubmenu(11) = New ToolStripMenuItem() With {.Name = "EventFileCancel", .Text = "Cancel", .ShortcutKeys = CType(Keys.Control + Keys.F4, Keys), .ShortcutKeyDisplayString = "Ctrl+F4"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(11))
                        AddHandler varItemSubmenu(11).Click, AddressOf EventFileCancel_Clicked
                    Case "REPORTS"
                        'Insert "Report"
                        varItemSubmenu(12) = New ToolStripMenuItem() With {.Name = "EventReportsShow", .Text = "Generate...", .ShortcutKeys = CType(Keys.Control + Keys.L, Keys), .ShortcutKeyDisplayString = "Ctrl+L"}
                        varEachSubItem.DropDown.Items.Add(varItemSubmenu(12))
                        AddHandler varItemSubmenu(12).Click, AddressOf EventReportsViewClicked
                End Select
            Next
        End Sub
#End Region

#Region "Events"
        Private Sub EventDataAddNew_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataAddNew()
            End If
        End Sub

        Private Sub EventDataEdit_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataEdit()
            End If
        End Sub

        Private Sub EventDataDelete_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataDelete()
            End If
        End Sub

        Private Sub EventDataRefresh_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataRefresh()
            End If
        End Sub

        Private Sub EventDataClose_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventDataClose()
            End If
        End Sub

        Private Sub EventToolsImport_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsImport()
            End If
        End Sub

        Private Sub EventToolsExport_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsExport()
            End If
        End Sub

        Private Sub EventToolsFind_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsFind()
            End If
        End Sub

        Private Sub EventToolsViewAttachment_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent EventToolsViewAttachment()
            End If
        End Sub

        Private Sub EventFileSave_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventFileSave()
            End If
        End Sub

        Private Sub EventFileUndoAll_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventFileUndoAll()
            End If
        End Sub

        Private Sub EventFileCancel_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventFileCancel()
            End If
        End Sub

        Public Sub EventReportsViewClicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventReportShow()
            End If
        End Sub
#End Region

#Region "Subs Collections"
        Public Function Visible(menuname As String) As Boolean
            Dim varIsVisible As Boolean = False
            Dim varSubmenu As ToolStripMenuItem

            Try
                For Each varEachSubMenu As Object In varItemSubmenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varIsVisible = EventToolsViewAttachmentVisible
                            varSubmenu.Visible = EventToolsViewAttachmentVisible
                        End If
                    End If
                    'If SubMenu.Name = MenuName Then
                    '    _IsVisible = EventToolsViewAttachmentVisible
                    '    SubMenu.Visible = EventToolsViewAttachmentVisible
                    'End If
                Next
            Catch ex As Exception
                Return False
                MsgBox(ex.ToString)
            End Try
            Return varIsVisible
        End Function

        Public Sub Visible(menuname As String, value As ShowItem)
            Try
                Dim varSubmenu As ToolStripMenuItem

                For Each varEachSubMenu As Object In varItemSubmenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varSubmenu.Visible = CType(value, Boolean)
                            EventToolsViewAttachmentVisible = CType(value, Boolean)
                            Return
                        End If
                    End If
                    'If SubMenu.Name = MenuName Then
                    '    SubMenu.Visible = ctype(Value,boolean)
                    '    EventToolsViewAttachmentVisible = ctype(Value,boolean)
                    '    Return
                    'End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Function Checked(menuname As String) As Boolean
            Dim varIsChecked As Boolean = False
            Dim varSubmenu As ToolStripMenuItem
            Try
                For Each varEachSubMenu As Object In varItemSubmenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varIsChecked = EventToolsViewAttachmentChecked
                            varSubmenu.Checked = EventToolsViewAttachmentChecked
                        End If
                    End If
                    'If SubMenu.name = MenuName Then
                    '    varIsChecked = EventToolsViewAttachmentChecked
                    '    SubMenu.Checked = EventToolsViewAttachmentChecked
                    'End If
                Next
            Catch ex As Exception
                Return False
                MsgBox(ex.ToString)
            End Try
            Return varIsChecked
        End Function

        Public Sub Checked(menuname As String, value As ShowItem)
            Try
                Dim varSubmenu As ToolStripMenuItem

                For Each varEachSubMenu As Object In varItemSubmenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varSubmenu.Checked = CType(value, Boolean)
                            EventToolsViewAttachmentChecked = CType(value, Boolean)
                            Return
                        End If
                    End If
                    'If SubMenu.Name = MenuName Then
                    '    SubMenu.Checked = Value
                    '    EventToolsViewAttachmentChecked = Value
                    '    Return
                    'End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub ShowMenuData(Optional value As ShowItem = CType(False, UI.View.MenuStrip.ShowItem))
            varItem(0).Visible = CType(value, Boolean)
        End Sub

        Public Sub ShowMenuTools(Optional value As ShowItem = CType(False, UI.View.MenuStrip.ShowItem))
            varItem(1).Visible = CType(value, Boolean)
        End Sub

        Public Sub ShowMenuReports(Optional value As ShowItem = CType(False, UI.View.MenuStrip.ShowItem))
            varItem(2).Visible = CType(value, Boolean)
        End Sub

        Public Sub ShowMenuFile(Optional value As ShowItem = CType(False, UI.View.MenuStrip.ShowItem))
            varItem(3).Visible = CType(value, Boolean)
        End Sub

#End Region
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' dispose managed state (managed objects)
                    Try
                        Com_menu?.Dispose()
                    Catch
                    End Try

                    If varItemSubmenu IsNot Nothing Then
                        For Each it In varItemSubmenu
                            Try
                                CType(it, ToolStripMenuItem)?.Dispose()
                            Catch
                            End Try
                        Next
                    End If

                    If varItem IsNot Nothing Then
                        For Each it In varItem
                            Try
                                CType(it, ToolStripMenuItem)?.Dispose()
                            Catch
                            End Try
                        Next
                    End If
                End If

                disposedValue = True
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

    End Class

    <SupportedOSPlatform("windows")>
    Public Class ContextMenu
        Implements IDisposable
        Private disposedValue As Boolean

        Private varContextMenu As New ContextMenuStrip
        Private varItem As ToolStripMenuItem()

#Region "Public Events"
        Public Event ContextCopy()
#End Region
        <SupportedOSPlatform("windows")>
        Public Sub LoadInGrid(grid As UI.Control.dgn)
            varContextMenu = New ContextMenuStrip
            ReDim varItem(1)

            varContextMenu.Visible = True

            varItem(0) = New ToolStripMenuItem() With {.Name = "COPYCELL", .Text = "Copy"}
            varContextMenu.Items.Add(varItem(0))
            AddHandler varItem(0).Click, AddressOf ContextCopy_Clicked
            grid.ContextMenuStrip = varContextMenu
        End Sub

#Region "Context Menu Events"
        Private Sub ContextCopy_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent ContextCopy()
            End If
        End Sub
#End Region

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    Try
                        If varItem IsNot Nothing Then
                            For Each it In varItem
                                Try
                                    CType(it, ToolStripMenuItem)?.Dispose()
                                Catch
                                End Try
                            Next
                        End If
                        varContextMenu?.Dispose()
                    Catch
                    End Try
                End If

                disposedValue = True
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
