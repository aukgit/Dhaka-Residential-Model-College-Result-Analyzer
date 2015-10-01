Public Class HouseEdit

    Private Sub HouseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HouseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HouseBindingSource.EndEdit()
        Me.HouseTableAdapter.Update(Me.AuksoftDataSet1.House)

    End Sub

    Private Sub HouseEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.House' table. You can move, or remove it, as needed.
        Me.HouseTableAdapter.Fill(Me.AuksoftDataSet1.House)

    End Sub
End Class