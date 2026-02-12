<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Std_Fo
    Inherits CMCv.frmStandard

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
        PnlBottomButton = New pnl(components)
        imgLine = New Windows.Forms.PictureBox()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        PnlBottomButton.SuspendLayout()
        CType(imgLine, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SLFLogo
        ' 
        SLFLogo.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        pnl_.Size = New System.Drawing.Size(1307, 110)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.AutoScroll = False
        SLFPanel.Controls.Add(PnlBottomButton)
        SLFPanel.Location = New System.Drawing.Point(0, 110)
        SLFPanel.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        SLFPanel.Size = New System.Drawing.Size(1307, 947)
        ' 
        ' SLFBackground
        ' 
        SLFBackground.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButton.Controls.Add(imgLine)
        PnlBottomButton.Dock = Windows.Forms.DockStyle.Bottom
        PnlBottomButton.Location = New System.Drawing.Point(0, 851)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PnlBottomButton.Name = "PnlBottomButton"
        PnlBottomButton.Size = New System.Drawing.Size(1307, 96)
        PnlBottomButton.TabIndex = 995
        ' 
        ' imgLine
        ' 
        imgLine.BackColor = Drawing.Color.Orange
        imgLine.Dock = Windows.Forms.DockStyle.Top
        imgLine.Location = New System.Drawing.Point(0, 0)
        imgLine.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        imgLine.Name = "imgLine"
        imgLine.Size = New System.Drawing.Size(1307, 8)
        imgLine.TabIndex = 0
        imgLine.TabStop = False
        ' 
        ' Std_Fo
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1307, 1079)
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(13, 23, 13, 23)
        Name = "Std_Fo"
        ShowInTaskbar = False
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        PnlBottomButton.ResumeLayout(False)
        CType(imgLine, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Public WithEvents PnlBottomButton As CMCv.pnl
    Friend WithEvents imgLine As System.Windows.Forms.PictureBox

End Class
