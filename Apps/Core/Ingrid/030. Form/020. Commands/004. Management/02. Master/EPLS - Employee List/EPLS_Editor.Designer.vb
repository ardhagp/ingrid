<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EPLS_Editor
    Inherits CMCv.Std_Fo

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EPLS_Editor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.pctbxPhoto = New CMCv.pctbx(Me.components)
        Me.BtnBrowsePhoto = New CMCv.btn(Me.components)
        Me.OfdPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.pcbxFrame = New CMCv.pctbx(Me.components)
        Me.tpPermissions = New System.Windows.Forms.TabPage()
        Me.GbxModulesRoles = New CMCv.gbx(Me.components)
        Me.DgnModulesRoles = New CMCv.dgn(Me.components)
        Me.modulegroup_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useraccess_view = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_add = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_edit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_reports = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbxCredetials = New CMCv.gbx(Me.components)
        Me.ULbl7 = New CMCv.ULbl()
        Me.TxtLogin = New CMCv.txt(Me.components)
        Me.tpWorkIn = New System.Windows.Forms.TabPage()
        Me.ULbl14 = New CMCv.ULbl()
        Me.ULbl13 = New CMCv.ULbl()
        Me.ULbl12 = New CMCv.ULbl()
        Me.ULbl11 = New CMCv.ULbl()
        Me.ULbl10 = New CMCv.ULbl()
        Me.ULbl9 = New CMCv.ULbl()
        Me.ULbl6 = New CMCv.ULbl()
        Me.ChkActiveEmployee = New CMCv.chk(Me.components)
        Me.TxtEmployeeNickname = New CMCv.txt(Me.components)
        Me.TxtContractType = New CMCv.txt(Me.components)
        Me.TxtContractTypeID = New CMCv.txt(Me.components)
        Me.TxtEmployeeNumber = New CMCv.txt(Me.components)
        Me.TxtGrade = New CMCv.txt(Me.components)
        Me.TxtPositionID = New CMCv.txt(Me.components)
        Me.TxtPosition = New CMCv.txt(Me.components)
        Me.TxtGradeID = New CMCv.txt(Me.components)
        Me.BtnBrowsePosition = New CMCv.btn(Me.components)
        Me.TxtDepartement = New CMCv.txt(Me.components)
        Me.TxtCompany = New CMCv.txt(Me.components)
        Me.tpGeneral = New System.Windows.Forms.TabPage()
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl5 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl16 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.TxtAddress = New CMCv.txt(Me.components)
        Me.TxtBirthPlace = New CMCv.txt(Me.components)
        Me.DtpBirthDate = New CMCv.dtp(Me.components)
        Me.TxtPersonalID = New CMCv.txt(Me.components)
        Me.CboGender = New CMCv.cbo(Me.components)
        Me.TxtFullName = New CMCv.txt(Me.components)
        Me.TbctlEmployee = New CMCv.tbctl(Me.components)
        Me.ULbl8 = New CMCv.ULbl()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.pctbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbxFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPermissions.SuspendLayout()
        Me.GbxModulesRoles.SuspendLayout()
        CType(Me.DgnModulesRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxCredetials.SuspendLayout()
        Me.tpWorkIn.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.TbctlEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 376)
        Me.PnlBottomButton.Size = New System.Drawing.Size(709, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(709, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ULbl8)
        Me.SLFPanel.Controls.Add(Me.TbctlEmployee)
        Me.SLFPanel.Controls.Add(Me.BtnBrowsePhoto)
        Me.SLFPanel.Controls.Add(Me.pctbxPhoto)
        Me.SLFPanel.Controls.Add(Me.pcbxFrame)
        Me.SLFPanel.Size = New System.Drawing.Size(709, 426)
        Me.SLFPanel.Controls.SetChildIndex(Me.pcbxFrame, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.pctbxPhoto, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.BtnBrowsePhoto, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TbctlEmployee, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl8, 0)
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(339, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 803
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(491, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 801
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(597, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 802
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'pctbxPhoto
        '
        Me.pctbxPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctbxPhoto.BackColor = System.Drawing.Color.White
        Me.pctbxPhoto.ErrorImage = CType(resources.GetObject("pctbxPhoto.ErrorImage"), System.Drawing.Image)
        Me.pctbxPhoto.Image = Global.ingrid.My.Resources.Resources.PCTPRV_001_512_icon
        Me.pctbxPhoto.InitialImage = CType(resources.GetObject("pctbxPhoto.InitialImage"), System.Drawing.Image)
        Me.pctbxPhoto.Location = New System.Drawing.Point(560, 86)
        Me.pctbxPhoto.Name = "pctbxPhoto"
        Me.pctbxPhoto.Padding = New System.Windows.Forms.Padding(15)
        Me.pctbxPhoto.Size = New System.Drawing.Size(107, 126)
        Me.pctbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctbxPhoto.SLFTampilkanBorder = False
        Me.pctbxPhoto.SLFWarnaBorder = System.Drawing.Color.Transparent
        Me.pctbxPhoto.TabIndex = 1038
        Me.pctbxPhoto.TabStop = False
        '
        'BtnBrowsePhoto
        '
        Me.BtnBrowsePhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrowsePhoto.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnBrowsePhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowsePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnBrowsePhoto.FlatAppearance.BorderSize = 2
        Me.BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnBrowsePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowsePhoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowsePhoto.ForeColor = System.Drawing.Color.White
        Me.BtnBrowsePhoto.Location = New System.Drawing.Point(560, 223)
        Me.BtnBrowsePhoto.Name = "BtnBrowsePhoto"
        Me.BtnBrowsePhoto.Size = New System.Drawing.Size(107, 42)
        Me.BtnBrowsePhoto.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnBrowsePhoto.SLFTampilkanFocusBorder = False
        Me.BtnBrowsePhoto.SLFValidasiSemuaInput = False
        Me.BtnBrowsePhoto.SLFValidasiSemuaInputTag = Nothing
        Me.BtnBrowsePhoto.TabIndex = 800
        Me.BtnBrowsePhoto.Text = "Browse"
        Me.BtnBrowsePhoto.UseVisualStyleBackColor = False
        '
        'OfdPhoto
        '
        Me.OfdPhoto.FileName = "OpenFileDialog1"
        '
        'pcbxFrame
        '
        Me.pcbxFrame.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbxFrame.BackColor = System.Drawing.Color.White
        Me.pcbxFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbxFrame.ErrorImage = CType(resources.GetObject("pcbxFrame.ErrorImage"), System.Drawing.Image)
        Me.pcbxFrame.InitialImage = CType(resources.GetObject("pcbxFrame.InitialImage"), System.Drawing.Image)
        Me.pcbxFrame.Location = New System.Drawing.Point(555, 81)
        Me.pcbxFrame.Name = "pcbxFrame"
        Me.pcbxFrame.Size = New System.Drawing.Size(117, 136)
        Me.pcbxFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbxFrame.SLFTampilkanBorder = False
        Me.pcbxFrame.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.pcbxFrame.TabIndex = 1040
        Me.pcbxFrame.TabStop = False
        '
        'tpPermissions
        '
        Me.tpPermissions.Controls.Add(Me.GbxModulesRoles)
        Me.tpPermissions.Controls.Add(Me.GbxCredetials)
        Me.tpPermissions.Location = New System.Drawing.Point(4, 30)
        Me.tpPermissions.Name = "tpPermissions"
        Me.tpPermissions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPermissions.Size = New System.Drawing.Size(566, 382)
        Me.tpPermissions.TabIndex = 1
        Me.tpPermissions.Text = "PERMISSIONS"
        Me.tpPermissions.UseVisualStyleBackColor = True
        '
        'GbxModulesRoles
        '
        Me.GbxModulesRoles.AutoSize = True
        Me.GbxModulesRoles.Controls.Add(Me.DgnModulesRoles)
        Me.GbxModulesRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbxModulesRoles.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GbxModulesRoles.Location = New System.Drawing.Point(3, 97)
        Me.GbxModulesRoles.Name = "GbxModulesRoles"
        Me.GbxModulesRoles.Size = New System.Drawing.Size(560, 282)
        Me.GbxModulesRoles.TabIndex = 0
        Me.GbxModulesRoles.TabStop = False
        Me.GbxModulesRoles.Text = "Modules or roles"
        '
        'DgnModulesRoles
        '
        Me.DgnModulesRoles.AllowUserToAddRows = False
        Me.DgnModulesRoles.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.DgnModulesRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnModulesRoles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnModulesRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnModulesRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnModulesRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnModulesRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnModulesRoles.ColumnHeadersHeight = 43
        Me.DgnModulesRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnModulesRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modulegroup_name, Me.module_code, Me.useraccess_view, Me.useraccess_add, Me.useraccess_edit, Me.useraccess_delete, Me.useraccess_reports, Me.useraccess_id, Me.module_id})
        Me.DgnModulesRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnModulesRoles.EnableHeadersVisualStyles = False
        Me.DgnModulesRoles.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnModulesRoles.Location = New System.Drawing.Point(3, 25)
        Me.DgnModulesRoles.Name = "DgnModulesRoles"
        Me.DgnModulesRoles.ReadOnly = True
        Me.DgnModulesRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnModulesRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnModulesRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnModulesRoles.Size = New System.Drawing.Size(554, 254)
        Me.DgnModulesRoles.SLFGroupFirstRows = True
        Me.DgnModulesRoles.SLFGunakanNomorBaris = True
        Me.DgnModulesRoles.StandardTab = True
        Me.DgnModulesRoles.TabIndex = 0
        '
        'modulegroup_name
        '
        Me.modulegroup_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.modulegroup_name.DataPropertyName = "modulegroup_name"
        Me.modulegroup_name.HeaderText = "Module Group"
        Me.modulegroup_name.Name = "modulegroup_name"
        Me.modulegroup_name.ReadOnly = True
        '
        'module_code
        '
        Me.module_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.module_code.DataPropertyName = "module_code"
        Me.module_code.HeaderText = "Module Code"
        Me.module_code.Name = "module_code"
        Me.module_code.ReadOnly = True
        Me.module_code.Width = 95
        '
        'useraccess_view
        '
        Me.useraccess_view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_view.DataPropertyName = "useraccess_view"
        Me.useraccess_view.HeaderText = "View"
        Me.useraccess_view.Name = "useraccess_view"
        Me.useraccess_view.ReadOnly = True
        Me.useraccess_view.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.useraccess_view.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.useraccess_view.Width = 40
        '
        'useraccess_add
        '
        Me.useraccess_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_add.DataPropertyName = "useraccess_add"
        Me.useraccess_add.HeaderText = "Add"
        Me.useraccess_add.Name = "useraccess_add"
        Me.useraccess_add.ReadOnly = True
        Me.useraccess_add.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.useraccess_add.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.useraccess_add.Width = 40
        '
        'useraccess_edit
        '
        Me.useraccess_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_edit.DataPropertyName = "useraccess_edit"
        Me.useraccess_edit.HeaderText = "Edit"
        Me.useraccess_edit.Name = "useraccess_edit"
        Me.useraccess_edit.ReadOnly = True
        Me.useraccess_edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.useraccess_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.useraccess_edit.Width = 40
        '
        'useraccess_delete
        '
        Me.useraccess_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_delete.DataPropertyName = "useraccess_delete"
        Me.useraccess_delete.HeaderText = "Del"
        Me.useraccess_delete.Name = "useraccess_delete"
        Me.useraccess_delete.ReadOnly = True
        Me.useraccess_delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.useraccess_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.useraccess_delete.Width = 40
        '
        'useraccess_reports
        '
        Me.useraccess_reports.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_reports.DataPropertyName = "useraccess_reports"
        Me.useraccess_reports.HeaderText = "Rpt"
        Me.useraccess_reports.Name = "useraccess_reports"
        Me.useraccess_reports.ReadOnly = True
        Me.useraccess_reports.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.useraccess_reports.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.useraccess_reports.Width = 40
        '
        'useraccess_id
        '
        Me.useraccess_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.useraccess_id.DataPropertyName = "useraccess_id"
        Me.useraccess_id.HeaderText = "UID"
        Me.useraccess_id.Name = "useraccess_id"
        Me.useraccess_id.ReadOnly = True
        Me.useraccess_id.Visible = False
        Me.useraccess_id.Width = 52
        '
        'module_id
        '
        Me.module_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.module_id.DataPropertyName = "module_id"
        Me.module_id.HeaderText = "Module ID"
        Me.module_id.Name = "module_id"
        Me.module_id.ReadOnly = True
        Me.module_id.Visible = False
        Me.module_id.Width = 81
        '
        'GbxCredetials
        '
        Me.GbxCredetials.Controls.Add(Me.ULbl7)
        Me.GbxCredetials.Controls.Add(Me.TxtLogin)
        Me.GbxCredetials.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbxCredetials.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GbxCredetials.Location = New System.Drawing.Point(3, 3)
        Me.GbxCredetials.Name = "GbxCredetials"
        Me.GbxCredetials.Size = New System.Drawing.Size(560, 94)
        Me.GbxCredetials.TabIndex = 3
        Me.GbxCredetials.TabStop = False
        Me.GbxCredetials.Text = "Credentials"
        '
        'ULbl7
        '
        Me.ULbl7.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl7.Location = New System.Drawing.Point(7, 40)
        Me.ULbl7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl7.Name = "ULbl7"
        Me.ULbl7.Size = New System.Drawing.Size(150, 29)
        Me.ULbl7.SLFText = "Login"
        Me.ULbl7.SLFTextAdjuster = True
        Me.ULbl7.SLFTextBorder = False
        Me.ULbl7.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl7.TabIndex = 301
        '
        'TxtLogin
        '
        Me.TxtLogin.BackColor = System.Drawing.Color.White
        Me.TxtLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtLogin.Location = New System.Drawing.Point(164, 40)
        Me.TxtLogin.MaxLength = 255
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.ReadOnly = True
        Me.TxtLogin.Size = New System.Drawing.Size(206, 29)
        Me.TxtLogin.SLFAutoTrim = False
        Me.TxtLogin.SLFHarusDiisi = False
        Me.TxtLogin.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtLogin.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtLogin.SLFHightlightSaatFokus = False
        Me.TxtLogin.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtLogin.SLFIsBlank = False
        Me.TxtLogin.SLFIsSearchBox = False
        Me.TxtLogin.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtLogin.SLFPilihSemuaSaatFokus = False
        Me.TxtLogin.SLFPwdLengthMin = 8
        Me.TxtLogin.SLFPwdStrengthCalculate = False
        Me.TxtLogin.SLFPwdStrengthScore = 0
        Me.TxtLogin.SLFPwdStrengthText = Nothing
        Me.TxtLogin.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtLogin.SLFSearchBoxText = "Type then press Enter"
        Me.TxtLogin.SLFSQLText = ""
        Me.TxtLogin.SLFTanpaSpasi = False
        Me.TxtLogin.SLFValidasiField = Nothing
        Me.TxtLogin.TabIndex = 300
        Me.TxtLogin.Tag = "txt"
        Me.TxtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tpWorkIn
        '
        Me.tpWorkIn.Controls.Add(Me.ULbl14)
        Me.tpWorkIn.Controls.Add(Me.ULbl13)
        Me.tpWorkIn.Controls.Add(Me.ULbl12)
        Me.tpWorkIn.Controls.Add(Me.ULbl11)
        Me.tpWorkIn.Controls.Add(Me.ULbl10)
        Me.tpWorkIn.Controls.Add(Me.ULbl9)
        Me.tpWorkIn.Controls.Add(Me.ULbl6)
        Me.tpWorkIn.Controls.Add(Me.ChkActiveEmployee)
        Me.tpWorkIn.Controls.Add(Me.TxtEmployeeNickname)
        Me.tpWorkIn.Controls.Add(Me.TxtContractType)
        Me.tpWorkIn.Controls.Add(Me.TxtContractTypeID)
        Me.tpWorkIn.Controls.Add(Me.TxtEmployeeNumber)
        Me.tpWorkIn.Controls.Add(Me.TxtGrade)
        Me.tpWorkIn.Controls.Add(Me.TxtPositionID)
        Me.tpWorkIn.Controls.Add(Me.TxtPosition)
        Me.tpWorkIn.Controls.Add(Me.TxtGradeID)
        Me.tpWorkIn.Controls.Add(Me.BtnBrowsePosition)
        Me.tpWorkIn.Controls.Add(Me.TxtDepartement)
        Me.tpWorkIn.Controls.Add(Me.TxtCompany)
        Me.tpWorkIn.Location = New System.Drawing.Point(4, 30)
        Me.tpWorkIn.Name = "tpWorkIn"
        Me.tpWorkIn.Size = New System.Drawing.Size(566, 382)
        Me.tpWorkIn.TabIndex = 2
        Me.tpWorkIn.Text = "WORK IN"
        Me.tpWorkIn.UseVisualStyleBackColor = True
        '
        'ULbl14
        '
        Me.ULbl14.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl14.Location = New System.Drawing.Point(7, 218)
        Me.ULbl14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl14.Name = "ULbl14"
        Me.ULbl14.Size = New System.Drawing.Size(150, 29)
        Me.ULbl14.SLFText = "Initial"
        Me.ULbl14.SLFTextAdjuster = True
        Me.ULbl14.SLFTextBorder = False
        Me.ULbl14.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl14.TabIndex = 1061
        '
        'ULbl13
        '
        Me.ULbl13.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl13.Location = New System.Drawing.Point(7, 183)
        Me.ULbl13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl13.Name = "ULbl13"
        Me.ULbl13.Size = New System.Drawing.Size(150, 29)
        Me.ULbl13.SLFText = "Contract Type"
        Me.ULbl13.SLFTextAdjuster = True
        Me.ULbl13.SLFTextBorder = False
        Me.ULbl13.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl13.TabIndex = 1060
        '
        'ULbl12
        '
        Me.ULbl12.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl12.Location = New System.Drawing.Point(7, 148)
        Me.ULbl12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl12.Name = "ULbl12"
        Me.ULbl12.Size = New System.Drawing.Size(150, 29)
        Me.ULbl12.SLFText = "Emp. Number"
        Me.ULbl12.SLFTextAdjuster = True
        Me.ULbl12.SLFTextBorder = False
        Me.ULbl12.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl12.TabIndex = 1059
        '
        'ULbl11
        '
        Me.ULbl11.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl11.Location = New System.Drawing.Point(7, 113)
        Me.ULbl11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl11.Name = "ULbl11"
        Me.ULbl11.Size = New System.Drawing.Size(150, 29)
        Me.ULbl11.SLFText = "Grade"
        Me.ULbl11.SLFTextAdjuster = True
        Me.ULbl11.SLFTextBorder = False
        Me.ULbl11.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl11.TabIndex = 1058
        '
        'ULbl10
        '
        Me.ULbl10.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl10.Location = New System.Drawing.Point(7, 78)
        Me.ULbl10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl10.Name = "ULbl10"
        Me.ULbl10.Size = New System.Drawing.Size(150, 29)
        Me.ULbl10.SLFText = "Position"
        Me.ULbl10.SLFTextAdjuster = True
        Me.ULbl10.SLFTextBorder = False
        Me.ULbl10.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl10.TabIndex = 1057
        '
        'ULbl9
        '
        Me.ULbl9.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl9.Location = New System.Drawing.Point(7, 43)
        Me.ULbl9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl9.Name = "ULbl9"
        Me.ULbl9.Size = New System.Drawing.Size(150, 29)
        Me.ULbl9.SLFText = "Department"
        Me.ULbl9.SLFTextAdjuster = True
        Me.ULbl9.SLFTextBorder = False
        Me.ULbl9.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl9.TabIndex = 1056
        '
        'ULbl6
        '
        Me.ULbl6.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl6.Location = New System.Drawing.Point(7, 8)
        Me.ULbl6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl6.Name = "ULbl6"
        Me.ULbl6.Size = New System.Drawing.Size(150, 29)
        Me.ULbl6.SLFText = "Company"
        Me.ULbl6.SLFTextAdjuster = True
        Me.ULbl6.SLFTextBorder = False
        Me.ULbl6.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl6.TabIndex = 1055
        '
        'ChkActiveEmployee
        '
        Me.ChkActiveEmployee.AutoSize = True
        Me.ChkActiveEmployee.BackColor = System.Drawing.Color.Transparent
        Me.ChkActiveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkActiveEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkActiveEmployee.Location = New System.Drawing.Point(164, 253)
        Me.ChkActiveEmployee.Name = "ChkActiveEmployee"
        Me.ChkActiveEmployee.Size = New System.Drawing.Size(140, 25)
        Me.ChkActiveEmployee.TabIndex = 211
        Me.ChkActiveEmployee.Text = "Active employee"
        Me.ChkActiveEmployee.UseVisualStyleBackColor = False
        '
        'TxtEmployeeNickname
        '
        Me.TxtEmployeeNickname.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtEmployeeNickname.Location = New System.Drawing.Point(164, 218)
        Me.TxtEmployeeNickname.MaxLength = 255
        Me.TxtEmployeeNickname.Name = "TxtEmployeeNickname"
        Me.TxtEmployeeNickname.Size = New System.Drawing.Size(62, 29)
        Me.TxtEmployeeNickname.SLFAutoTrim = True
        Me.TxtEmployeeNickname.SLFHarusDiisi = False
        Me.TxtEmployeeNickname.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtEmployeeNickname.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtEmployeeNickname.SLFHightlightSaatFokus = False
        Me.TxtEmployeeNickname.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtEmployeeNickname.SLFIsBlank = True
        Me.TxtEmployeeNickname.SLFIsSearchBox = False
        Me.TxtEmployeeNickname.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtEmployeeNickname.SLFPilihSemuaSaatFokus = False
        Me.TxtEmployeeNickname.SLFPwdLengthMin = 8
        Me.TxtEmployeeNickname.SLFPwdStrengthCalculate = False
        Me.TxtEmployeeNickname.SLFPwdStrengthScore = 0
        Me.TxtEmployeeNickname.SLFPwdStrengthText = Nothing
        Me.TxtEmployeeNickname.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtEmployeeNickname.SLFSearchBoxText = "Type then press Enter"
        Me.TxtEmployeeNickname.SLFSQLText = ""
        Me.TxtEmployeeNickname.SLFTanpaSpasi = False
        Me.TxtEmployeeNickname.SLFValidasiField = Nothing
        Me.TxtEmployeeNickname.TabIndex = 210
        Me.TxtEmployeeNickname.Tag = "txt"
        Me.TxtEmployeeNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtContractType
        '
        Me.TxtContractType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtContractType.Location = New System.Drawing.Point(232, 183)
        Me.TxtContractType.MaxLength = 255
        Me.TxtContractType.Name = "TxtContractType"
        Me.TxtContractType.ReadOnly = True
        Me.TxtContractType.Size = New System.Drawing.Size(206, 29)
        Me.TxtContractType.SLFAutoTrim = False
        Me.TxtContractType.SLFHarusDiisi = False
        Me.TxtContractType.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtContractType.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtContractType.SLFHightlightSaatFokus = False
        Me.TxtContractType.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtContractType.SLFIsBlank = True
        Me.TxtContractType.SLFIsSearchBox = False
        Me.TxtContractType.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtContractType.SLFPilihSemuaSaatFokus = False
        Me.TxtContractType.SLFPwdLengthMin = 8
        Me.TxtContractType.SLFPwdStrengthCalculate = False
        Me.TxtContractType.SLFPwdStrengthScore = 0
        Me.TxtContractType.SLFPwdStrengthText = Nothing
        Me.TxtContractType.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtContractType.SLFSearchBoxText = "Type then press Enter"
        Me.TxtContractType.SLFSQLText = ""
        Me.TxtContractType.SLFTanpaSpasi = False
        Me.TxtContractType.SLFValidasiField = Nothing
        Me.TxtContractType.TabIndex = 209
        Me.TxtContractType.TabStop = False
        Me.TxtContractType.Tag = "txt"
        '
        'TxtContractTypeID
        '
        Me.TxtContractTypeID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtContractTypeID.Location = New System.Drawing.Point(164, 183)
        Me.TxtContractTypeID.MaxLength = 255
        Me.TxtContractTypeID.Name = "TxtContractTypeID"
        Me.TxtContractTypeID.ReadOnly = True
        Me.TxtContractTypeID.Size = New System.Drawing.Size(62, 29)
        Me.TxtContractTypeID.SLFAutoTrim = False
        Me.TxtContractTypeID.SLFHarusDiisi = False
        Me.TxtContractTypeID.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtContractTypeID.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtContractTypeID.SLFHightlightSaatFokus = False
        Me.TxtContractTypeID.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtContractTypeID.SLFIsBlank = True
        Me.TxtContractTypeID.SLFIsSearchBox = False
        Me.TxtContractTypeID.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtContractTypeID.SLFPilihSemuaSaatFokus = False
        Me.TxtContractTypeID.SLFPwdLengthMin = 8
        Me.TxtContractTypeID.SLFPwdStrengthCalculate = False
        Me.TxtContractTypeID.SLFPwdStrengthScore = 0
        Me.TxtContractTypeID.SLFPwdStrengthText = Nothing
        Me.TxtContractTypeID.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtContractTypeID.SLFSearchBoxText = "Type then press Enter"
        Me.TxtContractTypeID.SLFSQLText = ""
        Me.TxtContractTypeID.SLFTanpaSpasi = False
        Me.TxtContractTypeID.SLFValidasiField = Nothing
        Me.TxtContractTypeID.TabIndex = 208
        Me.TxtContractTypeID.TabStop = False
        Me.TxtContractTypeID.Tag = "txt"
        Me.TxtContractTypeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmployeeNumber
        '
        Me.TxtEmployeeNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtEmployeeNumber.Location = New System.Drawing.Point(164, 148)
        Me.TxtEmployeeNumber.MaxLength = 255
        Me.TxtEmployeeNumber.Name = "TxtEmployeeNumber"
        Me.TxtEmployeeNumber.Size = New System.Drawing.Size(170, 29)
        Me.TxtEmployeeNumber.SLFAutoTrim = True
        Me.TxtEmployeeNumber.SLFHarusDiisi = True
        Me.TxtEmployeeNumber.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtEmployeeNumber.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtEmployeeNumber.SLFHightlightSaatFokus = True
        Me.TxtEmployeeNumber.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtEmployeeNumber.SLFIsBlank = True
        Me.TxtEmployeeNumber.SLFIsSearchBox = False
        Me.TxtEmployeeNumber.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtEmployeeNumber.SLFPilihSemuaSaatFokus = False
        Me.TxtEmployeeNumber.SLFPwdLengthMin = 8
        Me.TxtEmployeeNumber.SLFPwdStrengthCalculate = False
        Me.TxtEmployeeNumber.SLFPwdStrengthScore = 0
        Me.TxtEmployeeNumber.SLFPwdStrengthText = Nothing
        Me.TxtEmployeeNumber.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtEmployeeNumber.SLFSearchBoxText = "Type then press Enter"
        Me.TxtEmployeeNumber.SLFSQLText = ""
        Me.TxtEmployeeNumber.SLFTanpaSpasi = False
        Me.TxtEmployeeNumber.SLFValidasiField = Nothing
        Me.TxtEmployeeNumber.TabIndex = 207
        Me.TxtEmployeeNumber.Tag = "txt"
        Me.TxtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGrade
        '
        Me.TxtGrade.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtGrade.Location = New System.Drawing.Point(232, 113)
        Me.TxtGrade.MaxLength = 255
        Me.TxtGrade.Name = "TxtGrade"
        Me.TxtGrade.ReadOnly = True
        Me.TxtGrade.Size = New System.Drawing.Size(206, 29)
        Me.TxtGrade.SLFAutoTrim = False
        Me.TxtGrade.SLFHarusDiisi = False
        Me.TxtGrade.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtGrade.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtGrade.SLFHightlightSaatFokus = False
        Me.TxtGrade.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtGrade.SLFIsBlank = True
        Me.TxtGrade.SLFIsSearchBox = False
        Me.TxtGrade.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtGrade.SLFPilihSemuaSaatFokus = False
        Me.TxtGrade.SLFPwdLengthMin = 8
        Me.TxtGrade.SLFPwdStrengthCalculate = False
        Me.TxtGrade.SLFPwdStrengthScore = 0
        Me.TxtGrade.SLFPwdStrengthText = Nothing
        Me.TxtGrade.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtGrade.SLFSearchBoxText = "Type then press Enter"
        Me.TxtGrade.SLFSQLText = ""
        Me.TxtGrade.SLFTanpaSpasi = False
        Me.TxtGrade.SLFValidasiField = Nothing
        Me.TxtGrade.TabIndex = 206
        Me.TxtGrade.TabStop = False
        Me.TxtGrade.Tag = "txt"
        '
        'TxtPositionID
        '
        Me.TxtPositionID.BackColor = System.Drawing.Color.LightPink
        Me.TxtPositionID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPositionID.Location = New System.Drawing.Point(164, 78)
        Me.TxtPositionID.MaxLength = 255
        Me.TxtPositionID.Name = "TxtPositionID"
        Me.TxtPositionID.Size = New System.Drawing.Size(62, 29)
        Me.TxtPositionID.SLFAutoTrim = True
        Me.TxtPositionID.SLFHarusDiisi = True
        Me.TxtPositionID.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPositionID.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPositionID.SLFHightlightSaatFokus = True
        Me.TxtPositionID.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPositionID.SLFIsBlank = True
        Me.TxtPositionID.SLFIsSearchBox = False
        Me.TxtPositionID.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtPositionID.SLFPilihSemuaSaatFokus = True
        Me.TxtPositionID.SLFPwdLengthMin = 8
        Me.TxtPositionID.SLFPwdStrengthCalculate = False
        Me.TxtPositionID.SLFPwdStrengthScore = 0
        Me.TxtPositionID.SLFPwdStrengthText = Nothing
        Me.TxtPositionID.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPositionID.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPositionID.SLFSQLText = ""
        Me.TxtPositionID.SLFTanpaSpasi = True
        Me.TxtPositionID.SLFValidasiField = Nothing
        Me.TxtPositionID.TabIndex = 202
        Me.TxtPositionID.Tag = "txt"
        Me.TxtPositionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPosition
        '
        Me.TxtPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPosition.Location = New System.Drawing.Point(232, 78)
        Me.TxtPosition.MaxLength = 255
        Me.TxtPosition.Name = "TxtPosition"
        Me.TxtPosition.ReadOnly = True
        Me.TxtPosition.Size = New System.Drawing.Size(206, 29)
        Me.TxtPosition.SLFAutoTrim = False
        Me.TxtPosition.SLFHarusDiisi = False
        Me.TxtPosition.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPosition.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPosition.SLFHightlightSaatFokus = False
        Me.TxtPosition.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPosition.SLFIsBlank = True
        Me.TxtPosition.SLFIsSearchBox = False
        Me.TxtPosition.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPosition.SLFPilihSemuaSaatFokus = False
        Me.TxtPosition.SLFPwdLengthMin = 8
        Me.TxtPosition.SLFPwdStrengthCalculate = False
        Me.TxtPosition.SLFPwdStrengthScore = 0
        Me.TxtPosition.SLFPwdStrengthText = Nothing
        Me.TxtPosition.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPosition.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPosition.SLFSQLText = ""
        Me.TxtPosition.SLFTanpaSpasi = False
        Me.TxtPosition.SLFValidasiField = Nothing
        Me.TxtPosition.TabIndex = 203
        Me.TxtPosition.TabStop = False
        Me.TxtPosition.Tag = "txt"
        '
        'TxtGradeID
        '
        Me.TxtGradeID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtGradeID.Location = New System.Drawing.Point(164, 113)
        Me.TxtGradeID.MaxLength = 255
        Me.TxtGradeID.Name = "TxtGradeID"
        Me.TxtGradeID.ReadOnly = True
        Me.TxtGradeID.Size = New System.Drawing.Size(62, 29)
        Me.TxtGradeID.SLFAutoTrim = False
        Me.TxtGradeID.SLFHarusDiisi = False
        Me.TxtGradeID.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtGradeID.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtGradeID.SLFHightlightSaatFokus = False
        Me.TxtGradeID.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtGradeID.SLFIsBlank = True
        Me.TxtGradeID.SLFIsSearchBox = False
        Me.TxtGradeID.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtGradeID.SLFPilihSemuaSaatFokus = False
        Me.TxtGradeID.SLFPwdLengthMin = 8
        Me.TxtGradeID.SLFPwdStrengthCalculate = False
        Me.TxtGradeID.SLFPwdStrengthScore = 0
        Me.TxtGradeID.SLFPwdStrengthText = Nothing
        Me.TxtGradeID.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtGradeID.SLFSearchBoxText = "Type then press Enter"
        Me.TxtGradeID.SLFSQLText = ""
        Me.TxtGradeID.SLFTanpaSpasi = False
        Me.TxtGradeID.SLFValidasiField = Nothing
        Me.TxtGradeID.TabIndex = 205
        Me.TxtGradeID.TabStop = False
        Me.TxtGradeID.Tag = "txt"
        Me.TxtGradeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnBrowsePosition
        '
        Me.BtnBrowsePosition.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnBrowsePosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowsePosition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnBrowsePosition.FlatAppearance.BorderSize = 2
        Me.BtnBrowsePosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnBrowsePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowsePosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowsePosition.ForeColor = System.Drawing.Color.White
        Me.BtnBrowsePosition.Location = New System.Drawing.Point(444, 78)
        Me.BtnBrowsePosition.Name = "BtnBrowsePosition"
        Me.BtnBrowsePosition.Size = New System.Drawing.Size(39, 29)
        Me.BtnBrowsePosition.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnBrowsePosition.SLFTampilkanFocusBorder = False
        Me.BtnBrowsePosition.SLFValidasiSemuaInput = False
        Me.BtnBrowsePosition.SLFValidasiSemuaInputTag = Nothing
        Me.BtnBrowsePosition.TabIndex = 204
        Me.BtnBrowsePosition.Text = "..."
        Me.BtnBrowsePosition.UseVisualStyleBackColor = False
        '
        'TxtDepartement
        '
        Me.TxtDepartement.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDepartement.Location = New System.Drawing.Point(164, 43)
        Me.TxtDepartement.MaxLength = 255
        Me.TxtDepartement.Name = "TxtDepartement"
        Me.TxtDepartement.ReadOnly = True
        Me.TxtDepartement.Size = New System.Drawing.Size(274, 29)
        Me.TxtDepartement.SLFAutoTrim = False
        Me.TxtDepartement.SLFHarusDiisi = False
        Me.TxtDepartement.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDepartement.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDepartement.SLFHightlightSaatFokus = False
        Me.TxtDepartement.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDepartement.SLFIsBlank = True
        Me.TxtDepartement.SLFIsSearchBox = False
        Me.TxtDepartement.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtDepartement.SLFPilihSemuaSaatFokus = False
        Me.TxtDepartement.SLFPwdLengthMin = 8
        Me.TxtDepartement.SLFPwdStrengthCalculate = False
        Me.TxtDepartement.SLFPwdStrengthScore = 0
        Me.TxtDepartement.SLFPwdStrengthText = Nothing
        Me.TxtDepartement.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDepartement.SLFSearchBoxText = "Type then press Enter"
        Me.TxtDepartement.SLFSQLText = ""
        Me.TxtDepartement.SLFTanpaSpasi = False
        Me.TxtDepartement.SLFValidasiField = Nothing
        Me.TxtDepartement.TabIndex = 201
        Me.TxtDepartement.TabStop = False
        Me.TxtDepartement.Tag = "txt"
        '
        'TxtCompany
        '
        Me.TxtCompany.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtCompany.Location = New System.Drawing.Point(164, 8)
        Me.TxtCompany.MaxLength = 255
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.ReadOnly = True
        Me.TxtCompany.Size = New System.Drawing.Size(274, 29)
        Me.TxtCompany.SLFAutoTrim = False
        Me.TxtCompany.SLFHarusDiisi = False
        Me.TxtCompany.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtCompany.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtCompany.SLFHightlightSaatFokus = False
        Me.TxtCompany.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtCompany.SLFIsBlank = True
        Me.TxtCompany.SLFIsSearchBox = False
        Me.TxtCompany.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtCompany.SLFPilihSemuaSaatFokus = False
        Me.TxtCompany.SLFPwdLengthMin = 8
        Me.TxtCompany.SLFPwdStrengthCalculate = False
        Me.TxtCompany.SLFPwdStrengthScore = 0
        Me.TxtCompany.SLFPwdStrengthText = Nothing
        Me.TxtCompany.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtCompany.SLFSearchBoxText = "Type then press Enter"
        Me.TxtCompany.SLFSQLText = ""
        Me.TxtCompany.SLFTanpaSpasi = False
        Me.TxtCompany.SLFValidasiField = Nothing
        Me.TxtCompany.TabIndex = 200
        Me.TxtCompany.TabStop = False
        Me.TxtCompany.Tag = "txt"
        '
        'tpGeneral
        '
        Me.tpGeneral.AutoScroll = True
        Me.tpGeneral.Controls.Add(Me.ULbl1)
        Me.tpGeneral.Controls.Add(Me.ULbl5)
        Me.tpGeneral.Controls.Add(Me.ULbl4)
        Me.tpGeneral.Controls.Add(Me.ULbl3)
        Me.tpGeneral.Controls.Add(Me.ULbl16)
        Me.tpGeneral.Controls.Add(Me.ULbl2)
        Me.tpGeneral.Controls.Add(Me.TxtAddress)
        Me.tpGeneral.Controls.Add(Me.TxtBirthPlace)
        Me.tpGeneral.Controls.Add(Me.DtpBirthDate)
        Me.tpGeneral.Controls.Add(Me.TxtPersonalID)
        Me.tpGeneral.Controls.Add(Me.CboGender)
        Me.tpGeneral.Controls.Add(Me.TxtFullName)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 30)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneral.Size = New System.Drawing.Size(491, 323)
        Me.tpGeneral.TabIndex = 0
        Me.tpGeneral.Text = "PERSONAL"
        Me.tpGeneral.UseVisualStyleBackColor = True
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(7, 8)
        Me.ULbl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Personal ID"
        Me.ULbl1.SLFTextAdjuster = True
        Me.ULbl1.SLFTextBorder = False
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1056
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(7, 183)
        Me.ULbl5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 134)
        Me.ULbl5.SLFText = "Address"
        Me.ULbl5.SLFTextAdjuster = True
        Me.ULbl5.SLFTextBorder = False
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 1055
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(7, 148)
        Me.ULbl4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Gender"
        Me.ULbl4.SLFTextAdjuster = True
        Me.ULbl4.SLFTextBorder = False
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1054
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(7, 113)
        Me.ULbl3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Birth Place"
        Me.ULbl3.SLFTextAdjuster = True
        Me.ULbl3.SLFTextBorder = False
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1053
        '
        'ULbl16
        '
        Me.ULbl16.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl16.Location = New System.Drawing.Point(7, 78)
        Me.ULbl16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl16.Name = "ULbl16"
        Me.ULbl16.Size = New System.Drawing.Size(150, 29)
        Me.ULbl16.SLFText = "Date of Birth"
        Me.ULbl16.SLFTextAdjuster = True
        Me.ULbl16.SLFTextBorder = False
        Me.ULbl16.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl16.TabIndex = 1052
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(7, 43)
        Me.ULbl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Full Name"
        Me.ULbl2.SLFTextAdjuster = True
        Me.ULbl2.SLFTextBorder = False
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1051
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAddress.Location = New System.Drawing.Point(164, 183)
        Me.TxtAddress.MaxLength = 1024
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtAddress.Size = New System.Drawing.Size(321, 134)
        Me.TxtAddress.SLFAutoTrim = True
        Me.TxtAddress.SLFHarusDiisi = False
        Me.TxtAddress.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtAddress.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtAddress.SLFHightlightSaatFokus = False
        Me.TxtAddress.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtAddress.SLFIsBlank = False
        Me.TxtAddress.SLFIsSearchBox = False
        Me.TxtAddress.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtAddress.SLFPilihSemuaSaatFokus = False
        Me.TxtAddress.SLFPwdLengthMin = 8
        Me.TxtAddress.SLFPwdStrengthCalculate = False
        Me.TxtAddress.SLFPwdStrengthScore = 0
        Me.TxtAddress.SLFPwdStrengthText = Nothing
        Me.TxtAddress.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtAddress.SLFSearchBoxText = "Type then press Enter"
        Me.TxtAddress.SLFSQLText = ""
        Me.TxtAddress.SLFTanpaSpasi = False
        Me.TxtAddress.SLFValidasiField = Nothing
        Me.TxtAddress.TabIndex = 105
        Me.TxtAddress.Tag = "txt"
        '
        'TxtBirthPlace
        '
        Me.TxtBirthPlace.BackColor = System.Drawing.Color.White
        Me.TxtBirthPlace.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtBirthPlace.Location = New System.Drawing.Point(164, 113)
        Me.TxtBirthPlace.MaxLength = 255
        Me.TxtBirthPlace.Name = "TxtBirthPlace"
        Me.TxtBirthPlace.Size = New System.Drawing.Size(206, 29)
        Me.TxtBirthPlace.SLFAutoTrim = True
        Me.TxtBirthPlace.SLFHarusDiisi = False
        Me.TxtBirthPlace.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtBirthPlace.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtBirthPlace.SLFHightlightSaatFokus = False
        Me.TxtBirthPlace.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtBirthPlace.SLFIsBlank = False
        Me.TxtBirthPlace.SLFIsSearchBox = False
        Me.TxtBirthPlace.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtBirthPlace.SLFPilihSemuaSaatFokus = False
        Me.TxtBirthPlace.SLFPwdLengthMin = 8
        Me.TxtBirthPlace.SLFPwdStrengthCalculate = False
        Me.TxtBirthPlace.SLFPwdStrengthScore = 0
        Me.TxtBirthPlace.SLFPwdStrengthText = Nothing
        Me.TxtBirthPlace.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtBirthPlace.SLFSearchBoxText = "Type then press Enter"
        Me.TxtBirthPlace.SLFSQLText = ""
        Me.TxtBirthPlace.SLFTanpaSpasi = False
        Me.TxtBirthPlace.SLFValidasiField = Nothing
        Me.TxtBirthPlace.TabIndex = 103
        Me.TxtBirthPlace.Tag = "txt"
        '
        'DtpBirthDate
        '
        Me.DtpBirthDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtpBirthDate.Location = New System.Drawing.Point(164, 78)
        Me.DtpBirthDate.MaxDate = New Date(2029, 4, 3, 0, 0, 0, 0)
        Me.DtpBirthDate.MinDate = New Date(1919, 4, 3, 0, 0, 0, 0)
        Me.DtpBirthDate.Name = "DtpBirthDate"
        Me.DtpBirthDate.Size = New System.Drawing.Size(237, 29)
        Me.DtpBirthDate.SLFResetOnDisabled = False
        Me.DtpBirthDate.TabIndex = 102
        '
        'TxtPersonalID
        '
        Me.TxtPersonalID.BackColor = System.Drawing.Color.LightPink
        Me.TxtPersonalID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPersonalID.Location = New System.Drawing.Point(164, 8)
        Me.TxtPersonalID.MaxLength = 16
        Me.TxtPersonalID.Name = "TxtPersonalID"
        Me.TxtPersonalID.Size = New System.Drawing.Size(206, 29)
        Me.TxtPersonalID.SLFAutoTrim = True
        Me.TxtPersonalID.SLFHarusDiisi = True
        Me.TxtPersonalID.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPersonalID.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPersonalID.SLFHightlightSaatFokus = True
        Me.TxtPersonalID.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPersonalID.SLFIsBlank = True
        Me.TxtPersonalID.SLFIsSearchBox = False
        Me.TxtPersonalID.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPersonalID.SLFPilihSemuaSaatFokus = False
        Me.TxtPersonalID.SLFPwdLengthMin = 8
        Me.TxtPersonalID.SLFPwdStrengthCalculate = False
        Me.TxtPersonalID.SLFPwdStrengthScore = 0
        Me.TxtPersonalID.SLFPwdStrengthText = Nothing
        Me.TxtPersonalID.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPersonalID.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPersonalID.SLFSQLText = ""
        Me.TxtPersonalID.SLFTanpaSpasi = False
        Me.TxtPersonalID.SLFValidasiField = Nothing
        Me.TxtPersonalID.TabIndex = 100
        Me.TxtPersonalID.Tag = "txt"
        '
        'CboGender
        '
        Me.CboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboGender.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
        Me.CboGender.Location = New System.Drawing.Point(164, 148)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(137, 29)
        Me.CboGender.TabIndex = 104
        '
        'TxtFullName
        '
        Me.TxtFullName.BackColor = System.Drawing.Color.LightPink
        Me.TxtFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtFullName.Location = New System.Drawing.Point(164, 43)
        Me.TxtFullName.MaxLength = 255
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(274, 29)
        Me.TxtFullName.SLFAutoTrim = True
        Me.TxtFullName.SLFHarusDiisi = True
        Me.TxtFullName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtFullName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtFullName.SLFHightlightSaatFokus = True
        Me.TxtFullName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtFullName.SLFIsBlank = False
        Me.TxtFullName.SLFIsSearchBox = False
        Me.TxtFullName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtFullName.SLFPilihSemuaSaatFokus = False
        Me.TxtFullName.SLFPwdLengthMin = 8
        Me.TxtFullName.SLFPwdStrengthCalculate = False
        Me.TxtFullName.SLFPwdStrengthScore = 0
        Me.TxtFullName.SLFPwdStrengthText = Nothing
        Me.TxtFullName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFullName.SLFSearchBoxText = "Type then press Enter"
        Me.TxtFullName.SLFSQLText = ""
        Me.TxtFullName.SLFTanpaSpasi = False
        Me.TxtFullName.SLFValidasiField = Nothing
        Me.TxtFullName.TabIndex = 101
        Me.TxtFullName.Tag = "txt"
        '
        'TbctlEmployee
        '
        Me.TbctlEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbctlEmployee.Controls.Add(Me.tpGeneral)
        Me.TbctlEmployee.Controls.Add(Me.tpWorkIn)
        Me.TbctlEmployee.Controls.Add(Me.tpPermissions)
        Me.TbctlEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TbctlEmployee.Location = New System.Drawing.Point(12, 13)
        Me.TbctlEmployee.Name = "TbctlEmployee"
        Me.TbctlEmployee.SelectedIndex = 0
        Me.TbctlEmployee.Size = New System.Drawing.Size(499, 357)
        Me.TbctlEmployee.TabIndex = 1039
        '
        'ULbl8
        '
        Me.ULbl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ULbl8.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl8.Location = New System.Drawing.Point(533, 43)
        Me.ULbl8.Name = "ULbl8"
        Me.ULbl8.Size = New System.Drawing.Size(150, 29)
        Me.ULbl8.SLFText = "Photo"
        Me.ULbl8.SLFTextAdjuster = False
        Me.ULbl8.SLFTextBorder = False
        Me.ULbl8.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl8.TabIndex = 1041
        '
        'EPLS_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(709, 502)
        Me.KeyPreview = True
        Me.Name = "EPLS_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.pctbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbxFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPermissions.ResumeLayout(False)
        Me.tpPermissions.PerformLayout()
        Me.GbxModulesRoles.ResumeLayout(False)
        CType(Me.DgnModulesRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxCredetials.ResumeLayout(False)
        Me.GbxCredetials.PerformLayout()
        Me.tpWorkIn.ResumeLayout(False)
        Me.tpWorkIn.PerformLayout()
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        Me.TbctlEmployee.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents BtnBrowsePhoto As CMCv.btn
    Friend WithEvents pctbxPhoto As CMCv.pctbx
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents pcbxFrame As CMCv.pctbx
    Friend WithEvents TbctlEmployee As CMCv.tbctl
    Friend WithEvents tpGeneral As TabPage
    Friend WithEvents TxtPersonalID As CMCv.txt
    Friend WithEvents CboGender As CMCv.cbo
    Friend WithEvents TxtFullName As CMCv.txt
    Friend WithEvents tpWorkIn As TabPage
    Friend WithEvents TxtEmployeeNickname As CMCv.txt
    Friend WithEvents TxtContractType As CMCv.txt
    Friend WithEvents TxtContractTypeID As CMCv.txt
    Friend WithEvents TxtEmployeeNumber As CMCv.txt
    Friend WithEvents TxtGrade As CMCv.txt
    Friend WithEvents TxtPositionID As CMCv.txt
    Friend WithEvents TxtPosition As CMCv.txt
    Friend WithEvents TxtGradeID As CMCv.txt
    Friend WithEvents BtnBrowsePosition As CMCv.btn
    Friend WithEvents TxtDepartement As CMCv.txt
    Friend WithEvents TxtCompany As CMCv.txt
    Friend WithEvents tpPermissions As TabPage
    Friend WithEvents GbxModulesRoles As CMCv.gbx
    Friend WithEvents DgnModulesRoles As CMCv.dgn
    Friend WithEvents DtpBirthDate As CMCv.dtp
    Friend WithEvents ChkActiveEmployee As CMCv.chk
    Friend WithEvents TxtBirthPlace As CMCv.txt
    Friend WithEvents TxtAddress As CMCv.txt
    Friend WithEvents GbxCredetials As CMCv.gbx
    Friend WithEvents TxtLogin As CMCv.txt
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents module_code As DataGridViewTextBoxColumn
    Friend WithEvents useraccess_view As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_add As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_edit As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_delete As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_reports As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_id As DataGridViewTextBoxColumn
    Friend WithEvents module_id As DataGridViewTextBoxColumn
    Friend WithEvents ULbl8 As CMCv.ULbl
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl16 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl14 As CMCv.ULbl
    Friend WithEvents ULbl13 As CMCv.ULbl
    Friend WithEvents ULbl12 As CMCv.ULbl
    Friend WithEvents ULbl11 As CMCv.ULbl
    Friend WithEvents ULbl10 As CMCv.ULbl
    Friend WithEvents ULbl9 As CMCv.ULbl
    Friend WithEvents ULbl6 As CMCv.ULbl
    Friend WithEvents ULbl7 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
End Class
