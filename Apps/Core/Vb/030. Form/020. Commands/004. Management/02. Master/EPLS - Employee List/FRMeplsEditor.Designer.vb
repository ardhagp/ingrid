Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMeplsEditor
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
            components = New ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMeplsEditor))
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            ChkAddNew = New CMCv.UI.Control.chk(components)
            BtnSave = New CMCv.UI.Control.btn(components)
            BtnCancel = New CMCv.UI.Control.btn(components)
            pctbxPhoto = New CMCv.UI.Control.pctbx(components)
            BtnBrowsePhoto = New CMCv.UI.Control.btn(components)
            OfdPhoto = New OpenFileDialog()
            pcbxFrame = New CMCv.UI.Control.pctbx(components)
            tpPermissions = New TabPage()
            GbxModulesRoles = New CMCv.UI.Control.gbx(components)
            DgnModulesRoles = New CMCv.UI.Control.dgn(components)
            modulegroup_name = New DataGridViewTextBoxColumn()
            module_code = New DataGridViewTextBoxColumn()
            useraccess_view = New DataGridViewCheckBoxColumn()
            useraccess_add = New DataGridViewCheckBoxColumn()
            useraccess_edit = New DataGridViewCheckBoxColumn()
            useraccess_delete = New DataGridViewCheckBoxColumn()
            useraccess_reports = New DataGridViewCheckBoxColumn()
            useraccess_id = New DataGridViewTextBoxColumn()
            module_id = New DataGridViewTextBoxColumn()
            GbxCredetials = New CMCv.UI.Control.gbx(components)
            ULbl7 = New CMCv.UI.Control.ULbl()
            TxtLogin = New CMCv.UI.Control.txt(components)
            tpWorkIn = New TabPage()
            ULbl14 = New CMCv.UI.Control.ULbl()
            ULbl13 = New CMCv.UI.Control.ULbl()
            ULbl12 = New CMCv.UI.Control.ULbl()
            ULbl11 = New CMCv.UI.Control.ULbl()
            ULbl10 = New CMCv.UI.Control.ULbl()
            ULbl9 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            ChkActiveEmployee = New CMCv.UI.Control.chk(components)
            TxtEmployeeNickname = New CMCv.UI.Control.txt(components)
            TxtContractType = New CMCv.UI.Control.txt(components)
            TxtContractTypeID = New CMCv.UI.Control.txt(components)
            TxtEmployeeNumber = New CMCv.UI.Control.txt(components)
            TxtGrade = New CMCv.UI.Control.txt(components)
            TxtPositionID = New CMCv.UI.Control.txt(components)
            TxtPosition = New CMCv.UI.Control.txt(components)
            TxtGradeID = New CMCv.UI.Control.txt(components)
            BtnBrowsePosition = New CMCv.UI.Control.btn(components)
            TxTDepartment = New CMCv.UI.Control.txt(components)
            TxtCompany = New CMCv.UI.Control.txt(components)
            tpGeneral = New TabPage()
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl16 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            TxtAddress = New CMCv.UI.Control.txt(components)
            TxtBirthPlace = New CMCv.UI.Control.txt(components)
            DtpBirthDate = New CMCv.UI.Control.dtp(components)
            TxtPersonalID = New CMCv.UI.Control.txt(components)
            CboGender = New CMCv.UI.Control.cbo(components)
            TxtFullName = New CMCv.UI.Control.txt(components)
            TbctlEmployee = New CMCv.UI.Control.tbctl(components)
            ULbl8 = New CMCv.UI.Control.ULbl()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(pctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
            CType(pcbxFrame, ComponentModel.ISupportInitialize).BeginInit()
            tpPermissions.SuspendLayout()
            GbxModulesRoles.SuspendLayout()
            CType(DgnModulesRoles, ComponentModel.ISupportInitialize).BeginInit()
            GbxCredetials.SuspendLayout()
            tpWorkIn.SuspendLayout()
            tpGeneral.SuspendLayout()
            TbctlEmployee.SuspendLayout()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Location = New Point(0, 742)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(1181, 97)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(1181, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl8)
            SLFPanel.Controls.Add(TbctlEmployee)
            SLFPanel.Controls.Add(BtnBrowsePhoto)
            SLFPanel.Controls.Add(pctbxPhoto)
            SLFPanel.Controls.Add(pcbxFrame)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(1181, 839)
            SLFPanel.Controls.SetChildIndex(pcbxFrame, 0)
            SLFPanel.Controls.SetChildIndex(pctbxPhoto, 0)
            SLFPanel.Controls.SetChildIndex(BtnBrowsePhoto, 0)
            SLFPanel.Controls.SetChildIndex(TbctlEmployee, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(ULbl8, 0)
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(586, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 803
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' BtnSave
            ' 
            BtnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnSave.BackColor = Color.LimeGreen
            BtnSave.Cursor = Cursors.Hand
            BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnSave.FlatAppearance.BorderSize = 2
            BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnSave.FlatStyle = FlatStyle.Flat
            BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(817, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 801
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
            BtnSave.XOTampilkanFocusBorder = False
            BtnSave.XOValidasiSemuaInput = False
            BtnSave.XOValidasiSemuaInputTag = Nothing
            ' 
            ' BtnCancel
            ' 
            BtnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnCancel.BackColor = Color.Red
            BtnCancel.Cursor = Cursors.Hand
            BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnCancel.FlatAppearance.BorderSize = 2
            BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnCancel.FlatStyle = FlatStyle.Flat
            BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(994, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 802
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnCancel.XOTampilkanFocusBorder = False
            BtnCancel.XOValidasiSemuaInput = False
            BtnCancel.XOValidasiSemuaInputTag = Nothing
            ' 
            ' pctbxPhoto
            ' 
            pctbxPhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            pctbxPhoto.BackColor = Color.White
            pctbxPhoto.ErrorImage = CType(resources.GetObject("pctbxPhoto.ErrorImage"), Image)
            pctbxPhoto.Image = CType(resources.GetObject("pctbxPhoto.Image"), Image)
            pctbxPhoto.InitialImage = CType(resources.GetObject("pctbxPhoto.InitialImage"), Image)
            pctbxPhoto.Location = New Point(933, 165)
            pctbxPhoto.Margin = New Padding(6, 5, 6, 5)
            pctbxPhoto.Name = "pctbxPhoto"
            pctbxPhoto.Padding = New Padding(26, 28, 26, 28)
            pctbxPhoto.Size = New Size(179, 242)
            pctbxPhoto.SizeMode = PictureBoxSizeMode.Zoom
            pctbxPhoto.TabIndex = 1038
            pctbxPhoto.TabStop = False
            pctbxPhoto.XOTampilkanBorder = False
            pctbxPhoto.XOWarnaBorder = Color.Transparent
            ' 
            ' BtnBrowsePhoto
            ' 
            BtnBrowsePhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnBrowsePhoto.BackColor = Color.RoyalBlue
            BtnBrowsePhoto.Cursor = Cursors.Hand
            BtnBrowsePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowsePhoto.FlatAppearance.BorderSize = 2
            BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowsePhoto.FlatStyle = FlatStyle.Flat
            BtnBrowsePhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowsePhoto.ForeColor = Color.White
            BtnBrowsePhoto.Location = New Point(933, 428)
            BtnBrowsePhoto.Margin = New Padding(6, 5, 6, 5)
            BtnBrowsePhoto.Name = "BtnBrowsePhoto"
            BtnBrowsePhoto.Size = New Size(179, 80)
            BtnBrowsePhoto.TabIndex = 800
            BtnBrowsePhoto.Text = "Browse"
            BtnBrowsePhoto.UseVisualStyleBackColor = False
            BtnBrowsePhoto.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
            BtnBrowsePhoto.XOTampilkanFocusBorder = False
            BtnBrowsePhoto.XOValidasiSemuaInput = False
            BtnBrowsePhoto.XOValidasiSemuaInputTag = Nothing
            ' 
            ' OfdPhoto
            ' 
            OfdPhoto.FileName = "OpenFileDialog1"
            ' 
            ' pcbxFrame
            ' 
            pcbxFrame.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            pcbxFrame.BackColor = Color.White
            pcbxFrame.BorderStyle = BorderStyle.FixedSingle
            pcbxFrame.ErrorImage = CType(resources.GetObject("pcbxFrame.ErrorImage"), Image)
            pcbxFrame.InitialImage = CType(resources.GetObject("pcbxFrame.InitialImage"), Image)
            pcbxFrame.Location = New Point(924, 155)
            pcbxFrame.Margin = New Padding(6, 5, 6, 5)
            pcbxFrame.Name = "pcbxFrame"
            pcbxFrame.Size = New Size(193, 260)
            pcbxFrame.SizeMode = PictureBoxSizeMode.Zoom
            pcbxFrame.TabIndex = 1040
            pcbxFrame.TabStop = False
            pcbxFrame.XOTampilkanBorder = False
            pcbxFrame.XOWarnaBorder = Color.DodgerBlue
            ' 
            ' tpPermissions
            ' 
            tpPermissions.Controls.Add(GbxModulesRoles)
            tpPermissions.Controls.Add(GbxCredetials)
            tpPermissions.Location = New Point(4, 41)
            tpPermissions.Margin = New Padding(6, 5, 6, 5)
            tpPermissions.Name = "tpPermissions"
            tpPermissions.Padding = New Padding(6, 5, 6, 5)
            tpPermissions.Size = New Size(1508, 1410)
            tpPermissions.TabIndex = 1
            tpPermissions.Text = "PERMISSIONS"
            tpPermissions.UseVisualStyleBackColor = True
            ' 
            ' GbxModulesRoles
            ' 
            GbxModulesRoles.AutoSize = True
            GbxModulesRoles.Controls.Add(DgnModulesRoles)
            GbxModulesRoles.Dock = DockStyle.Fill
            GbxModulesRoles.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            GbxModulesRoles.Location = New Point(6, 185)
            GbxModulesRoles.Margin = New Padding(6, 5, 6, 5)
            GbxModulesRoles.Name = "GbxModulesRoles"
            GbxModulesRoles.Padding = New Padding(6, 5, 6, 5)
            GbxModulesRoles.Size = New Size(1496, 1220)
            GbxModulesRoles.TabIndex = 0
            GbxModulesRoles.TabStop = False
            GbxModulesRoles.Text = "Modules or roles"
            ' 
            ' DgnModulesRoles
            ' 
            DgnModulesRoles.AllowUserToAddRows = False
            DgnModulesRoles.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(192), CByte(208), CByte(115))
            DgnModulesRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnModulesRoles.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnModulesRoles.BorderStyle = BorderStyle.None
            DgnModulesRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnModulesRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnModulesRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnModulesRoles.ColumnHeadersHeight = 43
            DgnModulesRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnModulesRoles.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports, useraccess_id, module_id})
            DgnModulesRoles.Dock = DockStyle.Fill
            DgnModulesRoles.EnableHeadersVisualStyles = False
            DgnModulesRoles.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnModulesRoles.Location = New Point(6, 37)
            DgnModulesRoles.Margin = New Padding(6, 5, 6, 5)
            DgnModulesRoles.Name = "DgnModulesRoles"
            DgnModulesRoles.ReadOnly = True
            DgnModulesRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnModulesRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnModulesRoles.RowHeadersWidth = 62
            DgnModulesRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnModulesRoles.Size = New Size(1484, 1178)
            DgnModulesRoles.StandardTab = True
            DgnModulesRoles.TabIndex = 0
            DgnModulesRoles.XOGroupFirstRows = True
            DgnModulesRoles.XOGunakanNomorBaris = True
            ' 
            ' modulegroup_name
            ' 
            modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            modulegroup_name.DataPropertyName = "modulegroup_name"
            modulegroup_name.HeaderText = "Module Group"
            modulegroup_name.MinimumWidth = 8
            modulegroup_name.Name = "modulegroup_name"
            modulegroup_name.ReadOnly = True
            modulegroup_name.Width = 142
            ' 
            ' module_code
            ' 
            module_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            module_code.DataPropertyName = "module_code"
            module_code.HeaderText = "Module Code"
            module_code.MinimumWidth = 8
            module_code.Name = "module_code"
            module_code.ReadOnly = True
            module_code.Width = 135
            ' 
            ' useraccess_view
            ' 
            useraccess_view.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_view.DataPropertyName = "useraccess_view"
            useraccess_view.HeaderText = "View"
            useraccess_view.MinimumWidth = 8
            useraccess_view.Name = "useraccess_view"
            useraccess_view.ReadOnly = True
            useraccess_view.Resizable = DataGridViewTriState.True
            useraccess_view.SortMode = DataGridViewColumnSortMode.Automatic
            useraccess_view.Width = 40
            ' 
            ' useraccess_add
            ' 
            useraccess_add.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_add.DataPropertyName = "useraccess_add"
            useraccess_add.HeaderText = "Add"
            useraccess_add.MinimumWidth = 8
            useraccess_add.Name = "useraccess_add"
            useraccess_add.ReadOnly = True
            useraccess_add.Resizable = DataGridViewTriState.True
            useraccess_add.SortMode = DataGridViewColumnSortMode.Automatic
            useraccess_add.Width = 40
            ' 
            ' useraccess_edit
            ' 
            useraccess_edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_edit.DataPropertyName = "useraccess_edit"
            useraccess_edit.HeaderText = "Edit"
            useraccess_edit.MinimumWidth = 8
            useraccess_edit.Name = "useraccess_edit"
            useraccess_edit.ReadOnly = True
            useraccess_edit.Resizable = DataGridViewTriState.True
            useraccess_edit.SortMode = DataGridViewColumnSortMode.Automatic
            useraccess_edit.Width = 40
            ' 
            ' useraccess_delete
            ' 
            useraccess_delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_delete.DataPropertyName = "useraccess_delete"
            useraccess_delete.HeaderText = "Del"
            useraccess_delete.MinimumWidth = 8
            useraccess_delete.Name = "useraccess_delete"
            useraccess_delete.ReadOnly = True
            useraccess_delete.Resizable = DataGridViewTriState.True
            useraccess_delete.SortMode = DataGridViewColumnSortMode.Automatic
            useraccess_delete.Width = 40
            ' 
            ' useraccess_reports
            ' 
            useraccess_reports.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_reports.DataPropertyName = "useraccess_reports"
            useraccess_reports.HeaderText = "Rpt"
            useraccess_reports.MinimumWidth = 8
            useraccess_reports.Name = "useraccess_reports"
            useraccess_reports.ReadOnly = True
            useraccess_reports.Resizable = DataGridViewTriState.True
            useraccess_reports.SortMode = DataGridViewColumnSortMode.Automatic
            useraccess_reports.Width = 40
            ' 
            ' useraccess_id
            ' 
            useraccess_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            useraccess_id.DataPropertyName = "useraccess_id"
            useraccess_id.HeaderText = "UID"
            useraccess_id.MinimumWidth = 8
            useraccess_id.Name = "useraccess_id"
            useraccess_id.ReadOnly = True
            useraccess_id.Visible = False
            useraccess_id.Width = 150
            ' 
            ' module_id
            ' 
            module_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            module_id.DataPropertyName = "module_id"
            module_id.HeaderText = "Module ID"
            module_id.MinimumWidth = 8
            module_id.Name = "module_id"
            module_id.ReadOnly = True
            module_id.Visible = False
            module_id.Width = 150
            ' 
            ' GbxCredetials
            ' 
            GbxCredetials.Controls.Add(ULbl7)
            GbxCredetials.Controls.Add(TxtLogin)
            GbxCredetials.Dock = DockStyle.Top
            GbxCredetials.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            GbxCredetials.Location = New Point(6, 5)
            GbxCredetials.Margin = New Padding(6, 5, 6, 5)
            GbxCredetials.Name = "GbxCredetials"
            GbxCredetials.Padding = New Padding(6, 5, 6, 5)
            GbxCredetials.Size = New Size(1496, 180)
            GbxCredetials.TabIndex = 3
            GbxCredetials.TabStop = False
            GbxCredetials.Text = "Credentials"
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.Moccasin
            ULbl7.Location = New Point(11, 77)
            ULbl7.Margin = New Padding(7, 10, 7, 10)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(250, 55)
            ULbl7.SLFText = "Login"
            ULbl7.SLFTextAdjuster = True
            ULbl7.SLFTextBorder = False
            ULbl7.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl7.TabIndex = 301
            ' 
            ' TxtLogin
            ' 
            TxtLogin.BackColor = Color.White
            TxtLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtLogin.Location = New Point(273, 77)
            TxtLogin.Margin = New Padding(6, 5, 6, 5)
            TxtLogin.MaxLength = 255
            TxtLogin.Name = "TxtLogin"
            TxtLogin.ReadOnly = True
            TxtLogin.Size = New Size(341, 39)
            TxtLogin.TabIndex = 300
            TxtLogin.Tag = "txt"
            TxtLogin.TextAlign = HorizontalAlignment.Center
            TxtLogin.XOAutoTrim = False
            TxtLogin.XOHarusDiisi = False
            TxtLogin.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtLogin.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtLogin.XOHightlightSaatFokus = False
            TxtLogin.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtLogin.XOIsBlank = False
            TxtLogin.XOIsSearchBox = False
            TxtLogin.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtLogin.XOPilihSemuaSaatFokus = False
            TxtLogin.XOPwdLengthMin = 8
            TxtLogin.XOPwdStrengthCalculate = False
            TxtLogin.XOPwdStrengthScore = 0
            TxtLogin.XOPwdStrengthText = Nothing
            TxtLogin.XORestriction = ControlCodeBase.enuRestriction.None
            TxtLogin.XOSearchBoxText = "Type then press Enter"
            TxtLogin.XOSQLText = ""
            TxtLogin.XOTanpaSpasi = False
            TxtLogin.XOValidasiField = Nothing
            ' 
            ' tpWorkIn
            ' 
            tpWorkIn.Controls.Add(ULbl14)
            tpWorkIn.Controls.Add(ULbl13)
            tpWorkIn.Controls.Add(ULbl12)
            tpWorkIn.Controls.Add(ULbl11)
            tpWorkIn.Controls.Add(ULbl10)
            tpWorkIn.Controls.Add(ULbl9)
            tpWorkIn.Controls.Add(ULbl6)
            tpWorkIn.Controls.Add(ChkActiveEmployee)
            tpWorkIn.Controls.Add(TxtEmployeeNickname)
            tpWorkIn.Controls.Add(TxtContractType)
            tpWorkIn.Controls.Add(TxtContractTypeID)
            tpWorkIn.Controls.Add(TxtEmployeeNumber)
            tpWorkIn.Controls.Add(TxtGrade)
            tpWorkIn.Controls.Add(TxtPositionID)
            tpWorkIn.Controls.Add(TxtPosition)
            tpWorkIn.Controls.Add(TxtGradeID)
            tpWorkIn.Controls.Add(BtnBrowsePosition)
            tpWorkIn.Controls.Add(TxTDepartment)
            tpWorkIn.Controls.Add(TxtCompany)
            tpWorkIn.Location = New Point(4, 41)
            tpWorkIn.Margin = New Padding(6, 5, 6, 5)
            tpWorkIn.Name = "tpWorkIn"
            tpWorkIn.Size = New Size(1508, 1410)
            tpWorkIn.TabIndex = 2
            tpWorkIn.Text = "WORK IN"
            tpWorkIn.UseVisualStyleBackColor = True
            ' 
            ' ULbl14
            ' 
            ULbl14.BackColor = Color.Moccasin
            ULbl14.Location = New Point(11, 420)
            ULbl14.Margin = New Padding(7, 10, 7, 10)
            ULbl14.Name = "ULbl14"
            ULbl14.Size = New Size(250, 55)
            ULbl14.SLFText = "Initial"
            ULbl14.SLFTextAdjuster = True
            ULbl14.SLFTextBorder = False
            ULbl14.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl14.TabIndex = 1061
            ' 
            ' ULbl13
            ' 
            ULbl13.BackColor = Color.Moccasin
            ULbl13.Location = New Point(11, 352)
            ULbl13.Margin = New Padding(7, 10, 7, 10)
            ULbl13.Name = "ULbl13"
            ULbl13.Size = New Size(250, 55)
            ULbl13.SLFText = "Contract Type"
            ULbl13.SLFTextAdjuster = True
            ULbl13.SLFTextBorder = False
            ULbl13.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl13.TabIndex = 1060
            ' 
            ' ULbl12
            ' 
            ULbl12.BackColor = Color.Moccasin
            ULbl12.Location = New Point(11, 285)
            ULbl12.Margin = New Padding(7, 10, 7, 10)
            ULbl12.Name = "ULbl12"
            ULbl12.Size = New Size(250, 55)
            ULbl12.SLFText = "Emp. Number"
            ULbl12.SLFTextAdjuster = True
            ULbl12.SLFTextBorder = False
            ULbl12.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl12.TabIndex = 1059
            ' 
            ' ULbl11
            ' 
            ULbl11.BackColor = Color.Moccasin
            ULbl11.Location = New Point(11, 217)
            ULbl11.Margin = New Padding(7, 10, 7, 10)
            ULbl11.Name = "ULbl11"
            ULbl11.Size = New Size(250, 55)
            ULbl11.SLFText = "Grade"
            ULbl11.SLFTextAdjuster = True
            ULbl11.SLFTextBorder = False
            ULbl11.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl11.TabIndex = 1058
            ' 
            ' ULbl10
            ' 
            ULbl10.BackColor = Color.Moccasin
            ULbl10.Location = New Point(11, 150)
            ULbl10.Margin = New Padding(7, 10, 7, 10)
            ULbl10.Name = "ULbl10"
            ULbl10.Size = New Size(250, 55)
            ULbl10.SLFText = "Position"
            ULbl10.SLFTextAdjuster = True
            ULbl10.SLFTextBorder = False
            ULbl10.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl10.TabIndex = 1057
            ' 
            ' ULbl9
            ' 
            ULbl9.BackColor = Color.Moccasin
            ULbl9.Location = New Point(11, 83)
            ULbl9.Margin = New Padding(7, 10, 7, 10)
            ULbl9.Name = "ULbl9"
            ULbl9.Size = New Size(250, 55)
            ULbl9.SLFText = "Department"
            ULbl9.SLFTextAdjuster = True
            ULbl9.SLFTextBorder = False
            ULbl9.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl9.TabIndex = 1056
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(11, 15)
            ULbl6.Margin = New Padding(7, 10, 7, 10)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 55)
            ULbl6.SLFText = "Company"
            ULbl6.SLFTextAdjuster = True
            ULbl6.SLFTextBorder = False
            ULbl6.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl6.TabIndex = 1055
            ' 
            ' ChkActiveEmployee
            ' 
            ChkActiveEmployee.AutoSize = True
            ChkActiveEmployee.BackColor = Color.Transparent
            ChkActiveEmployee.FlatStyle = FlatStyle.Flat
            ChkActiveEmployee.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkActiveEmployee.Location = New Point(273, 487)
            ChkActiveEmployee.Margin = New Padding(6, 5, 6, 5)
            ChkActiveEmployee.Name = "ChkActiveEmployee"
            ChkActiveEmployee.Size = New Size(213, 36)
            ChkActiveEmployee.TabIndex = 211
            ChkActiveEmployee.Text = "Active employee"
            ChkActiveEmployee.UseVisualStyleBackColor = False
            ' 
            ' TxtEmployeeNickname
            ' 
            TxtEmployeeNickname.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtEmployeeNickname.Location = New Point(273, 420)
            TxtEmployeeNickname.Margin = New Padding(6, 5, 6, 5)
            TxtEmployeeNickname.MaxLength = 255
            TxtEmployeeNickname.Name = "TxtEmployeeNickname"
            TxtEmployeeNickname.Size = New Size(101, 39)
            TxtEmployeeNickname.TabIndex = 210
            TxtEmployeeNickname.Tag = "txt"
            TxtEmployeeNickname.TextAlign = HorizontalAlignment.Center
            TxtEmployeeNickname.XOAutoTrim = True
            TxtEmployeeNickname.XOHarusDiisi = False
            TxtEmployeeNickname.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtEmployeeNickname.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtEmployeeNickname.XOHightlightSaatFokus = False
            TxtEmployeeNickname.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtEmployeeNickname.XOIsBlank = True
            TxtEmployeeNickname.XOIsSearchBox = False
            TxtEmployeeNickname.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtEmployeeNickname.XOPilihSemuaSaatFokus = False
            TxtEmployeeNickname.XOPwdLengthMin = 8
            TxtEmployeeNickname.XOPwdStrengthCalculate = False
            TxtEmployeeNickname.XOPwdStrengthScore = 0
            TxtEmployeeNickname.XOPwdStrengthText = Nothing
            TxtEmployeeNickname.XORestriction = ControlCodeBase.enuRestriction.None
            TxtEmployeeNickname.XOSearchBoxText = "Type then press Enter"
            TxtEmployeeNickname.XOSQLText = ""
            TxtEmployeeNickname.XOTanpaSpasi = False
            TxtEmployeeNickname.XOValidasiField = Nothing
            ' 
            ' TxtContractType
            ' 
            TxtContractType.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtContractType.Location = New Point(387, 352)
            TxtContractType.Margin = New Padding(6, 5, 6, 5)
            TxtContractType.MaxLength = 255
            TxtContractType.Name = "TxtContractType"
            TxtContractType.ReadOnly = True
            TxtContractType.Size = New Size(341, 39)
            TxtContractType.TabIndex = 209
            TxtContractType.TabStop = False
            TxtContractType.Tag = "txt"
            TxtContractType.XOAutoTrim = False
            TxtContractType.XOHarusDiisi = False
            TxtContractType.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtContractType.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtContractType.XOHightlightSaatFokus = False
            TxtContractType.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtContractType.XOIsBlank = True
            TxtContractType.XOIsSearchBox = False
            TxtContractType.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtContractType.XOPilihSemuaSaatFokus = False
            TxtContractType.XOPwdLengthMin = 8
            TxtContractType.XOPwdStrengthCalculate = False
            TxtContractType.XOPwdStrengthScore = 0
            TxtContractType.XOPwdStrengthText = Nothing
            TxtContractType.XORestriction = ControlCodeBase.enuRestriction.None
            TxtContractType.XOSearchBoxText = "Type then press Enter"
            TxtContractType.XOSQLText = ""
            TxtContractType.XOTanpaSpasi = False
            TxtContractType.XOValidasiField = Nothing
            ' 
            ' TxtContractTypeID
            ' 
            TxtContractTypeID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtContractTypeID.Location = New Point(273, 352)
            TxtContractTypeID.Margin = New Padding(6, 5, 6, 5)
            TxtContractTypeID.MaxLength = 255
            TxtContractTypeID.Name = "TxtContractTypeID"
            TxtContractTypeID.ReadOnly = True
            TxtContractTypeID.Size = New Size(101, 39)
            TxtContractTypeID.TabIndex = 208
            TxtContractTypeID.TabStop = False
            TxtContractTypeID.Tag = "txt"
            TxtContractTypeID.TextAlign = HorizontalAlignment.Center
            TxtContractTypeID.XOAutoTrim = False
            TxtContractTypeID.XOHarusDiisi = False
            TxtContractTypeID.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtContractTypeID.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtContractTypeID.XOHightlightSaatFokus = False
            TxtContractTypeID.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtContractTypeID.XOIsBlank = True
            TxtContractTypeID.XOIsSearchBox = False
            TxtContractTypeID.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtContractTypeID.XOPilihSemuaSaatFokus = False
            TxtContractTypeID.XOPwdLengthMin = 8
            TxtContractTypeID.XOPwdStrengthCalculate = False
            TxtContractTypeID.XOPwdStrengthScore = 0
            TxtContractTypeID.XOPwdStrengthText = Nothing
            TxtContractTypeID.XORestriction = ControlCodeBase.enuRestriction.None
            TxtContractTypeID.XOSearchBoxText = "Type then press Enter"
            TxtContractTypeID.XOSQLText = ""
            TxtContractTypeID.XOTanpaSpasi = False
            TxtContractTypeID.XOValidasiField = Nothing
            ' 
            ' TxtEmployeeNumber
            ' 
            TxtEmployeeNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtEmployeeNumber.Location = New Point(273, 285)
            TxtEmployeeNumber.Margin = New Padding(6, 5, 6, 5)
            TxtEmployeeNumber.MaxLength = 255
            TxtEmployeeNumber.Name = "TxtEmployeeNumber"
            TxtEmployeeNumber.Size = New Size(281, 39)
            TxtEmployeeNumber.TabIndex = 207
            TxtEmployeeNumber.Tag = "txt"
            TxtEmployeeNumber.TextAlign = HorizontalAlignment.Center
            TxtEmployeeNumber.XOAutoTrim = True
            TxtEmployeeNumber.XOHarusDiisi = True
            TxtEmployeeNumber.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtEmployeeNumber.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtEmployeeNumber.XOHightlightSaatFokus = True
            TxtEmployeeNumber.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtEmployeeNumber.XOIsBlank = True
            TxtEmployeeNumber.XOIsSearchBox = False
            TxtEmployeeNumber.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtEmployeeNumber.XOPilihSemuaSaatFokus = False
            TxtEmployeeNumber.XOPwdLengthMin = 8
            TxtEmployeeNumber.XOPwdStrengthCalculate = False
            TxtEmployeeNumber.XOPwdStrengthScore = 0
            TxtEmployeeNumber.XOPwdStrengthText = Nothing
            TxtEmployeeNumber.XORestriction = ControlCodeBase.enuRestriction.None
            TxtEmployeeNumber.XOSearchBoxText = "Type then press Enter"
            TxtEmployeeNumber.XOSQLText = ""
            TxtEmployeeNumber.XOTanpaSpasi = False
            TxtEmployeeNumber.XOValidasiField = Nothing
            ' 
            ' TxtGrade
            ' 
            TxtGrade.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtGrade.Location = New Point(387, 217)
            TxtGrade.Margin = New Padding(6, 5, 6, 5)
            TxtGrade.MaxLength = 255
            TxtGrade.Name = "TxtGrade"
            TxtGrade.ReadOnly = True
            TxtGrade.Size = New Size(341, 39)
            TxtGrade.TabIndex = 206
            TxtGrade.TabStop = False
            TxtGrade.Tag = "txt"
            TxtGrade.XOAutoTrim = False
            TxtGrade.XOHarusDiisi = False
            TxtGrade.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtGrade.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtGrade.XOHightlightSaatFokus = False
            TxtGrade.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtGrade.XOIsBlank = True
            TxtGrade.XOIsSearchBox = False
            TxtGrade.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtGrade.XOPilihSemuaSaatFokus = False
            TxtGrade.XOPwdLengthMin = 8
            TxtGrade.XOPwdStrengthCalculate = False
            TxtGrade.XOPwdStrengthScore = 0
            TxtGrade.XOPwdStrengthText = Nothing
            TxtGrade.XORestriction = ControlCodeBase.enuRestriction.None
            TxtGrade.XOSearchBoxText = "Type then press Enter"
            TxtGrade.XOSQLText = ""
            TxtGrade.XOTanpaSpasi = False
            TxtGrade.XOValidasiField = Nothing
            ' 
            ' TxtPositionID
            ' 
            TxtPositionID.BackColor = Color.LightPink
            TxtPositionID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPositionID.Location = New Point(273, 150)
            TxtPositionID.Margin = New Padding(6, 5, 6, 5)
            TxtPositionID.MaxLength = 255
            TxtPositionID.Name = "TxtPositionID"
            TxtPositionID.Size = New Size(101, 39)
            TxtPositionID.TabIndex = 202
            TxtPositionID.Tag = "txt"
            TxtPositionID.TextAlign = HorizontalAlignment.Center
            TxtPositionID.XOAutoTrim = True
            TxtPositionID.XOHarusDiisi = True
            TxtPositionID.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPositionID.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPositionID.XOHightlightSaatFokus = True
            TxtPositionID.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPositionID.XOIsBlank = True
            TxtPositionID.XOIsSearchBox = False
            TxtPositionID.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtPositionID.XOPilihSemuaSaatFokus = True
            TxtPositionID.XOPwdLengthMin = 8
            TxtPositionID.XOPwdStrengthCalculate = False
            TxtPositionID.XOPwdStrengthScore = 0
            TxtPositionID.XOPwdStrengthText = Nothing
            TxtPositionID.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPositionID.XOSearchBoxText = "Type then press Enter"
            TxtPositionID.XOSQLText = ""
            TxtPositionID.XOTanpaSpasi = True
            TxtPositionID.XOValidasiField = Nothing
            ' 
            ' TxtPosition
            ' 
            TxtPosition.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPosition.Location = New Point(387, 150)
            TxtPosition.Margin = New Padding(6, 5, 6, 5)
            TxtPosition.MaxLength = 255
            TxtPosition.Name = "TxtPosition"
            TxtPosition.ReadOnly = True
            TxtPosition.Size = New Size(341, 39)
            TxtPosition.TabIndex = 203
            TxtPosition.TabStop = False
            TxtPosition.Tag = "txt"
            TxtPosition.XOAutoTrim = False
            TxtPosition.XOHarusDiisi = False
            TxtPosition.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPosition.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPosition.XOHightlightSaatFokus = False
            TxtPosition.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPosition.XOIsBlank = True
            TxtPosition.XOIsSearchBox = False
            TxtPosition.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtPosition.XOPilihSemuaSaatFokus = False
            TxtPosition.XOPwdLengthMin = 8
            TxtPosition.XOPwdStrengthCalculate = False
            TxtPosition.XOPwdStrengthScore = 0
            TxtPosition.XOPwdStrengthText = Nothing
            TxtPosition.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPosition.XOSearchBoxText = "Type then press Enter"
            TxtPosition.XOSQLText = ""
            TxtPosition.XOTanpaSpasi = False
            TxtPosition.XOValidasiField = Nothing
            ' 
            ' TxtGradeID
            ' 
            TxtGradeID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtGradeID.Location = New Point(273, 217)
            TxtGradeID.Margin = New Padding(6, 5, 6, 5)
            TxtGradeID.MaxLength = 255
            TxtGradeID.Name = "TxtGradeID"
            TxtGradeID.ReadOnly = True
            TxtGradeID.Size = New Size(101, 39)
            TxtGradeID.TabIndex = 205
            TxtGradeID.TabStop = False
            TxtGradeID.Tag = "txt"
            TxtGradeID.TextAlign = HorizontalAlignment.Center
            TxtGradeID.XOAutoTrim = False
            TxtGradeID.XOHarusDiisi = False
            TxtGradeID.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtGradeID.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtGradeID.XOHightlightSaatFokus = False
            TxtGradeID.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtGradeID.XOIsBlank = True
            TxtGradeID.XOIsSearchBox = False
            TxtGradeID.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtGradeID.XOPilihSemuaSaatFokus = False
            TxtGradeID.XOPwdLengthMin = 8
            TxtGradeID.XOPwdStrengthCalculate = False
            TxtGradeID.XOPwdStrengthScore = 0
            TxtGradeID.XOPwdStrengthText = Nothing
            TxtGradeID.XORestriction = ControlCodeBase.enuRestriction.None
            TxtGradeID.XOSearchBoxText = "Type then press Enter"
            TxtGradeID.XOSQLText = ""
            TxtGradeID.XOTanpaSpasi = False
            TxtGradeID.XOValidasiField = Nothing
            ' 
            ' BtnBrowsePosition
            ' 
            BtnBrowsePosition.BackColor = Color.RoyalBlue
            BtnBrowsePosition.Cursor = Cursors.Hand
            BtnBrowsePosition.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowsePosition.FlatAppearance.BorderSize = 2
            BtnBrowsePosition.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowsePosition.FlatStyle = FlatStyle.Flat
            BtnBrowsePosition.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowsePosition.ForeColor = Color.White
            BtnBrowsePosition.Location = New Point(740, 150)
            BtnBrowsePosition.Margin = New Padding(6, 5, 6, 5)
            BtnBrowsePosition.Name = "BtnBrowsePosition"
            BtnBrowsePosition.Size = New Size(66, 55)
            BtnBrowsePosition.TabIndex = 204
            BtnBrowsePosition.Text = "..."
            BtnBrowsePosition.UseVisualStyleBackColor = False
            BtnBrowsePosition.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
            BtnBrowsePosition.XOTampilkanFocusBorder = False
            BtnBrowsePosition.XOValidasiSemuaInput = False
            BtnBrowsePosition.XOValidasiSemuaInputTag = Nothing
            ' 
            ' TxTDepartment
            ' 
            TxTDepartment.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxTDepartment.Location = New Point(273, 83)
            TxTDepartment.Margin = New Padding(6, 5, 6, 5)
            TxTDepartment.MaxLength = 255
            TxTDepartment.Name = "TxTDepartment"
            TxTDepartment.ReadOnly = True
            TxTDepartment.Size = New Size(454, 39)
            TxTDepartment.TabIndex = 201
            TxTDepartment.TabStop = False
            TxTDepartment.Tag = "txt"
            TxTDepartment.XOAutoTrim = False
            TxTDepartment.XOHarusDiisi = False
            TxTDepartment.XOHarusDiisiWarnaLatar = Color.LightPink
            TxTDepartment.XOHarusDiisiWarnaLatarDefault = Color.White
            TxTDepartment.XOHightlightSaatFokus = False
            TxTDepartment.XOHightlightSaatFokusWarna = Color.LightYellow
            TxTDepartment.XOIsBlank = True
            TxTDepartment.XOIsSearchBox = False
            TxTDepartment.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxTDepartment.XOPilihSemuaSaatFokus = False
            TxTDepartment.XOPwdLengthMin = 8
            TxTDepartment.XOPwdStrengthCalculate = False
            TxTDepartment.XOPwdStrengthScore = 0
            TxTDepartment.XOPwdStrengthText = Nothing
            TxTDepartment.XORestriction = ControlCodeBase.enuRestriction.None
            TxTDepartment.XOSearchBoxText = "Type then press Enter"
            TxTDepartment.XOSQLText = ""
            TxTDepartment.XOTanpaSpasi = False
            TxTDepartment.XOValidasiField = Nothing
            ' 
            ' TxtCompany
            ' 
            TxtCompany.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtCompany.Location = New Point(273, 15)
            TxtCompany.Margin = New Padding(6, 5, 6, 5)
            TxtCompany.MaxLength = 255
            TxtCompany.Name = "TxtCompany"
            TxtCompany.ReadOnly = True
            TxtCompany.Size = New Size(454, 39)
            TxtCompany.TabIndex = 200
            TxtCompany.TabStop = False
            TxtCompany.Tag = "txt"
            TxtCompany.XOAutoTrim = False
            TxtCompany.XOHarusDiisi = False
            TxtCompany.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtCompany.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtCompany.XOHightlightSaatFokus = False
            TxtCompany.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtCompany.XOIsBlank = True
            TxtCompany.XOIsSearchBox = False
            TxtCompany.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtCompany.XOPilihSemuaSaatFokus = False
            TxtCompany.XOPwdLengthMin = 8
            TxtCompany.XOPwdStrengthCalculate = False
            TxtCompany.XOPwdStrengthScore = 0
            TxtCompany.XOPwdStrengthText = Nothing
            TxtCompany.XORestriction = ControlCodeBase.enuRestriction.None
            TxtCompany.XOSearchBoxText = "Type then press Enter"
            TxtCompany.XOSQLText = ""
            TxtCompany.XOTanpaSpasi = False
            TxtCompany.XOValidasiField = Nothing
            ' 
            ' tpGeneral
            ' 
            tpGeneral.AutoScroll = True
            tpGeneral.Controls.Add(ULbl1)
            tpGeneral.Controls.Add(ULbl5)
            tpGeneral.Controls.Add(ULbl4)
            tpGeneral.Controls.Add(ULbl3)
            tpGeneral.Controls.Add(ULbl16)
            tpGeneral.Controls.Add(ULbl2)
            tpGeneral.Controls.Add(TxtAddress)
            tpGeneral.Controls.Add(TxtBirthPlace)
            tpGeneral.Controls.Add(DtpBirthDate)
            tpGeneral.Controls.Add(TxtPersonalID)
            tpGeneral.Controls.Add(CboGender)
            tpGeneral.Controls.Add(TxtFullName)
            tpGeneral.Location = New Point(4, 41)
            tpGeneral.Margin = New Padding(6, 5, 6, 5)
            tpGeneral.Name = "tpGeneral"
            tpGeneral.Padding = New Padding(6, 5, 6, 5)
            tpGeneral.Size = New Size(822, 661)
            tpGeneral.TabIndex = 0
            tpGeneral.Text = "PERSONAL"
            tpGeneral.UseVisualStyleBackColor = True
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(11, 15)
            ULbl1.Margin = New Padding(7, 10, 7, 10)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 55)
            ULbl1.SLFText = "Personal ID"
            ULbl1.SLFTextAdjuster = True
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl1.TabIndex = 1056
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(11, 352)
            ULbl5.Margin = New Padding(7, 10, 7, 10)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 258)
            ULbl5.SLFText = "Address"
            ULbl5.SLFTextAdjuster = True
            ULbl5.SLFTextBorder = False
            ULbl5.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl5.TabIndex = 1055
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(11, 285)
            ULbl4.Margin = New Padding(7, 10, 7, 10)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 55)
            ULbl4.SLFText = "Gender"
            ULbl4.SLFTextAdjuster = True
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl4.TabIndex = 1054
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(11, 217)
            ULbl3.Margin = New Padding(7, 10, 7, 10)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 55)
            ULbl3.SLFText = "Birth Place"
            ULbl3.SLFTextAdjuster = True
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl3.TabIndex = 1053
            ' 
            ' ULbl16
            ' 
            ULbl16.BackColor = Color.Moccasin
            ULbl16.Location = New Point(11, 150)
            ULbl16.Margin = New Padding(7, 10, 7, 10)
            ULbl16.Name = "ULbl16"
            ULbl16.Size = New Size(250, 55)
            ULbl16.SLFText = "Date of Birth"
            ULbl16.SLFTextAdjuster = True
            ULbl16.SLFTextBorder = False
            ULbl16.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl16.TabIndex = 1052
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(11, 83)
            ULbl2.Margin = New Padding(7, 10, 7, 10)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 55)
            ULbl2.SLFText = "Full Name"
            ULbl2.SLFTextAdjuster = True
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1051
            ' 
            ' TxtAddress
            ' 
            TxtAddress.BackColor = Color.White
            TxtAddress.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtAddress.Location = New Point(273, 352)
            TxtAddress.Margin = New Padding(6, 5, 6, 5)
            TxtAddress.MaxLength = 1024
            TxtAddress.Multiline = True
            TxtAddress.Name = "TxtAddress"
            TxtAddress.ScrollBars = ScrollBars.Both
            TxtAddress.Size = New Size(533, 254)
            TxtAddress.TabIndex = 105
            TxtAddress.Tag = "txt"
            TxtAddress.XOAutoTrim = True
            TxtAddress.XOHarusDiisi = False
            TxtAddress.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtAddress.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtAddress.XOHightlightSaatFokus = False
            TxtAddress.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtAddress.XOIsBlank = False
            TxtAddress.XOIsSearchBox = False
            TxtAddress.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtAddress.XOPilihSemuaSaatFokus = False
            TxtAddress.XOPwdLengthMin = 8
            TxtAddress.XOPwdStrengthCalculate = False
            TxtAddress.XOPwdStrengthScore = 0
            TxtAddress.XOPwdStrengthText = Nothing
            TxtAddress.XORestriction = ControlCodeBase.enuRestriction.None
            TxtAddress.XOSearchBoxText = "Type then press Enter"
            TxtAddress.XOSQLText = ""
            TxtAddress.XOTanpaSpasi = False
            TxtAddress.XOValidasiField = Nothing
            ' 
            ' TxtBirthPlace
            ' 
            TxtBirthPlace.BackColor = Color.White
            TxtBirthPlace.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtBirthPlace.Location = New Point(273, 217)
            TxtBirthPlace.Margin = New Padding(6, 5, 6, 5)
            TxtBirthPlace.MaxLength = 255
            TxtBirthPlace.Name = "TxtBirthPlace"
            TxtBirthPlace.Size = New Size(341, 39)
            TxtBirthPlace.TabIndex = 103
            TxtBirthPlace.Tag = "txt"
            TxtBirthPlace.XOAutoTrim = True
            TxtBirthPlace.XOHarusDiisi = False
            TxtBirthPlace.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtBirthPlace.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtBirthPlace.XOHightlightSaatFokus = False
            TxtBirthPlace.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtBirthPlace.XOIsBlank = False
            TxtBirthPlace.XOIsSearchBox = False
            TxtBirthPlace.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtBirthPlace.XOPilihSemuaSaatFokus = False
            TxtBirthPlace.XOPwdLengthMin = 8
            TxtBirthPlace.XOPwdStrengthCalculate = False
            TxtBirthPlace.XOPwdStrengthScore = 0
            TxtBirthPlace.XOPwdStrengthText = Nothing
            TxtBirthPlace.XORestriction = ControlCodeBase.enuRestriction.None
            TxtBirthPlace.XOSearchBoxText = "Type then press Enter"
            TxtBirthPlace.XOSQLText = ""
            TxtBirthPlace.XOTanpaSpasi = False
            TxtBirthPlace.XOValidasiField = Nothing
            ' 
            ' DtpBirthDate
            ' 
            DtpBirthDate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            DtpBirthDate.Location = New Point(273, 150)
            DtpBirthDate.Margin = New Padding(6, 5, 6, 5)
            DtpBirthDate.MaxDate = New Date(2029, 4, 3, 0, 0, 0, 0)
            DtpBirthDate.MinDate = New Date(1919, 4, 3, 0, 0, 0, 0)
            DtpBirthDate.Name = "DtpBirthDate"
            DtpBirthDate.Size = New Size(393, 39)
            DtpBirthDate.TabIndex = 102
            DtpBirthDate.XOResetOnDisabled = False
            ' 
            ' TxtPersonalID
            ' 
            TxtPersonalID.BackColor = Color.LightPink
            TxtPersonalID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPersonalID.Location = New Point(273, 15)
            TxtPersonalID.Margin = New Padding(6, 5, 6, 5)
            TxtPersonalID.MaxLength = 16
            TxtPersonalID.Name = "TxtPersonalID"
            TxtPersonalID.Size = New Size(341, 39)
            TxtPersonalID.TabIndex = 100
            TxtPersonalID.Tag = "txt"
            TxtPersonalID.XOAutoTrim = True
            TxtPersonalID.XOHarusDiisi = True
            TxtPersonalID.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPersonalID.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPersonalID.XOHightlightSaatFokus = True
            TxtPersonalID.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPersonalID.XOIsBlank = True
            TxtPersonalID.XOIsSearchBox = False
            TxtPersonalID.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtPersonalID.XOPilihSemuaSaatFokus = False
            TxtPersonalID.XOPwdLengthMin = 8
            TxtPersonalID.XOPwdStrengthCalculate = False
            TxtPersonalID.XOPwdStrengthScore = 0
            TxtPersonalID.XOPwdStrengthText = Nothing
            TxtPersonalID.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPersonalID.XOSearchBoxText = "Type then press Enter"
            TxtPersonalID.XOSQLText = ""
            TxtPersonalID.XOTanpaSpasi = False
            TxtPersonalID.XOValidasiField = Nothing
            ' 
            ' CboGender
            ' 
            CboGender.DropDownStyle = ComboBoxStyle.DropDownList
            CboGender.FlatStyle = FlatStyle.Flat
            CboGender.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboGender.FormattingEnabled = True
            CboGender.Items.AddRange(New Object() {"FEMALE", "MALE"})
            CboGender.Location = New Point(273, 285)
            CboGender.Margin = New Padding(6, 5, 6, 5)
            CboGender.Name = "CboGender"
            CboGender.Size = New Size(225, 40)
            CboGender.TabIndex = 104
            ' 
            ' TxtFullName
            ' 
            TxtFullName.BackColor = Color.LightPink
            TxtFullName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtFullName.Location = New Point(273, 83)
            TxtFullName.Margin = New Padding(6, 5, 6, 5)
            TxtFullName.MaxLength = 255
            TxtFullName.Name = "TxtFullName"
            TxtFullName.Size = New Size(454, 39)
            TxtFullName.TabIndex = 101
            TxtFullName.Tag = "txt"
            TxtFullName.XOAutoTrim = True
            TxtFullName.XOHarusDiisi = True
            TxtFullName.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtFullName.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtFullName.XOHightlightSaatFokus = True
            TxtFullName.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtFullName.XOIsBlank = False
            TxtFullName.XOIsSearchBox = False
            TxtFullName.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtFullName.XOPilihSemuaSaatFokus = False
            TxtFullName.XOPwdLengthMin = 8
            TxtFullName.XOPwdStrengthCalculate = False
            TxtFullName.XOPwdStrengthScore = 0
            TxtFullName.XOPwdStrengthText = Nothing
            TxtFullName.XORestriction = ControlCodeBase.enuRestriction.None
            TxtFullName.XOSearchBoxText = "Type then press Enter"
            TxtFullName.XOSQLText = ""
            TxtFullName.XOTanpaSpasi = False
            TxtFullName.XOValidasiField = Nothing
            ' 
            ' TbctlEmployee
            ' 
            TbctlEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            TbctlEmployee.Controls.Add(tpGeneral)
            TbctlEmployee.Controls.Add(tpWorkIn)
            TbctlEmployee.Controls.Add(tpPermissions)
            TbctlEmployee.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlEmployee.Location = New Point(20, 25)
            TbctlEmployee.Margin = New Padding(6, 5, 6, 5)
            TbctlEmployee.Name = "TbctlEmployee"
            TbctlEmployee.SelectedIndex = 0
            TbctlEmployee.Size = New Size(830, 706)
            TbctlEmployee.TabIndex = 1039
            ' 
            ' ULbl8
            ' 
            ULbl8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ULbl8.BackColor = Color.Moccasin
            ULbl8.Location = New Point(887, 83)
            ULbl8.Margin = New Padding(7, 5, 7, 5)
            ULbl8.Name = "ULbl8"
            ULbl8.Size = New Size(250, 55)
            ULbl8.SLFText = "Photo"
            ULbl8.SLFTextAdjuster = False
            ULbl8.SLFTextBorder = False
            ULbl8.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl8.TabIndex = 1041
            ' 
            ' FRMeplsEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1181, 965)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMeplsEditor"
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(pctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
            CType(pcbxFrame, ComponentModel.ISupportInitialize).EndInit()
            tpPermissions.ResumeLayout(False)
            tpPermissions.PerformLayout()
            GbxModulesRoles.ResumeLayout(False)
            CType(DgnModulesRoles, ComponentModel.ISupportInitialize).EndInit()
            GbxCredetials.ResumeLayout(False)
            GbxCredetials.PerformLayout()
            tpWorkIn.ResumeLayout(False)
            tpWorkIn.PerformLayout()
            tpGeneral.ResumeLayout(False)
            tpGeneral.PerformLayout()
            TbctlEmployee.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents BtnCancel As CMCv.UI.Control.btn
        Friend WithEvents BtnSave As CMCv.UI.Control.btn
        Friend WithEvents ChkAddNew As CMCv.UI.Control.chk
        Friend WithEvents BtnBrowsePhoto As CMCv.UI.Control.btn
        Friend WithEvents pctbxPhoto As CMCv.UI.Control.pctbx
        Friend WithEvents OfdPhoto As OpenFileDialog
        Friend WithEvents pcbxFrame As CMCv.UI.Control.pctbx
        Friend WithEvents TbctlEmployee As CMCv.UI.Control.tbctl
        Friend WithEvents tpGeneral As TabPage
        Friend WithEvents TxtPersonalID As CMCv.UI.Control.txt
        Friend WithEvents CboGender As CMCv.UI.Control.cbo
        Friend WithEvents TxtFullName As CMCv.UI.Control.txt
        Friend WithEvents tpWorkIn As TabPage
        Friend WithEvents TxtEmployeeNickname As CMCv.UI.Control.txt
        Friend WithEvents TxtContractType As CMCv.UI.Control.txt
        Friend WithEvents TxtContractTypeID As CMCv.UI.Control.txt
        Friend WithEvents TxtEmployeeNumber As CMCv.UI.Control.txt
        Friend WithEvents TxtGrade As CMCv.UI.Control.txt
        Friend WithEvents TxtPositionID As CMCv.UI.Control.txt
        Friend WithEvents TxtPosition As CMCv.UI.Control.txt
        Friend WithEvents TxtGradeID As CMCv.UI.Control.txt
        Friend WithEvents BtnBrowsePosition As CMCv.UI.Control.btn
        Friend WithEvents TxTDepartment As CMCv.UI.Control.txt
        Friend WithEvents TxtCompany As CMCv.UI.Control.txt
        Friend WithEvents tpPermissions As TabPage
        Friend WithEvents GbxModulesRoles As CMCv.UI.Control.gbx
        Friend WithEvents DgnModulesRoles As CMCv.UI.Control.dgn
        Friend WithEvents DtpBirthDate As CMCv.UI.Control.dtp
        Friend WithEvents ChkActiveEmployee As CMCv.UI.Control.chk
        Friend WithEvents TxtBirthPlace As CMCv.UI.Control.txt
        Friend WithEvents TxtAddress As CMCv.UI.Control.txt
        Friend WithEvents GbxCredetials As CMCv.UI.Control.gbx
        Friend WithEvents TxtLogin As CMCv.UI.Control.txt
        Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
        Friend WithEvents module_code As DataGridViewTextBoxColumn
        Friend WithEvents useraccess_view As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_add As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_edit As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_delete As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_reports As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_id As DataGridViewTextBoxColumn
        Friend WithEvents module_id As DataGridViewTextBoxColumn
        Friend WithEvents ULbl8 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl16 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl14 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl13 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl12 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl11 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl10 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl9 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
    End Class
End Namespace