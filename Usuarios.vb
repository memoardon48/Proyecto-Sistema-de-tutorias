Imports System.Data.SqlClient
Public Class Usuarios
    Sub cargarDatos()
        conectar.Open()
        Dim mostrar As String = "SELECT * FROM Usuario WHERE estado = 'habilitado'"
        Dim mostrar2 As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(mostrar2)
        End Using

        dgvUsuarios.DataSource = mostrar2
        conectar.Close()
    End Sub


    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
        cboTipo.SelectedIndex = 0

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtPass.Text = String.Empty Or txtUsername.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim tipo As String
            Dim agregar As String = "INSERT INTO Usuario (username,pass,tipo,estado)  VALUES(@username,@pass,@tipo,'habilitado')"
            Dim agregar2 As New SqlCommand(agregar, conectar)
            agregar2.Parameters.AddWithValue("@username", txtUsername.Text)
            agregar2.Parameters.AddWithValue("@pass", txtPass.Text)
            If (cboTipo.SelectedIndex = 0) Then
                tipo = "1"
            ElseIf (cboTipo.SelectedIndex = 1) Then
                tipo = "2"
            ElseIf (cboTipo.SelectedIndex = 2) Then
                tipo = "3"
            ElseIf (cboTipo.SelectedIndex = 3) Then
                tipo = "4"
            ElseIf (cboTipo.SelectedIndex = 4) Then
                tipo = "5"
            End If
            agregar2.Parameters.AddWithValue("@tipo", tipo)
            agregar2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvUsuarios.Rows.Count
            codigo = dgvUsuarios.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Usuario', 'Usuarios', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar. Usuario: " & txtUsername.Text)
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()

            txtUsername.Clear()
            txtPass.Clear()

        End If


    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        If (txtCodUsuario.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()

            Dim habilitar As String = "UPDATE Usuario SET estado = 'habilitado' WHERE codUsuario = @codUsuario"
            Dim habilitar2 As New SqlCommand(habilitar, conectar)
            habilitar2.Parameters.AddWithValue("@codUsuario", txtCodUsuario.Text)
            habilitar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Usuario', 'Usuarios', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Habilitar. Usuario: " & txtUsername.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtCodUsuario.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()

            txtUsername.Clear()
            txtPass.Clear()
            btnAgregar.Enabled = True

        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtCodUsuario.Text = String.Empty Or txtUsername.Text = String.Empty Or txtPass.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim tipo As String

            Dim modificar As String = "UPDATE Usuario SET username=@username,pass=@pass,tipo=@tipo WHERE codUsuario = @codUsuario"
            Dim modificar2 As New SqlCommand(modificar, conectar)
            modificar2.Parameters.AddWithValue("@username", txtUsername.Text)
            modificar2.Parameters.AddWithValue("@pass", txtPass.Text)
            If (cboTipo.SelectedIndex = 0) Then
                tipo = "1"
            ElseIf (cboTipo.SelectedIndex = 1) Then
                tipo = "2"
            ElseIf (cboTipo.SelectedIndex = 2) Then
                tipo = "3"
            ElseIf (cboTipo.SelectedIndex = 3) Then
                tipo = "4"
            ElseIf (cboTipo.SelectedIndex = 4) Then
                tipo = "5"
            End If
            modificar2.Parameters.AddWithValue("@tipo", tipo)
            modificar2.Parameters.AddWithValue("@codUsuario", txtCodUsuario.Text)
            modificar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Usuario', 'Usuarios', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Modificar. Usuario: " & txtUsername.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtCodUsuario.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()


            txtUsername.Clear()
            txtPass.Clear()
            btnAgregar.Enabled = True

        End If
    End Sub

    Private Sub btnDeshabilitar_Click(sender As Object, e As EventArgs) Handles btnDeshabilitar.Click
        If (txtCodUsuario.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            conectar.Open()

            Dim habilitar As String = "UPDATE Usuario SET estado = 'deshabilitado' WHERE codUsuario = @codUsuario"
            Dim habilitar2 As New SqlCommand(habilitar, conectar)
            habilitar2.Parameters.AddWithValue("@codUsuario", txtCodUsuario.Text)
            habilitar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Usuario', 'Usuarios', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Deshabilitar. Usuario: " & txtUsername.Text)
            audi2.Parameters.AddWithValue("@codRegistro", txtCodUsuario.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            cargarDatos()
            txtUsername.Clear()
            txtPass.Clear()
            btnAgregar.Enabled = True

        End If
    End Sub

    Private Sub btnMostrarTod_Click(sender As Object, e As EventArgs) Handles btnMostrarTod.Click
        conectar.Open()

        Dim mostrar As String = "SELECT * FROM Usuario"
        Dim recuperar As New DataTable

        Using ejecutar As New SqlDataAdapter(mostrar, conectar)
            ejecutar.Fill(recuperar)
        End Using

        dgvUsuarios.DataSource = recuperar
        conectar.Close()
    End Sub

    Private Sub btnMostrarHabilitados_Click(sender As Object, e As EventArgs) Handles btnMostrarHabilitados.Click
        cargarDatos()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If (txtBuscar.Text = String.Empty) Then
            MessageBox.Show("Ingrese los valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If (validarNumero(txtBuscar.Text)) Then
                Dim codUsuario As String
                codUsuario = txtBuscar.Text

                Dim mostrar As String = "SELECT * FROM Usuario WHERE codUsuario = " & codUsuario
                Dim recuperar As New DataTable

                Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                    ejecutar.Fill(recuperar)
                End Using

                If (recuperar.Rows.Count = 0) Then
                    MessageBox.Show("El Usuario que busca no está registrado", "NO SE ENCUENTRA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                dgvUsuarios.DataSource = recuperar
                conectar.Close()
                txtBuscar.Clear()
            Else
                MessageBox.Show("Ingrese un valor correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        End If

    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        Dim tipo As String

        txtCodUsuario.Text = dgvUsuarios.CurrentRow.Cells(0).Value
        txtUsername.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        txtPass.Text = dgvUsuarios.CurrentRow.Cells(2).Value
        tipo = dgvUsuarios.CurrentRow.Cells(3).Value
        If (tipo = "1") Then
            cboTipo.SelectedIndex = "0"
        ElseIf (tipo = "2") Then
            cboTipo.SelectedIndex = "1"
        ElseIf (tipo = "3") Then
            cboTipo.SelectedIndex = "2"
        ElseIf (tipo = "4") Then
            cboTipo.SelectedIndex = "3"
        ElseIf (tipo = "5") Then
            cboTipo.SelectedIndex = "4"
        End If
        btnAgregar.Enabled = False
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