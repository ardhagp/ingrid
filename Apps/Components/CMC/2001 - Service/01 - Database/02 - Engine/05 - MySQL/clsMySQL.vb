Imports System.Data
Imports System.Globalization
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv.Database.Adapter
Imports MySql.Data

Namespace Database.Engine
    Public Class Mysql
        Implements IDisposable

        Private ReadOnly varConnection(1) As MySqlClient.MySqlConnection
        Private ReadOnly varCommand(1) As MySqlClient.MySqlCommand
        Private ReadOnly varDataAdapter As MySqlClient.MySqlDataAdapter

        Private ReadOnly varMySQL As New Connect.Mysqlconnection

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
        <SupportedOSPlatform("windows")>
        Public Function Open(ByVal fields As Properties.Fields, Optional ByVal splash As Form = Nothing) As Boolean
            Dim varSuccess As Boolean
            Try
                varConnection(1) = New MySqlClient.MySqlConnection(varMySQL.Mysqlforcessl(fields.ServerAddress, fields.Port, fields.DataStorage, fields.Username, fields.Password))
                varConnection(1).Open()
                varSuccess = True
            Catch ex As MySqlClient.MySqlException
                splash?.Close()
                varSuccess = False

                With proLog
                    .AppVersion = GetAppVersion()
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
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
            Return varSuccess
        End Function

        ''' <summary>
        ''' Executes a SQL query and returns a single DataRow from the result set.
        ''' </summary>
        ''' <param name="query">
        ''' The SQL query to execute. The method automatically prepends the database 
        ''' selection (USE databasename) before running the query.
        ''' </param>
        ''' <param name="databasename">
        ''' Optional. The target MySQL database name. Defaults to "defaultdb".
        ''' </param>
        ''' <returns>
        ''' A MySqlDataReader positioned at the first row of the result set. 
        ''' Returns Nothing if an exception occurs.
        ''' </returns>
        <SupportedOSPlatform("windows")>
        Public Function GetDataRow(ByVal query As String, ByVal databasename As String) As MySqlClient.MySqlDataReader
            Dim varDataReader(1) As MySqlClient.MySqlDataReader

            Try
                Dim varCommand0 As New MySqlClient.MySqlCommand

                query = "USE " & databasename & "; " & query

                varCommand0 = New MySqlClient.MySqlCommand(query, varConnection(1))
                varDataReader(1) = varCommand0.ExecuteReader(CommandBehavior.CloseConnection)

                If varDataReader(1).HasRows Then
                    varDataReader(1).Read()
                End If

                Return varDataReader(1)
            Catch ex As MySqlClient.MySqlException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
        <SupportedOSPlatform("windows")>
        Public Function GetValue(ByVal query As String, ByVal databasename As String) As Object
            Try
                Dim varRowValue As Object

                varCommand(1) = New MySqlClient.MySqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text,
                .CommandTimeout = 30}

                query = "USE " & databasename & "; " & query

                varCommand(1).CommandText = query

                varRowValue = varCommand(1).ExecuteScalar

                Return varRowValue

            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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

        ''' <summary>
        ''' Executes a SQL query and returns the results in a DataSet.
        ''' </summary>
        ''' <param name="dbr">
        ''' A request object containing the SQL query to execute.
        ''' </param>
        ''' <param name="tablename">
        ''' The name of the DataTable inside the DataSet where the query results 
        ''' will be stored.
        ''' </param>
        ''' <param name="databasename">
        ''' Optional. The target MySQL database name. Defaults to "defaultdb". 
        ''' The method automatically prepends a USE statement before executing the query.
        ''' </param>
        <SupportedOSPlatform("windows")>
        Public Function GetDataSet(ByVal dbr As Adapter.MySQL.Display.Request, ByVal tablename As String, ByVal databasename As String) As DataSet
            Dim varDataAdapter(1) As MySqlClient.MySqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingSource As New BindingSource

                If IsNothing(varCommand(1)) Then
                    varCommand(1) = New MySqlClient.MySqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                dbr.Query = "USE " & databasename & "; " & dbr.Query

                varCommand(1).CommandText = dbr.Query

                varDataAdapter(1) = New MySqlClient.MySqlDataAdapter(varCommand(1))
                varDataAdapter(1).Fill(varDataset, tablename)

                varBindingSource = New BindingSource(varDataset, tablename)

                Return varDataset
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataSet] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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

        ''' <summary>
        ''' Executes a SQL query and loads the results into a DataSet, then binds the 
        ''' resulting table to any UI components provided in the request object 
        ''' (DataGrid, Dropdown, StatusBar, or Chart).
        ''' </summary>
        ''' <param name="dbr">
        ''' A request object containing the SQL query and optional UI controls 
        ''' that will receive the resulting data (DataGrid, Dropdown, StatusBar, Chart).
        ''' </param>
        ''' <param name="tablename">
        ''' The name of the DataTable inside the DataSet where the query results 
        ''' will be stored and used as the binding source.
        ''' </param>
        ''' <param name="databasename">
        ''' Optional. The target MySQL database name. Defaults to "defaultdb". 
        ''' The method automatically prepends a USE statement before executing the query.
        ''' </param>
        <SupportedOSPlatform("windows")>
        Public Sub GetDataTable(ByVal dbr As Adapter.MySQL.Display.Request, ByVal tablename As String, Optional ByVal databasename As String = "defaultdb")

            Dim varDataAdapterPrivate(1) As MySqlClient.MySqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingSource As New BindingSource

                If (varCommand(1) Is Nothing) Then
                    varCommand(1) = New MySqlClient.MySqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                dbr.Query = "USE " & databasename & "; " & dbr.Query

                varCommand(1).CommandText = dbr.Query

                varDataAdapterPrivate(1) = New MySqlClient.MySqlDataAdapter(varCommand(1))
                varDataAdapterPrivate(1).Fill(varDataset, tablename)
                varBindingSource = New BindingSource(varDataset, tablename)

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

            Catch ex As MySqlClient.MySqlException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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

        ''' <summary>
        ''' Executes a non-query SQL command against the specified MySQL database.
        ''' This method is typically used for INSERT, UPDATE, DELETE, or other 
        ''' data‑manipulation statements.
        ''' </summary>
        ''' <param name="query">
        ''' The SQL command to execute. The method automatically prepends the 
        ''' database selection (USE databasename) before running the query.
        ''' </param>
        ''' <param name="databasename">
        ''' Optional. The target database name to apply the query to. 
        ''' Defaults to "defaultdb".
        ''' </param>
        <SupportedOSPlatform("windows")>
        Public Sub PushData(ByVal query As String, Optional ByVal databasename As String = "defaultdb")
            Try
                varCommand(1) = New MySqlClient.MySqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text}

                query = "USE " & databasename & "; " & query

                varCommand(1).CommandText = query
                varCommand(1).ExecuteNonQuery()
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[PushData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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
        <SupportedOSPlatform("windows")>
        Public Function PushImage(ByVal cmd As MySqlClient.MySqlCommand) As Boolean
            Dim varSuccess As Boolean

            Try
                varCommand(1) = New MySqlClient.MySqlCommand

                If cmd IsNot Nothing Then
                    varCommand(1) = cmd
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).ExecuteNonQuery()
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
                With proLog
                    .AppVersion = GetAppVersion()
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
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try

            Return varSuccess
        End Function

        ''' <summary>
        ''' Executes a SQL query against the specified MySQL database and fills the given DataSet 
        ''' with the results using the provided table name.
        ''' </summary>
        ''' <param name="query">
        ''' The SQL query to execute. The function automatically prepends the database selection (USE ...).
        ''' </param>
        ''' <param name="datasetname">
        ''' The DataSet instance that will receive the query results.
        ''' </param>
        ''' <param name="tablename">
        ''' The name of the DataTable inside the DataSet where the results will be stored.
        ''' </param>
        ''' <param name="databasename">
        ''' Optional. The target database name. Defaults to "defaultdb".
        ''' </param>
        ''' <returns>
        ''' The filled DataSet. Returns Nothing if an exception occurs.
        ''' </returns>
        <SupportedOSPlatform("windows")>
        Public Function FillDataSet(ByVal query As String, ByVal datasetname As DataSet, ByVal tablename As String, Optional ByVal databasename As String = "defaultdb") As DataSet
            GC.Collect()

            Try
                varCommand(1) = New MySqlClient.MySqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text}

                query = "USE " & databasename & "; " & query

                varCommand(1).CommandText = String.Format(CultureInfo.CurrentCulture, "RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", query)

                Using varDataAdapter = New MySqlClient.MySqlDataAdapter(varCommand(1))
                    varDataAdapter.Fill(datasetname, tablename)
                End Using
            Catch ex As Exception
                datasetname = Nothing
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb"
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

            Return datasetname
        End Function

        Public Sub Close()
            varConnection(1).Close()
            varConnection(1).Dispose()
        End Sub


        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
