Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMntfc

#Region "Declarations"

#End Region

#Region "Subs Collections"
        <SupportedOSPlatform("windows")>
        Private Sub GetData()
            DblBuffer(DgnNotification)
            CMDntfc.View.Display(varDataProperties, DgnNotification, varDataProperties.EmployeeId)
            UI.Canvas.FRMmainframe6.USERMENU.Text = varDataProperties.EmployeeFirstName
            UI.Canvas.FRMmainframe6.NotificationToolStripMenuItem.Text = "0 Notification(s)"
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMntfc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            DgnNotification.XOGETNewColor()
            Call GetData()
        End Sub
    End Class
End Namespace