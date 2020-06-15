Imports CMCv

Namespace Commands
    Public Class MaterialType
        Private _DBR_MSSQL2008(1) As Database.Engine.Display.Request

        Public Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = "select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.[[mm]]material] m where m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.[[mm]]materialtype] mt"
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select mt.materialtype_id, mt.materialtype_description,(convert(varchar(255),(select count(m.material_id) from dbo.[[mm]]material] m where m.material_materialtype = mt.materialtype_id)) + '  item(s)') as itemcount from dbo.[[mm]]materialtype] mt WHERE mt.materialtype_id LIKE '%{0}%' OR mt.materialtype_description LIKE '%{0}%'", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = DataGrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TMaterialType")
        End Sub
    End Class
End Namespace
