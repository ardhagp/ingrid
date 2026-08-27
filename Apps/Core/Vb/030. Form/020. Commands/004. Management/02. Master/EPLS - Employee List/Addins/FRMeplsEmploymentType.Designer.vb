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
            DgnAddinEmploymentType = New CMCv.UI.Control.Dgn(components)
            employmenttype_id = New DataGridViewTextBoxColumn()
            employmenttype_code = New DataGridViewTextBoxColumn()
            employmenttype_name = New DataGridViewTextBoxColumn()
            employmenttype_description = New DataGridViewTextBoxColumn()
            BtnOk = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Pnl1.SuspendLayout()
            CType(DgnAddinEmploymentType, ComponentModel.ISupportInitialize).BeginInit()
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
            SLFPanel.Controls.Add(DgnAddinEmploymentType)
            SLFPanel.Controls.Add(Pnl1)
            SLFPanel.Size = New Size(1095, 789)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(Pnl1, 0)
            SLFPanel.Controls.SetChildIndex(DgnAddinEmploymentType, 0)
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
            BtnClear.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
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
            Lbl1.Font = New Font("Segoe UI", 12.0F)
            Lbl1.ForeColor = Color.White
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
            TxtFind.Font = New Font("Segoe UI", 12.0F)
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
            ' DgnAddinEmploymentType
            ' 
            DgnAddinEmploymentType.AllowUserToAddRows = False
            DgnAddinEmploymentType.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(223), CByte(246), CByte(180))
            DgnAddinEmploymentType.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnAddinEmploymentType.BackgroundColor = Color.FromArgb(CByte(11), CByte(28), CByte(45))
            DgnAddinEmploymentType.BorderStyle = BorderStyle.None
            DgnAddinEmploymentType.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnAddinEmploymentType.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8.0F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnAddinEmploymentType.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnAddinEmploymentType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnAddinEmploymentType.Columns.AddRange(New DataGridViewColumn() {employmenttype_id, employmenttype_code, employmenttype_name, employmenttype_description})
            DgnAddinEmploymentType.Dock = DockStyle.Fill
            DgnAddinEmploymentType.EnableHeadersVisualStyles = False
            DgnAddinEmploymentType.Font = New Font("Verdana", 8.0F)
            DgnAddinEmploymentType.Location = New Point(0, 88)
            DgnAddinEmploymentType.Margin = New Padding(5, 6, 5, 6)
            DgnAddinEmploymentType.Name = "DgnAddinEmploymentType"
            DgnAddinEmploymentType.ReadOnly = True
            DgnAddinEmploymentType.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8.0F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnAddinEmploymentType.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnAddinEmploymentType.RowHeadersWidth = 62
            DgnAddinEmploymentType.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnAddinEmploymentType.Size = New Size(1095, 605)
            DgnAddinEmploymentType.StandardTab = True
            DgnAddinEmploymentType.TabIndex = 1005
            DgnAddinEmploymentType.XOIsGroupFirstRow = False
            DgnAddinEmploymentType.XOIsShowRowNumber = True
            ' 
            ' employmenttype_id
            ' 
            employmenttype_id.DataPropertyName = "employmenttype_id"
            employmenttype_id.Frozen = True
            employmenttype_id.HeaderText = "ID"
            employmenttype_id.MinimumWidth = 8
            employmenttype_id.Name = "employmenttype_id"
            employmenttype_id.ReadOnly = True
            employmenttype_id.Visible = False
            employmenttype_id.Width = 75
            ' 
            ' employmenttype_code
            ' 
            employmenttype_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            employmenttype_code.DataPropertyName = "employmenttype_code"
            employmenttype_code.HeaderText = "EP.TYPE CODE"
            employmenttype_code.MinimumWidth = 8
            employmenttype_code.Name = "employmenttype_code"
            employmenttype_code.ReadOnly = True
            employmenttype_code.Width = 146
            ' 
            ' employmenttype_name
            ' 
            employmenttype_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            employmenttype_name.DataPropertyName = "employmenttype_name"
            employmenttype_name.HeaderText = "EP.TYPE NAME"
            employmenttype_name.MinimumWidth = 8
            employmenttype_name.Name = "employmenttype_name"
            employmenttype_name.ReadOnly = True
            employmenttype_name.Width = 146
            ' 
            ' employmenttype_description
            ' 
            employmenttype_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            employmenttype_description.DataPropertyName = "employmenttype_description"
            employmenttype_description.HeaderText = "EP.TYPE DESCRIPTION"
            employmenttype_description.MinimumWidth = 8
            employmenttype_description.Name = "employmenttype_description"
            employmenttype_description.ReadOnly = True
            employmenttype_description.SortMode = DataGridViewColumnSortMode.NotSortable
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
            CType(DgnAddinEmploymentType, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents Pnl1 As CMCv.UI.Control.Pnl
        Friend WithEvents BtnClear As CMCv.UI.Control.Btn
        Friend WithEvents Lbl1 As CMCv.UI.Control.Lbl
        Friend WithEvents TxtFind As CMCv.UI.Control.Txt
        Friend WithEvents DgnAddinEmploymentType As CMCv.UI.Control.Dgn
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnOk As CMCv.UI.Control.Btn
        Friend WithEvents employmenttype_id As DataGridViewTextBoxColumn
        Friend WithEvents employmenttype_code As DataGridViewTextBoxColumn
        Friend WithEvents employmenttype_name As DataGridViewTextBoxColumn
        Friend WithEvents employmenttype_description As DataGridViewTextBoxColumn
    End Class
End Namespace