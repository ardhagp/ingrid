Imports System.Runtime.Versioning

Public Class lnklbl
    Inherits System.Windows.Forms.LinkLabel

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
        MyBase.DoubleBuffered = True
    End Sub
End Class
