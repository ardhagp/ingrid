Module Globals
    Public varDatabaseEngineMssql2008 As New CMCv.Database.Engine.Mssql2008
    Public varDatabaseEngineMysql As New CMCv.Database.Engine.Mysql
    Public varDatabaseEngineLocaldb As New CMCv.Database.Engine.LocalDB
    Public varDatabaseEngineSqlite As New CMCv.Database.Engine.SQLiteV3
    Public databaseproperties(1) As LibApp.Ingrid.Global.Properties

    Public varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
    Public varDatabaseRequestMysql(1) As CMCv.Database.Adapter.MySQL.Display.Request
    Public varDatabaseDisplayMssql2008 As New CMCv.Database.Adapter.MSSQL2008.Execute

    Public varSecurityEncrypt As New CMCv.Security.Encrypt

    Public varSecurityAes As Security.Cryptography.Aes
    Public varSecurityMd5 As Security.Cryptography.MD5
    Public varSecurityCrc32 As New System.IO.Hashing.Crc32

    Public varMajor As Integer = My.Application.Info.Version.Major
    Public varMinor As Integer = My.Application.Info.Version.Minor
    Public varBuild As Integer = My.Application.Info.Version.Build
    Public varRevision As Integer = My.Application.Info.Version.Revision
    Public varAppVer As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents MSG As New CMCv.FRMdialogbox

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
    Public Function Decision(windowtitle As String, message As String, title As String, subtitle As String, messageicon As CMCv.frmDialogBox.MessageIcon, ByVal buttontype As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.frmDialogBox(windowtitle, message, title, subtitle, messageicon, buttontype)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region
End Module
