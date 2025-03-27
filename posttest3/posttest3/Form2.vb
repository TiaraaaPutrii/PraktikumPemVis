Imports System.Drawing.Printing

Public Class Form2
    Private bgImage As Image ' Menyimpan background image

    ' Constructor untuk menerima data dari Form1
    Public Sub New(ByVal nama As String, ByVal umur As String, ByVal telepon As String, ByVal alamat As String,
                   ByVal tanggalLahir As String, ByVal jenisKelamin As String, ByVal hobi As String, ByVal fotoPath As String)

        ' Inisialisasi komponen
        InitializeComponent()

        ' Pastikan label hanya menampilkan data tanpa teks tambahan
        lblNama.Text = nama.Trim()
        lblUmur.Text = umur.Trim()
        lblTelepon.Text = telepon.Trim()
        lblAlamat.Text = alamat.Trim()
        lblTanggalLahir.Text = tanggalLahir.Trim()
        lblJenisKelamin.Text = jenisKelamin.Trim()
        lblHobi.Text = hobi.Trim()

        ' Menampilkan gambar jika ada
        If Not String.IsNullOrEmpty(fotoPath) AndAlso IO.File.Exists(fotoPath) Then
            PictureBoxHasil.Image = Image.FromFile(fotoPath)
            PictureBoxHasil.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBoxHasil.Image = Nothing
        End If

        ' Simpan background image dari Form2
        bgImage = Me.BackgroundImage
    End Sub

    ' Tombol untuk mencetak kartu
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        printDoc.Print()
    End Sub

    ' Event untuk mencetak kartu dengan background tidak ter-zoom
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim areaCetak As New Rectangle(0, 0, e.PageBounds.Width, e.PageBounds.Height)

        ' Pastikan background tidak ter-zoom dengan DrawImage
        If bgImage IsNot Nothing Then
            g.DrawImage(bgImage, areaCetak, New Rectangle(0, 0, bgImage.Width, bgImage.Height), GraphicsUnit.Pixel)
        End If

        ' Cetak teks dengan font yang sesuai
        Dim fontCetak As New Font("Arial", 14, FontStyle.Bold)
        g.DrawString(lblNama.Text, fontCetak, Brushes.Black, 50, 50)
        g.DrawString(lblHobi.Text, fontCetak, Brushes.Black, 50, 80)
        g.DrawString(lblJenisKelamin.Text, fontCetak, Brushes.Black, 50, 110)
    End Sub

    ' Button kembali ke Form1
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub lblAlamat_Click(sender As Object, e As EventArgs) Handles lblAlamat.Click

    End Sub

    Private Sub lblTelepon_Click(sender As Object, e As EventArgs) Handles lblTelepon.Click

    End Sub

    Private Sub lblTanggalLahir_Click(sender As Object, e As EventArgs) Handles lblTanggalLahir.Click

    End Sub
End Class
