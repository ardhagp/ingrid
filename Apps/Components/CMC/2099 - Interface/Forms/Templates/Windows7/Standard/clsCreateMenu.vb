Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace UI.View
    <SupportedOSPlatform("windows")>
    Public Class MenuStrip
        Private com_mms_Menu As New CMCv.mnu
        Private varItemMenu As ToolStripMenuItem()
        Private varItemSubMenu As ToolStripMenuItem()

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
        Private _EventToolsViewAttachmentChecked As Boolean

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

            ReDim varItemMenu(4)
            'com_mms_Menu = New CMCv.mnu
            With com_mms_Menu
                .Visible = isshown
                .Font = New Drawing.Font("Segoe UI", 12)
            End With


            'Add menu RECORD
            varItemMenu(0) = New ToolStripMenuItem() With {.Name = "RECORD", .Text = "RECORD", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 1}
            com_mms_Menu.Items.Add(varItemMenu(0))

            'Add menu TOOLS
            varItemMenu(1) = New ToolStripMenuItem() With {.Name = "TOOLS", .Text = "TOOLS", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            com_mms_Menu.Items.Add(varItemMenu(1))

            'Add menu TOOLS
            varItemMenu(2) = New ToolStripMenuItem() With {.Name = "REPORTS", .Text = "REPORTS", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            com_mms_Menu.Items.Add(varItemMenu(2))

            'Add menu FILE
            varItemMenu(3) = New ToolStripMenuItem() With {.Name = "FILE", .Text = "FILE", .MergeAction = Windows.Forms.MergeAction.Insert, .MergeIndex = 2}
            com_mms_Menu.Items.Add(varItemMenu(3))

            For Each varItemMenu As ToolStripMenuItem In com_mms_Menu.Items
                varItemMenu.Visible = False
            Next

            formname.Controls.Add(com_mms_Menu)

            ReDim varItemSubMenu(12) 'normal items
            ReDim varItemSeparator(5) 'separator items

            For Each varEachItem As ToolStripMenuItem In com_mms_Menu.Items

                Select Case varEachItem.Name
                    Case "RECORD"
                        'Insert "Add New..."
                        varItemSubMenu(0) = New ToolStripMenuItem() With {.Name = "EventDataAddNew", .Text = "Add New...", .ShortcutKeys = CType(Keys.Control + Keys.N, Keys), .ShortcutKeyDisplayString = "Ctrl+N"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(0))
                        AddHandler varItemSubMenu(0).Click, AddressOf EventDataAddNew_Clicked

                        'Insert "Edit..."
                        varItemSubMenu(1) = New ToolStripMenuItem() With {.Name = "EventDataEdit", .Text = "Edit...", .ShortcutKeys = CType(Keys.Control + Keys.E, Keys), .ShortcutKeyDisplayString = "Ctrl+E"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(1))
                        AddHandler varItemSubMenu(1).Click, AddressOf EventDataEdit_Clicked

                        'Insert "Delete..."
                        varItemSubMenu(2) = New ToolStripMenuItem() With {.Name = "EventDataDelete", .Text = "Delete", .ShortcutKeys = CType(Keys.Control + Keys.Delete, Keys), .ShortcutKeyDisplayString = "Ctrl+Del"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(2))
                        AddHandler varItemSubMenu(2).Click, AddressOf EventDataDelete_Clicked

                        'Insert "Separator"
                        varItemSeparator(0) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem1"}
                        varEachItem.DropDown.Items.Add(varItemSeparator(0))

                        'Insert "Find"
                        varItemSubMenu(3) = New ToolStripMenuItem() With {.Name = "EventToolsFind", .Text = "Find", .ShortcutKeys = CType(Keys.Control + Keys.F, Keys), .ShortcutKeyDisplayString = "Ctrl+F"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(3))
                        AddHandler varItemSubMenu(3).Click, AddressOf EventToolsFind_Clicked

                        'Insert "Refresh"
                        varItemSubMenu(4) = New ToolStripMenuItem() With {.Name = "EventDataRefresh", .Text = "Refresh", .ShortcutKeys = Keys.F5, .ShortcutKeyDisplayString = "F5"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(4))
                        AddHandler varItemSubMenu(4).Click, AddressOf EventDataRefresh_Clicked

                        'Insert "Separator"
                        varItemSeparator(1) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem2"}
                        varEachItem.DropDown.Items.Add(varItemSeparator(1))

                        'Insert "Close"
                        varItemSubMenu(5) = New ToolStripMenuItem() With {.Name = "EventDataClose", .Text = "Close", .ShortcutKeys = CType(Keys.Control + Keys.F4, Keys), .ShortcutKeyDisplayString = "Ctrl+F4"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(5))
                        AddHandler varItemSubMenu(5).Click, AddressOf EventDataClose_Clicked

                    Case "TOOLS"
                        'Insert "Import"
                        varItemSubMenu(6) = New ToolStripMenuItem() With {.Name = "EventToolsImport", .Text = "Import...", .Enabled = False}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(6))
                        AddHandler varItemSubMenu(6).Click, AddressOf EventToolsImport_Clicked

                        'Insert "Export"
                        varItemSubMenu(7) = New ToolStripMenuItem() With {.Name = "EventToolsExport", .Text = "Export...", .Enabled = False}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(7))
                        AddHandler varItemSubMenu(7).Click, AddressOf EventToolsExport_Clicked

                        'Insert "Separator"
                        varItemSeparator(2) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                        varEachItem.DropDown.Items.Add(varItemSeparator(2))

                        'Insert "ViewAttachment"
                        varItemSubMenu(8) = New ToolStripMenuItem() With {.Name = "EventToolsViewAttachment", .Text = "Attachment Viewer", .Visible = False, .CheckOnClick = True, .Checked = False, .ShortcutKeys = CType(Keys.Alt + Keys.P, Keys), .ShortcutKeyDisplayString = "Alt+P"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(8))
                        AddHandler varItemSubMenu(8).Click, AddressOf EventToolsViewAttachment_Clicked
                    Case "FILE"
                        'Insert "Save"
                        varItemSubMenu(9) = New ToolStripMenuItem() With {.Name = "EventToolsSave", .Text = "Save", .ShortcutKeys = CType(Keys.Control + Keys.S, Keys), .ShortcutKeyDisplayString = "Ctrl+S"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(9))
                        AddHandler varItemSubMenu(9).Click, AddressOf EventFileSave_Clicked

                        'Insert "Undo All"
                        varItemSubMenu(10) = New ToolStripMenuItem() With {.Name = "EventToolsUndoAll", .Text = "Undo All", .ShortcutKeys = CType(Keys.Control + Keys.Z, Keys), .ShortcutKeyDisplayString = "Ctrl+Z"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(10))
                        AddHandler varItemSubMenu(10).Click, AddressOf EventFileUndoAll_Clicked

                        'Insert "Separator"
                        varItemSeparator(3) = New ToolStripSeparator With {.Name = "SeparatorToolStripMenuItem3"}
                        varEachItem.DropDown.Items.Add(varItemSeparator(3))

                        'Insert "Close"
                        varItemSubMenu(11) = New ToolStripMenuItem() With {.Name = "EventFileCancel", .Text = "Cancel", .ShortcutKeys = CType(Keys.Control + Keys.F4, Keys), .ShortcutKeyDisplayString = "Ctrl+F4"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(11))
                        AddHandler varItemSubMenu(11).Click, AddressOf EventFileCancel_Clicked
                    Case "REPORTS"
                        'Insert "Report"
                        varItemSubMenu(12) = New ToolStripMenuItem() With {.Name = "EventReportsShow", .Text = "Generate...", .ShortcutKeys = CType(Keys.Control + Keys.L, Keys), .ShortcutKeyDisplayString = "Ctrl+L"}
                        varEachItem.DropDown.Items.Add(varItemSubMenu(12))
                        AddHandler varItemSubMenu(12).Click, AddressOf EventReportsView_Clicked
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

        Public Sub EventReportsView_Clicked(sender As Object, e As EventArgs)
            Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If item IsNot Nothing Then
                RaiseEvent EventReportShow()
            End If
        End Sub
#End Region

#Region "Subs Collections"
        Public Function Visible(ByVal menuname As String) As Boolean
            Dim varIsVisible As Boolean = False
            Dim varSubMenu As ToolStripMenuItem

            Try
                For Each varEachSubMenu As Object In varItemSubMenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubMenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubMenu.Name = menuname Then
                            varIsVisible = EventToolsViewAttachmentVisible
                            varSubMenu.Visible = EventToolsViewAttachmentVisible
                        End If
                    End If
                Next
            Catch ex As Exception
                Return False
                MsgBox(ex.ToString)
            End Try
            Return varIsVisible
        End Function

        Public Sub Visible(menuname As String, value As ShowItem)
            Dim varSubmenu As ToolStripMenuItem

            Try
                For Each varEachSubMenu As Object In varItemSubMenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varSubmenu.Visible = CType(value, Boolean)
                            EventToolsViewAttachmentVisible = CType(value, Boolean)
                            Return
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Function Checked(menuname As String) As Boolean
            Dim varIsChecked As Boolean = False
            Dim varSubmenu As ToolStripMenuItem

            Try
                For Each varEachSubMenu As Object In varItemSubMenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varIsChecked = _EventToolsViewAttachmentChecked
                            varSubmenu.Checked = _EventToolsViewAttachmentChecked
                        End If
                    End If
                Next
            Catch ex As Exception
                Return False
                MsgBox(ex.ToString)
            End Try
            Return varIsChecked
        End Function

        Public Sub Checked(menuname As String, value As ShowItem)
            Dim varSubmenu As ToolStripMenuItem

            Try
                For Each varEachSubMenu As Object In varItemSubMenu
                    If TypeOf varEachSubMenu Is ToolStripMenuItem Then
                        varSubmenu = CType(varEachSubMenu, ToolStripMenuItem)
                        If varSubmenu.Name = menuname Then
                            varSubmenu.Checked = CType(value, Boolean)
                            _EventToolsViewAttachmentChecked = CType(value, Boolean)
                            Return
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub ShowMenuData(Optional value As ShowItem = CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            varItemMenu(0).Visible = CType(value, Boolean)
        End Sub

        Public Sub ShowMenuTools(Optional value As ShowItem = CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            varItemMenu(1).Visible = CType(value, Boolean)
        End Sub

        Public Sub ShowMenuReports(Optional value As ShowItem = CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            varItemMenu(2).Visible = CType(value, Boolean)
        End Sub

        Public Sub ShowMenuFile(Optional value As ShowItem = CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            varItemMenu(3).Visible = CType(value, Boolean)
        End Sub
#End Region


    End Class

    Public Class ContextMenu
        Private COM_cs_Menu As New ContextMenuStrip
        Private varItemMenu As ToolStripMenuItem()

#Region "Public Events"
        Public Event ContextCopy()
#End Region

        Public Sub LoadInGrid(grid As dgn)

            'Dim varItemSubMenu() As ToolStripMenuItem

            COM_cs_Menu = New ContextMenuStrip
            ReDim varItemMenu(1)

            COM_cs_Menu.Visible = True

            varItemMenu(0) = New ToolStripMenuItem() With {.Name = "COPYCELL", .Text = "Copy"}
            COM_cs_Menu.Items.Add(varItemMenu(0))
            AddHandler varItemMenu(0).Click, AddressOf ContextCopy_Clicked
            grid.ContextMenuStrip = COM_cs_Menu


        End Sub

#Region "Context Menu Events"
        Private Sub ContextCopy_Clicked(sender As Object, e As EventArgs)
            Dim varItemMenu As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
            If varItemMenu IsNot Nothing Then
                'Your external code will be executed here
                RaiseEvent ContextCopy()
            End If
        End Sub
#End Region

    End Class
End Namespace
