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
            CMDacgr.Editor.FillCompany(varDataProperties, CboCompany)

            'Fill Cbo Accounting Book
            CMDacgr.Editor.FillAccountingBook(varDataProperties, CboAccountingBook, CboCompany)

            'Fill Account Group
            CMDacgr.Editor.FillAccountGroup(varDataProperties, CboAccountGroup)

            If (varDataProperties.AccountGroupIsNew) Then
                ChkEnable.Checked = True
                ChkAddNew.Visible = True
            Else
                ChkAddNew.Visible = False
                CboCompany.SelectedValue = CMDacgr.Editor.GetCompanyID(varDataProperties, Convert.ToString(Convert.ToString(varDataProperties.AccountGroupId)))
                CMDacgr.Editor.FillAccountingBook(varDataProperties, CboAccountingBook, CboCompany)
                CboAccountingBook.SelectedValue = CMDacgr.Editor.GetAccountBookID(varDataProperties, Convert.ToString(Convert.ToString(varDataProperties.AccountGroupId)))
                CboAccountGroup.SelectedValue = CMDacgr.Editor.GetAccountGroupID(varDataProperties, Convert.ToString(varDataProperties.AccountGroupId))
                TxtAccountNumber.Text = CMDacgr.Editor.GetAccountNumber(varDataProperties, Convert.ToString(varDataProperties.AccountGroupId))
                TxtAccountName.Text = CMDacgr.Editor.GetAccountName(varDataProperties, Convert.ToString(varDataProperties.AccountGroupId))
                ChkEnable.Checked = CMDacgr.Editor.GetEnableTransaction(varDataProperties, Convert.ToString(varDataProperties.AccountGroupId))

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
                CMDacgr.Editor.FillAccountingBook(varDataProperties, CboAccountingBook, CboCompany)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()

            If (TxtAccountName.Text = String.Empty) OrElse (TxtAccountNumber.Text = String.Empty) OrElse (CboAccountingBook.Items.Count = 0) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Account Book selected, Account Number & Account Name properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.AccountGroupIsNew) AndAlso (CMDacgr.Editor.IsDuplicate(varDataProperties, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Account Number already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (varDataProperties.AccountGroupIsNew) AndAlso (CMDacgr.Editor.IsDuplicate(varDataProperties, CboAccountingBook.SelectedValue.ToString, CboAccountGroup.SelectedValue.ToString, TxtAccountNumber.XOSQLText, Convert.ToString(varDataProperties.AccountGroupId))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Account Number already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                .AccountGroupId = Convert.ToString(varDataProperties.AccountGroupId)
            End With

            With varDataProperties
                .AccountBookId = CLng(CboAccountingBook.SelectedValue)
                .AccountGroupId = CboAccountGroup.SelectedValue.ToString
                .AccountBookNumber = CInt(TxtAccountNumber.XOSQLText)
                .AccountBookName = TxtAccountName.XOSQLText
                .AccountBookIsEnabled = ChkEnable.Checked
            End With

            If CMDacgr.Editor.PushData(varDataProperties) Then
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