Imports CMCv

Public Class ACBK
#Region "Variables"
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private _SQL As New LibSQL.Commands.ACBK.View
#End Region

#Region "Sub Collections"
    Private Sub GETDATA()
        _SQL.DisplayData(DgnACBK, SLFStatus, TxtFind, True)
    End Sub
#End Region

#Region "Menu Strip Functions"
    'Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
    '    _FORMAttrib.IsNew = True
    '    Display(ACBK_Editor, QERP.Main.ImageLibrary.EDIT_002_512_icon, "Add New Record", "New accounting book record for plant", True)
    'End Sub

    'Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
    '    _FORMAttrib.IsNew = False
    '    Display(ACBK_Editor, QERP.Main.ImageLibrary.EDIT_002_512_icon, "Update Record", "Update your accounting book data", True)

    'End Sub

#End Region

#Region "Upper Form Bar"
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA()
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmACBK_Load(sender As Object, e As EventArgs) Handles Me.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)

        Call GETDATA()
    End Sub
#End Region

#Region "Component Events"

#End Region

End Class
