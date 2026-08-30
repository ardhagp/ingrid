Namespace UI.Control
    Public Class Meb
        Inherits System.Windows.Forms.MaskedTextBox

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call Component.Properties.ActivateLicenses()
            MyBase.Font = Component.Properties.globalFontTxt
            MyBase.Width = 206
            Me.XOIsMandatory = False
            Me.XOMandatoryBgColor = Drawing.Color.LightPink
            Me.XOMandatoryBgColorDefault = Drawing.Color.White
            Me.XOHighlightOnFocus = False
            Me.XOHighlightColor = Drawing.Color.LightYellow
            Me.XOSelectOnFocus = False
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether this component requires a value and must not be left empty during user input")>
        Private varIsMandatory As Boolean
        Public Property XOIsMandatory As Boolean
            Get
                Return varIsMandatory
            End Get
            Set(value As Boolean)
                varIsMandatory = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the background color applied to the component when it is marked as mandatory")>
        Private varMandatoryBgColor As System.Drawing.Color
        Public Property XOMandatoryBgColor As System.Drawing.Color
            Get
                Return varMandatoryBgColor
            End Get
            Set(value As System.Drawing.Color)
                varMandatoryBgColor = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the default background color restored when the component is no longer marked as mandatory")>
        Private varMandatoryBgColorDefault As System.Drawing.Color
        Public Property XOMandatoryBgColorDefault As System.Drawing.Color
            Get
                Return varMandatoryBgColorDefault
            End Get
            Set(value As System.Drawing.Color)
                varMandatoryBgColorDefault = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Highlights the component visually when it receives focus to guide user attention during data entry")>
        Private varHighlightOnFocus As Boolean
        Public Property XOHighlightOnFocus() As Boolean
            Get
                Return varHighlightOnFocus
            End Get
            Set(value As Boolean)
                varHighlightOnFocus = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the highlight color applied to the component when it receives focus")>
        Private varHighlightColor As System.Drawing.Color
        Public Property XOHighlightColor() As System.Drawing.Color
            Get
                Return varHighlightColor
            End Get
            Set(value As System.Drawing.Color)
                varHighlightColor = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Automatically selects all text within the component when it receives focus to simplify user editing")>
        Private varSelectOnFocus As Boolean
        Public Property XOSelectOnFocus() As Boolean
            Get
                Return varSelectOnFocus
            End Get
            Set(value As Boolean)
                varSelectOnFocus = value
            End Set
        End Property

        Private varFlagAutoSelect As Boolean
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Meb_GotFocus(sender As Object, e As System.EventArgs) Handles Me.GotFocus
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
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Meb_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Meb_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
            If Me.XOHighlightOnFocus Then
                MyBase.BackColor = Me.XOHighlightColor
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Meb_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
            If Me.XOHighlightOnFocus AndAlso Not Me.Focused Then
                MyBase.BackColor = Me.XOMandatoryBgColorDefault
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Meb_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            If Me.XOSelectOnFocus AndAlso (Not varFlagAutoSelect AndAlso Me.SelectionLength = 0) Then
                varFlagAutoSelect = True
                Me.SelectAll()
            End If
        End Sub
    End Class
End Namespace