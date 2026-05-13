Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class rdo
        Inherits System.Windows.Forms.RadioButton

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontLbl
            MyBase.FlatStyle = system.Windows.Forms.FlatStyle.Flat
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace