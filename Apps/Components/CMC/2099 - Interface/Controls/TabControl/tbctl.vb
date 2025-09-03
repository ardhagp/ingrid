Imports System.Runtime.Versioning

Public Class tbctl
    Inherits System.Windows.Forms.TabControl

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
    End Sub


End Class
