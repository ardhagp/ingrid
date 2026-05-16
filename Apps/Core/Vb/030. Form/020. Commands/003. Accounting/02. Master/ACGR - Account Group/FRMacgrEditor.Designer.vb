Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMacgrEditor
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
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            CboCompany = New CMCv.UI.Control.cbo(components)
            CboAccountingBook = New CMCv.UI.Control.cbo(components)
            Lbl1 = New CMCv.UI.Control.lbl(components)
            Lbl2 = New CMCv.UI.Control.lbl(components)
            CboAccountGroup = New CMCv.UI.Control.cbo(components)
            Lbl3 = New CMCv.UI.Control.lbl(components)
            TxtAccountNumber = New CMCv.UI.Control.txt(components)
            Lbl4 = New CMCv.UI.Control.lbl(components)
            TxtAccountName = New CMCv.UI.Control.txt(components)
            Lbl5 = New CMCv.UI.Control.lbl(components)
            ChkEnable = New CMCv.UI.Control.chk(components)
            ChkAddNew = New CMCv.UI.Control.chk(components)
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
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 557)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(917, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(917, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(ChkEnable)
            SLFPanel.Controls.Add(Lbl5)
            SLFPanel.Controls.Add(TxtAccountName)
            SLFPanel.Controls.Add(Lbl4)
            SLFPanel.Controls.Add(TxtAccountNumber)
            SLFPanel.Controls.Add(Lbl3)
            SLFPanel.Controls.Add(CboAccountGroup)
            SLFPanel.Controls.Add(Lbl2)
            SLFPanel.Controls.Add(Lbl1)
            SLFPanel.Controls.Add(CboAccountingBook)
            SLFPanel.Controls.Add(CboCompany)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(917, 654)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(CboCompany, 0)
            SLFPanel.Controls.SetChildIndex(CboAccountingBook, 0)
            SLFPanel.Controls.SetChildIndex(Lbl1, 0)
            SLFPanel.Controls.SetChildIndex(Lbl2, 0)
            SLFPanel.Controls.SetChildIndex(CboAccountGroup, 0)
            SLFPanel.Controls.SetChildIndex(Lbl3, 0)
            SLFPanel.Controls.SetChildIndex(TxtAccountNumber, 0)
            SLFPanel.Controls.SetChildIndex(Lbl4, 0)
            SLFPanel.Controls.SetChildIndex(TxtAccountName, 0)
            SLFPanel.Controls.SetChildIndex(Lbl5, 0)
            SLFPanel.Controls.SetChildIndex(ChkEnable, 0)
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
            BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(553, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 6
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnSave.XOShowBorderOnFocus = False
            BtnSave.XOValidateAllInput = False
            BtnSave.XOValidateAllInputTag = Nothing
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
            BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(730, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 7
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' CboCompany
            ' 
            CboCompany.DropDownStyle = ComboBoxStyle.DropDownList
            CboCompany.DropDownWidth = 350
            CboCompany.FlatStyle = FlatStyle.Flat
            CboCompany.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboCompany.FormattingEnabled = True
            CboCompany.Location = New Point(234, 20)
            CboCompany.Margin = New Padding(6, 5, 6, 5)
            CboCompany.Name = "CboCompany"
            CboCompany.Size = New Size(467, 40)
            CboCompany.TabIndex = 0
            ' 
            ' CboAccountingBook
            ' 
            CboAccountingBook.DropDownStyle = ComboBoxStyle.DropDownList
            CboAccountingBook.DropDownWidth = 350
            CboAccountingBook.FlatStyle = FlatStyle.Flat
            CboAccountingBook.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboAccountingBook.FormattingEnabled = True
            CboAccountingBook.Location = New Point(234, 87)
            CboAccountingBook.Margin = New Padding(6, 5, 6, 5)
            CboAccountingBook.Name = "CboAccountingBook"
            CboAccountingBook.Size = New Size(467, 40)
            CboAccountingBook.TabIndex = 1
            ' 
            ' Lbl1
            ' 
            Lbl1.AutoSize = True
            Lbl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl1.Location = New Point(97, 25)
            Lbl1.Margin = New Padding(6, 0, 6, 0)
            Lbl1.Name = "Lbl1"
            Lbl1.Size = New Size(116, 32)
            Lbl1.TabIndex = 3
            Lbl1.Text = "Company"
            Lbl1.XOCustomElipsis = False
            ' 
            ' Lbl2
            ' 
            Lbl2.AutoSize = True
            Lbl2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl2.Location = New Point(13, 92)
            Lbl2.Margin = New Padding(6, 0, 6, 0)
            Lbl2.Name = "Lbl2"
            Lbl2.Size = New Size(196, 32)
            Lbl2.TabIndex = 4
            Lbl2.Text = "Accounting Book"
            Lbl2.XOCustomElipsis = False
            ' 
            ' CboAccountGroup
            ' 
            CboAccountGroup.DropDownStyle = ComboBoxStyle.DropDownList
            CboAccountGroup.FlatStyle = FlatStyle.Flat
            CboAccountGroup.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboAccountGroup.FormattingEnabled = True
            CboAccountGroup.Location = New Point(234, 153)
            CboAccountGroup.Margin = New Padding(6, 5, 6, 5)
            CboAccountGroup.Name = "CboAccountGroup"
            CboAccountGroup.Size = New Size(338, 40)
            CboAccountGroup.TabIndex = 2
            ' 
            ' Lbl3
            ' 
            Lbl3.AutoSize = True
            Lbl3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl3.Location = New Point(34, 160)
            Lbl3.Margin = New Padding(6, 0, 6, 0)
            Lbl3.Name = "Lbl3"
            Lbl3.Size = New Size(174, 32)
            Lbl3.TabIndex = 6
            Lbl3.Text = "Account Group"
            Lbl3.XOCustomElipsis = False
            ' 
            ' TxtAccountNumber
            ' 
            TxtAccountNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtAccountNumber.Location = New Point(234, 222)
            TxtAccountNumber.Margin = New Padding(6, 5, 6, 5)
            TxtAccountNumber.MaxLength = 255
            TxtAccountNumber.Name = "TxtAccountNumber"
            TxtAccountNumber.Size = New Size(341, 39)
            TxtAccountNumber.TabIndex = 3
            TxtAccountNumber.Tag = "txt"
            TxtAccountNumber.XOAutoTrim = True
            TxtAccountNumber.XOHarusDiisi = True
            TxtAccountNumber.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtAccountNumber.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtAccountNumber.XOHightlightSaatFokus = True
            TxtAccountNumber.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtAccountNumber.XOIsBlank = True
            TxtAccountNumber.XOIsSearchBox = False
            TxtAccountNumber.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtAccountNumber.XOPilihSemuaSaatFokus = True
            TxtAccountNumber.XOPwdLengthMin = 8
            TxtAccountNumber.XOPwdStrengthCalculate = False
            TxtAccountNumber.XOPwdStrengthScore = 0
            TxtAccountNumber.XOPwdStrengthText = Nothing
            TxtAccountNumber.XORestriction = ControlCodeBase.enuRestriction.None
            TxtAccountNumber.XOSearchBoxText = "Type then press Enter"
            TxtAccountNumber.XOSQLText = ""
            TxtAccountNumber.XOTanpaSpasi = False
            TxtAccountNumber.XOValidasiField = Nothing
            ' 
            ' Lbl4
            ' 
            Lbl4.AutoSize = True
            Lbl4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl4.Location = New Point(11, 227)
            Lbl4.Margin = New Padding(6, 0, 6, 0)
            Lbl4.Name = "Lbl4"
            Lbl4.Size = New Size(196, 32)
            Lbl4.TabIndex = 8
            Lbl4.Text = "Account Number"
            Lbl4.XOCustomElipsis = False
            ' 
            ' TxtAccountName
            ' 
            TxtAccountName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtAccountName.Location = New Point(234, 288)
            TxtAccountName.Margin = New Padding(6, 5, 6, 5)
            TxtAccountName.MaxLength = 255
            TxtAccountName.Name = "TxtAccountName"
            TxtAccountName.Size = New Size(663, 39)
            TxtAccountName.TabIndex = 4
            TxtAccountName.Tag = "txt"
            TxtAccountName.XOAutoTrim = True
            TxtAccountName.XOHarusDiisi = True
            TxtAccountName.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtAccountName.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtAccountName.XOHightlightSaatFokus = True
            TxtAccountName.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtAccountName.XOIsBlank = True
            TxtAccountName.XOIsSearchBox = False
            TxtAccountName.XOJenisKapital = ControlCodeBase.enuJenisKapital.KAPITALSEMUA
            TxtAccountName.XOPilihSemuaSaatFokus = True
            TxtAccountName.XOPwdLengthMin = 8
            TxtAccountName.XOPwdStrengthCalculate = False
            TxtAccountName.XOPwdStrengthScore = 0
            TxtAccountName.XOPwdStrengthText = Nothing
            TxtAccountName.XORestriction = ControlCodeBase.enuRestriction.None
            TxtAccountName.XOSearchBoxText = "Type then press Enter"
            TxtAccountName.XOSQLText = ""
            TxtAccountName.XOTanpaSpasi = False
            TxtAccountName.XOValidasiField = Nothing
            ' 
            ' Lbl5
            ' 
            Lbl5.AutoSize = True
            Lbl5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Lbl5.Location = New Point(39, 295)
            Lbl5.Margin = New Padding(6, 0, 6, 0)
            Lbl5.Name = "Lbl5"
            Lbl5.Size = New Size(172, 32)
            Lbl5.TabIndex = 10
            Lbl5.Text = "Account Name"
            Lbl5.XOCustomElipsis = False
            ' 
            ' ChkEnable
            ' 
            ChkEnable.AutoSize = True
            ChkEnable.BackColor = Color.Transparent
            ChkEnable.FlatStyle = FlatStyle.Flat
            ChkEnable.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkEnable.Location = New Point(234, 355)
            ChkEnable.Margin = New Padding(6, 5, 6, 5)
            ChkEnable.Name = "ChkEnable"
            ChkEnable.Size = New Size(267, 36)
            ChkEnable.TabIndex = 5
            ChkEnable.Text = "Enable for transaction"
            ChkEnable.UseVisualStyleBackColor = False
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(322, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 8
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' FRMacgrEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(917, 780)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMacgrEditor"
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
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents Lbl5 As CMCv.UI.Control.lbl
        Friend WithEvents TxtAccountName As CMCv.UI.Control.txt
        Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
        Friend WithEvents TxtAccountNumber As CMCv.UI.Control.txt
        Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
        Friend WithEvents CboAccountGroup As CMCv.UI.Control.cbo
        Friend WithEvents Lbl2 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
        Friend WithEvents CboAccountingBook As CMCv.UI.Control.cbo
        Friend WithEvents CboCompany As CMCv.UI.Control.cbo
        Friend WithEvents ChkAddNew As CMCv.UI.Control.chk
        Friend WithEvents ChkEnable As CMCv.UI.Control.chk

    End Class
End Namespace