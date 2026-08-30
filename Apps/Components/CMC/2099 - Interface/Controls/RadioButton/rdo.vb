Imports System.Runtime.Versioning

Namespace UI.Control
    ''' <summary>
    ''' Custom radio button
    ''' </summary>
    Public Class Rdo
        Inherits System.Windows.Forms.RadioButton

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontLbl
            MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace