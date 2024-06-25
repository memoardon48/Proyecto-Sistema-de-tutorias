Imports System.Data.SqlClient

Public Class Clases
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Clase WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvClases.DataSource = mostrar2
        conectar.Close()
    End Sub

    Private Sub Clases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtNombre.Text = String.Empty) Then
            MessageBox.Show("Rellene el campo del nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombre.Focus()
        Else
            conectar.Open()
            Dim insertar As String = "INSERT INTO Clase(nombreClase, estado) VALUES(@nombreClase,'habilitado')"
            Dim insertar2 As New SqlCommand(insertar, conectar)
            insertar2.Parameters.AddWithValue("@nombreClase", txtNombre.Text)
            insertar2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()


            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvClases.Rows.Count
            codigo = dgvClases.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Clase', 'Clases', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar. Clase: " & txtNombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()
            txtNombre.Clear()

        End If




    End Sub

    Private Sub btnhabilitar_Click(sender As Object, e As EventArgs) Handles btnhabilitar.Click
        If (txtNombre.Text = String.Empty Or txtCodClase.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim update As String = "UPDATE Clase SET estado = 'habilitado' WHERE codClase = @codClase"
            Dim update2 As New SqlCommand(update, conectar)
            update2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
            update2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Clase', 'Clases', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Habilitar. Clase: " & txtNombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtCodClase.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()



            cargarDatos()
            btnAgregar.Enabled = True
            txtNombre.Clear()
            txtCodClase.Clear()

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtNombre.Text = String.Empty Or txtCodClase.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim update As String = "UPDATE Clase SET nombreClase = @nombreClase  WHERE codClase = @codClase"
            Dim update2 As New SqlCommand(update, conectar)
            update2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
            update2.Parameters.AddWithValue("@nombreClase", txtNombre.Text)
            update2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Clase', 'Clases', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar. Clase: " & txtNombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtCodClase.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()
            btnAgregar.Enabled = True
            txtNombre.Clear()
            txtCodClase.Clear()

        End If

    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        If (txtNombre.Text = String.Empty Or txtCodClase.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim update As String = "UPDATE Clase SET estado = 'deshabilitado' WHERE codClase = @codClase"
            Dim update2 As New SqlCommand(update, conectar)
            update2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
            update2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Clase', 'Clases', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Deshabilitar. Clase: " & txtNombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtCodClase.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()
            btnAgregar.Enabled = True
            txtNombre.Clear()
            txtCodClase.Clear()

        End If
    End Sub

    Private Sub dgvClases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClases.CellContentClick

    End Sub

    Private Sub dgvClases_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClases.CellDoubleClick
        btnAgregar.Enabled = False
        txtCodClase.Text = dgvClases.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvClases.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnMostrarTods_Click(sender As Object, e As EventArgs) Handles btnMostrarTods.Click
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Clase"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvClases.DataSource = mostrar2
        conectar.Close()
    End Sub

    Private Sub btnmostrarhabilitados_Click(sender As Object, e As EventArgs) Handles btnmostrarhabilitados.Click
        cargarDatos()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If (txtBuscar.Text = String.Empty) Then
            MessageBox.Show("Rellene el campo para buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBuscar.Focus()
        Else
            If (validarNumero(txtBuscar.Text)) Then
                conectar.Open()
                Dim mostrar As String = "SELECT * FROM Clase WHERE codClase = " & txtBuscar.Text
                Dim mostrar2 As New DataTable

                Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                    ejecutar.Fill(mostrar2)
                End Using

                If (mostrar2.Rows.Count < 1) Then
                    MessageBox.Show("No se encontró la clase que busca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBuscar.Clear()

                Else
                    dgvClases.DataSource = mostrar2
                    txtBuscar.Clear()
                End If
            Else
                MessageBox.Show("Ingrese un código válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        conectar.Close()



    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
    Function validarNumero(ByVal numero As String)
        Try
            Dim convertido As Integer
            convertido = Convert.ToInt32(numero)
            If (convertido >= 0) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
End Class