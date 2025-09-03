Imports System.Runtime.Versioning
Imports CMCv

Public Class ACBK
#Region "Variables"
    Private WithEvents C_MMSMenu As New CMCv.UI.View.MenuStrip
    Private _SQL As New Commands.ACBK.View
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        Commands.ACBK.View.DISPLAYDATA(DgnACBK, SLFStatus, TxtFind, True)
    End Sub
#End Region

#Region "Menu Strip Functions"
    'Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
    '    V_FORMAttrib.IsNew = True
    '    Display(ACBK_Editor, QERP.Main.ImageLibrary.EDIT_icon, "Add New Record", "New accounting book record for plant", True)
    'End Sub

    'Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
    '    V_FORMAttrib.IsNew = False
    '    Display(ACBK_Editor, QERP.Main.ImageLibrary.EDIT_icon, "Update Record", "Update your accounting book data", True)

    'End Sub

#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub frmACBK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_MMSMenu.LoadIn(Me)
        C_MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)

        Call GETDATA()
    End Sub
#End Region

#Region "Component Events"

#End Region

End Class
