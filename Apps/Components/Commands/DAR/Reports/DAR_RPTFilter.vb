Imports CMCv

Public Class DAR_RPTFilter
    Private _SQLview As New LibSQL.Commands.DAR.View
    Private _SQLeditor As New LibSQL.Commands.DAR.Editor
    Private _SQL As New LibSQL.Commands.DAR.Reports
    Private _DS As DAR_RDS
    Private WithEvents _DAR_RPTContainer As DAR_RPTContainer

    Private Sub FillEmployee()
        _SQLview.FillEmployee(CboBy)
    End Sub

    Private Sub GETAffectedArea()
        _SQLeditor.GETAffectedArea(CboArea)
    End Sub

    Private Sub GETActivity()
        _SQLeditor.GETTemplateTitle(CboActivity)
    End Sub

    Private Sub ChkFrom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFrom.CheckedChanged
        If ChkFrom.Checked = True Then
            ChkTo.Enabled = True
            DtpFrom.Enabled = True
        Else
            ChkTo.Checked = False
            ChkTo.Enabled = False
            DtpTo.Enabled = False
        End If
    End Sub

    Private Sub ChkTo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTo.CheckedChanged
        If ChkTo.Checked = True Then
            DtpTo.Enabled = True
        Else
            DtpTo.Enabled = False
        End If
    End Sub

    Private Sub ChkArea_CheckedChanged(sender As Object, e As EventArgs) Handles ChkArea.CheckedChanged
        If ChkArea.Checked = True Then
            CboArea.Enabled = True
        Else
            CboArea.Enabled = False
        End If
    End Sub

    Private Sub ChkActivity_CheckedChanged(sender As Object, e As EventArgs) Handles ChkActivity.CheckedChanged
        If ChkActivity.Checked = True Then
            CboActivity.Enabled = True
        Else
            CboActivity.Enabled = False
        End If
    End Sub

    Private Sub ChkBy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBy.CheckedChanged
        If ChkBy.Checked = True Then
            CboBy.Enabled = True
        Else
            CboBy.Enabled = False
        End If
    End Sub

    Private Sub DAR_RPTFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ResetComponents()
        Call GETAffectedArea()
        Call GETActivity()
        Call FillEmployee()
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
        Me.Close()
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        _DS = _SQL.Display(ChkFrom, ChkTo, ChkArea, ChkActivity, ChkBy, DtpFrom, DtpTo, CboArea, CboActivity, CboBy, TxtDescription)

        MsgBox("a")
        '_DAR_RPTContainer = New DAR_RPTContainer
        'Display(_DAR_RPTContainer,, "Reports", "", True,)
    End Sub
End Class
