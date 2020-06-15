Imports CMCv

Public Class POST_Editor
#Region "Variables"
    Public Event RecordSaved()
    Public _SQL As New LibSQL.Commands.POST.Editor
    Public _FirstLoad As Boolean
#End Region

#Region "Subs Collections"

    Public Sub CheckAllInput()
        CboCompany.Focus()
        CboDepartement.Focus()
        TxtPositionCode.Focus()
        TxtPositionName.Focus()
        BtnSave.Focus()
    End Sub
#End Region


    Private Sub POST_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _FirstLoad = True
        _SQL.FILLCompany(CboCompany)
        _SQL.FILLDepartement(CboDepartement, CboCompany)

        If _FORMAttrib.IsNew = True Then
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = _SQL.GETCompanyID(_FORMAttrib.RowID)
            _SQL.FILLDepartement(CboDepartement, CboCompany)
            CboDepartement.SelectedValue = _SQL.GETDepartementID(_FORMAttrib.RowID)
            TxtPositionCode.Text = _SQL.GETPositionCode(_FORMAttrib.RowID)
            TxtPositionName.Text = _SQL.GETPositionName(_FORMAttrib.RowID)
            TxtPositionDescription.Text = _SQL.GETPositionDescription(_FORMAttrib.RowID)
        End If

        _FirstLoad = False
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If _FirstLoad = False Then
            _SQL.FILLDepartement(CboDepartement, CboCompany)
        End If
    End Sub

    Private Sub CboCompany_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboCompany.SelectionChangeCommitted

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (CboDepartement.Items.Count = 0) Or (TxtPositionCode.SLFSQLText = String.Empty) Or (TxtPositionName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Departement selected, Postition Code and Position Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf _FORMAttrib.IsNew = True And _SQL.IsDuplicate(CboDepartement.SelectedValue, TxtPositionCode.SLFSQLText, _FORMAttrib.RowID) = True Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf _FORMAttrib.IsNew = False And _SQL.IsDuplicate(CboDepartement.SelectedValue, TxtPositionCode.SLFSQLText, _FORMAttrib.RowID) = True Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _SQL.PUSHData(CboDepartement.SelectedValue, TxtPositionCode.SLFSQLText, TxtPositionName.SLFSQLText, TxtPositionDescription.SLFSQLText, _FORMAttrib.RowID) = True Then
            mainframe.ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        If ChkAddNew.Checked = True Then
            TxtPositionCode.Clear()
            TxtPositionName.Clear()
            TxtPositionDescription.Clear()
            TxtPositionCode.Focus()
        Else
            Me.Close()
        End If
    End Sub
End Class
