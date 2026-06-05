Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class Tv
        ''' <summary>
        ''' Custom treeview
        ''' </summary>
        Inherits System.Windows.Forms.TreeView

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
        End Sub
    End Class
End Namespace