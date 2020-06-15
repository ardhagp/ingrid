Namespace Commands.NTFC
    Public Class View
        Public Sub Display(ByVal NotificationGrid As CMCv.dgn, ByVal EID As String)
            _DBR_MSSQL2008(0).Query = String.Format("select top 100 ((case nt.notification_isread when 0 then '*NEW* ' else '' end) + convert(varchar(max),nt.notification_message)) as [notification_message], nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}')  order by nt.notification_datetime desc", EID)

            _DBR_MSSQL2008(0).DataGrid = NotificationGrid
            _DBR_MSSQL2008(0).StatusBar = Nothing
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TNotification")

            _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]notification] set notification_isread = 1 where notification_datetime <= (select top 1 nt.notification_datetime from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') order by nt.notification_datetime desc)", EID)
            _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
        End Sub
    End Class
End Namespace
