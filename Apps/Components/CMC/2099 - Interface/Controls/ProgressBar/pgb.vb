Imports System.ComponentModel
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
            Me.XOArahGradien = ControlCodeBase.EnumGradientType.Horizontal
            Me.XOWarnaProgressBar = ControlCodeBase.EnumColorFill.Solid
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

            If Me.XOWarnaProgressBar = ControlCodeBase.EnumColorFill.Gradien AndAlso Me.XOArahGradien = ControlCodeBase.EnumGradientType.Vertikal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Vertical)
            ElseIf Me.XOWarnaProgressBar = ControlCodeBase.EnumColorFill.Solid AndAlso Me.XOArahGradien = ControlCodeBase.EnumGradientType.Vertikal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, LinearGradientMode.Vertical)
            ElseIf Me.XOWarnaProgressBar = ControlCodeBase.EnumColorFill.Gradien AndAlso Me.XOArahGradien = ControlCodeBase.EnumGradientType.Horizontal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.BackColor, LinearGradientMode.Horizontal)
            ElseIf Me.XOWarnaProgressBar = ControlCodeBase.EnumColorFill.Solid AndAlso Me.XOArahGradien = ControlCodeBase.EnumGradientType.Horizontal Then
                brush = New LinearGradientBrush(rec, Me.ForeColor, Me.ForeColor, LinearGradientMode.Horizontal)
            End If
            brush2 = New LinearGradientBrush(rec, Me.BackColor, Me.BackColor, LinearGradientMode.Vertical)
            rec2.Width -= 4
            rec2.Height -= 4
            e.Graphics.FillRectangle(brush2, 2, 2, rec2.Width, rec2.Height)
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height)
        End Sub

        Private varWarnaProgressBar As ControlCodeBase.EnumColorFill
        <Category("Appearance"),
    Description("Warna progressbar")>
        Public Property XOWarnaProgressBar As ControlCodeBase.EnumColorFill
            Get
                Return varWarnaProgressBar
            End Get
            Set(value As ControlCodeBase.EnumColorFill)
                varWarnaProgressBar = value
            End Set
        End Property

        Private varArahGradien As ControlCodeBase.EnumGradientType
        <Category("Appearance"),
    Description("Arah gradien")>
        Public Property XOArahGradien As ControlCodeBase.EnumGradientType
            Get
                Return varArahGradien
            End Get
            Set(value As ControlCodeBase.EnumGradientType)
                varArahGradien = value
            End Set
        End Property
#End Region


    End Class
End Namespace