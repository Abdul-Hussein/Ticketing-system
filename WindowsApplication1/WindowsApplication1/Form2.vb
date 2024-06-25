Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("MANAGER")
        ComboBox1.Items.Add("SUPERVISOR")

        Call createConnection()

        DataGridView1.Rows.Clear()

        Dim dtRS As DataTable = getDataTable("Select * from itsuserdetails order by uname")

        For Each row As DataRow In dtRS.Rows


            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("ttl").Value = row("ttl")




            End With

        Next


        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ttle <> "ADMIN" Then

            MessageBox.Show("Access Denied ", "Attention Please")


            Exit Sub

        End If



        If TextBox1.Text = String.Empty Then

            MessageBox.Show("Enter Name ", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        If TextBox2.Text = String.Empty Then

            MessageBox.Show("Enter Password ", "Attention Please")

            TextBox2.Select()

            Exit Sub
        End If


        If ComboBox1.Text = String.Empty Then

            MessageBox.Show("Select Title ", "Attention Please")

            ComboBox1.Select()

            Exit Sub
        End If



        Dim ms As String
        Dim dg As Integer
        Dim tl As String
        Dim ss As Integer
        ms = "Want To Save The Record?"
        dg = vbYesNo + vbQuestion
        tl = "Confirm Updation"

        ss = MsgBox(ms, dg, tl)



        If ss = vbYes Then


            Call createConnection()


            Dim str1 As String

            str1 = VerifyFldNew("Select uname from itsuserdetails where uname='" & TextBox1.Text & "'", "", "", True)

            If str1 = TextBox1.Text Then

                MessageBox.Show("Name Already Exist. ", "Attention Please")

                Exit Sub

            End If

            Dim str2 As String

            str2 = VerifyFldNew("Select ttl from itsuserdetails where ttl='" & ComboBox1.Text & "'", "", "", True)

            If str2 = "ADMIN" Then

                MessageBox.Show("ADMIN Already Exist. ", "Attention Please")

                Exit Sub

            End If



            Dim str3 As String

            str3 = "INSERT INTO itsuserdetails([uname], [pwd], [ttl]) VALUES('" & TextBox1.Text.Trim & "','" & TextBox2.Text.Trim & "','" & ComboBox1.Text.Trim & "')"

            Call executeQuery(str3)

            If addtest = 0 Then

                MessageBox.Show("Details saved!", "Attention Please")
            Else

                MessageBox.Show("There is a problem in network!", "Attention Please")

                Exit Sub

            End If

            TextBox1.Clear()
            TextBox2.Clear()


            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itsuserdetails     order by uname")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("ttl").Value = row("ttl")




                End With

            Next

            con.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ttle <> "ADMIN" Then

            MessageBox.Show("Access Denied ", "Attention Please")


            Exit Sub

        End If


        If ComboBox1.Text = "ADMIN" Then

            MessageBox.Show("Can't Cancel ADMIN ", "Attention Please")


            Exit Sub
        End If



        Dim ms As String
        Dim dg As Integer
        Dim tl As String
        Dim ss As Integer
        ms = "Want To Cancel This Record?"
        dg = vbYesNo + vbQuestion
        tl = "Confirm Updation"

        ss = MsgBox(ms, dg, tl)



        If ss = vbYes Then

            Call createConnection()

            Dim str4 As String


            str4 = "DELETE from itsuserdetails where uname='" & TextBox1.Text & "'"

            Call executeQuery(str4)

            TextBox1.Clear()
            TextBox2.Clear()


            MessageBox.Show("Cancelled", "Attention Please")

            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itsuserdetails order by uname")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("ttl").Value = row("ttl")




                End With

            Next

            con.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value

        ComboBox1.Text = DataGridView1.Item(1, i).Value

        Button5.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class