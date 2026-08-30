Namespace UI.Canvas
    Public Class FRMphotoViewer
        Inherits UI.Canvas.FRMstandardFooter

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub PhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call Component.Properties.ActivateLicenses()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace