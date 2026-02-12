<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStandard
    Inherits CMCv.Blank

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
        Dim MySettings1 As CMCv.My.MySettings = New My.MySettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStandard))
        pnl_ = New pnl(components)
        SLFLogo = New pctbx(components)
        SLFBackground = New pctbx(components)
        SLFNamaForm = New lbl(components)
        SLFSubNamaForm = New lbl(components)
        SLFStatus = New stt(components)
        SLFStatusLabel = New Windows.Forms.ToolStripStatusLabel()
        SLFPanel = New pnl(components)
        pnl_.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SLFStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_
        ' 
        pnl_.AutoSize = True
        pnl_.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        pnl_.BackColor = Drawing.Color.Black
        pnl_.Controls.Add(SLFLogo)
        pnl_.Controls.Add(SLFBackground)
        pnl_.Controls.Add(SLFNamaForm)
        pnl_.Controls.Add(SLFSubNamaForm)
        pnl_.Dock = Windows.Forms.DockStyle.Top
        pnl_.Location = New System.Drawing.Point(0, 0)
        pnl_.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        pnl_.Name = "pnl_"
        pnl_.Size = New System.Drawing.Size(1307, 104)
        pnl_.TabIndex = 999
        ' 
        ' SLFLogo
        ' 
        SLFLogo.BackColor = Drawing.Color.Black
        MySettings1.MRUFiles = CType(resources.GetObject("MySettings1.MRUFiles"), Specialized.StringCollection)
        MySettings1.SettingsKey = ""
        MySettings1.SLFBackground = Drawing.Color.Black
        SLFLogo.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "SLFBackground", True, Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        SLFLogo.ErrorImage = CType(resources.GetObject("SLFLogo.ErrorImage"), Drawing.Image)
        SLFLogo.InitialImage = CType(resources.GetObject("SLFLogo.InitialImage"), Drawing.Image)
        SLFLogo.Location = New System.Drawing.Point(7, 10)
        SLFLogo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        SLFLogo.Name = "SLFLogo"
        SLFLogo.Size = New System.Drawing.Size(73, 85)
        SLFLogo.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
        SLFLogo.TabIndex = 0
        SLFLogo.TabStop = False
        SLFLogo.XOTampilkanBorder = False
        SLFLogo.XOWarnaBorder = Drawing.Color.DodgerBlue
        ' 
        ' SLFBackground
        ' 
        SLFBackground.BackColor = Drawing.Color.Black
        SLFBackground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "SLFBackground", True, Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        SLFBackground.ErrorImage = CType(resources.GetObject("SLFBackground.ErrorImage"), Drawing.Image)
        SLFBackground.InitialImage = CType(resources.GetObject("SLFBackground.InitialImage"), Drawing.Image)
        SLFBackground.Location = New System.Drawing.Point(3, 6)
        SLFBackground.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        SLFBackground.Name = "SLFBackground"
        SLFBackground.Size = New System.Drawing.Size(80, 92)
        SLFBackground.SizeMode = Windows.Forms.PictureBoxSizeMode.Zoom
        SLFBackground.TabIndex = 998
        SLFBackground.TabStop = False
        SLFBackground.XOTampilkanBorder = False
        SLFBackground.XOWarnaBorder = Drawing.Color.DodgerBlue
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        SLFNamaForm.AutoSize = True
        SLFNamaForm.BackColor = Drawing.Color.Transparent
        SLFNamaForm.Font = New System.Drawing.Font("Segoe UI", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        SLFNamaForm.ForeColor = Drawing.Color.White
        SLFNamaForm.Location = New System.Drawing.Point(88, 7)
        SLFNamaForm.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SLFNamaForm.Name = "SLFNamaForm"
        SLFNamaForm.Size = New System.Drawing.Size(217, 48)
        SLFNamaForm.TabIndex = 997
        SLFNamaForm.Text = "Nama Form"
        SLFNamaForm.TextAlign = Drawing.ContentAlignment.MiddleLeft
        SLFNamaForm.XOCustomElipsis = False
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        SLFSubNamaForm.AutoSize = True
        SLFSubNamaForm.BackColor = Drawing.Color.Transparent
        SLFSubNamaForm.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        SLFSubNamaForm.ForeColor = Drawing.Color.White
        SLFSubNamaForm.Location = New System.Drawing.Point(117, 58)
        SLFSubNamaForm.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SLFSubNamaForm.Name = "SLFSubNamaForm"
        SLFSubNamaForm.Size = New System.Drawing.Size(167, 25)
        SLFSubNamaForm.TabIndex = 996
        SLFSubNamaForm.Text = "Sub Deskripsi Form"
        SLFSubNamaForm.XOCustomElipsis = False
        ' 
        ' SLFStatus
        ' 
        SLFStatus.ImageScalingSize = New System.Drawing.Size(24, 24)
        SLFStatus.Items.AddRange(New Windows.Forms.ToolStripItem() {SLFStatusLabel})
        SLFStatus.Location = New System.Drawing.Point(0, 1057)
        SLFStatus.Name = "SLFStatus"
        SLFStatus.Padding = New System.Windows.Forms.Padding(2, 0, 23, 0)
        SLFStatus.Size = New System.Drawing.Size(1307, 22)
        SLFStatus.TabIndex = 994
        SLFStatus.Text = "Stt1"
        ' 
        ' SLFStatusLabel
        ' 
        SLFStatusLabel.Name = "SLFStatusLabel"
        SLFStatusLabel.Size = New System.Drawing.Size(0, 15)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.AutoScroll = True
        SLFPanel.AutoSize = True
        SLFPanel.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        SLFPanel.Dock = Windows.Forms.DockStyle.Fill
        SLFPanel.Location = New System.Drawing.Point(0, 104)
        SLFPanel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        SLFPanel.Name = "SLFPanel"
        SLFPanel.Size = New System.Drawing.Size(1307, 953)
        SLFPanel.TabIndex = 7
        ' 
        ' frmStandard
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1307, 1079)
        Controls.Add(SLFPanel)
        Controls.Add(SLFStatus)
        Controls.Add(pnl_)
        Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        Name = "frmStandard"
        StartPosition = Windows.Forms.FormStartPosition.CenterParent
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        SLFStatus.ResumeLayout(False)
        SLFStatus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Public WithEvents SLFLogo As CMCv.pctbx
    Public WithEvents SLFSubNamaForm As CMCv.lbl
    Public WithEvents SLFNamaForm As CMCv.lbl
    Public WithEvents SLFStatus As CMCv.stt
    Public WithEvents pnl_ As CMCv.pnl
    Friend WithEvents SLFStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents SLFPanel As CMCv.pnl
    Public WithEvents SLFBackground As pctbx
End Class
