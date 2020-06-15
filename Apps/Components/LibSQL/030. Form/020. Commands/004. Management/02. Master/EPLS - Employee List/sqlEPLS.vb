Imports CMCv
Imports System.IO
Imports System.Drawing

Namespace Commands.EPLS
    Public Class View

        Public Sub DisplayData(ByVal Grid As dgn, ByVal Status As CMCv.stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            ReDim _DBR_MSSQL2008(2)
            Dim _Where As String = String.Format("where ")

            If (Find.Text = String.Empty) And (ForceRefresh = True) Then
                _Where = String.Format("")
            Else
                _Where += String.Format("cm.company_code like '%{0}%' or dp.departement_code like '%{0}%' or ps.position_code like '%{0}%' or em.employee_number = '{0}' or em.employee_fullname like '%{0}%' or em.employee_nickname like '%{0}%'", Find.SLFSQLText)
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, (select gd.employeegrade_code from dbo.[[man]]employeegrade] gd where gd.employeegrade_id = em.employee_grade) as [employee_grade], em.employee_number, em.employee_fullname, em.employee_nickname, (select ct.contracttype_code from dbo.[[man]]contracttype] ct where ct.contracttype_id = em.employee_contracttype) as [employee_contracttype], employee_gender, (case em.employee_active when 0 then 'No' when 1 then 'Yes' end) as [employee_active] from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company {0} order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname", _Where)

            _DBR_MSSQL2008(0).DataGrid = Grid
            _DBR_MSSQL2008(0).StatusBar = Status
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TEmployee")
        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[man]]employee] where (employee_id = '{0}')", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)

                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function
    End Class

    Public Class Editor
        Private _IMG As New CMCv.ImageEditor.Proccessor.Compress

        Public Function GETCompany(ByVal RowID As String, Optional ByVal PositionID As String = "-1") As String
            Dim _Company As String = String.Empty

            If PositionID = "-1" Then
                _DBR_MSSQL2008(1).Query = String.Format("select cm.company_name from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (em.employee_id = '{0}')", RowID)
            Else
                _DBR_MSSQL2008(1).Query = String.Format("select cm.company_name from dbo.[[man]]position] ps inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}')", PositionID)
            End If

            _Company = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            Return _Company
        End Function

        Public Function GETDepartement(ByVal RowID As String, Optional ByVal PositionID As String = "-1") As String
            Dim _Departement As String = String.Empty

            If PositionID = "-1" Then
                _DBR_MSSQL2008(1).Query = String.Format("select dp.departement_name from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement where (em.employee_id = '{0}')", RowID)
            Else
                _DBR_MSSQL2008(1).Query = String.Format("select dp.departement_name from dbo.[[man]]position] ps inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement where (ps.position_id = '{0}')", PositionID)
            End If

            _Departement = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            Return _Departement
        End Function

        Public Function GETPositionID(ByVal RowID As String) As String
            Dim _PositionID As String = String.Empty

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_position from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _PositionID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            Return _PositionID
        End Function

        Public Function GETPosition(ByVal RowID As String, Optional ByVal PositionID As String = "-1") As String
            Dim _Position As String = String.Empty

            If PositionID = "-1" Then
                _DBR_MSSQL2008(1).Query = String.Format("select ps.position_name from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position where (em.employee_id = '{0}')", RowID)
            Else
                _DBR_MSSQL2008(1).Query = String.Format("select ps.position_name from dbo.[[man]]position] ps where (ps.position_id = '{0}')", PositionID)
            End If

            _Position = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            Return _Position
        End Function

        Public Function GETGradeID(ByVal RowID As String) As String
            Dim _GradeID As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_grade from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _GradeID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _GradeID = IIf(IsDBNull(_GradeID), "", _GradeID)

            Return _GradeID
        End Function

        Public Function GETGrade(ByVal RowID As String) As String
            Dim _Grade As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select gd.employeegrade_name from dbo.[[man]]employee] em inner join dbo.[[man]]employeegrade] gd on gd.employeegrade_id = em.employee_grade where (em.employee_id = '{0}')", RowID)

            _Grade = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _Grade = IIf(IsDBNull(_Grade), "", _Grade)

            Return _Grade
        End Function

        Public Function GETPersonalID(ByVal RowID As String) As String
            Dim _PersonalID As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select e.employee_personalid from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            _PersonalID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _PersonalID = IIf(IsDBNull(_PersonalID), "", _PersonalID)

            Return _PersonalID
        End Function

        Public Function GETBirthDate(ByVal RowID As String) As String
            Dim _BirthDate As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select e.employee_birthdate from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            _BirthDate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _BirthDate = IIf(IsDBNull(_BirthDate), "1990-01-01", _BirthDate)

            Return _BirthDate
        End Function

        Public Function GETBirthPlace(ByVal RowID As String) As String
            Dim _BirthPlace As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select e.employee_birthplace from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            _BirthPlace = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _BirthPlace = IIf(IsDBNull(_BirthPlace), "", _BirthPlace)

            Return _BirthPlace
        End Function

        Public Function GETAddress(ByVal RowID As String) As String
            Dim _BirthPlace As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select e.employee_address from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            _BirthPlace = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _BirthPlace = IIf(IsDBNull(_BirthPlace), "", _BirthPlace)

            Return _BirthPlace
        End Function

        Public Function GETEmployeeNumber(ByVal RowID As String) As String
            Dim _EmployeeNumber As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_number from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _EmployeeNumber = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _EmployeeNumber = IIf(IsDBNull(_EmployeeNumber), "", _EmployeeNumber)

            Return _EmployeeNumber
        End Function

        Public Function GETEmployeeFullName(ByVal RowID As String) As String
            Dim _EmployeeName As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_fullname from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _EmployeeName = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _EmployeeName = IIf(IsDBNull(_EmployeeName), "", _EmployeeName)

            Return _EmployeeName
        End Function

        Public Function GETEmployeeNickname(ByVal RowID As String) As String
            Dim _Nickname As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_nickname from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _Nickname = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _Nickname = IIf(IsDBNull(_Nickname), "", _Nickname)

            Return _Nickname
        End Function

        Public Function GETContractTypeID(ByVal RowID As String) As String
            Dim _ContractTypeID As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_contracttype from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _ContractTypeID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _ContractTypeID = IIf(IsDBNull(_ContractTypeID), "", _ContractTypeID)

            Return _ContractTypeID
        End Function

        Public Function GETContractType(ByVal RowID As String) As String
            Dim _ContractType As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select cp.contracttype_name from dbo.[[man]]employee] em inner join dbo.[[man]]contracttype] cp on cp.contracttype_id = em.employee_contracttype where (em.employee_id = '{0}')", RowID)

            _ContractType = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _ContractType = IIf(IsDBNull(_ContractType), "", _ContractType)

            Return _ContractType
        End Function

        Public Function GETActiveEmployee(ByVal RowID As String) As Boolean
            Dim _ActiveEmployee As Object = Nothing

            _DBR_MSSQL2008(1).Query = String.Format("select em.employee_active from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            _ActiveEmployee = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            _ActiveEmployee = IIf(IsDBNull(_ActiveEmployee), False, _ActiveEmployee)

            Return _ActiveEmployee
        End Function

        Public Function GETGender(ByVal RowID As String) As String
            Dim _Gender As String = False

            Try
                _DBR_MSSQL2008(1).Query = String.Format("select em.employee_gender from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)
                _Gender = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Catch ex As Exception
                _Gender = "MALE"
            End Try

            Return _Gender
        End Function

        Public Function GETIsHavePhoto(ByVal RowID As String) As Integer
            Dim _IsHavePhoto As Integer = 0

            _DBR_MSSQL2008(0).Query = String.Format("select count(f.file_id) as total from db_universe_erp_file.dbo.[[sto]]file] f where (f.file_parent = '{0}') and (f.file_tag = 'EMPLOYEE-PROFILE-PHOTO');", RowID)
            _IsHavePhoto = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _IsHavePhoto
        End Function

        Public Function GETPhoto(ByVal RowID As String) As Image
            Dim _Photo As System.Drawing.Image = Nothing
            Dim _Bytes As Byte() = Nothing

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.[[sto]]file] f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", RowID)
                _Bytes = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                If Not IsNothing(_Bytes) Then
                    _Photo = _IMG.OutputAsImage(_Bytes)
                End If

                Return _Photo
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function IsPersonalIDExist(ByVal IsNew As Boolean, ByVal PersonalID As String, Optional ByVal EmployeeID As String = "") As Boolean
            Dim _IsExist As Integer = 0

            If IsNew = True Then
                _DBR_MSSQL2008(1).Query = String.Format("select count(em.employee_personalid) from dbo.[[man]]employee] em where em.employee_personalid = '{0}'", PersonalID)
            Else
                _DBR_MSSQL2008(1).Query = String.Format("select count(em.employee_personalid) from dbo.[[man]]employee] em where (em.employee_personalid = '{0}' and em.employee_id <> '{1}')", PersonalID, EmployeeID)
            End If
            _IsExist = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            If _IsExist = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function IsPositionExist(ByVal PositionID As String) As Boolean
            Dim _IsExist As Integer = 0

            _DBR_MSSQL2008(1).Query = String.Format("select count(ps.position_id) as [rows] from dbo.[[man]]position] ps where (ps.position_id = '{0}')", PositionID)
            _IsExist = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            If _IsExist = 0 Then
                Return False
            Else
                Return True
            End If

        End Function

        Public Function IsDuplicate(ByVal PositionID As String, ByVal EmployeeNumber As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _IsDuplicate As Integer = 0
            Dim _Where As String = "where "

            If RowID = "-1" Then
                _Where += String.Format(" (em.employee_number = '{0}') and dp.departement_company = (select dp1.departement_company from dbo.[[man]]position] ps1 inner join dbo.[[man]]departement] dp1 on dp1.departement_id = ps1.position_departement where ps1.position_id = '{1}')", EmployeeNumber, PositionID)
            Else
                _Where += String.Format(" (em.employee_number = '{0}') and dp.departement_company = (select dp1.departement_company from dbo.[[man]]position] ps1 inner join dbo.[[man]]departement] dp1 on dp1.departement_id = ps1.position_departement where ps1.position_id = '{1}') and (em.employee_id <> '{2}')", EmployeeNumber, PositionID, RowID)
            End If

            _DBR_MSSQL2008(1).Query = String.Format("select count(em.employee_id) as [rows] from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement {0}", _Where)

            _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            If _IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function PUSHData(ByVal PersonalID As String, ByVal Position As String, ByVal EmployeeNumber As String, ByVal EmployeeFullName As String, ByVal EmployeeBirthDate As dtp, ByVal EmployeeBirthPlace As String, ByVal EmployeeAddress As String, ByVal EmployeeNickname As String, ByVal ActiveEmployee As Boolean, ByVal EmployeeGender As String, ByVal EmployeePhoto As System.Drawing.Image, ByVal ForceChangePhoto As Boolean, ByVal CreatorEditor As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _Success As Boolean = False
            Dim Hash As String = _SECEncrypt.MD5
            Dim _EmployeeBirthDate As String = EmployeeBirthDate.Value.Year & "-" & EmployeeBirthDate.Value.Month & "-" & EmployeeBirthDate.Value.Day

            Try
                If RowID = "-1" Then
                    _DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]employee](employee_id, employee_personalid, employee_position, employee_number, employee_fullname, employee_birthdate, employee_birthplace, employee_address, employee_nickname, employee_active, employee_gender) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');", Hash, PersonalID, Position, EmployeeNumber, EmployeeFullName, _EmployeeBirthDate, EmployeeBirthPlace, EmployeeAddress, EmployeeNickname, ActiveEmployee, EmployeeGender)
                Else
                    Hash = RowID
                    _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]employee] set employee_position = '{0}', employee_number = '{1}', employee_fullname = '{2}', employee_birthdate = '{3}', employee_birthplace = '{4}', employee_address = '{5}', employee_nickname = '{6}', employee_active = '{7}', employee_gender = '{8}', employee_personalid = '{9}' where employee_id = '{10}';", Position, EmployeeNumber, EmployeeFullName, _EmployeeBirthDate, EmployeeBirthPlace, EmployeeAddress, EmployeeNickname, ActiveEmployee, EmployeeGender, PersonalID, RowID)
                End If

                '_DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                Dim Query As String = String.Empty
                Dim _CMD As SqlClient.SqlCommand = Nothing
                _CMD = New SqlClient.SqlCommand

                If ForceChangePhoto = True Then
                    Dim _IsHavePhoto As Integer = GETIsHavePhoto(Hash)
                    Dim PhotoHash As String = _SECEncrypt.MD5

                    If _IsHavePhoto = 0 Then
                        Query = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filetype, file_content, file_tag, file_datetime, file_attribute, file_uploader, file_parentdate) values(@ID, @ParentID, 'jpg', @FileContent, 'EMPLOYEE-PROFILE-PHOTO', @DateNow, 'module=EPLS;', @Uploader,@ParentDate);"
                    Else
                        _CMD = New SqlClient.SqlCommand
                        Query = String.Format("update db_universe_erp_file.dbo.[[sto]]file] set file_content = @FileContent, file_datetime = GETDATE(), file_parentdate = GETDATE() where file_parent = '{0}' and file_tag = 'EMPLOYEE-PROFILE-PHOTO';", Hash)
                    End If

                    _DBR_MSSQL2008(1).Query += Query

                    _CMD.Parameters.AddWithValue("@ID", PhotoHash)
                    _CMD.Parameters.AddWithValue("@ParentID", Hash)
                    _CMD.Parameters.AddWithValue("@Uploader", CreatorEditor)
                    _CMD.Parameters.AddWithValue("@ParentDate", Now.Date)

                    Dim _MemoryStream = New MemoryStream()
                    Dim _Image As Image = EmployeePhoto
                    Dim _PhotoByte As Byte() = Nothing

                    _Image.Save(_MemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                    _PhotoByte = _MemoryStream.ToArray

                    Dim _ImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image)
                    _ImageParam.Value = _PhotoByte
                    _CMD.Parameters.Add(_ImageParam)

                    _CMD.Parameters.AddWithValue("@DateNow", Now.Date)
                End If

                _CMD.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' GOTO RETRY END END CATCH", _DBR_MSSQL2008(1).Query)

                _Success = _DBE_MSSQL2008.PUSHIMAGE(_CMD)

            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class
End Namespace
