<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMerrorreporting
    Inherits CMCv.FRMstandardFooter

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
        BtnClose = New CMCv.UI.Control.Btn(components)
        Tbctl1 = New CMCv.UI.Control.Tbx(components)
        tp_ApplicationFault = New System.Windows.Forms.TabPage()
        Lbl4 = New CMCv.UI.Control.lbl(components)
        TxtAppBuild = New CMCv.UI.Control.txt(components)
        TxtErrorNumber = New CMCv.UI.Control.txt(components)
        Lbl3 = New CMCv.UI.Control.lbl(components)
        TxtErrorMessage = New CMCv.UI.Control.txt(components)
        Lbl2 = New CMCv.UI.Control.lbl(components)
        TxtErrorType = New CMCv.UI.Control.txt(components)
        Lbl1 = New CMCv.UI.Control.lbl(components)
        tp_SystemInformation = New System.Windows.Forms.TabPage()
        ChkErrorReporting = New CMCv.UI.Control.Chk(components)
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
        BtnClose.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.Red
        BtnClose.Cursor = system.Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = system.Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New System.Drawing.Point(899, 14)
        BtnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(167, 77)
        BtnClose.TabIndex = 0
        BtnClose.Text = "Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOButtonType = ControlCodeBase.buttonType.No
        BtnClose.XOShowBorderOnFocus = False
        BtnClose.XOValidateAllInput = False
        BtnClose.XOValidateAllInputTag = Nothing
        ' 
        ' Tbctl1
        ' 
        Tbctl1.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left Or system.Windows.Forms.AnchorStyles.Right
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
        Lbl4.Anchor = system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left
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
        TxtAppBuild.Anchor = system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left
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
        TxtAppBuild.XOIsMandatory = False
        TxtAppBuild.XOMandatoryBgColor = Drawing.Color.LightPink
        TxtAppBuild.XOMandatoryBgColorDefault = Drawing.Color.White
        TxtAppBuild.XOHighlightOnFocus = False
        TxtAppBuild.XOHighlightColor = Drawing.Color.LightYellow
        TxtAppBuild.XOIsBlank = True
        TxtAppBuild.XOIsPlaceholder = False
        TxtAppBuild.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
        TxtAppBuild.XOSelectOnFocus = False
        TxtAppBuild.XOPasswordLengthMin = 8
        TxtAppBuild.XOPasswordStrengthCalc = False
        TxtAppBuild.XOPasswordStrengthScore = 0
        TxtAppBuild.XOPasswordStrengthText = Nothing
        TxtAppBuild.XORestriction = ControlCodeBase.enumRestriction.None
        TxtAppBuild.XOPlaceholderText = "Type then press Enter"
        TxtAppBuild.XOSqlText = Nothing
        TxtAppBuild.XOIsReplaceEmptyString = False
        TxtAppBuild.XOMandatoryMessage = Nothing
        ' 
        ' TxtErrorNumber
        ' 
        TxtErrorNumber.Anchor = system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left
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
        TxtErrorNumber.XOIsMandatory = False
        TxtErrorNumber.XOMandatoryBgColor = Drawing.Color.LightPink
        TxtErrorNumber.XOMandatoryBgColorDefault = Drawing.Color.White
        TxtErrorNumber.XOHighlightOnFocus = False
        TxtErrorNumber.XOHighlightColor = Drawing.Color.LightYellow
        TxtErrorNumber.XOIsBlank = True
        TxtErrorNumber.XOIsPlaceholder = False
        TxtErrorNumber.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
        TxtErrorNumber.XOSelectOnFocus = False
        TxtErrorNumber.XOPasswordLengthMin = 8
        TxtErrorNumber.XOPasswordStrengthCalc = False
        TxtErrorNumber.XOPasswordStrengthScore = 0
        TxtErrorNumber.XOPasswordStrengthText = Nothing
        TxtErrorNumber.XORestriction = ControlCodeBase.enumRestriction.None
        TxtErrorNumber.XOPlaceholderText = "Type then press Enter"
        TxtErrorNumber.XOSqlText = Nothing
        TxtErrorNumber.XOIsReplaceEmptyString = False
        TxtErrorNumber.XOMandatoryMessage = Nothing
        ' 
        ' Lbl3
        ' 
        Lbl3.Anchor = system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left
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
        TxtErrorMessage.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Bottom Or system.Windows.Forms.AnchorStyles.Left Or system.Windows.Forms.AnchorStyles.Right
        TxtErrorMessage.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtErrorMessage.Location = New System.Drawing.Point(10, 160)
        TxtErrorMessage.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        TxtErrorMessage.MaxLength = 255
        TxtErrorMessage.Multiline = True
        TxtErrorMessage.Name = "TxtErrorMessage"
        TxtErrorMessage.ScrollBars = system.Windows.Forms.ScrollBars.Vertical
        TxtErrorMessage.Size = New System.Drawing.Size(1009, 383)
        TxtErrorMessage.TabIndex = 3
        TxtErrorMessage.Tag = "txt"
        TxtErrorMessage.XOAutoTrim = False
        TxtErrorMessage.XOIsMandatory = False
        TxtErrorMessage.XOMandatoryBgColor = Drawing.Color.LightPink
        TxtErrorMessage.XOMandatoryBgColorDefault = Drawing.Color.White
        TxtErrorMessage.XOHighlightOnFocus = False
        TxtErrorMessage.XOHighlightColor = Drawing.Color.LightYellow
        TxtErrorMessage.XOIsBlank = True
        TxtErrorMessage.XOIsPlaceholder = False
        TxtErrorMessage.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
        TxtErrorMessage.XOSelectOnFocus = False
        TxtErrorMessage.XOPasswordLengthMin = 8
        TxtErrorMessage.XOPasswordStrengthCalc = False
        TxtErrorMessage.XOPasswordStrengthScore = 0
        TxtErrorMessage.XOPasswordStrengthText = Nothing
        TxtErrorMessage.XORestriction = ControlCodeBase.enumRestriction.None
        TxtErrorMessage.XOPlaceholderText = "Type then press Enter"
        TxtErrorMessage.XOSqlText = Nothing
        TxtErrorMessage.XOIsReplaceEmptyString = False
        TxtErrorMessage.XOMandatoryMessage = Nothing
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
        TxtErrorType.XOIsMandatory = False
        TxtErrorType.XOMandatoryBgColor = Drawing.Color.LightPink
        TxtErrorType.XOMandatoryBgColorDefault = Drawing.Color.White
        TxtErrorType.XOHighlightOnFocus = False
        TxtErrorType.XOHighlightColor = Drawing.Color.LightYellow
        TxtErrorType.XOIsBlank = True
        TxtErrorType.XOIsPlaceholder = False
        TxtErrorType.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
        TxtErrorType.XOSelectOnFocus = False
        TxtErrorType.XOPasswordLengthMin = 8
        TxtErrorType.XOPasswordStrengthCalc = False
        TxtErrorType.XOPasswordStrengthScore = 0
        TxtErrorType.XOPasswordStrengthText = Nothing
        TxtErrorType.XORestriction = ControlCodeBase.enumRestriction.None
        TxtErrorType.XOPlaceholderText = "Type then press Enter"
        TxtErrorType.XOSqlText = Nothing
        TxtErrorType.XOIsReplaceEmptyString = False
        TxtErrorType.XOMandatoryMessage = Nothing
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
        ChkErrorReporting.FlatStyle = system.Windows.Forms.FlatStyle.Flat
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
        FormBorderStyle = system.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents BtnClose As CMCv.UI.Control.Btn
    Friend WithEvents Tbctl1 As CMCv.UI.Control.Tbx
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
    Friend WithEvents ChkErrorReporting As CMCv.UI.Control.Chk

End Class
