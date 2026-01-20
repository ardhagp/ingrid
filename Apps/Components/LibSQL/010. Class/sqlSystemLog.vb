Imports System.Runtime.Versioning

Namespace SystemLog.Activity

    Public Class User
        ReadOnly V_DBR_MSSQL2008(1) As String
        ReadOnly V_DBR_MySQL(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub LoginFailed(databasename As String, ByVal dbengine As String, ByVal username As String)
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'Failed login with username : {0}', '{1}', '{2}', '{3}');", username, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(0))
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MySQL(0) = String.Format("insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'Failed login with username : {0}', '{1}', '{2}', '{3}');", username, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MySQL(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub LoginSuccess(databasename As String, dbengine As String, eid As String)
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Login Success', '{1}', '{2}', '{3}');", eid, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(0))
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL    
                    V_DBR_MySQL(0) = String.Format("insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Login Success', '{1}', '{2}', '{3}');", eid, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MySQL(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Logout(databasename As String, dbengine As String, eid As String)
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Logout', '{1}', '{2}', '{3}');", eid, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(0))
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL    
                    V_DBR_MySQL(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Logout', '{1}', '{2}', '{3}');", eid, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MySQL(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class

    Public Class Application
        ReadOnly V_DB_Reader(1) As String

        <SupportedOSPlatform("windows")>
        Public Sub Run(databasename As String, ByVal dbengine As String)
            Try
                If dbengine = "MSSQL" Then
                    V_DB_Reader(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'INGRID start running.', '{0}', '{1}', '{2}');", My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MSSQL2008.PushData(databasename, V_DB_Reader(0))
                ElseIf dbengine = "MYSQL" Then
                    V_DB_Reader(0) = String.Format("insert into sys_log(log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', now(), 'INGRID start running.', '{0}', '{1}', '{2}');", My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                    V_DBE_MYSQL.PushData(databasename, V_DB_Reader(0))
                End If
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class
End Namespace
