<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DRTM
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgnTemplate = New CMCv.dgn(Me.components)
        Me.template_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.template_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.template_text1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.DgnTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.DgnTemplate)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DgnTemplate, 0)
        '
        'DgnTemplate
        '
        Me.DgnTemplate.AllowUserToAddRows = False
        Me.DgnTemplate.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DgnTemplate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgnTemplate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgnTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgnTemplate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgnTemplate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnTemplate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgnTemplate.ColumnHeadersHeight = 43
        Me.DgnTemplate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.template_id, Me.template_title, Me.template_text1})
        Me.DgnTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgnTemplate.EnableHeadersVisualStyles = False
        Me.DgnTemplate.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DgnTemplate.Location = New System.Drawing.Point(0, 46)
        Me.DgnTemplate.Name = "DgnTemplate"
        Me.DgnTemplate.ReadOnly = True
        Me.DgnTemplate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgnTemplate.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgnTemplate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgnTemplate.Size = New System.Drawing.Size(784, 439)
        Me.DgnTemplate.SLFGroupFirstRows = False
        Me.DgnTemplate.SLFGunakanNomorBaris = False
        Me.DgnTemplate.StandardTab = True
        Me.DgnTemplate.TabIndex = 802
        '
        'template_id
        '
        Me.template_id.DataPropertyName = "template_id"
        Me.template_id.HeaderText = "ID"
        Me.template_id.Name = "template_id"
        Me.template_id.ReadOnly = True
        '
        'template_title
        '
        Me.template_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.template_title.DataPropertyName = "template_title"
        Me.template_title.HeaderText = "Name / Title"
        Me.template_title.Name = "template_title"
        Me.template_title.ReadOnly = True
        Me.template_title.Width = 70
        '
        'template_text1
        '
        Me.template_text1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.template_text1.DataPropertyName = "template_text1"
        Me.template_text1.HeaderText = "Template Text"
        Me.template_text1.Name = "template_text1"
        Me.template_text1.ReadOnly = True
        '
        'DRTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.KeyPreview = True
        Me.Name = "DRTM"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.DgnTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgnTemplate As CMCv.dgn
    Friend WithEvents template_id As DataGridViewTextBoxColumn
    Friend WithEvents template_title As DataGridViewTextBoxColumn
    Friend WithEvents template_text1 As DataGridViewTextBoxColumn
End Class
