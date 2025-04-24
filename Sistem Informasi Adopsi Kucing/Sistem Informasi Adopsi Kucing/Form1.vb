Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=dbkucing")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub tampilData()
        koneksi()
        da = New MySqlDataAdapter("SELECT * FROM kucing", conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        RichTextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        PictureBox1.Image = Nothing
        DateTimePicker1.Value = Date.Today
    End Sub

    Private Sub FormDataKucing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        koneksi()
        sql = "INSERT INTO kucing (id_kucing, id_user, nama, ras, umur, jenis_kelamin, warna, tanggal_masuk, status_vaksinasi, status_adopsi, deskripsi, foto) 
VALUES (@id, @id_user,@nama,@ras,@umur,@jk,@warna,@tgl,@vaksin,@adopsi,@deskripsi,@foto)"
        cmd = New MySqlCommand(sql, conn)
        With cmd.Parameters
            .AddWithValue("@id", TextBox1.Text)
            .AddWithValue("@id_user", Form2.id_user)
            .AddWithValue("@nama", TextBox2.Text)
            .AddWithValue("@ras", TextBox3.Text)
            .AddWithValue("@umur", TextBox4.Text)
            .AddWithValue("@jk", TextBox5.Text)
            .AddWithValue("@warna", TextBox6.Text)
            .AddWithValue("@tgl", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@vaksin", ComboBox1.Text)
            .AddWithValue("@adopsi", ComboBox2.Text)
            .AddWithValue("@deskripsi", RichTextBox1.Text)
            .AddWithValue("@foto", File.ReadAllBytes(PictureBox1.ImageLocation))
        End With
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil ditambahkan.")
        tampilData()
        kosongkan()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        koneksi()
        sql = "UPDATE kucing SET nama=@nama, ras=@ras, umur=@umur, jenis_kelamin=@jk, warna=@warna, tanggal_masuk=@tgl, status_vaksinasi=@vaksin, 
status_adopsi=@adopsi, deskripsi=@deskripsi, foto=@foto WHERE id_kucing=@id"
        cmd = New MySqlCommand(sql, conn)
        With cmd.Parameters
            .AddWithValue("@id", TextBox1.Text)
            .AddWithValue("@nama", TextBox2.Text)
            .AddWithValue("@ras", TextBox3.Text)
            .AddWithValue("@umur", TextBox4.Text)
            .AddWithValue("@jk", TextBox5.Text)
            .AddWithValue("@warna", TextBox6.Text)
            .AddWithValue("@tgl", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@vaksin", ComboBox1.Text)
            .AddWithValue("@adopsi", ComboBox2.Text)
            .AddWithValue("@deskripsi", RichTextBox1.Text)
            .AddWithValue("@foto", File.ReadAllBytes(PictureBox1.ImageLocation))
        End With
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah.")
        tampilData()
        kosongkan()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        koneksi()
        sql = "DELETE FROM kucing WHERE id_kucing=@id"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@id", TextBox1.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil dihapus.")
        tampilData()
        kosongkan()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        kosongkan()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("id_kucing").Value.ToString()
            TextBox2.Text = row.Cells("nama").Value.ToString()
            TextBox3.Text = row.Cells("ras").Value.ToString()
            TextBox4.Text = row.Cells("umur").Value.ToString()
            TextBox5.Text = row.Cells("jenis_kelamin").Value.ToString()
            TextBox6.Text = row.Cells("warna").Value.ToString()
            DateTimePicker1.Value = Convert.ToDateTime(row.Cells("tanggal_masuk").Value)
            ComboBox1.Text = row.Cells("status_vaksinasi").Value.ToString()
            ComboBox2.Text = row.Cells("status_adopsi").Value.ToString()
            RichTextBox1.Text = row.Cells("deskripsi").Value.ToString()

            ' Tampilkan gambar
            Dim img() As Byte = CType(row.Cells("foto").Value, Byte())
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        koneksi()
        sql = "SELECT * FROM kucing WHERE id_kucing LIKE @id_kucing"
        cmd = New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@id_kucing", "%" & TextBox7.Text & "%")
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnTambahFoto_Click(sender As Object, e As EventArgs) Handles btnTambahFoto.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openFile.ShowDialog = DialogResult.OK Then
            PictureBox1.ImageLocation = openFile.FileName
        End If
    End Sub

End Class
