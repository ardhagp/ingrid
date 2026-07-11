Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMapplauncher
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMapplauncher))
            Lbl1 = New CMCv.UI.Control.Lbl(components)
            LblBuild = New CMCv.UI.Control.Lbl(components)
            BtnLaunch = New CMCv.UI.Control.Btn(components)
            Lbl3 = New CMCv.UI.Control.Lbl(components)
            Lbl4 = New CMCv.UI.Control.Lbl(components)
            CboApplication = New CMCv.UI.Control.Cbo(components)
            tmrCountdown = New Timer(components)
            LblLeft = New CMCv.UI.Control.Lbl(components)
            LblRight = New CMCv.UI.Control.Lbl(components)
            BtnClose = New CMCv.UI.Control.Btn(components)
            LblVersion = New CMCv.UI.Control.Lbl(components)
            SuspendLayout()
            ' 
            ' Lbl1
            ' 
            Lbl1.BackColor = Color.Transparent
            Lbl1.Font = New Font("Segoe UI", 72F, FontStyle.Bold)
            Lbl1.ForeColor = Color.White
            Lbl1.Location = New Point(13, -8)
            Lbl1.Margin = New Padding(4, 0, 4, 0)
            Lbl1.Name = "Lbl1"
            Lbl1.Size = New Size(526, 213)
            Lbl1.TabIndex = 0
            Lbl1.Text = "Ingrid"
            Lbl1.TextAlign = ContentAlignment.TopCenter
            Lbl1.XOCustomElipsis = False
            ' 
            ' LblBuild
            ' 
            LblBuild.BackColor = Color.Transparent
            LblBuild.Font = New Font("Segoe UI", 12F)
            LblBuild.ForeColor = Color.White
            LblBuild.Location = New Point(293, 187)
            LblBuild.Margin = New Padding(4, 0, 4, 0)
            LblBuild.Name = "LblBuild"
            LblBuild.Size = New Size(171, 85)
            LblBuild.TabIndex = 1
            LblBuild.Text = "Build"
            LblBuild.TextAlign = ContentAlignment.TopRight
            LblBuild.XOCustomElipsis = False
            ' 
            ' BtnLaunch
            ' 
            BtnLaunch.Anchor = AnchorStyles.Top
            BtnLaunch.AutoSize = True
            BtnLaunch.BackColor = Color.LimeGreen
            BtnLaunch.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnLaunch.FlatAppearance.BorderSize = 2
            BtnLaunch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnLaunch.FlatStyle = FlatStyle.Flat
            BtnLaunch.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnLaunch.ForeColor = Color.White
            BtnLaunch.Location = New Point(177, 635)
            BtnLaunch.Margin = New Padding(4, 5, 4, 5)
            BtnLaunch.Name = "BtnLaunch"
            BtnLaunch.Size = New Size(187, 67)
            BtnLaunch.TabIndex = 1
            BtnLaunch.Text = "&Launch"
            BtnLaunch.UseVisualStyleBackColor = False
            BtnLaunch.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
            BtnLaunch.XOShowBorderOnFocus = False
            BtnLaunch.XOValidateAllInput = False
            BtnLaunch.XOValidateAllInputTag = Nothing
            ' 
            ' Lbl3
            ' 
            Lbl3.BackColor = Color.White
            Lbl3.BorderStyle = BorderStyle.Fixed3D
            Lbl3.Font = New Font("Segoe UI", 2F)
            Lbl3.Location = New Point(293, 183)
            Lbl3.Margin = New Padding(4, 0, 4, 0)
            Lbl3.Name = "Lbl3"
            Lbl3.Size = New Size(229, 3)
            Lbl3.TabIndex = 3
            Lbl3.XOCustomElipsis = False
            ' 
            ' Lbl4
            ' 
            Lbl4.BackColor = Color.White
            Lbl4.BorderStyle = BorderStyle.Fixed3D
            Lbl4.Font = New Font("Segoe UI", 2F)
            Lbl4.Location = New Point(13, 183)
            Lbl4.Margin = New Padding(4, 0, 4, 0)
            Lbl4.Name = "Lbl4"
            Lbl4.Size = New Size(180, 3)
            Lbl4.TabIndex = 4
            Lbl4.XOCustomElipsis = False
            ' 
            ' CboApplication
            ' 
            CboApplication.DropDownStyle = ComboBoxStyle.DropDownList
            CboApplication.FlatStyle = FlatStyle.Flat
            CboApplication.Font = New Font("Segoe UI", 12F)
            CboApplication.FormattingEnabled = True
            CboApplication.Location = New Point(155, 503)
            CboApplication.Margin = New Padding(4, 5, 4, 5)
            CboApplication.Name = "CboApplication"
            CboApplication.Size = New Size(131, 40)
            CboApplication.TabIndex = 0
            ' 
            ' tmrCountdown
            ' 
            tmrCountdown.Interval = 1000
            ' 
            ' LblLeft
            ' 
            LblLeft.BackColor = Color.Transparent
            LblLeft.Font = New Font("Segoe UI", 12F)
            LblLeft.ForeColor = Color.White
            LblLeft.Location = New Point(13, 508)
            LblLeft.Margin = New Padding(4, 0, 4, 0)
            LblLeft.Name = "LblLeft"
            LblLeft.Size = New Size(134, 35)
            LblLeft.TabIndex = 6
            LblLeft.Text = "Opening"
            LblLeft.TextAlign = ContentAlignment.TopRight
            LblLeft.XOCustomElipsis = False
            ' 
            ' LblRight
            ' 
            LblRight.BackColor = Color.Transparent
            LblRight.Font = New Font("Segoe UI", 12F)
            LblRight.ForeColor = Color.White
            LblRight.Location = New Point(294, 508)
            LblRight.Margin = New Padding(4, 0, 4, 0)
            LblRight.Name = "LblRight"
            LblRight.Size = New Size(232, 35)
            LblRight.TabIndex = 7
            LblRight.Text = "app in 3 seconds..."
            LblRight.XOCustomElipsis = False
            ' 
            ' BtnClose
            ' 
            BtnClose.BackColor = Color.Red
            BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClose.FlatAppearance.BorderSize = 2
            BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClose.FlatStyle = FlatStyle.Flat
            BtnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnClose.ForeColor = Color.White
            BtnClose.Location = New Point(476, 12)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(46, 45)
            BtnClose.TabIndex = 8
            BtnClose.Text = "X"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.Visible = False
            BtnClose.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
            ' 
            ' LblVersion
            ' 
            LblVersion.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            LblVersion.AutoEllipsis = True
            LblVersion.BackColor = Color.Transparent
            LblVersion.Font = New Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
            LblVersion.ForeColor = Color.White
            LblVersion.Location = New Point(13, 720)
            LblVersion.Name = "LblVersion"
            LblVersion.Size = New Size(514, 21)
            LblVersion.TabIndex = 9
            LblVersion.Text = "ver. 0.0"
            LblVersion.TextAlign = ContentAlignment.BottomLeft
            LblVersion.XOCustomElipsis = False
            ' 
            ' FRMapplauncher
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.Black
            ClientSize = New Size(539, 750)
            ControlBox = False
            Controls.Add(BtnClose)
            Controls.Add(LblRight)
            Controls.Add(LblLeft)
            Controls.Add(CboApplication)
            Controls.Add(Lbl4)
            Controls.Add(Lbl3)
            Controls.Add(LblBuild)
            Controls.Add(BtnLaunch)
            Controls.Add(Lbl1)
            Controls.Add(LblVersion)
            FormBorderStyle = FormBorderStyle.None
            Icon = CType(resources.GetObject("$this.Icon"), Icon)
            Margin = New Padding(4, 5, 4, 5)
            Name = "FRMapplauncher"
            StartPosition = FormStartPosition.CenterScreen
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
        Friend WithEvents LblBuild As CMCv.UI.Control.lbl
        Friend WithEvents BtnLaunch As CMCv.UI.Control.Btn
        Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
        Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
        Friend WithEvents CboApplication As CMCv.UI.Control.Cbo
        Friend WithEvents tmrCountdown As Timer
        Friend WithEvents LblLeft As CMCv.UI.Control.lbl
        Friend WithEvents LblRight As CMCv.UI.Control.lbl
        Friend WithEvents BtnClose As CMCv.UI.Control.Btn
        Friend WithEvents LblVersion As CMCv.UI.Control.Lbl
    End Class
End Namespace