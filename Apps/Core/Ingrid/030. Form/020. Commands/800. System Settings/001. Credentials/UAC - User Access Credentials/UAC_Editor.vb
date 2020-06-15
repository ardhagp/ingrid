Imports CMCv

Public Class UAC_Editor

#Region "Variables"
    Private _SQL As New LibSQL.Commands.UAC.Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _AddinEmployee As New UAC_Employee
    Private _IsAdminstrator As Boolean
    Private _PWDChange As Boolean = False
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnUACe, _FORMAttrib.RowID)
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
        TxtEmployeeNumber.Text = IIf(IsDBNull(_FORMAttrib.Field02), "", _FORMAttrib.Field02)
        TxtEmployeeFullName.Text = _FORMAttrib.Field03
    End Sub

    Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
        _AddinEmployee = New UAC_Employee
        Display(_AddinEmployee, IMAGEDB.Main.ImageLibrary.SEARCH_001_512_icon, "Find Employee", "Browse for employee data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        _FORMAttrib.IsChangePasswordForm = False
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UAC_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me, True)
        _MMSMenu.ShowMenuFILE(UI.View.MenuStrip.ShowItem.Yes)

        DgnUACe.SLF_GETNewColor()

        If _FORMAttrib.IsChangePasswordForm = True Then
            TbctlAccess.Visible = False
            ProgressBar1.Visible = False
            TxtEmployeeNumber.Width = 274
            LblPwdText.Visible = False
            Me.Height = 351
            Me.Width = 451
        End If

        If _FORMAttrib.IsNew = True Then
            ChkAddNew.Enabled = True
            ChkAddNew.Visible = True
        Else
            ChkAddNew.Enabled = False
            ChkAddNew.Visible = False
            BtnBrowseEmployee.Visible = False
            TxtEmployeeNumber.Text = _SQL.GETEmployeeNumber(_FORMAttrib.RowID)
            TxtEmployeeFullName.Text = _SQL.GETEmployeeFullName(_FORMAttrib.RowID)
            TxtUsername.Text = _SQL.GETUsernameByUserID(_FORMAttrib.RowID)
            _FORMAttrib.Password = _SQL.GETPassword(_FORMAttrib.RowID)
            ChkLocked.Checked = _SQL.GETLocked(_FORMAttrib.RowID)
            _IsAdminstrator = _SQL.GETAdministrator(_USERAttrib.UID)
            ChkAdministrator.Checked = _SQL.GETAdministrator(_FORMAttrib.RowID)
            If (_IsAdminstrator = True) And (_FORMAttrib.IsChangePasswordForm = False) Then
                ChkAdministrator.Visible = True
            Else
                ChkAdministrator.Visible = False
            End If
            TxtPassword.Text = _FORMAttrib.Password
        End If
        TxtPassword.SLFPwdLengthMin = _MINPASSWORDLENGTH
        Call GETDATA()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()

        If (_FORMAttrib.IsNew = True) And (_FORMAttrib.Field01 = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Employee data selected.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (TxtUsername.SLFSQLText = String.Empty) Or (TxtPassword.SLFSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Username and Password properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_PWDChange = True) And (TxtPassword.TextLength < _MINPASSWORDLENGTH) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure your Password meets the minimum criteria.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = True) And (_SQL.IsDuplicate(TxtUsername.SLFSQLText) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already registered.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        ElseIf (_FORMAttrib.IsNew = False) And (_SQL.IsDuplicate(TxtUsername.SLFSQLText, _FORMAttrib.RowID) = True) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Username already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If

        Call CheckPWDChange()

        If _SQL.PUSHData(_FORMAttrib.Field01, TxtUsername.SLFSQLText, _SECEncrypt.MD5(TxtPassword.SLFSQLText), ChkLocked.Checked, ChkAdministrator.Checked, DgnUACe, _FORMAttrib.RowID, _FORMAttrib.Hash, _PWDChange) = True Then
            RaiseEvent RecordSaved()
            mainframe.ts_status.Text = "Success"
        Else
            mainframe.ts_status.Text = "Failed to save"
            Exit Sub
        End If

        If ChkAddNew.Checked = True Then
            _FORMAttrib.Hash = _SECEncrypt.MD5
            TxtEmployeeNumber.Clear()
            TxtEmployeeFullName.Clear()
            TxtUsername.Clear()
            TxtPassword.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub CheckPWDChange()
        If TxtPassword.SLFSQLText = _FORMAttrib.Password Then
            _PWDChange = False
        Else
            _PWDChange = True
        End If
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPWDChange()

        If _PWDChange = True Then
            LblPwdText.Text = TxtPassword.SLFPwdStrengthText
            ProgressBar1.Value = TxtPassword.SLFPwdStrengthScore
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub
End Class
