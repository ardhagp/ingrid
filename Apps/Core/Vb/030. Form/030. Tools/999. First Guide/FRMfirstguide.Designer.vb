Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMfirstguide
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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Btn_Process = New CMCv.UI.Control.Btn(components)
            Lbl_Step = New CMCv.UI.Control.lbl(components)
            Gbx_Company = New CMCv.UI.Control.gbx(components)
            ULblEmploymentType = New CMCv.UI.Control.ULbl()
            CboEmploymentType = New CMCv.UI.Control.cbo(components)
            ULbl5 = New CMCv.UI.Control.ULbl()
            Txt_EmployeeID = New CMCv.UI.Control.txt(components)
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl1 = New CMCv.UI.Control.ULbl()
            Txt_EmployeeName = New CMCv.UI.Control.txt(components)
            Txt_Position = New CMCv.UI.Control.txt(components)
            Txt_Department = New CMCv.UI.Control.txt(components)
            Txt_Company = New CMCv.UI.Control.txt(components)
            Btn_Close = New CMCv.UI.Control.Btn(components)
            Gbx_Login = New CMCv.UI.Control.gbx(components)
            Btn_Check = New CMCv.UI.Control.Btn(components)
            UPwdStrength1 = New CMCv.UI.Control.UPwdStrength()
            ULbl7 = New CMCv.UI.Control.ULbl()
            ULbl6 = New CMCv.UI.Control.ULbl()
            Txt_Password = New CMCv.UI.Control.txt(components)
            Txt_Username = New CMCv.UI.Control.txt(components)
            object_da28eea8_631c_4534_a532_605841b1d2bd = New CMCv.UI.Control.lbl(components)
            Gbx_Modules = New CMCv.UI.Control.gbx(components)
            Dgn1 = New CMCv.UI.Control.dgn(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Gbx_Company.SuspendLayout()
            Gbx_Login.SuspendLayout()
            Gbx_Modules.SuspendLayout()
            CType(Dgn1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(Btn_Close)
            PnlBottomButton.Controls.Add(Btn_Process)
            PnlBottomButton.Location = New Point(0, 668)
            PnlBottomButton.Margin = New Padding(7, 10, 7, 10)
            PnlBottomButton.Size = New Size(684, 97)
            PnlBottomButton.Controls.SetChildIndex(Btn_Process, 0)
            PnlBottomButton.Controls.SetChildIndex(Btn_Close, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 10, 7, 10)
            pnl_.Size = New Size(684, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(Lbl_Step)
            SLFPanel.Controls.Add(Gbx_Company)
            SLFPanel.Controls.Add(Gbx_Modules)
            SLFPanel.Controls.Add(Gbx_Login)
            SLFPanel.Margin = New Padding(7, 10, 7, 10)
            SLFPanel.Size = New Size(684, 765)
            SLFPanel.Controls.SetChildIndex(Gbx_Login, 0)
            SLFPanel.Controls.SetChildIndex(Gbx_Modules, 0)
            SLFPanel.Controls.SetChildIndex(Gbx_Company, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Lbl_Step, 0)
            ' 
            ' Btn_Process
            ' 
            Btn_Process.BackColor = Color.RoyalBlue
            Btn_Process.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            Btn_Process.FlatAppearance.BorderSize = 2
            Btn_Process.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            Btn_Process.FlatStyle = FlatStyle.Flat
            Btn_Process.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            Btn_Process.ForeColor = Color.White
            Btn_Process.Location = New Point(524, 18)
            Btn_Process.Margin = New Padding(4, 5, 4, 5)
            Btn_Process.Name = "Btn_Process"
            Btn_Process.Size = New Size(143, 67)
            Btn_Process.TabIndex = 1
            Btn_Process.Text = "&Next"
            Btn_Process.UseVisualStyleBackColor = False
            Btn_Process.XOButtonType = ControlCodeBase.buttonType.Default
            Btn_Process.XOShowBorderOnFocus = False
            Btn_Process.XOValidateAllInput = False
            Btn_Process.XOValidateAllInputTag = Nothing
            ' 
            ' Lbl_Step
            ' 
            Lbl_Step.AutoSize = True
            Lbl_Step.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            Lbl_Step.Location = New Point(26, 30)
            Lbl_Step.Margin = New Padding(4, 0, 4, 0)
            Lbl_Step.Name = "Lbl_Step"
            Lbl_Step.Size = New Size(98, 32)
            Lbl_Step.TabIndex = 996
            Lbl_Step.Text = "Step 1 :"
            Lbl_Step.XOCustomElipsis = False
            ' 
            ' Gbx_Company
            ' 
            Gbx_Company.Controls.Add(ULblEmploymentType)
            Gbx_Company.Controls.Add(CboEmploymentType)
            Gbx_Company.Controls.Add(ULbl5)
            Gbx_Company.Controls.Add(Txt_EmployeeID)
            Gbx_Company.Controls.Add(ULbl4)
            Gbx_Company.Controls.Add(ULbl3)
            Gbx_Company.Controls.Add(ULbl2)
            Gbx_Company.Controls.Add(ULbl1)
            Gbx_Company.Controls.Add(Txt_EmployeeName)
            Gbx_Company.Controls.Add(Txt_Position)
            Gbx_Company.Controls.Add(Txt_Department)
            Gbx_Company.Controls.Add(Txt_Company)
            Gbx_Company.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Gbx_Company.Location = New Point(17, 70)
            Gbx_Company.Margin = New Padding(4, 5, 4, 5)
            Gbx_Company.Name = "Gbx_Company"
            Gbx_Company.Padding = New Padding(4, 5, 4, 5)
            Gbx_Company.Size = New Size(650, 582)
            Gbx_Company.TabIndex = 998
            Gbx_Company.TabStop = False
            Gbx_Company.Text = "About You && Your Company"
            ' 
            ' ULblEmploymentType
            ' 
            ULblEmploymentType.BackColor = Color.Moccasin
            ULblEmploymentType.Location = New Point(9, 372)
            ULblEmploymentType.Margin = New Padding(5, 6, 5, 6)
            ULblEmploymentType.Name = "ULblEmploymentType"
            ULblEmploymentType.Size = New Size(251, 40)
            ULblEmploymentType.SLFText = "Employment Type"
            ULblEmploymentType.SLFTextAdjuster = False
            ULblEmploymentType.SLFTextBorder = False
            ULblEmploymentType.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULblEmploymentType.TabIndex = 1009
            ' 
            ' CboEmploymentType
            ' 
            CboEmploymentType.DropDownStyle = ComboBoxStyle.DropDownList
            CboEmploymentType.FlatStyle = FlatStyle.Flat
            CboEmploymentType.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboEmploymentType.FormattingEnabled = True
            CboEmploymentType.Location = New Point(271, 372)
            CboEmploymentType.Name = "CboEmploymentType"
            CboEmploymentType.Size = New Size(370, 40)
            CboEmploymentType.TabIndex = 6
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(10, 307)
            ULbl5.Margin = New Padding(6, 5, 6, 5)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 39)
            ULbl5.SLFText = "Your Employee ID#"
            ULbl5.SLFTextAdjuster = False
            ULbl5.SLFTextBorder = False
            ULbl5.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl5.TabIndex = 1007
            ' 
            ' Txt_EmployeeID
            ' 
            Txt_EmployeeID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_EmployeeID.Location = New Point(270, 307)
            Txt_EmployeeID.Margin = New Padding(4, 5, 4, 5)
            Txt_EmployeeID.MaxLength = 255
            Txt_EmployeeID.Name = "Txt_EmployeeID"
            Txt_EmployeeID.Size = New Size(370, 39)
            Txt_EmployeeID.TabIndex = 5
            Txt_EmployeeID.Tag = "txt"
            Txt_EmployeeID.XOAutoTrim = True
            Txt_EmployeeID.XOHarusDiisi = True
            Txt_EmployeeID.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_EmployeeID.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_EmployeeID.XOHightlightSaatFokus = True
            Txt_EmployeeID.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_EmployeeID.XOIsBlank = True
            Txt_EmployeeID.XOIsSearchBox = False
            Txt_EmployeeID.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_EmployeeID.XOPilihSemuaSaatFokus = False
            Txt_EmployeeID.XOPwdLengthMin = 8
            Txt_EmployeeID.XOPwdStrengthCalculate = False
            Txt_EmployeeID.XOPwdStrengthScore = 0
            Txt_EmployeeID.XOPwdStrengthText = Nothing
            Txt_EmployeeID.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_EmployeeID.XOSearchBoxText = "Type then press Enter"
            Txt_EmployeeID.XOSQLText = ""
            Txt_EmployeeID.XOTanpaSpasi = False
            Txt_EmployeeID.XOValidasiField = Nothing
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(10, 242)
            ULbl4.Margin = New Padding(6, 5, 6, 5)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 39)
            ULbl4.SLFText = "Your Name"
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl4.TabIndex = 1005
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(10, 177)
            ULbl3.Margin = New Padding(6, 5, 6, 5)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 39)
            ULbl3.SLFText = "Position"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl3.TabIndex = 1004
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(10, 112)
            ULbl2.Margin = New Padding(6, 5, 6, 5)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 39)
            ULbl2.SLFText = "Department"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl2.TabIndex = 1003
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(10, 47)
            ULbl1.Margin = New Padding(6, 5, 6, 5)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 39)
            ULbl1.SLFText = "Company"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.JenisLabel.Yellow
            ULbl1.TabIndex = 1002
            ' 
            ' Txt_EmployeeName
            ' 
            Txt_EmployeeName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_EmployeeName.Location = New Point(270, 242)
            Txt_EmployeeName.Margin = New Padding(4, 5, 4, 5)
            Txt_EmployeeName.MaxLength = 255
            Txt_EmployeeName.Name = "Txt_EmployeeName"
            Txt_EmployeeName.Size = New Size(370, 39)
            Txt_EmployeeName.TabIndex = 4
            Txt_EmployeeName.Tag = "txt"
            Txt_EmployeeName.XOAutoTrim = True
            Txt_EmployeeName.XOHarusDiisi = True
            Txt_EmployeeName.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_EmployeeName.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_EmployeeName.XOHightlightSaatFokus = True
            Txt_EmployeeName.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_EmployeeName.XOIsBlank = True
            Txt_EmployeeName.XOIsSearchBox = False
            Txt_EmployeeName.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_EmployeeName.XOPilihSemuaSaatFokus = False
            Txt_EmployeeName.XOPwdLengthMin = 8
            Txt_EmployeeName.XOPwdStrengthCalculate = False
            Txt_EmployeeName.XOPwdStrengthScore = 0
            Txt_EmployeeName.XOPwdStrengthText = Nothing
            Txt_EmployeeName.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_EmployeeName.XOSearchBoxText = "Type then press Enter"
            Txt_EmployeeName.XOSQLText = ""
            Txt_EmployeeName.XOTanpaSpasi = False
            Txt_EmployeeName.XOValidasiField = Nothing
            ' 
            ' Txt_Position
            ' 
            Txt_Position.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_Position.Location = New Point(270, 177)
            Txt_Position.Margin = New Padding(4, 5, 4, 5)
            Txt_Position.MaxLength = 255
            Txt_Position.Name = "Txt_Position"
            Txt_Position.Size = New Size(370, 39)
            Txt_Position.TabIndex = 3
            Txt_Position.Tag = "txt"
            Txt_Position.XOAutoTrim = True
            Txt_Position.XOHarusDiisi = True
            Txt_Position.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_Position.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_Position.XOHightlightSaatFokus = True
            Txt_Position.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_Position.XOIsBlank = True
            Txt_Position.XOIsSearchBox = False
            Txt_Position.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_Position.XOPilihSemuaSaatFokus = False
            Txt_Position.XOPwdLengthMin = 8
            Txt_Position.XOPwdStrengthCalculate = False
            Txt_Position.XOPwdStrengthScore = 0
            Txt_Position.XOPwdStrengthText = Nothing
            Txt_Position.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_Position.XOSearchBoxText = "Type then press Enter"
            Txt_Position.XOSQLText = ""
            Txt_Position.XOTanpaSpasi = False
            Txt_Position.XOValidasiField = Nothing
            ' 
            ' Txt_Department
            ' 
            Txt_Department.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_Department.Location = New Point(270, 112)
            Txt_Department.Margin = New Padding(4, 5, 4, 5)
            Txt_Department.MaxLength = 255
            Txt_Department.Name = "Txt_Department"
            Txt_Department.Size = New Size(370, 39)
            Txt_Department.TabIndex = 2
            Txt_Department.Tag = "txt"
            Txt_Department.XOAutoTrim = True
            Txt_Department.XOHarusDiisi = True
            Txt_Department.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_Department.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_Department.XOHightlightSaatFokus = True
            Txt_Department.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_Department.XOIsBlank = True
            Txt_Department.XOIsSearchBox = False
            Txt_Department.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_Department.XOPilihSemuaSaatFokus = False
            Txt_Department.XOPwdLengthMin = 8
            Txt_Department.XOPwdStrengthCalculate = False
            Txt_Department.XOPwdStrengthScore = 0
            Txt_Department.XOPwdStrengthText = Nothing
            Txt_Department.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_Department.XOSearchBoxText = "Type then press Enter"
            Txt_Department.XOSQLText = ""
            Txt_Department.XOTanpaSpasi = False
            Txt_Department.XOValidasiField = Nothing
            ' 
            ' Txt_Company
            ' 
            Txt_Company.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_Company.Location = New Point(270, 47)
            Txt_Company.Margin = New Padding(4, 5, 4, 5)
            Txt_Company.MaxLength = 255
            Txt_Company.Name = "Txt_Company"
            Txt_Company.Size = New Size(370, 39)
            Txt_Company.TabIndex = 1
            Txt_Company.Tag = "txt"
            Txt_Company.XOAutoTrim = True
            Txt_Company.XOHarusDiisi = True
            Txt_Company.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_Company.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_Company.XOHightlightSaatFokus = True
            Txt_Company.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_Company.XOIsBlank = True
            Txt_Company.XOIsSearchBox = False
            Txt_Company.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_Company.XOPilihSemuaSaatFokus = False
            Txt_Company.XOPwdLengthMin = 8
            Txt_Company.XOPwdStrengthCalculate = False
            Txt_Company.XOPwdStrengthScore = 0
            Txt_Company.XOPwdStrengthText = Nothing
            Txt_Company.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_Company.XOSearchBoxText = "Type then press Enter"
            Txt_Company.XOSQLText = ""
            Txt_Company.XOTanpaSpasi = False
            Txt_Company.XOValidasiField = Nothing
            ' 
            ' Btn_Close
            ' 
            Btn_Close.BackColor = Color.Red
            Btn_Close.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            Btn_Close.FlatAppearance.BorderSize = 2
            Btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            Btn_Close.FlatStyle = FlatStyle.Flat
            Btn_Close.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            Btn_Close.ForeColor = Color.White
            Btn_Close.Location = New Point(373, 18)
            Btn_Close.Margin = New Padding(4, 5, 4, 5)
            Btn_Close.Name = "Btn_Close"
            Btn_Close.Size = New Size(143, 67)
            Btn_Close.TabIndex = 2
            Btn_Close.Text = "&Close"
            Btn_Close.UseVisualStyleBackColor = False
            Btn_Close.XOButtonType = ControlCodeBase.buttonType.No
            Btn_Close.XOShowBorderOnFocus = False
            Btn_Close.XOValidateAllInput = False
            Btn_Close.XOValidateAllInputTag = Nothing
            ' 
            ' Gbx_Login
            ' 
            Gbx_Login.Controls.Add(Btn_Check)
            Gbx_Login.Controls.Add(UPwdStrength1)
            Gbx_Login.Controls.Add(ULbl7)
            Gbx_Login.Controls.Add(ULbl6)
            Gbx_Login.Controls.Add(Txt_Password)
            Gbx_Login.Controls.Add(Txt_Username)
            Gbx_Login.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Gbx_Login.Location = New Point(17, 70)
            Gbx_Login.Margin = New Padding(4, 5, 4, 5)
            Gbx_Login.Name = "Gbx_Login"
            Gbx_Login.Padding = New Padding(4, 5, 4, 5)
            Gbx_Login.Size = New Size(650, 582)
            Gbx_Login.TabIndex = 1007
            Gbx_Login.TabStop = False
            Gbx_Login.Text = "About Your Login"
            ' 
            ' Btn_Check
            ' 
            Btn_Check.BackColor = Color.RoyalBlue
            Btn_Check.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            Btn_Check.FlatAppearance.BorderSize = 2
            Btn_Check.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            Btn_Check.FlatStyle = FlatStyle.Flat
            Btn_Check.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            Btn_Check.ForeColor = Color.White
            Btn_Check.Location = New Point(499, 265)
            Btn_Check.Margin = New Padding(4, 5, 4, 5)
            Btn_Check.Name = "Btn_Check"
            Btn_Check.Size = New Size(143, 67)
            Btn_Check.TabIndex = 11
            Btn_Check.Text = "&Check"
            Btn_Check.UseVisualStyleBackColor = False
            Btn_Check.XOButtonType = ControlCodeBase.buttonType.Default
            Btn_Check.XOShowBorderOnFocus = False
            Btn_Check.XOValidateAllInput = False
            Btn_Check.XOValidateAllInputTag = Nothing
            ' 
            ' UPwdStrength1
            ' 
            UPwdStrength1.BackColor = Color.Transparent
            UPwdStrength1.Location = New Point(270, 170)
            UPwdStrength1.Margin = New Padding(6, 8, 6, 8)
            UPwdStrength1.Name = "UPwdStrength1"
            UPwdStrength1.Size = New Size(371, 85)
            UPwdStrength1.SLFPasswordStrengthScore = 0
            UPwdStrength1.SLFPasswordStrengthText = Nothing
            UPwdStrength1.TabIndex = 10
            ' 
            ' ULbl7
            ' 
            ULbl7.BackColor = Color.MistyRose
            ULbl7.Location = New Point(10, 112)
            ULbl7.Margin = New Padding(6, 5, 6, 5)
            ULbl7.Name = "ULbl7"
            ULbl7.Size = New Size(250, 39)
            ULbl7.SLFText = "Password"
            ULbl7.SLFTextAdjuster = False
            ULbl7.SLFTextBorder = False
            ULbl7.SLFWarnaLabel = ControlCodeBase.JenisLabel.Red
            ULbl7.TabIndex = 9
            ' 
            ' ULbl6
            ' 
            ULbl6.BackColor = Color.MistyRose
            ULbl6.Location = New Point(10, 47)
            ULbl6.Margin = New Padding(6, 5, 6, 5)
            ULbl6.Name = "ULbl6"
            ULbl6.Size = New Size(250, 39)
            ULbl6.SLFText = "Username"
            ULbl6.SLFTextAdjuster = False
            ULbl6.SLFTextBorder = False
            ULbl6.SLFWarnaLabel = ControlCodeBase.JenisLabel.Red
            ULbl6.TabIndex = 8
            ' 
            ' Txt_Password
            ' 
            Txt_Password.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_Password.Location = New Point(270, 112)
            Txt_Password.Margin = New Padding(4, 5, 4, 5)
            Txt_Password.MaxLength = 255
            Txt_Password.Name = "Txt_Password"
            Txt_Password.Size = New Size(370, 39)
            Txt_Password.TabIndex = 7
            Txt_Password.Tag = "txt"
            Txt_Password.UseSystemPasswordChar = True
            Txt_Password.XOAutoTrim = False
            Txt_Password.XOHarusDiisi = True
            Txt_Password.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_Password.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_Password.XOHightlightSaatFokus = True
            Txt_Password.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_Password.XOIsBlank = True
            Txt_Password.XOIsSearchBox = False
            Txt_Password.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_Password.XOPilihSemuaSaatFokus = True
            Txt_Password.XOPwdLengthMin = 8
            Txt_Password.XOPwdStrengthCalculate = True
            Txt_Password.XOPwdStrengthScore = 0
            Txt_Password.XOPwdStrengthText = Nothing
            Txt_Password.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_Password.XOSearchBoxText = "Type then press Enter"
            Txt_Password.XOSQLText = ""
            Txt_Password.XOTanpaSpasi = False
            Txt_Password.XOValidasiField = Nothing
            ' 
            ' Txt_Username
            ' 
            Txt_Username.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_Username.Location = New Point(270, 47)
            Txt_Username.Margin = New Padding(4, 5, 4, 5)
            Txt_Username.MaxLength = 255
            Txt_Username.Name = "Txt_Username"
            Txt_Username.Size = New Size(370, 39)
            Txt_Username.TabIndex = 6
            Txt_Username.Tag = "txt"
            Txt_Username.XOAutoTrim = True
            Txt_Username.XOHarusDiisi = True
            Txt_Username.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_Username.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_Username.XOHightlightSaatFokus = True
            Txt_Username.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_Username.XOIsBlank = True
            Txt_Username.XOIsSearchBox = False
            Txt_Username.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_Username.XOPilihSemuaSaatFokus = False
            Txt_Username.XOPwdLengthMin = 8
            Txt_Username.XOPwdStrengthCalculate = False
            Txt_Username.XOPwdStrengthScore = 0
            Txt_Username.XOPwdStrengthText = Nothing
            Txt_Username.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_Username.XOSearchBoxText = "Type then press Enter"
            Txt_Username.XOSQLText = ""
            Txt_Username.XOTanpaSpasi = False
            Txt_Username.XOValidasiField = Nothing
            ' 
            ' object_da28eea8_631c_4534_a532_605841b1d2bd
            ' 
            object_da28eea8_631c_4534_a532_605841b1d2bd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            object_da28eea8_631c_4534_a532_605841b1d2bd.BackColor = Color.Transparent
            object_da28eea8_631c_4534_a532_605841b1d2bd.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            object_da28eea8_631c_4534_a532_605841b1d2bd.ForeColor = Color.Black
            object_da28eea8_631c_4534_a532_605841b1d2bd.Location = New Point(12, 0)
            object_da28eea8_631c_4534_a532_605841b1d2bd.Margin = New Padding(4, 0, 4, 0)
            object_da28eea8_631c_4534_a532_605841b1d2bd.Name = "object_da28eea8_631c_4534_a532_605841b1d2bd"
            object_da28eea8_631c_4534_a532_605841b1d2bd.Size = New Size(160, 33)
            object_da28eea8_631c_4534_a532_605841b1d2bd.TabIndex = 1
            object_da28eea8_631c_4534_a532_605841b1d2bd.Text = "Username"
            object_da28eea8_631c_4534_a532_605841b1d2bd.TextAlign = ContentAlignment.MiddleLeft
            object_da28eea8_631c_4534_a532_605841b1d2bd.XOCustomElipsis = False
            ' 
            ' Gbx_Modules
            ' 
            Gbx_Modules.Controls.Add(Dgn1)
            Gbx_Modules.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Gbx_Modules.Location = New Point(17, 70)
            Gbx_Modules.Margin = New Padding(4, 5, 4, 5)
            Gbx_Modules.Name = "Gbx_Modules"
            Gbx_Modules.Padding = New Padding(4, 5, 4, 5)
            Gbx_Modules.Size = New Size(650, 582)
            Gbx_Modules.TabIndex = 1008
            Gbx_Modules.TabStop = False
            Gbx_Modules.Text = "Preparing Necessary Modules"
            Gbx_Modules.Visible = False
            ' 
            ' Dgn1
            ' 
            Dgn1.AllowUserToAddRows = False
            Dgn1.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(237), CByte(223), CByte(164))
            Dgn1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Dgn1.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            Dgn1.BorderStyle = BorderStyle.None
            Dgn1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            Dgn1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            Dgn1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Dgn1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Dgn1.EnableHeadersVisualStyles = False
            Dgn1.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            Dgn1.Location = New Point(9, 105)
            Dgn1.Margin = New Padding(4, 5, 4, 5)
            Dgn1.Name = "Dgn1"
            Dgn1.ReadOnly = True
            Dgn1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            Dgn1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Dgn1.RowHeadersWidth = 62
            Dgn1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Dgn1.RowTemplate.Height = 25
            Dgn1.Size = New Size(633, 467)
            Dgn1.StandardTab = True
            Dgn1.TabIndex = 0
            Dgn1.XOGroupFirstRows = False
            Dgn1.XOGunakanNomorBaris = False
            ' 
            ' FRMfirstguide
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(684, 897)
            ControlBox = False
            FormBorderStyle = FormBorderStyle.FixedToolWindow
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMfirstguide"
            ShowIcon = False
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Gbx_Company.ResumeLayout(False)
            Gbx_Company.PerformLayout()
            Gbx_Login.ResumeLayout(False)
            Gbx_Login.PerformLayout()
            Gbx_Modules.ResumeLayout(False)
            CType(Dgn1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend WithEvents Btn_Process As CMCv.UI.Control.Btn
        Friend WithEvents Lbl_Step As CMCv.UI.Control.lbl
        Friend WithEvents Gbx_Company As CMCv.UI.Control.gbx
        Friend WithEvents Txt_Company As CMCv.UI.Control.txt
        Friend WithEvents Txt_EmployeeName As CMCv.UI.Control.txt
        Friend WithEvents Txt_Position As CMCv.UI.Control.txt
        Friend WithEvents Txt_Department As CMCv.UI.Control.txt
        Friend WithEvents Btn_Close As CMCv.UI.Control.Btn
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents Txt_EmployeeID As CMCv.UI.Control.txt
        Friend WithEvents Gbx_Login As CMCv.UI.Control.gbx
        Friend WithEvents ULbl7 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl6 As CMCv.UI.Control.ULbl
        Friend WithEvents Txt_Password As CMCv.UI.Control.txt
        Friend WithEvents Txt_Username As CMCv.UI.Control.txt
        Friend WithEvents object_da28eea8_631c_4534_a532_605841b1d2bd As CMCv.UI.Control.lbl
        Friend WithEvents UPwdStrength1 As CMCv.UI.Control.UPwdStrength
        Friend WithEvents Gbx_Modules As CMCv.UI.Control.gbx
        Friend WithEvents Btn_Check As CMCv.UI.Control.Btn
        Friend WithEvents Dgn1 As CMCv.UI.Control.dgn
        Friend WithEvents CboEmploymentType As CMCv.UI.Control.cbo
        Friend WithEvents ULblEmploymentType As CMCv.UI.Control.ULbl

    End Class
End Namespace