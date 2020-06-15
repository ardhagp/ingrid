Imports CMCv

Namespace Commands
    Public Class Company
        Private _DBR_MSSQL2008(1) As Database.Engine.Display.Request

        Public Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = "SELECT c.company_id, c.company_code, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.[[org]]company] c ORDER BY C.company_code"
            Else
                _DBR_MSSQL2008(0).Query = String.Format("SELECT c.company_id, c.company_code, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.[[org]]company] c WHERE (c.company_code ='{0}') or (c.company_searchterm2 like '%{0}%') or (c.company_searchterm1 like '%{0}%') or (c.company_description like '%{0}%')  ORDER BY C.company_code", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = DataGrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TCompany")
        End Sub
    End Class
End Namespace
