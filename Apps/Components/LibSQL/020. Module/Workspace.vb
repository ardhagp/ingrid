Imports System.Runtime.Versioning

Namespace UI
    Public Class Workspace
        Private Shared ReadOnly tSysModule As String = "SysModule"

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetModuleProperties(dataproperties As LibApp.Ingrid.Global.Properties, commandcode As String, datasetname As System.Data.DataSet)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = ""
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select smod.module_code, " &
                                                   $"smod.module_name, " &
                                                   $"smod.module_description, " &
                                                   $"smod.module_appminimumver, " &
                                                   $"smod.module_ismaintenance, " &
                                                   $"smod.module_issystem " &
                                                   $"from sys_module smod " &
                                                   $"where smod.module_code = @CommandCode " &
                                                   $"limit 0,1;"
                    varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, tSysModule, dataproperties.AllParameters)
                End If
            Catch ex As Exception
                Decision("Error", $"Failed to retrieve module properties.{Environment.NewLine}Error Message: {ex.Message}", LibApp.Ingrid.Global.PopupType.Error, "GetModuleProperties", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
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
                    varValue = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
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
                    varValue = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varValue = String.Empty
            End Try
            Return varValue
        End Function
    End Class
End Namespace