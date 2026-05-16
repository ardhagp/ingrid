Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMuacEditor
        Inherits CMCv.FRMstandardFooter

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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            TxtEmployeeNumber = New CMCv.UI.Control.txt(components)
            TxtEmployeeFullName = New CMCv.UI.Control.txt(components)
            TxtUsername = New CMCv.UI.Control.txt(components)
            TxtPassword = New CMCv.UI.Control.txt(components)
            BtnBrowseEmployee = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.chk(components)
            LblPwdText = New CMCv.UI.Control.lbl(components)
            ProgressBar1 = New ProgressBar()
            TbctlAccess = New CMCv.UI.Control.tbctl(components)
            TpPermissions = New TabPage()
            DgnUACe = New CMCv.UI.Control.dgn(components)
            modulegroup_name = New DataGridViewTextBoxColumn()
            module_code = New DataGridViewTextBoxColumn()
            useraccess_view = New DataGridViewCheckBoxColumn()
            useraccess_add = New DataGridViewCheckBoxColumn()
            useraccess_edit = New DataGridViewCheckBoxColumn()
            useraccess_delete = New DataGridViewCheckBoxColumn()
            useraccess_reports = New DataGridViewCheckBoxColumn()
            useraccess_id = New DataGridViewTextBoxColumn()
            module_id = New DataGridViewTextBoxColumn()
            TpAccessibility = New TabPage()
            ChkAdministrator = New CMCv.UI.Control.chk(components)
            ChkLocked = New CMCv.UI.Control.chk(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            TbctlAccess.SuspendLayout()
            TpPermissions.SuspendLayout()
            CType(DgnUACe, ComponentModel.ISupportInitialize).BeginInit()
            TpAccessibility.SuspendLayout()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 947)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(820, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(820, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TbctlAccess)
            SLFPanel.Controls.Add(ProgressBar1)
            SLFPanel.Controls.Add(LblPwdText)
            SLFPanel.Controls.Add(BtnBrowseEmployee)
            SLFPanel.Controls.Add(TxtPassword)
            SLFPanel.Controls.Add(TxtUsername)
            SLFPanel.Controls.Add(TxtEmployeeFullName)
            SLFPanel.Controls.Add(TxtEmployeeNumber)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(820, 1044)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TxtEmployeeNumber, 0)
            SLFPanel.Controls.SetChildIndex(TxtEmployeeFullName, 0)
            SLFPanel.Controls.SetChildIndex(TxtUsername, 0)
            SLFPanel.Controls.SetChildIndex(TxtPassword, 0)
            SLFPanel.Controls.SetChildIndex(BtnBrowseEmployee, 0)
            SLFPanel.Controls.SetChildIndex(LblPwdText, 0)
            SLFPanel.Controls.SetChildIndex(ProgressBar1, 0)
            SLFPanel.Controls.SetChildIndex(TbctlAccess, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
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
            BtnSave.Location = New Point(456, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 7
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = ControlCodeBase.buttonType.Yes
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
            BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(633, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 8
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' TxtEmployeeNumber
            ' 
            TxtEmployeeNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtEmployeeNumber.Location = New Point(280, 20)
            TxtEmployeeNumber.Margin = New Padding(6, 5, 6, 5)
            TxtEmployeeNumber.MaxLength = 255
            TxtEmployeeNumber.Name = "TxtEmployeeNumber"
            TxtEmployeeNumber.ReadOnly = True
            TxtEmployeeNumber.Size = New Size(378, 39)
            TxtEmployeeNumber.TabIndex = 0
            TxtEmployeeNumber.Tag = "txt"
            TxtEmployeeNumber.TextAlign = HorizontalAlignment.Center
            TxtEmployeeNumber.XOAutoTrim = False
            TxtEmployeeNumber.XOHarusDiisi = False
            TxtEmployeeNumber.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtEmployeeNumber.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtEmployeeNumber.XOHightlightSaatFokus = False
            TxtEmployeeNumber.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtEmployeeNumber.XOIsBlank = False
            TxtEmployeeNumber.XOIsSearchBox = False
            TxtEmployeeNumber.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
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
            ' TxtEmployeeFullName
            ' 
            TxtEmployeeFullName.BackColor = SystemColors.Window
            TxtEmployeeFullName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtEmployeeFullName.Location = New Point(280, 87)
            TxtEmployeeFullName.Margin = New Padding(6, 5, 6, 5)
            TxtEmployeeFullName.MaxLength = 255
            TxtEmployeeFullName.Name = "TxtEmployeeFullName"
            TxtEmployeeFullName.ReadOnly = True
            TxtEmployeeFullName.Size = New Size(454, 39)
            TxtEmployeeFullName.TabIndex = 1
            TxtEmployeeFullName.TabStop = False
            TxtEmployeeFullName.Tag = "txt"
            TxtEmployeeFullName.XOAutoTrim = False
            TxtEmployeeFullName.XOHarusDiisi = False
            TxtEmployeeFullName.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtEmployeeFullName.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtEmployeeFullName.XOHightlightSaatFokus = False
            TxtEmployeeFullName.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtEmployeeFullName.XOIsBlank = True
            TxtEmployeeFullName.XOIsSearchBox = False
            TxtEmployeeFullName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtEmployeeFullName.XOPilihSemuaSaatFokus = False
            TxtEmployeeFullName.XOPwdLengthMin = 8
            TxtEmployeeFullName.XOPwdStrengthCalculate = False
            TxtEmployeeFullName.XOPwdStrengthScore = 0
            TxtEmployeeFullName.XOPwdStrengthText = Nothing
            TxtEmployeeFullName.XORestriction = ControlCodeBase.enuRestriction.None
            TxtEmployeeFullName.XOSearchBoxText = "Type then press Enter"
            TxtEmployeeFullName.XOSQLText = ""
            TxtEmployeeFullName.XOTanpaSpasi = False
            TxtEmployeeFullName.XOValidasiField = Nothing
            ' 
            ' TxtUsername
            ' 
            TxtUsername.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtUsername.Location = New Point(280, 153)
            TxtUsername.Margin = New Padding(6, 5, 6, 5)
            TxtUsername.MaxLength = 255
            TxtUsername.Name = "TxtUsername"
            TxtUsername.Size = New Size(454, 39)
            TxtUsername.TabIndex = 3
            TxtUsername.Tag = "txt"
            TxtUsername.XOAutoTrim = True
            TxtUsername.XOHarusDiisi = True
            TxtUsername.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtUsername.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtUsername.XOHightlightSaatFokus = True
            TxtUsername.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtUsername.XOIsBlank = True
            TxtUsername.XOIsSearchBox = False
            TxtUsername.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtUsername.XOPilihSemuaSaatFokus = True
            TxtUsername.XOPwdLengthMin = 8
            TxtUsername.XOPwdStrengthCalculate = False
            TxtUsername.XOPwdStrengthScore = 0
            TxtUsername.XOPwdStrengthText = Nothing
            TxtUsername.XORestriction = ControlCodeBase.enuRestriction.None
            TxtUsername.XOSearchBoxText = "Type then press Enter"
            TxtUsername.XOSQLText = ""
            TxtUsername.XOTanpaSpasi = True
            TxtUsername.XOValidasiField = Nothing
            ' 
            ' TxtPassword
            ' 
            TxtPassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPassword.Location = New Point(280, 222)
            TxtPassword.Margin = New Padding(6, 5, 6, 5)
            TxtPassword.MaxLength = 255
            TxtPassword.Name = "TxtPassword"
            TxtPassword.PasswordChar = "●"c
            TxtPassword.Size = New Size(454, 39)
            TxtPassword.TabIndex = 4
            TxtPassword.Tag = "txt"
            TxtPassword.XOAutoTrim = False
            TxtPassword.XOHarusDiisi = True
            TxtPassword.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPassword.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPassword.XOHightlightSaatFokus = True
            TxtPassword.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPassword.XOIsBlank = True
            TxtPassword.XOIsSearchBox = False
            TxtPassword.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtPassword.XOPilihSemuaSaatFokus = True
            TxtPassword.XOPwdLengthMin = 8
            TxtPassword.XOPwdStrengthCalculate = True
            TxtPassword.XOPwdStrengthScore = 0
            TxtPassword.XOPwdStrengthText = Nothing
            TxtPassword.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPassword.XOSearchBoxText = "Type then press Enter"
            TxtPassword.XOSQLText = ""
            TxtPassword.XOTanpaSpasi = False
            TxtPassword.XOValidasiField = Nothing
            ' 
            ' BtnBrowseEmployee
            ' 
            BtnBrowseEmployee.BackColor = Color.RoyalBlue
            BtnBrowseEmployee.Cursor = Cursors.Hand
            BtnBrowseEmployee.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowseEmployee.FlatAppearance.BorderSize = 2
            BtnBrowseEmployee.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowseEmployee.FlatStyle = FlatStyle.Flat
            BtnBrowseEmployee.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowseEmployee.ForeColor = Color.White
            BtnBrowseEmployee.Location = New Point(671, 20)
            BtnBrowseEmployee.Margin = New Padding(6, 5, 6, 5)
            BtnBrowseEmployee.Name = "BtnBrowseEmployee"
            BtnBrowseEmployee.Size = New Size(66, 55)
            BtnBrowseEmployee.TabIndex = 2
            BtnBrowseEmployee.Text = "..."
            BtnBrowseEmployee.UseVisualStyleBackColor = False
            BtnBrowseEmployee.XOButtonType = ControlCodeBase.buttonType.Default
            BtnBrowseEmployee.XOShowBorderOnFocus = False
            BtnBrowseEmployee.XOValidateAllInput = False
            BtnBrowseEmployee.XOValidateAllInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(225, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 9
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' LblPwdText
            ' 
            LblPwdText.AutoSize = True
            LblPwdText.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            LblPwdText.Location = New Point(229, 313)
            LblPwdText.Margin = New Padding(6, 0, 6, 0)
            LblPwdText.Name = "LblPwdText"
            LblPwdText.Size = New Size(0, 32)
            LblPwdText.TabIndex = 1006
            LblPwdText.XOCustomElipsis = False
            ' 
            ' ProgressBar1
            ' 
            ProgressBar1.Location = New Point(280, 288)
            ProgressBar1.Margin = New Padding(6, 5, 6, 5)
            ProgressBar1.Name = "ProgressBar1"
            ProgressBar1.Size = New Size(457, 20)
            ProgressBar1.Step = 1
            ProgressBar1.TabIndex = 1007
            ' 
            ' TbctlAccess
            ' 
            TbctlAccess.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            TbctlAccess.Controls.Add(TpPermissions)
            TbctlAccess.Controls.Add(TpAccessibility)
            TbctlAccess.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlAccess.Location = New Point(0, 360)
            TbctlAccess.Margin = New Padding(6, 5, 6, 5)
            TbctlAccess.Name = "TbctlAccess"
            TbctlAccess.SelectedIndex = 0
            TbctlAccess.Size = New Size(820, 599)
            TbctlAccess.TabIndex = 1008
            ' 
            ' TpPermissions
            ' 
            TpPermissions.Controls.Add(DgnUACe)
            TpPermissions.Location = New Point(4, 41)
            TpPermissions.Margin = New Padding(6, 5, 6, 5)
            TpPermissions.Name = "TpPermissions"
            TpPermissions.Padding = New Padding(6, 5, 6, 5)
            TpPermissions.Size = New Size(812, 554)
            TpPermissions.TabIndex = 0
            TpPermissions.Text = "PERMISSIONS"
            TpPermissions.UseVisualStyleBackColor = True
            ' 
            ' DgnUACe
            ' 
            DgnUACe.AllowUserToAddRows = False
            DgnUACe.AllowUserToDeleteRows = False
            DgnUACe.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(233), CByte(222), CByte(150))
            DgnUACe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnUACe.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnUACe.BorderStyle = BorderStyle.None
            DgnUACe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnUACe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnUACe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnUACe.ColumnHeadersHeight = 43
            DgnUACe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnUACe.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports, useraccess_id, module_id})
            DgnUACe.Dock = DockStyle.Fill
            DgnUACe.EnableHeadersVisualStyles = False
            DgnUACe.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnUACe.Location = New Point(6, 5)
            DgnUACe.Margin = New Padding(6, 5, 6, 5)
            DgnUACe.MultiSelect = False
            DgnUACe.Name = "DgnUACe"
            DgnUACe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnUACe.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnUACe.RowHeadersWidth = 62
            DgnUACe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnUACe.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgnUACe.Size = New Size(800, 544)
            DgnUACe.StandardTab = True
            DgnUACe.TabIndex = 7
            DgnUACe.XOGroupFirstRows = True
            DgnUACe.XOGunakanNomorBaris = True
            ' 
            ' modulegroup_name
            ' 
            modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            modulegroup_name.DataPropertyName = "modulegroup_name"
            modulegroup_name.HeaderText = "Module Group"
            modulegroup_name.MinimumWidth = 8
            modulegroup_name.Name = "modulegroup_name"
            modulegroup_name.ReadOnly = True
            modulegroup_name.SortMode = DataGridViewColumnSortMode.Programmatic
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
            module_code.SortMode = DataGridViewColumnSortMode.Programmatic
            module_code.Width = 135
            ' 
            ' useraccess_view
            ' 
            useraccess_view.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_view.DataPropertyName = "useraccess_view"
            useraccess_view.HeaderText = "View"
            useraccess_view.MinimumWidth = 8
            useraccess_view.Name = "useraccess_view"
            useraccess_view.Width = 40
            ' 
            ' useraccess_add
            ' 
            useraccess_add.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_add.DataPropertyName = "useraccess_add"
            useraccess_add.HeaderText = "Add"
            useraccess_add.MinimumWidth = 8
            useraccess_add.Name = "useraccess_add"
            useraccess_add.Width = 40
            ' 
            ' useraccess_edit
            ' 
            useraccess_edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_edit.DataPropertyName = "useraccess_edit"
            useraccess_edit.HeaderText = "Edit"
            useraccess_edit.MinimumWidth = 8
            useraccess_edit.Name = "useraccess_edit"
            useraccess_edit.Width = 40
            ' 
            ' useraccess_delete
            ' 
            useraccess_delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_delete.DataPropertyName = "useraccess_delete"
            useraccess_delete.HeaderText = "Del"
            useraccess_delete.MinimumWidth = 8
            useraccess_delete.Name = "useraccess_delete"
            useraccess_delete.Width = 40
            ' 
            ' useraccess_reports
            ' 
            useraccess_reports.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            useraccess_reports.DataPropertyName = "useraccess_reports"
            useraccess_reports.HeaderText = "Rpt"
            useraccess_reports.MinimumWidth = 8
            useraccess_reports.Name = "useraccess_reports"
            useraccess_reports.Width = 40
            ' 
            ' useraccess_id
            ' 
            useraccess_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            useraccess_id.DataPropertyName = "useraccess_id"
            useraccess_id.HeaderText = "ID"
            useraccess_id.MinimumWidth = 8
            useraccess_id.Name = "useraccess_id"
            useraccess_id.ReadOnly = True
            useraccess_id.SortMode = DataGridViewColumnSortMode.Programmatic
            useraccess_id.Visible = False
            useraccess_id.Width = 150
            ' 
            ' module_id
            ' 
            module_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            module_id.DataPropertyName = "module_id"
            module_id.HeaderText = "Module ID"
            module_id.MinimumWidth = 8
            module_id.Name = "module_id"
            module_id.ReadOnly = True
            module_id.SortMode = DataGridViewColumnSortMode.Programmatic
            module_id.Visible = False
            module_id.Width = 150
            ' 
            ' TpAccessibility
            ' 
            TpAccessibility.Controls.Add(ChkAdministrator)
            TpAccessibility.Controls.Add(ChkLocked)
            TpAccessibility.Location = New Point(4, 41)
            TpAccessibility.Margin = New Padding(6, 5, 6, 5)
            TpAccessibility.Name = "TpAccessibility"
            TpAccessibility.Padding = New Padding(6, 5, 6, 5)
            TpAccessibility.Size = New Size(812, 554)
            TpAccessibility.TabIndex = 1
            TpAccessibility.Text = "ACCESSIBILITY"
            TpAccessibility.UseVisualStyleBackColor = True
            ' 
            ' ChkAdministrator
            ' 
            ChkAdministrator.AutoSize = True
            ChkAdministrator.BackColor = Color.Transparent
            ChkAdministrator.FlatStyle = FlatStyle.Flat
            ChkAdministrator.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAdministrator.Location = New Point(10, 78)
            ChkAdministrator.Margin = New Padding(6, 5, 6, 5)
            ChkAdministrator.Name = "ChkAdministrator"
            ChkAdministrator.Size = New Size(179, 36)
            ChkAdministrator.TabIndex = 1007
            ChkAdministrator.Text = "Administrator"
            ChkAdministrator.UseVisualStyleBackColor = False
            ' 
            ' ChkLocked
            ' 
            ChkLocked.AutoSize = True
            ChkLocked.BackColor = Color.Transparent
            ChkLocked.FlatStyle = FlatStyle.Flat
            ChkLocked.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkLocked.Location = New Point(10, 12)
            ChkLocked.Margin = New Padding(6, 5, 6, 5)
            ChkLocked.Name = "ChkLocked"
            ChkLocked.Size = New Size(110, 36)
            ChkLocked.TabIndex = 1006
            ChkLocked.Text = "Locked"
            ChkLocked.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(20, 20)
            ULbl1.Margin = New Padding(7, 5, 7, 5)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 55)
            ULbl1.SLFText = "Employee ID"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl1.TabIndex = 1010
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(20, 87)
            ULbl2.Margin = New Padding(7, 5, 7, 5)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 55)
            ULbl2.SLFText = "Employee Name"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1011
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(20, 153)
            ULbl3.Margin = New Padding(7, 5, 7, 5)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 55)
            ULbl3.SLFText = "Username"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl3.TabIndex = 1012
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 222)
            ULbl4.Margin = New Padding(7, 5, 7, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 55)
            ULbl4.SLFText = "Password"
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl4.TabIndex = 1013
            ' 
            ' FRMuacEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(820, 1170)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMuacEditor"
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            TbctlAccess.ResumeLayout(False)
            TpPermissions.ResumeLayout(False)
            CType(DgnUACe, ComponentModel.ISupportInitialize).EndInit()
            TpAccessibility.ResumeLayout(False)
            TpAccessibility.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents TxtEmployeeNumber As CMCv.UI.Control.txt
        Friend WithEvents TxtPassword As CMCv.UI.Control.txt
        Friend WithEvents TxtUsername As CMCv.UI.Control.txt
        Friend WithEvents TxtEmployeeFullName As CMCv.UI.Control.txt
        Friend WithEvents BtnBrowseEmployee As CMCv.UI.Control.Btn
        Friend WithEvents ChkAddNew As CMCv.UI.Control.chk
        Friend WithEvents LblPwdText As CMCv.UI.Control.lbl
        Friend WithEvents ProgressBar1 As ProgressBar
        Friend WithEvents TbctlAccess As CMCv.UI.Control.tbctl
        Friend WithEvents TpPermissions As TabPage
        Friend WithEvents DgnUACe As CMCv.UI.Control.dgn
        Friend WithEvents TpAccessibility As TabPage
        Friend WithEvents ChkAdministrator As CMCv.UI.Control.chk
        Friend WithEvents ChkLocked As CMCv.UI.Control.chk
        Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
        Friend WithEvents module_code As DataGridViewTextBoxColumn
        Friend WithEvents useraccess_view As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_add As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_edit As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_delete As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_reports As DataGridViewCheckBoxColumn
        Friend WithEvents useraccess_id As DataGridViewTextBoxColumn
        Friend WithEvents module_id As DataGridViewTextBoxColumn
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
    End Class
End Namespace