<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmainframe6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmainframe6))
        Dim TreeNode63 As TreeNode = New TreeNode("Dashboard")
        Dim TreeNode64 As TreeNode = New TreeNode("MCTG - Material Catalog")
        Dim TreeNode65 As TreeNode = New TreeNode("MMGR - Material Group")
        Dim TreeNode66 As TreeNode = New TreeNode("MMTY - Material Type")
        Dim TreeNode67 As TreeNode = New TreeNode("MMVT - Material Valuation")
        Dim TreeNode68 As TreeNode = New TreeNode("PLNT - Plant List")
        Dim TreeNode69 As TreeNode = New TreeNode("SLOC - Storage Location")
        Dim TreeNode70 As TreeNode = New TreeNode("MOW - Material Ownership")
        Dim TreeNode71 As TreeNode = New TreeNode("UOM - Unit Of Measurement")
        Dim TreeNode72 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode64, TreeNode65, TreeNode66, TreeNode67, TreeNode68, TreeNode69, TreeNode70, TreeNode71})
        Dim TreeNode73 As TreeNode = New TreeNode("MMIT - Material Inventory Table")
        Dim TreeNode74 As TreeNode = New TreeNode("MMSI - Material Stock Info")
        Dim TreeNode75 As TreeNode = New TreeNode("Inventory", New TreeNode() {TreeNode73, TreeNode74})
        Dim TreeNode76 As TreeNode = New TreeNode("DE001 - Logistics Data Entry")
        Dim TreeNode77 As TreeNode = New TreeNode("MVT - Movement Type")
        Dim TreeNode78 As TreeNode = New TreeNode("STG - Direction List")
        Dim TreeNode79 As TreeNode = New TreeNode("Additionals", New TreeNode() {TreeNode77, TreeNode78})
        Dim TreeNode80 As TreeNode = New TreeNode("SYN01 - Import")
        Dim TreeNode81 As TreeNode = New TreeNode("Tools", New TreeNode() {TreeNode80})
        Dim TreeNode82 As TreeNode = New TreeNode("Transaction", New TreeNode() {TreeNode76, TreeNode79, TreeNode81})
        Dim TreeNode83 As TreeNode = New TreeNode("Logistics", New TreeNode() {TreeNode63, TreeNode72, TreeNode75, TreeNode82})
        Dim TreeNode84 As TreeNode = New TreeNode("JIDR - Job Instructions")
        Dim TreeNode85 As TreeNode = New TreeNode("Documents", New TreeNode() {TreeNode84})
        Dim TreeNode86 As TreeNode = New TreeNode("SVCC - Service Company")
        Dim TreeNode87 As TreeNode = New TreeNode("Contact Person", New TreeNode() {TreeNode86})
        Dim TreeNode88 As TreeNode = New TreeNode("GRN - Goods Received Records")
        Dim TreeNode89 As TreeNode = New TreeNode("TFS - Transfer Records")
        Dim TreeNode90 As TreeNode = New TreeNode("Log Book", New TreeNode() {TreeNode88, TreeNode89})
        Dim TreeNode91 As TreeNode = New TreeNode("Administration", New TreeNode() {TreeNode85, TreeNode87, TreeNode90})
        Dim TreeNode92 As TreeNode = New TreeNode("Dashboard")
        Dim TreeNode93 As TreeNode = New TreeNode("ACBK - Accounting Book")
        Dim TreeNode94 As TreeNode = New TreeNode("ACGR - Account Group")
        Dim TreeNode95 As TreeNode = New TreeNode("ACCO - Account List")
        Dim TreeNode96 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode93, TreeNode94, TreeNode95})
        Dim TreeNode97 As TreeNode = New TreeNode("ACTP - Transaction Posting")
        Dim TreeNode98 As TreeNode = New TreeNode("Transaction", New TreeNode() {TreeNode97})
        Dim TreeNode99 As TreeNode = New TreeNode("Accounting", New TreeNode() {TreeNode92, TreeNode96, TreeNode98})
        Dim TreeNode100 As TreeNode = New TreeNode("CCIN - Companies")
        Dim TreeNode101 As TreeNode = New TreeNode("CDIN - Departements")
        Dim TreeNode102 As TreeNode = New TreeNode("POST - Positions")
        Dim TreeNode103 As TreeNode = New TreeNode("EPLS - Employee List")
        Dim TreeNode104 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode100, TreeNode101, TreeNode102, TreeNode103})
        Dim TreeNode105 As TreeNode = New TreeNode("Management", New TreeNode() {TreeNode104})
        Dim TreeNode106 As TreeNode = New TreeNode("VDLS - Vendor List")
        Dim TreeNode107 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode106})
        Dim TreeNode108 As TreeNode = New TreeNode("Procurement", New TreeNode() {TreeNode107})
        Dim TreeNode109 As TreeNode = New TreeNode("VHCL - Vehicle List")
        Dim TreeNode110 As TreeNode = New TreeNode("VHCT - Vehicle Type")
        Dim TreeNode111 As TreeNode = New TreeNode("Master", New TreeNode() {TreeNode109, TreeNode110})
        Dim TreeNode112 As TreeNode = New TreeNode("Transportation", New TreeNode() {TreeNode111})
        Dim TreeNode113 As TreeNode = New TreeNode("DAR - Daily Activity Reports")
        Dim TreeNode114 As TreeNode = New TreeNode("DRTM - DAR Templates")
        Dim TreeNode115 As TreeNode = New TreeNode("DRAA - DAR Area List")
        Dim TreeNode116 As TreeNode = New TreeNode("Activity Reports", New TreeNode() {TreeNode113, TreeNode114, TreeNode115})
        Dim TreeNode117 As TreeNode = New TreeNode("Custom", New TreeNode() {TreeNode116})
        Dim TreeNode118 As TreeNode = New TreeNode("PINF - Personal Information")
        Dim TreeNode119 As TreeNode = New TreeNode("My Folder", New TreeNode() {TreeNode118})
        Dim TreeNode120 As TreeNode = New TreeNode("UAC - User Access Credentials")
        Dim TreeNode121 As TreeNode = New TreeNode("Credentials", New TreeNode() {TreeNode120})
        Dim TreeNode122 As TreeNode = New TreeNode("MODS - Application Modules")
        Dim TreeNode123 As TreeNode = New TreeNode("Application", New TreeNode() {TreeNode122})
        Dim TreeNode124 As TreeNode = New TreeNode("System Settings", New TreeNode() {TreeNode121, TreeNode123})
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
        TreeNode63.ImageKey = "for_treeview_performace_16.png"
        TreeNode63.Name = "nd_folder"
        TreeNode63.SelectedImageKey = "for_treeview_performace_16.png"
        TreeNode63.Text = "Dashboard"
        TreeNode64.ImageKey = "for_treeview_settings2_16.png"
        TreeNode64.Name = "nd_file"
        TreeNode64.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode64.Tag = "MCTG"
        TreeNode64.Text = "MCTG - Material Catalog"
        TreeNode65.ImageKey = "for_treeview_settings2_16.png"
        TreeNode65.Name = "nd_file"
        TreeNode65.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode65.Tag = "MMGR"
        TreeNode65.Text = "MMGR - Material Group"
        TreeNode66.ImageKey = "for_treeview_settings2_16.png"
        TreeNode66.Name = "nd_file"
        TreeNode66.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode66.Tag = "MMTY"
        TreeNode66.Text = "MMTY - Material Type"
        TreeNode67.ImageKey = "for_treeview_settings2_16.png"
        TreeNode67.Name = "nd_file"
        TreeNode67.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode67.Tag = "MMVT"
        TreeNode67.Text = "MMVT - Material Valuation"
        TreeNode68.ImageKey = "for_treeview_settings2_16.png"
        TreeNode68.Name = "nd_file"
        TreeNode68.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode68.Tag = "PLNT"
        TreeNode68.Text = "PLNT - Plant List"
        TreeNode69.ImageKey = "for_treeview_settings2_16.png"
        TreeNode69.Name = "nd_file"
        TreeNode69.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode69.Tag = "SLOC"
        TreeNode69.Text = "SLOC - Storage Location"
        TreeNode70.ImageKey = "for_treeview_settings2_16.png"
        TreeNode70.Name = "nd_file"
        TreeNode70.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode70.Tag = "MOW"
        TreeNode70.Text = "MOW - Material Ownership"
        TreeNode71.ImageKey = "for_treeview_settings2_16.png"
        TreeNode71.Name = "nd_file"
        TreeNode71.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode71.Tag = "UOM"
        TreeNode71.Text = "UOM - Unit Of Measurement"
        TreeNode72.ImageKey = "for_treeview_folder_16.png"
        TreeNode72.Name = "nd_folder"
        TreeNode72.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode72.StateImageKey = "(none)"
        TreeNode72.Text = "Master"
        TreeNode73.ImageKey = "for_treeview_settings2_16.png"
        TreeNode73.Name = "nd_file"
        TreeNode73.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode73.Tag = "MMIT"
        TreeNode73.Text = "MMIT - Material Inventory Table"
        TreeNode74.ImageKey = "for_treeview_settings2_16.png"
        TreeNode74.Name = "nd_file"
        TreeNode74.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode74.Tag = "MMSI"
        TreeNode74.Text = "MMSI - Material Stock Info"
        TreeNode75.ImageKey = "for_treeview_folder_16.png"
        TreeNode75.Name = "nd_folder"
        TreeNode75.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode75.Text = "Inventory"
        TreeNode76.ImageKey = "for_treeview_settings2_16.png"
        TreeNode76.Name = "nd_file"
        TreeNode76.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode76.Tag = "DE001"
        TreeNode76.Text = "DE001 - Logistics Data Entry"
        TreeNode77.ImageKey = "for_treeview_settings2_16.png"
        TreeNode77.Name = "nd_file"
        TreeNode77.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode77.Tag = "MVT"
        TreeNode77.Text = "MVT - Movement Type"
        TreeNode78.ImageKey = "for_treeview_settings2_16.png"
        TreeNode78.Name = "nd_file"
        TreeNode78.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode78.Tag = "STG"
        TreeNode78.Text = "STG - Direction List"
        TreeNode79.ImageKey = "for_treeview_folder_16.png"
        TreeNode79.Name = "nd_folder"
        TreeNode79.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode79.Text = "Additionals"
        TreeNode80.ImageKey = "for_treeview_settings2_16.png"
        TreeNode80.Name = "nd_file"
        TreeNode80.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode80.Tag = "SYN01"
        TreeNode80.Text = "SYN01 - Import"
        TreeNode81.ImageKey = "for_treeview_folder_16.png"
        TreeNode81.Name = "nd_folder"
        TreeNode81.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode81.Text = "Tools"
        TreeNode82.ImageKey = "for_treeview_folder_16.png"
        TreeNode82.Name = "nd_folder"
        TreeNode82.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode82.Text = "Transaction"
        TreeNode83.ImageKey = "for_treeview_box_16.png"
        TreeNode83.Name = "nd_folder"
        TreeNode83.SelectedImageKey = "for_treeview_box_16.png"
        TreeNode83.StateImageKey = "(none)"
        TreeNode83.Text = "Logistics"
        TreeNode84.ImageKey = "for_treeview_settings2_16.png"
        TreeNode84.Name = "nd_file"
        TreeNode84.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode84.Tag = "JIDR"
        TreeNode84.Text = "JIDR - Job Instructions"
        TreeNode85.ImageKey = "for_treeview_folder_16.png"
        TreeNode85.Name = "nd_folder"
        TreeNode85.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode85.Text = "Documents"
        TreeNode86.ImageKey = "for_treeview_settings2_16.png"
        TreeNode86.Name = "nd_file"
        TreeNode86.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode86.Tag = "SVCC"
        TreeNode86.Text = "SVCC - Service Company"
        TreeNode87.ImageKey = "for_treeview_folder_16.png"
        TreeNode87.Name = "nd_folder"
        TreeNode87.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode87.Text = "Contact Person"
        TreeNode88.ImageKey = "for_treeview_settings2_16.png"
        TreeNode88.Name = "nd_file"
        TreeNode88.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode88.Tag = "GRN"
        TreeNode88.Text = "GRN - Goods Received Records"
        TreeNode89.ImageKey = "for_treeview_settings2_16.png"
        TreeNode89.Name = "nd_file"
        TreeNode89.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode89.Tag = "TFS"
        TreeNode89.Text = "TFS - Transfer Records"
        TreeNode90.ImageKey = "for_treeview_folder_16.png"
        TreeNode90.Name = "nd_folder"
        TreeNode90.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode90.Text = "Log Book"
        TreeNode91.ImageKey = "for_treeview_documents_16.png"
        TreeNode91.Name = "nd_folder"
        TreeNode91.SelectedImageKey = "for_treeview_documents_16.png"
        TreeNode91.Text = "Administration"
        TreeNode92.ImageKey = "for_treeview_performace_16.png"
        TreeNode92.Name = "nd_folder"
        TreeNode92.SelectedImageKey = "for_treeview_performace_16.png"
        TreeNode92.Text = "Dashboard"
        TreeNode93.ImageKey = "for_treeview_settings2_16.png"
        TreeNode93.Name = "nd_file"
        TreeNode93.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode93.Tag = "ACBK"
        TreeNode93.Text = "ACBK - Accounting Book"
        TreeNode94.ImageKey = "for_treeview_settings2_16.png"
        TreeNode94.Name = "nd_file"
        TreeNode94.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode94.Tag = "ACGR"
        TreeNode94.Text = "ACGR - Account Group"
        TreeNode95.ImageKey = "for_treeview_settings2_16.png"
        TreeNode95.Name = "nd_file"
        TreeNode95.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode95.Tag = "ACCO"
        TreeNode95.Text = "ACCO - Account List"
        TreeNode96.ImageKey = "for_treeview_folder_16.png"
        TreeNode96.Name = "nd_folder"
        TreeNode96.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode96.Text = "Master"
        TreeNode97.ImageKey = "for_treeview_settings2_16.png"
        TreeNode97.Name = "nd_file"
        TreeNode97.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode97.Tag = "ACTP"
        TreeNode97.Text = "ACTP - Transaction Posting"
        TreeNode98.ImageKey = "for_treeview_folder_16.png"
        TreeNode98.Name = "nd_folder"
        TreeNode98.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode98.Text = "Transaction"
        TreeNode99.ImageKey = "for_treeview_dollar_16.png"
        TreeNode99.Name = "nd_folder"
        TreeNode99.SelectedImageKey = "for_treeview_dollar_16.png"
        TreeNode99.Text = "Accounting"
        TreeNode100.ImageKey = "for_treeview_settings2_16.png"
        TreeNode100.Name = "nd_file"
        TreeNode100.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode100.Tag = "CCIN"
        TreeNode100.Text = "CCIN - Companies"
        TreeNode101.ImageKey = "for_treeview_settings2_16.png"
        TreeNode101.Name = "nd_file"
        TreeNode101.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode101.Tag = "CDIN"
        TreeNode101.Text = "CDIN - Departements"
        TreeNode102.ImageKey = "for_treeview_settings2_16.png"
        TreeNode102.Name = "nd_file"
        TreeNode102.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode102.Tag = "POST"
        TreeNode102.Text = "POST - Positions"
        TreeNode103.ImageKey = "for_treeview_settings2_16.png"
        TreeNode103.Name = "nd_file"
        TreeNode103.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode103.Tag = "EPLS"
        TreeNode103.Text = "EPLS - Employee List"
        TreeNode104.ImageKey = "for_treeview_folder_16.png"
        TreeNode104.Name = "nd_folder"
        TreeNode104.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode104.Text = "Master"
        TreeNode105.ImageKey = "for_treeview_crisismanagement_16.png"
        TreeNode105.Name = "nd_folder"
        TreeNode105.SelectedImageKey = "for_treeview_crisismanagement_16.png"
        TreeNode105.Text = "Management"
        TreeNode106.ImageKey = "for_treeview_settings2_16.png"
        TreeNode106.Name = "nd_file"
        TreeNode106.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode106.Tag = "VDLS"
        TreeNode106.Text = "VDLS - Vendor List"
        TreeNode107.ImageKey = "for_treeview_folder_16.png"
        TreeNode107.Name = "nd_folder"
        TreeNode107.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode107.Text = "Master"
        TreeNode108.ImageKey = "for_treeview_shoppingcart_16.png"
        TreeNode108.Name = "nd_folder"
        TreeNode108.SelectedImageKey = "for_treeview_shoppingcart_16.png"
        TreeNode108.Text = "Procurement"
        TreeNode109.ImageKey = "for_treeview_settings2_16.png"
        TreeNode109.Name = "nd_file"
        TreeNode109.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode109.Tag = "VHCL"
        TreeNode109.Text = "VHCL - Vehicle List"
        TreeNode110.ImageKey = "for_treeview_settings2_16.png"
        TreeNode110.Name = "nd_file"
        TreeNode110.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode110.Tag = "VHCT"
        TreeNode110.Text = "VHCT - Vehicle Type"
        TreeNode111.ImageKey = "for_treeview_folder_16.png"
        TreeNode111.Name = "nd_folder"
        TreeNode111.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode111.Text = "Master"
        TreeNode112.ImageKey = "for_treeview_deliverytruck_16.png"
        TreeNode112.Name = "nd_folder"
        TreeNode112.SelectedImageKey = "for_treeview_deliverytruck_16.png"
        TreeNode112.Text = "Transportation"
        TreeNode113.ImageKey = "for_treeview_settings2_16.png"
        TreeNode113.Name = "nd_file"
        TreeNode113.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode113.Tag = "DAR"
        TreeNode113.Text = "DAR - Daily Activity Reports"
        TreeNode114.ImageKey = "for_treeview_settings2_16.png"
        TreeNode114.Name = "nd_file"
        TreeNode114.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode114.Tag = "DRTM"
        TreeNode114.Text = "DRTM - DAR Templates"
        TreeNode115.ImageKey = "for_treeview_settings2_16.png"
        TreeNode115.Name = "nd_file"
        TreeNode115.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode115.Tag = "DRAA"
        TreeNode115.Text = "DRAA - DAR Area List"
        TreeNode116.ImageKey = "for_treeview_folder_16.png"
        TreeNode116.Name = "nd_folder"
        TreeNode116.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode116.Text = "Activity Reports"
        TreeNode117.ImageKey = "for_treeview_puzzle_16.png"
        TreeNode117.Name = "nd_folder"
        TreeNode117.SelectedImageKey = "for_treeview_puzzle_16.png"
        TreeNode117.Text = "Custom"
        TreeNode118.ImageKey = "for_treeview_settings2_16.png"
        TreeNode118.Name = "nd_file"
        TreeNode118.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode118.Tag = "PINF"
        TreeNode118.Text = "PINF - Personal Information"
        TreeNode119.ImageKey = "for_treeview_id_16.png"
        TreeNode119.Name = "nd_folder"
        TreeNode119.SelectedImageKey = "for_treeview_id_16.png"
        TreeNode119.Text = "My Folder"
        TreeNode120.ImageKey = "for_treeview_settings2_16.png"
        TreeNode120.Name = "nd_file"
        TreeNode120.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode120.Tag = "UAC"
        TreeNode120.Text = "UAC - User Access Credentials"
        TreeNode121.ImageKey = "for_treeview_folder_16.png"
        TreeNode121.Name = "nd_folder"
        TreeNode121.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode121.Text = "Credentials"
        TreeNode122.ImageKey = "for_treeview_settings2_16.png"
        TreeNode122.Name = "nd_file"
        TreeNode122.SelectedImageKey = "for_treeview_record_16.png"
        TreeNode122.Tag = "MODS"
        TreeNode122.Text = "MODS - Application Modules"
        TreeNode123.ImageKey = "for_treeview_folder_16.png"
        TreeNode123.Name = "nd_folder"
        TreeNode123.SelectedImageKey = "for_treeview_folder_16.png"
        TreeNode123.Text = "Application"
        TreeNode124.ImageKey = "for_treeview_settings_16.png"
        TreeNode124.Name = "nd_folder"
        TreeNode124.SelectedImageKey = "for_treeview_settings_16.png"
        TreeNode124.Text = "System Settings"
        Tv_mainframe.Nodes.AddRange(New TreeNode() {TreeNode83, TreeNode91, TreeNode99, TreeNode105, TreeNode108, TreeNode112, TreeNode117, TreeNode119, TreeNode124})
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
        LblPosition.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
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
        TxtRunning.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        ' FRMmainframe6
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
        Name = "FRMmainframe6"
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
