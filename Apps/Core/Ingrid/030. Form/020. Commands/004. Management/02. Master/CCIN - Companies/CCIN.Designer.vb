<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCIN
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
        Me.DgnCCIN = New CMCv.dgn(Me.components)
        Me.company_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_searchterm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_searchterm2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnCCIN, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnCCIN)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnCCIN, 0)
        '
        'DgnCCIN
        '
        Me.DgnCCIN.AllowUserToAddRows = False
        Me.DgnCCIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.DgnCCIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnCCIN.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnCCIN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnCCIN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnCCIN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnCCIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnCCIN.ColumnHeadersHeight = 43
        Me.DgnCCIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnCCIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.company_id, Me.company_code, Me.company_name, Me.company_searchterm1, Me.company_searchterm2, Me.company_description})
        Me.DgnCCIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnCCIN.EnableHeadersVisualStyles = False
        Me.DgnCCIN.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnCCIN.Location = New System.Drawing.Point(0, 46)
        Me.DgnCCIN.MultiSelect = False
        Me.DgnCCIN.Name = "DgnCCIN"
        Me.DgnCCIN.ReadOnly = True
        Me.DgnCCIN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnCCIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnCCIN.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnCCIN.Size = New System.Drawing.Size(784, 439)
        Me.DgnCCIN.SLFGroupFirstRows = False
        Me.DgnCCIN.SLFGunakanNomorBaris = True
        Me.DgnCCIN.StandardTab = True
        Me.DgnCCIN.TabIndex = 0
        '
        'company_id
        '
        Me.company_id.DataPropertyName = "company_id"
        Me.company_id.HeaderText = "Company ID"
        Me.company_id.Name = "company_id"
        Me.company_id.ReadOnly = True
        Me.company_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_id.Visible = False
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company Code"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_code.Width = 5
        '
        'company_name
        '
        Me.company_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.company_name.DataPropertyName = "company_name"
        Me.company_name.HeaderText = "Company Name"
        Me.company_name.Name = "company_name"
        Me.company_name.ReadOnly = True
        Me.company_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_name.Width = 112
        '
        'company_searchterm1
        '
        Me.company_searchterm1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.company_searchterm1.DataPropertyName = "company_searchterm1"
        Me.company_searchterm1.HeaderText = "Company Search Term 1"
        Me.company_searchterm1.Name = "company_searchterm1"
        Me.company_searchterm1.ReadOnly = True
        Me.company_searchterm1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_searchterm1.Width = 5
        '
        'company_searchterm2
        '
        Me.company_searchterm2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.company_searchterm2.DataPropertyName = "company_searchterm2"
        Me.company_searchterm2.HeaderText = "Company Search Term 2"
        Me.company_searchterm2.Name = "company_searchterm2"
        Me.company_searchterm2.ReadOnly = True
        Me.company_searchterm2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_searchterm2.Width = 5
        '
        'company_description
        '
        Me.company_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.company_description.DataPropertyName = "company_description"
        Me.company_description.HeaderText = "Description"
        Me.company_description.Name = "company_description"
        Me.company_description.ReadOnly = True
        Me.company_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'CCIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "CCIN"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnCCIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnCCIN As CMCv.dgn
    Friend WithEvents company_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_searchterm1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_searchterm2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
