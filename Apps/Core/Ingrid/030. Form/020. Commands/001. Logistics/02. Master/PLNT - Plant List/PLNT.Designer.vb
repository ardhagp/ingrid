<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PLNT
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnPLNT = New CMCv.dgn(Me.components)
        Me.plant_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_name2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_postalcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_searchterm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plant_searchterm2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnPLNT, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnPLNT)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnPLNT, 0)
        '
        'DgnPLNT
        '
        Me.DgnPLNT.AllowUserToAddRows = False
        Me.DgnPLNT.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.DgnPLNT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnPLNT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnPLNT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnPLNT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnPLNT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnPLNT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnPLNT.ColumnHeadersHeight = 43
        Me.DgnPLNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnPLNT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.plant_id, Me.plant_code, Me.plant_name, Me.plant_name2, Me.plant_description, Me.plant_city, Me.plant_postalcode, Me.plant_searchterm1, Me.plant_searchterm2})
        Me.DgnPLNT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnPLNT.EnableHeadersVisualStyles = False
        Me.DgnPLNT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnPLNT.Location = New System.Drawing.Point(0, 46)
        Me.DgnPLNT.Name = "DgnPLNT"
        Me.DgnPLNT.ReadOnly = True
        Me.DgnPLNT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnPLNT.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnPLNT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnPLNT.Size = New System.Drawing.Size(784, 439)
        Me.DgnPLNT.SLFGroupFirstRows = False
        Me.DgnPLNT.SLFGunakanNomorBaris = True
        Me.DgnPLNT.StandardTab = True
        Me.DgnPLNT.TabIndex = 1
        '
        'plant_id
        '
        Me.plant_id.DataPropertyName = "plant_id"
        Me.plant_id.HeaderText = "ID"
        Me.plant_id.Name = "plant_id"
        Me.plant_id.ReadOnly = True
        Me.plant_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_id.Visible = False
        '
        'plant_code
        '
        Me.plant_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.plant_code.DataPropertyName = "plant_code"
        Me.plant_code.HeaderText = "Code"
        Me.plant_code.Name = "plant_code"
        Me.plant_code.ReadOnly = True
        Me.plant_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.plant_code.Width = 41
        '
        'plant_name
        '
        Me.plant_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.plant_name.DataPropertyName = "plant_name"
        Me.plant_name.HeaderText = "Name 1"
        Me.plant_name.Name = "plant_name"
        Me.plant_name.ReadOnly = True
        Me.plant_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_name.Width = 68
        '
        'plant_name2
        '
        Me.plant_name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.plant_name2.DataPropertyName = "plant_name2"
        Me.plant_name2.HeaderText = "Name 2"
        Me.plant_name2.Name = "plant_name2"
        Me.plant_name2.ReadOnly = True
        Me.plant_name2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_name2.Width = 68
        '
        'plant_description
        '
        Me.plant_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.plant_description.DataPropertyName = "plant_description"
        Me.plant_description.HeaderText = "Description"
        Me.plant_description.Name = "plant_description"
        Me.plant_description.ReadOnly = True
        Me.plant_description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_description.Width = 5
        '
        'plant_city
        '
        Me.plant_city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.plant_city.DataPropertyName = "plant_city"
        Me.plant_city.HeaderText = "City"
        Me.plant_city.Name = "plant_city"
        Me.plant_city.ReadOnly = True
        Me.plant_city.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_city.Width = 53
        '
        'plant_postalcode
        '
        Me.plant_postalcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.plant_postalcode.DataPropertyName = "plant_postalcode"
        Me.plant_postalcode.HeaderText = "Postal Code"
        Me.plant_postalcode.Name = "plant_postalcode"
        Me.plant_postalcode.ReadOnly = True
        Me.plant_postalcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_postalcode.Width = 90
        '
        'plant_searchterm1
        '
        Me.plant_searchterm1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.plant_searchterm1.DataPropertyName = "plant_searchterm1"
        Me.plant_searchterm1.HeaderText = "Search Term 1"
        Me.plant_searchterm1.Name = "plant_searchterm1"
        Me.plant_searchterm1.ReadOnly = True
        Me.plant_searchterm1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_searchterm1.Width = 94
        '
        'plant_searchterm2
        '
        Me.plant_searchterm2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.plant_searchterm2.DataPropertyName = "plant_searchterm2"
        Me.plant_searchterm2.HeaderText = "Search Term 2"
        Me.plant_searchterm2.Name = "plant_searchterm2"
        Me.plant_searchterm2.ReadOnly = True
        Me.plant_searchterm2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.plant_searchterm2.Width = 94
        '
        'PLNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "PLNT"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnPLNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnPLNT As CMCv.dgn
    Friend WithEvents plant_id As DataGridViewTextBoxColumn
    Friend WithEvents plant_code As DataGridViewTextBoxColumn
    Friend WithEvents plant_name As DataGridViewTextBoxColumn
    Friend WithEvents plant_name2 As DataGridViewTextBoxColumn
    Friend WithEvents plant_description As DataGridViewTextBoxColumn
    Friend WithEvents plant_city As DataGridViewTextBoxColumn
    Friend WithEvents plant_postalcode As DataGridViewTextBoxColumn
    Friend WithEvents plant_searchterm1 As DataGridViewTextBoxColumn
    Friend WithEvents plant_searchterm2 As DataGridViewTextBoxColumn
End Class
