Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMpost
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
            DgnPOST = New dgn(components)
            company_code = New DataGridViewTextBoxColumn()
            departement_code = New DataGridViewTextBoxColumn()
            position_id = New DataGridViewTextBoxColumn()
            position_code = New DataGridViewTextBoxColumn()
            position_name = New DataGridViewTextBoxColumn()
            position_description = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnPOST, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnPOST)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnPOST, 0)
            ' 
            ' DgnPOST
            ' 
            DgnPOST.AllowUserToAddRows = False
            DgnPOST.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(214), CByte(239), CByte(92))
            DgnPOST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnPOST.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnPOST.BorderStyle = BorderStyle.None
            DgnPOST.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnPOST.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnPOST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnPOST.ColumnHeadersHeight = 43
            DgnPOST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnPOST.Columns.AddRange(New DataGridViewColumn() {company_code, departement_code, position_id, position_code, position_name, position_description})
            DgnPOST.Dock = DockStyle.Fill
            DgnPOST.EnableHeadersVisualStyles = False
            DgnPOST.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnPOST.Location = New Point(0, 88)
            DgnPOST.Margin = New Padding(6, 5, 6, 5)
            DgnPOST.Name = "DgnPOST"
            DgnPOST.ReadOnly = True
            DgnPOST.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnPOST.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnPOST.RowHeadersWidth = 62
            DgnPOST.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnPOST.Size = New Size(1307, 864)
            DgnPOST.StandardTab = True
            DgnPOST.TabIndex = 0
            DgnPOST.XOGroupFirstRows = False
            DgnPOST.XOGunakanNomorBaris = True
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "Company"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 117
            ' 
            ' departement_code
            ' 
            departement_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            departement_code.DataPropertyName = "departement_code"
            departement_code.HeaderText = "Departement"
            departement_code.MinimumWidth = 8
            departement_code.Name = "departement_code"
            departement_code.ReadOnly = True
            departement_code.SortMode = DataGridViewColumnSortMode.Programmatic
            departement_code.Width = 149
            ' 
            ' position_id
            ' 
            position_id.DataPropertyName = "position_id"
            position_id.HeaderText = "ID"
            position_id.MinimumWidth = 8
            position_id.Name = "position_id"
            position_id.ReadOnly = True
            position_id.SortMode = DataGridViewColumnSortMode.Programmatic
            position_id.Visible = False
            position_id.Width = 150
            ' 
            ' position_code
            ' 
            position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            position_code.DataPropertyName = "position_code"
            position_code.HeaderText = "Code"
            position_code.MinimumWidth = 8
            position_code.Name = "position_code"
            position_code.ReadOnly = True
            position_code.SortMode = DataGridViewColumnSortMode.Programmatic
            position_code.Width = 83
            ' 
            ' position_name
            ' 
            position_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            position_name.DataPropertyName = "position_name"
            position_name.HeaderText = "Position Name"
            position_name.MinimumWidth = 8
            position_name.Name = "position_name"
            position_name.ReadOnly = True
            position_name.SortMode = DataGridViewColumnSortMode.Programmatic
            position_name.Width = 148
            ' 
            ' position_description
            ' 
            position_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            position_description.DataPropertyName = "position_description"
            position_description.HeaderText = "Description"
            position_description.MinimumWidth = 8
            position_description.Name = "position_description"
            position_description.ReadOnly = True
            position_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMpost
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMpost"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnPOST, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnPOST As dgn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents departement_code As DataGridViewTextBoxColumn
        Friend WithEvents position_id As DataGridViewTextBoxColumn
        Friend WithEvents position_code As DataGridViewTextBoxColumn
        Friend WithEvents position_name As DataGridViewTextBoxColumn
        Friend WithEvents position_description As DataGridViewTextBoxColumn

    End Class
End Namespace