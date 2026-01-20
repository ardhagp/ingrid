Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMGR
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = "MSSQL" Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MSSQL2008(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.log_materialgroup mg order by mg.materialgroup_id"
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.log_materialgroup mg where " &
                                                        "(mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or " &
                                                        "(mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", find.XOSQLText)
                End If
                V_DBR_MSSQL2008(0).DataGrid = datagrid
                V_DBR_MSSQL2008(0).StatusBar = statusbar
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TMaterialGroup")
            ElseIf dbengine = "MYSQL" Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MYSQL(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from log_materialgroup mg order by mg.materialgroup_id"
                Else
                    V_DBR_MYSQL(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from log_materialgroup mg where " &
                                                        "(mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or " &
                                                        "(mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", find.XOSQLText)
                End If
                V_DBR_MYSQL(0).DataGrid = datagrid
                V_DBR_MYSQL(0).StatusBar = statusbar
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TMaterialGroup")
            End If
        End Sub
    End Class
End Namespace
