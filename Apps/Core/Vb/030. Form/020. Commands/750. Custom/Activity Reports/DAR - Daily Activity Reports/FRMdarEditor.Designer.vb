Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdarEditor
        Inherits CMCv.UI.Canvas.FRMstandardFooter

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMdarEditor))
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            CboTemplate = New CMCv.UI.Control.Cbo(components)
            DtpStart = New CMCv.UI.Control.Dtp(components)
            TxtContent = New CMCv.UI.Control.Txt(components)
            CboArea = New CMCv.UI.Control.Cbo(components)
            MebStart = New CMCv.UI.Control.Meb(components)
            BtnGETContent = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            MebEnd = New CMCv.UI.Control.Meb(components)
            DtpEnd = New CMCv.UI.Control.Dtp(components)
            TxtFeedback = New CMCv.UI.Control.Txt(components)
            OfdPhoto = New OpenFileDialog()
            TbctlAttachment = New CMCv.UI.Control.Tbx(components)
            tpPhotos = New TabPage()
            PnlPhoto = New CMCv.UI.Control.Pnl(components)
            BtnBrowsePhoto = New CMCv.UI.Control.Btn(components)
            PctbxPhoto = New CMCv.UI.Control.Pbx(components)
            DgnPictureList = New CMCv.UI.Control.Dgn(components)
            photo_id = New DataGridViewTextBoxColumn()
            photo_filename = New DataGridViewTextBoxColumn()
            photo_datetime = New DataGridViewTextBoxColumn()
            photo_content = New DataGridViewImageColumn()
            photo_status = New DataGridViewTextBoxColumn()
            photo_uploader = New DataGridViewTextBoxColumn()
            photo_delete = New DataGridViewButtonColumn()
            BtnPeekPhoto = New CMCv.UI.Control.Btn(components)
            TxtPhotoPath = New CMCv.UI.Control.Txt(components)
            BtnAddPhoto = New CMCv.UI.Control.Btn(components)
            tpFiles = New TabPage()
            PnlFile = New CMCv.UI.Control.Pnl(components)
            BtnBrowseFile = New CMCv.UI.Control.Btn(components)
            DgnFileList = New CMCv.UI.Control.Dgn(components)
            file_id = New DataGridViewTextBoxColumn()
            file_filename = New DataGridViewTextBoxColumn()
            file_tag = New DataGridViewTextBoxColumn()
            file_datetime = New DataGridViewTextBoxColumn()
            file_content = New DataGridViewTextBoxColumn()
            file_status = New DataGridViewTextBoxColumn()
            file_uploader = New DataGridViewTextBoxColumn()
            file_delete = New DataGridViewButtonColumn()
            CboFileTag = New CMCv.UI.Control.Cbo(components)
            TxtFilePath = New CMCv.UI.Control.Txt(components)
            BtnAddFile = New CMCv.UI.Control.Btn(components)
            BtnPeekFile = New CMCv.UI.Control.Btn(components)
            ofdFile = New OpenFileDialog()
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            ULbl7 = New CMCv.UI.Control.ULbl()
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
            BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(826, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 600
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
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
            BtnCancel.Location = New Point(1003, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 602
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' CboTemplate
            ' 
            CboTemplate.DropDownStyle = ComboBoxStyle.DropDownList
            CboTemplate.DropDownWidth = 350
            CboTemplate.FlatStyle = FlatStyle.Flat
            CboTemplate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            DtpStart.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            TxtContent.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            TxtContent.XOIsMandatory = True
            TxtContent.XOMandatoryBgColor = Color.LightPink
            TxtContent.XOMandatoryBgColorDefault = Color.White
            TxtContent.XOHighlightOnFocus = True
            TxtContent.XOHighlightColor = Color.LightYellow
            TxtContent.XOIsBlank = True
            TxtContent.XOIsPlaceholder = False
            TxtContent.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtContent.XOSelectOnFocus = False
            TxtContent.XOPasswordLengthMin = 8
            TxtContent.XOPasswordStrengthCalc = False
            TxtContent.XOPasswordStrengthScore = 0
            TxtContent.XOPasswordStrengthText = Nothing
            TxtContent.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtContent.XOPlaceholderText = "Type then press Enter"
            TxtContent.XOSqlText = Nothing
            TxtContent.XOIsReplaceEmptyString = False
            TxtContent.XOMandatoryMessage = Nothing
            ' 
            ' CboArea
            ' 
            CboArea.DropDownStyle = ComboBoxStyle.DropDownList
            CboArea.DropDownWidth = 350
            CboArea.FlatStyle = FlatStyle.Flat
            CboArea.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            MebStart.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            MebStart.Location = New Point(583, 20)
            MebStart.Margin = New Padding(6, 5, 6, 5)
            MebStart.Mask = "00:00"
            MebStart.Name = "MebStart"
            MebStart.Size = New Size(78, 39)
            MebStart.TabIndex = 1
            MebStart.TextAlign = HorizontalAlignment.Center
            MebStart.ValidatingType = GetType(Date)
            MebStart.XOIsMandatory = True
            MebStart.XOMandatoryBgColor = Color.LightPink
            MebStart.XOMandatoryBgColorDefault = Color.White
            MebStart.XOHighlightOnFocus = True
            MebStart.XOHighlightColor = Color.LightYellow
            MebStart.XOSelectOnFocus = True
            ' 
            ' BtnGETContent
            ' 
            BtnGETContent.BackColor = Color.RoyalBlue
            BtnGETContent.Cursor = Cursors.Hand
            BtnGETContent.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnGETContent.FlatAppearance.BorderSize = 2
            BtnGETContent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnGETContent.FlatStyle = FlatStyle.Flat
            BtnGETContent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnGETContent.ForeColor = Color.White
            BtnGETContent.Location = New Point(674, 208)
            BtnGETContent.Margin = New Padding(6, 5, 6, 5)
            BtnGETContent.Name = "BtnGETContent"
            BtnGETContent.Size = New Size(167, 77)
            BtnGETContent.TabIndex = 6
            BtnGETContent.Text = "Apply"
            BtnGETContent.UseVisualStyleBackColor = False
            BtnGETContent.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Default
            BtnGETContent.XOShowBorderOnFocus = False
            BtnGETContent.XOValidateAllInput = False
            BtnGETContent.XOValidateAllInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            MebEnd.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            MebEnd.Location = New Point(583, 87)
            MebEnd.Margin = New Padding(6, 5, 6, 5)
            MebEnd.Mask = "00:00"
            MebEnd.Name = "MebEnd"
            MebEnd.Size = New Size(78, 39)
            MebEnd.TabIndex = 3
            MebEnd.TextAlign = HorizontalAlignment.Center
            MebEnd.ValidatingType = GetType(Date)
            MebEnd.XOIsMandatory = True
            MebEnd.XOMandatoryBgColor = Color.LightPink
            MebEnd.XOMandatoryBgColorDefault = Color.White
            MebEnd.XOHighlightOnFocus = True
            MebEnd.XOHighlightColor = Color.LightYellow
            MebEnd.XOSelectOnFocus = True
            ' 
            ' DtpEnd
            ' 
            DtpEnd.CustomFormat = "dd MMMM yyyy"
            DtpEnd.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            TxtFeedback.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            TxtFeedback.XOIsMandatory = False
            TxtFeedback.XOMandatoryBgColor = Color.LightPink
            TxtFeedback.XOMandatoryBgColorDefault = Color.White
            TxtFeedback.XOHighlightOnFocus = True
            TxtFeedback.XOHighlightColor = Color.LightYellow
            TxtFeedback.XOIsBlank = True
            TxtFeedback.XOIsPlaceholder = False
            TxtFeedback.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtFeedback.XOSelectOnFocus = False
            TxtFeedback.XOPasswordLengthMin = 8
            TxtFeedback.XOPasswordStrengthCalc = False
            TxtFeedback.XOPasswordStrengthScore = 0
            TxtFeedback.XOPasswordStrengthText = Nothing
            TxtFeedback.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtFeedback.XOPlaceholderText = "Type then press Enter"
            TxtFeedback.XOSqlText = ""
            TxtFeedback.XOIsReplaceEmptyString = False
            TxtFeedback.XOMandatoryMessage = Nothing
            ' 
            ' OfdPhoto
            ' 
            OfdPhoto.FileName = "OpenFileDialog1"
            ' 
            ' TbctlAttachment
            ' 
            TbctlAttachment.Controls.Add(tpPhotos)
            TbctlAttachment.Controls.Add(tpFiles)
            TbctlAttachment.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            BtnBrowsePhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowsePhoto.ForeColor = Color.White
            BtnBrowsePhoto.Image = My.Resources.Resources.FOLDER_001_16_ICON
            BtnBrowsePhoto.Location = New Point(6, 5)
            BtnBrowsePhoto.Margin = New Padding(6, 5, 6, 5)
            BtnBrowsePhoto.Name = "BtnBrowsePhoto"
            BtnBrowsePhoto.Size = New Size(54, 55)
            BtnBrowsePhoto.TabIndex = 5
            BtnBrowsePhoto.UseVisualStyleBackColor = False
            BtnBrowsePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Custom
            BtnBrowsePhoto.XOShowBorderOnFocus = False
            BtnBrowsePhoto.XOValidateAllInput = False
            BtnBrowsePhoto.XOValidateAllInputTag = Nothing
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
            PctbxPhoto.XOShowBorder = False
            PctbxPhoto.XOBorderColor = Color.DodgerBlue
            ' 
            ' DgnPictureList
            ' 
            DgnPictureList.AllowUserToAddRows = False
            DgnPictureList.AllowUserToDeleteRows = False
            DgnPictureList.AllowUserToResizeRows = False
            DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(203), CByte(199), CByte(173))
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
            DgnPictureList.Columns.AddRange(New DataGridViewColumn() {photo_id, photo_filename, photo_datetime, photo_content, photo_status, photo_uploader, photo_delete})
            DgnPictureList.EnableHeadersVisualStyles = False
            DgnPictureList.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnPictureList.Location = New Point(6, 73)
            DgnPictureList.Margin = New Padding(6, 5, 6, 5)
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
            DgnPictureList.Size = New Size(602, 262)
            DgnPictureList.StandardTab = True
            DgnPictureList.TabIndex = 10
            DgnPictureList.XOIsGroupFirstRow = False
            DgnPictureList.XOIsShowRowNumber = True
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
            BtnPeekPhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnPeekPhoto.ForeColor = Color.White
            BtnPeekPhoto.Image = My.Resources.Resources.ZOOMNORMAL_001_16_ICON
            BtnPeekPhoto.Location = New Point(483, 5)
            BtnPeekPhoto.Margin = New Padding(6, 5, 6, 5)
            BtnPeekPhoto.Name = "BtnPeekPhoto"
            BtnPeekPhoto.Size = New Size(54, 55)
            BtnPeekPhoto.TabIndex = 8
            BtnPeekPhoto.UseVisualStyleBackColor = False
            BtnPeekPhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Custom
            BtnPeekPhoto.XOShowBorderOnFocus = False
            BtnPeekPhoto.XOValidateAllInput = False
            BtnPeekPhoto.XOValidateAllInputTag = Nothing
            ' 
            ' TxtPhotoPath
            ' 
            TxtPhotoPath.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPhotoPath.Location = New Point(70, 5)
            TxtPhotoPath.Margin = New Padding(6, 5, 6, 5)
            TxtPhotoPath.MaxLength = 255
            TxtPhotoPath.Name = "TxtPhotoPath"
            TxtPhotoPath.ReadOnly = True
            TxtPhotoPath.Size = New Size(401, 39)
            TxtPhotoPath.TabIndex = 7
            TxtPhotoPath.Tag = "txt"
            TxtPhotoPath.XOAutoTrim = False
            TxtPhotoPath.XOIsMandatory = False
            TxtPhotoPath.XOMandatoryBgColor = Color.LightPink
            TxtPhotoPath.XOMandatoryBgColorDefault = Color.White
            TxtPhotoPath.XOHighlightOnFocus = False
            TxtPhotoPath.XOHighlightColor = Color.LightYellow
            TxtPhotoPath.XOIsBlank = True
            TxtPhotoPath.XOIsPlaceholder = False
            TxtPhotoPath.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtPhotoPath.XOSelectOnFocus = False
            TxtPhotoPath.XOPasswordLengthMin = 8
            TxtPhotoPath.XOPasswordStrengthCalc = False
            TxtPhotoPath.XOPasswordStrengthScore = 0
            TxtPhotoPath.XOPasswordStrengthText = Nothing
            TxtPhotoPath.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtPhotoPath.XOPlaceholderText = "Type then press Enter"
            TxtPhotoPath.XOSqlText = ""
            TxtPhotoPath.XOIsReplaceEmptyString = False
            TxtPhotoPath.XOMandatoryMessage = Nothing
            ' 
            ' BtnAddPhoto
            ' 
            BtnAddPhoto.BackColor = Color.Black
            BtnAddPhoto.Cursor = Cursors.Hand
            BtnAddPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
            BtnAddPhoto.FlatAppearance.BorderSize = 2
            BtnAddPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
            BtnAddPhoto.FlatStyle = FlatStyle.Flat
            BtnAddPhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnAddPhoto.ForeColor = Color.White
            BtnAddPhoto.Image = My.Resources.Resources.ADD_001_16_ICON
            BtnAddPhoto.Location = New Point(549, 5)
            BtnAddPhoto.Margin = New Padding(6, 5, 6, 5)
            BtnAddPhoto.Name = "BtnAddPhoto"
            BtnAddPhoto.Size = New Size(54, 55)
            BtnAddPhoto.TabIndex = 9
            BtnAddPhoto.UseVisualStyleBackColor = False
            BtnAddPhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Custom
            BtnAddPhoto.XOShowBorderOnFocus = False
            BtnAddPhoto.XOValidateAllInput = False
            BtnAddPhoto.XOValidateAllInputTag = Nothing
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
            BtnBrowseFile.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowseFile.ForeColor = Color.White
            BtnBrowseFile.Image = My.Resources.Resources.FOLDER_001_16_ICON
            BtnBrowseFile.Location = New Point(6, 5)
            BtnBrowseFile.Margin = New Padding(6, 5, 6, 5)
            BtnBrowseFile.Name = "BtnBrowseFile"
            BtnBrowseFile.Size = New Size(54, 55)
            BtnBrowseFile.TabIndex = 10
            BtnBrowseFile.UseVisualStyleBackColor = False
            BtnBrowseFile.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Custom
            BtnBrowseFile.XOShowBorderOnFocus = False
            BtnBrowseFile.XOValidateAllInput = False
            BtnBrowseFile.XOValidateAllInputTag = Nothing
            ' 
            ' DgnFileList
            ' 
            DgnFileList.AllowUserToAddRows = False
            DgnFileList.AllowUserToDeleteRows = False
            DgnFileList.AllowUserToResizeRows = False
            DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(234), CByte(253), CByte(168))
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
            DgnFileList.Columns.AddRange(New DataGridViewColumn() {file_id, file_filename, file_tag, file_datetime, file_content, file_status, file_uploader, file_delete})
            DgnFileList.EnableHeadersVisualStyles = False
            DgnFileList.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnFileList.Location = New Point(6, 73)
            DgnFileList.Margin = New Padding(6, 5, 6, 5)
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
            DgnFileList.Size = New Size(880, 262)
            DgnFileList.StandardTab = True
            DgnFileList.TabIndex = 14
            DgnFileList.XOIsGroupFirstRow = False
            DgnFileList.XOIsShowRowNumber = True
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
            CboFileTag.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboFileTag.FormattingEnabled = True
            CboFileTag.Location = New Point(440, 5)
            CboFileTag.Margin = New Padding(6, 5, 6, 5)
            CboFileTag.Name = "CboFileTag"
            CboFileTag.Size = New Size(310, 40)
            CboFileTag.TabIndex = 15
            ' 
            ' TxtFilePath
            ' 
            TxtFilePath.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtFilePath.Location = New Point(70, 5)
            TxtFilePath.Margin = New Padding(6, 5, 6, 5)
            TxtFilePath.MaxLength = 255
            TxtFilePath.Name = "TxtFilePath"
            TxtFilePath.ReadOnly = True
            TxtFilePath.Size = New Size(357, 39)
            TxtFilePath.TabIndex = 11
            TxtFilePath.Tag = "txt"
            TxtFilePath.XOAutoTrim = False
            TxtFilePath.XOIsMandatory = False
            TxtFilePath.XOMandatoryBgColor = Color.LightPink
            TxtFilePath.XOMandatoryBgColorDefault = Color.White
            TxtFilePath.XOHighlightOnFocus = False
            TxtFilePath.XOHighlightColor = Color.LightYellow
            TxtFilePath.XOIsBlank = True
            TxtFilePath.XOIsPlaceholder = False
            TxtFilePath.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtFilePath.XOSelectOnFocus = False
            TxtFilePath.XOPasswordLengthMin = 8
            TxtFilePath.XOPasswordStrengthCalc = False
            TxtFilePath.XOPasswordStrengthScore = 0
            TxtFilePath.XOPasswordStrengthText = Nothing
            TxtFilePath.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtFilePath.XOPlaceholderText = "Type then press Enter"
            TxtFilePath.XOSqlText = ""
            TxtFilePath.XOIsReplaceEmptyString = False
            TxtFilePath.XOMandatoryMessage = Nothing
            ' 
            ' BtnAddFile
            ' 
            BtnAddFile.BackColor = Color.Black
            BtnAddFile.Cursor = Cursors.Hand
            BtnAddFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
            BtnAddFile.FlatAppearance.BorderSize = 2
            BtnAddFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
            BtnAddFile.FlatStyle = FlatStyle.Flat
            BtnAddFile.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnAddFile.ForeColor = Color.White
            BtnAddFile.Image = My.Resources.Resources.ADD_001_16_ICON
            BtnAddFile.Location = New Point(827, 5)
            BtnAddFile.Margin = New Padding(6, 5, 6, 5)
            BtnAddFile.Name = "BtnAddFile"
            BtnAddFile.Size = New Size(54, 55)
            BtnAddFile.TabIndex = 13
            BtnAddFile.UseVisualStyleBackColor = False
            BtnAddFile.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Custom
            BtnAddFile.XOShowBorderOnFocus = False
            BtnAddFile.XOValidateAllInput = False
            BtnAddFile.XOValidateAllInputTag = Nothing
            ' 
            ' BtnPeekFile
            ' 
            BtnPeekFile.BackColor = Color.Black
            BtnPeekFile.Cursor = Cursors.Hand
            BtnPeekFile.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
            BtnPeekFile.FlatAppearance.BorderSize = 2
            BtnPeekFile.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
            BtnPeekFile.FlatStyle = FlatStyle.Flat
            BtnPeekFile.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnPeekFile.ForeColor = Color.White
            BtnPeekFile.Image = My.Resources.Resources.ZOOMNORMAL_001_16_ICON
            BtnPeekFile.Location = New Point(761, 5)
            BtnPeekFile.Margin = New Padding(6, 5, 6, 5)
            BtnPeekFile.Name = "BtnPeekFile"
            BtnPeekFile.Size = New Size(54, 55)
            BtnPeekFile.TabIndex = 12
            BtnPeekFile.UseVisualStyleBackColor = False
            BtnPeekFile.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Custom
            BtnPeekFile.XOShowBorderOnFocus = False
            BtnPeekFile.XOValidateAllInput = False
            BtnPeekFile.XOValidateAllInputTag = Nothing
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
            ULbl1.XOText = "Activity Start"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.TabIndex = 1003
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(20, 87)
            ULbl2.Margin = New Padding(7, 5, 7, 5)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 55)
            ULbl2.XOText = "To"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.TabIndex = 1004
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(20, 153)
            ULbl3.Margin = New Padding(7, 5, 7, 5)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 55)
            ULbl3.XOText = "Area Affected"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.TabIndex = 1005
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 222)
            ULbl4.Margin = New Padding(7, 5, 7, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 55)
            ULbl4.XOText = "Activity Template"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ULbl4.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.TabIndex = 1006
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(20, 288)
            ULbl5.Margin = New Padding(7, 5, 7, 5)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 230)
            ULbl5.XOText = "Description"
            ULbl5.XOTextAdjuster = False
            ULbl5.XOTextBorder = False
            ULbl5.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.TabIndex = 1007
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(20, 530)
            ULbl6.Margin = New Padding(7, 5, 7, 5)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 120)
            ULbl6.XOText = "Feedback" & vbCrLf & "(Supv. Only)"
            ULbl6.XOTextAdjuster = False
            ULbl6.XOTextBorder = False
            ULbl6.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl6.TabIndex = 1008
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.Moccasin
            ULbl7.Location = New Point(20, 662)
            ULbl7.Margin = New Padding(7, 5, 7, 5)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(250, 395)
            ULbl7.XOText = "Attachment(s)"
            ULbl7.XOTextAdjuster = False
            ULbl7.XOTextBorder = False
            ULbl7.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl7.TabIndex = 1009
            ' 
            ' FRMdarEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
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
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents DtpStart As CMCv.UI.Control.Dtp
        Friend WithEvents CboTemplate As CMCv.UI.Control.Cbo
        Friend WithEvents TxtContent As CMCv.UI.Control.Txt
        Friend WithEvents CboArea As CMCv.UI.Control.Cbo
        Friend WithEvents MebStart As CMCv.UI.Control.Meb
        Friend WithEvents BtnGETContent As CMCv.UI.Control.Btn
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents MebEnd As CMCv.UI.Control.Meb
        Friend WithEvents DtpEnd As CMCv.UI.Control.Dtp
        Friend WithEvents TxtFeedback As CMCv.UI.Control.Txt
        Friend WithEvents OfdPhoto As OpenFileDialog
        Friend WithEvents TbctlAttachment As CMCv.UI.Control.Tbx
        Friend WithEvents tpPhotos As TabPage
        Friend WithEvents BtnPeekPhoto As CMCv.UI.Control.Btn
        Friend WithEvents BtnBrowsePhoto As CMCv.UI.Control.Btn
        Friend WithEvents BtnAddPhoto As CMCv.UI.Control.Btn
        Friend WithEvents TxtPhotoPath As CMCv.UI.Control.Txt
        Friend WithEvents DgnPictureList As CMCv.UI.Control.Dgn
        Friend WithEvents PctbxPhoto As CMCv.UI.Control.Pbx
        Friend WithEvents tpFiles As TabPage
        Friend WithEvents BtnPeekFile As CMCv.UI.Control.Btn
        Friend WithEvents BtnBrowseFile As CMCv.UI.Control.Btn
        Friend WithEvents BtnAddFile As CMCv.UI.Control.Btn
        Friend WithEvents TxtFilePath As CMCv.UI.Control.Txt
        Friend WithEvents DgnFileList As CMCv.UI.Control.Dgn
        Friend WithEvents ofdFile As OpenFileDialog
        Friend WithEvents CboFileTag As CMCv.UI.Control.Cbo
        Friend WithEvents PnlPhoto As CMCv.UI.Control.Pnl
        Friend WithEvents PnlFile As CMCv.UI.Control.Pnl
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
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
End Namespace