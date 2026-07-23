Namespace Database.Connect
    ''' <summary>
    ''' Interface for Microsoft Access Connections
    ''' </summary>
    Friend Interface IMsAccessConnections
        ''' <summary>
        ''' Microsoft Access OLEDB Connection String
        ''' </summary>
        ''' <param name="databasepath">Database file path</param>
        ''' <param name="username">Username for the database</param>
        ''' <param name="password">Password for the database</param>
        ''' <returns>Connection string</returns>
        Function MicrosoftOledbStandard(databasepath As String, ByVal username As String, ByVal password As String) As String

        ''' <summary>
        ''' Microsoft Access ODBC Connection String
        ''' </summary>
        ''' <param name="databasepath">Database file path</param>
        ''' <param name="username">Username for the database</param>
        ''' <param name="password">Password for the database</param>
        ''' <returns>Connection string</returns>
        Function MicrosoftOdbcStandard(databasepath As String, ByVal username As String, ByVal password As String) As String
    End Interface

    ''' <summary>
    ''' Interface for Microsoft SQL Server Connections
    ''' </summary>
    Friend Interface IMsSqlConnections
        ''' <summary>
        ''' SQL Server Standard Connection
        ''' </summary>
        ''' <param name="serveraddress">Address of the SQL Server</param>
        ''' <param name="serverport">Port of the SQL Server</param>
        ''' <param name="databasename">Name of the database</param>
        ''' <param name="username">Username for the database</param>
        ''' <param name="password">Password for the database</param>
        ''' <returns>Connection string</returns>
        Function MssqlStandard(serveraddress As String, serverport As Integer, databasename As String, username As String, password As String) As String

        ''' <summary>
        ''' SQL Server Trusted Connection
        ''' </summary>
        ''' <param name="serveraddress">Address of the SQL Server</param>
        ''' <param name="databasename">Name of the database</param>
        ''' <returns>Connection string</returns>
        Function MssqlTrustedConnection(serveraddress As String, databasename As String) As String
    End Interface

    ''' <summary>
    ''' Interface for MySQL Connections
    ''' </summary>
    Friend Interface IMysqlconnections
        ''' <summary>
        ''' MySQL Connection with SSL enforced
        ''' </summary>
        ''' <param name="serveraddress">Address of the MySQL Server</param>
        ''' <param name="serverport">Port of the MySQL Server</param>
        ''' <param name="databasename">Name of the database</param>
        ''' <param name="username">Username for the database</param>
        ''' <param name="password">Password for the database</param>
        ''' <returns>Connection string</returns>
        Function MySqlForceSsl(serveraddress As String, serverport As Integer, databasename As String, username As String, password As String) As String
    End Interface

    ''' <summary>
    ''' Interface for LocalDB Connections
    ''' </summary>
    Friend Interface ILocaldbconnections
        ''' <summary>
        ''' LocalDB Automatic Instance Connection
        ''' </summary>
        ''' <returns></returns>
        Function LocalDbAutomaticInstance() As String

        ''' <summary>
        ''' LocalDB Attach Database Connection
        ''' </summary>
        ''' <param name="dbfilename"></param>
        ''' <returns></returns>
        Function LocalDbAttachDb(dbfilename As String) As String

        ''' <summary>
        ''' LocalDB Specified Instance Connection
        ''' </summary>
        ''' <param name="instancename">Name of the LocalDB instance</param>
        ''' <returns>Connection string</returns>
        Function LocalDbSpecifiedInstance(instancename As String) As String

        ''' <summary>
        ''' LocalDB Initial Catalog Connection
        ''' </summary>
        ''' <param name="dbfilename">Name of the database file</param>
        ''' <returns>Connection string</returns>
        Function LocalDBInitialCatalog(dbfilename As String) As String
    End Interface

    ''' <summary>
    ''' Interface for SQLite Connections
    ''' </summary>
    Friend Interface ISqlite
        ''' <summary>
        ''' SQLite Basic Connection
        ''' </summary>
        ''' <param name="dbfile">Path to the SQLite database file</param>
        ''' <returns>Connection string</returns>
        Function SQLiteBasic(dbfile As String) As String

        ''' <summary>
        ''' SQLite Connection with Password
        ''' </summary>
        ''' <param name="dbfile">Path to the SQLite database file</param>
        ''' <param name="password">Password for the SQLite database</param>
        ''' <returns>Connection string</returns>
        Function SQLiteOpenWithPassword(dbfile As String, password As String) As String
    End Interface

    ''' <summary>
    ''' Class for Microsoft Access Connections
    ''' </summary>
    Public Class MsAccessConnection
        Implements IMsAccessConnections

        ''' <summary>
        ''' Microsoft Access ODBC Connection String
        ''' </summary>
        ''' <param name="databasepath">Path to the Microsoft Access database file</param>
        ''' <param name="username">Username for the Microsoft Access database</param>
        ''' <param name="password">Password for the Microsoft Access database</param>
        ''' <returns>Connection string</returns>
        Public Function MicrosoftOdbcStandard(databasepath As String, username As String, password As String) As String Implements IMsAccessConnections.MicrosoftOdbcStandard
            varResult = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & databasepath & ";Uid=" & username & ";Pwd=" & password & ";"
            Return varResult
        End Function

        ''' <summary>
        ''' Microsoft Access OLEDB Connection String
        ''' </summary>
        ''' <param name="databasepath">Path to the Microsoft Access database file</param>
        ''' <param name="username">Username for the Microsoft Access database</param>
        ''' <param name="password">Password for the Microsoft Access database</param>
        ''' <returns>Connection string</returns>
        Public Function MicrosoftOledbStandard(databasepath As String, username As String, password As String) As String Implements IMsAccessConnections.MicrosoftOledbStandard
            varResult = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & databasepath & ";User Id=" & username & ";password=" & password & ";"
            Return varResult
        End Function
    End Class

    ''' <summary>
    ''' Class for Microsoft SQL Server Connections
    ''' </summary>
    Public Class MsSqlConnection
        Implements IMsSqlConnections

        ''' <summary>
        ''' Microsoft SQL Server Standard Connection String
        ''' </summary>
        ''' <param name="serveraddress">Address of the SQL Server</param>
        ''' <param name="serverport">Port of the SQL Server</param>
        ''' <param name="databasename">Name of the database</param>
        ''' <param name="username">Username for the SQL Server</param>
        ''' <param name="password">Password for the SQL Server</param>
        ''' <returns>Connection string</returns>
        Public Function MsSqlStandard(serveraddress As String, serverport As Integer, databasename As String, username As String, password As String) As String Implements IMsSqlConnections.MssqlStandard
            varResult = String.Format(System.Globalization.CultureInfo.CurrentCulture, "Server = {0},{1}; Database = {2}; User Id = {3}; password = {4}; Encrypt=True; TrustServerCertificate=True;", serveraddress.Trim, serverport, databasename, username.Trim, password)
            Return varResult
        End Function

        ''' <summary>
        ''' Microsoft SQL Server Trusted Connection String
        ''' </summary>
        ''' <param name="serveraddress">Address of the SQL Server</param>
        ''' <param name="databasename">Name of the database</param>
        ''' <returns>Connection string</returns>
        Public Function MsSqlTrustedConnection(serveraddress As String, databasename As String) As String Implements IMsSqlConnections.MssqlTrustedConnection
            varResult = $"Server = {serveraddress.Trim}; Database = {databasename.Trim}; Trusted_Connection = True;"
            Return varResult
        End Function
    End Class

    ''' <summary>
    ''' Class for MySQL Connections
    ''' </summary>
    Public Class MysqlConnection
        Implements IMysqlconnections

        ''' <summary>
        ''' MySQL Connection String with SSL enforced
        ''' </summary>
        ''' <param name="serveraddress">Address of the MySQL server</param>
        ''' <param name="serverport">Port of the MySQL server</param>
        ''' <param name="databasename">Name of the database</param>
        ''' <param name="username">Username for the MySQL server</param>
        ''' <param name="password">Password for the MySQL server</param>
        ''' <returns>Connection string</returns>
        Public Function MysqlForceSsl(serveraddress As String, serverport As Integer, databasename As String, username As String, password As String) As String Implements IMysqlconnections.MySqlForceSsl
            varResult = String.Format(System.Globalization.CultureInfo.CurrentCulture, $"Server={serveraddress};Database={databasename};Port={serverport};Uid={username};Pwd={password};SslMode=Required;")
            Return varResult
        End Function
    End Class

    ''' <summary>
    ''' Class for LocalDB Connections
    ''' </summary>
    Public Class LocalDbConnection
        Implements ILocaldbconnections

        ''' <summary>
        ''' LocalDB Attach Database Connection String
        ''' </summary>
        ''' <param name="dbfilename">Path to the database file</param>
        ''' <returns>Connection string</returns>
        Public Function LocalDbAttachDb(dbfilename As String) As String Implements ILocaldbconnections.LocalDbAttachDb
            varResult = $"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName={dbfilename};"
            Return varResult
        End Function

        ''' <summary>
        ''' LocalDB Automatic Instance Connection String
        ''' </summary>
        ''' <returns>Connection string</returns>
        Public Function LocalDbAutomaticInstance() As String Implements ILocaldbconnections.LocalDbAutomaticInstance
            varResult = $"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"
            Return varResult
        End Function

        ''' <summary>
        ''' LocalDB Specified Instance Connection String
        ''' </summary>
        ''' <param name="instancename">Name of the LocalDB instance</param>
        ''' <returns>Connection string</returns>
        Public Function LocalDbSpecifiedInstance(instancename As String) As String Implements ILocaldbconnections.LocalDbSpecifiedInstance
            varResult = $"Server=(localdb)\{instancename};Integrated Security=true;"
            Return varResult
        End Function

        ''' <summary>
        ''' LocalDB Initial Catalog Connection String
        ''' </summary>
        ''' <param name="dbfilename">Path to the database file</param>
        ''' <returns>Connection string</returns>
        Public Function LocalDbInitialCatalog(dbfilename As String) As String Implements ILocaldbconnections.LocalDBInitialCatalog
            varResult = $"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName={dbfilename};Encrypt=False; TrustServerCertificate=False;"
            Return varResult
        End Function
    End Class

    ''' <summary>
    ''' Class for SQLite Connections
    ''' </summary>
    Public Class SqliteConnection
        Implements ISqlite

        ''' <summary>
        ''' SQLite Basic Connection String
        ''' </summary>
        ''' <param name="dbfile">Path to the SQLite database file</param>
        ''' <returns></returns>
        Public Function SqliteBasic(dbfile As String) As String Implements ISqlite.SQLiteBasic
            'Applied on System.Data.SQLite (No longer used)
            'varResult = "Data Source=" & dbfile & ";Version=3;Mode=ReadWrite;Journal Mode=Off;"
            'varResult = "Data Source=" & dbfile & ";Version=3;Journal Mode=Persist;Synchronous=Full;Max Page Count=5000;"

            'Applied on Microsoft.Data.Sqlite (Current)
            varResult = $"Data Source={dbfile};"
            Return varResult
        End Function

        ''' <summary>
        ''' SQLite Connection String with Password
        ''' </summary>
        ''' <param name="dbfile">Path to the SQLite database file</param>
        ''' <param name="password">Password for the SQLite database</param>
        ''' <returns>Connection string</returns>
        Public Function SqliteOpenWithPassword(dbfile As String, password As String) As String Implements ISqlite.SQLiteOpenWithPassword
            varResult = $"Data Source={dbfile};password={password};"
            Return varResult
        End Function
    End Class
End Namespace
