Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMacbk
#Region "Declaration"
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

#End Region

#Region "Sub Collections"
        <SupportedOSPlatform("windows")>
        Private Sub GetData()
            CMDacbk.View.DisplayData(varDataProperties, DgnACBK, SLFStatus, TxtFind, True)
        End Sub
#End Region

#Region "Menu Strip Functions"
        'Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        '    varDataProperties.IsNew = True
        '    Display(ACBK_Editor, QERP.Main.ImageLibrary.EDIT_icon, "Add New Record", "New accounting book record for plant", True)
        'End Sub

        'Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        '    varDataProperties.IsNew = False
        '    Display(ACBK_Editor, QERP.Main.ImageLibrary.EDIT_icon, "Update Record", "Update your accounting book data", True)

        'End Sub

#End Region

#Region "Upper Form Bar"
        <SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData()
        End Sub
#End Region

#Region "Form Events"
        <SupportedOSPlatform("windows")>
        Private Sub FRMacbk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            Call GetData()
        End Sub
#End Region

#Region "Component Events"

#End Region

    End Class
End Namespace