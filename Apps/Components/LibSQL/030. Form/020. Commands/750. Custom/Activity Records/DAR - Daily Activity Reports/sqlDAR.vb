Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace Commands.DAR
    Public Class View
        'ReDim V_DBR_MSSQL2008(3)
        Public V_IsEmpFilter As Boolean
        Public V_EID As String
        Public V_ContentID As String
        Public V_ContentYear As String

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckSettings(ByVal DBEngine As String, ByVal UID As String, ByVal Attribute As String) As Boolean
            Dim V_IsExist As Integer = 0
            Dim V_Attribute(1) As String

            V_Attribute(0) = "ViewPhotoTab"

            If DBEngine = "MSSQL" Then
                For V_Row = 0 To 0
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.modulesettings_id) from dbo.[[sys]]modulesettings] mods inner join " &
                                                        "dbo.[[sys]]module] mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') " &
                                                        "and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, V_Attribute(V_Row))
                    V_IsExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

                    If V_IsExist = 0 Then
                        V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]modulesettings](modulesettings_id, modulesettings_module," &
                                                            "modulesettings_user, modulesettings_attribute, modulesettings_value) values('{0}', " &
                                                            "(select mo.module_id from dbo.[[sys]]module] mo where mo.module_code = 'DAR'),'{1}','{2}'," &
                                                            "'False')", CMCv.Security.Encrypt.MD5(), UID, V_Attribute(V_Row))
                        V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                    End If
                Next
            ElseIf DBEngine = "MYSQL" Then
                For V_Row = 0 To 0
                    V_DBR_MYSQL(0).Query = String.Format("select count(mods.modulesettings_id) from sys_modulesettings mods inner join " &
                                                        "sys_module mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') " &
                                                        "and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, V_Attribute(V_Row))
                    V_IsExist = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Integer)

                    If V_IsExist = 0 Then
                        V_DBR_MYSQL(1).Query = String.Format("insert into sys_modulesettings(modulesettings_id, modulesettings_module," &
                                                            "modulesettings_user, modulesettings_attribute, modulesettings_value) values('{0}', " &
                                                            "(select mo.module_id from sys_module mo where mo.module_code = 'DAR'),'{1}','{2}'," &
                                                            "'False')", CMCv.Security.Encrypt.MD5(), UID, V_Attribute(V_Row))
                        V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                    End If
                Next
            End If

            Dim V_Value As Boolean = False

            If DBEngine = "MSSQL" Then

            ElseIf DBEngine = "MYSQL" Then

            End If
            V_DBR_MSSQL2008(0).Query = String.Format("select mods.modulesettings_value from dbo.[[sys]]modulesettings] mods inner join dbo.[[sys]]module] " &
                                                    "mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') and " &
                                                    "(mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, "ViewPhotoTab")

            V_Value = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Boolean)

            Return V_Value
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(ByVal DBEngine As String, ByVal UID As String, ByVal Attribute As String, ByVal Values As String) As Boolean
            Dim V_IsSuccess As Boolean = False

            Try
                If DBEngine = "MSSQL" Then

                ElseIf DBEngine = "MYSQL" Then

                End If


                V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]modulesettings] set modulesettings_value = '{0}' where (modulesettings_module = " &
                                                        "(select mo.module_id from dbo.[[sys]]module] mo where mo.module_code = 'DAR')) and " &
                                                        "(modulesettings_user = '{1}') and (modulesettings_attribute = '{2}')", Values, UID, Attribute)

                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                V_IsSuccess = True
            Catch ex As Exception
                V_IsSuccess = False
            End Try

            Return V_IsSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillEmployee(ByVal DBEngine As String, ByVal Employee As cbo)
            If DBEngine = "MSSQL" Then

            ElseIf DBEngine = "MYSQL" Then

            End If

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_id, em.employee_fullname from dbo.[[man]]employee] em where em.employee_id in " &
                                                    "(select ea.employeeactivity_employee from dbo.[[doc]]employeeactivity] ea group by " &
                                                    "ea.employeeactivity_employee) order by em.employee_fullname;")
            V_DBR_MSSQL2008(1).Dropdown = Employee
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TEmployee")
            Employee.DisplayMember = "employee_fullname"
            Employee.ValueMember = "employee_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub DisplayMainGrid(ByVal DBEngine As String, ByVal Find As txt, ByVal DateGrid As dgn, ByVal DateStatusBar As stt, ContentStatusBar As stt, ByVal chkDateFilter As chk, ByVal dtpDateFilter As dtp, ByVal chkByFilter As chk, ByVal cboByFilter As cbo, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim V_Where As String = String.Format("where ")

                If cboByFilter.Items.Count = 0 Then
                    V_EID = "-1"
                Else
                    V_EID = cboByFilter.SelectedValue().ToString
                End If

                If DBEngine = "MSSQL" Then
                    If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh) Then
                        If Not (chkDateFilter.Checked) Then
                            V_Where += String.Format("(year(ea.employeeactivity_datetime) = year(getdate())) And (month(ea.employeeactivity_datetime) = " &
                                                "month(getdate()))")
                        Else
                            V_Where += String.Format("(year(ea.employeeactivity_datetime) = {0} And month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                        End If

                        If (chkByFilter.Checked) Then
                            V_Where += String.Format(" And (ea.employeeactivity_employee = '{0}')", V_EID)
                        End If
                    Else
                        If Not (Find.XOSQLText.Trim.Contains("||")) Then
                            V_Where += String.Format("(ea.employeeactivity_description like '%{0}%')", Find.XOSQLText)
                        Else
                            Dim V_ContainText As String() = Find.XOSQLText.Split("||")
                            Dim V_Repeater As Integer = 0

                            V_Where += String.Format("(")

                            For Each V_Text As String In V_ContainText
                                If (V_Text <> "") Then
                                    If V_Repeater = 0 Then
                                        V_Where += String.Format("ea.employeeactivity_description like '%{0}%'", V_Text)
                                    Else
                                        V_Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", V_Text)
                                    End If
                                End If

                                V_Repeater += 1
                            Next

                            V_Where += String.Format(")")
                        End If

                        If (chkDateFilter.Checked) Then
                            V_Where += String.Format(" and (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                        End If

                        If (chkByFilter.Checked) Then
                            V_Where += String.Format(" and (ea.employeeactivity_employee = '{0}')", V_EID)
                        End If
                    End If

                    V_DBR_MSSQL2008(0).Query = String.Format("select ea.employeeactivity_datetime, (convert(varchar,ea.employeeactivity_datetime,106) + '' + " &
                                                        "char(13) + char(10) + '' + left(datename(dw,ea.employeeactivity_datetime),3)) as [employeeactivity_longdate] " &
                                                        "from dbo.[[doc]]employeeactivity] ea {0} group by ea.employeeactivity_datetime " &
                                                        "order by ea.employeeactivity_datetime desc", V_Where)

                    V_DBR_MSSQL2008(0).DataGrid = DateGrid
                    V_DBR_MSSQL2008(0).StatusBar = DateStatusBar
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TDailyReportsDate")

                    V_IsEmpFilter = chkByFilter.Checked
                ElseIf DBEngine = "MYSQL" Then
                    If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh) Then
                        If Not (chkDateFilter.Checked) Then
                            V_Where += String.Format("(year(ea.employeeactivity_datetime) = year(now())) And (month(ea.employeeactivity_datetime) = " &
                                                "month(now()))")
                        Else
                            V_Where += String.Format("(year(ea.employeeactivity_datetime) = {0} And month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                        End If

                        If (chkByFilter.Checked) Then
                            V_Where += String.Format(" And (ea.employeeactivity_employee = '{0}')", V_EID)
                        End If
                    Else
                        If Not (Find.XOSQLText.Trim.Contains("||")) Then
                            V_Where += String.Format("(ea.employeeactivity_description like '%{0}%')", Find.XOSQLText)
                        Else
                            Dim V_ContainText As String() = Find.XOSQLText.Split("||")
                            Dim V_Repeater As Integer = 0

                            V_Where += String.Format("(")

                            For Each V_Text As String In V_ContainText
                                If (V_Text <> "") Then
                                    If V_Repeater = 0 Then
                                        V_Where += String.Format("ea.employeeactivity_description like '%{0}%'", V_Text)
                                    Else
                                        V_Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", V_Text)
                                    End If
                                End If

                                V_Repeater += 1
                            Next

                            V_Where += String.Format(")")
                        End If

                        If (chkDateFilter.Checked) Then
                            V_Where += String.Format(" and (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                        End If

                        If (chkByFilter.Checked) Then
                            V_Where += String.Format(" and (ea.employeeactivity_employee = '{0}')", V_EID)
                        End If
                    End If

                    V_DBR_MYSQL(0).Query = String.Format("select ea.employeeactivity_datetime, (convert(varchar,ea.employeeactivity_datetime,106) + '' + " &
                                                        "char(13) + char(10) + '' + left(datename(dw,ea.employeeactivity_datetime),3)) as `employeeactivity_longdate` " &
                                                        "from doc_employeeactivity ea {0} group by ea.employeeactivity_datetime " &
                                                        "order by ea.employeeactivity_datetime desc", V_Where)

                    V_DBR_MYSQL(0).DataGrid = DateGrid
                    V_DBR_MYSQL(0).StatusBar = DateStatusBar
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TDailyReportsDate")

                    V_IsEmpFilter = chkByFilter.Checked
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub DisplaySecondGrid(ByVal DBEngine As String, ByVal DateGrid As String, ByVal ContentGrid As dgn, ByVal ContentStatusBar As stt, ByVal Find As txt, Optional ByVal ShowAttachment As Boolean = False, Optional ByVal PhotoGrid As dgn = Nothing, Optional ByVal FileGrid As dgn = Nothing)
            Try
                'Dim _CONTENTDATE As Date
                Dim V_CONTENTDATE_S As String = String.Empty
                Dim V_Where As String = "where "

                V_CONTENTDATE_S = DateGrid

                'If DateGrid.Rows.Count = 0 Then
                '    'contentdate = Now.AddYears(2)
                '    _CONTENTDATE_S = "9999-12-31"
                'Else
                '    _CONTENTDATE = DateGrid.CurrentRow.Cells("employeeactivity_datetime").Value
                '    _CONTENTDATE_S = _CONTENTDATE.Year & "-" & _CONTENTDATE.Month & "-" & _CONTENTDATE.Day
                'End If

                'add date query-cut
                V_Where += String.Format(" (ea.employeeactivity_datetime = '{0}')", V_CONTENTDATE_S)

                If DBEngine = "MSSQL" Then
                    ReDim V_DBR_MSSQL2008(3)

                    'add text query-cut
                    If (Find.XOSQLText <> String.Empty) Then
                        V_Where += String.Format(" and ")

                        'multiple keywords execution
                        If Not (Find.XOSQLText.Trim.Contains("||")) Then
                            V_Where += String.Format("(ea.employeeactivity_description like '%{0}%') ", Find.XOSQLText)
                        Else
                            Dim V_ContainText As String() = Find.XOSQLText.Split("||")
                            Dim V_Repeater As Integer = 0

                            V_Where += String.Format("(")

                            For Each V_Text As String In V_ContainText
                                If V_Text <> "" Then

                                    V_Text.Trim()

                                    If V_Repeater = 0 Then
                                        V_Where += String.Format("ea.employeeactivity_description like '%{0}%'", V_Text)
                                    Else
                                        V_Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", V_Text)
                                    End If
                                End If

                                V_Repeater += 1
                            Next

                            V_Where += String.Format(")")
                        End If
                    End If

                    'add employee filter query-cut
                    If (V_IsEmpFilter) Then
                        V_Where += String.Format(" and (ea.employeeactivity_employee = '{0}') ", V_EID)
                    End If

                    Dim V_TimeFormat(2) As String

                    'same day with different time
                    V_TimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                                   "as [employeeactivity_time]")

                    'same day with time range format & different day format
                    V_TimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
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

                    Dim V_Description As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') " &
                        "then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) " &
                    "+ '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                    V_DBR_MSSQL2008(2).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and " &
                                                            "(ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                            "(convert(varchar(max), e.employee_nickname) + ' / ' + convert(varchar(max), " &
                                                            "(select em.employee_nickname from dbo.[[man]]employee] em where " &
                                                            "em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as [employee_nickname], " &
                                                            "e.employee_id, ea.employeeactivity_id from dbo.[[doc]]employeeactivity] ea " &
                                                            "inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                            "inner join dbo.[[man]]employee] e on ea.employeeactivity_employee = e.employee_id {0} order by " &
                                                            "aa.areaaffected_order, ea.employeeactivity_time", V_Where, V_TimeFormat(2), V_Description)

                    V_DBR_MSSQL2008(2).DataGrid = ContentGrid
                    V_DBR_MSSQL2008(2).StatusBar = ContentStatusBar
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(2), "TDailyActivity")

                    If V_DBR_MSSQL2008(2).DataGrid Is Nothing Then
                        V_DBR_MSSQL2008(2).DataGrid = ContentGrid
                        V_DBR_MSSQL2008(2).StatusBar = ContentStatusBar
                    End If

                    If (PhotoGrid Is Nothing) AndAlso (FileGrid Is Nothing) Then
                        Return
                    End If

                    If (ShowAttachment) Then
                        If V_DBR_MSSQL2008(2).DataGrid.RowCount = 0 Then
                            V_ContentID = "-1"
                        Else
                            V_ContentID = V_DBR_MSSQL2008(2).DataGrid.CurrentRow.Cells("employeeactivity_id").Value.ToString
                        End If
                        Call DisplayPhotoGrid(DBEngine, V_ContentID, PhotoGrid)
                        Call DisplayFileGrid(DBEngine, V_ContentID, FileGrid)
                    End If
                ElseIf DBEngine = "MYSQL" Then
                    ReDim V_DBR_MYSQL(3)

                    'add text query-cut
                    If (Find.XOSQLText <> String.Empty) Then
                        V_Where += String.Format(" and ")

                        'multiple keywords execution
                        If Not (Find.XOSQLText.Trim.Contains("||")) Then
                            V_Where += String.Format("(ea.employeeactivity_description like '%{0}%') ", Find.XOSQLText)
                        Else
                            Dim V_ContainText As String() = Find.XOSQLText.Split("||")
                            Dim V_Repeater As Integer = 0

                            V_Where += String.Format("(")

                            For Each V_Text As String In V_ContainText
                                If V_Text <> "" Then

                                    V_Text.Trim()

                                    If V_Repeater = 0 Then
                                        V_Where += String.Format("ea.employeeactivity_description like '%{0}%'", V_Text)
                                    Else
                                        V_Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", V_Text)
                                    End If
                                End If

                                V_Repeater += 1
                            Next

                            V_Where += String.Format(")")
                        End If
                    End If

                    'add employee filter query-cut
                    If (V_IsEmpFilter) Then
                        V_Where += String.Format(" and (ea.employeeactivity_employee = '{0}') ", V_EID)
                    End If

                    Dim V_TimeFormat(2) As String

                    'same day with different time
                    V_TimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) " &
                                                   "as `employeeactivity_time`")

                    'same day with time range format & different day format
                    V_TimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) And " &
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

                    Dim V_Description As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') " &
                        "then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) " &
                    "+ '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as `employeeactivity_description`"

                    V_DBR_MYSQL(2).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and " &
                                                            "(ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                            "(convert(varchar(max), e.employee_nickname) + ' / ' + convert(varchar(max), " &
                                                            "(select em.employee_nickname from man_employee em where " &
                                                            "em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as `employee_nickname`, " &
                                                            "e.employee_id, ea.employeeactivity_id from doc_employeeactivity ea " &
                                                            "inner join doc_areaaffected aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                            "inner join man_employee e on ea.employeeactivity_employee = e.employee_id {0} order by " &
                                                            "aa.areaaffected_order, ea.employeeactivity_time", V_Where, V_TimeFormat(2), V_Description)

                    V_DBR_MYSQL(2).DataGrid = ContentGrid
                    V_DBR_MYSQL(2).StatusBar = ContentStatusBar
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(2), "TDailyActivity")

                    If V_DBR_MYSQL(2).DataGrid Is Nothing Then
                        V_DBR_MYSQL(2).DataGrid = ContentGrid
                        V_DBR_MYSQL(2).StatusBar = ContentStatusBar
                    End If

                    If (PhotoGrid Is Nothing) AndAlso (FileGrid Is Nothing) Then
                        Return
                    End If

                    If (ShowAttachment) Then
                        If V_DBR_MYSQL(2).DataGrid.RowCount = 0 Then
                            V_ContentID = "-1"
                        Else
                            V_ContentID = V_DBR_MYSQL(2).DataGrid.CurrentRow.Cells("employeeactivity_id").Value.ToString
                        End If
                        Call DisplayPhotoGrid(DBEngine, V_ContentID, PhotoGrid)
                        Call DisplayFileGrid(DBEngine, V_ContentID, FileGrid)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayPhotoGrid(ByVal DBEngine As String, ByVal ContentID As String, ByVal FileGrid As dgn, Optional ByVal RecordYear As String = "")
            ReDim V_DBR_MSSQL2008(5)
            Dim V_CONTENTID As String = ContentID

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(4).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, (convert(varchar(25),fi.file_content_size) + ' KB') " &
                                                    "as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], " &
                                                    "fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' " &
                                                    "and fi.file_filetype = 'jpg') order by fi.file_score desc, fi.file_datetime;", V_CONTENTID)
                V_DBR_MSSQL2008(4).DataGrid = FileGrid
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(4), "TPhotoFile")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(4).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, (convert(varchar(25),fi.file_content_size) + ' KB') " &
                                                    "as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], " &
                                                    "fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' " &
                                                    "and fi.file_filetype = 'jpg') order by fi.file_score desc, fi.file_datetime;", V_CONTENTID)
                V_DBR_MYSQL(4).DataGrid = FileGrid
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(4), "TPhotoFile")
            End If

        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayFileGrid(ByVal DBEngine As String, ByVal ContentID As String, ByVal FileGrid As dgn, Optional ByVal RecordYear As String = "")
            ReDim V_DBR_MSSQL2008(6)
            Dim V_CONTENTID As String = ContentID

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(5).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, '' as [file_content], " &
                                                    "(convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], " &
                                                    "(convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, " &
                                                    "fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", V_CONTENTID)
                V_DBR_MSSQL2008(5).DataGrid = FileGrid
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(5), "TFile")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(5).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, '' as [file_content], " &
                                                    "(convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], " &
                                                    "(convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, " &
                                                    "fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where " &
                                                    "em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname " &
                                                    "from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], " &
                                                    "'' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", V_CONTENTID)
                V_DBR_MYSQL(5).DataGrid = FileGrid
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(5), "TFile")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPDFFile(ByVal DBEngine As String, ByVal RowID As String, Optional ByVal RecordYear As String = "") As Object
            Dim V_File As Object = Nothing

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select fi.file_content from db_universe_erp_file.dbo.[[sto]]file] fi where fi.file_id = '{0}'", RowID)

                V_File = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select fi.file_content from db_universe_erp_file.dbo.[[sto]]file] fi where fi.file_id = '{0}'", RowID)

                V_File = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query)
            End If

            Return V_File
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False
            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete " &
                                                        "from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("delete from doc_employeeactivity where employeeactivity_id = '{0}';delete " &
                                                        "from sto_file where file_parent = '{0}';", RowID)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsLike(ByVal DBEngine As String, ByVal FileID As String, EID As String) As Boolean
            Dim V_Result As Integer = 0
            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select count(ff.filefeedback_id) as [islike] from db_universe_erp_file.dbo.[[sto]]filefeedback] ff " &
                                                        "where ff.filefeedback_file = '{0}' and ff.filefeedback_employee = '{1}';", FileID, EID)
                    V_Result = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("select count(ff.filefeedback_id) as `islike` from sto_filefeedback ff " &
                                                        "where ff.filefeedback_file = '{0}' and ff.filefeedback_employee = '{1}';", FileID, EID)
                    V_Result = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), Integer)
                End If

            Catch ex As Exception
                V_Result = 0
            End Try

            If V_Result = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function LikePhoto(ByVal DBEngine As String, ByVal FileID As String, ByVal EID As String, ByVal FileOwner As String) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into db_universe_erp_file.dbo.[[sto]]filefeedback](filefeedback_datetime, filefeedback_file, " &
                                                        "filefeedback_employee, filefeedback_type, filefeedback_value, filefeedback_text) values(GETDATE(), " &
                                                        "'{0}', '{1}', 'Like', 1, 'N/A'); insert into dbo.[[sys]]notification](notification_datetime, " &
                                                        "notification_employee, notification_message, notification_isread) values(GETDATE(), '{2}', " &
                                                        "(select em.employee_fullname from dbo.[[man]]employee] em where em.employee_id = '{1}') " &
                                                        "+ ' like one of your photo.', 0);update db_universe_erp_file.dbo.[[sto]]file] " &
                                                        "set file_score = (select count(ff.filefeedback_value) " &
                                                        "from db_universe_erp_file.dbo.[[sto]]filefeedback] ff where (ff.filefeedback_file = '{0}') and " &
                                                        "(ff.filefeedback_type = 'Like')) where (file_id = '{0}');", FileID, EID, FileOwner)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("insert into db_universe_erp_file.dbo.[[sto]]filefeedback](filefeedback_datetime, filefeedback_file, " &
                                                        "filefeedback_employee, filefeedback_type, filefeedback_value, filefeedback_text) values(GETDATE(), " &
                                                        "'{0}', '{1}', 'Like', 1, 'N/A'); insert into dbo.[[sys]]notification](notification_datetime, " &
                                                        "notification_employee, notification_message, notification_isread) values(GETDATE(), '{2}', " &
                                                        "(select em.employee_fullname from dbo.[[man]]employee] em where em.employee_id = '{1}') " &
                                                        "+ ' like one of your photo.', 0);update db_universe_erp_file.dbo.[[sto]]file] " &
                                                        "set file_score = (select count(ff.filefeedback_value) " &
                                                        "from db_universe_erp_file.dbo.[[sto]]filefeedback] ff where (ff.filefeedback_file = '{0}') and " &
                                                        "(ff.filefeedback_type = 'Like')) where (file_id = '{0}');", FileID, EID, FileOwner)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class

    Public Class Editor
        Private V_DS As DataSet

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETAffectedArea(ByVal DBEngine As String, ByVal ListOfAffectedArea As CMCv.cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = "select aa.areaaffected_id, aa.areaaffected_name from dbo.[[doc]]areaaffected] aa order by aa.areaaffected_order"
                V_DBR_MSSQL2008(1).Dropdown = ListOfAffectedArea
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TAffectedArea")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = "select aa.areaaffected_id, aa.areaaffected_name from doc_areaaffected aa order by aa.areaaffected_order"
                V_DBR_MYSQL(1).Dropdown = ListOfAffectedArea
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TAffectedArea")
            End If

            ListOfAffectedArea.DisplayMember = "areaaffected_name"
            ListOfAffectedArea.ValueMember = "areaaffected_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETTemplateTitle(ByVal DBEngine As String, ByVal ListOfTemplate As CMCv.cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = "select tp.template_id, tp.template_title from dbo.[[doc]]template] tp inner join dbo.[[sys]]module] mo on " &
                "mo.module_id = tp.template_module where mo.module_code = 'DAR' order by tp.template_title"
                V_DBR_MSSQL2008(1).Dropdown = ListOfTemplate
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TTemplate")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = "select tp.template_id, tp.template_title from doc_template tp inner join sys_module mo on " &
                "mo.module_id = tp.template_module where mo.module_code = 'DAR' order by tp.template_title"
                V_DBR_MYSQL(1).Dropdown = ListOfTemplate
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TTemplate")
            End If

            ListOfTemplate.DisplayMember = "template_title"
            ListOfTemplate.ValueMember = "template_id"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETTemplateContent(ByVal DBEngine As String, ByVal ListOfTemplate As CMCv.cbo) As String
            Dim V_TemplateContent As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select tp.template_text1 from dbo.[[doc]]template] tp where tp.template_id = '{0}'", ListOfTemplate.SelectedValue)
                V_TemplateContent = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select tp.template_text1 from doc_template tp where tp.template_id = '{0}'", ListOfTemplate.SelectedValue)
                V_TemplateContent = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_TemplateContent
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETRowValue(ByVal DBEngine As String, ByVal RowID As String, ByVal DatePart As CMCv.dtp, ByVal TimePart As CMCv.meb, ByVal DatePartEnd As CMCv.dtp, ByVal TimePartEnd As CMCv.meb, ByVal ListOfAffectedArea As cbo, ByVal ListOfTemplate As cbo, ByVal TemplateContent As CMCv.txt, ByVal FeedBack As CMCv.txt)
            Dim V_DatePart(3) As String
            Dim V_TimeParts(1) As TimeSpan
            Dim V_TimePart(3) As String

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_DatePart(0) = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_time from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_TimeParts(0) = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), TimeSpan)

                V_DatePart(2) = Convert.ToString(V_TimeParts(0))
                V_TimePart = V_DatePart(2).Split(":")
                V_DatePart(1) = V_TimePart(0) & ":" & V_TimePart(1)

                DatePart.Value = CType(V_DatePart(0), Date)
                TimePart.Text = V_DatePart(1)

                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_datetime_end from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_DatePart(0) = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_time_end from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_TimeParts(0) = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), TimeSpan)

                V_DatePart(2) = Convert.ToString(V_TimeParts(0))
                V_TimePart = V_DatePart(2).Split(":")
                V_DatePart(1) = V_TimePart(0) & ":" & V_TimePart(1)

                DatePartEnd.Value = CType(V_DatePart(0), Date)
                TimePartEnd.Text = V_DatePart(1)

                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_areaaffected from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                ListOfAffectedArea.SelectedValue = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_template from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                ListOfTemplate.SelectedValue = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)

                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_description from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                TemplateContent.Text = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

                Dim V_Feedback As Object
                V_DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_feedback from dbo.[[doc]]employeeactivity] ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_Feedback = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query)
                FeedBack.Text = IIf(IsDBNull(V_Feedback), "", V_Feedback).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_datetime from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_DatePart(0) = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString

                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_time from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_TimeParts(0) = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), TimeSpan)

                V_DatePart(2) = Convert.ToString(V_TimeParts(0))
                V_TimePart = V_DatePart(2).Split(":")
                V_DatePart(1) = V_TimePart(0) & ":" & V_TimePart(1)

                DatePart.Value = CType(V_DatePart(0), Date)
                TimePart.Text = V_DatePart(1)

                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_datetime_end from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_DatePart(0) = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString

                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_time_end from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_TimeParts(0) = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), TimeSpan)

                V_DatePart(2) = Convert.ToString(V_TimeParts(0))
                V_TimePart = V_DatePart(2).Split(":")
                V_DatePart(1) = V_TimePart(0) & ":" & V_TimePart(1)

                DatePartEnd.Value = CType(V_DatePart(0), Date)
                TimePartEnd.Text = V_DatePart(1)

                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_areaaffected from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                ListOfAffectedArea.SelectedValue = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query)

                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_template from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                ListOfTemplate.SelectedValue = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query)

                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_description from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                TemplateContent.Text = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString

                Dim V_Feedback As Object
                V_DBR_MYSQL(1).Query = String.Format("select ea.employeeactivity_feedback from doc_employeeactivity ea " &
                                                    "where ea.employeeactivity_id = '{0}'", RowID)
                V_Feedback = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query)

                FeedBack.Text = IIf(IsDBNull(V_Feedback), "", V_Feedback).ToString
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function DisplayPhotoGrid(ByVal DBEngine As String, ByVal RowID As String, ByVal FileGrid As dgn) As DataSet
            V_DS = New DataSet
            'ReDim V_DBR_MSSQL2008(3)

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'jpg') order by fi.file_datetime;", RowID)

                V_DS = V_DBE_MSSQL2008.GETDATASET(V_DBR_MSSQL2008(2), "TPhotoFileEditor")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'jpg') order by fi.file_datetime;", RowID)

                V_DS = V_DBE_MYSQL.GETDATASET(V_DBR_MYSQL(2), "TPhotoFileEditor")
            End If

            Return V_DS
        End Function

        <SupportedOSPlatform("windows")>
        Public Function DisplayFileGrid(ByVal DBEngine As String, ByVal RowID As String, ByVal FileGrid As dgn) As DataSet
            V_DS = New DataSet
            'ReDim V_DBR_MSSQL2008(3)

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", RowID)

                V_DS = V_DBE_MSSQL2008.GETDATASET(V_DBR_MSSQL2008(2), "TFileEditor")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(2).Query = String.Format("select fi.file_id, fi.file_filename, fi.file_tag, fi.file_content, fi.file_datetime, fi.file_uploader " &
                                                    "from sto_file fi where (fi.file_parent = '{0}' and " &
                                                    "fi.file_filetype = 'pdf') order by fi.file_datetime;", RowID)

                V_DS = V_DBE_MYSQL.GETDATASET(V_DBR_MYSQL(2), "TFileEditor")
            End If

            Return V_DS
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal AreaAffected As String, ByVal ActivityTemplate As String, ByVal DatePart As String, ByVal TimePart As String, ByVal DatePartEnd As String, ByVal TimePartEnd As String, ByVal Content As String, ByVal Feedback As String, ByVal UserID As String, ByVal RowID As String, ByVal IsNew As Boolean, Optional ExtendedQuery As String = "") As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    If (IsNew) Then
                        V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[doc]]employeeactivity](employeeactivity_id, employeeactivity_areaaffected, " &
                                                            "employeeactivity_template, employeeactivity_datetime, employeeactivity_time, " &
                                                            "employeeactivity_datetime_end, employeeactivity_time_end, employeeactivity_description, " &
                                                            "employeeactivity_employee,employeeactivity_feedback,employeeactivity_createon) values " &
                                                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',(select usr.user_employee " &
                                                            "from dbo.[[sys]]user] usr where usr.user_id = '{8}'),'{9}', " &
                                                            "(select getdate()));", RowID, AreaAffected, ActivityTemplate, DatePart, TimePart, DatePartEnd, TimePartEnd, Content, UserID, Feedback)
                    Else
                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[doc]]employeeactivity] set employeeactivity_datetime = '{0}', " &
                                                            "employeeactivity_time = '{1}', employeeactivity_datetime_end = '{2}', " &
                                                            "employeeactivity_time_end = '{3}', employeeactivity_areaaffected = '{4}', " &
                                                            "employeeactivity_template = '{5}', employeeactivity_description = '{6}', " &
                                                            "employeeactivity_lastupdate = (select usr.user_employee from dbo.[[sys]]user] usr " &
                                                            "where usr.user_id = '{7}'), employeeactivity_feedback = '{9}', " &
                                                            "employeeactivity_updateon = (select getdate()) where employeeactivity_id = '{8}';", DatePart, TimePart, DatePartEnd, TimePartEnd, AreaAffected, ActivityTemplate, Content, UserID, RowID, Feedback)

                        V_DBR_MSSQL2008(1).Query += String.Format("update db_universe_erp_file.dbo.[[sto]]file] set file_parentdate = '{0}' " &
                                                             "where file_parent = '{1}';", DatePart, RowID)
                    End If

                    If ExtendedQuery IsNot String.Empty Then
                        V_DBR_MSSQL2008(1).Query += ExtendedQuery
                    End If

                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    If (IsNew) Then
                        V_DBR_MYSQL(1).Query = String.Format("insert into doc_employeeactivity(employeeactivity_id, employeeactivity_areaaffected, " &
                                                            "employeeactivity_template, employeeactivity_datetime, employeeactivity_time, " &
                                                            "employeeactivity_datetime_end, employeeactivity_time_end, employeeactivity_description, " &
                                                            "employeeactivity_employee,employeeactivity_feedback,employeeactivity_createon) values " &
                                                            "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',(select usr.user_employee " &
                                                            "from sys_user usr where usr.user_id = '{8}'),'{9}', " &
                                                            "(select curdate()));", RowID, AreaAffected, ActivityTemplate, DatePart, TimePart, DatePartEnd, TimePartEnd, Content, UserID, Feedback)
                    Else
                        V_DBR_MYSQL(1).Query = String.Format("update doc_employeeactivity set employeeactivity_datetime = '{0}', " &
                                                            "employeeactivity_time = '{1}', employeeactivity_datetime_end = '{2}', " &
                                                            "employeeactivity_time_end = '{3}', employeeactivity_areaaffected = '{4}', " &
                                                            "employeeactivity_template = '{5}', employeeactivity_description = '{6}', " &
                                                            "employeeactivity_lastupdate = (select usr.user_employee from sys_user usr " &
                                                            "where usr.user_id = '{7}'), employeeactivity_feedback = '{9}', " &
                                                            "employeeactivity_updateon = (select curdate()) where employeeactivity_id = '{8}';", DatePart, TimePart, DatePartEnd, TimePartEnd, AreaAffected, ActivityTemplate, Content, UserID, RowID, Feedback)

                        V_DBR_MYSQL(1).Query += String.Format("update sto_file set file_parentdate = '{0}' " &
                                                             "where file_parent = '{1}';", DatePart, RowID)
                    End If

                    If ExtendedQuery IsNot String.Empty Then
                        V_DBR_MYSQL(1).Query += ExtendedQuery
                    End If

                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHPhoto(ByVal DBEngine As String, ByVal FileGrid As dgn, ByVal RowID As String, ByVal IsNew As Boolean, ByVal ParentDate As Date) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    Dim V_CMD As SqlClient.SqlCommand
                    For Each Row As DataGridViewRow In FileGrid.Rows
                        If Row.Cells("photo_status").Value Is "Add" Then

                            Dim Query As String = String.Empty

                            V_CMD = New SqlClient.SqlCommand
                            Query = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, @FileName, 'jpg', @FileContent, '', @DateNow, " &
                            "'module=DAR;', @Uploader,@ParentDate);"

                            V_CMD.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY " &
                                                         "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 " &
                                                         "BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)

                            V_CMD.Parameters.AddWithValue("@ID", Row.Cells("photo_id").Value)
                            V_CMD.Parameters.AddWithValue("@ParentID", RowID)
                            V_CMD.Parameters.AddWithValue("@FileName", Row.Cells("photo_filename").Value)
                            V_CMD.Parameters.AddWithValue("@Uploader", Row.Cells("photo_uploader").Value)
                            V_CMD.Parameters.AddWithValue("@ParentDate", ParentDate)

                            Dim V_MemoryStream = New MemoryStream()
                            Dim V_Image As Image = CType(Row.Cells("photo_content").Value, Image)
                            Dim V_PhotoByte As Byte() = Nothing

                            V_Image.Save(V_MemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                            V_PhotoByte = V_MemoryStream.ToArray

                            Dim V_ImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            V_ImageParam.Value = V_PhotoByte
                            V_CMD.Parameters.Add(V_ImageParam)

                            V_CMD.Parameters.AddWithValue("@DateNow", Row.Cells("photo_datetime").Value)

                            V_Success = V_DBE_MSSQL2008.PUSHIMAGE(V_CMD)
                        End If
                    Next
                ElseIf DBEngine = "MYSQL" Then
                    Dim V_CMD As MySql.Data.MySqlClient.MySqlCommand
                    For Each Row As DataGridViewRow In FileGrid.Rows
                        If Row.Cells("photo_status").Value Is "Add" Then

                            Dim Query As String = String.Empty

                            V_CMD = New MySql.Data.MySqlClient.MySqlCommand
                            Query = "insert into sto_file([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, @FileName, 'jpg', @FileContent, '', @DateNow, " &
                            "'module=DAR;', @Uploader,@ParentDate);"

                            V_CMD.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY " &
                                                         "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 " &
                                                         "BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)

                            V_CMD.Parameters.AddWithValue("@ID", Row.Cells("photo_id").Value)
                            V_CMD.Parameters.AddWithValue("@ParentID", RowID)
                            V_CMD.Parameters.AddWithValue("@FileName", Row.Cells("photo_filename").Value)
                            V_CMD.Parameters.AddWithValue("@Uploader", Row.Cells("photo_uploader").Value)
                            V_CMD.Parameters.AddWithValue("@ParentDate", ParentDate)

                            Dim V_MemoryStream = New MemoryStream()
                            Dim V_Image As Image = CType(Row.Cells("photo_content").Value, Image)
                            Dim V_PhotoByte As Byte() = Nothing

                            V_Image.Save(V_MemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                            V_PhotoByte = V_MemoryStream.ToArray

                            Dim V_ImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            V_ImageParam.Value = V_PhotoByte
                            V_CMD.Parameters.Add(V_ImageParam)

                            V_CMD.Parameters.AddWithValue("@DateNow", Row.Cells("photo_datetime").Value)

                            V_Success = V_DBE_MYSQL.PUSHIMAGE(V_CMD)
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                V_Success = False
            End Try

            Return V_Success
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHFile(ByVal DBEngine As String, ByVal FileGrid As dgn, ByVal RowID As String, ByVal IsNew As Boolean, ByVal ParentDate As Date) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    Dim V_CMD As SqlClient.SqlCommand

                    For Each Row As DataGridViewRow In FileGrid.Rows
                        If Row.Cells("file_status").Value Is "Add" Then

                            Dim Query As String = String.Empty

                            V_CMD = New SqlClient.SqlCommand
                            Query = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader,file_parentdate) values(@ID, @ParentID, @FileName, 'pdf', @FileContent, @Tag, @DateNow, " &
                            "'module=DAR;', @Uploader, @ParentDate);"

                            V_CMD.CommandText = "RETRY: BEGIN TRANSACTION BEGIN TRY " & Query & " COMMIT TRANSACTION END TRY " &
                            "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH"

                            V_CMD.Parameters.AddWithValue("@ID", Row.Cells("file_id").Value)
                            V_CMD.Parameters.AddWithValue("@ParentID", RowID)
                            V_CMD.Parameters.AddWithValue("@FileName", Row.Cells("file_filename").Value)
                            V_CMD.Parameters.AddWithValue("@Uploader", Row.Cells("file_uploader").Value)
                            V_CMD.Parameters.AddWithValue("@Tag", Row.Cells("file_tag").Value)
                            V_CMD.Parameters.AddWithValue("@ParentDate", ParentDate)

                            Dim V_FileStream As FileStream = Nothing
                            V_FileStream = New FileStream(Row.Cells("file_content").Value.ToString, FileMode.Open, FileAccess.Read)

                            Dim V_MemoryStream = New MemoryStream()
                            V_FileStream.CopyTo(V_MemoryStream)

                            Dim V_FileByte As Byte() = Nothing
                            V_FileByte = V_MemoryStream.ToArray

                            Dim V_FileParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            V_FileParam.Value = V_FileByte
                            V_CMD.Parameters.Add(V_FileParam)

                            V_CMD.Parameters.AddWithValue("@DateNow", Row.Cells("file_datetime").Value)

                            V_Success = V_DBE_MSSQL2008.PUSHIMAGE(V_CMD)
                        End If
                    Next
                ElseIf DBEngine = "MYSQL" Then
                    Dim V_CMD As MySql.Data.MySqlClient.MySqlCommand

                    For Each Row As DataGridViewRow In FileGrid.Rows
                        If Row.Cells("file_status").Value Is "Add" Then

                            Dim Query As String = String.Empty

                            V_CMD = New MySql.Data.MySqlClient.MySqlCommand
                            Query = "insert into sto_file([file_id], file_parent, file_filename, file_filetype, file_content, file_tag, " &
                            "file_datetime, file_attribute, file_uploader,file_parentdate) values(@ID, @ParentID, @FileName, 'pdf', @FileContent, @Tag, @DateNow, " &
                            "'module=DAR;', @Uploader, @ParentDate);"

                            V_CMD.CommandText = "RETRY: BEGIN TRANSACTION BEGIN TRY " & Query & " COMMIT TRANSACTION END TRY " &
                            "BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH"

                            V_CMD.Parameters.AddWithValue("@ID", Row.Cells("file_id").Value)
                            V_CMD.Parameters.AddWithValue("@ParentID", RowID)
                            V_CMD.Parameters.AddWithValue("@FileName", Row.Cells("file_filename").Value)
                            V_CMD.Parameters.AddWithValue("@Uploader", Row.Cells("file_uploader").Value)
                            V_CMD.Parameters.AddWithValue("@Tag", Row.Cells("file_tag").Value)
                            V_CMD.Parameters.AddWithValue("@ParentDate", ParentDate)

                            Dim V_FileStream As FileStream = Nothing
                            V_FileStream = New FileStream(Row.Cells("file_content").Value.ToString, FileMode.Open, FileAccess.Read)

                            Dim V_MemoryStream = New MemoryStream()
                            V_FileStream.CopyTo(V_MemoryStream)

                            Dim V_FileByte As Byte() = Nothing
                            V_FileByte = V_MemoryStream.ToArray

                            Dim V_FileParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                            V_FileParam.Value = V_FileByte
                            V_CMD.Parameters.Add(V_FileParam)

                            V_CMD.Parameters.AddWithValue("@DateNow", Row.Cells("file_datetime").Value)

                            V_Success = V_DBE_MYSQL.PUSHIMAGE(V_CMD)
                        End If
                    Next
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
                V_Success = False
            End Try

            Return V_Success
        End Function

    End Class

    Public Class Reports
        Public Shared Sub DISPLAY(ByVal DBEngine As String, ByVal ChkFrom As chk, ByVal ChkTo As chk, ByVal ChkArea As chk, ByVal ChkActivity As chk, ByVal ChkBy As chk, ByVal DTPFrom As dtp, ByVal DTPTo As dtp, ByVal CboArea As cbo, ByVal CboActivity As cbo, ByVal CboBy As cbo, ByVal TxtDescription As txt, ByVal DataSetName As DataSet)

            Dim V_Where As String
            Dim V_DTPFrom As String = DTPFrom.Value.Year & "-" & DTPFrom.Value.Month & "-" & DTPFrom.Value.Day
            Dim V_DTPTo As String = DTPTo.Value.Year & "-" & DTPTo.Value.Month & "-" & DTPTo.Value.Day

            Try
                V_Where = "Where "

                If (ChkFrom.Checked) Then
                    If (ChkTo.Checked) Then
                        V_Where += String.Format("(ea.employeeactivity_datetime >= '{0}' and ea.employeeactivity_datetime <= '{1}')", V_DTPFrom, V_DTPTo)
                    Else
                        V_Where += String.Format("(ea.employeeactivity_datetime = '{0}')", V_DTPFrom)
                    End If
                End If

                If (ChkArea.Checked) Then
                    If V_Where = "Where " Then
                        V_Where += String.Format("(aa.areaaffected_id = '{0}')", CboArea.SelectedValue)
                    Else
                        V_Where += String.Format(" and (aa.areaaffected_id = '{0}')", CboArea.SelectedValue)
                    End If
                End If

                If (ChkActivity.Checked) Then
                    If V_Where = "Where " Then
                        V_Where += String.Format("(ea.employeeactivity_template = '{0}')", CboActivity.SelectedValue)
                    Else
                        V_Where += String.Format(" and (ea.employeeactivity_template = '{0}')", CboActivity.SelectedValue)
                    End If
                End If

                If (ChkBy.Checked) Then
                    If V_Where = "Where " Then
                        V_Where += String.Format("(ea.employeeactivity_employee = '{0}')", CboBy.SelectedValue)
                    Else
                        V_Where += String.Format(" and (ea.employeeactivity_employee = '{0}')", CboBy.SelectedValue)
                    End If
                End If

                If TxtDescription.XOSQLText.Trim <> String.Empty Then

                    If V_Where <> "Where " Then
                        V_Where += String.Format(" and ")
                    End If

                    'multiple keywords execution
                    If Not (TxtDescription.XOSQLText.Trim.Contains("||")) Then
                        V_Where += String.Format("(ea.employeeactivity_description like '%{0}%') ", TxtDescription.XOSQLText)
                    Else
                        Dim V_ContainText As String() = TxtDescription.XOSQLText.Split("||")
                        Dim V_Repeater As Integer = 0

                        V_Where += String.Format("(")

                        For Each V_Text As String In V_ContainText
                            If V_Text <> "" Then

                                V_Text.Trim()

                                If V_Repeater = 0 Then
                                    V_Where += String.Format("ea.employeeactivity_description like '%{0}%'", V_Text)
                                Else
                                    V_Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", V_Text)
                                End If
                            End If

                            V_Repeater += 1
                        Next

                        V_Where += String.Format(")")
                    End If
                End If

                If V_Where = "Where " Then
                    V_Where = String.Empty
                End If

                DataSetName.Clear()

                Dim V_TimeFormat(2) As String

                If DBEngine = "MSSQL" Then
                    'same day with different time
                    V_TimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8))) as [employeeactivity_time]")

                    'same day with time range format & different day format
                    V_TimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
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

                    Dim V_Description As String = "case when (ea.employeeactivity_feedback is null) or " &
                    "(convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else " &
                    "convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' " &
                    "+ char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                    V_DBR_MSSQL2008(0).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) " &
                                                        "and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                        "(convert(varchar(max),e.employee_nickname) + ' / ' + " &
                                                        "convert(varchar(max),(select em.employee_nickname from dbo.[[man]]employee] em " &
                                                        "where em.employee_id = ea.employeeactivity_lastupdate))) else " &
                                                        "e.employee_nickname end as [employee_nickname], aa.areaaffected_order " &
                                                        "from dbo.[[doc]]employeeactivity] ea " &
                                                        "inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                        "inner join dbo.[[man]]employee] e on ea.employeeactivity_employee = e.employee_id {0} " &
                                                        "order by aa.areaaffected_order", V_Where, V_TimeFormat(2), V_Description)

                    DataSetName = V_DBE_MSSQL2008.FILLDATASET(V_DBR_MSSQL2008(0).Query, DataSetName, "employeeactivity")
                ElseIf DBEngine = "MYSQL" Then
                    'same day with different time
                    V_TimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + " &
                                               "cast(ea.employeeactivity_time_end as varchar(8))) as `employeeactivity_time`")

                    'same day with time range format & different day format
                    V_TimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and " &
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

                    Dim V_Description As String = "case when (ea.employeeactivity_feedback is null) or " &
                    "(convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else " &
                    "convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' " &
                    "+ char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                    V_DBR_MYSQL(0).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) " &
                                                        "and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then " &
                                                        "(convert(varchar(max),e.employee_nickname) + ' / ' + " &
                                                        "convert(varchar(max),(select em.employee_nickname from dbo.[[man]]employee] em " &
                                                        "where em.employee_id = ea.employeeactivity_lastupdate))) else " &
                                                        "e.employee_nickname end as [employee_nickname], aa.areaaffected_order " &
                                                        "from doc_employeeactivity ea " &
                                                        "inner join doc_areaaffected aa on ea.employeeactivity_areaaffected = aa.areaaffected_id " &
                                                        "inner join man_employee e on ea.employeeactivity_employee = e.employee_id {0} " &
                                                        "order by aa.areaaffected_order", V_Where, V_TimeFormat(2), V_Description)

                    DataSetName = V_DBE_MYSQL.FILLDATASET(V_DBR_MYSQL(0).Query, DataSetName, "employeeactivity")
                End If
            Catch ex As Exception
                DataSetName = Nothing
            End Try
        End Sub
    End Class
End Namespace
