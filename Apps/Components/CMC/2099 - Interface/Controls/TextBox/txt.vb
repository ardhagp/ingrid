Namespace UI.Control
    Public Class Txt
        Inherits System.Windows.Forms.TextBox

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontTxt
            MyBase.MaxLength = 255
            MyBase.Height = 23
            MyBase.Width = 206
            Me.XOIsMandatory = False
            Me.XOMandatoryBgColor = Drawing.Color.LightPink
            Me.XOMandatoryBgColorDefault = Drawing.Color.White
            Me.XOIsReplaceEmptyString = False
            Me.XOAutoTrim = False
            Me.XOHighlightOnFocus = False
            Me.XOHighlightColor = Drawing.Color.LightYellow
            Me.XOSelectOnFocus = False
            Me.XORestriction = UI.Control.ControlCodeBase.EnumRestriction.None
            Me.XOIsBlank = True
            Me.XOLetterCase = UI.Control.ControlCodeBase.EnumLetterCase.Normal
            Me.XOIsPlaceholder = False
            Me.XOPlaceholderText = "Type then press Enter"
            Me.XOPasswordLengthMin = 8
            Me.XOPasswordStrengthCalc = False
            Call FontSearchBox(True)
        End Sub

        Private varAutoTrim As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Automatically trims leading and trailing spaces from the component’s text value at runtime")>
        Public Property XOAutoTrim() As Boolean
            Get
                Return varAutoTrim
            End Get
            Set(value As Boolean)
                varAutoTrim = value
            End Set
        End Property

        Private varIsMandatory As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether this component requires a value and must not be left empty during user input")>
        Public Property XOIsMandatory As Boolean
            Get
                Return varIsMandatory
            End Get
            Set(value As Boolean)
                varIsMandatory = value
            End Set
        End Property

        Private varHighlightOnFocus As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Highlights the component visually when it receives focus to guide user attention during data entry")>
        Public Property XOHighlightOnFocus() As Boolean
            Get
                Return varHighlightOnFocus
            End Get
            Set(value As Boolean)
                varHighlightOnFocus = value
            End Set
        End Property

        Private varHighlightColor As System.Drawing.Color
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the highlight color applied to the component when it receives focus")>
        Public Property XOHighlightColor() As System.Drawing.Color
            Get
                Return varHighlightColor
            End Get
            Set(value As System.Drawing.Color)
                varHighlightColor = value
            End Set
        End Property

        Private varPasswordLengthMin As Integer
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Defines the minimum number of characters required for a valid password input")>
        Public Property XOPasswordLengthMin As Integer
            Get
                Return varPasswordLengthMin
            End Get
            Set(value As Integer)
                varPasswordLengthMin = value
            End Set
        End Property

        Private varPasswordStrengthCalc As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Determines whether the component evaluates and displays the strength level of the entered password")>
        Public Property XOPasswordStrengthCalc As Boolean
            Get
                Return varPasswordStrengthCalc
            End Get
            Set(value As Boolean)
                varPasswordStrengthCalc = value
            End Set
        End Property

        Private varPasswordStrengthScore As Integer
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Represents the calculated numeric score used to determine the strength level of the entered password")>
        Public Property XOPasswordStrengthScore As Integer
            Get
                Return varPasswordStrengthScore
            End Get
            Set(value As Integer)
                varPasswordStrengthScore = value
            End Set
        End Property

        Private varPasswordStrengthText As String
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Displays the descriptive strength label derived from the calculated password score")>
        Public Property XOPasswordStrengthText As String
            Get
                Return varPasswordStrengthText
            End Get
            Set(value As String)
                varPasswordStrengthText = value
            End Set
        End Property

        Private varReplaceEmptyString As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies whether empty or whitespace-only input should be automatically replaced with a predefined fallback value")>
        Public Property XOIsReplaceEmptyString As Boolean
            Get
                Return varReplaceEmptyString
            End Get
            Set(value As Boolean)
                varReplaceEmptyString = value
            End Set
        End Property

        Private varSqlText As String
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Contains the SQL command or query text associated with this component for data retrieval or processing")>
        Public Property XOSqlText As String
            Get
                Return varSqlText
            End Get
            Set(value As String)
                varSqlText = value
            End Set
        End Property

        Private varMandatoryBgColor As System.Drawing.Color
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the background color applied to the component when it is marked as mandatory")>
        Public Property XOMandatoryBgColor As System.Drawing.Color
            Get
                Return varMandatoryBgColor
            End Get
            Set(value As System.Drawing.Color)
                varMandatoryBgColor = value
            End Set
        End Property

        Private varMandatoryBgColorDefault As System.Drawing.Color
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the default background color restored when the component is no longer marked as mandatory")>
        Public Property XOMandatoryBgColorDefault As System.Drawing.Color
            Get
                Return varMandatoryBgColorDefault
            End Get
            Set(value As System.Drawing.Color)
                varMandatoryBgColorDefault = value
            End Set
        End Property

        Private varMandatoryMessage As String
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the validation message displayed when the component is mandatory but left empty by the user")>
        Public Property XOMandatoryMessage As String
            Get
                Return varMandatoryMessage
            End Get
            Set(value As String)
                varMandatoryMessage = value
            End Set
        End Property

        Private varSelectOnFocus As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Automatically selects all text within the component when it receives focus to simplify user editing")>
        Public Property XOSelectOnFocus() As Boolean
            Get
                Return varSelectOnFocus
            End Get
            Set(value As Boolean)
                varSelectOnFocus = value
            End Set
        End Property

        Private varIsBlank As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether the component’s current value is considered blank after applying trimming and normalization rules")>
        Public Property XOIsBlank() As Boolean
            Get
                Return varIsBlank
            End Get
            Set(value As Boolean)
                varIsBlank = value
            End Set
        End Property

        Private varLetterCase As UI.Control.ControlCodeBase.EnumLetterCase
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies how the component transforms its text value by applying the selected letter‑case rule")>
        Public Property XOLetterCase As UI.Control.ControlCodeBase.EnumLetterCase
            Get
                Return varLetterCase
            End Get
            Set(value As UI.Control.ControlCodeBase.EnumLetterCase)
                varLetterCase = value
            End Set
        End Property

        Private varRestriction As UI.Control.ControlCodeBase.EnumRestriction
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Defines the input restriction rule that limits which characters or patterns are allowed in the component")>
        Public Property XORestriction As UI.Control.ControlCodeBase.EnumRestriction
            Get
                Return varRestriction
            End Get
            Set(value As UI.Control.ControlCodeBase.EnumRestriction)
                varRestriction = value
            End Set
        End Property

        Private varIsPlaceholder As Boolean
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether the component behaves as a search box, enabling instant filtering or lookup as the user types")>
        Public Property XOIsPlaceholder As Boolean
            Get
                Return varIsPlaceholder
            End Get
            Set(value As Boolean)
                varIsPlaceholder = value
            End Set
        End Property

        Private varPlaceholderText As String
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the placeholder or prompt text displayed when the search box is empty")>
        Public Property XOPlaceholderText As String
            Get
                Return varPlaceholderText
            End Get
            Set(value As String)
                varPlaceholderText = value
            End Set
        End Property

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function SqlSafeText(txtControl As Txt) As String
            Dim varSqlSafeText As String = txtControl.Text

            If (txtControl.XOIsPlaceholder) AndAlso (txtControl.Text = txtControl.XOPlaceholderText) Then
                varSqlSafeText = String.Empty
            End If

            varSqlSafeText = varSqlSafeText.Replace("select ", "").Replace("'", "").Replace(";", "").Replace("--", "").Replace("drop table ", "").Replace("update ", "").Replace("insert into ", "").Replace("--", "").Replace("xp_", "").Trim
            If XOLetterCase = UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE Then
                varSqlSafeText = varSqlSafeText.ToUpper(System.Globalization.CultureInfo.CurrentCulture)
            ElseIf XOLetterCase = UI.Control.ControlCodeBase.EnumLetterCase.lowercase Then
                varSqlSafeText = varSqlSafeText.ToLower(System.Globalization.CultureInfo.CurrentCulture)
            End If

            Return varSqlSafeText
        End Function

        Private Sub CheckRestriction(valenurestriction As UI.Control.ControlCodeBase.EnumRestriction)
            Select Case valenurestriction
                ' No restriction, allow all input
                Case UI.Control.ControlCodeBase.EnumRestriction.None

                ' Do Only Number
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyNumber

                ' Do Only Number and Space
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyNumberAndSpace

                ' Do Only Number No Space
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyNumberNoSpace

                ' Do Only Text
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyText

                ' Do Only Text and Space
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyTextAndSpace

                ' Do Only Text No Space
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyTextNoSpace

                ' Do Text and Number
                Case UI.Control.ControlCodeBase.EnumRestriction.TextAndNumber

                ' Do Text Number and Space
                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberAndSpace

                ' Do Text Number No Space
                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberNoSpace

                ' Do Text and Symbol
                Case UI.Control.ControlCodeBase.EnumRestriction.TextAndSymbol

                ' Do Text Symbol and Space
                Case UI.Control.ControlCodeBase.EnumRestriction.TextSymbolAndSpace

                ' Do Text Symbol No Space
                Case UI.Control.ControlCodeBase.EnumRestriction.TextSymbolNoSpace

                ' Do Number Symbol and Space
                Case UI.Control.ControlCodeBase.EnumRestriction.NumberSymbolAndSpace

                ' Do Number Symbol No Space
                Case UI.Control.ControlCodeBase.EnumRestriction.NumberSymbolNoSpace

                ' Do Text Number Symbol and Space
                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberSymbolAndSpace

                ' Do Text Number Symbol No Space
                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberSymbolNoSpace

                ' Do Email
                Case UI.Control.ControlCodeBase.EnumRestriction.Email

            End Select
        End Sub

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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
            ' Fast path: always allow control characters (backspace, enter, etc.)
            Dim ch As Char = e.KeyChar
            If Char.IsControl(ch) Then
                Return
            End If

            ' Cache property to avoid repeated property access overhead
            Dim restriction = Me.XORestriction

            Select Case restriction
                ' ---------------------------------------------------------
                ' NONE
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.None
                ' Allow everything


                ' ---------------------------------------------------------
                ' ONLY NUMBER
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyNumber
                    If Not Char.IsDigit(ch) Then e.Handled = True
                    ' Allow only digits

                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyNumberNoSpace
                    If Not Char.IsDigit(ch) Then e.Handled = True
                    ' Allow only digits (no space)

                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyNumberAndSpace
                    If Not (Char.IsDigit(ch) OrElse ch = " "c) Then e.Handled = True
                    ' Allow only digits and space


                ' ---------------------------------------------------------
                ' ONLY TEXT
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyText
                    If Not Char.IsLetter(ch) Then e.Handled = True
                    ' Allow only letters

                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyTextNoSpace
                    If Not Char.IsLetter(ch) Then e.Handled = True
                    ' Allow only letters (no space)

                Case UI.Control.ControlCodeBase.EnumRestriction.OnlyTextAndSpace
                    If Not (Char.IsLetter(ch) OrElse ch = " "c) Then e.Handled = True
                    ' Allow only letters and space


                ' ---------------------------------------------------------
                ' TEXT + NUMBER
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.TextAndNumber
                    If Not Char.IsLetterOrDigit(ch) Then e.Handled = True
                    ' Allow letters and digits

                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberNoSpace
                    If Not Char.IsLetterOrDigit(ch) Then e.Handled = True
                    ' Allow letters and digits (no space)

                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberAndSpace
                    If Not (Char.IsLetterOrDigit(ch) OrElse ch = " "c) Then e.Handled = True
                    ' Allow letters, digits, and space


                ' ---------------------------------------------------------
                ' TEXT + SYMBOL
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.TextAndSymbol
                    If Not (Char.IsLetterOrDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch)) Then e.Handled = True
                    ' Allow letters, digits, punctuation, symbols

                Case UI.Control.ControlCodeBase.EnumRestriction.TextSymbolNoSpace
                    If Not (Char.IsLetterOrDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch)) Then e.Handled = True
                    ' Allow letters, digits, punctuation, symbols (no space)

                Case UI.Control.ControlCodeBase.EnumRestriction.TextSymbolAndSpace
                    If Not (Char.IsLetterOrDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch) OrElse ch = " "c) Then e.Handled = True
                    ' Allow letters, digits, punctuation, symbols, and space


                ' ---------------------------------------------------------
                ' NUMBER + SYMBOL (NEW)
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.NumberSymbolAndSpace
                    If Not (Char.IsDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch) OrElse ch = " "c) Then e.Handled = True
                    ' Allow digits, punctuation, symbols, and space

                Case UI.Control.ControlCodeBase.EnumRestriction.NumberSymbolNoSpace
                    If Not (Char.IsDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch)) Then e.Handled = True
                    ' Allow digits, punctuation, and symbols (no space)


                ' ---------------------------------------------------------
                ' TEXT + NUMBER + SYMBOL (NEW)
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberSymbolAndSpace
                    If Not (Char.IsLetterOrDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch) OrElse ch = " "c) Then e.Handled = True
                    ' Allow letters, digits, punctuation, symbols, and space

                Case UI.Control.ControlCodeBase.EnumRestriction.TextNumberSymbolNoSpace
                    If Not (Char.IsLetterOrDigit(ch) OrElse Char.IsPunctuation(ch) OrElse Char.IsSymbol(ch)) Then e.Handled = True
                    ' Allow letters, digits, punctuation, and symbols (no space)


                ' ---------------------------------------------------------
                ' EMAIL
                ' ---------------------------------------------------------
                Case UI.Control.ControlCodeBase.EnumRestriction.Email
                    ' Use a single static string for allowed characters to avoid reallocating on each keypress
                    Static allowedChars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@._-"
                    If Not allowedChars.Contains(ch, StringComparison.Ordinal) Then e.Handled = True
                    ' Allow only letters, digits, and specific email characters (@, ., _, -)
            End Select
        End Sub

        Private varFlagAutoSelect As Boolean

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
            Call FontSearchBox(True)

            If Me.XOSelectOnFocus AndAlso (MouseButtons = System.Windows.Forms.MouseButtons.None) Then
                Me.SelectAll()
                varFlagAutoSelect = True
            End If
            If Me.XOHighlightOnFocus Then
                MyBase.BackColor = Me.XOHighlightColor
            End If
            If Me.XOSelectOnFocus Then
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            If (e.Control AndAlso e.KeyCode = System.Windows.Forms.Keys.A) Then
                Me.SelectAll()
            End If
        End Sub

        Private Sub Txt_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave
            varFlagAutoSelect = False
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
            If Me.XOAutoTrim Then
                Me.Text = Me.Text.Trim()
            End If

            If Not (Me.ReadOnly) Then
                If (Me.XOIsMandatory) AndAlso Me.Text.Trim = String.Empty Then
                    MyBase.BackColor = Me.XOMandatoryBgColor
                Else
                    MyBase.BackColor = Me.XOMandatoryBgColorDefault
                End If
            End If

            Call FontSearchBox(False)

            If (Me.XOPasswordStrengthCalc) Then
                Call InitPasswordStrength(MyBase.Text)
                Call AnalyzePassword()
                Me.XOPasswordStrengthScore = OutputResultScore()
                Me.XOPasswordStrengthText = OutputResultText()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
            If Me.XOHighlightOnFocus AndAlso Not (Me.ReadOnly) Then
                MyBase.BackColor = Me.XOHighlightColor
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            If Me.XOHighlightOnFocus AndAlso Not Me.Focused AndAlso Not (Me.ReadOnly) Then
                If Me.XOIsMandatory AndAlso Me.XOSqlText.Trim = String.Empty Then
                    MyBase.BackColor = Me.XOMandatoryBgColor
                Else
                    MyBase.BackColor = Me.XOMandatoryBgColorDefault
                End If
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            If Me.XOSelectOnFocus AndAlso (Not varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
                varFlagAutoSelect = True
                Me.SelectAll()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_TextChanged(sender As Object, e As System.EventArgs) Handles Me.TextChanged
            XOSqlText = SqlSafeText(Me)

            If Me.Text = String.Empty Then
                XOSqlText = String.Empty
                XOIsBlank = True
            Else
                XOIsBlank = False
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub FontSearchBox(onfocus As Boolean)
            Try
                If (Me.XOIsPlaceholder) Then
                    If (onfocus) AndAlso Me.Text = Me.XOPlaceholderText Then
                        Me.Text = String.Empty
                        Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Regular)
                        Me.ForeColor = System.Drawing.SystemColors.WindowText
                        'ElseIf (onfocus) AndAlso Me.Text = String.Empty Then
                    ElseIf Not (onfocus) AndAlso Me.Text = String.Empty Then
                        Me.Font = New System.Drawing.Font(Me.Font, System.Drawing.FontStyle.Italic)
                        Me.ForeColor = System.Drawing.Color.LightGray
                        Me.Text = Me.XOPlaceholderText
                    End If
                Else
                    MyBase.Font = New System.Drawing.Font(MyBase.Font, System.Drawing.FontStyle.Regular)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Txt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Validating
            If (Me.XOIsMandatory) AndAlso Me.Text.Trim = String.Empty Then
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
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