Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDmmvt
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MsSql.Display.Request

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
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, ByVal find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.Text = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation sval;"
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;", find.XOSqlText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TMaterialValuation")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.Text = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = "select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;"
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("select sval.stockvaluation_id, sval.stockvaluation_code, sval.stockvaluation_description from dbo.log_stockvaluation  sval;", find.XOSqlText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TMaterialValuation")
            End If
        End Sub
    End Class
End Namespace
