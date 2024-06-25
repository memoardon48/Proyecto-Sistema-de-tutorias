Imports System.Data.SqlClient
Public Class Clientes
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Cliente WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvclientes.DataSource = mostrar2
        conectar.Close()


    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If (txtbuscarc.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para el campos de buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (validarNumero(txtbuscarc.Text)) Then
                conectar.Open()

                Dim cliente As String
                cliente = txtbuscarc.Text

                Dim mostrarC As String = "SELECT * FROM Cliente WHERE codcliente= " & cliente
                Dim cargarC As New DataTable

                Using ejecutar As New SqlDataAdapter(mostrarC, conectar)
                    ejecutar.Fill(cargarC)
                End Using

                If (cargarC.Rows.Count = 0) Then
                    MessageBox.Show("El estudiante que quiere encontrar no se encuentra", "NO SE ENCUENTRA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                dgvclientes.DataSource = cargarC
                conectar.Close()
                txtapellido.Clear()
                txtbuscarc.Clear()
                txtcelular.Clear()
                txtcodcliente.Clear()
                txtcorreo.Clear()
                txtnombre.Clear()
            Else
                MessageBox.Show("Ingrese un valor correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If


    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click

        If (txtnombre.Text = String.Empty Or txtapellido.Text = String.Empty Or txtcelular.Text = String.Empty Or txtcorreo.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim agregar As String = "INSERT INTO Cliente (nombre,apellido,email,edad,celular,universidad,estado)  VALUES(@nombre,@apellido,@email,@edad,@celular,@universidad,'habilitado')"
            Dim agregar2 As New SqlCommand(agregar, conectar)

            agregar2.Parameters.AddWithValue("@nombre", txtnombre.Text)
            agregar2.Parameters.AddWithValue("@apellido", txtapellido.Text)
            agregar2.Parameters.AddWithValue("@email", txtcorreo.Text)
            agregar2.Parameters.AddWithValue("@edad", nudedad.Value)
            agregar2.Parameters.AddWithValue("@celular", txtcelular.Text)
            agregar2.Parameters.AddWithValue("@universidad", cbuniversidad.Text)
            agregar2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()
            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvclientes.Rows.Count
            codigo = dgvclientes.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Cliente', 'Clientes', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar. Cliente: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()


            txtapellido.Clear()
            txtbuscarc.Clear()
            txtcelular.Clear()
            txtcodcliente.Clear()
            txtcorreo.Clear()
            txtnombre.Clear()

        End If
    End Sub

    Private Sub btnmhabilitados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()

        cbuniversidad.Items.Add("UNICAH")
        cbuniversidad.Items.Add("UNAH")
        cbuniversidad.Items.Add("UNITEC")
        cbuniversidad.Items.Add("CEUTEC")
        cbuniversidad.Items.Add("UTH")

        cbuniversidad.SelectedIndex = 0
    End Sub

    Private Sub btnmostrarhabilitados_Click(sender As Object, e As EventArgs) Handles btnmostrarhabilitados.Click

        cargarDatos()

    End Sub

    Private Sub btnhabilitar_Click(sender As Object, e As EventArgs) Handles btnhabilitar.Click
        If (txtcodcliente.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim habilitarC As String = "UPDATE Cliente SET estado = 'habilitado' WHERE codcliente = @codcliente"
            Dim hablilitarC2 As New SqlCommand(habilitarC, conectar)
            hablilitarC2.Parameters.AddWithValue("@codcliente", txtcodcliente.Text)
            hablilitarC2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Cliente', 'Clientes', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Habilitar. Cliente: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtcodcliente.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()

            txtapellido.Clear()
            txtbuscarc.Clear()
            txtcelular.Clear()
            txtcodcliente.Clear()
            txtcorreo.Clear()
            txtnombre.Clear()
            btnagregar.Enabled = True

        End If

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If (txtnombre.Text = String.Empty Or txtapellido.Text = String.Empty Or txtcelular.Text = String.Empty Or txtcorreo.Text = String.Empty Or txtcodcliente.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim modificarC As String = "UPDATE Cliente SET nombre = @nombre ,apellido = @apellido ,email = @email,edad = @edad,celular = @celular,universidad = @universidad WHERE codcliente = @codcliente"
            Dim modificarC2 As New SqlCommand(modificarC, conectar)
            modificarC2.Parameters.AddWithValue("@codcliente", txtcodcliente.Text)
            modificarC2.Parameters.AddWithValue("@nombre", txtnombre.Text)
            modificarC2.Parameters.AddWithValue("@apellido", txtapellido.Text)
            modificarC2.Parameters.AddWithValue("@email", txtcorreo.Text)
            modificarC2.Parameters.AddWithValue("@edad", nudedad.Value)
            modificarC2.Parameters.AddWithValue("@celular", txtcelular.Text)
            modificarC2.Parameters.AddWithValue("@universidad", cbuniversidad.Text)
            modificarC2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Cliente', 'Clientes', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar. Cliente: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtcodcliente.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()

            txtapellido.Clear()
            txtbuscarc.Clear()
            txtcelular.Clear()
            txtcodcliente.Clear()
            txtcorreo.Clear()
            txtnombre.Clear()
            btnagregar.Enabled = True
        End If
    End Sub

    Private Sub btndeshabilitar_Click(sender As Object, e As EventArgs) Handles btndeshabilitar.Click
        If (txtcodcliente.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()


            Dim habilitarC As String = "UPDATE Cliente SET estado = 'deshabilitado' WHERE codcliente = @codcliente"
            Dim hablilitarC2 As New SqlCommand(habilitarC, conectar)
            hablilitarC2.Parameters.AddWithValue("@codcliente", txtcodcliente.Text)
            hablilitarC2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Cliente', 'Clientes', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Deshabilitar. Cliente: " & txtnombre.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtcodcliente.Text)
            audi2.ExecuteNonQuery()

            conectar.Close()
            cargarDatos()


            txtapellido.Clear()
            txtbuscarc.Clear()
            txtcelular.Clear()
            txtcodcliente.Clear()
            txtcorreo.Clear()
            txtnombre.Clear()
            btnagregar.Enabled = True
        End If

    End Sub

    Private Sub btnmostrartod_Click(sender As Object, e As EventArgs) Handles btnmostrartod.Click

        conectar.Open()

        Dim mostrarC As String = "SELECT * FROM Cliente"
        Dim cargarC As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrarC, conectar)
            ejecutar.Fill(cargarC)
        End Using

        dgvclientes.DataSource = cargarC
        conectar.Close()


    End Sub

    Private Sub cbuniversidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbuniversidad.SelectedIndexChanged

    End Sub

    Private Sub dgvclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclientes.CellContentClick

    End Sub

    Private Sub dgvclientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclientes.CellDoubleClick
        txtcodcliente.Text = dgvclientes.CurrentRow.Cells(0).Value
        txtnombre.Text = dgvclientes.CurrentRow.Cells(1).Value
        txtapellido.Text = dgvclientes.CurrentRow.Cells(2).Value
        txtcorreo.Text = dgvclientes.CurrentRow.Cells(3).Value
        nudedad.Value = dgvclientes.CurrentRow.Cells(4).Value
        txtcelular.Text = dgvclientes.CurrentRow.Cells(5).Value
        cbuniversidad.Text = dgvclientes.CurrentRow.Cells(6).Value
        btnagregar.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmReporteClientes.Show()

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