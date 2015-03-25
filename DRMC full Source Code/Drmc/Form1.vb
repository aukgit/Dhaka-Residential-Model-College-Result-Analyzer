Public Class Form1

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        If e.command = "go" Then
            Me.Hide()
            Login.Show()

            Me.Finalize()
            'Me.Dispose()
        End If
    End Sub

    Private Sub Form1_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        RegOcx.RegOcx(Application.StartupPath & "\" & "Flash8.ocx")
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
End Class
