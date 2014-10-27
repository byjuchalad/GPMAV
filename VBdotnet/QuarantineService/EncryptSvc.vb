
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
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text

Public Class EncryptSvc

    Protected tmrMain As Timer

#Region "Declarations"

    '*************************
    '** Global Variables
    '*************************

    ' Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("Software\GPMAV", True)
    Dim appp As String = regKey.GetValue("Install_Dir")
    'regKey.Close()
    Dim strHomeGPMDrv As String = Environ("homedrive") & "\GPMAV"
    Dim strQuaDir As String = Environ("homedrive") & "\GPMAV\Quarantine"
    Dim strEncQuaDir As String = Environ("homedrive") & "\GPMAV\EncryptedQuarantine"

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream
    Dim txtDestinationEncrypt As String = ""
    Dim txtDestinationDecrypt As String = ""

#End Region

#Region "Encryption"

    'From http://www.codeproject.com/script/articles/download.aspx?file=/KB/security/EncryptFile/EncryptFile_src.zip&rp=

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

    '*************************
    '** Create An IV
    '*************************

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of bytResult into bytIV.
        'The 0 To 30 for bytKey used the first 256 bits of the hashed password.
        'The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'Return the IV.
    End Function


    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, _
                                     ByVal strOutputFile As String, _
                                     ByVal bytKey() As Byte, _
                                     ByVal bytIV() As Byte, _
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateEncryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateDecryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar

            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'If decrypting then delete the encrypted file.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Update the user when the file is done.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                ' MsgBox("Encryption Complete" + Wrap + Wrap + _
                '   "Total bytes processed = " + _
                '  lngBytesProcessed.ToString, _
                '  MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.

            Else
                'Update the user when the file is done.
                ' MsgBox("Decryption Complete" + Wrap + Wrap + _
                '      "Total bytes processed = " + _
                '    lngBytesProcessed.ToString, _
                '    MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.

            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            '  MsgBox("Please check to make sure the path and filename" + _
            '    "are correct and if the file exists.", _
            '    MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch
            fsInput.Close()
            fsOutput.Close()



            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt)
                fileDelete.Delete()

                ' MsgBox("Please check to make sure that you entered the correct" + _
                '        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt)
                fileDelete.Delete()

                '   MsgBox("This file cannot be encrypted.", _
                '       MsgBoxStyle.Exclamation, "Invalid File")
            End If

        End Try
    End Sub
#End Region


    Public Sub New()
        MyBase.New()
        CanPauseAndContinue = False
        ServiceName = "GPMAVQuaSvc"
        tmrMain = New Timer
    End Sub

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            EventLog.WriteEntry("GPMAVQuaSvc service started")
            AddHandler tmrMain.Elapsed, AddressOf tmrMain_Elapsed
            AddHandler tmrMain.Disposed, AddressOf tmrMain_Disposed
            'tmrMain.Interval = 3600000
            tmrMain.Interval = 3000
            ' Start raising the Elapsed event.
            tmrMain.Enabled = True
        Catch ex As Exception
            EventLog.WriteEntry("GPMAVQuaSvc Error: " & ex.Message)
        End Try
    End Sub

    Protected Sub tmrMain_Elapsed(ByVal source As Object, ByVal e As ElapsedEventArgs)
        Try

            ' Stop raising the Elapsed event.
            'Beep()
            ' tmrMain.Stop()
            ' Force garbage collection to make sure that the garbage collector
            ' reclaims the memory that is associated with the tmrMain Timer object.
            GC.Collect()
            ' Start to raise the Elapsed event again.
            ' tmrMain.Start()
            If Not My.Computer.FileSystem.DirectoryExists(strQuaDir) Then
                My.Computer.FileSystem.CreateDirectory(strQuaDir)
            Else
                If Not My.Computer.FileSystem.DirectoryExists(strEncQuaDir) Then
                    My.Computer.FileSystem.CreateDirectory(strEncQuaDir)
                Else

                    For Each UncFile In Directory.GetFiles(strQuaDir)
                        ' do whatever wtih filename

                        'Declare variables for the key and iv.
                        'The key needs to hold 256 bits and the iv 128 bits.
                        Dim bytKey As Byte()
                        Dim bytIV As Byte()
                        'Send the password to the CreateKey function.
                        bytKey = CreateKey("quar2f6t")
                        'Send the password to the CreateIV function.
                        bytIV = CreateIV("quar2f6t")
                        'Start the encryption.
                        strFileToEncrypt = UncFile
                        EventLog.WriteEntry("GPMAVQuaSvc: Encrypting GPMAV Quarantined Files...")
                        txtDestinationEncrypt = strEncQuaDir & "\" & Path.GetFileName(UncFile)
                        EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt, _
                                             bytKey, bytIV, CryptoAction.ActionEncrypt)

                        GC.Collect()
                    Next

                End If
            End If
        Catch ex As Exception
            EventLog.WriteEntry("GPMAVQuaSvc Error: " & ex.Message)
        End Try
    End Sub
    Protected Sub tmrMain_Disposed(ByVal source As Object, ByVal e As EventArgs)
        Try
            EventLog.WriteEntry("GPMAVQuaSvc timer disposed")
        Catch ex As Exception
            EventLog.WriteEntry("GPMAVQuaSvc Error: " & ex.Message)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        Try
            ' Add code here to perform any tear-down necessary to stop your service.
            EventLog.WriteEntry("GPMAVQuaSvc service stopped")
            tmrMain.Enabled = False
            tmrMain.Stop()

        Catch ex As Exception
            EventLog.WriteEntry("GPMAVQuaSvc Error: " & ex.Message)
        End Try
    End Sub
End Class
