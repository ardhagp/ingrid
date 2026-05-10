Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDacbk
    Public Class View

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
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
            varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TAccountingBook")
        End Sub
    End Class
End Namespace
