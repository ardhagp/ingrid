Namespace OperatingSystem.File
    ''' <summary>
    ''' This class provides methods to retrieve information about files, such as checking if a file exists and calculating the size of a file.
    ''' </summary>
    Public Class Info
        ''' <summary>
        ''' This function checks if a file exists at the specified file path.
        ''' </summary>
        ''' <param name="filepath"></param>
        ''' <returns></returns>
        Public Shared Function IsExists(filepath As String) As Boolean
            Dim varFileIsExists As New IO.FileInfo(filepath)
            Return varFileIsExists.Exists
        End Function

        ''' <summary>
        ''' This function retrieves the size of a file at the specified file path in bytes.
        ''' </summary>
        ''' <param name="filepath"></param>
        ''' <returns></returns>
        Public Shared Function Size(filepath As String) As Double
            Dim varFileSize As New IO.FileInfo(filepath)
            Return varFileSize.Length
        End Function
    End Class

    ''' <summary>
    ''' This class provides methods to handle file uploads, including checking if the uploaded file size is within the allowed limit.
    ''' </summary>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Class Upload
        ''' <summary>
        ''' This function checks if the size of a file at the specified file path is within the allowed maximum size. It can also display a native dialog box if the file size exceeds the limit.
        ''' </summary>
        ''' <param name="filePath">The path of the file to check.</param>
        ''' <param name="maxsize">The maximum allowed size in megabytes.</param>
        ''' <param name="shownativedialog">Indicates whether to show a native dialog if the file size exceeds the limit.</param>
        ''' <returns>True if the file size is within the allowed limit; otherwise, false.</returns>
        Public Shared Function IsAllowedSize(filePath As String, maxsize As Double, Optional shownativedialog As Boolean = False) As Boolean
            Dim varIsAllowed As Boolean
            Dim size As String() = {"B", "KB", "MB", "GB", "TB"}
            Dim varPhotoLength As Double = Info.Size(filePath)
            Dim varOriginalPhotoLength As Double = varPhotoLength
            Dim varOrder As Integer = 0
            Dim varMaximumOrder As Integer = 0

            If maxsize = 0 Then
                varIsAllowed = True
                Return varIsAllowed
            End If

            While (varPhotoLength >= 1024 AndAlso CType(size.Length - 1, Boolean))
                varOrder += 1
                varPhotoLength /= 1024
            End While

            Dim varMaximumPhotoLength As Double = ((1024 ^ 2) * maxsize) '1 indicate 1000KB or 1MB
            Dim varMaximumPhotoLengthDisplay As Double = varMaximumPhotoLength

            While (varMaximumPhotoLengthDisplay >= 1024 AndAlso CType(size.Length - 1, Boolean))
                varMaximumOrder += 1
                varMaximumPhotoLengthDisplay /= 1024
            End While

            If varOriginalPhotoLength > varMaximumPhotoLength Then
                Dim varErrorBox As New UI.Canvas.FRMdialogbox(My.Application.Info.AssemblyName, "Your file size is : " & String.Format(Globalization.CultureInfo.InvariantCulture, "{0:0.##} {1}", varPhotoLength, size(varOrder)) & ", above the size that we can tolerate." & vbCrLf & "Please pick your file size under " & String.Format(Globalization.CultureInfo.InvariantCulture, "{0:0.##} {1}", varMaximumPhotoLengthDisplay, size(varMaximumOrder)) & " and then try again.", LibApp.Ingrid.Global.PopupType.LimitExceeded, "", UI.Canvas.FRMdialogbox.MessageIcon.Error, UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                If (shownativedialog) Then
                    varErrorBox.ShowDialog()
                    varErrorBox.Dispose()
                End If
                varIsAllowed = False
            Else
                varIsAllowed = True
            End If

            Return varIsAllowed
        End Function
    End Class
End Namespace
