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
        Commands.ACGR.Editor.FILLCompany(varDatabaseEngine, CboCompany)

        'Fill Cbo Accounting Book
        Commands.ACGR.Editor.FILLAccountingBook(varDatabaseEngine, CboAccountingBook, CboCompany)

        'Fill Account Group
        Commands.ACGR.Editor.FILLAccountGroup(varDatabaseEngine, CboAccountGroup)

        If (varFormAttributes.IsNew) Then
            ChkEnable.Checked = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = Commands.ACGR.Editor.GETCompanyID(varDatabaseEngine, varFormAttributes.RowID)
            Commands.ACGR.Editor.FILLAccountingBook(varDatabaseEngine, CboAccountingBook, CboCompany)
            CboAccountingBook.SelectedValue = Commands.ACGR.Editor.GETAccountBookID(varDatabaseEngine, varFormAttributes.RowID)
            CboAccountGroup.SelectedValue = Commands.ACGR.Editor.GETAccountGroupID(varDatabaseEngine, varFormAttributes.RowID)
            TxtAccountNumber.Text = Commands.ACGR.Editor.GETAccountNumber(varDatabaseEngine, varFormAttributes.RowID)
            TxtAccountName.Text = Commands.ACGR.Editor.GETAccountName(varDatabaseEngine, varFormAttributes.RowID)
            ChkEnable.Checked = Commands.ACGR.Editor.GETEnableTransaction(varDatabaseEngine, varFormAttributes.RowID)

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
            Commands.ACGR.Editor.FILLAccountingBook(varDatabaseEngine, CboAccountingBook, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If (TxtAccountName.Text = String.Empty) OrElse (TxtAccountNumber.Text = String.Empty) OrElse (CboAccountingBook.Items.Count = 0) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (varFormAttributes.IsNew) AndAlso (Commands.ACGR.Editor.IsDuplicate(varDatabaseEngine, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormAttributes.IsNew) AndAlso (Commands.ACGR.Editor.IsDuplicate(varDatabaseEngine, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, varFormAttributes.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Account Number already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.ACGR.Editor.PUSHData(varDatabaseEngine, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, TxtAccountName.XOSQLText, ChkEnable.Checked, varFormAttributes.RowID)) Then
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
