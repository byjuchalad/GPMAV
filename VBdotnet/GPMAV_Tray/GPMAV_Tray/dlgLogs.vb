
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

Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class dlgLogs

#Region "Declarations"
    Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
    Dim appp As String = regKey.GetValue("Install_Dir")
    'regKey.Close()
    Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
#End Region

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub dlgLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If My.Computer.FileSystem.FileExists(AppPath & "\Logs\Autoupdatelog.log") Then
                Me.rtbUpdateLogs.LoadFile(AppPath & "\Logs\Autoupdatelog.log", RichTextBoxStreamType.PlainText)
            Else
                Me.rtbUpdateLogs.LoadFile(appp & "\Logs\Autoupdatelog.log", RichTextBoxStreamType.PlainText)
            End If

            If My.Computer.FileSystem.FileExists(AppPath & "\Logs\GPMCNScan.log") Then
                Me.rtbScanLogs.LoadFile(AppPath & "\Logs\GPMCNScan.log", RichTextBoxStreamType.PlainText)
            Else
                Me.rtbScanLogs.LoadFile(appp & "\Logs\GPMCNScan.log", RichTextBoxStreamType.PlainText)
            End If

            If My.Computer.FileSystem.FileExists(AppPath & "\Logs\GPMRTScan.log") Then
                Me.rtbRTPlogs.LoadFile(AppPath & "\Logs\GPMRTScan.log", RichTextBoxStreamType.PlainText)
            Else
                Me.rtbRTPlogs.LoadFile(appp & "\Logs\GPMRTScan.log", RichTextBoxStreamType.PlainText)
            End If

        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try

            If My.Computer.FileSystem.FileExists(AppPath & "\Logs\Autoupdatelog.log") Then
                Me.rtbUpdateLogs.LoadFile(AppPath & "\Logs\Autoupdatelog.log", RichTextBoxStreamType.PlainText)
            Else
                Me.rtbUpdateLogs.LoadFile(appp & "\Logs\Autoupdatelog.log", RichTextBoxStreamType.PlainText)
            End If

            If My.Computer.FileSystem.FileExists(AppPath & "\Logs\GPMCNScan.log") Then
                Me.rtbScanLogs.LoadFile(AppPath & "\Logs\GPMCNScan.log", RichTextBoxStreamType.PlainText)
            Else
                Me.rtbScanLogs.LoadFile(appp & "\Logs\GPMCNScan.log", RichTextBoxStreamType.PlainText)
            End If

            If My.Computer.FileSystem.FileExists(AppPath & "\Logs\GPMRTScan.log") Then
                Me.rtbRTPlogs.LoadFile(AppPath & "\Logs\GPMRTScan.log", RichTextBoxStreamType.PlainText)
            Else
                Me.rtbRTPlogs.LoadFile(appp & "\Logs\GPMRTScan.log", RichTextBoxStreamType.PlainText)
            End If

        Catch ex1 As Exception
            Beep()
            MsgBox("An Error has occurred! " & vbCrLf & ex1.Message, vbOKOnly + vbCritical, "ERROR!")
        End Try
    End Sub
End Class
