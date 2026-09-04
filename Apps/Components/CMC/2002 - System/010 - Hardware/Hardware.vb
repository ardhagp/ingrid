Namespace Hardware
    ''' <summary>
    ''' This class provides methods to check the presence of a keyboard on the system using Windows Management Instrumentation (WMI).
    ''' </summary>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Class Keyboard
        ''' <summary>
        ''' Checks if a keyboard is installed on the system by querying the Win32_Keyboard WMI class.
        ''' </summary>
        ''' <returns>The number of keyboards installed on the system.</returns>
        Public Shared Function Installed() As Integer

            Try
                Dim varResult As Integer = 0

                Dim searcher As New System.Management.ManagementObjectSearcher(
                    "root\CIMV2",
                    "SELECT * FROM Win32_Keyboard")

                For Each queryObj As System.Management.ManagementObject In searcher.Get()
                    varResult += 1
                Next
            Catch err As System.Management.ManagementException
                System.Windows.Forms.MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
                varResult = "0"
            End Try
            Return CType(varResult, Integer)
        End Function
    End Class
End Namespace
