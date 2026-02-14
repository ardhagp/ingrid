Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMde001Editor
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
            BtnClose = New CMCv.UI.Control.btn(components)
            Txt1 = New CMCv.UI.Control.txt(components)
            LblNumber = New CMCv.UI.Control.lbl(components)
            Cbo1 = New CMCv.UI.Control.cbo(components)
            LblGroup = New CMCv.UI.Control.lbl(components)
            LblDate = New CMCv.UI.Control.lbl(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnClose)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 857)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(LblDate)
            SLFPanel.Controls.Add(LblGroup)
            SLFPanel.Controls.Add(Cbo1)
            SLFPanel.Controls.Add(LblNumber)
            SLFPanel.Controls.Add(Txt1)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Txt1, 0)
            SLFPanel.Controls.SetChildIndex(LblNumber, 0)
            SLFPanel.Controls.SetChildIndex(Cbo1, 0)
            SLFPanel.Controls.SetChildIndex(LblGroup, 0)
            SLFPanel.Controls.SetChildIndex(LblDate, 0)
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
            BtnSave.Location = New Point(943, 13)
            BtnSave.Margin = New Padding(5, 6, 5, 6)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 1
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
            BtnSave.XOTampilkanFocusBorder = False
            BtnSave.XOValidasiSemuaInput = False
            BtnSave.XOValidasiSemuaInputTag = Nothing
            ' 
            ' BtnClose
            ' 
            BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnClose.BackColor = Color.Red
            BtnClose.Cursor = Cursors.Hand
            BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClose.FlatAppearance.BorderSize = 2
            BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClose.FlatStyle = FlatStyle.Flat
            BtnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnClose.ForeColor = Color.White
            BtnClose.Location = New Point(1120, 13)
            BtnClose.Margin = New Padding(5, 6, 5, 6)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(167, 77)
            BtnClose.TabIndex = 2
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnClose.XOTampilkanFocusBorder = False
            BtnClose.XOValidasiSemuaInput = False
            BtnClose.XOValidasiSemuaInputTag = Nothing
            ' 
            ' Txt1
            ' 
            Txt1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt1.Location = New Point(235, 19)
            Txt1.Margin = New Padding(5, 6, 5, 6)
            Txt1.MaxLength = 255
            Txt1.Name = "Txt1"
            Txt1.Size = New Size(341, 39)
            Txt1.TabIndex = 996
            Txt1.Tag = "txt"
            Txt1.XOAutoTrim = False
            Txt1.XOHarusDiisi = False
            Txt1.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt1.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt1.XOHightlightSaatFokus = False
            Txt1.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt1.XOIsBlank = True
            Txt1.XOIsSearchBox = False
            Txt1.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt1.XOPilihSemuaSaatFokus = False
            Txt1.XOPwdLengthMin = 8
            Txt1.XOPwdStrengthCalculate = False
            Txt1.XOPwdStrengthScore = 0
            Txt1.XOPwdStrengthText = Nothing
            Txt1.XORestriction = ControlCodeBase.enuRestriction.None
            Txt1.XOSearchBoxText = "Type then press Enter"
            Txt1.XOSQLText = ""
            Txt1.XOTanpaSpasi = False
            Txt1.XOValidasiField = Nothing
            ' 
            ' LblNumber
            ' 
            LblNumber.AutoSize = True
            LblNumber.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            LblNumber.Location = New Point(87, 25)
            LblNumber.Margin = New Padding(5, 0, 5, 0)
            LblNumber.Name = "LblNumber"
            LblNumber.Size = New Size(128, 32)
            LblNumber.TabIndex = 997
            LblNumber.Text = "Manifest #"
            LblNumber.XOCustomElipsis = False
            ' 
            ' Cbo1
            ' 
            Cbo1.DropDownStyle = ComboBoxStyle.DropDownList
            Cbo1.FlatStyle = FlatStyle.Flat
            Cbo1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Cbo1.FormattingEnabled = True
            Cbo1.Location = New Point(235, 87)
            Cbo1.Margin = New Padding(5, 6, 5, 6)
            Cbo1.Name = "Cbo1"
            Cbo1.Size = New Size(199, 40)
            Cbo1.TabIndex = 998
            ' 
            ' LblGroup
            ' 
            LblGroup.AutoSize = True
            LblGroup.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            LblGroup.Location = New Point(28, 92)
            LblGroup.Margin = New Padding(5, 0, 5, 0)
            LblGroup.Name = "LblGroup"
            LblGroup.Size = New Size(180, 32)
            LblGroup.TabIndex = 999
            LblGroup.Text = "Manifest Group"
            LblGroup.XOCustomElipsis = False
            ' 
            ' LblDate
            ' 
            LblDate.AutoSize = True
            LblDate.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            LblDate.Location = New Point(630, 25)
            LblDate.Margin = New Padding(5, 0, 5, 0)
            LblDate.Name = "LblDate"
            LblDate.Size = New Size(154, 32)
            LblDate.TabIndex = 1000
            LblDate.Text = "Start Loading"
            LblDate.XOCustomElipsis = False
            ' 
            ' FRMde001Editor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1079)
            KeyPreview = True
            Margin = New Padding(22, 44, 22, 44)
            Name = "FRMde001Editor"
            PnlBottomButton.ResumeLayout(False)
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
        Friend WithEvents BtnClose As CMCv.UI.Control.btn
        Friend WithEvents LblNumber As CMCv.UI.Control.lbl
        Friend WithEvents Txt1 As CMCv.UI.Control.txt
        Friend WithEvents LblGroup As CMCv.UI.Control.lbl
        Friend WithEvents Cbo1 As CMCv.UI.Control.cbo
        Friend WithEvents LblDate As CMCv.UI.Control.lbl
    End Class
End Namespace