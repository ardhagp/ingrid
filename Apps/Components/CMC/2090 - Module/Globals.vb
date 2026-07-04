Imports System.Runtime.Versioning

Namespace UI
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
        Public V_BRIDGE_KEY As Bridge.Getkey

        <SupportedOSPlatform("windows")>
        Public V_BRIDGE_LOG As Bridge.Writelog

        <SupportedOSPlatform("windows")>
        Public varSalt As String = Bridge.Getkey.Salt()

        <SupportedOSPlatform("windows")>
        Public varSyncfusionKey As String = Bridge.Getkey.Syncfusion

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
        Public varCodebase As New UI.Control.ControlCodeBase
        Public V_CFILEInfo As New OperatingSystem.File.Info
#End Region

#Region "Variabel Global"
        Public varRandomColor As New Random

        'Public SEC As New Security.Engine

        Public ERC As New CMCv.UI.Canvas.FRMerrorreporting
        Public proLog As Ladybug.Log.Fields

        Public varApplicationVersion As String
        Public varBetterstack As New LibAPI.Api.Betterstack.Heartbeats
#End Region

        <SupportedOSPlatform("windows")>
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
            Try
                ' License for Syncfusion
                ' Nuget version : 33.2.15
                Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionKey)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

    End Module
End Namespace