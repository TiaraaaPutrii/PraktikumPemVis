<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTanggalLahi = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtTelepon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.gbJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.GroupBoxHobi = New System.Windows.Forms.GroupBox()
        Me.chkMelukis = New System.Windows.Forms.CheckBox()
        Me.chkCoding = New System.Windows.Forms.CheckBox()
        Me.chkTenis = New System.Windows.Forms.CheckBox()
        Me.chkTraveling = New System.Windows.Forms.CheckBox()
        Me.chkGolf = New System.Windows.Forms.CheckBox()
        Me.chkBasket = New System.Windows.Forms.CheckBox()
        Me.chkBadminton = New System.Windows.Forms.CheckBox()
        Me.chkMembaca = New System.Windows.Forms.CheckBox()
        Me.chkMenari = New System.Windows.Forms.CheckBox()
        Me.chkNyanyi = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnCetakKartu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbJenisKelamin.SuspendLayout()
        Me.GroupBoxHobi.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(56, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 313)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Umur"
        '
        'lblTanggalLahi
        '
        Me.lblTanggalLahi.AutoSize = True
        Me.lblTanggalLahi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalLahi.Location = New System.Drawing.Point(310, 151)
        Me.lblTanggalLahi.Name = "lblTanggalLahi"
        Me.lblTanggalLahi.Size = New System.Drawing.Size(124, 20)
        Me.lblTanggalLahi.TabIndex = 4
        Me.lblTanggalLahi.Text = "Tanggal Lahir"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.Location = New System.Drawing.Point(310, 193)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(94, 20)
        Me.lblTelepon.TabIndex = 5
        Me.lblTelepon.Text = "No Telpon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Alamat"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(448, 67)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(543, 22)
        Me.txtNama.TabIndex = 7
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(448, 110)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(543, 22)
        Me.txtUmur.TabIndex = 8
        '
        'txtTelepon
        '
        Me.txtTelepon.Location = New System.Drawing.Point(448, 191)
        Me.txtTelepon.Name = "txtTelepon"
        Me.txtTelepon.Size = New System.Drawing.Size(543, 22)
        Me.txtTelepon.TabIndex = 9
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(448, 231)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(543, 22)
        Me.txtAlamat.TabIndex = 10
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(448, 149)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(543, 22)
        Me.dtpTanggalLahir.TabIndex = 11
        '
        'gbJenisKelamin
        '
        Me.gbJenisKelamin.BackColor = System.Drawing.Color.PeachPuff
        Me.gbJenisKelamin.Controls.Add(Me.rbPerempuan)
        Me.gbJenisKelamin.Controls.Add(Me.rbLaki)
        Me.gbJenisKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbJenisKelamin.Location = New System.Drawing.Point(313, 282)
        Me.gbJenisKelamin.Name = "gbJenisKelamin"
        Me.gbJenisKelamin.Size = New System.Drawing.Size(159, 107)
        Me.gbJenisKelamin.TabIndex = 12
        Me.gbJenisKelamin.TabStop = False
        Me.gbJenisKelamin.Text = "Jenis Kelamin"
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerempuan.Location = New System.Drawing.Point(27, 71)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(98, 20)
        Me.rbPerempuan.TabIndex = 1
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLaki.Location = New System.Drawing.Point(27, 31)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(84, 20)
        Me.rbLaki.TabIndex = 0
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki - laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'GroupBoxHobi
        '
        Me.GroupBoxHobi.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBoxHobi.Controls.Add(Me.chkMelukis)
        Me.GroupBoxHobi.Controls.Add(Me.chkCoding)
        Me.GroupBoxHobi.Controls.Add(Me.chkTenis)
        Me.GroupBoxHobi.Controls.Add(Me.chkTraveling)
        Me.GroupBoxHobi.Controls.Add(Me.chkGolf)
        Me.GroupBoxHobi.Controls.Add(Me.chkBasket)
        Me.GroupBoxHobi.Controls.Add(Me.chkBadminton)
        Me.GroupBoxHobi.Controls.Add(Me.chkMembaca)
        Me.GroupBoxHobi.Controls.Add(Me.chkMenari)
        Me.GroupBoxHobi.Controls.Add(Me.chkNyanyi)
        Me.GroupBoxHobi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxHobi.Location = New System.Drawing.Point(491, 282)
        Me.GroupBoxHobi.Name = "GroupBoxHobi"
        Me.GroupBoxHobi.Size = New System.Drawing.Size(500, 107)
        Me.GroupBoxHobi.TabIndex = 13
        Me.GroupBoxHobi.TabStop = False
        Me.GroupBoxHobi.Text = "Hobi"
        '
        'chkMelukis
        '
        Me.chkMelukis.AutoSize = True
        Me.chkMelukis.Location = New System.Drawing.Point(405, 70)
        Me.chkMelukis.Name = "chkMelukis"
        Me.chkMelukis.Size = New System.Drawing.Size(75, 20)
        Me.chkMelukis.TabIndex = 9
        Me.chkMelukis.Text = "Melukis"
        Me.chkMelukis.UseVisualStyleBackColor = True
        '
        'chkCoding
        '
        Me.chkCoding.AutoSize = True
        Me.chkCoding.Location = New System.Drawing.Point(405, 31)
        Me.chkCoding.Name = "chkCoding"
        Me.chkCoding.Size = New System.Drawing.Size(72, 20)
        Me.chkCoding.TabIndex = 8
        Me.chkCoding.Text = "Coding"
        Me.chkCoding.UseVisualStyleBackColor = True
        '
        'chkTenis
        '
        Me.chkTenis.AutoSize = True
        Me.chkTenis.Location = New System.Drawing.Point(313, 70)
        Me.chkTenis.Name = "chkTenis"
        Me.chkTenis.Size = New System.Drawing.Size(63, 20)
        Me.chkTenis.TabIndex = 7
        Me.chkTenis.Text = "Tenis"
        Me.chkTenis.UseVisualStyleBackColor = True
        '
        'chkTraveling
        '
        Me.chkTraveling.AutoSize = True
        Me.chkTraveling.Location = New System.Drawing.Point(313, 31)
        Me.chkTraveling.Name = "chkTraveling"
        Me.chkTraveling.Size = New System.Drawing.Size(86, 20)
        Me.chkTraveling.TabIndex = 6
        Me.chkTraveling.Text = "Traveling"
        Me.chkTraveling.UseVisualStyleBackColor = True
        '
        'chkGolf
        '
        Me.chkGolf.AutoSize = True
        Me.chkGolf.Location = New System.Drawing.Point(236, 70)
        Me.chkGolf.Name = "chkGolf"
        Me.chkGolf.Size = New System.Drawing.Size(53, 20)
        Me.chkGolf.TabIndex = 5
        Me.chkGolf.Text = "Golf"
        Me.chkGolf.UseVisualStyleBackColor = True
        '
        'chkBasket
        '
        Me.chkBasket.AutoSize = True
        Me.chkBasket.Location = New System.Drawing.Point(236, 31)
        Me.chkBasket.Name = "chkBasket"
        Me.chkBasket.Size = New System.Drawing.Size(71, 20)
        Me.chkBasket.TabIndex = 4
        Me.chkBasket.Text = "Basket"
        Me.chkBasket.UseVisualStyleBackColor = True
        '
        'chkBadminton
        '
        Me.chkBadminton.AutoSize = True
        Me.chkBadminton.Location = New System.Drawing.Point(102, 70)
        Me.chkBadminton.Name = "chkBadminton"
        Me.chkBadminton.Size = New System.Drawing.Size(93, 20)
        Me.chkBadminton.TabIndex = 3
        Me.chkBadminton.Text = "Badminton"
        Me.chkBadminton.UseVisualStyleBackColor = True
        '
        'chkMembaca
        '
        Me.chkMembaca.AutoSize = True
        Me.chkMembaca.Location = New System.Drawing.Point(102, 32)
        Me.chkMembaca.Name = "chkMembaca"
        Me.chkMembaca.Size = New System.Drawing.Size(123, 20)
        Me.chkMembaca.TabIndex = 2
        Me.chkMembaca.Text = "Membaca Buku"
        Me.chkMembaca.UseVisualStyleBackColor = True
        '
        'chkMenari
        '
        Me.chkMenari.AutoSize = True
        Me.chkMenari.Location = New System.Drawing.Point(25, 70)
        Me.chkMenari.Name = "chkMenari"
        Me.chkMenari.Size = New System.Drawing.Size(70, 20)
        Me.chkMenari.TabIndex = 1
        Me.chkMenari.Text = "Menari"
        Me.chkMenari.UseVisualStyleBackColor = True
        '
        'chkNyanyi
        '
        Me.chkNyanyi.AutoSize = True
        Me.chkNyanyi.Location = New System.Drawing.Point(25, 31)
        Me.chkNyanyi.Name = "chkNyanyi"
        Me.chkNyanyi.Size = New System.Drawing.Size(71, 20)
        Me.chkNyanyi.TabIndex = 0
        Me.chkNyanyi.Text = "Nyanyi"
        Me.chkNyanyi.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(99, 385)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(160, 29)
        Me.btnBrowse.TabIndex = 14
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnCetakKartu
        '
        Me.btnCetakKartu.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCetakKartu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCetakKartu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakKartu.Location = New System.Drawing.Point(313, 407)
        Me.btnCetakKartu.Name = "btnCetakKartu"
        Me.btnCetakKartu.Size = New System.Drawing.Size(678, 29)
        Me.btnCetakKartu.TabIndex = 15
        Me.btnCetakKartu.Text = "Cetak Kartu"
        Me.btnCetakKartu.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1010, 492)
        Me.Controls.Add(Me.btnCetakKartu)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.GroupBoxHobi)
        Me.Controls.Add(Me.gbJenisKelamin)
        Me.Controls.Add(Me.dtpTanggalLahir)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtTelepon)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblTanggalLahi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbJenisKelamin.ResumeLayout(False)
        Me.gbJenisKelamin.PerformLayout()
        Me.GroupBoxHobi.ResumeLayout(False)
        Me.GroupBoxHobi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTanggalLahi As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents gbJenisKelamin As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents GroupBoxHobi As GroupBox
    Friend WithEvents chkMelukis As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkTenis As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkGolf As CheckBox
    Friend WithEvents chkBasket As CheckBox
    Friend WithEvents chkBadminton As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkMenari As CheckBox
    Friend WithEvents chkNyanyi As CheckBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetakKartu As Button
End Class
