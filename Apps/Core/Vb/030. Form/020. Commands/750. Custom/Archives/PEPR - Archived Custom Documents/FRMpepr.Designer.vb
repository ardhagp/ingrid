Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMpepr
        Inherits CMCv.Std_Fi

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
            Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle25 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle26 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle27 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMpepr))
            Dim DataGridViewCellStyle29 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle30 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle32 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle31 As DataGridViewCellStyle = New DataGridViewCellStyle()
            SpcContent = New CMCv.UI.Control.spc(components)
            DgnDARActivity = New CMCv.UI.Control.dgn(components)
            areaaffected_name = New DataGridViewTextBoxColumn()
            employeeactivity_time = New DataGridViewTextBoxColumn()
            employeeactivity_description = New DataGridViewTextBoxColumn()
            employee_nickname = New DataGridViewTextBoxColumn()
            employee_id = New DataGridViewTextBoxColumn()
            employeeactivity_id = New DataGridViewTextBoxColumn()
            SttActivity = New CMCv.UI.Control.stt(components)
            ToolStripStatusLabel1 = New ToolStripStatusLabel()
            TbctlAttachment = New CMCv.UI.Control.tbctl(components)
            TPPhotos = New TabPage()
            SpcPhoto = New CMCv.UI.Control.spc(components)
            DgnPhoto = New CMCv.UI.Control.dgn(components)
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
            PctbxActivityPhoto = New CMCv.UI.Control.pctbx(components)
            TlpCopySave = New TableLayoutPanel()
            BtnCopyPhoto = New CMCv.UI.Control.btn(components)
            BtnSave = New CMCv.UI.Control.btn(components)
            BtnLike = New CMCv.UI.Control.btn(components)
            TPFiles = New TabPage()
            DgnFile = New CMCv.UI.Control.dgn(components)
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
            TxtFind.Margin = New Padding(7, 5, 7, 5)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(SpcContent)
            SLFPanel.Size = New Size(1307, 952)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(SpcContent, 0)
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
            SpcContent.Panel1.Controls.Add(DgnDARActivity)
            SpcContent.Panel1.Controls.Add(SttActivity)
            SpcContent.Panel1MinSize = 200
            ' 
            ' SpcContent.Panel2
            ' 
            SpcContent.Panel2.Controls.Add(TbctlAttachment)
            SpcContent.Panel2MinSize = 0
            SpcContent.Size = New Size(1307, 864)
            SpcContent.SplitterDistance = 392
            SpcContent.SplitterWidth = 8
            SpcContent.TabIndex = 802
            ' 
            ' DgnDARActivity
            ' 
            DgnDARActivity.AllowUserToAddRows = False
            DgnDARActivity.AllowUserToDeleteRows = False
            DataGridViewCellStyle17.BackColor = Color.FromArgb(CByte(223), CByte(222), CByte(164))
            DgnDARActivity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
            DgnDARActivity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DgnDARActivity.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnDARActivity.BorderStyle = BorderStyle.None
            DgnDARActivity.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnDARActivity.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle18.BackColor = Color.YellowGreen
            DataGridViewCellStyle18.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle18.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle18.SelectionForeColor = Color.Black
            DataGridViewCellStyle18.WrapMode = DataGridViewTriState.True
            DgnDARActivity.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
            DgnDARActivity.ColumnHeadersHeight = 43
            DgnDARActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnDARActivity.Columns.AddRange(New DataGridViewColumn() {areaaffected_name, employeeactivity_time, employeeactivity_description, employee_nickname, employee_id, employeeactivity_id})
            DataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle23.BackColor = SystemColors.Window
            DataGridViewCellStyle23.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle23.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle23.WrapMode = DataGridViewTriState.True
            DgnDARActivity.DefaultCellStyle = DataGridViewCellStyle23
            DgnDARActivity.Dock = DockStyle.Fill
            DgnDARActivity.EnableHeadersVisualStyles = False
            DgnDARActivity.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnDARActivity.Location = New Point(0, 0)
            DgnDARActivity.Margin = New Padding(6, 5, 6, 5)
            DgnDARActivity.MultiSelect = False
            DgnDARActivity.Name = "DgnDARActivity"
            DgnDARActivity.ReadOnly = True
            DgnDARActivity.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle24.BackColor = Color.YellowGreen
            DataGridViewCellStyle24.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle24.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle24.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle24.SelectionForeColor = Color.Black
            DataGridViewCellStyle24.WrapMode = DataGridViewTriState.True
            DgnDARActivity.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
            DgnDARActivity.RowHeadersWidth = 62
            DgnDARActivity.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnDARActivity.Size = New Size(1307, 370)
            DgnDARActivity.StandardTab = True
            DgnDARActivity.TabIndex = 102
            DgnDARActivity.XOGroupFirstRows = True
            DgnDARActivity.XOGunakanNomorBaris = True
            ' 
            ' areaaffected_name
            ' 
            areaaffected_name.DataPropertyName = "areaaffected_name"
            DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.TopLeft
            DataGridViewCellStyle19.WrapMode = DataGridViewTriState.True
            areaaffected_name.DefaultCellStyle = DataGridViewCellStyle19
            areaaffected_name.HeaderText = "Area"
            areaaffected_name.MinimumWidth = 8
            areaaffected_name.Name = "areaaffected_name"
            areaaffected_name.ReadOnly = True
            areaaffected_name.SortMode = DataGridViewColumnSortMode.Programmatic
            areaaffected_name.Width = 150
            ' 
            ' employeeactivity_time
            ' 
            employeeactivity_time.DataPropertyName = "employeeactivity_time"
            DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.TopLeft
            employeeactivity_time.DefaultCellStyle = DataGridViewCellStyle20
            employeeactivity_time.HeaderText = "Time"
            employeeactivity_time.MinimumWidth = 8
            employeeactivity_time.Name = "employeeactivity_time"
            employeeactivity_time.ReadOnly = True
            employeeactivity_time.SortMode = DataGridViewColumnSortMode.Programmatic
            employeeactivity_time.Width = 150
            ' 
            ' employeeactivity_description
            ' 
            employeeactivity_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            employeeactivity_description.DataPropertyName = "employeeactivity_description"
            DataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.TopLeft
            employeeactivity_description.DefaultCellStyle = DataGridViewCellStyle21
            employeeactivity_description.HeaderText = "Activity"
            employeeactivity_description.MinimumWidth = 8
            employeeactivity_description.Name = "employeeactivity_description"
            employeeactivity_description.ReadOnly = True
            employeeactivity_description.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' employee_nickname
            ' 
            employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            employee_nickname.DataPropertyName = "employee_nickname"
            DataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.TopCenter
            employee_nickname.DefaultCellStyle = DataGridViewCellStyle22
            employee_nickname.HeaderText = "Contrib."
            employee_nickname.MinimumWidth = 8
            employee_nickname.Name = "employee_nickname"
            employee_nickname.ReadOnly = True
            employee_nickname.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_nickname.Width = 107
            ' 
            ' employee_id
            ' 
            employee_id.DataPropertyName = "employee_id"
            employee_id.HeaderText = "Employee ID"
            employee_id.MinimumWidth = 8
            employee_id.Name = "employee_id"
            employee_id.ReadOnly = True
            employee_id.SortMode = DataGridViewColumnSortMode.Programmatic
            employee_id.Visible = False
            employee_id.Width = 150
            ' 
            ' employeeactivity_id
            ' 
            employeeactivity_id.DataPropertyName = "employeeactivity_id"
            employeeactivity_id.HeaderText = "ID"
            employeeactivity_id.MinimumWidth = 8
            employeeactivity_id.Name = "employeeactivity_id"
            employeeactivity_id.ReadOnly = True
            employeeactivity_id.SortMode = DataGridViewColumnSortMode.Programmatic
            employeeactivity_id.Visible = False
            employeeactivity_id.Width = 150
            ' 
            ' SttActivity
            ' 
            SttActivity.ImageScalingSize = New Size(24, 24)
            SttActivity.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
            SttActivity.Location = New Point(0, 370)
            SttActivity.Name = "SttActivity"
            SttActivity.Padding = New Padding(1, 0, 23, 0)
            SttActivity.Size = New Size(1307, 22)
            SttActivity.TabIndex = 103
            SttActivity.Text = "Stt1"
            ' 
            ' ToolStripStatusLabel1
            ' 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
            ToolStripStatusLabel1.Size = New Size(0, 15)
            ' 
            ' TbctlAttachment
            ' 
            TbctlAttachment.Controls.Add(TPPhotos)
            TbctlAttachment.Controls.Add(TPFiles)
            TbctlAttachment.Dock = DockStyle.Fill
            TbctlAttachment.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            TbctlAttachment.Location = New Point(0, 0)
            TbctlAttachment.Margin = New Padding(6, 5, 6, 5)
            TbctlAttachment.Name = "TbctlAttachment"
            TbctlAttachment.SelectedIndex = 0
            TbctlAttachment.Size = New Size(1307, 464)
            TbctlAttachment.TabIndex = 0
            ' 
            ' TPPhotos
            ' 
            TPPhotos.Controls.Add(SpcPhoto)
            TPPhotos.Location = New Point(4, 41)
            TPPhotos.Margin = New Padding(6, 5, 6, 5)
            TPPhotos.Name = "TPPhotos"
            TPPhotos.Padding = New Padding(6, 5, 6, 5)
            TPPhotos.Size = New Size(1299, 419)
            TPPhotos.TabIndex = 0
            TPPhotos.Text = "Photos"
            TPPhotos.UseVisualStyleBackColor = True
            ' 
            ' SpcPhoto
            ' 
            SpcPhoto.Dock = DockStyle.Fill
            SpcPhoto.Location = New Point(6, 5)
            SpcPhoto.Margin = New Padding(6, 5, 6, 5)
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
            SpcPhoto.Size = New Size(1287, 409)
            SpcPhoto.SplitterDistance = 531
            SpcPhoto.SplitterWidth = 10
            SpcPhoto.TabIndex = 2
            ' 
            ' DgnPhoto
            ' 
            DgnPhoto.AllowUserToAddRows = False
            DgnPhoto.AllowUserToDeleteRows = False
            DataGridViewCellStyle25.BackColor = Color.FromArgb(CByte(201), CByte(236), CByte(155))
            DgnPhoto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
            DgnPhoto.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnPhoto.BorderStyle = BorderStyle.None
            DgnPhoto.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnPhoto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle26.BackColor = Color.YellowGreen
            DataGridViewCellStyle26.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle26.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle26.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle26.SelectionForeColor = Color.Black
            DataGridViewCellStyle26.WrapMode = DataGridViewTriState.True
            DgnPhoto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
            DgnPhoto.ColumnHeadersHeight = 43
            DgnPhoto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnPhoto.Columns.AddRange(New DataGridViewColumn() {photo_id, photo_content, photo_uploader_nickname, photo_content_size, photo_score, photo_datetime, photo_uploader, photo_employee_fullname, photo_view})
            DgnPhoto.Dock = DockStyle.Fill
            DgnPhoto.EnableHeadersVisualStyles = False
            DgnPhoto.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnPhoto.Location = New Point(0, 0)
            DgnPhoto.Margin = New Padding(6, 5, 6, 5)
            DgnPhoto.MultiSelect = False
            DgnPhoto.Name = "DgnPhoto"
            DgnPhoto.ReadOnly = True
            DgnPhoto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle28.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle28.BackColor = Color.YellowGreen
            DataGridViewCellStyle28.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle28.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle28.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle28.SelectionForeColor = Color.Black
            DataGridViewCellStyle28.WrapMode = DataGridViewTriState.True
            DgnPhoto.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
            DgnPhoto.RowHeadersWidth = 62
            DgnPhoto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnPhoto.Size = New Size(531, 409)
            DgnPhoto.StandardTab = True
            DgnPhoto.TabIndex = 2
            DgnPhoto.XOGroupFirstRows = False
            DgnPhoto.XOGunakanNomorBaris = True
            ' 
            ' photo_id
            ' 
            photo_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            photo_id.DataPropertyName = "file_id"
            photo_id.HeaderText = "File ID"
            photo_id.MinimumWidth = 8
            photo_id.Name = "photo_id"
            photo_id.ReadOnly = True
            photo_id.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' photo_content
            ' 
            photo_content.DataPropertyName = "file_content"
            photo_content.HeaderText = "Photo"
            photo_content.ImageLayout = DataGridViewImageCellLayout.Zoom
            photo_content.MinimumWidth = 8
            photo_content.Name = "photo_content"
            photo_content.ReadOnly = True
            photo_content.Resizable = DataGridViewTriState.True
            photo_content.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_content.Visible = False
            photo_content.Width = 150
            ' 
            ' photo_uploader_nickname
            ' 
            photo_uploader_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            photo_uploader_nickname.DataPropertyName = "employee_nickname"
            photo_uploader_nickname.HeaderText = "Uploader"
            photo_uploader_nickname.MinimumWidth = 8
            photo_uploader_nickname.Name = "photo_uploader_nickname"
            photo_uploader_nickname.ReadOnly = True
            photo_uploader_nickname.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_uploader_nickname.Width = 115
            ' 
            ' photo_content_size
            ' 
            photo_content_size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            photo_content_size.DataPropertyName = "file_content_size"
            DataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleRight
            photo_content_size.DefaultCellStyle = DataGridViewCellStyle27
            photo_content_size.HeaderText = "Size"
            photo_content_size.MinimumWidth = 8
            photo_content_size.Name = "photo_content_size"
            photo_content_size.ReadOnly = True
            photo_content_size.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_content_size.Width = 76
            ' 
            ' photo_score
            ' 
            photo_score.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            photo_score.DataPropertyName = "file_score"
            photo_score.HeaderText = ""
            photo_score.MinimumWidth = 8
            photo_score.Name = "photo_score"
            photo_score.ReadOnly = True
            photo_score.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_score.Width = 27
            ' 
            ' photo_datetime
            ' 
            photo_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            photo_datetime.DataPropertyName = "file_datetime"
            photo_datetime.HeaderText = "Date Time"
            photo_datetime.MinimumWidth = 8
            photo_datetime.Name = "photo_datetime"
            photo_datetime.ReadOnly = True
            photo_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_datetime.Width = 117
            ' 
            ' photo_uploader
            ' 
            photo_uploader.DataPropertyName = "file_uploader"
            photo_uploader.HeaderText = "Uploader ID"
            photo_uploader.MinimumWidth = 8
            photo_uploader.Name = "photo_uploader"
            photo_uploader.ReadOnly = True
            photo_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_uploader.Visible = False
            photo_uploader.Width = 150
            ' 
            ' photo_employee_fullname
            ' 
            photo_employee_fullname.DataPropertyName = "employee_fullname"
            photo_employee_fullname.HeaderText = "Emp. Full Name"
            photo_employee_fullname.MinimumWidth = 8
            photo_employee_fullname.Name = "photo_employee_fullname"
            photo_employee_fullname.ReadOnly = True
            photo_employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
            photo_employee_fullname.Visible = False
            photo_employee_fullname.Width = 150
            ' 
            ' photo_view
            ' 
            photo_view.DataPropertyName = "file_view"
            photo_view.HeaderText = ""
            photo_view.MinimumWidth = 8
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
            TlpPhotoButton.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
            TlpPhotoButton.Controls.Add(PctbxActivityPhoto, 0, 0)
            TlpPhotoButton.Controls.Add(TlpCopySave, 0, 1)
            TlpPhotoButton.Dock = DockStyle.Fill
            TlpPhotoButton.Location = New Point(0, 0)
            TlpPhotoButton.Margin = New Padding(6, 5, 6, 5)
            TlpPhotoButton.Name = "TlpPhotoButton"
            TlpPhotoButton.RowCount = 2
            TlpPhotoButton.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            TlpPhotoButton.RowStyles.Add(New RowStyle(SizeType.Absolute, 70.0F))
            TlpPhotoButton.Size = New Size(746, 409)
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
            PctbxActivityPhoto.Location = New Point(6, 5)
            PctbxActivityPhoto.Margin = New Padding(6, 5, 6, 5)
            PctbxActivityPhoto.Name = "PctbxActivityPhoto"
            PctbxActivityPhoto.Size = New Size(734, 329)
            PctbxActivityPhoto.SizeMode = PictureBoxSizeMode.Zoom
            PctbxActivityPhoto.TabIndex = 105
            PctbxActivityPhoto.TabStop = False
            PctbxActivityPhoto.XOTampilkanBorder = False
            PctbxActivityPhoto.XOWarnaBorder = Color.DarkSlateBlue
            ' 
            ' TlpCopySave
            ' 
            TlpCopySave.ColumnCount = 3
            TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 57.0F))
            TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
            TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 33.0F))
            TlpCopySave.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 33.0F))
            TlpCopySave.Controls.Add(BtnCopyPhoto, 0, 0)
            TlpCopySave.Controls.Add(BtnSave, 2, 0)
            TlpCopySave.Controls.Add(BtnLike, 1, 0)
            TlpCopySave.Dock = DockStyle.Fill
            TlpCopySave.Location = New Point(6, 344)
            TlpCopySave.Margin = New Padding(6, 5, 6, 5)
            TlpCopySave.Name = "TlpCopySave"
            TlpCopySave.RowCount = 1
            TlpCopySave.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            TlpCopySave.Size = New Size(734, 60)
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
            BtnCopyPhoto.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnCopyPhoto.ForeColor = Color.White
            BtnCopyPhoto.Image = My.Resources.Resources.Copy_001_16_FFFFFFFF_
            BtnCopyPhoto.Location = New Point(6, 5)
            BtnCopyPhoto.Margin = New Padding(6, 5, 6, 5)
            BtnCopyPhoto.Name = "BtnCopyPhoto"
            BtnCopyPhoto.Size = New Size(326, 50)
            BtnCopyPhoto.TabIndex = 3
            BtnCopyPhoto.UseVisualStyleBackColor = False
            BtnCopyPhoto.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
            BtnCopyPhoto.XOTampilkanFocusBorder = False
            BtnCopyPhoto.XOValidasiSemuaInput = False
            BtnCopyPhoto.XOValidasiSemuaInputTag = Nothing
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
            BtnSave.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnSave.ForeColor = Color.White
            BtnSave.Image = My.Resources.Resources.SaveAs_001_16_FFFFFFFF_
            BtnSave.Location = New Point(401, 5)
            BtnSave.Margin = New Padding(6, 5, 6, 5)
            BtnSave.Name = "BtnSave"
            BtnSave.Size = New Size(327, 50)
            BtnSave.TabIndex = 4
            BtnSave.UseVisualStyleBackColor = False
            BtnSave.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
            BtnSave.XOTampilkanFocusBorder = False
            BtnSave.XOValidasiSemuaInput = False
            BtnSave.XOValidasiSemuaInputTag = Nothing
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
            BtnLike.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnLike.ForeColor = Color.White
            BtnLike.Image = My.Resources.Resources.Like_001_16__FFFC0000_
            BtnLike.Location = New Point(344, 5)
            BtnLike.Margin = New Padding(6, 5, 6, 5)
            BtnLike.Name = "BtnLike"
            BtnLike.Size = New Size(45, 50)
            BtnLike.TabIndex = 6
            BtnLike.UseVisualStyleBackColor = False
            BtnLike.XOJenisTombol = ControlCodeBase.enuJenisTombol.Custom
            BtnLike.XOTampilkanFocusBorder = False
            BtnLike.XOValidasiSemuaInput = False
            BtnLike.XOValidasiSemuaInputTag = Nothing
            ' 
            ' TPFiles
            ' 
            TPFiles.Controls.Add(DgnFile)
            TPFiles.Location = New Point(4, 41)
            TPFiles.Margin = New Padding(6, 5, 6, 5)
            TPFiles.Name = "TPFiles"
            TPFiles.Padding = New Padding(6, 5, 6, 5)
            TPFiles.Size = New Size(1859, 735)
            TPFiles.TabIndex = 1
            TPFiles.Text = "PDF"
            TPFiles.UseVisualStyleBackColor = True
            ' 
            ' DgnFile
            ' 
            DgnFile.AllowUserToAddRows = False
            DgnFile.AllowUserToDeleteRows = False
            DataGridViewCellStyle29.BackColor = Color.FromArgb(CByte(254), CByte(194), CByte(95))
            DgnFile.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
            DgnFile.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnFile.BorderStyle = BorderStyle.None
            DgnFile.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnFile.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle30.BackColor = Color.YellowGreen
            DataGridViewCellStyle30.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle30.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle30.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle30.SelectionForeColor = Color.Black
            DataGridViewCellStyle30.WrapMode = DataGridViewTriState.True
            DgnFile.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
            DgnFile.ColumnHeadersHeight = 43
            DgnFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnFile.Columns.AddRange(New DataGridViewColumn() {file_id, file_tag, file_content, file_employee_nickname, file_content_size, file_score, file_datetime, file_uploader, file_employee_fullname, file_view})
            DgnFile.Dock = DockStyle.Fill
            DgnFile.EnableHeadersVisualStyles = False
            DgnFile.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnFile.Location = New Point(6, 5)
            DgnFile.Margin = New Padding(6, 5, 6, 5)
            DgnFile.MultiSelect = False
            DgnFile.Name = "DgnFile"
            DgnFile.ReadOnly = True
            DgnFile.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle32.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle32.BackColor = Color.YellowGreen
            DataGridViewCellStyle32.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle32.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle32.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle32.SelectionForeColor = Color.Black
            DataGridViewCellStyle32.WrapMode = DataGridViewTriState.True
            DgnFile.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
            DgnFile.RowHeadersWidth = 62
            DgnFile.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnFile.Size = New Size(1847, 725)
            DgnFile.StandardTab = True
            DgnFile.TabIndex = 3
            DgnFile.XOGroupFirstRows = False
            DgnFile.XOGunakanNomorBaris = True
            ' 
            ' file_id
            ' 
            file_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            file_id.DataPropertyName = "file_id"
            file_id.HeaderText = "File ID"
            file_id.MinimumWidth = 8
            file_id.Name = "file_id"
            file_id.ReadOnly = True
            file_id.SortMode = DataGridViewColumnSortMode.Programmatic
            ' 
            ' file_tag
            ' 
            file_tag.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            file_tag.DataPropertyName = "file_tag"
            file_tag.HeaderText = "Tag"
            file_tag.MinimumWidth = 8
            file_tag.Name = "file_tag"
            file_tag.ReadOnly = True
            file_tag.SortMode = DataGridViewColumnSortMode.Programmatic
            file_tag.Width = 70
            ' 
            ' file_content
            ' 
            file_content.DataPropertyName = "file_content"
            file_content.HeaderText = "Photo"
            file_content.MinimumWidth = 8
            file_content.Name = "file_content"
            file_content.ReadOnly = True
            file_content.Resizable = DataGridViewTriState.True
            file_content.SortMode = DataGridViewColumnSortMode.Programmatic
            file_content.Visible = False
            file_content.Width = 150
            ' 
            ' file_employee_nickname
            ' 
            file_employee_nickname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            file_employee_nickname.DataPropertyName = "employee_nickname"
            file_employee_nickname.HeaderText = "Uploader"
            file_employee_nickname.MinimumWidth = 8
            file_employee_nickname.Name = "file_employee_nickname"
            file_employee_nickname.ReadOnly = True
            file_employee_nickname.SortMode = DataGridViewColumnSortMode.Programmatic
            file_employee_nickname.Width = 115
            ' 
            ' file_content_size
            ' 
            file_content_size.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            file_content_size.DataPropertyName = "file_content_size"
            DataGridViewCellStyle31.Alignment = DataGridViewContentAlignment.MiddleRight
            file_content_size.DefaultCellStyle = DataGridViewCellStyle31
            file_content_size.HeaderText = "Size"
            file_content_size.MinimumWidth = 8
            file_content_size.Name = "file_content_size"
            file_content_size.ReadOnly = True
            file_content_size.SortMode = DataGridViewColumnSortMode.Programmatic
            file_content_size.Width = 76
            ' 
            ' file_score
            ' 
            file_score.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            file_score.DataPropertyName = "file_score"
            file_score.HeaderText = ""
            file_score.MinimumWidth = 8
            file_score.Name = "file_score"
            file_score.ReadOnly = True
            file_score.SortMode = DataGridViewColumnSortMode.Programmatic
            file_score.Width = 27
            ' 
            ' file_datetime
            ' 
            file_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            file_datetime.DataPropertyName = "file_datetime"
            file_datetime.HeaderText = "Date Time"
            file_datetime.MinimumWidth = 8
            file_datetime.Name = "file_datetime"
            file_datetime.ReadOnly = True
            file_datetime.SortMode = DataGridViewColumnSortMode.Programmatic
            file_datetime.Width = 117
            ' 
            ' file_uploader
            ' 
            file_uploader.DataPropertyName = "file_uploader"
            file_uploader.HeaderText = "Uploader ID"
            file_uploader.MinimumWidth = 8
            file_uploader.Name = "file_uploader"
            file_uploader.ReadOnly = True
            file_uploader.SortMode = DataGridViewColumnSortMode.Programmatic
            file_uploader.Visible = False
            file_uploader.Width = 150
            ' 
            ' file_employee_fullname
            ' 
            file_employee_fullname.DataPropertyName = "employee_fullname"
            file_employee_fullname.HeaderText = "Emp. Full Name"
            file_employee_fullname.MinimumWidth = 8
            file_employee_fullname.Name = "file_employee_fullname"
            file_employee_fullname.ReadOnly = True
            file_employee_fullname.SortMode = DataGridViewColumnSortMode.Programmatic
            file_employee_fullname.Visible = False
            file_employee_fullname.Width = 150
            ' 
            ' file_view
            ' 
            file_view.DataPropertyName = "file_view"
            file_view.HeaderText = ""
            file_view.MinimumWidth = 8
            file_view.Name = "file_view"
            file_view.ReadOnly = True
            file_view.Text = "▶"
            file_view.ToolTipText = "View PDF"
            file_view.UseColumnTextForButtonValue = True
            file_view.Width = 20
            ' 
            ' FRMpepr
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1307, 1078)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMpepr"
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

        Friend WithEvents SpcContent As CMCv.UI.Control.spc
        Friend WithEvents DgnDARActivity As CMCv.UI.Control.dgn
        Friend WithEvents areaaffected_name As DataGridViewTextBoxColumn
        Friend WithEvents employeeactivity_time As DataGridViewTextBoxColumn
        Friend WithEvents employeeactivity_description As DataGridViewTextBoxColumn
        Friend WithEvents employee_nickname As DataGridViewTextBoxColumn
        Friend WithEvents employee_id As DataGridViewTextBoxColumn
        Friend WithEvents employeeactivity_id As DataGridViewTextBoxColumn
        Friend WithEvents SttActivity As CMCv.UI.Control.stt
        Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
        Friend WithEvents TbctlAttachment As CMCv.UI.Control.tbctl
        Friend WithEvents TPPhotos As TabPage
        Friend WithEvents SpcPhoto As CMCv.UI.Control.spc
        Friend WithEvents DgnPhoto As CMCv.UI.Control.dgn
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
        Friend WithEvents PctbxActivityPhoto As CMCv.UI.Control.pctbx
        Friend WithEvents TlpCopySave As TableLayoutPanel
        Friend WithEvents BtnCopyPhoto As CMCv.UI.Control.btn
        Friend WithEvents BtnSave As CMCv.UI.Control.btn
        Friend WithEvents BtnLike As CMCv.UI.Control.btn
        Friend WithEvents TPFiles As TabPage
        Friend WithEvents DgnFile As CMCv.UI.Control.dgn
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
End Namespace