Public Class FullViewResult
    Dim COnQua As String
    Dim SubIDS As String
    Dim QMainID As String
    Dim SubIDF As String
    Public Tms As String
    Dim Working As Boolean
    Dim Job As Integer
    Dim Yr As String
    Dim Clx As String
    Dim Subx As String
    Dim Shv As String
    Dim TR As String
    Dim Secx As String
    Dim SubPosX As Integer
    'Dim  As String
    Dim DefMain As String
    Dim T3rd As Boolean
    Dim Vid As String
    Dim SummaryID As String
    Dim GwRk As String = GTxt
    Dim APos, SingPos, ObjPos, SubjPos, ClPos, GrkPos As Integer
    Dim SubjectPosition As Integer
    Dim DefCn As New DataTable
    Dim Lq As Integer
    Dim WrkBind As New BindingSource
    Dim SvAdp As OleDb.OleDbDataAdapter
    Dim Nine As Boolean
    Dim SubCombo As New ComboBox
    Dim ConvertedNumConvertSubjective As String
    Dim ConvertedNumConvertObjective As String
    Dim N As New DataGridView
    Private Sub FullViewResult_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 100

    End Sub

    Private Sub FullViewResult_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 50

    End Sub
    Private Sub FullViewResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Secx = Sec
        Clx = ClasT
        Yr = Yearx
        Subx = Subject
        Shv = Shift
        TR = Term
        SubPosX = SubPos
        T3rd = Trd

    End Sub
    Public Sub Opener()
        'SubPosX = 5 + (Val(Me.SubjectList.SelectedIndex))
        Working = True


        Vid = Yr & Clx & Secx & TR
        MainID = Yr & Clx & Secx & Subx & TR & Shv & Collegeno
        UMainID = Clx & Secx & TR & Shv & Yr & Collegeno
        SubID = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & TR & ")Shift(" & Shv & ")"
        SubIDF = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "FIRST TERM" & ")Shift(" & Shv & ")"
        SubIDS = "Year(" & Yr & ")" & "ClassSec(" & Clx & Secx & ")" & "tr(" & "SECOND TERM" & ")Shift(" & Shv & ")"
        DefMain = Subx & "_" & Clx & "_" & "Term"
        DefMain2 = Subx & "_" & Clx & "_" & "ClassTest"
        Me.Acc2ConvertBindingSource.Filter = "ConvertQuality=''"
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "Acc2Convert", "val(Collegeno)", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "objective", "", Me.AuksoftDataSet1)
        SFC("subid")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "subjective", "", Me.AuksoftDataSet1)
        If Val(Clx) > 8 Then
            If GwRk = "Commerce" Or GwRk = "Science" Or GwRk = "Human" Then
                SFC("subid")
                STC(SubID)
                GSql.Sql_ORD_like_false("*", GwRk, "", Me.AuksoftDataSet1)
                WrkBind.DataSource = Me.AuksoftDataSet1
                WrkBind.DataMember = GwRk
                Me.DataGridView5.DataSource = WrkBind
                Me.BindingNavigator8.BindingSource = WrkBind

                For I = 0 To 2
                    Me.DataGridView5.Columns(I).Visible = False
                Next
                Me.DataGridView5.Columns(3).ReadOnly = True

            Else
                MsgBox("Error In Section Subject Contact With Developer...!Serious Error To Edit Numbers", MsgBoxStyle.Critical)
                Me.Close()
            End If
        End If
  
        SFC("SubID")
        STC(SubID)
        GSql.Sql_ORD_like_false("*", "grading", "", Me.AuksoftDataSet1)

    End Sub
    Private Sub Grdview_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grdview.CellContentClick

    End Sub

    Private Sub ResultView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ResultView.CellContentClick

    End Sub

    Private Sub SelectedColumnFreezeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedColumnFreezeToolStripMenuItem.Click

        'MsgBox(Me.Cursor.GetType.ToString)
        'For I = 0 To Me.Controls.Count - 1
        '    If Me.Controls.Item(I).Parent.S Then
        '        MsgBox(Me.Controls.Item(I).Name)
        '    End If
        'Next
        'If Me.TabPage2.Focused Then
        '    N = Me.DataGridView1
        'ElseIf Me.TabPage3.Focused Then
        '    N = Me.DataGridView2
        'ElseIf Me.TabPage4.Focused Then
        '    N = Me.DataGridView3
        'ElseIf Me.TabPage5.Focused Then
        '    N = Me.DataGridView4
        'ElseIf Me.TabPage6.Focused Then
        '    N = Me.DataGridView5
        'End If
        'N = sender
        'MsgBox(N.Name)

        N.Columns.Item(N.CurrentCell.ColumnIndex).Frozen = True

    End Sub

    Private Sub SelectedColumnUnFreezeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectedColumnUnFreezeToolStripMenuItem.Click
        'Dim N As New DataGridView
        'If Me.DataGridView1.Focused Then
        '    N = Me.DataGridView1
        'ElseIf Me.DataGridView2.Focused Then
        '    N = Me.DataGridView2
        'ElseIf Me.DataGridView3.Focused Then
        '    N = Me.DataGridView3
        'ElseIf Me.DataGridView4.Focused Then
        '    N = Me.DataGridView4
        'ElseIf Me.DataGridView5.Focused Then
        '    N = Me.DataGridView5
        'End If
        'MsgBox(N.Name)

        N.Columns.Item(N.CurrentCell.ColumnIndex).Frozen = False

    End Sub

    Private Sub Saved()

        Try
            Me.SubjectiveBindingSource.EndEdit()
            Me.ObjectiveBindingSource.EndEdit()
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.WrkBind.EndEdit()
            Me.GradingBindingSource.EndEdit()
            Me.ScienceTableAdapter1.Update(Me.AuksoftDataSet1)
            Me.HumanTableAdapter1.Update(Me.AuksoftDataSet1)
            Me.CommerceTableAdapter1.Update(Me.AuksoftDataSet1)
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1)

            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1)
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1)
            Me.GradingTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Saved()

    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAllToolStripMenuItem.Click
        Saved()

    End Sub

    Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
        Saved()

    End Sub

    Private Sub Objview_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Objview.CellContentClick


    End Sub

    Private Sub ToolStripButton23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton23.Click
        Saved()

    End Sub

    Private Sub ToolStripButton58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton58.Click
        Saved()

    End Sub

    Private Sub ToolStripButton59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton59.Click
        'MsgBox(Me.Cursor.GetType.ToString)

        FilterSelectedTxtInColumnToolStripMenuItem_Click(sender, e)

        'Dim N As New DataGridView
        'If Me.DataGridView1.Focused Then
        '    N = Me.DataGridView1
        'ElseIf Me.DataGridView2.Focused Then
        '    N = Me.DataGridView2
        'ElseIf Me.DataGridView3.Focused Then
        '    N = Me.DataGridView3
        'ElseIf Me.DataGridView4.Focused Then
        '    N = Me.DataGridView4
        'ElseIf Me.DataGridView5.Focused Then
        '    N = Me.DataGridView5
        'End If

    End Sub

    Private Sub FullViewResult_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Opacity = 50

    End Sub

    Private Sub ResultView_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResultView.GotFocus
        N = Me.ResultView

    End Sub

    Private Sub ResultView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ResultView.UserDeletedRow

    End Sub

    Private Sub Subjview_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Subjview.CellContentClick

    End Sub

    Private Sub Subjview_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subjview.GotFocus
        N = Me.Subjview

    End Sub

    Private Sub Objview_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Objview.GotFocus
        N = Me.Objview

    End Sub

    Private Sub Grdview_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grdview.GotFocus
        N = Me.Grdview
    End Sub

    Private Sub DataGridView5_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub DataGridView5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView5.GotFocus
        N = Me.DataGridView5
    End Sub
    Public Sub FindCol(ByVal Col As String)
        Dim Aq As Integer

    End Sub



    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Me.SubjectiveBindingSource.EndEdit()
            Me.SubjectiveTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        Try
            Me.Acc2ConvertBindingSource.EndEdit()
            Me.Acc2ConvertTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Try
            Me.ObjectiveBindingSource.EndEdit()
            Me.ObjectiveTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        Try
            Me.GradingBindingSource.EndEdit()
            Me.GradingTableAdapter.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub ToolStripButton57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton57.Click
        Try
            Me.WrkBind.EndEdit()
            Me.HumanTableAdapter1.Update(Me.AuksoftDataSet1)
            Me.ScienceTableAdapter1.Update(Me.AuksoftDataSet1)
            Me.CommerceTableAdapter1.Update(Me.AuksoftDataSet1)

        Catch ex As Exception
            Epx()

        End Try
    End Sub

    Private Sub FilterSelectedTxtInColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSelectedTxtInColumnToolStripMenuItem.Click
        AukF.DataGridSelectedFilter(N, N.DataSource, "=", "", False)

    End Sub

    Private Sub FilterInSelectedColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterInSelectedColumnToolStripMenuItem.Click
        AukF.BindFilter(N.DataSource, AukF.GetGridPropertyName(N), ToolStripTextBox14.Text, "", False)


    End Sub

    Private Sub ToolStripTextBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox14.Click

    End Sub

    Private Sub ToolStripTextBox14_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox14.KeyDown
        If e.KeyCode = Keys.Enter Then
            FilterInSelectedColumnToolStripMenuItem_Click(sender, e)

        End If
    End Sub
End Class