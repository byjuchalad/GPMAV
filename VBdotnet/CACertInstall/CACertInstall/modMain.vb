' GPM Antivirus
'
' Copyright (c) 2010-2014 GPM
'
' This program is free software; you can redistribute it and/or
' modify it under the terms of the GNU Library General Public
' License as published by the Free Software Foundation; either
' version 2 of the License, or (at your option) any later version.
'
' This library is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
' Library General Public License for more details.
'
' You should have received a copy of the GNU Library General Public
' License along with this software; if not, write to the
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
' 

Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports System.IO
Module modMain


    Private Sub InstallCertificate(ByVal cerFileName As String)
        Dim certificate As X509Certificate2 = New X509Certificate2(cerFileName)
        Dim store As X509Store = New X509Store(StoreName.Root, StoreLocation.LocalMachine)
        store.Open(OpenFlags.ReadWrite)
        store.Add(certificate)
        store.Close()
    End Sub

    Public Function ComputeMD5Hash(ByVal fileName As String) As String
        Return ComputeHash(fileName, New MD5CryptoServiceProvider)
    End Function

    Public Function ComputeSHA1Hash(ByVal fileName As String) As String
        Return ComputeHash(fileName, New SHA1CryptoServiceProvider)
    End Function

    Public Function ComputeHash(ByVal fileName As String, ByVal hashAlgorithm As HashAlgorithm) As String
        Dim stmcheck As FileStream = File.OpenRead(fileName)
        Try
            Dim hash() As Byte = hashAlgorithm.ComputeHash(stmcheck)
            Dim computed As String = BitConverter.ToString(hash).Replace("-", "")
            Return computed
        Finally
            stmcheck.Close()
        End Try
    End Function

    Public Sub SaveFromResources(ByVal FilePath As String, ByVal File As Object)
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub

    Sub Main()
        Try

            Console.WriteLine("Installing GPM Certificate Authority on this Compuer...")

            SaveFromResources(Application.StartupPath & "\ca.crt", My.Resources.ca)
            Dim FILE1 As String
            FILE1 = Application.StartupPath & "\ca.crt"


            If File.Exists(FILE1) Then
                If ComputeSHA1Hash(FILE1) = "57CF615AB2A9B7573D5975A959F0B785B238467A" Then
                    InstallCertificate(FILE1)

                    ' MsgBox("Root CERTIFICATE INSTALLED!", MsgBoxStyle.Information, "DONE")
                    Console.WriteLine("Root CERTIFICATE INSTALLED")
                    Application.Exit()
                    End
                Else
                    'MsgBox("Certificate INVALID! - PLEASE RE DOWNLOAD THIS FILE", MsgBoxStyle.Critical, "ERROR")
                    Console.WriteLine("Certificate INVALID! - PLEASE RE DOWNLOAD THIS FILE")
                    Application.Exit()
                    End
                End If

            Else
                'MsgBox("Certificate File Doesn't Exist in the current directory!", MsgBoxStyle.Critical, "ERROR")
                Console.WriteLine("Certificate File does not Exists in the current directory!")
                Application.Exit()
                End
            End If

            File.Delete(Application.StartupPath & "\ca.crt")
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            Console.WriteLine(ex.Message)
            Application.Exit()
            End
        End Try

    End Sub


End Module
