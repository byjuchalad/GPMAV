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
        Me.SvcProcInstaller = New System.ServiceProcess.ServiceProcessInstaller()
        Me.SvcInstaller = New System.ServiceProcess.ServiceInstaller()
        '
        'SvcProcInstaller
        '
        Me.SvcProcInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem
        Me.SvcProcInstaller.Password = Nothing
        Me.SvcProcInstaller.Username = Nothing
        '
        'SvcInstaller
        '
        Me.SvcInstaller.Description = "Virus Database Update Service for GPMAV."
        Me.SvcInstaller.DisplayName = "GPM Antivirus Automatic Virus Database Update Service"
        Me.SvcInstaller.ServiceName = "GPMAVAuSvc"
        '
        'ProjectInstaller
        '
        Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.SvcProcInstaller, Me.SvcInstaller})

    End Sub
    Friend WithEvents SvcProcInstaller As System.ServiceProcess.ServiceProcessInstaller
    Friend WithEvents SvcInstaller As System.ServiceProcess.ServiceInstaller

End Class
