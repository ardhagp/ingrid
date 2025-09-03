Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.EPLS
    Public Class View

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DBEngine As String, ByVal Grid As dgn, ByVal Status As CMCv.stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            ReDim V_DBR_MSSQL2008(2)
            Dim V_Where As String = String.Format("where ")

            If (Find.Text = String.Empty) And (ForceRefresh) Then
                V_Where = String.Format("")
            Else
                V_Where += String.Format("cm.company_code like '%{0}%' or dp.departement_code like '%{0}%' or ps.position_code like '%{0}%' or em.employee_number = '{0}' or em.employee_fullname like '%{0}%' or " &
                                        "em.employee_nickname like '%{0}%'", Find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, (select gd.employeegrade_code from dbo.[[man]]employeegrade] gd " &
                                                    "where gd.employeegrade_id = em.employee_grade) as [employee_grade], em.employee_number, em.employee_fullname, em.employee_nickname, (select ct.contracttype_code " &
                                                    "from dbo.[[man]]contracttype] ct where ct.contracttype_id = em.employee_contracttype) as [employee_contracttype], employee_gender, (case em.employee_active when 0 then 'No' " &
                                                    "when 1 then 'Yes' end) as [employee_active] from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position " &
                                                    "inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company {0} " &
                                                    "order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname", V_Where)

            V_DBR_MSSQL2008(0).DataGrid = Grid
            V_DBR_MSSQL2008(0).StatusBar = Status
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TEmployee")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[man]]employee] where (employee_id = '{0}')", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function
    End Class

    Public Class Editor
        ReadOnly _IMG As New CMCv.ImageEditor.Proccessor.Compress

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompany(ByVal DBEngine As String, ByVal RowID As String, Optional ByVal PositionID As String = "-1") As String
            Dim V_Company As String

            If PositionID = "-1" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select cm.company_name from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position " &
                                                        "inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company " &
                                                        "where (em.employee_id = '{0}')", RowID)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select cm.company_name from dbo.[[man]]position] ps inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement " &
                                                        "inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}')", PositionID)
            End If

            V_Company = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_Company
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDepartment(ByVal DBEngine As String, ByVal RowID As String, Optional ByVal PositionID As String = "-1") As String
            Dim V_Departement As String

            If PositionID = "-1" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select dp.departement_name from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position " &
                                                        "inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement where (em.employee_id = '{0}')", RowID)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select dp.departement_name from dbo.[[man]]position] ps inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement " &
                                                        "where (ps.position_id = '{0}')", PositionID)
            End If

            V_Departement = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_Departement
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_PositionID As String

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_position from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_PositionID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_PositionID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPosition(ByVal DBEngine As String, ByVal RowID As String, Optional ByVal PositionID As String = "-1") As String
            Dim V_Position As String

            If PositionID = "-1" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ps.position_name from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position where (em.employee_id = '{0}')", RowID)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select ps.position_name from dbo.[[man]]position] ps where (ps.position_id = '{0}')", PositionID)
            End If

            V_Position = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_Position
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETGradeID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_GradeID As String

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_grade from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_GradeID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_GradeID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETGrade(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_Grade As String

            V_DBR_MSSQL2008(1).Query = String.Format("select gd.employeegrade_name from dbo.[[man]]employee] em inner join dbo.[[man]]employeegrade] gd on gd.employeegrade_id = em.employee_grade where (em.employee_id = '{0}')", RowID)

            V_Grade = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_Grade
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPersonalID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_PersonalID As String

            V_DBR_MSSQL2008(1).Query = String.Format("select e.employee_personalid from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            V_PersonalID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_PersonalID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETBirthDate(ByVal DBEngine As String, ByVal RowID As String) As Date
            Dim V_BirthDate As Date

            V_DBR_MSSQL2008(1).Query = String.Format("select e.employee_birthdate from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            V_BirthDate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Date)

            Return V_BirthDate
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETBirthPlace(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_BirthPlace As String

            V_DBR_MSSQL2008(1).Query = String.Format("select e.employee_birthplace from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            V_BirthPlace = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_BirthPlace
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETAddress(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_BirthPlace As String

            V_DBR_MSSQL2008(1).Query = String.Format("select e.employee_address from dbo.[[man]]employee] e where e.employee_id = '{0}'", RowID)

            V_BirthPlace = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_BirthPlace
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_EmployeeNumber As String

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_number from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_EmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeFullName(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_EmployeeName As String

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_fullname from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_EmployeeName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_EmployeeName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNickname(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_Nickname As String

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_nickname from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_Nickname = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_Nickname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETContractTypeID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_ContractTypeID As String

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_contracttype from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_ContractTypeID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_ContractTypeID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETContractType(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_ContractType As String

            V_DBR_MSSQL2008(1).Query = String.Format("select cp.contracttype_name from dbo.[[man]]employee] em inner join dbo.[[man]]contracttype] cp on cp.contracttype_id = em.employee_contracttype " &
                                                    "where (em.employee_id = '{0}')", RowID)

            V_ContractType = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

            Return V_ContractType
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETActiveEmployee(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_ActiveEmployee As Boolean

            V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_active from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)

            V_ActiveEmployee = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Boolean)

            Return V_ActiveEmployee
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETGender(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_Gender As String

            Try
                V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_gender from dbo.[[man]]employee] em where (em.employee_id = '{0}')", RowID)
                V_Gender = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            Catch ex As Exception
                V_Gender = "MALE"
            End Try

            Return V_Gender
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETIsHavePhoto(ByVal DBEngine As String, ByVal RowID As String) As Integer
            Dim V_IsHavePhoto As Integer

            V_DBR_MSSQL2008(0).Query = String.Format("select count(f.file_id) as total from db_universe_erp_file.dbo.[[sto]]file] f where (f.file_parent = '{0}') and (f.file_tag = 'EMPLOYEE-PROFILE-PHOTO');", RowID)
            V_IsHavePhoto = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

            Return V_IsHavePhoto
        End Function

        <SupportedOSPlatform("windows")>
        Public Function GETPhoto(ByVal DBEngine As String, ByVal RowID As String) As Image
            Dim V_Photo As System.Drawing.Image = Nothing
            Dim V_Bytes As Byte()

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.[[sto]]file] f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", RowID)
                V_Bytes = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Byte())

                If Not IsNothing(V_Bytes) Then
                    V_Photo = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(V_Bytes)
                End If

                Return V_Photo
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsPersonalIDExist(ByVal DBEngine As String, ByVal IsNew As Boolean, ByVal PersonalID As String, Optional ByVal EmployeeID As String = "") As Boolean
            Dim V_IsExist As Integer

            If IsNew = True Then
                V_DBR_MSSQL2008(1).Query = String.Format("select count(em.employee_personalid) from dbo.[[man]]employee] em where em.employee_personalid = '{0}'", PersonalID)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select count(em.employee_personalid) from dbo.[[man]]employee] em where (em.employee_personalid = '{0}' and em.employee_id <> '{1}')", PersonalID, EmployeeID)
            End If
            V_IsExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

            If V_IsExist = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsPositionExist(ByVal DBEngine As String, ByVal PositionID As String) As Boolean
            Dim V_IsExist As Integer

            V_DBR_MSSQL2008(1).Query = String.Format("select count(ps.position_id) as [rows] from dbo.[[man]]position] ps where (ps.position_id = '{0}')", PositionID)
            V_IsExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

            If V_IsExist = 0 Then
                Return False
            Else
                Return True
            End If

        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal PositionID As String, ByVal EmployeeNumber As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_IsDuplicate As Integer
            Dim V_Where As String = "where "

            If RowID = "-1" Then
                V_Where += String.Format(" (em.employee_number = '{0}') and dp.departement_company = (select dp1.departement_company from dbo.[[man]]position] ps1 " &
                                        "inner join dbo.[[man]]department] dp1 on dp1.department_id = ps1.position_departement where ps1.position_id = '{1}')", EmployeeNumber, PositionID)
            Else
                V_Where += String.Format(" (em.employee_number = '{0}') and dp.departement_company = (select dp1.departement_company from dbo.[[man]]position] ps1 " &
                                        "inner join dbo.[[man]]department] dp1 on dp1.department_id = ps1.position_departement where ps1.position_id = '{1}') and (em.employee_id <> '{2}')", EmployeeNumber, PositionID, RowID)
            End If

            V_DBR_MSSQL2008(1).Query = String.Format("select count(em.employee_id) as [rows] from dbo.[[man]]employee] em inner join dbo.[[man]]position] ps on ps.position_id = em.employee_position " &
                                                    "inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement {0}", V_Where)

            V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

            If V_IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal PersonalID As String, ByVal Position As String, ByVal EmployeeNumber As String, ByVal EmployeeFullName As String, ByVal EmployeeBirthDate As dtp, ByVal EmployeeBirthPlace As String, ByVal EmployeeAddress As String, ByVal EmployeeNickname As String, ByVal ActiveEmployee As Boolean, ByVal EmployeeGender As String, ByVal EmployeePhoto As System.Drawing.Image, ByVal ForceChangePhoto As Boolean, ByVal CreatorEditor As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_Success As Boolean
            Dim Hash As String = CMCv.Security.Encrypt.MD5()
            Dim V_EmployeeBirthDate As String = EmployeeBirthDate.Value.Year & "-" & EmployeeBirthDate.Value.Month & "-" & EmployeeBirthDate.Value.Day

            Try
                If RowID = "-1" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]employee](employee_id, employee_personalid, employee_position, employee_number, employee_fullname, employee_birthdate, employee_birthplace, " &
                                                            "employee_address, employee_nickname, employee_active, employee_gender) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');", Hash, PersonalID, Position, EmployeeNumber, EmployeeFullName, V_EmployeeBirthDate, EmployeeBirthPlace, EmployeeAddress, EmployeeNickname, ActiveEmployee, EmployeeGender)
                Else
                    Hash = RowID
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]employee] set employee_position = '{0}', employee_number = '{1}', employee_fullname = '{2}', employee_birthdate = '{3}', employee_birthplace = '{4}', " &
                                                            "employee_address = '{5}', employee_nickname = '{6}', employee_active = '{7}', employee_gender = '{8}', employee_personalid = '{9}' " &
                                                            "where employee_id = '{10}';", Position, EmployeeNumber, EmployeeFullName, V_EmployeeBirthDate, EmployeeBirthPlace, EmployeeAddress, EmployeeNickname, ActiveEmployee, EmployeeGender, PersonalID, RowID)
                End If

                'V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                Dim Query As String = String.Empty
                Dim _CMD As SqlClient.SqlCommand = Nothing
                _CMD = New SqlClient.SqlCommand

                If ForceChangePhoto Then
                    Dim _IsHavePhoto As Integer = GETIsHavePhoto(DBEngine, Hash)
                    Dim PhotoHash As String = CMCv.Security.Encrypt.MD5()

                    If _IsHavePhoto = 0 Then
                        Query = "insert into db_universe_erp_file.dbo.[[sto]]file]([file_id], file_parent, file_filetype, file_content, file_tag, file_datetime, file_attribute, file_uploader, file_parentdate) " &
                            "values(@ID, @ParentID, 'jpg', @FileContent, 'EMPLOYEE-PROFILE-PHOTO', @DateNow, 'module=EPLS;', @Uploader,@ParentDate);"
                    Else
                        _CMD = New SqlClient.SqlCommand
                        Query = String.Format("update db_universe_erp_file.dbo.[[sto]]file] set file_content = @FileContent, file_datetime = GETDATE(), file_parentdate = GETDATE() where file_parent = '{0}' and " &
                                              "file_tag = 'EMPLOYEE-PROFILE-PHOTO';", Hash)
                    End If

                    V_DBR_MSSQL2008(1).Query += Query

                    _CMD.Parameters.AddWithValue("@ID", PhotoHash)
                    _CMD.Parameters.AddWithValue("@ParentID", Hash)
                    _CMD.Parameters.AddWithValue("@Uploader", CreatorEditor)
                    _CMD.Parameters.AddWithValue("@ParentDate", Now.Date)

                    Dim _MemoryStream = New MemoryStream()
                    Dim _Image As Image = EmployeePhoto
                    Dim _PhotoByte As Byte() = Nothing

                    _Image.Save(_MemoryStream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                    _PhotoByte = _MemoryStream.ToArray

                    Dim _ImageParam As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image) With {
                    .Value = _PhotoByte
                    }
                    _CMD.Parameters.Add(_ImageParam)

                    _CMD.Parameters.AddWithValue("@DateNow", Now.Date)
                End If

                _CMD.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' " &
                                                 "GOTO RETRY END END CATCH", V_DBR_MSSQL2008(1).Query)

                V_Success = V_DBE_MSSQL2008.PUSHIMAGE(_CMD)

            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class
End Namespace
