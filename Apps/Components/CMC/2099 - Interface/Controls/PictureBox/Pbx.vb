Imports System.Drawing
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace UI.Control
    Public Class Pbx
        Inherits System.Windows.Forms.PictureBox
        'Private initimg As New System.Drawing.Image

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.BackColor = Drawing.Color.White
            MyBase.InitialImage = My.Resources.Loading_001_24_FFFFFFFF_
            MyBase.ErrorImage = My.Resources.FailToLoad_001_24_FFFFFFFF_
            MyBase.SizeMode = PictureBoxSizeMode.Zoom
            'MyBase.Image = My.Resources.pctbxinitial
            Me.XOShowBorder = False
            Me.XOBorderColor = Color.DodgerBlue
            MyBase.DoubleBuffered = True
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether the picture box displays a visible border around its outer frame")>
        Private varShowBorder As Boolean
        Public Property XOShowBorder As Boolean
            Get
                Return varShowBorder
            End Get
            Set(value As Boolean)
                varShowBorder = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the color used to render the border around the picture box")>
        Private varBorderColor As Color
        Public Property XOBorderColor As Color
            Get
                Return varBorderColor
            End Get
            Set(value As Color)
                varBorderColor = value
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Protected Overrides Sub OnPaint(pe As System.Windows.Forms.PaintEventArgs)
            If Me.XOShowBorder Then
                ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Me.XOBorderColor, ButtonBorderStyle.Outset)
            End If
            MyBase.OnPaint(pe)
        End Sub
    End Class
End Namespace