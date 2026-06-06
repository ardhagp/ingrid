Imports System.Runtime.Versioning

Namespace UI.Control
    ''' <summary>
    ''' Custom split container
    ''' </summary>
    Public Class Spc
        Inherits System.Windows.Forms.SplitContainer

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace