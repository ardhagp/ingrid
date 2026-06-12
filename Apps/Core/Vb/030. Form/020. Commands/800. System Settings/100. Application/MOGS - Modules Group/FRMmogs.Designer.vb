Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMmogs
        Inherits CMCv.UI.Canvas.FRMstandard

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
            Pnl1 = New CMCv.UI.Control.Pnl(components)
            BtnClear = New CMCv.UI.Control.Btn(components)
            Lbl1 = New CMCv.UI.Control.Lbl(components)
            TxtFind = New CMCv.UI.Control.Txt(components)
            DgnMOG = New CMCv.UI.Control.Dgn(components)
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
            BtnClear.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnClear.ForeColor = Color.White
            BtnClear.Location = New Point(437, 5)
            BtnClear.Margin = New Padding(6, 5, 6, 5)
            BtnClear.Name = "BtnClear"
            BtnClear.Size = New Size(167, 77)
            BtnClear.TabIndex = 801
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
            TxtFind.XOIsMandatory = False
            TxtFind.XOMandatoryBgColor = Color.LightPink
            TxtFind.XOMandatoryBgColorDefault = Color.White
            TxtFind.XOHighlightOnFocus = False
            TxtFind.XOHighlightColor = Color.LightYellow
            TxtFind.XOIsBlank = True
            TxtFind.XOIsPlaceholder = False
            TxtFind.XOLetterCase = CMCv.UI.Control.ControlCodeBase.EnumLetterCase.Normal
            TxtFind.XOSelectOnFocus = False
            TxtFind.XOPasswordLengthMin = 8
            TxtFind.XOPasswordStrengthCalc = False
            TxtFind.XOPasswordStrengthScore = 0
            TxtFind.XOPasswordStrengthText = Nothing
            TxtFind.XORestriction = CMCv.UI.Control.ControlCodeBase.EnumRestriction.None
            TxtFind.XOPlaceholderText = "Type then press Enter"
            TxtFind.XOSqlText = Nothing
            TxtFind.XOIsReplaceEmptyString = False
            TxtFind.XOMandatoryMessage = Nothing
            ' 
            ' DgnMOG
            ' 
            DgnMOG.AllowUserToAddRows = False
            DgnMOG.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(246), CByte(226), CByte(91))
            DgnMOG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnMOG.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnMOG.BorderStyle = BorderStyle.None
            DgnMOG.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnMOG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnMOG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnMOG.ColumnHeadersHeight = 43
            DgnMOG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnMOG.Columns.AddRange(New DataGridViewColumn() {modulegroup_id, modulegroup_name, modulegroup_description, modulegroup_order})
            DgnMOG.Dock = DockStyle.Fill
            DgnMOG.EnableHeadersVisualStyles = False
            DgnMOG.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnMOG.Location = New Point(0, 88)
            DgnMOG.Margin = New Padding(6, 5, 6, 5)
            DgnMOG.Name = "DgnMOG"
            DgnMOG.ReadOnly = True
            DgnMOG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnMOG.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnMOG.RowHeadersWidth = 62
            DgnMOG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnMOG.Size = New Size(1307, 864)
            DgnMOG.StandardTab = True
            DgnMOG.TabIndex = 803
            DgnMOG.XOIsGroupFirstRow = False
            DgnMOG.XOIsShowRowNumber = True
            ' 
            ' modulegroup_id
            ' 
            modulegroup_id.DataPropertyName = "modulegroup_id"
            modulegroup_id.HeaderText = "ID"
            modulegroup_id.MinimumWidth = 8
            modulegroup_id.Name = "modulegroup_id"
            modulegroup_id.ReadOnly = True
            modulegroup_id.SortMode = DataGridViewColumnSortMode.Programmatic
            modulegroup_id.Width = 150
            ' 
            ' modulegroup_name
            ' 
            modulegroup_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            modulegroup_name.DataPropertyName = "modulegroup_name"
            modulegroup_name.HeaderText = "Group Name"
            modulegroup_name.MinimumWidth = 8
            modulegroup_name.Name = "modulegroup_name"
            modulegroup_name.ReadOnly = True
            modulegroup_name.SortMode = DataGridViewColumnSortMode.Programmatic
            modulegroup_name.Width = 132
            ' 
            ' modulegroup_description
            ' 
            modulegroup_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            modulegroup_description.DataPropertyName = "modulegroup_description"
            modulegroup_description.HeaderText = "Description"
            modulegroup_description.MinimumWidth = 8
            modulegroup_description.Name = "modulegroup_description"
            modulegroup_description.ReadOnly = True
            modulegroup_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' modulegroup_order
            ' 
            modulegroup_order.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            modulegroup_order.DataPropertyName = "modulegroup_order"
            modulegroup_order.HeaderText = "Order Number"
            modulegroup_order.MinimumWidth = 8
            modulegroup_order.Name = "modulegroup_order"
            modulegroup_order.ReadOnly = True
            modulegroup_order.SortMode = DataGridViewColumnSortMode.Programmatic
            modulegroup_order.Width = 143
            ' 
            ' FRMmogs
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(9, 5, 9, 5)
            Name = "FRMmogs"
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

        Friend WithEvents Pnl1 As CMCv.UI.Control.Pnl
        Friend WithEvents BtnClear As CMCv.UI.Control.Btn
        Friend WithEvents Lbl1 As CMCv.UI.Control.Lbl
        Friend WithEvents TxtFind As CMCv.UI.Control.Txt
        Friend WithEvents DgnMOG As CMCv.UI.Control.Dgn
        Friend WithEvents modulegroup_id As DataGridViewTextBoxColumn
        Friend WithEvents modulegroup_name As DataGridViewTextBoxColumn
        Friend WithEvents modulegroup_description As DataGridViewTextBoxColumn
        Friend WithEvents modulegroup_order As DataGridViewTextBoxColumn
    End Class
End Namespace