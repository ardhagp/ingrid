Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMconnEditor
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMconnEditor))
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            TbctlBasic = New CMCv.UI.Control.tbctl(components)
            tp1_ = New TabPage()
            ChkIsMasked = New CMCv.UI.Control.Chk(components)
            btnExport = New CMCv.UI.Control.Btn(components)
            CboDBEngine = New CMCv.UI.Control.cbo(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl_DatabaseName = New CMCv.UI.Control.ULbl()
            TxtDatabaseName = New CMCv.UI.Control.txt(components)
            ChkDefault = New CMCv.UI.Control.Chk(components)
            TxtPassword = New CMCv.UI.Control.txt(components)
            TxtUsername = New CMCv.UI.Control.txt(components)
            ULbl_Password = New CMCv.UI.Control.ULbl()
            ULbl_Username = New CMCv.UI.Control.ULbl()
            ULbl_Port = New CMCv.UI.Control.ULbl()
            TxtPort = New CMCv.UI.Control.txt(components)
            ULbl_Address = New CMCv.UI.Control.ULbl()
            ULbl_Name = New CMCv.UI.Control.ULbl()
            TxtConnectionName = New CMCv.UI.Control.txt(components)
            TxtAddress = New CMCv.UI.Control.txt(components)
            tp2_ = New TabPage()
            btnImport = New CMCv.UI.Control.Btn(components)
            btnSaveAs = New CMCv.UI.Control.Btn(components)
            Pnl1 = New CMCv.UI.Control.pnl(components)
            txtImportContent = New CMCv.UI.Control.txt(components)
            btnGet = New CMCv.UI.Control.Btn(components)
            ULbl2 = New CMCv.UI.Control.ULbl()
            txtImportCode = New CMCv.UI.Control.txt(components)
            Btn_Test = New CMCv.UI.Control.Btn(components)
            TtAllComponents = New ToolTip(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            TbctlBasic.SuspendLayout()
            tp1_.SuspendLayout()
            tp2_.SuspendLayout()
            Pnl1.SuspendLayout()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(Btn_Test)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 631)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(807, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(Btn_Test, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(807, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TbctlBasic)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(807, 728)
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
            BtnSave.Location = New Point(444, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 10
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
            BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(621, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 11
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' TbctlBasic
            ' 
            TbctlBasic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            TbctlBasic.Controls.Add(tp1_)
            TbctlBasic.Controls.Add(tp2_)
            TbctlBasic.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlBasic.Location = New Point(20, 12)
            TbctlBasic.Margin = New Padding(6, 5, 6, 5)
            TbctlBasic.Name = "TbctlBasic"
            TbctlBasic.SelectedIndex = 0
            TbctlBasic.Size = New Size(767, 608)
            TbctlBasic.TabIndex = 997
            ' 
            ' tp1_
            ' 
            tp1_.AutoScroll = True
            tp1_.Controls.Add(ChkIsMasked)
            tp1_.Controls.Add(btnExport)
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
            tp1_.Location = New Point(4, 41)
            tp1_.Margin = New Padding(6, 5, 6, 5)
            tp1_.Name = "tp1_"
            tp1_.Padding = New Padding(6, 5, 6, 5)
            tp1_.Size = New Size(759, 563)
            tp1_.TabIndex = 0
            tp1_.Text = "CONFIG"
            tp1_.UseVisualStyleBackColor = True
            ' 
            ' ChkIsMasked
            ' 
            ChkIsMasked.AutoSize = True
            ChkIsMasked.BackColor = Color.Transparent
            ChkIsMasked.FlatStyle = FlatStyle.Flat
            ChkIsMasked.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ChkIsMasked.Location = New Point(306, 556)
            ChkIsMasked.Name = "ChkIsMasked"
            ChkIsMasked.Size = New Size(288, 36)
            ChkIsMasked.TabIndex = 10
            ChkIsMasked.Text = "Unreadable after saving"
            ChkIsMasked.UseVisualStyleBackColor = False
            ' 
            ' btnExport
            ' 
            btnExport.BackColor = Color.RoyalBlue
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            btnExport.FlatAppearance.BorderSize = 2
            btnExport.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            btnExport.FlatStyle = FlatStyle.Flat
            btnExport.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            btnExport.ForeColor = Color.White
            btnExport.Location = New Point(569, 615)
            btnExport.Name = "btnExport"
            btnExport.Size = New Size(150, 60)
            btnExport.TabIndex = 11
            btnExport.Text = "Export"
            btnExport.UseVisualStyleBackColor = False
            btnExport.XOButtonType = ControlCodeBase.buttonType.Default
            btnExport.XOShowBorderOnFocus = False
            btnExport.XOValidateAllInput = False
            btnExport.XOValidateAllInputTag = Nothing
            ' 
            ' CboDBEngine
            ' 
            CboDBEngine.DropDownStyle = ComboBoxStyle.DropDownList
            CboDBEngine.FlatStyle = FlatStyle.Flat
            CboDBEngine.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            CboDBEngine.FormattingEnabled = True
            CboDBEngine.Location = New Point(306, 108)
            CboDBEngine.Margin = New Padding(4, 5, 4, 5)
            CboDBEngine.Name = "CboDBEngine"
            CboDBEngine.Size = New Size(413, 40)
            CboDBEngine.TabIndex = 2
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.AliceBlue
            ULbl1.Location = New Point(16, 108)
            ULbl1.Margin = New Padding(10, 8, 10, 8)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(272, 40)
            ULbl1.SLFText = "DB Engine"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
            ULbl1.TabIndex = 1010
            ' 
            ' ULbl_DatabaseName
            ' 
            ULbl_DatabaseName.BackColor = Color.MistyRose
            ULbl_DatabaseName.Location = New Point(16, 448)
            ULbl_DatabaseName.Margin = New Padding(12, 17, 12, 17)
            ULbl_DatabaseName.Name = "ULbl_DatabaseName"
            ULbl_DatabaseName.Size = New Size(272, 39)
            ULbl_DatabaseName.SLFText = "Database Name"
            ULbl_DatabaseName.SLFTextAdjuster = False
            ULbl_DatabaseName.SLFTextBorder = False
            ULbl_DatabaseName.SLFWarnaLabel = ControlCodeBase.JenisLabel.Red
            ULbl_DatabaseName.TabIndex = 1008
            ' 
            ' TxtDatabaseName
            ' 
            TxtDatabaseName.BackColor = Color.White
            TxtDatabaseName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDatabaseName.Location = New Point(306, 448)
            TxtDatabaseName.Margin = New Padding(6, 5, 6, 5)
            TxtDatabaseName.MaxLength = 255
            TxtDatabaseName.Name = "TxtDatabaseName"
            TxtDatabaseName.Size = New Size(413, 39)
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
            TxtDatabaseName.XORestriction = ControlCodeBase.enuRestriction.TextAndNumber
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
            ChkDefault.Location = New Point(306, 512)
            ChkDefault.Margin = New Padding(6, 5, 6, 5)
            ChkDefault.Name = "ChkDefault"
            ChkDefault.Size = New Size(313, 36)
            ChkDefault.TabIndex = 9
            ChkDefault.Text = "Set as Default Connection"
            ChkDefault.UseVisualStyleBackColor = False
            ' 
            ' TxtPassword
            ' 
            TxtPassword.BackColor = Color.White
            TxtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPassword.Location = New Point(306, 382)
            TxtPassword.Margin = New Padding(6, 5, 6, 5)
            TxtPassword.MaxLength = 255
            TxtPassword.Name = "TxtPassword"
            TxtPassword.PasswordChar = "●"c
            TxtPassword.Size = New Size(413, 39)
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
            TxtUsername.Location = New Point(306, 313)
            TxtUsername.Margin = New Padding(6, 5, 6, 5)
            TxtUsername.MaxLength = 255
            TxtUsername.Name = "TxtUsername"
            TxtUsername.Size = New Size(413, 39)
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
            TxtUsername.XORestriction = ControlCodeBase.enuRestriction.TextAndNumber
            TxtUsername.XOSearchBoxText = "Type then press Enter"
            TxtUsername.XOSQLText = ""
            TxtUsername.XOTanpaSpasi = False
            TxtUsername.XOValidasiField = Nothing
            ' 
            ' ULbl_Password
            ' 
            ULbl_Password.BackColor = Color.AliceBlue
            ULbl_Password.Location = New Point(16, 386)
            ULbl_Password.Margin = New Padding(12, 17, 12, 17)
            ULbl_Password.Name = "ULbl_Password"
            ULbl_Password.Size = New Size(272, 35)
            ULbl_Password.SLFText = "Password"
            ULbl_Password.SLFTextAdjuster = False
            ULbl_Password.SLFTextBorder = False
            ULbl_Password.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
            ULbl_Password.TabIndex = 1005
            ' 
            ' ULbl_Username
            ' 
            ULbl_Username.BackColor = Color.AliceBlue
            ULbl_Username.Location = New Point(16, 313)
            ULbl_Username.Margin = New Padding(12, 17, 12, 17)
            ULbl_Username.Name = "ULbl_Username"
            ULbl_Username.Size = New Size(272, 39)
            ULbl_Username.SLFText = "Username"
            ULbl_Username.SLFTextAdjuster = False
            ULbl_Username.SLFTextBorder = False
            ULbl_Username.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
            ULbl_Username.TabIndex = 1004
            ' 
            ' ULbl_Port
            ' 
            ULbl_Port.BackColor = Color.AliceBlue
            ULbl_Port.Location = New Point(16, 247)
            ULbl_Port.Margin = New Padding(12, 17, 12, 17)
            ULbl_Port.Name = "ULbl_Port"
            ULbl_Port.Size = New Size(272, 39)
            ULbl_Port.SLFText = "Port"
            ULbl_Port.SLFTextAdjuster = False
            ULbl_Port.SLFTextBorder = False
            ULbl_Port.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
            ULbl_Port.TabIndex = 1003
            ' 
            ' TxtPort
            ' 
            TxtPort.BackColor = Color.White
            TxtPort.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPort.Location = New Point(306, 247)
            TxtPort.Margin = New Padding(6, 5, 6, 5)
            TxtPort.MaxLength = 255
            TxtPort.Name = "TxtPort"
            TxtPort.Size = New Size(161, 39)
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
            ULbl_Address.Location = New Point(16, 178)
            ULbl_Address.Margin = New Padding(12, 17, 12, 17)
            ULbl_Address.Name = "ULbl_Address"
            ULbl_Address.Size = New Size(272, 39)
            ULbl_Address.SLFText = "Address"
            ULbl_Address.SLFTextAdjuster = False
            ULbl_Address.SLFTextBorder = False
            ULbl_Address.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
            ULbl_Address.TabIndex = 1001
            ' 
            ' ULbl_Name
            ' 
            ULbl_Name.BackColor = Color.AliceBlue
            ULbl_Name.Location = New Point(16, 38)
            ULbl_Name.Margin = New Padding(12, 17, 12, 17)
            ULbl_Name.Name = "ULbl_Name"
            ULbl_Name.Size = New Size(272, 39)
            ULbl_Name.SLFText = "Connection Name"
            ULbl_Name.SLFTextAdjuster = False
            ULbl_Name.SLFTextBorder = False
            ULbl_Name.SLFWarnaLabel = ControlCodeBase.JenisLabel.Default
            ULbl_Name.TabIndex = 1000
            ' 
            ' TxtConnectionName
            ' 
            TxtConnectionName.BackColor = Color.White
            TxtConnectionName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtConnectionName.Location = New Point(306, 38)
            TxtConnectionName.Margin = New Padding(6, 5, 6, 5)
            TxtConnectionName.MaxLength = 255
            TxtConnectionName.Name = "TxtConnectionName"
            TxtConnectionName.Size = New Size(413, 39)
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
            TxtAddress.Location = New Point(306, 178)
            TxtAddress.Margin = New Padding(6, 5, 6, 5)
            TxtAddress.MaxLength = 255
            TxtAddress.Name = "TxtAddress"
            TxtAddress.Size = New Size(413, 39)
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
            ' tp2_
            ' 
            tp2_.AutoScroll = True
            tp2_.Controls.Add(btnImport)
            tp2_.Controls.Add(btnSaveAs)
            tp2_.Controls.Add(Pnl1)
            tp2_.Controls.Add(btnGet)
            tp2_.Controls.Add(ULbl2)
            tp2_.Controls.Add(txtImportCode)
            tp2_.Location = New Point(4, 41)
            tp2_.Name = "tp2_"
            tp2_.Padding = New Padding(3)
            tp2_.Size = New Size(759, 563)
            tp2_.TabIndex = 1
            tp2_.Text = "IMPORT / EXPORT"
            tp2_.UseVisualStyleBackColor = True
            ' 
            ' btnImport
            ' 
            btnImport.BackColor = Color.RoyalBlue
            btnImport.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            btnImport.FlatAppearance.BorderSize = 2
            btnImport.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            btnImport.FlatStyle = FlatStyle.Flat
            btnImport.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            btnImport.ForeColor = Color.White
            btnImport.Location = New Point(6, 467)
            btnImport.Name = "btnImport"
            btnImport.Size = New Size(150, 60)
            btnImport.TabIndex = 6
            btnImport.Text = "Import"
            btnImport.UseVisualStyleBackColor = False
            btnImport.XOButtonType = ControlCodeBase.buttonType.Default
            btnImport.XOShowBorderOnFocus = False
            btnImport.XOValidateAllInput = False
            btnImport.XOValidateAllInputTag = Nothing
            ' 
            ' btnSaveAs
            ' 
            btnSaveAs.BackColor = Color.RoyalBlue
            btnSaveAs.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            btnSaveAs.FlatAppearance.BorderSize = 2
            btnSaveAs.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            btnSaveAs.FlatStyle = FlatStyle.Flat
            btnSaveAs.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            btnSaveAs.ForeColor = Color.White
            btnSaveAs.Location = New Point(581, 467)
            btnSaveAs.Name = "btnSaveAs"
            btnSaveAs.Size = New Size(150, 60)
            btnSaveAs.TabIndex = 5
            btnSaveAs.Text = "Save As"
            btnSaveAs.UseVisualStyleBackColor = False
            btnSaveAs.XOButtonType = ControlCodeBase.buttonType.Default
            btnSaveAs.XOShowBorderOnFocus = False
            btnSaveAs.XOValidateAllInput = False
            btnSaveAs.XOValidateAllInputTag = Nothing
            ' 
            ' Pnl1
            ' 
            Pnl1.Controls.Add(txtImportContent)
            Pnl1.Location = New Point(6, 72)
            Pnl1.Name = "Pnl1"
            Pnl1.Size = New Size(725, 389)
            Pnl1.TabIndex = 4
            ' 
            ' txtImportContent
            ' 
            txtImportContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            txtImportContent.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            txtImportContent.Location = New Point(3, 15)
            txtImportContent.MaxLength = 0
            txtImportContent.Multiline = True
            txtImportContent.Name = "txtImportContent"
            txtImportContent.Size = New Size(719, 371)
            txtImportContent.TabIndex = 3
            txtImportContent.Tag = "txt"
            txtImportContent.XOAutoTrim = False
            txtImportContent.XOHarusDiisi = False
            txtImportContent.XOHarusDiisiWarnaLatar = Color.LightPink
            txtImportContent.XOHarusDiisiWarnaLatarDefault = Color.White
            txtImportContent.XOHightlightSaatFokus = True
            txtImportContent.XOHightlightSaatFokusWarna = Color.LightYellow
            txtImportContent.XOIsBlank = True
            txtImportContent.XOIsSearchBox = False
            txtImportContent.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            txtImportContent.XOPilihSemuaSaatFokus = False
            txtImportContent.XOPwdLengthMin = 8
            txtImportContent.XOPwdStrengthCalculate = False
            txtImportContent.XOPwdStrengthScore = 0
            txtImportContent.XOPwdStrengthText = Nothing
            txtImportContent.XORestriction = ControlCodeBase.enuRestriction.None
            txtImportContent.XOSearchBoxText = "Type then press Enter"
            txtImportContent.XOSQLText = ""
            txtImportContent.XOTanpaSpasi = False
            txtImportContent.XOValidasiField = Nothing
            ' 
            ' btnGet
            ' 
            btnGet.BackColor = Color.RoyalBlue
            btnGet.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            btnGet.FlatAppearance.BorderSize = 2
            btnGet.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            btnGet.FlatStyle = FlatStyle.Flat
            btnGet.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            btnGet.ForeColor = Color.White
            btnGet.Location = New Point(581, 6)
            btnGet.Name = "btnGet"
            btnGet.Size = New Size(150, 60)
            btnGet.TabIndex = 2
            btnGet.Text = "Get"
            btnGet.UseVisualStyleBackColor = False
            btnGet.XOButtonType = ControlCodeBase.buttonType.Default
            btnGet.XOShowBorderOnFocus = False
            btnGet.XOValidateAllInput = False
            btnGet.XOValidateAllInputTag = Nothing
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(9, 17)
            ULbl2.Margin = New Padding(6, 8, 6, 8)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(231, 39)
            ULbl2.SLFText = "Connection Code"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1
            ' 
            ' txtImportCode
            ' 
            txtImportCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            txtImportCode.Location = New Point(249, 17)
            txtImportCode.MaxLength = 255
            txtImportCode.Name = "txtImportCode"
            txtImportCode.Size = New Size(326, 39)
            txtImportCode.TabIndex = 0
            txtImportCode.Tag = "txt"
            txtImportCode.XOAutoTrim = False
            txtImportCode.XOHarusDiisi = False
            txtImportCode.XOHarusDiisiWarnaLatar = Color.LightPink
            txtImportCode.XOHarusDiisiWarnaLatarDefault = Color.White
            txtImportCode.XOHightlightSaatFokus = True
            txtImportCode.XOHightlightSaatFokusWarna = Color.LightYellow
            txtImportCode.XOIsBlank = False
            txtImportCode.XOIsSearchBox = False
            txtImportCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            txtImportCode.XOPilihSemuaSaatFokus = False
            txtImportCode.XOPwdLengthMin = 8
            txtImportCode.XOPwdStrengthCalculate = False
            txtImportCode.XOPwdStrengthScore = 0
            txtImportCode.XOPwdStrengthText = Nothing
            txtImportCode.XORestriction = ControlCodeBase.enuRestriction.TextAndNumber
            txtImportCode.XOSearchBoxText = "Type then press Enter"
            txtImportCode.XOSQLText = ""
            txtImportCode.XOTanpaSpasi = False
            txtImportCode.XOValidasiField = Nothing
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
            Btn_Test.Location = New Point(20, 13)
            Btn_Test.Margin = New Padding(6, 5, 6, 5)
            Btn_Test.Name = "Btn_Test"
            Btn_Test.Size = New Size(167, 77)
            Btn_Test.TabIndex = 12
            Btn_Test.Text = "Test"
            Btn_Test.UseVisualStyleBackColor = False
            Btn_Test.XOButtonType = ControlCodeBase.buttonType.Warning
            Btn_Test.XOShowBorderOnFocus = False
            Btn_Test.XOValidateAllInput = False
            Btn_Test.XOValidateAllInputTag = Nothing
            ' 
            ' TtAllComponents
            ' 
            TtAllComponents.IsBalloon = True
            TtAllComponents.ToolTipIcon = ToolTipIcon.Info
            ' 
            ' FRMconnEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(807, 860)
            ControlBox = False
            FormBorderStyle = FormBorderStyle.FixedSingle
            Icon = CType(resources.GetObject("$this.Icon"), Icon)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMconnEditor"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            TbctlBasic.ResumeLayout(False)
            tp1_.ResumeLayout(False)
            tp1_.PerformLayout()
            tp2_.ResumeLayout(False)
            tp2_.PerformLayout()
            Pnl1.ResumeLayout(False)
            Pnl1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents TbctlBasic As CMCv.UI.Control.tbctl
        Friend WithEvents tp1_ As TabPage
        Friend WithEvents TxtAddress As CMCv.UI.Control.txt
        Friend WithEvents TxtConnectionName As CMCv.UI.Control.txt
        Friend WithEvents TxtPort As CMCv.UI.Control.txt
        Friend WithEvents ULbl_Address As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl_Name As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl_Password As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl_Username As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl_Port As CMCv.UI.Control.ULbl
        Friend WithEvents TxtPassword As CMCv.UI.Control.txt
        Friend WithEvents TxtUsername As CMCv.UI.Control.txt
        Friend WithEvents Btn_Test As CMCv.UI.Control.Btn
        Friend WithEvents ChkDefault As CMCv.UI.Control.Chk
        Friend WithEvents TxtDatabaseName As CMCv.UI.Control.txt
        Friend WithEvents ULbl_DatabaseName As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents CboDBEngine As CMCv.UI.Control.cbo
        Friend WithEvents tp2_ As TabPage
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents txtImportCode As CMCv.UI.Control.txt
        Friend WithEvents btnGet As CMCv.UI.Control.Btn
        Friend WithEvents Pnl1 As CMCv.UI.Control.pnl
        Friend WithEvents txtImportContent As CMCv.UI.Control.txt
        Friend WithEvents btnExport As CMCv.UI.Control.Btn
        Friend WithEvents btnImport As CMCv.UI.Control.Btn
        Friend WithEvents btnSaveAs As CMCv.UI.Control.Btn
        Friend WithEvents ChkIsMasked As CMCv.UI.Control.Chk
        Friend WithEvents TtAllComponents As ToolTip
    End Class
End Namespace