Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMVT
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If DBEngine = "MSSQL" Then
                If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                    V_DBR_MSSQL2008(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;"
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;", Find.XOSQLText)
                End If
                V_DBR_MSSQL2008(0).DataGrid = Datagrid
                V_DBR_MSSQL2008(0).StatusBar = StatusBar
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TMaterialValuation")
            ElseIf DBEngine = "MYSQL" Then
                If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                    V_DBR_MYSQL(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;"
                Else
                    V_DBR_MYSQL(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.[[log]]stockvaluation]  sval;", Find.XOSQLText)
                End If
                V_DBR_MYSQL(0).DataGrid = Datagrid
                V_DBR_MYSQL(0).StatusBar = StatusBar
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TMaterialValuation")
            End If
        End Sub
    End Class
End Namespace
