<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMdarSinglePdfViewer
    Inherits CMCv.FRMpdfviewer

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
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnClose
        ' 
        BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.Location = New Point(916, 13)
        ' 
        ' PDFContent
        ' 
        PDFContent.Size = New Size(1095, 698)
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Location = New Point(0, 698)
        PnlBottomButton.Size = New Size(1095, 97)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(1095, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Size = New Size(1095, 795)
        ' 
        ' FRMdarSinglePdfViewer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1095, 921)
        Margin = New Padding(17, 10, 17, 10)
        Name = "FRMdarSinglePdfViewer"
        WindowState = FormWindowState.Maximized
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class
