Public Class Informations
    Dim FObject As Object

    'Private Sub SavingOptionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.SavingOptionsBindingSource.EndEdit()
    '    Me.SavingOptionsTableAdapter.Update(Me.AuksoftDataSet1.SavingOptions)

    'End Sub
    Dim Pos As Integer

    Private Sub Informations_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()

    End Sub
    Private Sub Informations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.TermS' table. You can move, or remove it, as needed.
        Me.InformationIDDataGridView.DataSource = ""
        My.Application.SaveMySettingsOnExit = True
        My.Settings.Upgrade()

        Me.HouseTableAdapter.Fill(Me.AuksoftDataSet1.House)
        Me.TermSTableAdapter.Fill(Me.AuksoftDataSet1.TermS)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.ClassOptions' table. You can move, or remove it, as needed.
        Me.ClassOptionsTableAdapter.Fill(Me.AuksoftDataSet1.ClassOptions)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        'Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.House' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AuksoftDataSet1.F_Informations' table. You can move, or remove it, as needed.
        Me.F_InformationsTableAdapter.Fill(Me.AuksoftDataSet1.F_Informations)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SavingOptions' table. You can move, or remove it, as needed.
        'Me.SavingOptionsTableAdapter.Fill(Me.AuksoftDataSet1.SavingOptions)
        Me.AuksoftDataSet1.InformationID.Clear()
        If Acc = "" Then
            Acc = InputBox("Please Input your Username for Saved topic...", "Saved Topic Contact with Developer..", Acc)
        End If
        'AukF.XPAuk(Me)
        SFC("username")
        STC(Acc)
        GSql.Sql_ORD_like_false("*", "F_Informations", "", Me.AuksoftDataSet1)
        Me.InformationIDDataGridView.DefaultCellStyle.ForeColor = Color.Black

        ''msgbox(sql)
        'Dim mkt As ComboBox

        'For Each mkt In mkt.Controls

        '    mkt.SelectedIndex = 0


        'Next
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.FInformationsBindingSource.EndEdit()
            Me.F_InformationsTableAdapter.Update(Me.AuksoftDataSet1.F_Informations)
        Catch ex As Exception
            Epx()

        End Try
     

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Me.InformationIDDataGridView.DataSource = ""
            Me.Cg.DataSource = ""
            Me.Validate()
            Me.InformationIDBindingSource.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)
            'Me.InformationIDDataGridView.DataSource = Me.InformationIDBindingSource

        Catch ex As Exception
            Ebx(Err.Number, Err.Description)
        Finally
            Beep()

        End Try


    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim NullDset As New DataSet

        If ToolStripComboBox1.Text = "CollegeNo" Then
            Me.ComboBox8.DataSource = NullDset
            Me.ComboBox7.DataSource = Me.InformationIDBindingSource
            Me.ComboBox7.DisplayMember = "CollegeNo"

            Me.ComboBox7.Visible = True
            Me.ComboBox8.Visible = False
        Else
            Me.ComboBox7.DataSource = NullDset
            Me.ComboBox8.DataSource = Me.InformationIDBindingSource
            Me.ComboBox8.DisplayMember = "Name"
            Me.ComboBox7.Visible = False
            Me.ComboBox8.Visible = True
        End If
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ExToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExToolStripMenuItem.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectionChangeCommitted
        'Me.TextBox3.Text = Me.ComboBox3.Text

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Me.TextBox4.Text = Me.ComboBox2.Text


    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Me.TextBox5.Text = Me.ComboBox1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.CheckBox1.Checked = True Then
            SF(0) = "StudentClass"
            ST(0) = Me.TextBox1.Text
        End If
        If Me.CheckBox2.Checked = True Then
            SF(1) = "Class_Section"
            ST(1) = Me.TextBox2.Text
        End If
        If Me.CheckBox3.Checked = True Then
            SF(2) = "Position_number"
            EP(2) = Me.ComboBox3.Text
            NM(2) = Me.TextBox3.Text
            ST(2) = Me.TextBox3.Text
        End If
        If Me.CheckBox4.Checked = True Then
            SF(3) = "Shift"
            ST(3) = Me.TextBox4.Text
        End If
        If Me.CheckBox5.Checked = True Then
            SF(4) = "House"
            ST(4) = Me.TextBox5.Text
        End If
        If Me.CheckBox6.Checked = True Then
            GSql.Sql_ORD_like_false("*", "informationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        Else
            GSql.Sql_ORD_likeUse("*", "informationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        End If
        'MsgBox(Sql)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Do you want to open Full Database....?Its must need more time and enough sharing Ram...", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            GSql.Sql_ORD_like_false("*", "informationID", "val(CollegeNo)", Me.AuksoftDataSet1)

            'MsgBox(Sql)
        Else
            MsgBox("Its Safe to Work with query table....", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RecS.Text = Me.AuksoftDataSet1.InformationID.Count
        Me.NumbX.Text = Me.AuksoftDataSet1.InformationID.Count
        Pos = Me.FInformationsBindingSource.Position
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        'Try
        '    If OForm.Y1CheckBox.Checked = True Then
        '        Me.InformationIDBindingSource.CancelEdit()
        '        Me.AuksoftDataSet1.InformationID.RejectChanges()
        '    End If

        'Catch ex As Exception
        '    Ebx(Err.Number, Err.Description)
        'End Try


    End Sub

    'Private Sub CollegeNoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CollegeNoTextBox.KeyDown, NameTextBox.KeyDown, Father_sNameTextBox.KeyDown, Mother_sNameTextBox.KeyDown, DateOfBirthTextBox.KeyDown, JoiningDateTextBox.KeyDown, JoiningClassTextBox.KeyDown, ClassTextBox.KeyDown, SectionTextBox.KeyDown, AddressTextBox.KeyDown, ContactNumberTextBox.KeyDown, LastTermExamTextBox.KeyDown, ResultTextBox.KeyDown, PositionTextBox.KeyDown, HouseTextBox.KeyDown, ResidentOrNonResidentTextBox.KeyDown, OptionalSubjectTextBox.KeyDown, TotalMarksTextBox.KeyDown, ShiftTextBox.KeyDown
    '    Select Case DirectCast(sender, TextBox).Name
    '        Case Me.CollegeNoTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.ComboBox9.Focus()
    '            End If
    '        Case Me.NameTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.CollegeNoTextBox.Focus()
    '            End If
    '        Case Me.Father_sNameTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.NameTextBox.Focus()
    '            End If
    '        Case Me.Mother_sNameTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.Father_sNameTextBox.Focus()
    '            End If
    '        Case Me.DateOfBirthTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.Mother_sNameTextBox.Focus()
    '            End If
    '        Case Me.JoiningDateTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.DateOfBirthTextBox.Focus()
    '            End If
    '        Case Me.JoiningClassTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.JoiningDateTextBox.Focus()
    '            End If
    '        Case Me.ClassTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.JoiningClassTextBox.Focus()
    '            End If
    '        Case Me.SectionTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.ClassTextBox.Focus()
    '            End If
    '        Case Me.AddressTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.SectionTextBox.Focus()
    '            End If
    '        Case Me.ContactNumberTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.AddressTextBox.Focus()
    '            End If
    '        Case Me.LastTermExamTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.SectionTextBox.Focus()
    '            End If
    '        Case Me.PositionTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.SectionTextBox.Focus()
    '            End If
    '        Case Me.ResidentOrNonResidentTextBox.Name
    '            If e.KeyCode = Keys.Up Then
    '                Me.SectionTextBox.Focus()
    '            End If
    '            'Case Me.ComboBox5.Name
    '            '    If e.KeyCode = Keys.Up Then
    '            '        Me.SectionTextBox.Focus()
    '            '    End If
    '            'Case Me.ComboBox6.Name
    '            '    If e.KeyCode = Keys.Up Then
    '            '        Me.SectionTextBox.Focus()
    '            '    End If
    '            'Case Me.ComboBox7.Name
    '            '    If e.KeyCode = Keys.Up Then
    '            '        Me.SectionTextBox.Focus()
    '            '    End If

    '    End Select
    '    If e.KeyCode = Keys.Down Then
    '        SendKeys.Send("{TAB}")
    '    End If
    '    If e.KeyCode = Keys.Control And e.KeyCode = Keys.F Then
    '        ToolStripTextBox2.Focus()

    '    End If
    'End Sub

    Private Sub CollegeNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegeNoTextBox.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ClassSec.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Dim kTw(10) As String

b:
        m = InputBox("Please Type Saved topic...", "Saved Topic", m)
        If Acc = "" Then
            Acc = InputBox("Please Input your Username for Saved topic...", "Saved Topic Contact with Developer..", Acc)
        End If
        If m <> "" Then
            If Acc = "" Then GoTo b
            'If Me.FInformationsBindingSource.Position <> -1 Then
            '    Try
            '        For I = 3 To Me.AuksoftDataSet1.F_Informations.Columns.Count - 1
            '            kTw(I) = ""
            '            kTw(I) = Me.AuksoftDataSet1.F_Informations.Item(Me.FInformationsBindingSource.Position).Item(I)
            '        Next
            '    Catch ex As Exception
            '        Epx()

            '    End Try

            'End If
            Try
                Me.FInformationsBindingSource.AddNew()
                Me.FInformationsBindingSource.EndEdit()
                Me.AuksoftDataSet1.F_Informations.Rows(Me.FInformationsBindingSource.Position).Item(2) = m
                Me.AuksoftDataSet1.F_Informations.Rows(Me.FInformationsBindingSource.Position).Item(1) = Acc
                Me.FInformationsBindingSource.EndEdit()
                Me.F_InformationsTableAdapter.Update(Me.AuksoftDataSet1.F_Informations)

            Catch ex As Exception
                Epx()

            End Try

            'For I = 3 To Me.AuksoftDataSet1.F_Informations.Columns.Count - 1

            '    'Me.AuksoftDataSet1.F_Informations.Item(Pos).Item(1) = Acc
            '    Try
            '        Me.AuksoftDataSet1.F_Informations.Rows(Me.FInformationsBindingSource.Position).Item(I) = kTw(I)

            '    Catch ex As Exception

            '    End Try

            'Next
            Try
                Me.FInformationsBindingSource.EndEdit()
                Me.F_InformationsTableAdapter.Update(Me.AuksoftDataSet1.F_Informations)
            Catch ex As Exception
                Epx()

            End Try




        Else
            GoTo b

        End If



    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            'AukF.CutWordLetter(Me.ListBox1, Me.TextBox6.Text, ",", True)
            Dim k As Integer
            Me.ListBox1.Sorted = True
            AukF.CutWordLetter(Me.ListBox1, Me.TextBox6.Text, ",", True)
            'MsgBox(Me.ListBox1.Items.Count)
            For k = 0 To (Me.ListBox1.Items.Count - 1)
                c = Me.ListBox1.Items.Item(k).ToString
                'MsgBox(c)
                SFC("CollegeNo")
                STC(c)
                GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
            Next


        End If
        If e.Control = True Then
            If e.Shift = True Then
                If e.KeyCode = Keys.C Then
                    strn = AukF2.AukConvertKeysTo(Clipboard.GetText.Trim, vbCrLf, ",")
                    sender.text = strn

                End If
            End If

        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Adding_inList(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim k As Integer
        'Me.ListBox1.Sorted = True
        AukF2.CutWordLetter(Me.ListBox1, Me.TextBox6.Text, ",", True, False, True, False, True, False)

        'MsgBox(Me.ListBox1.Items.Count)
        For k = 0 To (Me.ListBox1.Items.Count - 1)

            c = Me.ListBox1.Items.Item(k).ToString
            If IsNumeric(c) = False Then
                MsgBox("Please Type Number Value to Common add College No...(" & c & ") is not accepted...", MsgBoxStyle.Critical)
                Exit Sub
            End If
            '(AukF.BindFind(Me.InformationBindingSource1, "CollegeNo", c) = True) Or 
            'If (AukF.BindFind(Me.InformationIDBindingSource, "CollegeNo", c)) = False Then
            '    'Else
            '    SFC("CollegeNo")
            '    STC(Val(c))
            '    GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "", Me.AuksoftDataSet1)
            'End If
            'MsgBox(c)
        Next
        AukF2.Mother_DB_Load(Me.ListBox1, ",", Me.InformationIDBindingSource, 0, True, True, True, False)
        'SFC("Collegeno")
        ExpressionsQ(0) = "CollegeNo In(" & GetStrs & ")"
        'INPC(GetStrs)
        'STC(GetStrs)
        AukF2.Db_Load("*", Me.AuksoftDataSet1, "InformationId", False, "val(collegeno)")
        'MsgBox(Sql)




    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'If Me.ListBox1.SelectedIndex > -1 Then
        '    c = Me.ListBox1.SelectedIndex
        '    'For I = 0 To Me.ListBox1.SelectedIndices
        '    Me.ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        '    Try
        '        Me.ListBox1.SelectedIndex = c
        '    Catch ex As Exception

        '    End Try


        'Else
        '    Try
        '        Me.ListBox1.SelectedIndex = c
        '    Catch ex As Exception

        '    End Try

        'End If
        AukF2.LstDeleteSelAllItems(Me.ListBox1)


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.ListBox1.Items.Clear()

    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        Me.TextBox14.Text = Me.ComboBox11.Text

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        Me.TextBox15.Text = Me.ComboBox12.Text

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        Me.TextBox9.Text = Me.ComboBox10.Text

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Me.InformationIDDataGridView.DataSource = ""
        Me.InformationBindingSource1.SuspendBinding()
        Me.InformationIDBindingSource.RemoveFilter()
        'InformationIDBindingSource.SuspendBinding()

        'Me.CheckBox17.Update()
        'Me.CheckBox7.Update()
        'Dim Dth As DataTable
        'Dth = Me.AuksoftDataSet1.InformationID
        'Dim dt2 As New DataTable
        Dim c, Aq As Integer
        'dt2 = Me.AuksoftDataSet1.InformationID
        'If msgbox("Before that you must Save the whole database by Click on Yes", msgboxStyle.YesNo) = msgboxResult.Yes Then
        '    Me.Validate()
        '    Me.InformationIDBindingSource.EndEdit()
        '    Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1)
        'Else
        '    msgbox("You can't see the exact Changes...")

        'End If
        'Dth.Rows(0).Item
        'Dim Rnw As DataRow
        Dim R As AuksoftDataSet1.InformationIDRow

        Me.ProgComm.Value = 0
        Me.ProgComm.Visible = True
        cdma = 100 / Me.ListBox1.Items.Count.ToString
        Try
            For I = 0 To Me.ListBox1.Items.Count - 1
                gmx = Me.ListBox1.Items.Count
                cur = I + 1


                cf = Val(Me.ListBox1.Items.Item(I).ToString)

                'dtxData = cf
                'Timer2.Enabled = True
                'WaitC.Show()

                'msgbox(cf)
                Me.Cursor = Cursors.WaitCursor

                If Me.CheckBox7.Checked = True Then
                    'TSql.CTab_NonLike(True, "*", "", "InformationID", "CollegeNo", cf, Dth)
                    'Dth.Select("collegeno = '" & cf & "'")

                    'c = Me.InformationIDBindingSource.Find("CollegeNo", cf)

                    'd()

                    Aq = Me.InformationIDBindingSource.Find("CollegeNo", cf)
                    'MsgBox(cf, , Aq)
                    If Aq = -1 Then
                        'Me.InformationIDBindingSource.AddNew()
                        '''Me.InformationIDBindingSource.a()
                        'Me.InformationIDBindingSource.EndEdit()
                        'c = Me.InformationIDBindingSource.Position
                        R = Me.AuksoftDataSet1.InformationID.NewRow

                        'Rnw = Me.AuksoftDataSet1.InformationID.NewRow()
                        R.CollegeNo = cf
                        'Rnw.Item(2) = cf

                        If Me.CheckBox8.Checked = True Then
                            R.StudentClass = Me.TextBox7.Text

                        End If
                        If Me.CheckBox9.Checked = True Then
                            R.Class_Section = Me.TextBox8.Text
                        End If
                        If Me.CheckBox10.Checked = True Then
                            R.Shift = Me.TextBox9.Text
                        End If
                        If Me.CheckBox11.Checked = True Then
                            R.JoiningDate = CDate(Me.TextBox10.Text)
                        End If
                        If Me.CheckBox12.Checked = True Then
                            R.JoiningClass = Me.TextBox11.Text
                        End If
                        If Me.CheckBox13.Checked = True Then
                            R.DateOfBirth = Me.TextBox12.Text
                        End If
                        If Me.CheckBox14.Checked = True Then
                            R.Address = Me.TextBox13.Text
                        End If
                        If Me.CheckBox15.Checked = True Then
                            R.House = Me.TextBox14.Text
                        End If
                        If Me.CheckBox16.Checked = True Then
                            R.Student_Status = Me.TextBox15.Text
                        End If
                        R.Table.Rows.Add(R)


                        'Rnw.EndEdit()
                        'Me.AuksoftDataSet1.InformationID.Rows.Add(Rnw)

                    Else
                        c = Aq
                        R = Me.AuksoftDataSet1.InformationID(c)
                        'Me.InformationIDBindingSource.Position = c
                        'R.Item(0) = cf
                        'Rnw.Item(2) = cf

                        If Me.CheckBox8.Checked = True Then
                            R.StudentClass = Me.TextBox7.Text

                        End If
                        If Me.CheckBox9.Checked = True Then
                            R.Class_Section = Me.TextBox8.Text
                        End If
                        If Me.CheckBox10.Checked = True Then
                            R.Shift = Me.TextBox9.Text
                        End If
                        If Me.CheckBox11.Checked = True Then
                            R.JoiningDate = CDate(Me.TextBox10.Text)
                        End If
                        If Me.CheckBox12.Checked = True Then
                            R.JoiningClass = Me.TextBox11.Text
                        End If
                        If Me.CheckBox13.Checked = True Then
                            R.DateOfBirth = Me.TextBox12.Text
                        End If
                        If Me.CheckBox14.Checked = True Then
                            R.Address = Me.TextBox13.Text
                        End If
                        If Me.CheckBox15.Checked = True Then
                            R.House = Me.TextBox14.Text
                        End If
                        If Me.CheckBox16.Checked = True Then
                            R.Student_Status = Me.TextBox15.Text
                        End If
                        'If Me.ch Then
                    End If
                Else
                    c = Me.InformationIDBindingSource.Find("CollegeNo", cf)

                    'TSql.CTab_NonLike(True, "*", "", "InformationID", "CollegeNo", cf, Dth)
                    'c = Me.AuksoftDataSet1.InformationID.Rows.Count
                    If c > -1 Then
                        R = Me.AuksoftDataSet1.InformationID(c)

                        'R.Item(0) = cf
                        'Rnw.Item(2) = cf

                        If Me.CheckBox8.Checked = True Then
                            R.StudentClass = Me.TextBox7.Text

                        End If
                        If Me.CheckBox9.Checked = True Then
                            R.Class_Section = Me.TextBox8.Text
                        End If
                        If Me.CheckBox10.Checked = True Then
                            R.Shift = Me.TextBox9.Text
                        End If
                        If Me.CheckBox11.Checked = True Then
                            R.JoiningDate = CDate(Me.TextBox10.Text)
                        End If
                        If Me.CheckBox12.Checked = True Then
                            R.JoiningClass = Me.TextBox11.Text
                        End If
                        If Me.CheckBox13.Checked = True Then
                            R.DateOfBirth = Me.TextBox12.Text
                        End If
                        If Me.CheckBox14.Checked = True Then
                            R.Address = Me.TextBox13.Text
                        End If
                        If Me.CheckBox15.Checked = True Then
                            R.House = Me.TextBox14.Text
                        End If
                        If Me.CheckBox16.Checked = True Then
                            R.Student_Status = Me.TextBox15.Text
                        End If
                    End If
                End If
                R.EndEdit()

                AukF.InsPro(Me.ProgComm, Val(cdma))

                'Try
                '    Me.AuksoftDataSet1.InformationID.NewRow.ClearErrors()
                '    'Me.Validate()
                '    Rnw.EndEdit()
                '    'Me.AuksoftDataSet1.InformationID.NewRow.ClearErrors()

                '    Me.InformationIDBindingSource.EndEdit()
                '    Me.InformationIDTableAdapter.Update(Rnw)


                'Catch ex As Exception
                '    InformationIDBindingSource.ResumeBinding()

                '    Epx()
                '    Me.ProgComm.Visible = False
                '    'WaitC.Close()
                '    'Timer2.Enabled = False

                '    Me.Cursor = Cursors.Default
                '    Exit Sub
                'End Try


            Next
            If Me.CheckBox17.Checked = True Then
                Cg.DataSource = Me.AuksoftDataSet1.InformationID.GetChanges
                'ChgGridView.Show()
                'ChgTab = "InformationID"
                'ChgGridView.InformationIDBindingSource.DataMember = ChgTab
                Me.TabControl2.SelectTab(3)
            End If
            'Me.InformationIDDataGridView.DataSource = Me.InformationIDBindingSource

        Catch ex As Exception
            Epx()
        Finally
            Beep()
            'InformationIDBindingSource.ResumeBinding()

        End Try
        Me.ProgComm.Visible = False
        'WaitC.Close()
        'Timer2.Enabled = False

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Dim dt2 As New DataTable
        'dt2 = Me.AuksoftDataSet1.InformationID
        'Me.ListBox1.DataSource = dt2
        'Me.ListBox1.DisplayMember = "CollegeNo"
        For I = 0 To Me.AuksoftDataSet1.InformationID.Rows.Count - 1
            m = Me.AuksoftDataSet1.InformationID.Rows(I).Item(2).ToString
            c = Me.ListBox1.FindString(m)
            'msgbox(c)
            If c = -1 Then
                Me.ListBox1.Items.Add(Me.AuksoftDataSet1.InformationID.Rows(I).Item(2).ToString)
            End If


        Next

        'Me.ListBox1.DisplayMember = "CollegeNo"

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'WaitC.T.Text = gmx
        ''cur = mix
        'WaitC.ProgressBar1.Increment(1)
        'WaitC.Isp.Text = cur
        'WaitC.info.Text = dtxData
        'WaitC.ProgressBar1.Maximum = gmx
        'WaitC.ProgressBar1.Value = cur
        'If cur = gmx Then
        '    WaitC.Close()

        '    Timer2.Enabled = False

        'End If

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        'Try
        '    cqa = Me.AuksoftDataSet1.InformationID.GetChanges(DataRowState.Added).Rows.Count.ToString
        'Catch ex As Exception
        '    cqa = 0
        'End Try
        'If cqa > 0 Then
        '    ToolStripButton7_Click(sender, e)
        '    Me.AuksoftDataSet1.InformationID.Clear()
        '    MsgBox("Please ReOpen Database for Refresh...", MsgBoxStyle.Information)
        '    Me.TabControl1.SelectTab(0)

        'Else
        ToolStripButton7_Click(sender, e)
        Me.TabControl2.SelectTab(0)

        'End If
        ''SFC("CollegeNo")
        ''STC("ooqkoksoksokosksLiejjbjhqjjkhHHHH882839919")
        ''GSql.NonCls_ORD_NonLikeCommand("*", "informationid", "val(CollegeNo)", Me.AuksoftDataSet1)

        Button26_Click(sender, e)


    End Sub

    Private Sub ClassOptionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassOptionsBindingNavigatorSaveItem.Click, SaveDataToolStripMenuItem.Click
        'ToolStripButton7_Click(sender, e)
        Try

            Me.Validate()
            If Me.BeforeSaveUnFillGridToSaveFastToolStripMenuItem.Checked = True Then
                Me.InformationIDDataGridView.DataSource = ""
            End If
            Me.InformationIDBindingSource.EndEdit()
            'Me.InformationBindingSource1.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1)
        Catch ex As Exception
            Epx()
        Finally
            Beep()

        End Try
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick, ToolStripButton8.ButtonClick, RefreshWholeTableToolStripMenuItem.Click
        'Me.InformationIDBindingSource.CancelEdit()
        'Me.AuksoftDataSet1.InformationID.RejectChanges()
        AukF2.SingleDataTable_DataRecordRefresh(Me.InformationIDBindingSource, True)

    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStripButton8_Click(sender, e)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Cg.CellContentClick

    End Sub

    Private Sub TabControl2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.Click
        'Me.tabpa()
    End Sub

    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage8.Click

    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click
        AukF.ComSelIndex(ToolStripComboBox3)
    End Sub

    Private Sub ToolStripTextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ToolStripComboBox3.SelectedIndex = -1 Then
                ToolStripComboBox3.SelectedIndex = 0
            End If
            c = Me.InformationIDBindingSource.Find(ToolStripComboBox3.Text, ToolStripTextBox2.Text)
            If c > -1 Then
                Me.InformationIDBindingSource.Position = c
            Else
                If NotFoundShowMessageToolStripMenuItem.Checked = True Then
                    MsgBox("Your text is not Found in this Colum...", MsgBoxStyle.Critical)
                End If
            End If
        End If
        If e.Control And e.KeyCode = Keys.B Then
            Me.CollegeNoTextBox.Focus()

        End If
        'AukF.BindGotoFind(Me.InformationBindingSource1, ToolStripComboBox3.Text, ToolStripTextBox2.Text)

    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Me.HouseTextBox.Text = Me.ComboBox5.Text

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged

    End Sub

    Private Sub ComboBox9_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectionChangeCommitted
        'Me.ShiftTextBox.Text = Me.ComboBox9.Text

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged

    End Sub

    Private Sub ComboBox6_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectionChangeCommitted
        'Me.ResidentOrNonResidentTextBox.Text = Me.ComboBox6.Text

    End Sub

    Private Sub ComboBox5_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectionChangeCommitted
        Me.HouseTextBox.Text = Me.ComboBox5.Text

    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub AddNewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.InformationIDBindingSource.AddNew()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.InformationIDBindingSource.RemoveAt(Me.InformationIDBindingSource.Position)

    End Sub

    Private Sub RejectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem.Click
        Me.InformationIDBindingSource.CancelEdit()
        Me.AuksoftDataSet1.InformationID.RejectChanges()

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Cg.DataSource = Me.AuksoftDataSet1.InformationID.GetChanges

    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged

    End Sub

    Private Sub RejectChangesToolStripMenuItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem.DoubleClick

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.ListBox1.SelectedIndex = -1 Then Exit Sub

        If Me.CheckBox18.Checked = True Then
            Me.ListBox1.Items.RemoveAt(Me.ListBox1.SelectedIndex)

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListXw.Show()
        Me.Hide()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Close()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GSql.Sql_ORD_like_false("CollegeNo", "informationid", "val(CollegeNo)", Me.AuksoftDataSet11)


    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        SFC("CollegeNo")
        STC(Me.TextBox16.Text)
        If Me.CheckBox6.Checked = True Then
            GSql.Sql_ORD_like_false("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        Else
            GSql.Sql_Cls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)

        End If

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        SFC("CollegeNo")
        STC(Me.TextBox16.Text)
        If Me.CheckBox6.Checked = True Then
            GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        Else
            GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)

        End If

    End Sub

    Private Sub TextBox16_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox16.KeyDown
        If e.KeyCode = Keys.Enter Then
            SFC("CollegeNo")
            STC(Me.TextBox16.Text)
            If Me.CheckBox6.Checked = True Then
                GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
            Else
                GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)

            End If
        End If
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AukF.CutWordLetter(Me.ColList, Me.ColText.Text, ",", True)

    End Sub

    Private Sub ColText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ColText.KeyDown
        If e.KeyCode = Keys.Enter Then
            AukF.CutWordLetter(Me.ColList, Me.ColText.Text, ",", True)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.ColList.Items.Count > 350 Then
            If AukF.MsgTr("Do you want to open ( " & Me.ColList.Items.Count & ")Students if the College no Match...Its need more time Do you want to do this...? ") = False Then
                Exit Sub
            End If
        End If
        For I = 0 To Me.ColList.Items.Count - 1
            c = Me.ColList.Items.Item(I).ToString
            SFC("CollegeNo")
            STC(c)
            If Me.CheckBox6.Checked = True Then
                GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
                'MsgBox(Sql)

            Else
                GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
                'MsgBox(Sql)
            End If
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.ColList.Items.Clear()

    End Sub

    Private Sub ColList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColList.DoubleClick
        Try
            Me.ColList.Items.RemoveAt(Me.ColList.SelectedIndex)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ColList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColList.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Me.CheckBox1.Checked = True Then
            SF(0) = "StudentClass"
            ST(0) = Me.TextBox1.Text
        End If
        If Me.CheckBox2.Checked = True Then
            SF(1) = "Class_Section"
            ST(1) = Me.TextBox2.Text
        End If
        If Me.CheckBox3.Checked = True Then
            SF(2) = "Position_number"
            EP(2) = Me.ComboBox3.Text & Me.TextBox3.Text
            NM(2) = Me.ComboBox3.Text & Me.TextBox3.Text
            ST(2) = Me.ComboBox3.Text & Me.TextBox3.Text
        End If
        If Me.CheckBox4.Checked = True Then
            SF(3) = "Shift"
            ST(3) = Me.TextBox4.Text
        End If
        If Me.CheckBox5.Checked = True Then
            SF(4) = "House"
            ST(4) = Me.TextBox5.Text
        End If
        If Me.CheckBox6.Checked = True Then
            GSql.NonCls_ORD_NonLikeCommand("*", "informationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        Else
            GSql.Sql_NonCls_Ord_like_From_First("*", "informationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        End If
        'MsgBox(Sql)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.AuksoftDataSet1.InformationID.Clear()

    End Sub

    Private Sub ToolStripTextBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox4.Click

    End Sub

    Private Sub ToolStripTextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            c = Me.InformationIDBindingSource.Find("CollegeNo", ToolStripTextBox4.Text)
            If c > -1 Then
                Me.InformationIDBindingSource.Position = c
            End If
        End If
    End Sub

    Private Sub ToolStripTextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.Click

    End Sub

    Private Sub ToolStripTextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If ExToolStripMenuItem.Checked = True Then
                    Me.InformationIDBindingSource.Filter = "[" & ToolStripComboBox3.Text & "]='" & Me.ToolStripTextBox3.Text & "'"
                    Me.InformationBindingSource1.Filter = "[" & ToolStripComboBox3.Text & "]='" & Me.ToolStripTextBox3.Text & "'"

                Else
                    If AnyWhereInFieldToolStripMenuItem.Checked = False Then
                        Me.InformationIDBindingSource.Filter = "[" & ToolStripComboBox3.Text & "] like '" & Me.ToolStripTextBox3.Text & "*'"
                        'MsgBox("[" & ToolStripComboBox3.Text & "] like '%" & Me.ToolStripTextBox3.Text & "'")
                        Me.InformationBindingSource1.Filter = "[" & ToolStripComboBox3.Text & "] like '" & Me.ToolStripTextBox3.Text & "*'"

                    Else
                        Me.InformationIDBindingSource.Filter = "[" & ToolStripComboBox3.Text & "] like '*" & Me.ToolStripTextBox3.Text & "*'"
                        Me.InformationBindingSource1.Filter = "[" & ToolStripComboBox3.Text & "] like '*" & Me.ToolStripTextBox3.Text & "*'"

                        'MsgBox("[" & ToolStripComboBox3.Text & "] like '*" & Me.ToolStripTextBox3.Text & "*'")

                    End If


                End If
                If Me.NotFoundShowMessageToolStripMenuItem.Checked = True Then
                    If Me.InformationIDBindingSource.Count = 0 Then
                        MsgBox("No Records Found...!", MsgBoxStyle.Information)

                    End If
                End If
                If e.Modifiers = Keys.Control Then
                    If e.KeyCode = Keys.F Then
                        Try
                            FObject.focus()

                        Catch ex As Exception
                            sender.focus()

                        End Try
                    End If
                End If
            Catch ex As Exception
                Epx()
            End Try

        End If
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        Me.InformationIDBindingSource.RemoveFilter()
        Me.InformationBindingSource1.RemoveFilter()

    End Sub

    Private Sub ToolStripTextBox3_TextBoxTextAlignChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextBoxTextAlignChanged

    End Sub

    Private Sub ToolStripTextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextChanged
        AukF.ComSelIndex(ToolStripComboBox3)
        If FilterByTextChangedToolStripMenuItem.Checked = True Then
            Try
                If ExToolStripMenuItem.Checked = True Then
                    Me.InformationIDBindingSource.Filter = "[" & ToolStripComboBox3.Text & "]='" & Me.ToolStripTextBox3.Text & "'"
                    Me.InformationBindingSource1.Filter = "[" & ToolStripComboBox3.Text & "]='" & Me.ToolStripTextBox3.Text & "'"

                Else
                    If AnyWhereInFieldToolStripMenuItem.Checked = False Then
                        Me.InformationIDBindingSource.Filter = "[" & ToolStripComboBox3.Text & "] like '" & Me.ToolStripTextBox3.Text & "*'"
                        'MsgBox("[" & ToolStripComboBox3.Text & "] like '%" & Me.ToolStripTextBox3.Text & "'")
                        Me.InformationBindingSource1.Filter = "[" & ToolStripComboBox3.Text & "] like '" & Me.ToolStripTextBox3.Text & "*'"

                    Else
                        Me.InformationIDBindingSource.Filter = "[" & ToolStripComboBox3.Text & "] like '*" & Me.ToolStripTextBox3.Text & "*'"
                        Me.InformationBindingSource1.Filter = "[" & ToolStripComboBox3.Text & "] like '*" & Me.ToolStripTextBox3.Text & "*'"

                        'MsgBox("[" & ToolStripComboBox3.Text & "] like '*" & Me.ToolStripTextBox3.Text & "*'")

                    End If


                End If
            Catch ex As Exception
                Epx()

            End Try

        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Me.InformationIDDataGridView.DataSource = ""
            Me.Cg.DataSource = ""
            Me.InformationIDBindingSource.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)
            'Me.InformationIDDataGridView.DataSource = Me.InformationIDBindingSource

        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        Me.InformationIDBindingSource.AddNew()
        'Me.InformationIDBindingSource.EndEdit()

    End Sub

    Private Sub CancelSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSaveToolStripMenuItem.Click
        'Me.InformationIDBindingSource.CancelEdit()
        'Me.AuksoftDataSet1.InformationID.RejectChanges()
        AukF2.SingleDataTable_DataRecordRefresh(Me.InformationIDBindingSource, True)

    End Sub

    Private Sub DeleteRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        'On Error Resume Next
        Try
            Me.InformationIDBindingSource.RemoveCurrent()
        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub SaveAndAddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAndAddNewToolStripMenuItem.Click
        SaveToolStripMenuItem_Click(sender, e)
        Me.InformationIDBindingSource.AddNew()
        Me.InformationIDBindingSource.EndEdit()

    End Sub

    Private Sub MoveRecordNextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveRecordNextToolStripMenuItem.Click
        Me.InformationIDBindingSource.MoveNext()

    End Sub

    Private Sub MoveToPreviousRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToPreviousRecordToolStripMenuItem.Click
        Me.InformationIDBindingSource.MovePrevious()
    End Sub

    Private Sub ProgComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgComm.Click

    End Sub

    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        If ToolStripComboBox3.SelectedIndex = -1 Then
            ToolStripComboBox3.SelectedIndex = 0
        End If
        c = Me.InformationIDBindingSource.Find(ToolStripComboBox3.Text, ToolStripTextBox2.Text)
        If c > -1 Then
            Me.InformationIDBindingSource.Position = c
        End If
        AukF.BindGotoFind(Me.InformationBindingSource1, ToolStripComboBox3.Text, sender.text)

    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click, FillTheGridViewToolStripMenuItem.Click, WorkWithDataGridToolStripMenuItem.Click
        Me.TabControl2.SelectedIndex = 1
        Me.InformationIDDataGridView.Focus()

        Me.InformationIDDataGridView.DataSource = Me.InformationBindingSource1
        InformationBindingSource1.ResumeBinding()

        Me.InformationIDBindingSource.SuspendBinding()


    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        SFC("Name")
        STC(Me.TextBox18.Text)
        If Me.CheckBox6.Checked = True Then
            GSql.Sql_ORD_like_false("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        Else
            GSql.Sql_Cls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        SFC("Name")
        STC(Me.TextBox18.Text)
        If Me.CheckBox6.Checked = True Then
            GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        Else
            GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If Me.ColList.Items.Count > 350 Then
            If AukF.MsgTr("Do you want to open ( " & Me.ColList.Items.Count & ")Students if the College no Match...Its need more time Do you want to do this...? ") = False Then
                Exit Sub
            End If
        End If
        For I = 0 To Me.ColList.Items.Count - 1
            c = Me.ColList.Items.Item(I).ToString
            SFC("name")
            STC(c)
            If Me.CheckBox6.Checked = True Then
                GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
                'MsgBox(Sql)

            Else
                GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(CollegeNo)", Me.AuksoftDataSet1)
                'MsgBox(Sql)
            End If
        Next
    End Sub

    Private Sub TextBox18_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox18.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button19_Click(sender, e)

        End If
    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Try
            Me.FInformationsBindingSource.RemoveCurrent()
        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub FilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilToolStripMenuItem.Click
        Try
            me.InformationIDBindingSource .SuspendBinding 
            Me.InformationIDDataGridView.DataSource = Me.InformationBindingSource1
            InformationBindingSource1.ResumeBinding()
            Me.TabControl2.SelectedIndex = 1

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub GotoFilterTextBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoFilterTextBoxToolStripMenuItem.Click
        ToolStripTextBox3.Focus()

    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.ButtonClick, PrintReportAsBioDataToolStripMenuItem.Click
        Dim kp As New PersonalInformation
        Dim Rv As New ReportViewer
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        Rv.Show()
        Rv.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub CLearDatabseErrorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLearDatabseErrorToolStripMenuItem.Click
        AukF.ClearErrorFromDataSet(Me.AuksoftDataSet1)
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        AukF.ClearErrorFromDataSet(Me.AuksoftDataSet1)

    End Sub

    Private Sub CommonAddsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub QueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryManagerToolStripMenuItem.Click
        QueryManager.Show()
        QueryManager.Activate()


    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If AukF.MsgTr(WhatDoso) = True Then
            Me.Close()

        End If
    End Sub

    Private Sub JoiningClassTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JoiningClassTextBox.TextChanged

    End Sub

    Private Sub InformationsEntryKeyPrs(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.CheckBox19.Checked = True Then
                Me.InformationIDBindingSource.MoveNext()

            Else
                Me.TabControl2.SelectNextControl(sender, True, True, True, True)

                If sender.name = Me.ComboBox9.Name Then
                    If Me.InformationIDBindingSource.Position = Me.InformationIDBindingSource.Count - 1 Then
                        Me.InformationIDBindingSource.AddNew()
                    Else
                        Me.InformationIDBindingSource.MoveNext()

                    End If

                    Me.CollegeNoTextBox.Focus()
                End If
            End If

            'Else
            'sender.SelectNextControl(sender, False, True, True, True)

        End If
        If e.Control = True Then
            If e.KeyCode = Keys.Up Then
                Me.TabControl2.SelectNextControl(sender, False, True, True, True)
            ElseIf e.KeyCode = Keys.Down Then
                Me.TabControl2.SelectNextControl(sender, True, True, True, True)

            End If
        End If
    End Sub

    Private Sub InformationIDDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub SelectedItemsCommonAddFunctionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsCommonAddFunctionToolStripMenuItem.Click
        Dim An, Ind As Integer
        Dim str As String = ""

        For An = 0 To Me.InformationIDDataGridView.SelectedRows.Count - 1

            Ind = Me.InformationIDDataGridView.SelectedRows(An).Index
            col = Me.InformationIDDataGridView.CurrentCell.DataGridView(0, Ind).Value.ToString()
            If str = "" Then
                str = col
            Else
                str = str & "," & col
            End If
        Next
        Me.TabControl2.SelectedIndex = 2

        Me.TextBox6.Text = str

    End Sub

    Private Sub SelectedItemsCollegeNoCopyToMemoryAsArrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsCollegeNoCopyToMemoryAsArrayToolStripMenuItem.Click
        Dim An, Ind As Integer
        Dim str As String = ""

        For An = 0 To Me.InformationIDDataGridView.SelectedRows.Count - 1

            Ind = Me.InformationIDDataGridView.SelectedRows(An).Index
            col = Me.InformationIDDataGridView.CurrentCell.DataGridView(0, Ind).Value.ToString()
            If str = "" Then
                str = col
            Else
                str = str & "," & col
            End If
        Next
        Clipboard.Clear()
        Clipboard.SetText(str)
        'MsgBox(str)

    End Sub

    Private Sub SelectedItemsDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsDeleteToolStripMenuItem.Click
        SendKeys.Send("{Delete}")


    End Sub

    Private Sub GetChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetChangesToolStripMenuItem.Click
        Try
            cjh = Me.AuksoftDataSet1.InformationID.GetChanges.Rows.Count
        Catch ex As Exception
            cjh = 0
        End Try
        If cjh > 0 Then
            Me.Cg.DataSource = Me.AuksoftDataSet1.InformationID.GetChanges
            Me.TabControl2.SelectedIndex = 3

        End If
    End Sub

    Private Sub InformationIDDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InformationIDDataGridView.CellEndEdit
        On Error Resume Next
        'Try
        '    ca = Me.InformationIDDataGridView.CurrentCell.RowIndex
        'Catch ex As Exception
        '    ca = -1
        'End Try
        If Me.InformationIDDataGridView.CurrentCell.RowIndex <> -1 Then

            t = Me.InformationIDDataGridView.CurrentCell.DataGridView(0, Me.InformationIDDataGridView.CurrentCell.RowIndex).Value.ToString
            If IsNumeric(t) = False Then
                MsgBox("College No can't Accept Expression...So (" & t & ") can't be accepted please Check... Your Self at row " & Me.InformationIDDataGridView.CurrentCell.RowIndex & "...", MsgBoxStyle.Critical)
                Me.InformationIDDataGridView.CurrentCell.DataGridView(0, Me.InformationIDDataGridView.CurrentCell.RowIndex).Value = ""

            End If
        End If

    End Sub

    Private Sub CollegeNoTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CollegeNoTextBox.Validated
        If Me.InformationIDBindingSource.Position <> -1 Then
            If IsNumeric(sender.text) = False Then
                MsgBox("Please type Number in CollgeNo Field...", MsgBoxStyle.Critical)

                Me.CollegeNoTextBox.Focus()

            End If
        End If

    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If Me.Cursor.Position.X <> 0 Then
            Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)

        End If

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub



    Private Sub CommAdd_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles YearCombox.KeyDown, TextBox9.KeyDown, TextBox8.KeyDown, TextBox7.KeyDown, TextBox15.KeyDown, TextBox14.KeyDown, TextBox13.KeyDown, TextBox12.KeyDown, TextBox11.KeyDown, TextBox10.KeyDown, ComboBox12.KeyDown, ComboBox11.KeyDown, ComboBox10.KeyDown, CheckBox9.KeyDown, CheckBox8.KeyDown, CheckBox16.KeyDown, CheckBox15.KeyDown, CheckBox14.KeyDown, CheckBox13.KeyDown, CheckBox12.KeyDown, CheckBox11.KeyDown, CheckBox10.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SplitContainer1.Panel2.SelectNextControl(sender, True, True, True, True)

        End If
    End Sub


    Private Sub ComboBox5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox5.Validating
        Me.HouseTextBox.Text = Me.ComboBox5.Text

    End Sub

    Private Sub InformationIDDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InformationIDDataGridView.CellContentClick

    End Sub

    Private Sub BeforeSaveUnFillGridToSaveFastToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeforeSaveUnFillGridToSaveFastToolStripMenuItem.Click

    End Sub

    Private Sub NameColumnFrozenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameColumnFrozenToolStripMenuItem.Click
        Me.InformationIDDataGridView.Columns(1).Frozen = Me.NameColumnFrozenToolStripMenuItem.Checked

    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged

    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        strn = AukF2.AukConvertKeysTo(Clipboard.GetText.Trim, Chr(13), ",", False, False, True)
        Me.TextBox6.Text = strn

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Me.TextBox6.Text = ""
        Me.TextBox6.Focus()
    End Sub

    Private Sub InputCollegeNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputCollegeNoToolStripMenuItem.Click
        AukF2.GetCopyedItemsFromExcel_Or_SomeWhereElse(Clipboard.GetText.Trim, Chr(13), "2", Me.InformationIDBindingSource, "", "", True, "", True, True, False, False, False, True, True, False)


    End Sub

    Private Sub SelectedItemsReplaceByIndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsReplaceByIndexToolStripMenuItem.Click
        Me.InformationIDDataGridView.Visible = False

        If Me.InformationIDDataGridView.CurrentCell.ColumnIndex = 13 Then
            'MsgBox("ok")

            AukF2.ReplaceInGrid(Me.InformationIDDataGridView, Clipboard.GetText.Trim.ToString, Me.InformationIDDataGridView.CurrentCell.ColumnIndex, False, Chr(13), "0", True, Me.ToolStripProgressBar1, True, False, "", False, True, False, "", "Res", "Resident")

        Else
            AukF2.ReplaceInGrid(Me.InformationIDDataGridView, Clipboard.GetText.Trim.ToString.TrimStart.TrimEnd.ToString, Me.InformationIDDataGridView.CurrentCell.ColumnIndex, False, Chr(13), "0", True, Me.ToolStripProgressBar1, True, False, "", False, True, False, "", "	", "")

        End If
        Me.InformationIDDataGridView.Visible = True

    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click, WorkWithFormToolStripMenuItem.Click
        'Me.InformationBindingSource1.SuspendBinding()'
        Me.TabControl2.SelectedIndex = 0
        Me.CollegeNoTextBox.Focus()

        Me.InformationBindingSource1.SuspendBinding()
        Me.InformationIDDataGridView.DataSource = ""
        Me.InformationIDBindingSource.ResumeBinding()
        'Me.InformationIDDataGridView.DataSource = Me.InformationBindingSource1

    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.InformationIDBindingSource.ResumeBinding()

    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        'Me.InformationIDBindingSource.ResetCurrentItem()
        'Me.InformationIDBindingSource.ResetItem(0)
        'Me.AuksoftDataSet1.InformationID.Rows(0).RejectChanges()

        'Me.AuksoftDataSet1.InformationID.RejectChanges()
        'Me.InformationIDBindingSource.SuspendBinding()
        'For I = 0 To Me.TabPage4.Controls.Count - 1


        'Next
        Me.InformationIDBindingSource.SuspendBinding()

        Me.InformationIDDataGridView.DataSource = Me.InformationIDBindingSource



    End Sub

    Private Sub RefreshCurrentItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshCurrentItemToolStripMenuItem.Click
        AukF2.Single_DataRecordRefresh(Me.InformationIDBindingSource, True)

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'AukF2.Single_DataRecordRefresh(Me.InformationBindingSource1, True)

    End Sub

    Private Sub InsertListCollegeNosInvertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertListCollegeNosInvertToolStripMenuItem.Click
        Dim Sy As String = ""

        Try
            For I = 0 To Me.InformationIDBindingSource.Count - 1
                col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
                If Me.ListBox1.FindStringExact(col) = -1 Then
                    If Sy = "" Then
                        Sy = col
                    Else
                        Sy = Sy & "," & col
                    End If
                End If
            Next
            Me.ListBox1.Items.Clear()
            AukF2.CutWordLetter(Me.ListBox1, Sy, ",")
        Catch ex As Exception
            Epx()

        End Try
      
    End Sub

    Private Sub InsertTextBoxArrayCollgeNosInvertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertTextBoxArrayCollgeNosInvertToolStripMenuItem.Click
        Button11_Click(sender, e)
        AukF2.DelItemsFromList(Me.ListBox1, Me.TextBox6.Text, ",")

    End Sub

    Private Sub DeleteFromListTextBoxArrayCollegeNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFromListTextBoxArrayCollegeNoToolStripMenuItem.Click
        AukF2.DelItemsFromList(Me.ListBox1, Me.TextBox6.Text, ",")

    End Sub

    Private Sub Button27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        AukF2.ContextShow(Me.ContextMenuStrip3)
    End Sub

    Private Sub Prnt_Sheet(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportAsSheetToolStripMenuItem.Click
        Dim x As New PersonalInformationDbType
        x.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.CrystalReportViewer1.ReportSource = x
        ReportViewer.Show()

    End Sub

    Private Sub RejectWholeTable(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        AukF2.SingleDataTable_DataRecordRefresh(Me.InformationBindingSource1, True)

    End Sub

    Private Sub SingleRefresh(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        AukF2.Single_DataRecordRefresh(Me.InformationBindingSource1, True)

    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Dim uk As New OpenFileDialog
        uk.Filter = "Jpg Files|*.jpg|Png Files|*.Png|Bmp Files|*.Bmp|Gif Files|*.Gif|All Files|*.*"
        uk.Title = "Browse Image for Students..."
        uk.FilterIndex = 0
        If uk.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Me.Student_ImagePictureBox.Image = System.Drawing.Image.FromFile(uk.FileName.ToString)

            Catch ex As Exception
                Epx()

            End Try


        End If

    End Sub

    Private Sub ImageBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageBrowserToolStripMenuItem.Click
        Image_Browser.InformationIDBindingSource.DataSource = Me.AuksoftDataSet1.InformationID

        'Image_Browser.InformationIDBindingSource.DataMember = Me.InformationIDBindingSource.DataMember

        Image_Browser.Show()
        Image_Browser.Activate()
        Me.Hide()

    End Sub


    Private Sub AnyWhereInFieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnyWhereInFieldToolStripMenuItem.Click

    End Sub

    Private Sub SetFilterToPrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFilterToPrintToolStripMenuItem.Click
        If AukF2.Check_Data_Object_Is_ChageOrNot(Me.InformationIDBindingSource, True) = Windows.Forms.DialogResult.Yes Then
            ClassOptionsBindingNavigatorSaveItem_Click(sender, e)
            GoTo Dojob1
        ElseIf AukF2.Check_Data_Object_Is_ChageOrNot(Me.InformationIDBindingSource, True) = Windows.Forms.DialogResult.No Then
            GoTo Dojob1
        End If
        Exit Sub

Dojob1:
        AukF2.DataSetFilter(Me.InformationIDBindingSource, True, False, True, True)
        MsgBox("Please Open Again From QueryManager(StudentProfile).", MsgBoxStyle.Information)
        Me.CollegeNoTextBox.Focus()
        Me.InformationIDDataGridView.Focus()

    End Sub

    Private Sub InformationIDDataGridView_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles InformationIDDataGridView.Enter
        FObject = sender

    End Sub

    Private Sub OnEnt(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalMarksTextBox.Enter, SectionTextBox.Enter, ResultTextBox.Enter, PositionTextBox.Enter, NameTextBox.Enter, Mother_sNameTextBox.Enter, LastTermExamTextBox.Enter, JoiningDateTextBox.Enter, JoiningClassTextBox.Enter, HouseTextBox.Enter, Father_sNameTextBox.Enter, DateOfBirthTextBox.Enter, ContactNumberTextBox.Enter, ComboBox9.Enter, ComboBox6.Enter, ComboBox5.Enter, CollegeNoTextBox.Enter, ClassTextBox.Enter, AddressTextBox.Enter
        FObject = sender

    End Sub

    Private Sub KpEd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TotalMarksTextBox.KeyDown, SectionTextBox.KeyDown, ResultTextBox.KeyDown, PositionTextBox.KeyDown, NameTextBox.KeyDown, Mother_sNameTextBox.KeyDown, LastTermExamTextBox.KeyDown, JoiningDateTextBox.KeyDown, JoiningClassTextBox.KeyDown, HouseTextBox.KeyDown, Father_sNameTextBox.KeyDown, DateOfBirthTextBox.KeyDown, ContactNumberTextBox.KeyDown, ComboBox9.KeyDown, ComboBox6.KeyDown, ComboBox5.KeyDown, CollegeNoTextBox.KeyDown, ClassTextBox.KeyDown, AddressTextBox.KeyDown
        'FObject = sender
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.F Then
                ToolStripTextBox3.Focus()

            End If
        End If
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class