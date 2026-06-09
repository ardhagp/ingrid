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
            TbctlBasic = New CMCv.UI.Control.Tbx(components)
            tp1_ = New TabPage()
            ULbl3 = New CMCv.UI.Control.ULbl()
            TxtClient = New CMCv.UI.Control.Txt(components)
            ChkIsMasked = New CMCv.UI.Control.Chk(components)
            btnExport = New CMCv.UI.Control.Btn(components)
            CboDBEngine = New CMCv.UI.Control.Cbo(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl_DatabaseName = New CMCv.UI.Control.ULbl()
            TxtDatabaseName = New CMCv.UI.Control.Txt(components)
            ChkDefault = New CMCv.UI.Control.Chk(components)
            TxtPassword = New CMCv.UI.Control.Txt(components)
            TxtUsername = New CMCv.UI.Control.Txt(components)
            ULbl_Password = New CMCv.UI.Control.ULbl()
            ULbl_Username = New CMCv.UI.Control.ULbl()
            ULbl_Port = New CMCv.UI.Control.ULbl()
            TxtPort = New CMCv.UI.Control.Txt(components)
            ULbl_Address = New CMCv.UI.Control.ULbl()
            ULbl_Name = New CMCv.UI.Control.ULbl()
            TxtConnectionName = New CMCv.UI.Control.Txt(components)
            TxtAddress = New CMCv.UI.Control.Txt(components)
            tp2_ = New TabPage()
            btnImport = New CMCv.UI.Control.Btn(components)
            btnSaveAs = New CMCv.UI.Control.Btn(components)
            Pnl1 = New CMCv.UI.Control.Pnl(components)
            txtImportContent = New CMCv.UI.Control.Txt(components)
            btnGet = New CMCv.UI.Control.Btn(components)
            ULbl2 = New CMCv.UI.Control.ULbl()
            txtImportCode = New CMCv.UI.Control.Txt(components)
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
            BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(444, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 10
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = ControlCodeBase.ButtonType.Yes
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
            BtnCancel.Location = New Point(621, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 11
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' TbctlBasic
            ' 
            TbctlBasic.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            TbctlBasic.Controls.Add(tp1_)
            TbctlBasic.Controls.Add(tp2_)
            TbctlBasic.Font = New Font("Segoe UI", 12F)
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
            tp1_.Controls.Add(ULbl3)
            tp1_.Controls.Add(TxtClient)
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
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.AliceBlue
            ULbl3.Location = New Point(16, 510)
            ULbl3.Margin = New Padding(5, 6, 5, 6)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(272, 35)
            ULbl3.TabIndex = 1012
            TtAllComponents.SetToolTip(ULbl3, "Test")
            ULbl3.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl3.XOText = "Client"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' TxtClient
            ' 
            TxtClient.Font = New Font("Segoe UI", 12F)
            TxtClient.Location = New Point(306, 510)
            TxtClient.MaxLength = 255
            TxtClient.Name = "TxtClient"
            TxtClient.Size = New Size(413, 39)
            TxtClient.TabIndex = 8
            TxtClient.Tag = "txt"
            TxtClient.XOAutoTrim = False
            TxtClient.XOHighlightColor = Color.LightYellow
            TxtClient.XOHighlightOnFocus = True
            TxtClient.XOIsBlank = True
            TxtClient.XOIsMandatory = False
            TxtClient.XOIsPlaceholder = True
            TxtClient.XOIsReplaceEmptyString = False
            TxtClient.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtClient.XOMandatoryBgColor = Color.LightPink
            TxtClient.XOMandatoryBgColorDefault = Color.White
            TxtClient.XOMandatoryMessage = Nothing
            TxtClient.XOPasswordLengthMin = 8
            TxtClient.XOPasswordStrengthCalc = False
            TxtClient.XOPasswordStrengthScore = 0
            TxtClient.XOPasswordStrengthText = Nothing
            TxtClient.XOPlaceholderText = "Usually filled with '@' + domain name"
            TxtClient.XORestriction = ControlCodeBase.EnumRestriction.None
            TxtClient.XOSelectOnFocus = False
            TxtClient.XOSqlText = ""
            ' 
            ' ChkIsMasked
            ' 
            ChkIsMasked.AutoSize = True
            ChkIsMasked.BackColor = Color.Transparent
            ChkIsMasked.FlatStyle = FlatStyle.Flat
            ChkIsMasked.Font = New Font("Segoe UI", 12F)
            ChkIsMasked.Location = New Point(306, 606)
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
            btnExport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            btnExport.ForeColor = Color.White
            btnExport.Location = New Point(569, 665)
            btnExport.Name = "btnExport"
            btnExport.Size = New Size(150, 60)
            btnExport.TabIndex = 11
            btnExport.Text = "Export"
            btnExport.UseVisualStyleBackColor = False
            btnExport.XOButtonType = ControlCodeBase.ButtonType.Default
            btnExport.XOShowBorderOnFocus = False
            btnExport.XOValidateAllInput = False
            btnExport.XOValidateAllInputTag = Nothing
            ' 
            ' CboDBEngine
            ' 
            CboDBEngine.DropDownStyle = ComboBoxStyle.DropDownList
            CboDBEngine.FlatStyle = FlatStyle.Flat
            CboDBEngine.Font = New Font("Segoe UI", 12F)
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
            ULbl1.TabIndex = 1010
            ULbl1.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl1.XOText = "DB Engine"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ' 
            ' ULbl_DatabaseName
            ' 
            ULbl_DatabaseName.BackColor = Color.MistyRose
            ULbl_DatabaseName.Location = New Point(16, 448)
            ULbl_DatabaseName.Margin = New Padding(12, 17, 12, 17)
            ULbl_DatabaseName.Name = "ULbl_DatabaseName"
            ULbl_DatabaseName.Size = New Size(272, 39)
            ULbl_DatabaseName.TabIndex = 1008
            ULbl_DatabaseName.XOLabelColor = ControlCodeBase.EnumColorSelect.Red
            ULbl_DatabaseName.XOText = "Database Name"
            ULbl_DatabaseName.XOTextAdjuster = False
            ULbl_DatabaseName.XOTextBorder = False
            ' 
            ' TxtDatabaseName
            ' 
            TxtDatabaseName.BackColor = Color.White
            TxtDatabaseName.Font = New Font("Segoe UI", 12F)
            TxtDatabaseName.Location = New Point(306, 448)
            TxtDatabaseName.Margin = New Padding(6, 5, 6, 5)
            TxtDatabaseName.MaxLength = 255
            TxtDatabaseName.Name = "TxtDatabaseName"
            TxtDatabaseName.Size = New Size(413, 39)
            TxtDatabaseName.TabIndex = 7
            TxtDatabaseName.Tag = "txt"
            TxtDatabaseName.XOAutoTrim = True
            TxtDatabaseName.XOHighlightColor = Color.LightYellow
            TxtDatabaseName.XOHighlightOnFocus = True
            TxtDatabaseName.XOIsBlank = True
            TxtDatabaseName.XOIsMandatory = True
            TxtDatabaseName.XOIsPlaceholder = False
            TxtDatabaseName.XOIsReplaceEmptyString = False
            TxtDatabaseName.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtDatabaseName.XOMandatoryBgColor = Color.LightPink
            TxtDatabaseName.XOMandatoryBgColorDefault = Color.White
            TxtDatabaseName.XOMandatoryMessage = Nothing
            TxtDatabaseName.XOPasswordLengthMin = 8
            TxtDatabaseName.XOPasswordStrengthCalc = False
            TxtDatabaseName.XOPasswordStrengthScore = 0
            TxtDatabaseName.XOPasswordStrengthText = Nothing
            TxtDatabaseName.XOPlaceholderText = "Type then press Enter"
            TxtDatabaseName.XORestriction = ControlCodeBase.EnumRestriction.TextAndNumber
            TxtDatabaseName.XOSelectOnFocus = False
            TxtDatabaseName.XOSqlText = ""
            ' 
            ' ChkDefault
            ' 
            ChkDefault.AutoSize = True
            ChkDefault.BackColor = Color.Transparent
            ChkDefault.FlatStyle = FlatStyle.Flat
            ChkDefault.Font = New Font("Segoe UI", 12F)
            ChkDefault.Location = New Point(306, 562)
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
            TxtPassword.Font = New Font("Segoe UI", 12F)
            TxtPassword.Location = New Point(306, 382)
            TxtPassword.Margin = New Padding(6, 5, 6, 5)
            TxtPassword.MaxLength = 255
            TxtPassword.Name = "TxtPassword"
            TxtPassword.PasswordChar = "●"c
            TxtPassword.Size = New Size(413, 39)
            TxtPassword.TabIndex = 6
            TxtPassword.Tag = "txt"
            TxtPassword.XOAutoTrim = False
            TxtPassword.XOHighlightColor = Color.LightYellow
            TxtPassword.XOHighlightOnFocus = True
            TxtPassword.XOIsBlank = True
            TxtPassword.XOIsMandatory = True
            TxtPassword.XOIsPlaceholder = False
            TxtPassword.XOIsReplaceEmptyString = False
            TxtPassword.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtPassword.XOMandatoryBgColor = Color.LightPink
            TxtPassword.XOMandatoryBgColorDefault = Color.White
            TxtPassword.XOMandatoryMessage = Nothing
            TxtPassword.XOPasswordLengthMin = 8
            TxtPassword.XOPasswordStrengthCalc = False
            TxtPassword.XOPasswordStrengthScore = 0
            TxtPassword.XOPasswordStrengthText = Nothing
            TxtPassword.XOPlaceholderText = "Type then press Enter"
            TxtPassword.XORestriction = ControlCodeBase.EnumRestriction.None
            TxtPassword.XOSelectOnFocus = False
            TxtPassword.XOSqlText = ""
            ' 
            ' TxtUsername
            ' 
            TxtUsername.BackColor = Color.White
            TxtUsername.Font = New Font("Segoe UI", 12F)
            TxtUsername.Location = New Point(306, 313)
            TxtUsername.Margin = New Padding(6, 5, 6, 5)
            TxtUsername.MaxLength = 255
            TxtUsername.Name = "TxtUsername"
            TxtUsername.Size = New Size(413, 39)
            TxtUsername.TabIndex = 5
            TxtUsername.Tag = "txt"
            TxtUsername.XOAutoTrim = True
            TxtUsername.XOHighlightColor = Color.LightYellow
            TxtUsername.XOHighlightOnFocus = True
            TxtUsername.XOIsBlank = True
            TxtUsername.XOIsMandatory = True
            TxtUsername.XOIsPlaceholder = False
            TxtUsername.XOIsReplaceEmptyString = False
            TxtUsername.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtUsername.XOMandatoryBgColor = Color.LightPink
            TxtUsername.XOMandatoryBgColorDefault = Color.White
            TxtUsername.XOMandatoryMessage = Nothing
            TxtUsername.XOPasswordLengthMin = 8
            TxtUsername.XOPasswordStrengthCalc = False
            TxtUsername.XOPasswordStrengthScore = 0
            TxtUsername.XOPasswordStrengthText = Nothing
            TxtUsername.XOPlaceholderText = "Type then press Enter"
            TxtUsername.XORestriction = ControlCodeBase.EnumRestriction.TextAndNumber
            TxtUsername.XOSelectOnFocus = False
            TxtUsername.XOSqlText = ""
            ' 
            ' ULbl_Password
            ' 
            ULbl_Password.BackColor = Color.AliceBlue
            ULbl_Password.Location = New Point(16, 386)
            ULbl_Password.Margin = New Padding(12, 17, 12, 17)
            ULbl_Password.Name = "ULbl_Password"
            ULbl_Password.Size = New Size(272, 35)
            ULbl_Password.TabIndex = 1005
            ULbl_Password.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl_Password.XOText = "Password"
            ULbl_Password.XOTextAdjuster = False
            ULbl_Password.XOTextBorder = False
            ' 
            ' ULbl_Username
            ' 
            ULbl_Username.BackColor = Color.AliceBlue
            ULbl_Username.Location = New Point(16, 313)
            ULbl_Username.Margin = New Padding(12, 17, 12, 17)
            ULbl_Username.Name = "ULbl_Username"
            ULbl_Username.Size = New Size(272, 39)
            ULbl_Username.TabIndex = 1004
            ULbl_Username.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl_Username.XOText = "Username"
            ULbl_Username.XOTextAdjuster = False
            ULbl_Username.XOTextBorder = False
            ' 
            ' ULbl_Port
            ' 
            ULbl_Port.BackColor = Color.AliceBlue
            ULbl_Port.Location = New Point(16, 247)
            ULbl_Port.Margin = New Padding(12, 17, 12, 17)
            ULbl_Port.Name = "ULbl_Port"
            ULbl_Port.Size = New Size(272, 39)
            ULbl_Port.TabIndex = 1003
            ULbl_Port.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl_Port.XOText = "Port"
            ULbl_Port.XOTextAdjuster = False
            ULbl_Port.XOTextBorder = False
            ' 
            ' TxtPort
            ' 
            TxtPort.BackColor = Color.White
            TxtPort.Font = New Font("Segoe UI", 12F)
            TxtPort.Location = New Point(306, 247)
            TxtPort.Margin = New Padding(6, 5, 6, 5)
            TxtPort.MaxLength = 255
            TxtPort.Name = "TxtPort"
            TxtPort.Size = New Size(161, 39)
            TxtPort.TabIndex = 4
            TxtPort.Tag = "txt"
            TxtPort.TextAlign = HorizontalAlignment.Center
            TxtPort.XOAutoTrim = True
            TxtPort.XOHighlightColor = Color.LightYellow
            TxtPort.XOHighlightOnFocus = True
            TxtPort.XOIsBlank = True
            TxtPort.XOIsMandatory = True
            TxtPort.XOIsPlaceholder = False
            TxtPort.XOIsReplaceEmptyString = False
            TxtPort.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtPort.XOMandatoryBgColor = Color.LightPink
            TxtPort.XOMandatoryBgColorDefault = Color.White
            TxtPort.XOMandatoryMessage = Nothing
            TxtPort.XOPasswordLengthMin = 8
            TxtPort.XOPasswordStrengthCalc = False
            TxtPort.XOPasswordStrengthScore = 0
            TxtPort.XOPasswordStrengthText = Nothing
            TxtPort.XOPlaceholderText = "Type then press Enter"
            TxtPort.XORestriction = ControlCodeBase.EnumRestriction.OnlyNumber
            TxtPort.XOSelectOnFocus = False
            TxtPort.XOSqlText = ""
            ' 
            ' ULbl_Address
            ' 
            ULbl_Address.BackColor = Color.AliceBlue
            ULbl_Address.Location = New Point(16, 178)
            ULbl_Address.Margin = New Padding(12, 17, 12, 17)
            ULbl_Address.Name = "ULbl_Address"
            ULbl_Address.Size = New Size(272, 39)
            ULbl_Address.TabIndex = 1001
            ULbl_Address.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl_Address.XOText = "Address"
            ULbl_Address.XOTextAdjuster = False
            ULbl_Address.XOTextBorder = False
            ' 
            ' ULbl_Name
            ' 
            ULbl_Name.BackColor = Color.AliceBlue
            ULbl_Name.Location = New Point(16, 38)
            ULbl_Name.Margin = New Padding(12, 17, 12, 17)
            ULbl_Name.Name = "ULbl_Name"
            ULbl_Name.Size = New Size(272, 39)
            ULbl_Name.TabIndex = 1000
            ULbl_Name.XOLabelColor = ControlCodeBase.EnumColorSelect.Default
            ULbl_Name.XOText = "Connection Name"
            ULbl_Name.XOTextAdjuster = False
            ULbl_Name.XOTextBorder = False
            ' 
            ' TxtConnectionName
            ' 
            TxtConnectionName.BackColor = Color.White
            TxtConnectionName.Font = New Font("Segoe UI", 12F)
            TxtConnectionName.Location = New Point(306, 38)
            TxtConnectionName.Margin = New Padding(6, 5, 6, 5)
            TxtConnectionName.MaxLength = 255
            TxtConnectionName.Name = "TxtConnectionName"
            TxtConnectionName.Size = New Size(413, 39)
            TxtConnectionName.TabIndex = 0
            TxtConnectionName.Tag = "txt"
            TxtConnectionName.XOAutoTrim = True
            TxtConnectionName.XOHighlightColor = Color.LightYellow
            TxtConnectionName.XOHighlightOnFocus = True
            TxtConnectionName.XOIsBlank = True
            TxtConnectionName.XOIsMandatory = True
            TxtConnectionName.XOIsPlaceholder = False
            TxtConnectionName.XOIsReplaceEmptyString = False
            TxtConnectionName.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtConnectionName.XOMandatoryBgColor = Color.LightPink
            TxtConnectionName.XOMandatoryBgColorDefault = Color.White
            TxtConnectionName.XOMandatoryMessage = Nothing
            TxtConnectionName.XOPasswordLengthMin = 8
            TxtConnectionName.XOPasswordStrengthCalc = False
            TxtConnectionName.XOPasswordStrengthScore = 0
            TxtConnectionName.XOPasswordStrengthText = Nothing
            TxtConnectionName.XOPlaceholderText = "Type then press Enter"
            TxtConnectionName.XORestriction = ControlCodeBase.EnumRestriction.None
            TxtConnectionName.XOSelectOnFocus = False
            TxtConnectionName.XOSqlText = ""
            ' 
            ' TxtAddress
            ' 
            TxtAddress.BackColor = Color.White
            TxtAddress.Font = New Font("Segoe UI", 12F)
            TxtAddress.Location = New Point(306, 178)
            TxtAddress.Margin = New Padding(6, 5, 6, 5)
            TxtAddress.MaxLength = 255
            TxtAddress.Name = "TxtAddress"
            TxtAddress.Size = New Size(413, 39)
            TxtAddress.TabIndex = 3
            TxtAddress.Tag = "txt"
            TxtAddress.XOAutoTrim = True
            TxtAddress.XOHighlightColor = Color.LightYellow
            TxtAddress.XOHighlightOnFocus = True
            TxtAddress.XOIsBlank = True
            TxtAddress.XOIsMandatory = True
            TxtAddress.XOIsPlaceholder = False
            TxtAddress.XOIsReplaceEmptyString = False
            TxtAddress.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            TxtAddress.XOMandatoryBgColor = Color.LightPink
            TxtAddress.XOMandatoryBgColorDefault = Color.White
            TxtAddress.XOMandatoryMessage = Nothing
            TxtAddress.XOPasswordLengthMin = 8
            TxtAddress.XOPasswordStrengthCalc = False
            TxtAddress.XOPasswordStrengthScore = 0
            TxtAddress.XOPasswordStrengthText = Nothing
            TxtAddress.XOPlaceholderText = "Type then press Enter"
            TxtAddress.XORestriction = ControlCodeBase.EnumRestriction.None
            TxtAddress.XOSelectOnFocus = False
            TxtAddress.XOSqlText = ""
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
            btnImport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            btnImport.ForeColor = Color.White
            btnImport.Location = New Point(6, 467)
            btnImport.Name = "btnImport"
            btnImport.Size = New Size(150, 60)
            btnImport.TabIndex = 6
            btnImport.Text = "Import"
            btnImport.UseVisualStyleBackColor = False
            btnImport.XOButtonType = ControlCodeBase.ButtonType.Default
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
            btnSaveAs.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            btnSaveAs.ForeColor = Color.White
            btnSaveAs.Location = New Point(581, 467)
            btnSaveAs.Name = "btnSaveAs"
            btnSaveAs.Size = New Size(150, 60)
            btnSaveAs.TabIndex = 5
            btnSaveAs.Text = "Save As"
            btnSaveAs.UseVisualStyleBackColor = False
            btnSaveAs.XOButtonType = ControlCodeBase.ButtonType.Default
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
            txtImportContent.Font = New Font("Segoe UI", 12F)
            txtImportContent.Location = New Point(3, 15)
            txtImportContent.MaxLength = 0
            txtImportContent.Multiline = True
            txtImportContent.Name = "txtImportContent"
            txtImportContent.Size = New Size(719, 371)
            txtImportContent.TabIndex = 3
            txtImportContent.Tag = "txt"
            txtImportContent.XOAutoTrim = False
            txtImportContent.XOHighlightColor = Color.LightYellow
            txtImportContent.XOHighlightOnFocus = True
            txtImportContent.XOIsBlank = True
            txtImportContent.XOIsMandatory = False
            txtImportContent.XOIsPlaceholder = False
            txtImportContent.XOIsReplaceEmptyString = False
            txtImportContent.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            txtImportContent.XOMandatoryBgColor = Color.LightPink
            txtImportContent.XOMandatoryBgColorDefault = Color.White
            txtImportContent.XOMandatoryMessage = Nothing
            txtImportContent.XOPasswordLengthMin = 8
            txtImportContent.XOPasswordStrengthCalc = False
            txtImportContent.XOPasswordStrengthScore = 0
            txtImportContent.XOPasswordStrengthText = Nothing
            txtImportContent.XOPlaceholderText = "Type then press Enter"
            txtImportContent.XORestriction = ControlCodeBase.EnumRestriction.None
            txtImportContent.XOSelectOnFocus = False
            txtImportContent.XOSqlText = ""
            ' 
            ' btnGet
            ' 
            btnGet.BackColor = Color.RoyalBlue
            btnGet.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            btnGet.FlatAppearance.BorderSize = 2
            btnGet.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            btnGet.FlatStyle = FlatStyle.Flat
            btnGet.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            btnGet.ForeColor = Color.White
            btnGet.Location = New Point(581, 6)
            btnGet.Name = "btnGet"
            btnGet.Size = New Size(150, 60)
            btnGet.TabIndex = 2
            btnGet.Text = "Get"
            btnGet.UseVisualStyleBackColor = False
            btnGet.XOButtonType = ControlCodeBase.ButtonType.Default
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
            ULbl2.TabIndex = 1
            ULbl2.XOLabelColor = ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.XOText = "Connection Code"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ' 
            ' txtImportCode
            ' 
            txtImportCode.Font = New Font("Segoe UI", 12F)
            txtImportCode.Location = New Point(249, 17)
            txtImportCode.MaxLength = 255
            txtImportCode.Name = "txtImportCode"
            txtImportCode.Size = New Size(326, 39)
            txtImportCode.TabIndex = 0
            txtImportCode.Tag = "txt"
            txtImportCode.XOAutoTrim = False
            txtImportCode.XOHighlightColor = Color.LightYellow
            txtImportCode.XOHighlightOnFocus = True
            txtImportCode.XOIsBlank = False
            txtImportCode.XOIsMandatory = False
            txtImportCode.XOIsPlaceholder = False
            txtImportCode.XOIsReplaceEmptyString = False
            txtImportCode.XOLetterCase = ControlCodeBase.EnumLetterCase.Normal
            txtImportCode.XOMandatoryBgColor = Color.LightPink
            txtImportCode.XOMandatoryBgColorDefault = Color.White
            txtImportCode.XOMandatoryMessage = Nothing
            txtImportCode.XOPasswordLengthMin = 8
            txtImportCode.XOPasswordStrengthCalc = False
            txtImportCode.XOPasswordStrengthScore = 0
            txtImportCode.XOPasswordStrengthText = Nothing
            txtImportCode.XOPlaceholderText = "Type then press Enter"
            txtImportCode.XORestriction = ControlCodeBase.EnumRestriction.TextAndNumber
            txtImportCode.XOSelectOnFocus = False
            txtImportCode.XOSqlText = ""
            ' 
            ' Btn_Test
            ' 
            Btn_Test.BackColor = Color.Yellow
            Btn_Test.Cursor = Cursors.Hand
            Btn_Test.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(195), CByte(0))
            Btn_Test.FlatAppearance.BorderSize = 2
            Btn_Test.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(20))
            Btn_Test.FlatStyle = FlatStyle.Flat
            Btn_Test.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            Btn_Test.ForeColor = Color.Black
            Btn_Test.Location = New Point(20, 13)
            Btn_Test.Margin = New Padding(6, 5, 6, 5)
            Btn_Test.Name = "Btn_Test"
            Btn_Test.Size = New Size(167, 77)
            Btn_Test.TabIndex = 12
            Btn_Test.Text = "Test"
            Btn_Test.UseVisualStyleBackColor = False
            Btn_Test.XOButtonType = ControlCodeBase.ButtonType.Warning
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
        Friend WithEvents TbctlBasic As CMCv.UI.Control.Tbx
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
        Friend WithEvents CboDBEngine As CMCv.UI.Control.Cbo
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
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents TxtClient As CMCv.UI.Control.Txt
    End Class
End Namespace