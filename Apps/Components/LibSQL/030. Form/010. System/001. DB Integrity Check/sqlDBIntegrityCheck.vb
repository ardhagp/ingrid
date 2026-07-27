
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
        Public Shared Function IsCompanyExist(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsExist As Integer

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = $"select count(com.company_id) as [company_count] " &
                                                       $"from dbo.man_company as com"
                varIsExist = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select count(com.company_id) as `company_count` " &
                                                   $"from man_company as com"
                varIsExist = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
            End If

            If varIsExist > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDepartmentExist(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsExist As Integer

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select count(d.department_id) as [department_count] from dbo.man_department as d")
                varIsExist = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select count(d.department_id) as `department_count` from man_department as d")
                varIsExist = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
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
    Public Class FRMepls
        Public Shared Sub Options()
            'put your code here
        End Sub
    End Class
End Namespace
