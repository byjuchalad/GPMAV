<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLogs
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rtbScanLogs = New System.Windows.Forms.RichTextBox()
        Me.Tabpage2 = New System.Windows.Forms.TabPage()
        Me.rtbRTPlogs = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rtbUpdateLogs = New System.Windows.Forms.RichTextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tabpage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(265, 284)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.Tabpage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 280)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rtbScanLogs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(456, 251)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Scan Logs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rtbScanLogs
        '
        Me.rtbScanLogs.DetectUrls = False
        Me.rtbScanLogs.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbScanLogs.Location = New System.Drawing.Point(4, 4)
        Me.rtbScanLogs.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbScanLogs.Name = "rtbScanLogs"
        Me.rtbScanLogs.ReadOnly = True
        Me.rtbScanLogs.Size = New System.Drawing.Size(451, 247)
        Me.rtbScanLogs.TabIndex = 0
        Me.rtbScanLogs.Text = ""
        Me.rtbScanLogs.WordWrap = False
        '
        'Tabpage2
        '
        Me.Tabpage2.Controls.Add(Me.rtbRTPlogs)
        Me.Tabpage2.Location = New System.Drawing.Point(4, 25)
        Me.Tabpage2.Margin = New System.Windows.Forms.Padding(4)
        Me.Tabpage2.Name = "Tabpage2"
        Me.Tabpage2.Padding = New System.Windows.Forms.Padding(4)
        Me.Tabpage2.Size = New System.Drawing.Size(456, 251)
        Me.Tabpage2.TabIndex = 1
        Me.Tabpage2.Text = "RTP Logs"
        Me.Tabpage2.UseVisualStyleBackColor = True
        '
        'rtbRTPlogs
        '
        Me.rtbRTPlogs.DetectUrls = False
        Me.rtbRTPlogs.Location = New System.Drawing.Point(3, 2)
        Me.rtbRTPlogs.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbRTPlogs.Name = "rtbRTPlogs"
        Me.rtbRTPlogs.ReadOnly = True
        Me.rtbRTPlogs.Size = New System.Drawing.Size(449, 245)
        Me.rtbRTPlogs.TabIndex = 1
        Me.rtbRTPlogs.Text = ""
        Me.rtbRTPlogs.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.rtbUpdateLogs)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(456, 251)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Update Logs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rtbUpdateLogs
        '
        Me.rtbUpdateLogs.DetectUrls = False
        Me.rtbUpdateLogs.Location = New System.Drawing.Point(3, 2)
        Me.rtbUpdateLogs.Margin = New System.Windows.Forms.Padding(4)
        Me.rtbUpdateLogs.Name = "rtbUpdateLogs"
        Me.rtbUpdateLogs.ReadOnly = True
        Me.rtbUpdateLogs.Size = New System.Drawing.Size(453, 253)
        Me.rtbUpdateLogs.TabIndex = 1
        Me.rtbUpdateLogs.Text = ""
        Me.rtbUpdateLogs.WordWrap = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(8, 288)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 28)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dlgLogs
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(464, 325)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLogs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log Files"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Tabpage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Tabpage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents rtbScanLogs As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbRTPlogs As System.Windows.Forms.RichTextBox
    Friend WithEvents rtbUpdateLogs As System.Windows.Forms.RichTextBox

End Class
