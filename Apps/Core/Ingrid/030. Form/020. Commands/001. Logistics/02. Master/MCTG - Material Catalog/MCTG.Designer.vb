<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCTG
    Inherits CMCv.Std_Fi

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
        Me.DgnMCTG = New CMCv.dgn(Me.components)
        Me.material_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material_longtext = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialtype_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material_isidentifier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.material_iscarrier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnMCTG, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnMCTG)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnMCTG, 0)
        '
        'DgnMCTG
        '
        Me.DgnMCTG.AllowUserToAddRows = False
        Me.DgnMCTG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.DgnMCTG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnMCTG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnMCTG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnMCTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnMCTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMCTG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnMCTG.ColumnHeadersHeight = 43
        Me.DgnMCTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnMCTG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material_id, Me.material_number, Me.material_name, Me.material_longtext, Me.materialgroup_code, Me.materialtype_code, Me.material_isidentifier, Me.material_iscarrier})
        Me.DgnMCTG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnMCTG.EnableHeadersVisualStyles = False
        Me.DgnMCTG.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnMCTG.Location = New System.Drawing.Point(0, 46)
        Me.DgnMCTG.Name = "DgnMCTG"
        Me.DgnMCTG.ReadOnly = True
        Me.DgnMCTG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMCTG.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnMCTG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnMCTG.Size = New System.Drawing.Size(784, 439)
        Me.DgnMCTG.SLFGroupFirstRows = False
        Me.DgnMCTG.SLFGunakanNomorBaris = True
        Me.DgnMCTG.StandardTab = True
        Me.DgnMCTG.TabIndex = 0
        '
        'material_id
        '
        Me.material_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.material_id.DataPropertyName = "material_id"
        Me.material_id.Frozen = True
        Me.material_id.HeaderText = "ID"
        Me.material_id.Name = "material_id"
        Me.material_id.ReadOnly = True
        Me.material_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.material_id.Width = 44
        '
        'material_number
        '
        Me.material_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.material_number.DataPropertyName = "material_number"
        Me.material_number.Frozen = True
        Me.material_number.HeaderText = "Number"
        Me.material_number.Name = "material_number"
        Me.material_number.ReadOnly = True
        Me.material_number.Width = 75
        '
        'material_name
        '
        Me.material_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.material_name.DataPropertyName = "material_name"
        Me.material_name.HeaderText = "Material Name"
        Me.material_name.Name = "material_name"
        Me.material_name.ReadOnly = True
        Me.material_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.material_name.Width = 103
        '
        'material_longtext
        '
        Me.material_longtext.DataPropertyName = "material_longtext"
        Me.material_longtext.HeaderText = "Long Text"
        Me.material_longtext.Name = "material_longtext"
        Me.material_longtext.ReadOnly = True
        Me.material_longtext.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.material_longtext.Width = 200
        '
        'materialgroup_code
        '
        Me.materialgroup_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.materialgroup_code.DataPropertyName = "materialgroup_code"
        Me.materialgroup_code.HeaderText = "Material Group"
        Me.materialgroup_code.Name = "materialgroup_code"
        Me.materialgroup_code.ReadOnly = True
        Me.materialgroup_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialgroup_code.Width = 104
        '
        'materialtype_code
        '
        Me.materialtype_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.materialtype_code.DataPropertyName = "materialtype_code"
        Me.materialtype_code.HeaderText = "Material Type"
        Me.materialtype_code.Name = "materialtype_code"
        Me.materialtype_code.ReadOnly = True
        Me.materialtype_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialtype_code.Width = 97
        '
        'material_isidentifier
        '
        Me.material_isidentifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.material_isidentifier.DataPropertyName = "material_isidentifier"
        Me.material_isidentifier.HeaderText = "IsID"
        Me.material_isidentifier.Name = "material_isidentifier"
        Me.material_isidentifier.ReadOnly = True
        Me.material_isidentifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.material_isidentifier.Width = 55
        '
        'material_iscarrier
        '
        Me.material_iscarrier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.material_iscarrier.DataPropertyName = "material_iscarrier"
        Me.material_iscarrier.HeaderText = "IsCa"
        Me.material_iscarrier.Name = "material_iscarrier"
        Me.material_iscarrier.ReadOnly = True
        Me.material_iscarrier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.material_iscarrier.Width = 57
        '
        'MCTG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.KeyPreview = True
        Me.Name = "MCTG"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnMCTG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents DgnMCTG As CMCv.dgn
    Friend WithEvents material_id As DataGridViewTextBoxColumn
    Friend WithEvents material_number As DataGridViewTextBoxColumn
    Friend WithEvents material_name As DataGridViewTextBoxColumn
    Friend WithEvents material_longtext As DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_code As DataGridViewTextBoxColumn
    Friend WithEvents materialtype_code As DataGridViewTextBoxColumn
    Friend WithEvents material_isidentifier As DataGridViewTextBoxColumn
    Friend WithEvents material_iscarrier As DataGridViewTextBoxColumn
End Class
