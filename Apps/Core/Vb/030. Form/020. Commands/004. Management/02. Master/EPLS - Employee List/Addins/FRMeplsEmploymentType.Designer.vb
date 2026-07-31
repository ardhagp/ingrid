Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMeplsEmploymentType
        Inherits CMCv.UI.Canvas.FRMstandardFooter

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
            Pnl1 = New CMCv.UI.Control.Pnl(components)
            BtnClear = New CMCv.UI.Control.Btn(components)
            Lbl1 = New CMCv.UI.Control.Lbl(components)
            TxtFind = New CMCv.UI.Control.Txt(components)
            DgnAddinPosition = New CMCv.UI.Control.Dgn(components)
            position_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            company_name = New DataGridViewTextBoxColumn()
            department_code = New DataGridViewTextBoxColumn()
            department_name = New DataGridViewTextBoxColumn()
            position_code = New DataGridViewTextBoxColumn()
            position_name = New DataGridViewTextBoxColumn()
            BtnOk = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Pnl1.SuspendLayout()
            CType(DgnAddinPosition, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnCancel)
            PnlBottomButton.Controls.Add(BtnOk)
            PnlBottomButton.Location = New Point(0, 693)
            PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
            PnlBottomButton.Size = New Size(1095, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnOk, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Size = New Size(1095, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnAddinPosition)
            SLFPanel.Controls.Add(Pnl1)
            SLFPanel.Size = New Size(1095, 789)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Pnl1, 0)
            SLFPanel.Controls.SetChildIndex(DgnAddinPosition, 0)
            ' 
            ' Pnl1
            ' 
            Pnl1.Controls.Add(BtnClear)
            Pnl1.Controls.Add(Lbl1)
            Pnl1.Controls.Add(TxtFind)
            Pnl1.Dock = DockStyle.Top
            Pnl1.Location = New Point(0, 0)
            Pnl1.Margin = New Padding(5, 6, 5, 6)
            Pnl1.Name = "Pnl1"
            Pnl1.Size = New Size(1095, 88)
            Pnl1.TabIndex = 1004
            ' 
            ' BtnClear
            ' 
            BtnClear.BackColor = Color.Red
            BtnClear.Cursor = Cursors.Hand
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClear.FlatAppearance.BorderSize = 2
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClear.FlatStyle = FlatStyle.Flat
            BtnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnClear.ForeColor = Color.White
            BtnClear.Location = New Point(437, 4)
            BtnClear.Margin = New Padding(5, 6, 5, 6)
            BtnClear.Name = "BtnClear"
            BtnClear.Size = New Size(167, 77)
            BtnClear.TabIndex = 6
            BtnClear.Text = "Clear"
            BtnClear.UseVisualStyleBackColor = False
            BtnClear.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnClear.XOShowBorderOnFocus = False
            BtnClear.XOValidateAllInput = False
            BtnClear.XOValidateAllInputTag = Nothing
            ' 
            ' Lbl1
            ' 
            Lbl1.AutoSize = True
            Lbl1.Font = New Font("Segoe UI", 12F)
            Lbl1.Location = New Point(20, 25)
            Lbl1.Margin = New Padding(5, 0, 5, 0)
            Lbl1.Name = "Lbl1"
            Lbl1.Size = New Size(60, 32)
            Lbl1.TabIndex = 5
            Lbl1.Text = "Find"
            Lbl1.XOCustomElipsis = False
            ' 
            ' TxtFind
            ' 
            TxtFind.Font = New Font("Segoe UI", 12F)
            TxtFind.Location = New Point(105, 19)
            TxtFind.Margin = New Padding(5, 6, 5, 6)
            TxtFind.MaxLength = 255
            TxtFind.Name = "TxtFind"
            TxtFind.Size = New Size(319, 39)
            TxtFind.TabIndex = 4
            TxtFind.Tag = "txt"
            TxtFind.XOAutoTrim = False
            TxtFind.XOHighlightColor = Color.LightYellow
            TxtFind.XOHighlightOnFocus = False
            TxtFind.XOIsBlank = True
            TxtFind.XOIsMandatory = False
            TxtFind.XOIsPlaceholder = False
            TxtFind.XOIsReplaceEmptyString = False
            TxtFind.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtFind.XOMandatoryBgColor = Color.LightPink
            TxtFind.XOMandatoryBgColorDefault = Color.White
            TxtFind.XOMandatoryMessage = Nothing
            TxtFind.XOPasswordLengthMin = 8
            TxtFind.XOPasswordStrengthCalc = False
            TxtFind.XOPasswordStrengthScore = 0
            TxtFind.XOPasswordStrengthText = Nothing
            TxtFind.XOPlaceholderText = "Type then press Enter"
            TxtFind.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtFind.XOSelectOnFocus = False
            TxtFind.XOSqlText = Nothing
            ' 
            ' DgnAddinPosition
            ' 
            DgnAddinPosition.AllowUserToAddRows = False
            DgnAddinPosition.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(226), CByte(219), CByte(155))
            DgnAddinPosition.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnAddinPosition.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnAddinPosition.BorderStyle = BorderStyle.None
            DgnAddinPosition.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnAddinPosition.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnAddinPosition.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnAddinPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnAddinPosition.Columns.AddRange(New DataGridViewColumn() {position_id, company_code, company_name, department_code, department_name, position_code, position_name})
            DgnAddinPosition.Dock = DockStyle.Fill
            DgnAddinPosition.EnableHeadersVisualStyles = False
            DgnAddinPosition.Font = New Font("Verdana", 8F)
            DgnAddinPosition.Location = New Point(0, 88)
            DgnAddinPosition.Margin = New Padding(5, 6, 5, 6)
            DgnAddinPosition.Name = "DgnAddinPosition"
            DgnAddinPosition.ReadOnly = True
            DgnAddinPosition.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnAddinPosition.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnAddinPosition.RowHeadersWidth = 62
            DgnAddinPosition.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnAddinPosition.Size = New Size(1095, 605)
            DgnAddinPosition.StandardTab = True
            DgnAddinPosition.TabIndex = 1005
            DgnAddinPosition.XOIsGroupFirstRow = False
            DgnAddinPosition.XOIsShowRowNumber = True
            ' 
            ' position_id
            ' 
            position_id.DataPropertyName = "position_id"
            position_id.Frozen = True
            position_id.HeaderText = "ID"
            position_id.MinimumWidth = 8
            position_id.Name = "position_id"
            position_id.ReadOnly = True
            position_id.Visible = False
            position_id.Width = 75
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "COMP. CODE"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 133
            ' 
            ' company_name
            ' 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            company_name.DataPropertyName = "company_name"
            company_name.HeaderText = "COMP."
            company_name.MinimumWidth = 8
            company_name.Name = "company_name"
            company_name.ReadOnly = True
            company_name.Visible = False
            company_name.Width = 150
            ' 
            ' department_code
            ' 
            department_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            department_code.DataPropertyName = "department_code"
            department_code.HeaderText = "DEPT. CODE"
            department_code.MinimumWidth = 8
            department_code.Name = "department_code"
            department_code.ReadOnly = True
            department_code.Width = 88
            ' 
            ' department_name
            ' 
            department_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            department_name.DataPropertyName = "department_name"
            department_name.HeaderText = "DEPT."
            department_name.MinimumWidth = 8
            department_name.Name = "department_name"
            department_name.ReadOnly = True
            department_name.Visible = False
            department_name.Width = 150
            ' 
            ' position_code
            ' 
            position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            position_code.DataPropertyName = "position_code"
            position_code.HeaderText = "POSITION CODE"
            position_code.MinimumWidth = 8
            position_code.Name = "position_code"
            position_code.ReadOnly = True
            position_code.Width = 161
            ' 
            ' position_name
            ' 
            position_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            position_name.DataPropertyName = "position_name"
            position_name.HeaderText = "POSITION"
            position_name.MinimumWidth = 8
            position_name.Name = "position_name"
            position_name.ReadOnly = True
            ' 
            ' BtnOk
            ' 
            BtnOk.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnOk.BackColor = Color.LimeGreen
            BtnOk.Cursor = Cursors.Hand
            BtnOk.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnOk.FlatAppearance.BorderSize = 2
            BtnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnOk.FlatStyle = FlatStyle.Flat
            BtnOk.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnOk.ForeColor = Color.White
            BtnOk.Location = New Point(747, 12)
            BtnOk.Margin = New Padding(5, 6, 5, 6)
            BtnOk.Name = "BtnOk"
            BtnOk.Size = New Size(167, 77)
            BtnOk.TabIndex = 1
            BtnOk.Text = "&Ok"
            BtnOk.UseVisualStyleBackColor = False
            BtnOk.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.Yes
            BtnOk.XOShowBorderOnFocus = False
            BtnOk.XOValidateAllInput = False
            BtnOk.XOValidateAllInputTag = Nothing
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
            BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(924, 12)
            BtnCancel.Margin = New Padding(5, 6, 5, 6)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 2
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' FRMeplsEmploymentType
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1095, 921)
            Margin = New Padding(22, 44, 22, 44)
            Name = "FRMeplsEmploymentType"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Pnl1.ResumeLayout(False)
            Pnl1.PerformLayout()
            CType(DgnAddinPosition, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents Pnl1 As CMCv.UI.Control.Pnl
        Friend WithEvents BtnClear As CMCv.UI.Control.Btn
        Friend WithEvents Lbl1 As CMCv.UI.Control.Lbl
        Friend WithEvents TxtFind As CMCv.UI.Control.Txt
        Friend WithEvents DgnAddinPosition As CMCv.UI.Control.Dgn
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnOk As CMCv.UI.Control.Btn
        Friend WithEvents position_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents company_name As DataGridViewTextBoxColumn
        Friend WithEvents department_code As DataGridViewTextBoxColumn
        Friend WithEvents department_name As DataGridViewTextBoxColumn
        Friend WithEvents position_code As DataGridViewTextBoxColumn
        Friend WithEvents position_name As DataGridViewTextBoxColumn
    End Class
End Namespace