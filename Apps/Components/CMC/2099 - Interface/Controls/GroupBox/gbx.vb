Imports System.Runtime.Versioning

Public Class gbx
    Inherits System.Windows.Forms.GroupBox

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
        MyBase.DoubleBuffered = True
    End Sub
End Class
