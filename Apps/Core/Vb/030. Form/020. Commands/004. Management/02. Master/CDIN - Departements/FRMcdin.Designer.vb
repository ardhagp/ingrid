Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMcdin
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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnCDIN = New CMCv.UI.Control.dgn(components)
            department_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            department_code = New DataGridViewTextBoxColumn()
            department_name = New DataGridViewTextBoxColumn()
            department_description = New DataGridViewTextBoxColumn()
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
            SLFPanel.Size = New Size(1307, 946)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnCDIN, 0)
            ' 
            ' DgnCDIN
            ' 
            DgnCDIN.AllowUserToAddRows = False
            DgnCDIN.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(197), CByte(225), CByte(139))
            DgnCDIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnCDIN.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnCDIN.BorderStyle = BorderStyle.None
            DgnCDIN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnCDIN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnCDIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnCDIN.ColumnHeadersHeight = 43
            DgnCDIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnCDIN.Columns.AddRange(New DataGridViewColumn() {department_id, company_code, department_code, department_name, department_description})
            DgnCDIN.Dock = DockStyle.Fill
            DgnCDIN.EnableHeadersVisualStyles = False
            DgnCDIN.Font = New Font("Verdana", 8F)
            DgnCDIN.Location = New Point(0, 88)
            DgnCDIN.Margin = New Padding(6, 5, 6, 5)
            DgnCDIN.Name = "DgnCDIN"
            DgnCDIN.ReadOnly = True
            DgnCDIN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnCDIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnCDIN.RowHeadersWidth = 62
            DgnCDIN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnCDIN.Size = New Size(1307, 858)
            DgnCDIN.StandardTab = True
            DgnCDIN.TabIndex = 0
            DgnCDIN.XOGroupFirstRow = False
            DgnCDIN.XOShowRowNumber = True
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
            company_code.HeaderText = "COMPANY CODE"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 160
            ' 
            ' department_code
            ' 
            department_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            department_code.DataPropertyName = "department_code"
            department_code.HeaderText = "DEPT. CODE"
            department_code.MinimumWidth = 8
            department_code.Name = "department_code"
            department_code.ReadOnly = True
            department_code.SortMode = DataGridViewColumnSortMode.Programmatic
            department_code.Width = 88
            ' 
            ' department_name
            ' 
            department_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            department_name.DataPropertyName = "department_name"
            department_name.HeaderText = "DEPT. NAME"
            department_name.MinimumWidth = 8
            department_name.Name = "department_name"
            department_name.ReadOnly = True
            department_name.SortMode = DataGridViewColumnSortMode.Programmatic
            department_name.Width = 88
            ' 
            ' department_description
            ' 
            department_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            department_description.DataPropertyName = "department_description"
            department_description.HeaderText = "DESCRIPTION"
            department_description.MinimumWidth = 8
            department_description.Name = "department_description"
            department_description.ReadOnly = True
            department_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMcdin
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1307, 1078)
            ControlBox = False
            FormBorderStyle = FormBorderStyle.SizableToolWindow
            Margin = New Padding(10, 5, 10, 5)
            MaximizeBox = False
            MdiChildrenMinimizedAnchorBottom = False
            MinimizeBox = False
            Name = "FRMcdin"
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
            CType(DgnCDIN, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnCDIN As cmcv.ui.control.dgn
        Friend WithEvents department_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents department_code As DataGridViewTextBoxColumn
        Friend WithEvents department_name As DataGridViewTextBoxColumn
        Friend WithEvents department_description As DataGridViewTextBoxColumn

    End Class
End Namespace