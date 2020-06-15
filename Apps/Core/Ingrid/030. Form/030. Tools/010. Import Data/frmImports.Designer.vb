<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImports
    Inherits CMCv.Std_Fo

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
        Me.Pnl1 = New CMCv.pnl(Me.components)
        Me.LblFileName = New CMCv.lbl(Me.components)
        Me.BtnBrowse = New CMCv.btn(Me.components)
        Me.TxtProgress = New CMCv.txt(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.od = New System.Windows.Forms.OpenFileDialog()
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.TxtProgress)
        Me.SLFPanel.Controls.Add(Me.Pnl1)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Pnl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtProgress, 0)
        '
        'Pnl1
        '
        Me.Pnl1.Controls.Add(Me.LblFileName)
        Me.Pnl1.Controls.Add(Me.BtnBrowse)
        Me.Pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl1.Location = New System.Drawing.Point(0, 0)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(657, 46)
        Me.Pnl1.TabIndex = 1
        '
        'LblFileName
        '
        Me.LblFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFileName.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblFileName.Location = New System.Drawing.Point(118, 13)
        Me.LblFileName.Name = "LblFileName"
        Me.LblFileName.Size = New System.Drawing.Size(527, 23)
        Me.LblFileName.SLFCustomElipsis = True
        Me.LblFileName.TabIndex = 1
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.Orange
        Me.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.BorderSize = 2
        Me.BtnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBrowse.Location = New System.Drawing.Point(12, 3)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(100, 40)
        Me.BtnBrowse.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Custom
        Me.BtnBrowse.SLFTampilkanFocusBorder = False
        Me.BtnBrowse.SLFValidasiSemuaInput = False
        Me.BtnBrowse.SLFValidasiSemuaInputTag = Nothing
        Me.BtnBrowse.TabIndex = 0
        Me.BtnBrowse.Text = "Browse..."
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'TxtProgress
        '
        Me.TxtProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtProgress.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtProgress.Location = New System.Drawing.Point(0, 46)
        Me.TxtProgress.MaxLength = 2147483647
        Me.TxtProgress.Multiline = True
        Me.TxtProgress.Name = "TxtProgress"
        Me.TxtProgress.ReadOnly = True
        Me.TxtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtProgress.Size = New System.Drawing.Size(657, 245)
        Me.TxtProgress.SLFAutoTrim = False
        Me.TxtProgress.SLFHarusDiisi = False
        Me.TxtProgress.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtProgress.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtProgress.SLFHightlightSaatFokus = False
        Me.TxtProgress.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtProgress.SLFPilihSemuaSaatFokus = False
        Me.TxtProgress.SLFTanpaSpasi = False
        Me.TxtProgress.SLFValidasiField = Nothing
        Me.TxtProgress.TabIndex = 2
        Me.TxtProgress.Tag = "txt"
        Me.TxtProgress.WordWrap = False
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
        Me.BtnSave.Location = New System.Drawing.Point(545, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(439, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 40)
        Me.BtnClose.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClose.SLFTampilkanFocusBorder = False
        Me.BtnClose.SLFValidasiSemuaInput = False
        Me.BtnClose.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'od
        '
        Me.od.DefaultExt = "[*.csv]"
        Me.od.SupportMultiDottedExtensions = True
        Me.od.Title = "Browse file to import..."
        '
        'frmImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "frmImports"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.Pnl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents BtnBrowse As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents TxtProgress As CMCv.txt
    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents od As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblFileName As CMCv.lbl

End Class
