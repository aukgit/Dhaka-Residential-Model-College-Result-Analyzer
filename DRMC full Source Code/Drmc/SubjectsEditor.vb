Public Class SubjectsEditor
    'Dim Cmp As ComboBox
    'Dim Cmp2 As ComboBox
    Dim Bdp As New BindingSource

    Private Sub SubjectsEditor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Ctmarks.Close()

    End Sub

    Private Sub SubjectsEditor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Frm.Show()
        'Dim l As Object
        'l = Frm.FindForm
        'l.show()



    End Sub

    Private Sub SubjectsEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectPosition' table. You can move, or remove it, as needed.
        Me.SubjectPositionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectPosition)

        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectsCollection' table. You can move, or remove it, as needed.
        'Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)
        ''TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectsCollection' table. You can move, or remove it, as needed.
        'Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)


        Me.SubjectsCollectionTableAdapter1.Fill(Me.AuksoftDataSet1.SubjectsCollection)

        Me.SectionsTableAdapter1.Fill(Me.AuksoftDataSet1.Sections)

        'Me.SectionsTableAdapter1.Fill(Me.AuksoftDataSet1.Sections)
        'Cmp.DataSource = "SubjectsCollection"
        'Cmp.DisplayMember = "Subjects"
        'Cmp2.DataSource = Me.AuksoftDataSet1.SubjectsCollection
        'Cmp2.DisplayMember = "CodeNo"
        Bdp.DataSource = Me.AuksoftDataSet1
        Bdp.DataMember = "SubjectsCollection"

        Me.DataGridViewTextBoxColumn2.Items.Clear()
        Me.DataGridViewTextBoxColumn5.Items.Clear()
        For I = 0 To Me.AuksoftDataSet1.Sections.Count - 1
            Me.DataGridViewTextBoxColumn2.Items.Add(Me.AuksoftDataSet1.Sections(I).Sections.ToString)
        Next

        For I = 0 To Me.AuksoftDataSet1.SubjectsCollection.Count - 1
            Me.DataGridViewTextBoxColumn5.Items.Add(Me.AuksoftDataSet1.SubjectsCollection(I).Subjects.ToString)
        Next


    End Sub

    Private Sub SubjectsCollectionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Validate()
        'Me.SubjectsCollectionBindingSource.EndEdit()
        'Me.SubjectsCollectionTableAdapter.Update(Me.AuksoftDataSet1.SubjectsCollection)

    End Sub

    Private Sub SubjectsCollectionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub SubjectPositionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectPositionBindingNavigatorSaveItem.Click
        Dim gy As Integer
        For I = 0 To Me.SubjectPositionBindingSource.Count - 1
            gy = Bdp.Find("Subjects", Me.AuksoftDataSet1.SubjectPosition(I).Item(3))
            If gy > -1 Then
                Me.AuksoftDataSet1.SubjectPosition(I).SubjectCode = Me.AuksoftDataSet1.SubjectsCollection(gy).Item(1)

            End If
        Next
        Try
            Me.Validate()
            Me.SubjectPositionBindingSource.EndEdit()
            Me.SubjectPositionTableAdapter.Update(Me.AuksoftDataSet1.SubjectPosition)
        Catch ex As Exception
            Epx()
        End Try
       

    End Sub

    Private Sub SubjectPositionDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubjectPositionDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        SubjectCollection.Show()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        SubjectsEditor_Load(sender, e)

    End Sub

    Private Sub SubjectPositionDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SubjectPositionDataGridView.CellValueChanged
        On Error Resume Next
        Me.DataGridViewTextBoxColumn5.AutoComplete = True
        Dim sq As Integer


        'MsgBox(ds)

        ds = Me.SubjectPositionDataGridView.CurrentRow.Cells.Item(2).Value
        'MsgBox(DS)
        If Trim(DS) <> "" Then
            sq = Bdp.Find("CodeNo", ds)


            'MsgBox(sq)
            If sq > -1 Then
                Me.DataGridViewTextBoxColumn5.DataGridView(1, Me.SubjectPositionDataGridView.CurrentCell.RowIndex).Value = Me.AuksoftDataSet1.SubjectsCollection(sq).Subjects
            Else
                Me.DataGridViewTextBoxColumn5.DataGridView(1, Me.SubjectPositionDataGridView.CurrentCell.RowIndex).Value = ""
            End If
        End If
    
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim cuty As DataTable
        Dim IK As Integer
        cuty = Me.AuksoftDataSet1.SubjectPosition.Copy
        For I = 0 To cuty.Rows.Count - 1
            Me.SubjectPositionBindingSource.AddNew()
            Me.SubjectPositionBindingSource.EndEdit()
            For IK = 1 To Me.AuksoftDataSet1.SubjectPosition.Columns.Count - 1
                Me.AuksoftDataSet1.SubjectPosition(Me.SubjectPositionBindingSource.Position).Item(IK) = cuty.Rows(I).Item(IK).ToString


            Next

        Next
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim m As New SubjectsOFClass

        AukF.Prnt(m, Me.AuksoftDataSet1)

    End Sub
End Class