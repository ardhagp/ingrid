Imports CMCv

Namespace Commands
    Public Class MaterialGroup
        Public Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = "select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.[[mm]]materialgroup] mg order by mg.materialgroup_id"
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select mg.materialgroup_id, mg.materialgroup_description, mg.materialgroup_description2, mg.materialgroup_language from dbo.[[mm]]materialgroup] mg where (mg.materialgroup_id = '{0}') or (mg.materialgroup_description like '%{0}%') or (mg.materialgroup_description2 like '%{0}%') or (mg.materialgroup_language like '%{0}%') order by mg.materialgroup_id;", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = DataGrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TMaterialGroup")
        End Sub
    End Class
End Namespace
