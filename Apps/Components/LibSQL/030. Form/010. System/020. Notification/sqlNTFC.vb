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
        Public Shared Sub Display(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, notificationgrid As CMCv.dgn, eid As String)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", eid)

                varDatabaseRequestMssql2008(0).DataGrid = notificationgrid
                varDatabaseRequestMssql2008(0).StatusBar = Nothing
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TNotification")

                varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.[[sys]]notification] set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", eid)
                varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from sys_notification nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", eid)

                varDatabaseRequestMysql(0).DataGrid = notificationgrid
                varDatabaseRequestMysql(0).StatusBar = Nothing
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TNotification")

                varDatabaseRequestMysql(1).Query = String.Format("update sys_notification set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from sys_notification nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", eid)
                varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
            End If
        End Sub
    End Class
End Namespace
