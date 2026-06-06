Imports System.Runtime.Versioning

Module Globals
    Public varDatabaseEngineMssql2008 As New CMCv.Database.Engine.Mssql2008
    Public varDatabaseEngineMysql As New CMCv.Database.Engine.Mysql
    Public varDatabaseEngineLocaldb As New CMCv.Database.Engine.LocalDB
    Public varDatabaseEngineSqlite As New CMCv.Database.Engine.SQLiteV3
    Public databaseproperties(1) As LibApp.Ingrid.Global.Properties

    Public varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
    Public varDatabaseRequestMysql(1) As CMCv.Database.Adapter.MySQL.Display.Request
    Public varDatabaseDisplayMssql2008 As New CMCv.Database.Adapter.MSSQL2008.Execute
    Public varDatabaseDisplayMysql As New CMCv.Database.Adapter.MySQL.Execute

    Public varSecurityEncrypt As New CMCv.Security.Encrypt

    Public varSecurityAes As Security.Cryptography.Aes
    Public varSecurityMd5 As Security.Cryptography.MD5
    Public varSecurityCrc32 As New System.IO.Hashing.Crc32

    <SupportedOSPlatform("windows")>
    Public varMajor As Integer = My.Application.Info.Version.Major
    <SupportedOSPlatform("windows")>
    Public varMinor As Integer = My.Application.Info.Version.Minor
    <SupportedOSPlatform("windows")>
    Public varBuild As Integer = My.Application.Info.Version.Build
    <SupportedOSPlatform("windows")>
    Public varRevision As Integer = My.Application.Info.Version.Revision
    <SupportedOSPlatform("windows")>
    Public varAppVer As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents MSG As New CMCv.FRMdialogbox

    Public tPosition As New LibApp.Table.Man.Position
    Public tEmployee As New LibApp.Table.Man.Employee
    Public tUser As New LibApp.Table.Sys.User
    Public tModule As New LibApp.Table.Sys.Module
    Public tUserAccess As New LibApp.Table.Sys.UserAccess
    Public tLog As New LibApp.Table.Sys.Log
    Public tSettings As New LibApp.Table.Sys.Settings
    Public tTemplate As New LibApp.Table.Cus.Template


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
    <SupportedOSPlatform("windows")>
    Public Function Decision(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As CMCv.FRMdialogbox.MessageIcon, ByVal buttontype As CMCv.FRMdialogbox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.FRMdialogbox(windowtitle, message, title, subtitle, messageicon, buttontype)
        Dim result As System.Windows.Forms.DialogResult = MSG.ShowDialog()
        MSG.Dispose()
        Return result
    End Function
#End Region
End Module
