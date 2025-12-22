Imports Ingrid
Imports Connect

Public Class App_Launcher
    Private WithEvents IngridMainframe As New Mainframe_n_6
    Private WithEvents ConnectMainframe As New CONN

    Private V_BRIDGE As New Bridge.Security.WRITELOG

    Private Var_Second As Integer

    Private Sub App_Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bridge.Security.WRITELOG.SENDLOG("Ingrid Launcher started." & Environment.NewLine & "--- App Ver. " & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision & " ---", Bridge.Security.WRITELOG.LogType.Information)

        Call ActivateLicenses()

        LblBuild.Text = String.Format("Build {0}" & Environment.NewLine & "Rev. {1}", My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        Var_Second = 4
        LblCountdown.Text = String.Format("app in {0} seconds...", Var_Second)

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

    Private Sub IngridMainframe_IngridFrameClose() Handles IngridMainframe.IngridFrameClose
        Me.Close()
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick
        Var_Second -= 1

        If (Var_Second = 0) Then
            Call OpenApp(CboApplication.SelectedIndex)
            tmrCountdown.Enabled = False
        ElseIf (Var_Second > 1) Then
            LblCountdown.Text = String.Format("app in {0} seconds...", Var_Second)
        Else
            LblCountdown.Text = String.Format("app in {0} second...", Var_Second)
        End If
    End Sub

    Private Sub OpenApp(ByVal AppNameIndex As Integer)
        Try
            If AppNameIndex = 0 Then
                ConnectMainframe.Show()
            ElseIf AppNameIndex = 1 Then
                IngridMainframe.Show()
            End If
            My.Settings.DefaultApp = AppNameIndex
            My.Settings.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConnectMainframe_ConnectFrameClose() Handles ConnectMainframe.ConnectFrameClose
        ConnectMainframe.Dispose()
        LblCountdown.Text = "by clicking Launch button"
        Me.Show()
        BtnClose.Visible = True
    End Sub

    Private Sub IngridMainframe_IngridFrameOpen() Handles IngridMainframe.IngridFrameOpen
        Me.Close()
    End Sub

    Private Sub ConnectMainframe_ConnectFrameOpen() Handles ConnectMainframe.ConnectFrameOpen
        Me.Hide()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class