Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMmmgr
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            CMDmmgr.View.DisplayData(varDataProperties, DgnMMGR, SLFStatus, TxtFind, forcerefresh)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMmmgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call GetData(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

#Region "Menu Strip Functions"

        <SupportedOSPlatform("windows")>
        Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
            Call GetData(True)
        End Sub
#End Region

    End Class
End Namespace