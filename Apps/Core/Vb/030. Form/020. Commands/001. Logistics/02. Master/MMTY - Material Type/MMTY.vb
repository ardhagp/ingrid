Imports System.Runtime.Versioning

Public Class MMTY
    'Private _SQL As New LibSQL.Commands.MMTY.View
    Private WithEvents V_MMSMenu As New CMCv.UI.View.MenuStrip

#Region "Menu Strip Functions"

#End Region

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        Commands.MMTY.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnMMTY, SLFStatus, TxtFind, forcerefresh)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmMMTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        V_MMSMenu.LoadIn(Me)
        Call GetData(True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GetData(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetData()
        End If
    End Sub
End Class
