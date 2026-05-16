Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMuacEmployee
        Inherits CMCv.FRMstandardFindFooter

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
            DgnAddinEmployee = New CMCv.UI.Control.dgn(components)
            employee_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            departement_code = New DataGridViewTextBoxColumn()
            position_code = New DataGridViewTextBoxColumn()
            employee_number = New DataGridViewTextBoxColumn()
            employee_fullname = New DataGridViewTextBoxColumn()
            BtnOk = New CMCv.UI.Control.Btn(components)
            BtnCancel = New CMCv.UI.Control.Btn(components)
            PnlBottomButton.SuspendLayout()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnAddinEmployee, ComponentModel.ISupportInitialize).BeginInit()
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
            ' PnlFind
            ' 
            PnlFind.Margin = New Padding(8, 12, 8, 12)
            PnlFind.Size = New Size(1095, 88)
            ' 
            ' BtnClear
            ' 
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClear.FlatAppearance.BorderSize = 2
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            ' 
            ' TxtFind
            ' 
            TxtFind.Margin = New Padding(8, 12, 8, 12)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(8, 12, 8, 12)
            pnl_.Size = New Size(1095, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnAddinEmployee)
            SLFPanel.Margin = New Padding(8, 12, 8, 12)
            SLFPanel.Size = New Size(1095, 795)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(DgnAddinEmployee, 0)
            ' 
            ' DgnAddinEmployee
            ' 
            DgnAddinEmployee.AllowUserToAddRows = False
            DgnAddinEmployee.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(211), CByte(233), CByte(170))
            DgnAddinEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnAddinEmployee.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnAddinEmployee.BorderStyle = BorderStyle.None
            DgnAddinEmployee.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnAddinEmployee.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnAddinEmployee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnAddinEmployee.ColumnHeadersHeight = 43
            DgnAddinEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnAddinEmployee.Columns.AddRange(New DataGridViewColumn() {employee_id, company_code, departement_code, position_code, employee_number, employee_fullname})
            DgnAddinEmployee.Dock = DockStyle.Fill
            DgnAddinEmployee.EnableHeadersVisualStyles = False
            DgnAddinEmployee.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnAddinEmployee.Location = New Point(0, 88)
            DgnAddinEmployee.Margin = New Padding(5, 6, 5, 6)
            DgnAddinEmployee.Name = "DgnAddinEmployee"
            DgnAddinEmployee.ReadOnly = True
            DgnAddinEmployee.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnAddinEmployee.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnAddinEmployee.RowHeadersWidth = 62
            DgnAddinEmployee.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnAddinEmployee.Size = New Size(1095, 611)
            DgnAddinEmployee.StandardTab = True
            DgnAddinEmployee.TabIndex = 1006
            DgnAddinEmployee.XOGroupFirstRows = False
            DgnAddinEmployee.XOGunakanNomorBaris = True
            ' 
            ' employee_id
            ' 
            employee_id.DataPropertyName = "employee_id"
            employee_id.HeaderText = "Emp. ID"
            employee_id.MinimumWidth = 8
            employee_id.Name = "employee_id"
            employee_id.ReadOnly = True
            employee_id.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_id.Visible = False
            employee_id.Width = 150
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
            ' employee_number
            ' 
            employee_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            employee_number.DataPropertyName = "employee_number"
            employee_number.HeaderText = "Employee Number"
            employee_number.MinimumWidth = 8
            employee_number.Name = "employee_number"
            employee_number.ReadOnly = True
            employee_number.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_number.Width = 174
            ' 
            ' employee_fullname
            ' 
            employee_fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            employee_fullname.DataPropertyName = "employee_fullname"
            employee_fullname.HeaderText = "Employee Full Name"
            employee_fullname.MinimumWidth = 8
            employee_fullname.Name = "employee_fullname"
            employee_fullname.ReadOnly = True
            employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' BtnOk
            ' 
            BtnOk.BackColor = Color.LimeGreen
            BtnOk.Cursor = Cursors.Hand
            BtnOk.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnOk.FlatAppearance.BorderSize = 2
            BtnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnOk.FlatStyle = FlatStyle.Flat
            BtnOk.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnOk.ForeColor = Color.White
            BtnOk.Location = New Point(732, 12)
            BtnOk.Margin = New Padding(5, 6, 5, 6)
            BtnOk.Name = "BtnOk"
            BtnOk.Size = New Size(167, 77)
            BtnOk.TabIndex = 1
            BtnOk.Text = "&Ok"
            BtnOk.UseVisualStyleBackColor = False
            BtnOk.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnOk.XOShowBorderOnFocus = False
            BtnOk.XOValidateAllInput = False
            BtnOk.XOValidateAllInputTag = Nothing
            ' 
            ' BtnCancel
            ' 
            BtnCancel.BackColor = Color.Red
            BtnCancel.Cursor = Cursors.Hand
            BtnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnCancel.FlatAppearance.BorderSize = 2
            BtnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnCancel.FlatStyle = FlatStyle.Flat
            BtnCancel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCancel.ForeColor = Color.White
            BtnCancel.Location = New Point(908, 12)
            BtnCancel.Margin = New Padding(5, 6, 5, 6)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(167, 77)
            BtnCancel.TabIndex = 2
            BtnCancel.Text = "&Cancel"
            BtnCancel.UseVisualStyleBackColor = False
            BtnCancel.XOButtonType = ControlCodeBase.buttonType.No
            BtnCancel.XOShowBorderOnFocus = False
            BtnCancel.XOValidateAllInput = False
            BtnCancel.XOValidateAllInputTag = Nothing
            ' 
            ' FRMuacEmployee
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1095, 921)
            KeyPreview = True
            Margin = New Padding(37, 85, 37, 85)
            Name = "FRMuacEmployee"
            PnlBottomButton.ResumeLayout(False)
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnAddinEmployee, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Friend WithEvents BtnCancel As CMCv.UI.Control.Btn
        Friend WithEvents BtnOk As CMCv.UI.Control.Btn
        Friend WithEvents DgnAddinEmployee As CMCv.UI.Control.dgn
        Friend WithEvents employee_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents departement_code As DataGridViewTextBoxColumn
        Friend WithEvents position_code As DataGridViewTextBoxColumn
        Friend WithEvents employee_number As DataGridViewTextBoxColumn
        Friend WithEvents employee_fullname As DataGridViewTextBoxColumn
    End Class
End Namespace