Namespace UI.Control
    Public Class Lnk
        Inherits System.Windows.Forms.LinkLabel

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontLbl
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace