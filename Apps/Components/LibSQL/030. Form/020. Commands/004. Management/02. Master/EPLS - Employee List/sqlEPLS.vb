Namespace CMDepls
    ''' <summary>
    ''' The View class provides methods for displaying and managing employee data in a user interface. It includes functionality to display employee data in a grid, delete employee records, and retrieve various employee properties from the database. The class supports both MSSQL and MySQL database engines and handles data retrieval and manipulation based on the specified database engine.
    ''' </summary>
    Public Class View
        ''' <summary>
        ''' Displays employee data in a specified grid control based on the provided data properties, status bar, and search criteria. This function constructs a SQL query to retrieve employee information from the database, applying filters based on the search text. It supports both MSSQL and MySQL database engines and populates the grid with the retrieved data. The function also updates the status bar to reflect the current state of the data display.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="grid">The grid control where the employee data will be displayed.</param>
        ''' <param name="status">The status bar control to update with the current state of the data display.</param>
        ''' <param name="find">The text box control containing the search criteria for filtering employee data.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, grid As CMCv.UI.Control.Dgn, status As CMCv.UI.Control.Stt, find As CMCv.UI.Control.Txt)
            ReDim varDatabaseRequestMssql2008(2)
            Dim varWhere As String = $"where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.Text = String.Empty) AndAlso (dataproperties.EmployeeIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += String.Format("cm.company_code like '%{0}%' or dp.departement_code like '%{0}%' or ps.position_code like '%{0}%' or em.employee_number = '{0}' or em.employee_fullname like '%{0}%' or " &
                                        "em.employee_nickname like '%{0}%'", find.XOSqlText)
                End If

                varDatabaseRequestMssql2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, (select gd.employeegrade_code from dbo.man_employeegrade gd " &
                                                    "where gd.employeegrade_id = em.employee_grade) as [employee_grade], em.employee_number, em.employee_fullname, em.employee_nickname, (select ct.contracttype_code " &
                                                    "from dbo.[[man]]contracttype] ct where ct.contracttype_id = em.employee_contracttype) as [employee_contracttype], employee_gender, (case em.employee_active when 0 then 'No' " &
                                                    "when 1 then 'Yes' end) as [employee_active] from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                    "inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company {0} " &
                                                    "order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = grid
                varDatabaseRequestMssql2008(0).StatusBar = status
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TEmployee")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.Text = String.Empty) AndAlso (dataproperties.EmployeeIsForceRefresh) Then
                    varWhere += $"({tEmployee.C_EmployeeClient} = {tClient.P_ClientId}) "
                Else
                    varWhere += $"({tEmployee.C_EmployeeClient} = {tClient.P_ClientId}) and ({tCompany.S}.{tCompany.C_CompanyCode} like '%{find.XOSqlText}%' or {tDepartment.S}.{tDepartment.C_DepartmentCode} like '%{find.XOSqlText}%' or {tPosition.S}.{tPosition.C_PositionCode} like '%{find.XOSqlText}%' or {tEmployee.S}.{tEmployee.C_EmployeeNumber} = '{find.XOSqlText}' or {tEmployee.S}.{tEmployee.C_EmployeeFullName} like '%{find.XOSqlText}%' or " &
                                $"{tEmployee.S}.{tEmployee.C_EmployeeNickname} like '%{find.XOSqlText}%')"
                End If
                varDatabaseRequestMysql(0).Query = $"select {tEmployee.S}.{tEmployee.C_EmployeeId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionCode}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionName}, " &
                                                   $"(select {tEmploymentType.S}.{tEmploymentType.C_EmploymentTypeName} from {tEmploymentType.TableName} {tEmploymentType.S} where {tEmploymentType.S}.{tEmploymentType.C_EmploymentTypeId} = {tEmployee.S}.{tEmployee.C_EmployeeEmploymentType}) as `{tEmploymentType.C_EmploymentTypeName}`, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeNumber}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeFullName}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeNickname}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeGender}, " &
                                                   $"(case {tEmployee.S}.{tEmployee.C_EmployeeIsActive} when 0 then 'No' when 1 then 'Yes' end) as `{tEmployee.C_EmployeeIsActive}` " &
                                                   $"From {tEmployee.TableName} {tEmployee.S} " &
                                                   $"inner Join {tPosition.TableName} {tPosition.S} on {tPosition.S}.{tPosition.C_PositionId} = {tEmployee.S}.{tEmployee.C_EmployeePosition} " &
                                                   $"inner Join {tDepartment.TableName} {tDepartment.S} on {tDepartment.S}.{tDepartment.C_DepartmentId} = {tPosition.S}.{tPosition.C_PositionDepartment} " &
                                                   $"inner Join {tCompany.TableName} {tCompany.S} On {tCompany.S}.{tCompany.C_CompanyId} = {tDepartment.S}.{tDepartment.C_DepartmentCompany} " &
                                                   $"{varWhere} " &
                                                   $"order by {tCompany.S}.{tCompany.C_CompanyCode}, {tDepartment.S}.{tDepartment.C_DepartmentCode}, {tPosition.S}.{tPosition.C_PositionCode}, {tEmployee.S}.{tEmployee.C_EmployeeFullName}"

                varDatabaseRequestMysql(0).DataGrid = grid
                varDatabaseRequestMysql(0).StatusBar = status
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TEmployee", dataproperties.AllParameters)
            End If
        End Sub

        ''' <summary>
        ''' Deletes employee data from the database based on the provided data properties and dataset name. This function constructs a SQL query to delete an employee record from the database, using the specified employee ID as a parameter. It supports both MSSQL and MySQL database engines and executes the deletion operation accordingly. The function returns a boolean value indicating whether the deletion was successful or not.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="datasetname">The dataset name containing the employee data to be deleted.</param>
        ''' <returns>True if the deletion was successful; otherwise, False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varSuccess As Boolean
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"delete from dbo.man_employee where (employee_id = @EmployeeId)"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"delete from {tEmploymentType.TableName} where ({tEmployee.C_EmployeeId} = {tEmployee.P_EmployeeId})"
                    varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    ''' <summary>
    ''' The Editor class provides methods for retrieving and managing employee properties from the database. It includes functionality to get various employee attributes such as company, department, position, grade, personal ID, birth date, birth place, address, employee number, full name, nickname, contract type, active status, gender, and
    ''' </summary>
    Public Class Editor
        ''' <summary>
        ''' Retrieves employee properties from the database and populates the specified dataset with the retrieved data. This function constructs a SQL query to select various employee attributes based on the provided data properties and employee ID. It supports both MSSQL and MySQL database engines and fills the dataset with the retrieved employee information. The function is intended for use in an editor context where employee details need to be displayed or modified.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="datasetname">The dataset name to be populated with the retrieved employee data.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub GetEmployeeProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = $"select em.employee_id, cm.company_id, cm.company_code, cm.company_name, " &
                                                   $"dp.department_id, dp.department_code, dp.department_name, " &
                                                   $"ps.position_id, ps.position_code, ps.position_name, " &
                                                   $"(select et.employmenttype_name from man_employmenttype et where et.employmenttype_id = em.employee_employmenttype) as `employmenttype_name`, " &
                                                   $"em.employee_personalidnumber, " &
                                                   $"em.employee_number, " &
                                                   $"em.employee_fullname, " &
                                                   $"em.employee_nickname, " &
                                                   $"em.employee_gender, " &
                                                   $"(case em.employee_active when 0 then 'No' when 1 then 'Yes' end) as `employee_active` " &
                                                   $"from man_employee em " &
                                                   $"inner join man_position ps on ps.position_id = em.employee_position " &
                                                   $"inner join man_department dp on dp.department_id = ps.position_department " &
                                                   $"inner join man_company cm on cm.company_id = dp.department_company " &
                                                   $"where em.employee_id = @EmployeeId " &
                                                   $"order by em.employee_id"
                varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query, datasetname, "EPLS_Editor")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select {tEmployee.S}.{tEmployee.C_EmployeeId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentId}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionId}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionCode}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionName}, " &
                                                   $"{tEmploymentType.S}.{tEmploymentType.C_EmploymentTypeName}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeePersonalIdNumber}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeNumber}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeFullName}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeNickname}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeGender}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeBirthDate}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeBirthPlace}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeAddress}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeEmploymentType}, " &
                                                   $"{tEmployee.S}.{tEmployee.C_EmployeeIsActive}, " &
                                                   $"if({tAttachment.S}.{tAttachment.C_AttachmentId} is null, 0, 1) `ishavephoto`, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentId}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentUrl} " &
                                                   $"from {tEmployee.TableName} {tEmployee.S} " &
                                                   $"left join {tAttachment.TableName} {tAttachment.S} " &
                                                   $"on {tEmployee.S}.{tEmployee.C_EmployeeId} = {tAttachment.S}.{tAttachment.C_AttachmentParentId} and " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentTag} = 'EMPLOYEE-PROFILE-PHOTO'" &
                                                   $"left join {tEmploymentType.TableName} {tEmploymentType.S} " &
                                                   $"on {tEmploymentType.S}.{tEmploymentType.C_EmploymentTypeId} = {tEmployee.S}.{tEmployee.C_EmployeeEmploymentType} " &
                                                   $"inner join {tPosition.TableName} {tPosition.S} " &
                                                   $"on {tPosition.S}.{tPosition.C_PositionId} = {tEmployee.S}.{tEmployee.C_EmployeePosition} " &
                                                   $"inner join {tDepartment.TableName} {tDepartment.S} " &
                                                   $"on {tDepartment.S}.{tDepartment.C_DepartmentId} = {tPosition.S}.{tPosition.C_PositionDepartment} " &
                                                   $"inner join {tCompany.TableName} {tCompany.S} " &
                                                   $"on {tCompany.S}.{tCompany.C_CompanyId} = {tDepartment.S}.{tDepartment.C_DepartmentCompany} " &
                                                   $"where {tEmployee.S}.{tEmployee.C_EmployeeId} = {tEmployee.P_EmployeeId} " &
                                                   $"order by {tEmployee.S}.{tEmployee.C_EmployeeFullName}"
                varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, "EPLS_Editor", dataproperties.AllParameters)
            End If
        End Sub

        ''' <summary>
        ''' Retrieves the company name associated with a specific employee or position from the database. This function constructs a SQL query to select the company name based on the provided employee ID or position ID. If the position ID is not provided, it retrieves the company name based on the employee ID. The function supports both MSSQL and MySQL database engines and returns the company name as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the company name.</param>
        ''' <param name="positionid">The optional ID of the position for which to retrieve the company name. If not provided, the employee ID is used.</param>
        ''' <returns>The name of the company associated with the specified employee or position.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetCompany(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String, Optional positionid As String = "-1") As String
            Dim varCompany As String

            If positionid = "-1" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select cm.company_name from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                        "inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company " &
                                                        "where (em.employee_id = '{0}')", rowid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select cm.company_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement " &
                                                        "inner join dbo.man_company cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}')", positionid)
            End If

            varCompany = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varCompany
        End Function

        ''' <summary>
        ''' Retrieves the department name associated with a specific employee or position from the database. This function constructs a SQL query to select the department name based on the provided employee ID or position ID. If the position ID is not provided, it retrieves the department name based on the employee ID. The function supports both MSSQL and MySQL database engines and returns the department name as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the department name.</param>
        ''' <param name="positionid">The optional ID of the position for which to retrieve the department name. If not provided, the employee ID is used.</param>
        ''' <returns>The name of the department associated with the specified employee or position.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetDepartment(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String, Optional positionid As String = "-1") As String
            Dim varDepartment As String

            If positionid = "-1" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select dp.departement_name from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                        "inner join dbo.man_department dp on dp.department_id = ps.position_departement where (em.employee_id = '{0}')", rowid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select dp.departement_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement " &
                                                        "where (ps.position_id = '{0}')", positionid)
            End If

            varDepartment = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varDepartment
        End Function

        ''' <summary>
        ''' Retrieves the position ID associated with a specific employee from the database. This function constructs a SQL query to select the position ID based on the provided employee ID. The function supports both MSSQL and MySQL database engines and returns the position ID as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the position ID.</param>
        ''' <returns>The position ID associated with the specified employee.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetPositionID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varPositionID As String = String.Empty

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_position from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varPositionID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varPositionID
        End Function

        ''' <summary>
        ''' Retrieves the position name associated with a specific employee or position from the database. This function constructs a SQL query to select the position name based on the provided employee ID or position ID. If the position ID is not provided, it retrieves the position name based on the employee ID. The function supports both MSSQL and MySQL database engines and returns the position name as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the position name.</param>
        ''' <param name="positionid">The ID of the position for which to retrieve the position name. If not provided, the function retrieves the position name based on the employee ID.</param>
        ''' <returns>The position name associated with the specified employee or position.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetPosition(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String, Optional positionid As String = "-1") As String
            Dim varPosition As String = String.Empty

            If positionid = "-1" Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ps.position_name from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position where (em.employee_id = '{0}')", rowid)
            Else
                varDatabaseRequestMssql2008(1).Query = String.Format("select ps.position_name from dbo.man_position ps where (ps.position_id = '{0}')", positionid)
            End If

            varPosition = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varPosition
        End Function

        ''' <summary>
        ''' Retrieves the grade ID associated with a specific employee from the database. This function constructs a SQL query to select the grade ID based on the provided employee ID. The function supports both MSSQL and MySQL database engines and returns the grade ID as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the grade ID.</param>
        ''' <returns>The grade ID associated with the specified employee.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetGradeID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varGradeID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_grade from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varGradeID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varGradeID
        End Function

        ''' <summary>
        ''' Retrieves the grade name associated with a specific employee from the database. This function constructs a SQL query to select the grade name based on the provided employee ID. The function supports both MSSQL and MySQL database engines and returns the grade name as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the grade name.</param>
        ''' <returns>The grade name associated with the specified employee.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetGrade(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varGrade As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select gd.employeegrade_name from dbo.man_employee em inner join dbo.man_employeegrade gd on gd.employeegrade_id = em.employee_grade where (em.employee_id = '{0}')", rowid)

            varGrade = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varGrade
        End Function

        ''' <summary>
        ''' Retrieves the personal ID associated with a specific employee from the database. This function constructs a SQL query to select the personal ID based on the provided employee ID. The function supports both MSSQL and MySQL database engines and returns the personal ID as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the personal ID.</param>
        ''' <returns>The personal ID associated with the specified employee.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetPersonalID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varPersonalID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_personalid from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varPersonalID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varPersonalID
        End Function

        ''' <summary>
        ''' Retrieves the birth date associated with a specific employee from the database. This function constructs a SQL query to select the birth date based on the provided employee ID. The function supports both MSSQL and MySQL database engines and returns the birth date as a Date object.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the birth date.</param>
        ''' <returns>The birth date associated with the specified employee.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetBirthDate(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As Date
            Dim varBirthDate As Date

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_birthdate from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varBirthDate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Date)

            Return varBirthDate
        End Function

        ''' <summary>
        ''' Retrieves the birth place associated with a specific employee from the database. This function constructs a SQL query to select the birth place based on the provided employee ID. The function supports both MSSQL and MySQL database engines and returns the birth place as a string.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The ID of the employee for which to retrieve the birth place.</param>
        ''' <returns>The birth place associated with the specified employee.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetBirthPlace(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varBirthPlace As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_birthplace from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varBirthPlace = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varBirthPlace
        End Function

        ''' <summary>
        ''' This function retrieves the address of an employee from the database. It queries the database for the address associated with the specified employee ID and returns it as a string.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose address is to be retrieved.</param>
        ''' <returns>The address of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetAddress(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varAddress As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_address from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varAddress = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            Return varAddress
        End Function

        ''' <summary>
        ''' This function retrieves the address of an employee from the database. It queries the database for the address associated with the specified employee ID and returns it as a string.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose address is to be retrieved.</param>
        ''' <returns>The address of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNumber(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varEmployeeNumber As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_number from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varEmployeeNumber
        End Function

        ''' <summary>
        ''' This function retrieves the full name of an employee from the database. It queries the database for the full name associated with the specified employee ID and returns it as a string.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose full name is to be retrieved.</param>
        ''' <returns>The full name of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeFullName(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varEmployeeName As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_fullname from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varEmployeeName = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varEmployeeName
        End Function

        ''' <summary>
        ''' This function retrieves the nickname of an employee from the database. It queries the database for the nickname associated with the specified employee ID and returns it as a string.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose nickname is to be retrieved.</param>
        ''' <returns>The nickname of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNickname(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varNickname As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_nickname from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varNickname = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varNickname
        End Function

        ''' <summary>
        ''' This function retrieves the contract type ID of an employee from the database. It queries the database for the contract type ID associated with the specified employee ID and returns it as a string.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose contract type ID is to be retrieved.</param>
        ''' <returns>The contract type ID of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetContractTypeID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varContractTypeID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_contracttype from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varContractTypeID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varContractTypeID
        End Function

        ''' <summary>
        ''' This function retrieves the contract type of an employee from the database. It queries the database for the contract type associated with the specified employee ID and returns it as a string.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose contract type is to be retrieved.</param>
        ''' <returns>The contract type of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetContractType(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varContractType As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select cp.contracttype_name from dbo.man_employee em inner join dbo.[[man]]contracttype] cp on cp.contracttype_id = em.employee_contracttype " &
                                                    "where (em.employee_id = '{0}')", rowid)

            varContractType = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varContractType
        End Function

        ''' <summary>
        ''' This function checks if an employee is active. It queries the database for the active status of the specified employee and returns True if the employee is active, or False if the employee is not active.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose active status is to be retrieved.</param>
        ''' <returns>True if the employee is active, False otherwise.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetActiveEmployee(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As Boolean
            Dim varActiveEmployee As Boolean = False

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_active from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varActiveEmployee = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)

            Return varActiveEmployee
        End Function

        ''' <summary>
        ''' This function retrieves the gender of an employee from the database. It queries the database for the gender associated with the specified employee ID and returns it as a string. If an error occurs during the query, it defaults to "MALE".
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="rowid">The ID of the employee whose gender is to be retrieved.</param>
        ''' <returns>The gender of the employee as a string.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetGender(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varGender As String

            Try
                varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_gender from dbo.man_employee em where (em.employee_id = '{0}')", rowid)
                varGender = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            Catch ex As Exception
                varGender = "MALE"
            End Try

            Return varGender
        End Function

        ''' <summary>
        ''' This function checks if an employee has a profile photo. It queries the database for the presence of a photo associated with the specified employee and returns True if a photo exists, or False if it does not.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="datasetname">The name of the dataset to fill with the query results.</param>
        ''' <param name="parametername">A dictionary of parameters for the query.</param>
        ''' <returns>True if the employee has a profile photo, False otherwise.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetIsHavePhoto(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet, parametername As Dictionary(Of String, Object)) As Boolean
            Dim varIsHavePhoto As Integer

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = $"select count(f.file_id) as total from db_universe_erp_file.dbo.sto_file f where (f.file_parent = '0') and (f.file_tag = 'EMPLOYEE-PROFILE-PHOTO');"
                varIsHavePhoto = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select {tAttachment.S}.{tAttachment.C_AttachmentId}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentModule}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentFileNameOriginal}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentFileNameStandard}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentExtension}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentUrl} ," &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentTag} , " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentProvider} " &
                                                   $"from {tAttachment.TableName} {tAttachment.S} " &
                                                   $"where {tAttachment.S}.{tAttachment.C_AttachmentParentId} = {tEmployee.P_EmployeeId} And " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentModule} = {tModule.P_ModuleId} And " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentTag} = 'EMPLOYEE-PROFILE-PHOTO'"
                varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, tAttachment.TableName, parametername)
            End If

            If datasetname.Tables(tAttachment.TableName).Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' Gets the photo of an employee based on the provided row ID. This function queries the database for the photo associated with the specified employee and returns it as an Image object. If the photo is not found or an error occurs, it returns Nothing.
        ''' </summary>
        ''' <param name="dataproperties">The data properties containing the database connection information.</param>
        ''' <param name="rowid">The row ID of the employee whose photo is to be retrieved.</param>
        ''' <returns>An Image object representing the employee's photo, or Nothing if not found or an error occurs.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetPhoto(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As System.Drawing.Image
            Dim varPhoto As System.Drawing.Image = Nothing
            Dim varBytes As Byte()

            Try
                varDatabaseRequestMssql2008(0).Query = $"select f.file_content from db_universe_erp_file.dbo.sto_file f where f.file_parent = '{rowid}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'"
                varBytes = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Byte())

                If Not IsNothing(varBytes) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(varBytes)
                End If

                Return varPhoto
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' This function checks if a personal ID number exists in the database. It constructs a SQL query to count the number of records with the specified personal ID number, considering whether the employee is new or existing. The function supports both MSSQL and MySQL database engines and returns 1 if the personal ID number exists, or 0 if it does not.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="personalidnumber">The personal ID number to check for existence.</param>
        ''' <returns>1 if the personal ID number exists, 0 if it does not.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsPersonalIdExist(dataproperties As LibApp.Ingrid.Global.Properties, personalidnumber As String) As Integer
            Dim varIsExist As Integer

            SetValue(dataproperties.AllParameters, tEmployee.P_EmployeePersonalIdNumber, personalidnumber)

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If dataproperties.EmployeeIsNew Then
                    varDatabaseRequestMssql2008(0).Query = "select count(em.employee_personalid) from dbo.man_employee em where em.employee_personalid = @EmployeePersonalId"
                Else
                    varDatabaseRequestMssql2008(0).Query = $"select count(em.employee_personalid) from man_employee em where (em.employee_personalid = @EmployeePersonalId and em.employee_id <> @EmployeeId)"
                End If
                varIsExist = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query, dataproperties.AllParameters))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If dataproperties.EmployeeIsNew Then
                    varDatabaseRequestMysql(0).Query = $"select count({tEmployee.S}.{tEmployee.C_EmployeePersonalIdNumber}) " &
                                                       $"from {tEmployee.TableName} {tEmployee.S} " &
                                                       $"where ( " &
                                                       $"({tEmployee.S}.{tEmployee.C_EmployeeClient} = {tClient.P_ClientId}) and " &
                                                       $"({tEmployee.S}.{tEmployee.C_EmployeePersonalIdNumber} = {tEmployee.P_EmployeePersonalIdNumber}))"
                Else
                    varDatabaseRequestMysql(0).Query = $"select count({tEmployee.S}.{tEmployee.C_EmployeePersonalIdNumber}) " &
                                                       $"from {tEmployee.TableName} {tEmployee.S} " &
                                                       $"where ( " &
                                                       $"({tEmployee.C_EmployeeClient} = {tClient.P_ClientId}) and " &
                                                       $"({tEmployee.S}.{tEmployee.C_EmployeePersonalIdNumber} = {tEmployee.P_EmployeePersonalIdNumber} and " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeeId} <> {tEmployee.P_EmployeeId}))"
                End If
                varIsExist = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters))
            End If

            If varIsExist > 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function

        ''' <summary>
        ''' This function checks if a position exists in the database. It constructs a SQL query to count the number of records with the specified position ID. The function supports the MSSQL database engine and returns True if the position exists, or False if it does not.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="positionid">The position ID to check for existence.</param>
        ''' <returns>True if the position exists, False if it does not.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsPositionExist(dataproperties As LibApp.Ingrid.Global.Properties, positionid As String) As Boolean
            Dim varIsExist As Integer

            varDatabaseRequestMssql2008(1).Query = $"select count(ps.position_id) as [rows] from dbo.man_position ps where (ps.position_id = '{positionid}')"
            varIsExist = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)

            If varIsExist = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' This function checks if an employee number is a duplicate in the database. It constructs a SQL query to count the number of records with the same employee number, considering whether the employee is new or existing. The function supports both MSSQL and MySQL database engines and returns 1 if a duplicate is found, or 0 if no duplicates exist.
        ''' </summary>
        ''' <param name="dataproperties">The properties of the database connection and employee information.</param>
        ''' <param name="employeenumber">The employee number to check for duplicates.</param>
        ''' <returns>1 if a duplicate is found, 0 if no duplicates exist.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsEmployeeNumberDuplicate(dataproperties As LibApp.Ingrid.Global.Properties, employeenumber As String) As Integer
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "where "
            SetValue(dataproperties.AllParameters, tEmployee.P_EmployeeNumber, employeenumber)

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If dataproperties.EmployeeIsNew Then
                    varWhere += $" (em.employee_number = @EmployeeNumber) and dp.departement_company = (select dp1.departement_company from dbo.man_position ps1 " &
                                $"inner join dbo.man_department dp1 on dp1.department_id = ps1.position_departement where ps1.position_id = @PositionId)"
                Else
                    varWhere += $" (em.employee_number = @EmployeeNumber) and dp.departement_company = (select dp1.departement_company from dbo.man_position ps1 " &
                                $"inner join dbo.man_department dp1 on dp1.department_id = ps1.position_departement where ps1.position_id = @PositionId) and (em.employee_id <> @EmployeeId)"
                End If

                varDatabaseRequestMssql2008(0).Query = $"select count(em.employee_id) as [rows] from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position " &
                                                   $"inner join dbo.man_department dp on dp.department_id = ps.position_departement {varWhere}"

                varIsDuplicate = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If dataproperties.EmployeeIsNew Then
                    varWhere += $"({tEmployee.C_EmployeeClient} = {tClient.P_ClientId}) and " &
                                $"({tEmployee.S}.{tEmployee.C_EmployeeNumber} = {tEmployee.P_EmployeeNumber})"
                Else
                    varWhere += $"({tEmployee.C_EmployeeClient} = {tClient.P_ClientId}) and " &
                                $"({tEmployee.S}.{tEmployee.C_EmployeeNumber} = {tEmployee.P_EmployeeNumber}) and " &
                                $"({tEmployee.S}.{tEmployee.C_EmployeeId} <> {tEmployee.P_EmployeeId})"
                End If

                varDatabaseRequestMysql(0).Query = $"select count ({tEmployee.S}.{tEmployee.C_EmployeeId}) as `rows` " &
                                                   $"from {tEmployee.TableName} {tEmployee.S} {varWhere}"
                varIsDuplicate = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters))
            End If

            If varIsDuplicate > 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function

        ''' <summary>
        ''' Inserts or updates employee data in the database based on the provided data properties and parameters. This function constructs SQL queries for inserting or updating employee records, depending on whether the employee is new or existing. It supports both MSSQL and MySQL database engines and returns a boolean indicating the success of the operation.
        ''' </summary>
        ''' <param name="dataproperties">Properties containing employee data and database connection information.</param>
        ''' <param name="parametername">Dictionary containing parameter names and their corresponding values.</param>
        ''' <returns>Boolean indicating the success of the operation.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Async Function PushData(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object)) As Task(Of Boolean)
            Dim varSuccess As Boolean = False
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If dataproperties.EmployeeIsNew Then
                        SetValue(dataproperties.AllParameters, tEmployee.P_EmployeeToken, CMCv.Security.Encryption.MD5())
                        varDatabaseRequestMssql2008(1).Query = $"insert into dbo.man_employee(employee_id, employee_personalid, employee_position, employee_number, employee_fullname, employee_birthdate, employee_birthplace, " &
                                                               $"employee_address, employee_nickname, employee_active, employee_gender) " &
                                                               $"values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');"
                    Else
                        varDatabaseRequestMssql2008(1).Query = $"update dbo.man_employee set employee_position = '{0}', employee_number = '{1}', employee_fullname = '{2}', employee_birthdate = '{3}', employee_birthplace = '{4}', " &
                                                               $"employee_address = '{5}', employee_nickname = '{6}', employee_active = '{7}', employee_gender = '{8}', employee_personalid = '{9}' " &
                                                               $"where employee_id = '{10}';"
                    End If
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    If dataproperties.EmployeeIsNew Then
                        SetValue(dataproperties.AllParameters, tEmployee.P_EmployeeToken, CMCv.Security.Encryption.MD5())
                        varDatabaseRequestMysql(1).Query = $"insert into {tEmployee.TableName}({tEmployee.C_EmployeeToken}, " &
                                                           $"{tEmployee.C_EmployeePersonalIdNumber}, " &
                                                           $"{tEmployee.C_EmployeePosition}, " &
                                                           $"{tEmployee.C_EmployeeEmploymentType}, " &
                                                           $"{tEmployee.C_EmployeeNumber}, " &
                                                           $"{tEmployee.C_EmployeeFullName}, " &
                                                           $"{tEmployee.C_EmployeeBirthDate}, " &
                                                           $"{tEmployee.C_EmployeeBirthPlace}, " &
                                                           $"{tEmployee.C_EmployeeAddress}, " &
                                                           $"{tEmployee.C_EmployeeNickname}, " &
                                                           $"{tEmployee.C_EmployeeIsActive}, " &
                                                           $"{tEmployee.C_EmployeeGender}, " &
                                                           $"{tEmployee.C_EmployeeClient}) " &
                                                           $"values ({tEmployee.P_EmployeeToken}, " &
                                                           $"{tEmployee.P_EmployeePersonalIdNumber}, " &
                                                           $"{tPosition.P_PositionId}, " &
                                                           $"{tEmploymentType.P_EmploymentTypeId}, " &
                                                           $"{tEmployee.P_EmployeeNumber}, " &
                                                           $"{tEmployee.P_EmployeeFullName}, " &
                                                           $"{tEmployee.P_EmployeeBirthDate}, " &
                                                           $"{tEmployee.P_EmployeeBirthPlace}, " &
                                                           $"{tEmployee.P_EmployeeAddress}, " &
                                                           $"{tEmployee.P_EmployeeNickname}, " &
                                                           $"{tEmployee.P_EmployeeIsActive}, " &
                                                           $"{tEmployee.P_EmployeeGender}, " &
                                                           $"{tClient.P_ClientId});"

                        If varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters) Then
                            With dataproperties.DatasetCopy.Tables("SYSS_Editor").Rows(0)
                                If .Item($"{tSettings.C_SettingsStorageProvider}").ToString = "Disabled" Then
                                    Return True
                                End If
                                ' If the insert operation is successful, save photo meta to database
                                Dim imageFolder = CMCv.OperatingSystem.Folder.GetPhotoFolder
                                Dim img As New System.Drawing.Bitmap(dataproperties.EmployeePhoto)
                                SetValue(dataproperties.AllParameters, tAttachment.P_AttachmentExtension, System.Drawing.Imaging.ImageFormat.Jpeg)
                                Dim varDestinationPathAndFileName As String = $"client_data/{dataproperties.AllParameters(tClient.P_ClientId)}/EPLS/{dataproperties.AllParameters(tEmployee.P_EmployeeToken)}.{dataproperties.AllParameters(tAttachment.P_AttachmentExtension)}"
                                Dim url As String = $"{If(.Item(tSettings.C_SettingsApiServiceUrl) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiServiceUrl).ToString))}/{varDestinationPathAndFileName}"
                                url = url.Replace("https://", $"https://{If(.Item(tSettings.C_SettingsApiBucketName) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiBucketName).ToString))}.")
                                SetValue(dataproperties.AllParameters, tAttachment.P_AttachmentUrl, url)
                                SetValue(dataproperties.AllParameters, tSettings.P_SettingsStorageProvider, dataproperties.DatasetCopy.Tables("SYSS_Editor").Rows(0).Item($"{tSettings.C_SettingsStorageProvider}").ToString)
                                img.Save(imageFolder & $"\{dataproperties.AllParameters(tEmployee.P_EmployeeToken)}.{dataproperties.AllParameters(tAttachment.P_AttachmentExtension)}", System.Drawing.Imaging.ImageFormat.Jpeg)
                                varDatabaseRequestMysql(1).Query = $"insert into {tAttachment.TableName}( " &
                                                                   $"{tAttachment.C_AttachmentParentToken}, " &
                                                                   $"{tAttachment.C_AttachmentModule}, " &
                                                                   $"{tAttachment.C_AttachmentFileNameOriginal}, " &
                                                                   $"{tAttachment.C_AttachmentFileNameStandard}, " &
                                                                   $"{tAttachment.C_AttachmentExtension}, " &
                                                                   $"{tAttachment.C_AttachmentUrl}, " &
                                                                   $"{tAttachment.C_AttachmentTag}, " &
                                                                   $"{tAttachment.C_AttachmentProvider}) " &
                                                                   $"values (" &
                                                                   $"{tEmployee.P_EmployeeToken}, " &
                                                                   $"{tModule.P_ModuleId}, " &
                                                                   $"{tAttachment.P_AttachmentFileNameOriginal}, " &
                                                                   $"{tEmployee.P_EmployeeToken}, " &
                                                                   $"{tAttachment.P_AttachmentExtension}, " &
                                                                   $"{tAttachment.P_AttachmentUrl}, " &
                                                                   $"'EMPLOYEE-PROFILE-PHOTO', " &
                                                                   $"{tSettings.P_SettingsStorageProvider});"

                                If Not varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters) Then
                                    Decision(My.Application.Info.AssemblyName.ToUpper, "Employee record are saved but failed to store photo data", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                                    Return True
                                End If

                                Dim backblaze = LibAPI.Api.BackblazeB2.Create(If(.Item(tSettings.C_SettingsApiKey) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiKey).ToString)),
                                                                              If(.Item(tSettings.C_SettingsApiSecret) Is Nothing, "", CMCv.Security.Decrypt.Aes(CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiSecret).ToString))),
                                                                              If(.Item(tSettings.C_SettingsApiServiceUrl) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiServiceUrl).ToString)))
                                Dim result = Await backblaze.Upload(If(.Item(tSettings.C_SettingsApiBucketName) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiBucketName).ToString)),
                                                           varDestinationPathAndFileName,
                                                           imageFolder & $"\{dataproperties.AllParameters(tEmployee.P_EmployeeToken)}.{dataproperties.AllParameters(tAttachment.P_AttachmentExtension)}")
                                If result Then
                                    Return True
                                    backblaze.Dispose()
                                Else
                                    Decision(My.Application.Info.AssemblyName.ToUpper, "Employee record and photo data are saved but failed to upload photo data", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                                End If
                            End With
                        Else
                            Dim baseFolder = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ardhagp\Ingrid .NET")

                            Dim imageFolder = IO.Path.Combine(baseFolder, "Files.Image")
                            IO.Directory.CreateDirectory(imageFolder)

                            Dim img As New System.Drawing.Bitmap(dataproperties.EmployeePhoto)
                            img.Save(imageFolder & "\a.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

                            varDatabaseRequestMysql(1).Query = $"update man_employee Set employee_position = @PositionId, " &
                                                           $"employee_number = @EmployeeNumber, " &
                                                           $"employee_fullname = @EmployeeFullName, " &
                                                           $"employee_birthdate = @EmployeeBirthDate, " &
                                                           $"employee_birthplace = @EmployeeBirthPlace, " &
                                                           $"employee_address = @EmployeeAddress, " &
                                                           $"employee_nickname = @EmployeeNickname, " &
                                                           $"employee_isactive = @EmployeeIsActive, " &
                                                           $"employee_gender = @EmployeeGender, " &
                                                           $"employee_personalid = @EmployeePersonalId " &
                                                           $"where employee_id = @EmployeeId;"
                        End If
                    End If

                    'varDatabaseEngineMssql2008.PUSHDATA(varDatabaseRequestMssql2008(1).Query)
                    'Dim varQuery As String = String.Empty
                    'Dim varCommand As System.Data.SqlClient.SqlCommand = Nothing
                    'varCommand = New System.Data.SqlClient.SqlCommand

                    'If dataproperties.EmployeeIsForceChangePhoto Then
                    '    Dim varIsHavePhoto As Integer = GetIsHavePhoto(varDataProperties, varHash)
                    '    Dim varPhotoHash As String = CMCv.Security.Encrypt.MD5()

                    '    If varIsHavePhoto = 0 Then
                    '        varQuery = "insert into db_universe_erp_file.dbo.sto_file([file_id], file_parent, file_filetype, file_content, file_tag, file_datetime, file_attribute, file_uploader, file_parentdate) " &
                    '            "values(@ID, @ParentID, 'jpg', @FileContent, 'EMPLOYEE-PROFILE-PHOTO', @DateNow, 'module=EPLS;', @Uploader,@ParentDate);"
                    '    Else
                    '        varCommand = New System.Data.SqlClient.SqlCommand
                    '        varQuery = String.Format("update db_universe_erp_file.dbo.sto_file set file_content = @FileContent, file_datetime = GETDATE(), file_parentdate = GETDATE() where file_parent = '{0}' and " &
                    '                              "file_tag = 'EMPLOYEE-PROFILE-PHOTO';", varHash)
                    '    End If

                    '    varDatabaseRequestMssql2008(1).Query += varQuery

                    '    varCommand.Parameters.AddWithValue("@ID", varPhotoHash)
                    '    varCommand.Parameters.AddWithValue("@ParentID", varHash)
                    '    varCommand.Parameters.AddWithValue("@Uploader", creatoreditor)
                    '    varCommand.Parameters.AddWithValue("@ParentDate", Now.Date)

                    '    Dim varMemorystream = New MemoryStream()
                    '    Dim varImage As Image = employeephoto
                    '    Dim varPhotobyte As Byte() = Nothing

                    '    varImage.Save(varMemorystream, Imaging.ImageFormat.Jpeg) ', Row.Cells("file_content").Value)
                    '    varPhotobyte = varMemorystream.ToArray

                    '    Dim varImageparameter As New System.Data.SqlClient.SqlParameter("@FileContent", System.Data.SqlDbType.Image) With {
                    '    .Value = varPhotobyte
                    '    }
                    '    varCommand.Parameters.Add(varImageparameter)
                    '    varCommand.Parameters.AddWithValue("@DateNow", Now.Date)
                    'End If

                    'varCommand.CommandText = String.Format("RETRY: BEGIN TRANSACTION BEGIN TRY {0} COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK TRANSACTION	IF ERROR_NUMBER() = 1205 BEGIN WAITFOR DELAY '00:00:00.05' " &
                    '                                 "GOTO RETRY END END CATCH", varDatabaseRequestMssql2008(1).Query)

                    'varSuccess = varDatabaseEngineMssql2008.PushImage(varCommand)
                End If
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.ToString)
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
