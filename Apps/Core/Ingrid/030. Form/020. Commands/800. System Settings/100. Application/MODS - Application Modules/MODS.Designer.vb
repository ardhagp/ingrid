<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MODS
    Inherits CMCv.Std_Fi

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnMODS = New CMCv.dgn(Me.components)
        Me.modulegroup_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_issystem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.module_ismaintenance = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.module_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnMODS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'TxtFind
        '
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnMODS)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnMODS, 0)
        '
        'DgnMODS
        '
        Me.DgnMODS.AllowUserToAddRows = False
        Me.DgnMODS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.DgnMODS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnMODS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnMODS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnMODS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnMODS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMODS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnMODS.ColumnHeadersHeight = 43
        Me.DgnMODS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnMODS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.modulegroup_name, Me.module_code, Me.module_name, Me.module_description, Me.module_issystem, Me.module_ismaintenance, Me.module_id})
        Me.DgnMODS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnMODS.EnableHeadersVisualStyles = False
        Me.DgnMODS.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnMODS.Location = New System.Drawing.Point(0, 46)
        Me.DgnMODS.Name = "DgnMODS"
        Me.DgnMODS.ReadOnly = True
        Me.DgnMODS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMODS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgnMODS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnMODS.Size = New System.Drawing.Size(784, 439)
        Me.DgnMODS.SLFGroupFirstRows = True
        Me.DgnMODS.SLFGunakanNomorBaris = True
        Me.DgnMODS.StandardTab = True
        Me.DgnMODS.TabIndex = 802
        '
        'modulegroup_name
        '
        Me.modulegroup_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.modulegroup_name.DataPropertyName = "modulegroup_name"
        Me.modulegroup_name.HeaderText = "Group"
        Me.modulegroup_name.Name = "modulegroup_name"
        Me.modulegroup_name.ReadOnly = True
        Me.modulegroup_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.modulegroup_name.Width = 65
        '
        'module_code
        '
        Me.module_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.module_code.DataPropertyName = "module_code"
        Me.module_code.HeaderText = "Code"
        Me.module_code.Name = "module_code"
        Me.module_code.ReadOnly = True
        Me.module_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.module_code.Width = 60
        '
        'module_name
        '
        Me.module_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.module_name.DataPropertyName = "module_name"
        Me.module_name.HeaderText = "Module Name"
        Me.module_name.Name = "module_name"
        Me.module_name.ReadOnly = True
        Me.module_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.module_name.Width = 98
        '
        'module_description
        '
        Me.module_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.module_description.DataPropertyName = "module_description"
        Me.module_description.HeaderText = "Description"
        Me.module_description.Name = "module_description"
        Me.module_description.ReadOnly = True
        Me.module_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.module_description.Width = 94
        '
        'module_issystem
        '
        Me.module_issystem.DataPropertyName = "module_issystem"
        Me.module_issystem.HeaderText = "System Module"
        Me.module_issystem.Name = "module_issystem"
        Me.module_issystem.ReadOnly = True
        '
        'module_ismaintenance
        '
        Me.module_ismaintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.module_ismaintenance.DataPropertyName = "module_ismaintenance"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.NullValue = False
        Me.module_ismaintenance.DefaultCellStyle = DataGridViewCellStyle3
        Me.module_ismaintenance.HeaderText = "Lock For Maintenance"
        Me.module_ismaintenance.Name = "module_ismaintenance"
        Me.module_ismaintenance.ReadOnly = True
        Me.module_ismaintenance.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.module_ismaintenance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'module_id
        '
        Me.module_id.DataPropertyName = "module_id"
        Me.module_id.HeaderText = "ID"
        Me.module_id.Name = "module_id"
        Me.module_id.ReadOnly = True
        Me.module_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.module_id.Visible = False
        '
        'MODS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.KeyPreview = True
        Me.Name = "MODS"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnMODS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnMODS As CMCv.dgn
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents module_code As DataGridViewTextBoxColumn
    Friend WithEvents module_name As DataGridViewTextBoxColumn
    Friend WithEvents module_description As DataGridViewTextBoxColumn
    Friend WithEvents module_issystem As DataGridViewTextBoxColumn
    Friend WithEvents module_ismaintenance As DataGridViewCheckBoxColumn
    Friend WithEvents module_id As DataGridViewTextBoxColumn
End Class
