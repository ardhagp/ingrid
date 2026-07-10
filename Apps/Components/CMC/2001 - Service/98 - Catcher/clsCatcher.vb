Namespace Ladybug.Log
    ''' <summary>
    ''' Fields structure is used to store various properties related to logging, such as the sender of the log, the type of fault, the message, the error number, the query, the application version, and other settings.
    ''' </summary>
    Public Structure Fields
        Public Property FromSender As String
        Public Property TypeOfFaulty As TypeOfFaulties
        Public Property Message As String
        Public Property Number As Integer
        Public Property Query As String
        Public Property AppVersion As String
        Public Property ShowErrorReporting As Boolean
        Public Property SaveLogInLocal As Boolean
        Public Property ResumeNext As Boolean
        Public Property InternalStackTrace As String

        ''' <summary>
        ''' TypeOfFaulties enum is used to categorize the type of fault that occurred in the application, such as support service database engine, support service SOAP, support service web, or application runtime.
        ''' </summary>
        Public Enum TypeOfFaulties
            None = 0
            SupportServiceDatabaseEngine = 20010102
            SupportServiceSOAP = 200102
            SupportServiceWeb = 200103
            ApplicationRunTime = 100100
        End Enum

        Public Property TypeOfLog As TypeOfLogs

        ''' <summary>
        ''' TypeOfLogs enum is used to categorize the type of log that is being recorded, such as information, warning, fatal, error, or debug.
        ''' </summary>
        Public Enum TypeOfLogs
            Information
            Warning
            Fatal
            [Error]
            [Debug]
        End Enum

        Public Property SaveInBetterLog As Boolean
    End Structure

    ''' <summary>
    ''' Events class is used to handle events related to logging, such as displaying the error reporting form and sending logs to the appropriate destination.
    ''' </summary>
    Public Class Events

        Public WithEvents FRMerc As New CMCv.UI.Canvas.FRMerrorreporting
        Private ReadOnly clsDBsqlite As Database.Engine.SQLiteV3

        ''' <summary>
        ''' Initializes a new instance of the Events class with the specified SQLite database engine.
        ''' </summary>
        ''' <param name="proLog"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub ShowData(proLog As Ladybug.Log.Fields)
            Dim varMessage As String

            If Not (proLog.ShowErrorReporting) Then
                varMessage = """message"" : """ & proLog.Message & """," & Environment.NewLine & """sender"" : """ & proLog.FromSender & """," & Environment.NewLine & """error_number"" : " & proLog.Number & "," & Environment.NewLine & """error_type"" : """ & proLog.TypeOfFaulty.ToString() & """," & Environment.NewLine & """log_type"" : """ & proLog.TypeOfLog.ToString() & """," & Environment.NewLine & """version"" : """ & proLog.AppVersion & ""","
                Bridge.Writelog.Sendlog(varMessage, proLog.TypeOfLog.ToString())
            Else
                FRMerc = New CMCv.UI.Canvas.FRMerrorreporting(proLog, clsDBsqlite)
                FRMerc.ShowDialog()
                FRMerc.Dispose()
            End If

            If Not (proLog.ResumeNext) Then
                Process.GetCurrentProcess.Kill()
            End If
        End Sub
    End Class
End Namespace