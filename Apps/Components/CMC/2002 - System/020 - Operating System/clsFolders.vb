Namespace OperatingSystem
    Public Class Folder
        Public Shared Function Exists(ByVal FolderPath As String) As Boolean
            Dim V_FileExists As New IO.DirectoryInfo(FolderPath)
            Return V_FileExists.Exists
        End Function
    End Class
End Namespace

