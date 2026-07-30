Namespace CMDcdin
    Public Class View
        Private Shared varQuery As String
        Private Shared ReadOnly consTableName As String = "CheckRelation"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt, find As CMCv.UI.Control.Txt)
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.DepartmentIsForceRefresh) Then
                    varWhere += $"{tDepartment.C_DepartmentClient} = {tDepartment.P_DepartmentClient}"
                Else
                    varWhere += $"{tDepartment.C_DepartmentClient} = {tDepartment.P_DepartmentClient} and (c.company_code like '%{find.XOSqlText}%') or (d.department_code like '%{find.XOSqlText}%') or (d.department_name like '%{find.XOSqlText}%') or (d.department_description like '%{find.XOSqlText}%')"
                End If

                varDatabaseRequestMssql2008(0).Query = $"select d.department_id, " &
                                                       $"c.company_code, " &
                                                       $"d.department_code, " &
                                                       $"d.department_name, " &
                                                       $"d.department_description " &
                                                       $"from dbo.man_department d " &
                                                       $"inner join dbo.man_company c " &
                                                       $"on d.department_company = c.company_id {varWhere} order by c.company_code, d.department_code "

                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TDepartment")

            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.DepartmentIsForceRefresh) Then
                    varWhere += $"({tDepartment.C_DepartmentClient} = {tClient.P_ClientId})"
                Else
                    varWhere += $"({tDepartment.C_DepartmentClient} = {tClient.P_ClientId}) and (c.company_code Like '%{find.XOSqlText}%') or (d.department_code like '%{find.XOSqlText}%') or (d.department_name like '%{find.XOSqlText}%') or (d.department_description like '%{find.XOSqlText}%')"
                End If

                varDatabaseRequestMysql(0).Query = $"select {tDepartment.S}.{tDepartment.C_DepartmentId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentDescription} " &
                                                   $"from {tDepartment.TableName} {tDepartment.S} " &
                                                   $"inner join {tCompany.TableName} {tCompany.S} " &
                                                   $"on {tDepartment.S}.{tDepartment.C_DepartmentCompany} = {tCompany.S}.{tCompany.C_CompanyId} {varWhere} " &
                                                   $"order by {tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tDepartment.S}.{tDepartment.C_DepartmentCode} "

                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TDepartment", dataproperties.AllParameters)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function CheckGranularity(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varHasChild As Boolean = True
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varQuery = $"select now() as `timestamp`, " &
                               $"(select count(*) " &
                               $"from " &
                               $"v_cdin_granularity_post " &
                               $"where " &
                               $"{tPosition.C_PositionDepartment} = {tDepartment.P_DepartmentId} limit 0,1) as `relation1`;"
                    datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName, dataproperties.AllParameters)
                End If

                If datasetname.Tables(consTableName).Rows.Count > 0 Then
                    If Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The department has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1"))} related record(s) in [POST] Position module.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
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

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varSuccess As Boolean = False
            Try
                If CheckGranularity(dataproperties, datasetname) Then
                    Return False
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"delete from dbo.man_department where (department_id = @DepartmentId)"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"delete from {tDepartment.TableName} " &
                                                       $"where ({tDepartment.C_DepartmentId} = {tDepartment.P_DepartmentId})"
                    varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        Private Shared varQuery As String

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsDuplicate As Integer = 1
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If dataproperties.DepartmentIsNew Then
                    varWhere += $"(d.department_company = @CompanyId) and (d.department_code = @DepartmentCode)"
                Else
                    varWhere += $"(d.department_company = @CompanyId) and (d.department_code = @DepartmentCode) and (d.department_id <> @DepartmentId)"
                End If

                varDatabaseRequestMssql2008(1).Query = $"select count(d.department_id) as [rows] from dbo.man_department d {varWhere}"

                varIsDuplicate = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If dataproperties.DepartmentIsNew Then
                    varWhere += $"({tDepartment.S}.{tDepartment.C_DepartmentCompany} = {tCompany.P_CompanyId}) and ({tDepartment.S}.{tDepartment.C_DepartmentCode} = {tDepartment.P_DepartmentCode}) and ({tDepartment.C_DepartmentClient} = {tClient.P_ClientId})"
                Else
                    varWhere += $"({tDepartment.S}.{tDepartment.C_DepartmentCompany} = {tCompany.P_CompanyId}) and ({tDepartment.S}.{tDepartment.C_DepartmentCode} = {tDepartment.P_DepartmentCode}) and ({tDepartment.C_DepartmentClient} = {tClient.P_ClientId} and {tDepartment.S}.{tDepartment.C_DepartmentId} <> {tDepartment.P_DepartmentId})"
                End If

                varDatabaseRequestMysql(1).Query = $"select count({tDepartment.S}.{tDepartment.C_DepartmentId}) as `rows` " &
                                                   $"from {tDepartment.TableName} {tDepartment.S} {varWhere}"

                varIsDuplicate = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters))
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(dataproperties As LibApp.Ingrid.Global.Properties, company As CMCv.UI.Control.Cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_code] from dbo.man_company c order by c.company_code"
                varDatabaseRequestMssql2008(1).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select {tCompany.S}.{tCompany.C_CompanyId}, " &
                                                   $"concat({tCompany.S}.{tCompany.C_CompanyCode}, ' - ', {tCompany.S}.{tCompany.C_CompanyName}) as company_code " &
                                                   $"from {tCompany.TableName} {tCompany.S} " &
                                                   $"where {tCompany.S}.{tCompany.C_CompanyClient} = {tClient.P_ClientId} " &
                                                   $"order by {tCompany.S}.{tCompany.C_CompanyCode}"
                varDatabaseRequestMysql(1).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TCompany", dataproperties.AllParameters)
            End If
            company.ValueMember = $"{tCompany.C_CompanyId}"
            company.DisplayMember = $"{tCompany.C_CompanyCode}"
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub GetDepartmentProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varQuery = $"select d.department_id, d.department_company, d.department_code, d.department_name, d.department_description from dbo.man_department d where d.department_id = @DepartmentId"
                datasetname = varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varQuery, datasetname, tDepartment.TableName)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varQuery = $"select {tDepartment.S}.{tDepartment.C_DepartmentId}, " &
                           $"{tDepartment.S}.{tDepartment.C_DepartmentCompany}, " &
                           $"{tDepartment.S}.{tDepartment.C_DepartmentCode}, " &
                           $"{tDepartment.S}.{tDepartment.C_DepartmentName}, " &
                           $"{tDepartment.S}.{tDepartment.C_DepartmentDescription} " &
                           $"from {tDepartment.TableName} {tDepartment.S} " &
                           $"where {tDepartment.S}.{tDepartment.C_DepartmentId} = {tDepartment.P_DepartmentId}"
                datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varQuery, datasetname, tDepartment.TableName, dataproperties.AllParameters)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If dataproperties.DepartmentIsNew Then
                        varDatabaseRequestMssql2008(1).Query = $"insert into dbo.man_department(department_company, department_code, department_name, department_description) " &
                                                               $"values(@CompanyId, @DepartmentCode, @DepartmentName, @DepartmentDescription)"
                    Else
                        varDatabaseRequestMssql2008(1).Query = $"update dbo.man_department set department_company = @CompanyId, department_code = @DepartmentCode, department_name = @DepartmentName, department_description = @DepartmentDescription, department_datelastmodified = now() " &
                                                               $"where department_id = @DepartmentId"
                    End If
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    If dataproperties.DepartmentIsNew Then
                        varDatabaseRequestMysql(1).Query = $"insert into {tDepartment.TableName}( " &
                                                           $"{tDepartment.C_DepartmentCompany}, " &
                                                           $"{tDepartment.C_DepartmentCode}, " &
                                                           $"{tDepartment.C_DepartmentName}, " &
                                                           $"{tDepartment.C_DepartmentDescription}, " &
                                                           $"{tDepartment.C_DepartmentClient}) " &
                                                           $"values(" &
                                                           $"{tCompany.P_CompanyId}, " &
                                                           $"{tDepartment.P_DepartmentCode}, " &
                                                           $"{tDepartment.P_DepartmentName}, " &
                                                           $"{tDepartment.P_DepartmentDescription}, " &
                                                           $"{tClient.P_ClientId})"
                    Else
                        varDatabaseRequestMysql(1).Query = $"update {tDepartment.TableName} set " &
                                                           $"{tDepartment.C_DepartmentCompany} = {tCompany.P_CompanyId}, " &
                                                           $"{tDepartment.C_DepartmentCode} = {tDepartment.P_DepartmentCode}, " &
                                                           $"{tDepartment.C_DepartmentName} = {tDepartment.P_DepartmentName}, " &
                                                           $"{tDepartment.C_DepartmentDescription} = {tDepartment.P_DepartmentDescription}, " &
                                                           $"{tDepartment.C_DepartmentDateLastModified} = now() " &
                                                           $"where {tDepartment.C_DepartmentId} = {tDepartment.P_DepartmentId}"
                    End If
                    varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
