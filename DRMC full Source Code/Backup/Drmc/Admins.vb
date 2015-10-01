Public Class Admins

    Private Sub AdminsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminsBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.AdminsBindingSource.EndEdit()
            Me.AdminsTableAdapter.Update(Me.AuksoftDataSet1.Admins)
        Catch ex As Exception
            Epx()

        End Try


    End Sub

    Private Sub Admins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Admins' table. You can move, or remove it, as needed.
        Me.AdminsTableAdapter.Fill(Me.AuksoftDataSet1.Admins)
        'SFC("username", "password")
        'STC(Acc, StrPass)
        'GSql.Sql_ORD_like_false("*", "Admins", "", Me.AuksoftDataSet1)
        'MsgBox(Sql)

    End Sub

    Private Sub AdminsBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminsBindingNavigator.RefreshItems

    End Sub

    Private Sub AdminsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdminsDataGridView.CellContentClick

    End Sub

    Private Sub AdminsDataGridView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdminsDataGridView.CellEndEdit
        'On Error Resume Next

        'Me.AdminsDataGridView.CurrentCell.DataGridView(6, Me.AdminsDataGridView.CurrentCell.RowIndex).Value = xo(AukF.GridT(Me.AdminsDataGridView, 1))
        'Me.AdminsDataGridView.CurrentCell.DataGridView(5, Me.AdminsDataGridView.CurrentCell.RowIndex).Value = xo(AukF.GridT(Me.AdminsDataGridView, 3).ToString)
    End Sub

    Private Sub AdminsDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AdminsDataGridView.CellValueChanged
        Try
            'Me.Validate()
            Me.AdminsBindingSource.EndEdit()
            Me.AdminsTableAdapter.Update(Me.AuksoftDataSet1.Admins)
        Catch ex As Exception
            Epx()

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For I = 0 To Me.AdminsDataGridView.RowCount - 1
        '    Me.AdminsDataGridView.CurrentCell.DataGridView(1, Me.AdminsDataGridView.CurrentCell.RowIndex).Value = xo_back(AukF.GridT(sender, 7).ToString)
        '    Me.AdminsDataGridView.CurrentCell.DataGridView(3, Me.AdminsDataGridView.CurrentCell.RowIndex).Value = xo_back(AukF.GridT(sender, 5).ToString)

        'Next
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class