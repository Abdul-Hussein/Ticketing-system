Public Class Form4

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()



        If newitem1 = 1 Then

            Form6.ComboBox1.Items.Clear()

            Form6.ComboBox2.Items.Clear()

            Call createConnection()

            Dim dtRS5 As DataTable = getDataTable("Select * from itsmain order by mn")

            For Each row As DataRow In dtRS5.Rows

                Form6.ComboBox1.Items.Add(row("mn"))

            Next

            con.Close()

            Form6.Show()

        End If

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call createConnection()

        DataGridView1.Rows.Clear()

        Dim dtRS As DataTable = getDataTable("Select * from itsmain order by mno")

        For Each row As DataRow In dtRS.Rows


            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mno").Value = row("mno")



            End With

        Next


        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If ttle <> "ADMIN" And ttle <> "MANAGER" Then

        '    MessageBox.Show("Access Denied ", "Attention Please")


        '    Exit Sub

        'End If


        If TextBox4.Text = String.Empty Then

            MessageBox.Show("Enter Main Issue", "Attention Please")

            TextBox4.Select()

            Exit Sub
        End If


        Call createConnection()


        Dim dtRS3 As DataTable = getDataTable("Select * from itsmain order by mno")


        If dtRS3.Rows.Count >= 20 Then

            MessageBox.Show("Maximum 20 Allowed", "Attention Please")

            Exit Sub


        End If




        Dim str1 As String

        str1 = VerifyFldNew("Select mn from itsmain where mn='" & TextBox4.Text & "'", "", "", True)


        If str1 = TextBox4.Text Then

            MessageBox.Show("Same Issue Already Exist. ", "Attention Please")

            Exit Sub

        End If

        Dim str2 As String



        If TextBox1.Text = String.Empty Then

            MessageBox.Show("Enter Issue No", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        If IsNumeric(TextBox1.Text) = False Then

            MessageBox.Show("Issue No Should Be Numeric", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        If Val(TextBox1.Text) <= 0 Then

            MessageBox.Show("Issue No Invalid", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        str2 = VerifyFldNew("Select mno from itsmain where mno=" & TextBox1.Text & "", "", "", True)


        If str2 = TextBox1.Text Then

            MessageBox.Show("Same Issue No Already Exist. ", "Attention Please")

            Exit Sub

        End If


        Dim ms As String
        Dim dg As Integer
        Dim tl As String
        Dim ss As Integer
        ms = "Do you want to save the detail?"
        dg = vbYesNo + vbQuestion
        tl = "Confirm Updation"

        ss = MsgBox(ms, dg, tl)



        If ss = vbYes Then


          

            Dim str4 As String


            str4 = "INSERT INTO itsmain([mn],[mno]) VALUES('" & TextBox4.Text.Trim & "'," & TextBox1.Text.Trim & " )"

            Call executeQuery(str4)



            If addtest = 0 Then

                MessageBox.Show("Details saved!", "Attention Please")
            Else

                MessageBox.Show("There is a problem in network!", "Attention Please")

                Exit Sub

            End If


            TextBox4.Clear()

            TextBox1.Clear()

            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itsmain order by mno")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mno").Value = row("mno")




                End With

            Next



        End If

        con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'If ttle <> "ADMIN" Then

        '    MessageBox.Show("Access Denied ", "Attention Please")


        '    Exit Sub

        'End If


        Dim ms As String
        Dim dg As Integer
        Dim tl As String
        Dim ss As Integer
        ms = "Want To Cancel This Record?"
        dg = vbYesNo + vbQuestion
        tl = "Confirm Cancellation"

        ss = MsgBox(ms, dg, tl)



        If ss = vbYes Then

            Call createConnection()

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn='" & TextBox4.Text & "' ")

            If dtRS1.Rows.Count > 0 Then

                MessageBox.Show("Can't Delete. Used In Solution Details", "Attention Please")

                Exit Sub

            End If


            Dim dtRS2 As DataTable = getDataTable("Select * from itssub where mn='" & TextBox4.Text & "' ")

            If dtRS2.Rows.Count > 0 Then

                MessageBox.Show("Can't Delete. Used In Sub Issue", "Attention Please")

                Exit Sub

            End If

            Dim str4 As String


            str4 = "DELETE from itsmain where mn='" & TextBox4.Text & "' "

            Call executeQuery(str4)

            MessageBox.Show("Cancelled", "Attention Please")

            TextBox4.Clear()

            TextBox1.Clear()

            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itsmain order by mno")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mno").Value = row("mno")




                End With

            Next

            con.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i = DataGridView1.CurrentRow.Index
        TextBox4.Text = DataGridView1.Item(0, i).Value
        TextBox1.Text = DataGridView1.Item(1, i).Value


        Button5.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class