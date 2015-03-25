Public Class Ctmarks
    'Dim opx As Boolean
    Dim ValTab As String

    Private Sub ClassTestBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTestBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description)
            'MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub Ctmarks_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.TermSTableAdapter.Fill(Me.AuksoftDataSet1.TermS)


    End Sub

    Private Sub Ctmarks_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'SubjectsEditor.Focus()
        'If e.CloseReason = CloseReason.ApplicationExitCall Then
        '    SubjectsEditor.Show()

        'End If

    End Sub

    Private Sub Ctmarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AukF.XPAuk(Me)


        'TODO: This line of code loads data into the 'AuksoftDataSet1.DefaultConvertNumbers' table. You can move, or remove it, as needed.
        'Me.DefaultConvertNumbersTableAdapter.Fill(Me.AuksoftDataSet1.DefaultConvertNumbers)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        'Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)
        'Me.InformationIDBindingSource.Clear()

        'TODO: This line of code loads data into the 'AuksoftDataSet1.AvarageNumberofClassTest' table. You can move, or remove it, as needed.
        'Me.AvarageNumberofClassTestTableAdapter.Fill(Me.AuksoftDataSet1.AvarageNumberofClassTest)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectsCollection' table. You can move, or remove it, as needed.
        Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.TermS' table. You can move, or remove it, as needed.
        Me.SubjectCodeTextbox.Text = Me.AuksoftDataSet1.SubjectsCollection.Rows(0).Item(1).ToString

        'TODO: This line of code loads data into the 'AuksoftDataSet1.ClassTest' table. You can move, or remove it, as needed.
        'Me.ClassTestTableAdapter.Fill(Me.AuksoftDataSet1.ClassTest)
        'opx = False
        For I = 0 To Me.Xyz.Items.Count - 1
            If ce = "" Then
                ce = "[" & Me.Xyz.Items.Item(I) & "]"

            Else
                ce = ce & " , " & "[" & Me.Xyz.Items.Item(I) & "]"
            End If

        Next
        Me.TableTitlenametextbox.Text = ce
        Me.SubjectComboBox.SelectedIndex = 0
        Me.ComboBox5.SelectedIndex = 0
        'TabIndex = "17"
        Me.YearTextBox.Text = Year(Today)
        AukF.ComSelIndex(Me.tableCombo)
        ValTab = " ConvertedMarksTest-I  ConvertedMarksTest-II 2nd-ConvertedMarksTest-I 2nd-ConvertedMarksTest-II 3rd-ConvertedMarksTest-I 3rd-ConvertedMarksTest-II"



    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Me.ShiftTextBox.Text = Me.ComboBox5.Text
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.YearTextBox.Text = Year(Today)



    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCodeTextbox.TextChanged
        c = Me.SubjectsCollectionBindingSource.Find("codeno", Me.SubjectCodeTextbox.Text)
        If c <> -1 Then
            SubjectsCollectionBindingSource.Position = c

        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectionChangeCommitted
        Me.SubjectCodeTextbox.Text = Me.AuksoftDataSet1.SubjectsCollection.Rows(Me.SubjectComboBox.SelectedIndex).Item(1).ToString

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'TermEditor.Show()

    End Sub

    Private Sub ClassTestBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTestBindingNavigator.RefreshItems
        'MsgBox("Re")

        'c = Me.CollgenoT1.FindStringExact(Me.CollegeNoTextBox.Text)
        'If c > -1 Then
        '    Me.CollgenoT1.SelectedIndex = c

        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CauseTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Frm = Me
        SubjectsEditor.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Ctmarks_Load(sender, e)
        If Button14.Enabled = False Then
            Button14_Click(sender, e)

        End If
    End Sub

    Private Sub CauseCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.CauseTextBox.Text = Me.CauseCombo.Text

    End Sub

    Private Sub CauseCombo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.CauseTextBox.Text = Me.CauseCombo.Text
    End Sub

    Private Sub CauseCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.CauseTextBox.Text = Me.CauseCombo.Text
    End Sub

    Private Sub FindCollegenoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindCollegenoToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PrintBlankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBlankToolStripMenuItem.Click


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim mssd As New Copy_of_ClassTest
        'Dim mTable As New DataTable
        'mTable = Me.AuksoftDataSet1.InformationID.Copy
        mssd.Database.Tables("informationID").SetDataSource(Me.AuksoftDataSet1)
        ClassTextPrint.CrystalReportViewer1.ReportSource = mssd
        ClassTextPrint.Show()
    End Sub

    Private Sub ConvertedMarksTest_ILabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CollgenoT1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CollgenoT1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CollgenoT1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CollgenoComboBox.SelectionChangeCommitted
        'Me.ClassTestBindingSource.RemoveFilter()
        Try
            If CollgenoComboBox.Items.Count > 0 Then
                colw = Me.CollgenoComboBox.Text
                c = Me.ClassTestBindingSource.Find("Collegeno", Me.CollgenoComboBox.Text)

                'MsgBox(c)
                If c > -1 Then
                    Me.ClassTestBindingSource.Position = c
                    'Me.CollegeNoTextBox.Text = Me.CollgenoT1.Text
                ElseIf c = -1 Then
                    If Me.ClassTestBindingSource.Filter = "" Then
                        mainIDx = Me.SubjectComboBox.Text & colw & Me.Clas.Text & Me.SectionText.Text & Me.YearTextBox.Text & Me.ComboBox5.Text
                        Me.ClassTestBindingSource.AddNew()
                        Me.ClassTestBindingSource.EndEdit()
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(6) = Me.SubjectComboBox.Text
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(4) = Me.Clas.Text
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(5) = Me.SectionText.Text
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(1) = Me.YearTextBox.Text
                        Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Shift = Me.ComboBox5.Text
                        Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).MainID = mainIDx
                        Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).CollegeNo = colw

                        'Me.CollegeNoTextBox.Text = Me.CollgenoComboBox.Text
                        'Me.ShiftTextBox.Text = Me.ComboBox5.Text
                    Else
                        MsgBox("Please Remove Filter then Select....", MsgBoxStyle.Critical)

                    End If


                End If
            End If
        Catch ex As Exception
            Epx()


        End Try

    End Sub
    Public Sub Input2(ByVal Col As String)
        Try
            If CollgenoComboBox.Items.Count > 0 Then
                colw = Col
                c = Me.ClassTestBindingSource.Find("Collegeno", Col)

                'MsgBox(c)
                If c = -1 Then
                    If Me.ClassTestBindingSource.Filter = "" Then
                        mainIDx = Me.SubjectComboBox.Text & colw & Me.Clas.Text & Me.SectionText.Text & Me.YearTextBox.Text & Me.ComboBox5.Text
                        Me.ClassTestBindingSource.AddNew()
                        Me.ClassTestBindingSource.EndEdit()
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(6) = Me.SubjectComboBox.Text
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(4) = Me.Clas.Text
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(5) = Me.SectionText.Text
                        Me.AuksoftDataSet1.ClassTest.Rows(Me.ClassTestBindingSource.Position).Item(1) = Me.YearTextBox.Text
                        Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Shift = Me.ComboBox5.Text
                        Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).MainID = mainIDx
                        Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).CollegeNo = colw

                        'Me.CollegeNoTextBox.Text = Me.CollgenoComboBox.Text
                        'Me.ShiftTextBox.Text = Me.ComboBox5.Text
                    Else
                        'MsgBox("Please Remove Filter then Select....", MsgBoxStyle.Critical)

                    End If

                End If

            End If

        Catch ex As Exception
            Epx()


        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        DatagridClasstest.ClassTestDataGridView.DataSource = Me.AuksoftDataSet1
        DatagridClasstest.ClassTestDataGridView.DataMember = "ClassTest"
        'DatagridClasstest.ChgView.DataSource = Me.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        'DatagridClasstest.ChgView.DataMember = "ClassTest"

        DatagridClasstest.DeletedRows.DataSource = Me.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Deleted)
        'DatagridClasstest.DeletedRows.DataMember = "ClassTest"
        DatagridClasstest.ChangeRowsDatagrid.DataSource = Me.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        DatagridClasstest.ErrorRows.DataSource = Me.AuksoftDataSet1.ClassTest.GetErrors

        'DatagridClasstest.ClassTestBindingSource.DataSource = Me.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        DatagridClasstest.Show()

    End Sub

    Private Sub CollgenoT1Find_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CollgenoT1Find.KeyDown, Test_ITextBox.KeyDown, Test_IITextBox.KeyDown, Cause1Combo.KeyDown
        Try
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollgenoT1Find.Name
                    If e.KeyCode = Keys.Enter Then
                        If Me.RadioButton2.Checked = True Then
                            Me.Test_ITextBox.Focus()
                        End If
                        If Me.RadioButton3.Checked = True Then
                            Me.Test_IITextBox.Focus()
                        End If
                        If Me.RadioButton1.Checked = True Then
                            Me.Test_ITextBox.Focus()
                        End If
                    End If
                    If e.KeyCode = Keys.Right Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If
                    If e.KeyCode = Keys.Left Then
                        Me.ClassTestBindingSource.MovePrevious()
                    End If


                Case Me.Test_ITextBox.Name
                    If Me.RadioButton2.Checked = True Then
                        If e.KeyCode = Keys.Enter Then
                            Me.ClassTestBindingSource.MoveNext()
                        Else
                            If e.KeyCode = Keys.Enter Then
                                Me.Test_IITextBox.Focus()
                            End If
                        End If
                    End If
                    If e.KeyCode = Keys.Right Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If
                    If e.KeyCode = Keys.Left Then
                        Me.ClassTestBindingSource.MovePrevious()
                    End If
                    If e.KeyCode = Keys.Enter Then
                        If Me.RadioButton1.Checked = True Then
                            Me.Test_IITextBox.Focus()
                        End If
                    End If
                Case Me.Test_IITextBox.Name
                    If e.KeyCode = Keys.Enter Then
                        If Me.RadioButton1.Checked = True Then
                            Me.CollgenoT1Find.Focus()
                        End If
                    End If
                    If Me.RadioButton3.Checked = True Then
                        If e.KeyCode = Keys.Enter Then
                            Me.ClassTestBindingSource.MoveNext()
                        End If
                    Else
                        If e.KeyCode = Keys.Enter Then
                            Me.CollgenoT1Find.Focus()
                        End If
                    End If
                    If e.KeyCode = Keys.Right Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If
                    If e.KeyCode = Keys.Left Then
                        Me.ClassTestBindingSource.MovePrevious()
                    End If
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CollgenoT1Find_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollgenoT1Find.TextChanged
        Try
            c = Me.ClassTestBindingSource.Find("collegeno", Me.CollgenoT1Find.Text)
            If c > -1 Then
                Me.ClassTestBindingSource.Position = C
                Me.CollgenoComboBox.SelectedIndex = Me.CollgenoComboBox.FindStringExact(CollgenoT1Find.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Test_IITextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Test_IITextBox.KeyDown
        'If e.KeyCode = Keys.Tab Then
        '    Me.CollgenoT1Find.Focus()
        'End If
    End Sub

    Private Sub Test_IITextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Test_IITextBox.KeyPress
        'If e.KeyChar = Chr(Asc(Keys.Tab)) Then
        '    Me.CollgenoT1Find.Focus()
        'End If
    End Sub

    Private Sub Test_IITextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Test_IITextBox.KeyUp

    End Sub

    Private Sub Test_IITextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test_IITextBox.TextChanged

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        SqlBuilder.CText = Me.SqlQuerytext
        xFrm = Me
        SqlBuilder.FirstStep("Classtest", Me.tableCombo.Text)
        mFrm.TableCombo.Items.Clear()
        For I = 0 To Me.tableCombo.Items.Count - 1
            'MsgBox(Me.tableCombo.Items.Item(I))
            mFrm.TableCombo.Items.Add(Me.tableCombo.Items.Item(I))
        Next
        VTab = ValTab
        mFrm.TableCombo.SelectedIndex = Me.tableCombo.SelectedIndex
    End Sub

    Private Sub tableCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tableCombo.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If AukF.InPText(Me.CauseTextBox) Then
        '    Me.CauseTextBox.Text = "None"
        'End If
        'If AukF.InPText(Me.Cause2TextBox) Then
        '    Me.CauseTextBox.Text = "None"
        'End If
        AukF.TextBoxColorDrmc(Me.Test_ITextBox)
        AukF.TextBoxColorDrmc(Me.Test_IITextBox)
        AukF.TextBoxColorDrmc(Me._2nd_Test_ITextBox)
        AukF.TextBoxColorDrmc(Me._2nd_Test_IITextBox)
        AukF.TextBoxColorDrmc(Me._3rd_Test_IITextBox)
        AukF.TextBoxColorDrmc(Me._3rd_Test_ITextBox)

        If Trim(Me.SqlQuerytext.Text) <> "" Then
            Me.SqlCommand.Text = "Select " & Me.TableTitlenametextbox.Text & " from classtest where " & Me.SqlQuerytext.Text & " Order by val(Collegeno)"
        Else
            Me.SqlCommand.Text = "Select " & Me.TableTitlenametextbox.Text & " from classtest " & Me.SqlQuerytext.Text & " Order by val(Collegeno)"

        End If
        If Nullval.Checked = False Then
            Nullval.ForeColor = Color.Red
        Else
            Nullval.ForeColor = Color.Black

        End If
        If Trim(Me.CauseTextBox.Text) = "" Then
            CauseTextBox.Text = "None"

        End If
        If Me.Cause1Combo.Text = "CauseAccepted" Then
            Me.Cause1Combo.ForeColor = Color.White
            Cause1Combo.BackColor = Color.Black
        ElseIf Me.Cause1Combo.Text = "%FromTerm" Then
            Me.Cause1Combo.ForeColor = Color.White
            Cause1Combo.BackColor = Color.Red
        ElseIf Me.Cause1Combo.Text = "None" Then
            Me.Cause1Combo.ForeColor = Color.Black
            Cause1Combo.BackColor = Color.White
        End If
        AukF.ComXDrmcClassTestColor(Me.Cause2Combo)
        AukF.ComXDrmcClassTestColor(Me.Cause3Combo)

        Me.CauseTextBox.BackColor = Me.Cause1Combo.BackColor
        Me.CauseTextBox.ForeColor = Me.Cause1Combo.ForeColor
        Me.Cause2TextBox.BackColor = Me.Cause2Combo.BackColor
        Me.Cause2TextBox.ForeColor = Me.Cause2Combo.ForeColor
        Me.Cause3TextBox.BackColor = Me.Cause3Combo.BackColor
        Me.Cause3TextBox.ForeColor = Me.Cause3Combo.ForeColor



        'Me.SqlCommand.ReadOnly = False
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SqlCommand.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilterTextBox.KeyDown
        Try
            If Me.Operators.SelectedIndex = -1 Then
                Me.Operators.SelectedIndex = 0
            End If
            'If Me.Operators.SelectedIndex = -1 Then
            '    Me.Operators.SelectedIndex = 0
            'End If
            AukF.ComSelIndex(Me.FilterQuality)
            AukF.ComSelIndex(Me.TabnameFilter)
            If AukF.FullWordFind(ValTab, Me.TabnameFilter.Text) Then
                'MsgBox(AukF.FullWordFind(ValTab, Me.tableCombo.Text))
                Me.FilterQuality.SelectedIndex = 1
            Else
                Me.FilterQuality.SelectedIndex = 0
                'MsgBox(AukF.FullWordFind(ValTab, Me.tableCombo.Text))

            End If
            If e.KeyCode = Keys.Enter Then
                If LCase(Me.FilterQuality.Text) = "value" Then
                    Me.ClassTestBindingSource.Filter = "[" & Me.TabnameFilter.Text & "]" & Me.Operators.Text & Me.FilterTextBox.Text

                Else

                    If Me.FilterExactWordCheckbox.Checked = True Then
                        Me.ClassTestBindingSource.Filter = "[" & Me.TabnameFilter.Text & "]" & " ='" & Me.FilterTextBox.Text & "'"
                    Else
                        Me.ClassTestBindingSource.Filter = "[" & Me.TabnameFilter.Text & "]" & " like '%" & Me.FilterTextBox.Text & "%'"
                    End If
                End If

            End If
        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterTextBox.TextChanged

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            If Trim(Me.SqlQuerytext.Text) = "" Then
                MsgBox("There is no Need to Open Whole Database...Please Query...", MsgBoxStyle.Critical)
                Exit Sub

            End If
            Me.AuksoftDataSet1.ClassTest.Clear()

            Adp = New OleDb.OleDbDataAdapter(Me.SqlCommand.Text, Cn)

            Adp.Fill(Me.AuksoftDataSet1.ClassTest)

        Catch ex As Exception
            AukMod.Epx()


        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.ClassTestBindingSource.RemoveFilter()


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GroupBox1.Enabled = True

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            If Nullval.Checked = True Then
                If xT(Me.Clas) = True Then
                    MsgBox("Class Text empty...")
                    Me.Clas.Focus()
                    Exit Sub
                End If
                If xT(Me.YearTextBox) = True Then
                    MsgBox("Year Text empty...")
                    Me.YearTextBox.Focus()
                    Exit Sub
                End If
                If xT(Me.SectionText) = True Then
                    MsgBox("Section Text empty...")
                    Me.SectionText.Focus()
                    Exit Sub
                End If
                If xT(Me.ShiftTextBox) = True Then
                    MsgBox("Shift Text empty...")
                    Me.ShiftTextBox.Focus()
                    Exit Sub
                End If
            End If
            SFC("StudentClass", "Class_Section", "Shift")
            STC(Me.Clas.Text, Me.SectionText.Text, Me.ShiftTextBox.Text)
            GSql.Sql_ORD_like_false("collegeno,[Name]", "InformationID", "val(collegeno)", Me.AuksoftDataSet1)
            'Me.CollegenoCombo.DataSource = Me.AuksoftDataSet1.InformationID
            'Me.CollegenoCombo.DisplayMember = "Collegeno"
            SFC("Class", "Section", "Shift", "Year", "Subjects")
            STC(Me.Clas.Text, Me.SectionText.Text, Me.ShiftTextBox.Text, Me.YearTextBox.Text, Me.SubjectComboBox.Text)
            GSql.Sql_ORD_like_false("*", "ClassTest", "val(collegeno)", Me.AuksoftDataSet1)
            'opx = True
            f = Replace(LCase(Sql), LCase("Select * from classtest where "), "", 1)
            c = Replace(LCase(f), LCase("ORDER BY val(collegeno)"), "", 1)

            Me.SqlQuerytext.Text = UCase(c)


            Me.GroupBox1.Enabled = False
            SFC("ExamQuality", "Class", "Subject")
            STC("Classtest", Me.Clas.Text, Me.SubjectComboBox.Text)
            GSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", Me.AuksoftDataSet1)
            If Me.DefaultConvertNumbersBindingSource.Count > 1 Then
                MsgBox("There are some Prob with TotalNumbers & convertNumbers Please Correct them...There more than one...Check Database...", MsgBoxStyle.Critical)

            End If
            EryNum()
            Me.CollgenoT1Find.Text = Me.CollegeNoTextBox.Text

        Catch ex As Exception
            'MsgBox(ex.Message)
            Epx2("Opening Problam Contact with Alim.... (0171-1334201,01717-829727)>>>")



        End Try

    End Sub

    Private Sub SetCurrentYearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetCurrentYearToolStripMenuItem.Click
        Me.YearTextBox.Text = Year(Today)

    End Sub

    Private Sub Test_ITextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test_ITextBox.TextChanged

    End Sub

    Private Sub ClassTestBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTestBindingSource.CurrentChanged
        ChgSor()
    End Sub
    Private Sub ChgSor()
        Me.MainIDTextBox.Text = Me.SubjectComboBox.Text & Me.CollegeNoTextBox.Text & Me.Clas.Text & Me.SectionText.Text & Me.YearTextBox.Text & Me.ShiftTextBox.Text
        Me.CollgenoT1Find.Text = Me.CollegeNoTextBox.Text
        Me.CollegenoF2.Text = Me.CollegeNoTextBox.Text
        Me.CollegenoF3.Text = Me.CollegeNoTextBox.Text
        EryNum()
        AukF.ComboFind(Me.Cause2Combo, Me.Cause2TextBox.Text, True)
        AukF.ComboFind(Me.Cause1Combo, Me.CauseTextBox.Text, True)
    End Sub
    Private Sub ClassTestBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles ClassTestBindingSource.ListChanged
        'ChgSor()
        AukF.ComboFind(Me.Cause2Combo, Me.Cause2TextBox.Text, True)
        AukF.ComboFind(Me.Cause1Combo, Me.CauseTextBox.Text, True)
        'Me.CollgenoT1Find.Text = Me.CollegeNoTextBox.Text
        'Me.CollegenoF2.Text = Me.CollegeNoTextBox.Text
        'Me.CollegenoF3.Text = Me.CollegeNoTextBox.Text
        'EryNum()
    End Sub

    Private Sub ClassTestBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassTestBindingSource.PositionChanged
        ChgSor()

    End Sub
    Private Sub EryNum()

        Me.ConvertedMarksTest_ITextBox.Text = AukF.RemovePoints(AukF.DrmcNumberCon(Me.Test_ITextBox.Text, Me.totalM.Text, Me.Converts.Text))
        Me.ConvertedMarksTest_IITextBox.Text = AukF.RemovePoints(AukF.DrmcNumberCon(Me.Test_IITextBox.Text, Me.totalM.Text, Me.Converts.Text))

        If Trim(Me.CauseTextBox.Text) = "" Or Me.CauseTextBox.Text = "None" Then
            Me.AvarageTextBox.Text = Val(ConvertedMarksTest_IITextBox.Text) + Val(ConvertedMarksTest_ITextBox.Text)
            Me.AvarageTextBox.Text = Me.AvarageTextBox.Text / 2
            Me.AvarageTextBox.Text = AukF.AukConverts_NumberPointConverts(Me.AvarageTextBox.Text)

        ElseIf Me.CauseTextBox.Text = "CauseAccepted" Then
            Me.AvarageTextBox.Text = AukF.AukConverts_NumberPointConverts(Val(ConvertedMarksTest_IITextBox.Text) + Val(ConvertedMarksTest_ITextBox.Text))

            'Me.AvarageTextBox.Text = Me.AvarageTextBox.Text / 2
        End If
        Me._2nd_ConvertedMarksTest_ITextBox.Text = AukF.RemovePoints(AukF.DrmcNumberCon(Me._2nd_Test_ITextBox.Text, Me.totalM.Text, Me.Converts.Text))
        Me._2nd_ConvertedMarksTest_IITextBox.Text = AukF.RemovePoints(AukF.DrmcNumberCon(Me._2nd_Test_IITextBox.Text, Me.totalM.Text, Me.Converts.Text))

        If Trim(Me.Cause2TextBox.Text) = "" Or Me.Cause2TextBox.Text = "None" Then
            Me.Avarage2TextBox.Text = Val(_2nd_ConvertedMarksTest_IITextBox.Text) + Val(_2nd_ConvertedMarksTest_ITextBox.Text)
            Me.Avarage2TextBox.Text = Me.Avarage2TextBox.Text / 2
            Me.Avarage2TextBox.Text = AukF.AukConverts_NumberPointConverts(Me.Avarage2TextBox.Text)

        ElseIf Me.Cause2TextBox.Text = "CauseAccepted" Then
            Me.Avarage2TextBox.Text = Val(_2nd_ConvertedMarksTest_IITextBox.Text) + Val(_2nd_ConvertedMarksTest_ITextBox.Text)
            Me.Avarage2TextBox.Text = AukF.AukConverts_NumberPointConverts(Me.Avarage2TextBox.Text)

            'Me.AvarageTextBox.Text = Me.AvarageTextBox.Text / 2
        End If
        Me._3rd_ConvertedMarksTest_ITextBox.Text = AukF.RemovePoints(AukF.DrmcNumberCon(Me._3rd_Test_ITextBox.Text, Me.totalM.Text, Me.Converts.Text))
        Me._3rd_ConvertedMarksTest_IITextBox.Text = AukF.RemovePoints(AukF.DrmcNumberCon(Me._3rd_Test_IITextBox.Text, Me.totalM.Text, Me.Converts.Text))

        If Trim(Me.cause3TextBox.Text) = "" Or Me.Cause3TextBox.Text = "None" Then
            Me.Avarage3TextBox.Text = Val(_3rd_ConvertedMarksTest_IITextBox.Text) + Val(_3rd_ConvertedMarksTest_ITextBox.Text)
            Me.Avarage3TextBox.Text = Me.Avarage3TextBox.Text / 2
            Me.Avarage3TextBox.Text = AukF.AukConverts_NumberPointConverts(Me.Avarage3TextBox.Text)

        ElseIf Me.Cause3TextBox.Text = "CauseAccepted" Then
            Me.Avarage3TextBox.Text = Val(_3rd_ConvertedMarksTest_IITextBox.Text) + Val(_3rd_ConvertedMarksTest_ITextBox.Text)
            Me.Avarage3TextBox.Text = AukF.AukConverts_NumberPointConverts(Me.Avarage3TextBox.Text)

            'Me.AvarageTextBox.Text = Me.AvarageTextBox.Text / 2
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Convert_and_Total.Show()

    End Sub

    Private Sub Cause1Combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cause1Combo.SelectedIndexChanged
        Me.CauseTextBox.Text = Cause1Combo.Text
    End Sub

    Private Sub Cause1Combo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cause1Combo.SelectionChangeCommitted
        Me.CauseTextBox.Text = Cause1Combo.Text

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        On Error Resume Next

        If Me.CollgenoComboBox.Items.Count > 0 Then
            For I = 0 To Me.CollgenoComboBox.Items.Count - 1
                m = Me.CollgenoComboBox.Items.Item(I).ToString
                Input2(m)
                'Me.MainIDTextBox.Text = Me.SubjectComboBox.Text & Me.CollegeNoTextBox.Text & Me.Clas.Text & Me.SectionText.Text & Me.YearTextBox.Text & Me.ShiftTextBox.Text
            Next
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim mssd As New ClassTest
        'Dim mTable As New DataTable
        'mTable = Me.AuksoftDataSet1.InformationID.Copy
        mssd.Database.Tables("ClassTest").SetDataSource(Me.AuksoftDataSet1)
        ClassTextPrint.CrystalReportViewer1.ReportSource = mssd
        ClassTextPrint.Show()
    End Sub

    Private Sub CollegenoF2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CollegenoF2.KeyDown, _2nd_Test_ITextBox.KeyDown, _2nd_Test_IITextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollegenoF2.Name
                    If Me.R2None.Checked Then
                        Me._2nd_Test_ITextBox.Focus()
                    ElseIf Me.R2T1.Checked Then
                        Me._2nd_Test_ITextBox.Focus()
                    ElseIf Me.R2T3.Checked Then
                        Me._2nd_Test_IITextBox.Focus()
                    End If
                Case Me._2nd_Test_ITextBox.Name
                    If Me.R2None.Checked Then
                        Me._2nd_Test_IITextBox.Focus()
                    ElseIf Me.R2T1.Checked Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If
                Case Me._2nd_Test_IITextBox.Name
                    If Me.R2None.Checked Then
                        Me.CollegenoF2.Focus()
                    ElseIf Me.R2T3.Checked Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If

            End Select
        End If
        If e.KeyCode = Keys.Right Then
            Me.ClassTestBindingSource.MoveNext()
        End If
        If e.KeyCode = Keys.Left Then
            Me.ClassTestBindingSource.MovePrevious()
        End If
        If e.KeyCode = Keys.Up Then
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollegenoF2.Name
                    Me._2nd_Test_IITextBox.Focus()
                Case Me._2nd_Test_ITextBox.Name
                    Me.CollegenoF2.Focus()
                Case Me._2nd_Test_IITextBox.Name
                    Me._2nd_Test_ITextBox.Focus()
            End Select
        End If
        If e.KeyCode = Keys.Down Then
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollegenoF2.Name
                    Me._2nd_Test_ITextBox.Focus()
                Case Me._2nd_Test_ITextBox.Name
                    Me._2nd_Test_IITextBox.Focus()
                Case Me._2nd_Test_IITextBox.Name
                    Me.CollegenoF2.Focus()
            End Select
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegenoF2.TextChanged
        c = Me.ClassTestBindingSource.Find("collegeno", Me.CollegenoF2.Text)
        If c > -1 Then
            Me.ClassTestBindingSource.Position = C
            Me.CollgenoComboBox.SelectedIndex = Me.CollgenoComboBox.FindStringExact(CollgenoT1Find.Text)
            xs = Me.CollgenoComboBox.FindStringExact(Me.CollegenoF2.Text)
            If xs > -1 Then
                Me.CollgenoComboBox.SelectedIndex = xs

            End If
        End If
    End Sub

    Private Sub _2nd_Test_ITextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _2nd_Test_ITextBox.TextChanged

    End Sub

    Private Sub Cause2Combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cause2Combo.SelectedIndexChanged
        Me.Cause2TextBox.Text = Cause2Combo.Text
    End Sub

    Private Sub Cause2Combo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cause2Combo.SelectionChangeCommitted
        Me.Cause2TextBox.Text = Me.Cause2Combo.Text
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Informations.Show()

    End Sub

    Private Sub NameCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NameCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        CollgenoT1_SelectionChangeCommitted(sender, e)

    End Sub

    Private Sub InsertSelectTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AbsentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox(Me.ContainsFocus.GetType()

    

    End Sub

    Private Sub AbsentToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsentToolStripMenuItem.Click
        If Me.Test_ITextBox.Focused = True Then
            Test_ITextBox.Text = "Absent"
        ElseIf Me.Test_IITextBox.Focused = True Then
            Test_IITextBox.Text = "Absent"
        ElseIf Me._2nd_Test_ITextBox.Focused = True Then
            _2nd_Test_ITextBox.Text = "Absent"
        ElseIf Me._2nd_Test_IITextBox.Focused = True Then
            Me._2nd_Test_IITextBox.Text = "Absent"
        ElseIf Me._3rd_Test_ITextBox.Focused = True Then
            _3rd_Test_ITextBox.Text = "Absent"
        ElseIf Me._3rd_Test_IITextBox.Focused = True Then
            Me._3rd_Test_IITextBox.Text = "Absent"
        End If
    End Sub

    Private Sub RefreshAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshAllToolStripMenuItem.Click
        Ctmarks_Load(sender, e)
        If Button14.Enabled = False Then
            Button14_Click(sender, e)

        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        EryNum()

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If Me.CollgenoComboBox.Items.Count > 0 Then
            For I = 0 To Me.CollgenoComboBox.Items.Count - 1
                Try
                    Me.CollgenoComboBox.SelectedIndex = I
                    CollgenoT1_SelectionChangeCommitted(sender, e)
                Catch ex As Exception
                    Exit Sub
                End Try
            Next
            Try
                Me.ClassTestBindingSource.EndEdit()
                Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            Catch ex As Exception
                Epx()
            End Try
        End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.ClassTestBindingSource.CancelEdit()

        Me.AuksoftDataSet1.ClassTest.RejectChanges()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Button16_Click(sender, e)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Me.ClassTestBindingSource.RemoveCurrent()
        Catch ex As Exception
            Epx()


        End Try

    End Sub

    Private Sub RejectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem.Click
        Me.ClassTestBindingSource.CancelEdit()

        Me.AuksoftDataSet1.ClassTest.RejectChanges()

    End Sub

    Private Sub GetChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetChangesToolStripMenuItem.Click
        ToolStripButton2_Click(sender, e)

    End Sub

    Private Sub SetAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAllToolStripMenuItem.Click
        Button14_Click(sender, e)

    End Sub

    Private Sub NextRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextRecordToolStripMenuItem.Click
        Me.ClassTestBindingSource.MoveNext()

    End Sub

    Private Sub PreviousRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousRecordToolStripMenuItem.Click
        Me.ClassTestBindingSource.MovePrevious()

    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click
 
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
 
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        m = Me.ClassTestBindingSource.Find("collegeno", ToolStripTextBox1.Text)
        If m > -1 Then
            ClassTestBindingSource.Position = m
            'CollgenoT1_SelectionChangeCommitted(sender, e)
         


        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        m = Me.NameCombo.FindString(ToolStripTextBox2.Text)
        If m > -1 Then
            NameCombo.SelectedIndex = m
            c = Me.ClassTestBindingSource.Find("Collegeno", Me.CollgenoComboBox.Text)
            If c > -1 Then Me.ClassTestBindingSource.Position = c
        End If
    End Sub

    Private Sub ToolStripSeparator5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        ClassTestBindingNavigatorSaveItem_Click(sender, e)

    End Sub

    Private Sub CollgenoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollgenoComboBox.SelectedIndexChanged

    End Sub

    Private Sub CollgenoComboBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CollgenoComboBox.SelectionChangeCommitted

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        'TextBox1_KeyDown(sender, e)
        Try
            If Me.Operators.SelectedIndex = -1 Then
                Me.Operators.SelectedIndex = 0
            End If
            'If Me.Operators.SelectedIndex = -1 Then
            '    Me.Operators.SelectedIndex = 0
            'End If
            AukF.ComSelIndex(Me.FilterQuality)
            AukF.ComSelIndex(Me.TabnameFilter)
            If AukF.FullWordFind(ValTab, Me.TabnameFilter.Text) Then
                'MsgBox(AukF.FullWordFind(ValTab, Me.tableCombo.Text))
                Me.FilterQuality.SelectedIndex = 1
            Else
                Me.FilterQuality.SelectedIndex = 0
                'MsgBox(AukF.FullWordFind(ValTab, Me.tableCombo.Text))

            End If
            'If e.KeyCode = Keys.Enter Then
            If LCase(Me.FilterQuality.Text) = "value" Then
                Me.ClassTestBindingSource.Filter = "[" & Me.TabnameFilter.Text & "]" & Me.Operators.Text & Me.FilterTextBox.Text

            Else

                If Me.FilterExactWordCheckbox.Checked = True Then
                    Me.ClassTestBindingSource.Filter = "[" & Me.TabnameFilter.Text & "]" & " ='" & Me.FilterTextBox.Text & "'"
                Else
                    Me.ClassTestBindingSource.Filter = "[" & Me.TabnameFilter.Text & "]" & " like '%" & Me.FilterTextBox.Text & "%'"
                End If
            End If

            'End If
        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub NameCombo_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameCombo.SelectedIndexChanged

    End Sub

    Private Sub ComboBox5_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectionChangeCommitted
        Me.ShiftTextBox.Text = Me.ComboBox5.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cause3Combo.SelectedIndexChanged
        Me.Cause3TextBox.Text = Cause3Combo.Text
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cause3Combo.SelectionChangeCommitted
        Me.Cause3TextBox.Text = Me.Cause3Combo.Text

    End Sub

    Private Sub _3rd_Test_ITextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _3rd_Test_ITextBox.KeyDown, _3rd_Test_IITextBox.KeyDown, CollegenoF3.KeyDown

        If e.KeyCode = Keys.Enter Then
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollegenoF3.Name
                    If Me.T3None.Checked Then
                        Me._3rd_Test_ITextBox.Focus()
                    ElseIf Me.T3r2.Checked Then
                        Me._3rd_Test_ITextBox.Focus()
                    ElseIf Me.T3R3.Checked Then
                        Me._3rd_Test_IITextBox.Focus()
                    End If
                Case Me._3rd_Test_ITextBox.Name
                    If Me.T3None.Checked Then
                        Me._3rd_Test_IITextBox.Focus()
                    ElseIf Me.T3r2.Checked Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If
                Case Me._3rd_Test_IITextBox.Name
                    If Me.T3None.Checked Then
                        Me.CollegenoF3.Focus()
                    ElseIf Me.T3R3.Checked Then
                        Me.ClassTestBindingSource.MoveNext()
                    End If

            End Select
        End If
        If e.KeyCode = Keys.Right Then
            Me.ClassTestBindingSource.MoveNext()
        End If
        If e.KeyCode = Keys.Left Then
            Me.ClassTestBindingSource.MovePrevious()
        End If
        If e.KeyCode = Keys.Up Then
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollegenoF3.Name
                    Me._3rd_Test_IITextBox.Focus()
                Case Me._3rd_Test_ITextBox.Name
                    Me.CollegenoF3.Focus()
                Case Me._3rd_Test_IITextBox.Name
                    Me._3rd_Test_ITextBox.Focus()
            End Select
        End If
        If e.KeyCode = Keys.Down Then
            Select Case DirectCast(sender, TextBox).Name
                Case Me.CollegenoF3.Name
                    Me._3rd_Test_ITextBox.Focus()
                Case Me._3rd_Test_ITextBox.Name
                    Me._3rd_Test_IITextBox.Focus()
                Case Me._3rd_Test_IITextBox.Name
                    Me.CollegenoF3.Focus()
            End Select
        End If
    End Sub

    Private Sub _3rd_Test_ITextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _3rd_Test_ITextBox.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub CollegenoF3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegenoF3.TextChanged

    End Sub

    Private Sub ExitFromSoftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitFromSoftToolStripMenuItem.Click
        If MsgBox("Do you to exit from Soft...Please Save before Exit....Click Yes to Exit Now!", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End

        End If
    End Sub

    Private Sub CauseAcceptedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CauseAcceptedToolStripMenuItem.Click
        'If Me.CollegenoF3.Focused Or Me._3rd_Test_IITextBox.Focused Or Me._3rd_Test_ITextBox.Focused Or Me.Avarage3TextBox.Focused Or Me.Cause3Combo.Focused Or Me.Cause3TextBox.Focused Or Me._3rd_ConvertedMarksTest_IITextBox.Focused Or Me._3rd_ConvertedMarksTest_ITextBox.Focused Then

        If Me.CollegenoF3.Focused Or Me._3rd_Test_IITextBox.Focused Or Me._3rd_Test_ITextBox.Focused Or Me.Avarage3TextBox.Focused Or Me.Cause3Combo.Focused Or Me.Cause3TextBox.Focused Or Me._3rd_ConvertedMarksTest_IITextBox.Focused Or Me._3rd_ConvertedMarksTest_ITextBox.Focused Then
            Me.Cause3Combo.SelectedIndex = 1
        ElseIf Me.CollegenoF2.Focused Or Me._2nd_Test_IITextBox.Focused Or Me._2nd_Test_ITextBox.Focused Or Me.Avarage2TextBox.Focused Or Me.Cause2Combo.Focused Or Me.Cause2TextBox.Focused Or Me._2nd_ConvertedMarksTest_IITextBox.Focused Or Me._2nd_ConvertedMarksTest_ITextBox.Focused Then
            Me.Cause2Combo.SelectedIndex = 1
        ElseIf Me.CollgenoT1Find.Focused Or Me.Test_IITextBox.Focused Or Me.Test_ITextBox.Focused Or Me.AvarageTextBox.Focused Or Me.Cause1Combo.Focused Or Me.CauseTextBox.Focused Or Me.ConvertedMarksTest_ITextBox.Focused Or Me.ConvertedMarksTest_IITextBox.Focused Then
            Me.Cause1Combo.SelectedIndex = 1

        End If
    End Sub

    Private Sub FromTermToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FromTermToolStripMenuItem.Click
        'TabPage1.Focus()
        'MsgBox(TabPage1.Focused)






        If Me.CollegenoF3.Focused Or Me._3rd_Test_IITextBox.Focused Or Me._3rd_Test_ITextBox.Focused Or Me.Avarage3TextBox.Focused Or Me.Cause3Combo.Focused Or Me.Cause3TextBox.Focused Or Me._3rd_ConvertedMarksTest_IITextBox.Focused Or Me._3rd_ConvertedMarksTest_ITextBox.Focused Then
            Me.Cause3Combo.SelectedIndex = 2
        ElseIf Me.CollegenoF2.Focused Or Me._2nd_Test_IITextBox.Focused Or Me._2nd_Test_ITextBox.Focused Or Me.Avarage2TextBox.Focused Or Me.Cause2Combo.Focused Or Me.Cause2TextBox.Focused Or Me._2nd_ConvertedMarksTest_IITextBox.Focused Or Me._2nd_ConvertedMarksTest_ITextBox.Focused Then
            Me.Cause2Combo.SelectedIndex = 2
        ElseIf Me.CollgenoT1Find.Focused Or Me.Test_IITextBox.Focused Or Me.Test_ITextBox.Focused Or Me.AvarageTextBox.Focused Or Me.Cause1Combo.Focused Or Me.CauseTextBox.Focused Or Me.ConvertedMarksTest_ITextBox.Focused Or Me.ConvertedMarksTest_IITextBox.Focused Then
            Me.Cause1Combo.SelectedIndex = 2

        End If
    End Sub

    Private Sub NoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneToolStripMenuItem.Click

        If Me.CollegenoF3.Focused Or Me._3rd_Test_IITextBox.Focused Or Me._3rd_Test_ITextBox.Focused Or Me.Avarage3TextBox.Focused Or Me.Cause3Combo.Focused Or Me.Cause3TextBox.Focused Or Me._3rd_ConvertedMarksTest_IITextBox.Focused Or Me._3rd_ConvertedMarksTest_ITextBox.Focused Then
            Me.Cause3Combo.SelectedIndex = 0
        ElseIf Me.CollegenoF2.Focused Or Me._2nd_Test_IITextBox.Focused Or Me._2nd_Test_ITextBox.Focused Or Me.Avarage2TextBox.Focused Or Me.Cause2Combo.Focused Or Me.Cause2TextBox.Focused Or Me._2nd_ConvertedMarksTest_IITextBox.Focused Or Me._2nd_ConvertedMarksTest_ITextBox.Focused Then
            Me.Cause2Combo.SelectedIndex = 0
        ElseIf Me.CollgenoT1Find.Focused Or Me.Test_IITextBox.Focused Or Me.Test_ITextBox.Focused Or Me.AvarageTextBox.Focused Or Me.Cause1Combo.Focused Or Me.CauseTextBox.Focused Or Me.ConvertedMarksTest_ITextBox.Focused Or Me.ConvertedMarksTest_IITextBox.Focused Then
            Me.Cause1Combo.SelectedIndex = 0

        End If
    End Sub

    Private Sub ClearSelectedTextBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSelectedTextBoxToolStripMenuItem.Click
        If Me.Test_ITextBox.Focused = True Then
            Test_ITextBox.Text = ""
        ElseIf Me.Test_IITextBox.Focused = True Then
            Test_IITextBox.Text = ""
        ElseIf Me._2nd_Test_ITextBox.Focused = True Then
            _2nd_Test_ITextBox.Text = ""
        ElseIf Me._2nd_Test_IITextBox.Focused = True Then
            Me._2nd_Test_IITextBox.Text = ""
        ElseIf Me._3rd_Test_ITextBox.Focused = True Then
            _3rd_Test_ITextBox.Text = ""
        ElseIf Me._3rd_Test_IITextBox.Focused = True Then
            Me._3rd_Test_IITextBox.Text = ""

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ClassTestMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTestMarksToolStripMenuItem.Click
        If MsgBox("Do you to exit from ClassTestMarks...Please Save before Exit....Click Yes to Exit Now!", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()


        End If
    End Sub
End Class