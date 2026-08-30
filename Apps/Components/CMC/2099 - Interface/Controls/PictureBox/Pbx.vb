Namespace UI.Control
    Public Class Pbx
        Inherits System.Windows.Forms.PictureBox

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.BackColor = Drawing.Color.White
            MyBase.InitialImage = My.Resources.Loading_001_24_FFFFFFFF_
            MyBase.ErrorImage = My.Resources.FailToLoad_001_24_FFFFFFFF_
            MyBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.XOShowBorder = False
            Me.XOBorderColor = System.Drawing.Color.DodgerBlue
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
        Private varBorderColor As System.Drawing.Color
        Public Property XOBorderColor As System.Drawing.Color
            Get
                Return varBorderColor
            End Get
            Set(value As System.Drawing.Color)
                varBorderColor = value
            End Set
        End Property

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Protected Overrides Sub OnPaint(pe As System.Windows.Forms.PaintEventArgs)
            If Me.XOShowBorder Then
                System.Windows.Forms.ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Me.XOBorderColor, System.Windows.Forms.ButtonBorderStyle.Outset)
            End If
            MyBase.OnPaint(pe)
        End Sub
    End Class
End Namespace