Imports System.Runtime.Versioning

Public Class frmErrorReporting
    'Private Catcher As New Catcher.Error.Fields
    Public ResumeNext As Boolean

    'Private ERL As New Database.Engine.LocalDB
    Private ERL As New Database.Engine.SQLiteV3

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub New(ByVal ErrorCatcher As Catcher.Error.Fields, Optional ByVal DBEngine As Database.Engine.SQLiteV3 = Nothing)
        InitializeComponent()
        TxtErrorType.Text = TypeOfFaultiesConverter(ErrorCatcher)
        TxtErrorMessage.Text = ErrorCatcher.Message & System.Environment.NewLine & System.Environment.NewLine & "Sender: " & ErrorCatcher.FromSender
        TxtErrorNumber.Text = ErrorCatcher.Number
        TxtAppBuild.Text = ErrorCatcher.AppVersion
        ChkErrorReporting.Enabled = ErrorCatcher.EnableErrorReporting
        ResumeNext = ErrorCatcher.ResumeNext

        'Send Error to Ingrid Log Center
        Bridge.Security.WRITELOG.SENDLOG(TxtErrorMessage.Text & Environment.NewLine & "Error Number: " & TxtErrorNumber.Text & Environment.NewLine & "Error Type: " & TxtErrorType.Text & Environment.NewLine & "App Build: " & TxtAppBuild.Text, Bridge.Security.WRITELOG.LogType.Error)

        'Record Error into local database
        If (ErrorCatcher.SaveError) Then
            If DBEngine Is Nothing Then
                Return
            End If
            ERL = DBEngine
            ERL.Open()
            ERL.SaveErrorData(ErrorCatcher)
        End If


        'Tbctl1.TabPages.RemoveByKey("tp_SystemInformation")

    End Sub

    Private Function TypeOfFaultiesConverter(ByVal ErrorCatcher As Catcher.Error.Fields) As String
        Dim Result As String = ""
        Select Case ErrorCatcher.Type
            Case CType(20010102, Catcher.Error.Fields.TypeOfFaulties)
                Result = "SupportServiceDatabaseEngine"
            Case CType(200102, Catcher.Error.Fields.TypeOfFaulties)
                Result = "SupportServiceSOAP"
            Case CType(200103, Catcher.Error.Fields.TypeOfFaulties)
                Result = "SupportServiceWeb"
            Case CType(100100, Catcher.Error.Fields.TypeOfFaulties)
                Result = "ApplicationRunTime"
        End Select

        Return Result
    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
        Me.Dispose()
        If Not (ResumeNext) Then
            'put your code here
        End If
    End Sub
End Class
