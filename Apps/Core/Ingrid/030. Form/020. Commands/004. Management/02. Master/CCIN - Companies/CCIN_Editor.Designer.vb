<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CCIN_Editor
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
        Me.TxtCode = New CMCv.txt(Me.components)
        Me.TxtSearchTerm1 = New CMCv.txt(Me.components)
        Me.TxtSearchTerm2 = New CMCv.txt(Me.components)
        Me.TxtDescription = New CMCv.txt(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.TxtName = New CMCv.txt(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.ULbl5 = New CMCv.ULbl()
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
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 341)
        Me.PnlBottomButton.Size = New System.Drawing.Size(539, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(539, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ULbl5)
        Me.SLFPanel.Controls.Add(Me.ULbl4)
        Me.SLFPanel.Controls.Add(Me.ULbl3)
        Me.SLFPanel.Controls.Add(Me.ULbl2)
        Me.SLFPanel.Controls.Add(Me.ULbl1)
        Me.SLFPanel.Controls.Add(Me.TxtName)
        Me.SLFPanel.Controls.Add(Me.TxtDescription)
        Me.SLFPanel.Controls.Add(Me.TxtSearchTerm2)
        Me.SLFPanel.Controls.Add(Me.TxtSearchTerm1)
        Me.SLFPanel.Controls.Add(Me.TxtCode)
        Me.SLFPanel.Size = New System.Drawing.Size(539, 391)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtCode, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtSearchTerm1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtSearchTerm2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtDescription, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtName, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl4, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl5, 0)
        '
        'TxtCode
        '
        Me.TxtCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtCode.Location = New System.Drawing.Point(169, 10)
        Me.TxtCode.MaxLength = 255
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(206, 29)
        Me.TxtCode.SLFAutoTrim = True
        Me.TxtCode.SLFHarusDiisi = True
        Me.TxtCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtCode.SLFHightlightSaatFokus = True
        Me.TxtCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtCode.SLFIsBlank = True
        Me.TxtCode.SLFIsSearchBox = False
        Me.TxtCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtCode.SLFPilihSemuaSaatFokus = True
        Me.TxtCode.SLFPwdLengthMin = 8
        Me.TxtCode.SLFPwdStrengthCalculate = False
        Me.TxtCode.SLFPwdStrengthScore = 0
        Me.TxtCode.SLFPwdStrengthText = Nothing
        Me.TxtCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtCode.SLFSearchBoxText = "Type then press Enter"
        Me.TxtCode.SLFSQLText = ""
        Me.TxtCode.SLFTanpaSpasi = False
        Me.TxtCode.SLFValidasiField = Nothing
        Me.TxtCode.TabIndex = 0
        Me.TxtCode.Tag = "txt"
        '
        'TxtSearchTerm1
        '
        Me.TxtSearchTerm1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtSearchTerm1.Location = New System.Drawing.Point(168, 80)
        Me.TxtSearchTerm1.MaxLength = 255
        Me.TxtSearchTerm1.Name = "TxtSearchTerm1"
        Me.TxtSearchTerm1.Size = New System.Drawing.Size(206, 29)
        Me.TxtSearchTerm1.SLFAutoTrim = True
        Me.TxtSearchTerm1.SLFHarusDiisi = False
        Me.TxtSearchTerm1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtSearchTerm1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtSearchTerm1.SLFHightlightSaatFokus = False
        Me.TxtSearchTerm1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtSearchTerm1.SLFIsBlank = True
        Me.TxtSearchTerm1.SLFIsSearchBox = False
        Me.TxtSearchTerm1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtSearchTerm1.SLFPilihSemuaSaatFokus = False
        Me.TxtSearchTerm1.SLFPwdLengthMin = 8
        Me.TxtSearchTerm1.SLFPwdStrengthCalculate = False
        Me.TxtSearchTerm1.SLFPwdStrengthScore = 0
        Me.TxtSearchTerm1.SLFPwdStrengthText = Nothing
        Me.TxtSearchTerm1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtSearchTerm1.SLFSearchBoxText = "Type then press Enter"
        Me.TxtSearchTerm1.SLFSQLText = ""
        Me.TxtSearchTerm1.SLFTanpaSpasi = False
        Me.TxtSearchTerm1.SLFValidasiField = Nothing
        Me.TxtSearchTerm1.TabIndex = 2
        Me.TxtSearchTerm1.Tag = "txt"
        '
        'TxtSearchTerm2
        '
        Me.TxtSearchTerm2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtSearchTerm2.Location = New System.Drawing.Point(168, 115)
        Me.TxtSearchTerm2.MaxLength = 255
        Me.TxtSearchTerm2.Name = "TxtSearchTerm2"
        Me.TxtSearchTerm2.Size = New System.Drawing.Size(356, 29)
        Me.TxtSearchTerm2.SLFAutoTrim = True
        Me.TxtSearchTerm2.SLFHarusDiisi = False
        Me.TxtSearchTerm2.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtSearchTerm2.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtSearchTerm2.SLFHightlightSaatFokus = False
        Me.TxtSearchTerm2.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtSearchTerm2.SLFIsBlank = True
        Me.TxtSearchTerm2.SLFIsSearchBox = False
        Me.TxtSearchTerm2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtSearchTerm2.SLFPilihSemuaSaatFokus = False
        Me.TxtSearchTerm2.SLFPwdLengthMin = 8
        Me.TxtSearchTerm2.SLFPwdStrengthCalculate = False
        Me.TxtSearchTerm2.SLFPwdStrengthScore = 0
        Me.TxtSearchTerm2.SLFPwdStrengthText = Nothing
        Me.TxtSearchTerm2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtSearchTerm2.SLFSearchBoxText = "Type then press Enter"
        Me.TxtSearchTerm2.SLFSQLText = ""
        Me.TxtSearchTerm2.SLFTanpaSpasi = False
        Me.TxtSearchTerm2.SLFValidasiField = Nothing
        Me.TxtSearchTerm2.TabIndex = 3
        Me.TxtSearchTerm2.Tag = "txt"
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDescription.Location = New System.Drawing.Point(168, 150)
        Me.TxtDescription.MaxLength = 255
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(356, 117)
        Me.TxtDescription.SLFAutoTrim = True
        Me.TxtDescription.SLFHarusDiisi = False
        Me.TxtDescription.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDescription.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDescription.SLFHightlightSaatFokus = False
        Me.TxtDescription.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDescription.SLFIsBlank = True
        Me.TxtDescription.SLFIsSearchBox = False
        Me.TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtDescription.SLFPilihSemuaSaatFokus = False
        Me.TxtDescription.SLFPwdLengthMin = 8
        Me.TxtDescription.SLFPwdStrengthCalculate = False
        Me.TxtDescription.SLFPwdStrengthScore = 0
        Me.TxtDescription.SLFPwdStrengthText = Nothing
        Me.TxtDescription.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDescription.SLFSearchBoxText = "Type then press Enter"
        Me.TxtDescription.SLFSQLText = ""
        Me.TxtDescription.SLFTanpaSpasi = False
        Me.TxtDescription.SLFValidasiField = Nothing
        Me.TxtDescription.TabIndex = 4
        Me.TxtDescription.Tag = "txt"
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
        Me.BtnSave.Location = New System.Drawing.Point(321, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 5
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
        Me.BtnCancel.Location = New System.Drawing.Point(427, 7)
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
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtName.Location = New System.Drawing.Point(168, 45)
        Me.TxtName.MaxLength = 255
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(206, 29)
        Me.TxtName.SLFAutoTrim = True
        Me.TxtName.SLFHarusDiisi = True
        Me.TxtName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtName.SLFHightlightSaatFokus = True
        Me.TxtName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtName.SLFIsBlank = True
        Me.TxtName.SLFIsSearchBox = False
        Me.TxtName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtName.SLFPilihSemuaSaatFokus = False
        Me.TxtName.SLFPwdLengthMin = 8
        Me.TxtName.SLFPwdStrengthCalculate = False
        Me.TxtName.SLFPwdStrengthScore = 0
        Me.TxtName.SLFPwdStrengthText = Nothing
        Me.TxtName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtName.SLFSearchBoxText = "Type then press Enter"
        Me.TxtName.SLFSQLText = ""
        Me.TxtName.SLFTanpaSpasi = False
        Me.TxtName.SLFValidasiField = Nothing
        Me.TxtName.TabIndex = 1
        Me.TxtName.Tag = "txt"
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(169, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 6
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(12, 10)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Company Code"
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1006
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(12, 45)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Company Name"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1007
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(12, 80)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Search Term 1"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1008
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(12, 115)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Search Term 2"
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1009
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(12, 150)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 117)
        Me.ULbl5.SLFText = "Description"
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 1010
        '
        'CCIN_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(539, 467)
        Me.KeyPreview = True
        Me.Name = "CCIN_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCode As CMCv.txt
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents TxtSearchTerm2 As CMCv.txt
    Friend WithEvents TxtSearchTerm1 As CMCv.txt
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents TxtName As CMCv.txt
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
End Class
