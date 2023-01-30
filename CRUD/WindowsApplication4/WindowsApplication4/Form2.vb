Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form2
    'CONEXION'
    Public conexion As SqlConnection = New SqlConnection(My.Settings.conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    'Funcion verificar'
    Function verificacion(ByVal sql)
        conexion.Open()
        cmd = New SqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles INGRESAR.Click
        'declaramos crud como variable para llamar los botones'
        Dim f2 = crud
        'Realizamos cada verificacion conforme al tipo'
        Dim verificar As String = "update login set rol=rol where nombre = '" + nombre_txt.Text + "' and contraseña = '" + contraseño_txt.Text + "' and rol = 'administrador'"

        Dim verificar1 As String = "update login set rol=rol where nombre = '" + nombre_txt.Text + "' and contraseña = '" + contraseño_txt.Text + "' and rol = 'cliente'"

        Dim verificar2 As String = "update login set rol=rol where nombre = '" + nombre_txt.Text + "' and contraseña = '" + contraseño_txt.Text + "' and rol = 'secretaria'"
        If verificacion(verificar) Then
            crud.Show()
            Me.Hide()
        ElseIf verificacion(verificar1) Then
            crud.Show()
            Me.Hide()
            f2.insertar.Visible = False
            f2.Button2.Visible = False
            f2.Button3.Visible = False
        ElseIf verificacion(verificar2) Then
            crud.Show()
            Me.Hide()
            f2.Button2.Visible = False
            f2.Button3.Visible = False
        Else
            MessageBox.Show("Error")
        End If
    End Sub
    'Cerramos el programa '
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
    End Sub
End Class