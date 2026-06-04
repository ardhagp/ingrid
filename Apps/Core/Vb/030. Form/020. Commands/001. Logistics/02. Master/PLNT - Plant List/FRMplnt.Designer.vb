Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMplnt
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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnPLNT = New CMCv.UI.Control.dgn(components)
            plant_id = New DataGridViewTextBoxColumn()
            plant_code = New DataGridViewTextBoxColumn()
            plant_name = New DataGridViewTextBoxColumn()
            plant_name2 = New DataGridViewTextBoxColumn()
            plant_searchterm1 = New DataGridViewTextBoxColumn()
            plant_searchterm2 = New DataGridViewTextBoxColumn()
            plant_description = New DataGridViewTextBoxColumn()
            plant_postalcode = New DataGridViewTextBoxColumn()
            plant_address = New DataGridViewTextBoxColumn()
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
            SLFPanel.Size = New Size(1307, 946)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnPLNT, 0)
            ' 
            ' DgnPLNT
            ' 
            DgnPLNT.AllowUserToAddRows = False
            DgnPLNT.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(204), CByte(192), CByte(163))
            DgnPLNT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnPLNT.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnPLNT.BorderStyle = BorderStyle.None
            DgnPLNT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnPLNT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnPLNT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnPLNT.ColumnHeadersHeight = 43
            DgnPLNT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnPLNT.Columns.AddRange(New DataGridViewColumn() {plant_id, plant_code, plant_name, plant_name2, plant_searchterm1, plant_searchterm2, plant_description, plant_postalcode, plant_address})
            DgnPLNT.Dock = DockStyle.Fill
            DgnPLNT.EnableHeadersVisualStyles = False
            DgnPLNT.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
            DgnPLNT.Location = New Point(0, 88)
            DgnPLNT.Margin = New Padding(6, 5, 6, 5)
            DgnPLNT.Name = "DgnPLNT"
            DgnPLNT.ReadOnly = True
            DgnPLNT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnPLNT.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnPLNT.RowHeadersWidth = 62
            DgnPLNT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnPLNT.Size = New Size(1307, 858)
            DgnPLNT.StandardTab = True
            DgnPLNT.TabIndex = 1
            DgnPLNT.XOGroupFirstRow = False
            DgnPLNT.XOShowRowNumber = True
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
            plant_code.HeaderText = "CODE"
            plant_code.MinimumWidth = 8
            plant_code.Name = "plant_code"
            plant_code.ReadOnly = True
            plant_code.SortMode = DataGridViewColumnSortMode.NotSortable
            plant_code.Width = 58
            ' 
            ' plant_name
            ' 
            plant_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            plant_name.DataPropertyName = "plant_name"
            plant_name.HeaderText = "NAME 1"
            plant_name.MinimumWidth = 8
            plant_name.Name = "plant_name"
            plant_name.ReadOnly = True
            plant_name.SortMode = DataGridViewColumnSortMode.Programmatic
            plant_name.Width = 88
            ' 
            ' plant_name2
            ' 
            plant_name2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            plant_name2.DataPropertyName = "plant_name2"
            plant_name2.HeaderText = "NAME 2"
            plant_name2.MinimumWidth = 8
            plant_name2.Name = "plant_name2"
            plant_name2.ReadOnly = True
            plant_name2.SortMode = DataGridViewColumnSortMode.Programmatic
            plant_name2.Width = 88
            ' 
            ' plant_searchterm1
            ' 
            plant_searchterm1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            plant_searchterm1.DataPropertyName = "plant_searchterm1"
            plant_searchterm1.HeaderText = "SEARCH TERM 1"
            plant_searchterm1.MinimumWidth = 8
            plant_searchterm1.Name = "plant_searchterm1"
            plant_searchterm1.ReadOnly = True
            plant_searchterm1.SortMode = DataGridViewColumnSortMode.Programmatic
            plant_searchterm1.Width = 144
            ' 
            ' plant_searchterm2
            ' 
            plant_searchterm2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            plant_searchterm2.DataPropertyName = "plant_searchterm2"
            plant_searchterm2.HeaderText = "SEARCH TERM 2"
            plant_searchterm2.MinimumWidth = 8
            plant_searchterm2.Name = "plant_searchterm2"
            plant_searchterm2.ReadOnly = True
            plant_searchterm2.SortMode = DataGridViewColumnSortMode.Programmatic
            plant_searchterm2.Width = 144
            ' 
            ' plant_description
            ' 
            plant_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            plant_description.DataPropertyName = "plant_description"
            plant_description.HeaderText = "DESCRIPTION"
            plant_description.MinimumWidth = 8
            plant_description.Name = "plant_description"
            plant_description.ReadOnly = True
            plant_description.SortMode = DataGridViewColumnSortMode.Programmatic
            plant_description.Width = 155
            ' 
            ' plant_postalcode
            ' 
            plant_postalcode.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            plant_postalcode.DataPropertyName = "plant_postalcode"
            plant_postalcode.HeaderText = "POSTAL CODE"
            plant_postalcode.MinimumWidth = 8
            plant_postalcode.Name = "plant_postalcode"
            plant_postalcode.ReadOnly = True
            plant_postalcode.SortMode = DataGridViewColumnSortMode.Programmatic
            plant_postalcode.Width = 143
            ' 
            ' plant_address
            ' 
            plant_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            plant_address.DataPropertyName = "plant_address"
            plant_address.HeaderText = "ADDRESS"
            plant_address.MinimumWidth = 8
            plant_address.Name = "plant_address"
            plant_address.ReadOnly = True
            plant_address.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMplnt
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1307, 1078)
            ControlBox = False
            Margin = New Padding(10, 5, 10, 5)
            MaximizeBox = False
            MinimizeBox = False
            Name = "FRMplnt"
            ShowIcon = False
            ShowInTaskbar = False
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
        Friend WithEvents DgnPLNT As cmcv.ui.control.dgn
        Friend WithEvents plant_id As DataGridViewTextBoxColumn
        Friend WithEvents plant_code As DataGridViewTextBoxColumn
        Friend WithEvents plant_name As DataGridViewTextBoxColumn
        Friend WithEvents plant_name2 As DataGridViewTextBoxColumn
        Friend WithEvents plant_searchterm1 As DataGridViewTextBoxColumn
        Friend WithEvents plant_searchterm2 As DataGridViewTextBoxColumn
        Friend WithEvents plant_description As DataGridViewTextBoxColumn
        Friend WithEvents plant_postalcode As DataGridViewTextBoxColumn
        Friend WithEvents plant_address As DataGridViewTextBoxColumn
    End Class
End Namespace