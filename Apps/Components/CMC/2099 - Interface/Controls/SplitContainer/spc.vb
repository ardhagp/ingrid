Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class spc
        Inherits System.Windows.Forms.SplitContainer

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace