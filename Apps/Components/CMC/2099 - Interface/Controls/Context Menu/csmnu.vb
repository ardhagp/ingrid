Imports System.Runtime.Versioning

Public Class csmnu
    Inherits System.Windows.Forms.ContextMenuStrip

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
    End Sub

End Class
