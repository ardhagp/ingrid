Imports System.Runtime.Versioning

Public Class LOGIN
#Region "Variables"
    Private varSQL As New LibSQL.Commands.UAC.Login
    Public Event LoginSuccess()
    Public Event LoginFailed()
    Private varWrongLogin As Integer
    Private varHoldLogin As Integer
    Private varStatusTimer As Integer
#End Region

#Region "Subs Collection"
    ''' <summary>
    ''' CheckAllInput ensures all input fields are focused to trigger validation.
    ''' </summary>
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

    <SupportedOSPlatform("windows")>
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call ExecLogin() '''login process
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ExecLogin()
        If (TxtUsername.XOSQLText = String.Empty) OrElse (TxtPassword.XOSQLText = String.Empty) Then
            Return
        End If

        varUserAttributes.UID = Commands.UAC.Login.GETUID(varDatabaseEngine, TxtUsername.XOSQLText, TxtPassword.XOSQLText, varUserAttributes.FirstName)

        If varUserAttributes.UID = String.Empty Then
            RaiseEvent LoginFailed()
            varWrongLogin += 1
            SLFStatus.Items(0).Text = "Login Failed"
            varLogUser.LoginFailed(varDatabaseEngine, TxtUsername.XOSQLText)

            Bridge.Security.Writelog.Sendlog("""message"" : """ & TxtUsername.XOSQLText & " failed to login."",", "Warning")

            tmr_status.Enabled = True
            If varWrongLogin = 3 Then
                tmr_control.Enabled = True
            End If
        Else
            With varUserAttributes
                .EID = Commands.UAC.Login.GETEID(varDatabaseEngine, varUserAttributes.UID)
                .FirstName = Commands.UAC.Login.GETFirstName(varDatabaseEngine, varUserAttributes.UID)
                .EmployeeNumber = Commands.UAC.Login.GETEmployeeNumber(varDatabaseEngine, varUserAttributes.UID)
                .Gender = Commands.UAC.Login.GETGender(varDatabaseEngine, varUserAttributes.UID)
                .Position = Commands.UAC.Login.GETPosition(varDatabaseEngine, varUserAttributes.UID)
                .IsAdministrator = Commands.UAC.Login.GETAdministrator(varDatabaseEngine, varUserAttributes.UID)
            End With

            varLogUser.LoginSuccess(varDatabaseEngine, varUserAttributes.EID)
            Bridge.Security.Writelog.Sendlog("""message"" : " & varUserAttributes.FirstName & " is login."",", "Information")
            RaiseEvent LoginSuccess()
            Me.Close()
        End If
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varWrongLogin = 0
        varHoldLogin = 15
        SLFStatus.Items(0).Text = String.Empty
        TxtUsername.Clear()
        TxtPassword.Clear()
        TxtUsername.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ExecLogin() '''login process
        End If
    End Sub

    Private Sub tmr_status_Tick(sender As Object, e As EventArgs) Handles tmr_status.Tick
        If varStatusTimer = 5 Then
            SLFStatus.Items(0).Text = ""
            tmr_status.Enabled = False
            varStatusTimer = 0
        Else
            varStatusTimer += 1
        End If
    End Sub

    Private Sub tmr_control_Tick(sender As Object, e As EventArgs) Handles tmr_control.Tick
        If varHoldLogin = 30 Then '''allow login again
            tmr_control.Enabled = False
            TxtUsername.Text = String.Empty
            TxtPassword.Text = String.Empty
            TxtUsername.Enabled = True
            TxtPassword.Enabled = True
            BtnLogin.Enabled = True
            BtnCancel.Enabled = True
            TxtUsername.Focus()
            varWrongLogin = 0
            varHoldLogin = 0
        Else '''hold login
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            BtnLogin.Enabled = False
            BtnCancel.Enabled = False
            varHoldLogin += 1
        End If
    End Sub

    Private Sub LOGIN_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
End Class
