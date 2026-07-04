Module Globals
    Public varDatabaseEngineMssql2008 As New CMCv.Database.Engine.Mssql2008
    Public varDatabaseEngineMysql As New CMCv.Database.Engine.Mysql
    Public varDatabaseEngineSqlite As New CMCv.Database.Engine.SQLiteV3
    Public databaseproperties(1) As LibApp.Ingrid.Global.Properties

    Public varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MsSql.Display.Request
    Public varDatabaseRequestMysql(1) As CMCv.Database.Adapter.Mysql.Display.Request
    Public varDatabaseDisplayMssql2008 As New CMCv.Database.Adapter.MsSql.Execute
    Public varDatabaseDisplayMysql As New CMCv.Database.Adapter.Mysql.Execute

    Public proLog As New CMCv.Ladybug.Log.Fields
    Public varSecurityEncrypt As New CMCv.Security.Encrypt

    Public varSecurityAes As System.Security.Cryptography.Aes
    Public varSecurityMd5 As System.Security.Cryptography.MD5
    Public varSecurityCrc32 As New System.IO.Hashing.Crc32

    '<SupportedOSPlatform("windows")>
    'Public varMajor As Integer = My.Application.Info.Version.Major
    '<SupportedOSPlatform("windows")>
    'Public varMinor As Integer = My.Application.Info.Version.Minor
    '<SupportedOSPlatform("windows")>
    'Public varBuild As Integer = My.Application.Info.Version.Build
    '<SupportedOSPlatform("windows")>
    'Public varRevision As Integer = My.Application.Info.Version.Revision
    '<SupportedOSPlatform("windows")>
    'Public varAppVer As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents MSG As New CMCv.UI.Canvas.FRMdialogbox

    Public tPosition As New LibApp.Table.Man.Position
    Public tEmployee As New LibApp.Table.Man.Employee
    Public tUser As New LibApp.Table.Sys.User
    Public tModule As New LibApp.Table.Sys.Module
    Public tUserAccess As New LibApp.Table.Sys.UserAccess
    Public tLog As New LibApp.Table.Sys.Log
    Public tSettings As New LibApp.Table.Sys.Settings
    Public tClient As New LibApp.Table.Sys.Client
    Public tTemplate As New LibApp.Table.Cus.Template
    Public tAttachment As New LibApp.Table.File.Attachment


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
    Public Function Decision(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As CMCv.UI.Canvas.FRMdialogbox.MessageIcon, ByVal buttontype As CMCv.UI.Canvas.FRMdialogbox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.UI.Canvas.FRMdialogbox(windowtitle, message, title, subtitle, messageicon, buttontype)
        Dim result As System.Windows.Forms.DialogResult = MSG.ShowDialog()
        MSG.Dispose()
        Return result
    End Function
#End Region

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

            Return " - Failed Getting Version"
        End Try
    End Function

End Module
