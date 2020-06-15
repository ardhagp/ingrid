Imports CMCv
Imports LibSQL

Public Class frmAccountGroup_Editor

#Region "Variables"
    Private _Size As New Size(566, 445)
    Private _SQL As New LibSQL.Commands.AccountGroupEditor
    Private _FirstLoad As Boolean
    Public Event RecordSaved()
#End Region

#Region "Sub Collections"
    Private Sub CheckAllInput()
        CboPlant.Focus()
        CboAccountingBook.Focus()
        TxtAccountNumber.Focus()
        TxtAccountName.Focus()
        BtnSave.Focus()
    End Sub
#End Region


    Private Sub frmAccountGroup_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = _Size
        Me.MinimumSize = Me.Size

        _FirstLoad = True
        'Fill cbo Plant
        _SQL.GETPlant(CboPlant)

        'Fill Cbo Accounting Book
        _SQL.GETAccountingBook(CboAccountingBook, CboPlant)

        'Fill Account Group
        _SQL.GETAccountGroup(CboAccountGroup)

        If _FORMAttrib.IsNew = True Then
            ChkEnable.Checked = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboPlant.SelectedValue = _SQL.GETPlantID(_FORMAttrib.RowID)
            CboAccountingBook.SelectedValue = _SQL.GETAccountBookID(_FORMAttrib.RowID)
            CboAccountGroup.SelectedValue = _SQL.GETAccountGroupID(_FORMAttrib.RowID)
            TxtAccountNumber.Text = _SQL.GETAccountNumber(_FORMAttrib.RowID)
            TxtAccountName.Text = _SQL.GETAccountName(_FORMAttrib.RowID)
            ChkEnable.Checked = _SQL.GETEnableTransaction(_FORMAttrib.RowID)

            'Disable all combobox
            CboPlant.Enabled = False
            CboAccountingBook.Enabled = False
            CboAccountGroup.Enabled = False
        End If

        _FirstLoad = False
    End Sub

    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPlant.SelectedIndexChanged
        If _FirstLoad = False Then
            _SQL.GETAccountingBook(CboAccountingBook, CboPlant)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If TxtAccountName.SLFIsBlank = True Or TxtAccountNumber.SLFIsBlank = True Or CboAccountingBook.Items.Count = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _FORMAttrib.IsNew = True And _SQL.IsDuplicate(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.Text.Trim) = True Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf _FORMAttrib.IsNew = False And _SQL.IsDuplicate(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.Text.Trim, _FORMAttrib.RowID) = True Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        If _FORMAttrib.IsNew = True Then
            If _SQL.PUSHData(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.SLFSQLText, TxtAccountName.SLFSQLText, ChkEnable.Checked) = True Then
                mainframe.ts_status.Text = "Success"
                RaiseEvent RecordSaved()
            Else
                mainframe.ts_status.Text = "Failed to save"
                Exit Sub
            End If
        ElseIf _FORMAttrib.IsNew = False Then
            If _SQL.PUSHData(CboAccountingBook.SelectedValue, CboAccountGroup.SelectedValue, TxtAccountNumber.SLFSQLText, TxtAccountName.SLFSQLText, ChkEnable.Checked, _FORMAttrib.RowID) = True Then
                mainframe.ts_status.Text = "Success"
                RaiseEvent RecordSaved()
            Else
                mainframe.ts_status.Text = "Failed to save"
                Exit Sub
            End If
        End If

            If ChkAddNew.Checked = False Then
                Me.Close()
            Else
                TxtAccountNumber.Text = String.Empty
                TxtAccountName.Text = String.Empty
            End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class
