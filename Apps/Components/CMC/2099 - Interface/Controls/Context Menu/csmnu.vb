Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class Csmnu
        Inherits System.Windows.Forms.ContextMenuStrip

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
        End Sub

    End Class
End Namespace