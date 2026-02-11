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
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.log_material m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.log_materialtype mt"
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.log_material m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.log_materialtype mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", find.XOSQLText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TMaterialType")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from log_material m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from log_materialtype mt"
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from log_material m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from log_materialtype mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", find.XOSQLText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TMaterialType")
            End If
        End Sub
    End Class
End Namespace
