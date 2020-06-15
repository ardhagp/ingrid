Imports CMCv

Public Class frmAccountingBook
    Private _SQL As New LibSQL.Commands.AccountingBook

    Private Sub frmAccountingBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        _SQL.DisplayData(DgnAccountingBook, SLFStatus, TxtFind, True)
    End Sub
End Class
