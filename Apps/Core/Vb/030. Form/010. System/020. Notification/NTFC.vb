Imports System.Runtime.Versioning

Public Class NTFC

#Region "Variables"
    Private V_SQL As New LibSQL.Commands.NTFC.View
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        DblBuffer(DgnNotification)
        Commands.NTFC.View.Display(varDatabaseName, varDatabaseEngine, DgnNotification, varProperties.EmployeeID)
        FRMmainframe6.USERMENU.Text = varProperties.FirstName
        FRMmainframe6.NotificationToolStripMenuItem.Text = "0 Notification(s)"
    End Sub
#End Region

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub NTFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgnNotification.XOGETNewColor()
        Call GETDATA()
    End Sub
End Class
