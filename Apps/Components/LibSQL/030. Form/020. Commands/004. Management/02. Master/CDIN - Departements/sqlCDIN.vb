Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CDIN
    Public Class View
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            Dim varWhere As String = "where "

            If dbengine = "MSSQL" Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varWhere = String.Format("")
                Else
                    varWhere += String.Format(" (c.company_code like '%{0}%') or (d.department_code like '%{0}%') or (d.department_name like '%{0}%') or (d.department_description like '%{0}%')", find.XOSQLText)
                End If

                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_id, c.company_code, d.department_code, d.department_name, d.department_description from dbo.man_department d inner join dbo.man_company c " &
                                                    "on d.department_company = c.company_id {0} order by c.company_code, d.department_code ", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TDepartment")

            ElseIf dbengine = "MYSQL" Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varWhere = String.Format("")
                Else
                    varWhere += String.Format(" (c.company_code like '%{0}%') or (d.department_code like '%{0}%') or (d.department_name like '%{0}%') or (d.department_description like '%{0}%')", find.XOSQLText)
                End If

                varDatabaseRequestMysql(0).Query = String.Format("select d.department_id, c.company_code, d.department_code, d.department_name, d.department_description from man_department d inner join man_company] c " &
                                                    "on d.department_company = c.company_id {0} order by c.company_code, d.department_code ", varWhere)

                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TDepartment")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean = False
            Try
                If dbengine = "MSSQL" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.man_department where (department_id = '{0}')", rowid)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dbengine = "MYSQL" Then
                    varDatabaseRequestMysql(1).Query = String.Format("delete from man_department where (department_id = '{0}')", rowid)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

    Public Class Editor
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As String, companyid As String, deptcode As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer = 1
            Dim varWhere As String = "where "

            If dbengine = "MSSQL" Then
                If rowid = "-1" Then
                    varWhere += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}')", companyid, deptcode)
                Else
                    varWhere += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}') and (d.department_id <> '{2}')", companyid, deptcode, rowid)
                End If

                varDatabaseRequestMssql2008(0).Query = String.Format("select count(d.department_id) as [rows] from dbo.man_department d {0}", varWhere)

                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dbengine = "MYSQL" Then
                If rowid = "-1" Then
                    varWhere += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}')", companyid, deptcode)
                Else
                    varWhere += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}') and (d.department_id <> '{2}')", companyid, deptcode, rowid)
                End If

                varDatabaseRequestMysql(0).Query = String.Format("select count(d.department_id) as `rows` from man_department d {0}", varWhere)

                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub FillCompany(databasename As String, dbengine As String, company As cbo)
            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_code] from dbo.man_company c order by c.company_code"
                varDatabaseRequestMssql2008(0).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TCompany")
                company.ValueMember = "company_id"
                company.DisplayMember = "company_code"
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(0).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as `company_code` from man_company c order by c.company_code"
                varDatabaseRequestMysql(0).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TCompany")
                company.ValueMember = "company_id"
                company.DisplayMember = "company_code"
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompanyID(databasename As String, dbengine As String, rowid As String) As Object
            Dim varCompanyID As String = String.Empty

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_company from dbo.man_department d where d.department_id = '{0}'", rowid)
                varCompanyID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(0).Query = String.Format("select d.department_company from man_department d where d.department_id = '{0}'", rowid)
                varCompanyID = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varCompanyID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetDeptCode(databasename As String, dbengine As String, rowid As String) As Object
            Dim varDeptCode As String = String.Empty

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_code from dbo.man_department d where d.department_id = '{0}'", rowid)
                varDeptCode = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(0).Query = String.Format("select d.department_code from man_department d where d.department_id = '{0}'", rowid)
                varDeptCode = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varDeptCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptName(databasename As String, dbengine As String, rowid As String) As Object
            Dim varDeptName As String = String.Empty

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_name from dbo.man_department d where d.department_id = '{0}'", rowid)
                varDeptName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(0).Query = String.Format("select d.department_name from man_department d where d.department_id = '{0}'", rowid)
                varDeptName = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varDeptName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetDescription(databasename As String, dbengine As String, rowid As String) As Object
            Dim varDescription As String = String.Empty

            If dbengine = "MSSQL" Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_description from dbo.man_department d where d.department_id = '{0}'", rowid)
                varDescription = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                varDatabaseRequestMysql(0).Query = String.Format("select d.department_description from man_department d where d.department_id = '{0}'", rowid)
                varDescription = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varDescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, company As String, departementcode As String, departementname As String, departementdescription As String, Optional rowid As String = "-1") As Boolean
            Dim varSuccess As Boolean
            Dim varHash As String = CMCv.Security.Encrypt.MD5()
            Try
                If dbengine = "MSSQL" Then
                    If rowid = "-1" Then
                        varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.man_department(department_id, departement_company, departement_code, departement_name, departement_description) " &
                                                            "values('{0}', '{1}', '{2}', '{3}', '{4}')", varHash, company, departementcode, departementname, departementdescription)
                    Else
                        varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.man_department set departement_company = '{0}', departement_code = '{1}', departement_name = '{2}', departement_description = '{3}' " &
                                                            "where department_id = '{4}'", company, departementcode, departementname, departementdescription, rowid)
                    End If

                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    If rowid = "-1" Then
                        varDatabaseRequestMysql(1).Query = String.Format("insert into dbo.man_department(department_id, departement_company, departement_code, departement_name, departement_description) " &
                                                            "values('{0}', '{1}', '{2}', '{3}', '{4}')", varHash, company, departementcode, departementname, departementdescription)
                    Else
                        varDatabaseRequestMysql(1).Query = String.Format("update man_department set departement_company = '{0}', departement_code = '{1}', departement_name = '{2}', departement_description = '{3}' " &
                                                            "where department_id = '{4}'", company, departementcode, departementname, departementdescription, rowid)
                    End If

                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
