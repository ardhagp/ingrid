<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMccinEditor
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
        TxtCode = New txt(components)
        TxtSearchTerm1 = New txt(components)
        TxtSearchTerm2 = New txt(components)
        TxtDescription = New txt(components)
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        TxtName = New txt(components)
        ChkAddNew = New chk(components)
        ULbl1 = New ULbl()
        ULbl2 = New ULbl()
        ULbl3 = New ULbl()
        ULbl4 = New ULbl()
        ULbl5 = New ULbl()
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
        PnlBottomButton.Location = New Point(0, 675)
        PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New Size(899, 97)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(899, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(ULbl5)
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TxtName)
        SLFPanel.Controls.Add(TxtDescription)
        SLFPanel.Controls.Add(TxtSearchTerm2)
        SLFPanel.Controls.Add(TxtSearchTerm1)
        SLFPanel.Controls.Add(TxtCode)
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(899, 772)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TxtCode, 0)
        SLFPanel.Controls.SetChildIndex(TxtSearchTerm1, 0)
        SLFPanel.Controls.SetChildIndex(TxtSearchTerm2, 0)
        SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
        SLFPanel.Controls.SetChildIndex(TxtName, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
        SLFPanel.Controls.SetChildIndex(ULbl5, 0)
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCode.Location = New Point(281, 20)
        TxtCode.Margin = New Padding(6, 5, 6, 5)
        TxtCode.MaxLength = 255
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(341, 39)
        TxtCode.TabIndex = 0
        TxtCode.Tag = "txt"
        TxtCode.XOAutoTrim = True
        TxtCode.XOHarusDiisi = True
        TxtCode.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtCode.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtCode.XOHightlightSaatFokus = True
        TxtCode.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtCode.XOIsBlank = True
        TxtCode.XOIsSearchBox = False
        TxtCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtCode.XOPilihSemuaSaatFokus = True
        TxtCode.XOPwdLengthMin = 8
        TxtCode.XOPwdStrengthCalculate = False
        TxtCode.XOPwdStrengthScore = 0
        TxtCode.XOPwdStrengthText = Nothing
        TxtCode.XORestriction = ControlCodeBase.enuRestriction.None
        TxtCode.XOSearchBoxText = "Type then press Enter"
        TxtCode.XOSQLText = ""
        TxtCode.XOTanpaSpasi = False
        TxtCode.XOValidasiField = Nothing
        ' 
        ' TxtSearchTerm1
        ' 
        TxtSearchTerm1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm1.Location = New Point(280, 153)
        TxtSearchTerm1.Margin = New Padding(6, 5, 6, 5)
        TxtSearchTerm1.MaxLength = 255
        TxtSearchTerm1.Name = "TxtSearchTerm1"
        TxtSearchTerm1.Size = New Size(341, 39)
        TxtSearchTerm1.TabIndex = 2
        TxtSearchTerm1.Tag = "txt"
        TxtSearchTerm1.XOAutoTrim = True
        TxtSearchTerm1.XOHarusDiisi = False
        TxtSearchTerm1.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm1.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm1.XOHightlightSaatFokus = False
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
        ' TxtSearchTerm2
        ' 
        TxtSearchTerm2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchTerm2.Location = New Point(280, 222)
        TxtSearchTerm2.Margin = New Padding(6, 5, 6, 5)
        TxtSearchTerm2.MaxLength = 255
        TxtSearchTerm2.Name = "TxtSearchTerm2"
        TxtSearchTerm2.Size = New Size(591, 39)
        TxtSearchTerm2.TabIndex = 3
        TxtSearchTerm2.Tag = "txt"
        TxtSearchTerm2.XOAutoTrim = True
        TxtSearchTerm2.XOHarusDiisi = False
        TxtSearchTerm2.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtSearchTerm2.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtSearchTerm2.XOHightlightSaatFokus = False
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
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(280, 288)
        TxtDescription.Margin = New Padding(6, 5, 6, 5)
        TxtDescription.MaxLength = 255
        TxtDescription.Multiline = True
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(591, 221)
        TxtDescription.TabIndex = 4
        TxtDescription.Tag = "txt"
        TxtDescription.XOAutoTrim = True
        TxtDescription.XOHarusDiisi = False
        TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.XOHightlightSaatFokus = False
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
        BtnSave.Location = New Point(535, 13)
        BtnSave.Margin = New Padding(6, 5, 6, 5)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(167, 77)
        BtnSave.TabIndex = 5
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
        BtnCancel.Location = New Point(712, 13)
        BtnCancel.Margin = New Padding(6, 5, 6, 5)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(167, 77)
        BtnCancel.TabIndex = 7
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(280, 87)
        TxtName.Margin = New Padding(6, 5, 6, 5)
        TxtName.MaxLength = 255
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(341, 39)
        TxtName.TabIndex = 1
        TxtName.Tag = "txt"
        TxtName.XOAutoTrim = True
        TxtName.XOHarusDiisi = True
        TxtName.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtName.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtName.XOHightlightSaatFokus = True
        TxtName.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtName.XOIsBlank = True
        TxtName.XOIsSearchBox = False
        TxtName.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtName.XOPilihSemuaSaatFokus = False
        TxtName.XOPwdLengthMin = 8
        TxtName.XOPwdStrengthCalculate = False
        TxtName.XOPwdStrengthScore = 0
        TxtName.XOPwdStrengthText = Nothing
        TxtName.XORestriction = ControlCodeBase.enuRestriction.None
        TxtName.XOSearchBoxText = "Type then press Enter"
        TxtName.XOSQLText = ""
        TxtName.XOTanpaSpasi = False
        TxtName.XOValidasiField = Nothing
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(304, 28)
        ChkAddNew.Margin = New Padding(6, 5, 6, 5)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(221, 36)
        ChkAddNew.TabIndex = 6
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(20, 20)
        ULbl1.Margin = New Padding(7, 5, 7, 5)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(250, 55)
        ULbl1.SLFText = "Company Code"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1006
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(20, 87)
        ULbl2.Margin = New Padding(7, 5, 7, 5)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(250, 55)
        ULbl2.SLFText = "Company Name"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1007
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(20, 153)
        ULbl3.Margin = New Padding(7, 5, 7, 5)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(250, 55)
        ULbl3.SLFText = "Search Term 1"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1008
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(20, 222)
        ULbl4.Margin = New Padding(7, 5, 7, 5)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(250, 55)
        ULbl4.SLFText = "Search Term 2"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1009
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(20, 288)
        ULbl5.Margin = New Padding(7, 5, 7, 5)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(250, 225)
        ULbl5.SLFText = "Description"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1010
        ' 
        ' FRMccinEditor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(899, 898)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMccinEditor"
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
    Friend WithEvents TxtCode As txt
    Friend WithEvents TxtDescription As txt
    Friend WithEvents TxtSearchTerm2 As txt
    Friend WithEvents TxtSearchTerm1 As txt
    Friend WithEvents BtnCancel As btn
    Friend WithEvents BtnSave As btn
    Friend WithEvents TxtName As txt
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
End Class
