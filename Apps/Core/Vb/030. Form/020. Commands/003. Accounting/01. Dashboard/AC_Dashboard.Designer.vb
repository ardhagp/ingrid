<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC_Dashboard
    Inherits CMCv.FRMstandard

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
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 10, 7, 10)
        pnl_.Size = New Size(1094, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Margin = New Padding(7, 10, 7, 10)
        SLFPanel.Size = New Size(1094, 796)
        ' 
        ' AC_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1094, 922)
        KeyPreview = True
        Margin = New Padding(9, 5, 9, 5)
        Name = "AC_Dashboard"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class
