<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cookies", -2, -2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Temporary Internet Files", -2, -2)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("History", -2, -2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recently Typed URLs", -2, -2)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Index", -2, -2)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Internet Explorer", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cookies")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cache")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Internet History")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Google Chrome", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cookies", 0, 0)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Download History", 0, 0)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Form History", 0, 0)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cache", 0, 0)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Session Store", 0, 0)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mozilla Firefox", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cache")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("History", 0, 0)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Webpage Previews", 0, 0)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Download History", 0, 0)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Last Session", 0, 0)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Safari", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cache", 0, 0)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("History")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cookies", 0, 0)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Website Icons", 0, 0)
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Download History", 0, 0)
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Opera", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25, TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recent Documents", 0, 0)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Thumbnail Cache", 0, 0)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows Explorer", 6, 6, New System.Windows.Forms.TreeNode() {TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows Temp Files")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User Temp Files", 0, 0)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Memory Dumps", 0, 0)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ChkDsk File Fragments", 0, 0)
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows Log Files", 0, 0)
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Windows Error Reporting", 0, 0)
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("System", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36, TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prefetch Data", -2, -2)
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IIS Logs", -2, -2)
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Advanced", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode40})
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnAdEvader = New System.Windows.Forms.Button()
        Me.btnRegTools = New System.Windows.Forms.Button()
        Me.btnMemCleaner = New System.Windows.Forms.Button()
        Me.btnProcExplr = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnGCLen = New System.Windows.Forms.Button()
        Me.btnMinTray = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.TimerSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDownloadSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.tSysInfo = New System.Timers.Timer()
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.tmrClear = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.pfcCPU = New System.Diagnostics.PerformanceCounter()
        Me.tmrCPU = New System.Windows.Forms.Timer(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.tabctrl_1 = New System.Windows.Forms.TabControl()
        Me.tabMemClnr = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.bxPhysicalMem = New System.Windows.Forms.GroupBox()
        Me.lblPhysCacheFaults = New System.Windows.Forms.Label()
        Me.lblPhysMemPeak = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPhysMemCache = New System.Windows.Forms.Label()
        Me.lblPhysMemAvailable = New System.Windows.Forms.Label()
        Me.lblPhysMemTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNoProc = New System.Windows.Forms.Label()
        Me.prgClear = New System.Windows.Forms.ProgressBar()
        Me.bxKernelMemory = New System.Windows.Forms.GroupBox()
        Me.lblKerMemNonpaged = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblKerMemVirtual = New System.Windows.Forms.Label()
        Me.lblKerMemPhys = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.bxCommitCharge = New System.Windows.Forms.GroupBox()
        Me.lblCommitPeak = New System.Windows.Forms.Label()
        Me.lblCommitLimit = New System.Windows.Forms.Label()
        Me.lblCommitCurrent = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bxTotals = New System.Windows.Forms.GroupBox()
        Me.lblTotIOOther = New System.Windows.Forms.Label()
        Me.lblTotIOWrite = New System.Windows.Forms.Label()
        Me.lblTotIORead = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTotalProcesses = New System.Windows.Forms.Label()
        Me.lblTotalsThreads = New System.Windows.Forms.Label()
        Me.lblTotalHandles = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblAvailVirMemPercent = New System.Windows.Forms.Label()
        Me.lblPercentAvailPhys = New System.Windows.Forms.Label()
        Me.prgmemoryVir = New System.Windows.Forms.ProgressBar()
        Me.prgmemory = New System.Windows.Forms.ProgressBar()
        Me.lblAvailVirMem = New System.Windows.Forms.Label()
        Me.lblAvailPhysMem = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.numUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lblTotVir = New System.Windows.Forms.Label()
        Me.lblTotPhys = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnAutFreof = New System.Windows.Forms.Button()
        Me.lstProc = New System.Windows.Forms.ListBox()
        Me.btnAutFre = New System.Windows.Forms.Button()
        Me.btnFreeMem = New System.Windows.Forms.Button()
        Me.prgTime = New System.Windows.Forms.ProgressBar()
        Me.tabRegTool = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstRegAVList = New System.Windows.Forms.ListBox()
        Me.btnFixReg = New System.Windows.Forms.Button()
        Me.btnScanReg = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSaveSel = New System.Windows.Forms.Button()
        Me.btnSelDefREG = New System.Windows.Forms.Button()
        Me.btnSelNonREG = New System.Windows.Forms.Button()
        Me.btnSelAllREG = New System.Windows.Forms.Button()
        Me.chkTrayCNTX = New System.Windows.Forms.CheckBox()
        Me.chkSetTaskbar = New System.Windows.Forms.CheckBox()
        Me.chkWinLogoff = New System.Windows.Forms.CheckBox()
        Me.chkDisCPL = New System.Windows.Forms.CheckBox()
        Me.chkWinLock = New System.Windows.Forms.CheckBox()
        Me.chkWinClose = New System.Windows.Forms.CheckBox()
        Me.chkChWP = New System.Windows.Forms.CheckBox()
        Me.chkChangePW = New System.Windows.Forms.CheckBox()
        Me.chkRecentDoc = New System.Windows.Forms.CheckBox()
        Me.htmlwallpaper = New System.Windows.Forms.CheckBox()
        Me.wallpaper = New System.Windows.Forms.CheckBox()
        Me.taskbarcontext = New System.Windows.Forms.CheckBox()
        Me.savesettings = New System.Windows.Forms.CheckBox()
        Me.addremove = New System.Windows.Forms.CheckBox()
        Me.winupdate = New System.Windows.Forms.CheckBox()
        Me.filemenu = New System.Windows.Forms.CheckBox()
        Me.logoff = New System.Windows.Forms.CheckBox()
        Me.run = New System.Windows.Forms.CheckBox()
        Me.taskbar = New System.Windows.Forms.CheckBox()
        Me.desktop = New System.Windows.Forms.CheckBox()
        Me.cpl = New System.Windows.Forms.CheckBox()
        Me.cmd = New System.Windows.Forms.CheckBox()
        Me.fldopt = New System.Windows.Forms.CheckBox()
        Me.regedit = New System.Windows.Forms.CheckBox()
        Me.tskmgr = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblStartupNo = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.checkedListBox = New System.Windows.Forms.CheckedListBox()
        Me.tabAdEvader = New System.Windows.Forms.TabPage()
        Me.gbAdEvader = New System.Windows.Forms.GroupBox()
        Me.RTF2 = New System.Windows.Forms.RichTextBox()
        Me.RTF1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnApplyHosts = New System.Windows.Forms.Button()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.LabelSpeed = New System.Windows.Forms.Label()
        Me.btnHelpAdBlock = New System.Windows.Forms.Button()
        Me.btnRemoveAdBlock = New System.Windows.Forms.Button()
        Me.btnDLApply = New System.Windows.Forms.Button()
        Me.DownloadProgress1 = New System.Windows.Forms.ProgressBar()
        Me.tabGCleaner = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tcLocations = New System.Windows.Forms.TabControl()
        Me.pgBrowsers = New System.Windows.Forms.TabPage()
        Me.tvwBrowsers = New System.Windows.Forms.TreeView()
        Me.pgUserSystem = New System.Windows.Forms.TabPage()
        Me.tvwUserSystem = New System.Windows.Forms.TreeView()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lvwTemps = New System.Windows.Forms.ListView()
        Me.colDirectory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.files = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.size = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClean = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.progressScanning = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tSysInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfcCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabctrl_1.SuspendLayout()
        Me.tabMemClnr.SuspendLayout()
        Me.bxPhysicalMem.SuspendLayout()
        Me.bxKernelMemory.SuspendLayout()
        Me.bxCommitCharge.SuspendLayout()
        Me.bxTotals.SuspendLayout()
        CType(Me.numUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRegTool.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.tabAdEvader.SuspendLayout()
        Me.gbAdEvader.SuspendLayout()
        Me.tabGCleaner.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tcLocations.SuspendLayout()
        Me.pgBrowsers.SuspendLayout()
        Me.pgUserSystem.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GPMAVGUI.My.Resources.Resources.GPM_NEW_ALL2
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lime
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 80)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(385, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(292, 11)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buy the Gold Edition to fund development."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(526, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GPM Antivirus - Free Edition - ""Version 14.6 Beta"""
        '
        'btnHome
        '
        Me.btnHome.Enabled = False
        Me.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnHome.FlatAppearance.BorderSize = 2
        Me.btnHome.Location = New System.Drawing.Point(1, 88)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(114, 27)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnAdEvader
        '
        Me.btnAdEvader.Location = New System.Drawing.Point(1, 121)
        Me.btnAdEvader.Name = "btnAdEvader"
        Me.btnAdEvader.Size = New System.Drawing.Size(114, 27)
        Me.btnAdEvader.TabIndex = 2
        Me.btnAdEvader.Text = "AdEvader"
        Me.btnAdEvader.UseVisualStyleBackColor = True
        '
        'btnRegTools
        '
        Me.btnRegTools.Location = New System.Drawing.Point(1, 154)
        Me.btnRegTools.Name = "btnRegTools"
        Me.btnRegTools.Size = New System.Drawing.Size(114, 27)
        Me.btnRegTools.TabIndex = 3
        Me.btnRegTools.Text = "Registry Tools"
        Me.btnRegTools.UseVisualStyleBackColor = True
        '
        'btnMemCleaner
        '
        Me.btnMemCleaner.Location = New System.Drawing.Point(1, 187)
        Me.btnMemCleaner.Name = "btnMemCleaner"
        Me.btnMemCleaner.Size = New System.Drawing.Size(114, 27)
        Me.btnMemCleaner.TabIndex = 4
        Me.btnMemCleaner.Text = "Memory Cleaner"
        Me.btnMemCleaner.UseVisualStyleBackColor = True
        '
        'btnProcExplr
        '
        Me.btnProcExplr.Enabled = False
        Me.btnProcExplr.Location = New System.Drawing.Point(1, 220)
        Me.btnProcExplr.Name = "btnProcExplr"
        Me.btnProcExplr.Size = New System.Drawing.Size(114, 27)
        Me.btnProcExplr.TabIndex = 5
        Me.btnProcExplr.Text = "Process Explorer"
        Me.btnProcExplr.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(1, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 27)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Secure Eraser"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(1, 286)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 27)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Quarantine"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnGCLen
        '
        Me.btnGCLen.Location = New System.Drawing.Point(1, 319)
        Me.btnGCLen.Name = "btnGCLen"
        Me.btnGCLen.Size = New System.Drawing.Size(114, 27)
        Me.btnGCLen.TabIndex = 8
        Me.btnGCLen.Text = "GCleaner"
        Me.btnGCLen.UseVisualStyleBackColor = True
        '
        'btnMinTray
        '
        Me.btnMinTray.Location = New System.Drawing.Point(1, 370)
        Me.btnMinTray.Name = "btnMinTray"
        Me.btnMinTray.Size = New System.Drawing.Size(114, 27)
        Me.btnMinTray.TabIndex = 9
        Me.btnMinTray.Text = "Exit"
        Me.btnMinTray.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Enabled = False
        Me.btnAbout.Location = New System.Drawing.Point(1, 401)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(114, 27)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'TimerSpeed
        '
        Me.TimerSpeed.Enabled = True
        Me.TimerSpeed.Interval = 1
        '
        'TimerDownloadSpeed
        '
        Me.TimerDownloadSpeed.Interval = 1000
        '
        'bgWorker2
        '
        '
        'tSysInfo
        '
        Me.tSysInfo.Enabled = True
        Me.tSysInfo.Interval = 1000.0R
        Me.tSysInfo.SynchronizingObject = Me
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        '
        'tmrClear
        '
        Me.tmrClear.Interval = 1000
        '
        'bgWorker1
        '
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 650
        '
        'pfcCPU
        '
        Me.pfcCPU.CategoryName = "Processor"
        Me.pfcCPU.CounterName = "% Processor Time"
        Me.pfcCPU.InstanceName = "_Total"
        '
        'tmrCPU
        '
        Me.tmrCPU.Enabled = True
        Me.tmrCPU.Interval = 500
        '
        'imgIcons
        '
        Me.imgIcons.ImageStream = CType(resources.GetObject("imgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIcons.Images.SetKeyName(0, "blank_16x16.png")
        Me.imgIcons.Images.SetKeyName(1, "chrome_16x16.png")
        Me.imgIcons.Images.SetKeyName(2, "firefox_16x16.png")
        Me.imgIcons.Images.SetKeyName(3, "ie9_16x16.png")
        Me.imgIcons.Images.SetKeyName(4, "safari_16x16.png")
        Me.imgIcons.Images.SetKeyName(5, "opera_16x16.png")
        Me.imgIcons.Images.SetKeyName(6, "explorer_16x16.png")
        Me.imgIcons.Images.SetKeyName(7, "system_16x16.png")
        Me.imgIcons.Images.SetKeyName(8, "advanced_16x16.png")
        Me.imgIcons.Images.SetKeyName(9, "internet_16x16.png")
        Me.imgIcons.Images.SetKeyName(10, "mis_app_16x16.png")
        Me.imgIcons.Images.SetKeyName(11, "media_16x16.png")
        Me.imgIcons.Images.SetKeyName(12, "antivirus_16x16.png")
        Me.imgIcons.Images.SetKeyName(13, "vs2010_16x16.png")
        '
        'tabctrl_1
        '
        Me.tabctrl_1.Controls.Add(Me.tabMemClnr)
        Me.tabctrl_1.Controls.Add(Me.tabRegTool)
        Me.tabctrl_1.Controls.Add(Me.tabAdEvader)
        Me.tabctrl_1.Controls.Add(Me.tabGCleaner)
        Me.tabctrl_1.Location = New System.Drawing.Point(121, 88)
        Me.tabctrl_1.Name = "tabctrl_1"
        Me.tabctrl_1.SelectedIndex = 0
        Me.tabctrl_1.Size = New System.Drawing.Size(603, 340)
        Me.tabctrl_1.TabIndex = 27
        '
        'tabMemClnr
        '
        Me.tabMemClnr.Controls.Add(Me.Label23)
        Me.tabMemClnr.Controls.Add(Me.bxPhysicalMem)
        Me.tabMemClnr.Controls.Add(Me.lblNoProc)
        Me.tabMemClnr.Controls.Add(Me.prgClear)
        Me.tabMemClnr.Controls.Add(Me.bxKernelMemory)
        Me.tabMemClnr.Controls.Add(Me.Label20)
        Me.tabMemClnr.Controls.Add(Me.bxCommitCharge)
        Me.tabMemClnr.Controls.Add(Me.bxTotals)
        Me.tabMemClnr.Controls.Add(Me.lblAvailVirMemPercent)
        Me.tabMemClnr.Controls.Add(Me.lblPercentAvailPhys)
        Me.tabMemClnr.Controls.Add(Me.prgmemoryVir)
        Me.tabMemClnr.Controls.Add(Me.prgmemory)
        Me.tabMemClnr.Controls.Add(Me.lblAvailVirMem)
        Me.tabMemClnr.Controls.Add(Me.lblAvailPhysMem)
        Me.tabMemClnr.Controls.Add(Me.Label24)
        Me.tabMemClnr.Controls.Add(Me.lbl3)
        Me.tabMemClnr.Controls.Add(Me.numUpDown)
        Me.tabMemClnr.Controls.Add(Me.lblTotVir)
        Me.tabMemClnr.Controls.Add(Me.lblTotPhys)
        Me.tabMemClnr.Controls.Add(Me.lbl2)
        Me.tabMemClnr.Controls.Add(Me.lbl1)
        Me.tabMemClnr.Controls.Add(Me.btnAutFreof)
        Me.tabMemClnr.Controls.Add(Me.lstProc)
        Me.tabMemClnr.Controls.Add(Me.btnAutFre)
        Me.tabMemClnr.Controls.Add(Me.btnFreeMem)
        Me.tabMemClnr.Controls.Add(Me.prgTime)
        Me.tabMemClnr.Location = New System.Drawing.Point(4, 24)
        Me.tabMemClnr.Name = "tabMemClnr"
        Me.tabMemClnr.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMemClnr.Size = New System.Drawing.Size(595, 312)
        Me.tabMemClnr.TabIndex = 0
        Me.tabMemClnr.Text = "Memory Cleaner"
        Me.tabMemClnr.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(533, 284)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 15)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Min"
        '
        'bxPhysicalMem
        '
        Me.bxPhysicalMem.Controls.Add(Me.lblPhysCacheFaults)
        Me.bxPhysicalMem.Controls.Add(Me.lblPhysMemPeak)
        Me.bxPhysicalMem.Controls.Add(Me.Label13)
        Me.bxPhysicalMem.Controls.Add(Me.Label10)
        Me.bxPhysicalMem.Controls.Add(Me.lblPhysMemCache)
        Me.bxPhysicalMem.Controls.Add(Me.lblPhysMemAvailable)
        Me.bxPhysicalMem.Controls.Add(Me.lblPhysMemTotal)
        Me.bxPhysicalMem.Controls.Add(Me.Label5)
        Me.bxPhysicalMem.Controls.Add(Me.Label6)
        Me.bxPhysicalMem.Controls.Add(Me.Label7)
        Me.bxPhysicalMem.Location = New System.Drawing.Point(15, 23)
        Me.bxPhysicalMem.Name = "bxPhysicalMem"
        Me.bxPhysicalMem.Size = New System.Drawing.Size(316, 77)
        Me.bxPhysicalMem.TabIndex = 78
        Me.bxPhysicalMem.TabStop = False
        Me.bxPhysicalMem.Text = "Physical Memory (KB)"
        '
        'lblPhysCacheFaults
        '
        Me.lblPhysCacheFaults.AutoSize = True
        Me.lblPhysCacheFaults.Location = New System.Drawing.Point(253, 55)
        Me.lblPhysCacheFaults.Name = "lblPhysCacheFaults"
        Me.lblPhysCacheFaults.Size = New System.Drawing.Size(14, 15)
        Me.lblPhysCacheFaults.TabIndex = 9
        Me.lblPhysCacheFaults.Text = "#"
        '
        'lblPhysMemPeak
        '
        Me.lblPhysMemPeak.AutoSize = True
        Me.lblPhysMemPeak.Location = New System.Drawing.Point(253, 23)
        Me.lblPhysMemPeak.Name = "lblPhysMemPeak"
        Me.lblPhysMemPeak.Size = New System.Drawing.Size(14, 15)
        Me.lblPhysMemPeak.TabIndex = 8
        Me.lblPhysMemPeak.Text = "#"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(165, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 15)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Cache Faults/s"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Peak"
        '
        'lblPhysMemCache
        '
        Me.lblPhysMemCache.AutoSize = True
        Me.lblPhysMemCache.Location = New System.Drawing.Point(108, 55)
        Me.lblPhysMemCache.Name = "lblPhysMemCache"
        Me.lblPhysMemCache.Size = New System.Drawing.Size(14, 15)
        Me.lblPhysMemCache.TabIndex = 5
        Me.lblPhysMemCache.Text = "#"
        '
        'lblPhysMemAvailable
        '
        Me.lblPhysMemAvailable.AutoSize = True
        Me.lblPhysMemAvailable.Location = New System.Drawing.Point(108, 39)
        Me.lblPhysMemAvailable.Name = "lblPhysMemAvailable"
        Me.lblPhysMemAvailable.Size = New System.Drawing.Size(14, 15)
        Me.lblPhysMemAvailable.TabIndex = 4
        Me.lblPhysMemAvailable.Text = "#"
        '
        'lblPhysMemTotal
        '
        Me.lblPhysMemTotal.AutoSize = True
        Me.lblPhysMemTotal.Location = New System.Drawing.Point(108, 23)
        Me.lblPhysMemTotal.Name = "lblPhysMemTotal"
        Me.lblPhysMemTotal.Size = New System.Drawing.Size(14, 15)
        Me.lblPhysMemTotal.TabIndex = 3
        Me.lblPhysMemTotal.Text = "#"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "System Cache"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Available"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total"
        '
        'lblNoProc
        '
        Me.lblNoProc.AutoSize = True
        Me.lblNoProc.Location = New System.Drawing.Point(95, 113)
        Me.lblNoProc.Name = "lblNoProc"
        Me.lblNoProc.Size = New System.Drawing.Size(14, 15)
        Me.lblNoProc.TabIndex = 82
        Me.lblNoProc.Text = "#"
        '
        'prgClear
        '
        Me.prgClear.Location = New System.Drawing.Point(18, 161)
        Me.prgClear.MarqueeAnimationSpeed = 0
        Me.prgClear.Name = "prgClear"
        Me.prgClear.Size = New System.Drawing.Size(326, 23)
        Me.prgClear.TabIndex = 80
        Me.prgClear.Value = 100
        '
        'bxKernelMemory
        '
        Me.bxKernelMemory.Controls.Add(Me.lblKerMemNonpaged)
        Me.bxKernelMemory.Controls.Add(Me.Label11)
        Me.bxKernelMemory.Controls.Add(Me.lblKerMemVirtual)
        Me.bxKernelMemory.Controls.Add(Me.lblKerMemPhys)
        Me.bxKernelMemory.Controls.Add(Me.Label12)
        Me.bxKernelMemory.Controls.Add(Me.Label14)
        Me.bxKernelMemory.Location = New System.Drawing.Point(350, 113)
        Me.bxKernelMemory.Name = "bxKernelMemory"
        Me.bxKernelMemory.Size = New System.Drawing.Size(200, 71)
        Me.bxKernelMemory.TabIndex = 79
        Me.bxKernelMemory.TabStop = False
        Me.bxKernelMemory.Text = "Kernel Memory (KB)"
        '
        'lblKerMemNonpaged
        '
        Me.lblKerMemNonpaged.AutoSize = True
        Me.lblKerMemNonpaged.Location = New System.Drawing.Point(108, 49)
        Me.lblKerMemNonpaged.Name = "lblKerMemNonpaged"
        Me.lblKerMemNonpaged.Size = New System.Drawing.Size(14, 15)
        Me.lblKerMemNonpaged.TabIndex = 7
        Me.lblKerMemNonpaged.Text = "#"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Nonpaged"
        '
        'lblKerMemVirtual
        '
        Me.lblKerMemVirtual.AutoSize = True
        Me.lblKerMemVirtual.Location = New System.Drawing.Point(108, 29)
        Me.lblKerMemVirtual.Name = "lblKerMemVirtual"
        Me.lblKerMemVirtual.Size = New System.Drawing.Size(14, 15)
        Me.lblKerMemVirtual.TabIndex = 4
        Me.lblKerMemVirtual.Text = "#"
        '
        'lblKerMemPhys
        '
        Me.lblKerMemPhys.AutoSize = True
        Me.lblKerMemPhys.Location = New System.Drawing.Point(108, 17)
        Me.lblKerMemPhys.Name = "lblKerMemPhys"
        Me.lblKerMemPhys.Size = New System.Drawing.Size(14, 15)
        Me.lblKerMemPhys.TabIndex = 3
        Me.lblKerMemPhys.Text = "#"
        Me.lblKerMemPhys.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Paged Virtual"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Paged Physical"
        Me.Label14.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 15)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "Processes"
        '
        'bxCommitCharge
        '
        Me.bxCommitCharge.Controls.Add(Me.lblCommitPeak)
        Me.bxCommitCharge.Controls.Add(Me.lblCommitLimit)
        Me.bxCommitCharge.Controls.Add(Me.lblCommitCurrent)
        Me.bxCommitCharge.Controls.Add(Me.Label8)
        Me.bxCommitCharge.Controls.Add(Me.Label9)
        Me.bxCommitCharge.Controls.Add(Me.Label15)
        Me.bxCommitCharge.Location = New System.Drawing.Point(350, 23)
        Me.bxCommitCharge.Name = "bxCommitCharge"
        Me.bxCommitCharge.Size = New System.Drawing.Size(200, 77)
        Me.bxCommitCharge.TabIndex = 77
        Me.bxCommitCharge.TabStop = False
        Me.bxCommitCharge.Text = "Commit Charge (KB)"
        '
        'lblCommitPeak
        '
        Me.lblCommitPeak.AutoSize = True
        Me.lblCommitPeak.Location = New System.Drawing.Point(108, 55)
        Me.lblCommitPeak.Name = "lblCommitPeak"
        Me.lblCommitPeak.Size = New System.Drawing.Size(14, 15)
        Me.lblCommitPeak.TabIndex = 5
        Me.lblCommitPeak.Text = "#"
        Me.lblCommitPeak.Visible = False
        '
        'lblCommitLimit
        '
        Me.lblCommitLimit.AutoSize = True
        Me.lblCommitLimit.Location = New System.Drawing.Point(108, 42)
        Me.lblCommitLimit.Name = "lblCommitLimit"
        Me.lblCommitLimit.Size = New System.Drawing.Size(14, 15)
        Me.lblCommitLimit.TabIndex = 4
        Me.lblCommitLimit.Text = "#"
        '
        'lblCommitCurrent
        '
        Me.lblCommitCurrent.AutoSize = True
        Me.lblCommitCurrent.Location = New System.Drawing.Point(108, 23)
        Me.lblCommitCurrent.Name = "lblCommitCurrent"
        Me.lblCommitCurrent.Size = New System.Drawing.Size(14, 15)
        Me.lblCommitCurrent.TabIndex = 3
        Me.lblCommitCurrent.Text = "#"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Peak"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Limit"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Current"
        '
        'bxTotals
        '
        Me.bxTotals.Controls.Add(Me.lblTotIOOther)
        Me.bxTotals.Controls.Add(Me.lblTotIOWrite)
        Me.bxTotals.Controls.Add(Me.lblTotIORead)
        Me.bxTotals.Controls.Add(Me.Label19)
        Me.bxTotals.Controls.Add(Me.Label18)
        Me.bxTotals.Controls.Add(Me.Label17)
        Me.bxTotals.Controls.Add(Me.lblTotalProcesses)
        Me.bxTotals.Controls.Add(Me.lblTotalsThreads)
        Me.bxTotals.Controls.Add(Me.lblTotalHandles)
        Me.bxTotals.Controls.Add(Me.Label16)
        Me.bxTotals.Controls.Add(Me.Label21)
        Me.bxTotals.Controls.Add(Me.Label22)
        Me.bxTotals.Location = New System.Drawing.Point(18, 23)
        Me.bxTotals.Name = "bxTotals"
        Me.bxTotals.Size = New System.Drawing.Size(132, 77)
        Me.bxTotals.TabIndex = 76
        Me.bxTotals.TabStop = False
        Me.bxTotals.Text = "Totals"
        Me.bxTotals.Visible = False
        '
        'lblTotIOOther
        '
        Me.lblTotIOOther.AutoSize = True
        Me.lblTotIOOther.Location = New System.Drawing.Point(275, 55)
        Me.lblTotIOOther.Name = "lblTotIOOther"
        Me.lblTotIOOther.Size = New System.Drawing.Size(14, 15)
        Me.lblTotIOOther.TabIndex = 11
        Me.lblTotIOOther.Text = "#"
        '
        'lblTotIOWrite
        '
        Me.lblTotIOWrite.AutoSize = True
        Me.lblTotIOWrite.Location = New System.Drawing.Point(275, 39)
        Me.lblTotIOWrite.Name = "lblTotIOWrite"
        Me.lblTotIOWrite.Size = New System.Drawing.Size(14, 15)
        Me.lblTotIOWrite.TabIndex = 10
        Me.lblTotIOWrite.Text = "#"
        '
        'lblTotIORead
        '
        Me.lblTotIORead.AutoSize = True
        Me.lblTotIORead.Location = New System.Drawing.Point(275, 23)
        Me.lblTotIORead.Name = "lblTotIORead"
        Me.lblTotIORead.Size = New System.Drawing.Size(14, 15)
        Me.lblTotIORead.TabIndex = 9
        Me.lblTotIORead.Text = "#"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(165, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 15)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "I/O Other Bytes:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(165, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 15)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "I/O Write Bytes:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(165, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 15)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "I/O Read Bytes:"
        '
        'lblTotalProcesses
        '
        Me.lblTotalProcesses.AutoSize = True
        Me.lblTotalProcesses.Location = New System.Drawing.Point(108, 55)
        Me.lblTotalProcesses.Name = "lblTotalProcesses"
        Me.lblTotalProcesses.Size = New System.Drawing.Size(14, 15)
        Me.lblTotalProcesses.TabIndex = 5
        Me.lblTotalProcesses.Text = "#"
        '
        'lblTotalsThreads
        '
        Me.lblTotalsThreads.AutoSize = True
        Me.lblTotalsThreads.Location = New System.Drawing.Point(108, 39)
        Me.lblTotalsThreads.Name = "lblTotalsThreads"
        Me.lblTotalsThreads.Size = New System.Drawing.Size(14, 15)
        Me.lblTotalsThreads.TabIndex = 4
        Me.lblTotalsThreads.Text = "#"
        '
        'lblTotalHandles
        '
        Me.lblTotalHandles.AutoSize = True
        Me.lblTotalHandles.Location = New System.Drawing.Point(108, 23)
        Me.lblTotalHandles.Name = "lblTotalHandles"
        Me.lblTotalHandles.Size = New System.Drawing.Size(14, 15)
        Me.lblTotalHandles.TabIndex = 3
        Me.lblTotalHandles.Text = "#"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 15)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Processes"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 15)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Threads"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Handles"
        '
        'lblAvailVirMemPercent
        '
        Me.lblAvailVirMemPercent.AutoSize = True
        Me.lblAvailVirMemPercent.Location = New System.Drawing.Point(15, 226)
        Me.lblAvailVirMemPercent.Name = "lblAvailVirMemPercent"
        Me.lblAvailVirMemPercent.Size = New System.Drawing.Size(140, 15)
        Me.lblAvailVirMemPercent.TabIndex = 75
        Me.lblAvailVirMemPercent.Text = "Available Virtual Memory"
        '
        'lblPercentAvailPhys
        '
        Me.lblPercentAvailPhys.AutoSize = True
        Me.lblPercentAvailPhys.Location = New System.Drawing.Point(15, 201)
        Me.lblPercentAvailPhys.Name = "lblPercentAvailPhys"
        Me.lblPercentAvailPhys.Size = New System.Drawing.Size(148, 15)
        Me.lblPercentAvailPhys.TabIndex = 74
        Me.lblPercentAvailPhys.Text = "Available Physical Memory"
        '
        'prgmemoryVir
        '
        Me.prgmemoryVir.Location = New System.Drawing.Point(220, 217)
        Me.prgmemoryVir.Name = "prgmemoryVir"
        Me.prgmemoryVir.Size = New System.Drawing.Size(330, 22)
        Me.prgmemoryVir.TabIndex = 73
        '
        'prgmemory
        '
        Me.prgmemory.Location = New System.Drawing.Point(220, 192)
        Me.prgmemory.Name = "prgmemory"
        Me.prgmemory.Size = New System.Drawing.Size(330, 22)
        Me.prgmemory.TabIndex = 69
        '
        'lblAvailVirMem
        '
        Me.lblAvailVirMem.AutoSize = True
        Me.lblAvailVirMem.Location = New System.Drawing.Point(411, 258)
        Me.lblAvailVirMem.Name = "lblAvailVirMem"
        Me.lblAvailVirMem.Size = New System.Drawing.Size(87, 15)
        Me.lblAvailVirMem.TabIndex = 72
        Me.lblAvailVirMem.Text = "lblAvailVirMem"
        '
        'lblAvailPhysMem
        '
        Me.lblAvailPhysMem.AutoSize = True
        Me.lblAvailPhysMem.Location = New System.Drawing.Point(411, 242)
        Me.lblAvailPhysMem.Name = "lblAvailPhysMem"
        Me.lblAvailPhysMem.Size = New System.Drawing.Size(97, 15)
        Me.lblAvailPhysMem.TabIndex = 71
        Me.lblAvailPhysMem.Text = "lblAvailPhysMem"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(217, 258)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(119, 15)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Used Virtual Memory"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(217, 242)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(127, 15)
        Me.lbl3.TabIndex = 68
        Me.lbl3.Text = "Used Physical Memory"
        '
        'numUpDown
        '
        Me.numUpDown.Location = New System.Drawing.Point(492, 277)
        Me.numUpDown.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numUpDown.Name = "numUpDown"
        Me.numUpDown.Size = New System.Drawing.Size(35, 24)
        Me.numUpDown.TabIndex = 61
        Me.numUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTotVir
        '
        Me.lblTotVir.AutoSize = True
        Me.lblTotVir.Location = New System.Drawing.Point(139, 258)
        Me.lblTotVir.Name = "lblTotVir"
        Me.lblTotVir.Size = New System.Drawing.Size(42, 15)
        Me.lblTotVir.TabIndex = 67
        Me.lblTotVir.Text = "Label5"
        '
        'lblTotPhys
        '
        Me.lblTotPhys.AutoSize = True
        Me.lblTotPhys.Location = New System.Drawing.Point(139, 242)
        Me.lblTotPhys.Name = "lblTotPhys"
        Me.lblTotPhys.Size = New System.Drawing.Size(42, 15)
        Me.lblTotPhys.TabIndex = 66
        Me.lblTotPhys.Text = "Label4"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(15, 258)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(119, 15)
        Me.lbl2.TabIndex = 65
        Me.lbl2.Text = "Total Virtual Memory"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(15, 242)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(127, 15)
        Me.lbl1.TabIndex = 64
        Me.lbl1.Text = "Total Physical Memory"
        '
        'btnAutFreof
        '
        Me.btnAutFreof.Location = New System.Drawing.Point(350, 280)
        Me.btnAutFreof.Name = "btnAutFreof"
        Me.btnAutFreof.Size = New System.Drawing.Size(130, 23)
        Me.btnAutFreof.TabIndex = 63
        Me.btnAutFreof.Text = "Auto Free Mem Off"
        Me.btnAutFreof.UseVisualStyleBackColor = True
        '
        'lstProc
        '
        Me.lstProc.FormattingEnabled = True
        Me.lstProc.ItemHeight = 15
        Me.lstProc.Location = New System.Drawing.Point(529, 23)
        Me.lstProc.Name = "lstProc"
        Me.lstProc.Size = New System.Drawing.Size(39, 4)
        Me.lstProc.TabIndex = 62
        Me.lstProc.Visible = False
        '
        'btnAutFre
        '
        Me.btnAutFre.Location = New System.Drawing.Point(220, 280)
        Me.btnAutFre.Name = "btnAutFre"
        Me.btnAutFre.Size = New System.Drawing.Size(130, 23)
        Me.btnAutFre.TabIndex = 60
        Me.btnAutFre.Text = "Auto Free Mem On"
        Me.btnAutFre.UseVisualStyleBackColor = True
        '
        'btnFreeMem
        '
        Me.btnFreeMem.Location = New System.Drawing.Point(15, 280)
        Me.btnFreeMem.Name = "btnFreeMem"
        Me.btnFreeMem.Size = New System.Drawing.Size(116, 23)
        Me.btnFreeMem.TabIndex = 59
        Me.btnFreeMem.Text = "Free Memory"
        Me.btnFreeMem.UseVisualStyleBackColor = True
        '
        'prgTime
        '
        Me.prgTime.Location = New System.Drawing.Point(18, 132)
        Me.prgTime.Name = "prgTime"
        Me.prgTime.Size = New System.Drawing.Size(326, 23)
        Me.prgTime.TabIndex = 58
        '
        'tabRegTool
        '
        Me.tabRegTool.Controls.Add(Me.TabControl1)
        Me.tabRegTool.Location = New System.Drawing.Point(4, 24)
        Me.tabRegTool.Name = "tabRegTool"
        Me.tabRegTool.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRegTool.Size = New System.Drawing.Size(595, 312)
        Me.tabRegTool.TabIndex = 1
        Me.tabRegTool.Text = "Registry Tools"
        Me.tabRegTool.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(19, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 302)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lstRegAVList)
        Me.TabPage1.Controls.Add(Me.btnFixReg)
        Me.TabPage1.Controls.Add(Me.btnScanReg)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(548, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registry Antivirus"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ANOMALIES FOUND:"
        '
        'lstRegAVList
        '
        Me.lstRegAVList.FormattingEnabled = True
        Me.lstRegAVList.ItemHeight = 15
        Me.lstRegAVList.Location = New System.Drawing.Point(7, 26)
        Me.lstRegAVList.Name = "lstRegAVList"
        Me.lstRegAVList.Size = New System.Drawing.Size(532, 199)
        Me.lstRegAVList.TabIndex = 0
        '
        'btnFixReg
        '
        Me.btnFixReg.Enabled = False
        Me.btnFixReg.Location = New System.Drawing.Point(88, 229)
        Me.btnFixReg.Name = "btnFixReg"
        Me.btnFixReg.Size = New System.Drawing.Size(75, 23)
        Me.btnFixReg.TabIndex = 1
        Me.btnFixReg.Text = "F&ix"
        Me.btnFixReg.UseVisualStyleBackColor = True
        '
        'btnScanReg
        '
        Me.btnScanReg.Location = New System.Drawing.Point(7, 229)
        Me.btnScanReg.Name = "btnScanReg"
        Me.btnScanReg.Size = New System.Drawing.Size(75, 23)
        Me.btnScanReg.TabIndex = 0
        Me.btnScanReg.Text = "S&can"
        Me.btnScanReg.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSaveSel)
        Me.TabPage2.Controls.Add(Me.btnSelDefREG)
        Me.TabPage2.Controls.Add(Me.btnSelNonREG)
        Me.TabPage2.Controls.Add(Me.btnSelAllREG)
        Me.TabPage2.Controls.Add(Me.chkTrayCNTX)
        Me.TabPage2.Controls.Add(Me.chkSetTaskbar)
        Me.TabPage2.Controls.Add(Me.chkWinLogoff)
        Me.TabPage2.Controls.Add(Me.chkDisCPL)
        Me.TabPage2.Controls.Add(Me.chkWinLock)
        Me.TabPage2.Controls.Add(Me.chkWinClose)
        Me.TabPage2.Controls.Add(Me.chkChWP)
        Me.TabPage2.Controls.Add(Me.chkChangePW)
        Me.TabPage2.Controls.Add(Me.chkRecentDoc)
        Me.TabPage2.Controls.Add(Me.htmlwallpaper)
        Me.TabPage2.Controls.Add(Me.wallpaper)
        Me.TabPage2.Controls.Add(Me.taskbarcontext)
        Me.TabPage2.Controls.Add(Me.savesettings)
        Me.TabPage2.Controls.Add(Me.addremove)
        Me.TabPage2.Controls.Add(Me.winupdate)
        Me.TabPage2.Controls.Add(Me.filemenu)
        Me.TabPage2.Controls.Add(Me.logoff)
        Me.TabPage2.Controls.Add(Me.run)
        Me.TabPage2.Controls.Add(Me.taskbar)
        Me.TabPage2.Controls.Add(Me.desktop)
        Me.TabPage2.Controls.Add(Me.cpl)
        Me.TabPage2.Controls.Add(Me.cmd)
        Me.TabPage2.Controls.Add(Me.fldopt)
        Me.TabPage2.Controls.Add(Me.regedit)
        Me.TabPage2.Controls.Add(Me.tskmgr)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(548, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registry Restriction Tool"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSaveSel
        '
        Me.btnSaveSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSel.Location = New System.Drawing.Point(464, 230)
        Me.btnSaveSel.Name = "btnSaveSel"
        Me.btnSaveSel.Size = New System.Drawing.Size(75, 25)
        Me.btnSaveSel.TabIndex = 66
        Me.btnSaveSel.Text = "Save"
        Me.btnSaveSel.UseVisualStyleBackColor = True
        '
        'btnSelDefREG
        '
        Me.btnSelDefREG.Location = New System.Drawing.Point(464, 204)
        Me.btnSelDefREG.Name = "btnSelDefREG"
        Me.btnSelDefREG.Size = New System.Drawing.Size(75, 25)
        Me.btnSelDefREG.TabIndex = 65
        Me.btnSelDefREG.Text = "Default"
        Me.btnSelDefREG.UseVisualStyleBackColor = True
        '
        'btnSelNonREG
        '
        Me.btnSelNonREG.Location = New System.Drawing.Point(379, 204)
        Me.btnSelNonREG.Name = "btnSelNonREG"
        Me.btnSelNonREG.Size = New System.Drawing.Size(75, 25)
        Me.btnSelNonREG.TabIndex = 64
        Me.btnSelNonREG.Text = "Select None"
        Me.btnSelNonREG.UseVisualStyleBackColor = True
        '
        'btnSelAllREG
        '
        Me.btnSelAllREG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelAllREG.Location = New System.Drawing.Point(298, 204)
        Me.btnSelAllREG.Name = "btnSelAllREG"
        Me.btnSelAllREG.Size = New System.Drawing.Size(75, 25)
        Me.btnSelAllREG.TabIndex = 63
        Me.btnSelAllREG.Text = "Select All"
        Me.btnSelAllREG.UseVisualStyleBackColor = True
        '
        'chkTrayCNTX
        '
        Me.chkTrayCNTX.AutoSize = True
        Me.chkTrayCNTX.Checked = True
        Me.chkTrayCNTX.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTrayCNTX.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrayCNTX.Location = New System.Drawing.Point(256, 187)
        Me.chkTrayCNTX.Name = "chkTrayCNTX"
        Me.chkTrayCNTX.Size = New System.Drawing.Size(252, 21)
        Me.chkTrayCNTX.TabIndex = 62
        Me.chkTrayCNTX.Text = "Windows Tray Context Menu"
        Me.chkTrayCNTX.UseVisualStyleBackColor = True
        '
        'chkSetTaskbar
        '
        Me.chkSetTaskbar.AutoSize = True
        Me.chkSetTaskbar.Checked = True
        Me.chkSetTaskbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetTaskbar.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetTaskbar.Location = New System.Drawing.Point(256, 169)
        Me.chkSetTaskbar.Name = "chkSetTaskbar"
        Me.chkSetTaskbar.Size = New System.Drawing.Size(198, 21)
        Me.chkSetTaskbar.TabIndex = 61
        Me.chkSetTaskbar.Text = "Windows Set Taskbar"
        Me.chkSetTaskbar.UseVisualStyleBackColor = True
        '
        'chkWinLogoff
        '
        Me.chkWinLogoff.AutoSize = True
        Me.chkWinLogoff.Checked = True
        Me.chkWinLogoff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWinLogoff.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWinLogoff.Location = New System.Drawing.Point(256, 151)
        Me.chkWinLogoff.Name = "chkWinLogoff"
        Me.chkWinLogoff.Size = New System.Drawing.Size(162, 21)
        Me.chkWinLogoff.TabIndex = 60
        Me.chkWinLogoff.Text = "Windows Log Off"
        Me.chkWinLogoff.UseVisualStyleBackColor = True
        '
        'chkDisCPL
        '
        Me.chkDisCPL.AutoSize = True
        Me.chkDisCPL.Checked = True
        Me.chkDisCPL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisCPL.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisCPL.Location = New System.Drawing.Point(256, 133)
        Me.chkDisCPL.Name = "chkDisCPL"
        Me.chkDisCPL.Size = New System.Drawing.Size(288, 21)
        Me.chkDisCPL.TabIndex = 59
        Me.chkDisCPL.Text = "Windows Display Control Panel"
        Me.chkDisCPL.UseVisualStyleBackColor = True
        '
        'chkWinLock
        '
        Me.chkWinLock.AutoSize = True
        Me.chkWinLock.Checked = True
        Me.chkWinLock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWinLock.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWinLock.Location = New System.Drawing.Point(256, 115)
        Me.chkWinLock.Name = "chkWinLock"
        Me.chkWinLock.Size = New System.Drawing.Size(243, 21)
        Me.chkWinLock.TabIndex = 58
        Me.chkWinLock.Text = "Windows Lock Workstation"
        Me.chkWinLock.UseVisualStyleBackColor = True
        '
        'chkWinClose
        '
        Me.chkWinClose.AutoSize = True
        Me.chkWinClose.Checked = True
        Me.chkWinClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWinClose.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWinClose.Location = New System.Drawing.Point(256, 97)
        Me.chkWinClose.Name = "chkWinClose"
        Me.chkWinClose.Size = New System.Drawing.Size(144, 21)
        Me.chkWinClose.TabIndex = 57
        Me.chkWinClose.Text = "Windows Close"
        Me.chkWinClose.UseVisualStyleBackColor = True
        '
        'chkChWP
        '
        Me.chkChWP.AutoSize = True
        Me.chkChWP.Checked = True
        Me.chkChWP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChWP.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChWP.Location = New System.Drawing.Point(256, 79)
        Me.chkChWP.Name = "chkChWP"
        Me.chkChWP.Size = New System.Drawing.Size(243, 21)
        Me.chkChWP.TabIndex = 56
        Me.chkChWP.Text = "Windows Change Wallpaper"
        Me.chkChWP.UseVisualStyleBackColor = True
        '
        'chkChangePW
        '
        Me.chkChangePW.AutoSize = True
        Me.chkChangePW.Checked = True
        Me.chkChangePW.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangePW.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkChangePW.Location = New System.Drawing.Point(256, 61)
        Me.chkChangePW.Name = "chkChangePW"
        Me.chkChangePW.Size = New System.Drawing.Size(234, 21)
        Me.chkChangePW.TabIndex = 55
        Me.chkChangePW.Text = "Windows Change Password"
        Me.chkChangePW.UseVisualStyleBackColor = True
        '
        'chkRecentDoc
        '
        Me.chkRecentDoc.AutoSize = True
        Me.chkRecentDoc.Checked = True
        Me.chkRecentDoc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecentDoc.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecentDoc.Location = New System.Drawing.Point(256, 43)
        Me.chkRecentDoc.Name = "chkRecentDoc"
        Me.chkRecentDoc.Size = New System.Drawing.Size(216, 21)
        Me.chkRecentDoc.TabIndex = 54
        Me.chkRecentDoc.Text = "Recent Documents Menu"
        Me.chkRecentDoc.UseVisualStyleBackColor = True
        '
        'htmlwallpaper
        '
        Me.htmlwallpaper.AutoSize = True
        Me.htmlwallpaper.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htmlwallpaper.Location = New System.Drawing.Point(256, 6)
        Me.htmlwallpaper.Name = "htmlwallpaper"
        Me.htmlwallpaper.Size = New System.Drawing.Size(270, 21)
        Me.htmlwallpaper.TabIndex = 53
        Me.htmlwallpaper.Text = "Don't Allow HTML WallPaper "
        Me.htmlwallpaper.UseVisualStyleBackColor = True
        '
        'wallpaper
        '
        Me.wallpaper.AutoSize = True
        Me.wallpaper.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wallpaper.Location = New System.Drawing.Point(7, 237)
        Me.wallpaper.Name = "wallpaper"
        Me.wallpaper.Size = New System.Drawing.Size(225, 21)
        Me.wallpaper.TabIndex = 52
        Me.wallpaper.Text = "Don't Change WallPaper"
        Me.wallpaper.UseVisualStyleBackColor = True
        '
        'taskbarcontext
        '
        Me.taskbarcontext.AutoSize = True
        Me.taskbarcontext.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskbarcontext.Location = New System.Drawing.Point(7, 204)
        Me.taskbarcontext.Name = "taskbarcontext"
        Me.taskbarcontext.Size = New System.Drawing.Size(234, 21)
        Me.taskbarcontext.TabIndex = 51
        Me.taskbarcontext.Text = "No Taskbar Context Menu"
        Me.taskbarcontext.UseVisualStyleBackColor = True
        '
        'savesettings
        '
        Me.savesettings.AutoSize = True
        Me.savesettings.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savesettings.Location = New System.Drawing.Point(7, 220)
        Me.savesettings.Name = "savesettings"
        Me.savesettings.Size = New System.Drawing.Size(243, 21)
        Me.savesettings.TabIndex = 50
        Me.savesettings.Text = "No Save Settings on Exit"
        Me.savesettings.UseVisualStyleBackColor = True
        '
        'addremove
        '
        Me.addremove.AutoSize = True
        Me.addremove.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addremove.Location = New System.Drawing.Point(256, 25)
        Me.addremove.Name = "addremove"
        Me.addremove.Size = New System.Drawing.Size(297, 21)
        Me.addremove.TabIndex = 49
        Me.addremove.Text = "No Windows Add/Remove Programs"
        Me.addremove.UseVisualStyleBackColor = True
        '
        'winupdate
        '
        Me.winupdate.AutoSize = True
        Me.winupdate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winupdate.Location = New System.Drawing.Point(7, 187)
        Me.winupdate.Name = "winupdate"
        Me.winupdate.Size = New System.Drawing.Size(180, 21)
        Me.winupdate.TabIndex = 48
        Me.winupdate.Text = "No Windows Update"
        Me.winupdate.UseVisualStyleBackColor = True
        '
        'filemenu
        '
        Me.filemenu.AutoSize = True
        Me.filemenu.Checked = True
        Me.filemenu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.filemenu.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filemenu.Location = New System.Drawing.Point(7, 169)
        Me.filemenu.Name = "filemenu"
        Me.filemenu.Size = New System.Drawing.Size(252, 21)
        Me.filemenu.TabIndex = 47
        Me.filemenu.Text = "Windows Explorer FileMenu"
        Me.filemenu.UseVisualStyleBackColor = True
        '
        'logoff
        '
        Me.logoff.AutoSize = True
        Me.logoff.Checked = True
        Me.logoff.CheckState = System.Windows.Forms.CheckState.Checked
        Me.logoff.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoff.Location = New System.Drawing.Point(7, 151)
        Me.logoff.Name = "logoff"
        Me.logoff.Size = New System.Drawing.Size(243, 21)
        Me.logoff.TabIndex = 46
        Me.logoff.Text = "Windows StartMenu Logoff"
        Me.logoff.UseVisualStyleBackColor = True
        '
        'run
        '
        Me.run.AutoSize = True
        Me.run.Checked = True
        Me.run.CheckState = System.Windows.Forms.CheckState.Checked
        Me.run.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.run.Location = New System.Drawing.Point(7, 133)
        Me.run.Name = "run"
        Me.run.Size = New System.Drawing.Size(216, 21)
        Me.run.TabIndex = 45
        Me.run.Text = "Windows StartMenu Run"
        Me.run.UseVisualStyleBackColor = True
        '
        'taskbar
        '
        Me.taskbar.AutoSize = True
        Me.taskbar.Checked = True
        Me.taskbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.taskbar.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskbar.Location = New System.Drawing.Point(7, 115)
        Me.taskbar.Name = "taskbar"
        Me.taskbar.Size = New System.Drawing.Size(243, 21)
        Me.taskbar.TabIndex = 44
        Me.taskbar.Text = "Windows Explorer Taskbar"
        Me.taskbar.UseVisualStyleBackColor = True
        '
        'desktop
        '
        Me.desktop.AutoSize = True
        Me.desktop.Checked = True
        Me.desktop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.desktop.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desktop.Location = New System.Drawing.Point(7, 97)
        Me.desktop.Name = "desktop"
        Me.desktop.Size = New System.Drawing.Size(243, 21)
        Me.desktop.TabIndex = 43
        Me.desktop.Text = "Windows Explorer Desktop"
        Me.desktop.UseVisualStyleBackColor = True
        '
        'cpl
        '
        Me.cpl.AutoSize = True
        Me.cpl.Checked = True
        Me.cpl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cpl.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpl.Location = New System.Drawing.Point(7, 79)
        Me.cpl.Name = "cpl"
        Me.cpl.Size = New System.Drawing.Size(216, 21)
        Me.cpl.TabIndex = 42
        Me.cpl.Text = "Windows Control Panel"
        Me.cpl.UseVisualStyleBackColor = True
        '
        'cmd
        '
        Me.cmd.AutoSize = True
        Me.cmd.Checked = True
        Me.cmd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd.Location = New System.Drawing.Point(7, 61)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(225, 21)
        Me.cmd.TabIndex = 41
        Me.cmd.Text = "Windows Command Prompt"
        Me.cmd.UseVisualStyleBackColor = True
        '
        'fldopt
        '
        Me.fldopt.AutoSize = True
        Me.fldopt.Checked = True
        Me.fldopt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fldopt.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fldopt.Location = New System.Drawing.Point(7, 43)
        Me.fldopt.Name = "fldopt"
        Me.fldopt.Size = New System.Drawing.Size(225, 21)
        Me.fldopt.TabIndex = 40
        Me.fldopt.Text = "Windows Folder Options"
        Me.fldopt.UseVisualStyleBackColor = True
        '
        'regedit
        '
        Me.regedit.AutoSize = True
        Me.regedit.Checked = True
        Me.regedit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.regedit.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regedit.Location = New System.Drawing.Point(7, 25)
        Me.regedit.Name = "regedit"
        Me.regedit.Size = New System.Drawing.Size(234, 21)
        Me.regedit.TabIndex = 39
        Me.regedit.Text = "Windows Registry Editor"
        Me.regedit.UseVisualStyleBackColor = True
        '
        'tskmgr
        '
        Me.tskmgr.AutoSize = True
        Me.tskmgr.Checked = True
        Me.tskmgr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tskmgr.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tskmgr.Location = New System.Drawing.Point(7, 6)
        Me.tskmgr.Name = "tskmgr"
        Me.tskmgr.Size = New System.Drawing.Size(207, 21)
        Me.tskmgr.TabIndex = 38
        Me.tskmgr.Text = "Windows Task Manager"
        Me.tskmgr.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblStartupNo)
        Me.TabPage3.Controls.Add(Me.btnRefresh)
        Me.TabPage3.Controls.Add(Me.btnDelete)
        Me.TabPage3.Controls.Add(Me.checkedListBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(548, 274)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "StartUp"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblStartupNo
        '
        Me.lblStartupNo.AutoSize = True
        Me.lblStartupNo.Location = New System.Drawing.Point(412, 242)
        Me.lblStartupNo.Name = "lblStartupNo"
        Me.lblStartupNo.Size = New System.Drawing.Size(101, 15)
        Me.lblStartupNo.TabIndex = 5
        Me.lblStartupNo.Text = "Number of Items:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(84, 232)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(3, 232)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'checkedListBox
        '
        Me.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkedListBox.HorizontalScrollbar = True
        Me.checkedListBox.Location = New System.Drawing.Point(3, 3)
        Me.checkedListBox.Name = "checkedListBox"
        Me.checkedListBox.Size = New System.Drawing.Size(542, 211)
        Me.checkedListBox.TabIndex = 2
        '
        'tabAdEvader
        '
        Me.tabAdEvader.Controls.Add(Me.gbAdEvader)
        Me.tabAdEvader.Location = New System.Drawing.Point(4, 24)
        Me.tabAdEvader.Name = "tabAdEvader"
        Me.tabAdEvader.Size = New System.Drawing.Size(595, 312)
        Me.tabAdEvader.TabIndex = 2
        Me.tabAdEvader.Text = "AdEvader"
        Me.tabAdEvader.UseVisualStyleBackColor = True
        '
        'gbAdEvader
        '
        Me.gbAdEvader.Controls.Add(Me.RTF2)
        Me.gbAdEvader.Controls.Add(Me.RTF1)
        Me.gbAdEvader.Controls.Add(Me.Label3)
        Me.gbAdEvader.Controls.Add(Me.Label4)
        Me.gbAdEvader.Controls.Add(Me.btnApplyHosts)
        Me.gbAdEvader.Controls.Add(Me.LabelTime)
        Me.gbAdEvader.Controls.Add(Me.LabelProgress)
        Me.gbAdEvader.Controls.Add(Me.LabelSpeed)
        Me.gbAdEvader.Controls.Add(Me.btnHelpAdBlock)
        Me.gbAdEvader.Controls.Add(Me.btnRemoveAdBlock)
        Me.gbAdEvader.Controls.Add(Me.btnDLApply)
        Me.gbAdEvader.Controls.Add(Me.DownloadProgress1)
        Me.gbAdEvader.Location = New System.Drawing.Point(3, 3)
        Me.gbAdEvader.Name = "gbAdEvader"
        Me.gbAdEvader.Size = New System.Drawing.Size(589, 315)
        Me.gbAdEvader.TabIndex = 21
        Me.gbAdEvader.TabStop = False
        Me.gbAdEvader.Text = "AdEvader"
        '
        'RTF2
        '
        Me.RTF2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RTF2.DetectUrls = False
        Me.RTF2.Location = New System.Drawing.Point(297, 42)
        Me.RTF2.Name = "RTF2"
        Me.RTF2.ReadOnly = True
        Me.RTF2.ShortcutsEnabled = False
        Me.RTF2.Size = New System.Drawing.Size(255, 162)
        Me.RTF2.TabIndex = 39
        Me.RTF2.Text = ""
        Me.RTF2.WordWrap = False
        '
        'RTF1
        '
        Me.RTF1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RTF1.DetectUrls = False
        Me.RTF1.Location = New System.Drawing.Point(23, 42)
        Me.RTF1.Name = "RTF1"
        Me.RTF1.ReadOnly = True
        Me.RTF1.ShortcutsEnabled = False
        Me.RTF1.Size = New System.Drawing.Size(259, 162)
        Me.RTF1.TabIndex = 38
        Me.RTF1.Text = ""
        Me.RTF1.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Local HOSTS File Contents:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 15)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Downloaded HOSTS File Contents:"
        '
        'btnApplyHosts
        '
        Me.btnApplyHosts.Enabled = False
        Me.btnApplyHosts.Location = New System.Drawing.Point(284, 276)
        Me.btnApplyHosts.Name = "btnApplyHosts"
        Me.btnApplyHosts.Size = New System.Drawing.Size(131, 23)
        Me.btnApplyHosts.TabIndex = 35
        Me.btnApplyHosts.Text = "Apply"
        Me.btnApplyHosts.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelTime.Location = New System.Drawing.Point(20, 267)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(217, 16)
        Me.LabelTime.TabIndex = 34
        Me.LabelTime.Text = "Time:"
        '
        'LabelProgress
        '
        Me.LabelProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelProgress.Location = New System.Drawing.Point(20, 235)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(217, 16)
        Me.LabelProgress.TabIndex = 32
        Me.LabelProgress.Text = "Progress:"
        '
        'LabelSpeed
        '
        Me.LabelSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelSpeed.Location = New System.Drawing.Point(20, 251)
        Me.LabelSpeed.Name = "LabelSpeed"
        Me.LabelSpeed.Size = New System.Drawing.Size(217, 16)
        Me.LabelSpeed.TabIndex = 33
        Me.LabelSpeed.Text = "Speed:"
        '
        'btnHelpAdBlock
        '
        Me.btnHelpAdBlock.Location = New System.Drawing.Point(421, 276)
        Me.btnHelpAdBlock.Name = "btnHelpAdBlock"
        Me.btnHelpAdBlock.Size = New System.Drawing.Size(131, 23)
        Me.btnHelpAdBlock.TabIndex = 31
        Me.btnHelpAdBlock.Text = "What is this?"
        Me.btnHelpAdBlock.UseVisualStyleBackColor = True
        '
        'btnRemoveAdBlock
        '
        Me.btnRemoveAdBlock.Enabled = False
        Me.btnRemoveAdBlock.Location = New System.Drawing.Point(421, 247)
        Me.btnRemoveAdBlock.Name = "btnRemoveAdBlock"
        Me.btnRemoveAdBlock.Size = New System.Drawing.Size(131, 23)
        Me.btnRemoveAdBlock.TabIndex = 30
        Me.btnRemoveAdBlock.Text = "Restore Default HOSTS"
        Me.btnRemoveAdBlock.UseVisualStyleBackColor = True
        '
        'btnDLApply
        '
        Me.btnDLApply.Location = New System.Drawing.Point(284, 247)
        Me.btnDLApply.Name = "btnDLApply"
        Me.btnDLApply.Size = New System.Drawing.Size(131, 23)
        Me.btnDLApply.TabIndex = 29
        Me.btnDLApply.Text = "Download"
        Me.btnDLApply.UseCompatibleTextRendering = True
        Me.btnDLApply.UseVisualStyleBackColor = True
        '
        'DownloadProgress1
        '
        Me.DownloadProgress1.Location = New System.Drawing.Point(20, 210)
        Me.DownloadProgress1.Name = "DownloadProgress1"
        Me.DownloadProgress1.Size = New System.Drawing.Size(532, 23)
        Me.DownloadProgress1.TabIndex = 28
        '
        'tabGCleaner
        '
        Me.tabGCleaner.Controls.Add(Me.Panel2)
        Me.tabGCleaner.Location = New System.Drawing.Point(4, 24)
        Me.tabGCleaner.Name = "tabGCleaner"
        Me.tabGCleaner.Size = New System.Drawing.Size(595, 312)
        Me.tabGCleaner.TabIndex = 3
        Me.tabGCleaner.Text = "GCleaner"
        Me.tabGCleaner.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.tcLocations)
        Me.Panel2.Controls.Add(Me.lblResults)
        Me.Panel2.Controls.Add(Me.lvwTemps)
        Me.Panel2.Controls.Add(Me.btnClean)
        Me.Panel2.Controls.Add(Me.btnScan)
        Me.Panel2.Controls.Add(Me.progressScanning)
        Me.Panel2.Location = New System.Drawing.Point(15, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(563, 306)
        Me.Panel2.TabIndex = 3
        '
        'tcLocations
        '
        Me.tcLocations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tcLocations.Controls.Add(Me.pgBrowsers)
        Me.tcLocations.Controls.Add(Me.pgUserSystem)
        Me.tcLocations.Location = New System.Drawing.Point(4, 5)
        Me.tcLocations.Name = "tcLocations"
        Me.tcLocations.SelectedIndex = 0
        Me.tcLocations.Size = New System.Drawing.Size(185, 297)
        Me.tcLocations.TabIndex = 6
        '
        'pgBrowsers
        '
        Me.pgBrowsers.Controls.Add(Me.tvwBrowsers)
        Me.pgBrowsers.Location = New System.Drawing.Point(4, 24)
        Me.pgBrowsers.Name = "pgBrowsers"
        Me.pgBrowsers.Padding = New System.Windows.Forms.Padding(3)
        Me.pgBrowsers.Size = New System.Drawing.Size(177, 269)
        Me.pgBrowsers.TabIndex = 0
        Me.pgBrowsers.Text = "Browsers"
        Me.pgBrowsers.UseVisualStyleBackColor = True
        '
        'tvwBrowsers
        '
        Me.tvwBrowsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwBrowsers.CheckBoxes = True
        Me.tvwBrowsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwBrowsers.ImageIndex = 0
        Me.tvwBrowsers.ImageList = Me.imgIcons
        Me.tvwBrowsers.Location = New System.Drawing.Point(3, 3)
        Me.tvwBrowsers.Name = "tvwBrowsers"
        TreeNode1.Checked = True
        TreeNode1.ImageIndex = -2
        TreeNode1.Name = "Node0"
        TreeNode1.SelectedImageIndex = -2
        TreeNode1.Text = "Cookies"
        TreeNode2.Checked = True
        TreeNode2.ImageIndex = -2
        TreeNode2.Name = "Node1"
        TreeNode2.SelectedImageIndex = -2
        TreeNode2.Text = "Temporary Internet Files"
        TreeNode3.Checked = True
        TreeNode3.ImageIndex = -2
        TreeNode3.Name = "Node2"
        TreeNode3.SelectedImageIndex = -2
        TreeNode3.Text = "History"
        TreeNode4.Checked = True
        TreeNode4.ImageIndex = -2
        TreeNode4.Name = "Node3"
        TreeNode4.SelectedImageIndex = -2
        TreeNode4.Text = "Recently Typed URLs"
        TreeNode5.Checked = True
        TreeNode5.ImageIndex = -2
        TreeNode5.Name = "Node4"
        TreeNode5.SelectedImageIndex = -2
        TreeNode5.Text = "Index"
        TreeNode6.Checked = True
        TreeNode6.ImageIndex = 3
        TreeNode6.Name = "Node0"
        TreeNode6.SelectedImageIndex = 3
        TreeNode6.Text = "Internet Explorer"
        TreeNode7.Checked = True
        TreeNode7.Name = "Node0"
        TreeNode7.SelectedImageIndex = 0
        TreeNode7.Text = "Cookies"
        TreeNode8.Checked = True
        TreeNode8.Name = "Node1"
        TreeNode8.SelectedImageIndex = 0
        TreeNode8.Text = "Cache"
        TreeNode9.Checked = True
        TreeNode9.Name = "Node2"
        TreeNode9.SelectedImageIndex = 0
        TreeNode9.Text = "Internet History"
        TreeNode10.Checked = True
        TreeNode10.ImageIndex = 1
        TreeNode10.Name = "Node1"
        TreeNode10.SelectedImageIndex = 1
        TreeNode10.Text = "Google Chrome"
        TreeNode11.Checked = True
        TreeNode11.ImageIndex = 0
        TreeNode11.Name = "Node0"
        TreeNode11.SelectedImageIndex = 0
        TreeNode11.Text = "Cookies"
        TreeNode12.Checked = True
        TreeNode12.ImageIndex = 0
        TreeNode12.Name = "Node7"
        TreeNode12.SelectedImageIndex = 0
        TreeNode12.Text = "Download History"
        TreeNode13.Checked = True
        TreeNode13.ImageIndex = 0
        TreeNode13.Name = "Node8"
        TreeNode13.SelectedImageIndex = 0
        TreeNode13.Text = "Form History"
        TreeNode14.Checked = True
        TreeNode14.ImageIndex = 0
        TreeNode14.Name = "Node9"
        TreeNode14.SelectedImageIndex = 0
        TreeNode14.Text = "Cache"
        TreeNode15.Checked = True
        TreeNode15.ImageIndex = 0
        TreeNode15.Name = "Node10"
        TreeNode15.SelectedImageIndex = 0
        TreeNode15.Text = "Session Store"
        TreeNode16.Checked = True
        TreeNode16.ImageIndex = 2
        TreeNode16.Name = "Node2"
        TreeNode16.SelectedImageIndex = 2
        TreeNode16.Text = "Mozilla Firefox"
        TreeNode17.Checked = True
        TreeNode17.Name = "Node11"
        TreeNode17.SelectedImageIndex = 0
        TreeNode17.Text = "Cache"
        TreeNode18.Checked = True
        TreeNode18.ImageIndex = 0
        TreeNode18.Name = "Node14"
        TreeNode18.SelectedImageIndex = 0
        TreeNode18.Text = "History"
        TreeNode19.Checked = True
        TreeNode19.ImageIndex = 0
        TreeNode19.Name = "Node17"
        TreeNode19.SelectedImageIndex = 0
        TreeNode19.Text = "Webpage Previews"
        TreeNode20.Checked = True
        TreeNode20.ImageIndex = 0
        TreeNode20.Name = "Node5"
        TreeNode20.SelectedImageIndex = 0
        TreeNode20.Text = "Download History"
        TreeNode21.Checked = True
        TreeNode21.ImageIndex = 0
        TreeNode21.Name = "Node7"
        TreeNode21.SelectedImageIndex = 0
        TreeNode21.Text = "Last Session"
        TreeNode22.Checked = True
        TreeNode22.ImageIndex = 4
        TreeNode22.Name = "Node3"
        TreeNode22.SelectedImageIndex = 4
        TreeNode22.Text = "Safari"
        TreeNode23.ImageIndex = 0
        TreeNode23.Name = "Node1"
        TreeNode23.SelectedImageIndex = 0
        TreeNode23.Text = "Cache"
        TreeNode24.Checked = True
        TreeNode24.ImageIndex = 0
        TreeNode24.Name = "Node2"
        TreeNode24.SelectedImageKey = "blank_16x16.png"
        TreeNode24.Text = "History"
        TreeNode25.Checked = True
        TreeNode25.ImageIndex = 0
        TreeNode25.Name = "Node3"
        TreeNode25.SelectedImageIndex = 0
        TreeNode25.Text = "Cookies"
        TreeNode26.Checked = True
        TreeNode26.ImageIndex = 0
        TreeNode26.Name = "Node4"
        TreeNode26.SelectedImageIndex = 0
        TreeNode26.Text = "Website Icons"
        TreeNode27.Checked = True
        TreeNode27.ImageIndex = 0
        TreeNode27.Name = "Node8"
        TreeNode27.SelectedImageIndex = 0
        TreeNode27.Text = "Download History"
        TreeNode28.Checked = True
        TreeNode28.ImageIndex = 5
        TreeNode28.Name = "Node0"
        TreeNode28.SelectedImageIndex = 5
        TreeNode28.Text = "Opera"
        Me.tvwBrowsers.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode10, TreeNode16, TreeNode22, TreeNode28})
        Me.tvwBrowsers.SelectedImageIndex = 3
        Me.tvwBrowsers.ShowLines = False
        Me.tvwBrowsers.ShowPlusMinus = False
        Me.tvwBrowsers.ShowRootLines = False
        Me.tvwBrowsers.Size = New System.Drawing.Size(171, 263)
        Me.tvwBrowsers.TabIndex = 0
        '
        'pgUserSystem
        '
        Me.pgUserSystem.Controls.Add(Me.tvwUserSystem)
        Me.pgUserSystem.Location = New System.Drawing.Point(4, 24)
        Me.pgUserSystem.Name = "pgUserSystem"
        Me.pgUserSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.pgUserSystem.Size = New System.Drawing.Size(177, 269)
        Me.pgUserSystem.TabIndex = 1
        Me.pgUserSystem.Text = "User/System"
        Me.pgUserSystem.UseVisualStyleBackColor = True
        '
        'tvwUserSystem
        '
        Me.tvwUserSystem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvwUserSystem.CheckBoxes = True
        Me.tvwUserSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvwUserSystem.ImageIndex = 0
        Me.tvwUserSystem.ImageList = Me.imgIcons
        Me.tvwUserSystem.Location = New System.Drawing.Point(3, 3)
        Me.tvwUserSystem.Name = "tvwUserSystem"
        TreeNode29.Checked = True
        TreeNode29.ImageIndex = 0
        TreeNode29.Name = "Node1"
        TreeNode29.SelectedImageIndex = 0
        TreeNode29.Text = "Recent Documents"
        TreeNode30.Checked = True
        TreeNode30.ImageIndex = 0
        TreeNode30.Name = "Node3"
        TreeNode30.SelectedImageIndex = 0
        TreeNode30.Text = "Thumbnail Cache"
        TreeNode31.Checked = True
        TreeNode31.ImageIndex = 6
        TreeNode31.Name = "Node0"
        TreeNode31.SelectedImageIndex = 6
        TreeNode31.Text = "Windows Explorer"
        TreeNode32.Checked = True
        TreeNode32.ImageKey = "blank_16x16.png"
        TreeNode32.Name = "Node1"
        TreeNode32.SelectedImageIndex = 0
        TreeNode32.Text = "Windows Temp Files"
        TreeNode33.Checked = True
        TreeNode33.ImageIndex = 0
        TreeNode33.Name = "Node3"
        TreeNode33.SelectedImageIndex = 0
        TreeNode33.Text = "User Temp Files"
        TreeNode34.Checked = True
        TreeNode34.ImageIndex = 0
        TreeNode34.Name = "Node4"
        TreeNode34.SelectedImageIndex = 0
        TreeNode34.Text = "Memory Dumps"
        TreeNode35.Checked = True
        TreeNode35.ImageIndex = 0
        TreeNode35.Name = "Node5"
        TreeNode35.SelectedImageIndex = 0
        TreeNode35.Text = "ChkDsk File Fragments"
        TreeNode36.Checked = True
        TreeNode36.ImageIndex = 0
        TreeNode36.Name = "Node6"
        TreeNode36.SelectedImageIndex = 0
        TreeNode36.Text = "Windows Log Files"
        TreeNode37.Checked = True
        TreeNode37.ImageIndex = 0
        TreeNode37.Name = "Node8"
        TreeNode37.SelectedImageIndex = 0
        TreeNode37.Text = "Windows Error Reporting"
        TreeNode38.Checked = True
        TreeNode38.ImageKey = "system_16x16.png"
        TreeNode38.Name = "Node0"
        TreeNode38.SelectedImageIndex = 7
        TreeNode38.Text = "System"
        TreeNode39.Checked = True
        TreeNode39.ImageIndex = -2
        TreeNode39.Name = "Node1"
        TreeNode39.SelectedImageIndex = -2
        TreeNode39.Text = "Prefetch Data"
        TreeNode40.Checked = True
        TreeNode40.ImageIndex = -2
        TreeNode40.Name = "Node2"
        TreeNode40.SelectedImageIndex = -2
        TreeNode40.Text = "IIS Logs"
        TreeNode41.Checked = True
        TreeNode41.ImageIndex = 8
        TreeNode41.Name = "Node0"
        TreeNode41.SelectedImageIndex = 8
        TreeNode41.Text = "Advanced"
        Me.tvwUserSystem.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode38, TreeNode41})
        Me.tvwUserSystem.SelectedImageIndex = 3
        Me.tvwUserSystem.ShowLines = False
        Me.tvwUserSystem.ShowPlusMinus = False
        Me.tvwUserSystem.ShowRootLines = False
        Me.tvwUserSystem.Size = New System.Drawing.Size(171, 263)
        Me.tvwUserSystem.TabIndex = 1
        '
        'lblResults
        '
        Me.lblResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResults.Location = New System.Drawing.Point(356, 277)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(198, 25)
        Me.lblResults.TabIndex = 5
        '
        'lvwTemps
        '
        Me.lvwTemps.AllowColumnReorder = True
        Me.lvwTemps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwTemps.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDirectory, Me.files, Me.size})
        Me.lvwTemps.FullRowSelect = True
        Me.lvwTemps.GridLines = True
        Me.lvwTemps.Location = New System.Drawing.Point(195, 26)
        Me.lvwTemps.MultiSelect = False
        Me.lvwTemps.Name = "lvwTemps"
        Me.lvwTemps.ShowItemToolTips = True
        Me.lvwTemps.Size = New System.Drawing.Size(359, 248)
        Me.lvwTemps.TabIndex = 4
        Me.lvwTemps.UseCompatibleStateImageBehavior = False
        Me.lvwTemps.View = System.Windows.Forms.View.Details
        '
        'colDirectory
        '
        Me.colDirectory.Text = "Directory"
        Me.colDirectory.Width = 232
        '
        'files
        '
        Me.files.Text = "Files"
        '
        'size
        '
        Me.size.Text = "Size"
        Me.size.Width = 51
        '
        'btnClean
        '
        Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClean.Location = New System.Drawing.Point(275, 279)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(75, 23)
        Me.btnClean.TabIndex = 3
        Me.btnClean.Text = "&Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnScan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScan.Location = New System.Drawing.Point(194, 279)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(75, 23)
        Me.btnScan.TabIndex = 2
        Me.btnScan.Text = "&Scan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'progressScanning
        '
        Me.progressScanning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressScanning.Location = New System.Drawing.Point(194, 5)
        Me.progressScanning.MarqueeAnimationSpeed = 5
        Me.progressScanning.Maximum = 1
        Me.progressScanning.Name = "progressScanning"
        Me.progressScanning.Size = New System.Drawing.Size(362, 15)
        Me.progressScanning.Step = 1
        Me.progressScanning.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 434)
        Me.Controls.Add(Me.tabctrl_1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnMinTray)
        Me.Controls.Add(Me.btnGCLen)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnProcExplr)
        Me.Controls.Add(Me.btnMemCleaner)
        Me.Controls.Add(Me.btnRegTools)
        Me.Controls.Add(Me.btnAdEvader)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "GPM Antivirus Tools"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tSysInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfcCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabctrl_1.ResumeLayout(False)
        Me.tabMemClnr.ResumeLayout(False)
        Me.tabMemClnr.PerformLayout()
        Me.bxPhysicalMem.ResumeLayout(False)
        Me.bxPhysicalMem.PerformLayout()
        Me.bxKernelMemory.ResumeLayout(False)
        Me.bxKernelMemory.PerformLayout()
        Me.bxCommitCharge.ResumeLayout(False)
        Me.bxCommitCharge.PerformLayout()
        Me.bxTotals.ResumeLayout(False)
        Me.bxTotals.PerformLayout()
        CType(Me.numUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRegTool.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.tabAdEvader.ResumeLayout(False)
        Me.gbAdEvader.ResumeLayout(False)
        Me.gbAdEvader.PerformLayout()
        Me.tabGCleaner.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.tcLocations.ResumeLayout(False)
        Me.pgBrowsers.ResumeLayout(False)
        Me.pgUserSystem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnAdEvader As System.Windows.Forms.Button
    Friend WithEvents btnRegTools As System.Windows.Forms.Button
    Friend WithEvents btnMemCleaner As System.Windows.Forms.Button
    Friend WithEvents btnProcExplr As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnGCLen As System.Windows.Forms.Button
    Friend WithEvents btnMinTray As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents TimerSpeed As System.Windows.Forms.Timer
    Friend WithEvents TimerDownloadSpeed As System.Windows.Forms.Timer
    Friend WithEvents bgWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tSysInfo As System.Timers.Timer
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents tmrClear As System.Windows.Forms.Timer
    Friend WithEvents bgWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents pfcCPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents tmrCPU As System.Windows.Forms.Timer
    Friend WithEvents imgIcons As System.Windows.Forms.ImageList
    Friend WithEvents tabctrl_1 As System.Windows.Forms.TabControl
    Friend WithEvents tabMemClnr As System.Windows.Forms.TabPage
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents bxPhysicalMem As System.Windows.Forms.GroupBox
    Friend WithEvents lblPhysCacheFaults As System.Windows.Forms.Label
    Friend WithEvents lblPhysMemPeak As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPhysMemCache As System.Windows.Forms.Label
    Friend WithEvents lblPhysMemAvailable As System.Windows.Forms.Label
    Friend WithEvents lblPhysMemTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNoProc As System.Windows.Forms.Label
    Friend WithEvents prgClear As System.Windows.Forms.ProgressBar
    Friend WithEvents bxKernelMemory As System.Windows.Forms.GroupBox
    Friend WithEvents lblKerMemNonpaged As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblKerMemVirtual As System.Windows.Forms.Label
    Friend WithEvents lblKerMemPhys As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents bxCommitCharge As System.Windows.Forms.GroupBox
    Friend WithEvents lblCommitPeak As System.Windows.Forms.Label
    Friend WithEvents lblCommitLimit As System.Windows.Forms.Label
    Friend WithEvents lblCommitCurrent As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents bxTotals As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotIOOther As System.Windows.Forms.Label
    Friend WithEvents lblTotIOWrite As System.Windows.Forms.Label
    Friend WithEvents lblTotIORead As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblTotalProcesses As System.Windows.Forms.Label
    Friend WithEvents lblTotalsThreads As System.Windows.Forms.Label
    Friend WithEvents lblTotalHandles As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblAvailVirMemPercent As System.Windows.Forms.Label
    Friend WithEvents lblPercentAvailPhys As System.Windows.Forms.Label
    Friend WithEvents prgmemoryVir As System.Windows.Forms.ProgressBar
    Friend WithEvents prgmemory As System.Windows.Forms.ProgressBar
    Friend WithEvents lblAvailVirMem As System.Windows.Forms.Label
    Friend WithEvents lblAvailPhysMem As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents numUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTotVir As System.Windows.Forms.Label
    Friend WithEvents lblTotPhys As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnAutFreof As System.Windows.Forms.Button
    Friend WithEvents lstProc As System.Windows.Forms.ListBox
    Friend WithEvents btnAutFre As System.Windows.Forms.Button
    Friend WithEvents btnFreeMem As System.Windows.Forms.Button
    Friend WithEvents prgTime As System.Windows.Forms.ProgressBar
    Friend WithEvents tabRegTool As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstRegAVList As System.Windows.Forms.ListBox
    Friend WithEvents btnFixReg As System.Windows.Forms.Button
    Friend WithEvents btnScanReg As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnSaveSel As System.Windows.Forms.Button
    Friend WithEvents btnSelDefREG As System.Windows.Forms.Button
    Friend WithEvents btnSelNonREG As System.Windows.Forms.Button
    Friend WithEvents btnSelAllREG As System.Windows.Forms.Button
    Friend WithEvents chkTrayCNTX As System.Windows.Forms.CheckBox
    Friend WithEvents chkSetTaskbar As System.Windows.Forms.CheckBox
    Friend WithEvents chkWinLogoff As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisCPL As System.Windows.Forms.CheckBox
    Friend WithEvents chkWinLock As System.Windows.Forms.CheckBox
    Friend WithEvents chkWinClose As System.Windows.Forms.CheckBox
    Friend WithEvents chkChWP As System.Windows.Forms.CheckBox
    Friend WithEvents chkChangePW As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecentDoc As System.Windows.Forms.CheckBox
    Friend WithEvents htmlwallpaper As System.Windows.Forms.CheckBox
    Friend WithEvents wallpaper As System.Windows.Forms.CheckBox
    Friend WithEvents taskbarcontext As System.Windows.Forms.CheckBox
    Friend WithEvents savesettings As System.Windows.Forms.CheckBox
    Friend WithEvents addremove As System.Windows.Forms.CheckBox
    Friend WithEvents winupdate As System.Windows.Forms.CheckBox
    Friend WithEvents filemenu As System.Windows.Forms.CheckBox
    Friend WithEvents logoff As System.Windows.Forms.CheckBox
    Friend WithEvents run As System.Windows.Forms.CheckBox
    Friend WithEvents taskbar As System.Windows.Forms.CheckBox
    Friend WithEvents desktop As System.Windows.Forms.CheckBox
    Friend WithEvents cpl As System.Windows.Forms.CheckBox
    Friend WithEvents cmd As System.Windows.Forms.CheckBox
    Friend WithEvents fldopt As System.Windows.Forms.CheckBox
    Friend WithEvents regedit As System.Windows.Forms.CheckBox
    Friend WithEvents tskmgr As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lblStartupNo As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents checkedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents tabAdEvader As System.Windows.Forms.TabPage
    Friend WithEvents gbAdEvader As System.Windows.Forms.GroupBox
    Friend WithEvents RTF2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RTF1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnApplyHosts As System.Windows.Forms.Button
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents LabelProgress As System.Windows.Forms.Label
    Friend WithEvents LabelSpeed As System.Windows.Forms.Label
    Friend WithEvents btnHelpAdBlock As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAdBlock As System.Windows.Forms.Button
    Friend WithEvents btnDLApply As System.Windows.Forms.Button
    Friend WithEvents DownloadProgress1 As System.Windows.Forms.ProgressBar
    Friend WithEvents tabGCleaner As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tcLocations As System.Windows.Forms.TabControl
    Friend WithEvents pgBrowsers As System.Windows.Forms.TabPage
    Friend WithEvents tvwBrowsers As System.Windows.Forms.TreeView
    Friend WithEvents pgUserSystem As System.Windows.Forms.TabPage
    Friend WithEvents tvwUserSystem As System.Windows.Forms.TreeView
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents lvwTemps As System.Windows.Forms.ListView
    Friend WithEvents colDirectory As System.Windows.Forms.ColumnHeader
    Friend WithEvents files As System.Windows.Forms.ColumnHeader
    Friend WithEvents size As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents btnScan As System.Windows.Forms.Button
    Friend WithEvents progressScanning As System.Windows.Forms.ProgressBar

End Class
