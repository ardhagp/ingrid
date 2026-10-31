Namespace UI.Components.Behavior
    ''' <summary>
    ''' This class provides methods to adapt the row height of a DataGridView based on the DPI settings of the form. It ensures that the row height is consistent across different display settings, improving the visual appearance and usability of the DataGridView control.
    ''' </summary>
    ''' <remarks>
    ''' The AdaptiveRowHeight method calculates the appropriate row height based on the vertical DPI of the form's graphics context. It sets a base height of 30 pixels at 96 DPI and scales it according to the actual DPI, ensuring that rows are displayed correctly on high-DPI displays.
    ''' </remarks>
    ''' <example>
    ''' To use this method, call it from your form's Load event or after initializing your DataGridView:
    ''' 
    ''' <code>
    ''' CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, myDataGridView)
    ''' </code>
    ''' </example>
    ''' <seealso cref="System.Windows.Forms.DataGridView"/>
    ''' </summary>
    Public Class Datagrid
        ''' <summary>
        ''' Adjusts the row height of the specified DataGridView based on the DPI settings of the provided form. This method calculates the appropriate row height to ensure that the DataGridView rows are displayed correctly on different display settings, particularly on high-DPI displays.
        ''' </summary>
        ''' <param name="frm">The form containing the DataGridView. The method uses this form to determine the current DPI settings.</param>
        ''' <param name="dgn">The DataGridView control whose row height will be adjusted.</param>
        ''' <remarks>
        ''' The method calculates a base height of 30 pixels at 96 DPI and scales it according to the actual vertical DPI of the form's graphics context. It then sets this calculated height for all rows in the DataGridView.
        ''' </remarks>
        ''' <example>
        ''' To use this method, call it from your form's Load event or after initializing your DataGridView:
        ''' 
        ''' <code>
        ''' CMCv.UI.Components.Behavior.Datagrid.AdaptiveRowHeight(Me, myDataGridView)
        ''' </code>
        ''' </example>
        ''' <seealso cref="System.Windows.Forms.DataGridView"/>
        ''' <param name="frm"></param>
        ''' <param name="dgn"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub AdaptiveRowHeight(frm As System.Windows.Forms.Form, dgn As System.Windows.Forms.DataGridView)
            Dim g As System.Drawing.Graphics = frm.CreateGraphics()
            Dim varDpiVertical As Single = g.DpiY

            ' Base height 30px at 96 DPI
            Dim adaptiveHeight As Integer = CInt(30 * (varDpiVertical / 96))

            dgn.RowTemplate.Height = adaptiveHeight

            For Each row As System.Windows.Forms.DataGridViewRow In dgn.Rows
                row.Height = adaptiveHeight
            Next
        End Sub
    End Class
End Namespace