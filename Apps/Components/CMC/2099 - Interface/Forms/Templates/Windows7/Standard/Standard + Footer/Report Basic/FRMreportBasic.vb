Imports System.Runtime.Versioning

Public Class FRMreportBasic
    <SupportedOSPlatform("windows")>
    Private Sub Rpt_Bsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Rv_.RefreshReport()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
