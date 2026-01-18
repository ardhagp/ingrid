Imports System.Runtime.Versioning

Namespace Ladybug.Log
    Public Structure Fields
        Public Property FromSender As String
        Public Property TypeOfFaulty As TypeOfFaulties
        Public Property Message As String
        Public Property Number As Integer
        Public Property AppVersion As String
        Public Property ShowErrorReporting As Boolean
        Public Property SaveLogInLocal As Boolean
        Public Property ResumeNext As Boolean
        Public Property InternalStackTrace As String

        Public Enum TypeOfFaulties
            None = 0
            SupportServiceDatabaseEngine = 20010102
            SupportServiceSOAP = 200102
            SupportServiceWeb = 200103
            ApplicationRunTime = 100100
        End Enum

        Public Property TypeOfLog As TypeOfLogs

        Public Enum TypeOfLogs
            Information
            Warning
            Fatal
            [Error]
            [Debug]
        End Enum
        Public Property SaveInBetterLog As Boolean
    End Structure

    Public Class Events

        Public WithEvents frmERC As New frmErrorReporting
        Private clsDBsqlite As Database.Engine.SQLiteV3

        ''' <summary>
        ''' Display Error Reporting Form
        ''' </summary>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Sub ShowData(ByVal proLog As Ladybug.Log.Fields)
            If Not (proLog.ShowErrorReporting) Then
                Bridge.Security.Writelog.Sendlog("""message"" : """ & proLog.Message & """," & Environment.NewLine & """sender"" : """ & proLog.FromSender & """," & Environment.NewLine & """error_number"" : " & proLog.Number & "," & Environment.NewLine & """error_type"" : """ & proLog.TypeOfFaulty.ToString() & """," & Environment.NewLine & """log_type"" : """ & proLog.TypeOfLog.ToString() & """," & Environment.NewLine & """version"" : """ & proLog.AppVersion & """,", proLog.TypeOfLog.ToString())
                Return
            End If

            frmERC = New CMCv.frmErrorReporting(proLog, If(proLog.SaveLogInLocal, Nothing, clsDBsqlite))
            frmERC.ShowDialog()

            If Not (frmERC.ResumeNext) Then
                Process.GetCurrentProcess.Kill()
                Return
            End If

            frmERC.Dispose()
        End Sub
    End Class
End Namespace