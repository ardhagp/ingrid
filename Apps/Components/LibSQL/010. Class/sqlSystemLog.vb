
Namespace SystemLog.Activity

    Public Class User
        Dim _DBR_MSSQL2008(1)

        Public Sub LoginFailed(ByVal Username As String)
            Try
                _DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'Failed login with username : {0}', '{1}', '{2}', '{3}');", Username, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0))
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub

        Public Sub LoginSuccess(ByVal EID As String)
            Try
                _DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Login Success', '{1}', '{2}', '{3}');", EID, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0))
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub

        Public Sub Logout(ByVal EID As String)
            Try
                _DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('{0}', getdate(), 'Logout', '{1}', '{2}', '{3}');", EID, My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0))
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class

    Public Class Application
        Dim _DBR_MSSQL2008(1)

        Public Sub Run()
            Try
                _DBR_MSSQL2008(0) = String.Format("insert into dbo.[[sys]]log](log_user, log_date, log_message, log_machine, log_os, log_appver) values('N/A', getdate(), 'INGRID start running.', '{0}', '{1}', '{2}');", My.Computer.Name, My.Computer.Info.OSFullName, _APPVer)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0))
            Catch ex As Exception
                Decision("Unable create log", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            End Try
        End Sub
    End Class
End Namespace
