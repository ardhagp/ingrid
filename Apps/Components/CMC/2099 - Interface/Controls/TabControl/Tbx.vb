Namespace UI.Control
    Public Class Tbx
        Inherits System.Windows.Forms.TabControl

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontLbl
        End Sub
    End Class
End Namespace