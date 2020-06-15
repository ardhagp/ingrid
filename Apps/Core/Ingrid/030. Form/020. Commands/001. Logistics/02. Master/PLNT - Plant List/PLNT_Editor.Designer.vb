<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLNT_Editor
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CboCompany = New CMCv.cbo(Me.components)
        Me.Lbl1 = New CMCv.lbl(Me.components)
        Me.TxtPlantCode = New CMCv.txt(Me.components)
        Me.TxtPlantName1 = New CMCv.txt(Me.components)
        Me.TxtSearchTerm1 = New CMCv.txt(Me.components)
        Me.TxtPlantName2 = New CMCv.txt(Me.components)
        Me.TxtCity = New CMCv.txt(Me.components)
        Me.TxtPostalCode = New CMCv.txt(Me.components)
        Me.TxtDescription = New CMCv.txt(Me.components)
        Me.TxtSearchTerm2 = New CMCv.txt(Me.components)
        Me.Lbl2 = New CMCv.lbl(Me.components)
        Me.Lbl3 = New CMCv.lbl(Me.components)
        Me.Lbl4 = New CMCv.lbl(Me.components)
        Me.Lbl5 = New CMCv.lbl(Me.components)
        Me.Lbl6 = New CMCv.lbl(Me.components)
        Me.Lbl7 = New CMCv.lbl(Me.components)
        Me.Lbl8 = New CMCv.lbl(Me.components)
        Me.Lbl9 = New CMCv.lbl(Me.components)
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnCancel = New CMCv.btn(Me.components)
        Me.Chk1 = New CMCv.chk(Me.components)
        Me.PnlBottomButton.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBottomButton
        '
        Me.PnlBottomButton.Controls.Add(Me.Chk1)
        Me.PnlBottomButton.Controls.Add(Me.BtnCancel)
        Me.PnlBottomButton.Controls.Add(Me.BtnSave)
        Me.PnlBottomButton.Location = New System.Drawing.Point(0, 330)
        Me.PnlBottomButton.Size = New System.Drawing.Size(391, 50)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.BtnCancel, 0)
        Me.PnlBottomButton.Controls.SetChildIndex(Me.Chk1, 0)
        '
        'SLFSubNamaForm
        '
        Me.SLFSubNamaForm.Size = New System.Drawing.Size(0, 23)
        '
        'SLFNamaForm
        '
        Me.SLFNamaForm.Size = New System.Drawing.Size(0, 46)
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(391, 96)
        '
        'SLFPanel
        '
        Me.SLFPanel.AutoScroll = True
        Me.SLFPanel.Controls.Add(Me.Lbl9)
        Me.SLFPanel.Controls.Add(Me.Lbl8)
        Me.SLFPanel.Controls.Add(Me.Lbl7)
        Me.SLFPanel.Controls.Add(Me.Lbl6)
        Me.SLFPanel.Controls.Add(Me.Lbl5)
        Me.SLFPanel.Controls.Add(Me.Lbl4)
        Me.SLFPanel.Controls.Add(Me.Lbl3)
        Me.SLFPanel.Controls.Add(Me.Lbl2)
        Me.SLFPanel.Controls.Add(Me.TxtSearchTerm2)
        Me.SLFPanel.Controls.Add(Me.TxtDescription)
        Me.SLFPanel.Controls.Add(Me.TxtPostalCode)
        Me.SLFPanel.Controls.Add(Me.TxtCity)
        Me.SLFPanel.Controls.Add(Me.TxtPlantName2)
        Me.SLFPanel.Controls.Add(Me.TxtSearchTerm1)
        Me.SLFPanel.Controls.Add(Me.TxtPlantName1)
        Me.SLFPanel.Controls.Add(Me.TxtPlantCode)
        Me.SLFPanel.Controls.Add(Me.Lbl1)
        Me.SLFPanel.Controls.Add(Me.CboCompany)
        Me.SLFPanel.Size = New System.Drawing.Size(391, 380)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlBottomButton, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.CboCompany, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPlantCode, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPlantName1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtSearchTerm1, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPlantName2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtCity, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtPostalCode, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtDescription, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TxtSearchTerm2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl2, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl3, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl4, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl5, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl6, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl7, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl8, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Lbl9, 0)
        '
        'CboCompany
        '
        Me.CboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCompany.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboCompany.FormattingEnabled = True
        Me.CboCompany.Location = New System.Drawing.Point(141, 10)
        Me.CboCompany.Name = "CboCompany"
        Me.CboCompany.Size = New System.Drawing.Size(207, 29)
        Me.CboCompany.TabIndex = 0
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl1.Location = New System.Drawing.Point(58, 13)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(77, 21)
        Me.Lbl1.SLFCustomElipsis = False
        Me.Lbl1.TabIndex = 997
        Me.Lbl1.Text = "Company"
        '
        'TxtPlantCode
        '
        Me.TxtPlantCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPlantCode.Location = New System.Drawing.Point(141, 45)
        Me.TxtPlantCode.MaxLength = 10
        Me.TxtPlantCode.Name = "TxtPlantCode"
        Me.TxtPlantCode.Size = New System.Drawing.Size(159, 29)
        Me.TxtPlantCode.SLFAutoTrim = True
        Me.TxtPlantCode.SLFHarusDiisi = True
        Me.TxtPlantCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPlantCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPlantCode.SLFHightlightSaatFokus = True
        Me.TxtPlantCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPlantCode.SLFIsBlank = True
        Me.TxtPlantCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtPlantCode.SLFPilihSemuaSaatFokus = True
        Me.TxtPlantCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPlantCode.SLFSQLText = ""
        Me.TxtPlantCode.SLFTanpaSpasi = False
        Me.TxtPlantCode.SLFValidasiField = Nothing
        Me.TxtPlantCode.TabIndex = 1
        Me.TxtPlantCode.Tag = "txt"
        Me.TxtPlantCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPlantName1
        '
        Me.TxtPlantName1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPlantName1.Location = New System.Drawing.Point(142, 80)
        Me.TxtPlantName1.MaxLength = 255
        Me.TxtPlantName1.Name = "TxtPlantName1"
        Me.TxtPlantName1.Size = New System.Drawing.Size(206, 29)
        Me.TxtPlantName1.SLFAutoTrim = True
        Me.TxtPlantName1.SLFHarusDiisi = True
        Me.TxtPlantName1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPlantName1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPlantName1.SLFHightlightSaatFokus = True
        Me.TxtPlantName1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPlantName1.SLFIsBlank = True
        Me.TxtPlantName1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtPlantName1.SLFPilihSemuaSaatFokus = True
        Me.TxtPlantName1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPlantName1.SLFSQLText = ""
        Me.TxtPlantName1.SLFTanpaSpasi = False
        Me.TxtPlantName1.SLFValidasiField = Nothing
        Me.TxtPlantName1.TabIndex = 2
        Me.TxtPlantName1.Tag = "txt"
        '
        'TxtSearchTerm1
        '
        Me.TxtSearchTerm1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtSearchTerm1.Location = New System.Drawing.Point(142, 255)
        Me.TxtSearchTerm1.MaxLength = 255
        Me.TxtSearchTerm1.Name = "TxtSearchTerm1"
        Me.TxtSearchTerm1.Size = New System.Drawing.Size(206, 29)
        Me.TxtSearchTerm1.SLFAutoTrim = True
        Me.TxtSearchTerm1.SLFHarusDiisi = True
        Me.TxtSearchTerm1.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtSearchTerm1.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtSearchTerm1.SLFHightlightSaatFokus = True
        Me.TxtSearchTerm1.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtSearchTerm1.SLFIsBlank = True
        Me.TxtSearchTerm1.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtSearchTerm1.SLFPilihSemuaSaatFokus = False
        Me.TxtSearchTerm1.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtSearchTerm1.SLFSQLText = ""
        Me.TxtSearchTerm1.SLFTanpaSpasi = False
        Me.TxtSearchTerm1.SLFValidasiField = Nothing
        Me.TxtSearchTerm1.TabIndex = 7
        Me.TxtSearchTerm1.Tag = "txt"
        '
        'TxtPlantName2
        '
        Me.TxtPlantName2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPlantName2.Location = New System.Drawing.Point(142, 115)
        Me.TxtPlantName2.MaxLength = 255
        Me.TxtPlantName2.Name = "TxtPlantName2"
        Me.TxtPlantName2.Size = New System.Drawing.Size(206, 29)
        Me.TxtPlantName2.SLFAutoTrim = True
        Me.TxtPlantName2.SLFHarusDiisi = False
        Me.TxtPlantName2.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPlantName2.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPlantName2.SLFHightlightSaatFokus = True
        Me.TxtPlantName2.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPlantName2.SLFIsBlank = True
        Me.TxtPlantName2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtPlantName2.SLFPilihSemuaSaatFokus = True
        Me.TxtPlantName2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPlantName2.SLFSQLText = ""
        Me.TxtPlantName2.SLFTanpaSpasi = False
        Me.TxtPlantName2.SLFValidasiField = Nothing
        Me.TxtPlantName2.TabIndex = 3
        Me.TxtPlantName2.Tag = "txt"
        '
        'TxtCity
        '
        Me.TxtCity.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtCity.Location = New System.Drawing.Point(142, 150)
        Me.TxtCity.MaxLength = 255
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(206, 29)
        Me.TxtCity.SLFAutoTrim = True
        Me.TxtCity.SLFHarusDiisi = True
        Me.TxtCity.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtCity.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtCity.SLFHightlightSaatFokus = True
        Me.TxtCity.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtCity.SLFIsBlank = True
        Me.TxtCity.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtCity.SLFPilihSemuaSaatFokus = True
        Me.TxtCity.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtCity.SLFSQLText = ""
        Me.TxtCity.SLFTanpaSpasi = False
        Me.TxtCity.SLFValidasiField = Nothing
        Me.TxtCity.TabIndex = 4
        Me.TxtCity.Tag = "txt"
        '
        'TxtPostalCode
        '
        Me.TxtPostalCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtPostalCode.Location = New System.Drawing.Point(142, 185)
        Me.TxtPostalCode.MaxLength = 6
        Me.TxtPostalCode.Name = "TxtPostalCode"
        Me.TxtPostalCode.Size = New System.Drawing.Size(95, 29)
        Me.TxtPostalCode.SLFAutoTrim = True
        Me.TxtPostalCode.SLFHarusDiisi = False
        Me.TxtPostalCode.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtPostalCode.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtPostalCode.SLFHightlightSaatFokus = True
        Me.TxtPostalCode.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtPostalCode.SLFIsBlank = True
        Me.TxtPostalCode.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtPostalCode.SLFPilihSemuaSaatFokus = True
        Me.TxtPostalCode.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtPostalCode.SLFSQLText = ""
        Me.TxtPostalCode.SLFTanpaSpasi = False
        Me.TxtPostalCode.SLFValidasiField = Nothing
        Me.TxtPostalCode.TabIndex = 5
        Me.TxtPostalCode.Tag = "txt"
        Me.TxtPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtDescription.Location = New System.Drawing.Point(142, 220)
        Me.TxtDescription.MaxLength = 255
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(206, 29)
        Me.TxtDescription.SLFAutoTrim = True
        Me.TxtDescription.SLFHarusDiisi = True
        Me.TxtDescription.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtDescription.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtDescription.SLFHightlightSaatFokus = True
        Me.TxtDescription.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtDescription.SLFIsBlank = True
        Me.TxtDescription.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtDescription.SLFPilihSemuaSaatFokus = False
        Me.TxtDescription.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtDescription.SLFSQLText = ""
        Me.TxtDescription.SLFTanpaSpasi = False
        Me.TxtDescription.SLFValidasiField = Nothing
        Me.TxtDescription.TabIndex = 6
        Me.TxtDescription.Tag = "txt"
        '
        'TxtSearchTerm2
        '
        Me.TxtSearchTerm2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtSearchTerm2.Location = New System.Drawing.Point(141, 290)
        Me.TxtSearchTerm2.MaxLength = 255
        Me.TxtSearchTerm2.Name = "TxtSearchTerm2"
        Me.TxtSearchTerm2.Size = New System.Drawing.Size(206, 29)
        Me.TxtSearchTerm2.SLFAutoTrim = True
        Me.TxtSearchTerm2.SLFHarusDiisi = False
        Me.TxtSearchTerm2.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtSearchTerm2.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtSearchTerm2.SLFHightlightSaatFokus = True
        Me.TxtSearchTerm2.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtSearchTerm2.SLFIsBlank = True
        Me.TxtSearchTerm2.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.KAPITALSEMUA
        Me.TxtSearchTerm2.SLFPilihSemuaSaatFokus = False
        Me.TxtSearchTerm2.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtSearchTerm2.SLFSQLText = ""
        Me.TxtSearchTerm2.SLFTanpaSpasi = False
        Me.TxtSearchTerm2.SLFValidasiField = Nothing
        Me.TxtSearchTerm2.TabIndex = 8
        Me.TxtSearchTerm2.Tag = "txt"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl2.Location = New System.Drawing.Point(50, 48)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(85, 21)
        Me.Lbl2.SLFCustomElipsis = False
        Me.Lbl2.TabIndex = 1006
        Me.Lbl2.Text = "Plant Code"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl3.Location = New System.Drawing.Point(32, 83)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(104, 21)
        Me.Lbl3.SLFCustomElipsis = False
        Me.Lbl3.TabIndex = 1007
        Me.Lbl3.Text = "Plant Name 1"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl4.Location = New System.Drawing.Point(32, 118)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(104, 21)
        Me.Lbl4.SLFCustomElipsis = False
        Me.Lbl4.TabIndex = 1008
        Me.Lbl4.Text = "Plant Name 2"
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl5.Location = New System.Drawing.Point(98, 153)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(37, 21)
        Me.Lbl5.SLFCustomElipsis = False
        Me.Lbl5.TabIndex = 1009
        Me.Lbl5.Text = "City"
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl6.Location = New System.Drawing.Point(45, 188)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(91, 21)
        Me.Lbl6.SLFCustomElipsis = False
        Me.Lbl6.TabIndex = 1010
        Me.Lbl6.Text = "Postal Code"
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl7.Location = New System.Drawing.Point(47, 223)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(89, 21)
        Me.Lbl7.SLFCustomElipsis = False
        Me.Lbl7.TabIndex = 1011
        Me.Lbl7.Text = "Description"
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl8.Location = New System.Drawing.Point(27, 293)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(108, 21)
        Me.Lbl8.SLFCustomElipsis = False
        Me.Lbl8.TabIndex = 1012
        Me.Lbl8.Text = "Search Term 2"
        '
        'Lbl9
        '
        Me.Lbl9.AutoSize = True
        Me.Lbl9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl9.Location = New System.Drawing.Point(28, 258)
        Me.Lbl9.Name = "Lbl9"
        Me.Lbl9.Size = New System.Drawing.Size(108, 21)
        Me.Lbl9.SLFCustomElipsis = False
        Me.Lbl9.TabIndex = 1013
        Me.Lbl9.Text = "Search Term 1"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(173, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 600
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(279, 7)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancel.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnCancel.SLFTampilkanFocusBorder = False
        Me.BtnCancel.SLFValidasiSemuaInput = False
        Me.BtnCancel.SLFValidasiSemuaInputTag = Nothing
        Me.BtnCancel.TabIndex = 602
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Chk1
        '
        Me.Chk1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk1.AutoSize = True
        Me.Chk1.BackColor = System.Drawing.Color.Transparent
        Me.Chk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chk1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Chk1.ForeColor = System.Drawing.Color.Tomato
        Me.Chk1.Location = New System.Drawing.Point(21, 15)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(146, 25)
        Me.Chk1.TabIndex = 601
        Me.Chk1.Text = "Add new on Save"
        Me.Chk1.UseVisualStyleBackColor = False
        '
        'PLNT_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(391, 498)
        Me.Name = "PLNT_Editor"
        Me.PnlBottomButton.ResumeLayout(False)
        Me.PnlBottomButton.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.SLFPanel.ResumeLayout(False)
        Me.SLFPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CboCompany As CMCv.cbo
    Friend WithEvents Lbl1 As CMCv.lbl
    Friend WithEvents Lbl9 As CMCv.lbl
    Friend WithEvents Lbl8 As CMCv.lbl
    Friend WithEvents Lbl7 As CMCv.lbl
    Friend WithEvents Lbl6 As CMCv.lbl
    Friend WithEvents Lbl5 As CMCv.lbl
    Friend WithEvents Lbl4 As CMCv.lbl
    Friend WithEvents Lbl3 As CMCv.lbl
    Friend WithEvents Lbl2 As CMCv.lbl
    Friend WithEvents TxtSearchTerm2 As CMCv.txt
    Friend WithEvents TxtDescription As CMCv.txt
    Friend WithEvents TxtPostalCode As CMCv.txt
    Friend WithEvents TxtCity As CMCv.txt
    Friend WithEvents TxtPlantName2 As CMCv.txt
    Friend WithEvents TxtSearchTerm1 As CMCv.txt
    Friend WithEvents TxtPlantName1 As CMCv.txt
    Friend WithEvents TxtPlantCode As CMCv.txt
    Friend WithEvents Chk1 As CMCv.chk
    Friend WithEvents BtnCancel As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
End Class
