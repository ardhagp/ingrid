Imports CMCv.UI
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Versioning

Namespace ImageEditor.Proccessor
    Public Class Compress
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsFile(file As String, saveas As String) As Boolean
            ' Get a bitmap.
            Dim varSuccess As Boolean
            Try
                Dim varPhoto As New Bitmap(file)
                Dim varTmpPhoto As New Bitmap(varPhoto)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim varEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim varEncoderParameters As New EncoderParameters(1)

                Dim varMemoryStream As New MemoryStream

                Dim varEncoderParameter As New EncoderParameter(varEncoder, 20&)

                varEncoderParameters.Param(0) = varEncoderParameter

                varTmpPhoto.Save(varMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

                Dim varNewPhoto As New Bitmap(System.Drawing.Image.FromStream(varMemoryStream))

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
        ''' Convert File Path to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(file As String) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varPhoto As New Bitmap(file)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim varEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim varEncoderParameters As New EncoderParameters(1)

                Dim varEncoderParameter As New EncoderParameter(varEncoder, 20&)
                varEncoderParameters.Param(0) = varEncoderParameter

                Dim varNewImage As System.Drawing.Image = Nothing

                Dim varMemoryStream = New MemoryStream()
                '_Photo.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                varPhoto.Save(varMemoryStream, jpgEncoder, varEncoderParameters)
                'Dim _Byte = _MemoryStream.ToArray

                varNewImage = System.Drawing.Image.FromStream(varMemoryStream)

                GC.Collect()

                Return varNewImage
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
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
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Filestream to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(file As FileStream) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varNewImage As System.Drawing.Image = Nothing
                Dim varMemoryStream = New MemoryStream()

                varMemoryStream.SetLength(file.Length)
                file.Read(varMemoryStream.GetBuffer, 0, CType(file.Length, Integer))

                varMemoryStream.Flush()
                file.Close()
                varMemoryStream.Close()

                varNewImage = System.Drawing.Image.FromStream(varMemoryStream)

                GC.Collect()

                Return varNewImage
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
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
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Byte to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(file() As Byte) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim varNewImage As System.Drawing.Image = Nothing
                Dim varMemoryStream = New MemoryStream()

                varMemoryStream.Write(file, 0, file.Length)
                varMemoryStream.Seek(0, SeekOrigin.Begin)

                varNewImage = System.Drawing.Image.FromStream(varMemoryStream)

                GC.Collect()

                Return varNewImage
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
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
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsByte(file As String) As Byte()
            ' Get a bitmap.
            Dim varPhoto As New Bitmap(file)

            ' Create an Encoder object based on the GUID
            ' for the Quality parameter category.
            Dim varEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

            ' Create an EncoderParameters object.
            ' An EncoderParameters object has an array of EncoderParameter
            ' objects. In this case, there is only one
            ' EncoderParameter object in the array.
            Dim varEncoderParameters As New EncoderParameters(1)

            Dim varEncoderParameter As New EncoderParameter(varEncoder, 20&)
            varEncoderParameters.Param(0) = varEncoderParameter
            '_Photo.Save(SaveAs, jpgEncoder, myEncoderParameters)

            Dim varMemoryStream = New MemoryStream()
            varPhoto.Save(varMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim varByte = varMemoryStream.ToArray

            GC.Collect()

            Return varByte
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Function GetEncoder(format As ImageFormat) As ImageCodecInfo
            Dim varCodecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

            Dim varCodec As ImageCodecInfo
            For Each varCodec In varCodecs
                If varCodec.FormatID = format.Guid Then
                    Return varCodec
                End If
            Next varCodec
            Return Nothing
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function WaterMarker(picture As System.Drawing.Image, watermarktext As String) As System.Drawing.Image
            Try
                Dim varBitmap As New Bitmap(picture)
                Dim varWaterText As String = watermarktext
                Dim varCanvas As Graphics = Graphics.FromImage(varBitmap)
                Dim varStringSizef As SizeF,
    varDesiredWidth As Double,
    varDesiredWidth2 As Double,
    varDesireHeight As Double,
    varwmFont As Font,
    varRequiredFontSize As Double,
    varRatio As Double

                varwmFont = New Font("Verdana", 14, FontStyle.Bold)

                varDesiredWidth = varBitmap.Width * 0.5
                varDesiredWidth2 = varBitmap.Width * 0.25
                varDesireHeight = varBitmap.Height * 0.5

                varStringSizeF = varCanvas.MeasureString(varWaterText, varwmFont)
                varRatio = varStringSizeF.Width / varwmFont.SizeInPoints
                varRequiredFontSize = varDesiredWidth / varRatio

                varwmFont = New Font("Verdana", CType(varRequiredFontSize, Single), CType(FontStyle.Bold, FontStyle))

                varCanvas.DrawString(varWaterText,
        varwmFont,
        New SolidBrush(Color.FromArgb(128, 0, 0, 0)), CType(varDesiredWidth2 + 2, Single), CType(varDesireHeight + 2, Single))

                varCanvas.DrawString(varWaterText,
        varwmFont,
        CType(New SolidBrush(Color.FromArgb(128, 255, 255, 255)), Brush), CType(varDesiredWidth2, Single), CType(varDesireHeight, Single))

                varBitmap.SetResolution(96, 96)

                Return varBitmap
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
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
                clsLog.ShowData(proLog)
                clsLog = Nothing
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

