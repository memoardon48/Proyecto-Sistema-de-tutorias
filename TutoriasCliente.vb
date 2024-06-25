Imports System.Data.SqlClient

Public Class TutoriasCliente

    Sub cargarEsperaRecha()
        conectar.Open()
        Dim cargar As String = "SELECT T.codTutoria, T.codCliente, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , T.codClase, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado, T.pagadaCliente, T.pagadaTutor  FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase  INNER JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.estado = 'en espera' OR T.estado = 'rechazada'"
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using

        dgvEsperayRecha.DataSource = cargar2

        conectar.Close()
    End Sub

    Sub BuscarCodFac()
        conectar.Open()
        Dim cargar As String = "SELECT TOP(1) codFactura FROM Factura ORDER BY codFactura DESC"
        Dim cargar2 As SqlDataReader

        Dim ejecutar As New SqlCommand(cargar, conectar)
        cargar2 = ejecutar.ExecuteReader()
        If (cargar2.Read = False) Then
            txtCodFactura.Text = 1
        Else
            txtCodFactura.Text = cargar2(0) + 1
        End If
        conectar.Close()
    End Sub

    Sub cargarConf()
        conectar.Open()
        Dim cargar As String = " SELECT T.codTutoria, T.codCliente, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , T.codTutor, (TT.nombre + ' ' + TT.apellido) AS nombreTutor, T.codClase, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado, T.pagadaCliente, T.pagadaTutor  FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase INNER JOIN Tutor TT ON T.codTutor = TT.codTutor INNER JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.estado = 'confirmada' and T.pagadaCliente = 'NO'"
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using
        conectar.Close()
        dgvConf.DataSource = cargar2
    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (txtCodCliente.Text = String.Empty Or txtNombreCliente.Text = String.Empty Or txtNombreClase.Text = String.Empty Or txtCodClase.Text = String.Empty Or txtTemas.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores en cada uno de los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim agregar As String = "INSERT INTO Tutoria(codCliente, codClase, temas, fecha, tipo, horas, personas, conocimientoCliente, estado, pagadaCliente, pagadaTutor) VALUES(@codCliente, @codClase, @temas, @fecha, @tipo, @horas, @personas, @conocimientoCliente, 'en espera', 'NO', 'NO')"
            Dim agregar2 As New SqlCommand(agregar, conectar)
            agregar2.Parameters.AddWithValue("@codCliente", txtCodCliente.Text)
            agregar2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
            agregar2.Parameters.AddWithValue("@temas", txtTemas.Text)
            agregar2.Parameters.AddWithValue("@fecha", dtpFechaTuto.Value)
            agregar2.Parameters.AddWithValue("@tipo", cboTipo.Text)
            agregar2.Parameters.AddWithValue("@horas", nudHoras.Value)
            agregar2.Parameters.AddWithValue("@personas", nudPersonas.Value)
            agregar2.Parameters.AddWithValue("@conocimientoCliente", cboConocimiento.Text)

            agregar2.ExecuteNonQuery()
            conectar.Close()
            cargarEsperaRecha()
            conectar.Open()
            Dim codigo As String
            Dim filas As Integer
            filas = dgvEsperayRecha.Rows.Count
            codigo = dgvEsperayRecha.Rows(filas - 1).Cells(0).Value
            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutoria', 'TutoriasCliente', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar.  Tutoría de : " & txtNombreCliente.Text & ")")
            audi2.Parameters.AddWithValue("@codRegistro", codigo)
            audi2.ExecuteNonQuery()
            conectar.Close()

            txtCodTutoria.Clear()
            txtCodCliente.Clear()
            txtNombreCliente.Clear()
            txtCodClase.Clear()
            txtNombreClase.Clear()
            txtTemas.Clear()
            cboTipo.SelectedIndex = 0
            nudHoras.Value = 1
            nudPersonas.Value = 1
            cboConocimiento.SelectedIndex = 0

        End If



    End Sub

    Private Sub TutoriasCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEsperaRecha()
        cargarConf()
        BuscarCodFac()
        dtpFechaTuto.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        dtpFechaTuto.Format = DateTimePickerFormat.Custom
        cboConocimiento.SelectedIndex = 0
        cboTipo.SelectedIndex = 0

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        FrmBuscarCliente.Show()

    End Sub

    Private Sub btnBuscarClase_Click(sender As Object, e As EventArgs) Handles btnBuscarClase.Click
        FrmBuscarClase.Show()

    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If (cboTipo.SelectedIndex = 0) Then
            nudPersonas.Enabled = False
        Else
            nudPersonas.Enabled = True
        End If

    End Sub

    Private Sub DgvTutorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEsperayRecha.CellContentClick

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (txtCodTutoria.Text = String.Empty Or txtCodCliente.Text = String.Empty Or txtCodClase.Text = String.Empty Or txtTemas.Text = String.Empty) Then
            MessageBox.Show("Ingrese valores para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (dgvEsperayRecha.CurrentRow.Cells(10).Value = "rechazada") Then
                MessageBox.Show("No puede modificar una tutoria rechazada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                conectar.Open()
                Dim editar As String = "UPDATE Tutoria SET codCliente = @codCliente, codClase = @codClase, temas = @temas, fecha = @fecha, tipo = @tipo, horas = @horas, personas = @personas, conocimientoCliente = @conocimientoCliente WHERE codTutoria = @codTutoria "
                Dim editar2 As New SqlCommand(editar, conectar)
                editar2.Parameters.AddWithValue("@codCliente", txtCodCliente.Text)
                editar2.Parameters.AddWithValue("@codClase", txtCodClase.Text)
                editar2.Parameters.AddWithValue("@temas", txtTemas.Text)
                editar2.Parameters.AddWithValue("@fecha", dtpFechaTuto.Value)
                editar2.Parameters.AddWithValue("@tipo", cboTipo.Text)
                editar2.Parameters.AddWithValue("@horas", nudHoras.Value)
                editar2.Parameters.AddWithValue("@personas", nudPersonas.Value)
                editar2.Parameters.AddWithValue("@conocimientoCliente", cboConocimiento.Text)
                editar2.Parameters.AddWithValue("@codTutoria", txtCodTutoria.Text)
                editar2.ExecuteNonQuery()

                Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Tutoria', 'TutoriasCliente', @codRegistro, GETDATE())"
                Dim audi2 As New SqlCommand(audi, conectar)
                audi2.Parameters.AddWithValue("@userName", user)
                audi2.Parameters.AddWithValue("@accion", "Modificar.  Tutoría de : " & txtNombreCliente.Text & ")")
                audi2.Parameters.AddWithValue("@codRegistro", txtCodTutoria.Text)
                audi2.ExecuteNonQuery()
                conectar.Close()
                cargarEsperaRecha()

                txtCodTutoria.Clear()
                txtCodCliente.Clear()
                txtNombreCliente.Clear()
                txtCodClase.Clear()
                txtNombreClase.Clear()
                txtTemas.Clear()
                cboTipo.SelectedIndex = 0
                nudHoras.Value = 1
                nudPersonas.Value = 1
                cboConocimiento.SelectedIndex = 0
            End If
        End If


    End Sub

    Private Sub dgvEsperayRecha_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEsperayRecha.CellDoubleClick

        txtCodTutoria.Text = dgvEsperayRecha.CurrentRow.Cells(0).Value
        txtCodCliente.Text = dgvEsperayRecha.CurrentRow.Cells(1).Value
        txtCodClase.Text = dgvEsperayRecha.CurrentRow.Cells(3).Value
        txtTemas.Text = dgvEsperayRecha.CurrentRow.Cells(5).Value
        dtpFechaTuto.Value = dgvEsperayRecha.CurrentRow.Cells(6).Value
        cboTipo.SelectedItem = dgvEsperayRecha.CurrentRow.Cells(7).Value
        nudHoras.Value = dgvEsperayRecha.CurrentRow.Cells(8).Value
        nudPersonas.Value = dgvEsperayRecha.CurrentRow.Cells(9).Value
        cboConocimiento.SelectedItem = dgvEsperayRecha.CurrentRow.Cells(10).Value
        btnAgregar.Enabled = False
    End Sub

    Private Sub dgvConf_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConf.CellContentClick

    End Sub

    Private Sub dgvConf_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConf.CellDoubleClick
        txtCodTutoria2.Text = dgvConf.CurrentRow.Cells(0).Value
        If (dgvConf.CurrentRow.Cells(9).Value = "Grupal") Then
            txtTotal.Text = 160 * dgvConf.CurrentRow.Cells(11).Value * dgvConf.CurrentRow.Cells(10).Value
        Else
            txtTotal.Text = 180 * dgvConf.CurrentRow.Cells(10).Value
        End If


    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If (txtCodTutoria2.Text = String.Empty Or txtTotal.Text = String.Empty) Then
            MessageBox.Show("Ingrese un valor para cada campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            conectar.Open()
            Dim insertar As String = "INSERT INTO Factura(codFactura, codTutoria,Total,fecha) VALUES(@codFactura, @codTutoria,@Total,GETDATE())"
            Dim insertar2 As New SqlCommand(insertar, conectar)
            insertar2.Parameters.AddWithValue("@codFactura", txtCodFactura.Text)
            insertar2.Parameters.AddWithValue("@codTutoria", txtCodTutoria2.Text)
            insertar2.Parameters.AddWithValue("@Total", txtTotal.Text)
            insertar2.ExecuteNonQuery()

            Dim actualizar As String = "UPDATE Tutoria SET pagadaCliente  = 'SI' WHERE codTutoria = @codTutoria"
            Dim actualizar2 As New SqlCommand(actualizar, conectar)
            actualizar2.Parameters.AddWithValue("@codTutoria", txtCodTutoria2.Text)
            actualizar2.ExecuteNonQuery()

            Dim audi As String = "INSERT INTO Auditoria(userName, accion, tabla, formulario, codRegistro, fecha) VALUES(@userName, @accion, 'Factura', 'TutoriasCliente', @codRegistro, GETDATE())"
            Dim audi2 As New SqlCommand(audi, conectar)
            audi2.Parameters.AddWithValue("@userName", user)
            audi2.Parameters.AddWithValue("@accion", "Insertar Pago de Tutoría (" & txtTotal.Text & ")")
            audi2.Parameters.AddWithValue("@codRegistro", txtCodTutoria2.Text)
            audi2.ExecuteNonQuery()
            conectar.Close()
            ReporteFactura.Show()

            BuscarCodFac()
            txtCodTutoria2.Clear()
            txtCodFactura.Clear()
            txtTotal.Clear()
            cargarConf()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmReporteTutorias.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarEspera.Click
        If (txtBuscarEspera.Text = String.Empty) Then
            MessageBox.Show("Ingrese el valor en el campo de buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (validarNumero(txtBuscarEspera.Text)) Then
                Dim codTutoria As String
                codTutoria = txtBuscarEspera.Text

                Dim mostrar As String = "SELECT * FROM Tutoria WHERE codTutoria = " & codTutoria & " AND estado = 'rechazada' OR estado = 'en espera'"
                Dim recuperar As New DataTable

                Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                    ejecutar.Fill(recuperar)
                End Using

                If (recuperar.Rows.Count = 0) Then
                    MessageBox.Show("La tutoría que busca no está registrada", "NO SE ENCUENTRA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    dgvEsperayRecha.DataSource = recuperar
                End If

                conectar.Close()
                txtBuscarEspera.Clear()
            Else
                MessageBox.Show("Ingrese un código válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtBuscarEspera.Clear()
        End If
    End Sub

    Private Sub btnBuscarConf_Click(sender As Object, e As EventArgs) Handles btnBuscarConf.Click
        If (txtBuscarConf.Text = String.Empty) Then
            MessageBox.Show("Ingrese el valor en el campo de buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (validarNumero(txtBuscarConf.Text)) Then
                Dim codTutoria As String
                codTutoria = txtBuscarConf.Text

                Dim mostrar As String = "SELECT * FROM Tutoria WHERE codTutoria = " & codTutoria & " AND estado = 'confirmada' AND pagadaCliente = 'NO' "
                Dim recuperar As New DataTable

                Using ejecutar As New SqlDataAdapter(mostrar, conectar)
                    ejecutar.Fill(recuperar)
                End Using

                If (recuperar.Rows.Count = 0) Then
                    MessageBox.Show("La tutoría que busca no está registrado", "NO SE ENCUENTRA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    dgvConf.DataSource = recuperar
                End If

                conectar.Close()
                txtBuscarConf.Clear()
            Else
                MessageBox.Show("Ingrese un código válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txtBuscarConf.Clear()
        End If
    End Sub

    Private Sub btnMostrarTod_Click(sender As Object, e As EventArgs) Handles btnMostrarTod.Click
        conectar.Open()
        Dim cargar As String = "SELECT T.codTutoria, T.codCliente, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , T.codTutor, T.codClase, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado, T.pagadaCliente, T.pagadaTutor  FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase INNER JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.estado = 'en espera' OR T.estado = 'rechazada'"
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using

        dgvEsperayRecha.DataSource = cargar2

        conectar.Close()
    End Sub

    Private Sub btnMostrarTodo2_Click(sender As Object, e As EventArgs) Handles btnMostrarTodo2.Click
        conectar.Open()
        Dim cargar As String = " SELECT T.codTutoria, T.codCliente, (CC.nombre + ' ' + CC.apellido) AS NombreCliente , T.codTutor, (TT.nombre + ' ' + TT.apellido) AS nombreTutor, T.codClase, C.nombreClase, T.temas, T.fecha,T.tipo,T.horas,T.personas, T.conocimientoCliente,T.estado, T.pagadaCliente, T.pagadaTutor  FROM Tutoria T INNER JOIN Clase C ON T.codClase = C.codClase INNER JOIN Tutor TT ON T.codTutor = TT.codTutor INNER JOIN Cliente CC ON T.codCliente = CC.codCliente WHERE T.estado = 'confirmada' and T.pagadaCliente = 'NO'"
        Dim cargar2 As New DataTable
        Using ejecutar As New SqlDataAdapter(cargar, conectar)
            ejecutar.Fill(cargar2)
        End Using
        conectar.Close()
        dgvConf.DataSource = cargar2
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