Module clSystemInfo
    Public Sub SystemInformation()
        '// Totals
        'Handles
        'Dim countTotalHandles As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Process", "Thread Count")
        'Dim totalHandles As Integer = CInt(countTotalHandles.RawValue)
        'frmMain.lblTotalHandles.Text = totalHandles
        '
        '// Physical Memory
        '
        'Total Physical Memory
        Dim intMemTotal As Integer = CInt(My.Computer.Info.TotalPhysicalMemory / 1024)
        frmMain.lblPhysMemTotal.Text = String.Format(intMemTotal.ToString("#,#"))
        '
        'Available Physical Memory
        Dim intMemAvail As Integer = CInt(My.Computer.Info.AvailablePhysicalMemory / 1024)
        frmMain.lblPhysMemAvailable.Text = String.Format(intMemAvail.ToString("#,#"))
        '
        'System Cache Peak
        Dim countSystemCache As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Cache Bytes")
        Dim physicalMemCache As Integer = CInt((countSystemCache.RawValue / (1024)))
        frmMain.lblPhysMemCache.Text = String.Format(physicalMemCache.ToString("#,#"))
        '
        Dim countSystemPeakCache As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Cache Bytes Peak")
        Dim physicalMemPeakCache As Integer = CInt((countSystemPeakCache.RawValue / (1024)))
        frmMain.lblPhysMemPeak.Text = String.Format(physicalMemPeakCache.ToString("#,#"))

        'System Fault per Sec
        Dim countSystemFaultsCache As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Cache Faults/sec")
        Dim physicalMemFaultsCache As Integer = CInt((countSystemFaultsCache.RawValue))
        frmMain.lblPhysCacheFaults.Text = physicalMemFaultsCache & "/s"

        '// Commit Charge
        '
        'Current Commit
        Dim countCommitCurrent As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Committed Bytes")
        Dim commitCurrentInKB As Integer = CInt((countCommitCurrent.RawValue / (1024)))
        frmMain.lblCommitCurrent.Text = String.Format(commitCurrentInKB.ToString("#,#"))
        '
        'Commit Limit
        Dim countCommitLimit As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Commit Limit")
        Dim commitCurrentLimitInKB As Integer = CInt((countCommitLimit.RawValue / (1024)))
        frmMain.lblCommitLimit.Text = String.Format(commitCurrentLimitInKB.ToString("#,#"))
        '
        'Commit Peak
        ' Dim countCommitPeak As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "None")
        ' Dim commitPeakInKB As Integer = CInt((countCommitPeak.RawValue / (1024)))
        ' frmMain.lblCommitPeak.Text = String.Format(commitPeakInKB.ToString("#,#"))
        '
        '// Kernel Memory
        '
        'Paged Virtual
        Dim countKernelVirtual As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Pool Paged Bytes")
        Dim kernelPhysical As Integer = CInt((countKernelVirtual.RawValue / (1024)))
        frmMain.lblKerMemVirtual.Text = String.Format(kernelPhysical.ToString("#,#"))
        '
        'Nonpaged
        Dim countKernelNonpaged As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Memory", "Pool Nonpaged Bytes")
        Dim kernelNonpaged As Integer = CInt((countKernelNonpaged.RawValue / (1024)))
        frmMain.lblKerMemNonpaged.Text = String.Format(kernelNonpaged.ToString("#,#"))



        '
        '
        'I/O Totals
        'Nonpaged
        '  Dim countIOTotalRead As System.Diagnostics.PerformanceCounter = New System.Diagnostics.PerformanceCounter("Process", "IO Read Bytes/sec")
        ' Dim IOTotalRead As Integer = CInt((countIOTotalRead.RawValue / (60)))
        'frmMain.lblTotIORead.Text = String.Format(IOTotalRead.ToString("#,#"))
    End Sub
End Module
