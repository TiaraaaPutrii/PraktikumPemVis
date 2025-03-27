Public Class Form1

    ' Function untuk mendapatkan daftar hobi yang dipilih
    Private Function GetHobiTerpilih() As String
        Dim hobi As String = ""
        For Each ctrl As Control In GroupBoxHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    hobi &= chk.Text & ", "
                End If
            End If
        Next
        Return hobi.TrimEnd(", ".ToCharArray())
    End Function

    ' Button untuk memilih foto
    Private Sub btnPilihFoto_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            PictureBox1.Tag = openFileDialog.FileName ' Simpan path foto di Tag PictureBox
        End If
    End Sub

    ' Button Cetak Kartu
    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        ' Validasi inputan
        If txtNama.Text = "" OrElse txtUmur.Text = "" OrElse txtTelepon.Text = "" OrElse txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi hanya huruf untuk Nama
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtNama.Text, "^[a-zA-Z ]+$") Then
            MessageBox.Show("Nama hanya boleh mengandung huruf", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi hanya angka untuk Umur dan Telepon
        If Not IsNumeric(txtUmur.Text) OrElse Not IsNumeric(txtTelepon.Text) Then
            MessageBox.Show("Umur dan No Telepon harus berupa angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi RadioButton
        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Silakan pilih jenis kelamin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validasi setidaknya satu hobi dipilih
        Dim hobiTerpilih As String = GetHobiTerpilih()
        If hobiTerpilih = "" Then
            MessageBox.Show("Pilih setidaknya satu hobi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Tangkap path foto
        Dim fotoPath As String = If(PictureBox1.Tag IsNot Nothing, PictureBox1.Tag.ToString(), "")

        ' Kirim data ke Form2
        Dim formHasil As New Form2(txtNama.Text, txtUmur.Text, txtTelepon.Text, txtAlamat.Text,
                                   dtpTanggalLahir.Value.ToString("dd MMMM yyyy"),
                                   If(rbLaki.Checked, "Laki-laki", "Perempuan"), hobiTerpilih, fotoPath)
        formHasil.Show()
    End Sub
End Class
