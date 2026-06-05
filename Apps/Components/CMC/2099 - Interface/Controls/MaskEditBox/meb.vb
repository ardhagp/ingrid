Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class meb
        Inherits System.Windows.Forms.MaskedTextBox

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontTxt
            MyBase.Width = 206
            Me.XOIsMandatory = False
            Me.XOMandatoryBgColor = Drawing.Color.LightPink
            Me.XOMandatoryBgColorDefault = Drawing.Color.White
            Me.XOHighlightOnFocus = False
            Me.XOHighlightColor = Drawing.Color.LightYellow
            Me.XOSelectOnFocus = False
        End Sub

#Region "Properti"
        Private _varHarusDiisi As Boolean
        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Maskeditbox harus diisi")>
        Public Property XOIsMandatory As Boolean
            Get
                Return _varHarusDiisi
            End Get
            Set(value As Boolean)
                _varHarusDiisi = value
            End Set
        End Property

        Private _varHarusDiisiWarnaLatarDefault As System.Drawing.Color
        Private _varHarusDiisiWarnaLatar As System.Drawing.Color
        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Warna saat teksboks tidak diisi")>
        Public Property XOMandatoryBgColor As System.Drawing.Color
            Get
                Return _varHarusDiisiWarnaLatar
            End Get
            Set(value As System.Drawing.Color)
                _varHarusDiisiWarnaLatar = value
            End Set
        End Property

        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Warna saat teksboks tidak diisi jika bernilai False")>
        Public Property XOMandatoryBgColorDefault As System.Drawing.Color
            Get
                Return _varHarusDiisiWarnaLatarDefault
            End Get
            Set(value As System.Drawing.Color)
                _varHarusDiisiWarnaLatarDefault = value
            End Set
        End Property

        Private _varHightlightSaatFokus As Boolean
        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
        Public Property XOHighlightOnFocus() As Boolean
            Get
                Return _varHightlightSaatFokus
            End Get
            Set(value As Boolean)
                _varHightlightSaatFokus = value
            End Set
        End Property

        Private _varHighlightSaatFokusWarna As System.Drawing.Color
        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Warna highlight")>
        Public Property XOHighlightColor() As System.Drawing.Color
            Get
                Return _varHighlightSaatFokusWarna
            End Get
            Set(value As System.Drawing.Color)
                _varHighlightSaatFokusWarna = value
            End Set
        End Property

        Private _varPilihSemuaSaatFokus As Boolean
        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Memilih semua teks saat fokus")>
        Public Property XOSelectOnFocus() As Boolean
            Get
                Return _varPilihSemuaSaatFokus
            End Get
            Set(value As Boolean)
                _varPilihSemuaSaatFokus = value
            End Set
        End Property
#End Region

        Private _varFlagAutoSelect As Boolean
        <SupportedOSPlatform("windows")>
        Private Sub txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
            If Me.XOSelectOnFocus AndAlso (MouseButtons = system.Windows.Forms.MouseButtons.None) Then
                Me.SelectAll()
                _varFlagAutoSelect = True
            End If
            If Me.XOHighlightOnFocus Then
                MyBase.BackColor = Me.XOHighlightColor
            End If
            If Me.XOSelectOnFocus Then
                Me.Select(0, Me.Text.Length)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
            'If Me.XOHighlightOnFocus AndAlso Not Me.Focused AndAlso Not Me.SLFHarusDiisi Then
            '    MyBase.BackColor = _varHarusDiisiWarnaLatarDefault
            'ElseIf Me.XOHighlightOnFocus AndAlso Not Me.Focused Then
            '    MyBase.BackColor = _varHarusDiisiWarnaLatarDefault
            If XOIsMandatory Then 'AndAlso Me.Text.Trim = "" Then
                MyBase.BackColor = Me.XOMandatoryBgColor
            Else
                MyBase.BackColor = Me.XOMandatoryBgColorDefault
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
            If Me.XOHighlightOnFocus Then
                MyBase.BackColor = Me.XOHighlightColor
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            If Me.XOHighlightOnFocus AndAlso Not Me.Focused Then
                MyBase.BackColor = Me.XOMandatoryBgColorDefault
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            If Me.XOSelectOnFocus AndAlso (Not _varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
                _varFlagAutoSelect = True
                Me.SelectAll()
            End If
        End Sub
    End Class
End Namespace