Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class crud
    'conexion'
    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String
    'ejecutar sql'
    Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'boton insertar'
    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        sentencia = "insert datos values(" + txt_id.Text + ",'" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_edad.Text + "','" + telefono.Text + "')"
        mensaje = "Datos ingresados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from datos ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'boton de eliminar'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sentencia = "delete datos where id= " + txt_id.Text + ""
        mensaje = "Datos eliminados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from datos ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'boton mostrar'
    Private Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click
        Dim da As New SqlDataAdapter("select *from datos ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    ' boton buscar'
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim da As New SqlDataAdapter("select *from datos where nombre = '" + txt_nombre.Text + "' ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f2 = Form2
        f2.Close()
        Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    'boton actualizar'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sentencia = "update datos set nombre = '" + txt_nombre.Text + "',apellido = '" + txt_apellido.Text + "',edad = '" + txt_edad.Text + "',telefono= '" + telefono.Text + "' where id = " + txt_id.Text + ""
        mensaje = "Datos actualizados"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *from datos ", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class