Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMpeprEditor
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
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            TxtArchiveCode = New CMCv.UI.Control.txt(components)
            TxtTitle = New CMCv.UI.Control.txt(components)
            CboCategory = New CMCv.UI.Control.Cbo(components)
            Txt1 = New CMCv.UI.Control.txt(components)
            Txt2 = New CMCv.UI.Control.txt(components)
            TbctlAttachment = New CMCv.UI.Control.tbctl(components)
            tpPhotos = New TabPage()
            PnlPhoto = New CMCv.UI.Control.pnl(components)
            BtnBrowsePhoto = New CMCv.UI.Control.Btn(components)
            PctbxPhoto = New CMCv.UI.Control.pctbx(components)
            DgnPictureList = New CMCv.UI.Control.dgn(components)
            photo_id = New DataGridViewTextBoxColumn()
            photo_datetime = New DataGridViewTextBoxColumn()
            photo_content = New DataGridViewImageColumn()
            photo_status = New DataGridViewTextBoxColumn()
            photo_uploader = New DataGridViewTextBoxColumn()
            photo_delete = New DataGridViewButtonColumn()
            BtnPeekPhoto = New CMCv.UI.Control.Btn(components)
            TxtPhotoPath = New CMCv.UI.Control.txt(components)
            BtnAddPhoto = New CMCv.UI.Control.Btn(components)
            tpFiles = New TabPage()
            PnlFile = New CMCv.UI.Control.pnl(components)
            BtnBrowseFile = New CMCv.UI.Control.Btn(components)
            DgnFileList = New CMCv.UI.Control.dgn(components)
            file_id = New DataGridViewTextBoxColumn()
            file_tag = New DataGridViewTextBoxColumn()
            file_datetime = New DataGridViewTextBoxColumn()
            file_content = New DataGridViewTextBoxColumn()
            file_status = New DataGridViewTextBoxColumn()
            file_uploader = New DataGridViewTextBoxColumn()
            file_delete = New DataGridViewButtonColumn()
            CboFileTag = New CMCv.UI.Control.Cbo(components)
            TxtFilePath = New CMCv.UI.Control.txt(components)
            BtnAddFile = New CMCv.UI.Control.Btn(components)
            BtnPeekFile = New CMCv.UI.Control.Btn(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
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
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 948)
            PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
            PnlBottomButton.Size = New Size(1162, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(8, 12, 8, 12)
            pnl_.Size = New Size(1162, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl6)
            SLFPanel.Controls.Add(ULbl5)
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtArchiveCode)
            SLFPanel.Controls.Add(TbctlAttachment)
            SLFPanel.Controls.Add(Txt2)
            SLFPanel.Controls.Add(Txt1)
            SLFPanel.Controls.Add(CboCategory)
            SLFPanel.Controls.Add(TxtTitle)
            SLFPanel.Margin = New Padding(8, 12, 8, 12)
            SLFPanel.Size = New Size(1162, 1044)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TxtTitle, 0)
            SLFPanel.Controls.SetChildIndex(CboCategory, 0)
            SLFPanel.Controls.SetChildIndex(Txt1, 0)
            SLFPanel.Controls.SetChildIndex(Txt2, 0)
            SLFPanel.Controls.SetChildIndex(TbctlAttachment, 0)
            SLFPanel.Controls.SetChildIndex(TxtArchiveCode, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
            SLFPanel.Controls.SetChildIndex(ULbl5, 0)
            SLFPanel.Controls.SetChildIndex(ULbl6, 0)
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
            BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(957, 13)
            BtnSave.Margin = New Padding(5, 6, 5, 6)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 1
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
            BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(781, 13)
            BtnCancel.Margin = New Padding(5, 6, 5, 6)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 2
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' TxtArchiveCode
            ' 
            TxtArchiveCode.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtArchiveCode.Location = New Point(280, 19)
            TxtArchiveCode.Margin = New Padding(5, 6, 5, 6)
            TxtArchiveCode.MaxLength = 255
            TxtArchiveCode.Name = "TxtArchiveCode"
            TxtArchiveCode.Size = New Size(341, 39)
            TxtArchiveCode.TabIndex = 996
            TxtArchiveCode.Tag = "txt"
            TxtArchiveCode.XOAutoTrim = False
            TxtArchiveCode.XOHarusDiisi = False
            TxtArchiveCode.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtArchiveCode.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtArchiveCode.XOHightlightSaatFokus = False
            TxtArchiveCode.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtArchiveCode.XOIsBlank = True
            TxtArchiveCode.XOIsSearchBox = False
            TxtArchiveCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtArchiveCode.XOPilihSemuaSaatFokus = False
            TxtArchiveCode.XOPwdLengthMin = 8
            TxtArchiveCode.XOPwdStrengthCalculate = False
            TxtArchiveCode.XOPwdStrengthScore = 0
            TxtArchiveCode.XOPwdStrengthText = Nothing
            TxtArchiveCode.XORestriction = ControlCodeBase.enuRestriction.None
            TxtArchiveCode.XOSearchBoxText = "Type then press Enter"
            TxtArchiveCode.XOSQLText = ""
            TxtArchiveCode.XOTanpaSpasi = False
            TxtArchiveCode.XOValidasiField = Nothing
            ' 
            ' TxtTitle
            ' 
            TxtTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtTitle.Location = New Point(280, 87)
            TxtTitle.Margin = New Padding(5, 6, 5, 6)
            TxtTitle.MaxLength = 255
            TxtTitle.Name = "TxtTitle"
            TxtTitle.Size = New Size(561, 39)
            TxtTitle.TabIndex = 998
            TxtTitle.Tag = "txt"
            TxtTitle.XOAutoTrim = False
            TxtTitle.XOHarusDiisi = False
            TxtTitle.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtTitle.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtTitle.XOHightlightSaatFokus = False
            TxtTitle.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtTitle.XOIsBlank = True
            TxtTitle.XOIsSearchBox = False
            TxtTitle.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtTitle.XOPilihSemuaSaatFokus = False
            TxtTitle.XOPwdLengthMin = 8
            TxtTitle.XOPwdStrengthCalculate = False
            TxtTitle.XOPwdStrengthScore = 0
            TxtTitle.XOPwdStrengthText = Nothing
            TxtTitle.XORestriction = ControlCodeBase.enuRestriction.None
            TxtTitle.XOSearchBoxText = "Type then press Enter"
            TxtTitle.XOSQLText = ""
            TxtTitle.XOTanpaSpasi = False
            TxtTitle.XOValidasiField = Nothing
            ' 
            ' CboCategory
            ' 
            CboCategory.DropDownStyle = ComboBoxStyle.DropDownList
            CboCategory.FlatStyle = FlatStyle.Flat
            CboCategory.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboCategory.FormattingEnabled = True
            CboCategory.Location = New Point(280, 154)
            CboCategory.Margin = New Padding(5, 6, 5, 6)
            CboCategory.Name = "CboCategory"
            CboCategory.Size = New Size(561, 40)
            CboCategory.TabIndex = 1000
            ' 
            ' Txt1
            ' 
            Txt1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt1.Location = New Point(280, 221)
            Txt1.Margin = New Padding(5, 6, 5, 6)
            Txt1.MaxLength = 255
            Txt1.Multiline = True
            Txt1.Name = "Txt1"
            Txt1.Size = New Size(862, 377)
            Txt1.TabIndex = 1002
            Txt1.Tag = "txt"
            Txt1.XOAutoTrim = False
            Txt1.XOHarusDiisi = False
            Txt1.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt1.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt1.XOHightlightSaatFokus = False
            Txt1.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt1.XOIsBlank = True
            Txt1.XOIsSearchBox = False
            Txt1.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt1.XOPilihSemuaSaatFokus = False
            Txt1.XOPwdLengthMin = 8
            Txt1.XOPwdStrengthCalculate = False
            Txt1.XOPwdStrengthScore = 0
            Txt1.XOPwdStrengthText = Nothing
            Txt1.XORestriction = ControlCodeBase.enuRestriction.None
            Txt1.XOSearchBoxText = "Type then press Enter"
            Txt1.XOSQLText = ""
            Txt1.XOTanpaSpasi = False
            Txt1.XOValidasiField = Nothing
            ' 
            ' Txt2
            ' 
            Txt2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt2.Location = New Point(280, 613)
            Txt2.Margin = New Padding(5, 6, 5, 6)
            Txt2.MaxLength = 255
            Txt2.Name = "Txt2"
            Txt2.Size = New Size(862, 39)
            Txt2.TabIndex = 1006
            Txt2.Tag = "txt"
            Txt2.XOAutoTrim = False
            Txt2.XOHarusDiisi = False
            Txt2.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt2.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt2.XOHightlightSaatFokus = False
            Txt2.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt2.XOIsBlank = True
            Txt2.XOIsSearchBox = False
            Txt2.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt2.XOPilihSemuaSaatFokus = False
            Txt2.XOPwdLengthMin = 8
            Txt2.XOPwdStrengthCalculate = False
            Txt2.XOPwdStrengthScore = 0
            Txt2.XOPwdStrengthText = Nothing
            Txt2.XORestriction = ControlCodeBase.enuRestriction.None
            Txt2.XOSearchBoxText = "Type then press Enter"
            Txt2.XOSQLText = ""
            Txt2.XOTanpaSpasi = False
            Txt2.XOValidasiField = Nothing
            ' 
            ' TbctlAttachment
            ' 
            TbctlAttachment.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            TbctlAttachment.Controls.Add(tpPhotos)
            TbctlAttachment.Controls.Add(tpFiles)
            TbctlAttachment.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlAttachment.Location = New Point(280, 681)
            TbctlAttachment.Margin = New Padding(5, 6, 5, 6)
            TbctlAttachment.Name = "TbctlAttachment"
            TbctlAttachment.SelectedIndex = 0
            TbctlAttachment.Size = New Size(866, 394)
            TbctlAttachment.TabIndex = 1008
            ' 
            ' tpPhotos
            ' 
            tpPhotos.AutoScroll = True
            tpPhotos.AutoScrollMinSize = New Size(1, 1)
            tpPhotos.Controls.Add(PnlPhoto)
            tpPhotos.Location = New Point(4, 41)
            tpPhotos.Margin = New Padding(5, 6, 5, 6)
            tpPhotos.Name = "tpPhotos"
            tpPhotos.Padding = New Padding(5, 6, 5, 6)
            tpPhotos.Size = New Size(858, 349)
            tpPhotos.TabIndex = 0
            tpPhotos.Text = "Images"
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
            PnlPhoto.Location = New Point(5, 6)
            PnlPhoto.Margin = New Padding(5, 6, 5, 6)
            PnlPhoto.Name = "PnlPhoto"
            PnlPhoto.Size = New Size(848, 337)
            PnlPhoto.TabIndex = 11
            ' 
            ' BtnBrowsePhoto
            ' 
            BtnBrowsePhoto.BackColor = Color.RoyalBlue
            BtnBrowsePhoto.Cursor = Cursors.Hand
            BtnBrowsePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowsePhoto.FlatAppearance.BorderSize = 2
            BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowsePhoto.FlatStyle = FlatStyle.Flat
            BtnBrowsePhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowsePhoto.ForeColor = Color.White
            BtnBrowsePhoto.Image = My.Resources.Resources.Bullets_001_16_FFFFFFFF_
            BtnBrowsePhoto.Location = New Point(5, 6)
            BtnBrowsePhoto.Margin = New Padding(5, 6, 5, 6)
            BtnBrowsePhoto.Name = "BtnBrowsePhoto"
            BtnBrowsePhoto.Size = New Size(55, 56)
            BtnBrowsePhoto.TabIndex = 5
            BtnBrowsePhoto.UseVisualStyleBackColor = False
            BtnBrowsePhoto.XOButtonType = ControlCodeBase.buttonType.Default
            BtnBrowsePhoto.XOShowBorderOnFocus = False
            BtnBrowsePhoto.XOValidateAllInput = False
            BtnBrowsePhoto.XOValidateAllInputTag = Nothing
            ' 
            ' PctbxPhoto
            ' 
            PctbxPhoto.BackColor = Color.DarkSlateGray
            PctbxPhoto.BackgroundImage = My.Resources.Resources.PCTPRV_001_512_icon
            PctbxPhoto.BackgroundImageLayout = ImageLayout.Zoom
            PctbxPhoto.Dock = DockStyle.Right
            PctbxPhoto.ErrorImage = Nothing
            PctbxPhoto.InitialImage = Nothing
            PctbxPhoto.Location = New Point(580, 0)
            PctbxPhoto.Margin = New Padding(5, 6, 5, 6)
            PctbxPhoto.Name = "PctbxPhoto"
            PctbxPhoto.Size = New Size(268, 337)
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
            DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(237), CByte(199), CByte(113))
            DgnPictureList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
            DgnPictureList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            DgnPictureList.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnPictureList.BorderStyle = BorderStyle.None
            DgnPictureList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnPictureList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = Color.YellowGreen
            DataGridViewCellStyle8.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle8.SelectionForeColor = Color.Black
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
            DgnPictureList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
            DgnPictureList.ColumnHeadersHeight = 43
            DgnPictureList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnPictureList.Columns.AddRange(New DataGridViewColumn() {photo_id, photo_datetime, photo_content, photo_status, photo_uploader, photo_delete})
            DgnPictureList.EnableHeadersVisualStyles = False
            DgnPictureList.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnPictureList.Location = New Point(5, 73)
            DgnPictureList.Margin = New Padding(5, 6, 5, 6)
            DgnPictureList.MultiSelect = False
            DgnPictureList.Name = "DgnPictureList"
            DgnPictureList.ReadOnly = True
            DgnPictureList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.BackColor = Color.YellowGreen
            DataGridViewCellStyle9.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle9.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle9.SelectionForeColor = Color.Black
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
            DgnPictureList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
            DgnPictureList.RowHeadersWidth = 62
            DgnPictureList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnPictureList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgnPictureList.Size = New Size(565, 258)
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
            BtnPeekPhoto.BackColor = Color.Crimson
            BtnPeekPhoto.Cursor = Cursors.Hand
            BtnPeekPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(160), CByte(20), CByte(0))
            BtnPeekPhoto.FlatAppearance.BorderSize = 2
            BtnPeekPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(40), CByte(80))
            BtnPeekPhoto.FlatStyle = FlatStyle.Flat
            BtnPeekPhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnPeekPhoto.ForeColor = Color.White
            BtnPeekPhoto.Image = My.Resources.Resources.Peek_001_16_FFFFFFFF_
            BtnPeekPhoto.Location = New Point(443, 6)
            BtnPeekPhoto.Margin = New Padding(5, 6, 5, 6)
            BtnPeekPhoto.Name = "BtnPeekPhoto"
            BtnPeekPhoto.Size = New Size(55, 56)
            BtnPeekPhoto.TabIndex = 8
            BtnPeekPhoto.UseVisualStyleBackColor = False
            BtnPeekPhoto.XOButtonType = ControlCodeBase.buttonType.Custom
            BtnPeekPhoto.XOShowBorderOnFocus = False
            BtnPeekPhoto.XOValidateAllInput = False
            BtnPeekPhoto.XOValidateAllInputTag = Nothing
            ' 
            ' TxtPhotoPath
            ' 
            TxtPhotoPath.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPhotoPath.Location = New Point(70, 6)
            TxtPhotoPath.Margin = New Padding(5, 6, 5, 6)
            TxtPhotoPath.MaxLength = 255
            TxtPhotoPath.Name = "TxtPhotoPath"
            TxtPhotoPath.ReadOnly = True
            TxtPhotoPath.Size = New Size(361, 39)
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
            BtnAddPhoto.BackColor = Color.LimeGreen
            BtnAddPhoto.Cursor = Cursors.Hand
            BtnAddPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnAddPhoto.FlatAppearance.BorderSize = 2
            BtnAddPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnAddPhoto.FlatStyle = FlatStyle.Flat
            BtnAddPhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnAddPhoto.ForeColor = Color.White
            BtnAddPhoto.Image = My.Resources.Resources.Plus_001_16_FFFFFFFF_
            BtnAddPhoto.Location = New Point(508, 6)
            BtnAddPhoto.Margin = New Padding(5, 6, 5, 6)
            BtnAddPhoto.Name = "BtnAddPhoto"
            BtnAddPhoto.Size = New Size(55, 56)
            BtnAddPhoto.TabIndex = 9
            BtnAddPhoto.UseVisualStyleBackColor = False
            BtnAddPhoto.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnAddPhoto.XOShowBorderOnFocus = False
            BtnAddPhoto.XOValidateAllInput = False
            BtnAddPhoto.XOValidateAllInputTag = Nothing
            ' 
            ' tpFiles
            ' 
            tpFiles.Controls.Add(PnlFile)
            tpFiles.Location = New Point(4, 41)
            tpFiles.Margin = New Padding(5, 6, 5, 6)
            tpFiles.Name = "tpFiles"
            tpFiles.Padding = New Padding(5, 6, 5, 6)
            tpFiles.Size = New Size(1874, 349)
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
            PnlFile.Location = New Point(5, 6)
            PnlFile.Margin = New Padding(5, 6, 5, 6)
            PnlFile.Name = "PnlFile"
            PnlFile.Size = New Size(1864, 337)
            PnlFile.TabIndex = 16
            ' 
            ' BtnBrowseFile
            ' 
            BtnBrowseFile.BackColor = Color.RoyalBlue
            BtnBrowseFile.Cursor = Cursors.Hand
            BtnBrowseFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnBrowseFile.FlatAppearance.BorderSize = 2
            BtnBrowseFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnBrowseFile.FlatStyle = FlatStyle.Flat
            BtnBrowseFile.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowseFile.ForeColor = Color.White
            BtnBrowseFile.Image = My.Resources.Resources.Bullets_001_16_FFFFFFFF_
            BtnBrowseFile.Location = New Point(5, 6)
            BtnBrowseFile.Margin = New Padding(5, 6, 5, 6)
            BtnBrowseFile.Name = "BtnBrowseFile"
            BtnBrowseFile.Size = New Size(55, 56)
            BtnBrowseFile.TabIndex = 10
            BtnBrowseFile.UseVisualStyleBackColor = False
            BtnBrowseFile.XOButtonType = ControlCodeBase.buttonType.Default
            BtnBrowseFile.XOShowBorderOnFocus = False
            BtnBrowseFile.XOValidateAllInput = False
            BtnBrowseFile.XOValidateAllInputTag = Nothing
            ' 
            ' DgnFileList
            ' 
            DgnFileList.AllowUserToAddRows = False
            DgnFileList.AllowUserToDeleteRows = False
            DgnFileList.AllowUserToResizeRows = False
            DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(213), CByte(243), CByte(144))
            DgnFileList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
            DgnFileList.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            DgnFileList.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnFileList.BorderStyle = BorderStyle.None
            DgnFileList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnFileList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = Color.YellowGreen
            DataGridViewCellStyle11.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle11.SelectionForeColor = Color.Black
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
            DgnFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
            DgnFileList.ColumnHeadersHeight = 43
            DgnFileList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnFileList.Columns.AddRange(New DataGridViewColumn() {file_id, file_tag, file_datetime, file_content, file_status, file_uploader, file_delete})
            DgnFileList.EnableHeadersVisualStyles = False
            DgnFileList.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnFileList.Location = New Point(5, 73)
            DgnFileList.Margin = New Padding(5, 6, 5, 6)
            DgnFileList.MultiSelect = False
            DgnFileList.Name = "DgnFileList"
            DgnFileList.ReadOnly = True
            DgnFileList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = Color.YellowGreen
            DataGridViewCellStyle12.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle12.SelectionForeColor = Color.Black
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
            DgnFileList.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            DgnFileList.RowHeadersWidth = 62
            DgnFileList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnFileList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DgnFileList.Size = New Size(1854, 258)
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
            CboFileTag.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboFileTag.FormattingEnabled = True
            CboFileTag.Location = New Point(440, 6)
            CboFileTag.Margin = New Padding(5, 6, 5, 6)
            CboFileTag.Name = "CboFileTag"
            CboFileTag.Size = New Size(309, 40)
            CboFileTag.TabIndex = 15
            ' 
            ' TxtFilePath
            ' 
            TxtFilePath.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtFilePath.Location = New Point(70, 6)
            TxtFilePath.Margin = New Padding(5, 6, 5, 6)
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
            BtnAddFile.BackColor = Color.LimeGreen
            BtnAddFile.Cursor = Cursors.Hand
            BtnAddFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnAddFile.FlatAppearance.BorderSize = 2
            BtnAddFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnAddFile.FlatStyle = FlatStyle.Flat
            BtnAddFile.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnAddFile.ForeColor = Color.White
            BtnAddFile.Image = My.Resources.Resources.Plus_001_16_FFFFFFFF_
            BtnAddFile.Location = New Point(827, 6)
            BtnAddFile.Margin = New Padding(5, 6, 5, 6)
            BtnAddFile.Name = "BtnAddFile"
            BtnAddFile.Size = New Size(55, 56)
            BtnAddFile.TabIndex = 13
            BtnAddFile.UseVisualStyleBackColor = False
            BtnAddFile.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnAddFile.XOShowBorderOnFocus = False
            BtnAddFile.XOValidateAllInput = False
            BtnAddFile.XOValidateAllInputTag = Nothing
            ' 
            ' BtnPeekFile
            ' 
            BtnPeekFile.BackColor = Color.Crimson
            BtnPeekFile.Cursor = Cursors.Hand
            BtnPeekFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(160), CByte(20), CByte(0))
            BtnPeekFile.FlatAppearance.BorderSize = 2
            BtnPeekFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(40), CByte(80))
            BtnPeekFile.FlatStyle = FlatStyle.Flat
            BtnPeekFile.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnPeekFile.ForeColor = Color.White
            BtnPeekFile.Image = My.Resources.Resources.Peek_001_16_FFFFFFFF_
            BtnPeekFile.Location = New Point(762, 6)
            BtnPeekFile.Margin = New Padding(5, 6, 5, 6)
            BtnPeekFile.Name = "BtnPeekFile"
            BtnPeekFile.Size = New Size(55, 56)
            BtnPeekFile.TabIndex = 12
            BtnPeekFile.UseVisualStyleBackColor = False
            BtnPeekFile.XOButtonType = ControlCodeBase.buttonType.Custom
            BtnPeekFile.XOShowBorderOnFocus = False
            BtnPeekFile.XOValidateAllInput = False
            BtnPeekFile.XOValidateAllInputTag = Nothing
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.ForeColor = Color.MintCream
            ULbl1.Location = New Point(20, 19)
            ULbl1.Margin = New Padding(8, 12, 8, 12)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 56)
            ULbl1.SLFText = "Archive Code"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl1.TabIndex = 1009
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(20, 87)
            ULbl2.Margin = New Padding(8, 12, 8, 12)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 56)
            ULbl2.SLFText = "Name / Title"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1010
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(20, 154)
            ULbl3.Margin = New Padding(8, 12, 8, 12)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 56)
            ULbl3.SLFText = "Category"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl3.TabIndex = 1011
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 221)
            ULbl4.Margin = New Padding(8, 12, 8, 12)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 381)
            ULbl4.SLFText = "Short Desc."
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl4.TabIndex = 1012
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(20, 613)
            ULbl5.Margin = New Padding(8, 12, 8, 12)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 56)
            ULbl5.SLFText = "Keywords"
            ULbl5.SLFTextAdjuster = False
            ULbl5.SLFTextBorder = False
            ULbl5.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl5.TabIndex = 1013
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(20, 681)
            ULbl6.Margin = New Padding(8, 12, 8, 12)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 394)
            ULbl6.SLFText = "Attachment(s)"
            ULbl6.SLFTextAdjuster = False
            ULbl6.SLFTextBorder = False
            ULbl6.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl6.TabIndex = 1014
            ' 
            ' FRMpeprEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1162, 1170)
            KeyPreview = True
            Margin = New Padding(22, 44, 22, 44)
            Name = "FRMpeprEditor"
            PnlBottomButton.ResumeLayout(False)
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

        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents TxtArchiveCode As CMCv.UI.Control.txt
        Friend WithEvents Txt1 As CMCv.UI.Control.txt
        Friend WithEvents CboCategory As CMCv.UI.Control.Cbo
        Friend WithEvents TxtTitle As CMCv.UI.Control.txt
        Friend WithEvents Txt2 As CMCv.UI.Control.txt
        Friend WithEvents TbctlAttachment As CMCv.UI.Control.tbctl
        Friend WithEvents tpPhotos As TabPage
        Friend WithEvents PnlPhoto As CMCv.UI.Control.pnl
        Friend WithEvents BtnBrowsePhoto As CMCv.UI.Control.Btn
        Friend WithEvents PctbxPhoto As CMCv.UI.Control.pctbx
        Friend WithEvents DgnPictureList As CMCv.UI.Control.dgn
        Friend WithEvents photo_id As DataGridViewTextBoxColumn
        Friend WithEvents photo_datetime As DataGridViewTextBoxColumn
        Friend WithEvents photo_content As DataGridViewImageColumn
        Friend WithEvents photo_status As DataGridViewTextBoxColumn
        Friend WithEvents photo_uploader As DataGridViewTextBoxColumn
        Friend WithEvents photo_delete As DataGridViewButtonColumn
        Friend WithEvents BtnPeekPhoto As CMCv.UI.Control.Btn
        Friend WithEvents TxtPhotoPath As CMCv.UI.Control.txt
        Friend WithEvents BtnAddPhoto As CMCv.UI.Control.Btn
        Friend WithEvents tpFiles As TabPage
        Friend WithEvents PnlFile As CMCv.UI.Control.pnl
        Friend WithEvents BtnBrowseFile As CMCv.UI.Control.Btn
        Friend WithEvents DgnFileList As CMCv.UI.Control.dgn
        Friend WithEvents file_id As DataGridViewTextBoxColumn
        Friend WithEvents file_tag As DataGridViewTextBoxColumn
        Friend WithEvents file_datetime As DataGridViewTextBoxColumn
        Friend WithEvents file_content As DataGridViewTextBoxColumn
        Friend WithEvents file_status As DataGridViewTextBoxColumn
        Friend WithEvents file_uploader As DataGridViewTextBoxColumn
        Friend WithEvents file_delete As DataGridViewButtonColumn
        Friend WithEvents CboFileTag As CMCv.UI.Control.Cbo
        Friend WithEvents TxtFilePath As CMCv.UI.Control.txt
        Friend WithEvents BtnAddFile As CMCv.UI.Control.Btn
        Friend WithEvents BtnPeekFile As CMCv.UI.Control.Btn
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
    End Class
End Namespace