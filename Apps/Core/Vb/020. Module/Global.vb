Namespace UI
    Module [Global]
        ''' <summary>
        ''' Activates the licenses for third-party components used in the application. This method retrieves the Syncfusion license key from the Bridge.Getkey.Syncfusion() method and registers it using the SyncfusionLicenseProvider.RegisterLicense() method. It is marked to be supported only on Windows platforms.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub ActivateLicenses()
            Dim varSyncfusionkey As String = Bridge.Getkey.Syncfusion()

            'License for Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
        End Sub

        Public varFormimage(4) As System.Drawing.Image
        Public varWorkspace As New Workspace
        Public varFileinfo As New CMCv.OperatingSystem.File.Info
        Public varFolderHandler As New CMCv.OperatingSystem.Folder
        Public varImageCompress As New CMCv.ImageEditor.Proccessor.Compress
        Public varImageEditor As New CMCv.ImageEditor.Proccessor.Editor
        Public varUserAccess As New Application.Access
        Public varLogUser As New LibSQL.SystemLog.Activity.User
        Public varLogApplication As New LibSQL.SystemLog.Activity.Application
        Public varCompany As New LibSQL.CMDccin.View
        Public varForceRefreshMainframeData As Boolean
        'Public clsBridgelog As New Bridge.WRITELOG
        Public clsBetterstack As New LibAPI.Api.Betterstack.Heartbeats

        Public proLog As New CMCv.Ladybug.Log.Fields
        Public varSecurityencrypt As New CMCv.Security.Encryption

        Public WithEvents FRMmsg As CMCv.UI.Canvas.FRMdialogBox
        Public WithEvents FRMcam As CMCv.UI.Canvas.FRMcamera

        Public varVersionapplication As String
        Public varVersionnetworkapplication As Version

        Public varDataProperties As New LibApp.Ingrid.Global.Properties

        'Dataset Tables
        Public varDatasetIngrid As New Ingrid.UI.Dataset.ADSglobal
        Public Const dtSettings As String = "SYSS_Editor"
        Public Const dtModule As String = "SysModule"
        Public Const dtUserData As String = "UserData"

        'Database Tables
        Public tIngrid As New LibApp.Table.Application.Ingrid
        Public tCompany As New LibApp.Table.Man.Company
        Public tDepartment As New LibApp.Table.Man.Department
        Public tPosition As New LibApp.Table.Man.Position
        Public tEmployee As New LibApp.Table.Man.Employee
        Public tEmploymentType As New LibApp.Table.Man.EmploymentType
        Public tModule As New LibApp.Table.Sys.Module
        Public tSettings As New LibApp.Table.Sys.Settings
        Public tClient As New LibApp.Table.Sys.Client
        Public tLog As New LibApp.Table.Sys.Log
        Public tUser As New LibApp.Table.Sys.User
        Public tAttachment As New LibApp.Table.File.Attachment

        Public ReadOnly DatagridBehaviour As CMCv.UI.Components.Behavior.Datagrid


        ''' <summary>
        ''' Sets a value in the provided dictionary (parametername) for the specified key. If the key already exists, it removes the existing entry before adding the new key-value pair. If the value is Nothing, it adds DBNull.Value instead. This method is marked to be supported only on Windows platforms.
        ''' </summary>
        ''' <param name="parametername">The dictionary in which to set the value.</param>
        ''' <param name="[key]">The key for which the value should be set.</param>
        ''' <param name="[value]">The value to set for the specified key. If Nothing, DBNull.Value is used.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub SetValue(parametername As Dictionary(Of String, Object), [key] As String, Optional [value] As Object = Nothing)
            If parametername.ContainsKey([key]) Then
                parametername([key]) = IIf([value] Is Nothing, DBNull.Value, [value])
            Else
                parametername.Add([key], IIf([value] Is Nothing, DBNull.Value, [value]))
            End If
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="parametername"></param>
        ''' <param name="modulecode"></param>
        ''' <param name="moduleid"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub SetModuleIdentifier(parametername As Dictionary(Of String, Object), modulecode As String, Optional moduleid As Long = Nothing)
            SetValue(parametername, tIngrid.P_ModuleCode, modulecode.ToString)
            If moduleid <> Nothing Then
                SetValue(parametername, tIngrid.P_ModuleId, CLng(moduleid))
            End If
        End Sub

        ''' <summary>
        ''' This method is called during the first load of the application. It initializes user parameters such as machine name, operating system, and application version. It also checks for the existence of required folders and creates them if they do not exist.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub FirstLoad()
            With varDataProperties
                SetValue(.AllParameters, tLog.P_LogMachine, My.Computer.Name.ToString)
                SetValue(.AllParameters, tLog.P_LogOS, My.Computer.Info.OSVersion.ToString)
                SetValue(.AllParameters, tLog.P_LogAppVer, GetAppVersion)
            End With
            Call CheckRequiredFolder()
        End Sub

        ''' <summary>
        ''' This method enables double buffering for a DataGridView control to reduce flickering during rendering. It uses reflection to access the non-public "DoubleBuffered" property of the DataGridView and sets it to True. If an exception occurs, it logs the error using the Ladybug logging framework.
        ''' </summary>
        ''' <param name="gridview">The DataGridView control for which to enable double buffering.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub DblBuffer(gridview As DataGridView)
            Try
                Dim systemType As Type = gridview.GetType()
                Dim propertyInfo As System.Reflection.PropertyInfo = systemType.GetProperty("DoubleBuffered", bindingAttr:=System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
                propertyInfo.SetValue(gridview, True, Nothing)
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[DblBuffer] $\Ingrid\Apps\Core\Vb\020. Module\Globals.vb"
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
        ''' This method clears the text in the footer of the main frame of the application. It sets the text of the status label (Ts_status) in the main frame (FRMmainframe6) to an empty string, effectively removing any existing text from the footer.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub ClearMainFrameFooterText()
            UI.Canvas.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        ''' <summary>
        ''' This method sets the text in the footer of the main frame of the application. It takes a string parameter (text) and assigns it to the status label (Ts_status) in the main frame (FRMmainframe6), allowing for dynamic updates to the footer text based on application events or user actions.
        ''' </summary>
        ''' <param name="text"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub SetMainframeFooterText(text As String)
            UI.Canvas.FRMmainframe6.Ts_status.Text = text
        End Sub

        ''' <summary>
        ''' Gets the application version as a string in the format "Major.Minor.Build.Revision". This function retrieves the version information from the application's assembly and formats it into a readable string. If an error occurs while retrieving the version, it logs the error details using the Ladybug logging framework and returns a failure message.
        ''' </summary>
        ''' <returns>The application version as a string in the format "Major.Minor.Build.Revision".</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetAppVersion() As String
            Try
                Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
            Catch ex As Exception
                With proLog
                    .AppVersion = "-1.-1.-1.-1"
                    .FromSender = "[DblBuffer] $\Ingrid\Apps\Core\Vb\020. Module\Globals.vb"
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

                Return " - Failed Getting Version"
            End Try
        End Function

        ''' <summary>
        ''' Checks for the existence of required folders (Commands, Files.PDF, Files.Photo) in the current directory and creates them if they do not exist. It returns the path of the specified folder based on the provided DirName enumeration value. If no specific folder is requested, it returns an empty string.
        ''' </summary>
        ''' <param name="getdirname">The directory name to check and create if necessary.</param>
        ''' <returns>The path of the specified folder or an empty string if no specific folder is requested.</returns>
        Public Function CheckRequiredFolder(Optional getdirname As DirName = Nothing) As String
            System.IO.Directory.CreateDirectory("Commands")
            System.IO.Directory.CreateDirectory("Files.PDF")
            System.IO.Directory.CreateDirectory("Files.Photo")

            Select Case getdirname
                Case DirName.Commands
                    Return System.IO.Directory.GetCurrentDirectory & "\Commands\" 'Folder for detachable modules
                Case DirName.PDF
                    Return System.IO.Directory.GetCurrentDirectory & "\Files.PDF\"
                Case DirName.Photo
                    Return System.IO.Directory.GetCurrentDirectory & "\Files.Photo\"
                Case Else
                    Return ""
            End Select
        End Function

        ''' <summary>
        ''' Enumeration for directory names used in the application. It defines three possible values: Commands, PDF, and Photo, which correspond to specific folders created and managed by the application.
        ''' </summary>
        Public Enum DirName
            Commands
            PDF
            Photo
        End Enum

        ''' <summary>
        ''' This method is used to display a standard form with optional parameters for form image, window name, form title, form subtitle, dialog mode, and parent frame. It sets the properties of the form and handles its display based on the provided parameters.
        ''' </summary>
        ''' <param name="formname">The standard form to be displayed.</param>
        ''' <param name="formimage">The image to be displayed on the form.</param>
        ''' <param name="windowname">The name of the window.</param>
        ''' <param name="formtitle">The title of the form.</param>
        ''' <param name="formsubtitle">The subtitle of the form.</param>
        ''' <param name="isdialog">Indicates whether the form should be displayed as a dialog.</param>
        ''' <param name="parentframe">The parent form for the form to be displayed.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub Display(formname As CMCv.UI.Canvas.FRMstandard, Optional formimage As System.Drawing.Image = Nothing,
                       Optional windowname As String = "", Optional formtitle As String = "",
                       Optional formsubtitle As String = "", Optional isdialog As Boolean = False,
                       Optional parentframe As System.Windows.Forms.Form = Nothing)
            Try
                formname.Text = windowname.Trim
                formname.SLFNamaForm.Text = formtitle.Trim
                If formimage IsNot Nothing Then
                    formname.SLFLogo.Image = formimage
                End If
                formname.SLFSubNamaForm.Text = formsubtitle.Trim
                If Not isdialog Then
                    If formname.IsHandleCreated Then
                        formname.Focus()
                    Else
                        If parentframe IsNot Nothing Then
                            formname.WindowState = FormWindowState.Maximized
                            formname.Visible = False
                            formname.MdiParent = parentframe
                            formname.Visible = True
                            formname.Show()
                        Else
                            formname.Show()
                        End If
                    End If
                Else
                    formname.ShowDialog()
                    formname.Dispose()
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Core\Vb\020. Module\Globals.vb"
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
        ''' This method is used to display a standard footer form with optional parameters for form image, window name, form title, form subtitle, dialog mode, and parent frame. It sets the properties of the form and handles its display based on the provided parameters.
        ''' </summary>
        ''' <param name="formname">The form to be displayed.</param>
        ''' <param name="formimage">The image to be displayed on the form.</param>
        ''' <param name="windowname">The name of the window.</param>
        ''' <param name="formtitle">The title of the form.</param>
        ''' <param name="formsubtitle">The subtitle of the form.</param>
        ''' <param name="isdialog">Indicates whether the form should be displayed as a dialog.</param>
        ''' <param name="parentframe">The parent frame for the form, if any.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub Display(formname As CMCv.UI.Canvas.FRMstandardFooter, Optional formimage As System.Drawing.Image = Nothing, Optional windowname As String = "", Optional formtitle As String = "", Optional formsubtitle As String = "", Optional isdialog As Boolean = False, Optional parentframe As System.Windows.Forms.Form = Nothing)
            Try
                formname.Text = windowname
                formname.SLFNamaForm.Text = formtitle
                If formimage IsNot Nothing Then
                    formname.SLFLogo.Image = formimage
                End If
                formname.SLFSubNamaForm.Text = formsubtitle
                If Not (isdialog) Then
                    If (formname.IsHandleCreated) Then
                        formname.Focus()
                    Else
                        If parentframe IsNot Nothing Then
                            formname.Visible = False
                            formname.MdiParent = parentframe
                            formname.WindowState = FormWindowState.Maximized
                            formname.Show()
                            formname.Visible = True
                        Else
                            formname.Show()
                        End If
                    End If
                Else
                    formname.ShowDialog()
                    formname.Dispose()
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Core\Vb\020. Module\Globals.vb"
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
        ''' This function displays a custom message box with specified parameters such as window title, message, title type, subtitle, message icon, and button type. It creates an instance of the FRMdialogbox form, shows it as a dialog, and returns the user's response as a DialogResult. The function is marked to be supported only on Windows platforms.
        ''' </summary>
        ''' <param name="windowtitle">The title of the message box window.</param>
        ''' <param name="message">The message to be displayed in the message box.</param>
        ''' <param name="title">The title of the message box content.</param>
        ''' <param name="subtitle">The subtitle of the message box content.</param>
        ''' <param name="messageicon">The icon to be displayed in the message box.</param>
        ''' <param name="buttontype">The type of buttons to be displayed in the message box.</param>
        ''' <returns>The result of the dialog box interaction, indicating which button was pressed by the user.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function Decision(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As CMCv.UI.Canvas.FRMdialogbox.MessageIcon, buttontype As CMCv.UI.Canvas.FRMdialogbox.MessageTypes) As DialogResult
            FRMmsg = New CMCv.UI.Canvas.FRMdialogbox(windowtitle, message, title, subtitle, messageicon, buttontype)
            Dim result As System.Windows.Forms.DialogResult = FRMmsg.ShowDialog()
            FRMmsg.Dispose()
            Return result
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetCamera() As DialogResult
            FRMcam = New CMCv.UI.Canvas.FRMcamera()
            Dim result As System.Windows.Forms.DialogResult = FRMcam.ShowDialog()
            FRMcam.Dispose()
            Return result
        End Function
    End Module
End Namespace