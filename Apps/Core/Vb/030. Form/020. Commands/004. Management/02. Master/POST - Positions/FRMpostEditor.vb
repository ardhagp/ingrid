Namespace UI.Canvas
    Public Class FRMpostEditor

        Public Event EventRecordSaved()
        Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip

        Public varIsFirstLoad As Boolean

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "POST"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub CheckAllInput()
            CboCompany.Focus()
            CboDepartement.Focus()
            TxtPositionCode.Focus()
            TxtPositionName.Focus()
            BtnSave.Focus()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EDIT, XOLogo,, 512, 512)

            ComponentMainframeMenu.LoadIn(Me, True)
            ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

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
                        CboCompany.SelectedValue = .Item(tDepartment.C_DepartmentCompany).ToString
                        CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
                        CboDepartement.SelectedValue = .Item(tPosition.C_PositionDepartment).ToString
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

        <Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs)
            If Not varIsFirstLoad Then
                CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call Save()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileSave() Handles ComponentMainframeMenu.EventFileSave
            Call Save()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileUndoAll() Handles ComponentMainframeMenu.EventFileUndoAll
            If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.UndoChanges, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If (varDataProperties.EmployeePositionIsNew) Then
                    CboCompany.SelectedIndex = -1
                    CboDepartement.SelectedIndex = -1
                    TxtPositionCode.Clear()
                    TxtPositionName.Clear()
                    TxtPositionDescription.Clear()
                Else
                    'Call LoadData()
                    TxtPositionDescription.Text = ""
                End If
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Save()
            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyId, CLng(CboCompany.SelectedValue))
                SetValue(.AllParameters, tDepartment.P_DepartmentId, CLng(CboDepartement.SelectedValue))
                SetValue(.AllParameters, tPosition.P_PositionCode, TxtPositionCode.XOSqlText)
                SetValue(.AllParameters, tPosition.P_PositionName, TxtPositionName.XOSqlText)
                SetValue(.AllParameters, tPosition.P_PositionDescription, IIf(TxtPositionDescription.XOSqlText = String.Empty OrElse TxtPositionDescription.XOSqlText = "", DBNull.Value, TxtPositionDescription.XOSqlText))
            End With

            If (CboDepartement.Items.Count = 0) OrElse (varDataProperties.AllParameters(tPosition.P_PositionCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(tPosition.P_PositionName).ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Department selected, Postition Code and Position Description are properly filled.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            ElseIf ((varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
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
            SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
        End Sub
    End Class
End Namespace