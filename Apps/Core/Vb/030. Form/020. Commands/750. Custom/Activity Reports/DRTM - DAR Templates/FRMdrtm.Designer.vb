Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdrtm
        Inherits CMCv.Std_Fi

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
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnTemplate = New dgn(components)
            template_id = New DataGridViewTextBoxColumn()
            template_title = New DataGridViewTextBoxColumn()
            template_text1 = New DataGridViewTextBoxColumn()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnTemplate, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnTemplate)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnTemplate, 0)
            ' 
            ' DgnTemplate
            ' 
            DgnTemplate.AllowUserToAddRows = False
            DgnTemplate.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(233), CByte(248), CByte(109))
            DgnTemplate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnTemplate.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnTemplate.BorderStyle = BorderStyle.None
            DgnTemplate.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnTemplate.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnTemplate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnTemplate.ColumnHeadersHeight = 43
            DgnTemplate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnTemplate.Columns.AddRange(New DataGridViewColumn() {template_id, template_title, template_text1})
            DgnTemplate.Dock = DockStyle.Fill
            DgnTemplate.EnableHeadersVisualStyles = False
            DgnTemplate.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnTemplate.Location = New Point(0, 88)
            DgnTemplate.Margin = New Padding(6, 5, 6, 5)
            DgnTemplate.Name = "DgnTemplate"
            DgnTemplate.ReadOnly = True
            DgnTemplate.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnTemplate.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnTemplate.RowHeadersWidth = 62
            DgnTemplate.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnTemplate.Size = New Size(1307, 864)
            DgnTemplate.StandardTab = True
            DgnTemplate.TabIndex = 802
            DgnTemplate.XOGroupFirstRows = False
            DgnTemplate.XOGunakanNomorBaris = False
            ' 
            ' template_id
            ' 
            template_id.DataPropertyName = "template_id"
            template_id.HeaderText = "ID"
            template_id.MinimumWidth = 8
            template_id.Name = "template_id"
            template_id.ReadOnly = True
            template_id.Width = 150
            ' 
            ' template_title
            ' 
            template_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            template_title.DataPropertyName = "template_title"
            template_title.HeaderText = "Name / Title"
            template_title.MinimumWidth = 8
            template_title.Name = "template_title"
            template_title.ReadOnly = True
            ' 
            ' template_text1
            ' 
            template_text1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            template_text1.DataPropertyName = "template_text1"
            template_text1.HeaderText = "Template Text"
            template_text1.MinimumWidth = 8
            template_text1.Name = "template_text1"
            template_text1.ReadOnly = True
            ' 
            ' FRMdrtm
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMdrtm"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnTemplate, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnTemplate As dgn
        Friend WithEvents template_id As DataGridViewTextBoxColumn
        Friend WithEvents template_title As DataGridViewTextBoxColumn
        Friend WithEvents template_text1 As DataGridViewTextBoxColumn
    End Class
End Namespace