Imports System.Data.SqlClient
Imports System.IO
Public Class Form10

    Public Function nowdate() As DateTime
        nowdate = DateValue(VerifyFldNew(" select getdate() ", "", "", True)) & " " & TimeValue(VerifyFldNew(" select getdate()", "", "", True))


    End Function

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call createConnection()



        DateTimePicker1.Value = nowdate()

        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker1.CustomFormat = "dd-MMM-yyyy"


        Dim rc, i As Integer

        Dim mn(20) As String

        Dim dtRS As DataTable = getDataTable("Select * from itsmain order by mno")

        rc = dtRS.Rows.Count

        If rc = 1 Then

            Button1.Visible = True


            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)



        End If


        If rc = 2 Then

            Button1.Visible = True

            Button2.Visible = True



            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)


        End If


        If rc = 3 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True


            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)



        End If


        If rc = 4 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True



            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)


        End If


        If rc = 5 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True



            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)


        End If


        If rc = 6 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True



            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

        End If


        If rc = 7 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True



            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

        End If


        If rc = 8 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True


            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)



        End If


        If rc = 9 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True


            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)



        End If


        If rc = 10 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True


            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)


        End If


        If rc = 11 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True




            For i = 1 To 11

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)


        End If


        If rc = 12 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True


            For i = 1 To 12

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)


        End If


        If rc = 13 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True


            For i = 1 To 13

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)


        End If


        If rc = 14 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True


            For i = 1 To 14

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)



        End If


        If rc = 15 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True

            Button15.Visible = True


            For i = 1 To 15

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)

            Button15.Text = mn(15)


        End If


        If rc = 16 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True

            Button15.Visible = True

            Button16.Visible = True


            For i = 1 To 16

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)

            Button15.Text = mn(15)

            Button16.Text = mn(16)

        End If


        If rc = 17 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True

            Button15.Visible = True

            Button16.Visible = True

            Button17.Visible = True


            For i = 1 To 17

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)

            Button15.Text = mn(15)

            Button17.Text = mn(17)


        End If


        If rc = 18 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True

            Button15.Visible = True

            Button16.Visible = True

            Button17.Visible = True

            Button18.Visible = True


            For i = 1 To 18

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)

            Button15.Text = mn(15)

            Button17.Text = mn(17)

            Button18.Text = mn(18)


        End If


        If rc = 19 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True

            Button15.Visible = True

            Button16.Visible = True

            Button17.Visible = True

            Button18.Visible = True

            Button19.Visible = True


            For i = 1 To 19

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)

            Button15.Text = mn(15)

            Button17.Text = mn(17)

            Button18.Text = mn(18)

            Button19.Text = mn(19)


        End If

        If rc = 20 Then

            Button1.Visible = True

            Button2.Visible = True

            Button3.Visible = True

            Button4.Visible = True

            Button5.Visible = True

            Button6.Visible = True

            Button7.Visible = True

            Button8.Visible = True

            Button9.Visible = True

            Button10.Visible = True

            Button11.Visible = True

            Button12.Visible = True

            Button13.Visible = True

            Button14.Visible = True

            Button15.Visible = True

            Button16.Visible = True

            Button17.Visible = True

            Button18.Visible = True

            Button19.Visible = True

            Button20.Visible = True


            For i = 1 To 20

                For Each row As DataRow In dtRS.Rows

                    mn(i) = row("mn")

                    i = i + 1

                Next

            Next

            Button1.Text = mn(1)

            Button2.Text = mn(2)

            Button3.Text = mn(3)

            Button4.Text = mn(4)

            Button5.Text = mn(5)

            Button6.Text = mn(6)

            Button7.Text = mn(7)

            Button8.Text = mn(8)

            Button9.Text = mn(9)

            Button10.Text = mn(10)

            Button11.Text = mn(11)

            Button12.Text = mn(12)

            Button13.Text = mn(13)

            Button14.Text = mn(14)

            Button15.Text = mn(15)

            Button17.Text = mn(17)

            Button18.Text = mn(18)

            Button19.Text = mn(19)

            Button20.Text = mn(20)

        End If



        con.Close()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button1.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button1.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button1.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)



                Dim p As String

                p = slocat

                Dim extension As String = path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If



                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button1.Text.Trim & "')"

                Call executeQuery(str4)



                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:

       

        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button2.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button2.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button2.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)



                Dim p As String

                p = slocat

                Dim extension As String = path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button2.Text.Trim & "')"

                Call executeQuery(str4)




                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button3.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button3.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button3.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)


                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button3.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button4.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button4.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button4.Text & "'")


            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button4.Text.Trim & "')"

                Call executeQuery(str4)

                GoTo b

            Else

                GoTo b

            End If


        End If



            If rc = 1 Then

                Button21.Visible = True

                For i = 1 To 1

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

            End If


            If rc = 2 Then

                Button21.Visible = True

                Button22.Visible = True

                For i = 1 To 2

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

            End If


            If rc = 3 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                For i = 1 To 3

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

            End If


            If rc = 4 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                For i = 1 To 4

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

            End If


            If rc = 5 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                Button25.Visible = True

                For i = 1 To 5

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

                Button25.Text = sb(5)

            End If


            If rc = 6 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                Button25.Visible = True

                Button26.Visible = True

                For i = 1 To 6

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

                Button25.Text = sb(5)

                Button26.Text = sb(6)

            End If


            If rc = 7 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                Button25.Visible = True

                Button26.Visible = True

                Button27.Visible = True

                For i = 1 To 7

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

                Button25.Text = sb(5)

                Button26.Text = sb(6)

                Button27.Text = sb(7)

            End If


            If rc = 8 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                Button25.Visible = True

                Button26.Visible = True

                Button27.Visible = True

                Button28.Visible = True

                For i = 1 To 8

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

                Button25.Text = sb(5)

                Button26.Text = sb(6)

                Button27.Text = sb(7)

                Button28.Text = sb(8)

            End If


            If rc = 9 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                Button25.Visible = True

                Button26.Visible = True

                Button27.Visible = True

                Button28.Visible = True

                Button29.Visible = True

                For i = 1 To 9

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

                Button25.Text = sb(5)

                Button26.Text = sb(6)

                Button27.Text = sb(7)

                Button28.Text = sb(8)

                Button29.Text = sb(9)

            End If


            If rc = 10 Then

                Button21.Visible = True

                Button22.Visible = True

                Button23.Visible = True

                Button24.Visible = True

                Button25.Visible = True

                Button26.Visible = True

                Button27.Visible = True

                Button28.Visible = True

                Button29.Visible = True

                Button30.Visible = True

                For i = 1 To 10

                    For Each row As DataRow In dtRS.Rows

                        sb(i) = row("sb")

                        i = i + 1

                    Next

                Next

                Button21.Text = sb(1)

                Button22.Text = sb(2)

                Button23.Text = sb(3)

                Button24.Text = sb(4)

                Button25.Text = sb(5)

                Button26.Text = sb(6)

                Button27.Text = sb(7)

                Button28.Text = sb(8)

                Button29.Text = sb(9)

                Button30.Text = sb(10)

            End If


b:



            con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button5.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button5.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button5.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button5.Text.Trim & "')"

                Call executeQuery(str4)

                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button6.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button6.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button6.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button6.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button7.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button7.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button7.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next

                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button7.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button8.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button8.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button8.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button8.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button9.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button9.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button9.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button9.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button10.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button10.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button10.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)


                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button10.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button11.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button11.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button11.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button11.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button12.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button12.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button12.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button12.Text.Trim & "')"

                Call executeQuery(str4)

                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button13.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button13.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button13.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)

                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button13.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button14.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button14.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button14.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button14.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If





        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button15.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button15.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button15.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button15.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button16.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button16.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button16.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button16.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button17.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button17.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button17.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")


                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button17.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If




        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button20.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button20.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button20.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next

                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button20.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If





        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button18.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button18.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button18.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)

                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button18.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If





        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Call createConnection()

        TextBox4.Text = ""

        TextBox1.Text = ""

        TextBox1.Text = Button19.Text

        Button21.Visible = False

        Button22.Visible = False

        Button23.Visible = False

        Button24.Visible = False

        Button25.Visible = False

        Button26.Visible = False

        Button27.Visible = False

        Button28.Visible = False

        Button29.Visible = False

        Button30.Visible = False



        Dim rc, i As Integer

        Dim sb(10) As String

        Dim dtRS As DataTable = getDataTable("Select * from itssub where mn ='" & Button19.Text & "' order by sno")

        rc = dtRS.Rows.Count


        If rc = 0 Then

            Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & Button19.Text & "'")

            If dtRS1.Rows.Count > 0 Then

                For Each row As DataRow In dtRS1.Rows

                    TextBox4.Text = row("sno")

                Next


                Dim myfolder As String = "C:\Solution\"

                Dim sh As Object = CreateObject("shell.application")
                For Each w In sh.Windows
                    If w.document.folder.self.Path = myfolder Then w.Quit()
                Next


                Dim path1 As String = "C:\Solution\"

                If Not Directory.Exists(path1) Then
                    Directory.CreateDirectory(path1)
                End If




                'Dim slocat As String

                Dim idfname As String

                idfname = ""

                slocat = "C:\Solution\"

                On Error Resume Next
                My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

                System.IO.Directory.CreateDirectory(slocat)

                Dim Rqry, sno As String


                sno = TextBox4.Text



                Rqry = "Select * from itsdocumentdetails where sno= " & sno


                Dim dtRS2 As DataTable = getDataTable(Rqry)


                Dim ordno As Integer


                ordno = 1


                For Each row As DataRow In dtRS2.Rows


                    Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                    idfname = row("idfname")

                    cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                    cmd.Parameters.AddWithValue("@ordrno", ordno)


                    IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

                    ordno = Val(ordno) + 1



                Next


                slocat = "C:\Solution\" + idfname

                'Process.Start(slocat)
                Dim p As String

                p = slocat

                Dim extension As String = Path.GetExtension(p)


                If extension = ".mp4" Then

                    Form11.AxWindowsMediaPlayer1.Width = 1150

                    Form11.AxWindowsMediaPlayer1.Height = 795

                    Form11.AxWindowsMediaPlayer1.URL = slocat


                    Form11.ShowDialog()

                End If


                If extension = ".pdf" Then

                    Form12.AxAcroPDF1.src = slocat


                    Form12.ShowDialog()

                End If


                If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                    Form13.PictureBox1.Image = Image.FromFile(slocat)


                    Form13.ShowDialog()

                End If

                DateTimePicker1.Value = nowdate()

                Dim str4 As String


                str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & Button19.Text.Trim & "')"

                Call executeQuery(str4)


                GoTo b

            Else

                GoTo b

            End If


        End If



        If rc = 1 Then

            Button21.Visible = True

            For i = 1 To 1

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

        End If


        If rc = 2 Then

            Button21.Visible = True

            Button22.Visible = True

            For i = 1 To 2

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

        End If


        If rc = 3 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            For i = 1 To 3

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

        End If


        If rc = 4 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            For i = 1 To 4

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

        End If


        If rc = 5 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            For i = 1 To 5

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

        End If


        If rc = 6 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            For i = 1 To 6

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

        End If


        If rc = 7 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            For i = 1 To 7

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

        End If


        If rc = 8 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            For i = 1 To 8

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

        End If


        If rc = 9 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            For i = 1 To 9

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

        End If


        If rc = 10 Then

            Button21.Visible = True

            Button22.Visible = True

            Button23.Visible = True

            Button24.Visible = True

            Button25.Visible = True

            Button26.Visible = True

            Button27.Visible = True

            Button28.Visible = True

            Button29.Visible = True

            Button30.Visible = True

            For i = 1 To 10

                For Each row As DataRow In dtRS.Rows

                    sb(i) = row("sb")

                    i = i + 1

                Next

            Next

            Button21.Text = sb(1)

            Button22.Text = sb(2)

            Button23.Text = sb(3)

            Button24.Text = sb(4)

            Button25.Text = sb(5)

            Button26.Text = sb(6)

            Button27.Text = sb(7)

            Button28.Text = sb(8)

            Button29.Text = sb(9)

            Button30.Text = sb(10)

        End If


b:



        con.Close()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button30.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button30.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button30.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button29.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button29.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button29.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click

        Call createConnection()

     

        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button21.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If

           


            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If


            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button21.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()

    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button22.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"

        '            On Error Resume Next
        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button22.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button22.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()





    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button23.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)

        '            'AxAcroPDF1.src = slocat



        '        Else


        '        End If


        '        con.Close()


        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button23.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If


            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button23.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button24.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button24.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button24.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()


    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button25.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button25.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button25.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button26.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()


        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button26.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button26.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button27.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button27.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button27.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        '        Call createConnection()

        '        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button28.Text & "'")

        '        If dtRS1.Rows.Count > 0 Then


        '            For Each row As DataRow In dtRS1.Rows

        '                TextBox4.Text = row("sno")

        '            Next


        '            Dim myfolder As String = "C:\Solution\"

        '            Dim sh As Object = CreateObject("shell.application")
        '            For Each w In sh.Windows
        '                If w.document.folder.self.Path = myfolder Then w.Quit()
        '            Next


        '            Dim path As String = "C:\Solution\"

        '            If Not Directory.Exists(path) Then
        '                Directory.CreateDirectory(path)
        '            End If




        '            Dim slocat As String

        '            Dim idfname As String

        '            idfname = ""

        '            slocat = "C:\Solution\"


        '            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

        '            System.IO.Directory.CreateDirectory(slocat)

        '            Dim Rqry, sno As String


        '            sno = TextBox4.Text



        '            Rqry = "Select * from itsdocumentdetails where sno= " & sno


        '            Dim dtRS2 As DataTable = getDataTable(Rqry)


        '            Dim ordno As Integer


        '            ordno = 1


        '            For Each row As DataRow In dtRS2.Rows


        'c:              Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

        '                idfname = row("idfname")

        '                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


        '                cmd.Parameters.AddWithValue("@ordrno", ordno)

        '                On Error GoTo c
        '                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))

        '                ordno = Val(ordno) + 1



        '            Next


        '            slocat = "C:\Solution\" + idfname

        '            Process.Start(slocat)



        '        Else


        '        End If


        '        con.Close()



        Call createConnection()



        Dim dtRS1 As DataTable = getDataTable("Select * from itssolutiondetails where mn ='" & TextBox1.Text & "' and sb ='" & Button28.Text & "'")

        If dtRS1.Rows.Count > 0 Then


            For Each row As DataRow In dtRS1.Rows

                TextBox4.Text = row("sno")

            Next


            Dim myfolder As String = "C:\Solution\"

            Dim sh As Object = CreateObject("shell.application")
            For Each w In sh.Windows
                If w.document.folder.self.Path = myfolder Then w.Quit()
            Next


            Dim path1 As String = "C:\Solution\"

            If Not Directory.Exists(path1) Then
                Directory.CreateDirectory(path1)
            End If




            Dim idfname As String


            idfname = ""


            slocat = "C:\Solution\"

            On Error Resume Next
            My.Computer.FileSystem.DeleteDirectory(slocat, FileIO.DeleteDirectoryOption.DeleteAllContents)

            System.IO.Directory.CreateDirectory(slocat)

            Dim Rqry, sno As String


            sno = TextBox4.Text



            Rqry = "Select * from itsdocumentdetails where sno= " & sno


            Dim dtRS2 As DataTable = getDataTable(Rqry)


            Dim ordno As Integer


            ordno = 1


            For Each row As DataRow In dtRS2.Rows


                Dim cmd As New SqlCommand("select Filen from itsdocumentdetails where sno=@sno and ordrno=@ordrno", con)

                idfname = row("idfname")


                cmd.Parameters.AddWithValue("@sno", TextBox4.Text)


                cmd.Parameters.AddWithValue("@ordrno", ordno)


                IO.File.WriteAllBytes(slocat & row("idfname"), CType(cmd.ExecuteScalar, Byte()))


                ordno = Val(ordno) + 1



            Next


            slocat = "C:\Solution\" + idfname

            'Process.Start(slocat)

            Dim p As String

            p = slocat

            Dim extension As String = Path.GetExtension(p)


            If extension = ".mp4" Then

                Form11.AxWindowsMediaPlayer1.Width = 1150

                Form11.AxWindowsMediaPlayer1.Height = 795

                Form11.AxWindowsMediaPlayer1.URL = slocat


                Form11.ShowDialog()

            End If


            If extension = ".pdf" Then

                Form12.AxAcroPDF1.src = slocat


                Form12.ShowDialog()

            End If


            If extension = ".jpg" Or extension = ".png" Or extension = ".bmp" Then


                Form13.PictureBox1.Image = Image.FromFile(slocat)


                Form13.ShowDialog()

            End If

            DateTimePicker1.Value = nowdate()

            Dim str4 As String


            str4 = "INSERT INTO itopenlog([dt],[dtonly],[mn],[sb]) VALUES('" & Format(DateTimePicker1.Value) & "','" & Format(DateTimePicker1.Value.Date, "dd-MMM-yyyy") & "','" & TextBox1.Text.Trim & "','" & Button28.Text.Trim & "')"

            Call executeQuery(str4)


        Else


        End If


        con.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class