Imports vb = Microsoft.VisualBasic
Public Class Login


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Admins' table. You can move, or remove it, as needed.
        'Me.AdminsTableAdapter.Fill(Me.AuksoftDataSet1.Admins)
        'TODO: This line of code loads data into the 'AuksoftDataSet.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.AuksoftDataSet1.Admins)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.TextBox1.Text = Me.ComboBox1.Text
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Me.TextBox1.Text = Me.ComboBox1.Text

    End Sub

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub
    Private Sub CmD()
        Dim c As Integer
        c = Me.AdminsBindingSource.Find("username", Me.TextBox1.Text)
        'MsgBox(c)
        If c > -1 Then
            m = Me.AuksoftDataSet1.Admins.Item(c).Item("AdminOrLimited").ToString


            x = Me.AuksoftDataSet1.Admins.Item(c).Item("Password").ToString
            'MsgBox(m)
            'MsgBox(x)
            If x = Me.TextBox2.Text Then
                Acc = Me.TextBox1.Text
                AccGrp = m
                Me.AuksoftDataSet1.Admins.Item(c).Item(5) = Now.ToLongDateString
                StrPass = x
                StrSign = Me.AuksoftDataSet1.Admins.Item(c).Item(7).ToString

                Try
                    Me.AdminsBindingSource.EndEdit()
                    Me.AdminsTableAdapter.Update(Me.AuksoftDataSet1)
                Catch ex As Exception
                    Epx()
                End Try
                MainScreen_Database.Show()
                MainScreen_Database.Activate()
                Me.Hide()
                Me.Finalize()
                'Me.Dispose()
                'Admin.Show()
                'Me.Hide()
            Else
                MsgBox("Please type the corrent password", MsgBoxStyle.Critical)
                Me.TextBox2.Focus()


            End If
        Else
            MsgBox("Try Again ...Please Check the user Names", MsgBoxStyle.Critical)





        End If
    End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        If e.command = "cancel" Then
            End
        ElseIf e.command = "login" Then
            CmD()
        ElseIf e.command = "hint" Then
            On Error Resume Next
            I = Me.AdminsBindingSource.Find("username", Me.TextBox1.Text)
            If I > -1 Then
                bc = Me.AuksoftDataSet1.Admins.Item(I).Item(8).ToString
                MsgBox("This user Password Hint:" & bc, MsgBoxStyle.Information)
            End If
        ElseIf e.command = "lastlog" Then
            On Error Resume Next
            I = Me.AdminsBindingSource.Find("username", Me.TextBox1.Text)
            If I > -1 Then
                bc = Me.AuksoftDataSet1.Admins.Item(I).Item(5).ToString
                MsgBox("This user LastLogin:" & bc, MsgBoxStyle.Information)
            End If
        ElseIf e.command = "description" Then
            On Error Resume Next
            I = Me.AdminsBindingSource.Find("username", Me.TextBox1.Text)
            If I > -1 Then
                bc = Me.AuksoftDataSet1.Admins.Item(I).Item(6).ToString
                MsgBox("This user Description:" & bc, MsgBoxStyle.Information)
            End If
        ElseIf e.command = "drag" Then
            AukF.DragAuk(Me)

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        On Error Resume Next
        I = Me.AdminsBindingSource.Find("username", Me.TextBox1.Text)
        If I > -1 Then
            bc = Me.AuksoftDataSet1.Admins.Item(I).Item(3).ToString
            If bc <> "" Then
                Me.AxShockwaveFlash1.SetVariable("cat", UCase(vb.Left(bc, 1)) & LCase(vb.Right(bc, Len(bc) - 1)))
            Else
                AccGrp = "User"
                Me.AxShockwaveFlash1.SetVariable("cat", "User")

            End If

        Else
            Me.AxShockwaveFlash1.SetVariable("cat", "Please Select...")

        End If

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown, TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmD()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class