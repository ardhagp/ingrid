'    SimpleUpdater by Arve Kjønsvik
'           Used by AKLib
'    E-mail: a_kjonsvik@hotmail.com
'    ''''''''''''''''''''''''''''''
'    Modified by:
'    
'    Credits to:
'      Zeljko    at vbforums.com
'      chris128  at vbforums.com
'
'    Version history:
'      Project started: July, 20th 2010
'       v1.0.0.0    -   First release

Option Strict On

Imports System.IO

Public Class frmMain

#Region "Variables"
    Dim listUpdates As New List(Of String)
    Dim workerIsDone As Boolean = False
    Dim updatingFile As Boolean = False
    Dim updatingFilePath As String = String.Empty
    Dim callerPath As String = String.Empty
    Dim compareFile As String = String.Empty
#End Region

    Private Sub frmMain_FormClosing(ByVal sender As Object, _
                                    ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                    Handles Me.FormClosing

        'If variable workerIsDone = True, the 'caller' will be 
        'started when SimpleUpdater is closing
        If workerIsDone Then Process.Start(callerPath)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, _
                             ByVal e As System.EventArgs) _
                             Handles MyBase.Load

        'Close the application if started with no arguments
        If My.Application.CommandLineArgs.Count = 0 Then
            MessageBox.Show("No arguments provided.", _
                            My.Application.Info.AssemblyName, _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        'Getting the arguments
        For Each argument In My.Application.CommandLineArgs
            Select Case My.Application.CommandLineArgs.Item(0).ToLower
                Case "/runupdate"
                    'The files downloaded by AKLib.SimpleUpdater is stored in this path
                    Dim tempPath As String = My.Computer.FileSystem.SpecialDirectories.Temp

                    'Read the update-file made by AKLib.SimpleUpdater
                    Using sr As StreamReader = New StreamReader(Path.Combine(tempPath, _
                                                                "updates_new.txt"))
                        Do Until sr.EndOfStream
                            listUpdates.Add(sr.ReadLine)
                        Loop
                    End Using

                    'Now we will work with and remove some of the information in the list we created
                    With listUpdates
                        'NOTE: This will only work with the current structure of the 'update_new.txt-file'.
                        'If the structure of the file is changed, then this should probably be changed as well!
                        .RemoveAt(0)            '[Caller]
                        callerPath = .Item(0)   'Path. Assign to 'callerPath'
                        .RemoveAt(0)            'Remove the path
                        .RemoveAt(0)            '[Compare]
                        compareFile = .Item(0)  'Path. Assign to 'compareFile'
                        .RemoveAt(0)            'Remove the path
                        .RemoveAt(0)            '[Updates]
                        'The list should now only contain information about the files that might be updated
                    End With

                    'Starting the BackgroundWorker
                    worker.RunWorkerAsync()

                Case Else
                    'Incorrect argument
                    MessageBox.Show("Incorrect argument.", My.Application.Info.AssemblyName, _
                                                           MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()

            End Select
        Next

    End Sub

    Private Sub worker_DoWork(ByVal sender As System.Object, _
                              ByVal e As System.ComponentModel.DoWorkEventArgs) _
                              Handles worker.DoWork

        'Looping through the files to find out if they need to update
        For Each update As String In listUpdates
            'If compareFiles returns True, a update is available
            If compareFiles(update) = True Then
                Dim updateName As String = String.Empty
                Dim updateVersion As String = String.Empty
                Dim updateURL As String = String.Empty

                'Splitting up the updatefile, to make it easier to work with
                Dim splitUpdateFile As New List(Of String)
                splitUpdateFile.AddRange(update.Split(CType(",", Char)))

                'Assigns values from the updatefile
                updateName = splitUpdateFile(0)
                updateVersion = splitUpdateFile(1)
                updateURL = splitUpdateFile(2)

                'Download and install the updates
                Try
                    'Add a new item to the Listbox in frmMain
                    Me.lstUpdate.Items.Add( _
                        Date.Now & " - Updating " & updateName & " to version " & updateVersion)

                    'Downloading
                    My.Computer.Network.DownloadFile(updateURL, _
                                                     Path.Combine(updatingFilePath, updateName), _
                                                     "", "", False, 10000, True)

                Catch ex As Exception
                    Me.lstUpdate.Items.Add(Date.Now & " - " & ex.Message)

                End Try

                'A update has been installed
                updatingFile = True

            End If
        Next

        'In no update has been installed, this line is added to the Listbox
        If updatingFile = False Then Me.lstUpdate.Items.Add( _
            Date.Now & " - All of your files were up to date.")

    End Sub

    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, _
                                          ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
                                          Handles worker.RunWorkerCompleted
        workerIsDone = True

        Me.lstUpdate.Items.Add(Date.Now & " - Done! Click 'OK' to continue...")

        Me.btnOK.Text = "OK"
        Me.btnOK.Enabled = True

    End Sub

    ''' <summary>
    ''' Compares the files in the update-list with the files in the new updates-list
    ''' </summary>
    ''' <param name="fileToCompare">The file that is compared</param>
    ''' <returns>True if file needs to update</returns>
    Private Function compareFiles(ByVal fileToCompare As String) As Boolean
        Dim compareList As New List(Of String)
        Dim updateNeeded As Boolean = False

        'Put the contents of the file into 'compareList'
        Using sr As StreamReader = New StreamReader(compareFile)
            Do Until sr.EndOfStream
                compareList.Add(sr.ReadLine)
            Loop
        End Using

        'Scan through compareList
        For Each file In compareList
            Dim name As String = String.Empty
            Dim version As String = String.Empty

            'Splitting up the fileinfo that we are comparing with the 
            'fileinfo from the update-file
            Dim splitFileInfo As New List(Of String)
            splitFileInfo.AddRange(file.Split(CType(",", Char)))

            'Filename, version and the path(file) of the fileinfo we are comparing
            name = splitFileInfo(0)
            version = splitFileInfo(1)
            updatingFilePath = splitFileInfo(2)

            'If the filename we got from splitting, is the same as the
            'one thatwe are checking for update, then do the following
            'code. Else we are going to the next file if available
            If fileToCompare.ToLower.StartsWith(name.ToLower) Then

                'Splitting up the fileinfo from the update-file
                Dim splitUpdateFileInfo As New List(Of String)
                splitUpdateFileInfo.AddRange(fileToCompare.Split(CType(",", Char)))

                'We already know the name of the file that we are checking are correct, 
                'so we are removing it from the list
                splitUpdateFileInfo.RemoveAt(0)

                'Assign the version to a variable
                Dim versionUpdate As String = splitUpdateFileInfo(0)

                'Comparing the two versions
                '' Credits to: Zeljko and chris128 at vbforums.com
                Dim versionOld As New Version(version)
                Dim versionNew As New Version(versionUpdate)

                If versionNew > versionOld Then
                    'VersionNew is higher, so it's going to update
                    updateNeeded = True
                    Exit For
                Else
                    'VersionNew is the same or lower, so it's not going to update
                    updateNeeded = False
                    Exit For
                End If
                '' / Credits
            End If
        Next

        'Tells the BackgroundWorker to download and install a update
        Return updateNeeded

    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) _
                            Handles btnOK.Click
        Application.Exit()

    End Sub

End Class

