<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOGS
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Pnl1 = New CMCv.pnl(Me.components)
        Me.BtnClear = New CMCv.btn(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtFind = New CMCv.txt(Me.components)
        Me.DgnMOG = New CMCv.dgn(Me.components)
        Me.modulegroup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modulegroup_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modulegroup_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modulegroup_order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        CType(Me.DgnMOG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnMOG)
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
        Me.Pnl1.TabIndex = 802
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
        Me.TxtFind.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFind.SLFSearchBoxText = "Type then press Enter"
        Me.TxtFind.SLFSQLText = Nothing
        Me.TxtFind.SLFTanpaSpasi = False
        Me.TxtFind.SLFValidasiField = Nothing
        Me.TxtFind.TabIndex = 800
        Me.TxtFind.Tag = "txt"
        '
        'DgnMOG
        '
        Me.DgnMOG.AllowUserToAddRows = False
        Me.DgnMOG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.DgnMOG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnMOG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnMOG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnMOG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnMOG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMOG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnMOG.ColumnHeadersHeight = 43
        Me.DgnMOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnMOG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modulegroup_id, Me.modulegroup_name, Me.modulegroup_description, Me.modulegroup_order})
        Me.DgnMOG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnMOG.EnableHeadersVisualStyles = False
        Me.DgnMOG.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnMOG.Location = New System.Drawing.Point(0, 46)
        Me.DgnMOG.Name = "DgnMOG"
        Me.DgnMOG.ReadOnly = True
        Me.DgnMOG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMOG.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnMOG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnMOG.Size = New System.Drawing.Size(784, 439)
        Me.DgnMOG.SLFGroupFirstRows = False
        Me.DgnMOG.SLFGunakanNomorBaris = True
        Me.DgnMOG.StandardTab = True
        Me.DgnMOG.TabIndex = 803
        '
        'modulegroup_id
        '
        Me.modulegroup_id.DataPropertyName = "modulegroup_id"
        Me.modulegroup_id.HeaderText = "ID"
        Me.modulegroup_id.Name = "modulegroup_id"
        Me.modulegroup_id.ReadOnly = True
        Me.modulegroup_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'modulegroup_name
        '
        Me.modulegroup_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.modulegroup_name.DataPropertyName = "modulegroup_name"
        Me.modulegroup_name.HeaderText = "Group Name"
        Me.modulegroup_name.Name = "modulegroup_name"
        Me.modulegroup_name.ReadOnly = True
        Me.modulegroup_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.modulegroup_name.Width = 94
        '
        'modulegroup_description
        '
        Me.modulegroup_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.modulegroup_description.DataPropertyName = "modulegroup_description"
        Me.modulegroup_description.HeaderText = "Description"
        Me.modulegroup_description.Name = "modulegroup_description"
        Me.modulegroup_description.ReadOnly = True
        Me.modulegroup_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'modulegroup_order
        '
        Me.modulegroup_order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.modulegroup_order.DataPropertyName = "modulegroup_order"
        Me.modulegroup_order.HeaderText = "Order Number"
        Me.modulegroup_order.Name = "modulegroup_order"
        Me.modulegroup_order.ReadOnly = True
        Me.modulegroup_order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.modulegroup_order.Width = 103
        '
        'MOGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "MOGS"
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        CType(Me.DgnMOG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents BtnClear As CMCv.btn
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents TxtFind As CMCv.txt
    Friend WithEvents DgnMOG As CMCv.dgn
    Friend WithEvents modulegroup_id As DataGridViewTextBoxColumn
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents modulegroup_description As DataGridViewTextBoxColumn
    Friend WithEvents modulegroup_order As DataGridViewTextBoxColumn
End Class
