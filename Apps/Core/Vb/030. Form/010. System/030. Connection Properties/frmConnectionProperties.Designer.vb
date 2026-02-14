<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMconnectionproperties
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
        Btn1 = New CMCv.UI.Control.btn(components)
        Btn2 = New CMCv.UI.Control.btn(components)
        Btn3 = New CMCv.UI.Control.btn(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn3)
        PnlBottomButton.Controls.Add(Btn2)
        PnlBottomButton.Controls.Add(Btn1)
        PnlBottomButton.Location = New Point(0, 699)
        PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
        PnlBottomButton.Size = New Size(1095, 96)
        PnlBottomButton.Controls.SetChildIndex(Btn1, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn2, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn3, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(8, 12, 8, 12)
        pnl_.Size = New Size(1095, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Margin = New Padding(8, 12, 8, 12)
        SLFPanel.Size = New Size(1095, 795)
        ' 
        ' Btn1
        ' 
        Btn1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn1.BackColor = Color.LimeGreen
        Btn1.Cursor = Cursors.Hand
        Btn1.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        Btn1.FlatAppearance.BorderSize = 2
        Btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        Btn1.FlatStyle = FlatStyle.Flat
        Btn1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn1.ForeColor = Color.White
        Btn1.Location = New Point(909, 13)
        Btn1.Margin = New Padding(5, 6, 5, 6)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(167, 77)
        Btn1.TabIndex = 0
        Btn1.Text = "Btn1"
        Btn1.UseVisualStyleBackColor = False
        Btn1.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        Btn1.XOTampilkanFocusBorder = False
        Btn1.XOValidasiSemuaInput = False
        Btn1.XOValidasiSemuaInputTag = Nothing
        ' 
        ' Btn2
        ' 
        Btn2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn2.BackColor = Color.Orange
        Btn2.Cursor = Cursors.Hand
        Btn2.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(105), CByte(0))
        Btn2.FlatAppearance.BorderSize = 2
        Btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(185), CByte(20))
        Btn2.FlatStyle = FlatStyle.Flat
        Btn2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn2.ForeColor = Color.White
        Btn2.Location = New Point(732, 13)
        Btn2.Margin = New Padding(5, 6, 5, 6)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(167, 77)
        Btn2.TabIndex = 1
        Btn2.Text = "Btn2"
        Btn2.UseVisualStyleBackColor = False
        Btn2.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        Btn2.XOTampilkanFocusBorder = False
        Btn2.XOValidasiSemuaInput = False
        Btn2.XOValidasiSemuaInputTag = Nothing
        ' 
        ' Btn3
        ' 
        Btn3.BackColor = Color.Red
        Btn3.Cursor = Cursors.Hand
        Btn3.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        Btn3.FlatAppearance.BorderSize = 2
        Btn3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        Btn3.FlatStyle = FlatStyle.Flat
        Btn3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btn3.ForeColor = Color.White
        Btn3.Location = New Point(20, 13)
        Btn3.Margin = New Padding(5, 6, 5, 6)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(167, 77)
        Btn3.TabIndex = 2
        Btn3.Text = "Btn3"
        Btn3.UseVisualStyleBackColor = False
        Btn3.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        Btn3.XOTampilkanFocusBorder = False
        Btn3.XOValidasiSemuaInput = False
        Btn3.XOValidasiSemuaInputTag = Nothing
        ' 
        ' FRMconnectionproperties
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        ClientSize = New Size(1095, 921)
        KeyPreview = True
        Margin = New Padding(22, 44, 22, 44)
        Name = "FRMconnectionproperties"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Btn1 As CMCv.UI.Control.btn
    Friend WithEvents Btn3 As CMCv.UI.Control.btn
    Friend WithEvents Btn2 As CMCv.UI.Control.btn

End Class
