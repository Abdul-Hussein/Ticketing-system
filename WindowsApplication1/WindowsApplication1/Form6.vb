Imports System.Data.SqlClient
Imports System.IO
Public Class Form6


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        newitem1 = 0

        newitem2 = 0

        rowcnt = 0

        rowcnt1 = 0

        rowcnt2 = 0

        Call createConnection()


        DateTimePicker1.Value = nowdate()

        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"



        Dim dtRS1 As DataTable = getDataTable("Select * from itsmain order by mn")

        For Each row As DataRow In dtRS1.Rows

            ComboBox1.Items.Add(row("mn"))

        Next


        'Dim dtRS2 As DataTable = getDataTable("Select * from itssub order by sb")

        'For Each row As DataRow In dtRS2.Rows

        '    ComboBox2.Items.Add(row("sb"))

        'Next

        TextBox2.Text = "-"

        TextBox8.Text = "-"

        con.Close()
    End Sub

    Public Function nowdate() As DateTime
        nowdate = DateValue(VerifyFldNew(" select getdate() ", "", "", True)) & " " & TimeValue(VerifyFldNew(" select getdate()", "", "", True))


    End Function

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Form4.Show()

        newitem1 = 1
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Form5.Show()

        newitem2 = 1
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If ComboBox1.Text = String.Empty Then

            MessageBox.Show("Select Main Issue", "Attention Please")

            ComboBox1.Select()

            Exit Sub
        End If

        If TextBox2.Text = "-" Then

            MessageBox.Show("Enter File Name", "Attention Please")

            Exit Sub
        End If



        Dim extension As String = Path.GetExtension(TextBox2.Text)

        If extension <> ".mp4" And extension <> ".pdf" And extension <> ".jpg" And extension <> ".png" And extension <> ".bmp" Then

            MessageBox.Show("Invalid Extension", "Attention Please")

            Exit Sub

        End If


        Dim myfilelocation As String = TextBox2.Text


        Dim filename As String = System.IO.Path.GetFileName(myfilelocation)

        Dim j, k As Integer
        Dim fn As String

        k = DataGridView1.RowCount

        fn = filename

        For j = 0 To k - 1


            If DataGridView1.Item(2, j).Value = fn Then

                MessageBox.Show("Same Filename Exist")

                Exit Sub
            End If

        Next



        If Button5.Enabled = False Then

            rowcnt = Val(rowcnt) + 1

        End If


        Call createConnection()

        If Button5.Enabled = True Then

            Dim str1 As String

            str1 = Val(VerifyFldNew("Select max(ordrno) from itsdocumentdetails where sno=" & TextBox10.Text & "", "", "", True))

            rowcnt = Val(str1) + 1

        End If



        With DataGridView1


            DataGridView1.Rows.Add()


            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = ComboBox1.Text

            If ComboBox2.Text <> String.Empty Then

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = ComboBox2.Text

            Else

                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = "-"


            End If
            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("fname").Value = filename
            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("fileloc").Value = TextBox2.Text
            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("ordrno").Value = rowcnt
            DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("idfname").Value = "-"


            DataGridView1.ClearSelection()



        End With

        ComboBox1.Enabled = False

        ComboBox2.Enabled = False

        con.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If DataGridView1.SelectedCells.Count > 0 Then


            Dim k, row As Integer

            k = DataGridView1.RowCount


            row = DataGridView1.SelectedCells.Item(0).RowIndex




            If DataGridView1.RowCount > 0 Then



                DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))

                DataGridView1.ClearSelection()


                rowcnt = Val(rowcnt) - 1




            End If



        End If


        If DataGridView1.RowCount = 0 Then


            ComboBox1.Enabled = True

            ComboBox2.Enabled = True



        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Delete Then


            If DataGridView1.SelectedCells.Count > 0 Then


                Dim k, row As Integer

                k = DataGridView1.RowCount


                row = DataGridView1.SelectedCells.Item(0).RowIndex




                If DataGridView1.RowCount > 0 Then



                    DataGridView1.Rows.Remove(DataGridView1.Rows(DataGridView1.SelectedCells.Item(0).RowIndex))

                    DataGridView1.ClearSelection()


                    rowcnt = Val(rowcnt) - 1




                End If



            End If


            If DataGridView1.RowCount = 0 Then


                ComboBox1.Enabled = True

                ComboBox2.Enabled = True



            End If


        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then

            e.Handled = True


            If ComboBox1.Text = String.Empty Then

                MessageBox.Show("Select Main Issue", "Attention Please")

                ComboBox1.Select()

                Exit Sub
            End If

            If TextBox2.Text = "-" Then

                MessageBox.Show("Enter File Name", "Attention Please")

                Exit Sub
            End If


            Dim myfilelocation As String = TextBox2.Text


            Dim filename As String = System.IO.Path.GetFileName(myfilelocation)

            Dim j, k As Integer
            Dim fn As String

            k = DataGridView1.RowCount

            fn = filename

            For j = 0 To k - 1


                If DataGridView1.Item(2, j).Value = fn Then

                    MessageBox.Show("Same Filename Exist")

                    Exit Sub
                End If

            Next



            If Button5.Enabled = False Then

                rowcnt = Val(rowcnt) + 1

            End If


            Call createConnection()

            If Button5.Enabled = True Then

                Dim str1 As String

                str1 = Val(VerifyFldNew("Select max(ordrno) from itsdocumentdetails where sno=" & TextBox10.Text & "", "", "", True))

                rowcnt = Val(str1) + 1

            End If



            With DataGridView1


                DataGridView1.Rows.Add()


                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("mn").Value = ComboBox1.Text

                If ComboBox2.Text <> String.Empty Then

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = ComboBox2.Text

                Else

                    DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("sb").Value = "-"


                End If
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("fname").Value = filename
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("fileloc").Value = TextBox2.Text
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("ordrno").Value = rowcnt
                DataGridView1.Rows(DataGridView1.RowCount - 1).Cells("idfname").Value = "-"


                DataGridView1.ClearSelection()



            End With

            ComboBox1.Enabled = False

            ComboBox2.Enabled = False

            con.Close()



        Else

            e.Handled = False

        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



        Call createConnection()



        If DataGridView1.Rows.Count < 1 Then

            MessageBox.Show("Fill The Solution Details", "Attention Please")

            Exit Sub

        End If



        If ComboBox2.Text = String.Empty Then

            Dim sb2 As String

            sb2 = "-"

            Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where mn='" & ComboBox1.Text & "' and sb='" & sb2 & "' ")

            If dtRS.Rows.Count = 1 Then

                MessageBox.Show("Same Main Issue Already Exist. ", "Attention Please")

                Exit Sub

            End If

        End If


        If ComboBox2.Text <> String.Empty Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn='" & ComboBox1.Text & "' and sb='" & ComboBox2.Text & "' ")

            If dtRS1.Rows.Count = 1 Then

                MessageBox.Show("Same Main/Sub Issue Already Exist. ", "Attention Please")

                Exit Sub

            End If

        End If




        If TextBox8.Text = String.Empty Then

            MessageBox.Show("Enter Remarks", "Attention Please")

            TextBox8.Select()

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

            Dim str1, str2, str5 As String

            Dim k3, j3 As Integer

            str1 = Val(VerifyFldNew("Select max(sno) from itssolutiondetails", "", "", True))

            TextBox10.Text = str1

            TextBox10.Text = Val(TextBox10.Text) + 1

            str5 = TextBox10.Text



            If DataGridView1.RowCount > 0 Then


                Dim j, k As Integer

                k = DataGridView1.RowCount

                For j = 0 To k - 1


                    DataGridView1.Item(5, j).Value = str5 + "-" + DataGridView1.Item(2, j).Value


                Next

                Dim sno, mn, sb, fname, fileloc, ordrno, idfname As String

                sno = TextBox10.Text

                mn = ComboBox1.Text


                If ComboBox2.Text <> String.Empty Then

                    sb = ComboBox2.Text

                Else

                    sb = "-"

                End If


                k3 = DataGridView1.RowCount

                For j3 = 0 To k3 - 1

                    fname = DataGridView1.Item(2, j3).Value

                    fileloc = DataGridView1.Item(3, j3).Value

                    ordrno = DataGridView1.Item(4, j3).Value

                    idfname = DataGridView1.Item(5, j3).Value




                    Dim cmd As New SqlCommand("Insert Into itsdocumentdetails(sno,mn,sb,Filen,fname,fileloc,ordrno,idfname) Values (@sno,@mn,@sb,@ImageData,@fname,@fileloc,@ordrno,@idfname)", con)



                    Dim param As New SqlParameter("@ImageData", SqlDbType.VarBinary)

                    Dim ImageData As Byte() = IO.File.ReadAllBytes(fileloc)

                    param.Value = ImageData

                    cmd.Parameters.Add(param)

                    cmd.Parameters.AddWithValue("@sno", sno)
                    cmd.Parameters.AddWithValue("@mn", mn)
                    cmd.Parameters.AddWithValue("@sb", sb)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@fileloc", fileloc)
                    cmd.Parameters.AddWithValue("@ordrno", ordrno)
                    cmd.Parameters.AddWithValue("@idfname", idfname)

                    cmd.ExecuteNonQuery()



                Next

            End If

            If addtest = 0 Then

            Else

                MessageBox.Show("There is a problem in network!", "Attention Please")

                Exit Sub

            End If



            Dim sb1 As String

            sb1 = "-"

            Dim command As SqlCommand = con.CreateCommand()

            Dim transaction As SqlTransaction


            transaction = con.BeginTransaction()

            command.Connection = con

            command.Transaction = transaction


            Try

                If ComboBox2.Text <> String.Empty Then

                    str2 = "INSERT INTO itssolutiondetails([sno],[dt],[dtonly],[mn],[sb],[rmrks],[uname]) VALUES(" & TextBox10.Text.Trim & ",'" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & ComboBox1.Text.Trim & "','" & ComboBox2.Text.Trim & "','" & TextBox8.Text.Trim & "','" & uname & "')"

                Else

                    str2 = "INSERT INTO itssolutiondetails([sno],[dt],[dtonly],[mn],[sb],[rmrks],[uname]) VALUES(" & TextBox10.Text.Trim & ",'" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & ComboBox1.Text.Trim & "','" & sb1 & "','" & TextBox8.Text.Trim & "','" & uname & "')"

                End If


                command.CommandText = str2

                command.ExecuteNonQuery()


                transaction.Commit()


                MessageBox.Show("Details saved!", "Attention Please")


                Call clear()



            Catch ex As Exception

                Try

                    transaction.Rollback()

                    MsgBox(Err.Description)

                    Exit Sub

                Catch ex2 As Exception

                    MsgBox("Check The Network. Data Not Saved")

                    Exit Sub

                End Try



            End Try





        End If


        con.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clear()
    End Sub
    Public Sub clear()

        rowcnt = 0

        rowcnt1 = 0

        rowcnt2 = 0

        Call createConnection()

        DateTimePicker1.Value = nowdate()

        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"


        ComboBox1.Items.Clear()
        Dim dtRS1 As DataTable = getDataTable("Select * from itsmain order by mn")

        For Each row As DataRow In dtRS1.Rows

            ComboBox1.Items.Add(row("mn"))

        Next


        ComboBox2.Items.Clear()
        'Dim dtRS2 As DataTable = getDataTable("Select * from itssub order by sb")

        'For Each row As DataRow In dtRS2.Rows

        '    ComboBox2.Items.Add(row("sb"))

        'Next

        TextBox2.Text = "-"

        TextBox8.Text = "-"

        TextBox10.Text = ""

        ComboBox1.Enabled = True

        ComboBox2.Enabled = True

        DataGridView1.Rows.Clear()

        Button3.Enabled = True

        Button5.Enabled = False

        Button1.Enabled = False

        con.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()

        Form7.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If ttle <> "MANAGER" And ttle <> "ADMIN" Then

        '    MessageBox.Show("Access Denied ", "Attention Please")


        '    Exit Sub

        'End If

        Call createConnection()

        Dim ms As String
        Dim dg As Integer
        Dim tl As String
        Dim ss As Integer
        ms = "Want To Cancel This Record?"
        dg = vbYesNo + vbQuestion
        tl = "Confirm Cancellation"

        ss = MsgBox(ms, dg, tl)


        If ss = vbYes Then

            Dim str1, str2 As String

            Dim command As SqlCommand = con.CreateCommand()

            Dim transaction As SqlTransaction


            transaction = con.BeginTransaction()

            command.Connection = con

            command.Transaction = transaction


            Try


                str1 = "DELETE from itssolutiondetails where sno=" & TextBox10.Text & ""

                command.CommandText = str1

                command.ExecuteNonQuery()


                str2 = "DELETE from itsdocumentdetails where sno=" & TextBox10.Text & ""

                command.CommandText = str2

                command.ExecuteNonQuery()





                transaction.Commit()


                MessageBox.Show("Cancelled", "Attention Please")


                Call clear()


            Catch ex As Exception

                Try

                    transaction.Rollback()

                    MsgBox(Err.Description)

                    Exit Sub

                Catch ex2 As Exception

                    MsgBox("Check The Network. Data Not Saved")

                    Exit Sub

                End Try


            End Try


        End If



        con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If ttle <> "MANAGER" And ttle <> "ADMIN" Then

            MessageBox.Show("Access Denied ", "Attention Please")


            Exit Sub

        End If


        If ComboBox1.Text = String.Empty Then

            MessageBox.Show("Select Main Issue", "Attention Please")

            ComboBox1.Select()

            Exit Sub
        End If


        If ComboBox2.Text = String.Empty Then

            Dim sb2 As String

            sb2 = "-"

            Dim dtRS As DataTable = getDataTable("Select * from itssolutiondetails where mn='" & ComboBox1.Text & "' and sb='" & sb2 & "' and sno<>" & TextBox10.Text & " ")

            If dtRS.Rows.Count = 1 Then

                MessageBox.Show("Same Main Issue Already Exist. ", "Attention Please")

                Exit Sub

            End If

        End If


        If ComboBox2.Text <> String.Empty Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn='" & ComboBox1.Text & "' and sb='" & ComboBox2.Text & "'and sno<>" & TextBox10.Text & " ")

            If dtRS1.Rows.Count = 1 Then

                MessageBox.Show("Same Main/Sub Issue Already Exist. ", "Attention Please")

                Exit Sub

            End If

        End If




        If TextBox8.Text = String.Empty Then

            MessageBox.Show("Enter Remarks", "Attention Please")

            TextBox8.Select()

            Exit Sub
        End If


        Call createConnection()




        Dim ms As String
        Dim dg As Integer
        Dim tl As String
        Dim ss As Integer
        ms = "Want To Modify This Record?"
        dg = vbYesNo + vbQuestion
        tl = "Confirm Updation"

        ss = MsgBox(ms, dg, tl)


        If ss = vbYes Then


            Dim str1 As String

            Dim k3, j3 As Integer


            If DataGridView1.RowCount > 0 Then



                Dim j, k As Integer

                k = DataGridView1.RowCount

                For j = 0 To k - 1


                    DataGridView1.Item(5, j).Value = TextBox10.Text + "-" + DataGridView1.Item(2, j).Value


                Next


                Dim sno, mn, sb, fname, fileloc, ordrno, idfname As String

                sno = TextBox10.Text

                mn = ComboBox1.Text


                If ComboBox2.Text <> String.Empty Then

                    sb = ComboBox2.Text

                Else

                    sb = "-"

                End If


                k3 = DataGridView1.RowCount

                For j3 = 0 To k3 - 1


                    fname = DataGridView1.Item(2, j3).Value

                    fileloc = DataGridView1.Item(3, j3).Value

                    ordrno = DataGridView1.Item(4, j3).Value

                    idfname = DataGridView1.Item(5, j3).Value


                    Dim cmd As New SqlCommand("Insert Into itsdocumentdetails(sno,mn,sb,Filen,fname,fileloc,ordrno,idfname) Values (@sno,@mn,@sb,@ImageData,@fname,@fileloc,@ordrno,@idfname)", con)

                    Dim param As New SqlParameter("@ImageData", SqlDbType.VarBinary)

                    Dim ImageData As Byte() = IO.File.ReadAllBytes(fileloc)

                    param.Value = ImageData

                    cmd.Parameters.Add(param)

                    cmd.Parameters.AddWithValue("@sno", sno)
                    cmd.Parameters.AddWithValue("@mn", mn)
                    cmd.Parameters.AddWithValue("@sb", sb)
                    cmd.Parameters.AddWithValue("@fname", fname)
                    cmd.Parameters.AddWithValue("@fileloc", fileloc)
                    cmd.Parameters.AddWithValue("@ordrno", ordrno)
                    cmd.Parameters.AddWithValue("@idfname", idfname)

                    cmd.ExecuteNonQuery()



                Next


                If addtest = 0 Then

                Else

                    MessageBox.Show("There is a problem in network!", "Attention Please")

                    Exit Sub

                End If

            End If


            Dim command As SqlCommand = con.CreateCommand()

            Dim transaction As SqlTransaction


            Dim sb1 = "-"

            transaction = con.BeginTransaction()

            command.Connection = con

            command.Transaction = transaction


            Try



                If ComboBox2.Text <> String.Empty Then

                    str1 = "UPDATE itssolutiondetails SET mn='" + ComboBox1.Text.Trim + "',sb='" + ComboBox2.Text.Trim + "',rmrks='" + TextBox8.Text.Trim + "' where sno=" & TextBox10.Text & ""


                Else

                    str1 = "UPDATE itssolutiondetails SET mn='" + ComboBox1.Text.Trim + "',sb='" + sb1 + "',rmrks='" + TextBox8.Text.Trim + "' where sno=" & TextBox10.Text & ""

                End If

                command.CommandText = str1

                command.ExecuteNonQuery()




                transaction.Commit()


                MessageBox.Show("Details Modified!", "Attention Please")


                Call clear()



            Catch ex As Exception

                Try

                    transaction.Rollback()

                    MsgBox(Err.Description)

                    Exit Sub

                Catch ex2 As Exception

                    MsgBox("Check The Network. Data Not Saved")

                    Exit Sub

                End Try



            End Try





        End If

        con.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Items.Clear()
        Call createConnection()

        Dim dtRS2 As DataTable = getDataTable("Select sb from itssub where mn='" & ComboBox1.Text & "' order by sno")

        For Each row As DataRow In dtRS2.Rows

            ComboBox2.Items.Add(row("sb"))

        Next

        con.Close()

    End Sub
End Class