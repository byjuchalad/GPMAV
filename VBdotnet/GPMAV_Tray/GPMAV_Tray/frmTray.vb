

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

'References: https://stackoverflow.com/questions/358700/how-to-install-a-windows-service-programmatically-in-c
'            http://lea2mail.wordpress.com/2010/01/05/change-startup-type-and-status-of-the-windows-service-with-vb-net/

Imports Microsoft.Win32
Imports System.ServiceProcess
Imports System.Management

Public Class frmTray

#Region "Declarations"
    Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
    Dim appp As String = regKey.GetValue("Install_Dir")
    'regKey.Close()
    Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"

    Public Shared Sub InstallService(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\Autoupdatelog.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Install(Nothing)
            installer.Commit(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub


    Public Shared Sub UninstallService(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\Autoupdatelog.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Uninstall(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Public Shared Sub InstallService1(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\GPMRTScan.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Install(Nothing)
            installer.Commit(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub


    Public Shared Sub UninstallService1(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\GPMRTScan.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Uninstall(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub


#End Region


#Region "Tray"

    Private Sub OpenGPMAntivirusGUIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenGPMAntivirusGUIToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAVGUI.exe") Then
                Shell(AppPath & "\GPMAVGUI.exe", AppWinStyle.NormalFocus)
            Else
                Process.Start(appp & "\GPMAVGUI.exe")
            End If
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub OpenGPMAntivirusScannerGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGPMAntivirusScannerGUIToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAV-SCANGUI.exe") Then
                Shell(AppPath & "\GPMAV-SCANGUI.exe", AppWinStyle.NormalFocus)
            Else
                Process.Start(appp & "\GPMAV-SCANGUI.exe")
            End If
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("GPM Antivirus 2014" & vbCrLf & "Version 14.6" & vbCrLf & "Created by GPM", MsgBoxStyle.Information, "About: GPM Antivirus")
    End Sub


    Private Sub UpdateGUIVisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateGUIVisibleToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAV-UPDATE-GUI.exe") Then

                Shell(AppPath & "\GPMAV-UPDATE-GUI.exe", AppWinStyle.NormalFocus)
            Else
                Process.Start(appp & "\GPMAV-UPDATE-GUI.exe")
            End If
        Catch ex2 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub UpdateGUIInvisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateGUIInvisibleToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\gpmavupdate.exe") Then
                Dim p As New ProcessStartInfo(AppPath & "\gpmavupdate.exe", "--stdout --log=" & AppPath & "\logs\Autoupdatelog.log")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)
            Else
                Dim p As New ProcessStartInfo(appp & "\gpmavupdate.exe", "--stdout --log=" & appp & "\logs\Autoupdatelog.log")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)
            End If

            systray1.BalloonTipIcon = ToolTipIcon.Info
            systray1.BalloonTipTitle = "GPM Antivirus Tray Message"
            systray1.BalloonTipText = "GPM Antivirus Hidden Update started."
            systray1.ShowBalloonTip(3000)
        Catch ex3 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub


    Private Sub RunRealTimeForDriveCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTPON.Click
        'Try
        'If My.Computer.FileSystem.FileExists(AppPath & "\GPMClamAVRT.exe") Then
        'Dim p As New ProcessStartInfo(AppPath & "\GPMClamAVRT.exe")
        'p.WindowStyle = ProcessWindowStyle.Hidden
        ' p.CreateNoWindow = True
        ' Process.Start(p)
        ' Else

        'Dim p As New ProcessStartInfo(appp & "\GPMClamAVRT.exe")
        ' p.WindowStyle = ProcessWindowStyle.Hidden
        'p.CreateNoWindow = True
        ' Process.Start(p)
        'End If


        Try
            Dim updService As New ServiceController("GPMClamAVRTSvc")
            Dim obj As ManagementObject
            Dim inParams, outParams As ManagementBaseObject
            Dim Result As Integer
            Dim sc As ServiceController

            If My.Computer.FileSystem.FileExists(AppPath & "\GPMClamAVRTSvc.exe") Then
                'Install the RT Service
                InstallService1(AppPath & "\GPMClamAVRTSvc.exe")
            Else 'condition no 2
                'Install the Update Service
                InstallService1(appp & "\GPMClamAVRTSvc.exe")

            End If

            'Start the Service
            If Not updService Is Nothing Then
                If Not updService.Status = ServiceControllerStatus.Running Then
                    updService.Start()
                    updService.WaitForStatus(ServiceControllerStatus.Running)
                End If
            End If

            'Change the Service Mode
            obj = New ManagementObject("\\.\root\cimv2:Win32_Service.Name='GPMClamAVRTSvc'")

            'Change the Start Mode to Manual         
            If obj("StartMode").ToString = "Manual" Then
                'Get an input parameters object for this method  
                inParams = obj.GetMethodParameters("ChangeStartMode")
                inParams("StartMode") = "Automatic"

                'do it!               
                outParams = obj.InvokeMethod("ChangeStartMode", inParams, Nothing)
                Result = Convert.ToInt32(outParams("returnValue"))

                If Result <> 0 Then
                    Throw New Exception("ChangeStartMode method error code " & Result)
                End If
            End If

            systray1.BalloonTipIcon = ToolTipIcon.Info
            systray1.BalloonTipTitle = "GPM Antivirus Tray Message"
            systray1.BalloonTipText = "GPM Antivirus Real Time Scanner Service Installed and Started!"
            systray1.ShowBalloonTip(3000)

        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try

    End Sub


    Private Sub StopRealTimeForDriveCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTPOFF.Click
        ' Kill process
        ' Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("GPMClamAVRT")

        ' For Each p As Process In pProcess
        'p.Kill()
        'Next

        'systray1.BalloonTipIcon = ToolTipIcon.Info
        'systray1.BalloonTipTitle = "GPM Antivirus Tray Message"
        'systray1.BalloonTipText = "GPM Antivirus Real Time Protection Deactivated!"
        ' systray1.ShowBalloonTip(3000)

        Try

            Dim updService As New ServiceController("GPMClamAVRTSvc")
            'Start the Service
            If Not updService Is Nothing Then
                If Not updService.Status = ServiceControllerStatus.Running Then
                    updService.Start()
                    updService.WaitForStatus(ServiceControllerStatus.Running)
                End If
            End If


            'Change the Service Mode
            Dim obj As ManagementObject
            Dim inParams, outParams As ManagementBaseObject
            Dim Result As Integer
            Dim sc As ServiceController

            obj = New ManagementObject("\\.\root\cimv2:Win32_Service.Name='GPMClamAVRTSvc'")

            'Change the Start Mode to Manual         
            If obj("StartMode").ToString = "Automatic" Then
                'Get an input parameters object for this method  
                inParams = obj.GetMethodParameters("ChangeStartMode")
                inParams("StartMode") = "Disabled"

                'do it!               
                outParams = obj.InvokeMethod("ChangeStartMode", inParams, Nothing)
                Result = Convert.ToInt32(outParams("returnValue"))

                If Result <> 0 Then
                    Throw New Exception("ChangeStartMode method error code " & Result)
                End If
            End If
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMClamAVRTSvc.exe") Then
                'Install the Update Service
                UninstallService1(AppPath & "\GPMClamAVRTSvc.exe")
            Else
                UninstallService1(appp & "\GPMClamAVRTSvc.exe")
            End If

            systray1.BalloonTipIcon = ToolTipIcon.Info
            systray1.BalloonTipTitle = "GPM Antivirus Tray Message"
            systray1.BalloonTipText = "GPM Antivirus Real Time Scanner Service Stopped and Uninstalled!"
            systray1.ShowBalloonTip(3000)

        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
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

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Try
            If My.Computer.FileSystem.FileExists(AppPath & "\help.pdf") Then
                Process.Start(AppPath & "\Help.pdf")
            Else
                Process.Start(appp & "\help.pdf")
            End If
        Catch ex6 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & "File not found!", vbOKOnly + vbCritical, "ERROR!")
        End Try
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
    Private Sub ShowReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowReportsToolStripMenuItem.Click
        dlgLogs.ShowDialog()
    End Sub


    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem.Click
        Try
            Dim updService As New ServiceController("GPMAVAuSvc")
            Dim obj As ManagementObject
            Dim inParams, outParams As ManagementBaseObject
            Dim Result As Integer
            Dim sc As ServiceController

            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAVAuSvc.exe") Then
                'Install the Update Service
                InstallService(AppPath & "\GPMAVAuSvc.exe")
            Else 'condition no 2
                'Install the Update Service
                InstallService(appp & "\GPMAVAuSvc.exe")

            End If

            'Start the Service
            If Not updService Is Nothing Then
                If Not updService.Status = ServiceControllerStatus.Running Then
                    updService.Start()
                    updService.WaitForStatus(ServiceControllerStatus.Running)
                End If
            End If

            'Change the Service Mode
            obj = New ManagementObject("\\.\root\cimv2:Win32_Service.Name='GPMAVAuSvc'")

            'Change the Start Mode to Manual         
            If obj("StartMode").ToString = "Manual" Then
                'Get an input parameters object for this method  
                inParams = obj.GetMethodParameters("ChangeStartMode")
                inParams("StartMode") = "Automatic"

                'do it!               
                outParams = obj.InvokeMethod("ChangeStartMode", inParams, Nothing)
                Result = Convert.ToInt32(outParams("returnValue"))

                If Result <> 0 Then
                    Throw New Exception("ChangeStartMode method error code " & Result)
                End If
            End If

            systray1.BalloonTipIcon = ToolTipIcon.Info
            systray1.BalloonTipTitle = "GPM Antivirus Tray Message"
            systray1.BalloonTipText = "GPM Antivirus Update Service Installed and Started! Will update every 1 hr."
            systray1.ShowBalloonTip(3000)

        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub OffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OffToolStripMenuItem.Click
        Try

            Dim updService As New ServiceController("GPMAVAuSvc")
            'Start the Service
            If Not updService Is Nothing Then
                If Not updService.Status = ServiceControllerStatus.Running Then
                    updService.Start()
                    updService.WaitForStatus(ServiceControllerStatus.Running)
                End If
            End If


            'Change the Service Mode
            Dim obj As ManagementObject
            Dim inParams, outParams As ManagementBaseObject
            Dim Result As Integer
            Dim sc As ServiceController

            obj = New ManagementObject("\\.\root\cimv2:Win32_Service.Name='GPMAVAuSvc'")

            'Change the Start Mode to Manual         
            If obj("StartMode").ToString = "Automatic" Then
                'Get an input parameters object for this method  
                inParams = obj.GetMethodParameters("ChangeStartMode")
                inParams("StartMode") = "Disabled"

                'do it!               
                outParams = obj.InvokeMethod("ChangeStartMode", inParams, Nothing)
                Result = Convert.ToInt32(outParams("returnValue"))

                If Result <> 0 Then
                    Throw New Exception("ChangeStartMode method error code " & Result)
                End If
            End If
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAVAuSvc.exe") Then
                'Install the Update Service
                UninstallService(AppPath & "\GPMAVAuSvc.exe")
            Else
                UninstallService(appp & "\GPMAVAuSvc.exe")
            End If

            systray1.BalloonTipIcon = ToolTipIcon.Info
            systray1.BalloonTipTitle = "GPM Antivirus Tray Message"
            systray1.BalloonTipText = "GPM Antivirus Update Service Stopped and Uninstalled! Automatic Update Disabled."
            systray1.ShowBalloonTip(3000)

        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub
#End Region




End Class
