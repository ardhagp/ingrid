Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMccinEditor

#Region "Variables"
    Public Event EventRecordSaved()
#End Region

#Region "Subs Collections"
    Private Sub CheckAllInput()
        'Call CheckAllControls()
        TxtCode.Focus()
        TxtName.Focus()
        TxtSearchTerm1.Focus()
        TxtSearchTerm2.Focus()
        TxtDescription.Focus()
        BtnSave.Focus()
    End Sub
#End Region

#Region "Form Events"

    <SupportedOSPlatform("windows")>
    Private Sub FRMccinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (varFormProperties.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Checked = False
        Else
            TxtCode.Text = CMDccin.Editor.GetCompanyCode(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtName.Text = CMDccin.Editor.GetCompanyName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtSearchTerm1.Text = CMDccin.Editor.GetSearchTerm1(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtSearchTerm2.Text = CMDccin.Editor.GetSearchTerm2(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtDescription.Text = CMDccin.Editor.GetDescription(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False
        End If
    End Sub
#End Region

#Region "Component Events"
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (TxtCode.XOSQLText = String.Empty) OrElse (TxtName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Company Code & Company Name properly filled.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, TxtCode.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already registered.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, TxtCode.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Company Code already used by another company.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        If (CMDccin.Editor.PushData(varDatabaseName, varDatabaseEngine, TxtCode.XOSQLText, TxtName.XOSQLText, TxtSearchTerm1.XOSQLText, TxtSearchTerm2.XOSQLText, TxtDescription.XOSQLText, Convert.ToString(varFormProperties.RowID))) Then
            FRMmainframe6.Ts_status.Text = "Success"
            RaiseEvent EventRecordSaved()
        Else
            FRMmainframe6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtCode.Text = String.Empty
        TxtName.Text = String.Empty
        TxtSearchTerm1.Text = String.Empty
        TxtSearchTerm2.Text = String.Empty
        TxtDescription.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        End If
    End Sub
#End Region

End Class
