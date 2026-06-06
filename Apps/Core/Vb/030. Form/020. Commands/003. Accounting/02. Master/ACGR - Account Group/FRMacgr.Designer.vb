Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMacgr
        Inherits CMCv.FRMstandardFind

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle25 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle26 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle27 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle29 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle30 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle32 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle31 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle33 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle34 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle36 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle35 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle37 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle38 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle40 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle39 As DataGridViewCellStyle = New DataGridViewCellStyle()
            CboCompany = New CMCv.UI.Control.Cbo(components)
            Lbl3 = New CMCv.UI.Control.lbl(components)
            CboAccountingBook = New CMCv.UI.Control.Cbo(components)
            Lbl2 = New CMCv.UI.Control.lbl(components)
            TbctlAccountGroup = New CMCv.UI.Control.Tbx(components)
            tpAssets = New TabPage()
            DgnACGRAssets = New CMCv.UI.Control.dgn(components)
            account_id_assets = New DataGridViewTextBoxColumn()
            account_num_assets = New DataGridViewTextBoxColumn()
            account_name_assets = New DataGridViewTextBoxColumn()
            account_enable_assets = New DataGridViewTextBoxColumn()
            tpLiabilities = New TabPage()
            DgnACGRLiabities = New CMCv.UI.Control.dgn(components)
            account_id_liability = New DataGridViewTextBoxColumn()
            account_num_liabilities = New DataGridViewTextBoxColumn()
            account_name_liabilities = New DataGridViewTextBoxColumn()
            account_enable_liabilities = New DataGridViewTextBoxColumn()
            tpEquity = New TabPage()
            DgnACGREquity = New CMCv.UI.Control.dgn(components)
            account_id_equity = New DataGridViewTextBoxColumn()
            account_num_equity = New DataGridViewTextBoxColumn()
            account_name_equity = New DataGridViewTextBoxColumn()
            account_enable_equity = New DataGridViewTextBoxColumn()
            tpRevenue = New TabPage()
            DgnACGRRevenue = New CMCv.UI.Control.dgn(components)
            account_id_revenue = New DataGridViewTextBoxColumn()
            account_num_revenue = New DataGridViewTextBoxColumn()
            account_name_revenue = New DataGridViewTextBoxColumn()
            account_enable_revenue = New DataGridViewTextBoxColumn()
            tpExpense = New TabPage()
            DgnACGRExpense = New CMCv.UI.Control.dgn(components)
            account_id_expense = New DataGridViewTextBoxColumn()
            account_num_expense = New DataGridViewTextBoxColumn()
            account_name_expense = New DataGridViewTextBoxColumn()
            account_enable_expense = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            TbctlAccountGroup.SuspendLayout()
            tpAssets.SuspendLayout()
            CType(DgnACGRAssets, ComponentModel.ISupportInitialize).BeginInit()
            tpLiabilities.SuspendLayout()
            CType(DgnACGRLiabities, ComponentModel.ISupportInitialize).BeginInit()
            tpEquity.SuspendLayout()
            CType(DgnACGREquity, ComponentModel.ISupportInitialize).BeginInit()
            tpRevenue.SuspendLayout()
            CType(DgnACGRRevenue, ComponentModel.ISupportInitialize).BeginInit()
            tpExpense.SuspendLayout()
            CType(DgnACGRExpense, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlFind
            ' 
            PnlFind.Controls.Add(CboCompany)
            PnlFind.Controls.Add(Lbl3)
            PnlFind.Controls.Add(Lbl2)
            PnlFind.Controls.Add(CboAccountingBook)
            PnlFind.Controls.SetChildIndex(TxtFind, 0)
            PnlFind.Controls.SetChildIndex(CboAccountingBook, 0)
            PnlFind.Controls.SetChildIndex(LblFind, 0)
            PnlFind.Controls.SetChildIndex(Lbl2, 0)
            PnlFind.Controls.SetChildIndex(Lbl3, 0)
            PnlFind.Controls.SetChildIndex(BtnClear, 0)
            PnlFind.Controls.SetChildIndex(CboCompany, 0)
            ' 
            ' BtnClear
            ' 
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClear.FlatAppearance.BorderSize = 2
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            ' 
            ' TxtFind
            ' 
            TxtFind.Margin = New Padding(7, 5, 7, 5)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TbctlAccountGroup)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(TbctlAccountGroup, 0)
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.DropDownWidth = 350
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboCompany.FormattingEnabled = True
            CboCompany.IntegralHeight = False
            CboCompany.Location = New Point(789, 20)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(164, 40)
            CboCompany.TabIndex = 802
            ' 
            ' Lbl3
            ' 
            Lbl3.AutoSize = True
            Lbl3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl3.Location = New Point(650, 25)
            Lbl3.Margin = New Padding(6, 0, 6, 0)
            Lbl3.Name = "Lbl3"
            Lbl3.Size = New Size(116, 32)
            Lbl3.TabIndex = 9
            Lbl3.Text = "Company"
            Lbl3.XOCustomElipsis = False
            ' 
            ' CboAccountingBook
            ' 
            CboAccountingBook.DropDownStyle = ComboBoxStyle.DropDownList
            CboAccountingBook.FlatStyle = FlatStyle.Flat
            CboAccountingBook.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboAccountingBook.FormattingEnabled = True
            CboAccountingBook.Location = New Point(1050, 20)
            CboAccountingBook.Margin = New Padding(6, 5, 6, 5)
            CboAccountingBook.Name = "CboAccountingBook"
            CboAccountingBook.Size = New Size(385, 40)
            CboAccountingBook.TabIndex = 803
            ' 
            ' Lbl2
            ' 
            Lbl2.AutoSize = True
            Lbl2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl2.Location = New Point(966, 25)
            Lbl2.Margin = New Padding(6, 0, 6, 0)
            Lbl2.Name = "Lbl2"
            Lbl2.Size = New Size(68, 32)
            Lbl2.TabIndex = 7
            Lbl2.Text = "Book"
            Lbl2.XOCustomElipsis = False
            ' 
            ' TbctlAccountGroup
            ' 
            TbctlAccountGroup.Controls.Add(tpAssets)
            TbctlAccountGroup.Controls.Add(tpLiabilities)
            TbctlAccountGroup.Controls.Add(tpEquity)
            TbctlAccountGroup.Controls.Add(tpRevenue)
            TbctlAccountGroup.Controls.Add(tpExpense)
            TbctlAccountGroup.Dock = DockStyle.Fill
            TbctlAccountGroup.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlAccountGroup.Location = New Point(0, 88)
            TbctlAccountGroup.Margin = New Padding(6, 5, 6, 5)
            TbctlAccountGroup.Name = "TbctlAccountGroup"
            TbctlAccountGroup.SelectedIndex = 0
            TbctlAccountGroup.Size = New Size(1307, 864)
            TbctlAccountGroup.TabIndex = 0
            ' 
            ' tpAssets
            ' 
            tpAssets.AccessibleName = "tpAssets"
            tpAssets.Controls.Add(DgnACGRAssets)
            tpAssets.Location = New Point(4, 41)
            tpAssets.Margin = New Padding(6, 5, 6, 5)
            tpAssets.Name = "tpAssets"
            tpAssets.Padding = New Padding(6, 5, 6, 5)
            tpAssets.Size = New Size(1299, 819)
            tpAssets.TabIndex = 0
            tpAssets.Text = "ASSETS"
            tpAssets.UseVisualStyleBackColor = True
            ' 
            ' DgnACGRAssets
            ' 
            DgnACGRAssets.AllowUserToAddRows = False
            DgnACGRAssets.AllowUserToDeleteRows = False
            DataGridViewCellStyle21.BackColor = Color.FromArgb(CByte(237), CByte(228), CByte(136))
            DgnACGRAssets.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
            DgnACGRAssets.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnACGRAssets.BorderStyle = BorderStyle.None
            DgnACGRAssets.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnACGRAssets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle22.BackColor = Color.YellowGreen
            DataGridViewCellStyle22.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle22.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle22.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle22.SelectionForeColor = Color.Black
            DataGridViewCellStyle22.WrapMode = DataGridViewTriState.True
            DgnACGRAssets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
            DgnACGRAssets.ColumnHeadersHeight = 43
            DgnACGRAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnACGRAssets.Columns.AddRange(New DataGridViewColumn() {account_id_assets, account_num_assets, account_name_assets, account_enable_assets})
            DgnACGRAssets.Dock = DockStyle.Fill
            DgnACGRAssets.EnableHeadersVisualStyles = False
            DgnACGRAssets.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnACGRAssets.Location = New Point(6, 5)
            DgnACGRAssets.Margin = New Padding(6, 5, 6, 5)
            DgnACGRAssets.Name = "DgnACGRAssets"
            DgnACGRAssets.ReadOnly = True
            DgnACGRAssets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle24.BackColor = Color.YellowGreen
            DataGridViewCellStyle24.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle24.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle24.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle24.SelectionForeColor = Color.Black
            DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True
            DgnACGRAssets.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
            DgnACGRAssets.RowHeadersWidth = 62
            DgnACGRAssets.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnACGRAssets.Size = New Size(1287, 809)
            DgnACGRAssets.StandardTab = True
            DgnACGRAssets.TabIndex = 0
            DgnACGRAssets.XOIsGroupFirstRow = False
            DgnACGRAssets.XOIsShowRowNumber = True
            ' 
            ' account_id_assets
            ' 
            account_id_assets.DataPropertyName = "account_id"
            account_id_assets.HeaderText = "ID"
            account_id_assets.MinimumWidth = 8
            account_id_assets.Name = "account_id_assets"
            account_id_assets.ReadOnly = True
            account_id_assets.Visible = False
            account_id_assets.Width = 150
            ' 
            ' account_num_assets
            ' 
            account_num_assets.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_num_assets.DataPropertyName = "account_num"
            account_num_assets.HeaderText = "Number"
            account_num_assets.MinimumWidth = 8
            account_num_assets.Name = "account_num_assets"
            account_num_assets.ReadOnly = True
            account_num_assets.SortMode = DataGridViewColumnSortMode.Programmatic
            account_num_assets.Width = 105
            ' 
            ' account_name_assets
            ' 
            account_name_assets.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_name_assets.DataPropertyName = "account_name"
            account_name_assets.HeaderText = "Account Name"
            account_name_assets.MinimumWidth = 8
            account_name_assets.Name = "account_name_assets"
            account_name_assets.ReadOnly = True
            account_name_assets.SortMode = DataGridViewColumnSortMode.Programmatic
            account_name_assets.Width = 146
            ' 
            ' account_enable_assets
            ' 
            account_enable_assets.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            account_enable_assets.DataPropertyName = "account_enable"
            DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft
            account_enable_assets.DefaultCellStyle = DataGridViewCellStyle23
            account_enable_assets.HeaderText = "Enable"
            account_enable_assets.MinimumWidth = 8
            account_enable_assets.Name = "account_enable_assets"
            account_enable_assets.ReadOnly = True
            account_enable_assets.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' tpLiabilities
            ' 
            tpLiabilities.Controls.Add(DgnACGRLiabities)
            tpLiabilities.Location = New Point(4, 41)
            tpLiabilities.Margin = New Padding(6, 5, 6, 5)
            tpLiabilities.Name = "tpLiabilities"
            tpLiabilities.Padding = New Padding(6, 5, 6, 5)
            tpLiabilities.Size = New Size(1859, 1397)
            tpLiabilities.TabIndex = 1
            tpLiabilities.Text = "LIABILITIES"
            tpLiabilities.UseVisualStyleBackColor = True
            ' 
            ' DgnACGRLiabities
            ' 
            DgnACGRLiabities.AllowUserToAddRows = False
            DgnACGRLiabities.AllowUserToDeleteRows = False
            DataGridViewCellStyle25.BackColor = Color.FromArgb(CByte(192), CByte(254), CByte(173))
            DgnACGRLiabities.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
            DgnACGRLiabities.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnACGRLiabities.BorderStyle = BorderStyle.None
            DgnACGRLiabities.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnACGRLiabities.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle26.BackColor = Color.YellowGreen
            DataGridViewCellStyle26.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle26.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle26.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle26.SelectionForeColor = Color.Black
            DataGridViewCellStyle26.WrapMode = DataGridViewTriState.True
            DgnACGRLiabities.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
            DgnACGRLiabities.ColumnHeadersHeight = 43
            DgnACGRLiabities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnACGRLiabities.Columns.AddRange(New DataGridViewColumn() {account_id_liability, account_num_liabilities, account_name_liabilities, account_enable_liabilities})
            DgnACGRLiabities.Dock = DockStyle.Fill
            DgnACGRLiabities.EnableHeadersVisualStyles = False
            DgnACGRLiabities.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnACGRLiabities.Location = New Point(6, 5)
            DgnACGRLiabities.Margin = New Padding(6, 5, 6, 5)
            DgnACGRLiabities.Name = "DgnACGRLiabities"
            DgnACGRLiabities.ReadOnly = True
            DgnACGRLiabities.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle28.BackColor = Color.YellowGreen
            DataGridViewCellStyle28.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle28.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle28.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle28.SelectionForeColor = Color.Black
            DataGridViewCellStyle28.WrapMode = DataGridViewTriState.True
            DgnACGRLiabities.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
            DgnACGRLiabities.RowHeadersWidth = 62
            DgnACGRLiabities.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnACGRLiabities.Size = New Size(1847, 1387)
            DgnACGRLiabities.StandardTab = True
            DgnACGRLiabities.TabIndex = 0
            DgnACGRLiabities.XOIsGroupFirstRow = False
            DgnACGRLiabities.XOIsShowRowNumber = True
            ' 
            ' account_id_liability
            ' 
            account_id_liability.DataPropertyName = "account_id"
            account_id_liability.HeaderText = "ID"
            account_id_liability.MinimumWidth = 8
            account_id_liability.Name = "account_id_liability"
            account_id_liability.ReadOnly = True
            account_id_liability.SortMode = DataGridViewColumnSortMode.Programmatic
            account_id_liability.Visible = False
            account_id_liability.Width = 150
            ' 
            ' account_num_liabilities
            ' 
            account_num_liabilities.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_num_liabilities.DataPropertyName = "account_num"
            account_num_liabilities.HeaderText = "Number"
            account_num_liabilities.MinimumWidth = 8
            account_num_liabilities.Name = "account_num_liabilities"
            account_num_liabilities.ReadOnly = True
            account_num_liabilities.SortMode = DataGridViewColumnSortMode.Programmatic
            account_num_liabilities.Width = 105
            ' 
            ' account_name_liabilities
            ' 
            account_name_liabilities.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_name_liabilities.DataPropertyName = "account_name"
            account_name_liabilities.HeaderText = "Account Name"
            account_name_liabilities.MinimumWidth = 8
            account_name_liabilities.Name = "account_name_liabilities"
            account_name_liabilities.ReadOnly = True
            account_name_liabilities.SortMode = DataGridViewColumnSortMode.Programmatic
            account_name_liabilities.Width = 146
            ' 
            ' account_enable_liabilities
            ' 
            account_enable_liabilities.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            account_enable_liabilities.DataPropertyName = "account_enable"
            DataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft
            account_enable_liabilities.DefaultCellStyle = DataGridViewCellStyle27
            account_enable_liabilities.HeaderText = "Enable"
            account_enable_liabilities.MinimumWidth = 8
            account_enable_liabilities.Name = "account_enable_liabilities"
            account_enable_liabilities.ReadOnly = True
            account_enable_liabilities.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' tpEquity
            ' 
            tpEquity.Controls.Add(DgnACGREquity)
            tpEquity.Location = New Point(4, 41)
            tpEquity.Margin = New Padding(6, 5, 6, 5)
            tpEquity.Name = "tpEquity"
            tpEquity.Padding = New Padding(6, 5, 6, 5)
            tpEquity.Size = New Size(1859, 1397)
            tpEquity.TabIndex = 2
            tpEquity.Text = "EQUITY"
            tpEquity.UseVisualStyleBackColor = True
            ' 
            ' DgnACGREquity
            ' 
            DgnACGREquity.AllowUserToAddRows = False
            DgnACGREquity.AllowUserToDeleteRows = False
            DataGridViewCellStyle29.BackColor = Color.FromArgb(CByte(232), CByte(228), CByte(139))
            DgnACGREquity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
            DgnACGREquity.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnACGREquity.BorderStyle = BorderStyle.None
            DgnACGREquity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnACGREquity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle30.BackColor = Color.YellowGreen
            DataGridViewCellStyle30.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle30.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle30.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle30.SelectionForeColor = Color.Black
            DataGridViewCellStyle30.WrapMode = DataGridViewTriState.True
            DgnACGREquity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
            DgnACGREquity.ColumnHeadersHeight = 43
            DgnACGREquity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnACGREquity.Columns.AddRange(New DataGridViewColumn() {account_id_equity, account_num_equity, account_name_equity, account_enable_equity})
            DgnACGREquity.Dock = DockStyle.Fill
            DgnACGREquity.EnableHeadersVisualStyles = False
            DgnACGREquity.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnACGREquity.Location = New Point(6, 5)
            DgnACGREquity.Margin = New Padding(6, 5, 6, 5)
            DgnACGREquity.Name = "DgnACGREquity"
            DgnACGREquity.ReadOnly = True
            DgnACGREquity.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle32.BackColor = Color.YellowGreen
            DataGridViewCellStyle32.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle32.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle32.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle32.SelectionForeColor = Color.Black
            DataGridViewCellStyle32.WrapMode = DataGridViewTriState.True
            DgnACGREquity.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
            DgnACGREquity.RowHeadersWidth = 62
            DgnACGREquity.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnACGREquity.Size = New Size(1847, 1387)
            DgnACGREquity.StandardTab = True
            DgnACGREquity.TabIndex = 0
            DgnACGREquity.XOIsGroupFirstRow = False
            DgnACGREquity.XOIsShowRowNumber = True
            ' 
            ' account_id_equity
            ' 
            account_id_equity.DataPropertyName = "account_id"
            account_id_equity.HeaderText = "ID"
            account_id_equity.MinimumWidth = 8
            account_id_equity.Name = "account_id_equity"
            account_id_equity.ReadOnly = True
            account_id_equity.SortMode = DataGridViewColumnSortMode.Programmatic
            account_id_equity.Visible = False
            account_id_equity.Width = 150
            ' 
            ' account_num_equity
            ' 
            account_num_equity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_num_equity.DataPropertyName = "account_num"
            account_num_equity.HeaderText = "Number"
            account_num_equity.MinimumWidth = 8
            account_num_equity.Name = "account_num_equity"
            account_num_equity.ReadOnly = True
            account_num_equity.SortMode = DataGridViewColumnSortMode.Programmatic
            account_num_equity.Width = 105
            ' 
            ' account_name_equity
            ' 
            account_name_equity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_name_equity.DataPropertyName = "account_name"
            account_name_equity.HeaderText = "Account Name"
            account_name_equity.MinimumWidth = 8
            account_name_equity.Name = "account_name_equity"
            account_name_equity.ReadOnly = True
            account_name_equity.SortMode = DataGridViewColumnSortMode.Programmatic
            account_name_equity.Width = 146
            ' 
            ' account_enable_equity
            ' 
            account_enable_equity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            account_enable_equity.DataPropertyName = "account_enable"
            DataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleLeft
            account_enable_equity.DefaultCellStyle = DataGridViewCellStyle31
            account_enable_equity.HeaderText = "Enable"
            account_enable_equity.MinimumWidth = 8
            account_enable_equity.Name = "account_enable_equity"
            account_enable_equity.ReadOnly = True
            account_enable_equity.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' tpRevenue
            ' 
            tpRevenue.Controls.Add(DgnACGRRevenue)
            tpRevenue.Location = New Point(4, 41)
            tpRevenue.Margin = New Padding(6, 5, 6, 5)
            tpRevenue.Name = "tpRevenue"
            tpRevenue.Padding = New Padding(6, 5, 6, 5)
            tpRevenue.Size = New Size(1859, 1397)
            tpRevenue.TabIndex = 3
            tpRevenue.Text = "REVENUE"
            tpRevenue.UseVisualStyleBackColor = True
            ' 
            ' DgnACGRRevenue
            ' 
            DgnACGRRevenue.AllowUserToAddRows = False
            DgnACGRRevenue.AllowUserToDeleteRows = False
            DataGridViewCellStyle33.BackColor = Color.FromArgb(CByte(222), CByte(194), CByte(161))
            DgnACGRRevenue.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
            DgnACGRRevenue.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnACGRRevenue.BorderStyle = BorderStyle.None
            DgnACGRRevenue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnACGRRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle34.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle34.BackColor = Color.YellowGreen
            DataGridViewCellStyle34.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle34.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle34.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle34.SelectionForeColor = Color.Black
            DataGridViewCellStyle34.WrapMode = DataGridViewTriState.True
            DgnACGRRevenue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
            DgnACGRRevenue.ColumnHeadersHeight = 43
            DgnACGRRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnACGRRevenue.Columns.AddRange(New DataGridViewColumn() {account_id_revenue, account_num_revenue, account_name_revenue, account_enable_revenue})
            DgnACGRRevenue.Dock = DockStyle.Fill
            DgnACGRRevenue.EnableHeadersVisualStyles = False
            DgnACGRRevenue.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnACGRRevenue.Location = New Point(6, 5)
            DgnACGRRevenue.Margin = New Padding(6, 5, 6, 5)
            DgnACGRRevenue.Name = "DgnACGRRevenue"
            DgnACGRRevenue.ReadOnly = True
            DgnACGRRevenue.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle36.BackColor = Color.YellowGreen
            DataGridViewCellStyle36.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle36.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle36.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle36.SelectionForeColor = Color.Black
            DataGridViewCellStyle36.WrapMode = DataGridViewTriState.True
            DgnACGRRevenue.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
            DgnACGRRevenue.RowHeadersWidth = 62
            DgnACGRRevenue.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnACGRRevenue.Size = New Size(1847, 1387)
            DgnACGRRevenue.StandardTab = True
            DgnACGRRevenue.TabIndex = 0
            DgnACGRRevenue.XOIsGroupFirstRow = False
            DgnACGRRevenue.XOIsShowRowNumber = True
            ' 
            ' account_id_revenue
            ' 
            account_id_revenue.DataPropertyName = "account_id"
            account_id_revenue.HeaderText = "ID"
            account_id_revenue.MinimumWidth = 8
            account_id_revenue.Name = "account_id_revenue"
            account_id_revenue.ReadOnly = True
            account_id_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
            account_id_revenue.Visible = False
            account_id_revenue.Width = 150
            ' 
            ' account_num_revenue
            ' 
            account_num_revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_num_revenue.DataPropertyName = "account_num"
            account_num_revenue.HeaderText = "Number"
            account_num_revenue.MinimumWidth = 8
            account_num_revenue.Name = "account_num_revenue"
            account_num_revenue.ReadOnly = True
            account_num_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
            account_num_revenue.Width = 105
            ' 
            ' account_name_revenue
            ' 
            account_name_revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_name_revenue.DataPropertyName = "account_name"
            account_name_revenue.HeaderText = "Account Name"
            account_name_revenue.MinimumWidth = 8
            account_name_revenue.Name = "account_name_revenue"
            account_name_revenue.ReadOnly = True
            account_name_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
            account_name_revenue.Width = 146
            ' 
            ' account_enable_revenue
            ' 
            account_enable_revenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            account_enable_revenue.DataPropertyName = "account_enable"
            DataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft
            account_enable_revenue.DefaultCellStyle = DataGridViewCellStyle35
            account_enable_revenue.HeaderText = "Enable"
            account_enable_revenue.MinimumWidth = 8
            account_enable_revenue.Name = "account_enable_revenue"
            account_enable_revenue.ReadOnly = True
            account_enable_revenue.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' tpExpense
            ' 
            tpExpense.Controls.Add(DgnACGRExpense)
            tpExpense.Location = New Point(4, 41)
            tpExpense.Margin = New Padding(6, 5, 6, 5)
            tpExpense.Name = "tpExpense"
            tpExpense.Padding = New Padding(6, 5, 6, 5)
            tpExpense.Size = New Size(1859, 1397)
            tpExpense.TabIndex = 4
            tpExpense.Text = "EXPENSE"
            tpExpense.UseVisualStyleBackColor = True
            ' 
            ' DgnACGRExpense
            ' 
            DgnACGRExpense.AllowUserToAddRows = False
            DgnACGRExpense.AllowUserToDeleteRows = False
            DataGridViewCellStyle37.BackColor = Color.FromArgb(CByte(231), CByte(193), CByte(184))
            DgnACGRExpense.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
            DgnACGRExpense.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnACGRExpense.BorderStyle = BorderStyle.None
            DgnACGRExpense.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnACGRExpense.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle38.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle38.BackColor = Color.YellowGreen
            DataGridViewCellStyle38.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle38.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle38.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle38.SelectionForeColor = Color.Black
            DataGridViewCellStyle38.WrapMode = DataGridViewTriState.True
            DgnACGRExpense.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
            DgnACGRExpense.ColumnHeadersHeight = 43
            DgnACGRExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnACGRExpense.Columns.AddRange(New DataGridViewColumn() {account_id_expense, account_num_expense, account_name_expense, account_enable_expense})
            DgnACGRExpense.Dock = DockStyle.Fill
            DgnACGRExpense.EnableHeadersVisualStyles = False
            DgnACGRExpense.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnACGRExpense.Location = New Point(6, 5)
            DgnACGRExpense.Margin = New Padding(6, 5, 6, 5)
            DgnACGRExpense.Name = "DgnACGRExpense"
            DgnACGRExpense.ReadOnly = True
            DgnACGRExpense.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle40.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle40.BackColor = Color.YellowGreen
            DataGridViewCellStyle40.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle40.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle40.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle40.SelectionForeColor = Color.Black
            DataGridViewCellStyle40.WrapMode = DataGridViewTriState.True
            DgnACGRExpense.RowHeadersDefaultCellStyle = DataGridViewCellStyle40
            DgnACGRExpense.RowHeadersWidth = 62
            DgnACGRExpense.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnACGRExpense.Size = New Size(1847, 1387)
            DgnACGRExpense.StandardTab = True
            DgnACGRExpense.TabIndex = 0
            DgnACGRExpense.XOIsGroupFirstRow = False
            DgnACGRExpense.XOIsShowRowNumber = True
            ' 
            ' account_id_expense
            ' 
            account_id_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_id_expense.DataPropertyName = "account_id"
            account_id_expense.HeaderText = "ID"
            account_id_expense.MinimumWidth = 8
            account_id_expense.Name = "account_id_expense"
            account_id_expense.ReadOnly = True
            account_id_expense.SortMode = DataGridViewColumnSortMode.Programmatic
            account_id_expense.Visible = False
            account_id_expense.Width = 150
            ' 
            ' account_num_expense
            ' 
            account_num_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_num_expense.DataPropertyName = "account_num"
            account_num_expense.HeaderText = "Number"
            account_num_expense.MinimumWidth = 8
            account_num_expense.Name = "account_num_expense"
            account_num_expense.ReadOnly = True
            account_num_expense.SortMode = DataGridViewColumnSortMode.Programmatic
            account_num_expense.Width = 105
            ' 
            ' account_name_expense
            ' 
            account_name_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            account_name_expense.DataPropertyName = "account_name"
            account_name_expense.HeaderText = "Account Name"
            account_name_expense.MinimumWidth = 8
            account_name_expense.Name = "account_name_expense"
            account_name_expense.ReadOnly = True
            account_name_expense.SortMode = DataGridViewColumnSortMode.Programmatic
            account_name_expense.Width = 146
            ' 
            ' account_enable_expense
            ' 
            account_enable_expense.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            account_enable_expense.DataPropertyName = "account_enable"
            DataGridViewCellStyle39.Alignment = DataGridViewContentAlignment.MiddleLeft
            account_enable_expense.DefaultCellStyle = DataGridViewCellStyle39
            account_enable_expense.HeaderText = "Enable"
            account_enable_expense.MinimumWidth = 8
            account_enable_expense.Name = "account_enable_expense"
            account_enable_expense.ReadOnly = True
            account_enable_expense.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMacgr
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMacgr"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            TbctlAccountGroup.ResumeLayout(False)
            tpAssets.ResumeLayout(False)
            CType(DgnACGRAssets, ComponentModel.ISupportInitialize).EndInit()
            tpLiabilities.ResumeLayout(False)
            CType(DgnACGRLiabities, ComponentModel.ISupportInitialize).EndInit()
            tpEquity.ResumeLayout(False)
            CType(DgnACGREquity, ComponentModel.ISupportInitialize).EndInit()
            tpRevenue.ResumeLayout(False)
            CType(DgnACGRRevenue, ComponentModel.ISupportInitialize).EndInit()
            tpExpense.ResumeLayout(False)
            CType(DgnACGRExpense, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents TbctlAccountGroup As CMCv.UI.Control.Tbx
        Friend WithEvents tpAssets As TabPage
        Friend WithEvents DgnACGRAssets As CMCv.UI.Control.dgn
        Friend WithEvents tpLiabilities As TabPage
        Friend WithEvents DgnACGRLiabities As CMCv.UI.Control.dgn
        Friend WithEvents tpEquity As TabPage
        Friend WithEvents tpRevenue As TabPage
        Friend WithEvents DgnACGRRevenue As CMCv.UI.Control.dgn
        Friend WithEvents tpExpense As TabPage
        Friend WithEvents DgnACGRExpense As CMCv.UI.Control.dgn
        Friend WithEvents CboAccountingBook As CMCv.UI.Control.Cbo
        Friend WithEvents Lbl2 As CMCv.UI.Control.lbl
        Friend WithEvents DgnACGREquity As CMCv.UI.Control.dgn
        Friend WithEvents CboCompany As CMCv.UI.Control.Cbo
        Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
        Friend WithEvents account_id_assets As DataGridViewTextBoxColumn
        Friend WithEvents account_num_assets As DataGridViewTextBoxColumn
        Friend WithEvents account_name_assets As DataGridViewTextBoxColumn
        Friend WithEvents account_enable_assets As DataGridViewTextBoxColumn
        Friend WithEvents account_id_liability As DataGridViewTextBoxColumn
        Friend WithEvents account_num_liabilities As DataGridViewTextBoxColumn
        Friend WithEvents account_name_liabilities As DataGridViewTextBoxColumn
        Friend WithEvents account_enable_liabilities As DataGridViewTextBoxColumn
        Friend WithEvents account_id_equity As DataGridViewTextBoxColumn
        Friend WithEvents account_num_equity As DataGridViewTextBoxColumn
        Friend WithEvents account_name_equity As DataGridViewTextBoxColumn
        Friend WithEvents account_enable_equity As DataGridViewTextBoxColumn
        Friend WithEvents account_id_revenue As DataGridViewTextBoxColumn
        Friend WithEvents account_num_revenue As DataGridViewTextBoxColumn
        Friend WithEvents account_name_revenue As DataGridViewTextBoxColumn
        Friend WithEvents account_enable_revenue As DataGridViewTextBoxColumn
        Friend WithEvents account_id_expense As DataGridViewTextBoxColumn
        Friend WithEvents account_num_expense As DataGridViewTextBoxColumn
        Friend WithEvents account_name_expense As DataGridViewTextBoxColumn
        Friend WithEvents account_enable_expense As DataGridViewTextBoxColumn
    End Class
End Namespace