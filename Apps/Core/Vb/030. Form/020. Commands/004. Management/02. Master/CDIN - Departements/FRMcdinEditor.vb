Namespace UI.Canvas
    Public Class FRMcdinEditor

#Region "Declaration"
        Public Event EventRecordSaved()

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CDIN"
#End Region

#Region "Subs Collections"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FillCompany(company As CMCv.UI.Control.Cbo)
            CMDcdin.Editor.FillCompany(varDataProperties, company)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CheckAllInput()
            CboCompany.Focus()
            TxtDeptCode.Focus()
            TxtDeptName.Focus()
            TxtDescription.Focus()
            BtnSave.Focus()
        End Sub
#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call FillCompany(CboCompany)
            If varDataProperties.DepartmentIsNew Then

                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                CMDcdin.Editor.GetDepartmentProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(tDepartment.TableName).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(tDepartment.TableName).Rows(0)
                        CboCompany.SelectedValue = .Item(tDepartment.C_DepartmentCompany).ToString
                        TxtDeptCode.Text = .Item(tDepartment.C_DepartmentCode).ToString
                        TxtDeptName.Text = .Item(tDepartment.C_DepartmentName).ToString
                        TxtDescription.Text = .Item(tDepartment.C_DepartmentDescription).ToString
                    End With
                End If
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            CheckAllInput()

            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyId, CLng(CboCompany.SelectedValue))
                SetValue(.AllParameters, tDepartment.P_DepartmentCode, IIf(TxtDeptCode.XOSqlText = String.Empty OrElse TxtDeptCode.XOSqlText = "", DBNull.Value, TxtDeptCode.XOSqlText))
                SetValue(.AllParameters, tDepartment.P_DepartmentName, IIf(TxtDeptName.XOSqlText = String.Empty OrElse TxtDeptName.XOSqlText = "", DBNull.Value, TxtDeptName.XOSqlText))
                SetValue(.AllParameters, tDepartment.P_DepartmentDescription, IIf(TxtDescription.XOSqlText = String.Empty OrElse TxtDescription.XOSqlText = "", DBNull.Value, TxtDescription.XOSqlText))
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcdinEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.UserParameters, varThisModuleCode, varThisModuleId)
        End Sub
    End Class
End Namespace