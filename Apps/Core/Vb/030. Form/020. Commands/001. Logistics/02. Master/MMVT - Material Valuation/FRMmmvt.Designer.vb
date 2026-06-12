Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmmvt
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
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnMMVT = New CMCv.UI.Control.Dgn(components)
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMMVT, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMMVT)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMMVT, 0)
            ' 
            ' DgnMMVT
            ' 
            DgnMMVT.AllowUserToAddRows = False
            DgnMMVT.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(218), CByte(195), CByte(126))
            DgnMMVT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnMMVT.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMMVT.BorderStyle = BorderStyle.None
            DgnMMVT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMMVT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnMMVT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnMMVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnMMVT.Dock = DockStyle.Fill
            DgnMMVT.EnableHeadersVisualStyles = False
            DgnMMVT.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMMVT.Location = New Point(0, 88)
            DgnMMVT.Margin = New Padding(6, 5, 6, 5)
            DgnMMVT.Name = "DgnMMVT"
            DgnMMVT.ReadOnly = True
            DgnMMVT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMMVT.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMMVT.RowHeadersWidth = 62
            DgnMMVT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMMVT.Size = New Size(1307, 864)
            DgnMMVT.StandardTab = True
            DgnMMVT.TabIndex = 802
            DgnMMVT.XOIsGroupFirstRow = False
            DgnMMVT.XOIsShowRowNumber = False
            ' 
            ' FRMmmvt
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmmvt"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMMVT, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMMVT As CMCv.UI.Control.Dgn

    End Class
End Namespace