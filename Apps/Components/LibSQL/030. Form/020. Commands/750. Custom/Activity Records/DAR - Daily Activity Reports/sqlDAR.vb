Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace CMDdar
    Public Class View
        'ReDim varDatabaseRequestMssql2008(3)
        Private Shared varIsEmpFilter As Boolean
        Private Shared varEmployeeID As String
        Private Shared varContentID As String
        Private Shared varContentYear As String

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckSettings(databasename As String, dbengine As String, uid As String, attribute As String) As Boolean
            Dim varIsExist As Integer = 0
            Dim varAttribute(1) As String

            varAttribute(0) = "ViewPhotoTab"

            If dbengine = "MSSQL" Then
                For varRow = 0 To 0
                    varDatabaseRequestMssql2008(0).Query = String.Format("select count(mods.modulesettings_id) from dbo.[[sys]]modulesettings] mods inner join " &
                                                        "dbo.sys_module mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') " &
                                                        "and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", uid, varAttribute(varRow))
                    varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

                    If varIsExist = 0 Then
                        varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.[[sys]]modulesettings](modulesettings_id, modulesettings_module," &
                                                            "modulesettings_user, modulesettings_attribute, modulesettings_value) values('{0}', " &
                                                            "(select mo.module_id from dbo.sys_module mo where mo.module_code = 'DAR'),'{1}','{2}'," &
                                                            "'False')", CMCv.Security.Encrypt.MD5(), uid, varAttribute(varRow))
                        varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                    End If
                Next
            ElseIf dbengine = "MYSQL" Then
                For varRow = 0 To 0
                    varDatabaseRequestMysql(0).Query = String.Format("select count(mods.modulesettings_id) from sys_modulesettings mods inner join " &
                                                        "sys_module mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') " &
                                                        "and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", uid, varAttribute(varRow))
                    varIsExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)

                    If varIsExist = 0 Then
                        varDatabaseRequestMysql(1).Query = String.Format("insert into sys_modulesettings(modulesettings_id, modulesettings_module," &
                                                            "modulesettings_user, modulesettings_attribute, modulesettings_value) values('{0}', " &
                                                            "(select mo.module_id from sys_module mo where mo.module_code = 'DAR'),'{1}','{2}'," &
                                                            "'False')", CMCv.Security.Encrypt.MD5(), uid, varAttribute(varRow))
                        varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                    End If
                Next
            End If

            Dim varValue As Boolean = False

            If dbengine = "MSSQL" Then

            ElseIf dbengine = "MYSQL" Then

            End If

            varDatabaseRequestMssql2008(0).Query = String.Format("select mods.modulesettings_value from dbo.[[sys]]modulesettings] mods inner join dbo.sys_module " &
                                                    "mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') and " &
                                                    "(mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", uid, "ViewPhotoTab")

            varValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Boolean)

            Return varValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(databasename As String, dbengine As String, uid As String, attribute As String, values As String) As Boolean
            Dim varIsSuccess As Boolean = False

            Try
                If dbengine = "MSSQL" Then

                ElseIf dbengine = "MYSQL" Then

                End If


                varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.[[sys]]modulesettings] set modulesettings_value = '{0}' where (modulesettings_module = " &
                                                        "(select mo.module_id from dbo.sys_module mo where mo.module_code = 'DAR')) and " &
                                                        "(modulesettings_user = '{1}') and (modulesettings_attribute = '{2}')", values, uid, attribute)

                varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)

                varIsSuccess = True
            Catch ex As Exception
                varIsSuccess = False
            End Try

            Return varIsSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillEmployee(databasename As String, dbengine As String, employee As cbo)
            If dbengine = "MSSQL" Then

            ElseIf dbengine = "MYSQL" Then

            End If

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_id, em.employee_fullname from dbo.man_employee em where em.employee_id in " &
                                                    "(select ea.employeeactivity_employee from dbo.doc_employeeactivity ea group by " &
                                                    "ea.employeeactivity_employee) order by em.employee_fullname;")
            varDatabaseRequestMssql2008(1).Dropdown = employee
            varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(1), "TEmployee")
            employee.DisplayMember = "employee_fullname"
            employee.ValueMember = "employee_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayMainGrid(databasename As String, dbengine As String, find As txt, dategrid As dgn, datestatusbar As stt, contentstatusbar As stt, chkdatefilter As chk, dtpdatefilter As dtp, chkbyfilter As chk, cbobyfilter As cbo, Optional forcerefresh As Boolean = False)
            Try
                Dim varWhere As String = String.Format("where ")

                If cbobyfilter.Items.Count = 0 Then
                    varEmployeeID = "-1"
                Else
                    varEmployeeID = cbobyfilter.SelectedValue().ToString
                End If

                If dbengine = "MSSQL" Then
                    If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
                        If Not (chkdatefilter.Checked) Then
                            varWhere += String.Format("(year(ea.employeeactivity_datetime) = year(getdate())) And (month(ea.employeeactivity_datetime) = " &
                                                "month(getdate()))")
                        Else
                            varWhere += String.Format("(year(ea.employeeactivity_datetime) = {0} And month(ea.employeeactivity_datetime) = {1})", dtpdatefilter.Value.Year, dtpdatefilter.Value.Month)
                        End If

                        If (chkbyfilter.Checked) Then
                            varWhere += String.Format(" And (ea.employeeactivity_employee = '{0}')", varEmployeeID)
                        End If
                    Else
                        If Not (find.XOSQLText.Trim.Contains("||")) Then
                            varWhere += String.Format("(ea.employeeactivity_description like '%{0}%')", find.XOSQLText)
                        Else
                            Dim varContainText As String() = find.XOSQLText.Split("||")
                            Dim varRepeater As Integer = 0

                            varWhere += String.Format("(")

                            For Each varText As String In varContainText
                                If (varText <> "") Then
                                    If varRepeater = 0 Then
                                        varWhere.Append(CChar($"ea.employeeactivity_description like '%{varText}%'"))
                                    Else
                                        varWhere.Append(CChar($" and ea.employeeactivity_description like '%{varText}%'"))
                                    End If
                                End If

                                varRepeater += 1
                            Next

                            varWhere += String.Format(")")
                        End If

                        If (chkdatefilter.Checked) Then
                            varWhere += String.Format(" and (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpdatefilter.Value.Year, dtpdatefilter.Value.Month)
                        End If

                        If (chkbyfilter.Checked) Then
                            varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}')", varEmployeeID)
                        End If
                    End If

                    varDatabaseRequestMssql2008(0).Query = String.Format("select ea.employeeactivity_datetime, (convert(varchar,ea.employeeactivity_datetime,106) + '' + " &
                                                        "char(13) + char(10) + '' + left(datename(dw,ea.employeeactivity_datetime),3)) as [employeeactivity_longdate] " &
                                                        "from dbo.doc_employeeactivity ea {0} group by ea.employeeactivity_datetime " &
                                                        "order by ea.employeeactivity_datetime desc", varWhere)

                    varDatabaseRequestMssql2008(0).DataGrid = dategrid
                    varDatabaseRequestMssql2008(0).StatusBar = datestatusbar
                    varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TDailyReportsDate")

                    varIsEmpFilter = chkbyfilter.Checked
                ElseIf dbengine = "MYSQL" Then
                    If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
                        If Not (chkdatefilter.Checked) Then
                            varWhere += String.Format("(year(ea.employeeactivity_datetime) = year(now())) And (month(ea.employeeactivity_datetime) = " &
                                                "month(now()))")
                        Else
                            varWhere += String.Format("(year(ea.employeeactivity_datetime) = {0} And month(ea.employeeactivity_datetime) = {1})", dtpdatefilter.Value.Year, dtpdatefilter.Value.Month)
                        End If

                        If (chkbyfilter.Checked) Then
                            varWhere += String.Format(" And (ea.employeeactivity_employee = '{0}')", varEmployeeID)
                        End If
                    Else
                        If Not (find.XOSQLText.Trim.Contains("||")) Then
                            varWhere += String.Format("(ea.employeeactivity_description like '%{0}%')", find.XOSQLText)
                        Else
                            Dim varContainText As String() = find.XOSQLText.Split("||")
                            Dim varRepeater As Integer = 0

                            varWhere += String.Format("(")

                            For Each varText As String In varContainText
                                If (varText <> "") Then
                                    If varRepeater = 0 Then
                                        varWhere.Append(CChar($"ea.employeeactivity_description like '%{varText}%'"))
                                    Else
                                        varWhere.Append(CChar($" and ea.employeeactivity_description like '%{varText}%'"))
                                    End If
                                End If

                                varRepeater += 1
                            Next

                            varWhere += String.Format(")")
                        End If

                        If (chkdatefilter.Checked) Then
                            varWhere += String.Format(" and (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpdatefilter.Value.Year, dtpdatefilter.Value.Month)
                        End If

                        If (chkbyfilter.Checked) Then
                            varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}')", varEmployeeID)
                        End If
                    End If

                    varDatabaseRequestMysql(0).Query = String.Format("select ea.employeeactivity_datetime, (convert(varchar,ea.employeeactivity_datetime,106) + '' + " &
                                                        "char(13) + char(10) + '' + left(datename(dw,ea.employeeactivity_datetime),3)) as `employeeactivity_longdate` " &
                                                        "from doc_employeeactivity ea {0} group by ea.employeeactivity_datetime " &
                                                        "order by ea.employeeactivity_datetime desc", varWhere)

                    varDatabaseRequestMysql(0).DataGrid = dategrid
                    varDatabaseRequestMysql(0).StatusBar = datestatusbar
                    varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TDailyReportsDate")

                    varIsEmpFilter = chkbyfilter.Checked
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplaySecondGrid(databasename As String, dbengine As String, dategrid As String, contentgrid As dgn, contentstatusbar As stt, find As txt, Optional showattachment As Boolean = False, Optional photogrid As dgn = Nothing, Optional filegrid As dgn = Nothing)
            Try
                'Dim _CONTENTDATE As Date
                Dim V_CONTENTDATE_S As String = String.Empty
                Dim varWhere As String = "where "

                V_CONTENTDATE_S = dategrid

                'If DateGrid.Rows.Count = 0 Then
                '    'contentdate = Now.AddYears(2)
                '    _CONTENTDATE_S = "9999-12-31"
                'Else
                '    _CONTENTDATE = DateGrid.CurrentRow.Cells("employeeactivity_datetime").Value
                '    _CONTENTDATE_S = _CONTENTDATE.Year & "-" & _CONTENTDATE.Month & "-" & _CONTENTDATE.Day
                'End If

                'add date query-cut
                varWhere += String.Format(" (ea.employeeactivity_datetime = '{0}')", V_CONTENTDATE_S)

                If dbengine = "MSSQL" Then
                    ReDim varDatabaseRequestMssql2008(3)

                    'add text query-cut
                    If (find.XOSQLText <> String.Empty) Then
                        varWhere += String.Format(" and ")

                        'multiple keywords execution
                        If Not (find.XOSQLText.Trim.Contains("||")) Then
                            varWhere += String.Format("(ea.employeeactivity_description like '%{0}%') ", find.XOSQLText)
                        Else
                            Dim varContainText As String() = find.XOSQLText.Split("||")
                            Dim varRepeater As Integer = 0

                            varWhere += String.Format("(")

                            For Each varText As String In varContainText
                                If varText <> "" Then

                                    varText.Trim()

                                    If varRepeater = 0 Then
                                        varWhere += String.Format("ea.employeeactivity_description like '%{0}%'", varText)
                                    Else
                                        varWhere += String.Format(" and ea.employeeactivity_description like '%{0}%'", varText)
                                    End If
                                End If

                                varRepeater += 1
                            Next

                            varWhere += String.Format(")")
                        End If
                    End If

                    'add employee filter query-cut
                    If (varIsEmpFilter) Then
                        varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}') ", varEmployeeID)
                    End If

                    Dim varTimeFormat(2) As String

                    'same day with different time
                    varTimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                                   "as [employeeactivity_time]")

                    'same day with time range format & different day format
                    varTimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
                                                   "(ea.employeeactivity_time_end = ea.employeeactivity_time)) then (cast(ea.employeeactivity_datetime " &
                                                   "as varchar(10))) + char(13) + char(10) + cast(ea.employeeactivity_time as varchar(8)) when " &
                                                   "((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
                                                   "(ea.employeeactivity_time_end > ea.employeeactivity_time)) then " &
                                                   "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + " &
                                                   "(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                                   "when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then " &
                                                   "(cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + (cast(ea.employeeactivity_time as varchar(8))) " &
                                                   "+ char(13) + char(10) + ' to ' + char(13) + char(10) + (cast(ea.employeeactivity_datetime_end as varchar(10))) " &
                                                   "+ ' ' + cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                    Dim varDescription As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') " &
                        "then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) " &
                    "+ '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                    varDatabaseRequestMssql2008(2).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and " &
                                                            "(ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                            "(convert(varchar(max), e.employee_nickname) + ' / ' + convert(varchar(max), " &
                                                            "(select em.employee_nickname from dbo.man_employee em where " &
                                                            "em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as [employee_nickname], " &
                                                            "e.employee_id, ea.employeeactivity_id from dbo.doc_employeeactivity ea " &
                                                            "inner join dbo.doc_areaaffected aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                            "inner join dbo.man_employee e on ea.employeeactivity_employee = e.employee_id {0} order by " &
                                                            "aa.areaaffected_order, ea.employeeactivity_time", varWhere, varTimeFormat(2), varDescription)

                    varDatabaseRequestMssql2008(2).DataGrid = contentgrid
                    varDatabaseRequestMssql2008(2).StatusBar = contentstatusbar
                    varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(2), "TDailyActivity")

                    If varDatabaseRequestMssql2008(2).DataGrid Is Nothing Then
                        varDatabaseRequestMssql2008(2).DataGrid = contentgrid
                        varDatabaseRequestMssql2008(2).StatusBar = contentstatusbar
                    End If

                    If (photogrid Is Nothing) AndAlso (filegrid Is Nothing) Then
                        Return
                    End If

                    If (showattachment) Then
                        If varDatabaseRequestMssql2008(2).DataGrid.RowCount = 0 Then
                            varContentID = "-1"
                        Else
                            varContentID = varDatabaseRequestMssql2008(2).DataGrid.CurrentRow.Cells("employeeactivity_id").Value.ToString
                        End If
                        Call DisplayPhotoGrid(databasename, dbengine, varContentID, photogrid)
                        Call DisplayFileGrid(databasename, dbengine, varContentID, filegrid)
                    End If
                ElseIf dbengine = "MYSQL" Then
                    ReDim varDatabaseRequestMysql(3)

                    'add text query-cut
                    If (find.XOSQLText <> String.Empty) Then
                        varWhere += String.Format(" and ")

                        'multiple keywords execution
                        If Not (find.XOSQLText.Trim.Contains("||")) Then
                            varWhere += String.Format("(ea.employeeactivity_description like '%{0}%') ", find.XOSQLText)
                        Else
                            Dim varContainText As String() = find.XOSQLText.Split("||")
                            Dim varRepeater As Integer = 0

                            varWhere += String.Format("(")

                            For Each varText As String In varContainText
                                If varText <> "" Then

                                    varText.Trim()

                                    If varRepeater = 0 Then
                                        varWhere += String.Format("ea.employeeactivity_description like '%{0}%'", varText)
                                    Else
                                        varWhere += String.Format(" and ea.employeeactivity_description like '%{0}%'", varText)
                                    End If
                                End If

                                varRepeater += 1
                            Next

                            varWhere += String.Format(")")
                        End If
                    End If

                    'add employee filter query-cut
                    If (varIsEmpFilter) Then
                        varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}') ", varEmployeeID)
                    End If

                    Dim varTimeFormat(2) As String

                    'same day with different time
                    varTimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                                   "as `employeeactivity_time`")

                    'same day with time range format & different day format
                    varTimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
                                                   "(ea.employeeactivity_time_end = ea.employeeactivity_time)) then (cast(ea.employeeactivity_datetime " &
                                                   "as varchar(10))) + char(13) + char(10) + cast(ea.employeeactivity_time as varchar(8)) when " &
                                                   "((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
                                                   "(ea.employeeactivity_time_end > ea.employeeactivity_time)) then " &
                                                   "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + " &
                                                   "(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                                   "when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then " &
                                                   "(cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + (cast(ea.employeeactivity_time as varchar(8))) " &
                                                   "+ char(13) + char(10) + ' to ' + char(13) + char(10) + (cast(ea.employeeactivity_datetime_end as varchar(10))) " &
                                                   "+ ' ' + cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                    Dim varDescription As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') " &
                        "then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) " &
                    "+ '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as `employeeactivity_description`"

                    varDatabaseRequestMysql(2).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and " &
                                                            "(ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                            "(convert(varchar(max), e.employee_nickname) + ' / ' + convert(varchar(max), " &
                                                            "(select em.employee_nickname from man_employee em where " &
                                                            "em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as `employee_nickname`, " &
                                                            "e.employee_id, ea.employeeactivity_id from doc_employeeactivity ea " &
                                                            "inner join doc_areaaffected aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                            "inner join man_employee e on ea.employeeactivity_employee = e.employee_id {0} order by " &
                                                            "aa.areaaffected_order, ea.employeeactivity_time", varWhere, varTimeFormat(2), varDescription)

                    varDatabaseRequestMysql(2).DataGrid = contentgrid
                    varDatabaseRequestMysql(2).StatusBar = contentstatusbar
                    varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(2), "TDailyActivity")

                    If varDatabaseRequestMysql(2).DataGrid Is Nothing Then
                        varDatabaseRequestMysql(2).DataGrid = contentgrid
                        varDatabaseRequestMysql(2).StatusBar = contentstatusbar
                    End If

                    If (photogrid Is Nothing) AndAlso (filegrid Is Nothing) Then
                        Return
                    End If

                    If (showattachment) Then
                        If varDatabaseRequestMysql(2).DataGrid.RowCount = 0 Then
                            varContentID = "-1"
                        Else
                            varContentID = varDatabaseRequestMysql(2).DataGrid.CurrentRow.Cells("employeeactivity_id").Value.ToString
                        End If
                        Call DisplayPhotoGrid(databasename, dbengine, varContentID, photogrid)
                        Call DisplayFileGrid(databasename, dbengine, varContentID, filegrid)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayPhotoGrid(databasename As String, dbengine As String, contentid As String, filegrid As dgn, Optional recordyear As String = "")
            ReDim varDatabaseRequestMssql2008(5)
            Dim V_CONTENTID As String = contentid

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(4).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, (convert(varchar(25),fi.file_content_size) + ' KB') " &
                                                    "as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], " &
                                                    "fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.man_employee em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.man_employee em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.sto_file fi where (fi.file_parent = '{0}' " &
                                                    "and fi.file_filetype = 'jpg') order by fi.file_score desc, fi.file_datetime;", V_CONTENTID)
                varDatabaseRequestMssql2008(4).DataGrid = filegrid
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(4), "TPhotoFile")
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(4).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, (convert(varchar(25),fi.file_content_size) + ' KB') " &
                                                    "as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], " &
                                                    "fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.man_employee em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.man_employee em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.sto_file fi where (fi.file_parent = '{0}' " &
                                                    "and fi.file_filetype = 'jpg') order by fi.file_score desc, fi.file_datetime;", V_CONTENTID)
                varDatabaseRequestMysql(4).DataGrid = filegrid
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(4), "TPhotoFile")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayFileGrid(databasename As String, dbengine As String, contentid As String, filegrid As dgn, Optional recordyear As String = "")
            ReDim varDatabaseRequestMssql2008(6)
            Dim varContentID As String = contentid

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(5).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, '' as [file_content], " &
                                                    "(convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], " &
                                                    "(convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, " &
                                                    "fi.file_uploader, (select em.employee_fullname from dbo.man_employee em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.man_employee em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", varContentID)
                varDatabaseRequestMssql2008(5).DataGrid = filegrid
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(5), "TFile")
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(5).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, '' as [file_content], " &
                                                    "(convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], " &
                                                    "(convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, " &
                                                    "fi.file_uploader, (select em.employee_fullname from dbo.man_employee em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.man_employee em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", varContentID)
                varDatabaseRequestMysql(5).DataGrid = filegrid
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(5), "TFile")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPdfFile(databasename As String, dbengine As String, rowid As String, Optional recordyear As String = "") As Object
            Dim varFile As Object = Nothing

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select fi.file_content from db_universe_erp_file.dbo.sto_file fi where fi.file_id = '{0}'", rowid)

                varFile = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query)
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(1).Query = String.Format("select fi.file_content from db_universe_erp_file.dbo.sto_file fi where fi.file_id = '{0}'", rowid)

                varFile = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query)
            End If

            Return varFile
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean = False
            Try
                If dbengine = "MSSQL" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.doc_employeeactivity where employeeactivity_id = '{0}';delete " &
                                                        "from db_universe_erp_file.dbo.sto_file where file_parent = '{0}';", rowid)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    varDatabaseRequestMysql(1).Query = String.Format("delete from doc_employeeactivity where employeeactivity_id = '{0}';delete " &
                                                        "from sto_file where file_parent = '{0}';", rowid)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                End If

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsLike(databasename As String, dbengine As String, fileid As String, eid As String) As Boolean
            Dim varResult As Integer = 0
            Try
                If dbengine = "MSSQL" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select count(ff.filefeedback_id) as [islike] from db_universe_erp_file.dbo.sto_filefeedback ff " &
                                                        "where ff.filefeedback_file = '{0}' and ff.filefeedback_employee = '{1}';", fileid, eid)
                    varResult = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)
                ElseIf dbengine = "MYSQL" Then
                    varDatabaseRequestMysql(1).Query = String.Format("select count(ff.filefeedback_id) as `islike` from sto_filefeedback ff " &
                                                        "where ff.filefeedback_file = '{0}' and ff.filefeedback_employee = '{1}';", fileid, eid)
                    varResult = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query), Integer)
                End If

            Catch ex As Exception
                varResult = 0
            End Try

            If varResult = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function LikePhoto(databasename As String, dbengine As String, fileid As String, eid As String, fileowner As String) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = "MSSQL" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("insert into db_universe_erp_file.dbo.sto_filefeedback(filefeedback_datetime, filefeedback_file, " &
                                                        "filefeedback_employee, filefeedback_type, filefeedback_value, filefeedback_text) values(GETDATE(), " &
                                                        "'{0}', '{1}', 'Like', 1, 'N/A'); insert into dbo.[[sys]]notification](notification_datetime, " &
                                                        "notification_employee, notification_message, notification_isread) values(GETDATE(), '{2}', " &
                                                        "(select em.employee_fullname from dbo.man_employee em where em.employee_id = '{1}') " &
                                                        "+ ' like one of your photo.', 0);update db_universe_erp_file.dbo.sto_file " &
                                                        "set file_score = (select count(ff.filefeedback_value) " &
                                                        "from db_universe_erp_file.dbo.sto_filefeedback ff where (ff.filefeedback_file = '{0}') and " &
                                                        "(ff.filefeedback_type = 'Like')) where (file_id = '{0}');", fileid, eid, fileowner)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    varDatabaseRequestMysql(1).Query = String.Format("insert into db_universe_erp_file.dbo.sto_filefeedback(filefeedback_datetime, filefeedback_file, " &
                                                        "filefeedback_employee, filefeedback_type, filefeedback_value, filefeedback_text) values(GETDATE(), " &
                                                        "'{0}', '{1}', 'Like', 1, 'N/A'); insert into dbo.[[sys]]notification](notification_datetime, " &
                                                        "notification_employee, notification_message, notification_isread) values(GETDATE(), '{2}', " &
                                                        "(select em.employee_fullname from dbo.man_employee em where em.employee_id = '{1}') " &
                                                        "+ ' like one of your photo.', 0);update db_universe_erp_file.dbo.sto_file " &
                                                        "set file_score = (select count(ff.filefeedback_value) " &
                                                        "from db_universe_erp_file.dbo.sto_filefeedback ff where (ff.filefeedback_file = '{0}') and " &
                                                        "(ff.filefeedback_type = 'Like')) where (file_id = '{0}');", fileid, eid, fileowner)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                End If

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

    Public Class Editor
        Private Shared V_DS As DataSet

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetAffectedArea(databasename As String, dbengine As String, listofaffectedarea As CMCv.cbo)
            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(1).Query = "select aa.areaaffected_id, aa.areaaffected_name from dbo.doc_areaaffected aa order by aa.areaaffected_order"
                varDatabaseRequestMssql2008(1).Dropdown = listofaffectedarea
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(1), "TAffectedArea")
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(1).Query = "select aa.areaaffected_id, aa.areaaffected_name from doc_areaaffected aa order by aa.areaaffected_order"
                varDatabaseRequestMysql(1).Dropdown = listofaffectedarea
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(1), "TAffectedArea")
            End If

            listofaffectedarea.DisplayMember = "areaaffected_name"
            listofaffectedarea.ValueMember = "areaaffected_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetTemplateTitle(databasename As String, dbengine As String, listoftemplate As CMCv.cbo)
            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(1).Query = "select tp.template_id, tp.template_title from dbo.doc_template tp inner join dbo.sys_module mo on " &
                "mo.module_id = tp.template_module where mo.module_code = 'DAR' order by tp.template_title"
                varDatabaseRequestMssql2008(1).Dropdown = listoftemplate
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(1), "TTemplate")
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(1).Query = "select tp.template_id, tp.template_title from doc_template tp inner join sys_module mo on " &
                "mo.module_id = tp.template_module where mo.module_code = 'DAR' order by tp.template_title"
                varDatabaseRequestMysql(1).Dropdown = listoftemplate
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(1), "TTemplate")
            End If

            listoftemplate.DisplayMember = "template_title"
            listoftemplate.ValueMember = "template_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetTemplateContent(databasename As String, dbengine As String, listoftemplate As CMCv.cbo) As String
            Dim varTemplateContent As String = String.Empty

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select tp.template_text1 from dbo.doc_template tp where tp.template_id = '{0}'", listoftemplate.SelectedValue)
                varTemplateContent = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(1).Query = String.Format("select tp.template_text1 from doc_template tp where tp.template_id = '{0}'", listoftemplate.SelectedValue)
                varTemplateContent = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varTemplateContent
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetRowValue(databasename As String, dbengine As String, rowid As String, datepart As CMCv.dtp, timepart As CMCv.meb, datepartend As CMCv.dtp, timepartend As CMCv.meb, listofaffectedarea As cbo, listoftemplate As cbo, templatecontent As CMCv.txt, feedBack As CMCv.txt)
            Dim varDatePart(3) As String
            Dim varTimeParts(1) As TimeSpan
            Dim varTimePart(3) As String

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_datetime from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varDatePart(0) = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_time from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varTimeParts(0) = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), TimeSpan)

                varDatePart(2) = Convert.ToString(varTimeParts(0))
                varTimePart = varDatePart(2).Split(":")
                varDatePart(1) = varTimePart(0) & ":" & varTimePart(1)

                datepart.Value = CType(varDatePart(0), Date)
                timepart.Text = varDatePart(1)

                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_datetime_end from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varDatePart(0) = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_time_end from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varTimeParts(0) = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), TimeSpan)

                varDatePart(2) = Convert.ToString(varTimeParts(0))
                varTimePart = varDatePart(2).Split(":")
                varDatePart(1) = varTimePart(0) & ":" & varTimePart(1)

                datepartend.Value = CType(varDatePart(0), Date)
                timepartend.Text = varDatePart(1)

                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_areaaffected from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                listofaffectedarea.SelectedValue = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query)

                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_template from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                listoftemplate.SelectedValue = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query)

                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_description from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                templatecontent.Text = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

                Dim varFeedback As Object
                varDatabaseRequestMssql2008(1).Query = String.Format("select ea.employeeactivity_feedback from dbo.doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varFeedback = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query)
                feedBack.Text = IIf(IsDBNull(varFeedback), "", varFeedback).ToString
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_datetime from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varDatePart(0) = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString

                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_time from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varTimeParts(0) = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query), TimeSpan)

                varDatePart(2) = Convert.ToString(varTimeParts(0))
                varTimePart = varDatePart(2).Split(":")
                varDatePart(1) = varTimePart(0) & ":" & varTimePart(1)

                datepart.Value = CType(varDatePart(0), Date)
                timepart.Text = varDatePart(1)

                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_datetime_end from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varDatePart(0) = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString

                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_time_end from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varTimeParts(0) = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query), TimeSpan)

                varDatePart(2) = Convert.ToString(varTimeParts(0))
                varTimePart = varDatePart(2).Split(":")
                varDatePart(1) = varTimePart(0) & ":" & varTimePart(1)

                datepartend.Value = CType(varDatePart(0), Date)
                timepartend.Text = varDatePart(1)

                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_areaaffected from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                listofaffectedarea.SelectedValue = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query)

                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_template from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                listoftemplate.SelectedValue = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query)

                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_description from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                templatecontent.Text = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString

                Dim varFeedback As Object
                varDatabaseRequestMysql(1).Query = String.Format("select ea.employeeactivity_feedback from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", rowid)
                varFeedback = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query)

                feedBack.Text = IIf(IsDBNull(varFeedback), "", varFeedback).ToString
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DisplayPhotoGrid(databasename As String, dbengine As String, rowid As String, filegrid As dgn) As DataSet
            V_DS = New DataSet
            'ReDim varDatabaseRequestMssql2008(3)

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from db_universe_erp_file.dbo.sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'jpg') order by fi.file_datetime;", rowid)

                V_DS = varDatabaseEngineMssql2008.GetDataSet(databasename, varDatabaseRequestMssql2008(2), "TPhotoFileEditor")
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'jpg') order by fi.file_datetime;", rowid)

                V_DS = varDatabaseEngineMysql.GetDataSet(databasename, varDatabaseRequestMysql(2), "TPhotoFileEditor")
            End If

            Return V_DS
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DisplayFileGrid(databasename As String, dbengine As String, rowid As String, filegrid As dgn) As DataSet
            V_DS = New DataSet
            'ReDim varDatabaseRequestMssql2008(3)

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from db_universe_erp_file.dbo.sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", rowid)

                V_DS = varDatabaseEngineMssql2008.GetDataSet(databasename, varDatabaseRequestMssql2008(2), "TFileEditor")
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", rowid)

                V_DS = varDatabaseEngineMysql.GetDataSet(databasename, varDatabaseRequestMysql(2), "TFileEditor")
            End If

            Return V_DS
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, areaaffected As String, activitytemplate As String, datepart As String, timepart As String, datepartend As String, timepartend As String, content As String, feedback As String, userid As String, rowid As String, isnew As Boolean, Optional extendedquery As String = "") As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = "MSSQL" Then
                    If (isnew) Then
                        varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.doc_employeeactivity(employeeactivity_id, employeeactivity_areaaffected, " &
                                                            "employeeactivity_template, employeeactivity_datetime, employeeactivity_time, " &
                                                            "employeeactivity_datetime_end, employeeactivity_time_end, employeeactivity_description, " &
                                                            "employeeactivity_employee,employeeactivity_feedback,employeeactivity_createon) values " &
                                                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',(select usr.user_employee " &
                                                            "from dbo.sys_user usr where usr.user_id = '{8}'),'{9}', " &
                                                            "(select getdate()));", rowid, areaaffected, activitytemplate, datepart, timepart, datepartend, timepartend, content, userid, feedback)
                    Else
                        varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.doc_employeeactivity set employeeactivity_datetime = '{0}', " &
                                                            "employeeactivity_time = '{1}', employeeactivity_datetime_end = '{2}', " &
                                                            "employeeactivity_time_end = '{3}', employeeactivity_areaaffected = '{4}', " &
                                                            "employeeactivity_template = '{5}', employeeactivity_description = '{6}', " &
                                                            "employeeactivity_lastupdate = (select usr.user_employee from dbo.sys_user usr " &
                                                            "where usr.user_id = '{7}'), employeeactivity_feedback = '{9}', " &
                                                            "employeeactivity_updateon = (select getdate()) where employeeactivity_id = '{8}';", datepart, timepart, datepartend, timepartend, areaaffected, activitytemplate, content, userid, rowid, feedback)

                        varDatabaseRequestMssql2008(1).Query += String.Format("update db_universe_erp_file.dbo.sto_file set file_parentdate = '{0}' " &
                                                             "where file_parent = '{1}';", datepart, rowid)
                    End If

                    If extendedquery IsNot String.Empty Then
                        varDatabaseRequestMssql2008(1).Query += extendedquery
                    End If

                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    If (isnew) Then
                        varDatabaseRequestMysql(1).Query = String.Format("insert into doc_employeeactivity(employeeactivity_id, employeeactivity_areaaffected, " &
                                                            "employeeactivity_template, employeeactivity_datetime, employeeactivity_time, " &
                                                            "employeeactivity_datetime_end, employeeactivity_time_end, employeeactivity_description, " &
                                                            "employeeactivity_employee,employeeactivity_feedback,employeeactivity_createon) values " &
                                                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',(select usr.user_employee " &
                                                            "from sys_user usr where usr.user_id = '{8}'),'{9}', " &
                                                            "(select curdate()));", rowid, areaaffected, activitytemplate, datepart, timepart, datepartend, timepartend, content, userid, feedback)
                    Else
                        varDatabaseRequestMysql(1).Query = String.Format("update doc_employeeactivity set employeeactivity_datetime = '{0}', " &
                                                            "employeeactivity_time = '{1}', employeeactivity_datetime_end = '{2}', " &
                                                            "employeeactivity_time_end = '{3}', employeeactivity_areaaffected = '{4}', " &
                                                            "employeeactivity_template = '{5}', employeeactivity_description = '{6}', " &
                                                            "employeeactivity_lastupdate = (select usr.user_employee from sys_user usr " &
                                                            "where usr.user_id = '{7}'), employeeactivity_feedback = '{9}', " &
                                                            "employeeactivity_updateon = (select curdate()) where employeeactivity_id = '{8}';", datepart, timepart, datepartend, timepartend, areaaffected, activitytemplate, content, userid, rowid, feedback)

                        varDatabaseRequestMysql(1).Query += String.Format("update sto_file set file_parentdate = '{0}' " &
                                                             "where file_parent = '{1}';", datepart, rowid)
                    End If

                    If extendedquery IsNot String.Empty Then
                        varDatabaseRequestMysql(1).Query += extendedquery
                    End If

                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                End If

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushPhoto(ByVal dbengine As String, filegrid As dgn, rowid As String, isnew As Boolean, parentdate As Date) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = "MSSQL" Then
                    Dim varCommand As SqlClient.SqlCommand
                    For Each Row As DataGridViewRow In filegrid.Rows
                        If Row.Cells("photo_status").Value Is "Add" Then

                            Dim varQuery As String = String.Empty

                            varCommand = New SqlClient.SqlCommand
                            varQuery = "insert into db_universe_erp_file.dbo.sto_file([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, @FileName, 'jpg', @FileContent, '', @DateNow, " &
                            "'module=DAR;', @Uploader,@ParentDate);"

                            With varCommand
                                .CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY " &
                                                         "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 " &
                                                         "BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", varQuery)

                                .Parameters.AddWithValue("@ID", Row.Cells("photo_id").Value)
                                .Parameters.AddWithValue("@ParentID", rowid)
                                .Parameters.AddWithValue("@FileName", Row.Cells("photo_filename").Value)
                                .Parameters.AddWithValue("@Uploader", Row.Cells("photo_uploader").Value)
                                .Parameters.AddWithValue("@ParentDate", parentdate)
                            End With

                            Dim varMemoryStream = New MemoryStream()
                            Dim varImage As Image = CType(Row.Cells("photo_content").Value, Image)
                            Dim varPhotoByte As Byte() = Nothing

                            varImage.Save(varMemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                            varPhotoByte = varMemoryStream.ToArray

                            Dim varImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            varImageParam.Value = varPhotoByte
                            varCommand.Parameters.Add(varImageParam)

                            varCommand.Parameters.AddWithValue("@DateNow", Row.Cells("photo_datetime").Value)

                            varSuccess = varDatabaseEngineMssql2008.PushImage(varCommand)
                        End If
                    Next
                ElseIf dbengine = "MYSQL" Then
                    Dim varCommand As MySql.Data.MySqlClient.MySqlCommand
                    For Each Row As DataGridViewRow In filegrid.Rows
                        If Row.Cells("photo_status").Value Is "Add" Then

                            Dim varQuery As String = String.Empty

                            varCommand = New MySql.Data.MySqlClient.MySqlCommand
                            varQuery = "insert into sto_file([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, @FileName, 'jpg', @FileContent, '', @DateNow, " &
                            "'module=DAR;', @Uploader,@ParentDate);"

                            With varCommand
                                .CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY " &
                                                         "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 " &
                                                         "BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", varQuery)

                                .Parameters.AddWithValue("@ID", Row.Cells("photo_id").Value)
                                .Parameters.AddWithValue("@ParentID", rowid)
                                .Parameters.AddWithValue("@FileName", Row.Cells("photo_filename").Value)
                                .Parameters.AddWithValue("@Uploader", Row.Cells("photo_uploader").Value)
                                .Parameters.AddWithValue("@ParentDate", parentdate)
                            End With

                            Dim varMemoryStream = New MemoryStream()
                            Dim varImage As Image = CType(Row.Cells("photo_content").Value, Image)
                            Dim varPhotoByte As Byte() = Nothing

                            varImage.Save(varMemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                            varPhotoByte = varMemoryStream.ToArray

                            Dim varImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            varImageParam.Value = varPhotoByte
                            varCommand.Parameters.Add(varImageParam)

                            varCommand.Parameters.AddWithValue("@DateNow", Row.Cells("photo_datetime").Value)

                            varSuccess = varDatabaseEngineMysql.PushImage(varCommand)
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushFile(ByVal dbengine As String, filegrid As dgn, rowid As String, isnew As Boolean, parentdate As Date) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = "MSSQL" Then
                    Dim varCommand As SqlClient.SqlCommand

                    For Each Row As DataGridViewRow In filegrid.Rows
                        If Row.Cells("file_status").Value Is "Add" Then

                            Dim Query As String = String.Empty

                            varCommand = New SqlClient.SqlCommand
                            Query = "insert into db_universe_erp_file.dbo.sto_file([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader,file_parentdate) values(@ID, @ParentID, @FileName, 'pdf', @FileContent, @Tag, @DateNow, " &
                            "'module=DAR;', @Uploader, @ParentDate);"

                            With varCommand
                                .CommandText = "RETRY: BEGIN TRANSACTION BEGIN TRY " & Query & " COMMIT TRANSACTION END TRY " &
                            "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH"

                                .Parameters.AddWithValue("@ID", Row.Cells("file_id").Value)
                                .Parameters.AddWithValue("@ParentID", rowid)
                                .Parameters.AddWithValue("@FileName", Row.Cells("file_filename").Value)
                                .Parameters.AddWithValue("@Uploader", Row.Cells("file_uploader").Value)
                                .Parameters.AddWithValue("@Tag", Row.Cells("file_tag").Value)
                                .Parameters.AddWithValue("@ParentDate", parentdate)
                            End With

                            Dim varFileStream As FileStream = Nothing
                            varFileStream = New FileStream(Row.Cells("file_content").Value.ToString, FileMode.Open, FileAccess.Read)

                            Dim varMemoryStream = New MemoryStream()
                            varFileStream.CopyTo(varMemoryStream)

                            Dim varFileByte As Byte() = Nothing
                            varFileByte = varMemoryStream.ToArray

                            Dim varFileParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            varFileParam.Value = varFileByte
                            varCommand.Parameters.Add(varFileParam)

                            varCommand.Parameters.AddWithValue("@DateNow", Row.Cells("file_datetime").Value)

                            varSuccess = varDatabaseEngineMssql2008.PushImage(varCommand)
                        End If
                    Next
                ElseIf dbengine = "MYSQL" Then
                    Dim varCommand As MySql.Data.MySqlClient.MySqlCommand

                    For Each varRow As DataGridViewRow In filegrid.Rows
                        If varRow.Cells("file_status").Value Is "Add" Then

                            Dim varQuery As String = String.Empty

                            varCommand = New MySql.Data.MySqlClient.MySqlCommand
                            varQuery = "insert into sto_file([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader,file_parentdate) values(@ID, @ParentID, @FileName, 'pdf', @FileContent, @Tag, @DateNow, " &
                            "'module=DAR;', @Uploader, @ParentDate);"

                            With varCommand
                                .CommandText = "RETRY: BEGIN TRANSACTION BEGIN TRY " & varQuery & " COMMIT TRANSACTION END TRY " &
                            "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH"

                                .Parameters.AddWithValue("@ID", varRow.Cells("file_id").Value)
                                .Parameters.AddWithValue("@ParentID", rowid)
                                .Parameters.AddWithValue("@FileName", varRow.Cells("file_filename").Value)
                                .Parameters.AddWithValue("@Uploader", varRow.Cells("file_uploader").Value)
                                .Parameters.AddWithValue("@Tag", varRow.Cells("file_tag").Value)
                                .Parameters.AddWithValue("@ParentDate", parentdate)
                            End With

                            Dim varFileStream As FileStream = Nothing
                            varFileStream = New FileStream(varRow.Cells("file_content").Value.ToString, FileMode.Open, FileAccess.Read)

                            Dim varMemoryStream = New MemoryStream()
                            varFileStream.CopyTo(varMemoryStream)

                            Dim varFileByte As Byte() = Nothing
                            varFileByte = varMemoryStream.ToArray

                            Dim varFileParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            varFileParam.Value = varFileByte
                            varCommand.Parameters.Add(varFileParam)

                            varCommand.Parameters.AddWithValue("@DateNow", varRow.Cells("file_datetime").Value)

                            varSuccess = varDatabaseEngineMysql.PushImage(varCommand)
                        End If
                    Next
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
                varSuccess = False
            End Try

            Return varSuccess
        End Function

    End Class

    Public Class Reports
        <SupportedOSPlatform("windows")>
        Public Shared Sub Display(databasename As String, dbengine As String, chkfrom As chk, chkto As chk, chkarea As chk, chkactivity As chk, chkby As chk, dtpfrom As dtp, dtpto As dtp, cboarea As cbo, cboactivity As cbo, cboby As cbo, txtdescription As txt, datasetname As DataSet)

            Dim varWhere As String
            Dim varDTPfrom As String = dtpfrom.Value.Year & "-" & dtpfrom.Value.Month & "-" & dtpfrom.Value.Day
            Dim varDTPto As String = dtpto.Value.Year & "-" & dtpto.Value.Month & "-" & dtpto.Value.Day

            Try
                varWhere = "Where "

                If (chkfrom.Checked) Then
                    If (chkto.Checked) Then
                        varWhere += String.Format("(ea.employeeactivity_datetime >= '{0}' and ea.employeeactivity_datetime <= '{1}')", varDTPfrom, varDTPto)
                    Else
                        varWhere += String.Format("(ea.employeeactivity_datetime = '{0}')", varDTPfrom)
                    End If
                End If

                If (chkarea.Checked) Then
                    If varWhere = "Where " Then
                        varWhere += String.Format("(aa.areaaffected_id = '{0}')", cboarea.SelectedValue)
                    Else
                        varWhere += String.Format(" and (aa.areaaffected_id = '{0}')", cboarea.SelectedValue)
                    End If
                End If

                If (chkactivity.Checked) Then
                    If varWhere = "Where " Then
                        varWhere += String.Format("(ea.employeeactivity_template = '{0}')", cboactivity.SelectedValue)
                    Else
                        varWhere += String.Format(" and (ea.employeeactivity_template = '{0}')", cboactivity.SelectedValue)
                    End If
                End If

                If (chkby.Checked) Then
                    If varWhere = "Where " Then
                        varWhere += String.Format("(ea.employeeactivity_employee = '{0}')", cboby.SelectedValue)
                    Else
                        varWhere += String.Format(" and (ea.employeeactivity_employee = '{0}')", cboby.SelectedValue)
                    End If
                End If

                If txtdescription.XOSQLText.Trim <> String.Empty Then

                    If varWhere <> "Where " Then
                        varWhere += String.Format(" and ")
                    End If

                    'multiple keywords execution
                    If Not (txtdescription.XOSQLText.Trim.Contains("||")) Then
                        varWhere += String.Format("(ea.employeeactivity_description like '%{0}%') ", txtdescription.XOSQLText)
                    Else
                        Dim varContainText As String() = txtdescription.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each varText As String In varContainText
                            If varText <> "" Then

                                varText.Trim()

                                If varRepeater = 0 Then
                                    varWhere.Append(CChar($"ea.employeeactivity_description like '%{varText}%'"))
                                Else
                                    varWhere.Append(CChar($" and ea.employeeactivity_description like '%{varText}%'"))
                                End If
                            End If

                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If
                End If

                If varWhere = "Where " Then
                    varWhere = String.Empty
                End If

                datasetname.Clear()

                Dim varTimeFormat(2) As String

                If dbengine = "MSSQL" Then
                    'same day with different time
                    varTimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8))) as [employeeactivity_time]")

                    'same day with time range format & different day format
                    varTimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
                                               "(ea.employeeactivity_time_end = ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) " &
                                               "+ cast(ea.employeeactivity_time as varchar(8)) when " &
                                               "((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
                                               "(ea.employeeactivity_time_end > ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                               "when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + " &
                                               "(cast(ea.employeeactivity_time as varchar(8))) + char(13) + char(10) + ' to ' + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_datetime_end as varchar(10))) + ' ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                    Dim varDescription As String = "case when (ea.employeeactivity_feedback is null) or " &
                    "(convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else " &
                    "convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' " &
                    "+ char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                    varDatabaseRequestMssql2008(0).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) " &
                                                        "and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                        "(convert(varchar(max),e.employee_nickname) + ' / ' + " &
                                                        "convert(varchar(max),(select em.employee_nickname from dbo.man_employee em " &
                                                        "where em.employee_id = ea.employeeactivity_lastupdate))) else " &
                                                        "e.employee_nickname end as [employee_nickname], aa.areaaffected_order " &
                                                        "from dbo.doc_employeeactivity ea " &
                                                        "inner join dbo.doc_areaaffected aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                        "inner join dbo.man_employee e on ea.employeeactivity_employee = e.employee_id {0} " &
                                                        "order by aa.areaaffected_order", varWhere, varTimeFormat(2), varDescription)

                    datasetname = varDatabaseEngineMssql2008.FillDataset(databasename, varDatabaseRequestMssql2008(0).Query, datasetname, "employeeactivity")
                ElseIf dbengine = "MYSQL" Then
                    'same day with different time
                    varTimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8))) as `employeeactivity_time`")

                    'same day with time range format & different day format
                    varTimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
                                               "(ea.employeeactivity_time_end = ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) " &
                                               "+ cast(ea.employeeactivity_time as varchar(8)) when " &
                                               "((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
                                               "(ea.employeeactivity_time_end > ea.employeeactivity_time)) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                               "when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then " &
                                               "(cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + " &
                                               "(cast(ea.employeeactivity_time as varchar(8))) + char(13) + char(10) + ' to ' + char(13) + char(10) + " &
                                               "(cast(ea.employeeactivity_datetime_end as varchar(10))) + ' ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                    Dim varDescription As String = "case when (ea.employeeactivity_feedback is null) or " &
                    "(convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else " &
                    "convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' " &
                    "+ char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                    varDatabaseRequestMysql(0).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) " &
                                                        "and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                        "(convert(varchar(max),e.employee_nickname) + ' / ' + " &
                                                        "convert(varchar(max),(select em.employee_nickname from dbo.man_employee em " &
                                                        "where em.employee_id = ea.employeeactivity_lastupdate))) else " &
                                                        "e.employee_nickname end as [employee_nickname], aa.areaaffected_order " &
                                                        "from doc_employeeactivity ea " &
                                                        "inner join doc_areaaffected aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                        "inner join man_employee e on ea.employeeactivity_employee = e.employee_id {0} " &
                                                        "order by aa.areaaffected_order", varWhere, varTimeFormat(2), varDescription)

                    datasetname = varDatabaseEngineMysql.FillDataSet(databasename, varDatabaseRequestMysql(0).Query, datasetname, "employeeactivity")
                End If
            Catch ex As Exception
                datasetname = Nothing
            End Try
        End Sub
    End Class
End Namespace
