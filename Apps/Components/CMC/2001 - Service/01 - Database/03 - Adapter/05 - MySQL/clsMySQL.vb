Imports MySql.Data.MySqlClient

Namespace Database.Adapter.Mysql.Display
    Public Structure Request
        Public Property Query As String
        Public Property Cmd As MySqlCommand
        Public Property DataGrid As dgn
        Public Property StatusBar As stt
        Public Property Dropdown As cbo
        Public Property Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    End Structure
End Namespace

Namespace Database.Adapter.Mysql
    Public Structure Execute
        Public Property Query As String
        Public Property Cmd As MySqlCommand
    End Structure
End Namespace