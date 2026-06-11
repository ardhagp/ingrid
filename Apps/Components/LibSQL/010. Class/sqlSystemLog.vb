Imports System.Runtime.Versioning

Namespace SystemLog.Activity

    Public Class User
        ReadOnly varDatabaseRequestMssql2008(1) As String
        ReadOnly varDatabaseRequestMysql(1) As String

        Private Const pClientComputerName As String = "@ClientComputerName"
        Private Const pClientOSFullName As String = "@ClientOSFullName"
        Private Const pClientAppVersion As String = "@ClientAppVersion"

        <SupportedOSPlatform("windows")>
        Public Sub LoginFailed(dataproperties As LibApp.Ingrid.Global.Properties)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values(null, getdate(), 'Failed login with username : {tUser.P_Username}', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(0) = $"insert into {tLog.TableName}(" &
                                                 $"{tLog.C_LogUser}, " &
                                                 $"{tLog.C_LogDate}, " &
                                                 $"{tLog.C_LogMessage}, " &
                                                 $"{tLog.C_LogMachine}, " &
                                                 $"{tLog.C_LogOS}, " &
                                                 $"{tLog.C_LogAppVer}" &
                                                 $") values (" &
                                                 $"null, " &
                                                 $"now(), " &
                                                 $"'Failed login with username : {tUser.P_Username}', " &
                                                 $"{pClientComputerName}, " &
                                                 $"{pClientOSFullName}, " &
                                                 $"{pClientAppVersion});"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), dataproperties.AllParameters)
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub LoginSuccess(dataproperties As LibApp.Ingrid.Global.Properties)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values({tUser.P_UserId}, getdate(), 'Login Success', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL    
                    varDatabaseRequestMysql(0) = $"insert into {tLog.TableName}(" &
                                                 $"{tLog.C_LogUser}, " &
                                                 $"{tLog.C_LogDate}, " &
                                                 $"{tLog.C_LogMessage}, " &
                                                 $"{tLog.C_LogMachine}, " &
                                                 $"{tLog.C_LogOS}, " &
                                                 $"{tLog.C_LogAppVer}" &
                                                 $") values (" &
                                                 $"{tUser.P_UserId}, " &
                                                 $"now(), " &
                                                 $"'Login Success', " &
                                                 $"@ClientComputerName, " &
                                                 $"@ClientOSFullName, " &
                                                 $"@ClientAppVersion);"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), dataproperties.AllParameters)
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Logout(dataproperties As LibApp.Ingrid.Global.Properties)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values(@UserId, getdate(), 'Logout', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL    
                    varDatabaseRequestMysql(0) = $"insert into {tLog.TableName}(" &
                                                 $"{tLog.C_LogUser}, " &
                                                 $"{tLog.C_LogDate}, " &
                                                 $"{tLog.C_LogMessage}, " &
                                                 $"{tLog.C_LogMachine}, " &
                                                 $"{tLog.C_LogOS}, " &
                                                 $"{tLog.C_LogAppVer}" &
                                                 $") values (" &
                                                 $"{tUser.P_UserId}, " &
                                                 $"now(), " &
                                                 $"'Logout', " &
                                                 $"@ClientComputerName, " &
                                                 $"@ClientOSFullName, " &
                                                 $"@ClientAppVersion);"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), dataproperties.AllParameters)
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class

    Public Class Application

        ReadOnly varDatabaseReader(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub Run(dataproperties As LibApp.Ingrid.Global.Properties)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseReader(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values(null, getdate(), 'INGRID start running.', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseReader(0))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseReader(0) = $"insert into {tLog.TableName}(" &
                                           $"{tLog.C_LogUser}, " &
                                           $"{tLog.C_LogDate}, " &
                                           $"{tLog.C_LogMessage}, " &
                                           $"{tLog.C_LogMachine}, " &
                                           $"{tLog.C_LogOS}, " &
                                           $"{tLog.C_LogAppVer}" &
                                           $") values (" &
                                           $"null, " &
                                           $"now(), " &
                                           $"'INGRID start running.', " &
                                           $"@ClientComputerName, " &
                                           $"@ClientOSFullName, " &
                                           $"@ClientAppVersion);"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseReader(0), dataproperties.AllParameters)
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class
End Namespace
