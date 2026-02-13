'For clickonce .net 6 prequisites please paste here : C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Microsoft\VisualStudio\BootstrapperPackages

Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMmainframe6

#Region "Interface"
        Public Interface ICommandFunction
            Function LoadCommand() As CMCv.frmStandard
        End Interface

        Public Interface ICommandName
            ReadOnly Property CommandCode As String
        End Interface
#End Region

#Region "Declaration"
        Private WithEvents Frm_login As New Ingrid.UI.FRMlogin
        Private WithEvents Frm_conn As Connect.UI.FRMconn
        Private WithEvents Frm_phtrz As New CMCv.FRMphtrz
        Private WithEvents Frm_uac_Editor As FRMuacEditor
        Private WithEvents Frm_ntfc As FRMntfc

        Public Event EventMainframeOpen()
        Public Event EventMainframeClose()

        Private varSql As New LibSQL.Mainframe.Database
        Private varSqlDBcheck As New LibSQL.CMDdbic.Applications
        Private varSqlNotification As New LibSQL.Application.Notification
        Private varSqlRunningText As New LibSQL.Application.RunningText
        Private varSqlModules As New LibSQL.Application.Modules
        Private varSqlProfiles As New LibSQL.Application.ProfilePanel
        Private varSqlStorage As New LibSQL.Application.StorageSense
        Private varGetNotifCounter As Integer
        Private varClearStatus As Integer
        Private varSession As Boolean
        Private varTotalNotification As Integer
        Private varRunningTextActive As Integer
        Private varMyMarquee As New Application.Marquee
#End Region

#Region "Subs Collection"
        <SupportedOSPlatform("windows")>
        Private Sub CommandAutoComplete()
            Try
                Dim varDataset As New DataSet
                Dim varList As New AutoCompleteStringCollection

                'Txt_shortcut.AutoCompleteSource = Nothing
                Txt_shortcut.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                varDataset = varSqlModules.DisplayAutoComplete(varDatabaseName, varDatabaseEngineE) '.DisplayAutoComplete(Convert.ToString(varFormProperties.RowID), DgnPictureList)
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

        <SupportedOSPlatform("windows")>
        Private Sub GetRunningText()
            TxtRunning.Visible = varSqlRunningText.Show(varDatabaseName, varDatabaseEngineE, varProperties.IsAdministrator)
        End Sub

        ''' <summary>
        ''' Get Notification Count
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub GetNotification()
            varTotalNotification = varSqlNotification.Exist(varDatabaseName, varDatabaseEngineE, varProperties.EmployeeID)
            If varTotalNotification > 0 Then
                USERMENU.Text = varProperties.FirstName & "*"
                USERMENU.BackColor = Global.System.Drawing.Color.LightPink
                USERMENU.ForeColor = Global.System.Drawing.Color.Black
            Else
                USERMENU.Text = varProperties.FirstName
                USERMENU.BackColor = Global.System.Drawing.Color.Yellow
                USERMENU.ForeColor = Global.System.Drawing.Color.Black
            End If
            NotificationToolStripMenuItem.Text = varTotalNotification & " Notification(s)"
        End Sub

        ''' <summary>
        ''' Clear Status Bar 
        ''' </summary>
        Private Sub ClearStatus()
            Ts_status.Text = String.Empty
            varClearStatus = 0
        End Sub

        ''' <summary>
        ''' Close All varWorkspace Windows
        ''' </summary>
        ''' <param name="forced"></param>
        <SupportedOSPlatform("windows")>
        Private Sub CloseAllWindows(Optional forced As Boolean = False)
            Try
                If Not (forced) AndAlso (Global.System.Windows.Forms.MessageBox.Show("Do you want to close all varWorkspace windows?", "Close All Windows", Global.System.Windows.Forms.MessageBoxButtons.YesNo, Global.System.Windows.Forms.MessageBoxIcon.Question) = Global.System.Windows.Forms.DialogResult.Yes) Then
                    For Each openedforms As CMCv.frmStandard In Tmdi_.MdiChildren
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

        <SupportedOSPlatform("windows")>
        Private Sub EnterCommand(commandcode As String)

            'For Modules That Not Required Login
            If (commandcode.ToUpper.Trim = "RESET") OrElse (commandcode.ToUpper.Trim = "PHTRZ") Then
                Globals.varWorkspace.Open(Me, commandcode.ToUpper.Trim, St_mainframe)
                Txt_shortcut.Clear()
                Return
            Else
                Call LoginClicked() ' Ensure User Logged In
            End If
            ' Check Module Availability
            If Not (Application.Modules.IsModuleReady(varDatabaseName, varDatabaseEngineE, commandcode.ToUpper.Trim)) Then
                St_mainframe.Items(0).Text = "Module " & commandcode.ToUpper.Trim & " not found."
                Return
            ElseIf (Application.Modules.IsModuleLocked(varDatabaseName, varDatabaseEngineE, commandcode.ToUpper.Trim)) Then
                St_mainframe.Items(0).Text = "[" & commandcode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator."
                Bridge.Security.Writelog.Sendlog("""message"" : """ & varProperties.FirstName & " trying to open Under Maintenance Module " & commandcode.ToUpper.Trim & """,", "Warning")
                Decision(My.Application.Info.AssemblyName.ToUpper, "[" & commandcode.ToUpper.Trim & "] module is under maintenance. Please contact your administrator.", LibApp.Ingrid.Global.PopupType.ModuleUnderMaintenance, "", CMCv.FRMdialogbox.MessageIcon.Information, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                System.Media.SystemSounds.Beep.Play()
                Return
            ElseIf Not (varUserAccess.User(varDatabaseName, varDatabaseEngineE, commandcode.ToUpper.Trim, varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.View, St_mainframe)) Then ''' Check User Access
                St_mainframe.Items(0).Text = "You are not authorized to access : " & commandcode.ToUpper.Trim
                Bridge.Security.Writelog.Sendlog("""message"" : " & varProperties.FirstName & " trying to open Restricted Module " & commandcode.ToUpper.Trim & """", "Warning")
                System.Media.SystemSounds.Beep.Play()
                Return
            Else ' Open Module
                Globals.varWorkspace.Open(Me, commandcode.ToUpper.Trim, St_mainframe)
                Bridge.Security.Writelog.Sendlog("""message"" : " & varProperties.FirstName & " opening Module " & commandcode.ToUpper.Trim & """,", "Information")
                Txt_shortcut.Clear()
            End If
        End Sub

#End Region

#Region "Application Menu"
        'Start Menu
        <SupportedOSPlatform("windows")>
        Private Sub MsstartLogin_Click(sender As Object, e As EventArgs) Handles Ms_start_Login.Click
            Call LoginClicked()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function LoginClicked() As Boolean
            If varProperties.UserID = String.Empty Then
                Frm_login = New Ingrid.UI.FRMlogin
                Display(Frm_login, IMAGEDB.Main.ImageLibrary.LOGIN_ICON, My.Application.Info.AssemblyName.ToUpper, "Sign In", "Please enter your credentials to continue", True)
            End If
            If varProperties.UserID = String.Empty Then
                varSession = False
                Call SystemLogout(True)
            Else
                varSession = True
                Call SystemLogout(False)
            End If
            Return varSession
        End Function

        <SupportedOSPlatform("windows")>
        Private Sub MsstartLogout_Click(sender As Object, e As EventArgs) Handles Ms_start_Logout.Click
            Call LogoutClicked()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub LogoutClicked()
            If Decision(My.Application.Info.AssemblyName.ToUpper, "Are you sure want to logout from system?", LibApp.Ingrid.Global.PopupType.Logout, "", FRMdialogbox.MessageIcon.Question, FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                Bridge.Security.Writelog.Sendlog("""message"" : " & varProperties.FirstName & " is logout."",", "Information")
                Call SystemLogout()
                varLogUser.Logout(varDatabaseName, varDatabaseEngineE, varProperties.EmployeeID)
                Call ClearLoginData()
            End If
        End Sub

        'varWorkspace Menu
        Private Sub MsworkspaceCascade_Click(sender As Object, e As EventArgs) Handles Ms_workspace_Cascade.Click
            Me.LayoutMdi(MdiLayout.Cascade)
        End Sub

        Private Sub MsworkspaceTileVertical_Click(sender As Object, e As EventArgs) Handles Ms_workspace_TileVertical.Click
            Me.LayoutMdi(MdiLayout.TileVertical)
        End Sub

        Private Sub MsworkspaceTileHorizontal_Click(sender As Object, e As EventArgs) Handles Ms_workspace_TileHorizontal.Click
            Me.LayoutMdi(MdiLayout.TileHorizontal)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub MsworkspaceCloseAll_Click(sender As Object, e As EventArgs) Handles Ms_workspace_CloseAll.Click
            Call CloseAllWindows()
        End Sub

        Private Sub MsworkspaceInputCommand_Click(sender As Object, e As EventArgs) Handles Ms_workspace_InputCommand.Click
            Txt_shortcut.Focus()
        End Sub

        Private Sub MsworkspaceMaximize_Click(sender As Object, e As EventArgs) Handles Ms_workspace_Maximize.Click
            Me.WindowState = FormWindowState.Maximized
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
            Try
                With varFormProperties
                    .RowID = varProperties.UserID
                    .IsNew = False
                    .IsChangePasswordForm = True
                End With
                Frm_uac_Editor = New FRMuacEditor
                Display(Frm_uac_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Change My Account", "Update your account username or password", True)
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

#End Region

#Region "Form Events"
        <SupportedOSPlatform("windows")>
        Private Sub FRMmainframe6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Try
                RaiseEvent EventMainframeOpen()
                varVersionapplication = GetAppVersion() 'Retrieve app version
                TmrNotif.Enabled = True

                Dim clsLog As New Ladybug.Log.Events

                ''' Log Application Start
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
                Call ActivateLicenses()
                Tmdi_.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererVS2010)
                varGetNotifCounter = 58
                varForceRefreshMainframeData = False
                TmrStatus.Interval = varStatusTimeWait * 1000
                Call SystemLogout()
                Call FirstLoad()
                varProperties.UserID = String.Empty
                Text += " - Ver. " & varVersionapplication
                varDatabaseName = LibSQL.Mainframe.Database.DatabaseName 'Retrieve Database Name
                varDatabaseEngine = LibSQL.Mainframe.Database.DatabaseEngine 'Retrieve Database Engine
                If varDatabaseEngine = "MSSQL" Then
                    varDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL
                ElseIf varDatabaseEngine = "MYSQL" Then
                    varDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL
                End If

                If Mainframe.Database.Connect(varProductionMode) Then
                    Ts_connection.Text = "Connected"
                    varLogApplication.Run(varDatabaseName, varDatabaseEngineE)
                    If varCompany.CountRecords(varDatabaseName, varDatabaseEngineE) = 0 Then
                        Display(FRMfirstguide,, My.Application.Info.AssemblyName.ToUpper, "First Guide", "Initial setup and essential information", True, Me)
                    End If
                Else
                    Ts_connection.Text = "Disconnected"
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot connect to server." & Environment.NewLine & "Please check your settings in APP -> Connection." & Environment.NewLine & "Restart Ingrid after you made any changes!", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                Call CommandAutoComplete()
                If Not (LibSQL.CMDdbic.Applications.IsCompanyExist(varDatabaseName, varDatabaseEngineE) OrElse Not LibSQL.CMDdbic.Applications.IsDepartmentExist(varDatabaseName, varDatabaseEngineE)) Then
                    Display(FRMfirstguide,, My.Application.Info.AssemblyName.ToUpper, "First Guide", "", True, Me)
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

#End Region

#Region "Components Events"
        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Private Sub TxtShortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_shortcut.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call EnterCommand(Txt_shortcut.Text.Trim)
                Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnExecute_Click(sender As Object, e As EventArgs) Handles BtnExecute.Click
            Call EnterCommand(Txt_shortcut.Text)
            Txt_shortcut.AutoCompleteCustomSource.Add(Txt_shortcut.Text.Trim)
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub SystemLogout(Optional ByVal islogout As Boolean = True)
            If Not (islogout) Then ''' Login Process
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
                Call GetNotification() ''' First Get Notification
                TmrNotif.Enabled = True
                NotificationToolStripMenuItem.Enabled = True
                Call GetProfile() ''' Get Profile Info
                Call GetStorage() ''' Get Storage Info
                Call GetSettings() ''' Get Settings Info
            Else ''' Logout Process
                varProperties.UserID = String.Empty
                Ms_start_Login.Visible = True
                Ms_start_Login.Enabled = True
                Ms_start_Logout.Visible = False
                Ms_start_Logout.Enabled = False
                Ms_start_Connection.Enabled = True
                MyAccountToolStripMenuItem.Enabled = False
                LoginToolStripMenuItem.Visible = True
                LoginToolStripMenuItem.Enabled = True
                LogoutToolStripMenuItem.Visible = False
                LogoutToolStripMenuItem.Enabled = False
                USERMENU.Text = "NOT LOGGED"
                USERMENU.BackColor = Global.System.Drawing.SystemColors.Control
                'tmdi_.AttachedTo = Nothing
                Call CloseAllWindows(True) ''' Close all windows on logout
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
                PctProfile.Image = My.Resources.AccountGroup_001_90_FFFFFFFF_
                PnlStorage.Visible = False
            End If
        End Sub

        Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)
            'TODO: Update method
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub PhotoResizerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhotoResizerToolStripMenuItem.Click
            Call EnterCommand("PHTRZ")
        End Sub

        Private Sub FRMphtrz_Done() Handles Frm_phtrz.EventDone
            Frm_phtrz.Dispose()
        End Sub

        Private Sub Frmconn_Done() Handles Frm_conn.ConnectFrameClose 'uncomment this when add Connect to library
            Frm_conn.Dispose()
        End Sub

        Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
            Try
                ''' Open Wiki URL
                Process.Start(New ProcessStartInfo(My.Settings.URL_Wiki) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TmrNotif_Tick(sender As Object, e As EventArgs) Handles TmrNotif.Tick
            varGetNotifCounter += 1
            If varGetNotifCounter = 60 Then
                Call GetNotification()
                Call GetRunningText()
                Call GetProfile()
                Call GetStorage()
                Call GetSettings()
                varGetNotifCounter = 0
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetProfile()
            PnlProfile.Visible = LibSQL.Application.ProfilePanel.Show(varDatabaseName, varDatabaseEngineE, varProperties.IsAdministrator)
            If (PnlProfile.Visible) Then
                LblWelcome.Text = LibSQL.Application.ProfilePanel.Welcome(varDatabaseName, varDatabaseEngineE)
                LblEmpNumber.Text = varProperties.EmployeeNumber

                Dim varNama = varProperties.FirstName.Split({" "}, StringSplitOptions.RemoveEmptyEntries)

                LblEmployeeName.Text = String.Join(" ", varNama.Take(2))
                LblPosition.Text = varProperties.EmployeePosition
                PctProfile.Image = varSqlProfiles.GetPhoto(varDatabaseName, varProperties.EmployeeID, varProperties.Gender)
                PnlProfile.Height = 191
            Else
                LblWelcome.Text = String.Empty
                LblEmpNumber.Text = String.Empty
                LblEmployeeName.Text = String.Empty
                LblPosition.Text = String.Empty
                PctProfile.Image = Nothing
                PnlProfile.Height = 0
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetStorage()
            Dim varDatacurrentsize As Integer
            Dim varFilecurrentsize As Integer
            Dim varFreespace As Integer

            PnlStorage.Visible = LibSQL.Application.StorageSense.Show(varDatabaseName, varDatabaseEngineE, varProperties.IsAdministrator)
            If (PnlStorage.Visible) Then
                PnlStorage.Height = 158
                varFreespace = CType(LibSQL.Application.StorageSense.MaxSize(varDatabaseName, LibSQL.Application.StorageSense.DBSizeType.FreeSpace), Integer)
                pgDataStorage.Maximum = varFreespace
                varDatacurrentsize = CType(LibSQL.Application.StorageSense.DataCurrentSize(varDatabaseName), Integer)
                pgDataStorage.Value = varDatacurrentsize
                lblDataStorage.Text = String.Format("{0} / {1}", IIf(varDatacurrentsize < 1024, varDatacurrentsize & " MB", Math.Round((varDatacurrentsize / 1024), 2) & " GB"), Math.Round((varFreespace / 1024), 2) & " GB")
                varFreespace = CType(LibSQL.Application.StorageSense.MaxSize(varDatabaseName, LibSQL.Application.StorageSense.DBSizeType.FreeSpace), Integer)
                pgFileStorage.Maximum = varFreespace
                varFilecurrentsize = CType(LibSQL.Application.StorageSense.FileCurrentSize(varDatabaseName, varDatabaseEngineE), Integer)
                pgFileStorage.Value = varFilecurrentsize
                lblFileStorage.Text = String.Format("{0} / {1}", IIf(varFilecurrentsize < 1024, varFilecurrentsize & " MB", Math.Round((varFilecurrentsize / 1024), 2) & " GB"), Math.Round((varFreespace / 1024), 2) & " GB")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub NotificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationToolStripMenuItem.Click
            Frm_ntfc = New FRMntfc
            Display(Frm_ntfc, IMAGEDB.Main.ImageLibrary.NOTIF_ICON, My.Application.Info.AssemblyName.ToUpper, "Notification", "Show all notification that addressed to you", True)
        End Sub

        Private Sub Tsstatus_TextChanged(sender As Object, e As EventArgs) Handles Ts_status.TextChanged
            varClearStatus = 0
            If Ts_status.Text = String.Empty Then
                TmrStatus.Enabled = False
            Else
                TmrStatus.Enabled = True
            End If
        End Sub

        Private Sub TmrStatus_Tick(sender As Object, e As EventArgs) Handles TmrStatus.Tick
            varClearStatus += 1
            If varClearStatus = varStatusTimeWait Then
                Call ClearStatus()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMlogin_LoginSuccess() Handles Frm_login.EventLoginSuccess
            Call GetNotification()
            PnlProfile.Visible = True
        End Sub

        Private Sub Tmrgc_Tick(sender As Object, e As EventArgs) Handles Tmr_gc.Tick
            GC.Collect()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Tmrmod_Tick(sender As Object, e As EventArgs) Handles TmrMOD.Tick
            If (varForceRefreshMainframeData) Then
                Call CommandAutoComplete() ''' Refresh Command Auto Complete
                varForceRefreshMainframeData = False
            End If
        End Sub

        Private Sub Support_Click(sender As Object, e As EventArgs) Handles SUPPORT.Click
            Try
                ''' Open Wiki URL
                Process.Start(New ProcessStartInfo(My.Settings.URL_Wiki) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
            Call LogoutClicked()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
            Call LoginClicked()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMmainframe6_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
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

                For Each varDeleteFile In Directory.GetFiles(varRequiredFolder, "*.*", SearchOption.TopDirectoryOnly)
                    File.Delete(varDeleteFile)
                Next
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
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
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        Private Sub Tmrrunningtext_Tick(sender As Object, e As EventArgs) Handles Tmr_runningtext.Tick
            varMyMarquee.Tick()
            TxtRunning.Text = varMyMarquee.MarqueeText
        End Sub

        Private Sub BuymeacoffeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuymeacoffeToolStripMenuItem.Click
            Try
                ''' Open Saweria URL
                Process.Start(New ProcessStartInfo(My.Settings.URL_Saweria) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub MsstartSettings_Click(sender As Object, e As EventArgs) Handles Ms_start_Settings.Click
            Call EnterCommand("SYSS")
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMlogin_LoginFailed() Handles Frm_login.EventLoginFailed
            Call ClearLoginData()
            Call SystemLogout(True)
        End Sub

        ''' <summary>
        ''' Clears the login data of the current user.
        ''' </summary>
        Private Sub ClearLoginData()
            varSession = False
            varProperties.EmployeeID = String.Empty
            varProperties.EmployeeNumber = String.Empty
            varProperties.FirstName = String.Empty
            varProperties.Gender = String.Empty
            varProperties.LastName = String.Empty
            varProperties.EmployeePosition = String.Empty
            varProperties.UserID = String.Empty
            varProperties.IsAdministrator = False
        End Sub

        ''' <summary>
        ''' Gets application settings such as maximum upload sizes, minimum password length, and text mark.
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Public Shared Sub GetSettings()
            varMaxUploadSizePDF = LibSQL.Application.Modules.MaxPDFallowed(varDatabaseName, varDatabaseEngineE)
            varMaxUploadSizePhoto = LibSQL.Application.Modules.MaxPhotoallowed(varDatabaseName, varDatabaseEngineE)
            varMinPasswordLength = LibSQL.Application.Modules.MinPasswordLength(varDatabaseName, varDatabaseEngineE)
            varTextmark = LibSQL.Application.Modules.TextMark(varDatabaseName, varDatabaseEngineE, varProperties.IsAdministrator)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub MsstartExit_Click(sender As Object, e As EventArgs) Handles Ms_start_Exit.Click
            If (varSession) Then
                Call SystemLogout() ''' Logout Process
                varLogUser.Logout(varDatabaseName, varDatabaseEngineE, varProperties.EmployeeID)
                Call ClearLoginData() ''' Clear Login Data
            End If
            Me.Close()
            System.Windows.Forms.Application.Exit()
            Return
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Msstartconnectionapp_Click(sender As Object, e As EventArgs) Handles Ms_start_connection_app.Click
            Frm_conn = New Connect.UI.FRMconn(varProductionMode, True)
            Display(Frm_conn, IMAGEDB.Main.ImageLibrary.CONN_ICON, My.Application.Info.AssemblyName.ToUpper, "Connection Settings", "Configure Ingrid database connection", True)
        End Sub

        Private Sub Msstartconnectionfolder_Click(sender As Object, e As EventArgs) Handles Ms_start_connection_folder.Click
            Try
                ''' Open Resources Folder
                Process.Start(New ProcessStartInfo(My.Application.Info.DirectoryPath & "\Resources\") With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMmainframe6_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            RaiseEvent EventMainframeClose()
        End Sub


        'TODO: Reactivate when supported by .net 6
        'Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        'only supported in .net 4.8, please reactivate this when supported by .net 6
        'MsgBox("You are idle")
        'End Sub

    End Class
End Namespace