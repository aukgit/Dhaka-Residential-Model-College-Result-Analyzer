Public Class PositionGenerator
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
    Dim Secx, DivSubID, DivSubID2 As String
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
    Dim FnumBer As String
    Dim Un, Kq, Ip, Aq, Pos As Integer
    Dim inBp() As DataRow

    Private Sub PositionGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1._3to8TotalMarks' table. You can move, or remove it, as needed.
        'Me._3to8TotalMarksTableAdapter.Fill(Me.AuksoftDataSet1._3to8TotalMarks)
        'TODO: This line of code loads data into the 'AuksoftDataSet1._3to8TotalMarks' table. You can move, or remove it, as needed.
        'Me._3to8TotalMarksTableAdapter.Fill(Me.AuksoftDataSet1._3to8TotalMarks)
        'TODO: This line of code loads data into the 'AuksoftDataSet1._3to8TotalMarks' table. You can move, or remove it, as needed.
        'Me._3to8TotalMarksTableAdapter.Fill(Me.AuksoftDataSet1._3to8TotalMarks)
        'TODO: This line of code loads data into the 'AuksoftDataSet2.Acc2Convert' table. You can move, or remove it, as needed.
        'Me.Acc2ConvertTableAdapter.Fill(Me.AuksoftDataSet2.Acc2Convert)
        ''TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        'Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)
        ''TODO: This line of code loads data into the 'AuksoftDataSet1.Acc2Convert' table. You can move, or remove it, as needed.
        'Me.Acc2ConvertTableAdapter.Fill(Me.AuksoftDataSet1.Acc2Convert)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Acc2Convert' table. You can move, or remove it, as needed.
        'Me.Acc2ConvertTableAdapter.Fill(Me.AuksoftDataSet1.Acc2Convert)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        'Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)
        AukF.XPAuk(Me)
        'inBp.DataSource = Me.AuksoftDataSet1.Acc2Convert

        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd
        Senior = Ac1Sec

        If Val(Clx) <= 5 Then
            Jonior1 = True
        Else
            Jonior1 = False

        End If
        Opener()

    End Sub
    Public Sub Opener()

        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        DivSubID = "Year(" & Yr & ")" & "ClassSec(" & Clx
        DivSubID2 = ")" & "tr(" & TR & ")Shift(" & Shv & ")"

        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
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
        If Senior = False Then
            If T3rd = True Then
                COnQua = "3rdTermConvert"
                SFC("SubID", "SubID", "Convertquality")
                STC(DivSubID, DivSubID2, COnQua)
                GSql.Sql_ORD_likeUse("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet2)
                COnQua = ""
                SFC("SubID", "SubID", "Convertquality")
                STC(DivSubID, DivSubID2, COnQua)
                LKC("A", "B")
                GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)
                sdt = Me.Acc2ConvertBindingSource1.Count + Me.Acc2ConvertBindingSource.Count
                Me.Label5.Text = "There are " & sdt & " in Class " & Clx & "."
            Else
                COnQua = ""
                SFC("SubID", "SubID", "Convertquality")
                STC(DivSubID, DivSubID2, COnQua)
                LKC("A", "B")
                'GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)
                AukF2.Db_Load("*", Me.AuksoftDataSet1.Acc2Convert, "", True, "val(CollegeNo)", False)
                'Clipboard.Clear()
                'Clipboard.SetText(Sql)

                MsgBox(Sql)
                sdt = Me.Acc2ConvertBindingSource1.Count + Me.Acc2ConvertBindingSource.Count
                Me.Label5.Text = "There are " & sdt & " in Class " & Clx & "."
            End If
        Else
            COnQua = ""
            SFC("SubID", "SubID", "Convertquality")
            STC(DivSubID, DivSubID2, COnQua)
            LKC("A", "B")
            GSql.Sql_ORD_like_false("*", "acc2convert", "val(Collegeno)", Me.AuksoftDataSet1)

            sdt = Me.Acc2ConvertBindingSource.Count
            Me.Label5.Text = "There are " & sdt & " in Class " & Clx & "."
        End If

        SFC("StudentClass", "Shift")
        STC(Clx, Shv)
        GSql.Sql_ORD_like_false("*", "informationid", "val(Collegeno)", Me.AuksoftDataSet1)
        MsgBox(Me.AuksoftDataSet1.InformationID.Rows.Count & Sql)

        'If Me.ComboBox1.SelectedIndex = 0 And T3rd = True Then

        'Else

        'End If


    End Sub
    Private Sub NamedOFForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NamedOFForm.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub Acc2ConvertBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.Acc2ConvertBindingSource.EndEdit()
        'Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)

    End Sub
    Private Sub DoJunior()
        mp = Me.ComboBox1.Text
        If mp = "Third Convert" And T3rd = True Then
            COnQua = "3rdTermConvert"
            If Me.CheckBox1.Checked = True Then
                SFC("SubID", "SubID", "Convertquality", "FailedSubjectNumber")
                EPC("", "", "", "=")
                'NMC("", "", "", "A")
                STC(DivSubID, DivSubID2, COnQua, "'0'")
            Else
                SFC("SubID", "SubID", "Convertquality")
                STC(DivSubID, DivSubID2, COnQua)
            End If
            LKC("A", "B")
            GSql.Sql_ORD_like_false("Distinct(TotalMarks)", "3to8Totalmarks", "", Me.AuksoftDataSet3)


            Me.ListBox1.DataSource = Me._3to8TotalMarksBindingSource
            perpix = 100 / Me.AuksoftDataSet2.Acc2Convert.Count
            For I = (Me.AuksoftDataSet2.Acc2Convert.Count - 1) To 0 Step -1
                c = Me.AuksoftDataSet1.Acc2Convert(I).Item("Totalmarks").ToString()
                yh = Me.ListBox1.FindStringExact(c)

                If yh = -1 Then
                    If Me.CheckBox1.Checked = True Then
                        Me.AuksoftDataSet2.Acc2Convert(I).Position = 0
                        Me.AuksoftDataSet2.Acc2Convert(I).TextPosition = 0
                        col = Me.AuksoftDataSet2.Acc2Convert(I).Collegeno.ToString
                        Aq = Me.InformationIDBindingSource.Find("collegeno", col)
                        If Aq > -1 Then
                            Me.AuksoftDataSet1.InformationID(Aq).Position_Number = 0
                            Me.AuksoftDataSet1.InformationID(Aq).Text_Position = 0
                            Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = c
                            'Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = Val(c)
                        End If

                    Else
                        MsgBox("Error are Held on Contact with Auk(0171-1334201,0193500863,01717829727)", MsgBoxStyle.Critical)
                        Me.ProgressBar1.Visible = False
                        Exit Sub
                    End If

                Else
                    Pos = Me.ListBox1.Items.Count - (Val(yh))
                    If Pos < 1 Then
                        MsgBox("Error(PositionError) are Held on Contact with Auk(0171-1334201,0193500863,01717829727)", MsgBoxStyle.Critical)

                    ElseIf Pos = 1 Then
                        tpos = "1st"
                    ElseIf Pos = 2 Then
                        tpos = "2nd"
                    ElseIf Pos = 3 Then
                        tpos = "3rd"
                    Else
                        tpos = Val(Pos) & "th"
                    End If
                    Me.AuksoftDataSet2.Acc2Convert(I).Position = Pos
                    Me.AuksoftDataSet2.Acc2Convert(I).TextPosition = tpos
                    col = Me.AuksoftDataSet2.Acc2Convert(I).Collegeno.ToString
                    Aq = Me.InformationIDBindingSource.Find("collegeno", col)
                    If Aq > -1 Then
                        Me.AuksoftDataSet1.InformationID(Aq).Position_Number = Pos
                        Me.AuksoftDataSet1.InformationID(Aq).Text_Position = tpos
                        Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = c
                        'Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = Val(c)
                    End If
                End If
                AukF.InsPro(Me.ProgressBar1, Val(perpix))
            Next
            If AukF.MsgTr(What & "Save..?") = True Then
                Saved()
            End If
            Grid.Show()
            Grid.DataGridView2.DataSource = Me.InformationIDBindingSource
            Grid.DataGridView1.DataSource = Me.Acc2ConvertBindingSource1
        Else
            perpix = 100 / Me.AuksoftDataSet1.Acc2Convert.Count
            COnQua = ""
            If Me.CheckBox1.Checked = True Then
                SFC("SubID", "SubID", "Convertquality", "FailedSubjectNumber")
                EPC("", "", "", "=")
                'NMC("", "", "", "A")

                STC(DivSubID, DivSubID2, COnQua, "'0'")
            Else
                SFC("SubID", "SubID", "Convertquality")
                STC(DivSubID, DivSubID2, COnQua)
            End If
            'MsgBox(Sql)

            LKC("A", "B")
            GSql.Sql_ORD_like_false("Distinct(TotalMarks)", "3to8Totalmarks", "", Me.AuksoftDataSet3)
            MsgBox(Sql)

            Me.ListBox1.DataSource = Me._3to8TotalMarksBindingSource
            For I = (Me.AuksoftDataSet1.Acc2Convert.Count - 1) To 0 Step -1
                c = Me.AuksoftDataSet1.Acc2Convert(I).Item("Totalmarks").ToString()
                'If Me.ListBox1.Items.Count = 0 Then
                '    Me.ProgressBar1.Visible = False
                '    Exit Sub
                'End If
                yh = Me.ListBox1.FindStringExact(c)
                If yh = -1 Then

                    If Me.CheckBox1.Checked = True Then
                        Me.AuksoftDataSet1.Acc2Convert(I).Position = 0
                        Me.AuksoftDataSet1.Acc2Convert(I).TextPosition = 0
                        col = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
                        Aq = Me.InformationIDBindingSource.Find("collegeno", col)
                        If Aq > -1 Then
                            Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = c
                            Me.AuksoftDataSet1.InformationID(Aq).Position_Number = 0
                            Me.AuksoftDataSet1.InformationID(Aq).Text_Position = 0
                            'Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = Val(c)
                        End If
                    Else
                        MsgBox("Error are Held on Contact with Auk(0171-1334201,0193500863,01717829727)", MsgBoxStyle.Critical)
                        Me.ProgressBar1.Visible = False
                        Exit Sub
                    End If
                Else
                    Pos = Me.ListBox1.Items.Count - (Val(yh))
                    If Pos < 1 Then
                        MsgBox("Error(PositionError) are Held on Contact with Auk(0171-1334201,0193500863,01717829727)", MsgBoxStyle.Critical)


                    ElseIf Pos = 1 Then
                        tpos = "1st"
                    ElseIf Pos = 2 Then
                        tpos = "2nd"
                    ElseIf Pos = 3 Then
                        tpos = "3rd"
                    Else
                        tpos = Val(Pos) & "th"
                    End If
                    Me.AuksoftDataSet1.Acc2Convert(I).Position = Pos
                    Me.AuksoftDataSet1.Acc2Convert(I).TextPosition = tpos
                    col = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
                    Aq = Me.InformationIDBindingSource.Find("collegeno", col)
                    If Aq > -1 Then
                        Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = c
                        Me.AuksoftDataSet1.InformationID(Aq).Position_Number = Pos
                        Me.AuksoftDataSet1.InformationID(Aq).Text_Position = tpos
                        'Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = Val(c)
                    End If
                End If
                AukF.InsPro(Me.ProgressBar1, Val(perpix))
            Next
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Un, Kq, Ip, Aq, Pos As Integer

        'MsgBox(T3rd)
        Grid.Close()
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = True
        If Senior = True Then
            SeniorSec()
        Else
            DoJunior()

        End If
       

        If AukF.MsgTr(What & "Save..?") = True Then
            Saved()
        End If
        If AukF2.MsgTr(What & "see the view in Grid...?") = True Then
            Grid.DataGridView2.DataSource = ""
            Grid.DataGridView1.DataSource = ""
            Grid.Show()
            Grid.DataGridView2.DataSource = Me.InformationIDBindingSource
            Grid.DataGridView1.DataSource = Me.Acc2ConvertBindingSource
            AukF2.AukOptionsOfDataGrid(Grid.DataGridView2, "", "", "2", "", "0,18,20", "")
            AukF2.AukOptionsOfDataGrid(Grid.DataGridView1, "", "", "4", "", "0,1,2,3", "")
        End If
      
        Me.ProgressBar1.Visible = False




    End Sub
    Private Sub SeniorSec()
        perpix = 100 / Me.AuksoftDataSet1.Acc2Convert.Count
        COnQua = ""
        If Me.CheckBox1.Checked = True Then
            SFC("SubID", "SubID", "Convertquality", "FailedSubjectNumber")
            EPC("", "", "", "=")
            'NMC("", "", "", "A")

            STC(DivSubID, DivSubID2, COnQua, "'0'")
        Else
            SFC("SubID", "SubID", "Convertquality")
            STC(DivSubID, DivSubID2, COnQua)
        End If

        'MsgBox(Sql)

        LKC("A", "B")
        GSql.Sql_ORD_like_false("Distinct(TotalMarks)", "3to8Totalmarks", "", Me.AuksoftDataSet3)
        'MsgBox(Sql)

        Me.ListBox1.DataSource = Me._3to8TotalMarksBindingSource
        For I = (Me.AuksoftDataSet1.Acc2Convert.Count - 1) To 0 Step -1
            c = Me.AuksoftDataSet1.Acc2Convert(I).Item("Totalmarks").ToString()
            'If Me.ListBox1.Items.Count = 0 Then
            '    Me.ProgressBar1.Visible = False
            '    Exit Sub
            'End If
            yh = Me.ListBox1.FindStringExact(c)
            If yh = -1 Then

                If Me.CheckBox1.Checked = True Then
                    Me.AuksoftDataSet1.Acc2Convert(I).Position = 0
                    Me.AuksoftDataSet1.Acc2Convert(I).TextPosition = 0
                    col = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
                    Aq = Me.InformationIDBindingSource.Find("collegeno", col)
                    If Aq > -1 Then
                        Me.AuksoftDataSet1.InformationID(Aq).Position_Number = 0
                        Me.AuksoftDataSet1.InformationID(Aq).Text_Position = 0
                        'Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = Val(c)
                    End If
                Else
                    MsgBox("Error are Held on Contact with Auk(0171-1334201,0193500863,01717829727)", MsgBoxStyle.Critical)
                    Me.ProgressBar1.Visible = False
                    Exit Sub
                End If
            Else
                Pos = Me.ListBox1.Items.Count - (Val(yh))
                If Pos < 1 Then
                    MsgBox("Error(PositionError) are Held on Contact with Auk(0171-1334201,0193500863,01717829727)", MsgBoxStyle.Critical)


                ElseIf Pos = 1 Then
                    tpos = "1st"
                ElseIf Pos = 2 Then
                    tpos = "2nd"
                ElseIf Pos = 3 Then
                    tpos = "3rd"
                Else
                    tpos = Val(Pos) & "th"
                End If
                Me.AuksoftDataSet1.Acc2Convert(I).Position = Pos
                Me.AuksoftDataSet1.Acc2Convert(I).TextPosition = tpos
                col = Me.AuksoftDataSet1.Acc2Convert(I).Collegeno.ToString
                Aq = Me.InformationIDBindingSource.Find("collegeno", col)
                If Aq > -1 Then
                    Me.AuksoftDataSet1.InformationID(Aq).Position_Number = Pos
                    Me.AuksoftDataSet1.InformationID(Aq).Text_Position = tpos
                    'Me.AuksoftDataSet1.InformationID(Aq).TotalMarks = Val(c)
                End If
            End If
            AukF.InsPro(Me.ProgressBar1, Val(perpix))
        Next

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next

        Grid.DataGridView2.DataSource = ""
        Grid.DataGridView1.DataSource = ""
        Grid.Show()
        Grid.DataGridView2.DataSource = Me.InformationIDBindingSource
        'Grid.DataGridView1.DataSource = Me.Acc2ConvertBindingSource
        AukF2.AukOptionsOfDataGrid(Grid.DataGridView2, "", "", "2", "", "0,18,20", "")
        Grid.Show()
        'Grid.DataGridView2.DataSource = Me.InformationIDBindingSource
        If Me.ComboBox1.Text = "Third Convert" And T3rd = True Then
            Grid.DataGridView1.DataSource = Me.Acc2ConvertBindingSource1
        Else
            Grid.DataGridView1.DataSource = Me.Acc2ConvertBindingSource
        End If
        AukF2.AukOptionsOfDataGrid(Grid.DataGridView1, "", "", "4", "", "0,1,2,3", "")

    End Sub

    Private Sub _3to8TotalMarksDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Public Sub Saved()
        Try
            Grid.Close()
            Me.Acc2ConvertBindingSource1.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.InformationIDBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1.Acc2Convert)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet2.Acc2Convert)
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)
        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    

    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If Me.ComboBox1.SelectedIndex = 0 And T3rd = True Then
            sdt = Me.Acc2ConvertBindingSource1.Count
            Me.Label5.Text = "There are " & sdt & " in Class " & Clx & "."
        Else
            sdt = Me.Acc2ConvertBindingSource.Count
            Me.Label5.Text = "There are " & sdt & " in Class " & Clx & "."
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Saved()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim m As New PositionReport

        AukF.Prnt(m, Me.AuksoftDataSet1)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Opener()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Strn, RvStr As String
        Dim CxI As Integer
        If Me.ListBox1.Items.Count > 0 Then
            If Me.ListBox1.SelectedIndex <> -1 Then

                Me.Label2.Visible = True
                Strn = Me.AuksoftDataSet3._3to8TotalMarks(Me.ListBox1.SelectedIndex).TotalMarks.ToString

                If Strn <> FnumBer Then
                    RvStr = ""
                    Try
                        inBp = Me.AuksoftDataSet1.Acc2Convert.Select("totalmarks='" & Strn & "'")


                        For CxI = inBp.GetLowerBound(0) To inBp.GetUpperBound(0)
                            qwz = inBp(CxI).Item("collegeno").ToString

                            If RvStr = "" Then
                                RvStr = qwz
                            Else
                                RvStr = RvStr & "," & qwz

                            End If
                            If CxI = inBp.GetUpperBound(0) Then
                                qwz = "Total(" & Val(inBp.GetUpperBound(0).ToString) + 1 & ")"

                                If RvStr = "" Then
                                    RvStr = "Not Found"
                                Else
                                    RvStr = RvStr & "." & qwz

                                End If
                            End If
                        Next


                    Catch ex As Exception
                        Me.Label2.Text = "Error Held on... Contact with Auk..."
                        Exit Sub
                    End Try
                    Me.Label2.Text = Strn & " Number(Found CollegeNo):" & RvStr
                    FnumBer = Strn

                End If

            Else
                Me.Label2.Visible = False

            End If
        Else
            Me.Label2.Visible = False

        End If
    End Sub
End Class