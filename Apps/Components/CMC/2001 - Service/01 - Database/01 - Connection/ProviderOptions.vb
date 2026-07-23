
Namespace Database.Provider

    Public Class Options
        ''' <summary>
        ''' Type of protocol used to connect to the database server
        ''' </summary>
        Public Enum Protocol
            TCP
            SOCKET
        End Enum

        ''' <summary>
        ''' Mode of encryption used to connect to the database server
        ''' </summary>
        Public Enum Encryption
            Yes = 1
            No = 0
        End Enum

        ''' <summary>
        ''' Mode of character set used to connect to the database server
        ''' </summary>
        Public Enum CharSet
            UTF8
        End Enum

        ''' <summary>
        ''' Mode of ignore prepare statement used to connect to the database server
        ''' </summary>
        Public Enum IgnorePrepare
            Yes = 1
            No = 2
        End Enum

        ''' <summary>
        ''' Mode of shared memory name used to connect to the database server
        ''' </summary>
        Public Enum SharedMemoryName
            MYSQL = 1
        End Enum

        ''' <summary>
        ''' Mode of command logging used to connect to the database server
        ''' </summary>
        Public Enum CommandLogging
            Yes = 1
            No = 0
        End Enum

        ''' <summary>
        ''' Mode of compression used to connect to the database server
        ''' </summary>
        Public Enum Compression
            Yes = 1
            No = 0
        End Enum

        ''' <summary>
        ''' Mode of connection pooling used to connect to the database server
        ''' </summary>
        Public Enum Pooling
            Yes = 1
            No = 0
        End Enum

        ''' <summary>
        ''' Mode of direct connection used to connect to the database server
        ''' </summary>
        Public Enum Direct
            Yes = 1
            No = 0
        End Enum
    End Class
End Namespace
