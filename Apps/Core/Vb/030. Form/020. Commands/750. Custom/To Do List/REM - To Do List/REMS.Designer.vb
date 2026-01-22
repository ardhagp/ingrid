<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REMS
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DgnOnProgress = New dgn(components)
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
        TbctlToDoList = New tbctl(components)
        tpOnProgress = New TabPage()
        tpFinished = New TabPage()
        DgnDone = New dgn(components)
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
        DgnVerified = New dgn(components)
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
        SpcContent = New spc(components)
        BtnViewAttachment = New btn(components)
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
        TxtFind.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point)
        TxtFind.ForeColor = Color.LightGray
        TxtFind.Margin = New Padding(5, 3, 5, 3)
        TxtFind.XOIsBlank = False
        TxtFind.XOSQLText = ""
        TxtFind.Text = "Type then press Enter"
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(SpcContent)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(SpcContent, 0)
        ' 
        ' DgnOnProgress
        ' 
        DgnOnProgress.AllowUserToAddRows = False
        DgnOnProgress.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(193), CByte(215), CByte(184))
        DgnOnProgress.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnOnProgress.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnOnProgress.BorderStyle = BorderStyle.None
        DgnOnProgress.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnOnProgress.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnOnProgress.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnOnProgress.ColumnHeadersHeight = 43
        DgnOnProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnOnProgress.Columns.AddRange(New DataGridViewColumn() {o_todos_id, o_todos_name, o_todos_datestart, o_todos_dateend, o_todos_dayleft, o_todos_priority, o_todos_totalvalue, o_todos_currentvalue, o_todos_percentage, o_todos_instruction, o_todos_createdby, o_todos_datecreated, o_todos_completedby, o_todos_verifiedby, o_todos_isreminder, o_todos_iscomplete, o_todos_ispublic})
        DgnOnProgress.Dock = DockStyle.Fill
        DgnOnProgress.EnableHeadersVisualStyles = False
        DgnOnProgress.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnOnProgress.Location = New Point(4, 3)
        DgnOnProgress.Margin = New Padding(4, 3, 4, 3)
        DgnOnProgress.Name = "DgnOnProgress"
        DgnOnProgress.ReadOnly = True
        DgnOnProgress.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.YellowGreen
        DataGridViewCellStyle3.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DgnOnProgress.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DgnOnProgress.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnOnProgress.Size = New Size(899, 411)
        DgnOnProgress.XOGroupFirstRows = False
        DgnOnProgress.XOGunakanNomorBaris = False
        DgnOnProgress.StandardTab = True
        DgnOnProgress.TabIndex = 802
        ' 
        ' o_todos_id
        ' 
        o_todos_id.DataPropertyName = "todos_id"
        o_todos_id.HeaderText = "ID"
        o_todos_id.Name = "o_todos_id"
        o_todos_id.ReadOnly = True
        o_todos_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' o_todos_name
        ' 
        o_todos_name.DataPropertyName = "todos_name"
        o_todos_name.HeaderText = "Name"
        o_todos_name.Name = "o_todos_name"
        o_todos_name.ReadOnly = True
        ' 
        ' o_todos_datestart
        ' 
        o_todos_datestart.DataPropertyName = "todos_datestart"
        o_todos_datestart.HeaderText = "Start"
        o_todos_datestart.Name = "o_todos_datestart"
        o_todos_datestart.ReadOnly = True
        ' 
        ' o_todos_dateend
        ' 
        o_todos_dateend.DataPropertyName = "todos_dateend"
        o_todos_dateend.HeaderText = "End"
        o_todos_dateend.Name = "o_todos_dateend"
        o_todos_dateend.ReadOnly = True
        ' 
        ' o_todos_dayleft
        ' 
        o_todos_dayleft.DataPropertyName = "todos_dayleft"
        o_todos_dayleft.HeaderText = "Day(s)"
        o_todos_dayleft.Name = "o_todos_dayleft"
        o_todos_dayleft.ReadOnly = True
        ' 
        ' o_todos_priority
        ' 
        o_todos_priority.DataPropertyName = "todos_priority"
        o_todos_priority.HeaderText = "Priority"
        o_todos_priority.Name = "o_todos_priority"
        o_todos_priority.ReadOnly = True
        ' 
        ' o_todos_totalvalue
        ' 
        o_todos_totalvalue.DataPropertyName = "todos_totalvalue"
        o_todos_totalvalue.HeaderText = "Total Value"
        o_todos_totalvalue.Name = "o_todos_totalvalue"
        o_todos_totalvalue.ReadOnly = True
        ' 
        ' o_todos_currentvalue
        ' 
        o_todos_currentvalue.DataPropertyName = "todos_currentvalue"
        o_todos_currentvalue.HeaderText = "Current Value"
        o_todos_currentvalue.Name = "o_todos_currentvalue"
        o_todos_currentvalue.ReadOnly = True
        ' 
        ' o_todos_percentage
        ' 
        o_todos_percentage.DataPropertyName = "todos_percentage"
        o_todos_percentage.HeaderText = "%"
        o_todos_percentage.Name = "o_todos_percentage"
        o_todos_percentage.ReadOnly = True
        ' 
        ' o_todos_instruction
        ' 
        o_todos_instruction.DataPropertyName = "todos_instruction"
        o_todos_instruction.HeaderText = "Instruction"
        o_todos_instruction.Name = "o_todos_instruction"
        o_todos_instruction.ReadOnly = True
        ' 
        ' o_todos_createdby
        ' 
        o_todos_createdby.DataPropertyName = "todos_createdby"
        o_todos_createdby.HeaderText = "Contrib."
        o_todos_createdby.Name = "o_todos_createdby"
        o_todos_createdby.ReadOnly = True
        ' 
        ' o_todos_datecreated
        ' 
        o_todos_datecreated.DataPropertyName = "todos_datecreated"
        o_todos_datecreated.HeaderText = "Date Created"
        o_todos_datecreated.Name = "o_todos_datecreated"
        o_todos_datecreated.ReadOnly = True
        ' 
        ' o_todos_completedby
        ' 
        o_todos_completedby.DataPropertyName = "todos_completedby"
        o_todos_completedby.HeaderText = "Completed By"
        o_todos_completedby.Name = "o_todos_completedby"
        o_todos_completedby.ReadOnly = True
        ' 
        ' o_todos_verifiedby
        ' 
        o_todos_verifiedby.DataPropertyName = "todos_verifiedby"
        o_todos_verifiedby.HeaderText = "Verified By"
        o_todos_verifiedby.Name = "o_todos_verifiedby"
        o_todos_verifiedby.ReadOnly = True
        ' 
        ' o_todos_isreminder
        ' 
        o_todos_isreminder.DataPropertyName = "todos_isreminder"
        o_todos_isreminder.HeaderText = "R"
        o_todos_isreminder.Name = "o_todos_isreminder"
        o_todos_isreminder.ReadOnly = True
        o_todos_isreminder.Resizable = DataGridViewTriState.True
        o_todos_isreminder.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' o_todos_iscomplete
        ' 
        o_todos_iscomplete.DataPropertyName = "todos_iscomplete"
        o_todos_iscomplete.HeaderText = "C"
        o_todos_iscomplete.Name = "o_todos_iscomplete"
        o_todos_iscomplete.ReadOnly = True
        ' 
        ' o_todos_ispublic
        ' 
        o_todos_ispublic.DataPropertyName = "todos_ispublic"
        o_todos_ispublic.HeaderText = "P"
        o_todos_ispublic.Name = "o_todos_ispublic"
        o_todos_ispublic.ReadOnly = True
        ' 
        ' TbctlToDoList
        ' 
        TbctlToDoList.Controls.Add(tpOnProgress)
        TbctlToDoList.Controls.Add(tpFinished)
        TbctlToDoList.Controls.Add(tpVerified)
        TbctlToDoList.Dock = DockStyle.Fill
        TbctlToDoList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlToDoList.Location = New Point(0, 0)
        TbctlToDoList.Margin = New Padding(4, 3, 4, 3)
        TbctlToDoList.Name = "TbctlToDoList"
        TbctlToDoList.SelectedIndex = 0
        TbctlToDoList.Size = New Size(915, 451)
        TbctlToDoList.TabIndex = 803
        ' 
        ' tpOnProgress
        ' 
        tpOnProgress.Controls.Add(DgnOnProgress)
        tpOnProgress.Location = New Point(4, 30)
        tpOnProgress.Margin = New Padding(4, 3, 4, 3)
        tpOnProgress.Name = "tpOnProgress"
        tpOnProgress.Padding = New Padding(4, 3, 4, 3)
        tpOnProgress.Size = New Size(907, 417)
        tpOnProgress.TabIndex = 0
        tpOnProgress.Text = "ON PROGRESS"
        tpOnProgress.UseVisualStyleBackColor = True
        ' 
        ' tpFinished
        ' 
        tpFinished.Controls.Add(DgnDone)
        tpFinished.Location = New Point(4, 30)
        tpFinished.Margin = New Padding(4, 3, 4, 3)
        tpFinished.Name = "tpFinished"
        tpFinished.Padding = New Padding(4, 3, 4, 3)
        tpFinished.Size = New Size(907, 417)
        tpFinished.TabIndex = 1
        tpFinished.Text = "FINISHED"
        tpFinished.UseVisualStyleBackColor = True
        ' 
        ' DgnDone
        ' 
        DgnDone.AllowUserToAddRows = False
        DgnDone.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(235), CByte(248), CByte(137))
        DgnDone.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DgnDone.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnDone.BorderStyle = BorderStyle.None
        DgnDone.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnDone.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.YellowGreen
        DataGridViewCellStyle5.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DgnDone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DgnDone.ColumnHeadersHeight = 43
        DgnDone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnDone.Columns.AddRange(New DataGridViewColumn() {d_todos_id, d_todos_name, d_todos_datestart, d_todos_dateend, d_todos_dayleft, d_todos_priority, d_todos_totalvalue, d_todos_currentvalue, d_todos_percentage, d_todos_instruction, d_todos_createdby, d_todos_datecreated, d_todos_completedby, d_todos_verifiedby, d_todos_isreminder, d_todos_iscomplete, d_todos_ispublic})
        DgnDone.Dock = DockStyle.Fill
        DgnDone.EnableHeadersVisualStyles = False
        DgnDone.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnDone.Location = New Point(4, 3)
        DgnDone.Margin = New Padding(4, 3, 4, 3)
        DgnDone.Name = "DgnDone"
        DgnDone.ReadOnly = True
        DgnDone.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.YellowGreen
        DataGridViewCellStyle6.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DgnDone.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DgnDone.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnDone.Size = New Size(899, 411)
        DgnDone.XOGroupFirstRows = False
        DgnDone.XOGunakanNomorBaris = False
        DgnDone.StandardTab = True
        DgnDone.TabIndex = 803
        ' 
        ' d_todos_id
        ' 
        d_todos_id.DataPropertyName = "todos_id"
        d_todos_id.HeaderText = "ID"
        d_todos_id.Name = "d_todos_id"
        d_todos_id.ReadOnly = True
        d_todos_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' d_todos_name
        ' 
        d_todos_name.DataPropertyName = "todos_name"
        d_todos_name.HeaderText = "Name"
        d_todos_name.Name = "d_todos_name"
        d_todos_name.ReadOnly = True
        ' 
        ' d_todos_datestart
        ' 
        d_todos_datestart.DataPropertyName = "todos_datestart"
        d_todos_datestart.HeaderText = "Start"
        d_todos_datestart.Name = "d_todos_datestart"
        d_todos_datestart.ReadOnly = True
        ' 
        ' d_todos_dateend
        ' 
        d_todos_dateend.DataPropertyName = "todos_dateend"
        d_todos_dateend.HeaderText = "End"
        d_todos_dateend.Name = "d_todos_dateend"
        d_todos_dateend.ReadOnly = True
        ' 
        ' d_todos_dayleft
        ' 
        d_todos_dayleft.DataPropertyName = "todos_dayleft"
        d_todos_dayleft.HeaderText = "Day(s)"
        d_todos_dayleft.Name = "d_todos_dayleft"
        d_todos_dayleft.ReadOnly = True
        ' 
        ' d_todos_priority
        ' 
        d_todos_priority.DataPropertyName = "todos_priority"
        d_todos_priority.HeaderText = "Priority"
        d_todos_priority.Name = "d_todos_priority"
        d_todos_priority.ReadOnly = True
        ' 
        ' d_todos_totalvalue
        ' 
        d_todos_totalvalue.DataPropertyName = "todos_totalvalue"
        d_todos_totalvalue.HeaderText = "Total Value"
        d_todos_totalvalue.Name = "d_todos_totalvalue"
        d_todos_totalvalue.ReadOnly = True
        ' 
        ' d_todos_currentvalue
        ' 
        d_todos_currentvalue.DataPropertyName = "todos_currentvalue"
        d_todos_currentvalue.HeaderText = "Current Value"
        d_todos_currentvalue.Name = "d_todos_currentvalue"
        d_todos_currentvalue.ReadOnly = True
        ' 
        ' d_todos_percentage
        ' 
        d_todos_percentage.DataPropertyName = "todos_percentage"
        d_todos_percentage.HeaderText = "%"
        d_todos_percentage.Name = "d_todos_percentage"
        d_todos_percentage.ReadOnly = True
        ' 
        ' d_todos_instruction
        ' 
        d_todos_instruction.DataPropertyName = "todos_instruction"
        d_todos_instruction.HeaderText = "Instruction"
        d_todos_instruction.Name = "d_todos_instruction"
        d_todos_instruction.ReadOnly = True
        ' 
        ' d_todos_createdby
        ' 
        d_todos_createdby.DataPropertyName = "todos_createdby"
        d_todos_createdby.HeaderText = "Contrib."
        d_todos_createdby.Name = "d_todos_createdby"
        d_todos_createdby.ReadOnly = True
        ' 
        ' d_todos_datecreated
        ' 
        d_todos_datecreated.DataPropertyName = "todos_datecreated"
        d_todos_datecreated.HeaderText = "Date Created"
        d_todos_datecreated.Name = "d_todos_datecreated"
        d_todos_datecreated.ReadOnly = True
        ' 
        ' d_todos_completedby
        ' 
        d_todos_completedby.DataPropertyName = "todos_completedby"
        d_todos_completedby.HeaderText = "Completed By"
        d_todos_completedby.Name = "d_todos_completedby"
        d_todos_completedby.ReadOnly = True
        ' 
        ' d_todos_verifiedby
        ' 
        d_todos_verifiedby.DataPropertyName = "todos_verifiedby"
        d_todos_verifiedby.HeaderText = "Verified By"
        d_todos_verifiedby.Name = "d_todos_verifiedby"
        d_todos_verifiedby.ReadOnly = True
        ' 
        ' d_todos_isreminder
        ' 
        d_todos_isreminder.DataPropertyName = "todos_isreminder"
        d_todos_isreminder.HeaderText = "R"
        d_todos_isreminder.Name = "d_todos_isreminder"
        d_todos_isreminder.ReadOnly = True
        d_todos_isreminder.Resizable = DataGridViewTriState.True
        d_todos_isreminder.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' d_todos_iscomplete
        ' 
        d_todos_iscomplete.DataPropertyName = "todos_iscomplete"
        d_todos_iscomplete.HeaderText = "C"
        d_todos_iscomplete.Name = "d_todos_iscomplete"
        d_todos_iscomplete.ReadOnly = True
        ' 
        ' d_todos_ispublic
        ' 
        d_todos_ispublic.DataPropertyName = "todos_ispublic"
        d_todos_ispublic.HeaderText = "P"
        d_todos_ispublic.Name = "d_todos_ispublic"
        d_todos_ispublic.ReadOnly = True
        ' 
        ' tpVerified
        ' 
        tpVerified.Controls.Add(DgnVerified)
        tpVerified.Location = New Point(4, 30)
        tpVerified.Margin = New Padding(4, 3, 4, 3)
        tpVerified.Name = "tpVerified"
        tpVerified.Padding = New Padding(4, 3, 4, 3)
        tpVerified.Size = New Size(907, 417)
        tpVerified.TabIndex = 2
        tpVerified.Text = "VERIFIED"
        tpVerified.UseVisualStyleBackColor = True
        ' 
        ' DgnVerified
        ' 
        DgnVerified.AllowUserToAddRows = False
        DgnVerified.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(249), CByte(200), CByte(152))
        DgnVerified.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DgnVerified.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnVerified.BorderStyle = BorderStyle.None
        DgnVerified.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnVerified.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.YellowGreen
        DataGridViewCellStyle8.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DgnVerified.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DgnVerified.ColumnHeadersHeight = 43
        DgnVerified.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnVerified.Columns.AddRange(New DataGridViewColumn() {v_todos_id, v_todos_name, v_todos_datestart, v_todos_dateend, v_todos_priority, v_todos_dayleft, v_todos_totalvalue, v_todos_currentvalue, v_todos_percentage, v_todos_instruction, v_todos_createdby, v_todos_datecreated, v_todos_completedby, v_todos_verifiedby, v_todos_isreminder, v_todos_iscomplete, v_todos_ispublic})
        DgnVerified.Dock = DockStyle.Fill
        DgnVerified.EnableHeadersVisualStyles = False
        DgnVerified.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnVerified.Location = New Point(4, 3)
        DgnVerified.Margin = New Padding(4, 3, 4, 3)
        DgnVerified.Name = "DgnVerified"
        DgnVerified.ReadOnly = True
        DgnVerified.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.YellowGreen
        DataGridViewCellStyle9.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle9.SelectionForeColor = Color.Black
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        DgnVerified.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DgnVerified.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnVerified.Size = New Size(899, 411)
        DgnVerified.XOGroupFirstRows = False
        DgnVerified.XOGunakanNomorBaris = False
        DgnVerified.StandardTab = True
        DgnVerified.TabIndex = 803
        ' 
        ' v_todos_id
        ' 
        v_todos_id.DataPropertyName = "todos_id"
        v_todos_id.HeaderText = "ID"
        v_todos_id.Name = "v_todos_id"
        v_todos_id.ReadOnly = True
        v_todos_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' v_todos_name
        ' 
        v_todos_name.DataPropertyName = "todos_name"
        v_todos_name.HeaderText = "Name"
        v_todos_name.Name = "v_todos_name"
        v_todos_name.ReadOnly = True
        ' 
        ' v_todos_datestart
        ' 
        v_todos_datestart.DataPropertyName = "todos_datestart"
        v_todos_datestart.HeaderText = "Start"
        v_todos_datestart.Name = "v_todos_datestart"
        v_todos_datestart.ReadOnly = True
        ' 
        ' v_todos_dateend
        ' 
        v_todos_dateend.DataPropertyName = "todos_dateend"
        v_todos_dateend.HeaderText = "End"
        v_todos_dateend.Name = "v_todos_dateend"
        v_todos_dateend.ReadOnly = True
        ' 
        ' v_todos_priority
        ' 
        v_todos_priority.DataPropertyName = "todos_priority"
        v_todos_priority.HeaderText = "Priority"
        v_todos_priority.Name = "v_todos_priority"
        v_todos_priority.ReadOnly = True
        ' 
        ' v_todos_dayleft
        ' 
        v_todos_dayleft.DataPropertyName = "todos_dayleft"
        v_todos_dayleft.HeaderText = "Day(s)"
        v_todos_dayleft.Name = "v_todos_dayleft"
        v_todos_dayleft.ReadOnly = True
        ' 
        ' v_todos_totalvalue
        ' 
        v_todos_totalvalue.DataPropertyName = "todos_totalvalue"
        v_todos_totalvalue.HeaderText = "Total Value"
        v_todos_totalvalue.Name = "v_todos_totalvalue"
        v_todos_totalvalue.ReadOnly = True
        ' 
        ' v_todos_currentvalue
        ' 
        v_todos_currentvalue.DataPropertyName = "todos_currentvalue"
        v_todos_currentvalue.HeaderText = "Current Value"
        v_todos_currentvalue.Name = "v_todos_currentvalue"
        v_todos_currentvalue.ReadOnly = True
        ' 
        ' v_todos_percentage
        ' 
        v_todos_percentage.DataPropertyName = "todos_percentage"
        v_todos_percentage.HeaderText = "%"
        v_todos_percentage.Name = "v_todos_percentage"
        v_todos_percentage.ReadOnly = True
        ' 
        ' v_todos_instruction
        ' 
        v_todos_instruction.DataPropertyName = "todos_instruction"
        v_todos_instruction.HeaderText = "Instruction"
        v_todos_instruction.Name = "v_todos_instruction"
        v_todos_instruction.ReadOnly = True
        ' 
        ' v_todos_createdby
        ' 
        v_todos_createdby.DataPropertyName = "todos_createdby"
        v_todos_createdby.HeaderText = "Contrib."
        v_todos_createdby.Name = "v_todos_createdby"
        v_todos_createdby.ReadOnly = True
        ' 
        ' v_todos_datecreated
        ' 
        v_todos_datecreated.DataPropertyName = "todos_datecreated"
        v_todos_datecreated.HeaderText = "Date Created"
        v_todos_datecreated.Name = "v_todos_datecreated"
        v_todos_datecreated.ReadOnly = True
        ' 
        ' v_todos_completedby
        ' 
        v_todos_completedby.DataPropertyName = "todos_completedby"
        v_todos_completedby.HeaderText = "Completed By"
        v_todos_completedby.Name = "v_todos_completedby"
        v_todos_completedby.ReadOnly = True
        ' 
        ' v_todos_verifiedby
        ' 
        v_todos_verifiedby.DataPropertyName = "todos_verifiedby"
        v_todos_verifiedby.HeaderText = "Verified By"
        v_todos_verifiedby.Name = "v_todos_verifiedby"
        v_todos_verifiedby.ReadOnly = True
        ' 
        ' v_todos_isreminder
        ' 
        v_todos_isreminder.DataPropertyName = "todos_isreminder"
        v_todos_isreminder.HeaderText = "R"
        v_todos_isreminder.Name = "v_todos_isreminder"
        v_todos_isreminder.ReadOnly = True
        v_todos_isreminder.Resizable = DataGridViewTriState.True
        v_todos_isreminder.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' v_todos_iscomplete
        ' 
        v_todos_iscomplete.DataPropertyName = "todos_iscomplete"
        v_todos_iscomplete.HeaderText = "C"
        v_todos_iscomplete.Name = "v_todos_iscomplete"
        v_todos_iscomplete.ReadOnly = True
        ' 
        ' v_todos_ispublic
        ' 
        v_todos_ispublic.DataPropertyName = "todos_ispublic"
        v_todos_ispublic.HeaderText = "P"
        v_todos_ispublic.Name = "v_todos_ispublic"
        v_todos_ispublic.ReadOnly = True
        ' 
        ' SpcContent
        ' 
        SpcContent.Dock = DockStyle.Fill
        SpcContent.Location = New Point(0, 53)
        SpcContent.Margin = New Padding(4, 3, 4, 3)
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
        SpcContent.Size = New Size(915, 511)
        SpcContent.SplitterDistance = 451
        SpcContent.SplitterWidth = 5
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
        BtnViewAttachment.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnViewAttachment.ForeColor = Color.Black
        BtnViewAttachment.Location = New Point(696, 3)
        BtnViewAttachment.Margin = New Padding(4, 3, 4, 3)
        BtnViewAttachment.Name = "BtnViewAttachment"
        BtnViewAttachment.Size = New Size(204, 46)
        BtnViewAttachment.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnViewAttachment.XOTampilkanFocusBorder = False
        BtnViewAttachment.XOValidasiSemuaInput = False
        BtnViewAttachment.XOValidasiSemuaInputTag = Nothing
        BtnViewAttachment.TabIndex = 0
        BtnViewAttachment.Text = "View Attachment"
        BtnViewAttachment.UseVisualStyleBackColor = False
        ' 
        ' REMS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "REMS"
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

    Friend WithEvents DgnOnProgress As dgn
    Friend WithEvents TbctlToDoList As tbctl
    Friend WithEvents tpOnProgress As TabPage
    Friend WithEvents tpFinished As TabPage
    Friend WithEvents SpcContent As spc
    Friend WithEvents tpVerified As TabPage
    Friend WithEvents BtnViewAttachment As btn
    Friend WithEvents DgnDone As dgn
    Friend WithEvents DgnVerified As dgn
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
