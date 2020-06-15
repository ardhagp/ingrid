Imports CMCv
Imports LibSQL

Public Class MMGR
    Private _SQL As New LibSQL.Commands.MMGR.View

    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnMMGR, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub frmMMGR_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GETDATA(True)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

#Region "Menu Strip Functions"
    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call GETDATA(True)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ImportsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExportsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
#End Region

End Class
