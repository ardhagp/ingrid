Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMmodsEditor
#Region "Variables"
    Public Event EventRecordSaved()
#End Region

#Region "Subs Collection"
    <SupportedOSPlatform("windows")>
    Private Sub FillGroup(modulegroup As cbo)
        CMDmods.Editor.FillModuleGroup(varDatabaseName, varDatabaseEngineE, modulegroup)
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
        If (varFormProperties.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
            CboGroup.Focus()
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            TxtID.Text = Convert.ToString(varFormProperties.RowID)
            CboGroup.SelectedValue = CMDmods.Editor.GetMODgroupid(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtCode.Text = CMDmods.Editor.GetMODcode(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtName.Text = CMDmods.Editor.GetMODname(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtDescription.Text = CMDmods.Editor.GetMODdescription(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            ChkSystem.Checked = CMDmods.Editor.GetMODsystem(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            ChkLocked.Checked = CMDmods.Editor.GetMODlocked(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))

            TxtCode.ReadOnly = True
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Call CheckAllInput()

        If (CboGroup.Items.Count = 0) OrElse (TxtCode.XOSQLText = String.Empty) OrElse (TxtName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Module Group selected, Module Code and Module Name are properly filled.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (varFormProperties.IsNew) AndAlso (CMDmods.Editor.IsDuplicate(varDatabaseName, varDatabaseEnginee, TxtCode.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormProperties.IsNew) AndAlso (CMDmods.Editor.IsDuplicate(varDatabaseName, varDatabaseEnginee, TxtCode.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (CMDmods.Editor.PushData(varDatabaseName, varDatabaseEngineE, TxtID.XOSQLText, CboGroup.SelectedValue.ToString, TxtCode.XOSQLText, TxtName.XOSQLText, TxtDescription.XOSQLText, ChkSystem.Checked, ChkLocked.Checked, Convert.ToString(varFormProperties.RowID))) Then
            RaiseEvent EventRecordSaved()
            FRMmainframe6.Ts_status.Text = "Success"
        Else
            FRMmainframe6.ts_status.Text = "Failed to save"
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
        If (varFormProperties.IsNew) Then
            TxtID.Text = CMCv.Security.Encrypt.MD5(TxtCode.XOSQLText.ToUpper)
        End If
    End Sub
End Class
