Imports System.Runtime.Versioning
Imports CMCv

Public Class POST_Editor
#Region "Variables"
    Public Event RecordSaved()
    Public _SQL As New LibSQL.Commands.POST.Editor
    Public V_ISfirstload As Boolean
#End Region

#Region "Subs Collections"

    Public Sub CheckAllInput()
        CboCompany.Focus()
        CboDepartement.Focus()
        TxtPositionCode.Focus()
        TxtPositionName.Focus()
        BtnSave.Focus()
    End Sub

    'Private sub _SQL as libsql.com
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub POST_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        V_ISfirstload = True
        _SQL.FillCompany(varDatabaseName, varDatabaseEngine, CboCompany)
        _SQL.FillDepartement(varDatabaseName, varDatabaseEngine, CboDepartement, CboCompany)

        If (varFormProperties.IsNew) Then
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = LibSQL.Commands.POST.Editor.GetCompanyID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            _SQL.FillDepartement(varDatabaseName, varDatabaseEngine, CboDepartement, CboCompany)
            CboDepartement.SelectedValue = LibSQL.Commands.POST.Editor.GetDepartmentID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPositionCode.Text = LibSQL.Commands.POST.Editor.GetPositionCode(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPositionName.Text = LibSQL.Commands.POST.Editor.GetPositionName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtPositionDescription.Text = LibSQL.Commands.POST.Editor.GetPositionDescription(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
        End If

        V_ISfirstload = False
        '#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (V_ISfirstload) Then
            _SQL.FillDepartement(varDatabaseName, varDatabaseEngine, CboDepartement, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (CboDepartement.Items.Count = 0) OrElse (TxtPositionCode.XOSQLText = String.Empty) OrElse (TxtPositionName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Departement selected, Postition Code and Position Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (LibSQL.Commands.POST.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (LibSQL.Commands.POST.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (LibSQL.Commands.POST.Editor.PushData(varDatabaseName, varDatabaseEngine, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, TxtPositionName.XOSQLText, TxtPositionDescription.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            FRMmainframe6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            FRMmainframe6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtPositionCode.Clear()
            TxtPositionName.Clear()
            TxtPositionDescription.Clear()
            TxtPositionCode.Focus()
        Else
            Me.Close()
        End If
    End Sub
End Class
