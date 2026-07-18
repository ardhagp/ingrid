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
            TxtPositionDescription = New CMCv.UI.Control.Txt(components)
            TxtPositionName = New CMCv.UI.Control.Txt(components)
            CboDepartement = New CMCv.UI.Control.Cbo(components)
            CboCompany = New CMCv.UI.Control.Cbo(components)
            TxtPositionCode = New CMCv.UI.Control.Txt(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl5 = New CMCv.UI.Control.ULbl()
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
            PnlBottomButton.Location = New Point(0, 671)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(854, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(854, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl5)
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtPositionDescription)
            SLFPanel.Controls.Add(TxtPositionName)
            SLFPanel.Controls.Add(CboDepartement)
            SLFPanel.Controls.Add(CboCompany)
            SLFPanel.Controls.Add(TxtPositionCode)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(854, 768)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TxtPositionCode, 0)
            SLFPanel.Controls.SetChildIndex(CboCompany, 0)
            SLFPanel.Controls.SetChildIndex(CboDepartement, 0)
            SLFPanel.Controls.SetChildIndex(TxtPositionName, 0)
            SLFPanel.Controls.SetChildIndex(TxtPositionDescription, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
            SLFPanel.Controls.SetChildIndex(ULbl5, 0)
            ' 
            ' TxtPositionDescription
            ' 
            TxtPositionDescription.Font = New Font("Segoe UI", 12F)
            TxtPositionDescription.Location = New Point(280, 288)
            TxtPositionDescription.Margin = New Padding(6, 5, 6, 5)
            TxtPositionDescription.MaxLength = 255
            TxtPositionDescription.Multiline = True
            TxtPositionDescription.Name = "TxtPositionDescription"
            TxtPositionDescription.Size = New Size(545, 221)
            TxtPositionDescription.TabIndex = 4
            TxtPositionDescription.Tag = "txt"
            TxtPositionDescription.XOAutoTrim = False
            TxtPositionDescription.XOHighlightColor = Color.LightYellow
            TxtPositionDescription.XOHighlightOnFocus = False
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
            TxtPositionName.Location = New Point(280, 222)
            TxtPositionName.Margin = New Padding(6, 5, 6, 5)
            TxtPositionName.MaxLength = 255
            TxtPositionName.Name = "TxtPositionName"
            TxtPositionName.Size = New Size(341, 39)
            TxtPositionName.TabIndex = 3
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
            TxtPositionName.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
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
            CboDepartement.Location = New Point(280, 87)
            CboDepartement.Margin = New Padding(6, 5, 6, 5)
            CboDepartement.Name = "CboDepartement"
            CboDepartement.Size = New Size(341, 40)
            CboDepartement.TabIndex = 1
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.DropDownWidth = 350
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12F)
            CboCompany.FormattingEnabled = True
            CboCompany.Location = New Point(280, 20)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(341, 40)
            CboCompany.TabIndex = 0
            ' 
            ' TxtPositionCode
            ' 
            TxtPositionCode.Font = New Font("Segoe UI", 12F)
            TxtPositionCode.Location = New Point(280, 153)
            TxtPositionCode.Margin = New Padding(6, 5, 6, 5)
            TxtPositionCode.MaxLength = 255
            TxtPositionCode.Name = "TxtPositionCode"
            TxtPositionCode.Size = New Size(341, 39)
            TxtPositionCode.TabIndex = 2
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
            TxtPositionCode.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtPositionCode.XOSelectOnFocus = True
            TxtPositionCode.XOSqlText = ""
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
            BtnSave.Location = New Point(490, 13)
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
            BtnCancel.Location = New Point(667, 13)
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
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(263, 22)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 803
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(20, 20)
            ULbl1.Margin = New Padding(7, 5, 7, 5)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 55)
            ULbl1.TabIndex = 1014
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.XOText = "Company"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(20, 87)
            ULbl2.Margin = New Padding(7, 5, 7, 5)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 55)
            ULbl2.TabIndex = 1015
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.XOText = "Department"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(20, 153)
            ULbl3.Margin = New Padding(7, 5, 7, 5)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 55)
            ULbl3.TabIndex = 1016
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.XOText = "Position Code"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 222)
            ULbl4.Margin = New Padding(7, 5, 7, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 55)
            ULbl4.TabIndex = 1017
            ULbl4.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.XOText = "Position Name"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(20, 288)
            ULbl5.Margin = New Padding(7, 5, 7, 5)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 225)
            ULbl5.TabIndex = 1018
            ULbl5.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.XOText = "Description"
            ULbl5.XOTextAdjuster = False
            ULbl5.XOTextBorder = False
            ' 
            ' FRMpostEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(854, 900)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMpostEditor"
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
        Friend WithEvents TxtPositionDescription As CMCv.UI.Control.Txt
        Friend WithEvents TxtPositionName As CMCv.UI.Control.Txt
        Friend WithEvents CboDepartement As CMCv.UI.Control.Cbo
        Friend WithEvents CboCompany As CMCv.UI.Control.Cbo
        Friend WithEvents TxtPositionCode As CMCv.UI.Control.Txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
    End Class
End Namespace