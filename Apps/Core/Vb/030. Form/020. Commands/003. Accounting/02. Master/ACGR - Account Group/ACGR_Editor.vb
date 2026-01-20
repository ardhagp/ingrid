Imports System.Runtime.Versioning
Imports CMCv

Public Class ACGR_Editor

#Region "Variables"
    Private V_Size As New Size(566, 445)
    Private V_SQLeditor As New Commands.ACGR.Editor
    Private V_ISfirstload As Boolean
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
    <SupportedOSPlatform("windows")>
    Private Sub frmACGR_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = V_Size
        Me.MinimumSize = Me.Size

        V_ISfirstload = True
        'Fill cbo Plant
        Commands.ACGR.Editor.FillCompany(varDatabaseName, varDatabaseEngine, CboCompany)

        'Fill Cbo Accounting Book
        Commands.ACGR.Editor.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)

        'Fill Account Group
        Commands.ACGR.Editor.FillAccountGroup(varDatabaseName, varDatabaseEngine, CboAccountGroup)

        If (varFormProperties.IsNew) Then
            ChkEnable.Checked = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = Commands.ACGR.Editor.GetCompanyID(varDatabaseName, varDatabaseEngine, Convert.ToString(Convert.ToString(varFormProperties.RowID)))
            Commands.ACGR.Editor.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)
            CboAccountingBook.SelectedValue = Commands.ACGR.Editor.GetAccountBookID(varDatabaseName, varDatabaseEngine, Convert.ToString(Convert.ToString(varFormProperties.RowID)))
            CboAccountGroup.SelectedValue = Commands.ACGR.Editor.GetAccountGroupID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtAccountNumber.Text = Commands.ACGR.Editor.GetAccountNumber(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtAccountName.Text = Commands.ACGR.Editor.GetAccountName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkEnable.Checked = Commands.ACGR.Editor.GetEnableTransaction(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))

            'Disable all combobox
            CboCompany.Enabled = False
            CboAccountingBook.Enabled = False
            CboAccountGroup.Enabled = False
        End If

        V_ISfirstload = False
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (V_ISfirstload) Then
            Commands.ACGR.Editor.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If (TxtAccountName.Text = String.Empty) OrElse (TxtAccountNumber.Text = String.Empty) OrElse (CboAccountingBook.Items.Count = 0) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (varFormProperties.IsNew) AndAlso (Commands.ACGR.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormProperties.IsNew) AndAlso (Commands.ACGR.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.ACGR.Editor.PushData(varDatabaseName, varDatabaseEngine, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, TxtAccountName.XOSQLText, ChkEnable.Checked, Convert.ToString(varFormProperties.RowID))) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtAccountNumber.Text = String.Empty
        TxtAccountName.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
#End Region

End Class
