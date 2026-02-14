Imports MySql.Data.MySqlClient

Namespace Database.Adapter.MySQL.Display
    Public Structure Request
        Public Property Query As String
        Public Property Cmd As MySqlCommand
        Public Property DataGrid As CMCv.UI.Control.dgn
        Public Property StatusBar As CMCv.UI.Control.stt
        Public Property Dropdown As CMCv.UI.Control.cbo
        Public Property Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    End Structure
End Namespace

Namespace Database.Adapter.MySQL
    Public Structure Execute
        Public Property Query As String
        Public Property Cmd As MySqlCommand
    End Structure
End Namespace