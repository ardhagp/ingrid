<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMcpdb
    Inherits CMCv.ui.canvas.FRMstandardFooter

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
        Btn1 = New CMCv.UI.Control.Btn(components)
        Btn2 = New CMCv.UI.Control.Btn(components)
        Lbl1 = New CMCv.UI.Control.lbl(components)
        Txt1 = New CMCv.UI.Control.txt(components)
        Txt2 = New CMCv.UI.Control.txt(components)
        Txt3 = New CMCv.UI.Control.txt(components)
        Lbl2 = New CMCv.UI.Control.lbl(components)
        Lbl3 = New CMCv.UI.Control.lbl(components)
        Txt4 = New CMCv.UI.Control.txt(components)
        Lbl4 = New CMCv.UI.Control.lbl(components)
        Nud1 = New CMCv.UI.Control.nud(components)
        Lbl5 = New CMCv.UI.Control.lbl(components)
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(Nud1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(Btn2)
        PnlBottomButton.Controls.Add(Btn1)
        PnlBottomButton.Location = New Point(0, 405)
        PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
        PnlBottomButton.Size = New Size(715, 96)
        PnlBottomButton.Controls.SetChildIndex(Btn1, 0)
        PnlBottomButton.Controls.SetChildIndex(Btn2, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(8, 12, 8, 12)
        pnl_.Size = New Size(715, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Lbl5)
        SLFPanel.Controls.Add(Nud1)
        SLFPanel.Controls.Add(Lbl4)
        SLFPanel.Controls.Add(Txt4)
        SLFPanel.Controls.Add(Lbl3)
        SLFPanel.Controls.Add(Lbl2)
        SLFPanel.Controls.Add(Txt3)
        SLFPanel.Controls.Add(Txt2)
        SLFPanel.Controls.Add(Txt1)
        SLFPanel.Controls.Add(Lbl1)
        SLFPanel.Margin = New Padding(8, 12, 8, 12)
        SLFPanel.Size = New Size(715, 501)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Lbl1, 0)
        SLFPanel.Controls.SetChildIndex(Txt1, 0)
        SLFPanel.Controls.SetChildIndex(Txt2, 0)
        SLFPanel.Controls.SetChildIndex(Txt3, 0)
        SLFPanel.Controls.SetChildIndex(Lbl2, 0)
        SLFPanel.Controls.SetChildIndex(Lbl3, 0)
        SLFPanel.Controls.SetChildIndex(Txt4, 0)
        SLFPanel.Controls.SetChildIndex(Lbl4, 0)
        SLFPanel.Controls.SetChildIndex(Nud1, 0)
        SLFPanel.Controls.SetChildIndex(Lbl5, 0)
        ' 
        ' Btn1
        ' 
        Btn1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn1.BackColor = Color.LimeGreen
        Btn1.Cursor = Cursors.Hand
        Btn1.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        Btn1.FlatAppearance.BorderSize = 2
        Btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        Btn1.FlatStyle = FlatStyle.Flat
        Btn1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn1.ForeColor = Color.White
        Btn1.Location = New Point(352, 13)
        Btn1.Margin = New Padding(5, 6, 5, 6)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(167, 77)
        Btn1.TabIndex = 1
        Btn1.Text = "&Save"
        Btn1.UseVisualStyleBackColor = False
        Btn1.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.Yes
        Btn1.XOShowBorderOnFocus = False
        Btn1.XOValidateAllInput = False
        Btn1.XOValidateAllInputTag = Nothing
        ' 
        ' Btn2
        ' 
        Btn2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn2.BackColor = Color.Red
        Btn2.Cursor = Cursors.Hand
        Btn2.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        Btn2.FlatAppearance.BorderSize = 2
        Btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        Btn2.FlatStyle = FlatStyle.Flat
        Btn2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn2.ForeColor = Color.White
        Btn2.Location = New Point(529, 13)
        Btn2.Margin = New Padding(5, 6, 5, 6)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(167, 77)
        Btn2.TabIndex = 2
        Btn2.Text = "&Cancel"
        Btn2.UseVisualStyleBackColor = False
        Btn2.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.No
        Btn2.XOShowBorderOnFocus = False
        Btn2.XOValidateAllInput = False
        Btn2.XOValidateAllInputTag = Nothing
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(73, 37)
        Lbl1.Margin = New Padding(5, 0, 5, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(172, 32)
        Lbl1.TabIndex = 996
        Lbl1.Text = "Server Address"
        Lbl1.XOCustomElipsis = False
        ' 
        ' Txt1
        ' 
        Txt1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt1.Location = New Point(275, 31)
        Txt1.Margin = New Padding(5, 6, 5, 6)
        Txt1.MaxLength = 255
        Txt1.Name = "Txt1"
        Txt1.Size = New Size(341, 39)
        Txt1.TabIndex = 997
        Txt1.Tag = "txt"
        Txt1.XOAutoTrim = False
        Txt1.XOIsMandatory = False
        Txt1.XOMandatoryBgColor = Color.LightPink
        Txt1.XOMandatoryBgColorDefault = Color.White
        Txt1.XOHighlightOnFocus = False
        Txt1.XOHighlightColor = Color.LightYellow
        Txt1.XOIsBlank = True
        Txt1.XOIsPlaceholder = False
        Txt1.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.Normal
        Txt1.XOSelectOnFocus = False
        Txt1.XOPasswordLengthMin = 8
        Txt1.XOPasswordStrengthCalc = False
        Txt1.XOPasswordStrengthScore = 0
        Txt1.XOPasswordStrengthText = Nothing
        Txt1.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
        Txt1.XOPlaceholderText = "Type then press Enter"
        Txt1.XOSqlText = ""
        Txt1.XOIsReplaceEmptyString = False
        Txt1.XOMandatoryMessage = Nothing
        ' 
        ' Txt2
        ' 
        Txt2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt2.Location = New Point(275, 98)
        Txt2.Margin = New Padding(5, 6, 5, 6)
        Txt2.MaxLength = 255
        Txt2.Name = "Txt2"
        Txt2.Size = New Size(341, 39)
        Txt2.TabIndex = 998
        Txt2.Tag = "txt"
        Txt2.XOAutoTrim = False
        Txt2.XOIsMandatory = False
        Txt2.XOMandatoryBgColor = Color.LightPink
        Txt2.XOMandatoryBgColorDefault = Color.White
        Txt2.XOHighlightOnFocus = False
        Txt2.XOHighlightColor = Color.LightYellow
        Txt2.XOIsBlank = True
        Txt2.XOIsPlaceholder = False
        Txt2.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.Normal
        Txt2.XOSelectOnFocus = False
        Txt2.XOPasswordLengthMin = 8
        Txt2.XOPasswordStrengthCalc = False
        Txt2.XOPasswordStrengthScore = 0
        Txt2.XOPasswordStrengthText = Nothing
        Txt2.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
        Txt2.XOPlaceholderText = "Type then press Enter"
        Txt2.XOSqlText = ""
        Txt2.XOIsReplaceEmptyString = False
        Txt2.XOMandatoryMessage = Nothing
        ' 
        ' Txt3
        ' 
        Txt3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt3.Location = New Point(275, 165)
        Txt3.Margin = New Padding(5, 6, 5, 6)
        Txt3.MaxLength = 255
        Txt3.Name = "Txt3"
        Txt3.Size = New Size(341, 39)
        Txt3.TabIndex = 999
        Txt3.Tag = "txt"
        Txt3.XOAutoTrim = False
        Txt3.XOIsMandatory = False
        Txt3.XOMandatoryBgColor = Color.LightPink
        Txt3.XOMandatoryBgColorDefault = Color.White
        Txt3.XOHighlightOnFocus = False
        Txt3.XOHighlightColor = Color.LightYellow
        Txt3.XOIsBlank = True
        Txt3.XOIsPlaceholder = False
        Txt3.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.Normal
        Txt3.XOSelectOnFocus = False
        Txt3.XOPasswordLengthMin = 8
        Txt3.XOPasswordStrengthCalc = False
        Txt3.XOPasswordStrengthScore = 0
        Txt3.XOPasswordStrengthText = Nothing
        Txt3.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
        Txt3.XOPlaceholderText = "Type then press Enter"
        Txt3.XOSqlText = ""
        Txt3.XOIsReplaceEmptyString = False
        Txt3.XOMandatoryMessage = Nothing
        ' 
        ' Lbl2
        ' 
        Lbl2.AutoSize = True
        Lbl2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl2.Location = New Point(142, 104)
        Lbl2.Margin = New Padding(5, 0, 5, 0)
        Lbl2.Name = "Lbl2"
        Lbl2.Size = New Size(112, 32)
        Lbl2.TabIndex = 1000
        Lbl2.Text = "Database"
        Lbl2.XOCustomElipsis = False
        ' 
        ' Lbl3
        ' 
        Lbl3.AutoSize = True
        Lbl3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl3.Location = New Point(138, 238)
        Lbl3.Margin = New Padding(5, 0, 5, 0)
        Lbl3.Name = "Lbl3"
        Lbl3.Size = New Size(111, 32)
        Lbl3.TabIndex = 1001
        Lbl3.Text = "Password"
        Lbl3.XOCustomElipsis = False
        ' 
        ' Txt4
        ' 
        Txt4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt4.Location = New Point(275, 233)
        Txt4.Margin = New Padding(5, 6, 5, 6)
        Txt4.MaxLength = 255
        Txt4.Name = "Txt4"
        Txt4.Size = New Size(341, 39)
        Txt4.TabIndex = 1002
        Txt4.Tag = "txt"
        Txt4.XOAutoTrim = False
        Txt4.XOIsMandatory = False
        Txt4.XOMandatoryBgColor = Color.LightPink
        Txt4.XOMandatoryBgColorDefault = Color.White
        Txt4.XOHighlightOnFocus = False
        Txt4.XOHighlightColor = Color.LightYellow
        Txt4.XOIsBlank = True
        Txt4.XOIsPlaceholder = False
        Txt4.XOLetterCase = CMCV.UI.Control.ControlCodeBase.enumLetterCase.Normal
        Txt4.XOSelectOnFocus = False
        Txt4.XOPasswordLengthMin = 8
        Txt4.XOPasswordStrengthCalc = False
        Txt4.XOPasswordStrengthScore = 0
        Txt4.XOPasswordStrengthText = Nothing
        Txt4.XORestriction = CMCV.UI.Control.ControlCodeBase.enumRestriction.None
        Txt4.XOPlaceholderText = "Type then press Enter"
        Txt4.XOSqlText = ""
        Txt4.XOIsReplaceEmptyString = False
        Txt4.XOMandatoryMessage = Nothing
        ' 
        ' Lbl4
        ' 
        Lbl4.AutoSize = True
        Lbl4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl4.Location = New Point(130, 171)
        Lbl4.Margin = New Padding(5, 0, 5, 0)
        Lbl4.Name = "Lbl4"
        Lbl4.Size = New Size(121, 32)
        Lbl4.TabIndex = 1003
        Lbl4.Text = "Username"
        Lbl4.XOCustomElipsis = False
        ' 
        ' Nud1
        ' 
        Nud1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Nud1.Location = New Point(275, 300)
        Nud1.Margin = New Padding(5, 6, 5, 6)
        Nud1.Name = "Nud1"
        Nud1.Size = New Size(172, 39)
        Nud1.TabIndex = 1004
        Nud1.XOAutoTrim = False
        Nud1.XOIsMandatory = False
        Nud1.XOHighlightOnFocus = False
        Nud1.XOHighlightColor = Color.LightYellow
        Nud1.XOSelectOnFocus = False
        ' 
        ' Lbl5
        ' 
        Lbl5.AutoSize = True
        Lbl5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl5.Location = New Point(202, 304)
        Lbl5.Margin = New Padding(5, 0, 5, 0)
        Lbl5.Name = "Lbl5"
        Lbl5.Size = New Size(56, 32)
        Lbl5.TabIndex = 1005
        Lbl5.Text = "Port"
        Lbl5.XOCustomElipsis = False
        ' 
        ' FRMcpdb
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(715, 627)
        KeyPreview = True
        Margin = New Padding(22, 44, 22, 44)
        Name = "FRMcpdb"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(Nud1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Btn1 As CMCv.UI.Control.Btn
    Friend WithEvents Btn2 As CMCv.UI.Control.Btn
    Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
    Friend WithEvents Lbl5 As CMCv.UI.Control.lbl
    Friend WithEvents Nud1 As CMCv.UI.Control.nud
    Friend WithEvents Lbl4 As CMCv.UI.Control.lbl
    Friend WithEvents Txt4 As CMCv.UI.Control.txt
    Friend WithEvents Lbl3 As CMCv.UI.Control.lbl
    Friend WithEvents Lbl2 As CMCv.UI.Control.lbl
    Friend WithEvents Txt3 As CMCv.UI.Control.txt
    Friend WithEvents Txt2 As CMCv.UI.Control.txt
    Friend WithEvents Txt1 As CMCv.UI.Control.txt
End Class
