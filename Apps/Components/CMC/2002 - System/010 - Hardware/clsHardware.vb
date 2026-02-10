Imports System.Management
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Sys.Hardware
    <SupportedOSPlatform("windows")>
    Public Class Keyboard
        Public Shared Function Installed() As Integer

            Try
                Dim varResult As Integer = 0

                Dim searcher As New ManagementObjectSearcher(
                    "root\CIMV2",
                    "SELECT * FROM Win32_Keyboard")

                For Each queryObj As ManagementObject In searcher.Get()
                    varResult += 1
                Next
            Catch err As ManagementException
                MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                varResult = "0"
            End Try
            Return CType(varResult, Integer)
        End Function
    End Class
End Namespace
