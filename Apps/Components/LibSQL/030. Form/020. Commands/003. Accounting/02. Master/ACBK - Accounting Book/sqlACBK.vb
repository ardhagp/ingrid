Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.ACBK
    Public Class View

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim _Where As String = "where "

            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _Where = ""
            Else
                _Where += String.Format("c.company_code like '%{0}%' and ab.book_code like '%{0}%' and ab.book_bookname like '%{0}%'", Find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("select ab.book_id, c.company_code, ab.book_code, ab.book_bookname, ab.book_datecreated from dbo.[[ac]]book] ab inner join dbo.[[man]]company] c on " &
                                                    "ab.book_company = c.company_id {0}", _Where)

            V_DBR_MSSQL2008(0).DataGrid = Datagrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TAccountingBook")
        End Sub
    End Class
End Namespace
