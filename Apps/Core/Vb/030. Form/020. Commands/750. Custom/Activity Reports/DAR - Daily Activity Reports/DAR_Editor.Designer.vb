<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMdarEditor
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMdarEditor))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnSave = New btn(components)
        BtnCancel = New btn(components)
        CboTemplate = New cbo(components)
        DtpStart = New dtp(components)
        TxtContent = New txt(components)
        CboArea = New cbo(components)
        MebStart = New meb(components)
        BtnGETContent = New btn(components)
        ChkAddNew = New chk(components)
        MebEnd = New meb(components)
        DtpEnd = New dtp(components)
        TxtFeedback = New txt(components)
        OfdPhoto = New OpenFileDialog()
        TbctlAttachment = New tbctl(components)
        tpPhotos = New TabPage()
        PnlPhoto = New pnl(components)
        BtnBrowsePhoto = New btn(components)
        PctbxPhoto = New pctbx(components)
        DgnPictureList = New dgn(components)
        photo_id = New DataGridViewTextBoxColumn()
        photo_filename = New DataGridViewTextBoxColumn()
        photo_datetime = New DataGridViewTextBoxColumn()
        photo_content = New DataGridViewImageColumn()
        photo_status = New DataGridViewTextBoxColumn()
        photo_uploader = New DataGridViewTextBoxColumn()
        photo_delete = New DataGridViewButtonColumn()
        BtnPeekPhoto = New btn(components)
        TxtPhotoPath = New txt(components)
        BtnAddPhoto = New btn(components)
        tpFiles = New TabPage()
        PnlFile = New pnl(components)
        BtnBrowseFile = New btn(components)
        DgnFileList = New dgn(components)
        file_id = New DataGridViewTextBoxColumn()
        file_filename = New DataGridViewTextBoxColumn()
        file_tag = New DataGridViewTextBoxColumn()
        file_datetime = New DataGridViewTextBoxColumn()
        file_content = New DataGridViewTextBoxColumn()
        file_status = New DataGridViewTextBoxColumn()
        file_uploader = New DataGridViewTextBoxColumn()
        file_delete = New DataGridViewButtonColumn()
        CboFileTag = New cbo(components)
        TxtFilePath = New txt(components)
        BtnAddFile = New btn(components)
        BtnPeekFile = New btn(components)
        ofdFile = New OpenFileDialog()
        ULbl1 = New ULbl()
        ULbl2 = New ULbl()
        ULbl3 = New ULbl()
        ULbl4 = New ULbl()
        ULbl5 = New ULbl()
        ULbl6 = New ULbl()
        ULbl7 = New ULbl()
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        TbctlAttachment.SuspendLayout()
        tpPhotos.SuspendLayout()
        PnlPhoto.SuspendLayout()
        CType(PctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnPictureList, ComponentModel.ISupportInitialize).BeginInit()
        tpFiles.SuspendLayout()
        PnlFile.SuspendLayout()
        CType(DgnFileList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkAddNew)
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnSave)
        PnlBottomButton.Location = New Point(0, 1057)
        PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New Size(1190, 97)
        PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(1203, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.AutoScroll = True
        SLFPanel.AutoScrollMinSize = New Size(1, 1)
        SLFPanel.Controls.Add(ULbl7)
        SLFPanel.Controls.Add(ULbl6)
        SLFPanel.Controls.Add(ULbl5)
        SLFPanel.Controls.Add(ULbl4)
        SLFPanel.Controls.Add(ULbl3)
        SLFPanel.Controls.Add(ULbl2)
        SLFPanel.Controls.Add(ULbl1)
        SLFPanel.Controls.Add(TbctlAttachment)
        SLFPanel.Controls.Add(TxtFeedback)
        SLFPanel.Controls.Add(MebEnd)
        SLFPanel.Controls.Add(DtpEnd)
        SLFPanel.Controls.Add(BtnGETContent)
        SLFPanel.Controls.Add(MebStart)
        SLFPanel.Controls.Add(CboArea)
        SLFPanel.Controls.Add(TxtContent)
        SLFPanel.Controls.Add(DtpStart)
        SLFPanel.Controls.Add(CboTemplate)
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(1203, 1044)
        SLFPanel.Controls.SetChildIndex(CboTemplate, 0)
        SLFPanel.Controls.SetChildIndex(DtpStart, 0)
        SLFPanel.Controls.SetChildIndex(TxtContent, 0)
        SLFPanel.Controls.SetChildIndex(CboArea, 0)
        SLFPanel.Controls.SetChildIndex(MebStart, 0)
        SLFPanel.Controls.SetChildIndex(BtnGETContent, 0)
        SLFPanel.Controls.SetChildIndex(DtpEnd, 0)
        SLFPanel.Controls.SetChildIndex(MebEnd, 0)
        SLFPanel.Controls.SetChildIndex(TxtFeedback, 0)
        SLFPanel.Controls.SetChildIndex(TbctlAttachment, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(ULbl1, 0)
        SLFPanel.Controls.SetChildIndex(ULbl2, 0)
        SLFPanel.Controls.SetChildIndex(ULbl3, 0)
        SLFPanel.Controls.SetChildIndex(ULbl4, 0)
        SLFPanel.Controls.SetChildIndex(ULbl5, 0)
        SLFPanel.Controls.SetChildIndex(ULbl6, 0)
        SLFPanel.Controls.SetChildIndex(ULbl7, 0)
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
        BtnSave.Location = New Point(826, 13)
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
        BtnCancel.Location = New Point(1003, 13)
        BtnCancel.Margin = New Padding(6, 5, 6, 5)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(167, 77)
        BtnCancel.TabIndex = 602
        BtnCancel.Text = "&Close"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' CboTemplate
        ' 
        CboTemplate.DropDownStyle = ComboBoxStyle.DropDownList
        CboTemplate.DropDownWidth = 350
        CboTemplate.FlatStyle = FlatStyle.Flat
        CboTemplate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboTemplate.FormattingEnabled = True
        CboTemplate.Location = New Point(280, 222)
        CboTemplate.Margin = New Padding(6, 5, 6, 5)
        CboTemplate.Name = "CboTemplate"
        CboTemplate.Size = New Size(383, 40)
        CboTemplate.TabIndex = 5
        ' 
        ' DtpStart
        ' 
        DtpStart.CustomFormat = "dd MMMM yyyy"
        DtpStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpStart.Format = DateTimePickerFormat.Custom
        DtpStart.Location = New Point(280, 20)
        DtpStart.Margin = New Padding(6, 5, 6, 5)
        DtpStart.MaxDate = New Date(2026, 6, 13, 0, 0, 0, 0)
        DtpStart.MinDate = New Date(1916, 6, 13, 0, 0, 0, 0)
        DtpStart.Name = "DtpStart"
        DtpStart.Size = New Size(291, 39)
        DtpStart.TabIndex = 0
        DtpStart.XOResetOnDisabled = False
        ' 
        ' TxtContent
        ' 
        TxtContent.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContent.Location = New Point(280, 288)
        TxtContent.Margin = New Padding(6, 5, 6, 5)
        TxtContent.MaxLength = 99999999
        TxtContent.Multiline = True
        TxtContent.Name = "TxtContent"
        TxtContent.ScrollBars = ScrollBars.Vertical
        TxtContent.Size = New Size(901, 227)
        TxtContent.TabIndex = 7
        TxtContent.Tag = "txt"
        TxtContent.XOAutoTrim = True
        TxtContent.XOHarusDiisi = True
        TxtContent.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtContent.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtContent.XOHightlightSaatFokus = True
        TxtContent.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtContent.XOIsBlank = True
        TxtContent.XOIsSearchBox = False
        TxtContent.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtContent.XOPilihSemuaSaatFokus = False
        TxtContent.XOPwdLengthMin = 8
        TxtContent.XOPwdStrengthCalculate = False
        TxtContent.XOPwdStrengthScore = 0
        TxtContent.XOPwdStrengthText = Nothing
        TxtContent.XORestriction = ControlCodeBase.enuRestriction.None
        TxtContent.XOSearchBoxText = "Type then press Enter"
        TxtContent.XOSQLText = Nothing
        TxtContent.XOTanpaSpasi = False
        TxtContent.XOValidasiField = Nothing
        ' 
        ' CboArea
        ' 
        CboArea.DropDownStyle = ComboBoxStyle.DropDownList
        CboArea.DropDownWidth = 350
        CboArea.FlatStyle = FlatStyle.Flat
        CboArea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboArea.FormattingEnabled = True
        CboArea.Location = New Point(280, 153)
        CboArea.Margin = New Padding(6, 5, 6, 5)
        CboArea.Name = "CboArea"
        CboArea.Size = New Size(383, 40)
        CboArea.TabIndex = 4
        ' 
        ' MebStart
        ' 
        MebStart.AsciiOnly = True
        MebStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MebStart.Location = New Point(583, 20)
        MebStart.Margin = New Padding(6, 5, 6, 5)
        MebStart.Mask = "00:00"
        MebStart.Name = "MebStart"
        MebStart.Size = New Size(78, 39)
        MebStart.TabIndex = 1
        MebStart.TextAlign = HorizontalAlignment.Center
        MebStart.ValidatingType = GetType(Date)
        MebStart.XOHarusDiisi = True
        MebStart.XOHarusDiisiWarnaLatar = Color.LightPink
        MebStart.XOHarusDiisiWarnaLatarDefault = Color.White
        MebStart.XOHightlightSaatFokus = True
        MebStart.XOHightlightSaatFokusWarna = Color.LightYellow
        MebStart.XOPilihSemuaSaatFokus = True
        ' 
        ' BtnGETContent
        ' 
        BtnGETContent.BackColor = Color.RoyalBlue
        BtnGETContent.Cursor = Cursors.Hand
        BtnGETContent.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnGETContent.FlatAppearance.BorderSize = 2
        BtnGETContent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnGETContent.FlatStyle = FlatStyle.Flat
        BtnGETContent.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnGETContent.ForeColor = Color.White
        BtnGETContent.Location = New Point(674, 208)
        BtnGETContent.Margin = New Padding(6, 5, 6, 5)
        BtnGETContent.Name = "BtnGETContent"
        BtnGETContent.Size = New Size(167, 77)
        BtnGETContent.TabIndex = 6
        BtnGETContent.Text = "Apply"
        BtnGETContent.UseVisualStyleBackColor = False
        BtnGETContent.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnGETContent.XOTampilkanFocusBorder = False
        BtnGETContent.XOValidasiSemuaInput = False
        BtnGETContent.XOValidasiSemuaInputTag = Nothing
        ' 
        ' ChkAddNew
        ' 
        ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ChkAddNew.AutoSize = True
        ChkAddNew.BackColor = Color.Transparent
        ChkAddNew.FlatStyle = FlatStyle.Flat
        ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkAddNew.ForeColor = Color.Tomato
        ChkAddNew.Location = New Point(595, 28)
        ChkAddNew.Margin = New Padding(6, 5, 6, 5)
        ChkAddNew.Name = "ChkAddNew"
        ChkAddNew.Size = New Size(221, 36)
        ChkAddNew.TabIndex = 601
        ChkAddNew.Text = "Add new on Save"
        ChkAddNew.UseVisualStyleBackColor = False
        ' 
        ' MebEnd
        ' 
        MebEnd.AsciiOnly = True
        MebEnd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MebEnd.Location = New Point(583, 87)
        MebEnd.Margin = New Padding(6, 5, 6, 5)
        MebEnd.Mask = "00:00"
        MebEnd.Name = "MebEnd"
        MebEnd.Size = New Size(78, 39)
        MebEnd.TabIndex = 3
        MebEnd.TextAlign = HorizontalAlignment.Center
        MebEnd.ValidatingType = GetType(Date)
        MebEnd.XOHarusDiisi = True
        MebEnd.XOHarusDiisiWarnaLatar = Color.LightPink
        MebEnd.XOHarusDiisiWarnaLatarDefault = Color.White
        MebEnd.XOHightlightSaatFokus = True
        MebEnd.XOHightlightSaatFokusWarna = Color.LightYellow
        MebEnd.XOPilihSemuaSaatFokus = True
        ' 
        ' DtpEnd
        ' 
        DtpEnd.CustomFormat = "dd MMMM yyyy"
        DtpEnd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpEnd.Format = DateTimePickerFormat.Custom
        DtpEnd.Location = New Point(280, 87)
        DtpEnd.Margin = New Padding(6, 5, 6, 5)
        DtpEnd.MaxDate = New Date(2026, 6, 13, 0, 0, 0, 0)
        DtpEnd.MinDate = New Date(1916, 6, 13, 0, 0, 0, 0)
        DtpEnd.Name = "DtpEnd"
        DtpEnd.Size = New Size(291, 39)
        DtpEnd.TabIndex = 2
        DtpEnd.XOResetOnDisabled = False
        ' 
        ' TxtFeedback
        ' 
        TxtFeedback.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFeedback.Location = New Point(280, 530)
        TxtFeedback.Margin = New Padding(6, 5, 6, 5)
        TxtFeedback.MaxLength = 255
        TxtFeedback.Multiline = True
        TxtFeedback.Name = "TxtFeedback"
        TxtFeedback.ScrollBars = ScrollBars.Vertical
        TxtFeedback.Size = New Size(901, 116)
        TxtFeedback.TabIndex = 8
        TxtFeedback.Tag = "txt"
        TxtFeedback.XOAutoTrim = True
        TxtFeedback.XOHarusDiisi = False
        TxtFeedback.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtFeedback.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtFeedback.XOHightlightSaatFokus = True
        TxtFeedback.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtFeedback.XOIsBlank = True
        TxtFeedback.XOIsSearchBox = False
        TxtFeedback.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        TxtFeedback.XOPilihSemuaSaatFokus = False
        TxtFeedback.XOPwdLengthMin = 8
        TxtFeedback.XOPwdStrengthCalculate = False
        TxtFeedback.XOPwdStrengthScore = 0
        TxtFeedback.XOPwdStrengthText = Nothing
        TxtFeedback.XORestriction = ControlCodeBase.enuRestriction.None
        TxtFeedback.XOSearchBoxText = "Type then press Enter"
        TxtFeedback.XOSQLText = ""
        TxtFeedback.XOTanpaSpasi = False
        TxtFeedback.XOValidasiField = Nothing
        ' 
        ' OfdPhoto
        ' 
        OfdPhoto.FileName = "OpenFileDialog1"
        ' 
        ' TbctlAttachment
        ' 
        TbctlAttachment.Controls.Add(tpPhotos)
        TbctlAttachment.Controls.Add(tpFiles)
        TbctlAttachment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlAttachment.Location = New Point(280, 662)
        TbctlAttachment.Margin = New Padding(6, 5, 6, 5)
        TbctlAttachment.Name = "TbctlAttachment"
        TbctlAttachment.SelectedIndex = 0
        TbctlAttachment.Size = New Size(910, 395)
        TbctlAttachment.TabIndex = 1002
        ' 
        ' tpPhotos
        ' 
        tpPhotos.AutoScroll = True
        tpPhotos.AutoScrollMinSize = New Size(1, 1)
        tpPhotos.Controls.Add(PnlPhoto)
        tpPhotos.Location = New Point(4, 41)
        tpPhotos.Margin = New Padding(6, 5, 6, 5)
        tpPhotos.Name = "tpPhotos"
        tpPhotos.Padding = New Padding(6, 5, 6, 5)
        tpPhotos.Size = New Size(902, 350)
        tpPhotos.TabIndex = 0
        tpPhotos.Text = "Photos"
        tpPhotos.UseVisualStyleBackColor = True
        ' 
        ' PnlPhoto
        ' 
        PnlPhoto.Controls.Add(BtnBrowsePhoto)
        PnlPhoto.Controls.Add(PctbxPhoto)
        PnlPhoto.Controls.Add(DgnPictureList)
        PnlPhoto.Controls.Add(BtnPeekPhoto)
        PnlPhoto.Controls.Add(TxtPhotoPath)
        PnlPhoto.Controls.Add(BtnAddPhoto)
        PnlPhoto.Dock = DockStyle.Fill
        PnlPhoto.Location = New Point(6, 5)
        PnlPhoto.Margin = New Padding(6, 5, 6, 5)
        PnlPhoto.Name = "PnlPhoto"
        PnlPhoto.Size = New Size(890, 340)
        PnlPhoto.TabIndex = 11
        ' 
        ' BtnBrowsePhoto
        ' 
        BtnBrowsePhoto.BackColor = Color.Black
        BtnBrowsePhoto.Cursor = Cursors.Hand
        BtnBrowsePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnBrowsePhoto.FlatAppearance.BorderSize = 2
        BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnBrowsePhoto.FlatStyle = FlatStyle.Flat
        BtnBrowsePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowsePhoto.ForeColor = Color.White
        BtnBrowsePhoto.Image = My.Resources.Resources.FOLDER_001_16_ICON
        BtnBrowsePhoto.Location = New Point(6, 5)
        BtnBrowsePhoto.Margin = New Padding(6, 5, 6, 5)
        BtnBrowsePhoto.Name = "BtnBrowsePhoto"
        BtnBrowsePhoto.Size = New Size(54, 55)
        BtnBrowsePhoto.TabIndex = 5
        BtnBrowsePhoto.UseVisualStyleBackColor = False
        BtnBrowsePhoto.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnBrowsePhoto.XOTampilkanFocusBorder = False
        BtnBrowsePhoto.XOValidasiSemuaInput = False
        BtnBrowsePhoto.XOValidasiSemuaInputTag = Nothing
        ' 
        ' PctbxPhoto
        ' 
        PctbxPhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        PctbxPhoto.BackColor = Color.DarkSlateGray
        PctbxPhoto.BackgroundImage = My.Resources.Resources.PCTPRV_001_512_icon
        PctbxPhoto.BackgroundImageLayout = ImageLayout.Zoom
        PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), Image)
        PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), Image)
        PctbxPhoto.Location = New Point(616, 5)
        PctbxPhoto.Margin = New Padding(6, 5, 6, 5)
        PctbxPhoto.Name = "PctbxPhoto"
        PctbxPhoto.Size = New Size(269, 335)
        PctbxPhoto.SizeMode = PictureBoxSizeMode.Zoom
        PctbxPhoto.TabIndex = 6
        PctbxPhoto.TabStop = False
        PctbxPhoto.XOTampilkanBorder = False
        PctbxPhoto.XOWarnaBorder = Color.DodgerBlue
        ' 
        ' DgnPictureList
        ' 
        DgnPictureList.AllowUserToAddRows = False
        DgnPictureList.AllowUserToDeleteRows = False
        DgnPictureList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(247), CByte(236), CByte(167))
        DgnPictureList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnPictureList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgnPictureList.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnPictureList.BorderStyle = BorderStyle.None
        DgnPictureList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnPictureList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnPictureList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnPictureList.ColumnHeadersHeight = 43
        DgnPictureList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnPictureList.Columns.AddRange(New DataGridViewColumn() {photo_id, photo_filename, photo_datetime, photo_content, photo_status, photo_uploader, photo_delete})
        DgnPictureList.EnableHeadersVisualStyles = False
        DgnPictureList.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnPictureList.Location = New Point(6, 73)
        DgnPictureList.Margin = New Padding(6, 5, 6, 5)
        DgnPictureList.MultiSelect = False
        DgnPictureList.Name = "DgnPictureList"
        DgnPictureList.ReadOnly = True
        DgnPictureList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnPictureList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnPictureList.RowHeadersWidth = 62
        DgnPictureList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnPictureList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgnPictureList.Size = New Size(602, 262)
        DgnPictureList.StandardTab = True
        DgnPictureList.TabIndex = 10
        DgnPictureList.XOGroupFirstRows = False
        DgnPictureList.XOGunakanNomorBaris = True
        ' 
        ' photo_id
        ' 
        photo_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        photo_id.DataPropertyName = "file_id"
        photo_id.HeaderText = "ID"
        photo_id.MinimumWidth = 8
        photo_id.Name = "photo_id"
        photo_id.ReadOnly = True
        photo_id.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_id.Visible = False
        ' 
        ' photo_filename
        ' 
        photo_filename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        photo_filename.DataPropertyName = "file_filename"
        photo_filename.HeaderText = "File Name"
        photo_filename.MinimumWidth = 8
        photo_filename.Name = "photo_filename"
        photo_filename.ReadOnly = True
        ' 
        ' photo_datetime
        ' 
        photo_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo_datetime.DataPropertyName = "file_datetime"
        photo_datetime.HeaderText = "Date Added"
        photo_datetime.MinimumWidth = 8
        photo_datetime.Name = "photo_datetime"
        photo_datetime.ReadOnly = True
        photo_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_datetime.Width = 127
        ' 
        ' photo_content
        ' 
        photo_content.DataPropertyName = "file_content"
        photo_content.HeaderText = "Photo"
        photo_content.MinimumWidth = 8
        photo_content.Name = "photo_content"
        photo_content.ReadOnly = True
        photo_content.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_content.Visible = False
        photo_content.Width = 150
        ' 
        ' photo_status
        ' 
        photo_status.DataPropertyName = "file_status"
        photo_status.HeaderText = "Status"
        photo_status.MinimumWidth = 8
        photo_status.Name = "photo_status"
        photo_status.ReadOnly = True
        photo_status.SortMode = DataGridViewColumnSortMode.NotSortable
        photo_status.Visible = False
        photo_status.Width = 150
        ' 
        ' photo_uploader
        ' 
        photo_uploader.DataPropertyName = "file_uploader"
        photo_uploader.HeaderText = "Uploader"
        photo_uploader.MinimumWidth = 8
        photo_uploader.Name = "photo_uploader"
        photo_uploader.ReadOnly = True
        photo_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_uploader.Visible = False
        photo_uploader.Width = 150
        ' 
        ' photo_delete
        ' 
        photo_delete.DataPropertyName = "file_delete"
        photo_delete.HeaderText = ""
        photo_delete.MinimumWidth = 8
        photo_delete.Name = "photo_delete"
        photo_delete.ReadOnly = True
        photo_delete.Text = "🗑"
        photo_delete.ToolTipText = "Delete"
        photo_delete.UseColumnTextForButtonValue = True
        photo_delete.Width = 19
        ' 
        ' BtnPeekPhoto
        ' 
        BtnPeekPhoto.BackColor = Color.Black
        BtnPeekPhoto.Cursor = Cursors.Hand
        BtnPeekPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnPeekPhoto.FlatAppearance.BorderSize = 2
        BtnPeekPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnPeekPhoto.FlatStyle = FlatStyle.Flat
        BtnPeekPhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPeekPhoto.ForeColor = Color.White
        BtnPeekPhoto.Image = My.Resources.Resources.ZOOMNORMAL_001_16_ICON
        BtnPeekPhoto.Location = New Point(483, 5)
        BtnPeekPhoto.Margin = New Padding(6, 5, 6, 5)
        BtnPeekPhoto.Name = "BtnPeekPhoto"
        BtnPeekPhoto.Size = New Size(54, 55)
        BtnPeekPhoto.TabIndex = 8
        BtnPeekPhoto.UseVisualStyleBackColor = False
        BtnPeekPhoto.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnPeekPhoto.XOTampilkanFocusBorder = False
        BtnPeekPhoto.XOValidasiSemuaInput = False
        BtnPeekPhoto.XOValidasiSemuaInputTag = Nothing
        ' 
        ' TxtPhotoPath
        ' 
        TxtPhotoPath.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPhotoPath.Location = New Point(70, 5)
        TxtPhotoPath.Margin = New Padding(6, 5, 6, 5)
        TxtPhotoPath.MaxLength = 255
        TxtPhotoPath.Name = "TxtPhotoPath"
        TxtPhotoPath.ReadOnly = True
        TxtPhotoPath.Size = New Size(401, 39)
        TxtPhotoPath.TabIndex = 7
        TxtPhotoPath.Tag = "txt"
        TxtPhotoPath.XOAutoTrim = False
        TxtPhotoPath.XOHarusDiisi = False
        TxtPhotoPath.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPhotoPath.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPhotoPath.XOHightlightSaatFokus = False
        TxtPhotoPath.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPhotoPath.XOIsBlank = True
        TxtPhotoPath.XOIsSearchBox = False
        TxtPhotoPath.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPhotoPath.XOPilihSemuaSaatFokus = False
        TxtPhotoPath.XOPwdLengthMin = 8
        TxtPhotoPath.XOPwdStrengthCalculate = False
        TxtPhotoPath.XOPwdStrengthScore = 0
        TxtPhotoPath.XOPwdStrengthText = Nothing
        TxtPhotoPath.XORestriction = ControlCodeBase.enuRestriction.None
        TxtPhotoPath.XOSearchBoxText = "Type then press Enter"
        TxtPhotoPath.XOSQLText = ""
        TxtPhotoPath.XOTanpaSpasi = False
        TxtPhotoPath.XOValidasiField = Nothing
        ' 
        ' BtnAddPhoto
        ' 
        BtnAddPhoto.BackColor = Color.Black
        BtnAddPhoto.Cursor = Cursors.Hand
        BtnAddPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnAddPhoto.FlatAppearance.BorderSize = 2
        BtnAddPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnAddPhoto.FlatStyle = FlatStyle.Flat
        BtnAddPhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAddPhoto.ForeColor = Color.White
        BtnAddPhoto.Image = My.Resources.Resources.ADD_001_16_ICON
        BtnAddPhoto.Location = New Point(549, 5)
        BtnAddPhoto.Margin = New Padding(6, 5, 6, 5)
        BtnAddPhoto.Name = "BtnAddPhoto"
        BtnAddPhoto.Size = New Size(54, 55)
        BtnAddPhoto.TabIndex = 9
        BtnAddPhoto.UseVisualStyleBackColor = False
        BtnAddPhoto.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnAddPhoto.XOTampilkanFocusBorder = False
        BtnAddPhoto.XOValidasiSemuaInput = False
        BtnAddPhoto.XOValidasiSemuaInputTag = Nothing
        ' 
        ' tpFiles
        ' 
        tpFiles.Controls.Add(PnlFile)
        tpFiles.Location = New Point(4, 41)
        tpFiles.Margin = New Padding(6, 5, 6, 5)
        tpFiles.Name = "tpFiles"
        tpFiles.Padding = New Padding(6, 5, 6, 5)
        tpFiles.Size = New Size(902, 350)
        tpFiles.TabIndex = 1
        tpFiles.Text = "PDF"
        tpFiles.UseVisualStyleBackColor = True
        ' 
        ' PnlFile
        ' 
        PnlFile.Controls.Add(BtnBrowseFile)
        PnlFile.Controls.Add(DgnFileList)
        PnlFile.Controls.Add(CboFileTag)
        PnlFile.Controls.Add(TxtFilePath)
        PnlFile.Controls.Add(BtnAddFile)
        PnlFile.Controls.Add(BtnPeekFile)
        PnlFile.Dock = DockStyle.Fill
        PnlFile.Location = New Point(6, 5)
        PnlFile.Margin = New Padding(6, 5, 6, 5)
        PnlFile.Name = "PnlFile"
        PnlFile.Size = New Size(890, 340)
        PnlFile.TabIndex = 16
        ' 
        ' BtnBrowseFile
        ' 
        BtnBrowseFile.BackColor = Color.Black
        BtnBrowseFile.Cursor = Cursors.Hand
        BtnBrowseFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnBrowseFile.FlatAppearance.BorderSize = 2
        BtnBrowseFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnBrowseFile.FlatStyle = FlatStyle.Flat
        BtnBrowseFile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBrowseFile.ForeColor = Color.White
        BtnBrowseFile.Image = My.Resources.Resources.FOLDER_001_16_ICON
        BtnBrowseFile.Location = New Point(6, 5)
        BtnBrowseFile.Margin = New Padding(6, 5, 6, 5)
        BtnBrowseFile.Name = "BtnBrowseFile"
        BtnBrowseFile.Size = New Size(54, 55)
        BtnBrowseFile.TabIndex = 10
        BtnBrowseFile.UseVisualStyleBackColor = False
        BtnBrowseFile.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnBrowseFile.XOTampilkanFocusBorder = False
        BtnBrowseFile.XOValidasiSemuaInput = False
        BtnBrowseFile.XOValidasiSemuaInputTag = Nothing
        ' 
        ' DgnFileList
        ' 
        DgnFileList.AllowUserToAddRows = False
        DgnFileList.AllowUserToDeleteRows = False
        DgnFileList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(238), CByte(213), CByte(101))
        DgnFileList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DgnFileList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgnFileList.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnFileList.BorderStyle = BorderStyle.None
        DgnFileList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnFileList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnFileList.ColumnHeadersHeight = 43
        DgnFileList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnFileList.Columns.AddRange(New DataGridViewColumn() {file_id, file_filename, file_tag, file_datetime, file_content, file_status, file_uploader, file_delete})
        DgnFileList.EnableHeadersVisualStyles = False
        DgnFileList.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnFileList.Location = New Point(6, 73)
        DgnFileList.Margin = New Padding(6, 5, 6, 5)
        DgnFileList.MultiSelect = False
        DgnFileList.Name = "DgnFileList"
        DgnFileList.ReadOnly = True
        DgnFileList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnFileList.RowHeadersWidth = 62
        DgnFileList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnFileList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgnFileList.Size = New Size(880, 262)
        DgnFileList.StandardTab = True
        DgnFileList.TabIndex = 14
        DgnFileList.XOGroupFirstRows = False
        DgnFileList.XOGunakanNomorBaris = True
        ' 
        ' file_id
        ' 
        file_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        file_id.DataPropertyName = "file_id"
        file_id.HeaderText = "ID"
        file_id.MinimumWidth = 8
        file_id.Name = "file_id"
        file_id.ReadOnly = True
        file_id.SortMode = DataGridViewColumnSortMode.Programmatic
        file_id.Visible = False
        ' 
        ' file_filename
        ' 
        file_filename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        file_filename.DataPropertyName = "file_name"
        file_filename.HeaderText = "File Name"
        file_filename.MinimumWidth = 8
        file_filename.Name = "file_filename"
        file_filename.ReadOnly = True
        ' 
        ' file_tag
        ' 
        file_tag.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_tag.DataPropertyName = "file_tag"
        file_tag.HeaderText = "Tag"
        file_tag.MinimumWidth = 8
        file_tag.Name = "file_tag"
        file_tag.ReadOnly = True
        file_tag.SortMode = DataGridViewColumnSortMode.Programmatic
        file_tag.Width = 70
        ' 
        ' file_datetime
        ' 
        file_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_datetime.DataPropertyName = "file_datetime"
        file_datetime.HeaderText = "Date Added"
        file_datetime.MinimumWidth = 8
        file_datetime.Name = "file_datetime"
        file_datetime.ReadOnly = True
        file_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
        file_datetime.Width = 127
        ' 
        ' file_content
        ' 
        file_content.DataPropertyName = "file_content"
        file_content.HeaderText = "File"
        file_content.MinimumWidth = 8
        file_content.Name = "file_content"
        file_content.ReadOnly = True
        file_content.Resizable = DataGridViewTriState.True
        file_content.SortMode = DataGridViewColumnSortMode.Programmatic
        file_content.Visible = False
        file_content.Width = 150
        ' 
        ' file_status
        ' 
        file_status.DataPropertyName = "file_status"
        file_status.HeaderText = "Status"
        file_status.MinimumWidth = 8
        file_status.Name = "file_status"
        file_status.ReadOnly = True
        file_status.SortMode = DataGridViewColumnSortMode.NotSortable
        file_status.Visible = False
        file_status.Width = 150
        ' 
        ' file_uploader
        ' 
        file_uploader.DataPropertyName = "file_uploader"
        file_uploader.HeaderText = "Uploader"
        file_uploader.MinimumWidth = 8
        file_uploader.Name = "file_uploader"
        file_uploader.ReadOnly = True
        file_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
        file_uploader.Visible = False
        file_uploader.Width = 150
        ' 
        ' file_delete
        ' 
        file_delete.DataPropertyName = "file_delete"
        file_delete.HeaderText = ""
        file_delete.MinimumWidth = 8
        file_delete.Name = "file_delete"
        file_delete.ReadOnly = True
        file_delete.Text = "🗑"
        file_delete.ToolTipText = "Delete"
        file_delete.UseColumnTextForButtonValue = True
        file_delete.Width = 19
        ' 
        ' CboFileTag
        ' 
        CboFileTag.DropDownStyle = ComboBoxStyle.DropDownList
        CboFileTag.FlatStyle = FlatStyle.Flat
        CboFileTag.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboFileTag.FormattingEnabled = True
        CboFileTag.Location = New Point(440, 5)
        CboFileTag.Margin = New Padding(6, 5, 6, 5)
        CboFileTag.Name = "CboFileTag"
        CboFileTag.Size = New Size(310, 40)
        CboFileTag.TabIndex = 15
        ' 
        ' TxtFilePath
        ' 
        TxtFilePath.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFilePath.Location = New Point(70, 5)
        TxtFilePath.Margin = New Padding(6, 5, 6, 5)
        TxtFilePath.MaxLength = 255
        TxtFilePath.Name = "TxtFilePath"
        TxtFilePath.ReadOnly = True
        TxtFilePath.Size = New Size(357, 39)
        TxtFilePath.TabIndex = 11
        TxtFilePath.Tag = "txt"
        TxtFilePath.XOAutoTrim = False
        TxtFilePath.XOHarusDiisi = False
        TxtFilePath.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtFilePath.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtFilePath.XOHightlightSaatFokus = False
        TxtFilePath.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtFilePath.XOIsBlank = True
        TxtFilePath.XOIsSearchBox = False
        TxtFilePath.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtFilePath.XOPilihSemuaSaatFokus = False
        TxtFilePath.XOPwdLengthMin = 8
        TxtFilePath.XOPwdStrengthCalculate = False
        TxtFilePath.XOPwdStrengthScore = 0
        TxtFilePath.XOPwdStrengthText = Nothing
        TxtFilePath.XORestriction = ControlCodeBase.enuRestriction.None
        TxtFilePath.XOSearchBoxText = "Type then press Enter"
        TxtFilePath.XOSQLText = ""
        TxtFilePath.XOTanpaSpasi = False
        TxtFilePath.XOValidasiField = Nothing
        ' 
        ' BtnAddFile
        ' 
        BtnAddFile.BackColor = Color.Black
        BtnAddFile.Cursor = Cursors.Hand
        BtnAddFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnAddFile.FlatAppearance.BorderSize = 2
        BtnAddFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnAddFile.FlatStyle = FlatStyle.Flat
        BtnAddFile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAddFile.ForeColor = Color.White
        BtnAddFile.Image = My.Resources.Resources.ADD_001_16_ICON
        BtnAddFile.Location = New Point(827, 5)
        BtnAddFile.Margin = New Padding(6, 5, 6, 5)
        BtnAddFile.Name = "BtnAddFile"
        BtnAddFile.Size = New Size(54, 55)
        BtnAddFile.TabIndex = 13
        BtnAddFile.UseVisualStyleBackColor = False
        BtnAddFile.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnAddFile.XOTampilkanFocusBorder = False
        BtnAddFile.XOValidasiSemuaInput = False
        BtnAddFile.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnPeekFile
        ' 
        BtnPeekFile.BackColor = Color.Black
        BtnPeekFile.Cursor = Cursors.Hand
        BtnPeekFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnPeekFile.FlatAppearance.BorderSize = 2
        BtnPeekFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnPeekFile.FlatStyle = FlatStyle.Flat
        BtnPeekFile.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPeekFile.ForeColor = Color.White
        BtnPeekFile.Image = My.Resources.Resources.ZOOMNORMAL_001_16_ICON
        BtnPeekFile.Location = New Point(761, 5)
        BtnPeekFile.Margin = New Padding(6, 5, 6, 5)
        BtnPeekFile.Name = "BtnPeekFile"
        BtnPeekFile.Size = New Size(54, 55)
        BtnPeekFile.TabIndex = 12
        BtnPeekFile.UseVisualStyleBackColor = False
        BtnPeekFile.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnPeekFile.XOTampilkanFocusBorder = False
        BtnPeekFile.XOValidasiSemuaInput = False
        BtnPeekFile.XOValidasiSemuaInputTag = Nothing
        ' 
        ' ofdFile
        ' 
        ofdFile.FileName = "OpenFileDialog1"
        ' 
        ' ULbl1
        ' 
        ULbl1.BackColor = Color.Moccasin
        ULbl1.Location = New Point(20, 20)
        ULbl1.Margin = New Padding(7, 5, 7, 5)
        ULbl1.Name = "ULbl1"
        ULbl1.Size = New Size(250, 55)
        ULbl1.SLFText = "Activity Start"
        ULbl1.SLFTextAdjuster = False
        ULbl1.SLFTextBorder = False
        ULbl1.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl1.TabIndex = 1003
        ' 
        ' ULbl2
        ' 
        ULbl2.BackColor = Color.Moccasin
        ULbl2.Location = New Point(20, 87)
        ULbl2.Margin = New Padding(7, 5, 7, 5)
        ULbl2.Name = "ULbl2"
        ULbl2.Size = New Size(250, 55)
        ULbl2.SLFText = "To"
        ULbl2.SLFTextAdjuster = False
        ULbl2.SLFTextBorder = False
        ULbl2.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl2.TabIndex = 1004
        ' 
        ' ULbl3
        ' 
        ULbl3.BackColor = Color.Moccasin
        ULbl3.Location = New Point(20, 153)
        ULbl3.Margin = New Padding(7, 5, 7, 5)
        ULbl3.Name = "ULbl3"
        ULbl3.Size = New Size(250, 55)
        ULbl3.SLFText = "Area Affected"
        ULbl3.SLFTextAdjuster = False
        ULbl3.SLFTextBorder = False
        ULbl3.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl3.TabIndex = 1005
        ' 
        ' ULbl4
        ' 
        ULbl4.BackColor = Color.Moccasin
        ULbl4.Location = New Point(20, 222)
        ULbl4.Margin = New Padding(7, 5, 7, 5)
        ULbl4.Name = "ULbl4"
        ULbl4.Size = New Size(250, 55)
        ULbl4.SLFText = "Activity Template"
        ULbl4.SLFTextAdjuster = False
        ULbl4.SLFTextBorder = False
        ULbl4.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl4.TabIndex = 1006
        ' 
        ' ULbl5
        ' 
        ULbl5.BackColor = Color.Moccasin
        ULbl5.Location = New Point(20, 288)
        ULbl5.Margin = New Padding(7, 5, 7, 5)
        ULbl5.Name = "ULbl5"
        ULbl5.Size = New Size(250, 230)
        ULbl5.SLFText = "Description"
        ULbl5.SLFTextAdjuster = False
        ULbl5.SLFTextBorder = False
        ULbl5.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl5.TabIndex = 1007
        ' 
        ' ULbl6
        ' 
        ULbl6.BackColor = Color.Moccasin
        ULbl6.Location = New Point(20, 530)
        ULbl6.Margin = New Padding(7, 5, 7, 5)
        ULbl6.Name = "ULbl6"
        ULbl6.Size = New Size(250, 120)
        ULbl6.SLFText = "Feedback" & vbCrLf & "(Supv. Only)"
        ULbl6.SLFTextAdjuster = False
        ULbl6.SLFTextBorder = False
        ULbl6.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl6.TabIndex = 1008
        ' 
        ' ULbl7
        ' 
        ULbl7.BackColor = Color.Moccasin
        ULbl7.Location = New Point(20, 662)
        ULbl7.Margin = New Padding(7, 5, 7, 5)
        ULbl7.Name = "ULbl7"
        ULbl7.Size = New Size(250, 395)
        ULbl7.SLFText = "Attachment(s)"
        ULbl7.SLFTextAdjuster = False
        ULbl7.SLFTextBorder = False
        ULbl7.SLFWarnaLabel = ControlCodeBase.enuJenisLabel.Yellow
        ULbl7.TabIndex = 1009
        ' 
        ' FRMdarEditor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1203, 1170)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMdarEditor"
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        TbctlAttachment.ResumeLayout(False)
        tpPhotos.ResumeLayout(False)
        PnlPhoto.ResumeLayout(False)
        PnlPhoto.PerformLayout()
        CType(PctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnPictureList, ComponentModel.ISupportInitialize).EndInit()
        tpFiles.ResumeLayout(False)
        PnlFile.ResumeLayout(False)
        PnlFile.PerformLayout()
        CType(DgnFileList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnSave As btn
    Friend WithEvents BtnCancel As btn
    Friend WithEvents DtpStart As dtp
    Friend WithEvents CboTemplate As cbo
    Friend WithEvents TxtContent As txt
    Friend WithEvents CboArea As cbo
    Friend WithEvents MebStart As meb
    Friend WithEvents BtnGETContent As btn
    Friend WithEvents ChkAddNew As chk
    Friend WithEvents MebEnd As meb
    Friend WithEvents DtpEnd As dtp
    Friend WithEvents TxtFeedback As txt
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents TbctlAttachment As tbctl
    Friend WithEvents tpPhotos As TabPage
    Friend WithEvents BtnPeekPhoto As btn
    Friend WithEvents BtnBrowsePhoto As btn
    Friend WithEvents BtnAddPhoto As btn
    Friend WithEvents TxtPhotoPath As txt
    Friend WithEvents DgnPictureList As dgn
    Friend WithEvents PctbxPhoto As pctbx
    Friend WithEvents tpFiles As TabPage
    Friend WithEvents BtnPeekFile As btn
    Friend WithEvents BtnBrowseFile As btn
    Friend WithEvents BtnAddFile As btn
    Friend WithEvents TxtFilePath As txt
    Friend WithEvents DgnFileList As dgn
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents CboFileTag As cbo
    Friend WithEvents PnlPhoto As pnl
    Friend WithEvents PnlFile As pnl
    Friend WithEvents ULbl7 As ULbl
    Friend WithEvents ULbl6 As ULbl
    Friend WithEvents ULbl5 As ULbl
    Friend WithEvents ULbl4 As ULbl
    Friend WithEvents ULbl3 As ULbl
    Friend WithEvents ULbl2 As ULbl
    Friend WithEvents ULbl1 As ULbl
    Friend WithEvents photo_id As DataGridViewTextBoxColumn
    Friend WithEvents photo_filename As DataGridViewTextBoxColumn
    Friend WithEvents photo_datetime As DataGridViewTextBoxColumn
    Friend WithEvents photo_content As DataGridViewImageColumn
    Friend WithEvents photo_status As DataGridViewTextBoxColumn
    Friend WithEvents photo_uploader As DataGridViewTextBoxColumn
    Friend WithEvents photo_delete As DataGridViewButtonColumn
    Friend WithEvents file_id As DataGridViewTextBoxColumn
    Friend WithEvents file_filename As DataGridViewTextBoxColumn
    Friend WithEvents file_tag As DataGridViewTextBoxColumn
    Friend WithEvents file_datetime As DataGridViewTextBoxColumn
    Friend WithEvents file_content As DataGridViewTextBoxColumn
    Friend WithEvents file_status As DataGridViewTextBoxColumn
    Friend WithEvents file_uploader As DataGridViewTextBoxColumn
    Friend WithEvents file_delete As DataGridViewButtonColumn
End Class
