Namespace UI.Control
    Public Class Gbx
        Inherits System.Windows.Forms.GroupBox

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontLbl
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace