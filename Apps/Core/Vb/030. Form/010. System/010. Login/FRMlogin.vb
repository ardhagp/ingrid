Imports System.Runtime.Versioning

Public Class FRMlogin
#Region "Variables"
    Public Event EventLoginSuccess()
    Public Event EventLoginFailed()

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
        RaiseEvent EventLoginFailed()
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

        varProperties.UserID = CMDuac.Login.GetUserID(varDatabaseName, varDatabaseEngineE, TxtUsername.XOSQLText, TxtPassword.XOSQLText, varProperties.FirstName)

        If varProperties.UserID = String.Empty Then
            RaiseEvent EventLoginFailed()
            varWrongLogin += 1
            SLFStatus.Items(0).Text = "Login Failed"
            varLogUser.LoginFailed(varDatabaseName, varDatabaseEngineE, TxtUsername.XOSQLText)

            Dim clsLog As New Ladybug.Log.Events
            With proLog
                .Message = TxtUsername.XOSQLText & " failed to login."
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Warning
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.None
                .ResumeNext = True
                .Number = 0
                .InternalStackTrace = String.Empty
                .SaveInBetterLog = True
                .SaveLogInLocal = True
                .ShowErrorReporting = False
                .FromSender = "LOGIN"
                .AppVersion = GetAppVersion()
            End With
            clsLog.ShowData(proLog)
            clsLog = Nothing

            tmr_status.Enabled = True
            If varWrongLogin = 3 Then
                tmr_control.Enabled = True
            End If
        Else
            With varProperties
                .EmployeeID = CMDuac.Login.GetEmployeeID(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
                .FirstName = CMDuac.Login.GetFirstName(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
                .EmployeeNumber = CMDuac.Login.GetEmployeeNumber(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
                .Gender = CMDuac.Login.GetGender(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
                .EmployeePosition = CMDuac.Login.GetPosition(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
                .IsAdministrator = CMDuac.Login.GetAdministrator(varDatabaseName, varDatabaseEngineE, varProperties.UserID)
            End With

            varLogUser.LoginSuccess(varDatabaseName, varDatabaseEngine, varProperties.EmployeeID)

            Dim clsLog As New Ladybug.Log.Events
            With proLog
                .Message = varProperties.FirstName & " is login."
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Information
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.None
                .ResumeNext = True
                .Number = 0
                .InternalStackTrace = String.Empty
                .SaveInBetterLog = True
                .SaveLogInLocal = True
                .ShowErrorReporting = False
                .FromSender = "LOGIN"
                .AppVersion = GetAppVersion()
            End With
            clsLog.ShowData(proLog)
            clsLog = Nothing

            RaiseEvent EventLoginSuccess()
            Me.Close()
        End If
    End Sub

    Private Sub FRMlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Tmrstatus_Tick(sender As Object, e As EventArgs) Handles tmr_status.Tick
        If varStatusTimer = 5 Then
            SLFStatus.Items(0).Text = ""
            tmr_status.Enabled = False
            varStatusTimer = 0
        Else
            varStatusTimer += 1
        End If
    End Sub

    Private Sub Tmrcontrol_Tick(sender As Object, e As EventArgs) Handles tmr_control.Tick
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

    Private Sub FRMlogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub
End Class
