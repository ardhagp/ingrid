Imports Mysqlx.Crud

Namespace CMDepls.Addins.Browse
    Public Class Position
        Shared varWhere As String = ""

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="datagrid"></param>
        ''' <param name="statusbar"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                RunMsSql(dataproperties, datagrid, statusbar)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                RunMySql(dataproperties, datagrid, statusbar)
            End If
        End Sub

        ''' <summary>
        ''' This method is used to run the SQL query for MSSQL database engine.
        ''' </summary>
        ''' <param name="dataproperties">The properties containing the database connection and other settings.</param>
        ''' <param name="datagrid">The datagrid control where the data will be displayed.</param>
        ''' <param name="statusbar">The statusbar control to show the status of the operation.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Sub RunMsSql(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt)
            If (dataproperties.EmployeePositionIsForceRefresh) Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company order by cm.company_code, dp.departement_code, ps.position_code")
            Else
                varWhere += " "
                varDatabaseRequestMssql2008(0).Query = $"select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company where (ps.position_id = '') or (cm.company_code like '%%') or (cm.company_name like '%%') or (dp.departement_code like '%%') or (dp.departement_name like '%%') or (ps.position_code like '%%') or (ps.position_name like '%%') order by cm.company_code, dp.departement_code, ps.position_code"
            End If
            varDatabaseRequestMssql2008(0).DataGrid = datagrid
            varDatabaseRequestMssql2008(0).StatusBar = statusbar
            varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TBrowsePosition")
        End Sub

        ''' <summary>
        ''' This method is used to run the MySQL query to retrieve position data and display it in the specified datagrid and statusbar. It constructs the SQL query based on whether a force refresh is required or if a search term is provided. The results are then fetched and displayed accordingly.
        ''' </summary>
        ''' <param name="dataproperties">The properties containing the database connection and other settings.</param>
        ''' <param name="datagrid">The datagrid control where the data will be displayed.</param>
        ''' <param name="statusbar">The statusbar control to show the status of the operation.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Sub RunMySql(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt)
            varWhere = $"where "
            If (dataproperties.EmployeePositionIsForceRefresh) Then
                varWhere += $"({tPosition.C_PositionClient} = {tClient.P_ClientId}) "
                varDatabaseRequestMysql(0).Query = $"select {tPosition.S}.{tPosition.C_PositionId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionCode}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionName} " &
                                                   $"from {tPosition.TableName} {tPosition.S} " &
                                                   $"inner join {tDepartment.TableName} {tDepartment.S} on {tDepartment.S}.{tDepartment.C_DepartmentId} = {tPosition.S}.{tPosition.C_PositionDepartment} " &
                                                   $"inner join {tCompany.TableName} {tCompany.S} on {tCompany.S}.{tCompany.C_CompanyId} = {tDepartment.S}.{tDepartment.C_DepartmentCompany} " &
                                                   $"{varWhere} " &
                                                   $"order by {tCompany.S}.{tCompany.C_CompanyCode}, {tDepartment.S}.{tDepartment.C_DepartmentCode}, {tPosition.S}.{tPosition.C_PositionCode}"
            Else
                varWhere += $"({tPosition.C_PositionClient} = {tClient.P_ClientId}) and " &
                            $"(({tPosition.S}.{tPosition.C_PositionCode} = {tPosition.P_PositionSearch}) or " &
                            $"({tCompany.S}.{tCompany.C_CompanyCode} like concat('%',{tPosition.P_PositionSearch},'%')) or " &
                            $"({tCompany.S}.{tCompany.C_CompanyName} like concat('%',{tPosition.P_PositionSearch},'%')) or " &
                            $"({tDepartment.S}.{tDepartment.C_DepartmentCode} like concat('%',{tPosition.P_PositionSearch},'%')) or " &
                            $"({tDepartment.S}.{tDepartment.C_DepartmentName} like concat('%',{tPosition.P_PositionSearch},'%')) or " &
                            $"({tPosition.S}.{tPosition.C_PositionCode} like concat('%',{tPosition.P_PositionSearch},'%')) or " &
                            $"({tPosition.S}.{tPosition.C_PositionName} like concat('%',{tPosition.P_PositionSearch},'%'))) "

                varDatabaseRequestMysql(0).Query = $"select {tPosition.S}.{tPosition.C_PositionId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionCode}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionName} " &
                                                   $"from {tPosition.TableName} {tPosition.S} " &
                                                   $"inner join {tDepartment.TableName} {tDepartment.S} on {tDepartment.S}.{tDepartment.C_DepartmentId} = {tPosition.S}.{tPosition.C_PositionDepartment} " &
                                                   $"inner join {tCompany.TableName} {tCompany.S} on {tCompany.S}.{tCompany.C_CompanyId} = {tDepartment.S}.{tDepartment.C_DepartmentCompany} " &
                                                   $"{varWhere}" &
                                                   $"order by {tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionCode}"
            End If
            varDatabaseRequestMysql(0).DataGrid = datagrid
            varDatabaseRequestMysql(0).StatusBar = statusbar
            varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TBrowsePosition", dataproperties.AllParameters)
        End Sub
    End Class

    Public Class EmploymentType
        Shared varWhere As String = ""
        ''' <summary>
        ''' This method is used to display employment type data in the specified datagrid and statusbar. It checks the database engine specified in the dataproperties and calls the appropriate method to retrieve and display the data based on whether it is MSSQL or MySQL.
        ''' </summary>
        ''' <param name="dataproperties">The properties containing the database connection and other settings.</param>
        ''' <param name="datagrid">The datagrid control where the data will be displayed.</param>
        ''' <param name="statusbar">The statusbar control to show the status of the operation.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                RunMsSql(dataproperties, datagrid, statusbar)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                RunMySql(dataproperties, datagrid, statusbar)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Sub RunMsSql(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt)
            varWhere = "where "
            If dataproperties.EmploymentTypeIsForceRefresh Then

            Else

            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Sub RunMySql(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt)
            varWhere = "where "
            If dataproperties.EmploymentTypeIsForceRefresh Then
                varWhere += $"({tPosition.C_PositionClient} = {tClient.P_ClientId}) "
                varDatabaseRequestMysql(0).Query = $"select {tPosition.S}.{tPosition.C_PositionId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionCode}, " &
                                                   $"{tPosition.S}.{tPosition.C_PositionName} " &
                                                   $"from {tPosition.TableName} {tPosition.S} " &
                                                   $"inner join {tDepartment.TableName} {tDepartment.S} on {tDepartment.S}.{tDepartment.C_DepartmentId} = {tPosition.S}.{tPosition.C_PositionDepartment} " &
                                                   $"inner join {tCompany.TableName} {tCompany.S} on {tCompany.S}.{tCompany.C_CompanyId} = {tDepartment.S}.{tDepartment.C_DepartmentCompany} " &
                                                   $"{varWhere} " &
                                                   $"order by {tCompany.S}.{tCompany.C_CompanyCode}, {tDepartment.S}.{tDepartment.C_DepartmentCode}, {tPosition.S}.{tPosition.C_PositionCode}"
            Else

            End If
        End Sub
    End Class
End Namespace
