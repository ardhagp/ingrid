'       AKLib by Arve Kjønsvik
'    E-mail: a_kjonsvik@hotmail.com
'    ''''''''''''''''''''''''''''''
'    Modified by:
'      
'    Version history:
'      Project started: July, 19th 2010
'       v1.0.0.0    -   First release

Option Strict On

Imports System.IO

''' <summary>
''' A simple way to update the files for your application.
''' SimpleUpdate will overwrite existing files without prompting (if newer).
''' </summary>
Public Class SimpleUpdater
    ''' <summary>
    ''' Using a pre-defined list with files to update.
    ''' </summary>
    ''' <param name="pathPreDefinedList">Path to the file with the update-list.</param>
    ''' <param name="urlNewUpdatesList">The update-list on the update-server.</param>
    ''' <param name="pathToSimpleUpdater">This is the path to the SimpleUpdater.Exe.</param>
    Public Shared Sub FromDefinedList(ByVal pathPreDefinedList As String, _
                                      ByVal urlNewUpdatesList As String, _
                                      ByVal pathToSimpleUpdater As String)

        'Checks to see if the user entered the correct path to the defined list
        If Not File.Exists(pathPreDefinedList) Then
            MessageBox.Show("The pre-defined list with updates could not be found!" & _
                            Environment.NewLine & _
                           "Please make sure you provided the correct path/filename.", _
                           "File not found - AKLib", _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Checks to see if the user entered the correct path to the SimpleUpdater executable
        If Not File.Exists(pathToSimpleUpdater) Then
            MessageBox.Show("The SimpleUpdater executable could not be found." & _
                            Environment.NewLine & _
                           "Please make sure you provided the correct path/filename.", _
                           "File not found - AKLib", _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Files are downloaded to this path
        Dim tempPath As String = My.Computer.FileSystem.SpecialDirectories.Temp

        Try
            'The path the textfile with the update-info is downloaded to
            Dim pathDownloadTo As String = Path.Combine(tempPath, "simpleupdates_info.txt")

            'Try to download the textfile with the update-info into the path the user entered
            My.Computer.Network.DownloadFile(urlNewUpdatesList, _
                                             pathDownloadTo, "", "", False, 10000, True)

            'Creates a list we can add strings to
            Dim updates As New List(Of String)

            'Adds strings to the list we just created
            With updates
                .Add("[Caller]") 'Caller is the application SimpleUpdater will start after updating
                .Add(Path.Combine(My.Application.Info.DirectoryPath, _
                                  My.Application.Info.AssemblyName & ".exe"))
                .Add("[Compare]")
                .Add(pathPreDefinedList)
                .Add("[Updates]")
                .Add(My.Computer.FileSystem.ReadAllText(pathDownloadTo))
            End With

            'Create a new file in the temp-folder and write the update-info to it. 
            'This file will be used by SimpleUpdater.exe
            Using sw As StreamWriter = New StreamWriter(Path.Combine(tempPath, _
                                                                     "updates_new.txt"))
                For Each update In updates
                    sw.WriteLine(update)
                Next
            End Using

        Catch ex As Exception
            'Downloading failed, this might show what caused the error
            MessageBox.Show(Err.Description)
            Exit Sub

        End Try

        'Create a new instance of ProcessStartInfo
        Dim startInfo As New ProcessStartInfo(pathToSimpleUpdater)

        'Pass an argument to SimpleUpdater. SimpleUpdater won't start without this argument.
        startInfo.Arguments = "/runupdate"

        'Start SimpleUpdater
        Process.Start(startInfo)

        'Exit the current application while SimpleUpdate.Exe installs the updates
        Application.Exit()

    End Sub

End Class




