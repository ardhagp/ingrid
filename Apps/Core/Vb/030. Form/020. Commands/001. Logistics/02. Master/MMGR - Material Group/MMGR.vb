Imports System.Runtime.Versioning

Public Class MMGR
    Private V_SQL As New Commands.MMGR.View

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        Commands.MMGR.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnMMGR, SLFStatus, TxtFind, forcerefresh)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmMMGR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETDATA(True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call GETDATA(True)
    End Sub
#End Region

End Class
