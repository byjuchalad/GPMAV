

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



    Public Sub UninstallService(ByVal exeFilename As String)
        Try
            Dim strTemp As String = Environ("temp")
            Dim commandLineOptions() As String = New String() {"/LogFile=" & strTemp & "\GPMAVSvcUninst.log"}
            Dim installer As System.Configuration.Install.AssemblyInstaller = New System.Configuration.Install.AssemblyInstaller(exeFilename, commandLineOptions)
            installer.UseNewContext = True
            installer.Uninstall(Nothing)
        Catch ex1 As Exception
            Beep()
        End Try
    End Sub


    Sub Main()
        Try
            Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
            UninstallService(strHomeGPMDrv & "\GPMClamAVRTSvc.exe")
            UninstallService(strHomeGPMDrv & "\GPMAVAuSvc.exe")
            UninstallService(strHomeGPMDrv & "\GPMAVQuaSvc.exe")
        Catch ex As Exception

        End Try
    End Sub
End Module
