Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form2
    Public id_user As Integer
    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbkucing")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Function SEARCH(ByRef x As String, ByRef y As String)
        koneksi()
        cmd = New MySqlCommand("select id_user from user where username = '" & x & "' and password = '" & y & "'", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            id_user = dr("id_user")
            Return True
        End If
        dr.Close()
        Return False
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pass = TextBox2.Text
        Dim User = TextBox1.Text

        If SEARCH(User, pass) Then
            dr.Close()
            Form1.Show()
            Me.Hide()
        Else
            Label3.Visible = True
            TextBox2.Clear()
            TextBox1.Clear()
            TextBox1.Focus()
        End If
    End Sub
End Class