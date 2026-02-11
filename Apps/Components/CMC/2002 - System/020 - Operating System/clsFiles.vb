Namespace OperatingSystem.File
    Public Class Info
        ''' <summary>
        ''' Fungsi untuk memastikan bahwa file ada.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsExists(filepath As String) As Boolean
            Dim varFileIsExists As New IO.FileInfo(filepath)
            Return varFileIsExists.Exists
        End Function

        ''' <summary>
        ''' Fungsi untuk menghitung besar suatu file.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <returns>Double</returns>
        Public Shared Function Size(filepath As String) As Double
            Dim varFileSize As New IO.FileInfo(filepath)
            Return varFileSize.Length
        End Function
    End Class

    Public Class Upload
        ''' <summary>
        ''' Fungsi untuk memeriksa ukuran maksimum file yang dapat diunggah.
        ''' </summary>
        ''' <param name="FilePath">Letak dan nama file tersimpan</param>
        ''' <param name="MaxSize">Ukuran file maksimum (dalam Megabyte)</param>
        ''' <returns>Boolean</returns>
        Public Shared Function IsAllowedSize(filePath As String, maxsize As Double, Optional shownativedialog As Boolean = False) As Boolean

            'Dim _File As New Info

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
                Dim varErrorBox As New CMCv.frmDialogBox(My.Application.Info.AssemblyName, "Your file size is : " & String.Format(Globalization.CultureInfo.InvariantCulture, "{0:0.##} {1}", varPhotoLength, size(varOrder)) & ", above the size that we can tolerate." & vbCrLf & "Please pick your file size under " & String.Format(Globalization.CultureInfo.InvariantCulture, "{0:0.##} {1}", varMaximumPhotoLengthDisplay, size(varMaximumOrder)) & " and then try again.", LibApp.Ingrid.Global.PopupType.LimitExceeded, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
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
