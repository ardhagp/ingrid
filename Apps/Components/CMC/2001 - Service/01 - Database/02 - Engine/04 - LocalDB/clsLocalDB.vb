Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class LocalDB
        Private ReadOnly varConnectionString(2) As String
        Private ReadOnly varFilePath(2) As String

        Private ReadOnly varConnection(2) As SqlClient.SqlConnection
        Private ReadOnly varCommand(2) As SqlClient.SqlCommand
        Private ReadOnly varDataReader(2) As SqlClient.SqlDataReader

        Private ReadOnly varLocalDB As New Connect.LocalDBConnection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDbCatalog() As Boolean
            Try
                Dim baseFolder = IO.Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "ardhagp\Ingrid .NET"
        )

                Dim resourcesFolder = IO.Path.Combine(baseFolder, "Resources")
                IO.Directory.CreateDirectory(resourcesFolder)

                Dim prodOk = EnsureDbExists("Resources\catalog.mdf", baseFolder)
                Dim devOk = EnsureDbExists("Resources\dev_catalog.mdf", baseFolder)
                Dim logOk = EnsureDbExists("Resources\errlog.mdf", baseFolder)

                Return (prodOk AndAlso logOk) OrElse (devOk AndAlso logOk)

            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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

                If Not (CheckDbCatalog()) Then
                    With proLog
                        .AppVersion = GetAppVersion()
                        .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
                    varFilePath(0) = varLocation & "\Resources\catalog.mdf"
                Else
                    varFilePath(0) = varLocation & "\Resources\dev_catalog.mdf"
                End If

                'Dim FileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(varFilePath(0)) Then
                    varConnectionString(0) = varLocalDB.LocalDBInitialCatalog(varFilePath(0))

                    varConnection(1) = New SqlClient.SqlConnection(varConnectionString(0)) 'OleDb.OleDbConnection(_CS(0))
                    varConnection(1).Open()
                    'Else
                    '    GoTo FileNotFound
                End If

                varFilePath(1) = varLocation & "\Resources\errlog.mdf"

                If OperatingSystem.File.Info.IsExists(varFilePath(1)) Then
                    varConnectionString(1) = varLocalDB.LocalDBInitialCatalog(varFilePath(1))

                    varConnection(2) = New SqlClient.SqlConnection(varConnectionString(1))
                    varConnection(2).Open()
                    'Else
                    '    GoTo FileNotFound
                End If
                'FileNotFound:
                '                MsgBox("One Of your components has been missing", MsgBoxStyle.OkOnly, "Ingrid Supporting App")
                'Application.Exit()
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
        Public Function GetDatabaseProperties(ByVal fields As Properties.Fields) As Database.Properties.Fields
            Try
                varDataReader(1) = GetDataRow("Select LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.SERVERPORT, LIST.DBFORDATA, LIST.DBFORFILE FROM LIST WHERE LIST.DEFAULTCONNECTION =1;")

                With varDataReader(1)
                    fields.ServerAddress = .GetString(0)
                    fields.Username = .GetString(1)
                    fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                    fields.Port = CType(.GetValue(3), Integer)
                    fields.DataStorage = .GetString(4)
                    fields.FileStorage = .GetString(5)
                End With

                Return fields
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
                Dim varNowdatetime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
                Call PushData("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & proLog.TypeOfFaulty & "','" & proLog.Message & "'," & proLog.Number & ",'" & proLog.InternalStackTrace & "'," & proLog.ShowErrorReporting & ",'" & varNowdatetime & "');")
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
        Private Function GetDataRow(ByVal query As String) As SqlClient.SqlDataReader
            Try
                varCommand(1) = New SqlClient.SqlCommand With {
                            .Connection = varConnection(1),
                            .CommandType = CommandType.Text,
                            .CommandText = query
                }

                varDataReader(0) = varCommand(1).ExecuteReader

                If varDataReader(0).HasRows Then
                    varDataReader(0).Read()
                End If

                Return varDataReader(0)
            Catch ex As SqlClient.SqlException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetDataRow] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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

                varCommand(1) = New SqlClient.SqlCommand With {
                            .Connection = varConnection(1),
                            .CommandType = CommandType.Text,
                            .CommandTimeout = 30,
                            .CommandText = query
                }

                varRowValue = varCommand(1).ExecuteScalar

                Return varRowValue
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetValue] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
        Public Sub GetDataTable(ByVal dbr As Adapter.LocalDB.Display.Request, ByVal tablename As String)

            Dim varDataAdapter(1) As SqlClient.SqlDataAdapter

            Try
                'If _DR(1) IsNot Nothing Then
                '    _DR(1).Close()
                'End If

                GC.Collect()

                Dim varDataset As New DataSet
                Dim varBindingSource As New BindingSource

                If (varCommand(1) Is Nothing) Then 'Or (_CMD = Nothing) Then
                    varCommand(1) = New SqlClient.SqlCommand
                End If

                varCommand(1).Connection = varConnection(1)
                varCommand(1).CommandType = CommandType.Text
                varCommand(1).CommandTimeout = 30

                'DBR.Query = "USE " & _FilePath(0) & " " & DBR.Query

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
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
                    .FromSender = "[GetDataTable] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
                varCommand(1) = New SqlClient.SqlCommand With {
                                .Connection = varConnection(1),
                                .CommandType = CommandType.Text,
                                .CommandText = query
                                }

                varCommand(1).ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[PushData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb"
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
