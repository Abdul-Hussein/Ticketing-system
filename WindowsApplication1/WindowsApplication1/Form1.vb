Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        'If ttle <> "ADMIN" Then

        '    MessageBox.Show("Access Denied ", "Attention Please")


        '    Exit Sub

        'End If




        Form2.Show()

    End Sub

    Private Sub ModelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelToolStripMenuItem.Click
        'If ttle = "ADMIN" Or ttle = "MANAGER" Then

        '    Form4.Show()

        'Else

        '    MsgBox("Access Denied")
        'End If


        Form4.Show()
    End Sub

    Private Sub SubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubToolStripMenuItem.Click
        'If ttle = "ADMIN" Or ttle = "MANAGER" Then

        '    Form5.Show()

        'Else

        '    MsgBox("Access Denied")
        'End If

        Form5.Show()
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        Form6.MdiParent = Me

        Form6.Show()

        'Form6.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SolutionDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolutionDetailsToolStripMenuItem.Click
        Form8.MdiParent = Me

        Form8.Show()

        Form8.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VoiceRecordingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoiceRecordingToolStripMenuItem.Click
        If ttle = "ADMIN" Or ttle = "MANAGER" Then

            Form9.Show()

        Else

            MsgBox("Access Denied")
        End If
    End Sub

    Private Sub DisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem.Click
        'If ttle = "ADMIN" Or ttle = "MANAGER" Then

        '    Form10.Show()

        'Else

        '    MsgBox("Access Denied")
        'End If

        Form10.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogDetailsToolStripMenuItem.Click
        Form14.Show()
    End Sub
End Class
