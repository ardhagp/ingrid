Imports System.Windows.Forms
Imports System.Drawing

Public Enum DeviceFormFactor
    Phone
    Tablet
    Desktop
    Unknown
End Enum

''' <summary>
''' This class provides methods to detect the form factor of the device based on the screen size and DPI. It calculates the diagonal size of the primary screen in inches and classifies it as Phone, Tablet, or Desktop.
''' </summary>
Public Class Device
    Private Shared varBounds As Rectangle
    Private Shared varWidthPx As Integer
    Private Shared varHeightPx As Integer

    Private Shared varDpiX As Integer
    Private Shared varDpiY As Integer

    Private Shared varWidthInches As Double
    Private Shared varHeightInches As Double
    Private Shared varDiagonalInches As Double

    ''' <summary>
    ''' Detects the form factor of the device based on the screen size and DPI. It calculates the diagonal size of the primary screen in inches and classifies it as Phone, Tablet, or Desktop.
    ''' </summary>
    ''' <returns></returns>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Shared Function DetectFormFactor() As DeviceFormFactor
        varBounds = Screen.PrimaryScreen.Bounds
        varWidthPx = varBounds.Width
        varHeightPx = varBounds.Height

        ' Get the DPI of the primary screen
        Using g As Graphics = Graphics.FromHwnd(IntPtr.Zero)
            varDpiX = CInt(g.DpiX)
            varDpiY = CInt(g.DpiY)
        End Using

        varWidthInches = varWidthPx / varDpiX
        varHeightInches = varHeightPx / varDpiY

        ' Calculate the diagonal size in inches using the Pythagorean theorem
        varDiagonalInches = Math.Sqrt((varWidthInches ^ 2) + (varHeightInches ^ 2))

        ' Classify the device based on the diagonal size
        Return ClassifyByDiagonal(varDiagonalInches)
    End Function

    Public Shared Function ClassifyByDiagonal(diagonal As Double) As DeviceFormFactor
        Select Case diagonal
            Case Is <= 7.0
                Return DeviceFormFactor.Phone
            Case Is <= 13.0
                Return DeviceFormFactor.Tablet
            Case Is > 13.0
                Return DeviceFormFactor.Desktop
            Case Else
                Return DeviceFormFactor.Unknown
        End Select
    End Function

    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Shared Function GetDiagnostics() As String
        varBounds = Screen.PrimaryScreen.Bounds

        Using g As Graphics = Graphics.FromHwnd(IntPtr.Zero)
            varDpiX = CInt(g.DpiX)
            varDpiY = CInt(g.DpiY)
        End Using

        varWidthInches = varBounds.Width / varDpiX
        varHeightInches = varBounds.Height / varDpiY
        varDiagonalInches = Math.Sqrt((varWidthInches ^ 2) + (varHeightInches ^ 2))

        Return $"Resolution: {varBounds.Width}x{varBounds.Height}, DPI: {varDpiX}x{varDpiY}, Diagonal: {varDiagonalInches:F2} inches"
    End Function
End Class
