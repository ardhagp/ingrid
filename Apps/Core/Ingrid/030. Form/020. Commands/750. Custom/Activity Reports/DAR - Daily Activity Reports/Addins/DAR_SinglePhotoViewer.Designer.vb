<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAR_SinglePhotoViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DAR_SinglePhotoViewer))
        Me.BtnClose = New CMCv.btn(Me.components)
        Me.PctbxPhoto = New CMCv.pctbx(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.PctbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnClose)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 353)
        Me.PnlBottomButton.Size = New System.Drawing.Size(657, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnClose, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(657, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.PctbxPhoto)
        Me.SLFPanel.Size = New System.Drawing.Size(657, 403)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.PctbxPhoto, 0)
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(545, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 40)
        Me.BtnClose.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnClose.SLFTampilkanFocusBorder = False
        Me.BtnClose.SLFValidasiSemuaInput = False
        Me.BtnClose.SLFValidasiSemuaInputTag = Nothing
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PctbxPhoto
        '
        Me.PctbxPhoto.BackColor = System.Drawing.Color.White
        Me.PctbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), System.Drawing.Image)
        Me.PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), System.Drawing.Image)
        Me.PctbxPhoto.Location = New System.Drawing.Point(0, 0)
        Me.PctbxPhoto.Name = "PctbxPhoto"
        Me.PctbxPhoto.Size = New System.Drawing.Size(657, 353)
        Me.PctbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctbxPhoto.SLFTampilkanBorder = False
        Me.PctbxPhoto.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.PctbxPhoto.TabIndex = 996
        Me.PctbxPhoto.TabStop = False
        '
        'DAR_SinglePhotoViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 479)
        Me.KeyPreview = True
        Me.Name = "DAR_SinglePhotoViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.PctbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents PctbxPhoto As CMCv.pctbx
End Class
