Namespace Database.Engine
    Public Class SQLiteV3
        Implements IDisposable

        Private varConnectionString As String
        Private ReadOnly varFilePath(2) As String

        ' Activate this when using Microsoft.Data.Sqlite
        'Private varConnection As Microsoft.Data.Sqlite.SqliteConnection
        'Private varCommand As Microsoft.Data.Sqlite.SqliteCommand
        'Private varDataReader As Microsoft.Data.Sqlite.SqliteDataReader

        ' Activate this when using System.Data.SQLite.Core
        Private varConnection As System.Data.SQLite.SQLiteConnection
        Private varCommand As System.Data.SQLite.SQLiteCommand
        Private varDataReader As System.Data.SQLite.SQLiteDataReader

        Private varSqlite As Connect.SQLiteConnection
        'Private varTX As SQLite.SQLiteTransaction

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog(localsqlitedb As String) As Boolean
            Try
                Dim baseFolder = IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ardhagp\Ingrid .NET"
        )

                Dim resourcesFolder = IO.Path.Combine(baseFolder, "Resources")
                IO.Directory.CreateDirectory(resourcesFolder)

                Dim prodOk = EnsureDbExists($"Resources\{localsqlitedb}", baseFolder)

                Return (prodOk)

            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return False
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Function EnsureDbExists(relativepath As String, basefolder As String) As Boolean
            Dim targetPath = IO.Path.Combine(basefolder, relativepath)
            Dim sourcePath = IO.Path.Combine(System.Windows.Forms.Application.StartupPath, relativepath)

            If Not IO.File.Exists(targetPath) Then
                IO.File.Copy(sourcePath, targetPath, True)
            End If

            Return IO.File.Exists(targetPath)
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub Open(localsqlitedb As String)
            Try
                varSqlite = New Connect.SQLiteConnection
                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ardhagp\Ingrid .NET"

                If Not (CheckDBCatalog(localsqlitedb)) Then
                    With CMCv.UI.proLog
                        .AppVersion = CMCv.UI.GetAppVersion()
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
                    clsLog.ShowData(CMCv.UI.proLog)
                    clsLog = Nothing
                    Return
                End If

                varFilePath(0) = varLocation & $"\Resources\{localsqlitedb}"

                If OperatingSystem.File.Info.IsExists(varFilePath(0)) Then
                    varFilePath(0) = Replace(varFilePath(0), "\", "\\")

                    varConnectionString = varSqlite.SQLiteBasic(varFilePath(0))

                    ' Activate this when using Microsoft.Data.Sqlite
                    'varConnection = New Microsoft.Data.Sqlite.SqliteConnection(varConnectionString) 'OleDb.OleDbConnection(_CS(0))

                    ' Activate this when using System.Data.SQLite.Core
                    varConnection = New System.Data.SQLite.SQLiteConnection(varConnectionString) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()
                End If
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(databaseproperties As LibApp.Ingrid.Global.Properties) As LibApp.Ingrid.Global.Properties
            Try
                If databaseproperties Is Nothing Then
                    databaseproperties = New LibApp.Ingrid.Global.Properties
                End If

                varDataReader = GetDataRow("Select SERVERADDRESS, USERNAME, PASSWORD, SERVERPORT, DBFORDATA, DBFORFILE, DATABASEENGINE FROM serverlist WHERE DEFAULTCONNECTION =1;")

                With varDataReader
                    If .HasRows Then
                        databaseproperties.ConnectionServerAddress = .GetString(0)
                        databaseproperties.ConnectionUsername = .GetString(1)
                        databaseproperties.ConnectionPassword = CMCv.Security.Decrypt.Aes(.GetString(2))
                        databaseproperties.ConnectionServerPort = CType(.GetValue(3), Integer)
                        databaseproperties.ConnectionDatabaseName = .GetString(4)
                        databaseproperties.ConnectionFileStorage = .GetString(5)
                        databaseproperties.ConnectionDatabaseEngine = .GetString(6)
                    Else
                        databaseproperties.ConnectionServerAddress = String.Empty
                        databaseproperties.ConnectionUsername = String.Empty
                        databaseproperties.ConnectionPassword = String.Empty
                        databaseproperties.ConnectionServerPort = 0
                        databaseproperties.ConnectionDatabaseName = String.Empty
                        databaseproperties.ConnectionFileStorage = String.Empty
                        databaseproperties.ConnectionDatabaseEngine = String.Empty
                    End If
                End With

                Return databaseproperties
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        'Private Function GetDataRow(query As String) As Microsoft.Data.Sqlite.SqliteDataReader
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function GetDataRow(query As String) As System.Data.SQLite.SQLiteDataReader ' Activate this when using System.Data.Sqlite.Core
            Try
                ' Activate this when using Microsoft.Data.Sqlite
                'varCommand = New Microsoft.Data.Sqlite.SqliteCommand With {
                '                .Connection = varConnection,
                '                .CommandType = CommandType.Text,
                '                .CommandText = query}

                ' Activate this when using System.Data.SQLite.Core
                varCommand = New System.Data.SQLite.SQLiteCommand With {
                                .Connection = varConnection,
                                .CommandType = System.Data.CommandType.Text,
                                .CommandText = query
                                }
                varDataReader = varCommand.ExecuteReader

                If varDataReader.HasRows Then
                    varDataReader.Read()
                End If

                Return varDataReader
            Catch ex As System.Data.SQLite.SQLiteException
                'Catch ex As Microsoft.Data.Sqlite.SqliteException
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetValue(query As String) As Object
            Try
                Dim varRowValue As Object

                ' Activate this when using Microsoft.Data.Sqlite
                'varCommand = New Microsoft.Data.Sqlite.SqliteCommand With {
                '                .Connection = varConnection,
                '                .CommandTimeout = 30,
                '                .CommandText = query
                '    }

                ' Activate this when using System.Data.SQLite.Core
                varCommand = New System.Data.SQLite.SQLiteCommand With {
                                .Connection = varConnection,
                                .CommandTimeout = 30,
                                .CommandText = query
                    }

                varRowValue = varCommand.ExecuteScalar

                Return varRowValue
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub GetDataTable(dbr As Adapter.Sqlite.Display.Request, datasetname As System.Data.DataSet, tablename As String)

            Try
                GC.Collect()

                Dim varBindingSource As New System.Windows.Forms.BindingSource

                If (varCommand Is Nothing) Then
                    ' Activate this when using Microsoft.Data.Sqlite
                    'varCommand = New Microsoft.Data.Sqlite.SqliteCommand

                    ' Activate this when using System.Data.Sqlite.Core
                    varCommand = New System.Data.SQLite.SQLiteCommand
                End If

                varCommand.Connection = varConnection
                varCommand.CommandTimeout = 30

                varCommand.CommandText = dbr.Query

                ' Activate this when using Microsoft.Data.Sqlite
                'Dim dt As New DataTable()

                'Using cmd As New SqliteCommand(varCommand.CommandText, varCommand.Connection)
                '    Using reader = cmd.ExecuteReader()
                '        dt.Load(reader)
                '    End Using
                'End Using

                'For Each row As DataRow In dt.Rows
                '    row("SERVERPORT") = CStr(row("SERVERPORT"))
                '    row("DEFAULTCONNECTION") = CLng(row("DEFAULTCONNECTION"))
                'Next

                'datasetname.Tables(tablename).Clear()
                'datasetname.Tables(tablename).Merge(dt)

                ' Activate this when using System.Data.Sqlite.Core
                Dim varDataAdapterPrivate As System.Data.SQLite.SQLiteDataAdapter
                varDataAdapterPrivate = New System.Data.SQLite.SQLiteDataAdapter(varCommand)
                datasetname.Tables(tablename).Clear()
                varDataAdapterPrivate.Fill(datasetname, tablename)

                varBindingSource = New System.Windows.Forms.BindingSource(datasetname, tablename)

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

            Catch ex As System.Data.SQLite.SQLiteException
                'Catch ex As Microsoft.Data.Sqlite.SqliteException
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing
            Catch ex As Exception
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function FillDataSet(query As String, datasetname As System.Data.DataSet, tablename As String) As System.Data.DataSet
            GC.Collect()

            Try
                ' Activate this when using Microsoft.Data.Sqlite
                'varCommand = New Microsoft.Data.Sqlite.SqliteCommand With {

                ' Activate this when using System.Data.SQLite.Core
                varCommand = New System.Data.SQLite.SQLiteCommand With {
                .Connection = varConnection,
                .CommandType = System.Data.CommandType.Text,
                .CommandText = String.Format(System.Globalization.CultureInfo.CurrentCulture, query)
                }


                ' Prepare a DataTable to load results
                Dim dt As New System.Data.DataTable()

                Using reader = varCommand.ExecuteReader()
                    dt.Load(reader)
                End Using

                ' Replace the target table inside the DataSet
                datasetname.Tables(tablename).Clear()
                datasetname.Tables(tablename).Merge(dt)

                Return datasetname
            Catch ex As Exception
                datasetname = Nothing
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLite.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Query = query
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing
                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub PushData(query As String)
            Try
                ' Activate this when using Microsoft.Data.Sqlite
                'Dim varTX As Microsoft.Data.Sqlite.SqliteTransaction = Nothing

                ' Activate this when using System.Data.SQLite.Core
                Dim varTX As System.Data.SQLite.SQLiteTransaction = Nothing

                If (varTX Is Nothing) Then
                    varTX = varConnection.BeginTransaction
                End If

                Dim varCommand = varConnection.CreateCommand
                varCommand.CommandText = query
                varCommand.ExecuteNonQuery()

                varTX.Commit()
            Catch ex As System.Data.SQLite.SQLiteException
                'Catch ex As Microsoft.Data.Sqlite.SqliteException
                With CMCv.UI.proLog
                    .AppVersion = CMCv.UI.GetAppVersion()
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
                clsLog.ShowData(CMCv.UI.proLog)
                clsLog = Nothing
            End Try
        End Sub

        Public Sub Close()
            If Not (varConnection Is Nothing) Then
                varSqlite = Nothing
                varConnection.Close()
                varConnection = Nothing
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Throw New NotImplementedException()
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
