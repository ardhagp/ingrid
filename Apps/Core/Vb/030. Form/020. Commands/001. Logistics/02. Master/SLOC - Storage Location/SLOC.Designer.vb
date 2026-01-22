<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMsloc
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnSLOC = New dgn(components)
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgnSLOC, ComponentModel.ISupportInitialize).BeginInit()
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
        SLFPanel.Controls.Add(DgnSLOC)
        SLFPanel.Size = New Size(1307, 952)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(DgnSLOC, 0)
        ' 
        ' DgnSLOC
        ' 
        DgnSLOC.AllowUserToAddRows = False
        DgnSLOC.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(238), CByte(224), CByte(99))
        DgnSLOC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DgnSLOC.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnSLOC.BorderStyle = BorderStyle.None
        DgnSLOC.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnSLOC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnSLOC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnSLOC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgnSLOC.Dock = DockStyle.Fill
        DgnSLOC.EnableHeadersVisualStyles = False
        DgnSLOC.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnSLOC.Location = New Point(0, 88)
        DgnSLOC.Margin = New Padding(6, 5, 6, 5)
        DgnSLOC.Name = "DgnSLOC"
        DgnSLOC.ReadOnly = True
        DgnSLOC.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnSLOC.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnSLOC.RowHeadersWidth = 62
        DgnSLOC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnSLOC.Size = New Size(1307, 864)
        DgnSLOC.StandardTab = True
        DgnSLOC.TabIndex = 1
        DgnSLOC.XOGroupFirstRows = False
        DgnSLOC.XOGunakanNomorBaris = False
        ' 
        ' FRMsloc
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1307, 1078)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMsloc"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(DgnSLOC, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DgnSLOC As dgn

End Class
