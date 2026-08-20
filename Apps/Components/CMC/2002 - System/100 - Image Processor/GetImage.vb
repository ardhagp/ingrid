Namespace ImageEditor.File
    Public Class GetImage
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetImageExtensionFromFile(filePath As String) As String
            Dim extension As String = System.IO.Path.GetExtension(filePath).ToLowerInvariant()
            Select Case extension
                Case ".jpg", ".jpeg"
                    Return "jpg"
                Case ".png"
                    Return "png"
                Case ".bmp"
                    Return "bmp"
                Case ".gif"
                    Return "gif"
                Case ".tiff", ".tif"
                    Return "tiff"
                Case Else
                    Return "unknown"
            End Select
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetImageExtensionFromBitmap(bitmap As System.Drawing.Bitmap) As String
            Dim format As System.Drawing.Imaging.ImageFormat = bitmap.RawFormat
            If format.Equals(System.Drawing.Imaging.ImageFormat.Jpeg.Guid) Then
                Return "jpg"
            ElseIf format.Equals(System.Drawing.Imaging.ImageFormat.Png.Guid) Then
                Return "png"
            ElseIf format.Equals(System.Drawing.Imaging.ImageFormat.Bmp.Guid) Then
                Return "bmp"
            ElseIf format.Equals(System.Drawing.Imaging.ImageFormat.Gif.Guid) Then
                Return "gif"
            ElseIf format.Equals(System.Drawing.Imaging.ImageFormat.Tiff.Guid) Then
                Return "tiff"
            Else
                Return "unknown"
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Async Function GetImageFromUrlAsync(url As String, picturebox As System.Windows.Forms.PictureBox, Optional dataproperties As LibApp.Ingrid.Global.Properties = Nothing) As Task(Of Boolean)
            Try
                Dim client As New Net.Http.HttpClient()

                Dim data As Byte() = Await client.GetByteArrayAsync(url)

                Using ms As New IO.MemoryStream(data)
                    picturebox.Image = System.Drawing.Image.FromStream(ms)
                End Using
                If dataproperties IsNot Nothing Then
                    dataproperties.EmployeeIsForceChangePhoto = False
                End If
                Return True
            Catch ex As Exception
                If dataproperties IsNot Nothing Then
                    dataproperties.EmployeeIsForceChangePhoto = True
                End If
                System.Windows.Forms.MessageBox.Show($"Unable to load image with this error: {ex.Message}", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
                Return False
            End Try
        End Function

        ''' <summary>
        ''' This function
        ''' </summary>
        ''' <param name="imagepath"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function ConvertSvgToBmp(imagepathandfilename As String, Optional isinsidecurrentdirectory As Boolean = False, Optional width As Integer = 24, Optional height As Integer = 24) As System.Drawing.Bitmap
            Dim path As String
            Dim svgImage As Svg.SvgDocument
            Dim bmp As System.Drawing.Bitmap

            Try
                If isinsidecurrentdirectory Then
                    path = Environment.CurrentDirectory & $"{imagepathandfilename}"
                Else
                    path = imagepathandfilename
                End If

                svgImage = Svg.SvgDocument.Open(path)
                bmp = svgImage.Draw(width, height)
                Return bmp
            Catch ex As Exception
                svgImage = Svg.SvgDocument.Open(Environment.CurrentDirectory & $"\Resources\svg-x-circle-fill.svg")
                bmp = svgImage.Draw(width, height)
                Return bmp
            End Try
        End Function
    End Class
End Namespace