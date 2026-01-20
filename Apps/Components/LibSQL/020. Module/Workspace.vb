Imports System
Imports System.Runtime.Versioning

Public Class Workspace
    <SupportedOSPlatform("windows")>
    Public Shared Function GetModuleName(databasename As String, dbengine As String, tcode As String) As String
        Dim varValue As String

        Try
            V_DBR_MSSQL2008(1).Query = String.Format("select mods.module_name from dbo.sys_module mods where mods.module_code = '{0}'", tcode)
            varValue = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString

        Catch ex As Exception
            varValue = String.Empty
        End Try
        Return varValue
    End Function

    <SupportedOSPlatform("windows")>
    Public Shared Function GetModuleDescription(databasename As String, dbengine As String, tcode As String) As String
        Dim varValue As String

        Try
            V_DBR_MSSQL2008(1).Query = String.Format("select mods.module_description from dbo.sys_module mods where mods.module_code = '{0}'", tcode)
            varValue = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString

        Catch ex As Exception
            varValue = String.Empty
        End Try
        Return varValue
    End Function
End Class
