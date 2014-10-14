
'A component of GPM Antivirus.

'GPM Antivirus is free software: you can redistribute it and/or modify it under the
'terms of the GNU General Public License as published by the Free Software
'Foundation, either version 3 of the License, or (at your option) any later
'version.

'GPM Antivirus is distributed in the hope that it will be useful, but WITHOUT ANY
'WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR
'A PARTICULAR PURPOSE. See the GNU General Public License for more details.

'A copy of the GNU General Public License can be found at
'<http://www.gnu.org/licenses/>.

Imports System
Imports System.ServiceProcess
Imports System.Diagnostics
Imports System.Timers
Imports Microsoft.Win32

Public Class Service : Inherits ServiceBase

    Protected tmrMain As Timer

#Region "Declarations"
    ' Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
    Dim appp As String = regKey.GetValue("Install_Dir")
    'regKey.Close()
    Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
#End Region


    Public Sub New()
        MyBase.New()
        CanPauseAndContinue = False
        ServiceName = "GPMAVAuSvc"
        tmrMain = New Timer
    End Sub

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            EventLog.WriteEntry("GPMAVAuSvc service started")
            AddHandler tmrMain.Elapsed, AddressOf tmrMain_Elapsed
            AddHandler tmrMain.Disposed, AddressOf tmrMain_Disposed
            tmrMain.Interval = 3600000
            ' Start raising the Elapsed event.
            tmrMain.Enabled = True
        Catch ex As Exception
            EventLog.WriteEntry("GPMAVAuSvc Error: " & ex.Message)
        End Try
    End Sub

    Protected Sub tmrMain_Elapsed(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Try
            EventLog.WriteEntry("GPMAVAuSvc: Updating ClamAV Virus Database...")
            ' Stop raising the Elapsed event.
            'Beep()
            ' tmrMain.Stop()
            ' Force garbage collection to make sure that the garbage collector
            ' reclaims the memory that is associated with the tmrMain Timer object.
            GC.Collect()
            ' Start to raise the Elapsed event again.
            ' tmrMain.Start()
            If My.Computer.FileSystem.FileExists(strHomeGPMDrv & "\gpmavupdate.exe") Then
                Dim p As New ProcessStartInfo(strHomeGPMDrv & "\gpmavupdate.exe", "--stdout --log=" & strHomeGPMDrv & "\logs\Autoupdatelog.log")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)
            Else
                Dim p As New ProcessStartInfo(appp & "\gpmavupdate.exe", "--stdout --log=" & appp & "\logs\Autoupdatelog.log")
                p.WindowStyle = ProcessWindowStyle.Hidden
                p.CreateNoWindow = True
                Process.Start(p)
            End If
        Catch ex As Exception
            EventLog.WriteEntry("GPMAVAuSvc Error: " & ex.Message)
        End Try
    End Sub
    Protected Sub tmrMain_Disposed(ByVal source As Object, ByVal e As EventArgs)
        Try
            EventLog.WriteEntry("GPMAVAuSvc timer disposed")
        Catch ex As Exception
            EventLog.WriteEntry("GPMAVAuSvc Error: " & ex.Message)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        Try
            ' Add code here to perform any tear-down necessary to stop your service.
            EventLog.WriteEntry("GPMAVAuSvc service stopped")
            tmrMain.Enabled = False
            tmrMain.Stop()

        Catch ex As Exception
            EventLog.WriteEntry("GPMAVAuSvc Error: " & ex.Message)
        End Try
    End Sub

End Class