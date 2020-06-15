Module Globals
    Public _DBE_MSSQL2008 As New CMCv.Database.Engine.MSSQL2008
    Public _DBE_LocalDB As New CMCv.Database.Engine.LocalDB
    Public _DB_Properties(1) As CMCv.Database.Properties.Fields

    Public _DBR_MSSQL2008(1) As CMCv.Database.Adapter.MSSQL2008.Display.Request
    Public _DBP_MSSQL2008 As New CMCv.Database.Adapter.MSSQL2008.Execute
    Public _SECEncrypt As New CMCv.Security.Encrypt
    Public _APPVer As String = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build

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
