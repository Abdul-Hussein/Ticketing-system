
Imports System.Data.SqlClient
Module Module1
    Public con As SqlConnection
    Public addtest, newitem, newitem1, newitem2, newitem3, newitem4 As Integer
    Public ttle, uname, br, slocat As String
    Public rowcnt, rowcnt1, rowcnt2 As Integer
    Public Sub createConnection()
        On Error Resume Next


        con = New SqlConnection

        con.ConnectionString = "Data Source=192.168.10.132;Initial Catalog=itsolution;User ID=sa;Password=abcd1234;"

        con.Open()

    End Sub

    Public Sub executeQuery(ByVal SQL As String)
        On Error GoTo oo
        addtest = 0
        Dim cmdX As New SqlCommand(SQL, con)
        cmdX.ExecuteNonQuery()
        'Debug.Print(SQL)
        Exit Sub
oo:
        '  MsgBox(Err.Description)
        addtest = 1
    End Sub
    Public Function VerifyFldNew(ByVal Qry As String, ByVal tblName As String, ByVal fldName As String, Optional ByVal sumstat As Boolean = False) As String


        Dim query3 As String = Qry '"Select " & fldName & " from " & tblName & " where " & fldName & "='" & SearchString & "'"
        Dim drVn As SqlClient.SqlDataReader
        drVn = getDataReader(query3)
        If (drVn IsNot Nothing AndAlso drVn.HasRows) Then
            drVn.Read()
            If sumstat = True Then
                VerifyFldNew = drVn(0).ToString
            Else
                VerifyFldNew = drVn(fldName).ToString
            End If
        Else
            VerifyFldNew = ""
        End If

        drVn.Close()

    End Function
    Public Function getDataReader(ByVal SQL As String) As SqlDataReader
        On Error GoTo 0

        Dim cmd As New SqlCommand(SQL, con)
        Dim drm As SqlDataReader
        'drm.Close()
        drm = cmd.ExecuteReader
        Return drm
        drm.Close()
        Exit Function
        '0:
        '        MsgBox(Err.Description)

    End Function
    Public Function getDataTable(ByVal SQL As String) As DataTable
        On Error GoTo Out

        Dim cmds As New SqlCommand(SQL, con)
        Dim table As New DataTable
        Dim das As New SqlDataAdapter(cmds)
        das.Fill(table)
        Return table
Out:

    End Function

End Module
