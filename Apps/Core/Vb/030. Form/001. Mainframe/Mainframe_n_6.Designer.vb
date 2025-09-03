<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainframe_n_6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainframe_n_6))
        Dim TreeNode1 As TreeNode = New TreeNode("Dashboard")
        Dim TreeNode2 As TreeNode = New TreeNode("MCTG - Material Catalog")
        Dim TreeNode3 As TreeNode = New TreeNode("MMGR - Material Group")
        Dim TreeNode4 As TreeNode = New TreeNode("MMTY - Material Type")
        Dim TreeNode5 As TreeNode = New TreeNode("MMVT - Material Valuation")
        Dim TreeNode6 As TreeNode = New TreeNode("PLNT - Plant List")
        Dim TreeNode7 As TreeNode = New TreeNode("SLOC - Storage Location")
        Dim TreeNode8 As TreeNode = New TreeNode("MOW - Material Ownership")
        Dim TreeNode9 As TreeNode = New TreeNode("UOM - Unit Of Measurement")
        Dim TreeNode10 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As TreeNode = New TreeNode("MMIT - Material Inventory Table")
        Dim TreeNode12 As TreeNode = New TreeNode("MMSI - Material Stock Info")
        Dim TreeNode13 As TreeNode = New TreeNode("Inventory", New TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As TreeNode = New TreeNode("DE001 - Logistics Data Entry")
        Dim TreeNode15 As TreeNode = New TreeNode("MVT - Movement Type")
        Dim TreeNode16 As TreeNode = New TreeNode("STG - Direction List")
        Dim TreeNode17 As TreeNode = New TreeNode("Additionals", New TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As TreeNode = New TreeNode("SYN01 - Import")
        Dim TreeNode19 As TreeNode = New TreeNode("Tools", New TreeNode() {TreeNode18})
        Dim TreeNode20 As TreeNode = New TreeNode("Transaction", New TreeNode() {TreeNode14, TreeNode17, TreeNode19})
        Dim TreeNode21 As TreeNode = New TreeNode("Logistics", New TreeNode() {TreeNode1, TreeNode10, TreeNode13, TreeNode20})
        Dim TreeNode22 As TreeNode = New TreeNode("JIDR - Job Instructions")
        Dim TreeNode23 As TreeNode = New TreeNode("Documents", New TreeNode() {TreeNode22})
        Dim TreeNode24 As TreeNode = New TreeNode("SVCC - Service Company")
        Dim TreeNode25 As TreeNode = New TreeNode("Contact Person", New TreeNode() {TreeNode24})
        Dim TreeNode26 As TreeNode = New TreeNode("GRN - Goods Received Records")
        Dim TreeNode27 As TreeNode = New TreeNode("TFS - Transfer Records")
        Dim TreeNode28 As TreeNode = New TreeNode("Log Book", New TreeNode() {TreeNode26, TreeNode27})
        Dim TreeNode29 As TreeNode = New TreeNode("Administration", New TreeNode() {TreeNode23, TreeNode25, TreeNode28})
        Dim TreeNode30 As TreeNode = New TreeNode("Dashboard")
        Dim TreeNode31 As TreeNode = New TreeNode("ACBK - Accounting Book")
        Dim TreeNode32 As TreeNode = New TreeNode("ACGR - Account Group")
        Dim TreeNode33 As TreeNode = New TreeNode("ACCO - Account List")
        Dim TreeNode34 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode31, TreeNode32, TreeNode33})
        Dim TreeNode35 As TreeNode = New TreeNode("ACTP - Transaction Posting")
        Dim TreeNode36 As TreeNode = New TreeNode("Transaction", New TreeNode() {TreeNode35})
        Dim TreeNode37 As TreeNode = New TreeNode("Accounting", New TreeNode() {TreeNode30, TreeNode34, TreeNode36})
        Dim TreeNode38 As TreeNode = New TreeNode("CCIN - Companies")
        Dim TreeNode39 As TreeNode = New TreeNode("CDIN - Departements")
        Dim TreeNode40 As TreeNode = New TreeNode("POST - Positions")
        Dim TreeNode41 As TreeNode = New TreeNode("EPLS - Employee List")
        Dim TreeNode42 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode38, TreeNode39, TreeNode40, TreeNode41})
        Dim TreeNode43 As TreeNode = New TreeNode("Management", New TreeNode() {TreeNode42})
        Dim TreeNode44 As TreeNode = New TreeNode("VDLS - Vendor List")
        Dim TreeNode45 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode44})
        Dim TreeNode46 As TreeNode = New TreeNode("Procurement", New TreeNode() {TreeNode45})
        Dim TreeNode47 As TreeNode = New TreeNode("VHCL - Vehicle List")
        Dim TreeNode48 As TreeNode = New TreeNode("VHCT - Vehicle Type")
        Dim TreeNode49 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode47, TreeNode48})
        Dim TreeNode50 As TreeNode = New TreeNode("Transportation", New TreeNode() {TreeNode49})
        Dim TreeNode51 As TreeNode = New TreeNode("DAR - Daily Activity Reports")
        Dim TreeNode52 As TreeNode = New TreeNode("DRTM - DAR Templates")
        Dim TreeNode53 As TreeNode = New TreeNode("DRAA - DAR Area List")
        Dim TreeNode54 As TreeNode = New TreeNode("Activity Reports", New TreeNode() {TreeNode51, TreeNode52, TreeNode53})
        Dim TreeNode55 As TreeNode = New TreeNode("Custom", New TreeNode() {TreeNode54})
        Dim TreeNode56 As TreeNode = New TreeNode("PINF - Personal Information")
        Dim TreeNode57 As TreeNode = New TreeNode("My Folder", New TreeNode() {TreeNode56})
        Dim TreeNode58 As TreeNode = New TreeNode("UAC - User Access Credentials")
        Dim TreeNode59 As TreeNode = New TreeNode("Credentials", New TreeNode() {TreeNode58})
        Dim TreeNode60 As TreeNode = New TreeNode("MODS - Application Modules")
        Dim TreeNode61 As TreeNode = New TreeNode("Application", New TreeNode() {TreeNode60})
        Dim TreeNode62 As TreeNode = New TreeNode("System Settings", New TreeNode() {TreeNode59, TreeNode61})
        Ms_mainframe = New MenuStrip()
        APPSYSTEM = New ToolStripMenuItem()
        Ms_start_Login = New ToolStripMenuItem()
        Ms_start_Logout = New ToolStripMenuItem()
        Ms_g_line1 = New ToolStripSeparator()
        Ms_start_Connection = New ToolStripMenuItem()
        Ms_start_connection_app = New ToolStripMenuItem()
        Ms_start_connection_folder = New ToolStripMenuItem()
        Ms_start_Settings = New ToolStripMenuItem()
        Ms_g_line2 = New ToolStripSeparator()
        Ms_start_Exit = New ToolStripMenuItem()
        WORKSPACE = New ToolStripMenuItem()
        Ms_workspace_Cascade = New ToolStripMenuItem()
        Ms_workspace_TileVertical = New ToolStripMenuItem()
        Ms_workspace_TileHorizontal = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        Ms_workspace_InputCommand = New ToolStripMenuItem()
        Ms_workspace_Maximize = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        Ms_workspace_CloseAll = New ToolStripMenuItem()
        HELP = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        AppsCollectionToolStripMenuItem = New ToolStripMenuItem()
        PhotoResizerToolStripMenuItem = New ToolStripMenuItem()
        KeyGeneratorToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        BuymeacoffeToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        USERMENU = New ToolStripMenuItem()
        NotificationToolStripMenuItem = New ToolStripMenuItem()
        MyAccountToolStripMenuItem = New ToolStripMenuItem()
        ChangePasswordToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        SUPPORT = New ToolStripMenuItem()
        pnl_mainframe_left = New pnl(components)
        Tv_mainframe = New tv(components)
        Imglst_mainframe = New ImageList(components)
        PnlStorage = New pnl(components)
        pgFileStorage = New Windows.Forms.Tools.ProgressBarAdv()
        pgDataStorage = New Windows.Forms.Tools.ProgressBarAdv()
        lblFile = New Label()
        lblData = New Label()
        lblFileStorage = New Label()
        lblDataStorage = New Label()
        lblStorage = New lbl(components)
        Pnl_command_top = New pnl(components)
        BtnExecute = New Windows.Forms.ButtonAdv()
        Txt_shortcut = New txt(components)
        PnlProfile = New pnl(components)
        PctProfile = New pctbx(components)
        PctbxFrame = New pctbx(components)
        LblPosition = New lbl(components)
        LblEmployeeName = New lbl(components)
        LblEmpNumber = New lbl(components)
        LblWelcome = New lbl(components)
        St_mainframe = New stt(components)
        Ts_status = New ToolStripStatusLabel()
        Ts_caps = New ToolStripStatusLabel()
        Ts_connection = New ToolStripStatusLabel()
        TmrNotif = New Timer(components)
        TmrStatus = New Timer(components)
        Tmr_gc = New Timer(components)
        TmrMOD = New Timer(components)
        Tmr_runningtext = New Timer(components)
        TxtRunning = New txt(components)
        spl_ = New Splitter()
        Tmdi_ = New Windows.Forms.Tools.TabbedGroupedMDIManager()
        Ms_mainframe.SuspendLayout()
        pnl_mainframe_left.SuspendLayout()
        PnlStorage.SuspendLayout()
        CType(pgFileStorage, ComponentModel.ISupportInitialize).BeginInit()
        CType(pgDataStorage, ComponentModel.ISupportInitialize).BeginInit()
        Pnl_command_top.SuspendLayout()
        PnlProfile.SuspendLayout()
        CType(PctProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PctbxFrame, ComponentModel.ISupportInitialize).BeginInit()
        St_mainframe.SuspendLayout()
        SuspendLayout()
        ' 
        ' Ms_mainframe
        ' 
        Ms_mainframe.BackColor = Color.White
        Ms_mainframe.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Ms_mainframe.ImageScalingSize = New Size(24, 24)
        Ms_mainframe.Items.AddRange(New ToolStripItem() {APPSYSTEM, WORKSPACE, HELP, USERMENU, SUPPORT})
        Ms_mainframe.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        Ms_mainframe.Location = New Point(0, 0)
        Ms_mainframe.MdiWindowListItem = WORKSPACE
        Ms_mainframe.Name = "Ms_mainframe"
        Ms_mainframe.Padding = New Padding(9, 3, 0, 3)
        Ms_mainframe.Size = New Size(1120, 42)
        Ms_mainframe.TabIndex = 5
        Ms_mainframe.Text = "MenuStrip"
        ' 
        ' APPSYSTEM
        ' 
        APPSYSTEM.DropDownItems.AddRange(New ToolStripItem() {Ms_start_Login, Ms_start_Logout, Ms_g_line1, Ms_start_Connection, Ms_start_Settings, Ms_g_line2, Ms_start_Exit})
        APPSYSTEM.ImageTransparentColor = SystemColors.ActiveBorder
        APPSYSTEM.MergeIndex = 0
        APPSYSTEM.Name = "APPSYSTEM"
        APPSYSTEM.Size = New Size(71, 36)
        APPSYSTEM.Text = "&APP"
        ' 
        ' Ms_start_Login
        ' 
        Ms_start_Login.Name = "Ms_start_Login"
        Ms_start_Login.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.L
        Ms_start_Login.Size = New Size(343, 40)
        Ms_start_Login.Text = "Login"
        ' 
        ' Ms_start_Logout
        ' 
        Ms_start_Logout.Name = "Ms_start_Logout"
        Ms_start_Logout.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.O
        Ms_start_Logout.Size = New Size(343, 40)
        Ms_start_Logout.Text = "Logout"
        ' 
        ' Ms_g_line1
        ' 
        Ms_g_line1.Name = "Ms_g_line1"
        Ms_g_line1.Size = New Size(340, 6)
        ' 
        ' Ms_start_Connection
        ' 
        Ms_start_Connection.DropDownItems.AddRange(New ToolStripItem() {Ms_start_connection_app, Ms_start_connection_folder})
        Ms_start_Connection.Name = "Ms_start_Connection"
        Ms_start_Connection.Size = New Size(343, 40)
        Ms_start_Connection.Text = "Connection"
        ' 
        ' Ms_start_connection_app
        ' 
        Ms_start_connection_app.Name = "Ms_start_connection_app"
        Ms_start_connection_app.Size = New Size(251, 40)
        Ms_start_connection_app.Text = "Open &App"
        ' 
        ' Ms_start_connection_folder
        ' 
        Ms_start_connection_folder.Name = "Ms_start_connection_folder"
        Ms_start_connection_folder.Size = New Size(251, 40)
        Ms_start_connection_folder.Text = "Open &Folder"
        ' 
        ' Ms_start_Settings
        ' 
        Ms_start_Settings.Name = "Ms_start_Settings"
        Ms_start_Settings.Size = New Size(343, 40)
        Ms_start_Settings.Text = "&Settings"
        ' 
        ' Ms_g_line2
        ' 
        Ms_g_line2.Name = "Ms_g_line2"
        Ms_g_line2.Size = New Size(340, 6)
        ' 
        ' Ms_start_Exit
        ' 
        Ms_start_Exit.Name = "Ms_start_Exit"
        Ms_start_Exit.Size = New Size(343, 40)
        Ms_start_Exit.Text = "&Exit"
        ' 
        ' WORKSPACE
        ' 
        WORKSPACE.DropDownItems.AddRange(New ToolStripItem() {Ms_workspace_Cascade, Ms_workspace_TileVertical, Ms_workspace_TileHorizontal, ToolStripSeparator1, Ms_workspace_InputCommand, Ms_workspace_Maximize, ToolStripMenuItem1, Ms_workspace_CloseAll})
        WORKSPACE.MergeIndex = 800
        WORKSPACE.Name = "WORKSPACE"
        WORKSPACE.Size = New Size(164, 36)
        WORKSPACE.Text = "&WORKSPACE"
        ' 
        ' Ms_workspace_Cascade
        ' 
        Ms_workspace_Cascade.Name = "Ms_workspace_Cascade"
        Ms_workspace_Cascade.Size = New Size(368, 40)
        Ms_workspace_Cascade.Text = "&Cascade"
        ' 
        ' Ms_workspace_TileVertical
        ' 
        Ms_workspace_TileVertical.Name = "Ms_workspace_TileVertical"
        Ms_workspace_TileVertical.Size = New Size(368, 40)
        Ms_workspace_TileVertical.Text = "Tile &Vertical"
        ' 
        ' Ms_workspace_TileHorizontal
        ' 
        Ms_workspace_TileHorizontal.Name = "Ms_workspace_TileHorizontal"
        Ms_workspace_TileHorizontal.Size = New Size(368, 40)
        Ms_workspace_TileHorizontal.Text = "Tile &Horizontal"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(365, 6)
        ' 
        ' Ms_workspace_InputCommand
        ' 
        Ms_workspace_InputCommand.Name = "Ms_workspace_InputCommand"
        Ms_workspace_InputCommand.ShortcutKeys = Keys.Control Or Keys.J
        Ms_workspace_InputCommand.Size = New Size(368, 40)
        Ms_workspace_InputCommand.Text = "Input Command"
        ' 
        ' Ms_workspace_Maximize
        ' 
        Ms_workspace_Maximize.Name = "Ms_workspace_Maximize"
        Ms_workspace_Maximize.ShortcutKeys = Keys.Control Or Keys.M
        Ms_workspace_Maximize.Size = New Size(368, 40)
        Ms_workspace_Maximize.Text = "Maximize"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(365, 6)
        ' 
        ' Ms_workspace_CloseAll
        ' 
        Ms_workspace_CloseAll.Name = "Ms_workspace_CloseAll"
        Ms_workspace_CloseAll.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.F4
        Ms_workspace_CloseAll.Size = New Size(368, 40)
        Ms_workspace_CloseAll.Text = "Close All"
        ' 
        ' HELP
        ' 
        HELP.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, AppsCollectionToolStripMenuItem, ToolStripSeparator8, BuymeacoffeToolStripMenuItem, AboutToolStripMenuItem})
        HELP.MergeIndex = 801
        HELP.Name = "HELP"
        HELP.Size = New Size(83, 36)
        HELP.Text = "&HELP"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.AccessibleRole = AccessibleRole.Link
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ContentsToolStripMenuItem.Size = New Size(306, 40)
        ContentsToolStripMenuItem.Text = "&Contents"
        ' 
        ' AppsCollectionToolStripMenuItem
        ' 
        AppsCollectionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PhotoResizerToolStripMenuItem, KeyGeneratorToolStripMenuItem})
        AppsCollectionToolStripMenuItem.Name = "AppsCollectionToolStripMenuItem"
        AppsCollectionToolStripMenuItem.Size = New Size(306, 40)
        AppsCollectionToolStripMenuItem.Text = "In-App Tools"
        ' 
        ' PhotoResizerToolStripMenuItem
        ' 
        PhotoResizerToolStripMenuItem.Name = "PhotoResizerToolStripMenuItem"
        PhotoResizerToolStripMenuItem.Size = New Size(293, 40)
        PhotoResizerToolStripMenuItem.Text = "Photo Compress"
        ' 
        ' KeyGeneratorToolStripMenuItem
        ' 
        KeyGeneratorToolStripMenuItem.Enabled = False
        KeyGeneratorToolStripMenuItem.Name = "KeyGeneratorToolStripMenuItem"
        KeyGeneratorToolStripMenuItem.Size = New Size(293, 40)
        KeyGeneratorToolStripMenuItem.Text = "Key Generator"
        KeyGeneratorToolStripMenuItem.Visible = False
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(303, 6)
        ' 
        ' BuymeacoffeToolStripMenuItem
        ' 
        BuymeacoffeToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point)
        BuymeacoffeToolStripMenuItem.ForeColor = Color.Blue
        BuymeacoffeToolStripMenuItem.Name = "BuymeacoffeToolStripMenuItem"
        BuymeacoffeToolStripMenuItem.Size = New Size(306, 40)
        BuymeacoffeToolStripMenuItem.Text = "Buy me a coffee.."
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(306, 40)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' USERMENU
        ' 
        USERMENU.Alignment = ToolStripItemAlignment.Right
        USERMENU.BackColor = SystemColors.Control
        USERMENU.DropDownItems.AddRange(New ToolStripItem() {NotificationToolStripMenuItem, MyAccountToolStripMenuItem, ToolStripSeparator2, LoginToolStripMenuItem, LogoutToolStripMenuItem})
        USERMENU.MergeIndex = 999
        USERMENU.Name = "USERMENU"
        USERMENU.Size = New Size(174, 36)
        USERMENU.Text = "NOT LOGGED"
        ' 
        ' NotificationToolStripMenuItem
        ' 
        NotificationToolStripMenuItem.Image = CType(resources.GetObject("NotificationToolStripMenuItem.Image"), Image)
        NotificationToolStripMenuItem.Name = "NotificationToolStripMenuItem"
        NotificationToolStripMenuItem.Size = New Size(343, 40)
        NotificationToolStripMenuItem.Text = "Notification"
        ' 
        ' MyAccountToolStripMenuItem
        ' 
        MyAccountToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ChangePasswordToolStripMenuItem})
        MyAccountToolStripMenuItem.Name = "MyAccountToolStripMenuItem"
        MyAccountToolStripMenuItem.Size = New Size(343, 40)
        MyAccountToolStripMenuItem.Text = "Profile Settings"
        ' 
        ' ChangePasswordToolStripMenuItem
        ' 
        ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        ChangePasswordToolStripMenuItem.Size = New Size(304, 40)
        ChangePasswordToolStripMenuItem.Text = "Change Password"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(340, 6)
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.L
        LoginToolStripMenuItem.Size = New Size(343, 40)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.O
        LogoutToolStripMenuItem.Size = New Size(343, 40)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' SUPPORT
        ' 
        SUPPORT.Alignment = ToolStripItemAlignment.Right
        SUPPORT.DisplayStyle = ToolStripItemDisplayStyle.Text
        SUPPORT.Font = New Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point)
        SUPPORT.ForeColor = Color.Blue
        SUPPORT.Name = "SUPPORT"
        SUPPORT.Overflow = ToolStripItemOverflow.AsNeeded
        SUPPORT.Size = New Size(161, 36)
        SUPPORT.Text = "UPDATE / HELP"
        ' 
        ' pnl_mainframe_left
        ' 
        pnl_mainframe_left.BorderStyle = BorderStyle.FixedSingle
        pnl_mainframe_left.Controls.Add(Tv_mainframe)
        pnl_mainframe_left.Controls.Add(PnlStorage)
        pnl_mainframe_left.Controls.Add(Pnl_command_top)
        pnl_mainframe_left.Controls.Add(PnlProfile)
        pnl_mainframe_left.Dock = DockStyle.Left
        pnl_mainframe_left.Location = New Point(0, 81)
        pnl_mainframe_left.Margin = New Padding(4, 5, 4, 5)
        pnl_mainframe_left.Name = "pnl_mainframe_left"
        pnl_mainframe_left.Size = New Size(423, 822)
        pnl_mainframe_left.TabIndex = 11
        ' 
        ' Tv_mainframe
        ' 
        Tv_mainframe.BackColor = Color.LightYellow
        Tv_mainframe.Dock = DockStyle.Fill
        Tv_mainframe.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Tv_mainframe.HideSelection = False
        Tv_mainframe.ImageIndex = 0
        Tv_mainframe.ImageList = Imglst_mainframe
        Tv_mainframe.Indent = 19
        Tv_mainframe.Location = New Point(0, 80)
        Tv_mainframe.Margin = New Padding(4, 5, 4, 5)
        Tv_mainframe.Name = "Tv_mainframe"
        TreeNode1.ImageKey = "for_treeview_performace_16.png"
        TreeNode1.Name = "nd_folder"
        TreeNode1.SelectedImageKey = "for_treeview_performace_16.png"
        TreeNode1.Text = "Dashboard"
        TreeNode2.ImageKey = "for_treeview_settings2_16.png"
        TreeNode2.Name = "nd_file"
        TreeNode2.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode2.Tag = "MCTG"
        TreeNode2.Text = "MCTG - Material Catalog"
        TreeNode3.ImageKey = "for_treeview_settings2_16.png"
        TreeNode3.Name = "nd_file"
        TreeNode3.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode3.Tag = "MMGR"
        TreeNode3.Text = "MMGR - Material Group"
        TreeNode4.ImageKey = "for_treeview_settings2_16.png"
        TreeNode4.Name = "nd_file"
        TreeNode4.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode4.Tag = "MMTY"
        TreeNode4.Text = "MMTY - Material Type"
        TreeNode5.ImageKey = "for_treeview_settings2_16.png"
        TreeNode5.Name = "nd_file"
        TreeNode5.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode5.Tag = "MMVT"
        TreeNode5.Text = "MMVT - Material Valuation"
        TreeNode6.ImageKey = "for_treeview_settings2_16.png"
        TreeNode6.Name = "nd_file"
        TreeNode6.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode6.Tag = "PLNT"
        TreeNode6.Text = "PLNT - Plant List"
        TreeNode7.ImageKey = "for_treeview_settings2_16.png"
        TreeNode7.Name = "nd_file"
        TreeNode7.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode7.Tag = "SLOC"
        TreeNode7.Text = "SLOC - Storage Location"
        TreeNode8.ImageKey = "for_treeview_settings2_16.png"
        TreeNode8.Name = "nd_file"
        TreeNode8.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode8.Tag = "MOW"
        TreeNode8.Text = "MOW - Material Ownership"
        TreeNode9.ImageKey = "for_treeview_settings2_16.png"
        TreeNode9.Name = "nd_file"
        TreeNode9.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode9.Tag = "UOM"
        TreeNode9.Text = "UOM - Unit Of Measurement"
        TreeNode10.ImageKey = "for_treeview_folder_16.png"
        TreeNode10.Name = "nd_folder"
        TreeNode10.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode10.StateImageKey = "(none)"
        TreeNode10.Text = "Master"
        TreeNode11.ImageKey = "for_treeview_settings2_16.png"
        TreeNode11.Name = "nd_file"
        TreeNode11.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode11.Tag = "MMIT"
        TreeNode11.Text = "MMIT - Material Inventory Table"
        TreeNode12.ImageKey = "for_treeview_settings2_16.png"
        TreeNode12.Name = "nd_file"
        TreeNode12.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode12.Tag = "MMSI"
        TreeNode12.Text = "MMSI - Material Stock Info"
        TreeNode13.ImageKey = "for_treeview_folder_16.png"
        TreeNode13.Name = "nd_folder"
        TreeNode13.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode13.Text = "Inventory"
        TreeNode14.ImageKey = "for_treeview_settings2_16.png"
        TreeNode14.Name = "nd_file"
        TreeNode14.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode14.Tag = "DE001"
        TreeNode14.Text = "DE001 - Logistics Data Entry"
        TreeNode15.ImageKey = "for_treeview_settings2_16.png"
        TreeNode15.Name = "nd_file"
        TreeNode15.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode15.Tag = "MVT"
        TreeNode15.Text = "MVT - Movement Type"
        TreeNode16.ImageKey = "for_treeview_settings2_16.png"
        TreeNode16.Name = "nd_file"
        TreeNode16.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode16.Tag = "STG"
        TreeNode16.Text = "STG - Direction List"
        TreeNode17.ImageKey = "for_treeview_folder_16.png"
        TreeNode17.Name = "nd_folder"
        TreeNode17.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode17.Text = "Additionals"
        TreeNode18.ImageKey = "for_treeview_settings2_16.png"
        TreeNode18.Name = "nd_file"
        TreeNode18.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode18.Tag = "SYN01"
        TreeNode18.Text = "SYN01 - Import"
        TreeNode19.ImageKey = "for_treeview_folder_16.png"
        TreeNode19.Name = "nd_folder"
        TreeNode19.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode19.Text = "Tools"
        TreeNode20.ImageKey = "for_treeview_folder_16.png"
        TreeNode20.Name = "nd_folder"
        TreeNode20.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode20.Text = "Transaction"
        TreeNode21.ImageKey = "for_treeview_box_16.png"
        TreeNode21.Name = "nd_folder"
        TreeNode21.SelectedImageKey = "for_treeview_box_16.png"
        TreeNode21.StateImageKey = "(none)"
        TreeNode21.Text = "Logistics"
        TreeNode22.ImageKey = "for_treeview_settings2_16.png"
        TreeNode22.Name = "nd_file"
        TreeNode22.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode22.Tag = "JIDR"
        TreeNode22.Text = "JIDR - Job Instructions"
        TreeNode23.ImageKey = "for_treeview_folder_16.png"
        TreeNode23.Name = "nd_folder"
        TreeNode23.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode23.Text = "Documents"
        TreeNode24.ImageKey = "for_treeview_settings2_16.png"
        TreeNode24.Name = "nd_file"
        TreeNode24.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode24.Tag = "SVCC"
        TreeNode24.Text = "SVCC - Service Company"
        TreeNode25.ImageKey = "for_treeview_folder_16.png"
        TreeNode25.Name = "nd_folder"
        TreeNode25.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode25.Text = "Contact Person"
        TreeNode26.ImageKey = "for_treeview_settings2_16.png"
        TreeNode26.Name = "nd_file"
        TreeNode26.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode26.Tag = "GRN"
        TreeNode26.Text = "GRN - Goods Received Records"
        TreeNode27.ImageKey = "for_treeview_settings2_16.png"
        TreeNode27.Name = "nd_file"
        TreeNode27.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode27.Tag = "TFS"
        TreeNode27.Text = "TFS - Transfer Records"
        TreeNode28.ImageKey = "for_treeview_folder_16.png"
        TreeNode28.Name = "nd_folder"
        TreeNode28.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode28.Text = "Log Book"
        TreeNode29.ImageKey = "for_treeview_documents_16.png"
        TreeNode29.Name = "nd_folder"
        TreeNode29.SelectedImageKey = "for_treeview_documents_16.png"
        TreeNode29.Text = "Administration"
        TreeNode30.ImageKey = "for_treeview_performace_16.png"
        TreeNode30.Name = "nd_folder"
        TreeNode30.SelectedImageKey = "for_treeview_performace_16.png"
        TreeNode30.Text = "Dashboard"
        TreeNode31.ImageKey = "for_treeview_settings2_16.png"
        TreeNode31.Name = "nd_file"
        TreeNode31.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode31.Tag = "ACBK"
        TreeNode31.Text = "ACBK - Accounting Book"
        TreeNode32.ImageKey = "for_treeview_settings2_16.png"
        TreeNode32.Name = "nd_file"
        TreeNode32.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode32.Tag = "ACGR"
        TreeNode32.Text = "ACGR - Account Group"
        TreeNode33.ImageKey = "for_treeview_settings2_16.png"
        TreeNode33.Name = "nd_file"
        TreeNode33.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode33.Tag = "ACCO"
        TreeNode33.Text = "ACCO - Account List"
        TreeNode34.ImageKey = "for_treeview_folder_16.png"
        TreeNode34.Name = "nd_folder"
        TreeNode34.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode34.Text = "Master"
        TreeNode35.ImageKey = "for_treeview_settings2_16.png"
        TreeNode35.Name = "nd_file"
        TreeNode35.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode35.Tag = "ACTP"
        TreeNode35.Text = "ACTP - Transaction Posting"
        TreeNode36.ImageKey = "for_treeview_folder_16.png"
        TreeNode36.Name = "nd_folder"
        TreeNode36.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode36.Text = "Transaction"
        TreeNode37.ImageKey = "for_treeview_dollar_16.png"
        TreeNode37.Name = "nd_folder"
        TreeNode37.SelectedImageKey = "for_treeview_dollar_16.png"
        TreeNode37.Text = "Accounting"
        TreeNode38.ImageKey = "for_treeview_settings2_16.png"
        TreeNode38.Name = "nd_file"
        TreeNode38.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode38.Tag = "CCIN"
        TreeNode38.Text = "CCIN - Companies"
        TreeNode39.ImageKey = "for_treeview_settings2_16.png"
        TreeNode39.Name = "nd_file"
        TreeNode39.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode39.Tag = "CDIN"
        TreeNode39.Text = "CDIN - Departements"
        TreeNode40.ImageKey = "for_treeview_settings2_16.png"
        TreeNode40.Name = "nd_file"
        TreeNode40.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode40.Tag = "POST"
        TreeNode40.Text = "POST - Positions"
        TreeNode41.ImageKey = "for_treeview_settings2_16.png"
        TreeNode41.Name = "nd_file"
        TreeNode41.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode41.Tag = "EPLS"
        TreeNode41.Text = "EPLS - Employee List"
        TreeNode42.ImageKey = "for_treeview_folder_16.png"
        TreeNode42.Name = "nd_folder"
        TreeNode42.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode42.Text = "Master"
        TreeNode43.ImageKey = "for_treeview_crisismanagement_16.png"
        TreeNode43.Name = "nd_folder"
        TreeNode43.SelectedImageKey = "for_treeview_crisismanagement_16.png"
        TreeNode43.Text = "Management"
        TreeNode44.ImageKey = "for_treeview_settings2_16.png"
        TreeNode44.Name = "nd_file"
        TreeNode44.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode44.Tag = "VDLS"
        TreeNode44.Text = "VDLS - Vendor List"
        TreeNode45.ImageKey = "for_treeview_folder_16.png"
        TreeNode45.Name = "nd_folder"
        TreeNode45.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode45.Text = "Master"
        TreeNode46.ImageKey = "for_treeview_shoppingcart_16.png"
        TreeNode46.Name = "nd_folder"
        TreeNode46.SelectedImageKey = "for_treeview_shoppingcart_16.png"
        TreeNode46.Text = "Procurement"
        TreeNode47.ImageKey = "for_treeview_settings2_16.png"
        TreeNode47.Name = "nd_file"
        TreeNode47.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode47.Tag = "VHCL"
        TreeNode47.Text = "VHCL - Vehicle List"
        TreeNode48.ImageKey = "for_treeview_settings2_16.png"
        TreeNode48.Name = "nd_file"
        TreeNode48.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode48.Tag = "VHCT"
        TreeNode48.Text = "VHCT - Vehicle Type"
        TreeNode49.ImageKey = "for_treeview_folder_16.png"
        TreeNode49.Name = "nd_folder"
        TreeNode49.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode49.Text = "Master"
        TreeNode50.ImageKey = "for_treeview_deliverytruck_16.png"
        TreeNode50.Name = "nd_folder"
        TreeNode50.SelectedImageKey = "for_treeview_deliverytruck_16.png"
        TreeNode50.Text = "Transportation"
        TreeNode51.ImageKey = "for_treeview_settings2_16.png"
        TreeNode51.Name = "nd_file"
        TreeNode51.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode51.Tag = "DAR"
        TreeNode51.Text = "DAR - Daily Activity Reports"
        TreeNode52.ImageKey = "for_treeview_settings2_16.png"
        TreeNode52.Name = "nd_file"
        TreeNode52.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode52.Tag = "DRTM"
        TreeNode52.Text = "DRTM - DAR Templates"
        TreeNode53.ImageKey = "for_treeview_settings2_16.png"
        TreeNode53.Name = "nd_file"
        TreeNode53.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode53.Tag = "DRAA"
        TreeNode53.Text = "DRAA - DAR Area List"
        TreeNode54.ImageKey = "for_treeview_folder_16.png"
        TreeNode54.Name = "nd_folder"
        TreeNode54.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode54.Text = "Activity Reports"
        TreeNode55.ImageKey = "for_treeview_puzzle_16.png"
        TreeNode55.Name = "nd_folder"
        TreeNode55.SelectedImageKey = "for_treeview_puzzle_16.png"
        TreeNode55.Text = "Custom"
        TreeNode56.ImageKey = "for_treeview_settings2_16.png"
        TreeNode56.Name = "nd_file"
        TreeNode56.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode56.Tag = "PINF"
        TreeNode56.Text = "PINF - Personal Information"
        TreeNode57.ImageKey = "for_treeview_id_16.png"
        TreeNode57.Name = "nd_folder"
        TreeNode57.SelectedImageKey = "for_treeview_id_16.png"
        TreeNode57.Text = "My Folder"
        TreeNode58.ImageKey = "for_treeview_settings2_16.png"
        TreeNode58.Name = "nd_file"
        TreeNode58.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode58.Tag = "UAC"
        TreeNode58.Text = "UAC - User Access Credentials"
        TreeNode59.ImageKey = "for_treeview_folder_16.png"
        TreeNode59.Name = "nd_folder"
        TreeNode59.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode59.Text = "Credentials"
        TreeNode60.ImageKey = "for_treeview_settings2_16.png"
        TreeNode60.Name = "nd_file"
        TreeNode60.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode60.Tag = "MODS"
        TreeNode60.Text = "MODS - Application Modules"
        TreeNode61.ImageKey = "for_treeview_folder_16.png"
        TreeNode61.Name = "nd_folder"
        TreeNode61.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode61.Text = "Application"
        TreeNode62.ImageKey = "for_treeview_settings_16.png"
        TreeNode62.Name = "nd_folder"
        TreeNode62.SelectedImageKey = "for_treeview_settings_16.png"
        TreeNode62.Text = "System Settings"
        Tv_mainframe.Nodes.AddRange(New TreeNode() {TreeNode21, TreeNode29, TreeNode37, TreeNode43, TreeNode46, TreeNode50, TreeNode55, TreeNode57, TreeNode62})
        Tv_mainframe.SelectedImageIndex = 0
        Tv_mainframe.Size = New Size(421, 143)
        Tv_mainframe.StateImageList = Imglst_mainframe
        Tv_mainframe.TabIndex = 2
        ' 
        ' Imglst_mainframe
        ' 
        Imglst_mainframe.ColorDepth = ColorDepth.Depth32Bit
        Imglst_mainframe.ImageStream = CType(resources.GetObject("Imglst_mainframe.ImageStream"), ImageListStreamer)
        Imglst_mainframe.TransparentColor = Color.Transparent
        Imglst_mainframe.Images.SetKeyName(0, "for_treeview_box_16.png")
        Imglst_mainframe.Images.SetKeyName(1, "for_treeview_documents_16.png")
        Imglst_mainframe.Images.SetKeyName(2, "for_treeview_dollar_16.png")
        Imglst_mainframe.Images.SetKeyName(3, "for_treeview_crisismanagement_16.png")
        Imglst_mainframe.Images.SetKeyName(4, "for_treeview_folder_16.png")
        Imglst_mainframe.Images.SetKeyName(5, "for_treeview_performace_16.png")
        Imglst_mainframe.Images.SetKeyName(6, "for_treeview_settings_16.png")
        Imglst_mainframe.Images.SetKeyName(7, "for_treeview_settings2_16.png")
        Imglst_mainframe.Images.SetKeyName(8, "for_treeview_record_16.png")
        Imglst_mainframe.Images.SetKeyName(9, "for_treeview_menu_16.png")
        Imglst_mainframe.Images.SetKeyName(10, "for_treeview_deliverytruck_16.png")
        Imglst_mainframe.Images.SetKeyName(11, "for_treeview_id_16.png")
        Imglst_mainframe.Images.SetKeyName(12, "for_treeview_idcard_16.png")
        Imglst_mainframe.Images.SetKeyName(13, "for_treeview_puzzle_16.png")
        Imglst_mainframe.Images.SetKeyName(14, "for_treeview_shoppingcart_16.png")
        ' 
        ' PnlStorage
        ' 
        PnlStorage.BackColor = Color.OrangeRed
        PnlStorage.Controls.Add(pgFileStorage)
        PnlStorage.Controls.Add(pgDataStorage)
        PnlStorage.Controls.Add(lblFile)
        PnlStorage.Controls.Add(lblData)
        PnlStorage.Controls.Add(lblFileStorage)
        PnlStorage.Controls.Add(lblDataStorage)
        PnlStorage.Controls.Add(lblStorage)
        PnlStorage.Dock = DockStyle.Bottom
        PnlStorage.Location = New Point(0, 223)
        PnlStorage.Margin = New Padding(4, 5, 4, 5)
        PnlStorage.Name = "PnlStorage"
        PnlStorage.Size = New Size(421, 277)
        PnlStorage.TabIndex = 6
        PnlStorage.Visible = False
        ' 
        ' pgFileStorage
        ' 
        pgFileStorage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pgFileStorage.BackgroundStyle = Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient
        pgFileStorage.BackMultipleColors = New Color() {Color.Empty}
        pgFileStorage.BackSegments = False
        pgFileStorage.BorderColor = Color.FromArgb(CByte(147), CByte(149), CByte(152))
        pgFileStorage.BorderSingle = ButtonBorderStyle.None
        pgFileStorage.BorderStyle = BorderStyle.FixedSingle
        pgFileStorage.CustomText = Nothing
        pgFileStorage.CustomWaitingRender = False
        pgFileStorage.ForegroundImage = Nothing
        pgFileStorage.GradientEndColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        pgFileStorage.GradientStartColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        pgFileStorage.Location = New Point(4, 207)
        pgFileStorage.Margin = New Padding(4, 5, 4, 5)
        pgFileStorage.MultipleColors = New Color() {Color.Empty}
        pgFileStorage.Name = "pgFileStorage"
        pgFileStorage.ProgressFallbackStyle = Windows.Forms.Tools.ProgressBarStyles.Metro
        pgFileStorage.ProgressStyle = Windows.Forms.Tools.ProgressBarStyles.Metro
        pgFileStorage.SegmentWidth = 12
        pgFileStorage.Size = New Size(410, 38)
        pgFileStorage.Step = 1
        pgFileStorage.TabIndex = 10001
        pgFileStorage.TabStop = False
        pgFileStorage.ThemeName = "Metro"
        pgFileStorage.WaitingGradientWidth = 400
        ' 
        ' pgDataStorage
        ' 
        pgDataStorage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pgDataStorage.BackgroundStyle = Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient
        pgDataStorage.BackMultipleColors = New Color() {Color.Empty}
        pgDataStorage.BackSegments = False
        pgDataStorage.BorderColor = Color.FromArgb(CByte(147), CByte(149), CByte(152))
        pgDataStorage.BorderSingle = ButtonBorderStyle.None
        pgDataStorage.BorderStyle = BorderStyle.FixedSingle
        pgDataStorage.CustomText = Nothing
        pgDataStorage.CustomWaitingRender = False
        pgDataStorage.ForegroundImage = Nothing
        pgDataStorage.GradientEndColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        pgDataStorage.GradientStartColor = Color.FromArgb(CByte(22), CByte(165), CByte(220))
        pgDataStorage.Location = New Point(4, 113)
        pgDataStorage.Margin = New Padding(4, 5, 4, 5)
        pgDataStorage.MultipleColors = New Color() {Color.Empty}
        pgDataStorage.Name = "pgDataStorage"
        pgDataStorage.ProgressFallbackStyle = Windows.Forms.Tools.ProgressBarStyles.Metro
        pgDataStorage.ProgressStyle = Windows.Forms.Tools.ProgressBarStyles.Metro
        pgDataStorage.SegmentWidth = 12
        pgDataStorage.Size = New Size(410, 38)
        pgDataStorage.Step = 1
        pgDataStorage.TabIndex = 10000
        pgDataStorage.TabStop = False
        pgDataStorage.ThemeName = "Metro"
        pgDataStorage.WaitingGradientWidth = 400
        ' 
        ' lblFile
        ' 
        lblFile.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblFile.ForeColor = Color.White
        lblFile.Location = New Point(4, 163)
        lblFile.Margin = New Padding(4, 0, 4, 0)
        lblFile.Name = "lblFile"
        lblFile.Size = New Size(89, 38)
        lblFile.TabIndex = 0
        lblFile.Text = "File :"
        lblFile.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblData
        ' 
        lblData.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblData.ForeColor = Color.White
        lblData.Location = New Point(4, 70)
        lblData.Margin = New Padding(4, 0, 4, 0)
        lblData.Name = "lblData"
        lblData.Size = New Size(89, 38)
        lblData.TabIndex = 0
        lblData.Text = "Data :"
        lblData.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFileStorage
        ' 
        lblFileStorage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblFileStorage.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileStorage.ForeColor = Color.White
        lblFileStorage.Location = New Point(99, 163)
        lblFileStorage.Margin = New Padding(4, 0, 4, 0)
        lblFileStorage.Name = "lblFileStorage"
        lblFileStorage.Size = New Size(316, 38)
        lblFileStorage.TabIndex = 0
        lblFileStorage.Text = "{0} / {1}"
        lblFileStorage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblDataStorage
        ' 
        lblDataStorage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDataStorage.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDataStorage.ForeColor = Color.White
        lblDataStorage.Location = New Point(101, 70)
        lblDataStorage.Margin = New Padding(4, 0, 4, 0)
        lblDataStorage.Name = "lblDataStorage"
        lblDataStorage.Size = New Size(316, 38)
        lblDataStorage.TabIndex = 0
        lblDataStorage.Text = "{0} / {1}"
        lblDataStorage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblStorage
        ' 
        lblStorage.BackColor = Color.GreenYellow
        lblStorage.Dock = DockStyle.Top
        lblStorage.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblStorage.Location = New Point(0, 0)
        lblStorage.Margin = New Padding(4, 0, 4, 0)
        lblStorage.Name = "lblStorage"
        lblStorage.Size = New Size(421, 53)
        lblStorage.TabIndex = 0
        lblStorage.Text = "Storage"
        lblStorage.TextAlign = ContentAlignment.MiddleCenter
        lblStorage.XOCustomElipsis = False
        ' 
        ' Pnl_command_top
        ' 
        Pnl_command_top.BackColor = Color.White
        Pnl_command_top.Controls.Add(BtnExecute)
        Pnl_command_top.Controls.Add(Txt_shortcut)
        Pnl_command_top.Dock = DockStyle.Top
        Pnl_command_top.Location = New Point(0, 0)
        Pnl_command_top.Margin = New Padding(4, 5, 4, 5)
        Pnl_command_top.Name = "Pnl_command_top"
        Pnl_command_top.Size = New Size(421, 80)
        Pnl_command_top.TabIndex = 1
        ' 
        ' BtnExecute
        ' 
        BtnExecute.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnExecute.Appearance = Windows.Forms.ButtonAppearance.Office2016Colorful
        BtnExecute.BackColor = SystemColors.Control
        BtnExecute.BackgroundImage = My.Resources.Resources.for_treeview_playbutton_512
        BtnExecute.BackgroundImageLayout = ImageLayout.Stretch
        BtnExecute.BeforeTouchSize = New Size(54, 63)
        BtnExecute.KeepFocusRectangle = False
        BtnExecute.Location = New Point(360, 8)
        BtnExecute.Margin = New Padding(4, 5, 4, 5)
        BtnExecute.Name = "BtnExecute"
        BtnExecute.Size = New Size(54, 63)
        BtnExecute.TabIndex = 2
        BtnExecute.ThemeName = "Office2016Colorful"
        BtnExecute.UseVisualStyle = True
        ' 
        ' Txt_shortcut
        ' 
        Txt_shortcut.AcceptsReturn = True
        Txt_shortcut.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Txt_shortcut.AutoCompleteMode = AutoCompleteMode.Suggest
        Txt_shortcut.AutoCompleteSource = AutoCompleteSource.CustomSource
        Txt_shortcut.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Txt_shortcut.Location = New Point(4, 17)
        Txt_shortcut.Margin = New Padding(4, 5, 4, 5)
        Txt_shortcut.MaxLength = 255
        Txt_shortcut.Name = "Txt_shortcut"
        Txt_shortcut.Size = New Size(345, 39)
        Txt_shortcut.TabIndex = 0
        Txt_shortcut.Tag = "txt"
        Txt_shortcut.XOAutoTrim = False
        Txt_shortcut.XOHarusDiisi = False
        Txt_shortcut.XOHarusDiisiWarnaLatar = Color.LightPink
        Txt_shortcut.XOHarusDiisiWarnaLatarDefault = Color.White
        Txt_shortcut.XOHightlightSaatFokus = False
        Txt_shortcut.XOHightlightSaatFokusWarna = Color.LightYellow
        Txt_shortcut.XOIsBlank = True
        Txt_shortcut.XOIsSearchBox = False
        Txt_shortcut.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        Txt_shortcut.XOPilihSemuaSaatFokus = False
        Txt_shortcut.XOPwdLengthMin = 8
        Txt_shortcut.XOPwdStrengthCalculate = False
        Txt_shortcut.XOPwdStrengthScore = 0
        Txt_shortcut.XOPwdStrengthText = Nothing
        Txt_shortcut.XORestriction = ControlCodeBase.enuRestriction.None
        Txt_shortcut.XOSearchBoxText = "Command Module"
        Txt_shortcut.XOSQLText = Nothing
        Txt_shortcut.XOTanpaSpasi = False
        Txt_shortcut.XOValidasiField = Nothing
        ' 
        ' PnlProfile
        ' 
        PnlProfile.BackColor = Color.SteelBlue
        PnlProfile.Controls.Add(PctProfile)
        PnlProfile.Controls.Add(PctbxFrame)
        PnlProfile.Controls.Add(LblPosition)
        PnlProfile.Controls.Add(LblEmployeeName)
        PnlProfile.Controls.Add(LblEmpNumber)
        PnlProfile.Controls.Add(LblWelcome)
        PnlProfile.Dock = DockStyle.Bottom
        PnlProfile.Location = New Point(0, 500)
        PnlProfile.Margin = New Padding(4, 5, 4, 5)
        PnlProfile.Name = "PnlProfile"
        PnlProfile.Size = New Size(421, 320)
        PnlProfile.TabIndex = 3
        PnlProfile.Visible = False
        ' 
        ' PctProfile
        ' 
        PctProfile.BackColor = Color.White
        PctProfile.BackgroundImage = My.Resources.Resources.PCTPRV_001_512_icon
        PctProfile.BackgroundImageLayout = ImageLayout.Zoom
        PctProfile.ErrorImage = Nothing
        PctProfile.InitialImage = Nothing
        PctProfile.Location = New Point(14, 82)
        PctProfile.Margin = New Padding(4, 5, 4, 5)
        PctProfile.Name = "PctProfile"
        PctProfile.Size = New Size(153, 210)
        PctProfile.SizeMode = PictureBoxSizeMode.StretchImage
        PctProfile.TabIndex = 0
        PctProfile.TabStop = False
        PctProfile.XOTampilkanBorder = False
        PctProfile.XOWarnaBorder = Color.DodgerBlue
        ' 
        ' PctbxFrame
        ' 
        PctbxFrame.BackColor = Color.White
        PctbxFrame.BorderStyle = BorderStyle.FixedSingle
        PctbxFrame.ErrorImage = Nothing
        PctbxFrame.InitialImage = Nothing
        PctbxFrame.Location = New Point(7, 73)
        PctbxFrame.Margin = New Padding(4, 5, 4, 5)
        PctbxFrame.Name = "PctbxFrame"
        PctbxFrame.Size = New Size(166, 225)
        PctbxFrame.SizeMode = PictureBoxSizeMode.Zoom
        PctbxFrame.TabIndex = 5
        PctbxFrame.TabStop = False
        PctbxFrame.XOTampilkanBorder = False
        PctbxFrame.XOWarnaBorder = Color.Black
        ' 
        ' LblPosition
        ' 
        LblPosition.AutoSize = True
        LblPosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblPosition.ForeColor = Color.Yellow
        LblPosition.Location = New Point(187, 157)
        LblPosition.Margin = New Padding(4, 0, 4, 0)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(127, 32)
        LblPosition.TabIndex = 4
        LblPosition.Text = "Loading..."
        LblPosition.XOCustomElipsis = False
        ' 
        ' LblEmployeeName
        ' 
        LblEmployeeName.AutoSize = True
        LblEmployeeName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEmployeeName.ForeColor = Color.White
        LblEmployeeName.Location = New Point(186, 115)
        LblEmployeeName.Margin = New Padding(4, 0, 4, 0)
        LblEmployeeName.Name = "LblEmployeeName"
        LblEmployeeName.Size = New Size(152, 40)
        LblEmployeeName.TabIndex = 3
        LblEmployeeName.Text = "Loading..."
        LblEmployeeName.XOCustomElipsis = False
        ' 
        ' LblEmpNumber
        ' 
        LblEmpNumber.AutoSize = True
        LblEmpNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEmpNumber.ForeColor = Color.White
        LblEmpNumber.Location = New Point(186, 73)
        LblEmpNumber.Margin = New Padding(4, 0, 4, 0)
        LblEmpNumber.Name = "LblEmpNumber"
        LblEmpNumber.Size = New Size(152, 40)
        LblEmpNumber.TabIndex = 2
        LblEmpNumber.Text = "Loading..."
        LblEmpNumber.XOCustomElipsis = False
        ' 
        ' LblWelcome
        ' 
        LblWelcome.BackColor = Color.GreenYellow
        LblWelcome.Dock = DockStyle.Top
        LblWelcome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblWelcome.ForeColor = Color.Black
        LblWelcome.Location = New Point(0, 0)
        LblWelcome.Margin = New Padding(4, 0, 4, 0)
        LblWelcome.Name = "LblWelcome"
        LblWelcome.Size = New Size(421, 45)
        LblWelcome.TabIndex = 1
        LblWelcome.TextAlign = ContentAlignment.MiddleCenter
        LblWelcome.XOCustomElipsis = False
        ' 
        ' St_mainframe
        ' 
        St_mainframe.BackColor = Color.White
        St_mainframe.ImageScalingSize = New Size(24, 24)
        St_mainframe.Items.AddRange(New ToolStripItem() {Ts_status, Ts_caps, Ts_connection})
        St_mainframe.Location = New Point(0, 903)
        St_mainframe.Name = "St_mainframe"
        St_mainframe.Padding = New Padding(1, 0, 20, 0)
        St_mainframe.Size = New Size(1120, 32)
        St_mainframe.TabIndex = 13
        St_mainframe.Text = "Stt1"
        ' 
        ' Ts_status
        ' 
        Ts_status.Name = "Ts_status"
        Ts_status.Size = New Size(970, 25)
        Ts_status.Spring = True
        Ts_status.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Ts_caps
        ' 
        Ts_caps.AutoSize = False
        Ts_caps.DisplayStyle = ToolStripItemDisplayStyle.Text
        Ts_caps.Name = "Ts_caps"
        Ts_caps.Size = New Size(20, 25)
        ' 
        ' Ts_connection
        ' 
        Ts_connection.Name = "Ts_connection"
        Ts_connection.Size = New Size(109, 25)
        Ts_connection.Text = "Disconected"
        ' 
        ' TmrNotif
        ' 
        TmrNotif.Interval = 1000
        ' 
        ' TmrStatus
        ' 
        TmrStatus.Interval = 1000
        ' 
        ' Tmr_gc
        ' 
        Tmr_gc.Enabled = True
        Tmr_gc.Interval = 1000
        ' 
        ' TmrMOD
        ' 
        ' 
        ' Tmr_runningtext
        ' 
        ' 
        ' TxtRunning
        ' 
        TxtRunning.BackColor = Color.White
        TxtRunning.BorderStyle = BorderStyle.FixedSingle
        TxtRunning.Dock = DockStyle.Top
        TxtRunning.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtRunning.Location = New Point(0, 42)
        TxtRunning.Margin = New Padding(4, 5, 4, 5)
        TxtRunning.MaxLength = 255
        TxtRunning.Name = "TxtRunning"
        TxtRunning.ReadOnly = True
        TxtRunning.Size = New Size(1120, 39)
        TxtRunning.TabIndex = 99
        TxtRunning.TabStop = False
        TxtRunning.Tag = "txt"
        TxtRunning.Visible = False
        TxtRunning.XOAutoTrim = False
        TxtRunning.XOHarusDiisi = False
        TxtRunning.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtRunning.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtRunning.XOHightlightSaatFokus = False
        TxtRunning.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtRunning.XOIsBlank = True
        TxtRunning.XOIsSearchBox = False
        TxtRunning.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtRunning.XOPilihSemuaSaatFokus = False
        TxtRunning.XOPwdLengthMin = 8
        TxtRunning.XOPwdStrengthCalculate = False
        TxtRunning.XOPwdStrengthScore = 0
        TxtRunning.XOPwdStrengthText = Nothing
        TxtRunning.XORestriction = ControlCodeBase.enuRestriction.None
        TxtRunning.XOSearchBoxText = "Type then press Enter"
        TxtRunning.XOSQLText = ""
        TxtRunning.XOTanpaSpasi = False
        TxtRunning.XOValidasiField = Nothing
        ' 
        ' spl_
        ' 
        spl_.BackColor = Color.Azure
        spl_.BorderStyle = BorderStyle.FixedSingle
        spl_.Location = New Point(423, 81)
        spl_.Margin = New Padding(4, 5, 4, 5)
        spl_.Name = "spl_"
        spl_.Size = New Size(5, 822)
        spl_.TabIndex = 9999
        spl_.TabStop = False
        ' 
        ' Tmdi_
        ' 
        Tmdi_.ActiveTabFont = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Tmdi_.AttachedTo = Me
        Tmdi_.CloseButtonBackColor = Color.Red
        Tmdi_.CloseButtonColor = Color.White
        Tmdi_.CloseButtonToolTip = ""
        Tmdi_.CloseButtonVisible = False
        Tmdi_.DropDownButtonToolTip = ""
        Tmdi_.ImageSize = New Size(16, 16)
        Tmdi_.NeedUpdateHostedForm = False
        Tmdi_.ShowCloseButton = True
        Tmdi_.ShowCloseButtonBackColor = True
        Tmdi_.TabFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tmdi_.TabStyle = GetType(Windows.Forms.Tools.TabRendererIE7)
        Tmdi_.ThemeName = "TabRendererIE7"
        Tmdi_.ThemesEnabled = True
        Tmdi_.UseIconsInTabs = False
        ' 
        ' Mainframe_n_6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1120, 935)
        Controls.Add(spl_)
        Controls.Add(pnl_mainframe_left)
        Controls.Add(St_mainframe)
        Controls.Add(TxtRunning)
        Controls.Add(Ms_mainframe)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = Ms_mainframe
        Margin = New Padding(4, 5, 4, 5)
        MinimumSize = New Size(1133, 963)
        Name = "Mainframe_n_6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INGRID"
        WindowState = FormWindowState.Maximized
        Ms_mainframe.ResumeLayout(False)
        Ms_mainframe.PerformLayout()
        pnl_mainframe_left.ResumeLayout(False)
        PnlStorage.ResumeLayout(False)
        CType(pgFileStorage, ComponentModel.ISupportInitialize).EndInit()
        CType(pgDataStorage, ComponentModel.ISupportInitialize).EndInit()
        Pnl_command_top.ResumeLayout(False)
        Pnl_command_top.PerformLayout()
        PnlProfile.ResumeLayout(False)
        PnlProfile.PerformLayout()
        CType(PctProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PctbxFrame, ComponentModel.ISupportInitialize).EndInit()
        St_mainframe.ResumeLayout(False)
        St_mainframe.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents APPSYSTEM As ToolStripMenuItem
    Friend WithEvents Ms_start_Login As ToolStripMenuItem
    Friend WithEvents Ms_start_Logout As ToolStripMenuItem
    Friend WithEvents Ms_g_line1 As ToolStripSeparator
    Friend WithEvents Ms_start_Connection As ToolStripMenuItem
    Friend WithEvents Ms_start_Settings As ToolStripMenuItem
    Friend WithEvents Ms_g_line2 As ToolStripSeparator
    Friend WithEvents Ms_start_Exit As ToolStripMenuItem
    Friend WithEvents WORKSPACE As ToolStripMenuItem
    Friend WithEvents Ms_workspace_Cascade As ToolStripMenuItem
    Friend WithEvents Ms_workspace_TileVertical As ToolStripMenuItem
    Friend WithEvents Ms_workspace_TileHorizontal As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Ms_workspace_InputCommand As ToolStripMenuItem
    Friend WithEvents Ms_workspace_Maximize As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents Ms_workspace_CloseAll As ToolStripMenuItem
    Friend WithEvents HELP As ToolStripMenuItem
    Friend WithEvents AppsCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhotoResizerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeyGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuymeacoffeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USERMENU As ToolStripMenuItem
    Friend WithEvents MyAccountToolStripMenuItem As ToolStripMenuItem
    Public WithEvents NotificationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUPPORT As ToolStripMenuItem
    Friend WithEvents TxtRunning As txt
    Friend WithEvents Imglst_mainframe As ImageList
    Friend WithEvents TmrNotif As Timer
    Friend WithEvents Tmr_gc As Timer
    Friend WithEvents imglst_36 As ImageList
    Friend WithEvents TmrMOD As Timer
    Friend WithEvents TmrStatus As Timer
    Friend WithEvents Tmr_runningtext As Timer
    Public WithEvents Ms_mainframe As MenuStrip
    Friend WithEvents Tmdi_ As Syncfusion.Windows.Forms.Tools.TabbedGroupedMDIManager
    Friend WithEvents pnl_mainframe_left As pnl
    Friend WithEvents spl_ As Splitter
    Friend WithEvents Tv_mainframe As tv
    Friend WithEvents Pnl_command_top As pnl
    Friend WithEvents BtnExecute As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents Txt_shortcut As txt
    Friend WithEvents PnlProfile As pnl
    Friend WithEvents LblWelcome As lbl
    Friend WithEvents PctProfile As pctbx
    Friend WithEvents LblEmpNumber As lbl
    Friend WithEvents LblEmployeeName As lbl
    Friend WithEvents LblPosition As lbl
    Friend WithEvents PctbxFrame As pctbx
    Friend WithEvents PnlStorage As pnl
    Friend WithEvents lblFile As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblFileStorage As Label
    Friend WithEvents lblDataStorage As Label
    Friend WithEvents lblStorage As lbl
    Friend WithEvents St_mainframe As stt
    Friend WithEvents Ts_status As ToolStripStatusLabel
    Friend WithEvents Ts_connection As ToolStripStatusLabel
    Friend WithEvents Ts_caps As ToolStripStatusLabel
    Friend WithEvents Ms_start_connection_app As ToolStripMenuItem
    Friend WithEvents Ms_start_connection_folder As ToolStripMenuItem
    Friend WithEvents pgDataStorage As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
    Friend WithEvents pgFileStorage As Syncfusion.Windows.Forms.Tools.ProgressBarAdv
End Class
