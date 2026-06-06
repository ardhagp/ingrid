Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMrems
        Inherits CMCv.FRMstandardFind

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
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnOnProgress = New CMCv.UI.Control.dgn(components)
            o_todos_id = New DataGridViewTextBoxColumn()
            o_todos_name = New DataGridViewTextBoxColumn()
            o_todos_datestart = New DataGridViewTextBoxColumn()
            o_todos_dateend = New DataGridViewTextBoxColumn()
            o_todos_dayleft = New DataGridViewTextBoxColumn()
            o_todos_priority = New DataGridViewTextBoxColumn()
            o_todos_totalvalue = New DataGridViewTextBoxColumn()
            o_todos_currentvalue = New DataGridViewTextBoxColumn()
            o_todos_percentage = New DataGridViewTextBoxColumn()
            o_todos_instruction = New DataGridViewTextBoxColumn()
            o_todos_createdby = New DataGridViewTextBoxColumn()
            o_todos_datecreated = New DataGridViewTextBoxColumn()
            o_todos_completedby = New DataGridViewTextBoxColumn()
            o_todos_verifiedby = New DataGridViewTextBoxColumn()
            o_todos_isreminder = New DataGridViewCheckBoxColumn()
            o_todos_iscomplete = New DataGridViewCheckBoxColumn()
            o_todos_ispublic = New DataGridViewCheckBoxColumn()
            TbctlToDoList = New CMCv.UI.Control.Tbx(components)
            tpOnProgress = New TabPage()
            tpFinished = New TabPage()
            DgnDone = New CMCv.UI.Control.dgn(components)
            d_todos_id = New DataGridViewTextBoxColumn()
            d_todos_name = New DataGridViewTextBoxColumn()
            d_todos_datestart = New DataGridViewTextBoxColumn()
            d_todos_dateend = New DataGridViewTextBoxColumn()
            d_todos_dayleft = New DataGridViewTextBoxColumn()
            d_todos_priority = New DataGridViewTextBoxColumn()
            d_todos_totalvalue = New DataGridViewTextBoxColumn()
            d_todos_currentvalue = New DataGridViewTextBoxColumn()
            d_todos_percentage = New DataGridViewTextBoxColumn()
            d_todos_instruction = New DataGridViewTextBoxColumn()
            d_todos_createdby = New DataGridViewTextBoxColumn()
            d_todos_datecreated = New DataGridViewTextBoxColumn()
            d_todos_completedby = New DataGridViewTextBoxColumn()
            d_todos_verifiedby = New DataGridViewTextBoxColumn()
            d_todos_isreminder = New DataGridViewCheckBoxColumn()
            d_todos_iscomplete = New DataGridViewCheckBoxColumn()
            d_todos_ispublic = New DataGridViewCheckBoxColumn()
            tpVerified = New TabPage()
            DgnVerified = New CMCv.UI.Control.dgn(components)
            v_todos_id = New DataGridViewTextBoxColumn()
            v_todos_name = New DataGridViewTextBoxColumn()
            v_todos_datestart = New DataGridViewTextBoxColumn()
            v_todos_dateend = New DataGridViewTextBoxColumn()
            v_todos_priority = New DataGridViewTextBoxColumn()
            v_todos_dayleft = New DataGridViewTextBoxColumn()
            v_todos_totalvalue = New DataGridViewTextBoxColumn()
            v_todos_currentvalue = New DataGridViewTextBoxColumn()
            v_todos_percentage = New DataGridViewTextBoxColumn()
            v_todos_instruction = New DataGridViewTextBoxColumn()
            v_todos_createdby = New DataGridViewTextBoxColumn()
            v_todos_datecreated = New DataGridViewTextBoxColumn()
            v_todos_completedby = New DataGridViewTextBoxColumn()
            v_todos_verifiedby = New DataGridViewTextBoxColumn()
            v_todos_isreminder = New DataGridViewCheckBoxColumn()
            v_todos_iscomplete = New DataGridViewCheckBoxColumn()
            v_todos_ispublic = New DataGridViewCheckBoxColumn()
            SpcContent = New CMCv.UI.Control.spc(components)
            BtnViewAttachment = New CMCv.UI.Control.Btn(components)
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnOnProgress, ComponentModel.ISupportInitialize).BeginInit()
            TbctlToDoList.SuspendLayout()
            tpOnProgress.SuspendLayout()
            tpFinished.SuspendLayout()
            CType(DgnDone, ComponentModel.ISupportInitialize).BeginInit()
            tpVerified.SuspendLayout()
            CType(DgnVerified, ComponentModel.ISupportInitialize).BeginInit()
            CType(SpcContent, ComponentModel.ISupportInitialize).BeginInit()
            SpcContent.Panel1.SuspendLayout()
            SpcContent.Panel2.SuspendLayout()
            SpcContent.SuspendLayout()
            SuspendLayout()
            ' 
            ' BtnClear
            ' 
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClear.FlatAppearance.BorderSize = 2
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            ' 
            ' TxtFind
            ' 
            TxtFind.BackColor = Color.White
            TxtFind.Font = New Font("Segoe UI", 12.0F, FontStyle.Italic, GraphicsUnit.Point)
            TxtFind.ForeColor = Color.LightGray
            TxtFind.Margin = New Padding(7, 5, 7, 5)
            TxtFind.Text = "Type then press Enter"
            TxtFind.XOIsBlank = False
            TxtFind.XOSqlText = ""
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(SpcContent)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(SpcContent, 0)
            ' 
            ' DgnOnProgress
            ' 
            DgnOnProgress.AllowUserToAddRows = False
            DgnOnProgress.AllowUserToDeleteRows = False
            DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(238), CByte(209), CByte(114))
            DgnOnProgress.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
            DgnOnProgress.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnOnProgress.BorderStyle = BorderStyle.None
            DgnOnProgress.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnOnProgress.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = Color.YellowGreen
            DataGridViewCellStyle11.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle11.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle11.SelectionForeColor = Color.Black
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
            DgnOnProgress.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
            DgnOnProgress.ColumnHeadersHeight = 43
            DgnOnProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnOnProgress.Columns.AddRange(New DataGridViewColumn() {o_todos_id, o_todos_name, o_todos_datestart, o_todos_dateend, o_todos_dayleft, o_todos_priority, o_todos_totalvalue, o_todos_currentvalue, o_todos_percentage, o_todos_instruction, o_todos_createdby, o_todos_datecreated, o_todos_completedby, o_todos_verifiedby, o_todos_isreminder, o_todos_iscomplete, o_todos_ispublic})
            DgnOnProgress.Dock = DockStyle.Fill
            DgnOnProgress.EnableHeadersVisualStyles = False
            DgnOnProgress.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnOnProgress.Location = New Point(6, 5)
            DgnOnProgress.Margin = New Padding(6, 5, 6, 5)
            DgnOnProgress.Name = "DgnOnProgress"
            DgnOnProgress.ReadOnly = True
            DgnOnProgress.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle12.BackColor = Color.YellowGreen
            DataGridViewCellStyle12.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle12.SelectionForeColor = Color.Black
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
            DgnOnProgress.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
            DgnOnProgress.RowHeadersWidth = 62
            DgnOnProgress.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnOnProgress.Size = New Size(1287, 707)
            DgnOnProgress.StandardTab = True
            DgnOnProgress.TabIndex = 802
            DgnOnProgress.XOIsGroupFirstRow = False
            DgnOnProgress.XOIsShowRowNumber = False
            ' 
            ' o_todos_id
            ' 
            o_todos_id.DataPropertyName = "todos_id"
            o_todos_id.HeaderText = "ID"
            o_todos_id.MinimumWidth = 8
            o_todos_id.Name = "o_todos_id"
            o_todos_id.ReadOnly = True
            o_todos_id.SortMode = DataGridViewColumnSortMode.Programmatic
            o_todos_id.Width = 150
            ' 
            ' o_todos_name
            ' 
            o_todos_name.DataPropertyName = "todos_name"
            o_todos_name.HeaderText = "Name"
            o_todos_name.MinimumWidth = 8
            o_todos_name.Name = "o_todos_name"
            o_todos_name.ReadOnly = True
            o_todos_name.Width = 150
            ' 
            ' o_todos_datestart
            ' 
            o_todos_datestart.DataPropertyName = "todos_datestart"
            o_todos_datestart.HeaderText = "Start"
            o_todos_datestart.MinimumWidth = 8
            o_todos_datestart.Name = "o_todos_datestart"
            o_todos_datestart.ReadOnly = True
            o_todos_datestart.Width = 150
            ' 
            ' o_todos_dateend
            ' 
            o_todos_dateend.DataPropertyName = "todos_dateend"
            o_todos_dateend.HeaderText = "End"
            o_todos_dateend.MinimumWidth = 8
            o_todos_dateend.Name = "o_todos_dateend"
            o_todos_dateend.ReadOnly = True
            o_todos_dateend.Width = 150
            ' 
            ' o_todos_dayleft
            ' 
            o_todos_dayleft.DataPropertyName = "todos_dayleft"
            o_todos_dayleft.HeaderText = "Day(s)"
            o_todos_dayleft.MinimumWidth = 8
            o_todos_dayleft.Name = "o_todos_dayleft"
            o_todos_dayleft.ReadOnly = True
            o_todos_dayleft.Width = 150
            ' 
            ' o_todos_priority
            ' 
            o_todos_priority.DataPropertyName = "todos_priority"
            o_todos_priority.HeaderText = "Priority"
            o_todos_priority.MinimumWidth = 8
            o_todos_priority.Name = "o_todos_priority"
            o_todos_priority.ReadOnly = True
            o_todos_priority.Width = 150
            ' 
            ' o_todos_totalvalue
            ' 
            o_todos_totalvalue.DataPropertyName = "todos_totalvalue"
            o_todos_totalvalue.HeaderText = "Total Value"
            o_todos_totalvalue.MinimumWidth = 8
            o_todos_totalvalue.Name = "o_todos_totalvalue"
            o_todos_totalvalue.ReadOnly = True
            o_todos_totalvalue.Width = 150
            ' 
            ' o_todos_currentvalue
            ' 
            o_todos_currentvalue.DataPropertyName = "todos_currentvalue"
            o_todos_currentvalue.HeaderText = "Current Value"
            o_todos_currentvalue.MinimumWidth = 8
            o_todos_currentvalue.Name = "o_todos_currentvalue"
            o_todos_currentvalue.ReadOnly = True
            o_todos_currentvalue.Width = 150
            ' 
            ' o_todos_percentage
            ' 
            o_todos_percentage.DataPropertyName = "todos_percentage"
            o_todos_percentage.HeaderText = "%"
            o_todos_percentage.MinimumWidth = 8
            o_todos_percentage.Name = "o_todos_percentage"
            o_todos_percentage.ReadOnly = True
            o_todos_percentage.Width = 150
            ' 
            ' o_todos_instruction
            ' 
            o_todos_instruction.DataPropertyName = "todos_instruction"
            o_todos_instruction.HeaderText = "Instruction"
            o_todos_instruction.MinimumWidth = 8
            o_todos_instruction.Name = "o_todos_instruction"
            o_todos_instruction.ReadOnly = True
            o_todos_instruction.Width = 150
            ' 
            ' o_todos_createdby
            ' 
            o_todos_createdby.DataPropertyName = "todos_createdby"
            o_todos_createdby.HeaderText = "Contrib."
            o_todos_createdby.MinimumWidth = 8
            o_todos_createdby.Name = "o_todos_createdby"
            o_todos_createdby.ReadOnly = True
            o_todos_createdby.Width = 150
            ' 
            ' o_todos_datecreated
            ' 
            o_todos_datecreated.DataPropertyName = "todos_datecreated"
            o_todos_datecreated.HeaderText = "Date Created"
            o_todos_datecreated.MinimumWidth = 8
            o_todos_datecreated.Name = "o_todos_datecreated"
            o_todos_datecreated.ReadOnly = True
            o_todos_datecreated.Width = 150
            ' 
            ' o_todos_completedby
            ' 
            o_todos_completedby.DataPropertyName = "todos_completedby"
            o_todos_completedby.HeaderText = "Completed By"
            o_todos_completedby.MinimumWidth = 8
            o_todos_completedby.Name = "o_todos_completedby"
            o_todos_completedby.ReadOnly = True
            o_todos_completedby.Width = 150
            ' 
            ' o_todos_verifiedby
            ' 
            o_todos_verifiedby.DataPropertyName = "todos_verifiedby"
            o_todos_verifiedby.HeaderText = "Verified By"
            o_todos_verifiedby.MinimumWidth = 8
            o_todos_verifiedby.Name = "o_todos_verifiedby"
            o_todos_verifiedby.ReadOnly = True
            o_todos_verifiedby.Width = 150
            ' 
            ' o_todos_isreminder
            ' 
            o_todos_isreminder.DataPropertyName = "todos_isreminder"
            o_todos_isreminder.HeaderText = "R"
            o_todos_isreminder.MinimumWidth = 8
            o_todos_isreminder.Name = "o_todos_isreminder"
            o_todos_isreminder.ReadOnly = True
            o_todos_isreminder.Resizable = DataGridViewTriState.True
            o_todos_isreminder.SortMode = DataGridViewColumnSortMode.Automatic
            o_todos_isreminder.Width = 150
            ' 
            ' o_todos_iscomplete
            ' 
            o_todos_iscomplete.DataPropertyName = "todos_iscomplete"
            o_todos_iscomplete.HeaderText = "C"
            o_todos_iscomplete.MinimumWidth = 8
            o_todos_iscomplete.Name = "o_todos_iscomplete"
            o_todos_iscomplete.ReadOnly = True
            o_todos_iscomplete.Width = 150
            ' 
            ' o_todos_ispublic
            ' 
            o_todos_ispublic.DataPropertyName = "todos_ispublic"
            o_todos_ispublic.HeaderText = "P"
            o_todos_ispublic.MinimumWidth = 8
            o_todos_ispublic.Name = "o_todos_ispublic"
            o_todos_ispublic.ReadOnly = True
            o_todos_ispublic.Width = 150
            ' 
            ' TbctlToDoList
            ' 
            TbctlToDoList.Controls.Add(tpOnProgress)
            TbctlToDoList.Controls.Add(tpFinished)
            TbctlToDoList.Controls.Add(tpVerified)
            TbctlToDoList.Dock = DockStyle.Fill
            TbctlToDoList.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlToDoList.Location = New Point(0, 0)
            TbctlToDoList.Margin = New Padding(6, 5, 6, 5)
            TbctlToDoList.Name = "TbctlToDoList"
            TbctlToDoList.SelectedIndex = 0
            TbctlToDoList.Size = New Size(1307, 762)
            TbctlToDoList.TabIndex = 803
            ' 
            ' tpOnProgress
            ' 
            tpOnProgress.Controls.Add(DgnOnProgress)
            tpOnProgress.Location = New Point(4, 41)
            tpOnProgress.Margin = New Padding(6, 5, 6, 5)
            tpOnProgress.Name = "tpOnProgress"
            tpOnProgress.Padding = New Padding(6, 5, 6, 5)
            tpOnProgress.Size = New Size(1299, 717)
            tpOnProgress.TabIndex = 0
            tpOnProgress.Text = "ON PROGRESS"
            tpOnProgress.UseVisualStyleBackColor = True
            ' 
            ' tpFinished
            ' 
            tpFinished.Controls.Add(DgnDone)
            tpFinished.Location = New Point(4, 41)
            tpFinished.Margin = New Padding(6, 5, 6, 5)
            tpFinished.Name = "tpFinished"
            tpFinished.Padding = New Padding(6, 5, 6, 5)
            tpFinished.Size = New Size(1859, 1227)
            tpFinished.TabIndex = 1
            tpFinished.Text = "FINISHED"
            tpFinished.UseVisualStyleBackColor = True
            ' 
            ' DgnDone
            ' 
            DgnDone.AllowUserToAddRows = False
            DgnDone.AllowUserToDeleteRows = False
            DataGridViewCellStyle13.BackColor = Color.FromArgb(CByte(248), CByte(231), CByte(116))
            DgnDone.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
            DgnDone.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnDone.BorderStyle = BorderStyle.None
            DgnDone.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnDone.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle14.BackColor = Color.YellowGreen
            DataGridViewCellStyle14.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle14.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle14.SelectionForeColor = Color.Black
            DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
            DgnDone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
            DgnDone.ColumnHeadersHeight = 43
            DgnDone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnDone.Columns.AddRange(New DataGridViewColumn() {d_todos_id, d_todos_name, d_todos_datestart, d_todos_dateend, d_todos_dayleft, d_todos_priority, d_todos_totalvalue, d_todos_currentvalue, d_todos_percentage, d_todos_instruction, d_todos_createdby, d_todos_datecreated, d_todos_completedby, d_todos_verifiedby, d_todos_isreminder, d_todos_iscomplete, d_todos_ispublic})
            DgnDone.Dock = DockStyle.Fill
            DgnDone.EnableHeadersVisualStyles = False
            DgnDone.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnDone.Location = New Point(6, 5)
            DgnDone.Margin = New Padding(6, 5, 6, 5)
            DgnDone.Name = "DgnDone"
            DgnDone.ReadOnly = True
            DgnDone.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle15.BackColor = Color.YellowGreen
            DataGridViewCellStyle15.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle15.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle15.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle15.SelectionForeColor = Color.Black
            DataGridViewCellStyle15.WrapMode = DataGridViewTriState.True
            DgnDone.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
            DgnDone.RowHeadersWidth = 62
            DgnDone.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnDone.Size = New Size(1847, 1217)
            DgnDone.StandardTab = True
            DgnDone.TabIndex = 803
            DgnDone.XOIsGroupFirstRow = False
            DgnDone.XOIsShowRowNumber = False
            ' 
            ' d_todos_id
            ' 
            d_todos_id.DataPropertyName = "todos_id"
            d_todos_id.HeaderText = "ID"
            d_todos_id.MinimumWidth = 8
            d_todos_id.Name = "d_todos_id"
            d_todos_id.ReadOnly = True
            d_todos_id.SortMode = DataGridViewColumnSortMode.Programmatic
            d_todos_id.Width = 150
            ' 
            ' d_todos_name
            ' 
            d_todos_name.DataPropertyName = "todos_name"
            d_todos_name.HeaderText = "Name"
            d_todos_name.MinimumWidth = 8
            d_todos_name.Name = "d_todos_name"
            d_todos_name.ReadOnly = True
            d_todos_name.Width = 150
            ' 
            ' d_todos_datestart
            ' 
            d_todos_datestart.DataPropertyName = "todos_datestart"
            d_todos_datestart.HeaderText = "Start"
            d_todos_datestart.MinimumWidth = 8
            d_todos_datestart.Name = "d_todos_datestart"
            d_todos_datestart.ReadOnly = True
            d_todos_datestart.Width = 150
            ' 
            ' d_todos_dateend
            ' 
            d_todos_dateend.DataPropertyName = "todos_dateend"
            d_todos_dateend.HeaderText = "End"
            d_todos_dateend.MinimumWidth = 8
            d_todos_dateend.Name = "d_todos_dateend"
            d_todos_dateend.ReadOnly = True
            d_todos_dateend.Width = 150
            ' 
            ' d_todos_dayleft
            ' 
            d_todos_dayleft.DataPropertyName = "todos_dayleft"
            d_todos_dayleft.HeaderText = "Day(s)"
            d_todos_dayleft.MinimumWidth = 8
            d_todos_dayleft.Name = "d_todos_dayleft"
            d_todos_dayleft.ReadOnly = True
            d_todos_dayleft.Width = 150
            ' 
            ' d_todos_priority
            ' 
            d_todos_priority.DataPropertyName = "todos_priority"
            d_todos_priority.HeaderText = "Priority"
            d_todos_priority.MinimumWidth = 8
            d_todos_priority.Name = "d_todos_priority"
            d_todos_priority.ReadOnly = True
            d_todos_priority.Width = 150
            ' 
            ' d_todos_totalvalue
            ' 
            d_todos_totalvalue.DataPropertyName = "todos_totalvalue"
            d_todos_totalvalue.HeaderText = "Total Value"
            d_todos_totalvalue.MinimumWidth = 8
            d_todos_totalvalue.Name = "d_todos_totalvalue"
            d_todos_totalvalue.ReadOnly = True
            d_todos_totalvalue.Width = 150
            ' 
            ' d_todos_currentvalue
            ' 
            d_todos_currentvalue.DataPropertyName = "todos_currentvalue"
            d_todos_currentvalue.HeaderText = "Current Value"
            d_todos_currentvalue.MinimumWidth = 8
            d_todos_currentvalue.Name = "d_todos_currentvalue"
            d_todos_currentvalue.ReadOnly = True
            d_todos_currentvalue.Width = 150
            ' 
            ' d_todos_percentage
            ' 
            d_todos_percentage.DataPropertyName = "todos_percentage"
            d_todos_percentage.HeaderText = "%"
            d_todos_percentage.MinimumWidth = 8
            d_todos_percentage.Name = "d_todos_percentage"
            d_todos_percentage.ReadOnly = True
            d_todos_percentage.Width = 150
            ' 
            ' d_todos_instruction
            ' 
            d_todos_instruction.DataPropertyName = "todos_instruction"
            d_todos_instruction.HeaderText = "Instruction"
            d_todos_instruction.MinimumWidth = 8
            d_todos_instruction.Name = "d_todos_instruction"
            d_todos_instruction.ReadOnly = True
            d_todos_instruction.Width = 150
            ' 
            ' d_todos_createdby
            ' 
            d_todos_createdby.DataPropertyName = "todos_createdby"
            d_todos_createdby.HeaderText = "Contrib."
            d_todos_createdby.MinimumWidth = 8
            d_todos_createdby.Name = "d_todos_createdby"
            d_todos_createdby.ReadOnly = True
            d_todos_createdby.Width = 150
            ' 
            ' d_todos_datecreated
            ' 
            d_todos_datecreated.DataPropertyName = "todos_datecreated"
            d_todos_datecreated.HeaderText = "Date Created"
            d_todos_datecreated.MinimumWidth = 8
            d_todos_datecreated.Name = "d_todos_datecreated"
            d_todos_datecreated.ReadOnly = True
            d_todos_datecreated.Width = 150
            ' 
            ' d_todos_completedby
            ' 
            d_todos_completedby.DataPropertyName = "todos_completedby"
            d_todos_completedby.HeaderText = "Completed By"
            d_todos_completedby.MinimumWidth = 8
            d_todos_completedby.Name = "d_todos_completedby"
            d_todos_completedby.ReadOnly = True
            d_todos_completedby.Width = 150
            ' 
            ' d_todos_verifiedby
            ' 
            d_todos_verifiedby.DataPropertyName = "todos_verifiedby"
            d_todos_verifiedby.HeaderText = "Verified By"
            d_todos_verifiedby.MinimumWidth = 8
            d_todos_verifiedby.Name = "d_todos_verifiedby"
            d_todos_verifiedby.ReadOnly = True
            d_todos_verifiedby.Width = 150
            ' 
            ' d_todos_isreminder
            ' 
            d_todos_isreminder.DataPropertyName = "todos_isreminder"
            d_todos_isreminder.HeaderText = "R"
            d_todos_isreminder.MinimumWidth = 8
            d_todos_isreminder.Name = "d_todos_isreminder"
            d_todos_isreminder.ReadOnly = True
            d_todos_isreminder.Resizable = DataGridViewTriState.True
            d_todos_isreminder.SortMode = DataGridViewColumnSortMode.Automatic
            d_todos_isreminder.Width = 150
            ' 
            ' d_todos_iscomplete
            ' 
            d_todos_iscomplete.DataPropertyName = "todos_iscomplete"
            d_todos_iscomplete.HeaderText = "C"
            d_todos_iscomplete.MinimumWidth = 8
            d_todos_iscomplete.Name = "d_todos_iscomplete"
            d_todos_iscomplete.ReadOnly = True
            d_todos_iscomplete.Width = 150
            ' 
            ' d_todos_ispublic
            ' 
            d_todos_ispublic.DataPropertyName = "todos_ispublic"
            d_todos_ispublic.HeaderText = "P"
            d_todos_ispublic.MinimumWidth = 8
            d_todos_ispublic.Name = "d_todos_ispublic"
            d_todos_ispublic.ReadOnly = True
            d_todos_ispublic.Width = 150
            ' 
            ' tpVerified
            ' 
            tpVerified.Controls.Add(DgnVerified)
            tpVerified.Location = New Point(4, 41)
            tpVerified.Margin = New Padding(6, 5, 6, 5)
            tpVerified.Name = "tpVerified"
            tpVerified.Padding = New Padding(6, 5, 6, 5)
            tpVerified.Size = New Size(1859, 1227)
            tpVerified.TabIndex = 2
            tpVerified.Text = "VERIFIED"
            tpVerified.UseVisualStyleBackColor = True
            ' 
            ' DgnVerified
            ' 
            DgnVerified.AllowUserToAddRows = False
            DgnVerified.AllowUserToDeleteRows = False
            DataGridViewCellStyle16.BackColor = Color.FromArgb(CByte(252), CByte(229), CByte(120))
            DgnVerified.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
            DgnVerified.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnVerified.BorderStyle = BorderStyle.None
            DgnVerified.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnVerified.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = Color.YellowGreen
            DataGridViewCellStyle17.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle17.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle17.SelectionForeColor = Color.Black
            DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True
            DgnVerified.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
            DgnVerified.ColumnHeadersHeight = 43
            DgnVerified.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnVerified.Columns.AddRange(New DataGridViewColumn() {v_todos_id, v_todos_name, v_todos_datestart, v_todos_dateend, v_todos_priority, v_todos_dayleft, v_todos_totalvalue, v_todos_currentvalue, v_todos_percentage, v_todos_instruction, v_todos_createdby, v_todos_datecreated, v_todos_completedby, v_todos_verifiedby, v_todos_isreminder, v_todos_iscomplete, v_todos_ispublic})
            DgnVerified.Dock = DockStyle.Fill
            DgnVerified.EnableHeadersVisualStyles = False
            DgnVerified.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnVerified.Location = New Point(6, 5)
            DgnVerified.Margin = New Padding(6, 5, 6, 5)
            DgnVerified.Name = "DgnVerified"
            DgnVerified.ReadOnly = True
            DgnVerified.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = Color.YellowGreen
            DataGridViewCellStyle18.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle18.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle18.SelectionForeColor = Color.Black
            DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True
            DgnVerified.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
            DgnVerified.RowHeadersWidth = 62
            DgnVerified.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnVerified.Size = New Size(1847, 1217)
            DgnVerified.StandardTab = True
            DgnVerified.TabIndex = 803
            DgnVerified.XOIsGroupFirstRow = False
            DgnVerified.XOIsShowRowNumber = False
            ' 
            ' v_todos_id
            ' 
            v_todos_id.DataPropertyName = "todos_id"
            v_todos_id.HeaderText = "ID"
            v_todos_id.MinimumWidth = 8
            v_todos_id.Name = "v_todos_id"
            v_todos_id.ReadOnly = True
            v_todos_id.SortMode = DataGridViewColumnSortMode.Programmatic
            v_todos_id.Width = 150
            ' 
            ' v_todos_name
            ' 
            v_todos_name.DataPropertyName = "todos_name"
            v_todos_name.HeaderText = "Name"
            v_todos_name.MinimumWidth = 8
            v_todos_name.Name = "v_todos_name"
            v_todos_name.ReadOnly = True
            v_todos_name.Width = 150
            ' 
            ' v_todos_datestart
            ' 
            v_todos_datestart.DataPropertyName = "todos_datestart"
            v_todos_datestart.HeaderText = "Start"
            v_todos_datestart.MinimumWidth = 8
            v_todos_datestart.Name = "v_todos_datestart"
            v_todos_datestart.ReadOnly = True
            v_todos_datestart.Width = 150
            ' 
            ' v_todos_dateend
            ' 
            v_todos_dateend.DataPropertyName = "todos_dateend"
            v_todos_dateend.HeaderText = "End"
            v_todos_dateend.MinimumWidth = 8
            v_todos_dateend.Name = "v_todos_dateend"
            v_todos_dateend.ReadOnly = True
            v_todos_dateend.Width = 150
            ' 
            ' v_todos_priority
            ' 
            v_todos_priority.DataPropertyName = "todos_priority"
            v_todos_priority.HeaderText = "Priority"
            v_todos_priority.MinimumWidth = 8
            v_todos_priority.Name = "v_todos_priority"
            v_todos_priority.ReadOnly = True
            v_todos_priority.Width = 150
            ' 
            ' v_todos_dayleft
            ' 
            v_todos_dayleft.DataPropertyName = "todos_dayleft"
            v_todos_dayleft.HeaderText = "Day(s)"
            v_todos_dayleft.MinimumWidth = 8
            v_todos_dayleft.Name = "v_todos_dayleft"
            v_todos_dayleft.ReadOnly = True
            v_todos_dayleft.Width = 150
            ' 
            ' v_todos_totalvalue
            ' 
            v_todos_totalvalue.DataPropertyName = "todos_totalvalue"
            v_todos_totalvalue.HeaderText = "Total Value"
            v_todos_totalvalue.MinimumWidth = 8
            v_todos_totalvalue.Name = "v_todos_totalvalue"
            v_todos_totalvalue.ReadOnly = True
            v_todos_totalvalue.Width = 150
            ' 
            ' v_todos_currentvalue
            ' 
            v_todos_currentvalue.DataPropertyName = "todos_currentvalue"
            v_todos_currentvalue.HeaderText = "Current Value"
            v_todos_currentvalue.MinimumWidth = 8
            v_todos_currentvalue.Name = "v_todos_currentvalue"
            v_todos_currentvalue.ReadOnly = True
            v_todos_currentvalue.Width = 150
            ' 
            ' v_todos_percentage
            ' 
            v_todos_percentage.DataPropertyName = "todos_percentage"
            v_todos_percentage.HeaderText = "%"
            v_todos_percentage.MinimumWidth = 8
            v_todos_percentage.Name = "v_todos_percentage"
            v_todos_percentage.ReadOnly = True
            v_todos_percentage.Width = 150
            ' 
            ' v_todos_instruction
            ' 
            v_todos_instruction.DataPropertyName = "todos_instruction"
            v_todos_instruction.HeaderText = "Instruction"
            v_todos_instruction.MinimumWidth = 8
            v_todos_instruction.Name = "v_todos_instruction"
            v_todos_instruction.ReadOnly = True
            v_todos_instruction.Width = 150
            ' 
            ' v_todos_createdby
            ' 
            v_todos_createdby.DataPropertyName = "todos_createdby"
            v_todos_createdby.HeaderText = "Contrib."
            v_todos_createdby.MinimumWidth = 8
            v_todos_createdby.Name = "v_todos_createdby"
            v_todos_createdby.ReadOnly = True
            v_todos_createdby.Width = 150
            ' 
            ' v_todos_datecreated
            ' 
            v_todos_datecreated.DataPropertyName = "todos_datecreated"
            v_todos_datecreated.HeaderText = "Date Created"
            v_todos_datecreated.MinimumWidth = 8
            v_todos_datecreated.Name = "v_todos_datecreated"
            v_todos_datecreated.ReadOnly = True
            v_todos_datecreated.Width = 150
            ' 
            ' v_todos_completedby
            ' 
            v_todos_completedby.DataPropertyName = "todos_completedby"
            v_todos_completedby.HeaderText = "Completed By"
            v_todos_completedby.MinimumWidth = 8
            v_todos_completedby.Name = "v_todos_completedby"
            v_todos_completedby.ReadOnly = True
            v_todos_completedby.Width = 150
            ' 
            ' v_todos_verifiedby
            ' 
            v_todos_verifiedby.DataPropertyName = "todos_verifiedby"
            v_todos_verifiedby.HeaderText = "Verified By"
            v_todos_verifiedby.MinimumWidth = 8
            v_todos_verifiedby.Name = "v_todos_verifiedby"
            v_todos_verifiedby.ReadOnly = True
            v_todos_verifiedby.Width = 150
            ' 
            ' v_todos_isreminder
            ' 
            v_todos_isreminder.DataPropertyName = "todos_isreminder"
            v_todos_isreminder.HeaderText = "R"
            v_todos_isreminder.MinimumWidth = 8
            v_todos_isreminder.Name = "v_todos_isreminder"
            v_todos_isreminder.ReadOnly = True
            v_todos_isreminder.Resizable = DataGridViewTriState.True
            v_todos_isreminder.SortMode = DataGridViewColumnSortMode.Automatic
            v_todos_isreminder.Width = 150
            ' 
            ' v_todos_iscomplete
            ' 
            v_todos_iscomplete.DataPropertyName = "todos_iscomplete"
            v_todos_iscomplete.HeaderText = "C"
            v_todos_iscomplete.MinimumWidth = 8
            v_todos_iscomplete.Name = "v_todos_iscomplete"
            v_todos_iscomplete.ReadOnly = True
            v_todos_iscomplete.Width = 150
            ' 
            ' v_todos_ispublic
            ' 
            v_todos_ispublic.DataPropertyName = "todos_ispublic"
            v_todos_ispublic.HeaderText = "P"
            v_todos_ispublic.MinimumWidth = 8
            v_todos_ispublic.Name = "v_todos_ispublic"
            v_todos_ispublic.ReadOnly = True
            v_todos_ispublic.Width = 150
            ' 
            ' SpcContent
            ' 
            SpcContent.Dock = DockStyle.Fill
            SpcContent.Location = New Point(0, 88)
            SpcContent.Margin = New Padding(6, 5, 6, 5)
            SpcContent.Name = "SpcContent"
            SpcContent.Orientation = Orientation.Horizontal
            ' 
            ' SpcContent.Panel1
            ' 
            SpcContent.Panel1.Controls.Add(TbctlToDoList)
            ' 
            ' SpcContent.Panel2
            ' 
            SpcContent.Panel2.Controls.Add(BtnViewAttachment)
            SpcContent.Size = New Size(1307, 864)
            SpcContent.SplitterDistance = 762
            SpcContent.SplitterWidth = 8
            SpcContent.TabIndex = 803
            ' 
            ' BtnViewAttachment
            ' 
            BtnViewAttachment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnViewAttachment.BackColor = Color.YellowGreen
            BtnViewAttachment.Cursor = Cursors.Hand
            BtnViewAttachment.FlatAppearance.BorderColor = Color.FromArgb(CByte(94), CByte(145), CByte(50))
            BtnViewAttachment.FlatAppearance.BorderSize = 2
            BtnViewAttachment.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(174), CByte(225), CByte(70))
            BtnViewAttachment.FlatStyle = FlatStyle.Flat
            BtnViewAttachment.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnViewAttachment.ForeColor = Color.Black
            BtnViewAttachment.Location = New Point(994, 5)
            BtnViewAttachment.Margin = New Padding(6, 5, 6, 5)
            BtnViewAttachment.Name = "BtnViewAttachment"
            BtnViewAttachment.Size = New Size(291, 77)
            BtnViewAttachment.TabIndex = 0
            BtnViewAttachment.Text = "View Attachment"
            BtnViewAttachment.UseVisualStyleBackColor = False
            BtnViewAttachment.XOButtonType = ControlCodeBase.buttonType.Custom
            BtnViewAttachment.XOShowBorderOnFocus = False
            BtnViewAttachment.XOValidateAllInput = False
            BtnViewAttachment.XOValidateAllInputTag = Nothing
            ' 
            ' FRMrems
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMrems"
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnOnProgress, ComponentModel.ISupportInitialize).EndInit()
            TbctlToDoList.ResumeLayout(False)
            tpOnProgress.ResumeLayout(False)
            tpFinished.ResumeLayout(False)
            CType(DgnDone, ComponentModel.ISupportInitialize).EndInit()
            tpVerified.ResumeLayout(False)
            CType(DgnVerified, ComponentModel.ISupportInitialize).EndInit()
            SpcContent.Panel1.ResumeLayout(False)
            SpcContent.Panel2.ResumeLayout(False)
            CType(SpcContent, ComponentModel.ISupportInitialize).EndInit()
            SpcContent.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents DgnOnProgress As CMCv.UI.Control.dgn
        Friend WithEvents TbctlToDoList As CMCv.UI.Control.Tbx
        Friend WithEvents tpOnProgress As TabPage
        Friend WithEvents tpFinished As TabPage
        Friend WithEvents SpcContent As CMCv.UI.Control.spc
        Friend WithEvents tpVerified As TabPage
        Friend WithEvents BtnViewAttachment As CMCv.UI.Control.Btn
        Friend WithEvents DgnDone As CMCv.UI.Control.dgn
        Friend WithEvents DgnVerified As CMCv.UI.Control.dgn
        Friend WithEvents o_todos_id As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_name As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_datestart As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_dateend As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_dayleft As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_priority As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_totalvalue As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_currentvalue As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_percentage As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_instruction As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_createdby As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_datecreated As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_completedby As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_verifiedby As DataGridViewTextBoxColumn
        Friend WithEvents o_todos_isreminder As DataGridViewCheckBoxColumn
        Friend WithEvents o_todos_iscomplete As DataGridViewCheckBoxColumn
        Friend WithEvents o_todos_ispublic As DataGridViewCheckBoxColumn
        Friend WithEvents d_todos_id As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_name As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_datestart As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_dateend As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_dayleft As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_priority As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_totalvalue As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_currentvalue As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_percentage As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_instruction As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_createdby As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_datecreated As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_completedby As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_verifiedby As DataGridViewTextBoxColumn
        Friend WithEvents d_todos_isreminder As DataGridViewCheckBoxColumn
        Friend WithEvents d_todos_iscomplete As DataGridViewCheckBoxColumn
        Friend WithEvents d_todos_ispublic As DataGridViewCheckBoxColumn
        Friend WithEvents v_todos_id As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_name As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_datestart As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_dateend As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_priority As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_dayleft As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_totalvalue As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_currentvalue As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_percentage As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_instruction As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_createdby As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_datecreated As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_completedby As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_verifiedby As DataGridViewTextBoxColumn
        Friend WithEvents v_todos_isreminder As DataGridViewCheckBoxColumn
        Friend WithEvents v_todos_iscomplete As DataGridViewCheckBoxColumn
        Friend WithEvents v_todos_ispublic As DataGridViewCheckBoxColumn
    End Class
End Namespace