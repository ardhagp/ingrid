Imports CMCv

Namespace Commands.POST
    Public Class View
        Private _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        Public Sub DisplayData(ByVal Grid As dgn, ByVal Status As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            'ReDim _DBR_MSSQL2008(2)
            Dim _Where As String = "where "

            If (Find.SLFSQLText = String.Empty) And (ForceRefresh = True) Then
                _Where = String.Format("")
            Else
                _Where += String.Format("(c.company_code Like '%{0}%') or (d.departement_code like '%{0}%') or (ps.position_code like '%{0}%') or (ps.position_name like '%{0}%')", Find.SLFSQLText)
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select c.company_code, d.departement_code, ps.position_id, ps.position_code,ps.position_name, ps.position_description from dbo.[[man]]position] ps inner join dbo.[[man]]departement] d on d.departement_id = ps.position_departement inner join dbo.[[man]]company] c on c.company_id = d.departement_company {0} order by c.company_code, d.departement_code, ps.position_code", _Where)

            _DBR_MSSQL2008(0).DataGrid = Grid
            _DBR_MSSQL2008(0).StatusBar = Status
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TPositions")
        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False

            Try
                _DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[man]]position] where (position_id = '{0}')", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class

    Public Class Editor
        Private _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        Public Sub FILLCompany(ByVal Company As cbo)
            _DBR_MSSQL2008(0).Query = "select c.company_id, (c.company_code+ ' - ' + c.company_name) as [company_name] from dbo.[[man]]company] c order by c.company_code"
            _DBR_MSSQL2008(0).Dropdown = Company
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TCompany")
            Company.ValueMember = "company_id"
            Company.DisplayMember = "company_name"
        End Sub

        Public Sub FILLDepartement(ByVal Departement As cbo, ByVal Company As cbo)
            Dim _Departement As String = String.Empty

            If Not Company.Items.Count = 0 Then
                _Departement = Company.SelectedValue
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select d.departement_id, (d.departement_code + ' - ' + d.departement_name) as [departement_code] from dbo.[[man]]departement] d where d.departement_company = '{0}' order by d.departement_code", _Departement)
            _DBR_MSSQL2008(0).Dropdown = Departement
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "Departement")
            Departement.ValueMember = "departement_id"
            Departement.DisplayMember = "departement_code"
        End Sub

        Public Function GETCompanyID(ByVal RowID As String) As String
            Dim _CompanyID As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select d.departement_company from dbo.[[man]]position] ps inner join dbo.[[man]]departement] d on d.departement_id = ps.position_departement where ps.position_id = '{0}'", RowID)
            _CompanyID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _CompanyID
        End Function


        Public Function GETDepartementID(ByVal RowID As String) As String
            Dim _DepartementID As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select ps.position_departement from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            _DepartementID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _DepartementID
        End Function

        Public Function GETPositionCode(ByVal RowID As String) As String
            Dim _PostitionCode As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select ps.position_code from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            _PostitionCode = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _PostitionCode
        End Function

        Public Function GETPositionName(ByVal RowID As String) As String
            Dim _PostitionName As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select ps.position_name from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            _PostitionName = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _PostitionName
        End Function

        Public Function GETPositionDescription(ByVal RowID As String) As String
            Dim _PostitionDescription As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select ps.position_description from dbo.[[man]]position] ps where ps.position_id = '{0}'", RowID)
            _PostitionDescription = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _PostitionDescription
        End Function

        Public Function IsDuplicate(ByVal Departement As String, ByVal PositionCode As String, ByVal RowID As String) As Boolean
            Dim _IsDuplicate As Integer = 0
            Dim _Where As String = "where "

            If RowID = "-1" Then
                _Where += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}')", Departement, PositionCode)
            Else
                _Where += String.Format("(ps.position_departement = '{0}') and (ps.position_code = '{1}' and ps.position_id <> '{2}')", Departement, PositionCode, RowID)
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select (ps.position_id) as [rows] from dbo.[[man]]position] ps {0}", _Where)

            _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            If _IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function PUSHData(ByVal Departement As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim _Success As Boolean = False

            Try
                If RowID = "-1" Then
                    Dim Hash As String = _SECEncrypt.MD5
                    _DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[man]]position](position_id, position_departement, position_code, position_name, position_description) values ('{0}', '{1}', '{2}', '{3}', '{4}')", Hash, Departement, Code, Name, Description)
                Else
                    _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[man]]position] set position_departement = '{0}', position_code = '{1}', position_name = '{2}', position_description = '{3}' where position_id = '{4}'", Departement, Code, Name, Description, RowID)
                End If
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function
    End Class
End Namespace
