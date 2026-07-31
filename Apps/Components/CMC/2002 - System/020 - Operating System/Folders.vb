Namespace OperatingSystem
    ''' <summary>
    ''' This class provides methods for working with folders in the file system, such as checking if a folder exists.
    ''' </summary>
    Public Class Folder
        ''' <summary>
        ''' This function checks if a folder exists at the specified folder path.
        ''' </summary>
        ''' <param name="folderpath">The path of the folder to check.</param>
        ''' <returns>True if the folder exists; otherwise, false.</returns>
        Public Shared Function Exists(folderpath As String) As Boolean
            Dim varFileExists As New IO.DirectoryInfo(folderpath)
            Return varFileExists.Exists
        End Function
    End Class
End Namespace

