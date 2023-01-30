<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crud
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(crud))
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.buscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mostrar = New System.Windows.Forms.Button()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(152, 168)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 0
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(152, 245)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(152, 334)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(152, 402)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(100, 20)
        Me.txt_edad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 26)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 474)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 26)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "telefono"
        '
        'insertar
        '
        Me.insertar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.insertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.insertar.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertar.Location = New System.Drawing.Point(540, 195)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(116, 49)
        Me.insertar.TabIndex = 10
        Me.insertar.Text = "insertar"
        Me.insertar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(728, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 49)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(728, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 49)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "actualizar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buscar.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(333, 162)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(116, 49)
        Me.buscar.TabIndex = 13
        Me.buscar.Text = "buscar"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(333, 295)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(530, 220)
        Me.DataGridView1.TabIndex = 14
        '
        'mostrar
        '
        Me.mostrar.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.mostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mostrar.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mostrar.Location = New System.Drawing.Point(333, 226)
        Me.mostrar.Name = "mostrar"
        Me.mostrar.Size = New System.Drawing.Size(116, 49)
        Me.mostrar.TabIndex = 16
        Me.mostrar.Text = "mostrar"
        Me.mostrar.UseVisualStyleBackColor = False
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(152, 480)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(100, 20)
        Me.telefono.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(889, 134)
        Me.Panel1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(251, -9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(530, 87)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "CLANDESTINO"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(306, 44)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "¡AHI QUE QUEDE!"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(822, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(67, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-5, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(67, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'crud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 527)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.mostrar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.buscar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.insertar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Name = "crud"
        Me.Text = "crud"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_edad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents insertar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents buscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mostrar As Button
    Friend WithEvents telefono As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
