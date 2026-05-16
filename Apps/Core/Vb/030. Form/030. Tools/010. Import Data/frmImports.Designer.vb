Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMimports
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
            Pnl1 = New CMCv.UI.Control.pnl(components)
            LblFileName = New CMCv.UI.Control.lbl(components)
            BtnBrowse = New CMCv.UI.Control.btn(components)
            TxtProgress = New CMCv.UI.Control.txt(components)
            BtnSave = New CMCv.UI.Control.btn(components)
            BtnClose = New CMCv.UI.Control.btn(components)
            od = New OpenFileDialog()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Pnl1.SuspendLayout()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnClose)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 699)
            PnlBottomButton.Size = New Size(1095, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Size = New Size(1095, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(TxtProgress)
            SLFPanel.Controls.Add(Pnl1)
            SLFPanel.Size = New Size(1095, 795)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Pnl1, 0)
            SLFPanel.Controls.SetChildIndex(TxtProgress, 0)
            ' 
            ' Pnl1
            ' 
            Pnl1.Controls.Add(LblFileName)
            Pnl1.Controls.Add(BtnBrowse)
            Pnl1.Dock = DockStyle.Top
            Pnl1.Location = New Point(0, 0)
            Pnl1.Margin = New Padding(5, 6, 5, 6)
            Pnl1.Name = "Pnl1"
            Pnl1.Size = New Size(1095, 88)
            Pnl1.TabIndex = 1
            ' 
            ' LblFileName
            ' 
            LblFileName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            LblFileName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            LblFileName.Location = New Point(197, 25)
            LblFileName.Margin = New Padding(5, 0, 5, 0)
            LblFileName.Name = "LblFileName"
            LblFileName.Size = New Size(879, 44)
            LblFileName.TabIndex = 1
            LblFileName.XOCustomElipsis = True
            ' 
            ' BtnBrowse
            ' 
            BtnBrowse.BackColor = Color.Orange
            BtnBrowse.Cursor = Cursors.Hand
            BtnBrowse.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(105), CByte(0))
            BtnBrowse.FlatAppearance.BorderSize = 2
            BtnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
            BtnBrowse.FlatStyle = FlatStyle.Flat
            BtnBrowse.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnBrowse.ForeColor = Color.White
            BtnBrowse.Location = New Point(20, 6)
            BtnBrowse.Margin = New Padding(5, 6, 5, 6)
            BtnBrowse.Name = "BtnBrowse"
            BtnBrowse.Size = New Size(167, 77)
            BtnBrowse.TabIndex = 0
            BtnBrowse.Text = "Browse..."
            BtnBrowse.UseVisualStyleBackColor = False
            BtnBrowse.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
            BtnBrowse.XOTampilkanFocusBorder = False
            BtnBrowse.XOValidasiSemuaInput = False
            BtnBrowse.XOValidasiSemuaInputTag = Nothing
            ' 
            ' TxtProgress
            ' 
            TxtProgress.Dock = DockStyle.Fill
            TxtProgress.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtProgress.Location = New Point(0, 88)
            TxtProgress.Margin = New Padding(5, 6, 5, 6)
            TxtProgress.MaxLength = Integer.MaxValue
            TxtProgress.Multiline = True
            TxtProgress.Name = "TxtProgress"
            TxtProgress.ReadOnly = True
            TxtProgress.ScrollBars = ScrollBars.Both
            TxtProgress.Size = New Size(1095, 611)
            TxtProgress.TabIndex = 2
            TxtProgress.Tag = "txt"
            TxtProgress.WordWrap = False
            TxtProgress.XOAutoTrim = False
            TxtProgress.XOHarusDiisi = False
            TxtProgress.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtProgress.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtProgress.XOHightlightSaatFokus = False
            TxtProgress.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtProgress.XOIsBlank = True
            TxtProgress.XOIsSearchBox = False
            TxtProgress.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtProgress.XOPilihSemuaSaatFokus = False
            TxtProgress.XOPwdLengthMin = 8
            TxtProgress.XOPwdStrengthCalculate = False
            TxtProgress.XOPwdStrengthScore = 0
            TxtProgress.XOPwdStrengthText = Nothing
            TxtProgress.XORestriction = ControlCodeBase.enuRestriction.None
            TxtProgress.XOSearchBoxText = "Type then press Enter"
            TxtProgress.XOSQLText = Nothing
            TxtProgress.XOTanpaSpasi = False
            TxtProgress.XOValidasiField = Nothing
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
            BtnSave.Location = New Point(696, 6)
            BtnSave.Margin = New Padding(5, 6, 5, 6)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 0
            BtnSave.Text = "Save"
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
            BtnClose.Location = New Point(520, 6)
            BtnClose.Margin = New Padding(5, 6, 5, 6)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(167, 77)
            BtnClose.TabIndex = 1
            BtnClose.Text = "Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnClose.XOTampilkanFocusBorder = False
            BtnClose.XOValidasiSemuaInput = False
            BtnClose.XOValidasiSemuaInputTag = Nothing
            ' 
            ' od
            ' 
            od.DefaultExt = "[*.csv]"
            od.SupportMultiDottedExtensions = True
            od.Title = "Browse file to import..."
            ' 
            ' FRMimports
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1095, 921)
            KeyPreview = True
            Margin = New Padding(22, 44, 22, 44)
            Name = "FRMimports"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Pnl1.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents Pnl1 As CMCv.UI.Control.pnl
        Friend WithEvents BtnBrowse As CMCv.UI.Control.btn
        Friend WithEvents BtnSave As CMCv.UI.Control.btn
        Friend WithEvents TxtProgress As CMCv.UI.Control.txt
        Friend WithEvents BtnClose As CMCv.UI.Control.btn
        Friend WithEvents od As System.Windows.Forms.OpenFileDialog
        Friend WithEvents LblFileName As CMCv.UI.Control.lbl

    End Class
End Namespace