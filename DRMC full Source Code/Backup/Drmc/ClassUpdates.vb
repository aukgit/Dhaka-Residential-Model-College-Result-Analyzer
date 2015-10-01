Public Class ClassUpdates
    Dim COnQua As String
    Dim SubIDS As String
    Dim QMainID As String
    Dim SubIDF As String
    Public Tms As String
    Dim Working As Boolean
    Dim Job As Integer
    Dim Yr As String
    'Dim Clx As String
    'Dim Subx As String
    Dim Shv As String
    Dim TR As String
    Dim Secx As String
    'Dim SubPosX As Integer
    'Dim  As String
    'Dim DefMain, SNID, MNID As String
    'Dim T3rd As Boolean
    'Dim Vid As String
    'Dim SummaryID As String
    Dim GwRk As String = GTxt
    'Dim APos, SingPos, ObjPos, SubjPos, ClPos, GrkPos As Integer
    Dim SubjectPosition As Integer
    Dim DefCn As New DataTable
    Dim Lq As Integer
    'Dim WrkBind As New BindingSource
    'Dim SvAdp As OleDb.OleDbDataAdapter
    Dim Nine As Boolean
    'Dim SubCombo As New ComboBox
    'Dim ConvertedNumConvertSubjective As String
    'Dim ConvertedNumConvertObjective As String
    Dim undoLst As New ListBox
    Dim Xch As CheckedListBox = Me.FailedList

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            'AukF.DataFilterExtraOrdinary(Me.InformationIDBindingSource, "Collegeno,Name", Me.TextBox2.Text, ",", Me.Exact, Me.ExactFirst, Me.Anywhere, True)

            If Me.CheckBox4.Checked = True Then
                AukF.DataFilterExtraOrdinary(Me.InformationIDBindingSource, "Collegeno,Name", Me.TextBox2.Text, ",", Me.Exact, Me.ExactFirst, Me.Anywhere, True)
            Else
                AukF.DataFilterExtraOrdinary(Me.InformationIDBindingSource, "Collegeno,Name", Me.TextBox2.Text, ",", False, Me.Exact, Me.ExactFirst, Me.Anywhere)
            End If
            AukF.BindFilter(Me.InformationIDBindingSource, "Shift", Shv, "", True)

            OrdTableName = "val(Collegeno)"
            AukF.DataSetFilter(Me.InformationIDBindingSource, True, True, True, True)
            'MsgBox(Sql)

        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub InformationIDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformationIDBindingNavigatorSaveItem.Click

        Try
            Me.DataGrid1.Update()

            Me.Validate()
            Me.InformationIDBindingSource.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.AuksoftDataSet1.InformationID)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ClassUpdates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SummaryClassUpdating' table. You can move, or remove it, as needed.
        'Me.SummaryClassUpdatingTableAdapter.Fill(Me.AuksoftDataSet1.SummaryClassUpdating)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        'Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)
        Shv = Shift
        'MsgBox(Shv)
        Yr = Yearx
        'Me.ClassOptionsTableAdapter1.Fill(Me.AuksoftDataSet1.ClassOptions)

        For I = 0 To 12
            SFC("StudentClass", "Shift")
            STC(I, Shv)
            GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
            'MsgBox(Sql)

          
        Next
        SFC("Class_Section")
        'MsgBox("(Year:" & Yr & ")")
        STC("(Year:" & Yr & ")")
        GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("Year")
        STC(Yr, "")
        NMC(1)
        'ExpreC("", "is not null")

        GSql.NonCls_ORD_NonLikeCommand("*", "SummaryClassUpdating", "val([Class])", Me.AuksoftDataSet1)
        SFC("Shift")
        STC(Shv)
        GSql.NonCls_ORD_NonLikeCommand("*", "ClassOptions", "val([Class])", Me.AuksoftDataSet1)
        'MsgBox(Sql)
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.CheckBox4.Checked = True Then
                AukF.DataFilterExtraOrdinary(Me.InformationIDBindingSource, "Class,Section", Me.TextBox1.Text, ",", Me.Exact, Me.ExactFirst, Me.Anywhere, True)
            Else
                AukF.DataFilterExtraOrdinary(Me.InformationIDBindingSource, "Class,Section", Me.TextBox1.Text, ",", False, Me.Exact.Checked, Me.ExactFirst.Checked, Me.Anywhere.Checked)
            End If



            AukF.BindFilter(Me.InformationIDBindingSource, "Shift", Shv, "", True)


            OrdTableName = "val(Collegeno)"
            AukF.DataSetFilter(Me.InformationIDBindingSource, True, True, True, True)
            'MsgBox(Sql)
            'SFC("Section")
            'STC("(Year:" & Yr & ")")
            'GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
            'MsgBox(Sql)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub FindTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindTxt.TextChanged
        If Working = False Then AukF.BindGotoFind(Me.InformationIDBindingSource, "Collegeno", Me.FindTxt.Text)

    End Sub

    Public Sub New()
        Working = True
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Working = False

    End Sub

    Private Sub TB1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

      
    End Sub

    Private Sub TB2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.InformationIDBindingSource.RemoveFilter()
        'OrdTableName = "val(Collegeno)"
        'AukF.DataSetFilter(Me.InformationIDBindingSource, True, True, True, True)
        For I = 0 To 12
            SFC("StudentClass", "Shift")
            STC(I, Shv)
            GSql.NonCls_ORD_NonLikeCommand("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
            'MsgBox(Sql)
        Next
        SFC("Class_Section")
        STC("(Year:" & Yr & ")")
        GSql.Sql_NonCls_Ord_like_From_First("*", "InformationID", "val(Collegeno)", Me.AuksoftDataSet1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ABs, Avg, Fail As Integer
        Me.ProgressBar1.Visible = True
        Me.ProgressBar1.Maximum = Me.AuksoftDataSet1.InformationID.Rows.Count - 1
        Me.FailedList.Items.Clear()
        Me.AverageList.Items.Clear()
        Me.AbsentList.Items.Clear()

        For I = 0 To Me.AuksoftDataSet1.InformationID.Rows.Count - 1
            col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString

            ABs = Val(Me.AuksoftDataSet1.InformationID.Rows(I).Item("absentsubs").ToString)
            Avg = Val(Me.AuksoftDataSet1.InformationID.Rows(I).Item("avgsubs").ToString)
            Fail = Val(Me.AuksoftDataSet1.InformationID.Rows(I).Item("failsubs").ToString)
            If ABs > 0 Then
                AukF.UniqueAdd(Me.AbsentList, col)
            End If
            If Avg > 0 Then
                AukF.UniqueAdd(Me.AverageList, col)
            End If

            If Fail > 0 Then
                AukF.UniqueAdd(Me.FailedList, col)
            End If
            AukF.InsPro(Me.ProgressBar1, 1)

        Next
        Xch = Me.AverageList
        'SelectAllToolStripMenuItem1_Click(sender, e)
        undoLst.Items.Clear()
        For I = 0 To Xch.Items.Count - 1
            undoLst.Items.Add(Xch.GetItemChecked(I))
            Xch.SetItemChecked(I, True)
        Next

        Xch = Me.FailedList
        Me.ProgressBar1.Visible = False
        Me.ProgressBar1.Value = 0

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub AverageList_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles AverageList.MouseEnter, FailedList.MouseEnter, AbsentList.MouseEnter, FailedList.MouseHover, AverageList.MouseHover, AbsentList.MouseHover
        If sender.SelectedIndex > -1 Then
            snu = sender.Items.Item(sender.SelectedIndex)

        End If
        If AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "name") = True Then

            Me.NameField.Text = WGeT
            AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "class")
            c = WGeT
            AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "section")
            s = WGeT
            se = c & "-" & s
            Me.ClxSec.Text = se

        End If

    End Sub

    Private Sub AverageList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ToolStripLabel4.Text = Me.InformationIDBindingSource.Count
        If Val(Me.ToolStripLabel4.Text) <= 0 Then
            Me.ToolStripLabel4.ForeColor = Color.Red
        Else
            Me.ToolStripLabel4.ForeColor = Color.Black
        End If
        If TypeOf (Xch) Is CheckedListBox Then
            Xch.CheckOnClick = Me.CheckBox7.Checked

        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        If AukF.MsgTr(What & "Refresh all... Database Now....?") = True Then
            Me.InformationIDBindingSource.RemoveFilter()
            Me.InformationIDBindingSource.CancelEdit()
            Me.AuksoftDataSet1.RejectChanges()

        End If
    End Sub

    Private Sub aukCheckListClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FailedList.Click, AverageList.Click, AbsentList.Click
        Xch = sender

    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem1.Click
        If AukF.MsgTr(WhatDoso) = True Then
            undoLst.Items.Clear()
            For I = 0 To Xch.Items.Count - 1
                undoLst.Items.Add(Xch.GetItemChecked(I))
                Xch.SetItemChecked(I, True)
            Next
        End If
    End Sub

    Private Sub UnSelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnSelectAllToolStripMenuItem.Click
        If AukF.MsgTr(WhatDoso) = True Then
            undoLst.Items.Clear()
            For I = 0 To Xch.Items.Count - 1
                undoLst.Items.Add(Xch.GetItemChecked(I))
                Xch.SetItemChecked(I, False)
            Next
        End If
    End Sub

    Private Sub InvertSelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertSelectToolStripMenuItem.Click
        If AukF.MsgTr(WhatDoso) = True Then
            undoLst.Items.Clear()
            For I = 0 To Xch.Items.Count - 1
                undoLst.Items.Add(Xch.GetItemChecked(I))
                Xch.SetItemChecked(I, AukF.BoolInvert(Xch.GetItemChecked(I)))
            Next
        End If
    End Sub

    Private Sub UndoSelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoSelectToolStripMenuItem.Click
        If AukF.MsgTr(WhatDoso) = True Then
            'undoLst.Items.Clear()
            If Xch.Items.Count <> Xch.Items.Count Then
                MsgBox("This Checked Box Items are not Equals to Before Memory CheckBox Items.....!", MsgBoxStyle.Critical, "Error to undo (Select other ListBox Please)....")
                Exit Sub

            End If
            For I = 0 To Xch.Items.Count - 1
                'undoLst.Items.Add(Xch.GetItemChecked(I))
                Xch.SetItemChecked(I, undoLst.Items.Item(I))
            Next
        End If
    End Sub

    Private Sub TB1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB1.TextChanged
        Dim c As Integer
        If AukF.FindInObjectAndSelect(Me.FailedList, TB1, Me.FindExactWordInText.Checked, False) = True Then
            If Me.CheckBox6.Checked = True Then
                c = Me.FailedList.SelectedIndex
                If Val(c) > -1 Then
                    Me.FailedList.SetItemChecked(c, AukF.BoolInvert(Me.FailedList.GetItemChecked(c)))
                End If
            Else
                If Me.CheckBox5.Checked = True Then
                    c = Me.FailedList.SelectedIndex
                    If Val(c) > -1 Then
                        Me.FailedList.SetItemChecked(c, True)

                    End If
                End If
            End If
        End If




    End Sub

    Private Sub TB2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB2.TextChanged
        If AukF.FindInObjectAndSelect(Me.AverageList, TB1, Me.FindExactWordInText.Checked, False) = True Then
            If Me.CheckBox6.Checked = True Then
                c = Me.AverageList.SelectedIndex
                If Val(c) > -1 Then
                    Me.AverageList.SetItemChecked(c, AukF.BoolInvert(Me.AverageList.GetItemChecked(c)))
                End If
            End If
            If Me.CheckBox5.Checked = True Then
                c = Me.AverageList.SelectedIndex
                If Val(c) > -1 Then
                    Me.AverageList.SetItemChecked(c, True)

                End If
            End If
        End If
 

    End Sub

    Private Sub TB3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB3.TextChanged
        If AukF.FindInObjectAndSelect(Me.AbsentList, TB1, Me.FindExactWordInText.Checked, False) = True Then
            If Me.CheckBox6.Checked = True Then
                c = Me.AbsentList.SelectedIndex
                If Val(c) > -1 Then
                    Me.AbsentList.SetItemChecked(c, AukF.BoolInvert(Me.AbsentList.GetItemChecked(c)))
                End If
            End If
            If Me.CheckBox5.Checked = True Then
                c = Me.AbsentList.SelectedIndex
                If Val(c) > -1 Then
                    Me.AbsentList.SetItemChecked(c, True)

                End If
            End If
        End If
   
    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox1.KeyDown

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim Str As String = ""
        Dim Ln As New ListBox
        AukF.CutWordLetter(Ln, Me.TextBox3.Text, ",", True, True)
        For I = 0 To Ln.Items.Count - 1
            col = Ln.Items.Item(I)
            If AukF.BindFind(Me.InformationIDBindingSource, "Collegeno", col) = True Then
                AukF.UniqueAdd(Me.ListBox1, col)
            Else
                Str = Str & col & vbCrLf
            End If
        Next
        If Str.Trim <> "" Then
            MsgBox(Str.ToUpper, MsgBoxStyle.Information, "Now Filtered Database Didn't Have this collegeno...")

        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AukF.DelItemsFromList(Me.ListBox1, Me.TextBox3.Text, ",")

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AukF.LstDeleteSelAllItems(Me.ListBox1)

    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.ListBox1.SelectedItems.Clear()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.ListBox1.Items.Clear()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim Clx, Sx As String
        Me.ToolStripProgressBar2.Visible = True
        Me.ToolStripProgressBar2.Maximum = Me.ListBox1.Items.Count - 1
        For I = 0 To Me.ListBox1.Items.Count - 1
            If AukF.BindFindTxT(Me.InformationIDBindingSource, "Collegeno", Me.ListBox1.Items.Item(I), "Collegeno") = True Then
                clx = Me.AuksoftDataSet1.InformationID(ComRow).Item("Class").ToString
                'MsgBox(clx)

                sx = Me.AuksoftDataSet1.InformationID(ComRow).Item("Section").ToString
                'MsgBox(sx)
                If AukF.FindTxt(LCase(clx), "t.c") = False Then
                    Me.AuksoftDataSet1.InformationID(ComRow).StudentClass = "(T.C) In Class" & "(" & Clx & ")"
                    Me.AuksoftDataSet1.InformationID(ComRow).Class_Section = "(Year:" & Yr & ")" & "(" & UCase(Sx) & ")"


                End If
               
            End If
            AukF.InsPro(Me.ToolStripProgressBar2, 1)
        Next
        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = False

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim m As New StudentsClass

        AukF.Prnt(m, Me.AuksoftDataSet1)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Ln, Ln2 As New ListBox
        AukF.MaxCountNumListBox(Me.FailedList, Me.AverageList, Me.AbsentList)

        'mn = Ln.TopIndex.MaxValue.ToString
        'MsgBox(mn)
        Me.ToolStripProgressBar2.Visible = True
        Me.ToolStripProgressBar2.Maximum = WGeT
        For I = 0 To WGeT - 1
            If AukF.GetIndexInOrNot(Me.FailedList, I) = True Then
                If Me.FailedList.GetItemChecked(I) = False Then
                    AukF.UniqueAdd(Me.ListBox1, WGeT)
                Else
                    AukF.UniqueAdd(Ln2, WGeT)
                End If
            End If
            If AukF.GetIndexInOrNot(Me.AverageList, I) = True Then
                If Me.AverageList.GetItemChecked(I) = False Then
                    AukF.UniqueAdd(Me.ListBox1, WGeT)
                Else
                    AukF.UniqueAdd(Ln2, WGeT)
                End If
            End If
            If AukF.GetIndexInOrNot(Me.AbsentList, I) = True Then
                If Me.AbsentList.GetItemChecked(I) = False Then
                    AukF.UniqueAdd(Me.ListBox1, WGeT)
                Else
                    AukF.UniqueAdd(Ln2, WGeT)
                End If
            End If
            AukF.InsPro(Me.ToolStripProgressBar2, 1)
        Next
        If Me.CheckBox8.Checked = True Then
            For I = 0 To Ln2.Items.Count - 1
                If AukF.FindInObjectAndSelect(Me.ListBox1, Ln2.Items.Item(I), True, False, False) = True Then
                    Me.ListBox1.Items.RemoveAt(ComRow)

                End If
            Next
        End If
  
        Me.ToolStripProgressBar2.Value = 0

        Me.ToolStripProgressBar2.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If AukF.MsgTr(What & "Update students Class Step+1...Eg:If Class =7 ... If No Absent and Fail then Class = 8...") = False Then
        '    Exit Sub
        'End If
        'Button2_Click(sender, e)
        'For I = 0 To Me.InformationIDBindingSource.Count - 1
        '    col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString()
        '    clx = Me.AuksoftDataSet1.InformationID(I).StudentClass.ToString()
        '    sx = Me.AuksoftDataSet1.InformationID(I).Item("Section").ToString()
        '    avg = Me.AuksoftDataSet1.InformationID(I).Item("AvgSubs").ToString()
        '    abs = Me.AuksoftDataSet1.InformationID(I).Item("absentSubs").ToString()
        '    fail = Me.AuksoftDataSet1.InformationID(I).Item("failSubs").ToString()
        '    If Val(abs) + Val(fail) = 0 Then
        '        If IsNumeric(clx) = True Then
        '            If Val(clx) = 10 Then
        '                Me.AuksoftDataSet1.InformationID(I).StudentClass = "(S.S.C),(" & Yr & ")"
        '            ElseIf Val(clx) = 12 Then
        '                Me.AuksoftDataSet1.InformationID(I).StudentClass = "(H.S.C),(" & Yr & ")"
        '            Else
        '                Me.AuksoftDataSet1.InformationID(I).StudentClass = Val(clx) + 1
        '            End If

        '        End If
        '    End If
        'Next
        Dim Vnx, Clx As String

        Dim ReUp As Boolean
        Dim CntUp As Integer
        Dim Gettxt, SumPos, CLx2, Sx, Sx2 As String
        Dim LstBox As New ListBox
        Dim InPT As Integer = 0

        LstBox.Items.Clear()

        If AukF.MsgTr(What & "Update students Class Step+1...Eg:If Class = 7 ... If No Absent and Fail then Class = 8...") = False Then
            Exit Sub
        End If


        Try
            For I = (Me.SummaryClassUpdatingBindingSource.Count - 1) To 0 Step -1
                Me.SummaryClassUpdatingBindingSource.RemoveAt(I)
            Next
        Catch ex As Exception
            'Epx()
            Exit Try
        End Try
    
        Try
            Me.SummaryClassUpdatingBindingSource.EndEdit()
            Me.SummaryClassUpdatingTableAdapter.Update(Me.AuksoftDataSet1.SummaryClassUpdating)
        Catch ex As Exception
            Epx()
        End Try
        For I = 0 To Me.AuksoftDataSet1.ClassOptions.Count - 1
            Clx = Me.AuksoftDataSet1.ClassOptions(I).Item("Class").ToString
            sx = Me.AuksoftDataSet1.ClassOptions(I).Item("Section").ToUpper
            MainID = Clx & sx & Yr & Shv
            cng = Clx
            mln = "(class like '*" & UCase(cng) & "*' and Section like '*" & UCase(Sx) & "*')"
            'Me.AuksoftDataSet1.CaseSensitive = False
            total = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln)
            If Val(total) > 0 Then
                If AukF.BindFind(Me.SummaryClassUpdatingBindingSource, "MainID", MainID) = False Then
                    Me.SummaryClassUpdatingBindingSource.AddNew()
                    Me.SummaryClassUpdatingBindingSource.EndEdit()
                    ComRow = Me.SummaryClassUpdatingBindingSource.Position
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).MainID = MainID
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow)._Class = Clx
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Section = Sx
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Year = Yr
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Shift = Shv
                End If
                tc = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", "(class = '(T.C) In Class(" & cng & ")') and Section like '*" & Sx & "*'")
                abs = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln & " and absentsubs > 0")
                avg = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln & " and avgsubs > 0")
                fail = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln & " and failsubs > 0")
                'MsgBox(total & vbCrLf & tc & vbCrLf & abs & vbCrLf & avg & vbCrLf & abs & vbCrLf & MainID, , mln)
                If AukF.BindFind(Me.SummaryClassUpdatingBindingSource, "MainID", MainID) = True Then
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).TotalStudents = Val(total)
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).TC_StudentsNum = Val(tc)
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).AbsentStudents = Val(abs)
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).AverageStudents = Val(avg)
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).FailStudents = Val(fail)
                End If
            End If
        Next

        'For I = 0 To LstBox.Items.Count - 1
        '    'MsgBox(I, , LstBox.Items.Item(I).ToString)
        '    t = LstBox.Items.Item(I).ToString
        '    Clx = AukF.CutTxtGet(t, ",", 1)
        '    sx = AukF.CutTxtGet(t, ",", 2)
        '    MainID = Clx & sx & Yr & Shv
        '    'mln = "((([class] = '" & Val(Clx) + 1 & "') or ([class] = '(T.C) In Class(" & Val(Clx) + 1 & ")') ) and (Section='*" & sx & "*'))"
        '    If Val(Clx) <> 0 Then
        '        If Val(Clx) = 10 Then
        '            cng = "S.S.C"
        '        ElseIf Val(Clx) = 12 Then
        '            cng = "H.S.C"
        '        Else
        '            If IsNumeric(Clx) = True Then
        '                cng = Val(Clx) + 1
        '            End If


        '        End If
        '        'mln = "((([class]='" & cng & "') or ([class]='(T.C) In Class(" & cng & ")')) and (Section='%" & UCase(sx) & "%'))"


        'Next

        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = True
        Me.ToolStripProgressBar2.Maximum = Me.InformationIDBindingSource.Count
        Button2_Click(sender, e)
        For I = 0 To Me.InformationIDBindingSource.Count - 1
            ReUp = False
            col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString()
            clx = Me.AuksoftDataSet1.InformationID(I).StudentClass.ToString()
            sx = Me.AuksoftDataSet1.InformationID(I).Item("Section").ToString
            If Val(Clx) <> 0 Then
                AukF.UniqueAdd(LstBox, Clx & "," & sx)
            End If





            tcnum = Me.AuksoftDataSet1.InformationID(I).Item("class").ToString()
            If AukF.FindTxt(LCase(tcnum), "t.c") = True Then
                tcnum = 1
                CLx2 = Clx.Replace("(T.C) In Class(", "")
                CLx2 = CLx2.Replace(")", "")
                Sx = Sx.Replace("(Year:" & Yr & ")(", "")
                Sx = Sx.Replace(")", "")
            Else
                tcnum = 0
                CLx2 = Clx
            End If
            MainID = Clx2 & sx & Yr & Shv
            avg = Me.AuksoftDataSet1.InformationID(I).Item("AvgSubs").ToString()
            abs = Me.AuksoftDataSet1.InformationID(I).Item("absentSubs").ToString()
            fail = Me.AuksoftDataSet1.InformationID(I).Item("failSubs").ToString()
            If Me.CheckBox2.Checked = True And Me.CheckBox3.Checked = True Then
                Vnx = Val(abs) + Val(fail)
            ElseIf Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False Then
                Vnx = 0
            ElseIf Me.CheckBox2.Checked = True Then
                Vnx = Val(abs)
            ElseIf Me.CheckBox3.Checked = True Then
                Vnx = Val(fail)
            End If
            If Vnx = 0 Then
                If Val(Clx) = 10 Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = "(S.S.C),(" & Yr & ")"
                    ReUp = True
                ElseIf Val(Clx) = 12 Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = "(H.S.C),(" & Yr & ")"
                    ReUp = True
                ElseIf IsNumeric(Clx) = True Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = Val(Clx) + 1
                    ReUp = True

                End If
            End If

            If ReUp = True Then
                If AukF.BindFind(Me.SummaryClassUpdatingBindingSource, "MainID", MainID) = True Then
                    avg = Me.AuksoftDataSet1.InformationID(I).Item("AvgSubs").ToString()
                    abs = Me.AuksoftDataSet1.InformationID(I).Item("absentSubs").ToString()
                    fail = Me.AuksoftDataSet1.InformationID(I).Item("failSubs").ToString()
                    Gettxt = Val(Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdateStudents").ToString)
                    Gettxt = Val(Gettxt) + 1
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).UpdateStudents = Val(Gettxt)
                    If Val(fail) > 0 Then
                        Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedFailStudents").ToString
                        AukF.StrNullAndWithAdd(Gettxt, col & "(" & fail & ")", "," & col & "(" & fail & ")")
                        Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedFailStudents") = WGeT
                    End If
                    If Val(abs) > 0 Then
                        Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAbsentStudents").ToString
                        AukF.StrNullAndWithAdd(Gettxt, col & "(" & abs & ")", "," & col & "(" & abs & ")")
                        Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAbsentStudents") = WGeT
                    End If
                    If Val(avg) > 0 Then
                        Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAverageStudents").ToString
                        AukF.StrNullAndWithAdd(Gettxt, col & "(" & avg & ")", "," & col & "(" & avg & ")")
                        Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAverageStudents") = WGeT

                    End If
                Else
                    Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("NonUpdateStudents").ToString
                    AukF.StrNullAndWithAdd(Gettxt, col & "(" & Clx & ")", "," & col & "(" & Clx & ")")
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("NonUpdateStudents") = WGeT
                End If




            End If
            If Val(tcnum) > 0 Then
                If AukF.BindFind(Me.SummaryClassUpdatingBindingSource, "MainID", MainID) = True Then
                    If AukF.FindTxt(LCase(Clx), LCase("t.c")) = True Then
                        Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("TC Students Collection").ToString
                        AukF.StrNullAndWithAdd(Gettxt, col, "," & col)
                        Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("TC Students Collection") = WGeT
                    End If
                End If
            End If

            Me.SummaryClassUpdatingBindingSource.EndEdit()
            AukF.InsPro(Me.ToolStripProgressBar2, 1)

        Next
        'MsgBox(LstBox.Items.Count)

        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = False
        Try
            Me.SummaryClassUpdatingBindingSource.EndEdit()
            Me.SummaryClassUpdatingTableAdapter.Update(Me.AuksoftDataSet1.SummaryClassUpdating)
        Catch ex As Exception
            Epx()

        End Try

        'End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click


        Dim Vnx, Clx As String

        Dim ReUp As Boolean
        Dim CntUp As Integer
        Dim Gettxt, SumPos As String
        Dim LstBox As New ListBox
        Dim InPT As Integer = 0

        LstBox.Items.Clear()

        If AukF.MsgTr(What & "Update students Class Step-1...Eg:If Class = 7 ... If No Absent and Fail then Class = 6...") = False Then
            Exit Sub
        End If


        Try
            For I = 0 To Me.SummaryClassUpdatingBindingSource.Count - 1
                Me.SummaryClassUpdatingBindingSource.RemoveAt(I)
            Next
        Catch ex As Exception
            Exit Try
        End Try

        Try
            Me.SummaryClassUpdatingBindingSource.EndEdit()
            Me.SummaryClassUpdatingTableAdapter.Update(Me.AuksoftDataSet1.SummaryClassUpdating)
        Catch ex As Exception
            Epx()
        End Try



        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = True
        Me.ToolStripProgressBar2.Maximum = Me.InformationIDBindingSource.Count
        Button2_Click(sender, e)
        For I = 0 To Me.InformationIDBindingSource.Count - 1
            ReUp = False
            col = Me.AuksoftDataSet1.InformationID(I).CollegeNo.ToString()
            Clx = Me.AuksoftDataSet1.InformationID(I).StudentClass.ToString()
            sx = Me.AuksoftDataSet1.InformationID(I).Item("Section").ToString()
            'If Val(Clx) <> 0 Then
            '    AukF.UniqueAdd(LstBox, Clx & "," & sx)
            'End If

            MainID = Clx & sx & Yr & Shv


            avg = Me.AuksoftDataSet1.InformationID(I).Item("AvgSubs").ToString()
            abs = Me.AuksoftDataSet1.InformationID(I).Item("absentSubs").ToString()
            fail = Me.AuksoftDataSet1.InformationID(I).Item("failSubs").ToString()
            If Me.CheckBox2.Checked = True And Me.CheckBox3.Checked = True Then
                Vnx = Val(abs) + Val(fail)
            ElseIf Me.CheckBox2.Checked = False And Me.CheckBox3.Checked = False Then
                Vnx = 0
            ElseIf Me.CheckBox2.Checked = True Then
                Vnx = Val(abs)
            ElseIf Me.CheckBox3.Checked = True Then
                Vnx = Val(fail)
            End If
            If Vnx = 0 Then
                If IsNumeric(Clx) = True Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = Val(Clx) - 1
                    ReUp = True
                ElseIf AukF.FindTxt(LCase(Clx), "h.s.c") = True Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = 12
                    ReUp = True
                ElseIf AukF.FindTxt(LCase(Clx), "s.s.c") = True Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = 10
                    ReUp = True
                Else
                    'MsgBox("Error & Class:" & Clx)
                    'Exit For
                End If
            End If

            If ReUp = True Then
                avg = Me.AuksoftDataSet1.InformationID(I).Item("AvgSubs").ToString()
                abs = Me.AuksoftDataSet1.InformationID(I).Item("absentSubs").ToString()
                fail = Me.AuksoftDataSet1.InformationID(I).Item("failSubs").ToString()
                Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdateStudents").ToString
                Gettxt = Val(Gettxt) + 1
                Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).UpdateStudents = Gettxt
                If Val(fail) > 0 Then
                    Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedFailStudents").ToString
                    AukF.StrNullAndWithAdd(Gettxt, col & "(" & fail & ")", "," & col & "(" & fail & ")")
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedFailStudents") = WGeT
                End If
                If Val(abs) > 0 Then
                    Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAbsentStudents").ToString
                    AukF.StrNullAndWithAdd(Gettxt, col & "(" & abs & ")", "," & col & "(" & abs & ")")
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAbsentStudents") = WGeT
                End If
                If Val(avg) > 0 Then
                    Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAverageStudents").ToString
                    AukF.StrNullAndWithAdd(Gettxt, col & "(" & avg & ")", "," & col & "(" & avg & ")")
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("UpdatedAverageStudents") = WGeT

                End If
            Else

                If AukF.FindTxt(LCase(Clx), LCase("t.c")) = True Then
                    Gettxt = Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("TC Students Collection").ToString
                    AukF.StrNullAndWithAdd(Gettxt, col, "," & col)
                    Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).Item("TC Students Collection") = WGeT
                End If

            End If

            Me.SummaryClassUpdatingBindingSource.EndEdit()
            AukF.InsPro(Me.ToolStripProgressBar2, 1)

        Next
        'MsgBox(LstBox.Items.Count)
        'For I = 0 To LstBox.Items.Count - 1
        '    'MsgBox(I, , LstBox.Items.Item(I).ToString)
        '    t = LstBox.Items.Item(I).ToString
        '    Clx = AukF.CutTxtGet(t, ",", 1)
        '    sx = AukF.CutTxtGet(t, ",", 2)
        '    MainID = Clx & sx & Yr & Shv
        '    'mln = "((([class] = '" & Val(Clx) + 1 & "') or ([class] = '(T.C) In Class(" & Val(Clx) + 1 & ")') ) and (Section='*" & sx & "*'))"
        '    If Val(Clx) <> 0 Then
        '        If Val(Clx) = "S.S.C Then" Then
        '            cng = "S.S.C"
        '        ElseIf Val(Clx) = 12 Then
        '            cng = "H.S.C"
        '        Else
        '            cng = Val(Clx) + 1

        '        End If
        '        mln = "([class]='" & cng & "'" & " and (Section='" & UCase(sx) & "'))"
        '        'Me.AuksoftDataSet1.CaseSensitive = False
        '        total = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln)
        '        tc = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", "(class like '(T.C) In Class(" & Val(Clx) + 1 & ")') and (Section='*" & sx & "*')")
        '        abs = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln & " and (absentsubs > 0)")
        '        avg = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln & " and (avgsubs > 0)")
        '        fail = Me.AuksoftDataSet1.InformationID.Compute("count(collegeno)", mln & " and (failsubs > 0)")
        '        'MsgBox(total & vbCrLf & tc & vbCrLf & abs & vbCrLf & avg & vbCrLf & abs & vbCrLf & MainID, , mln)
        '        If AukF.BindFind(Me.SummaryClassUpdatingBindingSource, "MainID", MainID) = True Then
        '            Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).TotalStudents = total
        '            Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).TC_StudentsNum = tc
        '            Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).AbsentStudents = abs
        '            Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).AverageStudents = avg
        '            Me.AuksoftDataSet1.SummaryClassUpdating(ComRow).FailStudents = fail
        '        End If
        '    End If

        'Next
        Me.ToolStripProgressBar2.Value = 0
        Me.ToolStripProgressBar2.Visible = False
        Try
            Me.SummaryClassUpdatingBindingSource.EndEdit()
            Me.SummaryClassUpdatingTableAdapter.Update(Me.AuksoftDataSet1.SummaryClassUpdating)
        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub AbsentList_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles AbsentList.MouseMove, FailedList.MouseMove, AverageList.MouseMove
        If sender.SelectedIndex > -1 Then
            snu = sender.Items.Item(sender.SelectedIndex)

        End If
        If AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "name") = True Then

            Me.NameField.Text = WGeT
            AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "class")
            c = WGeT
            AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "section")
            s = WGeT
            se = c & "-" & s
            Me.ClxSec.Text = se

        End If
    End Sub

    Private Sub FailedList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FailedList.SelectedIndexChanged, AverageList.SelectedIndexChanged, AbsentList.SelectedIndexChanged
        If sender.SelectedIndex > -1 Then
            snu = sender.Items.Item(sender.SelectedIndex)

        End If
        If AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "name") = True Then

            Me.NameField.Text = WGeT
            AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "class")
            c = WGeT
            AukF.BindFindTxT(Me.InformationIDBindingSource, "collegeno", snu, "section")
            s = WGeT
            se = c & "-" & s
            Me.ClxSec.Text = se

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.DataGrid1.ReadOnly = Me.CheckBox1.Checked

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim Str As String
        Str = InputBox("Type T.C Students (Class,Year,Section)", "Open T.C Students Record", Str)
        If Str.Trim <> "" Then
            AukF.CutTxtGet(Str, ",", 1)
            If WGeT.Trim <> "" Then
                Me.TextBox1.Text = "(T.C) In Class(" & WGeT & ")"
            End If
            AukF.CutTxtGet(Str, ",", 2)
            If WGeT.Trim <> "" Then
                Me.TextBox1.Text = Me.TextBox1.Text & ",(Year:" & WGeT & ")"
            End If
            AukF.CutTxtGet(Str, ",", 3)
            If WGeT.Trim <> "" Then
                Me.TextBox1.Text = Me.TextBox1.Text & "(" & WGeT & ")"
            End If
            Me.ExactFirst.Checked = True
        End If

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub AbsentList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SummaryOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummaryOnlyToolStripMenuItem.Click
        Dim m As New ClassUpdateSummary
        AukF.Prnt(m, Me.AuksoftDataSet1)

    End Sub

    Private Sub ShowMenuContest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.ContextMenuStrip1.Show(Me.Cursor.Position.X, Me.Cursor.Position.Y)


    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click


        If AukF.MsgTr("Are you want to back T.C Students...?") = True Then
            Button2_Click(sender, e)
            For I = 0 To Me.InformationIDBindingSource.Count - 1
                clx = Me.AuksoftDataSet1.InformationID(I).Item("Class").ToString
                If AukF.FindTxt(clx, "(T.C) In Class(") = True Then
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = Me.AuksoftDataSet1.InformationID(I).StudentClass.Replace("(T.C) In Class(", "")
                    Me.AuksoftDataSet1.InformationID(I).StudentClass = Me.AuksoftDataSet1.InformationID(I).StudentClass.Replace(")", "")
                    Me.AuksoftDataSet1.InformationID(I).Class_Section = Me.AuksoftDataSet1.InformationID(I).Class_Section.Replace("(Year:" & Yr & ")(", "")
                    Me.AuksoftDataSet1.InformationID(I).Class_Section = Me.AuksoftDataSet1.InformationID(I).Class_Section.Replace(")", "")
                End If
            Next
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6_Click(sender, e)

        End If
        If e.Modifiers = Keys.Control Then
            If e.KeyCode = Keys.D Then
                Button8_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class