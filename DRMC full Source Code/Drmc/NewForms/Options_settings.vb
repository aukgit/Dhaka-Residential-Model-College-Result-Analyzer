Public Class Options_settings

    Private Sub CommentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CommentsBindingSource.EndEdit()
        Me.CommentsTableAdapter.Update(Me.AuksoftDataSet1.Comments)

    End Sub

    Private Sub Options_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.Comments' table. You can move, or remove it, as needed.
        Me.CommentsTableAdapter.Fill(Me.AuksoftDataSet1.Comments)

    End Sub
End Class