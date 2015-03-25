Public Class PrintOption
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
    Dim SummaryID As String
    Dim MUp As Boolean
    'Dim Working As Boolean
    Dim QIp, Cnpd As Boolean
    Dim SubjectShow As String
    Dim TSubID As String
    Dim CnQua As String = "3rdTermConvert"
    Dim OpnWth, Bld2, Nine, Senior As Boolean
    Dim GrptxtTx As String
    Dim Ac1SecInt As Boolean
    Dim ClassOptNTab As New DataTable
    Private Sub NamedOFForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamedOFForm.Click


    End Sub

    Private Sub NamedOFForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NamedOFForm.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub PrintTopicBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintTopicBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PrintTopicBindingSource.EndEdit()
            Me.PrintTopicTableAdapter.Update(Me.AuksoftDataSet1.PrintTopic)


        Catch ex As Exception
            Epx()
        End Try
      

    End Sub

    Private Sub PrintOption_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        AukSoft.Close()

    End Sub

    Private Sub PrintOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Acc2Convert' table. You can move, or remove it, as needed.
        'Me.Acc2ConvertTableAdapter.Fill(Me.AuksoftDataSet1.Acc2Convert)
        Working = True
        GSql.Sql_Gr_LikeUse_False("*", "Classoptions", "", Me.AuksoftDataSet1)
        'Me.ClassOptNTab = Me.AuksoftDataSet1.ClassOptions

        Me.QueryTopicTableAdapter.Fill(Me.AuksoftDataSet1.QueryTopic)
        Me.TermSTableAdapter.Fill(Me.AuksoftDataSet1.TermS)
        'AukF.FullScreenSet(Me, True)
        AukF.XPAuk(Me)

        COnQua = "3rdTermConvert"
j:
        If Trim(Acc) = "" Then
            Acc = InputBox("type username....", "username", Acc)
        End If
        If Trim(Acc) = "" Then GoTo j

        SFC("UserName")
        STC(Acc)
        GSql.NonCls_ORD_NonLikeCommand("*", "PrintTopic", "", Me.AuksoftDataSet1)
        'MsgBox(Sql)
        Working = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Working = False Then
            ToolStripStatusLabel1.Text = Me.AuksoftDataSet1.Acc2Convert.Count + Me.AuksoftDataSet1.Science.Count + Me.AuksoftDataSet1.Commerce.Count + Me.AuksoftDataSet1.Human.Count + Me.AuksoftDataSet1.MedicalOfficerComments.Count + Me.AuksoftDataSet1.ClassTeacherComments.Count + Me.AuksoftDataSet1.GamesTeacherComments.Count + Me.AuksoftDataSet1.HousemasterComments.Count + Me.AuksoftDataSet1.InformationID.Count + Me.AuksoftDataSet1.DaysOFWorks.Count + Me.AuksoftDataSet1.MarksObtaint.Count

            WRec.Text = Me.AuksoftDataSet1.WholeRecordQuery.Rows.Count

        End If

      


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Public Function AcDicide()
        If (Val(Me.ClassTextBox.Text) >= 3) And (Val(Me.ClassTextBox.Text) <= 8) Then
            Ac1SecInt = False
        Else
            Ac1SecInt = True
        End If
    End Function
    Public Function AcDicide2()
        If (Val(Clx) >= 3) And (Val(Clx) <= 8) Then
            Ac1SecInt = False
        Else
            Ac1SecInt = True
        End If
    End Function
    Public Sub Decide()
        Yr = Me.YearTextBox.Text
        TR = Me.TermTextBox.Text
        Clx = Me.ClassTextBox.Text
        Shv = Me.ShiftTextBox.Text
        Secx = Me.SectionTextBox.Text

        If (Val(Me.ClassTextBox.Text) >= 3) And (Val(Me.ClassTextBox.Text) <= 8) Then
            Ac1SecInt = False
        Else
            Ac1SecInt = True

        End If
        If Clx = 9 Or Clx = 10 Then
            Nine = True
            Senior = False

            Ac1SecInt = True
        ElseIf Clx = 11 Or Clx = 12 Then
            Senior = True
            Nine = False
            Ac1SecInt = True
        Else
            Nine = False
            Senior = False
            Ac1SecInt = False
        End If
        'MsgBox(TR)
        'MsgBox(Ac1SecInt)


        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        QMainID = Clx & Secx & TR & Shv & Yr & Collegeno & COnQua

        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        SubjectShow = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "Shift(" & Shv & ")"
        bnw = Clx & "-" & Secx & Shv
        'GrptxtTx = AukF.DataSetFindTxT("ClassSection", bnw, Me.AuksoftDataSet1, "ClassOptions", 4)
        If TR = "FIRST TERM" Then
            Tms = 1
        ElseIf TR = "SECOND TERM" Then
            Tms = 2
        Else
            Tms = 3
            T3rd = True
        End If

        




    End Sub
    Public Sub QuerySt()
        If Me.PosChk.Checked = True And Me.CheckBox1.Checked = False Then
            SFC("", "", "Position")
            STC("", "", "")
            If IsNumeric(Me.PositionTextBox.Text) = True Then
                EPC("", "", "=" & Me.PositionTextBox.Text)

            Else
                EPC("", "", Me.PositionTextBox.Text)

            End If
        ElseIf Me.PosChk.Checked = True And Me.CheckBox1.Checked = True Then
            SFC("", "", "Position")
            STC("", "", Me.PositionTextBox.Text)
            INPC("", "", Me.PositionTextBox.Text)

        End If
        'MsgBox(Me.MarksTextBox.Text)
        If Me.MarksChk.Checked = True And Me.CheckBox2.Checked = False Then
            SFC("", "", "", "Totalmarks")
            'STC("", "", "", Me.MarksTextBox.Text)
            If IsNumeric(Me.MarksTextBox.Text) = True Then
                EPC("", "", "", "=" & Me.MarksTextBox.Text)

            Else
                EPC("", "", "", Me.MarksTextBox.Text)

            End If
        ElseIf Me.MarksChk.Checked = True And Me.CheckBox2.Checked = True Then
            SFC("", "", "", "Totalmarks")
            STC("", "", "", Me.MarksTextBox.Text)
            INPC("", "", "", Me.MarksTextBox.Text)
        End If
        If Me.ResChk.Checked = True Then
            If Me.ResultTextBox.Text = "Pass" Then
                SFC("", "", "", "", "Result")
                STC("", "", "", "", "Pass")
            Else
                SFC("", "", "", "", "Result")
                EPC("", "", "", "", "<>")
                STC("", "", "", "", "'Pass'")
            End If

            'EPC("", "", "", Me.MarksTextBox.Text)
        End If
    End Sub
    Private Sub TermCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TermCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.TermTextBox.Text = Me.TermCombo.Text

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

    End Sub

    Private Sub OpenSqlTextBoxTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSqlTextBoxTextToolStripMenuItem.Click
        If Me.SqlQueryView.Visible = True Then

        End If
    End Sub

    Private Sub ShowSqlTextRefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSqlTextRefreshToolStripMenuItem.Click

        If Me.ShowSqlTextRefreshToolStripMenuItem.Checked = True Then
            Me.SqlQueryView.Visible = True
        Else
            Me.SqlQueryView.Visible = False

        End If
    End Sub

    Private Sub OpenwithSqlTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenwithSqlTextToolStripMenuItem.Click
        If Me.SqlQueryView.Visible = True Then

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpnWth = False
        Cnpd = True

        Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)


    End Sub
    Public Function TotalStu()
        qx = Val(Me.ClassTextBox.Text)
        'gsql.ExpressionQueryTxt False ,"*","ClassOptions","",
        SFC("Class", "Shift", "Section", "ClassStudents")
        ExpreC("", "", "", "is not null")
        STC(qx, Me.ShiftTextBox.Text, Me.SectionTextBox.Text)
        AukF2.Db_Load("sum(val(ClassStudents))", Me.ClassOptNTab, "ClassOptions")
        ownclx = Me.ClassOptNTab.Rows(0).Item(0).ToString

        SFC("Class", "Shift", "ClassStudents")
        ExpreC("", "", "is not null")
        STC(qx, Me.ShiftTextBox.Text)
        AukF2.Db_Load("sum(val(ClassStudents))", Me.ClassOptNTab, "ClassOptions")
        total = Me.ClassOptNTab.Rows(0).Item(0).ToString

        'total = Me.AuksoftDataSet1.ClassOptions.Compute("sum(ClassStudents)", "class = '" &  & "' and shift='" & & "' and classstudents is not null")
        'ownclx = Me.AuksoftDataSet1.ClassOptions.Compute("sum(classstudents)", "class = '" & qx & "' and " & "section='" &  & "' and shift='" & Me.ShiftTextBox.Text & "' and classstudents is not null")
        If Val(ownclx) > 0 Then
            If Val(total) > 0 Then Me.TextBox1.Text = Val(total) & " of " & ownclx Else Me.TextBox1.Text = ownclx
        Else
            Me.TextBox1.Text = Me.AuksoftDataSet1.Acc2Convert.Count
        End If

    End Function
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        topic = InputBox("Please type your Print Topic to Save Details in it...", "SaveTopic", topic)
        If Trim(topic) = "" Then
            MsgBox("No Name of Topic... Entry Correctly...", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Me.PrintTopicBindingSource.AddNew()
        Me.PrintTopicBindingSource.EndEdit()
        Me.AuksoftDataSet1.PrintTopic(Me.PrintTopicBindingSource.Position).UserName = Acc
        Me.AuksoftDataSet1.PrintTopic(Me.PrintTopicBindingSource.Position).SavedTopic = topic

        'Me.AuksoftDataSet1.PrintTopic(Me.PrintTopicBindingSource.Position).
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AukSoft.Show()
        AukSoft.Activate()

    End Sub

    Private Sub Button13_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseHover
        MUp = True
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        MUp = False
        Me.Button13.Text = "...About Auk?"


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        '        Dim mo As Integer = 1
        'ws:
        '          mo = mo + 1
        '        If MUp = True Then
        '            tptext = "...AukSoftware's"

        '            If mo <= Len(tptext) Then

        '                Me.Button13.Text = Mid(tptext, 1, mo)
        '                GoTo ws
        '            End If

        '        Else
        '            mo = 1
        '            Me.Button13.Text = "...About Auk?"
        '        End If
        Rec00.Text = Me.AuksoftDataSet1.Acc2Convert.Rows.Count
        If Val(Rec00.Text) <= 0 Then
            Rec00.ForeColor = Color.Red
        Else
            Rec00.ForeColor = Color.Black
        End If

        If Me.AuksoftDataSet1.WholeRecordQuery.Rows.Count = 0 Then
            Me.Button24.Text = "....Print Students ...." & vbCrLf
            Me.Button24.Text += "....whole Record...."
            If Me.OpenWholeRecord.Checked = True Then
                'Me.Label13.Font.Bold = True
                Me.Label13.ForeColor = Color.Red
                'Me.WRec.Font.Bold = True
                Me.WRec.ForeColor = Color.Red
            End If


        Else
            Me.Button24.Text = "....Print Students ...." & vbCrLf
            Me.Button24.Text += "....whole Record...." & vbCrLf
            Me.Button24.Text += "Record:( " & Me.AuksoftDataSet1.WholeRecordQuery.Rows.Count & " )"
            If Me.OpenWholeRecord.Checked = True Then

                'Me.Label13.Font.Bold = False
                Me.Label13.ForeColor = Color.Black
                'Me.WRec.Font.Bold = False
                Me.WRec.ForeColor = Color.Black
            End If

        End If



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Me.PrintTopicBindingSource.EndEdit()
            Me.PrintTopicTableAdapter.Update(Me.AuksoftDataSet1.PrintTopic)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        PrintOption_Load(sender, e)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Me.TermTextBox.Text = Me.ComboBox2.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Me.ShiftTextBox.Text = Me.ComboBox1.Text

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.PrintTopicBindingSource.CancelEdit()
        Me.AuksoftDataSet1.PrintTopic.RejectChanges()

    End Sub

    Private Sub BigSheetOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BigSheetOpenToolStripMenuItem.Click
        Dim k As Integer


        Working = True
        Decide()
        QuerySt()
        'If Ac1SecInt = False Then
        '    'MsgBox(T3rd)
        '    If T3rd = True Then
        'COnQua = ""
        SFC("subid", "Convertquality")
        STC(SubID, "")
        GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
        'MsgBox(Sql)

        If Val(Me.ClassTextBox.Text) = 11 Or Val(Me.ClassTextBox.Text) = 12 Then
            SFC("subid")
            STC(SubjectShow)
            GSql.Sql_ORD_like_false("*", "subjectofstudents", "", Me.AuksoftDataSet1)
            'MsgBox(SubjectShow & Me.AuksoftDataSet1.SubjectOfStudents.Rows.Count)

        End If

        'End If
        OpenLiquid(False)
        OColNo()

        'End If
        TotalStu()


        Working = False
    End Sub
    Public Sub OColNo()
        Dim Spc As String = ""
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        rg = 1000 / Me.AuksoftDataSet1.Acc2Convert.Count
        Me.AuksoftDataSet1.InformationID.Clear()

        For k = 0 To Me.AuksoftDataSet1.Acc2Convert.Count - 1
            col = Me.AuksoftDataSet1.Acc2Convert(k).Collegeno.ToString
            th = Me.InformationBind.Find("Collegeno", col)
          
            If th = -1 Then
                If Spc = "" Then
                    Spc = "'" & col & "'"
                Else
                    Spc = Spc & "," & "'" & col & "'"

                End If
            End If


            If (Me.ProgressBar1.Value + Val(rg)) >= Me.ProgressBar1.Maximum Then
                Me.ProgressBar1.Value = 1000
            Else
                Me.ProgressBar1.Value = Me.ProgressBar1.Value + Val(rg)
            End If
        Next
        'MsgBox(Spc)

        If Spc <> "" Then
            ExpressionsQ(0) = "CollegeNo In(" & Spc & ")"
            AukF2.Db_Load("*", Me.AuksoftDataSet1, "InformationId", False, "val(collegeno)")
        End If
    

        Me.ProgressBar1.Visible = False
    End Sub
    Public Sub OpenLiquid(ByVal Convert As Boolean)


        If TSubID = SubID Then Exit Sub
        Decide()
        Working = True
        SFC("Class", "Section", "Shift")
        STC(Clx, Sec, Shv)
        AukF2.Db_Load("*", Me.AuksoftDataSet1.ClassOptions, "", True)

        SFC("StudentClass", "Class_Section", "Shift")
        STC(Clx, Secx, Shv)
        GSql.SqlNonClr_Gr_likeUse_false("*", "InformationID", "", Me.AuksoftDataSet1)

        SFC("SubID")
        STC(SubID)
        GSql.NonCls_ORD_NonLikeCommand("*", "MedicalOfficerComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.NonCls_ORD_NonLikeCommand("*", "HousemasterComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.NonCls_ORD_NonLikeCommand("*", "ClassTeacherComments", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.NonCls_ORD_NonLikeCommand("*", "GamesTeacherComments", "val(Collegeno)", Me.AuksoftDataSet1)

        'SFC("SubID", "ConvertQuality")
        'STC(SubID, "3rdTermConvert")
        'GSql.Sql_ORD_like_false("*", "Highestmarks", "", Me.AuksoftDataSet2)
        SFC("Class", "Section", "Shift")
        STC(Clx, Secx, Shv)
        GSql.NonCls_ORD_NonLikeCommand("*", "ClassOptions", "", Me.AuksoftDataSet1)
        SFC("Class")
        STC(Clx)
        GSql.NonCls_ORD_NonLikeCommand("*", "Acc2Subject", "", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.NonCls_ORD_NonLikeCommand("*", "viewers", "", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.NonCls_ORD_NonLikeCommand("*", "daysofWorks", "", Me.AuksoftDataSet1)
        SFC("Class")
        STC(Clx)
        GSql.NonCls_ORD_NonLikeCommand("*", "MarksObtaint", "", Me.AuksoftDataSet1)
        If Ac1SecInt = True Then
            SFC("Subid")
            STC(SubID)
            GSql.NonCls_ORD_NonLikeCommand("*", "grading", "", Me.AuksoftDataSet1)
            SFC("Subid")
            STC(SubID)
            GSql.NonCls_ORD_NonLikeCommand("*", "subjective", "", Me.AuksoftDataSet1)
            SFC("Subid")
            STC(SubID)
            GSql.NonCls_ORD_NonLikeCommand("*", "objective", "", Me.AuksoftDataSet1)
            cno = Clx & "-" & Secx & Shv
            If AukF.DataSetFindTxT("ClassSection", cno, Me.AuksoftDataSet1, "Classoptions", "SectionSubjectName") Then
                'MsgBox(WGeT)
                GrptxtTx = WGeT

                If WGeT.ToLower.Trim = "science" Or WGeT.ToLower.Trim = "human" Or WGeT.ToLower.Trim = "commerce" Or WGeT.ToLower.Trim = "" Then
                    If WGeT.Trim <> "" Then
                        SFC("Subid")
                        STC(SubID)
                        AukF.SqlQueryFilterAs("*", WGeT, "val(collegeno)", Me.RadioButton3, Me.RadioButton1, Me.RadioButton2, Me.AuksoftDataSet1, Cnpd, "")
                        'Me.AuksoftDataSet1
                    End If
                Else
                    MsgBox("There are some problem in ClassSection Subject....Please Contact with Developer....", MsgBoxStyle.Critical)

                End If

            End If
        Else
            GrptxtTx = ""


        End If
        If Ac1SecInt = False Then
            If Convert = True Then
                SFC("subid")
                STC(SubID & "Convert")
                GSql.NonCls_ORD_NonLikeCommand("*", "SummaryMain", "", Me.AuksoftDataSet1)
                SFC("subid")
                STC(SubID & "Convert")
                GSql.NonCls_ORD_NonLikeCommand("*", "SummaryReport", "", Me.AuksoftDataSet1)
                SFC("SubID", "ConvertQuality")
                STC(SubID, COnQua)
                GSql.NonCls_ORD_NonLikeCommand("*", "Highestmarks", "", Me.AuksoftDataSet1)
            Else
                SFC("subid")
                STC(SubID)
                GSql.NonCls_ORD_NonLikeCommand("*", "SummaryMain", "", Me.AuksoftDataSet1)
                SFC("subid")
                STC(SubID)
                GSql.NonCls_ORD_NonLikeCommand("*", "SummaryReport", "", Me.AuksoftDataSet1)

                SFC("SubID", "ConvertQuality")
                STC(SubID, "")
                GSql.NonCls_ORD_NonLikeCommand("*", "Highestmarks", "", Me.AuksoftDataSet1)
            End If

        Else
            SFC("subid")
            STC(SubID)
            GSql.NonCls_ORD_NonLikeCommand("*", "SummaryMain", "", Me.AuksoftDataSet1)
            SFC("subid")
            STC(SubID)
            GSql.NonCls_ORD_NonLikeCommand("*", "SummaryReport", "", Me.AuksoftDataSet1)

            SFC("SubID", "ConvertQuality")
            STC(SubID, "")
            GSql.NonCls_ORD_NonLikeCommand("*", "Highestmarks", "", Me.AuksoftDataSet1)
        End If


        Me.TextBox1.Text = Me.AuksoftDataSet1.Acc2Convert.Count
        TSubID = SubID
        Working = False

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Dim Snr2 As New SeniorNormalermSingleResult

        Dim t As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Mrp As New Object
        Dim gSrp As New SeniorNormalermSingleResult

        Dim Snr As New SeniorSingleCopy2_export2
        Dim Ssc As New SSC_Single_Finalize2
        Dim Jn As New JoniorSingleCopy2
        AcDicide2()
        'MsgBox(Clx)

        If Nine = True Then
            Mrp = Ssc
        ElseIf Senior = True Then

            If TR.ToLower = "test" Then
                Mrp = Snr
            Else
                Mrp = gSrp
            End If



            'Mrp = Snr

        ElseIf Ac1SecInt = False Then
            Mrp = Jn
            'MsgBox("ok")
        End If

        'MsgBox(Ac1SecInt)


        Mrp.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        t = Mrp.ReportDefinition.ReportObjects.Item("TotalStudentsTxt")
        t.Text = TextBox1.Text
        t = Mrp.ReportDefinition.ReportObjects.Item("Text91")
        t.Text = TextBox2.Text
        t = Mrp.ReportDefinition.ReportObjects.Item("Text102")
        t.Text = TextBox3.Text
        t = Mrp.ReportDefinition.ReportObjects.Item("ClxSign")
        t.Text = TextBox6.Text
        t = Mrp.ReportDefinition.ReportObjects.Item("vpsign")
        t.Text = TextBox5.Text
        t = Mrp.ReportDefinition.ReportObjects.Item("prsign")
        t.Text = TextBox4.Text
        t = Mrp.ReportDefinition.ReportObjects.Item("notetxt")
        t.Text = TextBox7.Text
        If Ac1SecInt = False Then
            If Val(Clx) <= 5 Then
                t = Mrp.ReportDefinition.ReportObjects.Item("TT")
                t.Text = "1000"
                t = Mrp.ReportDefinition.ReportObjects.Item("Tp")
                t.Text = "500"
            End If
        End If
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = Mrp
        ReportViewer.CrystalReportViewer1.ShowGroupTreeButton = True



    End Sub
    'Public Sub vPro(ByVal rp As Object, ByVal DSet As DataSet)

    'End Sub


    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        topic = InputBox("Please type your Print Topic to Save Details in it...", "SaveTopic", topic)
        If Trim(topic) = "" Then
            MsgBox("No Name of Topic... Entry Correctly...", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Me.AuksoftDataSet1.PrintTopic(Me.PrintTopicBindingSource.Position).SavedTopic = topic
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Me.ResultTextBox.Text = Me.ComboBox4.Text

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.QueryTopicBindingSource.EndEdit()
            Me.QueryTopicTableAdapter.Update(Me.AuksoftDataSet1.QueryTopic)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub WizerdTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WizerdTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            AukF.CutWordLetter(Me.ListBox1, Trim(Me.WizerdTextBox.Text), ",", True)
            ToolStripButton10_Click(sender, e)

        End If
    End Sub

    Private Sub WizerdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WizerdTextBox.TextChanged

    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Working = True
        AdCol(False)
        Working = False
    End Sub
    Public Sub AdCol(ByVal Cls As Boolean)
        Dim k As Integer
        Cnpd = Cls

        GID()
        Me.ProgressBar2.Value = 0
        rb = Me.ProgressBar2.Maximum / Me.ListBox1.Items.Count
        If Bld2 = False And Me.OpenWholeRecord.Checked = False Then
            MsgBox("Please Set Class,Section,Year,Term From QueryBuilder and click on QueryBuilder2 in QueryBuilder...", MsgBoxStyle.Critical)
            Exit Sub

        End If
        AcDicide()
        If Cls = True Then
            Me.AuksoftDataSet1.Acc2Convert.Clear()
            Me.AuksoftDataSet1.WholeRecordQuery.Clear()
            Me.AuksoftDataSet1.DaysWorkingQuery.Clear()
            Me.AuksoftDataSet1.DaysWorkQuery2.Clear()

        End If
        For k = 0 To Me.ListBox1.Items.Count - 1

            'If Ac1SecInt = False Then

            col = Me.ListBox1.Items.Item(k).ToString
            If Me.OpenWholeRecord.Checked = True Then
                SFC("Collegeno", "Class")
                STC(col)
                ExpreC("", "is not null")

                AukF.SqlQueryFilterAs("*", "WholeRecordQuery", "val([Class])", Me.RadioButton3, Me.RadioButton1, Me.RadioButton2, Me.AuksoftDataSet1, False, TSubID)
                SFC("Collegeno")
                STC(col)
                'ExpreC("", "is not null")
                AukF.SqlQueryFilterAs("*", "daysworkingquery", "", Me.RadioButton3, Me.RadioButton1, Me.RadioButton2, Me.AuksoftDataSet1, False, TSubID)
                'MsgBox(Sql)
                'MsgBox("Error of Auk...unFinished Command", MsgBoxStyle.Critical)
                'Exit Sub


            Else
                If Me.T3rdConvertResChk.Checked = False Then
                    SFC("Collegeno", "SubID", "ConvertQuality")
                    STC(col, SubID, "")
                Else
                    SFC("Collegeno", "SubID", "ConvertQuality")
                    STC(col, SubID, CnQua)
                End If
                oQuery(False)
                tm = Me.InformationBind.Find("Collegeno", col)
                If tm = -1 Then
                    SFC("collegeno")
                    STC(col)
                    AukF.SqlQueryFilterAs("*", "informationid", "", Me.RadioButton3, Me.RadioButton1, Me.RadioButton2, Me.AuksoftDataSet1, False, "")
                End If
            End If

            'End If

            If (Me.ProgressBar2.Value + Val(rb)) >= Me.ProgressBar2.Maximum Then
                Me.ProgressBar2.Value = Me.ProgressBar2.Maximum
            Else
                Me.ProgressBar2.Value = Me.ProgressBar2.Value + Val(rb)
            End If
        Next
        Me.ProgressBar2.Value = 0

    End Sub
    Public Sub AdNam(ByVal Cls As Boolean)
        Dim k As Integer
        Dim lq, Nx, Mn As Integer
        Dim Nvw As New BindingSource
        Dim Dmk As New DataTable

        'Dim lst As New ComboBox
        'lst.DataSource = Me.InformationBind
        'lst.DisplayMember = "Name"
        'Nx = 0

        If Cls = True Then
            Me.AuksoftDataSet1.Acc2Convert.Clear()
            Me.AuksoftDataSet1.WholeRecordQuery.Clear()
            Me.AuksoftDataSet1.DaysWorkingQuery.Clear()
            Me.AuksoftDataSet1.DaysWorkQuery2.Clear()

        End If
        GID()
        Me.ProgressBar2.Value = 0
        rb = Me.ProgressBar2.Maximum / Me.ListBox1.Items.Count
        For k = 0 To Me.ListBox1.Items.Count - 1
            col = Me.ListBox1.Items.Item(k).ToString
            If Me.OpenWholeRecord.Checked = True Then
                SFC("Name", "Class")
                STC(col)
                ExpreC("", "is not null")

                AukF.SqlQueryFilterAs("*", "WholeRecordQuery", "val([Class])", Me.RadioButton3, Me.RadioButton1, Me.RadioButton2, Me.AuksoftDataSet1, False, TSubID)
                SFC("Name")
                STC(col)
                'ExpreC("", "is not null")
                AukF.SqlQueryFilterAs("*", "daysworkingquery", "", Me.RadioButton3, Me.RadioButton1, Me.RadioButton2, Me.AuksoftDataSet1, False, TSubID)

            Else


                If Me.RadioButton3.Checked = True Then
                    col = Me.ListBox1.Items.Item(k).ToString
                    'MsgBox(col)
                    SFC("name")
                    STC(col)
                    NQuery(False)
                    yh = Me.InformationBind.Find("Name", col)
                    'yh = lst.FindString(col, Nx)
                    'MsgBox(yh)

                    If yh > -1 Then
                        Nx = yh

                        col = Me.AuksoftDataSet1.InformationID(Nx).CollegeNo.ToString

                        If Me.T3rdConvertResChk.Checked = False Then
                            MainID = Clx & Secx & TR & Shv & Yr & col
                        ElseIf Me.T3rdConvertResChk.Checked = True And Ac1SecInt = False Then
                            MainID = Clx & Secx & TR & Shv & Yr & col & CnQua
                        Else
                            MainID = Clx & Secx & TR & Shv & Yr & col
                        End If
                        'MsgBox(MainID, , col)
                        SFC("MainID")
                        STC(MainID)
                        GSql.NonCls_ORD_NonLikeCommand("*", "acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
                        tm = Me.InformationBind.Find("Collegeno", col)
                        If tm = -1 Then
                            SFC("collegeno")
                            STC(col)
                            GSql.NonCls_ORD_NonLikeCommand("*", "informationid", "", Me.AuksoftDataSet1)
                        End If
                    End If
                Else
                    Me.ProgressBar3.Visible = True
                    col = Me.ListBox1.Items.Item(k).ToString
                    'MsgBox(col)
                    SFC("name")
                    STC(col)
                    NQuery(False)
                    SFC("name")
                    STC(col)
                    If Me.RadioButton2.Checked = True Then
                        TbSql.Sql_ORD_likeUse("Collegeno", "InformationID", "", Dmk)
                    Else
                        TbSql.Sql_Cls_Ord_like_From_First("Collegeno", "InformationID", "", Dmk)
                    End If
                    'MsgBox(Dmk.Rows.Count, , Sql)
                    'Dmk = Me.AuksoftDataSet1.InformationID.Select(Nvw.Filter.ToString)
                    'Exit Sub

                    dfg = 100 / Dmk.Rows.Count
                    For Mn = 0 To Dmk.Rows.Count - 1


                        col = Dmk.Rows(Mn).Item(0).ToString

                        If Me.T3rdConvertResChk.Checked = False Then
                            MainID = Clx & Secx & TR & Shv & Yr & col
                        ElseIf Me.T3rdConvertResChk.Checked = True And Ac1SecInt = False Then
                            MainID = Clx & Secx & TR & Shv & Yr & col & CnQua
                        Else
                            MainID = Clx & Secx & TR & Shv & Yr & col
                        End If
                        SFC("MainID")
                        STC(MainID)
                        GSql.NonCls_ORD_NonLikeCommand("*", "acc2Convert", "val(collegeno)", Me.AuksoftDataSet1)
                        AukF.InsPro(Me.ProgressBar3, dfg)
                    Next

                End If
            End If


            Me.ProgressBar3.Value = 0

            AukF.InsPro(Me.ProgressBar2, Val(rb))

        Next
        'If Me.RadioButton3.Checked = False Then
        '    Me.AuksoftDataSet1.InformationID.Select()

        'End If
        'Me.InformationBind.RemoveFilter()

        Me.ProgressBar2.Value = 0
        Me.ProgressBar3.Value = 0
        Me.ProgressBar3.Visible = False

    End Sub
    Public Sub oQuery(ByVal Cls As Boolean)
        If Cls = True Then
            TSubID = ""
            'If Me.RadioButton1.Checked = True Then
            '    GSql.Sql_Cls_Ord_like_From_First("*", "acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            'ElseIf Me.RadioButton2.Checked = True Then
            '    GSql.Sql_ORD_likeUse("*", "acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            'ElseIf Me.RadioButton3.Checked = True Then
            '    GSql.Sql_ORD_like_false("*", "acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            'End If
        Else

            If Me.RadioButton1.Checked = True Then
                LKC("a", "", "")
                GSql.Sql_NonCls_Ord_NonLike_From_First("*", "acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            ElseIf Me.RadioButton2.Checked = True Then
                LKC("a", "", "")
                GSql.NonCls_ORD_NonLikeCommand("*", "acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            ElseIf Me.RadioButton3.Checked = True Then
                GSql.NonCls_ORD_NonLikeCommand("*", "acc2Convert", "val(collegeno)", Me.AuksoftDataSet1)
                'MsgBox(Sql)
            End If
        End If
    End Sub
    Public Sub NQuery(ByVal Cls As Boolean)
        If Cls = True Then
            TSubID = ""
            'If Me.RadioButton1.Checked = True Then
            '    GSql.Sql_Cls_Ord_like_From_First("*", "InformationID", "", Me.AuksoftDataSet1)
            'ElseIf Me.RadioButton2.Checked = True Then
            '    GSql.Sql_ORD_likeUse("*", "InformationID", "", Me.AuksoftDataSet1)
            'ElseIf Me.RadioButton3.Checked = True Then
            '    GSql.Sql_ORD_like_false("*", "InformationID", "", Me.AuksoftDataSet1)
            'End If
        Else
            If Me.RadioButton1.Checked = True Then
                GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "", Me.AuksoftDataSet1)
            ElseIf Me.RadioButton2.Checked = True Then
                GSql.NonCls_ORD_LikeCommand("*", "InformationID", "", Me.AuksoftDataSet1)
            ElseIf Me.RadioButton3.Checked = True Then
                GSql.SqlNonClr_Gr_likeUse_false("*", "InformationID", "", Me.AuksoftDataSet1)
            End If
        End If
    End Sub
    Public Sub GID()
        'If AukF.MsgTr(What & " open That.... you must set before Class ,Section,term,Year,Shift from QueryBuilder then the QueryBuilder2 work...!Are do that...") = False Then
        '    Exit Sub

        'End If
        If (Me.ListBox1.Items.Count - 1) > k Then
            mu = Me.ListBox1.Items.Item(k)

        End If

        Yr = Me.YearTextBox.Text
        TR = Me.TermTextBox.Text
        Clx = Me.ClassTextBox.Text
        Shv = Me.ShiftTextBox.Text
        Secx = Me.SectionTextBox.Text
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        AdNam(True)

    End Sub

    Private Sub BuildOptionOfQueryBuilder2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildOptionOfQueryBuilder2ToolStripMenuItem.Click, Button8.Click
        Decide()

        OpenLiquid(Me.T3rdConvertResChk.Checked)
        Bld2 = True
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        AdCol(True)

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        If Me.CheckBox4.Checked = True Then
            k = Me.ListBox1.SelectedIndex
            If k > -1 Then
                Me.ListBox1.Items.RemoveAt(k)
            End If
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        If Me.CheckBox5.Checked = True Then
            k = Me.ListBox1.SelectedIndex
            If k > -1 Then
                Me.ListBox1.Items.RemoveAt(k)
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        AukF.CutWordLetter(Me.ListBox1, Trim(Me.WizerdTextBox.Text), ",", True)
        ToolStripButton10_Click(sender, e)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        AdNam(False)

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenWholeRecord.CheckedChanged

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            Me.QueryTopicBindingSource.EndEdit()
            Me.QueryTopicTableAdapter.Update(Me.AuksoftDataSet1.QueryTopic)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.AuksoftDataSet1.Acc2Convert.Clear()
        Me.AuksoftDataSet1.WholeRecordQuery.Clear()
        TSubID = 0


    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        MsgBox(AukF.NumAsGrdValue(Me.TextBox10.Text))

    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Me.ListBox1.Items.Clear()

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        If Working = False Then
            AukF.BindGotoFind(Me.QueryTopicBindingSource, "Topic", TextBox9.Text)

        End If
    
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpnWth = True
        Cnpd = False
        Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        BuildOptionOfQueryBuilder2ToolStripMenuItem_Click(sender, e)
    End Sub

    Public Sub New()
        Working = True
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Working = False
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub DeleteTypedCollegeNoAs79867ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTypedCollegeNoAs79867ToolStripMenuItem.Click
        Dim npl As New ListBox
        AukF.CutWordLetter(npl, Me.WizerdTextBox.Text, ",", True)
        For m = 0 To npl.Items.Count - 1
            Me.ListBox1.Items.Remove(npl.Items.Item(m))
        Next
    End Sub

    Private Sub DeleteReordAndSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteReordAndSaveToolStripMenuItem.Click
        On Error Resume Next

        Me.QueryTopicBindingSource.RemoveCurrent()

    End Sub

    Private Sub NextRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextRecordToolStripMenuItem.Click
        Me.QueryTopicBindingSource.MoveNext()

    End Sub

    Private Sub PreRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreRecordToolStripMenuItem.Click
        Me.QueryTopicBindingSource.MovePrevious()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Me.QueryTopicBindingSource.EndEdit()
            Me.QueryTopicTableAdapter.Update(Me.AuksoftDataSet1.QueryTopic)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.DataGrid1.DataSource = Me.ResultView
        Me.BindingNavigator2.BindingSource = Me.ResultView
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        On Error Resume Next
        Dim nb As ListBox
        Dim nu As New BindingSource
        Me.DataGrid1.DataSource = nb
        'Me.DataGrid1.DataSource = Me.ResultView
        Me.BindingNavigator2.BindingSource = nu




    End Sub

    Private Sub SeeTheDatabaseCollegenoListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeeTheDatabaseCollegenoListToolStripMenuItem.Click
        Me.TabControl1.TabPages(3).Select()
        ToolStripButton5_Click(sender, e)

    End Sub

    Private Sub QueryTopicBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles QueryTopicBindingSource.AddingNew
  

    End Sub

    Private Sub QueryTopicBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryTopicBindingSource.CurrentChanged

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Me.ListBox2.DataSource = Me.QueryTopicBindingSource
        Me.ListBox2.DisplayMember = "Topic"

        Me.TextBox11.Visible = True

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Dim cp As New BindingSource
        Me.ListBox2.DataSource = cp
        Me.TextBox11.Visible = False
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Me.AuksoftDataSet1.Acc2Convert.Clear()
        Me.AuksoftDataSet1.DaysWorkQuery2.Clear()
        Me.AuksoftDataSet1.DaysWorkingQuery.Clear()
        Me.AuksoftDataSet1.WholeRecordQuery.Clear()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Decide()
        Dim Cval As Boolean = AukF.BoolInvert(Me.ShortSummary.Checked)

        Dim Np As New HumanBigSheetReport
        Dim Nx As New ScienceBigSheetReport
        Dim nmE As New CommerceBigSheetReport
        Dim Np2 As New BigSheet3
        If Ac1SecInt = False Then
            Np2.Subreports(0).ReportDefinition.Sections.Item(3).SectionFormat.EnableSuppress = Cval
            Np2.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer1.ReportSource = Np2
        Else
            'MsgBox(GrptxtTx)

            If Nine = True Then
                Np2.Subreports(0).ReportDefinition.Sections.Item(3).SectionFormat.EnableSuppress = Cval
                Np2.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
                ReportViewer.Show()
                ReportViewer.CrystalReportViewer1.ReportSource = Np2
            ElseIf Nine = False And Senior = True Then
                If GrptxtTx.ToLower.ToString = "science" Then
                    Nx.Subreports(0).ReportDefinition.Sections.Item(3).SectionFormat.EnableSuppress = Cval
                    Nx.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
                    ReportViewer.Show()
                    ReportViewer.CrystalReportViewer1.ReportSource = Nx
                ElseIf GrptxtTx.ToLower = "human" Then
                    Np.Subreports(0).ReportDefinition.Sections.Item(3).SectionFormat.EnableSuppress = Cval
                    Np.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
                    ReportViewer.Show()
                    ReportViewer.CrystalReportViewer1.ReportSource = Np
                ElseIf GrptxtTx.ToLower = "commerce" Then
                    nmE.Subreports(0).ReportDefinition.Sections.Item(3).SectionFormat.EnableSuppress = Cval
                    nmE.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
                    ReportViewer.Show()
                    ReportViewer.CrystalReportViewer1.ReportSource = nmE
                    ReportViewer.Activate()
                Else
                    MsgBox("Please Open Results First then Click on that....", MsgBoxStyle.Information)

                End If
            Else
                'MsgBox("Please Open Results First then Click on that....", MsgBoxStyle.Information)

            End If

        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If Me.AlsoSetNewRecordNameIDRecordNumToolStripMenuItem.Checked = True Then Me.TextBox8.Text = "ID:" & (Me.QueryTopicBindingSource.Position - 1)

    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Dim N As New StudentsWholeRecord
        If Me.AuksoftDataSet1.WholeRecordQuery.Rows.Count > 0 Then
            N.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer1.ReportSource = N
        Else
            MsgBox("Please Open Record First....", MsgBoxStyle.Information)

        End If


    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        If Me.AuksoftDataSet1.WholeRecordQuery.Rows.Count > 0 Then
            Me.DataGrid1.DataSource = Me.AuksoftDataSet1
            Me.DataGrid1.DataMember = "WholeRecordQuery"
        End If
    End Sub

    Private Sub SummaryOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SingleResultOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BigSheetOpenToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub BigSheetConvertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BigSheetConvertToolStripMenuItem.Click
        'Dim k As Integer


        Working = True
        Decide()
        QuerySt()
        'MsgBox(Ac1SecInt)

        'If Ac1SecInt = False Then
        '    'MsgBox(T3rd)
        '    If T3rd = True Then
        'COnQua = ""
        'MsgBox(Ac1SecInt & COnQua)
        If Ac1SecInt = False Then
            SFC("subid", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("subid", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "Highestmarks", "", Me.AuksoftDataSet1)
        Else
            SFC("subid", "Convertquality")
            STC(SubID, "")
            GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("subid", "Convertquality")
            STC(SubID, "")
            GSql.Sql_ORD_like_false("*", "Highestmarks", "", Me.AuksoftDataSet1)
        End If

        OpenLiquid(True)

        'End If
        OColNo()
        'End If
        'Me.TextBox1.Text = Me.AuksoftDataSet1.Acc2Convert.Count
        TotalStu()

        Working = False

    End Sub

    Private Sub ExtraSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraSummaryToolStripMenuItem.Click
        Decide()

        OpenLiquid(False)

    End Sub

    Private Sub ExtraSummaryConvert38ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraSummaryConvert38ToolStripMenuItem.Click
        Decide()
        OpenLiquid(True)
        'OpenLiquid()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim m As New SummaryReportOnly
        m.ReportDefinition.Sections(4).SectionFormat.EnableSuppress = AukF.BoolInvert(Me.ShortSummary.Checked)
        m.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.CrystalReportViewer1.ReportSource = m
        ReportViewer.Show()
    End Sub

    Private Sub BindingNavigatorDeleteItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem2.Click
        Try
            Me.AuksoftDataSet1.Acc2Convert(Me.DataGrid1.CurrentCell.RowNumber).Delete()

        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button5_Click(sender, e)
        Button2_Click(sender, e)

    End Sub
End Class