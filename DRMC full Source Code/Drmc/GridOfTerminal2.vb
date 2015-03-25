Public Class GridOfTerminal2

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
    
    End Sub

    Private Sub ToolStripLabel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ToolStripLabel1.MouseDown
        AukF.DragAuk(Me)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GridOfTerminal2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AukF.XPAuk(Me)

    End Sub
End Class