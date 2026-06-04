Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmctg
        Inherits CMCv.FRMstandardFind

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
            DgnMCTG = New cmcv.ui.control.dgn(components)
            material_id = New DataGridViewTextBoxColumn()
            material_number = New DataGridViewTextBoxColumn()
            material_name = New DataGridViewTextBoxColumn()
            material_longtext = New DataGridViewTextBoxColumn()
            materialgroup_code = New DataGridViewTextBoxColumn()
            materialtype_code = New DataGridViewTextBoxColumn()
            material_isidentifier = New DataGridViewTextBoxColumn()
            material_iscarrier = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMCTG, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMCTG)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMCTG, 0)
            ' 
            ' DgnMCTG
            ' 
            DgnMCTG.AllowUserToAddRows = False
            DgnMCTG.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(221), CByte(232), CByte(185))
            DgnMCTG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnMCTG.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMCTG.BorderStyle = BorderStyle.None
            DgnMCTG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMCTG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnMCTG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnMCTG.ColumnHeadersHeight = 43
            DgnMCTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnMCTG.Columns.AddRange(New DataGridViewColumn() {material_id, material_number, material_name, material_longtext, materialgroup_code, materialtype_code, material_isidentifier, material_iscarrier})
            DgnMCTG.Dock = DockStyle.Fill
            DgnMCTG.EnableHeadersVisualStyles = False
            DgnMCTG.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMCTG.Location = New Point(0, 88)
            DgnMCTG.Margin = New Padding(6, 5, 6, 5)
            DgnMCTG.Name = "DgnMCTG"
            DgnMCTG.ReadOnly = True
            DgnMCTG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMCTG.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMCTG.RowHeadersWidth = 62
            DgnMCTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMCTG.Size = New Size(1307, 864)
            DgnMCTG.StandardTab = True
            DgnMCTG.TabIndex = 0
            DgnMCTG.XOGroupFirstRow = False
            DgnMCTG.XOShowRowNumber = True
            ' 
            ' material_id
            ' 
            material_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            material_id.DataPropertyName = "material_id"
            material_id.Frozen = True
            material_id.HeaderText = "ID"
            material_id.MinimumWidth = 8
            material_id.Name = "material_id"
            material_id.ReadOnly = True
            material_id.SortMode = DataGridViewColumnSortMode.Programmatic
            material_id.Width = 61
            ' 
            ' material_number
            ' 
            material_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            material_number.DataPropertyName = "material_number"
            material_number.Frozen = True
            material_number.HeaderText = "Number"
            material_number.MinimumWidth = 8
            material_number.Name = "material_number"
            material_number.ReadOnly = True
            material_number.Width = 105
            ' 
            ' material_name
            ' 
            material_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            material_name.DataPropertyName = "material_name"
            material_name.HeaderText = "Material Name"
            material_name.MinimumWidth = 8
            material_name.Name = "material_name"
            material_name.ReadOnly = True
            material_name.SortMode = DataGridViewColumnSortMode.Programmatic
            material_name.Width = 148
            ' 
            ' material_longtext
            ' 
            material_longtext.DataPropertyName = "material_longtext"
            material_longtext.HeaderText = "Long Text"
            material_longtext.MinimumWidth = 8
            material_longtext.Name = "material_longtext"
            material_longtext.ReadOnly = True
            material_longtext.SortMode = DataGridViewColumnSortMode.Programmatic
            material_longtext.Width = 200
            ' 
            ' materialgroup_code
            ' 
            materialgroup_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            materialgroup_code.DataPropertyName = "materialgroup_code"
            materialgroup_code.HeaderText = "Material Group"
            materialgroup_code.MinimumWidth = 8
            materialgroup_code.Name = "materialgroup_code"
            materialgroup_code.ReadOnly = True
            materialgroup_code.SortMode = DataGridViewColumnSortMode.Programmatic
            materialgroup_code.Width = 149
            ' 
            ' materialtype_code
            ' 
            materialtype_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            materialtype_code.DataPropertyName = "materialtype_code"
            materialtype_code.HeaderText = "Material Type"
            materialtype_code.MinimumWidth = 8
            materialtype_code.Name = "materialtype_code"
            materialtype_code.ReadOnly = True
            materialtype_code.SortMode = DataGridViewColumnSortMode.Programmatic
            materialtype_code.Width = 139
            ' 
            ' material_isidentifier
            ' 
            material_isidentifier.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            material_isidentifier.DataPropertyName = "material_isidentifier"
            material_isidentifier.HeaderText = "IsID"
            material_isidentifier.MinimumWidth = 8
            material_isidentifier.Name = "material_isidentifier"
            material_isidentifier.ReadOnly = True
            material_isidentifier.SortMode = DataGridViewColumnSortMode.Programmatic
            material_isidentifier.Width = 77
            ' 
            ' material_iscarrier
            ' 
            material_iscarrier.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            material_iscarrier.DataPropertyName = "material_iscarrier"
            material_iscarrier.HeaderText = "IsCa"
            material_iscarrier.MinimumWidth = 8
            material_iscarrier.Name = "material_iscarrier"
            material_iscarrier.ReadOnly = True
            material_iscarrier.SortMode = DataGridViewColumnSortMode.Programmatic
            material_iscarrier.Width = 79
            ' 
            ' FRMmctg
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmctg"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMCTG, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMCTG As cmcv.ui.control.dgn
        Friend WithEvents material_id As DataGridViewTextBoxColumn
        Friend WithEvents material_number As DataGridViewTextBoxColumn
        Friend WithEvents material_name As DataGridViewTextBoxColumn
        Friend WithEvents material_longtext As DataGridViewTextBoxColumn
        Friend WithEvents materialgroup_code As DataGridViewTextBoxColumn
        Friend WithEvents materialtype_code As DataGridViewTextBoxColumn
        Friend WithEvents material_isidentifier As DataGridViewTextBoxColumn
        Friend WithEvents material_iscarrier As DataGridViewTextBoxColumn
    End Class
End Namespace