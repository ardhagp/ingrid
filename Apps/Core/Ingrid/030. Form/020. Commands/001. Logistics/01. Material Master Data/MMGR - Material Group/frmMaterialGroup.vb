Imports CMCv
Imports LibSQL

Public Class frmMaterialGroup
    Private _SQL As New LibSQL.Commands.MaterialGroup

    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnMaterialGroup, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub frmMaterialGroup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GETDATA(True)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call GETDATA(True)
    End Sub
End Class
