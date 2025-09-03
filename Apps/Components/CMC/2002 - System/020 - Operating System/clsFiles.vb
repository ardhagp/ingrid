Namespace OperatingSystem.File
    Public Class Info
        ''' <summary>
        ''' Fungsi untuk memastikan bahwa file ada.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsExists(ByVal FilePath As String) As Boolean
            Dim V_FileIsExists As New IO.FileInfo(FilePath)
            Return V_FileIsExists.Exists
        End Function

        ''' <summary>
        ''' Fungsi untuk menghitung besar suatu file.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Double</returns>
        Public Shared Function Size(ByVal FilePath As String) As Double
            Dim V_FileSize As New IO.FileInfo(FilePath)
            Return V_FileSize.Length
        End Function
    End Class

    Public Class Upload
        ''' <summary>
        ''' Fungsi untuk memeriksa ukuran maksimum file yang dapat diunggah.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <param name="MaxSize">Ukuran file maksimum (dalam Megabyte)</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsAllowedSize(ByVal FilePath As String, ByVal MaxSize As Double, Optional ByVal ShowNativeDialog As Boolean = False) As Boolean

            'Dim _File As New Info

            Dim V_IsAllowed As Boolean
            Dim size As String() = {"B", "KB", "MB", "GB", "TB"}
            Dim V_PhotoLength As Double = Info.Size(FilePath)
            Dim V_OriginalPhotoLength As Double = V_PhotoLength
            Dim V_Order As Integer = 0
            Dim V_MaximumOrder As Integer = 0

            If MaxSize = 0 Then
                V_IsAllowed = True
                Return V_IsAllowed
            End If

            While (V_PhotoLength >= 1024 AndAlso CType(size.Length - 1, Boolean))
                V_Order += 1
                V_PhotoLength /= 1024
            End While

            Dim V_MaximumPhotoLength As Double = ((1024 ^ 2) * MaxSize) '1 indicate 1000KB or 1MB
            Dim V_MaximumPhotoLengthDisplay As Double = V_MaximumPhotoLength

            While (V_MaximumPhotoLengthDisplay >= 1024 AndAlso CType(size.Length - 1, Boolean))
                V_MaximumOrder += 1
                V_MaximumPhotoLengthDisplay /= 1024
            End While

            If V_OriginalPhotoLength > V_MaximumPhotoLength Then
                Dim V_ErrorBox As New CMCv.frmDialogBox("Your file size is : " & String.Format("{0:0.##} {1}", V_PhotoLength, size(V_Order)) & ", above the size that we can tolerate." & vbCrLf & "Please pick your file size under " & String.Format("{0:0.##} {1}", V_MaximumPhotoLengthDisplay, size(V_MaximumOrder)) & " and then try again.", "Limit Exceeded", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                If (ShowNativeDialog) Then
                    V_ErrorBox.ShowDialog()
                    V_ErrorBox.Dispose()
                End If
                V_IsAllowed = False
            Else
                V_IsAllowed = True
            End If

            Return V_IsAllowed
        End Function
    End Class
End Namespace
