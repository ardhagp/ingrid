Imports CMCv

Public Class LOGIN
#Region "Variables"
    Private _SQL As New LibSQL.Commands.UAC.Login
    Public Event LoginSuccess()
    Public Event LoginFailed()
    Private _WrongLogin As Integer
    Private _HoldLogin As Integer
    Private _StatusTimer As Integer
#End Region

#Region "Subs Collection"
    Private Sub CheckAllInput()
        TxtUsername.Focus()
        TxtPassword.Focus()
        BtnLogin.Focus()
    End Sub
#End Region

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        RaiseEvent LoginFailed()
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call ExecLogin()
    End Sub

    Private Sub ExecLogin()
        If (TxtUsername.SLFSQLText = String.Empty) Or (TxtPassword.SLFSQLText = String.Empty) Then
            Exit Sub
        End If

        _USERAttrib.UID = _SQL.GETUID(TxtUsername.SLFSQLText, TxtPassword.SLFSQLText, _USERAttrib.FirstName)

        If _USERAttrib.UID = String.Empty Then
            RaiseEvent LoginFailed()
            _WrongLogin += 1
            SLFStatus.Items(0).Text = "Login Failed"
            _LOGUser.LoginFailed(TxtUsername.SLFSQLText)
            tmr_status.Enabled = True
            If _WrongLogin = 3 Then
                tmr_control.Enabled = True
            End If
        Else
            _USERAttrib.EID = _SQL.GETEID(_USERAttrib.UID)
            _USERAttrib.FirstName = _SQL.GETFirstName(_USERAttrib.UID)
            _USERAttrib.EmployeeNumber = _SQL.GETEmployeeNumber(_USERAttrib.UID)
            _USERAttrib.Gender = _SQL.GETGender(_USERAttrib.UID)
            _USERAttrib.Position = _SQL.GETPosition(_USERAttrib.UID)
            _USERAttrib.IsAdministrator = _SQL.GETAdministrator(_USERAttrib.UID)
            _LOGUser.LoginSuccess(_USERAttrib.EID)
            RaiseEvent LoginSuccess()
            Me.Close()
        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _WrongLogin = 0
        _HoldLogin = 15
        SLFStatus.Items(0).Text = String.Empty
        TxtUsername.Clear()
        TxtPassword.Clear()
        TxtUsername.Focus()
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ExecLogin()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub tmr_status_Tick(sender As Object, e As EventArgs) Handles tmr_status.Tick
        If _StatusTimer = 5 Then
            SLFStatus.Items(0).Text = ""
            tmr_status.Enabled = False
            _StatusTimer = 0
        Else
            _StatusTimer += 1
        End If
    End Sub

    Private Sub tmr_control_Tick(sender As Object, e As EventArgs) Handles tmr_control.Tick
        If _HoldLogin = 30 Then
            tmr_control.Enabled = False
            TxtUsername.Text = String.Empty
            TxtPassword.Text = String.Empty
            TxtUsername.Enabled = True
            TxtPassword.Enabled = True
            BtnLogin.Enabled = True
            BtnCancel.Enabled = True
            TxtUsername.Focus()
            _WrongLogin = 0
            _HoldLogin = 0
        Else
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            BtnLogin.Enabled = False
            BtnCancel.Enabled = False
            _HoldLogin += 1
        End If
    End Sub

    Private Sub LOGIN_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class
