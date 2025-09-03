
Imports System.Runtime.Versioning

Namespace Commands.DBIC
    Public Structure Modules

    End Structure

    ''' <summary>
    ''' DB Integrity Check for Applications
    ''' </summary>
    Public Class Applications
        Public Shared Sub Settings()
            'put your code here
        End Sub

        Public Shared Sub NativeModules()
            'put your code here
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function IsCompanyExist(ByVal DatabaseEngine As String) As Boolean
            Dim V_IsExist As Integer

            If DatabaseEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select count(c.company_id) as [company_count] from dbo.[[man]]company] as c")
                V_IsExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)
            Else
                V_DBR_MYSQL(0).Query = String.Format("select count(c.company_id) as `company_count` from man_company as c")
                V_IsExist = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Integer)
            End If


            If V_IsExist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDepartmentExist(ByVal DBEngine As String) As Boolean
            Dim V_IsExist As Integer

            'TODO: Create MYSQL version
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select count(d.department_id) as [department_count] from dbo.[[man]]department] as d")
                V_IsExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select count(d.department_id) as `department_count` from man_department as d")
                V_IsExist = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Integer)
            End If


            If V_IsExist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        'Public Function IsEmployeePositionExist() As Integer
        'TODO: Make Function
        'End Function
    End Class

    ''' <summary>
    ''' DB Integrity Check for EPLS
    ''' </summary>
    Public Class EPLS
        Public Shared Sub Options()
            'put your code here
        End Sub
    End Class
End Namespace
