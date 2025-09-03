Imports System.Runtime.Versioning
Imports CMCv

Public Class UAC_Editor

#Region "Variables"
    Private _SQL As New Commands.UAC.Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _AddinEmployee As New UAC_Employee
    Private _IsAdminstrator As Boolean
    Private _PWDChange As Boolean = False
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        Commands.UAC.Editor.DisplayData(V_DatabaseEngine, DgnUACe, V_FORMAttrib.RowID)
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
        TxtEmployeeNumber.Text = IIf(IsDBNull(V_FORMAttrib.Field02), "", V_FORMAttrib.Field02).ToString
        TxtEmployeeFullName.Text = V_FORMAttrib.Field03.ToString
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        _AddinEmployee = New UAC_Employee
        DISPLAY(_AddinEmployee, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Employee", "Browse for employee data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        V_FORMAttrib.IsChangePasswordForm = False
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

        If (V_FORMAttrib.IsChangePasswordForm) Then
            TbctlAccess.Visible = False
            ProgressBar1.Visible = False
            TxtEmployeeNumber.Width = 274
            LblPwdText.Visible = False
            Me.Height = 351
            Me.Width = 451
        End If

        If (V_FORMAttrib.IsNew) Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            BtnBrowseEmployee.Visible = False
            TxtEmployeeNumber.Text = Commands.UAC.Editor.GETEmployeeNumber(V_DatabaseEngine, V_FORMAttrib.RowID)
            TxtEmployeeFullName.Text = Commands.UAC.Editor.GETEmployeeFullName(V_DatabaseEngine, V_FORMAttrib.RowID)
            TxtUsername.Text = Commands.UAC.Editor.GETUsernameByUserID(V_DatabaseEngine, V_FORMAttrib.RowID)
            V_FORMAttrib.Password = Commands.UAC.Editor.GETPassword(V_DatabaseEngine, V_FORMAttrib.RowID)
            ChkLocked.Checked = Commands.UAC.Editor.GETLocked(V_DatabaseEngine, V_FORMAttrib.RowID)
            _IsAdminstrator = Commands.UAC.Editor.GETAdministrator(V_DatabaseEngine, V_USERAttrib.UID)
            ChkAdministrator.Checked = Commands.UAC.Editor.GETAdministrator(V_DatabaseEngine, V_FORMAttrib.RowID)
            If (_IsAdminstrator) AndAlso Not (V_FORMAttrib.IsChangePasswordForm) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = V_FORMAttrib.Password
        End If
        TxtPassword.XOPwdLengthMin = _MINPASSWORDLENGTH
        Call GETDATA()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If ((V_FORMAttrib.IsNew) AndAlso (V_FORMAttrib.Field01.ToString Is String.Empty)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Employee data selected.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Username and Password properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((_PWDChange) AndAlso (TxtPassword.TextLength < _MINPASSWORDLENGTH)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure your Password meets the minimum criteria.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf ((V_FORMAttrib.IsNew) AndAlso (Commands.UAC.Editor.IsDuplicate(V_DatabaseEngine, TxtUsername.XOSQLText))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (Not (V_FORMAttrib.IsNew) AndAlso (Commands.UAC.Editor.IsDuplicate(V_DatabaseEngine, TxtUsername.XOSQLText, V_FORMAttrib.RowID))) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call CheckPWDChange()

        If (Commands.UAC.Editor.PUSHData(V_DatabaseEngine, V_FORMAttrib.Field01.ToString, TxtUsername.XOSQLText, CMCv.Security.Encrypt.MD5(TxtPassword.XOSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, V_FORMAttrib.RowID, V_FORMAttrib.Hash, _PWDChange)) Then
            RaiseEvent RecordSaved()
            Mainframe_n_6.Ts_status.Text = "Success"
        Else
            Mainframe_n_6.ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            V_FORMAttrib.Hash = CMCv.Security.Encrypt.MD5()
            TxtEmployeeNumber.Clear()
            TxtEmployeeFullName.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckPWDChange()
        If TxtPassword.XOSQLText = V_FORMAttrib.Password Then
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
