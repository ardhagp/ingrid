Imports System.Runtime.Versioning
Imports CMCv

Public Class MODS_Editor
#Region "Variables"
    Private varSql As New Commands.MODS.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collection"
    <SupportedOSPlatform("windows")>
    Private Sub FillGroup(ByVal ModuleGroup As cbo)
        Commands.MODS.Editor.FillModuleGroup(varDatabaseName, varDatabaseEngine, ModuleGroup)
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
    Private Sub MODS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            CboGroup.SelectedValue = Commands.MODS.Editor.GetMODgroupid(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtCode.Text = Commands.MODS.Editor.GetMODcode(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtName.Text = Commands.MODS.Editor.GetMODname(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtDescription.Text = Commands.MODS.Editor.GETMODDescription(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkSystem.Checked = Commands.MODS.Editor.GetMODsystem(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkLocked.Checked = Commands.MODS.Editor.GETMODLocked(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))

            TxtCode.ReadOnly = True
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Call CheckAllInput()

        If (CboGroup.Items.Count = 0) OrElse (TxtCode.XOSQLText = String.Empty) OrElse (TxtName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Module Group selected, Module Code and Module Name are properly filled.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (varFormProperties.IsNew) AndAlso (Commands.MODS.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, TxtCode.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormProperties.IsNew) AndAlso (Commands.MODS.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, TxtCode.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.MODS.Editor.PushData(varDatabaseName, varDatabaseEngine, TxtID.XOSQLText, CboGroup.SelectedValue.ToString, TxtCode.XOSQLText, TxtName.XOSQLText, TxtDescription.XOSQLText, ChkSystem.Checked, ChkLocked.Checked, Convert.ToString(varFormProperties.RowID))) Then
            RaiseEvent RecordSaved()
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

        RaiseEvent RecordSaved()
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
