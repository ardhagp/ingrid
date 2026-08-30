Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace UI.Control
    Public Class ULbl
        Inherits System.Windows.Forms.UserControl

        Private iLoop As Integer

        <SupportedOSPlatform("windows")>
        Public Sub New()
            ' This call is required by the designer.
            InitializeComponent()
            Call ActivateLicenses()

            ' Add any initialization after the InitializeComponent() call.
            MyBase.DoubleBuffered = True
            Me.UText.Height = Me.Height
            Me.XOTextAdjuster = False
            Me.XOText = "Text"
            Me.XOTextBorder = False
            Me.XOLabelColor = UI.Control.ControlCodeBase.EnumColorSelect.Default
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the text value displayed by the component and used as its primary content")>
        Private varText As String
        <SupportedOSPlatform("windows")>
        Public Property XOText As String
            Get
                Return varText
            End Get
            Set(value As String)
                varText = value
                Call ChangeText(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub ChangeText(newtext As String)
            UText.Text = newtext
        End Sub

        Private varTextBorder As Boolean
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Format"),
        System.ComponentModel.Description("Specifies the border style applied to the component's text area, controlling how its outline is rendered")>
        Public Property XOTextBorder As Boolean
            Get
                Return varTextBorder
            End Get
            Set(value As Boolean)
                varTextBorder = value
                Call ChangeTextBorder(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub ChangeTextBorder(value As Boolean)
            If value Then
                UText.BorderStyle = BorderStyle.FixedSingle
            Else
                UText.BorderStyle = BorderStyle.None
            End If
        End Sub

        Private varTextAdjuster As Boolean
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Format"),
        System.ComponentModel.Description("Applies automatic text adjustments to the component’s value")>
        Public Property XOTextAdjuster As Boolean
            Get
                Return varTextAdjuster
            End Get
            Set(value As Boolean)
                varTextAdjuster = value
                Call ReadjustmentText(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub ReadjustmentText(value As Boolean)
            If value Then
                Tmr_.Enabled = True
            Else
                Tmr_.Enabled = False
            End If
        End Sub

        Private varLabelColor As UI.Control.ControlCodeBase.EnumColorSelect
        <SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Format"),
        System.ComponentModel.Description("Specifies the color used to render the component’s label")>
        Public Property XOLabelColor() As UI.Control.ControlCodeBase.EnumColorSelect
            Get
                Return varLabelColor
            End Get
            Set(value As UI.Control.ControlCodeBase.EnumColorSelect)
                varLabelColor = value
                ChangeLabelColor(value)
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub ChangeLabelColor(valEnuJenisTombol As UI.Control.ControlCodeBase.EnumColorSelect)
            Select Case valEnuJenisTombol
                Case UI.Control.ControlCodeBase.EnumColorSelect.Green
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.LimeGreen
                    MyBase.BackColor = Drawing.Color.MintCream
                Case UI.Control.ControlCodeBase.EnumColorSelect.Red
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.Red
                    MyBase.BackColor = Drawing.Color.MistyRose
                Case UI.Control.ControlCodeBase.EnumColorSelect.Default
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.RoyalBlue
                    MyBase.BackColor = Drawing.Color.AliceBlue
                Case UI.Control.ControlCodeBase.EnumColorSelect.Yellow
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.DarkOrange
                    MyBase.BackColor = Drawing.Color.Moccasin
                Case UI.Control.ControlCodeBase.EnumColorSelect.Grey
                    UText.ForeColor = Drawing.Color.Black
                    UText.BackColor = Drawing.Color.Transparent
                    UHead.BackColor = Drawing.Color.DarkGray
                    MyBase.BackColor = Drawing.Color.WhiteSmoke
                Case UI.Control.ControlCodeBase.EnumColorSelect.Custom
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
        Private Sub Tmr_Tick(sender As Object, e As EventArgs) Handles Tmr_.Tick
            If iLoop < 10 Then
                UText.Height = Me.Height
                Tmr_.Enabled = False
                iLoop = 0
            Else
                Tmr_.Enabled = False
                iLoop = 0
            End If
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