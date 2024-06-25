Public Class Form7

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now

        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"


        DateTimePicker2.Value = Date.Now

        DateTimePicker2.Format = DateTimePickerFormat.Custom

        DateTimePicker2.CustomFormat = "dd-MMM-yyyy"



        Call createConnection()


        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails order by sno desc")

        For Each row As DataRow In dtRS1.Rows

            ComboBox1.Items.Add(row("sno"))

        Next


        DataGridView1.Rows.Clear()


        Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails order by sno desc")

        For Each row As DataRow In dtRS.Rows


            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("dtonly").Value = row("dtonly")
                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("rmrks").Value = row("rmrks")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")



            End With

        Next


        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = ""

        Call createConnection()

        DataGridView1.Rows.Clear()


        Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where dtonly >='" & DateTimePicker1.Value.Date & "'and dtonly <='" & DateTimePicker2.Value.Date & "' order by sno desc")

        For Each row As DataRow In dtRS.Rows


            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("dtonly").Value = row("dtonly")
                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("rmrks").Value = row("rmrks")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")
            End With

        Next

        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call createConnection()

        DataGridView1.Rows.Clear()


        Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where sno=" & ComboBox1.Text & " ")

        For Each row As DataRow In dtRS.Rows


            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("dtonly").Value = row("dtonly")
                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("rmrks").Value = row("rmrks")
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")



            End With

        Next




        con.Close()
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        Call createConnection()

        If ComboBox1.Text = "" Then



            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails order by sno desc")

            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("dtonly").Value = row("dtonly")
                    DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("rmrks").Value = row("rmrks")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")


                End With

            Next


            ComboBox1.Items.Clear()


            Dim dtRS1 As DataTable = getDataTable("Select sno from itssolutiondetails order by sno desc")

            For Each row As DataRow In dtRS1.Rows

                ComboBox1.Items.Add(row("sno"))

            Next




        Else


            DataGridView1.Rows.Clear()

            Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where sno=" & ComboBox1.Text & "")


            For Each row As DataRow In dtRS.Rows


                With DataGridView1

                    DataGridView1.Rows.Add()

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sno").Value = row("sno")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("dtonly").Value = row("dtonly")
                    DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = row("mn")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = row("sb")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("rmrks").Value = row("rmrks")
                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("uname").Value = row("uname")



                End With

            Next


        End If



        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call Form6.clear()

        Dim rc As VariantType

        rc = DataGridView1.CurrentCell.ColumnIndex

        If rc = 0 Then

            Call createConnection()

            Dim i = DataGridView1.CurrentRow.Index
            Form6.TextBox10.Text = DataGridView1.Item(0, i).Value
            Form6.DateTimePicker1.Value = DataGridView1.Item(1, i).Value
            Form6.ComboBox1.Text = DataGridView1.Item(2, i).Value
            Form6.ComboBox2.Text = DataGridView1.Item(3, i).Value
            Form6.TextBox8.Text = DataGridView1.Item(4, i).Value


            Form6.Button3.Enabled = False
            Form6.Button5.Enabled = True
            Form6.Button1.Enabled = True



            Form6.Show()

            Form6.WindowState = FormWindowState.Maximized

            Me.Close()


            con.Close()


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class