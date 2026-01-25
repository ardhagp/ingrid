<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMremsEditorSwitch
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
        components = New ComponentModel.Container()
        BtnEdit = New btn(components)
        BtnChangeProgress = New btn(components)
        BtnMarkAsVerified = New btn(components)
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(8, 12, 8, 12)
        pnl_.Size = New Size(350, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(BtnMarkAsVerified)
        SLFPanel.Controls.Add(BtnChangeProgress)
        SLFPanel.Controls.Add(BtnEdit)
        SLFPanel.Margin = New Padding(8, 12, 8, 12)
        SLFPanel.Size = New Size(350, 312)
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        BtnEdit.BackColor = Color.RoyalBlue
        BtnEdit.Cursor = Cursors.Hand
        BtnEdit.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnEdit.FlatAppearance.BorderSize = 2
        BtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnEdit.FlatStyle = FlatStyle.Flat
        BtnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnEdit.ForeColor = Color.White
        BtnEdit.Location = New Point(20, 12)
        BtnEdit.Margin = New Padding(5, 6, 5, 6)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(310, 77)
        BtnEdit.TabIndex = 0
        BtnEdit.Text = "Edit"
        BtnEdit.UseVisualStyleBackColor = False
        BtnEdit.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnEdit.XOTampilkanFocusBorder = False
        BtnEdit.XOValidasiSemuaInput = False
        BtnEdit.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnChangeProgress
        ' 
        BtnChangeProgress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        BtnChangeProgress.BackColor = Color.RoyalBlue
        BtnChangeProgress.Cursor = Cursors.Hand
        BtnChangeProgress.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnChangeProgress.FlatAppearance.BorderSize = 2
        BtnChangeProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnChangeProgress.FlatStyle = FlatStyle.Flat
        BtnChangeProgress.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnChangeProgress.ForeColor = Color.White
        BtnChangeProgress.Location = New Point(20, 100)
        BtnChangeProgress.Margin = New Padding(5, 6, 5, 6)
        BtnChangeProgress.Name = "BtnChangeProgress"
        BtnChangeProgress.Size = New Size(310, 77)
        BtnChangeProgress.TabIndex = 1
        BtnChangeProgress.Text = "Change Progress"
        BtnChangeProgress.UseVisualStyleBackColor = False
        BtnChangeProgress.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnChangeProgress.XOTampilkanFocusBorder = False
        BtnChangeProgress.XOValidasiSemuaInput = False
        BtnChangeProgress.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnMarkAsVerified
        ' 
        BtnMarkAsVerified.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        BtnMarkAsVerified.BackColor = Color.RoyalBlue
        BtnMarkAsVerified.Cursor = Cursors.Hand
        BtnMarkAsVerified.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
        BtnMarkAsVerified.FlatAppearance.BorderSize = 2
        BtnMarkAsVerified.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
        BtnMarkAsVerified.FlatStyle = FlatStyle.Flat
        BtnMarkAsVerified.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMarkAsVerified.ForeColor = Color.White
        BtnMarkAsVerified.Location = New Point(20, 188)
        BtnMarkAsVerified.Margin = New Padding(5, 6, 5, 6)
        BtnMarkAsVerified.Name = "BtnMarkAsVerified"
        BtnMarkAsVerified.Size = New Size(310, 77)
        BtnMarkAsVerified.TabIndex = 2
        BtnMarkAsVerified.Text = "Mark As Verified"
        BtnMarkAsVerified.UseVisualStyleBackColor = False
        BtnMarkAsVerified.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
        BtnMarkAsVerified.XOTampilkanFocusBorder = False
        BtnMarkAsVerified.XOValidasiSemuaInput = False
        BtnMarkAsVerified.XOValidasiSemuaInputTag = Nothing
        ' 
        ' FRMremsEditorSwitch
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(350, 438)
        KeyPreview = True
        Margin = New Padding(13, 23, 13, 23)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FRMremsEditorSwitch"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As CMCv.btn
    Friend WithEvents BtnMarkAsVerified As CMCv.btn
    Friend WithEvents BtnChangeProgress As CMCv.btn
End Class
