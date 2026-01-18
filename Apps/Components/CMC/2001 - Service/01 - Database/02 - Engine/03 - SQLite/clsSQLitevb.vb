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
                Dim varDBpath As String = Nothing
                Dim varDBexists(3) As Boolean

                Dim varLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\ardhagp\Ingrid .NET"

                System.IO.Directory.CreateDirectory(varLocation & "\Resources")

                varDBpath = varLocation & "\Resources\catalog.db"
                If OperatingSystem.File.Info.IsExists(varDBpath) Then
                    varDBexists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\catalog.db", varLocation & "\Resources\catalog.db", True)
                    If OperatingSystem.File.Info.IsExists(varDBpath) Then
                        varDBexists(1) = True
                    Else
                        varDBexists(1) = False
                    End If
                End If

                varDBpath = varLocation & "\Resources\dev_catalog.db"
                If OperatingSystem.File.Info.IsExists(varDBpath) Then
                    varDBexists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\dev_catalog.db", varLocation & "\Resources\dev_catalog.db", True)
                    If OperatingSystem.File.Info.IsExists(varDBpath) Then
                        varDBexists(2) = True
                    Else
                        varDBexists(2) = False
                    End If
                End If

                varDBpath = varLocation & "\Resources\errlog.db"
                If OperatingSystem.File.Info.IsExists(varDBpath) Then
                    varDBexists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\errlog.db", varLocation & "\Resources\errlog.db", True)
                    If OperatingSystem.File.Info.IsExists(varDBpath) Then
                        varDBexists(3) = True
                    Else
                        varDBexists(3) = False
                    End If
                End If

                If ((varDBexists(1)) AndAlso (varDBexists(3))) OrElse ((varDBexists(2)) AndAlso (varDBexists(3))) Then
                    Return True
                Else
                    Return False
                End If
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
                        fields.DataStorage = .GetString(4)
                        fields.FileStorage = .GetString(5)
                        fields.DatabaseEngine = .GetString(6)
                    Else
                        fields.ServerAddress = String.Empty
                        fields.Username = String.Empty
                        fields.Password = String.Empty
                        fields.Port = 0
                        fields.DataStorage = String.Empty
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
                Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PushData("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & proLog.TypeOfFaulty & "','" & proLog.Message & "'," & proLog.Number & ",'" & proLog.InternalStackTrace & "'," & proLog.ShowErrorReporting & ",'" & NowDateTime & "');")
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
                Dim var_rowvalue As Object

                If (varConnection(1) Is Nothing) Then
                    varConnection(1).Open()
                End If

                varCommand(1) = New SQLite.SQLiteCommand With {
                                .Connection = varConnection(1),
                                .CommandTimeout = 30,
                                .CommandText = query
                    }

                var_rowvalue = varCommand(1).ExecuteScalar

                Return var_rowvalue
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

            Dim var_dataadapter(1) As SQLite.SQLiteDataAdapter

            Try
                GC.Collect()

                Dim var_dataset As New DataSet
                Dim var_bindingsource As New BindingSource

                If (varCommand(1) Is Nothing) Then
                    varCommand(1) = New SQLite.SQLiteCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandTimeout = 30

                varCommand(1).CommandText = dbr.Query

                var_dataadapter(1) = New SQLite.SQLiteDataAdapter(varCommand(1))
                var_dataadapter(1).Fill(var_dataset, tablename)

                var_bindingsource = New BindingSource(var_dataset, tablename)

                If Not (dbr.DataGrid Is Nothing) Then
                    dbr.DataGrid.DataSource = var_bindingsource
                End If

                If Not (dbr.Dropdown Is Nothing) Then
                    dbr.Dropdown.DataSource = var_bindingsource
                End If

                If Not (dbr.StatusBar Is Nothing) AndAlso (dbr.StatusBar.Items.Count <> 0) Then
                    dbr.StatusBar.Items(0).Text = var_bindingsource.Count & " Row(s)"
                End If

                If Not (dbr.Chart Is Nothing) Then
                    dbr.Chart.DataSource = var_bindingsource
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
                Using TX = varConnection(1).BeginTransaction
                    Dim W_CMD = varConnection(1).CreateCommand
                    W_CMD.CommandText = query

                    W_CMD.ExecuteNonQuery()

                    TX.Commit()
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
