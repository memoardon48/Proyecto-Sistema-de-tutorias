Imports System.Data.SqlClient
Public Class ClasesTutor
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT CT.codClase, C.nombreClase, CT.codTutor, T.nombre, CT.estado FROM ClaseTutor CT INNER JOIN Tutor T ON CT.codTutor = T.codTutor INNER JOIN Clase C ON CT.codClase = C.codClase WHERE CT.estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvClasesTuto.DataSource = mostrar2
        conectar.Close()


    End Sub

    Private Sub ClasesTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtCodClase.Text = String.Empty Or txtCodigoT.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim agregar As String = "INSERT INTO ClaseTutor (codClase,codTutor,estado)  VALUES(@codclase,@codtutor,'habilitado')"
            Dim agregar2 As New SqlCommand(agregar, conectar)

            agregar2.Parameters.AddWithValue("@codclase", txtCodClase.Text)
            agregar2.Parameters.AddWithValue("@codtutor", txtCodigoT.Text)
            agregar2.ExecuteNonQuery()
            conectar.Close()

            cargarDatos()


            conectar.Open()
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'ClaseTutor', 'ClasesTutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Asignar Clase(Código: " & txtCodClase.Text & ") a Tutor")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodigoT.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()

            txtCodClase.Clear()
            txtCodigoT.Clear()

        End If

    End Sub

    Private Sub btnhabilitar_Click(sender As Object, e As EventArgs) Handles btnhabilitar.Click
        If (txtCodigoT.Text = String.Empty Or txtCodClase.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim habilitarC As String = "UPDATE ClaseTutor SET estado = 'habilitado' WHERE codTutor = @codTutor AND codClase = @codClase"
            Dim hablilitarC2 As New SqlCommand(habilitarC, conectar)
            hablilitarC2.Parameters.AddWithValue("@codTutor", txtCodigoT.Text)
            hablilitarC2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
            hablilitarC2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'ClaseTutor', 'ClasesTutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Habilitar Clase(Código: " & txtCodClase.Text & ") a Tutor")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodigoT.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()

            txtCodClase.Clear()
            txtCodigoT.Clear()
            btnAgregar.Enabled = True

        End If

    End Sub


    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        If (txtCodigoT.Text = String.Empty Or txtCodClase.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim habilitarC As String = "UPDATE ClaseTutor SET estado = 'deshabilitado' WHERE codTutor = @codTutor AND codClase = @codClase"
            Dim hablilitarC2 As New SqlCommand(habilitarC, conectar)
            hablilitarC2.Parameters.AddWithValue("@codTutor", txtCodigoT.Text)
            hablilitarC2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
            hablilitarC2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'ClaseTutor', 'ClasesTutor', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Deshabilitar Clase(Código: " & txtCodClase.Text & ") a Tutor")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodigoT.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()

            txtCodClase.Clear()
            txtCodigoT.Clear()
            btnAgregar.Enabled = True

        End If

    End Sub

    Private Sub btnMostrarTods_Click(sender As Object, e As EventArgs) Handles btnMostrarTods.Click

        conectar.Open()

        Dim mostrarC As String = "SELECT CT.codClase, C.nombreClase, CT.codTutor, T.nombre, CT.estado FROM ClaseTutor CT INNER JOIN Tutor T ON CT.codTutor = T.codTutor INNER JOIN Clase C ON CT.codClase = C.codClase"
        Dim cargarC As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrarC, conectar)
            ejecutar.Fill(cargarC)
        End Using

        dgvClasesTuto.DataSource = cargarC
        conectar.Close()


    End Sub

    Private Sub btnmostrarhabilitados_Click(sender As Object, e As EventArgs) Handles btnmostrarhabilitados.Click

        cargarDatos()


    End Sub

    Private Sub dgvClasesTuto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasesTuto.CellContentClick


    End Sub

    Private Sub btnBuscarTutor_Click(sender As Object, e As EventArgs) Handles btnBuscarTutor.Click
        FrmBuscarTutor.Show()
    End Sub

    Private Sub btnBuscarClase_Click(sender As Object, e As EventArgs) Handles btnBuscarClase.Click
        FrmBuscarClase.Show()
    End Sub

    Private Sub dgvClasesTuto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasesTuto.CellDoubleClick
        txtCodClase.Text = dgvClasesTuto.CurrentRow.Cells(0).Value
        txtCodigoT.Text = dgvClasesTuto.CurrentRow.Cells(2).Value
        btnAgregar.Enabled = False
    End Sub
End Class