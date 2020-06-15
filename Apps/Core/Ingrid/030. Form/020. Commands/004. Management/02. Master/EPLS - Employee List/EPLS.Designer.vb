<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EPLS
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnEPLS = New CMCv.dgn(Me.components)
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_nickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_contracttype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnEPLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'TxtFind
        '
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnEPLS)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnEPLS, 0)
        '
        'DgnEPLS
        '
        Me.DgnEPLS.AllowUserToAddRows = False
        Me.DgnEPLS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.DgnEPLS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnEPLS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnEPLS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnEPLS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnEPLS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnEPLS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnEPLS.ColumnHeadersHeight = 43
        Me.DgnEPLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnEPLS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_id, Me.company_code, Me.departement_code, Me.position_code, Me.employee_grade, Me.employee_number, Me.employee_fullname, Me.employee_nickname, Me.employee_contracttype, Me.employee_gender, Me.employee_active})
        Me.DgnEPLS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnEPLS.EnableHeadersVisualStyles = False
        Me.DgnEPLS.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnEPLS.Location = New System.Drawing.Point(0, 46)
        Me.DgnEPLS.Name = "DgnEPLS"
        Me.DgnEPLS.ReadOnly = True
        Me.DgnEPLS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnEPLS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgnEPLS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnEPLS.Size = New System.Drawing.Size(784, 439)
        Me.DgnEPLS.SLFGroupFirstRows = False
        Me.DgnEPLS.SLFGunakanNomorBaris = True
        Me.DgnEPLS.StandardTab = True
        Me.DgnEPLS.TabIndex = 0
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "Employee ID"
        Me.employee_id.Name = "employee_id"
        Me.employee_id.ReadOnly = True
        Me.employee_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_id.Visible = False
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_code.Width = 5
        '
        'departement_code
        '
        Me.departement_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.departement_code.DataPropertyName = "departement_code"
        Me.departement_code.HeaderText = "Departement"
        Me.departement_code.Name = "departement_code"
        Me.departement_code.ReadOnly = True
        Me.departement_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.departement_code.Width = 5
        '
        'position_code
        '
        Me.position_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.position_code.DataPropertyName = "position_code"
        Me.position_code.HeaderText = "Position"
        Me.position_code.Name = "position_code"
        Me.position_code.ReadOnly = True
        Me.position_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.position_code.Width = 5
        '
        'employee_grade
        '
        Me.employee_grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.employee_grade.DataPropertyName = "employee_grade"
        Me.employee_grade.HeaderText = "Grade"
        Me.employee_grade.Name = "employee_grade"
        Me.employee_grade.ReadOnly = True
        Me.employee_grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_grade.Width = 46
        '
        'employee_number
        '
        Me.employee_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.employee_number.DataPropertyName = "employee_number"
        Me.employee_number.HeaderText = "Emp. ID"
        Me.employee_number.Name = "employee_number"
        Me.employee_number.ReadOnly = True
        Me.employee_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_number.Width = 5
        '
        'employee_fullname
        '
        Me.employee_fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.employee_fullname.DataPropertyName = "employee_fullname"
        Me.employee_fullname.HeaderText = "Full Name"
        Me.employee_fullname.Name = "employee_fullname"
        Me.employee_fullname.ReadOnly = True
        Me.employee_fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_fullname.Width = 60
        '
        'employee_nickname
        '
        Me.employee_nickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.employee_nickname.DataPropertyName = "employee_nickname"
        Me.employee_nickname.HeaderText = "Nicname"
        Me.employee_nickname.Name = "employee_nickname"
        Me.employee_nickname.ReadOnly = True
        Me.employee_nickname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_nickname.Width = 5
        '
        'employee_contracttype
        '
        Me.employee_contracttype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.employee_contracttype.DataPropertyName = "employee_contracttype"
        Me.employee_contracttype.HeaderText = "Contract Type"
        Me.employee_contracttype.Name = "employee_contracttype"
        Me.employee_contracttype.ReadOnly = True
        Me.employee_contracttype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.employee_contracttype.Width = 82
        '
        'employee_gender
        '
        Me.employee_gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.employee_gender.DataPropertyName = "employee_gender"
        Me.employee_gender.HeaderText = "Gender"
        Me.employee_gender.Name = "employee_gender"
        Me.employee_gender.ReadOnly = True
        Me.employee_gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.employee_gender.Width = 72
        '
        'employee_active
        '
        Me.employee_active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.employee_active.DataPropertyName = "employee_active"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.employee_active.DefaultCellStyle = DataGridViewCellStyle3
        Me.employee_active.HeaderText = "Active"
        Me.employee_active.Name = "employee_active"
        Me.employee_active.ReadOnly = True
        Me.employee_active.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employee_active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EPLS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "EPLS"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnEPLS,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DgnEPLS As CMCv.dgn
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
