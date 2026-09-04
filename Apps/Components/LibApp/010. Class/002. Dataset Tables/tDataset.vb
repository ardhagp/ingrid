Namespace Table.Dataset
    Public Class [Name]
        ' dst is for dataset table names, not for column names
        Public ReadOnly DatabaseProperties As String = "DatabaseProperties"
        Public ReadOnly CheckRelation As String = "CheckRelation"
        Public ReadOnly UserData As String = "UserData"
        Public ReadOnly EplsEditor As String = "EPLS_Editor"
        Public ReadOnly SyssEditor As String = "SYSS_Editor"
        Public ReadOnly SysModule As String = "SysModule"
    End Class
End Namespace

Namespace Table.Database
    Public Class [Name]
        'dbt is for database table names that stored in dataset
        Public ReadOnly Company As String = "man_company"
        Public ReadOnly Plant As String = "mat_plant"
        Public ReadOnly Department As String = "man_department"
        Public ReadOnly Position As String = "man_position"
    End Class
End Namespace