Imports System.Runtime.Versioning
Imports CMCv

Public Class POST_Editor
#Region "Variables"
    Public Event RecordSaved()
    Public _SQL As New LibSQL.Commands.POST.Editor
    Public _FirstLoad As Boolean
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
    Private Sub POST_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        _FirstLoad = True
        _SQL.FILLCompany(V_DatabaseEngine, CboCompany)
        _SQL.FILLDepartement(V_DatabaseEngine, CboDepartement, CboCompany)

        If (V_FORMAttrib.IsNew) Then
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Visible = False
            CboCompany.SelectedValue = LibSQL.Commands.POST.Editor.GETCompanyID(V_DatabaseEngine, V_FORMAttrib.RowID)
            _SQL.FILLDepartement(V_DatabaseEngine, CboDepartement, CboCompany)
            CboDepartement.SelectedValue = LibSQL.Commands.POST.Editor.GETDepartmentID(V_DatabaseEngine, V_FORMAttrib.RowID)
            TxtPositionCode.Text = LibSQL.Commands.POST.Editor.GETPositionCode(V_DatabaseEngine, V_FORMAttrib.RowID)
            TxtPositionName.Text = LibSQL.Commands.POST.Editor.GETPositionName(V_DatabaseEngine, V_FORMAttrib.RowID)
            TxtPositionDescription.Text = LibSQL.Commands.POST.Editor.GETPositionDescription(V_DatabaseEngine, V_FORMAttrib.RowID)
        End If

        _FirstLoad = False
        '#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (_FirstLoad) Then
            _SQL.FILLDepartement(V_DatabaseEngine, CboDepartement, CboCompany)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If (CboDepartement.Items.Count = 0) OrElse (TxtPositionCode.XOSQLText = String.Empty) OrElse (TxtPositionName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Departement selected, Postition Code and Position Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((V_FORMAttrib.IsNew) AndAlso (LibSQL.Commands.POST.Editor.IsDuplicate(V_DatabaseEngine, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, V_FORMAttrib.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (V_FORMAttrib.IsNew) AndAlso (LibSQL.Commands.POST.Editor.IsDuplicate(V_DatabaseEngine, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, V_FORMAttrib.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (LibSQL.Commands.POST.Editor.PUSHData(V_DatabaseEngine, CboDepartement.SelectedValue.ToString, TxtPositionCode.XOSQLText, TxtPositionName.XOSQLText, TxtPositionDescription.XOSQLText, V_FORMAttrib.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
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
