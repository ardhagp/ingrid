<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ACBK_Editor
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
        Me.Cbo1 = New CMCv.cbo(Me.components)
        Me.Txt1 = New CMCv.txt(Me.components)
        Me.Txt2 = New CMCv.txt(Me.components)
        Me.Txt3 = New CMCv.txt(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.Lbl3 = New CMCv.lbl(Me.components)
        Me.Lbl4 = New CMCv.lbl(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
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
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 227)
        Me.PnlBottomButton.Size = New System.Drawing.Size(495, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(202, 23)
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Size = New System.Drawing.Size(225, 46)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(495, 96)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.Lbl4)
        Me.SLFPanel.Controls.Add(Me.Lbl3)
        Me.SLFPanel.Controls.Add(Me.Lbl2)
        Me.SLFPanel.Controls.Add(Me.Lbl1)
        Me.SLFPanel.Controls.Add(Me.Txt3)
        Me.SLFPanel.Controls.Add(Me.Txt2)
        Me.SLFPanel.Controls.Add(Me.Txt1)
        Me.SLFPanel.Controls.Add(Me.Cbo1)
        Me.SLFPanel.Size = New System.Drawing.Size(495, 277)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Cbo1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Txt1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Txt2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Txt3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl4, 0)
        '
        'Cbo1
        '
        Me.Cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo1.DropDownWidth = 350
        Me.Cbo1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Location = New System.Drawing.Point(141, 10)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(121, 29)
        Me.Cbo1.TabIndex = 0
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt1.Location = New System.Drawing.Point(141, 45)
        Me.Txt1.MaxLength = 10
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(121, 29)
        Me.Txt1.SLFAutoTrim = True
        Me.Txt1.SLFHarusDiisi = True
        Me.Txt1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt1.SLFHightlightSaatFokus = True
        Me.Txt1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt1.SLFIsBlank = True
        Me.Txt1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.Txt1.SLFPilihSemuaSaatFokus = False
        Me.Txt1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt1.SLFSQLText = ""
        Me.Txt1.SLFTanpaSpasi = False
        Me.Txt1.SLFValidasiField = Nothing
        Me.Txt1.TabIndex = 1
        Me.Txt1.Tag = "txt"
        Me.Txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt2
        '
        Me.Txt2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt2.Location = New System.Drawing.Point(141, 80)
        Me.Txt2.MaxLength = 50
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(342, 29)
        Me.Txt2.SLFAutoTrim = True
        Me.Txt2.SLFHarusDiisi = True
        Me.Txt2.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt2.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt2.SLFHightlightSaatFokus = True
        Me.Txt2.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt2.SLFIsBlank = True
        Me.Txt2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.Txt2.SLFPilihSemuaSaatFokus = False
        Me.Txt2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt2.SLFSQLText = ""
        Me.Txt2.SLFTanpaSpasi = False
        Me.Txt2.SLFValidasiField = Nothing
        Me.Txt2.TabIndex = 2
        Me.Txt2.Tag = "txt"
        '
        'Txt3
        '
        Me.Txt3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt3.Location = New System.Drawing.Point(141, 115)
        Me.Txt3.MaxLength = 255
        Me.Txt3.Multiline = True
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(342, 75)
        Me.Txt3.SLFAutoTrim = True
        Me.Txt3.SLFHarusDiisi = False
        Me.Txt3.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt3.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt3.SLFHightlightSaatFokus = True
        Me.Txt3.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt3.SLFIsBlank = True
        Me.Txt3.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.Txt3.SLFPilihSemuaSaatFokus = False
        Me.Txt3.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt3.SLFSQLText = ""
        Me.Txt3.SLFTanpaSpasi = False
        Me.Txt3.SLFValidasiField = Nothing
        Me.Txt3.TabIndex = 3
        Me.Txt3.Tag = "txt"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(90, 13)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(45, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 5
        Me.Lbl1.Text = "Plant"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl2.Location = New System.Drawing.Point(50, 48)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(85, 21)
        Me.Lbl2.SLFCustomElipsis = False
        Me.Lbl2.TabIndex = 6
        Me.Lbl2.Text = "Book Code"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl3.Location = New System.Drawing.Point(44, 83)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(91, 21)
        Me.Lbl3.SLFCustomElipsis = False
        Me.Lbl3.TabIndex = 7
        Me.Lbl3.Text = "Book Name"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl4.Location = New System.Drawing.Point(46, 118)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(89, 21)
        Me.Lbl4.SLFCustomElipsis = False
        Me.Lbl4.TabIndex = 8
        Me.Lbl4.Text = "Description"
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
        Me.BtnSave.Location = New System.Drawing.Point(277, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 4
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
        Me.BtnCancel.Location = New System.Drawing.Point(383, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(125, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 6
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'ACBK_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(495, 395)
        Me.Name = "ACBK_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbo1 As CMCv.cbo
    Friend WithEvents Txt1 As CMCv.txt
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Txt3 As CMCv.txt
    Friend WithEvents Txt2 As CMCv.txt
    Friend WithEvents ChkAddNew As CMCv.chk

End Class
