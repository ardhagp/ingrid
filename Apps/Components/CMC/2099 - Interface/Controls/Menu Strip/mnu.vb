Namespace UI.Control
    Public Class Mnu
        Inherits System.Windows.Forms.MenuStrip

        Private varForeColor As System.Drawing.Color = System.Drawing.Color.White
        Private varForeColorOnClick As System.Drawing.Color = System.Drawing.Color.Black

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.DoubleBuffered = True
            Me.Renderer = New CustomMenuStripRenderer(varForeColor, varForeColorOnClick)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Appearance"),
            System.ComponentModel.Description("Specifies the default foreground color for menu items")>
        Public Property XOForeColor As System.Drawing.Color
            Get
                Return varForeColor
            End Get
            Set(value As System.Drawing.Color)
                varForeColor = value
                UpdateRenderer()
            End Set
        End Property

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Appearance"),
            System.ComponentModel.Description("Specifies the foreground color for menu items when clicked")>
        Public Property XOForeColorOnClick As System.Drawing.Color
            Get
                Return varForeColorOnClick
            End Get
            Set(value As System.Drawing.Color)
                varForeColorOnClick = value
                UpdateRenderer()
            End Set
        End Property

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub UpdateRenderer()
            Me.Renderer = New CustomMenuStripRenderer(XOForeColor, XOForeColorOnClick)
        End Sub
    End Class

    ''' <summary>
    ''' Custom renderer for MenuStrip to control text colors based on state.
    ''' </summary>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Friend Class CustomMenuStripRenderer
        Inherits System.Windows.Forms.ToolStripProfessionalRenderer

        Private ReadOnly _defaultForeColor As System.Drawing.Color
        Private ReadOnly _clickForeColor As System.Drawing.Color

        Public Sub New(defaultForeColor As System.Drawing.Color, clickForeColor As System.Drawing.Color)
            _defaultForeColor = defaultForeColor
            _clickForeColor = clickForeColor
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Protected Overrides Sub OnRenderItemText(e As System.Windows.Forms.ToolStripItemTextRenderEventArgs)
            ' Apply color based on item state
            If e.Item.Pressed OrElse e.Item.Selected Then
                e.TextColor = _clickForeColor
            Else
                e.TextColor = _defaultForeColor
            End If

            MyBase.OnRenderItemText(e)
        End Sub
    End Class
End Namespace