<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionProperties
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
        Me.components = New System.ComponentModel.Container()
        Me.Btn1 = New CMCv.btn(Me.components)
        Me.Btn2 = New CMCv.btn(Me.components)
        Me.Btn3 = New CMCv.btn(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.Btn3)
        Me.PnlBottomButton.Controls.Add(Me.Btn2)
        Me.PnlBottomButton.Controls.Add(Me.Btn1)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 353)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn1, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn2, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn3, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Size = New System.Drawing.Size(657, 403)
        '
        'Btn1
        '
        Me.Btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn1.BackColor = System.Drawing.Color.LimeGreen
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn1.FlatAppearance.BorderSize = 2
        Me.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn1.ForeColor = System.Drawing.Color.White
        Me.Btn1.Location = New System.Drawing.Point(545, 7)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(100, 40)
        Me.Btn1.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.Btn1.SLFTampilkanFocusBorder = False
        Me.Btn1.SLFValidasiSemuaInput = False
        Me.Btn1.SLFValidasiSemuaInputTag = Nothing
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Btn1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn2.BackColor = System.Drawing.Color.Orange
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn2.FlatAppearance.BorderSize = 2
        Me.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn2.ForeColor = System.Drawing.Color.White
        Me.Btn2.Location = New System.Drawing.Point(439, 7)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 40)
        Me.Btn2.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Custom
        Me.Btn2.SLFTampilkanFocusBorder = False
        Me.Btn2.SLFValidasiSemuaInput = False
        Me.Btn2.SLFValidasiSemuaInputTag = Nothing
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "Btn2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.Red
        Me.Btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn3.FlatAppearance.BorderSize = 2
        Me.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn3.ForeColor = System.Drawing.Color.White
        Me.Btn3.Location = New System.Drawing.Point(12, 7)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(100, 40)
        Me.Btn3.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.Btn3.SLFTampilkanFocusBorder = False
        Me.Btn3.SLFValidasiSemuaInput = False
        Me.Btn3.SLFValidasiSemuaInputTag = Nothing
        Me.Btn3.TabIndex = 2
        Me.Btn3.Text = "Btn3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'frmConnectionProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "frmConnectionProperties"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn1 As CMCv.btn
    Friend WithEvents Btn3 As CMCv.btn
    Friend WithEvents Btn2 As CMCv.btn

End Class
