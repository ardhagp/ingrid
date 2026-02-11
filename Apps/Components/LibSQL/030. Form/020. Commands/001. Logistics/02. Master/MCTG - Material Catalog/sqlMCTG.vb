Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDmctg
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
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
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = "Select m.material_id, m.material_number, m.material_name, m.material_longtext, mg.materialgroup_code, mt.materialtype_code, m.material_isidentifier, m.material_iscarrier from " &
                    "dbo.log_material m inner join dbo.log_materialgroup mg On m.material_materialgroup = mg.materialgroup_id inner join dbo.log_materialtype mt On m.material_materialtype = mt.materialtype_id " &
                    "order by m.material_number;"
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("Select m.material_id, m.material_number, m.material_name, m.material_longtext, mg.materialgroup_code, mt.materialtype_code, m.material_isidentifier, " &
                                                        "m.material_iscarrier from dbo.log_material m inner join dbo.log_materialgroup mg On m.material_materialgroup = mg.materialgroup_id inner join " &
                                                        "dbo.log_materialtype mt On m.material_materialtype = mt.materialtype_id where (m.material_number = '{0}') or (m.material_name like '%{0}%') or " &
                                                        "(m.material_longtext like '%{0}%') order by m.material_number;", find.XOSQLText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TMaterialCatalog")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = "Select m.material_id, m.material_number, m.material_name, m.material_longtext, mg.materialgroup_code, mt.materialtype_code, m.material_isidentifier, m.material_iscarrier from " &
                    "log_material m inner join log_materialgroup mg On m.material_materialgroup = mg.materialgroup_id inner join log_materialtype mt On m.material_materialtype = mt.materialtype_id " &
                    "order by m.material_number;"
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("Select m.material_id, m.material_number, m.material_name, m.material_longtext, mg.materialgroup_code, mt.materialtype_code, m.material_isidentifier, " &
                                                        "m.material_iscarrier from log_material m inner join log_materialgroup mg On m.material_materialgroup = mg.materialgroup_id inner join " &
                                                        "log_materialtype mt On m.material_materialtype = mt.materialtype_id where (m.material_number = '{0}') or (m.material_name like '%{0}%') or " &
                                                        "(m.material_longtext like '%{0}%') order by m.material_number;", find.XOSQLText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TMaterialCatalog")
            End If
        End Sub
    End Class
End Namespace
