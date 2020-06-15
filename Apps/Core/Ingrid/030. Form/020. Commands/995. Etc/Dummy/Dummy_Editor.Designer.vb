<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dummy_Editor
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
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.Btn2)
        Me.PnlBottomButton.Controls.Add(Me.Btn1)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn1, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Btn2, 0)
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(523, 23)
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Size = New System.Drawing.Size(546, 46)
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Btn1.FlatAppearance.BorderSize = 2
        Me.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn1.ForeColor = System.Drawing.Color.White
        Me.Btn1.Location = New System.Drawing.Point(439, 7)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(100, 40)
        Me.Btn1.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.Btn1.SLFTampilkanFocusBorder = False
        Me.Btn1.SLFValidasiSemuaInput = False
        Me.Btn1.SLFValidasiSemuaInputTag = Nothing
        Me.Btn1.TabIndex = 1
        Me.Btn1.Text = "Btn1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Btn2.FlatAppearance.BorderSize = 2
        Me.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn2.ForeColor = System.Drawing.Color.White
        Me.Btn2.Location = New System.Drawing.Point(545, 7)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(100, 40)
        Me.Btn2.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.Btn2.SLFTampilkanFocusBorder = False
        Me.Btn2.SLFValidasiSemuaInput = False
        Me.Btn2.SLFValidasiSemuaInputTag = Nothing
        Me.Btn2.TabIndex = 2
        Me.Btn2.Text = "Btn2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Dummy_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.Name = "Dummy_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn1 As CMCv.btn
    Friend WithEvents Btn2 As CMCv.btn

End Class
