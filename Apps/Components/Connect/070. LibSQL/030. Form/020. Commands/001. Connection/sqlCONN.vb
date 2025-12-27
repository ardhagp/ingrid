Imports System.Runtime.Versioning

Namespace Commands.CONN
    <SupportedOSPlatform("windows")>
    Public Class View

        Public Shared Sub DisplayData(ByVal datagrid As CMCv.dgn, ByVal statusbar As CMCv.stt,
                                      ByVal find As CMCv.txt, Optional forcerefresh As Boolean = False)

            If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then 'to display all data
                V_DBR_SQLITE(0).Query = "select serverlist.ID, serverlist.CONNECTIONNAME, " &
                    "serverlist.DATABASEENGINE, serverlist.SERVERADDRESS, serverlist.SERVERPORT, " &
                    "serverlist.DEFAULTCONNECTION from serverlist ORDER BY serverlist.CONNECTIONNAME;"
            Else 'to display filtered data
                V_DBR_SQLITE(0).Query = String.Format("select serverlist.ID, serverlist.CONNECTIONNAME, " &
                                                      "serverlist.DATABASEENGINE, serverlist.SERVERADDRESS, " &
                                                      "serverlist.SERVERPORT, serverlist.DEFAULTCONNECTION from " &
                                                      "serverlist where (serverlist.CONNECTIONNAME Like '%{0}%') or " &
                                                      "(serverlist.SERVERADDRESS Like '%{0}%') or " &
                                                      "(serverlist.SERVERPORT like '%{0}%') " &
                                                      "ORDER BY serverlist.CONNECTIONNAME;", find.XOSQLText)
            End If
            V_DBR_SQLITE(0).DataGrid = datagrid
            V_DBR_SQLITE(0).StatusBar = statusbar
            V_DBE_SQLite.GETDATATABLE(V_DBR_SQLITE(0), "TDBList")
        End Sub

        Public Shared Function DELETEData(ByVal rowID As String) As Boolean
            Dim varSuccess As Boolean
            Try
                V_DBR_SQLITE(1).Query = String.Format("DELETE FROM serverlist WHERE ID = '{0}';", rowID)
                V_DBE_SQLite.PUSHDATA(V_DBR_SQLITE(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub GETRowValue(ByVal rowID As String, ByVal connectionname As CMCv.txt, ByVal dbengine As CMCv.cbo,
                                      ByVal address As CMCv.txt, ByVal port As CMCv.txt, ByVal username As CMCv.txt,
                                      ByVal password As CMCv.txt, ByVal databasename As CMCv.txt, ByVal oldpassword As String, ByVal isdefault As CMCv.chk)
            V_DBR_SQLITE(1).Query = String.Format("select serverlist.CONNECTIONNAME from serverlist where serverlist.ID ='{0}'", rowID)
            connectionname.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            V_DBR_SQLITE(1).Query = String.Format("select serverlist.DATABASEENGINE from serverlist where serverlist.ID ='{0}'", rowID)
            dbengine.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            V_DBR_SQLITE(1).Query = String.Format("select serverlist.SERVERADDRESS from serverlist where serverlist.ID ='{0}'", rowID)
            address.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            V_DBR_SQLITE(1).Query = String.Format("select serverlist.SERVERPORT from serverlist where serverlist.ID ='{0}'", rowID)
            port.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            V_DBR_SQLITE(1).Query = String.Format("select serverlist.USERNAME from serverlist where serverlist.ID ='{0}'", rowID)
            username.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            V_DBR_SQLITE(1).Query = CMCv.Security.Decrypt.AES(String.Format("select serverlist.PASSWORD from serverlist where serverlist.ID ='{0}'", rowID))
            password.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString
            oldpassword = password.Text

            V_DBR_SQLITE(1).Query = String.Format("select serverlist.DBFORDATA from serverlist where serverlist.ID ='{0}'", rowID)
            databasename.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            'V_DBR_SQLITE(1).Query = String.Format("select serverlist.DBFORFILE from serverlist serverlist where serverlist.ID ='{0}'", RowID)
            'FileStorage.Text = V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query).ToString

            V_DBR_SQLITE(1).Query = String.Format("select serverlist.DEFAULTCONNECTION from serverlist where serverlist.ID ='{0}'", rowID)
            isdefault.Checked = CType(V_DBE_SQLite.GETVALUE(V_DBR_SQLITE(1).Query), Boolean)
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal connectionname As String, ByVal dbengine As String,
                                        ByVal address As String, ByVal port As String,
                                        ByVal username As String, ByVal password As String,
                                        ByVal databasename As String, ByVal isdefault As Boolean,
                                        ByVal rowID As String, ByVal isnew As Boolean,
                                        ByVal ispasswordchange As Boolean) As Boolean
            Dim varSuccess As Boolean
            Dim varIsDefaultActivate As String = ""

            Try
                If (isdefault) Then 'to check if isdefault is set
                    varIsDefaultActivate = "update serverlist set DEFAULTCONNECTION=0;"
                End If

                If (isnew) Then
                    V_DBR_SQLITE(1).Query = varIsDefaultActivate & $"insert into serverlist(ID, CONNECTIONNAME, DATABASEENGINE, SERVERADDRESS, SERVERPORT, USERNAME, PASSWORD, DBFORDATA, DBFORFILE, DEFAULTCONNECTION) values ('{rowID}','{connectionname}','{dbengine}','{address}',{port},'{username}','{Security.Encrypt.AES(password)}','{databasename}','',{isdefault})"
                Else
                    If Not (ispasswordchange) Then
                        V_DBR_SQLITE(1).Query = varIsDefaultActivate & String.Format("update serverlist set CONNECTIONNAME='{1}', DATABASEENGINE='{2}', SERVERADDRESS='{3}', SERVERPORT={4}, USERNAME='{5}', DBFORDATA='{6}', DEFAULTCONNECTION={7} where ID='{0}'", rowID, connectionname, dbengine, address, port, username, databasename, isdefault)
                    Else
                        V_DBR_SQLITE(1).Query = varIsDefaultActivate & String.Format("update serverlist set CONNECTIONNAME='{1}', DATABASEENGINE='{2}', SERVERADDRESS='{3}', SERVERPORT={4}, USERNAME='{5}', PASSWORD='{6}', DBFORDATA='{7}', DEFAULTCONNECTION={8} where ID='{0}'", rowID, connectionname, dbengine, address, port, username, Security.Encrypt.AES(password), databasename, isdefault)
                    End If
                End If

                V_DBE_SQLite.PUSHDATA(V_DBR_SQLITE(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace


