Imports Syncfusion.Windows.Forms.Tools

Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMsyss
        Inherits CMCv.UI.Canvas.FRMstandardFind

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
            GbxPanels = New CMCv.UI.Control.Gbx(components)
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl1 = New CMCv.UI.Control.ULbl()
            CboProfile = New CMCv.UI.Control.Cbo(components)
            CboStorage = New CMCv.UI.Control.Cbo(components)
            CboNewsTicker = New CMCv.UI.Control.Cbo(components)
            tbStorage = New TabPage()
            Gbx3 = New CMCv.UI.Control.Gbx(components)
            TxtApiServiceUrl = New CMCv.UI.Control.Txt(components)
            ULblApiServiceUrl = New CMCv.UI.Control.ULbl()
            ULblApiSecret = New CMCv.UI.Control.ULbl()
            TxtApiSecret = New CMCv.UI.Control.Txt(components)
            TxtApiKey = New CMCv.UI.Control.Txt(components)
            CboStorageProvider = New CMCv.UI.Control.Cbo(components)
            ULblApiKey = New CMCv.UI.Control.ULbl()
            ULbl9 = New CMCv.UI.Control.ULbl()
            TxtFileDb = New CMCv.UI.Control.Txt(components)
            GbxWatermark = New CMCv.UI.Control.Gbx(components)
            ULbl7 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            CboWatermark = New CMCv.UI.Control.Cbo(components)
            TxtWatermark = New CMCv.UI.Control.Txt(components)
            Gbx1 = New CMCv.UI.Control.Gbx(components)
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            Lbl7 = New CMCv.UI.Control.Lbl(components)
            nudUploadPDF = New NumericUpDown()
            Lbl6 = New CMCv.UI.Control.Lbl(components)
            nudUploadPhoto = New NumericUpDown()
            tbSecurity = New TabPage()
            Gbx4 = New CMCv.UI.Control.Gbx(components)
            TxtClientName = New CMCv.UI.Control.Txt(components)
            TxtClientCode = New CMCv.UI.Control.Txt(components)
            ULbl11 = New CMCv.UI.Control.ULbl()
            ULbl10 = New CMCv.UI.Control.ULbl()
            Gbx2 = New CMCv.UI.Control.Gbx(components)
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
            Gbx3.SuspendLayout()
            GbxWatermark.SuspendLayout()
            Gbx1.SuspendLayout()
            CType(nudUploadPDF, ComponentModel.ISupportInitialize).BeginInit()
            CType(nudUploadPhoto, ComponentModel.ISupportInitialize).BeginInit()
            tbSecurity.SuspendLayout()
            Gbx4.SuspendLayout()
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
            SLFPanel.Size = New Size(1307, 946)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(TbctlSettings, 0)
            ' 
            ' TbctlSettings
            ' 
            TbctlSettings.Controls.Add(tbInterface)
            TbctlSettings.Controls.Add(tbStorage)
            TbctlSettings.Controls.Add(tbSecurity)
            TbctlSettings.Dock = DockStyle.Fill
            TbctlSettings.Font = New Font("Segoe UI", 12F)
            TbctlSettings.Location = New Point(0, 88)
            TbctlSettings.Margin = New Padding(6, 5, 6, 5)
            TbctlSettings.Name = "TbctlSettings"
            TbctlSettings.SelectedIndex = 0
            TbctlSettings.Size = New Size(1307, 858)
            TbctlSettings.TabIndex = 802
            ' 
            ' tbInterface
            ' 
            tbInterface.Controls.Add(GbxPanels)
            tbInterface.Location = New Point(4, 41)
            tbInterface.Margin = New Padding(6, 5, 6, 5)
            tbInterface.Name = "tbInterface"
            tbInterface.Padding = New Padding(6, 5, 6, 5)
            tbInterface.Size = New Size(1299, 813)
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
            GbxPanels.Font = New Font("Segoe UI", 12F)
            GbxPanels.Location = New Point(26, 28)
            GbxPanels.Margin = New Padding(6, 5, 6, 5)
            GbxPanels.Name = "GbxPanels"
            GbxPanels.Padding = New Padding(6, 5, 6, 5)
            GbxPanels.Size = New Size(683, 280)
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
            ULbl3.Size = New Size(267, 39)
            ULbl3.TabIndex = 9
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.XOText = "Show News Ticker"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(11, 125)
            ULbl2.Margin = New Padding(7, 10, 7, 10)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(267, 39)
            ULbl2.TabIndex = 8
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.XOText = "Show Storage"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(11, 58)
            ULbl1.Margin = New Padding(7, 10, 7, 10)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(267, 39)
            ULbl1.TabIndex = 7
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.XOText = "Show Profile"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ' 
            ' CboProfile
            ' 
            CboProfile.DropDownStyle = ComboBoxStyle.DropDownList
            CboProfile.FlatStyle = FlatStyle.System
            CboProfile.Font = New Font("Segoe UI", 12F)
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
            CboStorage.Font = New Font("Segoe UI", 12F)
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
            CboNewsTicker.Font = New Font("Segoe UI", 12F)
            CboNewsTicker.FormattingEnabled = True
            CboNewsTicker.Location = New Point(290, 192)
            CboNewsTicker.Margin = New Padding(6, 5, 6, 5)
            CboNewsTicker.Name = "CboNewsTicker"
            CboNewsTicker.Size = New Size(307, 40)
            CboNewsTicker.TabIndex = 2
            ' 
            ' tbStorage
            ' 
            tbStorage.AutoScroll = True
            tbStorage.Controls.Add(Gbx3)
            tbStorage.Controls.Add(GbxWatermark)
            tbStorage.Controls.Add(Gbx1)
            tbStorage.Location = New Point(4, 41)
            tbStorage.Margin = New Padding(6, 5, 6, 5)
            tbStorage.Name = "tbStorage"
            tbStorage.Padding = New Padding(6, 5, 6, 5)
            tbStorage.Size = New Size(1299, 813)
            tbStorage.TabIndex = 1
            tbStorage.Text = "STORAGE"
            tbStorage.UseVisualStyleBackColor = True
            ' 
            ' Gbx3
            ' 
            Gbx3.Controls.Add(TxtApiServiceUrl)
            Gbx3.Controls.Add(ULblApiServiceUrl)
            Gbx3.Controls.Add(ULblApiSecret)
            Gbx3.Controls.Add(TxtApiSecret)
            Gbx3.Controls.Add(TxtApiKey)
            Gbx3.Controls.Add(CboStorageProvider)
            Gbx3.Controls.Add(ULblApiKey)
            Gbx3.Controls.Add(ULbl9)
            Gbx3.Controls.Add(TxtFileDb)
            Gbx3.Font = New Font("Segoe UI", 12F)
            Gbx3.Location = New Point(26, 478)
            Gbx3.Name = "Gbx3"
            Gbx3.Size = New Size(683, 311)
            Gbx3.TabIndex = 13
            Gbx3.TabStop = False
            Gbx3.Text = "Cloud Storage Provider"
            ' 
            ' TxtApiServiceUrl
            ' 
            TxtApiServiceUrl.Font = New Font("Segoe UI", 12F)
            TxtApiServiceUrl.Location = New Point(273, 253)
            TxtApiServiceUrl.MaxLength = 255
            TxtApiServiceUrl.Name = "TxtApiServiceUrl"
            TxtApiServiceUrl.Size = New Size(397, 39)
            TxtApiServiceUrl.TabIndex = 5
            TxtApiServiceUrl.Tag = "txt"
            TxtApiServiceUrl.XOAutoTrim = False
            TxtApiServiceUrl.XOHighlightColor = Color.LightYellow
            TxtApiServiceUrl.XOHighlightOnFocus = True
            TxtApiServiceUrl.XOIsBlank = True
            TxtApiServiceUrl.XOIsMandatory = False
            TxtApiServiceUrl.XOIsPlaceholder = False
            TxtApiServiceUrl.XOIsReplaceEmptyString = False
            TxtApiServiceUrl.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtApiServiceUrl.XOMandatoryBgColor = Color.LightPink
            TxtApiServiceUrl.XOMandatoryBgColorDefault = Color.White
            TxtApiServiceUrl.XOMandatoryMessage = Nothing
            TxtApiServiceUrl.XOPasswordLengthMin = 8
            TxtApiServiceUrl.XOPasswordStrengthCalc = False
            TxtApiServiceUrl.XOPasswordStrengthScore = 0
            TxtApiServiceUrl.XOPasswordStrengthText = Nothing
            TxtApiServiceUrl.XOPlaceholderText = "Type then press Enter"
            TxtApiServiceUrl.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtApiServiceUrl.XOSelectOnFocus = False
            TxtApiServiceUrl.XOSqlText = ""
            ' 
            ' ULblApiServiceUrl
            ' 
            ULblApiServiceUrl.BackColor = Color.Moccasin
            ULblApiServiceUrl.Location = New Point(11, 253)
            ULblApiServiceUrl.Margin = New Padding(5, 6, 5, 6)
            ULblApiServiceUrl.Name = "ULblApiServiceUrl"
            ULblApiServiceUrl.Size = New Size(250, 39)
            ULblApiServiceUrl.TabIndex = 7
            ULblApiServiceUrl.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULblApiServiceUrl.XOText = "API Service URL"
            ULblApiServiceUrl.XOTextAdjuster = False
            ULblApiServiceUrl.XOTextBorder = False
            ' 
            ' ULblApiSecret
            ' 
            ULblApiSecret.BackColor = Color.Moccasin
            ULblApiSecret.Location = New Point(11, 190)
            ULblApiSecret.Margin = New Padding(5, 6, 5, 6)
            ULblApiSecret.Name = "ULblApiSecret"
            ULblApiSecret.Size = New Size(250, 39)
            ULblApiSecret.TabIndex = 5
            ULblApiSecret.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULblApiSecret.XOText = "API Secret"
            ULblApiSecret.XOTextAdjuster = False
            ULblApiSecret.XOTextBorder = False
            ' 
            ' TxtApiSecret
            ' 
            TxtApiSecret.Font = New Font("Segoe UI", 12F)
            TxtApiSecret.Location = New Point(273, 190)
            TxtApiSecret.MaxLength = 255
            TxtApiSecret.Name = "TxtApiSecret"
            TxtApiSecret.Size = New Size(397, 39)
            TxtApiSecret.TabIndex = 4
            TxtApiSecret.Tag = "txt"
            TxtApiSecret.XOAutoTrim = False
            TxtApiSecret.XOHighlightColor = Color.LightYellow
            TxtApiSecret.XOHighlightOnFocus = True
            TxtApiSecret.XOIsBlank = True
            TxtApiSecret.XOIsMandatory = False
            TxtApiSecret.XOIsPlaceholder = False
            TxtApiSecret.XOIsReplaceEmptyString = False
            TxtApiSecret.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtApiSecret.XOMandatoryBgColor = Color.LightPink
            TxtApiSecret.XOMandatoryBgColorDefault = Color.White
            TxtApiSecret.XOMandatoryMessage = Nothing
            TxtApiSecret.XOPasswordLengthMin = 8
            TxtApiSecret.XOPasswordStrengthCalc = False
            TxtApiSecret.XOPasswordStrengthScore = 0
            TxtApiSecret.XOPasswordStrengthText = Nothing
            TxtApiSecret.XOPlaceholderText = "Type then press Enter"
            TxtApiSecret.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtApiSecret.XOSelectOnFocus = False
            TxtApiSecret.XOSqlText = ""
            ' 
            ' TxtApiKey
            ' 
            TxtApiKey.Font = New Font("Segoe UI", 12F)
            TxtApiKey.Location = New Point(273, 128)
            TxtApiKey.MaxLength = 255
            TxtApiKey.Name = "TxtApiKey"
            TxtApiKey.Size = New Size(397, 39)
            TxtApiKey.TabIndex = 3
            TxtApiKey.Tag = "txt"
            TxtApiKey.XOAutoTrim = False
            TxtApiKey.XOHighlightColor = Color.LightYellow
            TxtApiKey.XOHighlightOnFocus = True
            TxtApiKey.XOIsBlank = True
            TxtApiKey.XOIsMandatory = False
            TxtApiKey.XOIsPlaceholder = False
            TxtApiKey.XOIsReplaceEmptyString = False
            TxtApiKey.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtApiKey.XOMandatoryBgColor = Color.LightPink
            TxtApiKey.XOMandatoryBgColorDefault = Color.White
            TxtApiKey.XOMandatoryMessage = Nothing
            TxtApiKey.XOPasswordLengthMin = 8
            TxtApiKey.XOPasswordStrengthCalc = False
            TxtApiKey.XOPasswordStrengthScore = 0
            TxtApiKey.XOPasswordStrengthText = Nothing
            TxtApiKey.XOPlaceholderText = "Type then press Enter"
            TxtApiKey.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtApiKey.XOSelectOnFocus = False
            TxtApiKey.XOSqlText = ""
            ' 
            ' CboStorageProvider
            ' 
            CboStorageProvider.DropDownStyle = ComboBoxStyle.DropDownList
            CboStorageProvider.FlatStyle = FlatStyle.Flat
            CboStorageProvider.Font = New Font("Segoe UI", 12F)
            CboStorageProvider.FormattingEnabled = True
            CboStorageProvider.Location = New Point(273, 62)
            CboStorageProvider.Name = "CboStorageProvider"
            CboStorageProvider.Size = New Size(305, 40)
            CboStorageProvider.TabIndex = 2
            ' 
            ' ULblApiKey
            ' 
            ULblApiKey.BackColor = Color.Moccasin
            ULblApiKey.Location = New Point(11, 128)
            ULblApiKey.Margin = New Padding(5, 6, 5, 6)
            ULblApiKey.Name = "ULblApiKey"
            ULblApiKey.Size = New Size(250, 39)
            ULblApiKey.TabIndex = 1
            ULblApiKey.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULblApiKey.XOText = "API Key"
            ULblApiKey.XOTextAdjuster = False
            ULblApiKey.XOTextBorder = False
            ' 
            ' ULbl9
            ' 
            ULbl9.BackColor = Color.Moccasin
            ULbl9.Location = New Point(11, 62)
            ULbl9.Margin = New Padding(5, 6, 5, 6)
            ULbl9.Name = "ULbl9"
            ULbl9.Size = New Size(250, 39)
            ULbl9.TabIndex = 0
            ULbl9.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl9.XOText = "Service Provider"
            ULbl9.XOTextAdjuster = False
            ULbl9.XOTextBorder = False
            ' 
            ' TxtFileDb
            ' 
            TxtFileDb.Font = New Font("Segoe UI", 12F)
            TxtFileDb.Location = New Point(273, 128)
            TxtFileDb.MaxLength = 255
            TxtFileDb.Name = "TxtFileDb"
            TxtFileDb.Size = New Size(397, 39)
            TxtFileDb.TabIndex = 3
            TxtFileDb.Tag = "txt"
            TxtFileDb.XOAutoTrim = False
            TxtFileDb.XOHighlightColor = Color.LightYellow
            TxtFileDb.XOHighlightOnFocus = True
            TxtFileDb.XOIsBlank = True
            TxtFileDb.XOIsMandatory = False
            TxtFileDb.XOIsPlaceholder = False
            TxtFileDb.XOIsReplaceEmptyString = False
            TxtFileDb.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtFileDb.XOMandatoryBgColor = Color.LightPink
            TxtFileDb.XOMandatoryBgColorDefault = Color.White
            TxtFileDb.XOMandatoryMessage = Nothing
            TxtFileDb.XOPasswordLengthMin = 8
            TxtFileDb.XOPasswordStrengthCalc = False
            TxtFileDb.XOPasswordStrengthScore = 0
            TxtFileDb.XOPasswordStrengthText = Nothing
            TxtFileDb.XOPlaceholderText = "Type then press Enter"
            TxtFileDb.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtFileDb.XOSelectOnFocus = False
            TxtFileDb.XOSqlText = ""
            ' 
            ' GbxWatermark
            ' 
            GbxWatermark.Controls.Add(ULbl7)
            GbxWatermark.Controls.Add(ULbl6)
            GbxWatermark.Controls.Add(CboWatermark)
            GbxWatermark.Controls.Add(TxtWatermark)
            GbxWatermark.Font = New Font("Segoe UI", 12F)
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
            ULbl7.Size = New Size(250, 39)
            ULbl7.TabIndex = 15
            ULbl7.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl7.XOText = "Text"
            ULbl7.XOTextAdjuster = False
            ULbl7.XOTextBorder = False
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(11, 58)
            ULbl6.Margin = New Padding(7, 10, 7, 10)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 39)
            ULbl6.TabIndex = 14
            ULbl6.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl6.XOText = "Show To"
            ULbl6.XOTextAdjuster = False
            ULbl6.XOTextBorder = False
            ' 
            ' CboWatermark
            ' 
            CboWatermark.DropDownStyle = ComboBoxStyle.DropDownList
            CboWatermark.FlatStyle = FlatStyle.System
            CboWatermark.Font = New Font("Segoe UI", 12F)
            CboWatermark.FormattingEnabled = True
            CboWatermark.Location = New Point(273, 58)
            CboWatermark.Margin = New Padding(6, 5, 6, 5)
            CboWatermark.Name = "CboWatermark"
            CboWatermark.Size = New Size(305, 40)
            CboWatermark.TabIndex = 2
            ' 
            ' TxtWatermark
            ' 
            TxtWatermark.Font = New Font("Segoe UI", 12F)
            TxtWatermark.Location = New Point(273, 125)
            TxtWatermark.Margin = New Padding(6, 5, 6, 5)
            TxtWatermark.MaxLength = 255
            TxtWatermark.Name = "TxtWatermark"
            TxtWatermark.Size = New Size(397, 39)
            TxtWatermark.TabIndex = 3
            TxtWatermark.Tag = "txt"
            TxtWatermark.XOAutoTrim = False
            TxtWatermark.XOHighlightColor = Color.LightYellow
            TxtWatermark.XOHighlightOnFocus = True
            TxtWatermark.XOIsBlank = True
            TxtWatermark.XOIsMandatory = False
            TxtWatermark.XOIsPlaceholder = False
            TxtWatermark.XOIsReplaceEmptyString = False
            TxtWatermark.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtWatermark.XOMandatoryBgColor = Color.LightPink
            TxtWatermark.XOMandatoryBgColorDefault = Color.White
            TxtWatermark.XOMandatoryMessage = Nothing
            TxtWatermark.XOPasswordLengthMin = 8
            TxtWatermark.XOPasswordStrengthCalc = False
            TxtWatermark.XOPasswordStrengthScore = 0
            TxtWatermark.XOPasswordStrengthText = Nothing
            TxtWatermark.XOPlaceholderText = "Watermark Text"
            TxtWatermark.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtWatermark.XOSelectOnFocus = False
            TxtWatermark.XOSqlText = ""
            ' 
            ' Gbx1
            ' 
            Gbx1.Controls.Add(ULbl5)
            Gbx1.Controls.Add(ULbl4)
            Gbx1.Controls.Add(Lbl7)
            Gbx1.Controls.Add(nudUploadPDF)
            Gbx1.Controls.Add(Lbl6)
            Gbx1.Controls.Add(nudUploadPhoto)
            Gbx1.Font = New Font("Segoe UI", 12F)
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
            ULbl5.Size = New Size(250, 39)
            ULbl5.TabIndex = 17
            ULbl5.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.XOText = "PDF"
            ULbl5.XOTextAdjuster = False
            ULbl5.XOTextBorder = False
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(11, 58)
            ULbl4.Margin = New Padding(7, 10, 7, 10)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 39)
            ULbl4.TabIndex = 16
            ULbl4.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.XOText = "Photo"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ' 
            ' Lbl7
            ' 
            Lbl7.AutoSize = True
            Lbl7.Font = New Font("Segoe UI", 12F)
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
            Lbl6.Font = New Font("Segoe UI", 12F)
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
            tbSecurity.Controls.Add(Gbx4)
            tbSecurity.Controls.Add(Gbx2)
            tbSecurity.Location = New Point(4, 41)
            tbSecurity.Margin = New Padding(6, 5, 6, 5)
            tbSecurity.Name = "tbSecurity"
            tbSecurity.Size = New Size(1299, 813)
            tbSecurity.TabIndex = 2
            tbSecurity.Text = "SECURITY"
            tbSecurity.UseVisualStyleBackColor = True
            ' 
            ' Gbx4
            ' 
            Gbx4.Controls.Add(TxtClientName)
            Gbx4.Controls.Add(TxtClientCode)
            Gbx4.Controls.Add(ULbl11)
            Gbx4.Controls.Add(ULbl10)
            Gbx4.Font = New Font("Segoe UI", 12F)
            Gbx4.Location = New Point(26, 218)
            Gbx4.Name = "Gbx4"
            Gbx4.Size = New Size(683, 187)
            Gbx4.TabIndex = 1
            Gbx4.TabStop = False
            Gbx4.Text = "Client"
            ' 
            ' TxtClientName
            ' 
            TxtClientName.Enabled = False
            TxtClientName.Font = New Font("Segoe UI", 12F)
            TxtClientName.Location = New Point(273, 120)
            TxtClientName.MaxLength = 255
            TxtClientName.Name = "TxtClientName"
            TxtClientName.Size = New Size(392, 39)
            TxtClientName.TabIndex = 2
            TxtClientName.Tag = "txt"
            TxtClientName.XOAutoTrim = False
            TxtClientName.XOHighlightColor = Color.LightYellow
            TxtClientName.XOHighlightOnFocus = True
            TxtClientName.XOIsBlank = True
            TxtClientName.XOIsMandatory = False
            TxtClientName.XOIsPlaceholder = False
            TxtClientName.XOIsReplaceEmptyString = False
            TxtClientName.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtClientName.XOMandatoryBgColor = Color.LightPink
            TxtClientName.XOMandatoryBgColorDefault = Color.White
            TxtClientName.XOMandatoryMessage = Nothing
            TxtClientName.XOPasswordLengthMin = 8
            TxtClientName.XOPasswordStrengthCalc = False
            TxtClientName.XOPasswordStrengthScore = 0
            TxtClientName.XOPasswordStrengthText = Nothing
            TxtClientName.XOPlaceholderText = "Type then press Enter"
            TxtClientName.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtClientName.XOSelectOnFocus = False
            TxtClientName.XOSqlText = ""
            ' 
            ' TxtClientCode
            ' 
            TxtClientCode.Enabled = False
            TxtClientCode.Font = New Font("Segoe UI", 12F)
            TxtClientCode.Location = New Point(273, 57)
            TxtClientCode.MaxLength = 255
            TxtClientCode.Name = "TxtClientCode"
            TxtClientCode.Size = New Size(392, 39)
            TxtClientCode.TabIndex = 1
            TxtClientCode.Tag = "txt"
            TxtClientCode.XOAutoTrim = False
            TxtClientCode.XOHighlightColor = Color.LightYellow
            TxtClientCode.XOHighlightOnFocus = True
            TxtClientCode.XOIsBlank = True
            TxtClientCode.XOIsMandatory = False
            TxtClientCode.XOIsPlaceholder = False
            TxtClientCode.XOIsReplaceEmptyString = False
            TxtClientCode.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtClientCode.XOMandatoryBgColor = Color.LightPink
            TxtClientCode.XOMandatoryBgColorDefault = Color.White
            TxtClientCode.XOMandatoryMessage = Nothing
            TxtClientCode.XOPasswordLengthMin = 8
            TxtClientCode.XOPasswordStrengthCalc = False
            TxtClientCode.XOPasswordStrengthScore = 0
            TxtClientCode.XOPasswordStrengthText = Nothing
            TxtClientCode.XOPlaceholderText = "Type then press Enter"
            TxtClientCode.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtClientCode.XOSelectOnFocus = False
            TxtClientCode.XOSqlText = ""
            ' 
            ' ULbl11
            ' 
            ULbl11.BackColor = Color.Moccasin
            ULbl11.Location = New Point(8, 120)
            ULbl11.Margin = New Padding(5, 6, 5, 6)
            ULbl11.Name = "ULbl11"
            ULbl11.Size = New Size(250, 39)
            ULbl11.TabIndex = 1
            ULbl11.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl11.XOText = "Client Name"
            ULbl11.XOTextAdjuster = False
            ULbl11.XOTextBorder = False
            ' 
            ' ULbl10
            ' 
            ULbl10.BackColor = Color.Moccasin
            ULbl10.Location = New Point(11, 57)
            ULbl10.Margin = New Padding(5, 6, 5, 6)
            ULbl10.Name = "ULbl10"
            ULbl10.Size = New Size(250, 39)
            ULbl10.TabIndex = 0
            ULbl10.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl10.XOText = "Client Code"
            ULbl10.XOTextAdjuster = False
            ULbl10.XOTextBorder = False
            ' 
            ' Gbx2
            ' 
            Gbx2.Controls.Add(ULbl8)
            Gbx2.Controls.Add(nudMinPassword)
            Gbx2.Font = New Font("Segoe UI", 12F)
            Gbx2.Location = New Point(26, 28)
            Gbx2.Margin = New Padding(6, 5, 6, 5)
            Gbx2.Name = "Gbx2"
            Gbx2.Padding = New Padding(6, 5, 6, 5)
            Gbx2.Size = New Size(683, 165)
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
            ULbl8.Size = New Size(250, 39)
            ULbl8.TabIndex = 2
            ULbl8.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl8.XOText = "Minimum Length"
            ULbl8.XOTextAdjuster = False
            ULbl8.XOTextBorder = False
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
            BtnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnClose.ForeColor = Color.White
            BtnClose.Location = New Point(1139, 5)
            BtnClose.Margin = New Padding(6, 5, 6, 5)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(167, 77)
            BtnClose.TabIndex = 805
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
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
            BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(961, 5)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 804
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
            BtnSave.XOShowBorderOnFocus = False
            BtnSave.XOValidateAllInput = False
            BtnSave.XOValidateAllInputTag = Nothing
            ' 
            ' FRMsyss
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1307, 1078)
            ControlBox = False
            Margin = New Padding(10, 5, 10, 5)
            MaximizeBox = False
            MinimizeBox = False
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
            Gbx3.ResumeLayout(False)
            Gbx3.PerformLayout()
            GbxWatermark.ResumeLayout(False)
            GbxWatermark.PerformLayout()
            Gbx1.ResumeLayout(False)
            Gbx1.PerformLayout()
            CType(nudUploadPDF, ComponentModel.ISupportInitialize).EndInit()
            CType(nudUploadPhoto, ComponentModel.ISupportInitialize).EndInit()
            tbSecurity.ResumeLayout(False)
            Gbx4.ResumeLayout(False)
            Gbx4.PerformLayout()
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
        Friend WithEvents Gbx1 As CMCv.UI.Control.Gbx
        Friend WithEvents Lbl7 As CMCv.UI.Control.Lbl
        Friend WithEvents nudUploadPDF As NumericUpDown
        Friend WithEvents Lbl6 As CMCv.UI.Control.Lbl
        Friend WithEvents nudUploadPhoto As NumericUpDown
        Friend WithEvents GbxWatermark As CMCv.UI.Control.Gbx
        Friend WithEvents TxtWatermark As CMCv.UI.Control.Txt
        Friend WithEvents GbxPanels As CMCv.UI.Control.Gbx
        Friend WithEvents Gbx2 As CMCv.UI.Control.Gbx
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
        Friend WithEvents Gbx3 As CMCv.UI.Control.Gbx
        Friend WithEvents ULbl9 As CMCv.UI.Control.ULbl
        Friend WithEvents ULblApiKey As CMCv.UI.Control.ULbl
        Friend WithEvents TxtApiKey As CMCv.UI.Control.Txt
        Friend WithEvents CboStorageProvider As CMCv.UI.Control.Cbo
        Friend WithEvents TxtApiSecret As CMCv.UI.Control.Txt
        Friend WithEvents ULblApiSecret As CMCv.UI.Control.ULbl
        Friend WithEvents TxtFileDb As CMCv.UI.Control.Txt
        Friend WithEvents ULblApiServiceUrl As CMCv.UI.Control.ULbl
        Friend WithEvents TxtApiServiceUrl As CMCv.UI.Control.Txt
        Friend WithEvents Gbx4 As CMCv.UI.Control.Gbx
        Friend WithEvents ULbl10 As CMCv.UI.Control.ULbl
        Friend WithEvents TxtClientName As CMCv.UI.Control.Txt
        Friend WithEvents TxtClientCode As CMCv.UI.Control.Txt
        Friend WithEvents ULbl11 As CMCv.UI.Control.ULbl
    End Class
End Namespace