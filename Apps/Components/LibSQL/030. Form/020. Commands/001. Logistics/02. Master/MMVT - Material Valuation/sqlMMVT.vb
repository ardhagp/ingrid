Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMVT
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="dbengine"></param>
        ''' <param name="datagrid"></param>
        ''' <param name="statusbar"></param>
        ''' <param name="find"></param>
        ''' <param name="forcerefresh"></param>
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As String, datagrid As dgn, statusbar As stt, ByVal find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = "MSSQL" Then
                If (find.Text = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MSSQL2008(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation sval;"
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;", find.XOSQLText)
                End If
                V_DBR_MSSQL2008(0).DataGrid = datagrid
                V_DBR_MSSQL2008(0).StatusBar = statusbar
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TMaterialValuation")
            ElseIf dbengine = "MYSQL" Then
                If (find.Text = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MYSQL(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;"
                Else
                    V_DBR_MYSQL(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;", find.XOSQLText)
                End If
                V_DBR_MYSQL(0).DataGrid = datagrid
                V_DBR_MYSQL(0).StatusBar = statusbar
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TMaterialValuation")
            End If
        End Sub
    End Class
End Namespace
