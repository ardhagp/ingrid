Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdbcheck
        Inherits CMCv.FRMstandardFind

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlFind
            ' 
            PnlFind.Margin = New Padding(7, 10, 7, 10)
            PnlFind.Size = New Size(1143, 88)
            ' 
            ' BtnClear
            ' 
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClear.FlatAppearance.BorderSize = 2
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClear.Visible = False
            ' 
            ' LblFind
            ' 
            LblFind.Visible = False
            ' 
            ' TxtFind
            ' 
            TxtFind.Margin = New Padding(7, 10, 7, 10)
            TxtFind.Visible = False
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 10, 7, 10)
            pnl_.Size = New Size(1143, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Margin = New Padding(7, 10, 7, 10)
            SLFPanel.Size = New Size(1143, 624)
            ' 
            ' FRMdbcheck
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1143, 750)
            KeyPreview = True
            Margin = New Padding(19, 38, 19, 38)
            Name = "FRMdbcheck"
            Text = "DBCHECK"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
    End Class
End Namespace