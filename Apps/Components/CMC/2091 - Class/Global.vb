Imports System.Windows.Forms

Namespace UI.Components.Behavior
    Public Class Datagrid
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub AdaptiveRowHeight(frm As Form, dgn As DataGridView)
            Dim g As System.Drawing.Graphics = frm.CreateGraphics()
            Dim varDpiVertical As Single = g.DpiY

            ' Base height 30px at 96 DPI
            Dim adaptiveHeight As Integer = CInt(30 * (varDpiVertical / 96))

            dgn.RowTemplate.Height = adaptiveHeight

            For Each row As DataGridViewRow In dgn.Rows
                row.Height = adaptiveHeight
            Next
        End Sub
    End Class
End Namespace