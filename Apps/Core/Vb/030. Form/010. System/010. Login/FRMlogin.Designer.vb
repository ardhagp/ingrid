<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMlogin
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
        components = New ComponentModel.Container()
        BtnLogin = New btn(components)
        BtnCancel = New btn(components)
        TxtUsername = New txt(components)
        TxtPassword = New txt(components)
        Lbl1 = New lbl(components)
        Lbl2 = New lbl(components)
        tmr_status = New Timer(components)
        tmr_control = New Timer(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnCancel)
        PnlBottomButton.Controls.Add(BtnLogin)
        PnlBottomButton.Location = New Point(0, 259)
        PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New Size(630, 97)
        PnlBottomButton.Controls.SetChildIndex(BtnLogin, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(630, 110)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Lbl2)
        SLFPanel.Controls.Add(Lbl1)
        SLFPanel.Controls.Add(TxtPassword)
        SLFPanel.Controls.Add(TxtUsername)
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(630, 356)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(TxtUsername, 0)
        SLFPanel.Controls.SetChildIndex(TxtPassword, 0)
        SLFPanel.Controls.SetChildIndex(Lbl1, 0)
        SLFPanel.Controls.SetChildIndex(Lbl2, 0)
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnLogin.BackColor = Color.LimeGreen
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnLogin.FlatAppearance.BorderSize = 2
        BtnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(266, 13)
        BtnLogin.Margin = New Padding(6, 5, 6, 5)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(167, 77)
        BtnLogin.TabIndex = 2
        BtnLogin.Text = "&Login"
        BtnLogin.UseVisualStyleBackColor = False
        BtnLogin.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnLogin.XOTampilkanFocusBorder = False
        BtnLogin.XOValidasiSemuaInput = False
        BtnLogin.XOValidasiSemuaInputTag = Nothing
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnCancel.BackColor = Color.Red
        BtnCancel.Cursor = Cursors.Hand
        BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnCancel.FlatAppearance.BorderSize = 2
        BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnCancel.FlatStyle = FlatStyle.Flat
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(443, 13)
        BtnCancel.Margin = New Padding(6, 5, 6, 5)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(167, 77)
        BtnCancel.TabIndex = 3
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' TxtUsername
        ' 
        TxtUsername.AcceptsReturn = True
        TxtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(181, 62)
        TxtUsername.Margin = New Padding(6, 5, 6, 5)
        TxtUsername.MaxLength = 255
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(378, 39)
        TxtUsername.TabIndex = 0
        TxtUsername.Tag = "txt"
        TxtUsername.XOAutoTrim = True
        TxtUsername.XOHarusDiisi = True
        TxtUsername.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtUsername.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtUsername.XOHightlightSaatFokus = True
        TxtUsername.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtUsername.XOIsBlank = True
        TxtUsername.XOIsSearchBox = False
        TxtUsername.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtUsername.XOPilihSemuaSaatFokus = False
        TxtUsername.XOPwdLengthMin = 8
        TxtUsername.XOPwdStrengthCalculate = False
        TxtUsername.XOPwdStrengthScore = 0
        TxtUsername.XOPwdStrengthText = Nothing
        TxtUsername.XORestriction = ControlCodeBase.enuRestriction.None
        TxtUsername.XOSearchBoxText = "Type then press Enter"
        TxtUsername.XOSQLText = ""
        TxtUsername.XOTanpaSpasi = False
        TxtUsername.XOValidasiField = Nothing
        ' 
        ' TxtPassword
        ' 
        TxtPassword.AcceptsReturn = True
        TxtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(181, 128)
        TxtPassword.Margin = New Padding(6, 5, 6, 5)
        TxtPassword.MaxLength = 255
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "●"c
        TxtPassword.Size = New Size(378, 39)
        TxtPassword.TabIndex = 1
        TxtPassword.Tag = "txt"
        TxtPassword.XOAutoTrim = False
        TxtPassword.XOHarusDiisi = True
        TxtPassword.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtPassword.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtPassword.XOHightlightSaatFokus = True
        TxtPassword.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtPassword.XOIsBlank = True
        TxtPassword.XOIsSearchBox = False
        TxtPassword.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtPassword.XOPilihSemuaSaatFokus = False
        TxtPassword.XOPwdLengthMin = 8
        TxtPassword.XOPwdStrengthCalculate = False
        TxtPassword.XOPwdStrengthScore = 0
        TxtPassword.XOPwdStrengthText = Nothing
        TxtPassword.XORestriction = ControlCodeBase.enuRestriction.None
        TxtPassword.XOSearchBoxText = "Type then press Enter"
        TxtPassword.XOSQLText = ""
        TxtPassword.XOTanpaSpasi = False
        TxtPassword.XOValidasiField = Nothing
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(37, 67)
        Lbl1.Margin = New Padding(6, 0, 6, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(121, 32)
        Lbl1.TabIndex = 998
        Lbl1.Text = "Username"
        Lbl1.XOCustomElipsis = False
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl2.Location = New Point(44, 135)
        Lbl2.Margin = New Padding(6, 0, 6, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(111, 32)
        Lbl2.TabIndex = 999
        Lbl2.Text = "Password"
        Lbl2.XOCustomElipsis = False
        ' 
        ' tmr_status
        ' 
        tmr_status.Interval = 1000
        ' 
        ' tmr_control
        ' 
        tmr_control.Interval = 1000
        ' 
        ' FRMlogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(630, 488)
        ControlBox = False
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMlogin"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnCancel As btn
    Friend WithEvents BtnLogin As btn
    Friend WithEvents Lbl2 As lbl
    Friend WithEvents Lbl1 As lbl
    Friend WithEvents TxtPassword As txt
    Friend WithEvents TxtUsername As txt
    Friend WithEvents tmr_status As Timer
    Friend WithEvents tmr_control As Timer
End Class
