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
                    varWhere = $""
                Else
                    varWhere += $"cm.company_code like '%{find.XOSqlText}%' or dp.department_code like '%{find.XOSqlText}%' or ps.position_code like '%{find.XOSqlText}%' or em.employee_number = '{find.XOSqlText}' or em.employee_fullname like '%{find.XOSqlText}%' or " &
                                $"em.employee_nickname like '%{find.XOSqlText}%'"
                End If
                varDatabaseRequestMysql(0).Query = $"select em.employee_id, cm.company_code, cm.company_name, " &
                                                   $"dp.department_code, dp.department_name, ps.position_code, ps.position_name, " &
                                                   $"(select et.employmenttype_name from man_employmenttype et where et.employmenttype_id = em.employee_employmenttype) as `employmenttype_name`, " &
                                                   $"em.employee_number, " &
                                                   $"em.employee_fullname, " &
                                                   $"em.employee_nickname, " &
                                                   $"em.employee_gender, " &
                                                   $"(case em.employee_isactive when 0 then 'No' when 1 then 'Yes' end) as `employee_isactive` " &
                                                   $"From man_employee em " &
                                                   $"inner Join man_position ps on ps.position_id = em.employee_position " &
                                                   $"inner Join man_department dp on dp.department_id = ps.position_department " &
                                                   $"inner Join man_company cm On cm.company_id = dp.department_company {varWhere} " &
                                                   $"order by cm.company_code, dp.department_code, ps.position_code, em.employee_fullname"

                varDatabaseRequestMysql(0).DataGrid = grid
                varDatabaseRequestMysql(0).StatusBar = status
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TEmployee")
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
                    varDatabaseRequestMysql(1).Query = $"delete from man_employee where (employee_id = @EmployeeId)"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
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
        ReadOnly varImage As New CMCv.ImageEditor.Proccessor.Compress

        Private Const pEmployeeToken As String = "@EmployeeToken"

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
                varDatabaseRequestMysql(0).Query = $"select em.employee_id, cm.company_id, cm.company_code, cm.company_name, " &
                                                   $"dp.department_id, dp.department_code, dp.department_name, " &
                                                   $"ps.position_id, ps.position_code, ps.position_name, " &
                                                   $"(select et.employmenttype_name from man_employmenttype et where et.employmenttype_id = em.employee_employmenttype) as `employmenttype_name`, " &
                                                   $"em.employee_personalidnumber, " &
                                                   $"em.employee_number, " &
                                                   $"em.employee_fullname, " &
                                                   $"em.employee_nickname, " &
                                                   $"em.employee_gender, " &
                                                   $"em.employee_birthdate, " &
                                                   $"em.employee_birthplace, " &
                                                   $"em.employee_address, " &
                                                   $"em.employee_employmenttype, " &
                                                   $"em.employee_isactive " &
                                                   $"from man_employee em " &
                                                   $"inner join man_position ps on ps.position_id = em.employee_position " &
                                                   $"inner join man_department dp on dp.department_id = ps.position_department " &
                                                   $"inner join man_company cm on cm.company_id = dp.department_company " &
                                                   $"where em.employee_id = @EmployeeId " &
                                                   $"order by em.employee_id"
                varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, "EPLS_Editor", dataproperties.AllParameters)
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
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetAddress(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varBirthPlace As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select e.employee_address from dbo.man_employee e where e.employee_id = '{0}'", rowid)

            varBirthPlace = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varBirthPlace
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNumber(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varEmployeeNumber As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_number from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varEmployeeNumber
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeFullName(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varEmployeeName As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_fullname from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varEmployeeName = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varEmployeeName
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNickname(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varNickname As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_nickname from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varNickname = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varNickname
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetContractTypeID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varContractTypeID As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_contracttype from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varContractTypeID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varContractTypeID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetContractType(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varContractType As String

            varDatabaseRequestMssql2008(1).Query = String.Format("select cp.contracttype_name from dbo.man_employee em inner join dbo.[[man]]contracttype] cp on cp.contracttype_id = em.employee_contracttype " &
                                                    "where (em.employee_id = '{0}')", rowid)

            varContractType = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

            Return varContractType
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetActiveEmployee(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As Boolean
            Dim varActiveEmployee As Boolean = False

            varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_active from dbo.man_employee em where (em.employee_id = '{0}')", rowid)

            varActiveEmployee = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)

            Return varActiveEmployee
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
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
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="datasetname"></param>
        ''' <param name="parametername"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetIsHavePhoto(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet, parametername As Dictionary(Of String, Object)) As Boolean
            Dim varIsHavePhoto As Integer

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = $"select count(f.file_id) as total from db_universe_erp_file.dbo.sto_file f where (f.file_parent = '0') and (f.file_tag = 'EMPLOYEE-PROFILE-PHOTO');"
                varIsHavePhoto = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select {tAttachment.S}.{tAttachment.C_AttachmentId}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentModule}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentFileName}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentExtension}, " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentUrl} ," &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentTag} , " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentProvider} " &
                                                   $"from {tAttachment.TableName} {tAttachment.S} " &
                                                   $"where {tAttachment.S}.{tAttachment.C_AttachmentParentId} = {tEmployee.P_EmployeeId} And " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentModule} = {tModule.P_ModuleId} And " &
                                                   $"{tAttachment.S}.{tAttachment.C_AttachmentTag} = 'EMPLOYEE-PROFILE-PHOTO'"
                varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, tAttachment.TableName, parametername)
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
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsPersonalIdExist(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsExist As Integer

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If dataproperties.EmployeeIsNew Then
                    varDatabaseRequestMssql2008(0).Query = "select count(em.employee_personalid) from dbo.man_employee em where em.employee_personalid = @EmployeePersonalId"
                Else
                    varDatabaseRequestMssql2008(0).Query = $"select count(em.employee_personalid) from man_employee em where (em.employee_personalid = @EmployeePersonalId and em.employee_id <> @EmployeeId)"
                End If
                varIsExist = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query, dataproperties.AllParameters), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If dataproperties.EmployeeIsNew Then
                    varDatabaseRequestMysql(0).Query = $"select count(em.employee_personalid) from dbo.man_employee em where em.employee_personalid = @EmployeePersonalId"
                Else
                    varDatabaseRequestMysql(0).Query = $"select count(em.employee_personalid) from man_employee em where (em.employee_personalid = @EmployeePersonalId and em.employee_id <> @EmployeeId)"
                End If
                varIsExist = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query, dataproperties.AllParameters), Integer)
            End If

            If varIsExist = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="positionid"></param>
        ''' <returns></returns>
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
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsEmployeeNumberDuplicate(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "where "

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
                    varWhere += $" em.employee_number = @EmployeeNumber"
                Else
                    varWhere += $" em.employee_number = @EmployeeNumber and em.employee_employeeid <> @EmployeeId"
                End If

                varDatabaseRequestMysql(0).Query = $"select count (em.employee_id) as `rows` from man_employee em {varWhere}"
                varIsDuplicate = CInt(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters))
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="parametername"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object)) As Boolean
            Dim varSuccess As Boolean = False
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If dataproperties.EmployeeIsNew Then
                        dataproperties.AllParameters.Remove(pEmployeeToken)
                        dataproperties.AllParameters.Add(pEmployeeToken, CMCv.Security.Encrypt.MD5())
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
                        varDatabaseRequestMysql(1).Query = $"insert into {tEmployee.TableName}({tEmployee.C_EmployeeToken}, " &
                                                           $"{tEmployee.C_EmployeePersonalIdNumber}, " &
                                                           $"{tEmployee.C_EmployeePosition}, " &
                                                           $"{tEmployee.C_EmployeeNumber}, " &
                                                           $"{tEmployee.C_EmployeeFullName}, " &
                                                           $"{tEmployee.C_EmployeeBirthDate}, " &
                                                           $"{tEmployee.C_EmployeeBirthPlace}, " &
                                                           $"{tEmployee.C_EmployeeAddress}, " &
                                                           $"{tEmployee.C_EmployeeNickname}, " &
                                                           $"{tEmployee.C_EmployeeIsActive}, " &
                                                           $"{tEmployee.C_EmployeeGender}) " &
                                                           $"values ({tEmployee.P_EmployeeToken}, " &
                                                           $"{tEmployee.P_EmployeePersonalIdNumber}, " &
                                                           $"{tEmployee.P_EmployeePosition}, " &
                                                           $"{tEmployee.P_EmployeeNumber}, " &
                                                           $"{tEmployee.P_EmployeeFullName}, " &
                                                           $"{tEmployee.P_EmployeeBirthDate}, " &
                                                           $"{tEmployee.P_EmployeeBirthPlace}, " &
                                                           $"{tEmployee.P_EmployeeAddress}, " &
                                                           $"{tEmployee.P_EmployeeNickname}, " &
                                                           $"{tEmployee.P_EmployeeIsActive}, " &
                                                           $"{tEmployee.P_EmployeeGender});"

                        If varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters) Then
                            ' If the insert operation is successful, save photo meta to database
                            varDatabaseRequestMysql(1).Query = $"insert into {tAttachment.S}.{tAttachment.C_AttachmentParentToken}, " &
                                                               $"{tAttachment.C_AttachmentModule}, " &
                                                               $"{tAttachment.C_AttachmentFileName}, " &
                                                               $"{tAttachment.C_AttachmentExtension}, " &
                                                               $"{tAttachment.C_AttachmentUrl}, " &
                                                               $"{tAttachment.C_AttachmentTag}, " &
                                                               $"{tAttachment.C_AttachmentProvider}) " &
                                                               $"values ({tEmployee.P_EmployeeToken}, " &
                                                               $"{tModule.P_ModuleId}, " &
                                                               $"@FileName, " &
                                                               $"@FileExtension, " &
                                                               $"@FileUrl, " &
                                                               $"'EMPLOYEE-PROFILE-PHOTO', " &
                                                               $"@Uploader);"

                        End If
                    Else
                            varDatabaseRequestMysql(1).Query = $"update man_employee set employee_position = @PositionId, " &
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

            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
