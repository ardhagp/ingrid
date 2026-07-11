Module [Global]
#Region "Activate Licenses"
    ''' <summary>
    ''' This method is used to activate the licenses for Syncfusion components. It retrieves the license key from the Bridge.Getkey.Syncfusion() method and registers it using the SyncfusionLicenseProvider.RegisterLicense method. This ensures that the application can use Syncfusion components without any licensing issues.
    ''' </summary>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim varSyncfusionkey As String = Bridge.Getkey.Syncfusion()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
    End Sub
#End Region

    Public proLog As New CMCv.Ladybug.Log.Fields
    Private varVersionapplication As String
    Public WithEvents FRMmsg As New CMCv.UI.Canvas.FRMdialogbox

    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public varCloudstorageUrl As String = Bridge.Getkey.CloudStorageUrl()

    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Sub Display(formname As CMCv.UI.Canvas.FRMstandardFooter, Optional formimage As System.Drawing.Image = Nothing,
                       Optional windowtitle As String = "", Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False,
                       Optional parentframe As System.Windows.Forms.Form = Nothing)
        Try
            formname.Text = windowtitle
            formname.SLFNamaForm.Text = formtitle

            If formimage IsNot Nothing Then
                formname.SLFLogo.Image = formimage
            End If

            formname.SLFSubNamaForm.Text = formsubtitle

            If isdialog Then
                formname.ShowDialog()
                formname.Dispose()
                Return
            End If

            If formname.IsHandleCreated Then
                formname.Focus()
                Return
            End If

            If parentframe IsNot Nothing Then
                formname.Visible = False
                formname.MdiParent = parentframe
                formname.WindowState = FormWindowState.Maximized
                formname.Show()
                formname.Visible = True
            Else
                formname.Show()
            End If
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[Display] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New CMCv.Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' This method is used to display a form of type CMCv.ui.canvas.FRMstandardFindFooter. It sets the window title, form title, form subtitle, and optionally an image for the form. The method can display the form as a dialog or as a regular window, and it can also set the parent frame if provided. If the form is already created, it will focus on it instead of creating a new instance. Any exceptions that occur during this process are logged using the proLog object.
    ''' </summary>
    ''' <param name="formname"></param>
    ''' <param name="formimage"></param>
    ''' <param name="windowtitle"></param>
    ''' <param name="formtitle"></param>
    ''' <param name="formsubtitle"></param>
    ''' <param name="isdialog"></param>
    ''' <param name="parentframe"></param>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Sub Display(formname As CMCv.UI.Canvas.FRMstandardFindFooter, Optional formimage As System.Drawing.Image = Nothing,
                       Optional windowtitle As String = "", Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False,
                       Optional parentframe As System.Windows.Forms.Form = Nothing)
        Try
            formname.Text = windowtitle
            formname.SLFNamaForm.Text = formtitle

            If formimage IsNot Nothing Then
                formname.SLFLogo.Image = formimage
            End If

            formname.SLFSubNamaForm.Text = formsubtitle

            If isdialog Then
                formname.ShowDialog()
                formname.Dispose()
                Return
            End If

            If formname.IsHandleCreated Then
                formname.Focus()
                Return
            End If

            If parentframe IsNot Nothing Then
                formname.Visible = False
                formname.MdiParent = parentframe
                formname.WindowState = FormWindowState.Maximized
                formname.Show()
                formname.Visible = True
            Else
                formname.Show()
            End If
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[Display] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New CMCv.Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' This function retrieves the version of the application by accessing the My.Application.Info.Version property. It extracts the major, minor, build, and revision numbers and concatenates them into a string format "major.minor.build.revision". If an exception occurs while retrieving the version information, it logs the error details using the proLog object and returns a failure message indicating that the version could not be obtained.
    ''' </summary>
    ''' <returns></returns>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Function GetAppVersion() As String
        Try
            Dim varMajor, varMinor, varBuild, varRevision As Integer

            varMajor = My.Application.Info.Version.Major
            varMinor = My.Application.Info.Version.Minor
            varBuild = My.Application.Info.Version.Build
            varRevision = My.Application.Info.Version.Revision

            varVersionapplication = varMajor & "." & varMinor & "." & varBuild & "." & varRevision
            Return varVersionapplication
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
                .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New CMCv.Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing

            varVersionapplication = " - Failed Getting Version"
            Return varVersionapplication
        End Try
    End Function

#Region "Custom Message Box"
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

#End Region
End Module
