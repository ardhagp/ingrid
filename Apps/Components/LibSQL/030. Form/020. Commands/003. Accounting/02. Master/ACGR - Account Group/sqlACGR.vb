Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.ACGR
    Public Class View
#Region "Variables"
        'ReadOnly varDBreader_mssql2008(3) As Database.Adapter.MSSQL2008.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLCompany(ByVal DBEngine As String, ByVal Company As cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.[[man]]company] cm order by cm.company_code")
                V_DBR_MSSQL2008(1).Dropdown = Company
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TCompany")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as `company_name` from man_company cm order by cm.company_code")
                V_DBR_MYSQL(1).Dropdown = Company
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TCompany")
            End If

            Company.DisplayMember = "company_name"
            Company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLAccountingBook(ByVal DBEngine As String, ByVal AccountingBook As cbo, ByVal Company As cbo)
            Dim V_CompanyID As String = String.Empty

            If Company.Items.Count <> 0 Then
                V_CompanyID = Company.SelectedValue.ToString
            End If

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.[[ac]]book] ab inner join dbo.[[man]]company] cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", V_CompanyID)
                V_DBR_MSSQL2008(1).Dropdown = AccountingBook
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TAccountingBook")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as `book_bookname` from ac_book ab inner join man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", V_CompanyID)
                V_DBR_MYSQL(1).Dropdown = AccountingBook
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TAccountingBook")
            End If

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
        <SupportedOSPlatform("windows")>
        Public Shared Sub GETAccountList(ByVal DBEngine As String, ByVal Assets As dgn, ByVal Liability As dgn, ByVal Equity As dgn, ByVal Revenue As dgn, ByVal Expense As dgn, ByVal AccountingBook As cbo, ByVal Find As txt, Optional ForceRefresh As Boolean = False)
            Dim V_CBO_Index As String
            'Isikan index combobox dengan data dari mainframe
            varCB_index = AccountingBook.SelectedValue.ToString

            If DBEngine = "MSSQL" Then
                'Tampilkan data awal / tanpa filter / ForceRefresh=True
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = Assets
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TAssets")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = Liability
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TLiability")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = Equity
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TEquity")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = Revenue
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TRevenue")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = Expense
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TExpense")
                Else 'Tampilkan data berdasarkan filter
                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = Assets
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TAssets")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = Liability
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TLiability")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = Equity
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TEquity")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = Revenue
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TRevenue")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.[[ac]]account] acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = Expense
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TExpense")
                End If
            ElseIf DBEngine = "MYSQL" Then
                'Tampilkan data awal / tanpa filter / ForceRefresh=True
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = Assets
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TAssets")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = Liability
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TLiability")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = Equity
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TEquity")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = Revenue
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TRevenue")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = Expense
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TExpense")
                Else 'Tampilkan data berdasarkan filter
                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = Assets
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TAssets")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = Liability
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TLiability")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = Equity
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TEquity")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = Revenue
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TRevenue")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index, Find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = Expense
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TExpense")
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[ac]]account] where account_id = '{0}'", RowID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("delete from ac_account where account_id = '{0}'", RowID)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function

    End Class

    Public Class Editor
#Region "Variables"
        'ReadOnly varDBreader_mssql2008(3) As Database.Adapter.MSSQL2008.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLCompany(ByVal DBEngine As String, ByVal Company As cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.[[man]]company] cm order by cm.company_code")
                V_DBR_MSSQL2008(1).Dropdown = Company
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TCompany")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as `company_name` from man_company cm order by cm.company_code")
                V_DBR_MYSQL(1).Dropdown = Company
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TCompany")
            End If

            Company.DisplayMember = "company_name"
            Company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLAccountingBook(ByVal DBEngine As String, ByVal AccountingBook As cbo, ByVal Company As cbo)
            Dim V_CompanyID As String = String.Empty

            If Company.Items.Count <> 0 Then
                V_CompanyID = Company.SelectedValue.ToString
            End If

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.[[ac]]book] ab inner join dbo.[[man]]company] cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", V_CompanyID)
                V_DBR_MSSQL2008(1).Dropdown = AccountingBook
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TAccountingBook")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as `book_bookname` from ac_book ab inner join man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", V_CompanyID)
                V_DBR_MYSQL(1).Dropdown = AccountingBook
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TAccountingBook")
            End If

            AccountingBook.DisplayMember = "book_bookname"
            AccountingBook.ValueMember = "book_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountGroup"></param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLAccountGroup(ByVal DBEngine As String, ByVal AccountGroup As cbo)
            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from dbo.[[ac]]group] ag order by ag.group_order"
                V_DBR_MSSQL2008(1).Dropdown = AccountGroup
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TAccountingBook")
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from ac_group ag order by ag.group_order"
                V_DBR_MYSQL(1).Dropdown = AccountGroup
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(1), "TAccountingBook")
            End If

            AccountGroup.DisplayMember = "group_name"
            AccountGroup.ValueMember = "group_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETCompanyID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_CompanyID As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_company from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_CompanyID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_company from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_CompanyID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_CompanyID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountBookID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_AccountBookID As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_id from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountBookID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_id from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountBookID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_AccountBookID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountGroupID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_AccountGroupID As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_group from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountGroupID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ac.account_group from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountGroupID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_AccountGroupID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountNumber(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_AccountNumber As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_num from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ac.account_num from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountNumber = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_AccountNumber
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccountName(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_AccountNumber As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_name from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ac.account_name from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                V_AccountNumber = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_AccountNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEnableTransaction(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_EnableTransaction As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_enable from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                    V_EnableTransaction = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Boolean)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("select ac.account_enable from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", RowID)
                    V_EnableTransaction = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), Boolean)
                End If
            Catch ex As Exception
                V_EnableTransaction = False
            End Try

            Return V_EnableTransaction
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal AccountBookID As String, ByVal AccountGroupID As String, ByVal AccountNumber As String, Optional RowID As String = "-1") As Boolean
            Dim V_IsDuplicate As Integer = 0
            Dim V_Where As String = "where "

            If DBEngine = "MSSQL" Then
                If RowID = "-1" Then
                    V_Where += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", AccountBookID, AccountNumber)
                Else
                    V_Where += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", AccountBookID, AccountNumber, RowID)
                End If

                V_DBR_MSSQL2008(1).Query = String.Format("select count(ac.account_id) as [rows] from dbo.[[ac]]account] ac {0}", V_Where)

                V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)
            ElseIf DBEngine = "MYSQL" Then
                If RowID = "-1" Then
                    V_Where += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", AccountBookID, AccountNumber)
                Else
                    V_Where += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", AccountBookID, AccountNumber, RowID)
                End If

                V_DBR_MYSQL(1).Query = String.Format("select count(ac.account_id) as `rows` from ac_account ac {0}", V_Where)

                V_IsDuplicate = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), Integer)
            End If

            If varISduplicate > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal AccountBookID As String, ByVal AccountGroupID As String, ByVal AccountNumber As String, ByVal AccountName As String, ByVal AccountEnable As Boolean, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_Success As Boolean
            Try
                Dim Hash As String = CMCv.Security.Encrypt.MD5()

                If DBEngine = "MSSQL" Then
                    If RowID = "-1" Then
                        V_DBR_MSSQL2008(0).Query = String.Format("insert into dbo.[[ac]]account](account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, AccountBookID, AccountGroupID, AccountNumber, AccountName, AccountEnable)
                    Else
                        V_DBR_MSSQL2008(0).Query = String.Format("update dbo.[[ac]]account] set account_num = '{0}', account_name = '{1}', account_enable = '{2}' where account_id = '{3}'", AccountNumber, AccountName, AccountEnable, RowID)
                    End If
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(0).Query)
                ElseIf DBEngine = "MYSQL" Then
                    If RowID = "-1" Then
                        V_DBR_MYSQL(0).Query = String.Format("insert into ac_account(account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", Hash, AccountBookID, AccountGroupID, AccountNumber, AccountName, AccountEnable)
                    Else
                        V_DBR_MYSQL(0).Query = String.Format("update ac_account set account_num = '{0}', account_name = '{1}', account_enable = '{2}' where account_id = '{3}'", AccountNumber, AccountName, AccountEnable, RowID)
                    End If
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(0).Query)
                End If
                V_Success = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
