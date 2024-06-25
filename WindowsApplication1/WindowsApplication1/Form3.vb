Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True



            Call ok()
        Else
            e.Handled = False
        End If
    End Sub

    Public Sub ok()
        'On Error GoTo out

        Call createConnection()

        Dim dtRS As DataTable = getDataTable("Select * from itsuserdetails where uname='" & TextBox1.Text & "'and pwd='" & TextBox2.Text & "'")



        If dtRS.Rows.Count > 0 Then

            For Each row As DataRow In dtRS.Rows
                ttle = row("ttl")
                uname = row("uname")
            Next


            Me.Visible = False

            Form1.ShowDialog()



            Me.Close()







        Else

            MessageBox.Show("Please enter the valid user name & Password!", "Your Attention Please")


        End If






        con.Close()
        Exit Sub

out:
        MsgBox(" Network Problem")




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call ok()
    End Sub
End Class