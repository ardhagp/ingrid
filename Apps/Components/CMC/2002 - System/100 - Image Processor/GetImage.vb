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

        ''' <summary>
        ''' This function is used to get the image extension from a Bitmap object. It takes in a Bitmap object and returns a string representing the image extension (e.g., "jpg", "png", "bmp", "gif", "tiff"). If the image format is not recognized, it returns "unknown".
        ''' </summary>
        ''' <param name="bitmap">The Bitmap object to get the image extension from.</param>
        ''' <returns>A string representing the image extension (e.g., "jpg", "png", "bmp", "gif", "tiff"). If the image format is not recognized, it returns "unknown".</returns>
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

        ''' <summary>
        ''' This function is used to get an image from a URL and set it as the image of a PictureBox. It takes in the URL of the image, the PictureBox object, and an optional dataproperties object. If the image is successfully loaded, it sets the EmployeeIsForceChangePhoto property to False. If there is an error loading the image, it sets the EmployeeIsForceChangePhoto property to True and displays an error message.
        ''' </summary>
        ''' <param name="url">The URL of the image to load.</param>
        ''' <param name="picturebox">The PictureBox object to set the image for.</param>
        ''' <param name="dataproperties">Optional dataproperties object to update the EmployeeIsForceChangePhoto property.</param>
        ''' <returns>True if the image was successfully loaded and set; otherwise, False.</returns>
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
        ''' This function is used to get an image from a URL and set it as the background image of a form. It takes in the URL of the image, the form name, and an optional dataproperties object. If the image is successfully loaded, it sets the EmployeeIsForceChangePhoto property to False. If there is an error loading the image, it sets the EmployeeIsForceChangePhoto property to True and displays an error message.
        ''' </summary>
        ''' <param name="url">The URL of the image to load.</param>
        ''' <param name="formname">The form to set the background image for.</param>
        ''' <param name="dataproperties">Optional dataproperties object to update the EmployeeIsForceChangePhoto property.</param>
        ''' <returns>True if the image was successfully loaded and set; otherwise, False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Async Function GetImageFromUrlAsync(url As String, formname As System.Windows.Forms.Form, Optional dataproperties As LibApp.Ingrid.Global.Properties = Nothing) As Task(Of Boolean)
            Try
                Dim client As New Net.Http.HttpClient()

                Dim data As Byte() = Await client.GetByteArrayAsync(url)

                Using ms As New IO.MemoryStream(data)
                    formname.BackgroundImage = System.Drawing.Image.FromStream(ms)
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
        ''' This function is used to get an image from a URL and set it as the image of a ToolStrip item. It takes in the URL of the image, the ToolStrip object, the name of the ToolStrip item, and an optional dataproperties object. If the image is successfully loaded, it sets the EmployeeIsForceChangePhoto property to False. If there is an error loading the image, it sets the EmployeeIsForceChangePhoto property to True and displays an error message.
        ''' </summary>
        ''' <param name="url">The URL of the image to load.</param>
        ''' <param name="toolstrip">The ToolStrip object containing the item to set the image for.</param>
        ''' <param name="tooltipitemname">The name of the ToolStrip item to set the image for.</param>
        ''' <param name="dataproperties">Optional dataproperties object to update the EmployeeIsForceChangePhoto property.</param>
        ''' <returns>True if the image was successfully loaded and set; otherwise, False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Async Function GetImageFromUrlAsync(url As String, toolstrip As System.Windows.Forms.ToolStrip, tooltipitemname As String, Optional dataproperties As LibApp.Ingrid.Global.Properties = Nothing) As Task(Of Boolean)
            Try
                Dim client As New Net.Http.HttpClient()
                'Dim imgSix As SixLabors.ImageSharp.Image
                Dim data As Byte() = Await client.GetByteArrayAsync(url)

                Using ms As New IO.MemoryStream(data)
                    'This is the current implementation that loads the image directly into the toolstrip
                    'item without cropping.
                    toolstrip.Items(tooltipitemname).Image = System.Drawing.Image.FromStream(ms)
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
        ''' This function is used to convert an SVG image to a Bitmap image. It takes in the path and filename of the SVG image, a boolean indicating whether the image is inside the current directory, and optional width and height parameters for the resulting Bitmap. If the conversion is successful, it returns the Bitmap image. If there is an error during conversion, it returns a default "svg-404.svg" image as a Bitmap.
        ''' </summary>
        ''' <param name="imagepathandfilename">The path and filename of the SVG image to convert.</param>
        ''' <param name="isinsidecurrentdirectory">A boolean indicating whether the image is inside the current directory.</param>
        ''' <param name="width">The width of the resulting Bitmap. Default is 24.</param>
        ''' <param name="height">The height of the resulting Bitmap. Default is 24.</param>
        ''' <returns>A Bitmap image converted from the SVG image. If there is an error, returns a default "svg-404.svg" image as a Bitmap.</returns>
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
                svgImage = Svg.SvgDocument.Open(Environment.CurrentDirectory & $"\Resources\svg-404.svg")
                bmp = svgImage.Draw(width, height)
                Return bmp
            End Try
        End Function

        ''' <summary>
        ''' This function is used to get an SVG image from a URL and set it as the image of a PictureBox. It takes in the URL of the SVG image, the PictureBox object, optional dataproperties object, and optional width and height parameters for the resulting Bitmap. If the SVG image is successfully loaded and converted to a Bitmap, it sets the EmployeeIsForceChangePhoto property to False. If there is an error loading or converting the SVG image, it sets the EmployeeIsForceChangePhoto property to True, displays an error message, and sets a default "svg-404.svg" image as the PictureBox image.
        ''' </summary>
        ''' <param name="url">The URL of the SVG image to load.</param>
        ''' <param name="picturebox">The PictureBox control to set the image to.</param>
        ''' <param name="dataproperties">Optional dataproperties object.</param>
        ''' <param name="width">The width of the resulting Bitmap. Default is 24.</param>
        ''' <param name="height">The height of the resulting Bitmap. Default is 24.</param>
        ''' <returns>True if the SVG image was successfully loaded and set; otherwise, False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Async Function GetSvgImageFromUrlAsync(
    url As String,
    picturebox As System.Windows.Forms.PictureBox,
    Optional dataproperties As LibApp.Ingrid.Global.Properties = Nothing,
    Optional width As Integer = 24,
    Optional height As Integer = 24
) As Task(Of Boolean)

            Try
                Dim client As New Net.Http.HttpClient()

                ' Download SVG as text
                Dim svgContent As String = Await client.GetStringAsync(url)

                ' Load SVG from string
                Dim svgDoc As Svg.SvgDocument
                Using svgStream As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(svgContent))
                    svgDoc = Svg.SvgDocument.Open(Of Svg.SvgDocument)(svgStream)
                End Using

                ' Convert to Bitmap
                Dim bmp As System.Drawing.Bitmap = svgDoc.Draw(width, height)

                ' Assign to PictureBox
                picturebox.Image = bmp

                If dataproperties IsNot Nothing Then
                    dataproperties.EmployeeIsForceChangePhoto = False
                End If

                Return True

            Catch ex As Exception
                ' Fallback SVG
                Dim fallbackPath As String = IO.Path.Combine(Environment.CurrentDirectory, "Resources\svg-404.svg")
                Dim fallbackSvg As Svg.SvgDocument = Svg.SvgDocument.Open(fallbackPath)
                Dim fallbackBmp As System.Drawing.Bitmap = fallbackSvg.Draw(width, height)

                picturebox.Image = fallbackBmp

                If dataproperties IsNot Nothing Then
                    dataproperties.EmployeeIsForceChangePhoto = True
                End If

                System.Windows.Forms.MessageBox.Show($"Unable to load SVG image: {ex.Message}", "Error",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

                Return False
            End Try
        End Function

        ''' <summary>
        ''' This function is used to get an SVG image from a URL and set it as the image of a ToolStrip item. It takes in the URL of the SVG image, the MenuStrip object, the name of the ToolStrip item, optional dataproperties object, and optional width and height parameters for the resulting Bitmap. If the SVG image is successfully loaded and converted to a Bitmap, it sets the EmployeeIsForceChangePhoto property to False. If there is an error loading or converting the SVG image, it sets the EmployeeIsForceChangePhoto property to True, displays an error message, and sets a default "svg-404.svg" image as the ToolStrip item image.
        ''' </summary>
        ''' <param name="url">The URL of the SVG image to load.</param>
        ''' <param name="menustripname">The MenuStrip object containing the ToolStrip item.</param>
        ''' <param name="tooltipitemname">The name of the ToolStrip item to set the image for.</param>
        ''' <param name="dataproperties">Optional dataproperties object.</param>
        ''' <param name="width">Optional width of the resulting Bitmap.</param>
        ''' <param name="height">Optional height of the resulting Bitmap.</param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Async Function GetSvgImageFromUrlAsync(
    url As String,
    menustripname As System.Windows.Forms.MenuStrip, tooltipitemname As String,
    Optional dataproperties As LibApp.Ingrid.Global.Properties = Nothing,
    Optional width As Integer = 24,
    Optional height As Integer = 24
) As Task(Of Boolean)

            Try
                Dim client As New Net.Http.HttpClient()

                ' Download SVG as text
                Dim svgContent As String = Await client.GetStringAsync(url)

                ' Load SVG from string
                Dim svgDoc As Svg.SvgDocument
                Using svgStream As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(svgContent))
                    svgDoc = Svg.SvgDocument.Open(Of Svg.SvgDocument)(svgStream)
                End Using

                ' Convert to Bitmap
                Dim bmp As System.Drawing.Bitmap = svgDoc.Draw(width, height)

                If bmp Is Nothing Then
                    Throw New Exception("Failed to convert SVG to Bitmap.")
                    Return False
                End If

                Using ms As New IO.MemoryStream()
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    ms.Position = 0
                    menustripname.Items(tooltipitemname).Image = System.Drawing.Image.FromStream(ms)
                End Using

                ' Assign to ToolStrip item
                'menustripname.Items(tooltipitemname).Image = bmp

                If dataproperties IsNot Nothing Then
                    dataproperties.EmployeeIsForceChangePhoto = False
                End If

                Return True

            Catch ex As Exception
                ' Fallback SVG
                Dim fallbackPath As String = IO.Path.Combine(Environment.CurrentDirectory, "Resources\svg-404.svg")
                Dim fallbackSvg As Svg.SvgDocument = Svg.SvgDocument.Open(fallbackPath)
                Dim fallbackBmp As System.Drawing.Bitmap = fallbackSvg.Draw(width, height)

                menustripname.Items(tooltipitemname).Image = fallbackBmp

                If dataproperties IsNot Nothing Then
                    dataproperties.EmployeeIsForceChangePhoto = True
                End If

                System.Windows.Forms.MessageBox.Show($"Unable to load SVG image: {ex.Message}", "Error",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

                Return False
            End Try
        End Function
    End Class

    Public Class TransformImage
        ''' <summary>
        ''' This function is used to crop an image into a square shape. It takes in an Image object and returns a new Image object that is cropped to a square based on the smaller dimension of the original image. The cropping is centered, meaning that the center of the original image will be preserved in the resulting square image.
        ''' </summary>
        ''' <param name="image">The Image object to be cropped into a square.</param>
        ''' <returns>A new Image object that is cropped to a square.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function CroptoSquare(image As System.Drawing.Image) As System.Drawing.Image
            Dim size As Integer = Math.Min(image.Width, image.Height)
            Dim x As Integer = CInt((image.Width - size) / 2)
            Dim y As Integer = CInt((image.Height - size) / 2)
            Dim squareImage As New System.Drawing.Bitmap(size, size)
            Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(squareImage)
                g.DrawImage(image, New System.Drawing.Rectangle(0, 0, size, size), New System.Drawing.Rectangle(x, y, size, size), System.Drawing.GraphicsUnit.Pixel)
            End Using
            Return squareImage
        End Function
    End Class
End Namespace