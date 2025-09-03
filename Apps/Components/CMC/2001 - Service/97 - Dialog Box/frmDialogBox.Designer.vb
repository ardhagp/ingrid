<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDialogBox
    Inherits CMCv.Std_Fo

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
        Me.components = New System.ComponentModel.Container()
        Me.PnlBottomButtonYesNo = New CMCv.pnl(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnYes = New CMCv.btn(Me.components)
        Me.BtnNo = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.BtnOk = New CMCv.btn(Me.components)
        Me.PnlBottomButtonOkOnly = New CMCv.pnl(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnOkOnly = New CMCv.btn(Me.components)
        Me.TxtMessage = New CMCv.txt(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.SLFBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBottomButtonYesNo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBottomButtonOkOnly.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnOk)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 140)
        Me.PnlBottomButton.Size = New System.Drawing.Size(669, 50)
        Me.PnlBottomButton.Visible = False
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnOk, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(669, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.TxtMessage)
        Me.SLFPanel.Controls.Add(Me.PnlBottomButtonOkOnly)
        Me.SLFPanel.Controls.Add(Me.PnlBottomButtonYesNo)
        Me.SLFPanel.Size = New System.Drawing.Size(669, 240)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButtonYesNo, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButtonOkOnly, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtMessage, 0)
        '
        'PnlBottomButtonYesNo
        '
        Me.PnlBottomButtonYesNo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PnlBottomButtonYesNo.Controls.Add(Me.PictureBox1)
        Me.PnlBottomButtonYesNo.Controls.Add(Me.BtnYes)
        Me.PnlBottomButtonYesNo.Controls.Add(Me.BtnNo)
        Me.PnlBottomButtonYesNo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottomButtonYesNo.Location = New System.Drawing.Point(0, 190)
        Me.PnlBottomButtonYesNo.Name = "PnlBottomButtonYesNo"
        Me.PnlBottomButtonYesNo.Size = New System.Drawing.Size(669, 50)
        Me.PnlBottomButtonYesNo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(669, 4)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnYes
        '
        Me.BtnYes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnYes.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnYes.FlatAppearance.BorderSize = 2
        Me.BtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnYes.ForeColor = System.Drawing.Color.White
        Me.BtnYes.Location = New System.Drawing.Point(451, 7)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(100, 40)
        Me.BtnYes.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnYes.XOTampilkanFocusBorder = False
        Me.BtnYes.XOValidasiSemuaInput = False
        Me.BtnYes.XOValidasiSemuaInputTag = Nothing
        Me.BtnYes.TabIndex = 0
        Me.BtnYes.Text = "&Yes"
        Me.BtnYes.UseVisualStyleBackColor = False
        '
        'BtnNo
        '
        Me.BtnNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNo.BackColor = System.Drawing.Color.Red
        Me.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNo.FlatAppearance.BorderSize = 2
        Me.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNo.ForeColor = System.Drawing.Color.White
        Me.BtnNo.Location = New System.Drawing.Point(557, 7)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(100, 40)
        Me.BtnNo.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnNo.XOTampilkanFocusBorder = False
        Me.BtnNo.XOValidasiSemuaInput = False
        Me.BtnNo.XOValidasiSemuaInputTag = Nothing
        Me.BtnNo.TabIndex = 0
        Me.BtnNo.Text = "&No"
        Me.BtnNo.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(557, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.XOTampilkanFocusBorder = False
        Me.BtnCancel.XOValidasiSemuaInput = False
        Me.BtnCancel.XOValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnOk.FlatAppearance.BorderSize = 2
        Me.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(451, 7)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(100, 40)
        Me.BtnOk.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnOk.XOTampilkanFocusBorder = False
        Me.BtnOk.XOValidasiSemuaInput = False
        Me.BtnOk.XOValidasiSemuaInputTag = Nothing
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'PnlBottomButtonOkOnly
        '
        Me.PnlBottomButtonOkOnly.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PnlBottomButtonOkOnly.Controls.Add(Me.PictureBox2)
        Me.PnlBottomButtonOkOnly.Controls.Add(Me.BtnOkOnly)
        Me.PnlBottomButtonOkOnly.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlBottomButtonOkOnly.Location = New System.Drawing.Point(0, 90)
        Me.PnlBottomButtonOkOnly.Name = "PnlBottomButtonOkOnly"
        Me.PnlBottomButtonOkOnly.Size = New System.Drawing.Size(669, 50)
        Me.PnlBottomButtonOkOnly.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(669, 4)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnOkOnly
        '
        Me.BtnOkOnly.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOkOnly.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnOkOnly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOkOnly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnOkOnly.FlatAppearance.BorderSize = 2
        Me.BtnOkOnly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnOkOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOkOnly.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOkOnly.ForeColor = System.Drawing.Color.White
        Me.BtnOkOnly.Location = New System.Drawing.Point(557, 8)
        Me.BtnOkOnly.Name = "BtnOkOnly"
        Me.BtnOkOnly.Size = New System.Drawing.Size(100, 40)
        Me.BtnOkOnly.XOJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnOkOnly.XOTampilkanFocusBorder = False
        Me.BtnOkOnly.XOValidasiSemuaInput = False
        Me.BtnOkOnly.XOValidasiSemuaInputTag = Nothing
        Me.BtnOkOnly.TabIndex = 0
        Me.BtnOkOnly.Text = "&Ok"
        Me.BtnOkOnly.UseVisualStyleBackColor = False
        '
        'TxtMessage
        '
        Me.TxtMessage.AcceptsReturn = True
        Me.TxtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMessage.BackColor = System.Drawing.SystemColors.Window
        Me.TxtMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtMessage.Location = New System.Drawing.Point(12, 15)
        Me.TxtMessage.MaxLength = 255
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ReadOnly = True
        Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMessage.ShortcutsEnabled = False
        Me.TxtMessage.Size = New System.Drawing.Size(645, 166)
        Me.TxtMessage.XOAutoTrim = False
        Me.TxtMessage.XOHarusDiisi = False
        Me.TxtMessage.XOHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtMessage.XOHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtMessage.XOHightlightSaatFokus = False
        Me.TxtMessage.XOHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtMessage.XOIsBlank = True
        Me.TxtMessage.XOIsSearchBox = False
        Me.TxtMessage.XOJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtMessage.XOPilihSemuaSaatFokus = False
        Me.TxtMessage.XOPwdLengthMin = 8
        Me.TxtMessage.XOPwdStrengthCalculate = False
        Me.TxtMessage.XOPwdStrengthScore = 0
        Me.TxtMessage.XOPwdStrengthText = Nothing
        Me.TxtMessage.XORestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtMessage.XOSearchBoxText = "Type then press Enter"
        Me.TxtMessage.XOSQLText = ""
        Me.TxtMessage.XOTanpaSpasi = False
        Me.TxtMessage.XOValidasiField = Nothing
        Me.TxtMessage.TabIndex = 5
        Me.TxtMessage.TabStop = False
        Me.TxtMessage.Tag = "txt"
        '
        'frmDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(669, 316)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDialogBox"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        CType(Me.SLFBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBottomButtonYesNo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBottomButtonOkOnly.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlBottomButtonYesNo As CMCv.pnl
    Friend WithEvents BtnOk As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnYes As CMCv.btn
    Friend WithEvents BtnNo As CMCv.btn
    Friend WithEvents PnlBottomButtonOkOnly As CMCv.pnl
    Friend WithEvents BtnOkOnly As CMCv.btn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtMessage As CMCv.txt

End Class
