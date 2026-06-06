Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class Lbl
        Inherits System.Windows.Forms.Label

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontTxt
            Me.XOCustomElipsis = False
            'Me.SLFTypeOfElipsis = TextFormatFlags.Default
            MyBase.DoubleBuffered = True
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Specifies the custom ellipsis text displayed when the progress message exceeds the available space")>
        Private varCustomElipsis As Boolean
        Public Property XOCustomElipsis As Boolean
            Get
                Return varCustomElipsis
            End Get
            Set(value As Boolean)
                varCustomElipsis = value
            End Set
        End Property
    End Class
End Namespace