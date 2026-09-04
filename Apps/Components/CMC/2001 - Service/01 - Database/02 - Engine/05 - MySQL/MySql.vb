Imports MySql.Data.MySqlClient

Namespace Database.Engine
    ''' <summary>
    ''' Provides methods to connect to a MySQL database, execute queries, and retrieve results.
    ''' </summary>
    Public Class Mysql
        Implements IDisposable

        'Private varConnection As MySqlConnection
        'Private varCommand As MySqlCommand
        Private ReadOnly varDataAdapter As MySqlDataAdapter

        Private ReadOnly varMySQL As New Connect.MysqlConnection

        Private disposedValue As Boolean

        ''' <summary>
        ''' Releases the resources used by this instance. When disposing 
        ''' is True, both managed and unmanaged resources can be cleaned up; otherwise only 
        ''' unmanaged resources should be released.
        ''' </summary> 
        ''' <param name="disposing">
        ''' True to dispose managed resources such as the data adapter; False when called 
        ''' from the finalizer and only unmanaged cleanup should occur.
        ''' </param>
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    varDataAdapter?.Dispose()
                End If
                disposedValue = True
            End If
        End Sub

        ''' <summary>
        ''' Opens a MySQL database connection using the connection parameters provided 
        ''' in the object. Returns True if the 
        ''' connection is successfully established.
        ''' </summary>
        ''' <param name="fields">
        ''' A structure containing the server address, port, database name, username, 
        ''' and password required to build the MySQL connection string.
        ''' </param>
        ''' <param name="splash">
        ''' Optional. A splash screen form that will be closed automatically if the 
        ''' connection attempt fails.
        ''' </param>
        ''' <returns>
        ''' True if the connection is opened successfully; otherwise False. 
        ''' Errors are logged through the Ladybug logging system.
        ''' </returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function Open(databaseproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean = False
            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()
                    varSuccess = True
                End Using
            Catch ex As MySqlException
                varSuccess = False

                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing
            End Try
            Return varSuccess
        End Function

        ''' <summary>
        ''' Executes a SQL query and returns a single DataRow from the result set.
        ''' </summary>
        ''' <param name="databasename">
        ''' The target MySQL database name.
        ''' </param>
        ''' <param name="query">
        ''' The SQL query to execute. The method automatically prepends the database 
        ''' selection (USE databasename) before running the query.
        ''' </param>
        ''' <returns>
        ''' A MySqlDataReader positioned at the first row of the result set. 
        ''' Returns Nothing if an exception occurs.
        ''' </returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetDataRow(databaseproperties As LibApp.Ingrid.Global.Properties, databasename As String, query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As MySqlDataReader
            Dim varDataReader As MySqlDataReader

            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()

                    Using varCommand As New MySqlCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandTimeout = 30

                        query = "USE " & databasename & "; " & query
                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If

                        varDataReader = varCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

                        If varDataReader.HasRows Then
                            varDataReader.Read()
                        End If
                    End Using
                End Using
                Return varDataReader
            Catch ex As MySqlException
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing

                Return Nothing
            Catch ex As Exception
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Executes a SQL query and returns a single value from the result set.
        ''' </summary>
        ''' <param name="query">
        ''' The SQL query to execute. The method automatically prepends the database 
        ''' selection (USE databasename) before running the query.
        ''' </param>
        ''' <param name="databasename">
        ''' Optional. The target MySQL database name. Defaults to "defaultdb".
        ''' </param>
        ''' <returns>
        ''' The first column of the first row in the result set returned by the query. 
        ''' Returns Nothing if an exception occurs.
        ''' </returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetValue(databaseproperties As LibApp.Ingrid.Global.Properties, databasename As String, query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Object
            Dim varRowValue As Object

            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()

                    Using varcommand As New MySqlCommand
                        varcommand.Parameters.Clear()
                        varcommand.Connection = varConnection
                        varcommand.CommandType = System.Data.CommandType.Text
                        varcommand.CommandTimeout = 30

                        query = "USE " & databasename & "; " & query

                        varcommand.CommandText = query
                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varcommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If
                        varRowValue = varcommand.ExecuteScalar
                    End Using
                End Using
                Return varRowValue
            Catch ex As Exception
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\MySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Executes a SQL query and returns the results in a DataSet.
        ''' </summary>
        ''' <param name="databasename">
        ''' The target MySQL database name. 
        ''' The method automatically prepends a USE statement before executing the query.
        ''' </param>
        ''' <param name="dbr">
        ''' A request object containing the SQL query to execute.
        ''' </param>
        ''' <param name="tablename">
        ''' The name of the DataTable inside the DataSet where the query results 
        ''' will be stored.
        ''' </param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetDataSet(databaseproperties As LibApp.Ingrid.Global.Properties, databasename As String, dbr As Adapter.Mysql.Display.Request, tablename As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As System.Data.DataSet
            Dim varDataAdapter As MySqlDataAdapter
            Dim varDataset As New System.Data.DataSet
            Dim varBindingSource As New System.Windows.Forms.BindingSource

            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()
                    GC.Collect()

                    Using varCommand As New MySqlCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandTimeout = 30

                        dbr.Query = "USE " & databasename & "; " & dbr.Query

                        varCommand.CommandText = dbr.Query
                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If

                        varDataAdapter = New MySqlDataAdapter(varCommand)
                        varDataAdapter.Fill(varDataset, tablename)

                        varBindingSource = New System.Windows.Forms.BindingSource(varDataset, tablename)
                    End Using
                End Using
                Return varDataset
            Catch ex As Exception
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetDataSet] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Query = dbr.Query
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing

                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' Executes a SQL query and loads the results into a DataSet, then binds the 
        ''' resulting table to any UI components provided in the request object 
        ''' (DataGrid, Dropdown, StatusBar, or Chart).
        ''' </summary>
        ''' <param name="databasename">
        ''' The target MySQL database name.
        ''' The method automatically prepends a USE statement before executing the query.
        ''' </param>
        ''' <param name="dbr">
        ''' A request object containing the SQL query and optional UI controls 
        ''' that will receive the resulting data (DataGrid, Dropdown, StatusBar, Chart).
        ''' </param>
        ''' <param name="tablename">
        ''' The name of the DataTable inside the DataSet where the query results 
        ''' will be stored and used as the binding source.
        ''' </param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub GetDataTable(databaseproperties As LibApp.Ingrid.Global.Properties, databasename As String, dbr As Adapter.Mysql.Display.Request, tablename As String, Optional parameters As Dictionary(Of String, Object) = Nothing)
            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()
                    GC.Collect()

                    Using varCommand As New MySqlCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandTimeout = 30

                        dbr.Query = "USE " & databasename & "; " & dbr.Query

                        varCommand.CommandText = dbr.Query
                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If

                        Using varDataAdapterPrivate As New MySqlDataAdapter(varCommand)
                            Using varDataset As New System.Data.DataSet
                                varDataAdapterPrivate.Fill(varDataset, tablename)
                                dbr.BindingSource = New System.Windows.Forms.BindingSource(varDataset, tablename)
                            End Using
                        End Using

                        If Not (dbr.DataGrid Is Nothing) Then
                            dbr.DataGrid.DataSource = dbr.BindingSource
                        End If

                        If Not (dbr.Dropdown Is Nothing) Then
                            dbr.Dropdown.DataSource = dbr.BindingSource
                        End If

                        If Not (dbr.StatusBar Is Nothing) AndAlso (dbr.StatusBar.Items.Count <> 0) Then
                            dbr.StatusBar.Items(0).Text = dbr.BindingSource.Count & " Row(s)"
                        End If

                        If Not (dbr.Chart Is Nothing) Then
                            dbr.Chart.DataSource = dbr.BindingSource
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Query = dbr.Query
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing
            Catch ex As Exception
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Query = dbr.Query
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' Executes a non-query SQL command against the specified MySQL database.
        ''' This method is typically used for INSERT, UPDATE, DELETE, or other 
        ''' data‑manipulation statements.
        ''' </summary>
        ''' <param name="databasename">
        ''' Optional. The target database name to apply the query to. 
        ''' Defaults to "defaultdb".
        ''' </param>
        ''' <param name="query">
        ''' The SQL command to execute. The method automatically prepends the 
        ''' database selection (USE databasename) before running the query.
        ''' </param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function PushData(databaseproperties As LibApp.Ingrid.Global.Properties, databasename As String, query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Boolean
            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()
                    GC.Collect()

                    Using varCommand As New MySqlCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandTimeout = 30

                        query = "USE " & databasename & "; " & query

                        varCommand.CommandText = query
                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, If(param.Value, DBNull.Value))
                            Next
                        End If
                        varCommand.ExecuteNonQuery()
                    End Using
                End Using
                Return True
            Catch ex As Exception
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[PushData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Executes the provided MySqlCommand to push or update image-related data 
        ''' into the MySQL database. Returns True if the command executes successfully.
        ''' </summary>
        ''' <param name="cmd">
        ''' The MySqlCommand instance to execute. If Nothing is supplied, a new empty 
        ''' MySqlCommand object is created and used instead.
        ''' </param>
        ''' <returns>
        ''' True if the command executes without errors; otherwise False. 
        ''' Errors are logged through the Ladybug logging system.
        ''' </returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function PushImage(databaseproperties As LibApp.Ingrid.Global.Properties, cmd As MySqlCommand) As Boolean
            Dim varSuccess As Boolean

            Try
                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()
                    Dim varCommand As New MySqlCommand
                    If cmd IsNot Nothing Then
                        varCommand = cmd
                    End If

                    varCommand.Connection = varConnection
                    varCommand.CommandType = System.Data.CommandType.Text
                    varCommand.ExecuteNonQuery()
                    varCommand.Dispose()
                    varCommand = Nothing
                End Using
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[PushImage] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing
            End Try

            Return varSuccess
        End Function

        ''' <summary>
        ''' Executes a SQL query against the specified MySQL database and fills the given DataSet 
        ''' with the results using the provided table name.
        ''' </summary>
        ''' <param name="databasename">
        ''' The target database name.
        ''' </param>
        ''' <param name="query">
        ''' The SQL query to execute. The function automatically prepends the database selection (USE ...).
        ''' </param>
        ''' <param name="datasetname">
        ''' The DataSet instance that will receive the query results.
        ''' </param>
        ''' <param name="tablename">
        ''' The name of the DataTable inside the DataSet where the results will be stored.
        ''' </param>
        ''' <returns>
        ''' The filled DataSet. Returns Nothing if an exception occurs.
        ''' </returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function FillDataSet(databaseproperties As LibApp.Ingrid.Global.Properties, databasename As String, query As String, datasetname As System.Data.DataSet, tablename As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As System.Data.DataSet

            Try
                GC.Collect()

                Using varConnection As New MySqlConnection(varMySQL.MysqlForceSsl(databaseproperties.ConnectionServerAddress, databaseproperties.ConnectionServerPort, databaseproperties.ConnectionDatabaseName, databaseproperties.ConnectionUsername, Security.Decrypt.Aes(databaseproperties.ConnectionPassword)))
                    varConnection.Open()

                    Using varCommand As New MySqlCommand
                        varCommand.Parameters.Clear()
                        varCommand.Connection = varConnection
                        varCommand.CommandType = System.Data.CommandType.Text
                        varCommand.CommandTimeout = 30

                        query = "USE " & databasename & "; " & query

                        varCommand.CommandText = query
                        If parameters IsNot Nothing Then
                            For Each param In parameters
                                varCommand.Parameters.AddWithValue(param.Key, param.Value)
                            Next
                        End If

                        Using varDataAdapter = New MySqlDataAdapter(varCommand)
                            datasetname.Tables(tablename).Clear()
                            varDataAdapter.Fill(datasetname, tablename)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                datasetname = Nothing
                With Component.Properties.proLog
                    .AppVersion = Component.Properties.GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
                clsLog.ShowData(Component.Properties.proLog)
                clsLog = Nothing
            End Try

            Return datasetname
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
