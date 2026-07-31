Namespace Database.Engine
    Public Class SqliteV3
        Implements IDisposable

        Private varConnectionString As String
        Private ReadOnly varFilePath(2) As String

        ' Activate this when using Microsoft.Data.Sqlite
        ' Private varConnection As Microsoft.Data.Sqlite.SqliteConnection
        ' Private varCommand As Microsoft.Data.Sqlite.SqliteCommand
        ' Private varDataReader As Microsoft.Data.Sqlite.SqliteDataReader

        ' Activate this when using System.Data.SQLite.Core
        Private varConnection As System.Data.SQLite.SQLiteConnection
        Private varCommand As System.Data.SQLite.SQLiteCommand
        Private varDataReader As System.Data.SQLite.SQLiteDataReader

        Private varSqlite As Connect.SqliteConnection
        ' Private varTX As SQLite.SQLiteTransaction

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
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
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
        Public Function ConnectionString(localsqlitedb As String) As String
            Try
                varSqlite = New Connect.SqliteConnection
                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ardhagp\Ingrid .NET"

                If Not (CheckDBCatalog(localsqlitedb)) Then
                    With UI.proLog
                        .AppVersion = UI.GetAppVersion()
                        .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\SQLitevb.vb"
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
                    clsLog.ShowData(UI.proLog)
                    clsLog = Nothing
                    Return Nothing
                End If

                varFilePath(0) = varLocation & $"\Resources\{localsqlitedb}"

                If OperatingSystem.File.Info.IsExists(varFilePath(0)) Then
                    varFilePath(0) = Replace(varFilePath(0), "\", "\\")

                    varConnectionString = varSqlite.SqliteBasic(varFilePath(0))
                End If
                Return varConnectionString
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing
                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub Open(localsqlitedb As String)
            Try
                ' Activate this when using System.Data.SQLite.Core
                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString(localsqlitedb)) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()
                End Using
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(databaseproperties As LibApp.Ingrid.Global.Properties) As LibApp.Ingrid.Global.Properties
            Try
                Dim varQuery As String = $"Select SERVERADDRESS, " &
                                         $"USERNAME, " &
                                         $"PASSWORD, " &
                                         $"SERVERPORT, " &
                                         $"DBFORDATA, " &
                                         $"DBFORFILE, " &
                                         $"DATABASEENGINE, " &
                                         $"CLIENT " &
                                         $"FROM serverlist " &
                                         $"WHERE DEFAULTCONNECTION = 1;"
                Dim dsCmcv As New CMCv.Data.Dataset.ADSconnect
                FillDataSet(databaseproperties, varQuery, dsCmcv, "serverlist")

                With dsCmcv.Tables(0).Rows
                    If .Count = 0 Then
                        databaseproperties.ConnectionServerAddress = String.Empty
                        databaseproperties.ConnectionUsername = String.Empty
                        databaseproperties.ConnectionPassword = String.Empty
                        databaseproperties.ConnectionServerPort = 0
                        databaseproperties.ConnectionDatabaseName = String.Empty
                        databaseproperties.ConnectionFileStorage = String.Empty
                        databaseproperties.ConnectionDatabaseEngine = String.Empty
                        databaseproperties.ConnectionClientCode = String.Empty
                        Return databaseproperties
                    End If
                    databaseproperties.ConnectionServerAddress = .Item(0).ToString
                    databaseproperties.ConnectionUsername = .Item(1).ToString
                    databaseproperties.ConnectionPassword = Security.Decrypt.Aes(.Item(2).ToString)
                    databaseproperties.ConnectionServerPort = CInt(.Item(3).ToString)
                    databaseproperties.ConnectionDatabaseName = .Item(4).ToString
                    databaseproperties.ConnectionFileStorage = .Item(5).ToString
                    databaseproperties.ConnectionDatabaseEngine = .Item(6).ToString
                    databaseproperties.ConnectionClientCode = .Item(7).ToString
                    Return databaseproperties
                End With
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        'Private Function GetDataRow(query As String) As Microsoft.Data.Sqlite.SqliteDataReader
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function GetDataRow(dataproperties As LibApp.Ingrid.Global.Properties, query As String) As System.Data.SQLite.SQLiteDataReader ' Activate this when using System.Data.Sqlite.Core
            Try
                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString("catalog.db")) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()
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
                End Using
            Catch ex As System.Data.SQLite.SQLiteException
                'Catch ex As Microsoft.Data.Sqlite.SqliteException
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetValue(query As String) As Object
            Try
                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString("catalog.db")) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()
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
                End Using
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub GetDataTable(dbr As Adapter.Sqlite.Display.Request, datasetname As System.Data.DataSet, tablename As String)

            Try
                GC.Collect()
                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString("catalog.db")) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()

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
                End Using
            Catch ex As System.Data.SQLite.SQLiteException
                'Catch ex As Microsoft.Data.Sqlite.SqliteException
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetDataSet(dataproperties As LibApp.Ingrid.Global.Properties, query As String, tablename As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As System.Data.DataSet
            GC.Collect()

            Try
                Dim varDataAdapter As System.Data.SQLite.SQLiteDataAdapter
                Dim varDataset As New System.Data.DataSet
                Dim varBindingSource As New System.Windows.Forms.BindingSource

                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString("catalog.db")) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()

                    ' Activate this when using Microsoft.Data.Sqlite
                    'varCommand = New Microsoft.Data.Sqlite.SqliteCommand With {

                    ' Activate this when using System.Data.SQLite.Core
                    Using varCommand As New System.Data.SQLite.SQLiteCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandText = String.Format(System.Globalization.CultureInfo.CurrentCulture, query)
                        varCommand.CommandTimeout = 30

                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If

                        varDataAdapter = New System.Data.SQLite.SQLiteDataAdapter(varCommand)
                        varDataAdapter.Fill(varDataset, tablename)

                        varBindingSource = New System.Windows.Forms.BindingSource(varDataset, tablename)
                    End Using
                    Return varDataset
                End Using
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing
                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function FillDataSet(dataproperties As LibApp.Ingrid.Global.Properties, query As String, datasetname As System.Data.DataSet, tablename As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As System.Data.DataSet
            GC.Collect()

            Try
                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString("catalog.db")) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()

                    ' Activate this when using Microsoft.Data.Sqlite
                    'varCommand = New Microsoft.Data.Sqlite.SqliteCommand With {

                    ' Activate this when using System.Data.SQLite.Core
                    Using varCommand As New System.Data.SQLite.SQLiteCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandText = String.Format(System.Globalization.CultureInfo.CurrentCulture, query)
                        varCommand.CommandTimeout = 30

                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If

                        Using varDataAdapter = New System.Data.SQLite.SQLiteDataAdapter(varCommand)
                            datasetname.Tables(tablename).Clear()
                            varDataAdapter.Fill(datasetname, tablename)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing
                Return Nothing
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub PushData(query As String)
            Try
                Using varConnection As New System.Data.SQLite.SQLiteConnection(ConnectionString("catalog.db")) 'OleDb.OleDbConnection(_CS(0))
                    varConnection.Open()
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
                End Using
            Catch ex As System.Data.SQLite.SQLiteException
                'Catch ex As Microsoft.Data.Sqlite.SqliteException
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
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
