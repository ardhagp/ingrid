<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMdialogbox
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
        PnlBottomButtonYesNo = New CMCv.UI.Control.pnl(components)
        PictureBox1 = New System.Windows.Forms.PictureBox()
        BtnYes = New CMCv.UI.Control.btn(components)
        BtnNo = New CMCv.UI.Control.btn(components)
        BtnCancel = New CMCv.UI.Control.btn(components)
        BtnOk = New CMCv.UI.Control.btn(components)
        PnlBottomButtonOkOnly = New CMCv.UI.Control.pnl(components)
        PictureBox2 = New System.Windows.Forms.PictureBox()
        BtnOkOnly = New CMCv.UI.Control.btn(components)
        TxtMessage = New CMCv.UI.Control.txt(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
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
        PnlBottomButtonYesNo.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButtonYesNo.Controls.Add(PictureBox1)
        PnlBottomButtonYesNo.Controls.Add(BtnYes)
        PnlBottomButtonYesNo.Controls.Add(BtnNo)
        PnlBottomButtonYesNo.Dock = system.Windows.Forms.DockStyle.Bottom
        PnlBottomButtonYesNo.Location = New System.Drawing.Point(0, 380)
        PnlBottomButtonYesNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PnlBottomButtonYesNo.Name = "PnlBottomButtonYesNo"
        PnlBottomButtonYesNo.Size = New System.Drawing.Size(1115, 96)
        PnlBottomButtonYesNo.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Drawing.Color.Red
        PictureBox1.Dock = system.Windows.Forms.DockStyle.Top
        PictureBox1.Location = New System.Drawing.Point(0, 0)
        PictureBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(1115, 8)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' BtnYes
        ' 
        BtnYes.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
        BtnYes.BackColor = Drawing.Color.LimeGreen
        BtnYes.Cursor = system.Windows.Forms.Cursors.Hand
        BtnYes.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnYes.FlatAppearance.BorderSize = 2
        BtnYes.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnYes.FlatStyle = system.Windows.Forms.FlatStyle.Flat
        BtnYes.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnYes.ForeColor = Drawing.Color.White
        BtnYes.Location = New System.Drawing.Point(752, 13)
        BtnYes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnYes.Name = "BtnYes"
        BtnYes.Size = New System.Drawing.Size(167, 77)
        BtnYes.TabIndex = 0
        BtnYes.Text = "&Yes"
        BtnYes.UseVisualStyleBackColor = False
        BtnYes.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnYes.XOTampilkanFocusBorder = False
        BtnYes.XOValidasiSemuaInput = False
        BtnYes.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnNo
        ' 
        BtnNo.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
        BtnNo.BackColor = Drawing.Color.Red
        BtnNo.Cursor = system.Windows.Forms.Cursors.Hand
        BtnNo.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnNo.FlatAppearance.BorderSize = 2
        BtnNo.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnNo.FlatStyle = system.Windows.Forms.FlatStyle.Flat
        BtnNo.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnNo.ForeColor = Drawing.Color.White
        BtnNo.Location = New System.Drawing.Point(929, 13)
        BtnNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnNo.Name = "BtnNo"
        BtnNo.Size = New System.Drawing.Size(167, 77)
        BtnNo.TabIndex = 0
        BtnNo.Text = "&No"
        BtnNo.UseVisualStyleBackColor = False
        BtnNo.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnNo.XOTampilkanFocusBorder = False
        BtnNo.XOValidasiSemuaInput = False
        BtnNo.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
        BtnCancel.BackColor = Drawing.Color.Red
        BtnCancel.Cursor = system.Windows.Forms.Cursors.Hand
        BtnCancel.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnCancel.FlatAppearance.BorderSize = 2
        BtnCancel.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnCancel.FlatStyle = system.Windows.Forms.FlatStyle.Flat
        BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnCancel.ForeColor = Drawing.Color.White
        BtnCancel.Location = New System.Drawing.Point(929, 13)
        BtnCancel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New System.Drawing.Size(167, 77)
        BtnCancel.TabIndex = 0
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnOk
        ' 
        BtnOk.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
        BtnOk.BackColor = Drawing.Color.LimeGreen
        BtnOk.Cursor = system.Windows.Forms.Cursors.Hand
        BtnOk.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnOk.FlatAppearance.BorderSize = 2
        BtnOk.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnOk.FlatStyle = system.Windows.Forms.FlatStyle.Flat
        BtnOk.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnOk.ForeColor = Drawing.Color.White
        BtnOk.Location = New System.Drawing.Point(752, 13)
        BtnOk.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New System.Drawing.Size(167, 77)
        BtnOk.TabIndex = 0
        BtnOk.Text = "&Ok"
        BtnOk.UseVisualStyleBackColor = False
        BtnOk.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnOk.XOTampilkanFocusBorder = False
        BtnOk.XOValidasiSemuaInput = False
        BtnOk.XOValidasiSemuaInputTag = Nothing
        ' 
        ' PnlBottomButtonOkOnly
        ' 
        PnlBottomButtonOkOnly.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButtonOkOnly.Controls.Add(PictureBox2)
        PnlBottomButtonOkOnly.Controls.Add(BtnOkOnly)
        PnlBottomButtonOkOnly.Dock = system.Windows.Forms.DockStyle.Bottom
        PnlBottomButtonOkOnly.Location = New System.Drawing.Point(0, 188)
        PnlBottomButtonOkOnly.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PnlBottomButtonOkOnly.Name = "PnlBottomButtonOkOnly"
        PnlBottomButtonOkOnly.Size = New System.Drawing.Size(1115, 96)
        PnlBottomButtonOkOnly.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Drawing.Color.Red
        PictureBox2.Dock = system.Windows.Forms.DockStyle.Top
        PictureBox2.Location = New System.Drawing.Point(0, 0)
        PictureBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(1115, 8)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' BtnOkOnly
        ' 
        BtnOkOnly.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
        BtnOkOnly.BackColor = Drawing.Color.RoyalBlue
        BtnOkOnly.Cursor = system.Windows.Forms.Cursors.Hand
        BtnOkOnly.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnOkOnly.FlatAppearance.BorderSize = 2
        BtnOkOnly.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnOkOnly.FlatStyle = system.Windows.Forms.FlatStyle.Flat
        BtnOkOnly.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnOkOnly.ForeColor = Drawing.Color.White
        BtnOkOnly.Location = New System.Drawing.Point(929, 15)
        BtnOkOnly.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnOkOnly.Name = "BtnOkOnly"
        BtnOkOnly.Size = New System.Drawing.Size(167, 77)
        BtnOkOnly.TabIndex = 0
        BtnOkOnly.Text = "&Ok"
        BtnOkOnly.UseVisualStyleBackColor = False
        BtnOkOnly.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnOkOnly.XOTampilkanFocusBorder = False
        BtnOkOnly.XOValidasiSemuaInput = False
        BtnOkOnly.XOValidasiSemuaInputTag = Nothing
        ' 
        ' TxtMessage
        ' 
        TxtMessage.AcceptsReturn = True
        TxtMessage.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left Or system.Windows.Forms.AnchorStyles.Right
        TxtMessage.BackColor = Drawing.SystemColors.Window
        TxtMessage.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtMessage.Location = New System.Drawing.Point(20, 29)
        TxtMessage.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        TxtMessage.MaxLength = 255
        TxtMessage.Multiline = True
        TxtMessage.Name = "TxtMessage"
        TxtMessage.ReadOnly = True
        TxtMessage.ScrollBars = system.Windows.Forms.ScrollBars.Vertical
        TxtMessage.ShortcutsEnabled = False
        TxtMessage.Size = New System.Drawing.Size(1073, 330)
        TxtMessage.TabIndex = 5
        TxtMessage.TabStop = False
        TxtMessage.Tag = "txt"
        TxtMessage.XOAutoTrim = False
        TxtMessage.XOHarusDiisi = False
        TxtMessage.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtMessage.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtMessage.XOHightlightSaatFokus = False
        TxtMessage.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtMessage.XOIsBlank = True
        TxtMessage.XOIsSearchBox = False
        TxtMessage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtMessage.XOPilihSemuaSaatFokus = False
        TxtMessage.XOPwdLengthMin = 8
        TxtMessage.XOPwdStrengthCalculate = False
        TxtMessage.XOPwdStrengthScore = 0
        TxtMessage.XOPwdStrengthText = Nothing
        TxtMessage.XORestriction = ControlCodeBase.enuRestriction.None
        TxtMessage.XOSearchBoxText = "Type then press Enter"
        TxtMessage.XOSQLText = ""
        TxtMessage.XOTanpaSpasi = False
        TxtMessage.XOValidasiField = Nothing
        ' 
        ' FRMdialogbox
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
        ClientSize = New System.Drawing.Size(1115, 608)
        ControlBox = False
        FormBorderStyle = system.Windows.Forms.FormBorderStyle.FixedDialog
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
        PnlBottomButtonYesNo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlBottomButtonOkOnly.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PnlBottomButtonYesNo As CMCv.UI.Control.pnl
    Friend WithEvents BtnOk As CMCv.UI.Control.btn
    Friend WithEvents BtnCancel As CMCv.UI.Control.btn
    Friend WithEvents BtnYes As CMCv.UI.Control.btn
    Friend WithEvents BtnNo As CMCv.UI.Control.btn
    Friend WithEvents PnlBottomButtonOkOnly As CMCv.UI.Control.pnl
    Friend WithEvents BtnOkOnly As CMCv.UI.Control.btn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtMessage As CMCv.UI.Control.txt

End Class
