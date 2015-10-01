Imports VB = Microsoft.VisualBasic
Public Class SubjectEditor
    Dim COnQua As String
    Dim SubIDS As String
    Dim QMainID As String
    Dim SubIDF As String
    Public Tms As String
    Dim Working As Boolean
    Dim Job As Integer
    Dim Yr As String
    Dim Clx, Grp As String
    Dim Subx As String
    Dim Shv As String
    Dim TR As String
    Dim Secx As String
    Dim SubPosX As Integer
    'Dim  As String
    Dim DefMain As String
    Dim T3rd As Boolean
    Dim Vid As String
    Dim SummaryID As String
    Dim AcBuil As Boolean = Ac1Sec
    Dim ki As Integer
    Dim Npd As New ListBox


    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SubjectOfStudentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If Me.AlsoUpdateStudentsSingleSubjectsWhenSaveToolStripMenuItem.Checked = True Then ToolStripButton2_Click(sender, e)
            Me.SubjectOfStudentsBindingSource.EndEdit()
            Me.SubjectOfStudentsTableAdapter.Update(Me.AuksoftDataSet1.SubjectOfStudents)
        Catch ex As Exception
            Epx()

        End Try


    End Sub
    Public Sub InputCol(ByVal Col As String, ByVal GotoPos As Boolean)
        Dim Nk As Integer
        'SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")Shift(" & Shv & ")"
        MainID = SubID & Col
        Nk = Me.InformationIDBindingSource.Find("Collegeno", Col)
        If Nk = -1 Then Exit Sub

        Nk = Me.SubjectOfStudentsBindingSource.Find("Collegeno", Col)
        If Nk = -1 Then
            Me.SubjectOfStudentsBindingSource.AddNew()
            Me.SubjectOfStudentsBindingSource.EndEdit()
            Nk = Me.SubjectOfStudentsBindingSource.Position
            Me.AuksoftDataSet1.SubjectOfStudents(Nk).MainID = MainID
            Me.AuksoftDataSet1.SubjectOfStudents(Nk).SubID = SubID
            Me.AuksoftDataSet1.SubjectOfStudents(Nk).Collegeno = Col
            Me.SubjectOfStudentsBindingSource.EndEdit()
        Else
            If GotoPos = True Then
                Me.SubjectOfStudentsBindingSource.Position = Nk

            End If
        End If
    End Sub

    Private Sub SubjectEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.ShowSubjects' table. You can move, or remove it, as needed.
        'Me.ShowSubjectsTableAdapter.Fill(Me.AuksoftDataSet1.ShowSubjects)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectsCollection' table. You can move, or remove it, as needed.
        Dim Vbxw As Integer
        Dim Nt As TextBox
        Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)

        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd
        Grp = GTxt

        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "Shift(" & Shv & ")"
        'SubID2 = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")SubjectNumber"
        SFC("StudentClass", "Class_Section", "Shift")
        STC(Clx, Secx, Shv)
        GSql.Sql_ORD_like_false("*", "informationid", "val(collegeno)", Me.AuksoftDataSet1)
        SFC("Subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "ShowSubjects", "val(collegeno)", Me.AuksoftDataSet1)

        SFC("group", "Class")
        STC(GTxt, Clx)
        GSql.Sql_ORD_like_false("*", "subjectposition", "", Me.AuksoftDataSet1)
        cxp = Me.SplitContainer1.Panel2.Controls.Count
        For Vbxw = 0 To cxp - 1
            If TypeOf Me.SplitContainer1.Panel2.Controls(Vbxw) Is TextBox Then
                Nt = Me.SplitContainer1.Panel2.Controls(Vbxw)
                For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
                    'w = Me.AuksoftDataSet1.SubjectPosition(I).Item(5).ToString
                    'If w <> "" Then
                    '    Nt.AutoCompleteCustomSource.Add(Me.AuksoftDataSet1.SubjectPosition(I).Item(5).ToString)
                    'End If
                    w = Me.AuksoftDataSet1.SubjectPosition(I).Item(3).ToString
                    If w <> "" Then
                        Nt.AutoCompleteCustomSource.Add(Me.AuksoftDataSet1.SubjectPosition(I).Item(3).ToString)
                    End If
                Next

            End If
        Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn5.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn6.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn7.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn8.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn9.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn10.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn11.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn12.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn13.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn14.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn15.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn16.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'Me.DataGridViewTextBoxColumn5.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn6.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn7.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn8.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn9.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn10.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn11.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn12.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn13.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn14.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn15.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn16.DataSource = Me.SubjectPositionBindingSource
        'Me.DataGridViewTextBoxColumn5.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn6.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn7.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn8.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn9.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn10.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn11.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn12.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn13.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn14.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn15.DisplayMember = "Subject"
        'Me.DataGridViewTextBoxColumn16.DisplayMember = "Subject"
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "subjectofstudents", "val(collegeno)", Me.AuksoftDataSet1)
        'Dim Rrow() As DataRow
        'Me.SubjectPositionBindingSource.Filter = "Subjectposition='1'"
        'Me.AuksoftDataSet1.SubjectOfStudents.Select("Subjectposition='1'")
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn5.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn6.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        ''Me.SubjectPositionBindingSource.Filter = "Subjectposition='2'"
        'Me.AuksoftDataSet1.SubjectOfStudents.Select("Subjectposition='2'")
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn7.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn8.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        ''Me.SubjectPositionBindingSource.Filter = "Subjectposition='3'"
        'Me.AuksoftDataSet1.SubjectOfStudents.Select("Subjectposition='3'")
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn9.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn10.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        ''Me.SubjectPositionBindingSource.Filter = "Subjectposition='4'"
        'Me.AuksoftDataSet1.SubjectOfStudents.Select("Subjectposition='4'")
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn11.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn12.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        ''Me.SubjectPositionBindingSource.Filter = "Subjectposition='5'"
        'Me.AuksoftDataSet1.SubjectOfStudents.Select("Subjectposition='5'")
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn13.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn14.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        ''Me.SubjectPositionBindingSource.Filter = "Subjectposition='6'"
        'Me.AuksoftDataSet1.SubjectOfStudents.Select("Subjectposition='6'")


        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn15.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn16.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'Me.SubjectPositionBindingSource.RemoveFilter()
        If Clx = 12 Then
            Me.CheckBox15.Visible = False
        Else
            Me.CheckBox15.Visible = False
        End If
    End Sub
    Public Function Tg(ByVal Com As ComboBox, ByVal T As TextBox)
        T.Text = Com.Text
    End Function

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        FG(TextBox7)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        FG(TextBox8)

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        FG(TextBox9)

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        FG(TextBox10)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        FG(TextBox1)
    End Sub
    Public Function FG(ByVal T As TextBox)
        Dim rc As String = T.Text
        Dim ik As Integer
        'Dim K as 
vg:
        ik = Me.SubjectsCollectionBindingSource.Find("codeno", rc)
        If ik > -1 Then

            wex = Me.AuksoftDataSet1.SubjectsCollection(ik).Subjects.ToString
            aq = Me.ComboBox4.FindStringExact(wex)

            If aq > -1 Then
                'If Me.CheckBox15.Checked = True Then
                '    kn = Microsoft.VisualBasic.Right(T.Name, 2)
                '    If IsNumeric(kn) Then
                '        j = kn / 2
                '        If AukF.FindTxt(j, ".") Then
                '            hj = Microsoft.VisualBasic.Right(wex, 2)
                '            If hj = "II" Then
                '                If MsgBox("Please Type First Paper SubjectCode...Do you want to Set this Subjet First Paper In This Field... (If you don't so please Of Grading Generate)...?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '                    rc = Val(rc) - 1
                '                    GoTo vg

                '                End If
                '            Else
                '                T.Text = wex
                '            End If
                '        End If
                '    Else
                '        kn = Microsoft.VisualBasic.Right(T.Name, 1)
                '        j = kn / 2
                '        If AukF.FindTxt(j, ".") Then
                '            hj = Microsoft.VisualBasic.Right(wex, 2)
                '            If hj = "II" Then
                '                If MsgBox("Please Type First Paper SubjectCode...Do you want to Set this Subjet First Paper In This Field... (If you don't so please Of Grading Generate)...?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '                    rc = Val(rc) - 1
                '                    GoTo vg

                '                End If
                '            Else
                '                T.Text = wex
                '            End If
                '        Else
                '            hj = Microsoft.VisualBasic.Right(wex, 1)
                '            If hj = "I" Then
                '                If MsgBox("Please Type First Paper SubjectCode...Do you want to Set this Subjet First Paper In This Field... (If you don't so please Of Grading Generate)...?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '                    rc = Val(rc) - 1
                '                    GoTo vg

                '                End If
                '            Else
                '                T.Text = wex
                '            End If
                '        End If
                '    End If

                'Else
                '    T.Text = wex
                'End If
                T.Text = wex
            Else
                T.Text = ""
                MsgBox("This Subject (" & wex & ") ;this is a subject of diffrect section...", MsgBoxStyle.Critical)
            End If

            'T.SelectNextControl(Controls, True, True, True, True)
            T.SelectNextControl(T, True, True, False, True)


        End If

    End Function

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        FG(TextBox2)

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        FG(TextBox11)
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        FG(TextBox12)
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        FG(TextBox3)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        FG(TextBox4)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        FG(TextBox5)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        FG(TextBox6)

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted, ComboBox3.SelectionChangeCommitted, ComboBox4.SelectionChangeCommitted, ComboBox5.SelectionChangeCommitted, ComboBox6.SelectionChangeCommitted, ComboBox7.SelectionChangeCommitted, ComboBox8.SelectionChangeCommitted, ComboBox9.SelectionChangeCommitted, ComboBox10.SelectionChangeCommitted, ComboBox11.SelectionChangeCommitted, ComboBox12.SelectionChangeCommitted, ComboBox13.SelectionChangeCommitted
        Dim ol, Lp As String
        Lp = DirectCast(sender, ComboBox).Name

        ol = VB.Right(Lp, 2)

        'Dim r As String
        'r = "auk"
        ''UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'gh = Right(r, 1)


        If IsNumeric(ol) = False Then

            ol = VB.Right(Lp, 1)

        End If

        Select Case ol
            Case 2
                Tg(DirectCast(sender, ComboBox), Me.TextBox1)
            Case 3
                Tg(DirectCast(sender, ComboBox), Me.TextBox2)
            Case 4
                Tg(DirectCast(sender, ComboBox), Me.TextBox3)
            Case 5
                Tg(DirectCast(sender, ComboBox), Me.TextBox4)
            Case 6
                Tg(DirectCast(sender, ComboBox), Me.TextBox5)
            Case 7
                Tg(DirectCast(sender, ComboBox), Me.TextBox6)
            Case 8
                Tg(DirectCast(sender, ComboBox), Me.TextBox7)
            Case 9
                Tg(DirectCast(sender, ComboBox), Me.TextBox8)
            Case 10
                Tg(DirectCast(sender, ComboBox), Me.TextBox9)
            Case 11
                Tg(DirectCast(sender, ComboBox), Me.TextBox10)
            Case 12
                Tg(DirectCast(sender, ComboBox), Me.TextBox11)
            Case 13
                Tg(DirectCast(sender, ComboBox), Me.TextBox12)

        End Select


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim hj As Integer
        'Dim lo As Type
        Dim Kp As CheckBox
        hj = Me.SplitContainer1.Panel2.Controls.Count
        For I = 0 To hj - 1

            'MsgBox(lo)
            If TypeOf (Me.SplitContainer1.Panel2.Controls(I)) Is CheckBox Then


                Kp = Me.SplitContainer1.Panel2.Controls(I)
                Kp.Checked = True
            End If
        Next
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        ki = Me.ListBox1.SelectedIndex
        If ki > -1 Then
            AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)
        End If
    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'ki = Me.ListBox1.SelectedIndex
            'If ki > -1 Then
            '    col = Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno.ToString()

            'End If
            AukF2.SelectedItemsCopiedToObject(Me.ListBox1, Me.ListBox2, True, True)

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Me.CheckBox13.Checked = True Then
            ki = Me.ListBox1.SelectedIndex
            If ki > -1 Then
                AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)

            End If
        End If
    End Sub

    Private Sub ListBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.Click
        On Error Resume Next

        If Me.CheckBox14.Checked = True Then
            ki = Me.ListBox2.SelectedIndex
            If ki > -1 Then
                'AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)
                AukF.LstDeleteandSelect(Me.ListBox2, ki)

            End If
        End If
    End Sub

    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick

        ki = Me.ListBox2.SelectedIndex
        If ki > -1 Then
            'AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)
            AukF.LstDeleteandSelect(Me.ListBox2, ki)
        End If
    End Sub

    Private Sub ListBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        If e.KeyCode = Keys.Delete Then
            ki = Me.ListBox2.SelectedIndex
            If ki > -1 Then
                'AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)
                AukF.LstDeleteandSelect(Me.ListBox2, ki)
            End If
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        On Error Resume Next

 
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        For I = 0 To Me.ListBox1.Items.Count - 1
            AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(I).Collegeno)
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.ListBox2.Items.Clear()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ki = Me.ListBox2.SelectedIndex
        If ki > -1 Then
            AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)
            'Me.ListBox2.Items.RemoveAt(ki)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ki = Me.ListBox2.SelectedIndex
        If ki > -1 Then
            'AukF.UniqueAdd(Me.ListBox2, Me.AuksoftDataSet1.SubjectOfStudents(ki).Collegeno)
            AukF.LstDeleteandSelect(Me.ListBox2, ki)
        End If
    End Sub

    Private Sub SubjectOfStudentsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        c = 100 / Me.ComboBox1.Items.Count
        For I = 0 To Me.ComboBox1.Items.Count - 1
            col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
            InputCol(col, False)
            AukF.InsPro(ToolStripProgressBar1, c)
        Next
        ToolStripProgressBar1.Visible = False

        ToolStripProgressBar1.Value = 0
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim hj As Integer
        'Dim lo As Type
        Dim Kp As CheckBox
        hj = Me.SplitContainer1.Panel2.Controls.Count
        For I = 0 To hj - 1

            'MsgBox(lo)
            If TypeOf (Me.SplitContainer1.Panel2.Controls(I)) Is CheckBox Then


                Kp = Me.SplitContainer1.Panel2.Controls(I)
                Kp.Checked = False
            End If
        Next
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim hj As Integer
        'Dim lo As Type
        Dim Kp As CheckBox
        hj = Me.SplitContainer1.Panel2.Controls.Count
        For I = 0 To hj - 1

            'MsgBox(lo)
            If TypeOf (Me.SplitContainer1.Panel2.Controls(I)) Is CheckBox Then


                Kp = Me.SplitContainer1.Panel2.Controls(I)
                If Kp.Checked = True Then
                    Kp.Checked = False
                Else
                    Kp.Checked = True
                End If

            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Aq As Integer
        Me.ProgressBar1.Value = 0
        c = 100 / Me.ListBox2.Items.Count
        'Me.DataGrid1.DataSource = Npd


        For I = 0 To Me.ListBox2.Items.Count - 1
            lst = Me.ListBox2.Items.Item(I)

            Aq = Me.SubjectOfStudentsBindingSource.Find("Collegeno", lst)
            If Aq > -1 Then
                If Me.CheckBox1.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub1 = Me.TextBox1.Text
                End If
                If Me.CheckBox2.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub2 = Me.TextBox2.Text
                End If
                If Me.CheckBox3.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub3 = Me.TextBox3.Text
                End If
                If Me.CheckBox4.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub4 = Me.TextBox4.Text
                End If
                If Me.CheckBox5.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub5 = Me.TextBox5.Text
                End If
                If Me.CheckBox6.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub6 = Me.TextBox6.Text
                End If
                If Me.CheckBox7.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub7 = Me.TextBox7.Text
                End If
                If Me.CheckBox8.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub8 = Me.TextBox8.Text
                End If
                If Me.CheckBox9.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub9 = Me.TextBox9.Text
                End If
                If Me.CheckBox10.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub10 = Me.TextBox10.Text
                End If
                If Me.CheckBox11.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub11 = Me.TextBox11.Text
                End If
                If Me.CheckBox12.Checked = True Then
                    Me.AuksoftDataSet1.SubjectOfStudents(Aq).Sub12 = Me.TextBox12.Text
                End If
                AukF.InsPro(Me.ProgressBar1, c)
                Me.ProgressBar1.Value = 0

            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)

    End Sub

    Private Sub RejectCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectCToolStripMenuItem.Click
        Me.SubjectOfStudentsBindingSource.CancelEdit()
        Me.AuksoftDataSet1.SubjectOfStudents.RejectChanges()
        Me.ShowSubjectsBindingSource.CancelEdit()
        Me.AuksoftDataSet1.ShowSubjects.RejectChanges()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            Me.SubjectOfStudentsBindingSource.RemoveCurrent()
            Me.SubjectOfStudentsBindingSource.EndEdit()

            Me.SubjectOfStudentsTableAdapter.Update(Me.AuksoftDataSet1)
        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub RejectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.SubjectOfStudentsBindingSource.AddNew()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click, SubjectOfStudentsBindingNavigatorSaveItem.Click
        Try

            If Me.AlsoUpdateStudentsSingleSubjectsWhenSaveToolStripMenuItem.Checked = True Then ToolStripButton2_Click(sender, e)

            Me.SubjectOfStudentsBindingSource.EndEdit()
            Me.SubjectOfStudentsTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.LostFocus

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        Dim ap As Integer
        ap = Me.SubjectOfStudentsBindingSource.Find("Collegeno", ToolStripTextBox1.Text)
        If ap > -1 Then
            Me.SubjectOfStudentsBindingSource.Position = ap

        End If


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AukF.CutWordLetter(Me.ListBox2, Me.TextBox13.Text, ",", True)

    End Sub

    Private Sub TextBox13_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox13.KeyDown
        If e.KeyCode = Keys.Enter Then
            AukF.CutWordLetter(Me.ListBox2, Me.TextBox13.Text, ",", True)

        End If
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim Ko As New ListBox
        Ko.Items.Clear()
        AukF.CutWordLetter(Ko, Me.TextBox13.Text, ",", True)
        For I = 0 To Ko.Items.Count - 1
            aq = Me.ListBox2.FindStringExact(Ko.Items.Item(I))
            If aq > -1 Then
                Me.ListBox2.Items.RemoveAt(aq)

            End If
        Next
    End Sub

    Private Sub InputAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputAllToolStripMenuItem.Click
        InputCol(col, True)
    End Sub

    Private Sub FillTheViewOfStudentsSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillTheViewOfStudentsSubjectsToolStripMenuItem.Click
        'For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
        '    Me.DataGridViewTextBoxColumn5.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn6.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn7.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn8.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn9.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn10.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn11.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn12.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn13.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn14.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn15.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        '    Me.DataGridViewTextBoxColumn16.Items.Add(Me.AuksoftDataSet1.SubjectPosition.Rows(I).Item(3))
        'Next
        'Me.SubjectOfStudentsDataGridView.DataSource = Me.SubjectOfStudentsBindingSource
        Me.DataGrid1.DataSource = Me.SubjectOfStudentsBindingSource
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Nk, Aq As Integer
        Dim SubjectBox As String
        Me.ToolStripProgressBar1.Visible = True
        dp = Me.SubjectOfStudentsBindingSource.Count.ToString * (Me.AuksoftDataSet1.SubjectOfStudents.Columns.Count - 4)
        'MsgBox(Me.ShowSubjectsBindingSource.Count)
        'MsgBox(Me.ShowSubjectsBindingSource.Count)
        If Me.ShowSubjectsBindingSource.Count > dp Then
            'MsgBox("Cau")
            For I = (Me.ShowSubjectsBindingSource.Count - 1) To dp Step -1
                Me.ShowSubjectsBindingSource.RemoveAt(I)
                'MsgBox(I)
            Next
        End If
        Try
            Me.ShowSubjectsBindingSource.EndEdit()
            Me.ShowSubjectsTableAdapter.Update(Me.AuksoftDataSet1.ShowSubjects)
        Catch ex As Exception
            Epx()

        End Try

        dp = Me.SubjectOfStudentsBindingSource.Count.ToString * (Me.AuksoftDataSet1.SubjectOfStudents.Columns.Count - 4)
        'MsgBox(Me.ShowSubjectsBindingSource.Count)
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "Shift(" & Shv & ")"


        cyh = 100 / Me.AuksoftDataSet1.SubjectOfStudents.Rows.Count

        'MsgBox(cyh)

        For I = 0 To Me.SubjectOfStudentsBindingSource.Count - 1

            For Nk = 4 To Me.AuksoftDataSet1.SubjectOfStudents.Columns.Count - 1
                SubjectBox = Me.AuksoftDataSet1.SubjectOfStudents(I).Item(Nk).ToString
                col = Me.AuksoftDataSet1.SubjectOfStudents(I).Collegeno
                MainID = SubID & "Columns(" & Nk & ")Row(" & I & ")"
                Aq = Me.ShowSubjectsBindingSource.Find("MainID", MainID)
                If Aq = -1 Then
                    Me.ShowSubjectsBindingSource.AddNew()
                    Me.ShowSubjectsBindingSource.EndEdit()
                    Aq = Me.ShowSubjectsBindingSource.Position
                    Me.AuksoftDataSet1.ShowSubjects(Aq).Collegeno = col
                    Me.AuksoftDataSet1.ShowSubjects(Aq).MainID = MainID
                    Me.AuksoftDataSet1.ShowSubjects(Aq).SubID = SubID
                    Me.AuksoftDataSet1.ShowSubjects(Aq).Subjects = SubjectBox
                    Me.AuksoftDataSet1.ShowSubjects(Aq).RowNumber = Nk
                    Me.ShowSubjectsBindingSource.EndEdit()
                Else
                    Me.AuksoftDataSet1.ShowSubjects(Aq).Collegeno = col
                    Me.AuksoftDataSet1.ShowSubjects(Aq).MainID = MainID
                    Me.AuksoftDataSet1.ShowSubjects(Aq).SubID = SubID
                    Me.AuksoftDataSet1.ShowSubjects(Aq).Subjects = SubjectBox
                    Me.AuksoftDataSet1.ShowSubjects(Aq).RowNumber = Nk
                    Me.ShowSubjectsBindingSource.EndEdit()
                End If
                'AukF.InsPro(Me.ToolStripProgressBar1, cyh)
                'AukF.InsPro(Me.ProgressBar1, cyh)
            Next
            AukF.InsPro(Me.ProgressBar1, cyh)
            AukF.InsPro(Me.ToolStripProgressBar1, cyh)
        Next
        Me.ProgressBar1.Value = 0
        Me.ToolStripProgressBar1.Value = 0
        Me.ToolStripProgressBar1.Visible = False
        Try
            Me.ShowSubjectsBindingSource.EndEdit()
            Me.ShowSubjectsTableAdapter.Update(Me.AuksoftDataSet1.ShowSubjects)


        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        InputCol(Me.ComboBox1.Text, True)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SubjectEditor_Load(sender, e)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Help1.Show()

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim mxq As New SudentsSubjectsReport

        AukF.Prnt(mxq, Me.AuksoftDataSet1)

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        AukF.ClearErrorFromDataSet(Me.AuksoftDataSet1)

    End Sub
End Class