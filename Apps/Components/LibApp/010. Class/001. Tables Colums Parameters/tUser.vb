Namespace Table.Sys
    Public Class [User]
        ReadOnly Property TableName As String = "sys_user"
        ReadOnly Property S As String = "usr"
        ReadOnly Property C_UserId As String = "user_id"
        ReadOnly Property C_UserEmployee As String = "user_employee"
        ReadOnly Property C_UserUsername As String = "user_username"
        ReadOnly Property C_UserPassword As String = "user_password"
        ReadOnly Property C_UserIsRoot As String = "user_isroot"
        ReadOnly Property C_UserIsLocked As String = "user_islocked"
        ReadOnly Property C_UserDateCreated As String = "user_datecreated"
        ReadOnly Property C_UserLastLogin As String = "user_lastlogin"
        ReadOnly Property P_UserId As String = "@UserId"
        ReadOnly Property P_Username As String = "@Username"
        ReadOnly Property P_UserPassword As String = "@UserPassword"
        ReadOnly Property P_UserIsRoot As String = "@UserIsRoot"
        ReadOnly Property P_UserIsLocked As String = "@UserIsLocked"
    End Class
End Namespace
