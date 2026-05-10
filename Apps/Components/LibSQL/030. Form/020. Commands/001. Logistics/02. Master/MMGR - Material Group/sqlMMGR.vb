Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDmmgr
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.log_materialgroup mg order by mg.materialgroup_id"
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.log_materialgroup mg where " &
                                                        "(mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or " &
                                                        "(mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", find.XOSQLText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TMaterialGroup")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from log_materialgroup mg order by mg.materialgroup_id"
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from log_materialgroup mg where " &
                                                        "(mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or " &
                                                        "(mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", find.XOSQLText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TMaterialGroup")
            End If
        End Sub
    End Class
End Namespace
