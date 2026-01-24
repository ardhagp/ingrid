
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
        Public Shared Function IsCompanyExist(databasename As String, databaseengine As String) As Boolean
            Dim V_IsExist As Integer

            If databaseengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select count(c.company_id) as [company_count] from dbo.man_company as c")
                V_IsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            Else
                varDatabaseRequestMysql(0).Query = String.Format("select count(c.company_id) as `company_count` from man_company as c")
                V_IsExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
            End If


            If V_IsExist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDepartmentExist(databasename As String, dbengine As String) As Boolean
            Dim V_IsExist As Integer

            'TODO: Create MYSQL version
            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select count(d.department_id) as [department_count] from dbo.man_department as d")
                V_IsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(0).Query = String.Format("select count(d.department_id) as `department_count` from man_department as d")
                V_IsExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
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
