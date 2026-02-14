Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDplnt
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

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
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            Dim varWhere As String = "where "

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varWhere = String.Format("")
                Else
                    varWhere += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", find.XOSQLText)
                End If
                varDatabaseRequestMssql2008(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from " &
                                                    "dbo.man_company c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TPlant")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varWhere = String.Format("")
                Else
                    varWhere += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", find.XOSQLText)
                End If
                varDatabaseRequestMysql(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from " &
                                                    "dbo.man_company c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", varWhere)

                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TPlant")
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
        Public Shared Function DeleteData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.doc_employeeactivity where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.sto_file where file_parent = '{0}';", rowid)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("delete from dbo.doc_employeeactivity where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.sto_file where file_parent = '{0}';", rowid)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
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
        Public Shared Function IsDuplicate(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, companycode As String, plantcode As String, Optional rowid As String = "") As Boolean
            rowid = "0"
            Dim varIsDuplicate As Boolean = False

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If rowid = String.Empty Then
                        varDatabaseRequestMssql2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.sys_module mods where mods.module_code = '{0}'")
                    Else
                        varDatabaseRequestMssql2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.sys_module mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                    End If
                    varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Boolean)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    If rowid = String.Empty Then
                        varDatabaseRequestMysql(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.sys_module mods where mods.module_code = '{0}'")
                    Else
                        varDatabaseRequestMysql(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.sys_module mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                    End If
                    varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Boolean)
                End If
                Return varIsDuplicate
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
        Public Shared Sub GetCompany(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, listofcompany As CMCv.UI.Control.cbo)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.man_company com order by com.company_code"
                varDatabaseRequestMssql2008(1).Dropdown = listofcompany
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(1), "TCompany")
                listofcompany.DisplayMember = "company_name"
                listofcompany.ValueMember = "company_id"
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.man_company com order by com.company_code"
                varDatabaseRequestMysql(1).Dropdown = listofcompany
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(1), "TCompany")
                listofcompany.DisplayMember = "company_name"
                listofcompany.ValueMember = "company_id"
            End If
        End Sub
    End Class
End Namespace
