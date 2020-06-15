

Public Class Workspace
    Public Function GETModuleName(ByVal TCode As String)
        Dim _Value As String = String.Empty

        Try
            _DBR_MSSQL2008(1).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_code = '{0}'", TCode)
            _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

        Catch ex As Exception
            _Value = String.Empty
        End Try
        Return _Value
    End Function

    Public Function GETModuleDescription(ByVal TCode As String)
        Dim _Value As String = String.Empty

        Try
            _DBR_MSSQL2008(1).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_code = '{0}'", TCode)
            _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

        Catch ex As Exception
            _Value = String.Empty
        End Try
        Return _Value
    End Function
End Class
