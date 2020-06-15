Imports CMCv

Namespace Commands.ACGR
    Public Class View
#Region "Variables"
        Private _DBR_MSSQL2008(3) As Database.Adapter.MSSQL2008.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        Public Sub FILLCompany(ByVal Company As cbo)
            _DBR_MSSQL2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.[[man]]company] cm order by cm.company_code")
            _DBR_MSSQL2008(1).Dropdown = Company
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TCompany")
            Company.DisplayMember = "company_name"
            Company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        Public Sub FILLAccountingBook(ByVal AccountingBook As cbo, ByVal Company As cbo)
            Dim _CompanyID As String = String.Empty

            If Not Company.Items.Count = 0 Then
                _CompanyID = Company.SelectedValue
            End If

            _DBR_MSSQL2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.[[ac]]book] ab inner join dbo.[[man]]company] cm on ab.book_company = cm.company_id where ab.book_company = '{0}'", _CompanyID)
            _DBR_MSSQL2008(1).Dropdown = AccountingBook
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TAccountingBook")
            AccountingBook.DisplayMember = "book_bookname"
            AccountingBook.ValueMember = "book_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data nama akun dari database
        ''' </summary>
        ''' <param name="Assets">Datagrid untuk menampilkan akun Asset / Harta</param>
        ''' <param name="Liability">Datagrid untuk menampilkan akun Liability / Hutang</param>
        ''' <param name="Equity">Datagrid untuk menampilkan akun Equity / Modal</param>
        ''' <param name="Revenue">Datagrid untuk menampilkan akun Revenue / Pendapatan</param>
        ''' <param name="Expense">Datagrid untuk menampilkan akun Expense / Pengeluaran</param>
        ''' <param name="AccountingBook">ComboBox yang berisi Buku Akuntansi</param>
        ''' <param name="Find">TextBox Pencarian</param>
        ''' <param name="ForceRefresh">True / False</param>
        ''' <remarks>ForceRefresh = True akan menampilkan semua data tanpa filter</remarks>
        Public Sub GETAccountList(ByVal Assets As dgn, ByVal Liability As dgn, ByVal Equity As dgn, ByVal Revenue As dgn, ByVal Expense As dgn, ByVal AccountingBook As cbo, ByVal Find As txt, Optional ForceRefresh As Boolean = False)
            Dim _CBO_Index As String = String.Empty
            'Isikan index combobox dengan data dari mainframe
            _CBO_Index = AccountingBook.SelectedValue

            'Tampilkan data awal / tanpa filter / ForceRefresh=True
            If (Find.SLFSQLText = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", _CBO_Index)
                _DBR_MSSQL2008(0).DataGrid = Assets
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAssets")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", _CBO_Index)
                _DBR_MSSQL2008(0).DataGrid = Liability
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TLiability")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", _CBO_Index)
                _DBR_MSSQL2008(0).DataGrid = Equity
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TEquity")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", _CBO_Index)
                _DBR_MSSQL2008(0).DataGrid = Revenue
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TRevenue")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", _CBO_Index)
                _DBR_MSSQL2008(0).DataGrid = Expense
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TExpense")
            Else 'Tampilkan data berdasarkan filter
                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(0).DataGrid = Assets
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAssets")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(0).DataGrid = Liability
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TLiability")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(0).DataGrid = Equity
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TEquity")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(0).DataGrid = Revenue
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TRevenue")

                _DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(0).DataGrid = Expense
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TExpense")
            End If
        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[ac]]account] where account_id = '{0}'", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function

    End Class

    Public Class Editor
#Region "Variables"
        Private _DBR_MSSQL2008(3) As Database.Adapter.MSSQL2008.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        Public Sub FILLCompany(ByVal Company As cbo)
            _DBR_MSSQL2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.[[man]]company] cm order by cm.company_code")
            _DBR_MSSQL2008(1).Dropdown = Company
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TCompany")
            Company.DisplayMember = "company_name"
            Company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        Public Sub FILLAccountingBook(ByVal AccountingBook As cbo, ByVal Company As cbo)
            Dim _CompanyID As String = String.Empty
            If Not Company.Items.Count = 0 Then
                _CompanyID = Company.SelectedValue
            End If

            _DBR_MSSQL2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.[[ac]]book] ab inner join dbo.[[man]]company] cm on ab.book_company = cm.company_id where ab.book_company = '{0}'", _CompanyID)
            _DBR_MSSQL2008(1).Dropdown = AccountingBook
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TAccountingBook")
            AccountingBook.DisplayMember = "book_bookname"
            AccountingBook.ValueMember = "book_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountGroup"></param>
        ''' <remarks></remarks>
        Public Sub FILLAccountGroup(ByVal AccountGroup As cbo)
            _DBR_MSSQL2008(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from dbo.[[ac]]group] ag order by ag.group_order"
            _DBR_MSSQL2008(1).Dropdown = AccountGroup
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TAccountingBook")
            AccountGroup.DisplayMember = "group_name"
            AccountGroup.ValueMember = "group_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETCompanyID(ByVal RowID As String) As String
            Dim _CompanyID As String = String.Empty
            _DBR_MSSQL2008(1).Query = String.Format("select ab.book_company from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            _CompanyID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Return _CompanyID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountBookID(ByVal RowID As String) As String
            Dim _AccountBookID As String = "-1"
            _DBR_MSSQL2008(1).Query = String.Format("select ab.book_id from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            _AccountBookID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Return _AccountBookID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountGroupID(ByVal RowID As String) As String
            Dim _AccountGroupID As String = "-1"
            _DBR_MSSQL2008(1).Query = String.Format("select ac.account_group from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            _AccountGroupID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Return _AccountGroupID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountNumber(ByVal RowID As String) As String
            Dim _AccountNumber As String = String.Empty
            _DBR_MSSQL2008(1).Query = String.Format("select ac.account_num from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            _AccountNumber = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Return _AccountNumber
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountName(ByVal RowID As String) As String
            Dim _AccountNumber As String = String.Empty
            _DBR_MSSQL2008(1).Query = String.Format("select ac.account_name from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            _AccountNumber = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Return _AccountNumber
        End Function

        Public Function GETEnableTransaction(ByVal RowID As String) As Boolean
            Dim _EnableTransaction As Boolean = False
            _DBR_MSSQL2008(1).Query = String.Format("select ac.account_enable from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
            _EnableTransaction = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)
            Return _EnableTransaction
        End Function

        Public Function IsDuplicate(ByVal AccountBookID As String, ByVal AccountGroupID As String, ByVal AccountNumber As String, Optional RowID As String = "-1") As Boolean
            Dim _IsDuplicate As Integer = 0
            Dim _Where As String = "where "

            If RowID = "-1" Then
                _Where += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", AccountBookID, AccountNumber)
            Else
                _Where += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", AccountBookID, AccountNumber, RowID)
            End If

            _DBR_MSSQL2008(1).Query = String.Format("select count(ac.account_id) as [rows] from dbo.[[ac]]account] ac {0}", _Where)

            _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

            If _IsDuplicate > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function PUSHData(ByVal AccountBookID As String, ByVal AccountGroupID As String, ByVal AccountNumber As String, ByVal AccountName As String, ByVal AccountEnable As Boolean, Optional ByVal RowID As String = "-1") As Boolean
            Dim _Success As Boolean = False
            Try
                If RowID = "-1" Then
                    Dim Hash As String = _SECEncrypt.MD5
                    _DBR_MSSQL2008(0).Query = String.Format("insert into dbo.[[ac]]account](account_id, account_book, account_group, account_num, account_name, account_enable) values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, AccountBookID, AccountGroupID, AccountNumber, AccountName, AccountEnable)
                Else
                    _DBR_MSSQL2008(0).Query = String.Format("update dbo.[[ac]]account] set account_num = '{0}', account_name = '{1}', account_enable = '{2}' where account_id = '{3}'", AccountNumber, AccountName, AccountEnable, RowID)
                End If
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function

    End Class
End Namespace
