Public Class QueryManager

    Private Sub QueryManager_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.Hide()

    End Sub

    Private Sub QueryManager_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.NotifyIcon1.Visible = False

    End Sub

    Private Sub QueryManager_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.NotifyIcon1.Visible = False
    End Sub

    Private Sub QueryManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectPosition' table. You can move, or remove it, as needed.
        'Me.SubjectPositionTableAdapter1.Fill(Me.AuksoftDataSet1.SubjectPosition)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.ClassOptions' table. You can move, or remove it, as needed.
        Me.ClassOptionsTableAdapter.Fill(Me.AuksoftDataSet1.ClassOptions)
        Me.TermSTableAdapter.Fill(Me.AuksoftDataSet1.TermS)
        Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)
        Me.SubjectPositionTableAdapter1.Fill(Me.AuksoftDataSet1.SubjectPosition)
        SFC("Class", "Sections")
        STC("10", "Science")
        AukF2.Db_Load("*", Me.AuksoftDataSet1, "Acc2Subject")
        'MsgBox(AuksoftDataSet1.Acc2Subject.Rows.Count)
        If AuksoftDataSet1.Acc2Subject.Rows.Count > 0 Then
            AukF2.List_or_Combo_AddDb_Row_dataSource(Me.SublstFor9_Science, Me.AuksoftDataSet1.Acc2Subject, "2-13", "0")
        End If
        SFC("Class", "Sections")
        STC("10", "Human")
        AukF2.Db_Load("*", Me.AuksoftDataSet1, "Acc2Subject")
        If AuksoftDataSet1.Acc2Subject.Rows.Count > 0 Then
            'Me.SublstFor9_Science = AukF2.List_or_Combo_AddDb_Row_dataSource(Me.AuksoftDataSet1.Sections, "2-11", "0")
            AukF2.List_or_Combo_AddDb_Row_dataSource(Me.SubLstFor9_Human, Me.AuksoftDataSet1.Acc2Subject, "2-13", "0")

        End If

        'AukF.AddComboToAnother(Me.ComboBox1, Me.TermsComboX)
        'AukF.AddComboToAnother(Me.SubjectCombo, Me.SubCombox)
        '
fe:
        If Trim(Acc) = "" Then
            Acc = InputBox("Please type UserName...", "UserName...", Acc)
        End If
        If Trim(Acc) = "" Then GoTo fe
        SFC("User")
        STC(Acc)
        GSql.Sql_Gr_LikeUse_False("*", "SavedTopic", "", Me.AuksoftDataSet1)
        AukF.XPAuk(Me)
        AukSql.A_SqlAuk_FindAnd_Add("*", "acc2sublst", Me.AuksoftDataSet1)
        'If Acc.ToLower = "auk" Then
        '    Me.DeveloperUpdateSeniorMarksObtainToolStripMenuItem.Visible = True
        'End If
        ClassTextBox_TextChanged(sender, e)

        'Decide()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click

    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        MainFrm.Show()
        Me.Close()

    End Sub

    Private Sub SavedTopicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavedTopicBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SavedTopicBindingSource.EndEdit()
            Me.SavedTopicTableAdapter.Update(Me.AuksoftDataSet1.SavedTopic)

        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SavedTopicBindingSource.AddNew()
        Me.SavedTopicBindingSource.EndEdit()
        Me.AuksoftDataSet1.SavedTopic.Item(Me.SavedTopicBindingSource.Position).Item(1) = Acc
b:
        d = Trim(InputBox("Type your Saved Topic Name...", "Saved topic", d))
        If d = "" Then GoTo b
        Me.AuksoftDataSet1.SavedTopic.Item(Me.SavedTopicBindingSource.Position).Item(2) = d
fe:
        If Trim(Acc) = "" Then
            Acc = InputBox("Please type UserName...", "UserName...", Acc)
        End If
        If Trim(Acc) = "" Then GoTo fe
        Me.AuksoftDataSet1.SavedTopic.Item(Me.SavedTopicBindingSource.Position).Item(1) = Acc
        Try
            Me.SavedTopicBindingSource.EndEdit()
            Me.SavedTopicTableAdapter.Update(Me.AuksoftDataSet1.SavedTopic)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SavedTopicBindingSource.EndEdit()
        Me.AuksoftDataSet1.SavedTopic.Item(Me.SavedTopicBindingSource.Position).Item(1) = Acc
b:
        d = Trim(InputBox("Type your Saved Topic Name...", "Saved topic", d))
        If d = "" Then GoTo b
        Me.AuksoftDataSet1.SavedTopic.Item(Me.SavedTopicBindingSource.Position).Item(2) = d
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.SavedTopicBindingSource.CancelEdit()
        Me.AuksoftDataSet1.SavedTopic.RejectChanges()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SavedTopicBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SavedTopicBindingNavigatorSaveItem_Click(sender, e)
        'Me.ContextMenuStrip2.Show(Me.MousePosition.X, Me.MousePosition.Y)
        AukF2.ContextShow(Me.ContextMenuStrip2)

    End Sub
    Public Sub Decide()
        c = Me.ComboBox1.FindStringExact(Me.TermTextBox.Text)
        If c = -1 Then
            MsgBox("Please Select a valid TermForm List...", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Me.ComboBox1.SelectedIndex = c

            If c = 2 Or c = 3 Then
                Trd = True
            Else
                Trd = False
            End If
        End If
        'MsgBox(Trd)
        If Ac1Sec = True Then
        Else
            AukSql.A_SqlAuk_FindAnd_Add("*", "acc2sublst", Me.AuksoftDataSet1)
            c = Me.SubjectCombo.FindStringExact(Me.SubjectTextBox.Text)
            If c > -1 Then
                Me.SubjectCombo.SelectedIndex = c
                SubPos = 5 + (Val(c))
                'MsgBox(SubPos)
            Else
                MsgBox("There are some problems in Subject Please Select Subject From List...", MsgBoxStyle.Critical)

            End If
        End If
        GTxt = Me.Group.Text

        ClasT = Me.ClassTextBox.Text
        Yearx = Me.YearTextBox.Text
        Sec = Me.SectionTextBox.Text
        Subject = Me.SubjectCombo.Text
        Shift = Me.ShiftTextBox.Text
        Term = Me.TermTextBox.Text
        'MrkT = Me.CheckBox1.Checked
        'If MrkT = True Then
        '    Sign = Me.SignTextBox.Text
        '    Marks = Me.MarksTextBox.Text
        'End If
        ClassTextBox_TextChanged(sender, e)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Clxy As Double
        Clxy = Val(Me.ClassTextBox.Text)

        If Clxy >= 3 And Clxy <= 8 Then
            AukF2.ContextShow(Me.ContextMenuStrip2)
        Else
            If Me.Group.Text.ToLower = "human" Or Me.Group.Text.ToLower = "science" Or Me.Group.Text.ToLower = "commerce" Then
                AukF2.ContextShow(Me.ContextMenuStrip2)

            Else
                ClassOptions.Show()
                ClassOptions.Activate()
                MsgBox("Please Select Class Section Subject....", MsgBoxStyle.Information)


            End If
        End If


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Me.ShiftTextBox.Text = Me.ComboBox2.Text
        ClassTextBox_TextChanged(sender, e)

    End Sub

    Private Sub SubjectCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCombo.SelectedIndexChanged
        Me.SubjectTextBox.Text = Me.SubjectCombo.Text
        If Ac1Sec = False Then
            If (Val(Me.ClassTextBox.Text) < 6) And (Val(Me.ClassTextBox.Text) >= 3) Then
                If Me.SubjectCombo.SelectedIndex > 9 Then
                    MsgBox("They have only Ten Subjects ....", MsgBoxStyle.Critical)
                    Me.SubjectCombo.SelectedIndex = 9

                End If
            End If


        End If
        'If Val(Me.ClassTextBox.Text) = 11 Or Val(Me.ClassTextBox.Text) = 12 Then
        '    If Me.Group.Text.ToLower = "human" Or Me.Group.Text.ToLower = "science" Or Me.Group.Text.ToLower = "commerce" Then
        '        If AukF2.BindFind(Me.SubjectPositionBindingSource, "Subject", sender.text) = False Then
        '            MsgBox("Please select a subject which is include in '" & Me.Group.Text & "' section subject.", MsgBoxStyle.Critical)
        '        Else
        '            MsgBox(ComRow)

        '        End If
        '    End If

        'End If
    End Sub

    Private Sub SubjectCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubjectCombo.SelectionChangeCommitted
        Me.SubjectTextBox.Text = Me.SubjectCombo.Text
        ClassTextBox_TextChanged(sender, e)
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.SignTextBox.Text = Me.ComboBox3.Text

    End Sub

    Private Sub ClassTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTextBox.TextChanged
        Dim ey As Integer
        If Val(Me.ClassTextBox.Text) > 8 Then
            Me.Label2.Text = "Senior Section"
           
            Ac1Sec = True
            sh = Me.ShiftTextBox.Text
            egb = Me.SectionTextBox.Text

            If (Trim(sh) <> "") And (Trim(egb) <> "") Then
                gu = Me.ClassTextBox.Text & "-" & egb & sh
                ey = Me.ClassOptionsBindingSource.Find("ClassSection", gu)
                'MsgBox(gu, , ey)

                If ey > -1 Then
                    mpx = Me.AuksoftDataSet1.ClassOptions(ey).Item(4).ToString()
                    If mpx = "" Then
                        Me.Group.Text = "No Subject is Selected ... Insert from [ClassOptions]"

                    Else
                        Me.Group.Text = mpx

                    End If
                Else
                    Me.Group.Text = "No Subject is Selected ... Insert from [ClassOptions]"

                End If
            Else
                ey = Me.ClassOptionsBindingSource.Find("Class", Me.ClassTextBox.Text)
                mpx = Me.AuksoftDataSet1.ClassOptions(ey).Item(4).ToString()
                If ey > -1 Then
                    If mpx = "" Then
                        Me.Group.Text = "No Subject is Selected ... Insert from [ClassOptions]"

                    Else
                        Me.Group.Text = mpx

                    End If
                Else
                    Me.Group.Text = "No Subject is Selected ... Insert from [ClassOptions]"

                End If
            End If
            GTxt = Me.Group.Text
            If Trim(GTxt) = "" Or Trim(LCase(GTxt)) = "none" Then
                Me.SubjectEditorToolStripMenuItem1.Visible = False
            Else
                Me.SubjectEditorToolStripMenuItem1.Visible = True
            End If
            If Val(Me.ClassTextBox.Text) = 9 Or Val(Me.ClassTextBox.Text) = 10 Then
                If Me.Group.Text.ToLower = "human" Then
                    Me.SubLstFor9_Human.Visible = True
                    Me.SublstFor9_Science.Visible = False
                    Me.SubjectCombo.Visible = False
                    'Me.Print("human")
                    'Me.Text = "human "

                ElseIf Me.Group.Text.ToLower = "science" Then
                    Me.SublstFor9_Science.Visible = True
                    Me.SubLstFor9_Human.Visible = False
                    Me.SubjectCombo.Visible = False

                End If
            ElseIf Val(Me.ClassTextBox.Text) = 11 Or Val(Me.ClassTextBox.Text) = 12 Then
                If Me.Group.Text.ToLower = "science" Or Me.Group.Text.ToLower = "human" Or Me.Group.Text.ToLower = "commerce" Then
                    'Me.SubjectPositionBindingSource.Filter = "[subject]='" & GTxt & "'"
                    Me.SubjectCombo.DataSource = Me.SubjectPositionBindingSource
                    Me.SubjectCombo.DisplayMember = "Subject"
                End If
                Me.SublstFor9_Science.Visible = False
                Me.SubLstFor9_Human.Visible = False
                Me.SubjectCombo.Visible = True
            End If
        ElseIf (Val(Me.ClassTextBox.Text) <= 8) And (Val(Me.ClassTextBox.Text) >= 3) Then
            '
            Me.SublstFor9_Science.Visible = False
            Me.SubLstFor9_Human.Visible = False
            Me.SubjectCombo.Visible = True
            Me.Group.Visible = False
            Me.Group.Text = ""
            Me.SubjectEditorToolStripMenuItem1.Visible = False
            Me.Label2.Text = "Junior Section"
            Ac1Sec = False

            Me.SubjectCombo.DataSource = Me.AuksoftDataSet1.Acc2SubLst
            Me.SubjectCombo.DisplayMember = "Lst"

        End If
        AukF2.ComSelIndex(Me.SubjectCombo)
        AukF2.ComSelIndex(Me.SubLstFor9_Human)
        AukF2.ComSelIndex(Me.SublstFor9_Science)
        GTxt = Me.Group.Text

        If Me.Group.Text = "" Then Me.Group.Visible = False Else Me.Group.Visible = True


    End Sub

    Private Sub TermTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TermTextBox.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.Text = "Test" Then
            If Me.ClassTextBox.Text = 12 Or Me.ClassTextBox.Text = 10 Then
                Me.TermTextBox.Text = "Test"
            Else
                Me.TermTextBox.Text = ""
            End If
        Else
            Me.TermTextBox.Text = Me.ComboBox1.Text
        End If


    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If Me.ComboBox1.Text = "Test" Then
            If Me.ClassTextBox.Text = 12 Or Me.ClassTextBox.Text = 10 Then
                Me.TermTextBox.Text = "Test"
            Else
                Me.TermTextBox.Text = ""
            End If
        Else
            Me.TermTextBox.Text = Me.ComboBox1.Text
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Informations.Show()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ClassTextBox_TextChanged(sender, e)
        If Val(Me.ClassTextBox.Text) = 11 Or Val(Me.ClassTextBox.Text) = 12 Then
            If Me.Group.Text.ToLower = "science" Then
                'MsgBox("ok")
                Me.SubjectPositionBindingSource.Filter = "[group]='" & Me.Group.Text & "' and [class] = '" & Me.ClassTextBox.Text & "'"
            ElseIf Me.Group.Text.ToLower = "human" Then
                Me.SubjectPositionBindingSource.Filter = "[group]='" & Me.Group.Text & "' and [class] = '" & Me.ClassTextBox.Text & "'"
            ElseIf Me.Group.Text.ToLower = "commerce" Then
                Me.SubjectPositionBindingSource.Filter = "[group]='" & Me.Group.Text & "' and [class] = '" & Me.ClassTextBox.Text & "'"
            End If
        End If
      
    End Sub

    Private Sub ContextMenuStrip1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ContextMenuStrip1.KeyDown
        'MsgBox(Keys.A)

        'If e.KeyCode = Keys.A Then
        '    MsgBox("A")

        'End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        Me.ClassTextBox.Text = Me.ToolStripTextBox1.Text

    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click


    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Me.ShiftTextBox.Text = ToolStripComboBox1.Text

    End Sub

    Private Sub SavedTopicBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavedTopicBindingNavigator.RefreshItems

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button4_Click(sender, e)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SavedTopicBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub SaveNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveNewToolStripMenuItem.Click
        Me.SavedTopicBindingSource.AddNew()
        Me.SavedTopicBindingSource.EndEdit()

    End Sub

    Private Sub OpenAndSavedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAndSavedToolStripMenuItem.Click
        SavedTopicBindingNavigatorSaveItem_Click(sender, e)
        Button4_Click(sender, e)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TermEditor.Show()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AukSql.A_SqlAuk_FindAnd_Add("*", "Terms", Me.AuksoftDataSet1)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Decide()
        'Me.Hide()

        OtherEntryForm.Show()
        OtherEntryForm.Opener()

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        OtherEntryForm.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Informations.Show()

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        'TermEditor.Show()
        QueryManager_Load(sender, e)

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        If AukF.MsgTr(What & "ExitFromSoft...?") = True Then
            End

        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        If AukF.MsgTr(What & "ExitFromQueryManager...?") = True Then
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        Me.SectionTextBox.Text = Me.ToolStripTextBox2.Text
    End Sub

    Private Sub OpenCommentsOthersInformationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentsEntryToolStripMenuItem.Click
        Button6_Click(sender, e)

    End Sub

    Private Sub OpenResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultEntryToolStripMenuItem.Click
        'Dim xp As Terminal2

        Decide()
        'MsgBox(GTxt)

        If Ac1Sec = True Then
            Terminal.Show()
            Terminal.Opener()

        Else
            Terminal2.Show()
            Terminal2.Text = "Terminal Junior( " & Term & " )"
            Terminal2.NamedOFForm.Text = "Terminal Junior( " & Term & " )"
            Terminal2.Opener()


            'Terminal2.Show()
            'Terminal2.Opener()

        End If
        'Me.Hide()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MarksDivionNadGiveTheTotalNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksDistrubitionToolStripMenuItem.Click
        Decide()
        Marks_Division.Show()
        Marks_Division.Opener()

    End Sub

    Private Sub PositionGeneratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PositionGeneratorToolStripMenuItem1.Click
        Decide()
        PositionGenerator.Show()
        PositionGenerator.Opener()
    End Sub

    Private Sub ToolStripButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.SavedTopicTableAdapter.Fill(Me.AuksoftDataSet1.SavedTopic)
    End Sub

    Private Sub ClassOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassOptionsToolStripMenuItem1.Click
        ClassOptions.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click

        PrintOption.Show()
        'For I = 0 To 100
        '    PrintOption.Opacity = I
        'Next

    End Sub

    Private Sub DeveloperUpdateSeniorMarksObtainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xp As Terminal2
        gy = InputBox("Type AukPassword to pass through the door...!", "Password", gy)
        If gy <> "updateneed" Then

            Exit Sub

        End If

        Decide()
        xp.Show()
        xp.Text = "Terminal Junior( " & Term & " )"
        xp.NamedOFForm.Text = "Terminal Junior( " & Term & " )"
        xp.Opener()

    End Sub

    Private Sub SectionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionTextBox.TextChanged
        ClassTextBox_TextChanged(sender, e)

    End Sub

    Private Sub SubjectEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectEditorToolStripMenuItem1.Click
        Decide()
        SubjectEditor.Show()

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        QueryManager_Load(sender, e)

    End Sub

    Private Sub OpenResultUnProgrammatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnProgrammaticResultviewToolStripMenuItem.Click
        Decide()

        FullViewResult.Show()
        FullViewResult.Opener()

    End Sub

    Private Sub SubjectCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsCollectionToolStripMenuItem.Click
        Decide()
        SubjectCollection.Show()

    End Sub

    Private Sub ClassSubjectDivisionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Decide()

        SubjectsEditor.Show()
        SubjectsEditor.Activate()

    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Decide()

        ClassUpdates.Show()
        ClassUpdates.Activate()


    End Sub

    Private Sub SublstFor9_Science_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SublstFor9_Science.SelectedIndexChanged

    End Sub

    Private Sub SublstFor9_Science_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles SublstFor9_Science.SelectionChangeCommitted
        Me.SubjectTextBox.Text = sender.text

    End Sub

    Private Sub SubLstFor9_Human_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubLstFor9_Human.SelectedIndexChanged

    End Sub

    Private Sub SubLstFor9_Human_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubLstFor9_Human.SelectionChangeCommitted
        Me.SubjectTextBox.Text = sender.text

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        mq = InputBox("Please Type Topic Name...", "Topic Name to Change", mq)
        Me.AuksoftDataSet1.SavedTopic(Me.SavedTopicBindingSource.Position).SavedTopic = mq

    End Sub
End Class