<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountingBook
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
        Me.MMSMenu = New VisualInheritanceFixer.MergeableMenuStrip()
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Pnl1 = New CMCv.pnl(Me.components)
        Me.BtnClear = New CMCv.btn(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtFind = New CMCv.txt(Me.components)
        Me.DgnAccountingBook = New CMCv.dgn(Me.components)
        Me.acbook_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acbook_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acbook_bookname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.acbook_datecreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.MMSMenu.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        CType(Me.DgnAccountingBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnAccountingBook)
        Me.SLFPanel.Controls.Add(Me.Pnl1)
        Me.SLFPanel.Controls.Add(Me.MMSMenu)
        '
        'MMSMenu
        '
        Me.MMSMenu.InheritedToolStrip = Me.SLFMenu
        Me.MMSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAToolStripMenuItem, Me.TOOLSToolStripMenuItem})
        Me.MMSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MMSMenu.Name = "MMSMenu"
        Me.MMSMenu.Size = New System.Drawing.Size(657, 24)
        Me.MMSMenu.TabIndex = 3
        Me.MMSMenu.Text = "MMS"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem2, Me.RefreshToolStripMenuItem, Me.ToolStripMenuItem3, Me.CloseToolStripMenuItem})
        Me.DATAToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.DATAToolStripMenuItem.MergeIndex = 1
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.DATAToolStripMenuItem.Text = "DATA"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AddNewToolStripMenuItem.Text = "Add New..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.EditToolStripMenuItem.Text = "Edit..."
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(172, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(172, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportsToolStripMenuItem, Me.ExportsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.TOOLSToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.TOOLSToolStripMenuItem.MergeIndex = 2
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.TOOLSToolStripMenuItem.Text = "TOOLS"
        '
        'ImportsToolStripMenuItem
        '
        Me.ImportsToolStripMenuItem.Name = "ImportsToolStripMenuItem"
        Me.ImportsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImportsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ImportsToolStripMenuItem.Text = "Imports..."
        '
        'ExportsToolStripMenuItem
        '
        Me.ExportsToolStripMenuItem.Name = "ExportsToolStripMenuItem"
        Me.ExportsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ExportsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExportsToolStripMenuItem.Text = "Exports..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 6)
        '
        'Pnl1
        '
        Me.Pnl1.Controls.Add(Me.BtnClear)
        Me.Pnl1.Controls.Add(Me.Lbl1)
        Me.Pnl1.Controls.Add(Me.TxtFind)
        Me.Pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl1.Location = New System.Drawing.Point(0, 24)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(657, 46)
        Me.Pnl1.TabIndex = 4
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
        Me.BtnClear.Location = New System.Drawing.Point(261, 3)
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
        Me.TxtFind.Location = New System.Drawing.Point(62, 10)
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
        Me.TxtFind.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtFind.SLFPilihSemuaSaatFokus = False
        Me.TxtFind.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtFind.SLFSQLText = Nothing
        Me.TxtFind.SLFTanpaSpasi = False
        Me.TxtFind.SLFValidasiField = Nothing
        Me.TxtFind.TabIndex = 4
        Me.TxtFind.Tag = "txt"
        '
        'DgnAccountingBook
        '
        Me.DgnAccountingBook.AllowUserToAddRows = False
        Me.DgnAccountingBook.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DgnAccountingBook.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnAccountingBook.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnAccountingBook.ColumnHeadersHeight = 43
        Me.DgnAccountingBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnAccountingBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.acbook_id, Me.plant_code, Me.acbook_code, Me.acbook_bookname, Me.acbook_datecreated})
        Me.DgnAccountingBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnAccountingBook.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnAccountingBook.Location = New System.Drawing.Point(0, 70)
        Me.DgnAccountingBook.Name = "DgnAccountingBook"
        Me.DgnAccountingBook.ReadOnly = True
        Me.DgnAccountingBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnAccountingBook.Size = New System.Drawing.Size(657, 267)
        Me.DgnAccountingBook.SLFGroupFirstRows = False
        Me.DgnAccountingBook.SLFGunakanNomorBaris = True
        Me.DgnAccountingBook.TabIndex = 5
        '
        'acbook_id
        '
        Me.acbook_id.DataPropertyName = "acbook_id"
        Me.acbook_id.HeaderText = "ID"
        Me.acbook_id.Name = "acbook_id"
        Me.acbook_id.ReadOnly = True
        Me.acbook_id.Visible = False
        '
        'plant_code
        '
        Me.plant_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.plant_code.DataPropertyName = "plant_code"
        Me.plant_code.HeaderText = "Plant"
        Me.plant_code.Name = "plant_code"
        Me.plant_code.ReadOnly = True
        Me.plant_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_code.Width = 60
        '
        'acbook_code
        '
        Me.acbook_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.acbook_code.DataPropertyName = "acbook_code"
        Me.acbook_code.HeaderText = "Code"
        Me.acbook_code.Name = "acbook_code"
        Me.acbook_code.ReadOnly = True
        Me.acbook_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.acbook_code.Width = 62
        '
        'acbook_bookname
        '
        Me.acbook_bookname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.acbook_bookname.DataPropertyName = "acbook_bookname"
        Me.acbook_bookname.HeaderText = "Book Name"
        Me.acbook_bookname.Name = "acbook_bookname"
        Me.acbook_bookname.ReadOnly = True
        Me.acbook_bookname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'acbook_datecreated
        '
        Me.acbook_datecreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.acbook_datecreated.DataPropertyName = "acbook_datecreated"
        Me.acbook_datecreated.HeaderText = "Created On"
        Me.acbook_datecreated.Name = "acbook_datecreated"
        Me.acbook_datecreated.ReadOnly = True
        Me.acbook_datecreated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.acbook_datecreated.Width = 90
        '
        'frmAccountingBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "frmAccountingBook"
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.MMSMenu.ResumeLayout(False)
        Me.MMSMenu.PerformLayout()
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        CType(Me.DgnAccountingBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMSMenu As VisualInheritanceFixer.MergeableMenuStrip
    Friend WithEvents DATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOOLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents BtnClear As CMCv.btn
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents TxtFind As CMCv.txt
    Friend WithEvents DgnAccountingBook As CMCv.dgn
    Friend WithEvents acbook_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents plant_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acbook_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acbook_bookname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acbook_datecreated As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
