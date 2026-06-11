Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace UI.Control
    ''' <summary>
    ''' Custom progressbar
    ''' </summary>
    Public Class Pgb
        Inherits System.Windows.Forms.ProgressBar

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.ForeColor = Color.DodgerBlue
            Me.XOGradientDirection = CMCV.UI.Control.ControlCodeBase.EnumGradientType.Horizontal
            Me.XOProgressBarColor = CMCV.UI.Control.ControlCodeBase.EnumColorFill.Solid
            Me.SetStyle(ControlStyles.UserPaint, True)
        End Sub

#Region "Properties"

        <SupportedOSPlatform("windows")>
        Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
            MyBase.OnPaint(e)
            Dim brush As LinearGradientBrush = Nothing
            Dim brush2 As LinearGradientBrush
            Dim rec As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim rec2 As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim scalefactor As Double = ((CDbl(Value) - CDbl(Minimum)) / (CDbl(Maximum) - CDbl(Minimum)))

            If ProgressBarRenderer.IsSupported Then
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec)
            End If

            rec.Width = CInt(Math.Truncate((rec.Width * scalefactor) - 4))
            rec.Height -= 4

            If Me.XOProgressBarColor = CMCV.UI.Control.ControlCodeBase.EnumColorFill.Gradien AndAlso Me.XOGradientDirection = CMCV.UI.Control.ControlCodeBase.EnumGradientType.Vertikal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Vertical)
            ElseIf Me.XOProgressBarColor = CMCV.UI.Control.ControlCodeBase.EnumColorFill.Solid AndAlso Me.XOGradientDirection = CMCV.UI.Control.ControlCodeBase.EnumGradientType.Vertikal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, LinearGradientMode.Vertical)
            ElseIf Me.XOProgressBarColor = CMCV.UI.Control.ControlCodeBase.EnumColorFill.Gradien AndAlso Me.XOGradientDirection = CMCV.UI.Control.ControlCodeBase.EnumGradientType.Horizontal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Horizontal)
            ElseIf Me.XOProgressBarColor = CMCV.UI.Control.ControlCodeBase.EnumColorFill.Solid AndAlso Me.XOGradientDirection = CMCV.UI.Control.ControlCodeBase.EnumGradientType.Horizontal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, LinearGradientMode.Horizontal)
            End If
            brush2 = New LinearGradientBrush(rec, Me.BackColor, Me.BackColor, LinearGradientMode.Vertical)
            rec2.Width -= 4
            rec2.Height -= 4
            e.Graphics.FillRectangle(brush2, 2, 2, rec2.Width, rec2.Height)
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height)
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the color used to render the filled portion of the progress bar")>
        Private varProgressBarColor As CMCV.UI.Control.ControlCodeBase.EnumColorFill
        Public Property XOProgressBarColor As CMCV.UI.Control.ControlCodeBase.EnumColorFill
            Get
                Return varProgressBarColor
            End Get
            Set(value As CMCV.UI.Control.ControlCodeBase.EnumColorFill)
                varProgressBarColor = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the direction in which the gradient fill is applied to the progress bar")>
        Private varGradientDirection As CMCV.UI.Control.ControlCodeBase.EnumGradientType
        Public Property XOGradientDirection As CMCV.UI.Control.ControlCodeBase.EnumGradientType
            Get
                Return varGradientDirection
            End Get
            Set(value As CMCV.UI.Control.ControlCodeBase.EnumGradientType)
                varGradientDirection = value
            End Set
        End Property
#End Region
    End Class
End Namespace