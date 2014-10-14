<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTray
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTray))
        Me.sysstrp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenGPMAntivirusGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenGPMAntivirusScannerGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GPMAntivirusRealTimeProtectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RTPON = New System.Windows.Forms.ToolStripMenuItem()
        Me.RTPOFF = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateGPMAntivirusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateGUIVisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateGUIInvisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoUpdateGPMAntivirusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateBTC = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonatePPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitGIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitNB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.systray1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ShowReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sysstrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'sysstrp
        '
        Me.sysstrp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenGPMAntivirusGUIToolStripMenuItem, Me.OpenGPMAntivirusScannerGUIToolStripMenuItem, Me.ToolStripSeparator1, Me.GPMAntivirusRealTimeProtectionToolStripMenuItem, Me.ToolStripSeparator2, Me.UpdateGPMAntivirusToolStripMenuItem, Me.AutoUpdateGPMAntivirusToolStripMenuItem, Me.ToolStripSeparator4, Me.ShowReportsToolStripMenuItem, Me.ToolStripSeparator5, Me.DonateToolStripMenuItem, Me.VisitWebsiteToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator10, Me.ExitToolStripMenuItem})
        Me.sysstrp.Name = "sysstrp"
        Me.sysstrp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.sysstrp.ShowImageMargin = False
        Me.sysstrp.Size = New System.Drawing.Size(286, 298)
        '
        'OpenGPMAntivirusGUIToolStripMenuItem
        '
        Me.OpenGPMAntivirusGUIToolStripMenuItem.Name = "OpenGPMAntivirusGUIToolStripMenuItem"
        Me.OpenGPMAntivirusGUIToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.OpenGPMAntivirusGUIToolStripMenuItem.Text = "Open GPM Antivirus GUI"
        '
        'OpenGPMAntivirusScannerGUIToolStripMenuItem
        '
        Me.OpenGPMAntivirusScannerGUIToolStripMenuItem.Name = "OpenGPMAntivirusScannerGUIToolStripMenuItem"
        Me.OpenGPMAntivirusScannerGUIToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.OpenGPMAntivirusScannerGUIToolStripMenuItem.Text = "Open GPM Antivirus Scanner"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(282, 6)
        '
        'GPMAntivirusRealTimeProtectionToolStripMenuItem
        '
        Me.GPMAntivirusRealTimeProtectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RTPON, Me.RTPOFF})
        Me.GPMAntivirusRealTimeProtectionToolStripMenuItem.Name = "GPMAntivirusRealTimeProtectionToolStripMenuItem"
        Me.GPMAntivirusRealTimeProtectionToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.GPMAntivirusRealTimeProtectionToolStripMenuItem.Text = "GPM Antivirus Real-Time Protection"
        '
        'RTPON
        '
        Me.RTPON.Name = "RTPON"
        Me.RTPON.Size = New System.Drawing.Size(152, 22)
        Me.RTPON.Text = "On"
        '
        'RTPOFF
        '
        Me.RTPOFF.Name = "RTPOFF"
        Me.RTPOFF.Size = New System.Drawing.Size(152, 22)
        Me.RTPOFF.Text = "Off"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(282, 6)
        '
        'UpdateGPMAntivirusToolStripMenuItem
        '
        Me.UpdateGPMAntivirusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateGUIVisibleToolStripMenuItem, Me.ToolStripSeparator6, Me.UpdateGUIInvisibleToolStripMenuItem})
        Me.UpdateGPMAntivirusToolStripMenuItem.Name = "UpdateGPMAntivirusToolStripMenuItem"
        Me.UpdateGPMAntivirusToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.UpdateGPMAntivirusToolStripMenuItem.Text = "Update Virus Database"
        '
        'UpdateGUIVisibleToolStripMenuItem
        '
        Me.UpdateGUIVisibleToolStripMenuItem.Name = "UpdateGUIVisibleToolStripMenuItem"
        Me.UpdateGUIVisibleToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UpdateGUIVisibleToolStripMenuItem.Text = "Visible Update"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(170, 6)
        '
        'UpdateGUIInvisibleToolStripMenuItem
        '
        Me.UpdateGUIInvisibleToolStripMenuItem.Name = "UpdateGUIInvisibleToolStripMenuItem"
        Me.UpdateGUIInvisibleToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.UpdateGUIInvisibleToolStripMenuItem.Text = "Hidden Update"
        '
        'AutoUpdateGPMAntivirusToolStripMenuItem
        '
        Me.AutoUpdateGPMAntivirusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
        Me.AutoUpdateGPMAntivirusToolStripMenuItem.Name = "AutoUpdateGPMAntivirusToolStripMenuItem"
        Me.AutoUpdateGPMAntivirusToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.AutoUpdateGPMAntivirusToolStripMenuItem.Text = "Auto Update Virus Database"
        '
        'OnToolStripMenuItem
        '
        Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
        Me.OnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OnToolStripMenuItem.Text = "On"
        '
        'OffToolStripMenuItem
        '
        Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
        Me.OffToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OffToolStripMenuItem.Text = "Off"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(282, 6)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(282, 6)
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateBTC, Me.DonatePPL})
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.DonateToolStripMenuItem.Text = "Donate to Fund Development"
        '
        'DonateBTC
        '
        Me.DonateBTC.Name = "DonateBTC"
        Me.DonateBTC.Size = New System.Drawing.Size(152, 22)
        Me.DonateBTC.Text = "via Bitcoin"
        '
        'DonatePPL
        '
        Me.DonatePPL.Name = "DonatePPL"
        Me.DonatePPL.Size = New System.Drawing.Size(152, 22)
        Me.DonatePPL.Text = "via Paypal"
        '
        'VisitWebsiteToolStripMenuItem
        '
        Me.VisitWebsiteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitGIT, Me.VisitNB})
        Me.VisitWebsiteToolStripMenuItem.Name = "VisitWebsiteToolStripMenuItem"
        Me.VisitWebsiteToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.VisitWebsiteToolStripMenuItem.Text = "Visit Website"
        '
        'VisitGIT
        '
        Me.VisitGIT.Name = "VisitGIT"
        Me.VisitGIT.Size = New System.Drawing.Size(152, 22)
        Me.VisitGIT.Text = "On Github"
        '
        'VisitNB
        '
        Me.VisitNB.Name = "VisitNB"
        Me.VisitNB.Size = New System.Drawing.Size(152, 22)
        Me.VisitNB.Text = "On Noblogs"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(282, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'systray1
        '
        Me.systray1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.systray1.BalloonTipText = "GPM Antivirus 2014"
        Me.systray1.BalloonTipTitle = "GPMAV"
        Me.systray1.ContextMenuStrip = Me.sysstrp
        Me.systray1.Icon = CType(resources.GetObject("systray1.Icon"), System.Drawing.Icon)
        Me.systray1.Text = "GPM Antivirus"
        '
        'ShowReportsToolStripMenuItem
        '
        Me.ShowReportsToolStripMenuItem.Name = "ShowReportsToolStripMenuItem"
        Me.ShowReportsToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.ShowReportsToolStripMenuItem.Text = "View Logs"
        '
        'frmTray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(100, 35)
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTray"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.sysstrp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sysstrp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenGPMAntivirusGUIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenGPMAntivirusScannerGUIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GPMAntivirusRealTimeProtectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RTPON As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RTPOFF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateGPMAntivirusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateGUIVisibleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateGUIInvisibleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoUpdateGPMAntivirusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateBTC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonatePPL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitGIT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitNB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systray1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ShowReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
