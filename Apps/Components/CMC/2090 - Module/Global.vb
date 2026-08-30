Namespace Component.Properties
    Module [Global]
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public globalFontBtn As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public globalFontTxt As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public globalFontTxtItalic As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point)
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public globalFontLbl As New System.Drawing.Font("Segoe UI", 12, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public globalFontDgn As New System.Drawing.Font("Verdana", 8, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public varSalt As String = Bridge.Getkey.Salt()

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public varSyncfusionKey As String = Bridge.Getkey.Syncfusion

        Public varRandomColor As New Random

        Public proLog As Ladybug.Log.Fields

        Public varBetterstack As New LibAPI.Api.Betterstack.Heartbeats

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetAppVersion() As String
            Dim varMajor, varMinor, varBuild, varRevision As Integer
            varMajor = My.Application.Info.Version.Major
            varMinor = My.Application.Info.Version.Minor
            varBuild = My.Application.Info.Version.Build
            varRevision = My.Application.Info.Version.Revision
            Return varMajor & "." & varMinor & "." & varBuild & "." & varRevision
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
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