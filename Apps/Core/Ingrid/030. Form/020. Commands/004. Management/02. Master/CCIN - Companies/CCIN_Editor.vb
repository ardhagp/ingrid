Imports CMCv

Public Class CCIN_Editor

#Region "Variables"
    Public Event RecordSaved()
    Private _SQL As New LibSQL.Commands.CCIN.Editor
#End Region

#Region "Subs Collections"
    Private Sub CheckAllInput()
        'Call CheckAllControls()
        TxtCode.Focus()
        TxtName.Focus()
        TxtSearchTerm1.Focus()
        TxtSearchTerm2.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

#Region "Form Events"
    Private Sub CCIN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _FORMAttrib.IsNew = True Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            TxtCode.Text = _SQL.GETCompanyCode(_FORMAttrib.RowID)
            TxtName.Text = _SQL.GETCompanyName(_FORMAttrib.RowID)
            TxtSearchTerm1.Text = _SQL.GETSearchTerm1(_FORMAttrib.RowID)
            TxtSearchTerm2.Text = _SQL.GETSearchTerm2(_FORMAttrib.RowID)
            TxtDescription.Text = _SQL.GETDescription(_FORMAttrib.RowID)
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
        End If
    End Sub
#End Region

#Region "Component Events"
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (TxtCode.SLFSQLText = String.Empty) Or (TxtName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Company Code & Company Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = True) And (_SQL.IsDuplicate(TxtCode.SLFSQLText) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = False) And (_SQL.IsDuplicate(TxtCode.SLFSQLText, _FORMAttrib.RowID) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already used by another company.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _SQL.PUSHData(TxtCode.SLFSQLText, TxtName.SLFSQLText, TxtSearchTerm1.SLFSQLText, TxtSearchTerm2.SLFSQLText, TxtDescription.SLFSQLText, _FORMAttrib.RowID) = True Then
            mainframe.ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        TxtCode.Text = String.Empty
        TxtName.Text = String.Empty
        TxtSearchTerm1.Text = String.Empty
        TxtSearchTerm2.Text = String.Empty
        TxtDescription.Text = String.Empty

        If ChkAddNew.Checked = False Then
            Me.Close()
        End If
    End Sub
#End Region

End Class
