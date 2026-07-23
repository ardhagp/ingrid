Namespace Ladybug.Log
    ''' <summary>
    ''' The Fields structure is used to define the properties of a log entry, including the sender, type of fault, message, error number, query, application version, and various flags for error reporting and logging behavior.
    ''' </summary>
    Public Structure Fields
        ''' <summary>
        ''' The FromSender property represents the source or sender of the log entry, indicating where the log originated from.
        ''' </summary>
        ''' <returns>The source or sender of the log entry.</returns>
        Public Property FromSender As String

        ''' <summary>
        ''' The TypeOfFaulty property represents the type of fault that occurred in the application.
        ''' </summary>
        ''' <returns>The type of fault that occurred in the application.</returns>
        Public Property TypeOfFaulty As TypeOfFaulties

        ''' <summary>
        ''' The Message property represents the message associated with the log entry, providing details about the event or error that occurred.
        ''' </summary>
        ''' <returns>The message associated with the log entry.</returns>
        Public Property Message As String

        ''' <summary>
        ''' The Number property represents the error number associated with the log entry, providing a unique identifier for the specific error that occurred.
        ''' </summary>
        ''' <returns>The error number associated with the log entry.</returns>
        Public Property Number As Integer

        ''' <summary>
        ''' The Query property represents the SQL query associated with the log entry, providing context for database-related events or errors that occurred.
        ''' </summary>
        ''' <returns>The SQL query associated with the log entry.</returns>
        Public Property Query As String

        ''' <summary>
        ''' The AppVersion property represents the version of the application where the log entry was generated, providing context for the specific build or release of the software.
        ''' </summary>
        ''' <returns>The version of the application where the log entry was generated.</returns>
        Public Property AppVersion As String

        ''' <summary>
        ''' The ShowErrorReporting property indicates whether the error reporting form should be displayed to the user when an error occurs, allowing them to provide feedback or report the issue.
        ''' </summary>
        ''' <returns>True if the error reporting form should be displayed; otherwise, false.</returns>
        Public Property ShowErrorReporting As Boolean

        ''' <summary>
        ''' The SaveLogInLocal property indicates whether the log entry should be saved locally on the user's machine, allowing for offline access and troubleshooting of application issues.
        ''' </summary>
        ''' <returns>True if the log entry should be saved locally; otherwise, false.</returns>
        Public Property SaveLogInLocal As Boolean

        ''' <summary>
        ''' The ResumeNext property indicates whether the application should continue executing after an error occurs, allowing for graceful error handling and recovery without crashing the application.
        ''' </summary>
        ''' <returns>True if the application should continue executing after an error occurs; otherwise, false.</returns>
        Public Property ResumeNext As Boolean

        ''' <summary>
        ''' The InternalStackTrace property represents the internal stack trace associated with the log entry, providing detailed information about the sequence of method calls that led to the error or event being logged.
        ''' </summary>
        ''' <returns>The internal stack trace associated with the log entry.</returns>
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

        ''' <summary>
        ''' The TypeOfLog property represents the type of log entry being recorded, such as information, warning, fatal, error, or debug, allowing for categorization and filtering of log entries based on their severity or purpose.
        ''' </summary>
        ''' <returns>The type of log entry being recorded.</returns>
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

        ''' <summary>
        ''' The SaveInBetterLog property indicates whether the log entry should be saved in a more structured and organized format, allowing for easier analysis and reporting of application issues.
        ''' </summary>
        ''' <returns>True if the log entry should be saved in a more structured and organized format; otherwise, false.</returns>
        Public Property SaveInBetterLog As Boolean
    End Structure

    ''' <summary>
    ''' The Events class is responsible for handling log events and displaying error reporting forms when necessary. It provides functionality to show log data, send logs to a logging service, and manage the application's behavior after an error occurs.
    ''' </summary>
    Public Class Events

        Public WithEvents FRMerc As New CMCv.UI.Canvas.FRMerrorreporting
        Private ReadOnly clsDBsqlite As Database.Engine.SqliteV3

        ''' <summary>
        ''' Initializes a new instance of the Events class with the specified SQLite database engine.
        ''' </summary>
        ''' <param name="proLog">The log fields containing information about the log entry.</param>
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