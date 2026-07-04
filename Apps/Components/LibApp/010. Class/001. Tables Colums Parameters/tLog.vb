Namespace Table.Sys
    Public Class [Log]
        ReadOnly Property TableName As String = "sys_log"
        ReadOnly Property S As String = "log"
        ReadOnly Property C_LogId As String = "log_id"
        ReadOnly Property C_LogUser As String = "log_user"
        ReadOnly Property C_LogDate As String = "log_date"
        ReadOnly Property C_LogMessage As String = "log_message"
        ReadOnly Property C_LogMachine As String = "log_machine"
        ReadOnly Property C_LogOS As String = "log_os"
        ReadOnly Property C_LogAppVer As String = "log_appver"
        ReadOnly Property P_LogId As String = "@LogId"
        ReadOnly Property P_LogUser As String = "@LogUser"
        ReadOnly Property P_LogDate As String = "@LogDate"
        ReadOnly Property P_LogMessage As String = "@LogMessage"
        ReadOnly Property P_LogMachine As String = "@LogMachine"
        ReadOnly Property P_LogOS As String = "@LogOS"
        ReadOnly Property P_LogAppVer As String = "@LogAppVer"

    End Class
End Namespace
