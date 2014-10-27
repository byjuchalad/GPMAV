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
        Me.SvcProcInst1 = New System.ServiceProcess.ServiceProcessInstaller()
        Me.SvcInst1 = New System.ServiceProcess.ServiceInstaller()
        '
        'SvcProcInst1
        '
        Me.SvcProcInst1.Account = System.ServiceProcess.ServiceAccount.LocalSystem
        Me.SvcProcInst1.Password = Nothing
        Me.SvcProcInst1.Username = Nothing
        '
        'SvcInst1
        '
        Me.SvcInst1.Description = "GPM Antivirus Quarantine Service"
        Me.SvcInst1.DisplayName = "GPM Antivirus Quarantine Service"
        Me.SvcInst1.ServiceName = "GPMAVQuaSvc"
        Me.SvcInst1.StartType = System.ServiceProcess.ServiceStartMode.Automatic
        '
        'ProjectInstaller
        '
        Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.SvcProcInst1, Me.SvcInst1})

    End Sub
    Friend WithEvents SvcProcInst1 As System.ServiceProcess.ServiceProcessInstaller
    Friend WithEvents SvcInst1 As System.ServiceProcess.ServiceInstaller

End Class
