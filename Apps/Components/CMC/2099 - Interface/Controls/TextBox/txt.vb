Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace UI.Control
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
        Private varAutoTrim As Boolean
        Public Property XOAutoTrim() As Boolean
            Get
                Return varAutoTrim
            End Get
            Set(value As Boolean)
                varAutoTrim = value
            End Set
        End Property

        <Category("Text"),
    Description("Teksboks harus diisi")>
        Private varHarusDiisi As Boolean
        Public Property XOHarusDiisi As Boolean
            Get
                Return varHarusDiisi
            End Get
            Set(value As Boolean)
                varHarusDiisi = value
            End Set
        End Property

        Private varHightlightSaatFokus As Boolean
        <Category("Text"),
    Description("Jenis tombol akan mempengaruhi (warna latar, jenis font) tombol")>
        Public Property XOHightlightSaatFokus() As Boolean
            Get
                Return varHightlightSaatFokus
            End Get
            Set(value As Boolean)
                varHightlightSaatFokus = value
            End Set
        End Property

        Private varHighlightSaatFokusWarna As System.Drawing.Color
        <Category("Text"),
    Description("Warna highlight")>
        Public Property XOHightlightSaatFokusWarna() As System.Drawing.Color
            Get
                Return varHighlightSaatFokusWarna
            End Get
            Set(value As System.Drawing.Color)
                varHighlightSaatFokusWarna = value
            End Set
        End Property

        <Category("Text"),
   Description("Panjang password minimum")>
        Private varPwdLengthMin As Integer
        Public Property XOPwdLengthMin As Integer
            Get
                Return varPwdLengthMin
            End Get
            Set(value As Integer)
                varPwdLengthMin = value
            End Set
        End Property

        <Category("Text"),
   Description("Aktifkan penghitung kekuatan password")>
        Private varPwdStrengthCalculate As Boolean
        Public Property XOPwdStrengthCalculate As Boolean
            Get
                Return varPwdStrengthCalculate
            End Get
            Set(value As Boolean)
                varPwdStrengthCalculate = value
            End Set
        End Property

        <Category("Text"),
   Description("Indikator kekuatan password (skor)")>
        Private varPwdStrengthScore As Integer
        Public Property XOPwdStrengthScore As Integer
            Get
                Return varPwdStrengthScore
            End Get
            Set(value As Integer)
                varPwdStrengthScore = value
            End Set
        End Property

        <Category("Text"),
   Description("Indikator kekuatan password (teks)")>
        Private varPwdStrengthText As String
        Public Property XOPwdStrengthText As String
            Get
                Return varPwdStrengthText
            End Get
            Set(value As String)
                varPwdStrengthText = value
            End Set
        End Property

        <Category("Text"),
   Description("Mengisi teksboks kosong dengan tanda (-)")>
        Private varTanpaSpasi As Boolean
        Public Property XOTanpaSpasi As Boolean
            Get
                Return varTanpaSpasi
            End Get
            Set(value As Boolean)
                varTanpaSpasi = value
            End Set
        End Property

        <Category("Text"),
   Description("Teks yang dikonversi untuk sql")>
        Private varSQLText As String
        Public Property XOSQLText As String
            Get
                Return varSQLText
            End Get
            Set(value As String)
                varSQLText = value
            End Set
        End Property

        Private varHarusDiisiWarnaLatar As System.Drawing.Color
        <Category("Text"),
    Description("Warna saat teksboks tidak diisi")>
        Public Property XOHarusDiisiWarnaLatar As System.Drawing.Color
            Get
                Return varHarusDiisiWarnaLatar
            End Get
            Set(value As System.Drawing.Color)
                varHarusDiisiWarnaLatar = value
            End Set
        End Property

        Private varHarusDiisiWarnaLatarDefault As System.Drawing.Color
        <Category("Text"),
    Description("Warna saat teksboks tidak diisi jika bernilai False")>
        Public Property XOHarusDiisiWarnaLatarDefault As System.Drawing.Color
            Get
                Return varHarusDiisiWarnaLatarDefault
            End Get
            Set(value As System.Drawing.Color)
                varHarusDiisiWarnaLatarDefault = value
            End Set
        End Property

        Private varValidasiField As String
        <Category("Text"),
    Description("Field yang ditampilkan saat validasi tidak diisi")>
        Public Property XOValidasiField As String
            Get
                Return varValidasiField
            End Get
            Set(value As String)
                varValidasiField = value
            End Set
        End Property

        Private varPilihSemuaSaatFokus As Boolean
        <System.ComponentModel.Category("Text"),
    System.ComponentModel.Description("Memilih semua teks saat fokus")>
        Public Property XOPilihSemuaSaatFokus() As Boolean
            Get
                Return varPilihSemuaSaatFokus
            End Get
            Set(value As Boolean)
                varPilihSemuaSaatFokus = value
            End Set
        End Property

        Private varIsBlank As Boolean
        ''' <summary>
        ''' Nilai ini terisi secara otomatis
        ''' </summary>
        ''' <value>True/False</value>
        ''' <returns>True/False</returns>
        ''' <remarks></remarks>
        Public Property XOIsBlank() As Boolean
            Get
                Return varIsBlank
            End Get
            Set(value As Boolean)
                varIsBlank = value
            End Set
        End Property

        Private varJenisKapital As ControlCodeBase.enuJenisKapital
        <Category("Text"),
    Description("Isi akan diubah menjadi kapital semua")>
        Public Property XOJenisKapital As ControlCodeBase.enuJenisKapital
            Get
                Return varJenisKapital
            End Get
            Set(value As ControlCodeBase.enuJenisKapital)
                varJenisKapital = value
            End Set
        End Property

        Private varRestriction As ControlCodeBase.enuRestriction
        Public Property XORestriction As ControlCodeBase.enuRestriction
            Get
                Return varRestriction
            End Get
            Set(value As ControlCodeBase.enuRestriction)
                varRestriction = value
            End Set
        End Property

        Private varIsSearchBox As Boolean
        Public Property XOIsSearchBox As Boolean
            Get
                Return varIsSearchBox
            End Get
            Set(value As Boolean)
                varIsSearchBox = value
            End Set
        End Property

        Private varSearchBoxText As String
        Public Property XOSearchBoxText As String
            Get
                Return varSearchBoxText
            End Get
            Set(value As String)
                varSearchBoxText = value
            End Set
        End Property
#End Region

#Region "Function"
        Private Function SqlSafeText(txtControl As txt) As String
            Dim varSqlSafeText As String = txtControl.Text

            If (txtControl.XOIsSearchBox) AndAlso (txtControl.Text = txtControl.XOSearchBoxText) Then
                varSqlSafeText = String.Empty
            End If

            varSqlSafeText = varSqlSafeText.Replace("select ", "").Replace("'", "").Replace(";", "").Replace("--", "").Replace("drop table ", "").Replace("update ", "").Replace("insert into ", "").Replace("--", "").Replace("xp_", "").Trim
            If XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA Then
                varSqlSafeText = varSqlSafeText.ToUpper(CultureInfo.CurrentCulture)
            ElseIf XOJenisKapital = ControlCodeBase.enuJenisKapital.kecilsemua Then
                varSqlSafeText = varSqlSafeText.ToLower(CultureInfo.CurrentCulture)
            End If

            Return varSqlSafeText
        End Function

        Private Sub CheckRestriction(valenurestriction As ControlCodeBase.enuRestriction)
            Select Case valenurestriction
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
        Private varPassword As String
        Private varChrPassword() As Char
        Private varMinPasswordLength As Integer = 8
        Private varBaseScore As Integer
        Private varScore As Integer
        Private varResult As String
        Private varBonus As New Bonus
        Private varSecurityScore As New SecurityScore

        Private Sub InitPasswordStrength(userinput As String)
            varPassword = userinput
            varChrPassword = varPassword.ToCharArray()

            varSecurityScore.Excess = 0
            varSecurityScore.Upper = 0
            varSecurityScore.Numbers = 0
            varSecurityScore.Symbols = 0
            varBonus.Combo = 0
            varBonus.FlatLower = 0
            varBonus.FlatNumber = 0
            varBaseScore = 0
            varScore = 0
        End Sub

        Private Sub AnalyzePassword()
            ' Character scoring
            For i = 0 To varPassword.Length - 1
                Dim ch As Char = varPassword(i)

                If Char.IsDigit(ch) Then
                    varSecurityScore.Numbers += 2

                ElseIf Char.IsUpper(ch) Then
                    varSecurityScore.Upper += 1

                ElseIf Not Char.IsLetterOrDigit(ch) Then
                    varSecurityScore.Symbols += 3
                End If
            Next

            ' Excess length bonus
            varSecurityScore.Excess = varPassword.Length - varMinPasswordLength

            ' Combo bonus
            If (varSecurityScore.Upper > 0 AndAlso varSecurityScore.Numbers > 0 AndAlso varSecurityScore.Symbols > 0) Then
                varBonus.Combo = 25

            ElseIf (varSecurityScore.Upper > 0 AndAlso varSecurityScore.Numbers > 0) _
    OrElse (varSecurityScore.Upper > 0 AndAlso varSecurityScore.Symbols > 0) _
    OrElse (varSecurityScore.Numbers > 0 AndAlso varSecurityScore.Symbols > 0) Then

                varBonus.Combo = 15
            End If

            ' Flat penalties (LINQ versions)
            If varPassword.All(Function(ch) Char.IsLower(ch) OrElse Char.IsWhiteSpace(ch)) Then
                varBonus.FlatLower = -15
            End If

            If varPassword.All(Function(ch) Char.IsDigit(ch) OrElse Char.IsWhiteSpace(ch)) Then
                varBonus.FlatLower = -35
            End If
        End Sub

        Private Function OutputResultScore() As Integer
            varScore = varBaseScore + (varSecurityScore.Excess * varBonus.Excess) + (varSecurityScore.Upper * varBonus.Upper) + (varSecurityScore.Numbers * varBonus.Numbers) + (varSecurityScore.Symbols * varBonus.Symbols) + varBonus.Combo + varBonus.FlatLower + varBonus.FlatNumber

            If varScore < 0 Then
                varScore = 0
            ElseIf varScore > 100 Then
                varScore = 100
            End If

            Return varScore
        End Function

        Private Function OutputResultText() As String
            varResult = String.Empty
            If varPassword.Trim = "" Then
                varResult = "Password must not be empty"
            ElseIf varPassword.Length < varMinPasswordLength Then
                varResult = "At least " & varMinPasswordLength & " characters please!"
            ElseIf varScore < 50 Then
                varResult = "Weak!"
            ElseIf (varScore >= 50 AndAlso varScore < 75) Then
                varResult = "Average!"
            ElseIf (varScore >= 75 AndAlso varScore < 100) Then
                varResult = "Strong!"
            ElseIf varScore >= 100 Then
                varResult = "Secure!"
            End If
            Return varResult
        End Function
#End Region

        Private Sub Txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
            ' Fast path: always allow control characters (backspace, enter, etc.)
            Dim ch As Char = e.KeyChar
            If Char.IsControl(ch) Then
                Return
            End If

            ' Cache property to avoid repeated property access overhead
            Dim restriction = Me.XORestriction

            Select Case restriction
                Case ControlCodeBase.enuRestriction.None
                ' Allow all input

                Case ControlCodeBase.enuRestriction.OnlyNumber
                    If Not Char.IsDigit(ch) Then
                        e.Handled = True
                    End If

                Case ControlCodeBase.enuRestriction.OnlyText
                    If Not Char.IsLetter(ch) Then
                        e.Handled = True
                    End If

                Case ControlCodeBase.enuRestriction.TextAndNumber
                    If Not Char.IsLetterOrDigit(ch) Then
                        e.Handled = True
                    End If

                Case ControlCodeBase.enuRestriction.TextAndSymbol
                    ' Allow letters, digits, punctuation, symbols
                    If Not (Char.IsLetterOrDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch)) Then
                        e.Handled = True
                    End If

                Case ControlCodeBase.enuRestriction.Email
                    ' Use a single static string for allowed characters to avoid reallocating on each keypress
                    Static allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-"
                    If Not allowedChars.Contains(ch, StringComparison.Ordinal) Then
                        e.Handled = True
                    End If
            End Select
        End Sub


        Private varFlagAutoSelect As Boolean

        <SupportedOSPlatform("windows")>
        Private Sub txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
            Call FontSearchBox(True)

            If Me.XOPilihSemuaSaatFokus AndAlso (MouseButtons = system.Windows.Forms.MouseButtons.None) Then
                Me.SelectAll()
                varFlagAutoSelect = True
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
            If (e.Control AndAlso e.KeyCode = system.Windows.Forms.Keys.A) Then
                Me.SelectAll()
            End If
        End Sub

        Private Sub txt_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
            varFlagAutoSelect = False
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
            If Me.XOAutoTrim Then
                Me.Text = Me.Text.Trim()
            End If

            If Not (Me.ReadOnly) Then
                If (Me.XOHarusDiisi) AndAlso Me.Text.Trim = String.Empty Then
                    MyBase.BackColor = Me.XOHarusDiisiWarnaLatar
                Else
                    MyBase.BackColor = Me.XOHarusDiisiWarnaLatarDefault
                End If
            End If

            Call FontSearchBox(False)

            If (Me.XOPwdStrengthCalculate) Then
                Call InitPasswordStrength(MyBase.Text)
                Call AnalyzePassword()
                Me.XOPwdStrengthScore = OutputResultScore()
                Me.XOPwdStrengthText = OutputResultText()
            End If
        End Sub

        Private Sub txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
            If Me.XOHightlightSaatFokus AndAlso Not (Me.ReadOnly) Then
                MyBase.BackColor = Me.XOHightlightSaatFokusWarna
            End If
        End Sub

        Private Sub txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            If Me.XOHightlightSaatFokus AndAlso Not Me.Focused AndAlso Not (Me.ReadOnly) Then
                MyBase.BackColor = Me.XOHarusDiisiWarnaLatarDefault
            End If
        End Sub

        Private Sub txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            If Me.XOPilihSemuaSaatFokus AndAlso (Not varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
                varFlagAutoSelect = True
                Me.SelectAll()
            End If
        End Sub

        Private Sub txt_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
            XOSQLText = SQLSafeText(Me)

            If Me.Text = String.Empty Then
                XOSQLText = String.Empty
                XOIsBlank = True
            Else
                XOIsBlank = False
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub FontSearchBox(onfocus As Boolean)
            Try
                If (Me.XOIsSearchBox) Then
                    If (onfocus) AndAlso Me.Text = Me.XOSearchBoxText Then
                        Me.Text = String.Empty
                        Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Regular)
                        Me.ForeColor = System.Drawing.SystemColors.WindowText
                        'ElseIf (onfocus) AndAlso Me.Text = String.Empty Then
                    ElseIf Not (onfocus) AndAlso Me.Text = String.Empty Then
                        Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Italic)
                        Me.ForeColor = System.Drawing.Color.LightGray
                        Me.Text = Me.XOSearchBoxText
                    End If
                Else
                    MyBase.Font = New System.Drawing.Font(MyBase.Font, System.Drawing.FontStyle.Regular)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Private Sub txt_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
            If (Me.XOHarusDiisi) AndAlso Me.Text.Trim = String.Empty Then
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
    Public Class SecurityScore
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
End Namespace