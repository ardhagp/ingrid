<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmctgEditor
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
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Location = New Point(0, 489)
        PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New Size(760, 97)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(760, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(760, 586)
        ' 
        ' FRMmctgEditor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(760, 712)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMmctgEditor"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
