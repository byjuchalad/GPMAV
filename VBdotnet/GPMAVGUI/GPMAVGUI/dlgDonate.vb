Imports System.Windows.Forms

Public Class dlgDonate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub picQR_Click(sender As Object, e As EventArgs) Handles picQR.Click
        Try
            Clipboard.Clear()
            Clipboard.SetText("1DxFQQXLMTCtZjeshZ3dRseSxKk5TzugSv")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lnkBTC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkBTC.LinkClicked
        Process.Start("bitcoin:1DxFQQXLMTCtZjeshZ3dRseSxKk5TzugSv?label=GPMAV%20OFFICIAL%20BTC")
    End Sub
End Class
