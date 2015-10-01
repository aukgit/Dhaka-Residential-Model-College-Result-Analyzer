Public Class ClassOptions

    Private Sub ClassOptionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassOptionsBindingNavigatorSaveItem.Click
        Me.Validate()
        ToolStripButton3_Click(sender, e)
        'If Me.Shift.ToString = "" Then
        '    Me.Shift.Items = "Morning"
        'End If
        Try

            Me.ClassOptionsDataGridView.EndEdit()
            Me.ClassOptionsBindingSource.EndEdit()
            Me.ClassOptionsTableAdapter.Update(Me.AuksoftDataSet1.ClassOptions)
        Catch ex As Exception
            Epx()

        End Try
   

    End Sub

    Private Sub ClassOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Sections' table. You can move, or remove it, as needed.
        Me.SectionsTableAdapter.Fill(Me.AuksoftDataSet1.Sections)
        'TODO: This line of code loads data into the 'AuksoftDataSet1.ClassOptions' table. You can move, or remove it, as needed.
        Me.ClassOptionsTableAdapter.Fill(Me.AuksoftDataSet1.ClassOptions)
        'MsgBox(Application.CommonAppDataPath, , "Application.CommonAppDataPath")
        ''MsgBox(Application.CommonAppDataRegistry, , "Application.CommonAppDataRegistry")
        'MsgBox(Application.ExecutablePath, , "Application.ExecutablePath")
        'MsgBox(Application.StartupPath, , "Application.StartupPath")

        'MsgBox()

        'Me.AuksoftDataSet1.ClassOptions.ClassSectionColumn.Expression = "[Class] + [Section]"

    End Sub

    Private Sub ClassOptionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ClassOptionsBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassOptionsBindingSource.CurrentChanged
        'GetValIns(Me.ClassOptionsBindingSource.Position)
    End Sub

    Private Sub ClassOptionsBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassOptionsBindingSource.CurrentItemChanged
        'GetValIns(Me.ClassOptionsBindingSource.Position)

    End Sub
    Public Sub GetValIns(ByVal ci As Integer)
        On Error Resume Next

        If ci > -1 Then
            clp = Me.AuksoftDataSet1.ClassOptions(ci).Item(1).ToString
            seqx = Me.AuksoftDataSet1.ClassOptions(ci).Item(3).ToString
            subsec = Me.AuksoftDataSet1.ClassOptions(ci).Item(4).ToString
            shf = Me.AuksoftDataSet1.ClassOptions(ci).Item(8).ToString


            er = clp
            If Val(er) = 3 Then
                mo = "III"
            ElseIf Val(er) = 4 Then
                mo = "IV"
            ElseIf Val(er) = 5 Then
                mo = "V"
            ElseIf Val(er) = 6 Then
                mo = "VI"
            ElseIf Val(er) = 7 Then
                mo = "VII"
            ElseIf Val(er) = 8 Then
                mo = "VIII"
            ElseIf Val(er) = 9 Then
                mo = "IX"
            ElseIf Val(er) = 10 Then
                mo = "X"
            ElseIf Val(er) = 11 Then
                mo = "XI"
            ElseIf Val(er) = 12 Then
                mo = "XII"
            End If

            If subsec = "" Or LCase(subsec) = "none" Then
                Me.AuksoftDataSet1.ClassOptions(ci).InsClass = mo & "-" & seqx
            Else
                Me.AuksoftDataSet1.ClassOptions(ci).InsClass = mo & "-" & seqx & "(" & Mid(subsec, 1, 3) & ")"
            End If

        End If
        Me.AuksoftDataSet1.ClassOptions(ci).ClassSection = er & "-" & seqx & shf
        If Me.AuksoftDataSet1.ClassOptions(ci).Item(8) = "" Then
            Me.AuksoftDataSet1.ClassOptions(ci).Item(8) = "Morning"

        End If


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tx = Me.Cursor.Position.X
        ty = Me.Cursor.Position.Y
        If tx <> ty And ty <> 0 Then
            MenuView.Show()
            MenuView.Top = ty
            MenuView.Left = tx
            'For I = 0 To 100
            '    MenuView.Opacity = I
            'Next
            MenuView.Opacity = 100

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        'Me.ClassOptionsBindingSource.EndEdit()


    End Sub

    Private Sub ClassOptionsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClassOptionsBindingSource.PositionChanged
        'GetValIns(Me.ClassOptionsBindingSource.Position)
    End Sub

    Private Sub ClassOptionsDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'GetValIns(Me.ClassOptionsBindingSource.Position)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ClassOptions_Load(sender, e)
        ToolStripButton3_Click(sender, e)

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For I = 0 To Me.ClassOptionsBindingSource.Count - 1
            GetValIns(I)
        Next
    End Sub

    Private Sub ClassOptionsDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Control Then
        '    If e.KeyCode = Keys.S Then


        '    End If

        'End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.ClassOptionsBindingSource.AddNew()
        Me.ClassOptionsBindingSource.EndEdit()
        Me.ClassOptionsDataGridView.EndEdit()

        Me.ClassOptionsDataGridView.CurrentCellAddress.Offset(Me.ClassOptionsBindingSource.Position, 0)
        'Me.ClassOptionsDataGridView.CurrentCellAddress.Y = 0
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        ClassOptionsBindingNavigatorSaveItem_Click(sender, e)
    End Sub

    Private Sub SaveAndNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAndNewToolStripMenuItem.Click
        ClassOptionsBindingNavigatorSaveItem_Click(sender, e)
        NewToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.ClassOptionsTableAdapter.FillBy(Me.AuksoftDataSet1.ClassOptions, CType(IDToolStripTextBox.Text, Integer), _ClassToolStripTextBox.Text, ClassTeacher_sNameToolStripTextBox.Text, SectionToolStripTextBox.Text, SectionSubjectNameToolStripTextBox.Text, InsClassToolStripTextBox.Text, ClassStudentsToolStripTextBox.Text, ClassSectionToolStripTextBox.Text, ShiftToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub FillQueryToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Me.ClassOptionsTableAdapter.FillQuery(Me.AuksoftDataSet1.ClassOptions, _ClassToolStripTextBox.Text, SectionToolStripTextBox.Text, ShiftToolStripTextBox.Text, SectionSubjectNameToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub ClassOptionsDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClassOptionsDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim kp As Integer
        Dim Rbrow As DataTable
        Rbrow = Me.AuksoftDataSet1.ClassOptions.Copy



        'Me.AuksoftDataSet1.ClassOptions.LoadDataRow )




        For I = 0 To Rbrow.Rows.Count - 1
            Me.ClassOptionsBindingSource.AddNew()
            Me.ClassOptionsBindingSource.EndEdit()
            For kp = 1 To Me.AuksoftDataSet1.ClassOptions.Columns.Count - 1
                Me.AuksoftDataSet1.ClassOptions(Me.ClassOptionsBindingSource.Position).Item(kp) = Rbrow.Rows(I).Item(kp).ToString
            Next
        Next
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        AukF.ComSelIndex(ToolStripComboBox1)
        m = ToolStripComboBox1.Text
        Try
            If Me.ExtactWord.Checked = True Then
                '    Me.ClassOptionsBindingSource.Filter = "[" & m & "]='" & Me.FilterText.Text & "'"
                'Else
                '    Me.ClassOptionsBindingSource.Filter = "[" & m & "] like '" & Me.FilterText.Text & "*'"
                AukF.BindFilter(Me.ClassOptionsBindingSource, m, Me.FilterText.Text, "E", True)
            Else
                AukF.BindFilter(Me.ClassOptionsBindingSource, m, Me.FilterText.Text, "Auk", True)

            End If

        Catch ex As Exception
            Epx()

        End Try
   
        'AukF.DataSetFilter(Me.AuksoftDataSet1.ClassOptions, Me.ClassOptionsBindingSource)


        'Me.ClassOptionsDataGr()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click, RemoveFilterToolStripMenuItem.Click
        Me.ClassOptionsBindingSource.RemoveFilter()
        'AukF.DataSetFilter(Me.AuksoftDataSet1.ClassOptions, Me.ClassOptionsBindingSource)

    End Sub

    Private Sub FilterSelectedTextOnDataGridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSelectedTextOnDataGridToolStripMenuItem.Click, FilterGridSelectedTextToolStripMenuItem.Click
        Dim C, R As Integer

        c = Me.ClassOptionsDataGridView.CurrentCell.ColumnIndex
        r = Me.ClassOptionsDataGridView.CurrentCell.RowIndex
        nam = Me.ClassOptionsDataGridView.Columns(C).DataPropertyName.ToString
        m = nam
        txt = Me.ClassOptionsDataGridView.CurrentCell.DataGridView(C, R).Value


        Try
            If Me.ExtactWord.Checked = True Then
                'Me.ClassOptionsBindingSource.Filter = "[" & m & "]='" & txt & "'"
                AukF.DataGridSelectedFilter(Me.ClassOptionsDataGridView, Me.ClassOptionsBindingSource, "=", "E", True)
            Else
                AukF.DataGridSelectedFilter(Me.ClassOptionsDataGridView, Me.ClassOptionsBindingSource, "=", "auk", True)


            End If
        Catch ex As Exception
            Epx()

        End Try
        'AukF.DataSetFilter(Me.AuksoftDataSet1.ClassOptions, Me.ClassOptionsBindingSource)

    End Sub

    Private Sub FilterText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterText.Click

    End Sub

    Private Sub FilterText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FilterText.KeyDown
        If e.KeyCode = Keys.Enter Then
            ToolStripMenuItem2_Click(sender, e)
            'AukF.DataSetFilter(Me.AuksoftDataSet1.ClassOptions, Me.ClassOptionsBindingSource)
            'AukF.DataSetFilter(Me.ClassOptionsBindingSource, True, True, False)

        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim m As New ClassOptionsReport
        AukF.Prnt(m, Me.AuksoftDataSet1, "ClassOptions")

    End Sub

    Private Sub SetFilterForPrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetFilterForPrintToolStripMenuItem1.Click, SetFilterForPrintToolStripMenuItem.Click
        AukF.DataSetFilter(Me.ClassOptionsBindingSource, True, True, True, True)

    End Sub

    Private Sub FilterGridSelectedTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AukF.DataGridSelectedFilter(Me.ClassOptionsDataGridView, Me.ClassOptionsBindingSource, "=", "", True)

    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRowToolStripMenuItem.Click
        AukF.DataGridDeleteItems(Me.ClassOptionsDataGridView, False, True, True)
        'Me.SaveToolStripMenuItem
        SaveToolStripMenuItem_Click(sender, e)


    End Sub

    Private Sub FilterText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FilterText.TextChanged
        AukF2.ComSelIndex(ToolStripComboBox1)

    End Sub
End Class