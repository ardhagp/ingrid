<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMplnt
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnPLNT = New dgn(components)
        plant_id = New DataGridViewTextBoxColumn()
        plant_code = New DataGridViewTextBoxColumn()
        plant_name = New DataGridViewTextBoxColumn()
        plant_name2 = New DataGridViewTextBoxColumn()
        plant_description = New DataGridViewTextBoxColumn()
        plant_city = New DataGridViewTextBoxColumn()
        plant_postalcode = New DataGridViewTextBoxColumn()
        plant_searchterm1 = New DataGridViewTextBoxColumn()
        plant_searchterm2 = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnPLNT, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnClear
        ' 
        BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        ' 
        ' TxtFind
        ' 
        TxtFind.Margin = New Padding(7, 5, 7, 5)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(DgnPLNT)
        SLFPanel.Size = New Size(1307, 952)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnPLNT, 0)
        ' 
        ' DgnPLNT
        ' 
        DgnPLNT.AllowUserToAddRows = False
        DgnPLNT.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(200), CByte(113))
        DgnPLNT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DgnPLNT.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnPLNT.BorderStyle = BorderStyle.None
        DgnPLNT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnPLNT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnPLNT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnPLNT.ColumnHeadersHeight = 43
        DgnPLNT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnPLNT.Columns.AddRange(New DataGridViewColumn() {plant_id, plant_code, plant_name, plant_name2, plant_description, plant_city, plant_postalcode, plant_searchterm1, plant_searchterm2})
        DgnPLNT.Dock = DockStyle.Fill
        DgnPLNT.EnableHeadersVisualStyles = False
        DgnPLNT.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnPLNT.Location = New Point(0, 88)
        DgnPLNT.Margin = New Padding(6, 5, 6, 5)
        DgnPLNT.Name = "DgnPLNT"
        DgnPLNT.ReadOnly = True
        DgnPLNT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnPLNT.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnPLNT.RowHeadersWidth = 62
        DgnPLNT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnPLNT.Size = New Size(1307, 864)
        DgnPLNT.StandardTab = True
        DgnPLNT.TabIndex = 1
        DgnPLNT.XOGroupFirstRows = False
        DgnPLNT.XOGunakanNomorBaris = True
        ' 
        ' plant_id
        ' 
        plant_id.DataPropertyName = "plant_id"
        plant_id.HeaderText = "ID"
        plant_id.MinimumWidth = 8
        plant_id.Name = "plant_id"
        plant_id.ReadOnly = True
        plant_id.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_id.Visible = False
        plant_id.Width = 150
        ' 
        ' plant_code
        ' 
        plant_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        plant_code.DataPropertyName = "plant_code"
        plant_code.HeaderText = "Code"
        plant_code.MinimumWidth = 8
        plant_code.Name = "plant_code"
        plant_code.ReadOnly = True
        plant_code.SortMode = DataGridViewColumnSortMode.NotSortable
        plant_code.Width = 53
        ' 
        ' plant_name
        ' 
        plant_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        plant_name.DataPropertyName = "plant_name"
        plant_name.HeaderText = "Name 1"
        plant_name.MinimumWidth = 8
        plant_name.Name = "plant_name"
        plant_name.ReadOnly = True
        plant_name.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_name.Width = 97
        ' 
        ' plant_name2
        ' 
        plant_name2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        plant_name2.DataPropertyName = "plant_name2"
        plant_name2.HeaderText = "Name 2"
        plant_name2.MinimumWidth = 8
        plant_name2.Name = "plant_name2"
        plant_name2.ReadOnly = True
        plant_name2.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_name2.Width = 97
        ' 
        ' plant_description
        ' 
        plant_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        plant_description.DataPropertyName = "plant_description"
        plant_description.HeaderText = "Description"
        plant_description.MinimumWidth = 8
        plant_description.Name = "plant_description"
        plant_description.ReadOnly = True
        plant_description.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_description.Width = 8
        ' 
        ' plant_city
        ' 
        plant_city.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        plant_city.DataPropertyName = "plant_city"
        plant_city.HeaderText = "City"
        plant_city.MinimumWidth = 8
        plant_city.Name = "plant_city"
        plant_city.ReadOnly = True
        plant_city.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_city.Width = 74
        ' 
        ' plant_postalcode
        ' 
        plant_postalcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        plant_postalcode.DataPropertyName = "plant_postalcode"
        plant_postalcode.HeaderText = "Postal Code"
        plant_postalcode.MinimumWidth = 8
        plant_postalcode.Name = "plant_postalcode"
        plant_postalcode.ReadOnly = True
        plant_postalcode.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_postalcode.Width = 129
        ' 
        ' plant_searchterm1
        ' 
        plant_searchterm1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        plant_searchterm1.DataPropertyName = "plant_searchterm1"
        plant_searchterm1.HeaderText = "Search Term 1"
        plant_searchterm1.MinimumWidth = 8
        plant_searchterm1.Name = "plant_searchterm1"
        plant_searchterm1.ReadOnly = True
        plant_searchterm1.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_searchterm1.Width = 130
        ' 
        ' plant_searchterm2
        ' 
        plant_searchterm2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        plant_searchterm2.DataPropertyName = "plant_searchterm2"
        plant_searchterm2.HeaderText = "Search Term 2"
        plant_searchterm2.MinimumWidth = 8
        plant_searchterm2.Name = "plant_searchterm2"
        plant_searchterm2.ReadOnly = True
        plant_searchterm2.SortMode = DataGridViewColumnSortMode.Programmatic
        plant_searchterm2.Width = 130
        ' 
        ' FRMplnt
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1307, 1078)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMplnt"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnPLNT, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnPLNT As dgn
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
