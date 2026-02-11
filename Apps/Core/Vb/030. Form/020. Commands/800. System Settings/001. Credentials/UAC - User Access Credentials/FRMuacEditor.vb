Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMuacEditor

#Region "Variables"
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
    Private WithEvents Frm_employee_Addin As New FRMuacEmployee

    Public Event EventRecordSaved()

    Private varIsAdminstrator As Boolean
    Private varIsPWDChange As Boolean = False
    Private varMessageCannotSave As String = "Cannot save your record."
    Private varMessageAlert As String = "Alert"
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GetData()
        CMDuac.Editor.DisplayData(varDatabaseName, varDatabaseEngineE, DgnUACe, Convert.ToString(varFormProperties.RowID))
    End Sub

    Private Sub CheckAllInput()
        TxtEmployeeNumber.Focus()
        TxtEmployeeFullName.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub FRMemployeeAddin_RecordSelected() Handles Frm_employee_Addin.EventRecordSelected
        TxtEmployeeNumber.Text = IIf(IsDBNull(varFormProperties.Field02), "", varFormProperties.Field02).ToString
        TxtEmployeeFullName.Text = varFormProperties.Field03.ToString
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        Frm_employee_Addin = New FRMuacEmployee
        Display(Frm_employee_Addin, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Employee", "Browse for employee data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        varFormProperties.IsChangePasswordForm = False
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMuacEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me, True)
        Com_mms_Menu.ShowMenuFile(UI.View.MenuStrip.ShowItem.Yes)

        DgnUACe.XOGETNewColor()

        If (varFormProperties.IsChangePasswordForm) Then
            TbctlAccess.Visible = False
            ProgressBar1.Visible = False
            TxtEmployeeNumber.Width = 274
            LblPwdText.Visible = False
            Me.Height = 351
            Me.Width = 451
        End If

        If (varFormProperties.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            BtnBrowseEmployee.Visible = False
            TxtEmployeeNumber.Text = CMDuac.Editor.GetEmployeeNumber(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtEmployeeFullName.Text = CMDuac.Editor.GetEmployeeFullName(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtUsername.Text = CMDuac.Editor.GetUsernameByUserID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            TxtUsername.Text = CMDuac.Editor.GetUsernameByUserID(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            varFormProperties.Password = CMDuac.Editor.GetPassword(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            ChkLocked.Checked = CMDuac.Editor.GetLocked(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            varIsAdminstrator = CMDuac.Editor.GetAdministrator(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
            ChkAdministrator.Checked = CMDuac.Editor.GetAdministrator(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))
            If (varIsAdminstrator) AndAlso Not (varFormProperties.IsChangePasswordForm) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = varFormProperties.Password
        End If
        TxtPassword.XOPwdLengthMin = varMinPasswordLength
        Call GetData()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If ((varFormProperties.IsNew) AndAlso (varFormProperties.Field01.ToString Is String.Empty)) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Make sure you have Employee data selected.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Make sure you have Username and Password properly filled.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((varIsPWDChange) AndAlso (TxtPassword.TextLength < varMinPasswordLength)) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "Make sure your Password meets the minimum criteria.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (CMDuac.Editor.IsDuplicate(varDatabaseName, varDatabaseEnginee, TxtUsername.XOSQLText))) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "This Username already registered.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (CMDuac.Editor.IsDuplicate(varDatabaseName, varDatabaseEnginee, TxtUsername.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision(My.Application.Info.AssemblyName, varMessageCannotSave & Environment.NewLine & "This Username already used by another employee.", varMessageAlert, frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call CheckPasswordChange()

        If (CMDuac.Editor.PushData(varDatabaseName, varDatabaseEngineE, varFormProperties.Field01.ToString, TxtUsername.XOSQLText, CMCv.Security.Encrypt.MD5(TxtPassword.XOSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, Convert.ToString(varFormProperties.RowID), varFormProperties.Hash, varIsPWDChange)) Then
            RaiseEvent EventRecordSaved()
            FRMmainframe6.Ts_status.Text = "Success"
        Else
            FRMmainframe6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            varFormProperties.Hash = CMCv.Security.Encrypt.MD5()
            TxtEmployeeNumber.Clear()
            TxtEmployeeFullName.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckPasswordChange()
        If TxtPassword.XOSQLText = varFormProperties.Password Then
            varIsPWDChange = False
        Else
            varIsPWDChange = True
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPasswordChange()

        If (varIsPWDChange) Then
            LblPwdText.Text = TxtPassword.XOPwdStrengthText
            ProgressBar1.Value = TxtPassword.XOPwdStrengthScore
        End If
    End Sub
End Class
