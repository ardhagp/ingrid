Imports CMCv

Public Class CDIN_Editor

#Region "Variables"
    Public Event RecordSaved()
    Private _SQL As New LibSQL.Commands.CDIN.Editor
#End Region

#Region "Subs Collections"
    Private Sub FILLCompany(ByVal Company As cbo)
        _SQL.FILLCompany(CboCompany)
    End Sub

    Private Sub CheckAllInput()
        CboCompany.Focus()
        TxtDeptCode.Focus()
        TxtDeptName.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub CDIN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FILLCompany(CboCompany)
        If _FORMAttrib.RowID = "-1" Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
            CboCompany.SelectedValue = _SQL.GETCompanyID(_FORMAttrib.RowID)
            TxtDeptCode.Text = _SQL.GETDeptCode(_FORMAttrib.RowID)
            TxtDeptName.Text = _SQL.GETDeptName(_FORMAttrib.RowID)
            TxtDescription.Text = _SQL.GETDescription(_FORMAttrib.RowID)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If (CboCompany.Items.Count = 0) Or (TxtDeptCode.SLFSQLText = String.Empty) Or (TxtDeptName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Company Code selected, Departement Code and Departement Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = True) And (_SQL.IsDuplicate(CboCompany.SelectedValue, TxtDeptCode.SLFSQLText) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = False) And (_SQL.IsDuplicate(CboCompany.SelectedValue, TxtDeptCode.SLFSQLText, _FORMAttrib.RowID) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _SQL.PUSHData(CboCompany.SelectedValue, TxtDeptCode.SLFSQLText, TxtDeptName.SLFSQLText, TxtDescription.SLFSQLText, _FORMAttrib.RowID) = True Then
            RaiseEvent RecordSaved()
            mainframe.ts_status.Text = "Success"
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        If ChkAddNew.Checked = True Then
            TxtDeptCode.Clear()
            TxtDeptName.Clear()
            TxtDescription.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
