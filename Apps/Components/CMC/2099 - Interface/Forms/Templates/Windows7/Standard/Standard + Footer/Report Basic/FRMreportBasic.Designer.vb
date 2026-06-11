Imports Microsoft.Reporting.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMreportBasic
    Inherits CMCv.FRMstandardFooter

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
        BtnClose = New CMCv.UI.Control.Btn(components)
        Rv_ = New ReportViewer()
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
        PnlBottomButton.Location = New System.Drawing.Point(0, 0)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(7, 10, 7, 10)
        PnlBottomButton.Size = New System.Drawing.Size(0, 97)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        ' 
        ' SLFLogo
        ' 
        SLFLogo.Margin = New System.Windows.Forms.Padding(11, 20, 11, 20)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(11, 20, 11, 20)
        pnl_.Size = New System.Drawing.Size(1307, 118)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Rv_)
        SLFPanel.Dock = System.Windows.Forms.DockStyle.None
        SLFPanel.Location = New System.Drawing.Point(0, 103)
        SLFPanel.Margin = New System.Windows.Forms.Padding(11, 20, 11, 20)
        SLFPanel.Size = New System.Drawing.Size(0, 97)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Rv_, 0)
        ' 
        ' SLFBackground
        ' 
        SLFBackground.Margin = New System.Windows.Forms.Padding(11, 20, 11, 20)
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.RoyalBlue
        BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New System.Drawing.Point(-187, 12)
        BtnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(167, 77)
        BtnClose.TabIndex = 1
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.Default
        BtnClose.XOShowBorderOnFocus = False
        BtnClose.XOValidateAllInput = False
        BtnClose.XOValidateAllInputTag = Nothing
        ' 
        ' Rv_
        ' 
        Rv_.Dock = System.Windows.Forms.DockStyle.Fill
        Rv_.DocumentMapWidth = 1
        Rv_.Location = New System.Drawing.Point(0, 0)
        Rv_.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Rv_.Name = "Rv_"
        Rv_.ServerReport.BearerToken = Nothing
        Rv_.Size = New System.Drawing.Size(0, 0)
        Rv_.TabIndex = 996
        ' 
        ' FRMreportBasic
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
        ClientSize = New System.Drawing.Size(1307, 1078)
        Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Name = "FRMreportBasic"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnClose As CMCv.UI.Control.Btn
    'TODO: Microsoft.Reporting.WinForms.ReportViewer no longer supported.
    'Microsoft.Reporting.WinForms.ReportViewer
    Public WithEvents Rv_ As ReportViewer
End Class
