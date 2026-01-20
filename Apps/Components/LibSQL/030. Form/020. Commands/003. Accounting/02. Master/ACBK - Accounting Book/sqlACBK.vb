Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.ACBK
    Public Class View

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            Dim varWhere As String = "where "

            If (find.Text = String.Empty) OrElse (forcerefresh) Then
                varWhere = ""
            Else
                varWhere.Append(CChar($"c.company_code like '%{0}%' and ab.book_code like '%{find.XOSQLText}%' and ab.book_bookname like '%{0}%'"))
            End If

            varDatabaseRequestMssql2008(0).Query = String.Format("select ab.book_id, c.company_code, ab.book_code, ab.book_bookname, ab.book_datecreated from dbo.ac_book ab inner join dbo.man_company c on " &
                                                    "ab.book_company = c.company_id {0}", varWhere)

            varDatabaseRequestMssql2008(0).DataGrid = datagrid
            varDatabaseRequestMssql2008(0).StatusBar = statusbar
            varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TAccountingBook")
        End Sub
    End Class
End Namespace
