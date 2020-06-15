<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountGroup_Editor
    Inherits CMCv.frmStandardPlusButtonContainer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.CboPlant = New CMCv.cbo(Me.components)
        Me.CboAccountingBook = New CMCv.cbo(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.CboAccountGroup = New CMCv.cbo(Me.components)
        Me.Lbl3 = New CMCv.lbl(Me.components)
        Me.TxtAccountNumber = New CMCv.txt(Me.components)
        Me.Lbl4 = New CMCv.lbl(Me.components)
        Me.TxtAccountName = New CMCv.txt(Me.components)
        Me.Lbl5 = New CMCv.lbl(Me.components)
        Me.ChkEnable = New CMCv.chk(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 214)
        Me.PnlBottomButton.Size = New System.Drawing.Size(550, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(0, 23)
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Size = New System.Drawing.Size(0, 46)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(550, 96)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ChkEnable)
        Me.SLFPanel.Controls.Add(Me.Lbl5)
        Me.SLFPanel.Controls.Add(Me.TxtAccountName)
        Me.SLFPanel.Controls.Add(Me.Lbl4)
        Me.SLFPanel.Controls.Add(Me.TxtAccountNumber)
        Me.SLFPanel.Controls.Add(Me.Lbl3)
        Me.SLFPanel.Controls.Add(Me.CboAccountGroup)
        Me.SLFPanel.Controls.Add(Me.Lbl2)
        Me.SLFPanel.Controls.Add(Me.Lbl1)
        Me.SLFPanel.Controls.Add(Me.CboAccountingBook)
        Me.SLFPanel.Controls.Add(Me.CboPlant)
        Me.SLFPanel.Size = New System.Drawing.Size(550, 264)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboPlant, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboAccountingBook, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboAccountGroup, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtAccountNumber, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl4, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtAccountName, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl5, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ChkEnable, 0)
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(332, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(438, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'CboPlant
        '
        Me.CboPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPlant.DropDownWidth = 350
        Me.CboPlant.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboPlant.FormattingEnabled = True
        Me.CboPlant.Location = New System.Drawing.Point(141, 10)
        Me.CboPlant.Name = "CboPlant"
        Me.CboPlant.Size = New System.Drawing.Size(282, 29)
        Me.CboPlant.TabIndex = 0
        '
        'CboAccountingBook
        '
        Me.CboAccountingBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAccountingBook.DropDownWidth = 350
        Me.CboAccountingBook.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboAccountingBook.FormattingEnabled = True
        Me.CboAccountingBook.Location = New System.Drawing.Point(141, 45)
        Me.CboAccountingBook.Name = "CboAccountingBook"
        Me.CboAccountingBook.Size = New System.Drawing.Size(282, 29)
        Me.CboAccountingBook.TabIndex = 1
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(90, 13)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(45, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 3
        Me.Lbl1.Text = "Plant"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl2.Location = New System.Drawing.Point(8, 48)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(127, 21)
        Me.Lbl2.SLFCustomElipsis = False
        Me.Lbl2.TabIndex = 4
        Me.Lbl2.Text = "Accounting Book"
        '
        'CboAccountGroup
        '
        Me.CboAccountGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAccountGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboAccountGroup.FormattingEnabled = True
        Me.CboAccountGroup.Location = New System.Drawing.Point(141, 80)
        Me.CboAccountGroup.Name = "CboAccountGroup"
        Me.CboAccountGroup.Size = New System.Drawing.Size(205, 29)
        Me.CboAccountGroup.TabIndex = 2
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl3.Location = New System.Drawing.Point(21, 83)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(114, 21)
        Me.Lbl3.SLFCustomElipsis = False
        Me.Lbl3.TabIndex = 6
        Me.Lbl3.Text = "Account Group"
        '
        'TxtAccountNumber
        '
        Me.TxtAccountNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAccountNumber.Location = New System.Drawing.Point(141, 115)
        Me.TxtAccountNumber.MaxLength = 255
        Me.TxtAccountNumber.Name = "TxtAccountNumber"
        Me.TxtAccountNumber.Size = New System.Drawing.Size(206, 29)
        Me.TxtAccountNumber.SLFAutoTrim = True
        Me.TxtAccountNumber.SLFHarusDiisi = True
        Me.TxtAccountNumber.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtAccountNumber.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtAccountNumber.SLFHightlightSaatFokus = True
        Me.TxtAccountNumber.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtAccountNumber.SLFIsBlank = True
        Me.TxtAccountNumber.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtAccountNumber.SLFPilihSemuaSaatFokus = True
        Me.TxtAccountNumber.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtAccountNumber.SLFSQLText = ""
        Me.TxtAccountNumber.SLFTanpaSpasi = False
        Me.TxtAccountNumber.SLFValidasiField = Nothing
        Me.TxtAccountNumber.TabIndex = 3
        Me.TxtAccountNumber.Tag = "txt"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl4.Location = New System.Drawing.Point(7, 118)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(128, 21)
        Me.Lbl4.SLFCustomElipsis = False
        Me.Lbl4.TabIndex = 8
        Me.Lbl4.Text = "Account Number"
        '
        'TxtAccountName
        '
        Me.TxtAccountName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtAccountName.Location = New System.Drawing.Point(141, 150)
        Me.TxtAccountName.MaxLength = 255
        Me.TxtAccountName.Name = "TxtAccountName"
        Me.TxtAccountName.Size = New System.Drawing.Size(399, 29)
        Me.TxtAccountName.SLFAutoTrim = True
        Me.TxtAccountName.SLFHarusDiisi = True
        Me.TxtAccountName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtAccountName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtAccountName.SLFHightlightSaatFokus = True
        Me.TxtAccountName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtAccountName.SLFIsBlank = True
        Me.TxtAccountName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtAccountName.SLFPilihSemuaSaatFokus = True
        Me.TxtAccountName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtAccountName.SLFSQLText = ""
        Me.TxtAccountName.SLFTanpaSpasi = False
        Me.TxtAccountName.SLFValidasiField = Nothing
        Me.TxtAccountName.TabIndex = 4
        Me.TxtAccountName.Tag = "txt"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl5.Location = New System.Drawing.Point(23, 153)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(112, 21)
        Me.Lbl5.SLFCustomElipsis = False
        Me.Lbl5.TabIndex = 10
        Me.Lbl5.Text = "Account Name"
        '
        'ChkEnable
        '
        Me.ChkEnable.AutoSize = True
        Me.ChkEnable.BackColor = System.Drawing.Color.Transparent
        Me.ChkEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkEnable.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkEnable.Location = New System.Drawing.Point(141, 185)
        Me.ChkEnable.Name = "ChkEnable"
        Me.ChkEnable.Size = New System.Drawing.Size(177, 25)
        Me.ChkEnable.TabIndex = 5
        Me.ChkEnable.Text = "Enable for transaction"
        Me.ChkEnable.UseVisualStyleBackColor = False
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.Location = New System.Drawing.Point(180, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 8
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'frmAccountGroup_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(550, 406)
        Me.Name = "frmAccountGroup_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents Lbl5 As CMCv.lbl
    Friend WithEvents TxtAccountName As CMCv.txt
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents TxtAccountNumber As CMCv.txt
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents CboAccountGroup As CMCv.cbo
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents CboAccountingBook As CMCv.cbo
    Friend WithEvents CboPlant As CMCv.cbo
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents ChkEnable As CMCv.chk

End Class
