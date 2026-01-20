Imports System
Imports System.Runtime.Versioning
Imports System.Windows.Forms.DataVisualization.Charting

Namespace Commands.DARD
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub GetDailyStatistic(databasename As String, chrt As Chart)
            Try
                'ReDim varDatabaseRequestMssql2008(4)
                varDatabaseRequestMssql2008(0).Query = "select top 30 ea.employeeactivity_datetime, (select count(eac.employeeactivity_id) from dbo.doc_employeeactivity eac " &
                    "where eac.employeeactivity_datetime = ea.employeeactivity_datetime ) as [qty_activity] from dbo.doc_employeeactivity ea group by ea.employeeactivity_datetime order by ea.employeeactivity_datetime desc;"
                'Chrt.DataSource = _DBE_MSSQL2008.GETDATAROW(varDatabaseRequestMssql2008(1).Query)
                varDatabaseRequestMssql2008(0).StatusBar = Nothing
                varDatabaseRequestMssql2008(0).DataGrid = Nothing
                varDatabaseRequestMssql2008(0).Chart = chrt
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TDailyChart")

                chrt.Series("Series1").XValueMember = "employeeactivity_datetime"
                chrt.Series("Series1").YValueMembers = "qty_activity"

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetYearlyStatistic(databasename As String, chrt As Chart)
            Try
                'ReDim varDatabaseRequestMssql2008(4)
                varDatabaseRequestMssql2008(0).Query = "select top 5 year(employeeactivity_datetime) as [employeeactivity_datetime], count(ea.employeeactivity_id) as [qty_activity] from dbo.doc_employeeactivity ea " &
                    "group by year(ea.employeeactivity_datetime) order by year(ea.employeeactivity_datetime) desc;"
                'Chrt.DataSource = _DBE_MSSQL2008.GETDATAROW(varDatabaseRequestMssql2008(1).Query)
                varDatabaseRequestMssql2008(0).DataGrid = Nothing
                varDatabaseRequestMssql2008(0).StatusBar = Nothing
                varDatabaseRequestMssql2008(0).Chart = chrt
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TYearlyChart")

                chrt.Series("Series1").XValueMember = "employeeactivity_datetime"
                chrt.Series("Series1").YValueMembers = "qty_activity"

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetMonthlyStatistic(databasename As String, chrt As Chart)
            Try
                'ReDim varDatabaseRequestMssql2008(4)
                varDatabaseRequestMssql2008(0).Query = "select sq.employeeactivity_datetime, sq.qty_activity from (select top 12 (cast(month(ea.employeeactivity_datetime) as varchar(2)) + '-' + " &
                    "cast(year(ea.employeeactivity_datetime) as varchar(4))) as [employeeactivity_datetime], count(ea.employeeactivity_id) as [qty_activity], month(ea.employeeactivity_datetime) as [by_month], " &
                    "year(ea.employeeactivity_datetime) as [by_year] from dbo.doc_employeeactivity ea group by cast(year(ea.employeeactivity_datetime) as varchar(4)), " &
                    "cast(month(ea.employeeactivity_datetime) as varchar(2)), month(ea.employeeactivity_datetime), year(ea.employeeactivity_datetime) order by cast(year(ea.employeeactivity_datetime) as varchar(4)) desc, " &
                    "cast(month(ea.employeeactivity_datetime) as varchar(2)) desc) sq  order by sq.by_year, sq.by_month;"
                'Chrt.DataSource = _DBE_MSSQL2008.GETDATAROW(varDatabaseRequestMssql2008(1).Query)
                varDatabaseRequestMssql2008(0).DataGrid = Nothing
                varDatabaseRequestMssql2008(0).StatusBar = Nothing
                varDatabaseRequestMssql2008(0).Chart = chrt
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TMonthlyChart")

                chrt.Series("Series1").XValueMember = "employeeactivity_datetime"
                chrt.Series("Series1").YValueMembers = "qty_activity"

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class
End Namespace
