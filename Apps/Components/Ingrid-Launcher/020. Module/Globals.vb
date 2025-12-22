Imports System.Runtime.Versioning


Module Globals
#Region "Activate Licenses"
        <SupportedOSPlatform("windows")>
        Public Sub ActivateLicenses()
            Dim clsBridgekey As New Bridge.Security.Getkey
            Dim varSyncfusionkey As String = clsBridgekey.Syncfusion()

            'License for Syncfusion
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
        End Sub
#End Region
    End Module
