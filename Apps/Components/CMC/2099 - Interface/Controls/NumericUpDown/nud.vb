Namespace UI.Control
    Public Class Nud
        Inherits System.Windows.Forms.NumericUpDown

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Height = 23
            MyBase.Width = 206
            MyBase.Font = Component.Properties.globalFontTxt
            Me.XOHighlightOnFocus = False
            Me.XOHighlightColor = Drawing.Color.LightYellow
            Me.XOSelectOnFocus = False
            MyBase.DoubleBuffered = True
        End Sub


#Region "Properties"
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Automatically trims leading and trailing spaces from the component’s text value at runtime")>
        Private varAutoTrim As Boolean
        Public Property XOAutoTrim() As Boolean
            Get
                Return varAutoTrim
            End Get
            Set(value As Boolean)
                varAutoTrim = value
            End Set
        End Property

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
            System.ComponentModel.Description("Highlights the component visually when it receives focus to guide user attention during data entry")>
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

#End Region
    End Class
End Namespace