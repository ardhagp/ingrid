Imports System.Runtime.Versioning

Namespace CMDntfc
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbengine"></param>
        ''' <param name="notificationgrid"></param>
        ''' <param name="eid"></param>
        <SupportedOSPlatform("windows")>
        Public Shared Sub Display(dataproperties As LibApp.Ingrid.Global.Properties, notificationgrid As CMCv.UI.Control.dgn, eid As String)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", eid)

                varDatabaseRequestMssql2008(0).DataGrid = notificationgrid
                varDatabaseRequestMssql2008(0).StatusBar = Nothing
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TNotification")

                varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.[[sys]]notification] set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", eid)
                varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"SELECT CONCAT(CASE nt.notification_isread WHEN 0 THEN '*NEW* ' ELSE '' END, nt.notification_message) AS notification_message, nt.notification_datetime " &
                                                   $"FROM sys_notification nt WHERE nt.notification_employee = '{eid}' " &
                                                   $"ORDER BY nt.notification_datetime DESC LIMIT 0, 100;"

                varDatabaseRequestMysql(0).DataGrid = notificationgrid
                varDatabaseRequestMysql(0).StatusBar = Nothing
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TNotification")

                varDatabaseRequestMysql(1).Query = $"update sys_notification set notification_isread = 1 where notification_datetime <= (select t.notification_datetime from (select " &
                                                   $"nt.notification_datetime from sys_notification nt where (nt.notification_employee = '{eid}') " &
                                                   $"order by nt.notification_datetime desc limit 0,1) as t)"
                varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
            End If
        End Sub
    End Class
End Namespace
