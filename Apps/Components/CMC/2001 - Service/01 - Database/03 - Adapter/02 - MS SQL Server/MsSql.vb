Namespace Database.Adapter.MsSql.Display
    ''' <summary>
    ''' This structure is used to pass parameters for displaying data from a Microsoft SQL Server database in various UI controls such as DataGrid, StatusBar, Dropdown, and Chart.
    ''' </summary>
    Public Structure Request
        ''' <summary>
        ''' The SQL query string to be executed against the Microsoft SQL Server database.
        ''' </summary>
        ''' <returns>The SQL query string.</returns>
        Public Property Query As String

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
    End Structure
End Namespace

Namespace Database.Adapter.MsSql
    ''' <summary>
    ''' This structure is used to pass parameters for executing SQL commands against a Microsoft SQL Server database.
    ''' </summary>
    Public Structure Execute
        ''' <summary>
        ''' The SQL query string to be executed against the Microsoft SQL Server database.
        ''' </summary>
        ''' <returns>The SQL query string.</returns>
        Public Property Query As String
    End Structure
End Namespace
