Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Versioning

Namespace Database.Engine
    Public Class SQLiteV3
        Private ReadOnly varConnectionString(2) As String
        Private ReadOnly varFilePath(2) As String

        Private ReadOnly varConnection(2) As SQLite.SQLiteConnection
        Private ReadOnly varCommand(2) As SQLite.SQLiteCommand
        Private ReadOnly varDataReader(2) As SQLite.SQLiteDataReader

        Private ReadOnly varSqlite As New Connect.SQLiteConnection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim baseFolder = IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ardhagp\Ingrid .NET"
        )

                Dim resourcesFolder = IO.Path.Combine(baseFolder, "Resources")
                IO.Directory.CreateDirectory(resourcesFolder)

                Dim prodOk = EnsureDbExists("Resources\catalog.db", baseFolder)
                Dim devOk = EnsureDbExists("Resources\dev_catalog.db", baseFolder)
                Dim logOk = EnsureDbExists("Resources\errlog.db", baseFolder)

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
        Private Shared Function EnsureDbExists(relativePath As String, baseFolder As String) As Boolean
            Dim targetPath = IO.Path.Combine(baseFolder, relativePath)
            Dim sourcePath = IO.Path.Combine(Application.StartupPath, relativePath)

            If Not IO.File.Exists(targetPath) Then
                IO.File.Copy(sourcePath, targetPath, True)
            End If

            Return IO.File.Exists(targetPath)
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal isproductionmode As Boolean = False)
            Try
                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ardhagp\Ingrid .NET"

                If Not (CheckDBCatalog()) Then
                    With proLog
                        .AppVersion = GetAppVersion()
                        .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
                        .InternalStackTrace = ""
                        .Message = "File configuration Not found"
                        .Number = -1
                        .ResumeNext = False
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
                End If

                If (isproductionmode) Then
                    varFilePath(0) = varLocation & "\Resources\catalog.db"
                Else
                    varFilePath(0) = varLocation & "\Resources\dev_catalog.db"
                End If

                'Dim varFileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(varFilePath(0)) Then
                    varFilePath(0) = Replace(varFilePath(0), "\", "\\")

                    varConnectionString(0) = varSqlite.SQLiteBasic(varFilePath(0))

                    varConnection(1) = New SQLite.SQLiteConnection(varConnectionString(0)) 'OleDb.OleDbConnection(_CS(0))
                    varConnection(1).Open()
                End If

                varFilePath(1) = varLocation & "\Resources\errlog.db"

                If OperatingSystem.File.Info.IsExists(varFilePath(1)) Then
                    varFilePath(1) = Replace(varFilePath(1), "\", "\\")

                    varConnectionString(1) = varSqlite.SQLiteBasic(varFilePath(1))

                    varConnection(2) = New SQLite.SQLiteConnection(varConnectionString(1))
                    varConnection(2).Open()
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub OpenAppSettings()
            Try

            Catch ex As Exception
                'Call SUBlogdatapush("[OpenAppSettings] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                'Call SUBlogdatashow()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal fields As Properties.Fields) As Database.Properties.Fields
            Try
                varDataReader(1) = GetDataRow("Select SERVERADDRESS, USERNAME, PASSWORD, SERVERPORT, DBFORDATA, DBFORFILE, DATABASEENGINE FROM serverlist WHERE DEFAULTCONNECTION =1;")

                With varDataReader(1)
                    If .HasRows Then
                        fields.ServerAddress = .GetString(0)
                        fields.Username = .GetString(1)
                        fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                        fields.Port = CType(.GetValue(3), Integer)
                        fields.DatabaseName = .GetString(4)
                        fields.FileStorage = .GetString(5)
                        fields.DatabaseEngine = .GetString(6)
                    Else
                        fields.ServerAddress = String.Empty
                        fields.Username = String.Empty
                        fields.Password = String.Empty
                        fields.Port = 0
                        fields.DatabaseName = String.Empty
                        fields.FileStorage = String.Empty
                        fields.DatabaseEngine = String.Empty
                    End If
                End With

                Return fields
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal proLog As Ladybug.Log.Fields)
            Try
                Dim varDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PushData("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & proLog.TypeOfFaulty & "','" & proLog.Message & "'," & proLog.Number & ",'" & proLog.InternalStackTrace & "'," & proLog.ShowErrorReporting & ",'" & varDateTime & "');")
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function GetDataRow(ByVal query As String) As SQLite.SQLiteDataReader
            Try
                varCommand(1) = New SQLite.SQLiteCommand With {
                                .Connection = varConnection(1),
                                .CommandType = CommandType.Text,
                                .CommandText = query
                                                    }

                varDataReader(0) = varCommand(1).ExecuteReader

                If varDataReader(0).HasRows Then
                    varDataReader(0).Read()
                End If

                Return varDataReader(0)
            Catch ex As SQLite.SQLiteException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GetValue(ByVal query As String) As Object
            Try
                Dim varRowValue As Object

                If (varConnection(1) Is Nothing) Then
                    varConnection(1).Open()
                End If

                varCommand(1) = New SQLite.SQLiteCommand With {
                                .Connection = varConnection(1),
                                .CommandTimeout = 30,
                                .CommandText = query
                    }

                varRowValue = varCommand(1).ExecuteScalar

                Return varRowValue
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GetDataTable(ByVal dbr As Adapter.SQLite.Display.Request, ByVal tablename As String)

            Dim varDataAdapterPrivate(1) As SQLite.SQLiteDataAdapter

            Try
                GC.Collect()

                Dim varDataSet As New DataSet
                Dim varBindingSource As New BindingSource

                If (varCommand(1) Is Nothing) Then
                    varCommand(1) = New SQLite.SQLiteCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandTimeout = 30

                varCommand(1).CommandText = dbr.Query

                varDataAdapterPrivate(1) = New SQLite.SQLiteDataAdapter(varCommand(1))
                varDataAdapterPrivate(1).Fill(varDataSet, tablename)

                varBindingSource = New BindingSource(varDataSet, tablename)

                If Not (dbr.DataGrid Is Nothing) Then
                    dbr.DataGrid.DataSource = varBindingSource
                End If

                If Not (dbr.Dropdown Is Nothing) Then
                    dbr.Dropdown.DataSource = varBindingSource
                End If

                If Not (dbr.StatusBar Is Nothing) AndAlso (dbr.StatusBar.Items.Count <> 0) Then
                    dbr.StatusBar.Items(0).Text = varBindingSource.Count & " Row(s)"
                End If

                If Not (dbr.Chart Is Nothing) Then
                    dbr.Chart.DataSource = varBindingSource
                End If

            Catch ex As SQLite.SQLiteException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PushData(ByVal query As String)
            Try
                Using varTX = varConnection(1).BeginTransaction
                    Dim varCommand = varConnection(1).CreateCommand
                    varCommand.CommandText = query

                    varCommand.ExecuteNonQuery()

                    varTX.Commit()
                End Using

            Catch ex As SQLite.SQLiteException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[PushData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb"
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
                clsLog = Nothing
            End Try
        End Sub

        Public Sub Close()
            varConnection(1).Close()
            varConnection(2).Close()
            varConnection(1).Dispose()
            varConnection(2).Dispose()
        End Sub
    End Class
End Namespace
