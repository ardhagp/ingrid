<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDIN
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnCDIN = New dgn(components)
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
        TxtFind.Margin = New Padding(5, 3, 5, 3)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(DgnCDIN)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnCDIN, 0)
        ' 
        ' DgnCDIN
        ' 
        DgnCDIN.AllowUserToAddRows = False
        DgnCDIN.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(208), CByte(241), CByte(164))
        DgnCDIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnCDIN.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnCDIN.BorderStyle = BorderStyle.None
        DgnCDIN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnCDIN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnCDIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnCDIN.ColumnHeadersHeight = 43
        DgnCDIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnCDIN.Columns.AddRange(New DataGridViewColumn() {department_id, company_code, departement_code, departement_name, departement_description})
        DgnCDIN.Dock = DockStyle.Fill
        DgnCDIN.EnableHeadersVisualStyles = False
        DgnCDIN.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DgnCDIN.Location = New Point(0, 53)
        DgnCDIN.Margin = New Padding(4, 3, 4, 3)
        DgnCDIN.Name = "DgnCDIN"
        DgnCDIN.ReadOnly = True
        DgnCDIN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnCDIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnCDIN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnCDIN.Size = New Size(915, 511)
        DgnCDIN.XOGroupFirstRows = False
        DgnCDIN.XOGunakanNomorBaris = True
        DgnCDIN.StandardTab = True
        DgnCDIN.TabIndex = 0
        ' 
        ' department_id
        ' 
        department_id.DataPropertyName = "department_id"
        department_id.HeaderText = "ID"
        department_id.Name = "department_id"
        department_id.ReadOnly = True
        department_id.SortMode = DataGridViewColumnSortMode.Programmatic
        department_id.Visible = False
        ' 
        ' company_code
        ' 
        company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        company_code.DataPropertyName = "company_code"
        company_code.HeaderText = "Company Code"
        company_code.Name = "company_code"
        company_code.ReadOnly = True
        company_code.SortMode = DataGridViewColumnSortMode.Programmatic
        company_code.Width = 109
        ' 
        ' departement_code
        ' 
        departement_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        departement_code.DataPropertyName = "departement_code"
        departement_code.HeaderText = "Departement Code"
        departement_code.Name = "departement_code"
        departement_code.ReadOnly = True
        departement_code.SortMode = DataGridViewColumnSortMode.Programmatic
        departement_code.Width = 127
        ' 
        ' departement_name
        ' 
        departement_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        departement_name.DataPropertyName = "departement_name"
        departement_name.HeaderText = "Departement Name"
        departement_name.Name = "departement_name"
        departement_name.ReadOnly = True
        departement_name.SortMode = DataGridViewColumnSortMode.Programmatic
        departement_name.Width = 130
        ' 
        ' departement_description
        ' 
        departement_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        departement_description.DataPropertyName = "departement_description"
        departement_description.HeaderText = "Description"
        departement_description.Name = "departement_description"
        departement_description.ReadOnly = True
        departement_description.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' CDIN
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "CDIN"
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
    Friend WithEvents DgnCDIN As dgn
    Friend WithEvents department_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents departement_code As DataGridViewTextBoxColumn
    Friend WithEvents departement_name As DataGridViewTextBoxColumn
    Friend WithEvents departement_description As DataGridViewTextBoxColumn

End Class
