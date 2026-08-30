Namespace UI.Control
    Public Class Stt
        ''' <summary>
        ''' Custom status strip
        ''' </summary>
        Inherits System.Windows.Forms.StatusStrip

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace