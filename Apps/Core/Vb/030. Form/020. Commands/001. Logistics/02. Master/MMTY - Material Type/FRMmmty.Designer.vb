Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmmty
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
            DgnMMTY = New cmcv.ui.control.dgn(components)
            materialtype_id = New DataGridViewTextBoxColumn()
            materialtype_description = New DataGridViewTextBoxColumn()
            itemcount = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMMTY, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMMTY)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMMTY, 0)
            ' 
            ' DgnMMTY
            ' 
            DgnMMTY.AllowUserToAddRows = False
            DgnMMTY.AllowUserToDeleteRows = False
            DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(252), CByte(230), CByte(174))
            DgnMMTY.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            DgnMMTY.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMMTY.BorderStyle = BorderStyle.None
            DgnMMTY.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMMTY.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMMTY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMMTY.ColumnHeadersHeight = 43
            DgnMMTY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnMMTY.Columns.AddRange(New DataGridViewColumn() {materialtype_id, materialtype_description, itemcount})
            DgnMMTY.Dock = DockStyle.Fill
            DgnMMTY.EnableHeadersVisualStyles = False
            DgnMMTY.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMMTY.Location = New Point(0, 88)
            DgnMMTY.Margin = New Padding(6, 5, 6, 5)
            DgnMMTY.Name = "DgnMMTY"
            DgnMMTY.ReadOnly = True
            DgnMMTY.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = Color.YellowGreen
            DataGridViewCellStyle8.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle8.SelectionForeColor = Color.Black
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
            DgnMMTY.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            DgnMMTY.RowHeadersWidth = 62
            DgnMMTY.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMMTY.Size = New Size(1307, 864)
            DgnMMTY.StandardTab = True
            DgnMMTY.TabIndex = 0
            DgnMMTY.XOIsGroupFirstRow = False
            DgnMMTY.XOIsShowRowNumber = True
            ' 
            ' materialtype_id
            ' 
            materialtype_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            materialtype_id.DataPropertyName = "materialtype_id"
            materialtype_id.HeaderText = "Material Type"
            materialtype_id.MinimumWidth = 8
            materialtype_id.Name = "materialtype_id"
            materialtype_id.ReadOnly = True
            materialtype_id.SortMode = DataGridViewColumnSortMode.Programmatic
            materialtype_id.Width = 8
            ' 
            ' materialtype_description
            ' 
            materialtype_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            materialtype_description.DataPropertyName = "materialtype_description"
            materialtype_description.HeaderText = "Type Description"
            materialtype_description.MinimumWidth = 8
            materialtype_description.Name = "materialtype_description"
            materialtype_description.ReadOnly = True
            materialtype_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' itemcount
            ' 
            itemcount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            itemcount.DataPropertyName = "itemcount"
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight
            itemcount.DefaultCellStyle = DataGridViewCellStyle7
            itemcount.HeaderText = "Consist of"
            itemcount.MinimumWidth = 8
            itemcount.Name = "itemcount"
            itemcount.ReadOnly = True
            itemcount.SortMode = DataGridViewColumnSortMode.Programmatic
            itemcount.Width = 8
            ' 
            ' FRMmmty
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmmty"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMMTY, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMMTY As cmcv.ui.control.dgn
        Friend WithEvents materialtype_id As DataGridViewTextBoxColumn
        Friend WithEvents materialtype_description As DataGridViewTextBoxColumn
        Friend WithEvents itemcount As DataGridViewTextBoxColumn

    End Class
End Namespace