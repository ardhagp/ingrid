<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMepls
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnEPLS = New dgn(components)
        employee_id = New DataGridViewTextBoxColumn()
        company_code = New DataGridViewTextBoxColumn()
        departement_code = New DataGridViewTextBoxColumn()
        position_code = New DataGridViewTextBoxColumn()
        employee_grade = New DataGridViewTextBoxColumn()
        employee_number = New DataGridViewTextBoxColumn()
        employee_fullname = New DataGridViewTextBoxColumn()
        employee_nickname = New DataGridViewTextBoxColumn()
        employee_contracttype = New DataGridViewTextBoxColumn()
        employee_gender = New DataGridViewTextBoxColumn()
        employee_active = New DataGridViewTextBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnEPLS, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnEPLS)
        SLFPanel.Size = New Size(1307, 952)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnEPLS, 0)
        ' 
        ' DgnEPLS
        ' 
        DgnEPLS.AllowUserToAddRows = False
        DgnEPLS.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(205), CByte(253), CByte(108))
        DgnEPLS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DgnEPLS.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnEPLS.BorderStyle = BorderStyle.None
        DgnEPLS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnEPLS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnEPLS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnEPLS.ColumnHeadersHeight = 43
        DgnEPLS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnEPLS.Columns.AddRange(New DataGridViewColumn() {employee_id, company_code, departement_code, position_code, employee_grade, employee_number, employee_fullname, employee_nickname, employee_contracttype, employee_gender, employee_active})
        DgnEPLS.Dock = DockStyle.Fill
        DgnEPLS.EnableHeadersVisualStyles = False
        DgnEPLS.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnEPLS.Location = New Point(0, 88)
        DgnEPLS.Margin = New Padding(6, 5, 6, 5)
        DgnEPLS.Name = "DgnEPLS"
        DgnEPLS.ReadOnly = True
        DgnEPLS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.YellowGreen
        DataGridViewCellStyle8.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DgnEPLS.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DgnEPLS.RowHeadersWidth = 62
        DgnEPLS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnEPLS.Size = New Size(1307, 864)
        DgnEPLS.StandardTab = True
        DgnEPLS.TabIndex = 0
        DgnEPLS.XOGroupFirstRows = False
        DgnEPLS.XOGunakanNomorBaris = True
        ' 
        ' employee_id
        ' 
        employee_id.DataPropertyName = "employee_id"
        employee_id.HeaderText = "Employee ID"
        employee_id.MinimumWidth = 8
        employee_id.Name = "employee_id"
        employee_id.ReadOnly = True
        employee_id.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_id.Visible = False
        employee_id.Width = 150
        ' 
        ' company_code
        ' 
        company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        company_code.DataPropertyName = "company_code"
        company_code.HeaderText = "Company"
        company_code.MinimumWidth = 8
        company_code.Name = "company_code"
        company_code.ReadOnly = True
        company_code.SortMode = DataGridViewColumnSortMode.NotSortable
        company_code.Width = 8
        ' 
        ' departement_code
        ' 
        departement_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        departement_code.DataPropertyName = "departement_code"
        departement_code.HeaderText = "Departement"
        departement_code.MinimumWidth = 8
        departement_code.Name = "departement_code"
        departement_code.ReadOnly = True
        departement_code.SortMode = DataGridViewColumnSortMode.NotSortable
        departement_code.Width = 8
        ' 
        ' position_code
        ' 
        position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        position_code.DataPropertyName = "position_code"
        position_code.HeaderText = "Position"
        position_code.MinimumWidth = 8
        position_code.Name = "position_code"
        position_code.ReadOnly = True
        position_code.SortMode = DataGridViewColumnSortMode.NotSortable
        position_code.Width = 8
        ' 
        ' employee_grade
        ' 
        employee_grade.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_grade.DataPropertyName = "employee_grade"
        employee_grade.HeaderText = "Grade"
        employee_grade.MinimumWidth = 8
        employee_grade.Name = "employee_grade"
        employee_grade.ReadOnly = True
        employee_grade.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_grade.Width = 60
        ' 
        ' employee_number
        ' 
        employee_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        employee_number.DataPropertyName = "employee_number"
        employee_number.HeaderText = "Emp. ID"
        employee_number.MinimumWidth = 8
        employee_number.Name = "employee_number"
        employee_number.ReadOnly = True
        employee_number.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_number.Width = 8
        ' 
        ' employee_fullname
        ' 
        employee_fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_fullname.DataPropertyName = "employee_fullname"
        employee_fullname.HeaderText = "Full Name"
        employee_fullname.MinimumWidth = 8
        employee_fullname.Name = "employee_fullname"
        employee_fullname.ReadOnly = True
        employee_fullname.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_fullname.Width = 85
        ' 
        ' employee_nickname
        ' 
        employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        employee_nickname.DataPropertyName = "employee_nickname"
        employee_nickname.HeaderText = "Nicname"
        employee_nickname.MinimumWidth = 8
        employee_nickname.Name = "employee_nickname"
        employee_nickname.ReadOnly = True
        employee_nickname.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_nickname.Width = 8
        ' 
        ' employee_contracttype
        ' 
        employee_contracttype.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_contracttype.DataPropertyName = "employee_contracttype"
        employee_contracttype.HeaderText = "Contract Type"
        employee_contracttype.MinimumWidth = 8
        employee_contracttype.Name = "employee_contracttype"
        employee_contracttype.ReadOnly = True
        employee_contracttype.SortMode = DataGridViewColumnSortMode.NotSortable
        employee_contracttype.Width = 112
        ' 
        ' employee_gender
        ' 
        employee_gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        employee_gender.DataPropertyName = "employee_gender"
        employee_gender.HeaderText = "Gender"
        employee_gender.MinimumWidth = 8
        employee_gender.Name = "employee_gender"
        employee_gender.ReadOnly = True
        employee_gender.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' employee_active
        ' 
        employee_active.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        employee_active.DataPropertyName = "employee_active"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        employee_active.DefaultCellStyle = DataGridViewCellStyle7
        employee_active.HeaderText = "Active"
        employee_active.MinimumWidth = 8
        employee_active.Name = "employee_active"
        employee_active.ReadOnly = True
        employee_active.Resizable = DataGridViewTriState.True
        employee_active.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' FRMepls
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1307, 1078)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMepls"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnEPLS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnEPLS As dgn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents departement_code As DataGridViewTextBoxColumn
    Friend WithEvents position_code As DataGridViewTextBoxColumn
    Friend WithEvents employee_grade As DataGridViewTextBoxColumn
    Friend WithEvents employee_number As DataGridViewTextBoxColumn
    Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
    Friend WithEvents employee_nickname As DataGridViewTextBoxColumn
    Friend WithEvents employee_contracttype As DataGridViewTextBoxColumn
    Friend WithEvents employee_gender As DataGridViewTextBoxColumn
    Friend WithEvents employee_active As DataGridViewTextBoxColumn
End Class
