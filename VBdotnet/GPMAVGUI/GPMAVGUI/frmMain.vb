'Project: GPM Antivirus
'Description: GPM Antivirus GUI
'Copyright 2010-2014 GPM
'Original Author: GPM
'Modified By:  

'This file is part of GPM Antivirus.

'GPM Antivirus is free software: you can redistribute it and/or modify it under the
'terms of the GNU General Public License as published by the Free Software
'Foundation, either version 3 of the License, or (at your option) any later
'version.

'GPM Antivirus is distributed in the hope that it will be useful, but WITHOUT ANY
'WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR
'A PARTICULAR PURPOSE. See the GNU General Public License for more details.

'A copy of the GNU General Public License can be found at
'<http://www.gnu.org/licenses/>.
Option Strict Off
Imports System
Imports System.IO
Imports System.IO.File
Imports Microsoft.Win32
Imports GPMAVGUI.WebFileDownloader
Imports System.Management
Imports GPMAVGUI.clsAPI
Imports System.Runtime.InteropServices
Imports System.Threading



Public Class frmMain

#Region "DeclareationS"

    Inherits System.Windows.Forms.Form
    Private Const DIR_MESSAGE As String = "Directory to download"
    Private WithEvents _Downloader As WebFileDownloader
    Dim Speed1 As Integer = 0
    Dim Speed2 As Integer = 0
    Dim Hrs As Integer
    Dim Min As Integer
    Dim Sec As Integer
    Dim TimeLeft As Integer = 0

    Dim AppDataPath As String = Application.StartupPath & "\Data"
    Dim PathtoDL As String = Application.StartupPath & "\TEMP\HOSTS"
    Dim PathtoTemp As String = Application.StartupPath & "\TEMP"
    Dim DL1 As String = "http://winhelp2002.mvps.org/hosts.txt"
    Dim DL2 As String = "http://hosts-file.net/.%5Cad_servers.txt"
    'Dim DL3 As String = "http://pgl.yoyo.org/adservers/serverlist.php"

    'Dim DL3 As String = "http://pgl.yoyo.org/adservers/serverlist.php?hostformat=hosts&showintro=0&mimetype=plaintext"

    Dim SYS As String = GetSpecialFolder(Environment.SpecialFolder.System)

    Dim HostsSys As String = SYS & "\drivers\etc\hosts"
    Dim BkHosts As String = AppDataPath & "\HOSTS.BK"
    Dim DataHosts As String = AppDataPath & "\HOSTS"


    Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName


    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
    Dim appp As String = regKey.GetValue("Install_Dir")
    'regKey.Close()


    Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"

    Private clean As New UniducksCleaner
    Private hasTreeNodesExpanded As Boolean = False

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
        systray1.Visible = True

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CheckForIllegalCrossThreadCalls = False


            RTF2.Text = My.Computer.FileSystem.ReadAllText(HostsSys)
            'ListProcesses()
            '  tProcs.Start()
            prgTime.Value = "100"
            clSystemInfo.SystemInformation()
            Me.tSysInfo.Start()

            lstProc.Items.Clear()
            Dim ps() As Process
            ps = Process.GetProcesses()
            Dim p As Process
            For Each p In ps
                lstProc.Items.Add(p.ProcessName)


            Next
            lblNoProc.Text = lstProc.Items.Count

            Me.HKCURegistry1()
            Me.HKLMRegistry1()
            Me.HKURegistry1()
            lblStartupNo.Text = "Number of Items: " & checkedListBox.Items.Count

            Dim info As New UniducksInformation

            For Each n As TreeNode In Me.tvwBrowsers.Nodes
                n.Checked = True
            Next
            For Each n As TreeNode In Me.tvwUserSystem.Nodes
                n.Checked = True
            Next


            hasTreeNodesExpanded = True

            Me.tvwBrowsers.ExpandAll()
            Me.tvwUserSystem.ExpandAll()


            Me.tvwBrowsers.Nodes(0).EnsureVisible()
            Me.tvwUserSystem.Nodes(0).EnsureVisible()


            systray1.Visible = True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub



    Private Sub btnMinTray_Click(sender As Object, e As EventArgs) Handles btnMinTray.Click

        Try
            Me.Hide()
            systray1.Visible = True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnAdEvader_Click(sender As Object, e As EventArgs) Handles btnAdEvader.Click
        Try
            tabctrl_1.SelectedTab = tabAdEvader

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnRegTools_Click(sender As Object, e As EventArgs) Handles btnRegTools.Click
        Try
            tabctrl_1.SelectedTab = tabRegTool
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnMemCleaner_Click(sender As Object, e As EventArgs) Handles btnMemCleaner.Click
        Try

            tabctrl_1.SelectedTab = tabMemClnr
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnProcExplr_Click(sender As Object, e As EventArgs) Handles btnProcExplr.Click
        Try

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub




#End Region

#Region "AdEvader"
    Private Function GetFileNameFromURL(ByVal URL As String) As String
        If URL.IndexOf("/"c) = -1 Then Return String.Empty
        Return "\" & URL.Substring(URL.LastIndexOf("/"c) + 1)
    End Function


    Private Sub _Downloader_FileDownloadSizeObtained(ByVal iFileSize As Long) Handles _Downloader.FileDownloadSizeObtained
        DownloadProgress1.Value = 0
        DownloadProgress1.Maximum = Convert.ToInt32(iFileSize)
    End Sub

    Private Sub _Downloader_FileDownloadComplete() Handles _Downloader.FileDownloadComplete
        DownloadProgress1.Value = DownloadProgress1.Maximum
        '   MessageBox.Show("Downloaded Complete")
    End Sub

    Private Sub _Downloader_FileDownloadFailed(ByVal ex As System.Exception) Handles _Downloader.FileDownloadFailed
        MessageBox.Show("An error has occured during download: " & ex.Message)
    End Sub

    Private Sub _Downloader_AmountDownloadedChanged(ByVal iNewProgress As Long) Handles _Downloader.AmountDownloadedChanged
        DownloadProgress1.Value = Convert.ToInt32(iNewProgress)
        LabelProgress.Text = "Progress:" & WebFileDownloader.FormatFileSize(iNewProgress) & " of " & WebFileDownloader.FormatFileSize(DownloadProgress1.Maximum) & " downloaded"
        Application.DoEvents()
    End Sub


    Private Sub TimerDownloadSpeed_Tick(sender As Object, e As EventArgs) Handles TimerDownloadSpeed.Tick
        If Math.Round((Speed1), 2) - Math.Round((Speed2), 2) <= 1023 Then
            Speed1 = Math.Round((DownloadProgress1.Value / 1024), 2)
            LabelSpeed.Text = "Speed: " & Math.Round((Speed1), 2) - Math.Round((Speed2), 2) & " KB\s"
            Try
                TimeLeft = Math.Round((Math.Round(DownloadProgress1.Maximum / 1024) - Math.Round(DownloadProgress1.Value / 1024)) / (Math.Round(Speed1) - Math.Round(Speed2)))
                Sec = TimeLeft Mod 60
                Min = ((TimeLeft - Sec) / 60) Mod 60
                Hrs = ((TimeLeft - (Sec + (Min * 60))) / 3600) Mod 60
                LabelTime.Text = "Time Left: " & Format(Hrs, "00") & "h " & Format(Min, "00") & "m " & Format(Sec, "00") & "s"
            Catch ex As Exception
                LabelTime.Text = "Time Left: ∞"
            End Try
            Speed2 = Math.Round((DownloadProgress1.Value / 1024), 2)
        End If
    End Sub

    Private Sub TimerSpeed_Tick(sender As Object, e As EventArgs) Handles TimerSpeed.Tick
        If DownloadProgress1.Value >= 1 Then
            TimerDownloadSpeed.Start()
        Else
            TimerDownloadSpeed.Stop()
            LabelSpeed.Text = "-"
            LabelTime.Text = "-"
        End If
    End Sub

    Public Function GetFileContents(ByVal FullPath As String, _
       Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function

    Public Function GetSpecialFolder(ByVal mFolder As Environment.SpecialFolder) As String
        GetSpecialFolder = Environment.GetFolderPath(mFolder)
    End Function



    Private Sub btnDLApply_Click(sender As Object, e As EventArgs) Handles btnDLApply.Click
        Try
            If IO.File.Exists(PathtoDL & "\dl1.txt") Then IO.File.Delete(PathtoDL & "\dl1.txt")
            If IO.File.Exists(PathtoDL & "\dl2.txt") Then IO.File.Delete(PathtoDL & "\dl2.txt")
            If IO.File.Exists(DataHosts) Then IO.File.Delete(DataHosts)
            If Not Directory.Exists(AppDataPath) Then Directory.CreateDirectory(AppDataPath)
            If Not Directory.Exists(PathtoTemp) Then Directory.CreateDirectory(PathtoTemp)


            _Downloader = New WebFileDownloader

            ' _Downloader.DownloadFileWithProgress(DL3, PathtoDL.TrimEnd("\"c) & "\dl3.txt")
            _Downloader.DownloadFileWithProgress(DL1, PathtoDL.TrimEnd("\"c) & "\dl1.txt")
            _Downloader.DownloadFileWithProgress(DL2, PathtoDL.TrimEnd("\"c) & "\dl2.txt")




            Dim StartDirectory As String = PathtoDL
            Dim OutPutFile As String = Application.StartupPath & "\DATA\HOSTS.txt"

            Dim SW As New IO.StreamWriter(OutPutFile, False)

            Dim Files As String() = IO.Directory.GetFiles(StartDirectory, "*.txt")
            Dim File As String

            For Each File In Files

                Dim SR As New IO.StreamReader(File)

                Do Until SR.EndOfStream
                    Dim TempString As String = SR.ReadLine
                    SW.WriteLine(TempString)
                Loop
                SW.WriteLine()

            Next

            SW.Flush()
            SW.Close()

            IO.File.Copy(Application.StartupPath & "\Data\HOSTS.txt", DataHosts, True)
            '   GetFileContents(Application.StartupPath & "\Data\HOSTS.txt")
            RTF1.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Data\HOSTS.txt")
            btnApplyHosts.Enabled = True
            MsgBox("Click 'Apply' to Activate Downloaded Hosts Files")



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub


    Private Sub btnApplyHosts_Click(sender As Object, e As EventArgs) Handles btnApplyHosts.Click
        Try
            IO.File.Delete(PathtoDL & "\dl1.txt")
            IO.File.Delete(PathtoDL & "\dl2.txt")

            If File.Exists(HostsSys) Then File.Copy(HostsSys, BkHosts, True)
            Process.Start("net", " stop DNSCACHE")
            If File.Exists(AppDataPath & "\HOSTS.bk") Then
                File.Delete(HostsSys)
                File.Copy(DataHosts, HostsSys, True)
                Process.Start("net", " start DNSCACHE")
            End If
            btnRemoveAdBlock.Enabled = True
            MsgBox("DONE, AdEvader Activated")


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHelpAdBlock_Click(sender As Object, e As EventArgs) Handles btnHelpAdBlock.Click
        Process.Start("https://en.wikipedia.org/wiki/Hosts_%28file%29")
    End Sub

    Private Sub btnRemoveAdBlock_Click(sender As Object, e As EventArgs) Handles btnRemoveAdBlock.Click
        Try
            '  Dim HostsSys As String = SYS & "\drivers\etc\hosts"
            '  Dim BkHosts As String = AppDataPath & "\HOSTS.BK"
            '  Dim DataHosts As String = AppDataPath & "\HOSTS"

            If File.Exists(BkHosts) Then
                Process.Start("net", " stop DNSCACHE")
                File.Delete(HostsSys)
                File.Copy(BkHosts, HostsSys, True)
                Process.Start("net", " start DNSCACHE")
            End If

            MsgBox("DONE, Restored Default HOSTS File")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


#End Region

#Region "Tray"

    Private Sub OpenGPMAntivirusGUIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenGPMAntivirusGUIToolStripMenuItem.Click
        Me.Show()
    End Sub


    Private Sub OpenGPMAntivirusScannerGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGPMAntivirusScannerGUIToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAV-SCANGUI.exe") Then

                Shell(AppPath & "\GPMAV-SCANGUI.exe", AppWinStyle.NormalFocus)
            Else

                Dim regKey As RegistryKey
                Dim ver As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                ' regKey.SetValue("AppName", "MyRegApp")
                ver = regKey.GetValue("Install_Dir")
                '    If ver < 1.1 Then
                'regKey.SetValue("Version", 1.1)
                'End If
                Process.Start(ver & "\GPMAV-SCANGUI.exe")
                regKey.Close()


            End If
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("GPM Antivirus 2014" & vbCrLf & "Version 14.5" & vbCrLf & "Created by GPM", MsgBoxStyle.Information, "About: GPM Antivirus")
    End Sub


    Private Sub UpdateGUIVisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateGUIVisibleToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAV-UPDATE-GUI.exe") Then

                Shell(AppPath & "\GPMAV-UPDATE-GUI.exe", AppWinStyle.NormalFocus)
            Else

                Dim regKey As RegistryKey
                Dim ver As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                ' regKey.SetValue("AppName", "MyRegApp")
                ver = regKey.GetValue("Install_Dir")
                '    If ver < 1.1 Then
                'regKey.SetValue("Version", 1.1)
                'End If
                Process.Start(ver & "\GPMAV-UPDATE-GUI.exe")
                regKey.Close()


            End If
        Catch ex2 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub UpdateGUIInvisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateGUIInvisibleToolStripMenuItem.Click
        Try

  

            If My.Computer.FileSystem.FileExists(AppPath & "\gpmavupdate.exe") Then


                Dim p As New ProcessStartInfo(AppPath & "\gpmavupdate.exe", "--stdout --log=" & appp & "\logs\Autoupdatelog.log")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)

                'Shell(AppPath & "\gpmavupdate.exe", AppWinStyle.Hide)
            Else

                Dim regKey As RegistryKey
                Dim ver As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                ' regKey.SetValue("AppName", "MyRegApp")
                ver = regKey.GetValue("Install_Dir")
                '    If ver < 1.1 Then
                'regKey.SetValue("Version", 1.1)
                'End If
                ' Process.Start(ver & "\gpmavupdate.exe", "--stdout --log=" & ver & "\logs\Autoupdatelog.log")



                Dim p As New ProcessStartInfo(ver & "\gpmavupdate.exe", "--stdout --log=" & ver & "\logs\Autoupdatelog.log")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)

                regKey.Close()


            End If
        Catch ex3 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub



    Private Sub RunRealTimeForDriveCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTPON.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMClamAVRT.exe") Then


                Dim p As New ProcessStartInfo(AppPath & "\GPMClamAVRT.exe")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)

                'Shell(AppPath & "\GPMClamAVRT.exe", AppWinStyle.NormalFocus)
            Else

                Dim regKey As RegistryKey
                Dim ver As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                ' regKey.SetValue("AppName", "MyRegApp")
                ver = regKey.GetValue("Install_Dir")
                '    If ver < 1.1 Then
                'regKey.SetValue("Version", 1.1)
                'End If
                ' Process.Start(ver & "\GPMClamAVRT.exe")

                Dim p As New ProcessStartInfo(ver & "\GPMClamAVRT.exe")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)
                regKey.Close()


            End If
        Catch ex6 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub


    Private Sub StopRealTimeForDriveCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTPOFF.Click
        ' Kill process
        Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("GPMClamAVRT")

        For Each p As Process In pProcess
            p.Kill()
        Next
    End Sub


    Private Sub systray1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles systray1.Click
        sysstrp.Show()
    End Sub
    Private Sub systray1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles systray1.MouseDoubleClick
        sysstrp.Show()
    End Sub

    Private Sub VisitNB_Click(sender As Object, e As EventArgs) Handles VisitNB.Click
        Process.Start("http://www.gpmantivirus.noblogs.org")
    End Sub



    Private Sub DonateBTC_Click(sender As Object, e As EventArgs) Handles DonateBTC.Click
        '  Process.Start("bitcoin: 1DxFQQXLMTCtZjeshZ3dRseSxKk5TzugSv?label=GPMAV DONATION OFFICIAL")
        dlgDonate.ShowDialog()
    End Sub

    Private Sub DonatePPL_Click(sender As Object, e As EventArgs) Handles DonatePPL.Click
        Try
            Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=WFBYGAENP3VGY")
        Catch ex As Exception

        End Try

    End Sub


    Private Sub VisitGIT_Click(sender As Object, e As EventArgs) Handles VisitGIT.Click
        Try
            Process.Start("https://github.com/R1BN")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            Me.Dispose()
            Application.Exit()
            End
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Mem Clnr"

    Private m_EventDate As Date
    Public Function getStartUpName() As String
        Dim lioString As String
        Dim lstBS As Integer = Application.ExecutablePath.LastIndexOf("\")
        Dim spltStr() As String
        lioString = Application.ExecutablePath.Substring(lstBS)
        spltStr = lioString.Split("\")
        Return spltStr(1)
    End Function
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSize As Integer) As Integer

    Private Sub tmrClock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClock.Tick

        Try
            Dim remaining As TimeSpan = m_EventDate.Subtract(Now)
            If remaining.TotalSeconds < 1 Then
            Else



                prgTime.Value = remaining.Seconds

                prgTime.PerformStep()
                If prgTime.Value >= prgTime.Maximum Then

                    prgTime.Value = remaining.Seconds

                End If

                prgTime.Value = remaining.Minutes
                prgTime.PerformStep()
                If prgTime.Value >= prgTime.Maximum Then

                    prgTime.Value = remaining.Minutes

                End If

            End If


            lstProc.Items.Clear()
            Dim ps() As Process
            ps = Process.GetProcesses()
            Dim p As Process
            For Each p In ps

                lblNoProc.Text = lstProc.Items.Count
            Next


        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick
        Try
            ''  Me.lblAvail.Text = (Strings.Format(My.Computer.Info.AvailablePhysicalMemory, "###########0") / 1024 / 1024 & " MB") & " Total Physical Memory: " & My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 & "MB"
            'Me.lblAvail.Text = CInt(Math.Round(CDbl(((100 / CDbl(My.Computer.Info.TotalPhysicalMemory)) * My.Computer.Info.AvailablePhysicalMemory))))
            Me.lblTotPhys.Text = CInt(Math.Round(CDbl(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024)) & " MB"
            Me.lblAvailPhysMem.Text = CInt(Math.Round(CDbl(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024)) - CInt(Math.Round(CDbl(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024)) & " MB"

            Me.lblTotVir.Text = CInt(Math.Round(CDbl(My.Computer.Info.TotalVirtualMemory) / 1024 / 1024)) & " MB"
            Me.lblAvailVirMem.Text = CInt(Math.Round(CDbl(My.Computer.Info.TotalVirtualMemory) / 1024 / 1024)) - CInt(Math.Round(CDbl(My.Computer.Info.AvailableVirtualMemory) / 1024 / 1024)) & " MB"

            Me.lblAvailVirMemPercent.Text = "Available Virtual Memory: " & CInt(Math.Round(CDbl(((100 / CDbl(My.Computer.Info.TotalVirtualMemory)) * My.Computer.Info.AvailableVirtualMemory)))) & " %"
            Me.lblPercentAvailPhys.Text = "Available Physical Memory: " & CInt(Math.Round(CDbl(((100 / CDbl(My.Computer.Info.TotalPhysicalMemory)) * My.Computer.Info.AvailablePhysicalMemory)))) & " %"
            Me.prgmemory.Value = CInt(Math.Round(CDbl(((100 / CDbl(My.Computer.Info.TotalPhysicalMemory)) * My.Computer.Info.AvailablePhysicalMemory))))
            Me.prgmemoryVir.Value = CInt(Math.Round(CDbl(((100 / CDbl(My.Computer.Info.TotalVirtualMemory)) * My.Computer.Info.AvailableVirtualMemory))))


        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub tmrClear_Tick(sender As Object, e As EventArgs) Handles tmrClear.Tick
        Try

            bgWorker2.RunWorkerAsync()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgWorker1.DoWork
        Try
            lstProc.Items.Clear()
            Dim ps() As Process
            ps = Process.GetProcesses()
            Dim p As Process
            For Each p In ps
                lstProc.Items.Add(p.ProcessName)
                If p.ProcessName.Contains("Idle") Then
                    lstProc.Items.Remove("Idle")
                    lstProc.Items.Remove("System")
                Else
                    ' MsgBox(p.ProcessName)
                End If
                lblNoProc.Text = lstProc.Items.Count
                prgClear.Maximum = lstProc.Items.Count
                ' prgClear.Value = prgClear.Maximum
                Dim i As Integer

                Dim inc As Integer = (prgClear.Value = prgClear.Maximum - 1)

                For i = 0 To lstProc.Items.Count - 1

                    'prgClear.PerformStep()
                    'prgClear.Increment(inc)
                    prgClear.Step = inc

                    ' prgClear.Value = prgClear.Maximum - 1

                    'MessageBox.Show(lstProc.Items(i))
                    GC.Collect()
                    GC.WaitForPendingFinalizers()
                    If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then

                        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                        Dim myProcesses As Process() = Process.GetProcessesByName(lstProc.Items(i)) '("ApplicationName")
                        '   Dim myProcesses As Process
                        'Dim ProcessInfo As Process
                        For Each myProcess In myProcesses
                            SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                        Next myProcess
                    End If
                Next

                '  ListBox1.Items.Add(p.ProcessName)


            Next
            GC.Collect()
            GC.WaitForPendingFinalizers()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Try
    '    tmrClear.Enabled = True
    '     tmrClear.Interval = numUpDown.Value * 60000
    '      tmrClock.Start()
    ''      tmrClock.Enabled = True

    '   Catch ex As Exception
    '     Debug.WriteLine(ex.Message)
    '  End Try


    ' End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRegTools.Click
    ' Try
    '      tmrClear.Enabled = False
    '      tmrClear.Interval = numUpDown.Value * 60000
    ' '     tmrClock.Stop()
    '      tmrClock.Enabled = False
    ''
    '   Catch ex As Exception
    '        Debug.WriteLine(ex.Message)
    ' End Try
    'End Sub

    Private Sub tSysInfo_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles tSysInfo.Elapsed
        Try
            clSystemInfo.SystemInformation()

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub




    Private Sub bgWorker2_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bgWorker2.DoWork
        Try

            lstProc.Items.Clear()
            Dim ps() As Process
            ps = Process.GetProcesses()
            Dim p As Process
            For Each p In ps
                lstProc.Items.Add(p.ProcessName)
                If p.ProcessName.Contains("Idle") Then
                    lstProc.Items.Remove("Idle")
                    lstProc.Items.Remove("System")
                Else
                    ' MsgBox(p.ProcessName)
                End If
                lblNoProc.Text = lstProc.Items.Count
                prgClear.Maximum = lstProc.Items.Count
                ' prgClear.Value = prgClear.Maximum
                Dim i As Integer

                Dim inc As Integer = (prgClear.Value = prgClear.Maximum - 1)

                For i = 0 To lstProc.Items.Count - 1

                    'prgClear.PerformStep()
                    'prgClear.Increment(inc)
                    prgClear.Step = inc

                    'MessageBox.Show(lstProc.Items(i))
                    GC.Collect()
                    GC.WaitForPendingFinalizers()
                    If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then

                        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                        Dim myProcesses As Process() = Process.GetProcessesByName(lstProc.Items(i)) '("ApplicationName")
                        '   Dim myProcesses As Process
                        'Dim ProcessInfo As Process
                        For Each myProcess In myProcesses
                            SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                        Next myProcess
                    End If
                Next

                '  ListBox1.Items.Add(p.ProcessName)


            Next


        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub


    Private Sub btnFreeMem_Click(sender As Object, e As EventArgs) Handles btnFreeMem.Click
        Try
            bgWorker1.RunWorkerAsync()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnAutFre_Click(sender As Object, e As EventArgs) Handles btnAutFre.Click
        Try
            tmrClear.Enabled = True
            tmrClear.Interval = numUpDown.Value * 60000
            tmrClock.Start()
            tmrClock.Enabled = True

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnAutFreof_Click(sender As Object, e As EventArgs) Handles btnAutFreof.Click
        Try
            tmrClear.Enabled = False
            tmrClear.Interval = numUpDown.Value * 60000
            tmrClock.Stop()
            tmrClock.Enabled = False

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
#End Region

#Region "RegTools"

#Region "Declarations"
    'Dim key As Object
    Dim key = CreateObject("WScript.Shell")
    Dim hklmpoliciessystem = "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System"
    Dim hkcupoliciessystem = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System"

    Dim hklmpoliciesexplorer = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"
    Dim hkcupoliciesexplorer = "HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"
#End Region

    Private Sub btnSelAllREG_Click(sender As Object, e As EventArgs) Handles btnSelAllREG.Click
        Try
            tskmgr.CheckState = CheckState.Checked
            regedit.CheckState = CheckState.Checked
            fldopt.CheckState = CheckState.Checked
            cmd.CheckState = CheckState.Checked
            cpl.CheckState = CheckState.Checked

            desktop.CheckState = CheckState.Checked
            taskbar.CheckState = CheckState.Checked
            run.CheckState = CheckState.Checked
            logoff.CheckState = CheckState.Checked
            filemenu.CheckState = CheckState.Checked

            winupdate.CheckState = CheckState.Checked
            addremove.CheckState = CheckState.Checked
            savesettings.CheckState = CheckState.Checked
            taskbarcontext.CheckState = CheckState.Checked
            wallpaper.CheckState = CheckState.Checked
            htmlwallpaper.CheckState = CheckState.Checked

            chkRecentDoc.CheckState = CheckState.Checked
            chkChangePW.CheckState = CheckState.Checked
            chkChWP.CheckState = CheckState.Checked
            chkWinClose.CheckState = CheckState.Checked
            chkWinLock.CheckState = CheckState.Checked
            chkDisCPL.CheckState = CheckState.Checked
            chkWinLogoff.CheckState = CheckState.Checked
            chkSetTaskbar.CheckState = CheckState.Checked
            chkTrayCNTX.CheckState = CheckState.Checked
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSelNonREG_Click(sender As Object, e As EventArgs) Handles btnSelNonREG.Click
        Try
            tskmgr.CheckState = CheckState.Unchecked
            regedit.CheckState = CheckState.Unchecked
            fldopt.CheckState = CheckState.Unchecked
            cmd.CheckState = CheckState.Unchecked
            cpl.CheckState = CheckState.Unchecked

            desktop.CheckState = CheckState.Unchecked
            taskbar.CheckState = CheckState.Unchecked
            run.CheckState = CheckState.Unchecked
            logoff.CheckState = CheckState.Unchecked
            filemenu.CheckState = CheckState.Unchecked
            winupdate.CheckState = CheckState.Unchecked
            addremove.CheckState = CheckState.Unchecked
            savesettings.CheckState = CheckState.Unchecked
            taskbarcontext.CheckState = CheckState.Unchecked
            wallpaper.CheckState = CheckState.Unchecked
            htmlwallpaper.CheckState = CheckState.Unchecked

            chkRecentDoc.CheckState = CheckState.Unchecked
            chkChangePW.CheckState = CheckState.Unchecked
            chkChWP.CheckState = CheckState.Unchecked
            chkWinClose.CheckState = CheckState.Unchecked
            chkWinLock.CheckState = CheckState.Unchecked
            chkDisCPL.CheckState = CheckState.Unchecked
            chkWinLogoff.CheckState = CheckState.Unchecked
            chkSetTaskbar.CheckState = CheckState.Unchecked
            chkTrayCNTX.CheckState = CheckState.Unchecked
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSelDefREG_Click(sender As Object, e As EventArgs) Handles btnSelDefREG.Click
        Try
            tskmgr.CheckState = CheckState.Checked
            regedit.CheckState = CheckState.Checked
            fldopt.CheckState = CheckState.Checked
            cmd.CheckState = CheckState.Checked
            cpl.CheckState = CheckState.Checked
            chkRecentDoc.CheckState = CheckState.Checked
            chkChangePW.CheckState = CheckState.Checked
            chkChWP.CheckState = CheckState.Checked
            chkWinClose.CheckState = CheckState.Checked
            chkWinLock.CheckState = CheckState.Checked
            chkDisCPL.CheckState = CheckState.Checked
            chkWinLogoff.CheckState = CheckState.Checked
            chkSetTaskbar.CheckState = CheckState.Checked
            chkTrayCNTX.CheckState = CheckState.Checked
            desktop.CheckState = CheckState.Checked
            taskbar.CheckState = CheckState.Checked
            run.CheckState = CheckState.Checked
            logoff.CheckState = CheckState.Checked
            filemenu.CheckState = CheckState.Checked
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnScanReg_Click(sender As Object, e As EventArgs) Handles btnScanReg.Click
        Try

            lstRegAVList.Items.Clear()

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableTaskMgr", 0) = "1" Then
                lstRegAVList.Items.Add("Task Manager is Disabled! (0)")
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableTaskMgr", 0) = "1" Then
                lstRegAVList.Items.Add("Task Manager is Disabled! (1)")
            End If

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableRegistryTools", 0) = "1" Then
                lstRegAVList.Items.Add("Registry Editor is Disabled! (0)")
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableRegistryTools", 0) = "1" Then
                lstRegAVList.Items.Add("Registry Editor is Disabled! (1)")
            End If

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "NoFolderOptions", 0) = "1" Then
                lstRegAVList.Items.Add("Folder Options is Disabled! (0)")
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "NoFolderOptions", 0) = "1" Then
                lstRegAVList.Items.Add("Folder Options is Disabled! (1)")
            End If

            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableCMD", 0) = "1" Then
                lstRegAVList.Items.Add("Command Prompt is Disabled! (0)")
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableCMD", 0) = "1" Then
                lstRegAVList.Items.Add("Command Prompt is Disabled! (1)")
            End If
            btnFixReg.Enabled = True
        Catch ex As Exception
            Beep()
            MessageBox.Show(ex.Message, "ERROR!")
        End Try
    End Sub

    'HKCURUN
    'HKCURUNONCE
    Private Sub HKCURegistry1()
        Dim key As RegistryKey
        Dim valueNames As String()
        Dim currentUser As RegistryKey = Registry.CurrentUser
        Dim name As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim str2 As String = "Software\Microsoft\Windows\CurrentVersion\Runonce"
        Try
            key = currentUser.OpenSubKey(name, True)
            valueNames = key.GetValueNames
            Dim str3 As String
            For Each str3 In valueNames
                Try
                    ' Me.checkedListBox.Items.Add(("HKCURUN: " & str3 & " >> " & key.GetValue(str3).ToString))
                    Me.checkedListBox.Items.Add((str3 & " >> " & key.GetValue(str3).ToString))
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
        Try
            key = currentUser.OpenSubKey(str2, True)
            valueNames = key.GetValueNames
            Dim str3 As String
            For Each str3 In valueNames
                Try
                    '  Me.checkedListBox.Items.Add(("HKCURUNONCE: " & str3 & " >> " & key.GetValue(str3).ToString))
                    Me.checkedListBox.Items.Add((str3 & " >> " & key.GetValue(str3).ToString))
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
    End Sub


    'HKLMRUN:
    'HKLMRUNONCE
    Private Sub HKLMRegistry1()
        Dim key2 As RegistryKey
        Dim valueNames As String()
        Dim localMachine As RegistryKey = Registry.LocalMachine
        Dim name As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim str2 As String = "Software\Microsoft\Windows\CurrentVersion\Runonce"
        Dim str3 As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnceEx"
        Try
            key2 = localMachine.OpenSubKey(name, True)
            valueNames = key2.GetValueNames
            Dim str4 As String
            For Each str4 In valueNames
                Try
                    'Me.checkedListBox.Items.Add(("HKLMRUN: " & str4 & " >> " & key2.GetValue(str4).ToString))
                    Me.checkedListBox.Items.Add((str4 & " >> " & key2.GetValue(str4).ToString))
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
        Try
            key2 = localMachine.OpenSubKey(str2, True)
            valueNames = key2.GetValueNames
            Dim str4 As String
            For Each str4 In valueNames
                Try
                    '    Me.checkedListBox.Items.Add(("HKLMRUNONCE: " & str4 & " >> " & key2.GetValue(str4).ToString))
                    Me.checkedListBox.Items.Add((str4 & " >> " & key2.GetValue(str4).ToString))
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
        Try
            key2 = localMachine.OpenSubKey(str3, True)
            valueNames = key2.GetValueNames
            Dim str4 As String
            For Each str4 In valueNames
                Try
                    Me.checkedListBox.Items.Add(key2.GetValue(str4).ToString)
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
    End Sub

    'HKURUN
    Private Sub HKURegistry1()
        Dim users As RegistryKey = Registry.Users
        Dim name As String = ".DEFAULT\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Try
            Dim key2 As RegistryKey = users.OpenSubKey(name, True)
            Dim valueNames As String() = key2.GetValueNames
            Dim str2 As String
            For Each str2 In valueNames
                Try
                    ' Me.checkedListBox.Items.Add(("HKURUN: " & str2 & " >> " & key2.GetValue(str2).ToString))
                    Me.checkedListBox.Items.Add((str2 & " >> " & key2.GetValue(str2).ToString))
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            Me.checkedListBox.Items.Clear()
            MyBase.Update()
            Me.HKLMRegistry1()
            MyBase.Update()
            Me.HKCURegistry1()
            MyBase.Update()
            Me.HKURegistry1()
            MyBase.Update()
            lblStartupNo.Text = "Number of Items: " & checkedListBox.Items.Count
        Catch ex As Exception
            Beep()
            MessageBox.Show(ex.Message, "ERROR!")
        End Try
    End Sub


    Private Sub btnFixReg_Click(sender As Object, e As EventArgs) Handles btnFixReg.Click
        Try
            lstRegAVList.Items.Clear()
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableTaskMgr", 0) = "1" Then
                My.Computer.Registry.SetValue(hklmpoliciessystem, "DisableTaskMgr", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableTaskMgr", 0) = "1" Then
                lstRegAVList.Items.Add("Task Manager is Disabled! (1)")
                My.Computer.Registry.SetValue(hkcupoliciessystem, "DisableTaskMgr", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableRegistryTools", 0) = "1" Then
                lstRegAVList.Items.Add("Registry Editor is Disabled! (0)")
                My.Computer.Registry.SetValue(hklmpoliciessystem, "DisableRegistryTools", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableRegistryTools", 0) = "1" Then
                lstRegAVList.Items.Add("Registry Editor is Disabled! (1)")
                My.Computer.Registry.SetValue(hkcupoliciessystem, "DisableRegistryTools", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "NoFolderOptions", 0) = "1" Then
                lstRegAVList.Items.Add("Folder Options is Disabled! (0)")
                My.Computer.Registry.SetValue(hklmpoliciessystem, "NoFolderOptions", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "NoFolderOptions", 0) = "1" Then
                lstRegAVList.Items.Add("Folder Options is Disabled! (1)")
                My.Computer.Registry.SetValue(hkcupoliciessystem, "NoFolderOptions", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hklmpoliciessystem, "DisableCMD", 0) = "1" Then
                lstRegAVList.Items.Add("Command Prompt is Disabled! (0)")
                My.Computer.Registry.SetValue(hklmpoliciessystem, "DisableCMD", 0)
                lstRegAVList.Items.Clear()
            End If
            If My.Computer.Registry.GetValue(hkcupoliciessystem, "DisableCMD", 0) = "1" Then
                lstRegAVList.Items.Add("Command Prompt is Disabled! (1)")
                My.Computer.Registry.SetValue(hkcupoliciessystem, "DisableCMD", 0)
                lstRegAVList.Items.Clear()
            End If
        Catch ex As Exception
            Beep()
            MessageBox.Show(ex.Message, "ERROR!")
        End Try
    End Sub

    Private Sub btnSaveSel_Click(sender As Object, e As EventArgs) Handles btnSaveSel.Click
        Try
            If tskmgr.Checked Then
                key.regwrite(hklmpoliciessystem & "\DisableTaskMgr", 0, "REG_DWORD")
                key.regwrite(hkcupoliciessystem & "\DisableTaskMgr", 0, "REG_DWORD")
            Else
                key.regwrite(hklmpoliciessystem & "\DisableTaskMgr", 1, "REG_DWORD")
                key.regwrite(hkcupoliciessystem & "\DisableTaskMgr", 1, "REG_DWORD")
            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try

        Try
            If regedit.Checked Then
                key.regwrite(hklmpoliciessystem & "\DisableRegistryTools", 0, "REG_DWORD")
                key.regwrite(hkcupoliciessystem & "\DisableRegistryTools", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciessystem & "\DisableRegistryTools", 1, "REG_DWORD")
                key.regwrite(hkcupoliciessystem & "\DisableRegistryTools", 1, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try

        Try
            If fldopt.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoFolderOptions", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoFolderOptions", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoFolderOptions", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoFolderOptions", 1, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try


        Try
            If cmd.Checked Then
                key.regwrite(hklmpoliciessystem & "\DisableCMD", 0, "REG_DWORD")
                key.regwrite(hkcupoliciessystem & "\DisableCMD", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciessystem & "\DisableCMD", 1, "REG_DWORD")
                key.regwrite(hkcupoliciessystem & "\DisableCMD", 1, "REG_DWORD")


            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try




        Try
            If cpl.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoControlPanel", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoControlPanel", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoControlPanel", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoControlPanel", 1, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try


        If desktop.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoDesktop", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoDesktop", 0, "REG_DWORD")


        Else
            key.regwrite(hklmpoliciesexplorer & "\NoDesktop", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoDesktop", 1, "REG_DWORD")

        End If

        If taskbar.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoTaskbar", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoTaskbar", 0, "REG_DWORD")


        Else
            key.regwrite(hklmpoliciesexplorer & "\NoTaskbar", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoTaskbar", 1, "REG_DWORD")

        End If

        If run.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoRun", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoRun", 0, "REG_DWORD")
            key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\NoRun", 0, "REG_DWORD")
            key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System\NoRun", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\NoRun", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoRun", 1, "REG_DWORD")
            key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\NoRun", 1, "REG_DWORD")
            key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System\NoRun", 1, "REG_DWORD")
        End If

        If chkRecentDoc.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoRecentDocsMenu", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoRecentDocsMenu", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\NoRecentDocsMenu", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoRecentDocsMenu", 1, "REG_DWORD")
        End If

        If chkChangePW.Checked Then
            key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableChangePassword", 0, "REG_DWORD")
            key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableChangePassword", 0, "REG_DWORD")

        Else
            key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableChangePassword", 1, "REG_DWORD")
            key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableChangePassword", 1, "REG_DWORD")

        End If

        If chkChWP.Checked Then
            key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 0, "REG_DWORD")
            key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 0, "REG_DWORD")

        Else
            key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 1, "REG_DWORD")
            key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 1, "REG_DWORD")

        End If


        If chkWinLock.Checked Then
            key.regwrite(hklmpoliciessystem & "\DisableLockWorkstation", 0, "REG_DWORD")
            key.regwrite(hkcupoliciessystem & "\DisableLockWorkstation", 0, "REG_DWORD")


        Else
            key.regwrite(hklmpoliciessystem & "\DisableLockWorkstation", 1, "REG_DWORD")
            key.regwrite(hkcupoliciessystem & "\DisableLockWorkstation", 1, "REG_DWORD")

        End If

        If chkDisCPL.Checked Then
            key.regwrite(hklmpoliciessystem & "\NoDispCpl", 0, "REG_DWORD")
            key.regwrite(hkcupoliciessystem & "\NoDispCpl", 0, "REG_DWORD")


        Else
            key.regwrite(hklmpoliciessystem & "\NoDispCpl", 1, "REG_DWORD")
            key.regwrite(hkcupoliciessystem & "\NoDispCpl", 1, "REG_DWORD")

        End If

        If chkWinLogoff.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoLogOff", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoLogOff", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\NoLogOff", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoLogOff", 1, "REG_DWORD")
        End If

        If chkSetTaskbar.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoSetTaskbar", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoSetTaskbar", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\NoSetTaskbar", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoSetTaskbar", 1, "REG_DWORD")
        End If

        If chkTrayCNTX.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoTrayContextMenu", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoTrayContextMenu", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\NoTrayContextMenu", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoTrayContextMenu", 1, "REG_DWORD")
        End If

        If logoff.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\StartMenuLogOfF", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\StartMenuLogOfF", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\StartMenuLogOfF", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\StartMenuLogOfF", 1, "REG_DWORD")
        End If

        If chkWinClose.Checked Then
            key.regwrite(hklmpoliciesexplorer & "\NoClose", 0, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoClose", 0, "REG_DWORD")

        Else
            key.regwrite(hklmpoliciesexplorer & "\NoClose", 1, "REG_DWORD")
            key.regwrite(hkcupoliciesexplorer & "\NoClose", 1, "REG_DWORD")
        End If

        Try
            If run.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoRun", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoRun", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoRun", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoRUn", 1, "REG_DWORD")

            End If
        Catch ex As Exception
            Beep()
            MessageBox.Show(ex.Message, "ERROR!")
        End Try

        Try
            If logoff.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoLogoff", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoLogoff", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoLogoff", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoLogoff", 1, "REG_DWORD")

            End If
        Catch ex As Exception
        End Try

        Try
            If filemenu.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoFileMenu", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoFileMenu", 0, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoFileMenu", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoFileMenu", 1, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try

        Try
            If winupdate.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoWindowsUpdate", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoWindowsUpdate", 1, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoWindowsUpdate", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoWindowsUpdate", 0, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")

        End Try

        Try
            If addremove.Checked Then
                '     key.regwrite(hklmpoliciesexplorer & "\NoDesktop", 0, "REG_DWORD")
                '   key.regwrite(hkcupoliciesexplorer & "\NoDesktop", 0, "REG_DWORD")

                key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall\NoAddRemovePrograms", 1, "REG_DWORD")
                key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall\NoAddRemovePrograms", 1, "REG_DWORD")

            Else
                ' key.regwrite(hklmpoliciesexplorer & "\NoDesktop", 1, "REG_DWORD")
                ' key.regwrite(hkcupoliciesexplorer & "\NoDesktop", 1, "REG_DWORD")

                key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall\NoAddRemovePrograms", 0, "REG_DWORD")
                key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Uninstall\NoAddRemovePrograms", 0, "REG_DWORD")
            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")

        End Try

        Try
            If savesettings.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoSaveSettings", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoSaveSettings", 1, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoSaveSettings", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoSaveSettings", 0, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try

        Try
            If taskbarcontext.Checked Then
                key.regwrite(hklmpoliciesexplorer & "\NoTrayContextMenu", 1, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoTrayContextMenu", 1, "REG_DWORD")


            Else
                key.regwrite(hklmpoliciesexplorer & "\NoTrayContextMenu", 0, "REG_DWORD")
                key.regwrite(hkcupoliciesexplorer & "\NoTrayContextMenu", 0, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try
        Try
            If wallpaper.Checked Then

                key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 1, "REG_DWORD")
                key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 1, "REG_DWORD")


            Else
                key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 0, "REG_DWORD")
                key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoChangingWallPaper", 0, "REG_DWORD")

            End If
        Catch ex As Exception

            Beep()
            MessageBox.Show(ex.Message, "ERROR!")


        End Try

        Try
            If htmlwallpaper.Checked Then

                key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoHTMLWallPaper", 1, "REG_DWORD")
                key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoHTMLWallPaper", 1, "REG_DWORD")


            Else
                key.regwrite("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoHTMLWallPaper", 0, "REG_DWORD")
                key.regwrite("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop\NoHTMLWallPaper", 0, "REG_DWORD")

            End If
        Catch ex As Exception
            Beep()
            MessageBox.Show(ex.Message, "ERROR!")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (Me.checkedListBox.CheckedItems.Count = 0) Then
                MessageBox.Show("Please select the Registry Value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.checkedListBox.Focus()
            Else
                Dim str As String


                For Each str In Me.checkedListBox.CheckedItems
                    Dim strHKLM1 As String
                    Dim strHKLM2 As String
                    Dim valueNames As String()
                    'If (Me.ComboReg.SelectedItem.ToString = "HKLM Run") Then
                    Dim key2 As RegistryKey
                    Dim localMachine As RegistryKey = Registry.LocalMachine
                    strHKLM1 = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
                    strHKLM2 = "Software\Microsoft\Windows\CurrentVersion\Runonce"
                    Dim name As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnceEx"
                    Try
                        key2 = localMachine.OpenSubKey(strHKLM1, True)
                        valueNames = key2.GetValueNames
                        Dim str5 As String
                        For Each str5 In valueNames
                            Try
                                If ((str5 & " >> " & key2.GetValue(str5).ToString) = str) Then
                                    key2.DeleteValue(str5)
                                    key2.Flush()
                                    Me.checkedListBox.Items.Remove(str)
                                    ' Me.checkedListBox.Refresh()
                                    ' Me.btnDelete(sender, e)
                                End If
                            Catch ex As Exception
                                Beep()
                                MessageBox.Show(ex.Message, "ERROR!")
                            End Try
                        Next
                    Catch ex As Exception
                        Beep()
                        MessageBox.Show(ex.Message, "ERROR!")
                    End Try
                    Try

                        key2 = localMachine.OpenSubKey(strHKLM2, True)
                        valueNames = key2.GetValueNames
                        Dim str5 As String
                        For Each str5 In valueNames
                            Try
                                If ((str5 & " >> " & key2.GetValue(str5).ToString) = str) Then
                                    key2.DeleteValue(str5)
                                    key2.Flush()
                                    Me.checkedListBox.Items.Remove(str)
                                    '   Me.checkedListBox.Refresh()
                                    'Me.TmbDelete_Click(sender, e)
                                End If
                            Catch ex As Exception
                                Beep()
                                MessageBox.Show(ex.Message, "ERROR!")
                            End Try
                        Next
                    Catch ex As Exception
                        Beep()
                        MessageBox.Show(ex.Message, "ERROR!")
                    End Try
                    Try
                        key2 = localMachine.OpenSubKey(name, True)
                        valueNames = key2.GetValueNames
                        Dim str5 As String
                        For Each str5 In valueNames
                            Try
                                If ((str5 & " >> " & key2.GetValue(str5).ToString) = str) Then
                                    key2.DeleteValue(str5)
                                    key2.Flush()
                                    Me.checkedListBox.Items.Remove(str)
                                    '    Me.checkedListBox.Refresh()
                                    ' Me.TmbDelete_Click(sender, e)
                                End If
                            Catch ex As Exception
                                Beep()
                                MessageBox.Show(ex.Message, "ERROR!")
                            End Try
                        Next
                    Catch ex As Exception
                        Beep()
                        MessageBox.Show(ex.Message, "ERROR!")
                    End Try
                    '   Me.checkedListBox.Items.Clear()
                    '  Me.HKLMRegistry1()
                    MyBase.Update()
                    ' ElseIf (Me.ComboReg.SelectedItem.ToString = "HKCU Run") Then
                    Dim strHKCU1 As String
                    Dim strHKCU2 As String
                    Dim key4 As RegistryKey
                    Dim currentUser As RegistryKey = Registry.CurrentUser
                    strHKCU1 = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
                    strHKCU2 = "Software\Microsoft\Windows\CurrentVersion\Runonce"
                    Try
                        key4 = currentUser.OpenSubKey(strHKCU1, True)
                        valueNames = key4.GetValueNames
                        Dim str5 As String
                        For Each str5 In valueNames
                            Try
                                If ((str5 & " >> " & key4.GetValue(str5).ToString) = str) Then
                                    key4.DeleteValue(str5)
                                    key4.Flush()
                                    Me.checkedListBox.Items.Remove(str)
                                    '   Me.checkedListBox.Refresh()
                                    ' Me.TmbDelete_Click(sender, e)
                                End If
                            Catch ex As Exception
                                Beep()
                                MessageBox.Show(ex.Message, "ERROR!")
                            End Try
                        Next
                    Catch ex As Exception
                        Beep()
                        MessageBox.Show(ex.Message, "ERROR!")
                    End Try
                    Try
                        key4 = currentUser.OpenSubKey(strHKCU2, True)
                        valueNames = key4.GetValueNames
                        Dim str5 As String
                        For Each str5 In valueNames
                            Try
                                If ((str5 & " >> " & key4.GetValue(str5).ToString) = str) Then
                                    key4.DeleteValue(str5)
                                    key4.Flush()
                                    Me.checkedListBox.Items.Remove(str)
                                    '     Me.checkedListBox.Refresh()
                                    ' Me.TmbDelete_Click(sender, e)
                                End If
                            Catch ex As Exception
                                Beep()
                                MessageBox.Show(ex.Message, "ERROR!")
                            End Try
                        Next
                    Catch ex As Exception
                        Beep()
                        MessageBox.Show(ex.Message, "ERROR!")
                    End Try
                    '   Me.checkedListBox.Items.Clear()
                    '  Me.HKLMRegistry1()
                    ' MyBase.Update()
                    ' ElseIf (Me.ComboReg.SelectedItem.ToString = "HKU Run") Then
                    Dim users As RegistryKey = Registry.Users
                    Dim strHKU As String
                    strHKU = ".DEFAULT\SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
                    Try
                        Dim key6 As RegistryKey = users.OpenSubKey(strHKU, True)
                        valueNames = key6.GetValueNames
                        Dim str5 As String
                        For Each str5 In valueNames
                            Try
                                If ((str5 & " >> " & key6.GetValue(str5).ToString) = str) Then
                                    key6.DeleteValue(str5)
                                    key6.Flush()
                                    Me.checkedListBox.Items.Remove(str)
                                    '   Me.checkedListBox.Refresh()
                                    '  Me.TmbDelete_Click(sender, e)
                                End If
                            Catch ex As Exception
                                Beep()
                                MessageBox.Show(ex.Message, "ERROR!")
                            End Try
                        Next
                    Catch ex As Exception
                        Beep()
                        MessageBox.Show(ex.Message, "ERROR!")
                    End Try
                    ' Me.checkedListBox.Items.Clear()
                    '  Me.HKLMRegistry1()
                    '  MyBase.Update()
                    'End If

                    Me.checkedListBox.Items.Clear()
                    MyBase.Update()
                    Me.HKLMRegistry1()
                    MyBase.Update()
                    Me.HKCURegistry1()
                    MyBase.Update()
                    Me.HKURegistry1()
                    MyBase.Update()
                    lblStartupNo.Text = "Number of Items: " & checkedListBox.Items.Count
                Next
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub CheckedListBox_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Try
            If e.NewValue = CheckState.Checked Then
                For i As Integer = 0 To Me.checkedListBox.Items.Count - 1 Step 1
                    If i <> e.Index Then
                        Me.checkedListBox.SetItemChecked(i, False)
                    End If
                Next i
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

#End Region

#Region "GCleaner"

    Private Sub btnScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        Me.lvwTemps.Items.Clear()
        Me.btnClean.Enabled = False
        Me.btnScan.Enabled = False
        Me.lblResults.Text = String.Empty

        Dim t As New Thread(AddressOf Initiate)
        t.Start()
    End Sub
    Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
        MessageBox.Show("Cleaning isn't done yet! I'm not focusing on cleaning until I get all the directories done!")

        Me.progressScanning.Style = ProgressBarStyle.Blocks
        Me.progressScanning.Value = 0

        Me.progressScanning.Maximum = Me.clean.FilesToDelete.Count

        For Each f In Me.clean.FilesToDelete
            Dim fi As New FileInfo(f)
            progressScanning.PerformStep()
        Next
    End Sub

    Private Sub Initiate()
        Me.progressScanning.InvokeThreadSafeMethod(Sub() Me.progressScanning.Style = ProgressBarStyle.Marquee)
        clean.Clear()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''' Internet Explorer ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(0, 0, Me.tvwBrowsers) Then
            If Directory.Exists(InternetExplorerCookies) Then
                Dim di As New DirectoryInfoA(InternetExplorerCookies, "Internet Explorer - Cookies", 3, "*.*", True)
                clean.Add(di)
            End If
            If Directory.Exists(InternetExplorerCookiesDomStore) Then
                Dim di As New DirectoryInfoA(InternetExplorerCookiesDomStore, "Internet Explorer - Cookies (DOM Store)", 3, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(0, 1, Me.tvwBrowsers) Then
            If Directory.Exists(InternetExplorerTemps) Then
                Dim di As New DirectoryInfoA(InternetExplorerTemps, "Internet Explorer - Temporary Interent Files", 3, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(0, 2, Me.tvwBrowsers) Then
            If Directory.Exists(InternetExplorerHistory) Then
                Dim di As New DirectoryInfoA(InternetExplorerHistory, "Internet Explorer - History", 3, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(0, 3, Me.tvwBrowsers) Then
            Dim ri As New RegistryInfoA("hkcu", InternetExplorerRecentlyTypedUrls, False, "Internet Explorer - Recently Typed URLs", 3)
            clean.Add(ri)
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Chrome '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(1, 0, Me.tvwBrowsers) Then
            If Directory.Exists(GoogleChromeCookiesLocalStorage) Then
                Dim di As New DirectoryInfoA(GoogleChromeCookiesLocalStorage, "Google Chrome - Cookies (Local Storage)", 1, "*.*", False)
                clean.Add(di)
            End If
            If Directory.Exists(GoogleChromeCookiesDBs) Then
                Dim di As New DirectoryInfoA(GoogleChromeCookiesDBs, "Google Chrome - Cookies (DB)", 1, "*.*", True)
                clean.Add(di)
            End If
            If File.Exists(GoogleChromeCookies) Then
                Dim fi As New FileInfoA(GoogleChromeCookies, "Google Chrome - Cookies", 1, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(1, 1, Me.tvwBrowsers) Then
            If Directory.Exists(GoogleChromeCache) Then
                Dim di As New DirectoryInfoA(GoogleChromeCache, "Google Chrome - Cache", 1, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(1, 2, Me.tvwBrowsers) Then
            If Directory.Exists(GoogleChromeInternetHistory) Then
                Dim di As New DirectoryInfoA(GoogleChromeInternetHistory, "Google Chrome - Internet History", 1, "*History*", False)
                clean.Add(di)
            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Firefox ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(2, 0, Me.tvwBrowsers) Then
            If File.Exists(MozillaFireFoxCookies) Then
                Dim fi As New FileInfoA(MozillaFireFoxCookies, "Mozilla Firefox - Cookies", 2, "*.*")
                clean.Add(fi)
            End If
            If File.Exists(MozillaFireFoxCookiesWebAppsStore) Then
                Dim fi As New FileInfoA(MozillaFireFoxCookiesWebAppsStore, "Mozilla Firefox - Cookies (Web Apps Store)", 2, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(2, 1, Me.tvwBrowsers) Then
            If File.Exists(MozillaFireFoxDownloads) Then
                Dim fi As New FileInfoA(MozillaFireFoxDownloads, "Mozilla Firefox - Download History", 2, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(2, 2, Me.tvwBrowsers) Then
            If File.Exists(MozillaFireFoxFormHistory) Then
                Dim fi As New FileInfoA(MozillaFireFoxFormHistory, "Mozilla Firefox - Form History", 2, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(2, 3, Me.tvwBrowsers) Then
            If Directory.Exists(MozillaFireFoxCache) Then
                Dim di As New DirectoryInfoA(MozillaFireFoxCache, "Mozilla Firefox - Cache", 2, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(2, 4, Me.tvwBrowsers) Then
            If File.Exists(MozillaFirefoxSessionStore) Then
                Dim fi As New FileInfoA(MozillaFirefoxSessionStore, "Mozilla Firefox - Session Store", 2, "*.*")
                clean.Add(fi)
            End If
            If File.Exists(MozillaFirefoxSessionStoreBackup) Then
                Dim fi As New FileInfoA(MozillaFirefoxSessionStoreBackup, "Mozilla Firefox - Session Store (Backup)", 2, "*.*")
                clean.Add(fi)
            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Safari '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(3, 0, Me.tvwBrowsers) Then
            If File.Exists(SafariCache) Then
                Dim fi As New FileInfoA(SafariCache, "Safari - Cache", 4, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(3, 1, Me.tvwBrowsers) Then
            If Directory.Exists(SafariHistory) Then
                Dim di As New DirectoryInfoA(SafariHistory, "Safari - History", 4, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(3, 2, Me.tvwBrowsers) Then
            If Directory.Exists(SafariWebpagePreviews) Then
                Dim di As New DirectoryInfoA(SafariWebpagePreviews, "Safari - Webpage Previews", 4, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(3, 3, Me.tvwBrowsers) Then
            If File.Exists(SafariHistoryDownloadsPlist) Then
                Dim fi As New DirectoryInfoA(SafariHistoryDownloadsPlist, "Safari - Download History", 4, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(3, 4, Me.tvwBrowsers) Then
            If File.Exists(SafariHistoryLastSessionPlist) Then
                Dim fi As New DirectoryInfoA(SafariHistoryLastSessionPlist, "Safari - Last Session", 4, "*.*")
                clean.Add(fi)
            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Opera ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(4, 0, Me.tvwBrowsers) Then
            If Directory.Exists(OperaCache) Then
                Dim di As New DirectoryInfoA(OperaCache, "Opera - Cache", 5, "*.*", True)
                clean.Add(di)
            End If
            If Directory.Exists(OperaOPCache) Then
                Dim di As New DirectoryInfoA(OperaOPCache, "Opera - Cache (OP)", 5, "*.*", True)
                clean.Add(di)
            End If
            If Directory.Exists(OperaIconCache) Then
                Dim di As New DirectoryInfoA(OperaIconCache, "Opera - Cache (Icons)", 5, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(4, 1, Me.tvwBrowsers) Then
            If Directory.Exists(OperaInternetHistory_1) Then
                Dim di As New DirectoryInfoA(OperaInternetHistory_1, "Opera - Internet History (1)", 5, "*.*", True)
                clean.Add(di)
            End If
            If File.Exists(OperaInternetHistory_2) Then
                Dim fi As New FileInfoA(OperaInternetHistory_2, "Opera - Internet History (2)", 5, "*.*")
                clean.Add(fi)
            End If
            If File.Exists(OperaInternetHistory_3) Then
                Dim fi As New FileInfoA(OperaInternetHistory_3, "Opera - Internet History (3)", 5, "*.*")
                clean.Add(fi)
            End If
            If File.Exists(OperaInternetHistory_4) Then
                Dim fi As New FileInfoA(OperaInternetHistory_4, "Opera - Internet History (4)", 5, "*.*")
                clean.Add(fi)
            End If
            If File.Exists(OperaInternetHistory_5) Then
                Dim fi As New FileInfoA(OperaInternetHistory_5, "Opera - Internet History (5)", 5, "*.*")
                clean.Add(fi)
            End If
            If File.Exists(OperaInternetHistory_6) Then
                Dim fi As New FileInfoA(OperaInternetHistory_6, "Opera - Internet History (6)", 5, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(4, 2, Me.tvwBrowsers) Then
            If File.Exists(OperaCookies) Then
                Dim fi As New FileInfoA(OperaCookies, "Opera - Cookies", 5, "*.*")
                clean.Add(fi)
            End If
        End If
        If isTreeNodeChecked(4, 3, Me.tvwBrowsers) Then
            If Directory.Exists(OperaWebsiteIcon) Then
                Dim di As New DirectoryInfoA(OperaWebsiteIcon, "Opera - Website Icons", 5, "*.*", False)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(4, 4, Me.tvwBrowsers) Then
            If Directory.Exists(OperaCacheTempDownloads) Then
                Dim di As New DirectoryInfoA(OperaCacheTempDownloads, "Opera - Download History", 5, "*.*", True)
                clean.Add(di)
            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Explorer '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(0, 0, Me.tvwUserSystem) Then
            If Directory.Exists(WindowsExplorerRecent) Then
                Dim di As New DirectoryInfoA(WindowsExplorerRecent, "Windows Explorer - Recent Documents", 6, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(0, 1, Me.tvwUserSystem) Then
            If Directory.Exists(WindowsExplorerThumbnailCache) Then
                Dim di As New DirectoryInfoA(WindowsExplorerThumbnailCache, "Windows Explorer - Thumbnail Cache", 6, "*.*", True)
                clean.Add(di)
            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' System '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(1, 0, Me.tvwUserSystem) Then
            If Directory.Exists(WindowsTempFiles) Then
                Dim di As New DirectoryInfoA(WindowsTempFiles, "System - Windows Temp Files", 7, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(1, 1, Me.tvwUserSystem) Then
            If Directory.Exists(UserTemps) Then
                Dim di As New DirectoryInfoA(UserTemps, "System - User Temp Files", 7, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(1, 2, Me.tvwUserSystem) Then
            If Directory.Exists(MiniDumps) Then
                Dim di As New DirectoryInfoA(MiniDumps, "System - Memory Dumps", 7, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(1, 3, Me.tvwUserSystem) Then
            If Directory.Exists(ChkDskFileFragments) Then
                Dim di As New DirectoryInfoA(ChkDskFileFragments, "System - ChkDsk File Fragments", 7, "*.chk", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(1, 4, Me.tvwUserSystem) Then
            If Directory.Exists(WindowsLogFiles) Then
                Dim di As New DirectoryInfoA(WindowsLogFiles, "System - Windows Log Files", 7, "*.log", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(1, 5, Me.tvwUserSystem) Then
            If Directory.Exists(WindowsErrorReporting_1) Then
                Dim di As New DirectoryInfoA(WindowsErrorReporting_1, "System - Windows Error Reporting - 1", 7, "*.log", True)
                clean.Add(di)
            End If
            If Directory.Exists(WindowsErrorReporting_2) Then
                Dim di As New DirectoryInfoA(WindowsErrorReporting_2, "System - Windows Error Reporting - 2", 7, "*.log", True)
                clean.Add(di)
            End If
            If Directory.Exists(WindowsErrorReporting_3) Then
                Dim di As New DirectoryInfoA(WindowsErrorReporting_3, "System - Windows Error Reporting - 3", 7, "*.log", True)
                clean.Add(di)
            End If
            If Directory.Exists(WindowsErrorReporting_4) Then
                Dim di As New DirectoryInfoA(WindowsErrorReporting_4, "System - Windows Error Reporting - 4", 7, "*.log", True)
                clean.Add(di)
            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''' Advanced '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If isTreeNodeChecked(2, 0, Me.tvwUserSystem) Then
            If Directory.Exists(PrefetchData) Then
                Dim di As New DirectoryInfoA(PrefetchData, "Advanced - Prefetch Data", 8, "*.*", True)
                clean.Add(di)
            End If
        End If
        If isTreeNodeChecked(2, 1, Me.tvwUserSystem) Then
            If Directory.Exists(IISLogs_1) Then
                Dim di As New DirectoryInfoA(IISLogs_1, "Advanced - IIS Logs", 8, "*.log", True)
                clean.Add(di)
                Dim di2 As New DirectoryInfoA(IISLogs_1, "Advanced - IIS Logs Files - ETL", 8, "*.etl", True)
                clean.Add(di2)
            End If
            If Directory.Exists(IISLogs_2) Then
                Dim di As New DirectoryInfoA(IISLogs_2, "Advanced - IIS Logs Files - 2", 8, "*.log", True)
                clean.Add(di)
                Dim di2 As New DirectoryInfoA(IISLogs_2, "Advanced - IIS Logs Files - 2 - ETL", 8, "*.etl", True)
                clean.Add(di2)
            End If
        End If


        clean.Scan(lvwTemps)

        Me.progressScanning.InvokeThreadSafeMethod(Sub() Me.progressScanning.Style = ProgressBarStyle.Blocks)

        Me.btnScan.InvokeThreadSafeMethod(Sub() Me.btnScan.Enabled = True)
        Me.btnClean.InvokeThreadSafeMethod(Sub() Me.btnClean.Enabled = True)

        Me.progressScanning.InvokeThreadSafeMethod(Sub() Me.progressScanning.PerformStep())

        Me.lblResults.InvokeThreadSafeMethod(Sub() Me.lblResults.Text = "Initial Scan Size      " & clean.DisplaySize & Environment.NewLine & "Initial File Count       " & CStr(clean.FileCount))

    End Sub

    Private Function isTreeNodeChecked(ByVal indexParent As Integer, ByVal indexChild As Integer, ByVal tvw As TreeView) As Boolean
        For Each tn As TreeNode In tvw.GetThreadSafeProperty(Function() tvw.Nodes)
            If tn.Checked And tn.Index = indexParent Then
                For Each tn2 As TreeNode In tn.Nodes
                    If tn2.Index = indexChild Then
                        If tn2.Checked Then
                            Return True
                        Else
                            Return False
                        End If
                    End If
                Next
            End If
        Next
    End Function

    Private Sub tvwBrowsers_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        If e.Node.Checked Then
            For Each n As TreeNode In e.Node.Nodes
                n.Checked = True
            Next
        Else
            If hasTreeNodesExpanded Then
                For Each n As TreeNode In e.Node.Nodes
                    n.Checked = False
                Next
            End If
        End If
    End Sub

#End Region

    Private Sub btnGCLen_Click(sender As Object, e As EventArgs) Handles btnGCLen.Click
        tabctrl_1.SelectedTab = tabGCleaner
    End Sub


End Class

Public Class clsListviewSorter ' Implements a comparer Implements IComparer  
    Implements IComparer

    Private m_ColumnNumber As Integer
    Private m_SortOrder As SortOrder
    Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
        m_ColumnNumber = column_number
        m_SortOrder = sort_order
    End Sub
    ' Compare the items in the appropriate column  
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
        Dim item_y As ListViewItem = DirectCast(y, ListViewItem)
        ' Get the sub-item values.  
        Dim string_x As String
        If item_x.SubItems.Count <= m_ColumnNumber Then
            string_x = ""
        Else
            string_x = item_x.SubItems(m_ColumnNumber).Text
        End If
        Dim string_y As String
        If item_y.SubItems.Count <= m_ColumnNumber Then
            string_y = ""
        Else
            string_y = item_y.SubItems(m_ColumnNumber).Text
        End If
        ' Compare them.  
        If m_SortOrder = SortOrder.Ascending Then
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_x).CompareTo(Val(string_y))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
            Else
                Return String.Compare(string_x, string_y)
            End If
        Else
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_y).CompareTo(Val(string_x))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
            Else
                Return String.Compare(string_y, string_x)
            End If
        End If
    End Function
End Class