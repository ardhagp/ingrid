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
                Dim baseFolder = IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ardhagp\Ingrid .NET"
        )

                Dim resourcesFolder = IO.Path.Combine(baseFolder, "Resources")
                IO.Directory.CreateDirectory(resourcesFolder)

                Dim prodOk = EnsureDbExists("Resources\catalog.mdb", baseFolder)
                Dim devOk = EnsureDbExists("Resources\dev_catalog.mdb", baseFolder)
                Dim logOk = EnsureDbExists("Resources\errlog.mdb", baseFolder)

                Return (prodOk AndAlso logOk) OrElse (devOk AndAlso logOk)

            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = False
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)

                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Function EnsureDbExists(relativepath As String, basefolder As String) As Boolean
            Dim targetPath = IO.Path.Combine(basefolder, relativepath)
            Dim sourcePath = IO.Path.Combine(Application.StartupPath, relativepath)

            If Not IO.File.Exists(targetPath) Then
                IO.File.Copy(sourcePath, targetPath, True)
            End If

            Return IO.File.Exists(targetPath)
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional isproductionmode As Boolean = False)
            Try
                CheckDBCatalog()

                If (isproductionmode) Then
                    varFilepath(0) = Application.StartupPath & "\Resources\catalog.mdb"
                Else
                    varFilepath(0) = Application.StartupPath & "\Resources\dev_catalog.mdb"
                End If

                'Dim varFileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(varFilepath(0)) Then
                    varConnectionstring(0) = varMsa2003c.Microsoftoledbstandard(varFilepath(0), "admin", "")

                    varConnection(0) = New OleDb.OleDbConnection(varConnectionstring(0))
                    varConnection(0).Open()
                End If

                varFilepath(1) = Application.StartupPath & "\Resources\errlog.mdb"

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
        Public Function GetDatabaseProperties(globalproperties As LibApp.Ingrid.Global.Properties) As LibApp.Ingrid.Global.Properties
            Try
                varDatareader(0) = GetDataRow("SELECT LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.ACCEPTEDLINECONNECTION FROM LIST WHERE LIST.ID =1;", varConnection(0), varCommand(0))

                With varDatareader(0)
                    globalproperties.ConnectionServerAddress = .GetString(0)
                    globalproperties.ConnectionUsername = .GetString(1)
                    globalproperties.ConnectionPassword = CMCv.Security.Decrypt.Aes(.GetString(2))
                    globalproperties.ConnectionServerPort = CType(.GetValue(3), Integer)
                    globalproperties.ConnectionDatabaseName = .GetString(4)
                    globalproperties.ConnectionFileStorage = .GetString(5)
                End With

                Return globalproperties
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
            Call PushData("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & proLog.TypeOfFaulty & "','" & proLog.Message & "'," & proLog.Number & ",'" & proLog.InternalStackTrace & "'," & proLog.ShowErrorReporting & ",'" & varNowdatetime & "');", varConnection(1), varCommand(1))
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
