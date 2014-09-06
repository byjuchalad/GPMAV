'Project: GPM Antivirus
'Description: Splash Screen
'Copyright 2010-2014 GPM
'Original Author: GPM
'Modified By:  

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


Public NotInheritable Class splsh

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub splsh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        '    If My.Application.Info.Title <> "" Then
        'ApplicationTitle.Text = My.Application.Info.Title
        'Else
        'If the application title is missing, use the application name, without the extension
        'ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        ' Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        '  Copyright.Text = My.Application.Info.Copyright




    End Sub




    Private Sub tmrOut_Tick(sender As Object, e As EventArgs) Handles tmrOut.Tick
        Me.Hide()
        tmrOut.Enabled = False
        frmMain.systray1.Visible = True
    End Sub
End Class
