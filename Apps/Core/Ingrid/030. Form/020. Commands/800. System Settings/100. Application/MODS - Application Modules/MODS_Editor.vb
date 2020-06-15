Imports CMCv
Imports LibSQL

Public Class MODS_Editor
#Region "Variables"
    Private _SQL As New LibSQL.Commands.MODS.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collection"
    Private Sub FILLGroup(ByVal ModuleGroup As cbo)
        _SQL.FILLModuleGroup(ModuleGroup)
    End Sub

    Private Sub CheckAllInput()
        TxtID.Focus()
        TxtCode.Focus()
        TxtName.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub MODS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgnUserRoles.SLF_GETNewColor()

        Call FILLGroup(CboGroup)
        If _FORMAttrib.IsNew = True Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
            CboGroup.Focus()
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            TxtID.Text = _FORMAttrib.RowID
            CboGroup.SelectedValue = _SQL.GETMODGroupID(_FORMAttrib.RowID)
            TxtCode.Text = _SQL.GETMODCode(_FORMAttrib.RowID)
            TxtName.Text = _SQL.GETMODName(_FORMAttrib.RowID)
            TxtDescription.Text = _SQL.GETMODDescription(_FORMAttrib.RowID)
            ChkSystem.Checked = _SQL.GETMODSystem(_FORMAttrib.RowID)
            ChkLocked.Checked = _SQL.GETMODLocked(_FORMAttrib.RowID)
            TxtCode.ReadOnly = True
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Call CheckAllInput()

        If (CboGroup.Items.Count = 0) Or (TxtCode.SLFSQLText = String.Empty) Or (TxtName.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Module Group selected, Module Code and Module Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = True) And (_SQL.IsDuplicate(TxtCode.SLFSQLText) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = False) And (_SQL.IsDuplicate(TxtCode.SLFSQLText, _FORMAttrib.RowID) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Departement Code already used by another departement.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub

        End If

        If _SQL.PUSHData(TxtID.SLFSQLText, CboGroup.SelectedValue, TxtCode.SLFSQLText, TxtName.SLFSQLText, TxtDescription.SLFSQLText, ChkSystem.Checked, ChkLocked.Checked, _FORMAttrib.RowID) = True Then
            RaiseEvent RecordSaved()
            mainframe.ts_status.Text = "Success"
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        If ChkAddNew.Checked = True Then
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

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged
        If _FORMAttrib.IsNew = True Then
            TxtID.Text = _SECEncrypt.MD5(TxtCode.SLFSQLText.ToUpper)
        End If
    End Sub
End Class
