Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Mainframe
    Public Class Database
        Private Shared varQuery As String
        Private Const conCatalog As String = "catalog.db"

        <SupportedOSPlatform("windows")>
        Public Shared Function Connect(Optional splashscreen As Form = Nothing) As Boolean
            Dim varSuccess As Boolean
            Try
                varDatabaseEngineSqlite.Open(conCatalog)
                databaseproperties(1) = varDatabaseEngineSqlite.GetDatabaseProperties(databaseproperties(1))

                If databaseproperties(1).ConnectionDatabaseEngine = "MSSQL" AndAlso (varDatabaseEngineMssql2008.Open(databaseproperties(1), splashscreen)) Then
                    varSuccess = True
                ElseIf databaseproperties(1).ConnectionDatabaseEngine = "MYSQL" AndAlso (varDatabaseEngineMysql.Open(databaseproperties(1), splashscreen)) Then
                    varSuccess = True
                Else
                    splashscreen?.Close()
                    varSuccess = False
                End If

                varDatabaseEngineSqlite.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
                splashscreen?.Close()
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DatabaseEngine() As String
            Dim varDBengine As String

            varDatabaseEngineSqlite.Open(conCatalog)
            databaseproperties(1) = varDatabaseEngineSqlite.GetDatabaseProperties(databaseproperties(1))
            varDBengine = databaseproperties(1).ConnectionDatabaseEngine
            varDatabaseEngineSqlite.Close()
            Return varDBengine
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DatabaseName() As String
            Dim varDBname As String

            varDatabaseEngineSqlite.Open("catalog.db")
            databaseproperties(1) = varDatabaseEngineSqlite.GetDatabaseProperties(databaseproperties(1))
            varDBname = databaseproperties(1).ConnectionDatabaseName
            varDatabaseEngineSqlite.Close()
            Return varDBname
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetDatabaseProperties(datasetname As DataSet)
            varQuery = "SELECT [DATABASEENGINE],[DBFORDATA],[CLIENT] FROM [serverlist] WHERE [DEFAULTCONNECTION] = 1"

            varDatabaseEngineSqlite.Open(conCatalog)
            datasetname = varDatabaseEngineSqlite.FillDataSet(varQuery, datasetname, "DatabaseProperties")
        End Sub
    End Class
End Namespace
