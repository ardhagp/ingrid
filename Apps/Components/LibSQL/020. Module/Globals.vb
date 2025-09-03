Module Globals
    Public V_DBE_MSSQL2008 As New CMCv.Database.Engine.MSSQL2008
    Public V_DBE_MYSQL As New CMCv.Database.Engine.MySQL
    Public V_DBE_LocalDB As New CMCv.Database.Engine.LocalDB
    Public V_DBE_SQLite As New CMCv.Database.Engine.SQLiteV3
    Public V_DB_Properties(1) As CMCv.Database.Properties.Fields

    Public V_DBR_MSSQL2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
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
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region
End Module
