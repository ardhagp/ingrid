Imports CMCv

Namespace Commands.MMVT
    Public Class View
        Private _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        Public Sub DisplayData(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;"
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = Datagrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TMaterialValuation")
        End Sub


    End Class
End Namespace
