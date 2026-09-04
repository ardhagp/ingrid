Namespace UI.Canvas
    Public Class FRMreportBasic
        Inherits UI.Canvas.FRMstandardFooter

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMreportBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Rv_.RefreshReport()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace