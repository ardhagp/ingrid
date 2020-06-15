Imports CMCv

Namespace Commands.EPLS.Addins.Browse
    Public Class Position
        Public Sub DisplayData(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.[[man]]position] ps inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company order by cm.company_code, dp.departement_code, ps.position_code")
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select ps.position_id, cm.company_code, cm.company_name, dp.departement_code, dp.departement_name, ps.position_code, ps.position_name from dbo.[[man]]position] ps inner join dbo.[[man]]departement] dp on dp.departement_id = ps.position_departement inner join dbo.[[man]]company] cm on cm.company_id = dp.departement_company where (ps.position_id = '{0}') or (cm.company_code like '%{0}%') or (cm.company_name like '%{0}%') or (dp.departement_code like '%{0}%') or (dp.departement_name like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%') order by cm.company_code, dp.departement_code, ps.position_code", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = Datagrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TBrowsePosition")
        End Sub
    End Class
End Namespace
