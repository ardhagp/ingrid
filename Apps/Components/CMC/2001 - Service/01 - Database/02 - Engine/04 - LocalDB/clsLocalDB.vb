Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class LocalDB
        Private ReadOnly v_CS(2) As String
        Private ReadOnly v_FilePath(2) As String

        Private ReadOnly v_CONN(2) As SqlClient.SqlConnection
        Private ReadOnly v_CMD(2) As SqlClient.SqlCommand
        Private ReadOnly v_DR(2) As SqlClient.SqlDataReader

        Private ReadOnly v_LocalDB As New Connect.LocalDBConnection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim var_dbpath As String = Nothing
                Dim var_dbexists(3) As Boolean

                Dim var_location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                System.IO.Directory.CreateDirectory(var_location & "\Resources")

                var_dbpath = var_location & "\Resources\CATALOG.mdf"
                If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                    var_dbexists(1) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\CATALOG.mdf", var_location & "\Resources\CATALOG.mdf", True)
                    If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                        var_dbexists(1) = True
                    Else
                        var_dbexists(1) = False
                    End If
                End If

                var_dbpath = var_location & "\Resources\DEV_CATALOG.mdf"
                If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                    var_dbexists(2) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\DEV_CATALOG.mdf", var_location & "\Resources\DEV_CATALOG.mdf", True)
                    If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                        var_dbexists(2) = True
                    Else
                        var_dbexists(2) = False
                    End If
                End If

                var_dbpath = var_location & "\Resources\ERRLOG.mdf"
                If OperatingSystem.File.Info.IsExists(var_dbpath) Then
                    var_dbexists(3) = True
                Else
                    System.IO.File.Copy(Application.StartupPath & "\Resources\ERRLOG.mdf", var_location & "\Resources\ERRLOG.mdf", True)
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
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                Dim var_location As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Cagak Melon\Ingrid"

                If Not (CheckDBCatalog()) Then
                    Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, "File configuration Not found", 0.ToString, "", GETAPPVERSION, False, True, False)
                    Call PUSHERRORDATASHOW()
                    Return
                End If

                If (IsProductionMode) Then
                    v_FilePath(0) = var_location & "\Resources\CATALOG.mdf"
                Else
                    v_FilePath(0) = var_location & "\Resources\DEV_CATALOG.mdf"
                End If

                Dim V_FileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(v_FilePath(0)) Then
                    v_CS(0) = v_LocalDB.LocalDBInitialCatalog(v_FilePath(0))

                    v_CONN(1) = New SqlClient.SqlConnection(v_CS(0)) 'OleDb.OleDbConnection(_CS(0))
                    v_CONN(1).Open()
                    'Else
                    '    GoTo FileNotFound
                End If

                v_FilePath(1) = var_location & "\Resources\ERRLOG.mdf"

                If OperatingSystem.File.Info.IsExists(v_FilePath(1)) Then
                    v_CS(1) = v_LocalDB.LocalDBInitialCatalog(v_FilePath(1))

                    v_CONN(2) = New SqlClient.SqlConnection(v_CS(1))
                    v_CONN(2).Open()
                    'Else
                    '    GoTo FileNotFound
                End If
                'FileNotFound:
                '                MsgBox("One Of your components has been missing", MsgBoxStyle.OkOnly, "Ingrid Supporting App")
                'Application.Exit()
            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Properties.Fields) As Database.Properties.Fields
            Try
                v_DR(1) = GETDATAROW("Select LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.SERVERPORT, LIST.DBFORDATA, LIST.DBFORFILE FROM LIST WHERE LIST.DEFAULTCONNECTION =1;")

                With v_DR(1)
                    Fields.ServerAddress = .GetString(0)
                    Fields.Username = .GetString(1)
                    Fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                    Fields.Port = CType(.GetValue(3), Integer)
                    Fields.DataStorage = .GetString(4)
                    Fields.FileStorage = .GetString(5)
                End With

                Return Fields
            Catch ex As Exception
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
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
                PUSHERRORDATA("[SaveErrorData] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function GETDATAROW(ByVal Query As String) As SqlClient.SqlDataReader
            Try
                v_CMD(1) = New SqlClient.SqlCommand With {
                            .Connection = v_CONN(1),
                            .CommandType = CommandType.Text,
                            .CommandText = Query
                }

                v_DR(0) = v_CMD(1).ExecuteReader

                If v_DR(0).HasRows Then
                    v_DR(0).Read()
                End If

                Return v_DR(0)
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETVALUE(ByVal Query As String) As Object
            Try
                Dim v_ROWValue As Object

                v_CMD(1) = New SqlClient.SqlCommand With {
                            .Connection = v_CONN(1),
                            .CommandType = CommandType.Text,
                            .CommandTimeout = 30,
                            .CommandText = Query
                }

                v_ROWValue = v_CMD(1).ExecuteScalar

                Return v_ROWValue
            Catch ex As Exception
                Call PUSHERRORDATA("[GETVALUE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub GETDATATABLE(ByVal DBR As Adapter.LocalDB.Display.Request, ByVal TableName As String)

            Dim v_DA(1) As SqlClient.SqlDataAdapter

            Try
                'If _DR(1) IsNot Nothing Then
                '    _DR(1).Close()
                'End If

                GC.Collect()

                Dim varDataset As New DataSet
                Dim v_BS As New BindingSource

                If (v_CMD(1) Is Nothing) Then 'Or (_CMD = Nothing) Then
                    v_CMD(1) = New SqlClient.SqlCommand
                End If

                v_CMD(1).Connection = v_CONN(1)
                v_CMD(1).CommandType = CommandType.Text
                v_CMD(1).CommandTimeout = 30

                'DBR.Query = "USE " & _FilePath(0) & " " & DBR.Query

                v_CMD(1).CommandText = DBR.Query

                v_DA(1) = New SqlClient.SqlDataAdapter(v_CMD(1))
                v_DA(1).Fill(varDataset, TableName)

                v_BS = New BindingSource(varDataset, TableName)

                If Not (DBR.DataGrid Is Nothing) Then
                    DBR.DataGrid.DataSource = v_BS
                End If

                If Not (DBR.Dropdown Is Nothing) Then
                    DBR.Dropdown.DataSource = v_BS
                End If

                If Not (DBR.StatusBar Is Nothing) AndAlso (DBR.StatusBar.Items.Count <> 0) Then
                    DBR.StatusBar.Items(0).Text = v_BS.Count & " Row(s)"
                End If

                If Not (DBR.Chart Is Nothing) Then
                    DBR.Chart.DataSource = v_BS
                End If

            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As InvalidCastException
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            Catch ex As Exception
                Call PUSHERRORDATA("[GETDATATABLE] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub PUSHDATA(ByVal Query As String)
            Try
                v_CMD(1) = New SqlClient.SqlCommand With {
                                .Connection = v_CONN(1),
                                .CommandType = CommandType.Text,
                                .CommandText = Query
                                }

                v_CMD(1).ExecuteNonQuery()
            Catch ex As SqlClient.SqlException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\04 - LocalDB\clsLocalDB.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        Public Sub Close()
            v_CONN(1).Close()
            v_CONN(2).Close()
            v_CONN(1).Dispose()
            v_CONN(2).Dispose()
        End Sub
    End Class
End Namespace
