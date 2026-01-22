Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class Mssql2008
        Implements IDisposable

        Private ReadOnly varConnection(1) As SqlClient.SqlConnection
        Private ReadOnly varCommand(1) As SqlClient.SqlCommand
        Private varAdapter As SqlClient.SqlDataAdapter

        Private ReadOnly varMssql2008Connection As New Connect.Mssqlserver2008connection

        Public Enum DatabaseID
            DbDefault
            DbCustom
        End Enum

        Private disposedValue As Boolean

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing AndAlso varAdapter IsNot Nothing Then
                    varAdapter.Dispose()
                End If

                varAdapter = Nothing
                disposedValue = True
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="fields"></param>
        ''' <param name="splash"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function Open(databaseproperties As LibApp.Ingrid.Global.Properties, Optional splash As Form = Nothing) As Boolean
            If databaseproperties Is Nothing Then
                databaseproperties = New LibApp.Ingrid.Global.Properties
            End If

            Dim varSuccess As Boolean
            Try
                varConnection(1) = New SqlClient.SqlConnection(varMssql2008Connection.Mssql2008standard(databaseproperties.ServerAddress, databaseproperties.ServerPort, databaseproperties.DatabaseName, databaseproperties.Username, databaseproperties.Password))
                varConnection(1).Open()
                varSuccess = True
            Catch ex As SqlClient.SqlException
                splash?.Close()
                varSuccess = False

                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="query"></param>
        ''' <param name="databasename"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function GetDataRow(ByVal query As String, ByVal databasename As String) As SqlClient.SqlDataReader ', ByVal MyConnection As SqlClient.SqlConnection, ByVal MyCommand As SqlClient.SqlCommand) As SqlClient.SqlDataReader
            Dim varDataReader(1) As SqlClient.SqlDataReader

            Try
                Dim varCommand0 As New SqlClient.SqlCommand

                query = "USE " & databasename & "; " & query

                varCommand0 = New SqlClient.SqlCommand(query, varConnection(1))
                varDataReader(1) = varCommand0.ExecuteReader(CommandBehavior.CloseConnection)

                If varDataReader(1).HasRows Then
                    varDataReader(1).Read()
                End If

                Return varDataReader(1)
            Catch ex As SqlClient.SqlException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="query"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function GetValue(databasename As String, query As String) As Object
            Try
                Dim varRowValue As Object

                varCommand(1) = New SqlClient.SqlCommand With {
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
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbr"></param>
        ''' <param name="tablename"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function GetDataSet(databasename As String, dbr As Adapter.MSSQL2008.Display.Request, tablename As String) As DataSet
            Dim varDataAdapter(1) As SqlClient.SqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingSource As New BindingSource

                If IsNothing(varCommand(1)) Then
                    varCommand(1) = New SqlClient.SqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                dbr.Query = "USE " & databasename & "; " & dbr.Query

                varCommand(1).CommandText = dbr.Query

                varDataAdapter(1) = New SqlClient.SqlDataAdapter(varCommand(1))
                varDataAdapter(1).Fill(varDataset, tablename)

                varBindingSource = New BindingSource(varDataset, tablename)

                Return varDataset
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataSet] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbr"></param>
        ''' <param name="tablename"></param>
        <SupportedOSPlatform("windows")>
        Public Sub GetDataTable(databasename As String, dbr As Adapter.MSSQL2008.Display.Request, ByVal tablename As String)

            Dim varDataAdapter(1) As SqlClient.SqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingSource As New BindingSource

                If (varCommand(1) Is Nothing) Then
                    varCommand(1) = New SqlClient.SqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                dbr.Query = "USE " & databasename & "; " & dbr.Query

                varCommand(1).CommandText = dbr.Query

                varDataAdapter(1) = New SqlClient.SqlDataAdapter(varCommand(1))
                varDataAdapter(1).Fill(varDataset, tablename)
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

            Catch ex As SqlClient.SqlException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="query"></param>
        <SupportedOSPlatform("windows")>
        Public Sub PushData(databasename As String, query As String)
            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text}

                query = "USE " & databasename & "; " & query

                varCommand(1).CommandText = String.Format(Globalization.CultureInfo.InvariantCulture, "RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", query)
                varCommand(1).ExecuteNonQuery()
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[PushData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="cmd"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function PushImage(ByVal cmd As SqlClient.SqlCommand) As Boolean
            Dim varSuccess As Boolean

            Try
                varCommand(1) = New SqlClient.SqlCommand

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
                    .FromSender = "[PushImage] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="query"></param>
        ''' <param name="datasetname"></param>
        ''' <param name="tablename"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function FillDataset(databasename As String, query As String, datasetname As DataSet, tablename As String) As DataSet
            GC.Collect()

            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                .Connection = varConnection(1),
                .CommandType = CommandType.Text}

                query = "USE " & databasename & "; " & query

                varCommand(1).CommandText = String.Format(Globalization.CultureInfo.InvariantCulture, "RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", query)

                Using varAdapter = New SqlClient.SqlDataAdapter(varCommand(1))
                    varAdapter.Fill(datasetname, tablename)
                End Using

                'varAdapter = Nothing
                'varAdapter.Dispose()
            Catch ex As Exception
                datasetname = Nothing

                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[FillDataset] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\02 - MS SQL Server 2008\clsMSSQL2008.vb"
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
    End Class

End Namespace
