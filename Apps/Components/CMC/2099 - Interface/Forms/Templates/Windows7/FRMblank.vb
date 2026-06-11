Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMblank

        Private Sub Blank_FormClosed(sender As Object, e As system.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Me.Dispose()
        End Sub

        Private Sub Blank_FormClosing(sender As Object, e As system.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            Try
                GC.Collect()
                GC.Collect(GC.MaxGeneration)
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Blank_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                Call ActivateLicenses()
                GC.Collect()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
            End Try
        End Sub
    End Class
End Namespace