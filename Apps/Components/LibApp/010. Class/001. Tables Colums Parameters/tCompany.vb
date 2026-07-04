Namespace Table.Man
    Public Class [Company]
        ReadOnly Property TableName As String = "man_company"
        ReadOnly Property S As String = "com"
        ReadOnly Property C_CompanyId As String = "company_id"
        ReadOnly Property C_CompanyCode As String = "company_code"
        ReadOnly Property C_CompanyName As String = "company_name"
        ReadOnly Property C_SearchTerm1 As String = "company_searchterm1"
        ReadOnly Property C_SearchTerm2 As String = "company_searchterm2"
        ReadOnly Property C_Description As String = "company_description"
        ReadOnly Property P_CompanyId As String = "@CompanyId"
        ReadOnly Property P_CompanyCode As String = "@CompanyCode"
        ReadOnly Property P_CompanyName As String = "@CompanyName"
        ReadOnly Property P_SearchTerm1 As String = "@SearchTerm1"
        ReadOnly Property P_SearchTerm2 As String = "@SearchTerm2"
        ReadOnly Property P_Description As String = "@Description"
    End Class
End Namespace