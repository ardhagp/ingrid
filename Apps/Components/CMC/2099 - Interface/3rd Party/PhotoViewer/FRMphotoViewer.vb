Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMphotoViewer
        <SupportedOSPlatform("windows")>
        Private Sub PhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call ActivateLicenses()
        End Sub

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace