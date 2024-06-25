Imports System.Data.SqlClient
Public Class tutor
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Tutor WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvtutor.DataSource = mostrar2
        conectar.Close()
    End Sub
    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If (txtnombre.Text = String.Empty Or txtapellido.Text = String.Empty Or txtcelular.Text = String.Empty Or txtcorreo.Text = String.Empty Or txtCuenta.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim agregar As String = "INSERT INTO Tutor (nombre,apellido,email,edad,celular,universidad,carrera,cuenta,banco,estado,fechaAgregado)  VALUES(@nombre,@apellido,@email,@edad,@celular,@universidad,@carrera,@cuenta,@banco,'habilitado', GETDATE())"
            Dim agregar2 As New SqlCommand(agregar, conectar)
            agregar2.Parameters.AddWithValue("@nombre", txtnombre.Text)
            agregar2.Parameters.AddWithValue("@apellido", txtapellido.Text)
            agregar2.Parameters.AddWithValue("@email", txtcorreo.Text)
            agregar2.Parameters.AddWithValue("@edad", nudEdad.Text)
            agregar2.Parameters.AddWithValue("@celular", txtcelular.Text)
            agregar2.Parameters.AddWithValue("@universidad", cmbUniversidad.Text)
            agregar2.Parameters.AddWithValue("@carrera", cboCarrera.Text)
            agregar2.Parameters.AddWithValue("@cuenta", txtCuenta.Text)
            agregar2.Parameters.AddWithValue("@banco", cmbBanco.Text)
            agregar2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()

            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvtutor.Rows.Count
            codigo = dgvtutor.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutor', 'Tutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar. Tutor: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()

            txtapellido.Clear()
            txtnombre.Clear()
            txtcorreo.Clear()
            nudEdad.Value = 16
            txtcelular.Clear()
            cboCarrera.SelectedIndex = 0
            txtCuenta.Clear()
        End If

    End Sub

    Private Sub tutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUniversidad.SelectedItem = "UNICAH"
        cmbBanco.SelectedItem = "BAC"
        cboCarrera.SelectedIndex = 0

        cargarDatos()


    End Sub

    Private Sub btnhabilitar_Click(sender As Object, e As EventArgs) Handles btnhabilitar.Click
        If (txtcodtutor.Text = String.Empty) Then
            MessageBox.Show("Ingrese el valor para el campo del código del tutor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim habilitar As String = "UPDATE Tutor SET estado = 'habilitado' WHERE codTutor = @codTutor"
            Dim habilitar2 As New SqlCommand(habilitar, conectar)
            habilitar2.Parameters.AddWithValue("@codTutor", txtcodtutor.Text)
            habilitar2.ExecuteNonQuery()


            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutor', 'Tutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Habilitar. Tutor: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtcodtutor.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            txtapellido.Clear()
            txtnombre.Clear()
            txtcorreo.Clear()
            nudEdad.Value = 16
            txtcelular.Clear()
            cboCarrera.SelectedIndex = 0
            txtCuenta.Clear()
            btnagregar.Enabled = True

        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If (txtcodtutor.Text = String.Empty Or txtnombre.Text = String.Empty Or txtapellido.Text = String.Empty Or txtcelular.Text = String.Empty Or txtcorreo.Text = String.Empty Or txtCuenta.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim modificar As String = "UPDATE Tutor SET nombre=@nombre, apellido = @apellido,email = @email,edad = @edad,celular = @celular,universidad = @universidad,carrera = @carrera,cuenta = @cuenta,banco = @banco WHERE codTutor = @codTutor"
            Dim modificar2 As New SqlCommand(modificar, conectar)
            modificar2.Parameters.AddWithValue("@nombre", txtnombre.Text)
            modificar2.Parameters.AddWithValue("@apellido", txtapellido.Text)
            modificar2.Parameters.AddWithValue("@email", txtcorreo.Text)
            modificar2.Parameters.AddWithValue("@edad", nudEdad.Text)
            modificar2.Parameters.AddWithValue("@celular", txtcelular.Text)
            modificar2.Parameters.AddWithValue("@universidad", cmbUniversidad.Text)
            modificar2.Parameters.AddWithValue("@carrera", cboCarrera.Text)
            modificar2.Parameters.AddWithValue("@cuenta", txtCuenta.Text)
            modificar2.Parameters.AddWithValue("@banco", cmbBanco.Text)
            modificar2.Parameters.AddWithValue("@codTutor", txtcodtutor.Text)
            modificar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutor', 'Tutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar. Tutor: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtcodtutor.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()


            txtapellido.Clear()
            txtnombre.Clear()
            txtcorreo.Clear()
            nudEdad.Value = 16
            txtcelular.Clear()
            cboCarrera.SelectedIndex = 0
            txtCuenta.Clear()
            btnagregar.Enabled = True
        End If
    End Sub

    Private Sub btndeshabilitar_Click(sender As Object, e As EventArgs) Handles btndeshabilitar.Click
        If (txtcodtutor.Text = String.Empty) Then
            MessageBox.Show("Ingrese el valor para el campo del código del tutor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim habilitar As String = "UPDATE Tutor SET estado = 'deshabilitado' WHERE codTutor = @codTutor"
            Dim habilitar2 As New SqlCommand(habilitar, conectar)
            habilitar2.Parameters.AddWithValue("@codTutor", txtcodtutor.Text)
            habilitar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutor', 'Tutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Deshabilitar. Tutor: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtcodtutor.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            txtapellido.Clear()
            txtnombre.Clear()
            txtcorreo.Clear()
            nudEdad.Value = 16
            txtcelular.Clear()
            cboCarrera.SelectedIndex = 0
            txtCuenta.Clear()
            btnagregar.Enabled = True
        End If

    End Sub

    Private Sub btnmostrartod_Click(sender As Object, e As EventArgs) Handles btnmostrartod.Click
        conectar.Open()

        Dim mostrar As String = "SELECT * FROM Tutor"
        Dim recuperar As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(recuperar)
        End Using

        dgvtutor.DataSource = recuperar
        conectar.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscartu.Click
        If (txtBuscar.Text = String.Empty) Then
            MessageBox.Show("Ingrese el valor en el campo de buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (validarNumero(txtBuscar.Text)) Then
                conectar.Open()
                Dim codTutor As String
                codTutor = txtBuscar.Text

                Dim mostrar As String = "SELECT * FROM Tutor WHERE codTutor = " & codTutor
                Dim recuperar As New DataTable

                Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                    ejecutar.Fill(recuperar)
                End Using

                If (recuperar.Rows.Count = 0) Then
                    MessageBox.Show("El Tutor que busca no está registrado", "NO SE ENCUENTRA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                dgvtutor.DataSource = recuperar
                conectar.Close()
            Else
                MessageBox.Show("Ingrese un código válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtBuscar.Clear()
        End If
    End Sub

    Private Sub btnmostrarhabilitados_Click(sender As Object, e As EventArgs) Handles btnmostrarhabilitados.Click

        cargarDatos()

    End Sub

    Private Sub dgvtutor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtutor.CellContentClick

    End Sub

    Private Sub dgvtutor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtutor.CellDoubleClick
        txtcodtutor.Text = dgvtutor.CurrentRow.Cells(0).Value
        txtnombre.Text = dgvtutor.CurrentRow.Cells(1).Value
        txtapellido.Text = dgvtutor.CurrentRow.Cells(2).Value
        txtcorreo.Text = dgvtutor.CurrentRow.Cells(3).Value
        nudEdad.Value = dgvtutor.CurrentRow.Cells(4).Value
        txtcelular.Text = dgvtutor.CurrentRow.Cells(5).Value
        cmbUniversidad.Text = dgvtutor.CurrentRow.Cells(6).Value
        cboCarrera.SelectedItem = dgvtutor.CurrentRow.Cells(7).Value
        txtCuenta.Text = dgvtutor.CurrentRow.Cells(9).Value
        cmbBanco.Text = dgvtutor.CurrentRow.Cells(10).Value
        btnagregar.Enabled = False

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmReportTutor.Show()

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