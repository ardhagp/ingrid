Imports System.Data
Imports System.Globalization
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv.Database.Adapter
Imports MySql.Data

Namespace Database.Engine
    Public Class MySQL
        Implements IDisposable

        Private ReadOnly V_CONN(1) As MySqlClient.MySqlConnection
        Private ReadOnly V_CMD(1) As MySqlClient.MySqlCommand
        Private V_Adapter As MySqlClient.MySqlDataAdapter

        Private ReadOnly V_MySQL As New Connect.MySQLConnection

        Private disposedValue As Boolean

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    V_Adapter?.Dispose()
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                ' TODO: set large fields to null
                disposedValue = True
            End If
        End Sub

        ' 'TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
        ' Protected Overrides Sub Finalize()
        '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        '     Dispose(disposing:=False)
        '     MyBase.Finalize()
        ' End Sub

        <SupportedOSPlatform("windows")>
        Public Function Open(ByVal Fields As Properties.Fields, Optional ByVal Splash As Form = Nothing) As Boolean
            Dim V_Success As Boolean
            Try
                V_CONN(1) = New MySqlClient.MySqlConnection(V_MySQL.Mysqlforcessl(Fields.ServerAddress, Fields.Port, Fields.DataStorage, Fields.Username, Fields.Password))
                V_CONN(1).Open()
                V_Success = True
            Catch ex As MySqlClient.MySqlException
                Splash?.Close()
                V_Success = False
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
                Call PUSHERRORDATASHOW()
            End Try
            Return V_Success
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETDATAROW(ByVal Query As String, Optional ByVal DatabaseName As String = "defaultdb") As MySqlClient.MySqlDataReader ', ByVal MyConnection As SqlClient.SqlConnection, ByVal MyCommand As SqlClient.SqlCommand) As SqlClient.SqlDataReader
            Dim V_DR(1) As MySqlClient.MySqlDataReader

            Try
                Dim V_CMD_0 As New MySqlClient.MySqlCommand

                Query = "USE " & DatabaseName & "; " & Query

                V_CMD_0 = New MySqlClient.MySqlCommand(Query, V_CONN(1))
                V_DR(1) = V_CMD_0.ExecuteReader(CommandBehavior.CloseConnection)

                If V_DR(1).HasRows Then
                    V_DR(1).Read()
                End If

                Return V_DR(1)
            Catch ex As MySqlClient.MySqlException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, 0.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String, Optional ByVal DatabaseName As String = "defaultdb") As Object
            Try
                Dim V_ROWValue As Object

                V_CMD(1) = New MySqlClient.MySqlCommand With {
                .Connection = V_CONN(1),
                .CommandType = CommandType.Text,
                .CommandTimeout = 30}

                Query = "USE " & DatabaseName & "; " & Query

                V_CMD(1).CommandText = Query

                V_ROWValue = V_CMD(1).ExecuteScalar

                Return V_ROWValue

            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETDATASET(ByVal DBR As Adapter.MySQL.Display.Request, ByVal TableName As String, Optional ByVal DatabaseName As String = "defaultdb") As DataSet
            Dim V_DA(1) As MySqlClient.MySqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim V_BS As New BindingSource

                If IsNothing(V_CMD(1)) Then
                    V_CMD(1) = New MySqlClient.MySqlCommand
                End If

                V_CMD(1).Connection = V_CONN(1)
                V_CMD(1).CommandType = CommandType.Text
                V_CMD(1).CommandTimeout = 30

                DBR.Query = "USE " & DatabaseName & "; " & DBR.Query

                V_CMD(1).CommandText = DBR.Query

                V_DA(1) = New MySqlClient.MySqlDataAdapter(V_CMD(1))
                V_DA(1).Fill(varDataset, TableName)

                V_BS = New BindingSource(varDataset, TableName)

                Return varDataset
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATASET] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, 0.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.MySQL.Display.Request, ByVal TableName As String, Optional ByVal DatabaseName As String = "defaultdb")

            Dim V_DA(1) As MySqlClient.MySqlDataAdapter

            Try
                GC.Collect()

                Dim varDataset As New DataSet
                Dim V_BS As New BindingSource

                If (V_CMD(1) Is Nothing) Then
                    V_CMD(1) = New MySqlClient.MySqlCommand
                End If

                V_CMD(1).Connection = V_CONN(1)
                V_CMD(1).CommandType = CommandType.Text
                V_CMD(1).CommandTimeout = 30

                DBR.Query = "USE " & DatabaseName & "; " & DBR.Query

                V_CMD(1).CommandText = DBR.Query

                V_DA(1) = New MySqlClient.MySqlDataAdapter(V_CMD(1))
                V_DA(1).Fill(varDataset, TableName)
                V_BS = New BindingSource(varDataset, TableName)

                If Not (DBR.DataGrid Is Nothing) Then
                    DBR.DataGrid.DataSource = V_BS
                End If

                If Not (DBR.Dropdown Is Nothing) Then
                    DBR.Dropdown.DataSource = V_BS
                End If

                If Not (DBR.StatusBar Is Nothing) AndAlso (DBR.StatusBar.Items.Count <> 0) Then
                    DBR.StatusBar.Items(0).Text = V_BS.Count & " Row(s)"
                End If

                If Not (DBR.Chart Is Nothing) Then
                    DBR.Chart.DataSource = V_BS
                End If

            Catch ex As MySqlClient.MySqlException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String, Optional ByVal DatabaseName As String = "defaultdb")
            Try
                V_CMD(1) = New MySqlClient.MySqlCommand With {
                .Connection = V_CONN(1),
                .CommandType = CommandType.Text}

                Query = "USE " & DatabaseName & "; " & Query

                V_CMD(1).CommandText = Query
                V_CMD(1).ExecuteNonQuery()
            Catch ex As Exception
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "0", ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function PUSHIMAGE(ByVal CMD As MySqlClient.MySqlCommand) As Boolean
            Dim V_Success As Boolean

            Try
                V_CMD(1) = New MySqlClient.MySqlCommand

                If CMD IsNot Nothing Then
                    V_CMD(1) = CMD
                End If

                V_CMD(1).Connection = V_CONN(1)
                V_CMD(1).CommandType = CommandType.Text
                V_CMD(1).ExecuteNonQuery()
                V_Success = True
            Catch ex As Exception
                V_Success = False
                Call PUSHERRORDATA("[PUSHIMAGE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try

            Return V_Success
        End Function

        Public Function FILLDATASET(ByVal Query As String, ByVal DataSetName As DataSet, ByVal TableName As String, Optional ByVal DatabaseName As String = "defaultdb") As DataSet
            GC.Collect()

            Try
                V_CMD(1) = New MySqlClient.MySqlCommand With {
                .Connection = V_CONN(1),
                .CommandType = CommandType.Text}

                Query = "USE " & DatabaseName & "; " & Query

                V_CMD(1).CommandText = String.Format(CultureInfo.CurrentCulture, "RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)
                V_Adapter = New MySqlClient.MySqlDataAdapter(V_CMD(1))
                V_Adapter.Fill(DataSetName, TableName)
                V_Adapter = Nothing
                V_Adapter.Dispose()
            Catch ex As Exception
                DataSetName = Nothing
                Call PUSHERRORDATA("[FILLDATASET] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\05 - MySQL\clsMySQL.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, False, False)
            End Try

            Return DataSetName
        End Function

        Public Sub Close()
            V_CONN(1).Close()
            V_CONN(1).Dispose()
        End Sub


        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
