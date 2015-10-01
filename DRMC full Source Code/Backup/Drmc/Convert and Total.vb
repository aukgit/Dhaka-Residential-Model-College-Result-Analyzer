Public Class Convert_and_Total
    Dim Ko(6) As Object

    Private Sub DefaultConvertNumbersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
      
    End Sub


    Private Sub DefaultConvertNumbersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultConvertNumbersBindingNavigatorSaveItem.Click
        Try
            Me.MainIDTextBox.Text = Me.SubjectCombo.Text & "_" & Me.ClassTextBox.Text & "_" & Me.ExamQualityCombo.Text
            Me.SubjectTextBox.Text = Me.SubjectCombo.Text
            Me.ExamQualityTextBox.Text = Me.ExamQualityCombo.Text
            Me.Validate()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)


        Catch ex As Exception
            Ebx3(ex)

        End Try
    End Sub

    Private Sub Convert_and_Total_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)
            'TODO: This line of code loads data into the 'AuksoftDataSet1.DefaultConvertNumbers' table. You can move, or remove it, as needed.
            Me.DefaultConvertNumbersTableAdapter.Fill(Me.AuksoftDataSet1.DefaultConvertNumbers)
            Me.TextBox1.Text = Me.AuksoftDataSet1.SubjectsCollection.Rows(0).Item(1).ToString
            'MsgBox(Me.TabControl1.Controls.Count)

            AukSql.SqlAukLikeAnyWhere_Add("*", "Subjectscollection", Me.AuksoftDataSet11, True, True)


            c = Me.ExamQualityCombo.FindStringExact(Me.ExamQualityTextBox.Text)
            If c > -1 Then
                Me.ExamQualityCombo.SelectedIndex = c

            End If

        Catch ex As Exception
            AukMod.Ebx3(ex)
        End Try
        'TODO: This line of code loads data into the 'AuksoftDataSet1.DefaultTotalNumbersOfSubjects' table. You can move, or remove it, as needed.
        'Me.DefaultTotalNumbersOfSubjectsTableAdapter.Fill(Me.AuksoftDataSet1.DefaultTotalNumbersOfSubjects)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectsCollection' table. You can move, or remove it, as needed.
        Me.DataGridView1.ShowEditingIcon = True
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        c = Me.SubjectsCollectionBindingSource.Find("codeno", Me.TextBox1.Text)
        If c <> -1 Then
            SubjectsCollectionBindingSource.Position = c

        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCombo.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubjectCombo.SelectionChangeCommitted
        Me.TextBox1.Text = Me.AuksoftDataSet1.SubjectsCollection.Rows(Me.SubjectCombo.SelectedIndex).Item(1).ToString
    End Sub

    Private Sub DefaultConvertNumbersBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultConvertNumbersBindingSource.CurrentChanged
        DefaultConvertNumbersBindingSource_PositionChanged(sender, e)

    End Sub

    Private Sub DefaultConvertNumbersBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DefaultConvertNumbersBindingSource.CurrentItemChanged
        DefaultConvertNumbersBindingSource_PositionChanged(sender, e)

    End Sub

    Private Sub DefaultConvertNumbersBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles DefaultConvertNumbersBindingSource.ListChanged
        DefaultConvertNumbersBindingSource_PositionChanged(sender, e)

    End Sub

    Private Sub DefaultConvertNumbersBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DefaultConvertNumbersBindingSource.PositionChanged
        'Me.SubjectTextBox.Text = Me.ComboBox1.Text
        'Me.ExamQualityTextBox.Text = Me.ComboBox2.Text
        c = Me.ExamQualityCombo.FindStringExact(Me.ExamQualityTextBox.Text)
        If c > -1 Then
            Me.ExamQualityCombo.SelectedIndex = c

        End If
        c = Me.SubjectCombo.FindStringExact(Me.SubjectTextBox.Text)
        If c > -1 Then
            Me.SubjectCombo.SelectedIndex = c
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'AukF.CutWordLetter(Me.ListBox1, Me.ExamqualityListCombo.Text, "", True)

        AukF.UniqueAdd(Me.ListBox1, Me.ExamqualityListCombo.Text)
        If Me.ExamqualityListCombo.Items.Count > Me.ExamqualityListCombo.SelectedIndex + 1 Then
            Me.ExamqualityListCombo.SelectedIndex = Me.ExamqualityListCombo.SelectedIndex + 1
        Else
            Me.ExamqualityListCombo.SelectedIndex = 0
        End If

     

    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        'Dim u As DataRow
        If MsgBox("Before Please open whole database...Do you want to continue...?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If
        'Me.MainIDTextBox.Text = Me.SubjectCombo.Text & "_"  & Me.ClassTextBox.Text & "_"  & Me.ExamQualityCombo.Text
        Try
            'On Error Resume Next

            Ko(0) = Me.ExamQualityCombo.Text
            Ko(1) = Me.ClassTextBox.Text
            Ko(2) = Me.NumberTextBox.Text
            Ko(3) = Me.ConvertNumber.Text
            For I = 0 To Me.ListBox1.Items.Count - 1

                cw = Me.ListBox1.Items.Item(I).ToString & "_" & Ko(1) & "_" & Ko(0)

                c = Me.DefaultConvertNumbersBindingSource.Find("MainID", cw)
                'MsgBox(c, , cw)

                If c = -1 Then
                    Me.DefaultConvertNumbersBindingSource.AddNew()
                    Me.DefaultConvertNumbersBindingSource.EndEdit()
                    cx = Me.SubjectCombo.FindStringExact(Me.ListBox1.Items.Item(I))
                    If cx > -1 Then Me.SubjectCombo.SelectedIndex = cx

                    'u = Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position)
                    Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position).Item(2) = Ko(0)
                    Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position).Item(3) = Ko(1)
                    Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position).Item(4) = Me.ListBox1.Items.Item(I)
                    Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position).Item(5) = Ko(3)
                    Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position).Item(6) = Ko(2)
                    Me.AuksoftDataSet1.DefaultConvertNumbers.Rows(Me.DefaultConvertNumbersBindingSource.Position).Item(1) = cw

                    'Else
                    '      Me.DefaultConvertNumbersBindingSource.Position = cs
                    'MsgBox(Me.ListBox1.Items.Item(I))

                End If
     
                'Me.DefaultConvertNumbersBindingSource.EndEdit()
            Next
            DefaultConvertNumbersBindingNavigatorSaveItem_Click_1(sender, e)
        Catch ex As Exception
            Ebx3(ex)

        End Try
        c = Me.ExamQualityCombo.FindStringExact(Me.ExamQualityTextBox.Text)
        If c > -1 Then
            Me.ExamQualityCombo.SelectedIndex = c

        End If
        c = Me.SubjectCombo.FindStringExact(Me.SubjectTextBox.Text)
        If c > -1 Then
            Me.SubjectCombo.SelectedIndex = c
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.ListBox1.Items.Clear()

    End Sub

    Private Sub ConvertNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertNumber.TextChanged, SubjectTextBox.TextChanged, TextBox1.TextChanged, NumberTextBox.TextChanged, SubjectCombo.TextChanged, ExamQualityCombo.TextChanged, ConvertNumber.TextChanged
        Me.MainIDTextBox.Text = Me.SubjectCombo.Text & "_" & Me.ClassTextBox.Text & "_" & Me.ExamQualityCombo.Text

    End Sub

    Private Sub TabControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub TabPage1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPage1.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub Convert_and_Total_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub ToolStripButton8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton8.MouseEnter
        'ToolStripButton8.BackgroundImage = AukSoftware.My.Resources.Bluesky6
        'ToolStripButton8.BackColor = Color.Beige
        'ToolStripButton8.BackgroundImage = My.Resources.NewCur4


    End Sub

    Private Sub ToolStripButton8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton8.MouseHover
        'ToolStripButton8.BackColor = Color.LavenderBlush
        'ToolStripButton8.BackgroundImage = My.Resources.NewCur4
    End Sub

    Private Sub ToolStripButton8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton8.MouseLeave
        'ToolStripButton8.BackgroundImage = AukSoftware.My.Resources.Bluesky3
        'ToolStripButton8.BackColor = Color.Silver
    End Sub

    Private Sub DefaultConvertNumbersBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultConvertNumbersBindingNavigator.RefreshItems

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.DefaultConvertNumbersTableAdapter.Fill(Me.AuksoftDataSet1.DefaultConvertNumbers)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        STC(Me.TextBox12.Text)
        SFC(Me.ComboBox1.Text)
        If exactword.Checked = False Then
            GSql.Sql_ORD_likeUse("*", "DefaultConvertNumbers", "Subject", Me.AuksoftDataSet1)
        Else
            GSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "Subject", Me.AuksoftDataSet1)

        End If
        c = Me.ExamQualityCombo.FindStringExact(Me.ExamQualityTextBox.Text)
        If c > -1 Then
            Me.ExamQualityCombo.SelectedIndex = c

        End If
        c = Me.SubjectCombo.FindStringExact(Me.SubjectTextBox.Text)
        If c > -1 Then
            Me.SubjectCombo.SelectedIndex = c
        End If
      
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.DefaultConvertNumbersBindingSource.CancelEdit()
        Me.AuksoftDataSet1.DefaultConvertNumbers.RejectChanges()
        c = Me.ExamQualityCombo.FindStringExact(Me.ExamQualityTextBox.Text)
        If c > -1 Then
            Me.ExamQualityCombo.SelectedIndex = c

        End If
        c = Me.SubjectCombo.FindStringExact(Me.SubjectTextBox.Text)
        If c > -1 Then
            Me.SubjectCombo.SelectedIndex = c
        End If
    End Sub

    Private Sub BindingNavigatorSeparator2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorSeparator2.Click

    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems
        DefaultConvertNumbersBindingSource_PositionChanged(sender, e)

    End Sub

    Private Sub YesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesToolStripMenuItem.Click
        Try
            Me.DefaultConvertNumbersBindingSource.RemoveCurrent()
            'Me.DefaultConvertNumbersBindingSource.MoveNext()

        Catch ex As Exception
            Epx()

        End Try

        'Me.DataGridView1.Rows(1).Cells.Remove()


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim m As New DefaultNumbers
        m.SetDataSource(Me.AuksoftDataSet1)
        Me.CrystalReportViewer1.ReportSource = m

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        DefaultConvertNumbersBindingNavigatorSaveItem_Click_1(sender, e)

    End Sub

    Private Sub RejectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem.Click
        Button6_Click(sender, e)

    End Sub
End Class