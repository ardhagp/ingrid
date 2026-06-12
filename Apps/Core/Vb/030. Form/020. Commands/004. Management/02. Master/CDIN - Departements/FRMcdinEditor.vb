Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMcdinEditor

#Region "Declaration"
        Public Event EventRecordSaved()
        Private Shared consTableName As String = "man_department"

        'Parameters
        Private Const pCompanyId As String = "@CompanyId"
        Private Const pDepartmentCode As String = "@DepartmentCode"
        Private Const pDepartmentName As String = "@DepartmentName"
        Private Const pDepartmentDescription As String = "@DepartmentDescription"

#End Region

#Region "Subs Collections"
        <SupportedOSPlatform("windows")>
        Private Sub FillCompany(company As CMCv.UI.Control.Cbo)
            CMDcdin.Editor.FillCompany(varDataProperties, company)
        End Sub

        <SupportedOSPlatform("windows")>
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
            Call FillCompany(CboCompany)
            If varDataProperties.DepartmentIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                CMDcdin.Editor.GetDepartmentProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(consTableName).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(consTableName).Rows(0)
                        CboCompany.SelectedValue = .Item("department_company").ToString
                        TxtDeptCode.Text = .Item("department_code").ToString
                        TxtDeptName.Text = .Item("department_name").ToString
                        TxtDescription.Text = .Item("department_description").ToString
                    End With
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            CheckAllInput()

            With varDataProperties
                .AllParameters.Remove(pCompanyId)
                .AllParameters.Add(pCompanyId, CLng(CboCompany.SelectedValue))
                .AllParameters.Remove(pDepartmentCode)
                .AllParameters.Add(pDepartmentCode, IIf(TxtDeptCode.XOSqlText = String.Empty OrElse TxtDeptCode.XOSqlText = "", DBNull.Value, TxtDeptCode.XOSqlText))
                .AllParameters.Remove(pDepartmentName)
                .AllParameters.Add(pDepartmentName, IIf(TxtDeptName.XOSqlText = String.Empty OrElse TxtDeptName.XOSqlText = "", DBNull.Value, TxtDeptName.XOSqlText))
                .AllParameters.Remove(pDepartmentDescription)
                .AllParameters.Add(pDepartmentDescription, IIf(TxtDescription.XOSqlText = String.Empty OrElse TxtDescription.XOSqlText = "", DBNull.Value, TxtDescription.XOSqlText))
            End With

            If (CboCompany.Items.Count = 0) AndAlso (varDataProperties.AllParameters("@DepartmentCode").ToString = String.Empty) OrElse (varDataProperties.AllParameters("@DepartmentName").ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Ensure that the Company Code is selected and that both the Department Code and Department Name are properly filled in.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.DepartmentIsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Department Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.DepartmentIsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Department Code cannot be used because it is already assigned to another company.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDcdin.Editor.PushData(varDataProperties)) Then
                RaiseEvent EventRecordSaved()
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If ChkAddNew.Checked Then
                CboCompany.SelectedIndex = 0
                TxtDeptCode.Clear()
                TxtDeptName.Clear()
                TxtDescription.Clear()
                CboCompany.Focus()
            Else
                Me.Close()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub
    End Class
End Namespace