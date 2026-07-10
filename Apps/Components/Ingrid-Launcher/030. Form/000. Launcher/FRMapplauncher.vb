Namespace UI
    Public Class FRMapplauncher
        Private WithEvents Frm_mainframe6 As Ingrid.UI.Canvas.FRMmainframe6
        Private WithEvents Frm_conn As Connect.UI.Canvas.FRMconn

        Private varSecond As Integer
        Private varDownloadDB As String = "Update"
        Private varCaptionDownloadDB As String = "- press Download button"
        Private varLabelApp As String = "Opening"
        Private varLabelCountdown As String = $"app in {varSecond} seconds..."
        Private Const varItemLocalDB As String = "Local DB"

        Private Sub Frmapplauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            End With
            CboApplication.SelectedIndex = My.Settings.DefaultApp

            tmrCountdown.Enabled = True
        End Sub

        Private Sub BtnLaunch_Click(sender As Object, e As EventArgs) Handles BtnLaunch.Click
            If CboApplication.Text = varItemLocalDB Then
                If Decision("Do you want to download the latest database?", "Download Database", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                    MsgBox("")
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
                    Display(Frm_conn, , My.Application.Info.Title, "Connection Settings", "Manage your database connection settings", False)
                ElseIf appnameindex = 1 Then
                    Frm_mainframe6 = New Ingrid.UI.Canvas.FRMmainframe6
                    Frm_mainframe6.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub Frmconn_ConnectFrameClose() Handles Frm_conn.ConnectFrameClose
            Frm_conn.Dispose()
            Show()
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
            If i = 0 Then
                With CboApplication.Items
                    .Add(varItemLocalDB)
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
            Else
                LblLeft.Text = varLabelApp
                LblRight.Text = varLabelCountdown
                BtnLaunch.Text = "Launch"
                BtnLaunch.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
            End If
        End Sub
    End Class
End Namespace