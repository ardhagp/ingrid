Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class Tbx
        Inherits System.Windows.Forms.TabControl

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontLbl
        End Sub
    End Class
End Namespace