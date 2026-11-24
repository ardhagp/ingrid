Namespace UI
    Public Class FRMapplauncher
        Inherits System.Windows.Forms.Form

        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Private WithEvents Frm_mainframe6 As Ingrid.UI.Canvas.FRMmainframe6
        Private WithEvents Frm_conn As Connect.UI.Canvas.FRMconn

        Private varIsReturned As Boolean = False
        Private varSecond As Integer = 5
        Private varDownloadDB As String = "Update"
        Private varCaptionDownloadDB As String = "- press Download button"
        Private varLabelApp As String = "Opening"
        Private varLabelCountdown As String = $"app in {varSecond} seconds..."
        Private Const varItemLocalDB As String = "Local DB"


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' Handles the Load event of the FRMappLauncher form. This event is triggered when the form is loaded, and it initializes the application by activating licenses, ensuring the database exists, downloading the catalog if necessary, and setting up the UI elements such as labels and combo box items.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Async Sub FRMappLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call ActivateLicenses()

            Dim baseFolder = IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ardhagp\Ingrid .NET")

            Dim resourcesFolder = IO.Path.Combine(baseFolder, "Resources")
            IO.Directory.CreateDirectory(resourcesFolder)

            Dim dbok = EnsureDbExists($"Resources\catalog.db", baseFolder)

            If Not dbok Then
                Await DownloadCatalogAsync()
            End If

            With proLog
                .AppVersion = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}.{My.Application.Info.Version.Revision}"
                .FromSender = "$\IngridLauncher\030. FOrm\000. Launcher\App Launcher.vb"
                .InternalStackTrace = ""
                .Message = "Ingrid Launcher started."
                .Number = 0
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = True
                .ShowErrorReporting = False
                .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Information
            End With

            Dim clsLog As New CMCv.Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing

            LblBuild.Text = $"Ver. {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}" & Environment.NewLine & $"Build {My.Application.Info.Version.Build}"
            LblVersion.Text = $"Rev. {My.Application.Info.Version.Revision}"
            varSecond = 4
            LblRight.Text = varLabelCountdown

            With CboApplication.Items
                .Add("Connect")
                .Add("Ingrid")
                .Add(varItemLocalDB)
            End With
            CboApplication.SelectedIndex = My.Settings.DefaultApp

            tmrCountdown.Enabled = True
        End Sub

        ''' <summary>
        ''' Handles the EventMainframeClose event of the Frm_mainframe6 form. This event is triggered when the mainframe form is closed, and it closes the launcher form as well.
        ''' </summary>
        Private Sub Frmmainframe6_IngridFrameClose() Handles Frm_mainframe6.EventMainframeClose
            Close()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the BtnLaunch button. When clicked, it calls the LaunchApp function to launch the selected application or download the configuration file if "Local DB" is selected.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Async Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles BtnLaunch.Click
            Await LaunchApp()
        End Sub

        ''' <summary>
        ''' Launches the selected application based on the current selection in the CboApplication ComboBox. If "Local DB" is selected, it prompts the user for confirmation to download and replace the current configuration file. If confirmed, it calls the DownloadCatalogAsync function to download the new configuration file. Otherwise, it calls the OpenApp function to launch the selected application.
        ''' </summary>
        ''' <returns></returns>
        Private Async Function LaunchApp() As Task
            If CboApplication.Text = varItemLocalDB Then
                If Decision("Confirmation", $"Do you want to download and replace current configuration file with new configuration file format?", LibApp.Ingrid.Global.PopupType.Confirmation, "Update your existing configuration file format", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                    Await DownloadCatalogAsync()
                End If
            Else
                Call OpenApp(CboApplication.SelectedIndex)
            End If
        End Function

        ''' <summary>
        ''' Handles the Tick event of the tmrCountdown timer. Decrements the countdown seconds and updates the label text accordingly. If the countdown reaches zero, it calls the OpenApp function to launch the selected application.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub TmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
            varSecond -= 1

            If (varSecond = 0) Then
                Call OpenApp(CboApplication.SelectedIndex)
            ElseIf (varSecond > 1) Then
                varLabelCountdown = $"app in {varSecond} seconds..."
            Else
                varLabelCountdown = $"app in {varSecond} second..."
            End If
            LblRight.Text = varLabelCountdown
        End Sub

        ''' <summary>
        ''' Handles the ConnectFrameClose event of the Frm_conn form. This event is triggered when the connection settings frame is closed. It disposes of the Frm_conn form, resets the labels and button text, and shows the main launcher form again. It also checks if "Local DB" is in the application list and removes it if present.
        ''' </summary>
        Private Sub Frmconn_ConnectFrameClose() Handles Frm_conn.ConnectFrameClose
            varIsReturned = True
            Frm_conn.Dispose()
            Frm_conn = Nothing
            Me.Show()
            Dim i As Integer = 0
            varLabelCountdown = "- press Launch"
            varLabelApp = "Open"
            LblRight.Text = varLabelCountdown
            LblLeft.Text = varLabelApp
            For Each item In CboApplication.Items
                If item.ToString() = varItemLocalDB Then
                    i += 1
                End If
            Next
            If i > 0 Then
                With CboApplication.Items
                    .Remove(varItemLocalDB)
                End With
            End If
            BtnClose.Visible = True
        End Sub


        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' Handles the SelectedIndexChanged event for the CboApplication ComboBox. Updates the labels and button text based on the selected application. If "Local DB" is selected, it changes the labels to indicate a download action; otherwise, it sets them for launching an application. It also enables or disables the countdown timer based on the selection.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CboApplication_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboApplication.SelectedIndexChanged
            If CboApplication.Text = varItemLocalDB Then
                LblLeft.Text = varDownloadDB
                LblRight.Text = varCaptionDownloadDB
                BtnLaunch.Text = "Download"
                BtnLaunch.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
                tmrCountdown.Enabled = False
            Else
                LblLeft.Text = varLabelApp
                LblRight.Text = varLabelCountdown
                BtnLaunch.Text = "Launch"
                BtnLaunch.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
                If varIsReturned Then
                    tmrCountdown.Enabled = False
                Else
                    tmrCountdown.Enabled = True
                End If

            End If
        End Sub

        ''' <summary>
        ''' Handles the KeyPress event for the CboApplication ComboBox. If the Enter key is pressed, it calls the LaunchApp function to launch the selected application.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Async Sub CboApplication_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboApplication.KeyPress
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                Await LaunchApp()
            End If
        End Sub

        ''' <summary>
        ''' Closes the application when the close button is clicked.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Close()
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' Downloads the catalog.db file from the specified URL and saves it to the user's Documents folder.
        ''' </summary>
        ''' <returns></returns>
        Public Async Function DownloadCatalogAsync() As Task
            Using client As New System.Net.Http.HttpClient()
                Try
                    varCloudstorageUrl = My.Settings.CloudstorageUrl
                    Dim url As String = varCloudstorageUrl & "conf/catalog.db"
                    Dim savePath As String = IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ardhagp\Ingrid .NET\Resources",
                    "catalog.db"
                )

                    ' Send HEAD request first to check if file exists
                    Dim headResponse = Await client.GetAsync(url, System.Net.Http.HttpCompletionOption.ResponseHeadersRead) '(headRequest)

                    If Not headResponse.IsSuccessStatusCode Then
                        Decision("Error", $"Failed to download catalog.db. The file does not exist at the specified URL: {url}", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                        Return
                    End If

                    Dim data As Byte() = Await client.GetByteArrayAsync(url)
                    IO.File.WriteAllBytes(savePath, data)
                Catch ex As Exception
                    With proLog
                        .AppVersion = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}.{My.Application.Info.Version.Revision}"
                        .FromSender = "$\IngridLauncher\030. FOrm\000. Launcher\App Launcher.vb"
                        .InternalStackTrace = ""
                        .Message = "Download catalog.db failed."
                        .Number = 0
                        .ResumeNext = True
                        .SaveInBetterLog = True
                        .SaveLogInLocal = True
                        .ShowErrorReporting = False
                        .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                        .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Error
                    End With

                    Dim clsLog As New CMCv.Ladybug.Log.Events
                    clsLog.ShowData(proLog)
                    clsLog = Nothing
                End Try
            End Using
        End Function

        ''' <summary>
        ''' Opens the selected application based on the provided index. If the index is 0, it opens the connection settings form; if the index is 1, it opens the mainframe form. It also saves the selected application index to user settings.
        ''' </summary>
        ''' <param name="appnameindex"></param>
        Private Sub OpenApp(appnameindex As Integer)
            Try
                tmrCountdown.Enabled = False
                My.Settings.DefaultApp = appnameindex
                My.Settings.Save()

                If appnameindex = 0 Then
                    tmrCountdown.Enabled = False
                    Frm_conn = New Connect.UI.Canvas.FRMconn
                    Display(Frm_conn, , "INGRID - CONNECTION SETTINGS", "Connection Settings", "Manage your database connection settings", False)
                ElseIf appnameindex = 1 Then
                    Frm_mainframe6 = New Ingrid.UI.Canvas.FRMmainframe6
                    Frm_mainframe6.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Ensures that the specified database file exists in the target folder. If the file does not exist, it copies it from the source folder to the target folder. Returns True if the file exists after the operation, otherwise returns False.
        ''' </summary>
        ''' <param name="relativepath">The relative path of the database file.</param>
        ''' <param name="basefolder">The base folder where the database file should exist.</param>
        ''' <returns>True if the database file exists after the operation, otherwise False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Function EnsureDbExists(relativepath As String, basefolder As String) As Boolean
            Dim targetPath = IO.Path.Combine(basefolder, relativepath)
            Dim sourcePath = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, relativepath)

            If Not IO.File.Exists(targetPath) Then
                IO.File.Copy(sourcePath, targetPath, True)
            End If

            Return IO.File.Exists(targetPath)
        End Function


        ' ---------------------------------------------------------
        ' Addins or External Forms Events Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This handle will be triggered when mainframe opened
        ''' </summary>
        Private Sub Frmmainframe6_IngridFrameOpen() Handles Frm_mainframe6.EventMainframeOpen
            Close()
        End Sub

        ''' <summary>
        ''' This handle will be triggered when connection setting opened
        ''' </summary>
        Private Sub Frmconn_ConnectFrameOpen() Handles Frm_conn.ConnectFrameOpen
            Hide()
        End Sub
    End Class
End Namespace