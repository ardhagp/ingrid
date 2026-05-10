Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDepls.Addins.Browse
    Public Class Position
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            If (find.Text = String.Empty) OrElse (forcerefresh) Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company order by cm.company_code, dp.departement_code, ps.position_code")
            Else
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.man_position ps inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}') or (cm.company_code like '%{0}%') or (cm.company_name like '%{0}%') or (dp.departement_code like '%{0}%') or (dp.departement_name like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%') order by cm.company_code, dp.departement_code, ps.position_code", find.XOSQLText)
            End If
            varDatabaseRequestMssql2008(0).DataGrid = datagrid
            varDatabaseRequestMssql2008(0).StatusBar = statusbar
            varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TBrowsePosition")
        End Sub
    End Class
End Namespace
