Imports System.Data.SqlClient

Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        conectar.Open()

        Dim consulta As String = "SELECT * FROM Usuario WHERE username = @usuario AND pass = @pass AND estado = 'habilitado'"
        Dim recuperar As SqlDataReader

        Dim ejecutar As New SqlCommand(consulta, conectar)
        ejecutar.Parameters.AddWithValue("@usuario", txtusuario.Text)
        ejecutar.Parameters.AddWithValue("@pass", txtcontra.Text)
        recuperar = ejecutar.ExecuteReader()

        If (recuperar.Read() = True) Then
            tipo = recuperar(3)
            user = recuperar(1)
            MenuA.Show()

        Else
            MessageBox.Show("Ingrese una clave y un usuario correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conectar.Close()
    End Sub
End Class
