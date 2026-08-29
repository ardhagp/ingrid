Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdialogbox
        Inherits UI.Canvas.FRMstandardFooter

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
            PnlBottomButtonYesNo = New UI.Control.Pnl(components)
            PictureBox1 = New System.Windows.Forms.PictureBox()
            BtnYes = New UI.Control.Btn(components)
            BtnNo = New UI.Control.Btn(components)
            BtnCancel = New UI.Control.Btn(components)
            BtnOk = New UI.Control.Btn(components)
            PnlBottomButtonOkOnly = New UI.Control.Pnl(components)
            PictureBox2 = New System.Windows.Forms.PictureBox()
            BtnOkOnly = New UI.Control.Btn(components)
            TxtMessage = New UI.Control.Txt(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            PnlBottomButtonYesNo.SuspendLayout()
            CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            PnlBottomButtonOkOnly.SuspendLayout()
            CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnOk)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Location = New System.Drawing.Point(0, 284)
            PnlBottomButton.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            PnlBottomButton.Size = New System.Drawing.Size(1115, 96)
            PnlBottomButton.Visible = False
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnOk, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Size = New System.Drawing.Size(1115, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TxtMessage)
            SLFPanel.Controls.Add(PnlBottomButtonOkOnly)
            SLFPanel.Controls.Add(PnlBottomButtonYesNo)
            SLFPanel.Size = New System.Drawing.Size(1115, 476)
            SLFPanel.Controls.SetChildIndex(PnlBottomButtonYesNo, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButtonOkOnly, 0)
            SLFPanel.Controls.SetChildIndex(TxtMessage, 0)
            ' 
            ' PnlBottomButtonYesNo
            ' 
            PnlBottomButtonYesNo.BackColor = Drawing.Color.FromArgb(CByte(12), CByte(18), CByte(40))
            PnlBottomButtonYesNo.Controls.Add(PictureBox1)
            PnlBottomButtonYesNo.Controls.Add(BtnYes)
            PnlBottomButtonYesNo.Controls.Add(BtnNo)
            PnlBottomButtonYesNo.Dock = System.Windows.Forms.DockStyle.Bottom
            PnlBottomButtonYesNo.Location = New System.Drawing.Point(0, 380)
            PnlBottomButtonYesNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PnlBottomButtonYesNo.Name = "PnlBottomButtonYesNo"
            PnlBottomButtonYesNo.Size = New System.Drawing.Size(1115, 96)
            PnlBottomButtonYesNo.TabIndex = 1
            ' 
            ' PictureBox1
            ' 
            PictureBox1.BackColor = Drawing.Color.Red
            PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            PictureBox1.Location = New System.Drawing.Point(0, 0)
            PictureBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PictureBox1.Name = "PictureBox1"
            PictureBox1.Size = New System.Drawing.Size(1115, 8)
            PictureBox1.TabIndex = 1
            PictureBox1.TabStop = False
            ' 
            ' BtnYes
            ' 
            BtnYes.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnYes.BackColor = Drawing.Color.LimeGreen
            BtnYes.Cursor = System.Windows.Forms.Cursors.Hand
            BtnYes.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnYes.FlatAppearance.BorderSize = 2
            BtnYes.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnYes.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnYes.ForeColor = Drawing.Color.White
            BtnYes.Location = New System.Drawing.Point(752, 13)
            BtnYes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnYes.Name = "BtnYes"
            BtnYes.Size = New System.Drawing.Size(167, 77)
            BtnYes.TabIndex = 0
            BtnYes.Text = "&Yes"
            BtnYes.UseVisualStyleBackColor = False
            BtnYes.XOButtonType = UI.Control.ControlCodeBase.ButtonType.Yes
            BtnYes.XOShowBorderOnFocus = False
            BtnYes.XOValidateAllInput = False
            BtnYes.XOValidateAllInputTag = Nothing
            ' 
            ' BtnNo
            ' 
            BtnNo.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnNo.BackColor = Drawing.Color.Red
            BtnNo.Cursor = System.Windows.Forms.Cursors.Hand
            BtnNo.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnNo.FlatAppearance.BorderSize = 2
            BtnNo.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnNo.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnNo.ForeColor = Drawing.Color.White
            BtnNo.Location = New System.Drawing.Point(929, 13)
            BtnNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnNo.Name = "BtnNo"
            BtnNo.Size = New System.Drawing.Size(167, 77)
            BtnNo.TabIndex = 0
            BtnNo.Text = "&No"
            BtnNo.UseVisualStyleBackColor = False
            BtnNo.XOButtonType = UI.Control.ControlCodeBase.ButtonType.No
            BtnNo.XOShowBorderOnFocus = False
            BtnNo.XOValidateAllInput = False
            BtnNo.XOValidateAllInputTag = Nothing
            ' 
            ' BtnCancel
            ' 
            BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnCancel.BackColor = Drawing.Color.Red
            BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            BtnCancel.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnCancel.FlatAppearance.BorderSize = 2
            BtnCancel.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnCancel.ForeColor = Drawing.Color.White
            BtnCancel.Location = New System.Drawing.Point(929, 13)
            BtnCancel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New System.Drawing.Size(167, 77)
            BtnCancel.TabIndex = 0
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' BtnOk
            ' 
            BtnOk.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnOk.BackColor = Drawing.Color.LimeGreen
            BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
            BtnOk.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnOk.FlatAppearance.BorderSize = 2
            BtnOk.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnOk.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnOk.ForeColor = Drawing.Color.White
            BtnOk.Location = New System.Drawing.Point(752, 13)
            BtnOk.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnOk.Name = "BtnOk"
            BtnOk.Size = New System.Drawing.Size(167, 77)
            BtnOk.TabIndex = 0
            BtnOk.Text = "&Ok"
            BtnOk.UseVisualStyleBackColor = False
            BtnOk.XOButtonType = UI.Control.ControlCodeBase.ButtonType.Yes
            BtnOk.XOShowBorderOnFocus = False
            BtnOk.XOValidateAllInput = False
            BtnOk.XOValidateAllInputTag = Nothing
            ' 
            ' PnlBottomButtonOkOnly
            ' 
            PnlBottomButtonOkOnly.BackColor = Drawing.Color.FromArgb(CByte(12), CByte(18), CByte(40))
            PnlBottomButtonOkOnly.Controls.Add(PictureBox2)
            PnlBottomButtonOkOnly.Controls.Add(BtnOkOnly)
            PnlBottomButtonOkOnly.Dock = System.Windows.Forms.DockStyle.Bottom
            PnlBottomButtonOkOnly.Location = New System.Drawing.Point(0, 188)
            PnlBottomButtonOkOnly.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PnlBottomButtonOkOnly.Name = "PnlBottomButtonOkOnly"
            PnlBottomButtonOkOnly.Size = New System.Drawing.Size(1115, 96)
            PnlBottomButtonOkOnly.TabIndex = 3
            ' 
            ' PictureBox2
            ' 
            PictureBox2.BackColor = Drawing.Color.Red
            PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            PictureBox2.Location = New System.Drawing.Point(0, 0)
            PictureBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PictureBox2.Name = "PictureBox2"
            PictureBox2.Size = New System.Drawing.Size(1115, 8)
            PictureBox2.TabIndex = 1
            PictureBox2.TabStop = False
            ' 
            ' BtnOkOnly
            ' 
            BtnOkOnly.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnOkOnly.BackColor = Drawing.Color.RoyalBlue
            BtnOkOnly.Cursor = System.Windows.Forms.Cursors.Hand
            BtnOkOnly.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnOkOnly.FlatAppearance.BorderSize = 2
            BtnOkOnly.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnOkOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnOkOnly.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnOkOnly.ForeColor = Drawing.Color.White
            BtnOkOnly.Location = New System.Drawing.Point(929, 15)
            BtnOkOnly.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnOkOnly.Name = "BtnOkOnly"
            BtnOkOnly.Size = New System.Drawing.Size(167, 77)
            BtnOkOnly.TabIndex = 0
            BtnOkOnly.Text = "&Ok"
            BtnOkOnly.UseVisualStyleBackColor = False
            BtnOkOnly.XOButtonType = UI.Control.ControlCodeBase.ButtonType.Default
            BtnOkOnly.XOShowBorderOnFocus = False
            BtnOkOnly.XOValidateAllInput = False
            BtnOkOnly.XOValidateAllInputTag = Nothing
            ' 
            ' TxtMessage
            ' 
            TxtMessage.AcceptsReturn = True
            TxtMessage.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            TxtMessage.BackColor = Drawing.Color.FromArgb(CByte(11), CByte(28), CByte(45))
            TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
            TxtMessage.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            TxtMessage.ForeColor = Drawing.Color.White
            TxtMessage.Location = New System.Drawing.Point(20, 29)
            TxtMessage.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            TxtMessage.MaxLength = 255
            TxtMessage.Multiline = True
            TxtMessage.Name = "TxtMessage"
            TxtMessage.ReadOnly = True
            TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            TxtMessage.ShortcutsEnabled = False
            TxtMessage.Size = New System.Drawing.Size(1073, 330)
            TxtMessage.TabIndex = 5
            TxtMessage.TabStop = False
            TxtMessage.Tag = "txt"
            TxtMessage.XOAutoTrim = False
            TxtMessage.XOHighlightColor = Drawing.Color.LightYellow
            TxtMessage.XOHighlightOnFocus = False
            TxtMessage.XOIsBlank = True
            TxtMessage.XOIsMandatory = False
            TxtMessage.XOIsPlaceholder = False
            TxtMessage.XOIsReplaceEmptyString = False
            TxtMessage.XOLetterCase = UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtMessage.XOMandatoryBgColor = Drawing.Color.LightPink
            TxtMessage.XOMandatoryBgColorDefault = Drawing.Color.White
            TxtMessage.XOMandatoryMessage = Nothing
            TxtMessage.XOPasswordLengthMin = 8
            TxtMessage.XOPasswordStrengthCalc = False
            TxtMessage.XOPasswordStrengthScore = 0
            TxtMessage.XOPasswordStrengthText = Nothing
            TxtMessage.XOPlaceholderText = "Type then press Enter"
            TxtMessage.XORestriction = UI.Control.ControlCodeBase.EnumRestriction.None
            TxtMessage.XOSelectOnFocus = False
            TxtMessage.XOSqlText = ""
            ' 
            ' FRMdialogbox
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
            ClientSize = New System.Drawing.Size(1115, 608)
            ControlBox = False
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Margin = New System.Windows.Forms.Padding(22, 44, 22, 44)
            MaximizeBox = False
            MinimizeBox = False
            Name = "FRMdialogbox"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            PnlBottomButtonYesNo.ResumeLayout(False)
            CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
            PnlBottomButtonOkOnly.ResumeLayout(False)
            CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents PnlBottomButtonYesNo As UI.Control.Pnl
        Friend WithEvents BtnOk As UI.Control.Btn
        Friend WithEvents BtnCancel As UI.Control.Btn
        Friend WithEvents BtnYes As UI.Control.Btn
        Friend WithEvents BtnNo As UI.Control.Btn
        Friend WithEvents PnlBottomButtonOkOnly As UI.Control.Pnl
        Friend WithEvents BtnOkOnly As UI.Control.Btn
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents TxtMessage As UI.Control.Txt

    End Class
End Namespace