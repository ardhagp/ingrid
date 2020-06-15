Imports CMCv
Imports LibSQL

Public Class ACGR_Editor

#Region "Variables"
    Private _Size As New Size(566, 445)
    Private _SQL As New LibSQL.Commands.ACGR.Editor
    Private _FirstLoad As Boolean
    Public Event RecordSaved()
#End Region

#Region "Sub Collections"
    Private Sub CheckAllInput()
        CboCompany.Focus()
        CboAccountingBook.Focus()
        TxtAccountNumber.Focus()
        TxtAccountName.Focus()
        BtnSave.Focus()
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmACGR_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = _Size
        Me.MinimumSize = Me.Size

        _FirstLoad = True
        'Fill cbo Plant
        _SQL.FILLCompany(CboCompany)

        'Fill Cbo Accounting Book
        _SQL.FILLAccountingBook(CboAccountingBook, CboCompany)

        'Fill Account Group
        _SQL.FILLAccountGroup(CboAccountGroup)

        If _FORMAttrib.IsNew = True Then
            ChkEnable.Checked = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = _SQL.GETCompanyID(_FORMAttrib.RowID)
            _SQL.FILLAccountingBook(CboAccountingBook, CboCompany)
            CboAccountingBook.SelectedValue = _SQL.GETAccountBookID(_FORMAttrib.RowID)
            CboAccountGroup.SelectedValue = _SQL.GETAccountGroupID(_FORMAttrib.RowID)
            TxtAccountNumber.Text = _SQL.GETAccountNumber(_FORMAttrib.RowID)
            TxtAccountName.Text = _SQL.GETAccountName(_FORMAttrib.RowID)
            ChkEnable.Checked = _SQL.GETEnableTransaction(_FORMAttrib.RowID)

            'Disable all combobox
            CboCompany.Enabled = False
            CboAccountingBook.Enabled = False
            CboAccountGroup.Enabled = False
        End If

        _FirstLoad = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If _FirstLoad = False Then
            _SQL.FILLAccountingBook(CboAccountingBook, CboCompany)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If TxtAccountName.Text = String.Empty Or TxtAccountNumber.Text = String.Empty Or CboAccountingBook.Items.Count = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf _FORMAttrib.IsNew = True And _SQL.IsDuplicate(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.SLFSQLText) = True Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf _FORMAttrib.IsNew = False And _SQL.IsDuplicate(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.SLFSQLText, _FORMAttrib.RowID) = True Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _SQL.PUSHData(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.SLFSQLText, TxtAccountName.SLFSQLText, ChkEnable.Checked, _FORMAttrib.RowID) = True Then
            mainframe.ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        TxtAccountNumber.Text = String.Empty
        TxtAccountName.Text = String.Empty

        If ChkAddNew.Checked = False Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
#End Region

    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged

    End Sub
End Class
