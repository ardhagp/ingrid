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
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function Microsoftoledbstandard(ByVal DatabasePath As String, ByVal Username As String, ByVal Password As String) As String
#End Region

#Region "ODBC"
        ''' <summary>
        ''' Koneksi database Access 2003 Standard
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Function Microsoftodbcstandard(ByVal DatabasePath As String, ByVal Username As String, ByVal Password As String) As String
#End Region
    End Interface

    Friend Interface IMssqlserver2008connections
#Region ".NET Standard"

        ''' <summary>
        ''' Koneksi SQL Server 2008 Standard
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="DatabaseName">Nama database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Password</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Mssql2008standard(ByVal ServerAddress As String, ByVal ServerPort As Integer, ByVal DatabaseName As String, ByVal Username As String, ByVal Password As String) As String

        ''' <summary>
        ''' Koneksi SQL Server 2008 Trusted Connection
        ''' </summary>
        ''' <param name="ServerAddress">Alamat server</param>
        ''' <param name="DatabaseName">Nama database</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function Mssql2008trustedconnection(ByVal ServerAddress As String, ByVal DatabaseName As String) As String
#End Region
    End Interface

    Friend Interface IMysqlconnections

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress">Database server address</param>
        ''' <param name="ServerPort">Database port</param>
        ''' <param name="DatabaseName">Database name</param>
        ''' <param name="Username">Username to access database</param>
        ''' <param name="Password">PPassword to access dadtabase</param>
        ''' <returns></returns>
        Function Mysqlforcessl(ByVal ServerAddress As String, ByVal ServerPort As Integer, ByVal DatabaseName As String, ByVal Username As String, ByVal Password As String) As String
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
        ''' <param name="DBFileName"></param>
        ''' <returns></returns>
        Function LocalDBAttachDB(ByVal DBFileName As String) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="InstanceName"></param>
        ''' <returns></returns>
        Function LocalDBSpecifiedInstance(ByVal InstanceName As String) As String

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DBFileName"></param>
        ''' <returns></returns>
        Function LocalDBInitialCatalog(ByVal DBFileName As String) As String

    End Interface

    Friend Interface ISqlite
        Function SQLiteBasic(ByVal DBFile As String) As String

        Function SQLiteOpenWithPassword(ByVal DBFile As String, ByVal Password As String) As String

    End Interface

    '-----------------------------------------------------------------------------
    Public Class MSAccess2003Connection
        Implements IMsaccess2003connections
        ''' <summary>
        ''' Koneksi database Access 2003
        ''' </summary>
        ''' <param name="DatabasePath">Direktori database</param>
        ''' <param name="Username">Username</param>
        ''' <param name="Password">Kata sandi</param>
        ''' <returns>String</returns>
        ''' <remarks></remarks>
        Public Function Microsoftodbcstandard(DatabasePath As String, Username As String, Password As String) As String Implements IMsaccess2003connections.Microsoftodbcstandard
            V_result = "Driver={Microsoft Access Driver (*.mdb)};Dbq=" & DatabasePath & ";Uid=" & Username & ";Pwd=" & Password & ";"
            Return V_result
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="DatabasePath"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Microsoftoledbstandard(DatabasePath As String, Username As String, Password As String) As String Implements IMsaccess2003connections.Microsoftoledbstandard
            V_result = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabasePath & ";User Id=" & Username & ";Password=" & Password & ";"
            Return V_result
        End Function
    End Class

    Public Class MSSQLServer2008Connection
        Implements IMssqlserver2008connections

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="ServerPort"></param>
        ''' <param name="DatabaseName"></param>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Mssql2008standard(ServerAddress As String, ByVal ServerPort As Integer, ByVal DatabaseName As String, Username As String, Password As String) As String Implements IMssqlserver2008connections.Mssql2008standard
            V_result = String.Format(CultureInfo.CurrentCulture, "Server = {0},{1}; Database = {2}; User Id = {3}; Password = {4};", ServerAddress.Trim, ServerPort, DatabaseName, Username.Trim, Password)
            Return V_result
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="ServerAddress"></param>
        ''' <param name="DatabaseName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Mssql2008trustedconnection(ServerAddress As String, DatabaseName As String) As String Implements IMssqlserver2008connections.Mssql2008trustedconnection
            V_result = "Server = " & ServerAddress.Trim & "; Database = " & DatabaseName & "; Trusted_Connection = True;"
            Return V_result
        End Function
    End Class

    Public Class MySQLConnection
        Implements IMysqlconnections

        Public Function Mysqlforcessl(ServerAddress As String, ServerPort As Integer, DatabaseName As String, Username As String, Password As String) As String Implements IMysqlconnections.Mysqlforcessl
            V_result = String.Format(CultureInfo.CurrentCulture, "Server={0};Database={1};Port={2};Uid={3};Pwd={4};SslMode=Required;", ServerAddress, DatabaseName, ServerPort, Username, Password)
            Return V_result
        End Function
    End Class

    Public Class LocalDBConnection
        Implements ILocaldbconnections

        Public Function LocalDBAttachDB(DBFileName As String) As String Implements ILocaldbconnections.LocalDBAttachDB
            V_result = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" & DBFileName & ";"
            Return V_result
        End Function

        Public Function LocalDBAutomaticInstance() As String Implements ILocaldbconnections.LocalDBAutomaticInstance
            V_result = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;"
            Return V_result
        End Function

        Public Function LocalDBSpecifiedInstance(InstanceName As String) As String Implements ILocaldbconnections.LocalDBSpecifiedInstance
            V_result = "Server=(localdb)\" & InstanceName & ";Integrated Security=true;"
            Return V_result
        End Function

        Public Function LocalDBInitialCatalog(DBFileName As String) As String Implements ILocaldbconnections.LocalDBInitialCatalog
            V_result = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" & DBFileName & ";Encrypt=False; TrustServerCertificate=False;"
            Return V_result
        End Function
    End Class

    Public Class SQLiteConnection
        Implements ISqlite

        Public Function SQLiteBasic(DBFile As String) As String Implements ISqlite.SQLiteBasic
            'V_result = "Data Source=" & DBFile & ";Version=3;Mode=ReadWrite;Journal Mode=Off;"
            V_result = "Data Source=" & DBFile & ";Version=3;Journal Mode=Persist;Synchronous=Full;Max Page Count=5000;"
            Return V_result
        End Function

        Public Function SQLiteOpenWithPassword(DBFile As String, Password As String) As String Implements ISqlite.SQLiteOpenWithPassword
            V_result = "Data Source=" & DBFile & ";Password=" & Password & ";"
            Return V_result
        End Function
    End Class
End Namespace
