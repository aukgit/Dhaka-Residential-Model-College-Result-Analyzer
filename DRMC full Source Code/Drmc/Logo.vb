Public Class Logo
    Dim nj As Integer = 0
    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        Select Case e.command
            Case "go"
                'MsgBox(go)
                nj = nj + 1
                If nj = 2 Then
                    Login.Show()
                    Me.Hide()
                    Me.Finalize()
                End If
        End Select
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        'Me.Dispose()

    End Sub
End Class