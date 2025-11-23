<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CONN_Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONN_Editor))
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        TbctlBasic = New tbctl(components)
        tp1_ = New TabPage()
        CboDBEngine = New cbo(components)
        ULbl1 = New ULbl()
        ULbl_DatabaseName = New ULbl()
        TxtDatabaseName = New txt(components)
        ChkDefault = New chk(components)
        TxtPassword = New txt(components)
        TxtUsername = New txt(components)
        ULbl_Password = New ULbl()
        ULbl_Username = New ULbl()
        ULbl_Port = New ULbl()
        TxtPort = New txt(components)
        ULbl_Address = New ULbl()
        ULbl_Name = New ULbl()
        TxtConnectionName = New txt(components)
        TxtAddress = New txt(components)
        Btn_Test = New btn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlBasic.SuspendLayout()
        tp1_.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn_Test)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 375)
        PnlBottomButton.Margin = New Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New Size(565, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn_Test, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(5, 3, 5, 3)
        pnl_.Size = New Size(565, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TbctlBasic)
        SLFPanel.Margin = New Padding(5, 3, 5, 3)
        SLFPanel.Size = New Size(565, 433)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TbctlBasic, 0)
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
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(311, 8)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.TabIndex = 10
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
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(435, 8)
        BtnCancel.Margin = New Padding(4, 3, 4, 3)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(117, 46)
        BtnCancel.TabIndex = 11
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' TbctlBasic
        ' 
        TbctlBasic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TbctlBasic.Controls.Add(tp1_)
        TbctlBasic.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlBasic.Location = New Point(14, 7)
        TbctlBasic.Margin = New Padding(4, 3, 4, 3)
        TbctlBasic.Name = "TbctlBasic"
        TbctlBasic.SelectedIndex = 0
        TbctlBasic.Size = New Size(537, 361)
        TbctlBasic.TabIndex = 997
        ' 
        ' tp1_
        ' 
        tp1_.AutoScroll = True
        tp1_.Controls.Add(CboDBEngine)
        tp1_.Controls.Add(ULbl1)
        tp1_.Controls.Add(ULbl_DatabaseName)
        tp1_.Controls.Add(TxtDatabaseName)
        tp1_.Controls.Add(ChkDefault)
        tp1_.Controls.Add(TxtPassword)
        tp1_.Controls.Add(TxtUsername)
        tp1_.Controls.Add(ULbl_Password)
        tp1_.Controls.Add(ULbl_Username)
        tp1_.Controls.Add(ULbl_Port)
        tp1_.Controls.Add(TxtPort)
        tp1_.Controls.Add(ULbl_Address)
        tp1_.Controls.Add(ULbl_Name)
        tp1_.Controls.Add(TxtConnectionName)
        tp1_.Controls.Add(TxtAddress)
        tp1_.Location = New Point(4, 30)
        tp1_.Margin = New Padding(4, 3, 4, 3)
        tp1_.Name = "tp1_"
        tp1_.Padding = New Padding(4, 3, 4, 3)
        tp1_.Size = New Size(529, 327)
        tp1_.TabIndex = 0
        tp1_.Text = "CONFIG"
        tp1_.UseVisualStyleBackColor = True
        ' 
        ' CboDBEngine
        ' 
        CboDBEngine.DropDownStyle = ComboBoxStyle.DropDownList
        CboDBEngine.FlatStyle = FlatStyle.Flat
        CboDBEngine.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboDBEngine.FormattingEnabled = True
        CboDBEngine.Items.AddRange(New Object() {"MYSQL", "SQL SERVER"})
        CboDBEngine.Location = New Point(214, 65)
        CboDBEngine.Name = "CboDBEngine"
        CboDBEngine.Size = New Size(290, 29)
        CboDBEngine.TabIndex = 2
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.AliceBlue
        ULbl1.Location = New Point(8, 65)
        ULbl1.Margin = New Padding(4, 3, 4, 3)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(197, 24)
        ULbl1.SLFText = "DB Engine"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl1.TabIndex = 1010
        ' 
        ' ULbl_DatabaseName
        ' 
        ULbl_DatabaseName.BackColor = Color.MistyRose
        ULbl_DatabaseName.Location = New Point(8, 269)
        ULbl_DatabaseName.Margin = New Padding(5, 6, 5, 6)
        ULbl_DatabaseName.Name = "ULbl_DatabaseName"
        ULbl_DatabaseName.Size = New Size(197, 23)
        ULbl_DatabaseName.SLFText = "Database Name"
        ULbl_DatabaseName.SLFTextAdjuster = False
        ULbl_DatabaseName.SLFTextBorder = False
        ULbl_DatabaseName.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Red
        ULbl_DatabaseName.TabIndex = 1008
        ' 
        ' TxtDatabaseName
        ' 
        TxtDatabaseName.BackColor = Color.White
        TxtDatabaseName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDatabaseName.Location = New Point(214, 269)
        TxtDatabaseName.Margin = New Padding(4, 3, 4, 3)
        TxtDatabaseName.MaxLength = 255
        TxtDatabaseName.Name = "TxtDatabaseName"
        TxtDatabaseName.Size = New Size(290, 29)
        TxtDatabaseName.TabIndex = 7
        TxtDatabaseName.Tag = "txt"
        TxtDatabaseName.XOAutoTrim = True
        TxtDatabaseName.XOHarusDiisi = True
        TxtDatabaseName.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDatabaseName.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDatabaseName.XOHightlightSaatFokus = True
        TxtDatabaseName.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDatabaseName.XOIsBlank = True
        TxtDatabaseName.XOIsSearchBox = False
        TxtDatabaseName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtDatabaseName.XOPilihSemuaSaatFokus = False
        TxtDatabaseName.XOPwdLengthMin = 8
        TxtDatabaseName.XOPwdStrengthCalculate = False
        TxtDatabaseName.XOPwdStrengthScore = 0
        TxtDatabaseName.XOPwdStrengthText = Nothing
        TxtDatabaseName.XORestriction = ControlCodeBase.enuRestriction.None
        TxtDatabaseName.XOSearchBoxText = "Type then press Enter"
        TxtDatabaseName.XOSQLText = ""
        TxtDatabaseName.XOTanpaSpasi = False
        TxtDatabaseName.XOValidasiField = Nothing
        ' 
        ' ChkDefault
        ' 
        ChkDefault.AutoSize = True
        ChkDefault.BackColor = Color.Transparent
        ChkDefault.FlatStyle = FlatStyle.Flat
        ChkDefault.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkDefault.Location = New Point(214, 307)
        ChkDefault.Margin = New Padding(4, 3, 4, 3)
        ChkDefault.Name = "ChkDefault"
        ChkDefault.Size = New Size(204, 25)
        ChkDefault.TabIndex = 9
        ChkDefault.Text = "Set as Default Connection"
        ChkDefault.UseVisualStyleBackColor = False
        ' 
        ' TxtPassword
        ' 
        TxtPassword.BackColor = Color.White
        TxtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(214, 229)
        TxtPassword.Margin = New Padding(4, 3, 4, 3)
        TxtPassword.MaxLength = 255
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "●"c
        TxtPassword.Size = New Size(290, 29)
        TxtPassword.TabIndex = 6
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
        TxtPassword.XOPilihSemuaSaatFokus = False
        TxtPassword.XOPwdLengthMin = 8
        TxtPassword.XOPwdStrengthCalculate = False
        TxtPassword.XOPwdStrengthScore = 0
        TxtPassword.XOPwdStrengthText = Nothing
        TxtPassword.XORestriction = ControlCodeBase.enuRestriction.None
        TxtPassword.XOSearchBoxText = "Type then press Enter"
        TxtPassword.XOSQLText = ""
        TxtPassword.XOTanpaSpasi = False
        TxtPassword.XOValidasiField = Nothing
        ' 
        ' TxtUsername
        ' 
        TxtUsername.BackColor = Color.White
        TxtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(214, 188)
        TxtUsername.Margin = New Padding(4, 3, 4, 3)
        TxtUsername.MaxLength = 255
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(290, 29)
        TxtUsername.TabIndex = 5
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
        TxtUsername.XOPilihSemuaSaatFokus = False
        TxtUsername.XOPwdLengthMin = 8
        TxtUsername.XOPwdStrengthCalculate = False
        TxtUsername.XOPwdStrengthScore = 0
        TxtUsername.XOPwdStrengthText = Nothing
        TxtUsername.XORestriction = ControlCodeBase.enuRestriction.None
        TxtUsername.XOSearchBoxText = "Type then press Enter"
        TxtUsername.XOSQLText = ""
        TxtUsername.XOTanpaSpasi = False
        TxtUsername.XOValidasiField = Nothing
        ' 
        ' ULbl_Password
        ' 
        ULbl_Password.BackColor = Color.AliceBlue
        ULbl_Password.Location = New Point(8, 229)
        ULbl_Password.Margin = New Padding(5, 6, 5, 6)
        ULbl_Password.Name = "ULbl_Password"
        ULbl_Password.Size = New Size(197, 23)
        ULbl_Password.SLFText = "Password"
        ULbl_Password.SLFTextAdjuster = False
        ULbl_Password.SLFTextBorder = False
        ULbl_Password.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Password.TabIndex = 1005
        ' 
        ' ULbl_Username
        ' 
        ULbl_Username.BackColor = Color.AliceBlue
        ULbl_Username.Location = New Point(8, 188)
        ULbl_Username.Margin = New Padding(5, 6, 5, 6)
        ULbl_Username.Name = "ULbl_Username"
        ULbl_Username.Size = New Size(197, 23)
        ULbl_Username.SLFText = "Username"
        ULbl_Username.SLFTextAdjuster = False
        ULbl_Username.SLFTextBorder = False
        ULbl_Username.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Username.TabIndex = 1004
        ' 
        ' ULbl_Port
        ' 
        ULbl_Port.BackColor = Color.AliceBlue
        ULbl_Port.Location = New Point(8, 148)
        ULbl_Port.Margin = New Padding(5, 6, 5, 6)
        ULbl_Port.Name = "ULbl_Port"
        ULbl_Port.Size = New Size(197, 23)
        ULbl_Port.SLFText = "Port"
        ULbl_Port.SLFTextAdjuster = False
        ULbl_Port.SLFTextBorder = False
        ULbl_Port.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Port.TabIndex = 1003
        ' 
        ' TxtPort
        ' 
        TxtPort.BackColor = Color.White
        TxtPort.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPort.Location = New Point(214, 148)
        TxtPort.Margin = New Padding(4, 3, 4, 3)
        TxtPort.MaxLength = 255
        TxtPort.Name = "TxtPort"
        TxtPort.Size = New Size(114, 29)
        TxtPort.TabIndex = 4
        TxtPort.Tag = "txt"
        TxtPort.TextAlign = HorizontalAlignment.Center
        TxtPort.XOAutoTrim = True
        TxtPort.XOHarusDiisi = True
        TxtPort.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPort.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPort.XOHightlightSaatFokus = True
        TxtPort.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPort.XOIsBlank = True
        TxtPort.XOIsSearchBox = False
        TxtPort.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPort.XOPilihSemuaSaatFokus = False
        TxtPort.XOPwdLengthMin = 8
        TxtPort.XOPwdStrengthCalculate = False
        TxtPort.XOPwdStrengthScore = 0
        TxtPort.XOPwdStrengthText = Nothing
        TxtPort.XORestriction = ControlCodeBase.enuRestriction.OnlyNumber
        TxtPort.XOSearchBoxText = "Type then press Enter"
        TxtPort.XOSQLText = ""
        TxtPort.XOTanpaSpasi = False
        TxtPort.XOValidasiField = Nothing
        ' 
        ' ULbl_Address
        ' 
        ULbl_Address.BackColor = Color.AliceBlue
        ULbl_Address.Location = New Point(8, 107)
        ULbl_Address.Margin = New Padding(5, 6, 5, 6)
        ULbl_Address.Name = "ULbl_Address"
        ULbl_Address.Size = New Size(197, 23)
        ULbl_Address.SLFText = "Address"
        ULbl_Address.SLFTextAdjuster = False
        ULbl_Address.SLFTextBorder = False
        ULbl_Address.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Address.TabIndex = 1001
        ' 
        ' ULbl_Name
        ' 
        ULbl_Name.BackColor = Color.AliceBlue
        ULbl_Name.Location = New Point(8, 23)
        ULbl_Name.Margin = New Padding(5, 6, 5, 6)
        ULbl_Name.Name = "ULbl_Name"
        ULbl_Name.Size = New Size(197, 23)
        ULbl_Name.SLFText = "Connection Name"
        ULbl_Name.SLFTextAdjuster = False
        ULbl_Name.SLFTextBorder = False
        ULbl_Name.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Default
        ULbl_Name.TabIndex = 1000
        ' 
        ' TxtConnectionName
        ' 
        TxtConnectionName.BackColor = Color.White
        TxtConnectionName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtConnectionName.Location = New Point(214, 23)
        TxtConnectionName.Margin = New Padding(4, 3, 4, 3)
        TxtConnectionName.MaxLength = 255
        TxtConnectionName.Name = "TxtConnectionName"
        TxtConnectionName.Size = New Size(290, 29)
        TxtConnectionName.TabIndex = 0
        TxtConnectionName.Tag = "txt"
        TxtConnectionName.XOAutoTrim = True
        TxtConnectionName.XOHarusDiisi = True
        TxtConnectionName.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtConnectionName.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtConnectionName.XOHightlightSaatFokus = True
        TxtConnectionName.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtConnectionName.XOIsBlank = True
        TxtConnectionName.XOIsSearchBox = False
        TxtConnectionName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtConnectionName.XOPilihSemuaSaatFokus = False
        TxtConnectionName.XOPwdLengthMin = 8
        TxtConnectionName.XOPwdStrengthCalculate = False
        TxtConnectionName.XOPwdStrengthScore = 0
        TxtConnectionName.XOPwdStrengthText = Nothing
        TxtConnectionName.XORestriction = ControlCodeBase.enuRestriction.None
        TxtConnectionName.XOSearchBoxText = "Type then press Enter"
        TxtConnectionName.XOSQLText = ""
        TxtConnectionName.XOTanpaSpasi = False
        TxtConnectionName.XOValidasiField = Nothing
        ' 
        ' TxtAddress
        ' 
        TxtAddress.BackColor = Color.White
        TxtAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAddress.Location = New Point(214, 107)
        TxtAddress.Margin = New Padding(4, 3, 4, 3)
        TxtAddress.MaxLength = 255
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(290, 29)
        TxtAddress.TabIndex = 3
        TxtAddress.Tag = "txt"
        TxtAddress.XOAutoTrim = True
        TxtAddress.XOHarusDiisi = True
        TxtAddress.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtAddress.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtAddress.XOHightlightSaatFokus = True
        TxtAddress.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtAddress.XOIsBlank = True
        TxtAddress.XOIsSearchBox = False
        TxtAddress.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
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
        ' Btn_Test
        ' 
        Btn_Test.BackColor = Color.Yellow
        Btn_Test.Cursor = Cursors.Hand
        Btn_Test.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(195), CByte(0))
        Btn_Test.FlatAppearance.BorderSize = 2
        Btn_Test.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(20))
        Btn_Test.FlatStyle = FlatStyle.Flat
        Btn_Test.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Test.ForeColor = Color.Black
        Btn_Test.Location = New Point(14, 8)
        Btn_Test.Margin = New Padding(4, 3, 4, 3)
        Btn_Test.Name = "Btn_Test"
        Btn_Test.Size = New Size(117, 46)
        Btn_Test.TabIndex = 12
        Btn_Test.Text = "Test"
        Btn_Test.UseVisualStyleBackColor = False
        Btn_Test.XOJenisTombol = ControlCodeBase.enuJenisTombol.Warning
        Btn_Test.XOTampilkanFocusBorder = False
        Btn_Test.XOValidasiSemuaInput = False
        Btn_Test.XOValidasiSemuaInputTag = Nothing
        ' 
        ' CONN_Editor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(565, 516)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "CONN_Editor"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlBasic.ResumeLayout(False)
        tp1_.ResumeLayout(False)
        tp1_.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnSave As btn
    Friend WithEvents BtnCancel As btn
    Friend WithEvents TbctlBasic As tbctl
    Friend WithEvents tp1_ As TabPage
    Friend WithEvents TxtAddress As txt
    Friend WithEvents TxtConnectionName As txt
    Friend WithEvents TxtPort As txt
    Friend WithEvents ULbl_Address As ULbl
    Friend WithEvents ULbl_Name As ULbl
    Friend WithEvents ULbl_Password As ULbl
    Friend WithEvents ULbl_Username As ULbl
    Friend WithEvents ULbl_Port As ULbl
    Friend WithEvents TxtPassword As txt
    Friend WithEvents TxtUsername As txt
    Friend WithEvents Btn_Test As btn
    Friend WithEvents ChkDefault As chk
    Friend WithEvents TxtDatabaseName As txt
    Friend WithEvents ULbl_DatabaseName As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents CboDBEngine As cbo
End Class
