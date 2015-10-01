Public Class Image_Browser

    Private Sub Image_Browser_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    

    End Sub
    Public Sub Save()
        Try
            Me.Validate()
            Me.InformationIDBindingSource.EndEdit()
            Me.InformationIDTableAdapter.Update(Me.InformationIDBindingSource.DataSource)
        Catch ex As Exception
            Epx()

        End Try
 
    End Sub
    Private Sub Image_Browser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If AukF2.Check_Data_Object_Is_ChageOrNot(Me.InformationIDBindingSource) = True Then
            If AukF.MsgTr(What & "Save ?") = True Then
                Save()
            End If
        End If
        Informations.Show()
        Informations.Activate()
        'e.Cancel = False

        'Me.Close()
 
    End Sub

    Private Sub Image_Browser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        'Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        If Me.DataGridView1.CurrentCell.ColumnIndex = 3 Then
            Dim uk As New OpenFileDialog
            uk.Filter = "Jpg Files|*.jpg|Png Files|*.Png|Bmp Files|*.Bmp|Gif Files|*.Gif|All Files|*.*"

            uk.Title = "Browse Image for Students..."
            uk.FilterIndex = 0
            If uk.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Me.DataGridView1.CurrentCell.DataGridView(2, Me.DataGridView1.CurrentCell.RowIndex).Value = System.Drawing.Image.FromFile(uk.FileName.ToString)
                    Me.DataGridView1.CurrentCell.DataGridView(4, Me.DataGridView1.CurrentCell.RowIndex).Value = uk.FileName.ToString

                Catch ex As Exception
                    Epx()
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Save()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Student_Image_property.Visible = True

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Student_Image_property.Visible = False


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        AukF2.Single_DataRecordRefresh(Me.InformationIDBindingSource)

    End Sub
End Class