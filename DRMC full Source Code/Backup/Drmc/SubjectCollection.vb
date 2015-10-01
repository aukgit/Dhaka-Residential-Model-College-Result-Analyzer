Public Class SubjectCollection

    Private Sub SubjectsCollectionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectsCollectionBindingNavigatorSaveItem.Click
        For I = 0 To Me.AuksoftDataSet1.SubjectsCollection.Count - 1
            Me.AuksoftDataSet1.SubjectsCollection(I).Subjects = UCase(Me.AuksoftDataSet1.SubjectsCollection(I).Item(0))

        Next
        Me.Validate()
        Me.SubjectsCollectionBindingSource.EndEdit()
        Me.SubjectsCollectionTableAdapter.Update(Me.AuksoftDataSet1.SubjectsCollection)

    End Sub

    Private Sub SubjectCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.SubjectsCollection' table. You can move, or remove it, as needed.
        Me.SubjectsCollectionTableAdapter.Fill(Me.AuksoftDataSet1.SubjectsCollection)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If AukF.MsgTr(WhatDoso) = True Then
            For I = 0 To Me.SubjectsCollectionBindingSource.Count - 1
                Me.AuksoftDataSet1.SubjectsCollection(I).SubJectShowName = Me.AuksoftDataSet1.SubjectsCollection(I).Item("Subjects").ToString

            Next
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If AukF.MsgTr(WhatDoso) = True Then
            Me.SubjectsCollectionBindingSource.CancelEdit()
            Me.AuksoftDataSet1.RejectChanges()

        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim m As New SubjectsPrint
        m.Database.Tables(0).SetDataSource(Me.AuksoftDataSet1)
        ReportViewer.Show()
        ReportViewer.CrystalReportViewer1.ReportSource = m

    End Sub
End Class