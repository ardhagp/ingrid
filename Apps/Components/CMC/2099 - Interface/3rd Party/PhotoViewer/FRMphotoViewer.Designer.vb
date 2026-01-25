<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMphotoViewer
    Inherits CMCv.Std_Fo

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
        Imgs_ = New Windows.Forms.Tools.ImageStreamer()
        BtnClose = New btn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnClose)
        PnlBottomButton.Location = New System.Drawing.Point(0, 857)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Imgs_)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Imgs_, 0)
        ' 
        ' Imgs_
        ' 
        Imgs_.AllowDragging = True
        Imgs_.Dock = Windows.Forms.DockStyle.Fill
        Imgs_.InternalBackColor = Drawing.Color.Transparent
        Imgs_.Location = New System.Drawing.Point(0, 0)
        Imgs_.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Imgs_.Name = "Imgs_"
        Imgs_.Size = New System.Drawing.Size(1307, 857)
        Imgs_.TabIndex = 1
        Imgs_.TextAnimationDirection = Windows.Forms.Tools.ImageStreamer.TextStreamDirection.RightToLeft
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.Red
        BtnClose.Cursor = Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New System.Drawing.Point(1120, 13)
        BtnClose.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(167, 77)
        BtnClose.TabIndex = 0
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.XOTampilkanFocusBorder = False
        BtnClose.XOValidasiSemuaInput = False
        BtnClose.XOValidasiSemuaInputTag = Nothing
        ' 
        ' FRMphotoViewer
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1307, 1079)
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(22, 44, 22, 44)
        Name = "FRMphotoViewer"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Public WithEvents Imgs_ As Syncfusion.Windows.Forms.Tools.ImageStreamer
    Public WithEvents BtnClose As btn
End Class
