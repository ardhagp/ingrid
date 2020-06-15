<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainframe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainframe))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dashboard")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MCTG - Material Catalog")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MMGR - Material Group")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MMTY - Material Type")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MMVT - Material Valuation")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PLNT - Plant List")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SLOC - Storage Location")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MOW - Material Ownership")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UOM - Unit Of Measurement")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MMIT - Material Inventory Table")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MMSI - Material Stock Info")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventory", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DE001 - Logistics Data Entry")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MVT - Movement Type")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("STG - Direction List")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Additionals", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SYN01 - Import")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tools", New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode17, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logistics", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode10, TreeNode13, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JIDR - Job Instructions")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Documents", New System.Windows.Forms.TreeNode() {TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SVCC - Service Company")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contact Person", New System.Windows.Forms.TreeNode() {TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GRN - Goods Received Records")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("TFS - Transfer Records")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Log Book", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administration", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode25, TreeNode28})
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dashboard")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ACBK - Accounting Book")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ACGR - Account Group")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ACCO - Account List")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode33})
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ACTP - Transaction Posting")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transaction", New System.Windows.Forms.TreeNode() {TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounting", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode34, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CCIN - Companies")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CDIN - Departements")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("POST - Positions")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EPLS - Employee List")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master", New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode39, TreeNode40, TreeNode41})
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Management", New System.Windows.Forms.TreeNode() {TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VDLS - Vendor List")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master", New System.Windows.Forms.TreeNode() {TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procurement", New System.Windows.Forms.TreeNode() {TreeNode45})
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PINF - Personal Information")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Folder", New System.Windows.Forms.TreeNode() {TreeNode47})
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VHCL - Vehicle List")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VHCT - Vehicle Type")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Master", New System.Windows.Forms.TreeNode() {TreeNode49, TreeNode50})
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transportation", New System.Windows.Forms.TreeNode() {TreeNode51})
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DAR - Daily Activity Reports")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DRTM - DAR Templates")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DRAA - DAR Area List")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Activity Reports", New System.Windows.Forms.TreeNode() {TreeNode53, TreeNode54, TreeNode55})
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Custom", New System.Windows.Forms.TreeNode() {TreeNode56})
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UAC - User Access Credentials")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credentials", New System.Windows.Forms.TreeNode() {TreeNode58})
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MODS - Application Modules")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Application", New System.Windows.Forms.TreeNode() {TreeNode60})
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System Settings", New System.Windows.Forms.TreeNode() {TreeNode59, TreeNode61})
        Me.ms_mainframe = New System.Windows.Forms.MenuStrip()
        Me.APPSYSTEM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_start_Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_start_Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_g_line1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ms_start_Connection = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_start_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_g_line2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ms_start_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.WORKSPACE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_workspace_Cascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_workspace_TileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_workspace_TileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ms_workspace_InputCommand = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_workspace_Maximize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ms_workspace_CloseAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppsCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoResizerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeyGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuymeacoffeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERMENU = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUPPORT = New System.Windows.Forms.ToolStripMenuItem()
        Me.Imglst_mainframe = New System.Windows.Forms.ImageList(Me.components)
        Me.TmrNotif = New System.Windows.Forms.Timer(Me.components)
        Me.TmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.spl_ = New System.Windows.Forms.Splitter()
        Me.tmr_gc = New System.Windows.Forms.Timer(Me.components)
        Me.imglst_36 = New System.Windows.Forms.ImageList(Me.components)
        Me.TmrMOD = New System.Windows.Forms.Timer(Me.components)
        Me.tmdi_ = New Syncfusion.Windows.Forms.Tools.TabbedMDIManager(Me.components)
        Me.pnl_mainframe_left = New CMCv.pnl(Me.components)
        Me.Tv_mainframe = New CMCv.tv(Me.components)
        Me.Pnl_command_top = New CMCv.pnl(Me.components)
        Me.BtnExecute2 = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.Txt_shortcut = New CMCv.txt(Me.components)
        Me.PnlStorage = New CMCv.pnl(Me.components)
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblFileStorage = New System.Windows.Forms.Label()
        Me.pgFileStorage = New System.Windows.Forms.ProgressBar()
        Me.lblDataStorage = New System.Windows.Forms.Label()
        Me.pgDataStorage = New System.Windows.Forms.ProgressBar()
        Me.lblStorage = New CMCv.lbl(Me.components)
        Me.PnlProfile = New CMCv.pnl(Me.components)
        Me.PctProfile = New CMCv.pctbx(Me.components)
        Me.PctbxFrame = New CMCv.pctbx(Me.components)
        Me.LblPosition = New CMCv.lbl(Me.components)
        Me.LblEmployeeName = New CMCv.lbl(Me.components)
        Me.LblEmpNumber = New CMCv.lbl(Me.components)
        Me.LblWelcome = New CMCv.lbl(Me.components)
        Me.st_mainframe = New CMCv.stt(Me.components)
        Me.ts_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_caps = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_connection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TxtRunning = New CMCv.txt(Me.components)
        Me.tmr_runningtext = New System.Windows.Forms.Timer(Me.components)
        Me.ms_mainframe.SuspendLayout()
        Me.pnl_mainframe_left.SuspendLayout()
        Me.Pnl_command_top.SuspendLayout()
        Me.PnlStorage.SuspendLayout()
        Me.PnlProfile.SuspendLayout()
        CType(Me.PctProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctbxFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.st_mainframe.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_mainframe
        '
        Me.ms_mainframe.BackColor = System.Drawing.Color.White
        Me.ms_mainframe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms_mainframe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.APPSYSTEM, Me.WORKSPACE, Me.HELP, Me.USERMENU, Me.SUPPORT})
        Me.ms_mainframe.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ms_mainframe.Location = New System.Drawing.Point(0, 0)
        Me.ms_mainframe.MdiWindowListItem = Me.WORKSPACE
        Me.ms_mainframe.Name = "ms_mainframe"
        Me.ms_mainframe.Size = New System.Drawing.Size(784, 29)
        Me.ms_mainframe.TabIndex = 5
        Me.ms_mainframe.Text = "MenuStrip"
        '
        'APPSYSTEM
        '
        Me.APPSYSTEM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_start_Login, Me.ms_start_Logout, Me.ms_g_line1, Me.ms_start_Connection, Me.ms_start_Settings, Me.ms_g_line2, Me.ms_start_Exit})
        Me.APPSYSTEM.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.APPSYSTEM.MergeIndex = 0
        Me.APPSYSTEM.Name = "APPSYSTEM"
        Me.APPSYSTEM.Size = New System.Drawing.Size(79, 25)
        Me.APPSYSTEM.Text = "&SYSTEM"
        '
        'ms_start_Login
        '
        Me.ms_start_Login.Name = "ms_start_Login"
        Me.ms_start_Login.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ms_start_Login.Size = New System.Drawing.Size(230, 26)
        Me.ms_start_Login.Text = "Login"
        '
        'ms_start_Logout
        '
        Me.ms_start_Logout.Name = "ms_start_Logout"
        Me.ms_start_Logout.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ms_start_Logout.Size = New System.Drawing.Size(230, 26)
        Me.ms_start_Logout.Text = "Logout"
        '
        'ms_g_line1
        '
        Me.ms_g_line1.Name = "ms_g_line1"
        Me.ms_g_line1.Size = New System.Drawing.Size(227, 6)
        '
        'ms_start_Connection
        '
        Me.ms_start_Connection.Name = "ms_start_Connection"
        Me.ms_start_Connection.Size = New System.Drawing.Size(230, 26)
        Me.ms_start_Connection.Text = "Connection"
        '
        'ms_start_Settings
        '
        Me.ms_start_Settings.Name = "ms_start_Settings"
        Me.ms_start_Settings.Size = New System.Drawing.Size(230, 26)
        Me.ms_start_Settings.Text = "&Settings"
        '
        'ms_g_line2
        '
        Me.ms_g_line2.Name = "ms_g_line2"
        Me.ms_g_line2.Size = New System.Drawing.Size(227, 6)
        '
        'ms_start_Exit
        '
        Me.ms_start_Exit.Name = "ms_start_Exit"
        Me.ms_start_Exit.Size = New System.Drawing.Size(230, 26)
        Me.ms_start_Exit.Text = "&Exit"
        '
        'WORKSPACE
        '
        Me.WORKSPACE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_workspace_Cascade, Me.ms_workspace_TileVertical, Me.ms_workspace_TileHorizontal, Me.ToolStripSeparator1, Me.ms_workspace_InputCommand, Me.ms_workspace_Maximize, Me.ToolStripMenuItem1, Me.ms_workspace_CloseAll})
        Me.WORKSPACE.MergeIndex = 800
        Me.WORKSPACE.Name = "WORKSPACE"
        Me.WORKSPACE.Size = New System.Drawing.Size(113, 25)
        Me.WORKSPACE.Text = "&WORKSPACE"
        '
        'ms_workspace_Cascade
        '
        Me.ms_workspace_Cascade.Name = "ms_workspace_Cascade"
        Me.ms_workspace_Cascade.Size = New System.Drawing.Size(246, 26)
        Me.ms_workspace_Cascade.Text = "&Cascade"
        '
        'ms_workspace_TileVertical
        '
        Me.ms_workspace_TileVertical.Name = "ms_workspace_TileVertical"
        Me.ms_workspace_TileVertical.Size = New System.Drawing.Size(246, 26)
        Me.ms_workspace_TileVertical.Text = "Tile &Vertical"
        '
        'ms_workspace_TileHorizontal
        '
        Me.ms_workspace_TileHorizontal.Name = "ms_workspace_TileHorizontal"
        Me.ms_workspace_TileHorizontal.Size = New System.Drawing.Size(246, 26)
        Me.ms_workspace_TileHorizontal.Text = "Tile &Horizontal"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(243, 6)
        '
        'ms_workspace_InputCommand
        '
        Me.ms_workspace_InputCommand.Name = "ms_workspace_InputCommand"
        Me.ms_workspace_InputCommand.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.ms_workspace_InputCommand.Size = New System.Drawing.Size(246, 26)
        Me.ms_workspace_InputCommand.Text = "Input Command"
        '
        'ms_workspace_Maximize
        '
        Me.ms_workspace_Maximize.Name = "ms_workspace_Maximize"
        Me.ms_workspace_Maximize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ms_workspace_Maximize.Size = New System.Drawing.Size(246, 26)
        Me.ms_workspace_Maximize.Text = "Maximize"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(243, 6)
        '
        'ms_workspace_CloseAll
        '
        Me.ms_workspace_CloseAll.Name = "ms_workspace_CloseAll"
        Me.ms_workspace_CloseAll.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ms_workspace_CloseAll.Size = New System.Drawing.Size(246, 26)
        Me.ms_workspace_CloseAll.Text = "Close All"
        '
        'HELP
        '
        Me.HELP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.AppsCollectionToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.ToolStripSeparator8, Me.BuymeacoffeToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HELP.MergeIndex = 801
        Me.HELP.Name = "HELP"
        Me.HELP.Size = New System.Drawing.Size(58, 25)
        Me.HELP.Text = "&HELP"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'AppsCollectionToolStripMenuItem
        '
        Me.AppsCollectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhotoResizerToolStripMenuItem, Me.KeyGeneratorToolStripMenuItem})
        Me.AppsCollectionToolStripMenuItem.Name = "AppsCollectionToolStripMenuItem"
        Me.AppsCollectionToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AppsCollectionToolStripMenuItem.Text = "In-App Tools"
        '
        'PhotoResizerToolStripMenuItem
        '
        Me.PhotoResizerToolStripMenuItem.Name = "PhotoResizerToolStripMenuItem"
        Me.PhotoResizerToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.PhotoResizerToolStripMenuItem.Text = "Photo Compress"
        '
        'KeyGeneratorToolStripMenuItem
        '
        Me.KeyGeneratorToolStripMenuItem.Enabled = False
        Me.KeyGeneratorToolStripMenuItem.Name = "KeyGeneratorToolStripMenuItem"
        Me.KeyGeneratorToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.KeyGeneratorToolStripMenuItem.Text = "Key Generator"
        Me.KeyGeneratorToolStripMenuItem.Visible = False
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Enabled = False
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(202, 6)
        '
        'BuymeacoffeToolStripMenuItem
        '
        Me.BuymeacoffeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuymeacoffeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.BuymeacoffeToolStripMenuItem.Name = "BuymeacoffeToolStripMenuItem"
        Me.BuymeacoffeToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.BuymeacoffeToolStripMenuItem.Text = "Buy me a coffee.."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'USERMENU
        '
        Me.USERMENU.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.USERMENU.BackColor = System.Drawing.SystemColors.Control
        Me.USERMENU.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NotificationToolStripMenuItem, Me.MyAccountToolStripMenuItem, Me.ToolStripSeparator2, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.USERMENU.MergeIndex = 999
        Me.USERMENU.Name = "USERMENU"
        Me.USERMENU.Size = New System.Drawing.Size(117, 25)
        Me.USERMENU.Text = "NOT LOGGED"
        '
        'NotificationToolStripMenuItem
        '
        Me.NotificationToolStripMenuItem.Image = Global.ingrid.My.Resources.Resources.Notification_001_16_FFF00000_
        Me.NotificationToolStripMenuItem.Name = "NotificationToolStripMenuItem"
        Me.NotificationToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.NotificationToolStripMenuItem.Text = "Notification"
        '
        'MyAccountToolStripMenuItem
        '
        Me.MyAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem"
        Me.MyAccountToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.MyAccountToolStripMenuItem.Text = "Profile Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(227, 6)
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SUPPORT
        '
        Me.SUPPORT.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SUPPORT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SUPPORT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUPPORT.ForeColor = System.Drawing.Color.Blue
        Me.SUPPORT.Name = "SUPPORT"
        Me.SUPPORT.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.SUPPORT.Size = New System.Drawing.Size(311, 25)
        Me.SUPPORT.Text = "Help Ticket / Submit Your Idea or Feature Request"
        '
        'Imglst_mainframe
        '
        Me.Imglst_mainframe.ImageStream = CType(resources.GetObject("Imglst_mainframe.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imglst_mainframe.TransparentColor = System.Drawing.Color.Transparent
        Me.Imglst_mainframe.Images.SetKeyName(0, "custom_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(1, "cabinet_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(2, "appblack_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(3, "appcolor_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(4, "appflat_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(5, "appflat_2_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(6, "warehouse_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(7, "warehouse_2_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(8, "archive_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(9, "paper_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(10, "accounting_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(11, "management_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(12, "procurement_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(13, "personalfolder_2_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(14, "transportation_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(15, "settings_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(16, "folder_1_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(17, "folder_2_16.png")
        Me.Imglst_mainframe.Images.SetKeyName(18, "go_1_16.png")
        '
        'TmrNotif
        '
        Me.TmrNotif.Enabled = True
        Me.TmrNotif.Interval = 1000
        '
        'TmrStatus
        '
        Me.TmrStatus.Interval = 1000
        '
        'spl_
        '
        Me.spl_.BackColor = System.Drawing.Color.Gold
        Me.spl_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spl_.Location = New System.Drawing.Point(297, 58)
        Me.spl_.Name = "spl_"
        Me.spl_.Size = New System.Drawing.Size(4, 481)
        Me.spl_.TabIndex = 9999
        Me.spl_.TabStop = False
        '
        'tmr_gc
        '
        Me.tmr_gc.Enabled = True
        Me.tmr_gc.Interval = 10000
        '
        'imglst_36
        '
        Me.imglst_36.ImageStream = CType(resources.GetObject("imglst_36.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst_36.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst_36.Images.SetKeyName(0, "GO_001_512_icon.png")
        '
        'TmrMOD
        '
        Me.TmrMOD.Enabled = True
        '
        'tmdi_
        '
        Me.tmdi_.AllowTabGroupCustomizing = False
        Me.tmdi_.AttachedTo = Me
        Me.tmdi_.CloseButtonBackColor = System.Drawing.Color.Red
        Me.tmdi_.CloseButtonColor = System.Drawing.Color.White
        Me.tmdi_.CloseButtonToolTip = ""
        Me.tmdi_.CloseButtonVisible = False
        Me.tmdi_.DropDownButtonToolTip = ""
        Me.tmdi_.ImageSize = New System.Drawing.Size(16, 16)
        Me.tmdi_.NeedUpdateHostedForm = False
        Me.tmdi_.ShowCloseButton = True
        Me.tmdi_.ShowCloseButtonBackColor = True
        Me.tmdi_.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererWorkbookMode)
        Me.tmdi_.ThemesEnabled = True
        Me.tmdi_.UseIconsInTabs = False
        '
        'pnl_mainframe_left
        '
        Me.pnl_mainframe_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_mainframe_left.Controls.Add(Me.Tv_mainframe)
        Me.pnl_mainframe_left.Controls.Add(Me.Pnl_command_top)
        Me.pnl_mainframe_left.Controls.Add(Me.PnlStorage)
        Me.pnl_mainframe_left.Controls.Add(Me.PnlProfile)
        Me.pnl_mainframe_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_mainframe_left.Location = New System.Drawing.Point(0, 58)
        Me.pnl_mainframe_left.Name = "pnl_mainframe_left"
        Me.pnl_mainframe_left.Size = New System.Drawing.Size(297, 481)
        Me.pnl_mainframe_left.TabIndex = 11
        '
        'Tv_mainframe
        '
        Me.Tv_mainframe.BackColor = System.Drawing.Color.LightYellow
        Me.Tv_mainframe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tv_mainframe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tv_mainframe.HideSelection = False
        Me.Tv_mainframe.ImageIndex = 0
        Me.Tv_mainframe.ImageList = Me.Imglst_mainframe
        Me.Tv_mainframe.Indent = 19
        Me.Tv_mainframe.Location = New System.Drawing.Point(0, 48)
        Me.Tv_mainframe.Name = "Tv_mainframe"
        TreeNode1.ImageKey = "folder_1_16.png"
        TreeNode1.Name = "nd_folder"
        TreeNode1.SelectedImageKey = "folder_1_16.png"
        TreeNode1.Text = "Dashboard"
        TreeNode2.ImageKey = "appflat_1_16.png"
        TreeNode2.Name = "nd_file"
        TreeNode2.SelectedImageKey = "appflat_2_16.png"
        TreeNode2.Tag = "MCTG"
        TreeNode2.Text = "MCTG - Material Catalog"
        TreeNode3.ImageKey = "appflat_1_16.png"
        TreeNode3.Name = "nd_file"
        TreeNode3.SelectedImageKey = "appflat_2_16.png"
        TreeNode3.Tag = "MMGR"
        TreeNode3.Text = "MMGR - Material Group"
        TreeNode4.ImageKey = "appflat_1_16.png"
        TreeNode4.Name = "nd_file"
        TreeNode4.SelectedImageKey = "appflat_2_16.png"
        TreeNode4.Tag = "MMTY"
        TreeNode4.Text = "MMTY - Material Type"
        TreeNode5.ImageKey = "appflat_1_16.png"
        TreeNode5.Name = "nd_file"
        TreeNode5.SelectedImageKey = "appflat_2_16.png"
        TreeNode5.Tag = "MMVT"
        TreeNode5.Text = "MMVT - Material Valuation"
        TreeNode6.ImageKey = "appflat_1_16.png"
        TreeNode6.Name = "nd_file"
        TreeNode6.SelectedImageKey = "appflat_2_16.png"
        TreeNode6.Tag = "PLNT"
        TreeNode6.Text = "PLNT - Plant List"
        TreeNode7.ImageKey = "appflat_1_16.png"
        TreeNode7.Name = "nd_file"
        TreeNode7.SelectedImageKey = "appflat_2_16.png"
        TreeNode7.Tag = "SLOC"
        TreeNode7.Text = "SLOC - Storage Location"
        TreeNode8.ImageKey = "appflat_1_16.png"
        TreeNode8.Name = "nd_file"
        TreeNode8.SelectedImageKey = "appflat_2_16.png"
        TreeNode8.Tag = "MOW"
        TreeNode8.Text = "MOW - Material Ownership"
        TreeNode9.ImageKey = "appflat_1_16.png"
        TreeNode9.Name = "nd_file"
        TreeNode9.SelectedImageKey = "appflat_2_16.png"
        TreeNode9.Tag = "UOM"
        TreeNode9.Text = "UOM - Unit Of Measurement"
        TreeNode10.ImageKey = "folder_1_16.png"
        TreeNode10.Name = "nd_folder"
        TreeNode10.SelectedImageKey = "folder_1_16.png"
        TreeNode10.StateImageKey = "(none)"
        TreeNode10.Text = "Master"
        TreeNode11.ImageKey = "appflat_1_16.png"
        TreeNode11.Name = "nd_file"
        TreeNode11.SelectedImageKey = "appflat_2_16.png"
        TreeNode11.Tag = "MMIT"
        TreeNode11.Text = "MMIT - Material Inventory Table"
        TreeNode12.ImageKey = "appflat_1_16.png"
        TreeNode12.Name = "nd_file"
        TreeNode12.SelectedImageKey = "appflat_2_16.png"
        TreeNode12.Tag = "MMSI"
        TreeNode12.Text = "MMSI - Material Stock Info"
        TreeNode13.ImageKey = "folder_1_16.png"
        TreeNode13.Name = "nd_folder"
        TreeNode13.SelectedImageKey = "folder_1_16.png"
        TreeNode13.Text = "Inventory"
        TreeNode14.ImageKey = "appflat_1_16.png"
        TreeNode14.Name = "nd_file"
        TreeNode14.SelectedImageKey = "appflat_2_16.png"
        TreeNode14.Tag = "DE001"
        TreeNode14.Text = "DE001 - Logistics Data Entry"
        TreeNode15.ImageKey = "appflat_1_16.png"
        TreeNode15.Name = "nd_file"
        TreeNode15.SelectedImageKey = "appflat_2_16.png"
        TreeNode15.Tag = "MVT"
        TreeNode15.Text = "MVT - Movement Type"
        TreeNode16.ImageKey = "appflat_1_16.png"
        TreeNode16.Name = "nd_file"
        TreeNode16.SelectedImageKey = "appflat_2_16.png"
        TreeNode16.Tag = "STG"
        TreeNode16.Text = "STG - Direction List"
        TreeNode17.ImageKey = "folder_1_16.png"
        TreeNode17.Name = "nd_folder"
        TreeNode17.SelectedImageKey = "folder_1_16.png"
        TreeNode17.Text = "Additionals"
        TreeNode18.ImageKey = "appflat_1_16.png"
        TreeNode18.Name = "nd_file"
        TreeNode18.SelectedImageKey = "appflat_2_16.png"
        TreeNode18.Tag = "SYN01"
        TreeNode18.Text = "SYN01 - Import"
        TreeNode19.ImageKey = "folder_1_16.png"
        TreeNode19.Name = "nd_folder"
        TreeNode19.SelectedImageKey = "folder_1_16.png"
        TreeNode19.Text = "Tools"
        TreeNode20.ImageKey = "folder_1_16.png"
        TreeNode20.Name = "nd_folder"
        TreeNode20.SelectedImageKey = "folder_1_16.png"
        TreeNode20.Text = "Transaction"
        TreeNode21.ImageKey = "warehouse_2_16.png"
        TreeNode21.Name = "nd_folder"
        TreeNode21.SelectedImageKey = "warehouse_2_16.png"
        TreeNode21.StateImageKey = "(none)"
        TreeNode21.Text = "Logistics"
        TreeNode22.ImageKey = "appflat_1_16.png"
        TreeNode22.Name = "nd_file"
        TreeNode22.SelectedImageKey = "appflat_2_16.png"
        TreeNode22.Tag = "JIDR"
        TreeNode22.Text = "JIDR - Job Instructions"
        TreeNode23.ImageKey = "folder_1_16.png"
        TreeNode23.Name = "nd_folder"
        TreeNode23.SelectedImageKey = "folder_1_16.png"
        TreeNode23.Text = "Documents"
        TreeNode24.ImageKey = "appflat_1_16.png"
        TreeNode24.Name = "nd_file"
        TreeNode24.SelectedImageKey = "appflat_2_16.png"
        TreeNode24.Tag = "SVCC"
        TreeNode24.Text = "SVCC - Service Company"
        TreeNode25.ImageKey = "folder_1_16.png"
        TreeNode25.Name = "nd_folder"
        TreeNode25.SelectedImageKey = "folder_1_16.png"
        TreeNode25.Text = "Contact Person"
        TreeNode26.ImageKey = "appflat_1_16.png"
        TreeNode26.Name = "nd_file"
        TreeNode26.SelectedImageKey = "appflat_2_16.png"
        TreeNode26.Tag = "GRN"
        TreeNode26.Text = "GRN - Goods Received Records"
        TreeNode27.ImageKey = "appflat_1_16.png"
        TreeNode27.Name = "nd_file"
        TreeNode27.SelectedImageKey = "appflat_2_16.png"
        TreeNode27.Tag = "TFS"
        TreeNode27.Text = "TFS - Transfer Records"
        TreeNode28.ImageKey = "folder_1_16.png"
        TreeNode28.Name = "nd_folder"
        TreeNode28.SelectedImageKey = "folder_1_16.png"
        TreeNode28.Text = "Log Book"
        TreeNode29.ImageKey = "paper_1_16.png"
        TreeNode29.Name = "nd_folder"
        TreeNode29.SelectedImageKey = "paper_1_16.png"
        TreeNode29.Text = "Administration"
        TreeNode30.ImageKey = "folder_1_16.png"
        TreeNode30.Name = "nd_folder"
        TreeNode30.SelectedImageKey = "folder_1_16.png"
        TreeNode30.Text = "Dashboard"
        TreeNode31.ImageKey = "appflat_1_16.png"
        TreeNode31.Name = "nd_file"
        TreeNode31.SelectedImageKey = "appflat_2_16.png"
        TreeNode31.Tag = "ACBK"
        TreeNode31.Text = "ACBK - Accounting Book"
        TreeNode32.ImageKey = "appflat_1_16.png"
        TreeNode32.Name = "nd_file"
        TreeNode32.SelectedImageKey = "appflat_2_16.png"
        TreeNode32.Tag = "ACGR"
        TreeNode32.Text = "ACGR - Account Group"
        TreeNode33.ImageKey = "appflat_1_16.png"
        TreeNode33.Name = "nd_file"
        TreeNode33.SelectedImageKey = "appflat_2_16.png"
        TreeNode33.Tag = "ACCO"
        TreeNode33.Text = "ACCO - Account List"
        TreeNode34.ImageKey = "folder_1_16.png"
        TreeNode34.Name = "nd_folder"
        TreeNode34.SelectedImageKey = "folder_1_16.png"
        TreeNode34.Text = "Master"
        TreeNode35.ImageKey = "appflat_1_16.png"
        TreeNode35.Name = "nd_file"
        TreeNode35.SelectedImageKey = "appflat_2_16.png"
        TreeNode35.Tag = "ACTP"
        TreeNode35.Text = "ACTP - Transaction Posting"
        TreeNode36.ImageKey = "folder_1_16.png"
        TreeNode36.Name = "nd_folder"
        TreeNode36.SelectedImageKey = "folder_1_16.png"
        TreeNode36.Text = "Transaction"
        TreeNode37.ImageKey = "accounting_1_16.png"
        TreeNode37.Name = "nd_folder"
        TreeNode37.SelectedImageKey = "accounting_1_16.png"
        TreeNode37.Text = "Accounting"
        TreeNode38.ImageKey = "appflat_1_16.png"
        TreeNode38.Name = "nd_file"
        TreeNode38.SelectedImageKey = "appflat_2_16.png"
        TreeNode38.Tag = "CCIN"
        TreeNode38.Text = "CCIN - Companies"
        TreeNode39.ImageKey = "appflat_1_16.png"
        TreeNode39.Name = "nd_file"
        TreeNode39.SelectedImageKey = "appflat_2_16.png"
        TreeNode39.Tag = "CDIN"
        TreeNode39.Text = "CDIN - Departements"
        TreeNode40.ImageKey = "appflat_1_16.png"
        TreeNode40.Name = "nd_file"
        TreeNode40.SelectedImageKey = "appflat_2_16.png"
        TreeNode40.Tag = "POST"
        TreeNode40.Text = "POST - Positions"
        TreeNode41.ImageKey = "appflat_1_16.png"
        TreeNode41.Name = "nd_file"
        TreeNode41.SelectedImageKey = "appflat_2_16.png"
        TreeNode41.Tag = "EPLS"
        TreeNode41.Text = "EPLS - Employee List"
        TreeNode42.ImageKey = "folder_1_16.png"
        TreeNode42.Name = "nd_folder"
        TreeNode42.SelectedImageKey = "folder_1_16.png"
        TreeNode42.Text = "Master"
        TreeNode43.ImageKey = "management_1_16.png"
        TreeNode43.Name = "nd_folder"
        TreeNode43.SelectedImageKey = "management_1_16.png"
        TreeNode43.Text = "Management"
        TreeNode44.ImageKey = "appflat_1_16.png"
        TreeNode44.Name = "nd_file"
        TreeNode44.SelectedImageKey = "appflat_2_16.png"
        TreeNode44.Tag = "VDLS"
        TreeNode44.Text = "VDLS - Vendor List"
        TreeNode45.ImageKey = "folder_1_16.png"
        TreeNode45.Name = "nd_folder"
        TreeNode45.SelectedImageKey = "folder_1_16.png"
        TreeNode45.Text = "Master"
        TreeNode46.ImageKey = "procurement_1_16.png"
        TreeNode46.Name = "nd_folder"
        TreeNode46.SelectedImageKey = "procurement_1_16.png"
        TreeNode46.Text = "Procurement"
        TreeNode47.ImageKey = "appflat_1_16.png"
        TreeNode47.Name = "nd_file"
        TreeNode47.SelectedImageKey = "appflat_2_16.png"
        TreeNode47.Tag = "PINF"
        TreeNode47.Text = "PINF - Personal Information"
        TreeNode48.ImageKey = "personalfolder_2_16.png"
        TreeNode48.Name = "nd_folder"
        TreeNode48.SelectedImageKey = "personalfolder_2_16.png"
        TreeNode48.Text = "Personal Folder"
        TreeNode49.ImageKey = "appflat_1_16.png"
        TreeNode49.Name = "nd_file"
        TreeNode49.SelectedImageKey = "appflat_2_16.png"
        TreeNode49.Tag = "VHCL"
        TreeNode49.Text = "VHCL - Vehicle List"
        TreeNode50.ImageKey = "appflat_1_16.png"
        TreeNode50.Name = "nd_file"
        TreeNode50.SelectedImageKey = "appflat_2_16.png"
        TreeNode50.Tag = "VHCT"
        TreeNode50.Text = "VHCT - Vehicle Type"
        TreeNode51.ImageKey = "folder_1_16.png"
        TreeNode51.Name = "nd_folder"
        TreeNode51.SelectedImageKey = "folder_1_16.png"
        TreeNode51.Text = "Master"
        TreeNode52.ImageKey = "transportation_1_16.png"
        TreeNode52.Name = "nd_folder"
        TreeNode52.SelectedImageKey = "transportation_1_16.png"
        TreeNode52.Text = "Transportation"
        TreeNode53.ImageKey = "appflat_1_16.png"
        TreeNode53.Name = "nd_file"
        TreeNode53.SelectedImageKey = "appflat_2_16.png"
        TreeNode53.Tag = "DAR"
        TreeNode53.Text = "DAR - Daily Activity Reports"
        TreeNode54.ImageKey = "appflat_1_16.png"
        TreeNode54.Name = "nd_file"
        TreeNode54.SelectedImageKey = "appflat_2_16.png"
        TreeNode54.Tag = "DRTM"
        TreeNode54.Text = "DRTM - DAR Templates"
        TreeNode55.ImageKey = "appflat_1_16.png"
        TreeNode55.Name = "nd_file"
        TreeNode55.SelectedImageKey = "appflat_2_16.png"
        TreeNode55.Tag = "DRAA"
        TreeNode55.Text = "DRAA - DAR Area List"
        TreeNode56.ImageKey = "folder_1_16.png"
        TreeNode56.Name = "nd_folder"
        TreeNode56.SelectedImageKey = "folder_1_16.png"
        TreeNode56.Text = "Activity Reports"
        TreeNode57.ImageKey = "custom_16.png"
        TreeNode57.Name = "nd_folder"
        TreeNode57.SelectedImageKey = "custom_16.png"
        TreeNode57.Text = "Custom"
        TreeNode58.ImageKey = "appflat_1_16.png"
        TreeNode58.Name = "nd_file"
        TreeNode58.SelectedImageKey = "appflat_2_16.png"
        TreeNode58.Tag = "UAC"
        TreeNode58.Text = "UAC - User Access Credentials"
        TreeNode59.ImageKey = "folder_1_16.png"
        TreeNode59.Name = "nd_folder"
        TreeNode59.SelectedImageKey = "folder_1_16.png"
        TreeNode59.Text = "Credentials"
        TreeNode60.ImageKey = "appflat_1_16.png"
        TreeNode60.Name = "nd_file"
        TreeNode60.SelectedImageKey = "appflat_2_16.png"
        TreeNode60.Tag = "MODS"
        TreeNode60.Text = "MODS - Application Modules"
        TreeNode61.ImageKey = "folder_1_16.png"
        TreeNode61.Name = "nd_folder"
        TreeNode61.SelectedImageKey = "folder_1_16.png"
        TreeNode61.Text = "Application"
        TreeNode62.ImageKey = "settings_1_16.png"
        TreeNode62.Name = "nd_folder"
        TreeNode62.SelectedImageKey = "settings_1_16.png"
        TreeNode62.Text = "System Settings"
        Me.Tv_mainframe.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode29, TreeNode37, TreeNode43, TreeNode46, TreeNode48, TreeNode52, TreeNode57, TreeNode62})
        Me.Tv_mainframe.SelectedImageKey = "cabinet_16.png"
        Me.Tv_mainframe.Size = New System.Drawing.Size(295, 411)
        Me.Tv_mainframe.StateImageList = Me.Imglst_mainframe
        Me.Tv_mainframe.TabIndex = 2
        '
        'Pnl_command_top
        '
        Me.Pnl_command_top.BackColor = System.Drawing.Color.White
        Me.Pnl_command_top.Controls.Add(Me.BtnExecute2)
        Me.Pnl_command_top.Controls.Add(Me.Txt_shortcut)
        Me.Pnl_command_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_command_top.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_command_top.Name = "Pnl_command_top"
        Me.Pnl_command_top.Size = New System.Drawing.Size(295, 48)
        Me.Pnl_command_top.TabIndex = 1
        '
        'BtnExecute2
        '
        Me.BtnExecute2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExecute2.BackColor = System.Drawing.SystemColors.Control
        Me.BtnExecute2.BeforeTouchSize = New System.Drawing.Size(38, 38)
        Me.BtnExecute2.ImageKey = "GO_001_512_icon.png"
        Me.BtnExecute2.ImageList = Me.imglst_36
        Me.BtnExecute2.IsBackStageButton = False
        Me.BtnExecute2.KeepFocusRectangle = False
        Me.BtnExecute2.Location = New System.Drawing.Point(252, 7)
        Me.BtnExecute2.Name = "BtnExecute2"
        Me.BtnExecute2.Size = New System.Drawing.Size(38, 38)
        Me.BtnExecute2.TabIndex = 1
        '
        'Txt_shortcut
        '
        Me.Txt_shortcut.AcceptsReturn = True
        Me.Txt_shortcut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_shortcut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Txt_shortcut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_shortcut.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Txt_shortcut.Location = New System.Drawing.Point(3, 10)
        Me.Txt_shortcut.MaxLength = 255
        Me.Txt_shortcut.Name = "Txt_shortcut"
        Me.Txt_shortcut.Size = New System.Drawing.Size(243, 29)
        Me.Txt_shortcut.SLFAutoTrim = False
        Me.Txt_shortcut.SLFHarusDiisi = False
        Me.Txt_shortcut.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.Txt_shortcut.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.Txt_shortcut.SLFHightlightSaatFokus = False
        Me.Txt_shortcut.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.Txt_shortcut.SLFIsBlank = True
        Me.Txt_shortcut.SLFIsSearchBox = False
        Me.Txt_shortcut.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.Txt_shortcut.SLFPilihSemuaSaatFokus = False
        Me.Txt_shortcut.SLFPwdLengthMin = 8
        Me.Txt_shortcut.SLFPwdStrengthCalculate = False
        Me.Txt_shortcut.SLFPwdStrengthScore = 0
        Me.Txt_shortcut.SLFPwdStrengthText = Nothing
        Me.Txt_shortcut.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.Txt_shortcut.SLFSearchBoxText = "Command Module"
        Me.Txt_shortcut.SLFSQLText = Nothing
        Me.Txt_shortcut.SLFTanpaSpasi = False
        Me.Txt_shortcut.SLFValidasiField = Nothing
        Me.Txt_shortcut.TabIndex = 0
        Me.Txt_shortcut.Tag = "txt"
        '
        'PnlStorage
        '
        Me.PnlStorage.BackColor = System.Drawing.Color.OrangeRed
        Me.PnlStorage.Controls.Add(Me.lblFile)
        Me.PnlStorage.Controls.Add(Me.lblData)
        Me.PnlStorage.Controls.Add(Me.lblFileStorage)
        Me.PnlStorage.Controls.Add(Me.pgFileStorage)
        Me.PnlStorage.Controls.Add(Me.lblDataStorage)
        Me.PnlStorage.Controls.Add(Me.pgDataStorage)
        Me.PnlStorage.Controls.Add(Me.lblStorage)
        Me.PnlStorage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlStorage.Location = New System.Drawing.Point(0, 459)
        Me.PnlStorage.Name = "PnlStorage"
        Me.PnlStorage.Size = New System.Drawing.Size(295, 10)
        Me.PnlStorage.TabIndex = 4
        Me.PnlStorage.Visible = False
        '
        'lblFile
        '
        Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.ForeColor = System.Drawing.Color.White
        Me.lblFile.Location = New System.Drawing.Point(3, 98)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(62, 23)
        Me.lblFile.TabIndex = 0
        Me.lblFile.Text = "File :"
        Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData
        '
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.ForeColor = System.Drawing.Color.White
        Me.lblData.Location = New System.Drawing.Point(3, 42)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(62, 23)
        Me.lblData.TabIndex = 0
        Me.lblData.Text = "Data :"
        Me.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFileStorage
        '
        Me.lblFileStorage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFileStorage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileStorage.ForeColor = System.Drawing.Color.White
        Me.lblFileStorage.Location = New System.Drawing.Point(71, 98)
        Me.lblFileStorage.Name = "lblFileStorage"
        Me.lblFileStorage.Size = New System.Drawing.Size(221, 23)
        Me.lblFileStorage.TabIndex = 0
        Me.lblFileStorage.Text = "{0} / {1}"
        Me.lblFileStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgFileStorage
        '
        Me.pgFileStorage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgFileStorage.Location = New System.Drawing.Point(3, 124)
        Me.pgFileStorage.Maximum = 10000
        Me.pgFileStorage.Name = "pgFileStorage"
        Me.pgFileStorage.Size = New System.Drawing.Size(289, 20)
        Me.pgFileStorage.Step = 1
        Me.pgFileStorage.TabIndex = 0
        '
        'lblDataStorage
        '
        Me.lblDataStorage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataStorage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataStorage.ForeColor = System.Drawing.Color.White
        Me.lblDataStorage.Location = New System.Drawing.Point(71, 42)
        Me.lblDataStorage.Name = "lblDataStorage"
        Me.lblDataStorage.Size = New System.Drawing.Size(221, 23)
        Me.lblDataStorage.TabIndex = 0
        Me.lblDataStorage.Text = "{0} / {1}"
        Me.lblDataStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgDataStorage
        '
        Me.pgDataStorage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgDataStorage.Location = New System.Drawing.Point(3, 68)
        Me.pgDataStorage.Maximum = 10000
        Me.pgDataStorage.Name = "pgDataStorage"
        Me.pgDataStorage.Size = New System.Drawing.Size(289, 20)
        Me.pgDataStorage.Step = 1
        Me.pgDataStorage.TabIndex = 0
        '
        'lblStorage
        '
        Me.lblStorage.BackColor = System.Drawing.Color.GreenYellow
        Me.lblStorage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStorage.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblStorage.Location = New System.Drawing.Point(0, 0)
        Me.lblStorage.Name = "lblStorage"
        Me.lblStorage.Size = New System.Drawing.Size(295, 31)
        Me.lblStorage.SLFCustomElipsis = False
        Me.lblStorage.TabIndex = 0
        Me.lblStorage.Text = "Storage"
        Me.lblStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlProfile
        '
        Me.PnlProfile.BackColor = System.Drawing.Color.SteelBlue
        Me.PnlProfile.Controls.Add(Me.PctProfile)
        Me.PnlProfile.Controls.Add(Me.PctbxFrame)
        Me.PnlProfile.Controls.Add(Me.LblPosition)
        Me.PnlProfile.Controls.Add(Me.LblEmployeeName)
        Me.PnlProfile.Controls.Add(Me.LblEmpNumber)
        Me.PnlProfile.Controls.Add(Me.LblWelcome)
        Me.PnlProfile.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlProfile.Location = New System.Drawing.Point(0, 469)
        Me.PnlProfile.Name = "PnlProfile"
        Me.PnlProfile.Size = New System.Drawing.Size(295, 10)
        Me.PnlProfile.TabIndex = 3
        Me.PnlProfile.Visible = False
        '
        'PctProfile
        '
        Me.PctProfile.BackColor = System.Drawing.Color.White
        Me.PctProfile.BackgroundImage = Global.ingrid.My.Resources.Resources.PCTPRV_001_512_icon
        Me.PctProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PctProfile.ErrorImage = CType(resources.GetObject("PctProfile.ErrorImage"), System.Drawing.Image)
        Me.PctProfile.InitialImage = CType(resources.GetObject("PctProfile.InitialImage"), System.Drawing.Image)
        Me.PctProfile.Location = New System.Drawing.Point(10, 49)
        Me.PctProfile.Name = "PctProfile"
        Me.PctProfile.Size = New System.Drawing.Size(107, 126)
        Me.PctProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctProfile.SLFTampilkanBorder = False
        Me.PctProfile.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.PctProfile.TabIndex = 0
        Me.PctProfile.TabStop = False
        '
        'PctbxFrame
        '
        Me.PctbxFrame.BackColor = System.Drawing.Color.White
        Me.PctbxFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PctbxFrame.ErrorImage = CType(resources.GetObject("PctbxFrame.ErrorImage"), System.Drawing.Image)
        Me.PctbxFrame.InitialImage = CType(resources.GetObject("PctbxFrame.InitialImage"), System.Drawing.Image)
        Me.PctbxFrame.Location = New System.Drawing.Point(5, 44)
        Me.PctbxFrame.Name = "PctbxFrame"
        Me.PctbxFrame.Size = New System.Drawing.Size(117, 136)
        Me.PctbxFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctbxFrame.SLFTampilkanBorder = False
        Me.PctbxFrame.SLFWarnaBorder = System.Drawing.Color.Black
        Me.PctbxFrame.TabIndex = 5
        Me.PctbxFrame.TabStop = False
        '
        'LblPosition
        '
        Me.LblPosition.AutoSize = True
        Me.LblPosition.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPosition.ForeColor = System.Drawing.Color.Yellow
        Me.LblPosition.Location = New System.Drawing.Point(131, 94)
        Me.LblPosition.Name = "LblPosition"
        Me.LblPosition.Size = New System.Drawing.Size(84, 21)
        Me.LblPosition.SLFCustomElipsis = False
        Me.LblPosition.TabIndex = 4
        Me.LblPosition.Text = "Loading..."
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.AutoSize = True
        Me.LblEmployeeName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmployeeName.ForeColor = System.Drawing.Color.White
        Me.LblEmployeeName.Location = New System.Drawing.Point(130, 69)
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.Size = New System.Drawing.Size(100, 25)
        Me.LblEmployeeName.SLFCustomElipsis = False
        Me.LblEmployeeName.TabIndex = 3
        Me.LblEmployeeName.Text = "Loading..."
        '
        'LblEmpNumber
        '
        Me.LblEmpNumber.AutoSize = True
        Me.LblEmpNumber.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpNumber.ForeColor = System.Drawing.Color.White
        Me.LblEmpNumber.Location = New System.Drawing.Point(130, 44)
        Me.LblEmpNumber.Name = "LblEmpNumber"
        Me.LblEmpNumber.Size = New System.Drawing.Size(100, 25)
        Me.LblEmpNumber.SLFCustomElipsis = False
        Me.LblEmpNumber.TabIndex = 2
        Me.LblEmpNumber.Text = "Loading..."
        '
        'LblWelcome
        '
        Me.LblWelcome.BackColor = System.Drawing.Color.GreenYellow
        Me.LblWelcome.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblWelcome.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWelcome.ForeColor = System.Drawing.Color.Black
        Me.LblWelcome.Location = New System.Drawing.Point(0, 0)
        Me.LblWelcome.Name = "LblWelcome"
        Me.LblWelcome.Size = New System.Drawing.Size(295, 31)
        Me.LblWelcome.SLFCustomElipsis = False
        Me.LblWelcome.TabIndex = 1
        Me.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'st_mainframe
        '
        Me.st_mainframe.BackColor = System.Drawing.Color.White
        Me.st_mainframe.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_status, Me.ts_caps, Me.ts_connection})
        Me.st_mainframe.Location = New System.Drawing.Point(0, 539)
        Me.st_mainframe.Name = "st_mainframe"
        Me.st_mainframe.Size = New System.Drawing.Size(784, 22)
        Me.st_mainframe.TabIndex = 13
        Me.st_mainframe.Text = "Stt1"
        '
        'ts_status
        '
        Me.ts_status.Name = "ts_status"
        Me.ts_status.Size = New System.Drawing.Size(677, 17)
        Me.ts_status.Spring = True
        Me.ts_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ts_caps
        '
        Me.ts_caps.AutoSize = False
        Me.ts_caps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ts_caps.Name = "ts_caps"
        Me.ts_caps.Size = New System.Drawing.Size(20, 17)
        '
        'ts_connection
        '
        Me.ts_connection.Name = "ts_connection"
        Me.ts_connection.Size = New System.Drawing.Size(72, 17)
        Me.ts_connection.Text = "Disconected"
        '
        'TxtRunning
        '
        Me.TxtRunning.BackColor = System.Drawing.Color.White
        Me.TxtRunning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRunning.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtRunning.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TxtRunning.Location = New System.Drawing.Point(0, 29)
        Me.TxtRunning.MaxLength = 255
        Me.TxtRunning.Name = "TxtRunning"
        Me.TxtRunning.ReadOnly = True
        Me.TxtRunning.Size = New System.Drawing.Size(784, 29)
        Me.TxtRunning.SLFAutoTrim = False
        Me.TxtRunning.SLFHarusDiisi = False
        Me.TxtRunning.SLFHarusDiisiWarnaLatar = System.Drawing.Color.LightPink
        Me.TxtRunning.SLFHarusDiisiWarnaLatarDefault = System.Drawing.Color.White
        Me.TxtRunning.SLFHightlightSaatFokus = False
        Me.TxtRunning.SLFHightlightSaatFokusWarna = System.Drawing.Color.LightYellow
        Me.TxtRunning.SLFIsBlank = True
        Me.TxtRunning.SLFIsSearchBox = False
        Me.TxtRunning.SLFJenisKapital = CMCv.ControlCodeBase.enuJenisKapital.Normal
        Me.TxtRunning.SLFPilihSemuaSaatFokus = False
        Me.TxtRunning.SLFPwdLengthMin = 8
        Me.TxtRunning.SLFPwdStrengthCalculate = False
        Me.TxtRunning.SLFPwdStrengthScore = 0
        Me.TxtRunning.SLFPwdStrengthText = Nothing
        Me.TxtRunning.SLFRestriction = CMCv.ControlCodeBase.enuRestriction.None
        Me.TxtRunning.SLFSearchBoxText = "Type then press Enter"
        Me.TxtRunning.SLFSQLText = ""
        Me.TxtRunning.SLFTanpaSpasi = False
        Me.TxtRunning.SLFValidasiField = Nothing
        Me.TxtRunning.TabIndex = 99
        Me.TxtRunning.TabStop = False
        Me.TxtRunning.Tag = "txt"
        Me.TxtRunning.Visible = False
        '
        'tmr_runningtext
        '
        Me.tmr_runningtext.Enabled = True
        '
        'mainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.spl_)
        Me.Controls.Add(Me.pnl_mainframe_left)
        Me.Controls.Add(Me.st_mainframe)
        Me.Controls.Add(Me.TxtRunning)
        Me.Controls.Add(Me.ms_mainframe)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.ms_mainframe
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "mainframe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRID"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ms_mainframe.ResumeLayout(False)
        Me.ms_mainframe.PerformLayout()
        Me.pnl_mainframe_left.ResumeLayout(False)
        Me.Pnl_command_top.ResumeLayout(False)
        Me.Pnl_command_top.PerformLayout()
        Me.PnlStorage.ResumeLayout(False)
        Me.PnlProfile.ResumeLayout(False)
        Me.PnlProfile.PerformLayout()
        CType(Me.PctProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctbxFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.st_mainframe.ResumeLayout(False)
        Me.st_mainframe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WORKSPACE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_workspace_Cascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_workspace_TileVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_workspace_TileHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_g_line2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ms_start_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APPSYSTEM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_g_line1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ms_start_Login As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_start_Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_start_Connection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnl_mainframe_left As CMCv.pnl
    Friend WithEvents Tv_mainframe As CMCv.tv
    Friend WithEvents Pnl_command_top As CMCv.pnl
    Friend WithEvents Txt_shortcut As CMCv.txt
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ms_workspace_CloseAll As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Imglst_mainframe As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ms_workspace_InputCommand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ms_workspace_Maximize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents st_mainframe As CMCv.stt
    Friend WithEvents ts_status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ts_connection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents USERMENU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppsCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhotoResizerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TmrNotif As Timer
    Public WithEvents NotificationToolStripMenuItem As ToolStripMenuItem
    Public WithEvents ms_mainframe As MenuStrip
    Friend WithEvents TmrStatus As Timer
    Friend WithEvents spl_ As Splitter
    Friend WithEvents PnlProfile As CMCv.pnl
    Friend WithEvents LblWelcome As CMCv.lbl
    Friend WithEvents PctProfile As CMCv.pctbx
    Friend WithEvents LblEmpNumber As CMCv.lbl
    Friend WithEvents LblEmployeeName As CMCv.lbl
    Friend WithEvents LblPosition As CMCv.lbl
    Friend WithEvents tmr_gc As Timer
    Friend WithEvents imglst_36 As ImageList
    Friend WithEvents BtnExecute2 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents TmrMOD As Timer
    Friend WithEvents tmdi_ As Syncfusion.Windows.Forms.Tools.TabbedMDIManager
    Friend WithEvents PctbxFrame As CMCv.pctbx
    Friend WithEvents SUPPORT As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtRunning As CMCv.txt
    Friend WithEvents tmr_runningtext As Timer
    Friend WithEvents BuymeacoffeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ts_caps As ToolStripStatusLabel
    Friend WithEvents PnlStorage As CMCv.pnl
    Friend WithEvents lblStorage As CMCv.lbl
    Friend WithEvents lblDataStorage As Label
    Friend WithEvents pgDataStorage As ProgressBar
    Friend WithEvents lblFile As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblFileStorage As Label
    Friend WithEvents pgFileStorage As ProgressBar
    Friend WithEvents ms_start_Settings As ToolStripMenuItem
End Class
