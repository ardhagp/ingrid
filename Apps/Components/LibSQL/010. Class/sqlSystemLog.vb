Imports System.Runtime.Versioning

Namespace SystemLog.Activity

    Public Class User
        ReadOnly varDatabaseRequestMssql2008(1) As String
        ReadOnly varDatabaseRequestMysql(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub LoginFailed(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, username As String)
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values(null, getdate(), 'Failed login with username : {username}', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0))
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(0) = $"insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values(null, now(), 'Failed login with username : {username}', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(0))
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub LoginSuccess(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, employeeid As String)
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{employeeid}', getdate(), 'Login Success', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0))
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL    
                    varDatabaseRequestMysql(0) = $"insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('{employeeid}', now(), 'Login Success', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(0))
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Logout(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, employeeid As String)
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{employeeid}', getdate(), 'Logout', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0))
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL    
                    varDatabaseRequestMysql(0) = $"insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('{employeeid}', now(), 'Logout', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(0))
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class

    Public Class Application
        ReadOnly varDatabaseReader(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub Run(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine)
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseReader(0) = $"insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values(null, getdate(), 'INGRID start running.', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseReader(0))
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseReader(0) = $"insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values(null, now(), 'INGRID start running.', '{My.Computer.Name}', '{My.Computer.Info.OSFullName}', '{varAppVer}');"
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseReader(0))
                End If
            Catch ex As Exception
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable create log", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class
End Namespace
