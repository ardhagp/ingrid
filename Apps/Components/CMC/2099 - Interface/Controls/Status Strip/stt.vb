Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class Stt
        ''' <summary>
        ''' Custom statusstrip
        ''' </summary>
        Inherits System.Windows.Forms.StatusStrip

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace