Imports System.Runtime.Versioning

Public Class mnu
    Inherits System.Windows.Forms.MenuStrip

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub

End Class
