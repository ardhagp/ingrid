Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.POST
    Public Class View
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal Grid As dgn, ByVal Status As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            'ReDim V_DBR_MSSQL2008(2)
            Dim V_Where As String = "where "

            If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh) Then
                V_Where = String.Format("")
            Else
                V_Where += String.Format("(c.company_code Like '%{0}%') or (d.department_code like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%')", Find.XOSQLText)
            End If

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select c.company_code, d.department_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from dbo.[[man]]position] ps " &
                                                    "inner join dbo.[[man]]department] d on d.department_id = ps.position_departement inner join dbo.[[man]]company] c on c.company_id = d.department_company {0} " &
                                                    "order by c.company_code, d.department_code, ps.position_code", V_Where)

                V_DBR_MSSQL2008(0).DataGrid = Grid
                V_DBR_MSSQL2008(0).StatusBar = Status
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TPositions")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select c.company_code, d.department_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from man_position ps " &
                                                    "inner join man_department d on d.department_id = ps.position_departement inner join man_company c on c.company_id = d.department_company {0} " &
                                                    "order by c.company_code, d.department_code, ps.position_code", V_Where)

                V_DBR_MYSQL(0).DataGrid = Grid
                V_DBR_MYSQL(0).StatusBar = Status
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TPositions")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[man]]position] where (position_id = '{0}')", RowID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("delete from man_position where (position_id = '{0}')", RowID)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class

    Public Class Editor
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Sub FILLCompany(ByVal DBEngine As String, ByVal Company As cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as [company_name] from dbo.[[man]]company] c order by c.company_code"
                V_DBR_MSSQL2008(0).Dropdown = Company
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TCompany")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as `company_name` from man_company c order by c.company_code"
                V_DBR_MYSQL(0).Dropdown = Company
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TCompany")
            End If

            Company.ValueMember = "company_id"
            Company.DisplayMember = "company_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub FILLDepartement(ByVal DBEngine As String, ByVal Department As cbo, ByVal Company As cbo)
            Dim V_Department As String = String.Empty

            If Company.Items.Count <> 0 Then
                V_Department = Company.SelectedValue.ToString
            End If

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_id, (d.department_code + ' - ' + d.department_name) as [departement_code] from dbo.[[man]]department] d where d.department_company = '{0}' " &
                                                    "order by d.department_code", V_Department)
                V_DBR_MSSQL2008(0).Dropdown = Department
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "Departement")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select d.department_id, (d.department_code + ' - ' + d.department_name) as `departement_code` from man_department d where d.department_company = '{0}' " &
                                                    "order by d.department_code", V_Department)
                V_DBR_MYSQL(0).Dropdown = Department
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "Departement")
            End If

            Department.ValueMember = "department_id"
            Department.DisplayMember = "departement_code"
        End Sub

        <SupportedOSPlatform("Windows")>
        Public Shared Function GETCompanyID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_CompanyID As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select d.department_company from dbo.[[man]]position] ps inner join dbo.[[man]]department] d on d.department_id = ps.position_departement " &
                                                    "where ps.position_id = '{0}'", RowID)
                V_CompanyID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select d.department_company from man_position ps inner join man_department d on d.department_id = ps.position_departement " &
                                                    "where ps.position_id = '{0}'", RowID)
                V_CompanyID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If

            Return V_CompanyID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDepartmentID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_DepartementID As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_departement from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
                V_DepartementID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select ps.position_departement from man_position ps where ps.position_id = '{0}'", RowID)
                V_DepartementID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If

            Return V_DepartementID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionCode(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_PostitionCode As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_code from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
                V_PostitionCode = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select ps.position_code from man_position ps where ps.position_id = '{0}'", RowID)
                V_PostitionCode = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If

            Return V_PostitionCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionName(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_PostitionName As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_name from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
                V_PostitionName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select ps.position_name from man_position ps where ps.position_id = '{0}'", RowID)
                V_PostitionName = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If

            Return V_PostitionName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPositionDescription(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_PostitionDescription As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select ps.position_description from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
                V_PostitionDescription = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select ps.position_description from man_position ps where ps.position_id = '{0}'", RowID)
                V_PostitionDescription = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query).ToString
            End If

            Return V_PostitionDescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal Departement As String, ByVal PositionCode As String, ByVal RowID As String) As Boolean
            Dim V_IsDuplicate As Integer = 0
            Dim V_Where As String = "where "

            If RowID = "-1" Then
                V_Where += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}')", Departement, PositionCode)
            Else
                V_Where += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}' and ps.position_id <> '{2}')", Departement, PositionCode, RowID)
            End If

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(0).Query = String.Format("select (ps.position_id) as [rows] from dbo.[[man]]position] ps {0}", V_Where)
                V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(0).Query = String.Format("select (ps.position_id) as [rows] from man_position ps {0}", V_Where)
                V_IsDuplicate = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Integer)
            End If

            If V_IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal Department As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    If RowID = "-1" Then
                        Dim Hash As String = CMCv.Security.Encrypt.MD5()
                        V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]position](position_id, position_departement, position_code, position_name, position_description) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Department, Code, Name, Description)
                    Else
                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]position] set position_departement = '{0}', position_code = '{1}', position_name = '{2}', position_description = '{3}' " &
                                                            "where position_id = '{4}'", Department, Code, Name, Description, RowID)
                    End If
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    If RowID = "-1" Then
                        Dim Hash As String = CMCv.Security.Encrypt.MD5()
                        V_DBR_MYSQL(1).Query = String.Format("insert into man_position(position_id, position_departement, position_code, position_name, position_description) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Department, Code, Name, Description)
                    Else
                        V_DBR_MYSQL(1).Query = String.Format("update man_position set position_departement = '{0}', position_code = '{1}', position_name = '{2}', position_description = '{3}' " &
                                                            "where position_id = '{4}'", Department, Code, Name, Description, RowID)
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
