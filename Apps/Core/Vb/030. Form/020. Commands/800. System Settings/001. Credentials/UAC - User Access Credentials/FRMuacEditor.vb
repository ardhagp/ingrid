Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMuacEditor

#Region "Declaration"
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
        Private WithEvents Frm_employee_Addin As New FRMuacEmployee

        Public Event EventRecordSaved()

        Private Const pEmployeeId As String = "@EmployeeId"
        Private Const pEmployeeNumber As String = "@EmployeeNumber"
        Private Const pEmployeeFullName As String = "@EmployeeFullName"

        Private varIsAdminstrator As Boolean
        Private varIsPWDChange As Boolean = False
        Private varMessageCannotSave As String = "Cannot save your record."
#End Region

#Region "Subs Collections"

        <SupportedOSPlatform("windows")>
        Private Sub GetData()
            CMDuac.Editor.DisplayData(varDataProperties, DgnUACe, Convert.ToString(varDataProperties.UserAccessId))
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CheckAllInput()
            TxtEmployeeNumber.Focus()
            TxtEmployeeFullName.Focus()
            TxtUsername.Focus()
            TxtPassword.Focus()
            BtnSave.Focus()
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMemployeeAddin_RecordSelected() Handles Frm_employee_Addin.EventRecordSelected
            TxtEmployeeNumber.Text = IIf(IsDBNull(varDataProperties.AllParameters(pEmployeeNumber)), "", varDataProperties.AllParameters(pEmployeeNumber)).ToString
            TxtEmployeeFullName.Text = varDataProperties.AllParameters(pEmployeeFullName).ToString
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnBrowseEmployee_Click(sender As Object, e As EventArgs) Handles BtnBrowseEmployee.Click
            Frm_employee_Addin = New FRMuacEmployee
            Display(Frm_employee_Addin, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Employee", "Browse for employee data", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            varDataProperties.UserAccessIsChangePasswordForm = False
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
            Com_mms_Menu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            DgnUACe.XOGETNewColor()

            If varDataProperties.UserAccessIsChangePasswordForm Then
                TbctlAccess.Visible = False
                ProgressBar1.Visible = False
                TxtEmployeeNumber.Width = 274
                LblPwdText.Visible = False
                Me.Height = 351
                Me.Width = 451
            End If

            If varDataProperties.UserAccessIsNew Then
                ChkAddNew.Enabled = True
                ChkAddNew.Visible = True
            Else
                ChkAddNew.Enabled = False
                ChkAddNew.Visible = False
                BtnBrowseEmployee.Visible = False
                TxtEmployeeNumber.Text = CMDuac.Editor.GetEmployeeNumber(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                TxtEmployeeFullName.Text = CMDuac.Editor.GetEmployeeFullName(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                TxtUsername.Text = CMDuac.Editor.GetUsernameByUserID(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                TxtUsername.Text = CMDuac.Editor.GetUsernameByUserID(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                varDataProperties.UserAccessPassword = CMDuac.Editor.GetPassword(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                ChkLocked.Checked = CMDuac.Editor.GetLocked(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                varIsAdminstrator = CMDuac.Editor.GetAdministrator(varDataProperties, varDataProperties.UserAccessId)
                ChkAdministrator.Checked = CMDuac.Editor.GetAdministrator(varDataProperties, Convert.ToString(varDataProperties.UserAccessId))
                If (varIsAdminstrator) AndAlso Not (varDataProperties.UserAccessIsChangePasswordForm) Then
                    ChkAdministrator.Visible = True
                Else
                    ChkAdministrator.Visible = False
                End If
                TxtPassword.Text = varDataProperties.UserAccessPassword
            End If
            TxtPassword.XOPasswordLengthMin = varMinPasswordLength
            Call GetData()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()

            If ((varDataProperties.UserAccessIsNew) AndAlso (varDataProperties.AllParameters(pEmployeeId).ToString Is String.Empty)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Make sure you have Employee data selected.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (TxtUsername.XOSqlText = String.Empty) OrElse (TxtPassword.XOSqlText = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Make sure you have Username and Password properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf ((varIsPWDChange) AndAlso (TxtPassword.TextLength < varMinPasswordLength)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Make sure your Password meets the minimum criteria.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf ((varDataProperties.UserAccessIsNew) AndAlso (CMDuac.Editor.IsDuplicate(varDataProperties, TxtUsername.XOSqlText))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "This Username already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.UserAccessIsNew) AndAlso (CMDuac.Editor.IsDuplicate(varDataProperties, TxtUsername.XOSqlText, Convert.ToString(varDataProperties.UserAccessId)))) Then
                Decision(My.Application.Info.AssemblyName.toupper, varMessageCannotSave & Environment.NewLine & "This Username already used by another employee.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call CheckPasswordChange()

            If CMDuac.Editor.PushData(varDataProperties, DgnUACe) Then
                RaiseEvent EventRecordSaved()
                UI.FRMmainframe6.Ts_status.Text = "Success"
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If (ChkAddNew.Checked) Then
                varDataProperties.UserAccessHash = CMCv.Security.Encrypt.MD5()
                TxtEmployeeNumber.Clear()
                TxtEmployeeFullName.Clear()
                TxtUsername.Clear()
                TxtPassword.Clear()
            Else
                Me.Close()
            End If
        End Sub

        Private Sub CheckPasswordChange()
            If TxtPassword.XOSqlText = varDataProperties.UserAccessPassword Then
                varIsPWDChange = False
            Else
                varIsPWDChange = True
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
            Call CheckPasswordChange()

            If (varIsPWDChange) Then
                LblPwdText.Text = TxtPassword.XOPasswordStrengthText
                ProgressBar1.Value = TxtPassword.XOPasswordStrengthScore
            End If
        End Sub
    End Class
End Namespace