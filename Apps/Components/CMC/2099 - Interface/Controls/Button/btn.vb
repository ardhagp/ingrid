Imports System.ComponentModel
Imports System.Runtime.Versioning

Namespace UI.Control
    ''' <project>CMCC</project>
    ''' <author>Ardha Gp</author>
    ''' <summary>
    ''' Custom button
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Btn
        Inherits System.Windows.Forms.Button
        Public Event ValidasiBerhasil()

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            MyBase.FlatAppearance.BorderSize = 2
            'MyBase.BackColor = System.Drawing.Color.Orange
            MyBase.Size = New System.Drawing.Size(100, 40)
            MyBase.Cursor = System.Windows.Forms.Cursors.Hand
            MyBase.Font = globalFontBtn
            'Me.XOShowBorder = False
            Me.XOShowBorderOnFocus = False
            Me.XOButtonType = UI.Control.ControlCodeBase.ButtonType.Default
            MyBase.DoubleBuffered = True
        End Sub

        Private varButtonType As UI.Control.ControlCodeBase.ButtonType
        <SupportedOSPlatform("windows")>
        <Category("Button"),
    Description("Button type will affect (background color, font type) of the button")>
        Public Property XOButtonType() As UI.Control.ControlCodeBase.ButtonType
            Get
                Return varButtonType
            End Get
            Set(value As UI.Control.ControlCodeBase.ButtonType)
                varButtonType = value
                ChangeButtonColor(value)
            End Set
        End Property

        Private varValidateAllInput As Boolean
        ''' <summary>
        ''' Validate all input from textbox in the form
        ''' </summary>
        ''' <returns>True if all input is valid, otherwise False</returns>
        <Category("Button"),
    Description("Validate all input from textbox")>
        Public Property XOValidateAllInput() As Boolean
            Get
                Return varValidateAllInput
            End Get
            Set(value As Boolean)
                varValidateAllInput = value
            End Set
        End Property

        Private varValidateAllInputTag As String
        ''' <summary>
        ''' Validate all input from textbox with the same tag
        ''' </summary>
        ''' <returns>Tag of the input to be validated</returns>
        <Category("Button"),
    Description("Validate all input with this tag")>
        Public Property XOValidateAllInputTag() As String
            Get
                Return varValidateAllInputTag
            End Get
            Set(value As String)
                varValidateAllInputTag = value
            End Set
        End Property

        'Private _varStatusTeks As String
        '<Category("Text"), _
        'Description("Teks yang ditampilkan pada bilah status")> _
        'Public Property SLFStatusTeks() As String
        '    Get
        '        Return _varStatusTeks
        '    End Get
        '    Set(value As String)
        '        _varStatusTeks = value
        '    End Set
        'End Property

        'Private _varStatusTeksKomponen As CMCv.stt
        '<Category("Text"), _
        'Description("Tulisan yang tampil di status")> _
        'Public Property SLFStatusTeksKomponen(Optional ByVal KomponenStatus As CMCv.stt = Nothing) As CMCv.stt
        '    Get
        '        Return _varStatusTeksKomponen
        '    End Get
        '    Set(value As CMCv.stt)
        '        _varStatusTeksKomponen = value
        '    End Set
        'End Property

        ''' <summary>
        ''' Change button color based on button type
        ''' </summary>
        ''' <param name="enubuttontype">Button type</param>
        <SupportedOSPlatform("windows")>
        Private Sub ChangeButtonColor(enubuttontype As UI.Control.ControlCodeBase.ButtonType)
            Select Case enubuttontype
                Case UI.Control.ControlCodeBase.ButtonType.Yes
                    MyBase.BackColor = Drawing.Color.LimeGreen
                    MyBase.ForeColor = Drawing.Color.White
                Case UI.Control.ControlCodeBase.ButtonType.No
                    MyBase.BackColor = Drawing.Color.Red
                    MyBase.ForeColor = Drawing.Color.White
                Case UI.Control.ControlCodeBase.ButtonType.Default
                    MyBase.BackColor = Drawing.Color.RoyalBlue
                    MyBase.ForeColor = Drawing.Color.White
                Case UI.Control.ControlCodeBase.ButtonType.Warning
                    MyBase.BackColor = Drawing.Color.Yellow
                    MyBase.ForeColor = Drawing.Color.Black
                Case UI.Control.ControlCodeBase.ButtonType.Disabled
                    MyBase.BackColor = Drawing.Color.Gray
                    MyBase.ForeColor = Drawing.Color.DarkGray
                Case UI.Control.ControlCodeBase.ButtonType.Custom
                    'MyBase.BackColor = System.Drawing.Color.Orange
                    'MyBase.ForeColor = Drawing.Color.Black
            End Select
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Btn_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
            If Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat Then
                MyBase.FlatAppearance.BorderColor = UI.Control.ControlCodeBase.GetColor(MyBase.BackColor, UI.Control.ControlCodeBase.EnumColorRange.Darker, 60)
                MyBase.FlatAppearance.MouseOverBackColor = UI.Control.ControlCodeBase.GetColor(MyBase.BackColor, UI.Control.ControlCodeBase.EnumColorRange.Lighter, 20)
            End If
        End Sub

        Private varShowBorderOnFocus As Boolean
        Protected Overrides ReadOnly Property ShowFocusCues() As Boolean
            Get
                Return varShowBorderOnFocus
            End Get
        End Property

        ''' <summary>
        ''' Show border when button is focused
        ''' </summary>
        ''' <returns>True if the border is shown when focused, otherwise False</returns>
        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether the button displays a visual border highlight when it receives focus")>
        Public Property XOShowBorderOnFocus() As Boolean
            Get
                Return varShowBorderOnFocus
            End Get
            Set(value As Boolean)
                varShowBorderOnFocus = value
            End Set
        End Property
    End Class
End Namespace