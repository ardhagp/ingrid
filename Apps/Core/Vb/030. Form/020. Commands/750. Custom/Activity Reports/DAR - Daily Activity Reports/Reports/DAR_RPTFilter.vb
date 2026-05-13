Imports System.Runtime.Versioning

Namespace UI
    Public Class DAR_RPTFilter
        'Private varSqlView As New CMDdar.View
        'Private varSqlEditor As New CMDdar.Editor
        'Private varSql As New CMDdar.Reports
        Private varDataSet As UI.DAR_RDS
        Private WithEvents FRMdar_RPTContainer As DAR_RPTContainer

        <SupportedOSPlatform("windows")>
        Private Sub FillEmployee()
            CMDdar.View.FillEmployee(varDataProperties, CboBy)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetAffectedArea()
            CMDdar.Editor.GetAffectedArea(varDataProperties, CboArea)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetActivity()
            CMDdar.Editor.GetTemplateTitle(varDataProperties, CboActivity)
        End Sub

        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Private Sub ChkArea_CheckedChanged(sender As Object, e As EventArgs) Handles ChkArea.CheckedChanged
            If (ChkArea.Checked) Then
                CboArea.Enabled = True
            Else
                CboArea.Enabled = False
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ChkActivity_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivity.CheckedChanged
            If (ChkActivity.Checked) Then
                CboActivity.Enabled = True
            Else
                CboActivity.Enabled = False
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ChkBy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBy.CheckedChanged
            If (ChkBy.Checked) Then
                CboBy.Enabled = True
            Else
                CboBy.Enabled = False
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMdarRptFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call ResetComponents()
            Call GETAffectedArea()
            Call GETActivity()
            Call FillEmployee()
            DtpFrom.MaxDate = DtpTo.Value
            DtpTo.MinDate = DtpFrom.Value
        End Sub

        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
            varDataSet = New UI.DAR_RDS
            CMDdar.Reports.Display(varDataProperties, ChkFrom, ChkTo, ChkArea, ChkActivity, ChkBy, DtpFrom, DtpTo, CboArea, CboActivity, CboBy, TxtDescription, varDataSet)

            Dim varColor As Boolean

            If (RdoColor.Checked) Then
                varColor = True
            Else
                varColor = False
            End If

            FRMdar_RPTContainer = New DAR_RPTContainer(varDataSet, varDataProperties.EmployeeFirstName, varColor, GetAppVersion)
            Display(FRMdar_RPTContainer, IMAGEDB.Main.ImageLibrary.PRINTER_ICON, My.Application.Info.AssemblyName.ToUpper, "Print - Daily Activity Report", "Generated Daily Activity Report", True,)
        End Sub

        Private Sub FRMdarRptContainer_ReportClosed() Handles FRMdar_RPTContainer.ReportClosed
            varDataSet = Nothing
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub DtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles DtpFrom.ValueChanged
            DtpTo.MinDate = DtpFrom.Value
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub DtpTo_ValueChanged(sender As Object, e As EventArgs) Handles DtpTo.ValueChanged
            DtpFrom.MaxDate = DtpTo.Value
        End Sub
    End Class
End Namespace