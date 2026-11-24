Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMaccountingDashboard
        Inherits CMCv.UI.Canvas.FRMstandard

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
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            CType(XOLogoBackground, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 10, 7, 10)
            pnl_.Size = New Size(1094, 104)
            ' 
            ' SLFPanel
            ' 
            XOPanel.Margin = New Padding(7, 10, 7, 10)
            XOPanel.Size = New Size(1094, 796)
            ' 
            ' FRMaccountingDashboard
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1094, 922)
            KeyPreview = True
            Margin = New Padding(9, 5, 9, 5)
            Name = "FRMaccountingDashboard"
            Text = "Nama Form"
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            CType(XOLogoBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

    End Class
End Namespace