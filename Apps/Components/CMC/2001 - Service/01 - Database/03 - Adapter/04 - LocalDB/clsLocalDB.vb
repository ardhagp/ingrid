Namespace Database.Adapter.Localdb.Display
    Public Structure Request
        Public Property Query As String
        Public Property DataGrid As CMCv.UI.Control.Dgn
        Public Property StatusBar As CMCv.UI.Control.Stt
        Public Property Dropdown As CMCv.UI.Control.Cbo
        Public Property Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    End Structure
End Namespace

Namespace Database.Adapter.Localdb
    Public Structure Execute
        Public Property Query As String
    End Structure
End Namespace