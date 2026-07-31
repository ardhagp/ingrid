Imports System.Runtime.Versioning

Namespace CMDplnt
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
        Private Shared ReadOnly varQuery As String = String.Empty
        Private Shared ReadOnly consTableName As String = "CheckRelation"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbengine"></param>
        ''' <param name="datagrid"></param>
        ''' <param name="statusbar"></param>
        ''' <param name="find"></param>
        ''' <param name="forcerefresh"></param>
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt)
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.PlantIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $"(p.plant_code like '%{find.XOSqlText}%') or (p.plant_name like '%{find.XOSqlText}%') or (p.plant_name2 like '%{find.XOSqlText}%') or (p.plant_postalcode like '%{find.XOSqlText}%')"
                End If
                varDatabaseRequestMssql2008(0).Query = $"select p.plant_id, p.plant_code, p.plant_name, p.plant_searchterm1, p.plant_searchterm2, p.plant_description, p.plant_postalcode, p.plant_address from " &
                                                       $"dbo.man_company c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {varWhere} order by c.company_code, p.plant_code;"

                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TPlant")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.PlantIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $"(p.plant_code like '%{find.XOSqlText}%') or (p.plant_name like '%{find.XOSqlText}%') or (p.plant_name2 like '%{find.XOSqlText}%') or (p.plant_postalcode like '%{find.XOSqlText}%')"
                End If
                varDatabaseRequestMysql(0).Query = $"select p.plant_id, p.plant_code, p.plant_name, p.plant_searchterm1, p.plant_searchterm2, p.plant_description, p.plant_postalcode, p.plant_address from " &
                                                   $"man_company c inner join mat_plant p on p.plant_company = c.company_id {varWhere} order by c.company_code, p.plant_code;"

                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TPlant")
            End If
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbengine"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $""
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $""
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
    ''' 
    ''' </summary>
    Public Class Editor
        Private Shared varQuery As String = String.Empty

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbengine"></param>
        ''' <param name="companycode"></param>
        ''' <param name="plantcode"></param>
        ''' <param name="rowid"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = $"WHERE "

            Try
                If dataproperties.PlantIsNew Then
                    varWhere += $"p.plant_company='{dataproperties.AllParameters("@CompanyId")}' and p.plant_code = '{dataproperties.PlantCode}'"
                Else
                    varWhere += $"p.plant_company='{dataproperties.AllParameters("@CompanyId")}' and p.plant_code = '{dataproperties.PlantCode}' and p.plant_id <> '{dataproperties.PlantId}'"
                End If

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $""
                    varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"SELECT count(p.plant_id) as `rows` FROM mat_plant p {varWhere}"
                    varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Integer)
                End If

                If varIsDuplicate = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbengine"></param>
        ''' <param name="listofcompany"></param>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(dataproperties As LibApp.Ingrid.Global.Properties, listofcompany As CMCv.UI.Control.Cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = $"select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_name] from dbo.man_company c order by c.company_code"
                varDatabaseRequestMssql2008(1).Dropdown = listofcompany
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TCompany")
                listofcompany.DisplayMember = "company_name"
                listofcompany.ValueMember = "company_id"
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select c.company_id, concat(c.company_code, ' - ', c.company_name) as `company_name` from man_company c order by c.company_code"
                varDatabaseRequestMysql(1).Dropdown = listofcompany
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TCompany")
                listofcompany.DisplayMember = "company_name"
                listofcompany.ValueMember = "company_id"
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetPlantProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varQuery = $""
                datasetname = varDatabaseEngineMssql2008.FillDataset(dataproperties.ConnectionDatabaseName, varQuery, datasetname, "")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varQuery = $"SELECT p.plant_id, p.plant_company, c.company_code, p.plant_code, p.plant_name, p.plant_searchterm1, p.plant_searchterm2, p.plant_description, p.plant_address, p.plant_postalcode " &
                           $"FROM mat_plant p inner join man_company c on c.company_id = p.plant_company " &
                           $"WHERE p.plant_id = '{dataproperties.PlantId}';"
                datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varQuery, datasetname, "mat_plant")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            'TODO: Implement Insert and Update Query
        End Function
    End Class
End Namespace
