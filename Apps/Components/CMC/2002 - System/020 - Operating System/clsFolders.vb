Namespace OperatingSystem
    Public Class Folder
        Public Shared Function Exists(folderpath As String) As Boolean
            Dim varFileExists As New IO.DirectoryInfo(folderpath)
            Return varFileExists.Exists
        End Function
    End Class
End Namespace

