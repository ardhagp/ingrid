<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMTY
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnMMTY = New CMCv.dgn(Me.components)
        Me.materialtype_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materialtype_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemcount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnMMTY, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnMMTY)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnMMTY, 0)
        '
        'DgnMMTY
        '
        Me.DgnMMTY.AllowUserToAddRows = False
        Me.DgnMMTY.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DgnMMTY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnMMTY.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnMMTY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnMMTY.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnMMTY.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMMTY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnMMTY.ColumnHeadersHeight = 43
        Me.DgnMMTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnMMTY.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.materialtype_id, Me.materialtype_description, Me.itemcount})
        Me.DgnMMTY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnMMTY.EnableHeadersVisualStyles = False
        Me.DgnMMTY.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnMMTY.Location = New System.Drawing.Point(0, 46)
        Me.DgnMMTY.Name = "DgnMMTY"
        Me.DgnMMTY.ReadOnly = True
        Me.DgnMMTY.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnMMTY.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgnMMTY.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnMMTY.Size = New System.Drawing.Size(784, 439)
        Me.DgnMMTY.SLFGroupFirstRows = False
        Me.DgnMMTY.SLFGunakanNomorBaris = True
        Me.DgnMMTY.StandardTab = True
        Me.DgnMMTY.TabIndex = 0
        '
        'materialtype_id
        '
        Me.materialtype_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.materialtype_id.DataPropertyName = "materialtype_id"
        Me.materialtype_id.HeaderText = "Material Type"
        Me.materialtype_id.Name = "materialtype_id"
        Me.materialtype_id.ReadOnly = True
        Me.materialtype_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.materialtype_id.Width = 5
        '
        'materialtype_description
        '
        Me.materialtype_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.materialtype_description.DataPropertyName = "materialtype_description"
        Me.materialtype_description.HeaderText = "Type Description"
        Me.materialtype_description.Name = "materialtype_description"
        Me.materialtype_description.ReadOnly = True
        Me.materialtype_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'itemcount
        '
        Me.itemcount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.itemcount.DataPropertyName = "itemcount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.itemcount.DefaultCellStyle = DataGridViewCellStyle3
        Me.itemcount.HeaderText = "Consist of"
        Me.itemcount.Name = "itemcount"
        Me.itemcount.ReadOnly = True
        Me.itemcount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.itemcount.Width = 5
        '
        'MMTY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "MMTY"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnMMTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnMMTY As CMCv.dgn
    Friend WithEvents materialtype_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents materialtype_description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemcount As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
