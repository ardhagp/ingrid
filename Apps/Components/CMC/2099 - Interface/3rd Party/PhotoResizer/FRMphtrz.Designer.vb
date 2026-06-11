Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMphtrz
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMphtrz))
            BtnClose = New CMCv.UI.Control.Btn(components)
            BtnSave = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            TlpMain = New System.Windows.Forms.TableLayoutPanel()
            PnlLoad = New CMCv.UI.Control.pnl(components)
            Lbl1 = New CMCv.UI.Control.lbl(components)
            TxtLoad = New CMCv.UI.Control.txt(components)
            BtnLoad = New CMCv.UI.Control.Btn(components)
            PnlSave = New CMCv.UI.Control.pnl(components)
            ChkSaveAsACopy = New CMCv.UI.Control.Chk(components)
            TxtSave = New CMCv.UI.Control.txt(components)
            Lbl2 = New CMCv.UI.Control.lbl(components)
            PctbxPhoto = New CMCv.UI.Control.Pbx(components)
            OfdLoad = New System.Windows.Forms.OpenFileDialog()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            TlpMain.SuspendLayout()
            PnlLoad.SuspendLayout()
            PnlSave.SuspendLayout()
            CType(PctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Controls.Add(BtnClose)
            PnlBottomButton.Location = New System.Drawing.Point(0, 618)
            PnlBottomButton.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            PnlBottomButton.Size = New System.Drawing.Size(1095, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' SLFLogo
            ' 
            SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Drawing.Image)
            SLFLogo.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            SLFLogo.Size = New System.Drawing.Size(122, 163)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            pnl_.Size = New System.Drawing.Size(1095, 185)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TlpMain)
            SLFPanel.Location = New System.Drawing.Point(0, 185)
            SLFPanel.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            SLFPanel.Size = New System.Drawing.Size(1095, 714)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TlpMain, 0)
            ' 
            ' BtnClose
            ' 
            BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnClose.BackColor = Drawing.Color.Red
            BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
            BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClose.FlatAppearance.BorderSize = 2
            BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
            BtnClose.ForeColor = Drawing.Color.White
            BtnClose.Location = New System.Drawing.Point(909, 12)
            BtnClose.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New System.Drawing.Size(167, 77)
            BtnClose.TabIndex = 7
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
            ' 
            ' BtnSave
            ' 
            BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnSave.BackColor = Drawing.Color.LimeGreen
            BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
            BtnSave.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnSave.FlatAppearance.BorderSize = 2
            BtnSave.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
            BtnSave.ForeColor = Drawing.Color.White
            BtnSave.Location = New System.Drawing.Point(732, 12)
            BtnSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New System.Drawing.Size(167, 77)
            BtnSave.TabIndex = 5
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.Yes
            BtnSave.XOShowBorderOnFocus = False
            BtnSave.XOValidateAllInput = False
            BtnSave.XOValidateAllInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Drawing.Color.Transparent
            ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            ChkAddNew.ForeColor = Drawing.Color.OrangeRed
            ChkAddNew.Location = New System.Drawing.Point(460, 27)
            ChkAddNew.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New System.Drawing.Size(262, 36)
            ChkAddNew.TabIndex = 6
            ChkAddNew.Text = "Resize another photo"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' TlpMain
            ' 
            TlpMain.ColumnCount = 1
            TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            TlpMain.Controls.Add(PnlLoad, 0, 0)
            TlpMain.Controls.Add(PnlSave, 0, 2)
            TlpMain.Controls.Add(PctbxPhoto, 0, 1)
            TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
            TlpMain.Location = New System.Drawing.Point(0, 0)
            TlpMain.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            TlpMain.Name = "TlpMain"
            TlpMain.RowCount = 3
            TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108.0F))
            TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108.0F))
            TlpMain.Size = New System.Drawing.Size(1095, 618)
            TlpMain.TabIndex = 996
            ' 
            ' PnlLoad
            ' 
            PnlLoad.Controls.Add(Lbl1)
            PnlLoad.Controls.Add(TxtLoad)
            PnlLoad.Controls.Add(BtnLoad)
            PnlLoad.Dock = System.Windows.Forms.DockStyle.Fill
            PnlLoad.Location = New System.Drawing.Point(5, 6)
            PnlLoad.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PnlLoad.Name = "PnlLoad"
            PnlLoad.Size = New System.Drawing.Size(1085, 96)
            PnlLoad.TabIndex = 0
            ' 
            ' Lbl1
            ' 
            Lbl1.AutoSize = True
            Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            Lbl1.Location = New System.Drawing.Point(15, 29)
            Lbl1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Lbl1.Name = "Lbl1"
            Lbl1.Size = New System.Drawing.Size(178, 32)
            Lbl1.TabIndex = 2
            Lbl1.Text = "Original Picture"
            Lbl1.XOCustomElipsis = False
            ' 
            ' TxtLoad
            ' 
            TxtLoad.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            TxtLoad.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            TxtLoad.Location = New System.Drawing.Point(222, 23)
            TxtLoad.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            TxtLoad.MaxLength = 255
            TxtLoad.Name = "TxtLoad"
            TxtLoad.ReadOnly = True
            TxtLoad.Size = New System.Drawing.Size(669, 39)
            TxtLoad.TabIndex = 1
            TxtLoad.Tag = "txt"
            TxtLoad.XOAutoTrim = False
            TxtLoad.XOIsMandatory = False
            TxtLoad.XOMandatoryBgColor = Drawing.Color.LightPink
            TxtLoad.XOMandatoryBgColorDefault = Drawing.Color.White
            TxtLoad.XOHighlightOnFocus = False
            TxtLoad.XOHighlightColor = Drawing.Color.LightYellow
            TxtLoad.XOIsBlank = True
            TxtLoad.XOIsPlaceholder = False
            TxtLoad.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.Normal
            TxtLoad.XOSelectOnFocus = False
            TxtLoad.XOPasswordLengthMin = 8
            TxtLoad.XOPasswordStrengthCalc = False
            TxtLoad.XOPasswordStrengthScore = 0
            TxtLoad.XOPasswordStrengthText = Nothing
            TxtLoad.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtLoad.XOPlaceholderText = "Type then press Enter"
            TxtLoad.XOSqlText = ""
            TxtLoad.XOIsReplaceEmptyString = False
            TxtLoad.XOMandatoryMessage = Nothing
            ' 
            ' BtnLoad
            ' 
            BtnLoad.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnLoad.BackColor = Drawing.Color.RoyalBlue
            BtnLoad.Cursor = System.Windows.Forms.Cursors.Hand
            BtnLoad.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(5), CByte(45), CByte(165))
            BtnLoad.FlatAppearance.BorderSize = 2
            BtnLoad.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(85), CByte(125), CByte(245))
            BtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnLoad.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
            BtnLoad.ForeColor = Drawing.Color.White
            BtnLoad.Location = New System.Drawing.Point(904, 10)
            BtnLoad.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            BtnLoad.Name = "BtnLoad"
            BtnLoad.Size = New System.Drawing.Size(167, 77)
            BtnLoad.TabIndex = 0
            BtnLoad.Text = "&Load"
            BtnLoad.UseVisualStyleBackColor = False
            BtnLoad.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.Default
            BtnLoad.XOShowBorderOnFocus = False
            BtnLoad.XOValidateAllInput = False
            BtnLoad.XOValidateAllInputTag = Nothing
            ' 
            ' PnlSave
            ' 
            PnlSave.Controls.Add(ChkSaveAsACopy)
            PnlSave.Controls.Add(TxtSave)
            PnlSave.Controls.Add(Lbl2)
            PnlSave.Dock = System.Windows.Forms.DockStyle.Fill
            PnlSave.Location = New System.Drawing.Point(5, 516)
            PnlSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PnlSave.Name = "PnlSave"
            PnlSave.Size = New System.Drawing.Size(1085, 96)
            PnlSave.TabIndex = 1
            ' 
            ' ChkSaveAsACopy
            ' 
            ChkSaveAsACopy.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            ChkSaveAsACopy.AutoSize = True
            ChkSaveAsACopy.BackColor = Drawing.Color.Transparent
            ChkSaveAsACopy.Enabled = False
            ChkSaveAsACopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            ChkSaveAsACopy.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            ChkSaveAsACopy.Location = New System.Drawing.Point(920, 25)
            ChkSaveAsACopy.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            ChkSaveAsACopy.Name = "ChkSaveAsACopy"
            ChkSaveAsACopy.Size = New System.Drawing.Size(137, 36)
            ChkSaveAsACopy.TabIndex = 2
            ChkSaveAsACopy.TabStop = False
            ChkSaveAsACopy.Text = "As a copy"
            ChkSaveAsACopy.UseVisualStyleBackColor = False
            ' 
            ' TxtSave
            ' 
            TxtSave.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            TxtSave.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            TxtSave.Location = New System.Drawing.Point(220, 23)
            TxtSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            TxtSave.MaxLength = 255
            TxtSave.Name = "TxtSave"
            TxtSave.Size = New System.Drawing.Size(671, 39)
            TxtSave.TabIndex = 4
            TxtSave.Tag = "txt"
            TxtSave.XOAutoTrim = False
            TxtSave.XOIsMandatory = False
            TxtSave.XOMandatoryBgColor = Drawing.Color.LightPink
            TxtSave.XOMandatoryBgColorDefault = Drawing.Color.White
            TxtSave.XOHighlightOnFocus = False
            TxtSave.XOHighlightColor = Drawing.Color.LightYellow
            TxtSave.XOIsBlank = True
            TxtSave.XOIsPlaceholder = False
            TxtSave.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.Normal
            TxtSave.XOSelectOnFocus = False
            TxtSave.XOPasswordLengthMin = 8
            TxtSave.XOPasswordStrengthCalc = False
            TxtSave.XOPasswordStrengthScore = 0
            TxtSave.XOPasswordStrengthText = Nothing
            TxtSave.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
            TxtSave.XOPlaceholderText = "Type then press Enter"
            TxtSave.XOSqlText = ""
            TxtSave.XOIsReplaceEmptyString = False
            TxtSave.XOMandatoryMessage = Nothing
            ' 
            ' Lbl2
            ' 
            Lbl2.AutoSize = True
            Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
            Lbl2.Location = New System.Drawing.Point(107, 29)
            Lbl2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            Lbl2.Name = "Lbl2"
            Lbl2.Size = New System.Drawing.Size(96, 32)
            Lbl2.TabIndex = 0
            Lbl2.Text = "Save To"
            Lbl2.XOCustomElipsis = False
            ' 
            ' PctbxPhoto
            ' 
            PctbxPhoto.BackColor = Drawing.Color.Transparent
            PctbxPhoto.BackgroundImage = CType(resources.GetObject("PctbxPhoto.BackgroundImage"), Drawing.Image)
            PctbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            PctbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill
            PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), Drawing.Image)
            PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), Drawing.Image)
            PctbxPhoto.Location = New System.Drawing.Point(5, 114)
            PctbxPhoto.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PctbxPhoto.Name = "PctbxPhoto"
            PctbxPhoto.Size = New System.Drawing.Size(1085, 390)
            PctbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            PctbxPhoto.TabIndex = 2
            PctbxPhoto.TabStop = False
            PctbxPhoto.XOShowBorder = False
            PctbxPhoto.XOBorderColor = Drawing.Color.DodgerBlue
            ' 
            ' OfdLoad
            ' 
            OfdLoad.FileName = "OpenFileDialog1"
            ' 
            ' FRMphtrz
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
            ClientSize = New System.Drawing.Size(1095, 921)
            KeyPreview = True
            Margin = New System.Windows.Forms.Padding(22, 44, 22, 44)
            Name = "FRMphtrz"
            WindowState = System.Windows.Forms.FormWindowState.Maximized
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            TlpMain.ResumeLayout(False)
            PnlLoad.ResumeLayout(False)
            PnlLoad.PerformLayout()
            PnlSave.ResumeLayout(False)
            PnlSave.PerformLayout()
            CType(PctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend WithEvents BtnClose As CMCv.UI.Control.Btn
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents TlpMain As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PnlLoad As CMCv.UI.Control.pnl
        Friend WithEvents PnlSave As CMCv.UI.Control.pnl
        Friend WithEvents PctbxPhoto As CMCv.UI.Control.Pbx
        Friend WithEvents BtnLoad As CMCv.UI.Control.Btn
        Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
        Friend WithEvents TxtLoad As CMCv.UI.Control.txt
        Friend WithEvents TxtSave As CMCv.UI.Control.txt
        Friend WithEvents Lbl2 As CMCv.UI.Control.lbl
        Friend WithEvents OfdLoad As System.Windows.Forms.OpenFileDialog
        Friend WithEvents ChkSaveAsACopy As CMCv.UI.Control.Chk
    End Class
End Namespace