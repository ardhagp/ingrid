
Imports System.Runtime.Versioning

Namespace CMDdbic
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
        Public Shared Function IsCompanyExist(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine) As Boolean
            Dim varIsExist As Integer

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select count(c.company_id) as [company_count] from dbo.man_company as c")
                varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select count(c.company_id) as `company_count` from man_company as c")
                varIsExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
            End If


            If varIsExist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDepartmentExist(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine) As Boolean
            Dim varIsExist As Integer

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select count(d.department_id) as [department_count] from dbo.man_department as d")
                varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select count(d.department_id) as `department_count` from man_department as d")
                varIsExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
            End If

            If varIsExist > 0 Then
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
