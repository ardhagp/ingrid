Imports System.Runtime.Versioning

Public Class DAR_RPTFilter
    Private _SQLview As New Commands.DAR.View
    Private _SQLeditor As New Commands.DAR.Editor
    Private _SQL As New Commands.DAR.Reports
    Private _DS As DAR_RDS
    Private WithEvents _DAR_RPTContainer As DAR_RPTContainer

    <SupportedOSPlatform("windows")>
    Private Sub FillEmployee()
        Commands.DAR.View.FillEmployee(varDatabaseName, varDatabaseEngine, CboBy)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GETAffectedArea()
        Commands.DAR.Editor.GetAffectedArea(varDatabaseName, varDatabaseEngine, CboArea)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GETActivity()
        Commands.DAR.Editor.GetTemplateTitle(varDatabaseName, varDatabaseEngine, CboActivity)
    End Sub

    Private Sub ChkFrom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFrom.CheckedChanged
        If (ChkFrom.Checked) Then
            ChkTo.Enabled = True
            DtpFrom.Enabled = True
            DtpFrom.MaxDate = DtpTo.Value
        Else
            DtpFrom.Enabled = False
            ChkTo.Checked = False
            ChkTo.Enabled = False
        End If
    End Sub

    Private Sub ChkTo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTo.CheckedChanged
        If (ChkTo.Checked) Then
            ChkFrom.Text = "From"
            DtpTo.Enabled = True
            DtpTo.MinDate = DtpFrom.Value
        Else
            ChkFrom.Text = "In"
            DtpTo.Enabled = False
        End If
    End Sub

    Private Sub ChkArea_CheckedChanged(sender As Object, e As EventArgs) Handles ChkArea.CheckedChanged
        If (ChkArea.Checked) Then
            CboArea.Enabled = True
        Else
            CboArea.Enabled = False
        End If
    End Sub

    Private Sub ChkActivity_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivity.CheckedChanged
        If (ChkActivity.Checked) Then
            CboActivity.Enabled = True
        Else
            CboActivity.Enabled = False
        End If
    End Sub

    Private Sub ChkBy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBy.CheckedChanged
        If (ChkBy.Checked) Then
            CboBy.Enabled = True
        Else
            CboBy.Enabled = False
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_RPTFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ResetComponents()
        Call GETAffectedArea()
        Call GETActivity()
        Call FillEmployee()
        DtpFrom.MaxDate = DtpTo.Value
        DtpTo.MinDate = DtpFrom.Value
    End Sub

    Private Sub ResetComponents()
        ChkFrom.Checked = False
        DtpFrom.Enabled = False
        ChkTo.Checked = False
        ChkTo.Enabled = False
        DtpTo.Enabled = False
        ChkArea.Checked = False
        CboArea.Enabled = False
        ChkActivity.Checked = False
        CboActivity.Enabled = False
        ChkBy.Checked = False
        CboBy.Enabled = False
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        _DS = New DAR_RDS
        Commands.DAR.Reports.Display(varDatabaseName, varDatabaseEngine, ChkFrom, ChkTo, ChkArea, ChkActivity, ChkBy, DtpFrom, DtpTo, CboArea, CboActivity, CboBy, TxtDescription, _DS)

        Dim _Color As Boolean

        If (RdoColor.Checked) Then
            _Color = True
        Else
            _Color = False
        End If

        _DAR_RPTContainer = New DAR_RPTContainer(_DS, varUserAttributes.FirstName, _Color, GETAPPVERSION)
        DISPLAY(_DAR_RPTContainer, IMAGEDB.Main.ImageLibrary.PRINTER_ICON, "Print - Daily Activity Report", "Generated Daily Activity Report", True,)
    End Sub

    Private Sub _DAR_RPTContainer_ReportClosed() Handles _DAR_RPTContainer.ReportClosed
        _DS = Nothing
    End Sub

    Private Sub DtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles DtpFrom.ValueChanged
        DtpTo.MinDate = DtpFrom.Value
    End Sub

    Private Sub DtpTo_ValueChanged(sender As Object, e As EventArgs) Handles DtpTo.ValueChanged
        DtpFrom.MaxDate = DtpTo.Value
    End Sub
End Class
