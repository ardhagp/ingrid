Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDcdin
    Public Class View
        Private Shared varQuery As String
        Private Shared consTableName As String = "CheckRelation"

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt)
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (dataproperties.DepartmentIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $" (c.company_code like '%{find.XOSQLText}%') or (d.department_code like '%{find.XOSQLText}%') or (d.department_name like '%{find.XOSQLText}%') or (d.department_description like '%{find.XOSQLText}%')"
                End If

                varDatabaseRequestMssql2008(0).Query = $"select d.department_id, c.company_code, d.department_code, d.department_name, d.department_description from dbo.man_department d inner join dbo.man_company c " &
                                                       $"on d.department_company = c.company_id {varWhere} order by c.company_code, d.department_code "

                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TDepartment")

            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSQLText = String.Empty) OrElse (dataproperties.DepartmentIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $" (c.company_code like '%{find.XOSQLText}%') or (d.department_code like '%{find.XOSQLText}%') or (d.department_name like '%{find.XOSQLText}%') or (d.department_description like '%{find.XOSQLText}%')"
                End If

                varDatabaseRequestMysql(0).Query = $"select d.department_id, c.company_code, d.department_code, d.department_name, d.department_description from man_department d inner join man_company c " &
                                                   $"on d.department_company = c.company_id {varWhere} order by c.company_code, d.department_code "

                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TDepartment")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckGranularity(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varHasChild As Boolean = True
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varQuery = $"SELECT now() as `timestamp`, (select count(*) from v_cdin_granularity_post where position_department = '{dataproperties.DepartmentId}' limit 0,1) as `relation1`;"
                    datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName)
                End If

                If datasetname.Tables(consTableName).Rows.Count > 0 Then
                    If Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The department has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1"))} related record(s) in [POST] Position module.", LibApp.Ingrid.Global.PopupType.Error, "", FRMdialogbox.MessageIcon.Error, FRMdialogbox.MessageTypes.OkOnly)
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
            Try
                If CheckGranularity(dataproperties, datasetname) Then
                    Return False
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"delete from dbo.man_department where (department_id = '{dataproperties.DepartmentId}')"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"delete from man_department where (department_id = '{dataproperties.DepartmentId}')"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request
        Private Shared varQuery As String
        Private Shared consTableName As String = "man_department"

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsDuplicate As Integer = 1
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If dataproperties.DepartmentId = "-1" Then
                    varWhere += $"(d.department_company = '{dataproperties.CompanyId}') and (d.department_code = '{dataproperties.DepartmentCode}')"
                Else
                    varWhere += $"(d.department_company = '{dataproperties.CompanyId}') and (d.department_code = '{dataproperties.DepartmentCode}') and (d.department_id <> '{dataproperties.DepartmentId}')"
                End If

                varDatabaseRequestMssql2008(1).Query = $"select count(d.department_id) as [rows] from dbo.man_department d {varWhere}"

                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If dataproperties.DepartmentId = "-1" Then
                    varWhere += $"(d.department_company = '{dataproperties.CompanyId}') and (d.department_code = '{dataproperties.DepartmentCode}')"
                Else
                    varWhere += $"(d.department_company = '{dataproperties.CompanyId}') and (d.department_code = '{dataproperties.DepartmentCode}') and (d.department_id <> '{dataproperties.DepartmentId}')"
                End If

                varDatabaseRequestMysql(1).Query = $"select count(d.department_id) as `rows` from man_department d {varWhere}"

                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Integer)
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(dataproperties As LibApp.Ingrid.Global.Properties, company As CMCv.UI.Control.cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_code] from dbo.man_company c order by c.company_code"
                varDatabaseRequestMssql2008(1).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = "select c.company_id, concat(c.company_code, ' - ', c.company_name) as company_code from man_company c order by c.company_code"
                varDatabaseRequestMysql(1).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TCompany")
            End If
            company.ValueMember = "company_id"
            company.DisplayMember = "company_code"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetDepartmentProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varQuery = $"select d.department_id, d.department_company, d.department_code, d.department_name, d.department_description from dbo.man_department d where d.department_id = '{dataproperties.DepartmentId}'"
                datasetname = varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varQuery = $"select d.department_id, d.department_company, d.department_code, d.department_name, d.department_description from man_department d where d.department_id = '{dataproperties.DepartmentId}'"
                datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean
            Dim varHash As String = CMCv.Security.Encrypt.MD5()
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If dataproperties.DepartmentIsNew Then
                        varDatabaseRequestMssql2008(1).Query = $"insert into dbo.man_department(department_id, department_company, department_code, department_name, department_description) " &
                                                               $"values('{varHash}', '{dataproperties.CompanyId}', '{dataproperties.DepartmentCode}', '{dataproperties.DepartmentName}', '{dataproperties.DepartmentDescription}')"
                    Else
                        varDatabaseRequestMssql2008(1).Query = $"update dbo.man_department set department_company = '{dataproperties.CompanyId}', department_code = '{dataproperties.DepartmentCode}', department_name = '{dataproperties.DepartmentName}', department_description = '{dataproperties.DepartmentDescription}' " &
                                                               $"where department_id = '{dataproperties.DepartmentId}'"
                    End If
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    If dataproperties.DepartmentId = "-1" Then
                        varDatabaseRequestMysql(1).Query = $"insert into man_department(department_id, department_company, department_code, department_name, department_description) " &
                                                           $"values('{varHash}', '{dataproperties.CompanyId}', '{dataproperties.DepartmentCode}', '{dataproperties.DepartmentName}', '{dataproperties.DepartmentDescription}')"
                    Else
                        varDatabaseRequestMysql(1).Query = $"update man_department set department_company = '{dataproperties.CompanyId}', department_code = '{dataproperties.DepartmentCode}', department_name = '{dataproperties.DepartmentName}', department_description = '{dataproperties.DepartmentDescription}' " &
                                                           $"where department_id = '{dataproperties.DepartmentId}'"
                    End If
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
