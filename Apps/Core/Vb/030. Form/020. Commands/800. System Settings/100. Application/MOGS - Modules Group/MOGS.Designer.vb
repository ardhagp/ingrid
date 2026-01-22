<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOGS
    Inherits CMCv.FRMstandard

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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Pnl1 = New pnl(components)
        BtnClear = New btn(components)
        Lbl1 = New lbl(components)
        TxtFind = New txt(components)
        DgnMOG = New dgn(components)
        modulegroup_id = New DataGridViewTextBoxColumn()
        modulegroup_name = New DataGridViewTextBoxColumn()
        modulegroup_description = New DataGridViewTextBoxColumn()
        modulegroup_order = New DataGridViewTextBoxColumn()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Pnl1.SuspendLayout()
        CType(DgnMOG, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(DgnMOG)
        SLFPanel.Controls.Add(Pnl1)
        ' 
        ' Pnl1
        ' 
        Pnl1.Controls.Add(BtnClear)
        Pnl1.Controls.Add(Lbl1)
        Pnl1.Controls.Add(TxtFind)
        Pnl1.Dock = DockStyle.Top
        Pnl1.Location = New Point(0, 0)
        Pnl1.Margin = New Padding(4, 3, 4, 3)
        Pnl1.Name = "Pnl1"
        Pnl1.Size = New Size(915, 53)
        Pnl1.TabIndex = 802
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.Red
        BtnClear.Cursor = Cursors.Hand
        BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClear.FlatStyle = FlatStyle.Flat
        BtnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClear.ForeColor = Color.White
        BtnClear.Location = New Point(306, 3)
        BtnClear.Margin = New Padding(4, 3, 4, 3)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(117, 46)
        BtnClear.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClear.XOTampilkanFocusBorder = False
        BtnClear.XOValidasiSemuaInput = False
        BtnClear.XOValidasiSemuaInputTag = Nothing
        BtnClear.TabIndex = 801
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' Lbl1
        ' 
        Lbl1.AutoSize = True
        Lbl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl1.Location = New Point(14, 15)
        Lbl1.Margin = New Padding(4, 0, 4, 0)
        Lbl1.Name = "Lbl1"
        Lbl1.Size = New Size(40, 21)
        Lbl1.XOCustomElipsis = False
        Lbl1.TabIndex = 5
        Lbl1.Text = "Find"
        ' 
        ' TxtFind
        ' 
        TxtFind.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtFind.Location = New Point(74, 12)
        TxtFind.Margin = New Padding(4, 3, 4, 3)
        TxtFind.MaxLength = 255
        TxtFind.Name = "TxtFind"
        TxtFind.Size = New Size(224, 29)
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
        TxtFind.TabIndex = 800
        TxtFind.Tag = "txt"
        ' 
        ' DgnMOG
        ' 
        DgnMOG.AllowUserToAddRows = False
        DgnMOG.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(212), CByte(218), CByte(124))
        DgnMOG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnMOG.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnMOG.BorderStyle = BorderStyle.None
        DgnMOG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnMOG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnMOG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnMOG.ColumnHeadersHeight = 43
        DgnMOG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnMOG.Columns.AddRange(New DataGridViewColumn() {modulegroup_id, modulegroup_name, modulegroup_description, modulegroup_order})
        DgnMOG.Dock = DockStyle.Fill
        DgnMOG.EnableHeadersVisualStyles = False
        DgnMOG.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnMOG.Location = New Point(0, 53)
        DgnMOG.Margin = New Padding(4, 3, 4, 3)
        DgnMOG.Name = "DgnMOG"
        DgnMOG.ReadOnly = True
        DgnMOG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnMOG.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnMOG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnMOG.Size = New Size(915, 511)
        DgnMOG.XOGroupFirstRows = False
        DgnMOG.XOGunakanNomorBaris = True
        DgnMOG.StandardTab = True
        DgnMOG.TabIndex = 803
        ' 
        ' modulegroup_id
        ' 
        modulegroup_id.DataPropertyName = "modulegroup_id"
        modulegroup_id.HeaderText = "ID"
        modulegroup_id.Name = "modulegroup_id"
        modulegroup_id.ReadOnly = True
        modulegroup_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' modulegroup_name
        ' 
        modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        modulegroup_name.DataPropertyName = "modulegroup_name"
        modulegroup_name.HeaderText = "Group Name"
        modulegroup_name.Name = "modulegroup_name"
        modulegroup_name.ReadOnly = True
        modulegroup_name.SortMode = DataGridViewColumnSortMode.Programmatic
        modulegroup_name.Width = 94
        ' 
        ' modulegroup_description
        ' 
        modulegroup_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        modulegroup_description.DataPropertyName = "modulegroup_description"
        modulegroup_description.HeaderText = "Description"
        modulegroup_description.Name = "modulegroup_description"
        modulegroup_description.ReadOnly = True
        modulegroup_description.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' modulegroup_order
        ' 
        modulegroup_order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        modulegroup_order.DataPropertyName = "modulegroup_order"
        modulegroup_order.HeaderText = "Order Number"
        modulegroup_order.Name = "modulegroup_order"
        modulegroup_order.ReadOnly = True
        modulegroup_order.SortMode = DataGridViewColumnSortMode.Programmatic
        modulegroup_order.Width = 103
        ' 
        ' MOGS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(6, 3, 6, 3)
        Name = "MOGS"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Pnl1.ResumeLayout(False)
        Pnl1.PerformLayout()
        CType(DgnMOG, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Pnl1 As pnl
    Friend WithEvents BtnClear As btn
    Friend WithEvents Lbl1 As lbl
    Friend WithEvents TxtFind As txt
    Friend WithEvents DgnMOG As dgn
    Friend WithEvents modulegroup_id As DataGridViewTextBoxColumn
    Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
    Friend WithEvents modulegroup_description As DataGridViewTextBoxColumn
    Friend WithEvents modulegroup_order As DataGridViewTextBoxColumn
End Class
