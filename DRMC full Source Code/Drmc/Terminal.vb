Imports System.Data.SqlClient
Public Class Terminal
    Dim COnQua As String
    Dim SubIDS As String
    Dim QMainID As String
    Dim SubIDF As String
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
    Dim DefMain, SNID, MNID As String
    Dim T3rd As Boolean
    Dim Vid As String
    Dim SummaryID As String
    Dim GwRk As String = GTxt
    Dim APos, SingPos, ObjPos, SubjPos, ClPos, GrkPos As Integer
    Dim SubjectPosition As Integer
    Dim DefCn As New DataTable
    Dim Lq As Integer
    Dim WrkBind As New BindingSource
    Dim SvAdp As OleDb.OleDbDataAdapter
    Dim Nine As Boolean
    'Dim SubCombo As ComboBox = Me.SubList
    Dim ConvertedNumConvertSubjective As String
    Dim ConvertedNumConvertObjective As String



    Private Sub SubjectSingleNumbersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectSingleNumbersBindingNavigatorSaveItem.Click
        Try
            ToolStripMenuItem1_Click(sender, e)
        Catch ex As Exception
            Epx()
        End Try

    End Sub

    Private Sub Terminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Viewers' table. You can move, or remove it, as needed.
        Me.ViewersTableAdapter.Fill(Me.AuksoftDataSet1.Viewers)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.PassMarks' table. You can move, or remove it, as needed.
        'Me.PassMarksTableAdapter.Fill(Me.AuksoftDataSet1.PassMarks)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Acc2Subject' table. You can move, or remove it, as needed.
        'Me.Acc2SubjectTableAdapter.Fill(Me.AuksoftDataSet1.Acc2Subject)
        'Me.Acc2ConvertTableAdapter.Fill(Me.AuksoftDataSet1.Acc2Convert)
        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd
        'Opener()
        If Val(Clx) > 10 Then
            'Me.SubList.DataSource = Me.AuksoftDataSet1.SubjectPosition
            'Me.SubList.DisplayMember = "Subject"
            'SFC("Class", "Group")

            If GwRk = "Commerce" Or GwRk = "Science" Or GwRk = "Human" Then
                SFC("Group", "Class")
                STC(GwRk, Val(Clx))

                GSql.Sql_ORD_like_false("*", "SubjectPosition", "", Me.AuksoftDataSet1)
                'MsgBox(Sql)
                'MsgBox(Me.AuksoftDataSet1.SubjectPosition.Rows.Count)
                If Me.AuksoftDataSet1.SubjectPosition.Rows.Count > 0 Then
                    For I = 0 To Me.AuksoftDataSet1.SubjectPosition.Rows.Count - 1
                        AukF.UniqueAdd(Me.SubList, Me.AuksoftDataSet1.SubjectPosition(I).Subject.ToString)
                    Next
                Else
                    MsgBox("No Subject's Found Error ..Contact With Auk(Because Class [" & Clx & "-" & Secx & "] Subject is not Selected ... Please Select Subject From ClassOptions...)", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Error ClassSection Subject is not found... Please Select this from ClassOptions", MsgBoxStyle.Critical)
                Me.Close()
            End If
        Else
            'Me.SubList.DataSource = Me.AuksoftDataSet1.Acc2Subject
            'Me.SubList.DisplayMember = ""
            SFC("Class", "Sections")
            STC(Clx, GwRk)
            GSql.Sql_ORD_like_false("*", "Acc2Subject", "", Me.AuksoftDataSet1)

        End If

    End Sub
    Public Sub Opener2()
        'Subx = Me.SubjectList.Text
        'SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))
        Working = True


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "Shift(" & Shv & ")"

        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        DefMain2 = Subx & "_" & Clx & "_" & "ClassTest"


        SFC("subid", "Subject")
        STC(SubID, Subx)
        GSql.Sql_ORD_like_false("*", "SubjectSingleNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
 
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "objective", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "subjective", "", Me.AuksoftDataSet1)

        Me.ToolStripComboBox1.Items.Clear()
        If Nine = False Then
            SFC("subid", "Subjects")
            STC(SubIDF, Subx)
            GSql.Sql_ORD_like_false("*", "ShowSubjects", "val(Collegeno)", Me.AuksoftDataSet1)

        Else
            'For I = 0 To Me.AuksoftDataSet1.InformationID.Rows.Count - 1
            '    col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
            '    Me.ToolStripComboBox1.Items.Add(col)
            'Next
        End If
        Working = False

    End Sub
    Public Sub Opener3()
        'Subx = Me.SubjectList.Text
        'SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))
        Working = True


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "Shift(" & Shv & ")"

        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        DefMain2 = Subx & "_" & Clx & "_" & "ClassTest"
      
        


        SFC("MainID")
        STC(DefMain2)
        TbSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", DefCn)
        SFC("subid", "Subject")
        STC(SubID, Subx)
        GSql.Sql_ORD_like_false("*", "SubjectSingleNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("Class", "Section", "Shift", "year", "Subjects")
        STC(Clx, Secx, Shv, Yr, Subx)
        GSql.Sql_ORD_like_false("*", "ClassTest", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("class")
        STC(Clx)
        GSql.Sql_ORD_like_false("*", "marksobtaint", "", Me.AuksoftDataSet1)
        SFC("MainID")
        STC(DefMain)
        GSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "objective", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "subjective", "", Me.AuksoftDataSet1)
    

      

        'TbSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", DefCn)
    

        Working = False

    End Sub
    Public Sub Opener()
        'Subx = Me.SubjectList.Text
        'SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))
        Working = True


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "Shift(" & Shv & ")"

        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        DefMain2 = Subx & "_" & Clx & "_" & "ClassTest"
        If Val(Clx) = 9 Or Val(Clx) = 10 Then
            Nine = True
        Else
            Nine = False

        End If
        If TR = "FIRST TERM" Then
            Tms = 1
            Me.DataGridViewTextBoxColumn25.Visible = False
            Me.DataGridViewTextBoxColumn26.Visible = False
            Me.DataGridViewTextBoxColumn27.Visible = False
            Me.DataGridViewTextBoxColumn28.Visible = False
            Me.DataGridViewTextBoxColumn29.Visible = False
            Me.DataGridViewTextBoxColumn30.Visible = False
            Me.DataGridViewTextBoxColumn31.Visible = False
            Me.DataGridViewTextBoxColumn32.Visible = False
            Me.DataGridViewTextBoxColumn33.Visible = False
            Me.DataGridViewTextBoxColumn34.Visible = False
            Me.DataGridViewTextBoxColumn35.Visible = False
            Me.DataGridViewTextBoxColumn36.Visible = False
        ElseIf TR = "SECOND TERM" Then
            Tms = 2
            Me.DataGridViewTextBoxColumn19.Visible = False
            Me.DataGridViewTextBoxColumn20.Visible = False
            Me.DataGridViewTextBoxColumn21.Visible = False
            Me.DataGridViewTextBoxColumn22.Visible = False
            Me.DataGridViewTextBoxColumn23.Visible = False
            Me.DataGridViewTextBoxColumn24.Visible = False
            Me.DataGridViewTextBoxColumn31.Visible = False
            Me.DataGridViewTextBoxColumn32.Visible = False
            Me.DataGridViewTextBoxColumn33.Visible = False
            Me.DataGridViewTextBoxColumn34.Visible = False
            Me.DataGridViewTextBoxColumn35.Visible = False
            Me.DataGridViewTextBoxColumn36.Visible = False
        Else
            Tms = 3
            Me.DataGridViewTextBoxColumn19.Visible = False
            Me.DataGridViewTextBoxColumn20.Visible = False
            Me.DataGridViewTextBoxColumn21.Visible = False
            Me.DataGridViewTextBoxColumn22.Visible = False
            Me.DataGridViewTextBoxColumn23.Visible = False
            Me.DataGridViewTextBoxColumn24.Visible = False
            Me.DataGridViewTextBoxColumn25.Visible = False
            Me.DataGridViewTextBoxColumn26.Visible = False
            Me.DataGridViewTextBoxColumn27.Visible = False
            Me.DataGridViewTextBoxColumn28.Visible = False
            Me.DataGridViewTextBoxColumn29.Visible = False
            Me.DataGridViewTextBoxColumn30.Visible = False
            T3rd = True

        End If


        SFC("MainID")
        STC(DefMain2)
        TbSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", DefCn)
        SFC("subid", "Subject")
        STC(SubID, Subx)
        GSql.Sql_ORD_like_false("*", "SubjectSingleNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
        If Nine = False Then
            SFC("subid", "Subjects")
            STC(SubIDF, Subx)
            GSql.Sql_ORD_like_false("*", "ShowSubjects", "val(Collegeno)", Me.AuksoftDataSet1)
            'MsgBox(GwRk)
 
        Else
            SFC("class", "sections")
            STC(Clx, GwRk)
            GSql.Sql_ORD_like_false("*", "acc2subject", "", Me.AuksoftDataSet1)
            'MsgBox(Sql)

            SFC("StudentClass", "Class_Section", "Shift")
            STC(Clx, Secx, Shv)
            GSql.Sql_ORD_like_false("*", "informationid", "val(Collegeno)", Me.AuksoftDataSet1)
            If Me.AuksoftDataSet1.Acc2Subject.Rows.Count > 0 Then
                For I = 2 To Me.AuksoftDataSet1.Acc2Subject.Columns.Count - 4
                    AukF.UniqueAdd(Me.SubList, Me.AuksoftDataSet1.Acc2Subject(0).Item(I).ToString)
                Next
            Else
                MsgBox("No Subject's Found Error ..Contact With Auk(Because Class [" & Clx & "-" & Secx & "] Subject is not Selected ... Please Select Subject From ClassOptions...)", MsgBoxStyle.Critical)
            End If

        End If
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("Class", "Section", "Shift", "year", "Subjects")
        STC(Clx, Secx, Shv, Yr, Subx)
        GSql.Sql_ORD_like_false("*", "ClassTest", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("class")
        STC(Clx)
        GSql.Sql_ORD_like_false("*", "marksobtaint", "", Me.AuksoftDataSet1)
        SFC("MainID")
        STC(DefMain)
        GSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "objective", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "subjective", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "viewers", "", Me.AuksoftDataSet1)

        SFC("SubID")
        STC(Clx)
        GSql.Sql_ORD_like_false("*", "passmarks", "", Me.AuksoftDataSet1)
        If AukF.AddRows(2, Me.PassMarksBindingSource) = True Then
            MNID = Clx & "Subjective"
            SNID = Clx & "Objective"
            Me.AuksoftDataSet1.PassMarks(0).SubID = Clx
            Me.AuksoftDataSet1.PassMarks(0).MainID = MNID
            Me.AuksoftDataSet1.PassMarks(0)._Class = Clx
            Me.AuksoftDataSet1.PassMarks(0).Section = "None"
            Me.AuksoftDataSet1.PassMarks(0).ExamID = "Subjective"
            Me.AuksoftDataSet1.PassMarks(1).SubID = Clx
            Me.AuksoftDataSet1.PassMarks(1).MainID = SNID
            Me.AuksoftDataSet1.PassMarks(1)._Class = Clx
            Me.AuksoftDataSet1.PassMarks(1).Section = "None"
            Me.AuksoftDataSet1.PassMarks(1).ExamID = "Objective"
            Try
                Me.PassMarksBindingSource.EndEdit()
                Me.PassMarksTableAdapter.Update(Me.AuksoftDataSet1)
            Catch ex As Exception
                Epx()
            End Try
        End If
        SFC("MainID")
        STC(DefMain2)

        TbSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", DefCn)
        If Nine = False Then
            If GwRk = "Commerce" Or GwRk = "Science" Or GwRk = "Human" Then
                SFC("subid")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", GwRk, "", Me.AuksoftDataSet1)
                WrkBind.DataSource = Me.AuksoftDataSet1
                WrkBind.DataMember = GwRk
            Else
                MsgBox("Error In Section Subject Contact With Developer...!Serious Error To Edit Numbers", MsgBoxStyle.Critical)
                Me.Close()
            End If
        End If

        Me.ToolStripComboBox1.Items.Clear()
        If Nine = False Then
            For I = 0 To Me.AuksoftDataSet1.ShowSubjects.Rows.Count - 1
                col = Me.AuksoftDataSet1.ShowSubjects(I).Collegeno.ToString
                Me.ToolStripComboBox1.Items.Add(col)
            Next
        Else
            For I = 0 To Me.AuksoftDataSet1.InformationID.Rows.Count - 1
                col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
                Me.ToolStripComboBox1.Items.Add(col)
            Next
        End If

        If Me.MarksObtaintBindingSource.Count = 0 Then
            Me.MarksObtaintBindingSource.AddNew()
            Me.MarksObtaintBindingSource.EndEdit()
            I = Me.MarksObtaintBindingSource.Position
            Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(1) = Clx
            Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(2) = Shv
            Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(3) = TR
        ElseIf Me.MarksObtaintBindingSource.Count > 1 Then
            If AukF.DelRecAll("Marks_comments ", Me.MarksObtaintBindingSource) = True Then
                Me.MarksObtaintBindingSource.EndEdit()
                Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
                Me.MarksObtaintBindingSource.AddNew()
                Me.MarksObtaintBindingSource.EndEdit()
                I = Me.MarksObtaintBindingSource.Position
                Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(1) = Clx
                Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(2) = Shv
                Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(3) = TR
            Else
                I = Me.MarksObtaintBindingSource.Position
                Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(1) = Clx
                Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(2) = Shv
                Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(3) = TR
            End If
        End If
        If Me.DefaultConvertNumbersBindingSource.Count = 0 Then
            Me.DefaultConvertNumbersBindingSource.AddNew()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            I = Me.DefaultConvertNumbersBindingSource.Position
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(1) = DefMain

            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(2) = "Term"
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(3) = Clx
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(4) = Subx

        ElseIf Me.DefaultConvertNumbersBindingSource.Count > 1 Then
            If AukF.DelRecAll("Marks_comments_MarksConvert ", Me.DefaultConvertNumbersBindingSource) = True Then
                Me.DefaultConvertNumbersBindingSource.EndEdit()
                Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)

                Me.DefaultConvertNumbersBindingSource.AddNew()
                Me.DefaultConvertNumbersBindingSource.EndEdit()
                I = Me.DefaultConvertNumbersBindingSource.Position
                Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(1) = DefMain
                Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(2) = "Term"
                Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(3) = Clx
                Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(4) = Subx
            End If
        Else
            I = Me.DefaultConvertNumbersBindingSource.Position
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(1) = DefMain
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(2) = "Term"
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(3) = Clx
            Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(4) = Subx

        End If

        If Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(8).ToString) = 0 Then
            If Clx = 11 Or Clx = 12 Then
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).SubjectiveTotalNumber = 75
            Else
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).SubjectiveTotalNumber = 50
            End If
        End If
        If Me.AuksoftDataSet1.Viewers.Count = 0 Then
            'Me.AuksoftDataSet1.Viewers.Rows.Add()
            'Me.AuksoftDataSet1.Viewers.NewRow.EndEdit()
            Me.ViewersBindingSource.AddNew()
            Me.ViewersBindingSource.EndEdit()
            Me.AuksoftDataSet1.Viewers(0).SubID = SubID
            Me.AuksoftDataSet1.Viewers(0).Year = Yr
            Me.AuksoftDataSet1.Viewers(0).Term = TR
            Me.AuksoftDataSet1.Viewers(0)._Class = Clx
            Me.AuksoftDataSet1.Viewers(0).Section = Secx
            Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
            Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & UCase(TR) & " EXAM"
            Me.AuksoftDataSet1.Viewers(0).Subject = Shv

            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
        Else
            Me.AuksoftDataSet1.Viewers(0).SubID = SubID
            Me.AuksoftDataSet1.Viewers(0).Year = Yr
            Me.AuksoftDataSet1.Viewers(0).Term = TR
            Me.AuksoftDataSet1.Viewers(0)._Class = Clx
            Me.AuksoftDataSet1.Viewers(0).Section = Secx
            Me.AuksoftDataSet1.Viewers(0).Subject = Shv
            'Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
            'Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & UCase(TR) & " EXAM"
            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
        End If

        If Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(7).ToString) = 0 Then
            If Clx = 11 Or Clx = 12 Then
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).ObjectiveTotalNumber = 25
            Else
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).ObjectiveTotalNumber = 40
            End If
        End If
        If Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(6).ToString) = 0 Then
            If Nine = True Then
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).TotalNumber = 90
            Else
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).TotalNumber = 100
            End If


        End If
        If Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(5).ToString) = 0 Then
            If Nine = True Then
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).ConvertNumber = 90
            Else
                Me.AuksoftDataSet1.DefaultConvertNumbers(0).ConvertNumber = 100
            End If
        End If
        If Val(Me.AuksoftDataSet1.MarksObtaint(0).Item("TotalMarks").ToString) = 0 Then
            cry = Me.AuksoftDataSet1.DefaultConvertNumbers(0).ConvertNumber
            If DefCn.Rows.Count > 0 Then
                ccry = DefCn.Rows(0).Item("ConvertNumber")
            Else
                If Nine = False Then
                    ccry = 25
                Else
                    ccry = 10
                End If
            End If
            DefCn.Rows(0).Item("ConvertNumber") = ccry
            Me.AuksoftDataSet1.MarksObtaint(0).TotalMarks = Val(cry) + Val(ccry)

        End If


        Try
            DefCn.NewRow.EndEdit()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            'Me.DefaultConvertNumbersTableAdapter.Update(DefCn.)

        Catch ex As Exception
            Epx()
        End Try
        AukF2.FindInObjectAndSelect(Me.SubList, Subx, True, False)

        Working = False

    End Sub
    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
    Public Sub InputCol(ByVal Col As String, ByVal GotoPos As Boolean)
        Working = True
        Dim Aq As Integer
        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Col
        UMainID = Clx & Secx & TR & Shv & Yr & Col
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"

        If Nine = False Then
            Aq = Me.ShowSubjectsBindingSource.Find("Collegeno", Col)

            If Aq > -1 Then
                SubjectPosition = Me.AuksoftDataSet1.ShowSubjects(Aq).Item(5).ToString
                'MsgBox(Aq, , SubjectPosition)
            Else
                SubjectPosition = -1
            End If
        Else
            Aq = Me.SubList.FindStringExact(Subx)
            If Aq > -1 Then
                SubjectPosition = Aq + 4
            Else
                SubjectPosition = -1
            End If

        End If
        'MsgBox(Nine)


        Aq = Me.SubjectSingleNumbersBindingSource.Find("Collegeno", Col)
        If Aq = -1 Then
            Me.SubjectSingleNumbersBindingSource.AddNew()
            Me.SubjectSingleNumbersBindingSource.EndEdit()
            Aq = Me.SubjectSingleNumbersBindingSource.Position
            Me.AuksoftDataSet1.SubjectSingleNumbers(Aq).MainID = MainID
            Me.AuksoftDataSet1.SubjectSingleNumbers(Aq).SubID = SubID
            Me.AuksoftDataSet1.SubjectSingleNumbers(Aq).Collegeno = Col
            Me.AuksoftDataSet1.SubjectSingleNumbers(Aq).Subject = Subx
        Else
            If GotoPos = True Then Me.SubjectSingleNumbersBindingSource.Position = Aq
        End If
        SingPos = Aq
        Aq = Me.SubjectiveBindingSource.Find("Collegeno", Col)
        If Aq = -1 Then
            Me.SubjectiveBindingSource.AddNew()
            Me.SubjectiveBindingSource.EndEdit()
            Aq = Me.SubjectiveBindingSource.Position
            Me.AuksoftDataSet1.Subjective(Aq).MainID = UMainID
            Me.AuksoftDataSet1.Subjective(Aq).SubID = SubID
            Me.AuksoftDataSet1.Subjective(Aq).Collegeno = Col
            'Me.AuksoftDataSet1.Subjective(Aq).Subject = Subx
        Else
            'If GotoPos = True Then Me.SubjectiveBindingSource.Position = Aq
        End If
        SubjPos = Aq
        Aq = Me.ObjectiveBindingSource.Find("Collegeno", Col)
        If Aq = -1 Then
            Me.ObjectiveBindingSource.AddNew()
            Me.ObjectiveBindingSource.EndEdit()
            Aq = Me.ObjectiveBindingSource.Position

            Me.AuksoftDataSet1.Objective(Aq).MainID = UMainID
            Me.AuksoftDataSet1.Objective(Aq).SubID = SubID
            Me.AuksoftDataSet1.Objective(Aq).Collegeno = Col
            'Me.AuksoftDataSet1.Subjective(Aq).Subject = Subx
        Else

            'If GotoPos = True Then Me.ObjectiveBindingSource.Position = Aq
        End If

        ObjPos = Aq
        Aq = Me.Acc2ConvertBindingSource.Find("Collegeno", Col)
        If Aq = -1 Then
            Me.Acc2ConvertBindingSource.AddNew()
            Me.Acc2ConvertBindingSource.EndEdit()
            Aq = Me.Acc2ConvertBindingSource.Position
            Me.AuksoftDataSet1.Acc2Convert(Aq).MainID = UMainID
            Me.AuksoftDataSet1.Acc2Convert(Aq).SubID = SubID
            Me.AuksoftDataSet1.Acc2Convert(Aq).Collegeno = Col
            Me.AuksoftDataSet1.Acc2Convert(Aq).ConvertQuality = ""

            'Me.AuksoftDataSet1.Subjective(Aq).Subject = Subx
        Else
            'If GotoPos = True Then Me.ObjectiveBindingSource.Position = Aq
        End If
        APos = Aq
        Aq = Me.ClassTestBindingSource.Find("Collegeno", Col)
        ClPos = Aq
        If Nine = False Then
            Aq = Me.WrkBind.Find("Collegeno", Col)
            If Aq = -1 Then
                Me.WrkBind.AddNew()
                Me.WrkBind.EndEdit()
                Aq = Me.WrkBind.Position
                Me.AuksoftDataSet1.Tables(GwRk).Rows(Aq).Item(1) = UMainID
                Me.AuksoftDataSet1.Tables(GwRk).Rows(Aq).Item(2) = SubID
                Me.AuksoftDataSet1.Tables(GwRk).Rows(Aq).Item(3) = Col
                'Me.AuksoftDataSet1.Tables(GwRk).Rows(Aq) = ""

                'Me.AuksoftDataSet1.Subjective(Aq).Subject = Subx
            Else
                'If GotoPos = True Then Me.ObjectiveBindingSource.Position = Aq
                GrkPos = Aq
            End If
            GrkPos = Aq
        Else
            GrkPos = -1

        End If


        Working = False

    End Sub


    Private Sub InputAllThisSubjectStudentsInDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Alo As Integer
        Dim Chk As Boolean = Me.CheckBox3.Checked
        Me.CheckBox3.Checked = False
        If AukF2.MsgTr(What & "Inster all Subject Students...?") = False Then
            Exit Sub

        End If


        Working = True
        Me.Cursor = Cursors.WaitCursor
        Me.SubjectSingleNumbersDataGridView.DataSource = ""

        Me.ToolStripProgressBar1.Visible = True
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        Me.ProgressBar1.Maximum = Me.SubList.Items.Count
        For Alo = 0 To Me.SubList.Items.Count - 1
            Subx = Me.SubList.Items.Item(Alo).ToString
            Opener2()
            Me.ToolStripProgressBar1.Value = 0
            If Nine = False Then
                c = 100 / Me.AuksoftDataSet1.ShowSubjects.Rows.Count
                For I = 0 To Me.AuksoftDataSet1.ShowSubjects.Rows.Count - 1
                    Col = Me.AuksoftDataSet1.ShowSubjects(I).Collegeno.ToString
                    InputCol(col, False)
                    AukF.InsPro(Me.ToolStripProgressBar1, c)
                Next
            Else
                c = 100 / Me.AuksoftDataSet1.InformationID.Rows.Count
                For I = 0 To Me.AuksoftDataSet1.InformationID.Rows.Count - 1
                    Col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
                    InputCol(col, False)
                    AukF.InsPro(Me.ToolStripProgressBar1, c)
                Next
            End If
            SaveTerm()

            Me.ToolStripProgressBar1.Value = 0
            'Me.ToolStripProgressBar1.Visible = False
            AukF2.InsPro(Me.ProgressBar1, 1)

        Next
        Me.SubList.SelectedIndex = 0

        Subx = Me.SubList.Items.Item(0).ToString
        Opener()
        Me.ProgressBar1.Visible = False
        Me.CheckBox3.Checked = Chk

        'If AukF.MsgTr(What & "Save ?,Without Save Changes Couldn't be accpted... ") = True Then
        '    ToolStripMenuItem1_Click(sender, e)
        '    ToolStripMenuItem3_Click(sender, e)
        '    Terminal_Load(sender, e)

        '    Opener()


        'End If
        Me.Cursor = Cursors.Default

        Working = False

    End Sub

    Private Sub SubjectSingleNumbersDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubjectSingleNumbersDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Dim MpID As String
        Dim d As Integer
        Working = True

        Try
            If Nine = False Then
                c = 100 / Me.ShowSubjectsBindingSource.Count.ToString
                Me.CtProg.Value = 0
                Me.CtProg.Visible = True
                For I = 0 To (Me.ShowSubjectsBindingSource.Count - 1)
                    colpx = Me.AuksoftDataSet1.ShowSubjects(I).Collegeno.ToString
                    d = Me.ClassTestBindingSource.Find("Collegeno", colpx)

                    MpID = Subx & colpx & Clx & Secx & Yr & Shv

                    If d = -1 Then
                        If Me.ClassTestBindingSource.Filter = "" Then
                            Me.ClassTestBindingSource.AddNew()
                            Me.ClassTestBindingSource.EndEdit()
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Subjects = Subx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position)._Class = Clx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Section = Secx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Year = Yr
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).CollegeNo = colpx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Cause = "None"
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Cause2 = "None"
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Cause3 = "None"
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Shift = Shv
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).MainID = MpID

                        End If

                    End If
                    AukF.InsPro(Me.CtProg, c)

                Next
            Else
                c = 100 / Me.AuksoftDataSet1.InformationID.Rows.Count.ToString
                Me.CtProg.Value = 0
                Me.CtProg.Visible = True
                For I = 0 To (Me.AuksoftDataSet1.InformationID.Rows.Count - 1)
                    colpx = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
                    d = Me.ClassTestBindingSource.Find("Collegeno", colpx)
                    MpID = Subx & colpx & Clx & Secx & Yr & Shv

                    If d = -1 Then
                        If Me.ClassTestBindingSource.Filter = "" Then
                            Me.ClassTestBindingSource.AddNew()
                            Me.ClassTestBindingSource.EndEdit()
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Subjects = Subx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position)._Class = Clx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Section = Secx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Year = Yr
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).CollegeNo = colpx
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Cause = "None"
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Cause2 = "None"
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Cause3 = "None"
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).Shift = Shv
                            Me.AuksoftDataSet1.ClassTest(Me.ClassTestBindingSource.Position).MainID = MpID
                            'Me.CollegenoTextBox.Text = Me.CollgenoComboBox.Text
                            'Me.ShiftTextBox.Text = Me.ComboBox5.Text
                        End If
                    End If
                    AukF.InsPro(Me.CtProg, c)


                Next
            End If

            Me.CtProg.Visible = False
            Me.CtProg.Value = 0
        Catch ex As Exception
            Epx()
            Me.CtProg.Value = 0
            Working = False
        Finally
            'MsgBox("ok")
            If AukF.MsgTr(What & "Save ?,Without Save Changes Couldn't be accpted... ") = True Then
                ToolStripMenuItem3_Click(sender, e)
                Terminal_Load(sender, e)


                Me.Opener()

            End If
            Me.CtProg.Value = 0
            Working = False
        End Try
        Working = False

    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click
        Try
            Me.ClassTestBindingSource.RemoveCurrent()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripStatusLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel5.Click
        AukF.DelRecAll("ClassTest", Me.ClassTestBindingSource)

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click
        Try
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
        Catch ex As Exception
            Epx()
            'Finally
        End Try
    End Sub

    Private Sub ToolStripStatusLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel4.Click
        Try
            If AukF.MsgTr(What & "RejectChanges") = False Then
                Exit Sub
            End If
            Me.ClassTestBindingSource.CancelEdit()
            Me.AuksoftDataSet1.ClassTest.RejectChanges()

        Catch ex As Exception
            Epx()

        Finally

        End Try

    End Sub

    Private Sub CountRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountRecordToolStripMenuItem.Click
        MsgBox(Me.ClassTestBindingSource.Count)
    End Sub

    Private Sub HowManyFromTermToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowManyFromTermToolStripMenuItem.Click
        On Error Resume Next
        If T3rd = True Then
            MsgBox(Me.AuksoftDataSet1.ClassTest.Compute("Count([Cause])", "cause3='%FromTerm'"))
        Else
            If Tms = 1 Then
                MsgBox(Me.AuksoftDataSet1.ClassTest.Compute("Count([Cause])", "cause='%FromTerm'"))
            Else
                MsgBox(Me.AuksoftDataSet1.ClassTest.Compute("Count([Cause])", "cause2='%FromTerm'"))
            End If
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            If Me.CheckBox1.Checked = True Then
                Me.ClassTestDataGridView.DataSource = ""
                'Me.SubjectSingleNumbersDataGridView.DataSource = ""
            End If
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Convert_and_Total.Show()

    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click

    End Sub
    Public Sub Ery(ByVal Pos As Integer)
        Dim SelfNum, Num, ObjNum, SubjNum, ClMrk, TNum As Double
        Dim Total, Cause, CCause, WTotal, ObjShow As String
        WTotal = Val(Me.AuksoftDataSet1.MarksObtaint(0).Item("totalmarks").ToString)
        If Val(WTotal) = 0 Then
            WTotal = 100
        End If
        Dim Aq As Integer
        Dim TMrk, CMrk As Double
        Dim ClTotalMrk As String
        If DefCn.Rows.Count > 0 Then ClTotalMrk = DefCn.Rows(0).Item(5).ToString
        If Val(ClTotalMrk) = 0 Then
            ClTotalMrk = 25
        End If
        Dim ObjT, SubjT As String
        ObjT = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(7).ToString)
        SubjT = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(8).ToString)
        Dim ConvertT As String = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(5).ToString)
        Dim TotalTerm As String = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(6).ToString)

        Me.ConvertedNumConvertObjective = AukF.ConvertOnlyForTerminalForm(ConvertT, TotalTerm, ObjT)
        Me.ConvertedNumConvertSubjective = AukF.ConvertOnlyForTerminalForm(ConvertT, TotalTerm, SubjT)
        If (Val(Me.ConvertedNumConvertObjective) + Val(Me.ConvertedNumConvertSubjective) = ConvertT) Or (Val(Me.ConvertedNumConvertObjective) + Val(Me.ConvertedNumConvertSubjective) = TotalTerm) Then
        Else
            MsgBox("Error of ConvertNumber Contact with developer or Setup Marks From Other's and (Convert Number  Editor Button)", MsgBoxStyle.Critical)
        End If
        'MsgBox(Me.ConvertedNumConvertObjective)
        'Exit Sub


        'TMrk = Val(Me.TotalNumberTextBox.Text)
        'CMrk = Val(Me.ConvertNumberTextBox.Text)

        col = Me.AuksoftDataSet1.SubjectSingleNumbers(Pos).Collegeno.ToString
        'MsgBox(Col)

        InputCol(col, False)
        If SingPos > -1 Then
            ObjNum = Val(Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).Item(5).ToString)
            SubjNum = Val(Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).Item(6).ToString)
        Else
            ObjNum = 0
            SubjNum = 0
        End If



        If ClPos > -1 Then
            If Tms = 1 Then
                ClMrk = Val(Me.AuksoftDataSet1.ClassTest(ClPos).Item(11).ToString)
                Cause = Me.AuksoftDataSet1.ClassTest(ClPos).Item(12).ToString
            ElseIf Tms = 2 Then
                ClMrk = Val(Me.AuksoftDataSet1.ClassTest(ClPos).Item(17).ToString)
                Cause = Me.AuksoftDataSet1.ClassTest(ClPos).Item(18).ToString
            Else
                ClMrk = Val(Me.AuksoftDataSet1.ClassTest(ClPos).Item(23).ToString)
                Cause = Me.AuksoftDataSet1.ClassTest(ClPos).Item(24).ToString
            End If
        Else
            ClMrk = 0
            Cause = "None"

        End If
        'MsgBox(ClMrk)

        SelfNum = ObjNum + SubjNum
        Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).SelfMarksTotal = SelfNum
        ObjNum = Format(AukF.DrmcNumberCon(ObjNum, ObjT, Me.ConvertedNumConvertObjective), "0.###")

        SubjNum = Format(AukF.DrmcNumberCon(SubjNum, SubjT, Me.ConvertedNumConvertSubjective), "0.###")
        SelfNum = ObjNum + SubjNum

        If Cause = "%FromTerm" Then
            ClMrk = AukF.DrmcNumberCon(SelfNum, ConvertT, ClTotalMrk)
            'MsgBox(ClMrk & "&S=" & SelfNum & "&C=" & ConvertT & "&W=" & ClTotalMrk, , "Cls")
        End If
        If Nine = True Then
            Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).ClassTestAvarageMarks = Format(Val(ClMrk) + Val(ObjNum), "0.###")
        Else
            Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).ClassTestAvarageMarks = Format(((Val(ClMrk) * 2) + ObjNum) / 3, "0.##")
        End If
        ObjShow = Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).Item("ClassTestAvarageMarks").ToString
        TNum = Format(Val(SubjNum) + Val(ObjShow), "0.###")
        Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).ConvertedMarks = TNum
        Num = AukF.RemovePoints(TNum)

        Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).TotalMarks = Num
        Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).CauseOfClasstest = Cause
        CCause = Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).Item(10).ToString


        'MsgBox(SubjectPosition, , "Sub")
        If SubjectPosition > -1 Then
            Aq = SubjectPosition + 1
            If CCause.ToLower.Trim = "causeaccepted" Then
                Me.AuksoftDataSet1.Acc2Convert(APos).Item(Aq) = "CA"
                Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).TotalMarks = 0
            ElseIf CCause.ToLower.Trim = "absent" Then
                'MsgBox(CCause, , "CCause")
                Me.AuksoftDataSet1.Acc2Convert(APos).Item(Aq) = "A"
                Me.AuksoftDataSet1.SubjectSingleNumbers(SingPos).TotalMarks = 0
            Else
                Me.AuksoftDataSet1.Acc2Convert(APos).Item(Aq) = Num
            End If
            Aq = SubjectPosition
            'MsgBox(Aq)
            Me.AuksoftDataSet1.Subjective(SubjPos).Item(Aq) = SubjNum
            Me.AuksoftDataSet1.Objective(ObjPos).Item(Aq) = AukF.RemovePoints(ObjShow)
            If GrkPos > -1 Then Me.AuksoftDataSet1.Tables(GwRk).Rows(GrkPos).Item(Aq) = Num
        End If
    End Sub
    Public Sub Ery(ByVal SubjNumber As Double, ByVal ObjNumber As Double)
        Dim SelfNum, Num, ObjNum, SubjNum, ClMrk, TNum As Double
        Dim Total, Cause, CCause, WTotal, ObjShow As String
        WTotal = Val(Me.AuksoftDataSet1.MarksObtaint(0).Item("totalmarks").ToString)
        If Val(WTotal) = 0 Then
            WTotal = 100
        End If
        Dim Aq As Integer
        Dim TMrk, CMrk As Double
        Dim ClTotalMrk As String
        If DefCn.Rows.Count > 0 Then ClTotalMrk = DefCn.Rows(0).Item(5).ToString
        If Val(ClTotalMrk) = 0 Then
            ClTotalMrk = 25
        End If
        Dim ObjT, SubjT As String
        ObjT = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(7).ToString)
        SubjT = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(8).ToString)
        Dim ConvertT As String = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(5).ToString)
        Dim TotalTerm As String = Val(Me.AuksoftDataSet1.DefaultConvertNumbers(0).Item(6).ToString)

        Me.ConvertedNumConvertObjective = AukF.ConvertOnlyForTerminalForm(ConvertT, TotalTerm, ObjT)
        Me.ConvertedNumConvertSubjective = AukF.ConvertOnlyForTerminalForm(ConvertT, TotalTerm, SubjT)
        If (Val(Me.ConvertedNumConvertObjective) + Val(Me.ConvertedNumConvertSubjective) = ConvertT) Or (Val(Me.ConvertedNumConvertObjective) + Val(Me.ConvertedNumConvertSubjective) = TotalTerm) Then
        Else
            MsgBox("Error of ConvertNumber Contact with developer or Setup Marks From Other's and (Convert Number  Editor Button)", MsgBoxStyle.Critical)
        End If
        'MsgBox(Me.ConvertedNumConvertObjective)
        'Exit Sub


        'TMrk = Val(Me.TotalNumberTextBox.Text)
        'CMrk = Val(Me.ConvertNumberTextBox.Text)

        col = Me.AuksoftDataSet1.SubjectSingleNumbers(Pos).Collegeno.ToString
        'MsgBox(Col)

        InputCol(col, False)
        If SingPos > -1 Then
            ObjNum = ObjNumber
            SubjNum = SubjNumber
        Else
            ObjNum = 0
            SubjNum = 0
        End If



        If ClPos > -1 Then
            If Tms = 1 Then
                ClMrk = Val(Me.AuksoftDataSet1.ClassTest(ClPos).Item(11).ToString)
                Cause = Me.AuksoftDataSet1.ClassTest(ClPos).Item(12).ToString
            ElseIf Tms = 2 Then
                ClMrk = Val(Me.AuksoftDataSet1.ClassTest(ClPos).Item(17).ToString)
                Cause = Me.AuksoftDataSet1.ClassTest(ClPos).Item(18).ToString
            Else
                ClMrk = Val(Me.AuksoftDataSet1.ClassTest(ClPos).Item(23).ToString)
                Cause = Me.AuksoftDataSet1.ClassTest(ClPos).Item(24).ToString
            End If
        Else
            ClMrk = 0
            Cause = "None"

        End If
        'MsgBox(ClMrk)

        SelfNum = ObjNum + SubjNum
        Me.SelfMarksTotalTextBox.Text = SelfNum
        ObjNum = Format(AukF.DrmcNumberCon(ObjNum, ObjT, Me.ConvertedNumConvertObjective), "0.###")
        MsgBox(ObjNum)

        SubjNum = Format(AukF.DrmcNumberCon(SubjNum, SubjT, Me.ConvertedNumConvertSubjective), "0.###")
        SelfNum = ObjNum + SubjNum

        If Cause = "%FromTerm" Then
            ClMrk = AukF.DrmcNumberCon(SelfNum, ConvertT, ClTotalMrk)
            'MsgBox(ClMrk & "&S=" & SelfNum & "&C=" & ConvertT & "&W=" & ClTotalMrk, , "Cls")
        End If
        If Nine = True Then
            Me.ClassTestAvarageMarksTextBox.Text = Format(Val(ClMrk) + Val(ObjNum), "0.###")
        Else
            Me.ClassTestAvarageMarksTextBox.Text = Format(((Val(ClMrk) * 2) + ObjNum) / 3, "0.##")
        End If
        ObjShow = Me.ClassTestAvarageMarksTextBox.Text
        TNum = Format(Val(SubjNum) + Val(ObjShow), "0.###")
        Me.ConvertedMarksTextBox.Text = TNum
        Num = AukF.RemovePoints(TNum)

        Me.TotalMarksTextBox1.Text = Num
        Me.CauseOfClasstestLabel1.Text = Cause
        CCause = Me.CauseOfTermExamComboBox.Text


        'MsgBox(SubjectPosition, , "Sub")
        If SubjectPosition > -1 Then
            Aq = SubjectPosition + 1
            If CCause.ToLower.Trim = "causeaccepted" Then
                Me.AuksoftDataSet1.Acc2Convert(APos).Item(Aq) = "CA"
                Me.TotalMarksTextBox1.Text = 0
            ElseIf CCause.ToLower.Trim = "absent" Then
                'MsgBox(CCause, , "CCause")
                Me.AuksoftDataSet1.Acc2Convert(APos).Item(Aq) = "A"
                Me.TotalMarksTextBox1.Text = 0
            Else
                Me.AuksoftDataSet1.Acc2Convert(APos).Item(Aq) = Num
            End If
            Aq = SubjectPosition
            'MsgBox(Aq)
            Me.AuksoftDataSet1.Subjective(SubjPos).Item(Aq) = SubjNum
            Me.AuksoftDataSet1.Objective(ObjPos).Item(Aq) = AukF.RemovePoints(ObjShow)
            If GrkPos > -1 Then Me.AuksoftDataSet1.Tables(GwRk).Rows(GrkPos).Item(Aq) = Num
        End If
    End Sub
    Public Function CTst(ByVal Pos As Integer)
        Dim SelfNum, Num, Num2, CNum1, CNum2 As Double
        Dim Total, Cause, CCause As String
        Dim ConvertNum As String
        Dim TNum As String
        If DefCn.Rows.Count > 0 Then
            ConvertNum = DefCn.Rows(0).Item(5).ToString()
            TNum = DefCn.Rows(0).Item(6).ToString()
        End If

        Dim Aq As Integer
        Dim TMrk, CMrk As Double
        TMrk = Val(Me.TotalNumberTextBox.Text)
        CMrk = Val(Me.ConvertNumberTextBox.Text)
        'col = Me.AuksoftDataSet1.ClassTest(Pos).CollegeNo.ToString
        'InputCol(col, False)
        If Tms = 1 Then
            Num = Val(Me.AuksoftDataSet1.ClassTest(Pos).Item(7).ToString)
            Num2 = Val(Me.AuksoftDataSet1.ClassTest(Pos).Item(8).ToString)
            CNum1 = Format(AukF.DrmcNumberCon(Num, TNum, ConvertNum), "0.##")
            CNum2 = Format(AukF.DrmcNumberCon(Num2, TNum, ConvertNum), "0.##")
            Me.AuksoftDataSet1.ClassTest(Pos).Item(9) = CNum1
            Me.AuksoftDataSet1.ClassTest(Pos).Item(10) = CNum2
            Cause = Me.AuksoftDataSet1.ClassTest(Pos).Item(12).ToString
        ElseIf Tms = 2 Then
            Num = Val(Me.AuksoftDataSet1.ClassTest(Pos).Item(13).ToString)
            Num2 = Val(Me.AuksoftDataSet1.ClassTest(Pos).Item(14).ToString)
            CNum1 = Format(AukF.DrmcNumberCon(Num, TNum, ConvertNum), "0.##")
            CNum2 = Format(AukF.DrmcNumberCon(Num2, TNum, ConvertNum), "0.##")
            Me.AuksoftDataSet1.ClassTest(Pos).Item(15) = CNum1
            Me.AuksoftDataSet1.ClassTest(Pos).Item(16) = CNum2
            Cause = Me.AuksoftDataSet1.ClassTest(Pos).Item(17).ToString
        Else
            Num = Val(Me.AuksoftDataSet1.ClassTest(Pos).Item(19).ToString)
            Num2 = Val(Me.AuksoftDataSet1.ClassTest(Pos).Item(20).ToString)
            CNum1 = Format(AukF.DrmcNumberCon(Num, TNum, ConvertNum), "0.##")
            CNum2 = Format(AukF.DrmcNumberCon(Num2, TNum, ConvertNum), "0.##")
            Me.AuksoftDataSet1.ClassTest(Pos).Item(21) = CNum1
            Me.AuksoftDataSet1.ClassTest(Pos).Item(22) = CNum2
            Cause = Me.AuksoftDataSet1.ClassTest(Pos).Item(24).ToString
        End If
        If Cause.ToLower = "causeaccepted" Then
            avg = CNum1 + CNum2
        Else
            avg = (CNum1 + CNum2) / 2
        End If
        avg = Format(avg, "0.##")
        If Tms = 1 Then
            Me.AuksoftDataSet1.ClassTest(Pos).Avarage = avg
        ElseIf Tms = 2 Then
            Me.AuksoftDataSet1.ClassTest(Pos).Avarage2 = avg
        Else
            Me.AuksoftDataSet1.ClassTest(Pos).Avarage3 = avg
        End If
    End Function
    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        Dim Aq As Integer
        Aq = Me.SubjectSingleNumbersBindingSource.Find("Collegeno", ToolStripTextBox2.Text)
        If Aq > -1 Then
            Me.SubjectSingleNumbersBindingSource.Position = Aq

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim nu As Data.DataRow = Me.AuksoftDataSet1.MarksObtaint(0)
        Try
            Me.MarksObtaintBindingSource.EndEdit()
            nu.Item(16) = nu(5).ToString & "%-" & nu(6).ToString & "%"
            nu.Item(17) = nu(7).ToString & "%-" & nu(8).ToString & "%"
            nu.Item(18) = nu(9).ToString & "%-" & nu(10).ToString & "%"
            nu.Item(19) = nu(11).ToString & "%-" & nu(12).ToString & "%"
            nu.Item(20) = nu(13).ToString & "%-" & nu(14).ToString & "%"
            nu.Item(21) = nu(15).ToString & "% or below"
            Me.MarksObtaintBindingSource.EndEdit()
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
        Catch ex As Exception
            Epx()
            'Resume Next
        End Try
    End Sub

    Private Sub ClassTestBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassTestBindingSource.CurrentChanged

        'If Working = False Then
        '    CTst(Me.ClassTestBindingSource.Position)

        'End If
    End Sub

    Private Sub SubjectSingleNumbersBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectSingleNumbersBindingSource.CurrentChanged
        'If Working = False Then
        '    Ery(Me.AuksoftDataSet1.SubjectSingleNumbers(Me.SubjectSingleNumbersBindingSource.Position).Collegeno.ToString)
        'End If
    End Sub

    Private Sub SubjectSingleNumbersBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubjectSingleNumbersBindingSource.CurrentItemChanged
        'If Working = False Then
        '    Ery(Me.SubjectSingleNumbersBindingSource.Position)
        'End If
        'If Working = False Then
        '    Ery(Me.AuksoftDataSet1.SubjectSingleNumbers(Me.SubjectSingleNumbersBindingSource.Position).Collegeno.ToString)
        'End If
    End Sub

    Private Sub SubjectSingleNumbersBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubjectSingleNumbersBindingSource.PositionChanged
        On Error Resume Next
        'If Working = False Then
        '    Lq = Me.SubjectSingleNumbersBindingSource.Position - 1
        '    If Lq > -1 Then Ery(Lq) Else Ery(0)
        'End If
        'If Working = False Then
        '    Ery(Me.AuksoftDataSet1.SubjectSingleNumbers(Me.SubjectSingleNumbersBindingSource.Position - 1).Collegeno.ToString)
        'End If
    End Sub

    Private Sub ClassTestBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassTestBindingSource.CurrentItemChanged
        'If Working = False Then
        '    CTst(Me.ClassTestBindingSource.Position)

        'End If
    End Sub

    Private Sub ClassTestBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassTestBindingSource.PositionChanged
        'On Error Resume Next
        'If Working = False Then
        '    Lq = Me.ClassTestBindingSource.Position - 1

        '    If Lq > -1 Then CTst(Lq) Else CTst(0)

        'End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        InputAllThisSubjectStudentsInDatabaseToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub InputThisSubjectAllStudentsInClassTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputThisSubjectAllStudentsInClassTestToolStripMenuItem.Click
        ToolStripStatusLabel2_Click(sender, e)

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        Try
            If Me.CheckBox1.Checked = True Then
                Me.ClassTestDataGridView.DataSource = ""
                Me.SubjectSingleNumbersDataGridView.DataSource = ""
            End If
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            If Me.AfterSaveGiveMessageToolStripMenuItem.Checked Then
                MsgBox("Saved (ClassTest Marks Only) Successfully...", MsgBoxStyle.Information)

            End If
        Catch ex As Exception
            Epx()
        Finally
            Beep()

        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Try
            Me.ClassTestBindingSource.RemoveCurrent()
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub RejectChangesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem1.Click
        If AukF.MsgTr("Do you want to Resject Changes..?") = True Then
            Me.ClassTestBindingSource.CancelEdit()
            Me.AuksoftDataSet1.ClassTest.RejectChanges()


        End If

    End Sub

    Private Sub RefreshDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDatabaseToolStripMenuItem.Click
        Opener()

    End Sub

    Private Sub GotoFindTextBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoFindTextBoxToolStripMenuItem.Click
        ToolStripTextBox1.Focus()

    End Sub

    Private Sub ResumeToDataEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumeToDataEditToolStripMenuItem.Click
        Me.ClassTestDataGridView.Focus()

    End Sub
    Public Sub SaveTerm()
        Try
            Me.Validate()
            Me.SubjectiveBindingSource.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.SubjectSingleNumbersBindingSource.EndEdit()
            Me.MarksObtaintBindingSource.EndEdit()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            WrkBind.EndEdit()
            Me.SubjectSingleNumbersTableAdapter.Update(Me.AuksoftDataSet1.SubjectSingleNumbers)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            'SvAdp.Update(Me.AuksoftDataSet1.Tables(GwRk))
            If Nine = False Then
                If GwRk = "Commerce" Then
                    Me.CommerceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Science" Then
                    Me.ScienceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Human" Then
                    Me.HumanTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                End If
            End If
        Catch ex As Exception
            Epx()
        Finally
            'Beep()

        End Try
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            Me.Validate()


            If Me.CheckBox1.Checked = True Then
                Me.ClassTestDataGridView.DataSource = ""
                Me.SubjectSingleNumbersDataGridView.DataSource = ""
            End If
            Me.SubjectiveBindingSource.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.SubjectSingleNumbersBindingSource.EndEdit()
            Me.MarksObtaintBindingSource.EndEdit()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            WrkBind.EndEdit()

            Me.SubjectSingleNumbersTableAdapter.Update(Me.AuksoftDataSet1.SubjectSingleNumbers)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            'SvAdp.Update(Me.AuksoftDataSet1.Tables(GwRk))
            If Nine = False Then
                If GwRk = "Commerce" Then
                    Me.CommerceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Science" Then
                    Me.ScienceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Human" Then
                    Me.HumanTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                End If
            End If
            If Me.AfterSaveGiveMessageToolStripMenuItem.Checked Then
                MsgBox("Saved (Terms+Other's+(Without ClassTest)) Successfully...", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Epx()
        Finally
            'Beep()

        End Try
    End Sub
    Public Sub Save2()
        Try
            'Me.Validate()
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            Me.SubjectiveBindingSource.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.SubjectSingleNumbersBindingSource.EndEdit()
            WrkBind.EndEdit()

            Me.SubjectSingleNumbersTableAdapter.Update(Me.AuksoftDataSet1.SubjectSingleNumbers)
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
            'SvAdp.Update(Me.AuksoftDataSet1.Tables(GwRk))
          

        Catch ex As Exception
            Epx()
        Finally

        End Try

    End Sub
    Public Sub Save()
        Try
            Me.Validate()
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            Me.SubjectiveBindingSource.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.SubjectSingleNumbersBindingSource.EndEdit()
            Me.MarksObtaintBindingSource.EndEdit()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            WrkBind.EndEdit()

            Me.SubjectSingleNumbersTableAdapter.Update(Me.AuksoftDataSet1.SubjectSingleNumbers)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            'SvAdp.Update(Me.AuksoftDataSet1.Tables(GwRk))
            If Nine = False Then
                If GwRk = "Commerce" Then
                    Me.CommerceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Science" Then
                    Me.ScienceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Human" Then
                    Me.HumanTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                End If
            End If

        Catch ex As Exception
            Epx()
        Finally

        End Try

    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try


            Me.Validate()
            If Me.CheckBox1.Checked = True Then
                Me.ClassTestDataGridView.DataSource = ""
                Me.SubjectSingleNumbersDataGridView.DataSource = ""
            End If
            If Me.CheckBox1.Checked = True Then
                Me.ClassTestDataGridView.DataSource = ""
                Me.SubjectSingleNumbersDataGridView.DataSource = ""
            End If
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            Me.SubjectiveBindingSource.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.SubjectSingleNumbersBindingSource.EndEdit()
            Me.MarksObtaintBindingSource.EndEdit()
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            WrkBind.EndEdit()

            Me.SubjectSingleNumbersTableAdapter.Update(Me.AuksoftDataSet1.SubjectSingleNumbers)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            'SvAdp.Update(Me.AuksoftDataSet1.Tables(GwRk))
            If Nine = False Then
                If GwRk = "Commerce" Then
                    Me.CommerceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Science" Then
                    Me.ScienceTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                ElseIf GwRk = "Human" Then
                    Me.HumanTableAdapter1.Update(Me.AuksoftDataSet1.Tables(GwRk))
                End If
            End If

        Catch ex As Exception
            Epx()
        Finally
            If Me.AfterSaveGiveMessageToolStripMenuItem.Checked Then
                MsgBox("Saved all data Successfully...", MsgBoxStyle.Information)
            End If

        End Try

        'Beep()

    End Sub

    Private Sub ClassTestDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClassTestDataGridView.CellContentClick

    End Sub

    Private Sub UnFillClassTestMarksToMakeFasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnFillClassTestMarksToMakeFasterToolStripMenuItem.Click
        Me.ClassTestDataGridView.DataSource = ""

    End Sub

    Private Sub FillToSeeClassTestInformationsOfStudentsAndEditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToSeeClassTestInformationsOfStudentsAndEditToolStripMenuItem.Click
        Me.ClassTestDataGridView.DataSource = Me.ClassTestBindingSource

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Dc As Integer
        Button2_Click(sender, e)

        If Nine = False Then
            If Me.ShowSubjectsBindingSource.Count > 0 Then
                Dc = Me.AuksoftDataSet1.ShowSubjects(0).Item("RowNumber").ToString
                rn = Me.AuksoftDataSet1.ShowSubjects.Compute("Count([RowNumber])", "[RowNumber]=" & Dc)
                If rn <> Me.ShowSubjectsBindingSource.Count Then
                    MsgBox("There are some Problems In SubjectEditor... Go and Set Subjects Correctly...The Problem is this type [If this Subject is (Bangla-I) then[Someone have (Bangla-I) in Sub1,Someone have on Sub2... Please Setup Subjects from SubjectEditor...", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    Dc = Me.AuksoftDataSet1.ShowSubjects(0).Item("RowNumber").ToString
                    Dc = Dc + 2
                    Me.AuksoftDataSet1.PassMarks(0).Item(Dc) = Me.TheoryOrSubjectivePassmarksTextBox.Text
                    Me.AuksoftDataSet1.PassMarks(1).Item(Dc) = Me.PraticalOrObjectivePassMarksTextBox.Text

                End If
            End If
        Else
            Dc = Me.SubList.FindStringExact(Subx)
            If Dc > -1 Then
                Dc = Dc + 6
                Me.AuksoftDataSet1.PassMarks(0).Item(Dc) = Me.TheoryOrSubjectivePassmarksTextBox.Text
                Me.AuksoftDataSet1.PassMarks(1).Item(Dc) = Me.PraticalOrObjectivePassMarksTextBox.Text
            Else
                MsgBox("Subject is not Found on List Contact with Developer...auk(0193-500863)", MsgBoxStyle.Critical)
            End If
        End If
        Try
            Me.PassMarksBindingSource.EndEdit()
            Me.PassMarksTableAdapter.Update(Me.AuksoftDataSet1.PassMarks)
            Me.MarksObtaintBindingSource.EndEdit()
            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)

            Me.DefaultConvertNumbersBindingSource.EndEdit()
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub RefreshOnlyTermMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshOnlyTermMarksToolStripMenuItem.Click
        Dim K As Integer
        If Me.CheckBox2.Checked = True Then
            'Me.ClassTestDataGridView.DataSource = ""
            Me.SubjectSingleNumbersDataGridView.DataSource = ""
        End If
        c = 100 / Me.SubjectSingleNumbersBindingSource.Count
        'Me.SubjectSingleNumbersDataGridView.DataSource = ""
        Me.ToolStripProgressBar1.Visible = True
        For K = 0 To Me.SubjectSingleNumbersBindingSource.Count - 1
            Ery(K)
            AukF.InsPro(Me.ToolStripProgressBar1, c)
        Next
        Me.ToolStripProgressBar1.Value = 0
        Me.ToolStripProgressBar1.Visible = False

    End Sub
    Public Sub RefreshNum()
        Dim k As Integer
   
        'Me.SubjectSingleNumbersDataGridView.DataSource = ""
        'Me.ClassTestDataGridView.DataSource = ""
        s = Me.SubjectSingleNumbersBindingSource.Count
        c = Me.ClassTestBindingSource.Count
        If s > c Then
            d = s
        ElseIf s < c Then
            d = c
        ElseIf s = c Then
            d = c
        End If
        s = s - 1
        c = c - 1
        rg = 100 / d
        Me.ToolStripProgressBar1.Visible = True
        Me.CtProg.Visible = True
        Me.CtProg.Value = 0
        Me.ToolStripProgressBar1.Value = 0
        For k = 0 To d - 1
            If k <= c Then
                CTst(k)
            End If
            If k <= s Then
                Ery(k)
            End If
            AukF.InsPro(Me.ToolStripProgressBar1, rg)
            AukF.InsPro(Me.CtProg, rg)
        Next
        Me.CtProg.Value = 0
        Me.ToolStripProgressBar1.Value = 0

        Me.CtProg.Visible = False
        Me.ToolStripProgressBar1.Visible = False
    End Sub
    Private Sub RefreshAllNumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshAllNumbersToolStripMenuItem.Click
        Dim k As Integer
        If Me.CheckBox2.Checked = True Then
            Me.ClassTestDataGridView.DataSource = ""
            Me.SubjectSingleNumbersDataGridView.DataSource = ""
        End If
        'Me.SubjectSingleNumbersDataGridView.DataSource = ""
        'Me.ClassTestDataGridView.DataSource = ""
        s = Me.SubjectSingleNumbersBindingSource.Count
        c = Me.ClassTestBindingSource.Count
        If s > c Then
            d = s
        ElseIf s < c Then
            d = c
        ElseIf s = c Then
            d = c
        End If
        s = s - 1
        c = c - 1
        rg = 100 / d
        Me.ToolStripProgressBar1.Visible = True
        Me.CtProg.Visible = True
        Me.CtProg.Value = 0
        Me.ToolStripProgressBar1.Value = 0
        For k = 0 To d - 1
            If k <= c Then
                CTst(k)
            End If
            If k <= s Then
                Ery(k)
            End If
            AukF.InsPro(Me.ToolStripProgressBar1, rg)
            AukF.InsPro(Me.CtProg, rg)
        Next
        Me.CtProg.Value = 0
        Me.ToolStripProgressBar1.Value = 0

        Me.CtProg.Visible = False
        Me.ToolStripProgressBar1.Visible = False

    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Me.SubjectSingleNumbersDataGridView.DataSource = Me.SubjectSingleNumbersBindingSource
        Me.ClassTestDataGridView.DataSource = Me.ClassTestBindingSource

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        AukF.DelRecAll("SingleSubjectInformation...?", Me.SubjectSingleNumbersBindingSource)
        AukF.DelRecAll("SubjectMarks...?", Me.SubjectiveBindingSource)
        AukF.DelRecAll("ObjectiveMarks...?", Me.ObjectiveBindingSource)
        AukF.DelRecAll("ResultView(all Subject Number Which is Inputed or Be Input)...?", Me.Acc2ConvertBindingSource)
        ToolStripMenuItem1_Click(sender, e)

    End Sub

    Private Sub UnFillAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnFillAllToolStripMenuItem.Click
        Me.SubjectSingleNumbersDataGridView.DataSource = ""
        Me.ClassTestDataGridView.DataSource = ""
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.DataGridViewTextBoxColumn4.Frozen = True
        'Me.DataGridViewTextBoxColumn5.Frozen = True

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.DataGridViewTextBoxColumn4.Frozen = False
        'Me.DataGridViewTextBoxColumn5.Frozen = False

    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Try
            Me.ClassTestDataGridView.Columns.Item(Me.ClassTestDataGridView.CurrentCell.ColumnIndex).Frozen = True
        Catch ex As Exception
            Epx()

        End Try



    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Try
            Me.ClassTestDataGridView.Columns.Item(Me.ClassTestDataGridView.CurrentCell.ColumnIndex).Frozen = False

        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub SelectColumnFreezeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectColumnFreezeToolStripMenuItem.Click
        Me.SubjectSingleNumbersDataGridView.Columns.Item(Me.SubjectSingleNumbersDataGridView.CurrentCell.ColumnIndex).Frozen = True
    End Sub

    Private Sub SeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeToolStripMenuItem.Click
        Me.SubjectSingleNumbersDataGridView.Columns.Item(Me.SubjectSingleNumbersDataGridView.CurrentCell.ColumnIndex).Frozen = False
    End Sub

    Private Sub SelectedColumnInVisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedColumnInVisibleToolStripMenuItem.Click
        Try
            Me.ClassTestDataGridView.Columns.Item(Me.ClassTestDataGridView.CurrentCell.ColumnIndex).Visible = False
        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub DeleSelectedRowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleSelectedRowsToolStripMenuItem.Click
        For I = 0 To Me.ClassTestDataGridView.SelectedRows.Count - 1
            MsgBox(Me.ClassTestDataGridView.SelectedRows.Item(I).Index)
        Next

    End Sub

    Private Sub SelectInvisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectInvisibleToolStripMenuItem.Click
        Me.SubjectSingleNumbersDataGridView.Columns.Item(Me.SubjectSingleNumbersDataGridView.CurrentCell.ColumnIndex).Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ToolStripMenuItem8_Click(sender, e)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        UnFillAllToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub RefreshOnlyClassTestmarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshOnlyClassTestmarksToolStripMenuItem.Click
        If Me.CheckBox2.Checked = True Then
            Me.ClassTestDataGridView.DataSource = ""
            'Me.SubjectSingleNumbersDataGridView.DataSource = ""
        End If
        c = 100 / Me.ClassTestBindingSource.Count
        'Me.SubjectSingleNumbersDataGridView.DataSource = ""
        Me.ToolStripProgressBar1.Visible = True
        For K = 0 To Me.ClassTestBindingSource.Count - 1
            CTst(K)
            AukF.InsPro(Me.ToolStripProgressBar1, c)
        Next
        Me.ToolStripProgressBar1.Value = 0
        Me.ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ToolStripMenuItem3_Click(sender, e)

    End Sub

    Private Sub ObjectiveTotalNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObjectiveTotalNumberTextBox.TextChanged
        Me.TotalNumberTextBox.Text = Val(Me.ObjectiveTotalNumberTextBox.Text) + Val(Me.SubjectiveTotalNumberTextBox.Text)
    End Sub

    Private Sub SubjectiveTotalNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectiveTotalNumberTextBox.TextChanged
        Me.TotalNumberTextBox.Text = Val(Me.ObjectiveTotalNumberTextBox.Text) + Val(Me.SubjectiveTotalNumberTextBox.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        If Me.SubjectSingleNumbersBindingSource.Position > -1 Then Ery(Me.SubjectSingleNumbersBindingSource.Position)
        If Me.ClassTestBindingSource.Position > -1 Then CTst(Me.ClassTestBindingSource.Position)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click, RefrshAllStudentsNumberCurrentSubjectToolStripMenuItem.Click
        RefreshAllNumbersToolStripMenuItem_Click(sender, e)
        If AukF2.MsgTr(What & "Save ?") = True Then
            Save()

        End If

    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If AukF.MsgTr("Do you want to Resject Changes..?") = True Then
            Me.SubjectiveBindingSource.CancelEdit()
            Me.ObjectiveBindingSource.CancelEdit()
            Me.Acc2ConvertBindingSource.CancelEdit()
            Me.AuksoftDataSet1.RejectChanges()

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click, InputTootls.Click
        InputAllThisSubjectStudentsInDatabaseToolStripMenuItem_Click(sender, e)
        'If AukF.MsgTr(What & "Save ?,Without Save Changes Couldn't be accpted... ") = True Then
        '    ToolStripMenuItem3_Click(sender, e)

        'End If
    End Sub

    Private Sub RejectChangeAllwithClassTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangeAllwithClassTestToolStripMenuItem.Click
        If AukF.MsgTr("Do you want to Resject Changes..?") = True Then
            Me.SubjectiveBindingSource.CancelEdit()
            Me.ObjectiveBindingSource.CancelEdit()
            Me.Acc2ConvertBindingSource.CancelEdit()
            Me.ClassTestBindingSource.CancelEdit()

            Me.AuksoftDataSet1.RejectChanges()

        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        AukF.DelRecAll("ClassTest", Me.ClassTestBindingSource)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ToolStripStatusLabel2_Click(sender, e)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ToolStripMenuItem4_Click(sender, e)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ctmarks.Show()

    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.Click


    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        AukF.BindGotoFind(Me.ClassTestBindingSource, "Collegeno", ToolStripTextBox1.Text)
        AukF.BindGotoFind(Me.SubjectSingleNumbersBindingSource, "Collegeno", ToolStripTextBox1.Text)
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        If AukF.MsgTr("Do you want to Reset Database ....Repair Error...?") = True Then
            Opener()


        End If
    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If AukF2.MsgTr(What & "Load Again all data..?") = False Then Exit Sub

        'ToolStripMenuItem6_Click(sender, e)
        AukF.ClearErrorFromDataSet(Me.AuksoftDataSet1)
        'Terminal_Load(sender, e)
        Opener()


    End Sub

    Private Sub RefreshSinglePositionNumberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshSinglePositionNumberToolStripMenuItem.Click
        On Error Resume Next
        If Me.SubjectSingleNumbersBindingSource.Position > -1 Then Ery(Me.SubjectSingleNumbersBindingSource.Position)
        If Me.ClassTestBindingSource.Position > -1 Then CTst(Me.ClassTestBindingSource.Position)

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        InputCol(Me.ToolStripComboBox1.Text, True)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim Na As New SeniorBlackSubjectsReport
        Dim Na2 As New SScBlackSubjectsReport

        If Nine = True Then
            Na2.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer1.ReportSource = Na2
        Else
            Na.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer1.ReportSource = Na
        End If


    End Sub

    Private Sub ToolStripTextBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.Click
        AukF.BindGotoFind(Me.SubjectSingleNumbersBindingSource, "Collegeno", sender.text)

    End Sub

    Private Sub ToolStripTextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextChanged
        AukF.BindFind(Me.SubjectSingleNumbersBindingSource, "Collegeno", Me.ToolStripTextBox3.Text)

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Me.GroupBox4.Visible = True

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Me.GroupBox4.Visible = False

    End Sub

    Private Sub Objective_or_PracticalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Objective_or_PracticalTextBox.TextChanged
        On Error Resume Next
        'Ery(Val(Me.Subjective_or_TheoryTextBox.Text), Val(Me.Objective_or_PracticalTextBox.Text))
    End Sub

    Private Sub Subjective_or_TheoryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subjective_or_TheoryTextBox.TextChanged
        On Error Resume Next
        'Ery(Me.SubjectSingleNumbersBindingSource.Position)
        'Ery(Val(Me.Subjective_or_TheoryTextBox.Text), Val(Me.Objective_or_PracticalTextBox.Text))

    End Sub

    Private Sub CauseOfTermExamComboBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CauseOfTermExamComboBox.LostFocus

    End Sub

    Private Sub CauseOfTermExamComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CauseOfTermExamComboBox.SelectedIndexChanged

    End Sub


    Private Sub AukPrd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Subjective_or_TheoryTextBox.KeyDown, Objective_or_PracticalTextBox.KeyDown, CauseOfTermExamComboBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SubjectSingleNumbersBindingSource.MoveNext()

        End If
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.Up Then
                Me.SelectNextControl(GroupBox4, False, True, True, True)
            ElseIf e.KeyCode = Keys.Down Then
                Me.SelectNextControl(GroupBox4, True, True, True, True)
            ElseIf e.KeyCode = Keys.Left Then
                'Me.SelectNextControl(GroupBox4, True, True, True, True)
                Me.SubjectSingleNumbersBindingSource.MovePrevious()
            ElseIf e.KeyCode = Keys.Right Then
                'Me.SelectNextControl(GroupBox4, True, True, True, True)
                Me.SubjectSingleNumbersBindingSource.MoveNext()

            End If

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub SubList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubList.SelectedIndexChanged
        Subx = sender.text
        If Me.CheckBox3.Checked = True Then
            Opener()
        End If
    End Sub

    Private Sub RefreshAllSubjectNumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshAllSubjectNumbersToolStripMenuItem.Click
        Dim Chk As Boolean = Me.CheckBox3.Checked
        Dim TIlq As Integer
        Me.CheckBox3.Checked = False
        If AukF.MsgTr(What & "Refresh all Subjects Number...?") = True Then

            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Maximum = Me.SubList.Items.Count
            Me.ProgressBar1.Visible = True
            For TIlq = 0 To Me.SubList.Items.Count - 1
                'Me.SubList.SelectedIndex = TIlq
                Subx = Me.SubList.Items.Item(TIlq).ToString

                Opener3()
                If Me.SubjectSingleNumbersBindingSource.Count > 0 Then
                    RefreshNum()
                    Save()
                End If
                If Val(Me.SubList.Items.Count - 1) = TIlq Then
                    Opener()
                End If
                AukF2.InsPro(Me.ProgressBar1, 1)

            Next

        End If
        Me.CheckBox3.Checked = Chk

        Me.ProgressBar1.Visible = False

    End Sub

    Private Sub RefrshAllStudentsNumberCurrentSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Objective_or_PracticalTextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Objective_or_PracticalTextBox.Validated
        Ery(Me.SubjectSingleNumbersBindingSource.Position)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next

        If Me.Label1.Text <> "Total Student:" & Me.SubjectSingleNumbersBindingSource.Count Then
            Me.Label1.Text = "Total Student:" & Me.SubjectSingleNumbersBindingSource.Count

        End If

    End Sub
End Class