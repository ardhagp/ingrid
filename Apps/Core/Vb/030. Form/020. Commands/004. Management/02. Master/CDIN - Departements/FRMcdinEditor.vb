Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMcdinEditor

#Region "Declaration"
        Public Event EventRecordSaved()
        Private Shared consTableName As String = "man_department"
#End Region

#Region "Subs Collections"
        <SupportedOSPlatform("windows")>
        Private Sub FillCompany(company As CMCv.UI.Control.cbo)
            CMDcdin.Editor.FillCompany(varDataProperties, company)
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
            Call FillCompany(CboCompany)
            If varDataProperties.DepartmentId = "-1" Then
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
            Call CheckAllInput()
            With varDataProperties
                .CompanyId = CboCompany.SelectedValue.ToString
                .DepartmentCode = TxtDeptCode.XOSQLText
                .DepartmentName = TxtDeptName.XOSQLText
                .DepartmentDescription = TxtDescription.XOSQLText
            End With

            If (CboCompany.Items.Count = 0) AndAlso (varDataProperties.DepartmentCode = String.Empty) AndAlso (varDataProperties.DepartmentName = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Ensure that the Company Code is selected and that both the Department Code and Department Name are properly filled in.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.DepartmentIsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Department Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.DepartmentIsNew) AndAlso (CMDcdin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Department Code cannot be used because it is already assigned to another company.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDcdin.Editor.PushData(varDataProperties)) Then
                RaiseEvent EventRecordSaved()
                UI.FRMmainframe6.Ts_status.Text = "Success"
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
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

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub
    End Class
End Namespace