Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDmmty
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
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
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSqlText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.log_material m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.log_materialtype mt"
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.log_material m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.log_materialtype mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", find.XOSqlText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TMaterialType")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSqlText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from log_material m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from log_materialtype mt"
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from log_material m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from log_materialtype mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", find.XOSqlText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TMaterialType")
            End If
        End Sub
    End Class
End Namespace
