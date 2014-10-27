
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

Module modMain

    Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
    Dim appp As String = regKey.GetValue("Install_Dir")
    'regKey.Close()
    Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"


    Public Sub InstallService(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\Autoupdatelog.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Install(Nothing)
            installer.Commit(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!: GPMAVSvcInst")
        End Try
    End Sub


    Public Sub UninstallService(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\Autoupdatelog.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Uninstall(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!: GPMAVSvcInst")
        End Try
    End Sub

    Public Sub InstallService1(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\GPMRTScan.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Install(Nothing)
            installer.Commit(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!: GPMAVSvcInst")
        End Try
    End Sub


    Public Sub UninstallService1(ByVal exeFilename As String)
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strHomeGPMDrv & "\Logs\GPMRTScan.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Uninstall(Nothing)
        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!: GPMAVSvcInst")
        End Try
    End Sub



    Sub Main()

        Try
            'Declare Services
            Dim updService1 As New ServiceController("GPMAVQuaSvc")
            Dim updService As New ServiceController("GPMAVAuSvc")
            Dim obj As ManagementObject
            Dim inParams, outParams As ManagementBaseObject
            Dim Result As Integer
            Dim obj1 As ManagementObject
            Dim inParams1, outParams1 As ManagementBaseObject
            Dim Result1 As Integer
            Dim sc As ServiceController
            'Installation of Services
            If My.Computer.FileSystem.FileExists(AppPath & "\GPMClamAVRTSvc.exe") Then
                'Install the RT Service
                InstallService1(AppPath & "\GPMClamAVRTSvc.exe")

            Else 'condition no 2
                'Install the Update Service
                InstallService1(appp & "\GPMClamAVRTSvc.exe")

            End If

            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAVAuSvc.exe") Then
                'Install the Update Service
                InstallService(AppPath & "\GPMAVAuSvc.exe")
            Else 'condition no 2
                'Install the Update Service
                InstallService(appp & "\GPMAVAuSvc.exe")

            End If

            If My.Computer.FileSystem.FileExists(AppPath & "\GPMAVQuaSvc.exe") Then
                'Install the Update Service
                InstallService1(AppPath & "\GPMAVQuaSvc.exe")
            Else 'condition no 2
                'Install the Update Service
                InstallService1(appp & "\GPMAVQuaSvc.exe")
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

            'Start Services
            If Not updService1 Is Nothing Then
                If Not updService1.Status = ServiceControllerStatus.Running Then
                    updService1.Start()
                    updService1.WaitForStatus(ServiceControllerStatus.Running)
                End If
            End If

            'Change the Service Mode
            obj1 = New ManagementObject("\\.\root\cimv2:Win32_Service.Name='GPMAVQuaSvc'")

            'Change the Start Mode to Manual         
            If obj1("StartMode").ToString = "Manual" Then
                'Get an input parameters object for this method  
                inParams1 = obj1.GetMethodParameters("ChangeStartMode")
                inParams1("StartMode") = "Automatic"

                'do it!               
                outParams1 = obj1.InvokeMethod("ChangeStartMode", inParams1, Nothing)
                Result1 = Convert.ToInt32(outParams1("returnValue"))

                If Result1 <> 0 Then
                    Throw New Exception("ChangeStartMode method error code " & Result1)
                End If
            End If



        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!: GPMAVSvcInst")
        End Try


    End Sub
End Module
