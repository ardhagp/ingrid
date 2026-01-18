Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class MSAccess2003
        Private ReadOnly varConnectionstring(2) As String
        Private ReadOnly varFilepath(2) As String

        Private ReadOnly varConnection(2) As OleDb.OleDbConnection
        Private ReadOnly varCommand(2) As OleDb.OleDbCommand
        Private ReadOnly varDatareader(2) As OleDb.OleDbDataReader

        Private ReadOnly varMsa2003c As New Connect.MSAccess2003Connection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim vardbpath As String = Nothing
                Dim vardbexists(2) As Boolean

                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Resources")

                vardbpath = Application.StartupPath & "\Resources\CATALOG.mdb"
                If OperatingSystem.File.Info.IsExists(vardbpath) Then
                    vardbexists(1) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.catalog, True)
                    vardbexists(1) = False
                End If

                vardbpath = Application.StartupPath & "\Resources\DEV_CATALOG.mdb"
                If OperatingSystem.File.Info.IsExists(vardbpath) Then
                    vardbexists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.dev_catalog, True)
                    vardbexists(2) = False
                End If

                vardbpath = Application.StartupPath & "\Resources\ERRLOG.mdb"
                If OperatingSystem.File.Info.IsExists(vardbpath) Then
                    vardbexists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.errlog, True)
                    vardbexists(2) = False
                End If

                If (vardbexists(1)) AndAlso (vardbexists(2)) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal isproductionmode As Boolean = False)
            Try
                CheckDBCatalog()

                If (isproductionmode) Then
                    varFilepath(0) = Application.StartupPath & "\Resources\CATALOG.mdb"
                Else
                    varFilepath(0) = Application.StartupPath & "\Resources\DEV_CATALOG.mdb"
                End If

                Dim V_FileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(varFilepath(0)) Then
                    varConnectionstring(0) = varMsa2003c.Microsoftoledbstandard(varFilepath(0), "admin", "")

                    varConnection(0) = New OleDb.OleDbConnection(varConnectionstring(0))
                    varConnection(0).Open()
                End If

                varFilepath(1) = Application.StartupPath & "\Resources\ERRLOG.mdb"

                If OperatingSystem.File.Info.IsExists(varFilepath(1)) Then
                    varConnectionstring(1) = varMsa2003c.Microsoftoledbstandard(varFilepath(1), "admin", "")

                    varConnection(1) = New OleDb.OleDbConnection(varConnectionstring(1))
                    varConnection(1).Open()
                End If

            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
                Return
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal fields As Database.Properties.Fields) As Database.Properties.Fields
            Try
                varDatareader(0) = GETDATAROW("SELECT LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.ACCEPTEDLINECONNECTION FROM LIST WHERE LIST.ID =1;", varConnection(0), varCommand(0))

                With varDatareader(0)
                    fields.ServerAddress = .GetString(0)
                    fields.Username = .GetString(1)
                    fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                    fields.Port = CType(.GetValue(3), Integer)
                    fields.DataStorage = .GetString(4)
                    fields.FileStorage = .GetString(5)
                End With

                Return fields
            Catch ex As System.Data.OleDb.OleDbException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.ErrorCode
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal proLog As Ladybug.Log.Fields)
            Dim varNowdatetime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
            Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & proLog.TypeOfFaulty & "','" & proLog.Message & "'," & proLog.Number & ",'" & proLog.InternalStackTrace & "'," & proLog.ShowErrorReporting & ",'" & varNowdatetime & "');", varConnection(1), varCommand(1))
        End Sub

        <SupportedOSPlatform("windows")>
        Private Shared Function GetDataRow(ByVal query As String, ByVal myconnection As OleDb.OleDbConnection, ByVal mycommand As OleDb.OleDbCommand) As OleDb.OleDbDataReader
            Try
                Dim varDatareader As OleDb.OleDbDataReader

                mycommand = New OleDb.OleDbCommand With {
                .Connection = myconnection,
                .CommandType = CommandType.Text,
                .CommandText = query}

                mycommand = New System.Data.OleDb.OleDbCommand(query, myconnection)
                varDatareader = mycommand.ExecuteReader

                If varDatareader.HasRows Then
                    varDatareader.Read()
                End If

                Return varDatareader
            Catch ex As System.Data.OleDb.OleDbException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Sub PushData(ByVal query As String, ByVal myconnection As OleDb.OleDbConnection, ByVal mycommand As OleDb.OleDbCommand)
            Try
                mycommand = New OleDb.OleDbCommand With {
                .Connection = myconnection,
                .CommandType = CommandType.Text,
                .CommandText = query}
                mycommand.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[PushData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Close()
            varConnection(1).Close()
            varConnection(2).Close()
            varConnection(1).Dispose()
            varConnection(2).Dispose()
        End Sub
    End Class
End Namespace
