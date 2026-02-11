Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDmmvt
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
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, datagrid As dgn, statusbar As stt, ByVal find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.Text = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation sval;"
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;", find.XOSQLText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TMaterialValuation")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.Text = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;"
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;", find.XOSQLText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TMaterialValuation")
            End If
        End Sub
    End Class
End Namespace
