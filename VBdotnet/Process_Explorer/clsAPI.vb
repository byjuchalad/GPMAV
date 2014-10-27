'Project: GPM Antivirus
'Description: GPM Antivirus Process Explorer
'Copyright 2010-2014 GPM
'Original Author: 
'Modified By:  GPM

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
Imports System.Runtime.InteropServices

'FROM: http://blog.cjwdev.co.uk/2010/06/10/vb-net-get-command-line-for-external-process/

Public Class clsAPI
    ''' <summary>
    ''' Retrieves information about a specific process, returns 0 if operation was successful
    ''' </summary>
    ''' <param name="handle">A handle to the process to get information for</param>
    ''' <param name="processinformationclass">The level of information to retrieve, 0 = basic</param>
    ''' <param name="ProcessInformation">OUTPUT An instance of the Basic_Process_Information class that will be populated with information</param>
    ''' <param name="ProcessInformationLength">The size of the ProcessInformation parameter</param>
    ''' <param name="ReturnLength">OUTPUT The amount of data that was written to the object passed in to the ProcessInformation parameter</param>
    <DllImport("ntdll.dll", EntryPoint:="NtQueryInformationProcess")> _
    Public Shared Function NtQueryInformationProcess(ByVal handle As IntPtr, ByVal processinformationclass As UInteger, ByRef ProcessInformation As PROCESS_BASIC_INFORMATION, ByVal ProcessInformationLength As Integer, ByRef ReturnLength As UInteger) As Integer
    End Function

    ''' <summary>
    ''' Holds basic information about a process, used by NtQueryInformationProcess function
    ''' </summary>
    <StructLayoutAttribute(LayoutKind.Sequential)> _
    Public Structure PROCESS_BASIC_INFORMATION
        Public Reserved1 As System.IntPtr
        Public PebBaseAddress As IntPtr
        <MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst:=2, ArraySubType:=UnmanagedType.SysUInt)> _
        Public Reserved2() As System.IntPtr
        Public UniqueProcessId As UInteger
        Public Reserved3 As System.IntPtr
    End Structure

    Const PROC_PARAMS_OFFSET As Integer = 16
    Const CMDLINE_LENGTH_OFFSET As Integer = 64

    ''' <summary>
    ''' Gets the command line that was used to start a process, including any command line arguments
    ''' </summary>
    ''' <param name="TargetProcess">The process to get the command line for</param>
    Public Shared Function GetCommandLineX86(ByVal TargetProcess As Process) As String
        'Open the process ready for memory reading
        Using MemoryReader As New NativeMemoryReader(TargetProcess)
            Dim ProcessInfo As New PROCESS_BASIC_INFORMATION
            'Get basic information about the process, including the PEB address
            Dim Result As Integer = NtQueryInformationProcess(MemoryReader.TargetProcessHandle, 0, ProcessInfo, Marshal.SizeOf(ProcessInfo), 0)
            If Not Result = 0 Then
                Throw New System.ComponentModel.Win32Exception(Result)
            End If
            Dim ParamPtrBytes(3) As Byte
            'Get a byte array that represents the pointer held in the ProcessParameters member of the PEB structure
            ParamPtrBytes = MemoryReader.ReadMemory(New IntPtr(ProcessInfo.PebBaseAddress.ToInt32 + PROC_PARAMS_OFFSET), ParamPtrBytes.Length - 1)
            If ParamPtrBytes Is Nothing Then
                Throw New ApplicationException("Memory could not be read from PebBaseAddress + " & PROC_PARAMS_OFFSET & ". Ensure that you have access to the full range of memory specified")
            End If
            'Convert the byte array to a pointer so that we now have the address for the RTL_USER_PROCESS_PARAMETERS structure
            Dim ParamPtr As IntPtr = New IntPtr(BitConverter.ToInt32(ParamPtrBytes, 0))
            Dim ParamBytes(7) As Byte
            'Read 8 bytes from the start of the CommandLine member of the RTL_USER_PROCESS_PARAMETERS structure
            ParamBytes = MemoryReader.ReadMemory(New IntPtr(ParamPtr.ToInt32 + CMDLINE_LENGTH_OFFSET), ParamBytes.Length - 1)
            If ParamBytes Is Nothing Then
                Throw New ApplicationException("Memory could not be read from ProcessParameters + " & CMDLINE_LENGTH_OFFSET & ". Ensure that you have access to the full range of memory specified")
            End If
            'The first 2 bytes in the CommandLine member tell us the length of the command line string in bytes
            Dim CmdLineLength As Byte = New IntPtr(BitConverter.ToInt16(ParamBytes, 0))
            'The last 4 bytes of the CommandLine member are a pointer to the actual command line string
            Dim CmdLinePtr As New IntPtr(BitConverter.ToInt32(ParamBytes, 4))
            'Now that we have the address and length of the string, we can read it into a byte array
            'Dim CmdLineBytes As Byte = MemoryReader.ReadMemory(CmdLinePtr, CmdLineLength – 1)
            Dim CmdLineBytes As Byte() = MemoryReader.ReadMemory(CmdLinePtr, CmdLineLength - 1)
            'No more memory needs reading from the process so close the handle
            MemoryReader.Close()
            'Return a string representation of the bytes we got for the command line string
            Return System.Text.Encoding.Unicode.GetString(CmdLineBytes).Trim
        End Using
    End Function
End Class
