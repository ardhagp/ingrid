Namespace Api
    ''' <summary>
    ''' The Magika class provides functionality to validate file types using the MagikaNet library. It includes a method to check if a given file path corresponds to an allowed file extension and whether the detected file type matches the file's extension. The class is designed to ensure that files meet specific criteria before further processing or storage.
    ''' </summary>
    Public Class Magika
        ''' <summary>
        ''' Validates the file at the specified path against a list of allowed extensions. It uses the MagikaNet library to detect the file type and compares it with the provided allowed extensions. The method returns a tuple indicating whether the file is valid and a reason message if it is not valid.
        ''' </summary>
        ''' <param name="path">The file path to validate.</param>
        ''' <param name="allowedextension">An array of allowed file extensions.</param>
        ''' <returns>A tuple containing a boolean indicating validity and a reason message.</returns>
        Public Shared Function Validate(path As String, allowedextension As String()) As (IsValid As Boolean, Reason As String)
            Using m As New MagikaNet.MagikaClient
                Dim info = m.DetectPath(path)

                If info.Value.Output.Label = String.Empty OrElse info.FileType = "unknown" Then
                    Return (False, "Unable to identify file type.")
                End If

                If Not allowedextension.Contains(info.Value.Output.Label) Then
                    Return (False, $"The file extension '.{info.Value.Output.Label.ToUpper}' is not allowed, the file type you selected is invalid.")
                End If

                Dim extension = System.IO.Path.GetExtension(path).TrimStart("."c).ToUpper()
                Dim detectLabel = info.Value.Output.Label.ToUpper()

                Dim isValidMatch = If(extension = "JPG" OrElse extension = "JPEG", detectLabel = "JPG" OrElse detectLabel = "JPEG", detectLabel = extension)

                If Not isValidMatch Then
                    Return (False, $"The file extension '.{extension}' does not match the detected file type '.{info.Value.Output.Label.ToUpper}'.")
                Else
                    Return (True, "File is valid.")
                End If
            End Using
        End Function
    End Class
End Namespace