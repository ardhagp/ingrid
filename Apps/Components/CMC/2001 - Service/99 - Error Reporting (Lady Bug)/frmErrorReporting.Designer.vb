<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMerrorreporting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMerrorreporting))
        BtnClose = New CMCv.UI.Control.btn(components)
        Tbctl1 = New CMCv.UI.Control.tbctl(components)
        tp_ApplicationFault = New Windows.Forms.TabPage()
        Lbl4 = New CMCv.UI.Control.lbl(components)
        TxtAppBuild = New CMCv.UI.Control.txt(components)
        TxtErrorNumber = New CMCv.UI.Control.txt(components)
        Lbl3 = New CMCv.UI.Control.lbl(components)
        TxtErrorMessage = New CMCv.UI.Control.txt(components)
        Lbl2 = New CMCv.UI.Control.lbl(components)
        TxtErrorType = New CMCv.UI.Control.txt(components)
        Lbl1 = New CMCv.UI.Control.lbl(components)
        tp_SystemInformation = New Windows.Forms.TabPage()
        ChkErrorReporting = New CMCv.UI.Control.chk(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Tbctl1.SuspendLayout()
        tp_ApplicationFault.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(ChkErrorReporting)
        PnlBottomButton.Controls.Add(BtnClose)
        PnlBottomButton.Location = New System.Drawing.Point(0, 764)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New System.Drawing.Size(1086, 96)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        PnlBottomButton.Controls.SetChildIndex(ChkErrorReporting, 0)
        ' 
        ' SLFLogo
        ' 
        SLFLogo.BackColor = Drawing.Color.Red
        SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Drawing.Image)
        SLFLogo.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        pnl_.Size = New System.Drawing.Size(1086, 118)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Tbctl1)
        SLFPanel.Location = New System.Drawing.Point(0, 118)
        SLFPanel.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        SLFPanel.Size = New System.Drawing.Size(1086, 860)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Tbctl1, 0)
        ' 
        ' SLFBackground
        ' 
        SLFBackground.Margin = New System.Windows.Forms.Padding(11, 20, 11, 20)
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.Red
        BtnClose.Cursor = Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New System.Drawing.Point(899, 14)
        BtnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(167, 77)
        BtnClose.TabIndex = 0
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.XOTampilkanFocusBorder = False
        BtnClose.XOValidasiSemuaInput = False
        BtnClose.XOValidasiSemuaInputTag = Nothing
        ' 
        ' Tbctl1
        ' 
        Tbctl1.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        Tbctl1.Controls.Add(tp_ApplicationFault)
        Tbctl1.Controls.Add(tp_SystemInformation)
        Tbctl1.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Tbctl1.Location = New System.Drawing.Point(20, 12)
        Tbctl1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Tbctl1.Name = "Tbctl1"
        Tbctl1.SelectedIndex = 0
        Tbctl1.Size = New System.Drawing.Size(1046, 749)
        Tbctl1.TabIndex = 1
        ' 
        ' tp_ApplicationFault
        ' 
        tp_ApplicationFault.Controls.Add(Lbl4)
        tp_ApplicationFault.Controls.Add(TxtAppBuild)
        tp_ApplicationFault.Controls.Add(TxtErrorNumber)
        tp_ApplicationFault.Controls.Add(Lbl3)
        tp_ApplicationFault.Controls.Add(TxtErrorMessage)
        tp_ApplicationFault.Controls.Add(Lbl2)
        tp_ApplicationFault.Controls.Add(TxtErrorType)
        tp_ApplicationFault.Controls.Add(Lbl1)
        tp_ApplicationFault.Location = New System.Drawing.Point(4, 41)
        tp_ApplicationFault.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        tp_ApplicationFault.Name = "tp_ApplicationFault"
        tp_ApplicationFault.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        tp_ApplicationFault.Size = New System.Drawing.Size(1038, 704)
        tp_ApplicationFault.TabIndex = 0
        tp_ApplicationFault.Text = "Application Fault"
        tp_ApplicationFault.UseVisualStyleBackColor = True
        ' 
        ' Lbl4
        ' 
        Lbl4.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        Lbl4.AutoSize = True
        Lbl4.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl4.Location = New System.Drawing.Point(423, 552)
        Lbl4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New System.Drawing.Size(207, 32)
        Lbl4.TabIndex = 7
        Lbl4.Text = "Application Build :"
        Lbl4.XOCustomElipsis = False
        ' 
        ' TxtAppBuild
        ' 
        TxtAppBuild.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        TxtAppBuild.BackColor = Drawing.Color.White
        TxtAppBuild.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtAppBuild.Location = New System.Drawing.Point(423, 597)
        TxtAppBuild.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        TxtAppBuild.MaxLength = 255
        TxtAppBuild.Name = "TxtAppBuild"
        TxtAppBuild.ReadOnly = True
        TxtAppBuild.Size = New System.Drawing.Size(341, 39)
        TxtAppBuild.TabIndex = 6
        TxtAppBuild.Tag = "txt"
        TxtAppBuild.XOAutoTrim = False
        TxtAppBuild.XOHarusDiisi = False
        TxtAppBuild.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtAppBuild.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtAppBuild.XOHightlightSaatFokus = False
        TxtAppBuild.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtAppBuild.XOIsBlank = True
        TxtAppBuild.XOIsSearchBox = False
        TxtAppBuild.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtAppBuild.XOPilihSemuaSaatFokus = False
        TxtAppBuild.XOPwdLengthMin = 8
        TxtAppBuild.XOPwdStrengthCalculate = False
        TxtAppBuild.XOPwdStrengthScore = 0
        TxtAppBuild.XOPwdStrengthText = Nothing
        TxtAppBuild.XORestriction = ControlCodeBase.enuRestriction.None
        TxtAppBuild.XOSearchBoxText = "Type then press Enter"
        TxtAppBuild.XOSQLText = Nothing
        TxtAppBuild.XOTanpaSpasi = False
        TxtAppBuild.XOValidasiField = Nothing
        ' 
        ' TxtErrorNumber
        ' 
        TxtErrorNumber.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        TxtErrorNumber.BackColor = Drawing.Color.White
        TxtErrorNumber.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorNumber.Location = New System.Drawing.Point(10, 597)
        TxtErrorNumber.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        TxtErrorNumber.MaxLength = 255
        TxtErrorNumber.Name = "TxtErrorNumber"
        TxtErrorNumber.ReadOnly = True
        TxtErrorNumber.Size = New System.Drawing.Size(401, 39)
        TxtErrorNumber.TabIndex = 5
        TxtErrorNumber.Tag = "txt"
        TxtErrorNumber.XOAutoTrim = False
        TxtErrorNumber.XOHarusDiisi = False
        TxtErrorNumber.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorNumber.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorNumber.XOHightlightSaatFokus = False
        TxtErrorNumber.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorNumber.XOIsBlank = True
        TxtErrorNumber.XOIsSearchBox = False
        TxtErrorNumber.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorNumber.XOPilihSemuaSaatFokus = False
        TxtErrorNumber.XOPwdLengthMin = 8
        TxtErrorNumber.XOPwdStrengthCalculate = False
        TxtErrorNumber.XOPwdStrengthScore = 0
        TxtErrorNumber.XOPwdStrengthText = Nothing
        TxtErrorNumber.XORestriction = ControlCodeBase.enuRestriction.None
        TxtErrorNumber.XOSearchBoxText = "Type then press Enter"
        TxtErrorNumber.XOSQLText = Nothing
        TxtErrorNumber.XOTanpaSpasi = False
        TxtErrorNumber.XOValidasiField = Nothing
        ' 
        ' Lbl3
        ' 
        Lbl3.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left
        Lbl3.AutoSize = True
        Lbl3.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl3.Location = New System.Drawing.Point(10, 552)
        Lbl3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New System.Drawing.Size(171, 32)
        Lbl3.TabIndex = 4
        Lbl3.Text = "Error Number :"
        Lbl3.XOCustomElipsis = False
        ' 
        ' TxtErrorMessage
        ' 
        TxtErrorMessage.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        TxtErrorMessage.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorMessage.Location = New System.Drawing.Point(10, 160)
        TxtErrorMessage.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        TxtErrorMessage.MaxLength = 255
        TxtErrorMessage.Multiline = True
        TxtErrorMessage.Name = "TxtErrorMessage"
        TxtErrorMessage.ScrollBars = Windows.Forms.ScrollBars.Vertical
        TxtErrorMessage.Size = New System.Drawing.Size(1009, 383)
        TxtErrorMessage.TabIndex = 3
        TxtErrorMessage.Tag = "txt"
        TxtErrorMessage.XOAutoTrim = False
        TxtErrorMessage.XOHarusDiisi = False
        TxtErrorMessage.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorMessage.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorMessage.XOHightlightSaatFokus = False
        TxtErrorMessage.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorMessage.XOIsBlank = True
        TxtErrorMessage.XOIsSearchBox = False
        TxtErrorMessage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorMessage.XOPilihSemuaSaatFokus = False
        TxtErrorMessage.XOPwdLengthMin = 8
        TxtErrorMessage.XOPwdStrengthCalculate = False
        TxtErrorMessage.XOPwdStrengthScore = 0
        TxtErrorMessage.XOPwdStrengthText = Nothing
        TxtErrorMessage.XORestriction = ControlCodeBase.enuRestriction.None
        TxtErrorMessage.XOSearchBoxText = "Type then press Enter"
        TxtErrorMessage.XOSQLText = Nothing
        TxtErrorMessage.XOTanpaSpasi = False
        TxtErrorMessage.XOValidasiField = Nothing
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl2.Location = New System.Drawing.Point(10, 113)
        Lbl2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New System.Drawing.Size(120, 32)
        Lbl2.TabIndex = 2
        Lbl2.Text = "Message :"
        Lbl2.XOCustomElipsis = False
        ' 
        ' TxtErrorType
        ' 
        TxtErrorType.BackColor = Drawing.Color.White
        TxtErrorType.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorType.Location = New System.Drawing.Point(10, 52)
        TxtErrorType.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        TxtErrorType.MaxLength = 255
        TxtErrorType.Name = "TxtErrorType"
        TxtErrorType.ReadOnly = True
        TxtErrorType.Size = New System.Drawing.Size(401, 39)
        TxtErrorType.TabIndex = 1
        TxtErrorType.Tag = "txt"
        TxtErrorType.XOAutoTrim = False
        TxtErrorType.XOHarusDiisi = False
        TxtErrorType.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtErrorType.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtErrorType.XOHightlightSaatFokus = False
        TxtErrorType.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtErrorType.XOIsBlank = True
        TxtErrorType.XOIsSearchBox = False
        TxtErrorType.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtErrorType.XOPilihSemuaSaatFokus = False
        TxtErrorType.XOPwdLengthMin = 8
        TxtErrorType.XOPwdStrengthCalculate = False
        TxtErrorType.XOPwdStrengthScore = 0
        TxtErrorType.XOPwdStrengthText = Nothing
        TxtErrorType.XORestriction = ControlCodeBase.enuRestriction.None
        TxtErrorType.XOSearchBoxText = "Type then press Enter"
        TxtErrorType.XOSQLText = Nothing
        TxtErrorType.XOTanpaSpasi = False
        TxtErrorType.XOValidasiField = Nothing
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Lbl1.Location = New System.Drawing.Point(10, 5)
        Lbl1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New System.Drawing.Size(77, 32)
        Lbl1.TabIndex = 0
        Lbl1.Text = "Type :"
        Lbl1.XOCustomElipsis = False
        ' 
        ' tp_SystemInformation
        ' 
        tp_SystemInformation.Location = New System.Drawing.Point(4, 41)
        tp_SystemInformation.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        tp_SystemInformation.Name = "tp_SystemInformation"
        tp_SystemInformation.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        tp_SystemInformation.Size = New System.Drawing.Size(1038, 704)
        tp_SystemInformation.TabIndex = 1
        tp_SystemInformation.Text = "Your System Information"
        tp_SystemInformation.UseVisualStyleBackColor = True
        ' 
        ' ChkErrorReporting
        ' 
        ChkErrorReporting.AutoSize = True
        ChkErrorReporting.BackColor = Drawing.Color.Transparent
        ChkErrorReporting.FlatStyle = Windows.Forms.FlatStyle.Flat
        ChkErrorReporting.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        ChkErrorReporting.Location = New System.Drawing.Point(497, 28)
        ChkErrorReporting.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        ChkErrorReporting.Name = "ChkErrorReporting"
        ChkErrorReporting.Size = New System.Drawing.Size(365, 36)
        ChkErrorReporting.TabIndex = 1
        ChkErrorReporting.Text = "Report this error to Developer?"
        ChkErrorReporting.TextAlign = Drawing.ContentAlignment.MiddleRight
        ChkErrorReporting.UseVisualStyleBackColor = True
        ChkErrorReporting.Visible = False
        ' 
        ' FRMerrorreporting
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1086, 1000)
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        MaximizeBox = False
        MaximumSize = New System.Drawing.Size(1108, 1056)
        MinimizeBox = False
        Name = "FRMerrorreporting"
        ShowInTaskbar = True
        TopMost = True
        PnlBottomButton.ResumeLayout(False)
        PnlBottomButton.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Tbctl1.ResumeLayout(False)
        tp_ApplicationFault.ResumeLayout(False)
        tp_ApplicationFault.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnClose As CMCv.UI.Control.btn
    Friend WithEvents Tbctl1 As CMCv.UI.Control.tbctl
    Friend WithEvents tp_ApplicationFault As System.Windows.Forms.TabPage
    Friend WithEvents tp_SystemInformation As System.Windows.Forms.TabPage
    Friend WithEvents TxtErrorNumber As CMCv.UI.Control.txt
    Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
    Friend WithEvents TxtErrorMessage As CMCv.UI.Control.txt
    Friend WithEvents Lbl2 As CMCv.UI.Control.lbl
    Friend WithEvents TxtErrorType As CMCv.UI.Control.txt
    Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
    Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
    Friend WithEvents TxtAppBuild As CMCv.UI.Control.txt
    Friend WithEvents ChkErrorReporting As CMCv.UI.Control.chk

End Class
