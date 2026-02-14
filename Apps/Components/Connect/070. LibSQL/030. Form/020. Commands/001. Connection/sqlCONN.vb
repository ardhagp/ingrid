Imports System.Runtime.Versioning

Namespace CMDconn
    <SupportedOSPlatform("windows")>
    Public Class View

        Public Shared Sub DisplayData(datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt,
                                      find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            Try
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then 'to display all data
                    varDatabaseRequestSqlite(0).Query = "select serverlist.ID, serverlist.CONNECTIONNAME, " &
                        "serverlist.DATABASEENGINE, IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERADDRESS) || 'c', '*'), 1), serverlist.SERVERADDRESS) as 'SERVERADDRESS', IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERPORT) || 'c', '*'), 1), serverlist.SERVERPORT) as 'SERVERPORT', " &
                        "serverlist.DEFAULTCONNECTION from serverlist ORDER BY serverlist.CONNECTIONNAME;"
                Else 'to display filtered data
                    varDatabaseRequestSqlite(0).Query = String.Format("select serverlist.ID, serverlist.CONNECTIONNAME, " &
                                                          "serverlist.DATABASEENGINE, IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERADDRESS) || 'c', '*'), 1), serverlist.SERVERADDRESS) as 'SERVERADDRESS', " &
                                                          "IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERPORT) || 'c', '*'), 1), serverlist.SERVERPORT) as 'SERVERPORT', serverlist.DEFAULTCONNECTION from " &
                                                          "serverlist where (serverlist.CONNECTIONNAME Like '%{0}%')" &
                                                          "ORDER BY serverlist.CONNECTIONNAME;", find.XOSQLText)
                End If
                varDatabaseRequestSqlite(0).DataGrid = datagrid
                varDatabaseRequestSqlite(0).StatusBar = statusbar
                varDatabaseEngineSqlite.GetDataTable(varDatabaseRequestSqlite(0), "TDBList")
            Catch ex As Exception
                Dim clsLog As New Ladybug.Log.Events
                With proLog
                    .Message = ex.Message
                    .FromSender = ""
                    .Number = ex.HResult
                    .InternalStackTrace = ex.StackTrace
                    .SaveInBetterLog = True
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .AppVersion = GetAppVersion()
                End With
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        Public Shared Function DeleteData(rowid As String) As Boolean
            Dim varSuccess As Boolean
            Try
                varDatabaseRequestSqlite(1).Query = String.Format("DELETE FROM serverlist WHERE ID = '{0}';", rowid)
                varDatabaseEngineSqlite.PushData(varDatabaseRequestSqlite(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub GetRowValue(globalproperties As LibApp.Ingrid.Global.Properties)

            With varDatabaseRequestSqlite(1)
                .Query = $"select serverlist.CONNECTIONNAME from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.ConnectionName = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.DATABASEENGINE from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.DatabaseEngine = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.SERVERADDRESS from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.ServerAddress = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.SERVERPORT from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.ServerPort = Convert.ToInt32(varDatabaseEngineSqlite.GetValue(.Query))

                .Query = $"select serverlist.USERNAME from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.Username = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.PASSWORD from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.Password = CMCv.Security.Decrypt.AES(varDatabaseEngineSqlite.GetValue(.Query).ToString)
                globalproperties.PasswordOld = globalproperties.Password

                .Query = $"select serverlist.DBFORDATA from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.DatabaseName = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.DEFAULTCONNECTION from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.IsDefault = Convert.ToBoolean(varDatabaseEngineSqlite.GetValue(.Query))

                .Query = $"select serverlist.ISMASKED from serverlist where serverlist.ID ='{globalproperties.RowID}'"
                globalproperties.IsMasked = Convert.ToBoolean(varDatabaseEngineSqlite.GetValue(.Query))

            End With
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(globalproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean
            Dim varIsDefaultActivate As String = ""

            Try
                If (globalproperties.IsDefault) Then 'to check if isdefault is set
                    varIsDefaultActivate = "update serverlist set DEFAULTCONNECTION=0;"
                End If

                With varDatabaseRequestSqlite(1)
                    If (globalproperties.IsNew) Then
                        .Query = varIsDefaultActivate & $"insert into serverlist(ID, CONNECTIONNAME, DATABASEENGINE, SERVERADDRESS, SERVERPORT, USERNAME, PASSWORD, DBFORDATA, DBFORFILE, DEFAULTCONNECTION, ISMASKED) values ('{globalproperties.RowID}','{globalproperties.ConnectionName}','{globalproperties.DatabaseEngine}','{globalproperties.ServerAddress}',{globalproperties.ServerPort},'{globalproperties.Username}','{Security.Encrypt.AES(globalproperties.Password)}','{globalproperties.DatabaseName}','',{globalproperties.IsDefault},{globalproperties.IsMasked})"
                    Else
                        If Not (globalproperties.IsPasswordChanged) Then
                            .Query = varIsDefaultActivate & $"update serverlist set CONNECTIONNAME='{globalproperties.ConnectionName}', DATABASEENGINE='{globalproperties.DatabaseEngine}', SERVERADDRESS='{globalproperties.ServerAddress}', SERVERPORT={globalproperties.ServerPort}, USERNAME='{globalproperties.Username}', DBFORDATA='{globalproperties.DatabaseName}', DEFAULTCONNECTION={globalproperties.IsDefault} where ID='{globalproperties.RowID}'"
                        Else
                            .Query = varIsDefaultActivate & $"update serverlist set CONNECTIONNAME='{globalproperties.ConnectionName}', DATABASEENGINE='{globalproperties.DatabaseEngine}', SERVERADDRESS='{globalproperties.ServerAddress}', SERVERPORT={globalproperties.ServerPort}, USERNAME='{globalproperties.Username}', PASSWORD='{Security.Encrypt.AES(globalproperties.Password)}', DBFORDATA='{globalproperties.DatabaseName}', DEFAULTCONNECTION={globalproperties.IsDefault} where ID='{globalproperties.RowID}'"
                        End If
                    End If
                End With

                varDatabaseEngineSqlite.PushData(varDatabaseRequestSqlite(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace


