Namespace UI.Canvas
    Public Class FRMlogin
        Public Event EventLoginSuccess()
        Public Event EventLoginFailed()

        Private varWrongLogin As Integer
        Private varCooldownLogin As Integer
        Private varStatusTimer As Integer


        ''' <summary>
        ''' CheckAllInput ensures all input fields are focused to trigger validation.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CheckAllInput()
            TxtUsername.Focus()
            TxtPassword.Focus()
            BtnLogin.Focus()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            RaiseEvent EventLoginFailed()
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
            Call ExecLogin()
        End Sub

        ''' <summary>
        ''' ExecLogin handles the login process by validating user input, checking credentials against the database, and managing login attempts and cooldowns. It raises events for successful or failed logins and logs relevant information.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ExecLogin()
            Dim clsLog As New Ladybug.Log.Events

            If (TxtUsername.XOSqlText = String.Empty) OrElse (TxtPassword.XOSqlText = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Please fill in all fields.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                SetValue(.AllParameters, tIngrid.P_Username, TxtUsername.XOSqlText)
                SetValue(.AllParameters, tIngrid.P_UserPassword, CMCv.Security.Encryption.MD5(TxtPassword.XOSqlText))
            End With
            CMDuac.Login.GetUserProperties(varDataProperties, varDataProperties.AllParameters, varDatasetIngrid)

            If varDatasetIngrid.Tables(dtUserData).Rows.Count = 0 Then
                RaiseEvent EventLoginFailed()
                varWrongLogin += 1
                SLFStatus.Items(0).Text = "Login Failed"
                varLogUser.LoginFailed(varDataProperties, varDataProperties.AllParameters)

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
                SetValue(.AllParameters, tIngrid.P_UserId, CLng(varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tUser.C_UserId)))
                SetValue(.AllParameters, tIngrid.P_UserIsRoot, CBool(varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tUser.C_UserIsRoot)))
                SetValue(.AllParameters, tIngrid.P_EmployeeId, CLng(varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeId)))
                SetValue(.AllParameters, tIngrid.P_EmployeeNumber, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeNumber))
                SetValue(.AllParameters, tIngrid.P_EmployeeFullName, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeFullName))
                SetValue(.AllParameters, tIngrid.P_EmployeeNickname, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeNickname))
                SetValue(.AllParameters, tIngrid.P_EmployeePersonalIdNumber, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeePersonalIdNumber))
                SetValue(.AllParameters, tIngrid.P_EmployeeGender, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tEmployee.C_EmployeeGender))
                SetValue(.AllParameters, tIngrid.P_PositionCode, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tPosition.C_PositionCode))
                SetValue(.AllParameters, tIngrid.P_PositionName, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tPosition.C_PositionName))
            End With

            varLogUser.LoginSuccess(varDataProperties, varDataProperties.AllParameters)

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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            SLFLogo.Image = CMCv.ImageEditor.File.GetImage.ConvertSvgToBmp("\Resources\svg-LOGIN02.svg", True, 512, 512)

            varWrongLogin = 0
            varCooldownLogin = 0
            SLFStatus.Items(0).Text = String.Empty
            TxtUsername.Clear()
            TxtPassword.Clear()
            TxtUsername.Focus()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call ExecLogin() ' login process
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Tmrstatus_Tick(sender As Object, e As EventArgs) Handles tmr_status.Tick
            If varStatusTimer = 5 Then
                SLFStatus.Items(0).Text = ""
                tmr_status.Enabled = False
                varStatusTimer = 0
            Else
                varStatusTimer += 1
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
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