<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAR_Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DAR_Editor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.CboTemplate = New CMCv.cbo(Me.components)
        Me.DtpStart = New CMCv.dtp(Me.components)
        Me.TxtContent = New CMCv.txt(Me.components)
        Me.CboArea = New CMCv.cbo(Me.components)
        Me.MebStart = New CMCv.meb(Me.components)
        Me.BtnGETContent = New CMCv.btn(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.MebEnd = New CMCv.meb(Me.components)
        Me.DtpEnd = New CMCv.dtp(Me.components)
        Me.TxtFeedback = New CMCv.txt(Me.components)
        Me.OfdPhoto = New System.Windows.Forms.OpenFileDialog()
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
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.ULbl5 = New CMCv.ULbl()
        Me.ULbl6 = New CMCv.ULbl()
        Me.ULbl7 = New CMCv.ULbl()
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
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 592)
        Me.PnlBottomButton.Size = New System.Drawing.Size(722, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(722, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.AutoScroll = True
        Me.SLFPanel.AutoScrollMinSize = New System.Drawing.Size(1, 1)
        Me.SLFPanel.Controls.Add(Me.ULbl7)
        Me.SLFPanel.Controls.Add(Me.ULbl6)
        Me.SLFPanel.Controls.Add(Me.ULbl5)
        Me.SLFPanel.Controls.Add(Me.ULbl4)
        Me.SLFPanel.Controls.Add(Me.ULbl3)
        Me.SLFPanel.Controls.Add(Me.ULbl2)
        Me.SLFPanel.Controls.Add(Me.ULbl1)
        Me.SLFPanel.Controls.Add(Me.TbctlAttachment)
        Me.SLFPanel.Controls.Add(Me.TxtFeedback)
        Me.SLFPanel.Controls.Add(Me.MebEnd)
        Me.SLFPanel.Controls.Add(Me.DtpEnd)
        Me.SLFPanel.Controls.Add(Me.BtnGETContent)
        Me.SLFPanel.Controls.Add(Me.MebStart)
        Me.SLFPanel.Controls.Add(Me.CboArea)
        Me.SLFPanel.Controls.Add(Me.TxtContent)
        Me.SLFPanel.Controls.Add(Me.DtpStart)
        Me.SLFPanel.Controls.Add(Me.CboTemplate)
        Me.SLFPanel.Size = New System.Drawing.Size(722, 642)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboTemplate, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DtpStart, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtContent, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboArea, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.MebStart, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.BtnGETContent, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DtpEnd, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.MebEnd, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtFeedback, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TbctlAttachment, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl4, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl5, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl6, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl7, 0)
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
        Me.BtnSave.Location = New System.Drawing.Point(504, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 600
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
        Me.BtnCancel.Location = New System.Drawing.Point(610, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 602
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'CboTemplate
        '
        Me.CboTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTemplate.DropDownWidth = 350
        Me.CboTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboTemplate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboTemplate.FormattingEnabled = True
        Me.CboTemplate.Location = New System.Drawing.Point(168, 115)
        Me.CboTemplate.Name = "CboTemplate"
        Me.CboTemplate.Size = New System.Drawing.Size(231, 29)
        Me.CboTemplate.TabIndex = 5
        '
        'DtpStart
        '
        Me.DtpStart.CustomFormat = "dd MMMM yyyy"
        Me.DtpStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpStart.Location = New System.Drawing.Point(168, 10)
        Me.DtpStart.MaxDate = New Date(2026, 6, 13, 0, 0, 0, 0)
        Me.DtpStart.MinDate = New Date(1916, 6, 13, 0, 0, 0, 0)
        Me.DtpStart.Name = "DtpStart"
        Me.DtpStart.Size = New System.Drawing.Size(176, 29)
        Me.DtpStart.SLFResetOnDisabled = False
        Me.DtpStart.TabIndex = 0
        '
        'TxtContent
        '
        Me.TxtContent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtContent.Location = New System.Drawing.Point(168, 150)
        Me.TxtContent.MaxLength = 99999999
        Me.TxtContent.Multiline = True
        Me.TxtContent.Name = "TxtContent"
        Me.TxtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtContent.Size = New System.Drawing.Size(542, 120)
        Me.TxtContent.SLFAutoTrim = True
        Me.TxtContent.SLFHarusDiisi = True
        Me.TxtContent.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtContent.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtContent.SLFHightlightSaatFokus = True
        Me.TxtContent.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtContent.SLFIsBlank = True
        Me.TxtContent.SLFIsSearchBox = False
        Me.TxtContent.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtContent.SLFPilihSemuaSaatFokus = False
        Me.TxtContent.SLFPwdLengthMin = 8
        Me.TxtContent.SLFPwdStrengthCalculate = False
        Me.TxtContent.SLFPwdStrengthScore = 0
        Me.TxtContent.SLFPwdStrengthText = Nothing
        Me.TxtContent.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtContent.SLFSearchBoxText = "Type then press Enter"
        Me.TxtContent.SLFSQLText = Nothing
        Me.TxtContent.SLFTanpaSpasi = False
        Me.TxtContent.SLFValidasiField = Nothing
        Me.TxtContent.TabIndex = 7
        Me.TxtContent.Tag = "txt"
        '
        'CboArea
        '
        Me.CboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboArea.DropDownWidth = 350
        Me.CboArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboArea.FormattingEnabled = True
        Me.CboArea.Location = New System.Drawing.Point(168, 80)
        Me.CboArea.Name = "CboArea"
        Me.CboArea.Size = New System.Drawing.Size(231, 29)
        Me.CboArea.TabIndex = 4
        '
        'MebStart
        '
        Me.MebStart.AsciiOnly = True
        Me.MebStart.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MebStart.Location = New System.Drawing.Point(350, 10)
        Me.MebStart.Mask = "00:00"
        Me.MebStart.Name = "MebStart"
        Me.MebStart.Size = New System.Drawing.Size(49, 29)
        Me.MebStart.SLFHarusDiisi = True
        Me.MebStart.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.MebStart.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.MebStart.SLFHightlightSaatFokus = True
        Me.MebStart.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.MebStart.SLFPilihSemuaSaatFokus = True
        Me.MebStart.TabIndex = 1
        Me.MebStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MebStart.ValidatingType = GetType(Date)
        '
        'BtnGETContent
        '
        Me.BtnGETContent.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnGETContent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGETContent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnGETContent.FlatAppearance.BorderSize = 2
        Me.BtnGETContent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnGETContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGETContent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGETContent.ForeColor = System.Drawing.Color.White
        Me.BtnGETContent.Location = New System.Drawing.Point(405, 108)
        Me.BtnGETContent.Name = "BtnGETContent"
        Me.BtnGETContent.Size = New System.Drawing.Size(100, 40)
        Me.BtnGETContent.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnGETContent.SLFTampilkanFocusBorder = False
        Me.BtnGETContent.SLFValidasiSemuaInput = False
        Me.BtnGETContent.SLFValidasiSemuaInputTag = Nothing
        Me.BtnGETContent.TabIndex = 6
        Me.BtnGETContent.Text = "Apply"
        Me.BtnGETContent.UseVisualStyleBackColor = False
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(352, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 601
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'MebEnd
        '
        Me.MebEnd.AsciiOnly = True
        Me.MebEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MebEnd.Location = New System.Drawing.Point(350, 45)
        Me.MebEnd.Mask = "00:00"
        Me.MebEnd.Name = "MebEnd"
        Me.MebEnd.Size = New System.Drawing.Size(49, 29)
        Me.MebEnd.SLFHarusDiisi = True
        Me.MebEnd.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.MebEnd.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.MebEnd.SLFHightlightSaatFokus = True
        Me.MebEnd.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.MebEnd.SLFPilihSemuaSaatFokus = True
        Me.MebEnd.TabIndex = 3
        Me.MebEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MebEnd.ValidatingType = GetType(Date)
        '
        'DtpEnd
        '
        Me.DtpEnd.CustomFormat = "dd MMMM yyyy"
        Me.DtpEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpEnd.Location = New System.Drawing.Point(168, 45)
        Me.DtpEnd.MaxDate = New Date(2026, 6, 13, 0, 0, 0, 0)
        Me.DtpEnd.MinDate = New Date(1916, 6, 13, 0, 0, 0, 0)
        Me.DtpEnd.Name = "DtpEnd"
        Me.DtpEnd.Size = New System.Drawing.Size(176, 29)
        Me.DtpEnd.SLFResetOnDisabled = False
        Me.DtpEnd.TabIndex = 2
        '
        'TxtFeedback
        '
        Me.TxtFeedback.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtFeedback.Location = New System.Drawing.Point(168, 276)
        Me.TxtFeedback.MaxLength = 255
        Me.TxtFeedback.Multiline = True
        Me.TxtFeedback.Name = "TxtFeedback"
        Me.TxtFeedback.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtFeedback.Size = New System.Drawing.Size(542, 62)
        Me.TxtFeedback.SLFAutoTrim = True
        Me.TxtFeedback.SLFHarusDiisi = False
        Me.TxtFeedback.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtFeedback.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtFeedback.SLFHightlightSaatFokus = True
        Me.TxtFeedback.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtFeedback.SLFIsBlank = True
        Me.TxtFeedback.SLFIsSearchBox = False
        Me.TxtFeedback.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtFeedback.SLFPilihSemuaSaatFokus = False
        Me.TxtFeedback.SLFPwdLengthMin = 8
        Me.TxtFeedback.SLFPwdStrengthCalculate = False
        Me.TxtFeedback.SLFPwdStrengthScore = 0
        Me.TxtFeedback.SLFPwdStrengthText = Nothing
        Me.TxtFeedback.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFeedback.SLFSearchBoxText = "Type then press Enter"
        Me.TxtFeedback.SLFSQLText = ""
        Me.TxtFeedback.SLFTanpaSpasi = False
        Me.TxtFeedback.SLFValidasiField = Nothing
        Me.TxtFeedback.TabIndex = 8
        Me.TxtFeedback.Tag = "txt"
        '
        'OfdPhoto
        '
        Me.OfdPhoto.FileName = "OpenFileDialog1"
        '
        'TbctlAttachment
        '
        Me.TbctlAttachment.Controls.Add(Me.tpPhotos)
        Me.TbctlAttachment.Controls.Add(Me.tpFiles)
        Me.TbctlAttachment.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TbctlAttachment.Location = New System.Drawing.Point(168, 344)
        Me.TbctlAttachment.Name = "TbctlAttachment"
        Me.TbctlAttachment.SelectedIndex = 0
        Me.TbctlAttachment.Size = New System.Drawing.Size(546, 205)
        Me.TbctlAttachment.TabIndex = 1002
        '
        'tpPhotos
        '
        Me.tpPhotos.AutoScroll = True
        Me.tpPhotos.AutoScrollMinSize = New System.Drawing.Size(1, 1)
        Me.tpPhotos.Controls.Add(Me.PnlPhoto)
        Me.tpPhotos.Location = New System.Drawing.Point(4, 30)
        Me.tpPhotos.Name = "tpPhotos"
        Me.tpPhotos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPhotos.Size = New System.Drawing.Size(538, 171)
        Me.tpPhotos.TabIndex = 0
        Me.tpPhotos.Text = "Photos"
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
        Me.PnlPhoto.Size = New System.Drawing.Size(532, 165)
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
        Me.PctbxPhoto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PctbxPhoto.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PctbxPhoto.BackgroundImage = Global.ingrid.My.Resources.Resources.PCTPRV_001_512_icon
        Me.PctbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), System.Drawing.Image)
        Me.PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), System.Drawing.Image)
        Me.PctbxPhoto.Location = New System.Drawing.Point(368, 3)
        Me.PctbxPhoto.Name = "PctbxPhoto"
        Me.PctbxPhoto.Size = New System.Drawing.Size(161, 162)
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
        Me.DgnPictureList.Size = New System.Drawing.Size(359, 124)
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
        Me.BtnPeekPhoto.Location = New System.Drawing.Point(290, 3)
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
        Me.TxtPhotoPath.Size = New System.Drawing.Size(242, 29)
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
        Me.BtnAddPhoto.Location = New System.Drawing.Point(329, 3)
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
        Me.tpFiles.Size = New System.Drawing.Size(538, 171)
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
        Me.PnlFile.Size = New System.Drawing.Size(532, 165)
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
        Me.DgnFileList.Size = New System.Drawing.Size(526, 124)
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
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(12, 10)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Activity Start"
        Me.ULbl1.SLFTextAdjuster = False
        Me.ULbl1.SLFTextBorder = False
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1003
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(12, 45)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "To"
        Me.ULbl2.SLFTextAdjuster = False
        Me.ULbl2.SLFTextBorder = False
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1004
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(12, 80)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Area Affected"
        Me.ULbl3.SLFTextAdjuster = False
        Me.ULbl3.SLFTextBorder = False
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1005
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(12, 115)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Activity Template"
        Me.ULbl4.SLFTextAdjuster = False
        Me.ULbl4.SLFTextBorder = False
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1006
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(12, 150)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 120)
        Me.ULbl5.SLFText = "Description"
        Me.ULbl5.SLFTextAdjuster = False
        Me.ULbl5.SLFTextBorder = False
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 1007
        '
        'ULbl6
        '
        Me.ULbl6.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl6.Location = New System.Drawing.Point(12, 276)
        Me.ULbl6.Name = "ULbl6"
        Me.ULbl6.Size = New System.Drawing.Size(150, 62)
        Me.ULbl6.SLFText = "Feedback" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Supv. Only)"
        Me.ULbl6.SLFTextAdjuster = False
        Me.ULbl6.SLFTextBorder = False
        Me.ULbl6.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl6.TabIndex = 1008
        '
        'ULbl7
        '
        Me.ULbl7.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl7.Location = New System.Drawing.Point(12, 344)
        Me.ULbl7.Name = "ULbl7"
        Me.ULbl7.Size = New System.Drawing.Size(150, 205)
        Me.ULbl7.SLFText = "Attachment(s)"
        Me.ULbl7.SLFTextAdjuster = False
        Me.ULbl7.SLFTextBorder = False
        Me.ULbl7.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl7.TabIndex = 1009
        '
        'DAR_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(722, 718)
        Me.KeyPreview = True
        Me.Name = "DAR_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
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
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents DtpStart As CMCv.dtp
    Friend WithEvents CboTemplate As CMCv.cbo
    Friend WithEvents TxtContent As CMCv.txt
    Friend WithEvents CboArea As CMCv.cbo
    Friend WithEvents MebStart As CMCv.meb
    Friend WithEvents BtnGETContent As CMCv.btn
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents MebEnd As CMCv.meb
    Friend WithEvents DtpEnd As CMCv.dtp
    Friend WithEvents TxtFeedback As CMCv.txt
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents TbctlAttachment As CMCv.tbctl
    Friend WithEvents tpPhotos As TabPage
    Friend WithEvents BtnPeekPhoto As CMCv.btn
    Friend WithEvents BtnBrowsePhoto As CMCv.btn
    Friend WithEvents BtnAddPhoto As CMCv.btn
    Friend WithEvents TxtPhotoPath As CMCv.txt
    Friend WithEvents DgnPictureList As CMCv.dgn
    Friend WithEvents PctbxPhoto As CMCv.pctbx
    Friend WithEvents tpFiles As TabPage
    Friend WithEvents BtnPeekFile As CMCv.btn
    Friend WithEvents BtnBrowseFile As CMCv.btn
    Friend WithEvents BtnAddFile As CMCv.btn
    Friend WithEvents TxtFilePath As CMCv.txt
    Friend WithEvents DgnFileList As CMCv.dgn
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents CboFileTag As CMCv.cbo
    Friend WithEvents PnlPhoto As CMCv.pnl
    Friend WithEvents PnlFile As CMCv.pnl
    Friend WithEvents photo_id As DataGridViewTextBoxColumn
    Friend WithEvents photo_datetime As DataGridViewTextBoxColumn
    Friend WithEvents photo_content As DataGridViewImageColumn
    Friend WithEvents photo_status As DataGridViewTextBoxColumn
    Friend WithEvents photo_uploader As DataGridViewTextBoxColumn
    Friend WithEvents photo_delete As DataGridViewButtonColumn
    Friend WithEvents file_id As DataGridViewTextBoxColumn
    Friend WithEvents file_tag As DataGridViewTextBoxColumn
    Friend WithEvents file_datetime As DataGridViewTextBoxColumn
    Friend WithEvents file_content As DataGridViewTextBoxColumn
    Friend WithEvents file_status As DataGridViewTextBoxColumn
    Friend WithEvents file_uploader As DataGridViewTextBoxColumn
    Friend WithEvents file_delete As DataGridViewButtonColumn
    Friend WithEvents ULbl7 As CMCv.ULbl
    Friend WithEvents ULbl6 As CMCv.ULbl
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
End Class
