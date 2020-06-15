<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDIN
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
        Me.DgnCDIN = New CMCv.dgn(Me.components)
        Me.departement_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnCDIN, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnCDIN)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnCDIN, 0)
        '
        'DgnCDIN
        '
        Me.DgnCDIN.AllowUserToAddRows = False
        Me.DgnCDIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.DgnCDIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnCDIN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnCDIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnCDIN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnCDIN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnCDIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnCDIN.ColumnHeadersHeight = 43
        Me.DgnCDIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnCDIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.departement_id, Me.company_code, Me.departement_code, Me.departement_name, Me.departement_description})
        Me.DgnCDIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnCDIN.EnableHeadersVisualStyles = False
        Me.DgnCDIN.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnCDIN.Location = New System.Drawing.Point(0, 46)
        Me.DgnCDIN.Name = "DgnCDIN"
        Me.DgnCDIN.ReadOnly = True
        Me.DgnCDIN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnCDIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnCDIN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnCDIN.Size = New System.Drawing.Size(784, 439)
        Me.DgnCDIN.SLFGroupFirstRows = False
        Me.DgnCDIN.SLFGunakanNomorBaris = True
        Me.DgnCDIN.StandardTab = True
        Me.DgnCDIN.TabIndex = 0
        '
        'departement_id
        '
        Me.departement_id.DataPropertyName = "departement_id"
        Me.departement_id.HeaderText = "ID"
        Me.departement_id.Name = "departement_id"
        Me.departement_id.ReadOnly = True
        Me.departement_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_id.Visible = False
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company Code"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_code.Width = 109
        '
        'departement_code
        '
        Me.departement_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.departement_code.DataPropertyName = "departement_code"
        Me.departement_code.HeaderText = "Departement Code"
        Me.departement_code.Name = "departement_code"
        Me.departement_code.ReadOnly = True
        Me.departement_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_code.Width = 127
        '
        'departement_name
        '
        Me.departement_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.departement_name.DataPropertyName = "departement_name"
        Me.departement_name.HeaderText = "Departement Name"
        Me.departement_name.Name = "departement_name"
        Me.departement_name.ReadOnly = True
        Me.departement_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_name.Width = 130
        '
        'departement_description
        '
        Me.departement_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.departement_description.DataPropertyName = "departement_description"
        Me.departement_description.HeaderText = "Description"
        Me.departement_description.Name = "departement_description"
        Me.departement_description.ReadOnly = True
        Me.departement_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'CDIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "CDIN"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnCDIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnCDIN As CMCv.dgn
    Friend WithEvents departement_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departement_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departement_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departement_description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
