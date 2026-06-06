Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMacbkEditor
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
            Cbo1 = New CMCv.UI.Control.Cbo(components)
            Txt1 = New CMCv.UI.Control.txt(components)
            Txt2 = New CMCv.UI.Control.txt(components)
            Txt3 = New CMCv.UI.Control.txt(components)
            Lbl1 = New CMCv.UI.Control.lbl(components)
            Lbl2 = New CMCv.UI.Control.lbl(components)
            Lbl3 = New CMCv.UI.Control.lbl(components)
            Lbl4 = New CMCv.UI.Control.lbl(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
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
            PnlBottomButton.Location = New Point(0, 537)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(826, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(826, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(Lbl4)
            SLFPanel.Controls.Add(Lbl3)
            SLFPanel.Controls.Add(Lbl2)
            SLFPanel.Controls.Add(Lbl1)
            SLFPanel.Controls.Add(Txt3)
            SLFPanel.Controls.Add(Txt2)
            SLFPanel.Controls.Add(Txt1)
            SLFPanel.Controls.Add(Cbo1)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(826, 634)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Cbo1, 0)
            SLFPanel.Controls.SetChildIndex(Txt1, 0)
            SLFPanel.Controls.SetChildIndex(Txt2, 0)
            SLFPanel.Controls.SetChildIndex(Txt3, 0)
            SLFPanel.Controls.SetChildIndex(Lbl1, 0)
            SLFPanel.Controls.SetChildIndex(Lbl2, 0)
            SLFPanel.Controls.SetChildIndex(Lbl3, 0)
            SLFPanel.Controls.SetChildIndex(Lbl4, 0)
            ' 
            ' Cbo1
            ' 
            Cbo1.DropDownStyle = ComboBoxStyle.DropDownList
            Cbo1.DropDownWidth = 350
            Cbo1.FlatStyle = FlatStyle.Flat
            Cbo1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Cbo1.FormattingEnabled = True
            Cbo1.Location = New Point(234, 20)
            Cbo1.Margin = New Padding(6, 5, 6, 5)
            Cbo1.Name = "Cbo1"
            Cbo1.Size = New Size(198, 40)
            Cbo1.TabIndex = 0
            ' 
            ' Txt1
            ' 
            Txt1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt1.Location = New Point(234, 87)
            Txt1.Margin = New Padding(6, 5, 6, 5)
            Txt1.MaxLength = 10
            Txt1.Name = "Txt1"
            Txt1.Size = New Size(198, 39)
            Txt1.TabIndex = 1
            Txt1.Tag = "txt"
            Txt1.TextAlign = HorizontalAlignment.Center
            Txt1.XOAutoTrim = True
            Txt1.XOIsMandatory = True
            Txt1.XOMandatoryBgColor = Color.LightPink
            Txt1.XOMandatoryBgColorDefault = Color.White
            Txt1.XOHighlightOnFocus = True
            Txt1.XOHighlightColor = Color.LightYellow
            Txt1.XOIsBlank = True
            Txt1.XOIsSearchBox = False
            Txt1.XOLetterCase = ControlCodeBase.enumLetterCase.UPPERCASE
            Txt1.XOSelectOnFocus = False
            Txt1.XOPasswordLengthMin = 8
            Txt1.XOPasswordStrengthCalc = False
            Txt1.XOPasswordStrengthScore = 0
            Txt1.XOPasswordStrengthText = Nothing
            Txt1.XORestriction = ControlCodeBase.enumRestriction.None
            Txt1.XOSearchBoxText = "Type then press Enter"
            Txt1.XOSqlText = ""
            Txt1.XOIsReplaceEmptyString = False
            Txt1.XOMandatoryMessage = Nothing
            ' 
            ' Txt2
            ' 
            Txt2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt2.Location = New Point(234, 153)
            Txt2.Margin = New Padding(6, 5, 6, 5)
            Txt2.MaxLength = 50
            Txt2.Name = "Txt2"
            Txt2.Size = New Size(567, 39)
            Txt2.TabIndex = 2
            Txt2.Tag = "txt"
            Txt2.XOAutoTrim = True
            Txt2.XOIsMandatory = True
            Txt2.XOMandatoryBgColor = Color.LightPink
            Txt2.XOMandatoryBgColorDefault = Color.White
            Txt2.XOHighlightOnFocus = True
            Txt2.XOHighlightColor = Color.LightYellow
            Txt2.XOIsBlank = True
            Txt2.XOIsSearchBox = False
            Txt2.XOLetterCase = ControlCodeBase.enumLetterCase.UPPERCASE
            Txt2.XOSelectOnFocus = False
            Txt2.XOPasswordLengthMin = 8
            Txt2.XOPasswordStrengthCalc = False
            Txt2.XOPasswordStrengthScore = 0
            Txt2.XOPasswordStrengthText = Nothing
            Txt2.XORestriction = ControlCodeBase.enumRestriction.None
            Txt2.XOSearchBoxText = "Type then press Enter"
            Txt2.XOSqlText = ""
            Txt2.XOIsReplaceEmptyString = False
            Txt2.XOMandatoryMessage = Nothing
            ' 
            ' Txt3
            ' 
            Txt3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt3.Location = New Point(234, 222)
            Txt3.Margin = New Padding(6, 5, 6, 5)
            Txt3.MaxLength = 255
            Txt3.Multiline = True
            Txt3.Name = "Txt3"
            Txt3.Size = New Size(567, 141)
            Txt3.TabIndex = 3
            Txt3.Tag = "txt"
            Txt3.XOAutoTrim = True
            Txt3.XOIsMandatory = False
            Txt3.XOMandatoryBgColor = Color.LightPink
            Txt3.XOMandatoryBgColorDefault = Color.White
            Txt3.XOHighlightOnFocus = True
            Txt3.XOHighlightColor = Color.LightYellow
            Txt3.XOIsBlank = True
            Txt3.XOIsSearchBox = False
            Txt3.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
            Txt3.XOSelectOnFocus = False
            Txt3.XOPasswordLengthMin = 8
            Txt3.XOPasswordStrengthCalc = False
            Txt3.XOPasswordStrengthScore = 0
            Txt3.XOPasswordStrengthText = Nothing
            Txt3.XORestriction = ControlCodeBase.enumRestriction.None
            Txt3.XOSearchBoxText = "Type then press Enter"
            Txt3.XOSqlText = ""
            Txt3.XOIsReplaceEmptyString = False
            Txt3.XOMandatoryMessage = Nothing
            ' 
            ' Lbl1
            ' 
            Lbl1.AutoSize = True
            Lbl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl1.Location = New Point(150, 25)
            Lbl1.Margin = New Padding(6, 0, 6, 0)
            Lbl1.Name = "Lbl1"
            Lbl1.Size = New Size(67, 32)
            Lbl1.TabIndex = 5
            Lbl1.Text = "Plant"
            Lbl1.XOCustomElipsis = False
            ' 
            ' Lbl2
            ' 
            Lbl2.AutoSize = True
            Lbl2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl2.Location = New Point(83, 92)
            Lbl2.Margin = New Padding(6, 0, 6, 0)
            Lbl2.Name = "Lbl2"
            Lbl2.Size = New Size(131, 32)
            Lbl2.TabIndex = 6
            Lbl2.Text = "Book Code"
            Lbl2.XOCustomElipsis = False
            ' 
            ' Lbl3
            ' 
            Lbl3.AutoSize = True
            Lbl3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl3.Location = New Point(73, 160)
            Lbl3.Margin = New Padding(6, 0, 6, 0)
            Lbl3.Name = "Lbl3"
            Lbl3.Size = New Size(139, 32)
            Lbl3.TabIndex = 7
            Lbl3.Text = "Book Name"
            Lbl3.XOCustomElipsis = False
            ' 
            ' Lbl4
            ' 
            Lbl4.AutoSize = True
            Lbl4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl4.Location = New Point(77, 227)
            Lbl4.Margin = New Padding(6, 0, 6, 0)
            Lbl4.Name = "Lbl4"
            Lbl4.Size = New Size(135, 32)
            Lbl4.TabIndex = 8
            Lbl4.Text = "Description"
            Lbl4.XOCustomElipsis = False
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
            BtnSave.Location = New Point(462, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 4
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
            BtnCancel.Location = New Point(639, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 5
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
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
            ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(231, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 6
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' FRMacbkEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(826, 760)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMacbkEditor"
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
        Friend WithEvents Cbo1 As CMCv.UI.Control.Cbo
        Friend WithEvents Txt1 As CMCv.UI.Control.txt
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl2 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
        Friend WithEvents Txt3 As CMCv.UI.Control.txt
        Friend WithEvents Txt2 As CMCv.UI.Control.txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk

    End Class
End Namespace