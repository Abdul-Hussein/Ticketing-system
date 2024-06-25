Public Class Form5

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

        If newitem2 = 1 Then

            Form6.ComboBox2.Items.Clear()

            Call createConnection()

            Dim dtRS5 As DataTable = getDataTable("Select sb from itssub where mn='" & Form6.ComboBox1.Text & "' order by sno")

            'Dim dtRS5 As DataTable = getDataTable("Select * from itssub order by sb")

            For Each row As DataRow In dtRS5.Rows

                Form6.ComboBox2.Items.Add(row("sb"))

            Next

            con.Close()

            Form6.Show()

        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call createConnection()

        DataGridView1.Rows.Clear()

        Dim dtRS As DataTable = getDataTable("Select * from itssub order by mn,sno")

        For Each row As DataRow In dtRS.Rows


            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")



            End With

        Next


        Dim dtRS1 As DataTable = getDataTable("Select * from itsmain order by mn")

        For Each row As DataRow In dtRS1.Rows

            ComboBox1.Items.Add(row("mn"))

        Next

        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If ttle <> "ADMIN" And ttle <> "MANAGER" Then

        '    MessageBox.Show("Access Denied ", "Attention Please")


        '    Exit Sub

        'End If


        If ComboBox1.Text = String.Empty Then

            MessageBox.Show("Select Main Issue", "Attention Please")

            ComboBox1.Select()

            Exit Sub
        End If


        If TextBox4.Text = String.Empty Then

            MessageBox.Show("Enter Sub Issue", "Attention Please")

            TextBox4.Select()

            Exit Sub
        End If


        Call createConnection()



        Dim dtRS3 As DataTable = getDataTable("Select * from itssub where mn='" & ComboBox1.Text & "' ")

        If dtRS3.Rows.Count >= 10 Then

            MessageBox.Show("Maximum 10 Allowed", "Attention Please")

            Exit Sub


        End If



        Dim str1 As String

        str1 = VerifyFldNew("Select sb from itssub where mn='" & ComboBox1.Text & "' and sb='" & TextBox4.Text & "'", "", "", True)


        If str1 = TextBox4.Text Then

            MessageBox.Show("Same Sub Issue Already Exist Against This Main. ", "Attention Please")

            Exit Sub

        End If




        If TextBox1.Text = String.Empty Then

            MessageBox.Show("Enter Sub Issue No", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        If IsNumeric(TextBox1.Text) = False Then

            MessageBox.Show("Sub Issue No Should Be Numeric", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        If Val(TextBox1.Text) <= 0 Then

            MessageBox.Show("Sub Issue No Invalid", "Attention Please")

            TextBox1.Select()

            Exit Sub
        End If


        Dim str3 As String

        str3 = VerifyFldNew("Select sno from itssub where mn='" & ComboBox1.Text & "' and sno=" & TextBox1.Text & "", "", "", True)


        If str3 = TextBox1.Text Then

            MessageBox.Show("Same Sub Issue No Already Exist For This Main. ", "Attention Please")

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


            str4 = "INSERT INTO itssub([mn],[sb],[sno]) VALUES('" & ComboBox1.Text.Trim & "','" & TextBox4.Text.Trim & "'," & TextBox1.Text.Trim & " )"

            Call executeQuery(str4)



            If addtest = 0 Then

                MessageBox.Show("Details saved!", "Attention Please")
            Else

                MessageBox.Show("There is a problem in network!", "Attention Please")

                Exit Sub

            End If


            TextBox4.Clear()

            TextBox1.Clear()

            ComboBox1.Items.Clear()

            Dim dtRS1 As DataTable = getDataTable("Select * from itsmain order by mn")

            For Each row As DataRow In dtRS1.Rows

                ComboBox1.Items.Add(row("mn"))

            Next

            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itssub order by mn,sno")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")




                End With

            Next



        End If

        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i = DataGridView1.CurrentRow.Index

        ComboBox1.Text = DataGridView1.Item(0, i).Value
        TextBox4.Text = DataGridView1.Item(1, i).Value
        TextBox1.Text = DataGridView1.Item(2, i).Value


        Button5.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn='" & ComboBox1.Text & "' and sb='" & TextBox4.Text & "' ")

            If dtRS1.Rows.Count > 0 Then

                MessageBox.Show("Can't Delete. Used In Solution Details", "Attention Please")

                Exit Sub

            End If

            Dim str4 As String


            str4 = "DELETE from itssub where sb='" & TextBox4.Text & "' "

            Call executeQuery(str4)

            MessageBox.Show("Cancelled", "Attention Please")

            TextBox4.Clear()

            TextBox1.Clear()

            ComboBox1.Items.Clear()

            Dim dtRS2 As DataTable = getDataTable("Select * from itsmain order by mn")

            For Each row As DataRow In dtRS2.Rows

                ComboBox1.Items.Add(row("mn"))

            Next

            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itssub order by mn,sno")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")




                End With

            Next

            con.Close()
        End If
    End Sub
End Class