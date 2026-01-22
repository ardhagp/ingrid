<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PEPR
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PEPR))
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        SpcContent = New spc(components)
        DgnDARActivity = New dgn(components)
        areaaffected_name = New DataGridViewTextBoxColumn()
        employeeactivity_time = New DataGridViewTextBoxColumn()
        employeeactivity_description = New DataGridViewTextBoxColumn()
        employee_nickname = New DataGridViewTextBoxColumn()
        employee_id = New DataGridViewTextBoxColumn()
        employeeactivity_id = New DataGridViewTextBoxColumn()
        SttActivity = New stt(components)
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        TbctlAttachment = New tbctl(components)
        TPPhotos = New TabPage()
        SpcPhoto = New spc(components)
        DgnPhoto = New dgn(components)
        photo_id = New DataGridViewTextBoxColumn()
        photo_content = New DataGridViewImageColumn()
        photo_uploader_nickname = New DataGridViewTextBoxColumn()
        photo_content_size = New DataGridViewTextBoxColumn()
        photo_score = New DataGridViewTextBoxColumn()
        photo_datetime = New DataGridViewTextBoxColumn()
        photo_uploader = New DataGridViewTextBoxColumn()
        photo_employee_fullname = New DataGridViewTextBoxColumn()
        photo_view = New DataGridViewButtonColumn()
        TlpPhotoButton = New TableLayoutPanel()
        PctbxActivityPhoto = New pctbx(components)
        TlpCopySave = New TableLayoutPanel()
        BtnCopyPhoto = New btn(components)
        BtnSave = New btn(components)
        BtnLike = New btn(components)
        TPFiles = New TabPage()
        DgnFile = New dgn(components)
        file_id = New DataGridViewTextBoxColumn()
        file_tag = New DataGridViewTextBoxColumn()
        file_content = New DataGridViewTextBoxColumn()
        file_employee_nickname = New DataGridViewTextBoxColumn()
        file_content_size = New DataGridViewTextBoxColumn()
        file_score = New DataGridViewTextBoxColumn()
        file_datetime = New DataGridViewTextBoxColumn()
        file_uploader = New DataGridViewTextBoxColumn()
        file_employee_fullname = New DataGridViewTextBoxColumn()
        file_view = New DataGridViewButtonColumn()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(SpcContent, ComponentModel.ISupportInitialize).BeginInit()
        SpcContent.Panel1.SuspendLayout()
        SpcContent.Panel2.SuspendLayout()
        SpcContent.SuspendLayout()
        CType(DgnDARActivity, ComponentModel.ISupportInitialize).BeginInit()
        SttActivity.SuspendLayout()
        TbctlAttachment.SuspendLayout()
        TPPhotos.SuspendLayout()
        CType(SpcPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SpcPhoto.Panel1.SuspendLayout()
        SpcPhoto.Panel2.SuspendLayout()
        SpcPhoto.SuspendLayout()
        CType(DgnPhoto, ComponentModel.ISupportInitialize).BeginInit()
        TlpPhotoButton.SuspendLayout()
        CType(PctbxActivityPhoto, ComponentModel.ISupportInitialize).BeginInit()
        TlpCopySave.SuspendLayout()
        TPFiles.SuspendLayout()
        CType(DgnFile, ComponentModel.ISupportInitialize).BeginInit()
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
        TxtFind.Margin = New Padding(5, 3, 5, 3)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(SpcContent)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(SpcContent, 0)
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
        SpcContent.Panel1.Controls.Add(DgnDARActivity)
        SpcContent.Panel1.Controls.Add(SttActivity)
        SpcContent.Panel1MinSize = 200
        ' 
        ' SpcContent.Panel2
        ' 
        SpcContent.Panel2.Controls.Add(TbctlAttachment)
        SpcContent.Panel2MinSize = 0
        SpcContent.Size = New Size(915, 511)
        SpcContent.SplitterDistance = 232
        SpcContent.SplitterWidth = 5
        SpcContent.TabIndex = 802
        ' 
        ' DgnDARActivity
        ' 
        DgnDARActivity.AllowUserToAddRows = False
        DgnDARActivity.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(194), CByte(196), CByte(117))
        DgnDARActivity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DgnDARActivity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgnDARActivity.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnDARActivity.BorderStyle = BorderStyle.None
        DgnDARActivity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnDARActivity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.YellowGreen
        DataGridViewCellStyle2.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgnDARActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgnDARActivity.ColumnHeadersHeight = 43
        DgnDARActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnDARActivity.Columns.AddRange(New DataGridViewColumn() {areaaffected_name, employeeactivity_time, employeeactivity_description, employee_nickname, employee_id, employeeactivity_id})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DgnDARActivity.DefaultCellStyle = DataGridViewCellStyle7
        DgnDARActivity.Dock = DockStyle.Fill
        DgnDARActivity.EnableHeadersVisualStyles = False
        DgnDARActivity.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnDARActivity.Location = New Point(0, 0)
        DgnDARActivity.Margin = New Padding(4, 3, 4, 3)
        DgnDARActivity.MultiSelect = False
        DgnDARActivity.Name = "DgnDARActivity"
        DgnDARActivity.ReadOnly = True
        DgnDARActivity.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.YellowGreen
        DataGridViewCellStyle8.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DgnDARActivity.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DgnDARActivity.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnDARActivity.Size = New Size(915, 210)
        DgnDARActivity.XOGroupFirstRows = True
        DgnDARActivity.XOGunakanNomorBaris = True
        DgnDARActivity.StandardTab = True
        DgnDARActivity.TabIndex = 102
        ' 
        ' areaaffected_name
        ' 
        areaaffected_name.DataPropertyName = "areaaffected_name"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        areaaffected_name.DefaultCellStyle = DataGridViewCellStyle3
        areaaffected_name.HeaderText = "Area"
        areaaffected_name.Name = "areaaffected_name"
        areaaffected_name.ReadOnly = True
        areaaffected_name.SortMode = DataGridViewColumnSortMode.Programmatic
        areaaffected_name.Width = 150
        ' 
        ' employeeactivity_time
        ' 
        employeeactivity_time.DataPropertyName = "employeeactivity_time"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft
        employeeactivity_time.DefaultCellStyle = DataGridViewCellStyle4
        employeeactivity_time.HeaderText = "Time"
        employeeactivity_time.Name = "employeeactivity_time"
        employeeactivity_time.ReadOnly = True
        employeeactivity_time.SortMode = DataGridViewColumnSortMode.Programmatic
        employeeactivity_time.Width = 150
        ' 
        ' employeeactivity_description
        ' 
        employeeactivity_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        employeeactivity_description.DataPropertyName = "employeeactivity_description"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft
        employeeactivity_description.DefaultCellStyle = DataGridViewCellStyle5
        employeeactivity_description.HeaderText = "Activity"
        employeeactivity_description.Name = "employeeactivity_description"
        employeeactivity_description.ReadOnly = True
        employeeactivity_description.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' employee_nickname
        ' 
        employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        employee_nickname.DataPropertyName = "employee_nickname"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter
        employee_nickname.DefaultCellStyle = DataGridViewCellStyle6
        employee_nickname.HeaderText = "Contrib."
        employee_nickname.Name = "employee_nickname"
        employee_nickname.ReadOnly = True
        employee_nickname.SortMode = DataGridViewColumnSortMode.Programmatic
        employee_nickname.Width = 76
        ' 
        ' employee_id
        ' 
        employee_id.DataPropertyName = "employee_id"
        employee_id.HeaderText = "Employee ID"
        employee_id.Name = "employee_id"
        employee_id.ReadOnly = True
        employee_id.SortMode = DataGridViewColumnSortMode.Programmatic
        employee_id.Visible = False
        ' 
        ' employeeactivity_id
        ' 
        employeeactivity_id.DataPropertyName = "employeeactivity_id"
        employeeactivity_id.HeaderText = "ID"
        employeeactivity_id.Name = "employeeactivity_id"
        employeeactivity_id.ReadOnly = True
        employeeactivity_id.SortMode = DataGridViewColumnSortMode.Programmatic
        employeeactivity_id.Visible = False
        ' 
        ' SttActivity
        ' 
        SttActivity.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        SttActivity.Location = New Point(0, 210)
        SttActivity.Name = "SttActivity"
        SttActivity.Padding = New Padding(1, 0, 16, 0)
        SttActivity.Size = New Size(915, 22)
        SttActivity.TabIndex = 103
        SttActivity.Text = "Stt1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(0, 17)
        ' 
        ' TbctlAttachment
        ' 
        TbctlAttachment.Controls.Add(TPPhotos)
        TbctlAttachment.Controls.Add(TPFiles)
        TbctlAttachment.Dock = DockStyle.Fill
        TbctlAttachment.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TbctlAttachment.Location = New Point(0, 0)
        TbctlAttachment.Margin = New Padding(4, 3, 4, 3)
        TbctlAttachment.Name = "TbctlAttachment"
        TbctlAttachment.SelectedIndex = 0
        TbctlAttachment.Size = New Size(915, 274)
        TbctlAttachment.TabIndex = 0
        ' 
        ' TPPhotos
        ' 
        TPPhotos.Controls.Add(SpcPhoto)
        TPPhotos.Location = New Point(4, 30)
        TPPhotos.Margin = New Padding(4, 3, 4, 3)
        TPPhotos.Name = "TPPhotos"
        TPPhotos.Padding = New Padding(4, 3, 4, 3)
        TPPhotos.Size = New Size(907, 240)
        TPPhotos.TabIndex = 0
        TPPhotos.Text = "Photos"
        TPPhotos.UseVisualStyleBackColor = True
        ' 
        ' SpcPhoto
        ' 
        SpcPhoto.Dock = DockStyle.Fill
        SpcPhoto.Location = New Point(4, 3)
        SpcPhoto.Margin = New Padding(4, 3, 4, 3)
        SpcPhoto.Name = "SpcPhoto"
        ' 
        ' SpcPhoto.Panel1
        ' 
        SpcPhoto.Panel1.Controls.Add(DgnPhoto)
        ' 
        ' SpcPhoto.Panel2
        ' 
        SpcPhoto.Panel2.Controls.Add(TlpPhotoButton)
        SpcPhoto.Panel2MinSize = 300
        SpcPhoto.Size = New Size(899, 234)
        SpcPhoto.SplitterDistance = 371
        SpcPhoto.SplitterWidth = 7
        SpcPhoto.TabIndex = 2
        ' 
        ' DgnPhoto
        ' 
        DgnPhoto.AllowUserToAddRows = False
        DgnPhoto.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(245), CByte(231), CByte(182))
        DgnPhoto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DgnPhoto.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnPhoto.BorderStyle = BorderStyle.None
        DgnPhoto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnPhoto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.YellowGreen
        DataGridViewCellStyle10.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle10.SelectionForeColor = Color.Black
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DgnPhoto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DgnPhoto.ColumnHeadersHeight = 43
        DgnPhoto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnPhoto.Columns.AddRange(New DataGridViewColumn() {photo_id, photo_content, photo_uploader_nickname, photo_content_size, photo_score, photo_datetime, photo_uploader, photo_employee_fullname, photo_view})
        DgnPhoto.Dock = DockStyle.Fill
        DgnPhoto.EnableHeadersVisualStyles = False
        DgnPhoto.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnPhoto.Location = New Point(0, 0)
        DgnPhoto.Margin = New Padding(4, 3, 4, 3)
        DgnPhoto.MultiSelect = False
        DgnPhoto.Name = "DgnPhoto"
        DgnPhoto.ReadOnly = True
        DgnPhoto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.YellowGreen
        DataGridViewCellStyle12.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle12.SelectionForeColor = Color.Black
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DgnPhoto.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DgnPhoto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnPhoto.Size = New Size(371, 234)
        DgnPhoto.XOGroupFirstRows = False
        DgnPhoto.XOGunakanNomorBaris = True
        DgnPhoto.StandardTab = True
        DgnPhoto.TabIndex = 2
        ' 
        ' photo_id
        ' 
        photo_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        photo_id.DataPropertyName = "file_id"
        photo_id.HeaderText = "File ID"
        photo_id.Name = "photo_id"
        photo_id.ReadOnly = True
        photo_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' photo_content
        ' 
        photo_content.DataPropertyName = "file_content"
        photo_content.HeaderText = "Photo"
        photo_content.ImageLayout = DataGridViewImageCellLayout.Zoom
        photo_content.Name = "photo_content"
        photo_content.ReadOnly = True
        photo_content.Resizable = DataGridViewTriState.True
        photo_content.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_content.Visible = False
        ' 
        ' photo_uploader_nickname
        ' 
        photo_uploader_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo_uploader_nickname.DataPropertyName = "employee_nickname"
        photo_uploader_nickname.HeaderText = "Uploader"
        photo_uploader_nickname.Name = "photo_uploader_nickname"
        photo_uploader_nickname.ReadOnly = True
        photo_uploader_nickname.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_uploader_nickname.Width = 81
        ' 
        ' photo_content_size
        ' 
        photo_content_size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo_content_size.DataPropertyName = "file_content_size"
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleRight
        photo_content_size.DefaultCellStyle = DataGridViewCellStyle11
        photo_content_size.HeaderText = "Size"
        photo_content_size.Name = "photo_content_size"
        photo_content_size.ReadOnly = True
        photo_content_size.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_content_size.Width = 54
        ' 
        ' photo_score
        ' 
        photo_score.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo_score.DataPropertyName = "file_score"
        photo_score.HeaderText = ""
        photo_score.Name = "photo_score"
        photo_score.ReadOnly = True
        photo_score.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_score.Width = 17
        ' 
        ' photo_datetime
        ' 
        photo_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo_datetime.DataPropertyName = "file_datetime"
        photo_datetime.HeaderText = "Date Time"
        photo_datetime.Name = "photo_datetime"
        photo_datetime.ReadOnly = True
        photo_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_datetime.Width = 82
        ' 
        ' photo_uploader
        ' 
        photo_uploader.DataPropertyName = "file_uploader"
        photo_uploader.HeaderText = "Uploader ID"
        photo_uploader.Name = "photo_uploader"
        photo_uploader.ReadOnly = True
        photo_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_uploader.Visible = False
        ' 
        ' photo_employee_fullname
        ' 
        photo_employee_fullname.DataPropertyName = "employee_fullname"
        photo_employee_fullname.HeaderText = "Emp. Full Name"
        photo_employee_fullname.Name = "photo_employee_fullname"
        photo_employee_fullname.ReadOnly = True
        photo_employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_employee_fullname.Visible = False
        ' 
        ' photo_view
        ' 
        photo_view.DataPropertyName = "file_view"
        photo_view.HeaderText = ""
        photo_view.Name = "photo_view"
        photo_view.ReadOnly = True
        photo_view.SortMode = DataGridViewColumnSortMode.Programmatic
        photo_view.Text = "▶"
        photo_view.ToolTipText = "View Photo"
        photo_view.UseColumnTextForButtonValue = True
        photo_view.Width = 20
        ' 
        ' TlpPhotoButton
        ' 
        TlpPhotoButton.ColumnCount = 1
        TlpPhotoButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TlpPhotoButton.Controls.Add(PctbxActivityPhoto, 0, 0)
        TlpPhotoButton.Controls.Add(TlpCopySave, 0, 1)
        TlpPhotoButton.Dock = DockStyle.Fill
        TlpPhotoButton.Location = New Point(0, 0)
        TlpPhotoButton.Margin = New Padding(4, 3, 4, 3)
        TlpPhotoButton.Name = "TlpPhotoButton"
        TlpPhotoButton.RowCount = 2
        TlpPhotoButton.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TlpPhotoButton.RowStyles.Add(New RowStyle(SizeType.Absolute, 42F))
        TlpPhotoButton.Size = New Size(521, 234)
        TlpPhotoButton.TabIndex = 0
        ' 
        ' PctbxActivityPhoto
        ' 
        PctbxActivityPhoto.BackColor = Color.DarkSlateGray
        PctbxActivityPhoto.BackgroundImage = My.Resources.Resources.PCTPRV_001_512_icon
        PctbxActivityPhoto.BackgroundImageLayout = ImageLayout.Zoom
        PctbxActivityPhoto.Dock = DockStyle.Fill
        PctbxActivityPhoto.ErrorImage = CType(resources.GetObject("PctbxActivityPhoto.ErrorImage"), Image)
        PctbxActivityPhoto.InitialImage = CType(resources.GetObject("PctbxActivityPhoto.InitialImage"), Image)
        PctbxActivityPhoto.Location = New Point(4, 3)
        PctbxActivityPhoto.Margin = New Padding(4, 3, 4, 3)
        PctbxActivityPhoto.Name = "PctbxActivityPhoto"
        PctbxActivityPhoto.Size = New Size(513, 186)
        PctbxActivityPhoto.SizeMode = PictureBoxSizeMode.Zoom
        PctbxActivityPhoto.XOTampilkanBorder = False
        PctbxActivityPhoto.XOWarnaBorder = Color.DarkSlateBlue
        PctbxActivityPhoto.TabIndex = 105
        PctbxActivityPhoto.TabStop = False
        ' 
        ' TlpCopySave
        ' 
        TlpCopySave.ColumnCount = 3
        TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 23F))
        TlpCopySave.Controls.Add(BtnCopyPhoto, 0, 0)
        TlpCopySave.Controls.Add(BtnSave, 2, 0)
        TlpCopySave.Controls.Add(BtnLike, 1, 0)
        TlpCopySave.Dock = DockStyle.Fill
        TlpCopySave.Location = New Point(4, 195)
        TlpCopySave.Margin = New Padding(4, 3, 4, 3)
        TlpCopySave.Name = "TlpCopySave"
        TlpCopySave.RowCount = 1
        TlpCopySave.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TlpCopySave.Size = New Size(513, 36)
        TlpCopySave.TabIndex = 106
        ' 
        ' BtnCopyPhoto
        ' 
        BtnCopyPhoto.BackColor = Color.OrangeRed
        BtnCopyPhoto.Cursor = Cursors.Hand
        BtnCopyPhoto.Dock = DockStyle.Fill
        BtnCopyPhoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(9), CByte(0))
        BtnCopyPhoto.FlatAppearance.BorderSize = 2
        BtnCopyPhoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(89), CByte(20))
        BtnCopyPhoto.FlatStyle = FlatStyle.Flat
        BtnCopyPhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCopyPhoto.ForeColor = Color.White
        BtnCopyPhoto.Image = My.Resources.Resources.Copy_001_16_FFFFFFFF_
        BtnCopyPhoto.Location = New Point(4, 3)
        BtnCopyPhoto.Margin = New Padding(4, 3, 4, 3)
        BtnCopyPhoto.Name = "BtnCopyPhoto"
        BtnCopyPhoto.Size = New Size(228, 30)
        BtnCopyPhoto.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnCopyPhoto.XOTampilkanFocusBorder = False
        BtnCopyPhoto.XOValidasiSemuaInput = False
        BtnCopyPhoto.XOValidasiSemuaInputTag = Nothing
        BtnCopyPhoto.TabIndex = 3
        BtnCopyPhoto.UseVisualStyleBackColor = False
        ' 
        ' BtnSave
        ' 
        BtnSave.BackColor = Color.DarkOrange
        BtnSave.Cursor = Cursors.Hand
        BtnSave.Dock = DockStyle.Fill
        BtnSave.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(80), CByte(0))
        BtnSave.FlatAppearance.BorderSize = 2
        BtnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(160), CByte(20))
        BtnSave.FlatStyle = FlatStyle.Flat
        BtnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSave.ForeColor = Color.White
        BtnSave.Image = My.Resources.Resources.SaveAs_001_16_FFFFFFFF_
        BtnSave.Location = New Point(280, 3)
        BtnSave.Margin = New Padding(4, 3, 4, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(229, 30)
        BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnSave.XOTampilkanFocusBorder = False
        BtnSave.XOValidasiSemuaInput = False
        BtnSave.XOValidasiSemuaInputTag = Nothing
        BtnSave.TabIndex = 4
        BtnSave.UseVisualStyleBackColor = False
        ' 
        ' BtnLike
        ' 
        BtnLike.BackColor = Color.Black
        BtnLike.Cursor = Cursors.Hand
        BtnLike.Dock = DockStyle.Fill
        BtnLike.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(0))
        BtnLike.FlatAppearance.BorderSize = 2
        BtnLike.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        BtnLike.FlatStyle = FlatStyle.Flat
        BtnLike.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLike.ForeColor = Color.White
        BtnLike.Image = My.Resources.Resources.Like_001_16__FFFC0000_
        BtnLike.Location = New Point(240, 3)
        BtnLike.Margin = New Padding(4, 3, 4, 3)
        BtnLike.Name = "BtnLike"
        BtnLike.Size = New Size(32, 30)
        BtnLike.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
        BtnLike.XOTampilkanFocusBorder = False
        BtnLike.XOValidasiSemuaInput = False
        BtnLike.XOValidasiSemuaInputTag = Nothing
        BtnLike.TabIndex = 6
        BtnLike.UseVisualStyleBackColor = False
        ' 
        ' TPFiles
        ' 
        TPFiles.Controls.Add(DgnFile)
        TPFiles.Location = New Point(4, 30)
        TPFiles.Margin = New Padding(4, 3, 4, 3)
        TPFiles.Name = "TPFiles"
        TPFiles.Padding = New Padding(4, 3, 4, 3)
        TPFiles.Size = New Size(907, 240)
        TPFiles.TabIndex = 1
        TPFiles.Text = "PDF"
        TPFiles.UseVisualStyleBackColor = True
        ' 
        ' DgnFile
        ' 
        DgnFile.AllowUserToAddRows = False
        DgnFile.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = Color.FromArgb(CByte(248), CByte(220), CByte(132))
        DgnFile.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        DgnFile.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DgnFile.BorderStyle = BorderStyle.None
        DgnFile.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DgnFile.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = Color.YellowGreen
        DataGridViewCellStyle14.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle14.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = Color.YellowGreen
        DataGridViewCellStyle14.SelectionForeColor = Color.Black
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
        DgnFile.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        DgnFile.ColumnHeadersHeight = 43
        DgnFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgnFile.Columns.AddRange(New DataGridViewColumn() {file_id, file_tag, file_content, file_employee_nickname, file_content_size, file_score, file_datetime, file_uploader, file_employee_fullname, file_view})
        DgnFile.Dock = DockStyle.Fill
        DgnFile.EnableHeadersVisualStyles = False
        DgnFile.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DgnFile.Location = New Point(4, 3)
        DgnFile.Margin = New Padding(4, 3, 4, 3)
        DgnFile.MultiSelect = False
        DgnFile.Name = "DgnFile"
        DgnFile.ReadOnly = True
        DgnFile.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = Color.YellowGreen
        DataGridViewCellStyle16.Font = New Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = Color.Yellow
        DataGridViewCellStyle16.SelectionForeColor = Color.Black
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
        DgnFile.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        DgnFile.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgnFile.Size = New Size(899, 234)
        DgnFile.XOGroupFirstRows = False
        DgnFile.XOGunakanNomorBaris = True
        DgnFile.StandardTab = True
        DgnFile.TabIndex = 3
        ' 
        ' file_id
        ' 
        file_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        file_id.DataPropertyName = "file_id"
        file_id.HeaderText = "File ID"
        file_id.Name = "file_id"
        file_id.ReadOnly = True
        file_id.SortMode = DataGridViewColumnSortMode.Programmatic
        ' 
        ' file_tag
        ' 
        file_tag.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        file_tag.DataPropertyName = "file_tag"
        file_tag.HeaderText = "Tag"
        file_tag.Name = "file_tag"
        file_tag.ReadOnly = True
        file_tag.SortMode = DataGridViewColumnSortMode.Programmatic
        file_tag.Width = 50
        ' 
        ' file_content
        ' 
        file_content.DataPropertyName = "file_content"
        file_content.HeaderText = "Photo"
        file_content.Name = "file_content"
        file_content.ReadOnly = True
        file_content.Resizable = DataGridViewTriState.True
        file_content.SortMode = DataGridViewColumnSortMode.Programmatic
        file_content.Visible = False
        ' 
        ' file_employee_nickname
        ' 
        file_employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_employee_nickname.DataPropertyName = "employee_nickname"
        file_employee_nickname.HeaderText = "Uploader"
        file_employee_nickname.Name = "file_employee_nickname"
        file_employee_nickname.ReadOnly = True
        file_employee_nickname.SortMode = DataGridViewColumnSortMode.Programmatic
        file_employee_nickname.Width = 81
        ' 
        ' file_content_size
        ' 
        file_content_size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_content_size.DataPropertyName = "file_content_size"
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight
        file_content_size.DefaultCellStyle = DataGridViewCellStyle15
        file_content_size.HeaderText = "Size"
        file_content_size.Name = "file_content_size"
        file_content_size.ReadOnly = True
        file_content_size.SortMode = DataGridViewColumnSortMode.Programmatic
        file_content_size.Width = 54
        ' 
        ' file_score
        ' 
        file_score.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_score.DataPropertyName = "file_score"
        file_score.HeaderText = ""
        file_score.Name = "file_score"
        file_score.ReadOnly = True
        file_score.SortMode = DataGridViewColumnSortMode.Programmatic
        file_score.Width = 17
        ' 
        ' file_datetime
        ' 
        file_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        file_datetime.DataPropertyName = "file_datetime"
        file_datetime.HeaderText = "Date Time"
        file_datetime.Name = "file_datetime"
        file_datetime.ReadOnly = True
        file_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
        file_datetime.Width = 82
        ' 
        ' file_uploader
        ' 
        file_uploader.DataPropertyName = "file_uploader"
        file_uploader.HeaderText = "Uploader ID"
        file_uploader.Name = "file_uploader"
        file_uploader.ReadOnly = True
        file_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
        file_uploader.Visible = False
        ' 
        ' file_employee_fullname
        ' 
        file_employee_fullname.DataPropertyName = "employee_fullname"
        file_employee_fullname.HeaderText = "Emp. Full Name"
        file_employee_fullname.Name = "file_employee_fullname"
        file_employee_fullname.ReadOnly = True
        file_employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
        file_employee_fullname.Visible = False
        ' 
        ' file_view
        ' 
        file_view.DataPropertyName = "file_view"
        file_view.HeaderText = ""
        file_view.Name = "file_view"
        file_view.ReadOnly = True
        file_view.Text = "▶"
        file_view.ToolTipText = "View PDF"
        file_view.UseColumnTextForButtonValue = True
        file_view.Width = 20
        ' 
        ' PEPR
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        ClientSize = New Size(915, 647)
        KeyPreview = True
        Margin = New Padding(7, 3, 7, 3)
        Name = "PEPR"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        SpcContent.Panel1.ResumeLayout(False)
        SpcContent.Panel1.PerformLayout()
        SpcContent.Panel2.ResumeLayout(False)
        CType(SpcContent, ComponentModel.ISupportInitialize).EndInit()
        SpcContent.ResumeLayout(False)
        CType(DgnDARActivity, ComponentModel.ISupportInitialize).EndInit()
        SttActivity.ResumeLayout(False)
        SttActivity.PerformLayout()
        TbctlAttachment.ResumeLayout(False)
        TPPhotos.ResumeLayout(False)
        SpcPhoto.Panel1.ResumeLayout(False)
        SpcPhoto.Panel2.ResumeLayout(False)
        CType(SpcPhoto, ComponentModel.ISupportInitialize).EndInit()
        SpcPhoto.ResumeLayout(False)
        CType(DgnPhoto, ComponentModel.ISupportInitialize).EndInit()
        TlpPhotoButton.ResumeLayout(False)
        CType(PctbxActivityPhoto, ComponentModel.ISupportInitialize).EndInit()
        TlpCopySave.ResumeLayout(False)
        TPFiles.ResumeLayout(False)
        CType(DgnFile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SpcContent As spc
    Friend WithEvents DgnDARActivity As dgn
    Friend WithEvents areaaffected_name As DataGridViewTextBoxColumn
    Friend WithEvents employeeactivity_time As DataGridViewTextBoxColumn
    Friend WithEvents employeeactivity_description As DataGridViewTextBoxColumn
    Friend WithEvents employee_nickname As DataGridViewTextBoxColumn
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents employeeactivity_id As DataGridViewTextBoxColumn
    Friend WithEvents SttActivity As stt
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TbctlAttachment As tbctl
    Friend WithEvents TPPhotos As TabPage
    Friend WithEvents SpcPhoto As spc
    Friend WithEvents DgnPhoto As dgn
    Friend WithEvents photo_id As DataGridViewTextBoxColumn
    Friend WithEvents photo_content As DataGridViewImageColumn
    Friend WithEvents photo_uploader_nickname As DataGridViewTextBoxColumn
    Friend WithEvents photo_content_size As DataGridViewTextBoxColumn
    Friend WithEvents photo_score As DataGridViewTextBoxColumn
    Friend WithEvents photo_datetime As DataGridViewTextBoxColumn
    Friend WithEvents photo_uploader As DataGridViewTextBoxColumn
    Friend WithEvents photo_employee_fullname As DataGridViewTextBoxColumn
    Friend WithEvents photo_view As DataGridViewButtonColumn
    Friend WithEvents TlpPhotoButton As TableLayoutPanel
    Friend WithEvents PctbxActivityPhoto As pctbx
    Friend WithEvents TlpCopySave As TableLayoutPanel
    Friend WithEvents BtnCopyPhoto As btn
    Friend WithEvents BtnSave As btn
    Friend WithEvents BtnLike As btn
    Friend WithEvents TPFiles As TabPage
    Friend WithEvents DgnFile As dgn
    Friend WithEvents file_id As DataGridViewTextBoxColumn
    Friend WithEvents file_tag As DataGridViewTextBoxColumn
    Friend WithEvents file_content As DataGridViewTextBoxColumn
    Friend WithEvents file_employee_nickname As DataGridViewTextBoxColumn
    Friend WithEvents file_content_size As DataGridViewTextBoxColumn
    Friend WithEvents file_score As DataGridViewTextBoxColumn
    Friend WithEvents file_datetime As DataGridViewTextBoxColumn
    Friend WithEvents file_uploader As DataGridViewTextBoxColumn
    Friend WithEvents file_employee_fullname As DataGridViewTextBoxColumn
    Friend WithEvents file_view As DataGridViewButtonColumn
End Class
