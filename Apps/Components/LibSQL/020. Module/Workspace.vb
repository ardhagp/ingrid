Imports System
Imports System.Runtime.Versioning

Public Class Workspace
    <SupportedOSPlatform("windows")>
    Public Shared Function GETModuleName(ByVal TCode As String) As String
        Dim _Value As String

        Try
            V_DBR_MSSQL2008(1).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_code = '{0}'", TCode)
            _Value = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

        Catch ex As Exception
            _Value = String.Empty
        End Try
        Return _Value
    End Function

    <SupportedOSPlatform("windows")>
    Public Shared Function GETModuleDescription(ByVal TCode As String) As String
        Dim _Value As String

        Try
            V_DBR_MSSQL2008(1).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_code = '{0}'", TCode)
            _Value = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

        Catch ex As Exception
            _Value = String.Empty
        End Try
        Return _Value
    End Function
End Class
