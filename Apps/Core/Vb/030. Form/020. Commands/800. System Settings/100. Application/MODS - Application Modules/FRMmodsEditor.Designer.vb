Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmodsEditor
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
            BtnSave = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            ChkAddNew = New CMCv.UI.Control.Chk(components)
            Tbctl1 = New CMCv.UI.Control.Tbx(components)
            tpGeneral = New TabPage()
            ULbl5 = New CMCv.UI.Control.ULbl()
            ULbl4 = New CMCv.UI.Control.ULbl()
            ULbl3 = New CMCv.UI.Control.ULbl()
            ULbl2 = New CMCv.UI.Control.ULbl()
            ULbl1 = New CMCv.UI.Control.ULbl()
            ChkSystem = New CMCv.UI.Control.Chk(components)
            TxtCode = New CMCv.UI.Control.txt(components)
            ChkLocked = New CMCv.UI.Control.Chk(components)
            CboGroup = New CMCv.UI.Control.Cbo(components)
            TxtDescription = New CMCv.UI.Control.txt(components)
            TxtName = New CMCv.UI.Control.txt(components)
            TxtID = New CMCv.UI.Control.txt(components)
            tpPermissions = New TabPage()
            GbxAccessBy = New CMCv.UI.Control.gbx(components)
            DgnUserRoles = New CMCv.UI.Control.dgn(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Tbctl1.SuspendLayout()
            tpGeneral.SuspendLayout()
            tpPermissions.SuspendLayout()
            GbxAccessBy.SuspendLayout()
            CType(DgnUserRoles, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(ChkAddNew)
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnSave)
            PnlBottomButton.Location = New Point(0, 585)
            PnlBottomButton.Margin = New Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New Size(947, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnSave, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            PnlBottomButton.Controls.SetChildIndex(ChkAddNew, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 5, 7, 5)
            pnl_.Size = New Size(947, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(Tbctl1)
            SLFPanel.Margin = New Padding(7, 5, 7, 5)
            SLFPanel.Size = New Size(947, 682)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Tbctl1, 0)
            ' 
            ' BtnSave
            ' 
            BtnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnSave.BackColor = Color.LimeGreen
            BtnSave.Cursor = Cursors.Hand
            BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnSave.FlatAppearance.BorderSize = 2
            BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnSave.FlatStyle = FlatStyle.Flat
            BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Location = New Point(583, 13)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(167, 77)
            BtnSave.TabIndex = 6
            BtnSave.Text = "&Save"
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnSave.XOShowBorderOnFocus = False
            BtnSave.XOValidateAllInput = False
            BtnSave.XOValidateAllInputTag = Nothing
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
            BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(760, 13)
            BtnCancel.Margin = New Padding(6, 5, 6, 5)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 8
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' ChkAddNew
            ' 
            ChkAddNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            ChkAddNew.AutoSize = True
            ChkAddNew.BackColor = Color.Transparent
            ChkAddNew.FlatStyle = FlatStyle.Flat
            ChkAddNew.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkAddNew.ForeColor = Color.Tomato
            ChkAddNew.Location = New Point(352, 28)
            ChkAddNew.Margin = New Padding(6, 5, 6, 5)
            ChkAddNew.Name = "ChkAddNew"
            ChkAddNew.Size = New Size(221, 36)
            ChkAddNew.TabIndex = 7
            ChkAddNew.Text = "Add new on Save"
            ChkAddNew.UseVisualStyleBackColor = False
            ' 
            ' Tbctl1
            ' 
            Tbctl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            Tbctl1.Controls.Add(tpGeneral)
            Tbctl1.Controls.Add(tpPermissions)
            Tbctl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Tbctl1.Location = New Point(20, 12)
            Tbctl1.Margin = New Padding(6, 5, 6, 5)
            Tbctl1.Name = "Tbctl1"
            Tbctl1.SelectedIndex = 0
            Tbctl1.Size = New Size(907, 562)
            Tbctl1.TabIndex = 0
            ' 
            ' tpGeneral
            ' 
            tpGeneral.AutoScroll = True
            tpGeneral.Controls.Add(ULbl5)
            tpGeneral.Controls.Add(ULbl4)
            tpGeneral.Controls.Add(ULbl3)
            tpGeneral.Controls.Add(ULbl2)
            tpGeneral.Controls.Add(ULbl1)
            tpGeneral.Controls.Add(ChkSystem)
            tpGeneral.Controls.Add(TxtCode)
            tpGeneral.Controls.Add(ChkLocked)
            tpGeneral.Controls.Add(CboGroup)
            tpGeneral.Controls.Add(TxtDescription)
            tpGeneral.Controls.Add(TxtName)
            tpGeneral.Controls.Add(TxtID)
            tpGeneral.Location = New Point(4, 41)
            tpGeneral.Margin = New Padding(6, 5, 6, 5)
            tpGeneral.Name = "tpGeneral"
            tpGeneral.Padding = New Padding(6, 5, 6, 5)
            tpGeneral.Size = New Size(899, 517)
            tpGeneral.TabIndex = 0
            tpGeneral.Text = "General"
            tpGeneral.UseVisualStyleBackColor = True
            ' 
            ' ULbl5
            ' 
            ULbl5.BackColor = Color.Moccasin
            ULbl5.Location = New Point(11, 288)
            ULbl5.Margin = New Padding(7, 10, 7, 10)
            ULbl5.Name = "ULbl5"
            ULbl5.Size = New Size(250, 55)
            ULbl5.SLFText = "Description"
            ULbl5.SLFTextAdjuster = False
            ULbl5.SLFTextBorder = False
            ULbl5.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl5.TabIndex = 1021
            ' 
            ' ULbl4
            ' 
            ULbl4.BackColor = Color.Moccasin
            ULbl4.Location = New Point(11, 222)
            ULbl4.Margin = New Padding(7, 10, 7, 10)
            ULbl4.Name = "ULbl4"
            ULbl4.Size = New Size(250, 55)
            ULbl4.SLFText = "Module Name"
            ULbl4.SLFTextAdjuster = False
            ULbl4.SLFTextBorder = False
            ULbl4.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl4.TabIndex = 1020
            ' 
            ' ULbl3
            ' 
            ULbl3.BackColor = Color.Moccasin
            ULbl3.Location = New Point(11, 153)
            ULbl3.Margin = New Padding(7, 10, 7, 10)
            ULbl3.Name = "ULbl3"
            ULbl3.Size = New Size(250, 55)
            ULbl3.SLFText = "Code"
            ULbl3.SLFTextAdjuster = False
            ULbl3.SLFTextBorder = False
            ULbl3.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl3.TabIndex = 1019
            ' 
            ' ULbl2
            ' 
            ULbl2.BackColor = Color.Moccasin
            ULbl2.Location = New Point(11, 87)
            ULbl2.Margin = New Padding(7, 10, 7, 10)
            ULbl2.Name = "ULbl2"
            ULbl2.Size = New Size(250, 55)
            ULbl2.SLFText = "Group"
            ULbl2.SLFTextAdjuster = False
            ULbl2.SLFTextBorder = False
            ULbl2.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl2.TabIndex = 1018
            ' 
            ' ULbl1
            ' 
            ULbl1.BackColor = Color.Moccasin
            ULbl1.Location = New Point(11, 20)
            ULbl1.Margin = New Padding(7, 10, 7, 10)
            ULbl1.Name = "ULbl1"
            ULbl1.Size = New Size(250, 55)
            ULbl1.SLFText = "Module ID"
            ULbl1.SLFTextAdjuster = False
            ULbl1.SLFTextBorder = False
            ULbl1.SLFWarnaLabel = ControlCodeBase.EnumColorSelect.Yellow
            ULbl1.TabIndex = 1017
            ' 
            ' ChkSystem
            ' 
            ChkSystem.AutoSize = True
            ChkSystem.BackColor = Color.Transparent
            ChkSystem.FlatStyle = FlatStyle.Flat
            ChkSystem.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkSystem.Location = New Point(270, 355)
            ChkSystem.Margin = New Padding(6, 5, 6, 5)
            ChkSystem.Name = "ChkSystem"
            ChkSystem.Size = New Size(201, 36)
            ChkSystem.TabIndex = 6
            ChkSystem.Text = "System Module"
            ChkSystem.UseVisualStyleBackColor = False
            ' 
            ' TxtCode
            ' 
            TxtCode.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtCode.Location = New Point(273, 153)
            TxtCode.Margin = New Padding(6, 5, 6, 5)
            TxtCode.MaxLength = 255
            TxtCode.Name = "TxtCode"
            TxtCode.Size = New Size(217, 39)
            TxtCode.TabIndex = 3
            TxtCode.Tag = "txt"
            TxtCode.XOAutoTrim = True
            TxtCode.XOIsMandatory = True
            TxtCode.XOMandatoryBgColor = Color.LightPink
            TxtCode.XOMandatoryBgColorDefault = Color.White
            TxtCode.XOHighlightOnFocus = False
            TxtCode.XOHighlightColor = Color.LightYellow
            TxtCode.XOIsBlank = True
            TxtCode.XOIsSearchBox = False
            TxtCode.XOLetterCase = ControlCodeBase.enumLetterCase.UPPERCASE
            TxtCode.XOSelectOnFocus = True
            TxtCode.XOPasswordLengthMin = 8
            TxtCode.XOPasswordStrengthCalc = False
            TxtCode.XOPasswordStrengthScore = 0
            TxtCode.XOPasswordStrengthText = Nothing
            TxtCode.XORestriction = ControlCodeBase.enumRestriction.None
            TxtCode.XOSearchBoxText = "Type then press Enter"
            TxtCode.XOSqlText = ""
            TxtCode.XOIsReplaceEmptyString = True
            TxtCode.XOMandatoryMessage = Nothing
            ' 
            ' ChkLocked
            ' 
            ChkLocked.AutoSize = True
            ChkLocked.BackColor = Color.Transparent
            ChkLocked.FlatStyle = FlatStyle.Flat
            ChkLocked.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            ChkLocked.Location = New Point(270, 415)
            ChkLocked.Margin = New Padding(6, 5, 6, 5)
            ChkLocked.Name = "ChkLocked"
            ChkLocked.Size = New Size(144, 36)
            ChkLocked.TabIndex = 7
            ChkLocked.Text = "Is Locked?"
            ChkLocked.UseVisualStyleBackColor = False
            ' 
            ' CboGroup
            ' 
            CboGroup.DropDownStyle = ComboBoxStyle.DropDownList
            CboGroup.FlatStyle = FlatStyle.Flat
            CboGroup.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            CboGroup.FormattingEnabled = True
            CboGroup.Location = New Point(273, 87)
            CboGroup.Margin = New Padding(6, 5, 6, 5)
            CboGroup.Name = "CboGroup"
            CboGroup.Size = New Size(341, 40)
            CboGroup.TabIndex = 2
            ' 
            ' TxtDescription
            ' 
            TxtDescription.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtDescription.Location = New Point(273, 288)
            TxtDescription.Margin = New Padding(6, 5, 6, 5)
            TxtDescription.MaxLength = 255
            TxtDescription.Name = "TxtDescription"
            TxtDescription.Size = New Size(551, 39)
            TxtDescription.TabIndex = 5
            TxtDescription.Tag = "txt"
            TxtDescription.XOAutoTrim = True
            TxtDescription.XOIsMandatory = True
            TxtDescription.XOMandatoryBgColor = Color.LightPink
            TxtDescription.XOMandatoryBgColorDefault = Color.White
            TxtDescription.XOHighlightOnFocus = False
            TxtDescription.XOHighlightColor = Color.LightYellow
            TxtDescription.XOIsBlank = True
            TxtDescription.XOIsSearchBox = False
            TxtDescription.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
            TxtDescription.XOSelectOnFocus = False
            TxtDescription.XOPasswordLengthMin = 8
            TxtDescription.XOPasswordStrengthCalc = False
            TxtDescription.XOPasswordStrengthScore = 0
            TxtDescription.XOPasswordStrengthText = Nothing
            TxtDescription.XORestriction = ControlCodeBase.enumRestriction.None
            TxtDescription.XOSearchBoxText = "Type then press Enter"
            TxtDescription.XOSqlText = ""
            TxtDescription.XOIsReplaceEmptyString = False
            TxtDescription.XOMandatoryMessage = Nothing
            ' 
            ' TxtName
            ' 
            TxtName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtName.Location = New Point(273, 222)
            TxtName.Margin = New Padding(6, 5, 6, 5)
            TxtName.MaxLength = 255
            TxtName.Name = "TxtName"
            TxtName.Size = New Size(378, 39)
            TxtName.TabIndex = 4
            TxtName.Tag = "txt"
            TxtName.XOAutoTrim = True
            TxtName.XOIsMandatory = True
            TxtName.XOMandatoryBgColor = Color.LightPink
            TxtName.XOMandatoryBgColorDefault = Color.White
            TxtName.XOHighlightOnFocus = False
            TxtName.XOHighlightColor = Color.LightYellow
            TxtName.XOIsBlank = True
            TxtName.XOIsSearchBox = False
            TxtName.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
            TxtName.XOSelectOnFocus = True
            TxtName.XOPasswordLengthMin = 8
            TxtName.XOPasswordStrengthCalc = False
            TxtName.XOPasswordStrengthScore = 0
            TxtName.XOPasswordStrengthText = Nothing
            TxtName.XORestriction = ControlCodeBase.enumRestriction.None
            TxtName.XOSearchBoxText = "Type then press Enter"
            TxtName.XOSqlText = ""
            TxtName.XOIsReplaceEmptyString = False
            TxtName.XOMandatoryMessage = Nothing
            ' 
            ' TxtID
            ' 
            TxtID.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtID.Location = New Point(273, 20)
            TxtID.Margin = New Padding(6, 5, 6, 5)
            TxtID.MaxLength = 255
            TxtID.Name = "TxtID"
            TxtID.ReadOnly = True
            TxtID.Size = New Size(551, 39)
            TxtID.TabIndex = 1
            TxtID.Tag = "txt"
            TxtID.XOAutoTrim = False
            TxtID.XOIsMandatory = False
            TxtID.XOMandatoryBgColor = Color.LightPink
            TxtID.XOMandatoryBgColorDefault = Color.White
            TxtID.XOHighlightOnFocus = False
            TxtID.XOHighlightColor = Color.LightYellow
            TxtID.XOIsBlank = True
            TxtID.XOIsSearchBox = False
            TxtID.XOLetterCase = ControlCodeBase.enumLetterCase.Normal
            TxtID.XOSelectOnFocus = False
            TxtID.XOPasswordLengthMin = 8
            TxtID.XOPasswordStrengthCalc = False
            TxtID.XOPasswordStrengthScore = 0
            TxtID.XOPasswordStrengthText = Nothing
            TxtID.XORestriction = ControlCodeBase.enumRestriction.None
            TxtID.XOSearchBoxText = "Type then press Enter"
            TxtID.XOSqlText = ""
            TxtID.XOIsReplaceEmptyString = False
            TxtID.XOMandatoryMessage = Nothing
            ' 
            ' tpPermissions
            ' 
            tpPermissions.Controls.Add(GbxAccessBy)
            tpPermissions.Location = New Point(4, 41)
            tpPermissions.Margin = New Padding(6, 5, 6, 5)
            tpPermissions.Name = "tpPermissions"
            tpPermissions.Padding = New Padding(6, 5, 6, 5)
            tpPermissions.Size = New Size(899, 517)
            tpPermissions.TabIndex = 1
            tpPermissions.Text = "Permissions"
            tpPermissions.UseVisualStyleBackColor = True
            ' 
            ' GbxAccessBy
            ' 
            GbxAccessBy.Controls.Add(DgnUserRoles)
            GbxAccessBy.Dock = DockStyle.Fill
            GbxAccessBy.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            GbxAccessBy.Location = New Point(6, 5)
            GbxAccessBy.Margin = New Padding(6, 5, 6, 5)
            GbxAccessBy.Name = "GbxAccessBy"
            GbxAccessBy.Padding = New Padding(6, 5, 6, 5)
            GbxAccessBy.Size = New Size(887, 507)
            GbxAccessBy.TabIndex = 0
            GbxAccessBy.TabStop = False
            GbxAccessBy.Text = "User or roles"
            ' 
            ' DgnUserRoles
            ' 
            DgnUserRoles.AllowUserToAddRows = False
            DgnUserRoles.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(234), CByte(188))
            DgnUserRoles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnUserRoles.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnUserRoles.BorderStyle = BorderStyle.None
            DgnUserRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnUserRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnUserRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnUserRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnUserRoles.Dock = DockStyle.Fill
            DgnUserRoles.EnableHeadersVisualStyles = False
            DgnUserRoles.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnUserRoles.Location = New Point(6, 37)
            DgnUserRoles.Margin = New Padding(6, 5, 6, 5)
            DgnUserRoles.Name = "DgnUserRoles"
            DgnUserRoles.ReadOnly = True
            DgnUserRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnUserRoles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnUserRoles.RowHeadersWidth = 62
            DgnUserRoles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnUserRoles.Size = New Size(875, 465)
            DgnUserRoles.StandardTab = True
            DgnUserRoles.TabIndex = 0
            DgnUserRoles.XOGroupFirstRow = False
            DgnUserRoles.XOShowRowNumber = False
            ' 
            ' FRMmodsEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(947, 808)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMmodsEditor"
            PnlBottomButton.ResumeLayout(False)
            PnlBottomButton.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Tbctl1.ResumeLayout(False)
            tpGeneral.ResumeLayout(False)
            tpGeneral.PerformLayout()
            tpPermissions.ResumeLayout(False)
            GbxAccessBy.ResumeLayout(False)
            CType(DgnUserRoles, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents ChkAddNew As CMCv.UI.Control.Chk
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnSave As CMCv.UI.Control.Btn
        Friend WithEvents Tbctl1 As CMCv.UI.Control.Tbx
        Friend WithEvents tpGeneral As TabPage
        Friend WithEvents TxtCode As CMCv.UI.Control.txt
        Friend WithEvents ChkLocked As CMCv.UI.Control.Chk
        Friend WithEvents CboGroup As CMCv.UI.Control.Cbo
        Friend WithEvents TxtDescription As CMCv.UI.Control.txt
        Friend WithEvents TxtName As CMCv.UI.Control.txt
        Friend WithEvents TxtID As CMCv.UI.Control.txt
        Friend WithEvents tpPermissions As TabPage
        Friend WithEvents GbxAccessBy As CMCv.UI.Control.gbx
        Friend WithEvents DgnUserRoles As CMCv.UI.Control.dgn
        Friend WithEvents ChkSystem As CMCv.UI.Control.Chk
        Friend WithEvents ULbl5 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl4 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl3 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl2 As CMCv.UI.Control.ULbl
        Friend WithEvents ULbl1 As CMCv.UI.Control.ULbl
    End Class
End Namespace