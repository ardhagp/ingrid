Imports CMCv

Namespace Commands
    Public Class AccountGroup
#Region "Variables"
        Private _DBR_MSSQL2008(3) As Database.Engine.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data plant
        ''' </summary>
        ''' <param name="cPlant">ComboBox Plant</param>
        ''' <remarks></remarks>
        Public Sub GETPlant(ByVal cPlant As cbo)
            _DBR_MSSQL2008(2).Query = "select p.plant_id, (p.plant_code + ' - ' + p.plant_name) as [plant_name] from dbo.[[mm]]plant] p"
            _DBR_MSSQL2008(2).Dropdown = cPlant
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(2), "TPlant")
            cPlant.DisplayMember = "plant_name"
            cPlant.ValueMember = "plant_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        Public Sub GETAccountingBook(ByVal AccountingBook As cbo, ByVal cPlant As cbo)
            Dim _PlantID As Integer = -1
            If Not cPlant.Items.Count = 0 Then
                _PlantID = cPlant.SelectedValue
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select ab.acbook_id, (ab.acbook_code + ' - ' + ab.acbook_bookname) as [acbook_bookname] from dbo.[[ac]]book] ab inner join dbo.[[mm]]plant] pl on ab.acbook_plant = pl.plant_id where ab.acbook_plant = {0}", _PlantID)
            _DBR_MSSQL2008(0).Dropdown = AccountingBook
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAccountingBook")
            AccountingBook.DisplayMember = "acbook_bookname"
            AccountingBook.ValueMember = "acbook_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data nama akun dari database
        ''' </summary>
        ''' <param name="Assets">Datagrid untuk menampilkan akun Asset / Harta</param>
        ''' <param name="Liability">Datagrid untuk menampilkan akun Liability / Hutang</param>
        ''' <param name="Capital">Datagrid untuk menampilkan akun Capital / Modal</param>
        ''' <param name="Wage">Datagrid untuk menampilkan akun Wage / Pendapatan</param>
        ''' <param name="Expense">Datagrid untuk menampilkan akun Expense / Pengeluaran</param>
        ''' <param name="AccountingBook">ComboBox yang berisi Buku Akuntansi</param>
        ''' <param name="Find">TextBox Pencarian</param>
        ''' <param name="ForceRefresh">True / False</param>
        ''' <remarks>ForceRefresh = True akan menampilkan semua data tanpa filter</remarks>
        Public Sub GETAccountList(ByVal Assets As dgn, ByVal Liability As dgn, ByVal Capital As dgn, ByVal Wage As dgn, ByVal Expense As dgn, ByVal AccountingBook As cbo, ByVal Find As txt, Optional ForceRefresh As Boolean = False)
            Dim _CBO_Index As Integer = -1
            'Isikan index combobox dengan data dari mainframe
            _CBO_Index = AccountingBook.SelectedValue

            'Tampilkan data awal / tanpa filter / ForceRefresh=True
            If (Find.Text = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_acgroup = 1 order by acc.acaccount_num", _CBO_Index)
                _DBR_MSSQL2008(1).DataGrid = Assets
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TAssets")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_acgroup = 2 order by acc.acaccount_num", _CBO_Index)
                _DBR_MSSQL2008(1).DataGrid = Liability
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TLiability")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_acgroup = 3 order by acc.acaccount_num", _CBO_Index)
                _DBR_MSSQL2008(1).DataGrid = Capital
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TCapital")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_acgroup = 4 order by acc.acaccount_num", _CBO_Index)
                _DBR_MSSQL2008(1).DataGrid = Wage
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TWage")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_acgroup = 5 order by acc.acaccount_num", _CBO_Index)
                _DBR_MSSQL2008(1).DataGrid = Expense
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TExpense")
            Else 'Tampilkan data berdasarkan filter
                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_name like '%{1}%' and acc.acaccount_acgroup = 1 order by acc.acaccount_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(1).DataGrid = Assets
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TAssets")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_name like '%{1}%' and acc.acaccount_acgroup = 2 order by acc.acaccount_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(1).DataGrid = Liability
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TLiability")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_name like '%{1}%' and acc.acaccount_acgroup = 3 order by acc.acaccount_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(1).DataGrid = Capital
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TCapital")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_name like '%{1}%' and acc.acaccount_acgroup = 4 order by acc.acaccount_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(1).DataGrid = Wage
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TWage")

                _DBR_MSSQL2008(1).Query = String.Format("select acc.acaccount_id,acc.acaccount_num,acc.acaccount_name, (case acc.acaccount_enable when 0 then 'No' when 1 then 'Yes' end) as [acaccount_enable] from dbo.[[ac]]account] acc where acc.acaccount_acbook = {0} and acc.acaccount_name like '%{1}%' and acc.acaccount_acgroup = 5 order by acc.acaccount_num", _CBO_Index, Find.SLFSQLText)
                _DBR_MSSQL2008(1).DataGrid = Expense
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TExpense")
            End If
        End Sub

        Public Function DELETEData(ByVal AccountID As Integer) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(0).Query = String.Format("delete from dbo.[[ac]]account] where acaccount_id = {0}", AccountID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(0).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try

            Return _Success
        End Function

    End Class

    Public Class AccountGroupEditor
#Region "Variables"
        Private _DBR_MSSQL2008(3) As Database.Engine.Display.Request
#End Region

        ''' <summary>
        ''' Prosedur untuk mengambil data plant
        ''' </summary>
        ''' <param name="cPlant">ComboBox Plant</param>
        ''' <remarks></remarks>
        Public Sub GETPlant(ByVal cPlant As cbo)
            _DBR_MSSQL2008(2).Query = "select p.plant_id, (p.plant_code + ' - ' + p.plant_name) as [plant_name] from dbo.[[mm]]plant] p"
            _DBR_MSSQL2008(2).Dropdown = cPlant
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(2), "TPlant")
            cPlant.DisplayMember = "plant_name"
            cPlant.ValueMember = "plant_id"
        End Sub

        ''' <summary>
        ''' Prosedur untuk mengambil data buku akuntansi dari database
        ''' </summary>
        ''' <param name="AccountingBook">ComboBox yang akan diisi</param>
        ''' <remarks></remarks>
        Public Sub GETAccountingBook(ByVal AccountingBook As cbo, ByVal cPlant As cbo)
            Dim _PlantID As Integer = -1
            If Not cPlant.Items.Count = 0 Then
                _PlantID = cPlant.SelectedValue
            End If

            _DBR_MSSQL2008(0).Query = String.Format("select ab.acbook_id, (ab.acbook_code + ' - ' + ab.acbook_bookname) as [acbook_bookname] from dbo.[[ac]]book] ab inner join dbo.[[mm]]plant] pl on ab.acbook_plant = pl.plant_id where ab.acbook_plant = {0}", _PlantID)
            _DBR_MSSQL2008(0).Dropdown = AccountingBook
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAccountingBook")
            AccountingBook.DisplayMember = "acbook_bookname"
            AccountingBook.ValueMember = "acbook_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountGroup"></param>
        ''' <remarks></remarks>
        Public Sub GETAccountGroup(ByVal AccountGroup As cbo)
            _DBR_MSSQL2008(0).Query = "select ag.acgroup_id, ag.acgroup_name + ' (' + ag.acgroup_inline + ')' as acgroup_name from dbo.[[ac]]group] ag"
            _DBR_MSSQL2008(0).Dropdown = AccountGroup
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAccountingBook")
            AccountGroup.DisplayMember = "acgroup_name"
            AccountGroup.ValueMember = "acgroup_id"
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETPlantID(ByVal AccountID As Integer) As Integer
            Dim _PlantID As Integer = -1
            _DBR_MSSQL2008(0).Query = String.Format("select ab.acbook_plant from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.acaccount_acbook = ab.acbook_id where ac.acaccount_id = {0}", AccountID)
            _PlantID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _PlantID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountBookID(ByVal AccountID As Integer) As Integer
            Dim _AccountBookID As Integer = -1
            _DBR_MSSQL2008(0).Query = String.Format("select ab.acbook_id from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.acaccount_acbook = ab.acbook_id where ac.acaccount_id = {0}", AccountID)
            _AccountBookID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _AccountBookID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountGroupID(ByVal AccountID As Integer) As Integer
            Dim _AccountGroupID As Integer = -1
            _DBR_MSSQL2008(0).Query = String.Format("select ac.acaccount_acgroup from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.acaccount_acbook = ab.acbook_id where ac.acaccount_id = {0}", AccountID)
            _AccountGroupID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _AccountGroupID
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountNumber(ByVal AccountID As Integer) As String
            Dim _AccountNumber As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select ac.acaccount_num from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.acaccount_acbook = ab.acbook_id where ac.acaccount_id = {0}", AccountID)
            _AccountNumber = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _AccountNumber
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="AccountID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GETAccountName(ByVal AccountID As Integer) As String
            Dim _AccountNumber As String = String.Empty
            _DBR_MSSQL2008(0).Query = String.Format("select ac.acaccount_name from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.acaccount_acbook = ab.acbook_id where ac.acaccount_id = {0}", AccountID)
            _AccountNumber = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _AccountNumber
        End Function

        Public Function GETEnableTransaction(ByVal AccountID As Integer) As Boolean
            Dim _EnableTransaction As Boolean = False
            _DBR_MSSQL2008(0).Query = String.Format("select ac.acaccount_enable from dbo.[[ac]]account] ac inner join dbo.[[ac]]book] ab on ac.acaccount_acbook = ab.acbook_id where ac.acaccount_id = {0}", AccountID)
            _EnableTransaction = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Return _EnableTransaction
        End Function

        Public Function IsDuplicate(ByVal AccountBookID As Integer, ByVal AccountGroupID As Integer, ByVal AccountNumber As String, Optional AccountID As Integer = -1) As Boolean
            Dim _IsDuplicate As Integer = 0
            If AccountID = -1 Then
                _DBR_MSSQL2008(0).Query = String.Format("select count(ac.acaccount_id) as [rows] from dbo.[[ac]]account] ac where ac.acaccount_acbook = {0} and ac.acaccount_num = '{1}'", AccountBookID, AccountNumber)
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select count(ac.acaccount_id) as [rows] from dbo.[[ac]]account] ac where ac.acaccount_acbook = {0} and ac.acaccount_num = '{1}' and ac.acaccount_id <> {2}", AccountBookID, AccountNumber, AccountID)
            End If
            _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            If _IsDuplicate > 0 Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function PUSHData(ByVal AccountBookID As Integer, ByVal AccountGroupID As Integer, ByVal AccountNumber As String, ByVal AccountName As String, ByVal AccountEnable As Boolean, Optional ByVal AccountID As Integer = -1) As Boolean
            Dim _Success As Boolean = False
            Try
                If AccountID = -1 Then
                    _DBR_MSSQL2008(0).Query = String.Format("insert into dbo.[[ac]]account](acaccount_acbook, acaccount_acgroup, acaccount_num, acaccount_name, acaccount_enable) values({0},{1},{2},'{3}','{4}')", AccountBookID, AccountGroupID, AccountNumber, AccountName, AccountEnable)
                Else
                    _DBR_MSSQL2008(0).Query = String.Format("update dbo.[[ac]]account] set acaccount_num = '{0}', acaccount_name = '{1}', acaccount_enable = '{2}' where acaccount_id = {3}", AccountNumber, AccountName, AccountEnable, AccountID)
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
