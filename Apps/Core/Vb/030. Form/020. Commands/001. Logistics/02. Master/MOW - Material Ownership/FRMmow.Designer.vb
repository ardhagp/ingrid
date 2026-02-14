Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmow
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
            DgnMOW = New cmcv.ui.control.dgn(components)
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMOW, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMOW)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMOW, 0)
            ' 
            ' DgnMOW
            ' 
            DgnMOW.AllowUserToAddRows = False
            DgnMOW.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(235), CByte(203), CByte(145))
            DgnMOW.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnMOW.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMOW.BorderStyle = BorderStyle.None
            DgnMOW.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMOW.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnMOW.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnMOW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnMOW.Dock = DockStyle.Fill
            DgnMOW.EnableHeadersVisualStyles = False
            DgnMOW.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMOW.Location = New Point(0, 88)
            DgnMOW.Margin = New Padding(6, 5, 6, 5)
            DgnMOW.Name = "DgnMOW"
            DgnMOW.ReadOnly = True
            DgnMOW.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMOW.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMOW.RowHeadersWidth = 62
            DgnMOW.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMOW.Size = New Size(1307, 864)
            DgnMOW.StandardTab = True
            DgnMOW.TabIndex = 802
            DgnMOW.XOGroupFirstRows = False
            DgnMOW.XOGunakanNomorBaris = False
            ' 
            ' FRMmow
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmow"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMOW, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMOW As cmcv.ui.control.dgn

    End Class
End Namespace