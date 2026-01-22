<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMdarSinglePhotoViewer
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMdarSinglePhotoViewer))
        BtnClose = New btn(components)
        PctbxPhoto = New pctbx(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(PctbxPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnClose)
        PnlBottomButton.Location = New Point(0, 699)
        PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New Size(1094, 97)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(1094, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(PctbxPhoto)
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(1094, 796)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(PctbxPhoto, 0)
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.BackColor = Color.Red
        BtnClose.Cursor = Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClose.ForeColor = Color.White
        BtnClose.Location = New Point(907, 13)
        BtnClose.Margin = New Padding(6, 5, 6, 5)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(167, 77)
        BtnClose.TabIndex = 0
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.XOTampilkanFocusBorder = False
        BtnClose.XOValidasiSemuaInput = False
        BtnClose.XOValidasiSemuaInputTag = Nothing
        ' 
        ' PctbxPhoto
        ' 
        PctbxPhoto.BackColor = Color.White
        PctbxPhoto.Dock = DockStyle.Fill
        PctbxPhoto.ErrorImage = CType(resources.GetObject("PctbxPhoto.ErrorImage"), Image)
        PctbxPhoto.InitialImage = CType(resources.GetObject("PctbxPhoto.InitialImage"), Image)
        PctbxPhoto.Location = New Point(0, 0)
        PctbxPhoto.Margin = New Padding(6, 5, 6, 5)
        PctbxPhoto.Name = "PctbxPhoto"
        PctbxPhoto.Size = New Size(1094, 699)
        PctbxPhoto.SizeMode = PictureBoxSizeMode.Zoom
        PctbxPhoto.TabIndex = 996
        PctbxPhoto.TabStop = False
        PctbxPhoto.XOTampilkanBorder = False
        PctbxPhoto.XOWarnaBorder = Color.DodgerBlue
        ' 
        ' FRMdarSinglePhotoViewer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1094, 922)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMdarSinglePhotoViewer"
        WindowState = FormWindowState.Maximized
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(PctbxPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents PctbxPhoto As CMCv.pctbx
End Class
