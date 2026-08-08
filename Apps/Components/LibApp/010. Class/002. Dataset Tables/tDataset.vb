Namespace Table.Dataset
    Public Class [Name]
        ' dst is for dataset table names, not for column names
        Public ReadOnly dst_DatabaseProperties As String = "DatabaseProperties"
        Public ReadOnly dst_CheckRelation As String = "CheckRelation"
        Public ReadOnly dst_UserData As String = "UserData"
        Public ReadOnly dst_EplsEditor As String = "EPLS_Editor"
        Public ReadOnly dst_SyssEditor As String = "SYSS_Editor"
        Public ReadOnly dst_SysModule As String = "SysModule"

        'dbt is for database table names that stored in dataset
        Public ReadOnly dbt_Company As String = "man_company"
        Public ReadOnly dbt_Plant As String = "mat_plant"
        Public ReadOnly dbt_Department As String = "man_department"
        Public ReadOnly dbt_Position As String = "man_position"
    End Class
End Namespace