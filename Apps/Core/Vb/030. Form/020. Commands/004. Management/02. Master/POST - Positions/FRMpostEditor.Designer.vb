Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMpostEditor
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
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            TbxPosition = New CMCv.UI.Control.Tbx(components)
            tpDetail = New TabPage()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULblDepartment = New CMCv.UI.Control.ULbl()
            ULblCompany = New CMCv.UI.Control.ULbl()
            TxtPositionDescription = New CMCv.UI.Control.Txt(components)
            TxtPositionName = New CMCv.UI.Control.Txt(components)
            CboDepartement = New CMCv.UI.Control.Cbo(components)
            CboCompany = New CMCv.UI.Control.Cbo(components)
            TxtPositionCode = New CMCv.UI.Control.Txt(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            TbxPosition.SuspendLayout()
            tpDetail.SuspendLayout()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 736)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(824, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(824, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TbxPosition)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(824, 833)
            SLFPanel.Controls.SetChildIndex(TbxPosition, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
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
            BtnSave.Location = New Point(460, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 801
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
            BtnCancel.Location = New Point(637, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 802
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.FromArgb(CByte(12), CByte(18), CByte(40))
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F)
            ChkAddNew.ForeColor = Color.White
            ChkAddNew.Location = New Point(233, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 803
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ChkAddNew.XOCheckColor = Color.White
            ' 
            ' TbxPosition
            ' 
            TbxPosition.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            TbxPosition.Controls.Add(tpDetail)
            TbxPosition.Font = New Font("Segoe UI", 12F)
            TbxPosition.Location = New Point(20, 25)
            TbxPosition.Name = "TbxPosition"
            TbxPosition.SelectedIndex = 0
            TbxPosition.Size = New Size(784, 700)
            TbxPosition.TabIndex = 1019
            ' 
            ' tpDetail
            ' 
            tpDetail.AutoScroll = True
            tpDetail.BackColor = Color.FromArgb(CByte(11), CByte(28), CByte(45))
            tpDetail.Controls.Add(ULbl3)
            tpDetail.Controls.Add(ULbl2)
            tpDetail.Controls.Add(ULbl1)
            tpDetail.Controls.Add(ULblDepartment)
            tpDetail.Controls.Add(ULblCompany)
            tpDetail.Controls.Add(TxtPositionDescription)
            tpDetail.Controls.Add(TxtPositionName)
            tpDetail.Controls.Add(CboDepartement)
            tpDetail.Controls.Add(CboCompany)
            tpDetail.Controls.Add(TxtPositionCode)
            tpDetail.Location = New Point(4, 41)
            tpDetail.Name = "tpDetail"
            tpDetail.Padding = New Padding(3)
            tpDetail.Size = New Size(776, 655)
            tpDetail.TabIndex = 0
            tpDetail.Text = "DETAIL"
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(16, 316)
            ULbl3.Margin = New Padding(5, 6, 5, 6)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(272, 254)
            ULbl3.TabIndex = 1028
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.XOText = "Description"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.MistyRose
            ULbl2.Location = New Point(16, 247)
            ULbl2.Margin = New Padding(5, 6, 5, 6)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(272, 38)
            ULbl2.TabIndex = 1027
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl2.XOText = "Position Name"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.MistyRose
            ULbl1.Location = New Point(16, 178)
            ULbl1.Margin = New Padding(5, 6, 5, 6)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(272, 38)
            ULbl1.TabIndex = 1026
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULbl1.XOText = "Position Code"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ' 
            ' ULblDepartment
            ' 
            ULblDepartment.BackColor = Color.MistyRose
            ULblDepartment.Location = New Point(16, 108)
            ULblDepartment.Margin = New Padding(5, 6, 5, 6)
            ULblDepartment.Name = "ULblDepartment"
            ULblDepartment.Size = New Size(272, 38)
            ULblDepartment.TabIndex = 1025
            ULblDepartment.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULblDepartment.XOText = "Department"
            ULblDepartment.XOTextAdjuster = False
            ULblDepartment.XOTextBorder = False
            ' 
            ' ULblCompany
            ' 
            ULblCompany.BackColor = Color.MistyRose
            ULblCompany.Location = New Point(16, 38)
            ULblCompany.Margin = New Padding(6, 8, 6, 8)
            ULblCompany.Name = "ULblCompany"
            ULblCompany.Size = New Size(272, 38)
            ULblCompany.TabIndex = 1024
            ULblCompany.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Red
            ULblCompany.XOText = "Company"
            ULblCompany.XOTextAdjuster = False
            ULblCompany.XOTextBorder = False
            ' 
            ' TxtPositionDescription
            ' 
            TxtPositionDescription.Font = New Font("Segoe UI", 12F)
            TxtPositionDescription.Location = New Point(306, 316)
            TxtPositionDescription.Margin = New Padding(6, 5, 6, 5)
            TxtPositionDescription.MaxLength = 255
            TxtPositionDescription.Multiline = True
            TxtPositionDescription.Name = "TxtPositionDescription"
            TxtPositionDescription.Size = New Size(425, 254)
            TxtPositionDescription.TabIndex = 1023
            TxtPositionDescription.Tag = "txt"
            TxtPositionDescription.XOAutoTrim = False
            TxtPositionDescription.XOHighlightColor = Color.LightYellow
            TxtPositionDescription.XOHighlightOnFocus = True
            TxtPositionDescription.XOIsBlank = True
            TxtPositionDescription.XOIsMandatory = False
            TxtPositionDescription.XOIsPlaceholder = False
            TxtPositionDescription.XOIsReplaceEmptyString = False
            TxtPositionDescription.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtPositionDescription.XOMandatoryBgColor = Color.LightPink
            TxtPositionDescription.XOMandatoryBgColorDefault = Color.White
            TxtPositionDescription.XOMandatoryMessage = Nothing
            TxtPositionDescription.XOPasswordLengthMin = 8
            TxtPositionDescription.XOPasswordStrengthCalc = False
            TxtPositionDescription.XOPasswordStrengthScore = 0
            TxtPositionDescription.XOPasswordStrengthText = Nothing
            TxtPositionDescription.XOPlaceholderText = "Type then press Enter"
            TxtPositionDescription.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtPositionDescription.XOSelectOnFocus = False
            TxtPositionDescription.XOSqlText = ""
            ' 
            ' TxtPositionName
            ' 
            TxtPositionName.Font = New Font("Segoe UI", 12F)
            TxtPositionName.Location = New Point(306, 247)
            TxtPositionName.Margin = New Padding(6, 5, 6, 5)
            TxtPositionName.MaxLength = 255
            TxtPositionName.Name = "TxtPositionName"
            TxtPositionName.Size = New Size(425, 39)
            TxtPositionName.TabIndex = 1022
            TxtPositionName.Tag = "txt"
            TxtPositionName.XOAutoTrim = True
            TxtPositionName.XOHighlightColor = Color.LightYellow
            TxtPositionName.XOHighlightOnFocus = True
            TxtPositionName.XOIsBlank = True
            TxtPositionName.XOIsMandatory = True
            TxtPositionName.XOIsPlaceholder = False
            TxtPositionName.XOIsReplaceEmptyString = False
            TxtPositionName.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtPositionName.XOMandatoryBgColor = Color.LightPink
            TxtPositionName.XOMandatoryBgColorDefault = Color.White
            TxtPositionName.XOMandatoryMessage = Nothing
            TxtPositionName.XOPasswordLengthMin = 8
            TxtPositionName.XOPasswordStrengthCalc = False
            TxtPositionName.XOPasswordStrengthScore = 0
            TxtPositionName.XOPasswordStrengthText = Nothing
            TxtPositionName.XOPlaceholderText = "Type then press Enter"
            TxtPositionName.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberAndSpace
            TxtPositionName.XOSelectOnFocus = False
            TxtPositionName.XOSqlText = ""
            ' 
            ' CboDepartement
            ' 
            CboDepartement.DropDownStyle = ComboBoxStyle.DropDownList
            CboDepartement.DropDownWidth = 350
            CboDepartement.FlatStyle = FlatStyle.Flat
            CboDepartement.Font = New Font("Segoe UI", 12F)
            CboDepartement.FormattingEnabled = True
            CboDepartement.Location = New Point(306, 108)
            CboDepartement.Margin = New Padding(6, 5, 6, 5)
            CboDepartement.Name = "CboDepartement"
            CboDepartement.Size = New Size(425, 40)
            CboDepartement.TabIndex = 1020
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.DropDownWidth = 350
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12F)
            CboCompany.FormattingEnabled = True
            CboCompany.Location = New Point(306, 38)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(425, 40)
            CboCompany.TabIndex = 1019
            ' 
            ' TxtPositionCode
            ' 
            TxtPositionCode.Font = New Font("Segoe UI", 12F)
            TxtPositionCode.Location = New Point(306, 178)
            TxtPositionCode.Margin = New Padding(6, 5, 6, 5)
            TxtPositionCode.MaxLength = 255
            TxtPositionCode.Name = "TxtPositionCode"
            TxtPositionCode.Size = New Size(425, 39)
            TxtPositionCode.TabIndex = 1021
            TxtPositionCode.Tag = "txt"
            TxtPositionCode.XOAutoTrim = True
            TxtPositionCode.XOHighlightColor = Color.LightYellow
            TxtPositionCode.XOHighlightOnFocus = True
            TxtPositionCode.XOIsBlank = True
            TxtPositionCode.XOIsMandatory = True
            TxtPositionCode.XOIsPlaceholder = False
            TxtPositionCode.XOIsReplaceEmptyString = False
            TxtPositionCode.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtPositionCode.XOMandatoryBgColor = Color.LightPink
            TxtPositionCode.XOMandatoryBgColorDefault = Color.White
            TxtPositionCode.XOMandatoryMessage = Nothing
            TxtPositionCode.XOPasswordLengthMin = 8
            TxtPositionCode.XOPasswordStrengthCalc = False
            TxtPositionCode.XOPasswordStrengthScore = 0
            TxtPositionCode.XOPasswordStrengthText = Nothing
            TxtPositionCode.XOPlaceholderText = "Type then press Enter"
            TxtPositionCode.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.TextNumberNoSpace
            TxtPositionCode.XOSelectOnFocus = True
            TxtPositionCode.XOSqlText = ""
            ' 
            ' FRMpostEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(824, 965)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMpostEditor"
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            TbxPosition.ResumeLayout(False)
            tpDetail.ResumeLayout(False)
            tpDetail.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents TbxPosition As CMCv.UI.Control.Tbx
        Friend WithEvents tpDetail As TabPage
        Friend WithEvents TxtPositionDescription As CMCv.UI.Control.Txt
        Friend WithEvents TxtPositionName As CMCv.UI.Control.Txt
        Friend WithEvents CboDepartement As CMCv.UI.Control.Cbo
        Friend WithEvents CboCompany As CMCv.UI.Control.Cbo
        Friend WithEvents TxtPositionCode As CMCv.UI.Control.Txt
        Friend WithEvents ULblCompany As CMCv.UI.Control.ULbl
        Friend WithEvents ULblDepartment As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
    End Class
End Namespace