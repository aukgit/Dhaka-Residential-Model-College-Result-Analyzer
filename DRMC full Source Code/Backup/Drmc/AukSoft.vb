Public Class AukSoft

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        If e.command = "exit" Then
            Me.Hide()

        End If
    End Sub

    Private Sub AukSoft_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AukF.FullScreenSet(Me, True)

    End Sub
End Class