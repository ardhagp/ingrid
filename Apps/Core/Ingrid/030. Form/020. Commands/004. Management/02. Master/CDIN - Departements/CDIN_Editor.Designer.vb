<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CDIN_Editor
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
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.TxtDeptCode = New CMCv.txt(Me.components)
        Me.CboCompany = New CMCv.cbo(Me.components)
        Me.TxtDeptName = New CMCv.txt(Me.components)
        Me.TxtDescription = New CMCv.txt(Me.components)
        Me.ChkAddNew = New CMCv.chk(Me.components)
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.ChkAddNew)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 228)
        Me.PnlBottomButton.Size = New System.Drawing.Size(524, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.ChkAddNew, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(524, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.ULbl4)
        Me.SLFPanel.Controls.Add(Me.ULbl3)
        Me.SLFPanel.Controls.Add(Me.ULbl2)
        Me.SLFPanel.Controls.Add(Me.ULbl1)
        Me.SLFPanel.Controls.Add(Me.TxtDescription)
        Me.SLFPanel.Controls.Add(Me.TxtDeptName)
        Me.SLFPanel.Controls.Add(Me.CboCompany)
        Me.SLFPanel.Controls.Add(Me.TxtDeptCode)
        Me.SLFPanel.Size = New System.Drawing.Size(524, 278)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtDeptCode, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboCompany, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtDeptName, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtDescription, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ULbl4, 0)
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
        Me.BtnSave.Location = New System.Drawing.Point(306, 7)
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
        Me.BtnCancel.Location = New System.Drawing.Point(412, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtDeptCode
        '
        Me.TxtDeptCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDeptCode.Location = New System.Drawing.Point(168, 45)
        Me.TxtDeptCode.MaxLength = 255
        Me.TxtDeptCode.Name = "TxtDeptCode"
        Me.TxtDeptCode.Size = New System.Drawing.Size(206, 29)
        Me.TxtDeptCode.SLFAutoTrim = True
        Me.TxtDeptCode.SLFHarusDiisi = True
        Me.TxtDeptCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDeptCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDeptCode.SLFHightlightSaatFokus = True
        Me.TxtDeptCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDeptCode.SLFIsBlank = True
        Me.TxtDeptCode.SLFIsSearchBox = False
        Me.TxtDeptCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtDeptCode.SLFPilihSemuaSaatFokus = True
        Me.TxtDeptCode.SLFPwdLengthMin = 8
        Me.TxtDeptCode.SLFPwdStrengthCalculate = False
        Me.TxtDeptCode.SLFPwdStrengthScore = 0
        Me.TxtDeptCode.SLFPwdStrengthText = Nothing
        Me.TxtDeptCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDeptCode.SLFSearchBoxText = "Type then press Enter"
        Me.TxtDeptCode.SLFSQLText = ""
        Me.TxtDeptCode.SLFTanpaSpasi = False
        Me.TxtDeptCode.SLFValidasiField = Nothing
        Me.TxtDeptCode.TabIndex = 1
        Me.TxtDeptCode.Tag = "txt"
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
        'TxtDeptName
        '
        Me.TxtDeptName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDeptName.Location = New System.Drawing.Point(168, 80)
        Me.TxtDeptName.MaxLength = 255
        Me.TxtDeptName.Name = "TxtDeptName"
        Me.TxtDeptName.Size = New System.Drawing.Size(206, 29)
        Me.TxtDeptName.SLFAutoTrim = True
        Me.TxtDeptName.SLFHarusDiisi = True
        Me.TxtDeptName.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDeptName.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDeptName.SLFHightlightSaatFokus = True
        Me.TxtDeptName.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDeptName.SLFIsBlank = True
        Me.TxtDeptName.SLFIsSearchBox = False
        Me.TxtDeptName.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtDeptName.SLFPilihSemuaSaatFokus = False
        Me.TxtDeptName.SLFPwdLengthMin = 8
        Me.TxtDeptName.SLFPwdStrengthCalculate = False
        Me.TxtDeptName.SLFPwdStrengthScore = 0
        Me.TxtDeptName.SLFPwdStrengthText = Nothing
        Me.TxtDeptName.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDeptName.SLFSearchBoxText = "Type then press Enter"
        Me.TxtDeptName.SLFSQLText = ""
        Me.TxtDeptName.SLFTanpaSpasi = False
        Me.TxtDeptName.SLFValidasiField = Nothing
        Me.TxtDeptName.TabIndex = 2
        Me.TxtDeptName.Tag = "txt"
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDescription.Location = New System.Drawing.Point(168, 115)
        Me.TxtDescription.MaxLength = 255
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(345, 98)
        Me.TxtDescription.SLFAutoTrim = False
        Me.TxtDescription.SLFHarusDiisi = False
        Me.TxtDescription.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDescription.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDescription.SLFHightlightSaatFokus = True
        Me.TxtDescription.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDescription.SLFIsBlank = True
        Me.TxtDescription.SLFIsSearchBox = False
        Me.TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
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
        Me.TxtDescription.TabIndex = 3
        Me.TxtDescription.Tag = "txt"
        '
        'ChkAddNew
        '
        Me.ChkAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAddNew.AutoSize = True
        Me.ChkAddNew.BackColor = System.Drawing.Color.Transparent
        Me.ChkAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkAddNew.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkAddNew.ForeColor = System.Drawing.Color.Tomato
        Me.ChkAddNew.Location = New System.Drawing.Point(154, 15)
        Me.ChkAddNew.Name = "ChkAddNew"
        Me.ChkAddNew.Size = New System.Drawing.Size(146, 25)
        Me.ChkAddNew.TabIndex = 5
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
        Me.ULbl1.TabIndex = 1004
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(12, 45)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(150, 29)
        Me.ULbl2.SLFText = "Dept. Code"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 1005
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(12, 80)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(150, 29)
        Me.ULbl3.SLFText = "Dept. Name"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 1006
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(12, 115)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 98)
        Me.ULbl4.SLFText = "Description"
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 1007
        '
        'CDIN_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(524, 354)
        Me.KeyPreview = True
        Me.Name = "CDIN_Editor"
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
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents TxtDeptName As CMCv.txt
    Friend WithEvents CboCompany As CMCv.cbo
    Friend WithEvents TxtDeptCode As CMCv.txt
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents ChkAddNew As CMCv.chk
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
End Class
