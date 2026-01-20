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
        Public Shared Sub FillCompany(databasename As String, dbengine As String, company As cbo)
            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.man_company cm order by cm.company_code")
                V_DBR_MSSQL2008(1).Dropdown = company
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(1), "TCompany")
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as `company_name` from man_company cm order by cm.company_code")
                V_DBR_MYSQL(1).Dropdown = company
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(1), "TCompany")
            End If

            company.DisplayMember = "company_name"
            company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FillAccountingBook(databasename As String, dbengine As String, accountingbook As cbo, company As cbo)
            Dim varCompanyID As String = String.Empty

            If company.Items.Count <> 0 Then
                varCompanyID = company.SelectedValue.ToString
            End If

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.ac_book ab inner join dbo.man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                V_DBR_MSSQL2008(1).Dropdown = accountingbook
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(1), "TAccountingBook")
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as `book_bookname` from ac_book ab inner join man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                V_DBR_MYSQL(1).Dropdown = accountingbook
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(1), "TAccountingBook")
            End If

            accountingbook.DisplayMember = "book_bookname"
            accountingbook.ValueMember = "book_id"
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
        Public Shared Sub GetAccountList(databasename As String, dbengine As String, assets As dgn, liability As dgn, equity As dgn, revenue As dgn, expense As dgn, accountingbook As cbo, find As txt, Optional forcerefresh As Boolean = False)
            Dim V_CBO_Index As String = String.Empty
            'Isikan index combobox dengan data dari mainframe
            V_CBO_Index = accountingbook.SelectedValue.ToString

            If dbengine = "MSSQL" Then
                'Tampilkan data awal / tanpa filter / ForceRefresh=True
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = assets
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TAssets")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = liability
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TLiability")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = equity
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TEquity")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = revenue
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TRevenue")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index)
                    V_DBR_MSSQL2008(0).DataGrid = expense
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TExpense")
                Else 'Tampilkan data berdasarkan filter
                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = assets
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TAssets")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = liability
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TLiability")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = equity
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TEquity")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = revenue
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TRevenue")

                    V_DBR_MSSQL2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MSSQL2008(0).DataGrid = expense
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TExpense")
                End If
            ElseIf dbengine = "MYSQL" Then
                'Tampilkan data awal / tanpa filter / ForceRefresh=True
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = assets
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TAssets")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = liability
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TLiability")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = equity
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TEquity")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = revenue
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TRevenue")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index)
                    V_DBR_MYSQL(0).DataGrid = expense
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TExpense")
                Else 'Tampilkan data berdasarkan filter
                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = assets
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TAssets")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = liability
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TLiability")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = equity
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TEquity")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = revenue
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TRevenue")

                    V_DBR_MYSQL(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", V_CBO_Index, find.XOSQLText)
                    V_DBR_MYSQL(0).DataGrid = expense
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TExpense")
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean

            Try
                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.ac_account where account_id = '{0}'", rowid)
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("delete from ac_account where account_id = '{0}'", rowid)
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
                End If

                varSuccess = True
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
        Public Shared Sub FillCompany(databasename As String, dbengine As String, company As cbo)
            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.man_company cm order by cm.company_code")
                V_DBR_MSSQL2008(1).Dropdown = company
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(1), "TCompany")
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as `company_name` from man_company cm order by cm.company_code")
                V_DBR_MYSQL(1).Dropdown = company
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(1), "TCompany")
            End If

            company.DisplayMember = "company_name"
            company.ValueMember = "company_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FillAccountingBook(databasename As String, dbengine As String, accountingbook As cbo, company As cbo)
            Dim varCompanyID As String = String.Empty

            If company.Items.Count <> 0 Then
                varCompanyID = company.SelectedValue.ToString
            End If

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.ac_book ab inner join dbo.man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                V_DBR_MSSQL2008(1).Dropdown = accountingbook
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(1), "TAccountingBook")
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as `book_bookname` from ac_book ab inner join man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                V_DBR_MYSQL(1).Dropdown = accountingbook
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(1), "TAccountingBook")
            End If

            accountingbook.DisplayMember = "book_bookname"
            accountingbook.ValueMember = "book_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountGroup"></param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FillAccountGroup(databasename As String, dbengine As String, accountgroup As cbo)
            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from dbo.[[ac]]group] ag order by ag.group_order"
                V_DBR_MSSQL2008(1).Dropdown = accountgroup
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(1), "TAccountingBook")
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from ac_group ag order by ag.group_order"
                V_DBR_MYSQL(1).Dropdown = accountgroup
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(1), "TAccountingBook")
            End If

            accountgroup.DisplayMember = "group_name"
            accountgroup.ValueMember = "group_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetCompanyID(databasename As String, dbengine As String, rowid As String) As String
            Dim varCompanyID As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_company from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varCompanyID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_company from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varCompanyID = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varCompanyID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAccountBookID(databasename As String, dbengine As String, rowid As String) As String
            Dim varAccountBookID As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ab.book_id from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountBookID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ab.book_id from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountBookID = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varAccountBookID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAccountGroupID(databasename As String, dbengine As String, rowid As String) As String
            Dim varAccountGroupID As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_group from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountGroupID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ac.account_group from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountGroupID = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varAccountGroupID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAccountNumber(databasename As String, dbengine As String, rowid As String) As String
            Dim varAccountNumber As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_num from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ac.account_num from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varAccountNumber
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAccountName(databasename As String, dbengine As String, rowid As String) As String
            Dim varAccountNumber As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_name from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select ac.account_name from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varAccountNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEnableTransaction(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varEnableTransaction As Boolean = False

            Try
                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select ac.account_enable from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                    varEnableTransaction = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Boolean)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("select ac.account_enable from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                    varEnableTransaction = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query), Boolean)
                End If
            Catch ex As Exception
                varEnableTransaction = False
            End Try

            Return varEnableTransaction
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As String, accountbookid As String, accountgroupid As String, accountnumber As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "where "

            If dbengine = "MSSQL" Then
                If rowid = "-1" Then
                    varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", accountbookid, accountnumber)
                Else
                    varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", accountbookid, accountnumber, rowid)
                End If

                V_DBR_MSSQL2008(1).Query = String.Format("select count(ac.account_id) as [rows] from dbo.ac_account ac {0}", varWhere)

                varIsDuplicate = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Integer)
            ElseIf dbengine = "MYSQL" Then
                If rowid = "-1" Then
                    varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", accountbookid, accountnumber)
                Else
                    varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", accountbookid, accountnumber, rowid)
                End If

                V_DBR_MYSQL(1).Query = String.Format("select count(ac.account_id) as `rows` from ac_account ac {0}", varWhere)

                varIsDuplicate = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query), Integer)
            End If

            If varIsDuplicate > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, accountbookid As String, accountgroupid As String, accountnumber As String, accountname As String, accountenable As Boolean, Optional rowid As String = "-1") As Boolean
            Dim varSuccess As Boolean = False
            Try
                Dim varHash As String = CMCv.Security.Encrypt.MD5()

                If dbengine = "MSSQL" Then
                    If rowid = "-1" Then
                        V_DBR_MSSQL2008(0).Query = String.Format("insert into dbo.ac_account(account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", varHash, accountbookid, accountgroupid, accountnumber, accountname, accountenable)
                    Else
                        V_DBR_MSSQL2008(0).Query = String.Format("update dbo.ac_account set account_num = '{0}', account_name = '{1}', account_enable = '{2}' where account_id = '{3}'", accountnumber, accountname, accountenable, rowid)
                    End If
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(0).Query)
                ElseIf dbengine = "MYSQL" Then
                    If rowid = "-1" Then
                        V_DBR_MYSQL(0).Query = String.Format("insert into ac_account(account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                                            "values('{0}', '{1}','{2}','{3}','{4}','{5}')", varHash, accountbookid, accountgroupid, accountnumber, accountname, accountenable)
                    Else
                        V_DBR_MYSQL(0).Query = String.Format("update ac_account set account_num = '{0}', account_name = '{1}', account_enable = '{2}' where account_id = '{3}'", accountnumber, accountname, accountenable, rowid)
                    End If
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(0).Query)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
