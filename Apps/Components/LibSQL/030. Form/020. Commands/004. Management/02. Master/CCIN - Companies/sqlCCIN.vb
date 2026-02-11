Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDccin
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            Dim varWhere As String = "where "

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varWhere = String.Format("")
                Else
                    varWhere += String.Format(" (c.company_code ='{0}') or (c.company_name like '%{0}%') or (c.company_searchterm2 like '%{0}%') or (c.company_searchterm1 like '%{0}%') or (c.company_description " &
                                            "like '%{0}%')", find.XOSQLText)
                End If

                varDatabaseRequestMssql2008(0).Query = String.Format("SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.man_company c {0} " &
                                                        "ORDER BY C.company_code", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TCompany")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As Boolean
            Dim varSuccess As Boolean
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("delete from dbo.man_company where company_id='{0}'", rowid)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(0).Query)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    'TODO: implement mysql delete
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, code As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer
            Dim varWhere As String = "where "

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If rowid = "-1" Then
                    varWhere += String.Format(" c.company_code = '{0}'", code)
                Else
                    varWhere += String.Format(" c.company_code = '{0}' and c.company_id <> '{1}'", code, rowid)
                End If
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(c.company_id) as [isduplicate] from dbo.man_company c {0}", varWhere)
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: implement mysql duplicate check
            End If
            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, companycode As String, companyname As String, searchterm1 As String, searchterm2 As String, description As String, Optional rowid As String = "-1") As Boolean
            Dim varSuccess As Boolean

            Try
                If rowid = "-1" AndAlso dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    Dim varHash As String = CMCv.Security.Encrypt.MD5()
                    varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.man_company(company_id,company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", varHash, companycode, companyname, searchterm1, searchterm2, description)
                ElseIf rowid <> "-1" AndAlso dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.man_company set company_code='{0}',company_name='{1}',company_searchterm1='{2}',company_searchterm2='{3}',company_description='{4}' " &
                                                            "where company_id='{5}'", companycode, companyname, searchterm1, searchterm2, description, rowid)
                End If

                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    'TODO: implement mysql push data
                End If
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompanyCode(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, ByVal rowid As String) As String
            Dim varCode As String = String.Empty
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_code from dbo.man_company c where c.company_id = '{0}'", rowid)
                varCode = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: implement mysql get company code
            End If
            Return varCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompanyName(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varName As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_name from dbo.man_company c where c.company_id = '{0}'", rowid)
                varName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: implement mysql get company name
            End If
            Return varName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetSearchTerm1(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varSearchTerm As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_searchterm1 from dbo.man_company c where c.company_id = '{0}'", rowid)
                varSearchTerm = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: implement mysql get search term 1
            End If
            Return varSearchTerm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetSearchTerm2(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varSearchTerm As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_searchterm2 from dbo.man_company c where c.company_id = '{0}'", rowid)
                varSearchTerm = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: implement mysql get search term 2
            End If
            Return varSearchTerm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetDescription(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As String
            Dim varDesciption As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = String.Format("select c.company_description from dbo.man_company c where c.company_id = '{0}'", rowid)
                varDesciption = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: implement mysql get description
            End If
            Return varDesciption
        End Function
    End Class
End Namespace
