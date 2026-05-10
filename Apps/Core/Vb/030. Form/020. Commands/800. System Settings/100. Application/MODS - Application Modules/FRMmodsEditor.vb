Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMmodsEditor
#Region "Declaration"
        Public Event EventRecordSaved()
#End Region

#Region "Subs Collection"
        <SupportedOSPlatform("windows")>
        Private Sub FillGroup(modulegroup As CMCv.UI.Control.cbo)
            CMDmods.Editor.FillModuleGroup(varDataProperties, modulegroup)
        End Sub

        Private Sub CheckAllInput()
            TxtID.Focus()
            TxtCode.Focus()
            TxtName.Focus()
            TxtDescription.Focus()
            BtnSave.Focus()
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMmodsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            DgnUserRoles.XOGETNewColor()

            Call FillGroup(CboGroup)
            If (varDataProperties.SystemModuleIsNew) Then
                ChkAddNew.Enabled = True
                ChkAddNew.Visible = True
                CboGroup.Focus()
            Else
                ChkAddNew.Enabled = False
                ChkAddNew.Visible = False
                TxtID.Text = Convert.ToString(varDataProperties.SystemModuleId)
                CboGroup.SelectedValue = CMDmods.Editor.GetMODgroupid(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))
                TxtCode.Text = CMDmods.Editor.GetMODcode(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))
                TxtName.Text = CMDmods.Editor.GetMODname(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))
                TxtDescription.Text = CMDmods.Editor.GetMODdescription(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))
                ChkSystem.Checked = CMDmods.Editor.GetMODsystem(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))
                ChkLocked.Checked = CMDmods.Editor.GetMODlocked(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))

                TxtCode.ReadOnly = True
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

            Call CheckAllInput()

            If (CboGroup.Items.Count = 0) OrElse (TxtCode.XOSQLText = String.Empty) OrElse (TxtName.XOSQLText = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "Make sure you have Module Group selected, Module Code and Module Name are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.SystemModuleIsNew) AndAlso (CMDmods.Editor.IsDuplicate(varDataProperties, TxtCode.XOSQLText)) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (varDataProperties.SystemModuleIsNew) AndAlso (CMDmods.Editor.IsDuplicate(varDataProperties, TxtCode.XOSQLText, Convert.ToString(varDataProperties.SystemModuleId))) Then
                Decision(My.Application.Info.AssemblyName.toupper, "Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDmods.Editor.PushData(varDataProperties, TxtID.XOSQLText, CboGroup.SelectedValue.ToString, TxtCode.XOSQLText, TxtName.XOSQLText, TxtDescription.XOSQLText, ChkSystem.Checked, ChkLocked.Checked, Convert.ToString(varDataProperties.SystemModuleId))) Then
                RaiseEvent EventRecordSaved()
                UI.FRMmainframe6.Ts_status.Text = "Success"
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If (ChkAddNew.Checked) Then
                TxtID.Clear()
                TxtCode.Clear()
                TxtName.Clear()
                TxtDescription.Clear()
                ChkLocked.Checked = False
                TxtCode.ReadOnly = False
                TxtCode.Focus()
            Else
                Me.Close()
            End If

            RaiseEvent EventRecordSaved()
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged
            If (varDataProperties.SystemModuleIsNew) Then
                TxtID.Text = CMCv.Security.Encrypt.MD5(TxtCode.XOSQLText.ToUpper)
            End If
        End Sub
    End Class
End Namespace