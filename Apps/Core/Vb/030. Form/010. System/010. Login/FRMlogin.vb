Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMlogin
#Region "Declaration"
        Public Event EventLoginSuccess()
        Public Event EventLoginFailed()

        Private varWrongLogin As Integer
        Private varCooldownLogin As Integer
        Private varStatusTimer As Integer

#End Region

#Region "Subs Collection"
        ''' <summary>
        ''' CheckAllInput ensures all input fields are focused to trigger validation.
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub CheckAllInput()
            TxtUsername.Focus()
            TxtPassword.Focus()
            BtnLogin.Focus()
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
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
            Dim clsLog As New Ladybug.Log.Events

            If (TxtUsername.XOSqlText = String.Empty) OrElse (TxtPassword.XOSqlText = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Please fill in all fields.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varDataProperties.UserParameters.Remove(tUser.P_Username)
            varDataProperties.UserParameters.Add(tUser.P_Username, TxtUsername.XOSqlText)
            varDataProperties.UserParameters.Remove(tUser.P_UserPassword)
            varDataProperties.UserParameters.Add(tUser.P_UserPassword, CMCv.Security.Encrypt.MD5(TxtPassword.XOSqlText))

            CMDuac.Login.GetUserProperties(varDataProperties, varDataProperties.UserParameters, varDatasetIngrid)

            If varDatasetIngrid.Tables(dtUserData).Rows.Count = 0 Then
                RaiseEvent EventLoginFailed()
                varWrongLogin += 1
                SLFStatus.Items(0).Text = "Login Failed"
                varLogUser.LoginFailed(varDataProperties, varDataProperties.UserParameters)

                With proLog
                    .Message = TxtUsername.XOSqlText & " failed to login."
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
                Return
            End If

            With varDataProperties
                .UserParameters.Remove(tUser.P_UserId)
                .UserParameters.Add(tUser.P_UserId, CLng(varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tUser.C_UserId)))
                .UserParameters.Remove(tUser.P_UserIsRoot)
                .UserParameters.Add(tUser.P_UserIsRoot, CBool(varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tUser.C_UserIsRoot)))
                .UserParameters.Remove(tEmployee.P_EmployeeId)
                .UserParameters.Add(tEmployee.P_EmployeeId, CLng(varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeId)))
                .UserParameters.Remove(tEmployee.P_EmployeeNumber)
                .UserParameters.Add(tEmployee.P_EmployeeNumber, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeNumber))
                .UserParameters.Remove(tEmployee.P_EmployeeFullName)
                .UserParameters.Add(tEmployee.P_EmployeeFullName, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeFullName))
                .UserParameters.Remove(tEmployee.P_EmployeeNickname)
                .UserParameters.Add(tEmployee.P_EmployeeNickname, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeNickname))
                .UserParameters.Remove(tEmployee.P_EmployeePersonalIdNumber)
                .UserParameters.Add(tEmployee.P_EmployeePersonalIdNumber, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeePersonalIdNumber))
                .UserParameters.Remove(tEmployee.P_EmployeeGender)
                .UserParameters.Add(tEmployee.P_EmployeeGender, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeGender))
                .UserParameters.Remove(tPosition.P_PositionCode)
                .UserParameters.Add(tPosition.P_PositionCode, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tPosition.C_PositionCode))
                .UserParameters.Remove(tPosition.P_PositionName)
                .UserParameters.Add(tPosition.P_PositionName, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tPosition.C_PositionName))
            End With

            varLogUser.LoginSuccess(varDataProperties, varDataProperties.UserParameters)

            With proLog
                .Message = varDataProperties.EmployeeFirstName & " is login."
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
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            varWrongLogin = 0
            varCooldownLogin = 0
            SLFStatus.Items(0).Text = String.Empty
            TxtUsername.Clear()
            TxtPassword.Clear()
            TxtUsername.Focus()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call ExecLogin() ' login process
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Tmrstatus_Tick(sender As Object, e As EventArgs) Handles tmr_status.Tick
            If varStatusTimer = 5 Then
                SLFStatus.Items(0).Text = ""
                tmr_status.Enabled = False
                varStatusTimer = 0
            Else
                varStatusTimer += 1
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Tmrcontrol_Tick(sender As Object, e As EventArgs) Handles tmr_control.Tick
            If varCooldownLogin = 30 Then ' allow login again
                tmr_control.Enabled = False
                TxtUsername.Text = String.Empty
                TxtPassword.Text = String.Empty
                TxtUsername.Enabled = True
                TxtPassword.Enabled = True
                BtnLogin.Enabled = True
                BtnCancel.Enabled = True
                TxtUsername.Focus()
                varWrongLogin = 0
                varCooldownLogin = 0
            Else ' hold login
                TxtUsername.Enabled = False
                TxtPassword.Enabled = False
                BtnLogin.Enabled = False
                BtnCancel.Enabled = False
                varCooldownLogin += 1
            End If
        End Sub

        Private Sub FRMlogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
            Me.Dispose()
        End Sub
    End Class
End Namespace