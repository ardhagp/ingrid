Imports System.Runtime.Versioning

Namespace Commands.NTFC
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
        Public Shared Sub Display(databasename As String, dbengine As String, notificationgrid As CMCv.dgn, eid As String)
            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", eid)

                V_DBR_MSSQL2008(0).DataGrid = notificationgrid
                V_DBR_MSSQL2008(0).StatusBar = Nothing
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TNotification")

                V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]notification] set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", eid)
                V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
            ElseIf dbengine = "MySQL" Then
                V_DBR_MYSQL(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from sys_notification nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", eid)

                V_DBR_MYSQL(0).DataGrid = notificationgrid
                V_DBR_MYSQL(0).StatusBar = Nothing
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TNotification")

                V_DBR_MYSQL(1).Query = String.Format("update sys_notification set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from sys_notification nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", eid)
                V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
            End If
        End Sub
    End Class
End Namespace
