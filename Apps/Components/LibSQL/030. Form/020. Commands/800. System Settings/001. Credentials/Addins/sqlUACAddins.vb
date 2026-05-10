Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDuac.Addins.Browse
    Public Class Employee
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, grid As CMCv.UI.Control.dgn, status As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            ReDim varDatabaseRequestMssql2008(2)

            If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, em.employee_number, em.employee_fullname from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company where (em.employee_active = 1) and (em.employee_id not in (select usr.user_employee from dbo.sys_user usr))  order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname")
            Else
                varDatabaseRequestMssql2008(0).Query = String.Format("select em.employee_id, cm.company_code, dp.departement_code, ps.position_code, em.employee_number, em.employee_fullname from dbo.man_employee em inner join dbo.man_position ps on ps.position_id = em.employee_position inner join dbo.man_department dp on dp.department_id = ps.position_departement inner join dbo.man_company cm on cm.company_id = dp.departement_company where (em.employee_active = 1) and (em.employee_id not in (select usr.user_employee from dbo.sys_user usr)) and (cm.company_code like '%{0}%' or dp.departement_code like '%{0}%' or ps.position_code like '%{0}%' or em.employee_number = '{0}' or em.employee_fullname like '%{0}%') order by cm.company_code, dp.departement_code, ps.position_code, em.employee_fullname", find.XOSQLText)
            End If

            varDatabaseRequestMssql2008(0).DataGrid = grid
            varDatabaseRequestMssql2008(0).StatusBar = status
            varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TEmployee")
        End Sub
    End Class
End Namespace

