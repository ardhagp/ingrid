Imports System.Runtime.Versioning

Namespace UI
    Public Class Workspace
        Private Shared ReadOnly tSysModule As String = "SysModule"

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetModuleProperties(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object), commandcode As String, datasetname As System.Data.DataSet)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = ""
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select {tModule.S}.{tModule.C_ModuleCode}, " &
                                                   $"{tModule.S}.{tModule.C_ModuleName}, " &
                                                   $"{tModule.S}.{tModule.C_ModuleDescription}, " &
                                                   $"{tModule.S}.{tModule.C_ModuleAppMinimumVer}, " &
                                                   $"{tModule.S}.{tModule.C_ModuleIsMaintenance}, " &
                                                   $"{tModule.S}.{tModule.C_ModuleIsSystem} " &
                                                   $"from {tModule.TableName} {tModule.S} " &
                                                   $"where {tModule.S}.{tModule.C_ModuleCode} = {tModule.P_ModuleCode} " &
                                                   $"limit 0,1;"
                    varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, tSysModule, parametername)
                End If
            Catch ex As Exception
                Decision("Error", $"Failed to retrieve module properties.{Environment.NewLine}Error Message: {ex.Message}", LibApp.Ingrid.Global.PopupType.Error, "GetModuleProperties", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetModuleName(dataproperties As LibApp.Ingrid.Global.Properties, commandcode As String) As String
            Dim varValue As String = String.Empty
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"select mods.module_name from dbo.sys_module mods where mods.module_code = '{commandcode}'"
                    varValue = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"select mods.module_name from sys_module mods where mods.module_code = '{commandcode}'"
                    varValue = varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varValue = String.Empty
            End Try
            Return varValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetModuleDescription(dataproperties As LibApp.Ingrid.Global.Properties, commandcode As String) As String
            Dim varValue As String = String.Empty

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select mods.module_description from sys_module mods where mods.module_code = '{0}'", commandcode)
                    varValue = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"select mods.module_description from sys_module mods where mods.module_code = '{commandcode}'"
                    varValue = varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varValue = String.Empty
            End Try
            Return varValue
        End Function
    End Class
End Namespace