<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UAC
    Inherits CMCv.FRMstandardFind

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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnUAC = New dgn(components)
        user_id = New DataGridViewTextBoxColumn()
        employee_number = New DataGridViewTextBoxColumn()
        employee_fullname = New DataGridViewTextBoxColumn()
        user_username = New DataGridViewTextBoxColumn()
        user_root = New DataGridViewTextBoxColumn()
        user_lastlogin = New DataGridViewTextBoxColumn()
        user_locked = New DataGridViewCheckBoxColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnUAC, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnUAC)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnUAC, 0)
        ' 
        ' DgnUAC
        ' 
        DgnUAC.AllowUserToAddRows = False
        DgnUAC.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(250), CByte(239), CByte(103))
        DgnUAC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnUAC.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnUAC.BorderStyle = BorderStyle.None
        DgnUAC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnUAC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnUAC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnUAC.ColumnHeadersHeight = 43
        DgnUAC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnUAC.Columns.AddRange(New DataGridViewColumn() {user_id, employee_number, employee_fullname, user_username, user_root, user_lastlogin, user_locked})
        DgnUAC.Dock = DockStyle.Fill
        DgnUAC.EnableHeadersVisualStyles = False
        DgnUAC.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnUAC.Location = New Point(0, 53)
        DgnUAC.Margin = New Padding(4, 3, 4, 3)
        DgnUAC.Name = "DgnUAC"
        DgnUAC.ReadOnly = True
        DgnUAC.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnUAC.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnUAC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnUAC.Size = New Size(915, 511)
        DgnUAC.XOGroupFirstRows = False
        DgnUAC.XOGunakanNomorBaris = True
        DgnUAC.StandardTab = True
        DgnUAC.TabIndex = 0
        ' 
        ' user_id
        ' 
        user_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        user_id.DataPropertyName = "user_id"
        user_id.HeaderText = "User ID"
        user_id.Name = "user_id"
        user_id.ReadOnly = True
        user_id.SortMode = DataGridViewColumnSortMode.Programmatic
        user_id.Visible = False
        ' 
        ' employee_number
        ' 
        employee_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_number.DataPropertyName = "employee_number"
        employee_number.HeaderText = "Emp. Number"
        employee_number.Name = "employee_number"
        employee_number.ReadOnly = True
        employee_number.SortMode = DataGridViewColumnSortMode.Programmatic
        employee_number.Width = 99
        ' 
        ' employee_fullname
        ' 
        employee_fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_fullname.DataPropertyName = "employee_fullname"
        employee_fullname.HeaderText = "Emp. Full Name"
        employee_fullname.Name = "employee_fullname"
        employee_fullname.ReadOnly = True
        employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
        employee_fullname.Width = 79
        ' 
        ' user_username
        ' 
        user_username.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        user_username.DataPropertyName = "user_username"
        user_username.HeaderText = "Username"
        user_username.Name = "user_username"
        user_username.ReadOnly = True
        user_username.SortMode = DataGridViewColumnSortMode.Programmatic
        user_username.Width = 88
        ' 
        ' user_root
        ' 
        user_root.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        user_root.DataPropertyName = "user_root"
        user_root.HeaderText = "Role"
        user_root.Name = "user_root"
        user_root.ReadOnly = True
        user_root.SortMode = DataGridViewColumnSortMode.Programmatic
        user_root.Width = 55
        ' 
        ' user_lastlogin
        ' 
        user_lastlogin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        user_lastlogin.DataPropertyName = "user_lastlogin"
        DataGridViewCellStyle3.Format = "s"
        DataGridViewCellStyle3.NullValue = "n/a"
        user_lastlogin.DefaultCellStyle = DataGridViewCellStyle3
        user_lastlogin.HeaderText = "Last Login"
        user_lastlogin.Name = "user_lastlogin"
        user_lastlogin.ReadOnly = True
        user_lastlogin.SortMode = DataGridViewColumnSortMode.Programmatic
        user_lastlogin.Width = 80
        ' 
        ' user_locked
        ' 
        user_locked.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        user_locked.DataPropertyName = "user_locked"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.NullValue = False
        user_locked.DefaultCellStyle = DataGridViewCellStyle4
        user_locked.HeaderText = "Locked"
        user_locked.Name = "user_locked"
        user_locked.ReadOnly = True
        user_locked.Resizable = DataGridViewTriState.True
        user_locked.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' UAC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "UAC"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnUAC, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnUAC As dgn
    Friend WithEvents user_id As DataGridViewTextBoxColumn
    Friend WithEvents employee_number As DataGridViewTextBoxColumn
    Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
    Friend WithEvents user_username As DataGridViewTextBoxColumn
    Friend WithEvents user_root As DataGridViewTextBoxColumn
    Friend WithEvents user_lastlogin As DataGridViewTextBoxColumn
    Friend WithEvents user_locked As DataGridViewCheckBoxColumn
End Class
