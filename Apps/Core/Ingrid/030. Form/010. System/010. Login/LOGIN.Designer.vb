<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits CMCv.Std_Fo

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
        Me.BtnLogin = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.TxtUsername = New CMCv.txt(Me.components)
        Me.TxtPassword = New CMCv.txt(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.tmr_status = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_control = New System.Windows.Forms.Timer(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnLogin)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 128)
        Me.PnlBottomButton.Size = New System.Drawing.Size(378, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnLogin, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(378, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.Lbl2)
        Me.SLFPanel.Controls.Add(Me.Lbl1)
        Me.SLFPanel.Controls.Add(Me.TxtPassword)
        Me.SLFPanel.Controls.Add(Me.TxtUsername)
        Me.SLFPanel.Size = New System.Drawing.Size(378, 178)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtUsername, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPassword, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl2, 0)
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLogin.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 2
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(160, 7)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(100, 40)
        Me.BtnLogin.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnLogin.SLFTampilkanFocusBorder = False
        Me.BtnLogin.SLFValidasiSemuaInput = False
        Me.BtnLogin.SLFValidasiSemuaInputTag = Nothing
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "&Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.Red
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(266, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtUsername
        '
        Me.TxtUsername.AcceptsReturn = True
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtUsername.Location = New System.Drawing.Point(109, 32)
        Me.TxtUsername.MaxLength = 255
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(229, 29)
        Me.TxtUsername.SLFAutoTrim = True
        Me.TxtUsername.SLFHarusDiisi = True
        Me.TxtUsername.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtUsername.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtUsername.SLFHightlightSaatFokus = True
        Me.TxtUsername.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtUsername.SLFIsBlank = True
        Me.TxtUsername.SLFIsSearchBox = False
        Me.TxtUsername.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtUsername.SLFPilihSemuaSaatFokus = False
        Me.TxtUsername.SLFPwdLengthMin = 8
        Me.TxtUsername.SLFPwdStrengthCalculate = False
        Me.TxtUsername.SLFPwdStrengthScore = 0
        Me.TxtUsername.SLFPwdStrengthText = Nothing
        Me.TxtUsername.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtUsername.SLFSearchBoxText = "Type then press Enter"
        Me.TxtUsername.SLFSQLText = ""
        Me.TxtUsername.SLFTanpaSpasi = False
        Me.TxtUsername.SLFValidasiField = Nothing
        Me.TxtUsername.TabIndex = 0
        Me.TxtUsername.Tag = "txt"
        '
        'TxtPassword
        '
        Me.TxtPassword.AcceptsReturn = True
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPassword.Location = New System.Drawing.Point(109, 67)
        Me.TxtPassword.MaxLength = 255
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(229, 29)
        Me.TxtPassword.SLFAutoTrim = False
        Me.TxtPassword.SLFHarusDiisi = True
        Me.TxtPassword.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPassword.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPassword.SLFHightlightSaatFokus = True
        Me.TxtPassword.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPassword.SLFIsBlank = True
        Me.TxtPassword.SLFIsSearchBox = False
        Me.TxtPassword.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtPassword.SLFPilihSemuaSaatFokus = False
        Me.TxtPassword.SLFPwdLengthMin = 8
        Me.TxtPassword.SLFPwdStrengthCalculate = False
        Me.TxtPassword.SLFPwdStrengthScore = 0
        Me.TxtPassword.SLFPwdStrengthText = Nothing
        Me.TxtPassword.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPassword.SLFSearchBoxText = "Type then press Enter"
        Me.TxtPassword.SLFSQLText = ""
        Me.TxtPassword.SLFTanpaSpasi = False
        Me.TxtPassword.SLFValidasiField = Nothing
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.Tag = "txt"
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(22, 35)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(81, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 998
        Me.Lbl1.Text = "Username"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl2.Location = New System.Drawing.Point(27, 70)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(76, 21)
        Me.Lbl2.SLFCustomElipsis = False
        Me.Lbl2.TabIndex = 999
        Me.Lbl2.Text = "Password"
        '
        'tmr_status
        '
        Me.tmr_status.Interval = 1000
        '
        'tmr_control
        '
        Me.tmr_control.Interval = 1000
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(378, 254)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "LOGIN"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnLogin As CMCv.btn
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents TxtPassword As CMCv.txt
    Friend WithEvents TxtUsername As CMCv.txt
    Friend WithEvents tmr_status As Timer
    Friend WithEvents tmr_control As Timer
End Class
