Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMepls
        Inherits CMCv.UI.Canvas.FRMstandardFind

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
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnEPLS = New CMCv.UI.Control.Dgn(components)
            employee_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            company_name = New DataGridViewTextBoxColumn()
            department_code = New DataGridViewTextBoxColumn()
            department_name = New DataGridViewTextBoxColumn()
            position_code = New DataGridViewTextBoxColumn()
            position_name = New DataGridViewTextBoxColumn()
            employee_number = New DataGridViewTextBoxColumn()
            employee_fullname = New DataGridViewTextBoxColumn()
            employee_nickname = New DataGridViewTextBoxColumn()
            employmenttype_name = New DataGridViewTextBoxColumn()
            employee_gender = New DataGridViewTextBoxColumn()
            employee_isactive = New DataGridViewTextBoxColumn()
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
            SLFPanel.Size = New Size(1307, 946)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnEPLS, 0)
            ' 
            ' DgnEPLS
            ' 
            DgnEPLS.AllowUserToAddRows = False
            DgnEPLS.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(252), CByte(217), CByte(126))
            DgnEPLS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnEPLS.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnEPLS.BorderStyle = BorderStyle.None
            DgnEPLS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnEPLS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnEPLS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnEPLS.ColumnHeadersHeight = 43
            DgnEPLS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnEPLS.Columns.AddRange(New DataGridViewColumn() {employee_id, company_code, company_name, department_code, department_name, position_code, position_name, employee_number, employee_fullname, employee_nickname, employmenttype_name, employee_gender, employee_isactive})
            DgnEPLS.Dock = DockStyle.Fill
            DgnEPLS.EnableHeadersVisualStyles = False
            DgnEPLS.Font = New Font("Verdana", 8.0F)
            DgnEPLS.Location = New Point(0, 88)
            DgnEPLS.Margin = New Padding(6, 5, 6, 5)
            DgnEPLS.Name = "DgnEPLS"
            DgnEPLS.ReadOnly = True
            DgnEPLS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = Color.YellowGreen
            DataGridViewCellStyle4.Font = New Font("Verdana", 8.0F)
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle4.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle4.SelectionForeColor = Color.Black
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
            DgnEPLS.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
            DgnEPLS.RowHeadersWidth = 62
            DgnEPLS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnEPLS.Size = New Size(1307, 858)
            DgnEPLS.StandardTab = True
            DgnEPLS.TabIndex = 0
            DgnEPLS.XOIsGroupFirstRow = False
            DgnEPLS.XOIsShowRowNumber = True
            ' 
            ' employee_id
            ' 
            employee_id.DataPropertyName = "employee_id"
            employee_id.HeaderText = "EMPLOYEE ID"
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
            company_code.HeaderText = "COMP. CODE"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.NotSortable
            company_code.Width = 8
            ' 
            ' company_name
            ' 
            company_name.DataPropertyName = "company_name"
            company_name.HeaderText = "COMP."
            company_name.MinimumWidth = 8
            company_name.Name = "company_name"
            company_name.ReadOnly = True
            company_name.Visible = False
            company_name.Width = 150
            ' 
            ' department_code
            ' 
            department_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            department_code.DataPropertyName = "department_code"
            department_code.HeaderText = "DEPT. CODE"
            department_code.MinimumWidth = 8
            department_code.Name = "department_code"
            department_code.ReadOnly = True
            department_code.SortMode = DataGridViewColumnSortMode.NotSortable
            department_code.Width = 8
            ' 
            ' department_name
            ' 
            department_name.DataPropertyName = "department_name"
            department_name.HeaderText = "DEPT."
            department_name.MinimumWidth = 8
            department_name.Name = "department_name"
            department_name.ReadOnly = True
            department_name.Visible = False
            department_name.Width = 150
            ' 
            ' position_code
            ' 
            position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            position_code.DataPropertyName = "position_code"
            position_code.HeaderText = "POSITION CODE"
            position_code.MinimumWidth = 8
            position_code.Name = "position_code"
            position_code.ReadOnly = True
            position_code.SortMode = DataGridViewColumnSortMode.NotSortable
            position_code.Width = 8
            ' 
            ' position_name
            ' 
            position_name.DataPropertyName = "position_name"
            position_name.HeaderText = "POSITION"
            position_name.MinimumWidth = 8
            position_name.Name = "position_name"
            position_name.ReadOnly = True
            position_name.Visible = False
            position_name.Width = 150
            ' 
            ' employee_number
            ' 
            employee_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            employee_number.DataPropertyName = "employee_number"
            employee_number.HeaderText = "EMPLOYEE NUM"
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
            employee_fullname.HeaderText = "EMPLOYEE FULL NAME"
            employee_fullname.MinimumWidth = 8
            employee_fullname.Name = "employee_fullname"
            employee_fullname.ReadOnly = True
            employee_fullname.SortMode = DataGridViewColumnSortMode.NotSortable
            employee_fullname.Width = 134
            ' 
            ' employee_nickname
            ' 
            employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
            employee_nickname.DataPropertyName = "employee_nickname"
            employee_nickname.HeaderText = "NICKNAME"
            employee_nickname.MinimumWidth = 8
            employee_nickname.Name = "employee_nickname"
            employee_nickname.ReadOnly = True
            employee_nickname.SortMode = DataGridViewColumnSortMode.NotSortable
            employee_nickname.Width = 8
            ' 
            ' employmenttype_name
            ' 
            employmenttype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            employmenttype_name.DataPropertyName = "employmenttype_name"
            employmenttype_name.HeaderText = "EMP. TYPE"
            employmenttype_name.MinimumWidth = 8
            employmenttype_name.Name = "employmenttype_name"
            employmenttype_name.ReadOnly = True
            employmenttype_name.SortMode = DataGridViewColumnSortMode.NotSortable
            employmenttype_name.Width = 86
            ' 
            ' employee_gender
            ' 
            employee_gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            employee_gender.DataPropertyName = "employee_gender"
            employee_gender.HeaderText = "GENDER"
            employee_gender.MinimumWidth = 8
            employee_gender.Name = "employee_gender"
            employee_gender.ReadOnly = True
            employee_gender.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_gender.Width = 109
            ' 
            ' employee_isactive
            ' 
            employee_isactive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            employee_isactive.DataPropertyName = "employee_isactive"
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            employee_isactive.DefaultCellStyle = DataGridViewCellStyle3
            employee_isactive.HeaderText = "IS ACTIVE"
            employee_isactive.MinimumWidth = 8
            employee_isactive.Name = "employee_isactive"
            employee_isactive.ReadOnly = True
            employee_isactive.Resizable = DataGridViewTriState.True
            employee_isactive.SortMode = DataGridViewColumnSortMode.NotSortable
            ' 
            ' FRMepls
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            ControlBox = False
            FormBorderStyle = FormBorderStyle.SizableToolWindow
            Margin = New Padding(10, 5, 10, 5)
            MaximizeBox = False
            MdiChildrenMinimizedAnchorBottom = False
            MinimizeBox = False
            Name = "FRMepls"
            ShowIcon = False
            ShowInTaskbar = False
            WindowState = FormWindowState.Maximized
            XOWindowAlwaysMaximized = True
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
        Friend WithEvents DgnEPLS As CMCv.UI.Control.Dgn
        Friend WithEvents employee_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents company_name As DataGridViewTextBoxColumn
        Friend WithEvents department_code As DataGridViewTextBoxColumn
        Friend WithEvents department_name As DataGridViewTextBoxColumn
        Friend WithEvents position_code As DataGridViewTextBoxColumn
        Friend WithEvents position_name As DataGridViewTextBoxColumn
        Friend WithEvents employee_number As DataGridViewTextBoxColumn
        Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
        Friend WithEvents employee_nickname As DataGridViewTextBoxColumn
        Friend WithEvents employmenttype_name As DataGridViewTextBoxColumn
        Friend WithEvents employee_gender As DataGridViewTextBoxColumn
        Friend WithEvents employee_isactive As DataGridViewTextBoxColumn
    End Class
End Namespace