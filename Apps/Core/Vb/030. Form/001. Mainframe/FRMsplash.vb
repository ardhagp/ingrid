Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMsplash
        <SupportedOSPlatform("windows")>
        Private Sub splash_Load(sender As Object, e As EventArgs) Handles Me.Load
            My.Application.MinimumSplashScreenDisplayTime = 100000
        End Sub
    End Class
End Namespace