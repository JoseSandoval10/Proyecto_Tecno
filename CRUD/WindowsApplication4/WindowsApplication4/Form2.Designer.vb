<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.nombre_txt = New System.Windows.Forms.TextBox()
        Me.contraseño_txt = New System.Windows.Forms.TextBox()
        Me.INGRESAR = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nombre_txt
        '
        Me.nombre_txt.Location = New System.Drawing.Point(179, 138)
        Me.nombre_txt.Name = "nombre_txt"
        Me.nombre_txt.Size = New System.Drawing.Size(100, 20)
        Me.nombre_txt.TabIndex = 0
        '
        'contraseño_txt
        '
        Me.contraseño_txt.Location = New System.Drawing.Point(179, 202)
        Me.contraseño_txt.Name = "contraseño_txt"
        Me.contraseño_txt.Size = New System.Drawing.Size(100, 20)
        Me.contraseño_txt.TabIndex = 1
        Me.contraseño_txt.UseSystemPasswordChar = True
        '
        'INGRESAR
        '
        Me.INGRESAR.BackColor = System.Drawing.Color.LightGreen
        Me.INGRESAR.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INGRESAR.Location = New System.Drawing.Point(162, 248)
        Me.INGRESAR.Name = "INGRESAR"
        Me.INGRESAR.Size = New System.Drawing.Size(139, 44)
        Me.INGRESAR.TabIndex = 2
        Me.INGRESAR.Text = "INGRESAR"
        Me.INGRESAR.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 100)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(415, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 393)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.INGRESAR)
        Me.Controls.Add(Me.contraseño_txt)
        Me.Controls.Add(Me.nombre_txt)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nombre_txt As TextBox
    Friend WithEvents contraseño_txt As TextBox
    Friend WithEvents INGRESAR As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
