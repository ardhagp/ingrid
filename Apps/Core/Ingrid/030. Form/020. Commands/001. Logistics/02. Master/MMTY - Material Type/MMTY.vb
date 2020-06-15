Imports CMCv
Imports LibSQL

Public Class MMTY
    Private _SQL As New LibSQL.Commands.MMTY.View
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip

#Region "Menu Strip Functions"

#End Region

    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnMMTY, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub frmMMTY_Load(sender As Object, e As EventArgs) Handles Me.Load
        _MMSMenu.LoadIn(Me)
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


End Class
