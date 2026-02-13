Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdraa
        Inherits CMCv.frmStandard

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
            DgnArea = New dgn(components)
            areaaffected_id = New DataGridViewTextBoxColumn()
            areaaffected_order = New DataGridViewTextBoxColumn()
            areaaffected_name = New DataGridViewTextBoxColumn()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Pnl1.SuspendLayout()
            CType(DgnArea, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnArea)
            SLFPanel.Controls.Add(Pnl1)
            SLFPanel.Size = New Size(1307, 952)
            ' 
            ' Pnl1
            ' 
            Pnl1.Controls.Add(BtnClear)
            Pnl1.Controls.Add(Lbl1)
            Pnl1.Controls.Add(TxtFind)
            Pnl1.Dock = DockStyle.Top
            Pnl1.Location = New Point(0, 0)
            Pnl1.Margin = New Padding(6, 5, 6, 5)
            Pnl1.Name = "Pnl1"
            Pnl1.Size = New Size(1307, 88)
            Pnl1.TabIndex = 801
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
            BtnClear.Location = New Point(437, 5)
            BtnClear.Margin = New Padding(6, 5, 6, 5)
            BtnClear.Name = "BtnClear"
            BtnClear.Size = New Size(167, 77)
            BtnClear.TabIndex = 801
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
            Lbl1.Margin = New Padding(6, 0, 6, 0)
            Lbl1.Name = "Lbl1"
            Lbl1.Size = New Size(60, 32)
            Lbl1.TabIndex = 5
            Lbl1.Text = "Find"
            Lbl1.XOCustomElipsis = False
            ' 
            ' TxtFind
            ' 
            TxtFind.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TxtFind.Location = New Point(106, 20)
            TxtFind.Margin = New Padding(6, 5, 6, 5)
            TxtFind.MaxLength = 255
            TxtFind.Name = "TxtFind"
            TxtFind.Size = New Size(318, 39)
            TxtFind.TabIndex = 800
            TxtFind.Tag = "txt"
            TxtFind.XOAutoTrim = False
            TxtFind.XOHarusDiisi = False
            TxtFind.XOHarusDiisiWarnaLatar = Color.LightPink
            TxtFind.XOHarusDiisiWarnaLatarDefault = Color.White
            TxtFind.XOHightlightSaatFokus = False
            TxtFind.XOHightlightSaatFokusWarna = Color.LightYellow
            TxtFind.XOIsBlank = True
            TxtFind.XOIsSearchBox = True
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
            ' DgnArea
            ' 
            DgnArea.AllowUserToAddRows = False
            DgnArea.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(236), CByte(246), CByte(123))
            DgnArea.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnArea.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnArea.BorderStyle = BorderStyle.None
            DgnArea.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnArea.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnArea.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnArea.ColumnHeadersHeight = 43
            DgnArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnArea.Columns.AddRange(New DataGridViewColumn() {areaaffected_id, areaaffected_order, areaaffected_name})
            DgnArea.Dock = DockStyle.Fill
            DgnArea.EnableHeadersVisualStyles = False
            DgnArea.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnArea.Location = New Point(0, 88)
            DgnArea.Margin = New Padding(6, 5, 6, 5)
            DgnArea.Name = "DgnArea"
            DgnArea.ReadOnly = True
            DgnArea.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnArea.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnArea.RowHeadersWidth = 62
            DgnArea.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnArea.Size = New Size(1307, 864)
            DgnArea.StandardTab = True
            DgnArea.TabIndex = 803
            DgnArea.XOGroupFirstRows = False
            DgnArea.XOGunakanNomorBaris = True
            ' 
            ' areaaffected_id
            ' 
            areaaffected_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            areaaffected_id.DataPropertyName = "areaaffected_id"
            areaaffected_id.HeaderText = "ID"
            areaaffected_id.MinimumWidth = 8
            areaaffected_id.Name = "areaaffected_id"
            areaaffected_id.ReadOnly = True
            areaaffected_id.Width = 61
            ' 
            ' areaaffected_order
            ' 
            areaaffected_order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            areaaffected_order.DataPropertyName = "areaaffected_order"
            areaaffected_order.HeaderText = "Order"
            areaaffected_order.MinimumWidth = 8
            areaaffected_order.Name = "areaaffected_order"
            areaaffected_order.ReadOnly = True
            areaaffected_order.Width = 87
            ' 
            ' areaaffected_name
            ' 
            areaaffected_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            areaaffected_name.DataPropertyName = "areaaffected_name"
            areaaffected_name.HeaderText = "Area Name"
            areaaffected_name.MinimumWidth = 8
            areaaffected_name.Name = "areaaffected_name"
            areaaffected_name.ReadOnly = True
            ' 
            ' FRMdraa
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(9, 5, 9, 5)
            Name = "FRMdraa"
            Text = "Nama Form"
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Pnl1.ResumeLayout(False)
            Pnl1.PerformLayout()
            CType(DgnArea, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents Pnl1 As pnl
        Friend WithEvents BtnClear As btn
        Friend WithEvents Lbl1 As lbl
        Friend WithEvents TxtFind As txt
        Friend WithEvents DgnArea As dgn
        Friend WithEvents areaaffected_id As DataGridViewTextBoxColumn
        Friend WithEvents areaaffected_order As DataGridViewTextBoxColumn
        Friend WithEvents areaaffected_name As DataGridViewTextBoxColumn
    End Class
End Namespace