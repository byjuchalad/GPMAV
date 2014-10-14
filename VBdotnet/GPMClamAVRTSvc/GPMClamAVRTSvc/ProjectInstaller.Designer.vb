<System.ComponentModel.RunInstaller(True)> Partial Class ProjectInstaller
    Inherits System.Configuration.Install.Installer

    'Installer overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RTServiceProcessInstaller = New System.ServiceProcess.ServiceProcessInstaller()
        Me.RTServiceInstaller = New System.ServiceProcess.ServiceInstaller()
        '
        'RTServiceProcessInstaller
        '
        Me.RTServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem
        Me.RTServiceProcessInstaller.Password = Nothing
        Me.RTServiceProcessInstaller.Username = Nothing
        '
        'RTServiceInstaller
        '
        Me.RTServiceInstaller.Description = "GPM Antivirus Real Time Antivirus Scanner Service"
        Me.RTServiceInstaller.DisplayName = "GPM Antivirus Real Time ClamAV Scanner Service"
        Me.RTServiceInstaller.ServiceName = "GPMClamAVRTSvc"
        '
        'ProjectInstaller
        '
        Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.RTServiceProcessInstaller, Me.RTServiceInstaller})

    End Sub
    Friend WithEvents RTServiceProcessInstaller As System.ServiceProcess.ServiceProcessInstaller
    Friend WithEvents RTServiceInstaller As System.ServiceProcess.ServiceInstaller

End Class
