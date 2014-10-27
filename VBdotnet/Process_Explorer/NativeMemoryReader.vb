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
'FROM http://www.vbforums.com/showthread.php?617782-Reading-memory-from-another-process-(ReadProcessMemory-API)&p=3819578

Imports System.Runtime.InteropServices

Public Class NativeMemoryReader : Implements IDisposable


#Region "API Definitions"

    <DllImport("kernel32.dll", EntryPoint:="OpenProcess", SetLastError:=True)> _
    Private Shared Function OpenProcess(ByVal dwDesiredAccess As UInteger, <MarshalAsAttribute(UnmanagedType.Bool)> ByVal bInheritHandle As Boolean, ByVal dwProcessId As UInteger) As IntPtr
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="ReadProcessMemory", SetLastError:=True)> _
    Private Shared Function ReadProcessMemory(<InAttribute()> ByVal hProcess As System.IntPtr, <InAttribute()> ByVal lpBaseAddress As System.IntPtr, <Out()> ByVal lpBuffer As Byte(), ByVal nSize As UInteger, <OutAttribute()> ByRef lpNumberOfBytesRead As UInteger) As <System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("kernel32.dll", EntryPoint:="CloseHandle", SetLastError:=True)> _
    Private Shared Function CloseHandle(ByVal hObject As IntPtr) As <MarshalAsAttribute(UnmanagedType.Bool)> Boolean
    End Function

#End Region


#Region "Private Fields"

    Private _TargetProcess As Process = Nothing
    Private _TargetProcessHandle As IntPtr = IntPtr.Zero
    Const PROCESS_VM_READ As UInteger = 16
    Const PROCESS_QUERY_INFORMATION As UInteger = 1024

#End Region


#Region "Public Properties"

    ''' <summary>
    ''' The process that memory will be read from when ReadMemory is called
    ''' </summary>
    Public ReadOnly Property TargetProcess() As Process
        Get
            Return _TargetProcess
        End Get
    End Property

    ''' <summary>
    ''' The handle to the process that was retrieved during the constructor or the last
    ''' successful call to the Open method
    ''' </summary>
    Public ReadOnly Property TargetProcessHandle() As IntPtr
        Get
            Return _TargetProcessHandle
        End Get
    End Property

#End Region


#Region "Public Methods"

    ''' <summary>
    ''' Reads the specified number of bytes from an address in the process's memory.
    ''' All memory in the specified range must be available or the method will fail.
    ''' Returns Nothing if the method fails for any reason
    ''' </summary>
    ''' <param name="MemoryAddress">The address in the process's virtual memory to start reading from</param>
    ''' <param name="Count">The number of bytes to read</param>
    Public Function ReadMemory(ByVal MemoryAddress As IntPtr, ByVal Count As Integer) As Byte()
        If _TargetProcessHandle = IntPtr.Zero Then
            Me.Open()
        End If
        Dim Bytes(Count) As Byte
        Dim Result As Boolean = ReadProcessMemory(_TargetProcessHandle, MemoryAddress, Bytes, CUInt(Count), 0)
        If Result Then
            Return Bytes
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Gets a handle to the process specified in the TargetProcess property.
    ''' A handle is automatically obtained by the constructor of this class but if the Close
    ''' method has been called to close a previously obtained handle then another handle can
    ''' be obtained by calling this method. If a handle has previously been obtained and Close has
    ''' not been called yet then an exception will be thrown.
    ''' </summary>
    Public Sub Open()
        If _TargetProcess Is Nothing Then
            Throw New ApplicationException("Process not found")
        End If
        If _TargetProcessHandle = IntPtr.Zero Then
            _TargetProcessHandle = OpenProcess(PROCESS_VM_READ Or PROCESS_QUERY_INFORMATION, True, CUInt(_TargetProcess.Id))
            If _TargetProcessHandle = IntPtr.Zero Then
                Throw New ApplicationException("Unable to open process for memory reading. The last error reported was: " & New System.ComponentModel.Win32Exception().Message)
            End If
        Else
            Throw New ApplicationException("A handle to the process has already been obtained, " & _
                                           "close the existing handle by calling the Close method before calling Open again")
        End If
    End Sub

    ''' <summary>
    ''' Closes a handle that was previously obtained by the constructor or a call to the Open method
    ''' </summary>
    Public Sub Close()
        If Not _TargetProcessHandle = IntPtr.Zero Then
            Dim Result As Boolean = CloseHandle(_TargetProcessHandle)
            If Not Result Then
                Throw New ApplicationException("Unable to close process handle. The last error reported was: " & _
                                               New System.ComponentModel.Win32Exception().Message)
            End If
            _TargetProcessHandle = IntPtr.Zero
        End If
    End Sub

#End Region


#Region "Constructors"

    ''' <summary>
    ''' Creates a new instance of the NativeMemoryReader class and attempts to get a handle to the
    ''' process that is to be read by calls to the ReadMemory method.
    ''' If a handle cannot be obtained then an exception is thrown
    ''' </summary>
    ''' <param name="ProcessToRead">The process that memory will be read from</param>
    Public Sub New(ByVal ProcessToRead As Process)
        If ProcessToRead Is Nothing Then
            Throw New ArgumentNullException("ProcessToRead")
        End If
        _TargetProcess = ProcessToRead
        Me.Open()
    End Sub

#End Region


#Region "IDisposable Support"

    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If Not _TargetProcessHandle = IntPtr.Zero Then
                Try
                    CloseHandle(_TargetProcessHandle)
                Catch ex As Exception
                    Debug.WriteLine("Error closing handle - " & ex.Message)
                End Try
            End If
        End If
        Me.disposedValue = True
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

    ''' <summary>
    ''' Releases resources and closes any process handles that are still open
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class