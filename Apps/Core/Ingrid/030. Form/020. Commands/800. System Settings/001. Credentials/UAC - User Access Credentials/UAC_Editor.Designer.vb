<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UAC_Editor
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.TxtEmployeeNumber = New CMCv.txt(Me.components)
        Me.TxtEmployeeFullName = New CMCv.txt(Me.components)
        Me.TxtUsername = New CMCv.txt(Me.components)
        Me.TxtPassword = New CMCv.txt(Me.components)
        Me.BtnBrowseEmployee = New CMCv.btn(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.LblPwdText = New CMCv.lbl(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TbctlAccess = New CMCv.tbctl(Me.components)
        Me.TpPermissions = New System.Windows.Forms.TabPage()
        Me.DgnUACe = New CMCv.dgn(Me.components)
        Me.modulegroup_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.useraccess_view = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_add = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_edit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_reports = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.useraccess_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpAccessibility = New System.Windows.Forms.TabPage()
        Me.ChkAdministrator = New CMCv.chk(Me.components)
        Me.ChkLocked = New CMCv.chk(Me.components)
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.TbctlAccess.SuspendLayout()
        Me.TpPermissions.SuspendLayout()
        CType(Me.DgnUACe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpAccessibility.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 482)
        Me.PnlBottomButton.Size = New System.Drawing.Size(492, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(492, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ULbl4)
        Me.SLFPanel.Controls.Add(Me.ULbl3)
        Me.SLFPanel.Controls.Add(Me.ULbl2)
        Me.SLFPanel.Controls.Add(Me.ULbl1)
        Me.SLFPanel.Controls.Add(Me.TbctlAccess)
        Me.SLFPanel.Controls.Add(Me.ProgressBar1)
        Me.SLFPanel.Controls.Add(Me.LblPwdText)
        Me.SLFPanel.Controls.Add(Me.BtnBrowseEmployee)
        Me.SLFPanel.Controls.Add(Me.TxtPassword)
        Me.SLFPanel.Controls.Add(Me.TxtUsername)
        Me.SLFPanel.Controls.Add(Me.TxtEmployeeFullName)
        Me.SLFPanel.Controls.Add(Me.TxtEmployeeNumber)
        Me.SLFPanel.Size = New System.Drawing.Size(492, 532)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtEmployeeNumber, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtEmployeeFullName, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtUsername, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPassword, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.BtnBrowseEmployee, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.LblPwdText, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ProgressBar1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TbctlAccess, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl4, 0)
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
        Me.BtnSave.Location = New System.Drawing.Point(274, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 7
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
        Me.BtnCancel.Location = New System.Drawing.Point(380, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtEmployeeNumber
        '
        Me.TxtEmployeeNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtEmployeeNumber.Location = New System.Drawing.Point(168, 10)
        Me.TxtEmployeeNumber.MaxLength = 255
        Me.TxtEmployeeNumber.Name = "TxtEmployeeNumber"
        Me.TxtEmployeeNumber.ReadOnly = True
        Me.TxtEmployeeNumber.Size = New System.Drawing.Size(229, 29)
        Me.TxtEmployeeNumber.SLFAutoTrim = False
        Me.TxtEmployeeNumber.SLFHarusDiisi = False
        Me.TxtEmployeeNumber.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtEmployeeNumber.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtEmployeeNumber.SLFHightlightSaatFokus = False
        Me.TxtEmployeeNumber.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtEmployeeNumber.SLFIsBlank = False
        Me.TxtEmployeeNumber.SLFIsSearchBox = False
        Me.TxtEmployeeNumber.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
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
        Me.TxtEmployeeNumber.TabIndex = 0
        Me.TxtEmployeeNumber.Tag = "txt"
        Me.TxtEmployeeNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtEmployeeFullName
        '
        Me.TxtEmployeeFullName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtEmployeeFullName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtEmployeeFullName.Location = New System.Drawing.Point(168, 45)
        Me.TxtEmployeeFullName.MaxLength = 255
        Me.TxtEmployeeFullName.Name = "TxtEmployeeFullName"
        Me.TxtEmployeeFullName.ReadOnly = True
        Me.TxtEmployeeFullName.Size = New System.Drawing.Size(274, 29)
        Me.TxtEmployeeFullName.SLFAutoTrim = False
        Me.TxtEmployeeFullName.SLFHarusDiisi = False
        Me.TxtEmployeeFullName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtEmployeeFullName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtEmployeeFullName.SLFHightlightSaatFokus = False
        Me.TxtEmployeeFullName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtEmployeeFullName.SLFIsBlank = True
        Me.TxtEmployeeFullName.SLFIsSearchBox = False
        Me.TxtEmployeeFullName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtEmployeeFullName.SLFPilihSemuaSaatFokus = False
        Me.TxtEmployeeFullName.SLFPwdLengthMin = 8
        Me.TxtEmployeeFullName.SLFPwdStrengthCalculate = False
        Me.TxtEmployeeFullName.SLFPwdStrengthScore = 0
        Me.TxtEmployeeFullName.SLFPwdStrengthText = Nothing
        Me.TxtEmployeeFullName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtEmployeeFullName.SLFSearchBoxText = "Type then press Enter"
        Me.TxtEmployeeFullName.SLFSQLText = ""
        Me.TxtEmployeeFullName.SLFTanpaSpasi = False
        Me.TxtEmployeeFullName.SLFValidasiField = Nothing
        Me.TxtEmployeeFullName.TabIndex = 1
        Me.TxtEmployeeFullName.TabStop = False
        Me.TxtEmployeeFullName.Tag = "txt"
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtUsername.Location = New System.Drawing.Point(168, 80)
        Me.TxtUsername.MaxLength = 255
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(274, 29)
        Me.TxtUsername.SLFAutoTrim = True
        Me.TxtUsername.SLFHarusDiisi = True
        Me.TxtUsername.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtUsername.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtUsername.SLFHightlightSaatFokus = True
        Me.TxtUsername.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtUsername.SLFIsBlank = True
        Me.TxtUsername.SLFIsSearchBox = False
        Me.TxtUsername.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtUsername.SLFPilihSemuaSaatFokus = True
        Me.TxtUsername.SLFPwdLengthMin = 8
        Me.TxtUsername.SLFPwdStrengthCalculate = False
        Me.TxtUsername.SLFPwdStrengthScore = 0
        Me.TxtUsername.SLFPwdStrengthText = Nothing
        Me.TxtUsername.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtUsername.SLFSearchBoxText = "Type then press Enter"
        Me.TxtUsername.SLFSQLText = ""
        Me.TxtUsername.SLFTanpaSpasi = True
        Me.TxtUsername.SLFValidasiField = Nothing
        Me.TxtUsername.TabIndex = 3
        Me.TxtUsername.Tag = "txt"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPassword.Location = New System.Drawing.Point(168, 115)
        Me.TxtPassword.MaxLength = 255
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(274, 29)
        Me.TxtPassword.SLFAutoTrim = False
        Me.TxtPassword.SLFHarusDiisi = True
        Me.TxtPassword.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPassword.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPassword.SLFHightlightSaatFokus = True
        Me.TxtPassword.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPassword.SLFIsBlank = True
        Me.TxtPassword.SLFIsSearchBox = False
        Me.TxtPassword.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPassword.SLFPilihSemuaSaatFokus = True
        Me.TxtPassword.SLFPwdLengthMin = 8
        Me.TxtPassword.SLFPwdStrengthCalculate = True
        Me.TxtPassword.SLFPwdStrengthScore = 0
        Me.TxtPassword.SLFPwdStrengthText = Nothing
        Me.TxtPassword.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPassword.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPassword.SLFSQLText = ""
        Me.TxtPassword.SLFTanpaSpasi = False
        Me.TxtPassword.SLFValidasiField = Nothing
        Me.TxtPassword.TabIndex = 4
        Me.TxtPassword.Tag = "txt"
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'BtnBrowseEmployee
        '
        Me.BtnBrowseEmployee.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnBrowseEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowseEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnBrowseEmployee.FlatAppearance.BorderSize = 2
        Me.BtnBrowseEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnBrowseEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowseEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowseEmployee.ForeColor = System.Drawing.Color.White
        Me.BtnBrowseEmployee.Location = New System.Drawing.Point(403, 10)
        Me.BtnBrowseEmployee.Name = "BtnBrowseEmployee"
        Me.BtnBrowseEmployee.Size = New System.Drawing.Size(39, 29)
        Me.BtnBrowseEmployee.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnBrowseEmployee.SLFTampilkanFocusBorder = False
        Me.BtnBrowseEmployee.SLFValidasiSemuaInput = False
        Me.BtnBrowseEmployee.SLFValidasiSemuaInputTag = Nothing
        Me.BtnBrowseEmployee.TabIndex = 2
        Me.BtnBrowseEmployee.Text = "..."
        Me.BtnBrowseEmployee.UseVisualStyleBackColor = False
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(122, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 9
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'LblPwdText
        '
        Me.LblPwdText.AutoSize = True
        Me.LblPwdText.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblPwdText.Location = New System.Drawing.Point(137, 163)
        Me.LblPwdText.Name = "LblPwdText"
        Me.LblPwdText.Size = New System.Drawing.Size(0, 21)
        Me.LblPwdText.SLFCustomElipsis = False
        Me.LblPwdText.TabIndex = 1006
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(168, 150)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(274, 10)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 1007
        '
        'TbctlAccess
        '
        Me.TbctlAccess.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbctlAccess.Controls.Add(Me.TpPermissions)
        Me.TbctlAccess.Controls.Add(Me.TpAccessibility)
        Me.TbctlAccess.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TbctlAccess.Location = New System.Drawing.Point(0, 187)
        Me.TbctlAccess.Name = "TbctlAccess"
        Me.TbctlAccess.SelectedIndex = 0
        Me.TbctlAccess.Size = New System.Drawing.Size(492, 301)
        Me.TbctlAccess.TabIndex = 1008
        '
        'TpPermissions
        '
        Me.TpPermissions.Controls.Add(Me.DgnUACe)
        Me.TpPermissions.Location = New System.Drawing.Point(4, 30)
        Me.TpPermissions.Name = "TpPermissions"
        Me.TpPermissions.Padding = New System.Windows.Forms.Padding(3)
        Me.TpPermissions.Size = New System.Drawing.Size(484, 267)
        Me.TpPermissions.TabIndex = 0
        Me.TpPermissions.Text = "PERMISSIONS"
        Me.TpPermissions.UseVisualStyleBackColor = True
        '
        'DgnUACe
        '
        Me.DgnUACe.AllowUserToAddRows = False
        Me.DgnUACe.AllowUserToDeleteRows = False
        Me.DgnUACe.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DgnUACe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnUACe.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnUACe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnUACe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnUACe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnUACe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnUACe.ColumnHeadersHeight = 43
        Me.DgnUACe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnUACe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modulegroup_name, Me.module_code, Me.useraccess_view, Me.useraccess_add, Me.useraccess_edit, Me.useraccess_delete, Me.useraccess_reports, Me.useraccess_id, Me.module_id})
        Me.DgnUACe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnUACe.EnableHeadersVisualStyles = False
        Me.DgnUACe.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnUACe.Location = New System.Drawing.Point(3, 3)
        Me.DgnUACe.MultiSelect = False
        Me.DgnUACe.Name = "DgnUACe"
        Me.DgnUACe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnUACe.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnUACe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnUACe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgnUACe.Size = New System.Drawing.Size(478, 261)
        Me.DgnUACe.SLFGroupFirstRows = True
        Me.DgnUACe.SLFGunakanNomorBaris = True
        Me.DgnUACe.StandardTab = True
        Me.DgnUACe.TabIndex = 7
        '
        'modulegroup_name
        '
        Me.modulegroup_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.modulegroup_name.DataPropertyName = "modulegroup_name"
        Me.modulegroup_name.HeaderText = "Module Group"
        Me.modulegroup_name.Name = "modulegroup_name"
        Me.modulegroup_name.ReadOnly = True
        Me.modulegroup_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'module_code
        '
        Me.module_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.module_code.DataPropertyName = "module_code"
        Me.module_code.HeaderText = "Module Code"
        Me.module_code.Name = "module_code"
        Me.module_code.ReadOnly = True
        Me.module_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.module_code.Width = 95
        '
        'useraccess_view
        '
        Me.useraccess_view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_view.DataPropertyName = "useraccess_view"
        Me.useraccess_view.HeaderText = "View"
        Me.useraccess_view.Name = "useraccess_view"
        Me.useraccess_view.Width = 40
        '
        'useraccess_add
        '
        Me.useraccess_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_add.DataPropertyName = "useraccess_add"
        Me.useraccess_add.HeaderText = "Add"
        Me.useraccess_add.Name = "useraccess_add"
        Me.useraccess_add.Width = 40
        '
        'useraccess_edit
        '
        Me.useraccess_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_edit.DataPropertyName = "useraccess_edit"
        Me.useraccess_edit.HeaderText = "Edit"
        Me.useraccess_edit.Name = "useraccess_edit"
        Me.useraccess_edit.Width = 40
        '
        'useraccess_delete
        '
        Me.useraccess_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_delete.DataPropertyName = "useraccess_delete"
        Me.useraccess_delete.HeaderText = "Del"
        Me.useraccess_delete.Name = "useraccess_delete"
        Me.useraccess_delete.Width = 40
        '
        'useraccess_reports
        '
        Me.useraccess_reports.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.useraccess_reports.DataPropertyName = "useraccess_reports"
        Me.useraccess_reports.HeaderText = "Rpt"
        Me.useraccess_reports.Name = "useraccess_reports"
        Me.useraccess_reports.Width = 40
        '
        'useraccess_id
        '
        Me.useraccess_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.useraccess_id.DataPropertyName = "useraccess_id"
        Me.useraccess_id.HeaderText = "ID"
        Me.useraccess_id.Name = "useraccess_id"
        Me.useraccess_id.ReadOnly = True
        Me.useraccess_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.useraccess_id.Visible = False
        Me.useraccess_id.Width = 5
        '
        'module_id
        '
        Me.module_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.module_id.DataPropertyName = "module_id"
        Me.module_id.HeaderText = "Module ID"
        Me.module_id.Name = "module_id"
        Me.module_id.ReadOnly = True
        Me.module_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.module_id.Visible = False
        Me.module_id.Width = 5
        '
        'TpAccessibility
        '
        Me.TpAccessibility.Controls.Add(Me.ChkAdministrator)
        Me.TpAccessibility.Controls.Add(Me.ChkLocked)
        Me.TpAccessibility.Location = New System.Drawing.Point(4, 30)
        Me.TpAccessibility.Name = "TpAccessibility"
        Me.TpAccessibility.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAccessibility.Size = New System.Drawing.Size(776, 220)
        Me.TpAccessibility.TabIndex = 1
        Me.TpAccessibility.Text = "ACCESSIBILITY"
        Me.TpAccessibility.UseVisualStyleBackColor = True
        '
        'ChkAdministrator
        '
        Me.ChkAdministrator.AutoSize = True
        Me.ChkAdministrator.BackColor = System.Drawing.Color.Transparent
        Me.ChkAdministrator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAdministrator.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAdministrator.Location = New System.Drawing.Point(6, 41)
        Me.ChkAdministrator.Name = "ChkAdministrator"
        Me.ChkAdministrator.Size = New System.Drawing.Size(122, 25)
        Me.ChkAdministrator.TabIndex = 1007
        Me.ChkAdministrator.Text = "Administrator"
        Me.ChkAdministrator.UseVisualStyleBackColor = False
        '
        'ChkLocked
        '
        Me.ChkLocked.AutoSize = True
        Me.ChkLocked.BackColor = System.Drawing.Color.Transparent
        Me.ChkLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLocked.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkLocked.Location = New System.Drawing.Point(6, 6)
        Me.ChkLocked.Name = "ChkLocked"
        Me.ChkLocked.Size = New System.Drawing.Size(75, 25)
        Me.ChkLocked.TabIndex = 1006
        Me.ChkLocked.Text = "Locked"
        Me.ChkLocked.UseVisualStyleBackColor = False
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(12, 10)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Employee ID"
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1010
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(12, 45)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Employee Name"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1011
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(12, 80)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Username"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1012
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(12, 115)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Password"
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1013
        '
        'UAC_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(492, 608)
        Me.KeyPreview = True
        Me.Name = "UAC_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.TbctlAccess.ResumeLayout(False)
        Me.TpPermissions.ResumeLayout(False)
        CType(Me.DgnUACe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpAccessibility.ResumeLayout(False)
        Me.TpAccessibility.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents TxtEmployeeNumber As CMCv.txt
    Friend WithEvents TxtPassword As CMCv.txt
    Friend WithEvents TxtUsername As CMCv.txt
    Friend WithEvents TxtEmployeeFullName As CMCv.txt
    Friend WithEvents BtnBrowseEmployee As CMCv.btn
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents LblPwdText As CMCv.lbl
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TbctlAccess As CMCv.tbctl
    Friend WithEvents TpPermissions As TabPage
    Friend WithEvents DgnUACe As CMCv.dgn
    Friend WithEvents TpAccessibility As TabPage
    Friend WithEvents ChkAdministrator As CMCv.chk
    Friend WithEvents ChkLocked As CMCv.chk
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents module_code As DataGridViewTextBoxColumn
    Friend WithEvents useraccess_view As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_add As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_edit As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_delete As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_reports As DataGridViewCheckBoxColumn
    Friend WithEvents useraccess_id As DataGridViewTextBoxColumn
    Friend WithEvents module_id As DataGridViewTextBoxColumn
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
End Class
