Namespace UI.Control
    ''' <summary>
    ''' Custom radio button
    ''' </summary>
    Public Class Rdo
        Inherits System.Windows.Forms.RadioButton

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontLbl
            MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace