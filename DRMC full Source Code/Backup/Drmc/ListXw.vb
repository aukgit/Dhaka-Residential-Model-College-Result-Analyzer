Public Class ListXw

    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        'If Me.CheckBox1.Checked = True Then
        AukF.CutWordLetter(Me.ListBox1, Me.ListBox2.Text, ",", True)
        'End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        If Me.CheckBox1.Checked = True Then
            AukF.CutWordLetter(Me.ListBox1, Me.ListBox2.Text, ",", True)
        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If Me.CheckBox1.Checked = True Then
        AukF.CutWordLetter(Me.ListBox1, Me.ListBox2.Text, ",", True)
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For I = 1 To Me.ListBox2.Items.Count
            MsgBox(Me.ListBox2.Items.Item(I))
            AukF.CutWordLetter(Me.ListBox1, Me.ListBox2.Items.Item(I), ",", True)

        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.ListBox1.Items.Clear()

    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Me.ListBox1.ClearSelected()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If Me.CheckBox2.Checked = True Then
            Me.ListBox1.ClearSelected()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.CheckBox3.Checked = True Then
            Informations.ListBox1.Items.Clear()
        End If

        For I = 1 To Me.ListBox1.Items.Count
            AukF.CutWordLetter(Informations.ListBox1, Me.ListBox1.Items.Item(I), ",", True)

        Next
        Me.Close()
        Informations.Show()


    End Sub

    Private Sub ListXw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuksoftDataSet1.InformationID' table. You can move, or remove it, as needed.
        Me.InformationIDTableAdapter.Fill(Me.AuksoftDataSet1.InformationID)

    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged

    End Sub

    Private Sub ComboBox10_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectionChangeCommitted
        Me.TextBox3.Text = Me.ComboBox10.Text

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        SFC("StudentClass", "Class_Section", "Shift")
        STC(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text)
        GSql.Sql_ORD_like_false("Collegeno", "informationid", "val(collegeno)", Me.AuksoftDataSet1)
        'MsgBox(Sql)

    End Sub
End Class