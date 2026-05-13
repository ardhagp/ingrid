Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace UI.Control
    Public Class ULbl
        Private iLoop As Integer

        <SupportedOSPlatform("windows")>
        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()
            Call ActivateLicenses()

            ' Add any initialization after the InitializeComponent() call.
            MyBase.DoubleBuffered = True
            Me.UText.Height = Me.Height
            Me.SLFTextAdjuster = False
            Me.SLFText = "Text"
            Me.SLFTextBorder = False
            Me.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
        End Sub

        Private _varText As String
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Description("This text will show on label
"), System.ComponentModel.Editor(GetType(System.ComponentModel.Design.MultilineStringEditor), GetType(System.Drawing.Design.UITypeEditor))>
        Public Property SLFText As String
            Get
                Return _varText
            End Get
            Set(value As String)
                _varText = value
                Call GantiText(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub GantiText(ByVal _value As String)
            UText.Text = _value
        End Sub

        Private _varTextBorder As Boolean
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Description("This show text border
")>
        Public Property SLFTextBorder As Boolean
            Get
                Return _varTextBorder
            End Get
            Set(value As Boolean)
                _varTextBorder = value
                Call GantiTextBorder(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub GantiTextBorder(ByVal _value As Boolean)
            If _value = True Then
                UText.BorderStyle = BorderStyle.FixedSingle
            Else
                UText.BorderStyle = BorderStyle.None
            End If
        End Sub

        Private varReadjustText As Boolean
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Description("Enable this to readjust text
")>
        Public Property SLFTextAdjuster As Boolean
            Get
                Return varReadjustText
            End Get
            Set(value As Boolean)
                varReadjustText = value
                Call ReadjustText(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub ReadjustText(value As Boolean)
            If value Then
                tmr_.Enabled = True
            Else
                tmr_.Enabled = False
            End If
        End Sub

        Private varWarnaLabel As ControlCodeBase.JenisLabel
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Description("Color options")>
        Public Property SLFWarnaLabel() As ControlCodeBase.JenisLabel
            Get
                Return varWarnaLabel
            End Get
            Set(value As ControlCodeBase.JenisLabel)
                varWarnaLabel = value
                GantiWarnaLabel(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub GantiWarnaLabel(valEnuJenisTombol As ControlCodeBase.JenisLabel)
            Select Case valEnuJenisTombol
                Case ControlCodeBase.JenisLabel.Green
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.LimeGreen
                    MyBase.BackColor = Drawing.Color.MintCream
                Case ControlCodeBase.JenisLabel.Red
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.Red
                    MyBase.BackColor = Drawing.Color.MistyRose
                Case ControlCodeBase.JenisLabel.Default
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.RoyalBlue
                    MyBase.BackColor = Drawing.Color.AliceBlue
                Case ControlCodeBase.JenisLabel.Yellow
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.DarkOrange
                    MyBase.BackColor = Drawing.Color.Moccasin
                Case ControlCodeBase.JenisLabel.Grey
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.DarkGray
                    MyBase.BackColor = Drawing.Color.WhiteSmoke
                Case ControlCodeBase.JenisLabel.Custom
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    'UHead.BackColor = System.Drawing.Color.Orange
                    'MyBase.BackColor = Drawing.Color.Black
            End Select
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ULbl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            UText.Height = Me.Height
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub tmr__Tick(sender As Object, e As EventArgs) Handles tmr_.Tick
            If iLoop < 10 Then
                UText.Height = Me.Height
                tmr_.Enabled = False
                iLoop = 0
            Else
                tmr_.Enabled = False
                iLoop = 0
            End If
        End Sub

        Private Sub ULbl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            '
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ULbl_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
            UText.Height = Me.Height
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ULbl_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
            UText.Height = Me.Height
        End Sub
    End Class
End Namespace