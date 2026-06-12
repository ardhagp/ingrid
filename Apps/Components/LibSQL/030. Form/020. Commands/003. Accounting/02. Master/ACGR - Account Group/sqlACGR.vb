Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDacgr
    Public Class View
#Region "Declaration"
        'ReadOnly varDBreader_mssql2008(3) As Database.Adapter.MsSql.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(dataproperties As LibApp.Ingrid.Global.Properties, company As CMCv.UI.Control.Cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.man_company cm order by cm.company_code")
                varDatabaseRequestMssql2008(1).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as `company_name` from man_company cm order by cm.company_code")
                varDatabaseRequestMysql(1).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TCompany")
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
        Public Shared Sub FillAccountingBook(dataproperties As LibApp.Ingrid.Global.Properties, accountingbook As CMCv.UI.Control.Cbo, company As CMCv.UI.Control.Cbo)
            Dim varCompanyID As String = String.Empty

            If company.Items.Count <> 0 Then
                varCompanyID = company.SelectedValue.ToString
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.ac_book ab inner join dbo.man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                varDatabaseRequestMssql2008(1).Dropdown = accountingbook
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TAccountingBook")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as `book_bookname` from ac_book ab inner join man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                varDatabaseRequestMysql(1).Dropdown = accountingbook
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TAccountingBook")
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
        Public Shared Sub GetAccountList(dataproperties As LibApp.Ingrid.Global.Properties, assets As CMCv.UI.Control.dgn, liability As CMCv.UI.Control.dgn, equity As CMCv.UI.Control.dgn, revenue As CMCv.UI.Control.dgn, expense As CMCv.UI.Control.dgn, accountingbook As CMCv.UI.Control.Cbo, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            Dim varCboIndex As String
            'Isikan index combobox dengan data dari mainframe
            varCboIndex = accountingbook.SelectedValue.ToString

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                'Tampilkan data awal / tanpa filter / ForceRefresh=True
                If (find.XOSqlText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMssql2008(0).DataGrid = assets
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TAssets")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMssql2008(0).DataGrid = liability
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TLiability")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMssql2008(0).DataGrid = equity
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TEquity")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMssql2008(0).DataGrid = revenue
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TRevenue")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMssql2008(0).DataGrid = expense
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TExpense")
                Else 'Tampilkan data berdasarkan filter
                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMssql2008(0).DataGrid = assets
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TAssets")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMssql2008(0).DataGrid = liability
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TLiability")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMssql2008(0).DataGrid = equity
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TEquity")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMssql2008(0).DataGrid = revenue
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TRevenue")

                    varDatabaseRequestMssql2008(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as [account_enable] from dbo.ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMssql2008(0).DataGrid = expense
                    varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TExpense")
                End If
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'Tampilkan data awal / tanpa filter / ForceRefresh=True
                If (find.XOSqlText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMysql(0).DataGrid = assets
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TAssets")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMysql(0).DataGrid = liability
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TLiability")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMysql(0).DataGrid = equity
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TEquity")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMysql(0).DataGrid = revenue
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TRevenue")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", varCboIndex)
                    varDatabaseRequestMysql(0).DataGrid = expense
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TExpense")
                Else 'Tampilkan data berdasarkan filter
                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '5417BC6652ACDD9848361A86AC910529' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMysql(0).DataGrid = assets
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TAssets")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '9350CB36E672BD4333FF51590CC06B7A' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMysql(0).DataGrid = liability
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TLiability")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'C5A59ADFD8978BE3B64F37B47ECDE743' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMysql(0).DataGrid = equity
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TEquity")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = 'F7E86014BCE4308D75F212605D711332' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMysql(0).DataGrid = revenue
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TRevenue")

                    varDatabaseRequestMysql(0).Query = String.Format("select acc.account_id,acc.account_num,acc.account_name, (case acc.account_enable when 0 then 'No' when 1 then 'Yes' end) as `account_enable` from ac_account acc " &
                                                        "where acc.account_book = '{0}' and acc.account_name like '%{1}%' and acc.account_group = '49A2747735077FAB5B2B0B96E67AC297' order by acc.account_num", varCboIndex, find.XOSqlText)
                    varDatabaseRequestMysql(0).DataGrid = expense
                    varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TExpense")
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As Boolean
            Dim varSuccess As Boolean

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.ac_account where account_id = '{0}'", rowid)
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("delete from ac_account where account_id = '{0}'", rowid)
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
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
        'ReadOnly varDBreader_mssql2008(3) As Database.Adapter.MsSql.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data company
        ''' </summary>
        ''' <param name="Company">ComboBox Company</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub FillCompany(dataproperties As LibApp.Ingrid.Global.Properties, company As CMCv.UI.Control.Cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as [company_name] from dbo.man_company cm order by cm.company_code")
                varDatabaseRequestMssql2008(1).Dropdown = company
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TCompany")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select cm.company_id, (cm.company_code + ' - ' + cm.company_name) as `company_name` from man_company cm order by cm.company_code")
                varDatabaseRequestMysql(1).Dropdown = company
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TCompany")
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
        Public Shared Sub FillAccountingBook(dataproperties As LibApp.Ingrid.Global.Properties, accountingbook As CMCv.UI.Control.Cbo, company As CMCv.UI.Control.Cbo)
            Dim varCompanyID As String = String.Empty

            If company.Items.Count <> 0 Then
                varCompanyID = company.SelectedValue.ToString
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as [book_bookname] from dbo.ac_book ab inner join dbo.man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                varDatabaseRequestMssql2008(1).Dropdown = accountingbook
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TAccountingBook")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ab.book_id, (ab.book_code + ' - ' + ab.book_bookname) as `book_bookname` from ac_book ab inner join man_company cm on ab.book_company = cm.company_id " &
                                                    "where ab.book_company = '{0}'", varCompanyID)
                varDatabaseRequestMysql(1).Dropdown = accountingbook
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TAccountingBook")
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
        Public Shared Sub FillAccountGroup(dataproperties As LibApp.Ingrid.Global.Properties, accountgroup As CMCv.UI.Control.Cbo)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from dbo.[[ac]]group] ag order by ag.group_order"
                varDatabaseRequestMssql2008(1).Dropdown = accountgroup
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1), "TAccountingBook")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = "select ag.group_id, ag.group_name + ' (' + ag.group_inline + ')' as group_name from ac_group ag order by ag.group_order"
                varDatabaseRequestMysql(1).Dropdown = accountgroup
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1), "TAccountingBook")
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
        Public Shared Function GetCompanyID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varCompanyID As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ab.book_company from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varCompanyID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ab.book_company from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varCompanyID = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
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
        Public Shared Function GetAccountBookID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varAccountBookID As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ab.book_id from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountBookID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ab.book_id from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountBookID = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
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
        Public Shared Function GetAccountGroupID(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varAccountGroupID As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ac.account_group from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountGroupID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ac.account_group from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountGroupID = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
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
        Public Shared Function GetAccountNumber(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varAccountNumber As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ac.account_num from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ac.account_num from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
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
        Public Shared Function GetAccountName(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As String
            Dim varAccountNumber As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select ac.account_name from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select ac.account_name from ac_account ac inner join ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                varAccountNumber = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
            End If
            Return varAccountNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEnableTransaction(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As Boolean
            Dim varEnableTransaction As Boolean = False

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select ac.account_enable from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                    varEnableTransaction = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("select ac.account_enable from dbo.ac_account ac inner join dbo.ac_book ab on ac.account_book = ab.book_id where ac.account_id = '{0}'", rowid)
                    varEnableTransaction = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Boolean)
                End If
            Catch ex As Exception
                varEnableTransaction = False
            End Try
            Return varEnableTransaction
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties, accountbookid As String, accountgroupid As String, accountnumber As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer = 0
            Dim varWhere As String = "where "

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                If rowid = "-1" Then
                    varWhere &= $"ac.account_book = '{accountbookid}' and ac.account_num = '{accountnumber}'"
                Else
                    varWhere &= String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", accountbookid, accountnumber, rowid)
                End If
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(ac.account_id) as [rows] from dbo.ac_account ac {0}", varWhere)
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                If rowid = "-1" Then
                    varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}'", accountbookid, accountnumber)
                Else
                    varWhere += String.Format("ac.account_book = '{0}' and ac.account_num = '{1}' and ac.account_id <> '{2}'", accountbookid, accountnumber, rowid)
                End If
                varDatabaseRequestMysql(1).Query = String.Format("select count(ac.account_id) as `rows` from ac_account ac {0}", varWhere)
                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Integer)
            End If

            If varIsDuplicate > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varSuccess As Boolean
            Try
                Dim varHash As String = CMCv.Security.Encrypt.MD5()

                If dataproperties.ConnectionDatabaseEngine = "MSSQL" Then
                    If Convert.ToString(dataproperties.AccountGroupId) = "-1" Then
                        varDatabaseRequestMssql2008(0).Query = $"insert into dbo.ac_account(account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                                   $"values('{varHash}', '{dataproperties.AccountBookId}','{dataproperties.AccountGroupId}','{dataproperties.AccountBookNumber}','{dataproperties.AccountBookName}','{dataproperties.AccountBookIsEnabled}')"
                    Else
                        varDatabaseRequestMssql2008(0).Query = $"update dbo.ac_account set account_num = '{dataproperties.AccountBookNumber}', account_name = '{dataproperties.AccountBookName}', account_enable = '{dataproperties.AccountBookIsEnabled}' where account_id = '{dataproperties.AccountGroupId}'"
                    End If
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query)
                ElseIf dataproperties.ConnectionDatabaseEngine = "MYSQL" Then
                    If Convert.ToString(dataproperties.AccountGroupId) = "-1" Then
                        varDatabaseRequestMysql(0).Query = $"insert into ac_account(account_id, account_book, account_group, account_num, account_name, account_enable) " &
                                               $"values('{varHash}', '{dataproperties.AccountBookId}','{dataproperties.AccountGroupId}','{dataproperties.AccountBookNumber}','{dataproperties.AccountBookName}','{dataproperties.AccountBookIsEnabled}')"
                    Else
                        varDatabaseRequestMysql(0).Query = $"update ac_account set account_num = '{dataproperties.AccountBookNumber}', account_name = '{dataproperties.AccountBookName}', account_enable = '{dataproperties.AccountBookIsEnabled}' where account_id = '{dataproperties.AccountGroupId}'"
                    End If
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class
End Namespace
