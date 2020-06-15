<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UAC
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnUAC = New CMCv.dgn(Me.components)
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_lastlogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_locked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnUAC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SLFPanel.Controls.Add(Me.DgnUAC)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnUAC, 0)
        '
        'DgnUAC
        '
        Me.DgnUAC.AllowUserToAddRows = False
        Me.DgnUAC.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.DgnUAC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnUAC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnUAC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnUAC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnUAC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnUAC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnUAC.ColumnHeadersHeight = 43
        Me.DgnUAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgnUAC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_id, Me.employee_number, Me.employee_fullname, Me.user_username, Me.user_lastlogin, Me.user_locked})
        Me.DgnUAC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnUAC.EnableHeadersVisualStyles = False
        Me.DgnUAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnUAC.Location = New System.Drawing.Point(0, 46)
        Me.DgnUAC.Name = "DgnUAC"
        Me.DgnUAC.ReadOnly = True
        Me.DgnUAC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnUAC.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgnUAC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnUAC.Size = New System.Drawing.Size(784, 439)
        Me.DgnUAC.SLFGroupFirstRows = False
        Me.DgnUAC.SLFGunakanNomorBaris = True
        Me.DgnUAC.StandardTab = True
        Me.DgnUAC.TabIndex = 0
        '
        'user_id
        '
        Me.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.user_id.DataPropertyName = "user_id"
        Me.user_id.HeaderText = "User ID"
        Me.user_id.Name = "user_id"
        Me.user_id.ReadOnly = True
        Me.user_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.user_id.Visible = False
        Me.user_id.Width = 56
        '
        'employee_number
        '
        Me.employee_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.employee_number.DataPropertyName = "employee_number"
        Me.employee_number.HeaderText = "Emp. Number"
        Me.employee_number.Name = "employee_number"
        Me.employee_number.ReadOnly = True
        Me.employee_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.employee_number.Width = 99
        '
        'employee_fullname
        '
        Me.employee_fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.employee_fullname.DataPropertyName = "employee_fullname"
        Me.employee_fullname.HeaderText = "Emp. Full Name"
        Me.employee_fullname.Name = "employee_fullname"
        Me.employee_fullname.ReadOnly = True
        Me.employee_fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.employee_fullname.Width = 79
        '
        'user_username
        '
        Me.user_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.user_username.DataPropertyName = "user_username"
        Me.user_username.HeaderText = "Username"
        Me.user_username.Name = "user_username"
        Me.user_username.ReadOnly = True
        Me.user_username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.user_username.Width = 88
        '
        'user_lastlogin
        '
        Me.user_lastlogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.user_lastlogin.DataPropertyName = "user_lastlogin"
        DataGridViewCellStyle3.Format = "s"
        DataGridViewCellStyle3.NullValue = "n/a"
        Me.user_lastlogin.DefaultCellStyle = DataGridViewCellStyle3
        Me.user_lastlogin.HeaderText = "Last Login"
        Me.user_lastlogin.Name = "user_lastlogin"
        Me.user_lastlogin.ReadOnly = True
        Me.user_lastlogin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.user_lastlogin.Width = 80
        '
        'user_locked
        '
        Me.user_locked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.user_locked.DataPropertyName = "user_locked"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.NullValue = False
        Me.user_locked.DefaultCellStyle = DataGridViewCellStyle4
        Me.user_locked.HeaderText = "Locked"
        Me.user_locked.Name = "user_locked"
        Me.user_locked.ReadOnly = True
        Me.user_locked.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user_locked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'UAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "UAC"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnUAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnUAC As CMCv.dgn
    Friend WithEvents user_id As DataGridViewTextBoxColumn
    Friend WithEvents employee_number As DataGridViewTextBoxColumn
    Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
    Friend WithEvents user_username As DataGridViewTextBoxColumn
    Friend WithEvents user_lastlogin As DataGridViewTextBoxColumn
    Friend WithEvents user_locked As DataGridViewCheckBoxColumn
End Class
