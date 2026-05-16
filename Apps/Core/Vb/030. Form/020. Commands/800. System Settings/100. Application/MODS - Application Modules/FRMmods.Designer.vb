Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmods
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
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnMODS = New cmcv.ui.control.dgn(components)
            modulegroup_name = New DataGridViewTextBoxColumn()
            module_code = New DataGridViewTextBoxColumn()
            module_name = New DataGridViewTextBoxColumn()
            module_description = New DataGridViewTextBoxColumn()
            module_issystem = New DataGridViewTextBoxColumn()
            module_ismaintenance = New DataGridViewCheckBoxColumn()
            module_id = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMODS, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMODS)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMODS, 0)
            ' 
            ' DgnMODS
            ' 
            DgnMODS.AllowUserToAddRows = False
            DgnMODS.AllowUserToDeleteRows = False
            DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(225), CByte(204), CByte(94))
            DgnMODS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            DgnMODS.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMODS.BorderStyle = BorderStyle.None
            DgnMODS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMODS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMODS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMODS.ColumnHeadersHeight = 43
            DgnMODS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnMODS.Columns.AddRange(New DataGridViewColumn() {modulegroup_name, module_code, module_name, module_description, module_issystem, module_ismaintenance, module_id})
            DgnMODS.Dock = DockStyle.Fill
            DgnMODS.EnableHeadersVisualStyles = False
            DgnMODS.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMODS.Location = New Point(0, 88)
            DgnMODS.Margin = New Padding(6, 5, 6, 5)
            DgnMODS.Name = "DgnMODS"
            DgnMODS.ReadOnly = True
            DgnMODS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = Color.YellowGreen
            DataGridViewCellStyle8.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle8.SelectionForeColor = Color.Black
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
            DgnMODS.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            DgnMODS.RowHeadersWidth = 62
            DgnMODS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMODS.Size = New Size(1307, 864)
            DgnMODS.StandardTab = True
            DgnMODS.TabIndex = 802
            DgnMODS.XOGroupFirstRows = True
            DgnMODS.XOGunakanNomorBaris = True
            ' 
            ' modulegroup_name
            ' 
            modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            modulegroup_name.DataPropertyName = "modulegroup_name"
            modulegroup_name.HeaderText = "Group"
            modulegroup_name.MinimumWidth = 8
            modulegroup_name.Name = "modulegroup_name"
            modulegroup_name.ReadOnly = True
            modulegroup_name.SortMode = DataGridViewColumnSortMode.Programmatic
            modulegroup_name.Width = 90
            ' 
            ' module_code
            ' 
            module_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            module_code.DataPropertyName = "module_code"
            module_code.HeaderText = "Code"
            module_code.MinimumWidth = 8
            module_code.Name = "module_code"
            module_code.ReadOnly = True
            module_code.SortMode = DataGridViewColumnSortMode.Programmatic
            module_code.Width = 83
            ' 
            ' module_name
            ' 
            module_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            module_name.DataPropertyName = "module_name"
            module_name.HeaderText = "Module Name"
            module_name.MinimumWidth = 8
            module_name.Name = "module_name"
            module_name.ReadOnly = True
            module_name.SortMode = DataGridViewColumnSortMode.Programmatic
            module_name.Width = 141
            ' 
            ' module_description
            ' 
            module_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            module_description.DataPropertyName = "module_description"
            module_description.HeaderText = "Description"
            module_description.MinimumWidth = 8
            module_description.Name = "module_description"
            module_description.ReadOnly = True
            module_description.SortMode = DataGridViewColumnSortMode.Programmatic
            module_description.Width = 134
            ' 
            ' module_issystem
            ' 
            module_issystem.DataPropertyName = "module_issystem"
            module_issystem.HeaderText = "System Module"
            module_issystem.MinimumWidth = 8
            module_issystem.Name = "module_issystem"
            module_issystem.ReadOnly = True
            module_issystem.Width = 150
            ' 
            ' module_ismaintenance
            ' 
            module_ismaintenance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            module_ismaintenance.DataPropertyName = "module_ismaintenance"
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.NullValue = False
            module_ismaintenance.DefaultCellStyle = DataGridViewCellStyle7
            module_ismaintenance.HeaderText = "Lock For Maintenance"
            module_ismaintenance.MinimumWidth = 8
            module_ismaintenance.Name = "module_ismaintenance"
            module_ismaintenance.ReadOnly = True
            module_ismaintenance.Resizable = DataGridViewTriState.True
            module_ismaintenance.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' module_id
            ' 
            module_id.DataPropertyName = "module_id"
            module_id.HeaderText = "ID"
            module_id.MinimumWidth = 8
            module_id.Name = "module_id"
            module_id.ReadOnly = True
            module_id.SortMode = DataGridViewColumnSortMode.Programmatic
            module_id.Visible = False
            module_id.Width = 150
            ' 
            ' FRMmods
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmods"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMODS, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMODS As cmcv.ui.control.dgn
        Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
        Friend WithEvents module_code As DataGridViewTextBoxColumn
        Friend WithEvents module_name As DataGridViewTextBoxColumn
        Friend WithEvents module_description As DataGridViewTextBoxColumn
        Friend WithEvents module_issystem As DataGridViewTextBoxColumn
        Friend WithEvents module_ismaintenance As DataGridViewCheckBoxColumn
        Friend WithEvents module_id As DataGridViewTextBoxColumn
    End Class
End Namespace