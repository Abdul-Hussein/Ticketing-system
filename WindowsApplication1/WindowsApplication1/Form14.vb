Public Class Form14

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call createConnection()

        DateTimePicker1.Value = nowdate()

        DateTimePicker2.Value = nowdate()


        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"


        DateTimePicker2.Format = DateTimePickerFormat.Custom

        DateTimePicker2.CustomFormat = "dd-MMM-yyyy"


        DataGridView1.Rows.Clear()

        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 14


        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 4



        DataGridView1.Rows(0).Cells(0).Value = "S.No"

        DataGridView1.Rows(0).Cells(0).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        DataGridView1.Rows(0).Cells(1).Value = "Date"

        DataGridView1.Columns(1).Width = 200

        DataGridView1.Rows(0).Cells(1).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        DataGridView1.Rows(0).Cells(2).Value = "Main Issue"

        DataGridView1.Columns(2).Width = 200

        DataGridView1.Rows(0).Cells(2).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        DataGridView1.Rows(0).Cells(3).Value = "Sub Issue"

        DataGridView1.Columns(3).Width = 200

        DataGridView1.Rows(0).Cells(3).Style.Font = New Font("ariel", 8, FontStyle.Bold)







        'Dim sno, i As Integer

        'sno = 1

        'i = 1


        'Dim dtRS2 As DataTable = getDataTable("Select * from itopenlog order by mn,sb")


        'For Each row As DataRow In dtRS2.Rows


        '    With DataGridView1


        '        DataGridView1.Rows.Add()

        '        DataGridView1.Rows(i).Cells(0).Value = sno

        '        DataGridView1.Rows(i).Cells(1).Value = row("dtonly")

        '        DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

        '        DataGridView1.Rows(i).Cells(2).Value = row("mn")

        '        DataGridView1.Rows(i).Cells(3).Value = row("sb")


        '        sno = Val(sno) + 1

        '        i = i + 1


        '    End With

        'Next



        con.Close()

    End Sub
    Public Function nowdate() As DateTime
        nowdate = DateValue(VerifyFldNew(" select getdate() ", "", "", True)) & " " & TimeValue(VerifyFldNew(" select getdate()", "", "", True))


    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()

        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 14


        DataGridView1.RowCount = 2

        DataGridView1.ColumnCount = 4



        DataGridView1.Rows(0).Cells(0).Value = "S.No"

        DataGridView1.Rows(0).Cells(0).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        DataGridView1.Rows(0).Cells(1).Value = "Date"

        DataGridView1.Columns(1).Width = 200

        DataGridView1.Rows(0).Cells(1).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        DataGridView1.Rows(0).Cells(2).Value = "Main Issue"

        DataGridView1.Columns(2).Width = 200

        DataGridView1.Rows(0).Cells(2).Style.Font = New Font("ariel", 8, FontStyle.Bold)


        DataGridView1.Rows(0).Cells(3).Value = "Sub Issue"

        DataGridView1.Columns(3).Width = 200

        DataGridView1.Rows(0).Cells(3).Style.Font = New Font("ariel", 8, FontStyle.Bold)





        Call createConnection()

        Dim sno, i As Integer

        sno = 1

        i = 1


        'Dim dtRS2 As DataTable = getDataTable("Select * from itopenlog where dtonly>='" & DateValue(DateTimePicker1.Value.Date) & " ' and dtonly <='" & DateValue(DateTimePicker2.Value.Date) & "' order by mn,sb")


        Dim dtRS2 As DataTable = getDataTable("Select * from itopenlog where dt>='" & DateValue(DateTimePicker1.Value.Date) & " 00:00am' and dt <='" & DateValue(DateTimePicker2.Value.Date) & " 11:59:59pm' order by dt")

        For Each row As DataRow In dtRS2.Rows


            With DataGridView1


                DataGridView1.Rows.Add()

                DataGridView1.Rows(i).Cells(0).Value = sno

                'DataGridView1.Rows(i).Cells(1).Value = row("dtonly")

                'DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"

                DataGridView1.Rows(i).Cells(1).Value = row("dt")


                DataGridView1.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy hh:mm:ss tt"

                DataGridView1.Rows(i).Cells(2).Value = row("mn")

                DataGridView1.Rows(i).Cells(3).Value = row("sb")


                sno = Val(sno) + 1

                i = i + 1


            End With

        Next



        con.Close()
    End Sub
End Class