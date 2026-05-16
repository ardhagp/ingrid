Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMplntEditor
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
            CboCompany = New CMCv.UI.Control.cbo(components)
            TxtPlantCode = New CMCv.UI.Control.txt(components)
            TxtPlantName = New CMCv.UI.Control.txt(components)
            TxtSearchTerm1 = New CMCv.UI.Control.txt(components)
            TxtAddress = New CMCv.UI.Control.txt(components)
            TxtPostalCode = New CMCv.UI.Control.txt(components)
            TxtDescription = New CMCv.UI.Control.txt(components)
            TxtSearchTerm2 = New CMCv.UI.Control.txt(components)
            BtnSave = New CMCv.UI.Control.btn(components)
            BtnCancel = New CMCv.UI.Control.btn(components)
            ChkAddNew = New CMCv.UI.Control.chk(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            ULbl7 = New CMCv.UI.Control.ULbl()
            ULbl8 = New CMCv.UI.Control.ULbl()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 729)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(651, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(651, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.AutoScroll = True
            SLFPanel.Controls.Add(ULbl8)
            SLFPanel.Controls.Add(ULbl7)
            SLFPanel.Controls.Add(ULbl6)
            SLFPanel.Controls.Add(ULbl5)
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtSearchTerm2)
            SLFPanel.Controls.Add(TxtDescription)
            SLFPanel.Controls.Add(TxtPostalCode)
            SLFPanel.Controls.Add(TxtAddress)
            SLFPanel.Controls.Add(TxtSearchTerm1)
            SLFPanel.Controls.Add(TxtPlantName)
            SLFPanel.Controls.Add(TxtPlantCode)
            SLFPanel.Controls.Add(CboCompany)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(651, 826)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(CboCompany, 0)
            SLFPanel.Controls.SetChildIndex(TxtPlantCode, 0)
            SLFPanel.Controls.SetChildIndex(TxtPlantName, 0)
            SLFPanel.Controls.SetChildIndex(TxtSearchTerm1, 0)
            SLFPanel.Controls.SetChildIndex(TxtAddress, 0)
            SLFPanel.Controls.SetChildIndex(TxtPostalCode, 0)
            SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
            SLFPanel.Controls.SetChildIndex(TxtSearchTerm2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
            SLFPanel.Controls.SetChildIndex(ULbl5, 0)
            SLFPanel.Controls.SetChildIndex(ULbl6, 0)
            SLFPanel.Controls.SetChildIndex(ULbl7, 0)
            SLFPanel.Controls.SetChildIndex(ULbl8, 0)
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            CboCompany.FormattingEnabled = True
            CboCompany.Location = New Point(234, 20)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(343, 40)
            CboCompany.TabIndex = 0
            ' 
            ' TxtPlantCode
            ' 
            TxtPlantCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPlantCode.Location = New Point(234, 87)
            TxtPlantCode.Margin = New Padding(6, 5, 6, 5)
            TxtPlantCode.MaxLength = 10
            TxtPlantCode.Name = "TxtPlantCode"
            TxtPlantCode.Size = New Size(263, 39)
            TxtPlantCode.TabIndex = 1
            TxtPlantCode.Tag = "txt"
            TxtPlantCode.TextAlign = HorizontalAlignment.Center
            TxtPlantCode.XOAutoTrim = True
            TxtPlantCode.XOHarusDiisi = True
            TxtPlantCode.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPlantCode.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPlantCode.XOHightlightSaatFokus = True
            TxtPlantCode.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPlantCode.XOIsBlank = True
            TxtPlantCode.XOIsSearchBox = False
            TxtPlantCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtPlantCode.XOPilihSemuaSaatFokus = True
            TxtPlantCode.XOPwdLengthMin = 8
            TxtPlantCode.XOPwdStrengthCalculate = False
            TxtPlantCode.XOPwdStrengthScore = 0
            TxtPlantCode.XOPwdStrengthText = Nothing
            TxtPlantCode.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPlantCode.XOSearchBoxText = "Type then press Enter"
            TxtPlantCode.XOSQLText = ""
            TxtPlantCode.XOTanpaSpasi = False
            TxtPlantCode.XOValidasiField = Nothing
            ' 
            ' TxtPlantName
            ' 
            TxtPlantName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPlantName.Location = New Point(234, 153)
            TxtPlantName.Margin = New Padding(6, 5, 6, 5)
            TxtPlantName.MaxLength = 255
            TxtPlantName.Name = "TxtPlantName"
            TxtPlantName.Size = New Size(344, 39)
            TxtPlantName.TabIndex = 2
            TxtPlantName.Tag = "txt"
            TxtPlantName.XOAutoTrim = True
            TxtPlantName.XOHarusDiisi = True
            TxtPlantName.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPlantName.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPlantName.XOHightlightSaatFokus = True
            TxtPlantName.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPlantName.XOIsBlank = True
            TxtPlantName.XOIsSearchBox = False
            TxtPlantName.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtPlantName.XOPilihSemuaSaatFokus = True
            TxtPlantName.XOPwdLengthMin = 8
            TxtPlantName.XOPwdStrengthCalculate = False
            TxtPlantName.XOPwdStrengthScore = 0
            TxtPlantName.XOPwdStrengthText = Nothing
            TxtPlantName.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPlantName.XOSearchBoxText = "Type then press Enter"
            TxtPlantName.XOSQLText = ""
            TxtPlantName.XOTanpaSpasi = False
            TxtPlantName.XOValidasiField = Nothing
            ' 
            ' TxtSearchTerm1
            ' 
            TxtSearchTerm1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtSearchTerm1.Location = New Point(234, 219)
            TxtSearchTerm1.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm1.MaxLength = 255
            TxtSearchTerm1.Name = "TxtSearchTerm1"
            TxtSearchTerm1.Size = New Size(344, 39)
            TxtSearchTerm1.TabIndex = 3
            TxtSearchTerm1.Tag = "txt"
            TxtSearchTerm1.XOAutoTrim = True
            TxtSearchTerm1.XOHarusDiisi = False
            TxtSearchTerm1.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtSearchTerm1.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtSearchTerm1.XOHightlightSaatFokus = True
            TxtSearchTerm1.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtSearchTerm1.XOIsBlank = True
            TxtSearchTerm1.XOIsSearchBox = False
            TxtSearchTerm1.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtSearchTerm1.XOPilihSemuaSaatFokus = False
            TxtSearchTerm1.XOPwdLengthMin = 8
            TxtSearchTerm1.XOPwdStrengthCalculate = False
            TxtSearchTerm1.XOPwdStrengthScore = 0
            TxtSearchTerm1.XOPwdStrengthText = Nothing
            TxtSearchTerm1.XORestriction = ControlCodeBase.enuRestriction.None
            TxtSearchTerm1.XOSearchBoxText = "Type then press Enter"
            TxtSearchTerm1.XOSQLText = ""
            TxtSearchTerm1.XOTanpaSpasi = False
            TxtSearchTerm1.XOValidasiField = Nothing
            ' 
            ' TxtAddress
            ' 
            TxtAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtAddress.Location = New Point(234, 416)
            TxtAddress.Margin = New Padding(6, 5, 6, 5)
            TxtAddress.MaxLength = 255
            TxtAddress.Multiline = True
            TxtAddress.Name = "TxtAddress"
            TxtAddress.Size = New Size(344, 143)
            TxtAddress.TabIndex = 6
            TxtAddress.Tag = "txt"
            TxtAddress.XOAutoTrim = True
            TxtAddress.XOHarusDiisi = False
            TxtAddress.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtAddress.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtAddress.XOHightlightSaatFokus = True
            TxtAddress.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtAddress.XOIsBlank = True
            TxtAddress.XOIsSearchBox = False
            TxtAddress.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtAddress.XOPilihSemuaSaatFokus = True
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
            ' TxtPostalCode
            ' 
            TxtPostalCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPostalCode.Location = New Point(234, 586)
            TxtPostalCode.Margin = New Padding(6, 5, 6, 5)
            TxtPostalCode.MaxLength = 6
            TxtPostalCode.Name = "TxtPostalCode"
            TxtPostalCode.Size = New Size(158, 39)
            TxtPostalCode.TabIndex = 7
            TxtPostalCode.Tag = "txt"
            TxtPostalCode.TextAlign = HorizontalAlignment.Center
            TxtPostalCode.XOAutoTrim = True
            TxtPostalCode.XOHarusDiisi = False
            TxtPostalCode.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtPostalCode.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtPostalCode.XOHightlightSaatFokus = True
            TxtPostalCode.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtPostalCode.XOIsBlank = True
            TxtPostalCode.XOIsSearchBox = False
            TxtPostalCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtPostalCode.XOPilihSemuaSaatFokus = True
            TxtPostalCode.XOPwdLengthMin = 8
            TxtPostalCode.XOPwdStrengthCalculate = False
            TxtPostalCode.XOPwdStrengthScore = 0
            TxtPostalCode.XOPwdStrengthText = Nothing
            TxtPostalCode.XORestriction = ControlCodeBase.enuRestriction.None
            TxtPostalCode.XOSearchBoxText = "Type then press Enter"
            TxtPostalCode.XOSQLText = ""
            TxtPostalCode.XOTanpaSpasi = False
            TxtPostalCode.XOValidasiField = Nothing
            ' 
            ' TxtDescription
            ' 
            TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDescription.Location = New Point(234, 351)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(344, 39)
            TxtDescription.TabIndex = 5
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = True
            TxtDescription.XOHarusDiisi = False
            TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtDescription.XOHightlightSaatFokus = True
            TxtDescription.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtDescription.XOIsBlank = True
            TxtDescription.XOIsSearchBox = False
            TxtDescription.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtDescription.XOPilihSemuaSaatFokus = False
            TxtDescription.XOPwdLengthMin = 8
            TxtDescription.XOPwdStrengthCalculate = False
            TxtDescription.XOPwdStrengthScore = 0
            TxtDescription.XOPwdStrengthText = Nothing
            TxtDescription.XORestriction = ControlCodeBase.enuRestriction.None
            TxtDescription.XOSearchBoxText = "Type then press Enter"
            TxtDescription.XOSQLText = ""
            TxtDescription.XOTanpaSpasi = False
            TxtDescription.XOValidasiField = Nothing
            ' 
            ' TxtSearchTerm2
            ' 
            TxtSearchTerm2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtSearchTerm2.Location = New Point(234, 285)
            TxtSearchTerm2.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm2.MaxLength = 255
            TxtSearchTerm2.Name = "TxtSearchTerm2"
            TxtSearchTerm2.Size = New Size(341, 39)
            TxtSearchTerm2.TabIndex = 4
            TxtSearchTerm2.Tag = "txt"
            TxtSearchTerm2.XOAutoTrim = True
            TxtSearchTerm2.XOHarusDiisi = False
            TxtSearchTerm2.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtSearchTerm2.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtSearchTerm2.XOHightlightSaatFokus = True
            TxtSearchTerm2.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtSearchTerm2.XOIsBlank = True
            TxtSearchTerm2.XOIsSearchBox = False
            TxtSearchTerm2.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtSearchTerm2.XOPilihSemuaSaatFokus = False
            TxtSearchTerm2.XOPwdLengthMin = 8
            TxtSearchTerm2.XOPwdStrengthCalculate = False
            TxtSearchTerm2.XOPwdStrengthScore = 0
            TxtSearchTerm2.XOPwdStrengthText = Nothing
            TxtSearchTerm2.XORestriction = ControlCodeBase.enuRestriction.None
            TxtSearchTerm2.XOSearchBoxText = "Type then press Enter"
            TxtSearchTerm2.XOSQLText = ""
            TxtSearchTerm2.XOTanpaSpasi = False
            TxtSearchTerm2.XOValidasiField = Nothing
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
            BtnSave.Location = New Point(287, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 600
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
            BtnCancel.Location = New Point(464, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 602
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnCancel.XOTampilkanFocusBorder = False
            BtnCancel.XOValidasiSemuaInput = False
            BtnCancel.XOValidasiSemuaInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(56, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 601
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(17, 20)
            ULbl1.Margin = New Padding(5, 6, 5, 6)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(197, 39)
            ULbl1.SLFText = "Company"
            ULbl1.SLFTextAdjuster = True
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl1.TabIndex = 1014
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(17, 87)
            ULbl2.Margin = New Padding(5, 6, 5, 6)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(197, 39)
            ULbl2.SLFText = "Plant Code"
            ULbl2.SLFTextAdjuster = True
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1015
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(17, 153)
            ULbl3.Margin = New Padding(5, 6, 5, 6)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(197, 39)
            ULbl3.SLFText = "Plant Name"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl3.TabIndex = 1016
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(17, 219)
            ULbl4.Margin = New Padding(5, 6, 5, 6)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(197, 39)
            ULbl4.SLFText = "Search Term 1"
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl4.TabIndex = 1017
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(17, 285)
            ULbl5.Margin = New Padding(5, 6, 5, 6)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(197, 39)
            ULbl5.SLFText = "Search Term 2"
            ULbl5.SLFTextAdjuster = True
            ULbl5.SLFTextBorder = False
            ULbl5.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl5.TabIndex = 1018
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(17, 351)
            ULbl6.Margin = New Padding(5, 6, 5, 6)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(197, 39)
            ULbl6.SLFText = "Description"
            ULbl6.SLFTextAdjuster = True
            ULbl6.SLFTextBorder = False
            ULbl6.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl6.TabIndex = 1019
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.Moccasin
            ULbl7.Location = New Point(17, 416)
            ULbl7.Margin = New Padding(5, 6, 5, 6)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(197, 143)
            ULbl7.SLFText = "Address"
            ULbl7.SLFTextAdjuster = True
            ULbl7.SLFTextBorder = False
            ULbl7.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl7.TabIndex = 1020
            ' 
            ' ULbl8
            ' 
            ULbl8.BackColor = Color.Moccasin
            ULbl8.Location = New Point(17, 586)
            ULbl8.Margin = New Padding(5, 6, 5, 6)
            ULbl8.Name = "ULbl8"
            ULbl8.Size = New Size(197, 39)
            ULbl8.SLFText = "Postal Code"
            ULbl8.SLFTextAdjuster = True
            ULbl8.SLFTextBorder = False
            ULbl8.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl8.TabIndex = 1021
            ' 
            ' FRMplntEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(651, 958)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMplntEditor"
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents CboCompany As CMCv.UI.Control.cbo
        Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
        Friend WithEvents TxtSearchTerm2 As CMCv.UI.Control.txt
        Friend WithEvents TxtDescription As CMCv.UI.Control.txt
        Friend WithEvents TxtPostalCode As CMCv.UI.Control.txt
        Friend WithEvents TxtAddress As CMCv.UI.Control.txt
        Friend WithEvents TxtPlantName2 As CMCv.UI.Control.txt
        Friend WithEvents TxtSearchTerm1 As CMCv.UI.Control.txt
        Friend WithEvents TxtPlantName As CMCv.UI.Control.txt
        Friend WithEvents TxtPlantCode As CMCv.UI.Control.txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.chk
        Friend WithEvents BtnCancel As CMCv.UI.Control.btn
        Friend WithEvents BtnSave As CMCv.UI.Control.btn
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl8 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
    End Class
End Namespace