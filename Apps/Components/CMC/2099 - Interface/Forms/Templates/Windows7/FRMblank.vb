Namespace UI.Canvas
    Public Class FRMblank
        Inherits System.Windows.Forms.Form

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Blank_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                Component.Properties.ActivateLicenses()
                GC.Collect()
                Component.Properties.varBetterstack.SendSuccess(Bridge.Getkey.Betterstack_heartbeats)
            Catch ex As Exception
                Component.Properties.varBetterstack.SendFailure(Bridge.Getkey.Betterstack_heartbeats)
                MsgBox(ex.ToString)
            Finally
                GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
            End Try
        End Sub

        Private Sub Blank_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            Try
                GC.Collect()
                GC.Collect(GC.MaxGeneration)
            Catch ex As Exception
                Component.Properties.varBetterstack.SendFailure(Bridge.Getkey.Betterstack_heartbeats)
                MsgBox(ex.ToString)
            Finally
                GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
            End Try
        End Sub

        Private Sub Blank_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Me.Dispose()
        End Sub
    End Class
End Namespace