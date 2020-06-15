Imports CMCv

Namespace Commands.CCIN
    Public Class View
        Private _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        Public Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            Dim _Where As String = "where "

            If (Find.SLFSQLText = String.Empty) Or (ForceRefresh = True) Then
                _Where = String.Format("")
            Else
                _Where += String.Format(" (c.company_code ='{0}') or (c.company_name like '%{0}%') or (c.company_searchterm2 like '%{0}%') or (c.company_searchterm1 like '%{0}%') or (c.company_description like '%{0}%')", Find.SLFSQLText)
            End If

            _DBR_MSSQL2008(0).Query = String.Format("SELECT c.company_id, c.company_code, c.company_name, c.company_searchterm2, c.company_searchterm1, c.company_description FROM dbo.[[man]]company] c {0} ORDER BY C.company_code", _Where)

            _DBR_MSSQL2008(0).DataGrid = DataGrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TCompany")
        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(0).Query = String.Format("delete from dbo.[[man]]company] where company_id='{0}'", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function

    End Class

    Public Class Editor
        Public Function IsDuplicate(ByVal Code As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _IsDuplicate As Integer = 0
            Dim _Where As String = "where "
            If RowID = "-1" Then
                _Where += String.Format(" c.company_code = '{0}'", Code)
            Else
                _Where += String.Format(" c.company_code = '{0}' and c.company_id <> '{1}'", Code, RowID)
            End If

            _DBR_MSSQL2008(1).Query = String.Format("select count(c.company_id) as [isduplicate] from dbo.[[man]]company] c {0}", _Where)


            _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            If _IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function PUSHData(ByVal CompanyCode As String, ByVal CompanyName As String, ByVal SearchTerm1 As String, ByVal SearchTerm2 As String, ByVal Description As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _Success As Boolean = False

            Try
                If RowID = "-1" Then
                    Dim Hash As String = _SECEncrypt.MD5
                    _DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]company](company_id,company_code,company_name,company_searchterm1,company_searchterm2,company_description) values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, CompanyCode, CompanyName, SearchTerm1, SearchTerm2, Description)
                Else
                    _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]company] set company_code='{0}',company_name='{1}',company_searchterm1='{2}',company_searchterm2='{3}',company_description='{4}' where company_id='{5}'", CompanyCode, CompanyName, SearchTerm1, SearchTerm2, Description, RowID)
                End If
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function

        Public Function GETCompanyCode(ByVal RowID As String) As String
            Dim _Code As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select c.company_code from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _Code = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _Code
        End Function

        Public Function GETCompanyName(ByVal RowID As String) As String
            Dim _Name As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select c.company_name from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _Name = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _Name
        End Function

        Public Function GETSearchTerm1(ByVal RowID As String) As String
            Dim _SearchTerm As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select c.company_searchterm1 from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _SearchTerm = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _SearchTerm
        End Function

        Public Function GETSearchTerm2(ByVal RowID As String) As String
            Dim _SearchTerm As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select c.company_searchterm2 from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _SearchTerm = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _SearchTerm
        End Function

        Public Function GETDescription(ByVal RowID As String) As String
            Dim _Desciption As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select c.company_description from dbo.[[man]]company] c where c.company_id = '{0}'", RowID)
            _Desciption = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _Desciption
        End Function
    End Class
End Namespace
