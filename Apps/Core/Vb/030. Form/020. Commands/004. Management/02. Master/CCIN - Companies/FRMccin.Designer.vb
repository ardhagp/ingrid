Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMccin
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
            DgnCCIN = New CMCv.UI.Control.Dgn(components)
            company_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            company_name = New DataGridViewTextBoxColumn()
            company_searchterm1 = New DataGridViewTextBoxColumn()
            company_searchterm2 = New DataGridViewTextBoxColumn()
            company_description = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnCCIN, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnCCIN)
            SLFPanel.Size = New Size(1307, 946)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnCCIN, 0)
            ' 
            ' DgnCCIN
            ' 
            DgnCCIN.AllowUserToAddRows = False
            DgnCCIN.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(190), CByte(196), CByte(96))
            DgnCCIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnCCIN.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnCCIN.BorderStyle = BorderStyle.None
            DgnCCIN.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnCCIN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnCCIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnCCIN.ColumnHeadersHeight = 43
            DgnCCIN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnCCIN.Columns.AddRange(New DataGridViewColumn() {company_id, company_code, company_name, company_searchterm1, company_searchterm2, company_description})
            DgnCCIN.Dock = DockStyle.Fill
            DgnCCIN.EnableHeadersVisualStyles = False
            DgnCCIN.Font = New Font("Verdana", 8F)
            DgnCCIN.Location = New Point(0, 88)
            DgnCCIN.Margin = New Padding(6, 5, 6, 5)
            DgnCCIN.MultiSelect = False
            DgnCCIN.Name = "DgnCCIN"
            DgnCCIN.ReadOnly = True
            DgnCCIN.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnCCIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnCCIN.RowHeadersWidth = 62
            DgnCCIN.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnCCIN.Size = New Size(1307, 858)
            DgnCCIN.StandardTab = True
            DgnCCIN.TabIndex = 0
            DgnCCIN.XOIsGroupFirstRow = False
            DgnCCIN.XOIsShowRowNumber = True
            ' 
            ' company_id
            ' 
            company_id.DataPropertyName = "company_id"
            company_id.HeaderText = "COMPANY ID"
            company_id.MinimumWidth = 8
            company_id.Name = "company_id"
            company_id.ReadOnly = True
            company_id.Visible = False
            company_id.Width = 150
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "COMPANY CODE"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.Width = 160
            ' 
            ' company_name
            ' 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_name.DataPropertyName = "company_name"
            company_name.HeaderText = "COMPANY NAME"
            company_name.MinimumWidth = 8
            company_name.Name = "company_name"
            company_name.ReadOnly = True
            company_name.Width = 160
            ' 
            ' company_searchterm1
            ' 
            company_searchterm1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_searchterm1.DataPropertyName = "company_searchterm1"
            company_searchterm1.HeaderText = "SEARCH TERM 1"
            company_searchterm1.MinimumWidth = 8
            company_searchterm1.Name = "company_searchterm1"
            company_searchterm1.ReadOnly = True
            company_searchterm1.Width = 144
            ' 
            ' company_searchterm2
            ' 
            company_searchterm2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_searchterm2.DataPropertyName = "company_searchterm2"
            company_searchterm2.HeaderText = "SEARCH TERM 2"
            company_searchterm2.MinimumWidth = 8
            company_searchterm2.Name = "company_searchterm2"
            company_searchterm2.ReadOnly = True
            company_searchterm2.Width = 144
            ' 
            ' company_description
            ' 
            company_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            company_description.DataPropertyName = "company_description"
            company_description.HeaderText = "DESCRIPTION"
            company_description.MinimumWidth = 8
            company_description.Name = "company_description"
            company_description.ReadOnly = True
            company_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMccin
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1307, 1078)
            Margin = New Padding(10, 5, 10, 5)
            MinimizeBox = False
            Name = "FRMccin"
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
            CType(DgnCCIN, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnCCIN As CMCv.UI.Control.Dgn
        Friend WithEvents company_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents company_name As DataGridViewTextBoxColumn
        Friend WithEvents company_searchterm1 As DataGridViewTextBoxColumn
        Friend WithEvents company_searchterm2 As DataGridViewTextBoxColumn
        Friend WithEvents company_description As DataGridViewTextBoxColumn

    End Class
End Namespace