Public Class Marks_Division
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
    Dim DefMain As String
    Dim T3rd As Boolean
    Dim Vid As String
    Dim SummaryID, ObjNum, SubjNum As String
    Dim Senior As Boolean
    Dim Jonior1 As Boolean
    Dim SumConPos, SumPos, AcNPos, AcNConPos, SubjPos, ObjPos, GrdPos, SubPassPos, ObjPassPos As Integer
    Dim Qi As Integer
    Dim Qi2 As Integer
    Dim Nine As Boolean
    Public Pgrid As DataGridView = Nothing



    Private Sub Marks_Division_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectOfStudents' table. You can move, or remove it, as needed.
        Me.SubjectOfStudentsTableAdapter.Fill(Me.AuksoftDataSet1.SubjectOfStudents)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.PassMarks' table. You can move, or remove it, as needed.
        'Me.PassMarksTableAdapter.Fill(Me.AuksoftDataSet1.PassMarks)
        AukF.XPAuk(Me)
        Me.CommentsTableAdapter.Fill(Me.AuksoftDataSet1.Comments)
        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd
        Senior = Ac1Sec
        If Val(Clx) = 9 Or Val(Clx) = 10 Then
            Nine = True
            Jonior1 = False
            Senior = False
        Else
            Nine = False
        End If
        If Val(Clx) <= 5 Then
            Jonior1 = True
            Nine = False
            Senior = False
        Else
            Jonior1 = False
        End If
        If Val(Clx) = 11 Or Val(Clx) = 12 Then
            Senior = True
            Jonior1 = False
            Nine = False
        Else
            Senior = False

        End If
        If Senior = False Then
            AukSql.A_SqlAuk_FindAnd_Add("*", "acc2sublst", Me.AuksoftDataSet1)
            'AukSql.A_SqlAuk_FindAnd_Add("*", "acc2sublst", Me.AuksoftDataSet2)
        Else

        End If
    End Sub
    Public Sub Saved()
        Try
            Me.Acc2ConvertBindingSource1.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.SummaryMainBindingSource.EndEdit()
            Me.SummaryMainBindingSource1.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.SubjectiveBindingSource.EndEdit()
            Me.GradingBindingSource.EndEdit()
            If Val(Clx) >= 9 Then
                Me.GradingTableAdapter.Update(Me.AuksoftDataSet1.Grading)
                Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
                Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
            End If


            Me.InformationIDBindingSource.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)

            'Me.SummaryMainTableAdapter.Update()
            Me.SummaryReportBindingSource.EndEdit()
            Me.SummaryReportBindingSource1.EndEdit()

            Me.HighestmarksBindingSource.EndEdit()
            Me.HighestmarksBindingSource1.EndEdit()
            Me.HighestmarksTableAdapter.Update(Me.AuksoftDataSet1.Highestmarks)
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet1.SummaryReport)
            Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)
            'If Val(Clx) Then
            If Val(Clx) >= 3 And Val(Clx) <= 8 Then
                If T3rd = True Then
                    Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet2.SummaryMain)
                    Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet2.SummaryReport)
                    Me.HighestmarksTableAdapter.Update(Me.AuksoftDataSet2.Highestmarks)
                    Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)

                End If
            End If
        Catch ex As Exception
            Epx()
        Finally
            Beep()

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
    

        If T3rd = False Then
            If TR = "FIRST TERM" Then
                Tms = 1
            ElseIf TR = "SECOND TERM" Then
                Tms = 2
            End If
        Else
            Tms = 3
        End If
        If Nine = True Or Senior = True Then
            SFC("SubID")
            STC(SubID, "")
            GSql.Sql_ORD_like_false("*", "Grading", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("SubID", "Convertquality")
            STC(SubID, "")
            GSql.Sql_ORD_like_false("*", "HighestMarks", "", Me.AuksoftDataSet1)
            SFC("SubID")
            STC(SubID)
            GSql.Sql_ORD_like_false("*", "SummaryMain", "Subject", Me.AuksoftDataSet1)
            COnQua = ""
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)

            SFC("SubID")
            STC(SubID)
            GSql.Sql_ORD_like_false("*", "Subjective", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("SubID")
            STC(SubID)
            GSql.Sql_ORD_like_false("*", "Objective", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("SubID")
            STC(SubID)
            GSql.Sql_ORD_like_false("*", "SummaryReport", "", Me.AuksoftDataSet1)
            'SFC("SubID")
            'STC(SubID)
            'GSql.Sql_ORD_like_false("*", "SUBJECTOFSTUDENTS", "VAL(COLLEGENO)", Me.AuksoftDataSet1)


            ConvertPrintToolStripMenuItem.Visible = False
            If Me.HighestmarksBindingSource.Count = 0 Then
                Me.HighestmarksBindingSource.AddNew()
                Me.HighestmarksBindingSource.EndEdit()
                Me.AuksoftDataSet1.Highestmarks(0).SubID = SubID
                Me.AuksoftDataSet1.Highestmarks(0).ConvertQuality = ""
            Else
                Me.AuksoftDataSet1.Highestmarks(0).SubID = SubID
                Me.AuksoftDataSet1.Highestmarks(0).ConvertQuality = ""
            End If
            If Nine = True Then
                SFC("SubID")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", "grading", "", Me.AuksoftDataSet1)
            Else
                SFC("SubID")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", "subjectofstudents", "", Me.AuksoftDataSet1)
            End If
        Else
            If T3rd = False Then
                SFC("SubID", "Convertquality")
                STC(SubID, "")
                GSql.Sql_ORD_like_false("*", "HighestMarks", "", Me.AuksoftDataSet1)
                SFC("SubID")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", "SummaryMain", "Subject", Me.AuksoftDataSet1)
                COnQua = ""
                SFC("SubID", "Convertquality")
                STC(SubID, COnQua)
                GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
                SFC("SubID")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", "SummaryReport", "", Me.AuksoftDataSet1)

                ConvertPrintToolStripMenuItem.Visible = False
                If Me.HighestmarksBindingSource.Count = 0 Then
                    Me.HighestmarksBindingSource.AddNew()
                    Me.HighestmarksBindingSource.EndEdit()
                    Me.AuksoftDataSet1.Highestmarks(0).SubID = SubID
                    Me.AuksoftDataSet1.Highestmarks(0).ConvertQuality = ""
                Else
                    Me.AuksoftDataSet1.Highestmarks(0).SubID = SubID
                    Me.AuksoftDataSet1.Highestmarks(0).ConvertQuality = ""
                End If
            Else
                SFC("SubID", "Convertquality")
                STC(SubID, "")
                GSql.Sql_ORD_like_false("*", "HighestMarks", "", Me.AuksoftDataSet1)
                SFC("SubID", "Convertquality")
                STC(SubID, "3rdTermConvert")
                GSql.Sql_ORD_like_false("*", "HighestMarks", "", Me.AuksoftDataSet2)
                ConvertPrintToolStripMenuItem.Visible = True
                SFC("SubID")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", "SummaryReport", "", Me.AuksoftDataSet1)
                SFC("SubID")
                STC(SubID & "Convert")
                GSql.Sql_ORD_like_false("*", "SummaryReport", "", Me.AuksoftDataSet2)
                SFC("SubID")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
                SFC("SubID")
                STC(SubID & "Convert")
                GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet2)
                COnQua = "3rdTermConvert"
                SFC("SubID", "Convertquality")
                STC(SubID, COnQua)
                GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet2)
                COnQua = ""
                SFC("SubID", "Convertquality")
                STC(SubID, COnQua)
                GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)

                If Me.HighestmarksBindingSource1.Count = 0 Then
                    Me.HighestmarksBindingSource1.AddNew()
                    HighestmarksBindingSource1.EndEdit()
                    Me.AuksoftDataSet2.Highestmarks(0).SubID = SubID
                    Me.AuksoftDataSet2.Highestmarks(0).ConvertQuality = "3rdTermConvert"
                Else
                    Me.AuksoftDataSet2.Highestmarks(0).SubID = SubID
                    Me.AuksoftDataSet2.Highestmarks(0).ConvertQuality = "3rdTermConvert"
                End If


            End If
        End If


        If Me.HighestmarksBindingSource.Count = 0 Then
            Me.HighestmarksBindingSource.AddNew()
            Me.HighestmarksBindingSource.EndEdit()
            Me.AuksoftDataSet1.Highestmarks(0).SubID = SubID
            Me.AuksoftDataSet1.Highestmarks(0).ConvertQuality = ""
        Else
            Me.AuksoftDataSet1.Highestmarks(0).SubID = SubID
            Me.AuksoftDataSet1.Highestmarks(0).ConvertQuality = ""
        End If
       

        SFC("SubID")
        STC(Vid)
        GSql.Sql_ORD_like_false("*", "viewers", "", Me.AuksoftDataSet1)
        If Me.AuksoftDataSet1.Viewers.Count = 0 Then
            Me.AuksoftDataSet1.Viewers.Rows.Add()
            Me.AuksoftDataSet1.Viewers.NewRow.EndEdit()
            Me.AuksoftDataSet1.Viewers(0).SubID = Vid
            Me.AuksoftDataSet1.Viewers(0).Subject = Subx
            Me.AuksoftDataSet1.Viewers(0).Year = Yr
            Me.AuksoftDataSet1.Viewers(0).Term = TR
            Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & TR & "EXAM"
            Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
        ElseIf Me.AuksoftDataSet1.Viewers.Count = 1 Then
            Me.AuksoftDataSet1.Viewers(0).SubID = Vid
            Me.AuksoftDataSet1.Viewers(0).Subject = Subx
            Me.AuksoftDataSet1.Viewers(0).Year = Yr
            Me.AuksoftDataSet1.Viewers(0).Term = TR
            Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & TR & "EXAM"
            Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
        End If
        SFC("StudentClass", "Class_Section", "Shift")
        STC(Clx, Secx, Shv)
        GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)

        SFC("Class")
        STC(Clx)
        GSql.Sql_ORD_like_false("*", "marksobtaint", "", Me.AuksoftDataSet1)

        If Me.AuksoftDataSet1.MarksObtaint.Rows.Count > 0 Then
            DrmcModule.A_plusSt = Me.AuksoftDataSet1.MarksObtaint(0).Item(5).ToString
            DrmcModule.A_St = Me.AuksoftDataSet1.MarksObtaint(0).Item(7).ToString
            DrmcModule.A_MinSt = Me.AuksoftDataSet1.MarksObtaint(0).Item(9).ToString
            DrmcModule.B_ST = Me.AuksoftDataSet1.MarksObtaint(0).Item(11).ToString
            DrmcModule.C_ST = Me.AuksoftDataSet1.MarksObtaint(0).Item(13).ToString
            DrmcModule.Fnum = Me.AuksoftDataSet1.MarksObtaint(0).Item(15).ToString
        End If
        co = (Me.Acc2ConvertBindingSource.Count + Me.Acc2ConvertBindingSource1.Count)
        Me.TotalRec.Text = co
        If Nine = False And Senior = False Then
            SFC("Class")
            STC(Clx)
            GSql.Sql_ORD_like_false("*", "Acc2Subject", "", Me.AuksoftDataSet2)
            'SFC("Class", "Section", "Shift")
            'STC(Clx, Secx, Shv)
            'GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet2)

            SFC("Class")
            STC(Clx)
            GSql.Sql_ORD_like_false("*", "Acc2Subject", "", Me.AuksoftDataSet1)
        Else
            SFC("class", "Sections")
            STC(Clx, GTxt)
            GSql.Sql_ORD_like_false("*", "acc2subject", "", Me.AuksoftDataSet1)
        End If



    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub GIn(ByVal col As String)
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        MainID = SubID & col
        Dim Aq As Integer

        If Nine = True Or Senior = True Then
            SubPassPos = Me.PassMarksBindingSource.Find("ExamID", "Subjective")
            ObjPassPos = Me.PassMarksBindingSource.Find("ExamID", "objective")

            AcNPos = Me.Acc2ConvertBindingSource.Find("collegeno", col)
            'col = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Collegeno.ToString
            ObjPos = Me.ObjectiveBindingSource.Find("Collegeno", col)
            SubjPos = Me.SubjectiveBindingSource.Find("Collegeno", col)
            GrdPos = Me.GradingBindingSource.Find("Collegeno", col)
            If GrdPos = -1 Then
                Me.GradingBindingSource.AddNew()
                Me.GradingBindingSource.EndEdit()
                Aq = Me.GradingBindingSource.Position
                Me.AuksoftDataSet1.Grading(Aq).SubID = SubID
                Me.AuksoftDataSet1.Grading(Aq).MainID = MainID
                Me.AuksoftDataSet1.Grading(Aq).Collegeno = col
                Me.GradingBindingSource.EndEdit()
                GrdPos = Aq
            End If
        Else
            If T3rd = False Then
                AcNPos = Me.Acc2ConvertBindingSource.Find("collegeno", col)
            Else
                AcNPos = Me.Acc2ConvertBindingSource.Find("collegeno", col)
                AcNConPos = Me.Acc2ConvertBindingSource1.Find("collegeno", col)
            End If
        End If



    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TotalNum, TotalNum2, GTotal, SubSub1, SubSub2, Gn(12), Gpd As Double
        Dim Pass, SubjPass, ObjPass As Double
        Dim ResultStr, ResultStr2 As String
        ResultStr2 = ""
        ResultStr = ""

        If Me.AuksoftDataSet1.MarksObtaint.Rows.Count > 0 Then
            Pass = Val(Me.AuksoftDataSet1.MarksObtaint(0).Item("Passmarks").ToString)
      
        End If
        Try
            'If Me.HighestmarksBindingSource.Count > 0 Then
            '    AukF2.DeleteWholeTableRecords(Me.HighestmarksBindingSource)
            'End If
            'If Me.HighestmarksBindingSource1.Count > 0 Then
            '    AukF2.DeleteWholeTableRecords(Me.HighestmarksBindingSource1)
            'End If
            AukF2.EmptyRowCoulms(Me.HighestmarksBindingSource, "3-14", "", ",", False, True, False)
            'MsgBox(AukF2.DivideIn_To_2("3-14", "-", False))
            'MsgBox(QA2)
            Me.HighestmarksTableAdapter.Update(Me.AuksoftDataSet1.Highestmarks)
            If Trd = True And (Val(Clx) >= 3 And Val(Clx) <= 8) Then
                AukF2.EmptyRowCoulms(Me.HighestmarksBindingSource1, "3-14", "", ",", False, True, False)

                Me.HighestmarksTableAdapter.Update(Me.AuksoftDataSet2.Highestmarks)

            End If

        Catch ex As Exception
            Epx()

        End Try
        If Me.AuksoftDataSet1.MarksObtaint.Rows.Count > 0 Then
            DrmcModule.A_plusSt = Me.AuksoftDataSet1.MarksObtaint(0).Item(5).ToString
            DrmcModule.A_St = Me.AuksoftDataSet1.MarksObtaint(0).Item(7).ToString
            DrmcModule.A_MinSt = Me.AuksoftDataSet1.MarksObtaint(0).Item(9).ToString
            DrmcModule.B_ST = Me.AuksoftDataSet1.MarksObtaint(0).Item(11).ToString
            DrmcModule.C_ST = Me.AuksoftDataSet1.MarksObtaint(0).Item(13).ToString
            DrmcModule.Fnum = Me.AuksoftDataSet1.MarksObtaint(0).Item(15).ToString
        End If
        Dim Vp As String = Me.AuksoftDataSet1.Comments(0).PassVPCom.ToString
        Dim Pri As String = Me.AuksoftDataSet1.Comments(0).PassPriCom.ToString
        Dim CCom As String = Me.AuksoftDataSet1.Comments(0).PassClassteacherCom.ToString
        Dim VpF As String = Me.AuksoftDataSet1.Comments(0).FailedVpCom.ToString
        Dim PriF As String = Me.AuksoftDataSet1.Comments(0).FailedPriCom.ToString
        Dim CComF As String = Me.AuksoftDataSet1.Comments(0).FailedClassTeacherCom.ToString
        Dim Avgx, Abs, FailNum, Avgx2, Abs2, FailNum2, Xn, Sb, GnW As Integer

        Dim FailSub, FailSub2, QSubject As String
        Dim SubFail(12), FailIn(12) As Boolean
        Dim Csil As String
        Dim Yp, Qmp As Integer
        Me.DataGridView1.DataSource = ""
        Me.DataGridView2.DataSource = ""
        Me.DataGridView3.DataSource = ""
        Me.SUbjView.DataSource = ""
        Me.ObjView.DataSource = ""
        'Try
        Me.ProgressBar1.Value = 0

        perpix = Val(100 / Me.InformationIDBindingSource.Count)
        Me.GroupBox1.Visible = True
        Me.ProSub.Value = 0
        If Jonior1 = True Then
            Csil = 10
        ElseIf Nine = True Then
            Csil = 11
        ElseIf Senior = True Then
            'Csil = Val(Me.SubjNm.Text)
            'If Me.CheckBox1.Checked = True Then
            '    If TR.ToLower = "test" Then
            '        If Csil <> 12 Then
            '            If AukF.MsgTr("Grading = True ... Must be set 12 subject if not Set automatically if you click on 'Yes'....") = True Then
            '                Csil = 12
            '            Else
            '                MsgBox("Please set your self or Please Check off Grading...", MsgBoxStyle.Critical)
            '                Exit Sub
            '            End If
            '        End If
            '    Else
            '        If Csil <> 6 Or Clx <> 12 Then
            '            If AukF.MsgTr("Grading = True ... Must be set 6 subject if not Set automatically if you click on 'Yes'....") = True Then
            '                Csil = 6
            '            Else
            '                MsgBox("Please set your self or Please Check off Grading 6 or 12...", MsgBoxStyle.Critical)
            '                Exit Sub
            '            End If
            '        End If
            '    End If
            'Else
            '    Csil = Val(Me.SubjNm.Text)
            '    If Csil = 0 Then
            '        MsgBox("Please Type Subject for Get Subjects Pass,Fail etc...(If Type 6... then Sub1,Sub2,Sub3...Sub5)", MsgBoxStyle.Critical)
            '        Me.SubjNm.Focus()

            '        Exit Sub

            '    End If
            'End If
            If TR.ToLower = "test" Then
                Csil = 12
            Else
                Csil = 6

            End If




        Else
            Csil = 11
        End If

        colpix = Val(100 / Csil)

        For I = 0 To Me.Acc2ConvertBindingSource.Count - 1
            If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                Me.ProSub.Value = 0
            End If
            cgh = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
            GIn(cgh)
            If Nine = True Or Senior = True Then
                If (Nine = True) Or (Senior = True And Csil = 6 And Me.CheckBox1.Checked = True) Then 'Class 11 Generate if Class (9 or 10) False
                    If AcNPos > -1 Then
                        TotalNum = 0
                        Avgx = 0
                        Abs = 0
                        FailNum = 0
                        FailSub = ""
                        GTotal = 0
                        grnum = 0
                        SubSub1 = 0

                        'If Nine = True Then

                        For Qi = 5 To ((Csil - 1) + 5)
                            Sb = Qi - 5

                            Xn = Qi + 1
                            SubjPass = Val(Me.AuksoftDataSet1.PassMarks(SubPassPos).Item(Xn).ToString)
                            ObjPass = Val(Me.AuksoftDataSet1.PassMarks(ObjPassPos).Item(Xn).ToString)
                            c = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString
                            'MsgBox(c)
                            Qi2 = Qi - 1

                            If ObjPos > -1 Then ObjNum = Me.AuksoftDataSet1.Objective(ObjPos).Item(Qi2).ToString Else ObjNum = 0
                            If SubjPos > -1 Then SubjNum = Me.AuksoftDataSet1.Subjective(ObjPos).Item(Qi2).ToString Else SubjNum = 0
                            If (Val(ObjNum) < Val(ObjPass)) Or (Val(SubjNum) < Val(SubjPass)) Then
                                SubFail(Sb) = True
                            Else
                                SubFail(Sb) = False
                            End If
                            If c = "CA" Then
                                Avgx = Avgx + 1
                            ElseIf c = "A" Then
                                Abs = Abs + 1
                            ElseIf Val(c) >= Pass Then
                                If SubFail(Sb) = True Then
                                    FailNum = FailNum + 1
                                    FailIn(Sb) = True
                                Else
                                    FailIn(Sb) = False

                                End If
                            ElseIf Val(c) < Pass Then
                                FailIn(Sb) = True
                                FailNum = FailNum + 1
                            End If

                            If Nine = True Then 'Class 9 Generate
                                If Me.CheckBox1.Checked = True Then
                                    If GrdPos > -1 Then
                                        grnum = 0
                                        mn = Qi - 5
                                        If (mn = 0 Or mn = 1) Or (mn = 2 Or mn = 3) Then
                                            SubSub1 = Val(c) + SubSub1
                                            If mn = 1 Or mn = 3 Then
                                                SubSub1 = SubSub1 / 2
                                                grnum = AukF.NumAsGrdValue(SubSub1)
                                                grd = AukF.GradePointsToGrade(grnum)
                                                'below (B1 & b2) and (E1 & E2) Subjects Failed are decided... 
                                                If FailIn(0) = True Or FailIn(1) = True Or FailIn(2) = True Or FailIn(3) = True Then
                                                    If FailIn(0) = True Or FailIn(1) = True Then
                                                        Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = "F"
                                                    Else
                                                        Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = "F"
                                                    End If
                                                Else
                                                    Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = grd
                                                End If
                                                SubSub1 = 0
                                            End If
                                        Else 'Class 9 or 10 's Optional Subjects Generate(Subject Number 11)
                                            If mn = 11 Then
                                                If SubFail(Sb) = True Then
                                                    grnum = 0

                                                    Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = "F"
                                                Else
                                                    grnum = AukF.NumAsGrdValue(c)
                                                    grd = AukF.GradePointsToGrade(grnum)
                                                    Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = grd
                                                    If Val(grnum) >= 2 Then
                                                        grnum = grnum - 2

                                                    End If
                                                End If
                                            Else
                                                If SubFail(Sb) = True Then
                                                    grnum = 0

                                                    Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = "F"
                                                Else
                                                    grnum = AukF.NumAsGrdValue(c)
                                                    grd = AukF.GradePointsToGrade(grnum)
                                                    Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = grd
                                                End If
                                            End If


                                        End If

                                    End If

                                End If
                            End If
                            If Senior = True And Nine = False Then
                                mn = (Qi - 4)
                                If mn = Csil Then
                                    If FailIn(Sb) = True Then
                                        grnum = 0
                                        Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = "F"
                                    Else
                                        grnum = AukF.NumAsGrdValue(c)
                                        grd = AukF.GradePointsToGrade(grnum)
                                        Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = grd
                                    End If
                                Else
                                    If FailIn(Sb) = True Then
                                        grnum = 0
                                        Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = "F"
                                    Else
                                        grnum = AukF.NumAsGrdValue(c)
                                        grd = AukF.GradePointsToGrade(grnum)
                                        Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2) = grd
                                        If Val(grnum) >= 2 Then
                                            grnum = grnum - 2

                                        End If
                                    End If
                                End If

                            End If
                            GTotal = GTotal + Val(grnum)
                            TotalNum = TotalNum + Val(c)
                            If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                                Me.ProSub.Value = 0
                                'MsgBox("done")
                            End If
                            Me.ProSub.Value = ProSub.Value + Val(colpix)
                            '............highest marks
                            Qmp = (Qi - 5) + 3
                            Vnum = Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp).ToString()
                            If Val(c) > Val(Vnum) Then
                                Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp) = Val(c)
                            End If
                            'QSubject = Me.AuksoftDataSet1.Acc2SubLst(Qmp).Lst.ToString()
                            'Me.HighestmarksBindingSource .Find 
                        Next
                        'MsgBox(FailNum, , GTotal)
                        If FailNum = 0 Then ' ResultStr Making Started (9 & 10 ResultStr) .....
                            'ResultStr = "Failed In " & FailNum & " Subjects"
                            If Val(Avgx) + Val(Abs) = Csil Then
                                ResultStr = "Absent in all subjects"
                            ElseIf Val(Avgx) + Val(Abs) > 0 Then
                                If Val(Avgx) + Val(Abs) > 1 Then
                                    ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subjects"
                                ElseIf Val(Avgx) + Val(Abs) = 1 Then
                                    ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subject"
                                End If
                            Else
                                ResultStr = "Pass"

                            End If
                        ElseIf FailNum > 0 Then
                            If Val(Avgx) + Val(Abs) = 0 Then
                                If FailNum > 1 Then
                                    ResultStr = "Failed In " & FailNum & " Subjects"
                                ElseIf FailNum = 1 Then
                                    ResultStr = "Failed In " & FailNum & " Subject"
                                End If
                                If Val(Avgx) + Val(Abs) > 0 Then
                                    ResultStr = ResultStr & ",Absent:" & Val(Avgx) + Val(Abs)
                                End If
                            End If
                        End If

                        'End If

                        If FailNum = 0 Then
                            If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", cgh) = True Then
                                Me.AuksoftDataSet1.InformationID(ComRow).AvgSubs = Avgx
                                Me.AuksoftDataSet1.InformationID(ComRow).FailSubs = FailNum
                                Me.AuksoftDataSet1.InformationID(ComRow).AbsentSubs = Abs
                                Me.AuksoftDataSet1.InformationID(ComRow).LastTermExam = TR
                                Me.AuksoftDataSet1.InformationID(ComRow).Result = ResultStr
                                Me.AuksoftDataSet1.InformationID(ComRow).TotalMarks = TotalNum
                            End If

                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = Vp
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = Pri
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CCom
                            psub = Csil - Avgx - Abs
                            If Val(psub) <> Csil Then
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            Else
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            End If

                            If Nine = True And GrdPos > -1 Then
                                'GTotal = (GTotal - 2)
                                dx = GTotal / 8
                                wq = dx
                                'wq = AukF.NumAsGrdValue(dx)
                                If Val(wq) > 5 Then
                                    wq = 5
                                ElseIf Val(wq) < 0 Then
                                    wq = 0
                                End If
                                Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                                Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                                Me.AuksoftDataSet1.Grading(GrdPos).Total = AukF.GradePointsToGrade(GTotal / 8)
                            Else
                                dx = GTotal / 5
                                wq = dx
                                'wq = AukF.NumAsGrdValue(dx)
                                If Val(wq) > 5 Then
                                    wq = 5
                                ElseIf Val(wq) < 0 Then
                                    wq = 0
                                End If
                                Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                                Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                                Me.AuksoftDataSet1.Grading(GrdPos).Total = AukF.GradePointsToGrade(GTotal / 5)
                            End If
                            'If Senior = True And GrdPos > -1 Then
                            '    Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                            '    dx = GTotal / 5
                            '    wq = dx
                            '    'wq = AukF.NumAsGrdValue(dx)
                            '    If Val(wq) > 5 Then
                            '        wq = 5
                            '    ElseIf Val(wq) < 0 Then
                            '        wq = 0
                            '    End If
                            '    Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                            '    Me.AuksoftDataSet1.Grading(GrdPos).Total = AukF.GradePointsToGrade(GTotal / 5)
                            'End If

                        Else
                            Me.AuksoftDataSet1.InformationID(I).Result = ResultStr
                            Me.AuksoftDataSet1.InformationID(I).LastTermExam = TR

                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = VpF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = PriF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CComF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            If Nine = True And GrdPos > -1 Then

                                'GTotal = (GTotal - 2)
                                Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                                dx = GTotal / 8
                                wq = dx
                                'wq = AukF.NumAsGrdValue(dx)
                                If Val(wq) > 5 Then
                                    wq = 5
                                ElseIf Val(wq) < 0 Then
                                    wq = 0
                                End If
                                Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                                Me.AuksoftDataSet1.Grading(GrdPos).Total = "F"

                            ElseIf Senior = True And GrdPos > -1 Then
                                'GTotal = (GTotal - 2)if 

                                Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                                dx = GTotal / 5
                                wq = dx
                                'wq = AukF.NumAsGrdValue(dx)
                                If Val(wq) > 5 Then
                                    wq = 5
                                ElseIf Val(wq) < 0 Then
                                    wq = 0
                                End If
                                Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                                Me.AuksoftDataSet1.Grading(GrdPos).Total = AukF.GradePointsToGrade(GTotal / 5)
                                If FailNum > 0 Then
                                    'MsgBox("Failed", , cgh)
                                    Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                                    Me.AuksoftDataSet1.Grading(GrdPos).Total = "F"
                                End If

                            End If


                        End If
                        If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", cgh) = True Then
                            Me.AuksoftDataSet1.InformationID(ComRow).AvgSubs = Avgx
                            Me.AuksoftDataSet1.InformationID(ComRow).FailSubs = FailNum
                            Me.AuksoftDataSet1.InformationID(ComRow).AbsentSubs = Abs
                            Me.AuksoftDataSet1.InformationID(ComRow).LastTermExam = TR
                            Me.AuksoftDataSet1.InformationID(ComRow).TotalMarks = TotalNum
                            'Me.AuksoftDataSet1.InformationID(ComRow).Result = "Pass"

                        End If




                        'End If

                    End If
                ElseIf (Nine = False) And (Senior = True And Me.CheckBox1.Checked = True And TR.ToLower = "test") Then 'nine false .....

                    If AcNPos > -1 Then
                        TotalNum = 0
                        Avgx = 0
                        Abs = 0
                        FailNum = 0
                        FailSub = ""
                        GTotal = 0
                        grnum = 0
                        SubSub1 = 0

                        'If Nine = True Then

                        For Qi = 5 To ((Csil - 1) + 5)
                            Sb = Qi - 5

                            Xn = Qi + 1
                            SubjPass = Val(Me.AuksoftDataSet1.PassMarks(SubPassPos).Item(Xn).ToString)
                            ObjPass = Val(Me.AuksoftDataSet1.PassMarks(ObjPassPos).Item(Xn).ToString)
                            c = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString
                            'MsgBox(c)
                            Qi2 = Qi - 1

                            If ObjPos > -1 Then ObjNum = Me.AuksoftDataSet1.Objective(ObjPos).Item(Qi2).ToString Else ObjNum = 0
                            If SubjPos > -1 Then SubjNum = Me.AuksoftDataSet1.Subjective(ObjPos).Item(Qi2).ToString Else SubjNum = 0
                            If (Val(ObjNum) < Val(ObjPass)) Or (Val(SubjNum) < Val(SubjPass)) Then
                                SubFail(Sb) = True
                            Else
                                SubFail(Sb) = False
                            End If
                            If c = "CA" Then
                                Avgx = Avgx + 1
                            ElseIf c = "A" Then
                                Abs = Abs + 1
                            ElseIf Val(c) >= Pass Then
                                If SubFail(Sb) = True Then
                                    FailNum = FailNum + 1
                                    FailIn(Sb) = True
                                Else
                                    FailIn(Sb) = False
                                End If
                            ElseIf Val(c) < Pass Then
                                FailNum = FailNum + 1
                                FailIn(Sb) = True
                            End If
                            GnW = Qi - 5
                            If GnW = 1 Or GnW = 3 Or GnW = 5 Or GnW = 7 Or GnW = 9 Or GnW = 11 Then
                                If GnW = 11 Then
                                    If FailIn(GnW) = True Or FailIn(GnW - 1) = True Then
                                        If GrdPos > -1 Then
                                            gx = AukF.GradePointsToGrade(grnum)
                                            Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = "F"
                                        End If
                                        SubSub1 = 0

                                        GTotal = GTotal + Val(0)
                                    ElseIf (FailIn(GnW) = False) And (FailIn(GnW - 1) = False) Then

                                        SubSub1 = Val(Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi - 1).ToString) + Val(Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString)
                                        Gpd = Val(SubSub1) / 2

                                        grnum = AukF.NumAsGrdValue(Gpd)

                                        If GrdPos > -1 Then
                                            gx = AukF.GradePointsToGrade(grnum)
                                            Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = gx
                                        End If
                                        If Val(grnum) >= 2 Then
                                            grnum = Val(grnum) - 2

                                        End If
                                        'MsgBox(Gpd & "," & grnum & "," & gx)
                                        SubSub1 = 0
                                        GTotal = GTotal + Val(grnum)
                                    End If
                                Else
                                    If FailIn(GnW) = True Or FailIn(GnW - 1) = True Then
                                        If GrdPos > -1 Then
                                            gx = AukF.GradePointsToGrade(grnum)
                                            Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = "F"
                                        End If
                                        SubSub1 = 0

                                        GTotal = GTotal + Val(0)
                                    ElseIf (FailIn(GnW) = False) And (FailIn(GnW - 1) = False) Then

                                        SubSub1 = Val(Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi - 1).ToString) + Val(Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString)
                                        Gpd = Val(SubSub1) / 2

                                        grnum = AukF.NumAsGrdValue(Gpd)

                                        If GrdPos > -1 Then
                                            gx = AukF.GradePointsToGrade(grnum)
                                            Me.AuksoftDataSet1.Grading(GrdPos).Item(Qi2 - 1) = gx
                                        End If
                                        'MsgBox(Gpd & "," & grnum & "," & gx)
                                        SubSub1 = 0
                                        GTotal = GTotal + Val(grnum)
                                    End If
                                End If


                            End If


                            TotalNum = TotalNum + Val(c)
                            If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                                Me.ProSub.Value = 0
                                'MsgBox("done")
                            End If

                            Me.ProSub.Value = ProSub.Value + Val(colpix)
                            Qmp = (Qi - 5) + 3
                            Vnum = Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp).ToString()
                            If Val(c) > Val(Vnum) Then
                                Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp) = Val(c)
                            End If
                            'QSubject = Me.AuksoftDataSet1.Acc2SubLst(Qmp).Lst.ToString()
                            'Me.HighestmarksBindingSource .Find 
                        Next
                        If FailNum = 0 Then ' ResultStr Making Started (12 test ResultStr) .....
                            'ResultStr = "Failed In " & FailNum & " Subjects"
                            If Val(Avgx) + Val(Abs) = Csil Then
                                ResultStr = "Absent in all subjects"
                            ElseIf Val(Avgx) + Val(Abs) > 0 Then
                                If Val(Avgx) + Val(Abs) > 1 Then
                                    ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subjects"
                                ElseIf Val(Avgx) + Val(Abs) = 1 Then
                                    ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subject"

                                End If
                            Else
                                ResultStr = "Pass"

                            End If
                        ElseIf FailNum > 0 Then
                            If Val(Avgx) + Val(Abs) = 0 Then
                                If FailNum > 1 Then
                                    ResultStr = "Failed In " & FailNum & " Subjects"
                                ElseIf FailNum = 1 Then
                                    ResultStr = "Failed In " & FailNum & " Subject"
                                End If
                                If Val(Avgx) + Val(Abs) > 0 Then
                                    ResultStr = ResultStr & ",Absent:" & Val(Avgx) + Val(Abs)
                                End If
                            End If
                        End If
                        If FailNum = 0 Then


                            Me.AuksoftDataSet1.InformationID(I).Result = ResultStr
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = Vp
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = Pri
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CCom
                            psub = Csil - Avgx - Abs
                            If Val(psub) <> Csil Then
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            Else
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            End If
                            If Senior = True And GrdPos > -1 Then
                                'GTotal = (GTotal - 2)
                                Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                                dx = GTotal / 5
                                wq = Format(dx, "0.##")
                                'wq = AukF.NumAsGrdValue(dx)
                                If Val(wq) > 5 Then
                                    wq = 5
                                ElseIf Val(wq) < 0 Then
                                    wq = 0
                                End If
                                Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = wq
                                Me.AuksoftDataSet1.Grading(GrdPos).Total = AukF.GradePointsToGrade(GTotal / 5)

                            End If

                        Else
                            Me.AuksoftDataSet1.InformationID(I).Result = ResultStr
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = VpF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = PriF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CComF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            If Nine = True And GrdPos > -1 Then
                                'GTotal = (GTotal - 2)
                                Me.AuksoftDataSet1.Grading(GrdPos).GradingMarks = GTotal
                                Me.AuksoftDataSet1.Grading(GrdPos).TotalGrading = GTotal / 8
                                Me.AuksoftDataSet1.Grading(GrdPos).Total = "F"
                            End If


                        End If
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).Totalmarks = TotalNum
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).FailedSubjectNumber = FailNum
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).AbsentSubjectsNumbers = Abs
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).AverageSubjectNumbers = Avgx


                        If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", cgh) = True Then
                            Me.AuksoftDataSet1.InformationID(ComRow).AvgSubs = Avgx
                            Me.AuksoftDataSet1.InformationID(ComRow).FailSubs = FailNum
                            Me.AuksoftDataSet1.InformationID(ComRow).AbsentSubs = Abs
                            Me.AuksoftDataSet1.InformationID(ComRow).LastTermExam = TR
                            Me.AuksoftDataSet1.InformationID(ComRow).TotalMarks = TotalNum
                            'Me.AuksoftDataSet1.InformationID(ComRow).Result = "Pass"

                        End If



                        'End If

                    End If

                End If



            Else
                If T3rd = False Then

                    If AcNPos > -1 Then
                        TotalNum = 0
                        Avgx = 0
                        Abs = 0
                        FailNum = 0
                        FailSub = ""
                        For Qi = 5 To ((Csil - 1) + 5)
                            c = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString
                            If c = "P" Then
                                Avgx = Avgx + 1
                            ElseIf c = "A" Then
                                Abs = Abs + 1
                            ElseIf Val(c) < Pass Then
                                FailNum = FailNum + 1
                            End If
                            TotalNum = TotalNum + Val(c)

                            If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                                Me.ProSub.Value = 0
                                'MsgBox("done")
                            End If
                            Me.ProSub.Value = ProSub.Value + Val(colpix)
                            Qmp = (Qi - 5) + 3
                            Vnum = Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp).ToString()
                            If Val(c) > Val(Vnum) Then
                                Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp) = Val(c)
                            End If
                            'QSubject = Me.AuksoftDataSet1.Acc2SubLst(Qmp).Lst.ToString()
                            'Me.HighestmarksBindingSource .Find 
                        Next
                        If FailNum = 0 Then ' ResultStr Making Started (3-8 1st and 2nd term ResultStr) .....
                            'ResultStr = "Failed In " & FailNum & " Subjects"
                            If Val(Avgx) + Val(Abs) = Csil Then
                                ResultStr = "Absent in all subjects"
                            ElseIf Val(Avgx) + Val(Abs) > 0 Then
                                If Val(Avgx) + Val(Abs) > 1 Then
                                    ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subjects"
                                ElseIf Val(Avgx) + Val(Abs) = 1 Then
                                    ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subject"
                                End If
                            Else
                                ResultStr = "Pass"
                            End If
                        ElseIf FailNum > 0 Then
                            If Val(Avgx) + Val(Abs) = 0 Then
                                If FailNum > 1 Then
                                    ResultStr = "Failed In " & FailNum & " Subjects"
                                ElseIf FailNum = 1 Then
                                    ResultStr = "Failed In " & FailNum & " Subject"
                                End If
                                If Val(Avgx) + Val(Abs) > 0 Then
                                    ResultStr = ResultStr & ",Absent:" & Val(Avgx) + Val(Abs)
                                End If
                            End If
                        End If
                        If FailNum = 0 Then
                            'Me.AuksoftDataSet1.InformationID(I).Result = ResultStr
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = Vp
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = Pri
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CCom
                            psub = Csil - Avgx - Abs
                            If Val(psub) <> Csil Then
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            Else
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            End If

                        Else
                            'Me.AuksoftDataSet1.InformationID(I).Result = ResultStr
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = VpF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = PriF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CComF
                            Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr

                        End If
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).Totalmarks = TotalNum
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).FailedSubjectNumber = FailNum
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).AbsentSubjectsNumbers = Abs
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).AverageSubjectNumbers = Avgx
                        If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", cgh) = True Then
                            Me.AuksoftDataSet1.InformationID(ComRow).AvgSubs = Avgx
                            Me.AuksoftDataSet1.InformationID(ComRow).FailSubs = FailNum
                            Me.AuksoftDataSet1.InformationID(ComRow).AbsentSubs = Abs
                            Me.AuksoftDataSet1.InformationID(ComRow).LastTermExam = TR
                            Me.AuksoftDataSet1.InformationID(ComRow).Result = ResultStr
                            Me.AuksoftDataSet1.InformationID(ComRow).TotalMarks = TotalNum
                        End If



                        'If Me.CheckBox1.Checked = True Then
                        '    Me.AuksoftDataSet1.Acc2Convert(AcNPos).Position = 0
                        '    Me.AuksoftDataSet1.InformationID(I).Position_Number = 0
                        '    Me.AuksoftDataSet1.InformationID(I).TxtPos = 0
                        'End If
                    End If
                Else 'trd = true

                    If (AcNPos > -1) And (AcNConPos > -1) Then
                        TotalNum = 0
                        Avgx = 0
                        Abs = 0
                        FailNum = 0
                        FailSub = ""
                        TotalNum2 = 0
                        Avgx2 = 0
                        Abs2 = 0
                        FailNum2 = 0
                        FailSub2 = ""
                        For Qi = 5 To ((Csil - 1) + 5)
                            c = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString
                            If c = "P" Then
                                Avgx = Avgx + 1
                            ElseIf c = "A" Then
                                Abs = Abs + 1
                            ElseIf Val(c) < Pass Then
                                FailNum = FailNum + 1
                            End If
                            TotalNum = TotalNum + Val(c)
                            Qmp = (Qi - 5) + 3
                            Vnum = Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp).ToString()
                            If Val(c) > Val(Vnum) Then
                                Me.AuksoftDataSet1.Highestmarks(0).Item(Qmp) = Val(c)
                            End If

                            c = Me.AuksoftDataSet2.Acc2Convert(AcNConPos).Item(Qi).ToString
                            If c = "P" Then
                                Avgx2 = Avgx2 + 1
                            ElseIf c = "A" Then
                                Abs2 = Abs2 + 1
                            ElseIf Val(c) < Pass Then
                                FailNum2 = FailNum2 + 1
                            End If
                            TotalNum2 = TotalNum2 + Val(c)
                            'Qmp = (Qi - 5) + 2
                            Vnum = Me.AuksoftDataSet2.Highestmarks(0).Item(Qmp).ToString()
                            If Val(c) > Val(Vnum) Then
                                Me.AuksoftDataSet2.Highestmarks(0).Item(Qmp) = Val(c)
                            End If

                            If FailNum = 0 Then ' ResultStr Making Started (3-8 3rd term ResultStr) .....
                                'ResultStr = "Failed In " & FailNum & " Subjects"
                                If Val(Avgx) + Val(Abs) = Csil Then
                                    ResultStr = "Absent in all subjects"
                                ElseIf Val(Avgx) + Val(Abs) > 0 Then
                                    If Val(Avgx) + Val(Abs) > 1 Then
                                        ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subjects"
                                    ElseIf Val(Avgx) + Val(Abs) = 1 Then
                                        ResultStr = "Absent In " & Val(Avgx) + Val(Abs) & " Subject"
                                    End If
                                Else
                                    ResultStr = "Pass"
                                End If
                            ElseIf FailNum > 0 Then
                                If Val(Avgx) + Val(Abs) = 0 Then
                                    If FailNum > 1 Then
                                        ResultStr = "Failed In " & FailNum & " Subjects"
                                    ElseIf FailNum = 1 Then
                                        ResultStr = "Failed In " & FailNum & " Subject"
                                    End If
                                    If Val(Avgx) + Val(Abs) > 0 Then
                                        ResultStr = ResultStr & ",Absent:" & Val(Avgx) + Val(Abs)
                                    End If
                                End If
                            End If
                            If FailNum2 = 0 Then ' ResultStr2 Making Started (3-8 3rd term ResultStr) For Converted Marks .....
                                'ResultStr = "Failed In " & FailNum & " Subjects"
                                If Val(Avgx2) + Val(Abs2) = Csil Then
                                    ResultStr2 = "Absent in all subjects"
                                ElseIf Val(Avgx2) + Val(Abs2) > 0 Then
                                    If Val(Avgx2) + Val(Abs2) > 1 Then
                                        ResultStr2 = "Absent In " & Val(Avgx2) + Val(Abs2) & " Subjects"
                                    ElseIf Val(Avgx2) + Val(Abs2) = 1 Then
                                        ResultStr2 = "Absent In " & Val(Avgx2) + Val(Abs2) & " Subject"
                                    End If
                                Else
                                    ResultStr2 = "Pass"
                                End If
                            ElseIf FailNum2 > 0 Then
                                If Val(Avgx2) + Val(Abs2) = 0 Then
                                    If FailNum2 > 1 Then
                                        ResultStr2 = "Failed In " & FailNum2 & " Subjects"
                                    ElseIf FailNum2 = 1 Then
                                        ResultStr2 = "Failed In " & FailNum2 & " Subject"
                                    End If
                                    If Val(Avgx2) + Val(Abs2) > 0 Then
                                        ResultStr2 = ResultStr2 & ",Absent:" & Val(Avgx2) + Val(Abs2)
                                    End If
                                End If
                            End If
                            If FailNum = 0 Then
                                'Me.AuksoftDataSet1.InformationID(I).Result = "Pass"
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = Vp
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = Pri
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CCom
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                            Else
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).Result = ResultStr
                                'Me.AuksoftDataSet1.InformationID(I).Result = "Failed In " & FailNum & " Subjects"
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).VpComments = VpF
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos)._Principal_sComments = PriF
                                Me.AuksoftDataSet1.Acc2Convert(AcNPos).ClassTeacherComment = CComF
                            End If
                            If FailNum2 = 0 Then
                                'Me.AuksoftDataSet1.InformationID(I).Result = ResultStr2
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos).VpComments = Vp
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos)._Principal_sComments = Pri
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos).ClassTeacherComment = CCom
                                psub = Csil - Avgx - Abs
                                If Val(psub) <> Csil Then
                                    Me.AuksoftDataSet2.Acc2Convert(AcNConPos).Result = ResultStr2
                                Else
                                    Me.AuksoftDataSet2.Acc2Convert(AcNConPos).Result = ResultStr2
                                End If

                            Else
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos).Result = ResultStr2
                                'Me.AuksoftDataSet1.InformationID(I).Result = ResultStr2
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos).VpComments = VpF
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos)._Principal_sComments = PriF
                                Me.AuksoftDataSet2.Acc2Convert(AcNConPos).ClassTeacherComment = CComF
                            End If
                            If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", cgh) = True Then
                                Me.AuksoftDataSet1.InformationID(ComRow).AvgSubs = Avgx2
                                Me.AuksoftDataSet1.InformationID(ComRow).FailSubs = FailNum2
                                Me.AuksoftDataSet1.InformationID(ComRow).AbsentSubs = Abs2
                                Me.AuksoftDataSet1.InformationID(ComRow).LastTermExam = TR
                                Me.AuksoftDataSet1.InformationID(ComRow).Result = ResultStr2
                                Me.AuksoftDataSet1.InformationID(ComRow).TotalMarks = TotalNum2
                            End If
                            If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                                Me.ProSub.Value = 0
                            End If
                            Me.ProSub.Value = ProSub.Value + Val(colpix)
                        Next
                        Me.AuksoftDataSet2.Acc2Convert(AcNConPos).Totalmarks = TotalNum2
                        Me.AuksoftDataSet2.Acc2Convert(AcNConPos).FailedSubjectNumber = FailNum2
                        Me.AuksoftDataSet2.Acc2Convert(AcNConPos).AbsentSubjectsNumbers = Abs2
                        Me.AuksoftDataSet2.Acc2Convert(AcNConPos).AverageSubjectNumbers = Avgx2
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).FailedSubjectNumber = FailNum
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).AbsentSubjectsNumbers = Abs
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).AverageSubjectNumbers = Avgx
                        'Me.AuksoftDataSet1.Acc2Convert(AcNPos).FailedSubjects = FailSub
                        Me.AuksoftDataSet1.Acc2Convert(AcNPos).Totalmarks = TotalNum

                    Else
                        If AcNPos > -1 Then
                            MsgBox(Me.AuksoftDataSet1.Acc2Convert(AcNPos).CollegeNo.ToString & " College no's Convert Numbers is not Valid ...Input all from Result....!", MsgBoxStyle.Critical)
                        End If
                        If AcNConPos > -1 Then
                            MsgBox(Me.AuksoftDataSet2.Acc2Convert(AcNConPos).CollegeNo.ToString & " College no's Numbers is not Valid ...Input all from Result....!", MsgBoxStyle.Critical)
                        End If
                        If AukF.MsgTr(What & " Exit from Function...?") = True Then
                            Me.ProgressBar1.Value = 0
                            Me.ProSub.Value = 0
                            Exit Sub

                        End If
                    End If

                End If
                '<last Off -- See for Any Effect>
                If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", cgh) = True Then
                    Me.AuksoftDataSet1.InformationID(ComRow).TotalMarks = TotalNum
                    If T3rd = False Then
                        If FailNum > 0 Then
                            Me.AuksoftDataSet1.InformationID(ComRow).Result = "Failed In " & FailNum & " Subjects"
                        Else
                            Me.AuksoftDataSet1.InformationID(ComRow).Result = "Pass"
                        End If

                    Else
                        If FailNum2 > 0 Then
                            Me.AuksoftDataSet1.InformationID(ComRow).Result = ResultStr2
                        Else
                            Me.AuksoftDataSet1.InformationID(ComRow).Result = ResultStr2
                        End If
                    End If

                    Me.AuksoftDataSet1.InformationID(ComRow).AvgSubs = Avgx2
                    Me.AuksoftDataSet1.InformationID(ComRow).FailSubs = FailNum2
                    Me.AuksoftDataSet1.InformationID(ComRow).AbsentSubs = Abs2
                    Me.AuksoftDataSet1.InformationID(ComRow).LastTermExam = TR
                    'Me.AuksoftDataSet1.InformationID(ComRow).Result = "Pass"

                End If


                AukF.InsPro(Me.ProgressBar1, Val(perpix))
                'Me.PerCent.Text = Me.ProgressBar1.Value
            End If

        Next
        'Me.GroupBox1.Visible = False
        Me.ProgressBar1.Value = 0
        Me.ProSub.Value = 0

        If AukF.MsgTr(What & " Saved...?") = True Then
            Saved()

        End If


        'Catch ex As Exception
        '    Me.ProgressBar1.Value = 0
        '    Me.ProSub.Value = 0
        '    Epx()
        '    If AukF.MsgTr("Do you want to Exit From Function[(someProb) Contact With Developer...]?") = True Then
        '        'Me.GroupBox1.Visible = False
        '        Exit Sub
        '    Else
        '        'Me.GroupBox1.Visible = False
        '    End If


        'Finally
        '    Beep()

        'End Try

    End Sub
    Private Sub summarydo(ByVal pos As Integer)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ContextMenuStrip2.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Opener()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If T3rd = False Then
            Try
                Me.DataGridView1.DataSource = Me.Acc2ConvertBindingSource

            Catch ex As Exception
                Epx()

            End Try
            If Acc2ConvertBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "4", "", "0,1,2,3", "")
            Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip4

        Else
            Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip4
            Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip4

            Me.DataGridView1.DataSource = Me.Acc2ConvertBindingSource
            If Acc2ConvertBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "4", "", "0,1,2,3", "")
            Me.DataGridView2.DataSource = Me.Acc2ConvertBindingSource1

            If Me.Acc2ConvertBindingSource1.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView2, "", "", "4", "", "0,1,2,3", "")
            Me.SUbjView.DataSource = Me.SubjectiveBindingSource
            Me.ObjView.DataSource = Me.ObjectiveBindingSource
            If Me.SubjectiveBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.SUbjView, "", "", "4", "", "0,1,2,3", "")
            If Me.ObjectiveBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.ObjView, "", "", "4", "", "0,1,2,3", "")

        End If

        If Me.CheckBox1.Checked = True Then Me.DataGridView3.DataSource = Me.GradingBindingSource
        If Me.GradingBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView3, "", "", "4", "", "0,1,2,3", "")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim TotalNum, TotalNum2, Avgx, Avgx2, SubPass, ObjPass, SubNum, ObjNum As Double
        Dim Max, Min, Max2, Min2 As Double
        Dim SubFail As Boolean
        Dim Pass As Double = 0
        'MsgBox(Pass)
        Dim APlus As Double = 0
        If Me.AuksoftDataSet1.MarksObtaint.Rows.Count > 0 Then
            Pass = Me.AuksoftDataSet1.MarksObtaint(0).Item("Passmarks").ToString
            APlus = Me.AuksoftDataSet1.MarksObtaint(0).Item(5).ToString
        End If

        Dim Abs, FailNum, Abs2, FailNum2, Qi, Qi2, CountA, CountA2, PosXP As Integer
        Dim FailSub, FailSub2, SubT, Num, Xn, Zn As String
        Dim SubColNext, Aq As Integer
        Dim CSil, Col, ColN As String
        Me.DataGridView1.DataSource = ""
        Me.DataGridView2.DataSource = ""

        'If Senior = False Then
        If Jonior1 = True Then
            CSil = 10
        ElseIf Nine = True Then
            CSil = 11
        ElseIf Senior = True Then
            If TR.ToLower = "test" Then
                CSil = 12
            Else
                CSil = 6

            End If
            'CSil = Val(Me.SubjNm.Text)
            'If Senior = True Then
            '    If CSil = 12 Then
            '        SFC("class", "Sections", "LinkText")
            '        STC(Clx, GTxt, 12)
            '        GSql.Sql_ORD_like_false("*", "Acc2Subject", "", Me.AuksoftDataSet1)
            '    ElseIf CSil = 6 Then
            '        SFC("class", "Sections", "Linktext")
            '        STC(Clx, GTxt, 6)
            '        GSql.Sql_ORD_like_false("*", "acc2subject", "", Me.AuksoftDataSet1)
            '    Else
            '        MsgBox("Only Accepted 6 Subject or 12 Subject....Check your self...", MsgBoxStyle.Critical)
            '        Me.SubjNm.Focus()

            '        Exit Sub

            '    End If

            'Else

            '    CSil = Val(Me.SubjNm.Text)
            '    If CSil = 0 Then
            '        MsgBox("Please Type Subject for Get Subjects Pass,Fail etc...(If Type 6... then Sub1,Sub2,Sub3...Sub5)", MsgBoxStyle.Critical)
            '        Me.SubjNm.Focus()
            '        Exit Sub
            '    End If
            'End If

        Else
            CSil = 11
        End If

        Me.ProgressBar1.Value = 0
        colpix = Val(100 / Me.Acc2ConvertBindingSource.Count)
        Me.ProSub.Value = 0
        perpix = Val(100 / CSil)
        For I = 5 To ((CSil - 1) + 5)
            TotalNum = 0
            Avgx = 0
            Abs = 0
            FailNum = 0
            FailSub = ""
            TotalNum2 = 0
            Avgx2 = 0
            Abs2 = 0
            FailNum2 = 0
            FailSub2 = ""
            CountA = 0
            CountA2 = 0
            Max = 0
            Min = 999 ^ 98
            Max2 = 0
            Min2 = 999 ^ 98
            Qi = (I - 5)

            If Nine = True Or Senior = True Then


                If Me.AuksoftDataSet1.Acc2Subject.Rows.Count > 0 Then
                    SubT = Me.AuksoftDataSet1.Acc2Subject(0).Item(Qi + 2).ToString
                End If
            Else
                SubT = Me.AuksoftDataSet1.Acc2SubLst(Qi).Lst.ToString

            End If


            SummaryID = Clx & Sec & TR & Shv & Yr & SubT
            For SubColNext = 0 To Me.Acc2ConvertBindingSource.Count - 1
                'If Senior = True Then
                '    Col = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToUpper
                '    Zn = Me.SubjectOfStudentsBindingSource.Find("Collegeno", Col)
                '    If Zn > -1 Then
                '        SubT = Me.AuksoftDataSet1.SubjectOfStudents(Zn).Item(Qi + 4).ToString
                '    Else
                '        SubT = ""
                '    End If

                'End If
                If T3rd = False Or (Senior = True Or Nine = True) Then
                    Num = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Item(I).ToString
                    If Senior = True Or Nine = True Then
                        'true
                        GIn(Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString)
                        'MsgBox(Num, , SubColNext & "," & I & "," & Pass)

                        Aq = I + 1
                        SubjPass = Val(Me.AuksoftDataSet1.PassMarks(SubPassPos).Item(Aq).ToString)
                        ObjPass = Val(Me.AuksoftDataSet1.PassMarks(ObjPassPos).Item(Aq).ToString)
                        c = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString
                        'MsgBox(c)
                        Qi2 = I - 1

                        If ObjPos > -1 Then ObjNum = Val(Me.AuksoftDataSet1.Objective(ObjPos).Item(Qi2).ToString) Else ObjNum = 0
                        If SubjPos > -1 Then SubjNum = Val(Me.AuksoftDataSet1.Subjective(ObjPos).Item(Qi2).ToString) Else SubjNum = 0
                        If (Val(ObjNum) < Val(ObjPass)) Or (Val(SubjNum) < Val(SubjPass)) Then
                            SubFail = True
                        Else
                            SubFail = False
                        End If
                        If Num = "A" Or Num = "CA" Then
                            Abs = Abs + 1
                        ElseIf Val(Num) < Val(Pass) Then
                            xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                            'MsgBox(xow)
                            FailNum = FailNum + 1
                            If FailSub = "" Then
                                FailSub = xow
                            Else
                                FailSub = FailSub & "," & xow
                            End If
                        ElseIf Val(Num) >= Val(Pass) Then
                            'xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                            If SubFail = True Then
                                xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                                'MsgBox(xow)
                                FailNum = FailNum + 1
                                If FailSub = "" Then
                                    FailSub = xow
                                Else
                                    FailSub = FailSub & "," & xow
                                End If
                            Else
                                If Val(Num) >= Val(APlus) Then
                                    CountA = CountA + 1
                                End If

                            End If
                            'when a+ then +1

                        End If
                        Avgx = Avgx + Val(Num)
                        If Val(Max) < Val(Num) Then
                            Max = Val(Num)
                        End If
                        If Num = "CA" Or Num = "A" Or Num = "P" Then 'Replace Min -3
                            'MsgBox("getTok")
                        Else
                            If Val(Min) > Val(Num) Then
                                Min = Val(Num)
                            End If

                        End If
                       
                        If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                            Me.ProSub.Value = 0
                            'MsgBox("done")
                        End If



                        Else

                            'MsgBox(Num, , SubColNext & "," & I & "," & Pass)
                            If Num = "A" Or Num = "P" Then
                                Abs = Abs + 1
                            ElseIf Val(Num) < Val(Pass) Then
                                xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                                'MsgBox(xow)
                                FailNum = FailNum + 1
                                If FailSub = "" Then
                                    FailSub = xow
                                Else
                                    FailSub = FailSub & "," & xow
                                End If
                            ElseIf Val(Num) >= Val(APlus) Then
                                'xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                                CountA = CountA + 1

                            End If
                            Avgx = Avgx + Val(Num)
                            If Val(Max) < Val(Num) Then
                                Max = Val(Num)
                        End If
                        'If MsgBox("num" & Num & "min" & Min, MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                        If Num = "CA" Or Num = "A" Or Num = "P" Then
                            'MsgBox("getTok")
                        Else
                            If Val(Min) > Val(Num) Then
                                Min = Val(Num)
                            End If

                        End If
                        If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                            Me.ProSub.Value = 0
                            'MsgBox("done")
                        End If
                    End If
                    Me.ProSub.Value = ProSub.Value + Val(colpix)
                Else
                    Num = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Item(I).ToString
                    'MsgBox(Num, , SubColNext & "," & I & "," & Pass)
                    ColN = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString
                    If Num = "A" Or Num = "P" Then
                        Abs = Abs + 1
                    ElseIf Val(Num) < Val(Pass) Then
                        xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                        'MsgBox(xow)
                        FailNum = FailNum + 1
                        If FailSub = "" Then
                            FailSub = xow
                        Else
                            FailSub = FailSub & "," & xow
                        End If
                    ElseIf Val(Num) >= Val(APlus) Then
                        'xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                        CountA = CountA + 1
                    End If
                    Avgx = Avgx + Val(Num)
                    If Val(Max) < Val(Num) Then
                        Max = Val(Num)
                    End If
                    If Num = "CA" Or Num = "A" Or Num = "P" Then 'Replace Min -2
                        'MsgBox("getTok")
                    Else
                        If Val(Min) > Val(Num) Then
                            Min = Val(Num)
                        End If

                    End If

                    '----2nd
                    Aq = Me.Acc2ConvertBindingSource1.Find("collegeno", ColN)
                    If Aq > -1 Then
                        Num2 = Me.AuksoftDataSet2.Acc2Convert(Aq).Item(I).ToString
                        'MsgBox(Num, , SubColNext & "," & I & "," & Pass)
                        If Num2 = "A" Or Num2 = "P" Then
                            Abs2 = Abs2 + 1
                        ElseIf Val(Num2) < Val(Pass) Then
                            xow = Me.AuksoftDataSet2.Acc2Convert(Aq).Collegeno.ToString & "(" & Val(Num) & ")"
                            'MsgBox(xow)
                            FailNum2 = FailNum2 + 1
                            If FailSub2 = "" Then
                                FailSub2 = xow
                            Else
                                FailSub2 = FailSub2 & "," & xow
                            End If
                        ElseIf Val(Num2) >= Val(APlus) Then
                            'xow = Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString & "(" & Val(Num) & ")"
                            CountA2 = CountA2 + 1
                        End If

                        Avgx2 = Avgx2 + Val(Num2)
                        If Val(Max2) < Val(Num2) Then
                            Max2 = Val(Num2)
                        End If
                        If Num2 = "CA" Or Num2 = "A" Or Num2 = "P" Then 'Replace Min2 -1
                            'MsgBox("getTok")
                        Else
                            If Val(Min2) > Val(Num2) Then
                                Min2 = Val(Num2)
                            End If

                        End If

                       
                        If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                            Me.ProSub.Value = 0
                            'MsgBox("done")
                        End If
                        Me.ProSub.Value = ProSub.Value + Val(colpix)

                End If


                End If

            Next
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource1.EndEdit()
            cv = Me.Acc2ConvertBindingSource.Count
            cv2 = Me.Acc2ConvertBindingSource1.Count

            re = Me.Acc2ConvertBindingSource.Count.ToString
            If Val(re) < Val(cv) Then
                MsgBox("There are some Problem in Total Record and Class Students ,Extra Students Information : " & (cv - re), MsgBoxStyle.Information)
            End If
            If T3rd = False Or Senior = True Or Nine = True Then
                If cv <> 0 Then
                    'present = re - Abs
                    'PassX = cv - FailNum
                    present = re
                    PassX = cv - FailNum - Abs
                    PercentPass = (100 * Val(PassX)) / cv
                    Avgx = Avgx / cv
                    Avgx = Format(Avgx, "0.##")
                    'MsgBox(Avgx, , "Made")
                    'ey = Me.AuksoftDataSet1.Acc2Convert.Compute("avg(Convert(Sub1,'System.double'))", "")
                    'MsgBox(ey)
                    PercentPass = Format(PercentPass, "0.##")
                End If

            Else
                'q = re - cv
                't = Abs + q
                If cv <> 0 And cv2 <> 0 Then
                    'present = re - Abs
                    'PassX = cv - FailNum
                    present = re
                    PassX = cv - FailNum - Abs
                    PercentPass = (100 * Val(PassX)) / cv
                    Avgx = Avgx / cv
                    Avgx = Format(Avgx, "0.##")
                    'MsgBox(Avgx, , "Made")
                    'ey = Me.AuksoftDataSet1.Acc2Convert.Compute("avg(Convert(Sub1,'System.double'))", "")
                    'MsgBox(ey)
                    PercentPass = Format(PercentPass, "0.##")
                    'q = re - cv2
                    't = Abs2 + q

                    'present = re - Abs2
                    'PassX = cv2 - FailNum2
                    present = cv2
                    PassX = cv2 - FailNum2 - Abs2
                    PercentPass2 = (100 * Val(PassX)) / cv2
                    Avgx2 = Avgx2 / cv2
                    Avgx2 = Format(Avgx2, "0.##")
                    'MsgBox(Avgx, , "Made")
                    'ey = Me.AuksoftDataSet1.Acc2Convert.Compute("avg(Convert(Sub1,'System.double'))", "")
                    'MsgBox(ey)
                    PercentPass2 = Format(PercentPass2, "0.##")
                End If
            
            End If


            PosXP = Me.SummaryMainBindingSource.Find("Subject", SubT)
            If PosXP = -1 Then
                Me.SummaryMainBindingSource.AddNew()
                Me.SummaryMainBindingSource.EndEdit()
                PosXP = Me.SummaryMainBindingSource.Position
                Me.AuksoftDataSet1.SummaryMain(PosXP).MainID = SummaryID
                Me.AuksoftDataSet1.SummaryMain(PosXP).SubID = SubID
                Me.AuksoftDataSet1.SummaryMain(PosXP).Subject = SubT
                Me.AuksoftDataSet1.SummaryMain(PosXP)._A_ = CountA
                Me.AuksoftDataSet1.SummaryMain(PosXP).HighestMarks = Max
                Me.AuksoftDataSet1.SummaryMain(PosXP).F = FailNum
                Me.AuksoftDataSet1.SummaryMain(PosXP).FailedStudents = FailSub
                Me.AuksoftDataSet1.SummaryMain(PosXP).Lowest_Marks = Min
                Me.AuksoftDataSet1.SummaryMain(PosXP).Absent = Abs
                Me.AuksoftDataSet1.SummaryMain(PosXP).Present = Me.Acc2ConvertBindingSource.Count.ToString - Abs
                Me.AuksoftDataSet1.SummaryMain(PosXP).Avarage = Avgx
                Me.AuksoftDataSet1.SummaryMain(PosXP).Prentice_Of_Pass = PercentPass
                Me.AuksoftDataSet1.SummaryMain(PosXP).TotalStudents = Me.Acc2ConvertBindingSource.Count.ToString
            Else

                Me.AuksoftDataSet1.SummaryMain(PosXP).MainID = SummaryID
                Me.AuksoftDataSet1.SummaryMain(PosXP).SubID = SubID
                Me.AuksoftDataSet1.SummaryMain(PosXP).Subject = SubT
                Me.AuksoftDataSet1.SummaryMain(PosXP)._A_ = CountA
                Me.AuksoftDataSet1.SummaryMain(PosXP).HighestMarks = Max
                Me.AuksoftDataSet1.SummaryMain(PosXP).F = FailNum
                Me.AuksoftDataSet1.SummaryMain(PosXP).FailedStudents = FailSub
                Me.AuksoftDataSet1.SummaryMain(PosXP).Lowest_Marks = Min
                Me.AuksoftDataSet1.SummaryMain(PosXP).Absent = Abs
                Me.AuksoftDataSet1.SummaryMain(PosXP).Present = Me.InformationIDBindingSource.Count.ToString - Abs
                Me.AuksoftDataSet1.SummaryMain(PosXP).Avarage = Avgx
                Me.AuksoftDataSet1.SummaryMain(PosXP).Prentice_Of_Pass = PercentPass
                Me.AuksoftDataSet1.SummaryMain(PosXP).TotalStudents = Me.InformationIDBindingSource.Count.ToString
            End If
            'SubColNext = 0
            If T3rd = True And (Senior = False And Nine = False) Then
                'SummaryID = Clx & Sec & TR & Shv & Yr & SubT & "(Convert)"
                PosXP = Me.SummaryMainBindingSource1.Find("Subject", SubT & "(Convert)")
                'MsgBox(PosXP)

                If PosXP = -1 Then
                    Me.SummaryMainBindingSource1.AddNew()
                    Me.SummaryMainBindingSource1.EndEdit()
                    PosXP = Me.SummaryMainBindingSource1.Position
                    Me.AuksoftDataSet2.SummaryMain(PosXP).MainID = SummaryID & "Convert"
                    Me.AuksoftDataSet2.SummaryMain(PosXP).SubID = SubID & "Convert"
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Subject = SubT & "(Convert)"
                    Me.AuksoftDataSet2.SummaryMain(PosXP)._A_ = CountA2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).HighestMarks = Max2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).F = FailNum2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).FailedStudents = FailSub2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Lowest_Marks = Min2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Absent = Abs2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Present = cv2 - Abs2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Avarage = Avgx2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Prentice_Of_Pass = PercentPass2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).TotalStudents = cv2
                Else
                    Me.AuksoftDataSet2.SummaryMain(PosXP).MainID = SummaryID & "Convert"
                    Me.AuksoftDataSet2.SummaryMain(PosXP).SubID = SubID & "Convert"
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Subject = SubT & "(Convert)"
                    Me.AuksoftDataSet2.SummaryMain(PosXP)._A_ = CountA2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).HighestMarks = Max2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).F = FailNum2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).FailedStudents = FailSub2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Lowest_Marks = Min2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Absent = Abs2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Present = cv2 - Abs2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Avarage = Avgx2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).Prentice_Of_Pass = PercentPass2
                    Me.AuksoftDataSet2.SummaryMain(PosXP).TotalStudents = cv2
                End If
            End If


            AukF.InsPro(Me.ProgressBar1, Val(perpix))

            'Me.PerCent.Text = Me.ProgressBar1.Value

            'Me.GroupBox1.Visible = False

        Next
        Me.ProgressBar1.Value = 0
        Me.ProSub.Value = 0

        If AukF.MsgTr(What & " Saved...?") = True Then
            Saved()

        End If
        'End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If T3rd = False Or Senior = True Or Nine = True Then
            Me.DataGridView1.DataSource = Me.SummaryMainBindingSource
            If Me.SummaryMainBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "4", "", "0,1,2,3", "")
        Else
            Me.DataGridView1.DataSource = Me.SummaryMainBindingSource
            If Me.SummaryMainBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "4", "", "0,1,2,3", "")

            Me.DataGridView2.DataSource = Me.SummaryMainBindingSource1
            If Me.SummaryMainBindingSource1.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView2, "", "", "4", "", "0,1,2,3", "")

        End If



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Me.Label2.ForeColor = Color * 12




    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Saved()
        Me.ContextMenuStrip3.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim CountA, CountA2, Abs, Qi, Qi2, Qi3, Csil, Avg, Avg2, Abs2, FailNum, FailNum2, FailIN As Integer
        Dim FailSub, FailSub2, SubT, Failtxt, AOpt, AbSub, AbSub2, AvgSub, Num, AvgSub2, ASub, ASub2, ColN As String
        Dim Pass As Double = Me.AuksoftDataSet1.MarksObtaint(0).Item("Passmarks").ToString
        Dim APlus As Double = Me.AuksoftDataSet1.MarksObtaint(0).Item(5).ToString
        Dim Max, Min, Max2, Min2, ObjPass, SubjPass, ObjNum, SubjNum As Double
        Me.DataGridView1.DataSource = ""
        Me.DataGridView2.DataSource = ""
        Me.ProgressBar1.Value = 0
        perpix = Val(100 / Me.InformationIDBindingSource.Count)
        Me.GroupBox1.Visible = True
        Me.ProSub.Value = 0
        Dim Aq2 As Integer
        Dim SubFail As Boolean

        'If Senior = False Then
        If Jonior1 = True Then
            Csil = 10
        ElseIf Nine = True Then
            Csil = 11
        ElseIf Senior = True Then
            If TR.ToLower = "test" Then
                Csil = 12
            Else
                Csil = 6

            End If
            'Csil = Val(Me.SubjNm.Text)
            'If Senior = True Then
            '    If Csil = 12 Then
            '        SFC("class", "Sections", "LinkText")
            '        STC(Clx, GTxt, 12)
            '        GSql.Sql_ORD_like_false("*", "Acc2Subject", "", Me.AuksoftDataSet1)
            '    ElseIf Csil = 6 Then
            '        SFC("class", "Sections", "Linktext")
            '        STC(Clx, GTxt, 6)
            '        GSql.Sql_ORD_like_false("*", "acc2subject", "", Me.AuksoftDataSet1)
            '    Else
            '        MsgBox("Only Accepted 6 Subject or 12 Subject....Check your self...", MsgBoxStyle.Critical)
            '        Me.SubjNm.Focus()

            '        Exit Sub

            '    End If

            'Else

            '    Csil = Val(Me.SubjNm.Text)
            '    If Csil = 0 Then
            '        MsgBox("Please Type Subject for Get Subjects Pass,Fail etc...(If Type 6... then Sub1,Sub2,Sub3...Sub5)", MsgBoxStyle.Critical)
            '        Me.SubjNm.Focus()
            '        Exit Sub
            '    End If
            'End If

        Else
            Csil = 11
        End If

        colpix = Val(100 / Csil)
        'If Senior = False Then
        For I = 0 To Me.Acc2ConvertBindingSource.Count - 1
            Abs = 0
            CountA = 0
            CountA2 = 0
            Abs2 = 0
            Avg = 0
            Avg2 = 0
            Max = 0
            Min = 999 ^ 98
            Max2 = 0
            Min2 = 999 ^ 98
            FailNum = 0
            FailNum2 = 0
            FailSub = ""
            FailSub2 = ""
            ASub = ""
            ASub2 = ""
            AvgSub = ""
            AvgSub2 = ""

            For Qi = 5 To (Csil - 1) + 5
                If T3rd = False Or (Senior = True Or Nine = True) Then
                    Qi2 = Qi - 5
                    If Senior = True Or Nine = True Then
                        SubT = Me.AuksoftDataSet1.Acc2Subject(0).Item(Qi2 + 2).ToString

                    Else
                        SubT = Me.AuksoftDataSet1.Acc2SubLst(Qi2).Lst.ToString
                    End If

                    Num = Me.AuksoftDataSet1.Acc2Convert(I).Item(Qi).ToString
                    'MsgBox(Num)

                    GIn(Me.AuksoftDataSet1.Acc2Convert(SubColNext).Collegeno.ToString)
                    'MsgBox(Num, , SubColNext & "," & I & "," & Pass)

                    Aq = Qi + 1
                    SubjPass = Val(Me.AuksoftDataSet1.PassMarks(SubPassPos).Item(Aq).ToString)
                    ObjPass = Val(Me.AuksoftDataSet1.PassMarks(ObjPassPos).Item(Aq).ToString)
                    c = Me.AuksoftDataSet1.Acc2Convert(AcNPos).Item(Qi).ToString
                    'MsgBox(c)
                    Qi2 = Qi - 1
                    Try
                        If ObjPos > -1 Then ObjNum = Val(Me.AuksoftDataSet1.Objective(ObjPos).Item(Qi2).ToString) Else ObjNum = 0

                    Catch ex As Exception
                        ObjNum = 0

                    End Try
                    Try
                        If SubjPos > -1 Then SubjNum = Val(Me.AuksoftDataSet1.Subjective(ObjPos).Item(Qi2).ToString) Else SubjNum = 0

                    Catch ex As Exception
                        SubjNum = 0

                    End Try
                    If (Val(ObjNum) < Val(ObjPass)) Or (Val(SubjNum) < Val(SubjPass)) Then
                        SubFail = True
                    Else
                        SubFail = False
                    End If

                    'nine senior
                    If Senior = True Or Nine = True Then

                        If Num = "A" Then
                            Abs = Abs + 1
                            Sux = SubT & " (" & (Num) & ")"
                            If AbSub = "" Then
                                AbSub = sux
                            Else
                                AbSub = AbSub & "," & sux
                            End If
                        ElseIf Num = "CA" Then
                            Avg = Avg + 1
                            Sux = SubT & " (" & (Num) & ")"
                            If AvgSub = "" Then
                                AvgSub = sux
                            Else
                                AvgSub = AvgSub & "," & sux
                            End If
                        ElseIf Val(Num) >= Val(Pass) Then
                            If SubFail = True Then
                                FailNum = FailNum + 1
                                Sux = SubT & " (" & Val(Num) & ")"
                                If FailSub = "" Then
                                    FailSub = sux
                                Else
                                    FailSub = FailSub & "," & sux
                                End If
                            Else
                                If Val(Num) >= Val(APlus) Then
                                    CountA = CountA + 1
                                    Sux = SubT & " (Sub:(" & Val(SubjNum) & ")Obj:(" & Val(ObjNum) & ")" & ")"
                                    If ASub = "" Then
                                        ASub = sux
                                    Else
                                        ASub = ASub & "," & sux
                                    End If '
                                End If

                            End If
                          
                        ElseIf Val(Num) < Val(Pass) Then
                            FailNum = FailNum + 1
                            Sux = SubT & " (" & Val(Num) & ")"
                            If FailSub = "" Then
                                FailSub = sux
                            Else
                                FailSub = FailSub & "," & sux
                            End If
                        End If


                    Else
                        'others 2nd term and 3rd term
                        If Num = "A" Then
                            Abs = Abs + 1
                            Sux = SubT & " (" & (Num) & ")"
                            If AbSub = "" Then
                                AbSub = sux
                            Else
                                AbSub = AbSub & "," & sux
                            End If
                        ElseIf Num = "P" Then
                            Avg = Avg + 1
                            Sux = SubT & " (" & (Num) & ")"
                            If AvgSub = "" Then
                                AvgSub = sux
                            Else
                                AvgSub = AvgSub & "," & sux
                            End If
                        ElseIf Val(Num) >= Val(APlus) Then
                            CountA = CountA + 1
                            Sux = SubT & " (" & Val(Num) & ")"
                            If ASub = "" Then
                                ASub = sux
                            Else
                                ASub = ASub & "," & sux
                            End If
                        ElseIf Val(Num) < Val(Pass) Then
                            FailNum = FailNum + 1
                            Sux = SubT & " (" & Val(Num) & ")"
                            If FailSub = "" Then
                                FailSub = sux
                            Else
                                FailSub = FailSub & "," & sux
                            End If
                        End If
                    End If
                Else

                    '--- satrt2
                    Qi2 = Qi - 5
                    SubT = Me.AuksoftDataSet1.Acc2SubLst(Qi2).Lst.ToString
                    Num = Me.AuksoftDataSet1.Acc2Convert(I).Item(Qi).ToString
                    ColN = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString

                    If Num = "A" Then
                        Abs = Abs + 1
                        Sux = SubT & " (" & (Num) & ")"
                        If AbSub = "" Then
                            AbSub = sux
                        Else
                            AbSub = AbSub & "," & sux
                        End If
                    ElseIf Num = "P" Then
                        Avg = Avg + 1
                        Sux = SubT & " (" & (Num) & ")"
                        If AvgSub = "" Then
                            AvgSub = sux
                        Else
                            AvgSub = AvgSub & "," & sux
                        End If
                    ElseIf Val(Num) >= Val(APlus) Then
                        CountA = CountA + 1
                        Sux = SubT & " (" & Val(Num) & ")"
                        If ASub = "" Then
                            ASub = sux
                        Else
                            ASub = ASub & "," & sux
                        End If
                    ElseIf Val(Num) < Val(Pass) Then
                        FailNum = FailNum + 1
                        Sux = SubT & " (" & Val(Num) & ")"
                        If FailSub = "" Then
                            FailSub = sux
                        Else
                            FailSub = FailSub & "," & sux
                        End If
                    End If

                    'Convert Start
                    'Qi2 = Qi - 5
                    'SubT = Me.AuksoftDataSet1.Acc2SubLst(Qi2).Lst.ToString
                    Aq2 = Me.Acc2ConvertBindingSource1.Find("Collegeno", ColN)
                    If Aq2 > -1 Then
                        Num = Me.AuksoftDataSet2.Acc2Convert(Aq2).Item(Qi).ToString
                        If Num = "A" Then
                            Abs2 = Abs2 + 1
                            Sux = SubT & " (" & (Num) & ")"
                            If AbSub2 = "" Then
                                AbSub2 = sux
                            Else
                                AbSub2 = AbSub2 & "," & sux
                            End If
                        ElseIf Num = "P" Then
                            Avg2 = Avg2 + 1
                            Sux = SubT & " (" & (Num) & ")"
                            If AvgSub2 = "" Then
                                AvgSub2 = sux
                            Else
                                AvgSub2 = AvgSub2 & "," & sux
                            End If
                        ElseIf Val(Num) >= Val(APlus) Then
                            CountA2 = CountA2 + 1
                            Sux = SubT & " (" & Val(Num) & ")"
                            If ASub2 = "" Then
                                ASub2 = sux
                            Else
                                ASub2 = ASub2 & "," & sux
                            End If
                        ElseIf Val(Num) < Val(Pass) Then
                            FailNum2 = FailNum2 + 1
                            Sux = SubT & " (" & Val(Num) & ")"
                            If FailSub2 = "" Then
                                FailSub2 = sux
                            Else
                                FailSub2 = FailSub2 & "," & sux
                            End If
                        End If
                    End If



                End If
                'MsgBox(Num & "FN" & FailNum2 & "FSub" & FailSub2 & "Avg2" & Avg2)
                If (Me.ProSub.Value + Val(colpix)) >= Me.ProSub.Maximum Then
                    Me.ProSub.Value = 0
                End If
                Me.ProSub.Value = ProSub.Value + Val(colpix)
            Next

            col = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
            'MsgBox(col)

            MainID = Yr & Clx & Sec & Subx & TR & Shv & col
            If FailNum > 0 Then
                AOpt = "Failed"
                id = MainID & AOpt
                Qi3 = Me.SummaryReportBindingSource.Find("MainID", id)
                If Qi3 = -1 Then
                    Me.SummaryReportBindingSource.AddNew()
                    Me.SummaryReportBindingSource.EndEdit()
                    Qi3 = Me.SummaryReportBindingSource.Position
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = FailNum
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = FailSub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...Failed in " & FailNum & " Subjects... "
                Else
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = FailNum
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = FailSub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...Failed in " & FailNum & " Subjects... "
                    'Me.AuksoftDataSet1.SummaryReport(Qi3). = col
                End If
            End If

            If Abs > 0 Then
                AOpt = "Absent"
                id = MainID & AOpt
                Qi3 = Me.SummaryReportBindingSource.Find("MainID", id)
                If Qi3 = -1 Then
                    Me.SummaryReportBindingSource.AddNew()
                    Me.SummaryReportBindingSource.EndEdit()
                    Qi3 = Me.SummaryReportBindingSource.Position
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = Abs
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = AbSub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...Absent in " & Abs & " Subjects... "
                Else
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = Abs
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = AbSub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...Absent in " & Abs & " Subjects... "
                    'Me.AuksoftDataSet1.SummaryReport(Qi3). = col
                End If
            End If
            If Avg > 0 Then
                AOpt = "Average"
                id = MainID & AOpt
                Qi3 = Me.SummaryReportBindingSource.Find("MainID", id)
                If Qi3 = -1 Then
                    Me.SummaryReportBindingSource.AddNew()
                    Me.SummaryReportBindingSource.EndEdit()
                    Qi3 = Me.SummaryReportBindingSource.Position
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = Avg
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = AvgSub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...Average Subjects " & Avg & " ... "
                Else
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = Avg
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = AvgSub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...Average Subjects " & Avg & " ... "
                    'Me.AuksoftDataSet1.SummaryReport(Qi3). = col
                End If
            End If
            If CountA > 0 Then
                AOpt = "A+"
                id = MainID & AOpt
                Qi3 = Me.SummaryReportBindingSource.Find("MainID", id)
                If Qi3 = -1 Then
                    Me.SummaryReportBindingSource.AddNew()
                    Me.SummaryReportBindingSource.EndEdit()
                    Qi3 = Me.SummaryReportBindingSource.Position
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = CountA
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = ASub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...A+ Marks In " & CountA & " Subjects... "
                Else
                    Me.AuksoftDataSet1.SummaryReport(Qi3).MainID = id
                    Me.AuksoftDataSet1.SummaryReport(Qi3).SubID = SubID
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Collegeno = col
                    Me.AuksoftDataSet1.SummaryReport(Qi3)._Option = AOpt
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Number = CountA
                    Me.AuksoftDataSet1.SummaryReport(Qi3).Subjects = ASub
                    Me.AuksoftDataSet1.SummaryReport(Qi3).TypedChar = "...A+ Marks In " & CountA & " Subjects... "
                    'Me.AuksoftDataSet1.SummaryReport(Qi3). = col
                End If
            End If

            col = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
            MainID = Yr & Clx & Sec & Subx & TR & Shv & col & "(Convert)"
            If T3rd = True And (Senior = True Or Nine = True) Then
                'MsgBox(Num & "FN" & FailNum2 & "FSub" & FailSub2 & "Avg" & Avg2, , col)
                If FailNum2 > 0 Then
                    AOpt = "Failed"
                    id = MainID & AOpt
                    Qi3 = Me.SummaryReportBindingSource1.Find("MainID", id)
                    If Qi3 = -1 Then
                        Me.SummaryReportBindingSource1.AddNew()
                        Me.SummaryReportBindingSource1.EndEdit()
                        Qi3 = Me.SummaryReportBindingSource1.Position
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = FailNum2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = FailSub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...Failed in " & FailNum2 & " Subjects... "
                    Else
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = FailNum2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = FailSub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...Failed in " & FailNum2 & " Subjects... "
                        'Me.AuksoftDataSet2.SummaryReport(Qi3). = col
                    End If
                End If

                If Abs2 > 0 Then
                    AOpt = "Absent"
                    id = MainID & AOpt
                    Qi3 = Me.SummaryReportBindingSource1.Find("MainID", id)
                    If Qi3 = -1 Then
                        Me.SummaryReportBindingSource1.AddNew()
                        Me.SummaryReportBindingSource1.EndEdit()
                        Qi3 = Me.SummaryReportBindingSource1.Position
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = Abs2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = AbSub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...Absent in " & Abs2 & " Subjects... "
                    Else
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = Abs2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = AbSub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...Absent in " & Abs2 & " Subjects... "
                        'Me.AuksoftDataSet2.SummaryReport(Qi3). = col
                    End If
                End If
                If Avg2 > 0 Then
                    'MsgBox(Avg2 & AvgSub2, , col)
                    AOpt = "Average"
                    id = MainID & AOpt
                    Qi3 = Me.SummaryReportBindingSource1.Find("MainID", id)
                    If Qi3 = -1 Then
                        Me.SummaryReportBindingSource1.AddNew()
                        Me.SummaryReportBindingSource1.EndEdit()
                        Qi3 = Me.SummaryReportBindingSource1.Position
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = Avg2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = AvgSub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...Average Subjects " & Avg2 & " ... "
                    Else
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = Avg2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = AvgSub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...Average Subjects " & Avg2 & " ... "
                        'Me.AuksoftDataSet2.SummaryReport(Qi3). = col
                    End If
                End If
                If CountA2 > 0 Then
                    'MsgBox(CountA2 & ASub2, , col)
                    AOpt = "A+"
                    id = MainID & AOpt
                    Qi3 = Me.SummaryReportBindingSource1.Find("MainID", id)
                    If Qi3 = -1 Then
                        Me.SummaryReportBindingSource1.AddNew()
                        Me.SummaryReportBindingSource1.EndEdit()
                        Qi3 = Me.SummaryReportBindingSource1.Position
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = CountA2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = ASub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...A+ Marks In " & CountA2 & " Subjects... "
                    Else
                        Me.AuksoftDataSet2.SummaryReport(Qi3).MainID = id
                        Me.AuksoftDataSet2.SummaryReport(Qi3).SubID = SubID & "Convert"
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Collegeno = col
                        Me.AuksoftDataSet2.SummaryReport(Qi3)._Option = AOpt
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Number = CountA2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).Subjects = ASub2
                        Me.AuksoftDataSet2.SummaryReport(Qi3).TypedChar = "...A+ Marks In " & CountA2 & " Subjects... "
                        'Me.AuksoftDataSet2.SummaryReport(Qi3). = col
                    End If
                End If
            End If


            AukF.InsPro(Me.ProgressBar1, Val(perpix))
            'Me.PerCent.Text = Me.ProgressBar1.Value
        Next
        'End If
        'Me.GroupBox1.Visible = False
        Me.ProgressBar1.Value = 0
        Me.ProSub.Value = 0
        If AukF.MsgTr(What & " Saved...?") = True Then
            Saved()
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If T3rd = False Or Senior = True Or Nine = True Then
            Me.DataGridView1.DataSource = Me.SummaryReportBindingSource
            If Me.SummaryReportBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "3,4", "", "0,1,2", "")


            Me.DataGridView2.DataSource = ""
        Else
            Me.DataGridView1.DataSource = Me.SummaryReportBindingSource
            If Me.SummaryReportBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "3,4", "", "0,1,2", "")

            Me.DataGridView2.DataSource = Me.SummaryReportBindingSource1
            If Me.SummaryReportBindingSource1.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView2, "", "", "3,4", "", "0,1,2", "")

        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)
    End Sub

    Private Sub ExtraSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraSummaryToolStripMenuItem.Click
        Dim kp As New SummaryReportOnly
        'If Me.CheckBox6.Checked = True Then
        kp.ReportDefinition.Sections.Item(4).SectionFormat.EnableSuppress = AukF.BoolInvert(Me.CheckBox6.Checked)

        'End If
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp


    End Sub

    Private Sub ExtraSummaryShortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraSummaryShortToolStripMenuItem.Click
        'Dim kp As New Copy_of_SummaryReportOnly
        'kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        'ReportViewer.Show()
        'ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub DeleteAllBigSheetSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllBigSheetSummaryToolStripMenuItem.Click
        If T3rd = True Or Senior = True Or Nine = True Then
            AukF.DelRecAll("BigSheetSummary", Me.SummaryMainBindingSource)
            AukF.DelRecAll("BigSheetSummary(Convert)", Me.SummaryMainBindingSource1)
            Me.SummaryMainBindingSource.EndEdit()
            Me.SummaryMainBindingSource1.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2)
        Else
            AukF.DelRecAll("BigSheetSummary", Me.SummaryMainBindingSource)
            Me.SummaryMainBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1)
        End If
        Saved()
    End Sub

    Private Sub DeleteAllExtraSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllExtraSummaryToolStripMenuItem.Click
        If T3rd = True Or Senior = True Or Nine = True Then
            AukF.DelRecAll("ExtraSummary", Me.SummaryReportBindingSource)
            AukF.DelRecAll("ExtraSummary(Convert)", Me.SummaryReportBindingSource1)
            Me.SummaryReportBindingSource.EndEdit()
            Me.SummaryReportBindingSource1.EndEdit()
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet1)
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet2)
        Else
            AukF.DelRecAll("ExtraSummary", Me.SummaryReportBindingSource)
            Me.SummaryReportBindingSource.EndEdit()
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet1)
        End If
        Saved()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()
    End Sub

    Private Sub BigSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BigSheetToolStripMenuItem.Click
        Dim kp As New BigSheet2
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub RdTermBigSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdTermBigSheetToolStripMenuItem.Click
        Dim kp As New BigSheet2
        kp.Database.Tables("InformationID").SetDataSource(Me.AuksoftDataSet1)
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet2)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub ExtraSummrySheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraSummrySheetToolStripMenuItem.Click
        'Dim kp As New SummaryReportOnly
        'kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet2)
        'ReportViewer.Show()
        'ReportViewer.CrystalReportViewer1.ReportSource = kp
        Dim kp As New SummaryReportOnly
        'If Me.CheckBox6.Checked = True Then
        kp.ReportDefinition.Sections.Item(4).SectionFormat.EnableSuppress = AukF.BoolInvert(Me.CheckBox6.Checked)
        'End If
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet2)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        'Dim kp As New Copy_of_SummaryReportOnly
        'kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet2)
        'ReportViewer.Show()
        'ReportViewer.CrystalReportViewer1.ReportSource = kp
        Dim kp As New SummaryReportOnly
        'If Me.CheckBox6.Checked = True Then
        kp.ReportDefinition.Sections.Item(4).SectionFormat.EnableSuppress = AukF.BoolInvert(Me.CheckBox6.Checked)
        'End If
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet2)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim kp As New Copy_of_BigSheet2
        kp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = kp
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'If Me.CheckBox1.Checked = True Then
        '    Me.CheckBox1.Text = "(*Failed Position = 0 *)=True)"
        'Else
        '    Me.CheckBox1.Text = "(*Failed Position = 0 *)=False)"

        'End If
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        'If Me.CheckBox1.Checked = True Then
        '    Me.CheckBox1.Text = "(*Failed Position = 0 *)=True)"
        'Else
        '    Me.CheckBox1.Text = "(*Failed Position = 0 *)=False)"

        'End If
    End Sub

    Private Sub CheckBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Enter
        'If Me.CheckBox1.Checked = True Then
        '    Me.CheckBox1.Text = "(*Failed Position = 0 *)=True)"
        'Else
        '    Me.CheckBox1.Text = "(*Failed Position = 0 *)=False)"

        'End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.DataGridView1.DataSource = Me.HighestmarksBindingSource
        If HighestmarksBindingSource.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "3", "", "0,1,2", "")

        Me.DataGridView2.DataSource = Me.HighestmarksBindingSource1
        If HighestmarksBindingSource1.Count > 0 Then AukF2.AukOptionsOfDataGrid(Me.DataGridView2, "", "", "3", "", "0,1,2", "")


    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAllToolStripMenuItem.Click
        Saved()

    End Sub

    Private Sub ResultOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultOnlyToolStripMenuItem.Click
        Try
            Me.Acc2ConvertBindingSource1.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)
            Me.HighestmarksBindingSource.EndEdit()
            Me.HighestmarksBindingSource1.EndEdit()
            Me.HighestmarksTableAdapter.Update(Me.AuksoftDataSet1.Highestmarks)
            Me.HighestmarksTableAdapter.Update(Me.AuksoftDataSet2.Highestmarks)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub SummaryExtraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryExtraToolStripMenuItem.Click
        Try
            Me.SummaryReportBindingSource.EndEdit()
            Me.SummaryReportBindingSource1.EndEdit()
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet1.SummaryReport)
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet2.SummaryReport)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub SummaryBigSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryBigSheetToolStripMenuItem.Click
        Try
            Me.SummaryMainBindingSource.EndEdit()
            Me.SummaryMainBindingSource1.EndEdit()
            Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)
            Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet2.SummaryMain)
        Catch ex As Exception
            Epx()
        End Try
    End Sub

    Private Sub InformationEntryResultTotalMarkEtcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationEntryResultTotalMarkEtcToolStripMenuItem.Click
        Try
            Me.InformationIDBindingSource.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim qAq As Integer

        gn = Me.TextBox1.Text
        qAq = Me.Acc2ConvertBindingSource1.Find("collegeno", gn)
        If qAq > -1 Then
            Me.Acc2ConvertBindingSource1.Position = qAq
        End If
        qAq = Me.Acc2ConvertBindingSource.Find("collegeno", gn)
        If qAq > -1 Then
            Me.Acc2ConvertBindingSource.Position = qAq
        End If
        'qAq = Me..Find("collegeno", gn)
        'If qAq > -1 Then
        '    Me.Acc2ConvertBindingSource.Position = qAq
        'End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.AuksoftDataSet1.MarksObtaint.Rows.Count > 0 Then
            DrmcModule.A_plusSt = Me.AuksoftDataSet1.MarksObtaint(0).Item(5).ToString
            DrmcModule.A_St = Me.AuksoftDataSet1.MarksObtaint(0).Item(7).ToString
            DrmcModule.A_MinSt = Me.AuksoftDataSet1.MarksObtaint(0).Item(9).ToString
            DrmcModule.B_ST = Me.AuksoftDataSet1.MarksObtaint(0).Item(11).ToString
            DrmcModule.C_ST = Me.AuksoftDataSet1.MarksObtaint(0).Item(13).ToString
            DrmcModule.Fnum = Me.AuksoftDataSet1.MarksObtaint(0).Item(15).ToString
            'MsgBox(DrmcModule.A_plusSt)
            'MsgBox(DrmcModule.A_St)
            'MsgBox(DrmcModule.A_MinSt)
            'MsgBox(DrmcModule.B_ST)
            'MsgBox(DrmcModule.C_ST)
            'MsgBox(DrmcModule.Fnum)
        End If
        'MsgBox(AukF.NumAsGrdValue(Me.TextBox2.Text))
        'MsgBox(AukF.GradePointsToGrade(AukF.NumAsGrdValue(Me.TextBox2.Text)), , AukF.GradeToGradePoints(AukF.GradePointsToGrade(AukF.NumAsGrdValue(Me.TextBox2.Text))))
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Dim nu As Data.DataRow = Me.AuksoftDataSet1.MarksObtaint(0)
        Try
            Me.PassMarksBindingSource.EndEdit()
            Me.PassMarksTableAdapter.Update(Me.AuksoftDataSet1.PassMarks)
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

    Private Sub SaveObjectiveSubjectiveGradingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveObjectiveSubjectiveGradingToolStripMenuItem.Click
        Try
            Me.ObjectiveBindingSource.EndEdit()
            Me.SubjectiveBindingSource.EndEdit()
            Me.GradingBindingSource.EndEdit()
            Me.GradingTableAdapter.Update(Me.AuksoftDataSet1.Grading)
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1.Objective)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1.Subjective)
        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub Timer2_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs)

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Dim Xn As Integer
        Dim bndSr As New BindingSource
        Dim SD As DataSet
        'Dim T As DataTable
        On Error Resume Next
        If Me.CheckBox7.Checked = True Then
            bndSr = Me.SummaryMainBindingSource1
            SD = Me.AuksoftDataSet2

        Else
            bndSr = Me.SummaryMainBindingSource
            SD = Me.AuksoftDataSet1
        End If
        'AukF.DelRowsFromDatabase(3, 4, Me.AuksoftDataSet1.SummaryReport, "a", True)

        If AukF.MsgTr(What & "delete  .... Selected Items Field From ExtraSummary...?") = True Then
            cvg = Val(SD.Tables("SummaryReport").Rows.Count)
            rx = 100 / cvg

            Dim m As String

            For I = 0 To cvg - 1
                m = SD.Tables("SummaryReport").Rows(I).Item(3).ToString

                If m.ToLower = "failed" Then
                    If Me.CheckBox2.Checked = True Then
                        SD.Tables("SummaryReport").Rows(I).Delete()


                        'Exit For
                    End If
                End If
                If m.ToLower = "a+" Then
                    If Me.CheckBox3.Checked = True Then
                        SD.Tables("SummaryReport").Rows(I).Delete()
                        'Exit For
                    End If
                End If
                If m.ToLower = "absent" Then
                    If Me.CheckBox4.Checked = True Then
                        SD.Tables("SummaryReport").Rows(I).Delete()
                        'Exit For
                    End If
                End If
                If m.ToLower = "average" Then
                    If Me.CheckBox5.Checked = True Then
                        SD.Tables("SummaryReport").Rows(I).Delete()
                        'Exit For
                    End If
                End If
                AukF.InsPro(Me.ProgressBar1, rx)

            Next




        End If
        Me.ProgressBar1.Value = 0

        Me.SummaryReportBindingSource.EndEdit()
        If AukF.MsgTr("Do you want  to Save?...Without Save you can also print Informations what you don't want...") = True Then
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet1)
            Me.SummaryReportTableAdapter.Update(Me.AuksoftDataSet2)
        End If
     
        'Me.SummaryReportBindingSource1.RemoveFilter()
        'Me.SummaryReportBindingSource.RemoveFilter()
    End Sub

    Private Sub DeleteAllHightestMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllHightestMarksToolStripMenuItem.Click
        Try
            AukF2.DeleteWholeTableRecords(Me.HighestmarksBindingSource, True)
            AukF2.DeleteWholeTableRecords(Me.HighestmarksBindingSource1, True)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'If Me.DataGridView1.DataSource.DataSource = Me.Acc2ConvertBindingSource.DataSource Then
        '    Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip4
        'ElseIf Me.DataGridView1.DataSource.DataSource = Me.Acc2ConvertBindingSource.DataSource Then
        '    If Me.DataGridView1.ContextMenuStrip IsNot Nothing Then
        '        Me.DataGridView1.ContextMenuStrip = Nothing
        '    End If

        'End If
    End Sub

    Private Sub SelectedItemsVicePrincipalCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsVicePrincipalCommentsToolStripMenuItem.Click
        If Pgrid IsNot Nothing Then
            m = InputBox("Please Type VicePrincipal Comment to Set .... Selected Students Field....", "VP Comments", m)

            AukF2.Grid_View_SetCommonItems(Me.DataGridView1, m, 20, False, Me.ProgressBar1, False, True)

        End If
       
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.GotFocus
        Dim Bpq As BindingSource = Me.DataGridView1.DataSource
        If Bpq.DataMember = "Acc2Convert" Then
            Me.Pgrid = sender
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView2.GotFocus
        Dim Bpq As BindingSource = Me.DataGridView1.DataSource
        If Bpq.DataMember = "Acc2Convert" Then
            Me.Pgrid = sender
        End If
    End Sub

    Private Sub ContextMenuStrip4_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening

    End Sub

    Private Sub SelectedItemsPrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsPrincipalToolStripMenuItem.Click
        If Pgrid IsNot Nothing Then
            m = InputBox("Please Type Principal Comment to Set .... Selected Students Field....", "Principal Comments", m)

            AukF2.Grid_View_SetCommonItems(Me.DataGridView1, m, 21, False, Me.ProgressBar1, False, True)

        End If
    End Sub

    Private Sub SelectedItemsClassTeachersCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedItemsClassTeachersCommentsToolStripMenuItem.Click
        If Pgrid IsNot Nothing Then
            m = InputBox("Please Type Principal Comment to Set .... Selected Students Field....", "Principal Comments", m)

            AukF2.Grid_View_SetCommonItems(Me.DataGridView1, m, 19, False, Me.ProgressBar1, False, True)

        End If
    End Sub
End Class