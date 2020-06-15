<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountingBook_Editor
    Inherits CMCv.frmStandardPlusButtonContainer

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
        Me.Cbo1 = New CMCv.cbo(Me.components)
        Me.Txt1 = New CMCv.txt(Me.components)
        Me.Txt2 = New CMCv.txt(Me.components)
        Me.Txt3 = New CMCv.txt(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.Lbl3 = New CMCv.lbl(Me.components)
        Me.Lbl4 = New CMCv.lbl(Me.components)
        Me.Btn1 = New CMCv.btn(Me.components)
        Me.Btn2 = New CMCv.btn(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.Btn2)
        Me.PnlBottomButton.Controls.Add(Me.Btn1)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 203)
        Me.PnlBottomButton.Size = New System.Drawing.Size(495, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn1, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn2, 0)
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(361, 23)
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Size = New System.Drawing.Size(384, 46)
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
        Me.SLFPanel.Size = New System.Drawing.Size(495, 253)
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
        Me.Cbo1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Cbo1.FormattingEnabled = True
        Me.Cbo1.Location = New System.Drawing.Point(159, 17)
        Me.Cbo1.Name = "Cbo1"
        Me.Cbo1.Size = New System.Drawing.Size(121, 29)
        Me.Cbo1.TabIndex = 1
        '
        'Txt1
        '
        Me.Txt1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt1.Location = New System.Drawing.Point(159, 52)
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
        Me.Txt1.TabIndex = 2
        Me.Txt1.Tag = "txt"
        '
        'Txt2
        '
        Me.Txt2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt2.Location = New System.Drawing.Point(159, 87)
        Me.Txt2.MaxLength = 50
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(264, 29)
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
        Me.Txt2.TabIndex = 3
        Me.Txt2.Tag = "txt"
        '
        'Txt3
        '
        Me.Txt3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt3.Location = New System.Drawing.Point(159, 122)
        Me.Txt3.MaxLength = 255
        Me.Txt3.Multiline = True
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(264, 75)
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
        Me.Txt3.TabIndex = 4
        Me.Txt3.Tag = "txt"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(108, 20)
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
        Me.Lbl2.Location = New System.Drawing.Point(71, 55)
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
        Me.Lbl3.Location = New System.Drawing.Point(65, 90)
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
        Me.Lbl4.Location = New System.Drawing.Point(64, 125)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(89, 21)
        Me.Lbl4.SLFCustomElipsis = False
        Me.Lbl4.TabIndex = 8
        Me.Lbl4.Text = "Description"
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn1.FlatAppearance.BorderSize = 2
        Me.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn1.ForeColor = System.Drawing.Color.White
        Me.Btn1.Location = New System.Drawing.Point(277, 7)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(100, 40)
        Me.Btn1.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.Btn1.SLFTampilkanFocusBorder = False
        Me.Btn1.SLFValidasiSemuaInput = False
        Me.Btn1.SLFValidasiSemuaInputTag = Nothing
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Btn1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.Red
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn2.FlatAppearance.BorderSize = 2
        Me.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn2.ForeColor = System.Drawing.Color.White
        Me.Btn2.Location = New System.Drawing.Point(383, 7)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 40)
        Me.Btn2.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.Btn2.SLFTampilkanFocusBorder = False
        Me.Btn2.SLFValidasiSemuaInput = False
        Me.Btn2.SLFValidasiSemuaInputTag = Nothing
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Btn2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'frmAccountingBook_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(495, 395)
        Me.Name = "frmAccountingBook_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbo1 As CMCv.cbo
    Friend WithEvents Txt1 As CMCv.txt
    Friend WithEvents Btn2 As CMCv.btn
    Friend WithEvents Btn1 As CMCv.btn
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Txt3 As CMCv.txt
    Friend WithEvents Txt2 As CMCv.txt

End Class
