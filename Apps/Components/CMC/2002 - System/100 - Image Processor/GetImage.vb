Imports System.Windows.Forms

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
        Public Shared Async Sub GetImageFromUrl(url As String, picturebox As System.Windows.Forms.PictureBox)
            Try
                Dim client As New Net.Http.HttpClient()

                Dim data As Byte() = Await client.GetByteArrayAsync(url)

                Using ms As New IO.MemoryStream(data)
                    picturebox.Image = System.Drawing.Image.FromStream(ms)
                End Using
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show($"Unable to load image with this error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace