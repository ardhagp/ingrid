<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODS_Editor
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.Tbctl1 = New CMCv.tbctl(Me.components)
        Me.tpGeneral = New System.Windows.Forms.TabPage()
        Me.ChkSystem = New CMCv.chk(Me.components)
        Me.TxtCode = New CMCv.txt(Me.components)
        Me.ChkLocked = New CMCv.chk(Me.components)
        Me.CboGroup = New CMCv.cbo(Me.components)
        Me.TxtDescription = New CMCv.txt(Me.components)
        Me.TxtName = New CMCv.txt(Me.components)
        Me.TxtID = New CMCv.txt(Me.components)
        Me.tpPermissions = New System.Windows.Forms.TabPage()
        Me.GbxAccessBy = New CMCv.gbx(Me.components)
        Me.DgnUserRoles = New CMCv.dgn(Me.components)
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.ULbl5 = New CMCv.ULbl()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Tbctl1.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.tpPermissions.SuspendLayout()
        Me.GbxAccessBy.SuspendLayout()
        CType(Me.DgnUserRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 294)
        Me.PnlBottomButton.Size = New System.Drawing.Size(568, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(568, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.Tbctl1)
        Me.SLFPanel.Size = New System.Drawing.Size(568, 344)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Tbctl1, 0)
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
        Me.BtnSave.Location = New System.Drawing.Point(350, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 6
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
        Me.BtnCancel.Location = New System.Drawing.Point(456, 7)
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
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(198, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 7
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'Tbctl1
        '
        Me.Tbctl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tbctl1.Controls.Add(Me.tpGeneral)
        Me.Tbctl1.Controls.Add(Me.tpPermissions)
        Me.Tbctl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Tbctl1.Location = New System.Drawing.Point(12, 6)
        Me.Tbctl1.Name = "Tbctl1"
        Me.Tbctl1.SelectedIndex = 0
        Me.Tbctl1.Size = New System.Drawing.Size(544, 282)
        Me.Tbctl1.TabIndex = 0
        '
        'tpGeneral
        '
        Me.tpGeneral.AutoScroll = True
        Me.tpGeneral.Controls.Add(Me.ULbl5)
        Me.tpGeneral.Controls.Add(Me.ULbl4)
        Me.tpGeneral.Controls.Add(Me.ULbl3)
        Me.tpGeneral.Controls.Add(Me.ULbl2)
        Me.tpGeneral.Controls.Add(Me.ULbl1)
        Me.tpGeneral.Controls.Add(Me.ChkSystem)
        Me.tpGeneral.Controls.Add(Me.TxtCode)
        Me.tpGeneral.Controls.Add(Me.ChkLocked)
        Me.tpGeneral.Controls.Add(Me.CboGroup)
        Me.tpGeneral.Controls.Add(Me.TxtDescription)
        Me.tpGeneral.Controls.Add(Me.TxtName)
        Me.tpGeneral.Controls.Add(Me.TxtID)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 30)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGeneral.Size = New System.Drawing.Size(536, 248)
        Me.tpGeneral.TabIndex = 0
        Me.tpGeneral.Text = "General"
        Me.tpGeneral.UseVisualStyleBackColor = True
        '
        'ChkSystem
        '
        Me.ChkSystem.AutoSize = True
        Me.ChkSystem.BackColor = System.Drawing.Color.Transparent
        Me.ChkSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkSystem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkSystem.Location = New System.Drawing.Point(162, 185)
        Me.ChkSystem.Name = "ChkSystem"
        Me.ChkSystem.Size = New System.Drawing.Size(134, 25)
        Me.ChkSystem.TabIndex = 6
        Me.ChkSystem.Text = "System Module"
        Me.ChkSystem.UseVisualStyleBackColor = False
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(164, 80)
        Me.TxtCode.MaxLength = 255
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(132, 29)
        Me.TxtCode.SLFAutoTrim = True
        Me.TxtCode.SLFHarusDiisi = True
        Me.TxtCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtCode.SLFHightlightSaatFokus = False
        Me.TxtCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtCode.SLFIsBlank = True
        Me.TxtCode.SLFIsSearchBox = False
        Me.TxtCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtCode.SLFPilihSemuaSaatFokus = True
        Me.TxtCode.SLFPwdLengthMin = 8
        Me.TxtCode.SLFPwdStrengthCalculate = False
        Me.TxtCode.SLFPwdStrengthScore = 0
        Me.TxtCode.SLFPwdStrengthText = Nothing
        Me.TxtCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtCode.SLFSearchBoxText = "Type then press Enter"
        Me.TxtCode.SLFSQLText = ""
        Me.TxtCode.SLFTanpaSpasi = True
        Me.TxtCode.SLFValidasiField = Nothing
        Me.TxtCode.TabIndex = 3
        Me.TxtCode.Tag = "txt"
        '
        'ChkLocked
        '
        Me.ChkLocked.AutoSize = True
        Me.ChkLocked.BackColor = System.Drawing.Color.Transparent
        Me.ChkLocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkLocked.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkLocked.Location = New System.Drawing.Point(162, 216)
        Me.ChkLocked.Name = "ChkLocked"
        Me.ChkLocked.Size = New System.Drawing.Size(97, 25)
        Me.ChkLocked.TabIndex = 7
        Me.ChkLocked.Text = "Is Locked?"
        Me.ChkLocked.UseVisualStyleBackColor = False
        '
        'CboGroup
        '
        Me.CboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboGroup.FormattingEnabled = True
        Me.CboGroup.Location = New System.Drawing.Point(164, 45)
        Me.CboGroup.Name = "CboGroup"
        Me.CboGroup.Size = New System.Drawing.Size(206, 29)
        Me.CboGroup.TabIndex = 2
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDescription.Location = New System.Drawing.Point(164, 150)
        Me.TxtDescription.MaxLength = 255
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(332, 29)
        Me.TxtDescription.SLFAutoTrim = True
        Me.TxtDescription.SLFHarusDiisi = True
        Me.TxtDescription.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDescription.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDescription.SLFHightlightSaatFokus = False
        Me.TxtDescription.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDescription.SLFIsBlank = True
        Me.TxtDescription.SLFIsSearchBox = False
        Me.TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtDescription.SLFPilihSemuaSaatFokus = False
        Me.TxtDescription.SLFPwdLengthMin = 8
        Me.TxtDescription.SLFPwdStrengthCalculate = False
        Me.TxtDescription.SLFPwdStrengthScore = 0
        Me.TxtDescription.SLFPwdStrengthText = Nothing
        Me.TxtDescription.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDescription.SLFSearchBoxText = "Type then press Enter"
        Me.TxtDescription.SLFSQLText = ""
        Me.TxtDescription.SLFTanpaSpasi = False
        Me.TxtDescription.SLFValidasiField = Nothing
        Me.TxtDescription.TabIndex = 5
        Me.TxtDescription.Tag = "txt"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtName.Location = New System.Drawing.Point(164, 115)
        Me.TxtName.MaxLength = 255
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(229, 29)
        Me.TxtName.SLFAutoTrim = True
        Me.TxtName.SLFHarusDiisi = True
        Me.TxtName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtName.SLFHightlightSaatFokus = False
        Me.TxtName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtName.SLFIsBlank = True
        Me.TxtName.SLFIsSearchBox = False
        Me.TxtName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtName.SLFPilihSemuaSaatFokus = True
        Me.TxtName.SLFPwdLengthMin = 8
        Me.TxtName.SLFPwdStrengthCalculate = False
        Me.TxtName.SLFPwdStrengthScore = 0
        Me.TxtName.SLFPwdStrengthText = Nothing
        Me.TxtName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtName.SLFSearchBoxText = "Type then press Enter"
        Me.TxtName.SLFSQLText = ""
        Me.TxtName.SLFTanpaSpasi = False
        Me.TxtName.SLFValidasiField = Nothing
        Me.TxtName.TabIndex = 4
        Me.TxtName.Tag = "txt"
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtID.Location = New System.Drawing.Point(164, 10)
        Me.TxtID.MaxLength = 255
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(332, 29)
        Me.TxtID.SLFAutoTrim = False
        Me.TxtID.SLFHarusDiisi = False
        Me.TxtID.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtID.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtID.SLFHightlightSaatFokus = False
        Me.TxtID.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtID.SLFIsBlank = True
        Me.TxtID.SLFIsSearchBox = False
        Me.TxtID.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtID.SLFPilihSemuaSaatFokus = False
        Me.TxtID.SLFPwdLengthMin = 8
        Me.TxtID.SLFPwdStrengthCalculate = False
        Me.TxtID.SLFPwdStrengthScore = 0
        Me.TxtID.SLFPwdStrengthText = Nothing
        Me.TxtID.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtID.SLFSearchBoxText = "Type then press Enter"
        Me.TxtID.SLFSQLText = ""
        Me.TxtID.SLFTanpaSpasi = False
        Me.TxtID.SLFValidasiField = Nothing
        Me.TxtID.TabIndex = 1
        Me.TxtID.Tag = "txt"
        '
        'tpPermissions
        '
        Me.tpPermissions.Controls.Add(Me.GbxAccessBy)
        Me.tpPermissions.Location = New System.Drawing.Point(4, 30)
        Me.tpPermissions.Name = "tpPermissions"
        Me.tpPermissions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPermissions.Size = New System.Drawing.Size(536, 248)
        Me.tpPermissions.TabIndex = 1
        Me.tpPermissions.Text = "Permissions"
        Me.tpPermissions.UseVisualStyleBackColor = True
        '
        'GbxAccessBy
        '
        Me.GbxAccessBy.Controls.Add(Me.DgnUserRoles)
        Me.GbxAccessBy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbxAccessBy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GbxAccessBy.Location = New System.Drawing.Point(3, 3)
        Me.GbxAccessBy.Name = "GbxAccessBy"
        Me.GbxAccessBy.Size = New System.Drawing.Size(530, 242)
        Me.GbxAccessBy.TabIndex = 0
        Me.GbxAccessBy.TabStop = False
        Me.GbxAccessBy.Text = "User or roles"
        '
        'DgnUserRoles
        '
        Me.DgnUserRoles.AllowUserToAddRows = False
        Me.DgnUserRoles.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.DgnUserRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnUserRoles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnUserRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnUserRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnUserRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnUserRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnUserRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgnUserRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnUserRoles.EnableHeadersVisualStyles = False
        Me.DgnUserRoles.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnUserRoles.Location = New System.Drawing.Point(3, 25)
        Me.DgnUserRoles.Name = "DgnUserRoles"
        Me.DgnUserRoles.ReadOnly = True
        Me.DgnUserRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnUserRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnUserRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnUserRoles.Size = New System.Drawing.Size(524, 214)
        Me.DgnUserRoles.SLFGroupFirstRows = False
        Me.DgnUserRoles.SLFGunakanNomorBaris = False
        Me.DgnUserRoles.StandardTab = True
        Me.DgnUserRoles.TabIndex = 0
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(7, 10)
        Me.ULbl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Module ID"
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1017
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(7, 45)
        Me.ULbl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Group"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1018
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(7, 80)
        Me.ULbl3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Code"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1019
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(7, 115)
        Me.ULbl4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Module Name"
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1020
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(7, 150)
        Me.ULbl5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 29)
        Me.ULbl5.SLFText = "Description"
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 1021
        '
        'MODS_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(568, 420)
        Me.KeyPreview = True
        Me.Name = "MODS_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.Tbctl1.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        Me.tpPermissions.ResumeLayout(False)
        Me.GbxAccessBy.ResumeLayout(False)
        CType(Me.DgnUserRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents Tbctl1 As CMCv.tbctl
    Friend WithEvents tpGeneral As TabPage
    Friend WithEvents TxtCode As CMCv.txt
    Friend WithEvents ChkLocked As CMCv.chk
    Friend WithEvents CboGroup As CMCv.cbo
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents TxtName As CMCv.txt
    Friend WithEvents TxtID As CMCv.txt
    Friend WithEvents tpPermissions As TabPage
    Friend WithEvents GbxAccessBy As CMCv.gbx
    Friend WithEvents DgnUserRoles As CMCv.dgn
    Friend WithEvents ChkSystem As CMCv.chk
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
End Class
