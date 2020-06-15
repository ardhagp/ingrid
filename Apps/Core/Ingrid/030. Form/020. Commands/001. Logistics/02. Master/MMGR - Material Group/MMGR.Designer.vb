<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMGR
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
        Me.DgnMMGR = New CMCv.dgn(Me.components)
        Me.materialgroup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_description2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialgroup_language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnMMGR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnMMGR)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnMMGR, 0)
        '
        'DgnMMGR
        '
        Me.DgnMMGR.AllowUserToAddRows = False
        Me.DgnMMGR.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.DgnMMGR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnMMGR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnMMGR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnMMGR.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnMMGR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMMGR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnMMGR.ColumnHeadersHeight = 43
        Me.DgnMMGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnMMGR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.materialgroup_id, Me.materialgroup_description, Me.materialgroup_description2, Me.materialgroup_language})
        Me.DgnMMGR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnMMGR.EnableHeadersVisualStyles = False
        Me.DgnMMGR.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnMMGR.Location = New System.Drawing.Point(0, 46)
        Me.DgnMMGR.Name = "DgnMMGR"
        Me.DgnMMGR.ReadOnly = True
        Me.DgnMMGR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMMGR.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnMMGR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnMMGR.Size = New System.Drawing.Size(784, 439)
        Me.DgnMMGR.SLFGroupFirstRows = False
        Me.DgnMMGR.SLFGunakanNomorBaris = True
        Me.DgnMMGR.StandardTab = True
        Me.DgnMMGR.TabIndex = 0
        '
        'materialgroup_id
        '
        Me.materialgroup_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.materialgroup_id.DataPropertyName = "materialgroup_id"
        Me.materialgroup_id.HeaderText = "Group ID"
        Me.materialgroup_id.Name = "materialgroup_id"
        Me.materialgroup_id.ReadOnly = True
        Me.materialgroup_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialgroup_id.Width = 76
        '
        'materialgroup_description
        '
        Me.materialgroup_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.materialgroup_description.DataPropertyName = "materialgroup_description"
        Me.materialgroup_description.HeaderText = "Description"
        Me.materialgroup_description.Name = "materialgroup_description"
        Me.materialgroup_description.ReadOnly = True
        Me.materialgroup_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialgroup_description.Width = 94
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
        Me.materialgroup_language.Width = 85
        '
        'MMGR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "MMGR"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnMMGR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnMMGR As CMCv.dgn
    Friend WithEvents materialgroup_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_description2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialgroup_language As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
