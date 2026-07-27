Imports MySql.Data.MySqlClient

Namespace Database.Adapter.Mysql.Display
    ''' <summary>
    ''' This structure is used to pass parameters for displaying data from a MySQL database in various UI controls such as DataGrid, StatusBar, Dropdown, and Chart.
    ''' </summary>
    Public Structure Request
        ''' <summary>
        ''' The SQL query string to be executed against the MySQL database.
        ''' </summary>
        ''' <returns>The SQL query string.</returns>
        Public Property Query As String

        ''' <summary>
        ''' The MySqlCommand object that represents the SQL command to be executed.
        ''' </summary>
        ''' <returns>The MySqlCommand object.</returns>
        Public Property Cmd As MySqlCommand

        ''' <summary>
        ''' The DataGrid control where the data will be displayed.
        ''' </summary>
        ''' <returns>The DataGrid control.</returns>
        Public Property DataGrid As CMCv.UI.Control.Dgn

        ''' <summary>
        ''' The StatusBar control where the data will be displayed.
        ''' </summary>
        ''' <returns>The StatusBar control.</returns>
        Public Property StatusBar As CMCv.UI.Control.Stt

        ''' <summary>
        ''' The Dropdown control where the data will be displayed.
        ''' </summary>
        ''' <returns>The Dropdown control.</returns>
        Public Property Dropdown As CMCv.UI.Control.Cbo

        ''' <summary>
        ''' The Chart control where the data will be displayed.
        ''' </summary>
        ''' <returns>The Chart control.</returns>
        Public Property Chart As System.Windows.Forms.DataVisualization.Charting.Chart

        ''' <summary>
        ''' The BindingSource object that represents the data source for data binding.
        ''' </summary>
        ''' <returns>The BindingSource object.</returns>
        Public Property BindingSource As System.Windows.Forms.BindingSource
    End Structure
End Namespace

Namespace Database.Adapter.Mysql
    ''' <summary>
    ''' This structure is used to pass parameters for executing SQL commands against a MySQL database.
    ''' </summary>
    Public Structure Execute
        ''' <summary>
        ''' The SQL query string to be executed against the MySQL database.
        ''' </summary>
        ''' <returns>The SQL query string.</returns>
        Public Property Query As String

        ''' <summary>
        ''' The MySqlCommand object that represents the SQL command to be executed.
        ''' </summary>
        ''' <returns>The MySqlCommand object.</returns>
        Public Property Cmd As MySqlCommand
    End Structure
End Namespace