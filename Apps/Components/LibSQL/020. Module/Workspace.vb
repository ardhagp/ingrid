Imports System.Runtime.Versioning

Public Class Workspace
    <SupportedOSPlatform("windows")>
    Public Shared Function GetModuleName(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, tcode As String) As String
        Dim varValue As String = String.Empty

        Try
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select mods.module_name from dbo.sys_module mods where mods.module_code = '{0}'", tcode)
                varValue = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select mods.module_name from sys_module mods where mods.module_code = '{tcode}'"
                varValue = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If
        Catch ex As Exception
            varValue = String.Empty
        End Try
        Return varValue
    End Function

    <SupportedOSPlatform("windows")>
    Public Shared Function GetModuleDescription(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, tcode As String) As String
        Dim varValue As String = String.Empty

        Try
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select mods.module_description from sys_module mods where mods.module_code = '{0}'", tcode)
                varValue = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select mods.module_description from sys_module mods where mods.module_code = '{tcode}'"
                varValue = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If
        Catch ex As Exception
            varValue = String.Empty
        End Try
        Return varValue
    End Function
End Class
