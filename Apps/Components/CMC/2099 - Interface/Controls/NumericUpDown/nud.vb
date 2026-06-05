Imports System.ComponentModel
Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class nud
        Inherits System.Windows.Forms.NumericUpDown

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Height = 23
            MyBase.Width = 206
            MyBase.Font = globalFontTxt
            Me.XOHighlightOnFocus = False
            Me.XOHighlightColor = Drawing.Color.LightYellow
            Me.XOSelectOnFocus = False
            MyBase.DoubleBuffered = True
        End Sub

#Region "Properti"
        <Category("Text"),
Description("Potong spasi kiri-kanan secara otomatis saat lost focus")>
        Public Property XOAutoTrim() As Boolean
            Get
                Return V_AutoTrim
            End Get
            Set(value As Boolean)
                V_AutoTrim = value
            End Set
        End Property

        <Category("Text"),
    Description("Teksboks harus diisi")>
        Public Property XOIsMandatory As Boolean
            Get
                Return V_HarusDiisi
            End Get
            Set(value As Boolean)
                V_HarusDiisi = value
            End Set
        End Property

        Private _varHightlightSaatFokus As Boolean
        <Category("Text"),
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
        Public Property XOHighlightOnFocus() As Boolean
            Get
                Return _varHightlightSaatFokus
            End Get
            Set(value As Boolean)
                _varHightlightSaatFokus = value
            End Set
        End Property

        Private _varHighlightSaatFokusWarna As System.Drawing.Color
        <Category("Text"),
    Description("Warna highlight")>
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
    End Class
End Namespace