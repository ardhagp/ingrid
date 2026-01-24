Imports System.Runtime.Versioning
Imports CMCv

Public Class UAC_Editor

#Region "Variables"
    Private _SQL As New cmduac.Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _AddinEmployee As New UAC_Employee
    Private _IsAdminstrator As Boolean
    Private _PWDChange As Boolean = False
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GetData()
        cmduac.Editor.DisplayData(varDatabaseName, varDatabaseEngine, DgnUACe, Convert.ToString(varFormProperties.RowID))
    End Sub

    Private Sub CheckAllInput()
        TxtEmployeeNumber.Focus()
        TxtEmployeeFullName.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnSave.Focus()
    End Sub
#End Region

    Private Sub _AddinEmployee_RecordSelected() Handles _AddinEmployee.RecordSelected
        TxtEmployeeNumber.Text = IIf(IsDBNull(varFormProperties.Field02), "", varFormProperties.Field02).ToString
        TxtEmployeeFullName.Text = varFormProperties.Field03.ToString
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        _AddinEmployee = New UAC_Employee
        Display(_AddinEmployee, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Employee", "Browse for employee data", True)
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
    Private Sub UAC_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me, True)
        _MMSMenu.ShowMenuFILE(UI.View.MenuStrip.ShowItem.Yes)

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
            TxtEmployeeNumber.Text = cmduac.Editor.GetEmployeeNumber(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtEmployeeFullName.Text = cmduac.Editor.GetEmployeeFullName(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtUsername.Text = cmduac.Editor.GetUsernameByUserID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            TxtUsername.Text = cmduac.Editor.GetUsernameByUserID(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            varFormProperties.Password = cmduac.Editor.GetPassword(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            ChkLocked.Checked = cmduac.Editor.GetLocked(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            _IsAdminstrator = cmduac.Editor.GetAdministrator(varDatabaseName, varDatabaseEngine, varProperties.UserID)
            ChkAdministrator.Checked = cmduac.Editor.GetAdministrator(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))
            If (_IsAdminstrator) AndAlso Not (varFormProperties.IsChangePasswordForm) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = varFormProperties.Password
        End If
        TxtPassword.XOPwdLengthMin = varMinPasswordLength
        Call GETDATA()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If ((varFormProperties.IsNew) AndAlso (varFormProperties.Field01.ToString Is String.Empty)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Employee data selected.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Username and Password properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((_PWDChange) AndAlso (TxtPassword.TextLength < varMinPasswordLength)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure your Password meets the minimum criteria.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((varFormProperties.IsNew) AndAlso (cmduac.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, TxtUsername.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (varFormProperties.IsNew) AndAlso (cmduac.Editor.IsDuplicate(varDatabaseName, varDatabaseEngine, TxtUsername.XOSQLText, Convert.ToString(varFormProperties.RowID)))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call CheckPWDChange()

        If (cmduac.Editor.PushData(varDatabaseName, varDatabaseEngine, varFormProperties.Field01.ToString, TxtUsername.XOSQLText, CMCv.Security.Encrypt.MD5(TxtPassword.XOSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, Convert.ToString(varFormProperties.RowID), varFormProperties.Hash, _PWDChange)) Then
            RaiseEvent RecordSaved()
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

    Private Sub CheckPWDChange()
        If TxtPassword.XOSQLText = varFormProperties.Password Then
            _PWDChange = False
        Else
            _PWDChange = True
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPWDChange()

        If (_PWDChange) Then
            LblPwdText.Text = TxtPassword.XOPwdStrengthText
            ProgressBar1.Value = TxtPassword.XOPwdStrengthScore
        End If
    End Sub
End Class
