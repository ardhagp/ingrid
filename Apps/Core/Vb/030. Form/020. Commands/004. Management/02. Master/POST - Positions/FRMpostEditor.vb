Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMpostEditor
#Region "Variables"
    Public Event EventRecordSaved()

    Public varIsFirstLoad As Boolean
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
    Private Sub FRMpostEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        varIsFirstLoad = True
        CMDpost.Editor.FillCompany(varDatabaseName, varDatabaseEngineE, CboCompany)
        CMDpost.Editor.FillDepartement(varDatabaseName, varDatabaseEngineE, CboDepartement, CboCompany)

        If (varFormProperties.IsNew) Then
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = CMDpost.Editor.GetCompanyID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            CMDpost.Editor.FillDepartement(varDatabaseName, varDatabaseEngineE, CboDepartement, CboCompany)
            CboDepartement.SelectedValue = CMDpost.Editor.GetDepartmentID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtPositionCode.Text = CMDpost.Editor.GetPositionCode(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtPositionName.Text = CMDpost.Editor.GetPositionName(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtPositionDescription.Text = CMDpost.Editor.GetPositionDescription(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
        End If

        varIsFirstLoad = False
        '#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (varIsFirstLoad) Then
            CMDpost.Editor.FillDepartement(varDatabaseName, varDatabaseEngineE, CboDepartement, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (CboDepartement.Items.Count = 0) OrElse (TxtPositionCode.XOSQLText = String.Empty) OrElse (TxtPositionName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Departement selected, Postition Code and Position Description are properly filled.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDatabaseName, varDatabaseEnginee, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDatabaseName, varDatabaseEnginee, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (CMDpost.Editor.PushData(varDatabaseName, varDatabaseEngineE, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, TxtPositionName.XOSQLText, TxtPositionDescription.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            FRMmainframe6.Ts_status.Text = "Success"
            RaiseEvent EventRecordSaved()
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
