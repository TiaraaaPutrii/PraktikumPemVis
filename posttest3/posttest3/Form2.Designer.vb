<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBoxHasil = New System.Windows.Forms.PictureBox()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblTanggalLahir = New System.Windows.Forms.Label()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.lblHobi = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        CType(Me.PictureBoxHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxHasil
        '
        Me.PictureBoxHasil.Location = New System.Drawing.Point(48, 61)
        Me.PictureBoxHasil.Name = "PictureBoxHasil"
        Me.PictureBoxHasil.Size = New System.Drawing.Size(195, 245)
        Me.PictureBoxHasil.TabIndex = 0
        Me.PictureBoxHasil.TabStop = False
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.BackColor = System.Drawing.Color.Transparent
        Me.lblUmur.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUmur.Location = New System.Drawing.Point(297, 176)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(63, 26)
        Me.lblUmur.TabIndex = 2
        Me.lblUmur.Text = "Umur"
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.BackColor = System.Drawing.Color.Transparent
        Me.lblTelepon.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.Location = New System.Drawing.Point(296, 210)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(107, 26)
        Me.lblTelepon.TabIndex = 3
        Me.lblTelepon.Text = "No Telepon"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.BackColor = System.Drawing.Color.Transparent
        Me.lblAlamat.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlamat.Location = New System.Drawing.Point(296, 245)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(74, 26)
        Me.lblAlamat.TabIndex = 4
        Me.lblAlamat.Text = "Alamat"
        '
        'lblTanggalLahir
        '
        Me.lblTanggalLahir.AutoSize = True
        Me.lblTanggalLahir.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggalLahir.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTanggalLahir.Location = New System.Drawing.Point(296, 98)
        Me.lblTanggalLahir.Name = "lblTanggalLahir"
        Me.lblTanggalLahir.Size = New System.Drawing.Size(128, 26)
        Me.lblTanggalLahir.TabIndex = 5
        Me.lblTanggalLahir.Text = "Tanggal Lahir"
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.BackColor = System.Drawing.Color.Transparent
        Me.lblJenisKelamin.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisKelamin.Location = New System.Drawing.Point(296, 137)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(128, 26)
        Me.lblJenisKelamin.TabIndex = 6
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'lblHobi
        '
        Me.lblHobi.AutoSize = True
        Me.lblHobi.BackColor = System.Drawing.Color.Transparent
        Me.lblHobi.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHobi.Location = New System.Drawing.Point(297, 280)
        Me.lblHobi.Name = "lblHobi"
        Me.lblHobi.Size = New System.Drawing.Size(54, 26)
        Me.lblHobi.TabIndex = 7
        Me.lblHobi.Text = "Hobi"
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.LightGreen
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(699, 383)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(95, 27)
        Me.btnKembali.TabIndex = 8
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'lblNama
        '
        Me.lblNama.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(295, 67)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 26)
        Me.lblNama.TabIndex = 9
        Me.lblNama.Text = "Nama"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(806, 431)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.lblHobi)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.lblTanggalLahir)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.PictureBoxHasil)
        Me.Name = "Form2"
        Me.Text = "Form3"
        CType(Me.PictureBoxHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxHasil As PictureBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents lblNama As Label
End Class
