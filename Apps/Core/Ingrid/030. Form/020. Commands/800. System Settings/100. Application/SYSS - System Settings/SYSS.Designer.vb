<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYSS
    Inherits CMCv.Std_Fi

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
        Me.BtnSave = New CMCv.btn(Me.components)
        Me.BtnReset = New CMCv.btn(Me.components)
        Me.TbctlSettings = New CMCv.tbctl(Me.components)
        Me.tbInterface = New System.Windows.Forms.TabPage()
        Me.GbxPanels = New CMCv.gbx(Me.components)
        Me.CboProfile = New CMCv.cbo(Me.components)
        Me.CboStorage = New CMCv.cbo(Me.components)
        Me.CboNewsTicker = New CMCv.cbo(Me.components)
        Me.tbStorage = New System.Windows.Forms.TabPage()
        Me.GbxWatermark = New CMCv.gbx(Me.components)
        Me.CboWatermark = New CMCv.cbo(Me.components)
        Me.TxtWatermark = New CMCv.txt(Me.components)
        Me.Gbx1 = New CMCv.gbx(Me.components)
        Me.Lbl7 = New CMCv.lbl(Me.components)
        Me.nudUploadPDF = New System.Windows.Forms.NumericUpDown()
        Me.Lbl6 = New CMCv.lbl(Me.components)
        Me.nudUploadPhoto = New System.Windows.Forms.NumericUpDown()
        Me.tbSecurity = New System.Windows.Forms.TabPage()
        Me.Gbx2 = New CMCv.gbx(Me.components)
        Me.nudMinPassword = New System.Windows.Forms.NumericUpDown()
        Me.ULbl1 = New CMCv.ULbl()
        Me.ULbl2 = New CMCv.ULbl()
        Me.ULbl3 = New CMCv.ULbl()
        Me.ULbl4 = New CMCv.ULbl()
        Me.ULbl5 = New CMCv.ULbl()
        Me.ULbl6 = New CMCv.ULbl()
        Me.ULbl7 = New CMCv.ULbl()
        Me.ULbl8 = New CMCv.ULbl()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.TbctlSettings.SuspendLayout()
        Me.tbInterface.SuspendLayout()
        Me.GbxPanels.SuspendLayout()
        Me.tbStorage.SuspendLayout()
        Me.GbxWatermark.SuspendLayout()
        Me.Gbx1.SuspendLayout()
        CType(Me.nudUploadPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUploadPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSecurity.SuspendLayout()
        Me.Gbx2.SuspendLayout()
        CType(Me.nudMinPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlFind
        '
        Me.PnlFind.Controls.Add(Me.BtnReset)
        Me.PnlFind.Controls.Add(Me.BtnSave)
        Me.PnlFind.Controls.SetChildIndex(Me.TxtFind, 0)
        Me.PnlFind.Controls.SetChildIndex(Me.LblFind, 0)
        Me.PnlFind.Controls.SetChildIndex(Me.BtnClear, 0)
        Me.PnlFind.Controls.SetChildIndex(Me.BtnSave, 0)
        Me.PnlFind.Controls.SetChildIndex(Me.BtnReset, 0)
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClear.Visible = False
        '
        'LblFind
        '
        Me.LblFind.Visible = False
        '
        'TxtFind
        '
        Me.TxtFind.BackColor = System.Drawing.Color.White
        Me.TxtFind.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic)
        Me.TxtFind.ForeColor = System.Drawing.Color.LightGray
        Me.TxtFind.SLFIsBlank = False
        Me.TxtFind.SLFSQLText = ""
        Me.TxtFind.Text = "Type then press Enter"
        Me.TxtFind.Visible = False
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.TbctlSettings)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.TbctlSettings, 0)
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSave.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(566, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 40)
        Me.BtnSave.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.Yes
        Me.BtnSave.SLFTampilkanFocusBorder = False
        Me.BtnSave.SLFValidasiSemuaInput = False
        Me.BtnSave.SLFValidasiSemuaInputTag = Nothing
        Me.BtnSave.TabIndex = 802
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnReset.BackColor = System.Drawing.Color.Red
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnReset.FlatAppearance.BorderSize = 2
        Me.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.Location = New System.Drawing.Point(672, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 40)
        Me.BtnReset.SLFJenisTombol = CMCv.ControlCodeBase.enuJenisTombol.No
        Me.BtnReset.SLFTampilkanFocusBorder = False
        Me.BtnReset.SLFValidasiSemuaInput = False
        Me.BtnReset.SLFValidasiSemuaInputTag = Nothing
        Me.BtnReset.TabIndex = 803
        Me.BtnReset.Text = "&Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'TbctlSettings
        '
        Me.TbctlSettings.Controls.Add(Me.tbInterface)
        Me.TbctlSettings.Controls.Add(Me.tbStorage)
        Me.TbctlSettings.Controls.Add(Me.tbSecurity)
        Me.TbctlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbctlSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TbctlSettings.Location = New System.Drawing.Point(0, 46)
        Me.TbctlSettings.Name = "TbctlSettings"
        Me.TbctlSettings.SelectedIndex = 0
        Me.TbctlSettings.Size = New System.Drawing.Size(784, 439)
        Me.TbctlSettings.TabIndex = 802
        '
        'tbInterface
        '
        Me.tbInterface.Controls.Add(Me.GbxPanels)
        Me.tbInterface.Location = New System.Drawing.Point(4, 30)
        Me.tbInterface.Name = "tbInterface"
        Me.tbInterface.Padding = New System.Windows.Forms.Padding(3)
        Me.tbInterface.Size = New System.Drawing.Size(776, 405)
        Me.tbInterface.TabIndex = 0
        Me.tbInterface.Text = "INTERFACE"
        Me.tbInterface.UseVisualStyleBackColor = True
        '
        'GbxPanels
        '
        Me.GbxPanels.Controls.Add(Me.ULbl3)
        Me.GbxPanels.Controls.Add(Me.ULbl2)
        Me.GbxPanels.Controls.Add(Me.ULbl1)
        Me.GbxPanels.Controls.Add(Me.CboProfile)
        Me.GbxPanels.Controls.Add(Me.CboStorage)
        Me.GbxPanels.Controls.Add(Me.CboNewsTicker)
        Me.GbxPanels.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GbxPanels.Location = New System.Drawing.Point(15, 15)
        Me.GbxPanels.Name = "GbxPanels"
        Me.GbxPanels.Size = New System.Drawing.Size(369, 146)
        Me.GbxPanels.TabIndex = 7
        Me.GbxPanels.TabStop = False
        Me.GbxPanels.Text = "Panel Visibility"
        '
        'CboProfile
        '
        Me.CboProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProfile.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboProfile.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboProfile.FormattingEnabled = True
        Me.CboProfile.Items.AddRange(New Object() {"Disabled", "Administrator Only", "User Only", "All Users"})
        Me.CboProfile.Location = New System.Drawing.Point(174, 30)
        Me.CboProfile.Name = "CboProfile"
        Me.CboProfile.Size = New System.Drawing.Size(185, 29)
        Me.CboProfile.TabIndex = 0
        '
        'CboStorage
        '
        Me.CboStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboStorage.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboStorage.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboStorage.FormattingEnabled = True
        Me.CboStorage.Items.AddRange(New Object() {"Disabled", "Administrator Only", "User Only", "All Users"})
        Me.CboStorage.Location = New System.Drawing.Point(174, 65)
        Me.CboStorage.Name = "CboStorage"
        Me.CboStorage.Size = New System.Drawing.Size(186, 29)
        Me.CboStorage.TabIndex = 1
        '
        'CboNewsTicker
        '
        Me.CboNewsTicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNewsTicker.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboNewsTicker.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboNewsTicker.FormattingEnabled = True
        Me.CboNewsTicker.Items.AddRange(New Object() {"Disabled", "Administrator Only", "User Only", "All Users"})
        Me.CboNewsTicker.Location = New System.Drawing.Point(174, 100)
        Me.CboNewsTicker.Name = "CboNewsTicker"
        Me.CboNewsTicker.Size = New System.Drawing.Size(186, 29)
        Me.CboNewsTicker.TabIndex = 2
        '
        'tbStorage
        '
        Me.tbStorage.Controls.Add(Me.GbxWatermark)
        Me.tbStorage.Controls.Add(Me.Gbx1)
        Me.tbStorage.Location = New System.Drawing.Point(4, 30)
        Me.tbStorage.Name = "tbStorage"
        Me.tbStorage.Padding = New System.Windows.Forms.Padding(3)
        Me.tbStorage.Size = New System.Drawing.Size(776, 405)
        Me.tbStorage.TabIndex = 1
        Me.tbStorage.Text = "STORAGE"
        Me.tbStorage.UseVisualStyleBackColor = True
        '
        'GbxWatermark
        '
        Me.GbxWatermark.Controls.Add(Me.ULbl7)
        Me.GbxWatermark.Controls.Add(Me.ULbl6)
        Me.GbxWatermark.Controls.Add(Me.CboWatermark)
        Me.GbxWatermark.Controls.Add(Me.TxtWatermark)
        Me.GbxWatermark.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GbxWatermark.Location = New System.Drawing.Point(15, 129)
        Me.GbxWatermark.Name = "GbxWatermark"
        Me.GbxWatermark.Size = New System.Drawing.Size(410, 107)
        Me.GbxWatermark.TabIndex = 12
        Me.GbxWatermark.TabStop = False
        Me.GbxWatermark.Text = "Picture Watermark"
        '
        'CboWatermark
        '
        Me.CboWatermark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboWatermark.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CboWatermark.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CboWatermark.FormattingEnabled = True
        Me.CboWatermark.Items.AddRange(New Object() {"Disabled", "Administrator Only", "User Only", "All Users"})
        Me.CboWatermark.Location = New System.Drawing.Point(164, 30)
        Me.CboWatermark.Name = "CboWatermark"
        Me.CboWatermark.Size = New System.Drawing.Size(185, 29)
        Me.CboWatermark.TabIndex = 2
        '
        'TxtWatermark
        '
        Me.TxtWatermark.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtWatermark.Location = New System.Drawing.Point(164, 65)
        Me.TxtWatermark.MaxLength = 255
        Me.TxtWatermark.Name = "TxtWatermark"
        Me.TxtWatermark.Size = New System.Drawing.Size(240, 29)
        Me.TxtWatermark.SLFAutoTrim = False
        Me.TxtWatermark.SLFHarusDiisi = False
        Me.TxtWatermark.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtWatermark.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtWatermark.SLFHightlightSaatFokus = False
        Me.TxtWatermark.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtWatermark.SLFIsBlank = True
        Me.TxtWatermark.SLFIsSearchBox = False
        Me.TxtWatermark.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtWatermark.SLFPilihSemuaSaatFokus = False
        Me.TxtWatermark.SLFPwdLengthMin = 8
        Me.TxtWatermark.SLFPwdStrengthCalculate = False
        Me.TxtWatermark.SLFPwdStrengthScore = 0
        Me.TxtWatermark.SLFPwdStrengthText = Nothing
        Me.TxtWatermark.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtWatermark.SLFSearchBoxText = "Watermark Text"
        Me.TxtWatermark.SLFSQLText = ""
        Me.TxtWatermark.SLFTanpaSpasi = False
        Me.TxtWatermark.SLFValidasiField = Nothing
        Me.TxtWatermark.TabIndex = 3
        Me.TxtWatermark.Tag = "txt"
        '
        'Gbx1
        '
        Me.Gbx1.Controls.Add(Me.ULbl5)
        Me.Gbx1.Controls.Add(Me.ULbl4)
        Me.Gbx1.Controls.Add(Me.Lbl7)
        Me.Gbx1.Controls.Add(Me.nudUploadPDF)
        Me.Gbx1.Controls.Add(Me.Lbl6)
        Me.Gbx1.Controls.Add(Me.nudUploadPhoto)
        Me.Gbx1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Gbx1.Location = New System.Drawing.Point(15, 15)
        Me.Gbx1.Name = "Gbx1"
        Me.Gbx1.Size = New System.Drawing.Size(410, 108)
        Me.Gbx1.TabIndex = 11
        Me.Gbx1.TabStop = False
        Me.Gbx1.Text = "Upload Limit"
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl7.Location = New System.Drawing.Point(290, 67)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(33, 21)
        Me.Lbl7.SLFCustomElipsis = False
        Me.Lbl7.TabIndex = 15
        Me.Lbl7.Text = "MB"
        '
        'nudUploadPDF
        '
        Me.nudUploadPDF.Location = New System.Drawing.Point(164, 65)
        Me.nudUploadPDF.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudUploadPDF.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudUploadPDF.Name = "nudUploadPDF"
        Me.nudUploadPDF.Size = New System.Drawing.Size(120, 29)
        Me.nudUploadPDF.TabIndex = 1
        Me.nudUploadPDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudUploadPDF.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Lbl6.Location = New System.Drawing.Point(290, 31)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(33, 21)
        Me.Lbl6.SLFCustomElipsis = False
        Me.Lbl6.TabIndex = 13
        Me.Lbl6.Text = "MB"
        '
        'nudUploadPhoto
        '
        Me.nudUploadPhoto.Location = New System.Drawing.Point(164, 30)
        Me.nudUploadPhoto.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudUploadPhoto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudUploadPhoto.Name = "nudUploadPhoto"
        Me.nudUploadPhoto.Size = New System.Drawing.Size(120, 29)
        Me.nudUploadPhoto.TabIndex = 0
        Me.nudUploadPhoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudUploadPhoto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbSecurity
        '
        Me.tbSecurity.Controls.Add(Me.Gbx2)
        Me.tbSecurity.Location = New System.Drawing.Point(4, 30)
        Me.tbSecurity.Name = "tbSecurity"
        Me.tbSecurity.Size = New System.Drawing.Size(776, 405)
        Me.tbSecurity.TabIndex = 2
        Me.tbSecurity.Text = "SECURITY"
        Me.tbSecurity.UseVisualStyleBackColor = True
        '
        'Gbx2
        '
        Me.Gbx2.Controls.Add(Me.ULbl8)
        Me.Gbx2.Controls.Add(Me.nudMinPassword)
        Me.Gbx2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Gbx2.Location = New System.Drawing.Point(15, 15)
        Me.Gbx2.Name = "Gbx2"
        Me.Gbx2.Size = New System.Drawing.Size(333, 86)
        Me.Gbx2.TabIndex = 0
        Me.Gbx2.TabStop = False
        Me.Gbx2.Text = "Password"
        '
        'nudMinPassword
        '
        Me.nudMinPassword.Location = New System.Drawing.Point(164, 30)
        Me.nudMinPassword.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMinPassword.Name = "nudMinPassword"
        Me.nudMinPassword.Size = New System.Drawing.Size(120, 29)
        Me.nudMinPassword.TabIndex = 0
        Me.nudMinPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMinPassword.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ULbl1
        '
        Me.ULbl1.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl1.Location = New System.Drawing.Point(7, 30)
        Me.ULbl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl1.Name = "ULbl1"
        Me.ULbl1.Size = New System.Drawing.Size(160, 29)
        Me.ULbl1.SLFText = "Show Profile"
        Me.ULbl1.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl1.TabIndex = 7
        '
        'ULbl2
        '
        Me.ULbl2.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl2.Location = New System.Drawing.Point(7, 65)
        Me.ULbl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl2.Name = "ULbl2"
        Me.ULbl2.Size = New System.Drawing.Size(160, 29)
        Me.ULbl2.SLFText = "Show Storage"
        Me.ULbl2.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl2.TabIndex = 8
        '
        'ULbl3
        '
        Me.ULbl3.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl3.Location = New System.Drawing.Point(7, 100)
        Me.ULbl3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl3.Name = "ULbl3"
        Me.ULbl3.Size = New System.Drawing.Size(160, 29)
        Me.ULbl3.SLFText = "Show News Ticker"
        Me.ULbl3.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl3.TabIndex = 9
        '
        'ULbl4
        '
        Me.ULbl4.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl4.Location = New System.Drawing.Point(7, 30)
        Me.ULbl4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl4.Name = "ULbl4"
        Me.ULbl4.Size = New System.Drawing.Size(150, 29)
        Me.ULbl4.SLFText = "Photo"
        Me.ULbl4.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl4.TabIndex = 16
        '
        'ULbl5
        '
        Me.ULbl5.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl5.Location = New System.Drawing.Point(7, 65)
        Me.ULbl5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl5.Name = "ULbl5"
        Me.ULbl5.Size = New System.Drawing.Size(150, 29)
        Me.ULbl5.SLFText = "PDF"
        Me.ULbl5.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl5.TabIndex = 17
        '
        'ULbl6
        '
        Me.ULbl6.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl6.Location = New System.Drawing.Point(7, 30)
        Me.ULbl6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl6.Name = "ULbl6"
        Me.ULbl6.Size = New System.Drawing.Size(150, 29)
        Me.ULbl6.SLFText = "Show To"
        Me.ULbl6.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl6.TabIndex = 14
        '
        'ULbl7
        '
        Me.ULbl7.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl7.Location = New System.Drawing.Point(7, 65)
        Me.ULbl7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl7.Name = "ULbl7"
        Me.ULbl7.Size = New System.Drawing.Size(150, 29)
        Me.ULbl7.SLFText = "Text"
        Me.ULbl7.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl7.TabIndex = 15
        '
        'ULbl8
        '
        Me.ULbl8.BackColor = System.Drawing.Color.Moccasin
        Me.ULbl8.Location = New System.Drawing.Point(7, 30)
        Me.ULbl8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULbl8.Name = "ULbl8"
        Me.ULbl8.Size = New System.Drawing.Size(150, 29)
        Me.ULbl8.SLFText = "Minimum Length"
        Me.ULbl8.SLFWarnaLabel = CMCv.ControlCodeBase.enuJenisLabel.Yellow
        Me.ULbl8.TabIndex = 2
        '
        'SYSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.KeyPreview = True
        Me.Name = "SYSS"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.TbctlSettings.ResumeLayout(False)
        Me.tbInterface.ResumeLayout(False)
        Me.GbxPanels.ResumeLayout(False)
        Me.tbStorage.ResumeLayout(False)
        Me.GbxWatermark.ResumeLayout(False)
        Me.GbxWatermark.PerformLayout()
        Me.Gbx1.ResumeLayout(False)
        Me.Gbx1.PerformLayout()
        CType(Me.nudUploadPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUploadPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSecurity.ResumeLayout(False)
        Me.Gbx2.ResumeLayout(False)
        CType(Me.nudMinPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnReset As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents TbctlSettings As CMCv.tbctl
    Friend WithEvents tbInterface As TabPage
    Friend WithEvents CboProfile As CMCv.cbo
    Friend WithEvents tbStorage As TabPage
    Friend WithEvents tbSecurity As TabPage
    Friend WithEvents CboNewsTicker As CMCv.cbo
    Friend WithEvents CboStorage As CMCv.cbo
    Friend WithEvents Gbx1 As CMCv.gbx
    Friend WithEvents Lbl7 As CMCv.lbl
    Friend WithEvents nudUploadPDF As NumericUpDown
    Friend WithEvents Lbl6 As CMCv.lbl
    Friend WithEvents nudUploadPhoto As NumericUpDown
    Friend WithEvents GbxWatermark As CMCv.gbx
    Friend WithEvents TxtWatermark As CMCv.txt
    Friend WithEvents GbxPanels As CMCv.gbx
    Friend WithEvents Gbx2 As CMCv.gbx
    Friend WithEvents nudMinPassword As NumericUpDown
    Friend WithEvents CboWatermark As CMCv.cbo
    Friend WithEvents ULbl3 As CMCv.ULbl
    Friend WithEvents ULbl2 As CMCv.ULbl
    Friend WithEvents ULbl1 As CMCv.ULbl
    Friend WithEvents ULbl7 As CMCv.ULbl
    Friend WithEvents ULbl6 As CMCv.ULbl
    Friend WithEvents ULbl5 As CMCv.ULbl
    Friend WithEvents ULbl4 As CMCv.ULbl
    Friend WithEvents ULbl8 As CMCv.ULbl
End Class
