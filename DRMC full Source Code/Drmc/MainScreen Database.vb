Public Class MainScreen_Database

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MainScreen_Database_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AukF.FullScreenSet(Me, True)
        Me.NotifyIcon1.Visible = True
        MainFrm = Me
    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand

        Select Case e.command


            Case 1
                MainFrm = Me
                Me.Hide()
                Informations.Show()
                Informations.Activate()

            Case 2
                MainFrm = Me
                Me.Hide()
                QueryManager.Show()
                QueryManager.Activate()

            Case 3
                MainFrm = Me
                Me.Hide()
                Ctmarks.Show()
                Ctmarks.Activate()

            Case 4
                MainFrm = Me
                Me.Hide()
                ClassOptions.Show()
            Case 5 'SubjectColl
                MainFrm = Me
                Me.Hide()
                SubjectCollection.Show()
                SubjectCollection.Activate()

            Case 6 'print
                MainFrm = Me
                Me.Hide()
                PrintOption.Show()
                PrintOption.Activate()


            Case 7
                MainFrm = Me
                Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)

            Case 9 'user account
                If AccGrp.ToLower = "admin" Then
                    Admins.Show()
                    Admins.Activate()
                Else
                    MsgBox("User Account has no permission to access there...", MsgBoxStyle.Information)

                End If

            Case 10
                End
            Case "auk"
                MainFrm = Me
                'Me.Hide()
                AukSoft.Show()
                AukSoft.Activate()
        End Select
    End Sub

    Private Sub AboutAukSoftwaresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutAukSoftwaresToolStripMenuItem.Click
        AukSoft.Show()
        AukSoft.Activate()
    End Sub

    Private Sub HouseEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseEditorToolStripMenuItem.Click
        HouseEdit.Show()
        HouseEdit.Activate()

    End Sub

    Private Sub CloseAllOpenedWindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next

        If AukF.MsgTr(What & "Close all opened forms?... Please Save Before do it...!") = True Then
            For I = 0 To My.Application.OpenForms.Count - 1
                If Me.Name.ToString <> My.Application.OpenForms.Item(I).Name.ToString Then
                    'My.Application.OpenForms.Item(I).Hide()
                    My.Application.OpenForms.Item(I).Close()
                End If

            Next
        End If


    End Sub

    Private Sub ExitFromSoftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitFromSoftToolStripMenuItem.Click
        If AukF.MsgTr(What & "Exit from soft?... Please Save Before do it...!") = True Then
            Me.NotifyIcon1.Visible = False
            End
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.CloseOnlyItems.DropDownItems.Find(My.Application.OpenForms.Item(I), False)

    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub HideAllFormsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideAllFormsToolStripMenuItem.Click
        If AukF.MsgTr(What & "Hide all opened forms?... Please Save Before do it...!") = True Then
            For I = 0 To My.Application.OpenForms.Count - 1
                If Me.Name <> My.Application.OpenForms.Item(I).Name Then
                    'My.Application.OpenForms.Item(I).Hide()
                    My.Application.OpenForms.Item(I).Hide()
                End If

            Next
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.Activate()

    End Sub

    Private Sub AxShockwaveFlash1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Admins.Show()
        Admins.Activate()

    End Sub

    Private Sub HowQueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowQueryManagerToolStripMenuItem.Click
        QueryManager.Show()
        QueryManager.Activate()

    End Sub

    Private Sub SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SToolStripMenuItem.Click
        HouseEdit.Show()
        HouseEdit.Activate()

    End Sub

    Private Sub HideMainSceeenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideMainSceeenToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub InformationEntryProfileEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationEntryProfileEditorToolStripMenuItem.Click
        Informations.Show()
        Informations.Activate()
        Me.Hide()

    End Sub

    Private Sub SubjectCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCollectionToolStripMenuItem.Click
        SubjectCollection.Show()
        SubjectCollection.Activate()
        Me.Hide()

    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsToolStripMenuItem.Click
        If AccGrp.ToLower = "admin" Then
            Admins.Show()
            Admins.Activate()
            'Me.Hide()

        Else
            MsgBox("User Account has no permission to access there...", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub ClassOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassOptionsToolStripMenuItem.Click
        MainFrm = Me
        Me.Hide()
        ClassOptions.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        MainFrm = Me
        Me.Hide()
        PrintOption.Show()
        PrintOption.Activate()
    End Sub



End Class