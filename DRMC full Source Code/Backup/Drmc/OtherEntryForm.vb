Public Class OtherEntryForm
    Dim SubIDF, SubIDS As String
    Dim UMainID As String
    Dim COnQua As String
    'Dim SubIDS As String
    Dim QMainID As String
    'Dim SubIDF As String
    Public Tms As String
    Dim Working As Boolean
    Dim Job As Integer
    Dim Yr As String
    Dim Clx As String
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
    Dim Senior As Boolean
    Dim Jonior1 As Boolean
    Dim SumConPos, SumPos, AcNPos, AcNConPos As Integer
    Dim Qi As Integer
    Dim Qi2 As Integer
    Private Sub InformationIDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.InformationIDBindingSource.EndEdit()
        'Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)

    End Sub
    Public Sub InsCol2(ByVal Collegeno As String)
        Dim k As Integer
        MainID = Yearx & ClasT & Sec & Subject & Term & Shift & Collegeno
        UMainID = ClasT & Sec & Term & Shift & Yearx & Collegeno
        SubID = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & Term & ")Shift(" & Shift & ")"
        SubIDF = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shift & ")"
        SubIDS = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shift & ")"

        Try
            m = Me.InformationIDBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                'Me.InformationIDBindingSource.Position = m '

            End If
            m = Me.ClassTeacherCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                'Me.ClassTeacherCommentsBindingSource.Position = m '
            Else
                Me.ClassTeacherCommentsBindingSource.AddNew()
                Me.ClassTeacherCommentsBindingSource.EndEdit()
                Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).Collegeno = Collegeno

            End If
            m = Me.HousemasterCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                'Me.HousemasterCommentsBindingSource.Position = m '
            Else
                Me.HousemasterCommentsBindingSource.AddNew()
                Me.HousemasterCommentsBindingSource.EndEdit()
                Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).CollegeNo = Collegeno

            End If
            m = Me.GamesTeacherCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                'Me.GamesTeacherCommentsBindingSource.Position = m '
            Else
                Me.GamesTeacherCommentsBindingSource.AddNew()
                Me.GamesTeacherCommentsBindingSource.EndEdit()
                Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).Collegeno = Collegeno
            End If
            m = Me.MedicalOfficerCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                'Me.MedicalOfficerCommentsBindingSource.Position = m '
                'MsgBox(Collegeno)
                k = m

                Me.AuksoftDataSet1.MedicalOfficerComments(k).Item(1) = UMainID
                Me.AuksoftDataSet1.MedicalOfficerComments(k).Item(2) = SubID
                Me.AuksoftDataSet1.MedicalOfficerComments(k).Item(3) = Collegeno
            Else
                'MsgBox(Collegeno)
                Me.MedicalOfficerCommentsBindingSource.AddNew()
                Me.MedicalOfficerCommentsBindingSource.EndEdit()
                I = Me.MedicalOfficerCommentsBindingSource.Position
                Me.AuksoftDataSet1.MedicalOfficerComments(I).Item(1) = UMainID
                Me.AuksoftDataSet1.MedicalOfficerComments(I).Item(2) = SubID
                Me.AuksoftDataSet1.MedicalOfficerComments(I).Item(3) = Collegeno
            End If
            m = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                'Me.DaysOFWorksBindingSource.Position = m '
            Else
                Me.DaysOFWorksBindingSource.AddNew()
                Me.DaysOFWorksBindingSource.EndEdit()
                Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).Collegeno = Collegeno

            End If
        Catch ex As Exception
            Epx()
            'If AukF.MsgTr("Do you want to Exit From Function?") = True Then
            '    Exit Sub
            'End If
        End Try

    End Sub
    Public Sub InsCol(ByVal Collegeno As String)
        MainID = Yearx & ClasT & Sec & Subject & Term & Shift & Collegeno
        UMainID = ClasT & Sec & Term & Shift & Yearx & Collegeno
        SubID = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & Term & ")Shift(" & Shift & ")"
        SubIDF = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shift & ")"
        SubIDS = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shift & ")"

        Try
            m = Me.InformationIDBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                Me.InformationIDBindingSource.Position = m '

            End If
            m = Me.ClassTeacherCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                Me.ClassTeacherCommentsBindingSource.Position = m '
            Else
                Me.ClassTeacherCommentsBindingSource.AddNew()
                Me.ClassTeacherCommentsBindingSource.EndEdit()
                Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).Collegeno = Collegeno

            End If
            m = Me.HousemasterCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                Me.HousemasterCommentsBindingSource.Position = m '
            Else
                Me.HousemasterCommentsBindingSource.AddNew()
                Me.HousemasterCommentsBindingSource.EndEdit()
                Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).CollegeNo = Collegeno

            End If
            m = Me.GamesTeacherCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                Me.GamesTeacherCommentsBindingSource.Position = m '
            Else
                Me.GamesTeacherCommentsBindingSource.AddNew()
                Me.GamesTeacherCommentsBindingSource.EndEdit()
                Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).Collegeno = Collegeno


            End If
            m = Me.MedicalOfficerCommentsBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                Me.MedicalOfficerCommentsBindingSource.Position = m '
            Else
                Me.MedicalOfficerCommentsBindingSource.AddNew()
                Me.MedicalOfficerCommentsBindingSource.EndEdit()
                I = Me.MedicalOfficerCommentsBindingSource.Position
                Me.AuksoftDataSet1.MedicalOfficerComments(I).Item(1) = UMainID
                Me.AuksoftDataSet1.MedicalOfficerComments(I).Item(2) = SubID
                Me.AuksoftDataSet1.MedicalOfficerComments(I).Item(3) = Collegeno

            End If
            m = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
            If m > -1 Then
                Me.DaysOFWorksBindingSource.Position = m '
            Else
                Me.DaysOFWorksBindingSource.AddNew()
                Me.DaysOFWorksBindingSource.EndEdit()
                Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).MainID = UMainID
                Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).SubID = SubID
                Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).Collegeno = Collegeno

            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ColFind(ByVal Collegeno As String)
        MainID = Yearx & ClasT & Sec & Subject & Term & Shift & Collegeno
        UMainID = ClasT & Sec & Term & Shift & Yearx & Collegeno
        SubID = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & Term & ")Shift(" & Shift & ")"
        SubIDF = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shift & ")"
        SubIDS = "Year(" & Yearx & ")" & "ClassSec(" & ClasT & Sec & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shift & ")"

        m = Me.InformationIDBindingSource.Find("Collegeno", Collegeno)
        If m > -1 Then
            Me.InformationIDBindingSource.Position = m '

        End If
        m = Me.ClassTeacherCommentsBindingSource.Find("Collegeno", Collegeno)
        If m > -1 Then
            Me.ClassTeacherCommentsBindingSource.Position = m '
        Else
            'Me.ClassTeacherCommentsBindingSource.AddNew()
            'Me.ClassTeacherCommentsBindingSource.EndEdit()
            'Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).MainID = UMainID
            'Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).SubID = SubID
            'Me.AuksoftDataSet1.ClassTeacherComments(Me.ClassTeacherCommentsBindingSource.Position).Collegeno = SubID

        End If
        m = Me.HousemasterCommentsBindingSource.Find("Collegeno", Collegeno)
        If m > -1 Then
            Me.HousemasterCommentsBindingSource.Position = m '
        Else
            'Me.HousemasterCommentsBindingSource.AddNew()
            'Me.HousemasterCommentsBindingSource.EndEdit()
            'Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).MainID = UMainID
            'Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).SubID = SubID
            'Me.AuksoftDataSet1.HousemasterComments(Me.HousemasterCommentsBindingSource.Position).CollegeNo = SubID

        End If
        m = Me.GamesTeacherCommentsBindingSource.Find("Collegeno", Collegeno)
        If m > -1 Then
            Me.GamesTeacherCommentsBindingSource.Position = m '
        Else
            'Me.GamesTeacherCommentsBindingSource.AddNew()
            'Me.GamesTeacherCommentsBindingSource.EndEdit()
            'Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).MainID = UMainID
            'Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).SubID = SubID
            'Me.AuksoftDataSet1.GamesTeacherComments(Me.GamesTeacherCommentsBindingSource.Position).Collegeno = SubID

        End If
        m = Me.MedicalOfficerCommentsBindingSource.Find("Collegeno", Collegeno)
        If m > -1 Then
            Me.MedicalOfficerCommentsBindingSource.Position = m '
        Else
            'Me.MedicalOfficerCommentsBindingSource.AddNew()
            'Me.MedicalOfficerCommentsBindingSource.EndEdit()
            'Me.AuksoftDataSet1.MedicalOfficerComments(Me.MedicalOfficerCommentsBindingSource.Position).MainID = UMainID
            'Me.AuksoftDataSet1.MedicalOfficerComments(Me.MedicalOfficerCommentsBindingSource.Position).SubID = SubID
            'Me.AuksoftDataSet1.MedicalOfficerComments(Me.MedicalOfficerCommentsBindingSource.Position).Collegeno = SubID

        End If
        m = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
        If m > -1 Then
            Me.DaysOFWorksBindingSource.Position = m '
        Else
            'Me.DaysOFWorksBindingSource.AddNew()
            'Me.DaysOFWorksBindingSource.EndEdit()
            'Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).MainID = UMainID
            'Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).SubID = SubID
            'Me.AuksoftDataSet1.DaysOFWorks(Me.DaysOFWorksBindingSource.Position).Collegeno = SubID

        End If
    End Sub
    Public Sub Saved()
        Try
            Me.ClassTeacherCommentsBindingSource.EndEdit()

            Me.ClassTeacherCommentsTableAdapter.Update(Me.AuksoftDataSet1)
            Me.HousemasterCommentsBindingSource.EndEdit()
            Me.HousemasterCommentsTableAdapter.Update(Me.AuksoftDataSet1)
            Me.GamesTeacherCommentsBindingSource.EndEdit()
            Me.GamesTeacherCommentsTableAdapter.Update(Me.AuksoftDataSet1)

            Me.MedicalOfficerCommentsBindingSource.EndEdit()
            Me.DaysOFWorksBindingSource.EndEdit()
            Me.DaysOFWorksTableAdapter.Update(Me.AuksoftDataSet1)

            Me.MedicalOfficerCommentsTableAdapter.Update(Me.AuksoftDataSet1)
        Catch ex As Exception
            Epx()

        End Try


    End Sub
    Public Sub Opener()
        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        SummaryID = Clx & Sec & TR & Shv & Yr & Subx
        If Trd = False Then
            If Term = "FIRST TERM" Then
                Tms = 1
            ElseIf Term = "SECOND TERM" Then
                Tms = 2
            End If
        Else
            Tms = 3
        End If
        SFC("SubID")
        STC(SubID)
        'MsgBox(SubID)
        GSql.Sql_ORD_like_false("*", "daysofworks", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("StudentClass", "Class_Section", "Shift")
        STC(Clx, Secx, Shv)
        GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        'MsgBox(SubID)
        GSql.Sql_ORD_like_false("*", "ClassTeacherComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "HousemasterComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "GamesTeacherComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "MedicalOfficerComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "DaysofWorks", "val(Collegeno)", Me.AuksoftDataSet1)
        Nums.Text = Me.CollegenoMainCombo.Items.Count

    End Sub
    Private Sub OtherEntryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.House' table. You can move, or remove it, as needed.
        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd
        Senior = Ac1Sec
        Me.HouseTableAdapter.Fill(Me.AuksoftDataSet1.House)
        AukF.XPAuk(Me)


    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Saved()

    End Sub

    Private Sub QueryLoadRefreshDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryLoadRefreshDatabaseToolStripMenuItem.Click
        Opener()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub QueryFormLoadDatabaseOpenFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        QueryManager.Show()
        Me.Hide()

    End Sub

    Private Sub QueryManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryManagerToolStripMenuItem.Click
        QueryManager.Show()
        Me.Hide()

    End Sub

    Private Sub InputAllCollegenoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputAllCollegenoToolStripMenuItem.Click
        Dim k As Integer
        For k = 0 To Me.InformationIDBindingSource.Count - 1
            Try
                InsCol2(Me.AuksoftDataSet1.InformationID(k).CollegeNo)
            Catch ex As Exception
                Epx()
                If AukF.MsgTr("Do you want to Exit From Function?") = True Then
                    Exit Sub
                End If
            End Try



        Next
        If AukF.MsgTr(What & "Save ?,Without Save Changes Couldn't be accpted... ") = True Then
            Saved()
            Opener()

        End If
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub CollegenoMainCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegenoMainCombo.SelectedIndexChanged

    End Sub

    Private Sub CollegenoMainCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CollegenoMainCombo.SelectionChangeCommitted
        Try
            ColFind(sender.text)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub Inp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Inp.KeyDown
        If e.KeyCode = Keys.Enter Then
            ak()
        End If

    End Sub

    Private Sub Inp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inp.TextChanged

    End Sub
    Public Sub ak()
        AukF.CutWordLetter(Me.ListBox1, Me.Inp.Text, ",", True)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ak()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InputInfo()
        If AukF.MsgTr(What & "Save ?,Without Save Changes Couldn't be accpted... ") = True Then
            Saved()
            OtherEntryForm_Load(sender, e)
            Opener()

        End If
    End Sub
    Public Sub InputInfo()
        Me.HousemasterCommentsDataGridView.DataSource = ""
        Me.ClassTeacherCommentsDataGridView.DataSource = ""
        Me.MedicalOfficerCommentsDataGridView.DataSource = ""
        Me.GamesTeacherCommentsDataGridView.DataSource = ""
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        perpix = 100 / Me.ListBox1.Items.Count
        For o = 0 To Me.ListBox1.Items.Count - 1
            m = Me.ListBox1.Items.Item(o)
            If Me.HouseCheck.Checked = True Then
                I = Me.ClassTeacherCommentsBindingSource.Find("collegeno", m)
                If I > -1 Then
                    HouseIn()
                End If
            End If
            If Me.GamesTeacher.Checked = True Then
                I = Me.GamesTeacherCommentsBindingSource.Find("collegeno", m)
                If I > -1 Then
                    GamesIn()
                    'Me.AuksoftDataSet1.GamesTeacherComments(I).Final_Average_Grading = Me.TextBox8.Text
                End If
            End If
            If Me.ClasCheck.Checked = True Then
                I = Me.ClassTeacherCommentsBindingSource.Find("collegeno", m)
                If I > -1 Then
                    ClassIn()
                    'Me.AuksoftDataSet1.GamesTeacherComments(I).Final_Average_Grading = Me.TextBox8.Text
                End If
            End If
            If Me.MediCombo.Checked = True Then
                I = Me.MedicalOfficerCommentsBindingSource.Find("collegeno", m)
                If I > -1 Then
                    mediInput()
                    'Me.AuksoftDataSet1.GamesTeacherComments(I).Final_Average_Grading = Me.TextBox8.Text
                End If
            End If
            Me.ProgressBar1.Value = Me.ProgressBar1.Value + Val(perpix)
        Next
        Me.ProgressBar1.Visible = False

        Me.HousemasterCommentsDataGridView.DataSource = Me.HousemasterCommentsBindingSource
        Me.ClassTeacherCommentsDataGridView.DataSource = Me.ClassTeacherCommentsBindingSource
        Me.MedicalOfficerCommentsDataGridView.DataSource = Me.MedicalOfficerCommentsBindingSource
        Me.GamesTeacherCommentsDataGridView.DataSource = Me.GamesTeacherCommentsBindingSource

    End Sub
    Public Sub mediInput()
        If Me.CheckBox1.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Height = Me.TextBox1.Text
        End If
        If Me.CheckBox2.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Width = Me.TextBox2.Text
        End If
        If Me.CheckBox3.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Chest = Me.TextBox3.Text
        End If
        If Me.CheckBox4.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).ENT = Me.TextBox4.Text
        End If
        If Me.CheckBox5.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Skin = Me.TextBox5.Text
        End If
        If Me.CheckBox6.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Teeth = Me.TextBox6.Text
        End If
        If Me.CheckBox7.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Any_serious_illness_during_the_term = Me.TextBox7.Text
        End If
        If Me.CheckBox8.Checked = True Then
            Me.AuksoftDataSet1.MedicalOfficerComments(I).Comments = Me.TextBox8.Text
        End If
    End Sub

    Public Sub HouseIn()
        If Me.CheckBox1.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I)._Adaptability___Cooperation = Me.TextBox1.Text

        End If
        If Me.CheckBox2.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I)._Responsibility__Initiative = Me.TextBox2.Text

        End If
        If Me.CheckBox3.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I).Confidence = Me.TextBox3.Text

        End If
        If Me.CheckBox4.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I).Ledership_Quality = Me.TextBox4.Text

        End If
        If Me.CheckBox5.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I)._Loyatty___Truthfulnes = Me.TextBox5.Text

        End If
        If Me.CheckBox6.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I)._Health___Cleanliness = Me.TextBox6.Text

        End If
        If Me.CheckBox7.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I).House_Contribution = Me.TextBox7.Text

        End If
        If Me.CheckBox8.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I).Final_Average_Grading = Me.TextBox8.Text

        End If
        If Me.CheckBox9.Checked = True Then
            Me.AuksoftDataSet1.HousemasterComments(I).Comments = Me.TextBox9.Text

        End If
    End Sub
    Public Sub HouseMas()
        For o = 0 To Me.ListBox1.Items.Count - 1
            m = Me.ListBox1.Items.Item(o)
            'MsgBox(m)
            I = Me.HousemasterCommentsBindingSource.Find("collegeno", m)
            If I > -1 Then
     
            End If
        Next
    End Sub
    Public Sub Games()
        For o = 0 To Me.ListBox1.Items.Count - 1
            m = Me.ListBox1.Items.Item(o)
       
        Next
    End Sub
    Public Sub GamesIn()
        If Me.CheckBox1.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I).Punctuality = Me.TextBox1.Text

        End If
        If Me.CheckBox2.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I).Discipline = Me.TextBox2.Text

        End If
        If Me.CheckBox3.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I).Physical_Ability = Me.TextBox3.Text

        End If
        If Me.CheckBox4.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I).Endurance = Me.TextBox4.Text

        End If
        If Me.CheckBox5.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I)._Participation_In_Games___Sports = Me.TextBox5.Text

        End If
        If Me.CheckBox6.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I).Final_Grading = Me.TextBox6.Text

        End If
        If Me.CheckBox7.Checked = True Then
            Me.AuksoftDataSet1.GamesTeacherComments(I).Comments = Me.TextBox7.Text

        End If
        If Me.CheckBox8.Checked = True Then

        End If
    End Sub
    Public Sub ClassTeacher()
   
    End Sub
    Public Sub ClassIn()
        If Me.CheckBox2.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I).Oral_Expression = Me.TextBox2.Text

        End If
        If Me.CheckBox3.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I).WrittenWork_Expression = Me.TextBox3.Text

        End If
        If Me.CheckBox4.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I).Attentiveness = Me.TextBox4.Text

        End If
        If Me.CheckBox5.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I)._Class_Participation_Conduct___Dicipline = Me.TextBox5.Text

        End If
        If Me.CheckBox6.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I)._Dress___Cleanliness = Me.TextBox6.Text

        End If
        If Me.CheckBox7.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I)._Hobies___Co_Curriculam_Activies = Me.TextBox7.Text

        End If
        If Me.CheckBox8.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I).Final_Grading = Me.TextBox8.Text

        End If
        If Me.CheckBox1.Checked = True Then
            Me.AuksoftDataSet1.ClassTeacherComments(I)._Briliance___Academic_Originality = Me.TextBox1.Text

        End If
    End Sub
    Private Sub SplitContainer2_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ListBox1.Items.Clear()
        For I = 0 To Me.CollegenoMainCombo.Items.Count - 1
            c = Me.AuksoftDataSet1.InformationID(I).CollegeNo
            Me.ListBox1.Items.Add(c)
        Next
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Try
            Me.ListBox1.Items.RemoveAt(Me.ListBox1.SelectedItem.ToString)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                c = Me.ListBox1.SelectedIndex
                Me.ListBox1.Items.RemoveAt(Me.ListBox1.SelectedIndex)
                Me.ListBox1.SelectedIndex = c
            End If
        Catch ex As Exception

            'Epx()
        End Try
   
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            For m = (Me.ListBox1.SelectedItems.Count - 1) To 0 Step -1
                'MsgBox(m)

                'MsgBox(Me.ListBox1.SelectedItems.Item(m))
                'MsgBox()
                c = Me.ListBox1.SelectedItems.Item(m)
                'MsgBox(c)

                d = Me.ListBox1.FindStringExact(c)
                'MsgBox(d)

                Me.ListBox1.Items.RemoveAt(d)



                'MsgBox()


            Next
        Catch ex As Exception

        End Try



    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
       
    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub ToolStripLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel7.Click
        mw = Me.TotalDaystext.Text
        For I = 0 To Me.DaysOFWorksBindingSource.Count - 1
            Me.AuksoftDataSet1.DaysOFWorks(I).TotalDays = mw
        Next
    End Sub

    Private Sub TotalDaystext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDaystext.Click

    End Sub

    Private Sub TotalDaystext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TotalDaystext.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripLabel7_Click(sender, e)

        End If
    End Sub

    Private Sub ToolStripButton35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton35.Click
        'mw = Me.TotalDaystext.Text
        On Error Resume Next

        For I = 0 To Me.DaysOFWorksBindingSource.Count - 1
            tday = Me.AuksoftDataSet1.DaysOFWorks(I).Item(6).ToString

            abday = Me.AuksoftDataSet1.DaysOFWorks(I).Item(5).ToString
            If abday = "" Then
                Me.AuksoftDataSet1.DaysOFWorks(I).AbsentDays = 0
            End If
            Me.AuksoftDataSet1.DaysOFWorks(I).WorkingDays = Val(tday) - Val(abday)

        Next
    End Sub

    Private Sub CollegenoFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegenoFind.TextChanged
        crq = CollegenoFind.Text
        n = Me.ClassTeacherCommentsBindingSource.Find("collegeno", crq)
        If n > -1 Then
            Me.ClassTeacherCommentsBindingSource.Position = n
        End If
        n = Me.MedicalOfficerCommentsBindingSource.Find("collegeno", crq)
        If n > -1 Then
            Me.MedicalOfficerCommentsBindingSource.Position = n

        End If
        n = Me.HousemasterCommentsBindingSource.Find("collegeno", crq)
        If n > -1 Then
            Me.HousemasterCommentsBindingSource.Position = n

        End If
        n = Me.GamesTeacherCommentsBindingSource.Find("collegeno", crq)
        If n > -1 Then
            Me.GamesTeacherCommentsBindingSource.Position = n
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'SFC("Class", "Section", "Shift", "House")
        'STC(Clx, Secx, Shv, Me.ComboBox1.Text)
        'GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
    End Sub

    Private Sub ToolStripButton37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton37.Click
        AukF.DelRecAll("Housemaster'sComments", Me.HousemasterCommentsBindingSource)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub BlankClassTeacherCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankClassTeacherCommentsToolStripMenuItem.Click
        Dim kp As New BlankClassTeacherComments
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub BlankClassTeacherCommentsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankClassTeacherCommentsToolStripMenuItem1.Click
        Dim kp As New blankComments
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub BlankClassTeacherCommentsToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlankClassTeacherCommentsToolStripMenuItem3.Click
        Dim kp As New BlankMedicalofficers
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub InformationIDBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationIDBindingNavigatorSaveItem.Click
        Try
            Me.MedicalOfficerCommentsBindingSource.EndEdit()
            Me.MedicalOfficerCommentsTableAdapter.Update(Me.AuksoftDataSet1.MedicalOfficerComments)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Try

            Me.HousemasterCommentsBindingSource.EndEdit()
            Me.HousemasterCommentsTableAdapter.Update(Me.AuksoftDataSet1.HousemasterComments)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        Try
            Me.ClassTeacherCommentsBindingSource.EndEdit()
            Me.ClassTeacherCommentsTableAdapter.Update(Me.AuksoftDataSet1.ClassTeacherComments)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton33.Click
        Try
            Me.GamesTeacherCommentsBindingSource.EndEdit()
            Me.GamesTeacherCommentsTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton42.Click
        Try
            Me.DaysOFWorksBindingSource.EndEdit()
            Me.DaysOFWorksTableAdapter.Update(Me.AuksoftDataSet1.DaysOFWorks)

        Catch ex As Exception
            Epx()

        End Try
    End Sub
End Class