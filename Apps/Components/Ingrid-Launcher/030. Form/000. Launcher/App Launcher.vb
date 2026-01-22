Imports Ingrid
Imports Connect

Public Class FRMapplauncher
    Private WithEvents IngridMainframe As New FRMmainframe6
    Private WithEvents Frm_conn As New FRMconn

    Private varSecond As Integer
    Private varVersion As String

    Private Sub App_Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BtnLaunch_Click(sender As Object, e As EventArgs)
        OpenApp(CboApplication.SelectedIndex)
    End Sub

    Private Sub IngridMainframe_IngridFrameClose() Handles IngridMainframe.IngridFrameClose
        Me.Close()
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        varSecond -= 1

        If (varSecond = 0) Then
            Call OpenApp(CboApplication.SelectedIndex)
            tmrCountdown.Enabled = False
        ElseIf (varSecond > 1) Then
            LblCountdown.Text = String.Format("app in {0} seconds...", varSecond)
        Else
            LblCountdown.Text = String.Format("app in {0} second...", varSecond)
        End If
    End Sub

    Private Sub OpenApp(appNameindex As Integer)
        Try
            If appNameindex = 0 Then
                Frm_conn.Show()
            ElseIf appNameindex = 1 Then
                IngridMainframe.Show()
            End If
            My.Settings.DefaultApp = appNameindex
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConnectMainframe_ConnectFrameClose() Handles Frm_conn.ConnectFrameClose
        Frm_conn.Dispose()
        LblCountdown.Text = "by clicking Launch button"
        Me.Show()
        BtnClose.Visible = True
    End Sub

    Private Sub IngridMainframe_IngridFrameOpen() Handles IngridMainframe.IngridFrameOpen
        Me.Close()
    End Sub

    Private Sub ConnectMainframe_ConnectFrameOpen() Handles Frm_conn.ConnectFrameOpen
        Me.Hide()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub App_Launcher_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class