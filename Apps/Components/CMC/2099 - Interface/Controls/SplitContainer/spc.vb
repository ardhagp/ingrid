Imports System.Runtime.Versioning

Public Class spc
    Inherits System.Windows.Forms.SplitContainer

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.DoubleBuffered = True
    End Sub
End Class
