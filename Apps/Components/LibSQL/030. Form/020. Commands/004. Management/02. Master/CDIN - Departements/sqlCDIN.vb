Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CDIN
    Public Class View
        ReadOnly _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim _Where As String = "where "

            If DBEngine = "MSSQL" Then
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    _Where = String.Format("")
                Else
                    _Where += String.Format(" (c.company_code like '%{0}%') or (d.department_code like '%{0}%') or (d.department_name like '%{0}%') or (d.department_description like '%{0}%')", Find.XOSQLText)
                End If

                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_id, c.company_code, d.department_code, d.department_name, d.department_description from dbo.[[man]]department] d inner join dbo.[[man]]company] c " &
                                                    "on d.department_company = c.company_id {0} order by c.company_code, d.department_code ", _Where)

                V_DBR_MSSQL2008(0).DataGrid = DataGrid
                V_DBR_MSSQL2008(0).StatusBar = StatusBar
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TDepartment")

            ElseIf DBEngine = "MYSQL" Then
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    _Where = String.Format("")
                Else
                    _Where += String.Format(" (c.company_code like '%{0}%') or (d.department_code like '%{0}%') or (d.department_name like '%{0}%') or (d.department_description like '%{0}%')", Find.XOSQLText)
                End If

                V_DBR_MYSQL(0).Query = String.Format("select d.department_id, c.company_code, d.department_code, d.department_name, d.department_description from man_department d inner join man_company] c " &
                                                    "on d.department_company = c.company_id {0} order by c.company_code, d.department_code ", _Where)

                V_DBR_MYSQL(0).DataGrid = DataGrid
                V_DBR_MYSQL(0).StatusBar = StatusBar
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TDepartment")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False
            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[man]]department] where (department_id = '{0}')", RowID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                    V_Success = True
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("delete from man_department where (department_id = '{0}')", RowID)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                    V_Success = True
                End If
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class

    Public Class Editor
        ReadOnly _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal CompanyID As String, ByVal DeptCode As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_IsDuplicate As Integer = 1
            Dim V_Where As String = "where "

            If DBEngine = "MSSQL" Then
                If RowID = "-1" Then
                    V_Where += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}')", CompanyID, DeptCode)
                Else
                    V_Where += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}') and (d.department_id <> '{2}')", CompanyID, DeptCode, RowID)
                End If

                V_DBR_MSSQL2008(0).Query = String.Format("select count(d.department_id) as [rows] from dbo.[[man]]department] d {0}", V_Where)

                V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)
            ElseIf DBEngine = "MYSQL" Then
                If RowID = "-1" Then
                    V_Where += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}')", CompanyID, DeptCode)
                Else
                    V_Where += String.Format("(d.department_company = '{0}') and (d.department_code = '{1}') and (d.department_id <> '{2}')", CompanyID, DeptCode, RowID)
                End If

                V_DBR_MYSQL(0).Query = String.Format("select count(d.department_id) as `rows` from man_department d {0}", V_Where)

                V_IsDuplicate = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Integer)
            End If

            If V_IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub FILLCompany(ByVal DBEngine As String, ByVal Company As cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as [company_code] from dbo.[[man]]company] c order by c.company_code"
                V_DBR_MSSQL2008(0).Dropdown = Company
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TCompany")
                Company.ValueMember = "company_id"
                Company.DisplayMember = "company_code"
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = "select c.company_id, (c.company_code + ' - ' + c.company_name) as `company_code` from man_company c order by c.company_code"
                V_DBR_MYSQL(0).Dropdown = Company
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TCompany")
                Company.ValueMember = "company_id"
                Company.DisplayMember = "company_code"
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyID(ByVal DBEngine As String, ByVal RowID As String) As Object
            Dim V_CompanyID As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_company from dbo.[[man]]department] d where d.department_id = '{0}'", RowID)
                V_CompanyID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select d.department_company from man_department d where d.department_id = '{0}'", RowID)
                V_CompanyID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If
            Return V_CompanyID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptCode(ByVal DBEngine As String, ByVal RowID As String) As Object
            Dim V_DeptCode As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_code from dbo.[[man]]department] d where d.department_id = '{0}'", RowID)
                V_DeptCode = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select d.department_code from man_department d where d.department_id = '{0}'", RowID)
                V_DeptCode = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If
            Return V_DeptCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDeptName(ByVal DBEngine As String, ByVal RowID As String) As Object
            Dim V_DeptName As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_name from dbo.[[man]]department] d where d.department_id = '{0}'", RowID)
                V_DeptName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select d.department_name from man_department d where d.department_id = '{0}'", RowID)
                V_DeptName = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If
            Return V_DeptName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDescription(ByVal DBEngine As String, ByVal RowID As String) As Object
            Dim V_Description As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_description from dbo.[[man]]department] d where d.department_id = '{0}'", RowID)
                V_Description = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select d.department_description from man_department d where d.department_id = '{0}'", RowID)
                V_Description = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If
            Return V_Description
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal Company As String, ByVal DepartementCode As String, ByVal DepartementName As String, ByVal DepartementDescription As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_Success As Boolean = False
            Try
                If DBEngine = "MSSQL" Then
                    If RowID = "-1" Then
                        Dim Hash As String = CMCv.Security.Encrypt.MD5()
                        V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]department](department_id, departement_company, departement_code, departement_name, departement_description) " &
                                                            "values('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Company, DepartementCode, DepartementName, DepartementDescription)
                    Else
                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]department] set departement_company = '{0}', departement_code = '{1}', departement_name = '{2}', departement_description = '{3}' " &
                                                            "where department_id = '{4}'", Company, DepartementCode, DepartementName, DepartementDescription, RowID)
                    End If

                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    If RowID = "-1" Then
                        Dim Hash As String = CMCv.Security.Encrypt.MD5()
                        V_DBR_MYSQL(1).Query = String.Format("insert into dbo.[[man]]department](department_id, departement_company, departement_code, departement_name, departement_description) " &
                                                            "values('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Company, DepartementCode, DepartementName, DepartementDescription)
                    Else
                        V_DBR_MYSQL(1).Query = String.Format("update man_department set departement_company = '{0}', departement_code = '{1}', departement_name = '{2}', departement_description = '{3}' " &
                                                            "where department_id = '{4}'", Company, DepartementCode, DepartementName, DepartementDescription, RowID)
                    End If

                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If
                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class
End Namespace
