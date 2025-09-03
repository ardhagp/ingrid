Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Mainframe
    Public Class Database
        <SupportedOSPlatform("windows")>
        Public Shared Function Connect(Optional ByVal IsProduction As Boolean = False, Optional ByVal SplashScreen As Form = Nothing) As Boolean
            Dim V_Success As Boolean
            Try
                V_DBE_SQLite.Open(IsProduction)
                V_DB_Properties(1) = V_DBE_SQLite.GetDatabaseProperties(V_DB_Properties(1))

                If V_DB_Properties(1).DatabaseEngine = "MSSQL" AndAlso (V_DBE_MSSQL2008.Open(V_DB_Properties(1), SplashScreen)) Then
                    V_Success = True
                ElseIf V_DB_Properties(1).DatabaseEngine = "MYSQL" AndAlso (V_DBE_MYSQL.Open(V_DB_Properties(1), SplashScreen)) Then
                    V_Success = True
                Else
                    SplashScreen?.Close()
                    V_Success = False
                End If

                V_DBE_SQLite.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
                SplashScreen?.Close()
                V_Success = False
            End Try

            Return V_Success
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DBEngine() As String
            Dim V_DBEngine As String

            V_DBE_SQLite.Open(True)
            V_DB_Properties(1) = V_DBE_SQLite.GetDatabaseProperties(V_DB_Properties(1))
            V_DBEngine = V_DB_Properties(1).DatabaseEngine
            V_DBE_SQLite.Close()
            Return V_DBEngine
        End Function
    End Class
End Namespace
