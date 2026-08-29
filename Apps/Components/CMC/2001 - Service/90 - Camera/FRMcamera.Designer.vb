<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMcamera
    Inherits UI.Canvas.FRMstandardFooter

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMcamera))
        Pbx1 = New CMCv.UI.Control.Pbx(components)
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pbx1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Location = New System.Drawing.Point(0, 669)
        PnlBottomButton.Size = New System.Drawing.Size(558, 96)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New System.Drawing.Size(558, 110)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Pbx1)
        SLFPanel.Size = New System.Drawing.Size(558, 765)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Pbx1, 0)
        ' 
        ' Pbx1
        ' 
        Pbx1.BackColor = Drawing.Color.White
        Pbx1.ErrorImage = CType(resources.GetObject("Pbx1.ErrorImage"), Drawing.Image)
        Pbx1.InitialImage = CType(resources.GetObject("Pbx1.InitialImage"), Drawing.Image)
        Pbx1.Location = New System.Drawing.Point(12, 15)
        Pbx1.Name = "Pbx1"
        Pbx1.Size = New System.Drawing.Size(534, 534)
        Pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Pbx1.TabIndex = 996
        Pbx1.TabStop = False
        Pbx1.XOBorderColor = Drawing.Color.DodgerBlue
        Pbx1.XOShowBorder = False
        ' 
        ' FRMcamera
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(558, 897)
        Name = "FRMcamera"
        Text = "FRMcamera"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(Pbx1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pbx1 As UI.Control.Pbx
End Class
