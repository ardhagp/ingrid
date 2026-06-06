Namespace Api
    Public Class Magika

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
                End If

                'If extension = "jpg" OrElse extension = "jpeg" Then
                '    If Not info.Value.Output.Label.ToLower().Equals("jpg") OrElse Not info.Value.Output.Label.ToLower().Equals("jpeg") Then
                '        Return (False, $"File extension {extension} does not match detected file type {info.Value.Output.Label}.")
                '    End If
                'Else
                '    If Not info.Value.Output.Label.ToLower().Equals(extension) Then
                '        Return (False, $"File extension {extension} does not match detected file type {info.Value.Output.Label}.")
                '    End If
                'End If

                Return (True, "File is valid.")
            End Using
        End Function
    End Class
End Namespace