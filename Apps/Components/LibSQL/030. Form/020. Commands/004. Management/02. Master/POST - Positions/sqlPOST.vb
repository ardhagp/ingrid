Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDpost
    Public Class View
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, grid As CMCv.UI.Control.dgn, status As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            'ReDim varDatabaseRequestMssql2008(2)
            Dim varWhere As String = "where "

            If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format("(c.company_code Like '%{0}%') or (d.department_code like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%')", find.XOSQLText)
            End If

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_code, d.department_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from dbo.man_position ps " &
                                                    "inner join dbo.man_department d on d.department_id = ps.position_departement inner join dbo.man_company c on c.company_id = d.department_company {0} " &
                                                    "order by c.company_code, d.department_code, ps.position_code", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = grid
                varDatabaseRequestMssql2008(0).StatusBar = status
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TPositions")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_code, d.department_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from man_position ps " &
                                                    "inner join man_department d on d.department_id = ps.position_departement inner join man_company c on c.company_id = d.department_company {0} " &
                                                    "order by c.company_code, d.department_code, ps.position_code", varWhere)

                varDatabaseRequestMysql(0).DataGrid = grid
                varDatabaseRequestMysql(0).StatusBar = status
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TPositions")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.man_position where (position_id = '{0}')", rowid)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("delete from man_position where (position_id = '{0}')", rowid)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        'ReadOnly varDBreader_mssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, company As CMCv.UI.Control.cbo)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as [company_name] from dbo.man_company c order by c.company_code"
                varDatabaseRequestMssql2008(0).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TCompany")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as `company_name` from man_company c order by c.company_code"
                varDatabaseRequestMysql(0).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TCompany")
            End If
            company.ValueMember = "company_id"
            company.DisplayMember = "company_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillDepartement(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, department As CMCv.UI.Control.cbo, company As CMCv.UI.Control.cbo)
            Dim varDepartment As String = String.Empty

            If company.Items.Count <> 0 Then
                varDepartment = company.SelectedValue.ToString
            End If

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_id, (d.department_code + ' - ' + d.department_name) as [departement_code] from dbo.man_department d where d.department_company = '{0}' " &
                                                    "order by d.department_code", varDepartment)
                varDatabaseRequestMssql2008(0).Dropdown = department
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "Departement")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select d.department_id, (d.department_code + ' - ' + d.department_name) as `departement_code` from man_department d where d.department_company = '{0}' " &
                                                    "order by d.department_code", varDepartment)
                varDatabaseRequestMysql(0).Dropdown = department
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "Departement")
            End If
            department.ValueMember = "department_id"
            department.DisplayMember = "departement_code"
        End Sub

        <SupportedOSPlatform("Windows")>
        Public Shared Function GetCompanyID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varCompanyID As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select d.department_company from dbo.man_position ps inner join dbo.man_department d on d.department_id = ps.position_departement " &
                                                    "where ps.position_id = '{0}'", rowid)
                varCompanyID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select d.department_company from man_position ps inner join man_department d on d.department_id = ps.position_departement " &
                                                    "where ps.position_id = '{0}'", rowid)
                varCompanyID = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varCompanyID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetDepartmentID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varDepartementID As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_departement from dbo.man_position ps where ps.position_id = '{0}'", rowid)
                varDepartementID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select ps.position_departement from man_position ps where ps.position_id = '{0}'", rowid)
                varDepartementID = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varDepartementID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPositionCode(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varPostitionCode As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_code from dbo.man_position ps where ps.position_id = '{0}'", rowid)
                varPostitionCode = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select ps.position_code from man_position ps where ps.position_id = '{0}'", rowid)
                varPostitionCode = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varPostitionCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPositionName(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varPostitionName As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_name from dbo.man_position ps where ps.position_id = '{0}'", rowid)
                varPostitionName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select ps.position_name from man_position ps where ps.position_id = '{0}'", rowid)
                varPostitionName = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varPostitionName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPositionDescription(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varPostitionDescription As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select ps.position_description from dbo.man_position ps where ps.position_id = '{0}'", rowid)
                varPostitionDescription = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select ps.position_description from man_position ps where ps.position_id = '{0}'", rowid)
                varPostitionDescription = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query).ToString
            End If
            Return varPostitionDescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, departement As String, positioncode As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "where "

            If rowid = "-1" Then
                varWhere += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}')", departement, positioncode)
            Else
                varWhere += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}' and ps.position_id <> '{2}')", departement, positioncode, rowid)
            End If

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select (ps.position_id) as [rows] from dbo.man_position ps {0}", varWhere)
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = String.Format("select (ps.position_id) as [rows] from man_position ps {0}", varWhere)
                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, department As String, code As String, name As String, description As String, Optional ByVal rowid As String = "-1") As Boolean
            Dim varSuccess As Boolean = False
            Dim varHash As String = CMCv.Security.Encrypt.MD5()

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    If rowid = "-1" Then
                        varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.man_position(position_id, position_departement, position_code, position_name, position_description) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')", varHash, department, code, name, description)
                    Else
                        varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.man_position set position_departement = '{0}', position_code = '{1}', position_name = '{2}', position_description = '{3}' " &
                                                            "where position_id = '{4}'", department, code, name, description, rowid)
                    End If
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    If rowid = "-1" Then
                        varDatabaseRequestMysql(1).Query = String.Format("insert into man_position(position_id, position_departement, position_code, position_name, position_description) " &
                                                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')", varHash, department, code, name, description)
                    Else
                        varDatabaseRequestMysql(1).Query = String.Format("update man_position set position_departement = '{0}', position_code = '{1}', position_name = '{2}', position_description = '{3}' " &
                                                            "where position_id = '{4}'", department, code, name, description, rowid)
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
