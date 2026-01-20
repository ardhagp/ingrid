Imports System.IO
Imports System.Reflection
Imports System.Runtime.Versioning

Module Globals
#Region "Activate Licenses"
    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim clsBridgekey As New Bridge.Security.Getkey
        Dim varSyncfusionkey As String = clsBridgekey.Syncfusion()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
    End Sub
#End Region

#Region "Variables"
    Public varFormimage(4) As System.Drawing.Image
    Public varWorkspace As New WorkspaceClass
    Public varFileinfo As New CMCv.OperatingSystem.File.Info
    Public FolderHandler As New CMCv.OperatingSystem.Folder
    'Public SecurityEngine As New Security.Engine
    Public varDatabaseEngine As String
    Public varDatabaseName As String
    Public V_IMG_COMPRESS As New CMCv.ImageEditor.Proccessor.Compress
    Public V_IMG_EDITOR As New CMCv.ImageEditor.Proccessor.Editor
    Public varUserAccess As New Application.Access
    'Public V_SYSAPP As New Application.Modules
    Public varLogUser As New LibSQL.SystemLog.Activity.User
    Public varLogApplication As New LibSQL.SystemLog.Activity.Application
    Public varForceRefreshMainframeData As Boolean
    'Public clsBridgelog As New Bridge.Security.WRITELOG

    Public proLog As New CMCv.Ladybug.Log.Fields
    Public varSecurityencrypt As New CMCv.Security.Encrypt

    'Public clsDBsqlite As Database.Engine.LocalDB
    'Public WithEvents TED As New frmTextEditor
    Public WithEvents frmMSG As New frmDialogBox

    Public varVersionapplication As String
    Public varVersionnetworkapplication As Version

    Public varFormProperties As New LibApp.Ingrid.Global.Properties
    Public varProperties As New LibApp.Ingrid.Global.Properties
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub FirstLoad()
        Call GETAPPVERSION()
        Call CHECKREQUIREDFOLDER()
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub DblBuffer(ByVal gridview As DataGridView)
        Try
            Dim systemType As Type = gridview.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", bindingAttr:=BindingFlags.Instance Or BindingFlags.NonPublic)
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

#Region "Get App Version"

    ''' <summary>
    ''' Return Application Version
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
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
#End Region

#Region "Check Modules Folder"

    ''' <summary>
    ''' Check and Create Required Folder
    ''' </summary>
    Public Function CheckRequiredFolder(ByVal Optional getdirname As DirName = Nothing) As String
        If Not Directory.Exists("Commands") Then
            Directory.CreateDirectory("Commands")
        End If
        If Not Directory.Exists("Files.PDF") Then
            Directory.CreateDirectory("Files.PDF")
        End If
        If Not Directory.Exists("Files.Photo") Then
            Directory.CreateDirectory("Files.Photo")
        End If

        Select Case getdirname
            Case DirName.Commands
                Return Directory.GetCurrentDirectory & "\Commands\" 'Folder for detachable modules
            Case DirName.PDF
                Return Directory.GetCurrentDirectory & "\Files.PDF\"
            Case DirName.PDF
                Return Directory.GetCurrentDirectory & "\Files.Photo\"
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
    <SupportedOSPlatform("windows")>
    Public Sub Display(ByVal formName As CMCv.frmStandard, Optional formimage As System.Drawing.Image = Nothing,
                       Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False, Optional parentframe As Windows.Forms.Form = Nothing)
        Try
            formName.SLFNamaForm.Text = formtitle
            'If formimage IsNot Nothing Then
            '    formName.SLFLogo.Image = formimage
            'End If
            'formName.SLFSubNamaForm.Text = formsubtitle
            'If Not (isdialog) Then
            '    If (formName.IsHandleCreated) Then
            '        formName.Focus()
            '    Else
            '        If parentframe IsNot Nothing Then
            '            formName.Visible = False
            '            formName.MdiParent = parentframe
            '            'formName.WindowState = FormWindowState.Maximized
            '            formName.Show()
            '            formName.Visible = True
            '        Else
            '            formName.Show()
            '        End If
            '    End If
            'Else
            '    formName.ShowDialog()
            '    formName.Dispose()
            'End If


        Catch ex As Exception
            With proLog
                .AppVersion = GETAPPVERSION()
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
    <SupportedOSPlatform("windows")>
    Public Sub Display(ByVal formname As CMCv.Std_Fo, Optional ByVal formimage As System.Drawing.Image = Nothing, Optional ByVal formtitle As String = "", Optional ByVal formsubtitle As String = "", Optional ByVal isdialog As Boolean = False, Optional ByVal parentframe As Windows.Forms.Form = Nothing)
        Try
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
                .AppVersion = GETAPPVERSION()
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
    Public Function Decision(ByVal message As String, ByVal title As String, ByVal messageicon As CMCv.frmDialogBox.MessageIcon, ByVal buttontype As CMCv.frmDialogBox.MessageTypes) As DialogResult
        frmMSG = New CMCv.frmDialogBox(message, title, messageicon, buttontype)
        Return frmMSG.ShowDialog()
        frmMSG.Dispose()
    End Function
#End Region
End Module