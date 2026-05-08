Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMpostEditor
#Region "Declaration"
        Public Event EventRecordSaved()

        Public varIsFirstLoad As Boolean
        Private Shared consTableName As String = "man_position"

        'Parameters
        Private Const pCompanyId As String = "@CompanyId"
        Private Const pDepartmentId As String = "@DepartmentId"
        Private Const pPositionCode As String = "@PositionCode"
        Private Const pPositionName As String = "@PositionName"
        Private Const pPositionDescription As String = "@PositionDescription"
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
            varIsFirstLoad = True
            If (varDataProperties.EmployeePositionIsNew) Then
                ChkAddNew.Visible = True
                CMDpost.Editor.FillCompany(varDataProperties, CboCompany)
                CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
            Else
                ChkAddNew.Visible = False
                CMDpost.Editor.FillCompany(varDataProperties, CboCompany)
                CMDpost.Editor.GetPositionProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(consTableName).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(consTableName).Rows(0)
                        CboCompany.SelectedValue = .Item("department_company").ToString
                        CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
                        CboDepartement.SelectedValue = .Item("position_department").ToString
                        TxtPositionCode.Text = .Item("position_code").ToString
                        TxtPositionName.Text = .Item("position_name").ToString
                        TxtPositionDescription.Text = .Item("position_description").ToString
                    End With
                End If
            End If
            varIsFirstLoad = False
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
            If Not (varIsFirstLoad) Then
                CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            With varDataProperties.AllParameters
                .Remove(pCompanyId)
                .Add(pCompanyId, CLng(CboCompany.SelectedValue))
                .Remove(pDepartmentId)
                .Add(pDepartmentId, CLng(CboDepartement.SelectedValue))
                .Remove(pPositionCode)
                .Add(pPositionCode, TxtPositionCode.XOSQLText)
                .Remove(pPositionName)
                .Add(pPositionName, TxtPositionName.XOSQLText)
                .Remove(pPositionDescription)
                .Add(pPositionDescription, IIf(TxtPositionDescription.XOSQLText = String.Empty OrElse TxtPositionDescription.XOSQLText = "", DBNull.Value, TxtPositionDescription.XOSQLText))
            End With

            If (CboDepartement.Items.Count = 0) OrElse (varDataProperties.AllParameters(pPositionCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(pPositionName).ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Department selected, Postition Code and Position Description are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf ((varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDpost.Editor.PushData(varDataProperties)) Then
                UI.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
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
End Namespace