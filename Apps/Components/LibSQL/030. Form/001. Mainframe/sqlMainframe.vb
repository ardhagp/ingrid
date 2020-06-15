Imports CMCv
Imports System.Windows.Forms

Namespace Mainframe
    Public Class Database
        Public Function Connect(Optional ByVal IsProduction As Boolean = False, Optional ByVal SplashScreen As Form = Nothing) As Boolean
            Dim _Success As Boolean = False
            Try
                'Using MS Access Connection Properties
                '_DBE_MSACCESS2003.Open(IsProduction)
                '_DB_Properties(1) = _DBE_MSACCESS2003.GetDatabaseProperties(_DB_Properties(1))

                'Try Using LocalDB Connection Properties
                _DBE_LocalDB.Open(IsProduction)
                _DB_Properties(1) = _DBE_LocalDB.GetDatabaseProperties(_DB_Properties(1))

                If _DBE_MSSQL2008.Open(_DB_Properties(1), SplashScreen) = True Then
                    _Success = True
                Else
                    If SplashScreen IsNot Nothing Then
                        SplashScreen.Close()
                    End If
                    _Success = False
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                If SplashScreen IsNot Nothing Then
                    SplashScreen.Close()
                End If
                _Success = False
            End Try
            Return _Success
        End Function
    End Class
End Namespace
