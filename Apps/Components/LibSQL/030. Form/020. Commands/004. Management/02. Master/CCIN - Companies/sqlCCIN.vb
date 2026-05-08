Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDccin
    Public Class View
        Private Shared ReadOnly consTableName As String = "CheckRelation"
        Private Shared varQuery As String

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt)
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (dataproperties.CompanyIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $" (c.company_code ='{find.XOSQLText}') or (c.company_name like '%{find.XOSQLText}%') or (c.company_searchterm2 like '%{find.XOSQLText}%') or (c.company_searchterm1 like '%{find.XOSQLText}%') or (c.company_description " &
                                $"like '%{find.XOSQLText}%')"
                End If
                varDatabaseRequestMssql2008(0).Query = $"SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.man_company c {varWhere} " &
                                                       $"ORDER BY c.company_code"
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSQLText = String.Empty) OrElse (dataproperties.CompanyIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $" (c.company_code ='{find.XOSQLText}') or (c.company_name like '%{find.XOSQLText}%') or (c.company_searchterm2 like '%{find.XOSQLText}%') or (c.company_searchterm1 like '%{find.XOSQLText}%') or (c.company_description " &
                                $"like '%{find.XOSQLText}%')"
                End If
                varDatabaseRequestMysql(0).Query = $"SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM man_company c {varWhere} " &
                                                   $"ORDER BY c.company_code"
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TCompany")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckGranularity(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet) As Boolean
            Dim varHasChild As Boolean = True
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varQuery = $"SELECT now() as `timestamp`, (select count(*) from v_ccin_granularity_cdin where department_company = @CompanyID limit 0,1) as `relation1`, (select count(*) from v_ccin_granularity_plnt where plant_company = @CompanyID limit 0,1) as `relation2`;"
                    datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varQuery, datasetname, consTableName, dataproperties.AllParameters)
                End If

                If datasetname.Tables(consTableName).Rows.Count > 0 Then
                    If Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The company has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation1"))} related record(s) in [CDIN] Department module.", LibApp.Ingrid.Global.PopupType.Error, "", FRMdialogbox.MessageIcon.Error, FRMdialogbox.MessageTypes.OkOnly)
                        varHasChild = True
                    ElseIf Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation2")) > 0 Then
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"The company has {Convert.ToInt32(datasetname.Tables(consTableName).Rows(0).Item("relation2"))} related record(s) in [PLNT] Plant module.", LibApp.Ingrid.Global.PopupType.Error, "", FRMdialogbox.MessageIcon.Error, FRMdialogbox.MessageTypes.OkOnly)
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
            Dim varSuccess As Boolean
            Try
                If CheckGranularity(dataproperties, datasetname) Then
                    Return False
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = $"delete from dbo.man_company where company_id=@CompanyId"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"delete from man_company where company_id=@CompanyId"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Function CountRecords(dataproperties As LibApp.Ingrid.Global.Properties) As Integer
            Dim varCount As Integer = 0
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = $""
                varCount = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"SELECT count(com.company_id) as `count` FROM man_company as com"
                varCount = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query), Integer)
            End If
            Return varCount
        End Function
    End Class

    Public Class Editor
        Private Shared varQuery As String

        <SupportedOSPlatform("windows")>
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
                    varWhere += $" c.company_code = @CompanyCode"
                Else
                    varWhere += $" c.company_code = @CompanyCode and c.company_id <> @CompanyId"
                End If
                varDatabaseRequestMysql(1).Query = $"select count(c.company_id) as `isduplicate` from man_company c {varWhere}"
                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters), Integer)
            End If
            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean ', databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, companycode As String, companyname As String, searchterm1 As String, searchterm2 As String, description As String, Optional rowid As String = "-1") As Boolean
            Try
                If dataproperties.CompanyIsNew AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    dataproperties.AllParameters.Add("@CompanyToken", CMCv.Security.Encrypt.MD5())
                    varDatabaseRequestMssql2008(1).Query = $"insert into dbo.man_company(company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                           $"values(@CompanyCode, @CompanyName, @CompanySearchTerm1, @CompanySearchTerm2, @CompanyDescription)"
                ElseIf Not (dataproperties.CompanyIsNew) AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"update dbo.man_company set company_code = @CompanyCode ,company_name = @CompanyName, company_searchterm1 = @CompanySearchTerm1, company_searchterm2 = @CompanySearchTerm2, company_description = @CompanyDescription, company_datelastmodified = now() " &
                                                           $"where company_id = @CompanyId"
                ElseIf (dataproperties.CompanyIsNew) AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    dataproperties.AllParameters.Add("@CompanyToken", CMCv.Security.Encrypt.MD5())
                    varDatabaseRequestMysql(1).Query = $"insert into man_company(company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                       $"values(@CompanyCode, @CompanyName, @CompanySearchTerm1, @CompanySearchTerm2, @CompanyDescription)"
                ElseIf Not (dataproperties.CompanyIsNew) AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"update man_company set company_code = @CompanyCode, company_name = @CompanyName, company_searchterm1 = @CompanySearchTerm1, company_searchterm2 = @CompanySearchTerm2, company_description = @CompanyDescription, company_datelastmodified = now() " &
                                                       $"where company_id = @CompanyId"
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    dataproperties.CompanyIsCommitSuccess = True
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                    dataproperties.CompanyIsCommitSuccess = True
                End If
                Return dataproperties.CompanyIsCommitSuccess
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetCompanyProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varQuery = $"SELECT c.company_code, c.company_name, c.company_searchterm1, c.company_searchterm2, c.company_description " &
                           $"FROM dbo.man_company c " &
                           $"WHERE c.company_id = @CompanyId"
                datasetname = varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varQuery, datasetname, "man_company")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varQuery = $"SELECT c.company_code, c.company_name, c.company_searchterm1, c.company_searchterm2, c.company_description " &
                           $"FROM man_company c " &
                           $"WHERE c.company_id = @CompanyId"
                datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varQuery, datasetname, "man_company", dataproperties.AllParameters)
            End If
        End Sub
    End Class
End Namespace
