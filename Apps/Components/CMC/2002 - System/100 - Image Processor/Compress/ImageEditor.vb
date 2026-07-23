Namespace ImageEditor.Proccessor
    ''' <summary>
    ''' This class provides methods for compressing images and converting them to different formats. It includes functions to output images as files, byte arrays, or System.Drawing.Image objects, with options for setting image quality and applying watermarks.
    ''' </summary>
    Public Class Compress
        ''' <summary>
        ''' This function compresses an image file and saves it as a new file with the specified quality. It takes the input file path and the output file path as parameters, and returns a boolean indicating whether the operation was successful.
        ''' </summary>
        ''' <param name="file">The path of the input image file.</param>
        ''' <param name="saveas">The path where the compressed image will be saved.</param>
        ''' <returns>True if the image was successfully compressed and saved; otherwise, false.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function OutputAsFile(file As String, saveas As String) As Boolean
            ' Get a bitmap.
            Dim varSuccess As Boolean
            Try
                Dim varPhoto As New System.Drawing.Bitmap(file)
                Dim varTmpPhoto As New System.Drawing.Bitmap(varPhoto)
                Dim jpgEncoder As System.Drawing.Imaging.ImageCodecInfo = GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim varEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim varEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)

                Dim varMemoryStream As New System.IO.MemoryStream

                Dim varEncoderParameter As New System.Drawing.Imaging.EncoderParameter(varEncoder, 20&)
                varEncoderParameters.Param(0) = varEncoderParameter

                varTmpPhoto.Save(varMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

                Dim varNewPhoto As New System.Drawing.Bitmap(System.Drawing.Image.FromStream(varMemoryStream))

                '_NewPhoto = System.Drawing.Image.FromStream(_MemoryStream)
                varNewPhoto.Save(saveas, jpgEncoder, varEncoderParameters)
                varNewPhoto.Dispose()
                varMemoryStream.Dispose()
                varTmpPhoto.Dispose()
                varPhoto.Dispose()
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            GC.Collect()

            Return varSuccess
        End Function

        ''' <summary>
        ''' This function converts an image file to a System.Drawing.Image object. It takes the input file path as a parameter and returns the corresponding Image object. If an error occurs during the conversion, it logs the error and returns Nothing.
        ''' </summary>
        ''' <param name="file">The path of the input image file.</param>
        ''' <returns>The corresponding Image object if the conversion is successful; otherwise, Nothing.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(file As String) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varPhoto As New System.Drawing.Bitmap(file)
                Dim jpgEncoder As System.Drawing.Imaging.ImageCodecInfo = GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim varEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim varEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)

                Dim varEncoderParameter As New System.Drawing.Imaging.EncoderParameter(varEncoder, 20&)
                varEncoderParameters.Param(0) = varEncoderParameter

                Dim varNewImage As System.Drawing.Image = Nothing

                Dim varMemoryStream = New System.IO.MemoryStream()
                '_Photo.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                varPhoto.Save(varMemoryStream, jpgEncoder, varEncoderParameters)
                'Dim _Byte = _MemoryStream.ToArray

                varNewImage = System.Drawing.Image.FromStream(varMemoryStream)

                GC.Collect()

                Return varNewImage
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
                    .FromSender = "[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' This function converts a FileStream containing image data to a System.Drawing.Image object. It reads the data from the FileStream, creates a MemoryStream, and then generates an Image object from that stream. If an error occurs during the conversion, it logs the error and returns Nothing.
        ''' </summary>
        ''' <param name="file">The FileStream containing the image data.</param>
        ''' <returns>The corresponding Image object if the conversion is successful; otherwise, Nothing.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(file As System.IO.FileStream) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varNewImage As System.Drawing.Image = Nothing
                Dim varMemoryStream = New System.IO.MemoryStream()

                varMemoryStream.SetLength(file.Length)
                file.Read(varMemoryStream.GetBuffer, 0, CType(file.Length, Integer))

                varMemoryStream.Flush()
                file.Close()
                varMemoryStream.Close()

                varNewImage = System.Drawing.Image.FromStream(varMemoryStream)

                GC.Collect()

                Return varNewImage
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
                    .FromSender = "[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' This function converts a byte array containing image data to a System.Drawing.Image object. It creates a MemoryStream from the byte array and then generates an Image object from that stream. If an error occurs during the conversion, it logs the error and returns Nothing.
        ''' </summary>
        ''' <param name="file">The byte array containing the image data.</param>
        ''' <returns>The corresponding Image object if the conversion is successful; otherwise, Nothing.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(file() As Byte) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varNewImage As System.Drawing.Image = Nothing
                Dim varMemoryStream = New System.IO.MemoryStream()

                varMemoryStream.Write(file, 0, file.Length)
                varMemoryStream.Seek(0, System.IO.SeekOrigin.Begin)

                varNewImage = System.Drawing.Image.FromStream(varMemoryStream)

                GC.Collect()

                Return varNewImage
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
                    .FromSender = "[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' This function converts an image file to a byte array. It reads the image from the specified file path, compresses it to JPEG format with a specified quality, and returns the resulting byte array. If an error occurs during the conversion, it logs the error and returns Nothing.
        ''' </summary>
        ''' <param name="file">The file path of the image to be converted.</param>
        ''' <returns>The byte array representing the compressed image if the conversion is successful; otherwise, Nothing.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function OutputAsByte(file As String) As Byte()
            ' Get a bitmap.
            Dim varPhoto As New System.Drawing.Bitmap(file)

            ' Create an Encoder object based on the GUID
            ' for the Quality parameter category.
            Dim varEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

            ' Create an EncoderParameters object.
            ' An EncoderParameters object has an array of EncoderParameter
            ' objects. In this case, there is only one
            ' EncoderParameter object in the array.
            Dim varEncoderParameters As New System.Drawing.Imaging.EncoderParameters(1)

            Dim varEncoderParameter As New System.Drawing.Imaging.EncoderParameter(varEncoder, 20&)
            varEncoderParameters.Param(0) = varEncoderParameter
            '_Photo.Save(SaveAs, jpgEncoder, myEncoderParameters)

            Dim varMemoryStream = New System.IO.MemoryStream()
            varPhoto.Save(varMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim varByte = varMemoryStream.ToArray

            GC.Collect()

            Return varByte
        End Function

        ''' <summary>
        ''' This function retrieves the ImageCodecInfo for a specified image format. It iterates through the available image decoders and returns the codec that matches the provided format's GUID. If no matching codec is found, it returns Nothing.
        ''' </summary>
        ''' <param name="format">The image format for which to retrieve the codec.</param>
        ''' <returns>The ImageCodecInfo object for the specified format if found; otherwise, Nothing.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Function GetEncoder(format As System.Drawing.Imaging.ImageFormat) As System.Drawing.Imaging.ImageCodecInfo
            Dim varCodecs As System.Drawing.Imaging.ImageCodecInfo() = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders()

            Dim varCodec As System.Drawing.Imaging.ImageCodecInfo
            For Each varCodec In varCodecs
                If varCodec.FormatID = format.Guid Then
                    Return varCodec
                End If
            Next varCodec
            Return Nothing
        End Function
    End Class

    ''' <summary>
    ''' This class provides methods for editing images, such as adding watermarks. It includes a function to apply a watermark text to an image and return the modified image. The watermark is drawn with a specified font and color, and the function handles any exceptions that may occur during the process, logging them appropriately.
    ''' </summary>
    Public Class Editor
        ''' <summary>
        ''' This function applies a watermark text to a given image. It creates a new bitmap from the original image, calculates the appropriate font size and position for the watermark, and draws the watermark text onto the image. The function returns the modified image with the watermark applied. If an error occurs during the process, it logs the error and returns Nothing.
        ''' </summary>
        ''' <param name="picture">The image to which the watermark will be applied.</param>
        ''' <param name="watermarktext">The text to be used as the watermark.</param>
        ''' <returns>The image with the watermark applied if successful; otherwise, Nothing.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function WaterMarker(picture As System.Drawing.Image, watermarktext As String) As System.Drawing.Image
            Try
                Dim varBitmap As New System.Drawing.Bitmap(picture)
                Dim varWaterText As String = watermarktext
                Dim varCanvas As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(varBitmap)
                Dim varStringSizef As System.Drawing.SizeF,
    varDesiredWidth As Double,
    varDesiredWidth2 As Double,
    varDesireHeight As Double,
    varwmFont As System.Drawing.Font,
    varRequiredFontSize As Double,
    varRatio As Double

                varwmFont = New System.Drawing.Font("Verdana", 14, System.Drawing.FontStyle.Bold)
                varDesiredWidth = varBitmap.Width * 0.5
                varDesiredWidth2 = varBitmap.Width * 0.25
                varDesireHeight = varBitmap.Height * 0.5

                varStringSizef = varCanvas.MeasureString(varWaterText, varwmFont)
                varRatio = varStringSizef.Width / varwmFont.SizeInPoints
                varRequiredFontSize = varDesiredWidth / varRatio

                varwmFont = New System.Drawing.Font("Verdana", CType(varRequiredFontSize, Single), CType(System.Drawing.FontStyle.Bold, System.Drawing.FontStyle))

                varCanvas.DrawString(varWaterText,
        varwmFont,
        New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(128, 0, 0, 0)), CType(varDesiredWidth2 + 2, Single), CType(varDesireHeight + 2, Single))

                varCanvas.DrawString(varWaterText,
        varwmFont,
        CType(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(128, 255, 255, 255)), System.Drawing.Brush), CType(varDesiredWidth2, Single), CType(varDesireHeight, Single))
                varBitmap.SetResolution(96, 96)

                Return varBitmap
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
                    .FromSender = "[WaterMarker] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

