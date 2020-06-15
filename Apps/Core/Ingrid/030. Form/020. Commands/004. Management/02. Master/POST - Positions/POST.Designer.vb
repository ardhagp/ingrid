<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POST
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
        Me.DgnPOST = New CMCv.dgn(Me.components)
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnPOST, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnPOST)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnPOST, 0)
        '
        'DgnPOST
        '
        Me.DgnPOST.AllowUserToAddRows = False
        Me.DgnPOST.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.DgnPOST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnPOST.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnPOST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnPOST.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnPOST.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnPOST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnPOST.ColumnHeadersHeight = 43
        Me.DgnPOST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnPOST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.company_code, Me.departement_code, Me.position_id, Me.position_code, Me.position_name, Me.position_description})
        Me.DgnPOST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnPOST.EnableHeadersVisualStyles = False
        Me.DgnPOST.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnPOST.Location = New System.Drawing.Point(0, 46)
        Me.DgnPOST.Name = "DgnPOST"
        Me.DgnPOST.ReadOnly = True
        Me.DgnPOST.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnPOST.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnPOST.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnPOST.Size = New System.Drawing.Size(784, 439)
        Me.DgnPOST.SLFGroupFirstRows = False
        Me.DgnPOST.SLFGunakanNomorBaris = True
        Me.DgnPOST.StandardTab = True
        Me.DgnPOST.TabIndex = 0
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_code.Width = 85
        '
        'departement_code
        '
        Me.departement_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.departement_code.DataPropertyName = "departement_code"
        Me.departement_code.HeaderText = "Departement"
        Me.departement_code.Name = "departement_code"
        Me.departement_code.ReadOnly = True
        Me.departement_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_code.Width = 105
        '
        'position_id
        '
        Me.position_id.DataPropertyName = "position_id"
        Me.position_id.HeaderText = "ID"
        Me.position_id.Name = "position_id"
        Me.position_id.ReadOnly = True
        Me.position_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_id.Visible = False
        '
        'position_code
        '
        Me.position_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.position_code.DataPropertyName = "position_code"
        Me.position_code.HeaderText = "Code"
        Me.position_code.Name = "position_code"
        Me.position_code.ReadOnly = True
        Me.position_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_code.Width = 60
        '
        'position_name
        '
        Me.position_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.position_name.DataPropertyName = "position_name"
        Me.position_name.HeaderText = "Position Name"
        Me.position_name.Name = "position_name"
        Me.position_name.ReadOnly = True
        Me.position_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_name.Width = 102
        '
        'position_description
        '
        Me.position_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.position_description.DataPropertyName = "position_description"
        Me.position_description.HeaderText = "Description"
        Me.position_description.Name = "position_description"
        Me.position_description.ReadOnly = True
        Me.position_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'POST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "POST"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnPOST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnPOST As CMCv.dgn
    Friend WithEvents company_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents departement_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents position_description As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
