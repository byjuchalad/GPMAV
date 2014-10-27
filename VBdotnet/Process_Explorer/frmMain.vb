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

Option Strict Off

Imports System.IO
Imports System.Management
Imports Process_Explore.clsAPI
Imports System.Runtime.InteropServices

Public Class frmMain

#Region " API Functions & Flags"
    Declare Function SuspendThread Lib "kernel32.dll" (ByVal hThread As Integer) As Integer
    Declare Function ResumeThread Lib "kernel32.dll" (ByVal hThread As Integer) As Integer

    Public Enum ThreadAccess As Integer
        TERMINATE = 1
        SUSPEND_RESUME = 2
        GET_CONTEXT = 8
        SET_CONTEXT = 16
        SET_INFORMATION = 32
        QUERY_INFORMATION = 64
        SET_THREAD_TOKEN = 128
        IMPERSONATE = 256
        DIRECT_IMPERSONATION = 512
    End Enum

    Declare Function OpenThread Lib "kernel32.dll" (ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As Integer) As Integer
#End Region



    Public Shared Function GetProcessInstanceName(ByVal PID As Integer) As String
        Dim cat As New PerformanceCounterCategory("Process")
        Dim instances() = cat.GetInstanceNames()
        For Each instance In instances
            Using cnt As PerformanceCounter = New PerformanceCounter("Process", "ID Process", instance, True)
                Dim val As Integer = CType(cnt.RawValue, Int32)
                If val = PID Then
                    Return instance
                End If
            End Using
        Next
    End Function


    Public Function FindInstanceByProcessID(ByVal pid As Integer, ByVal name As String) As String
        Dim res As String
        Dim i As Integer = 0
        Dim pc As PerformanceCounter = New PerformanceCounter("Process", "ID Process")
        Try

            While True
                res = name
                If (i > 0) Then
                    res = (res + ("#" + i.ToString))
                End If
                i = (i + 1)
                pc.InstanceName = res
                pc.NextValue()
                If (CType(pc.NextValue, Integer) = pid) Then
                    Return res
                End If

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Not found")
        Return ""
    End Function



    Private _processes As New List(Of String)()
    Public Sub ListProcesses()
        Try

 
        CheckForIllegalCrossThreadCalls = False

        Dim killedProcs As New List(Of String)(_processes)
        Dim processes As Process() = System.Diagnostics.Process.GetProcesses()
        For Each proc As Process In processes
            '==Image List=========
            Dim strImageKey As String = String.Empty
            Try
                Dim ico As Icon = Icon.ExtractAssociatedIcon(proc.MainModule.FileName)
                If ico IsNot Nothing Then
                    strImageKey = ico.GetHashCode.ToString
                    imagesProcessIcons.Images.Add(strImageKey, ico)
                End If
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
            '=======End Image List=======

            Dim procId As String = proc.Id.ToString()
            If Not _processes.Contains(procId) Then
                _processes.Add(procId)
                Dim lvi As New ListViewItem(proc.ProcessName)
                If strImageKey <> String.Empty Then
                    lvi.ImageKey = strImageKey
                End If

                lvi.Name = procId
                Try

                    '1
                    'Add CPU usage to lvwProcess
                    ' lvi.SubItems.Add("")
                    ' FindInstanceByProcessID
                    'lvi.SubItems.Add(FindInstanceByProcessID(proc.Id.ToString, proc.ProcessName))

                    ' Dim PCounter = New PerformanceCounter
                    ' PCounter.CategoryName = "Process"
                    ' PCounter.CounterName = "% Processor Time"
                    ' PCounter.InstanceName = GetProcessInstanceName(proc.Id)
                    'lvi.SubItems.Add(PCounter.NextValue())

                    'lvi.SubItems.Add(proc.Modules.ToString())


                    'GetProcessInstanceName(proc.Id.ToString()))

                    ' lvi.SubItems.Add(proc.StartInfo. + "%")
                Catch ex As Exception
                    Debug.WriteLine(ex.Message)
                End Try
                Try
                    '2


                    'Add Process ID to lvwProcess
                    lvi.SubItems.Add(proc.Id.ToString())

                Catch ex As Exception

                End Try
                Try

                    '3

                    lvi.SubItems.Add(proc.BasePriority)



                Catch ex As Exception

                End Try
                Try
                    '4
                    'Add memory usage to lvwProcess
                    lvi.SubItems.Add(CInt(CDbl(proc.WorkingSet64 / 1024 / 1024)) & " MB")


                Catch ex As Exception

                End Try
                Try
                    'Add the companies name to the lvwProcess, also known as the Vendor Name
                    lvi.SubItems.Add(proc.MainModule.FileName)
                    lvi.SubItems.Add(GetCommandLineX86(proc))

                Catch ex As Exception

                End Try
                Try

                    lvi.SubItems.Add(proc.MainModule.FileVersionInfo.CompanyName)



                Catch ex As Exception

                End Try

                Try
                    'Adds the image path to the lvwProcess

                    lvi.SubItems.Add(proc.MainModule.FileVersionInfo.FileDescription)


                Catch ex As Exception

                End Try



                lvwProcess.Items.Add(lvi)

                '// Color Highlighting


                'Dim procUser As String = "SELECT * FROM Win32_Process WHERE ProcessID = '" & proc.Id & "'"
                'Dim wmiSearcher As New ManagementObjectSearcher(procUser)
                'If wmiSearcher.Get.Count > 0 Then
                '    Dim objects(1) As String
                '    For Each oObject As ManagementObject In wmiSearcher.Get
                '        oObject.InvokeMethod("GetOwner", objects)

                '        If frmPreferences.chkOwnProc.Checked = True Then
                '            If objects(0) = Environment.UserName.ToString Then
                '                lvi.BackColor = lvi.Tag
                '            End If
                '        End If
                '    Next
                'End If
            Else
                killedProcs.Remove(procId)
            End If
        Next

        'remove the killed procs in the list view
        For Each procId As String In killedProcs
            lvwProcess.Items.RemoveByKey(procId)
        Next

            tslProcesses.Text = CStr(lvwProcess.Items.Count)

        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub tsmiExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub tProcs_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles tProcs.Elapsed
        ListProcesses()


    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = True
            Me.Hide()
            Me.SysTrayIcon.Visible = True
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ListProcesses()
            tProcs.Start()
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F5 Then
                'Refresh
                'Start updating the ListView
                lvwProcess.BeginUpdate()
                'Ass the new proceses. The sub removes the old items on its own
                ListProcesses()
                'End update
                lvwProcess.EndUpdate()
            End If
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub lvwProcess_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwProcess.SelectedIndexChanged
        Try
            'If no items are selected, then set the appropriate buttons to false so they don't throw an exception
            If lvwProcess.SelectedItems.Count = 0 Then

                tsbKill.Enabled = False
                tsbSuspend.Enabled = False
                tsbLocate.Enabled = False

            Else
                'Enable the buttons when a process is selected

                tsbKill.Enabled = True
                tsbSuspend.Enabled = True
                tsbLocate.Enabled = True

            End If

            '=====Checking Backcolor of Selected ListViewItem. If it's Gray, we know the process has been paused, so we need to show the "Resume" option
            '=====Instead of so on
            If lvwProcess.SelectedItems.Count > 0 Then
                If lvwProcess.SelectedItems(0).BackColor = Color.Gray Then
                    tsmiSuspend.Text = "Resume"
                    'tsmiSuspend.Image = My.Resources._resume

                    tsbSuspend.Text = "Resume"
                    'tsbSuspend.Image = My.Resources._resume
                Else
                    tsmiSuspend.Text = "Suspend"
                    'tsmiSuspend.Image = My.Resources.suspend

                    tsbSuspend.Text = "Suspend"
                    ' tsbSuspend.Image = My.Resources.suspend
                End If
            End If
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

#Region " Process Functions "
    '==========Kill Process==========
    Private Sub tsbKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbKill.Click, tsmiKill.Click
        Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
        Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you would like to close the selected process?", "Close Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            Select Case result
                Case Windows.Forms.DialogResult.Yes

                    'If preferences form, chkNautilus is not checked, then kill whatever process is selected.
                    If p Is Nothing Then Return
                    If Not p.CloseMainWindow() Then p.Kill()
                    p.WaitForExit()
                    p.Close()
                    lvwProcess.Items.Remove(lvwProcess.SelectedItems(0))

                Case Windows.Forms.DialogResult.No
                    'Do nothing
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    '===========Refresh Process List=============
    Private Sub tsbRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRefresh.Click
        'Start updating the ListView
        lvwProcess.BeginUpdate()
        'Ass the new proceses. The sub removes the old items on its own
        ListProcesses()
        'End update
        lvwProcess.EndUpdate()
    End Sub

    '=============Suspend===============
    Private Sub tsbSuspend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSuspend.Click, tsmiSuspend.Click
        If lvwProcess.SelectedItems(0).BackColor = Color.Gray Then
            '============Resume===============
            Try
                Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
                Dim p As Process = Process.GetProcessById(pid)
                If (p.ProcessName = String.Empty) Then
                    'Check to see if the process is still running
                    MessageBox.Show("The process is no longer running.", "Process Missing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    For Each pThread As ProcessThread In p.Threads
                        Dim pOpenThread As Integer = OpenThread(ThreadAccess.SUSPEND_RESUME, False, CType(pThread.Id, Integer))
                        ResumeThread(pOpenThread)
                        lvwProcess.SelectedItems(0).BackColor = Color.White

                        tsmiSuspend.Text = "Suspend"
                        ' tsmiSuspend.Image = My.Resources.suspend

                        tsbSuspend.Text = "Suspend"
                        'tsbSuspend.Image = My.Resources.suspend
                    Next
                End If
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        Else
            '=========Suspend============
            Try
                Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
                Dim p As Process = Process.GetProcessById(pid)
                If (p.ProcessName = String.Empty) Then
                    'Check to see if the process is still running
                    MessageBox.Show("The process is no longer running.", "Process Missing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    If (p.ProcessName = "Process Manager") Then
                        Dim result As DialogResult = MessageBox.Show("Are you sure you would like to suspend Process Manager?", "Suspend Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                        Select Case result
                            Case Windows.Forms.DialogResult.Yes
                                For Each pThread As ProcessThread In p.Threads
                                    Dim pOpenThread As Integer = OpenThread(ThreadAccess.SUSPEND_RESUME, False, CType(pThread.Id, Integer))
                                    SuspendThread(pOpenThread)
                                    lvwProcess.SelectedItems(0).BackColor = Color.Gray

                                    tsmiSuspend.Text = "Resume"
                                    ' tsmiSuspend.Image = My.Resources._resume

                                    tsbSuspend.Text = "Resume"
                                    'tsbSuspend.Image = My.Resources._resume
                                Next
                            Case Windows.Forms.DialogResult.No
                                'Do Nothing
                        End Select
                    Else
                        For Each pThread As ProcessThread In p.Threads
                            Dim pOpenThread As Integer = OpenThread(ThreadAccess.SUSPEND_RESUME, False, CType(pThread.Id, Integer))
                            SuspendThread(pOpenThread)
                            lvwProcess.SelectedItems(0).BackColor = Color.Gray

                            tsmiSuspend.Text = "Resume"
                            ' tsmiSuspend.Image = My.Resources._resume

                            tsbSuspend.Text = "Resume"
                            'tsbSuspend.Image = My.Resources._resume
                        Next
                    End If
                End If
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub
#End Region

#Region " Tools "



    '===========Set Priority==========
    Private Sub tsmiPriorityI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPriorityI2.Click
        Try
            Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
            Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

            If (p.ProcessName = String.Empty) Then
                'Do nothing. process doesn't exist anymore
            Else
                p.PriorityClass = ProcessPriorityClass.Idle
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub tsmiPriorityBN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPriorityBN2.Click
        Try
            Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
            Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

            If (p.ProcessName = String.Empty) Then
                'Do nothing. process doesn't exist anymore
            Else
                p.PriorityClass = ProcessPriorityClass.BelowNormal
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmiPriorityAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPriorityAN2.Click
        Try
            Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
            Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

            If (p.ProcessName = String.Empty) Then
                'Do nothing. process doesn't exist anymore
            Else
                p.PriorityClass = ProcessPriorityClass.AboveNormal
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmiPriorityRT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPriorityRT2.Click
        Try
            Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
            Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

            If (p.ProcessName = String.Empty) Then
                'Do nothing. process doesn't exist anymore
            Else
                p.PriorityClass = ProcessPriorityClass.RealTime
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmiPriorityN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPriorityN2.Click
        Try
            Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
            Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

            If (p.ProcessName = String.Empty) Then
                'Do nothing. process doesn't exist anymore
            Else
                p.PriorityClass = ProcessPriorityClass.Normal
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmiPriorityH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiPriorityH2.Click
        Try
            Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
            Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

            If (p.ProcessName = String.Empty) Then
                'Do nothing. process doesn't exist anymore
            Else
                p.PriorityClass = ProcessPriorityClass.High
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


    Private Sub tsmiSetPriority_DropDownOpening(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            '======Gets the priority of the selected process==========
            Try
                Dim pid As Integer = Int32.Parse(lvwProcess.SelectedItems(0).SubItems(1).Text)
                Dim p As Process = System.Diagnostics.Process.GetProcessById(pid)

                If (p.ProcessName = String.Empty) Then
                    'Do nothing
                Else
                    Select Case p.PriorityClass
                        Case ProcessPriorityClass.Idle

                            tsmiPriorityI2.Checked = True



                            tsmiPriorityBN2.Checked = False
                            tsmiPriorityN2.Checked = False
                            tsmiPriorityAN2.Checked = False
                            tsmiPriorityH2.Checked = False
                            tsmiPriorityRT2.Checked = False
                        Case ProcessPriorityClass.BelowNormal

                            tsmiPriorityBN2.Checked = True


                            tsmiPriorityI2.Checked = False
                            tsmiPriorityN2.Checked = False
                            tsmiPriorityAN2.Checked = False
                            tsmiPriorityH2.Checked = False
                            tsmiPriorityRT2.Checked = False
                        Case ProcessPriorityClass.Normal

                            tsmiPriorityN2.Checked = True



                            tsmiPriorityI2.Checked = False
                            tsmiPriorityBN2.Checked = False
                            tsmiPriorityAN2.Checked = False
                            tsmiPriorityH2.Checked = False
                            tsmiPriorityRT2.Checked = False
                        Case ProcessPriorityClass.AboveNormal

                            tsmiPriorityAN2.Checked = True


                            tsmiPriorityI2.Checked = False
                            tsmiPriorityBN2.Checked = False
                            tsmiPriorityN2.Checked = False
                            tsmiPriorityH2.Checked = False
                            tsmiPriorityRT2.Checked = False
                        Case ProcessPriorityClass.High

                            tsmiPriorityH2.Checked = True


                            tsmiPriorityI2.Checked = False
                            tsmiPriorityBN2.Checked = False
                            tsmiPriorityN2.Checked = False
                            tsmiPriorityAN2.Checked = False
                            tsmiPriorityRT2.Checked = False
                        Case ProcessPriorityClass.RealTime

                            tsmiPriorityRT2.Checked = True


                            tsmiPriorityI2.Checked = False
                            tsmiPriorityBN2.Checked = False
                            tsmiPriorityN2.Checked = False
                            tsmiPriorityAN2.Checked = False
                            tsmiPriorityH2.Checked = False
                    End Select
                End If
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub



    '======== Sorting Code obtained from http://www.fryan0911.com/2009/05/vbnet-how-to-sort-listview-by-clicked.html
    '=================================================================================================================
    Private m_SortingColumn As ColumnHeader




    Private Sub LOcateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocateToolStripMenuItem.Click

        Try
            Process.Start("explorer.exe ", Path.GetDirectoryName(lvwProcess.SelectedItems(0).SubItems(4).Text))
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub



    Private Sub tmrCPU_Tick(sender As Object, e As EventArgs) Handles tmrCPU.Tick
        ' tsbCPU.Text = pfcCPU.NextValue
        Try
            tsbCPUProg.Value = CInt(Fix(pfcCPU.NextValue()))
            tsbCPU.Text = tsbCPUProg.Value.ToString() & "%"
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub MinimizeToTrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToTrayToolStripMenuItem.Click
        Try
            SysTrayIcon.Visible = True
            Me.Hide()
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Try
            GC.Collect()
            Me.Close()
            Application.Exit()
            End
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            MsgBox("Process Explorer. A component of GPM Antivirus 2014.  Copyright (c) 2010-2014 GPM.  All Rights Reserved. Free and Open Source Forever!", MsgBoxStyle.Information, "About")
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub SysTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SysTrayIcon.MouseDoubleClick
        Try
            Me.Show()
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click


        Try
            MsgBox("Process Explorer. A component of GPM Antivirus 2014.  Copyright (c) 2010-2014 GPM.  All Rights Reserved. Free and Open Source Forever!", MsgBoxStyle.Information, "About")
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Try
            GC.Collect()
            Me.Close()
            Application.Exit()
            End
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Try
            Me.Show()
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub tsbLocate_Click(sender As Object, e As EventArgs) Handles tsbLocate.Click

        Try
            Process.Start("explorer.exe ", Path.GetDirectoryName(lvwProcess.SelectedItems(0).SubItems(4).Text))
        Catch ex As Exception
            Beep()
            Debug.WriteLine(ex.Message)
        End Try
    End Sub
End Class


Public Class clsListviewSorter ' Implements a comparer Implements IComparer  
    Implements IComparer

    Private m_ColumnNumber As Integer
    Private m_SortOrder As SortOrder
    Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
        m_ColumnNumber = column_number
        m_SortOrder = sort_order
    End Sub
    ' Compare the items in the appropriate column  
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
        Dim item_y As ListViewItem = DirectCast(y, ListViewItem)
        ' Get the sub-item values.  
        Dim string_x As String
        If item_x.SubItems.Count <= m_ColumnNumber Then
            string_x = ""
        Else
            string_x = item_x.SubItems(m_ColumnNumber).Text
        End If
        Dim string_y As String
        If item_y.SubItems.Count <= m_ColumnNumber Then
            string_y = ""
        Else
            string_y = item_y.SubItems(m_ColumnNumber).Text
        End If
        ' Compare them.  
        If m_SortOrder = SortOrder.Ascending Then
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_x).CompareTo(Val(string_y))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
            Else
                Return String.Compare(string_x, string_y)
            End If
        Else
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_y).CompareTo(Val(string_x))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
            Else
                Return String.Compare(string_y, string_x)
            End If
        End If
    End Function

End Class