<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POST_Editor
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
        Me.TxtPositionDescription = New CMCv.txt(Me.components)
        Me.TxtPositionName = New CMCv.txt(Me.components)
        Me.CboDepartement = New CMCv.cbo(Me.components)
        Me.CboCompany = New CMCv.cbo(Me.components)
        Me.TxtPositionCode = New CMCv.txt(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
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
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 342)
        Me.PnlBottomButton.Size = New System.Drawing.Size(513, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(513, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ULbl5)
        Me.SLFPanel.Controls.Add(Me.ULbl4)
        Me.SLFPanel.Controls.Add(Me.ULbl3)
        Me.SLFPanel.Controls.Add(Me.ULbl2)
        Me.SLFPanel.Controls.Add(Me.ULbl1)
        Me.SLFPanel.Controls.Add(Me.TxtPositionDescription)
        Me.SLFPanel.Controls.Add(Me.TxtPositionName)
        Me.SLFPanel.Controls.Add(Me.CboDepartement)
        Me.SLFPanel.Controls.Add(Me.CboCompany)
        Me.SLFPanel.Controls.Add(Me.TxtPositionCode)
        Me.SLFPanel.Size = New System.Drawing.Size(513, 392)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPositionCode, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboCompany, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboDepartement, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPositionName, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPositionDescription, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl4, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl5, 0)
        '
        'TxtPositionDescription
        '
        Me.TxtPositionDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPositionDescription.Location = New System.Drawing.Point(168, 150)
        Me.TxtPositionDescription.MaxLength = 255
        Me.TxtPositionDescription.Multiline = True
        Me.TxtPositionDescription.Name = "TxtPositionDescription"
        Me.TxtPositionDescription.Size = New System.Drawing.Size(329, 117)
        Me.TxtPositionDescription.SLFAutoTrim = False
        Me.TxtPositionDescription.SLFHarusDiisi = False
        Me.TxtPositionDescription.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPositionDescription.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPositionDescription.SLFHightlightSaatFokus = False
        Me.TxtPositionDescription.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPositionDescription.SLFIsBlank = True
        Me.TxtPositionDescription.SLFIsSearchBox = False
        Me.TxtPositionDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPositionDescription.SLFPilihSemuaSaatFokus = False
        Me.TxtPositionDescription.SLFPwdLengthMin = 8
        Me.TxtPositionDescription.SLFPwdStrengthCalculate = False
        Me.TxtPositionDescription.SLFPwdStrengthScore = 0
        Me.TxtPositionDescription.SLFPwdStrengthText = Nothing
        Me.TxtPositionDescription.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPositionDescription.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPositionDescription.SLFSQLText = ""
        Me.TxtPositionDescription.SLFTanpaSpasi = False
        Me.TxtPositionDescription.SLFValidasiField = Nothing
        Me.TxtPositionDescription.TabIndex = 4
        Me.TxtPositionDescription.Tag = "txt"
        '
        'TxtPositionName
        '
        Me.TxtPositionName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPositionName.Location = New System.Drawing.Point(168, 115)
        Me.TxtPositionName.MaxLength = 255
        Me.TxtPositionName.Name = "TxtPositionName"
        Me.TxtPositionName.Size = New System.Drawing.Size(206, 29)
        Me.TxtPositionName.SLFAutoTrim = True
        Me.TxtPositionName.SLFHarusDiisi = True
        Me.TxtPositionName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPositionName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPositionName.SLFHightlightSaatFokus = True
        Me.TxtPositionName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPositionName.SLFIsBlank = True
        Me.TxtPositionName.SLFIsSearchBox = False
        Me.TxtPositionName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPositionName.SLFPilihSemuaSaatFokus = False
        Me.TxtPositionName.SLFPwdLengthMin = 8
        Me.TxtPositionName.SLFPwdStrengthCalculate = False
        Me.TxtPositionName.SLFPwdStrengthScore = 0
        Me.TxtPositionName.SLFPwdStrengthText = Nothing
        Me.TxtPositionName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPositionName.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPositionName.SLFSQLText = ""
        Me.TxtPositionName.SLFTanpaSpasi = False
        Me.TxtPositionName.SLFValidasiField = Nothing
        Me.TxtPositionName.TabIndex = 3
        Me.TxtPositionName.Tag = "txt"
        '
        'CboDepartement
        '
        Me.CboDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDepartement.DropDownWidth = 350
        Me.CboDepartement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboDepartement.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboDepartement.FormattingEnabled = True
        Me.CboDepartement.Location = New System.Drawing.Point(168, 45)
        Me.CboDepartement.Name = "CboDepartement"
        Me.CboDepartement.Size = New System.Drawing.Size(206, 29)
        Me.CboDepartement.TabIndex = 1
        '
        'CboCompany
        '
        Me.CboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCompany.DropDownWidth = 350
        Me.CboCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboCompany.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboCompany.FormattingEnabled = True
        Me.CboCompany.Location = New System.Drawing.Point(168, 10)
        Me.CboCompany.Name = "CboCompany"
        Me.CboCompany.Size = New System.Drawing.Size(206, 29)
        Me.CboCompany.TabIndex = 0
        '
        'TxtPositionCode
        '
        Me.TxtPositionCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPositionCode.Location = New System.Drawing.Point(168, 80)
        Me.TxtPositionCode.MaxLength = 255
        Me.TxtPositionCode.Name = "TxtPositionCode"
        Me.TxtPositionCode.Size = New System.Drawing.Size(206, 29)
        Me.TxtPositionCode.SLFAutoTrim = True
        Me.TxtPositionCode.SLFHarusDiisi = True
        Me.TxtPositionCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPositionCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPositionCode.SLFHightlightSaatFokus = True
        Me.TxtPositionCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPositionCode.SLFIsBlank = True
        Me.TxtPositionCode.SLFIsSearchBox = False
        Me.TxtPositionCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtPositionCode.SLFPilihSemuaSaatFokus = True
        Me.TxtPositionCode.SLFPwdLengthMin = 8
        Me.TxtPositionCode.SLFPwdStrengthCalculate = False
        Me.TxtPositionCode.SLFPwdStrengthScore = 0
        Me.TxtPositionCode.SLFPwdStrengthText = Nothing
        Me.TxtPositionCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPositionCode.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPositionCode.SLFSQLText = ""
        Me.TxtPositionCode.SLFTanpaSpasi = False
        Me.TxtPositionCode.SLFValidasiField = Nothing
        Me.TxtPositionCode.TabIndex = 2
        Me.TxtPositionCode.Tag = "txt"
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
        Me.BtnSave.Location = New System.Drawing.Point(295, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 801
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
        Me.BtnCancel.Location = New System.Drawing.Point(401, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 802
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
        Me.ChkAddNew.Location = New System.Drawing.Point(146, 11)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 803
        Me.ChkAddNew.Text = "Add new on Save"
        Me.ChkAddNew.UseVisualStyleBackColor = False
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(12, 10)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(150, 29)
        Me.ULbl1.SLFText = "Company"
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 1014
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(12, 45)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Department"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1015
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(12, 80)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Position Code"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1016
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(12, 115)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Position Name"
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1017
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(12, 150)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 117)
        Me.ULbl5.SLFText = "Description"
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 1018
        '
        'POST_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(513, 468)
        Me.KeyPreview = True
        Me.Name = "POST_Editor"
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
    Friend WithEvents TxtPositionDescription As CMCv.txt
    Friend WithEvents TxtPositionName As CMCv.txt
    Friend WithEvents CboDepartement As CMCv.cbo
    Friend WithEvents CboCompany As CMCv.cbo
    Friend WithEvents TxtPositionCode As CMCv.txt
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
End Class
