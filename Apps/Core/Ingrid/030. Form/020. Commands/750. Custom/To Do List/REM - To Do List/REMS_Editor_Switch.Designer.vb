<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REMS_Editor_Switch
    Inherits CMCv.frmStandard

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
        Me.components = New System.ComponentModel.Container()
        Me.BtnEdit = New CMCv.btn(Me.components)
        Me.BtnChangeProgress = New CMCv.btn(Me.components)
        Me.BtnMarkAsVerified = New CMCv.btn(Me.components)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(210, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.BtnMarkAsVerified)
        Me.SLFPanel.Controls.Add(Me.BtnChangeProgress)
        Me.SLFPanel.Controls.Add(Me.BtnEdit)
        Me.SLFPanel.Size = New System.Drawing.Size(210, 152)
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnEdit.FlatAppearance.BorderSize = 2
        Me.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(12, 6)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(186, 40)
        Me.BtnEdit.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnEdit.SLFTampilkanFocusBorder = False
        Me.BtnEdit.SLFValidasiSemuaInput = False
        Me.BtnEdit.SLFValidasiSemuaInputTag = Nothing
        Me.BtnEdit.TabIndex = 0
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnChangeProgress
        '
        Me.BtnChangeProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChangeProgress.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnChangeProgress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChangeProgress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnChangeProgress.FlatAppearance.BorderSize = 2
        Me.BtnChangeProgress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnChangeProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChangeProgress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnChangeProgress.ForeColor = System.Drawing.Color.White
        Me.BtnChangeProgress.Location = New System.Drawing.Point(12, 52)
        Me.BtnChangeProgress.Name = "BtnChangeProgress"
        Me.BtnChangeProgress.Size = New System.Drawing.Size(186, 40)
        Me.BtnChangeProgress.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnChangeProgress.SLFTampilkanFocusBorder = False
        Me.BtnChangeProgress.SLFValidasiSemuaInput = False
        Me.BtnChangeProgress.SLFValidasiSemuaInputTag = Nothing
        Me.BtnChangeProgress.TabIndex = 1
        Me.BtnChangeProgress.Text = "Change Progress"
        Me.BtnChangeProgress.UseVisualStyleBackColor = False
        '
        'BtnMarkAsVerified
        '
        Me.BtnMarkAsVerified.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMarkAsVerified.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnMarkAsVerified.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMarkAsVerified.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnMarkAsVerified.FlatAppearance.BorderSize = 2
        Me.BtnMarkAsVerified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BtnMarkAsVerified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMarkAsVerified.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMarkAsVerified.ForeColor = System.Drawing.Color.White
        Me.BtnMarkAsVerified.Location = New System.Drawing.Point(12, 98)
        Me.BtnMarkAsVerified.Name = "BtnMarkAsVerified"
        Me.BtnMarkAsVerified.Size = New System.Drawing.Size(186, 40)
        Me.BtnMarkAsVerified.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.[Default]
        Me.BtnMarkAsVerified.SLFTampilkanFocusBorder = False
        Me.BtnMarkAsVerified.SLFValidasiSemuaInput = False
        Me.BtnMarkAsVerified.SLFValidasiSemuaInputTag = Nothing
        Me.BtnMarkAsVerified.TabIndex = 2
        Me.BtnMarkAsVerified.Text = "Mark As Verified"
        Me.BtnMarkAsVerified.UseVisualStyleBackColor = False
        '
        'REMS_Editor_Switch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(210, 228)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "REMS_Editor_Switch"
        Me.Text = "Nama Form"
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As CMCv.btn
    Friend WithEvents BtnMarkAsVerified As CMCv.btn
    Friend WithEvents BtnChangeProgress As CMCv.btn
End Class
