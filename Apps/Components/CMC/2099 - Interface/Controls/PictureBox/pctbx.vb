Imports System.Drawing
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Public Class pctbx
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
        Me.XOTampilkanBorder = False
        Me.XOWarnaBorder = Color.DodgerBlue
        MyBase.DoubleBuffered = True
    End Sub

    Private _varTampilkanBorder As Boolean
    Public Property XOTampilkanBorder As Boolean
        Get
            Return _varTampilkanBorder
        End Get
        Set(value As Boolean)
            _varTampilkanBorder = value
        End Set
    End Property

    Private _varWarnaBorder As Color
    Public Property XOWarnaBorder As Color
        Get
            Return _varWarnaBorder
        End Get
        Set(value As Color)
            _varWarnaBorder = value
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal pe As System.Windows.Forms.PaintEventArgs)
        If Me.XOTampilkanBorder = True Then
            ControlPaint.DrawBorder(pe.Graphics, pe.ClipRectangle, Me.XOWarnaBorder, ButtonBorderStyle.Outset)
        End If
        MyBase.OnPaint(pe)
    End Sub
End Class
