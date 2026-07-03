Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMerrorreporting
        ' Private Catcher As New Ladybug.Log.Fields
        Private ResumeNext As Boolean

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub New(proLog As Ladybug.Log.Fields, Optional dbengine As Database.Engine.SQLiteV3 = Nothing)
            InitializeComponent()
            Me.Text = "INGRID - Error Reporting"
            SLFNamaForm.Text = "Error Reporting"
            SLFSubNamaForm.Text = "A simple diagnostic tool for logging exceptions"

            TxtErrorType.Text = proLog.TypeOfFaulty.ToString()
            TxtErrorMessage.Text = proLog.Message & System.Environment.NewLine & System.Environment.NewLine & "Sender: " & proLog.FromSender
            If proLog.Query <> String.Empty AndAlso proLog.AppVersion = "0.0.0.0" Then
                TxtErrorMessage.AppendText(System.Environment.NewLine & System.Environment.NewLine & "Query: " & proLog.Query)
            End If
            TxtErrorNumber.Text = CStr(proLog.Number)
            TxtAppBuild.Text = proLog.AppVersion
            ChkErrorReporting.Enabled = proLog.ShowErrorReporting
            ResumeNext = proLog.ResumeNext

            Dim varMessage As String

            ' Send Error to Ingrid Log Center
            If (proLog.SaveInBetterLog) Then
                varMessage = """message"" : """ & proLog.Message & """," & Environment.NewLine & """sender"" : """ & proLog.FromSender & """," & Environment.NewLine & """error_number"" : " & proLog.Number & "," & Environment.NewLine & """error_type"" : """ & proLog.TypeOfFaulty.ToString() & """," & Environment.NewLine & """log_type"" : """ & proLog.TypeOfLog.ToString() & """," & Environment.NewLine & """version"" : """ & proLog.AppVersion & ""","
                Bridge.Security.Writelog.Sendlog(varMessage, proLog.TypeOfLog.ToString())
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
            Me.Dispose()
            If Not (ResumeNext) Then
                Process.GetCurrentProcess.Kill()
            End If
        End Sub
    End Class
End Namespace