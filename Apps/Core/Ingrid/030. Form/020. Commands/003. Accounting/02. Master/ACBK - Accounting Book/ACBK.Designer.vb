<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACBK
    Inherits CMCv.frmStandard

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pnl1 = New CMCv.pnl(Me.components)
        Me.BtnClear = New CMCv.btn(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtFind = New CMCv.txt(Me.components)
        Me.DgnACBK = New CMCv.dgn(Me.components)
        Me.book_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_bookname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.book_datecreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        CType(Me.DgnACBK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnACBK)
        Me.SLFPanel.Controls.Add(Me.Pnl1)
        '
        'Pnl1
        '
        Me.Pnl1.Controls.Add(Me.BtnClear)
        Me.Pnl1.Controls.Add(Me.Lbl1)
        Me.Pnl1.Controls.Add(Me.TxtFind)
        Me.Pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl1.Location = New System.Drawing.Point(0, 0)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(784, 46)
        Me.Pnl1.TabIndex = 800
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Red
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(262, 3)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(100, 40)
        Me.BtnClear.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClear.SLFTampilkanFocusBorder = False
        Me.BtnClear.SLFValidasiSemuaInput = False
        Me.BtnClear.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClear.TabIndex = 801
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(12, 13)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(40, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 5
        Me.Lbl1.Text = "Find"
        '
        'TxtFind
        '
        Me.TxtFind.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtFind.Location = New System.Drawing.Point(63, 10)
        Me.TxtFind.MaxLength = 255
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(193, 29)
        Me.TxtFind.SLFAutoTrim = False
        Me.TxtFind.SLFHarusDiisi = False
        Me.TxtFind.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtFind.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtFind.SLFHightlightSaatFokus = False
        Me.TxtFind.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtFind.SLFIsBlank = True
        Me.TxtFind.SLFIsSearchBox = False
        Me.TxtFind.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtFind.SLFPilihSemuaSaatFokus = False
        Me.TxtFind.SLFPwdLengthMin = 8
        Me.TxtFind.SLFPwdStrengthCalculate = False
        Me.TxtFind.SLFPwdStrengthScore = 0
        Me.TxtFind.SLFPwdStrengthText = Nothing
        Me.TxtFind.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFind.SLFSearchBoxText = "Type then press Enter"
        Me.TxtFind.SLFSQLText = Nothing
        Me.TxtFind.SLFTanpaSpasi = False
        Me.TxtFind.SLFValidasiField = Nothing
        Me.TxtFind.TabIndex = 800
        Me.TxtFind.Tag = "txt"
        '
        'DgnACBK
        '
        Me.DgnACBK.AllowUserToAddRows = False
        Me.DgnACBK.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DgnACBK.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnACBK.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnACBK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnACBK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnACBK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnACBK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnACBK.ColumnHeadersHeight = 43
        Me.DgnACBK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnACBK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.book_id, Me.company_code, Me.book_code, Me.book_bookname, Me.book_datecreated})
        Me.DgnACBK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnACBK.EnableHeadersVisualStyles = False
        Me.DgnACBK.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnACBK.Location = New System.Drawing.Point(0, 46)
        Me.DgnACBK.Name = "DgnACBK"
        Me.DgnACBK.ReadOnly = True
        Me.DgnACBK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnACBK.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgnACBK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnACBK.Size = New System.Drawing.Size(784, 439)
        Me.DgnACBK.SLFGroupFirstRows = False
        Me.DgnACBK.SLFGunakanNomorBaris = True
        Me.DgnACBK.StandardTab = True
        Me.DgnACBK.TabIndex = 0
        '
        'book_id
        '
        Me.book_id.DataPropertyName = "book_id"
        Me.book_id.HeaderText = "ID"
        Me.book_id.Name = "book_id"
        Me.book_id.ReadOnly = True
        Me.book_id.Visible = False
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_code.Width = 85
        '
        'book_code
        '
        Me.book_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.book_code.DataPropertyName = "book_code"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.GreenYellow
        Me.book_code.DefaultCellStyle = DataGridViewCellStyle3
        Me.book_code.HeaderText = "Acc Book Code"
        Me.book_code.Name = "book_code"
        Me.book_code.ReadOnly = True
        Me.book_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.book_code.Width = 80
        '
        'book_bookname
        '
        Me.book_bookname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.book_bookname.DataPropertyName = "book_bookname"
        Me.book_bookname.HeaderText = "Book Name"
        Me.book_bookname.Name = "book_bookname"
        Me.book_bookname.ReadOnly = True
        Me.book_bookname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.book_bookname.Width = 88
        '
        'book_datecreated
        '
        Me.book_datecreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.book_datecreated.DataPropertyName = "book_datecreated"
        Me.book_datecreated.HeaderText = "Created On"
        Me.book_datecreated.Name = "book_datecreated"
        Me.book_datecreated.ReadOnly = True
        Me.book_datecreated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'ACBK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "ACBK"
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        CType(Me.DgnACBK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents BtnClear As CMCv.btn
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents TxtFind As CMCv.txt
    Friend WithEvents DgnACBK As CMCv.dgn
    Friend WithEvents book_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents book_code As DataGridViewTextBoxColumn
    Friend WithEvents book_bookname As DataGridViewTextBoxColumn
    Friend WithEvents book_datecreated As DataGridViewTextBoxColumn
End Class
