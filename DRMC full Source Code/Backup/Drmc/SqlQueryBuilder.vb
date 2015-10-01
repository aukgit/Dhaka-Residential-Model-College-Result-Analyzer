Public Class SqlQueryBuilder
    Dim CyByx As String
    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub

    'Private Sub AxShockwaveFlash1_FlashCall(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FlashCallEvent) Handles AxShockwaveFlash1.FlashCall

    'End Sub

    Private Sub AxShockwaveFlash1_FSCommand(ByVal sender As Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles AxShockwaveFlash1.FSCommand
        On Error Resume Next

        Select Case e.command
            Case "new" 'new sql
                Inputs()
                CyByx = Flv.GetVariable("sqlcmd")
                'MsgBox(InStr(CyByx, "  )"))


           
                If Trim(CyByx) <> "" Then
                    If Trim(CText.Text) = "" Then
                        If InStr(CyByx, "  )") = 0 Then
                            Flv.SetVariable("sqlcmd", CyByx & "  )")
                        End If
                        CyByx = Flv.GetVariable("sqlcmd")
                        CText.Text = CyByx
                    Else
                        If InStr(CyByx, "  )") = 0 Then
                            Flv.SetVariable("sqlcmd", CyByx & "  )")
                        End If
                        CyByx = Flv.GetVariable("sqlcmd")
                        CText.Text = CText.Text & " " & Flv.GetVariable("clause") & " " & CyByx
                    End If
                End If


                xFrm.Show()
                'MsgBox("s")
                Me.Hide()
                xFrm.Enabled = True

                xFrm.Show()


            Case "add" 'add this column  
                Inputs()

            Case "auk" 'aboutme
            Case "sql" 'Costomizew

            Case "exit"
                CyByx = Flv.GetVariable("sqlcmd")
                If InStr(CyByx, "  )") = 0 Then
                    Flv.SetVariable("sqlcmd", CyByx & "  )")
                End If
                If Trim(CyByx) <> "" Then
                    If Trim(CText.Text) = "" Then
                        CText.Text = CyByx
                    Else
                        CText.Text = CText.Text & " " & Flv.GetVariable("clause") & " " & CyByx
                    End If
                End If
           

                xFrm.Show()
                'MsgBox("s")
                Me.Hide()
                xFrm.Enabled = True
            Case "drag"
                AukF.DragAuk(Me)

        End Select
    End Sub
    Private Sub Inputs()
        On Error Resume Next
        m = Flv.GetVariable("systemx")
        CyByx = Flv.GetVariable("sqlcmd")
        d = Flv.GetVariable("filter")
        If Trim(d) = "" Then Exit Sub


        If m = "AsTextQuery" Then
            If Flv.GetVariable("ext") = "false" Then
                cf = "([" & Flv.GetVariable("column") & "] like '%"
                cf_Cl = "%'"
            Else
                cf = "([" & Flv.GetVariable("column") & "] ='"
                cf_Cl = "'"
            End If
            If Trim(CyByx) = "" Then
                CyByx = "(  " & cf & Flv.GetVariable("filter") & cf_cl & ")"
            Else
                If InStr(CyByx, cf & Flv.GetVariable("filter")) = 0 Then
                    CyByx = CyByx & " " & Flv.GetVariable("clause") & " " & cf & Flv.GetVariable("filter") & cf_cl & ")"

                End If

            End If
        Else
            'If Flv.GetVariable("ext") = "false" Then
            cf = "val(([" & Flv.GetVariable("column") & "])" & Flv.GetVariable("operators")

            'cf_Cl = ""
            'Else
            'cf = "(val([" & Flv.GetVariable("column") & "]) " & Flv.GetVariable("operators")
            'cf_Cl = "'"
            'End If
            If Trim(CyByx) = "" Then
                CyByx = "(  " & cf & "" & Flv.GetVariable("filter") & ")"
            Else
                If InStr(CyByx, cf & Flv.GetVariable("filter") & ")") = 0 Then
                    CyByx = CyByx & " " & Flv.GetVariable("clause") & " " & cf & Flv.GetVariable("filter") & ")"
                End If
            End If

        End If
        'MsgBox(CyByx)

        Flv.SetVariable("sqlcmd", UCase(CyByx))

    End Sub
    Private Sub SqlQueryBuilder_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        'Me.AxShockwaveFlash1.Visible = False
        'Me.Close()


    End Sub

    Private Sub AxShockwaveFlash1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles AxShockwaveFlash1.PreviewKeyDown
        If e.KeyCode = Keys.Up Then
            MsgBox("up")

            If (Me.TableCombo.Items.Count - 1) <= (Me.TableCombo.SelectedIndex + 1) Then
                Me.TableCombo.SelectedIndex = (TableCombo.SelectedIndex + 1)


            End If
        ElseIf e.KeyCode = Keys.Down Then
            If (Me.TableCombo.SelectedIndex - 1) >= 0 Then
                Me.TableCombo.SelectedIndex = Me.TableCombo.SelectedIndex - 1

            End If
       
        End If
        If e.KeyCode = Keys.Enter Then
            'MsgBox("en")
            Inputs()

        End If
    End Sub

    Private Sub AxShockwaveFlash1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Validated
        'e.Empty()


    End Sub

    Private Sub SqlQueryBuilder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AukF.XPAuk(Me)

    End Sub

    Private Sub TableCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TableCombo.SelectedIndexChanged

    End Sub

    Private Sub TableCombo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableCombo.SelectionChangeCommitted
        Flv.SetVariable("column", Me.TableCombo.Text)

    End Sub

    Private Sub NextTableNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextTableNameToolStripMenuItem.Click
        If (Me.TableCombo.Items.Count - 1) <= (Me.TableCombo.SelectedIndex + 1) Then
            Me.TableCombo.SelectedIndex = (TableCombo.SelectedIndex + 1)


        End If
    End Sub

    Private Sub PreviousTableNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousTableNameToolStripMenuItem.Click
        If (Me.TableCombo.SelectedIndex - 1) >= 0 Then
            Me.TableCombo.SelectedIndex = Me.TableCombo.SelectedIndex - 1

        End If
    End Sub

    Private Sub InsertCommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertCommandToolStripMenuItem.Click
        Inputs()
        Flv.SetVariable("sqlcmd", CyByx & "  )")
        CyByx = Flv.GetVariable("sqlcmd")
        If Trim(CText.Text) = "" Then
            CText.Text = CyByx
        Else
            CText.Text = CText.Text & " " & Flv.GetVariable("clause") & " " & CyByx
        End If

        xFrm.Show()

        xFrm.Enabled = True
        Me.Hide()
    End Sub

    Private Sub AddNewThisColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewThisColumnToolStripMenuItem.Click
        Inputs()

    End Sub
End Class