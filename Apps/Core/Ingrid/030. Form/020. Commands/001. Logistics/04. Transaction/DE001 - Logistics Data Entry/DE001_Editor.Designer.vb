<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DE001_Editor
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
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.Txt1 = New CMCv.txt(Me.components)
        Me.LblNumber = New CMCv.lbl(Me.components)
        Me.Cbo1 = New CMCv.cbo(Me.components)
        Me.LblGroup = New CMCv.lbl(Me.components)
        Me.LblDate = New CMCv.lbl(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnClose, 0)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.LblDate)
        Me.SLFPanel.Controls.Add(Me.LblGroup)
        Me.SLFPanel.Controls.Add(Me.Cbo1)
        Me.SLFPanel.Controls.Add(Me.LblNumber)
        Me.SLFPanel.Controls.Add(Me.Txt1)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Txt1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.LblNumber, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Cbo1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.LblGroup, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.LblDate, 0)
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
        Me.BtnSave.Location = New System.Drawing.Point(566, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
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
        Me.BtnClose.Location = New System.Drawing.Point(672, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 40)
        Me.BtnClose.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClose.SLFTampilkanFocusBorder = False
        Me.BtnClose.SLFValidasiSemuaInput = False
        Me.BtnClose.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt1.Location = New System.Drawing.Point(141, 10)
        Me.Txt1.MaxLength = 255
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(206, 29)
        Me.Txt1.SLFAutoTrim = False
        Me.Txt1.SLFHarusDiisi = False
        Me.Txt1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt1.SLFHightlightSaatFokus = False
        Me.Txt1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt1.SLFIsBlank = True
        Me.Txt1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.Txt1.SLFPilihSemuaSaatFokus = False
        Me.Txt1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt1.SLFSQLText = ""
        Me.Txt1.SLFTanpaSpasi = False
        Me.Txt1.SLFValidasiField = Nothing
        Me.Txt1.TabIndex = 996
        Me.Txt1.Tag = "txt"
        '
        'LblNumber
        '
        Me.LblNumber.AutoSize = True
        Me.LblNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblNumber.Location = New System.Drawing.Point(52, 13)
        Me.LblNumber.Name = "LblNumber"
        Me.LblNumber.Size = New System.Drawing.Size(83, 21)
        Me.LblNumber.SLFCustomElipsis = False
        Me.LblNumber.TabIndex = 997
        Me.LblNumber.Text = "Manifest #"
        '
        'Cbo1
        '
        Me.Cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cbo1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Location = New System.Drawing.Point(141, 45)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(121, 29)
        Me.Cbo1.TabIndex = 998
        '
        'LblGroup
        '
        Me.LblGroup.AutoSize = True
        Me.LblGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblGroup.Location = New System.Drawing.Point(17, 48)
        Me.LblGroup.Name = "LblGroup"
        Me.LblGroup.Size = New System.Drawing.Size(118, 21)
        Me.LblGroup.SLFCustomElipsis = False
        Me.LblGroup.TabIndex = 999
        Me.LblGroup.Text = "Manifest Group"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblDate.Location = New System.Drawing.Point(378, 13)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(102, 21)
        Me.LblDate.SLFCustomElipsis = False
        Me.LblDate.TabIndex = 1000
        Me.LblDate.Text = "Start Loading"
        '
        'DE001_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "DE001_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents LblNumber As CMCv.lbl
    Friend WithEvents Txt1 As CMCv.txt
    Friend WithEvents LblGroup As CMCv.lbl
    Friend WithEvents Cbo1 As CMCv.cbo
    Friend WithEvents LblDate As CMCv.lbl
End Class
