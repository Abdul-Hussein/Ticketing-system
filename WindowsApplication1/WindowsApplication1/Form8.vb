Imports System.Data.SqlClient
Imports System.IO
Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now

        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"


        DateTimePicker2.Value = Date.Now

        DateTimePicker2.Format = DateTimePickerFormat.Custom

        DateTimePicker2.CustomFormat = "dd-MMM-yyyy"


        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 6


        DataGridView1.Rows(0).Cells(0).Value = "Solution No"

        DataGridView1.Rows(0).Cells(0).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(0).Width = 80

        DataGridView1.Rows(0).Cells(1).Value = "Date"

        DataGridView1.Rows(0).Cells(1).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(1).Width = 100

        DataGridView1.Rows(0).Cells(2).Value = "Main Issue"

        DataGridView1.Rows(0).Cells(2).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(2).Width = 150

        DataGridView1.Rows(0).Cells(3).Value = "Sub Issue"

        DataGridView1.Rows(0).Cells(3).Style.Font = New Font("ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 150

        DataGridView1.Rows(0).Cells(4).Value = "Remarks"
        DataGridView1.Rows(0).Cells(4).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(4).Width = 300


        DataGridView1.Rows(0).Cells(5).Value = "User"
        DataGridView1.Rows(0).Cells(5).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        Call createConnection()




        Dim dtRS1 As DataTable = getDataTable("Select * from itsmain order by mn")

        For Each row As DataRow In dtRS1.Rows

            ComboBox1.Items.Add(row("mn"))

        Next


        con.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()

        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 6


        DataGridView1.Rows(0).Cells(0).Value = "Solution No"

        DataGridView1.Rows(0).Cells(0).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(0).Width = 80

        DataGridView1.Rows(0).Cells(1).Value = "Date"

        DataGridView1.Rows(0).Cells(1).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(1).Width = 100

        DataGridView1.Rows(0).Cells(2).Value = "Main Issue"

        DataGridView1.Rows(0).Cells(2).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(2).Width = 150

        DataGridView1.Rows(0).Cells(3).Value = "Sub Issue"

        DataGridView1.Rows(0).Cells(3).Style.Font = New Font("ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 150

        DataGridView1.Rows(0).Cells(4).Value = "Remarks"
        DataGridView1.Rows(0).Cells(4).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(4).Width = 300


        DataGridView1.Rows(0).Cells(5).Value = "User"
        DataGridView1.Rows(0).Cells(5).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        Call createConnection()

        Dim i As Integer

        Dim sno As String

        i = 1


        Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where dtonly >='" & DateTimePicker1.Value.Date & "'and dtonly <='" & DateTimePicker2.Value.Date & "' order by sno")

        For Each row As DataRow In dtRS.Rows

            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(i).Cells(0).Value = row("sno")

                sno = row("sno")


                DataGridView1.Rows(i).Cells(1).Value = row("dtonly")

                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                DataGridView1.Rows(i).Cells(2).Value = row("mn")

                DataGridView1.Rows(i).Cells(3).Value = row("sb")


                DataGridView1.Rows(i).Cells(4).Value = row("rmrks")

                DataGridView1.Rows(i).Cells(5).Value = row("uname")

                i = i + 1

            End With

        Next

        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim rc As VariantType

        rc = DataGridView1.CurrentCell.ColumnIndex

        If rc = 0 Then

            Dim i = DataGridView1.CurrentRow.Index

            TextBox4.Text = DataGridView1.Item(0, i).Value


            Button12.Enabled = True

        Else

            TextBox4.Text = ""


            Button12.Enabled = False


        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim myfolder As String = "C:\Solution\"

        Dim sh As Object = CreateObject("shell.application")
        For Each w In sh.Windows
            If w.document.folder.self.Path = myfolder Then w.Quit()
        Next


        Dim path As String = "C:\Solution\"

        If Not Directory.Exists(path) Then
            Directory.CreateDirectory(path)
        End If



        'On Error GoTo a

        Call createConnection()

        Dim slocat As String

        Dim idfname As String

        idfname = ""

        slocat = "C:\Solution\"


        My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        System.IO.Directory.CreateDirectory(slocat)

        Dim Rqry, sno As String


        sno = TextBox4.Text



        Rqry = "Select * from itsdocumentdetails where sno= " & sno


        Dim dtRS As DataTable = getDataTable(Rqry)


        Dim ordno As Integer


        ordno = 1


        For Each row As DataRow In dtRS.Rows


            Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

            idfname = row("idfname")

            cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


            cmd.Parameters.AddWithValue("@ordrno", ordno)


            IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

            ordno = Val(ordno) + 1



        Next

        con.Close()


        'Process.Start("explorer.exe", slocat)


        slocat = "C:\Solution\" + idfname

        Process.Start(slocat)

a:
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        TextBox4.Text = ""

        Button12.Enabled = False

        DataGridView1.Rows.Clear()

        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 6


        DataGridView1.Rows(0).Cells(0).Value = "Solution No"

        DataGridView1.Rows(0).Cells(0).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(0).Width = 80

        DataGridView1.Rows(0).Cells(1).Value = "Date"

        DataGridView1.Rows(0).Cells(1).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(1).Width = 100

        DataGridView1.Rows(0).Cells(2).Value = "Main Issue"

        DataGridView1.Rows(0).Cells(2).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(2).Width = 150

        DataGridView1.Rows(0).Cells(3).Value = "Sub Issue"

        DataGridView1.Rows(0).Cells(3).Style.Font = New Font("ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 150

        DataGridView1.Rows(0).Cells(4).Value = "Remarks"
        DataGridView1.Rows(0).Cells(4).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(4).Width = 300


        DataGridView1.Rows(0).Cells(5).Value = "User"
        DataGridView1.Rows(0).Cells(5).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        Call createConnection()

        Dim i As Integer

        Dim sno As String

        i = 1


        Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & ComboBox1.Text & "' order by sno")

        For Each row As DataRow In dtRS.Rows

            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(i).Cells(0).Value = row("sno")

                sno = row("sno")


                DataGridView1.Rows(i).Cells(1).Value = row("dtonly")

                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                DataGridView1.Rows(i).Cells(2).Value = row("mn")

                DataGridView1.Rows(i).Cells(3).Value = row("sb")


                DataGridView1.Rows(i).Cells(4).Value = row("rmrks")

                DataGridView1.Rows(i).Cells(5).Value = row("uname")

                i = i + 1

            End With

        Next

        ComboBox2.Items.Clear()
        Dim dtRS2 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & ComboBox1.Text & "' order by sb")

        For Each row As DataRow In dtRS2.Rows

            ComboBox2.Items.Add(row("sb"))

        Next



        con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        TextBox4.Text = ""

        Button12.Enabled = False

        DataGridView1.Rows.Clear()

        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 6


        DataGridView1.Rows(0).Cells(0).Value = "Solution No"

        DataGridView1.Rows(0).Cells(0).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(0).Width = 80

        DataGridView1.Rows(0).Cells(1).Value = "Date"

        DataGridView1.Rows(0).Cells(1).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(1).Width = 100

        DataGridView1.Rows(0).Cells(2).Value = "Main Issue"

        DataGridView1.Rows(0).Cells(2).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(2).Width = 150

        DataGridView1.Rows(0).Cells(3).Value = "Sub Issue"

        DataGridView1.Rows(0).Cells(3).Style.Font = New Font("ariel", 8, FontStyle.Bold)
        DataGridView1.Columns(3).Width = 150

        DataGridView1.Rows(0).Cells(4).Value = "Remarks"
        DataGridView1.Rows(0).Cells(4).Style.Font = New Font("ariel", 8, FontStyle.Bold)

        DataGridView1.Columns(4).Width = 300


        DataGridView1.Rows(0).Cells(5).Value = "User"
        DataGridView1.Rows(0).Cells(5).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        Call createConnection()

        Dim i As Integer

        Dim sno As String

        i = 1


        Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & ComboBox1.Text & "' and sb ='" & ComboBox2.Text & "' order by sno")

        For Each row As DataRow In dtRS.Rows

            With DataGridView1

                DataGridView1.Rows.Add()

                DataGridView1.Rows(i).Cells(0).Value = row("sno")

                sno = row("sno")


                DataGridView1.Rows(i).Cells(1).Value = row("dtonly")

                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MMM-yyyy"

                DataGridView1.Rows(i).Cells(2).Value = row("mn")

                DataGridView1.Rows(i).Cells(3).Value = row("sb")


                DataGridView1.Rows(i).Cells(4).Value = row("rmrks")

                DataGridView1.Rows(i).Cells(5).Value = row("uname")

                i = i + 1

            End With

        Next



        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class