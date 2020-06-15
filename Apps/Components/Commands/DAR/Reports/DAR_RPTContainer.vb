

Public Class DAR_RPTContainer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DAR_RPTContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rv_.Refresh()
    End Sub
End Class
