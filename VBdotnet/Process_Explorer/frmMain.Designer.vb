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
        Me.menuContextProcess = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiKill = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSuspend = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.LocateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSetPriority2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPriorityRT2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPriorityH2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPriorityAN2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPriorityN2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPriorityBN2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPriorityI2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MinimizeToTrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imagesProcessIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.toolProcess = New System.Windows.Forms.ToolStrip()
        Me.tsbKill = New System.Windows.Forms.ToolStripButton()
        Me.tsbSuspend = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLocate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslCPUusage = New System.Windows.Forms.ToolStripLabel()
        Me.tslProcCount = New System.Windows.Forms.ToolStripLabel()
        Me.tslProcesses = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbCPU = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCPUProg = New System.Windows.Forms.ToolStripProgressBar()
        Me.bgProcessList = New System.ComponentModel.BackgroundWorker()
        Me.tProcs = New System.Timers.Timer()
        Me.lvwProcess = New System.Windows.Forms.ListView()
        Me.colProc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPriority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colImagePath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCmdLine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colVendorName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFileDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pfcCPU = New System.Diagnostics.PerformanceCounter()
        Me.tmrCPU = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CMSTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuContextProcess.SuspendLayout()
        Me.toolProcess.SuspendLayout()
        CType(Me.tProcs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfcCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuContextProcess
        '
        Me.menuContextProcess.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiKill, Me.tsmiSuspend, Me.ToolStripSeparator6, Me.LocateToolStripMenuItem, Me.tsmiSetPriority2, Me.ToolStripSeparator7, Me.tsmiRefresh, Me.ToolStripSeparator3, Me.MinimizeToTrayToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.menuContextProcess.Name = "menuContextProcess"
        Me.menuContextProcess.Size = New System.Drawing.Size(184, 198)
        '
        'tsmiKill
        '
        Me.tsmiKill.Name = "tsmiKill"
        Me.tsmiKill.Size = New System.Drawing.Size(183, 22)
        Me.tsmiKill.Text = "&Kill"
        '
        'tsmiSuspend
        '
        Me.tsmiSuspend.Name = "tsmiSuspend"
        Me.tsmiSuspend.Size = New System.Drawing.Size(183, 22)
        Me.tsmiSuspend.Text = "&Suspend"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'LocateToolStripMenuItem
        '
        Me.LocateToolStripMenuItem.Name = "LocateToolStripMenuItem"
        Me.LocateToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LocateToolStripMenuItem.Text = "&Locate"
        '
        'tsmiSetPriority2
        '
        Me.tsmiSetPriority2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPriorityRT2, Me.tsmiPriorityH2, Me.tsmiPriorityAN2, Me.tsmiPriorityN2, Me.tsmiPriorityBN2, Me.tsmiPriorityI2})
        Me.tsmiSetPriority2.Name = "tsmiSetPriority2"
        Me.tsmiSetPriority2.Size = New System.Drawing.Size(183, 22)
        Me.tsmiSetPriority2.Text = "Set &Priority"
        '
        'tsmiPriorityRT2
        '
        Me.tsmiPriorityRT2.Name = "tsmiPriorityRT2"
        Me.tsmiPriorityRT2.Size = New System.Drawing.Size(196, 22)
        Me.tsmiPriorityRT2.Text = "Realtime: 24"
        '
        'tsmiPriorityH2
        '
        Me.tsmiPriorityH2.Name = "tsmiPriorityH2"
        Me.tsmiPriorityH2.Size = New System.Drawing.Size(196, 22)
        Me.tsmiPriorityH2.Text = "High: 13"
        '
        'tsmiPriorityAN2
        '
        Me.tsmiPriorityAN2.Name = "tsmiPriorityAN2"
        Me.tsmiPriorityAN2.Size = New System.Drawing.Size(196, 22)
        Me.tsmiPriorityAN2.Text = "Above Normal: 10"
        '
        'tsmiPriorityN2
        '
        Me.tsmiPriorityN2.Name = "tsmiPriorityN2"
        Me.tsmiPriorityN2.Size = New System.Drawing.Size(196, 22)
        Me.tsmiPriorityN2.Text = "Normal: 8"
        '
        'tsmiPriorityBN2
        '
        Me.tsmiPriorityBN2.Name = "tsmiPriorityBN2"
        Me.tsmiPriorityBN2.Size = New System.Drawing.Size(196, 22)
        Me.tsmiPriorityBN2.Text = "Below Normal: 6"
        '
        'tsmiPriorityI2
        '
        Me.tsmiPriorityI2.Name = "tsmiPriorityI2"
        Me.tsmiPriorityI2.Size = New System.Drawing.Size(196, 22)
        Me.tsmiPriorityI2.Text = "Idle: 4"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(180, 6)
        '
        'tsmiRefresh
        '
        Me.tsmiRefresh.Name = "tsmiRefresh"
        Me.tsmiRefresh.Size = New System.Drawing.Size(183, 22)
        Me.tsmiRefresh.Text = "&Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'MinimizeToTrayToolStripMenuItem
        '
        Me.MinimizeToTrayToolStripMenuItem.Name = "MinimizeToTrayToolStripMenuItem"
        Me.MinimizeToTrayToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MinimizeToTrayToolStripMenuItem.Text = "Minimize to &Tray"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'imagesProcessIcons
        '
        Me.imagesProcessIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imagesProcessIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.imagesProcessIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'toolProcess
        '
        Me.toolProcess.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbKill, Me.tsbSuspend, Me.ToolStripSeparator5, Me.tsbLocate, Me.ToolStripSeparator2, Me.tslCPUusage, Me.tslProcCount, Me.tslProcesses, Me.ToolStripLabel1, Me.tsbCPU, Me.ToolStripSeparator1, Me.tsbCPUProg})
        Me.toolProcess.Location = New System.Drawing.Point(0, 0)
        Me.toolProcess.Name = "toolProcess"
        Me.toolProcess.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.toolProcess.Size = New System.Drawing.Size(556, 25)
        Me.toolProcess.TabIndex = 3
        '
        'tsbKill
        '
        Me.tsbKill.Enabled = False
        Me.tsbKill.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbKill.Name = "tsbKill"
        Me.tsbKill.Size = New System.Drawing.Size(31, 22)
        Me.tsbKill.Text = "Kill"
        '
        'tsbSuspend
        '
        Me.tsbSuspend.Enabled = False
        Me.tsbSuspend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSuspend.Name = "tsbSuspend"
        Me.tsbSuspend.Size = New System.Drawing.Size(69, 22)
        Me.tsbSuspend.Text = "Suspend"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbLocate
        '
        Me.tsbLocate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLocate.Enabled = False
        Me.tsbLocate.Image = CType(resources.GetObject("tsbLocate.Image"), System.Drawing.Image)
        Me.tsbLocate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbLocate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLocate.Name = "tsbLocate"
        Me.tsbLocate.Size = New System.Drawing.Size(57, 22)
        Me.tsbLocate.Text = "Locate"
        Me.tsbLocate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tslCPUusage
        '
        Me.tslCPUusage.Name = "tslCPUusage"
        Me.tslCPUusage.Size = New System.Drawing.Size(0, 22)
        '
        'tslProcCount
        '
        Me.tslProcCount.ActiveLinkColor = System.Drawing.Color.Black
        Me.tslProcCount.LinkColor = System.Drawing.Color.Black
        Me.tslProcCount.Name = "tslProcCount"
        Me.tslProcCount.Size = New System.Drawing.Size(82, 22)
        Me.tslProcCount.Text = "Processes:"
        Me.tslProcCount.VisitedLinkColor = System.Drawing.Color.Black
        '
        'tslProcesses
        '
        Me.tslProcesses.ActiveLinkColor = System.Drawing.Color.Black
        Me.tslProcesses.LinkColor = System.Drawing.Color.Black
        Me.tslProcesses.Name = "tslProcesses"
        Me.tslProcesses.Size = New System.Drawing.Size(18, 22)
        Me.tslProcesses.Text = "#"
        Me.tslProcesses.VisitedLinkColor = System.Drawing.Color.Black
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(40, 22)
        Me.ToolStripLabel1.Text = "CPU:"
        '
        'tsbCPU
        '
        Me.tsbCPU.Name = "tsbCPU"
        Me.tsbCPU.Size = New System.Drawing.Size(48, 22)
        Me.tsbCPU.Text = "####"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbCPUProg
        '
        Me.tsbCPUProg.Name = "tsbCPUProg"
        Me.tsbCPUProg.Size = New System.Drawing.Size(100, 22)
        '
        'tProcs
        '
        Me.tProcs.Enabled = True
        Me.tProcs.Interval = 1000.0R
        Me.tProcs.SynchronizingObject = Me
        '
        'lvwProcess
        '
        Me.lvwProcess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvwProcess.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProc, Me.colPID, Me.colPriority, Me.colMem, Me.colImagePath, Me.colCmdLine, Me.colVendorName, Me.colFileDescription})
        Me.lvwProcess.ContextMenuStrip = Me.menuContextProcess
        Me.lvwProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwProcess.FullRowSelect = True
        Me.lvwProcess.Location = New System.Drawing.Point(0, 25)
        Me.lvwProcess.MultiSelect = False
        Me.lvwProcess.Name = "lvwProcess"
        Me.lvwProcess.Size = New System.Drawing.Size(556, 263)
        Me.lvwProcess.SmallImageList = Me.imagesProcessIcons
        Me.lvwProcess.TabIndex = 4
        Me.lvwProcess.UseCompatibleStateImageBehavior = False
        Me.lvwProcess.View = System.Windows.Forms.View.Details
        '
        'colProc
        '
        Me.colProc.Text = "Name"
        Me.colProc.Width = 193
        '
        'colPID
        '
        Me.colPID.Text = "PID"
        Me.colPID.Width = 42
        '
        'colPriority
        '
        Me.colPriority.Text = "Priority"
        Me.colPriority.Width = 47
        '
        'colMem
        '
        Me.colMem.Text = "Memory"
        Me.colMem.Width = 61
        '
        'colImagePath
        '
        Me.colImagePath.Text = "Path"
        Me.colImagePath.Width = 447
        '
        'colCmdLine
        '
        Me.colCmdLine.Text = "Command Line"
        Me.colCmdLine.Width = 600
        '
        'colVendorName
        '
        Me.colVendorName.Text = "Company Name"
        Me.colVendorName.Width = 115
        '
        'colFileDescription
        '
        Me.colFileDescription.Text = "File Description"
        Me.colFileDescription.Width = 194
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        '
        'SysTrayIcon
        '
        Me.SysTrayIcon.ContextMenuStrip = Me.CMSTray
        Me.SysTrayIcon.Icon = CType(resources.GetObject("SysTrayIcon.Icon"), System.Drawing.Icon)
        Me.SysTrayIcon.Text = "Process Explorer"
        Me.SysTrayIcon.Visible = True
        '
        'CMSTray
        '
        Me.CMSTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ToolStripSeparator4, Me.AboutToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.CMSTray.Name = "CMSTray"
        Me.CMSTray.Size = New System.Drawing.Size(116, 76)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ShowToolStripMenuItem.Text = "&Show"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(112, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem1.Text = "&Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 288)
        Me.Controls.Add(Me.lvwProcess)
        Me.Controls.Add(Me.toolProcess)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Process Explorer"
        Me.menuContextProcess.ResumeLayout(False)
        Me.toolProcess.ResumeLayout(False)
        Me.toolProcess.PerformLayout()
        CType(Me.tProcs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfcCPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menuContextProcess As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSuspend As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imagesProcessIcons As System.Windows.Forms.ImageList
    Friend WithEvents toolProcess As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbKill As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSuspend As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslProcCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tslProcesses As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tslCPUusage As System.Windows.Forms.ToolStripLabel
    Friend WithEvents bgProcessList As System.ComponentModel.BackgroundWorker
    Friend WithEvents tProcs As System.Timers.Timer
    Friend WithEvents lvwProcess As System.Windows.Forms.ListView
    Friend WithEvents colProc As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMem As System.Windows.Forms.ColumnHeader
    Friend WithEvents colVendorName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFileDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents colImagePath As System.Windows.Forms.ColumnHeader
    Friend WithEvents LocateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colCmdLine As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents colPriority As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbCPU As System.Windows.Forms.ToolStripLabel
    Friend WithEvents pfcCPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents tsbCPUProg As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tmrCPU As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLocate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmiSetPriority2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPriorityRT2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPriorityH2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPriorityAN2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPriorityN2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPriorityBN2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPriorityI2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MinimizeToTrayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SysTrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents CMSTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator

End Class
