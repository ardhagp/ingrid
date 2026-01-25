<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMremsEditorProgress
    Inherits CMCv.Std_Fo

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
        TrackBar1 = New TrackBar()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Location = New Point(0, 857)
        PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
        PnlBottomButton.Size = New Size(818, 96)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(8, 12, 8, 12)
        pnl_.Size = New Size(818, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TrackBar1)
        SLFPanel.Margin = New Padding(8, 12, 8, 12)
        SLFPanel.Size = New Size(818, 953)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TrackBar1, 0)
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(72, 112)
        TrackBar1.Margin = New Padding(5, 6, 5, 6)
        TrackBar1.Maximum = 50
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(665, 69)
        TrackBar1.TabIndex = 996
        TrackBar1.TickStyle = TickStyle.Both
        TrackBar1.Value = 50
        ' 
        ' FRMremsEditorProgress
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(818, 1079)
        KeyPreview = True
        Margin = New Padding(22, 44, 22, 44)
        Name = "FRMremsEditorProgress"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TrackBar1 As TrackBar
End Class
