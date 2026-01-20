Imports System.Runtime.Versioning

Module Globals
#Region "Activate Licenses"
    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim varSyncfusionkey As String = Bridge.Security.Getkey.Syncfusion()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
    End Sub
#End Region

    Public proLog As New CMCv.Ladybug.Log.Fields
End Module
