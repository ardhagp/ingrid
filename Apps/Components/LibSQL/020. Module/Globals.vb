Module Globals
    Public varDatabaseEngineMssql2008 As New CMCv.Database.Engine.Mssql2008
    Public varDatabaseEngineMysql As New CMCv.Database.Engine.Mysql
    Public varDatabaseEngineLocaldb As New CMCv.Database.Engine.LocalDB
    Public varDatabaseEngineSqlite As New CMCv.Database.Engine.SQLiteV3
    Public databaseproperties(1) As LibApp.Ingrid.Global.Properties

    Public varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
    Public V_DBR_MYSQL(1) As CMCv.Database.Adapter.MySQL.Display.Request
    Public _DBP_MSSQL2008 As New CMCv.Database.Adapter.MSSQL2008.Execute

    Public V_SECEncrypt As New CMCv.Security.Encrypt

    Public V_SEC_AES As Security.Cryptography.Aes
    Public V_SEC_MD5 As Security.Cryptography.MD5
    Public V_SEC_CRC32 As New System.IO.Hashing.Crc32

    Public V_Major As Integer = My.Application.Info.Version.Major
    Public V_Minor As Integer = My.Application.Info.Version.Minor
    Public V_Build As Integer = My.Application.Info.Version.Build
    Public V_Revision As Integer = My.Application.Info.Version.Revision
    Public _APPVer As String = V_Major & "." & V_Minor & "." & V_Build & "." & V_Revision

    Public WithEvents MSG As New CMCv.frmDialogBox

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
    Public Function Decision(message As String, title As String, messageicon As CMCv.frmDialogBox.MessageIcon, ByVal buttontype As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.frmDialogBox(message, title, messageicon, buttontype)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region
End Module
