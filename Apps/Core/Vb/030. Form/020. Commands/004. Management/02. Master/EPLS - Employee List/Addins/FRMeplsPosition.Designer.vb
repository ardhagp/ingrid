Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMeplsPosition
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
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Pnl1 = New pnl(components)
            BtnClear = New btn(components)
            Lbl1 = New lbl(components)
            TxtFind = New txt(components)
            DgnAddinPosition = New dgn(components)
            position_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            company_name = New DataGridViewTextBoxColumn()
            departement_code = New DataGridViewTextBoxColumn()
            departement_name = New DataGridViewTextBoxColumn()
            position_code = New DataGridViewTextBoxColumn()
            position_name = New DataGridViewTextBoxColumn()
            BtnOk = New btn(components)
            BtnCancel = New btn(components)
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
            PnlBottomButton.Location = New Point(0, 699)
            PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
            PnlBottomButton.Size = New Size(1095, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnOk, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnCancel, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(8, 12, 8, 12)
            pnl_.Size = New Size(1095, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnAddinPosition)
            SLFPanel.Controls.Add(Pnl1)
            SLFPanel.Margin = New Padding(8, 12, 8, 12)
            SLFPanel.Size = New Size(1095, 795)
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
            BtnClear.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnClear.ForeColor = Color.White
            BtnClear.Location = New Point(437, 4)
            BtnClear.Margin = New Padding(5, 6, 5, 6)
            BtnClear.Name = "BtnClear"
            BtnClear.Size = New Size(167, 77)
            BtnClear.TabIndex = 6
            BtnClear.Text = "Clear"
            BtnClear.UseVisualStyleBackColor = False
            BtnClear.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnClear.XOTampilkanFocusBorder = False
            BtnClear.XOValidasiSemuaInput = False
            BtnClear.XOValidasiSemuaInputTag = Nothing
            ' 
            ' Lbl1
            ' 
            Lbl1.AutoSize = True
            Lbl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            TxtFind.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtFind.Location = New Point(105, 19)
            TxtFind.Margin = New Padding(5, 6, 5, 6)
            TxtFind.MaxLength = 255
            TxtFind.Name = "TxtFind"
            TxtFind.Size = New Size(319, 39)
            TxtFind.TabIndex = 4
            TxtFind.Tag = "txt"
            TxtFind.XOAutoTrim = False
            TxtFind.XOHarusDiisi = False
            TxtFind.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtFind.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtFind.XOHightlightSaatFokus = False
            TxtFind.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtFind.XOIsBlank = True
            TxtFind.XOIsSearchBox = False
            TxtFind.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            TxtFind.XOPilihSemuaSaatFokus = False
            TxtFind.XOPwdLengthMin = 8
            TxtFind.XOPwdStrengthCalculate = False
            TxtFind.XOPwdStrengthScore = 0
            TxtFind.XOPwdStrengthText = Nothing
            TxtFind.XORestriction = ControlCodeBase.enuRestriction.None
            TxtFind.XOSearchBoxText = "Type then press Enter"
            TxtFind.XOSQLText = Nothing
            TxtFind.XOTanpaSpasi = False
            TxtFind.XOValidasiField = Nothing
            ' 
            ' DgnAddinPosition
            ' 
            DgnAddinPosition.AllowUserToAddRows = False
            DgnAddinPosition.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(136))
            DgnAddinPosition.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnAddinPosition.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnAddinPosition.BorderStyle = BorderStyle.None
            DgnAddinPosition.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnAddinPosition.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnAddinPosition.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnAddinPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DgnAddinPosition.Columns.AddRange(New DataGridViewColumn() {position_id, company_code, company_name, departement_code, departement_name, position_code, position_name})
            DgnAddinPosition.Dock = DockStyle.Fill
            DgnAddinPosition.EnableHeadersVisualStyles = False
            DgnAddinPosition.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnAddinPosition.Location = New Point(0, 88)
            DgnAddinPosition.Margin = New Padding(5, 6, 5, 6)
            DgnAddinPosition.Name = "DgnAddinPosition"
            DgnAddinPosition.ReadOnly = True
            DgnAddinPosition.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnAddinPosition.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnAddinPosition.RowHeadersWidth = 62
            DgnAddinPosition.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnAddinPosition.Size = New Size(1095, 611)
            DgnAddinPosition.StandardTab = True
            DgnAddinPosition.TabIndex = 1005
            DgnAddinPosition.XOGroupFirstRows = False
            DgnAddinPosition.XOGunakanNomorBaris = True
            ' 
            ' position_id
            ' 
            position_id.DataPropertyName = "position_id"
            position_id.Frozen = True
            position_id.HeaderText = "ID"
            position_id.MinimumWidth = 8
            position_id.Name = "position_id"
            position_id.ReadOnly = True
            position_id.SortMode = DataGridViewColumnSortMode.Programmatic
            position_id.Width = 75
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "Company Code"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 151
            ' 
            ' company_name
            ' 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            company_name.DataPropertyName = "company_name"
            company_name.HeaderText = "Company Name"
            company_name.MinimumWidth = 8
            company_name.Name = "company_name"
            company_name.ReadOnly = True
            company_name.SortMode = DataGridViewColumnSortMode.Programmatic
            company_name.Width = 156
            ' 
            ' departement_code
            ' 
            departement_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            departement_code.DataPropertyName = "departement_code"
            departement_code.HeaderText = "Dept. Code"
            departement_code.MinimumWidth = 8
            departement_code.Name = "departement_code"
            departement_code.ReadOnly = True
            departement_code.SortMode = DataGridViewColumnSortMode.Programmatic
            departement_code.Width = 87
            ' 
            ' departement_name
            ' 
            departement_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            departement_name.DataPropertyName = "departement_name"
            departement_name.HeaderText = "Dept. Name"
            departement_name.MinimumWidth = 8
            departement_name.Name = "departement_name"
            departement_name.ReadOnly = True
            departement_name.SortMode = DataGridViewColumnSortMode.Programmatic
            departement_name.Width = 129
            ' 
            ' position_code
            ' 
            position_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            position_code.DataPropertyName = "position_code"
            position_code.HeaderText = "Position Code"
            position_code.MinimumWidth = 8
            position_code.Name = "position_code"
            position_code.ReadOnly = True
            position_code.SortMode = DataGridViewColumnSortMode.Programmatic
            position_code.Width = 142
            ' 
            ' position_name
            ' 
            position_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            position_name.DataPropertyName = "position_name"
            position_name.HeaderText = "Postition Name"
            position_name.MinimumWidth = 8
            position_name.Name = "position_name"
            position_name.ReadOnly = True
            position_name.SortMode = DataGridViewColumnSortMode.Programmatic
            position_name.Width = 154
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
            BtnOk.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnOk.ForeColor = Color.White
            BtnOk.Location = New Point(747, 12)
            BtnOk.Margin = New Padding(5, 6, 5, 6)
            BtnOk.Name = "BtnOk"
            BtnOk.Size = New Size(167, 77)
            BtnOk.TabIndex = 1
            BtnOk.Text = "&Ok"
            BtnOk.UseVisualStyleBackColor = False
            BtnOk.XOJenisTombol = ControlCodeBase.enuJenisTombol.Yes
            BtnOk.XOTampilkanFocusBorder = False
            BtnOk.XOValidasiSemuaInput = False
            BtnOk.XOValidasiSemuaInputTag = Nothing
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
            BtnCancel.Location = New Point(924, 12)
            BtnCancel.Margin = New Padding(5, 6, 5, 6)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 2
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            BtnCancel.XOTampilkanFocusBorder = False
            BtnCancel.XOValidasiSemuaInput = False
            BtnCancel.XOValidasiSemuaInputTag = Nothing
            ' 
            ' FRMeplsPosition
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1095, 921)
            KeyPreview = True
            Margin = New Padding(22, 44, 22, 44)
            Name = "FRMeplsPosition"
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
        Friend WithEvents Pnl1 As CMCv.pnl
        Friend WithEvents BtnClear As CMCv.btn
        Friend WithEvents Lbl1 As CMCv.lbl
        Friend WithEvents TxtFind As CMCv.txt
        Friend WithEvents DgnAddinPosition As CMCv.dgn
        Friend WithEvents BtnCancel As CMCv.btn
        Friend WithEvents BtnOk As CMCv.btn
        Friend WithEvents position_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents company_name As DataGridViewTextBoxColumn
        Friend WithEvents departement_code As DataGridViewTextBoxColumn
        Friend WithEvents departement_name As DataGridViewTextBoxColumn
        Friend WithEvents position_code As DataGridViewTextBoxColumn
        Friend WithEvents position_name As DataGridViewTextBoxColumn
    End Class
End Namespace