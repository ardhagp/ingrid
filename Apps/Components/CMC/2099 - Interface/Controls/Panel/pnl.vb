Imports System.Runtime.Versioning

Namespace UI.Control
    ''' <summary>
    ''' Custom panel
    ''' </summary>
    Public Class Pnl
        Inherits System.Windows.Forms.Panel

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace