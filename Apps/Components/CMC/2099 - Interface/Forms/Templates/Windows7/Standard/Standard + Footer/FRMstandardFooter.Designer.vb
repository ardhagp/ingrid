Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMstandardFooter
        Inherits UI.Canvas.FRMstandard

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
            PnlBottomButton = New UI.Control.Pnl(components)
            imgLine = New System.Windows.Forms.PictureBox()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            XOPanel.SuspendLayout()
            CType(XOLogoBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            PnlBottomButton.SuspendLayout()
            CType(imgLine, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' SLFLogo
            ' 
            SLFLogo.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            ' 
            ' XOSubtitle
            ' 
            XOSubtitle.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
            ' 
            ' XOFormTitle
            ' 
            XOFormTitle.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            pnl_.Size = New System.Drawing.Size(1307, 110)
            ' 
            ' SLFPanel
            ' 
            XOPanel.AutoScroll = False
            XOPanel.Controls.Add(PnlBottomButton)
            XOPanel.Location = New System.Drawing.Point(0, 110)
            XOPanel.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            XOPanel.Size = New System.Drawing.Size(1307, 947)
            ' 
            ' XOLogoBackground
            ' 
            XOLogoBackground.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.BackColor = Drawing.Color.FromArgb(CByte(12), CByte(18), CByte(40))
            PnlBottomButton.Controls.Add(imgLine)
            PnlBottomButton.Dock = System.Windows.Forms.DockStyle.Bottom
            PnlBottomButton.Location = New System.Drawing.Point(0, 851)
            PnlBottomButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            PnlBottomButton.Name = "PnlBottomButton"
            PnlBottomButton.Size = New System.Drawing.Size(1307, 96)
            PnlBottomButton.TabIndex = 995
            ' 
            ' imgLine
            ' 
            imgLine.BackColor = Drawing.Color.Orange
            imgLine.Dock = System.Windows.Forms.DockStyle.Top
            imgLine.Location = New System.Drawing.Point(0, 0)
            imgLine.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            imgLine.Name = "imgLine"
            imgLine.Size = New System.Drawing.Size(1307, 8)
            imgLine.TabIndex = 0
            imgLine.TabStop = False
            ' 
            ' FRMstandardFooter
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
            ClientSize = New System.Drawing.Size(1307, 1079)
            KeyPreview = True
            Margin = New System.Windows.Forms.Padding(13, 23, 13, 23)
            Name = "FRMstandardFooter"
            ShowInTaskbar = False
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            XOPanel.ResumeLayout(False)
            CType(XOLogoBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            PnlBottomButton.ResumeLayout(False)
            CType(imgLine, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Public WithEvents PnlBottomButton As UI.Control.Pnl
        Friend WithEvents imgLine As System.Windows.Forms.PictureBox

    End Class
End Namespace