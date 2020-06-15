<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPLS_Position
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pnl1 = New CMCv.pnl(Me.components)
        Me.BtnClear = New CMCv.btn(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtFind = New CMCv.txt(Me.components)
        Me.DgnAddinPosition = New CMCv.dgn(Me.components)
        Me.position_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOk = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        CType(Me.DgnAddinPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnOk)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 353)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnOk, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnAddinPosition)
        Me.SLFPanel.Controls.Add(Me.Pnl1)
        Me.SLFPanel.Size = New System.Drawing.Size(657, 403)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Pnl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnAddinPosition, 0)
        '
        'Pnl1
        '
        Me.Pnl1.Controls.Add(Me.BtnClear)
        Me.Pnl1.Controls.Add(Me.Lbl1)
        Me.Pnl1.Controls.Add(Me.TxtFind)
        Me.Pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl1.Location = New System.Drawing.Point(0, 0)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(657, 46)
        Me.Pnl1.TabIndex = 1004
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
        Me.BtnClear.Location = New System.Drawing.Point(262, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(100, 40)
        Me.BtnClear.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClear.SLFTampilkanFocusBorder = False
        Me.BtnClear.SLFValidasiSemuaInput = False
        Me.BtnClear.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClear.TabIndex = 6
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
        Me.TxtFind.TabIndex = 4
        Me.TxtFind.Tag = "txt"
        '
        'DgnAddinPosition
        '
        Me.DgnAddinPosition.AllowUserToAddRows = False
        Me.DgnAddinPosition.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.DgnAddinPosition.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnAddinPosition.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnAddinPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnAddinPosition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnAddinPosition.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnAddinPosition.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnAddinPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgnAddinPosition.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.position_id, Me.company_code, Me.company_name, Me.departement_code, Me.departement_name, Me.position_code, Me.position_name})
        Me.DgnAddinPosition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnAddinPosition.EnableHeadersVisualStyles = False
        Me.DgnAddinPosition.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnAddinPosition.Location = New System.Drawing.Point(0, 46)
        Me.DgnAddinPosition.Name = "DgnAddinPosition"
        Me.DgnAddinPosition.ReadOnly = True
        Me.DgnAddinPosition.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnAddinPosition.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnAddinPosition.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnAddinPosition.Size = New System.Drawing.Size(657, 307)
        Me.DgnAddinPosition.SLFGroupFirstRows = False
        Me.DgnAddinPosition.SLFGunakanNomorBaris = True
        Me.DgnAddinPosition.StandardTab = True
        Me.DgnAddinPosition.TabIndex = 1005
        '
        'position_id
        '
        Me.position_id.DataPropertyName = "position_id"
        Me.position_id.Frozen = True
        Me.position_id.HeaderText = "ID"
        Me.position_id.Name = "position_id"
        Me.position_id.ReadOnly = True
        Me.position_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_id.Width = 75
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company Code"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_code.Width = 109
        '
        'company_name
        '
        Me.company_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.company_name.DataPropertyName = "company_name"
        Me.company_name.HeaderText = "Company Name"
        Me.company_name.Name = "company_name"
        Me.company_name.ReadOnly = True
        Me.company_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_name.Width = 112
        '
        'departement_code
        '
        Me.departement_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.departement_code.DataPropertyName = "departement_code"
        Me.departement_code.HeaderText = "Dept. Code"
        Me.departement_code.Name = "departement_code"
        Me.departement_code.ReadOnly = True
        Me.departement_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_code.Width = 87
        '
        'departement_name
        '
        Me.departement_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.departement_name.DataPropertyName = "departement_name"
        Me.departement_name.HeaderText = "Dept. Name"
        Me.departement_name.Name = "departement_name"
        Me.departement_name.ReadOnly = True
        Me.departement_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_name.Width = 90
        '
        'position_code
        '
        Me.position_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.position_code.DataPropertyName = "position_code"
        Me.position_code.HeaderText = "Position Code"
        Me.position_code.Name = "position_code"
        Me.position_code.ReadOnly = True
        Me.position_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_code.Width = 99
        '
        'position_name
        '
        Me.position_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.position_name.DataPropertyName = "position_name"
        Me.position_name.HeaderText = "Postition Name"
        Me.position_name.Name = "position_name"
        Me.position_name.ReadOnly = True
        Me.position_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_name.Width = 105
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnOk.FlatAppearance.BorderSize = 2
        Me.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(448, 6)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(100, 40)
        Me.BtnOk.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnOk.SLFTampilkanFocusBorder = False
        Me.BtnOk.SLFValidasiSemuaInput = False
        Me.BtnOk.SLFValidasiSemuaInputTag = Nothing
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(554, 6)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'EPLS_Position
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.KeyPreview = True
        Me.Name = "EPLS_Position"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        CType(Me.DgnAddinPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents BtnClear As CMCv.btn
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents TxtFind As CMCv.txt
    Friend WithEvents DgnAddinPosition As CMCv.dgn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnOk As CMCv.btn
    Friend WithEvents position_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents company_name As DataGridViewTextBoxColumn
    Friend WithEvents departement_code As DataGridViewTextBoxColumn
    Friend WithEvents departement_name As DataGridViewTextBoxColumn
    Friend WithEvents position_code As DataGridViewTextBoxColumn
    Friend WithEvents position_name As DataGridViewTextBoxColumn
End Class
