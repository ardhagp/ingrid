
Imports System.Runtime.Versioning

Namespace CMDmow
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.Dgn, statusbar As CMCv.UI.Control.Stt, find As CMCv.UI.Control.Txt)
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSqlText = String.Empty) OrElse (dataproperties.PlantIsForceRefresh) Then
                    varWhere = $""
                Else
                    varWhere += $"(m.mow_code like '%{find.XOSqlText}%') or (mow.mow_name like '%{find.XOSqlText}%') or (p.plant_name2 like '%{find.XOSqlText}%')"
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
                    varWhere += $"(m.mow_code like '%{find.XOSqlText}%') or (mow.mow_name like '%{find.XOSqlText}%') or (p.plant_name2 like '%{find.XOSqlText}%')"
                End If

                varDatabaseRequestMysql(0).Query = $"select p.plant_id, p.plant_code, p.plant_name, p.plant_searchterm1, p.plant_searchterm2, p.plant_description, p.plant_postalcode, p.plant_address from " &
                                                   $"man_company c inner join mat_plant p on p.plant_company = c.company_id {varWhere} order by c.company_code, p.plant_code;"

                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TPlant")
            End If
        End Sub
    End Class
End Namespace
