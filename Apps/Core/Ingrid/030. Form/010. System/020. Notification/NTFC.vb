Public Class NTFC

#Region "Variables"
    Private _SQL As New LibSQL.Commands.NTFC.View
#End Region

#Region "Subs Collections"
    Private Sub GETDATA()
        DblBuffer(DgnNotification)
        _SQL.Display(DgnNotification, _USERAttrib.EID)
        mainframe.USERMENU.Text = _USERAttrib.FirstName
        mainframe.NotificationToolStripMenuItem.Text = "0 Notification(s)"
    End Sub
#End Region

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub NTFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgnNotification.SLF_GETNewColor()
        Call GETDATA()
    End Sub
End Class
