Imports System.Runtime.Versioning

Module Globals
#Region "Font Globals"
    <SupportedOSPlatform("windows")>
    Public globalFontBtn As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
    <SupportedOSPlatform("windows")>
    Public globalFontTxt As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
    <SupportedOSPlatform("windows")>
    Public globalFontLbl As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
    <SupportedOSPlatform("windows")>
    Public globalFontDgn As New System.Drawing.Font("Verdana", 8, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
#End Region

#Region "Security Globals"
    <SupportedOSPlatform("windows")>
    Public V_BRIDGE_KEY As New Bridge.Security.GETKEY

    <SupportedOSPlatform("windows")>
    Public V_BRIDGE_LOG As New Bridge.Security.WRITELOG

    <SupportedOSPlatform("windows")>
    Public V_SALT As String = V_BRIDGE_KEY.SALT()

    <SupportedOSPlatform("windows")>
    Public V_SyncfusionKey As String = V_BRIDGE_KEY.SYNCFUSION

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public V_SECEncrypt As New Security.Encrypt

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public V_SECDecrypt As New Security.Decrypt

    'new security
    Public V_SEC_AES As System.Security.Cryptography.Aes
    Public V_SEC_MD5 As System.Security.Cryptography.MD5
    Public V_SEC_CRC32 As New System.IO.Hashing.Crc32

#End Region

#Region "Class Globals"
    Public CBS As New ControlCodeBase
    Public V_CFILEInfo As New OperatingSystem.File.Info

#End Region

#Region "Variabel Global"
    Public V_RandomColor As New Random
    Public V_AutoTrim As Boolean
    Public V_HarusDiisi As Boolean

    'Public SEC As New Security.Engine

    Public ERC As New frmErrorReporting
    Public ERL As New Database.Engine.LocalDB
    Public ErrorCatcher As Catcher.Error.Fields

    Public V_APPVer As String
#End Region

    Public Function GETAPPVERSION() As String
        Dim V_Major, V_Minor, V_Build, V_Revision As Integer
        V_Major = My.Application.Info.Version.Major
        V_Minor = My.Application.Info.Version.Minor
        V_Build = My.Application.Info.Version.Build
        V_Revision = My.Application.Info.Version.Revision
        V_APPVer = V_Major & "." & V_Minor & "." & V_Build & "." & V_Revision
        Return V_APPVer
    End Function

    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        'License for Syncfusion

        'nuget version : 21.2.9
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(V_SyncfusionKey)
    End Sub

    'Public Function CREATESECURITY(ByVal IsEncrypt As Boolean, ByVal Message As String)
    '    Try
    '        SEC = New Security.Engine
    '        Dim SECAlgorithm As Security.Engine.Algorithm = Security.Engine.Algorithm.Rijndael
    '        Security.Engine.EncryptionAlgorithm = SECAlgorithm
    '        Security.Engine.Key = ""

    '        If (IsEncrypt) Then
    '            If Security.Engine.EncryptString(Message) Then
    '                Message = Security.Engine.Content
    '            Else
    '                Message = Security.Engine.CryptoException.Message
    '            End If
    '        Else
    '            Security.Engine.Content = Message
    '            If Security.Engine.DecryptString Then
    '                Message = Security.Engine.Content
    '            Else
    '                Message = Security.Engine.CryptoException.Message
    '            End If
    '        End If

    '        Return Message
    '    Catch ex As Exception
    '        Call PUSHERRORDATA("[CREATESECURITY] $\Ingrid\Apps\Components\CMC\2090 - Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
    '        PUSHERRORDATASHOW()
    '        Return Nothing
    '    End Try
    'End Function

    Public Sub GETMACHINENAME()
        'GET Machinge Name
    End Sub

    Public Sub PUSHERRORDATA(ByVal FromSender As String, ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With ErrorCatcher
            .FromSender = FromSender
            .Type = ErrorType
            .Message = ErrorMessage
            .Number = ErrorNumber
            .InternalStackTrace = InternalStackTrace
            .AppVersion = AppVersion
            .EnableErrorReporting = EnableErrorReporting
            .SaveError = SaveError
            .ResumeNext = ResumeNext
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub PUSHERRORDATASHOW()
        ERC = New frmErrorReporting(ErrorCatcher, )
        ERC.SLFNamaForm.Text = "Lady Bug (Error Catcher)"
        ERC.SLFSubNamaForm.Text = "Please check detail below and report to system administrator."
        ERC.ShowDialog()
        If Not (ERC.ResumeNext) Then
            Process.GetCurrentProcess.Kill()
        End If
        ERC.Dispose()
    End Sub
End Module
