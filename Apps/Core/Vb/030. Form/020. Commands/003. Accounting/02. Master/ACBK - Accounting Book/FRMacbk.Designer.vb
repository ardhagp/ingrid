Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMacbk
        Inherits CMCv.FRMstandard

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
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Pnl1 = New CMCv.UI.Control.pnl(components)
            BtnClear = New CMCv.UI.Control.Btn(components)
            Lbl1 = New CMCv.UI.Control.lbl(components)
            TxtFind = New CMCv.UI.Control.txt(components)
            DgnACBK = New CMCv.UI.Control.dgn(components)
            book_id = New DataGridViewTextBoxColumn()
            company_code = New DataGridViewTextBoxColumn()
            book_code = New DataGridViewTextBoxColumn()
            book_bookname = New DataGridViewTextBoxColumn()
            book_datecreated = New DataGridViewTextBoxColumn()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            Pnl1.SuspendLayout()
            CType(DgnACBK, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnACBK)
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
            Pnl1.TabIndex = 800
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
            BtnClear.XOButtonType = ControlCodeBase.buttonType.No
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
            TxtFind.XOIsSearchBox = False
            TxtFind.XOLetterCase = ControlCodeBase.enuJenisKapital.Normal
            TxtFind.XOSelectOnFocus = False
            TxtFind.XOPasswordLengthMin = 8
            TxtFind.XOPasswordStrengthCalc = False
            TxtFind.XOPasswordStrengthScore = 0
            TxtFind.XOPasswordStrengthText = Nothing
            TxtFind.XORestriction = ControlCodeBase.enuRestriction.None
            TxtFind.XOSearchBoxText = "Type then press Enter"
            TxtFind.XOSqlText = Nothing
            TxtFind.XOIsReplaceEmptyString = False
            TxtFind.XOMandatoryMessage = Nothing
            ' 
            ' DgnACBK
            ' 
            DgnACBK.AllowUserToAddRows = False
            DgnACBK.AllowUserToDeleteRows = False
            DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(250), CByte(228), CByte(165))
            DgnACBK.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
            DgnACBK.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnACBK.BorderStyle = BorderStyle.None
            DgnACBK.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnACBK.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnACBK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnACBK.ColumnHeadersHeight = 43
            DgnACBK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnACBK.Columns.AddRange(New DataGridViewColumn() {book_id, company_code, book_code, book_bookname, book_datecreated})
            DgnACBK.Dock = DockStyle.Fill
            DgnACBK.EnableHeadersVisualStyles = False
            DgnACBK.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnACBK.Location = New Point(0, 88)
            DgnACBK.Margin = New Padding(6, 5, 6, 5)
            DgnACBK.Name = "DgnACBK"
            DgnACBK.ReadOnly = True
            DgnACBK.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle8.BackColor = Color.YellowGreen
            DataGridViewCellStyle8.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle8.SelectionForeColor = Color.Black
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
            DgnACBK.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
            DgnACBK.RowHeadersWidth = 62
            DgnACBK.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnACBK.Size = New Size(1307, 864)
            DgnACBK.StandardTab = True
            DgnACBK.TabIndex = 0
            DgnACBK.XOGroupFirstRow = False
            DgnACBK.XOShowRowNumber = True
            ' 
            ' book_id
            ' 
            book_id.DataPropertyName = "book_id"
            book_id.HeaderText = "ID"
            book_id.MinimumWidth = 8
            book_id.Name = "book_id"
            book_id.ReadOnly = True
            book_id.Visible = False
            book_id.Width = 150
            ' 
            ' company_code
            ' 
            company_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            company_code.DataPropertyName = "company_code"
            company_code.HeaderText = "Company"
            company_code.MinimumWidth = 8
            company_code.Name = "company_code"
            company_code.ReadOnly = True
            company_code.SortMode = DataGridViewColumnSortMode.Programmatic
            company_code.Width = 117
            ' 
            ' book_code
            ' 
            book_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            book_code.DataPropertyName = "book_code"
            DataGridViewCellStyle7.BackColor = Color.GreenYellow
            book_code.DefaultCellStyle = DataGridViewCellStyle7
            book_code.HeaderText = "Acc Book Code"
            book_code.MinimumWidth = 8
            book_code.Name = "book_code"
            book_code.ReadOnly = True
            book_code.SortMode = DataGridViewColumnSortMode.Programmatic
            book_code.Width = 149
            ' 
            ' book_bookname
            ' 
            book_bookname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            book_bookname.DataPropertyName = "book_bookname"
            book_bookname.HeaderText = "Book Name"
            book_bookname.MinimumWidth = 8
            book_bookname.Name = "book_bookname"
            book_bookname.ReadOnly = True
            book_bookname.SortMode = DataGridViewColumnSortMode.Programmatic
            book_bookname.Width = 124
            ' 
            ' book_datecreated
            ' 
            book_datecreated.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            book_datecreated.DataPropertyName = "book_datecreated"
            book_datecreated.HeaderText = "Created On"
            book_datecreated.MinimumWidth = 8
            book_datecreated.Name = "book_datecreated"
            book_datecreated.ReadOnly = True
            book_datecreated.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' FRMacbk
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(9, 5, 9, 5)
            Name = "FRMacbk"
            Text = "Nama Form"
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            Pnl1.ResumeLayout(False)
            Pnl1.PerformLayout()
            CType(DgnACBK, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents Pnl1 As CMCv.UI.Control.pnl
        Friend WithEvents BtnClear As CMCv.UI.Control.Btn
        Friend WithEvents Lbl1 As CMCv.UI.Control.lbl
        Friend WithEvents TxtFind As CMCv.UI.Control.txt
        Friend WithEvents DgnACBK As CMCv.UI.Control.dgn
        Friend WithEvents book_id As DataGridViewTextBoxColumn
        Friend WithEvents company_code As DataGridViewTextBoxColumn
        Friend WithEvents book_code As DataGridViewTextBoxColumn
        Friend WithEvents book_bookname As DataGridViewTextBoxColumn
        Friend WithEvents book_datecreated As DataGridViewTextBoxColumn
    End Class
End Namespace