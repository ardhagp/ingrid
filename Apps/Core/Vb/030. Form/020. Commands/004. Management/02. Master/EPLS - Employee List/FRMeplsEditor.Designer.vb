Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMeplsEditor
        Inherits CMCv.UI.Canvas.FRMstandardFooter

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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            pctbxPhoto = New CMCv.UI.Control.Pbx(components)
            BtnBrowsePhoto = New CMCv.UI.Control.Btn(components)
            OfdPhoto = New OpenFileDialog()
            pcbxFrame = New CMCv.UI.Control.Pbx(components)
            tpPermissions = New TabPage()
            GbxModulesRoles = New CMCv.UI.Control.Gbx(components)
            DgnModulesRoles = New CMCv.UI.Control.Dgn(components)
            modulegroup_name = New DataGridViewTextBoxColumn()
            module_code = New DataGridViewTextBoxColumn()
            useraccess_view = New DataGridViewCheckBoxColumn()
            useraccess_add = New DataGridViewCheckBoxColumn()
            useraccess_edit = New DataGridViewCheckBoxColumn()
            useraccess_delete = New DataGridViewCheckBoxColumn()
            useraccess_reports = New DataGridViewCheckBoxColumn()
            useraccess_id = New DataGridViewTextBoxColumn()
            module_id = New DataGridViewTextBoxColumn()
            GbxCredetials = New CMCv.UI.Control.Gbx(components)
            ULbl7 = New CMCv.UI.Control.ULbl()
            TxtLogin = New CMCv.UI.Control.Txt(components)
            tpEmployment = New TabPage()
            BtnBrowseEmploymentType = New CMCv.UI.Control.Btn(components)
            ULbl14 = New CMCv.UI.Control.ULbl()
            ULbl12 = New CMCv.UI.Control.ULbl()
            ULbl11 = New CMCv.UI.Control.ULbl()
            ULbl10 = New CMCv.UI.Control.ULbl()
            ULbl9 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            ChkActiveEmployee = New CMCv.UI.Control.Chk(components)
            TxtEmployeeNickname = New CMCv.UI.Control.Txt(components)
            TxtEmployeeNumber = New CMCv.UI.Control.Txt(components)
            TxtEmploymentType = New CMCv.UI.Control.Txt(components)
            TxtPosition = New CMCv.UI.Control.Txt(components)
            BtnBrowsePosition = New CMCv.UI.Control.Btn(components)
            TxTDepartment = New CMCv.UI.Control.Txt(components)
            TxtCompany = New CMCv.UI.Control.Txt(components)
            tpGeneral = New TabPage()
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl16 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            TxtAddress = New CMCv.UI.Control.Txt(components)
            TxtBirthPlace = New CMCv.UI.Control.Txt(components)
            DtpBirthDate = New CMCv.UI.Control.Dtp(components)
            TxtPersonalID = New CMCv.UI.Control.Txt(components)
            CboGender = New CMCv.UI.Control.Cbo(components)
            TxtFullName = New CMCv.UI.Control.Txt(components)
            TbctlEmployee = New CMCv.UI.Control.Tbx(components)
            ULbl8 = New CMCv.UI.Control.ULbl()
            BtnRemovePhoto = New CMCv.UI.Control.Btn(components)
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
            tpEmployment.SuspendLayout()
            tpGeneral.SuspendLayout()
            TbctlEmployee.SuspendLayout()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Location = New Point(0, 736)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(1181, 97)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(1181, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(BtnRemovePhoto)
            SLFPanel.Controls.Add(ULbl8)
            SLFPanel.Controls.Add(TbctlEmployee)
            SLFPanel.Controls.Add(BtnBrowsePhoto)
            SLFPanel.Controls.Add(pctbxPhoto)
            SLFPanel.Controls.Add(pcbxFrame)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(1181, 833)
            SLFPanel.Controls.SetChildIndex(pcbxFrame, 0)
            SLFPanel.Controls.SetChildIndex(pctbxPhoto, 0)
            SLFPanel.Controls.SetChildIndex(BtnBrowsePhoto, 0)
            SLFPanel.Controls.SetChildIndex(TbctlEmployee, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(ULbl8, 0)
            SLFPanel.Controls.SetChildIndex(BtnRemovePhoto, 0)
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F)
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
            BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(817, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 801
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
            BtnSave.XOShowBorderOnFocus = False
            BtnSave.XOValidateAllInput = False
            BtnSave.XOValidateAllInputTag = Nothing
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
            BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(994, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 802
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
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
            pctbxPhoto.XOBorderColor = Color.Transparent
            pctbxPhoto.XOShowBorder = False
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
            BtnBrowsePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnBrowsePhoto.ForeColor = Color.White
            BtnBrowsePhoto.Location = New Point(933, 428)
            BtnBrowsePhoto.Name = "BtnBrowsePhoto"
            BtnBrowsePhoto.Size = New Size(179, 80)
            BtnBrowsePhoto.TabIndex = 800
            BtnBrowsePhoto.Text = "Browse"
            BtnBrowsePhoto.UseVisualStyleBackColor = False
            BtnBrowsePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Default
            BtnBrowsePhoto.XOShowBorderOnFocus = False
            BtnBrowsePhoto.XOValidateAllInput = False
            BtnBrowsePhoto.XOValidateAllInputTag = Nothing
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
            pcbxFrame.XOBorderColor = Color.DodgerBlue
            pcbxFrame.XOShowBorder = False
            ' 
            ' tpPermissions
            ' 
            tpPermissions.Controls.Add(GbxModulesRoles)
            tpPermissions.Controls.Add(GbxCredetials)
            tpPermissions.Location = New Point(4, 41)
            tpPermissions.Margin = New Padding(6, 5, 6, 5)
            tpPermissions.Name = "tpPermissions"
            tpPermissions.Padding = New Padding(6, 5, 6, 5)
            tpPermissions.Size = New Size(822, 655)
            tpPermissions.TabIndex = 1
            tpPermissions.Text = "PERMISSIONS"
            tpPermissions.UseVisualStyleBackColor = True
            ' 
            ' GbxModulesRoles
            ' 
            GbxModulesRoles.AutoSize = True
            GbxModulesRoles.Controls.Add(DgnModulesRoles)
            GbxModulesRoles.Dock = DockStyle.Fill
            GbxModulesRoles.Font = New Font("Segoe UI", 12F)
            GbxModulesRoles.Location = New Point(6, 128)
            GbxModulesRoles.Margin = New Padding(6, 5, 6, 5)
            GbxModulesRoles.Name = "GbxModulesRoles"
            GbxModulesRoles.Padding = New Padding(6, 5, 6, 5)
            GbxModulesRoles.Size = New Size(810, 522)
            GbxModulesRoles.TabIndex = 0
            GbxModulesRoles.TabStop = False
            GbxModulesRoles.Text = "Modules or roles"
            ' 
            ' DgnModulesRoles
            ' 
            DgnModulesRoles.AllowUserToAddRows = False
            DgnModulesRoles.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(244), CByte(190), CByte(100))
            DgnModulesRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnModulesRoles.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnModulesRoles.BorderStyle = BorderStyle.None
            DgnModulesRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnModulesRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnModulesRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnModulesRoles.ColumnHeadersHeight = 43
            DgnModulesRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnModulesRoles.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports, useraccess_id, module_id})
            DgnModulesRoles.Dock = DockStyle.Fill
            DgnModulesRoles.EnableHeadersVisualStyles = False
            DgnModulesRoles.Font = New Font("Verdana", 8F)
            DgnModulesRoles.Location = New Point(6, 37)
            DgnModulesRoles.Margin = New Padding(6, 5, 6, 5)
            DgnModulesRoles.Name = "DgnModulesRoles"
            DgnModulesRoles.ReadOnly = True
            DgnModulesRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnModulesRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnModulesRoles.RowHeadersWidth = 62
            DgnModulesRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnModulesRoles.Size = New Size(798, 480)
            DgnModulesRoles.StandardTab = True
            DgnModulesRoles.TabIndex = 0
            DgnModulesRoles.XOIsGroupFirstRow = True
            DgnModulesRoles.XOIsShowRowNumber = True
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
            GbxCredetials.Font = New Font("Segoe UI", 12F)
            GbxCredetials.Location = New Point(6, 5)
            GbxCredetials.Margin = New Padding(6, 5, 6, 5)
            GbxCredetials.Name = "GbxCredetials"
            GbxCredetials.Padding = New Padding(6, 5, 6, 5)
            GbxCredetials.Size = New Size(810, 123)
            GbxCredetials.TabIndex = 3
            GbxCredetials.TabStop = False
            GbxCredetials.Text = "Credentials"
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.Moccasin
            ULbl7.Location = New Point(11, 54)
            ULbl7.Margin = New Padding(7, 10, 7, 10)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(250, 39)
            ULbl7.TabIndex = 301
            ULbl7.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl7.XOText = "Login"
            ULbl7.XOTextAdjuster = True
            ULbl7.XOTextBorder = False
            ' 
            ' TxtLogin
            ' 
            TxtLogin.BackColor = Color.White
            TxtLogin.Font = New Font("Segoe UI", 12F)
            TxtLogin.Location = New Point(273, 54)
            TxtLogin.Margin = New Padding(6, 5, 6, 5)
            TxtLogin.MaxLength = 255
            TxtLogin.Name = "TxtLogin"
            TxtLogin.ReadOnly = True
            TxtLogin.Size = New Size(341, 39)
            TxtLogin.TabIndex = 300
            TxtLogin.Tag = "txt"
            TxtLogin.TextAlign = HorizontalAlignment.Center
            TxtLogin.XOAutoTrim = False
            TxtLogin.XOHighlightColor = Color.LightYellow
            TxtLogin.XOHighlightOnFocus = False
            TxtLogin.XOIsBlank = False
            TxtLogin.XOIsMandatory = False
            TxtLogin.XOIsPlaceholder = False
            TxtLogin.XOIsReplaceEmptyString = False
            TxtLogin.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtLogin.XOMandatoryBgColor = Color.LightPink
            TxtLogin.XOMandatoryBgColorDefault = Color.White
            TxtLogin.XOMandatoryMessage = Nothing
            TxtLogin.XOPasswordLengthMin = 8
            TxtLogin.XOPasswordStrengthCalc = False
            TxtLogin.XOPasswordStrengthScore = 0
            TxtLogin.XOPasswordStrengthText = Nothing
            TxtLogin.XOPlaceholderText = "Type then press Enter"
            TxtLogin.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtLogin.XOSelectOnFocus = False
            TxtLogin.XOSqlText = ""
            ' 
            ' tpEmployment
            ' 
            tpEmployment.Controls.Add(BtnBrowseEmploymentType)
            tpEmployment.Controls.Add(ULbl14)
            tpEmployment.Controls.Add(ULbl12)
            tpEmployment.Controls.Add(ULbl11)
            tpEmployment.Controls.Add(ULbl10)
            tpEmployment.Controls.Add(ULbl9)
            tpEmployment.Controls.Add(ULbl6)
            tpEmployment.Controls.Add(ChkActiveEmployee)
            tpEmployment.Controls.Add(TxtEmployeeNickname)
            tpEmployment.Controls.Add(TxtEmployeeNumber)
            tpEmployment.Controls.Add(TxtEmploymentType)
            tpEmployment.Controls.Add(TxtPosition)
            tpEmployment.Controls.Add(BtnBrowsePosition)
            tpEmployment.Controls.Add(TxTDepartment)
            tpEmployment.Controls.Add(TxtCompany)
            tpEmployment.Location = New Point(4, 41)
            tpEmployment.Margin = New Padding(6, 5, 6, 5)
            tpEmployment.Name = "tpEmployment"
            tpEmployment.Size = New Size(822, 655)
            tpEmployment.TabIndex = 2
            tpEmployment.Text = "EMPLOYMENT"
            tpEmployment.UseVisualStyleBackColor = True
            ' 
            ' BtnBrowseEmploymentType
            ' 
            BtnBrowseEmploymentType.BackColor = Color.RoyalBlue
            BtnBrowseEmploymentType.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowseEmploymentType.FlatAppearance.BorderSize = 2
            BtnBrowseEmploymentType.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowseEmploymentType.FlatStyle = FlatStyle.Flat
            BtnBrowseEmploymentType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnBrowseEmploymentType.ForeColor = Color.White
            BtnBrowseEmploymentType.Location = New Point(740, 217)
            BtnBrowseEmploymentType.Name = "BtnBrowseEmploymentType"
            BtnBrowseEmploymentType.Size = New Size(66, 39)
            BtnBrowseEmploymentType.TabIndex = 1062
            BtnBrowseEmploymentType.Text = "..."
            BtnBrowseEmploymentType.UseVisualStyleBackColor = False
            BtnBrowseEmploymentType.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Default
            BtnBrowseEmploymentType.XOShowBorderOnFocus = False
            BtnBrowseEmploymentType.XOValidateAllInput = False
            BtnBrowseEmploymentType.XOValidateAllInputTag = Nothing
            ' 
            ' ULbl14
            ' 
            ULbl14.BackColor = Color.Moccasin
            ULbl14.Location = New Point(14, 353)
            ULbl14.Margin = New Padding(12, 17, 12, 17)
            ULbl14.Name = "ULbl14"
            ULbl14.Size = New Size(250, 39)
            ULbl14.TabIndex = 1061
            ULbl14.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl14.XOText = "Initial"
            ULbl14.XOTextAdjuster = True
            ULbl14.XOTextBorder = False
            ' 
            ' ULbl12
            ' 
            ULbl12.BackColor = Color.MistyRose
            ULbl12.Location = New Point(14, 285)
            ULbl12.Margin = New Padding(12, 17, 12, 17)
            ULbl12.Name = "ULbl12"
            ULbl12.Size = New Size(250, 39)
            ULbl12.TabIndex = 1059
            ULbl12.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl12.XOText = "Emp. Code"
            ULbl12.XOTextAdjuster = True
            ULbl12.XOTextBorder = False
            ' 
            ' ULbl11
            ' 
            ULbl11.BackColor = Color.MistyRose
            ULbl11.Location = New Point(14, 217)
            ULbl11.Margin = New Padding(12, 17, 12, 17)
            ULbl11.Name = "ULbl11"
            ULbl11.Size = New Size(250, 39)
            ULbl11.TabIndex = 1058
            ULbl11.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl11.XOText = "Emp. Type"
            ULbl11.XOTextAdjuster = True
            ULbl11.XOTextBorder = False
            ' 
            ' ULbl10
            ' 
            ULbl10.BackColor = Color.MistyRose
            ULbl10.Location = New Point(14, 150)
            ULbl10.Margin = New Padding(12, 17, 12, 17)
            ULbl10.Name = "ULbl10"
            ULbl10.Size = New Size(250, 39)
            ULbl10.TabIndex = 1057
            ULbl10.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl10.XOText = "Position"
            ULbl10.XOTextAdjuster = True
            ULbl10.XOTextBorder = False
            ' 
            ' ULbl9
            ' 
            ULbl9.BackColor = Color.MistyRose
            ULbl9.Location = New Point(14, 83)
            ULbl9.Margin = New Padding(12, 17, 12, 17)
            ULbl9.Name = "ULbl9"
            ULbl9.Size = New Size(250, 39)
            ULbl9.TabIndex = 1056
            ULbl9.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl9.XOText = "Department"
            ULbl9.XOTextAdjuster = True
            ULbl9.XOTextBorder = False
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.MistyRose
            ULbl6.Location = New Point(14, 15)
            ULbl6.Margin = New Padding(12, 17, 12, 17)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 39)
            ULbl6.TabIndex = 1055
            ULbl6.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl6.XOText = "Company"
            ULbl6.XOTextAdjuster = True
            ULbl6.XOTextBorder = False
            ' 
            ' ChkActiveEmployee
            ' 
            ChkActiveEmployee.AutoSize = True
            ChkActiveEmployee.BackColor = Color.Transparent
            ChkActiveEmployee.FlatStyle = FlatStyle.Flat
            ChkActiveEmployee.Font = New Font("Segoe UI", 12F)
            ChkActiveEmployee.Location = New Point(273, 421)
            ChkActiveEmployee.Margin = New Padding(6, 5, 6, 5)
            ChkActiveEmployee.Name = "ChkActiveEmployee"
            ChkActiveEmployee.Size = New Size(213, 36)
            ChkActiveEmployee.TabIndex = 211
            ChkActiveEmployee.Text = "Active employee"
            ChkActiveEmployee.UseVisualStyleBackColor = False
            ' 
            ' TxtEmployeeNickname
            ' 
            TxtEmployeeNickname.Font = New Font("Segoe UI", 12F)
            TxtEmployeeNickname.Location = New Point(273, 353)
            TxtEmployeeNickname.Margin = New Padding(6, 5, 6, 5)
            TxtEmployeeNickname.MaxLength = 255
            TxtEmployeeNickname.Name = "TxtEmployeeNickname"
            TxtEmployeeNickname.Size = New Size(101, 39)
            TxtEmployeeNickname.TabIndex = 210
            TxtEmployeeNickname.Tag = "txt"
            TxtEmployeeNickname.TextAlign = HorizontalAlignment.Center
            TxtEmployeeNickname.XOAutoTrim = True
            TxtEmployeeNickname.XOHighlightColor = Color.LightYellow
            TxtEmployeeNickname.XOHighlightOnFocus = False
            TxtEmployeeNickname.XOIsBlank = True
            TxtEmployeeNickname.XOIsMandatory = False
            TxtEmployeeNickname.XOIsPlaceholder = False
            TxtEmployeeNickname.XOIsReplaceEmptyString = False
            TxtEmployeeNickname.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtEmployeeNickname.XOMandatoryBgColor = Color.LightPink
            TxtEmployeeNickname.XOMandatoryBgColorDefault = Color.White
            TxtEmployeeNickname.XOMandatoryMessage = Nothing
            TxtEmployeeNickname.XOPasswordLengthMin = 8
            TxtEmployeeNickname.XOPasswordStrengthCalc = False
            TxtEmployeeNickname.XOPasswordStrengthScore = 0
            TxtEmployeeNickname.XOPasswordStrengthText = Nothing
            TxtEmployeeNickname.XOPlaceholderText = "Type then press Enter"
            TxtEmployeeNickname.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtEmployeeNickname.XOSelectOnFocus = False
            TxtEmployeeNickname.XOSqlText = ""
            ' 
            ' TxtEmployeeNumber
            ' 
            TxtEmployeeNumber.Font = New Font("Segoe UI", 12F)
            TxtEmployeeNumber.Location = New Point(273, 285)
            TxtEmployeeNumber.Margin = New Padding(6, 5, 6, 5)
            TxtEmployeeNumber.MaxLength = 255
            TxtEmployeeNumber.Name = "TxtEmployeeNumber"
            TxtEmployeeNumber.Size = New Size(281, 39)
            TxtEmployeeNumber.TabIndex = 207
            TxtEmployeeNumber.Tag = "txt"
            TxtEmployeeNumber.TextAlign = HorizontalAlignment.Center
            TxtEmployeeNumber.XOAutoTrim = True
            TxtEmployeeNumber.XOHighlightColor = Color.LightYellow
            TxtEmployeeNumber.XOHighlightOnFocus = True
            TxtEmployeeNumber.XOIsBlank = True
            TxtEmployeeNumber.XOIsMandatory = True
            TxtEmployeeNumber.XOIsPlaceholder = False
            TxtEmployeeNumber.XOIsReplaceEmptyString = False
            TxtEmployeeNumber.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtEmployeeNumber.XOMandatoryBgColor = Color.LightPink
            TxtEmployeeNumber.XOMandatoryBgColorDefault = Color.White
            TxtEmployeeNumber.XOMandatoryMessage = Nothing
            TxtEmployeeNumber.XOPasswordLengthMin = 8
            TxtEmployeeNumber.XOPasswordStrengthCalc = False
            TxtEmployeeNumber.XOPasswordStrengthScore = 0
            TxtEmployeeNumber.XOPasswordStrengthText = Nothing
            TxtEmployeeNumber.XOPlaceholderText = "Type then press Enter"
            TxtEmployeeNumber.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberSymbolNoSpace
            TxtEmployeeNumber.XOSelectOnFocus = False
            TxtEmployeeNumber.XOSqlText = ""
            ' 
            ' TxtEmploymentType
            ' 
            TxtEmploymentType.Font = New Font("Segoe UI", 12F)
            TxtEmploymentType.Location = New Point(273, 217)
            TxtEmploymentType.Margin = New Padding(6, 5, 6, 5)
            TxtEmploymentType.MaxLength = 255
            TxtEmploymentType.Name = "TxtEmploymentType"
            TxtEmploymentType.ReadOnly = True
            TxtEmploymentType.Size = New Size(455, 39)
            TxtEmploymentType.TabIndex = 206
            TxtEmploymentType.TabStop = False
            TxtEmploymentType.Tag = "txt"
            TxtEmploymentType.XOAutoTrim = False
            TxtEmploymentType.XOHighlightColor = Color.LightYellow
            TxtEmploymentType.XOHighlightOnFocus = False
            TxtEmploymentType.XOIsBlank = True
            TxtEmploymentType.XOIsMandatory = False
            TxtEmploymentType.XOIsPlaceholder = False
            TxtEmploymentType.XOIsReplaceEmptyString = False
            TxtEmploymentType.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtEmploymentType.XOMandatoryBgColor = Color.LightPink
            TxtEmploymentType.XOMandatoryBgColorDefault = Color.White
            TxtEmploymentType.XOMandatoryMessage = Nothing
            TxtEmploymentType.XOPasswordLengthMin = 8
            TxtEmploymentType.XOPasswordStrengthCalc = False
            TxtEmploymentType.XOPasswordStrengthScore = 0
            TxtEmploymentType.XOPasswordStrengthText = Nothing
            TxtEmploymentType.XOPlaceholderText = "Type then press Enter"
            TxtEmploymentType.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtEmploymentType.XOSelectOnFocus = False
            TxtEmploymentType.XOSqlText = ""
            ' 
            ' TxtPosition
            ' 
            TxtPosition.Font = New Font("Segoe UI", 12F)
            TxtPosition.Location = New Point(273, 150)
            TxtPosition.Margin = New Padding(6, 5, 6, 5)
            TxtPosition.MaxLength = 255
            TxtPosition.Name = "TxtPosition"
            TxtPosition.ReadOnly = True
            TxtPosition.Size = New Size(455, 39)
            TxtPosition.TabIndex = 203
            TxtPosition.TabStop = False
            TxtPosition.Tag = "txt"
            TxtPosition.XOAutoTrim = False
            TxtPosition.XOHighlightColor = Color.LightYellow
            TxtPosition.XOHighlightOnFocus = False
            TxtPosition.XOIsBlank = True
            TxtPosition.XOIsMandatory = False
            TxtPosition.XOIsPlaceholder = False
            TxtPosition.XOIsReplaceEmptyString = False
            TxtPosition.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtPosition.XOMandatoryBgColor = Color.LightPink
            TxtPosition.XOMandatoryBgColorDefault = Color.White
            TxtPosition.XOMandatoryMessage = Nothing
            TxtPosition.XOPasswordLengthMin = 8
            TxtPosition.XOPasswordStrengthCalc = False
            TxtPosition.XOPasswordStrengthScore = 0
            TxtPosition.XOPasswordStrengthText = Nothing
            TxtPosition.XOPlaceholderText = "Type then press Enter"
            TxtPosition.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtPosition.XOSelectOnFocus = False
            TxtPosition.XOSqlText = ""
            ' 
            ' BtnBrowsePosition
            ' 
            BtnBrowsePosition.BackColor = Color.RoyalBlue
            BtnBrowsePosition.Cursor = Cursors.Hand
            BtnBrowsePosition.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowsePosition.FlatAppearance.BorderSize = 2
            BtnBrowsePosition.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowsePosition.FlatStyle = FlatStyle.Flat
            BtnBrowsePosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnBrowsePosition.ForeColor = Color.White
            BtnBrowsePosition.Location = New Point(740, 150)
            BtnBrowsePosition.Name = "BtnBrowsePosition"
            BtnBrowsePosition.Size = New Size(66, 39)
            BtnBrowsePosition.TabIndex = 204
            BtnBrowsePosition.Text = "..."
            BtnBrowsePosition.UseVisualStyleBackColor = False
            BtnBrowsePosition.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Default
            BtnBrowsePosition.XOShowBorderOnFocus = False
            BtnBrowsePosition.XOValidateAllInput = False
            BtnBrowsePosition.XOValidateAllInputTag = Nothing
            ' 
            ' TxTDepartment
            ' 
            TxTDepartment.Font = New Font("Segoe UI", 12F)
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
            TxTDepartment.XOHighlightColor = Color.LightYellow
            TxTDepartment.XOHighlightOnFocus = False
            TxTDepartment.XOIsBlank = True
            TxTDepartment.XOIsMandatory = False
            TxTDepartment.XOIsPlaceholder = False
            TxTDepartment.XOIsReplaceEmptyString = False
            TxTDepartment.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxTDepartment.XOMandatoryBgColor = Color.LightPink
            TxTDepartment.XOMandatoryBgColorDefault = Color.White
            TxTDepartment.XOMandatoryMessage = Nothing
            TxTDepartment.XOPasswordLengthMin = 8
            TxTDepartment.XOPasswordStrengthCalc = False
            TxTDepartment.XOPasswordStrengthScore = 0
            TxTDepartment.XOPasswordStrengthText = Nothing
            TxTDepartment.XOPlaceholderText = "Type then press Enter"
            TxTDepartment.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxTDepartment.XOSelectOnFocus = False
            TxTDepartment.XOSqlText = ""
            ' 
            ' TxtCompany
            ' 
            TxtCompany.Font = New Font("Segoe UI", 12F)
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
            TxtCompany.XOHighlightColor = Color.LightYellow
            TxtCompany.XOHighlightOnFocus = False
            TxtCompany.XOIsBlank = True
            TxtCompany.XOIsMandatory = False
            TxtCompany.XOIsPlaceholder = False
            TxtCompany.XOIsReplaceEmptyString = False
            TxtCompany.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtCompany.XOMandatoryBgColor = Color.LightPink
            TxtCompany.XOMandatoryBgColorDefault = Color.White
            TxtCompany.XOMandatoryMessage = Nothing
            TxtCompany.XOPasswordLengthMin = 8
            TxtCompany.XOPasswordStrengthCalc = False
            TxtCompany.XOPasswordStrengthScore = 0
            TxtCompany.XOPasswordStrengthText = Nothing
            TxtCompany.XOPlaceholderText = "Type then press Enter"
            TxtCompany.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtCompany.XOSelectOnFocus = False
            TxtCompany.XOSqlText = ""
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
            tpGeneral.Size = New Size(822, 655)
            tpGeneral.TabIndex = 0
            tpGeneral.Text = "PERSONAL"
            tpGeneral.UseVisualStyleBackColor = True
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.MistyRose
            ULbl1.Location = New Point(14, 15)
            ULbl1.Margin = New Padding(9, 13, 9, 13)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 39)
            ULbl1.TabIndex = 1056
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl1.XOText = "National ID Card"
            ULbl1.XOTextAdjuster = True
            ULbl1.XOTextBorder = False
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(14, 352)
            ULbl5.Margin = New Padding(9, 13, 9, 13)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 254)
            ULbl5.TabIndex = 1055
            ULbl5.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.XOText = "Address"
            ULbl5.XOTextAdjuster = True
            ULbl5.XOTextBorder = False
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.MistyRose
            ULbl4.Location = New Point(14, 285)
            ULbl4.Margin = New Padding(9, 13, 9, 13)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 39)
            ULbl4.TabIndex = 1054
            ULbl4.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl4.XOText = "Gender"
            ULbl4.XOTextAdjuster = True
            ULbl4.XOTextBorder = False
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.MistyRose
            ULbl3.Location = New Point(14, 217)
            ULbl3.Margin = New Padding(9, 13, 9, 13)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 39)
            ULbl3.TabIndex = 1053
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl3.XOText = "Birth Place"
            ULbl3.XOTextAdjuster = True
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl16
            ' 
            ULbl16.BackColor = Color.MistyRose
            ULbl16.Location = New Point(14, 150)
            ULbl16.Margin = New Padding(9, 13, 9, 13)
            ULbl16.Name = "ULbl16"
            ULbl16.Size = New Size(250, 39)
            ULbl16.TabIndex = 1052
            ULbl16.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl16.XOText = "Date of Birth"
            ULbl16.XOTextAdjuster = True
            ULbl16.XOTextBorder = False
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.MistyRose
            ULbl2.Location = New Point(14, 83)
            ULbl2.Margin = New Padding(9, 13, 9, 13)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 39)
            ULbl2.TabIndex = 1051
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl2.XOText = "Full Name"
            ULbl2.XOTextAdjuster = True
            ULbl2.XOTextBorder = False
            ' 
            ' TxtAddress
            ' 
            TxtAddress.BackColor = Color.White
            TxtAddress.Font = New Font("Segoe UI", 12F)
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
            TxtAddress.XOHighlightColor = Color.LightYellow
            TxtAddress.XOHighlightOnFocus = False
            TxtAddress.XOIsBlank = False
            TxtAddress.XOIsMandatory = False
            TxtAddress.XOIsPlaceholder = False
            TxtAddress.XOIsReplaceEmptyString = False
            TxtAddress.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtAddress.XOMandatoryBgColor = Color.LightPink
            TxtAddress.XOMandatoryBgColorDefault = Color.White
            TxtAddress.XOMandatoryMessage = Nothing
            TxtAddress.XOPasswordLengthMin = 8
            TxtAddress.XOPasswordStrengthCalc = False
            TxtAddress.XOPasswordStrengthScore = 0
            TxtAddress.XOPasswordStrengthText = Nothing
            TxtAddress.XOPlaceholderText = "Type then press Enter"
            TxtAddress.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtAddress.XOSelectOnFocus = False
            TxtAddress.XOSqlText = ""
            ' 
            ' TxtBirthPlace
            ' 
            TxtBirthPlace.BackColor = Color.White
            TxtBirthPlace.Font = New Font("Segoe UI", 12F)
            TxtBirthPlace.Location = New Point(273, 217)
            TxtBirthPlace.Margin = New Padding(6, 5, 6, 5)
            TxtBirthPlace.MaxLength = 255
            TxtBirthPlace.Name = "TxtBirthPlace"
            TxtBirthPlace.Size = New Size(341, 39)
            TxtBirthPlace.TabIndex = 103
            TxtBirthPlace.Tag = "txt"
            TxtBirthPlace.XOAutoTrim = True
            TxtBirthPlace.XOHighlightColor = Color.LightYellow
            TxtBirthPlace.XOHighlightOnFocus = True
            TxtBirthPlace.XOIsBlank = False
            TxtBirthPlace.XOIsMandatory = True
            TxtBirthPlace.XOIsPlaceholder = False
            TxtBirthPlace.XOIsReplaceEmptyString = False
            TxtBirthPlace.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtBirthPlace.XOMandatoryBgColor = Color.LightPink
            TxtBirthPlace.XOMandatoryBgColorDefault = Color.White
            TxtBirthPlace.XOMandatoryMessage = Nothing
            TxtBirthPlace.XOPasswordLengthMin = 8
            TxtBirthPlace.XOPasswordStrengthCalc = False
            TxtBirthPlace.XOPasswordStrengthScore = 0
            TxtBirthPlace.XOPasswordStrengthText = Nothing
            TxtBirthPlace.XOPlaceholderText = "Type then press Enter"
            TxtBirthPlace.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.OnlyTextAndSpace
            TxtBirthPlace.XOSelectOnFocus = False
            TxtBirthPlace.XOSqlText = ""
            ' 
            ' DtpBirthDate
            ' 
            DtpBirthDate.Font = New Font("Segoe UI", 12F)
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
            TxtPersonalID.Font = New Font("Segoe UI", 12F)
            TxtPersonalID.Location = New Point(273, 15)
            TxtPersonalID.Margin = New Padding(6, 5, 6, 5)
            TxtPersonalID.MaxLength = 16
            TxtPersonalID.Name = "TxtPersonalID"
            TxtPersonalID.Size = New Size(341, 39)
            TxtPersonalID.TabIndex = 100
            TxtPersonalID.Tag = "txt"
            TxtPersonalID.XOAutoTrim = True
            TxtPersonalID.XOHighlightColor = Color.LightYellow
            TxtPersonalID.XOHighlightOnFocus = True
            TxtPersonalID.XOIsBlank = True
            TxtPersonalID.XOIsMandatory = True
            TxtPersonalID.XOIsPlaceholder = False
            TxtPersonalID.XOIsReplaceEmptyString = False
            TxtPersonalID.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtPersonalID.XOMandatoryBgColor = Color.LightPink
            TxtPersonalID.XOMandatoryBgColorDefault = Color.White
            TxtPersonalID.XOMandatoryMessage = Nothing
            TxtPersonalID.XOPasswordLengthMin = 8
            TxtPersonalID.XOPasswordStrengthCalc = False
            TxtPersonalID.XOPasswordStrengthScore = 0
            TxtPersonalID.XOPasswordStrengthText = Nothing
            TxtPersonalID.XOPlaceholderText = "Type then press Enter"
            TxtPersonalID.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.OnlyNumberNoSpace
            TxtPersonalID.XOSelectOnFocus = False
            TxtPersonalID.XOSqlText = ""
            ' 
            ' CboGender
            ' 
            CboGender.DropDownStyle = ComboBoxStyle.DropDownList
            CboGender.FlatStyle = FlatStyle.Flat
            CboGender.Font = New Font("Segoe UI", 12F)
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
            TxtFullName.Font = New Font("Segoe UI", 12F)
            TxtFullName.Location = New Point(273, 83)
            TxtFullName.Margin = New Padding(6, 5, 6, 5)
            TxtFullName.MaxLength = 255
            TxtFullName.Name = "TxtFullName"
            TxtFullName.Size = New Size(454, 39)
            TxtFullName.TabIndex = 101
            TxtFullName.Tag = "txt"
            TxtFullName.XOAutoTrim = True
            TxtFullName.XOHighlightColor = Color.LightYellow
            TxtFullName.XOHighlightOnFocus = True
            TxtFullName.XOIsBlank = False
            TxtFullName.XOIsMandatory = True
            TxtFullName.XOIsPlaceholder = False
            TxtFullName.XOIsReplaceEmptyString = False
            TxtFullName.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtFullName.XOMandatoryBgColor = Color.LightPink
            TxtFullName.XOMandatoryBgColorDefault = Color.White
            TxtFullName.XOMandatoryMessage = Nothing
            TxtFullName.XOPasswordLengthMin = 8
            TxtFullName.XOPasswordStrengthCalc = False
            TxtFullName.XOPasswordStrengthScore = 0
            TxtFullName.XOPasswordStrengthText = Nothing
            TxtFullName.XOPlaceholderText = "Type then press Enter"
            TxtFullName.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.OnlyTextAndSpace
            TxtFullName.XOSelectOnFocus = False
            TxtFullName.XOSqlText = ""
            ' 
            ' TbctlEmployee
            ' 
            TbctlEmployee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            TbctlEmployee.Controls.Add(tpGeneral)
            TbctlEmployee.Controls.Add(tpEmployment)
            TbctlEmployee.Controls.Add(tpPermissions)
            TbctlEmployee.Font = New Font("Segoe UI", 12F)
            TbctlEmployee.Location = New Point(20, 25)
            TbctlEmployee.Margin = New Padding(6, 5, 6, 5)
            TbctlEmployee.Name = "TbctlEmployee"
            TbctlEmployee.SelectedIndex = 0
            TbctlEmployee.Size = New Size(830, 700)
            TbctlEmployee.TabIndex = 1039
            ' 
            ' ULbl8
            ' 
            ULbl8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ULbl8.BackColor = Color.Moccasin
            ULbl8.Location = New Point(887, 83)
            ULbl8.Margin = New Padding(7, 5, 7, 5)
            ULbl8.Name = "ULbl8"
            ULbl8.Size = New Size(250, 39)
            ULbl8.TabIndex = 1041
            ULbl8.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl8.XOText = "Photo"
            ULbl8.XOTextAdjuster = False
            ULbl8.XOTextBorder = False
            ' 
            ' BtnRemovePhoto
            ' 
            BtnRemovePhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnRemovePhoto.BackColor = Color.Red
            BtnRemovePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnRemovePhoto.FlatAppearance.BorderSize = 2
            BtnRemovePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnRemovePhoto.FlatStyle = FlatStyle.Flat
            BtnRemovePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnRemovePhoto.ForeColor = Color.White
            BtnRemovePhoto.Location = New Point(933, 516)
            BtnRemovePhoto.Name = "BtnRemovePhoto"
            BtnRemovePhoto.Size = New Size(179, 80)
            BtnRemovePhoto.TabIndex = 1042
            BtnRemovePhoto.Text = "Remove"
            BtnRemovePhoto.UseVisualStyleBackColor = False
            BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnRemovePhoto.XOShowBorderOnFocus = False
            BtnRemovePhoto.XOValidateAllInput = False
            BtnRemovePhoto.XOValidateAllInputTag = Nothing
            ' 
            ' FRMeplsEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1181, 965)
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
            tpEmployment.ResumeLayout(False)
            tpEmployment.PerformLayout()
            tpGeneral.ResumeLayout(False)
            tpGeneral.PerformLayout()
            TbctlEmployee.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents BtnBrowsePhoto As CMCv.UI.Control.Btn
        Friend WithEvents pctbxPhoto As CMCv.UI.Control.Pbx
        Friend WithEvents OfdPhoto As OpenFileDialog
        Friend WithEvents pcbxFrame As CMCv.UI.Control.Pbx
        Friend WithEvents TbctlEmployee As CMCv.UI.Control.Tbx
        Friend WithEvents tpGeneral As TabPage
        Friend WithEvents TxtPersonalID As CMCv.UI.Control.Txt
        Friend WithEvents CboGender As CMCv.UI.Control.Cbo
        Friend WithEvents TxtFullName As CMCv.UI.Control.Txt
        Friend WithEvents tpEmployment As TabPage
        Friend WithEvents TxtEmployeeNickname As CMCv.UI.Control.Txt
        Friend WithEvents TxtEmployeeNumber As CMCv.UI.Control.Txt
        Friend WithEvents TxtEmploymentType As CMCv.UI.Control.Txt
        Friend WithEvents TxtPosition As CMCv.UI.Control.Txt
        Friend WithEvents BtnBrowsePosition As CMCv.UI.Control.Btn
        Friend WithEvents TxTDepartment As CMCv.UI.Control.Txt
        Friend WithEvents TxtCompany As CMCv.UI.Control.Txt
        Friend WithEvents tpPermissions As TabPage
        Friend WithEvents GbxModulesRoles As CMCv.UI.Control.Gbx
        Friend WithEvents DgnModulesRoles As CMCv.UI.Control.Dgn
        Friend WithEvents DtpBirthDate As CMCv.UI.Control.Dtp
        Friend WithEvents ChkActiveEmployee As CMCv.UI.Control.Chk
        Friend WithEvents TxtBirthPlace As CMCv.UI.Control.Txt
        Friend WithEvents TxtAddress As CMCv.UI.Control.Txt
        Friend WithEvents GbxCredetials As CMCv.UI.Control.Gbx
        Friend WithEvents TxtLogin As CMCv.UI.Control.Txt
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
        Friend WithEvents ULbl12 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl11 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl10 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl9 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents BtnBrowseEmploymentType As CMCv.UI.Control.Btn
        Friend WithEvents BtnRemovePhoto As CMCv.UI.Control.Btn
    End Class
End Namespace