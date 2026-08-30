Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMphotoViewer
        Inherits UI.Canvas.FRMstandardFooter

        <SupportedOSPlatform("windows")>
        Private Sub PhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call ActivateLicenses()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace