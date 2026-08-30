Namespace UI.Control
    ''' <summary>
    ''' Custom progress bar
    ''' </summary>
    Public Class Pgb
        Inherits System.Windows.Forms.ProgressBar

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.ForeColor = System.Drawing.Color.DodgerBlue
            Me.XOGradientDirection = UI.Control.ControlCodeBase.EnumGradientType.Horizontal
            Me.XOProgressBarColor = UI.Control.ControlCodeBase.EnumColorFill.Solid
            Me.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, True)
        End Sub

#Region "Properties"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            Dim brush As System.Drawing.Drawing2D.LinearGradientBrush = Nothing
            Dim brush2 As System.Drawing.Drawing2D.LinearGradientBrush
            Dim rec As New System.Drawing.Rectangle(0, 0, Me.Width, Me.Height)
            Dim rec2 As New System.Drawing.Rectangle(0, 0, Me.Width, Me.Height)
            Dim scalefactor As Double = ((CDbl(Value) - CDbl(Minimum)) / (CDbl(Maximum) - CDbl(Minimum)))

            If System.Windows.Forms.ProgressBarRenderer.IsSupported Then
                System.Windows.Forms.ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec)
            End If

            rec.Width = CInt(Math.Truncate((rec.Width * scalefactor) - 4))
            rec.Height -= 4

            If Me.XOProgressBarColor = UI.Control.ControlCodeBase.EnumColorFill.Gradien AndAlso Me.XOGradientDirection = UI.Control.ControlCodeBase.EnumGradientType.Vertikal Then
                brush = New System.Drawing.Drawing2D.LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
            ElseIf Me.XOProgressBarColor = UI.Control.ControlCodeBase.EnumColorFill.Solid AndAlso Me.XOGradientDirection = UI.Control.ControlCodeBase.EnumGradientType.Vertikal Then
                brush = New System.Drawing.Drawing2D.LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
            ElseIf Me.XOProgressBarColor = UI.Control.ControlCodeBase.EnumColorFill.Gradien AndAlso Me.XOGradientDirection = UI.Control.ControlCodeBase.EnumGradientType.Horizontal Then
                brush = New System.Drawing.Drawing2D.LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, System.Drawing.Drawing2D.LinearGradientMode.Horizontal)
            ElseIf Me.XOProgressBarColor = UI.Control.ControlCodeBase.EnumColorFill.Solid AndAlso Me.XOGradientDirection = UI.Control.ControlCodeBase.EnumGradientType.Horizontal Then
                brush = New System.Drawing.Drawing2D.LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, System.Drawing.Drawing2D.LinearGradientMode.Horizontal)
            End If
            brush2 = New System.Drawing.Drawing2D.LinearGradientBrush(rec, Me.BackColor, Me.BackColor, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
            rec2.Width -= 4
            rec2.Height -= 4
            e.Graphics.FillRectangle(brush2, 2, 2, rec2.Width, rec2.Height)
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height)
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the color used to render the filled portion of the progress bar")>
        Private varProgressBarColor As UI.Control.ControlCodeBase.EnumColorFill
        Public Property XOProgressBarColor As UI.Control.ControlCodeBase.EnumColorFill
            Get
                Return varProgressBarColor
            End Get
            Set(value As UI.Control.ControlCodeBase.EnumColorFill)
                varProgressBarColor = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the direction in which the gradient fill is applied to the progress bar")>
        Private varGradientDirection As UI.Control.ControlCodeBase.EnumGradientType
        Public Property XOGradientDirection As UI.Control.ControlCodeBase.EnumGradientType
            Get
                Return varGradientDirection
            End Get
            Set(value As UI.Control.ControlCodeBase.EnumGradientType)
                varGradientDirection = value
            End Set
        End Property
#End Region
    End Class
End Namespace