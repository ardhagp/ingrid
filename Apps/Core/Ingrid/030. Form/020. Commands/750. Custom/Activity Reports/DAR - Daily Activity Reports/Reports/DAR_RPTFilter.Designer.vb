<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DAR_RPTFilter
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnShow = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.ChkFrom = New CMCv.chk(Me.components)
        Me.DtpFrom = New CMCv.dtp(Me.components)
        Me.ChkTo = New CMCv.chk(Me.components)
        Me.DtpTo = New CMCv.dtp(Me.components)
        Me.ChkArea = New CMCv.chk(Me.components)
        Me.CboArea = New CMCv.cbo(Me.components)
        Me.CboActivity = New CMCv.cbo(Me.components)
        Me.ChkActivity = New CMCv.chk(Me.components)
        Me.CboBy = New CMCv.cbo(Me.components)
        Me.ChkBy = New CMCv.chk(Me.components)
        Me.TxtDescription = New CMCv.txt(Me.components)
        Me.LblNote = New CMCv.lbl(Me.components)
        Me.RdoColor = New CMCv.rdo(Me.components)
        Me.RdoBlackWhite = New CMCv.rdo(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnShow)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 322)
        Me.PnlBottomButton.Size = New System.Drawing.Size(436, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnShow, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(436, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.RdoBlackWhite)
        Me.SLFPanel.Controls.Add(Me.RdoColor)
        Me.SLFPanel.Controls.Add(Me.LblNote)
        Me.SLFPanel.Controls.Add(Me.TxtDescription)
        Me.SLFPanel.Controls.Add(Me.ChkBy)
        Me.SLFPanel.Controls.Add(Me.CboBy)
        Me.SLFPanel.Controls.Add(Me.ChkActivity)
        Me.SLFPanel.Controls.Add(Me.CboActivity)
        Me.SLFPanel.Controls.Add(Me.CboArea)
        Me.SLFPanel.Controls.Add(Me.ChkArea)
        Me.SLFPanel.Controls.Add(Me.DtpTo)
        Me.SLFPanel.Controls.Add(Me.ChkTo)
        Me.SLFPanel.Controls.Add(Me.DtpFrom)
        Me.SLFPanel.Controls.Add(Me.ChkFrom)
        Me.SLFPanel.Size = New System.Drawing.Size(436, 372)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ChkFrom, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DtpFrom, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ChkTo, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.DtpTo, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ChkArea, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboArea, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboActivity, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ChkActivity, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboBy, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.ChkBy, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtDescription, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.LblNote, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.RdoColor, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.RdoBlackWhite, 0)
        '
        'BtnShow
        '
        Me.BtnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnShow.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnShow.FlatAppearance.BorderSize = 2
        Me.BtnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnShow.ForeColor = System.Drawing.Color.White
        Me.BtnShow.Location = New System.Drawing.Point(218, 7)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(100, 40)
        Me.BtnShow.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnShow.SLFTampilkanFocusBorder = False
        Me.BtnShow.SLFValidasiSemuaInput = False
        Me.BtnShow.SLFValidasiSemuaInputTag = Nothing
        Me.BtnShow.TabIndex = 99
        Me.BtnShow.Text = "&Show"
        Me.BtnShow.UseVisualStyleBackColor = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(324, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 98
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'ChkFrom
        '
        Me.ChkFrom.AutoSize = True
        Me.ChkFrom.BackColor = System.Drawing.Color.Transparent
        Me.ChkFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkFrom.Location = New System.Drawing.Point(40, 38)
        Me.ChkFrom.Name = "ChkFrom"
        Me.ChkFrom.Size = New System.Drawing.Size(39, 25)
        Me.ChkFrom.TabIndex = 0
        Me.ChkFrom.Text = "In"
        Me.ChkFrom.UseVisualStyleBackColor = False
        '
        'DtpFrom
        '
        Me.DtpFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtpFrom.Location = New System.Drawing.Point(123, 34)
        Me.DtpFrom.MaxDate = New Date(2028, 6, 24, 0, 0, 0, 0)
        Me.DtpFrom.MinDate = New Date(1918, 6, 24, 0, 0, 0, 0)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(276, 29)
        Me.DtpFrom.SLFResetOnDisabled = True
        Me.DtpFrom.TabIndex = 5
        '
        'ChkTo
        '
        Me.ChkTo.AutoSize = True
        Me.ChkTo.BackColor = System.Drawing.Color.Transparent
        Me.ChkTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkTo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkTo.Location = New System.Drawing.Point(40, 73)
        Me.ChkTo.Name = "ChkTo"
        Me.ChkTo.Size = New System.Drawing.Size(41, 25)
        Me.ChkTo.TabIndex = 1
        Me.ChkTo.Text = "To"
        Me.ChkTo.UseVisualStyleBackColor = False
        '
        'DtpTo
        '
        Me.DtpTo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DtpTo.Location = New System.Drawing.Point(123, 69)
        Me.DtpTo.MaxDate = New Date(2028, 6, 24, 0, 0, 0, 0)
        Me.DtpTo.MinDate = New Date(1918, 6, 24, 0, 0, 0, 0)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(276, 29)
        Me.DtpTo.SLFResetOnDisabled = True
        Me.DtpTo.TabIndex = 6
        '
        'ChkArea
        '
        Me.ChkArea.AutoSize = True
        Me.ChkArea.BackColor = System.Drawing.Color.Transparent
        Me.ChkArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkArea.Location = New System.Drawing.Point(40, 105)
        Me.ChkArea.Name = "ChkArea"
        Me.ChkArea.Size = New System.Drawing.Size(58, 25)
        Me.ChkArea.TabIndex = 2
        Me.ChkArea.Text = "Area"
        Me.ChkArea.UseVisualStyleBackColor = False
        '
        'CboArea
        '
        Me.CboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboArea.FormattingEnabled = True
        Me.CboArea.Location = New System.Drawing.Point(123, 104)
        Me.CboArea.Name = "CboArea"
        Me.CboArea.Size = New System.Drawing.Size(276, 29)
        Me.CboArea.TabIndex = 7
        '
        'CboActivity
        '
        Me.CboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboActivity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboActivity.FormattingEnabled = True
        Me.CboActivity.Location = New System.Drawing.Point(123, 139)
        Me.CboActivity.Name = "CboActivity"
        Me.CboActivity.Size = New System.Drawing.Size(276, 29)
        Me.CboActivity.TabIndex = 8
        '
        'ChkActivity
        '
        Me.ChkActivity.AutoSize = True
        Me.ChkActivity.BackColor = System.Drawing.Color.Transparent
        Me.ChkActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkActivity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkActivity.Location = New System.Drawing.Point(40, 140)
        Me.ChkActivity.Name = "ChkActivity"
        Me.ChkActivity.Size = New System.Drawing.Size(77, 25)
        Me.ChkActivity.TabIndex = 3
        Me.ChkActivity.Text = "Activity"
        Me.ChkActivity.UseVisualStyleBackColor = False
        '
        'CboBy
        '
        Me.CboBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboBy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboBy.FormattingEnabled = True
        Me.CboBy.Location = New System.Drawing.Point(123, 174)
        Me.CboBy.Name = "CboBy"
        Me.CboBy.Size = New System.Drawing.Size(276, 29)
        Me.CboBy.TabIndex = 9
        '
        'ChkBy
        '
        Me.ChkBy.AutoSize = True
        Me.ChkBy.BackColor = System.Drawing.Color.Transparent
        Me.ChkBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkBy.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChkBy.Location = New System.Drawing.Point(40, 175)
        Me.ChkBy.Name = "ChkBy"
        Me.ChkBy.Size = New System.Drawing.Size(43, 25)
        Me.ChkBy.TabIndex = 4
        Me.ChkBy.Text = "By"
        Me.ChkBy.UseVisualStyleBackColor = False
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDescription.Location = New System.Drawing.Point(123, 209)
        Me.TxtDescription.MaxLength = 255
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(276, 29)
        Me.TxtDescription.SLFAutoTrim = False
        Me.TxtDescription.SLFHarusDiisi = False
        Me.TxtDescription.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDescription.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDescription.SLFHightlightSaatFokus = False
        Me.TxtDescription.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDescription.SLFIsBlank = True
        Me.TxtDescription.SLFIsSearchBox = False
        Me.TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtDescription.SLFPilihSemuaSaatFokus = False
        Me.TxtDescription.SLFPwdLengthMin = 8
        Me.TxtDescription.SLFPwdStrengthCalculate = False
        Me.TxtDescription.SLFPwdStrengthScore = 0
        Me.TxtDescription.SLFPwdStrengthText = Nothing
        Me.TxtDescription.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDescription.SLFSearchBoxText = "Type then press Enter"
        Me.TxtDescription.SLFSQLText = ""
        Me.TxtDescription.SLFTanpaSpasi = False
        Me.TxtDescription.SLFValidasiField = Nothing
        Me.TxtDescription.TabIndex = 10
        Me.TxtDescription.Tag = "txt"
        '
        'LblNote
        '
        Me.LblNote.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.LblNote.Location = New System.Drawing.Point(119, 241)
        Me.LblNote.Name = "LblNote"
        Me.LblNote.Size = New System.Drawing.Size(280, 52)
        Me.LblNote.SLFCustomElipsis = False
        Me.LblNote.TabIndex = 1007
        Me.LblNote.Text = "Note : The more specific your filter," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the more faster report will load."
        '
        'RdoColor
        '
        Me.RdoColor.AutoSize = True
        Me.RdoColor.Checked = True
        Me.RdoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RdoColor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RdoColor.Location = New System.Drawing.Point(123, 291)
        Me.RdoColor.Name = "RdoColor"
        Me.RdoColor.Size = New System.Drawing.Size(65, 25)
        Me.RdoColor.TabIndex = 1008
        Me.RdoColor.TabStop = True
        Me.RdoColor.Text = "Color"
        Me.RdoColor.UseVisualStyleBackColor = True
        '
        'RdoBlackWhite
        '
        Me.RdoBlackWhite.AutoSize = True
        Me.RdoBlackWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RdoBlackWhite.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RdoBlackWhite.Location = New System.Drawing.Point(213, 291)
        Me.RdoBlackWhite.Name = "RdoBlackWhite"
        Me.RdoBlackWhite.Size = New System.Drawing.Size(125, 25)
        Me.RdoBlackWhite.TabIndex = 1009
        Me.RdoBlackWhite.TabStop = True
        Me.RdoBlackWhite.Text = "Black && White"
        Me.RdoBlackWhite.UseVisualStyleBackColor = True
        '
        'DAR_RPTFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(436, 448)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DAR_RPTFilter"
        Me.PnlBottomButton.ResumeLayout(False)
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
