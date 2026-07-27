Namespace Mainframe
    ''' <summary>
    ''' This class is used to connect to the database and get the database properties.
    ''' </summary>
    Public Class Database
        Private Shared varQuery As String
        Private Const conCatalog As String = "catalog.db"

        ''' <summary>
        ''' This function is used to connect to the database. It will first connect to the SQLite database and get the database properties. Then it will connect to the database engine specified in the database properties. If the connection is successful, it will return True, otherwise it will return False.
        ''' </summary>
        ''' <returns>True if the connection is successful; otherwise, False.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Connect(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean
            Try
                varDatabaseEngineSqlite.Open(conCatalog)
                varDataProperties = varDatabaseEngineSqlite.GetDatabaseProperties(dataproperties)
                If varDataProperties.ConnectionDatabaseEngine = "MSSQL" AndAlso (varDatabaseEngineMssql2008.Open(varDataProperties)) Then
                    varSuccess = True
                ElseIf varDataProperties.ConnectionDatabaseEngine = "MYSQL" AndAlso (varDatabaseEngineMysql.Open(varDataProperties)) Then
                    varSuccess = True
                Else
                    varSuccess = False
                End If

                varDatabaseEngineSqlite.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                varSuccess = False
            End Try
            Return varSuccess
        End Function

        ''' <summary>
        ''' This function is used to get the database engine from the database properties. It will first connect to the SQLite database and get the database properties. Then it will return the database engine specified in the database properties.
        ''' </summary>
        ''' <returns>The database engine specified in the database properties.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function DatabaseEngine() As String
            Dim varDBengine As String

            varDatabaseEngineSqlite.Open(conCatalog)
            varDataProperties = varDatabaseEngineSqlite.GetDatabaseProperties(varDataProperties)
            varDBengine = varDataProperties.ConnectionDatabaseEngine
            varDatabaseEngineSqlite.Close()
            Return varDBengine
        End Function

        ''' <summary>
        ''' This function is used to get the database name from the database properties. It will first connect to the SQLite database and get the database properties. Then it will return the database name specified in the database properties.
        ''' </summary>
        ''' <returns>The database name specified in the database properties.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function DatabaseName() As String
            Dim varDBname As String

            varDatabaseEngineSqlite.Open(conCatalog)
            varDataProperties = varDatabaseEngineSqlite.GetDatabaseProperties(varDataProperties)
            varDBname = varDataProperties.ConnectionDatabaseName
            varDatabaseEngineSqlite.Close()
            Return varDBname
        End Function

        ''' <summary>
        ''' This function is used to get the database properties from the SQLite database. It will first connect to the SQLite database and get the database properties. Then it will fill the dataset with the database properties.
        ''' </summary>
        ''' <param name="datasetname">The dataset to fill with the database properties.</param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub GetDatabaseProperties(datasetname As System.Data.DataSet)
            varQuery = "SELECT [DATABASEENGINE], [DBFORDATA], [CLIENT] FROM [serverlist] WHERE [DEFAULTCONNECTION] = 1"

            varDatabaseEngineSqlite.Open(conCatalog)
            varDatabaseEngineSqlite.FillDataSet(varQuery, datasetname, "DatabaseProperties")
            varDatabaseEngineSqlite.Close()
        End Sub
    End Class
End Namespace
