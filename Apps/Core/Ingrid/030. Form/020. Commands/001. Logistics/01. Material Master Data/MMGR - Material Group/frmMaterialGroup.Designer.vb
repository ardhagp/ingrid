<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialGroup
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
        Me.Pnl1 = New CMCv.pnl(Me.components)
        Me.BtnClear = New CMCv.btn(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtFind = New CMCv.txt(Me.components)
        Me.DgnMaterialGroup = New CMCv.dgn(Me.components)
        Me.materialgroup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_description2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_language = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Pnl1.SuspendLayout()
        CType(Me.DgnMaterialGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMSMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnMaterialGroup)
        Me.SLFPanel.Controls.Add(Me.Pnl1)
        Me.SLFPanel.Controls.Add(Me.MMSMenu)
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
        Me.Pnl1.TabIndex = 0
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
        Me.BtnClear.TabIndex = 9
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
        Me.Lbl1.TabIndex = 8
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
        Me.TxtFind.SLFPilihSemuaSaatFokus = False
        Me.TxtFind.SLFTanpaSpasi = False
        Me.TxtFind.SLFValidasiField = Nothing
        Me.TxtFind.TabIndex = 7
        Me.TxtFind.Tag = "txt"
        '
        'DgnMaterialGroup
        '
        Me.DgnMaterialGroup.AllowUserToAddRows = False
        Me.DgnMaterialGroup.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgnMaterialGroup.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnMaterialGroup.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnMaterialGroup.ColumnHeadersHeight = 43
        Me.DgnMaterialGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnMaterialGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.materialgroup_id, Me.materialgroup_description, Me.materialgroup_description2, Me.materialgroup_language})
        Me.DgnMaterialGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnMaterialGroup.Location = New System.Drawing.Point(0, 70)
        Me.DgnMaterialGroup.Name = "DgnMaterialGroup"
        Me.DgnMaterialGroup.ReadOnly = True
        Me.DgnMaterialGroup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnMaterialGroup.Size = New System.Drawing.Size(657, 267)
        Me.DgnMaterialGroup.SLFGunakanNomorBaris = True
        Me.DgnMaterialGroup.TabIndex = 1
        '
        'materialgroup_id
        '
        Me.materialgroup_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.materialgroup_id.DataPropertyName = "materialgroup_id"
        Me.materialgroup_id.HeaderText = "Group ID"
        Me.materialgroup_id.Name = "materialgroup_id"
        Me.materialgroup_id.ReadOnly = True
        Me.materialgroup_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialgroup_id.Width = 69
        '
        'materialgroup_description
        '
        Me.materialgroup_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.materialgroup_description.DataPropertyName = "materialgroup_description"
        Me.materialgroup_description.HeaderText = "Description"
        Me.materialgroup_description.Name = "materialgroup_description"
        Me.materialgroup_description.ReadOnly = True
        Me.materialgroup_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialgroup_description.Width = 85
        '
        'materialgroup_description2
        '
        Me.materialgroup_description2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.materialgroup_description2.DataPropertyName = "materialgroup_description2"
        Me.materialgroup_description2.HeaderText = "Description 2"
        Me.materialgroup_description2.Name = "materialgroup_description2"
        Me.materialgroup_description2.ReadOnly = True
        Me.materialgroup_description2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'materialgroup_language
        '
        Me.materialgroup_language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.materialgroup_language.DataPropertyName = "materialgroup_language"
        Me.materialgroup_language.HeaderText = "Language"
        Me.materialgroup_language.Name = "materialgroup_language"
        Me.materialgroup_language.ReadOnly = True
        Me.materialgroup_language.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialgroup_language.Width = 80
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
        'frmMaterialGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "frmMaterialGroup"
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        CType(Me.DgnMaterialGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMSMenu.ResumeLayout(False)
        Me.MMSMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents DgnMaterialGroup As CMCv.dgn
    Friend WithEvents BtnClear As CMCv.btn
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents TxtFind As CMCv.txt
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
    Friend WithEvents materialgroup_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_description2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_language As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
