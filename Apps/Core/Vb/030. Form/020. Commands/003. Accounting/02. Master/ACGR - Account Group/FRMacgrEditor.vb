Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMacgrEditor

#Region "Declaration"
        Public Event EventRecordSaved()

        Private varSize As New Size(566, 445)
        Private varIsFirstLoad As Boolean
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
        Private Sub FRMacgrEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Size = varSize
            Me.MinimumSize = Me.Size

            varIsFirstLoad = True
            'Fill cbo Plant
            CMDacgr.Editor.FillCompany(varDatabaseName, varDatabaseEngineE, CboCompany)

            'Fill Cbo Accounting Book
            CMDacgr.Editor.FillAccountingBook(varDatabaseName, varDatabaseEngineE, CboAccountingBook, CboCompany)

            'Fill Account Group
            CMDacgr.Editor.FillAccountGroup(varDatabaseName, varDatabaseEngineE, CboAccountGroup)

            If (varDataProperties.AccountingGroupIsNew) Then
                ChkEnable.Checked = True
                ChkAddNew.Visible = True
            Else
                ChkAddNew.Visible = False
                CboCompany.SelectedValue = CMDacgr.Editor.GetCompanyID(varDatabaseName, varDatabaseEngineE, Convert.ToString(Convert.ToString(varDataProperties.AccountingGroupId)))
                CMDacgr.Editor.FillAccountingBook(varDatabaseName, varDatabaseEngineE, CboAccountingBook, CboCompany)
                CboAccountingBook.SelectedValue = CMDacgr.Editor.GetAccountBookID(varDatabaseName, varDatabaseEngineE, Convert.ToString(Convert.ToString(varDataProperties.AccountingGroupId)))
                CboAccountGroup.SelectedValue = CMDacgr.Editor.GetAccountGroupID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varDataProperties.AccountingGroupId))
                TxtAccountNumber.Text = CMDacgr.Editor.GetAccountNumber(varDatabaseName, varDatabaseEngineE, Convert.ToString(varDataProperties.AccountingGroupId))
                TxtAccountName.Text = CMDacgr.Editor.GetAccountName(varDatabaseName, varDatabaseEngineE, Convert.ToString(varDataProperties.AccountingGroupId))
                ChkEnable.Checked = CMDacgr.Editor.GetEnableTransaction(varDatabaseName, varDatabaseEngineE, Convert.ToString(varDataProperties.AccountingGroupId))

                'Disable all combobox
                CboCompany.Enabled = False
                CboAccountingBook.Enabled = False
                CboAccountGroup.Enabled = False
            End If

            varIsFirstLoad = False
        End Sub
#End Region

#Region "Component Events"
        <SupportedOSPlatform("windows")>
        Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
            If Not (varIsFirstLoad) Then
                CMDacgr.Editor.FillAccountingBook(varDatabaseName, varDatabaseEngineE, CboAccountingBook, CboCompany)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()

            If (TxtAccountName.Text = String.Empty) OrElse (TxtAccountNumber.Text = String.Empty) OrElse (CboAccountingBook.Items.Count = 0) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.AccountingGroupIsNew) AndAlso (CMDacgr.Editor.IsDuplicate(varDatabaseName, varDatabaseEngineE, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText)) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Account Number already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (varDataProperties.AccountingGroupIsNew) AndAlso (CMDacgr.Editor.IsDuplicate(varDatabaseName, varDatabaseEngineE, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, Convert.ToString(varDataProperties.AccountingGroupId))) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Account Number already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                .ConnectionDatabaseName = varDatabaseName
                .ConnectionDatabaseEngine = varDatabaseEngine
                .AccountingGroupId = Convert.ToString(varDataProperties.AccountingGroupId)
            End With

            With varAccountingProperties
                .AccountBookID = CboAccountingBook.SelectedValue.ToString
                .AccountGroupID = CboAccountGroup.SelectedValue.ToString
                .AccountNumber = TxtAccountNumber.XOSQLText
                .AccountName = TxtAccountName.XOSQLText
                .AccountEnabled = ChkEnable.Checked
            End With

            If (CMDacgr.Editor.PushData(varDataProperties, varAccountingProperties)) Then
                UI.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
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
End Namespace