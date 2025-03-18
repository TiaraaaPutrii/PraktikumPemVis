Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonHITUNG_Click(sender As Object, e As EventArgs) Handles ButtonHITUNG.Click
        Dim hasil As Integer
        hasil = TXTPANJANG.Text * TXTLEBAR.Text
        MessageBox.Show(hasil, "Hasil Hitungan")
    End Sub
End Class
