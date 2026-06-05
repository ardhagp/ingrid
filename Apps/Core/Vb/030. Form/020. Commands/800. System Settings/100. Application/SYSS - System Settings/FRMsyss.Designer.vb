Imports Syncfusion.Windows.Forms.Tools

Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMsyss
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
            TbctlSettings = New CMCv.UI.Control.Tbx(components)
            tbInterface = New TabPage()
            GbxPanels = New CMCv.UI.Control.gbx(components)
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl1 = New CMCv.UI.Control.ULbl()
            CboProfile = New CMCv.UI.Control.Cbo(components)
            CboStorage = New CMCv.UI.Control.Cbo(components)
            CboNewsTicker = New CMCv.UI.Control.Cbo(components)
            tbStorage = New TabPage()
            GbxWatermark = New CMCv.UI.Control.gbx(components)
            ULbl7 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            CboWatermark = New CMCv.UI.Control.Cbo(components)
            TxtWatermark = New CMCv.UI.Control.txt(components)
            Gbx1 = New CMCv.UI.Control.gbx(components)
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            Lbl7 = New CMCv.UI.Control.lbl(components)
            nudUploadPDF = New NumericUpDown()
            Lbl6 = New CMCv.UI.Control.lbl(components)
            nudUploadPhoto = New NumericUpDown()
            tbSecurity = New TabPage()
            Gbx2 = New CMCv.UI.Control.gbx(components)
            ULbl8 = New CMCv.UI.Control.ULbl()
            nudMinPassword = New NumericUpDown()
            BtnClose = New CMCv.UI.Control.Btn(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
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
            TxtFind.Margin = New Padding(7, 10, 7, 10)
            TxtFind.Visible = False
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TbctlSettings)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(TbctlSettings, 0)
            ' 
            ' TbctlSettings
            ' 
            TbctlSettings.Controls.Add(tbInterface)
            TbctlSettings.Controls.Add(tbStorage)
            TbctlSettings.Controls.Add(tbSecurity)
            TbctlSettings.Dock = DockStyle.Fill
            TbctlSettings.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlSettings.Location = New Point(0, 88)
            TbctlSettings.Margin = New Padding(6, 5, 6, 5)
            TbctlSettings.Name = "TbctlSettings"
            TbctlSettings.SelectedIndex = 0
            TbctlSettings.Size = New Size(1307, 864)
            TbctlSettings.TabIndex = 802
            ' 
            ' tbInterface
            ' 
            tbInterface.Controls.Add(GbxPanels)
            tbInterface.Location = New Point(4, 41)
            tbInterface.Margin = New Padding(6, 5, 6, 5)
            tbInterface.Name = "tbInterface"
            tbInterface.Padding = New Padding(6, 5, 6, 5)
            tbInterface.Size = New Size(1299, 819)
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
            GbxPanels.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            GbxPanels.Location = New Point(26, 28)
            GbxPanels.Margin = New Padding(6, 5, 6, 5)
            GbxPanels.Name = "GbxPanels"
            GbxPanels.Padding = New Padding(6, 5, 6, 5)
            GbxPanels.Size = New Size(614, 280)
            GbxPanels.TabIndex = 7
            GbxPanels.TabStop = False
            GbxPanels.Text = "Panel Visibility"
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(11, 192)
            ULbl3.Margin = New Padding(7, 10, 7, 10)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(267, 55)
            ULbl3.SLFText = "Show News Ticker"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.TabIndex = 9
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(11, 125)
            ULbl2.Margin = New Padding(7, 10, 7, 10)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(267, 55)
            ULbl2.SLFText = "Show Storage"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.TabIndex = 8
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(11, 58)
            ULbl1.Margin = New Padding(7, 10, 7, 10)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(267, 55)
            ULbl1.SLFText = "Show Profile"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.TabIndex = 7
            ' 
            ' CboProfile
            ' 
            CboProfile.DropDownStyle = ComboBoxStyle.DropDownList
            CboProfile.FlatStyle = FlatStyle.System
            CboProfile.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboProfile.FormattingEnabled = True
            CboProfile.Location = New Point(290, 58)
            CboProfile.Margin = New Padding(6, 5, 6, 5)
            CboProfile.Name = "CboProfile"
            CboProfile.Size = New Size(305, 40)
            CboProfile.TabIndex = 0
            ' 
            ' CboStorage
            ' 
            CboStorage.DropDownStyle = ComboBoxStyle.DropDownList
            CboStorage.FlatStyle = FlatStyle.System
            CboStorage.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboStorage.FormattingEnabled = True
            CboStorage.Location = New Point(290, 125)
            CboStorage.Margin = New Padding(6, 5, 6, 5)
            CboStorage.Name = "CboStorage"
            CboStorage.Size = New Size(307, 40)
            CboStorage.TabIndex = 1
            ' 
            ' CboNewsTicker
            ' 
            CboNewsTicker.DropDownStyle = ComboBoxStyle.DropDownList
            CboNewsTicker.FlatStyle = FlatStyle.System
            CboNewsTicker.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboNewsTicker.FormattingEnabled = True
            CboNewsTicker.Location = New Point(290, 192)
            CboNewsTicker.Margin = New Padding(6, 5, 6, 5)
            CboNewsTicker.Name = "CboNewsTicker"
            CboNewsTicker.Size = New Size(307, 40)
            CboNewsTicker.TabIndex = 2
            ' 
            ' tbStorage
            ' 
            tbStorage.Controls.Add(GbxWatermark)
            tbStorage.Controls.Add(Gbx1)
            tbStorage.Location = New Point(4, 41)
            tbStorage.Margin = New Padding(6, 5, 6, 5)
            tbStorage.Name = "tbStorage"
            tbStorage.Padding = New Padding(6, 5, 6, 5)
            tbStorage.Size = New Size(1859, 1397)
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
            GbxWatermark.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            GbxWatermark.Location = New Point(26, 248)
            GbxWatermark.Margin = New Padding(6, 5, 6, 5)
            GbxWatermark.Name = "GbxWatermark"
            GbxWatermark.Padding = New Padding(6, 5, 6, 5)
            GbxWatermark.Size = New Size(683, 205)
            GbxWatermark.TabIndex = 12
            GbxWatermark.TabStop = False
            GbxWatermark.Text = "Picture Watermark"
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.Moccasin
            ULbl7.Location = New Point(11, 125)
            ULbl7.Margin = New Padding(7, 10, 7, 10)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(250, 55)
            ULbl7.SLFText = "Text"
            ULbl7.SLFTextAdjuster = False
            ULbl7.SLFTextBorder = False
            ULbl7.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl7.TabIndex = 15
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(11, 58)
            ULbl6.Margin = New Padding(7, 10, 7, 10)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 55)
            ULbl6.SLFText = "Show To"
            ULbl6.SLFTextAdjuster = False
            ULbl6.SLFTextBorder = False
            ULbl6.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl6.TabIndex = 14
            ' 
            ' CboWatermark
            ' 
            CboWatermark.DropDownStyle = ComboBoxStyle.DropDownList
            CboWatermark.FlatStyle = FlatStyle.System
            CboWatermark.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboWatermark.FormattingEnabled = True
            CboWatermark.Location = New Point(273, 58)
            CboWatermark.Margin = New Padding(6, 5, 6, 5)
            CboWatermark.Name = "CboWatermark"
            CboWatermark.Size = New Size(305, 40)
            CboWatermark.TabIndex = 2
            ' 
            ' TxtWatermark
            ' 
            TxtWatermark.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtWatermark.Location = New Point(273, 125)
            TxtWatermark.Margin = New Padding(6, 5, 6, 5)
            TxtWatermark.MaxLength = 255
            TxtWatermark.Name = "TxtWatermark"
            TxtWatermark.Size = New Size(397, 39)
            TxtWatermark.TabIndex = 3
            TxtWatermark.Tag = "txt"
            TxtWatermark.XOAutoTrim = False
            TxtWatermark.XOIsMandatory = False
            TxtWatermark.XOMandatoryBgColor = Color.LightPink
            TxtWatermark.XOMandatoryBgColorDefault = Color.White
            TxtWatermark.XOHighlightOnFocus = False
            TxtWatermark.XOHighlightColor = Color.LightYellow
            TxtWatermark.XOIsBlank = True
            TxtWatermark.XOIsSearchBox = False
            TxtWatermark.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
            TxtWatermark.XOSelectOnFocus = False
            TxtWatermark.XOPasswordLengthMin = 8
            TxtWatermark.XOPasswordStrengthCalc = False
            TxtWatermark.XOPasswordStrengthScore = 0
            TxtWatermark.XOPasswordStrengthText = Nothing
            TxtWatermark.XORestriction = ControlCodeBase.enumRestriction.None
            TxtWatermark.XOSearchBoxText = "Watermark Text"
            TxtWatermark.XOSqlText = ""
            TxtWatermark.XOIsReplaceEmptyString = False
            TxtWatermark.XOMandatoryMessage = Nothing
            ' 
            ' Gbx1
            ' 
            Gbx1.Controls.Add(ULbl5)
            Gbx1.Controls.Add(ULbl4)
            Gbx1.Controls.Add(Lbl7)
            Gbx1.Controls.Add(nudUploadPDF)
            Gbx1.Controls.Add(Lbl6)
            Gbx1.Controls.Add(nudUploadPhoto)
            Gbx1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Gbx1.Location = New Point(26, 28)
            Gbx1.Margin = New Padding(6, 5, 6, 5)
            Gbx1.Name = "Gbx1"
            Gbx1.Padding = New Padding(6, 5, 6, 5)
            Gbx1.Size = New Size(683, 208)
            Gbx1.TabIndex = 11
            Gbx1.TabStop = False
            Gbx1.Text = "Upload Limit"
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(11, 125)
            ULbl5.Margin = New Padding(7, 10, 7, 10)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 55)
            ULbl5.SLFText = "PDF"
            ULbl5.SLFTextAdjuster = False
            ULbl5.SLFTextBorder = False
            ULbl5.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.TabIndex = 17
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(11, 58)
            ULbl4.Margin = New Padding(7, 10, 7, 10)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 55)
            ULbl4.SLFText = "Photo"
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.TabIndex = 16
            ' 
            ' Lbl7
            ' 
            Lbl7.AutoSize = True
            Lbl7.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl7.Location = New Point(483, 128)
            Lbl7.Margin = New Padding(6, 0, 6, 0)
            Lbl7.Name = "Lbl7"
            Lbl7.Size = New Size(50, 32)
            Lbl7.TabIndex = 15
            Lbl7.Text = "MB"
            Lbl7.XOCustomElipsis = False
            ' 
            ' nudUploadPDF
            ' 
            nudUploadPDF.Location = New Point(273, 125)
            nudUploadPDF.Margin = New Padding(6, 5, 6, 5)
            nudUploadPDF.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
            nudUploadPDF.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            nudUploadPDF.Name = "nudUploadPDF"
            nudUploadPDF.Size = New Size(200, 39)
            nudUploadPDF.TabIndex = 1
            nudUploadPDF.TextAlign = HorizontalAlignment.Center
            nudUploadPDF.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' Lbl6
            ' 
            Lbl6.AutoSize = True
            Lbl6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl6.Location = New Point(483, 60)
            Lbl6.Margin = New Padding(6, 0, 6, 0)
            Lbl6.Name = "Lbl6"
            Lbl6.Size = New Size(50, 32)
            Lbl6.TabIndex = 13
            Lbl6.Text = "MB"
            Lbl6.XOCustomElipsis = False
            ' 
            ' nudUploadPhoto
            ' 
            nudUploadPhoto.Location = New Point(273, 58)
            nudUploadPhoto.Margin = New Padding(6, 5, 6, 5)
            nudUploadPhoto.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
            nudUploadPhoto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            nudUploadPhoto.Name = "nudUploadPhoto"
            nudUploadPhoto.Size = New Size(200, 39)
            nudUploadPhoto.TabIndex = 0
            nudUploadPhoto.TextAlign = HorizontalAlignment.Center
            nudUploadPhoto.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' tbSecurity
            ' 
            tbSecurity.Controls.Add(Gbx2)
            tbSecurity.Location = New Point(4, 41)
            tbSecurity.Margin = New Padding(6, 5, 6, 5)
            tbSecurity.Name = "tbSecurity"
            tbSecurity.Size = New Size(1859, 1397)
            tbSecurity.TabIndex = 2
            tbSecurity.Text = "SECURITY"
            tbSecurity.UseVisualStyleBackColor = True
            ' 
            ' Gbx2
            ' 
            Gbx2.Controls.Add(ULbl8)
            Gbx2.Controls.Add(nudMinPassword)
            Gbx2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Gbx2.Location = New Point(26, 28)
            Gbx2.Margin = New Padding(6, 5, 6, 5)
            Gbx2.Name = "Gbx2"
            Gbx2.Padding = New Padding(6, 5, 6, 5)
            Gbx2.Size = New Size(554, 165)
            Gbx2.TabIndex = 0
            Gbx2.TabStop = False
            Gbx2.Text = "Password"
            ' 
            ' ULbl8
            ' 
            ULbl8.BackColor = Color.Moccasin
            ULbl8.Location = New Point(11, 58)
            ULbl8.Margin = New Padding(7, 10, 7, 10)
            ULbl8.Name = "ULbl8"
            ULbl8.Size = New Size(250, 55)
            ULbl8.SLFText = "Minimum Length"
            ULbl8.SLFTextAdjuster = False
            ULbl8.SLFTextBorder = False
            ULbl8.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl8.TabIndex = 2
            ' 
            ' nudMinPassword
            ' 
            nudMinPassword.Location = New Point(273, 58)
            nudMinPassword.Margin = New Padding(6, 5, 6, 5)
            nudMinPassword.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            nudMinPassword.Name = "nudMinPassword"
            nudMinPassword.Size = New Size(200, 39)
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
            BtnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnClose.ForeColor = Color.White
            BtnClose.Location = New Point(1139, 5)
            BtnClose.Margin = New Padding(6, 5, 6, 5)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(167, 77)
            BtnClose.TabIndex = 805
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = ControlCodeBase.buttonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
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
            BtnSave.Location = New Point(961, 5)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 804
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnSave.XOShowBorderOnFocus = False
            BtnSave.XOValidateAllInput = False
            BtnSave.XOValidateAllInputTag = Nothing
            ' 
            ' FRMsyss
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMsyss"
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
        Friend WithEvents TbctlSettings As CMCv.UI.Control.Tbx
        Friend WithEvents tbInterface As TabPage
        Friend WithEvents CboProfile As CMCv.UI.Control.Cbo
        Friend WithEvents tbStorage As TabPage
        Friend WithEvents tbSecurity As TabPage
        Friend WithEvents CboNewsTicker As CMCv.UI.Control.Cbo
        Friend WithEvents CboStorage As CMCv.UI.Control.Cbo
        Friend WithEvents Gbx1 As CMCv.UI.Control.gbx
        Friend WithEvents Lbl7 As CMCv.UI.Control.lbl
        Friend WithEvents nudUploadPDF As NumericUpDown
        Friend WithEvents Lbl6 As CMCv.UI.Control.lbl
        Friend WithEvents nudUploadPhoto As NumericUpDown
        Friend WithEvents GbxWatermark As CMCv.UI.Control.gbx
        Friend WithEvents TxtWatermark As CMCv.UI.Control.txt
        Friend WithEvents GbxPanels As CMCv.UI.Control.gbx
        Friend WithEvents Gbx2 As CMCv.UI.Control.gbx
        Friend WithEvents nudMinPassword As NumericUpDown
        Friend WithEvents CboWatermark As CMCv.UI.Control.Cbo
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl8 As CMCv.UI.Control.ULbl
        Friend WithEvents BtnClose As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
    End Class
End Namespace