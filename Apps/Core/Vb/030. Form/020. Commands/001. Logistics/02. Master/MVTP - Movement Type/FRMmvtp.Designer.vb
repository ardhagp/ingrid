Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmvtp
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
            DgnMVTP = New CMCv.UI.Control.Dgn(components)
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnMVTP, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnMVTP)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnMVTP, 0)
            ' 
            ' DgnMVTP
            ' 
            DgnMVTP.AllowUserToAddRows = False
            DgnMVTP.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(206), CByte(247), CByte(146))
            DgnMVTP.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnMVTP.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMVTP.BorderStyle = BorderStyle.None
            DgnMVTP.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMVTP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnMVTP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnMVTP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnMVTP.Dock = DockStyle.Fill
            DgnMVTP.EnableHeadersVisualStyles = False
            DgnMVTP.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMVTP.Location = New Point(0, 88)
            DgnMVTP.Margin = New Padding(6, 5, 6, 5)
            DgnMVTP.Name = "DgnMVTP"
            DgnMVTP.ReadOnly = True
            DgnMVTP.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMVTP.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMVTP.RowHeadersWidth = 62
            DgnMVTP.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMVTP.Size = New Size(1307, 864)
            DgnMVTP.StandardTab = True
            DgnMVTP.TabIndex = 802
            DgnMVTP.XOIsGroupFirstRow = False
            DgnMVTP.XOIsShowRowNumber = False
            ' 
            ' FRMmvtp
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmvtp"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnMVTP, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents DgnMVTP As CMCv.UI.Control.Dgn

    End Class
End Namespace