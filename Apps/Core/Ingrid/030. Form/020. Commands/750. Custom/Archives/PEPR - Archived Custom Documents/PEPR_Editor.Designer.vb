<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEPR_Editor
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.TxtArchiveCode = New CMCv.txt(Me.components)
        Me.TxtTitle = New CMCv.txt(Me.components)
        Me.CboCategory = New CMCv.cbo(Me.components)
        Me.Txt1 = New CMCv.txt(Me.components)
        Me.Txt2 = New CMCv.txt(Me.components)
        Me.TbctlAttachment = New CMCv.tbctl(Me.components)
        Me.tpPhotos = New System.Windows.Forms.TabPage()
        Me.PnlPhoto = New CMCv.pnl(Me.components)
        Me.BtnBrowsePhoto = New CMCv.btn(Me.components)
        Me.PctbxPhoto = New CMCv.pctbx(Me.components)
        Me.DgnPictureList = New CMCv.dgn(Me.components)
        Me.photo_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.photo_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.photo_content = New System.Windows.Forms.DataGridViewImageColumn()
        Me.photo_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.photo_uploader = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.photo_delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnPeekPhoto = New CMCv.btn(Me.components)
        Me.TxtPhotoPath = New CMCv.txt(Me.components)
        Me.BtnAddPhoto = New CMCv.btn(Me.components)
        Me.tpFiles = New System.Windows.Forms.TabPage()
        Me.PnlFile = New CMCv.pnl(Me.components)
        Me.BtnBrowseFile = New CMCv.btn(Me.components)
        Me.DgnFileList = New CMCv.dgn(Me.components)
        Me.file_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_tag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_content = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_uploader = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.file_delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CboFileTag = New CMCv.cbo(Me.components)
        Me.TxtFilePath = New CMCv.txt(Me.components)
        Me.BtnAddFile = New CMCv.btn(Me.components)
        Me.BtnPeekFile = New CMCv.btn(Me.components)
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.ULbl5 = New CMCv.ULbl()
        Me.ULbl6 = New CMCv.ULbl()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.TbctlAttachment.SuspendLayout()
        Me.tpPhotos.SuspendLayout()
        Me.PnlPhoto.SuspendLayout()
        CType(Me.PctbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgnPictureList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFiles.SuspendLayout()
        Me.PnlFile.SuspendLayout()
        CType(Me.DgnFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 578)
        Me.PnlBottomButton.Size = New System.Drawing.Size(697, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(697, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ULbl6)
        Me.SLFPanel.Controls.Add(Me.ULbl5)
        Me.SLFPanel.Controls.Add(Me.ULbl4)
        Me.SLFPanel.Controls.Add(Me.ULbl3)
        Me.SLFPanel.Controls.Add(Me.ULbl2)
        Me.SLFPanel.Controls.Add(Me.ULbl1)
        Me.SLFPanel.Controls.Add(Me.TxtArchiveCode)
        Me.SLFPanel.Controls.Add(Me.TbctlAttachment)
        Me.SLFPanel.Controls.Add(Me.Txt2)
        Me.SLFPanel.Controls.Add(Me.Txt1)
        Me.SLFPanel.Controls.Add(Me.CboCategory)
        Me.SLFPanel.Controls.Add(Me.TxtTitle)
        Me.SLFPanel.Size = New System.Drawing.Size(697, 628)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtTitle, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboCategory, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Txt1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Txt2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TbctlAttachment, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtArchiveCode, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl4, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl5, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl6, 0)
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
        Me.BtnSave.Location = New System.Drawing.Point(574, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 1
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
        Me.BtnCancel.Location = New System.Drawing.Point(468, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtArchiveCode
        '
        Me.TxtArchiveCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtArchiveCode.Location = New System.Drawing.Point(168, 10)
        Me.TxtArchiveCode.MaxLength = 255
        Me.TxtArchiveCode.Name = "TxtArchiveCode"
        Me.TxtArchiveCode.Size = New System.Drawing.Size(206, 29)
        Me.TxtArchiveCode.SLFAutoTrim = False
        Me.TxtArchiveCode.SLFHarusDiisi = False
        Me.TxtArchiveCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtArchiveCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtArchiveCode.SLFHightlightSaatFokus = False
        Me.TxtArchiveCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtArchiveCode.SLFIsBlank = True
        Me.TxtArchiveCode.SLFIsSearchBox = False
        Me.TxtArchiveCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtArchiveCode.SLFPilihSemuaSaatFokus = False
        Me.TxtArchiveCode.SLFPwdLengthMin = 8
        Me.TxtArchiveCode.SLFPwdStrengthCalculate = False
        Me.TxtArchiveCode.SLFPwdStrengthScore = 0
        Me.TxtArchiveCode.SLFPwdStrengthText = Nothing
        Me.TxtArchiveCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtArchiveCode.SLFSearchBoxText = "Type then press Enter"
        Me.TxtArchiveCode.SLFSQLText = ""
        Me.TxtArchiveCode.SLFTanpaSpasi = False
        Me.TxtArchiveCode.SLFValidasiField = Nothing
        Me.TxtArchiveCode.TabIndex = 996
        Me.TxtArchiveCode.Tag = "txt"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtTitle.Location = New System.Drawing.Point(168, 45)
        Me.TxtTitle.MaxLength = 255
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(338, 29)
        Me.TxtTitle.SLFAutoTrim = False
        Me.TxtTitle.SLFHarusDiisi = False
        Me.TxtTitle.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtTitle.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtTitle.SLFHightlightSaatFokus = False
        Me.TxtTitle.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtTitle.SLFIsBlank = True
        Me.TxtTitle.SLFIsSearchBox = False
        Me.TxtTitle.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtTitle.SLFPilihSemuaSaatFokus = False
        Me.TxtTitle.SLFPwdLengthMin = 8
        Me.TxtTitle.SLFPwdStrengthCalculate = False
        Me.TxtTitle.SLFPwdStrengthScore = 0
        Me.TxtTitle.SLFPwdStrengthText = Nothing
        Me.TxtTitle.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtTitle.SLFSearchBoxText = "Type then press Enter"
        Me.TxtTitle.SLFSQLText = ""
        Me.TxtTitle.SLFTanpaSpasi = False
        Me.TxtTitle.SLFValidasiField = Nothing
        Me.TxtTitle.TabIndex = 998
        Me.TxtTitle.Tag = "txt"
        '
        'CboCategory
        '
        Me.CboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboCategory.FormattingEnabled = True
        Me.CboCategory.Location = New System.Drawing.Point(168, 80)
        Me.CboCategory.Name = "CboCategory"
        Me.CboCategory.Size = New System.Drawing.Size(338, 29)
        Me.CboCategory.TabIndex = 1000
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt1.Location = New System.Drawing.Point(168, 115)
        Me.Txt1.MaxLength = 255
        Me.Txt1.Multiline = True
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(519, 198)
        Me.Txt1.SLFAutoTrim = False
        Me.Txt1.SLFHarusDiisi = False
        Me.Txt1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt1.SLFHightlightSaatFokus = False
        Me.Txt1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt1.SLFIsBlank = True
        Me.Txt1.SLFIsSearchBox = False
        Me.Txt1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.Txt1.SLFPilihSemuaSaatFokus = False
        Me.Txt1.SLFPwdLengthMin = 8
        Me.Txt1.SLFPwdStrengthCalculate = False
        Me.Txt1.SLFPwdStrengthScore = 0
        Me.Txt1.SLFPwdStrengthText = Nothing
        Me.Txt1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt1.SLFSearchBoxText = "Type then press Enter"
        Me.Txt1.SLFSQLText = ""
        Me.Txt1.SLFTanpaSpasi = False
        Me.Txt1.SLFValidasiField = Nothing
        Me.Txt1.TabIndex = 1002
        Me.Txt1.Tag = "txt"
        '
        'Txt2
        '
        Me.Txt2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt2.Location = New System.Drawing.Point(168, 319)
        Me.Txt2.MaxLength = 255
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(519, 29)
        Me.Txt2.SLFAutoTrim = False
        Me.Txt2.SLFHarusDiisi = False
        Me.Txt2.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt2.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt2.SLFHightlightSaatFokus = False
        Me.Txt2.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt2.SLFIsBlank = True
        Me.Txt2.SLFIsSearchBox = False
        Me.Txt2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.Txt2.SLFPilihSemuaSaatFokus = False
        Me.Txt2.SLFPwdLengthMin = 8
        Me.Txt2.SLFPwdStrengthCalculate = False
        Me.Txt2.SLFPwdStrengthScore = 0
        Me.Txt2.SLFPwdStrengthText = Nothing
        Me.Txt2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt2.SLFSearchBoxText = "Type then press Enter"
        Me.Txt2.SLFSQLText = ""
        Me.Txt2.SLFTanpaSpasi = False
        Me.Txt2.SLFValidasiField = Nothing
        Me.Txt2.TabIndex = 1006
        Me.Txt2.Tag = "txt"
        '
        'TbctlAttachment
        '
        Me.TbctlAttachment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbctlAttachment.Controls.Add(Me.tpPhotos)
        Me.TbctlAttachment.Controls.Add(Me.tpFiles)
        Me.TbctlAttachment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TbctlAttachment.Location = New System.Drawing.Point(168, 354)
        Me.TbctlAttachment.Name = "TbctlAttachment"
        Me.TbctlAttachment.SelectedIndex = 0
        Me.TbctlAttachment.Size = New System.Drawing.Size(519, 205)
        Me.TbctlAttachment.TabIndex = 1008
        '
        'tpPhotos
        '
        Me.tpPhotos.AutoScroll = True
        Me.tpPhotos.AutoScrollMinSize = New System.Drawing.Size(1, 1)
        Me.tpPhotos.Controls.Add(Me.PnlPhoto)
        Me.tpPhotos.Location = New System.Drawing.Point(4, 30)
        Me.tpPhotos.Name = "tpPhotos"
        Me.tpPhotos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPhotos.Size = New System.Drawing.Size(511, 171)
        Me.tpPhotos.TabIndex = 0
        Me.tpPhotos.Text = "Images"
        Me.tpPhotos.UseVisualStyleBackColor = True
        '
        'PnlPhoto
        '
        Me.PnlPhoto.Controls.Add(Me.BtnBrowsePhoto)
        Me.PnlPhoto.Controls.Add(Me.PctbxPhoto)
        Me.PnlPhoto.Controls.Add(Me.DgnPictureList)
        Me.PnlPhoto.Controls.Add(Me.BtnPeekPhoto)
        Me.PnlPhoto.Controls.Add(Me.TxtPhotoPath)
        Me.PnlPhoto.Controls.Add(Me.BtnAddPhoto)
        Me.PnlPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlPhoto.Location = New System.Drawing.Point(3, 3)
        Me.PnlPhoto.Name = "PnlPhoto"
        Me.PnlPhoto.Size = New System.Drawing.Size(505, 165)
        Me.PnlPhoto.TabIndex = 11
        '
        'BtnBrowsePhoto
        '
        Me.BtnBrowsePhoto.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnBrowsePhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowsePhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnBrowsePhoto.FlatAppearance.BorderSize = 2
        Me.BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnBrowsePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowsePhoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowsePhoto.ForeColor = System.Drawing.Color.White
        Me.BtnBrowsePhoto.Image = Global.ingrid.My.Resources.Resources.Bullets_001_16_FFFFFFFF_
        Me.BtnBrowsePhoto.Location = New System.Drawing.Point(3, 3)
        Me.BtnBrowsePhoto.Name = "BtnBrowsePhoto"
        Me.BtnBrowsePhoto.Size = New System.Drawing.Size(33, 29)
        Me.BtnBrowsePhoto.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnBrowsePhoto.SLFTampilkanFocusBorder = False
        Me.BtnBrowsePhoto.SLFValidasiSemuaInput = False
        Me.BtnBrowsePhoto.SLFValidasiSemuaInputTag = Nothing
        Me.BtnBrowsePhoto.TabIndex = 5
        Me.BtnBrowsePhoto.UseVisualStyleBackColor = False
        '
        'PctbxPhoto
        '
        Me.PctbxPhoto.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PctbxPhoto.BackgroundImage = Global.ingrid.My.Resources.Resources.PCTPRV_001_512_icon
        Me.PctbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PctbxPhoto.Dock = System.Windows.Forms.DockStyle.Right
        Me.PctbxPhoto.ErrorImage = Nothing
        Me.PctbxPhoto.InitialImage = Nothing
        Me.PctbxPhoto.Location = New System.Drawing.Point(344, 0)
        Me.PctbxPhoto.Name = "PctbxPhoto"
        Me.PctbxPhoto.Size = New System.Drawing.Size(161, 165)
        Me.PctbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctbxPhoto.SLFTampilkanBorder = False
        Me.PctbxPhoto.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.PctbxPhoto.TabIndex = 6
        Me.PctbxPhoto.TabStop = False
        '
        'DgnPictureList
        '
        Me.DgnPictureList.AllowUserToAddRows = False
        Me.DgnPictureList.AllowUserToDeleteRows = False
        Me.DgnPictureList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.DgnPictureList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnPictureList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgnPictureList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnPictureList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnPictureList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnPictureList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnPictureList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnPictureList.ColumnHeadersHeight = 43
        Me.DgnPictureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnPictureList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.photo_id, Me.photo_datetime, Me.photo_content, Me.photo_status, Me.photo_uploader, Me.photo_delete})
        Me.DgnPictureList.EnableHeadersVisualStyles = False
        Me.DgnPictureList.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnPictureList.Location = New System.Drawing.Point(3, 38)
        Me.DgnPictureList.MultiSelect = False
        Me.DgnPictureList.Name = "DgnPictureList"
        Me.DgnPictureList.ReadOnly = True
        Me.DgnPictureList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnPictureList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnPictureList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnPictureList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgnPictureList.Size = New System.Drawing.Size(335, 124)
        Me.DgnPictureList.SLFGroupFirstRows = False
        Me.DgnPictureList.SLFGunakanNomorBaris = True
        Me.DgnPictureList.StandardTab = True
        Me.DgnPictureList.TabIndex = 10
        '
        'photo_id
        '
        Me.photo_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.photo_id.DataPropertyName = "file_id"
        Me.photo_id.HeaderText = "ID"
        Me.photo_id.Name = "photo_id"
        Me.photo_id.ReadOnly = True
        Me.photo_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'photo_datetime
        '
        Me.photo_datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.photo_datetime.DataPropertyName = "file_datetime"
        Me.photo_datetime.HeaderText = "Date Added"
        Me.photo_datetime.Name = "photo_datetime"
        Me.photo_datetime.ReadOnly = True
        Me.photo_datetime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.photo_datetime.Width = 89
        '
        'photo_content
        '
        Me.photo_content.DataPropertyName = "file_content"
        Me.photo_content.HeaderText = "Photo"
        Me.photo_content.Name = "photo_content"
        Me.photo_content.ReadOnly = True
        Me.photo_content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.photo_content.Visible = False
        '
        'photo_status
        '
        Me.photo_status.DataPropertyName = "file_status"
        Me.photo_status.HeaderText = "Status"
        Me.photo_status.Name = "photo_status"
        Me.photo_status.ReadOnly = True
        Me.photo_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.photo_status.Visible = False
        '
        'photo_uploader
        '
        Me.photo_uploader.DataPropertyName = "file_uploader"
        Me.photo_uploader.HeaderText = "Uploader"
        Me.photo_uploader.Name = "photo_uploader"
        Me.photo_uploader.ReadOnly = True
        Me.photo_uploader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.photo_uploader.Visible = False
        '
        'photo_delete
        '
        Me.photo_delete.DataPropertyName = "file_delete"
        Me.photo_delete.HeaderText = ""
        Me.photo_delete.Name = "photo_delete"
        Me.photo_delete.ReadOnly = True
        Me.photo_delete.Text = "🗑"
        Me.photo_delete.ToolTipText = "Delete"
        Me.photo_delete.UseColumnTextForButtonValue = True
        Me.photo_delete.Width = 19
        '
        'BtnPeekPhoto
        '
        Me.BtnPeekPhoto.BackColor = System.Drawing.Color.Crimson
        Me.BtnPeekPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPeekPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPeekPhoto.FlatAppearance.BorderSize = 2
        Me.BtnPeekPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnPeekPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPeekPhoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPeekPhoto.ForeColor = System.Drawing.Color.White
        Me.BtnPeekPhoto.Image = Global.ingrid.My.Resources.Resources.Peek_001_16_FFFFFFFF_
        Me.BtnPeekPhoto.Location = New System.Drawing.Point(266, 3)
        Me.BtnPeekPhoto.Name = "BtnPeekPhoto"
        Me.BtnPeekPhoto.Size = New System.Drawing.Size(33, 29)
        Me.BtnPeekPhoto.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Custom
        Me.BtnPeekPhoto.SLFTampilkanFocusBorder = False
        Me.BtnPeekPhoto.SLFValidasiSemuaInput = False
        Me.BtnPeekPhoto.SLFValidasiSemuaInputTag = Nothing
        Me.BtnPeekPhoto.TabIndex = 8
        Me.BtnPeekPhoto.UseVisualStyleBackColor = False
        '
        'TxtPhotoPath
        '
        Me.TxtPhotoPath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPhotoPath.Location = New System.Drawing.Point(42, 3)
        Me.TxtPhotoPath.MaxLength = 255
        Me.TxtPhotoPath.Name = "TxtPhotoPath"
        Me.TxtPhotoPath.ReadOnly = True
        Me.TxtPhotoPath.Size = New System.Drawing.Size(218, 29)
        Me.TxtPhotoPath.SLFAutoTrim = False
        Me.TxtPhotoPath.SLFHarusDiisi = False
        Me.TxtPhotoPath.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPhotoPath.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPhotoPath.SLFHightlightSaatFokus = False
        Me.TxtPhotoPath.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPhotoPath.SLFIsBlank = True
        Me.TxtPhotoPath.SLFIsSearchBox = False
        Me.TxtPhotoPath.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPhotoPath.SLFPilihSemuaSaatFokus = False
        Me.TxtPhotoPath.SLFPwdLengthMin = 8
        Me.TxtPhotoPath.SLFPwdStrengthCalculate = False
        Me.TxtPhotoPath.SLFPwdStrengthScore = 0
        Me.TxtPhotoPath.SLFPwdStrengthText = Nothing
        Me.TxtPhotoPath.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPhotoPath.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPhotoPath.SLFSQLText = ""
        Me.TxtPhotoPath.SLFTanpaSpasi = False
        Me.TxtPhotoPath.SLFValidasiField = Nothing
        Me.TxtPhotoPath.TabIndex = 7
        Me.TxtPhotoPath.Tag = "txt"
        '
        'BtnAddPhoto
        '
        Me.BtnAddPhoto.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddPhoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAddPhoto.FlatAppearance.BorderSize = 2
        Me.BtnAddPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnAddPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddPhoto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAddPhoto.ForeColor = System.Drawing.Color.White
        Me.BtnAddPhoto.Image = Global.ingrid.My.Resources.Resources.Plus_001_16_FFFFFFFF_
        Me.BtnAddPhoto.Location = New System.Drawing.Point(305, 3)
        Me.BtnAddPhoto.Name = "BtnAddPhoto"
        Me.BtnAddPhoto.Size = New System.Drawing.Size(33, 29)
        Me.BtnAddPhoto.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnAddPhoto.SLFTampilkanFocusBorder = False
        Me.BtnAddPhoto.SLFValidasiSemuaInput = False
        Me.BtnAddPhoto.SLFValidasiSemuaInputTag = Nothing
        Me.BtnAddPhoto.TabIndex = 9
        Me.BtnAddPhoto.UseVisualStyleBackColor = False
        '
        'tpFiles
        '
        Me.tpFiles.Controls.Add(Me.PnlFile)
        Me.tpFiles.Location = New System.Drawing.Point(4, 30)
        Me.tpFiles.Name = "tpFiles"
        Me.tpFiles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFiles.Size = New System.Drawing.Size(598, 171)
        Me.tpFiles.TabIndex = 1
        Me.tpFiles.Text = "PDF"
        Me.tpFiles.UseVisualStyleBackColor = True
        '
        'PnlFile
        '
        Me.PnlFile.Controls.Add(Me.BtnBrowseFile)
        Me.PnlFile.Controls.Add(Me.DgnFileList)
        Me.PnlFile.Controls.Add(Me.CboFileTag)
        Me.PnlFile.Controls.Add(Me.TxtFilePath)
        Me.PnlFile.Controls.Add(Me.BtnAddFile)
        Me.PnlFile.Controls.Add(Me.BtnPeekFile)
        Me.PnlFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlFile.Location = New System.Drawing.Point(3, 3)
        Me.PnlFile.Name = "PnlFile"
        Me.PnlFile.Size = New System.Drawing.Size(592, 165)
        Me.PnlFile.TabIndex = 16
        '
        'BtnBrowseFile
        '
        Me.BtnBrowseFile.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowseFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnBrowseFile.FlatAppearance.BorderSize = 2
        Me.BtnBrowseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowseFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowseFile.ForeColor = System.Drawing.Color.White
        Me.BtnBrowseFile.Image = Global.ingrid.My.Resources.Resources.Bullets_001_16_FFFFFFFF_
        Me.BtnBrowseFile.Location = New System.Drawing.Point(3, 3)
        Me.BtnBrowseFile.Name = "BtnBrowseFile"
        Me.BtnBrowseFile.Size = New System.Drawing.Size(33, 29)
        Me.BtnBrowseFile.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnBrowseFile.SLFTampilkanFocusBorder = False
        Me.BtnBrowseFile.SLFValidasiSemuaInput = False
        Me.BtnBrowseFile.SLFValidasiSemuaInputTag = Nothing
        Me.BtnBrowseFile.TabIndex = 10
        Me.BtnBrowseFile.UseVisualStyleBackColor = False
        '
        'DgnFileList
        '
        Me.DgnFileList.AllowUserToAddRows = False
        Me.DgnFileList.AllowUserToDeleteRows = False
        Me.DgnFileList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.DgnFileList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgnFileList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgnFileList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnFileList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnFileList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnFileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgnFileList.ColumnHeadersHeight = 43
        Me.DgnFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnFileList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.file_id, Me.file_tag, Me.file_datetime, Me.file_content, Me.file_status, Me.file_uploader, Me.file_delete})
        Me.DgnFileList.EnableHeadersVisualStyles = False
        Me.DgnFileList.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnFileList.Location = New System.Drawing.Point(3, 38)
        Me.DgnFileList.MultiSelect = False
        Me.DgnFileList.Name = "DgnFileList"
        Me.DgnFileList.ReadOnly = True
        Me.DgnFileList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgnFileList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgnFileList.Size = New System.Drawing.Size(586, 124)
        Me.DgnFileList.SLFGroupFirstRows = False
        Me.DgnFileList.SLFGunakanNomorBaris = True
        Me.DgnFileList.StandardTab = True
        Me.DgnFileList.TabIndex = 14
        '
        'file_id
        '
        Me.file_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.file_id.DataPropertyName = "file_id"
        Me.file_id.HeaderText = "ID"
        Me.file_id.Name = "file_id"
        Me.file_id.ReadOnly = True
        Me.file_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'file_tag
        '
        Me.file_tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.file_tag.DataPropertyName = "file_tag"
        Me.file_tag.HeaderText = "Tag"
        Me.file_tag.Name = "file_tag"
        Me.file_tag.ReadOnly = True
        Me.file_tag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.file_tag.Width = 50
        '
        'file_datetime
        '
        Me.file_datetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.file_datetime.DataPropertyName = "file_datetime"
        Me.file_datetime.HeaderText = "Date Added"
        Me.file_datetime.Name = "file_datetime"
        Me.file_datetime.ReadOnly = True
        Me.file_datetime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.file_datetime.Width = 89
        '
        'file_content
        '
        Me.file_content.DataPropertyName = "file_content"
        Me.file_content.HeaderText = "File"
        Me.file_content.Name = "file_content"
        Me.file_content.ReadOnly = True
        Me.file_content.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.file_content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.file_content.Visible = False
        '
        'file_status
        '
        Me.file_status.DataPropertyName = "file_status"
        Me.file_status.HeaderText = "Status"
        Me.file_status.Name = "file_status"
        Me.file_status.ReadOnly = True
        Me.file_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.file_status.Visible = False
        '
        'file_uploader
        '
        Me.file_uploader.DataPropertyName = "file_uploader"
        Me.file_uploader.HeaderText = "Uploader"
        Me.file_uploader.Name = "file_uploader"
        Me.file_uploader.ReadOnly = True
        Me.file_uploader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.file_uploader.Visible = False
        '
        'file_delete
        '
        Me.file_delete.DataPropertyName = "file_delete"
        Me.file_delete.HeaderText = ""
        Me.file_delete.Name = "file_delete"
        Me.file_delete.ReadOnly = True
        Me.file_delete.Text = "🗑"
        Me.file_delete.ToolTipText = "Delete"
        Me.file_delete.UseColumnTextForButtonValue = True
        Me.file_delete.Width = 19
        '
        'CboFileTag
        '
        Me.CboFileTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFileTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboFileTag.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboFileTag.FormattingEnabled = True
        Me.CboFileTag.Location = New System.Drawing.Point(264, 3)
        Me.CboFileTag.Name = "CboFileTag"
        Me.CboFileTag.Size = New System.Drawing.Size(187, 29)
        Me.CboFileTag.TabIndex = 15
        '
        'TxtFilePath
        '
        Me.TxtFilePath.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtFilePath.Location = New System.Drawing.Point(42, 3)
        Me.TxtFilePath.MaxLength = 255
        Me.TxtFilePath.Name = "TxtFilePath"
        Me.TxtFilePath.ReadOnly = True
        Me.TxtFilePath.Size = New System.Drawing.Size(216, 29)
        Me.TxtFilePath.SLFAutoTrim = False
        Me.TxtFilePath.SLFHarusDiisi = False
        Me.TxtFilePath.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtFilePath.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtFilePath.SLFHightlightSaatFokus = False
        Me.TxtFilePath.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtFilePath.SLFIsBlank = True
        Me.TxtFilePath.SLFIsSearchBox = False
        Me.TxtFilePath.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtFilePath.SLFPilihSemuaSaatFokus = False
        Me.TxtFilePath.SLFPwdLengthMin = 8
        Me.TxtFilePath.SLFPwdStrengthCalculate = False
        Me.TxtFilePath.SLFPwdStrengthScore = 0
        Me.TxtFilePath.SLFPwdStrengthText = Nothing
        Me.TxtFilePath.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFilePath.SLFSearchBoxText = "Type then press Enter"
        Me.TxtFilePath.SLFSQLText = ""
        Me.TxtFilePath.SLFTanpaSpasi = False
        Me.TxtFilePath.SLFValidasiField = Nothing
        Me.TxtFilePath.TabIndex = 11
        Me.TxtFilePath.Tag = "txt"
        '
        'BtnAddFile
        '
        Me.BtnAddFile.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnAddFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAddFile.FlatAppearance.BorderSize = 2
        Me.BtnAddFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAddFile.ForeColor = System.Drawing.Color.White
        Me.BtnAddFile.Image = Global.ingrid.My.Resources.Resources.Plus_001_16_FFFFFFFF_
        Me.BtnAddFile.Location = New System.Drawing.Point(496, 3)
        Me.BtnAddFile.Name = "BtnAddFile"
        Me.BtnAddFile.Size = New System.Drawing.Size(33, 29)
        Me.BtnAddFile.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnAddFile.SLFTampilkanFocusBorder = False
        Me.BtnAddFile.SLFValidasiSemuaInput = False
        Me.BtnAddFile.SLFValidasiSemuaInputTag = Nothing
        Me.BtnAddFile.TabIndex = 13
        Me.BtnAddFile.UseVisualStyleBackColor = False
        '
        'BtnPeekFile
        '
        Me.BtnPeekFile.BackColor = System.Drawing.Color.Crimson
        Me.BtnPeekFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPeekFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPeekFile.FlatAppearance.BorderSize = 2
        Me.BtnPeekFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnPeekFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPeekFile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPeekFile.ForeColor = System.Drawing.Color.White
        Me.BtnPeekFile.Image = Global.ingrid.My.Resources.Resources.Peek_001_16_FFFFFFFF_
        Me.BtnPeekFile.Location = New System.Drawing.Point(457, 3)
        Me.BtnPeekFile.Name = "BtnPeekFile"
        Me.BtnPeekFile.Size = New System.Drawing.Size(33, 29)
        Me.BtnPeekFile.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Custom
        Me.BtnPeekFile.SLFTampilkanFocusBorder = False
        Me.BtnPeekFile.SLFValidasiSemuaInput = False
        Me.BtnPeekFile.SLFValidasiSemuaInputTag = Nothing
        Me.BtnPeekFile.TabIndex = 12
        Me.BtnPeekFile.UseVisualStyleBackColor = False
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.ForeColor = System.Drawing.Color.MintCream
        Me.ULbl1.Location = New System.Drawing.Point(12, 10)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Archive Code"
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1009
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(12, 45)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Name / Title"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1010
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(12, 80)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Category"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1011
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(12, 115)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 198)
        Me.ULbl4.SLFText = "Short Desc."
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1012
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(12, 319)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 29)
        Me.ULbl5.SLFText = "Keywords"
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 1013
        '
        'ULbl6
        '
        Me.ULbl6.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl6.Location = New System.Drawing.Point(12, 354)
        Me.ULbl6.Name = "ULbl6"
        Me.ULbl6.Size = New System.Drawing.Size(150, 205)
        Me.ULbl6.SLFText = "Attachment(s)"
        Me.ULbl6.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl6.TabIndex = 1014
        '
        'PEPR_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(697, 704)
        Me.KeyPreview = True
        Me.Name = "PEPR_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.TbctlAttachment.ResumeLayout(False)
        Me.tpPhotos.ResumeLayout(False)
        Me.PnlPhoto.ResumeLayout(False)
        Me.PnlPhoto.PerformLayout()
        CType(Me.PctbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgnPictureList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFiles.ResumeLayout(False)
        Me.PnlFile.ResumeLayout(False)
        Me.PnlFile.PerformLayout()
        CType(Me.DgnFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents TxtArchiveCode As CMCv.txt
    Friend WithEvents Txt1 As CMCv.txt
    Friend WithEvents CboCategory As CMCv.cbo
    Friend WithEvents TxtTitle As CMCv.txt
    Friend WithEvents Txt2 As CMCv.txt
    Friend WithEvents TbctlAttachment As CMCv.tbctl
    Friend WithEvents tpPhotos As TabPage
    Friend WithEvents PnlPhoto As CMCv.pnl
    Friend WithEvents BtnBrowsePhoto As CMCv.btn
    Friend WithEvents PctbxPhoto As CMCv.pctbx
    Friend WithEvents DgnPictureList As CMCv.dgn
    Friend WithEvents photo_id As DataGridViewTextBoxColumn
    Friend WithEvents photo_datetime As DataGridViewTextBoxColumn
    Friend WithEvents photo_content As DataGridViewImageColumn
    Friend WithEvents photo_status As DataGridViewTextBoxColumn
    Friend WithEvents photo_uploader As DataGridViewTextBoxColumn
    Friend WithEvents photo_delete As DataGridViewButtonColumn
    Friend WithEvents BtnPeekPhoto As CMCv.btn
    Friend WithEvents TxtPhotoPath As CMCv.txt
    Friend WithEvents BtnAddPhoto As CMCv.btn
    Friend WithEvents tpFiles As TabPage
    Friend WithEvents PnlFile As CMCv.pnl
    Friend WithEvents BtnBrowseFile As CMCv.btn
    Friend WithEvents DgnFileList As CMCv.dgn
    Friend WithEvents file_id As DataGridViewTextBoxColumn
    Friend WithEvents file_tag As DataGridViewTextBoxColumn
    Friend WithEvents file_datetime As DataGridViewTextBoxColumn
    Friend WithEvents file_content As DataGridViewTextBoxColumn
    Friend WithEvents file_status As DataGridViewTextBoxColumn
    Friend WithEvents file_uploader As DataGridViewTextBoxColumn
    Friend WithEvents file_delete As DataGridViewButtonColumn
    Friend WithEvents CboFileTag As CMCv.cbo
    Friend WithEvents TxtFilePath As CMCv.txt
    Friend WithEvents BtnAddFile As CMCv.btn
    Friend WithEvents BtnPeekFile As CMCv.btn
    Friend WithEvents ULbl1 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl6 As CMCv.ULbl
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
End Class
