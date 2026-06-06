Namespace Table.Sys
    ''' <summary>
    ''' Represents the "sys_module" table in the database, which stores information about system modules.
    ''' </summary>
    Public Class [Module]
        ReadOnly Property TableName As String = "sys_module"
        ReadOnly Property S As String = "mods"
        ReadOnly Property C_ModuleId As String = "module_id"
        ReadOnly Property C_ModuleCode As String = "module_code"
        ReadOnly Property C_ModuleName As String = "module_name"
        ReadOnly Property C_ModuleDescription As String = "module_description"
        ReadOnly Property C_ModuleIsMaintenance As String = "module_ismaintenance"
        ReadOnly Property C_ModuleIsSystem As String = "module_issystem"
        ReadOnly Property P_ModuleId As String = "@ModuleId"
        ReadOnly Property P_ModuleCode As String = "@ModuleCode"
        ReadOnly Property P_ModuleName As String = "@ModuleName"
        ReadOnly Property P_ModuleDescription As String = "@ModuleDescription"
        ReadOnly Property P_ModuleIsMaintenance As String = "@ModuleIsMaintenance"
        ReadOnly Property P_ModuleIsSystem As String = "@ModuleIsSystem"

    End Class
End Namespace
