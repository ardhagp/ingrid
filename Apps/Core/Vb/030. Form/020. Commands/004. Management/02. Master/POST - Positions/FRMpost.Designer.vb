Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMpost
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
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnPOST = New CMCv.UI.Control.Dgn(components)
            company_code = New DataGridViewTextBoxColumn()
            department_code = New DataGridViewTextBoxColumn()
            position_id = New DataGridViewTextBoxColumn()
            position_code = New DataGridViewTextBoxColumn()
            position_name = New DataGridViewTextBoxColumn()
            position_description = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnPOST, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnPOST)
            SLFPanel.Size = New Size(1307, 946)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnPOST, 0)
            ' 
            ' DgnPOST
            ' 
            DgnPOST.AllowUserToAddRows = False
            DgnPOST.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(196), CByte(207), CByte(152))
            DgnPOST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnPOST.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnPOST.BorderStyle = BorderStyle.None
            DgnPOST.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnPOST.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnPOST.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnPOST.ColumnHeadersHeight = 43
            DgnPOST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnPOST.Columns.AddRange(New DataGridViewColumn() {company_code, department_code, position_id, position_code, position_name, position_description})
            DgnPOST.Dock = DockStyle.Fill
            DgnPOST.EnableHeadersVisualStyles = False
            DgnPOST.Font = New Font("Verdana", 8F)
            DgnPOST.Location = New Point(0, 88)
            DgnPOST.Margin = New Padding(6, 5, 6, 5)
            DgnPOST.Name = "DgnPOST"
            DgnPOST.ReadOnly = True
            DgnPOST.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnPOST.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnPOST.RowHeadersWidth = 62
            DgnPOST.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnPOST.Size = New Size(1307, 858)
            DgnPOST.StandardTab = True
            DgnPOST.TabIndex = 0
            DgnPOST.XOIsGroupFirstRow = False
            DgnPOST.XOIsShowRowNumber = True
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "COMPANY"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 123
            ' 
            ' department_code
            ' 
            department_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            department_code.DataPropertyName = "department_code"
            department_code.HeaderText = "DEPT."
            department_code.MinimumWidth = 8
            department_code.Name = "department_code"
            department_code.ReadOnly = True
            department_code.SortMode = DataGridViewColumnSortMode.Programmatic
            department_code.Width = 88
            ' 
            ' position_id
            ' 
            position_id.DataPropertyName = "position_id"
            position_id.HeaderText = "ID"
            position_id.MinimumWidth = 8
            position_id.Name = "position_id"
            position_id.ReadOnly = True
            position_id.SortMode = DataGridViewColumnSortMode.Programmatic
            position_id.Visible = False
            position_id.Width = 150
            ' 
            ' position_code
            ' 
            position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            position_code.DataPropertyName = "position_code"
            position_code.HeaderText = "POSITION CODE"
            position_code.MinimumWidth = 8
            position_code.Name = "position_code"
            position_code.ReadOnly = True
            position_code.SortMode = DataGridViewColumnSortMode.Programmatic
            position_code.Width = 161
            ' 
            ' position_name
            ' 
            position_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            position_name.DataPropertyName = "position_name"
            position_name.HeaderText = "POSITION NAME"
            position_name.MinimumWidth = 8
            position_name.Name = "position_name"
            position_name.ReadOnly = True
            position_name.SortMode = DataGridViewColumnSortMode.Programmatic
            position_name.Width = 161
            ' 
            ' position_description
            ' 
            position_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            position_description.DataPropertyName = "position_description"
            position_description.HeaderText = "DESCRIPTION"
            position_description.MinimumWidth = 8
            position_description.Name = "position_description"
            position_description.ReadOnly = True
            position_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMpost
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1307, 1078)
            Margin = New Padding(10, 5, 10, 5)
            MinimizeBox = False
            Name = "FRMpost"
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
            CType(DgnPOST, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnPOST As CMCv.UI.Control.Dgn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents department_code As DataGridViewTextBoxColumn
        Friend WithEvents position_id As DataGridViewTextBoxColumn
        Friend WithEvents position_code As DataGridViewTextBoxColumn
        Friend WithEvents position_name As DataGridViewTextBoxColumn
        Friend WithEvents position_description As DataGridViewTextBoxColumn

    End Class
End Namespace