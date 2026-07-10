Namespace UI.Canvas
    Public Class FRMpostEditor
#Region "Declaration"
        Public Event EventRecordSaved()

        Public varIsFirstLoad As Boolean

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "POST"
#End Region

#Region "Subs Collections"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub CheckAllInput()
            CboCompany.Focus()
            CboDepartement.Focus()
            TxtPositionCode.Focus()
            TxtPositionName.Focus()
            BtnSave.Focus()
        End Sub
#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
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
                If varDatasetIngrid.Tables(tPosition.TableName).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(tPosition.TableName).Rows(0)
                        CboCompany.SelectedValue = .Item(tCompany.C_CompanyId).ToString
                        CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
                        CboDepartement.SelectedValue = .Item(tDepartment.C_DepartmentId).ToString
                        TxtPositionCode.Text = .Item(tPosition.C_PositionCode).ToString
                        TxtPositionName.Text = .Item(tPosition.C_PositionName).ToString
                        TxtPositionDescription.Text = .Item(tPosition.C_PositionDescription).ToString
                    End With
                End If
            End If
            varIsFirstLoad = False
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
            If Not (varIsFirstLoad) Then
                CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyId, CLng(CboCompany.SelectedValue))
                SetValue(.AllParameters, tDepartment.P_DepartmentId, CLng(CboDepartement.SelectedValue))
                SetValue(.AllParameters, tPosition.P_PositionCode, TxtPositionCode.XOSqlText)
                SetValue(.AllParameters, tPosition.P_PositionName, TxtPositionName.XOSqlText)
                SetValue(.AllParameters, tPosition.P_PositionDescription, IIf(TxtPositionDescription.XOSqlText = String.Empty OrElse TxtPositionDescription.XOSqlText = "", DBNull.Value, TxtPositionDescription.XOSqlText))
            End With

            If (CboDepartement.Items.Count = 0) OrElse (varDataProperties.AllParameters(tPosition.P_PositionCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(tPosition.P_PositionName).ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Department selected, Postition Code and Position Description are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf ((varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDpost.Editor.PushData(varDataProperties)) Then
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.UserParameters, varThisModuleCode, varThisModuleId)
        End Sub
    End Class
End Namespace