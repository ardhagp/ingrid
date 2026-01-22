Imports System.Runtime.Versioning

Public Class FRMphotoviewer
    <SupportedOSPlatform("windows")>
    Private Sub PhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ActivateLicenses()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
