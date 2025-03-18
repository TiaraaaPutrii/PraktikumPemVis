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
        Me.TXTPANJANG = New System.Windows.Forms.TextBox()
        Me.TXTLEBAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonHITUNG = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTPANJANG
        '
        Me.TXTPANJANG.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTPANJANG.Location = New System.Drawing.Point(22, 117)
        Me.TXTPANJANG.Name = "TXTPANJANG"
        Me.TXTPANJANG.Size = New System.Drawing.Size(139, 20)
        Me.TXTPANJANG.TabIndex = 0
        '
        'TXTLEBAR
        '
        Me.TXTLEBAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTLEBAR.Location = New System.Drawing.Point(22, 178)
        Me.TXTLEBAR.Name = "TXTLEBAR"
        Me.TXTLEBAR.Size = New System.Drawing.Size(139, 20)
        Me.TXTLEBAR.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CALCULATOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lebar"
        '
        'ButtonHITUNG
        '
        Me.ButtonHITUNG.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonHITUNG.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHITUNG.ForeColor = System.Drawing.Color.Black
        Me.ButtonHITUNG.Location = New System.Drawing.Point(342, 138)
        Me.ButtonHITUNG.Name = "ButtonHITUNG"
        Me.ButtonHITUNG.Size = New System.Drawing.Size(93, 28)
        Me.ButtonHITUNG.TabIndex = 5
        Me.ButtonHITUNG.Text = "Hitung"
        Me.ButtonHITUNG.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(472, 261)
        Me.Controls.Add(Me.ButtonHITUNG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTLEBAR)
        Me.Controls.Add(Me.TXTPANJANG)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTPANJANG As System.Windows.Forms.TextBox
    Friend WithEvents TXTLEBAR As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonHITUNG As System.Windows.Forms.Button

End Class
