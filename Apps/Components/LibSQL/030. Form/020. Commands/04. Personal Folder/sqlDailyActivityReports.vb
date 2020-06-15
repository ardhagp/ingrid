Imports CMCv
Imports VisualInheritanceFixer
Imports System

Namespace Commands
    Public Class DailyActivityReports
        Public Sub DisplayMainGrid(ByVal Find As txt, ByRef DateGrid As dgn, ByVal ContentGrid As dgn, ByVal DateStatusBar As stt, ContentStatusBar As stt, ByVal chkDateFilter As chk, ByVal dtpDateFilter As dtp, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) And (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = "select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea group by ea.employeeactivity_datetime order by ea.employeeactivity_datetime desc"
                If chkDateFilter.Checked = True Then
                    _DBR_MSSQL2008(0).Query = String.Format("select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea where (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1}) group by ea.employeeactivity_datetime order by ea.employeeactivity_datetime desc", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                End If
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_description like '%{0}%' group by ea.employeeactivity_datetime order by ea.employeeactivity_datetime desc", Find.SLFSQLText)
                If chkDateFilter.Checked = True Then
                    _DBR_MSSQL2008(0).Query = String.Format("select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_description like '%{0}%' and (year(ea.employeeactivity_datetime) = {1} and month(ea.employeeactivity_datetime) = {2}) group by ea.employeeactivity_datetime order by ea.employeeactivity_datetime desc", Find.SLFSQLText, dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                End If
            End If
            _DBR_MSSQL2008(0).DataGrid = DateGrid
            _DBR_MSSQL2008(0).StatusBar = DateStatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TDailyReportsDate")

            Call DisplaySecondGrid(DateGrid, ContentGrid, ContentStatusBar, Find)
        End Sub

        Public Sub DisplaySecondGrid(ByVal DateGrid As dgn, ByVal ContentGrid As dgn, ByVal ContentStatusBar As stt, ByVal Find As txt)
            Dim _CONTENTDATE As Date
            Dim _CONTENTDATE_S As String

            If DateGrid.Rows.Count = 0 Then
                'contentdate = Now.AddYears(2)
                _CONTENTDATE_S = "9999-12-31"
            Else
                _CONTENTDATE = DateGrid.CurrentRow.Cells("employeeactivity_datetime").Value
                _CONTENTDATE_S = _CONTENTDATE.Year & "-" & _CONTENTDATE.Month & "-" & _CONTENTDATE.Day
            End If

            If (Find.Text = String.Empty) Then
                _DBR_MSSQL2008(1).Query = String.Format("select aa.areaaffected_name, ea.employeeactivity_time, ea.employeeactivity_description, e.employee_name, ea.employeeactivity_id from dbo.[[doc]]employeeactivity] ea inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id inner join dbo.[[hr]]employee] e on ea.employeeactivity_employee = e.employee_id where ea.employeeactivity_datetime = '{0}' order by aa.areaaffected_order, ea.employeeactivity_time", _CONTENTDATE_S)
            Else
                _DBR_MSSQL2008(1).Query = String.Format("select aa.areaaffected_name, ea.employeeactivity_time, ea.employeeactivity_description, e.employee_name, ea.employeeactivity_id from dbo.[[doc]]employeeactivity] ea inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id inner join dbo.[[hr]]employee] e on ea.employeeactivity_employee = e.employee_id where ea.employeeactivity_datetime = '{0}' and ea.employeeactivity_description like '%{1}%' order by aa.areaaffected_order, ea.employeeactivity_time", _CONTENTDATE_S, Find.SLFSQLText)
            End If

            _DBR_MSSQL2008(1).DataGrid = ContentGrid
            _DBR_MSSQL2008(1).StatusBar = ContentStatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TDailyActivity")
        End Sub
    End Class
End Namespace
