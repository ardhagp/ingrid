Imports CMCv

Namespace Commands
    Public Class AccountingBook

        Public Sub DisplayData(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then

                _DBR_MSSQL2008(0).Query = "select ab.acbook_id, p.plant_code, ab.acbook_code, ab.acbook_bookname, ab.acbook_datecreated from dbo.[[ac]]book] ab inner join dbo.[[mm]]plant] p on ab.acbook_plant = p.plant_id"
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select ab.acbook_id, p.plant_code, ab.acbook_code, ab.acbook_bookname, ab.acbook_datecreated from dbo.[[ac]]book] ab inner join dbo.[[mm]]plant] p on ab.acbook_plant = p.plant_id where p.plant_code like '%{0}%' and ab.acbook_code like '%{0}%' and ab.acbook_bookname like '%{0}%'", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = Datagrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAccountingBook")
        End Sub
    End Class
End Namespace
