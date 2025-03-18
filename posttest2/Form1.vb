' Module untuk menyimpan daftar buku
Module ModuleBuku
    Public daftarBuku(99) As String ' Array dengan kapasitas 100 buku
    Public jumlahBuku As Integer = 0 ' Menyimpan jumlah buku yang terisi
End Module

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi ListBox
        UpdateListBox()
    End Sub

    ' Fungsi untuk mencari indeks buku berdasarkan judul
    Private Function CariIndeksBuku(ByVal judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).StartsWith(judul & " (") Then
                Return i
            End If
        Next
        Return -1 ' Buku tidak ditemukan
    End Function

    ' Prosedur untuk menambahkan buku
    Private Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If judul <> "" And genre <> "" Then
            If jumlahBuku < daftarBuku.Length Then
                daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
                jumlahBuku += 1
                UpdateListBox()
            Else
                MessageBox.Show("Kapasitas daftar buku penuh!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Prosedur untuk menghapus buku
    Private Sub HapusBuku(ByVal judul As String)
        Dim indeks As Integer = CariIndeksBuku(judul)
        If indeks <> -1 Then
            For i As Integer = indeks To jumlahBuku - 2
                daftarBuku(i) = daftarBuku(i + 1)
            Next
            jumlahBuku -= 1
            daftarBuku(jumlahBuku) = Nothing
            UpdateListBox()
        Else
            MessageBox.Show("Buku tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Prosedur untuk memperbarui tampilan ListBox
    Private Sub UpdateListBox()
        LB1.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            LB1.Items.Add(daftarBuku(i))
        Next
    End Sub

    ' Event klik tombol tambah
    Private Sub BTNtambah_Click(sender As Object, e As EventArgs) Handles BTNtambah.Click
        TambahBuku(TBJudulBuku.Text, TBGenre.Text)
        TBJudulBuku.Clear()
        TBGenre.Clear()
    End Sub

    ' Event klik tombol hapus
    Private Sub BTNhapus_Click(sender As Object, e As EventArgs) Handles BTNhapus.Click
        HapusBuku(TBJudulBuku2.Text)
        TBJudulBuku2.Clear()
    End Sub
End Class
