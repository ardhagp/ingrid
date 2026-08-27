Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMccinEditor
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMccinEditor))
            TxtCode = New CMCv.UI.Control.Txt(components)
            TxtSearchTerm1 = New CMCv.UI.Control.Txt(components)
            TxtSearchTerm2 = New CMCv.UI.Control.Txt(components)
            TxtDescription = New CMCv.UI.Control.Txt(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            TxtName = New CMCv.UI.Control.Txt(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            Tbx1 = New CMCv.UI.Control.Tbx(components)
            tpDetail = New TabPage()
            ULbl6 = New CMCv.UI.Control.ULbl()
            BtnRemovePhoto = New CMCv.UI.Control.Btn(components)
            BtnBrowsePhoto = New CMCv.UI.Control.Btn(components)
            pctbxPhoto = New CMCv.UI.Control.Pbx(components)
            pcbxFrame = New CMCv.UI.Control.Pbx(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Tbx1.SuspendLayout()
            tpDetail.SuspendLayout()
            CType(pctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
            CType(pcbxFrame, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 736)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(1181, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(1181, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.AutoScroll = True
            SLFPanel.Controls.Add(BtnRemovePhoto)
            SLFPanel.Controls.Add(BtnBrowsePhoto)
            SLFPanel.Controls.Add(pctbxPhoto)
            SLFPanel.Controls.Add(pcbxFrame)
            SLFPanel.Controls.Add(ULbl6)
            SLFPanel.Controls.Add(Tbx1)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(1181, 833)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Tbx1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl6, 0)
            SLFPanel.Controls.SetChildIndex(pcbxFrame, 0)
            SLFPanel.Controls.SetChildIndex(pctbxPhoto, 0)
            SLFPanel.Controls.SetChildIndex(BtnBrowsePhoto, 0)
            SLFPanel.Controls.SetChildIndex(BtnRemovePhoto, 0)
            ' 
            ' TxtCode
            ' 
            TxtCode.Font = New Font("Segoe UI", 12F)
            TxtCode.Location = New Point(273, 15)
            TxtCode.Margin = New Padding(6, 5, 6, 5)
            TxtCode.MaxLength = 255
            TxtCode.Name = "TxtCode"
            TxtCode.Size = New Size(533, 39)
            TxtCode.TabIndex = 0
            TxtCode.Tag = "txt"
            TxtCode.XOAutoTrim = True
            TxtCode.XOHighlightColor = Color.LightYellow
            TxtCode.XOHighlightOnFocus = True
            TxtCode.XOIsBlank = True
            TxtCode.XOIsMandatory = True
            TxtCode.XOIsPlaceholder = False
            TxtCode.XOIsReplaceEmptyString = False
            TxtCode.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtCode.XOMandatoryBgColor = Color.LightPink
            TxtCode.XOMandatoryBgColorDefault = Color.White
            TxtCode.XOMandatoryMessage = Nothing
            TxtCode.XOPasswordLengthMin = 8
            TxtCode.XOPasswordStrengthCalc = False
            TxtCode.XOPasswordStrengthScore = 0
            TxtCode.XOPasswordStrengthText = Nothing
            TxtCode.XOPlaceholderText = "Type then press Enter"
            TxtCode.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberNoSpace
            TxtCode.XOSelectOnFocus = True
            TxtCode.XOSqlText = ""
            ' 
            ' TxtSearchTerm1
            ' 
            TxtSearchTerm1.Font = New Font("Segoe UI", 12F)
            TxtSearchTerm1.Location = New Point(273, 150)
            TxtSearchTerm1.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm1.MaxLength = 255
            TxtSearchTerm1.Name = "TxtSearchTerm1"
            TxtSearchTerm1.Size = New Size(533, 39)
            TxtSearchTerm1.TabIndex = 2
            TxtSearchTerm1.Tag = "txt"
            TxtSearchTerm1.XOAutoTrim = True
            TxtSearchTerm1.XOHighlightColor = Color.LightYellow
            TxtSearchTerm1.XOHighlightOnFocus = True
            TxtSearchTerm1.XOIsBlank = True
            TxtSearchTerm1.XOIsMandatory = True
            TxtSearchTerm1.XOIsPlaceholder = False
            TxtSearchTerm1.XOIsReplaceEmptyString = False
            TxtSearchTerm1.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtSearchTerm1.XOMandatoryBgColor = Color.LightPink
            TxtSearchTerm1.XOMandatoryBgColorDefault = Color.White
            TxtSearchTerm1.XOMandatoryMessage = Nothing
            TxtSearchTerm1.XOPasswordLengthMin = 8
            TxtSearchTerm1.XOPasswordStrengthCalc = False
            TxtSearchTerm1.XOPasswordStrengthScore = 0
            TxtSearchTerm1.XOPasswordStrengthText = Nothing
            TxtSearchTerm1.XOPlaceholderText = "Type then press Enter"
            TxtSearchTerm1.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberAndSpace
            TxtSearchTerm1.XOSelectOnFocus = False
            TxtSearchTerm1.XOSqlText = ""
            ' 
            ' TxtSearchTerm2
            ' 
            TxtSearchTerm2.Font = New Font("Segoe UI", 12F)
            TxtSearchTerm2.Location = New Point(273, 217)
            TxtSearchTerm2.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm2.MaxLength = 255
            TxtSearchTerm2.Name = "TxtSearchTerm2"
            TxtSearchTerm2.Size = New Size(534, 39)
            TxtSearchTerm2.TabIndex = 3
            TxtSearchTerm2.Tag = "txt"
            TxtSearchTerm2.XOAutoTrim = True
            TxtSearchTerm2.XOHighlightColor = Color.LightYellow
            TxtSearchTerm2.XOHighlightOnFocus = True
            TxtSearchTerm2.XOIsBlank = True
            TxtSearchTerm2.XOIsMandatory = True
            TxtSearchTerm2.XOIsPlaceholder = False
            TxtSearchTerm2.XOIsReplaceEmptyString = False
            TxtSearchTerm2.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtSearchTerm2.XOMandatoryBgColor = Color.LightPink
            TxtSearchTerm2.XOMandatoryBgColorDefault = Color.White
            TxtSearchTerm2.XOMandatoryMessage = Nothing
            TxtSearchTerm2.XOPasswordLengthMin = 8
            TxtSearchTerm2.XOPasswordStrengthCalc = False
            TxtSearchTerm2.XOPasswordStrengthScore = 0
            TxtSearchTerm2.XOPasswordStrengthText = Nothing
            TxtSearchTerm2.XOPlaceholderText = "Type then press Enter"
            TxtSearchTerm2.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberAndSpace
            TxtSearchTerm2.XOSelectOnFocus = False
            TxtSearchTerm2.XOSqlText = ""
            ' 
            ' TxtDescription
            ' 
            TxtDescription.Font = New Font("Segoe UI", 12F)
            TxtDescription.Location = New Point(273, 285)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Multiline = True
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(533, 254)
            TxtDescription.TabIndex = 4
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = True
            TxtDescription.XOHighlightColor = Color.LightYellow
            TxtDescription.XOHighlightOnFocus = True
            TxtDescription.XOIsBlank = True
            TxtDescription.XOIsMandatory = False
            TxtDescription.XOIsPlaceholder = False
            TxtDescription.XOIsReplaceEmptyString = False
            TxtDescription.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtDescription.XOMandatoryBgColor = Color.LightPink
            TxtDescription.XOMandatoryBgColorDefault = Color.White
            TxtDescription.XOMandatoryMessage = Nothing
            TxtDescription.XOPasswordLengthMin = 8
            TxtDescription.XOPasswordStrengthCalc = False
            TxtDescription.XOPasswordStrengthScore = 0
            TxtDescription.XOPasswordStrengthText = Nothing
            TxtDescription.XOPlaceholderText = "Type then press Enter"
            TxtDescription.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtDescription.XOSelectOnFocus = False
            TxtDescription.XOSqlText = ""
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
            BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(817, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 5
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
            BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(994, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 7
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' TxtName
            ' 
            TxtName.Font = New Font("Segoe UI", 12F)
            TxtName.Location = New Point(273, 83)
            TxtName.Margin = New Padding(6, 5, 6, 5)
            TxtName.MaxLength = 255
            TxtName.Name = "TxtName"
            TxtName.Size = New Size(533, 39)
            TxtName.TabIndex = 1
            TxtName.Tag = "txt"
            TxtName.XOAutoTrim = True
            TxtName.XOHighlightColor = Color.LightYellow
            TxtName.XOHighlightOnFocus = True
            TxtName.XOIsBlank = True
            TxtName.XOIsMandatory = True
            TxtName.XOIsPlaceholder = False
            TxtName.XOIsReplaceEmptyString = False
            TxtName.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtName.XOMandatoryBgColor = Color.LightPink
            TxtName.XOMandatoryBgColorDefault = Color.White
            TxtName.XOMandatoryMessage = Nothing
            TxtName.XOPasswordLengthMin = 8
            TxtName.XOPasswordStrengthCalc = False
            TxtName.XOPasswordStrengthScore = 0
            TxtName.XOPasswordStrengthText = Nothing
            TxtName.XOPlaceholderText = "Type then press Enter"
            TxtName.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberAndSpace
            TxtName.XOSelectOnFocus = False
            TxtName.XOSqlText = ""
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(586, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 6
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.MistyRose
            ULbl1.Location = New Point(14, 15)
            ULbl1.Margin = New Padding(12, 8, 12, 8)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 39)
            ULbl1.TabIndex = 1006
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl1.XOText = "Company Code"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.MistyRose
            ULbl2.Location = New Point(14, 83)
            ULbl2.Margin = New Padding(12, 8, 12, 8)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 39)
            ULbl2.TabIndex = 1007
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl2.XOText = "Company Name"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.MistyRose
            ULbl3.Location = New Point(14, 150)
            ULbl3.Margin = New Padding(12, 8, 12, 8)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 39)
            ULbl3.TabIndex = 1008
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl3.XOText = "Search Term 1"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.MistyRose
            ULbl4.Location = New Point(15, 217)
            ULbl4.Margin = New Padding(12, 8, 12, 8)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 39)
            ULbl4.TabIndex = 1009
            ULbl4.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl4.XOText = "Search Term 2"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(15, 285)
            ULbl5.Margin = New Padding(12, 8, 12, 8)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 254)
            ULbl5.TabIndex = 1010
            ULbl5.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.XOText = "Description"
            ULbl5.XOTextAdjuster = False
            ULbl5.XOTextBorder = False
            ' 
            ' Tbx1
            ' 
            Tbx1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            Tbx1.Controls.Add(tpDetail)
            Tbx1.Font = New Font("Segoe UI", 12F)
            Tbx1.ItemSize = New Size(126, 37)
            Tbx1.Location = New Point(20, 25)
            Tbx1.Name = "Tbx1"
            Tbx1.SelectedIndex = 0
            Tbx1.Size = New Size(830, 700)
            Tbx1.TabIndex = 1011
            ' 
            ' tpDetail
            ' 
            tpDetail.AutoScroll = True
            tpDetail.BackColor = Color.FromArgb(CByte(11), CByte(28), CByte(45))
            tpDetail.Controls.Add(ULbl1)
            tpDetail.Controls.Add(ULbl5)
            tpDetail.Controls.Add(TxtCode)
            tpDetail.Controls.Add(ULbl4)
            tpDetail.Controls.Add(ULbl2)
            tpDetail.Controls.Add(ULbl3)
            tpDetail.Controls.Add(TxtSearchTerm1)
            tpDetail.Controls.Add(TxtSearchTerm2)
            tpDetail.Controls.Add(TxtName)
            tpDetail.Controls.Add(TxtDescription)
            tpDetail.Location = New Point(4, 41)
            tpDetail.Name = "tpDetail"
            tpDetail.Padding = New Padding(3)
            tpDetail.Size = New Size(822, 655)
            tpDetail.TabIndex = 0
            tpDetail.Text = "DETAIL"
            ' 
            ' ULbl6
            ' 
            ULbl6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(887, 83)
            ULbl6.Margin = New Padding(5, 6, 5, 6)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 39)
            ULbl6.TabIndex = 1012
            ULbl6.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl6.XOText = "Company Logo"
            ULbl6.XOTextAdjuster = False
            ULbl6.XOTextBorder = False
            ' 
            ' BtnRemovePhoto
            ' 
            BtnRemovePhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnRemovePhoto.BackColor = Color.Gray
            BtnRemovePhoto.Enabled = False
            BtnRemovePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
            BtnRemovePhoto.FlatAppearance.BorderSize = 2
            BtnRemovePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(148), CByte(148), CByte(148))
            BtnRemovePhoto.FlatStyle = FlatStyle.Flat
            BtnRemovePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnRemovePhoto.ForeColor = Color.DarkGray
            BtnRemovePhoto.Location = New Point(923, 449)
            BtnRemovePhoto.Name = "BtnRemovePhoto"
            BtnRemovePhoto.Size = New Size(179, 80)
            BtnRemovePhoto.TabIndex = 1046
            BtnRemovePhoto.Text = "Remove"
            BtnRemovePhoto.UseVisualStyleBackColor = False
            BtnRemovePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
            BtnRemovePhoto.XOShowBorderOnFocus = False
            BtnRemovePhoto.XOValidateAllInput = False
            BtnRemovePhoto.XOValidateAllInputTag = Nothing
            ' 
            ' BtnBrowsePhoto
            ' 
            BtnBrowsePhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnBrowsePhoto.BackColor = Color.Gray
            BtnBrowsePhoto.Cursor = Cursors.Hand
            BtnBrowsePhoto.Enabled = False
            BtnBrowsePhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
            BtnBrowsePhoto.FlatAppearance.BorderSize = 2
            BtnBrowsePhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(148), CByte(148), CByte(148))
            BtnBrowsePhoto.FlatStyle = FlatStyle.Flat
            BtnBrowsePhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnBrowsePhoto.ForeColor = Color.DarkGray
            BtnBrowsePhoto.Location = New Point(923, 361)
            BtnBrowsePhoto.Name = "BtnBrowsePhoto"
            BtnBrowsePhoto.Size = New Size(179, 80)
            BtnBrowsePhoto.TabIndex = 1043
            BtnBrowsePhoto.Text = "Browse"
            BtnBrowsePhoto.UseVisualStyleBackColor = False
            BtnBrowsePhoto.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Disabled
            BtnBrowsePhoto.XOShowBorderOnFocus = False
            BtnBrowsePhoto.XOValidateAllInput = False
            BtnBrowsePhoto.XOValidateAllInputTag = Nothing
            ' 
            ' pctbxPhoto
            ' 
            pctbxPhoto.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            pctbxPhoto.BackColor = Color.White
            pctbxPhoto.ErrorImage = CType(resources.GetObject("pctbxPhoto.ErrorImage"), Image)
            pctbxPhoto.Image = CType(resources.GetObject("pctbxPhoto.Image"), Image)
            pctbxPhoto.InitialImage = CType(resources.GetObject("pctbxPhoto.InitialImage"), Image)
            pctbxPhoto.Location = New Point(923, 162)
            pctbxPhoto.Margin = New Padding(6, 5, 6, 5)
            pctbxPhoto.Name = "pctbxPhoto"
            pctbxPhoto.Padding = New Padding(26, 28, 26, 28)
            pctbxPhoto.Size = New Size(179, 179)
            pctbxPhoto.SizeMode = PictureBoxSizeMode.Zoom
            pctbxPhoto.TabIndex = 1044
            pctbxPhoto.TabStop = False
            pctbxPhoto.XOBorderColor = Color.Transparent
            pctbxPhoto.XOShowBorder = False
            ' 
            ' pcbxFrame
            ' 
            pcbxFrame.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            pcbxFrame.BackColor = Color.White
            pcbxFrame.BorderStyle = BorderStyle.FixedSingle
            pcbxFrame.ErrorImage = CType(resources.GetObject("pcbxFrame.ErrorImage"), Image)
            pcbxFrame.InitialImage = CType(resources.GetObject("pcbxFrame.InitialImage"), Image)
            pcbxFrame.Location = New Point(916, 155)
            pcbxFrame.Margin = New Padding(6, 5, 6, 5)
            pcbxFrame.Name = "pcbxFrame"
            pcbxFrame.Size = New Size(193, 193)
            pcbxFrame.SizeMode = PictureBoxSizeMode.Zoom
            pcbxFrame.TabIndex = 1045
            pcbxFrame.TabStop = False
            pcbxFrame.XOBorderColor = Color.DodgerBlue
            pcbxFrame.XOShowBorder = False
            ' 
            ' FRMccinEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1181, 965)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMccinEditor"
            ShowIcon = False
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Tbx1.ResumeLayout(False)
            tpDetail.ResumeLayout(False)
            tpDetail.PerformLayout()
            CType(pctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
            CType(pcbxFrame, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents TxtCode As CMCv.UI.Control.Txt
        Friend WithEvents TxtDescription As CMCv.UI.Control.Txt
        Friend WithEvents TxtSearchTerm2 As CMCv.UI.Control.Txt
        Friend WithEvents TxtSearchTerm1 As CMCv.UI.Control.Txt
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents TxtName As CMCv.UI.Control.Txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents Tbx1 As CMCv.UI.Control.Tbx
        Friend WithEvents tpDetail As TabPage
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents BtnRemovePhoto As CMCv.UI.Control.Btn
        Friend WithEvents BtnBrowsePhoto As CMCv.UI.Control.Btn
        Friend WithEvents pctbxPhoto As CMCv.UI.Control.Pbx
        Friend WithEvents pcbxFrame As CMCv.UI.Control.Pbx
    End Class
End Namespace