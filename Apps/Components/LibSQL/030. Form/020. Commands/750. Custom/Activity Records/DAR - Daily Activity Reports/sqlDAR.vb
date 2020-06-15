Imports CMCv
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Namespace Commands.DAR
    Public Class View
        'reDim _DBR_MSSQL2008(3)
        Public _IsEmpFilter As Boolean
        Public _EID As String
        Public _ContentID As String

        Public Function CheckSettings(ByVal UID As String, ByVal Attribute As String) As Boolean
            Dim _IsExist As Integer = 0
            Dim _Attribute(1) As String

            _Attribute(0) = "ViewPhotoTab"

            For _Row = 0 To 0
                _DBR_MSSQL2008(0).Query = String.Format("select count(mods.modulesettings_id) from dbo.[[sys]]modulesettings] mods inner join dbo.[[sys]]module] mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, _Attribute(_Row))
                _IsExist = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                If _IsExist = 0 Then
                    _DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]modulesettings](modulesettings_id, modulesettings_module, modulesettings_user, modulesettings_attribute, modulesettings_value) values('{0}',(select mo.module_id from dbo.[[sys]]module] mo where mo.module_code = 'DAR'),'{1}','{2}','False')", _SECEncrypt.MD5(), UID, _Attribute(_Row))
                    _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                End If
            Next

            Dim _Value As Object = Nothing

            _DBR_MSSQL2008(0).Query = String.Format("select mods.modulesettings_value from dbo.[[sys]]modulesettings] mods inner join dbo.[[sys]]module] mo on mo.module_id = mods.modulesettings_module where (mo.module_code = 'DAR') and (mods.modulesettings_user = '{0}') and (mods.modulesettings_attribute = '{1}')", UID, "ViewPhotoTab")

            _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _Value
        End Function

        Public Function SaveSettings(ByVal UID As String, ByVal Attribute As String, ByVal Values As String) As Boolean
            Dim _IsSuccess As Boolean = False
            Try
                _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]modulesettings] set modulesettings_value = '{0}' where (modulesettings_module = (select mo.module_id from dbo.[[sys]]module] mo where mo.module_code = 'DAR')) and (modulesettings_user = '{1}') and (modulesettings_attribute = '{2}')", Values, UID, Attribute)

                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)

                _IsSuccess = True
            Catch ex As Exception
                _IsSuccess = False
            End Try

            Return _IsSuccess

        End Function

        Public Sub FillEmployee(ByVal Employee As cbo)
            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_id, em.employee_fullname from dbo.[[man]]employee] em where em.employee_id in (select ea.employeeactivity_employee from dbo.[[doc]]employeeactivity] ea group by ea.employeeactivity_employee) order by em.employee_fullname;")
            _DBR_MSSQL2008(1).Dropdown = Employee
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TEmployee")
            Employee.DisplayMember = "employee_fullname"
            Employee.ValueMember = "employee_id"
        End Sub

        Public Sub DisplayMainGrid(ByVal Find As txt, ByVal DateGrid As dgn, ByVal DateStatusBar As stt, ContentStatusBar As stt, ByVal chkDateFilter As chk, ByVal dtpDateFilter As dtp, ByVal chkByFilter As chk, ByVal cboByFilter As cbo, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim _Where As String = String.Format("where ")

                If cboByFilter.Items.Count = 0 Then
                    _EID = "-1"
                Else
                    _EID = cboByFilter.SelectedValue()
                End If

                If (Find.SLFSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                    If chkDateFilter.Checked = False Then
                        _Where += String.Format("(year(ea.employeeactivity_datetime) = year(getdate())) and (month(ea.employeeactivity_datetime) = month(getdate()))")
                    Else
                        _Where += String.Format("(year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                    End If

                    If chkByFilter.Checked = True Then
                        _Where += String.Format(" and (ea.employeeactivity_employee = '{0}')", _EID)
                    End If
                Else
                    If Find.SLFSQLText.Trim.Contains("||") = False Then
                        _Where += String.Format("(ea.employeeactivity_description like '%{0}%')", Find.SLFSQLText)
                    Else
                        Dim _ContainText() As String = Find.SLFSQLText.Split("||")
                        Dim _Repeater As Integer = 0

                        _Where += String.Format("(")

                        For Each _Text As String In _ContainText
                            If Not _Text = "" Then
                                If _Repeater = 0 Then
                                    _Where += String.Format("ea.employeeactivity_description like '%{0}%'", _Text)
                                Else
                                    _Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", _Text)
                                End If
                            End If

                            _Repeater += 1
                        Next

                        _Where += String.Format(")")
                    End If

                    If chkDateFilter.Checked = True Then
                        _Where += String.Format(" and (year(ea.employeeactivity_datetime) = {0} and month(ea.employeeactivity_datetime) = {1})", dtpDateFilter.Value.Year, dtpDateFilter.Value.Month)
                    End If

                    If chkByFilter.Checked = True Then
                        _Where += String.Format(" and (ea.employeeactivity_employee = '{0}')", _EID)
                    End If
                End If

                _DBR_MSSQL2008(0).Query = String.Format("select ea.employeeactivity_datetime, (convert(varchar,ea.employeeactivity_datetime,106) + '' + char(13) + char(10) + '' + left(datename(dw,ea.employeeactivity_datetime),3)) as [employeeactivity_longdate] from dbo.[[doc]]employeeactivity] ea {0} group by ea.employeeactivity_datetime order by ea.employeeactivity_datetime desc", _Where)

                _DBR_MSSQL2008(0).DataGrid = DateGrid
                _DBR_MSSQL2008(0).StatusBar = DateStatusBar
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TDailyReportsDate")

                _IsEmpFilter = chkByFilter.Checked

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub DisplaySecondGrid(ByVal DateGrid As String, ByVal ContentGrid As dgn, ByVal ContentStatusBar As stt, ByVal Find As txt, Optional ByVal ShowAttachment As Boolean = False, Optional ByVal PhotoGrid As dgn = Nothing, Optional ByVal FileGrid As dgn = Nothing)
            Try
                ReDim _DBR_MSSQL2008(3)
                'Dim _CONTENTDATE As Date
                Dim _CONTENTDATE_S As String
                Dim _Where As String = "where "

                _CONTENTDATE_S = DateGrid

                'If DateGrid.Rows.Count = 0 Then
                '    'contentdate = Now.AddYears(2)
                '    _CONTENTDATE_S = "9999-12-31"
                'Else
                '    _CONTENTDATE = DateGrid.CurrentRow.Cells("employeeactivity_datetime").Value
                '    _CONTENTDATE_S = _CONTENTDATE.Year & "-" & _CONTENTDATE.Month & "-" & _CONTENTDATE.Day
                'End If

                'add date query-cut
                _Where += String.Format(" (ea.employeeactivity_datetime = '{0}')", _CONTENTDATE_S)

                'add text query-cut
                If Not (Find.SLFSQLText = String.Empty) Then
                    _Where += String.Format(" and ")

                    'multiple keywords execution
                    If Find.SLFSQLText.Trim.Contains("||") = False Then
                        _Where += String.Format("(ea.employeeactivity_description like '%{0}%') ", Find.SLFSQLText)
                    Else
                        Dim _ContainText() As String = Find.SLFSQLText.Split("||")
                        Dim _Repeater As Integer = 0

                        _Where += String.Format("(")

                        For Each _Text As String In _ContainText
                            If Not _Text = "" Then

                                _Text.Trim()

                                If _Repeater = 0 Then
                                    _Where += String.Format("ea.employeeactivity_description like '%{0}%'", _Text)
                                Else
                                    _Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", _Text)
                                End If
                            End If

                            _Repeater += 1
                        Next

                        _Where += String.Format(")")
                    End If
                End If

                'add employee filter query-cut
                If _IsEmpFilter = True Then
                    _Where += String.Format(" and (ea.employeeactivity_employee = '{0}') ", _EID)
                End If

                Dim _TimeFormat(2) As String

                'same day with different time
                _TimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) as [employeeactivity_time]")

                'same day with time range format & different day format
                _TimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and (ea.employeeactivity_time_end = ea.employeeactivity_time)) then (cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + cast(ea.employeeactivity_time as varchar(8)) when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and (ea.employeeactivity_time_end > ea.employeeactivity_time)) then  (cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + (cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then (cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + (cast(ea.employeeactivity_time as varchar(8))) + char(13) + char(10) + ' to ' + char(13) + char(10) + (cast(ea.employeeactivity_datetime_end as varchar(10))) + ' ' + cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                Dim _Description As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                _DBR_MSSQL2008(2).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then (convert(varchar(max),e.employee_nickname) + ' / ' + convert(varchar(max),(select em.employee_nickname from dbo.[[man]]employee] em where em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as [employee_nickname], e.employee_id, ea.employeeactivity_id from dbo.[[doc]]employeeactivity] ea inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id inner join dbo.[[man]]employee] e on ea.employeeactivity_employee = e.employee_id {0} order by aa.areaaffected_order, ea.employeeactivity_time", _Where, _TimeFormat(2), _Description)


                _DBR_MSSQL2008(2).DataGrid = ContentGrid
                _DBR_MSSQL2008(2).StatusBar = ContentStatusBar
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(2), "TDailyActivity")

                If _DBR_MSSQL2008(2).DataGrid Is Nothing Then
                    _DBR_MSSQL2008(2).DataGrid = ContentGrid
                    _DBR_MSSQL2008(2).StatusBar = ContentStatusBar
                End If

                If (PhotoGrid Is Nothing) And (FileGrid Is Nothing) Then
                    Exit Sub
                End If

                If ShowAttachment = True Then
                    If _DBR_MSSQL2008(2).DataGrid.RowCount = 0 Then
                        _ContentID = "-1"
                    Else
                        _ContentID = _DBR_MSSQL2008(2).DataGrid.CurrentRow.Cells("employeeactivity_id").Value
                    End If
                    Call DisplayPhotoGrid(_ContentID, PhotoGrid)
                    Call DisplayFileGrid(_ContentID, FileGrid)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub DisplayPhotoGrid(ByVal ContentID As String, ByVal FileGrid As dgn)
            ReDim _DBR_MSSQL2008(5)
            Dim _CONTENTID As String = ContentID

            _DBR_MSSQL2008(4).Query = String.Format("select fi.file_id, fi.file_content, (convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], '' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and fi.file_filetype = 'jpg') order by fi.file_score desc, fi.file_datetime;", _CONTENTID)
            _DBR_MSSQL2008(4).DataGrid = FileGrid
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(4), "TPhotoFile")
        End Sub

        Public Sub DisplayFileGrid(ByVal ContentID As String, ByVal FileGrid As dgn)
            ReDim _DBR_MSSQL2008(6)
            Dim _CONTENTID As String = ContentID

            _DBR_MSSQL2008(5).Query = String.Format("select fi.file_id, fi.file_tag, '' as [file_content], (convert(varchar(25),fi.file_content_size) + ' KB') as [file_content_size], (convert(varchar(3),fi.file_score) + ' like(s)') as [file_score], fi.file_datetime, fi.file_uploader, (select em.employee_fullname from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_fullname], (select em.employee_nickname from dbo.[[man]]employee] em where em.employee_id = fi.file_uploader) as [employee_nickname], '' as [file_view] from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and fi.file_filetype = 'pdf') order by fi.file_datetime;", _CONTENTID)
            _DBR_MSSQL2008(5).DataGrid = FileGrid
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(5), "TFile")
        End Sub

        Public Function GETPDFFile(ByVal RowID As String) As Object
            Dim _File As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select fi.file_content from db_universe_erp_file.dbo.[[sto]]file] fi where fi.file_id = '{0}'", RowID)

            _File = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            Return _File
        End Function

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function

        Public Function IsLike(ByVal FileID As String, EID As String) As Boolean
            Dim _Result As Integer = Nothing
            Try
                _DBR_MSSQL2008(1).Query = String.Format("select count(ff.filefeedback_id) as [islike] from db_universe_erp_file.dbo.[[sto]]filefeedback] ff where ff.filefeedback_file = '{0}' and ff.filefeedback_employee = '{1}';", FileID, EID)
                _Result = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            Catch ex As Exception
                _Result = 0
            End Try

            If _Result = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function LikePhoto(ByVal FileID As String, ByVal EID As String, ByVal FileOwner As String) As Boolean
            Dim _Success As Boolean = False

            Try
                _DBR_MSSQL2008(1).Query = String.Format("insert into db_universe_erp_file.dbo.[[sto]]filefeedback](filefeedback_datetime, filefeedback_file, filefeedback_employee, filefeedback_type, filefeedback_value, filefeedback_text) values(GETDATE(), '{0}', '{1}', 'Like', 1, 'N/A'); insert into dbo.[[sys]]notification](notification_datetime, notification_employee, notification_message, notification_isread) values(GETDATE(), '{2}', (select em.employee_fullname from dbo.[[man]]employee] em where em.employee_id = '{1}') + ' like one of your photo.', 0);update db_universe_erp_file.dbo.[[sto]]file] set file_score = (select count(ff.filefeedback_value) from db_universe_erp_file.dbo.[[sto]]filefeedback] ff where (ff.filefeedback_file = '{0}') and (ff.filefeedback_type = 'Like')) where (file_id = '{0}');", FileID, EID, FileOwner)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class

    Public Class Editor
        Private _DS As DataSet

        Public Sub GETAffectedArea(ByVal ListOfAffectedArea As CMCv.cbo)
            _DBR_MSSQL2008(1).Query = "select aa.areaaffected_id, aa.areaaffected_name from dbo.[[doc]]areaaffected] aa order by aa.areaaffected_order"
            _DBR_MSSQL2008(1).Dropdown = ListOfAffectedArea
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TAffectedArea")
            ListOfAffectedArea.DisplayMember = "areaaffected_name"
            ListOfAffectedArea.ValueMember = "areaaffected_id"
        End Sub

        Public Sub GETTemplateTitle(ByVal ListOfTemplate As CMCv.cbo)

            _DBR_MSSQL2008(1).Query = "select tp.template_id, tp.template_title from dbo.[[doc]]template] tp inner join dbo.[[sys]]module] mo on mo.module_id = tp.template_module where mo.module_code = 'DAR' order by tp.template_title"
            _DBR_MSSQL2008(1).Dropdown = ListOfTemplate
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TTemplate")
            ListOfTemplate.DisplayMember = "template_title"
            ListOfTemplate.ValueMember = "template_id"
        End Sub

        Public Function GETTemplateContent(ByVal ListOfTemplate As CMCv.cbo) As String
            _DBR_MSSQL2008(1).Query = String.Format("select tp.template_text1 from dbo.[[doc]]template] tp where tp.template_id = '{0}'", ListOfTemplate.SelectedValue)
            Return _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
        End Function

        Public Sub GETRowValue(ByVal RowID As String, ByVal DatePart As CMCv.dtp, ByVal TimePart As CMCv.meb, ByVal DatePartEnd As CMCv.dtp, ByVal TimePartEnd As CMCv.meb, ByVal ListOfAffectedArea As cbo, ByVal ListOfTemplate As cbo, ByVal TemplateContent As CMCv.txt, ByVal FeedBack As CMCv.txt)
            Dim _DatePart(3) As String
            Dim _TimeParts(1) As TimeSpan
            Dim _TimePart(3) As String


            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_datetime from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)
            _DatePart(0) = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_time from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)

            _TimeParts(0) = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _DatePart(2) = Convert.ToString(_TimeParts(0))
            _TimePart = _DatePart(2).Split(":")
            _DatePart(1) = _TimePart(0) + ":" + _TimePart(1)

            DatePart.Value = Convert.ToDateTime(_DatePart(0))
            TimePart.Text = _DatePart(1)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_datetime_end from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)
            _DatePart(0) = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_time_end from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)
            _TimeParts(0) = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            _DatePart(2) = Convert.ToString(_TimeParts(0))
            _TimePart = _DatePart(2).Split(":")
            _DatePart(1) = _TimePart(0) + ":" + _TimePart(1)

            DatePartEnd.Value = Convert.ToDateTime(_DatePart(0))
            TimePartEnd.Text = _DatePart(1)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_areaaffected from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)
            ListOfAffectedArea.SelectedValue = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_template from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)
            ListOfTemplate.SelectedValue = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_description from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)
            TemplateContent.Text = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            _DBR_MSSQL2008(1).Query = String.Format("select ea.employeeactivity_feedback from dbo.[[doc]]employeeactivity] ea where ea.employeeactivity_id = '{0}'", RowID)

            Dim _Feedback As Object = Nothing
            _Feedback = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            FeedBack.Text = IIf(IsDBNull(_Feedback), "", _Feedback)
        End Sub

        Public Function DisplayPhotoGrid(ByVal RowID As String, ByVal FileGrid As dgn) As DataSet
            _DS = New DataSet
            'ReDim _DBR_MSSQL2008(3)
            _DBR_MSSQL2008(2).Query = String.Format("select fi.file_id, fi.file_content, fi.file_datetime, fi.file_uploader from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and fi.file_filetype = 'jpg') order by fi.file_datetime;", RowID)

            _DS = _DBE_MSSQL2008.GETDATASET(_DBR_MSSQL2008(2), "TPhotoFileEditor")

            Return _DS

            '_DBR_MSSQL2008(2).DataGrid = FileGrid
            '_DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(2), "TPhotoFileEditor")
        End Function

        Public Function DisplayFileGrid(ByVal RowID As String, ByVal FileGrid As dgn) As DataSet
            _DS = New DataSet
            'ReDim _DBR_MSSQL2008(3)
            _DBR_MSSQL2008(2).Query = String.Format("select fi.file_id, fi.file_tag, fi.file_content, fi.file_datetime, fi.file_uploader from db_universe_erp_file.dbo.[[sto]]file] fi where (fi.file_parent = '{0}' and fi.file_filetype = 'pdf') order by fi.file_datetime;", RowID)

            _DS = _DBE_MSSQL2008.GETDATASET(_DBR_MSSQL2008(2), "TFileEditor")

            Return _DS

            '_DBR_MSSQL2008(2).DataGrid = FileGrid
            '_DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(2), "TPhotoFileEditor")
        End Function

        Public Function PUSHData(ByVal AreaAffected As String, ByVal ActivityTemplate As String, ByVal DatePart As String, ByVal TimePart As String, ByVal DatePartEnd As String, ByVal TimePartEnd As String, ByVal Content As String, ByVal Feedback As String, ByVal UserID As String, ByVal RowID As String, ByVal IsNew As Boolean, Optional ExtendedQuery As String = "")
            Dim _Success As Boolean = False

            Try
                If IsNew = True Then
                    _DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[doc]]employeeactivity](employeeactivity_id, employeeactivity_areaaffected, employeeactivity_template, employeeactivity_datetime, employeeactivity_time, employeeactivity_datetime_end, employeeactivity_time_end, employeeactivity_description,employeeactivity_employee,employeeactivity_feedback,employeeactivity_createon) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',(select usr.user_employee from dbo.[[sys]]user] usr where usr.user_id = '{8}'),'{9}',(select getdate()));", RowID, AreaAffected, ActivityTemplate, DatePart, TimePart, DatePartEnd, TimePartEnd, Content, UserID, Feedback)
                Else
                    _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[doc]]employeeactivity] set employeeactivity_datetime = '{0}', employeeactivity_time = '{1}', employeeactivity_datetime_end = '{2}', employeeactivity_time_end = '{3}', employeeactivity_areaaffected = '{4}', employeeactivity_template = '{5}', employeeactivity_description = '{6}', employeeactivity_lastupdate = (select usr.user_employee from dbo.[[sys]]user] usr where usr.user_id = '{7}'), employeeactivity_feedback = '{9}',employeeactivity_updateon = (select getdate()) where employeeactivity_id = '{8}';", DatePart, TimePart, DatePartEnd, TimePartEnd, AreaAffected, ActivityTemplate, Content, UserID, RowID, Feedback)

                    '--update dbo.[[doc]]employeeactivity] set employeeactivity_datetime_end = employeeactivity_datetime, employeeactivity_time_end = employeeactivity_time where (employeeactivity_datetime_end is null and employeeactivity_time_end is null);

                    _DBR_MSSQL2008(1).Query += String.Format("update db_universe_erp_file.dbo.[[sto]]file] set file_parentdate = '{0}' where file_parent = '{1}';", DatePart, RowID)
                End If

                If ExtendedQuery IsNot String.Empty Then
                    _DBR_MSSQL2008(1).Query += ExtendedQuery
                End If

                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function

        Public Function PUSHPhoto(ByVal FileGrid As dgn, ByVal RowID As String, ByVal IsNew As Boolean, ByVal ParentDate As Date) As Boolean
            Dim _Success As Boolean = False
            Dim _CMD As SqlClient.SqlCommand = Nothing

            Try
                For Each Row As DataGridViewRow In FileGrid.Rows
                    If Row.Cells("photo_status").Value = "Add" Then

                        Dim Query As String = String.Empty

                        _CMD = New SqlClient.SqlCommand
                        Query = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filetype, file_content, file_tag, file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, 'jpg', @FileContent, '', @DateNow, 'module=DAR;', @Uploader,@ParentDate);"

                        _CMD.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", Query)

                        _CMD.Parameters.AddWithValue("@ID", Row.Cells("photo_id").Value)
                        _CMD.Parameters.AddWithValue("@ParentID", RowID)
                        _CMD.Parameters.AddWithValue("@Uploader", Row.Cells("photo_uploader").Value)
                        _CMD.Parameters.AddWithValue("@ParentDate", ParentDate)

                        Dim _MemoryStream = New MemoryStream()
                        Dim _Image As Image = Row.Cells("photo_content").Value
                        Dim _PhotoByte As Byte() = Nothing

                        _Image.Save(_MemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                        _PhotoByte = _MemoryStream.ToArray

                        Dim _ImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                        _ImageParam.Value = _PhotoByte
                        _CMD.Parameters.Add(_ImageParam)

                        _CMD.Parameters.AddWithValue("@DateNow", Row.Cells("photo_datetime").Value)

                        _Success = _DBE_MSSQL2008.PUSHIMAGE(_CMD)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
                _Success = False
            End Try

            Return _Success
        End Function

        Public Function PUSHFile(ByVal FileGrid As dgn, ByVal RowID As String, ByVal IsNew As Boolean, ByVal ParentDate As Date) As Boolean
            Dim _Success As Boolean = False
            Dim _CMD As SqlClient.SqlCommand = Nothing

            Try
                For Each Row As DataGridViewRow In FileGrid.Rows
                    If Row.Cells("file_status").Value = "Add" Then

                        Dim Query As String = String.Empty

                        _CMD = New SqlClient.SqlCommand
                        Query = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filetype, file_content, file_tag, file_datetime, file_attribute, file_uploader,file_parentdate) values(@ID, @ParentID, 'pdf', @FileContent, @Tag, @DateNow, 'module=DAR;', @Uploader, @ParentDate);"

                        _CMD.CommandText = "RETRY: BEGIN TRANSACTION BEGIN TRY " & Query & " COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH"
                        _CMD.Parameters.AddWithValue("@ID", Row.Cells("file_id").Value)
                        _CMD.Parameters.AddWithValue("@ParentID", RowID)
                        _CMD.Parameters.AddWithValue("@Uploader", Row.Cells("file_uploader").Value)
                        _CMD.Parameters.AddWithValue("@Tag", Row.Cells("file_tag").Value)
                        _CMD.Parameters.AddWithValue("@ParentDate", ParentDate)

                        Dim _FileStream As FileStream = Nothing
                        _FileStream = New FileStream(Row.Cells("file_content").Value, FileMode.Open, FileAccess.Read)

                        Dim _MemoryStream = New MemoryStream()
                        _FileStream.CopyTo(_MemoryStream)

                        Dim _FileByte As Byte() = Nothing
                        _FileByte = _MemoryStream.ToArray

                        Dim _FileParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                        _FileParam.Value = _FileByte
                        _CMD.Parameters.Add(_FileParam)

                        _CMD.Parameters.AddWithValue("@DateNow", Row.Cells("file_datetime").Value)

                        _Success = _DBE_MSSQL2008.PUSHIMAGE(_CMD)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.ToString)
                _Success = False
            End Try

            Return _Success
        End Function

    End Class

    Public Class Reports
        Public Sub Display(ByVal ChkFrom As chk, ByVal ChkTo As chk, ByVal ChkArea As chk, ByVal ChkActivity As chk, ByVal ChkBy As chk, ByVal DTPFrom As dtp, ByVal DTPTo As dtp, ByVal CboArea As cbo, ByVal CboActivity As cbo, ByVal CboBy As cbo, ByVal TxtDescription As txt, ByVal DataSetName As DataSet)

            Dim _Where As String = String.Empty
            Dim _DTPFrom As String = DTPFrom.Value.Year & "-" & DTPFrom.Value.Month & "-" & DTPFrom.Value.Day
            Dim _DTPTo As String = DTPTo.Value.Year & "-" & DTPTo.Value.Month & "-" & DTPTo.Value.Day

            Try
                _Where = "Where "

                If ChkFrom.Checked = True Then
                    If ChkTo.Checked = True Then
                        _Where += String.Format("(ea.employeeactivity_datetime >= '{0}' and ea.employeeactivity_datetime <= '{1}')", _DTPFrom, _DTPTo)
                    Else
                        _Where += String.Format("(ea.employeeactivity_datetime = '{0}')", _DTPFrom)
                    End If
                End If

                If ChkArea.Checked = True Then
                    If _Where = "Where " Then
                        _Where += String.Format("(aa.areaaffected_id = '{0}')", CboArea.SelectedValue)
                    Else
                        _Where += String.Format(" and (aa.areaaffected_id = '{0}')", CboArea.SelectedValue)
                    End If
                End If

                If ChkActivity.Checked = True Then
                    If _Where = "Where " Then
                        _Where += String.Format("(ea.employeeactivity_template = '{0}')", CboActivity.SelectedValue)
                    Else
                        _Where += String.Format(" and (ea.employeeactivity_template = '{0}')", CboActivity.SelectedValue)
                    End If
                End If

                If ChkBy.Checked = True Then
                    If _Where = "Where " Then
                        _Where += String.Format("(ea.employeeactivity_employee = '{0}')", CboBy.SelectedValue)
                    Else
                        _Where += String.Format(" and (ea.employeeactivity_employee = '{0}')", CboBy.SelectedValue)
                    End If
                End If

                If Not TxtDescription.SLFSQLText.Trim = String.Empty Then

                    If Not _Where = "Where " Then
                        _Where += String.Format(" and ")
                    End If

                    'multiple keywords execution
                    If TxtDescription.SLFSQLText.Trim.Contains("||") = False Then
                        _Where += String.Format("(ea.employeeactivity_description like '%{0}%') ", TxtDescription.SLFSQLText)
                    Else
                        Dim _ContainText() As String = TxtDescription.SLFSQLText.Split("||")
                        Dim _Repeater As Integer = 0

                        _Where += String.Format("(")

                        For Each _Text As String In _ContainText
                            If Not _Text = "" Then

                                _Text.Trim()

                                If _Repeater = 0 Then
                                    _Where += String.Format("ea.employeeactivity_description like '%{0}%'", _Text)
                                Else
                                    _Where += String.Format(" and ea.employeeactivity_description like '%{0}%'", _Text)
                                End If
                            End If

                            _Repeater += 1
                        Next

                        _Where += String.Format(")")
                    End If
                End If

                If _Where = "Where " Then
                    _Where = String.Empty
                End If

                DataSetName.Clear()

                Dim _TimeFormat(2) As String

                'same day with different time
                _TimeFormat(1) = String.Format("(cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) as [employeeactivity_time]")

                'same day with time range format & different day format
                _TimeFormat(2) = String.Format("(case when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and (ea.employeeactivity_time_end = ea.employeeactivity_time)) then (cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + cast(ea.employeeactivity_time as varchar(8)) when ((ea.employeeactivity_datetime_end = ea.employeeactivity_datetime) and (ea.employeeactivity_time_end > ea.employeeactivity_time)) then  (cast(ea.employeeactivity_datetime as varchar(10))) + char(13) + char(10) + (cast(ea.employeeactivity_time as varchar(8)) + ' - ' + cast(ea.employeeactivity_time_end as varchar(8))) when (ea.employeeactivity_datetime_end > ea.employeeactivity_datetime) then (cast(ea.employeeactivity_datetime as varchar(10))) + ' ' + (cast(ea.employeeactivity_time as varchar(8))) + char(13) + char(10) + ' to ' + char(13) + char(10) + (cast(ea.employeeactivity_datetime_end as varchar(10))) + ' ' + cast(ea.employeeactivity_time_end as varchar(8)) end) as [employeeactivity_time]")

                Dim _Description As String = "case when (ea.employeeactivity_feedback is null) or (convert(varchar(max),ea.employeeactivity_feedback) = '') then employeeactivity_description else convert(varchar(max),employeeactivity_description) + char(13) + char(10) + char(13) + char(10) + '--- Feedback Note : ---' + char(13) + char(10) + convert(varchar(max),ea.employeeactivity_feedback) end as [employeeactivity_description]"

                _DBR_MSSQL2008(0).Query = String.Format("select aa.areaaffected_name, {1}, {2}, case when (ea.employeeactivity_lastupdate is not null) and (ea.employeeactivity_employee <> ea.employeeactivity_lastupdate) then (convert(varchar(max),e.employee_nickname) + ' / ' + convert(varchar(max),(select em.employee_nickname from dbo.[[man]]employee] em where em.employee_id = ea.employeeactivity_lastupdate))) else e.employee_nickname end as [employee_nickname], aa.areaaffected_order from dbo.[[doc]]employeeactivity] ea inner join dbo.[[doc]]areaaffected] aa on ea.employeeactivity_areaaffected = aa.areaaffected_id inner join dbo.[[man]]employee] e on ea.employeeactivity_employee = e.employee_id {0} order by aa.areaaffected_order", _Where, _TimeFormat(2), _Description)

                DataSetName = _DBE_MSSQL2008.FILLDATASET(_DBR_MSSQL2008(0).Query, DataSetName, "employeeactivity")

            Catch ex As Exception
                DataSetName = Nothing
            End Try
        End Sub
    End Class
End Namespace
