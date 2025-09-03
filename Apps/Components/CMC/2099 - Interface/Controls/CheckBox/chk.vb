Imports System.Runtime.Versioning

''' <project>CMCC</project>
''' <author>Ardha Gp</author>
''' <summary>
''' Custom checkbox
''' </summary>
Public Class chk
    Inherits System.Windows.Forms.CheckBox

    <SupportedOSPlatform("windows")>
    Public Sub New()
        InitializeComponent()
        Call ActivateLicenses()
        MyBase.Font = globalFontLbl
        MyBase.BackColor = Drawing.Color.Transparent
        MyBase.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.DoubleBuffered = True
    End Sub

End Class
