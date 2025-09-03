Imports System.Management
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Sys.Hardware
    <SupportedOSPlatform("windows")>
    Public Class Keyboard
        Public Shared Function Installed() As Integer

            Try
                Dim _Result As Integer = 0

                Dim searcher As New ManagementObjectSearcher(
                    "root\CIMV2",
                    "SELECT * FROM Win32_Keyboard")

                For Each queryObj As ManagementObject In searcher.Get()
                    _Result += 1
                Next
            Catch err As ManagementException
                MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                V_result = "0"
            End Try
            Return CType(V_result, Integer)
        End Function
    End Class
End Namespace
