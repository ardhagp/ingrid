Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.EPLS.Addins.Browse
    Public Class Position
        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.[[man]]position] ps inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company order by cm.company_code, dp.departement_code, ps.position_code")
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.[[man]]position] ps inner join dbo.[[man]]department] dp on dp.department_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}') or (cm.company_code like '%{0}%') or (cm.company_name like '%{0}%') or (dp.departement_code like '%{0}%') or (dp.departement_name like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%') order by cm.company_code, dp.departement_code, ps.position_code", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = Datagrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TBrowsePosition", "db_universe_erp")
        End Sub
    End Class
End Namespace
