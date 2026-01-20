Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CCIN
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            Dim varWhere As String = "where "

            If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                varWhere = String.Format("")
            Else
                varWhere += String.Format(" (c.company_code ='{0}') or (c.company_name like '%{0}%') or (c.company_searchterm2 like '%{0}%') or (c.company_searchterm1 like '%{0}%') or (c.company_description " &
                                        "like '%{0}%')", find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.man_company c {0} " &
                                                    "ORDER BY C.company_code", varWhere)

            V_DBR_MSSQL2008(0).DataGrid = datagrid
            V_DBR_MSSQL2008(0).StatusBar = statusbar
            V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TCompany")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean
            Try
                V_DBR_MSSQL2008(0).Query = String.Format("delete from dbo.man_company where company_id='{0}'", rowid)
                V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(0).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As String, code As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer
            Dim varWhere As String = "where "

            If rowid = "-1" Then
                varWhere += String.Format(" c.company_code = '{0}'", code)
            Else
                varWhere += String.Format(" c.company_code = '{0}' and c.company_id <> '{1}'", code, rowid)
            End If

            V_DBR_MSSQL2008(1).Query = String.Format("select count(c.company_id) as [isduplicate] from dbo.man_company c {0}", varWhere)


            varIsDuplicate = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Integer)

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, companycode As String, companyname As String, searchterm1 As String, searchterm2 As String, description As String, Optional rowid As String = "-1") As Boolean
            Dim varSuccess As Boolean

            Try
                If rowid = "-1" Then
                    Dim varHash As String = CMCv.Security.Encrypt.MD5()
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.man_company(company_id,company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", varHash, companycode, companyname, searchterm1, searchterm2, description)
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.man_company set company_code='{0}',company_name='{1}',company_searchterm1='{2}',company_searchterm2='{3}',company_description='{4}' " &
                                                            "where company_id='{5}'", companycode, companyname, searchterm1, searchterm2, description, rowid)
                End If
                V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompanyCode(databasename As String, dbengine As String, ByVal rowid As String) As String
            Dim varCode As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_code from dbo.man_company c where c.company_id = '{0}'", rowid)
            varCode = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString
            Return varCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompanyName(databasename As String, dbengine As String, rowid As String) As String
            Dim varName As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_name from dbo.man_company c where c.company_id = '{0}'", rowid)
            varName = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString
            Return varName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetSearchTerm1(databasename As String, dbengine As String, rowid As String) As String
            Dim varSearchTerm As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_searchterm1 from dbo.man_company c where c.company_id = '{0}'", rowid)
            varSearchTerm = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString
            Return varSearchTerm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetSearchTerm2(databasename As String, dbengine As String, rowid As String) As String
            Dim varSearchTerm As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_searchterm2 from dbo.man_company c where c.company_id = '{0}'", rowid)
            varSearchTerm = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString
            Return varSearchTerm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetDescription(databasename As String, dbengine As String, rowid As String) As String
            Dim varDesciption As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_description from dbo.man_company c where c.company_id = '{0}'", rowid)
            varDesciption = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString
            Return varDesciption
        End Function
    End Class
End Namespace
