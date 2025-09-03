Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Versioning

Namespace Database.Engine
    Public Class SQLiteV3
        Private ReadOnly var_connectionstring(2) As String
        Private ReadOnly var_filepath(2) As String

        Private ReadOnly var_connection(2) As SQLite.SQLiteConnection
        Private ReadOnly var_command(2) As SQLite.SQLiteCommand
        Private ReadOnly var_datareader(2) As SQLite.SQLiteDataReader

        Private ReadOnly var_sqlite As New Connect.SQLiteConnection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim var_dbpath As String = Nothing
                Dim var_dbexists(3) As Boolean

                Dim var_location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                System.IO.Directory.CreateDirectory(var_location & "\Resources")

                var_dbpath = var_location & "\Resources\catalog.db"
                If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                    var_dbexists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\catalog.db", var_location & "\Resources\catalog.db", True)
                    If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                        var_dbexists(1) = True
                    Else
                        var_dbexists(1) = False
                    End If
                End If

                var_dbpath = var_location & "\Resources\dev_catalog.db"
                If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                    var_dbexists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\dev_catalog.db", var_location & "\Resources\dev_catalog.db", True)
                    If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                        var_dbexists(2) = True
                    Else
                        var_dbexists(2) = False
                    End If
                End If

                var_dbpath = var_location & "\Resources\errlog.db"
                If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                    var_dbexists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\errlog.db", var_location & "\Resources\errlog.db", True)
                    If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                        var_dbexists(3) = True
                    Else
                        var_dbexists(3) = False
                    End If
                End If

                If ((var_dbexists(1)) AndAlso (var_dbexists(3))) OrElse ((var_dbexists(2)) AndAlso (var_dbexists(3))) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                Dim var_location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                If Not (CheckDBCatalog()) Then
                    Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration Not found", 0.ToString, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Return
                End If

                If (IsProductionMode) Then
                    var_filepath(0) = var_location & "\Resources\catalog.db"
                Else
                    var_filepath(0) = var_location & "\Resources\dev_catalog.db"
                End If

                Dim var_fileinfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(var_filepath(0)) Then
                    var_filepath(0) = Replace(var_filepath(0), "\", "\\")

                    var_connectionstring(0) = var_sqlite.SQLiteBasic(var_filepath(0))

                    var_connection(1) = New SQLite.SQLiteConnection(var_connectionstring(0)) 'OleDb.OleDbConnection(_CS(0))
                    var_connection(1).Open()
                End If

                var_filepath(1) = var_location & "\Resources\errlog.db"

                If OperatingSystem.File.Info.IsExists(var_filepath(1)) Then
                    var_filepath(1) = Replace(var_filepath(1), "\", "\\")

                    var_connectionstring(1) = var_sqlite.SQLiteBasic(var_filepath(1))

                    var_connection(2) = New SQLite.SQLiteConnection(var_connectionstring(1))
                    var_connection(2).Open()
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub OpenAppSettings()
            Try

            Catch ex As Exception
                Call PUSHERRORDATA("[OpenAppSettings] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                var_datareader(1) = GETDATAROW("Select SERVERADDRESS, USERNAME, PASSWORD, SERVERPORT, DBFORDATA, DBFORFILE, DATABASEENGINE FROM serverlist WHERE DEFAULTCONNECTION =1;")

                With var_datareader(1)
                    If .HasRows Then
                        Fields.ServerAddress = .GetString(0)
                        Fields.Username = .GetString(1)
                        Fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                        Fields.Port = CType(.GetValue(3), Integer)
                        Fields.DataStorage = .GetString(4)
                        Fields.FileStorage = .GetString(5)
                        Fields.DatabaseEngine = .GetString(6)
                    Else
                        Fields.ServerAddress = String.Empty
                        Fields.Username = String.Empty
                        Fields.Password = String.Empty
                        Fields.Port = 0
                        Fields.DataStorage = String.Empty
                        Fields.FileStorage = String.Empty
                        Fields.DatabaseEngine = String.Empty
                    End If
                End With

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Try
                Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & NowDateTime & "');")
            Catch ex As Exception
                PUSHERRORDATA("[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function GETDATAROW(ByVal Query As String) As SQLite.SQLiteDataReader
            Try
                var_command(1) = New SQLite.SQLiteCommand With {
                                .Connection = var_connection(1),
                                .CommandType = CommandType.Text,
                                .CommandText = Query
                                                    }

                var_datareader(0) = var_command(1).ExecuteReader

                If var_datareader(0).HasRows Then
                    var_datareader(0).Read()
                End If

                Return var_datareader(0)
            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String) As Object
            Try
                Dim var_rowvalue As Object

                If (var_connection(1) Is Nothing) Then
                    var_connection(1).Open()
                End If

                var_command(1) = New SQLite.SQLiteCommand With {
                                .Connection = var_connection(1),
                                .CommandTimeout = 30,
                                .CommandText = Query
                    }

                var_rowvalue = var_command(1).ExecuteScalar

                Return var_rowvalue
            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.SQLite.Display.Request, ByVal TableName As String)

            Dim var_dataadapter(1) As SQLite.SQLiteDataAdapter

            Try
                GC.Collect()

                Dim var_dataset As New DataSet
                Dim var_bindingsource As New BindingSource

                If (var_command(1) Is Nothing) Then
                    var_command(1) = New SQLite.SQLiteCommand
                End If

                var_command(1).Connection = var_connection(1)
                var_command(1).CommandTimeout = 30

                var_command(1).CommandText = DBR.Query

                var_dataadapter(1) = New SQLite.SQLiteDataAdapter(var_command(1))
                var_dataadapter(1).Fill(var_dataset, TableName)

                var_bindingsource = New BindingSource(var_dataset, TableName)

                If Not (DBR.DataGrid Is Nothing) Then
                    DBR.DataGrid.DataSource = var_bindingsource
                End If

                If Not (DBR.Dropdown Is Nothing) Then
                    DBR.Dropdown.DataSource = var_bindingsource
                End If

                If Not (DBR.StatusBar Is Nothing) AndAlso (DBR.StatusBar.Items.Count <> 0) Then
                    DBR.StatusBar.Items(0).Text = var_bindingsource.Count & " Row(s)"
                End If

                If Not (DBR.Chart Is Nothing) Then
                    DBR.Chart.DataSource = var_bindingsource
                End If

            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String)
            Try
                Using TX = var_connection(1).BeginTransaction
                    Dim W_CMD = var_connection(1).CreateCommand
                    W_CMD.CommandText = Query

                    W_CMD.ExecuteNonQuery()

                    TX.Commit()
                End Using

            Catch ex As SQLite.SQLiteException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\03 - SQLite\clsSQLitevb.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub Close()
            var_connection(1).Close()
            var_connection(2).Close()
            var_connection(1).Dispose()
            var_connection(2).Dispose()
        End Sub
    End Class
End Namespace
