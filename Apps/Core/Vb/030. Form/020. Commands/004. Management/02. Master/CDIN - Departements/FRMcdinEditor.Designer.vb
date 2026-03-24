Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMcdinEditor
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
            components = New ComponentModel.Container()
            BtnSave = New CMCv.UI.Control.btn(components)
            BtnCancel = New CMCv.UI.Control.btn(components)
            TxtDeptCode = New CMCv.UI.Control.txt(components)
            CboCompany = New CMCv.UI.Control.cbo(components)
            TxtDeptName = New CMCv.UI.Control.txt(components)
            TxtDescription = New CMCv.UI.Control.txt(components)
            ChkAddNew = New CMCv.UI.Control.chk(components)
            ULbl1 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
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
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Location = New Point(0, 451)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(873, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(873, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ULbl4)
            SLFPanel.Controls.Add(ULbl3)
            SLFPanel.Controls.Add(ULbl2)
            SLFPanel.Controls.Add(ULbl1)
            SLFPanel.Controls.Add(TxtDescription)
            SLFPanel.Controls.Add(TxtDeptName)
            SLFPanel.Controls.Add(CboCompany)
            SLFPanel.Controls.Add(TxtDeptCode)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(873, 548)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(TxtDeptCode, 0)
            SLFPanel.Controls.SetChildIndex(CboCompany, 0)
            SLFPanel.Controls.SetChildIndex(TxtDeptName, 0)
            SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
            SLFPanel.Controls.SetChildIndex(ULbl1, 0)
            SLFPanel.Controls.SetChildIndex(ULbl2, 0)
            SLFPanel.Controls.SetChildIndex(ULbl3, 0)
            SLFPanel.Controls.SetChildIndex(ULbl4, 0)
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
            BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(509, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 4
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
            BtnSave.XOTampilkanFocusBorder = False
            BtnSave.XOValidasiSemuaInput = False
            BtnSave.XOValidasiSemuaInputTag = Nothing
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
            BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(686, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 6
            BtnCancel.Text = "&Close"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnCancel.XOTampilkanFocusBorder = False
            BtnCancel.XOValidasiSemuaInput = False
            BtnCancel.XOValidasiSemuaInputTag = Nothing
            ' 
            ' TxtDeptCode
            ' 
            TxtDeptCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDeptCode.Location = New Point(280, 87)
            TxtDeptCode.Margin = New Padding(6, 5, 6, 5)
            TxtDeptCode.MaxLength = 255
            TxtDeptCode.Name = "TxtDeptCode"
            TxtDeptCode.Size = New Size(341, 39)
            TxtDeptCode.TabIndex = 1
            TxtDeptCode.Tag = "txt"
            TxtDeptCode.XOAutoTrim = True
            TxtDeptCode.XOHarusDiisi = True
            TxtDeptCode.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtDeptCode.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtDeptCode.XOHightlightSaatFokus = True
            TxtDeptCode.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtDeptCode.XOIsBlank = True
            TxtDeptCode.XOIsSearchBox = False
            TxtDeptCode.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtDeptCode.XOPilihSemuaSaatFokus = True
            TxtDeptCode.XOPwdLengthMin = 8
            TxtDeptCode.XOPwdStrengthCalculate = False
            TxtDeptCode.XOPwdStrengthScore = 0
            TxtDeptCode.XOPwdStrengthText = Nothing
            TxtDeptCode.XORestriction = ControlCodeBase.enuRestriction.None
            TxtDeptCode.XOSearchBoxText = "Type then press Enter"
            TxtDeptCode.XOSQLText = ""
            TxtDeptCode.XOTanpaSpasi = False
            TxtDeptCode.XOValidasiField = Nothing
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.DropDownWidth = 350
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            CboCompany.FormattingEnabled = True
            CboCompany.Location = New Point(280, 20)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(341, 40)
            CboCompany.TabIndex = 0
            ' 
            ' TxtDeptName
            ' 
            TxtDeptName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDeptName.Location = New Point(280, 153)
            TxtDeptName.Margin = New Padding(6, 5, 6, 5)
            TxtDeptName.MaxLength = 255
            TxtDeptName.Name = "TxtDeptName"
            TxtDeptName.Size = New Size(341, 39)
            TxtDeptName.TabIndex = 2
            TxtDeptName.Tag = "txt"
            TxtDeptName.XOAutoTrim = True
            TxtDeptName.XOHarusDiisi = True
            TxtDeptName.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtDeptName.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtDeptName.XOHightlightSaatFokus = True
            TxtDeptName.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtDeptName.XOIsBlank = True
            TxtDeptName.XOIsSearchBox = False
            TxtDeptName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtDeptName.XOPilihSemuaSaatFokus = False
            TxtDeptName.XOPwdLengthMin = 8
            TxtDeptName.XOPwdStrengthCalculate = False
            TxtDeptName.XOPwdStrengthScore = 0
            TxtDeptName.XOPwdStrengthText = Nothing
            TxtDeptName.XORestriction = ControlCodeBase.enuRestriction.None
            TxtDeptName.XOSearchBoxText = "Type then press Enter"
            TxtDeptName.XOSQLText = ""
            TxtDeptName.XOTanpaSpasi = False
            TxtDeptName.XOValidasiField = Nothing
            ' 
            ' TxtDescription
            ' 
            TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDescription.Location = New Point(280, 222)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Multiline = True
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(573, 184)
            TxtDescription.TabIndex = 3
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = False
            TxtDescription.XOHarusDiisi = False
            TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtDescription.XOHightlightSaatFokus = True
            TxtDescription.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtDescription.XOIsBlank = True
            TxtDescription.XOIsSearchBox = False
            TxtDescription.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtDescription.XOPilihSemuaSaatFokus = False
            TxtDescription.XOPwdLengthMin = 8
            TxtDescription.XOPwdStrengthCalculate = False
            TxtDescription.XOPwdStrengthScore = 0
            TxtDescription.XOPwdStrengthText = Nothing
            TxtDescription.XORestriction = ControlCodeBase.enuRestriction.None
            TxtDescription.XOSearchBoxText = "Type then press Enter"
            TxtDescription.XOSQLText = ""
            TxtDescription.XOTanpaSpasi = False
            TxtDescription.XOValidasiField = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(278, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 5
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(20, 20)
            ULbl1.Margin = New Padding(7, 5, 7, 5)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 39)
            ULbl1.SLFText = "Company"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl1.TabIndex = 1004
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(20, 87)
            ULbl2.Margin = New Padding(7, 5, 7, 5)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 39)
            ULbl2.SLFText = "Dept. Code"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1005
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(20, 153)
            ULbl3.Margin = New Padding(7, 5, 7, 5)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 39)
            ULbl3.SLFText = "Dept. Name"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl3.TabIndex = 1006
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(20, 222)
            ULbl4.Margin = New Padding(7, 5, 7, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 184)
            ULbl4.SLFText = "Description"
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl4.TabIndex = 1007
            ' 
            ' FRMcdinEditor
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(873, 680)
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMcdinEditor"
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
        Friend WithEvents BtnSave As CMCv.UI.Control.btn
        Friend WithEvents BtnCancel As CMCv.UI.Control.btn
        Friend WithEvents TxtDeptName As CMCv.UI.Control.txt
        Friend WithEvents CboCompany As CMCv.UI.Control.cbo
        Friend WithEvents TxtDeptCode As CMCv.UI.Control.txt
        Friend WithEvents TxtDescription As CMCv.UI.Control.txt
        Friend WithEvents ChkAddNew As CMCv.UI.Control.chk
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
    End Class
End Namespace