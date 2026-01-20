Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Mainframe
    Public Class Database
        <SupportedOSPlatform("windows")>
        Public Shared Function Connect(Optional isproduction As Boolean = False, Optional splashscreen As Form = Nothing) As Boolean
            Dim varSuccess As Boolean
            Try
                V_DBE_SQLite.Open(isproduction)
                V_DB_Properties(1) = V_DBE_SQLite.GetDatabaseProperties(V_DB_Properties(1))

                If V_DB_Properties(1).DatabaseEngine = "MSSQL" AndAlso (V_DBE_MSSQL2008.Open(V_DB_Properties(1), splashscreen)) Then
                    varSuccess = True
                ElseIf V_DB_Properties(1).DatabaseEngine = "MYSQL" AndAlso (V_DBE_MYSQL.Open(V_DB_Properties(1), splashscreen)) Then
                    varSuccess = True
                Else
                    splashscreen?.Close()
                    varSuccess = False
                End If

                V_DBE_SQLite.Close()

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

            V_DBE_SQLite.Open(True)
            V_DB_Properties(1) = V_DBE_SQLite.GetDatabaseProperties(V_DB_Properties(1))
            varDBEngine = V_DB_Properties(1).DatabaseEngine
            V_DBE_SQLite.Close()
            Return varDBEngine
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DatabaseName() As String
            Dim varDBname As String

            V_DBE_SQLite.Open(True)
            V_DB_Properties(1) = V_DBE_SQLite.GetDatabaseProperties(V_DB_Properties(1))
            varDBname = V_DB_Properties(1).DatabaseName
            V_DBE_SQLite.Close()
            Return varDBname
        End Function
    End Class
End Namespace
