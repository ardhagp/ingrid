Namespace UI.Control
    ''' <project>CMCC</project>
    ''' <author>Ardha Gp</author>
    ''' <summary>
    ''' Custom checkbox
    ''' </summary>
    Public Class Chk
        Inherits System.Windows.Forms.CheckBox

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontLbl
            MyBase.BackColor = Drawing.Color.Transparent
            MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            MyBase.DoubleBuffered = True
        End Sub

        Private varCheckColor As System.Drawing.Color
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("Check"),
    System.ComponentModel.Description("Check color will affect (background color, font type) of the check")>
        Public Property XOCheckColor As System.Drawing.Color
            Get
                Return varCheckColor
            End Get
            Set(value As System.Drawing.Color)
                varCheckColor = value
                Me.Invalidate() ' Redraw the control when the color changes
            End Set
        End Property

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
            e.Graphics.Clear(Me.BackColor)

            ' Adjust vertical alignment here
            Dim offsetY As Integer = (Me.Height - 16) \ 2   ' centers the box

            ' Draw checkbox border
            Dim boxRect As New System.Drawing.Rectangle(0, offsetY, 16, 16)
            System.Windows.Forms.ControlPaint.DrawCheckBox(e.Graphics, boxRect,
                                  If(Me.Checked,
                                     System.Windows.Forms.ButtonState.Checked,
                                     System.Windows.Forms.ButtonState.Normal))

            MyBase.BackColor = Me.Parent.BackColor

            ' Draw custom box background
            Using bg As New System.Drawing.SolidBrush(Me.BackColor)
                e.Graphics.FillRectangle(bg, boxRect)
            End Using

            ' Draw box border
            Using border As New System.Drawing.Pen(Me.ForeColor, 1)
                e.Graphics.DrawRectangle(border, boxRect)
            End Using

            ' Draw custom check mark
            If Me.Checked Then
                Using p As New System.Drawing.Pen(XOCheckColor, 2)
                    e.Graphics.DrawLine(p, 3, offsetY + 8, 7, offsetY + 12)
                    e.Graphics.DrawLine(p, 7, offsetY + 12, 13, offsetY + 3)
                End Using
            End If

            ' Draw text
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, Me.Text, Me.Font,
                              New System.Drawing.Point(20, 0), Me.ForeColor)
        End Sub
    End Class
End Namespace