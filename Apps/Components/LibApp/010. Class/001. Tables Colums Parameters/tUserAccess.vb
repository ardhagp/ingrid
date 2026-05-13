Namespace Table.Sys
    Public Class [UserAccess]
        ReadOnly Property TableName As String = "sys_useraccess"
        ReadOnly Property C_UserAccessId As String = "useraccess_id"
        ReadOnly Property C_UserAccessUser As String = "useraccess_user"
        ReadOnly Property C_UserAccessModule As String = "useraccess_module"
        ReadOnly Property C_UserAccessView As String = "useraccess_view"
        ReadOnly Property C_UserAccessAdd As String = "useraccess_add"
        ReadOnly Property C_UserAccessEdit As String = "useraccess_edit"
        ReadOnly Property C_UserAccessDelete As String = "useraccess_delete"
        ReadOnly Property C_UserAccessReports As String = "useraccess_reports"

        ReadOnly Property P_UserAccessId As String = "@UserAccessId"
        ReadOnly Property P_UserAccessView As String = "@UserAccessView"
        ReadOnly Property P_UserAccessAdd As String = "@UserAccessAdd"
        ReadOnly Property P_UserAccessEdit As String = "@UserAccessEdit"
        ReadOnly Property P_UserAccessDelete As String = "@UserAccessDelete"
        ReadOnly Property P_UserAccessReports As String = "@UserAccessReports"
    End Class
End Namespace
