Namespace UI.Control
    ''' <summary>
    ''' Custom panel
    ''' </summary>
    Public Class Pnl
        Inherits System.Windows.Forms.Panel

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace