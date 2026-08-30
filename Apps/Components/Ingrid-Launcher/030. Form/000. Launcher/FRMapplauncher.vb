Namespace UI
    Public Class FRMapplauncher
        Inherits System.Windows.Forms.Form

        Private WithEvents Frm_mainframe6 As Ingrid.UI.Canvas.FRMmainframe6
        Private WithEvents Frm_conn As Connect.UI.Canvas.FRMconn

        Private varIsReturned As Boolean = False
        Private varSecond As Integer = 5
        Private varDownloadDB As String = "Update"
        Private varCaptionDownloadDB As String = "- press Download button"
        Private varLabelApp As String = "Opening"
        Private varLabelCountdown As String = $"app in {varSecond} seconds..."
        Private Const varItemLocalDB As String = "Local DB"

        Private Async Sub FRMappLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Call ActivateLicenses()
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

        Private Async Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles BtnLaunch.Click
            If CboApplication.Text = varItemLocalDB Then
                If Decision("Confirmation", $"Do you want to download and replace current configuration file with new configuration file format?", LibApp.Ingrid.Global.PopupType.Confirmation, "Update your existing configuration file format", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                    Await DownloadCatalogAsync()
                End If
            Else
                Call OpenApp(CboApplication.SelectedIndex)
            End If
        End Sub

        Private Sub Frmmainframe6_IngridFrameClose() Handles Frm_mainframe6.EventMainframeClose
            Close()
        End Sub

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

        Private Sub OpenApp(appnameindex As Integer)
            Try
                tmrCountdown.Enabled = False
                My.Settings.DefaultApp = appnameindex
                My.Settings.Save()

                If appnameindex = 0 Then
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

        Private Sub Frmmainframe6_IngridFrameOpen() Handles Frm_mainframe6.EventMainframeOpen
            Close()
        End Sub

        Private Sub Frmconn_ConnectFrameOpen() Handles Frm_conn.ConnectFrameOpen
            Hide()
        End Sub

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Close()
        End Sub

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
                        Decision("Error", $"Failed to download catalog.db. The file does not exist at the specified URL: {url}", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Function EnsureDbExists(relativepath As String, basefolder As String) As Boolean
            Dim targetPath = IO.Path.Combine(basefolder, relativepath)
            Dim sourcePath = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, relativepath)

            If Not IO.File.Exists(targetPath) Then
                IO.File.Copy(sourcePath, targetPath, True)
            End If

            Return IO.File.Exists(targetPath)
        End Function
    End Class
End Namespace