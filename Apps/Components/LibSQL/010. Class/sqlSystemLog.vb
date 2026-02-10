Imports System.Runtime.Versioning

Namespace SystemLog.Activity

    Public Class User
        ReadOnly varDatabaseRequestMssql2008(1) As String
        ReadOnly varDatabaseRequestMysql(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub LoginFailed(databasename As String, dbengine As String, username As String)
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'Failed login with username : {0}', '{1}', '{2}', '{3}');", username, My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0))
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    varDatabaseRequestMysql(0) = String.Format("insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'Failed login with username : {0}', '{1}', '{2}', '{3}');", username, My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub LoginSuccess(databasename As String, dbengine As String, employeeid As String)
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Login Success', '{1}', '{2}', '{3}');", employeeid, My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0))
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL    
                    varDatabaseRequestMysql(0) = String.Format("insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Login Success', '{1}', '{2}', '{3}');", employeeid, My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Logout(databasename As String, dbengine As String, employeeid As String)
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Logout', '{1}', '{2}', '{3}');", employeeid, My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0))
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL    
                    varDatabaseRequestMysql(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Logout', '{1}', '{2}', '{3}');", employeeid, My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class

    Public Class Application
        ReadOnly varDatabaseReader(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub Run(databasename As String, dbengine As String)
            Try
                If dbengine = "MSSQL" Then
                    varDatabaseReader(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'INGRID start running.', '{0}', '{1}', '{2}');", My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseReader(0))
                ElseIf dbengine = "MYSQL" Then
                    varDatabaseReader(0) = String.Format("insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', now(), 'INGRID start running.', '{0}', '{1}', '{2}');", My.Computer.Name, My.Computer.Info.OSFullName, varAppVer)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseReader(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class
End Namespace
