Imports Syncfusion.Windows.Forms.Tools

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SYSS
    Inherits CMCv.FRMstandardFind

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
        TbctlSettings = New tbctl(components)
        tbInterface = New TabPage()
        GbxPanels = New gbx(components)
        ULbl3 = New ULbl()
        ULbl2 = New ULbl()
        ULbl1 = New ULbl()
        CboProfile = New cbo(components)
        CboStorage = New cbo(components)
        CboNewsTicker = New cbo(components)
        tbStorage = New TabPage()
        GbxWatermark = New gbx(components)
        ULbl7 = New ULbl()
        ULbl6 = New ULbl()
        CboWatermark = New cbo(components)
        TxtWatermark = New txt(components)
        Gbx1 = New gbx(components)
        ULbl5 = New ULbl()
        ULbl4 = New ULbl()
        Lbl7 = New lbl(components)
        nudUploadPDF = New NumericUpDown()
        Lbl6 = New lbl(components)
        nudUploadPhoto = New NumericUpDown()
        tbSecurity = New TabPage()
        Gbx2 = New gbx(components)
        ULbl8 = New ULbl()
        nudMinPassword = New NumericUpDown()
        BtnClose = New btn(components)
        BtnSave = New btn(components)
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlSettings.SuspendLayout()
        tbInterface.SuspendLayout()
        GbxPanels.SuspendLayout()
        tbStorage.SuspendLayout()
        GbxWatermark.SuspendLayout()
        Gbx1.SuspendLayout()
        CType(nudUploadPDF, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudUploadPhoto, ComponentModel.ISupportInitialize).BeginInit()
        tbSecurity.SuspendLayout()
        Gbx2.SuspendLayout()
        CType(nudMinPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlFind
        ' 
        PnlFind.Controls.Add(BtnClose)
        PnlFind.Controls.Add(BtnSave)
        PnlFind.Controls.SetChildIndex(TxtFind, 0)
        PnlFind.Controls.SetChildIndex(LblFind, 0)
        PnlFind.Controls.SetChildIndex(BtnSave, 0)
        PnlFind.Controls.SetChildIndex(BtnClose, 0)
        PnlFind.Controls.SetChildIndex(BtnClear, 0)
        ' 
        ' BtnClear
        ' 
        BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClear.Visible = False
        ' 
        ' LblFind
        ' 
        LblFind.Visible = False
        ' 
        ' TxtFind
        ' 
        TxtFind.Visible = False
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TbctlSettings)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(TbctlSettings, 0)
        ' 
        ' TbctlSettings
        ' 
        TbctlSettings.Controls.Add(tbInterface)
        TbctlSettings.Controls.Add(tbStorage)
        TbctlSettings.Controls.Add(tbSecurity)
        TbctlSettings.Dock = DockStyle.Fill
        TbctlSettings.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlSettings.Location = New Point(0, 53)
        TbctlSettings.Margin = New Padding(4, 3, 4, 3)
        TbctlSettings.Name = "TbctlSettings"
        TbctlSettings.SelectedIndex = 0
        TbctlSettings.Size = New Size(915, 511)
        TbctlSettings.TabIndex = 802
        ' 
        ' tbInterface
        ' 
        tbInterface.Controls.Add(GbxPanels)
        tbInterface.Location = New Point(4, 30)
        tbInterface.Margin = New Padding(4, 3, 4, 3)
        tbInterface.Name = "tbInterface"
        tbInterface.Padding = New Padding(4, 3, 4, 3)
        tbInterface.Size = New Size(907, 477)
        tbInterface.TabIndex = 0
        tbInterface.Text = "INTERFACE"
        tbInterface.UseVisualStyleBackColor = True
        ' 
        ' GbxPanels
        ' 
        GbxPanels.Controls.Add(ULbl3)
        GbxPanels.Controls.Add(ULbl2)
        GbxPanels.Controls.Add(ULbl1)
        GbxPanels.Controls.Add(CboProfile)
        GbxPanels.Controls.Add(CboStorage)
        GbxPanels.Controls.Add(CboNewsTicker)
        GbxPanels.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GbxPanels.Location = New Point(18, 17)
        GbxPanels.Margin = New Padding(4, 3, 4, 3)
        GbxPanels.Name = "GbxPanels"
        GbxPanels.Padding = New Padding(4, 3, 4, 3)
        GbxPanels.Size = New Size(430, 168)
        GbxPanels.TabIndex = 7
        GbxPanels.TabStop = False
        GbxPanels.Text = "Panel Visibility"
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(8, 115)
        ULbl3.Margin = New Padding(5, 6, 5, 6)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(187, 33)
        ULbl3.SLFText = "Show News Ticker"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 9
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(8, 75)
        ULbl2.Margin = New Padding(5, 6, 5, 6)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(187, 33)
        ULbl2.SLFText = "Show Storage"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 8
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(8, 35)
        ULbl1.Margin = New Padding(5, 6, 5, 6)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(187, 33)
        ULbl1.SLFText = "Show Profile"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 7
        ' 
        ' CboProfile
        ' 
        CboProfile.DropDownStyle = ComboBoxStyle.DropDownList
        CboProfile.FlatStyle = FlatStyle.System
        CboProfile.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboProfile.FormattingEnabled = True
        CboProfile.Location = New Point(203, 35)
        CboProfile.Margin = New Padding(4, 3, 4, 3)
        CboProfile.Name = "CboProfile"
        CboProfile.Size = New Size(215, 29)
        CboProfile.TabIndex = 0
        ' 
        ' CboStorage
        ' 
        CboStorage.DropDownStyle = ComboBoxStyle.DropDownList
        CboStorage.FlatStyle = FlatStyle.System
        CboStorage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboStorage.FormattingEnabled = True
        CboStorage.Location = New Point(203, 75)
        CboStorage.Margin = New Padding(4, 3, 4, 3)
        CboStorage.Name = "CboStorage"
        CboStorage.Size = New Size(216, 29)
        CboStorage.TabIndex = 1
        ' 
        ' CboNewsTicker
        ' 
        CboNewsTicker.DropDownStyle = ComboBoxStyle.DropDownList
        CboNewsTicker.FlatStyle = FlatStyle.System
        CboNewsTicker.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboNewsTicker.FormattingEnabled = True
        CboNewsTicker.Location = New Point(203, 115)
        CboNewsTicker.Margin = New Padding(4, 3, 4, 3)
        CboNewsTicker.Name = "CboNewsTicker"
        CboNewsTicker.Size = New Size(216, 29)
        CboNewsTicker.TabIndex = 2
        ' 
        ' tbStorage
        ' 
        tbStorage.Controls.Add(GbxWatermark)
        tbStorage.Controls.Add(Gbx1)
        tbStorage.Location = New Point(4, 30)
        tbStorage.Margin = New Padding(4, 3, 4, 3)
        tbStorage.Name = "tbStorage"
        tbStorage.Padding = New Padding(4, 3, 4, 3)
        tbStorage.Size = New Size(907, 477)
        tbStorage.TabIndex = 1
        tbStorage.Text = "STORAGE"
        tbStorage.UseVisualStyleBackColor = True
        ' 
        ' GbxWatermark
        ' 
        GbxWatermark.Controls.Add(ULbl7)
        GbxWatermark.Controls.Add(ULbl6)
        GbxWatermark.Controls.Add(CboWatermark)
        GbxWatermark.Controls.Add(TxtWatermark)
        GbxWatermark.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        GbxWatermark.Location = New Point(18, 149)
        GbxWatermark.Margin = New Padding(4, 3, 4, 3)
        GbxWatermark.Name = "GbxWatermark"
        GbxWatermark.Padding = New Padding(4, 3, 4, 3)
        GbxWatermark.Size = New Size(478, 123)
        GbxWatermark.TabIndex = 12
        GbxWatermark.TabStop = False
        GbxWatermark.Text = "Picture Watermark"
        ' 
        ' ULbl7
        ' 
        ULbl7.BackColor = Color.Moccasin
        ULbl7.Location = New Point(8, 75)
        ULbl7.Margin = New Padding(5, 6, 5, 6)
        ULbl7.Name = "ULbl7"
        ULbl7.Size = New Size(175, 33)
        ULbl7.SLFText = "Text"
        ULbl7.SLFTextAdjuster = False
        ULbl7.SLFTextBorder = False
        ULbl7.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl7.TabIndex = 15
        ' 
        ' ULbl6
        ' 
        ULbl6.BackColor = Color.Moccasin
        ULbl6.Location = New Point(8, 35)
        ULbl6.Margin = New Padding(5, 6, 5, 6)
        ULbl6.Name = "ULbl6"
        ULbl6.Size = New Size(175, 33)
        ULbl6.SLFText = "Show To"
        ULbl6.SLFTextAdjuster = False
        ULbl6.SLFTextBorder = False
        ULbl6.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl6.TabIndex = 14
        ' 
        ' CboWatermark
        ' 
        CboWatermark.DropDownStyle = ComboBoxStyle.DropDownList
        CboWatermark.FlatStyle = FlatStyle.System
        CboWatermark.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboWatermark.FormattingEnabled = True
        CboWatermark.Location = New Point(191, 35)
        CboWatermark.Margin = New Padding(4, 3, 4, 3)
        CboWatermark.Name = "CboWatermark"
        CboWatermark.Size = New Size(215, 29)
        CboWatermark.TabIndex = 2
        ' 
        ' TxtWatermark
        ' 
        TxtWatermark.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtWatermark.Location = New Point(191, 75)
        TxtWatermark.Margin = New Padding(4, 3, 4, 3)
        TxtWatermark.MaxLength = 255
        TxtWatermark.Name = "TxtWatermark"
        TxtWatermark.Size = New Size(279, 29)
        TxtWatermark.XOAutoTrim = False
        TxtWatermark.XOHarusDiisi = False
        TxtWatermark.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtWatermark.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtWatermark.XOHightlightSaatFokus = False
        TxtWatermark.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtWatermark.XOIsBlank = True
        TxtWatermark.XOIsSearchBox = False
        TxtWatermark.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtWatermark.XOPilihSemuaSaatFokus = False
        TxtWatermark.XOPwdLengthMin = 8
        TxtWatermark.XOPwdStrengthCalculate = False
        TxtWatermark.XOPwdStrengthScore = 0
        TxtWatermark.XOPwdStrengthText = Nothing
        TxtWatermark.XORestriction = ControlCodeBase.enuRestriction.None
        TxtWatermark.XOSearchBoxText = "Watermark Text"
        TxtWatermark.XOSQLText = ""
        TxtWatermark.XOTanpaSpasi = False
        TxtWatermark.XOValidasiField = Nothing
        TxtWatermark.TabIndex = 3
        TxtWatermark.Tag = "txt"
        ' 
        ' Gbx1
        ' 
        Gbx1.Controls.Add(ULbl5)
        Gbx1.Controls.Add(ULbl4)
        Gbx1.Controls.Add(Lbl7)
        Gbx1.Controls.Add(nudUploadPDF)
        Gbx1.Controls.Add(Lbl6)
        Gbx1.Controls.Add(nudUploadPhoto)
        Gbx1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Gbx1.Location = New Point(18, 17)
        Gbx1.Margin = New Padding(4, 3, 4, 3)
        Gbx1.Name = "Gbx1"
        Gbx1.Padding = New Padding(4, 3, 4, 3)
        Gbx1.Size = New Size(478, 125)
        Gbx1.TabIndex = 11
        Gbx1.TabStop = False
        Gbx1.Text = "Upload Limit"
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(8, 75)
        ULbl5.Margin = New Padding(5, 6, 5, 6)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(175, 33)
        ULbl5.SLFText = "PDF"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 17
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(8, 35)
        ULbl4.Margin = New Padding(5, 6, 5, 6)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(175, 33)
        ULbl4.SLFText = "Photo"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 16
        ' 
        ' Lbl7
        ' 
        Lbl7.AutoSize = True
        Lbl7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl7.Location = New Point(338, 77)
        Lbl7.Margin = New Padding(4, 0, 4, 0)
        Lbl7.Name = "Lbl7"
        Lbl7.Size = New Size(33, 21)
        Lbl7.XOCustomElipsis = False
        Lbl7.TabIndex = 15
        Lbl7.Text = "MB"
        ' 
        ' nudUploadPDF
        ' 
        nudUploadPDF.Location = New Point(191, 75)
        nudUploadPDF.Margin = New Padding(4, 3, 4, 3)
        nudUploadPDF.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudUploadPDF.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudUploadPDF.Name = "nudUploadPDF"
        nudUploadPDF.Size = New Size(140, 29)
        nudUploadPDF.TabIndex = 1
        nudUploadPDF.TextAlign = HorizontalAlignment.Center
        nudUploadPDF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Lbl6
        ' 
        Lbl6.AutoSize = True
        Lbl6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl6.Location = New Point(338, 36)
        Lbl6.Margin = New Padding(4, 0, 4, 0)
        Lbl6.Name = "Lbl6"
        Lbl6.Size = New Size(33, 21)
        Lbl6.XOCustomElipsis = False
        Lbl6.TabIndex = 13
        Lbl6.Text = "MB"
        ' 
        ' nudUploadPhoto
        ' 
        nudUploadPhoto.Location = New Point(191, 35)
        nudUploadPhoto.Margin = New Padding(4, 3, 4, 3)
        nudUploadPhoto.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudUploadPhoto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudUploadPhoto.Name = "nudUploadPhoto"
        nudUploadPhoto.Size = New Size(140, 29)
        nudUploadPhoto.TabIndex = 0
        nudUploadPhoto.TextAlign = HorizontalAlignment.Center
        nudUploadPhoto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' tbSecurity
        ' 
        tbSecurity.Controls.Add(Gbx2)
        tbSecurity.Location = New Point(4, 30)
        tbSecurity.Margin = New Padding(4, 3, 4, 3)
        tbSecurity.Name = "tbSecurity"
        tbSecurity.Size = New Size(907, 477)
        tbSecurity.TabIndex = 2
        tbSecurity.Text = "SECURITY"
        tbSecurity.UseVisualStyleBackColor = True
        ' 
        ' Gbx2
        ' 
        Gbx2.Controls.Add(ULbl8)
        Gbx2.Controls.Add(nudMinPassword)
        Gbx2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Gbx2.Location = New Point(18, 17)
        Gbx2.Margin = New Padding(4, 3, 4, 3)
        Gbx2.Name = "Gbx2"
        Gbx2.Padding = New Padding(4, 3, 4, 3)
        Gbx2.Size = New Size(388, 99)
        Gbx2.TabIndex = 0
        Gbx2.TabStop = False
        Gbx2.Text = "Password"
        ' 
        ' ULbl8
        ' 
        ULbl8.BackColor = Color.Moccasin
        ULbl8.Location = New Point(8, 35)
        ULbl8.Margin = New Padding(5, 6, 5, 6)
        ULbl8.Name = "ULbl8"
        ULbl8.Size = New Size(175, 33)
        ULbl8.SLFText = "Minimum Length"
        ULbl8.SLFTextAdjuster = False
        ULbl8.SLFTextBorder = False
        ULbl8.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl8.TabIndex = 2
        ' 
        ' nudMinPassword
        ' 
        nudMinPassword.Location = New Point(191, 35)
        nudMinPassword.Margin = New Padding(4, 3, 4, 3)
        nudMinPassword.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudMinPassword.Name = "nudMinPassword"
        nudMinPassword.Size = New Size(140, 29)
        nudMinPassword.TabIndex = 0
        nudMinPassword.TextAlign = HorizontalAlignment.Center
        nudMinPassword.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Right
        BtnClose.BackColor = Color.Red
        BtnClose.Cursor = Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClose.ForeColor = Color.White
        BtnClose.Location = New Point(797, 3)
        BtnClose.Margin = New Padding(4, 3, 4, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(117, 46)
        BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.XOTampilkanFocusBorder = False
        BtnClose.XOValidasiSemuaInput = False
        BtnClose.XOValidasiSemuaInputTag = Nothing
        BtnClose.TabIndex = 805
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' BtnSave
        ' 
        BtnSave.Anchor = AnchorStyles.Right
        BtnSave.BackColor = Color.LimeGreen
        BtnSave.Cursor = Cursors.Hand
        BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnSave.FlatAppearance.BorderSize = 2
        BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Location = New Point(673, 3)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(117, 46)
        BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnSave.XOTampilkanFocusBorder = False
        BtnSave.XOValidasiSemuaInput = False
        BtnSave.XOValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 804
        BtnSave.Text = "&Save"
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' SYSS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "SYSS"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlSettings.ResumeLayout(False)
        tbInterface.ResumeLayout(False)
        GbxPanels.ResumeLayout(False)
        tbStorage.ResumeLayout(False)
        GbxWatermark.ResumeLayout(False)
        GbxWatermark.PerformLayout()
        Gbx1.ResumeLayout(False)
        Gbx1.PerformLayout()
        CType(nudUploadPDF, ComponentModel.ISupportInitialize).EndInit()
        CType(nudUploadPhoto, ComponentModel.ISupportInitialize).EndInit()
        tbSecurity.ResumeLayout(False)
        Gbx2.ResumeLayout(False)
        CType(nudMinPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TbctlSettings As tbctl
    Friend WithEvents tbInterface As TabPage
    Friend WithEvents CboProfile As cbo
    Friend WithEvents tbStorage As TabPage
    Friend WithEvents tbSecurity As TabPage
    Friend WithEvents CboNewsTicker As cbo
    Friend WithEvents CboStorage As cbo
    Friend WithEvents Gbx1 As gbx
    Friend WithEvents Lbl7 As lbl
    Friend WithEvents nudUploadPDF As NumericUpDown
    Friend WithEvents Lbl6 As lbl
    Friend WithEvents nudUploadPhoto As NumericUpDown
    Friend WithEvents GbxWatermark As gbx
    Friend WithEvents TxtWatermark As txt
    Friend WithEvents GbxPanels As gbx
    Friend WithEvents Gbx2 As gbx
    Friend WithEvents nudMinPassword As NumericUpDown
    Friend WithEvents CboWatermark As cbo
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents ULbl7 As ULbl
    Friend WithEvents ULbl6 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl8 As ULbl
    Friend WithEvents BtnClose As btn
    Friend WithEvents BtnSave As btn
End Class
