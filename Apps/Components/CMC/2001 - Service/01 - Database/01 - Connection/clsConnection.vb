Imports CMCv.Database.Provider
Imports Syncfusion.Windows.Forms
Imports System.Globalization

Namespace Database.Connect
    ''' <summary>
    ''' Database connection string untuk berbagai provider
    ''' </summary>
    ''' <remarks></remarks>
    Friend Interface IMsaccess2003connections
#Region "OLEDB"
        ''' <summary>
        ''' Koneksi database Access 2003 menggunakan OLEDB
        ''' </summary>
        ''' <param name="databasepath">Direktori database</param>
        ''' <param name="username">username</param>
        ''' <param name="password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function Microsoftoledbstandard(ByVal databasepath As String, ByVal username As String, ByVal password As String) As String
#End Region

#Region "ODBC"
        ''' <summary>
        ''' Koneksi database Access 2003 Standard
        ''' </summary>
        ''' <param name="databasepath">Direktori database</param>
        ''' <param name="username">username</param>
        ''' <param name="password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function Microsoftodbcstandard(ByVal databasepath As String, ByVal username As String, ByVal password As String) As String
#End Region
    End Interface

    Friend Interface IMssqlserver2008connections
#Region ".NET Standard"

        ''' <summary>
        ''' Koneksi SQL Server 2008 Standard
        ''' </summary>
        ''' <param name="serveraddress">Alamat server</param>
        ''' <param name="databasename">Nama database</param>
        ''' <param name="username">username</param>
        ''' <param name="password">password</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Mssql2008standard(ByVal serveraddress As String, ByVal serverport As Integer, ByVal databasename As String, ByVal username As String, ByVal password As String) As String

        ''' <summary>
        ''' Koneksi SQL Server 2008 Trusted Connection
        ''' </summary>
        ''' <param name="serveraddress">Alamat server</param>
        ''' <param name="databasename">Nama database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Mssql2008trustedconnection(ByVal serveraddress As String, ByVal databasename As String) As String
#End Region
    End Interface

    Friend Interface IMysqlconnections

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="serveraddress">Database server address</param>
        ''' <param name="serverport">Database port</param>
        ''' <param name="databasename">Database name</param>
        ''' <param name="username">username to access database</param>
        ''' <param name="password">PPassword to access dadtabase</param>
        ''' <returns></returns>
        Function Mysqlforcessl(ByVal serveraddress As String, ByVal serverport As Integer, ByVal databasename As String, ByVal username As String, ByVal password As String) As String
    End Interface

    Friend Interface ILocaldbconnections
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <returns></returns>
        Function LocalDBAutomaticInstance() As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dbfilename"></param>
        ''' <returns></returns>
        Function LocalDBAttachDB(ByVal dbfilename As String) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="instancename"></param>
        ''' <returns></returns>
        Function LocalDBSpecifiedInstance(ByVal instancename As String) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dbfilename"></param>
        ''' <returns></returns>
        Function LocalDBInitialCatalog(ByVal dbfilename As String) As String

    End Interface

    Friend Interface ISqlite
        Function SQLiteBasic(ByVal dbfile As String) As String

        Function SQLiteOpenWithPassword(ByVal dbfile As String, ByVal password As String) As String

    End Interface

    '-----------------------------------------------------------------------------
    Public Class Msaccess2003connection
        Implements IMsaccess2003connections
        ''' <summary>
        ''' Koneksi database Access 2003
        ''' </summary>
        ''' <param name="databasepath">Direktori database</param>
        ''' <param name="username">username</param>
        ''' <param name="password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Function Microsoftodbcstandard(databasepath As String, username As String, password As String) As String Implements IMsaccess2003connections.Microsoftodbcstandard
            varResult = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & databasepath & ";Uid=" & username & ";Pwd=" & password & ";"
            Return varResult
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasepath"></param>
        ''' <param name="username"></param>
        ''' <param name="password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Microsoftoledbstandard(databasepath As String, username As String, password As String) As String Implements IMsaccess2003connections.Microsoftoledbstandard
            varResult = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & databasepath & ";User Id=" & username & ";password=" & password & ";"
            Return varResult
        End Function
    End Class

    Public Class Mssqlserver2008connection
        Implements IMssqlserver2008connections

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="serveraddress"></param>
        ''' <param name="serverport"></param>
        ''' <param name="databasename"></param>
        ''' <param name="username"></param>
        ''' <param name="password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Mssql2008standard(serveraddress As String, ByVal serverport As Integer, ByVal databasename As String, username As String, password As String) As String Implements IMssqlserver2008connections.Mssql2008standard
            varResult = String.Format(CultureInfo.CurrentCulture, "Server = {0},{1}; Database = {2}; User Id = {3}; password = {4};", serveraddress.Trim, serverport, databasename, username.Trim, password)
            Return varResult
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="serveraddress"></param>
        ''' <param name="databasename"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Mssql2008trustedconnection(serveraddress As String, databasename As String) As String Implements IMssqlserver2008connections.Mssql2008trustedconnection
            varResult = "Server = " & serveraddress.Trim & "; Database = " & databasename & "; Trusted_Connection = True;"
            Return varResult
        End Function
    End Class

    Public Class Mysqlconnection
        Implements IMysqlconnections

        Public Function Mysqlforcessl(serveraddress As String, serverport As Integer, databasename As String, username As String, password As String) As String Implements IMysqlconnections.Mysqlforcessl
            varResult = String.Format(CultureInfo.CurrentCulture, "Server={0};Database={1};Port={2};Uid={3};Pwd={4};SslMode=Required;", serveraddress, databasename, serverport, username, password)
            Return varResult
        End Function
    End Class

    Public Class LocalDBConnection
        Implements ILocaldbconnections

        Public Function LocalDBAttachDB(dbfilename As String) As String Implements ILocaldbconnections.LocalDBAttachDB
            varResult = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" & dbfilename & ";"
            Return varResult
        End Function

        Public Function LocalDBAutomaticInstance() As String Implements ILocaldbconnections.LocalDBAutomaticInstance
            varResult = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"
            Return varResult
        End Function

        Public Function LocalDBSpecifiedInstance(instancename As String) As String Implements ILocaldbconnections.LocalDBSpecifiedInstance
            varResult = "Server=(localdb)\" & instancename & ";Integrated Security=true;"
            Return varResult
        End Function

        Public Function LocalDBInitialCatalog(dbfilename As String) As String Implements ILocaldbconnections.LocalDBInitialCatalog
            varResult = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" & dbfilename & ";Encrypt=False; TrustServerCertificate=False;"
            Return varResult
        End Function
    End Class

    Public Class SQLiteConnection
        Implements ISqlite

        Public Function SQLiteBasic(dbfile As String) As String Implements ISqlite.SQLiteBasic
            'V_result = "Data Source=" & dbfile & ";Version=3;Mode=ReadWrite;Journal Mode=Off;"
            varResult = "Data Source=" & dbfile & ";Version=3;Journal Mode=Persist;Synchronous=Full;Max Page Count=5000;"
            Return varResult
        End Function

        Public Function SQLiteOpenWithPassword(dbfile As String, password As String) As String Implements ISqlite.SQLiteOpenWithPassword
            varResult = "Data Source=" & dbfile & ";password=" & password & ";"
            Return varResult
        End Function
    End Class
End Namespace
