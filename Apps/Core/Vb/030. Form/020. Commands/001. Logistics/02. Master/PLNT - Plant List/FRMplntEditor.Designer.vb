Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMplntEditor
        Inherits CMCv.ui.canvas.FRMstandardFooter

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
            CboCompany = New CMCv.UI.Control.Cbo(components)
            TxtPlantCode = New CMCv.UI.Control.txt(components)
            TxtPlantName = New CMCv.UI.Control.txt(components)
            TxtSearchTerm1 = New CMCv.UI.Control.txt(components)
            TxtAddress = New CMCv.UI.Control.txt(components)
            TxtPostalCode = New CMCv.UI.Control.txt(components)
            TxtDescription = New CMCv.UI.Control.txt(components)
            TxtSearchTerm2 = New CMCv.UI.Control.txt(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            ULbl7 = New CMCv.UI.Control.ULbl()
            ULbl8 = New CMCv.UI.Control.ULbl()
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
            PnlBottomButton.Location = New Point(0, 729)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(651, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(651, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.AutoScroll = True
            SLFPanel.Controls.Add(ULbl8)
            SLFPanel.Controls.Add(ULbl7)
            SLFPanel.Controls.Add(ULbl6)
            SLFPanel.Controls.Add(ULbl5)
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtSearchTerm2)
            SLFPanel.Controls.Add(TxtDescription)
            SLFPanel.Controls.Add(TxtPostalCode)
            SLFPanel.Controls.Add(TxtAddress)
            SLFPanel.Controls.Add(TxtSearchTerm1)
            SLFPanel.Controls.Add(TxtPlantName)
            SLFPanel.Controls.Add(TxtPlantCode)
            SLFPanel.Controls.Add(CboCompany)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(651, 826)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(CboCompany, 0)
            SLFPanel.Controls.SetChildIndex(TxtPlantCode, 0)
            SLFPanel.Controls.SetChildIndex(TxtPlantName, 0)
            SLFPanel.Controls.SetChildIndex(TxtSearchTerm1, 0)
            SLFPanel.Controls.SetChildIndex(TxtAddress, 0)
            SLFPanel.Controls.SetChildIndex(TxtPostalCode, 0)
            SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
            SLFPanel.Controls.SetChildIndex(TxtSearchTerm2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
            SLFPanel.Controls.SetChildIndex(ULbl5, 0)
            SLFPanel.Controls.SetChildIndex(ULbl6, 0)
            SLFPanel.Controls.SetChildIndex(ULbl7, 0)
            SLFPanel.Controls.SetChildIndex(ULbl8, 0)
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            CboCompany.FormattingEnabled = True
            CboCompany.Location = New Point(234, 20)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(343, 40)
            CboCompany.TabIndex = 0
            ' 
            ' TxtPlantCode
            ' 
            TxtPlantCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPlantCode.Location = New Point(234, 87)
            TxtPlantCode.Margin = New Padding(6, 5, 6, 5)
            TxtPlantCode.MaxLength = 10
            TxtPlantCode.Name = "TxtPlantCode"
            TxtPlantCode.Size = New Size(263, 39)
            TxtPlantCode.TabIndex = 1
            TxtPlantCode.Tag = "txt"
            TxtPlantCode.TextAlign = HorizontalAlignment.Center
            TxtPlantCode.XOAutoTrim = True
            TxtPlantCode.XOIsMandatory = True
            TxtPlantCode.XOMandatoryBgColor = Color.LightPink
            TxtPlantCode.XOMandatoryBgColorDefault = Color.White
            TxtPlantCode.XOHighlightOnFocus = True
            TxtPlantCode.XOHighlightColor = Color.LightYellow
            TxtPlantCode.XOIsBlank = True
            TxtPlantCode.XOIsPlaceholder = False
            TxtPlantCode.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtPlantCode.XOSelectOnFocus = True
            TxtPlantCode.XOPasswordLengthMin = 8
            TxtPlantCode.XOPasswordStrengthCalc = False
            TxtPlantCode.XOPasswordStrengthScore = 0
            TxtPlantCode.XOPasswordStrengthText = Nothing
            TxtPlantCode.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtPlantCode.XOPlaceholderText = "Type then press Enter"
            TxtPlantCode.XOSqlText = ""
            TxtPlantCode.XOIsReplaceEmptyString = False
            TxtPlantCode.XOMandatoryMessage = Nothing
            ' 
            ' TxtPlantName
            ' 
            TxtPlantName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPlantName.Location = New Point(234, 153)
            TxtPlantName.Margin = New Padding(6, 5, 6, 5)
            TxtPlantName.MaxLength = 255
            TxtPlantName.Name = "TxtPlantName"
            TxtPlantName.Size = New Size(344, 39)
            TxtPlantName.TabIndex = 2
            TxtPlantName.Tag = "txt"
            TxtPlantName.XOAutoTrim = True
            TxtPlantName.XOIsMandatory = True
            TxtPlantName.XOMandatoryBgColor = Color.LightPink
            TxtPlantName.XOMandatoryBgColorDefault = Color.White
            TxtPlantName.XOHighlightOnFocus = True
            TxtPlantName.XOHighlightColor = Color.LightYellow
            TxtPlantName.XOIsBlank = True
            TxtPlantName.XOIsPlaceholder = False
            TxtPlantName.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtPlantName.XOSelectOnFocus = True
            TxtPlantName.XOPasswordLengthMin = 8
            TxtPlantName.XOPasswordStrengthCalc = False
            TxtPlantName.XOPasswordStrengthScore = 0
            TxtPlantName.XOPasswordStrengthText = Nothing
            TxtPlantName.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtPlantName.XOPlaceholderText = "Type then press Enter"
            TxtPlantName.XOSqlText = ""
            TxtPlantName.XOIsReplaceEmptyString = False
            TxtPlantName.XOMandatoryMessage = Nothing
            ' 
            ' TxtSearchTerm1
            ' 
            TxtSearchTerm1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtSearchTerm1.Location = New Point(234, 219)
            TxtSearchTerm1.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm1.MaxLength = 255
            TxtSearchTerm1.Name = "TxtSearchTerm1"
            TxtSearchTerm1.Size = New Size(344, 39)
            TxtSearchTerm1.TabIndex = 3
            TxtSearchTerm1.Tag = "txt"
            TxtSearchTerm1.XOAutoTrim = True
            TxtSearchTerm1.XOIsMandatory = False
            TxtSearchTerm1.XOMandatoryBgColor = Color.LightPink
            TxtSearchTerm1.XOMandatoryBgColorDefault = Color.White
            TxtSearchTerm1.XOHighlightOnFocus = True
            TxtSearchTerm1.XOHighlightColor = Color.LightYellow
            TxtSearchTerm1.XOIsBlank = True
            TxtSearchTerm1.XOIsPlaceholder = False
            TxtSearchTerm1.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtSearchTerm1.XOSelectOnFocus = False
            TxtSearchTerm1.XOPasswordLengthMin = 8
            TxtSearchTerm1.XOPasswordStrengthCalc = False
            TxtSearchTerm1.XOPasswordStrengthScore = 0
            TxtSearchTerm1.XOPasswordStrengthText = Nothing
            TxtSearchTerm1.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtSearchTerm1.XOPlaceholderText = "Type then press Enter"
            TxtSearchTerm1.XOSqlText = ""
            TxtSearchTerm1.XOIsReplaceEmptyString = False
            TxtSearchTerm1.XOMandatoryMessage = Nothing
            ' 
            ' TxtAddress
            ' 
            TxtAddress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtAddress.Location = New Point(234, 416)
            TxtAddress.Margin = New Padding(6, 5, 6, 5)
            TxtAddress.MaxLength = 255
            TxtAddress.Multiline = True
            TxtAddress.Name = "TxtAddress"
            TxtAddress.Size = New Size(344, 143)
            TxtAddress.TabIndex = 6
            TxtAddress.Tag = "txt"
            TxtAddress.XOAutoTrim = True
            TxtAddress.XOIsMandatory = False
            TxtAddress.XOMandatoryBgColor = Color.LightPink
            TxtAddress.XOMandatoryBgColorDefault = Color.White
            TxtAddress.XOHighlightOnFocus = True
            TxtAddress.XOHighlightColor = Color.LightYellow
            TxtAddress.XOIsBlank = True
            TxtAddress.XOIsPlaceholder = False
            TxtAddress.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtAddress.XOSelectOnFocus = True
            TxtAddress.XOPasswordLengthMin = 8
            TxtAddress.XOPasswordStrengthCalc = False
            TxtAddress.XOPasswordStrengthScore = 0
            TxtAddress.XOPasswordStrengthText = Nothing
            TxtAddress.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtAddress.XOPlaceholderText = "Type then press Enter"
            TxtAddress.XOSqlText = ""
            TxtAddress.XOIsReplaceEmptyString = False
            TxtAddress.XOMandatoryMessage = Nothing
            ' 
            ' TxtPostalCode
            ' 
            TxtPostalCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtPostalCode.Location = New Point(234, 586)
            TxtPostalCode.Margin = New Padding(6, 5, 6, 5)
            TxtPostalCode.MaxLength = 6
            TxtPostalCode.Name = "TxtPostalCode"
            TxtPostalCode.Size = New Size(158, 39)
            TxtPostalCode.TabIndex = 7
            TxtPostalCode.Tag = "txt"
            TxtPostalCode.TextAlign = HorizontalAlignment.Center
            TxtPostalCode.XOAutoTrim = True
            TxtPostalCode.XOIsMandatory = False
            TxtPostalCode.XOMandatoryBgColor = Color.LightPink
            TxtPostalCode.XOMandatoryBgColorDefault = Color.White
            TxtPostalCode.XOHighlightOnFocus = True
            TxtPostalCode.XOHighlightColor = Color.LightYellow
            TxtPostalCode.XOIsBlank = True
            TxtPostalCode.XOIsPlaceholder = False
            TxtPostalCode.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtPostalCode.XOSelectOnFocus = True
            TxtPostalCode.XOPasswordLengthMin = 8
            TxtPostalCode.XOPasswordStrengthCalc = False
            TxtPostalCode.XOPasswordStrengthScore = 0
            TxtPostalCode.XOPasswordStrengthText = Nothing
            TxtPostalCode.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtPostalCode.XOPlaceholderText = "Type then press Enter"
            TxtPostalCode.XOSqlText = ""
            TxtPostalCode.XOIsReplaceEmptyString = False
            TxtPostalCode.XOMandatoryMessage = Nothing
            ' 
            ' TxtDescription
            ' 
            TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDescription.Location = New Point(234, 351)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(344, 39)
            TxtDescription.TabIndex = 5
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = True
            TxtDescription.XOIsMandatory = False
            TxtDescription.XOMandatoryBgColor = Color.LightPink
            TxtDescription.XOMandatoryBgColorDefault = Color.White
            TxtDescription.XOHighlightOnFocus = True
            TxtDescription.XOHighlightColor = Color.LightYellow
            TxtDescription.XOIsBlank = True
            TxtDescription.XOIsPlaceholder = False
            TxtDescription.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtDescription.XOSelectOnFocus = False
            TxtDescription.XOPasswordLengthMin = 8
            TxtDescription.XOPasswordStrengthCalc = False
            TxtDescription.XOPasswordStrengthScore = 0
            TxtDescription.XOPasswordStrengthText = Nothing
            TxtDescription.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtDescription.XOPlaceholderText = "Type then press Enter"
            TxtDescription.XOSqlText = ""
            TxtDescription.XOIsReplaceEmptyString = False
            TxtDescription.XOMandatoryMessage = Nothing
            ' 
            ' TxtSearchTerm2
            ' 
            TxtSearchTerm2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtSearchTerm2.Location = New Point(234, 285)
            TxtSearchTerm2.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm2.MaxLength = 255
            TxtSearchTerm2.Name = "TxtSearchTerm2"
            TxtSearchTerm2.Size = New Size(341, 39)
            TxtSearchTerm2.TabIndex = 4
            TxtSearchTerm2.Tag = "txt"
            TxtSearchTerm2.XOAutoTrim = True
            TxtSearchTerm2.XOIsMandatory = False
            TxtSearchTerm2.XOMandatoryBgColor = Color.LightPink
            TxtSearchTerm2.XOMandatoryBgColorDefault = Color.White
            TxtSearchTerm2.XOHighlightOnFocus = True
            TxtSearchTerm2.XOHighlightColor = Color.LightYellow
            TxtSearchTerm2.XOIsBlank = True
            TxtSearchTerm2.XOIsPlaceholder = False
            TxtSearchTerm2.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.UPPERCASE
            TxtSearchTerm2.XOSelectOnFocus = False
            TxtSearchTerm2.XOPasswordLengthMin = 8
            TxtSearchTerm2.XOPasswordStrengthCalc = False
            TxtSearchTerm2.XOPasswordStrengthScore = 0
            TxtSearchTerm2.XOPasswordStrengthText = Nothing
            TxtSearchTerm2.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtSearchTerm2.XOPlaceholderText = "Type then press Enter"
            TxtSearchTerm2.XOSqlText = ""
            TxtSearchTerm2.XOIsReplaceEmptyString = False
            TxtSearchTerm2.XOMandatoryMessage = Nothing
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
            BtnSave.Location = New Point(287, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 600
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.Yes
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
            BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(464, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 602
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(56, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 601
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(17, 20)
            ULbl1.Margin = New Padding(5, 6, 5, 6)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(197, 39)
            ULbl1.XOText = "Company"
            ULbl1.XOTextAdjuster = True
            ULbl1.XOTextBorder = False
            ULbl1.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.TabIndex = 1014
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(17, 87)
            ULbl2.Margin = New Padding(5, 6, 5, 6)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(197, 39)
            ULbl2.XOText = "Plant Code"
            ULbl2.XOTextAdjuster = True
            ULbl2.XOTextBorder = False
            ULbl2.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.TabIndex = 1015
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(17, 153)
            ULbl3.Margin = New Padding(5, 6, 5, 6)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(197, 39)
            ULbl3.XOText = "Plant Name"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ULbl3.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.TabIndex = 1016
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(17, 219)
            ULbl4.Margin = New Padding(5, 6, 5, 6)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(197, 39)
            ULbl4.XOText = "Search Term 1"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ULbl4.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.TabIndex = 1017
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(17, 285)
            ULbl5.Margin = New Padding(5, 6, 5, 6)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(197, 39)
            ULbl5.XOText = "Search Term 2"
            ULbl5.XOTextAdjuster = True
            ULbl5.XOTextBorder = False
            ULbl5.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.TabIndex = 1018
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.Moccasin
            ULbl6.Location = New Point(17, 351)
            ULbl6.Margin = New Padding(5, 6, 5, 6)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(197, 39)
            ULbl6.XOText = "Description"
            ULbl6.XOTextAdjuster = True
            ULbl6.XOTextBorder = False
            ULbl6.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl6.TabIndex = 1019
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.Moccasin
            ULbl7.Location = New Point(17, 416)
            ULbl7.Margin = New Padding(5, 6, 5, 6)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(197, 143)
            ULbl7.XOText = "Address"
            ULbl7.XOTextAdjuster = True
            ULbl7.XOTextBorder = False
            ULbl7.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl7.TabIndex = 1020
            ' 
            ' ULbl8
            ' 
            ULbl8.BackColor = Color.Moccasin
            ULbl8.Location = New Point(17, 586)
            ULbl8.Margin = New Padding(5, 6, 5, 6)
            ULbl8.Name = "ULbl8"
            ULbl8.Size = New Size(197, 39)
            ULbl8.XOText = "Postal Code"
            ULbl8.XOTextAdjuster = True
            ULbl8.XOTextBorder = False
            ULbl8.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl8.TabIndex = 1021
            ' 
            ' FRMplntEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(651, 958)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMplntEditor"
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

        Friend WithEvents CboCompany As CMCv.UI.Control.Cbo
        Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
        Friend WithEvents TxtSearchTerm2 As CMCv.UI.Control.txt
        Friend WithEvents TxtDescription As CMCv.UI.Control.txt
        Friend WithEvents TxtPostalCode As CMCv.UI.Control.txt
        Friend WithEvents TxtAddress As CMCv.UI.Control.txt
        Friend WithEvents TxtPlantName2 As CMCv.UI.Control.txt
        Friend WithEvents TxtSearchTerm1 As CMCv.UI.Control.txt
        Friend WithEvents TxtPlantName As CMCv.UI.Control.txt
        Friend WithEvents TxtPlantCode As CMCv.UI.Control.txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl8 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
    End Class
End Namespace