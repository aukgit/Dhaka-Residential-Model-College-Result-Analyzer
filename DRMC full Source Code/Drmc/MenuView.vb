Public Class MenuView

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        Select Case e.command
            Case "query"
                QueryManager.Show()
            Case "clas"
                ClassOptions.Show()
            Case "sub"

        End Select
    End Sub

    Private Sub AxShockwaveFlash1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.GotFocus

    End Sub

    Private Sub MenuView_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0
        Me.Hide()

    End Sub
End Class