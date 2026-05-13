Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMdummyEditor
        Public Event RecordSaved()

        <SupportedOSPlatform("windows")>
        Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
            Me.Close()
        End Sub
    End Class
End Namespace