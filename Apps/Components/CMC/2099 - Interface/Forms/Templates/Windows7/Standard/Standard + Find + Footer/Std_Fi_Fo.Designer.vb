<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Std_Fi_Fo
    Inherits CMCv.Std_Fi

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PnlBottomButton = New pnl(components)
        imgLine = New Windows.Forms.PictureBox()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        PnlBottomButton.SuspendLayout()
        CType(imgLine, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnClear
        ' 
        BtnClear.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        ' 
        ' TxtFind
        ' 
        TxtFind.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        ' 
        ' SLFLogo
        ' 
        SLFLogo.Location = New System.Drawing.Point(7, 10)
        SLFLogo.Size = New System.Drawing.Size(73, 85)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Location = New System.Drawing.Point(117, 58)
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Location = New System.Drawing.Point(88, 7)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New System.Drawing.Size(1307, 110)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(PnlBottomButton)
        SLFPanel.Location = New System.Drawing.Point(0, 110)
        SLFPanel.Size = New System.Drawing.Size(1307, 947)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        ' 
        ' SLFBackground
        ' 
        SLFBackground.Location = New System.Drawing.Point(3, 6)
        SLFBackground.Size = New System.Drawing.Size(80, 92)
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
        PnlBottomButton.TabIndex = 996
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
        ' Std_Fi_Fo
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1307, 1079)
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(22, 44, 22, 44)
        Name = "Std_Fi_Fo"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
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

    Public WithEvents PnlBottomButton As pnl
    Friend WithEvents imgLine As Windows.Forms.PictureBox
End Class
