
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

Imports System.IO
Imports Microsoft.Win32

Public Class RTService

    Protected Overrides Sub OnStart(ByVal args() As String)

        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Try
            EventLog.WriteEntry("GPMClamAVRTSvc service started")
            Dim _watchers As Object


            Dim drives() As String = Environment.GetLogicalDrives
            For Each strDrive As String In drives
                Dim df As DriveInfo = New DriveInfo(strDrive)
                If df.IsReady = True Then

                    If Directory.Exists(df.Name) = True Then
                        _watchers = New FileSystemWatcher((drives.Length) - 1) {}

                        Dim i As Integer = 0

                        Dim _watcher As FileSystemWatcher = New FileSystemWatcher
                        _watcher.Path = strDrive
                        AddHandler _watcher.Changed, AddressOf FolderWatcherTest_Changed
                        AddHandler _watcher.Created, AddressOf FolderWatcherTest_Created
                        AddHandler _watcher.Deleted, AddressOf FolderWatcherTest_Deleted
                        'AddHandler _watcher.Renamed, AddressOf FolderWatcherTest_Renamed
                        _watchers(i) = _watcher
                        Microsoft.VisualBasic.ChrW(32)
                        _watcher.IncludeSubdirectories = True
                        _watcher.EnableRaisingEvents = True
                        i = (i + 1)


                    End If
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Try
            EventLog.WriteEntry("GPMClamAVRTSvc service stopped")
            'Get list of all running processes
            Dim proc() As Process = Process.GetProcesses
            'Loop through all processes
            For i As Integer = 0 To proc.GetUpperBound(0)
                If proc(i).ProcessName = "gpmavscan" Then
                    proc(i).Kill()
                End If
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try

    End Sub
    Public Sub ShellandWait(ByVal ProcessPath As String, ByVal ProcessArg As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.Arguments = ProcessArg
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try
    End Sub

    Public Function checkprocess(ByVal processname As String)
        Try
            'Get list of all running processes
            Dim proc() As Process = Process.GetProcesses

            'Loop through all processes
            For i As Integer = 0 To proc.GetUpperBound(0)
                If proc(i).ProcessName = processname Then
                    'kill process if name is calc
                    ' proc(i).Kill()

                    ' For Each Proc1 As Process In Process.GetProcesses
                    'processname = Proc1.ProcessName & ".exe"

                    If proc(i).ProcessName = "gpmavscan" Then
                        Return True
                    Else
                        Return False
                    End If

                    '  Next

                End If


            Next

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try
    End Function

    Dim lastRead As DateTime = DateTime.MinValue
    Private Sub FolderWatcherTest_Created(sender As Object, e As FileSystemEventArgs)
        Try
            Dim lastRead As DateTime = DateTime.MinValue

            Dim lastWriteTime As DateTime = File.GetLastWriteTime(e.FullPath)
            If (lastWriteTime <> lastRead) Then
                'TODO

                Dim regKey As RegistryKey
                Dim appp As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                appp = regKey.GetValue("Install_Dir")
                regKey.Close()


                Dim strHomeGPMDrv As String
                strHomeGPMDrv = Environ("homedrive") & "\GPMAV"

                'Dim programfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.) & "\GPMClamAV\gpmavscan.exe"
                ' Dim programfilesx86 As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\GPMClamAV\gpmavscan.exe"
                Dim commands As String = " --max-filesize=100M --database=""" & appp & "\database"" --infected --bell --no-summary --move=""" & appp & "\Quarantine""" & " --exclude=""[^\]*\.dbx$"" --exclude=""[^\]*\.tbb$"" --exclude=""[^\]*\.pst$"" --exclude=""[^\]*\.dat$"" --exclude=""[^\]*\.log$"" --exclude=""[^\]*\.evt$""  --exclude=""[^\]*\.nsf$"" --exclude=""[^\]*\.ntf$"" --exclude=""[^\]*\.chm$"" --exclude=""[^\]*\.csv$"" --exclude=""[^\]*\.doc$"" --exclude=""[^\]*\.txt$""  --tempdir=""" & appp & "\temp""" & " --log=""" & appp & "\Logs\GPMRTScan.log"" """ & e.FullPath & """"


                Dim commands1 As String = " --max-filesize=100M --database=""" & strHomeGPMDrv & "\database""  --infected --bell --no-summary --move=""" & strHomeGPMDrv & "\Quarantine"" --exclude=""[^\]*\.dbx$"" --exclude=""[^\]*\.tbb$"" --exclude=""[^\]*\.pst$""  --exclude=""[^\]*\.dat$"" --exclude=""[^\]*\.log$"" --exclude=""[^\]*\.evt$""  --exclude=""[^\]*\.nsf$"" --exclude=""[^\]*\.ntf$"" --exclude=""[^\]*\.chm$"" --exclude=""[^\]*\.csv$"" --exclude=""[^\]*\.doc$"" --exclude=""[^\]*\.txt$""  --tempdir=""" & strHomeGPMDrv & "\temp""" & " --log=""" & strHomeGPMDrv & "\Logs\GPMRTScan.log"" "" & """ & e.FullPath & """"

                If File.Exists(appp & "\gpmavscan.exe") Then
                    If e.FullPath.Contains("GPMRTScan.log") Then

                    Else


                        If checkprocess("gpmavscan") = True Then
                            Debug.WriteLine("Process Exists Waiting for it to Exit.")
                        Else

                            ShellandWait(appp & "\gpmavscan.exe", commands)

                        End If
                    End If

                ElseIf File.Exists(strHomeGPMDrv) Then

                    If e.FullPath.Contains("GPMRTScan.log") Then

                    Else


                        If checkprocess("gpmavscan") = True Then
                            Debug.WriteLine("Process Exists Waiting for it to Exit.")
                        Else

                            ShellandWait(appp & "\gpmavscan.exe", commands)

                        End If

                    End If

                    lastRead = lastWriteTime
                End If
            End If
            ' else discard the (duplicated) OnChanged event

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try

    End Sub

    Private Sub FolderWatcherTest_Changed(sender As Object, e As FileSystemEventArgs)
        Try
            Dim lastRead As DateTime = DateTime.MinValue

            Dim lastWriteTime As DateTime = File.GetLastWriteTime(e.FullPath)
            If (lastWriteTime <> lastRead) Then
                'TODO


                Dim regKey As RegistryKey
                Dim appp As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                appp = regKey.GetValue("Install_Dir")
                regKey.Close()


                Dim strHomeGPMDrv As String
                strHomeGPMDrv = Environ("homedrive") & "\GPMAV"

                'Dim programfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.) & "\GPMClamAV\gpmavscan.exe"
                ' Dim programfilesx86 As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\GPMClamAV\gpmavscan.exe"
                Dim commands As String = " --max-filesize=100M --database=""" & appp & "\database"" --infected --bell --no-summary --move=""" & appp & "\Quarantine""" & " --exclude=""[^\]*\.dbx$"" --exclude=""[^\]*\.tbb$"" --exclude=""[^\]*\.pst$"" --exclude=""[^\]*\.dat$"" --exclude=""[^\]*\.log$"" --exclude=""[^\]*\.evt$""  --exclude=""[^\]*\.nsf$"" --exclude=""[^\]*\.ntf$"" --exclude=""[^\]*\.chm$"" --exclude=""[^\]*\.csv$"" --exclude=""[^\]*\.doc$"" --exclude=""[^\]*\.txt$""  --tempdir=""" & appp & "\temp""" & " --log=""" & appp & "\Logs\GPMRTScan.log"" """ & e.FullPath & """"


                Dim commands1 As String = " --max-filesize=100M --database=""" & strHomeGPMDrv & "\database""  --infected --bell --no-summary --move=""" & strHomeGPMDrv & "\Quarantine"" --exclude=""[^\]*\.dbx$"" --exclude=""[^\]*\.tbb$"" --exclude=""[^\]*\.pst$""  --exclude=""[^\]*\.dat$"" --exclude=""[^\]*\.log$"" --exclude=""[^\]*\.evt$""  --exclude=""[^\]*\.nsf$"" --exclude=""[^\]*\.ntf$"" --exclude=""[^\]*\.chm$"" --exclude=""[^\]*\.csv$"" --exclude=""[^\]*\.doc$"" --exclude=""[^\]*\.txt$""  --tempdir=""" & strHomeGPMDrv & "\temp""" & " --log=""" & strHomeGPMDrv & "\Logs\GPMRTScan.log"" "" & """ & e.FullPath & """"


                If File.Exists(appp & "\gpmavscan.exe") Then
                    If e.FullPath.Contains("GPMRTScan.log") Then

                    Else


                        If checkprocess("gpmavscan") = True Then
                            Debug.WriteLine("Process Exists Waiting for it to Exit.")
                        Else

                            ShellandWait(appp & "\gpmavscan.exe", commands)

                        End If
                    End If

                ElseIf File.Exists(strHomeGPMDrv) Then

                    If e.FullPath.Contains("GPMRTScan.log") Then

                    Else


                        If checkprocess("gpmavscan") = True Then
                            Debug.WriteLine("Process Exists Waiting for it to Exit.")
                        Else

                            ShellandWait(appp & "\gpmavscan.exe", commands)

                        End If

                    End If

                    lastRead = lastWriteTime
                End If
            End If
            ' else discard the (duplicated) OnChanged event
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try

    End Sub

    Private Sub FolderWatcherTest_Deleted(sender As Object, e As FileSystemEventArgs)
        Try

            '  _

            Dim lastRead As DateTime = DateTime.MinValue

            Dim lastWriteTime As DateTime = File.GetLastWriteTime(e.FullPath)
            If (lastWriteTime <> lastRead) Then
                'TODO


                Dim regKey As RegistryKey
                Dim appp As String
                regKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
                appp = regKey.GetValue("Install_Dir")
                regKey.Close()


                Dim strHomeGPMDrv As String
                strHomeGPMDrv = Environ("homedrive") & "\GPMAV"

                'Dim programfiles As String = Environment.GetFolderPath(Environment.SpecialFolder.) & "\GPMClamAV\gpmavscan.exe"
                ' Dim programfilesx86 As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\GPMClamAV\gpmavscan.exe"
                Dim commands As String = " --max-filesize=100M --database=""" & appp & "\database"" --infected --bell --no-summary --move=""" & appp & "\Quarantine""" & " --exclude=""[^\]*\.dbx$"" --exclude=""[^\]*\.tbb$"" --exclude=""[^\]*\.pst$"" --exclude=""[^\]*\.dat$"" --exclude=""[^\]*\.log$"" --exclude=""[^\]*\.evt$""  --exclude=""[^\]*\.nsf$"" --exclude=""[^\]*\.ntf$"" --exclude=""[^\]*\.chm$"" --exclude=""[^\]*\.csv$"" --exclude=""[^\]*\.doc$"" --exclude=""[^\]*\.txt$""  --tempdir=""" & appp & "\temp""" & " --log=""" & appp & "\Logs\GPMRTScan.log"" """ & e.FullPath & """"


                Dim commands1 As String = " --max-filesize=100M --database=""" & strHomeGPMDrv & "\database""  --infected --bell --no-summary --move=""" & strHomeGPMDrv & "\Quarantine"" --exclude=""[^\]*\.dbx$"" --exclude=""[^\]*\.tbb$"" --exclude=""[^\]*\.pst$""  --exclude=""[^\]*\.dat$"" --exclude=""[^\]*\.log$"" --exclude=""[^\]*\.evt$""  --exclude=""[^\]*\.nsf$"" --exclude=""[^\]*\.ntf$"" --exclude=""[^\]*\.chm$"" --exclude=""[^\]*\.csv$"" --exclude=""[^\]*\.doc$"" --exclude=""[^\]*\.txt$""  --tempdir=""" & strHomeGPMDrv & "\temp""" & " --log=""" & strHomeGPMDrv & "\Logs\GPMRTScan.log"" "" & """ & e.FullPath & """"

                If File.Exists(appp & "\gpmavscan.exe") Then
                    If e.FullPath.Contains("GPMRTScan.log") Then

                    Else


                        If checkprocess("gpmavscan") = True Then
                            Debug.WriteLine("Process Exists Waiting for it to Exit.")
                        Else

                            ShellandWait(appp & "\gpmavscan.exe", commands)

                        End If
                    End If

                ElseIf File.Exists(strHomeGPMDrv) Then

                    If e.FullPath.Contains("GPMRTScan.log") Then

                    Else


                        If checkprocess("gpmavscan") = True Then
                            Debug.WriteLine("Process Exists Waiting for it to Exit.")
                        Else

                            ShellandWait(appp & "\gpmavscan.exe", commands)

                        End If

                    End If
                    lastRead = lastWriteTime
                End If
                ' else discard the (duplicated) OnChanged event
            End If

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            EventLog.WriteEntry("GPMClamAVRTSvc service err:" & ex.Message)
        End Try

    End Sub
End Class
