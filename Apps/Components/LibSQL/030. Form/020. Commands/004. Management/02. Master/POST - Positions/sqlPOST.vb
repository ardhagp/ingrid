Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDpost
    Public Class View
        Private Shared varQuery As String = String.Empty
        Private Shared consTableName As String = "CheckRelation"

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, grid As CMCv.UI.Control.dgn, status As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt)
            'ReDim varDatabaseRequestMssql2008(2)
            Dim varWhere As String = "where "

            If (find.XOSQLText = String.Empty) AndAlso (dataproperties.EmployeePositionIsForceRefresh) Then
                varWhere = $""
            Else
                varWhere += $"(c.company_code Like '%{find.XOSQLText}%') or (d.department_code like '%{find.XOSQLText}%') or (ps.position_code like '%{find.XOSQLText}%') or (ps.position_name like '%{find.XOSQLText}%')"
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_code, d.department_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from dbo.man_position ps " &
                                                    "inner join dbo.man_department d on d.department_id = ps.position_department inner join dbo.man_company c on c.company_id = d.department_company {0} " &
                                                    "order by c.company_code, d.department_code, ps.position_code", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = grid
                varDatabaseRequestMssql2008(0).StatusBar = status
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TPositions")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select c.company_code, d.department_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from man_position ps " &
                                                       $"inner join man_department d on d.department_id = ps.position_department inner join man_company c on c.company_id = d.department_company {varWhere} " &
                                                       $"order by c.company_code, d.department_code, ps.position_code"

                varDatabaseRequestMysql(0).DataGrid = grid
                varDatabaseRequestMysql(0).StatusBar = status
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TPositions")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckGranularity(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varHasChild As Boolean = True
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varQuery = $"SELECT now() as `timestamp`, (select count(*) from v_post_granularity_epls where employee_position = @PositionId limit 0,1) as `relation1`;"
                    datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName)
                End If

                If datasetname.Tables(consTableName).Rows.Count > 0 Then
                    If Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The position has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1"))} related record(s) in [EPLS] Employee module.", LibApp.Ingrid.Global.PopupType.Error, "", FRMdialogbox.MessageIcon.Error, FRMdialogbox.MessageTypes.OkOnly)
                        varHasChild = True
                    Else
                        varHasChild = False
                    End If
                End If
                Return varHasChild
            Catch ex As Exception
                Return True
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varSuccess As Boolean = False

            If CheckGranularity(dataproperties, datasetname) Then
                Return False
            End If

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"delete from dbo.man_position where position_id = @PositionId"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"delete from man_position where position_id = @PositionId"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        Private Shared consTableName As String = "man_position"
        Private Shared varQuery As String = String.Empty

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(dataproperties As LibApp.Ingrid.Global.Properties, company As CMCv.UI.Control.cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as [company_name] from dbo.man_company c order by c.company_code"
                varDatabaseRequestMssql2008(1).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = "select c.company_id, concat(c.company_code, ' - ', c.company_name) as `company_name` from man_company c order by c.company_code"
                varDatabaseRequestMysql(1).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TCompany")
            End If
            company.ValueMember = "company_id"
            company.DisplayMember = "company_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillDepartement(dataproperties As LibApp.Ingrid.Global.Properties, department As CMCv.UI.Control.cbo, company As CMCv.UI.Control.cbo)
            Dim varDepartment As String = String.Empty

            If company.Items.Count <> 0 Then
                varDepartment = company.SelectedValue.ToString
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = $"select d.department_id, (d.department_code + ' - ' + d.department_name) as [departement_code] from dbo.man_department d where d.department_company = '{varDepartment}' " &
                                                       $"order by d.department_code"
                varDatabaseRequestMssql2008(1).Dropdown = department
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "Departement")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select d.department_id, concat(d.department_code, ' - ', d.department_name) as `departement_code` from man_department d where d.department_company = '{varDepartment}' " &
                                                   $"order by d.department_code"
                varDatabaseRequestMysql(1).Dropdown = department
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "Departement")
            End If
            department.ValueMember = "department_id"
            department.DisplayMember = "departement_code"
        End Sub

        <SupportedOSPlatform("Windows")>
        Public Shared Sub GetPositionProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varQuery = $"SELECT ps.position_id, d.department_company, ps.position_department, ps.position_code, ps.position_name, ps.position_description, ps.position_parent " &
                           $"FROM dbo.man_position ps inner join dbo.man_department d on d.department_id = ps.position_department " &
                           $"WHERE ps.position_id = @PositionId;"
                datasetname = varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varQuery, datasetname, "man_position")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varQuery = $"SELECT ps.position_id, d.department_company, ps.position_department, ps.position_code, ps.position_name, ps.position_description, ps.position_parent " &
                           $"FROM man_position ps inner join man_department d on d.department_id = ps.position_department " &
                           $"WHERE ps.position_id = @PositionId;"
                datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varQuery, datasetname, "man_position", dataproperties.AllParameters)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "WHERE "

            If dataproperties.EmployeePositionIsNew Then
                varWhere += $"(ps.position_department = @DepartmentId) and (ps.position_code = @PositionCode)"
            Else
                varWhere += $"(ps.position_department = @DepartmentId) and (ps.position_code = @PositionCode and ps.position_id <> @PositionId)"
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = $"select (ps.position_id) as [rows] from dbo.man_position ps {varWhere}"
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select (ps.position_id) as `rows` from man_position ps {varWhere}"
                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters), Integer)
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If dataproperties.EmployeePositionIsNew Then
                        varDatabaseRequestMssql2008(1).Query = $"insert into dbo.man_position(position_department, position_code, position_name, position_description) " &
                                                               $"values (@DepartmentId, @PositionCode, @PositionName, @PositionDescription)"
                    Else
                        varDatabaseRequestMssql2008(1).Query = $"update dbo.man_position set position_department = @DepartmentId, position_code = @PositionCode, position_name = @PositionName, position_description = @PositionDescription " &
                                                               $"where position_id = @PositionId"
                    End If
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    If dataproperties.EmployeePositionIsNew Then
                        varDatabaseRequestMysql(1).Query = $"insert into man_position(position_department, position_code, position_name, position_description) " &
                                                           $"values (@DepartmentId, @PositionCode, @PositionName, @PositionDescription)"
                    Else
                        varDatabaseRequestMysql(1).Query = $"update man_position set position_department = @DepartmentId, position_code = @PositionCode, position_name = @PositionName, position_description = @PositionDescription, position_datelastmodified = now() " &
                                                           $"where position_id = @PositionId"
                    End If
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class
End Namespace
