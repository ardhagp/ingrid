Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMcdin
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
            DgnCDIN = New cmcv.ui.control.dgn(components)
            department_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            departement_code = New DataGridViewTextBoxColumn()
            departement_name = New DataGridViewTextBoxColumn()
            departement_description = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnCDIN, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnCDIN)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnCDIN, 0)
            ' 
            ' DgnCDIN
            ' 
            DgnCDIN.AllowUserToAddRows = False
            DgnCDIN.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(199), CByte(223), CByte(174))
            DgnCDIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnCDIN.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnCDIN.BorderStyle = BorderStyle.None
            DgnCDIN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnCDIN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnCDIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnCDIN.ColumnHeadersHeight = 43
            DgnCDIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnCDIN.Columns.AddRange(New DataGridViewColumn() {department_id, company_code, departement_code, departement_name, departement_description})
            DgnCDIN.Dock = DockStyle.Fill
            DgnCDIN.EnableHeadersVisualStyles = False
            DgnCDIN.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnCDIN.Location = New Point(0, 88)
            DgnCDIN.Margin = New Padding(6, 5, 6, 5)
            DgnCDIN.Name = "DgnCDIN"
            DgnCDIN.ReadOnly = True
            DgnCDIN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnCDIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnCDIN.RowHeadersWidth = 62
            DgnCDIN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnCDIN.Size = New Size(1307, 864)
            DgnCDIN.StandardTab = True
            DgnCDIN.TabIndex = 0
            DgnCDIN.XOGroupFirstRows = False
            DgnCDIN.XOGunakanNomorBaris = True
            ' 
            ' department_id
            ' 
            department_id.DataPropertyName = "department_id"
            department_id.HeaderText = "ID"
            department_id.MinimumWidth = 8
            department_id.Name = "department_id"
            department_id.ReadOnly = True
            department_id.SortMode = DataGridViewColumnSortMode.Programmatic
            department_id.Visible = False
            department_id.Width = 150
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "Company Code"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 151
            ' 
            ' departement_code
            ' 
            departement_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            departement_code.DataPropertyName = "departement_code"
            departement_code.HeaderText = "Departement Code"
            departement_code.MinimumWidth = 8
            departement_code.Name = "departement_code"
            departement_code.ReadOnly = True
            departement_code.SortMode = DataGridViewColumnSortMode.Programmatic
            departement_code.Width = 179
            ' 
            ' departement_name
            ' 
            departement_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            departement_name.DataPropertyName = "departement_name"
            departement_name.HeaderText = "Departement Name"
            departement_name.MinimumWidth = 8
            departement_name.Name = "departement_name"
            departement_name.ReadOnly = True
            departement_name.SortMode = DataGridViewColumnSortMode.Programmatic
            departement_name.Width = 185
            ' 
            ' departement_description
            ' 
            departement_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            departement_description.DataPropertyName = "departement_description"
            departement_description.HeaderText = "Description"
            departement_description.MinimumWidth = 8
            departement_description.Name = "departement_description"
            departement_description.ReadOnly = True
            departement_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMcdin
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMcdin"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnCDIN, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnCDIN As cmcv.ui.control.dgn
        Friend WithEvents department_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents departement_code As DataGridViewTextBoxColumn
        Friend WithEvents departement_name As DataGridViewTextBoxColumn
        Friend WithEvents departement_description As DataGridViewTextBoxColumn

    End Class
End Namespace