Imports System.ComponentModel
Imports System.Globalization
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Runtime.Versioning
Imports System.Text.RegularExpressions

''' <project>Mainframe : txt (Textbox Custom Component)</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom komponen textbox. Dilengkapi dengan sekuensial validasi pada button clicked.
''' </summary>
''' <remarks></remarks>
Public Class txt
    Inherits System.Windows.Forms.TextBox

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontTxt
        MyBase.MaxLength = 255
        MyBase.Height = 23
        MyBase.Width = 206
        Me.XOHarusDiisi = False
        Me.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        Me.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        Me.XOTanpaSpasi = False
        Me.XOAutoTrim = False
        Me.XOHightlightSaatFokus = False
        Me.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        Me.XOPilihSemuaSaatFokus = False
        Me.XORestriction = ControlCodeBase.enuRestriction.None
        Me.XOIsBlank = True
        Me.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Me.XOIsSearchBox = False
        Me.XOSearchBoxText = "Type then press Enter"
        Me.XOPwdLengthMin = 8
        Me.XOPwdStrengthCalculate = False
        Call FontSearchBox(True)
    End Sub

#Region "Properties"
    <Category("Text"),
    Description("Potong spasi kiri-kanan secara otomatis saat lost focus")>
    Private _varAutoTrim As Boolean
    Public Property XOAutoTrim() As Boolean
        Get
            Return _varAutoTrim
        End Get
        Set(value As Boolean)
            _varAutoTrim = value
        End Set
    End Property

    <Category("Text"),
    Description("Teksboks harus diisi")>
    Private _varHarusDiisi As Boolean
    Public Property XOHarusDiisi As Boolean
        Get
            Return _varHarusDiisi
        End Get
        Set(value As Boolean)
            _varHarusDiisi = value
        End Set
    End Property

    Private _varHightlightSaatFokus As Boolean
    <Category("Text"),
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
    Public Property XOHightlightSaatFokus() As Boolean
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
    Public Property XOHightlightSaatFokusWarna() As System.Drawing.Color
        Get
            Return _varHighlightSaatFokusWarna
        End Get
        Set(value As System.Drawing.Color)
            _varHighlightSaatFokusWarna = value
        End Set
    End Property

    <Category("Text"),
   Description("Panjang password minimum")>
    Private _varPwdLengthMin As Integer
    Public Property XOPwdLengthMin As Integer
        Get
            Return _varPwdLengthMin
        End Get
        Set(value As Integer)
            _varPwdLengthMin = value
        End Set
    End Property

    <Category("Text"),
   Description("Aktifkan penghitung kekuatan password")>
    Private _varPwdStrengthCalculate As Boolean
    Public Property XOPwdStrengthCalculate As Boolean
        Get
            Return _varPwdStrengthCalculate
        End Get
        Set(value As Boolean)
            _varPwdStrengthCalculate = value
        End Set
    End Property

    <Category("Text"),
   Description("Indikator kekuatan password (skor)")>
    Private _varPwdStrengthScore As Integer
    Public Property XOPwdStrengthScore As Integer
        Get
            Return _varPwdStrengthScore
        End Get
        Set(value As Integer)
            _varPwdStrengthScore = value
        End Set
    End Property

    <Category("Text"),
   Description("Indikator kekuatan password (teks)")>
    Private _varPwdStrengthText As String
    Public Property XOPwdStrengthText As String
        Get
            Return _varPwdStrengthText
        End Get
        Set(value As String)
            _varPwdStrengthText = value
        End Set
    End Property

    <Category("Text"),
   Description("Mengisi teksboks kosong dengan tanda (-)")>
    Private _varTanpaSpasi As Boolean
    Public Property XOTanpaSpasi As Boolean
        Get
            Return _varTanpaSpasi
        End Get
        Set(value As Boolean)
            _varTanpaSpasi = value
        End Set
    End Property

    <Category("Text"),
   Description("Teks yang dikonversi untuk sql")>
    Private _varSQLText As String
    Public Property XOSQLText As String
        Get
            Return _varSQLText
        End Get
        Set(value As String)
            _varSQLText = value
        End Set
    End Property

    Private _varHarusDiisiWarnaLatarDefault As System.Drawing.Color
    Private _varHarusDiisiWarnaLatar As System.Drawing.Color
    <Category("Text"),
    Description("Warna saat teksboks tidak diisi")>
    Public Property XOHarusDiisiWarnaLatar As System.Drawing.Color
        Get
            Return _varHarusDiisiWarnaLatar
        End Get
        Set(value As System.Drawing.Color)
            _varHarusDiisiWarnaLatar = value
        End Set
    End Property

    <Category("Text"),
    Description("Warna saat teksboks tidak diisi jika bernilai False")>
    Public Property XOHarusDiisiWarnaLatarDefault As System.Drawing.Color
        Get
            Return _varHarusDiisiWarnaLatarDefault
        End Get
        Set(value As System.Drawing.Color)
            _varHarusDiisiWarnaLatarDefault = value
        End Set
    End Property

    Private _varValidasiField As String
    <Category("Text"),
    Description("Field yang ditampilkan saat validasi tidak diisi")>
    Public Property XOValidasiField As String
        Get
            Return _varValidasiField
        End Get
        Set(value As String)
            _varValidasiField = value
        End Set
    End Property

    Private _varPilihSemuaSaatFokus As Boolean
    <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Memilih semua teks saat fokus")>
    Public Property XOPilihSemuaSaatFokus() As Boolean
        Get
            Return _varPilihSemuaSaatFokus
        End Get
        Set(value As Boolean)
            _varPilihSemuaSaatFokus = value
        End Set
    End Property

    Private _varIsBlank As Boolean
    ''' <summary>
    ''' Nilai ini terisi secara otomatis
    ''' </summary>
    ''' <value>True/False</value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    Public Property XOIsBlank() As Boolean
        Get
            Return _varIsBlank
        End Get
        Set(value As Boolean)
            _varIsBlank = value
        End Set
    End Property

    Private _varJenisKapital As ControlCodeBase.enuJenisKapital
    <Category("Text"),
    Description("Isi akan diubah menjadi kapital semua")>
    Public Property XOJenisKapital As ControlCodeBase.enuJenisKapital
        Get
            Return _varJenisKapital
        End Get
        Set(value As ControlCodeBase.enuJenisKapital)
            _varJenisKapital = value
        End Set
    End Property

    Private _varRestriction As ControlCodeBase.enuRestriction
    Public Property XORestriction As ControlCodeBase.enuRestriction
        Get
            Return _varRestriction
        End Get
        Set(value As ControlCodeBase.enuRestriction)
            _varRestriction = value
        End Set
    End Property

    Private _varIsSearchBox As Boolean
    Public Property XOIsSearchBox As Boolean
        Get
            Return _varIsSearchBox
        End Get
        Set(value As Boolean)
            _varIsSearchBox = value
        End Set
    End Property

    Private _varSearchBoxText As String
    Public Property XOSearchBoxText As String
        Get
            Return _varSearchBoxText
        End Get
        Set(value As String)
            _varSearchBoxText = value
        End Set
    End Property
#End Region

#Region "Function"
    Private Function SQLSafeText(ByVal txtControl As txt) As String
        Dim _SQLSafeText As String = txtControl.Text

        If (txtControl.XOIsSearchBox = True) AndAlso (txtControl.Text = txtControl.XOSearchBoxText) Then
            _SQLSafeText = String.Empty
        End If

        _SQLSafeText = _SQLSafeText.Replace("'", "").Replace(";", "").Replace("--", "").Replace("drop table ", "").Replace("update ", "").Replace("insert into ", "").Replace("--", "").Replace("xp_", "").Trim
        If XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA Then
            _SQLSafeText = _SQLSafeText.ToUpper(CultureInfo.CurrentCulture)
        ElseIf XOJenisKapital = ControlCodeBase.enuJenisKapital.kecilsemua Then
            _SQLSafeText = _SQLSafeText.ToLower(CultureInfo.CurrentCulture)
        End If
        Return _SQLSafeText
    End Function

    Private Sub CheckRestriction(ByVal _valEnuRestriction As ControlCodeBase.enuRestriction)
        Select Case _valEnuRestriction
            Case ControlCodeBase.enuRestriction.None
                'Do nothing
            Case ControlCodeBase.enuRestriction.OnlyNumber
                'Do Only Number
            Case ControlCodeBase.enuRestriction.OnlyText
                'Do Only Text
            Case ControlCodeBase.enuRestriction.TextAndNumber
                'Do Text and Number
            Case ControlCodeBase.enuRestriction.TextAndSymbol
                'Do Text and Symbol
            Case ControlCodeBase.enuRestriction.Email
                'Do Email
        End Select
    End Sub
#End Region

#Region "Password Strength Indicator"
    Private _Password As String
    Private _ChrPassword() As Char
    Private _MinPasswordLength As Integer = 8
    Private _BaseScore As Integer
    Private _Score As Integer
    Private _Result As String
    Private _Bonus As New Bonus
    Private _Num As New Num

    Private Sub InitPasswordStrength(ByVal UserInput As String)
        _Password = UserInput
        _ChrPassword = _Password.ToCharArray()

        _Num.Excess = 0
        _Num.Upper = 0
        _Num.Numbers = 0
        _Num.Symbols = 0
        _Bonus.Combo = 0
        _Bonus.FlatLower = 0
        _Bonus.FlatNumber = 0
        _BaseScore = 0
        _Score = 0
    End Sub

    Private Sub AnalyzePassword()

        For i = 0 To (_Password.Length - 1)
            If Regex.IsMatch(_ChrPassword(i), "[0-9]") Then
                _Num.Upper += 1
            ElseIf Regex.IsMatch(_ChrPassword(i), "[A-Z]") Then
                _Num.Numbers += 2
            ElseIf Regex.IsMatch(_ChrPassword(i), "\W") Then
                _Num.Symbols += 3
            End If
        Next

        'If _Match1.Success Then
        '        _Num.Upper += 1
        '    ElseIf _Match2.Success Then
        '    _Num.Numbers += 1
        'ElseIf _Match3.Success Then
        '    _Num.Symbols += 1
        'End If
        '    i += 1
        'Next

        _Num.Excess = _Password.Length - _MinPasswordLength

        If (_Num.Upper > 0 AndAlso _Num.Numbers > 0 AndAlso _Num.Symbols > 0) Then
            _Bonus.Combo = 25
        ElseIf (_Num.Upper > 0 AndAlso _Num.Numbers > 0) OrElse (_Num.Upper > 0 AndAlso _Num.Symbols > 0) OrElse (_Num.Numbers > 0 AndAlso _Num.Symbols > 0) Then
            _Bonus.Combo = 15
        End If

        If Regex.IsMatch(_Password, "^[\sa-z]+$") Then
            _Bonus.FlatLower = -15
        End If

        If Regex.IsMatch(_Password, "^[\s0-9]+$") Then
            _Bonus.FlatLower = -35
        End If

    End Sub

    Private Function OutputResultScore() As Integer
        _Score = _BaseScore + (_Num.Excess * _Bonus.Excess) + (_Num.Upper * _Bonus.Upper) + (_Num.Numbers * _Bonus.Numbers) + (_Num.Symbols * _Bonus.Symbols) + _Bonus.Combo + _Bonus.FlatLower + _Bonus.FlatNumber

        If _Score < 0 Then
            _Score = 0
        ElseIf _Score > 100 Then
            _Score = 100
        End If

        Return _Score
    End Function

    Private Function OutputResultText() As String
        _Result = String.Empty
        If _Password.Trim = "" Then
            _Result = "Password must not be empty"
        ElseIf _Password.Length < _MinPasswordLength Then
            _Result = "At least " & _MinPasswordLength & " characters please!"
        ElseIf _Score < 50 Then
            _Result = "Weak!"
        ElseIf (_Score >= 50 AndAlso _Score < 75) Then
            _Result = "Average!"
        ElseIf (_Score >= 75 AndAlso _Score < 100) Then
            _Result = "Strong!"
        ElseIf _Score >= 100 Then
            _Result = "Secure!"
        End If
        Return _Result
    End Function
#End Region

    Private _varFlagAutoSelect As Boolean

    <SupportedOSPlatform("windows")>
    Private Sub txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
        Call FontSearchBox(True)

        If Me.XOPilihSemuaSaatFokus AndAlso (MouseButtons = Windows.Forms.MouseButtons.None) Then
            Me.SelectAll()
            _varFlagAutoSelect = True
        End If
        If Me.XOHightlightSaatFokus Then
            MyBase.BackColor = Me.XOHightlightSaatFokusWarna
        End If
        If Me.XOPilihSemuaSaatFokus Then
            Me.Select(0, Me.Text.Length)
        End If
        'If Not HasKeyboard() Then
        '    'Call OSK
        '    Dim OSKProccess As Process = Nothing
        '    If OSKProccess Is Nothing OrElse OSKProccess.HasExited Then
        '        If OSKProccess IsNot Nothing AndAlso OSKProccess.HasExited Then
        '            OSKProccess.Close()
        '        End If
        '        OSKProccess = Process.Start("osk")
        '    End If
        'End If
    End Sub

    Private Sub txt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Control And e.KeyCode = Windows.Forms.Keys.A) Then
            Me.SelectAll()
        End If
    End Sub

    Private Sub txt_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
        _varFlagAutoSelect = False
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        If Me.XOAutoTrim Then
            Me.Text = Me.Text.Trim()
        End If

        If Me.ReadOnly = False Then
            If Me.XOHarusDiisi = True AndAlso Me.Text.Trim = "" Then
                MyBase.BackColor = Me.XOHarusDiisiWarnaLatar
            Else
                MyBase.BackColor = Me.XOHarusDiisiWarnaLatarDefault
            End If
        End If

        Call FontSearchBox(False)

        If (Me.XOPwdStrengthCalculate = True) Then
            Call InitPasswordStrength(MyBase.Text)
            Call AnalyzePassword()
            Me.XOPwdStrengthScore = OutputResultScore()
            Me.XOPwdStrengthText = OutputResultText()
        End If
    End Sub

    Private Sub txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        If Me.XOHightlightSaatFokus AndAlso Me.ReadOnly = False Then
            MyBase.BackColor = Me.XOHightlightSaatFokusWarna
        End If
    End Sub

    Private Sub txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        If Me.XOHightlightSaatFokus AndAlso Not Me.Focused AndAlso Me.ReadOnly = False Then
            MyBase.BackColor = Me.XOHarusDiisiWarnaLatarDefault
        End If
    End Sub

    Private Sub txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If Me.XOPilihSemuaSaatFokus AndAlso (Not _varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
            _varFlagAutoSelect = True
            Me.SelectAll()
        End If
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
        XOSQLText = SQLSafeText(Me)

        If Me.Text = Nothing Then
            XOSQLText = ""
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub FontSearchBox(ByVal OnFocus As Boolean)
        Try
            If Me.XOIsSearchBox = True Then
                If OnFocus = True AndAlso Me.Text = Me.XOSearchBoxText Then
                    Me.Text = ""
                    Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Regular)
                    Me.ForeColor = System.Drawing.SystemColors.WindowText
                ElseIf OnFocus = True AndAlso Me.Text = String.Empty Then

                ElseIf OnFocus = False AndAlso Me.Text = String.Empty Then
                    Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Italic)
                    Me.ForeColor = System.Drawing.Color.LightGray
                    Me.Text = Me.XOSearchBoxText
                End If
            Else
                MyBase.Font = New System.Drawing.Font(MyBase.Font, System.Drawing.FontStyle.Regular)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        If Me.XOHarusDiisi = True AndAlso Me.Text.Trim = "" Then
            Me.XOIsBlank = True
        Else
            Me.XOIsBlank = False
        End If
    End Sub

    '<SupportedOSPlatform("windows")>
    'Private Shared Function HasKeyboard() As IEnumerable
    '    Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Keyboard")
    '    Dim result = From mobj In searcher.Get()
    '                 Select mobj Where mobj("Status").ToString() = 0
    '    Return Not IsNothing(result)
    'End Function

    <SupportedOSPlatform("windows")>
    Public Sub ClearSearch()
        Call FontSearchBox(False)
    End Sub
End Class

''' <summary>
''' 
''' </summary>
Public Class Num
    Property Excess As Integer
    Property Upper As Integer
    Property Numbers As Integer
    Property Symbols As Integer
End Class

Public Class Bonus
    Property Excess As Integer = 3
    Property Upper As Integer = 4
    Property Numbers As Integer = 5
    Property Symbols As Integer = 5
    Property Combo As Integer
    Property FlatLower As Integer
    Property FlatNumber As Integer
End Class
