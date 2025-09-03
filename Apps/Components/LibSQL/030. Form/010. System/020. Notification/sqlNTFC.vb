Imports System.Runtime.Versioning

Namespace Commands.NTFC
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAY(ByVal DBEngine As String, ByVal NotificationGrid As CMCv.dgn, ByVal EID As String)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", EID)

                V_DBR_MSSQL2008(0).DataGrid = NotificationGrid
                V_DBR_MSSQL2008(0).StatusBar = Nothing
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TNotification")

                V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]notification] set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", EID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
            ElseIf DBEngine = "MySQL" Then
                V_DBR_MYSQL(0).Query = String.Format("Select top 100 ((Case nt.notification_isread When 0 Then '*NEW* ' else '' end) + convert(varchar(max), " &
                                                    "nt.notification_message)) as [notification_message], nt.notification_datetime " &
                                                    "from sys_notification nt where (nt.notification_employee = '{0}')  order by " &
                                                    "nt.notification_datetime desc", EID)

                V_DBR_MYSQL(0).DataGrid = NotificationGrid
                V_DBR_MYSQL(0).StatusBar = Nothing
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TNotification")

                V_DBR_MYSQL(1).Query = String.Format("update sys_notification set notification_isread = 1 where notification_datetime <= (select " &
                                                    "top 1 nt.notification_datetime from sys_notification nt where (nt.notification_employee = '{0}') " &
                                                    "order by nt.notification_datetime desc)", EID)
                V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
            End If
        End Sub
    End Class
End Namespace
