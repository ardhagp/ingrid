Imports CMCv
Imports System.Windows.Forms

Namespace Commands.PLNT
    Public Class View
        Private _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        Public Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim _Where As String = "where "

            If (Find.SLFSQLText = String.Empty) Or (ForceRefresh = True) Then
                _Where = String.Format("")
            Else
                _Where += String.Format("(p.plant_code like '%{0}%') or (p.plant_name like '%{0}%') or (p.plant_name2 like '%{0}%') or (p.plant_postalcode like '%{0}%')", Find.SLFSQLText)
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select p.plant_id, p.plant_code, p.plant_name, p.plant_name2, p.plant_description, p.plant_city, p.plant_postalcode, p.plant_searchterm1, p.plant_searchterm2 from dbo.[[man]]company] c inner join dbo.[[log]]plant] p on p.plant_company = c.company_id {0} order by c.company_code, p.plant_code;", _Where)

            _DBR_MSSQL2008(0).DataGrid = DataGrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TPlant")

        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[doc]]employeeactivity] where employeeactivity_id = '{0}';delete from db_universe_erp_file.dbo.[[sto]]file] where file_parent = '{0}';", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function

    End Class

    Public Class Editor
        Public Function IsDuplicate(ByVal CompanyCode As String, ByVal PlantCode As String, Optional ByVal RowID As String = "") As Boolean
            RowID = 0
            Dim _IsDuplicate As Boolean = False

            Try
                If RowID = String.Empty Then
                    _DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'")
                Else
                    _DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'")
                End If

                _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _IsDuplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Sub GETCompany(ByVal ListOfCompany As CMCv.cbo)
            _DBR_MSSQL2008(1).Query = "select com.company_id, '[' + com.company_code + '] - ' + com.company_name as [company_name] from dbo.[[man]]company] com order by com.company_code"
            _DBR_MSSQL2008(1).Dropdown = ListOfCompany
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TCompany")
            ListOfCompany.DisplayMember = "company_name"
            ListOfCompany.ValueMember = "company_id"
        End Sub
    End Class
End Namespace
