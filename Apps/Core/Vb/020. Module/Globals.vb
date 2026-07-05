Namespace UI
    Module Globals
#Region "Activate Licenses"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub ActivateLicenses()
            Dim varSyncfusionkey As String = Bridge.Getkey.Syncfusion()

            'License for Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
        End Sub
#End Region

#Region "Declaration"
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
        Public varSecurityencrypt As New CMCv.Security.Encrypt

        Public WithEvents FRMmsg As New CMCv.UI.Canvas.FRMdialogbox

        Public varVersionapplication As String
        Public varVersionnetworkapplication As Version

        Public varDataProperties As New LibApp.Ingrid.Global.Properties

        'Dataset Tables
        Public varDatasetIngrid As New Ingrid.UI.Dataset.ADSglobal
        Public Const dtSettings As String = "SYSS_Editor"
        Public Const dtModule As String = "SysModule"
        Public Const dtUserData As String = "UserData"

        'Database Tables
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

#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub FirstLoad()
            With varDataProperties.UserParameters
                .Remove(tLog.P_LogMachine)
                .Add(tLog.P_LogMachine, My.Computer.Name.ToString)
                .Remove(tLog.P_LogOS)
                .Add(tLog.P_LogOS, My.Computer.Info.OSFullName.ToString)
                .Remove(tLog.P_LogAppVer)
                .Add(tLog.P_LogAppVer, GetAppVersion)
            End With

            Call CheckRequiredFolder()
        End Sub

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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub ClearMainFrameFooterText()
            UI.Canvas.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub SetMainframeFooterText(text As String)
            UI.Canvas.FRMmainframe6.Ts_status.Text = text
        End Sub

#Region "Get App Version"

        ''' <summary>
        ''' Return Application Version
        ''' </summary>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
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
#End Region

#Region "Check Modules Folder"

        ''' <summary>
        ''' Check and Create Required Folder
        ''' </summary>
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

        Public Enum DirName
            Commands
            PDF
            Photo
        End Enum
#End Region

#Region "Display Form"

        ''' <summary>
        ''' Untuk menampilkan form Standard
        ''' </summary>
        ''' <param name="formName">Nama Form</param>
        ''' <param name="FormImage">Form Icon</param>
        ''' <param name="FormTitle">Form Title</param>
        ''' <param name="FormSubTitle">Form Subtitle</param>
        ''' <param name="IsDialog">True/False</param>
        ''' <param name="ParentFrame">MDI</param>
        ''' <remarks></remarks>
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
        ''' Untuk menampilkan form Standard + Footer Container
        ''' </summary>
        ''' <param name="FormName">Nama Form</param>
        ''' <param name="FormImage">Form Icon</param>
        ''' <param name="FormTitle">Form Title</param>
        ''' <param name="FormSubTitle">Form Subtitle</param>
        ''' <param name="IsDialog">True/False</param>
        ''' <param name="ParentFrame">MDI</param>
        ''' <remarks></remarks>
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
#End Region

#Region "Custom Message Box"
        ''' <summary>
        ''' CMCv Message Box
        ''' </summary>
        ''' <param name="Message">Masukkan pesan anda di sini</param>
        ''' <param name="Title">Judul form</param>
        ''' <param name="MessageIcon">Jenis Icon</param>
        ''' <param name="ButtonType">Jenis Tombol</param>
        ''' <returns>DialogResult</returns>
        ''' <remarks></remarks>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function Decision(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As CMCv.UI.Canvas.FRMdialogbox.MessageIcon, buttontype As CMCv.UI.Canvas.FRMdialogbox.MessageTypes) As DialogResult
            FRMmsg = New CMCv.UI.Canvas.FRMdialogbox(windowtitle, message, title, subtitle, messageicon, buttontype)
            Dim result As System.Windows.Forms.DialogResult = FRMmsg.ShowDialog()
            FRMmsg.Dispose()
            Return result
        End Function
#End Region
    End Module
End Namespace