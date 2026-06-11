Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMcdinEditor
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
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            TxtDeptCode = New CMCv.UI.Control.txt(components)
            CboCompany = New CMCv.UI.Control.cbo(components)
            TxtDeptName = New CMCv.UI.Control.txt(components)
            TxtDescription = New CMCv.UI.Control.txt(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Location = New Point(0, 451)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(873, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(873, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtDescription)
            SLFPanel.Controls.Add(TxtDeptName)
            SLFPanel.Controls.Add(CboCompany)
            SLFPanel.Controls.Add(TxtDeptCode)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(873, 548)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TxtDeptCode, 0)
            SLFPanel.Controls.SetChildIndex(CboCompany, 0)
            SLFPanel.Controls.SetChildIndex(TxtDeptName, 0)
            SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
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
            BtnSave.Location = New Point(509, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 4
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = CMCV.UI.Control.ControlCodeBase.ButtonType.Yes
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
            BtnCancel.Location = New Point(686, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 6
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCV.UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' TxtDeptCode
            ' 
            TxtDeptCode.Font = New Font("Segoe UI", 12F)
            TxtDeptCode.Location = New Point(280, 87)
            TxtDeptCode.Margin = New Padding(6, 5, 6, 5)
            TxtDeptCode.MaxLength = 255
            TxtDeptCode.Name = "TxtDeptCode"
            TxtDeptCode.Size = New Size(341, 39)
            TxtDeptCode.TabIndex = 1
            TxtDeptCode.Tag = "txt"
            TxtDeptCode.XOAutoTrim = True
            TxtDeptCode.XOHighlightColor = Color.LightYellow
            TxtDeptCode.XOHighlightOnFocus = True
            TxtDeptCode.XOIsBlank = True
            TxtDeptCode.XOIsMandatory = True
            TxtDeptCode.XOIsReplaceEmptyString = False
            TxtDeptCode.XOIsPlaceholder = False
            TxtDeptCode.XOLetterCase = CMCV.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtDeptCode.XOMandatoryBgColor = Color.LightPink
            TxtDeptCode.XOMandatoryBgColorDefault = Color.White
            TxtDeptCode.XOMandatoryMessage = Nothing
            TxtDeptCode.XOPasswordLengthMin = 8
            TxtDeptCode.XOPasswordStrengthCalc = False
            TxtDeptCode.XOPasswordStrengthScore = 0
            TxtDeptCode.XOPasswordStrengthText = Nothing
            TxtDeptCode.XORestriction = CMCV.UI.Control.ControlCodeBase.EnumRestriction.TextAndNumber
            TxtDeptCode.XOPlaceholderText = "Type then press Enter"
            TxtDeptCode.XOSelectOnFocus = True
            TxtDeptCode.XOSqlText = ""
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
            ' TxtDeptName
            ' 
            TxtDeptName.Font = New Font("Segoe UI", 12F)
            TxtDeptName.Location = New Point(280, 153)
            TxtDeptName.Margin = New Padding(6, 5, 6, 5)
            TxtDeptName.MaxLength = 255
            TxtDeptName.Name = "TxtDeptName"
            TxtDeptName.Size = New Size(341, 39)
            TxtDeptName.TabIndex = 2
            TxtDeptName.Tag = "txt"
            TxtDeptName.XOAutoTrim = True
            TxtDeptName.XOHighlightColor = Color.LightYellow
            TxtDeptName.XOHighlightOnFocus = True
            TxtDeptName.XOIsBlank = True
            TxtDeptName.XOIsMandatory = True
            TxtDeptName.XOIsReplaceEmptyString = False
            TxtDeptName.XOIsPlaceholder = False
            TxtDeptName.XOLetterCase = CMCV.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtDeptName.XOMandatoryBgColor = Color.LightPink
            TxtDeptName.XOMandatoryBgColorDefault = Color.White
            TxtDeptName.XOMandatoryMessage = Nothing
            TxtDeptName.XOPasswordLengthMin = 8
            TxtDeptName.XOPasswordStrengthCalc = False
            TxtDeptName.XOPasswordStrengthScore = 0
            TxtDeptName.XOPasswordStrengthText = Nothing
            TxtDeptName.XORestriction = CMCV.UI.Control.ControlCodeBase.EnumRestriction.TextAndNumber
            TxtDeptName.XOPlaceholderText = "Type then press Enter"
            TxtDeptName.XOSelectOnFocus = False
            TxtDeptName.XOSqlText = ""
            ' 
            ' TxtDescription
            ' 
            TxtDescription.Font = New Font("Segoe UI", 12F)
            TxtDescription.Location = New Point(280, 222)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Multiline = True
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(573, 184)
            TxtDescription.TabIndex = 3
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = False
            TxtDescription.XOHighlightColor = Color.LightYellow
            TxtDescription.XOHighlightOnFocus = True
            TxtDescription.XOIsBlank = True
            TxtDescription.XOIsMandatory = False
            TxtDescription.XOIsReplaceEmptyString = False
            TxtDescription.XOIsPlaceholder = False
            TxtDescription.XOLetterCase = CMCV.UI.Control.ControlCodeBase.EnumLetterCase.UPPERCASE
            TxtDescription.XOMandatoryBgColor = Color.LightPink
            TxtDescription.XOMandatoryBgColorDefault = Color.White
            TxtDescription.XOMandatoryMessage = Nothing
            TxtDescription.XOPasswordLengthMin = 8
            TxtDescription.XOPasswordStrengthCalc = False
            TxtDescription.XOPasswordStrengthScore = 0
            TxtDescription.XOPasswordStrengthText = Nothing
            TxtDescription.XORestriction = CMCV.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtDescription.XOPlaceholderText = "Type then press Enter"
            TxtDescription.XOSelectOnFocus = False
            TxtDescription.XOSqlText = ""
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(20, 20)
            ULbl1.Margin = New Padding(7, 5, 7, 5)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 39)
            ULbl1.TabIndex = 1004
            ULbl1.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
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
            ULbl2.Size = New Size(250, 39)
            ULbl2.TabIndex = 1005
            ULbl2.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.XOText = "Dept. Code"
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
            ULbl3.TabIndex = 1006
            ULbl3.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.XOText = "Dept. Name"
            ULbl3.XOTextAdjuster = False
            ULbl3.XOTextBorder = False
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 222)
            ULbl4.Margin = New Padding(7, 5, 7, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 184)
            ULbl4.TabIndex = 1007
            ULbl4.XOLabelColor = CMCV.UI.Control.ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.XOText = "Description"
            ULbl4.XOTextAdjuster = False
            ULbl4.XOTextBorder = False
            ' 
            ' FRMcdinEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(873, 680)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMcdinEditor"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents TxtDeptName As CMCv.UI.Control.txt
        Friend WithEvents CboCompany As CMCv.UI.Control.Cbo
        Friend WithEvents TxtDeptCode As CMCv.UI.Control.txt
        Friend WithEvents TxtDescription As CMCv.UI.Control.txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
    End Class
End Namespace