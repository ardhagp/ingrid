Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMcdinEditor

#Region "Declaration"
    Public Event EventRecordSaved()
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub FillCompany(company As cbo)
        CMDcdin.Editor.FillCompany(varDatabaseName, varDatabaseEngine, company)
    End Sub

    Private Sub CheckAllInput()
        CboCompany.Focus()
        TxtDeptCode.Focus()
        TxtDeptName.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub FRMcdinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
            CboCompany.SelectedValue = CMDcdin.Editor.GetCompanyID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtDeptCode.Text = CMDcdin.Editor.GetDeptCode(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)).ToString
            TxtDeptName.Text = CMDcdin.Editor.GETDeptName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)).ToString
            TxtDescription.Text = CMDcdin.Editor.GetDescription(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)).ToString
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "Make sure you have Company Code selected, Departement Code and Departement Name are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboCompany.SelectedValue.ToString, TxtDeptCode.XOSQLText))) Then
            Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboCompany.SelectedValue.ToString, TxtDeptCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (CMDcdin.Editor.PushData(varDatabaseName, varDatabaseEngine, CboCompany.SelectedValue.ToString, TxtDeptCode.XOSQLText, TxtDeptName.XOSQLText, TxtDescription.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            RaiseEvent EventRecordSaved()
            FRMmainframe6.Ts_status.Text = "Success"
        Else
            FRMmainframe6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
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
