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
            PnlBottomButton.Location = New Point(0, 669)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(899, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(899, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl5)
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtName)
            SLFPanel.Controls.Add(TxtDescription)
            SLFPanel.Controls.Add(TxtSearchTerm2)
            SLFPanel.Controls.Add(TxtSearchTerm1)
            SLFPanel.Controls.Add(TxtCode)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(899, 766)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TxtCode, 0)
            SLFPanel.Controls.SetChildIndex(TxtSearchTerm1, 0)
            SLFPanel.Controls.SetChildIndex(TxtSearchTerm2, 0)
            SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
            SLFPanel.Controls.SetChildIndex(TxtName, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
            SLFPanel.Controls.SetChildIndex(ULbl5, 0)
            ' 
            ' TxtCode
            ' 
            TxtCode.Font = New Font("Segoe UI", 12F)
            TxtCode.Location = New Point(281, 20)
            TxtCode.Margin = New Padding(6, 5, 6, 5)
            TxtCode.MaxLength = 255
            TxtCode.Name = "TxtCode"
            TxtCode.Size = New Size(341, 39)
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
            TxtSearchTerm1.Location = New Point(280, 153)
            TxtSearchTerm1.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm1.MaxLength = 255
            TxtSearchTerm1.Name = "TxtSearchTerm1"
            TxtSearchTerm1.Size = New Size(341, 39)
            TxtSearchTerm1.TabIndex = 2
            TxtSearchTerm1.Tag = "txt"
            TxtSearchTerm1.XOAutoTrim = True
            TxtSearchTerm1.XOHighlightColor = Color.LightYellow
            TxtSearchTerm1.XOHighlightOnFocus = False
            TxtSearchTerm1.XOIsBlank = True
            TxtSearchTerm1.XOIsMandatory = False
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
            TxtSearchTerm2.Location = New Point(280, 222)
            TxtSearchTerm2.Margin = New Padding(6, 5, 6, 5)
            TxtSearchTerm2.MaxLength = 255
            TxtSearchTerm2.Name = "TxtSearchTerm2"
            TxtSearchTerm2.Size = New Size(591, 39)
            TxtSearchTerm2.TabIndex = 3
            TxtSearchTerm2.Tag = "txt"
            TxtSearchTerm2.XOAutoTrim = True
            TxtSearchTerm2.XOHighlightColor = Color.LightYellow
            TxtSearchTerm2.XOHighlightOnFocus = False
            TxtSearchTerm2.XOIsBlank = True
            TxtSearchTerm2.XOIsMandatory = False
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
            TxtDescription.Location = New Point(280, 288)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Multiline = True
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(591, 221)
            TxtDescription.TabIndex = 4
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = True
            TxtDescription.XOHighlightColor = Color.LightYellow
            TxtDescription.XOHighlightOnFocus = False
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
            BtnSave.Location = New Point(535, 13)
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
            BtnCancel.Location = New Point(712, 13)
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
            TxtName.Location = New Point(280, 87)
            TxtName.Margin = New Padding(6, 5, 6, 5)
            TxtName.MaxLength = 255
            TxtName.Name = "TxtName"
            TxtName.Size = New Size(341, 39)
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
            ChkAddNew.Location = New Point(304, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 6
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(20, 20)
            ULbl1.Margin = New Padding(7, 5, 7, 5)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 39)
            ULbl1.TabIndex = 1006
            ULbl1.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.XOText = "Company Code"
            ULbl1.XOTextAdjuster = False
            ULbl1.XOTextBorder = False
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(20, 87)
            ULbl2.Margin = New Padding(7, 5, 7, 5)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 39)
            ULbl2.TabIndex = 1007
            ULbl2.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.XOText = "Company Name"
            ULbl2.XOTextAdjuster = False
            ULbl2.XOTextBorder = False
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(20, 153)
            ULbl3.Margin = New Padding(7, 5, 7, 5)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 39)
            ULbl3.TabIndex = 1008
            ULbl3.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.XOText = "Search Term 1"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 222)
            ULbl4.Margin = New Padding(7, 5, 7, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 39)
            ULbl4.TabIndex = 1009
            ULbl4.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.XOText = "Search Term 2"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(20, 288)
            ULbl5.Margin = New Padding(7, 5, 7, 5)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 221)
            ULbl5.TabIndex = 1010
            ULbl5.XOLabelColor = CMCv.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.XOText = "Description"
            ULbl5.XOTextAdjuster = False
            ULbl5.XOTextBorder = False
            ' 
            ' FRMccinEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(899, 898)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMccinEditor"
            ShowIcon = False
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
    End Class
End Namespace