Imports Drmc_DatabaseSoft_by_Auk.AukMod


Public Class AukFunC
    Dim PrVI As Integer
    Dim Iw, Kpl, Knd, KrX As Integer


    Public Function ConTOAsc(ByVal Txt As String, ByVal Expresion As String, ByVal WhichNum As String) As String
        Dim Str As String = ""
        For Iw = 1 To Len(Txt)
            n = Asc(Mid(Txt, Iw, 1))
            'MsgBox(n)
            If Expresion = "+" Then
                n = Val(n) + Val(WhichNum)
            ElseIf Expresion = "-" Then
                n = Val(n) - Val(WhichNum)
            ElseIf Expresion = "*" Then
                n = Val(n) * Val(WhichNum)
            ElseIf Expresion = "/" Then
                n = Val(n) / Val(WhichNum)
            End If
            Str = Str & n
        Next
        ConTOAsc = Str
    End Function
    Public Function ConTOAsc(ByVal Txt As String, ByVal Expresion As String, ByVal WhichNum As String, ByVal AlsoDoWith As Boolean) As String
        Dim Str As String = ""
        For Iw = 1 To Len(Txt)
            n = Asc(Mid(Txt, Iw, 1))
            'MsgBox(n)
            If AlsoDoWith = True Then
                If Expresion = "+" Then
                    n = Val(n) + Val(WhichNum)
                ElseIf Expresion = "-" Then
                    n = Val(n) - Val(WhichNum)
                ElseIf Expresion = "*" Then
                    n = Val(n) * Val(WhichNum)
                ElseIf Expresion = "/" Then
                    n = Val(n) / Val(WhichNum)
                End If
                Str = Val(Val(Str) + Val(n))
            Else
                If Expresion = "+" Then
                    n = Val(n) + Val(WhichNum)
                ElseIf Expresion = "-" Then
                    n = Val(n) - Val(WhichNum)
                ElseIf Expresion = "*" Then
                    n = Val(n) * Val(WhichNum)
                ElseIf Expresion = "/" Then
                    n = Val(n) / Val(WhichNum)
                End If
                Str = Str & n
            End If


        Next
        ConTOAsc = Str
    End Function
    Public Function Prnt(ByVal MRpt As Object, ByVal Dset As DataSet)
        Dim m As New Object
        m = MRpt
        Try
            m.Database.Tables(0).SetDataSource(Dset)
            ReportViewer.Show()
            ReportViewer.CrystalReportViewer1.ReportSource = m
            ReportViewer.Activate()
        Catch ex As Exception
            Epx()
        End Try
    
    End Function

    Public Function Prnt(ByVal MRpt As Object, ByVal Dset As Data.DataSet, ByVal TabName As String)

        'Dim npde As DataTable = Dset.Tables(TabName)
        'Dim m As New SudentsSubjectsReport
        Dim m As New Object
        m = MRpt
        m.Database.Tables(TabName).SetDataSource(Dset)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = m
        ReportViewer.Activate()
    End Function
    Public Function CountKeys(ByVal Txt As String, ByVal Key As String) As Integer
        Dim Nlst As New ListBox
        Me.CutWordLetter(Nlst, Txt, Key)
        contkeys = Nlst.Items.Count

    End Function
    Public Function GetIndexInOrNot(ByVal Lst As ListBox, ByVal Index As Integer) As Boolean
        m = Lst.Items.Count - 1
        If Val(m) >= Index Then
            GetIndexInOrNot = True
            WGeT = Lst.Items.Item(Index)
        Else
            GetIndexInOrNot = False
            WGeT = ""
        End If
    End Function
    Public Function DataFilterNormal(ByVal Bp As BindingSource, ByVal FormatStr As String, ByVal FndTxtFromatTxt As String, ByVal KeyInFortmatString As String, ByVal IfTrueNullValueNotFiltered As Boolean)
        Dim lst1, lst2 As New ListBox
        Dim Fntxt As String
        Dim Col As String
        Bp.RemoveFilter()

        Me.CutWordLetter(lst1, FormatStr, KeyInFortmatString, True)
        Me.CutWordLetter(lst2, FndTxtFromatTxt, KeyInFortmatString, True, True)
        For PrVI = 0 To lst1.Items.Count - 1
            GetIndexInOrNot(lst1, PrVI)
            Col = WGeT
            If IfTrueNullValueNotFiltered = True Then
                If Col.Trim <> "" Then
                    GetIndexInOrNot(lst2, PrVI)
                    Fntxt = WGeT
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                End If
            Else
                GetIndexInOrNot(lst2, PrVI)
                Fntxt = WGeT
                Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
            End If
        Next

    End Function
    Public Function DataFilterExtraOrdinary(ByVal Bp As BindingSource, ByVal FormatStr As String, ByVal FndTxtFromatTxt As String, ByVal KeyInFortmatString As String, ByVal IfTrueNullValueNotFiltered As Boolean, ByVal Exact As Boolean, ByVal FExact As Boolean, ByVal AnyWhere As Boolean)
        Dim lst1, lst2 As New ListBox
        Dim Fntxt As String
        Dim Col As String
        Bp.RemoveFilter()


        Me.CutWordLetter(lst1, FormatStr, KeyInFortmatString, True, False)
        Me.CutWordLetter(lst2, FndTxtFromatTxt, KeyInFortmatString, True, True)
        For PrVI = 0 To lst1.Items.Count - 1
            GetIndexInOrNot(lst1, PrVI)
            Col = WGeT
            GetIndexInOrNot(lst2, PrVI)
            Fntxt = WGeT
            If IfTrueNullValueNotFiltered = True Then
                If Fntxt.Trim <> "" Then

                    If Exact = True Then
                        Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                    ElseIf FExact = True Then
                        Me.BindFilter(Bp, Col.ToUpper, Fntxt, "auk", True)
                    ElseIf AnyWhere = True Then
                        Me.BindFilter(Bp, Col.ToUpper, Fntxt, "lk", True)
                    End If

                End If
            Else
                GetIndexInOrNot(lst2, PrVI)
                Fntxt = WGeT
                If Exact = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                ElseIf fExact = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "auk", True)
                ElseIf AnyWhere = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "lk", True)
                End If
            End If
        Next

    End Function
    Public Function DataFilterExtraOrdinary(ByVal Bp As BindingSource, ByVal FormatStr As String, ByVal FndTxtFromatTxt As String, ByVal KeyInFortmatString As String, ByVal IfTrueNullValueNotFiltered As Boolean, ByVal Exact As RadioButton, ByVal FExact As RadioButton, ByVal AnyWhere As RadioButton)
        Dim lst1, lst2 As New ListBox
        Dim Fntxt As String
        Dim Col As String
        Bp.RemoveFilter()
        Me.CutWordLetter(lst1, FormatStr, KeyInFortmatString)
        Me.CutWordLetter(lst2, FndTxtFromatTxt, KeyInFortmatString, True)
        For PrVI = 0 To lst1.Items.Count - 1
            GetIndexInOrNot(lst1, PrVI)
            Col = WGeT
            GetIndexInOrNot(lst2, PrVI)
            Fntxt = WGeT
            If IfTrueNullValueNotFiltered = True Then
                If Fntxt.Trim <> "" Then

                    If Exact.Checked = True Then
                        Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                    ElseIf FExact.Checked = True Then
                        Me.BindFilter(Bp, Col.ToUpper, Fntxt, "auk", True)
                    ElseIf AnyWhere.Checked = True Then
                        Me.BindFilter(Bp, Col.ToUpper, Fntxt, "lk", True)
                    End If

                End If
            Else
                GetIndexInOrNot(lst2, PrVI)
                Fntxt = WGeT
                If Exact.Checked = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                ElseIf FExact.Checked = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "auk", True)
                ElseIf AnyWhere.Checked = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "lk", True)
                End If
            End If
        Next

    End Function
    Public Function DataFilterExtraOrdinary(ByVal Bp As BindingSource, ByVal FormatStr As String, ByVal FndTxtFromatTxt As String, ByVal KeyInFortmatString As String, ByVal Exact As RadioButton, ByVal FExact As RadioButton, ByVal AnyWhere As RadioButton, ByVal Clr As Boolean)
        Dim lst1, lst2 As New ListBox
        Dim Fntxt As String
        Dim Col As String

        Me.CutWordLetter(lst1, FormatStr, KeyInFortmatString)
        Me.CutWordLetter(lst2, FndTxtFromatTxt, KeyInFortmatString, True)

        If Clr = True Then
            Bp.RemoveFilter()
        End If

        For PrVI = 0 To lst1.Items.Count - 1
            GetIndexInOrNot(lst1, PrVI)
            Col = WGeT
            GetIndexInOrNot(lst2, PrVI)
            Fntxt = WGeT
            'MsgBox(GetIndexInOrNot(lst2, PrVI))
            If GetIndexInOrNot(lst2, PrVI) = True Then


                If Exact.Checked = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                ElseIf FExact.Checked = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "auk", True)
                ElseIf AnyWhere.Checked = True Then
                    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "lk", True)
                End If

                'End If
                'Else
                'GetIndexInOrNot(lst2, PrVI)
                'Fntxt = WGeT
                'If Exact.Checked = True Then
                '    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "", True)
                'ElseIf FExact.Checked = True Then
                '    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "auk", True)
                'ElseIf AnyWhere.Checked = True Then
                '    Me.BindFilter(Bp, Col.ToUpper, Fntxt, "lk", True)
                'End If
            End If
        Next
        If lst2.Items.Count = 0 Then
            Bp.RemoveFilter()

        End If
        'Try
        '    MsgBox(Bp.Filter.ToUpper)
        'Catch ex As Exception

        'End Try


    End Function
    Public Function TxtRowAddInDatabase(ByVal Txt As Object, ByVal TableName As String, ByVal Dataset As DataSet, ByVal NullAddTrue As Boolean, ByVal AllowColumn1 As String)
        Dim Mnp As String
        Dim Bnw As New BindingSource
        Dim PrvI As Integer
        Try
            Mnp = Txt.text
        Catch ex As Exception
            Mnp = Txt.ToString
        End Try


        If NullAddTrue = False Then
            If Mnp.Trim = "" Then
                Exit Function
            Else
                'Dataset.Tables(TableName).Rows.Add()
                Dataset.Tables(TableName).NewRow()
                If AllowColumn1.Trim.ToUpper = "" Then
                    For PrvI = 0 To 3
                        If AddColDb(PrvI).ToUpper.Trim <> "" Then
                            Dataset.Tables(TableName).NewRow.Item(AddColDb(PrvI).ToUpper) = AddRwTxt(PrvI).ToString
                            Dataset.Tables(TableName).NewRow.EndEdit()
                        End If

                    Next
                Else
                    Dataset.Tables(TableName).NewRow.Item(AllowColumn1.Trim.ToUpper) = Mnp
                    Dataset.Tables(TableName).NewRow.EndEdit()
                End If


                'Dataset.Tables(TableName).Rows .Add 
            End If
        Else
            Dataset.Tables(TableName).NewRow()
            If AllowColumn1.Trim.ToUpper = "" Then
                For PrvI = 0 To 3
                    If AddColDb(PrvI).ToUpper.Trim <> "" Then
                        Dataset.Tables(TableName).NewRow.Item(AddColDb(PrvI).ToUpper) = AddRwTxt(PrvI).ToString
                        Dataset.Tables(TableName).NewRow.EndEdit()
                    End If

                Next
            Else
                Dataset.Tables(TableName).NewRow.Item(AllowColumn1.Trim.ToUpper) = Mnp
                Dataset.Tables(TableName).NewRow.EndEdit()
            End If
        End If
    End Function
    Public Function DataGridDeleteItems(ByVal D As DataGridView, ByVal CurrentOnly As Boolean, ByVal AllSelected As Boolean)
        Dim Sk As Integer
        mbs = D.SelectedRows.Count
        If AllSelected = True Then
            For PrVI = (mbs - 1) To 0 Step -1

                Sk = D.SelectedRows(PrVI).Index.ToString
                'MsgBox(Sk)

                D.Rows.RemoveAt(Sk)

            Next
        ElseIf CurrentOnly = True Then
            'D.SelectedRows(D.CurrentCell.RowIndex.ToString).Cells.RemoveAt(PrVI)
            D.Rows.RemoveAt(D.CurrentCell.RowIndex.ToString)
        End If
    End Function
    Public Function DataGridDeleteItems(ByVal D As DataGridView, ByVal CurrentOnly As Boolean, ByVal AllSelected As Boolean, ByVal MsgboxShow As Boolean)
        Dim Sk As Integer
        mbs = D.SelectedRows.Count
        If MsgboxShow = True Then
            If AukF.MsgTr(What & "delete (" & mbs & ") rows from this DataTable....?") = False Then
                Exit Function
            End If
        End If
        If AllSelected = True Then
            For PrVI = (mbs - 1) To 0 Step -1

                Sk = D.SelectedRows(PrVI).Index.ToString
                'MsgBox(Sk)

                D.Rows.RemoveAt(Sk)

            Next
        ElseIf CurrentOnly = True Then
            'D.SelectedRows(D.CurrentCell.RowIndex.ToString).Cells.RemoveAt(PrVI)
            D.Rows.RemoveAt(D.CurrentCell.RowIndex.ToString)
        End If
    End Function
    Public Function DataGridDeleteItemsProcessor(ByVal D As DataGridView, ByVal CurrentOnly As Boolean, ByVal AllSelected As Boolean, ByVal MsgboxShow As Boolean, ByVal Prog As ProgressBar)
        Dim Sk As Integer
        mbs = D.SelectedRows.Count
        If MsgboxShow = True Then
            If AukF.MsgTr(What & "delete (" & mbs & ") rows from this DataTable....?") = False Then
                Exit Function
            End If
        End If
        If Val(mbs) > 0 Then
            caz = 100 / mbs
        End If

        If AllSelected = True Then
            For PrVI = (mbs - 1) To 0 Step -1

                Sk = D.SelectedRows(PrVI).Index.ToString
                'MsgBox(Sk)

                D.Rows.RemoveAt(Sk)
                Me.InsPro(Prog, caz)
            Next
        ElseIf CurrentOnly = True Then
            'D.SelectedRows(D.CurrentCell.RowIndex.ToString).Cells.RemoveAt(PrVI)
            D.Rows.RemoveAt(D.CurrentCell.RowIndex.ToString)
        End If
        Prog.Value = 0

    End Function
    Public Function BoolInvert(ByVal B As Boolean) As Boolean
        If B = True Then
            BoolInvert = False
        Else
            BoolInvert = True
        End If
    End Function

    Public Function CutTxtGet(ByVal Txt As String, ByVal Key As String, ByVal NumArryGet As String) As String
        Dim Lst As New ListBox
        AukF.CutWordLetter(Lst, Txt, Key, True)
        clvn = Lst.Items.Count

        If Val(clvn) >= Val(NumArryGet) Then
            CutTxtGet = Lst.Items.Item(NumArryGet - 1).ToString
            WGeT = CutTxtGet
        Else
            CutTxtGet = ""
            WGeT = ""
        End If
    End Function
    Public Function AukOptionsOfDataGrid(ByVal D As DataGridView, ByVal ReadWriteColumn As String, ByVal ReadonlyColumn As String, ByVal FrozenColumn As String, ByVal UnFrozenColumn As String, ByVal InvisibleColumn As String, ByVal VisibleColumn As String)
        Dim Lp As New ListBox
        Lp.Items.Clear()

        Me.CutWordLetter(Lp, ReadonlyColumn, ",", True)
        If Lp.Items.Count > 0 Then
            For PrVI = 0 To Lp.Items.Count - 1
                D.Columns(Lp.Items.Item(PrVI)).ReadOnly = True
            Next
        End If
        Lp.Items.Clear()
        Me.CutWordLetter(Lp, ReadWriteColumn, ",", True)
        If Lp.Items.Count > 0 Then
            For PrVI = 0 To Lp.Items.Count - 1
                D.Columns(Lp.Items.Item(PrVI)).ReadOnly = False
            Next
        End If
        Lp.Items.Clear()
        Me.CutWordLetter(Lp, FrozenColumn, ",", True)
        If Lp.Items.Count > 0 Then
            For PrVI = 0 To Lp.Items.Count - 1
                D.Columns(Lp.Items.Item(PrVI)).Frozen = True
            Next
        End If
        Lp.Items.Clear()
        Me.CutWordLetter(Lp, UnFrozenColumn, ",", True)

        If Lp.Items.Count > 0 Then
            For PrVI = 0 To Lp.Items.Count - 1
                D.Columns(Lp.Items.Item(PrVI)).Frozen = False
            Next
        End If
        Lp.Items.Clear()
        Me.CutWordLetter(Lp, VisibleColumn, ",", True)

        If Lp.Items.Count > 0 Then
            For PrVI = 0 To Lp.Items.Count - 1
                D.Columns(Lp.Items.Item(PrVI)).Visible = True
            Next
        End If
        Lp.Items.Clear()
        Me.CutWordLetter(Lp, InvisibleColumn, ",", True)
        If Lp.Items.Count > 0 Then
            For PrVI = 0 To Lp.Items.Count - 1
                D.Columns(Lp.Items.Item(PrVI)).Visible = False
            Next
        End If
    End Function
    Public Function DelRowsFromDatabase(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal AllRowFind As Boolean)

        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If J = WhatFind Then
                    Tab.Rows(PrVI).Delete()
                    Tab.Rows(PrVI).ClearErrors()
                End If
            Next
        End If
    End Function
    Public Function GetStringTextFromDataset(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal GetColumnNumber As String)

        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If J = WhatFind Then

                    GetStringTextFromDataset = Tab.Rows(PrVI).Item(GetColumnNumber).ToString
                    WGeT = GetStringTextFromDataset
                Else
                    GetStringTextFromDataset = ""
                    WGeT = ""

                End If
            Next
        End If
    End Function
    Public Function DelRowsFromDatabase(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal AllRowFind As Boolean, ByVal CaseSensetive As Boolean)

        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If CaseSensetive = True Then
                    If J = WhatFind Then
                        Tab.Rows(PrVI).Delete()
                        Tab.Rows(PrVI).ClearErrors()
                    End If
                Else
                    If J.ToUpper = WhatFind.ToUpper Then
                        Tab.Rows(PrVI).Delete()
                        Tab.Rows(PrVI).ClearErrors()
                    End If
                End If

            Next
        End If
    End Function
    Public Function DelRowsFromDatabase(ByVal Column As Integer, ByVal CurRow As String, ByVal Tab As Data.DataTable, ByVal WhatFind As String, ByVal AllRowFind As Boolean, ByVal CaseSensetive As Boolean, ByVal UseInStr As Boolean)

        Dim J As String
        If AllRowFind = True Then
            For PrVI = 0 To Tab.Rows.Count - 1
                J = Tab.Rows(PrVI).Item(Column).ToString
                If UseInStr = True Then
                    If CaseSensetive = True Then
                        If InStr(J, WhatFind) <> 0 Then
                            Tab.Rows(PrVI).Delete()
                            Tab.Rows(PrVI).ClearErrors()
                        End If
                    Else
                        If InStr(J.ToUpper, WhatFind.ToUpper) <> 0 Then
                            Tab.Rows(PrVI).Delete()
                            Tab.Rows(PrVI).ClearErrors()
                        End If
                    End If
                End If


            Next
        End If
    End Function
    Public Function SuggestListSourceAdd(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As String)
        Dim lpJ As Integer
        'Dim m As ComboBox
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then
            If Dset.Tables(TableName).Rows.Count > 0 Then
                For lpJ = 0 To Dset.Tables(TableName).Rows.Count - 1
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        Else
            Exit Function
        End If
    End Function
    Public Function SuggestListSourceAdd(ByVal Obj As Object, ByVal obj2 As Object)
        Dim lpJ As Integer
        'Dim m As ComboBox
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then
            If obj2.Items.Count > 0 And obj2.DataSource Is Nothing Then
                For lpJ = 0 To Dset.Tables(TableName).Rows.Count - 1
                    Obj.AutoCompleteCustomSource.Add(obj2.Items.Item(lpJ).ToString)
                Next
            End If
        Else
            Exit Function
        End If
    End Function
    Public Function SuggestListSourceAdd(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As Integer)
        Dim lpJ As Integer



        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then
            If Dset.Tables(TableName).Rows.Count > 0 Then
                For lpJ = 0 To Dset.Tables(TableName).Rows.Count - 1
                    'MsgBox(Dset.Tables(TableName).Rows.Count)
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        Else
            Exit Function
        End If
        'Dim m As ComboBox

    End Function
    Public Function SuggestListSourceAdd(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As String, ByVal MaxNum As Integer)
        Dim lpJ As Integer
        'Dim m As ComboBox
        cvnp = Dset.Tables(TableName).Rows.Count
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then

            If Dset.Tables(TableName).Rows.Count > 0 Then
                If Val(MaxNum) < Val(cvnp) Then
                    If MaxNum <> 0 Then
                        xne = MaxNum
                    End If

                Else
                    xne = cvnp
                End If

                For lpJ = 0 To xne - 1
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        Else
            Exit Function
        End If
    End Function
    Public Function SuggestListSourceAdd(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As Integer, ByVal MaxNum As Integer)
        cvnp = Dset.Tables(TableName).Rows.Count
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then

            If Dset.Tables(TableName).Rows.Count > 0 Then
                If Val(MaxNum) < Val(cvnp) Then
                    If MaxNum <> 0 Then
                        xne = MaxNum
                    End If
                Else
                    xne = cvnp
                End If

                For lpJ = 0 To xne - 1
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        Else
            Exit Function
        End If
        'Dim m As ComboBox
    End Function
    Public Function SuggestListSourceAddGveMsg(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As String, ByVal MaxNum As Integer)
        Dim lpJ As Integer
        'Dim m As ComboBox
        cvnp = Dset.Tables(TableName).Rows.Count
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then

            If Dset.Tables(TableName).Rows.Count > 0 Then
                If Val(MaxNum) < Val(cvnp) Then
                    If MaxNum <> 0 Then
                        If MsgBox("Do you want to load .... ( " & cvnp & " )Data in current In Object Item...Yes to Load all or Else to Load Maximum(" & MaxNum & ")", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            xne = MaxNum
                        Else
                            xne = cvnp
                        End If

                    End If

                Else
                    xne = cvnp
                End If

                For lpJ = 0 To xne - 1
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        Else
            Exit Function
        End If
    End Function
    Public Function SuggestListSourceAddGveMsg(ByVal Obj As Object, ByVal Dset As DataSet, ByVal TableName As String, ByVal Column As Integer, ByVal MaxNum As Integer)
        Dim lpJ As Integer
        'Dim m As ComboBox
        cvnp = Dset.Tables(TableName).Rows.Count
        If (TypeOf (Obj) Is TextBox) Or (TypeOf (Obj) Is ComboBox) Or (TypeOf (Obj) Is ToolStripComboBox) Or (TypeOf (Obj) Is ToolStripTextBox) Then

            If Dset.Tables(TableName).Rows.Count > 0 Then
                If Val(MaxNum) < Val(cvnp) Then
                    If MaxNum <> 0 Then
                        If MsgBox("Do you want to load .... ( " & cvnp & " )Data in current In Object Item...Yes to Load all or Else to Load Maximum(" & MaxNum & ")", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            xne = MaxNum
                        Else
                            xne = cvnp
                        End If

                    End If

                Else
                    xne = cvnp
                End If

                For lpJ = 0 To xne - 1
                    Obj.AutoCompleteCustomSource.Add(Dset.Tables(TableName).Rows(lpJ).Item(Column).ToString)
                Next
            End If
        Else
            Exit Function
        End If
        'Dim m As ComboBox
    End Function
    Public Function FullWordFind(ByVal FindFrom As String, ByVal FindText As String) As Boolean
        c = " " & FindText & " "
        'MsgBox(c)
        If InStr(FindFrom, c) = 0 Then
            FullWordFind = False
        Else
            FullWordFind = True
        End If

    End Function
    Public Function ClearErrorFromDataSet(ByVal Dset As DataSet)
        Dim Nk As Integer
        For Nk = 0 To Dset.Tables.Count - 1
            Dset.Tables(Nk).NewRow.ClearErrors()
        Next
    End Function
    Public Function SqlQueryFilterAs(ByVal TableTitle As String, ByVal TableName As String, ByVal OrdTxt As String, ByVal Exact As Boolean, ByVal FExact As Boolean, ByVal LikeCmd As Boolean, ByVal Dataset As DataSet, ByVal Cls As Boolean, ByVal AnyStringEmpt As String)
        'Dim RadioButton1, RadioButton2, RadioButton3 As RadioButton


        If Cls = True Then
            AnyStringEmpt = ""
            If FExact = True Then
                GSql.Sql_Cls_Ord_like_From_First(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf LikeCmd = True Then
                GSql.Sql_ORD_likeUse(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf Exact = True Then
                GSql.Sql_ORD_like_false(TableTitle, TableName, OrdTxt, Dataset)
            End If
        Else
            If FExact = True Then
                GSql.Sql_NonCls_Ord_like_From_First(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf LikeCmd = True Then
                GSql.NonCls_ORD_LikeCommand(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf Exact = True Then
                GSql.NonCls_ORD_NonLikeCommand(TableTitle, TableName, OrdTxt, Dataset)
                'MsgBox(Sql)
            End If
        End If
        SqlQueryFilterAs = Sql
    End Function
    Public Function SqlQueryFilterAs(ByVal TableTitle As String, ByVal TableName As String, ByVal OrdTxt As String, ByVal Exact As RadioButton, ByVal FExact As RadioButton, ByVal LikeCmd As RadioButton, ByVal Dataset As DataSet, ByVal Cls As Boolean, ByVal AnyStringEmpt As String)
        'Dim RadioButton1, RadioButton2, RadioButton3 As RadioButton


        If Cls = True Then
            AnyStringEmpt = ""
            If FExact.Checked = True Then
                GSql.Sql_Cls_Ord_like_From_First(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf LikeCmd.Checked = True Then
                GSql.Sql_ORD_likeUse(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf Exact.Checked = True Then
                GSql.Sql_ORD_like_false(TableTitle, TableName, OrdTxt, Dataset)
            End If
        Else
            If FExact.Checked = True Then
                GSql.Sql_NonCls_Ord_like_From_First(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf LikeCmd.Checked = True Then
                GSql.NonCls_ORD_LikeCommand(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf Exact.Checked = True Then
                GSql.NonCls_ORD_NonLikeCommand(TableTitle, TableName, OrdTxt, Dataset)
                'MsgBox(Sql)
            End If
        End If
        SqlQueryFilterAs = Sql

    End Function
    Public Function SqlQueryFilterAs(ByVal TableTitle As String, ByVal TableName As String, ByVal OrdTxt As String, ByVal Exact As Boolean, ByVal FExact As Boolean, ByVal LikeCmd As Boolean, ByVal Dataset As DataSet, ByVal Cls As Boolean)
        'Dim RadioButton1, RadioButton2, RadioButton3 As RadioButton


        If Cls = True Then
            'TSubID = ""
            If FExact = True Then
                GSql.Sql_Cls_Ord_like_From_First(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf LikeCmd = True Then
                GSql.Sql_ORD_likeUse(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf Exact = True Then
                GSql.Sql_ORD_like_false(TableTitle, TableName, OrdTxt, Dataset)
            End If
        Else
            If FExact = True Then
                GSql.Sql_NonCls_Ord_like_From_First(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf LikeCmd = True Then
                GSql.NonCls_ORD_LikeCommand(TableTitle, TableName, OrdTxt, Dataset)
            ElseIf Exact = True Then
                GSql.SqlNonClr_Gr_likeUse_false(TableTitle, TableName, OrdTxt, Dataset)
                'MsgBox(Sql)
            End If
        End If
        SqlQueryFilterAs = Sql
    End Function

    Public Function BindFind(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String) As Boolean
        Dim Ap As Integer
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindFind = True
        Else
            BindFind = False
        End If
        ComRow = Ap
    End Function
    Public Function BindFind(ByVal GotoPos As Boolean, ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String) As Boolean
        Dim Ap As Integer
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindFind = True
        Else
            BindFind = False
        End If
        If GotoPos = True Then
            If BindFind = True Then Bp.Position = Ap
        End If
        ComRow = Ap
    End Function
    Public Function BindFindFormatAsAuk(ByVal GotoPos As Boolean, ByVal Bp As BindingSource, ByVal TitleNameFormat As String, ByVal FindTxtAsFormat As String, ByVal FormatKey As String, ByVal outputFormatKey As String, ByVal ColumnFormat As String) As Boolean
        Dim M As DataSet = Bp.DataSource
        Dim Rnw As New Data.DataTable

        Dim Tab As String = Bp.DataMember.ToString
        Dim LStr, TStr As String

        Dim Lst1, Lst2, Lst3, Lst4 As New ListBox
        Me.CutWordLetter(Lst1, TitleNameFormat, FormatKey, True, True)
        Me.CutWordLetter(Lst2, FindTxtAsFormat, FormatKey, True, True)
        Me.CutWordLetter(Lst3, ColumnFormat, FormatKey, True, True)
        WGeT = ""
        Sql = ""
        For PrVI = 0 To Lst1.Items.Count - 1
            LStr = Lst1.Items.Item(PrVI).ToString
            Me.GetIndexInOrNot(Lst2, PrVI)
            If Sql.Trim = "" Then
                Sql = "(" & LStr.ToUpper & "='" & WGeT & "')"
            Else
                Sql = Sql & " and (" & LStr.ToUpper & "='" & WGeT & "')"
            End If
        Next
        If Sql <> "" Then
            Sql = "Select * From where (" & Sql & ")"
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(Rnw)
            If Rnw.Rows.Count > 0 Then
                For PrVI = 0 To Lst3.Items.Count - 1
                    cq = Lst3.Items.Item(PrVI)
                    If IsNumeric(cq) = True Then
                        cq = CInt(Val(cq))
                    End If
                    Lst4.Items.Add(Rnw.Rows(0).Item(Cq).ToString)
                    StrNullAndWithAdd(WGeT, Lst4.Items.Item(PrVI).ToString, outputFormatKey & Lst4.Items.Item(PrVI).ToString)
                Next
                If GotoPos = True Then
                    prk = Rnw.Rows(0).Item(0).ToString
                    col = M.Tables(Tab).Columns(0).ColumnName.ToUpper
                    PrVI = Bp.Find(col, prk)
                    If PrVI > -1 Then
                        Bp.Position = PrVI
                    End If
                End If
                BindFindFormatAsAuk = True
            Else
                BindFindFormatAsAuk = False
            End If
            'Rnw = M.Tables(Tab).Select(Sql)
         
        End If

    End Function
    Public Function StrNullAndWithAdd(ByVal Str As String, ByVal NullTxt As String, ByVal WithTxt As String)
        If Str.Trim = "" Then
            Str = NullTxt
        Else
            Str = Str & WithTxt
        End If
        StrNullAndWithAdd = Str
        WGeT = Str

    End Function
    Public Function BindGotoFind(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String) As Boolean
        Dim Ap As Integer
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindGotoFind = True
        Else
            BindGotoFind = False
        End If

        If BindGotoFind = True Then Bp.Position = Ap
        ComRow = Ap
    End Function
    'Public Function BindFindTxT(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal DSet As DataSet, ByVal TableName As String) As Boolean
    '    Dim Ap As Integer
    '    'Dim Nmp As DataTable

    '    Ap = Bp.Find(TitleName, FindTxt)
    '    If Ap > -1 Then
    '        BindFindTxT = True
    '    Else
    '        BindFindTxT = False
    '    End If

    '    If BindFindTxT = True Then
    '        'SFC(TitleName)
    '        'STC(FindTxt)

    '        'TbSql.Sql_ORD_like_false(TitleName, Bp.DataMember.ToUpper, "", Nmp)
    '        'If Nmp.Rows.Count > 0 Then
    '        '    WGeT = Nmp.Rows(0).Item(TitleName).ToString

    '        'End If
    '        WGeT = DSet.Tables(TableName).Rows(Ap).Item(TitleName).ToString



    '    End If
    '    ComRow = Ap

    'End Function
    Public Function DelItemsFromList(ByVal Lst As Object, ByVal Txt As String, ByVal Key As String)

        Dim Lplst As New ListBox
        Me.CutWordLetter(Lplst, Txt, ",", True, True)
        For PrVI = 0 To Lplst.Items.Count - 1
            If Me.FindInObjectAndSelect(Lst, Lplst.Items.Item(PrVI), True, False, False) Then
                Lst.Items.Remove(Lplst.Items.Item(PrVI))
            End If
        Next

    End Function
    Public Function BindFindTxT(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal Column As String) As Boolean
        Dim Ap As Integer
        'Dim Nmp As DataTable
        Dim Dset As DataSet = Bp.DataSource
        Dim TableName As String = Bp.DataMember
        Ap = Bp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            BindFindTxT = True
        Else
            BindFindTxT = False
        End If

        If BindFindTxT = True Then
            'SFC(TitleName)
            'STC(FindTxt)

            'TbSql.Sql_ORD_like_false(TitleName, Bp.DataMember.ToUpper, "", Nmp)
            'If Nmp.Rows.Count > 0 Then
            '    WGeT = Nmp.Rows(0).Item(TitleName).ToString

            'End If
            WGeT = Dset.Tables(TableName).Rows(Ap).Item(Column).ToString



        End If
        ComRow = Ap

    End Function
    Public Function DataSetFindTxT(ByVal TitleName As String, ByVal FindTxt As String, ByVal DSet As DataSet, ByVal TableName As String, ByVal ColumnNum As Integer) As Boolean
        Dim Ap As Integer
        'Dim Nmp As DataTable
        Dim Bnp As New BindingSource
        Bnp.DataSource = DSet
        Bnp.DataMember = TableName
        Ap = Bnp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            DataSetFindTxT = True
        Else
            DataSetFindTxT = False
        End If

        If DataSetFindTxT = True Then
            'SFC(TitleName)
            'STC(FindTxt)

            'TbSql.Sql_ORD_like_false(TitleName, Bp.DataMember.ToUpper, "", Nmp)
            'If Nmp.Rows.Count > 0 Then
            '    WGeT = Nmp.Rows(0).Item(TitleName).ToString

            'End If
            WGeT = DSet.Tables(TableName).Rows(Ap).Item(ColumnNum).ToString
        End If
        ComRow = Ap
    End Function
    Public Function DataSetFindTxT(ByVal TitleName As String, ByVal FindTxt As String, ByVal DSet As DataSet, ByVal TableName As String, ByVal ColumnNum As String) As Boolean
        Dim Ap As Integer
        'Dim Nmp As DataTable
        Dim Bnp As New BindingSource
        Bnp.DataSource = DSet
        Bnp.DataMember = TableName
        Ap = Bnp.Find(TitleName, FindTxt)
        If Ap > -1 Then
            DataSetFindTxT = True
        Else
            DataSetFindTxT = False
        End If

        If DataSetFindTxT = True Then
            'SFC(TitleName)
            'STC(FindTxt)

            'TbSql.Sql_ORD_like_false(TitleName, Bp.DataMember.ToUpper, "", Nmp)
            'If Nmp.Rows.Count > 0 Then
            '    WGeT = Nmp.Rows(0).Item(TitleName).ToString

            'End If
            WGeT = DSet.Tables(TableName).Rows(Ap).Item(ColumnNum).ToString
        End If
        ComRow = Ap
    End Function
    Public Function BindFilterNumber(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal NumSign As String) As String
        ', ByVal Quality As String
        'If Quality.ToUpper = "E" Or Quality.Trim = "" Then
        Bp.Filter = "[" & TitleName & "]" & NumSign & FindTxt
        Bp.Filter = "(" & Bp.Filter.ToUpper & ")"

        'End If
        BindFilterNumber = Bp.Filter.ToUpper

    End Function
    Public Function BindFilterNumber(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal NumSign As String, ByVal WithFiter As Boolean) As String
        ', ByVal Quality As String
        'If Quality.ToUpper = "E" Or Quality.Trim = "" Then
        m = Bp.Filter.ToUpper
        If Trim(m) <> "" Then
            If WithFiter = True Then
                Bp.Filter = m & " and ([" & TitleName & "]" & NumSign & FindTxt & ")"
            Else
                Bp.Filter = "([" & TitleName & "]" & NumSign & FindTxt & ")"
            End If
        Else
            Bp.Filter = "([" & TitleName & "]" & NumSign & FindTxt & ")"
        End If


        'End If
        BindFilterNumber = Bp.Filter.ToUpper

    End Function
    Public Function BindFilter(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal Quality As String) As String
        '
        If Quality.ToUpper = "E" Or Quality.Trim = "" Then
            Bp.Filter = "[" & TitleName & "]='" & FindTxt & "'"
        ElseIf Quality.ToUpper = "LK" Then
            Bp.Filter = "[" & TitleName & "] Like '%" & FindTxt & "%'"
        Else
            Bp.Filter = "[" & TitleName & "] Like '" & FindTxt & "%'"
        End If
        Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
        BindFilter = Bp.Filter.ToUpper

    End Function
    Public Function BindFilterNot(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String) As String
        Bp.Filter = "[" & TitleName & "]<>'" & FindTxt & "'"
        Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
        BindFilterNot = Bp.Filter.ToUpper

    End Function
    Public Function BindFilterNot(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal WithFilter As Boolean) As String

        If WithFilter = True Then
            If Bp.Filter.ToString <> "" Then
                Bp.Filter = Bp.Filter.ToString & " and ([" & TitleName & "]<>'" & FindTxt & "')"
            Else
                Bp.Filter = "[" & TitleName & "]<>'" & FindTxt & "'"
            End If

            'Bp.Filter = "(" & Bp.Filter.ToUpper & ")"

            BindFilterNot = Bp.Filter.ToUpper
        Else

            Bp.Filter = "[" & TitleName & "]<>'" & FindTxt & "'"
            Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
            BindFilterNot = Bp.Filter.ToUpper
        End If


    End Function
    Public Function BindFilterNot(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal Quality As String, ByVal NotTrue As Boolean) As String
        '
        If NotTrue = True Then
            If Quality.ToUpper = "E" Or Quality.Trim = "" Then
                Bp.Filter = "[" & TitleName & "]<>'" & FindTxt & "'"
            ElseIf Quality.ToUpper = "LK" Then
                Bp.Filter = "[" & TitleName & "] NOT Like '%" & FindTxt & "%'"
            Else
                Bp.Filter = "[" & TitleName & "] NOT Like '" & FindTxt & "%'"
            End If
            Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
        Else
            If Quality.ToUpper = "E" Or Quality.Trim = "" Then
                Bp.Filter = "[" & TitleName & "]='" & FindTxt & "'"
            ElseIf Quality.ToUpper = "LK" Then
                Bp.Filter = "[" & TitleName & "] Like '%" & FindTxt & "%'"
            Else
                Bp.Filter = "[" & TitleName & "] Like '" & FindTxt & "%'"
            End If
            Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
        End If

        BindFilterNot = Bp.Filter.ToUpper

    End Function
    Public Function BindFilter(ByVal Bp As BindingSource, ByVal TitleName As String, ByVal FindTxt As String, ByVal Quality As String, ByVal withFilter As Boolean) As String
        '
        'Bp = New BindingSource
        Try
            m = Bp.Filter.ToUpper
        Catch ex As Exception
            m = ""
        End Try

        If Trim(m) <> "" Then
            If withFilter = True Then

                If Quality.ToUpper = "E" Or Quality.Trim = "" Then
                    Bp.Filter = m & " and ([" & TitleName & "]='" & FindTxt & "')"
                ElseIf Quality.ToUpper = "LK" Then
                    Bp.Filter = m & " and ([" & TitleName & "] Like '%" & FindTxt & "%')"
                Else
                    Bp.Filter = m & " and ([" & TitleName & "] Like '" & FindTxt & "%')"
                End If

            Else
                If Quality.ToUpper = "E" Or Quality.Trim = "" Then
                    Bp.Filter = "[" & TitleName & "]='" & FindTxt & "'"
                ElseIf Quality.ToUpper = "LK" Then
                    Bp.Filter = "[" & TitleName & "] Like '%" & FindTxt & "%'"
                Else
                    Bp.Filter = "[" & TitleName & "] Like '" & FindTxt & "%'"
                End If
                Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
            End If
        Else
            If Quality.ToUpper = "E" Or Quality.Trim = "" Then
                Bp.Filter = "[" & TitleName & "]='" & FindTxt & "'"
            ElseIf Quality.ToUpper = "LK" Then
                Bp.Filter = "[" & TitleName & "] Like '%" & FindTxt & "%'"
            Else
                Bp.Filter = "[" & TitleName & "] Like '" & FindTxt & "%'"
            End If
            Bp.Filter = "(" & Bp.Filter.ToUpper & ")"
        End If


        BindFilter = Bp.Filter.ToUpper
    End Function
    Public Function DataGridSelectedFilter(ByVal DGrid As DataGridView, ByVal Bp As BindingSource, ByVal Sign As String)
        Dim C, R As Integer
        'Dim Unp As Type

        C = DGrid.CurrentCell.ColumnIndex
        R = DGrid.CurrentCell.RowIndex
        s = DGrid.Columns(C).DataPropertyName
        curtxt = DGrid(C, R).Value.ToString
        If s <> "" Then
            ty = DGrid.Columns(C).ValueType.ToString
            If Me.FindTxt(ty, "double") = True Then
                Me.BindFilterNumber(Bp, s, curtxt, Sign)
            ElseIf Me.FindTxt(ty, "decimal") = True Then
                Me.BindFilterNumber(Bp, s, curtxt, Sign)

            ElseIf Me.FindTxt(ty, "date") = True Then
                Me.BindFilterNumber(Bp, s, "# " & curtxt & " #", Sign)
            Else
                Me.BindFilter(Bp, s, curtxt, "")
            End If
        End If
    End Function
    Public Function DataGridSelectedFilter(ByVal DGrid As DataGridView, ByVal Bp As BindingSource, ByVal Sign As String, ByVal Quality As String)
        Dim C, R As Integer
        'Dim Unp As Type

        C = DGrid.CurrentCell.ColumnIndex
        R = DGrid.CurrentCell.RowIndex
        s = DGrid.Columns(C).DataPropertyName
        curtxt = DGrid(C, R).Value.ToString
        If s <> "" Then
            ty = DGrid.Columns(C).ValueType.ToString
            If Me.FindTxt(ty, "double") = True Then
                Me.BindFilterNumber(Bp, s, curtxt, Sign)
            ElseIf Me.FindTxt(ty, "decimal") = True Then
                Me.BindFilterNumber(Bp, s, curtxt, Sign)
            ElseIf Me.FindTxt(ty, "date") = True Then
                Me.BindFilterNumber(Bp, s, "# " & curtxt & " #", Sign)
            Else
                Me.BindFilter(Bp, s, curtxt, Quality)
            End If
        End If
    End Function
    Public Function DataGridSelectedFilter(ByVal DGrid As DataGridView, ByVal Bp As BindingSource, ByVal Sign As String, ByVal Quality As String, ByVal WithFilter As Boolean)
        Dim C, R As Integer
        'Dim Unp As Type

        C = DGrid.CurrentCell.ColumnIndex
        R = DGrid.CurrentCell.RowIndex
        s = DGrid.Columns(C).DataPropertyName
        curtxt = DGrid(C, R).Value.ToString
        If s <> "" Then
            ty = DGrid.Columns(C).ValueType.ToString
            If Me.FindTxt(ty, "double") = True Then
                Me.BindFilterNumber(Bp, s, curtxt, Sign, WithFilter)
            ElseIf Me.FindTxt(ty, "decimal") = True Then
                Me.BindFilterNumber(Bp, s, curtxt, Sign, WithFilter)
            ElseIf Me.FindTxt(ty, "date") = True Then
                Me.BindFilterNumber(Bp, s, "# " & curtxt & " #", Sign, WithFilter)
            Else
                Me.BindFilter(Bp, s, curtxt, Quality, WithFilter)
            End If
        End If
    End Function
    Public Function DataSetFilter(ByVal Bp As BindingSource, ByVal clearBeforeFill As Boolean, ByVal FillNullOpen As Boolean, ByVal AllTabTrue As Boolean, ByVal BindingSourceRemoveFilter As Boolean)
        Dim Fil, ColName As String
        Dim MDataSet As DataSet = Bp.DataSource
        Dim RAdp As OleDb.OleDbDataAdapter
        Dim TabN As String = Bp.DataMember.ToUpper
        Try
            Fil = Bp.Filter.ToUpper
        Catch ex As Exception
            Fil = ""
        End Try

        cnt = MDataSet.Tables(TabN).Columns.Count - 1
        If AllTabTrue = False Then
            If cnt > -1 Then
                For PrVI = 0 To cnt
                    If ColName = "" Then
                        ColName = "[" & MDataSet.Tables(TabN).Columns.Item(PrVI).ColumnName.ToUpper & "]"
                    Else
                        ColName = ColName & "," & "[" & MDataSet.Tables(TabN).Columns.Item(PrVI).ColumnName.ToUpper & "]"
                    End If
                Next
            End If
        Else
            ColName = "*"
        End If

        If Fil.Trim <> "" Then
            If clearBeforeFill = True Then
                MDataSet.Tables(TabN).Clear()
            End If
            If OrdTableName.Trim <> "" Then

                Sql = "Select " & ColName & " from " & TabN & " where (" & Fil.ToUpper & ") ORDER BY (" & OrdTableName & ")"
                Try
                    RAdp = New OleDb.OleDbDataAdapter(Sql, Cn)
                    RAdp.Fill(MDataSet, TabN)

                Catch ex As Exception
                    Epx()
                End Try
            Else
                Sql = "Select " & ColName & " from " & TabN & " where (" & Fil.ToUpper & ")"
                Try
                    RAdp = New OleDb.OleDbDataAdapter(Sql, Cn)
                    RAdp.Fill(MDataSet, TabN)

                Catch ex As Exception
                    Epx()
                End Try
            End If
        Else
            If FillNullOpen = True Then
                Sql = "Select " & ColName & " from " & TabN
                Try
                    RAdp = New OleDb.OleDbDataAdapter(Sql, Cn)
                    RAdp.Fill(MDataSet, TabN)

                Catch ex As Exception
                    Epx()
                End Try
            End If




        End If
        'MsgBox(Sql)

        'm.Tables(Bp.DataMember.ToString).Select(Bp.Filter.ToUpper)
        'MsgBox(Sql)
        If BindingSourceRemoveFilter = True Then
            Bp.RemoveFilter()
        End If
        ColName = ""
        OrdTableName = ""


    End Function
    Public Function GridT(ByVal D As DataGridView, ByVal Column As Integer) As Object
        DRow = D.CurrentCell.RowIndex
        DColumn = D.CurrentCell.ColumnIndex
        GridT = D.CurrentCell.DataGridView(Column, DRow).Value
        WGeT = GridT

    End Function
    Public Function GridT(ByVal D As Object, ByVal Column As Integer) As Object
        DRow = D.CurrentCell.RowIndex
        DColumn = D.CurrentCell.ColumnIndex
        GridT = D.CurrentCell.DataGridView(Column, DRow).Value
        WGeT = GridT

    End Function
    Public Function DataSetFilter(ByVal Dt As DataTable, ByVal Bp As BindingSource)
        'Dt.Select(Bp.Filter.ToUpper)

    End Function
    Public Function GetGridCurrentTxt(ByVal Dgrid As DataGridView) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        WGeT = Dgrid(DColumn, DRow).Value.ToString
        GetGridCurrentTxt = WGeT

    End Function
    Public Function GetGridCurrentTxt(ByVal Dgrid As Object) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        WGeT = Dgrid(DColumn, DRow).Value.ToString
        GetGridCurrentTxt = WGeT

    End Function
    Public Function SetGridTxt(ByVal Dgrid As DataGridView, ByVal Txt As String) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        Dgrid(DColumn, DRow).Value = Txt
        SetGridTxt = Txt
    End Function
    Public Function GetGridPropertyName(ByVal Dgrid As DataGridView) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        GetGridPropertyName = Dgrid.Columns(DColumn).DataPropertyName.ToUpper()

        WGeT = Txt

    End Function

    Public Function FreezeColumn(ByVal Dgrid As DataGridView, ByVal Txt As String) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        Dgrid.Columns(DColumn).Frozen = True
    End Function
    Public Function UnFreezeColumn(ByVal Dgrid As DataGridView, ByVal Txt As String) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        Dgrid.Columns(DColumn).Frozen = False
    End Function
    Public Function DColumnVisible(ByVal Dgrid As DataGridView, ByVal Txt As String) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        Dgrid.Columns(DColumn).Visible = True
    End Function
    Public Function DColumnAllVisible(ByVal Dgrid As DataGridView, ByVal Txt As String) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        For DColumn = 0 To Dgrid.Columns.Count - 1
            Dgrid.Columns(DColumn).Visible = True
        Next

    End Function

    Public Function DColumnInVisible(ByVal Dgrid As DataGridView, ByVal Txt As String) As String
        DColumn = Dgrid.CurrentCell.ColumnIndex
        DRow = Dgrid.CurrentCell.RowIndex
        Dgrid.Columns(DColumn).Visible = False
    End Function
    Public Function FindTxt(ByVal txt As String, ByVal FndTxt As String) As Boolean
        If InStr(txt, FndTxt) = 0 Then
            FindTxt = False
        Else
            FindTxt = True

        End If
    End Function
    Public Function AddRows(ByVal HowMany As String, ByVal Bp As BindingSource) As Boolean
        If HowMany = Bp.Count Then
            AddRows = False
            Exit Function
        End If


bindger:
        If HowMany > Bp.Count Then
            Bp.AddNew()
            Bp.EndEdit()
            AddRows = True

        End If
        If HowMany > Bp.Count Then GoTo bindger
    End Function
    'Public Function Convert(ByVal Txt As String, ByVal Enry As Boolean)

    '    If Enry = True Then
    '        gb = Asc(Txt.ToCharArray)
    '        gb = Val(gb * 4 + 5) * 9
    '        Txt = gb
    '        gv = Asc(Txt.ToCharArray)

    '        Convert = gv
    '        WGeT = gv
    '    Else
    '        For I = 0 To Txt.Length - 1
    '            gb = Chr(mid()

    '        Next


    '    End If
    'End Function
    Public Function InsPro(ByVal Prb As ProgressBar, ByVal UpNum As String)
        If (Prb.Value + Val(UpNum)) >= Prb.Maximum Then
            Prb.Value = Prb.Maximum
        Else
            Prb.Value = Prb.Value + Val(UpNum)
        End If
    End Function
    Public Function InsPro(ByVal Prb As ToolStripProgressBar, ByVal UpNum As String)
        If (Prb.Value + Val(UpNum)) >= Prb.Maximum Then
            Prb.Value = Prb.Maximum
        Else
            Prb.Value = Prb.Value + Val(UpNum)
        End If
    End Function
    'public Function GridComboData(CmboSr as ComboBox ,AddToGridCmbo as DataGridViewcom
    Public Function ShowObj(ByVal obj As Object)
        q = obj.GetType
        If InStr(q, "Context") <> 0 Or InStr(q, "form") <> 0 Or InStr(q, "menu") <> 0 Then
            xd = Windows.Forms.Cursor.Position.X
            yd = Windows.Forms.Cursor.Position.Y
            If xd <> 0 And yd <> 0 Then
                obj.show(xd, yd)
            End If
        End If
    End Function
    Public Function ProMake(ByVal Pic As PictureBox, ByVal SetValue As String)

    End Function
    Public Function LstDeleteandSelect(ByVal lst As ListBox, ByVal Del As Integer)
        On Error Resume Next
        chq = lst.Items.Count
        If lst.Items.Count > 0 Then
            If Del > -1 Then
                lst.Items.RemoveAt(Del)
            End If
            If (chq - 1) >= Del Then
                lst.SelectedIndex = Del
            Else
                If (lst.Items.Count > 0) And (Del >= 2) Then
                    lst.SelectedIndex = Del - 2
                End If

            End If
        End If
    End Function
    Public Function LstDeleteSelAllItems(ByVal Lst As ListBox)
        Dim Dlin As String
        On Error Resume Next
        'MsgBox(Lst.SelectedItems.Count)
        For PrVI = (Lst.SelectedItems.Count - 1) To 0 Step -1
            Dlin = Lst.SelectedItems.Item(PrVI).ToString
            'MsgBox(Dlin)
            'If Me.FindInObjectAndSelect(Lst, Dlin, True, False, False) = True Then
            Lst.Items.Remove(Dlin)
            'End If



        Next
    End Function
    Public Function LstCopyAllSelected(ByVal CopyFromLst As ListBox, ByVal PasteIn As ListBox, ByVal Unique As Boolean)
        On Error Resume Next
        For PrVI = 0 To CopyFromLst.SelectedItems.Count - 1
            If Unique = True Then
                Me.UniqueAdd(PasteIn, CopyFromLst.SelectedIndices.Item(PrVI).ToString)
            Else
                PasteIn.Items.Add(CopyFromLst.SelectedIndices.Item(PrVI).ToString)

            End If
        Next
    End Function
    Public Function AddComboToAnother(ByVal Com As ComboBox, ByVal Com2 As ComboBox)
        For PrVI = 0 To Com.Items.Count - 1
            Me.UniqueAdd(Com2, Com.Items.Item(PrVI).ToString)
        Next
    End Function
    ''' <summary>
    ''' Items CollectFrom Com and Send to Com2
    ''' </summary>
    ''' <remarks>Items CollectFrom Com and Send to Com2</remarks>
    ''' <returns>Items CollectFrom Com and Send to Com2</returns>
    Public Function AddComboToAnother(ByVal Com As ComboBox, ByVal Com2 As ToolStripComboBox)
        'MsgBox(Com.Items.Count)
        For PrVI = 0 To Com.Items.Count - 1
            'MsgBox(Com.Items.Item(PrVI).ToString)
            Me.UniqueAdd(Com2, Com.Items.Item(PrVI).ToString)
        Next
    End Function
    Public Function AddComboToAnother(ByVal Com As ListBox, ByVal Com2 As ListBox)
        For PrVI = 0 To Com.Items.Count - 1
            Me.UniqueAdd(Com2, Com.Items.Item(PrVI).ToString)
        Next
    End Function
    Public Function DelRecAll(ByVal TitleOFTable As String, ByVal mdw As BindingSource) As Boolean
        On Error Resume Next

        If MsgBox("Do you want to Delete all Records from " & TitleOFTable & "?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            On Error Resume Next
            DelRecAll = True
            'Try
            'MsgBox(mdw.Count - 1)
            de = mdw.Count - 1
            For PrVI = Val(de) To (0) Step -1
                On Error Resume Next

                mdw.RemoveAt(PrVI)
                mdw.EndEdit()
            Next
            'Catch ex As Exception
            '    Epx()
            '    Exit Function
            'End Try
        Else
            DelRecAll = False
        End If
    End Function
    Public Function MsgTr(ByVal Msgtxt As String) As Boolean
        If MsgBox(Msgtxt, MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgTr = True
        Else
            MsgTr = False
        End If
    End Function

    Public Function ComSelIndex(ByVal com As ComboBox)
        If com.SelectedIndex = -1 Then
            com.SelectedIndex = 0
        End If
    End Function
    Public Function ComSelIndex(ByVal com As ToolStripComboBox)
        If com.SelectedIndex = -1 Then
            com.SelectedIndex = 0
        End If
    End Function
    Public Function ConvertOnlyForTerminalForm(ByVal SelfNumber As String, ByVal Total As String, ByVal Convert As String)
        If Val(Total) > 0 Then
            If Val(SelfNumber) = 0 Then
                ConvertOnlyForTerminalForm = Convert

            Else
                ConvertOnlyForTerminalForm = ConvertAndSentsConvetrs(SelfNumber, Total, Convert)
            End If

        ElseIf Val(Total) = 0 Or SelfNumber = 0 Then
            ConvertOnlyForTerminalForm = Val(Convert)
        End If
    End Function
    Public Function DrmcNumberCon(ByVal SelfNumber As String, ByVal Total As String, ByVal Convert As String)
        If Val(Total) > 0 Then
            DrmcNumberCon = ConvertAndSentsConvetrs(SelfNumber, Total, Convert)
        ElseIf Val(Total) = 0 Then
            DrmcNumberCon = Val(SelfNumber)
        End If
    End Function
    Public Function GivePoints2(ByVal Num As String) As String
        'cf = Num
        'gh = InStr(cf, ".")
        'If gh > 0 Then
        '    lpx = Len(cf)
        '    gt = Mid(cf, 1, gh - 1)
        '    g = Mid(cf, gh + 1, 2)
        '    If (Val(gh) + 3) <= Val(lpx) Then
        '        m = Val(gt) & "." & Val(g)
        '        ewq = Replace(cf, m, "")
        '        dws = Mid(ewq, 1, 1)
        '        If dws >= 5 Then
        '            Mid(g, Len(g), 1) = Val(Mid(g, Len(g), 1)) + 1
        '        End If
        '        xw = Val(gt) & "." & Val(g)
        '        gt = Mid(xw, 1, Len(xw))
        '    Else
        '        gt = Val(cf)

        '    End If
        'Else
        '    gt = Val(cf)
        'End If
        'GivePoints2 = Val(gt)
        GivePoints2 = Format(Val(Num), "0.##")

    End Function
    Public Function DrmcPoints(ByVal DoJob As Integer, ByVal Num As String, ByVal Make1 As String, ByVal MakeHalf As String)
        If DoJob = 1 Then
            DrmcPoints = GivePoints2(Num)
        ElseIf DoJob = 2 Then
            DrmcPoints = RemoveCostomize(Num, Make1, MakeHalf)
        ElseIf DoJob = 3 Then
            DrmcPoints = RemovePoints(Num)
        End If
    End Function

    Public Function GivePoints2(ByVal Num As String, ByVal Digit As String) As String
        cf = Val(Num)
        Digit = Val(Digit) + 1
        gh = InStr(cf, ".")
        If gh > 0 Then
            gt = Mid(cf, 1, gh - 1)
            g = Mid(cf, gh + 1, Digit)
            m = Val(gt) & "." + Val(g)
            ewq = Replace(cf, m, "")
            dws = Mid(ewq, 1, 1)
            If dws >= 5 Then
                Mid(g, Len(g), 1) = Val(Mid(g, Len(g), 1)) + 1
            End If
            gt = Val(gt) & "." & Val(g)
        Else
            gt = cf
        End If
        GivePoints2 = Val(gt)
    End Function
    Public Function AddNumbers(ByVal Sum As String)
        Dim ValChk As String
        If Len(Trim(Sum)) = 0 Then
            Exit Function
        End If
cnn:
        If cr = "" Then
            cr = 1
        End If
        MsgBox(cr)
        dp = InStr(cr, Sum, "+")
        If dp > 0 Then
            dp2 = InStr(Val(dp) + 1, Sum, "+", CompareMethod.Text)
            If dp2 > 0 Then
                dp = dp + 1
                er = dp2 - 1
                dr = Val(Mid(Sum, dp, dp2 - dp))
                MsgBox(dr)
                ValChk = Val(ValChk) + Val(Mid(Sum, dp, dp2 - dp))
                cr = dp2 + 1
                GoTo cnn
            Else
                dp = dp + 1

                dr = Val(Mid(Sum, dp, Len(Sum)))
                MsgBox(dr)
                ValChk = Val(ValChk) + dr
                cr = ""
                Exit Function
            End If
        Else
            dr = Val(Mid(Sum, cr, Len(Sum)))



            MsgBox(dr)
            ValChk = Val(ValChk) + dr
            cr = ""
        End If
    End Function
    Public Function RemoveCostomize(ByVal FormNumber As String, ByVal HowtoMake1 As String, ByVal HowtomakeHalf As String) As String
        cf = Val(FormNumber)
        'MsgBox(HowtoMake1)
        'MsgBox(HowtomakeHalf, , "half")
        gh = InStr(cf, ".")
        If gh > 0 Then
            gt = Mid(cf, 1, gh - 1)
        Else
            gt = cf
        End If
        If gh > 0 Then
            g = Mid(cf, gh, 3)
            If Val(g) > Val(HowtoMake1) Then
                m = 10
                MsgBox(g, , m)
            ElseIf (Val(g) > Val(HowtomakeHalf)) And (Val(g) < Val(HowtoMake1)) Then
                m = 5
            Else
                m = 0
            End If
            fr = gt
            If m = 5 Then
                fr = fr & ".5"
            ElseIf m = 10 Then
                fr = Val(fr) + 1
            Else
                fr = fr
            End If
        Else
            fr = Val(cf)
        End If
        RemoveCostomize = Val(fr)
        WGeT = Val(fr)
    End Function
    Public Function RemovePoints(ByVal FormNumber As String) As String
        cf = Val(FormNumber)
        gh = InStr(cf, ".")
        If gh > 0 Then
            gt = Mid(cf, 1, gh - 1)
        Else
            gt = cf
        End If
        If gh > 0 Then
            g = Mid(cf, gh, 3)
            If Val(g) >= 0.46 Then
                m = 10

            Else
                m = 0
            End If
            fr = gt
            If m = 5 Then
                fr = fr & ".5"
            ElseIf m = 10 Then
                fr = Val(fr) + 1
            Else
            End If
        Else
            fr = Val(cf)
        End If
        RemovePoints = Val(fr)
        WGeT = Val(fr)
    End Function
    Public Function AukConverts_NumberPointConverts(ByVal FormNumber As String)

        'MsgBox(cf, , cf)


        cf = Val(FormNumber)
        'MsgBox(cf)
        gh = InStr(cf, ".")
        If gh > 0 Then
            g = Mid(cf, gh, Len(cf))
            'MsgBox(g, , "G")
            'MsgBox(g)
            'MsgBox(g)

            If Val(g) > 0.42 And Val(g) < 0.7 Then
                m = 5
            ElseIf Val(g) > 0.7 Then
                'MsgBox("ok")

                m = 10
            Else
                m = 0
            End If
            fr = Replace(cf, g, "", 1)

            If m = 5 Then
                fr = fr & ".5"
            ElseIf m = 10 Then
                fr = Val(fr) + 1
            Else
                'MsgBox(fr, , "a")
            End If
            'MsgBox(fr)
        Else
            fr = Val(cf)
            'MsgBox(fr)

        End If
        'MsgBox(fr, , "last")
        AukConverts_NumberPointConverts = Val(fr)
        'MsgBox(Val(fr))
        WGeT = fr

    End Function
    Public Function InPText(ByVal TextBoxName As TextBox) As Boolean
        If Trim(TextBoxName.Text) = "" Then
            TextBoxName.Text = TextI
            InPText = True
        Else
            InPText = False
        End If
    End Function
    Public Function InPText(ByVal TextBoxName As TextBox, ByVal TextI As String) As Boolean
        If Trim(TextBoxName.Text) = "" Then
            TextBoxName.Text = TextI
            InPText = True
        Else
            InPText = False
        End If
    End Function
    Public Function ComXDrmcClassTestColor(ByVal Cause1Combo As ComboBox) As ComboBox
        If Cause1Combo.Text = "CauseAccepted" Then
            Cause1Combo.ForeColor = Color.White
            Cause1Combo.BackColor = Color.Black
        ElseIf Cause1Combo.Text = "%FromTerm" Then
            Cause1Combo.ForeColor = Color.White
            Cause1Combo.BackColor = Color.Red
        ElseIf Cause1Combo.Text = "None" Then
            Cause1Combo.ForeColor = Color.Black
            Cause1Combo.BackColor = Color.White
        End If

    End Function
    Public Function ComboFind(ByVal Cause1Combo As ComboBox, ByVal CauseTextBox As String)
        m = Cause1Combo.FindStringExact(CauseTextBox)
        If m > -1 Then
            Cause1Combo.SelectedIndex = m
        End If
    End Function
    Public Function ComboFind(ByVal Cause1Combo As ComboBox, ByVal CauseTextBox As String, ByVal NotFindSelectFirst As Boolean)
        If NotFindSelectFirst = True Then
            m = Cause1Combo.FindStringExact(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            Else
                Cause1Combo.SelectedIndex = 0

            End If
        Else
            m = Cause1Combo.FindStringExact(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            End If
        End If


    End Function
    Public Function UnMatchListFind(ByVal Cause1Combo As ListBox, ByVal CauseTextBox As String)
        'If NotFindSelectFirst = True Then
        m = Cause1Combo.FindString(CauseTextBox)
        If m > -1 Then
            Cause1Combo.SelectedIndex = m
        Else
            Cause1Combo.SelectedIndex = 0

        End If

        'End If


    End Function
    Public Function UnMatchListFind(ByVal Cause1Combo As ListBox, ByVal CauseTextBox As String, ByVal NotFindSelectFirst As Boolean)
        If NotFindSelectFirst = True Then
            m = Cause1Combo.FindString(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            Else
                Cause1Combo.SelectedIndex = 0

            End If
        Else
            m = Cause1Combo.FindString(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            End If
        End If


    End Function
    Public Function UnMatchComboFind(ByVal Cause1Combo As ComboBox, ByVal CauseTextBox As String)
        'If NotFindSelectFirst = True Then
        m = Cause1Combo.FindString(CauseTextBox)
        If m > -1 Then
            Cause1Combo.SelectedIndex = m
        Else
            Cause1Combo.SelectedIndex = 0

        End If

        'End If


    End Function
    Public Function FindInObjectAndSelect(ByVal Cause1Combo As Object, ByVal CauseTextBox As Object, ByVal Exact As Boolean, ByVal NotFoundSelFirst As Boolean) As Boolean
        'If NotFindSelectFirst = True Then
        Try
            caukq = CauseTextBox.text
        Catch ex As Exception
            caukq = CauseTextBox.ToString
        End Try


        If Exact = True Then
            m = Cause1Combo.FindStringExact(caukq)
        Else
            m = Cause1Combo.FindString(caukq)
        End If

        If m > -1 Then
            Cause1Combo.SelectedIndex = m
            FindInObjectAndSelect = True
        Else
            If NotFoundSelFirst = True Then Cause1Combo.SelectedIndex = 0
            FindInObjectAndSelect = False

        End If
        ComRow = m

        'End If


    End Function
    Public Function MaxCountNumListBox(ByVal L As ListBox, ByVal L2 As ListBox, ByVal L3 As ListBox)
        Dim Nm As Decimal
        If L.Items.Count > L2.Items.Count Then
            Nm = L.Items.Count
        ElseIf L.Items.Count < L2.Items.Count Then
            Nm = L2.Items.Count
        Else
            Nm = L2.Items.Count
        End If
        If Nm < L3.Items.Count Then
            Nm = L3.Items.Count
        End If
        MaxCountNumListBox = Nm
        WGeT = MaxCountNumListBox

    End Function
    Public Function FindInObjectAndSelect(ByVal Cause1Combo As Object, ByVal CauseTextBox As Object, ByVal Exact As Boolean, ByVal NotFoundSelFirst As Boolean, ByVal GotoPos As Boolean) As Boolean
        'If NotFindSelectFirst = True Then
        Try
            caukq = CauseTextBox.text
        Catch ex As Exception
            caukq = CauseTextBox.ToString
        End Try


        If Exact = True Then
            m = Cause1Combo.FindStringExact(caukq)
        Else
            m = Cause1Combo.FindString(caukq)
        End If

        If m > -1 Then
            If GotoPos = True Then Cause1Combo.SelectedIndex = m
            FindInObjectAndSelect = True
        Else
            If NotFoundSelFirst = True Then Cause1Combo.SelectedIndex = 0
            FindInObjectAndSelect = False

        End If
        ComRow = m

        'End If


    End Function
    Public Function UnMatchComboFind(ByVal Cause1Combo As Object, ByVal CauseTextBox As String, ByVal NotFindSelectFirst As Boolean)
        If NotFindSelectFirst = True Then
            m = Cause1Combo.FindString(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            Else
                Cause1Combo.SelectedIndex = 0

            End If
        Else
            m = Cause1Combo.FindString(CauseTextBox)
            If m > -1 Then
                Cause1Combo.SelectedIndex = m
            End If
        End If


    End Function
    Public Function TextBoxColorDrmc(ByVal Cause1Combo As TextBox)
        If Cause1Combo.Text = "CauseAccepted" Then
            Cause1Combo.ForeColor = Color.White
            Cause1Combo.BackColor = Color.Black
        ElseIf UCase(Cause1Combo.Text) = "ABSENT" Then
            Cause1Combo.ForeColor = Color.White

            Cause1Combo.BackColor = Color.Black
        Else
            Cause1Combo.ForeColor = Color.Black
            Cause1Combo.BackColor = Color.White
        End If

        If UCase(Cause1Combo.Text) = "ABSENT" Then
            Cause1Combo.ForeColor = Color.Yellow
            Cause1Combo.BackColor = Color.Black
        ElseIf UCase(Cause1Combo.Text) = "AVERAGE" Then
            Cause1Combo.ForeColor = Color.White
            Cause1Combo.BackColor = Color.Red
        Else
            Cause1Combo.ForeColor = Color.White

            Cause1Combo.BackColor = Color.Black
        End If

    End Function
    Public Function SetFla(ByRef frm As System.Windows.Forms.Form, ByRef fla1 As AxShockwaveFlashObjects.AxShockwaveFlash, ByRef SameAsFla1 As AxShockwaveFlashObjects.AxShockwaveFlash) As Object
        frm.Height = VB6.TwipsToPixelsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height)
        frm.Width = VB6.TwipsToPixelsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width)
        fla1.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frm.Height))
        fla1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frm.Width))
        frm.Top = 0
        frm.Left = 0
        frm.Hide()
        SameAsFla1.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(fla1.Height))
        SameAsFla1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(fla1.Width))
        SameAsFla1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(fla1.Top))
        SameAsFla1.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(fla1.Left))
        frm.Show()
    End Function
    Public Function SetFla(ByRef frm As System.Windows.Forms.Form, ByRef fla1 As AxShockwaveFlashObjects.AxShockwaveFlash) As Object 'Set Flash one in Frm
        fla1.Top = 0
        fla1.Left = 0
        frm.Hide()
        fla1.Height = frm.Height
        fla1.Width = frm.Width
        frm.Show()
    End Function
    Public Function UniqueAdd(ByVal Lst As ListBox, ByVal Item As String) As Boolean
        c = Lst.FindStringExact(Item)
        If c = -1 Then
            UniqueAdd = True
        Else
            UniqueAdd = False
        End If
        If UniqueAdd = True Then
            Lst.Items.Add(Item)
        End If

    End Function
    Public Function UniqueAdd(ByVal IndexForADD As Integer, ByVal Lst As ListBox, ByVal Item As String) As Boolean
        c = Lst.FindStringExact(Item)
        If c = -1 Then
            UniqueAdd = True
        Else
            UniqueAdd = False
        End If
        If UniqueAdd = True Then
            Lst.Items.Add(Item)
        End If

    End Function
    Public Function UniqueAdd(ByVal Lst As ToolStripComboBox, ByVal Item As String) As Boolean
        c = Lst.FindStringExact(Item)
        If c = -1 Then
            UniqueAdd = True
        Else
            UniqueAdd = False
        End If
        If UniqueAdd = True Then
            Lst.Items.Add(Item)
        End If

    End Function
    Public Function UniqueAdd(ByVal Lst As Object, ByVal Item As String) As Boolean
        c = Lst.FindStringExact(Item)
        If c = -1 Then
            UniqueAdd = True
        Else
            UniqueAdd = False
        End If
        If UniqueAdd = True Then
            Lst.Items.Add(Item)
        End If

    End Function
    Public Function UniqueAdd(ByVal Lst As ComboBox, ByVal Item As String) As Boolean
        c = Lst.FindStringExact(Item)
        If c = -1 Then
            UniqueAdd = True
        Else
            UniqueAdd = False
        End If
        If UniqueAdd = True Then
            Lst.Items.Add(Item)
        End If

    End Function
    Public Function XPAuk(ByRef Frm As System.Windows.Forms.Form) As Object
        Dim Y As Single
        Dim X As Single
        If VB6.PixelsToTwipsY(Frm.Height) < 615 Then Frm.Height = VB6.TwipsToPixelsY(615) 'Checks that form
        If VB6.PixelsToTwipsX(Frm.Width) < 1695 Then Frm.Width = VB6.TwipsToPixelsX(1695) 'is not too small

        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        X = VB6.PixelsToTwipsX(Frm.Width) / VB6.TwipsPerPixelX 'Registers the size of the
        'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Y = VB6.PixelsToTwipsY(Frm.Height) / VB6.TwipsPerPixelY 'form in pixels

        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object CreateRectRgn(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Sum. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Sum = CreateRectRgn(5, 0, X - 5, 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CombineRgn(Sum, Sum, CreateRectRgn(3, 1, X - 3, 2), 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CombineRgn(Sum, Sum, CreateRectRgn(2, 2, X - 2, 3), 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CombineRgn(Sum, Sum, CreateRectRgn(1, 3, X - 1, 4), 2)
        'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CombineRgn(Sum, Sum, CreateRectRgn(1, 4, X - 1, 5), 2)
        CombineRgn(Sum, Sum, CreateRectRgn(0, 5, X, Y), 2)
        SetWindowRgn(Frm.Handle.ToInt32, Sum, True)
    End Function
    Public Function TransparentFrm(ByRef frm As System.Windows.Forms.Form, ByRef MakeTrans_ As Byte) As Boolean

        AukMod.SetWindowLong(frm.Handle.ToInt32, GWL_EXSTYLE, WS_EX_LAYERED)
        AukMod.SetLayeredWindowAttributes(frm.Handle.ToInt32, 0, MakeTrans_, LWA_ALPHA)
        TransparentFrm = Err.LastDllError = 0
    End Function
    Public Function DragAuk(ByRef M_frm As System.Windows.Forms.Form) As Object

        ReleaseCapture()
        SendMessage(M_frm.Handle.ToInt32, &HA1S, 2, 0)
    End Function
    Function OExe(ByRef filename As String, ByRef fx As System.Windows.Forms.Form) As Object

        AukMod.ShellExecute(fx.Handle.ToInt32, "open", filename, "", "", 10)
    End Function
    'Public Sups As String
    Public Function SizeForm(ByRef frm As System.Windows.Forms.Form, ByVal SizeW As String, ByVal SizeH As String, ByRef Cmd As String, ByRef Tit As String) As Object
        Dim gh As Object
        Dim mx As Object
        On Error Resume Next
        Cmd = LCase(Cmd)
        If Cmd = "ful" Then

            frm.Height = VB6.TwipsToPixelsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height)
            frm.Width = VB6.TwipsToPixelsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width)
        ElseIf Cmd = "normal" Or Cmd = "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = 15420 / 1024
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gh = CDbl(SizeW) * mx
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            frm.Width = VB6.TwipsToPixelsX(gh)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = 11580 / 768
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gh = CDbl(SizeH) * mx
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            frm.Height = VB6.TwipsToPixelsY(gh)
        End If
    End Function

    Public Function FlashHW(ByRef Flash As AxShockwaveFlashObjects.AxShockwaveFlash, ByVal SizeW As String, ByVal SizeH As String) As Object
        Dim gh As Object
        Dim mx As Object

        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mx = 15420 / 1024
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gh = CDbl(SizeW) * mx
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Flash.Width = VB6.TwipsToPixelsX(gh)
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mx = 11580 / 768
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gh = CDbl(SizeH) * mx
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Flash.Height = VB6.TwipsToPixelsY(gh)
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mx = 15420 / 1024

    End Function
    Public Function NumAsGrdValue(ByVal Num As String)
        Dim NumX As Double

        NumX = Val(Num)
        If NumX = 0 Then
            NumAsGrdValue = 0
            WGeT = 0
            Exit Function
        End If
        A_plusSt = Val(A_plusSt)
        A_St = Val(A_St)
        A_MinSt = Val(A_MinSt)
        B_ST = Val(B_ST)
        C_ST = Val(C_ST)
        Fnum = Val(Fnum)
        'MsgBox(Num)
        If Val(A_plusSt) <= NumX Then
            NumAsGrdValue = DrmcModule.APlusGrade
            WGeT = DrmcModule.APlusGrade
        End If
        If (Val(A_plusSt) > NumX) Then
            NumAsGrdValue = DrmcModule.AGrade
            WGeT = DrmcModule.AGrade
            'MsgBox(NumX, , A_St)
        End If
        If (Val(A_St) > NumX) Then
            NumAsGrdValue = DrmcModule.AMinusGrade
            WGeT = DrmcModule.AMinusGrade
            'MsgBox(NumX, , A_St)
        End If
        If (Val(A_MinSt) > NumX) Then
            NumAsGrdValue = DrmcModule.BGrade
            WGeT = DrmcModule.BGrade
        End If
        If (Val(B_ST) > NumX) Then
            NumAsGrdValue = DrmcModule.CGrade
            WGeT = DrmcModule.CGrade
        End If
        If (Val(C_ST) > NumX) Then
            NumAsGrdValue = DrmcModule.FGrade
            WGeT = DrmcModule.FGrade
        End If
    End Function
    Public Function GradePointsToGrade(ByVal NumVal As String)
        If Val(NumVal) = DrmcModule.APlusGrade Then
            GradePointsToGrade = "A+"
        ElseIf Val(NumVal) >= DrmcModule.AGrade Then
            GradePointsToGrade = "A"
        ElseIf Val(NumVal) >= DrmcModule.AMinusGrade Then
            GradePointsToGrade = "A-"
        ElseIf Val(NumVal) >= DrmcModule.BGrade Then
            GradePointsToGrade = "B"
        ElseIf Val(NumVal) >= DrmcModule.CGrade Then
            GradePointsToGrade = "C"
        ElseIf Val(NumVal) >= DrmcModule.FGrade Then
            GradePointsToGrade = "F"
        End If
    End Function
    Public Function GradeToGradePoints(ByVal NumVal As String)
        If NumVal.ToUpper = "A+" Then
            GradeToGradePoints = DrmcModule.APlusGrade
        ElseIf NumVal.ToUpper = "A" Then
            GradeToGradePoints = DrmcModule.AGrade
        ElseIf NumVal.ToUpper = "A-" Then
            GradeToGradePoints = DrmcModule.AMinusGrade
        ElseIf NumVal.ToUpper = "B" Then
            GradeToGradePoints = DrmcModule.BGrade
        ElseIf NumVal.ToUpper = "C" Then
            GradeToGradePoints = DrmcModule.CGrade
        ElseIf NumVal.ToUpper = "F" Then
            GradeToGradePoints = DrmcModule.FGrade
        End If

    End Function

    Public Function CutWordLetter(ByVal AddingList As ComboBox, ByVal txt As String, ByVal Key As String)
d:
        'MsgBox(txt)
        For PrVI = 1 To Len(txt)
            If Mid(txt, PrVI, Len(Key)) = Key Then
                If Trim(Left(txt, (PrVI - 1))) = "" Then Exit Function


                AddingList.Items.Add(Left(txt, (PrVI - 1)))
                txt = Right(txt, Len(txt) - PrVI)
                'MsgBox(txt)
                If Len(txt) > 0 Then
                    GoTo d
                Else
                    Exit Function

                End If
            ElseIf (Mid(txt, PrVI, Len(Key)) = Key) = False And PrVI = Len(txt) Then
                If Trim(txt) = "" Then Exit Function
                AddingList.Items.Add(txt)
                txt = ""
                Exit Function

            End If
        Next
    End Function
    Public Function CutWordLetter(ByVal AddingList As ListBox, ByVal txt As String, ByVal Key As String)
d:
        'MsgBox(txt)
        For PrVI = 1 To Len(txt)
            If Mid(txt, PrVI, Len(Key)) = Key Then
                AddingList.Items.Add(Left(txt, (PrVI - 1)))
                If Trim(Left(txt, (PrVI - 1))) = "" Then Exit Function
                txt = Right(txt, Len(txt) - PrVI)
                'MsgBox(txt)
                If Len(txt) > 0 Then
                    GoTo d
                Else
                    Exit Function

                End If
            ElseIf (Mid(txt, PrVI, Len(Key)) = Key) = False And PrVI = Len(txt) Then
                If Trim(txt) = "" Then Exit Function
                AddingList.Items.Add(txt)
                txt = ""
                Exit Function

            End If
        Next
    End Function
    Public Function CutWordLetter(ByVal AddingList As Object, ByVal txt As String, ByVal Key As String, ByVal SingleTxt As Boolean, ByVal BlankAdd As Boolean)
d:
        'txt=trim(txt)
        'MsgBox(txt)
        For PrVI = 1 To Len(txt)
            If Mid(txt, PrVI, Len(Key)) = Key Then
                If BlankAdd = False Then
                    If Trim(Left(txt, (PrVI - 1))) = "" Then Exit Function
                End If

                If SingleTxt = True Then
                    gh = Left(txt, (PrVI - 1))
                    c = AddingList.FindStringExact(gh)
                    If c = -1 Then
                        AddingList.Items.Add(gh)
                    End If
                End If

                txt = Right(txt, Len(txt) - PrVI)
                'MsgBox(txt)
                If Len(txt) > 0 Then
                    GoTo d
                Else
                    Exit Function

                End If
            ElseIf (Mid(txt, PrVI, Len(Key)) = Key) = False And PrVI = Len(txt) Then
                If BlankAdd = False Then
                    If Trim(txt) = "" Then Exit Function
                End If

                c = AddingList.FindStringExact(txt)
                'MsgBox(c)

                If c = -1 Then
                    AddingList.Items.Add(txt)
                End If
                txt = ""
                Exit Function

            End If
        Next
    End Function
    Public Function CutWordLetter(ByVal AddingList As ListBox, ByVal txt As String, ByVal Key As String, ByVal SingleTxt As Boolean, ByVal BlankAdd As Boolean)
d:
        'txt=trim(txt)
        'MsgBox(txt)
        For PrVI = 1 To Len(txt)
            If Mid(txt, PrVI, Len(Key)) = Key Then
                If BlankAdd = False Then
                    If Trim(Left(txt, (PrVI - 1))) = "" Then Exit Function
                End If

                If SingleTxt = True Then
                    gh = Left(txt, (PrVI - 1))
                    c = AddingList.FindStringExact(gh)
                    If c = -1 Then
                        AddingList.Items.Add(gh)
                    End If
                End If

                txt = Right(txt, Len(txt) - PrVI)
                'MsgBox(txt)
                If Len(txt) > 0 Then
                    GoTo d
                Else
                    Exit Function

                End If
            ElseIf (Mid(txt, PrVI, Len(Key)) = Key) = False And PrVI = Len(txt) Then
                If BlankAdd = False Then
                    If Trim(txt) = "" Then Exit Function
                End If

                c = AddingList.FindStringExact(txt)
                'MsgBox(c)

                If c = -1 Then
                    AddingList.Items.Add(txt)
                End If
                txt = ""
                Exit Function

            End If
        Next
    End Function
    Public Function CutWordLetter(ByVal AddingList As ListBox, ByVal txt As String, ByVal Key As String, ByVal SingleTxt As Boolean)
d:
        'txt=trim(txt)
        'MsgBox(txt)
        For PrVI = 1 To Len(txt)
            If Mid(txt, PrVI, Len(Key)) = Key Then
                If Trim(Left(txt, (PrVI - 1))) = "" Then Exit Function
                If SingleTxt = True Then
                    gh = Left(txt, (PrVI - 1))
                    c = AddingList.FindStringExact(gh)
                    If c = -1 Then
                        AddingList.Items.Add(gh)
                    End If
                End If

                txt = Right(txt, Len(txt) - PrVI)
                'MsgBox(txt)
                If Len(txt) > 0 Then
                    GoTo d
                Else
                    Exit Function

                End If
            ElseIf (Mid(txt, PrVI, Len(Key)) = Key) = False And PrVI = Len(txt) Then
                If Trim(txt) = "" Then Exit Function
                c = AddingList.FindStringExact(txt)
                'MsgBox(c)

                If c = -1 Then
                    AddingList.Items.Add(txt)
                End If
                txt = ""
                Exit Function

            End If
        Next
    End Function
    Public Function CutWordLetter(ByVal AddingList As ComboBox, ByVal txt As String, ByVal Key As String, ByVal SingleTxt As Boolean)
d:
        'MsgBox(txt)
        For PrVI = 1 To Len(txt)
            If Mid(txt, PrVI, Len(Key)) = Key Then
                If Trim(Left(txt, (PrVI - 1))) = "" Then Exit Function
                If SingleTxt = True Then
                    gh = Left(txt, (PrVI - 1))
                    c = AddingList.FindStringExact(gh)
                    If c = -1 Then
                        AddingList.Items.Add(gh)
                    End If
                End If

                txt = Right(txt, Len(txt) - PrVI)
                'MsgBox(txt)
                If Len(txt) > 0 Then
                    GoTo d
                Else
                    Exit Function

                End If
            ElseIf (Mid(txt, PrVI, Len(Key)) = Key) = False And PrVI = Len(txt) Then
                c = AddingList.FindStringExact(txt)
                'MsgBox(c)
                If Trim(txt) = "" Then Exit Function
                If c = -1 Then
                    AddingList.Items.Add(txt)
                End If
                txt = ""
                Exit Function

            End If
        Next
    End Function
    Public Function FlashMinus(ByRef Flash As AxShockwaveFlashObjects.AxShockwaveFlash, ByVal SizeW As String, ByVal SizeH As String) As Object
        Dim kl As Object
        Dim Hj As Object
        Dim gh As Object
        Dim mx As Object
        On Error Resume Next

        If SizeW = "" Or CDbl(SizeW) = 0 Then
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = 1024 / 15420
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gh = VB6.PixelsToTwipsX(Flash.Width) * mx
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Hj. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Hj = gh - SizeW
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = 15420 / 1024
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Hj. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object kl. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            kl = Hj * mx
            'UPGRADE_WARNING: Couldn't resolve default property of object kl. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Flash.Width = VB6.TwipsToPixelsX(kl)
        End If
        If SizeH = "" Or CDbl(SizeH) = 0 Then
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = 768 / 11580
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            gh = VB6.PixelsToTwipsY(Flash.Height) * mx

            'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Hj. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Hj = gh - SizeH

            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = 11580 / 768
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Hj. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object kl. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            kl = Hj * mx
            'UPGRADE_WARNING: Couldn't resolve default property of object kl. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Flash.Height = VB6.TwipsToPixelsY(kl)
        End If



    End Function
    Public Function GetFormSize(ByRef frm As System.Windows.Forms.Form) As String
        Dim WGH As Object
        Dim WGD As Object
        Dim gh As Object
        Dim mx As Object

        On Error Resume Next
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mx = 1024 / 15420
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gh = VB6.PixelsToTwipsX(frm.Width) * mx

        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object WGD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        WGD = gh

        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mx = 768 / 11580
        'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gh = VB6.PixelsToTwipsY(frm.Height) * mx
        'UPGRADE_WARNING: Couldn't resolve default property of object gh. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object WGH. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        WGH = gh

        'UPGRADE_WARNING: Couldn't resolve default property of object WGH. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object WGD. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFormSize = WGD & "x" & WGH

    End Function
    Public Function FullScreenSet(ByRef frm As System.Windows.Forms.Form, ByRef fla As AxShockwaveFlashObjects.AxShockwaveFlash)
        frm.Height = Screen.PrimaryScreen.Bounds.Height
        frm.Width = Screen.PrimaryScreen.Bounds.Width
        fla.Height = frm.Height
        fla.Width = frm.Width
        fla.Top = 0
        fla.Left = 0
        frm.Top = 0
        frm.Left = 0
        'frm.Top = 0
        'frm.Left = 0
        'frm.Hide()
        'frm.Show()
    End Function
    Public Function FullScreenSet(ByRef frm As System.Windows.Forms.Form, ByVal ToPOSiz As Boolean)
        frm.Height = Screen.PrimaryScreen.Bounds.Height
        frm.Width = Screen.PrimaryScreen.Bounds.Width
        If ToPOSiz = True Then
            frm.Top = 0
            frm.Left = 0
        End If


        'frm.Top = 0
        'frm.Left = 0
        'frm.Hide()
        'frm.Show()
    End Function
    Public Function CountFind(ByRef Where As String, ByRef What As String, ByRef Match As Boolean)
        Dim ko As Object
        Dim Lk As Object
        Dim d As Object
        Dim i As Object
        Dim lx As Object
        Dim WGeT As Object
        Dim F As Object
        Dim lastPos As Object
        Dim CountMinus1 As Object
        Dim Wh As String
        Dim what2 As String
        'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CountMinus1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object lastPos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lastPos = 1
        If Match = True Then
            Wh = Where
            what2 = What
        Else
            Wh = LCase(Where)
            what2 = LCase(What)
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object F. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        F = InStr(1, Wh, what2)
        'UPGRADE_WARNING: Couldn't resolve default property of object F. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If F = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WGeT = 0

            Exit Function
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object lx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lx = Len(Wh)
        'UPGRADE_WARNING: Couldn't resolve default property of object lx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For i = 1 To lx
            'MsgBox lastPos
            'UPGRADE_WARNING: Couldn't resolve default property of object lastPos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If lastPos = "" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object lastPos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lastPos = 1
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object lastPos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object d. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            d = InStr(lastPos, Wh, what2)
            'MsgBox d
            'UPGRADE_WARNING: Couldn't resolve default property of object d. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If d = 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                WGeT = CountMinus1
                Exit Function
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object Lk. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Lk = Len(what2)
                'UPGRADE_WARNING: Couldn't resolve default property of object Lk. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object d. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object lastPos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lastPos = Val(d) + Val(Lk)
                'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                CountMinus1 = Val(CountMinus1) + 1
                'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                WGeT = CountMinus1
                'UPGRADE_WARNING: Couldn't resolve default property of object lastPos. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ko. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ko = InStr(lastPos, Wh, what2)
                'MsgBox lastPos, , "last"
                'MsgBox lx, , "len"
                'UPGRADE_WARNING: Couldn't resolve default property of object ko. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If ko = 0 Then
                    'MsgBox "tr"
                    Exit Function
                End If

            End If
        Next i



    End Function

    Public Function CtMn2(ByRef FormWhere As String, ByVal Howmany As String, ByRef Match As Boolean, ByRef What As String, ByRef LastWhatShow As Boolean, ByRef CutGet As Boolean) As Object
        Dim WhMax As Object
        Dim i As Object
        Dim xF As Object
        Dim mdx As Object
        Dim WGeT As Object
        Dim CountMinus1 As Object
        Dim m As Object
        On Error GoTo b
        'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        m = InStr(FormWhere, What)
        'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CountMinus1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If m = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WGeT = ""
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mdx = Len(FormWhere)

            If CutGet = True Then
                'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                xF = Mid(FormWhere, 1, mdx)
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                xF = Mid(FormWhere, 1, mdx - 1)
            End If
            'MsgBox Howmany
            'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Do While CountMinus1 < Howmany
                'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                For i = Val(mdx) To 1 Step -1

                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Mid(xF, i, 1) = What Then CountMinus1 = Val(CountMinus1) + 1

                    'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CountMinus1 = Howmany Then

                        If CutGet = False Then

                            If LastWhatShow Then
                                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                WGeT = Left(xF, i)
                            Else
                                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                WGeT = Left(xF, i - 1)
                                'MsgBox WGeT

                            End If
                        Else
                            If LastWhatShow Then
                                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                WGeT = Right(xF, mdx - i)
                            Else
                                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                WGeT = Right(xF, mdx - i)
                            End If
                        End If


                        'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CountMinus1 = 0
                        Exit Do
                    End If
                Next i
            Loop
        End If

b:
        If Err.Number = 5 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object WhMax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WhMax = ""
        End If
    End Function

    Public Function CtMn1(ByRef FormWhere As String, ByVal Howmany As String, ByRef Match As Boolean, ByRef What As String) As Object
        Dim WhMax As Object
        Dim i As Object
        Dim xF As Object
        Dim mdx As Object
        Dim WGeT As Object
        Dim CountMinus1 As Object
        Dim m As Object
        On Error GoTo b
        'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        m = InStr(FormWhere, What)
        'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CountMinus1 = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If m = 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WGeT = ""
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mdx = Len(FormWhere)

            'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            xF = Mid(FormWhere, 1, mdx - 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Do While CountMinus1 < Howmany
                'UPGRADE_WARNING: Couldn't resolve default property of object mdx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                For i = Val(mdx) To 1 Step -1

                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Mid(xF, i, 1) = What Then CountMinus1 = Val(CountMinus1) + 1

                    'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If CountMinus1 = Howmany Then

                        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object xF. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object WGeT. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        WGeT = Left(xF, i)

                        'UPGRADE_WARNING: Couldn't resolve default property of object CountMinus1. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        CountMinus1 = 0
                        Exit Do
                    End If
                Next i
            Loop
        End If

b:
        If Err.Number = 5 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object WhMax. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WhMax = ""
        End If
    End Function



End Class
