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
    Public V_BRIDGE_KEY As Bridge.Security.Getkey

    <SupportedOSPlatform("windows")>
    Public V_BRIDGE_LOG As Bridge.Security.Writelog

    <SupportedOSPlatform("windows")>
    Public varSalt As String = Bridge.Security.Getkey.Salt()

    <SupportedOSPlatform("windows")>
    Public V_SyncfusionKey As String = Bridge.Security.Getkey.Syncfusion

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    Public V_SECEncrypt As New Security.Encrypt

    ''' <summary>
    ''' This security will be retired
    ''' </summary>
    'Public V_SECDecrypt As New Security.Decrypt

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
    Public varRandomColor As New Random
    Public V_AutoTrim As Boolean
    Public V_HarusDiisi As Boolean

    'Public SEC As New Security.Engine

    Public ERC As New frmErrorReporting
    Public ERL As New Database.Engine.LocalDB
    Public proLog As Ladybug.Log.Fields

    Public varApplicationVersion As String
#End Region

    Public Function GetAppVersion() As String
        Dim varMajor, varMinor, varBuild, varRevision As Integer
        varMajor = My.Application.Info.Version.Major
        varMinor = My.Application.Info.Version.Minor
        varBuild = My.Application.Info.Version.Build
        varRevision = My.Application.Info.Version.Revision
        varApplicationVersion = varMajor & "." & varMinor & "." & varBuild & "." & varRevision
        Return varApplicationVersion
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
    '        Call SUBlogdatapush("[CREATESECURITY] $\Ingrid\Apps\Components\CMC\2090 - Module\Globals.vb", Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
    '        SUBlogdatashow()
    '        Return Nothing
    '    End Try
    'End Function

    Public Sub GETMACHINENAME()
        'GET Machinge Name
    End Sub

End Module
