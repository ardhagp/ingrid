Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.EPLS.Addins.Browse
    Public Class Position
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If (find.Text = String.Empty) OrElse (forcerefresh) Then
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company order by cm.company_code, dp.departement_code, ps.position_code")
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}') or (cm.company_code like '%{0}%') or (cm.company_name like '%{0}%') or (dp.departement_code like '%{0}%') or (dp.departement_name like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%') order by cm.company_code, dp.departement_code, ps.position_code", find.XOSQLText)
            End If
            V_DBR_MSSQL2008(0).DataGrid = datagrid
            V_DBR_MSSQL2008(0).StatusBar = statusbar
            V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TBrowsePosition")
        End Sub
    End Class
End Namespace
