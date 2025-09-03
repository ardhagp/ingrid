Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.CCIN
    Public Class View
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Sub DISPLAYDATA(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim V_Where As String = "where "

            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                V_Where = String.Format("")
            Else
                V_Where += String.Format(" (c.company_code ='{0}') or (c.company_name like '%{0}%') or (c.company_searchterm2 like '%{0}%') or (c.company_searchterm1 like '%{0}%') or (c.company_description " &
                                        "like '%{0}%')", Find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).Query = String.Format("SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.[[man]]company] c {0} " &
                                                    "ORDER BY C.company_code", V_Where)

            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TCompany")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEDATA(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean
            Try
                V_DBR_MSSQL2008(0).Query = String.Format("delete from dbo.[[man]]company] where company_id='{0}'", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(0).Query)
                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal Code As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_IsDuplicate As Integer
            Dim V_Where As String = "where "

            If RowID = "-1" Then
                V_Where += String.Format(" c.company_code = '{0}'", Code)
            Else
                V_Where += String.Format(" c.company_code = '{0}' and c.company_id <> '{1}'", Code, RowID)
            End If

            V_DBR_MSSQL2008(1).Query = String.Format("select count(c.company_id) as [isduplicate] from dbo.[[man]]company] c {0}", V_Where)


            V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

            If V_IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal CompanyCode As String, ByVal CompanyName As String, ByVal SearchTerm1 As String, ByVal SearchTerm2 As String, ByVal Description As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_Success As Boolean

            Try
                If RowID = "-1" Then
                    Dim Hash As String = CMCv.Security.Encrypt.MD5()
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]company](company_id,company_code,company_name,company_searchterm1,company_searchterm2,company_description) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, CompanyCode, CompanyName, SearchTerm1, SearchTerm2, Description)
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]company] set company_code='{0}',company_name='{1}',company_searchterm1='{2}',company_searchterm2='{3}',company_description='{4}' " &
                                                            "where company_id='{5}'", CompanyCode, CompanyName, SearchTerm1, SearchTerm2, Description, RowID)
                End If
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyCode(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _Code As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_code from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _Code = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            Return _Code
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyName(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _Name As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_name from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _Name = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            Return _Name
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETSearchTerm1(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _SearchTerm As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_searchterm1 from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _SearchTerm = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            Return _SearchTerm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETSearchTerm2(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _SearchTerm As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_searchterm2 from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _SearchTerm = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            Return _SearchTerm
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETDescription(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _Desciption As String
            V_DBR_MSSQL2008(0).Query = String.Format("select c.company_description from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _Desciption = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
            Return _Desciption
        End Function
    End Class
End Namespace
