Namespace UI.Control
    ''' <summary>
    ''' Custom split container
    ''' </summary>
    Public Class Spc
        Inherits System.Windows.Forms.SplitContainer

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call component.properties.ActivateLicenses()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace