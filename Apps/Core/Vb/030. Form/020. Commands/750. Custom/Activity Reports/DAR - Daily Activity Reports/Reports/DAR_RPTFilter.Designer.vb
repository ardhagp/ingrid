<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMdarRptFilter
    Inherits CMCv.Std_Fo

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
        BtnShow = New btn(components)
        BtnCancel = New btn(components)
        ChkFrom = New chk(components)
        DtpFrom = New dtp(components)
        ChkTo = New chk(components)
        DtpTo = New dtp(components)
        ChkArea = New chk(components)
        CboArea = New cbo(components)
        CboActivity = New cbo(components)
        ChkActivity = New chk(components)
        CboBy = New cbo(components)
        ChkBy = New chk(components)
        TxtDescription = New txt(components)
        LblNote = New lbl(components)
        RdoColor = New rdo(components)
        RdoBlackWhite = New rdo(components)
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
        PnlBottomButton.Controls.Add(BtnShow)
        PnlBottomButton.Location = New Point(0, 639)
        PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
        PnlBottomButton.Size = New Size(727, 97)
        PnlBottomButton.Controls.SetChildIndex(BtnShow, 0)
        PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(727, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(RdoBlackWhite)
        SLFPanel.Controls.Add(RdoColor)
        SLFPanel.Controls.Add(LblNote)
        SLFPanel.Controls.Add(TxtDescription)
        SLFPanel.Controls.Add(ChkBy)
        SLFPanel.Controls.Add(CboBy)
        SLFPanel.Controls.Add(ChkActivity)
        SLFPanel.Controls.Add(CboActivity)
        SLFPanel.Controls.Add(CboArea)
        SLFPanel.Controls.Add(ChkArea)
        SLFPanel.Controls.Add(DtpTo)
        SLFPanel.Controls.Add(ChkTo)
        SLFPanel.Controls.Add(DtpFrom)
        SLFPanel.Controls.Add(ChkFrom)
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(727, 736)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(ChkFrom, 0)
        SLFPanel.Controls.SetChildIndex(DtpFrom, 0)
        SLFPanel.Controls.SetChildIndex(ChkTo, 0)
        SLFPanel.Controls.SetChildIndex(DtpTo, 0)
        SLFPanel.Controls.SetChildIndex(ChkArea, 0)
        SLFPanel.Controls.SetChildIndex(CboArea, 0)
        SLFPanel.Controls.SetChildIndex(CboActivity, 0)
        SLFPanel.Controls.SetChildIndex(ChkActivity, 0)
        SLFPanel.Controls.SetChildIndex(CboBy, 0)
        SLFPanel.Controls.SetChildIndex(ChkBy, 0)
        SLFPanel.Controls.SetChildIndex(TxtDescription, 0)
        SLFPanel.Controls.SetChildIndex(LblNote, 0)
        SLFPanel.Controls.SetChildIndex(RdoColor, 0)
        SLFPanel.Controls.SetChildIndex(RdoBlackWhite, 0)
        ' 
        ' BtnShow
        ' 
        BtnShow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnShow.BackColor = Color.LimeGreen
        BtnShow.Cursor = Cursors.Hand
        BtnShow.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
        BtnShow.FlatAppearance.BorderSize = 2
        BtnShow.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
        BtnShow.FlatStyle = FlatStyle.Flat
        BtnShow.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnShow.ForeColor = Color.White
        BtnShow.Location = New Point(363, 13)
        BtnShow.Margin = New Padding(6, 5, 6, 5)
        BtnShow.Name = "BtnShow"
        BtnShow.Size = New Size(167, 77)
        BtnShow.TabIndex = 99
        BtnShow.Text = "&Show"
        BtnShow.UseVisualStyleBackColor = False
        BtnShow.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
        BtnShow.XOTampilkanFocusBorder = False
        BtnShow.XOValidasiSemuaInput = False
        BtnShow.XOValidasiSemuaInputTag = Nothing
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
        BtnCancel.Location = New Point(540, 13)
        BtnCancel.Margin = New Padding(6, 5, 6, 5)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(167, 77)
        BtnCancel.TabIndex = 98
        BtnCancel.Text = "&Cancel"
        BtnCancel.UseVisualStyleBackColor = False
        BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnCancel.XOTampilkanFocusBorder = False
        BtnCancel.XOValidasiSemuaInput = False
        BtnCancel.XOValidasiSemuaInputTag = Nothing
        ' 
        ' ChkFrom
        ' 
        ChkFrom.AutoSize = True
        ChkFrom.BackColor = Color.Transparent
        ChkFrom.FlatStyle = FlatStyle.Flat
        ChkFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkFrom.Location = New Point(67, 73)
        ChkFrom.Margin = New Padding(6, 5, 6, 5)
        ChkFrom.Name = "ChkFrom"
        ChkFrom.Size = New Size(55, 36)
        ChkFrom.TabIndex = 0
        ChkFrom.Text = "In"
        ChkFrom.UseVisualStyleBackColor = False
        ' 
        ' DtpFrom
        ' 
        DtpFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpFrom.Location = New Point(206, 65)
        DtpFrom.Margin = New Padding(6, 5, 6, 5)
        DtpFrom.MaxDate = New Date(2028, 6, 24, 0, 0, 0, 0)
        DtpFrom.MinDate = New Date(1918, 6, 24, 0, 0, 0, 0)
        DtpFrom.Name = "DtpFrom"
        DtpFrom.Size = New Size(457, 39)
        DtpFrom.TabIndex = 5
        DtpFrom.XOResetOnDisabled = True
        ' 
        ' ChkTo
        ' 
        ChkTo.AutoSize = True
        ChkTo.BackColor = Color.Transparent
        ChkTo.FlatStyle = FlatStyle.Flat
        ChkTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkTo.Location = New Point(67, 140)
        ChkTo.Margin = New Padding(6, 5, 6, 5)
        ChkTo.Name = "ChkTo"
        ChkTo.Size = New Size(60, 36)
        ChkTo.TabIndex = 1
        ChkTo.Text = "To"
        ChkTo.UseVisualStyleBackColor = False
        ' 
        ' DtpTo
        ' 
        DtpTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DtpTo.Location = New Point(206, 133)
        DtpTo.Margin = New Padding(6, 5, 6, 5)
        DtpTo.MaxDate = New Date(2028, 6, 24, 0, 0, 0, 0)
        DtpTo.MinDate = New Date(1918, 6, 24, 0, 0, 0, 0)
        DtpTo.Name = "DtpTo"
        DtpTo.Size = New Size(457, 39)
        DtpTo.TabIndex = 6
        DtpTo.XOResetOnDisabled = True
        ' 
        ' ChkArea
        ' 
        ChkArea.AutoSize = True
        ChkArea.BackColor = Color.Transparent
        ChkArea.FlatStyle = FlatStyle.Flat
        ChkArea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkArea.Location = New Point(67, 202)
        ChkArea.Margin = New Padding(6, 5, 6, 5)
        ChkArea.Name = "ChkArea"
        ChkArea.Size = New Size(83, 36)
        ChkArea.TabIndex = 2
        ChkArea.Text = "Area"
        ChkArea.UseVisualStyleBackColor = False
        ' 
        ' CboArea
        ' 
        CboArea.DropDownStyle = ComboBoxStyle.DropDownList
        CboArea.FlatStyle = FlatStyle.Flat
        CboArea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboArea.FormattingEnabled = True
        CboArea.Location = New Point(206, 200)
        CboArea.Margin = New Padding(6, 5, 6, 5)
        CboArea.Name = "CboArea"
        CboArea.Size = New Size(457, 40)
        CboArea.TabIndex = 7
        ' 
        ' CboActivity
        ' 
        CboActivity.DropDownStyle = ComboBoxStyle.DropDownList
        CboActivity.FlatStyle = FlatStyle.Flat
        CboActivity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboActivity.FormattingEnabled = True
        CboActivity.Location = New Point(206, 267)
        CboActivity.Margin = New Padding(6, 5, 6, 5)
        CboActivity.Name = "CboActivity"
        CboActivity.Size = New Size(457, 40)
        CboActivity.TabIndex = 8
        ' 
        ' ChkActivity
        ' 
        ChkActivity.AutoSize = True
        ChkActivity.BackColor = Color.Transparent
        ChkActivity.FlatStyle = FlatStyle.Flat
        ChkActivity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkActivity.Location = New Point(67, 270)
        ChkActivity.Margin = New Padding(6, 5, 6, 5)
        ChkActivity.Name = "ChkActivity"
        ChkActivity.Size = New Size(113, 36)
        ChkActivity.TabIndex = 3
        ChkActivity.Text = "Activity"
        ChkActivity.UseVisualStyleBackColor = False
        ' 
        ' CboBy
        ' 
        CboBy.DropDownStyle = ComboBoxStyle.DropDownList
        CboBy.FlatStyle = FlatStyle.Flat
        CboBy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CboBy.FormattingEnabled = True
        CboBy.Location = New Point(206, 335)
        CboBy.Margin = New Padding(6, 5, 6, 5)
        CboBy.Name = "CboBy"
        CboBy.Size = New Size(457, 40)
        CboBy.TabIndex = 9
        ' 
        ' ChkBy
        ' 
        ChkBy.AutoSize = True
        ChkBy.BackColor = Color.Transparent
        ChkBy.FlatStyle = FlatStyle.Flat
        ChkBy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ChkBy.Location = New Point(67, 337)
        ChkBy.Margin = New Padding(6, 5, 6, 5)
        ChkBy.Name = "ChkBy"
        ChkBy.Size = New Size(61, 36)
        ChkBy.TabIndex = 4
        ChkBy.Text = "By"
        ChkBy.UseVisualStyleBackColor = False
        ' 
        ' TxtDescription
        ' 
        TxtDescription.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDescription.Location = New Point(206, 402)
        TxtDescription.Margin = New Padding(6, 5, 6, 5)
        TxtDescription.MaxLength = 255
        TxtDescription.Name = "TxtDescription"
        TxtDescription.Size = New Size(457, 39)
        TxtDescription.TabIndex = 10
        TxtDescription.Tag = "txt"
        TxtDescription.XOAutoTrim = False
        TxtDescription.XOHarusDiisi = False
        TxtDescription.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtDescription.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtDescription.XOHightlightSaatFokus = False
        TxtDescription.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtDescription.XOIsBlank = True
        TxtDescription.XOIsSearchBox = False
        TxtDescription.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtDescription.XOPilihSemuaSaatFokus = False
        TxtDescription.XOPwdLengthMin = 8
        TxtDescription.XOPwdStrengthCalculate = False
        TxtDescription.XOPwdStrengthScore = 0
        TxtDescription.XOPwdStrengthText = Nothing
        TxtDescription.XORestriction = ControlCodeBase.enuRestriction.None
        TxtDescription.XOSearchBoxText = "Type then press Enter"
        TxtDescription.XOSQLText = ""
        TxtDescription.XOTanpaSpasi = False
        TxtDescription.XOValidasiField = Nothing
        ' 
        ' LblNote
        ' 
        LblNote.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        LblNote.Location = New Point(199, 463)
        LblNote.Margin = New Padding(6, 0, 6, 0)
        LblNote.Name = "LblNote"
        LblNote.Size = New Size(467, 100)
        LblNote.TabIndex = 1007
        LblNote.Text = "Note : The more specific your filter," & vbCrLf & "the more faster report will load."
        LblNote.XOCustomElipsis = False
        ' 
        ' RdoColor
        ' 
        RdoColor.AutoSize = True
        RdoColor.Checked = True
        RdoColor.FlatStyle = FlatStyle.Flat
        RdoColor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RdoColor.Location = New Point(206, 560)
        RdoColor.Margin = New Padding(6, 5, 6, 5)
        RdoColor.Name = "RdoColor"
        RdoColor.Size = New Size(94, 36)
        RdoColor.TabIndex = 1008
        RdoColor.TabStop = True
        RdoColor.Text = "Color"
        RdoColor.UseVisualStyleBackColor = True
        ' 
        ' RdoBlackWhite
        ' 
        RdoBlackWhite.AutoSize = True
        RdoBlackWhite.FlatStyle = FlatStyle.Flat
        RdoBlackWhite.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RdoBlackWhite.Location = New Point(354, 560)
        RdoBlackWhite.Margin = New Padding(6, 5, 6, 5)
        RdoBlackWhite.Name = "RdoBlackWhite"
        RdoBlackWhite.Size = New Size(188, 36)
        RdoBlackWhite.TabIndex = 1009
        RdoBlackWhite.TabStop = True
        RdoBlackWhite.Text = "Black && White"
        RdoBlackWhite.UseVisualStyleBackColor = True
        ' 
        ' FRMdarRptFilter
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(727, 862)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FRMdarRptFilter"
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

    Friend WithEvents BtnShow As CMCv.btn
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents DtpFrom As CMCv.dtp
    Friend WithEvents ChkFrom As CMCv.chk
    Friend WithEvents CboActivity As CMCv.cbo
    Friend WithEvents CboArea As CMCv.cbo
    Friend WithEvents ChkArea As CMCv.chk
    Friend WithEvents DtpTo As CMCv.dtp
    Friend WithEvents ChkTo As CMCv.chk
    Friend WithEvents ChkBy As CMCv.chk
    Friend WithEvents CboBy As CMCv.cbo
    Friend WithEvents ChkActivity As CMCv.chk
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents LblNote As CMCv.lbl
    Friend WithEvents RdoBlackWhite As CMCv.rdo
    Friend WithEvents RdoColor As CMCv.rdo
End Class
