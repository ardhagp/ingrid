Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.Versioning

Namespace ImageEditor.Proccessor
    Public Class Compress
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsFile(ByVal File As String, ByVal SaveAs As String) As Boolean
            ' Get a bitmap.
            Dim V_Success As Boolean
            Try
                Dim V_Photo As New Bitmap(File)
                Dim V_TmpPhoto As New Bitmap(V_Photo)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim V_myEncoderParameters As New EncoderParameters(1)

                Dim V_MemoryStream As New MemoryStream

                Dim V_myEncoderParameter As New EncoderParameter(myEncoder, 20&)

                V_myEncoderParameters.Param(0) = V_myEncoderParameter

                V_TmpPhoto.Save(V_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

                Dim V_NewPhoto As New Bitmap(System.Drawing.Image.FromStream(V_MemoryStream))

                '_NewPhoto = System.Drawing.Image.FromStream(_MemoryStream)
                V_NewPhoto.Save(SaveAs, jpgEncoder, V_myEncoderParameters)
                V_NewPhoto.Dispose()
                V_MemoryStream.Dispose()
                V_TmpPhoto.Dispose()
                V_Photo.Dispose()
                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            GC.Collect()

            Return V_Success
        End Function

        ''' <summary>
        ''' Convert File Path to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(ByVal File As String) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim V_Photo As New Bitmap(File)
                Dim jpgEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

                ' Create an Encoder object based on the GUID
                ' for the Quality parameter category.
                Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

                ' Create an EncoderParameters object.
                ' An EncoderParameters object has an array of EncoderParameter
                ' objects. In this case, there is only one
                ' EncoderParameter object in the array.
                Dim V_myEncoderParameters As New EncoderParameters(1)

                Dim V_myEncoderParameter As New EncoderParameter(myEncoder, 20&)
                V_myEncoderParameters.Param(0) = V_myEncoderParameter

                Dim V_NewImage As System.Drawing.Image = Nothing

                Dim V_MemoryStream = New MemoryStream()
                '_Photo.Save(_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                V_Photo.Save(V_MemoryStream, jpgEncoder, V_myEncoderParameters)
                'Dim _Byte = _MemoryStream.ToArray

                V_NewImage = System.Drawing.Image.FromStream(V_MemoryStream)

                GC.Collect()

                Return V_NewImage
            Catch ex As Exception
                PUSHERRORDATA("[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Filestream to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(ByVal File As FileStream) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim V_NewImage As System.Drawing.Image = Nothing
                Dim V_MemoryStream = New MemoryStream()

                V_MemoryStream.SetLength(File.Length)
                File.Read(V_MemoryStream.GetBuffer, 0, CType(File.Length, Integer))

                V_MemoryStream.Flush()
                File.Close()
                V_MemoryStream.Close()

                V_NewImage = System.Drawing.Image.FromStream(V_MemoryStream)

                GC.Collect()

                Return V_NewImage
            Catch ex As Exception
                PUSHERRORDATA("[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Convert Byte to Image
        ''' </summary>
        ''' <param name="File"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsImage(ByVal File() As Byte) As System.Drawing.Image
            ' Get a bitmap.
            Try
                Dim V_NewImage As System.Drawing.Image = Nothing
                Dim V_MemoryStream = New MemoryStream()

                V_MemoryStream.Write(File, 0, File.Length)
                V_MemoryStream.Seek(0, SeekOrigin.Begin)

                V_NewImage = System.Drawing.Image.FromStream(V_MemoryStream)

                GC.Collect()

                Return V_NewImage
            Catch ex As Exception
                PUSHERRORDATA("[OutputAsImage] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function OutputAsByte(ByVal File As String) As Byte()
            ' Get a bitmap.
            Dim V_Photo As New Bitmap(File)

            ' Create an Encoder object based on the GUID
            ' for the Quality parameter category.
            Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality

            ' Create an EncoderParameters object.
            ' An EncoderParameters object has an array of EncoderParameter
            ' objects. In this case, there is only one
            ' EncoderParameter object in the array.
            Dim V_myEncoderParameters As New EncoderParameters(1)

            Dim V_myEncoderParameter As New EncoderParameter(myEncoder, 20&)
            V_myEncoderParameters.Param(0) = V_myEncoderParameter
            '_Photo.Save(SaveAs, jpgEncoder, myEncoderParameters)

            Dim V_MemoryStream = New MemoryStream()
            V_Photo.Save(V_MemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim V_Byte = V_MemoryStream.ToArray

            GC.Collect()

            Return V_Byte
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
            Dim V_Codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

            Dim V_codec As ImageCodecInfo
            For Each V_codec In V_Codecs
                If V_codec.FormatID = format.Guid Then
                    Return V_codec
                End If
            Next v_codec
            Return Nothing
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function Watermarker(ByVal Picture As System.Drawing.Image, ByVal Text As String) As System.Drawing.Image
            Try
                Dim V_BMP As New Bitmap(Picture)
                Dim V_WaterText As String = Text
                Dim V_Canvas As Graphics = Graphics.FromImage(V_BMP)
                Dim V_StringSizeF As SizeF,
    V_DesiredWidth As Double,
    V_DesiredWidth2 As Double,
    V_DesireHeight As Double,
    V_wmFont As Font,
    V_RequiredFontSize As Double,
    V_Ratio As Double

                V_wmFont = New Font("Verdana", 14, FontStyle.Bold)

                V_DesiredWidth = V_BMP.Width * 0.5
                V_DesiredWidth2 = V_BMP.Width * 0.25
                V_DesireHeight = V_BMP.Height * 0.5

                V_StringSizeF = V_Canvas.MeasureString(V_WaterText, V_wmFont)
                V_Ratio = V_StringSizeF.Width / V_wmFont.SizeInPoints
                V_RequiredFontSize = V_DesiredWidth / V_Ratio

                V_wmFont = New Font("Verdana", CType(V_RequiredFontSize, Single), CType(FontStyle.Bold, FontStyle))

                V_Canvas.DrawString(V_WaterText,
        V_wmFont,
        New SolidBrush(Color.FromArgb(128, 0, 0, 0)), CType(V_DesiredWidth2 + 2, Single), CType(V_DesireHeight + 2, Single))

                V_Canvas.DrawString(V_WaterText,
        V_wmFont,
        CType(New SolidBrush(Color.FromArgb(128, 255, 255, 255)), Brush), CType(V_DesiredWidth2, Single), CType(V_DesireHeight, Single))

                V_BMP.SetResolution(96, 96)

                Return V_BMP
            Catch ex As Exception
                PUSHERRORDATA("[Watermarker] $\Ingrid\Apps\Components\CMC\2002 - System\100 - Image Processor\Compress\clsImageEditor.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.ToString, "-1", "", "", True, True, True)
                PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

