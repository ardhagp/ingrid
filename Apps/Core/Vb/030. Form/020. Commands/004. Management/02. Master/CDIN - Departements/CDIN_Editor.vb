Imports System.Runtime.Versioning
Imports CMCv

Public Class CDIN_Editor

#Region "Variables"
    Public Event RecordSaved()
    Private _SQL As New Commands.CDIN.Editor
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub FillCompany(company As cbo)
        _SQL.FillCompany(varDatabaseName, varDatabaseEngine, company)
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
    Private Sub CDIN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If convert.tostring(varFormProperties.RowID) = "-1" Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
            CboCompany.SelectedValue = Commands.CDIN.Editor.GetCompanyID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtDeptCode.Text = Commands.CDIN.Editor.GetDeptCode(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)).ToString
            TxtDeptName.Text = Commands.CDIN.Editor.GETDeptName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)).ToString
            TxtDescription.Text = Commands.CDIN.Editor.GetDescription(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)).ToString
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If convert.tostring(varFormProperties.RowID) = "-1" Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Company Code selected, Departement Code and Departement Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (Commands.CDIN.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboCompany.SelectedValue.ToString, TxtDeptCode.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (Commands.CDIN.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboCompany.SelectedValue.ToString, TxtDeptCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
        Return
        End If

        If (Commands.CDIN.Editor.PUSHData(varDatabaseName, varDatabaseEngine, CboCompany.SelectedValue.ToString, TxtDeptCode.XOSQLText, TxtDeptName.XOSQLText, TxtDescription.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.Ts_status.Text = "Success"
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
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
