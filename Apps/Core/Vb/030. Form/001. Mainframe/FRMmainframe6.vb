' ----------------------------------------------------------
' Licensed under the MIT (the "License");
' you may not use this file except in compliance with the License.
' You may obtain a copy of the License at
' http://opensource.org/licenses/MIT
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.
'
' Author: ardhagp
'
' Additional Notes:
' 'For Clickonce .NET prerequisites please paste here :
' C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Microsoft\VisualStudio\BootstrapperPackages
' ----------------------------------------------------------

Namespace UI.Canvas
    Public Class FRMmainframe6
        ' ----------------------------------------------------------
        ' Interfaces
        ' ----------------------------------------------------------
        Public Interface ICommandFunction
            Function LoadCommand() As CMCv.UI.Canvas.FRMstandard
        End Interface

        Public Interface ICommandName
            ReadOnly Property CommandCode As String
        End Interface


        ' ----------------------------------------------------------
        ' Variables
        ' ----------------------------------------------------------
        Private WithEvents Frm_login As New UI.Canvas.FRMlogin
        Private WithEvents Frm_conn As Connect.UI.Canvas.FRMconn
        Private WithEvents Frm_phtrz As New CMCv.UI.Canvas.FRMphtrz
        Private WithEvents Frm_uac_Editor As FRMuacEditor
        Private WithEvents Frm_ntfc As FRMntfc

        Public Event EventMainframeOpen()
        Public Event EventMainframeClose()

        Private varClientId As Long
        Private varSql As New LibSQL.Mainframe.Database
        Private varAppNotification As New LibSQL.CMDapp.Notification
        Private varAppRunningText As New LibSQL.CMDapp.RunningText
        'Private varAppDBcheck As New LibSQL.CMDdbic.Applications
        'Private varAppProfiles As New LibSQL.CMDapp.ProfilePanel
        'Private varAppStorage As New LibSQL.CMDapp.StorageSense
        Private varAppModules As New LibSQL.CMDapp.Modules
        Private varAppClient As New LibSQL.CMDapp.Client
        Private varGetNotifCounter As Integer
        Private varClearStatus As Integer
        Private varSession As Boolean
        Private varTotalNotification As Integer
        Private varRunningTextActive As Integer
        Private varMyMarquee As New Application.Marquee

        Private Const dtDatabaseProperties As String = "DatabaseProperties"
        Private Const dtUserData As String = "UserData"
        Private Const dtSettings As String = "SYSS_Editor"


        ' ----------------------------------------------------------
        ' Forms Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the mainframe form is loaded. It initializes various components, sets up the user interface, retrieves application settings, and establishes a connection to the database. It also handles exceptions that may occur during the loading process and logs relevant information for debugging purposes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMmainframe6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                varDevice = CMCv.Device.Device.DetectFormFactor
                CMCv.ImageEditor.File.GetImage.GetImageFromUrlAsync(My.Settings.URL_MainframeBackground, Me,, True, "Background")
                CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Image_OPENCOMMAND, BtnExecute,, 48, 48, True, "Button")
                PctProfile.Image = CMCv.ImageEditor.File.GetImage.ConvertSvgToBmp("\Resources\svg-images.svg", True, 72, 72)
                Ms_mainframe.Items("SUPPORT").Image = CMCv.ImageEditor.File.GetImage.ConvertSvgToBmp("\Resources\svg-UPDATE.svg", True, 24, 24)

                ' Set MDI Client Background Color
                For Each ctrl As Control In Me.Controls
                    If TypeOf ctrl Is MdiClient Then
                        ctrl.BackColor = Color.FromArgb(11, 28, 45)
                    End If
                Next

                Call ActivateLicenses()
                RaiseEvent EventMainframeOpen()

                varVersionapplication = GetAppVersion() 'Retrieve app version
                TmrNotif.Enabled = True

                Dim clsLog As New Ladybug.Log.Events

                With proLog
                    .Message = "Ingrid Main App is opened."
                    .FromSender = "FRMmainframe6 Load Event"
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Information
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.None
                    .ResumeNext = True
                    .InternalStackTrace = String.Empty
                    .ShowErrorReporting = False
                    .SaveInBetterLog = True
                    .SaveLogInLocal = True
                    .Number = 0
                    .AppVersion = GetAppVersion()
                End With
                clsLog.ShowData(proLog)
                clsLog = Nothing

                ' Tmdi_.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererVS2010)
                varGetNotifCounter = 58
                varForceRefreshMainframeData = False
                TmrStatus.Interval = varStatusTimeWait * 1000

                ' Make sure user is logged out before loading the mainframe
                Call SystemLogout()

                ' Setup components and load initial data
                Call FirstLoad()

                SetValue(varDataProperties.AllParameters, tIngrid.P_UserId, 0)
                Text += " - Ver. " & varVersionapplication
                LibSQL.Mainframe.Database.GetDatabaseProperties(varDatasetIngrid)

                ' Check if database properties exist
                If varDatasetIngrid.Tables(dtDatabaseProperties).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(dtDatabaseProperties).Rows(0)
                        varDataProperties.ConnectionServerAddress = .Item("SERVERADDRESS").ToString
                        varDataProperties.ConnectionServerPort = CInt(.Item("SERVERPORT").ToString)
                        varDataProperties.ConnectionUsername = .Item("USERNAME").ToString
                        varDataProperties.ConnectionPassword = .Item("PASSWORD").ToString
                        varDataProperties.ConnectionDatabaseEngineE = CType([Enum].Parse(GetType(LibApp.Ingrid.Global.DatabaseEngine), .Item("DATABASEENGINE").ToString), LibApp.Ingrid.Global.DatabaseEngine)
                        varDataProperties.ConnectionDatabaseEngine = .Item("DATABASEENGINE").ToString
                        varDataProperties.ConnectionDatabaseName = .Item("DBFORDATA").ToString
                        SetValue(varDataProperties.AllParameters, tIngrid.P_ClientCode, .Item("CLIENT").ToString)
                    End With
                Else
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Database properties not found.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                ' Connect to Database
                If Mainframe.Database.Connect(varDataProperties) Then
                    SetValue(varDataProperties.AllParameters, tIngrid.P_ClientId, varAppClient.GetClientId(varDataProperties))
                    'varClientId = varAppClient.GetClientId(varDataProperties)
                    Ts_connection.Text = "Connected"
                    varLogApplication.Run(varDataProperties, varDataProperties.AllParameters)
                    Dim varRecords As Integer = LibSQL.CMDccin.View.CountRecords(varDataProperties)

                    ' Check if company and department exist, if not, show first guide
                    If varRecords = 0 Then
                        varDataProperties.IngridFormImage = Nothing
                        varDataProperties.IngridFormTitle = "First Guide"
                        varDataProperties.IngridFormSubtitle = "Initial setup and essential information"
                        varDataProperties.IngridFormIsDialog = True
                        Display(FRMfirstguide, Me, varDataProperties)
                    End If
                    CMDsyss.View.GetSettingsProperties(varDataProperties, varDataProperties.AllParameters, varDatasetIngrid)
                Else
                    Ts_connection.Text = "Disconnected"
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot connect to server." & Environment.NewLine & "Please check your settings in APP -> Connection." & Environment.NewLine & "Restart Ingrid after you made any changes!", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If
                SetValue(varDataProperties.AllParameters, tIngrid.P_ClientId, IIf(CInt(varDataProperties.AllParameters(tIngrid.P_ClientId)) = 0, DBNull.Value, varDataProperties.AllParameters(tIngrid.P_ClientId)))

                Call CommandAutoComplete()

                ' Check if company and department exist, if not, show first guide
                If Not (LibSQL.CMDdbic.Applications.IsCompanyExist(varDataProperties) OrElse Not LibSQL.CMDdbic.Applications.IsDepartmentExist(varDataProperties)) Then
                    varDataProperties.IngridFormImage = Nothing
                    varDataProperties.IngridFormTitle = "First Guide"
                    varDataProperties.IngridFormSubtitle = "Initial setup and essential information"
                    varDataProperties.IngridFormIsDialog = True
                    Display(FRMfirstguide, Me, varDataProperties)
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Load] Mainframe"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events

                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the mainframe form is closing. It performs cleanup operations such as logging the closure event and deleting temporary files in the PDF directory. If any exceptions occur during this process, they are logged appropriately. The method ensures that necessary resources are released and that the application state is properly managed before the form is closed.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMmainframe6_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            Dim varRequiredFolder = CheckRequiredFolder(DirName.PDF)

            Try
                Dim clsLog As New Ladybug.Log.Events
                With proLog
                    .Message = "Ingrid Main App is closing."
                    .FromSender = "FRMmainframe6 Closing Event"
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Information
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.None
                    .ResumeNext = True
                    .InternalStackTrace = String.Empty
                    .Number = 0
                    .ShowErrorReporting = False
                    .SaveInBetterLog = True
                    .SaveLogInLocal = True
                    .AppVersion = GetAppVersion()
                End With
                clsLog.ShowData(proLog)
                clsLog = Nothing

                For Each varDeleteFile In System.IO.Directory.GetFiles(varRequiredFolder, "*.*", System.IO.SearchOption.TopDirectoryOnly)
                    System.IO.File.Delete(varDeleteFile)
                Next
            Catch ex As Exception
                With proLog
                    .FromSender = "[Closing] Mainframe"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                    .AppVersion = GetAppVersion()
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the mainframe form is closed. It raises the EventMainframeClose event to notify any subscribers that the mainframe has been closed. This can be used to perform cleanup operations or update the application state accordingly.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMmainframe6_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            RaiseEvent EventMainframeClose()
        End Sub


        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event handler is triggered when the "Login" option in the start menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsstartLogin_Click(sender As Object, e As EventArgs) Handles Ms_start_Login.Click
            Call LoginClicked()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Logout" option in the start menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsstartLogout_Click(sender As Object, e As EventArgs) Handles Ms_start_Logout.Click
            Call LogoutClicked()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Cascade" option in the workspace menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsworkspaceCascade_Click(sender As Object, e As EventArgs) Handles Ms_workspace_Cascade.Click
            Me.LayoutMdi(MdiLayout.Cascade)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Tile Vertical" option in the workspace menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsworkspaceTileVertical_Click(sender As Object, e As EventArgs) Handles Ms_workspace_TileVertical.Click
            Me.LayoutMdi(MdiLayout.TileVertical)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Tile Horizontal" option in the workspace menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsworkspaceTileHorizontal_Click(sender As Object, e As EventArgs) Handles Ms_workspace_TileHorizontal.Click
            Me.LayoutMdi(MdiLayout.TileHorizontal)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Close All" option in the workspace menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsworkspaceCloseAll_Click(sender As Object, e As EventArgs) Handles Ms_workspace_CloseAll.Click
            Call CloseAllWindows()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Input Command" option in the workspace menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsworkspaceInputCommand_Click(sender As Object, e As EventArgs) Handles Ms_workspace_InputCommand.Click
            Txt_shortcut.Focus()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Maximize" option in the workspace menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsworkspaceMaximize_Click(sender As Object, e As EventArgs) Handles Ms_workspace_Maximize.Click
            Me.WindowState = FormWindowState.Maximized
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Change Password" option in the start menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
            Try
                With varDataProperties
                    .UserAccessId = varDataProperties.UserAccessId
                    .UserAccessIsNew = False
                    .UserAccessIsChangePasswordForm = True
                End With
                Frm_uac_Editor = New FRMuacEditor
                varDataProperties.IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                varDataProperties.IngridFormTitle = "Change My Account"
                varDataProperties.IngridFormSubtitle = "Update your account username or password"
                varDataProperties.IngridFormIsDialog = True
                Display(Frm_uac_Editor, Me, varDataProperties)
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[ChangePasswordToolStripMenuItem] $\Ingrid\Apps\Core\Vb\030. Form\001. Mainframe\FRMmainframe6.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events

                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when a node in the mainframe tree view is double-clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Tvmainframe_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles Tv_mainframe.NodeMouseDoubleClick
            Try
                With Tv_mainframe.SelectedNode
                    If .Name = "nd_file" Then
                        Call EnterCommand(.Tag.ToString)
                    End If
                End With
            Catch ex As Exception
                'please add error dialog box here
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when a key is pressed while the Txt_shortcut textbox has focus.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtShortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_shortcut.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call EnterCommand(Txt_shortcut.Text.Trim)
                Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the BtnExecute button is clicked. It calls the EnterCommand method with the text entered in the Txt_shortcut textbox and adds the command to the auto-complete source for future use.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click
            Call EnterCommand(Txt_shortcut.Text)
            Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Photo Resizer" option in the start menu is clicked. It calls the EnterCommand method with the command code "PHTRZ" to open the photo resizer tool.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub PhotoResizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotoResizerToolStripMenuItem.Click
            Call EnterCommand("PHTRZ")
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Contents" option in the start menu is clicked. It attempts to open the Wiki URL specified in the application settings using the default web browser. If any exceptions occur during this process, an error message is displayed to the user.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
            Try
                ' Open Wiki URL in default browser
                Process.Start(New ProcessStartInfo(My.Settings.URL_Wiki) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the TmrNotif timer ticks. It increments the notification counter and calls the GetNotification method every 60 ticks.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TmrNotif_Tick(sender As Object, e As EventArgs) Handles TmrNotif.Tick
            varGetNotifCounter += 1
            If varGetNotifCounter = 60 Then
                Call GetNotification()
                varGetNotifCounter = 0
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the TmrMOD timer ticks. It checks if the mainframe data needs to be refreshed and calls the CommandAutoComplete method if necessary.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Tmrmod_Tick(sender As Object, e As EventArgs) Handles TmrMOD.Tick
            If (varForceRefreshMainframeData) Then
                Call CommandAutoComplete() ''' Refresh Command Auto Complete
                varForceRefreshMainframeData = False
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the TmrStatus timer ticks. It increments the clear status counter and calls the ClearStatus method when the counter reaches the specified wait time.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TmrStatus_Tick(sender As Object, e As EventArgs) Handles TmrStatus.Tick
            varClearStatus += 1
            If varClearStatus = varStatusTimeWait Then
                Call ClearStatus()
            End If
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the Tmr_gc timer ticks. It forces garbage collection to free up memory.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Tmrgc_Tick(sender As Object, e As EventArgs) Handles Tmr_gc.Tick
            GC.Collect()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the SUPPORT button is clicked. It attempts to open the Wiki URL specified in the application settings using the default web browser. If any exceptions occur during this process, an error message is displayed to the user.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Support_Click(sender As Object, e As EventArgs) Handles SUPPORT.Click
            Try
                ' Open Wiki URL in default browser
                Process.Start(New ProcessStartInfo(My.Settings.URL_Home) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Logout" option in the start menu is clicked. It calls the LogoutClicked method to handle the logout process.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
            Call LogoutClicked()
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Login" option in the start menu is clicked. It calls the LoginClicked method to handle the login process.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
            Call LoginClicked()
        End Sub

        ''' <summary>
        ''' This event handler triggered when "Notification" option is clicked from start menu.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub NotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationToolStripMenuItem.Click
            Frm_ntfc = New FRMntfc
            varDataProperties.IngridFormImage = ImageDb.Main.ImageLibrary.NOTIF_ICON
            varDataProperties.IngridFormTitle = "Notification"
            varDataProperties.IngridFormSubtitle = "Show all notification that addressed to you"
            varDataProperties.IngridFormIsDialog = True
            Display(Frm_ntfc, Me, varDataProperties)
        End Sub

        ''' <summary>
        ''' Triggered everytime status text changed
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Tsstatus_TextChanged(sender As Object, e As EventArgs) Handles Ts_status.TextChanged
            varClearStatus = 0
            If Ts_status.Text = String.Empty Then
                TmrStatus.Enabled = False
            Else
                TmrStatus.Enabled = True
            End If
        End Sub

        ''' <summary>
        ''' Timer for running text
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Tmrrunningtext_Tick(sender As Object, e As EventArgs) Handles Tmr_runningtext.Tick
            varMyMarquee.Tick()
            TxtRunning.Text = varMyMarquee.MarqueeText
        End Sub

        ''' <summary>
        ''' This event handler when the "Buy me a coffe" option in the start menu is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BuymeacoffeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuymeacoffeToolStripMenuItem.Click
            Try
                ' Open Saweria URL
                Process.Start(New ProcessStartInfo(My.Settings.URL_Saweria) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Settings" option in the start menu is clicked. It calls the EnterCommand method with the command code "SYSS" to open the system settings form. This allows users to access and modify various application settings through the system settings interface.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsstartSettings_Click(sender As Object, e As EventArgs) Handles Ms_start_Settings.Click
            Call EnterCommand("SYSS")
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Connection Settings" option in the start menu is clicked. It opens a new instance of the connection settings form (FRMconn) and configures its properties, such as the form image, title, subtitle, and dialog behavior. The Display method is then called to show the connection settings form to the user, allowing them to configure the Ingrid database connection.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Msstartconnectionapp_Click(sender As Object, e As EventArgs) Handles Ms_start_connection_app.Click
            Frm_conn = New Connect.UI.Canvas.FRMconn(varProductionMode, True)
            varDataProperties.IngridFormImage = ImageDb.Main.ImageLibrary.CONN_ICON
            varDataProperties.IngridFormTitle = "Connection Settings"
            varDataProperties.IngridFormSubtitle = "Configure Ingrid database connection"
            varDataProperties.IngridFormIsDialog = True
            Display(Frm_conn, Me, varDataProperties)
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Connection Folder" option in the start menu is clicked. It attempts to open the "Resources" folder located in the application's directory using the default file explorer. If any exceptions occur during this process, such as if the folder cannot be found or accessed, an error message is displayed to the user in a message box.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Msstartconnectionfolder_Click(sender As Object, e As EventArgs) Handles Ms_start_connection_folder.Click
            Try
                ' Open Resources Folder
                Process.Start(New ProcessStartInfo(My.Application.Info.DirectoryPath & "\Resources\") With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        ''' <summary>
        ''' This event handler is triggered when the "Exit" option in the start menu is clicked. It checks if there is an active session, and if so, it calls the SystemLogout method to handle the logout process, logs the user out, and clears any login data. Finally, it closes the mainframe form and exits the application. This ensures that all necessary cleanup operations are performed before the application terminates.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub MsstartExit_Click(sender As Object, e As EventArgs) Handles Ms_start_Exit.Click
            If (varSession) Then
                Call SystemLogout() ' Logout Process
                varLogUser.Logout(varDataProperties, varDataProperties.AllParameters)
                Call ClearLoginData() ' Clear Login Data
            End If
            Me.Close()
            System.Windows.Forms.Application.Exit()
            Return
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This subroutine sets up the auto-complete functionality for the Txt_shortcut control. It retrieves a dataset of available commands from the application modules and populates an AutoCompleteStringCollection with the module codes. The Txt_shortcut control is then configured to use this collection for auto-completion, allowing users to easily find and enter commands. If any exceptions occur during this process, they are logged appropriately.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CommandAutoComplete()
            Try
                Dim varDataset As New System.Data.DataSet
                Dim varList As New AutoCompleteStringCollection

                'Txt_shortcut.AutoCompleteSource = Nothing
                Txt_shortcut.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                varDataset = varAppModules.DisplayAutoComplete(varDataProperties) '.DisplayAutoComplete(Convert.ToString(varDataProperties.RowID), DgnPictureList)
                If varDataset Is Nothing Then
                    Return
                End If
                For i As Integer = 0 To varDataset.Tables("TCMD").Rows.Count - 1
                    varList.Add(varDataset.Tables("TCMD").Rows(i).Item("module_code").ToString)
                Next
                Txt_shortcut.AutoCompleteCustomSource = varList
                Txt_shortcut.AutoCompleteSource = AutoCompleteSource.CustomSource
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[CommandAutoComplete] Mainframe"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' This subroutine retrieves and displays the running text in the TxtRunning control based on the current application settings and data properties. It checks if the running text should be shown and updates the visibility of the TxtRunning control accordingly.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRunningText()
            TxtRunning.Visible = varAppRunningText.Show(varDataProperties)
        End Sub

        ''' <summary>
        ''' Get Notification Count
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetNotification()
            varTotalNotification = varAppNotification.Exist(varDataProperties)

            ' Check if there are any notifications for the user. If there are notifications, update the USERMENU text to include an asterisk and change the background color to light pink. If there are no notifications, display the user's full name without an asterisk and set the background color to yellow. Update the NotificationToolStripMenuItem text to show the total number of notifications.
            If varTotalNotification > 0 Then
                USERMENU.Text = varDatasetIngrid.Tables(dtUserData).Rows(0).Item("employee_fullname").ToString & "*"
                USERMENU.BackColor = Global.System.Drawing.Color.LightPink
                USERMENU.ForeColor = Global.System.Drawing.Color.Black
            Else
                USERMENU.Text = varDatasetIngrid.Tables(dtUserData).Rows(0).Item("employee_fullname").ToString
                USERMENU.BackColor = Global.System.Drawing.Color.Yellow
                USERMENU.ForeColor = Global.System.Drawing.Color.Black
            End If
            NotificationToolStripMenuItem.Text = varTotalNotification & " Notification(s)"
        End Sub

        ''' <summary>
        ''' Clear Status Bar 
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ClearStatus()
            Ts_status.Text = String.Empty
            varClearStatus = 0
        End Sub

        ''' <summary>
        ''' Close All varWorkspace Windows
        ''' </summary>
        ''' <param name="forced"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CloseAllWindows(Optional isforced As Boolean = False)
            Try
                ' Prompt the user for confirmation before closing all workspace windows, unless the operation is forced.
                If Not (isforced) AndAlso (Global.System.Windows.Forms.MessageBox.Show("Do you want to close all Workspace windows?", "Close All Windows", Global.System.Windows.Forms.MessageBoxButtons.YesNo, Global.System.Windows.Forms.MessageBoxIcon.Question) = Global.System.Windows.Forms.DialogResult.No) Then
                    Return
                Else
                    For Each openedforms As CMCv.UI.Canvas.FRMstandard In Me.MdiChildren
                        openedforms.Close()
                        openedforms.Dispose()
                    Next
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[CloseAllWindows] Mainframe"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events

                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' This subroutine handles the execution of a command based on the provided command code. It checks for special commands like "RESET" or "PHTRZ", ensures the user is logged in, verifies module availability and maintenance status, checks user access permissions, and opens the corresponding module if all conditions are met. It also logs relevant actions and updates the status bar accordingly.
        ''' </summary>
        ''' <param name="commandcode"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EnterCommand(commandcode As String)
            SetValue(varDataProperties.AllParameters, tIngrid.P_ModuleCode, commandcode.ToUpper.Trim)

            ' Run RESET Command to delete all data
            If commandcode.ToUpper.Trim = "RESET" OrElse commandcode.ToUpper.Trim = "PHTRZ" Then
                [Global].varWorkspace.Open(Me, commandcode.ToUpper.Trim, St_mainframe)
                Txt_shortcut.Clear()
                Return
            Else
                Call LoginClicked() ' Ensure User Logged In
            End If

            If Not varSession Then
                Return
            End If

            ' Check if the module exists and retrieve its properties. If the module is not found, display a message in the status bar. If the module is under maintenance, inform the user and log the attempt. If the user does not have access to the module, display an unauthorized access message and log the attempt. If all checks pass, open the module in the workspace and log the action.
            LibSQL.UI.Workspace.GetModuleProperties(varDataProperties, varDataProperties.AllParameters, commandcode, varDatasetIngrid)

            With varDatasetIngrid.Tables(dtModule)
                If .Rows.Count = 0 Then
                    St_mainframe.Items(0).Text = "Module " & commandcode.ToUpper.Trim & " not found."
                    Return
                ElseIf CBool(.Rows(0).Item("module_ismaintenance")) Then
                    St_mainframe.Items(0).Text = "[" & commandcode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator."
                    Bridge.Writelog.Sendlog("""message"" : """ & varDataProperties.EmployeeFirstName & " trying to open Under Maintenance Module " & commandcode.ToUpper.Trim & """,", "Warning")
                    Decision(My.Application.Info.AssemblyName.ToUpper, "[" & commandcode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator.", LibApp.Ingrid.Global.PopupType.ModuleUnderMaintenance, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Information, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                    System.Media.SystemSounds.Beep.Play()
                    Return
                ElseIf Not (varUserAccess.User(varDataProperties, St_mainframe)) Then ''' Check User Access
                    St_mainframe.Items(0).Text = "You are not authorized to access : " & commandcode.ToUpper.Trim
                    Bridge.Writelog.Sendlog("""message"" : " & varDataProperties.EmployeeFirstName & " trying to open Restricted Module " & commandcode.ToUpper.Trim & """", "Warning")
                    System.Media.SystemSounds.Beep.Play()
                    Return
                Else
                    [Global].varWorkspace.Open(Me, commandcode.ToUpper.Trim, St_mainframe)
                    Bridge.Writelog.Sendlog("""message"" : " & varDataProperties.EmployeeFirstName & " opening Module " & commandcode.ToUpper.Trim & """,", "Information")
                    Txt_shortcut.Clear()
                End If
            End With
        End Sub

        ''' <summary>
        ''' This function handles the login process when the login button is clicked. It checks if user data is available, displays the login form if necessary, and updates the session state based on the login outcome. It also calls the SystemLogout function to manage UI changes and data clearing based on whether the user is logged in or out. The function returns a Boolean indicating whether the user is successfully logged in (True) or not (False).
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function LoginClicked() As Boolean
            ' Check if user data is available. If no user data is found, it indicates that the user is not logged in, and the login form is displayed to prompt the user for credentials. The login form is configured with appropriate properties such as form image, window name, title, subtitle, and dialog behavior. The Display function is called to show the login form to the user.
            If varDatasetIngrid.Tables(dtUserData).Rows.Count = 0 Then
                Frm_login = New UI.Canvas.FRMlogin
                varDataProperties.IngridFormImage = ImageDb.Main.ImageLibrary.LOGIN_ICON
                varDataProperties.IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                varDataProperties.IngridFormTitle = "Sign In"
                varDataProperties.IngridFormSubtitle = "Please enter your credentials to access the application"
                varDataProperties.IngridFormIsDialog = True
                Display(Frm_login,, varDataProperties)
            End If

            ' Check if user data is available after the login form is displayed. If no user data is found, it indicates that the login was unsuccessful, and the session state is set to False. The SystemLogout function is called with True to manage UI changes and data clearing for a logged-out state. If user data is found, it indicates a successful login, and the session state is set to True. The SystemLogout function is called with False to manage UI changes and data clearing for a logged-in state. Finally, the function returns the session state (True or False) to indicate whether the user is successfully logged in or not.
            If varDatasetIngrid.Tables(dtUserData).Rows.Count = 0 Then
                varSession = False
                Call SystemLogout(True)
            Else
                varSession = True
                Call SystemLogout(False)
            End If
            Return varSession
        End Function

        ''' <summary>
        ''' This subroutine handles the logout process when the logout button is clicked. It prompts the user for confirmation to end the session, logs the logout action, calls the SystemLogout function to manage UI changes and data clearing, and clears the login data. If the user confirms the logout action, it effectively ends the user's session and resets the application state accordingly.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LogoutClicked()
            If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to end your session now?", LibApp.Ingrid.Global.PopupType.Logout, "Please confirm your action", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                Bridge.Writelog.Sendlog("""message"" : " & varDataProperties.EmployeeFirstName & " is logout."",", "Information")
                ' Call SystemLogout to update the UI and clear data for logout
                Call SystemLogout()
                varLogUser.Logout(varDataProperties, varDataProperties.AllParameters)

                ' Clear login data to reset the application state
                Call ClearLoginData()
            End If
        End Sub

        ''' <summary>
        ''' SystemLogout handles the UI changes and data clearing when a user logs in or out. It updates the visibility and enabled state of menu items, resets notification counters, and clears profile and storage information on logout.
        ''' </summary>
        ''' <param name="islogout"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub SystemLogout(Optional islogout As Boolean = True)
            ' When user is logged in, update the UI to reflect the logged-in state. This includes hiding the login button, showing the logout button, disabling the connection settings, enabling account management options, and starting the notification timer to fetch new notifications. It also retrieves user settings, profile information, and storage details to ensure the application reflects the current user's data and preferences.
            If Not (islogout) Then
                Ms_start_Login.Visible = False
                Ms_start_Login.Enabled = False
                Ms_start_Logout.Visible = True
                Ms_start_Logout.Enabled = True
                Ms_start_Connection.Enabled = False
                MyAccountToolStripMenuItem.Enabled = True
                LoginToolStripMenuItem.Visible = False
                LoginToolStripMenuItem.Enabled = False
                LogoutToolStripMenuItem.Visible = True
                LogoutToolStripMenuItem.Enabled = True
                varGetNotifCounter = 58

                ' Retrieve and display notifications for the logged-in user. This includes fetching the count of notifications and updating the notification menu item to reflect the current number of notifications. The timer for notifications is enabled to periodically check for new notifications, ensuring that the user is kept informed of any updates or alerts relevant to their account or activities within the application.
                Call GetNotification()
                TmrNotif.Enabled = True
                NotificationToolStripMenuItem.Enabled = True

                ' Retrieve settings values from the database and update the application state accordingly. This includes fetching user profile information and storage details to ensure that the application reflects the current user's data and preferences.
                Call GetSettings()

                ' Get Profile Info
                Call GetProfile()

                ' Get Storage Info
                Call GetStorage()
            Else
                Call ClearLoginData()
                Ms_start_Login.Visible = True
                Ms_start_Login.Enabled = True
                Ms_start_Logout.Visible = False
                Ms_start_Logout.Enabled = False
                Ms_start_Connection.Enabled = True
                Ms_mainframe.Items("USERMENU").Image = Nothing
                MyAccountToolStripMenuItem.Enabled = False
                LoginToolStripMenuItem.Visible = True
                LoginToolStripMenuItem.Enabled = True
                LogoutToolStripMenuItem.Visible = False
                LogoutToolStripMenuItem.Enabled = False
                USERMENU.Text = "NOT LOGGED"
                USERMENU.BackColor = Global.System.Drawing.Color.White
                'tmdi_.AttachedTo = Nothing
                Call CloseAllWindows(True) ' Close all windows on logout
                TmrNotif.Enabled = False
                varGetNotifCounter = 0
                NotificationToolStripMenuItem.Text = "0 Notification(s)"
                NotificationToolStripMenuItem.Enabled = False
                PnlProfile.Visible = False
                PnlProfile.Height = 0
                LblWelcome.Text = ""
                LblEmpNumber.Text = "Loading..."
                LblEmployeeName.Text = "Loading..."
                LblPosition.Text = "Loading..."
                PctProfile.Image = My.Resources.PCTPRV_001_512_icon
                PnlStorage.Visible = False
            End If
        End Sub

        ''' <summary>
        ''' This function checks the visibility of a specific panel based on the provided panel settings and the user's admin status. It returns True if the panel should be visible, and False otherwise. The visibility is determined by the panel settings value, which can indicate whether the panel is always visible, visible only to admins, or visible only to non-admin users.
        ''' </summary>
        ''' <param name="panelsettings">Panel settings value indicating visibility rules.</param>
        ''' <param name="isadmin">Boolean indicating if the user is an admin.</param>
        ''' <returns>True if the panel should be visible, False otherwise.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function IsProfileVisible(panelsettings As Integer, isadmin As Boolean) As Boolean
            Return IsPanelVisible(panelsettings, isadmin)
        End Function

        ''' <summary>
        ''' This function checks the visibility of the storage panel based on the provided panel settings and the user's admin status. It returns True if the storage panel should be visible, and False otherwise. The visibility is determined by the panel settings value, which can indicate whether the panel is always visible, visible only to admins, or visible only to non-admin users.
        ''' </summary>
        ''' <param name="panelsettings">Panel settings value indicating visibility rules.</param>
        ''' <param name="isadmin">Boolean indicating if the user is an admin.</param>
        ''' <returns>True if the storage panel should be visible, False otherwise.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function IsStorageVisible(panelsettings As Integer, isadmin As Boolean) As Boolean
            Return IsPanelVisible(panelsettings, isadmin)
        End Function

        ''' <summary>
        ''' This function checks the visibility of the news ticker panel based on the provided panel settings and the user's admin status. It returns True if the news ticker panel should be visible, and False otherwise. The visibility is determined by the panel settings value, which can indicate whether the panel is always visible, visible only to admins, or visible only to non-admin users.
        ''' </summary>
        ''' <param name="panelsettings">Panel settings value indicating visibility rules.</param>
        ''' <param name="isadmin">Boolean indicating if the user is an admin.</param>
        ''' <returns>True if the news ticker panel should be visible, False otherwise.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function IsNewsTickerVisible(panelsettings As Integer, isadmin As Boolean) As Boolean
            Return IsPanelVisible(panelsettings, isadmin)
        End Function

        ''' <summary>
        ''' This function checks the visibility of a panel based on the provided profile settings and the user's admin status. It returns True if the panel should be visible, and False otherwise. The visibility is determined by the profile settings value, which can indicate whether the panel is always visible, visible only to admins, or visible only to non-admin users.
        ''' </summary>
        ''' <param name="profilesettings">Profile settings value indicating visibility rules.</param>
        ''' <param name="isadmin">Boolean indicating if the user is an admin.</param>
        ''' <returns>True if the panel should be visible, False otherwise.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function IsPanelVisible(profilesettings As Integer, isadmin As Boolean) As Boolean
            Return (profilesettings = 3) _
                    OrElse (isadmin AndAlso profilesettings = 1) _
                    OrElse (Not isadmin AndAlso profilesettings = 2)
        End Function

        ''' <summary>
        ''' This subroutine retrieves and displays the user's profile information in the profile panel. It checks if the profile panel should be visible based on the user's settings and admin status, and updates the labels and image accordingly. If the profile panel is not visible, it clears the labels and image to ensure no sensitive information is displayed.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetProfile()
            With varDatasetIngrid.Tables(dtSettings)
                ' When the dataset is empty, it means there are no settings available, so we exit the subroutine early to avoid any further processing.
                If .Rows.Count = 0 Then
                    Return
                End If

                PnlProfile.Visible = IsProfileVisible(CInt(.Rows(0).Item(tSettings.C_SettingsShowProfile)), CBool(varDataProperties.AllParameters(tIngrid.P_UserIsRoot)))
                PnlProfile.Height = 320
                ' If the profile panel is visible, we retrieve and display the user's profile information, including welcome message, employee number, name, position, and profile image. If the profile panel is not visible, we clear the labels and image to ensure no sensitive information is displayed.
                If (PnlProfile.Visible) Then
                    LblWelcome.Text = LibSQL.CMDapp.ProfilePanel.Welcome(varDataProperties)
                    LblEmpNumber.Text = varDataProperties.AllParameters(tIngrid.P_EmployeeNumber).ToString

                    Dim varNama = varDataProperties.AllParameters(tIngrid.P_EmployeeFullName).ToString.Split({" "}, StringSplitOptions.RemoveEmptyEntries)

                    LblEmployeeName.Text = String.Join(" ", varNama.Take(2))
                    LblPosition.Text = varDataProperties.AllParameters(tIngrid.P_PositionName).ToString
                    'PctProfile.Image = varSqlProfiles.GetPhoto(varDataProperties.ConnectionDatabaseName, varDataProperties.EmployeeId, varDataProperties.EmployeeGender)
                Else
                    LblWelcome.Text = String.Empty
                    LblEmpNumber.Text = String.Empty
                    LblEmployeeName.Text = String.Empty
                    LblPosition.Text = String.Empty
                    PctProfile.Image = Nothing
                    PnlProfile.Height = 0
                End If
            End With
        End Sub

        ''' <summary>
        ''' This subroutine retrieves and displays the storage information in the storage panel. It checks if the storage panel should be visible based on the user's settings and admin status, and updates the progress bars and labels to show the current data and file storage sizes along with the maximum free space available. If the storage panel is not visible, it does not perform any updates.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetStorage()
            Dim varDatacurrentsize As Integer
            Dim varFilecurrentsize As Integer
            Dim varFreespace As Integer

            With varDatasetIngrid.Tables(dtSettings)
                If .Rows.Count = 0 Then
                    Return
                End If

                PnlStorage.Visible = IsPanelVisible(CInt(.Rows(0).Item(tSettings.C_SettingsShowStorage)), CBool(varDataProperties.AllParameters(tIngrid.P_UserIsRoot)))
                PnlStorage.Height = 158
                If (PnlStorage.Visible) Then
                    varFreespace = CInt(LibSQL.CMDapp.StorageSense.MaxSize(varDataProperties.ConnectionDatabaseName, LibSQL.CMDapp.StorageSense.DBSizeType.FreeSpace))
                    pgDataStorage.Maximum = varFreespace
                    varDatacurrentsize = CInt(LibSQL.CMDapp.StorageSense.DataCurrentSize(varDataProperties.ConnectionDatabaseName))
                    pgDataStorage.Value = varDatacurrentsize
                    lblDataStorage.Text = String.Format("{0} / {1}", IIf(varDatacurrentsize < 1024, varDatacurrentsize & " MB", Math.Round((varDatacurrentsize / 1024), 2) & " GB"), Math.Round((varFreespace / 1024), 2) & " GB")
                    varFreespace = CInt(LibSQL.CMDapp.StorageSense.MaxSize(varDataProperties.ConnectionDatabaseName, LibSQL.CMDapp.StorageSense.DBSizeType.FreeSpace))
                    pgFileStorage.Maximum = varFreespace
                    varFilecurrentsize = CInt(LibSQL.CMDapp.StorageSense.FileCurrentSize(varDataProperties))
                    pgFileStorage.Value = varFilecurrentsize
                    lblFileStorage.Text = String.Format("{0} / {1}", IIf(varFilecurrentsize < 1024, varFilecurrentsize & " MB", Math.Round((varFilecurrentsize / 1024), 2) & " GB"), Math.Round((varFreespace / 1024), 2) & " GB")
                End If
            End With
        End Sub

        ''' <summary>
        ''' Clears the login data of the current user.
        ''' </summary>
        Private Sub ClearLoginData()
            varSession = False
            varDatasetIngrid.Tables(dtUserData).Rows.Clear()
        End Sub

        ''' <summary>
        ''' Gets application settings such as maximum upload sizes, minimum password length, and text mark.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub GetSettings()
            LibSQL.CMDsyss.View.GetSettingsProperties(varDataProperties, varDataProperties.AllParameters, varDatasetIngrid)
        End Sub


        ' ---------------------------------------------------------
        ' Addins or External Forms Events Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' Handles the event when the login is successful. It retrieves notifications, updates the profile panel, and loads the user's profile image from the specified URL. If no profile image URL is provided, it sets a default image.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMlogin_LoginSuccess() Handles Frm_login.EventLoginSuccess
            Call GetNotification()
            PnlProfile.Height = 320
            PnlProfile.Visible = True
            PctProfile.Image = Nothing
            PctProfile.BackgroundImage = Nothing
            If varDataProperties.AllParameters(tIngrid.P_AttachmentUrl).ToString = String.Empty Then
                PctProfile.Image = CMCv.ImageEditor.File.GetImage.ConvertSvgToBmp("\Resources\svg-404.svg", True, 512, 512)
            Else
                CMCv.ImageEditor.File.GetImage.GetImageFromUrlAsync(varDataProperties.AllParameters(tIngrid.P_AttachmentUrl).ToString, PctProfile,, True, "Profile")
                'PctProfile.ImageLocation = varDataProperties.AllParameters(tIngrid.P_AttachmentUrl).ToString
                CMCv.ImageEditor.File.GetImage.GetImageFromUrlAsync(varDataProperties.AllParameters(tIngrid.P_AttachmentUrl).ToString, Ms_mainframe, "USERMENU",, True, "Profile")
            End If
        End Sub

        ''' <summary>
        ''' Handles the event when the login fails. It clears the login data and logs out the user, resetting the application state accordingly.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMlogin_LoginFailed() Handles Frm_login.EventLoginFailed
            Call ClearLoginData()
            Call SystemLogout(True)
        End Sub

        ''' <summary>
        ''' Handles the event when the authorization form is closed. It disposes of the authorization form to free up resources.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMphtrz_Done() Handles Frm_phtrz.EventDone
            Frm_phtrz.Dispose()
        End Sub

        ''' <summary>
        ''' Handles the event when the connection settings form is closed. It disposes of the connection form to free up resources.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Frmconn_Done() Handles Frm_conn.ConnectFrameClose 'uncomment this when add Connect to library
            Frm_conn.Dispose()
        End Sub
    End Class
End Namespace