Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDepls
    Public Class View

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As String, grid As dgn, status As CMCv.stt, find As txt, Optional forcerefresh As Boolean = False)
            ReDim varDatabaseRequestMssql2008(2)
            Dim varWhere As String = String.Format("where ")

            If (find.Text = String.Empty) AndAlso (forcerefresh) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format("cm.company_code like '%{0}%' or dp.departement_code like '%{0}%' or ps.position_code like '%{0}%' or em.employee_number = '{0}' or em.employee_fullname like '%{0}%' or " &
                                        "em.employee_nickname like '%{0}%'", find.XOSQLText)
            End If

            varDatabaseRequestMssql2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, (select gd.employeegrade_code from dbo.man_employeegrade gd " &
                                                    "where gd.employeegrade_id = em.employee_grade) as [employee_grade], em.employee_number, em.employee_fullname, em.employee_nickname, (select ct.contracttype_code " &
                                                    "from dbo.[[man]]contracttype] ct where ct.contracttype_id = em.employee_contracttype) as [employee_contracttype], employee_gender, (case em.employee_active when 0 then 'No' " &
                                                    "when 1 then 'Yes' end) as [employee_active] from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                    "inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company {0} " &
                                                    "order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname", varWhere)

            varDatabaseRequestMssql2008(0).DataGrid = grid
            varDatabaseRequestMssql2008(0).StatusBar = status
            varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TEmployee")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean = False
            Try
                varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.man_employee where (employee_id = '{0}')", rowid)
                varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        ReadOnly varImage As New CMCv.ImageEditor.Proccessor.Compress

        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompany(databasename As String, dbengine As String, rowid As String, Optional positionid As String = "-1") As String
            Dim varCompany As String

            If positionid = "-1" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select cm.company_name from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                        "inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company " &
                                                        "where (em.employee_id = '{0}')", rowid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select cm.company_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement " &
                                                        "inner join dbo.man_company cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}')", positionid)
            End If

            varCompany = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varCompany
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetDepartment(databasename As String, dbengine As String, rowid As String, Optional positionid As String = "-1") As String
            Dim varDepartment As String = String.Empty

            If positionid = "-1" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select dp.departement_name from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                        "inner join dbo.man_department dp on dp.department_id = ps.position_departement where (em.employee_id = '{0}')", rowid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select dp.departement_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement " &
                                                        "where (ps.position_id = '{0}')", positionid)
            End If

            varDepartment = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varDepartment
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionID(databasename As String, dbengine As String, rowid As String) As String
            Dim varPositionID As String = String.Empty

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_position from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varPositionID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varPositionID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPosition(databasename As String, dbengine As String, rowid As String, Optional positionid As String = "-1") As String
            Dim varPosition As String = String.Empty

            If positionid = "-1" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ps.position_name from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position where (em.employee_id = '{0}')", rowid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select ps.position_name from dbo.man_position ps where (ps.position_id = '{0}')", positionid)
            End If

            varPosition = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varPosition
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetGradeID(databasename As String, dbengine As String, rowid As String) As String
            Dim varGradeID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_grade from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varGradeID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varGradeID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetGrade(databasename As String, dbengine As String, rowid As String) As String
            Dim varGrade As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select gd.employeegrade_name from dbo.man_employee em inner join dbo.man_employeegrade gd on gd.employeegrade_id = em.employee_grade where (em.employee_id = '{0}')", rowid)

            varGrade = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varGrade
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPersonalID(databasename As String, dbengine As String, rowid As String) As String
            Dim varPersonalID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_personalid from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varPersonalID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varPersonalID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetBirthDate(databasename As String, dbengine As String, rowid As String) As Date
            Dim varBirthDate As Date

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_birthdate from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varBirthDate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Date)

            Return varBirthDate
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetBirthPlace(databasename As String, dbengine As String, rowid As String) As String
            Dim varBirthPlace As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_birthplace from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varBirthPlace = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varBirthPlace
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetAddress(databasename As String, dbengine As String, rowid As String) As String
            Dim varBirthPlace As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_address from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varBirthPlace = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varBirthPlace
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(databasename As String, dbengine As String, rowid As String) As String
            Dim varEmployeeNumber As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_number from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varEmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeFullName(databasename As String, dbengine As String, rowid As String) As String
            Dim varEmployeeName As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_fullname from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varEmployeeName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varEmployeeName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNickname(databasename As String, dbengine As String, rowid As String) As String
            Dim varNickname As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_nickname from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varNickname = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varNickname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetContractTypeID(databasename As String, dbengine As String, rowid As String) As String
            Dim varContractTypeID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_contracttype from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varContractTypeID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varContractTypeID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetContractType(databasename As String, dbengine As String, rowid As String) As String
            Dim varContractType As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select cp.contracttype_name from dbo.man_employee em inner join dbo.[[man]]contracttype] cp on cp.contracttype_id = em.employee_contracttype " &
                                                    "where (em.employee_id = '{0}')", rowid)

            varContractType = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

            Return varContractType
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetActiveEmployee(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varActiveEmployee As Boolean = False

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_active from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varActiveEmployee = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Boolean)

            Return varActiveEmployee
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetGender(databasename As String, dbengine As String, rowid As String) As String
            Dim varGender As String

            Try
                varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_gender from dbo.man_employee em where (em.employee_id = '{0}')", rowid)
                varGender = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            Catch ex As Exception
                varGender = "MALE"
            End Try

            Return varGender
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetIsHavePhoto(databasename As String, dbengine As String, rowid As String) As Integer
            Dim varIsHavePhoto As Integer = 0

            varDatabaseRequestMssql2008(0).Query = String.Format("select count(f.file_id) as total from db_universe_erp_file.dbo.sto_file f where (f.file_parent = '{0}') and (f.file_tag = 'EMPLOYEE-PROFILE-PHOTO');", rowid)
            varIsHavePhoto = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

            Return varIsHavePhoto
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPhoto(databasename As String, dbengine As String, rowid As String) As Image
            Dim varPhoto As System.Drawing.Image = Nothing
            Dim varBytes As Byte()

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.sto_file f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", rowid)
                varBytes = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Byte())

                If Not IsNothing(varBytes) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(varBytes)
                End If

                Return varPhoto
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsPersonalIDExist(databasename As String, dbengine As String, isnew As Boolean, personalid As String, Optional employeeid As String = "") As Boolean
            Dim varIsExist As Integer = 0

            If isnew Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(em.employee_personalid) from dbo.man_employee em where em.employee_personalid = '{0}'", personalid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(em.employee_personalid) from dbo.man_employee em where (em.employee_personalid = '{0}' and em.employee_id <> '{1}')", personalid, employeeid)
            End If
            varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)

            If varIsExist = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsPositionExist(databasename As String, dbengine As String, positionid As String) As Boolean
            Dim varIsExist As Integer = 0

            varDatabaseRequestMssql2008(1).Query = String.Format("select count(ps.position_id) as [rows] from dbo.man_position ps where (ps.position_id = '{0}')", positionid)
            varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)

            If varIsExist = 0 Then
                Return False
            Else
                Return True
            End If

        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As String, positionid As String, employeenumber As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "where "

            If rowid = "-1" Then
                varWhere += String.Format(" (em.employee_number = '{0}') and dp.departement_company = (select dp1.departement_company from dbo.man_position ps1 " &
                                        "inner join dbo.man_department dp1 on dp1.department_id = ps1.position_departement where ps1.position_id = '{1}')", employeenumber, positionid)
            Else
                varWhere += String.Format(" (em.employee_number = '{0}') and dp.departement_company = (select dp1.departement_company from dbo.man_position ps1 " &
                                        "inner join dbo.man_department dp1 on dp1.department_id = ps1.position_departement where ps1.position_id = '{1}') and (em.employee_id <> '{2}')", employeenumber, positionid, rowid)
            End If

            varDatabaseRequestMssql2008(1).Query = String.Format("select count(em.employee_id) as [rows] from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                    "inner join dbo.man_department dp on dp.department_id = ps.position_departement {0}", varWhere)

            varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, personalid As String, position As String, employeenumber As String, employeefullname As String, employeebirthdate As dtp, employeebirthplace As String, employeeaddress As String, employeenickname As String, activeemployee As Boolean, employeegender As String, employeephoto As System.Drawing.Image, forcechangephoto As Boolean, creatoreditor As String, Optional rowid As String = "-1") As Boolean
            Dim varSuccess As Boolean = False
            Dim varHash As String = CMCv.Security.Encrypt.MD5()
            Dim varEmployeeBirthDate As String = employeebirthdate.Value.Year & "-" & employeebirthdate.Value.Month & "-" & employeebirthdate.Value.Day

            Try
                If rowid = "-1" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.man_employee(employee_id, employee_personalid, employee_position, employee_number, employee_fullname, employee_birthdate, employee_birthplace, " &
                                                            "employee_address, employee_nickname, employee_active, employee_gender) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');", varHash, personalid, position, employeenumber, employeefullname, varEmployeeBirthDate, employeebirthplace, employeeaddress, employeenickname, activeemployee, employeegender)
                Else
                    varHash = rowid
                    varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.man_employee set employee_position = '{0}', employee_number = '{1}', employee_fullname = '{2}', employee_birthdate = '{3}', employee_birthplace = '{4}', " &
                                                            "employee_address = '{5}', employee_nickname = '{6}', employee_active = '{7}', employee_gender = '{8}', employee_personalid = '{9}' " &
                                                            "where employee_id = '{10}';", position, employeenumber, employeefullname, varEmployeeBirthDate, employeebirthplace, employeeaddress, employeenickname, activeemployee, employeegender, personalid, rowid)
                End If

                'varDatabaseEngineMssql2008.PUSHDATA(varDatabaseRequestMssql2008(1).Query)
                Dim varQuery As String = String.Empty
                Dim varCommand As SqlClient.SqlCommand = Nothing
                varCommand = New SqlClient.SqlCommand

                If forcechangephoto Then
                    Dim varIsHavePhoto As Integer = GetIsHavePhoto(databasename, dbengine, varHash)
                    Dim varPhotoHash As String = CMCv.Security.Encrypt.MD5()

                    If varIsHavePhoto = 0 Then
                        varQuery = "insert into db_universe_erp_file.dbo.sto_file([file_id], file_parent, file_filetype, file_content, file_tag, file_datetime, file_attribute, file_uploader, file_parentdate) " &
                            "values(@ID, @ParentID, 'jpg', @FileContent, 'EMPLOYEE-PROFILE-PHOTO', @DateNow, 'module=EPLS;', @Uploader,@ParentDate);"
                    Else
                        varCommand = New SqlClient.SqlCommand
                        varQuery = String.Format("update db_universe_erp_file.dbo.sto_file set file_content = @FileContent, file_datetime = GETDATE(), file_parentdate = GETDATE() where file_parent = '{0}' and " &
                                              "file_tag = 'EMPLOYEE-PROFILE-PHOTO';", varHash)
                    End If

                    varDatabaseRequestMssql2008(1).Query += varQuery

                    varCommand.Parameters.AddWithValue("@ID", varPhotoHash)
                    varCommand.Parameters.AddWithValue("@ParentID", varHash)
                    varCommand.Parameters.AddWithValue("@Uploader", creatoreditor)
                    varCommand.Parameters.AddWithValue("@ParentDate", Now.Date)

                    Dim varMemorystream = New MemoryStream()
                    Dim varImage As Image = employeephoto
                    Dim varPhotobyte As Byte() = Nothing

                    varImage.Save(varMemorystream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                    varPhotobyte = varMemorystream.ToArray

                    Dim varImageparameter As New SqlClient.SqlParameter("@FileContent", SqlDbType.Image) With {
                    .Value = varPhotobyte
                    }
                    varCommand.Parameters.Add(varImageparameter)
                    varCommand.Parameters.AddWithValue("@DateNow", Now.Date)
                End If

                varCommand.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' " &
                                                 "GOTO RETRY END END CATCH", varDatabaseRequestMssql2008(1).Query)

                varSuccess = varDatabaseEngineMssql2008.PushImage(varCommand)

            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
