
Namespace Commands

    Public Class Auththenticate
        Public Enum enuAuthType
            Read = 4
            Write = 2
            Execute = 1
        End Enum

        Public Function GETAccess(ByVal AuthType As enuAuthType, ByVal SysModule As String, ByVal UID As Integer) As Boolean
            Dim _IsAuth As Integer = 0

            If AuthType = enuAuthType.Read Then

            ElseIf AuthType = enuAuthType.Write Then

            ElseIf AuthType = enuAuthType.Execute Then

            End If

            _DBR_MSSQL2008(0).Query = ""
            _IsAuth = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            If _IsAuth = 0 Then
                Return False
            Else
                Return True
            End If
        End Function
    End Class
End Namespace
