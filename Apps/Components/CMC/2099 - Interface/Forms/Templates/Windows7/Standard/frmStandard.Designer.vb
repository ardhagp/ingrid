Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMstandard
        Inherits UI.Canvas.FRMblank

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMstandard))
            Dim MySettings1 As My.MySettings = New My.MySettings()
            pnl_ = New UI.Control.Pnl(components)
            XOLogo = New UI.Control.Pbx(components)
            SLFLogo = New UI.Control.Pbx(components)
            SLFBackground = New UI.Control.Pbx(components)
            SLFNamaForm = New UI.Control.Lbl(components)
            SLFSubNamaForm = New UI.Control.Lbl(components)
            SLFStatus = New UI.Control.Stt(components)
            SLFStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            SLFPanel = New UI.Control.Pnl(components)
            pnl_.SuspendLayout()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            SLFStatus.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnl_
            ' 
            pnl_.AutoSize = True
            pnl_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            pnl_.BackColor = Drawing.Color.Black
            pnl_.Controls.Add(XOLogo)
            pnl_.Controls.Add(SLFLogo)
            pnl_.Controls.Add(SLFBackground)
            pnl_.Controls.Add(SLFNamaForm)
            pnl_.Controls.Add(SLFSubNamaForm)
            pnl_.Dock = System.Windows.Forms.DockStyle.Top
            pnl_.Location = New System.Drawing.Point(0, 0)
            pnl_.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            pnl_.Name = "pnl_"
            pnl_.Size = New System.Drawing.Size(1307, 104)
            pnl_.TabIndex = 999
            ' 
            ' XOLogo
            ' 
            XOLogo.BackColor = Drawing.Color.Transparent
            XOLogo.ErrorImage = CType(resources.GetObject("XOLogo.ErrorImage"), Drawing.Image)
            XOLogo.InitialImage = CType(resources.GetObject("XOLogo.InitialImage"), Drawing.Image)
            XOLogo.Location = New System.Drawing.Point(7, 10)
            XOLogo.Name = "XOLogo"
            XOLogo.Size = New System.Drawing.Size(73, 85)
            XOLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            XOLogo.TabIndex = 999
            XOLogo.TabStop = False
            XOLogo.XOBorderColor = Drawing.Color.DodgerBlue
            XOLogo.XOShowBorder = False
            ' 
            ' SLFLogo
            ' 
            SLFLogo.BackColor = Drawing.Color.Black
            MySettings1.MRUFiles = CType(resources.GetObject("MySettings1.MRUFiles"), Specialized.StringCollection)
            MySettings1.SettingsKey = ""
            MySettings1.SLFBackground = Drawing.Color.Black
            SLFLogo.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "SLFBackground", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            SLFLogo.ErrorImage = CType(resources.GetObject("SLFLogo.ErrorImage"), Drawing.Image)
            SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Drawing.Image)
            SLFLogo.InitialImage = CType(resources.GetObject("SLFLogo.InitialImage"), Drawing.Image)
            SLFLogo.Location = New System.Drawing.Point(7, 10)
            SLFLogo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            SLFLogo.Name = "SLFLogo"
            SLFLogo.Size = New System.Drawing.Size(73, 85)
            SLFLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            SLFLogo.TabIndex = 0
            SLFLogo.TabStop = False
            SLFLogo.Visible = False
            SLFLogo.XOBorderColor = Drawing.Color.DodgerBlue
            SLFLogo.XOShowBorder = False
            ' 
            ' SLFBackground
            ' 
            SLFBackground.BackColor = Drawing.Color.Black
            SLFBackground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings1, "SLFBackground", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            SLFBackground.ErrorImage = CType(resources.GetObject("SLFBackground.ErrorImage"), Drawing.Image)
            SLFBackground.InitialImage = CType(resources.GetObject("SLFBackground.InitialImage"), Drawing.Image)
            SLFBackground.Location = New System.Drawing.Point(3, 6)
            SLFBackground.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            SLFBackground.Name = "SLFBackground"
            SLFBackground.Size = New System.Drawing.Size(80, 92)
            SLFBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            SLFBackground.TabIndex = 998
            SLFBackground.TabStop = False
            SLFBackground.XOBorderColor = Drawing.Color.DodgerBlue
            SLFBackground.XOShowBorder = False
            ' 
            ' SLFNamaForm
            ' 
            SLFNamaForm.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            SLFNamaForm.AutoSize = True
            SLFNamaForm.BackColor = Drawing.Color.Transparent
            SLFNamaForm.Font = New System.Drawing.Font("Segoe UI", 18.0F, Drawing.FontStyle.Bold)
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
            SLFSubNamaForm.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            SLFSubNamaForm.AutoSize = True
            SLFSubNamaForm.BackColor = Drawing.Color.Transparent
            SLFSubNamaForm.Font = New System.Drawing.Font("Segoe UI", 9.0F)
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
            SLFStatus.BackColor = Drawing.SystemColors.Control
            SLFStatus.ImageScalingSize = New System.Drawing.Size(24, 24)
            SLFStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {SLFStatusLabel})
            SLFStatus.Location = New System.Drawing.Point(0, 1057)
            SLFStatus.Name = "SLFStatus"
            SLFStatus.Padding = New System.Windows.Forms.Padding(2, 0, 23, 0)
            SLFStatus.Size = New System.Drawing.Size(1307, 22)
            SLFStatus.TabIndex = 994
            SLFStatus.Text = "Stt1"
            ' 
            ' SLFStatusLabel
            ' 
            SLFStatusLabel.ForeColor = Drawing.Color.Black
            SLFStatusLabel.Name = "SLFStatusLabel"
            SLFStatusLabel.Size = New System.Drawing.Size(0, 15)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.AutoScroll = True
            SLFPanel.AutoSize = True
            SLFPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            SLFPanel.Dock = System.Windows.Forms.DockStyle.Fill
            SLFPanel.Location = New System.Drawing.Point(0, 104)
            SLFPanel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            SLFPanel.Name = "SLFPanel"
            SLFPanel.Size = New System.Drawing.Size(1307, 953)
            SLFPanel.TabIndex = 7
            ' 
            ' FRMstandard
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
            BackColor = Drawing.Color.FromArgb(CByte(11), CByte(28), CByte(45))
            ClientSize = New System.Drawing.Size(1307, 1079)
            Controls.Add(SLFPanel)
            Controls.Add(SLFStatus)
            Controls.Add(pnl_)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            Name = "FRMstandard"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            SLFStatus.ResumeLayout(False)
            SLFStatus.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Public WithEvents SLFLogo As UI.Control.Pbx
        Public WithEvents SLFSubNamaForm As UI.Control.Lbl
        Public WithEvents SLFNamaForm As UI.Control.Lbl
        Public WithEvents SLFStatus As UI.Control.Stt
        Public WithEvents pnl_ As UI.Control.Pnl
        Friend WithEvents SLFStatusLabel As System.Windows.Forms.ToolStripStatusLabel
        Public WithEvents SLFPanel As UI.Control.Pnl
        Public WithEvents SLFBackground As UI.Control.Pbx
        Public WithEvents XOLogo As UI.Control.Pbx
    End Class
End Namespace