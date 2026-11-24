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
            Dim MySettings2 As My.MySettings = New My.MySettings()
            pnl_ = New UI.Control.Pnl(components)
            BtnHelp = New UI.Control.Btn(components)
            XOLogo = New UI.Control.Pbx(components)
            SLFLogo = New UI.Control.Pbx(components)
            XOLogoBackground = New UI.Control.Pbx(components)
            XOFormTitle = New UI.Control.Lbl(components)
            XOSubtitle = New UI.Control.Lbl(components)
            XOStatus = New UI.Control.Stt(components)
            SLFStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
            XOPanel = New UI.Control.Pnl(components)
            Ttp = New System.Windows.Forms.ToolTip(components)
            pnl_.SuspendLayout()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            CType(XOLogoBackground, ComponentModel.ISupportInitialize).BeginInit()
            XOStatus.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnl_
            ' 
            pnl_.AutoSize = True
            pnl_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            pnl_.BackColor = Drawing.Color.Black
            pnl_.Controls.Add(BtnHelp)
            pnl_.Controls.Add(XOLogo)
            pnl_.Controls.Add(SLFLogo)
            pnl_.Controls.Add(XOLogoBackground)
            pnl_.Controls.Add(XOFormTitle)
            pnl_.Controls.Add(XOSubtitle)
            pnl_.Dock = System.Windows.Forms.DockStyle.Top
            pnl_.Location = New System.Drawing.Point(0, 0)
            pnl_.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            pnl_.Name = "pnl_"
            pnl_.Size = New System.Drawing.Size(1307, 104)
            pnl_.TabIndex = 999
            ' 
            ' BtnHelp
            ' 
            BtnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnHelp.BackColor = Drawing.Color.Black
            BtnHelp.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(0), CByte(0), CByte(0))
            BtnHelp.FlatAppearance.BorderSize = 2
            BtnHelp.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(20), CByte(20), CByte(20))
            BtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnHelp.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnHelp.ForeColor = Drawing.Color.White
            BtnHelp.Location = New System.Drawing.Point(1231, 19)
            BtnHelp.Name = "BtnHelp"
            BtnHelp.Size = New System.Drawing.Size(64, 64)
            BtnHelp.TabIndex = 1000
            Ttp.SetToolTip(BtnHelp, "Open the User Guide and Documentation.")
            BtnHelp.UseVisualStyleBackColor = False
            BtnHelp.Visible = False
            BtnHelp.XOButtonType = UI.Control.ControlCodeBase.ButtonType.Custom
            BtnHelp.XOShowBorderOnFocus = False
            BtnHelp.XOValidateAllInput = False
            BtnHelp.XOValidateAllInputTag = Nothing
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
            MySettings1.CameraDeviceId = 0
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
            ' XOLogoBackground
            ' 
            XOLogoBackground.BackColor = Drawing.Color.Black
            MySettings2.CameraDeviceId = 0
            MySettings2.MRUFiles = CType(resources.GetObject("MySettings2.MRUFiles"), Specialized.StringCollection)
            MySettings2.SettingsKey = ""
            MySettings2.SLFBackground = Drawing.Color.Black
            XOLogoBackground.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", MySettings2, "SLFBackground", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            XOLogoBackground.ErrorImage = CType(resources.GetObject("XOLogoBackground.ErrorImage"), Drawing.Image)
            XOLogoBackground.InitialImage = CType(resources.GetObject("XOLogoBackground.InitialImage"), Drawing.Image)
            XOLogoBackground.Location = New System.Drawing.Point(3, 6)
            XOLogoBackground.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            XOLogoBackground.Name = "XOLogoBackground"
            XOLogoBackground.Size = New System.Drawing.Size(80, 92)
            XOLogoBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            XOLogoBackground.TabIndex = 998
            XOLogoBackground.TabStop = False
            XOLogoBackground.XOBorderColor = Drawing.Color.DodgerBlue
            XOLogoBackground.XOShowBorder = False
            ' 
            ' XOFormTitle
            ' 
            XOFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            XOFormTitle.BackColor = Drawing.Color.Transparent
            XOFormTitle.Font = New System.Drawing.Font("Segoe UI", 18.0F, Drawing.FontStyle.Bold)
            XOFormTitle.ForeColor = Drawing.Color.White
            XOFormTitle.Location = New System.Drawing.Point(88, 7)
            XOFormTitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            XOFormTitle.Name = "XOFormTitle"
            XOFormTitle.Size = New System.Drawing.Size(1136, 48)
            XOFormTitle.TabIndex = 997
            XOFormTitle.Text = "{Form Title}"
            XOFormTitle.TextAlign = Drawing.ContentAlignment.MiddleLeft
            XOFormTitle.XOCustomElipsis = False
            ' 
            ' XOSubtitle
            ' 
            XOSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            XOSubtitle.BackColor = Drawing.Color.Transparent
            XOSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            XOSubtitle.ForeColor = Drawing.Color.White
            XOSubtitle.Location = New System.Drawing.Point(117, 58)
            XOSubtitle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            XOSubtitle.Name = "XOSubtitle"
            XOSubtitle.Size = New System.Drawing.Size(1107, 25)
            XOSubtitle.TabIndex = 996
            XOSubtitle.Text = "Sub Deskripsi Form"
            XOSubtitle.XOCustomElipsis = False
            ' 
            ' XOStatus
            ' 
            XOStatus.BackColor = Drawing.SystemColors.Control
            XOStatus.ImageScalingSize = New System.Drawing.Size(24, 24)
            XOStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {SLFStatusLabel})
            XOStatus.Location = New System.Drawing.Point(0, 1057)
            XOStatus.Name = "XOStatus"
            XOStatus.Padding = New System.Windows.Forms.Padding(2, 0, 23, 0)
            XOStatus.Size = New System.Drawing.Size(1307, 22)
            XOStatus.TabIndex = 994
            XOStatus.Text = "Stt1"
            ' 
            ' SLFStatusLabel
            ' 
            SLFStatusLabel.ForeColor = Drawing.Color.Black
            SLFStatusLabel.Name = "SLFStatusLabel"
            SLFStatusLabel.Size = New System.Drawing.Size(0, 15)
            ' 
            ' XOPanel
            ' 
            XOPanel.AutoScroll = True
            XOPanel.AutoSize = True
            XOPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            XOPanel.Dock = System.Windows.Forms.DockStyle.Fill
            XOPanel.Location = New System.Drawing.Point(0, 104)
            XOPanel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            XOPanel.Name = "XOPanel"
            XOPanel.Size = New System.Drawing.Size(1307, 953)
            XOPanel.TabIndex = 7
            ' 
            ' Ttp
            ' 
            Ttp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
            Ttp.ToolTipTitle = "Guide Book"
            ' 
            ' FRMstandard
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
            BackColor = Drawing.Color.FromArgb(CByte(11), CByte(28), CByte(45))
            ClientSize = New System.Drawing.Size(1307, 1079)
            Controls.Add(XOPanel)
            Controls.Add(XOStatus)
            Controls.Add(pnl_)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
            Name = "FRMstandard"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Text = "{Form Title}"
            pnl_.ResumeLayout(False)
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            CType(XOLogoBackground, ComponentModel.ISupportInitialize).EndInit()
            XOStatus.ResumeLayout(False)
            XOStatus.PerformLayout()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Public WithEvents SLFLogo As UI.Control.Pbx
        Public WithEvents XOSubtitle As UI.Control.Lbl
        Public WithEvents XOFormTitle As UI.Control.Lbl
        Public WithEvents XOStatus As UI.Control.Stt
        Public WithEvents pnl_ As UI.Control.Pnl
        Friend WithEvents SLFStatusLabel As System.Windows.Forms.ToolStripStatusLabel
        Public WithEvents XOPanel As UI.Control.Pnl
        Public WithEvents XOLogoBackground As UI.Control.Pbx
        Public WithEvents XOLogo As UI.Control.Pbx
        Friend WithEvents BtnHelp As UI.Control.Btn
        Friend WithEvents Ttp As System.Windows.Forms.ToolTip
    End Class
End Namespace