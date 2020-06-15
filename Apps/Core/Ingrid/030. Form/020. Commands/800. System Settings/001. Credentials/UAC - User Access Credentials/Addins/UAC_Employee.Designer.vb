<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UAC_Employee
    Inherits CMCv.Std_Fi_Fo

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnAddinEmployee = New CMCv.dgn(Me.components)
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.departement_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOk = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnAddinEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnOk)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 353)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnOk, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'PnlFind
        '
        Me.PnlFind.Size = New System.Drawing.Size(657, 46)
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnAddinEmployee)
        Me.SLFPanel.Size = New System.Drawing.Size(657, 403)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnAddinEmployee, 0)
        '
        'DgnAddinEmployee
        '
        Me.DgnAddinEmployee.AllowUserToAddRows = False
        Me.DgnAddinEmployee.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.DgnAddinEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnAddinEmployee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnAddinEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnAddinEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnAddinEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnAddinEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnAddinEmployee.ColumnHeadersHeight = 43
        Me.DgnAddinEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnAddinEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_id, Me.company_code, Me.departement_code, Me.position_code, Me.employee_number, Me.employee_fullname})
        Me.DgnAddinEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnAddinEmployee.EnableHeadersVisualStyles = False
        Me.DgnAddinEmployee.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnAddinEmployee.Location = New System.Drawing.Point(0, 46)
        Me.DgnAddinEmployee.Name = "DgnAddinEmployee"
        Me.DgnAddinEmployee.ReadOnly = True
        Me.DgnAddinEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnAddinEmployee.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnAddinEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnAddinEmployee.Size = New System.Drawing.Size(657, 307)
        Me.DgnAddinEmployee.SLFGroupFirstRows = False
        Me.DgnAddinEmployee.SLFGunakanNomorBaris = True
        Me.DgnAddinEmployee.StandardTab = True
        Me.DgnAddinEmployee.TabIndex = 1006
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "Emp. ID"
        Me.employee_id.Name = "employee_id"
        Me.employee_id.ReadOnly = True
        Me.employee_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.employee_id.Visible = False
        '
        'company_code
        '
        Me.company_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.company_code.DataPropertyName = "company_code"
        Me.company_code.HeaderText = "Company Code"
        Me.company_code.Name = "company_code"
        Me.company_code.ReadOnly = True
        Me.company_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.company_code.Width = 109
        '
        'departement_code
        '
        Me.departement_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.departement_code.DataPropertyName = "departement_code"
        Me.departement_code.HeaderText = "Dept. Code"
        Me.departement_code.Name = "departement_code"
        Me.departement_code.ReadOnly = True
        Me.departement_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.departement_code.Width = 87
        '
        'position_code
        '
        Me.position_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.position_code.DataPropertyName = "position_code"
        Me.position_code.HeaderText = "Position Code"
        Me.position_code.Name = "position_code"
        Me.position_code.ReadOnly = True
        Me.position_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.position_code.Width = 99
        '
        'employee_number
        '
        Me.employee_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.employee_number.DataPropertyName = "employee_number"
        Me.employee_number.HeaderText = "Employee Number"
        Me.employee_number.Name = "employee_number"
        Me.employee_number.ReadOnly = True
        Me.employee_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.employee_number.Width = 123
        '
        'employee_fullname
        '
        Me.employee_fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.employee_fullname.DataPropertyName = "employee_fullname"
        Me.employee_fullname.HeaderText = "Employee Full Name"
        Me.employee_fullname.Name = "employee_fullname"
        Me.employee_fullname.ReadOnly = True
        Me.employee_fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnOk.FlatAppearance.BorderSize = 2
        Me.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(439, 6)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(100, 40)
        Me.BtnOk.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnOk.SLFTampilkanFocusBorder = False
        Me.BtnOk.SLFValidasiSemuaInput = False
        Me.BtnOk.SLFValidasiSemuaInputTag = Nothing
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(545, 6)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'UAC_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "UAC_Employee"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnAddinEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnOk As CMCv.btn
    Friend WithEvents DgnAddinEmployee As CMCv.dgn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents company_code As DataGridViewTextBoxColumn
    Friend WithEvents departement_code As DataGridViewTextBoxColumn
    Friend WithEvents position_code As DataGridViewTextBoxColumn
    Friend WithEvents employee_number As DataGridViewTextBoxColumn
    Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
End Class
