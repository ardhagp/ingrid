Namespace Database.Adapter.LocalDB.Display
    Public Structure Request
        Public Property Query As String
        Public Property DataGrid As CMCv.UI.Control.dgn
        Public Property StatusBar As CMCv.UI.Control.stt
        Public Property Dropdown As CMCv.UI.Control.Cbo
        Public Property Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    End Structure
End Namespace

Namespace Database.Adapter.LocalDB
    Public Structure Execute
        Public Property Query As String
    End Structure
End Namespace