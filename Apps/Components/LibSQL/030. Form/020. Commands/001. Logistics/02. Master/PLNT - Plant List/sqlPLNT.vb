Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.PLNT
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim V_Where As String = "where "

            If DBEngine = "MSSQL" Then
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_Where = String.Format("")
                Else
                    V_Where += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", Find.XOSQLText)
                End If

                V_DBR_MSSQL2008(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from " &
                                                    "dbo.[[man]]company] c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", V_Where)

                V_DBR_MSSQL2008(0).DataGrid = DataGrid
                V_DBR_MSSQL2008(0).StatusBar = StatusBar
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TPlant")
            ElseIf DBEngine = "MYSQL" Then
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_Where = String.Format("")
                Else
                    V_Where += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", Find.XOSQLText)
                End If

                V_DBR_MYSQL(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from " &
                                                    "dbo.[[man]]company] c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", V_Where)

                V_DBR_MYSQL(0).DataGrid = DataGrid
                V_DBR_MYSQL(0).StatusBar = StatusBar
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TPlant")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                    V_Success = True
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                    V_Success = True
                End If
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal CompanyCode As String, ByVal PlantCode As String, Optional ByVal RowID As String = "") As Boolean
            RowID = "0"
            Dim V_IsDuplicate As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    If RowID = String.Empty Then
                        V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'")
                    Else
                        V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                    End If

                    V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Boolean)
                ElseIf DBEngine = "MYSQL" Then
                    If RowID = String.Empty Then
                        V_DBR_MYSQL(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'")
                    Else
                        V_DBR_MYSQL(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                    End If

                    V_IsDuplicate = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Boolean)
                End If

                Return V_IsDuplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GETCompany(ByVal DBEngine As String, ByVal ListOfCompany As CMCv.cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.[[man]]company] com order by com.company_code"
                V_DBR_MSSQL2008(1).Dropdown = ListOfCompany
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TCompany")
                ListOfCompany.DisplayMember = "company_name"
                ListOfCompany.ValueMember = "company_id"
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.[[man]]company] com order by com.company_code"
                V_DBR_MYSQL(1).Dropdown = ListOfCompany
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TCompany")
                ListOfCompany.DisplayMember = "company_name"
                ListOfCompany.ValueMember = "company_id"
            End If
        End Sub
    End Class
End Namespace
