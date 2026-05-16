Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMuac
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
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnUAC = New cmcv.ui.control.dgn(components)
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
            TxtFind.Margin = New Padding(7, 5, 7, 5)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnUAC)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnUAC, 0)
            ' 
            ' DgnUAC
            ' 
            DgnUAC.AllowUserToAddRows = False
            DgnUAC.AllowUserToDeleteRows = False
            DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(193), CByte(251), CByte(96))
            DgnUAC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
            DgnUAC.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnUAC.BorderStyle = BorderStyle.None
            DgnUAC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnUAC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = Color.YellowGreen
            DataGridViewCellStyle7.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle7.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle7.SelectionForeColor = Color.Black
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
            DgnUAC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
            DgnUAC.ColumnHeadersHeight = 43
            DgnUAC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnUAC.Columns.AddRange(New DataGridViewColumn() {user_id, employee_number, employee_fullname, user_username, user_root, user_lastlogin, user_locked})
            DgnUAC.Dock = DockStyle.Fill
            DgnUAC.EnableHeadersVisualStyles = False
            DgnUAC.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnUAC.Location = New Point(0, 88)
            DgnUAC.Margin = New Padding(6, 5, 6, 5)
            DgnUAC.Name = "DgnUAC"
            DgnUAC.ReadOnly = True
            DgnUAC.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.BackColor = Color.YellowGreen
            DataGridViewCellStyle10.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle10.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle10.SelectionForeColor = Color.Black
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
            DgnUAC.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
            DgnUAC.RowHeadersWidth = 62
            DgnUAC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnUAC.Size = New Size(1307, 864)
            DgnUAC.StandardTab = True
            DgnUAC.TabIndex = 0
            DgnUAC.XOGroupFirstRows = False
            DgnUAC.XOGunakanNomorBaris = True
            ' 
            ' user_id
            ' 
            user_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            user_id.DataPropertyName = "user_id"
            user_id.HeaderText = "User ID"
            user_id.MinimumWidth = 8
            user_id.Name = "user_id"
            user_id.ReadOnly = True
            user_id.SortMode = DataGridViewColumnSortMode.Programmatic
            user_id.Visible = False
            user_id.Width = 150
            ' 
            ' employee_number
            ' 
            employee_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            employee_number.DataPropertyName = "employee_number"
            employee_number.HeaderText = "Emp. Number"
            employee_number.MinimumWidth = 8
            employee_number.Name = "employee_number"
            employee_number.ReadOnly = True
            employee_number.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_number.Width = 140
            ' 
            ' employee_fullname
            ' 
            employee_fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            employee_fullname.DataPropertyName = "employee_fullname"
            employee_fullname.HeaderText = "Emp. Full Name"
            employee_fullname.MinimumWidth = 8
            employee_fullname.Name = "employee_fullname"
            employee_fullname.ReadOnly = True
            employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_fullname.Width = 157
            ' 
            ' user_username
            ' 
            user_username.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            user_username.DataPropertyName = "user_username"
            user_username.HeaderText = "Username"
            user_username.MinimumWidth = 8
            user_username.Name = "user_username"
            user_username.ReadOnly = True
            user_username.SortMode = DataGridViewColumnSortMode.Programmatic
            user_username.Width = 124
            ' 
            ' user_root
            ' 
            user_root.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            user_root.DataPropertyName = "user_root"
            user_root.HeaderText = "Role"
            user_root.MinimumWidth = 8
            user_root.Name = "user_root"
            user_root.ReadOnly = True
            user_root.SortMode = DataGridViewColumnSortMode.Programmatic
            user_root.Width = 78
            ' 
            ' user_lastlogin
            ' 
            user_lastlogin.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            user_lastlogin.DataPropertyName = "user_lastlogin"
            DataGridViewCellStyle8.Format = "s"
            DataGridViewCellStyle8.NullValue = "n/a"
            user_lastlogin.DefaultCellStyle = DataGridViewCellStyle8
            user_lastlogin.HeaderText = "Last Login"
            user_lastlogin.MinimumWidth = 8
            user_lastlogin.Name = "user_lastlogin"
            user_lastlogin.ReadOnly = True
            user_lastlogin.SortMode = DataGridViewColumnSortMode.Programmatic
            user_lastlogin.Width = 117
            ' 
            ' user_locked
            ' 
            user_locked.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            user_locked.DataPropertyName = "user_locked"
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle9.NullValue = False
            user_locked.DefaultCellStyle = DataGridViewCellStyle9
            user_locked.HeaderText = "Locked"
            user_locked.MinimumWidth = 8
            user_locked.Name = "user_locked"
            user_locked.ReadOnly = True
            user_locked.Resizable = DataGridViewTriState.True
            user_locked.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMuac
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMuac"
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
        Friend WithEvents DgnUAC As cmcv.ui.control.dgn
        Friend WithEvents user_id As DataGridViewTextBoxColumn
        Friend WithEvents employee_number As DataGridViewTextBoxColumn
        Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
        Friend WithEvents user_username As DataGridViewTextBoxColumn
        Friend WithEvents user_root As DataGridViewTextBoxColumn
        Friend WithEvents user_lastlogin As DataGridViewTextBoxColumn
        Friend WithEvents user_locked As DataGridViewCheckBoxColumn
    End Class
End Namespace