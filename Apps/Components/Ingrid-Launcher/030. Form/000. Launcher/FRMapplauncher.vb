Namespace UI
    Public Class FRMapplauncher
        Private WithEvents Frm_mainframe6 As Ingrid.UI.FRMmainframe6
        Private WithEvents Frm_conn As New Connect.UI.FRMconn

        Private varSecond As Integer
        Private varVersion As String

        Private Sub Frmapplauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            varVersion = String.Format("{0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            With proLog
                .AppVersion = varVersion
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

            LblBuild.Text = String.Format("Build {0}" & Environment.NewLine & "Rev. {1}", My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
            varSecond = 4
            LblCountdown.Text = String.Format("app in {0} seconds...", varSecond)

            With CboApplication.Items
                .Add("Connect")
                .Add("Ingrid")
            End With
            CboApplication.SelectedIndex = My.Settings.DefaultApp

            tmrCountdown.Enabled = True
        End Sub

        Private Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles BtnLaunch.Click
            Call OpenApp(CboApplication.SelectedIndex)
        End Sub

        Private Sub Frmmainframe6_IngridFrameClose() Handles Frm_mainframe6.EventMainframeClose
            Close()
        End Sub

        Private Sub TmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
            varSecond -= 1

            If (varSecond = 0) Then
                Call OpenApp(CboApplication.SelectedIndex)
            ElseIf (varSecond > 1) Then
                LblCountdown.Text = String.Format("app in {0} seconds...", varSecond)
            Else
                LblCountdown.Text = String.Format("app in {0} second...", varSecond)
            End If
        End Sub

        Private Sub OpenApp(appnameindex As Integer)
            Try
                tmrCountdown.Enabled = False
                My.Settings.DefaultApp = appnameindex
                My.Settings.Save()

                If appnameindex = 0 Then
                    'Display(Frm_conn, IMAGEDB.Main.ImageLibrary.CONNECT_ICON, My.Application.Info.AssemblyName, "Connection Settings", "Manage your database connection settings", False)
                    Display(Frm_conn, , My.Application.Info.Title, "Connection Settings", "Manage your database connection settings", False)
                    'Frm_conn = New FRMconn()
                    'Frm_conn.Show()
                ElseIf appnameindex = 1 Then
                    Frm_mainframe6 = New Ingrid.UI.FRMmainframe6
                    Frm_mainframe6.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub Frmconn_ConnectFrameClose() Handles Frm_conn.ConnectFrameClose
            Frm_conn.Dispose()
            Show()
            LblCountdown.Text = "by clicking Launch button"
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
    End Class
End Namespace