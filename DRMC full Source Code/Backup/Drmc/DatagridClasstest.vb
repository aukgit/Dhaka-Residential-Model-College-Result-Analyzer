Public Class DatagridClasstest

    Private Sub ClassTestBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)
        Catch ex As Exception
            Epx()
        End Try


    End Sub

    Private Sub DatagridClasstest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.ClassTest' table. You can move, or remove it, as needed.
        'Me.ClassTestTableAdapter.Fill(Me.AuksoftDataSet1.ClassTest)
        ''TODO: This line of code loads data into the 'AuksoftDataSet1.ClassTest' table. You can move, or remove it, as needed.
        'Me.ClassTestTableAdapter.Fill(Me.AuksoftDataSet1.ClassTest)
        ''TODO: This line of code loads data into the 'AuksoftDataSet1.ClassTest' table. You can move, or remove it, as needed.
        'Me.ClassTestTableAdapter.Fill(Me.AuksoftDataSet1.ClassTest)

    End Sub

    Private Sub ClassTestDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ClassTestBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.ClassTestBindingSource.EndEdit()
            Me.ClassTestTableAdapter.Update(Me.AuksoftDataSet1.ClassTest)

        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub ClassTestDataGridView_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClassTestDataGridView.CellContentClick

    End Sub

    Private Sub RejectChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RejectChangesToolStripMenuItem.Click
        Me.ClassTestBindingSource.CancelEdit()
        Me.AuksoftDataSet1.ClassTest.RejectChanges()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.ClassTestDataGridView.Rows.RemoveAt(Me.ClassTestDataGridView.CurrentRow.Index)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'ClassTestBindingNavigatorSaveItem_Click_1(sender, e)
        'AddHandler (Ctmarks.ClassTestBindingNavigatorSaveItem.Click(sender, e)), AddressOf SaveToolStripMenuItem.Click(sender, e)

        'ctmarks.ClassTestBindingNavigatorSaveItem. 
        'raiseevent 

        Me.ClassTestDataGridView.Update()



    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RejectChangesToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'c = Me.ClassTestDataGridView.Columns(2).        .Find(ToolStripComboBox1.Text, ToolStripTextBox1.Text)
        'If c > -1 Then
        '    ClassTestBindingSource.Position = c

        'End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ClassTestDataGridView.DataSource = Ctmarks.AuksoftDataSet1
        Me.ClassTestDataGridView.DataMember = "ClassTest"
        'Me.ChgView.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        'DatagridClasstest.ChgView.DataMember = "ClassTest"

        Me.DeletedRows.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Deleted)
        'DatagridClasstest.DeletedRows.DataMember = "ClassTest"

        Me.ClassTestBindingSource.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        'Me.ClassTestBindingNavigator. = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        Me.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub ErrorRows_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ErrorRows.CellContentClick

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        ClassTestDataGridView.DataSource = Ctmarks.AuksoftDataSet1
        ClassTestDataGridView.DataMember = "ClassTest"

        'DatagridClasstest.ChgView.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)
        'DatagridClasstest.ChgView.DataMember = "ClassTest"

        DeletedRows.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Deleted)
        'DatagridClasstest.DeletedRows.DataMember = "ClassTest"
        ChangeRowsDatagrid.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)

        ErrorRows.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetErrors


        'DatagridClasstest.ClassTestBindingSource.DataSource = Ctmarks.AuksoftDataSet1.ClassTest.GetChanges(DataRowState.Modified)


    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Ctmarks.ClassTestBindingSource.CancelEdit()
        Ctmarks.AuksoftDataSet1.ClassTest.RejectChanges()

    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        RefreshToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ChangeRowsDatagrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ChangeRowsDatagrid.CellContentClick

    End Sub

    Private Sub ChangeRowsDatagrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChangeRowsDatagrid.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.ChangeRowsDatagrid.Rows(Me.ClassTestDataGridView.CurrentCellAddress.X).Cells.RemoveAt(Me.ClassTestDataGridView.CurrentCellAddress.X)
            Me.ChangeRowsDatagrid.Update()

        End If
    End Sub
End Class