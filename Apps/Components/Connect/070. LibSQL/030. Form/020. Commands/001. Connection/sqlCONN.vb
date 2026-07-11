Imports System.Runtime.Versioning

Namespace CMDconn
    <SupportedOSPlatform("windows")>
    Public Class View

        Public Shared Sub DisplayData(datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt,
                                      find As CMCv.UI.Control.Txt, datasetname As System.Data.DataSet, Optional forcerefresh As Boolean = False)
            Try
                If (find.XOSqlText = String.Empty) OrElse (forcerefresh) Then 'to display all data
                    varDatabaseRequestSqlite(0).Query = $"select serverlist.ID, serverlist.CONNECTIONNAME, " &
                                                        $"serverlist.DATABASEENGINE, IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERADDRESS) || 'c', '*'), 1), serverlist.SERVERADDRESS) as 'SERVERADDRESS', " &
                                                        $"IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERPORT) || 'c', '*'), 1), serverlist.SERVERPORT) as 'SERVERPORT', " &
                                                        $"serverlist.DEFAULTCONNECTION from serverlist " &
                                                        $"ORDER BY serverlist.CONNECTIONNAME;"
                Else 'to display filtered data
                    varDatabaseRequestSqlite(0).Query = $"select serverlist.ID, serverlist.CONNECTIONNAME, " &
                                                        $"serverlist.DATABASEENGINE, IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERADDRESS) || 'c', '*'), 1), serverlist.SERVERADDRESS) as 'SERVERADDRESS', " &
                                                        $"IIF( serverlist.ISMASKED = 1, substr(printf('%.' || length(serverlist.SERVERPORT) || 'c', '*'), 1), serverlist.SERVERPORT) as 'SERVERPORT', " &
                                                        $"serverlist.DEFAULTCONNECTION from serverlist " &
                                                        $"where (serverlist.CONNECTIONNAME Like '%{find.XOSqlText}%')" &
                                                        $"ORDER BY serverlist.CONNECTIONNAME;"
                End If
                varDatabaseRequestSqlite(0).DataGrid = datagrid
                varDatabaseRequestSqlite(0).StatusBar = statusbar
                varDatabaseEngineSqlite.GetDataTable(varDatabaseRequestSqlite(0), datasetname, "serverlist")
                'varDatabaseEngineSqlite.FillDataSet(varDatabaseRequestSqlite(0).Query, datasetname, "serverlist")
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
                .Query = $"select serverlist.CONNECTIONNAME from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionName = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.DATABASEENGINE from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionDatabaseEngine = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.SERVERADDRESS from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionServerAddress = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.SERVERPORT from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionServerPort = Convert.ToInt32(varDatabaseEngineSqlite.GetValue(.Query))

                .Query = $"select serverlist.USERNAME from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionUsername = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.PASSWORD from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionPassword = CMCv.Security.Decrypt.Aes(varDatabaseEngineSqlite.GetValue(.Query).ToString)
                globalproperties.ConnectionPasswordOld = globalproperties.ConnectionPassword

                .Query = $"select serverlist.DBFORDATA from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionDatabaseName = varDatabaseEngineSqlite.GetValue(.Query).ToString

                .Query = $"select serverlist.DEFAULTCONNECTION from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionIsDefault = Convert.ToBoolean(varDatabaseEngineSqlite.GetValue(.Query))

                .Query = $"select serverlist.ISMASKED from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionIsMasked = Convert.ToBoolean(varDatabaseEngineSqlite.GetValue(.Query))

                .Query = $"select serverlist.CLIENT from serverlist where serverlist.ID ='{globalproperties.ConnectionId}'"
                globalproperties.ConnectionClientCode = varDatabaseEngineSqlite.GetValue(.Query).ToString

            End With
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(globalproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean
            Dim varIsDefaultActivate As String = ""

            Try
                If (globalproperties.ConnectionIsDefault) Then 'to check if isdefault is set
                    varIsDefaultActivate = "update serverlist set DEFAULTCONNECTION=0;"
                End If

                With varDatabaseRequestSqlite(1)
                    If (globalproperties.ConnectionIsNew) Then
                        .Query = varIsDefaultActivate & $"insert into serverlist(ID, CONNECTIONNAME, DATABASEENGINE, SERVERADDRESS, SERVERPORT, USERNAME, PASSWORD, DBFORDATA, DBFORFILE, DEFAULTCONNECTION, ISMASKED, CLIENT) values ('{globalproperties.ConnectionId}','{globalproperties.ConnectionName}','{globalproperties.ConnectionDatabaseEngine}','{globalproperties.ConnectionServerAddress}',{globalproperties.ConnectionServerPort},'{globalproperties.ConnectionUsername}','{Security.Encrypt.Aes(globalproperties.ConnectionPassword)}','{globalproperties.ConnectionDatabaseName}','',{globalproperties.ConnectionIsDefault},{globalproperties.ConnectionIsMasked},'{globalproperties.ConnectionClientCode}')"
                    Else
                        If Not (globalproperties.ConnectionIsPasswordChanged) Then
                            .Query = varIsDefaultActivate & $"update serverlist set CONNECTIONNAME='{globalproperties.ConnectionName}', DATABASEENGINE='{globalproperties.ConnectionDatabaseEngine}', SERVERADDRESS='{globalproperties.ConnectionServerAddress}', SERVERPORT={globalproperties.ConnectionServerPort}, USERNAME='{globalproperties.ConnectionUsername}', DBFORDATA='{globalproperties.ConnectionDatabaseName}', DEFAULTCONNECTION={globalproperties.ConnectionIsDefault}, CLIENT='{globalproperties.ConnectionClientCode}' where ID='{globalproperties.ConnectionId}'"
                        Else
                            .Query = varIsDefaultActivate & $"update serverlist set CONNECTIONNAME='{globalproperties.ConnectionName}', DATABASEENGINE='{globalproperties.ConnectionDatabaseEngine}', SERVERADDRESS='{globalproperties.ConnectionServerAddress}', SERVERPORT={globalproperties.ConnectionServerPort}, USERNAME='{globalproperties.ConnectionUsername}', PASSWORD='{Security.Encrypt.Aes(globalproperties.ConnectionPassword)}', DBFORDATA='{globalproperties.ConnectionDatabaseName}', DEFAULTCONNECTION={globalproperties.ConnectionIsDefault}, CLIENT='{globalproperties.ConnectionClientCode}' where ID='{globalproperties.ConnectionId}'"
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


