Imports System.Runtime.Versioning
Imports CMCv

Module Globals
#Region "Activate Licenses"
    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim varSyncfusionkey As String = Bridge.Security.Getkey.Syncfusion()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
    End Sub
#End Region

    Public proLog As New CMCv.Ladybug.Log.Fields
    Private varVersionapplication As String

    <SupportedOSPlatform("windows")>
    Public Sub Display(formname As CMCv.ui.canvas.FRMstandardFooter, Optional formimage As System.Drawing.Image = Nothing,
                       Optional windowtitle As String = "", Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False,
                       Optional parentframe As system.Windows.Forms.Form = Nothing)
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
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub Display(formname As CMCv.ui.canvas.FRMstandardFindFooter, Optional formimage As System.Drawing.Image = Nothing,
                       Optional windowtitle As String = "", Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False,
                       Optional parentframe As system.Windows.Forms.Form = Nothing)
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
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

    <SupportedOSPlatform("windows")>
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
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing

            varVersionapplication = " - Failed Getting Version"
            Return varVersionapplication
        End Try
    End Function
End Module
