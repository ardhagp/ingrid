Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmmgr
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
            DgnMMGR = New cmcv.ui.control.dgn(components)
            materialgroup_id = New DataGridViewTextBoxColumn()
            materialgroup_description = New DataGridViewTextBoxColumn()
            materialgroup_description2 = New DataGridViewTextBoxColumn()
            materialgroup_language = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMMGR, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMMGR)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMMGR, 0)
            ' 
            ' DgnMMGR
            ' 
            DgnMMGR.AllowUserToAddRows = False
            DgnMMGR.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(252), CByte(224), CByte(120))
            DgnMMGR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnMMGR.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMMGR.BorderStyle = BorderStyle.None
            DgnMMGR.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMMGR.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnMMGR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnMMGR.ColumnHeadersHeight = 43
            DgnMMGR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnMMGR.Columns.AddRange(New DataGridViewColumn() {materialgroup_id, materialgroup_description, materialgroup_description2, materialgroup_language})
            DgnMMGR.Dock = DockStyle.Fill
            DgnMMGR.EnableHeadersVisualStyles = False
            DgnMMGR.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMMGR.Location = New Point(0, 88)
            DgnMMGR.Margin = New Padding(6, 5, 6, 5)
            DgnMMGR.Name = "DgnMMGR"
            DgnMMGR.ReadOnly = True
            DgnMMGR.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMMGR.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMMGR.RowHeadersWidth = 62
            DgnMMGR.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMMGR.Size = New Size(1307, 864)
            DgnMMGR.StandardTab = True
            DgnMMGR.TabIndex = 0
            DgnMMGR.XOGroupFirstRows = False
            DgnMMGR.XOGunakanNomorBaris = True
            ' 
            ' materialgroup_id
            ' 
            materialgroup_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            materialgroup_id.DataPropertyName = "materialgroup_id"
            materialgroup_id.HeaderText = "Group ID"
            materialgroup_id.MinimumWidth = 8
            materialgroup_id.Name = "materialgroup_id"
            materialgroup_id.ReadOnly = True
            materialgroup_id.SortMode = DataGridViewColumnSortMode.Programmatic
            materialgroup_id.Width = 106
            ' 
            ' materialgroup_description
            ' 
            materialgroup_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            materialgroup_description.DataPropertyName = "materialgroup_description"
            materialgroup_description.HeaderText = "Description"
            materialgroup_description.MinimumWidth = 8
            materialgroup_description.Name = "materialgroup_description"
            materialgroup_description.ReadOnly = True
            materialgroup_description.SortMode = DataGridViewColumnSortMode.Programmatic
            materialgroup_description.Width = 134
            ' 
            ' materialgroup_description2
            ' 
            materialgroup_description2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            materialgroup_description2.DataPropertyName = "materialgroup_description2"
            materialgroup_description2.HeaderText = "Description 2"
            materialgroup_description2.MinimumWidth = 8
            materialgroup_description2.Name = "materialgroup_description2"
            materialgroup_description2.ReadOnly = True
            materialgroup_description2.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' materialgroup_language
            ' 
            materialgroup_language.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            materialgroup_language.DataPropertyName = "materialgroup_language"
            materialgroup_language.HeaderText = "Language"
            materialgroup_language.MinimumWidth = 8
            materialgroup_language.Name = "materialgroup_language"
            materialgroup_language.ReadOnly = True
            materialgroup_language.SortMode = DataGridViewColumnSortMode.Programmatic
            materialgroup_language.Width = 121
            ' 
            ' FRMmmgr
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmmgr"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMMGR, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMMGR As cmcv.ui.control.dgn
        Friend WithEvents materialgroup_id As DataGridViewTextBoxColumn
        Friend WithEvents materialgroup_description As DataGridViewTextBoxColumn
        Friend WithEvents materialgroup_description2 As DataGridViewTextBoxColumn
        Friend WithEvents materialgroup_language As DataGridViewTextBoxColumn

    End Class
End Namespace