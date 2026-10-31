Namespace UI.Canvas
    ''' <summary>
    ''' FRMlogin is a Windows Forms class that handles user login functionality. It provides a user interface for entering a username and password, validates the input, checks credentials against a database, and manages login attempts and cooldowns. The class raises events for successful or failed logins and logs relevant information for auditing purposes.
    ''' </summary>
    Public Class FRMlogin
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Public Event EventLoginSuccess()
        Public Event EventLoginFailed()

        Private varWrongLogin As Integer
        Private varCooldownLogin As Integer
        Private varStatusTimer As Integer


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the FRMlogin form is loaded. It initializes the login form by loading the logo image from a specified URL, resetting the wrong login attempt counter and cooldown timer, clearing the username and password fields, and setting focus to the username input field. This prepares the form for user interaction and ensures that the login process starts with a clean state.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_LOGIN, XOLogo,, 512, 512, True, "Module")

            varWrongLogin = 0
            varCooldownLogin = 0
            SLFStatus.Items(0).Text = String.Empty
            TxtUsername.Clear()
            TxtPassword.Clear()
            TxtUsername.Focus()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the FRMlogin form is closed. It disposes of the form's resources to free up memory and ensure proper cleanup of any associated components. This helps prevent memory leaks and maintains application performance.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub FRMlogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
            Me.Dispose()
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' CheckAllInput ensures all input fields are focused to trigger validation.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CheckAllInput()
            TxtUsername.Focus()
            TxtPassword.Focus()
            BtnLogin.Focus()
        End Sub

        ''' <summary>
        ''' ExecLogin handles the login process by validating user input, checking credentials against the database, and managing login attempts and cooldowns. It raises events for successful or failed logins and logs relevant information.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ExecLogin()
            Dim clsLog As New Ladybug.Log.Events

            If (TxtUsername.XOSqlText = String.Empty) OrElse (TxtPassword.XOSqlText = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Please fill in all fields.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
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
                SetValue(.AllParameters, tIngrid.P_AttachmentUrl, varDatasetIngrid.Tables(dtUserData).Rows(0).Item(tAttachment.C_AttachmentUrl))
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


        ' ---------------------------------------------------------
        ' Components Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the "Cancel" button is clicked. It raises the EventLoginFailed event to notify that the login attempt has failed and closes the FRMlogin form, effectively terminating the login process and returning control to the parent form or application.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            RaiseEvent EventLoginFailed()
            Me.Close()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Login" button is clicked. It calls the ExecLogin method to initiate the login process, validating user input and checking credentials against the database. This allows users to submit their login credentials by clicking the login button.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
            Call ExecLogin()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when a key is pressed while the TxtPassword control has focus. If the Enter key is pressed, it calls the ExecLogin method to initiate the login process, allowing users to submit their credentials by pressing Enter instead of clicking the login button.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call ExecLogin() ' login process
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered at regular intervals by the tmr_status timer. It manages the display of status messages related to login attempts. If the varStatusTimer reaches 5, it clears the status message, disables the timer, and resets the varStatusTimer counter. Otherwise, it increments the varStatusTimer counter, allowing for a temporary display of status messages before they are cleared.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
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

        ''' <summary>
        ''' This event handler is triggered at regular intervals by the tmr_control timer. It manages the cooldown period after multiple failed login attempts. If varCooldownLogin reaches 30, it re-enables the login controls, clears the input fields, resets the wrong login attempt counter, and allows the user to attempt logging in again. If varCooldownLogin is less than 30, it disables the login controls and increments the varCooldownLogin counter, effectively enforcing a temporary lockout period to prevent further login attempts.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
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
    End Class
End Namespace