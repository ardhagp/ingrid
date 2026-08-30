Namespace UI.Control
    ''' <project>CMCC</project>
    ''' <author>Ardha Gp</author>
    ''' <summary>
    ''' Custom combo box
    ''' </summary>
    <System.ComponentModel.DesignerCategory("Code")>
    Public Class Cbo
        Inherits System.Windows.Forms.ComboBox

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontLbl
            MyBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            MyBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            MyBase.DoubleBuffered = True
        End Sub
    End Class
End Namespace