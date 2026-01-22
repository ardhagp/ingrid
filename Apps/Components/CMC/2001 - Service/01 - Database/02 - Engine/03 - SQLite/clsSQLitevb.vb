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

        Private ReadOnly varSqliteConnection As New Connect.SQLiteConnection
        Private varTX As SQLite.SQLiteTransaction
        Private varIsProductionMode As Boolean

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
                clsLog = Nothing

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
        Public Sub Open(Optional isproductionmode As Boolean = True)
            Try
                varIsProductionMode = isproductionmode
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

                varFilePath(0) = varLocation & "\Resources\catalog.db"
                varFilePath(1) = varLocation & "\Resources\errlog.db"

                If (isproductionmode) AndAlso OperatingSystem.File.Info.IsExists(varFilePath(0)) Then
                    varFilePath(0) = Replace(varFilePath(0), "\", "\\")

                    varConnectionString(0) = varSqliteConnection.SQLiteBasic(varFilePath(0))

                    varConnection(1) = New SQLite.SQLiteConnection(varConnectionString(0)) 'OleDb.OleDbConnection(_CS(0))
                    varConnection(1).Open()
                ElseIf Not (isproductionmode) AndAlso (OperatingSystem.File.Info.IsExists(varFilePath(1))) Then
                    varFilePath(1) = Replace(varFilePath(1), "\", "\\")

                    varConnectionString(1) = varSqliteConnection.SQLiteBasic(varFilePath(1))

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

        '<SupportedOSPlatform("windows")>
        'Public Shared Sub OpenAppSettings()
        '    Try

        '    Catch ex As Exception
        '        'Call SUBlogdatapush("[OpenAppSettings] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
        '        'Call SUBlogdatashow()
        '    End Try
        'End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(databaseproperties As LibApp.Ingrid.Global.Properties) As LibApp.Ingrid.Global.Properties
            Try
                If databaseproperties Is Nothing Then
                    databaseproperties = New LibApp.Ingrid.Global.Properties
                End If

                varDataReader(1) = GetDataRow("Select SERVERADDRESS, USERNAME, PASSWORD, SERVERPORT, DBFORDATA, DBFORFILE, DATABASEENGINE FROM serverlist WHERE DEFAULTCONNECTION =1;")

                With varDataReader(1)
                    If .HasRows Then
                        databaseproperties.ServerAddress = .GetString(0)
                        databaseproperties.Username = .GetString(1)
                        databaseproperties.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                        databaseproperties.ServerPort = CType(.GetValue(3), Integer)
                        databaseproperties.DatabaseName = .GetString(4)
                        databaseproperties.FileStorage = .GetString(5)
                        databaseproperties.DatabaseEngine = .GetString(6)
                    Else
                        databaseproperties.ServerAddress = String.Empty
                        databaseproperties.Username = String.Empty
                        databaseproperties.Password = String.Empty
                        databaseproperties.ServerPort = 0
                        databaseproperties.DatabaseName = String.Empty
                        databaseproperties.FileStorage = String.Empty
                        databaseproperties.DatabaseEngine = String.Empty
                    End If
                End With

                Return databaseproperties
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
        Public Sub SaveErrorData(proLog As Ladybug.Log.Fields)
            Try
                Dim varDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Dim varQuery As String
                varQuery = $"insert into ERRORLOG(ERRORDATETIME,ERRORTYPE,ERRORNUMBER,ERRORDESCRIPTION,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDONEREPORTED) values " &
                           $"('{varDateTime}','{proLog.TypeOfFaulty}','{proLog.Number}','{proLog.Message}','{proLog.InternalStackTrace}','{proLog.ShowErrorReporting}','1')"
                Call PushData(varQuery)
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
        Private Function GetDataRow(query As String) As SQLite.SQLiteDataReader
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
        Public Function GetValue(query As String) As Object
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
        Public Sub GetDataTable(dbr As Adapter.SQLite.Display.Request, tablename As String)

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
        Public Sub PushData(query As String)
            Try
                If (varIsProductionMode) AndAlso (varTX Is Nothing) Then
                    varTX = varConnection(1).BeginTransaction
                ElseIf Not (varIsProductionMode) AndAlso (varTX Is Nothing) Then
                    varTX = varConnection(2).BeginTransaction
                End If

                If varIsProductionMode Then
                    Dim varCommand = varConnection(1).CreateCommand
                    varCommand.CommandText = query
                    varCommand.ExecuteNonQuery()
                Else
                    Dim varCommand = varConnection(2).CreateCommand
                    varCommand.CommandText = query
                    varCommand.ExecuteNonQuery()
                End If

                varTX.Commit()
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
            If Not (varConnection(1) Is Nothing) Then
                varConnection(1).Close()
                varConnection(1).Dispose()
                varConnection(1) = Nothing
            End If

            If Not (varConnection(2) Is Nothing) Then
                varConnection(2).Close()
                varConnection(2).Dispose()
                varConnection(2) = Nothing
            End If
        End Sub
    End Class
End Namespace
