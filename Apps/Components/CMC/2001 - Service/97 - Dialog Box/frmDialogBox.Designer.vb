<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMdialogbox
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
        PnlBottomButtonYesNo = New pnl(components)
        PictureBox1 = New Windows.Forms.PictureBox()
        PnlBottomButtonOkOnly = New pnl(components)
        PictureBox2 = New Windows.Forms.PictureBox()
        TxtMessage = New txt(components)
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        PnlBottomButtonYesNo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlBottomButtonOkOnly.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Location = New System.Drawing.Point(0, 290)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        PnlBottomButton.Size = New System.Drawing.Size(1115, 96)
        PnlBottomButton.Visible = False
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        pnl_.Size = New System.Drawing.Size(1115, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TxtMessage)
        SLFPanel.Controls.Add(PnlBottomButtonOkOnly)
        SLFPanel.Controls.Add(PnlBottomButtonYesNo)
        SLFPanel.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        SLFPanel.Size = New System.Drawing.Size(1115, 482)
        SLFPanel.Controls.SetChildIndex(PnlBottomButtonYesNo, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(PnlBottomButtonOkOnly, 0)
        SLFPanel.Controls.SetChildIndex(TxtMessage, 0)
        ' 
        ' PnlBottomButtonYesNo
        ' 
        PnlBottomButtonYesNo.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButtonYesNo.Controls.Add(PictureBox1)
        PnlBottomButtonYesNo.Dock = Windows.Forms.DockStyle.Bottom
        PnlBottomButtonYesNo.Location = New System.Drawing.Point(0, 386)
        PnlBottomButtonYesNo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PnlBottomButtonYesNo.Name = "PnlBottomButtonYesNo"
        PnlBottomButtonYesNo.Size = New System.Drawing.Size(1115, 96)
        PnlBottomButtonYesNo.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Drawing.Color.Red
        PictureBox1.Dock = Windows.Forms.DockStyle.Top
        PictureBox1.Location = New System.Drawing.Point(0, 0)
        PictureBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(1115, 8)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PnlBottomButtonOkOnly
        ' 
        PnlBottomButtonOkOnly.BackColor = Drawing.Color.DarkSlateGray
        PnlBottomButtonOkOnly.Controls.Add(PictureBox2)
        PnlBottomButtonOkOnly.Dock = Windows.Forms.DockStyle.Bottom
        PnlBottomButtonOkOnly.Location = New System.Drawing.Point(0, 194)
        PnlBottomButtonOkOnly.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PnlBottomButtonOkOnly.Name = "PnlBottomButtonOkOnly"
        PnlBottomButtonOkOnly.Size = New System.Drawing.Size(1115, 96)
        PnlBottomButtonOkOnly.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Drawing.Color.Red
        PictureBox2.Dock = Windows.Forms.DockStyle.Top
        PictureBox2.Location = New System.Drawing.Point(0, 0)
        PictureBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(1115, 8)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' TxtMessage
        ' 
        TxtMessage.AcceptsReturn = True
        TxtMessage.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Left Or Windows.Forms.AnchorStyles.Right
        TxtMessage.BackColor = Drawing.SystemColors.Window
        TxtMessage.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtMessage.Location = New System.Drawing.Point(20, 29)
        TxtMessage.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        TxtMessage.MaxLength = 255
        TxtMessage.Multiline = True
        TxtMessage.Name = "TxtMessage"
        TxtMessage.ReadOnly = True
        TxtMessage.ScrollBars = Windows.Forms.ScrollBars.Vertical
        TxtMessage.ShortcutsEnabled = False
        TxtMessage.Size = New System.Drawing.Size(1073, 336)
        TxtMessage.TabIndex = 5
        TxtMessage.TabStop = False
        TxtMessage.Tag = "txt"
        TxtMessage.XOAutoTrim = False
        TxtMessage.XOHarusDiisi = False
        TxtMessage.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtMessage.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtMessage.XOHightlightSaatFokus = False
        TxtMessage.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtMessage.XOIsBlank = True
        TxtMessage.XOIsSearchBox = False
        TxtMessage.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtMessage.XOPilihSemuaSaatFokus = False
        TxtMessage.XOPwdLengthMin = 8
        TxtMessage.XOPwdStrengthCalculate = False
        TxtMessage.XOPwdStrengthScore = 0
        TxtMessage.XOPwdStrengthText = Nothing
        TxtMessage.XORestriction = ControlCodeBase.enuRestriction.None
        TxtMessage.XOSearchBoxText = "Type then press Enter"
        TxtMessage.XOSQLText = ""
        TxtMessage.XOTanpaSpasi = False
        TxtMessage.XOValidasiField = Nothing
        ' 
        ' FRMdialogbox
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1115, 608)
        ControlBox = False
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(22, 44, 22, 44)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FRMdialogbox"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        PnlBottomButtonYesNo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlBottomButtonOkOnly.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents PnlBottomButtonYesNo As CMCv.pnl
    Friend WithEvents BtnOk As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnYes As CMCv.btn
    Friend WithEvents BtnNo As CMCv.btn
    Friend WithEvents PnlBottomButtonOkOnly As CMCv.pnl
    Friend WithEvents BtnOkOnly As CMCv.btn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtMessage As CMCv.txt

End Class
