Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MMTY
    Public Class View
        'ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If DBEngine = "MSSQL" Then
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                    V_DBR_MSSQL2008(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.[[log]]material] m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.[[log]]materialtype] mt"
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.[[log]]material] m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.[[log]]materialtype] mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", Find.XOSQLText)
                End If
                V_DBR_MSSQL2008(0).DataGrid = DataGrid
                V_DBR_MSSQL2008(0).StatusBar = StatusBar
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TMaterialType")
            ElseIf DBEngine = "MYSQL" Then
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_DBR_MYSQL(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from log_material m where " &
                    "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from log_materialtype mt"
                Else
                    V_DBR_MYSQL(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from log_material m where " &
                                                        "m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from log_materialtype mt WHERE mt.materialtype_id LIKE '%{0}%' OR " &
                                                        "mt.materialtype_description LIKE '%{0}%'", Find.XOSQLText)
                End If
                V_DBR_MYSQL(0).DataGrid = DataGrid
                V_DBR_MYSQL(0).StatusBar = StatusBar
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TMaterialType")
            End If
        End Sub
    End Class
End Namespace
