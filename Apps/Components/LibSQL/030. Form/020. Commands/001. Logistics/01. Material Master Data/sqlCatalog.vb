Imports CMCv

Namespace Commands
    Public Class Catalog
        Private _DBR_MSSQL2008(1) As Database.Engine.Display.Request

        Public Sub DisplayData(ByVal Datagrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = "select m.material_materialtype, m.material_id, m.material_description, m.material_potext, m.material_materialgroup from dbo.[[mm]]material] m order by m.material_id"
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select m.material_materialtype, m.material_id, m.material_description, m.material_potext, m.material_materialgroup from dbo.[[mm]]material] m where (m.material_id = '{0}') or (m.material_description like '%{0}%') or (m.material_potext like '%{0}%') or (m.material_materialgroup like '%{0}%') order by m.material_id;", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = Datagrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TMaterialCatalog")
        End Sub
    End Class
End Namespace
