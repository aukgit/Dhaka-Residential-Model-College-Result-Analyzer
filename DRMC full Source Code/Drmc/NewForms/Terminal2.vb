Public Class Terminal2
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
    Dim ClassTestView As Boolean = False
    Public Sub Saved2(Optional ByVal Msg As Boolean = False)
        'If Me.BeforeSaveUnFillAllToolStripMenuItem.Checked = True Then UnFill()

        Try
            'Me.Validate()



            'Me.MarksObtaintBindingSource.EndEdit()

            'Me.DefaultConvertNumbersBindingSource.EndEdit()
            Me.ClassTestBindingSource.EndEdit()
            Me.Single3To8SubjectsNumbersBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource1.EndEdit()
            Me.DaysOFWorksBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            If Trd = True Then

                Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)
            End If
            'Me.SummaryMainBindingSource.EndEdit()
            'Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)


            'Me.ThirdtermConvertBindingSource.EndEdit()
            'Me.ThirdtermConvertTableAdapter.Update(Me.AuksoftDataSet1.ThirdtermConvert)
            'Me.CommentsBindingSource.EndEdit()
            'Me.CommentsTableAdapter.Update(Me.AuksoftDataSet1.Comments)

            'Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            'Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            Me.Single3To8SubjectsNumbersTableAdapter.Update(Me.AuksoftDataSet1.Single3To8SubjectsNumbers)
            Me.DaysOFWorksTableAdapter.Update(Me.AuksoftDataSet1.DaysOFWorks)
            'Me.ViewersBindingSource.EndEdit()
            'Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
            'Button7_Click_1(Sender, e)

        Catch ex As Exception
            Me.AuksoftDataSet1.Single3To8SubjectsNumbers.NewRow.ClearErrors()
            Me.AuksoftDataSet1.MarksObtaint.NewRow.ClearErrors()
            Me.AuksoftDataSet1.SummaryMain.NewRow.ClearErrors()
            Me.AuksoftDataSet1.Viewers.NewRow.ClearErrors()
            Me.AuksoftDataSet1.ClassTest.NewRow.ClearErrors()
            Me.AuksoftDataSet1.Acc2Convert.NewRow.ClearErrors()
            Me.AuksoftDataSet2.Acc2Convert.NewRow.ClearErrors()
            Epx()
        Finally
            If Msg = True Then MsgBox("Saved all informations....", MsgBoxStyle.Information)
        End Try

    End Sub
    Public Sub Saved()
        If Me.BeforeSaveUnFillAllToolStripMenuItem.Checked = True Then UnFill()

        Try
            Me.Validate()



            Me.MarksObtaintBindingSource.EndEdit()

            Me.DefaultConvertNumbersBindingSource.EndEdit()
            Me.ClassTestBindingSource.EndEdit()
            Me.Single3To8SubjectsNumbersBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource1.EndEdit()
            Me.DaysOFWorksBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            If Trd = True Then
                Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)
            End If
            'Me.SummaryMainBindingSource.EndEdit()
            'Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)


            Me.ThirdtermConvertBindingSource.EndEdit()
            Me.ThirdtermConvertTableAdapter.Update(Me.AuksoftDataSet1.ThirdtermConvert)
            Me.CommentsBindingSource.EndEdit()
            Me.CommentsTableAdapter.Update(Me.AuksoftDataSet1.Comments)

            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
            Me.Single3To8SubjectsNumbersTableAdapter.Update(Me.AuksoftDataSet1.Single3To8SubjectsNumbers)
            Me.DaysOFWorksTableAdapter.Update(Me.AuksoftDataSet1.DaysOFWorks)
            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
            'Button7_Click_1(Sender, e)

        Catch ex As Exception
            Me.AuksoftDataSet1.Single3To8SubjectsNumbers.NewRow.ClearErrors()
            Me.AuksoftDataSet1.MarksObtaint.NewRow.ClearErrors()
            Me.AuksoftDataSet1.SummaryMain.NewRow.ClearErrors()
            Me.AuksoftDataSet1.Viewers.NewRow.ClearErrors()
            Me.AuksoftDataSet1.ClassTest.NewRow.ClearErrors()
            Me.AuksoftDataSet1.Acc2Convert.NewRow.ClearErrors()
            Me.AuksoftDataSet2.Acc2Convert.NewRow.ClearErrors()

            Epx()
        Finally
            MsgBox("Saved all informations....", MsgBoxStyle.Information)


        End Try

    End Sub
    Public Sub InsCol2(ByVal Collegeno As String)
        Dim I As Integer
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        QMainID = Clx & Secx & TR & Shv & Yr & Collegeno & COnQua
      

        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"

        If Me.Single3To8SubjectsNumbersBindingSource.Filter = "" Then
            'MsgBox(c, , Collegeno)
            c = Me.Single3To8SubjectsNumbersBindingSource.Find("Collegeno", Collegeno)
            If c = -1 Then
                'Me.Single3To8SubjectsNumbersBindingSource.Position = c
                Try
                    Me.Single3To8SubjectsNumbersBindingSource.AddNew()
                    Me.Single3To8SubjectsNumbersBindingSource.EndEdit()
                    I = Me.Single3To8SubjectsNumbersBindingSource.Position
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(1) = MainID
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(2) = SubID
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(3) = Subx
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item("collegeno") = Collegeno
                Catch ex As Exception
                    Epx()
                End Try
            End If

        End If



        c = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
        If Me.DaysOFWorksBindingSource.Filter = "" Then
            If c = -1 Then


                Try
                    Me.DaysOFWorksBindingSource.AddNew()
                    Me.DaysOFWorksBindingSource.EndEdit()
                    I = Me.DaysOFWorksBindingSource.Position
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(1) = UMainID
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(2) = SubID
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(3) = Collegeno
                    Me.DaysOFWorksBindingSource.EndEdit()
                Catch ex As Exception
                    Epx()

                End Try

            End If
        End If


        If T3rd = False Then
            c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
            If Me.Acc2ConvertBindingSource.Filter = "" Then
                If c = -1 Then

                    Try
                        Me.Acc2ConvertBindingSource.AddNew()
                        Me.Acc2ConvertBindingSource.EndEdit()
                        I = Me.Acc2ConvertBindingSource.Position
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(1) = UMainID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(2) = SubID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(4) = Collegeno
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(3) = ""
                        Me.Acc2ConvertBindingSource.EndEdit()
                    Catch ex As Exception
                        Epx()

                    End Try
                End If
            End If
        Else
            If Me.Acc2ConvertBindingSource.Filter = "" And Me.Acc2ConvertBindingSource1.Filter = "" Then
                c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
                If c = -1 Then
                    Try
                        Me.Acc2ConvertBindingSource.AddNew()
                        Me.Acc2ConvertBindingSource.EndEdit()
                        I = Me.Acc2ConvertBindingSource.Position
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(1) = QMainID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(2) = SubID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(4) = Collegeno
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(3) = COnQua
                        Me.Acc2ConvertBindingSource.EndEdit()
                    Catch ex As Exception
                        Epx()
                    End Try
                End If
                c = Me.Acc2ConvertBindingSource1.Find("Collegeno", Collegeno)
                If c = -1 Then
                    Try
                        Me.Acc2ConvertBindingSource1.AddNew()
                        Me.Acc2ConvertBindingSource1.EndEdit()
                        I = Me.Acc2ConvertBindingSource1.Position
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(1) = UMainID
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(2) = SubID
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(4) = Collegeno
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(3) = ""
                        Me.Acc2ConvertBindingSource1.EndEdit()
                    Catch ex As Exception
                        Epx()
                    End Try
                End If
            End If
        End If
    End Sub
    Public Sub InsCol(ByVal Collegeno As String)
        Dim I As Integer
        Working = True
        'yr=
        QMainID = Clx & Secx & TR & Shv & Yr & Collegeno & COnQua
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"

        c = Me.Single3To8SubjectsNumbersBindingSource.Find("Collegeno", Collegeno)
        If Me.Single3To8SubjectsNumbersBindingSource.Filter = "" Then
            'MsgBox(c, , Collegeno)

            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource.Position = c
            ElseIf c = -1 Then
                Try

                    Me.Single3To8SubjectsNumbersBindingSource.AddNew()
                    Me.Single3To8SubjectsNumbersBindingSource.EndEdit()
                    I = Me.Single3To8SubjectsNumbersBindingSource.Position
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(2) = SubID
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(1) = MainID
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(3) = Subx
                    Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Rows(I).Item(4) = Collegeno

                Catch ex As Exception
                    Epx()

                End Try
            End If
        Else
            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource.Position = c
            Else
                MsgBox("Please Remove Filter then Select...", MsgBoxStyle.Critical)
            End If

        End If

        c = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
        If Me.DaysOFWorksBindingSource.Filter = "" Then
            If c > -1 Then
                Me.DaysOFWorksBindingSource.Position = c
            Else
                Try
                    Me.DaysOFWorksBindingSource.AddNew()
                    Me.DaysOFWorksBindingSource.EndEdit()
                    I = Me.DaysOFWorksBindingSource.Position
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(2) = SubID
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(1) = UMainID
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(3) = Collegeno
                Catch ex As Exception
                    Epx()

                End Try

            End If
        Else
            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource.Position = c
            Else
                MsgBox("Please Remove Filter then Select...", MsgBoxStyle.Critical)
            End If
        End If


        If T3rd = False Then
            c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
            If Me.Acc2ConvertBindingSource.Filter = "" Then
                If c = -1 Then

                    Try
                        Me.Acc2ConvertBindingSource.AddNew()
                        Me.Acc2ConvertBindingSource.EndEdit()
                        I = Me.Acc2ConvertBindingSource.Position
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(1) = UMainID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(2) = SubID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(4) = Collegeno
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(3) = ""
                        Me.Acc2ConvertBindingSource.EndEdit()
                    Catch ex As Exception
                        Epx()

                    End Try
                Else
                    Acc2ConvertBindingSource.Position = c
                End If
            Else
                c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
                If c > -1 Then
                    Acc2ConvertBindingSource.Position = c
                Else
                    MsgBox("Please Remove Filter....", MsgBoxStyle.Critical)

                End If
            End If

        Else
            If Me.Acc2ConvertBindingSource.Filter = "" And Me.Acc2ConvertBindingSource1.Filter = "" Then
                c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
                If c = -1 Then
                    Try
                        Me.Acc2ConvertBindingSource.AddNew()
                        Me.Acc2ConvertBindingSource.EndEdit()
                        I = Me.Acc2ConvertBindingSource.Position
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(1) = QMainID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(2) = SubID
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(4) = Collegeno
                        Me.AuksoftDataSet1.Acc2Convert.Rows(I).Item(3) = COnQua
                        Me.Acc2ConvertBindingSource.EndEdit()
                    Catch ex As Exception
                        Epx()
                    End Try
                Else
                    Acc2ConvertBindingSource.Position = c
                End If
                c = Me.Acc2ConvertBindingSource1.Find("Collegeno", Collegeno)
                If c = -1 Then
                    Try
                        Me.Acc2ConvertBindingSource1.AddNew()
                        Me.Acc2ConvertBindingSource1.EndEdit()
                        I = Me.Acc2ConvertBindingSource1.Position
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(1) = UMainID
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(2) = SubID
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(4) = Collegeno
                        Me.AuksoftDataSet2.Acc2Convert.Rows(I).Item(3) = ""
                        Me.Acc2ConvertBindingSource1.EndEdit()
                    Catch ex As Exception
                        Epx()
                    End Try
                Else
                    Acc2ConvertBindingSource1.Position = c

                End If
            Else
                c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
                If c > -1 Then
                    Acc2ConvertBindingSource.Position = c
                Else
                    MsgBox("Please Remove Filter....", MsgBoxStyle.Critical)

                End If
                c = Me.Acc2ConvertBindingSource1.Find("Collegeno", Collegeno)
                If c > -1 Then
                    Acc2ConvertBindingSource1.Position = c
                Else
                    MsgBox("Please Remove Filter....", MsgBoxStyle.Critical)

                End If
            End If
        End If
        Working = False


    End Sub
    Public Sub ColFind(ByVal Collegeno As String)
        'MsgBox(Collegeno)

        Dim c As Integer
        c = Me.Single3To8SubjectsNumbersBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.Single3To8SubjectsNumbersBindingSource.Position = c
        End If
      

        c = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.DaysOFWorksBindingSource.Position = c
        End If
        c = Me.ClassTestBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.ClassTestBindingSource.Position = c
        End If
        c = Me.InformationIDBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.InformationIDBindingSource.Position = c
        End If
        c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.Acc2ConvertBindingSource.Position = c
        End If
        If T3rd = True Then
            c = Me.Acc2ConvertBindingSource1.Find("Collegeno", Collegeno)
            If c > -1 Then
                Me.Acc2ConvertBindingSource1.Position = c
            End If
            c = Me.Single3To8SubjectsNumbersBindingSource1.Find("Collegeno", Collegeno)
            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource1.Position = c
            End If
            c = Me.Single3To8SubjectsNumbersBindingSource2.Find("Collegeno", Collegeno)
            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource2.Position = c
            End If
        End If
    End Sub
    Public Sub ColFind2(ByVal Collegeno As String)
        'c = Me.Single3To8SubjectsNumbersBindingSource.Find("Collegeno", Collegeno)
        'If c > -1 Then
        '    Me.Single3To8SubjectsNumbersBindingSource.Position = c
        'End If
        c = Me.DaysOFWorksBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.DaysOFWorksBindingSource.Position = c
        End If
        c = Me.ClassTestBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.ClassTestBindingSource.Position = c
        End If
        c = Me.InformationIDBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.InformationIDBindingSource.Position = c
        End If
        c = Me.Acc2ConvertBindingSource.Find("Collegeno", Collegeno)
        If c > -1 Then
            Me.Acc2ConvertBindingSource.Position = c
        End If
        If T3rd = True Then
            c = Me.Acc2ConvertBindingSource1.Find("Collegeno", Collegeno)
            If c > -1 Then
                Me.Acc2ConvertBindingSource1.Position = c
            End If
            c = Me.Single3To8SubjectsNumbersBindingSource1.Find("Collegeno", Collegeno)
            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource1.Position = c
            End If
            c = Me.Single3To8SubjectsNumbersBindingSource2.Find("Collegeno", Collegeno)
            If c > -1 Then
                Me.Single3To8SubjectsNumbersBindingSource2.Position = c
            End If
        End If
    End Sub
    Public Sub Opener()
        Working = True
        If Me.BeforeLoadAllInformationUnFillAllToolStripMenuItem.Checked = True Then UnFill()

        Subx = Me.SubjectList.Text
        SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        'MsgBox(MainID)
        'MsgBox(SubID)
        SummaryID = Clx & Sec & TR & Shv & Yr & Subx
        If T3rd = False Then
            If TR = "FIRST TERM" Then
                Tms = 1
            ElseIf TR = "SECOND TERM" Then
                Tms = 2
            End If
        Else
            Tms = 3
        End If
        If ClassTestView = False Then
            If Tms = 1 Then
                AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "0", "", "", "1, 2")
            ElseIf Tms = 2 Then
                AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "0", "", "", "3, 4")
            ElseIf Tms = 3 Then
                AukF2.AukOptionsOfDataGrid(Me.DataGridView1, "", "", "0", "", "", "5, 6")
            End If
            ClassTestView = True
        End If
  
        If T3rd = False Then
            'SFC("SubID", "Subject")
            'STC(SubID, Subx)
            'GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
            ToolStripMenuItem6.Visible = False
            COnQua = ""
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            Me.Thir3rd.Visible = False
            GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            'msgbox(Sql)
            Me.ThirdTermPersentiseMarkTextBox.Visible = False

            SFC("SubID", "Subject")
            STC(SubID, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
            'Me.th()
            'Me.T3rdGroup.Visible = False
        Else
            'SFC("SubID", "Subject")
            'STC(SubID, Subx)
            'GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
            'SFC("SubID", "Subject")
            'STC(SubID & "Convert", Subx & "(Convert)")
            'GSql.NonCls_ORD_NonLikeCommand("*", "SummaryMain", "", Me.AuksoftDataSet1)
            ToolStripMenuItem6.Visible = True
            Job = 3
            'Me.RadioButton3.Checked = True

            COnQua = "3rdTermConvert"
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)
            ''msgbox(Sql)
            SFC("SubID", "Subject")
            STC(SubID, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("SubID", "Subject")
            STC(SubIDF, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet2)
            SFC("SubID", "Subject")
            STC(SubIDS, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet3)
            'MsgBox(Me.Single3To8SubjectsNumbersBindingSource2.Count)
            'MsgBox(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(2).Item("Collegeno").ToString)
            'MsgBox(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(2).Item(8).ToString)

            COnQua = ""
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet2)
            COnQua = "3rdTermConvert"
            Me.ThirdTermPersentiseMarkTextBox.Visible = True
            Me.Thir3rd.Visible = True
            'Me.T3rdGroup.Visible = True
        End If
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "viewers", "", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "daysofworks", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("MainID")
        STC(DefMain)
        GSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", Me.AuksoftDataSet1)
        SFC("Class")
        STC(Clx)
        GSql.Sql_ORD_like_false("*", "marksobtaint", "", Me.AuksoftDataSet1)
        SFC("StudentClass", "Class_Section", "Shift")
        STC(Clx, Secx, Shv)
        GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("Class", "Section", "Shift", "year", "Subjects")
        STC(Clx, Secx, Shv, Yr, Subx)
        GSql.Sql_ORD_like_false("*", "ClassTest", "val(Collegeno)", Me.AuksoftDataSet1)

        SFC("Term")
        STC(TR)
        'Me.MainIDDataGridViewTextBoxColumn.Visible = False
        GSql.Sql_ORD_like_false("*", "ThirdtermConvert", "", Me.AuksoftDataSet2)
        SFC("Term")
        STC(TR)
        'Me.MainIDDataGridViewTextBoxColumn.Visible = False
        GSql.Sql_ORD_like_false("*", "ThirdtermConvert", "", Me.AuksoftDataSet1)
        If Me.AuksoftDataSet1.Viewers.Count = 0 Then
            Me.ViewersBindingSource.AddNew()
            Me.ViewersBindingSource.EndEdit()
            Me.AuksoftDataSet1.Viewers(0).SubID = SubID
            Me.AuksoftDataSet1.Viewers(0).Year = Yr
            Me.AuksoftDataSet1.Viewers(0).Term = TR
            Me.AuksoftDataSet1.Viewers(0)._Class = Clx
            Me.AuksoftDataSet1.Viewers(0).Section = Secx
            Me.AuksoftDataSet1.Viewers(0).Subject = Shv
            Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
            Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & UCase(TR) & " EXAM"
            'Me.ViewersBindingSource.AddNew()
            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
        Else
            Me.AuksoftDataSet1.Viewers(0).SubID = SubID
            Me.AuksoftDataSet1.Viewers(0).Year = Yr
            Me.AuksoftDataSet1.Viewers(0).Term = TR
            Me.AuksoftDataSet1.Viewers(0).Subject = Shv
            Me.AuksoftDataSet1.Viewers(0)._Class = Clx
            Me.AuksoftDataSet1.Viewers(0).Section = Secx
            'Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
            'Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & UCase(TR) & " EXAM"
            'Me.ViewersBindingSource.AddNew()
            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
        End If

        If Me.ThirdtermConvertBindingSource.Count = 0 Then
            Try
                Me.ThirdtermConvertBindingSource.AddNew()
                Me.ThirdtermConvertBindingSource.EndEdit()
                Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(1) = TR
            Catch ex As Exception
                Epx()
            End Try
        ElseIf Me.ThirdtermConvertBindingSource.Count > 1 Then
            If AukF.DelRecAll("Convert Marks ", Me.DefaultConvertNumbersBindingSource) = True Then
                Me.ThirdtermConvertBindingSource.AddNew()
                Me.ThirdtermConvertBindingSource.EndEdit()
                Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(1) = TR
            End If
        Else
            Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(1) = TR
        End If
        Me.ConvertFor3rdTerm_FromTotalMarks_TextBox.Text = Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(2).ToString

        'msgbox(Sql)
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

        'Me.ThirdtermConvertBindingSource.EndEdit()
        'Me.DefaultConvertNumbersBindingSource.EndEdit()
        'Me.DaysOFWorksBindingSource.EndEdit()
        'Me.MarksObtaintBindingSource.EndEdit()

        Working = False

    End Sub
    Public Sub Opener3(ByVal Col As String)
        Working = True
        'If Me.BeforeLoadAllInformationUnFillAllToolStripMenuItem.Checked = True Then UnFill()

        Subx = Me.SubjectList.Text
        SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        'MsgBox(MainID)
        'MsgBox(SubID)
        SummaryID = Clx & Sec & TR & Shv & Yr & Subx
        If T3rd = False Then
            If TR = "FIRST TERM" Then
                Tms = 1
            ElseIf TR = "SECOND TERM" Then
                Tms = 2
            End If
        Else
            Tms = 3
        End If
        If T3rd = False Then
            'SFC("SubID", "Subject")
            'STC(SubID, Subx)
            'GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
            ToolStripMenuItem6.Visible = False
            COnQua = ""
            SFC("SubID", "Convertquality", "Collegeno")
            STC(SubID, COnQua, Col)
            Me.Thir3rd.Visible = False
            GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            'msgbox(Sql)
            Me.ThirdTermPersentiseMarkTextBox.Visible = False

            SFC("SubID", "Subject", "collegeno")
            STC(SubID, Subx, Col)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
            'Me.th()
            'Me.T3rdGroup.Visible = False
        Else
            'SFC("SubID", "Subject")
            'STC(SubID, Subx)
            'GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
            'SFC("SubID", "Subject")
            'STC(SubID & "Convert", Subx & "(Convert)")
            'GSql.NonCls_ORD_NonLikeCommand("*", "SummaryMain", "", Me.AuksoftDataSet1)
            ToolStripMenuItem6.Visible = True
            Job = 3
            'Me.RadioButton3.Checked = True

            COnQua = "3rdTermConvert"
            SFC("SubID", "Convertquality", "collegeno")
            STC(SubID, COnQua, Col)
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)
            ''msgbox(Sql)
            SFC("SubID", "Subject", "collegeno")
            STC(SubID, Subx, Col)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("SubID", "Subject", "collegeno")
            STC(SubIDF, Subx, Col)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet2)
            SFC("SubID", "Subject", "collegeno")
            STC(SubIDS, Subx, col)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet3)
            'MsgBox(Me.Single3To8SubjectsNumbersBindingSource2.Count)
            'MsgBox(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(2).Item("Collegeno").ToString)
            'MsgBox(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(2).Item(8).ToString)

            COnQua = ""
            SFC("SubID", "Convertquality", "collegeno")
            STC(SubID, COnQua, Col)
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet2)
            COnQua = "3rdTermConvert"
            Me.ThirdTermPersentiseMarkTextBox.Visible = True
            Me.Thir3rd.Visible = True
            'Me.T3rdGroup.Visible = True
        End If
        MsgBox(Col)
        SFC("StudentClass", "Class_Section", "Shift", "collegeno")
        STC(Clx, Secx, Shv, Col)
        GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
    End Sub

    Public Sub Opener2()
        Working = True
        'If Me.BeforeLoadAllInformationUnFillAllToolStripMenuItem.Checked = True Then UnFill()

        Subx = Me.SubjectList.Text
        SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        'MsgBox(MainID)
        'MsgBox(SubID)
        SummaryID = Clx & Sec & TR & Shv & Yr & Subx
        If T3rd = False Then
            If TR = "FIRST TERM" Then
                Tms = 1
            ElseIf TR = "SECOND TERM" Then
                Tms = 2
            End If
        Else
            Tms = 3
        End If
        If T3rd = False Then
            'SFC("SubID", "Subject")
            'STC(SubID, Subx)
            'GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
            ToolStripMenuItem6.Visible = False
            COnQua = ""
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            Me.Thir3rd.Visible = False
            GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
            'msgbox(Sql)
            Me.ThirdTermPersentiseMarkTextBox.Visible = False

            SFC("SubID", "Subject")
            STC(SubID, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
            'Me.th()
            'Me.T3rdGroup.Visible = False
        Else
            'SFC("SubID", "Subject")
            'STC(SubID, Subx)
            'GSql.Sql_ORD_like_false("*", "SummaryMain", "", Me.AuksoftDataSet1)
            'SFC("SubID", "Subject")
            'STC(SubID & "Convert", Subx & "(Convert)")
            'GSql.NonCls_ORD_NonLikeCommand("*", "SummaryMain", "", Me.AuksoftDataSet1)
            ToolStripMenuItem6.Visible = True
            Job = 3
            'Me.RadioButton3.Checked = True

            COnQua = "3rdTermConvert"
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)
            ''msgbox(Sql)
            SFC("SubID", "Subject")
            STC(SubID, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet1)
            SFC("SubID", "Subject")
            STC(SubIDF, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet2)
            SFC("SubID", "Subject")
            STC(SubIDS, Subx)
            GSql.Sql_ORD_like_false("*", "Single3To8SubjectsNumbers", "val(Collegeno)", Me.AuksoftDataSet3)
            'MsgBox(Me.Single3To8SubjectsNumbersBindingSource2.Count)
            'MsgBox(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(2).Item("Collegeno").ToString)
            'MsgBox(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(2).Item(8).ToString)

            COnQua = ""
            SFC("SubID", "Convertquality")
            STC(SubID, COnQua)
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet2)
            COnQua = "3rdTermConvert"
            Me.ThirdTermPersentiseMarkTextBox.Visible = True
            Me.Thir3rd.Visible = True
            'Me.T3rdGroup.Visible = True
        End If
        'SFC("SubID")
        'STC(SubID)
        'GSql.Sql_ORD_like_false("*", "viewers", "", Me.AuksoftDataSet1)
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "daysofworks", "val(Collegeno)", Me.AuksoftDataSet1)
        'SFC("MainID")
        'STC(DefMain)
        'GSql.Sql_ORD_like_false("*", "DefaultConvertNumbers", "", Me.AuksoftDataSet1)
        'SFC("Class")
        'STC(Clx)
        'GSql.Sql_ORD_like_false("*", "marksobtaint", "", Me.AuksoftDataSet1)
        'SFC("Class", "Section", "Shift")
        'STC(Clx, Secx, Shv)
        'GSql.Sql_ORD_like_false("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("Class", "Section", "Shift", "year", "Subjects")
        STC(Clx, Secx, Shv, Yr, Subx)
        GSql.Sql_ORD_like_false("*", "ClassTest", "val(Collegeno)", Me.AuksoftDataSet1)

        'SFC("Term")
        'STC(TR)
        'Me.MainIDDataGridViewTextBoxColumn.Visible = False
        'GSql.Sql_ORD_like_false("*", "ThirdtermConvert", "", Me.AuksoftDataSet2)
        'SFC("Term")
        'STC(TR)
        'Me.MainIDDataGridViewTextBoxColumn.Visible = False
        'GSql.Sql_ORD_like_false("*", "ThirdtermConvert", "", Me.AuksoftDataSet1)
        'If Me.AuksoftDataSet1.Viewers.Count = 0 Then
        '    Me.ViewersBindingSource.AddNew()
        '    Me.ViewersBindingSource.EndEdit()
        '    Me.AuksoftDataSet1.Viewers(0).SubID = SubID
        '    Me.AuksoftDataSet1.Viewers(0).Year = Yr
        '    Me.AuksoftDataSet1.Viewers(0).Term = TR
        '    Me.AuksoftDataSet1.Viewers(0)._Class = Clx
        '    Me.AuksoftDataSet1.Viewers(0).Section = Secx
        '    Me.AuksoftDataSet1.Viewers(0).Subject = Shv
        '    Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
        '    Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & UCase(TR) & " EXAM"
        '    'Me.ViewersBindingSource.AddNew()
        '    Me.ViewersBindingSource.EndEdit()
        '    Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
        'Else
        '    Me.AuksoftDataSet1.Viewers(0).SubID = SubID
        '    Me.AuksoftDataSet1.Viewers(0).Year = Yr
        '    Me.AuksoftDataSet1.Viewers(0).Term = TR
        '    Me.AuksoftDataSet1.Viewers(0).Subject = Shv
        '    Me.AuksoftDataSet1.Viewers(0)._Class = Clx
        '    Me.AuksoftDataSet1.Viewers(0).Section = Secx
        '    'Me.AuksoftDataSet1.Viewers(0).AcademicText = "Academic Year " & Yr
        '    'Me.AuksoftDataSet1.Viewers(0).TermShows = "MARKS OBTAINED IN " & UCase(TR) & " EXAM"
        '    'Me.ViewersBindingSource.AddNew()
        '    Me.ViewersBindingSource.EndEdit()
        '    Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)
        'End If

        'If Me.ThirdtermConvertBindingSource.Count = 0 Then
        '    Try
        '        Me.ThirdtermConvertBindingSource.AddNew()
        '        Me.ThirdtermConvertBindingSource.EndEdit()
        '        Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(1) = TR
        '    Catch ex As Exception
        '        Epx()
        '    End Try
        'ElseIf Me.ThirdtermConvertBindingSource.Count > 1 Then
        '    If AukF.DelRecAll("Convert Marks ", Me.DefaultConvertNumbersBindingSource) = True Then
        '        Me.ThirdtermConvertBindingSource.AddNew()
        '        Me.ThirdtermConvertBindingSource.EndEdit()
        '        Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(1) = TR
        '    End If
        'Else
        '    Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(1) = TR
        'End If
        'Me.ConvertFor3rdTerm_FromTotalMarks_TextBox.Text = Me.AuksoftDataSet1.ThirdtermConvert(Me.ThirdtermConvertBindingSource.Position).Item(2).ToString

        ''msgbox(Sql)
        'If Me.MarksObtaintBindingSource.Count = 0 Then
        '    Me.MarksObtaintBindingSource.AddNew()
        '    Me.MarksObtaintBindingSource.EndEdit()
        '    I = Me.MarksObtaintBindingSource.Position
        '    Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(1) = Clx
        '    Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(2) = Shv
        '    Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(3) = TR
        'ElseIf Me.MarksObtaintBindingSource.Count > 1 Then
        '    If AukF.DelRecAll("Marks_comments ", Me.MarksObtaintBindingSource) = True Then
        '        Me.MarksObtaintBindingSource.EndEdit()
        '        Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
        '        Me.MarksObtaintBindingSource.AddNew()
        '        Me.MarksObtaintBindingSource.EndEdit()
        '        I = Me.MarksObtaintBindingSource.Position
        '        Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(1) = Clx
        '        Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(2) = Shv
        '        Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(3) = TR
        '    Else
        '        I = Me.MarksObtaintBindingSource.Position
        '        Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(1) = Clx
        '        Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(2) = Shv
        '        Me.AuksoftDataSet1.MarksObtaint.Item(I).Item(3) = TR
        '    End If
        'End If
        'If Me.DefaultConvertNumbersBindingSource.Count = 0 Then
        '    Me.DefaultConvertNumbersBindingSource.AddNew()
        '    Me.DefaultConvertNumbersBindingSource.EndEdit()
        '    I = Me.DefaultConvertNumbersBindingSource.Position
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(1) = DefMain

        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(2) = "Term"
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(3) = Clx
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(4) = Subx

        'ElseIf Me.DefaultConvertNumbersBindingSource.Count > 1 Then
        '    If AukF.DelRecAll("Marks_comments_MarksConvert ", Me.DefaultConvertNumbersBindingSource) = True Then
        '        Me.DefaultConvertNumbersBindingSource.EndEdit()
        '        Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)

        '        Me.DefaultConvertNumbersBindingSource.AddNew()
        '        Me.DefaultConvertNumbersBindingSource.EndEdit()
        '        I = Me.DefaultConvertNumbersBindingSource.Position
        '        Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(1) = DefMain
        '        Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(2) = "Term"
        '        Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(3) = Clx
        '        Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(4) = Subx
        '    End If
        'Else
        '    I = Me.DefaultConvertNumbersBindingSource.Position
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(1) = DefMain
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(2) = "Term"
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(3) = Clx
        '    Me.AuksoftDataSet1.DefaultConvertNumbers.Item(I).Item(4) = Subx

        'End If

        'Me.ThirdtermConvertBindingSource.EndEdit()
        'Me.DefaultConvertNumbersBindingSource.EndEdit()
        'Me.DaysOFWorksBindingSource.EndEdit()
        'Me.MarksObtaintBindingSource.EndEdit()

        Working = False

    End Sub
    Private Sub Avarage3TextBox_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub PositionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ResultTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Function CerKit(ByVal Num As String)
        CerKit = AukF.DrmcPoints(Job, (Num), ".85", ".42")
    End Function
    Public Sub EryNum(ByVal Collegeno As String)
        Dim c As Integer
        Dim Dw As Integer
        Dim perx As Boolean
        Dim Contxt As String = Me.AuksoftDataSet1.ThirdtermConvert(0).Item(2).ToString
        Dim Tmarks As String
        Dim SelfCon As String
        Dim OnTerm, Hp, Ft As String
        Dim m1r As Boolean
        Dim m2r As Boolean
        Dim m3r As Boolean
        merine = Me.CauseTextBox.Text
        Hp = 25
        Ft = 50
        OnTerm = Val(Me.TotalNumberTextBox.Text)
        If OnTerm = 0 Then OnTerm = 75
        SelfCon = Val(Me.ConvertNumberTextBox1.Text)
        If SelfCon = 0 Then SelfCon = 75
        Tmarks = Me.TextBox1.Text
        'MsgBox(Tmarks)
        'MsgBox(Contxt)
        If T3rd = False Then
            Me.ConvertNumberTextBox.Text = AukF.GivePoints2(AukF.DrmcNumberCon(Me.NumberTextBox.Text, Me.TotalNumberTextBox.Text, Me.ConvertNumberTextBox1.Text))
            I = Me.ClassTestBindingSource.Find("collegeno", Collegeno)
            If I > -1 Then
                If Tms = 1 Then
                    cx = Me.AuksoftDataSet1.ClassTest(I).Item(12).ToString
                    If InStr(cx, "%FromTerm") = 0 Then
                        avg = Val(Me.AuksoftDataSet1.ClassTest(I).Item(11).ToString)
                        perx = False
                    Else
                        perx = True
                    End If
                ElseIf Tms = 2 Then
                    cx = Me.AuksoftDataSet1.ClassTest(I).Item(18).ToString
                    If InStr(cx, "%FromTerm") = 0 Then
                        avg = Val(Me.AuksoftDataSet1.ClassTest(I).Item(17).ToString)
                        perx = False
                    Else
                        perx = True
                    End If
                End If
            End If
            If perx = False Then
                Me.TotalMarksTextBox.Text = (Val(Me.ConvertNumberTextBox.Text) + Val(avg))
            Else
                Me.TotalMarksTextBox.Text = (AukF.DrmcNumberCon(Me.ConvertNumberTextBox.Text, SelfCon, Tmarks))
            End If

     

            Me.PersentiseNumberTextBox.Text = AukF.GivePoints2(AukF.DrmcNumberCon(Me.TotalMarksTextBox.Text, Tmarks, Contxt))
        Else
            '------
            Me.ConvertNumberTextBox.Text = AukF.GivePoints2(AukF.DrmcNumberCon(Me.NumberTextBox.Text, Me.TotalNumberTextBox.Text, Me.ConvertNumberTextBox1.Text))
            I = Me.ClassTestBindingSource.Find("collegeno", Collegeno)
            If I > -1 Then
                cx = Me.AuksoftDataSet1.ClassTest(I).Item(24).ToString
                If InStr(cx, "%FromTerm") = 0 Then
                    avg = Val(Me.AuksoftDataSet1.ClassTest(I).Item(23).ToString)
                    perx = False
                Else
                    perx = True
                End If
            End If
            If perx = False Then
                Me.TotalMarksTextBox.Text = (Val(Me.ConvertNumberTextBox.Text) + Val(avg))
            Else
                Me.TotalMarksTextBox.Text = (AukF.DrmcNumberCon(Me.ConvertNumberTextBox.Text, SelfCon, Tmarks))
            End If
            c = Me.Acc2ConvertBindingSource.Find("collegeno", Collegeno)
            If c > -1 Then
                Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = Me.TotalMarksTextBox.Text
            End If
            Me.PersentiseNumberTextBox.Text = AukF.GivePoints2(AukF.DrmcNumberCon(Me.TotalMarksTextBox.Text, Tmarks, Contxt))
            Dw = Me.Single3To8SubjectsNumbersBindingSource1.Find("collegeno", Collegeno)
            If Dw > -1 Then
                cr1 = LCase(Me.AuksoftDataSet2.Single3To8SubjectsNumbers.Item(Dw).Item(9).ToString)
                If cr1 = "average" Then
                    m1r = True
                Else
                    m1 = Val(Me.AuksoftDataSet2.Single3To8SubjectsNumbers.Item(Dw).Item(7).ToString)
                    m1r = False
                End If

            End If
            Dw = Me.Single3To8SubjectsNumbersBindingSource2.Find("collegeno", Collegeno)
            If Dw > -1 Then
                cr1 = LCase(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(Dw).Item(9).ToString)
                If cr1 = "average" Then
                    m2r = True
                Else
                    m2 = Val(Me.AuksoftDataSet3.Single3To8SubjectsNumbers.Item(Dw).Item(7).ToString)
                    m2r = False
                End If
            End If
            Dw = Me.Single3To8SubjectsNumbersBindingSource.Find("collegeno", Collegeno)
            If Dw > -1 Then
                cr1 = LCase(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Dw).Item(9).ToString)
                If cr1 = "average" Then
                    m3r = True
                Else
                    m3 = PersentiseNumberTextBox.Text
                    m3r = False
                End If
            End If
            If m1r = False And m2r = False And m3r = False Then
                Me.ThirdTermPersentiseMarkTextBox.Text = (Val(m1) + Val(m2) + Val(m3))
            Else
                If (m1r = True And m2r = True And m3r = False) Then
                    Me.ThirdTermPersentiseMarkTextBox.Text = TotalMarksTextBox.Text
                ElseIf (m2r = True And m3r = True And m1r = False) Then
                    'there is a gerbage
                    Me.ThirdTermPersentiseMarkTextBox.Text = (AukF.DrmcNumberCon(m1, Hp, 100))
                ElseIf (m1r = True And m3r = True And m2r = False) Then
                    'there is a gerbage
                    Me.ThirdTermPersentiseMarkTextBox.Text = (AukF.DrmcNumberCon(m2, Hp, 100))

                ElseIf (m2r = False And m3r = False And m1r = True) Then
                    'there is a gerbage
                    m2 = (AukF.DrmcNumberCon(m2, Hp, Ft))
                    Me.ThirdTermPersentiseMarkTextBox.Text = (Val(m2) + Val(m3))
                ElseIf (m1r = False And m3r = False And m2r = True) Then
                    'there is a gerbage
                    m1 = (AukF.DrmcNumberCon(m1, Hp, Ft))
                    'MsgBox(m1)
                    Me.ThirdTermPersentiseMarkTextBox.Text = (Val(m1) + Val(m3))
                ElseIf (m1r = False And m2r = False And m3r = True) Then
                    'there is a gerbage
                    m1 = (AukF.DrmcNumberCon(m1, Hp, Ft))
                    m2 = (AukF.DrmcNumberCon(m2, Hp, Ft))
                    Me.ThirdTermPersentiseMarkTextBox.Text = (Val(m2) + Val(m1))

                End If
            End If
        End If
        If T3rd = True Then
            Me.TotalMarksTextBox.Text = AukF.RemovePoints(Me.TotalMarksTextBox.Text)
            Me.ThirdTermPersentiseMarkTextBox.Text = AukF.RemovePoints(Me.ThirdTermPersentiseMarkTextBox.Text)
            c = Me.Acc2ConvertBindingSource1.Find("collegeno", Collegeno)
            If c > -1 Then
                If merine = "Average" Then
                    Me.AuksoftDataSet2.Acc2Convert.Item(c).Item(SubPosX) = "P"
                ElseIf merine = "Absent" Then
                    Me.AuksoftDataSet2.Acc2Convert.Item(c).Item(SubPosX) = "A"
                Else
                    Me.AuksoftDataSet2.Acc2Convert.Item(c).Item(SubPosX) = Me.TotalMarksTextBox.Text
                End If
            End If
            c = Me.Acc2ConvertBindingSource.Find("collegeno", Collegeno)
            If c > -1 Then
                If merine = "Average" Then
                    Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = "P"
                ElseIf merine = "Absent" Then
                    Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = "A"
                Else
                    Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = Me.ThirdTermPersentiseMarkTextBox.Text
                End If
            End If
        Else
            Me.TotalMarksTextBox.Text = AukF.RemovePoints(Me.TotalMarksTextBox.Text)
            c = Me.Acc2ConvertBindingSource.Find("collegeno", Collegeno)
            If c > -1 Then
                If merine = "Average" Then
                    Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = "P"
                ElseIf merine = "Absent" Then
                    Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = "A"
                Else
                    Me.AuksoftDataSet1.Acc2Convert.Item(c).Item(SubPosX) = Me.TotalMarksTextBox.Text
                End If
            End If
        End If
    End Sub
    Private Sub MainQuerymanagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainQuerymanagerToolStripMenuItem.Click
        If AukF.MsgTr("Do you want to Save Before Query New...?") = True Then
            Saved()
        End If
        Me.Hide()
        QueryManager.Show()


    End Sub

    Private Sub Single3To8SubjectsNumbersDataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Single3To8SubjectsNumbersDataGridView1.CellBeginEdit

    End Sub
    Private Sub Single3To8SubjectsNumbersDataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Single3To8SubjectsNumbersDataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Terminal2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Working = True

    End Sub

    Private Sub Terminal2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = False
        Working = True

    End Sub
    Private Sub TRinal2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SummaryMain' table. You can move, or remove it, as needed.
        'Me.SummaryMainTableAdapter.Fill(Me.AuksoftDataSet1.SummaryMain)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Viewers' table. You can move, or remove it, as needed.
        Me.CommentsTableAdapter.Fill(Me.AuksoftDataSet1.Comments)
        'Me.ViewersTableAdapter.Fill(Me.AuksoftDataSet1.Viewers)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Viewers' table. You can move, or remove it, as needed.
        AukSql.A_SqlAuk_FindAnd_Add("*", "acc2sublst", Me.AuksoftDataSet1)
        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd
        'c = AukF.ComboFind(Me.SubjectList, Subx)
        AukF.ComboFind(Me.SubjectList, Subx)
        'MsgBox("There are some problem in subject list...", MsgBoxStyle.Critical)
        'End If
        'Me.NamedOFForm.Text = Me.Text
        Me.Examination.Text = Term

        AukF.XPAuk(Me)
        AukF.ComSelIndex(Me.SignofFilter)
        AukF.ComSelIndex(Me.TabletileComboToolTip)
        Job = 1


    End Sub
    Private Sub FilterTextbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterTextbox.Click

    End Sub
    Private Sub FilterTextbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilterTextbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.TabletileComboToolTip.Text = "Cause" Then
                Me.Single3To8SubjectsNumbersBindingSource.Filter = "[" & Me.TabletileComboToolTip.Text & "]" & "='" & Me.FilterTextbox.Text & "'"
            Else
                Me.Single3To8SubjectsNumbersBindingSource.Filter = "[" & Me.TabletileComboToolTip.Text & "]" & Me.SignofFilter.Text & Me.FilterTextbox.Text
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        AukF.TextBoxColorDrmc(Me.CauseTextBox)
        Nums.Text = Me.CollegenoMainCombo.Items.Count
        RecNum.Text = Me.Single3To8SubjectsNumbersBindingSource.Count
        Rec2.Text = Me.Single3To8SubjectsNumbersBindingSource.Count
    End Sub
    Private Sub Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Working = True
        Me.Single3To8SubjectsNumbersBindingSource.Filter = "[" & Me.TabletileComboToolTip.Text & "]" & Me.SignofFilter.Text & Me.FilterTextbox.Text
        Working = False

    End Sub
    Private Sub RemoveFilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Single3To8SubjectsNumbersBindingSource.RemoveFilter()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Saved()

    End Sub
    Private Sub LoadAgainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadAgainToolStripMenuItem.Click
        Opener()

    End Sub
    Private Sub CollegenoMainCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollegenoMainCombo.SelectedIndexChanged

    End Sub
    Private Sub CollegenoMainCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CollegenoMainCombo.SelectionChangeCommitted
        Try
            'InsCol(Me.CollegenoMainCombo.Text)
            ColFind(sender.text)

            '

        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Private Sub CancelSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSaveToolStripMenuItem.Click
        If AukF.MsgTr(What & "Reject all table Changes ...?") = False Then
            Exit Sub

        End If
        Try
            Me.Single3To8SubjectsNumbersBindingSource.CancelEdit()
            Me.DaysOFWorksBindingSource.CancelEdit()
            Me.Acc2ConvertBindingSource.CancelEdit()
            Me.Acc2ConvertBindingSource1.CancelEdit()
            Me.MarksObtaintBindingSource.CancelEdit()
            Me.AuksoftDataSet1.RejectChanges()
        Catch ex As Exception
            Epx()

        End Try


    End Sub
    Public Function Inputs(Optional ByVal GotoFirst As Boolean = False, Optional ByVal Beeps As Boolean = False)

        dx = (Me.AuksoftDataSet1.InformationID.Rows.Count - 1)
        Me.Acc2ConvertBindingSource.RemoveFilter()
        Me.Acc2ConvertBindingSource1.RemoveFilter()
        Me.DaysOFWorksBindingSource.RemoveFilter()
        'MsgBox(Me.AuksoftDataSet1.InformationID.Rows(0).Item(4).ToString)
        Dim m As Integer
        Try
            Me.ProgressBar1.Value = 0
            Me.ProgressBar1.Visible = True
            c = Me.InformationIDBindingSource.Count.ToString
            g = 100 / c
            For m = 0 To dx
                Working = True

                xe = Me.AuksoftDataSet1.InformationID.Rows(m).Item(0).ToString
                'MsgBox(xe, , m)
                InsCol2(xe)
                AukF.InsPro(Me.ProgressBar1, g)


            Next


            Working = False
            If GotoFirst = True Then Me.Single3To8SubjectsNumbersBindingSource.MoveFirst()
            Me.ProgressBar1.Visible = False
        Catch ex As Exception
            Epx()
            If AukF.MsgTr("Do you want to Exit From Function?") = True Then
                Working = False
                Exit Function
            End If
        Finally
            If Beeps = True Then Beep()

        End Try
        'If AukF.MsgTr(What & "Save ?,Without Save Changes Couldn't be accpted... ") = True Then
        '    Saved()
        '    TRinal2_Load(sender, e)
        '    Opener()

        '    'terminal2_load(
        'End If
    End Function
    Private Sub InputAllCollegeNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputAllCollegeNoToolStripMenuItem.Click
        Dim CntClas, Aq, Ahi As Integer
        Dim Chk = Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked
        If AukF.MsgTr(What & "Input all Students Information In Database?") = False Then
            Exit Sub
        End If
        UnFill()

        If Val(Clx) >= 3 And Val(Clx) <= 5 Then
            CntClas = 10
        Else
            CntClas = 11
        End If

        ProgressBar2.Value = 0

        ProgressBar2.Visible = True
        Me.ProgressBar2.Maximum = CntClas
        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = False
        Me.DataGridView1.Visible = False
        Aq = Me.SubjectList.SelectedIndex
        For Ahi = 0 To CntClas - 1
            Me.SubjectList.SelectedIndex = Ahi
            'MsgBox(Ahi)
            If Ahi = (CntClas - 1) Then
                Opener2()
                Inputs(True, True)
            Else
                Opener2()
                Inputs()
            End If
            ToolStripStatusLabel2_Click(sender, e)
            Saved2()

            AukF.InsPro(ProgressBar2, 1)
        Next
        Me.DataGridView1.Visible = True
        ProgressBar2.Visible = False

        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = Chk
        Me.SubjectList.SelectedIndex = Aq
        If Chk = False Then Opener()


    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CancelSaveToolStripMenuItem_Click(sender, e)

    End Sub
    Private Sub CollgenoFindTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CollgenoFindTextBox.KeyDown
        'If e.KeyCode = Keys.Up Then
        '    Me.Calculate_TextTextBox.Focus()
        'ElseIf e.KeyCode = Keys.Down Then
        '    Me.Calculate_TextTextBox.Focus()
        'End If
        'If Me.KeydownEvent.Checked = True Then
        '    If e.KeyCode = Keys.Left Then
        '        Me.Single3To8SubjectsNumbersBindingSource.MovePrevious()
        '        Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
        '        ColFind2(Me.CollgenoFindTextBox.Text)
        '    ElseIf e.KeyCode = Keys.Right Then
        '        Me.Single3To8SubjectsNumbersBindingSource.MoveNext()
        '        Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
        '        ColFind2(Me.CollgenoFindTextBox.Text)
        '    End If
        '    If e.KeyCode = Keys.Enter Then
        '        Me.Single3To8SubjectsNumbersBindingSource.MoveNext()
        '        Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
        '        ColFind2(Me.CollgenoFindTextBox.Text)
        '    End If
        '    If e.KeyCode = Keys.Delete Then
        '        DirectCast(sender, TextBox).Text = ""

        '    End If
        'End If

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollgenoFindTextBox.TextChanged
        On Error Resume Next
        'Dim tru As Integer
        If Trim(CollgenoFindTextBox.Text) = "" Then Exit Sub
        ColFind(sender.text)

        'If Me.ExtactCollegeno.Checked = False Then
        '    tru = Me.CollegenoMainCombo.FindString(CollgenoFindTextBox.Text)
        '    'MsgBox(tru)
        '    If tru > -1 Then
        '        qxq = Me.AuksoftDataSet1.InformationID(tru).CollegeNo.ToString

        '        'MsgBox(qxq)
        '        ColFind(qxq)
        '    Else
        '        ColFind(Me.CollgenoFindTextBox.Text)
        '    End If

        'Else
        '    ColFind(Me.CollgenoFindTextBox.Text)
        'End If

    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Informations.Show()

    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Try
            For I = 0 To Me.DaysOFWorksBindingSource.Count - 1
                Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(6) = TotalDaystext.Text
            Next I
        Catch ex As Exception
            Epx()
            If AukF.MsgTr("Do you want to Exit From Function?") = True Then
                Exit Sub
            End If
        End Try
    End Sub
    Private Sub TotalDaystext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDaystext.Click


    End Sub
    Private Sub TotalDaystext_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TotalDaystext.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                For I = 0 To Me.DaysOFWorksBindingSource.Count - 1
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(6) = TotalDaystext.Text
                Next I
            Catch ex As Exception
                Epx()
                If AukF.MsgTr("Do you want to Exit From Function?") = True Then
                    Exit Sub
                End If
            End Try

        End If
    End Sub
    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click


    End Sub
    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        ColFind(ToolStripTextBox1.Text)
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Ctmarks.Show()
        Ctmarks.ShiftTextBox.Text = Shv
        Ctmarks.YearTextBox.Text = Yr
        Ctmarks.Clas.Text = Clx
        Ctmarks.SectionText.Text = Sec

        c = Ctmarks.SubjectComboBox.FindStringExact(Subject)
        If c > -1 Then
            Ctmarks.SubjectComboBox.SelectedIndex = c
        End If
    End Sub
    Private Sub DeleteRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        Try
            'Me.DaysOFWorksBindingSource.RemoveCurrent()
            Working = True
            Me.Single3To8SubjectsNumbersBindingSource.RemoveCurrent()
            Working = False
        Catch ex As Exception
            Epx()
            'If AukF.MsgTr("Do you want to Exit From Function?") = True Then
            '    Exit Sub
            'End If
        End Try

    End Sub
    Private Sub Single3To8SubjectsNumbersBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Single3To8SubjectsNumbersBindingSource.CurrentChanged
        'GetCol()
        'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4))

    End Sub
    Public Sub GetCol()
        Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)

    End Sub
    Private Sub Single3To8SubjectsNumbersBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Single3To8SubjectsNumbersBindingSource.CurrentItemChanged
        'GetCol()
        'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4))
        'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4))

    End Sub
    Private Sub Single3To8SubjectsNumbersBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Single3To8SubjectsNumbersBindingSource.PositionChanged
        'GetCol()
        ''ColFind2(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4))
        On Error Resume Next

        AukF.InPText(Me.CauseTextBox, "None")
        'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4))

        'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4))
        If Single3To8SubjectsNumbersBindingSource.Position <> -1 Then
            If Working = False Then
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4).ToString()
                EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4).ToString)
            End If

            'Exit Sub
        End If
     


        'ColFind(Me.CollgenoFindTextBox.Text)


    End Sub
    Private Sub NumberTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumberTextBox.KeyDown
        If e.KeyCode = Keys.Up Then
            Me.CollgenoFindTextBox.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            Me.CollgenoFindTextBox.Focus()
        End If
        If Me.KeydownEvent.Checked = True Then
            If e.KeyCode = Keys.Left Then
                Me.Single3To8SubjectsNumbersBindingSource.MovePrevious()
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
                ColFind2(Me.CollgenoFindTextBox.Text)
            ElseIf e.KeyCode = Keys.Right Then
                Me.Single3To8SubjectsNumbersBindingSource.MoveNext()
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
                ColFind2(Me.CollgenoFindTextBox.Text)
            End If
            If e.KeyCode = Keys.Enter Then
                Me.Single3To8SubjectsNumbersBindingSource.MoveNext()
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
                ColFind2(Me.CollgenoFindTextBox.Text)
            End If

            If e.KeyCode = Keys.Delete Then
                Working = True
                NumberTextBox.Text = ""
                Working = False

            End If

        End If
 
    End Sub
    Private Sub TabPage5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage5.Click

    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Sub NumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberTextBox.TextChanged
        If Working = False Then
            EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Item(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4).ToString)


        End If
    
    End Sub
    Private Sub GetWorkingDaysTotaldaysAbsentDaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetWorkingDaysTotaldaysAbsentDaysToolStripMenuItem.Click
        Try
            For I = 0 To Me.DaysOFWorksBindingSource.Count - 1
                ab = Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(5).ToString
                If Trim(ab) = "" Then
                    Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(5) = 0
                End If
                total = Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(6).ToString
                wr = Val(total) - Val(ab)
                Me.AuksoftDataSet1.DaysOFWorks.Rows(I).Item(4) = Val(wr)
            Next I
        Catch ex As Exception
            Epx()
            If AukF.MsgTr("Do you want to Exit From Function?") = True Then
                Exit Sub
            End If
        Finally

        End Try
    End Sub
    Private Sub Lix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Acc2SubLstBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acc2SubLstBindingNavigatorSaveItem.Click
        Saved()

    End Sub
    Private Sub CauseCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CauseCombo.SelectedIndexChanged
        Me.CauseTextBox.Text = Me.CauseCombo.Text
    End Sub
    Private Sub CauseCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CauseCombo.SelectionChangeCommitted
        Me.CauseTextBox.Text = Me.CauseCombo.Text

    End Sub
    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
    Private Sub Single3To8SubjectsNumbersDataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Single3To8SubjectsNumbersDataGridView1.CellValueChanged

    End Sub
    Public Sub UnFill()
        Me.DataGridView1.DataSource = ""
        Me.Acc2ConvertDataGridView.DataSource = ""
        Me.Single3To8SubjectsNumbersDataGridView1.DataSource = ""
        Me.DaysOFWorksDataGridView.DataSource = ""
        'me.
    End Sub
    Public Sub Fill()
        Me.DataGridView1.DataSource = Me.ClassTestBindingSource
        Me.Acc2ConvertDataGridView.DataSource = Me.Acc2ConvertBindingSource
        Me.Single3To8SubjectsNumbersDataGridView1.DataSource = Me.Single3To8SubjectsNumbersBindingSource
        Me.DaysOFWorksDataGridView.DataSource = Me.DaysOFWorksBindingSource
        'me.
    End Sub
    Private Sub TotalDaystext_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TotalDaystext.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Saved()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Saved()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, RefreshAllNumbersOfThisSubjectToolStripMenuItem.Click

        On Error Resume Next
        If AukF.MsgTr(What & "Refresh all Numbers(its need much time)....!") = no Then
            Exit Sub
        End If
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        c = Me.Single3To8SubjectsNumbersBindingSource.Count.ToString
        g = 100 / c
        'MsgBox(g)
        If Me.Single3To8SubjectsNumbersBindingSource.Count < 0 Then
            Exit Sub
        End If
        For m = 0 To Me.Single3To8SubjectsNumbersBindingSource.Count.ToString - 1
            Me.Single3To8SubjectsNumbersBindingSource.Position = m
            'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Collegeno.ToString)
            Me.ProgressBar1.Value = Me.ProgressBar1.Value + Val(g)
        Next
        Me.Single3To8SubjectsNumbersBindingSource.Position = 0
        Me.ProgressBar1.Visible = False
    End Sub
    Public Function RefreshNums()

        On Error Resume Next
        'If AukF.MsgTr(What & "Refresh all Numbers(its need much time)....!") = no Then
        '    Exit Function
        'End If
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        c = Me.Single3To8SubjectsNumbersBindingSource.Count.ToString
        g = 100 / c
        'MsgBox(g)
        If Me.Single3To8SubjectsNumbersBindingSource.Count < 0 Then
            Exit Function
        End If
        For m = 0 To Me.Single3To8SubjectsNumbersBindingSource.Count.ToString - 1
            Me.Single3To8SubjectsNumbersBindingSource.Position = m
            'EryNum(Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Collegeno.ToString)
            Me.ProgressBar1.Value = Me.ProgressBar1.Value + Val(g)
        Next
        Me.Single3To8SubjectsNumbersBindingSource.Position = 0
        Me.ProgressBar1.Visible = False
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        InputAllCollegeNoToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub ClearTextBoxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearTextBoxToolStripMenuItem.Click
        'Select Case DirectCast(sender, TextBox).Name
        '    Case Me.NumberTextBox.Name
        '        Me.NumberTextBox.Text = ""
        '    Case Me.CollgenoFindTextBox.Name
        '        Me.CollgenoFindTextBox.Text = ""

        'End Select

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamedOFForm.Click


    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NamedOFForm.MouseDown
        AukF.DragAuk(Me)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.CauseTextBox.Text = "Absent"
    End Sub

    Private Sub TabPage8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.RadioButton1.Checked = True Then
        '    Job = 1
        'ElseIf Me.RadioButton2.Checked = True Then
        '    Job = 2
        'Else
        '    Job = 3

        'End If
    End Sub

    Private Sub Calculate_TextTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            Me.CollgenoFindTextBox.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            Me.NumberTextBox.Focus()
        End If
        If Me.KeydownEvent.Checked = True Then
            If e.KeyCode = Keys.Left Then
                Me.Single3To8SubjectsNumbersBindingSource.MovePrevious()
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
                ColFind2(Me.CollgenoFindTextBox.Text)
            ElseIf e.KeyCode = Keys.Right Then
                Me.Single3To8SubjectsNumbersBindingSource.MoveNext()
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
                ColFind2(Me.CollgenoFindTextBox.Text)
            End If
            If e.KeyCode = Keys.Enter Then
                Me.Single3To8SubjectsNumbersBindingSource.MoveNext()
                Me.CollgenoFindTextBox.Text = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(Me.Single3To8SubjectsNumbersBindingSource.Position).Item(4)
                ColFind2(Me.CollgenoFindTextBox.Text)
            End If
            If e.KeyCode = Keys.Delete Then
                DirectCast(sender, TextBox).Text = ""
            End If
        End If
    End Sub

    Private Sub Calculate_TextTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        GridOfTerminal2.Show()
        GridOfTerminal2.DataGridView1.DataSource = Me.Single3To8SubjectsNumbersBindingSource1
        GridOfTerminal2.DataGridView2.DataSource = Me.Single3To8SubjectsNumbersBindingSource2
        GridOfTerminal2.DataGridView3.DataSource = Me.Single3To8SubjectsNumbersBindingSource
        GridOfTerminal2.DataGridView4.DataSource = Me.Acc2ConvertBindingSource1
        GridOfTerminal2.DataGridView5.DataSource = Me.Acc2ConvertBindingSource


    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Saved()
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
            Me.ViewersBindingSource.EndEdit()
            Me.ViewersTableAdapter.Update(Me.AuksoftDataSet1.Viewers)

        Catch ex As Exception
            Epx()
            'Resume Next
        End Try
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click, SaveToolStripMenuItem2.Click
        Try
            Me.DaysOFWorksBindingSource.EndEdit()
            Me.DaysOFWorksTableAdapter.Update(Me.AuksoftDataSet1.DaysOFWorks)
        Catch ex As Exception
            Epx()
        End Try


    End Sub

    Private Sub DeleteAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllToolStripMenuItem.Click
        'If AukF.MsgTr(What & "Delete all Records from DaysofWorks...?") = True Then
        AukF.DelRecAll("DaysofWorks", Me.DaysOFWorksBindingSource)
        'End If
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        If AukF.MsgTr(What & "Reject Changes for Daysof Work..?") = False Then
            Exit Sub

        End If
        Me.DaysOFWorksBindingSource.CancelEdit()
        Me.AuksoftDataSet1.RejectChanges()

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub SubjectList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectList.SelectedIndexChanged
        If Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = True Then
            'col = GetCol(Me.Single3To8SubjectsNumbersBindingSource.Position)
            'MsgBox(col)
            If Working = False Then
                Subx = Me.SubjectList.Text
                SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))
                Opener()
                'AukF2.FindInObjectAndSelect(Me.CollegenoMainCombo, col, True, True)
                'AukF2.BindFind(Me.Single3To8SubjectsNumbersBindingSource, "Collegeno", col)
                'Me.Single3To8SubjectsNumbersBindingSource.Position = ComRow


            End If


        End If

        'MsgBox(SubPosx)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    '    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        'On Error Resume Next

    '        Dim Mvt, Mvt2 As Integer
    '        Dim Failed, Failed2, Pass, Pass2, PassPercent, PassPercent2, abs, abs2 As Double
    '        Dim StCol, StCol2 As String
    '        Try
    '            Mvt = 0
    '            Failed = 0
    '            Pass = 0
    '            PassPercent = 0
    '            abs = 0
    '            StCol = ""
    '            Mvt2 = 0
    '            Failed2 = 0
    '            Pass2 = 0
    '            PassPercent2 = 0
    '            abs2 = 0
    '            StCol2 = ""

    '            If T3rd = False Then
    '                If Me.SummaryMainBindingSource.Count = 0 Then
    '                    Me.SummaryMainBindingSource.AddNew()
    '                    Me.SummaryMainBindingSource.EndEdit()
    '                End If
    '                a = Val(Me.AuksoftDataSet1.MarksObtaint(0).Item(7).ToString)
    '                'MsgBox(a)
    '                p = Val(Me.AuksoftDataSet1.MarksObtaint(0).Passmarks.ToString)

    '                For I = 0 To Me.Single3To8SubjectsNumbersBindingSource.Count.ToString - 1
    '                    c = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString
    '                    If Val(c) >= Val(a) Then
    '                        Mvt = Mvt + 1
    '                    End If
    '                    If Val(c) < Val(p) Then
    '                        Failed = Failed + 1
    '                        If Trim(StCol) = "" Then
    '                            StCol = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Collegeno.ToString & "(" & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString & ")"
    '                        Else
    '                            StCol = StCol & "," & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Collegeno.ToString & "(" & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString & ")"
    '                        End If
    '                    End If
    '                    exw = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Cause.ToString
    '                    If LCase(exw) = "absent" Or LCase(exw) = "average" Then
    '                        abs = abs + 1
    '                    End If

    '                Next
    '                cv = Me.Single3To8SubjectsNumbersBindingSource.Count.ToString
    '                mio = Me.InformationIDBindingSource.Count.ToString
    '                If Val(cv) > Val(mio) Then
    '                    dm = cv - mio
    '                    MsgBox("There are " & dm & " Extra then Total Stuents of Class(Set Original Information)Delete unWanted Records ...(AukError : ExtraRecord) ", MsgBoxStyle.Critical, "Contact with developer...0193-500863,01711-334201,01717-829727")
    '                    cv = Val(mio)
    '                End If
    '                re = Me.InformationIDBindingSource.Count.ToString
    '                q = re - cv
    '                t = abs + q
    '                present = re - t
    '                Pass = cv - Failed
    '                PercentPass = (100 * Val(Pass)) / cv

    '                avg = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("avg([TotalMarks])", "")
    '                max = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("max([TotalMarks])", "")
    '                min = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("Min([TotalMarks])", "")

    '                Me.AuksoftDataSet1.SummaryMain(0).SubID = SubID
    '                Me.AuksoftDataSet1.SummaryMain(0).MainID = SummaryID
    '                Me.AuksoftDataSet1.SummaryMain(0).Subject = Subx
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(5) = AukF.GivePoints2(Mvt)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(6) = AukF.GivePoints2(max)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(7) = AukF.GivePoints2(Failed)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(8) = AukF.GivePoints2(min)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(9) = AukF.GivePoints2(abs)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(10) = AukF.GivePoints2(cv - abs)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(11) = AukF.GivePoints2(avg)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(12) = AukF.GivePoints2(PercentPass)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(13) = (StCol)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(14) = cv
    '                Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)
    '            Else
    'byu:
    '                'MsgBox(SummaryMainBindingSource.Count.ToString)
    '                If Me.SummaryMainBindingSource.Count < 2 Then
    '                    Me.SummaryMainBindingSource.AddNew()
    '                    Me.SummaryMainBindingSource.EndEdit()
    '                End If
    '                If Me.SummaryMainBindingSource.Count < 2 Then GoTo byu
    '                'MsgBox(SummaryMainBindingSource.Count)

    '                a = Val(Me.AuksoftDataSet1.MarksObtaint(0).Item(7).ToString)
    '                'MsgBox(a)
    '                p = Val(Me.AuksoftDataSet1.MarksObtaint(0).Passmarks.ToString)

    '                For I = 0 To Me.Single3To8SubjectsNumbersBindingSource.Count.ToString - 1
    '                    c = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString
    '                    If Val(c) >= Val(a) Then
    '                        Mvt = Mvt + 1
    '                    End If
    '                    d = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).ThirdTermPersentiseMark.ToString
    '                    If Val(d) >= Val(a) Then
    '                        Mvt2 = Mvt2 + 1
    '                    End If
    '                    If Val(c) < Val(p) Then
    '                        Failed = Failed + 1
    '                        If Trim(StCol) = "" Then
    '                            StCol = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Collegeno.ToString & "(" & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString & ")"
    '                        Else
    '                            StCol = StCol & "," & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Collegeno.ToString & "(" & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString & ")"
    '                        End If
    '                    End If
    '                    If Val(d) < Val(p) Then
    '                        Failed2 = Failed2 + 1
    '                        If Trim(StCol2) = "" Then
    '                            StCol2 = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Collegeno.ToString & "(" & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).TotalMarks.ToString & ")"
    '                        Else
    '                            StCol2 = StCol2 & "," & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Collegeno.ToString & "(" & Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).ThirdTermPersentiseMark.ToString & ")"
    '                        End If
    '                    End If
    '                    exw = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(I).Cause.ToString
    '                    If LCase(exw) = "absent" Or LCase(exw) = "average" Then
    '                        abs = abs + 1
    '                    End If

    '                Next
    '                cv = Me.Single3To8SubjectsNumbersBindingSource.Count.ToString
    '                mio = Me.InformationIDBindingSource.Count.ToString
    '                If Val(cv) > Val(mio) Then
    '                    dm = cv - mio
    '                    MsgBox("There are " & dm & " Extra then Total Stuents of Class(Set Original Information)Delete unWanted Records ...(AukError : ExtraRecord) ", MsgBoxStyle.Critical, "Contact with developer...0193-500863,01711-334201,01717-829727")
    '                    cv = Val(mio)
    '                End If
    '                re = Me.InformationIDBindingSource.Count.ToString
    '                q = re - cv
    '                t = abs + q
    '                present = re - t

    '                Pass = Val(cv) - Failed
    '                Pass2 = Val(cv) - Failed2
    '                PercentPass = (100 * Val(Pass)) / cv
    '                'MsgBox(Pass2, , "pass")
    '                'MsgBox(Failed, , "Failed")
    '                'MsgBox(Failed2, , "Failed2")
    '                PercentPass2 = (100 * Val(Pass2)) / cv
    '                'MsgBox(PercentPass2, , "PercentPass2")
    '                avg = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("Avg([TotalMarks])", "")
    '                max = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("Max([TotalMarks])", "")
    '                min = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("Min([TotalMarks])", "")



    '                Me.AuksoftDataSet1.SummaryMain(0).SubID = SubID
    '                Me.AuksoftDataSet1.SummaryMain(0).MainID = SummaryID
    '                Me.AuksoftDataSet1.SummaryMain(0).Subject = Subx
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(5) = AukF.GivePoints2(Mvt)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(6) = AukF.GivePoints2(max)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(7) = AukF.GivePoints2(Failed)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(8) = AukF.GivePoints2(min)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(9) = AukF.GivePoints2(abs)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(10) = AukF.GivePoints2(cv - abs)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(11) = AukF.GivePoints2(avg)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(12) = AukF.GivePoints2(PercentPass)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(13) = (StCol)
    '                Me.AuksoftDataSet1.SummaryMain(0).Item(14) = cv
    '                'Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)

    '                avg = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("avg([ThirdTermPersentiseMark])", "")
    '                max = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("max([ThirdTermPersentiseMark])", "")
    '                min = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.Compute("Min([ThirdTermPersentiseMark])", "")
    '                'Me.SummaryMainBindingSource.EndEdit()
    '                'SW = 
    '                'MsgBox(SW, , 2)

    '                Me.AuksoftDataSet1.SummaryMain(1).SubID = SubID & "Convert"
    '                Me.AuksoftDataSet1.SummaryMain(1).MainID = SummaryID & "Convert"
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(4) = (Subx) & "(Convert)"
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(5) = AukF.GivePoints2(Mvt2)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(6) = AukF.GivePoints2(max)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(7) = AukF.GivePoints2(Failed2)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(8) = AukF.GivePoints2(min)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(9) = AukF.GivePoints2(abs)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(10) = AukF.GivePoints2(cv - abs)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(11) = AukF.GivePoints2(avg)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(12) = AukF.GivePoints2(PercentPass2)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(13) = (StCol2)
    '                Me.AuksoftDataSet1.SummaryMain(1).Item(14) = cv
    '                Me.SummaryMainTableAdapter.Update(Me.AuksoftDataSet1.SummaryMain)
    '            End If
    '        Catch ex As Exception
    '            'MsgBox(ex.HelpLink.ToString)
    '            Epx()
    '        Finally
    '            Beep()
    '            'If AukF.MsgTr("Do you want to Exit From Function?") = True Then
    '            '    Exit Sub
    '            'End If
    '        End Try


    '    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click

        If T3rd = False Then
            Me.Acc2ConvertBindingSource.RemoveCurrent()
        Else
            Try
                d = Me.AuksoftDataSet1.Acc2Convert(Me.Acc2ConvertBindingSource.Position).Collegeno.ToString

                Me.Acc2ConvertBindingSource.RemoveCurrent()
                er = Me.Acc2ConvertBindingSource1.Find("Collegeno", d)
                If er > -1 Then
                    Me.Acc2ConvertBindingSource1.RemoveAt(er)

                End If
                Me.Acc2ConvertBindingSource.EndEdit()
                Me.Acc2ConvertBindingSource1.EndEdit()

            Catch ex As Exception
                Epx()
            Finally
            End Try


        End If
    End Sub

    'Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.AuksoftDataSet1.SummaryMain.GetErrors
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.AuksoftDataSet1.Single3To8SubjectsNumbers.GetErrors
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.Acc2ConvertTableAdapter.GetData.GetErrors
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If T3rd = True Then
    '            Me.ViewGrid.DataSource = ""
    '            Me.ViewGrid.DataSource = Me.AuksoftDataSet2.Acc2Convert.GetErrors
    '        Else
    '            MsgBox("Click When you are editing Third termExam....", MsgBoxStyle.Critical)

    '        End If

    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.DaysOFWorksTableAdapter.GetData.GetErrors
    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    Private Sub GetErrorInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rty As String
        rty = ""
        If Me.Single3To8SubjectsNumbersTableAdapter.GetData.HasErrors = True Then
            rty = "SingleSubject"
        End If
        If Me.Acc2ConvertTableAdapter.GetData.HasErrors = True Then
            If Trim(rty) = "" Then
                rty = "TotalResult"
            Else
                rty = rty & ",TotalResult"
            End If
        End If
        If Me.MarksObtaintTableAdapter.GetData.HasErrors = True Then
            If Trim(rty) = "" Then
                rty = "MarksObtaint"
            Else
                rty = rty & ",MarksObtaint"
            End If
        End If
        If Me.DefaultConvertNumbersTableAdapter.GetData.HasErrors = True Then
            If Trim(rty) = "" Then
                rty = "DefaultConvertNumbers"
            Else
                rty = rty & ",DefaultConvertNumbers"
            End If
        End If
        'If Me.SummaryMainTableAdapter.GetData.HasErrors = True Then
        '    If Trim(rty) = "" Then
        '        rty = "Summary"
        '    Else
        '        rty = rty & ",Summary"
        '    End If
        'End If
        If Me.DaysOFWorksTableAdapter.GetData.HasErrors = True Then
            If Trim(rty) = "" Then
                rty = "DaysOFWorks"
            Else
                rty = rty & ",DaysOFWorks"
            End If
        End If
        If Trim(rty) = "" Then
            MsgBox("There is not Error in Any Table....Resume working....", MsgBoxStyle.Information)
        Else
            MsgBox("There are some error In ( " & rty & ") Tables....Please Save Other Tables Single....", MsgBoxStyle.Information)
        End If
    End Sub

    'Private Sub SingleSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.Single3To8SubjectsNumbersTableAdapter.GetData.GetChanges

    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub TotalResultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.Acc2ConvertTableAdapter.GetData.GetChanges

    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.SummaryMainTableAdapter.GetData.GetChanges

    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub DaysOfWorksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.DaysOFWorksTableAdapter.GetData.GetChanges

    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If T3rd = True Then
    '            Me.ViewGrid.DataSource = ""
    '            Me.ViewGrid.DataSource = Me.AuksoftDataSet2.Acc2Convert
    '        Else
    '            MsgBox("Click When you are editing Third TermExam....", MsgBoxStyle.Critical)

    '        End If

    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
    '    Try
    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.SummaryMainBindingSource


    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        For I = 0 To 16
            Copy1(I) = Me.AuksoftDataSet1.MarksObtaint(0).Item(7 + I).ToString
        Next
        Copy1x = True

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.MarksObtaintBindingSource.EndEdit()

        For I = 0 To 16
            Me.AuksoftDataSet1.MarksObtaint(0).Item(7 + I) = Copy1(I)
        Next
        Me.MarksObtaintBindingSource.EndEdit()
        'Copy1x = True
    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rty As String
        rty = ""

        If Me.AuksoftDataSet1.HasChanges = True Then
            rty = "Database need update(some Records are changes)..."
        End If

    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Dim MpID As String
        Dim d As Integer
        'ToolStripStatusLabel1_Click(sender, e)

        Try
            c = 100 / Me.InformationIDBindingSource.Count.ToString
            Me.CtProg.Value = 0
            Me.CtProg.Visible = True
            For I = 0 To (Me.InformationIDBindingSource.Count - 1)
                colpx = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString
                d = Me.ClassTestBindingSource.Find("Collegeno", colpx)
                'MsgBox(c)
                'Me.CollegeNoTextBox.Text = Me.CollgenoT1.Text
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
                    'ElseIf d > -1 Then
                    '    If Me.ClassTestBindingSource.Filter = "" Then
                    '        Me.AuksoftDataSet1.ClassTest(d).Subjects = Subx
                    '        Me.AuksoftDataSet1.ClassTest(d)._Class = Clx
                    '        Me.AuksoftDataSet1.ClassTest(d).Section = Secx
                    '        Me.AuksoftDataSet1.ClassTest(d).Year = Yr
                    '        Me.AuksoftDataSet1.ClassTest(d).CollegeNo = colpx
                    '        Me.AuksoftDataSet1.ClassTest(d).Cause = "None"
                    '        Me.AuksoftDataSet1.ClassTest(d).Cause2 = "None"
                    '        Me.AuksoftDataSet1.ClassTest(d).Cause3 = "None"
                    '        Me.AuksoftDataSet1.ClassTest(d).Shift = Shv
                    '        Me.AuksoftDataSet1.ClassTest(d).MainID = MpID

                    '        'Me.CollegenoTextBox.Text = Me.CollgenoComboBox.Text
                    '        'Me.ShiftTextBox.Text = Me.ComboBox5.Text
                    '        'Me.ClassTestBindingSource.EndEdit()
                    '    End If
                End If
                AukF.InsPro(Me.CtProg, c)


            Next
            Me.CtProg.Visible = False

        Catch ex As Exception
            Epx()
        Finally
            'MsgBox("ok")
        End Try

    End Sub

    Private Sub ToolStripStatusLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel4.Click, RejectCurrentItemChangeToolStripMenuItem.Click
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

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click, SaveClassTestToolStripMenuItem.Click
        Try
            Me.Validate()

            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
        Catch ex As Exception
            Epx()
            'Finally
        End Try
    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click
        Try
            Me.ClassTestBindingSource.RemoveCurrent()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RejectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If AukF.MsgTr(What & "Reject Changes of TotalSheet and Convert Sheet...?") = False Then
            Exit Sub
        End If
        If T3rd = True Then
            Me.Acc2ConvertBindingSource1.CancelEdit()
            Me.Acc2ConvertBindingSource.CancelEdit()
            Me.AuksoftDataSet1.Acc2Convert.RejectChanges()
            Me.AuksoftDataSet2.Acc2Convert.RejectChanges()
        Else
            Me.Acc2ConvertBindingSource.CancelEdit()
            Me.AuksoftDataSet1.Acc2Convert.RejectChanges()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            If T3rd = True Then
                Me.Acc2ConvertBindingSource1.EndEdit()
                Me.Acc2ConvertBindingSource.EndEdit()
                Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
                Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)
            Else
                Me.Acc2ConvertBindingSource.EndEdit()
                Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            End If
        Catch ex As Exception
            Epx()
        Finally
            Beep()

        End Try

    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStripButton8_Click(sender, e)

    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click

    End Sub

    Private Sub PrintPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPageToolStripMenuItem.Click
        'Button2_Click(sender, e)

    End Sub

    Private Sub AllCtAndSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCtAndSummaryToolStripMenuItem.Click
        Dim ji As New CrystalReport1
        ji.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = ji

    End Sub

    Private Sub ToolStripMenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem28.Click
        Try
            Me.Single3To8SubjectsNumbersBindingSource.EndEdit()
            Me.Single3To8SubjectsNumbersTableAdapter.Update(Me.AuksoftDataSet1.Single3To8SubjectsNumbers)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Me.DefaultConvertNumbersBindingSource.EndEdit()
            Me.MarksObtaintBindingSource.EndEdit()
            Me.MarksObtaintTableAdapter.Update(Me.AuksoftDataSet1.MarksObtaint)
            Me.DefaultConvertNumbersTableAdapter.Update(Me.AuksoftDataSet1.DefaultConvertNumbers)
        Catch ex As Exception
            Epx()
        Finally
            Beep()

        End Try
    End Sub

    Private Sub ToolStripMenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem21.Click
        Dim ji As New ClassTest
        ji.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = ji
    End Sub

    Private Sub ToolStripMenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem27.Click
        Dim ji As New Copy_of_ClassTest
        ji.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = ji

    End Sub

    'Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
    '    If AukF.MsgTr(What & "RejectChanges") = False Then
    '        Exit Sub
    '    End If
    '    Me.Single3To8SubjectsNumbersBindingSource.CancelEdit()
    '    Me.Single3To8SubjectsNumbersTableAdapter.Update(Me.AuksoftDataSet1.Single3To8SubjectsNumbers)

    'End Sub

    Private Sub RejectChangesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem.Click
        If AukF.MsgTr(What & "RejectChanges") = False Then
            Exit Sub
        End If
        Me.Acc2ConvertBindingSource1.CancelEdit()
        Me.Acc2ConvertBindingSource.CancelEdit()
        Me.AuksoftDataSet1.Acc2Convert.RejectChanges()
        Me.AuksoftDataSet2.Acc2Convert.RejectChanges()

    End Sub

    Private Sub SaveToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        Try
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource1.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)
        Catch ex As Exception
            Epx()
        Finally

        End Try



    End Sub

    'Private Sub ClassTestToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.AuksoftDataSet1.ClassTest


    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ClassTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        Me.ViewGrid.DataSource = ""
    '        Me.ViewGrid.DataSource = Me.AuksoftDataSet1.ClassTest.GetChanges



    '    Catch ex As Exception
    '        Epx()
    '    End Try
    'End Sub

    'Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.ViewGrid.DataSource = ""
    'End Sub

    Private Sub ToolStripStatusLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel5.Click
        AukF.DelRecAll("ClassTest", Me.ClassTestBindingSource)
        ToolStripStatusLabel1_Click(sender, e)

    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        AukF.DelRecAll("TotalResult", Me.Acc2ConvertBindingSource)
        If Trd = True Then
            AukF.DelRecAll("3rd Term Original Result", Me.Acc2ConvertBindingSource1)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        Dim ji As New WorkingDays
        ji.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = ji

        'ReportViewer.CrystalReportViewer1.SelectTab(PrintTerminal2.TabPage2.Name)
    End Sub

    Private Sub PrintBlankToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBlankToolStripMenuItem.Click
        Dim ji As New Copy_of_WorkingDays
        ji.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = ji
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

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        AukF.DelRecAll("Single Subject", Me.Single3To8SubjectsNumbersBindingSource)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Examination_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Examination.Click

    End Sub

    Private Sub ColP_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ColP.ItemClicked

    End Sub

    Private Sub AvaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvaToolStripMenuItem.Click
        Me.CauseTextBox.Text = "Average"

    End Sub

    Private Sub NoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneToolStripMenuItem.Click
        Me.CauseTextBox.Text = "None"
    End Sub

    Private Sub UnFillClassTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnFillClassTestToolStripMenuItem.Click
        Me.DataGridView1.DataSource = ""
    End Sub

    Private Sub FillClassTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillClassTestToolStripMenuItem.Click
        Me.DataGridView1.DataSource = Me.ClassTestBindingSource

    End Sub

    Private Sub FillThisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillThisToolStripMenuItem.Click
        Me.DaysOFWorksDataGridView.DataSource = Me.DaysOFWorksBindingSource

    End Sub

    Private Sub UnFillThisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnFillThisToolStripMenuItem.Click
        Me.DaysOFWorksDataGridView.DataSource = ""

    End Sub

    Private Sub Acc2ConvertDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Acc2ConvertDataGridView.CellContentClick

    End Sub

    Private Sub ToolStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip2.ItemClicked

    End Sub

    Private Sub DaysOFWorksDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DaysOFWorksDataGridView.CellContentClick

    End Sub

    Private Sub FillAllViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillAllViewToolStripMenuItem.Click
        Fill()

    End Sub

    Private Sub UnFillAllToMakeFasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnFillAllToMakeFasterToolStripMenuItem.Click
        UnFill()

    End Sub

    Private Sub SavedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavedToolStripMenuItem.Click

        If AukF.MsgTr(What & "ExitFromSoft WithSave...?") = True Then
            Saved()
            End
        End If


    End Sub

    Private Sub WithoutSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithoutSaveToolStripMenuItem.Click
        If AukF.MsgTr(What & "ExitFromSoft withoutSave...?") = True Then
            End
        End If


    End Sub

    Private Sub ClearErrorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearErrorToolStripMenuItem.Click
        AukF.ClearErrorFromDataSet(Me.AuksoftDataSet1)
        AukF.ClearErrorFromDataSet(Me.AuksoftDataSet2)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub RejectCurrentFieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectCurrentFieldToolStripMenuItem.Click
        AukF2.Single_DataRecordRefresh(Me.InformationIDBindingSource, True)

    End Sub

    Private Sub RejectWholeDataTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectWholeDataTableToolStripMenuItem.Click, ToolStripButton7.ButtonClick
        AukF2.SingleDataTable_DataRecordRefresh(Me.InformationIDBindingSource, True)
    End Sub

    Private Sub ImportsExcelSheetCopyedColumnInNumberFieldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportsExcelSheetCopyedColumnInNumberFieldToolStripMenuItem.Click
        Try
            AukF2.ReplaceInBindingSource(Me.Single3To8SubjectsNumbersBindingSource, Clipboard.GetText.Trim, 5, True, Chr(13), "", True, Me.ProgressBar2, True, False, "", True, True, False, "", "", "", False, False, "na,a,0", True, Me, True)

        Catch ex As Exception
            Epx()
        End Try
    End Sub
    Public Function Auk_Crv1()
        'MsgBox("call" & ITnt)

        If ITnt > -1 Then
            'MsgBox(EStr)

            'Try
            If EStr = "na" Then
                'MsgBox("Avg")

                Me.AuksoftDataSet1.Single3To8SubjectsNumbers(ITnt).Cause = "Average"
            ElseIf EStr = "a" Or EStr = "0" Then
                Me.AuksoftDataSet1.Single3To8SubjectsNumbers(ITnt).Cause = "Absent"

                'MsgBox("abesnt")

            End If
            'Catch ex As Exception
            '    Epx()

            'End Try
        End If


    End Function
    Private Sub ImportNumbersFromExcelSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportNumbersFromExcelSheetToolStripMenuItem.Click
        Try
            Me.DataGridView1.Visible = False
            m = CtProg.Maximum
            If Tms = 1 Then
                AukF2.ReplaceInBindingSource(Me.ClassTestBindingSource, Clipboard.GetText.Trim, "Avarage", True, Chr(13), "", True, Me.CtProg, True, False, "", True, Me.WhenImportsRowFromExcelSheetRefreshNumberToolStripMenuItem.Checked)

            ElseIf Tms = 2 Then
                AukF2.ReplaceInBindingSource(Me.ClassTestBindingSource, Clipboard.GetText.Trim, "Avarage2", True, Chr(13), "", True, Me.CtProg, True, False, "", True, Me.WhenImportsRowFromExcelSheetRefreshNumberToolStripMenuItem.Checked)

            ElseIf Tms = 3 Then
                AukF2.ReplaceInBindingSource(Me.ClassTestBindingSource, Clipboard.GetText.Trim, "Avarage3", True, Chr(13), "", True, Me.CtProg, True, False, "", True, Me.WhenImportsRowFromExcelSheetRefreshNumberToolStripMenuItem.Checked)

            End If
            CtProg.Maximum = m

        Catch ex As Exception
            Epx()
        Finally
            Me.DataGridView1.Visible = True

        End Try
    End Sub

    Private Sub AllSubjectsNumberRefeshAndSaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllSubjectsNumberRefeshAndSaveToolStripMenuItem.Click

        Dim CntClas, Aq, Abhq As Integer
        Dim Chk = Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked
        If AukF.MsgTr(What & "Refresh all Subjects Numbers and Save In Database?") = False Then
            Exit Sub
        End If
        UnFill()

        If Val(Clx) >= 3 And Val(Clx) <= 5 Then
            CntClas = 10
        Else
            CntClas = 11
        End If
        ProgressBar2.Value = 0

        ProgressBar2.Visible = True
        Me.ProgressBar2.Maximum = CntClas
        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = False
        Me.DataGridView1.Visible = False
        Aq = Me.SubjectList.SelectedIndex
        For Abhq = 0 To CntClas - 1
            Me.SubjectList.SelectedIndex = Abhq
            Opener2()
            'If I = CntClas - 1 Then
            '    Inputs(True, True)
            'Else
            '    Inputs()
            'End If
            RefreshNums()
            'ToolStripStatusLabel2_Click(sender, e)
            Saved2()

            AukF.InsPro(ProgressBar2, 1)
        Next
        Me.DataGridView1.Visible = True
        ProgressBar2.Visible = False

        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = Chk
        Me.SubjectList.SelectedIndex = Aq
        If Chk = False Then Opener()



    End Sub
    Public Function GetCol(ByVal PosSingSubs As Integer) As String
        Try
            If PosSingSubs <> -1 Then
                GetCol = Me.AuksoftDataSet1.Single3To8SubjectsNumbers(PosSingSubs).Collegeno.Trim.ToString
            Else
                GetCol = ""
            End If

        Catch ex As Exception
            GetCol = ""
        End Try
      
    End Function
    Private Sub CurrentStudentAllSubjectCauseCurrentCauseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentStudentAllSubjectCauseCurrentCauseToolStripMenuItem.Click
        Dim CntClas, Aq, Abhq As Integer
        Me.Single3To8SubjectsNumbersBindingSource.RemoveFilter()
        Dim Rw As DataRow

        Dim Chk = Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked
        If AukF.MsgTr(What & "Set Current Student all Subjects Cause = Current Cause?") = False Then
            Exit Sub
        End If
        UnFill()
        causet = Me.CauseTextBox.Text
        col = GetCol(Single3To8SubjectsNumbersBindingSource.Position)
        MsgBox(col)

        If Val(Clx) >= 3 And Val(Clx) <= 5 Then
            CntClas = 10
        Else
            CntClas = 11
        End If
        ProgressBar2.Value = 0

        ProgressBar2.Visible = True
        Me.ProgressBar2.Maximum = CntClas
        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = False
        Me.DataGridView1.Visible = False
        Aq = Me.SubjectList.SelectedIndex
        For Abhq = 0 To CntClas - 1
            Me.SubjectList.SelectedIndex = Abhq
            Opener3(col)

            'AukF2.BindFind(Me.Single3To8SubjectsNumbersBindingSource, "Collegeno", col)
            'MsgBox(ComRow)

            Me.CauseTextBox.Text = causet
            'Saved()
            Me.Validate()

            'Me.SubjectList.SelectedIndex = Abhq
            'Opener2()

            'If I = CntClas - 1 Then
            '    Inputs(True, True)
            'Else
            '    Inputs()
            'End If
            'RefreshNums()
            'ToolStripStatusLabel2_Click(sender, e)
            Saved2()

            AukF.InsPro(ProgressBar2, 1)
        Next
        Me.DataGridView1.Visible = True
        ProgressBar2.Visible = False

        Me.WhenChangeSubjectSetAllInformationsToolStripMenuItem.Checked = Chk
        Me.SubjectList.SelectedIndex = Aq
        If Chk = False Then Opener()
    End Sub

    Private Sub EditCurrentStudentInformationOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RejectChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangeToolStripMenuItem.Click
        AukF2.Single_DataRecordRefresh(Me.DaysOFWorksBindingSource, True)

    End Sub

    Private Sub EjectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjectChangesToolStripMenuItem.Click
        AukF2.SingleDataTable_DataRecordRefresh(Me.DaysOFWorksBindingSource, True)

    End Sub

    Private Sub ReplaceItemsFromExcelSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceItemsFromExcelSheetToolStripMenuItem.Click
        Try
            mx = ProgressBar1.Maximum
            AukF2.ReplaceInGrid(Me.DaysOFWorksDataGridView, Clipboard.GetText.Trim, Me.DaysOFWorksDataGridView.CurrentCell.ColumnIndex, True, Chr(13), "0", True, Me.ProgressBar1, True)
            ProgressBar1.Maximum = mx

        Catch ex As Exception
            Epx()


        End Try
    End Sub
End Class