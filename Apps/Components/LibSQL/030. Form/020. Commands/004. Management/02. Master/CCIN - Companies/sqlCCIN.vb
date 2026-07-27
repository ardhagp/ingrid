Namespace CMDccin
    Public Class View
        Private Shared ReadOnly consTableName As String = "CheckRelation"
        Private Shared varQuery As String

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt, find As CMCv.UI.Control.Txt)
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.CompanyIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $" (c.company_code ='{find.XOSqlText}') or (c.company_name like '%{find.XOSqlText}%') or (c.company_searchterm2 like '%{find.XOSqlText}%') or (c.company_searchterm1 like '%{find.XOSqlText}%') or (c.company_description " &
                                $"like '%{find.XOSqlText}%')"
                End If
                varDatabaseRequestMssql2008(0).Query = $"SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.man_company c {varWhere} " &
                                                       $"ORDER BY c.company_code"
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.CompanyIsForceRefresh) Then
                    varWhere += $"({tCompany.S}.{tCompany.C_CompanyClient} = {tClient.P_ClientId})"
                Else
                    varWhere += $"({tCompany.S}.{tCompany.C_CompanyClient} = {tClient.P_ClientId}) and ({tCompany.S}.{tCompany.C_CompanyCode} ='{find.XOSqlText}') or ({tCompany.S}.{tCompany.C_CompanyName} like '%{find.XOSqlText}%') or ({tCompany.S}.{tCompany.C_CompanySearchTerm1} like '%{find.XOSqlText}%') or ({tCompany.S}.{tCompany.C_CompanySearchTerm2} like '%{find.XOSqlText}%') or ({tCompany.S}.{tCompany.C_CompanyDescription} " &
                                $"like '%{find.XOSqlText}%')"
                End If
                varDatabaseRequestMysql(0).Query = $"select {tCompany.S}.{tCompany.C_CompanyId}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanySearchTerm1}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanySearchTerm2}, " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyDescription} " &
                                                   $"from {tCompany.TableName} {tCompany.S} {varWhere} " &
                                                   $"order by " &
                                                   $"{tCompany.S}.{tCompany.C_CompanyCode}"
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TCompany", dataproperties.AllParameters)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function CheckGranularity(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varHasChild As Boolean = True
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varQuery = $"select now() as `timestamp`, (select count(*) from v_ccin_granularity_cdin where department_company = {tCompany.P_CompanyId} limit 0,1) as `relation1`, (select count(*) from v_ccin_granularity_plnt where plant_company = {tCompany.P_CompanyId} limit 0,1) as `relation2`;"
                    datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName, dataproperties.AllParameters)
                End If

                If datasetname.Tables(consTableName).Rows.Count > 0 Then
                    If Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The company has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1"))} related record(s) in [CDIN] Department module.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                        varHasChild = True
                    ElseIf Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation2")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The company has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation2"))} related record(s) in [PLNT] Plant module.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
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
            Dim varSuccess As Boolean
            Try
                If CheckGranularity(dataproperties, datasetname) Then
                    Return False
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = $"delete from dbo.man_company where company_id=@CompanyId"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"delete from {tCompany.TableName} " &
                                                       $"where {tCompany.C_CompanyId} = {tCompany.P_CompanyId}"
                    varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function CountRecords(dataproperties As LibApp.Ingrid.Global.Properties) As Integer
            Dim varCount As Integer = 0
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = $""
                varCount = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select count({tCompany.S}.{tCompany.C_CompanyId}) as `count` " &
                                                   $"from {tCompany.TableName} {tCompany.S}"
                varCount = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
            End If
            Return varCount
        End Function
    End Class

    Public Class Editor
        Private Shared varQuery As String

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsDuplicate As Integer
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If dataproperties.CompanyIsNew Then
                    varWhere += $" c.company_code = @CompanyCode"
                Else
                    varWhere += $" c.company_code = @CompanyCode and c.company_id <> @CompanyId"
                End If
                varDatabaseRequestMssql2008(1).Query = $"select count(c.company_id) as [isduplicate] from dbo.man_company c {varWhere}"
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If dataproperties.CompanyIsNew Then
                    varWhere += $" {tCompany.S}.{tCompany.C_CompanyCode} = {tCompany.P_CompanyCode}"
                Else
                    varWhere += $" {tCompany.S}.{tCompany.C_CompanyCode} = {tCompany.P_CompanyCode} and {tCompany.S}.{tCompany.C_CompanyId} <> {tCompany.P_CompanyId}"
                End If
                varDatabaseRequestMysql(1).Query = $"select count({tCompany.S}.{tCompany.C_CompanyId}) as `isduplicate` " &
                                                   $"from {tCompany.TableName} {tCompany.S} {varWhere}"
                varIsDuplicate = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters))
            End If
            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean ', databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, companycode As String, companyname As String, searchterm1 As String, searchterm2 As String, description As String, Optional rowid As String = "-1") As Boolean
            Try
                If dataproperties.CompanyIsNew AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    dataproperties.AllParameters.Add("@CompanyToken", CMCv.Security.Encryption.MD5())
                    varDatabaseRequestMssql2008(1).Query = $"insert into dbo.man_company(company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                           $"values(@CompanyCode, @CompanyName, @CompanySearchTerm1, @CompanySearchTerm2, @CompanyDescription)"
                ElseIf Not (dataproperties.CompanyIsNew) AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"update dbo.man_company set company_code = @CompanyCode ,company_name = @CompanyName, company_searchterm1 = @CompanySearchTerm1, company_searchterm2 = @CompanySearchTerm2, company_description = @CompanyDescription, company_datelastmodified = now() " &
                                                           $"where company_id = @CompanyId"
                ElseIf (dataproperties.CompanyIsNew) AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    SetValue(dataproperties.AllParameters, tCompany.P_CompanyToken, CMCv.Security.Encryption.MD5())
                    varDatabaseRequestMysql(1).Query = $"insert into {tCompany.TableName}(" &
                                                       $"{tCompany.C_CompanyCode}, " &
                                                       $"{tCompany.C_CompanyName}, " &
                                                       $"{tCompany.C_CompanySearchTerm1}, " &
                                                       $"{tCompany.C_CompanySearchTerm2}, " &
                                                       $"{tCompany.C_CompanyDescription}, " &
                                                       $"{tCompany.C_CompanyToken}, " &
                                                       $"{tCompany.C_CompanyClient}) " &
                                                       $"values ( " &
                                                       $"{tCompany.P_CompanyCode}, " &
                                                       $"{tCompany.P_CompanyName}, " &
                                                       $"{tCompany.P_CompanySearchTerm1}, " &
                                                       $"{tCompany.P_CompanySearchTerm2}, " &
                                                       $"{tCompany.P_CompanyDescription}, " &
                                                       $"{tCompany.P_CompanyToken}, " &
                                                       $"{tClient.P_ClientId})"
                ElseIf Not (dataproperties.CompanyIsNew) AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"update {tCompany.TableName} set " &
                                                       $"{tCompany.C_CompanyCode} = {tCompany.P_CompanyCode}, " &
                                                       $"{tCompany.C_CompanyName} = {tCompany.P_CompanyName}, " &
                                                       $"{tCompany.C_CompanySearchTerm1} = {tCompany.P_CompanySearchTerm1}, " &
                                                       $"{tCompany.C_CompanySearchTerm2} = {tCompany.P_CompanySearchTerm2}, " &
                                                       $"{tCompany.C_CompanyDescription} = {tCompany.P_CompanyDescription} " &
                                                       $"where " &
                                                       $"{tCompany.C_CompanyId} = {tCompany.P_CompanyId}"
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                End If
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub GetCompanyProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varQuery = $"SELECT c.company_code, c.company_name, c.company_searchterm1, c.company_searchterm2, c.company_description " &
                           $"FROM dbo.man_company c " &
                           $"WHERE c.company_id = @CompanyId"
                datasetname = varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varQuery, datasetname, "man_company")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varQuery = $"select {tCompany.S}.{tCompany.C_CompanyCode}, " &
                           $"{tCompany.S}.{tCompany.C_CompanyName}, " &
                           $"{tCompany.S}.{tCompany.C_CompanySearchTerm1}, " &
                           $"{tCompany.S}.{tCompany.C_CompanySearchTerm2}, " &
                           $"{tCompany.S}.{tCompany.C_CompanyDescription} " &
                           $"from {tCompany.TableName} {tCompany.S} " &
                           $"where {tCompany.S}.{tCompany.C_CompanyId} = {tCompany.P_CompanyId}"
                datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varQuery, datasetname, "man_company", dataproperties.AllParameters)
            End If
        End Sub
    End Class
End Namespace
